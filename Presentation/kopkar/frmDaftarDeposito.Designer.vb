﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDaftarDeposito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDaftarDeposito))
        Me.LUE_jnsTab = New DevExpress.XtraEditors.LookUpEdit
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.lb_stat_agt = New System.Windows.Forms.Label
        Me.lb_umur = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.lb_nama = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.lb_persen = New System.Windows.Forms.Label
        Me.cb_no_tbg = New System.Windows.Forms.CheckBox
        Me.txb_no_tbg = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txb_bank = New System.Windows.Forms.TextBox
        Me.LUE_nama = New DevExpress.XtraEditors.LookUpEdit
        Me.cb_periode = New System.Windows.Forms.ComboBox
        Me.lb_alamat = New System.Windows.Forms.Label
        Me.lb_telp = New System.Windows.Forms.Label
        Me.lb_kota = New System.Windows.Forms.Label
        Me.lb_nip = New System.Windows.Forms.Label
        Me.cb_bulanan = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cb_bg = New System.Windows.Forms.CheckBox
        Me.TE_Setoran = New DevExpress.XtraEditors.TextEdit
        Me.lb1_pajak = New System.Windows.Forms.Label
        Me.lb1_bunga = New System.Windows.Forms.Label
        Me.lb1_t_bunga = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.tx1_ket = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.dtp_sd = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.tx_bg_khus = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.lb_ket = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LU_bunga_dps = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.t_rek = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.dtp_tgl = New System.Windows.Forms.DateTimePicker
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.pnl = New System.Windows.Forms.Panel
        Me.Label13 = New System.Windows.Forms.Label
        CType(Me.LUE_jnsTab.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.LUE_nama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TE_Setoran.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LU_bunga_dps.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'LUE_jnsTab
        '
        Me.LUE_jnsTab.Location = New System.Drawing.Point(213, 155)
        Me.LUE_jnsTab.Name = "LUE_jnsTab"
        Me.LUE_jnsTab.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LUE_jnsTab.Properties.Appearance.Options.UseBackColor = True
        Me.LUE_jnsTab.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LUE_jnsTab.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("DESKRIPSI_JENIS_TABUNGAN", "Tabungan")})
        Me.LUE_jnsTab.Properties.NullText = "[klik disini]"
        Me.LUE_jnsTab.Size = New System.Drawing.Size(193, 20)
        Me.LUE_jnsTab.TabIndex = 49
        '
        'LookupTipe
        '
        Me.LookupTipe.AutoHeight = False
        Me.LookupTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama Tipe")})
        Me.LookupTipe.Name = "LookupTipe"
        Me.LookupTipe.NullText = "klik disini"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(Me.lb_stat_agt)
        Me.Panel5.Controls.Add(Me.lb_umur)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Controls.Add(Me.lb_nama)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.lb_persen)
        Me.Panel5.Controls.Add(Me.cb_no_tbg)
        Me.Panel5.Controls.Add(Me.txb_no_tbg)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.txb_bank)
        Me.Panel5.Controls.Add(Me.LUE_nama)
        Me.Panel5.Controls.Add(Me.cb_periode)
        Me.Panel5.Controls.Add(Me.lb_alamat)
        Me.Panel5.Controls.Add(Me.lb_telp)
        Me.Panel5.Controls.Add(Me.lb_kota)
        Me.Panel5.Controls.Add(Me.lb_nip)
        Me.Panel5.Controls.Add(Me.cb_bulanan)
        Me.Panel5.Controls.Add(Me.Label10)
        Me.Panel5.Controls.Add(Me.cb_bg)
        Me.Panel5.Controls.Add(Me.TE_Setoran)
        Me.Panel5.Controls.Add(Me.lb1_pajak)
        Me.Panel5.Controls.Add(Me.lb1_bunga)
        Me.Panel5.Controls.Add(Me.lb1_t_bunga)
        Me.Panel5.Controls.Add(Me.Label9)
        Me.Panel5.Controls.Add(Me.tx1_ket)
        Me.Panel5.Controls.Add(Me.Label8)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.dtp_sd)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.tx_bg_khus)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.lb_ket)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.LU_bunga_dps)
        Me.Panel5.Controls.Add(Me.Panel1)
        Me.Panel5.Controls.Add(Me.LUE_jnsTab)
        Me.Panel5.Controls.Add(Me.t_rek)
        Me.Panel5.Controls.Add(Me.Label31)
        Me.Panel5.Controls.Add(Me.Label33)
        Me.Panel5.Controls.Add(Me.Label34)
        Me.Panel5.Controls.Add(Me.Label23)
        Me.Panel5.Controls.Add(Me.Label25)
        Me.Panel5.Controls.Add(Me.Label27)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.Label14)
        Me.Panel5.Controls.Add(Me.dtp_tgl)
        Me.Panel5.Controls.Add(Me.ShapeContainer1)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(799, 459)
        Me.Panel5.TabIndex = 2
        '
        'lb_stat_agt
        '
        Me.lb_stat_agt.AutoSize = True
        Me.lb_stat_agt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_stat_agt.ForeColor = System.Drawing.Color.Gold
        Me.lb_stat_agt.Location = New System.Drawing.Point(132, 121)
        Me.lb_stat_agt.Name = "lb_stat_agt"
        Me.lb_stat_agt.Size = New System.Drawing.Size(21, 13)
        Me.lb_stat_agt.TabIndex = 323
        Me.lb_stat_agt.Text = "<>"
        '
        'lb_umur
        '
        Me.lb_umur.AutoSize = True
        Me.lb_umur.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_umur.ForeColor = System.Drawing.Color.Gold
        Me.lb_umur.Location = New System.Drawing.Point(428, 72)
        Me.lb_umur.Name = "lb_umur"
        Me.lb_umur.Size = New System.Drawing.Size(48, 13)
        Me.lb_umur.TabIndex = 322
        Me.lb_umur.Text = "<umur>"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label18.Location = New System.Drawing.Point(351, 72)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 13)
        Me.Label18.TabIndex = 321
        Me.Label18.Text = "Umur  :"
        '
        'lb_nama
        '
        Me.lb_nama.AutoSize = True
        Me.lb_nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nama.ForeColor = System.Drawing.Color.Gold
        Me.lb_nama.Location = New System.Drawing.Point(131, 82)
        Me.lb_nama.Name = "lb_nama"
        Me.lb_nama.Size = New System.Drawing.Size(56, 13)
        Me.lb_nama.TabIndex = 320
        Me.lb_nama.Text = "<NAMA>"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label16.Location = New System.Drawing.Point(37, 82)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 13)
        Me.Label16.TabIndex = 319
        Me.Label16.Text = "No Anggota :"
        '
        'lb_persen
        '
        Me.lb_persen.AutoSize = True
        Me.lb_persen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_persen.ForeColor = System.Drawing.Color.Gold
        Me.lb_persen.Location = New System.Drawing.Point(341, 292)
        Me.lb_persen.Name = "lb_persen"
        Me.lb_persen.Size = New System.Drawing.Size(16, 13)
        Me.lb_persen.TabIndex = 318
        Me.lb_persen.Text = "%"
        '
        'cb_no_tbg
        '
        Me.cb_no_tbg.AutoSize = True
        Me.cb_no_tbg.Location = New System.Drawing.Point(552, 161)
        Me.cb_no_tbg.Name = "cb_no_tbg"
        Me.cb_no_tbg.Size = New System.Drawing.Size(15, 14)
        Me.cb_no_tbg.TabIndex = 315
        Me.cb_no_tbg.UseVisualStyleBackColor = True
        '
        'txb_no_tbg
        '
        Me.txb_no_tbg.Location = New System.Drawing.Point(573, 158)
        Me.txb_no_tbg.Name = "txb_no_tbg"
        Me.txb_no_tbg.Size = New System.Drawing.Size(98, 20)
        Me.txb_no_tbg.TabIndex = 317
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(468, 158)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 13)
        Me.Label12.TabIndex = 316
        Me.Label12.Text = "No Tabungan :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(341, 374)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 313
        Me.Label11.Text = "Bank:"
        '
        'txb_bank
        '
        Me.txb_bank.Location = New System.Drawing.Point(388, 371)
        Me.txb_bank.Name = "txb_bank"
        Me.txb_bank.Size = New System.Drawing.Size(213, 20)
        Me.txb_bank.TabIndex = 312
        '
        'LUE_nama
        '
        Me.LUE_nama.Location = New System.Drawing.Point(116, 46)
        Me.LUE_nama.Name = "LUE_nama"
        Me.LUE_nama.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LUE_nama.Properties.Appearance.Options.UseBackColor = True
        Me.LUE_nama.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LUE_nama.Properties.NullText = ""
        Me.LUE_nama.Size = New System.Drawing.Size(205, 20)
        Me.LUE_nama.TabIndex = 311
        '
        'cb_periode
        '
        Me.cb_periode.FormattingEnabled = True
        Me.cb_periode.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cb_periode.Location = New System.Drawing.Point(436, 344)
        Me.cb_periode.Name = "cb_periode"
        Me.cb_periode.Size = New System.Drawing.Size(121, 21)
        Me.cb_periode.TabIndex = 308
        '
        'lb_alamat
        '
        Me.lb_alamat.AutoSize = True
        Me.lb_alamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_alamat.ForeColor = System.Drawing.Color.Gold
        Me.lb_alamat.Location = New System.Drawing.Point(428, 112)
        Me.lb_alamat.Name = "lb_alamat"
        Me.lb_alamat.Size = New System.Drawing.Size(58, 13)
        Me.lb_alamat.TabIndex = 307
        Me.lb_alamat.Text = "<alamat>"
        '
        'lb_telp
        '
        Me.lb_telp.AutoSize = True
        Me.lb_telp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_telp.ForeColor = System.Drawing.Color.Gold
        Me.lb_telp.Location = New System.Drawing.Point(428, 91)
        Me.lb_telp.Name = "lb_telp"
        Me.lb_telp.Size = New System.Drawing.Size(46, 13)
        Me.lb_telp.TabIndex = 306
        Me.lb_telp.Text = "<Telp>"
        '
        'lb_kota
        '
        Me.lb_kota.AutoSize = True
        Me.lb_kota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_kota.ForeColor = System.Drawing.Color.Gold
        Me.lb_kota.Location = New System.Drawing.Point(429, 132)
        Me.lb_kota.Name = "lb_kota"
        Me.lb_kota.Size = New System.Drawing.Size(46, 13)
        Me.lb_kota.TabIndex = 306
        Me.lb_kota.Text = "<kota>"
        '
        'lb_nip
        '
        Me.lb_nip.AutoSize = True
        Me.lb_nip.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_nip.ForeColor = System.Drawing.Color.Gold
        Me.lb_nip.Location = New System.Drawing.Point(131, 101)
        Me.lb_nip.Name = "lb_nip"
        Me.lb_nip.Size = New System.Drawing.Size(42, 13)
        Me.lb_nip.TabIndex = 305
        Me.lb_nip.Text = "<NIP>"
        '
        'cb_bulanan
        '
        Me.cb_bulanan.AutoSize = True
        Me.cb_bulanan.Location = New System.Drawing.Point(320, 348)
        Me.cb_bulanan.Name = "cb_bulanan"
        Me.cb_bulanan.Size = New System.Drawing.Size(15, 14)
        Me.cb_bulanan.TabIndex = 304
        Me.cb_bulanan.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(188, 212)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 13)
        Me.Label10.TabIndex = 303
        Me.Label10.Text = "Bunga Custom :"
        '
        'cb_bg
        '
        Me.cb_bg.AutoSize = True
        Me.cb_bg.Location = New System.Drawing.Point(276, 212)
        Me.cb_bg.Name = "cb_bg"
        Me.cb_bg.Size = New System.Drawing.Size(15, 14)
        Me.cb_bg.TabIndex = 302
        Me.cb_bg.UseVisualStyleBackColor = True
        '
        'TE_Setoran
        '
        Me.TE_Setoran.Location = New System.Drawing.Point(206, 235)
        Me.TE_Setoran.Name = "TE_Setoran"
        Me.TE_Setoran.Properties.DisplayFormat.FormatString = "n2"
        Me.TE_Setoran.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TE_Setoran.Properties.EditFormat.FormatString = "n2"
        Me.TE_Setoran.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TE_Setoran.Properties.Mask.EditMask = "n2"
        Me.TE_Setoran.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.TE_Setoran.Properties.Mask.UseMaskAsDisplayFormat = True
        Me.TE_Setoran.Size = New System.Drawing.Size(112, 20)
        Me.TE_Setoran.TabIndex = 301
        '
        'lb1_pajak
        '
        Me.lb1_pajak.AutoSize = True
        Me.lb1_pajak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb1_pajak.ForeColor = System.Drawing.Color.Gold
        Me.lb1_pajak.Location = New System.Drawing.Point(210, 318)
        Me.lb1_pajak.Name = "lb1_pajak"
        Me.lb1_pajak.Size = New System.Drawing.Size(37, 13)
        Me.lb1_pajak.TabIndex = 300
        Me.lb1_pajak.Text = "<Rp>"
        '
        'lb1_bunga
        '
        Me.lb1_bunga.AutoSize = True
        Me.lb1_bunga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb1_bunga.ForeColor = System.Drawing.Color.Gold
        Me.lb1_bunga.Location = New System.Drawing.Point(210, 292)
        Me.lb1_bunga.Name = "lb1_bunga"
        Me.lb1_bunga.Size = New System.Drawing.Size(37, 13)
        Me.lb1_bunga.TabIndex = 299
        Me.lb1_bunga.Text = "<Rp>"
        '
        'lb1_t_bunga
        '
        Me.lb1_t_bunga.AutoSize = True
        Me.lb1_t_bunga.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb1_t_bunga.ForeColor = System.Drawing.Color.Gold
        Me.lb1_t_bunga.Location = New System.Drawing.Point(210, 346)
        Me.lb1_t_bunga.Name = "lb1_t_bunga"
        Me.lb1_t_bunga.Size = New System.Drawing.Size(37, 13)
        Me.lb1_t_bunga.TabIndex = 298
        Me.lb1_t_bunga.Text = "<Rp>"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(85, 399)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 297
        Me.Label9.Text = "Keterangan"
        '
        'tx1_ket
        '
        Me.tx1_ket.Location = New System.Drawing.Point(206, 396)
        Me.tx1_ket.Multiline = True
        Me.tx1_ket.Name = "tx1_ket"
        Me.tx1_ket.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tx1_ket.Size = New System.Drawing.Size(395, 42)
        Me.tx1_ket.TabIndex = 161
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(85, 344)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 295
        Me.Label8.Text = "Net Bunga"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(85, 318)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 293
        Me.Label7.Text = "Pajak (/bln)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(85, 292)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 291
        Me.Label6.Text = "Bunga Gros(/bln) :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(341, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 290
        Me.Label5.Text = "Sampai Dengan :"
        '
        'dtp_sd
        '
        Me.dtp_sd.Location = New System.Drawing.Point(436, 261)
        Me.dtp_sd.Name = "dtp_sd"
        Me.dtp_sd.Size = New System.Drawing.Size(129, 20)
        Me.dtp_sd.TabIndex = 289
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(353, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 288
        Me.Label4.Text = "Kota :"
        '
        'tx_bg_khus
        '
        Me.tx_bg_khus.Location = New System.Drawing.Point(308, 209)
        Me.tx_bg_khus.Name = "tx_bg_khus"
        Me.tx_bg_khus.Size = New System.Drawing.Size(98, 20)
        Me.tx_bg_khus.TabIndex = 287
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(333, 348)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 286
        Me.Label3.Text = "Transfer Bulanan : "
        '
        'lb_ket
        '
        Me.lb_ket.AutoSize = True
        Me.lb_ket.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ket.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lb_ket.Location = New System.Drawing.Point(327, 190)
        Me.lb_ket.Name = "lb_ket"
        Me.lb_ket.Size = New System.Drawing.Size(34, 14)
        Me.lb_ket.TabIndex = 163
        Me.lb_ket.Text = "*)ket"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(132, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 162
        Me.Label2.Text = "Bunga:"
        '
        'LU_bunga_dps
        '
        Me.LU_bunga_dps.Location = New System.Drawing.Point(213, 183)
        Me.LU_bunga_dps.Name = "LU_bunga_dps"
        Me.LU_bunga_dps.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LU_bunga_dps.Properties.Appearance.Options.UseBackColor = True
        Me.LU_bunga_dps.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LU_bunga_dps.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama", "Nama")})
        Me.LU_bunga_dps.Properties.NullText = "[klik disini]"
        Me.LU_bunga_dps.Size = New System.Drawing.Size(98, 20)
        Me.LU_bunga_dps.TabIndex = 161
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(799, 38)
        Me.Panel1.TabIndex = 160
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 36)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Orange
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(633, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "            PENDAFTARAN DAN SETORAN AWAL DEPOSITO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        't_rek
        '
        Me.t_rek.BackColor = System.Drawing.SystemColors.Window
        Me.t_rek.Location = New System.Drawing.Point(206, 371)
        Me.t_rek.Name = "t_rek"
        Me.t_rek.Size = New System.Drawing.Size(112, 20)
        Me.t_rek.TabIndex = 48
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label31.Location = New System.Drawing.Point(37, 121)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(86, 13)
        Me.Label31.TabIndex = 38
        Me.Label31.Text = "Status Anggota :"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label33.Location = New System.Drawing.Point(37, 101)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(70, 13)
        Me.Label33.TabIndex = 36
        Me.Label33.Text = "No Anggota :"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label34.Location = New System.Drawing.Point(33, 49)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(31, 13)
        Me.Label34.TabIndex = 35
        Me.Label34.Text = "NIP :"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label23.Location = New System.Drawing.Point(351, 91)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(51, 13)
        Me.Label23.TabIndex = 34
        Me.Label23.Text = "No Telp :"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label25.Location = New System.Drawing.Point(85, 264)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(82, 13)
        Me.Label25.TabIndex = 32
        Me.Label25.Text = "Tgl Pengajuan :"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label27.Location = New System.Drawing.Point(85, 242)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(76, 13)
        Me.Label27.TabIndex = 30
        Me.Label27.Text = "Setoran Awal :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(85, 158)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(89, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Jenis Tabungan :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(85, 373)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(89, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "No Rek Transfer:"
        '
        'dtp_tgl
        '
        Me.dtp_tgl.Location = New System.Drawing.Point(206, 261)
        Me.dtp_tgl.Name = "dtp_tgl"
        Me.dtp_tgl.Size = New System.Drawing.Size(129, 20)
        Me.dtp_tgl.TabIndex = 46
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(799, 459)
        Me.ShapeContainer1.TabIndex = 5
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 2
        Me.LineShape1.X2 = 802
        Me.LineShape1.Y1 = 149
        Me.LineShape1.Y2 = 146
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'LookupMerk
        '
        Me.LookupMerk.AutoHeight = False
        Me.LookupMerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupMerk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", "Nama Merk")})
        Me.LookupMerk.Name = "LookupMerk"
        Me.LookupMerk.NullText = "klik disini"
        '
        'LookupStok
        '
        Me.LookupStok.AutoHeight = False
        Me.LookupStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupStok.Name = "LookupStok"
        Me.LookupStok.NullText = "[klik disini]"
        '
        'Lookup
        '
        Me.Lookup.AutoHeight = False
        Me.Lookup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookup.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.Lookup.Name = "Lookup"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Y", "T"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(799, 459)
        Me.pnl.TabIndex = 160
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Gold
        Me.Label13.Location = New System.Drawing.Point(327, 53)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(190, 13)
        Me.Label13.TabIndex = 324
        Me.Label13.Text = "*) setelah ketik NIP tekan tombol Enter"
        '
        'frmDaftarDeposito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 459)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmDaftarDeposito"
        Me.Text = "frmDeposito"
        CType(Me.LUE_jnsTab.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.LUE_nama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TE_Setoran.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LU_bunga_dps.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LUE_jnsTab As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtp_tgl As System.Windows.Forms.DateTimePicker
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LU_bunga_dps As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lb_ket As System.Windows.Forms.Label
    Friend WithEvents tx_bg_khus As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtp_sd As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents t_rek As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tx1_ket As System.Windows.Forms.TextBox
    Friend WithEvents lb1_pajak As System.Windows.Forms.Label
    Friend WithEvents lb1_bunga As System.Windows.Forms.Label
    Friend WithEvents lb1_t_bunga As System.Windows.Forms.Label
    Friend WithEvents TE_Setoran As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cb_bg As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cb_bulanan As System.Windows.Forms.CheckBox
    Friend WithEvents lb_alamat As System.Windows.Forms.Label
    Friend WithEvents lb_telp As System.Windows.Forms.Label
    Friend WithEvents lb_nip As System.Windows.Forms.Label
    Friend WithEvents cb_periode As System.Windows.Forms.ComboBox
    Friend WithEvents LUE_nama As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txb_bank As System.Windows.Forms.TextBox
    Friend WithEvents cb_no_tbg As System.Windows.Forms.CheckBox
    Friend WithEvents txb_no_tbg As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lb_persen As System.Windows.Forms.Label
    Friend WithEvents lb_nama As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lb_umur As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lb_stat_agt As System.Windows.Forms.Label
    Friend WithEvents lb_kota As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
