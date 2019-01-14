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
        Me.GV = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
        Me.GridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.No_seq = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Kd_Stok = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.repStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.Tgl_Kirim_MarketingB = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.repTglKirim = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.Tgl_Kirim_Marketing = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand3 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.JanjiKirimAsli = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.tgl_kirim = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.GridBand4 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        Me.Alasan = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.MemoEdit1 = New DevExpress.XtraEditors.MemoEdit
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.tglKirimSP = New DevExpress.XtraEditors.DateEdit
        Me.tglKirimSPB = New System.Windows.Forms.TextBox
        Me.TglKirim = New DevExpress.XtraEditors.DateEdit
        Me.tglKirimA = New System.Windows.Forms.TextBox
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
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
        Me.Panel8.SuspendLayout()
        Me.Panel10.SuspendLayout()
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel9.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.tglKirimSP.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglKirimSP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TglKirim.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TglKirim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.pnl.Controls.Add(Me.Panel8)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(963, 402)
        Me.pnl.TabIndex = 0
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC.Location = New System.Drawing.Point(0, 103)
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repTglKirim, Me.repStok})
        Me.GC.Size = New System.Drawing.Size(963, 249)
        Me.GC.TabIndex = 4
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV})
        '
        'GV
        '
        Me.GV.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.GridBand1, Me.gridBand2, Me.GridBand3, Me.GridBand4})
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.No_seq, Me.Kd_Stok, Me.tgl_kirim, Me.Alasan, Me.JanjiKirimAsli, Me.Tgl_Kirim_MarketingB, Me.Tgl_Kirim_Marketing})
        Me.GV.GridControl = Me.GC
        Me.GV.Name = "GV"
        Me.GV.OptionsView.ColumnAutoWidth = True
        Me.GV.OptionsView.EnableAppearanceOddRow = True
        Me.GV.OptionsView.ShowGroupPanel = False
        '
        'GridBand1
        '
        Me.GridBand1.Caption = "Daftar Barang"
        Me.GridBand1.Columns.Add(Me.No_seq)
        Me.GridBand1.Columns.Add(Me.Kd_Stok)
        Me.GridBand1.Name = "GridBand1"
        Me.GridBand1.Width = 362
        '
        'No_seq
        '
        Me.No_seq.Caption = "No"
        Me.No_seq.FieldName = "No_seq"
        Me.No_seq.Name = "No_seq"
        Me.No_seq.OptionsColumn.AllowEdit = False
        Me.No_seq.OptionsColumn.AllowFocus = False
        Me.No_seq.Visible = True
        Me.No_seq.Width = 36
        '
        'Kd_Stok
        '
        Me.Kd_Stok.Caption = "Deskripsi"
        Me.Kd_Stok.ColumnEdit = Me.repStok
        Me.Kd_Stok.FieldName = "Kd_Stok"
        Me.Kd_Stok.Name = "Kd_Stok"
        Me.Kd_Stok.OptionsColumn.AllowEdit = False
        Me.Kd_Stok.OptionsColumn.AllowFocus = False
        Me.Kd_Stok.Visible = True
        Me.Kd_Stok.Width = 326
        '
        'repStok
        '
        Me.repStok.AutoHeight = False
        Me.repStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repStok.DisplayMember = "Nama_Barang"
        Me.repStok.Name = "repStok"
        Me.repStok.NullText = ""
        Me.repStok.ValueMember = "Kode_Barang"
        '
        'gridBand2
        '
        Me.gridBand2.AppearanceHeader.Options.UseTextOptions = True
        Me.gridBand2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridBand2.Caption = "Janji Kirim SP"
        Me.gridBand2.Columns.Add(Me.Tgl_Kirim_MarketingB)
        Me.gridBand2.Columns.Add(Me.Tgl_Kirim_Marketing)
        Me.gridBand2.Name = "gridBand2"
        Me.gridBand2.Visible = False
        Me.gridBand2.Width = 217
        '
        'Tgl_Kirim_MarketingB
        '
        Me.Tgl_Kirim_MarketingB.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Tgl_Kirim_MarketingB.AppearanceCell.Options.UseBackColor = True
        Me.Tgl_Kirim_MarketingB.Caption = "Lama"
        Me.Tgl_Kirim_MarketingB.ColumnEdit = Me.repTglKirim
        Me.Tgl_Kirim_MarketingB.FieldName = "Tgl_Kirim_Marketing"
        Me.Tgl_Kirim_MarketingB.Name = "Tgl_Kirim_MarketingB"
        Me.Tgl_Kirim_MarketingB.OptionsColumn.AllowEdit = False
        Me.Tgl_Kirim_MarketingB.OptionsColumn.AllowFocus = False
        Me.Tgl_Kirim_MarketingB.Visible = True
        Me.Tgl_Kirim_MarketingB.Width = 108
        '
        'repTglKirim
        '
        Me.repTglKirim.AutoHeight = False
        Me.repTglKirim.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repTglKirim.Name = "repTglKirim"
        Me.repTglKirim.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.repTglKirim.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'Tgl_Kirim_Marketing
        '
        Me.Tgl_Kirim_Marketing.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tgl_Kirim_Marketing.AppearanceCell.Options.UseFont = True
        Me.Tgl_Kirim_Marketing.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Tgl_Kirim_Marketing.AppearanceHeader.Options.UseFont = True
        Me.Tgl_Kirim_Marketing.Caption = "Baru"
        Me.Tgl_Kirim_Marketing.ColumnEdit = Me.repTglKirim
        Me.Tgl_Kirim_Marketing.FieldName = "tgl_kirimSPB"
        Me.Tgl_Kirim_Marketing.Name = "Tgl_Kirim_Marketing"
        Me.Tgl_Kirim_Marketing.Visible = True
        Me.Tgl_Kirim_Marketing.Width = 109
        '
        'GridBand3
        '
        Me.GridBand3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridBand3.Caption = "Janji Kirim PPIC"
        Me.GridBand3.Columns.Add(Me.JanjiKirimAsli)
        Me.GridBand3.Columns.Add(Me.tgl_kirim)
        Me.GridBand3.Name = "GridBand3"
        Me.GridBand3.Width = 214
        '
        'JanjiKirimAsli
        '
        Me.JanjiKirimAsli.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.JanjiKirimAsli.AppearanceCell.Options.UseBackColor = True
        Me.JanjiKirimAsli.AppearanceCell.Options.UseTextOptions = True
        Me.JanjiKirimAsli.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.JanjiKirimAsli.Caption = "Lama"
        Me.JanjiKirimAsli.FieldName = "tgl_kirim"
        Me.JanjiKirimAsli.Name = "JanjiKirimAsli"
        Me.JanjiKirimAsli.OptionsColumn.AllowEdit = False
        Me.JanjiKirimAsli.OptionsColumn.AllowFocus = False
        Me.JanjiKirimAsli.Visible = True
        Me.JanjiKirimAsli.Width = 101
        '
        'tgl_kirim
        '
        Me.tgl_kirim.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.tgl_kirim.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tgl_kirim.AppearanceCell.Options.UseBackColor = True
        Me.tgl_kirim.AppearanceCell.Options.UseFont = True
        Me.tgl_kirim.AppearanceCell.Options.UseTextOptions = True
        Me.tgl_kirim.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tgl_kirim.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.tgl_kirim.AppearanceHeader.Options.UseFont = True
        Me.tgl_kirim.Caption = "Baru"
        Me.tgl_kirim.ColumnEdit = Me.repTglKirim
        Me.tgl_kirim.DisplayFormat.FormatString = "d"
        Me.tgl_kirim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tgl_kirim.FieldName = "tgl_kirimB"
        Me.tgl_kirim.Name = "tgl_kirim"
        Me.tgl_kirim.Visible = True
        Me.tgl_kirim.Width = 113
        '
        'GridBand4
        '
        Me.GridBand4.Caption = " "
        Me.GridBand4.Columns.Add(Me.Alasan)
        Me.GridBand4.Name = "GridBand4"
        Me.GridBand4.Width = 232
        '
        'Alasan
        '
        Me.Alasan.Caption = "Alasan"
        Me.Alasan.FieldName = "Alasan"
        Me.Alasan.Name = "Alasan"
        Me.Alasan.Visible = True
        Me.Alasan.Width = 232
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel8.Controls.Add(Me.Panel10)
        Me.Panel8.Controls.Add(Me.Panel9)
        Me.Panel8.Controls.Add(Me.Panel5)
        Me.Panel8.Controls.Add(Me.Panel6)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 352)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel8.Size = New System.Drawing.Size(963, 50)
        Me.Panel8.TabIndex = 5
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.MemoEdit1)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(497, 3)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(255, 44)
        Me.Panel10.TabIndex = 7
        '
        'MemoEdit1
        '
        Me.MemoEdit1.Dock = System.Windows.Forms.DockStyle.Top
        Me.MemoEdit1.Location = New System.Drawing.Point(0, 0)
        Me.MemoEdit1.Name = "MemoEdit1"
        Me.MemoEdit1.Size = New System.Drawing.Size(255, 42)
        Me.MemoEdit1.TabIndex = 31
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Label4)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(398, 3)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(99, 44)
        Me.Panel9.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Alasan : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.tglKirimSP)
        Me.Panel5.Controls.Add(Me.tglKirimSPB)
        Me.Panel5.Controls.Add(Me.TglKirim)
        Me.Panel5.Controls.Add(Me.tglKirimA)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(143, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(255, 44)
        Me.Panel5.TabIndex = 5
        '
        'tglKirimSP
        '
        Me.tglKirimSP.EditValue = Nothing
        Me.tglKirimSP.Location = New System.Drawing.Point(107, 21)
        Me.tglKirimSP.Name = "tglKirimSP"
        Me.tglKirimSP.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.tglKirimSP.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglKirimSP.Properties.Appearance.Options.UseBackColor = True
        Me.tglKirimSP.Properties.Appearance.Options.UseFont = True
        Me.tglKirimSP.Properties.Appearance.Options.UseTextOptions = True
        Me.tglKirimSP.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.tglKirimSP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglKirimSP.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglKirimSP.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglKirimSP.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglKirimSP.Size = New System.Drawing.Size(148, 21)
        Me.tglKirimSP.TabIndex = 33
        Me.tglKirimSP.ToolTip = "Janji Kirim SO Baru"
        '
        'tglKirimSPB
        '
        Me.tglKirimSPB.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tglKirimSPB.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglKirimSPB.Location = New System.Drawing.Point(0, 21)
        Me.tglKirimSPB.Name = "tglKirimSPB"
        Me.tglKirimSPB.ReadOnly = True
        Me.tglKirimSPB.Size = New System.Drawing.Size(107, 21)
        Me.tglKirimSPB.TabIndex = 34
        Me.tglKirimSPB.Tag = "Janji Kirim SO Lama"
        Me.tglKirimSPB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TglKirim
        '
        Me.TglKirim.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TglKirim.EditValue = Nothing
        Me.TglKirim.Location = New System.Drawing.Point(107, 0)
        Me.TglKirim.Name = "TglKirim"
        Me.TglKirim.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TglKirim.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TglKirim.Properties.Appearance.Options.UseBackColor = True
        Me.TglKirim.Properties.Appearance.Options.UseFont = True
        Me.TglKirim.Properties.Appearance.Options.UseTextOptions = True
        Me.TglKirim.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.TglKirim.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TglKirim.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.TglKirim.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.TglKirim.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.TglKirim.Size = New System.Drawing.Size(148, 21)
        Me.TglKirim.TabIndex = 30
        Me.TglKirim.ToolTip = "Janji Kirim PPIC Baru"
        '
        'tglKirimA
        '
        Me.tglKirimA.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tglKirimA.Dock = System.Windows.Forms.DockStyle.Left
        Me.tglKirimA.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglKirimA.Location = New System.Drawing.Point(0, 0)
        Me.tglKirimA.Name = "tglKirimA"
        Me.tglKirimA.ReadOnly = True
        Me.tglKirimA.Size = New System.Drawing.Size(107, 21)
        Me.tglKirimA.TabIndex = 32
        Me.tglKirimA.Tag = "Janji Kirim PPIC Lama"
        Me.tglKirimA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(140, 44)
        Me.Panel6.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(0, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Janji Kirim SP : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Janji Kirim PPIC : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 37)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(3)
        Me.Panel2.Size = New System.Drawing.Size(963, 66)
        Me.Panel2.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Controls.Add(Me.txtTgl)
        Me.Panel4.Controls.Add(Me.txtNomor)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(120, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(345, 60)
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
        Me.txtKode.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtKode.Enabled = False
        Me.txtKode.Location = New System.Drawing.Point(235, 0)
        Me.txtKode.Name = "txtKode"
        Me.txtKode.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKode.Properties.Appearance.Options.UseBackColor = True
        Me.txtKode.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtKode.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtKode.Properties.ReadOnly = True
        Me.txtKode.Size = New System.Drawing.Size(110, 20)
        Me.txtKode.TabIndex = 2
        '
        'txtCustomer
        '
        Me.txtCustomer.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtCustomer.Enabled = False
        Me.txtCustomer.Location = New System.Drawing.Point(0, 0)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomer.Properties.Appearance.Options.UseBackColor = True
        Me.txtCustomer.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCustomer.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCustomer.Properties.ReadOnly = True
        Me.txtCustomer.Size = New System.Drawing.Size(235, 20)
        Me.txtCustomer.TabIndex = 1
        '
        'txtTgl
        '
        Me.txtTgl.Enabled = False
        Me.txtTgl.Location = New System.Drawing.Point(0, 19)
        Me.txtTgl.Name = "txtTgl"
        Me.txtTgl.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTgl.Properties.Appearance.Options.UseBackColor = True
        Me.txtTgl.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtTgl.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtTgl.Properties.ReadOnly = True
        Me.txtTgl.Size = New System.Drawing.Size(235, 20)
        Me.txtTgl.TabIndex = 2
        '
        'txtNomor
        '
        Me.txtNomor.Enabled = False
        Me.txtNomor.Location = New System.Drawing.Point(0, 0)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomor.Properties.Appearance.Options.UseBackColor = True
        Me.txtNomor.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtNomor.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtNomor.Properties.ReadOnly = True
        Me.txtNomor.Size = New System.Drawing.Size(235, 20)
        Me.txtNomor.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
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
        Me.Panel1.Size = New System.Drawing.Size(963, 37)
        Me.Panel1.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.ClientSize = New System.Drawing.Size(963, 402)
        Me.Controls.Add(Me.pnl)
        Me.LookAndFeel.SkinName = "The Asphalt World"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmUpdateJanjiKirim"
        Me.Text = "frmUpdateJanjiKirim"
        Me.pnl.ResumeLayout(False)
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repTglKirim.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repTglKirim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        CType(Me.MemoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel9.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.tglKirimSP.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglKirimSP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TglKirim.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TglKirim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
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
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtTgl As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtCustomer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNomor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents txtKode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents repTglKirim As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents repStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GV As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView
    Friend WithEvents No_seq As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Kd_Stok As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents tgl_kirim As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Alasan As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents JanjiKirimAsli As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Tgl_Kirim_MarketingB As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents Tgl_Kirim_Marketing As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
    Friend WithEvents GridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand3 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents GridBand4 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents MemoEdit1 As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents tglKirimSP As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tglKirimSPB As System.Windows.Forms.TextBox
    Friend WithEvents TglKirim As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tglKirimA As System.Windows.Forms.TextBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
