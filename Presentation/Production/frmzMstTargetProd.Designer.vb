<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmzMstTargetProd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmzMstTargetProd))
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.btnNew = New DevExpress.XtraEditors.SimpleButton
        Me.pnl = New System.Windows.Forms.Panel
        Me.gControl = New DevExpress.XtraGrid.GridControl
        Me.gView = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.clmKegiatan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lkKegiatan = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.clmJumlah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clmKubik = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clmNilai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clmKeterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.clmStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ckStatus = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.pnlTools = New System.Windows.Forms.Panel
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.dtAkhir = New DevExpress.XtraEditors.DateEdit
        Me.dtMulai = New DevExpress.XtraEditors.DateEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.txtKeterangan = New System.Windows.Forms.TextBox
        Me.txtNomor = New System.Windows.Forms.TextBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnlTitle = New System.Windows.Forms.Panel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl.SuspendLayout()
        CType(Me.gControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lkKegiatan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ckStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTools.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.dtAkhir.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtMulai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtMulai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton4.Location = New System.Drawing.Point(373, 3)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton4.TabIndex = 17
        Me.SimpleButton4.Text = "Save"
        Me.SimpleButton4.Visible = False
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton3.Location = New System.Drawing.Point(697, 3)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton3.TabIndex = 16
        Me.SimpleButton3.Text = "Delete"
        Me.SimpleButton3.Visible = False
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton2.Location = New System.Drawing.Point(616, 3)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 15
        Me.SimpleButton2.Text = "Cancel"
        Me.SimpleButton2.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Location = New System.Drawing.Point(535, 3)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 14
        Me.SimpleButton1.Text = "Edit"
        Me.SimpleButton1.Visible = False
        '
        'btnNew
        '
        Me.btnNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNew.Location = New System.Drawing.Point(454, 3)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(75, 23)
        Me.btnNew.TabIndex = 13
        Me.btnNew.Text = "New"
        Me.btnNew.Visible = False
        '
        'pnl
        '
        Me.pnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl.Controls.Add(Me.gControl)
        Me.pnl.Controls.Add(Me.pnlTools)
        Me.pnl.Controls.Add(Me.pnlTitle)
        Me.pnl.Location = New System.Drawing.Point(12, 40)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(760, 438)
        Me.pnl.TabIndex = 18
        '
        'gControl
        '
        Me.gControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gControl.Location = New System.Drawing.Point(0, 83)
        Me.gControl.MainView = Me.gView
        Me.gControl.Name = "gControl"
        Me.gControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.ckStatus, Me.lkKegiatan})
        Me.gControl.Size = New System.Drawing.Size(760, 355)
        Me.gControl.TabIndex = 6
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
        Me.gView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.clmKegiatan, Me.clmJumlah, Me.clmKubik, Me.clmNilai, Me.clmKeterangan, Me.clmStatus})
        Me.gView.GridControl = Me.gControl
        Me.gView.Name = "gView"
        Me.gView.NewItemRowText = "Tambah data di sini"
        Me.gView.OptionsView.EnableAppearanceEvenRow = True
        Me.gView.OptionsView.EnableAppearanceOddRow = True
        Me.gView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gView.OptionsView.ShowGroupPanel = False
        Me.gView.PaintStyleName = "Skin"
        '
        'clmKegiatan
        '
        Me.clmKegiatan.AppearanceHeader.Options.UseTextOptions = True
        Me.clmKegiatan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clmKegiatan.Caption = "Kegiatan"
        Me.clmKegiatan.ColumnEdit = Me.lkKegiatan
        Me.clmKegiatan.FieldName = "kd_kegiatan"
        Me.clmKegiatan.Name = "clmKegiatan"
        Me.clmKegiatan.Visible = True
        Me.clmKegiatan.VisibleIndex = 0
        Me.clmKegiatan.Width = 161
        '
        'lkKegiatan
        '
        Me.lkKegiatan.AutoHeight = False
        Me.lkKegiatan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lkKegiatan.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Desc_Data", "Kegiatan")})
        Me.lkKegiatan.DisplayMember = "Desc_Data"
        Me.lkKegiatan.Name = "lkKegiatan"
        Me.lkKegiatan.NullText = "[Kegiatan]"
        Me.lkKegiatan.ValueMember = "Id_Data"
        '
        'clmJumlah
        '
        Me.clmJumlah.AppearanceHeader.Options.UseTextOptions = True
        Me.clmJumlah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clmJumlah.Caption = "Target (Indeks)"
        Me.clmJumlah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clmJumlah.FieldName = "jml_target"
        Me.clmJumlah.Name = "clmJumlah"
        Me.clmJumlah.Visible = True
        Me.clmJumlah.VisibleIndex = 1
        Me.clmJumlah.Width = 106
        '
        'clmKubik
        '
        Me.clmKubik.Caption = "Target (Kubik)"
        Me.clmKubik.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clmKubik.FieldName = "jml_target_kubik"
        Me.clmKubik.Name = "clmKubik"
        Me.clmKubik.Visible = True
        Me.clmKubik.VisibleIndex = 2
        '
        'clmNilai
        '
        Me.clmNilai.AppearanceHeader.Options.UseTextOptions = True
        Me.clmNilai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clmNilai.Caption = "Nilai"
        Me.clmNilai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.clmNilai.FieldName = "nilai"
        Me.clmNilai.Name = "clmNilai"
        Me.clmNilai.Width = 87
        '
        'clmKeterangan
        '
        Me.clmKeterangan.AppearanceHeader.Options.UseTextOptions = True
        Me.clmKeterangan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clmKeterangan.Caption = "Keterangan"
        Me.clmKeterangan.FieldName = "keterangan"
        Me.clmKeterangan.Name = "clmKeterangan"
        Me.clmKeterangan.Width = 103
        '
        'clmStatus
        '
        Me.clmStatus.AppearanceHeader.Options.UseTextOptions = True
        Me.clmStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.clmStatus.Caption = "Status"
        Me.clmStatus.ColumnEdit = Me.ckStatus
        Me.clmStatus.FieldName = "rec_stat"
        Me.clmStatus.Name = "clmStatus"
        Me.clmStatus.Visible = True
        Me.clmStatus.VisibleIndex = 3
        Me.clmStatus.Width = 70
        '
        'ckStatus
        '
        Me.ckStatus.AutoHeight = False
        Me.ckStatus.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.ckStatus.DisplayValueChecked = "Y"
        Me.ckStatus.DisplayValueUnchecked = "N"
        Me.ckStatus.Name = "ckStatus"
        Me.ckStatus.ValueChecked = "Y"
        Me.ckStatus.ValueUnchecked = "N"
        '
        'pnlTools
        '
        Me.pnlTools.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTools.Controls.Add(Me.Panel1)
        Me.pnlTools.Controls.Add(Me.Panel2)
        Me.pnlTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTools.Location = New System.Drawing.Point(0, 31)
        Me.pnlTools.Name = "pnlTools"
        Me.pnlTools.Size = New System.Drawing.Size(760, 52)
        Me.pnlTools.TabIndex = 5
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(376, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(381, 52)
        Me.Panel1.TabIndex = 6
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.dtAkhir)
        Me.Panel5.Controls.Add(Me.dtMulai)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(156, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(222, 52)
        Me.Panel5.TabIndex = 1
        '
        'dtAkhir
        '
        Me.dtAkhir.Dock = System.Windows.Forms.DockStyle.Top
        Me.dtAkhir.EditValue = Nothing
        Me.dtAkhir.Location = New System.Drawing.Point(0, 20)
        Me.dtAkhir.Name = "dtAkhir"
        Me.dtAkhir.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtAkhir.Properties.Appearance.Options.UseBackColor = True
        Me.dtAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtAkhir.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtAkhir.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtAkhir.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtAkhir.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtAkhir.Size = New System.Drawing.Size(222, 20)
        Me.dtAkhir.TabIndex = 3
        Me.dtAkhir.ToolTip = "Format : dd/mm/yyyy"
        '
        'dtMulai
        '
        Me.dtMulai.Dock = System.Windows.Forms.DockStyle.Top
        Me.dtMulai.EditValue = Nothing
        Me.dtMulai.Location = New System.Drawing.Point(0, 0)
        Me.dtMulai.Name = "dtMulai"
        Me.dtMulai.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtMulai.Properties.Appearance.Options.UseBackColor = True
        Me.dtMulai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtMulai.Properties.DisplayFormat.FormatString = "dd/MM/yyyy"
        Me.dtMulai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dtMulai.Properties.Mask.EditMask = "dd/MM/yyyy"
        Me.dtMulai.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.dtMulai.Size = New System.Drawing.Size(222, 20)
        Me.dtMulai.TabIndex = 2
        Me.dtMulai.ToolTip = "Format : dd/mm/yyyy"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(156, 52)
        Me.Panel6.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Tanggal Berakhir : "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tanggal Mulai : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(376, 52)
        Me.Panel2.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtKeterangan)
        Me.Panel4.Controls.Add(Me.txtNomor)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(141, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(235, 52)
        Me.Panel4.TabIndex = 1
        '
        'txtKeterangan
        '
        Me.txtKeterangan.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKeterangan.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtKeterangan.Location = New System.Drawing.Point(0, 20)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(235, 20)
        Me.txtKeterangan.TabIndex = 2
        '
        'txtNomor
        '
        Me.txtNomor.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomor.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNomor.Location = New System.Drawing.Point(0, 0)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Size = New System.Drawing.Size(235, 20)
        Me.txtNomor.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(141, 52)
        Me.Panel3.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Keterangan : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nomor : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.pnlTitle.Size = New System.Drawing.Size(760, 31)
        Me.pnlTitle.TabIndex = 4
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTitle.Font = New System.Drawing.Font("Arial Narrow", 15.75!)
        Me.lblTitle.ForeColor = System.Drawing.Color.Gold
        Me.lblTitle.Location = New System.Drawing.Point(37, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(312, 29)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "MASTER TARGET PRODUKSI"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 29)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'frmzMstTargetProd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 518)
        Me.Controls.Add(Me.pnl)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.btnNew)
        Me.Name = "frmzMstTargetProd"
        Me.Text = "frmzMstTargetProd"
        Me.pnl.ResumeLayout(False)
        CType(Me.gControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lkKegiatan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ckStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTools.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.dtAkhir.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtMulai.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtMulai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.pnlTitle.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnNew As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents gControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents gView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents clmKegiatan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lkKegiatan As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents clmJumlah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmNilai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmKeterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents clmStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ckStatus As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents pnlTools As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents dtAkhir As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dtMulai As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents txtNomor As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents clmKubik As DevExpress.XtraGrid.Columns.GridColumn
End Class
