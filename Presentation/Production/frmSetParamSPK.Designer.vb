<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetParamSPK
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetParamSPK))
        Me.stateD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.GCD = New DevExpress.XtraGrid.GridControl
        Me.GVD = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Kd_Cabangd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Jns_Table = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Id_Tabled = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Id_Ref_File_D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Id_Ref_Data = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Val_kode1_D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Val_kode2d = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangand = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Rec_Statd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemRadioGroup2 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
        Me.Last_Create_Dated = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Last_Created_Byd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Last_Update_Dated = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Last_Updated_Byd = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Program_NameD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Desc_Data = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Id_Data = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Col_Dept = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Rep_Departemen = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblJudul = New System.Windows.Forms.Label
        Me.pnl.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GCD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemRadioGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rep_Departemen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stateD
        '
        Me.stateD.Caption = "State"
        Me.stateD.FieldName = "state"
        Me.stateD.Name = "stateD"
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1028, 559)
        Me.pnl.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GCD)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 34)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1028, 525)
        Me.Panel2.TabIndex = 23
        '
        'GCD
        '
        Me.GCD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GCD.Location = New System.Drawing.Point(0, 0)
        Me.GCD.MainView = Me.GVD
        Me.GCD.Name = "GCD"
        Me.GCD.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemRadioGroup2, Me.Rep_Departemen})
        Me.GCD.Size = New System.Drawing.Size(1028, 525)
        Me.GCD.TabIndex = 1
        Me.GCD.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVD})
        '
        'GVD
        '
        Me.GVD.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVD.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVD.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVD.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVD.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVD.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVD.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVD.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVD.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GVD.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVD.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVD.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVD.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVD.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVD.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GVD.Appearance.Empty.Options.UseBackColor = True
        Me.GVD.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVD.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVD.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVD.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVD.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVD.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVD.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVD.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVD.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVD.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVD.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVD.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GVD.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVD.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVD.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GVD.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVD.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVD.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVD.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVD.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GVD.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVD.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVD.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVD.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVD.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVD.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVD.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVD.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVD.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVD.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVD.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVD.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVD.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVD.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVD.Appearance.GroupButton.Options.UseForeColor = True
        Me.GVD.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVD.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVD.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVD.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVD.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVD.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVD.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVD.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVD.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVD.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVD.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GVD.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GVD.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVD.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVD.Appearance.GroupRow.Options.UseFont = True
        Me.GVD.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVD.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVD.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVD.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GVD.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GVD.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVD.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVD.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVD.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GVD.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GVD.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVD.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVD.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GVD.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVD.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GVD.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.OddRow.Options.UseBackColor = True
        Me.GVD.Appearance.OddRow.Options.UseForeColor = True
        Me.GVD.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GVD.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GVD.Appearance.Preview.Options.UseBackColor = True
        Me.GVD.Appearance.Preview.Options.UseForeColor = True
        Me.GVD.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GVD.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.Row.Options.UseBackColor = True
        Me.GVD.Appearance.Row.Options.UseForeColor = True
        Me.GVD.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GVD.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVD.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GVD.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GVD.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVD.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GVD.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GVD.Appearance.VertLine.Options.UseBackColor = True
        Me.GVD.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Kd_Cabangd, Me.Jns_Table, Me.Id_Tabled, Me.Id_Ref_File_D, Me.Id_Ref_Data, Me.Val_kode1_D, Me.Val_kode2d, Me.Keterangand, Me.Rec_Statd, Me.Last_Create_Dated, Me.Last_Created_Byd, Me.Last_Update_Dated, Me.Last_Updated_Byd, Me.Program_NameD, Me.stateD, Me.Desc_Data, Me.Id_Data, Me.Col_Dept})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.stateD
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "1"
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.stateD
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "2"
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.ApplyToRow = True
        StyleFormatCondition3.Column = Me.stateD
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition3.Value1 = "3"
        Me.GVD.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2, StyleFormatCondition3})
        Me.GVD.GridControl = Me.GCD
        Me.GVD.Name = "GVD"
        Me.GVD.OptionsView.EnableAppearanceEvenRow = True
        Me.GVD.OptionsView.EnableAppearanceOddRow = True
        Me.GVD.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GVD.OptionsView.RowAutoHeight = True
        Me.GVD.OptionsView.ShowGroupPanel = False
        Me.GVD.OptionsView.ShowViewCaption = True
        '
        'Kd_Cabangd
        '
        Me.Kd_Cabangd.Caption = "Kd_Cabang"
        Me.Kd_Cabangd.FieldName = "Kd_Cabang"
        Me.Kd_Cabangd.Name = "Kd_Cabangd"
        '
        'Jns_Table
        '
        Me.Jns_Table.Caption = "Jns_Table"
        Me.Jns_Table.FieldName = "Jns_Table"
        Me.Jns_Table.Name = "Jns_Table"
        '
        'Id_Tabled
        '
        Me.Id_Tabled.Caption = "GridColumn1"
        Me.Id_Tabled.FieldName = "Id_Table"
        Me.Id_Tabled.Name = "Id_Tabled"
        '
        'Id_Ref_File_D
        '
        Me.Id_Ref_File_D.Caption = "Id_Ref_File"
        Me.Id_Ref_File_D.FieldName = "Id_Ref_File"
        Me.Id_Ref_File_D.Name = "Id_Ref_File_D"
        Me.Id_Ref_File_D.Width = 70
        '
        'Id_Ref_Data
        '
        Me.Id_Ref_Data.Caption = "ID Ref Data"
        Me.Id_Ref_Data.FieldName = "Id_Ref_Data"
        Me.Id_Ref_Data.Name = "Id_Ref_Data"
        Me.Id_Ref_Data.Width = 94
        '
        'Val_kode1_D
        '
        Me.Val_kode1_D.Caption = "Value 1"
        Me.Val_kode1_D.FieldName = "Val_kode1"
        Me.Val_kode1_D.Name = "Val_kode1_D"
        Me.Val_kode1_D.Width = 97
        '
        'Val_kode2d
        '
        Me.Val_kode2d.Caption = "Value 2"
        Me.Val_kode2d.FieldName = "Val_kode2"
        Me.Val_kode2d.Name = "Val_kode2d"
        Me.Val_kode2d.Width = 84
        '
        'Keterangand
        '
        Me.Keterangand.AppearanceHeader.Options.UseTextOptions = True
        Me.Keterangand.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Keterangand.Caption = "Keterangan"
        Me.Keterangand.FieldName = "Keterangan"
        Me.Keterangand.Name = "Keterangand"
        Me.Keterangand.Visible = True
        Me.Keterangand.VisibleIndex = 3
        Me.Keterangand.Width = 294
        '
        'Rec_Statd
        '
        Me.Rec_Statd.Caption = "Status"
        Me.Rec_Statd.ColumnEdit = Me.RepositoryItemRadioGroup2
        Me.Rec_Statd.FieldName = "Rec_Stat"
        Me.Rec_Statd.Name = "Rec_Statd"
        Me.Rec_Statd.Width = 134
        '
        'RepositoryItemRadioGroup2
        '
        Me.RepositoryItemRadioGroup2.Columns = 2
        Me.RepositoryItemRadioGroup2.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Y", "Aktif"), New DevExpress.XtraEditors.Controls.RadioGroupItem("T", "Tidak Aktif")})
        Me.RepositoryItemRadioGroup2.Name = "RepositoryItemRadioGroup2"
        '
        'Last_Create_Dated
        '
        Me.Last_Create_Dated.Caption = "GridColumn3"
        Me.Last_Create_Dated.FieldName = "Last_Create_Date"
        Me.Last_Create_Dated.Name = "Last_Create_Dated"
        '
        'Last_Created_Byd
        '
        Me.Last_Created_Byd.Caption = "GridColumn4"
        Me.Last_Created_Byd.FieldName = "Last_Created_By"
        Me.Last_Created_Byd.Name = "Last_Created_Byd"
        '
        'Last_Update_Dated
        '
        Me.Last_Update_Dated.Caption = "GridColumn5"
        Me.Last_Update_Dated.FieldName = "Last_Update_Date"
        Me.Last_Update_Dated.Name = "Last_Update_Dated"
        '
        'Last_Updated_Byd
        '
        Me.Last_Updated_Byd.Caption = "GridColumn6"
        Me.Last_Updated_Byd.FieldName = "Last_Updated_By"
        Me.Last_Updated_Byd.Name = "Last_Updated_Byd"
        '
        'Program_NameD
        '
        Me.Program_NameD.Caption = "GridColumn7"
        Me.Program_NameD.FieldName = "Program_Name"
        Me.Program_NameD.Name = "Program_NameD"
        '
        'Desc_Data
        '
        Me.Desc_Data.AppearanceHeader.Options.UseTextOptions = True
        Me.Desc_Data.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Desc_Data.Caption = "Deskripsi"
        Me.Desc_Data.FieldName = "Desc_Data"
        Me.Desc_Data.Name = "Desc_Data"
        Me.Desc_Data.Visible = True
        Me.Desc_Data.VisibleIndex = 1
        Me.Desc_Data.Width = 471
        '
        'Id_Data
        '
        Me.Id_Data.AppearanceHeader.Options.UseTextOptions = True
        Me.Id_Data.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Id_Data.Caption = "ID Data"
        Me.Id_Data.FieldName = "Id_Data"
        Me.Id_Data.Name = "Id_Data"
        Me.Id_Data.Visible = True
        Me.Id_Data.VisibleIndex = 0
        Me.Id_Data.Width = 107
        '
        'Col_Dept
        '
        Me.Col_Dept.AppearanceHeader.Options.UseTextOptions = True
        Me.Col_Dept.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_Dept.Caption = "Departemen"
        Me.Col_Dept.ColumnEdit = Me.Rep_Departemen
        Me.Col_Dept.FieldName = "kd_departemen"
        Me.Col_Dept.Name = "Col_Dept"
        Me.Col_Dept.Visible = True
        Me.Col_Dept.VisibleIndex = 2
        Me.Col_Dept.Width = 135
        '
        'Rep_Departemen
        '
        Me.Rep_Departemen.AutoHeight = False
        Me.Rep_Departemen.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.Rep_Departemen.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Departemen", "Kode Departemen"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Departemen", "Nama Departemen")})
        Me.Rep_Departemen.DisplayMember = "Nama_Departemen"
        Me.Rep_Departemen.Name = "Rep_Departemen"
        Me.Rep_Departemen.NullText = "[Pilih Departemen]"
        Me.Rep_Departemen.ValueMember = "Kd_Departemen"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblJudul)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 34)
        Me.Panel1.TabIndex = 22
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
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblJudul.Location = New System.Drawing.Point(0, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(516, 33)
        Me.lblJudul.TabIndex = 1
        Me.lblJudul.Text = "          MAINTENANCE MASTER KEGIATAN SPK"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmSetParamSPK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 559)
        Me.Controls.Add(Me.pnl)
        Me.LookAndFeel.SkinName = "Black"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frmSetParamSPK"
        Me.Text = "frmSetParam"
        Me.pnl.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.GCD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemRadioGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rep_Departemen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents GCD As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVD As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Id_Ref_File_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Id_Ref_Data As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Val_kode1_D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_Cabangd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Jns_Table As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Id_Tabled As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Val_kode2d As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rec_Statd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Last_Create_Dated As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Last_Created_Byd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Last_Update_Dated As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Last_Updated_Byd As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Program_NameD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemRadioGroup2 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup
    Friend WithEvents stateD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Desc_Data As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Id_Data As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_Dept As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Rep_Departemen As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
End Class
