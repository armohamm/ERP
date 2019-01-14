<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMasterGudang
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
        Me.components = New System.ComponentModel.Container
        Me.Pnl = New System.Windows.Forms.Panel
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.cbStatus = New System.Windows.Forms.ComboBox
        Me.txtKeterangan = New System.Windows.Forms.TextBox
        Me.txtNamaGudang = New System.Windows.Forms.TextBox
        Me.txtKodeGudang = New System.Windows.Forms.TextBox
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage
        Me.GC_Gudang = New DevExpress.XtraGrid.GridControl
        Me.GVSpon = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.KodeGudang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.NamaGudang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.recstat = New DevExpress.XtraGrid.Columns.GridColumn
        Me.lookupdepartemen = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Pnl.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        CType(Me.GC_Gudang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVSpon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lookupdepartemen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Pnl
        '
        Me.Pnl.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Pnl.Controls.Add(Me.XtraTabControl1)
        Me.Pnl.Controls.Add(Me.Panel1)
        Me.Pnl.Location = New System.Drawing.Point(12, 12)
        Me.Pnl.Name = "Pnl"
        Me.Pnl.Size = New System.Drawing.Size(559, 346)
        Me.Pnl.TabIndex = 66
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Location = New System.Drawing.Point(4, 44)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(550, 289)
        Me.XtraTabControl1.TabIndex = 21
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.Panel3)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(543, 260)
        Me.XtraTabPage1.Text = "Maintenance Data Gudang"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cbStatus)
        Me.Panel3.Controls.Add(Me.txtKeterangan)
        Me.Panel3.Controls.Add(Me.txtNamaGudang)
        Me.Panel3.Controls.Add(Me.txtKodeGudang)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(543, 260)
        Me.Panel3.TabIndex = 26
        '
        'cbStatus
        '
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"AKTIF", "TIDAK AKTIF"})
        Me.cbStatus.Location = New System.Drawing.Point(200, 90)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(124, 21)
        Me.cbStatus.TabIndex = 66
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtKeterangan.Location = New System.Drawing.Point(200, 40)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtKeterangan.Size = New System.Drawing.Size(343, 50)
        Me.txtKeterangan.TabIndex = 31
        '
        'txtNamaGudang
        '
        Me.txtNamaGudang.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNamaGudang.Location = New System.Drawing.Point(200, 20)
        Me.txtNamaGudang.Name = "txtNamaGudang"
        Me.txtNamaGudang.Size = New System.Drawing.Size(343, 20)
        Me.txtNamaGudang.TabIndex = 30
        '
        'txtKodeGudang
        '
        Me.txtKodeGudang.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtKodeGudang.Location = New System.Drawing.Point(200, 0)
        Me.txtKodeGudang.MaxLength = 12
        Me.txtKodeGudang.Name = "txtKodeGudang"
        Me.txtKodeGudang.ReadOnly = True
        Me.txtKodeGudang.Size = New System.Drawing.Size(343, 20)
        Me.txtKodeGudang.TabIndex = 29
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 260)
        Me.Panel4.TabIndex = 0
        '
        'Label20
        '
        Me.Label20.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(0, 90)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(200, 20)
        Me.Label20.TabIndex = 65
        Me.Label20.Text = "Status :"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(0, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 50)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Keterangan :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(0, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(200, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Nama Gudang :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 20)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Kode Gudang :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.GC_Gudang)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(543, 260)
        Me.XtraTabPage2.Text = "Daftar Gudang"
        '
        'GC_Gudang
        '
        Me.GC_Gudang.Location = New System.Drawing.Point(-2, 3)
        Me.GC_Gudang.LookAndFeel.SkinName = "The Asphalt World"
        Me.GC_Gudang.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GC_Gudang.MainView = Me.GVSpon
        Me.GC_Gudang.Name = "GC_Gudang"
        Me.GC_Gudang.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.lookupdepartemen})
        Me.GC_Gudang.Size = New System.Drawing.Size(545, 254)
        Me.GC_Gudang.TabIndex = 7
        Me.GC_Gudang.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVSpon, Me.GridView1})
        '
        'GVSpon
        '
        Me.GVSpon.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVSpon.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVSpon.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVSpon.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVSpon.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVSpon.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVSpon.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVSpon.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVSpon.Appearance.Empty.Options.UseBackColor = True
        Me.GVSpon.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSpon.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVSpon.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVSpon.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVSpon.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVSpon.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVSpon.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSpon.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVSpon.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVSpon.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.GVSpon.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVSpon.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVSpon.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVSpon.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVSpon.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GVSpon.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVSpon.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVSpon.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVSpon.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVSpon.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVSpon.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVSpon.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVSpon.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVSpon.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVSpon.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVSpon.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVSpon.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVSpon.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVSpon.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVSpon.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVSpon.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVSpon.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVSpon.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVSpon.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVSpon.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVSpon.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.GVSpon.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVSpon.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVSpon.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVSpon.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVSpon.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.OddRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.OddRow.Options.UseForeColor = True
        Me.GVSpon.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GVSpon.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVSpon.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GVSpon.Appearance.Preview.Options.UseBackColor = True
        Me.GVSpon.Appearance.Preview.Options.UseFont = True
        Me.GVSpon.Appearance.Preview.Options.UseForeColor = True
        Me.GVSpon.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSpon.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVSpon.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVSpon.Appearance.Row.Options.UseBackColor = True
        Me.GVSpon.Appearance.Row.Options.UseBorderColor = True
        Me.GVSpon.Appearance.Row.Options.UseForeColor = True
        Me.GVSpon.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVSpon.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVSpon.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVSpon.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GVSpon.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVSpon.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVSpon.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVSpon.Appearance.VertLine.Options.UseBackColor = True
        Me.GVSpon.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.KodeGudang, Me.NamaGudang, Me.Keterangan, Me.recstat})
        Me.GVSpon.GridControl = Me.GC_Gudang
        Me.GVSpon.GroupFormat = "{0}: [#image]{1}{2}"
        Me.GVSpon.Name = "GVSpon"
        Me.GVSpon.OptionsBehavior.Editable = False
        Me.GVSpon.OptionsBehavior.ReadOnly = True
        Me.GVSpon.OptionsCustomization.AllowColumnMoving = False
        Me.GVSpon.OptionsPrint.ExpandAllDetails = True
        Me.GVSpon.OptionsView.ColumnAutoWidth = False
        Me.GVSpon.OptionsView.EnableAppearanceEvenRow = True
        Me.GVSpon.OptionsView.EnableAppearanceOddRow = True
        Me.GVSpon.OptionsView.ShowChildrenInGroupPanel = True
        Me.GVSpon.OptionsView.ShowGroupPanel = False
        '
        'KodeGudang
        '
        Me.KodeGudang.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodeGudang.AppearanceCell.Options.UseFont = True
        Me.KodeGudang.Caption = "Kode Gudang"
        Me.KodeGudang.FieldName = "Kode_Gudang"
        Me.KodeGudang.Name = "KodeGudang"
        Me.KodeGudang.Visible = True
        Me.KodeGudang.VisibleIndex = 0
        Me.KodeGudang.Width = 153
        '
        'NamaGudang
        '
        Me.NamaGudang.Caption = "Nama Gudang"
        Me.NamaGudang.FieldName = "Nama_Gudang"
        Me.NamaGudang.Name = "NamaGudang"
        Me.NamaGudang.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.NamaGudang.Visible = True
        Me.NamaGudang.VisibleIndex = 1
        Me.NamaGudang.Width = 117
        '
        'Keterangan
        '
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 3
        '
        'recstat
        '
        Me.recstat.Caption = "Status"
        Me.recstat.FieldName = "Rec_Stat"
        Me.recstat.Name = "recstat"
        Me.recstat.Visible = True
        Me.recstat.VisibleIndex = 2
        '
        'lookupdepartemen
        '
        Me.lookupdepartemen.AutoHeight = False
        Me.lookupdepartemen.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lookupdepartemen.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Departemen", "Nama Departemen")})
        Me.lookupdepartemen.Name = "lookupdepartemen"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GC_Gudang
        Me.GridView1.Name = "GridView1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(557, 41)
        Me.Panel1.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(577, 41)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MASTER GUDANG"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Maroon
        Me.Panel2.Controls.Add(Me.cmdCancel)
        Me.Panel2.Controls.Add(Me.cmdDelete)
        Me.Panel2.Controls.Add(Me.cmdSave)
        Me.Panel2.Controls.Add(Me.cmdEdit)
        Me.Panel2.Controls.Add(Me.cmdAdd)
        Me.Panel2.Location = New System.Drawing.Point(14, 361)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(557, 37)
        Me.Panel2.TabIndex = 24
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(303, 4)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(64, 27)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cancel"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Location = New System.Drawing.Point(233, 4)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(64, 27)
        Me.cmdDelete.TabIndex = 3
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(163, 3)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(64, 27)
        Me.cmdSave.TabIndex = 2
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Location = New System.Drawing.Point(93, 3)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(64, 27)
        Me.cmdEdit.TabIndex = 1
        Me.cmdEdit.Text = "Edit"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(23, 3)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(64, 27)
        Me.cmdAdd.TabIndex = 0
        Me.cmdAdd.Text = "Add"
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmMasterGudang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(601, 420)
        Me.Controls.Add(Me.Pnl)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmMasterGudang"
        Me.Text = "Master Gudang"
        Me.Pnl.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.XtraTabPage2.ResumeLayout(False)
        CType(Me.GC_Gudang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVSpon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lookupdepartemen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaGudang As System.Windows.Forms.TextBox
    Friend WithEvents txtKodeGudang As System.Windows.Forms.TextBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GC_Gudang As DevExpress.XtraGrid.GridControl
    Friend WithEvents GVSpon As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents KodeGudang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents NamaGudang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents recstat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lookupdepartemen As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class
