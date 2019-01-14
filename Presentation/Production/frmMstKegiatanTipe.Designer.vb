<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstKegiatanTipe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMstKegiatanTipe))
        Me.pnl = New System.Windows.Forms.Panel
        Me.gControl = New DevExpress.XtraGrid.GridControl
        Me.gView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Jns_Brg = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepLE_SPK = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_tipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kd_subtipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kkd_subtipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.kd_ukuran = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nilai_konv = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Rec_Stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.kkd_tipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ckStatus = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.kdukuran = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtKegiatan = New DevExpress.XtraEditors.LookUpEdit
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
        CType(Me.RepLE_SPK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kkd_subtipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kkd_tipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.kdukuran, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.txtKegiatan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnl.BackColor = System.Drawing.SystemColors.Control
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
        Me.gControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.kkd_tipe, Me.ckStatus, Me.kdukuran, Me.RepLE_SPK, Me.kkd_subtipe})
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
        Me.gView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Jns_Brg, Me.kd_tipe, Me.kd_subtipe, Me.kd_ukuran, Me.nilai_konv, Me.Keterangan, Me.Rec_Stat})
        Me.gView.GridControl = Me.gControl
        Me.gView.Name = "gView"
        Me.gView.NewItemRowText = "Klik di sini untuk menambah item baru"
        Me.gView.OptionsView.EnableAppearanceEvenRow = True
        Me.gView.OptionsView.EnableAppearanceOddRow = True
        Me.gView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gView.OptionsView.ShowGroupPanel = False
        Me.gView.PaintStyleName = "Skin"
        '
        'Jns_Brg
        '
        Me.Jns_Brg.AppearanceHeader.Options.UseTextOptions = True
        Me.Jns_Brg.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Jns_Brg.Caption = "Jenis Barang"
        Me.Jns_Brg.ColumnEdit = Me.RepLE_SPK
        Me.Jns_Brg.FieldName = "kd_jenis"
        Me.Jns_Brg.Name = "Jns_Brg"
        Me.Jns_Brg.Visible = True
        Me.Jns_Brg.VisibleIndex = 0
        '
        'RepLE_SPK
        '
        Me.RepLE_SPK.AutoHeight = False
        Me.RepLE_SPK.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepLE_SPK.DisplayMember = "Nama_Jenis"
        Me.RepLE_SPK.Name = "RepLE_SPK"
        Me.RepLE_SPK.NullText = ""
        Me.RepLE_SPK.ValueMember = "Kd_Jns_Brg"
        '
        'kd_tipe
        '
        Me.kd_tipe.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_tipe.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_tipe.Caption = "Kode Tipe"
        Me.kd_tipe.FieldName = "kd_tipe"
        Me.kd_tipe.Name = "kd_tipe"
        Me.kd_tipe.Visible = True
        Me.kd_tipe.VisibleIndex = 1
        '
        'kd_subtipe
        '
        Me.kd_subtipe.Caption = "Kode Sub Tipe"
        Me.kd_subtipe.ColumnEdit = Me.kkd_subtipe
        Me.kd_subtipe.FieldName = "kd_subtipe"
        Me.kd_subtipe.Name = "kd_subtipe"
        Me.kd_subtipe.Visible = True
        Me.kd_subtipe.VisibleIndex = 2
        '
        'kkd_subtipe
        '
        Me.kkd_subtipe.AutoHeight = False
        Me.kkd_subtipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kkd_subtipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Sub_Tipe", "Nama_Sub_Tipe")})
        Me.kkd_subtipe.Name = "kkd_subtipe"
        Me.kkd_subtipe.NullText = ""
        '
        'kd_ukuran
        '
        Me.kd_ukuran.AppearanceHeader.Options.UseTextOptions = True
        Me.kd_ukuran.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.kd_ukuran.Caption = "Kode Ukuran"
        Me.kd_ukuran.FieldName = "kd_ukuran"
        Me.kd_ukuran.Name = "kd_ukuran"
        Me.kd_ukuran.Visible = True
        Me.kd_ukuran.VisibleIndex = 3
        '
        'nilai_konv
        '
        Me.nilai_konv.AppearanceHeader.Options.UseTextOptions = True
        Me.nilai_konv.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.nilai_konv.Caption = "Nilai"
        Me.nilai_konv.DisplayFormat.FormatString = "N2"
        Me.nilai_konv.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.nilai_konv.FieldName = "nilai_konv"
        Me.nilai_konv.Name = "nilai_konv"
        Me.nilai_konv.Visible = True
        Me.nilai_konv.VisibleIndex = 4
        '
        'Keterangan
        '
        Me.Keterangan.AppearanceHeader.Options.UseTextOptions = True
        Me.Keterangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 5
        '
        'Rec_Stat
        '
        Me.Rec_Stat.AppearanceHeader.Options.UseTextOptions = True
        Me.Rec_Stat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Rec_Stat.Caption = "Status"
        Me.Rec_Stat.FieldName = "rec_stat"
        Me.Rec_Stat.Name = "Rec_Stat"
        Me.Rec_Stat.Visible = True
        Me.Rec_Stat.VisibleIndex = 6
        '
        'kkd_tipe
        '
        Me.kkd_tipe.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.kkd_tipe.AutoHeight = False
        Me.kkd_tipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.kkd_tipe.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Tipe", "Nama_Tipe")})
        Me.kkd_tipe.Name = "kkd_tipe"
        Me.kkd_tipe.NullText = ""
        Me.kkd_tipe.ShowHeader = False
        '
        'ckStatus
        '
        Me.ckStatus.AutoHeight = False
        Me.ckStatus.Caption = "Aktif"
        Me.ckStatus.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.ckStatus.Name = "ckStatus"
        Me.ckStatus.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.ckStatus.ValueChecked = "Y"
        Me.ckStatus.ValueUnchecked = "N"
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtKegiatan)
        Me.Panel2.Controls.Add(Me.txtkegiatanppic)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(809, 61)
        Me.Panel2.TabIndex = 4
        '
        'txtKegiatan
        '
        Me.txtKegiatan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKegiatan.Location = New System.Drawing.Point(270, 32)
        Me.txtKegiatan.Name = "txtKegiatan"
        Me.txtKegiatan.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtKegiatan.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Jenis Kegiatan")})
        Me.txtKegiatan.Properties.NullText = "[Pilih Jenis Kegiatan SPK]"
        Me.txtKegiatan.Properties.ShowHeader = False
        Me.txtKegiatan.Size = New System.Drawing.Size(175, 20)
        Me.txtKegiatan.TabIndex = 0
        '
        'txtkegiatanppic
        '
        Me.txtkegiatanppic.Location = New System.Drawing.Point(270, 6)
        Me.txtkegiatanppic.Name = "txtkegiatanppic"
        Me.txtkegiatanppic.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
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
        Me.Label1.Text = "* Jenis Kegiatan : "
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
        Me.lblTitle.Text = "INDEKS KEGIATAN PRODUKSI"
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
        'frmMstKegiatanTipe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(822, 403)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMstKegiatanTipe"
        Me.Text = "frmKegiatanPerTipe"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.pnl.ResumeLayout(False)
        CType(Me.gControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepLE_SPK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kkd_subtipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kkd_tipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.kdukuran, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.txtKegiatan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents kkd_tipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ckStatus As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents kd_ukuran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nilai_konv As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kdukuran As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents txtkegiatanppic As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtKegiatan As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Jns_Brg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepLE_SPK As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents kd_subtipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents kkd_subtipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
