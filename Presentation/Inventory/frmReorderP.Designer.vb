<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReorderP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReorderP))
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.GcReorder = New DevExpress.XtraGrid.GridControl
        Me.gvReorder = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.nomer = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_Barang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.spek_brg = New DevExpress.XtraGrid.Columns.GridColumn
        Me.satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.stok_barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.stok_max = New DevExpress.XtraGrid.Columns.GridColumn
        Me.stok_min = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rata_pakai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lead_time = New DevExpress.XtraGrid.Columns.GridColumn
        Me.stok_capai_min = New DevExpress.XtraGrid.Columns.GridColumn
        Me.reorder_poin = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.RG_Jenis = New DevExpress.XtraEditors.RadioGroup
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.LookupTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Lookup = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.LookupMerk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.LookupStok = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.GcReorder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvReorder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_Barang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.RG_Jenis.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'pnl
        '
        Me.pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 34)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(792, 317)
        Me.pnl.TabIndex = 150
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GcReorder)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 45)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(792, 272)
        Me.Panel5.TabIndex = 2
        '
        'GcReorder
        '
        Me.GcReorder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcReorder.Location = New System.Drawing.Point(0, 0)
        Me.GcReorder.MainView = Me.gvReorder
        Me.GcReorder.Name = "GcReorder"
        Me.GcReorder.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RL_Barang})
        Me.GcReorder.Size = New System.Drawing.Size(792, 272)
        Me.GcReorder.TabIndex = 0
        Me.GcReorder.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvReorder})
        '
        'gvReorder
        '
        Me.gvReorder.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.nomer, Me.kd_stok, Me.spek_brg, Me.satuan, Me.stok_barang, Me.stok_max, Me.stok_min, Me.rata_pakai, Me.lead_time, Me.stok_capai_min, Me.reorder_poin})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.DarkRed
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Yellow
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.Column = Me.stok_capai_min
        StyleFormatCondition1.Expression = "[reorder_poin] <= [stok_capai_min]"
        Me.gvReorder.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.gvReorder.GridControl = Me.GcReorder
        Me.gvReorder.Name = "gvReorder"
        Me.gvReorder.OptionsBehavior.ReadOnly = True
        Me.gvReorder.OptionsView.ShowFooter = True
        '
        'nomer
        '
        Me.nomer.Caption = "No"
        Me.nomer.FieldName = "nomer"
        Me.nomer.Name = "nomer"
        Me.nomer.OptionsColumn.ReadOnly = True
        Me.nomer.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        Me.nomer.Visible = True
        Me.nomer.VisibleIndex = 0
        Me.nomer.Width = 24
        '
        'kd_stok
        '
        Me.kd_stok.Caption = "Barang"
        Me.kd_stok.ColumnEdit = Me.RL_Barang
        Me.kd_stok.FieldName = "kd_stok"
        Me.kd_stok.Name = "kd_stok"
        Me.kd_stok.OptionsColumn.ReadOnly = True
        Me.kd_stok.Visible = True
        Me.kd_stok.VisibleIndex = 1
        Me.kd_stok.Width = 219
        '
        'RL_Barang
        '
        Me.RL_Barang.AutoHeight = False
        Me.RL_Barang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_Barang.Name = "RL_Barang"
        Me.RL_Barang.NullText = ""
        '
        'spek_brg
        '
        Me.spek_brg.Caption = "Spek"
        Me.spek_brg.FieldName = "spek_brg"
        Me.spek_brg.Name = "spek_brg"
        Me.spek_brg.OptionsColumn.ReadOnly = True
        Me.spek_brg.Visible = True
        Me.spek_brg.VisibleIndex = 2
        Me.spek_brg.Width = 34
        '
        'satuan
        '
        Me.satuan.Caption = "Satuan"
        Me.satuan.FieldName = "satuan"
        Me.satuan.Name = "satuan"
        Me.satuan.OptionsColumn.ReadOnly = True
        Me.satuan.Visible = True
        Me.satuan.VisibleIndex = 3
        Me.satuan.Width = 38
        '
        'stok_barang
        '
        Me.stok_barang.Caption = "Stok Barang"
        Me.stok_barang.FieldName = "stok_barang"
        Me.stok_barang.Name = "stok_barang"
        Me.stok_barang.OptionsColumn.ReadOnly = True
        Me.stok_barang.Visible = True
        Me.stok_barang.VisibleIndex = 4
        Me.stok_barang.Width = 69
        '
        'stok_max
        '
        Me.stok_max.Caption = "Stok Max"
        Me.stok_max.FieldName = "stok_max"
        Me.stok_max.Name = "stok_max"
        Me.stok_max.OptionsColumn.ReadOnly = True
        Me.stok_max.Visible = True
        Me.stok_max.VisibleIndex = 5
        Me.stok_max.Width = 55
        '
        'stok_min
        '
        Me.stok_min.Caption = "Stok Min"
        Me.stok_min.FieldName = "stok_min"
        Me.stok_min.Name = "stok_min"
        Me.stok_min.OptionsColumn.ReadOnly = True
        Me.stok_min.Visible = True
        Me.stok_min.VisibleIndex = 6
        Me.stok_min.Width = 51
        '
        'rata_pakai
        '
        Me.rata_pakai.Caption = "Konsumsi/hr"
        Me.rata_pakai.FieldName = "rata_pakai"
        Me.rata_pakai.Name = "rata_pakai"
        Me.rata_pakai.OptionsColumn.ReadOnly = True
        Me.rata_pakai.Visible = True
        Me.rata_pakai.VisibleIndex = 7
        Me.rata_pakai.Width = 70
        '
        'lead_time
        '
        Me.lead_time.Caption = "LeadTime"
        Me.lead_time.FieldName = "lead_time"
        Me.lead_time.Name = "lead_time"
        Me.lead_time.OptionsColumn.ReadOnly = True
        Me.lead_time.Visible = True
        Me.lead_time.VisibleIndex = 8
        Me.lead_time.Width = 55
        '
        'stok_capai_min
        '
        Me.stok_capai_min.Caption = "Stok Capai Min"
        Me.stok_capai_min.FieldName = "stok_capai_min"
        Me.stok_capai_min.Name = "stok_capai_min"
        Me.stok_capai_min.OptionsColumn.ReadOnly = True
        Me.stok_capai_min.Visible = True
        Me.stok_capai_min.VisibleIndex = 9
        Me.stok_capai_min.Width = 84
        '
        'reorder_poin
        '
        Me.reorder_poin.Caption = "ReOrder Point"
        Me.reorder_poin.FieldName = "reorder_poin"
        Me.reorder_poin.Name = "reorder_poin"
        Me.reorder_poin.OptionsColumn.ReadOnly = True
        Me.reorder_poin.Visible = True
        Me.reorder_poin.VisibleIndex = 10
        Me.reorder_poin.Width = 72
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cmdRefresh)
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(792, 45)
        Me.Panel3.TabIndex = 0
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(482, 0)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(49, 45)
        Me.cmdRefresh.TabIndex = 34
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.RG_Jenis)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(482, 45)
        Me.Panel6.TabIndex = 1
        '
        'RG_Jenis
        '
        Me.RG_Jenis.Dock = System.Windows.Forms.DockStyle.Top
        Me.RG_Jenis.Location = New System.Drawing.Point(0, 0)
        Me.RG_Jenis.Name = "RG_Jenis"
        Me.RG_Jenis.Properties.Appearance.BackColor = System.Drawing.Color.DimGray
        Me.RG_Jenis.Properties.Appearance.Options.UseBackColor = True
        Me.RG_Jenis.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(11, Short), "Barang Jadi"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(22, Short), "Barang 1/2 Jadi"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(33, Short), "Bahan Baku"), New DevExpress.XtraEditors.Controls.RadioGroupItem(CType(44, Short), "Semua")})
        Me.RG_Jenis.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RG_Jenis.Size = New System.Drawing.Size(482, 39)
        Me.RG_Jenis.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 351)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(792, 37)
        Me.Panel2.TabIndex = 149
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'LookupTipe
        '
        Me.LookupTipe.AutoHeight = False
        Me.LookupTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupTipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama Tipe")})
        Me.LookupTipe.Name = "LookupTipe"
        Me.LookupTipe.NullText = "klik disini"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Y", "T"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'Lookup
        '
        Me.Lookup.AutoHeight = False
        Me.Lookup.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Lookup.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.Lookup.Name = "Lookup"
        '
        'LookupMerk
        '
        Me.LookupMerk.AutoHeight = False
        Me.LookupMerk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupMerk.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Merk", "Nama Merk")})
        Me.LookupMerk.Name = "LookupMerk"
        Me.LookupMerk.NullText = "klik disini"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          MONITORING REORDER POIN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.Panel1.Size = New System.Drawing.Size(792, 34)
        Me.Panel1.TabIndex = 148
        '
        'LookupStok
        '
        Me.LookupStok.AutoHeight = False
        Me.LookupStok.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookupStok.Name = "LookupStok"
        Me.LookupStok.NullText = "[klik disini]"
        '
        'frmReorderP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 388)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmReorderP"
        Me.Text = "frmReorderP"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.GcReorder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvReorder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_Barang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.RG_Jenis.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lookup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookupMerk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.LookupStok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LookupTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Lookup As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents LookupMerk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LookupStok As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GcReorder As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvReorder As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents nomer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kd_stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents spek_brg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents stok_max As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents stok_min As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rata_pakai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lead_time As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents stok_capai_min As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents reorder_poin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents RL_Barang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents RG_Jenis As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents stok_barang As DevExpress.XtraGrid.Columns.GridColumn
End Class
