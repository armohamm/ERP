<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetHarga
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
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetHarga))
        Me.pilih = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repcheck = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.repNum = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.pnl = New System.Windows.Forms.Panel
        Me.GcMstHarga = New DevExpress.XtraGrid.GridControl
        Me.GvMstHarga = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Nama_Barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kode_Barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me._jenisbrg = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_jnbrg = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me._merk = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RL_merk = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.End_Date = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepTgl = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.Rec_stat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repCombo = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.tipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.subTipe = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repSubTipe = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Ukuran = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repUkuran = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Kain = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repKain = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.HargaRpBaru = New DevExpress.XtraGrid.Columns.GridColumn
        Me.HargaUsdBaru = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.txtCari = New DevExpress.XtraEditors.TextEdit
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnDel = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnTerapkan = New System.Windows.Forms.Button
        Me.btnTutup = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.repcheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        CType(Me.GcMstHarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvMstHarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_jnbrg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RL_merk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepTgl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepTgl.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repCombo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repSubTipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repUkuran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repKain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.txtCari.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pilih
        '
        Me.pilih.Caption = "Pilih"
        Me.pilih.ColumnEdit = Me.repcheck
        Me.pilih.FieldName = "pilih"
        Me.pilih.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.pilih.Name = "pilih"
        Me.pilih.Visible = True
        Me.pilih.VisibleIndex = 9
        Me.pilih.Width = 50
        '
        'repcheck
        '
        Me.repcheck.AutoHeight = False
        Me.repcheck.Name = "repcheck"
        Me.repcheck.ValueChecked = "1"
        Me.repcheck.ValueUnchecked = "0"
        '
        'repNum
        '
        Me.repNum.AutoHeight = False
        Me.repNum.DisplayFormat.FormatString = "n2"
        Me.repNum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repNum.EditFormat.FormatString = "n2"
        Me.repNum.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repNum.Name = "repNum"
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcMstHarga)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1038, 627)
        Me.pnl.TabIndex = 0
        '
        'GcMstHarga
        '
        Me.GcMstHarga.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcMstHarga.Location = New System.Drawing.Point(0, 57)
        Me.GcMstHarga.MainView = Me.GvMstHarga
        Me.GcMstHarga.Name = "GcMstHarga"
        Me.GcMstHarga.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repCombo, Me.RL_jnbrg, Me.RL_merk, Me.repNum, Me.RepTgl, Me.repTipe, Me.repSubTipe, Me.repUkuran, Me.repKain, Me.repcheck})
        Me.GcMstHarga.Size = New System.Drawing.Size(1038, 533)
        Me.GcMstHarga.TabIndex = 137
        Me.GcMstHarga.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvMstHarga})
        '
        'GvMstHarga
        '
        Me.GvMstHarga.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GvMstHarga.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GvMstHarga.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.GvMstHarga.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GvMstHarga.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GvMstHarga.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GvMstHarga.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMstHarga.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMstHarga.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GvMstHarga.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GvMstHarga.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GvMstHarga.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GvMstHarga.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMstHarga.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GvMstHarga.Appearance.Empty.Options.UseBackColor = True
        Me.GvMstHarga.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMstHarga.Appearance.EvenRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMstHarga.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GvMstHarga.Appearance.EvenRow.Options.UseBackColor = True
        Me.GvMstHarga.Appearance.EvenRow.Options.UseBorderColor = True
        Me.GvMstHarga.Appearance.EvenRow.Options.UseForeColor = True
        Me.GvMstHarga.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GvMstHarga.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GvMstHarga.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.GvMstHarga.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GvMstHarga.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GvMstHarga.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GvMstHarga.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMstHarga.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GvMstHarga.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GvMstHarga.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GvMstHarga.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GvMstHarga.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.GvMstHarga.Appearance.FixedLine.Options.UseBackColor = True
        Me.GvMstHarga.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GvMstHarga.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GvMstHarga.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GvMstHarga.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GvMstHarga.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.GvMstHarga.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.GvMstHarga.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GvMstHarga.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GvMstHarga.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.GvMstHarga.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GvMstHarga.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GvMstHarga.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GvMstHarga.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GvMstHarga.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GvMstHarga.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GvMstHarga.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GvMstHarga.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GvMstHarga.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GvMstHarga.Appearance.GroupButton.Options.UseBackColor = True
        Me.GvMstHarga.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GvMstHarga.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMstHarga.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMstHarga.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GvMstHarga.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GvMstHarga.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GvMstHarga.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GvMstHarga.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMstHarga.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GvMstHarga.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GvMstHarga.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GvMstHarga.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GvMstHarga.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMstHarga.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMstHarga.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GvMstHarga.Appearance.GroupRow.Options.UseBackColor = True
        Me.GvMstHarga.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GvMstHarga.Appearance.GroupRow.Options.UseForeColor = True
        Me.GvMstHarga.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMstHarga.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(139, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvMstHarga.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GvMstHarga.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GvMstHarga.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GvMstHarga.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GvMstHarga.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.GvMstHarga.Appearance.HideSelectionRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GvMstHarga.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMstHarga.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GvMstHarga.Appearance.HideSelectionRow.Options.UseBorderColor = True
        Me.GvMstHarga.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GvMstHarga.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GvMstHarga.Appearance.HorzLine.Options.UseBackColor = True
        Me.GvMstHarga.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMstHarga.Appearance.OddRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMstHarga.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GvMstHarga.Appearance.OddRow.Options.UseBackColor = True
        Me.GvMstHarga.Appearance.OddRow.Options.UseBorderColor = True
        Me.GvMstHarga.Appearance.OddRow.Options.UseForeColor = True
        Me.GvMstHarga.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GvMstHarga.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GvMstHarga.Appearance.Preview.Options.UseFont = True
        Me.GvMstHarga.Appearance.Preview.Options.UseForeColor = True
        Me.GvMstHarga.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMstHarga.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GvMstHarga.Appearance.Row.Options.UseBackColor = True
        Me.GvMstHarga.Appearance.Row.Options.UseForeColor = True
        Me.GvMstHarga.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(236, Byte), Integer), CType(CType(246, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvMstHarga.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GvMstHarga.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GvMstHarga.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(83, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.GvMstHarga.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GvMstHarga.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GvMstHarga.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GvMstHarga.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GvMstHarga.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GvMstHarga.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GvMstHarga.Appearance.VertLine.Options.UseBackColor = True
        Me.GvMstHarga.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Nama_Barang, Me.Kode_Barang, Me._jenisbrg, Me._merk, Me.End_Date, Me.Rec_stat, Me.tipe, Me.subTipe, Me.Ukuran, Me.Kain, Me.HargaRpBaru, Me.HargaUsdBaru, Me.pilih})
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.Column = Me.pilih
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "1"
        Me.GvMstHarga.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
        Me.GvMstHarga.GridControl = Me.GcMstHarga
        Me.GvMstHarga.GroupPanelText = "Geser nama kolom kemari untuk mengelompokkan data."
        Me.GvMstHarga.Name = "GvMstHarga"
        Me.GvMstHarga.OptionsView.ColumnAutoWidth = False
        Me.GvMstHarga.OptionsView.EnableAppearanceEvenRow = True
        Me.GvMstHarga.OptionsView.EnableAppearanceOddRow = True
        Me.GvMstHarga.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.GvMstHarga.OptionsView.ShowGroupPanel = False
        '
        'Nama_Barang
        '
        Me.Nama_Barang.Caption = "Nama Barang"
        Me.Nama_Barang.FieldName = "Nama_Barang"
        Me.Nama_Barang.Name = "Nama_Barang"
        Me.Nama_Barang.OptionsColumn.AllowEdit = False
        Me.Nama_Barang.OptionsColumn.AllowFocus = False
        Me.Nama_Barang.Width = 465
        '
        'Kode_Barang
        '
        Me.Kode_Barang.Caption = "Kode Barang"
        Me.Kode_Barang.FieldName = "Kode_Barang"
        Me.Kode_Barang.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.Kode_Barang.Name = "Kode_Barang"
        Me.Kode_Barang.OptionsColumn.AllowEdit = False
        Me.Kode_Barang.OptionsColumn.ReadOnly = True
        Me.Kode_Barang.OptionsFilter.AllowFilter = False
        Me.Kode_Barang.Width = 358
        '
        '_jenisbrg
        '
        Me._jenisbrg.Caption = "Jenis Barang"
        Me._jenisbrg.ColumnEdit = Me.RL_jnbrg
        Me._jenisbrg.FieldName = "kd_jenis"
        Me._jenisbrg.Name = "_jenisbrg"
        Me._jenisbrg.OptionsColumn.AllowEdit = False
        Me._jenisbrg.OptionsColumn.AllowFocus = False
        Me._jenisbrg.OptionsColumn.ReadOnly = True
        Me._jenisbrg.Visible = True
        Me._jenisbrg.VisibleIndex = 0
        Me._jenisbrg.Width = 120
        '
        'RL_jnbrg
        '
        Me.RL_jnbrg.AutoHeight = False
        Me.RL_jnbrg.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_jnbrg.Name = "RL_jnbrg"
        Me.RL_jnbrg.NullText = ""
        '
        '_merk
        '
        Me._merk.Caption = "Merk"
        Me._merk.ColumnEdit = Me.RL_merk
        Me._merk.FieldName = "kd_merk"
        Me._merk.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me._merk.Name = "_merk"
        Me._merk.OptionsColumn.AllowEdit = False
        Me._merk.OptionsColumn.AllowFocus = False
        Me._merk.OptionsColumn.ReadOnly = True
        Me._merk.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.[Like]
        Me._merk.OptionsFilter.ImmediateUpdateAutoFilter = False
        Me._merk.Visible = True
        Me._merk.VisibleIndex = 1
        Me._merk.Width = 125
        '
        'RL_merk
        '
        Me.RL_merk.AutoHeight = False
        Me.RL_merk.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RL_merk.Name = "RL_merk"
        Me.RL_merk.NullText = ""
        '
        'End_Date
        '
        Me.End_Date.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.End_Date.AppearanceHeader.Options.UseFont = True
        Me.End_Date.Caption = "Tgl Berlaku"
        Me.End_Date.ColumnEdit = Me.RepTgl
        Me.End_Date.FieldName = "end_date"
        Me.End_Date.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.End_Date.Name = "End_Date"
        Me.End_Date.Visible = True
        Me.End_Date.VisibleIndex = 8
        Me.End_Date.Width = 98
        '
        'RepTgl
        '
        Me.RepTgl.AutoHeight = False
        Me.RepTgl.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepTgl.Name = "RepTgl"
        Me.RepTgl.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'Rec_stat
        '
        Me.Rec_stat.Caption = "Status"
        Me.Rec_stat.ColumnEdit = Me.repCombo
        Me.Rec_stat.FieldName = "Rec_Stat"
        Me.Rec_stat.Name = "Rec_stat"
        Me.Rec_stat.Width = 88
        '
        'repCombo
        '
        Me.repCombo.AutoHeight = False
        Me.repCombo.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repCombo.Items.AddRange(New Object() {"Y", "T"})
        Me.repCombo.Name = "repCombo"
        '
        'tipe
        '
        Me.tipe.Caption = "Tipe"
        Me.tipe.ColumnEdit = Me.repTipe
        Me.tipe.FieldName = "kd_tipe"
        Me.tipe.Name = "tipe"
        Me.tipe.OptionsColumn.AllowEdit = False
        Me.tipe.OptionsColumn.AllowFocus = False
        Me.tipe.Visible = True
        Me.tipe.VisibleIndex = 2
        Me.tipe.Width = 136
        '
        'repTipe
        '
        Me.repTipe.AutoHeight = False
        Me.repTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repTipe.Name = "repTipe"
        '
        'subTipe
        '
        Me.subTipe.Caption = "Sub Tipe"
        Me.subTipe.ColumnEdit = Me.repSubTipe
        Me.subTipe.FieldName = "kd_sub_tipe"
        Me.subTipe.Name = "subTipe"
        Me.subTipe.OptionsColumn.AllowEdit = False
        Me.subTipe.OptionsColumn.AllowFocus = False
        Me.subTipe.Visible = True
        Me.subTipe.VisibleIndex = 3
        Me.subTipe.Width = 119
        '
        'repSubTipe
        '
        Me.repSubTipe.AutoHeight = False
        Me.repSubTipe.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repSubTipe.Name = "repSubTipe"
        '
        'Ukuran
        '
        Me.Ukuran.Caption = "Ukuran"
        Me.Ukuran.ColumnEdit = Me.repUkuran
        Me.Ukuran.FieldName = "kd_ukuran"
        Me.Ukuran.Name = "Ukuran"
        Me.Ukuran.OptionsColumn.AllowEdit = False
        Me.Ukuran.OptionsColumn.AllowFocus = False
        Me.Ukuran.Visible = True
        Me.Ukuran.VisibleIndex = 4
        Me.Ukuran.Width = 101
        '
        'repUkuran
        '
        Me.repUkuran.AutoHeight = False
        Me.repUkuran.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repUkuran.Name = "repUkuran"
        '
        'Kain
        '
        Me.Kain.Caption = "Kain"
        Me.Kain.ColumnEdit = Me.repKain
        Me.Kain.FieldName = "kd_kain"
        Me.Kain.Name = "Kain"
        Me.Kain.OptionsColumn.AllowEdit = False
        Me.Kain.OptionsColumn.AllowFocus = False
        Me.Kain.Visible = True
        Me.Kain.VisibleIndex = 5
        Me.Kain.Width = 99
        '
        'repKain
        '
        Me.repKain.AutoHeight = False
        Me.repKain.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repKain.Name = "repKain"
        '
        'HargaRpBaru
        '
        Me.HargaRpBaru.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.HargaRpBaru.AppearanceCell.Options.UseBackColor = True
        Me.HargaRpBaru.Caption = "Harga Rp"
        Me.HargaRpBaru.ColumnEdit = Me.repNum
        Me.HargaRpBaru.FieldName = "rp_new"
        Me.HargaRpBaru.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.HargaRpBaru.Name = "HargaRpBaru"
        Me.HargaRpBaru.Visible = True
        Me.HargaRpBaru.VisibleIndex = 6
        Me.HargaRpBaru.Width = 89
        '
        'HargaUsdBaru
        '
        Me.HargaUsdBaru.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.HargaUsdBaru.AppearanceCell.Options.UseBackColor = True
        Me.HargaUsdBaru.Caption = "Harga USD"
        Me.HargaUsdBaru.ColumnEdit = Me.repNum
        Me.HargaUsdBaru.FieldName = "usd_new"
        Me.HargaUsdBaru.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.HargaUsdBaru.Name = "HargaUsdBaru"
        Me.HargaUsdBaru.Visible = True
        Me.HargaUsdBaru.VisibleIndex = 7
        Me.HargaUsdBaru.Width = 84
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Controls.Add(Me.txtCari)
        Me.Panel3.Controls.Add(Me.LabelControl1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1038, 20)
        Me.Panel3.TabIndex = 138
        '
        'txtCari
        '
        Me.txtCari.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtCari.Location = New System.Drawing.Point(81, 0)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(508, 20)
        Me.txtCari.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(81, 20)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Search : "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.btnDel)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.btnSimpan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 590)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1038, 37)
        Me.Panel2.TabIndex = 136
        Me.Panel2.Visible = False
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(474, 6)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(64, 27)
        Me.btnDel.TabIndex = 27
        Me.btnDel.Text = "&Hapus"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(592, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 27)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "e&Xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(393, 6)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(64, 27)
        Me.btnSimpan.TabIndex = 24
        Me.btnSimpan.Text = "&Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnTerapkan)
        Me.Panel1.Controls.Add(Me.btnTutup)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1038, 37)
        Me.Panel1.TabIndex = 135
        '
        'btnTerapkan
        '
        Me.btnTerapkan.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnTerapkan.Location = New System.Drawing.Point(930, 0)
        Me.btnTerapkan.Name = "btnTerapkan"
        Me.btnTerapkan.Size = New System.Drawing.Size(53, 35)
        Me.btnTerapkan.TabIndex = 4
        Me.btnTerapkan.Text = "Oke"
        Me.btnTerapkan.UseVisualStyleBackColor = True
        '
        'btnTutup
        '
        Me.btnTutup.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnTutup.Location = New System.Drawing.Point(983, 0)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(53, 35)
        Me.btnTutup.TabIndex = 3
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 35)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(41, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(453, 37)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MAINTENANCE MASTER HARGA BARANG JADI"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmSetHarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 627)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl)
        Me.DoubleBuffered = True
        Me.Name = "frmSetHarga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMstHarga"
        CType(Me.repcheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        CType(Me.GcMstHarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvMstHarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_jnbrg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RL_merk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepTgl.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepTgl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repCombo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repSubTipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repUkuran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repKain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.txtCari.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents GcMstHarga As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvMstHarga As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Kode_Barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents End_Date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rec_stat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repCombo As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _merk As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents _jenisbrg As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RL_jnbrg As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents RL_merk As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtCari As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Nama_Barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repNum As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents RepTgl As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents tipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents subTipe As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Ukuran As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents repSubTipe As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents repUkuran As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents repKain As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents HargaRpBaru As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HargaUsdBaru As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pilih As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repcheck As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents btnTerapkan As System.Windows.Forms.Button
End Class
