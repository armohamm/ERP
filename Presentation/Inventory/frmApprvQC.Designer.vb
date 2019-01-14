<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApprvQC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmApprvQC))
        Me.LookBrg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ket_approve = New DevExpress.XtraGrid.Columns.GridColumn
        Me.No_Seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_Stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty_PR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Qty_sisa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GcApprvQC = New DevExpress.XtraGrid.GridControl
        Me.GVApprvQC = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.no_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tgl_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_stok1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.no_ref = New DevExpress.XtraGrid.Columns.GridColumn
        Me.hold = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Last_Created_By = New DevExpress.XtraGrid.Columns.GridColumn
        Me.status_hold = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_release = New DevExpress.XtraGrid.Columns.GridColumn
        Me.qty_reject_hold = New DevExpress.XtraGrid.Columns.GridColumn
        Me.harga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.rp_trans = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.txbNoTrans = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.LookBrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GcApprvQC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVApprvQC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LookBrg
        '
        Me.LookBrg.AutoHeight = False
        Me.LookBrg.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookBrg.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", "Kode")})
        Me.LookBrg.Name = "LookBrg"
        Me.LookBrg.NullText = "[Barang]"
        '
        'GridView1
        '
        Me.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsPrint.ExpandAllDetails = True
        Me.GridView1.OptionsPrint.PrintDetails = True
        Me.GridView1.OptionsPrint.PrintFilterInfo = True
        Me.GridView1.OptionsPrint.PrintHorzLines = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'ket_approve
        '
        Me.ket_approve.AppearanceHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ket_approve.AppearanceHeader.Options.UseFont = True
        Me.ket_approve.Caption = "Alasan Reject"
        Me.ket_approve.FieldName = "ket_approve"
        Me.ket_approve.MinWidth = 100
        Me.ket_approve.Name = "ket_approve"
        Me.ket_approve.OptionsColumn.AllowEdit = False
        Me.ket_approve.Visible = True
        Me.ket_approve.VisibleIndex = 6
        Me.ket_approve.Width = 191
        '
        'No_Seq
        '
        Me.No_Seq.Caption = "Nomor"
        Me.No_Seq.FieldName = "No_Seq"
        Me.No_Seq.MinWidth = 10
        Me.No_Seq.Name = "No_Seq"
        Me.No_Seq.Visible = True
        Me.No_Seq.VisibleIndex = 0
        Me.No_Seq.Width = 64
        '
        'Kd_Stok
        '
        Me.Kd_Stok.Caption = "Nama"
        Me.Kd_Stok.ColumnEdit = Me.LookBrg
        Me.Kd_Stok.FieldName = "Kd_Stok"
        Me.Kd_Stok.Name = "Kd_Stok"
        Me.Kd_Stok.OptionsColumn.AllowEdit = False
        Me.Kd_Stok.Visible = True
        Me.Kd_Stok.VisibleIndex = 1
        Me.Kd_Stok.Width = 497
        '
        'Satuan
        '
        Me.Satuan.Caption = "Satuan"
        Me.Satuan.FieldName = "Satuan"
        Me.Satuan.Name = "Satuan"
        Me.Satuan.Visible = True
        Me.Satuan.VisibleIndex = 2
        '
        'Qty
        '
        Me.Qty.Caption = "Qty"
        Me.Qty.DisplayFormat.FormatString = "d2"
        Me.Qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Qty.FieldName = "Qty"
        Me.Qty.Name = "Qty"
        Me.Qty.OptionsColumn.AllowEdit = False
        Me.Qty.SummaryItem.FieldName = "Qty"
        Me.Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Qty.Visible = True
        Me.Qty.VisibleIndex = 3
        Me.Qty.Width = 78
        '
        'Qty_PR
        '
        Me.Qty_PR.Caption = "Qty Purc"
        Me.Qty_PR.FieldName = "Qty_PR"
        Me.Qty_PR.Name = "Qty_PR"
        Me.Qty_PR.OptionsColumn.AllowEdit = False
        Me.Qty_PR.SummaryItem.FieldName = "Qty_PR"
        Me.Qty_PR.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Qty_PR.Visible = True
        Me.Qty_PR.VisibleIndex = 4
        Me.Qty_PR.Width = 78
        '
        'Qty_sisa
        '
        Me.Qty_sisa.Caption = "Sisa"
        Me.Qty_sisa.FieldName = "Qty_sisa"
        Me.Qty_sisa.Name = "Qty_sisa"
        Me.Qty_sisa.OptionsColumn.AllowEdit = False
        Me.Qty_sisa.SummaryItem.FieldName = "Qty_sisa"
        Me.Qty_sisa.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Qty_sisa.Visible = True
        Me.Qty_sisa.VisibleIndex = 5
        Me.Qty_sisa.Width = 91
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(792, 362)
        Me.pnl.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GcApprvQC)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 84)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(792, 278)
        Me.Panel3.TabIndex = 141
        '
        'GcApprvQC
        '
        Me.GcApprvQC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcApprvQC.EmbeddedNavigator.Enabled = False
        Me.GcApprvQC.Location = New System.Drawing.Point(0, 0)
        Me.GcApprvQC.MainView = Me.GVApprvQC
        Me.GcApprvQC.Name = "GcApprvQC"
        Me.GcApprvQC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LookBrg})
        Me.GcApprvQC.ShowOnlyPredefinedDetails = True
        Me.GcApprvQC.Size = New System.Drawing.Size(792, 278)
        Me.GcApprvQC.TabIndex = 139
        Me.GcApprvQC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVApprvQC})
        '
        'GVApprvQC
        '
        Me.GVApprvQC.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVApprvQC.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVApprvQC.AppearancePrint.EvenRow.BackColor = System.Drawing.Color.White
        Me.GVApprvQC.AppearancePrint.EvenRow.Options.UseBackColor = True
        Me.GVApprvQC.AppearancePrint.FooterPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVApprvQC.AppearancePrint.FooterPanel.Options.UseBackColor = True
        Me.GVApprvQC.AppearancePrint.FooterPanel.Options.UseForeColor = True
        Me.GVApprvQC.AppearancePrint.GroupFooter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GVApprvQC.AppearancePrint.GroupFooter.Options.UseForeColor = True
        Me.GVApprvQC.AppearancePrint.Lines.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GVApprvQC.AppearancePrint.Lines.Options.UseBackColor = True
        Me.GVApprvQC.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.GVApprvQC.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.no_trans, Me.tgl_trans, Me.kd_stok1, Me.no_ref, Me.hold, Me.Last_Created_By, Me.status_hold, Me.qty_release, Me.qty_reject_hold, Me.harga, Me.rp_trans})
        Me.GVApprvQC.DetailHeight = 600
        Me.GVApprvQC.GridControl = Me.GcApprvQC
        Me.GVApprvQC.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GVApprvQC.Name = "GVApprvQC"
        Me.GVApprvQC.OptionsDetail.AllowExpandEmptyDetails = True
        Me.GVApprvQC.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GVApprvQC.OptionsPrint.ExpandAllDetails = True
        Me.GVApprvQC.OptionsPrint.PrintDetails = True
        Me.GVApprvQC.OptionsPrint.PrintFilterInfo = True
        Me.GVApprvQC.OptionsPrint.PrintHorzLines = False
        Me.GVApprvQC.OptionsPrint.UsePrintStyles = True
        Me.GVApprvQC.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem
        Me.GVApprvQC.OptionsView.EnableAppearanceEvenRow = True
        Me.GVApprvQC.OptionsView.EnableAppearanceOddRow = True
        Me.GVApprvQC.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office2003
        Me.GVApprvQC.OptionsView.ShowGroupedColumns = True
        Me.GVApprvQC.PaintStyleName = "Office2003"
        Me.GVApprvQC.RowHeight = 4
        Me.GVApprvQC.RowSeparatorHeight = 1
        Me.GVApprvQC.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'no_trans
        '
        Me.no_trans.Caption = "No Transaksi"
        Me.no_trans.FieldName = "no_trans"
        Me.no_trans.Name = "no_trans"
        Me.no_trans.OptionsColumn.AllowEdit = False
        Me.no_trans.OptionsColumn.ReadOnly = True
        Me.no_trans.Visible = True
        Me.no_trans.VisibleIndex = 0
        Me.no_trans.Width = 69
        '
        'tgl_trans
        '
        Me.tgl_trans.Caption = "Tgl Trans"
        Me.tgl_trans.FieldName = "tgl_trans"
        Me.tgl_trans.Name = "tgl_trans"
        Me.tgl_trans.OptionsColumn.AllowEdit = False
        Me.tgl_trans.OptionsColumn.ReadOnly = True
        Me.tgl_trans.Visible = True
        Me.tgl_trans.VisibleIndex = 1
        Me.tgl_trans.Width = 52
        '
        'kd_stok1
        '
        Me.kd_stok1.Caption = "Barang"
        Me.kd_stok1.ColumnEdit = Me.LookBrg
        Me.kd_stok1.FieldName = "kd_stok"
        Me.kd_stok1.Name = "kd_stok1"
        Me.kd_stok1.Visible = True
        Me.kd_stok1.VisibleIndex = 2
        '
        'no_ref
        '
        Me.no_ref.Caption = "No Referensi"
        Me.no_ref.FieldName = "no_ref"
        Me.no_ref.Name = "no_ref"
        Me.no_ref.OptionsColumn.AllowEdit = False
        Me.no_ref.OptionsColumn.ReadOnly = True
        Me.no_ref.Visible = True
        Me.no_ref.VisibleIndex = 3
        Me.no_ref.Width = 70
        '
        'hold
        '
        Me.hold.Caption = "Jumlah Hold"
        Me.hold.FieldName = "hold"
        Me.hold.Name = "hold"
        Me.hold.OptionsColumn.AllowEdit = False
        Me.hold.OptionsColumn.ReadOnly = True
        Me.hold.Visible = True
        Me.hold.VisibleIndex = 5
        Me.hold.Width = 65
        '
        'Last_Created_By
        '
        Me.Last_Created_By.Caption = "Petugas QC"
        Me.Last_Created_By.FieldName = "Last_Created_By"
        Me.Last_Created_By.Name = "Last_Created_By"
        Me.Last_Created_By.OptionsColumn.AllowEdit = False
        Me.Last_Created_By.OptionsColumn.ReadOnly = True
        Me.Last_Created_By.Visible = True
        Me.Last_Created_By.VisibleIndex = 4
        Me.Last_Created_By.Width = 65
        '
        'status_hold
        '
        Me.status_hold.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status_hold.AppearanceCell.Options.UseFont = True
        Me.status_hold.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.status_hold.AppearanceHeader.Options.UseFont = True
        Me.status_hold.Caption = "Status Hold"
        Me.status_hold.FieldName = "status_hold"
        Me.status_hold.Name = "status_hold"
        Me.status_hold.OptionsColumn.AllowEdit = False
        Me.status_hold.OptionsColumn.ReadOnly = True
        Me.status_hold.Visible = True
        Me.status_hold.VisibleIndex = 8
        '
        'qty_release
        '
        Me.qty_release.Caption = "Release"
        Me.qty_release.FieldName = "qty_release"
        Me.qty_release.Name = "qty_release"
        Me.qty_release.Visible = True
        Me.qty_release.VisibleIndex = 6
        Me.qty_release.Width = 46
        '
        'qty_reject_hold
        '
        Me.qty_reject_hold.Caption = "Reject Hold"
        Me.qty_reject_hold.FieldName = "qty_reject_hold"
        Me.qty_reject_hold.Name = "qty_reject_hold"
        Me.qty_reject_hold.OptionsColumn.AllowEdit = False
        Me.qty_reject_hold.OptionsColumn.ReadOnly = True
        Me.qty_reject_hold.Visible = True
        Me.qty_reject_hold.VisibleIndex = 7
        Me.qty_reject_hold.Width = 63
        '
        'harga
        '
        Me.harga.Caption = "harga"
        Me.harga.FieldName = "harga"
        Me.harga.Name = "harga"
        Me.harga.OptionsColumn.AllowEdit = False
        Me.harga.OptionsColumn.ReadOnly = True
        Me.harga.Visible = True
        Me.harga.VisibleIndex = 9
        Me.harga.Width = 63
        '
        'rp_trans
        '
        Me.rp_trans.Caption = "rp_trans"
        Me.rp_trans.FieldName = "rp_trans"
        Me.rp_trans.Name = "rp_trans"
        Me.rp_trans.OptionsColumn.AllowEdit = False
        Me.rp_trans.OptionsColumn.ReadOnly = True
        Me.rp_trans.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.rp_trans.Visible = True
        Me.rp_trans.VisibleIndex = 10
        Me.rp_trans.Width = 82
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txbNoTrans)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 42)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(792, 42)
        Me.Panel2.TabIndex = 140
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(29, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 179
        Me.Label8.Text = "No Transaksi"
        '
        'txbNoTrans
        '
        Me.txbNoTrans.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txbNoTrans.Location = New System.Drawing.Point(133, 10)
        Me.txbNoTrans.Name = "txbNoTrans"
        Me.txbNoTrans.Size = New System.Drawing.Size(212, 20)
        Me.txbNoTrans.TabIndex = 178
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
        Me.Panel1.Size = New System.Drawing.Size(792, 42)
        Me.Panel1.TabIndex = 139
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 40)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(790, 40)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "        RELEASE BARANG STATUS HOLD"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmApprvQC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 362)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmApprvQC"
        Me.Text = "frmApprvQC"
        CType(Me.LookBrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.GcApprvQC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVApprvQC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ket_approve As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents No_Seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_Stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty_PR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty_sisa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GcApprvQC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVApprvQC As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tgl_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents no_ref As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents hold As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Last_Created_By As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_release As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents qty_reject_hold As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LookBrg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents harga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rp_trans As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents status_hold As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txbNoTrans As System.Windows.Forms.TextBox
    Friend WithEvents kd_stok1 As DevExpress.XtraGrid.Columns.GridColumn
End Class
