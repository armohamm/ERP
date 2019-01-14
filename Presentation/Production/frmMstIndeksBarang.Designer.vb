<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstIndeksBarang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMstIndeksBarang))
        Me.pnl = New System.Windows.Forms.Panel
        Me.gControl = New DevExpress.XtraGrid.GridControl
        Me.gView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_tipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kkd_tipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_ukuran = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kdukuran = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Nilai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Col_Vol = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ckStatus = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Rec_Stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_jenis = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jns_kegiatan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kkd_sub_tipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtjnsbarang = New DevExpress.XtraEditors.LookUpEdit
        Me.txtkegiatanppic = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.pnlTitle = New System.Windows.Forms.Panel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl.SuspendLayout()
        CType(Me.gControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kkd_tipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kdukuran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kkd_sub_tipe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.txtjnsbarang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtkegiatanppic.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl.Controls.Add(Me.gControl)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.pnlTitle)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(809, 357)
        Me.pnl.TabIndex = 0
        '
        'gControl
        '
        Me.gControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gControl.Location = New System.Drawing.Point(0, 95)
        Me.gControl.MainView = Me.gView
        Me.gControl.Name = "gControl"
        Me.gControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.kkd_sub_tipe, Me.ckStatus, Me.kdukuran, Me.kkd_tipe})
        Me.gControl.Size = New System.Drawing.Size(809, 262)
        Me.gControl.TabIndex = 5
        Me.gControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gView})
        '
        'gView
        '
        Me.gView.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gView.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gView.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.gView.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.gView.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.gView.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gView.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.gView.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gView.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gView.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.gView.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.gView.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.gView.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.gView.Appearance.Empty.Options.UseBackColor = True
        Me.gView.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.EvenRow.Options.UseBackColor = True
        Me.gView.Appearance.EvenRow.Options.UseForeColor = True
        Me.gView.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gView.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gView.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.gView.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.gView.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.gView.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gView.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.gView.Appearance.FilterPanel.Options.UseBackColor = True
        Me.gView.Appearance.FilterPanel.Options.UseForeColor = True
        Me.gView.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.gView.Appearance.FixedLine.Options.UseBackColor = True
        Me.gView.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.gView.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.FocusedCell.Options.UseBackColor = True
        Me.gView.Appearance.FocusedCell.Options.UseForeColor = True
        Me.gView.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.gView.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.gView.Appearance.FocusedRow.Options.UseBackColor = True
        Me.gView.Appearance.FocusedRow.Options.UseForeColor = True
        Me.gView.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gView.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gView.Appearance.FooterPanel.Options.UseBackColor = True
        Me.gView.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.gView.Appearance.FooterPanel.Options.UseForeColor = True
        Me.gView.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gView.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gView.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.GroupButton.Options.UseBackColor = True
        Me.gView.Appearance.GroupButton.Options.UseBorderColor = True
        Me.gView.Appearance.GroupButton.Options.UseForeColor = True
        Me.gView.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gView.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gView.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.GroupFooter.Options.UseBackColor = True
        Me.gView.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.gView.Appearance.GroupFooter.Options.UseForeColor = True
        Me.gView.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gView.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.GroupPanel.Options.UseBackColor = True
        Me.gView.Appearance.GroupPanel.Options.UseForeColor = True
        Me.gView.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gView.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.gView.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.gView.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.GroupRow.Options.UseBackColor = True
        Me.gView.Appearance.GroupRow.Options.UseBorderColor = True
        Me.gView.Appearance.GroupRow.Options.UseFont = True
        Me.gView.Appearance.GroupRow.Options.UseForeColor = True
        Me.gView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gView.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.gView.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.gView.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.gView.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.gView.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.gView.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.gView.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.gView.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.gView.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.gView.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gView.Appearance.HorzLine.Options.UseBackColor = True
        Me.gView.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.gView.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.OddRow.Options.UseBackColor = True
        Me.gView.Appearance.OddRow.Options.UseForeColor = True
        Me.gView.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gView.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.gView.Appearance.Preview.Options.UseBackColor = True
        Me.gView.Appearance.Preview.Options.UseForeColor = True
        Me.gView.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.gView.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.gView.Appearance.Row.Options.UseBackColor = True
        Me.gView.Appearance.Row.Options.UseForeColor = True
        Me.gView.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.gView.Appearance.RowSeparator.Options.UseBackColor = True
        Me.gView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.gView.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.gView.Appearance.SelectedRow.Options.UseBackColor = True
        Me.gView.Appearance.SelectedRow.Options.UseForeColor = True
        Me.gView.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.gView.Appearance.VertLine.Options.UseBackColor = True
        Me.gView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_tipe, Me.kd_ukuran, Me.Nilai, Me.Col_Vol, Me.Keterangan, Me.Rec_Stat, Me.kd_jenis, Me.jns_kegiatan})
        Me.gView.GridControl = Me.gControl
        Me.gView.Name = "gView"
        Me.gView.NewItemRowText = "Klik di sini untuk menambah item baru"
        Me.gView.OptionsView.EnableAppearanceEvenRow = True
        Me.gView.OptionsView.EnableAppearanceOddRow = True
        Me.gView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gView.OptionsView.ShowGroupPanel = False
        Me.gView.PaintStyleName = "Skin"
        '
        'kd_tipe
        '
        Me.kd_tipe.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_tipe.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_tipe.Caption = "Tipe "
        Me.kd_tipe.ColumnEdit = Me.kkd_tipe
        Me.kd_tipe.FieldName = "kd_tipe"
        Me.kd_tipe.Name = "kd_tipe"
        Me.kd_tipe.Visible = True
        Me.kd_tipe.VisibleIndex = 0
        '
        'kkd_tipe
        '
        Me.kkd_tipe.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.kkd_tipe.AutoHeight = False
        Me.kkd_tipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kkd_tipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Kode Tipe")})
        Me.kkd_tipe.Name = "kkd_tipe"
        Me.kkd_tipe.NullText = ""
        Me.kkd_tipe.ShowHeader = False
        '
        'kd_ukuran
        '
        Me.kd_ukuran.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_ukuran.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_ukuran.Caption = "Ukuran"
        Me.kd_ukuran.ColumnEdit = Me.kdukuran
        Me.kd_ukuran.FieldName = "kd_ukuran"
        Me.kd_ukuran.Name = "kd_ukuran"
        Me.kd_ukuran.Visible = True
        Me.kd_ukuran.VisibleIndex = 1
        '
        'kdukuran
        '
        Me.kdukuran.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.kdukuran.AutoHeight = False
        Me.kdukuran.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kdukuran.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Ukuran", "Jenis Ukuran")})
        Me.kdukuran.Name = "kdukuran"
        Me.kdukuran.NullText = ""
        Me.kdukuran.ShowHeader = False
        '
        'Nilai
        '
        Me.Nilai.AppearanceHeader.Options.UseTextOptions = True
        Me.Nilai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Nilai.Caption = "Indeks"
        Me.Nilai.FieldName = "nilai"
        Me.Nilai.Name = "Nilai"
        Me.Nilai.Visible = True
        Me.Nilai.VisibleIndex = 2
        '
        'Col_Vol
        '
        Me.Col_Vol.AppearanceHeader.Options.UseTextOptions = True
        Me.Col_Vol.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_Vol.Caption = "Nilai Volume"
        Me.Col_Vol.FieldName = "nilai_m3"
        Me.Col_Vol.Name = "Col_Vol"
        Me.Col_Vol.Visible = True
        Me.Col_Vol.VisibleIndex = 3
        '
        'Keterangan
        '
        Me.Keterangan.AppearanceHeader.Options.UseTextOptions = True
        Me.Keterangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Keterangan.Caption = "Status"
        Me.Keterangan.ColumnEdit = Me.ckStatus
        Me.Keterangan.FieldName = "rec_stat"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 4
        '
        'ckStatus
        '
        Me.ckStatus.AutoHeight = False
        Me.ckStatus.Caption = "Aktif"
        Me.ckStatus.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.ckStatus.DisplayValueChecked = "Y"
        Me.ckStatus.DisplayValueUnchecked = "N"
        Me.ckStatus.Name = "ckStatus"
        Me.ckStatus.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.ckStatus.ValueChecked = "Y"
        Me.ckStatus.ValueUnchecked = "N"
        '
        'Rec_Stat
        '
        Me.Rec_Stat.AppearanceHeader.Options.UseTextOptions = True
        Me.Rec_Stat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Rec_Stat.Caption = "Keterangan"
        Me.Rec_Stat.FieldName = "keterangan"
        Me.Rec_Stat.Name = "Rec_Stat"
        Me.Rec_Stat.Visible = True
        Me.Rec_Stat.VisibleIndex = 5
        '
        'kd_jenis
        '
        Me.kd_jenis.Caption = "kd_jenis"
        Me.kd_jenis.FieldName = "kd_jenis"
        Me.kd_jenis.Name = "kd_jenis"
        '
        'jns_kegiatan
        '
        Me.jns_kegiatan.Caption = "jns_kegiatan"
        Me.jns_kegiatan.FieldName = "jns_kegiatan"
        Me.jns_kegiatan.Name = "jns_kegiatan"
        '
        'kkd_sub_tipe
        '
        Me.kkd_sub_tipe.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.kkd_sub_tipe.AutoHeight = False
        Me.kkd_sub_tipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kkd_sub_tipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Sub_Tipe", "Kode Sub Tipe")})
        Me.kkd_sub_tipe.Name = "kkd_sub_tipe"
        Me.kkd_sub_tipe.NullText = ""
        Me.kkd_sub_tipe.ShowHeader = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtjnsbarang)
        Me.Panel2.Controls.Add(Me.txtkegiatanppic)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(809, 61)
        Me.Panel2.TabIndex = 4
        '
        'txtjnsbarang
        '
        Me.txtjnsbarang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtjnsbarang.Location = New System.Drawing.Point(270, 32)
        Me.txtjnsbarang.Name = "txtjnsbarang"
        Me.txtjnsbarang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtjnsbarang.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtjnsbarang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Jenis", "Nama_Jenis", 80, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.txtjnsbarang.Properties.NullText = "[Pilih Jenis Barang]"
        Me.txtjnsbarang.Properties.ShowHeader = False
        Me.txtjnsbarang.Size = New System.Drawing.Size(175, 20)
        Me.txtjnsbarang.TabIndex = 0
        '
        'txtkegiatanppic
        '
        Me.txtkegiatanppic.Location = New System.Drawing.Point(270, 6)
        Me.txtkegiatanppic.Name = "txtkegiatanppic"
        Me.txtkegiatanppic.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtkegiatanppic.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtkegiatanppic.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Desc_Data", 75, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
        Me.txtkegiatanppic.Properties.NullText = "[Pilih Jenis Kegiatan PPIC]"
        Me.txtkegiatanppic.Properties.ShowHeader = False
        Me.txtkegiatanppic.Size = New System.Drawing.Size(175, 20)
        Me.txtkegiatanppic.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(264, 61)
        Me.Panel3.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "* Jenis Barang : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(264, 26)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "* Jenis Proses  : "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.pnlTitle.Size = New System.Drawing.Size(809, 34)
        Me.pnlTitle.TabIndex = 3
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTitle.Font = New System.Drawing.Font("Arial Narrow", 15.75!)
        Me.lblTitle.ForeColor = System.Drawing.Color.Gold
        Me.lblTitle.Location = New System.Drawing.Point(37, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(324, 32)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "INDEKS BARANG"
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
        'frmMstIndeksBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 403)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMstIndeksBarang"
        Me.Text = "frmMstIndeksBarang"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl.ResumeLayout(False)
        CType(Me.gControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kkd_tipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kdukuran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kkd_sub_tipe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.txtjnsbarang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtkegiatanppic.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.pnlTitle.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rec_Stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kkd_sub_tipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ckStatus As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents kd_ukuran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nilai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kdukuran As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtkegiatanppic As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtjnsbarang As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents kkd_tipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_jenis As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jns_kegiatan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_Vol As DevExpress.XtraGrid.Columns.GridColumn
End Class
