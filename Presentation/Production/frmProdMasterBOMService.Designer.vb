<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProdMasterBOMService
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProdMasterBOMService))
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.GC_Biaya = New DevExpress.XtraGrid.GridControl
        Me.GV_BIAYA = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.ColNamaRek = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LEBiaya = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.ColNilai = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ColStatus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepStatusBiaya = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.GC_Bahan = New DevExpress.XtraGrid.GridControl
        Me.GV_BahanService = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.NmBarang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.LE_Barang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.jumlah = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Status = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepStatus = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.pnlTools = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.txt_waktu = New DevExpress.XtraEditors.TextEdit
        Me.txtNoDokBOM = New DevExpress.XtraEditors.TextEdit
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Txt_namaService = New DevExpress.XtraEditors.TextEdit
        Me.txt_kdService = New DevExpress.XtraEditors.TextEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.pnlTitle = New System.Windows.Forms.Panel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.GC_Biaya, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_BIAYA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LEBiaya, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepStatusBiaya, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.GC_Bahan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_BahanService, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LE_Barang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTools.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.txt_waktu.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNoDokBOM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Txt_namaService.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_kdService.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl.Controls.Add(Me.Panel6)
        Me.pnl.Controls.Add(Me.Panel5)
        Me.pnl.Controls.Add(Me.pnlTools)
        Me.pnl.Controls.Add(Me.pnlTitle)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(920, 537)
        Me.pnl.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel6.Controls.Add(Me.GC_Biaya)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(0, 407)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(920, 130)
        Me.Panel6.TabIndex = 7
        '
        'GC_Biaya
        '
        Me.GC_Biaya.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC_Biaya.Location = New System.Drawing.Point(0, 0)
        Me.GC_Biaya.MainView = Me.GV_BIAYA
        Me.GC_Biaya.Name = "GC_Biaya"
        Me.GC_Biaya.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemLookUpEdit1, Me.LEBiaya, Me.RepStatusBiaya})
        Me.GC_Biaya.Size = New System.Drawing.Size(920, 130)
        Me.GC_Biaya.TabIndex = 1
        Me.GC_Biaya.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_BIAYA})
        '
        'GV_BIAYA
        '
        Me.GV_BIAYA.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BIAYA.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_BIAYA.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BIAYA.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV_BIAYA.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_BIAYA.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV_BIAYA.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV_BIAYA.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV_BIAYA.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_BIAYA.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GV_BIAYA.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_BIAYA.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV_BIAYA.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_BIAYA.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV_BIAYA.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV_BIAYA.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV_BIAYA.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GV_BIAYA.Appearance.Empty.Options.UseBackColor = True
        Me.GV_BIAYA.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BIAYA.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV_BIAYA.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV_BIAYA.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV_BIAYA.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BIAYA.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_BIAYA.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BIAYA.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV_BIAYA.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_BIAYA.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV_BIAYA.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV_BIAYA.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV_BIAYA.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV_BIAYA.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GV_BIAYA.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV_BIAYA.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV_BIAYA.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GV_BIAYA.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV_BIAYA.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV_BIAYA.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV_BIAYA.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV_BIAYA.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV_BIAYA.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GV_BIAYA.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV_BIAYA.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV_BIAYA.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV_BIAYA.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BIAYA.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_BIAYA.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BIAYA.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_BIAYA.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_BIAYA.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV_BIAYA.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV_BIAYA.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV_BIAYA.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_BIAYA.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_BIAYA.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GV_BIAYA.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV_BIAYA.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV_BIAYA.Appearance.GroupButton.Options.UseForeColor = True
        Me.GV_BIAYA.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_BIAYA.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_BIAYA.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV_BIAYA.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV_BIAYA.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV_BIAYA.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV_BIAYA.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV_BIAYA.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BIAYA.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV_BIAYA.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV_BIAYA.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_BIAYA.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_BIAYA.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GV_BIAYA.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV_BIAYA.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV_BIAYA.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV_BIAYA.Appearance.GroupRow.Options.UseFont = True
        Me.GV_BIAYA.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV_BIAYA.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BIAYA.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_BIAYA.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BIAYA.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_BIAYA.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_BIAYA.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV_BIAYA.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV_BIAYA.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV_BIAYA.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_BIAYA.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_BIAYA.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV_BIAYA.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV_BIAYA.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV_BIAYA.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV_BIAYA.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GV_BIAYA.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV_BIAYA.Appearance.OddRow.Options.UseBackColor = True
        Me.GV_BIAYA.Appearance.OddRow.Options.UseForeColor = True
        Me.GV_BIAYA.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_BIAYA.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV_BIAYA.Appearance.Preview.Options.UseBackColor = True
        Me.GV_BIAYA.Appearance.Preview.Options.UseForeColor = True
        Me.GV_BIAYA.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GV_BIAYA.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV_BIAYA.Appearance.Row.Options.UseBackColor = True
        Me.GV_BIAYA.Appearance.Row.Options.UseForeColor = True
        Me.GV_BIAYA.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GV_BIAYA.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV_BIAYA.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GV_BIAYA.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GV_BIAYA.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_BIAYA.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV_BIAYA.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV_BIAYA.Appearance.VertLine.Options.UseBackColor = True
        Me.GV_BIAYA.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ColNamaRek, Me.ColNilai, Me.ColStatus})
        Me.GV_BIAYA.GridControl = Me.GC_Biaya
        Me.GV_BIAYA.Name = "GV_BIAYA"
        Me.GV_BIAYA.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_BIAYA.OptionsView.EnableAppearanceOddRow = True
        Me.GV_BIAYA.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV_BIAYA.OptionsView.ShowGroupPanel = False
        Me.GV_BIAYA.OptionsView.ShowViewCaption = True
        Me.GV_BIAYA.ViewCaption = "BIAYA SERVICE"
        '
        'ColNamaRek
        '
        Me.ColNamaRek.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNamaRek.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNamaRek.Caption = "Nama Rekening"
        Me.ColNamaRek.ColumnEdit = Me.LEBiaya
        Me.ColNamaRek.FieldName = "kd_rek"
        Me.ColNamaRek.Name = "ColNamaRek"
        Me.ColNamaRek.Visible = True
        Me.ColNamaRek.VisibleIndex = 0
        Me.ColNamaRek.Width = 380
        '
        'LEBiaya
        '
        Me.LEBiaya.AutoHeight = False
        Me.LEBiaya.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LEBiaya.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("kd_buku_besar", "Kode Rekening Buku Besar"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("nm_buku_besar", "Nama Rekening Buku Besar")})
        Me.LEBiaya.DisplayMember = "nm_buku_besar"
        Me.LEBiaya.Name = "LEBiaya"
        Me.LEBiaya.NullText = "Nama Rekening"
        Me.LEBiaya.ValueMember = "kd_buku_besar"
        '
        'ColNilai
        '
        Me.ColNilai.AppearanceCell.Options.UseTextOptions = True
        Me.ColNilai.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.ColNilai.AppearanceHeader.Options.UseTextOptions = True
        Me.ColNilai.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColNilai.Caption = "Nilai (Rp.)"
        Me.ColNilai.DisplayFormat.FormatString = "c2"
        Me.ColNilai.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.ColNilai.FieldName = "nilai"
        Me.ColNilai.Name = "ColNilai"
        Me.ColNilai.Visible = True
        Me.ColNilai.VisibleIndex = 1
        Me.ColNilai.Width = 330
        '
        'ColStatus
        '
        Me.ColStatus.AppearanceCell.Options.UseTextOptions = True
        Me.ColStatus.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColStatus.AppearanceHeader.Options.UseTextOptions = True
        Me.ColStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.ColStatus.Caption = "Status"
        Me.ColStatus.ColumnEdit = Me.RepStatusBiaya
        Me.ColStatus.FieldName = "rec_stat"
        Me.ColStatus.Name = "ColStatus"
        Me.ColStatus.Visible = True
        Me.ColStatus.VisibleIndex = 2
        Me.ColStatus.Width = 213
        '
        'RepStatusBiaya
        '
        Me.RepStatusBiaya.AutoHeight = False
        Me.RepStatusBiaya.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.RepStatusBiaya.DisplayValueChecked = "Y"
        Me.RepStatusBiaya.DisplayValueUnchecked = "T"
        Me.RepStatusBiaya.Name = "RepStatusBiaya"
        Me.RepStatusBiaya.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepStatusBiaya.ValueChecked = "Y"
        Me.RepStatusBiaya.ValueUnchecked = "T"
        '
        'RepositoryItemLookUpEdit1
        '
        Me.RepositoryItemLookUpEdit1.AutoHeight = False
        Me.RepositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", "Kode Barang"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.RepositoryItemLookUpEdit1.DisplayMember = "Nama_Barang"
        Me.RepositoryItemLookUpEdit1.Name = "RepositoryItemLookUpEdit1"
        Me.RepositoryItemLookUpEdit1.NullText = "Nama Barang"
        Me.RepositoryItemLookUpEdit1.ValueMember = "Kode_Barang"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Controls.Add(Me.GC_Bahan)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 109)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(920, 298)
        Me.Panel5.TabIndex = 6
        '
        'GC_Bahan
        '
        Me.GC_Bahan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC_Bahan.Location = New System.Drawing.Point(0, 0)
        Me.GC_Bahan.MainView = Me.GV_BahanService
        Me.GC_Bahan.Name = "GC_Bahan"
        Me.GC_Bahan.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.LE_Barang, Me.RepStatus})
        Me.GC_Bahan.Size = New System.Drawing.Size(920, 298)
        Me.GC_Bahan.TabIndex = 0
        Me.GC_Bahan.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_BahanService})
        '
        'GV_BahanService
        '
        Me.GV_BahanService.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BahanService.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_BahanService.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BahanService.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV_BahanService.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_BahanService.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV_BahanService.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV_BahanService.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV_BahanService.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_BahanService.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GV_BahanService.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_BahanService.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV_BahanService.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_BahanService.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV_BahanService.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV_BahanService.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV_BahanService.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GV_BahanService.Appearance.Empty.Options.UseBackColor = True
        Me.GV_BahanService.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BahanService.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV_BahanService.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV_BahanService.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV_BahanService.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BahanService.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_BahanService.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BahanService.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV_BahanService.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_BahanService.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV_BahanService.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV_BahanService.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV_BahanService.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV_BahanService.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GV_BahanService.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV_BahanService.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV_BahanService.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GV_BahanService.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV_BahanService.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV_BahanService.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV_BahanService.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV_BahanService.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV_BahanService.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GV_BahanService.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV_BahanService.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV_BahanService.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV_BahanService.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BahanService.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_BahanService.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BahanService.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_BahanService.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_BahanService.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV_BahanService.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV_BahanService.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV_BahanService.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_BahanService.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_BahanService.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GV_BahanService.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV_BahanService.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV_BahanService.Appearance.GroupButton.Options.UseForeColor = True
        Me.GV_BahanService.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_BahanService.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_BahanService.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV_BahanService.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV_BahanService.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV_BahanService.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV_BahanService.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV_BahanService.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BahanService.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV_BahanService.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV_BahanService.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_BahanService.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GV_BahanService.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GV_BahanService.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV_BahanService.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV_BahanService.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV_BahanService.Appearance.GroupRow.Options.UseFont = True
        Me.GV_BahanService.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV_BahanService.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BahanService.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_BahanService.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GV_BahanService.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_BahanService.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GV_BahanService.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV_BahanService.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV_BahanService.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV_BahanService.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GV_BahanService.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GV_BahanService.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV_BahanService.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV_BahanService.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV_BahanService.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV_BahanService.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GV_BahanService.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV_BahanService.Appearance.OddRow.Options.UseBackColor = True
        Me.GV_BahanService.Appearance.OddRow.Options.UseForeColor = True
        Me.GV_BahanService.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GV_BahanService.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GV_BahanService.Appearance.Preview.Options.UseBackColor = True
        Me.GV_BahanService.Appearance.Preview.Options.UseForeColor = True
        Me.GV_BahanService.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GV_BahanService.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV_BahanService.Appearance.Row.Options.UseBackColor = True
        Me.GV_BahanService.Appearance.Row.Options.UseForeColor = True
        Me.GV_BahanService.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GV_BahanService.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV_BahanService.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GV_BahanService.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GV_BahanService.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_BahanService.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GV_BahanService.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GV_BahanService.Appearance.VertLine.Options.UseBackColor = True
        Me.GV_BahanService.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NmBarang, Me.Satuan, Me.jumlah, Me.Status})
        Me.GV_BahanService.GridControl = Me.GC_Bahan
        Me.GV_BahanService.Name = "GV_BahanService"
        Me.GV_BahanService.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_BahanService.OptionsView.EnableAppearanceOddRow = True
        Me.GV_BahanService.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV_BahanService.OptionsView.ShowGroupPanel = False
        Me.GV_BahanService.OptionsView.ShowViewCaption = True
        Me.GV_BahanService.ViewCaption = "BAHAN SERVICE"
        '
        'NmBarang
        '
        Me.NmBarang.AppearanceCell.Options.UseTextOptions = True
        Me.NmBarang.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.NmBarang.AppearanceHeader.Options.UseTextOptions = True
        Me.NmBarang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.NmBarang.Caption = "Nama Barang"
        Me.NmBarang.ColumnEdit = Me.LE_Barang
        Me.NmBarang.FieldName = "kd_barang"
        Me.NmBarang.Name = "NmBarang"
        Me.NmBarang.Visible = True
        Me.NmBarang.VisibleIndex = 0
        Me.NmBarang.Width = 433
        '
        'LE_Barang
        '
        Me.LE_Barang.AutoHeight = False
        Me.LE_Barang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LE_Barang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", "Kode Barang"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", "Nama Barang")})
        Me.LE_Barang.DisplayMember = "Nama_Barang"
        Me.LE_Barang.Name = "LE_Barang"
        Me.LE_Barang.NullText = "Nama Barang"
        Me.LE_Barang.ValueMember = "Kode_Barang"
        '
        'Satuan
        '
        Me.Satuan.AppearanceCell.Options.UseTextOptions = True
        Me.Satuan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Satuan.AppearanceHeader.Options.UseTextOptions = True
        Me.Satuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Satuan.Caption = "Satuan"
        Me.Satuan.FieldName = "satuan"
        Me.Satuan.Name = "Satuan"
        Me.Satuan.OptionsColumn.AllowEdit = False
        Me.Satuan.Visible = True
        Me.Satuan.VisibleIndex = 1
        Me.Satuan.Width = 188
        '
        'jumlah
        '
        Me.jumlah.AppearanceCell.Options.UseTextOptions = True
        Me.jumlah.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.jumlah.AppearanceHeader.Options.UseTextOptions = True
        Me.jumlah.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.jumlah.Caption = "Jumlah"
        Me.jumlah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.jumlah.FieldName = "jumlah"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Visible = True
        Me.jumlah.VisibleIndex = 2
        Me.jumlah.Width = 176
        '
        'Status
        '
        Me.Status.AppearanceCell.Options.UseTextOptions = True
        Me.Status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Status.AppearanceHeader.Options.UseTextOptions = True
        Me.Status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Status.Caption = "Status"
        Me.Status.ColumnEdit = Me.RepStatus
        Me.Status.FieldName = "rec_stat"
        Me.Status.Name = "Status"
        Me.Status.Visible = True
        Me.Status.VisibleIndex = 3
        Me.Status.Width = 126
        '
        'RepStatus
        '
        Me.RepStatus.AutoHeight = False
        Me.RepStatus.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.RepStatus.DisplayValueChecked = "Y"
        Me.RepStatus.DisplayValueUnchecked = "T"
        Me.RepStatus.Name = "RepStatus"
        Me.RepStatus.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepStatus.ValueChecked = "Y"
        Me.RepStatus.ValueUnchecked = "T"
        '
        'pnlTools
        '
        Me.pnlTools.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTools.Controls.Add(Me.Panel4)
        Me.pnlTools.Controls.Add(Me.Panel3)
        Me.pnlTools.Controls.Add(Me.Panel2)
        Me.pnlTools.Controls.Add(Me.Panel1)
        Me.pnlTools.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTools.Location = New System.Drawing.Point(0, 34)
        Me.pnlTools.Name = "pnlTools"
        Me.pnlTools.Size = New System.Drawing.Size(920, 75)
        Me.pnlTools.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txt_waktu)
        Me.Panel4.Controls.Add(Me.txtNoDokBOM)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(551, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(260, 75)
        Me.Panel4.TabIndex = 7
        '
        'txt_waktu
        '
        Me.txt_waktu.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_waktu.Location = New System.Drawing.Point(0, 20)
        Me.txt_waktu.Name = "txt_waktu"
        Me.txt_waktu.Size = New System.Drawing.Size(260, 20)
        Me.txt_waktu.TabIndex = 4
        '
        'txtNoDokBOM
        '
        Me.txtNoDokBOM.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNoDokBOM.Location = New System.Drawing.Point(0, 0)
        Me.txtNoDokBOM.Name = "txtNoDokBOM"
        Me.txtNoDokBOM.Size = New System.Drawing.Size(260, 20)
        Me.txtNoDokBOM.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(460, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(91, 75)
        Me.Panel3.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Waktu : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "No. Dokumen : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.Controls.Add(Me.Txt_namaService)
        Me.Panel2.Controls.Add(Me.txt_kdService)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(149, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(311, 75)
        Me.Panel2.TabIndex = 5
        '
        'Txt_namaService
        '
        Me.Txt_namaService.Dock = System.Windows.Forms.DockStyle.Top
        Me.Txt_namaService.Location = New System.Drawing.Point(0, 20)
        Me.Txt_namaService.Name = "Txt_namaService"
        Me.Txt_namaService.Size = New System.Drawing.Size(311, 20)
        Me.Txt_namaService.TabIndex = 5
        '
        'txt_kdService
        '
        Me.txt_kdService.Dock = System.Windows.Forms.DockStyle.Top
        Me.txt_kdService.Location = New System.Drawing.Point(0, 0)
        Me.txt_kdService.Name = "txt_kdService"
        Me.txt_kdService.Properties.Appearance.BackColor = System.Drawing.Color.LightGreen
        Me.txt_kdService.Properties.Appearance.Options.UseBackColor = True
        Me.txt_kdService.Properties.ReadOnly = True
        Me.txt_kdService.Size = New System.Drawing.Size(311, 20)
        Me.txt_kdService.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(149, 75)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nama Service : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Kode Service : "
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
        Me.pnlTitle.Size = New System.Drawing.Size(920, 34)
        Me.pnlTitle.TabIndex = 4
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTitle.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.Gold
        Me.lblTitle.Location = New System.Drawing.Point(37, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(271, 32)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "MASTER BOM SERVICE"
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
        'frmProdMasterBOMService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 554)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmProdMasterBOMService"
        Me.pnl.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        CType(Me.GC_Biaya, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_BIAYA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LEBiaya, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepStatusBiaya, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.GC_Bahan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_BahanService, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LE_Barang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTools.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.txt_waktu.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNoDokBOM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.Txt_namaService.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_kdService.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.pnlTitle.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTools As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtNoDokBOM As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents GC_Bahan As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_BahanService As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NmBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LE_Barang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents jumlah As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GC_Biaya As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_BIAYA As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ColNamaRek As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents ColNilai As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ColStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_waktu As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Txt_namaService As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_kdService As DevExpress.XtraEditors.TextEdit
    Friend WithEvents RepStatus As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents LEBiaya As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RepStatusBiaya As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Status As DevExpress.XtraGrid.Columns.GridColumn
End Class
