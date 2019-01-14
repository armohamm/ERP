<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMstBookPeriod
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMstBookPeriod))
        Me.pnl = New System.Windows.Forms.Panel
        Me.GcBookPeriod = New DevExpress.XtraGrid.GridControl
        Me.GvBookPeriod = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.thn_buku = New DevExpress.XtraGrid.Columns.GridColumn
        Me.bln_buku = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_bulan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.attrib1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.attrib2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.status_close = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepCek = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.RepositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnDel = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.cmdSimpan = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.active = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl.SuspendLayout()
        CType(Me.GcBookPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GvBookPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepCek, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.GcBookPeriod)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1004, 388)
        Me.pnl.TabIndex = 0
        '
        'GcBookPeriod
        '
        Me.GcBookPeriod.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GcBookPeriod.Location = New System.Drawing.Point(0, 34)
        Me.GcBookPeriod.MainView = Me.GvBookPeriod
        Me.GcBookPeriod.Name = "GcBookPeriod"
        Me.GcBookPeriod.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemComboBox1, Me.RepCek})
        Me.GcBookPeriod.Size = New System.Drawing.Size(1004, 317)
        Me.GcBookPeriod.TabIndex = 29
        Me.GcBookPeriod.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GvBookPeriod})
        '
        'GvBookPeriod
        '
        Me.GvBookPeriod.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvBookPeriod.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvBookPeriod.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvBookPeriod.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GvBookPeriod.Appearance.ColumnFilterButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvBookPeriod.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GvBookPeriod.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GvBookPeriod.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GvBookPeriod.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvBookPeriod.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(154, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.GvBookPeriod.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(251, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvBookPeriod.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GvBookPeriod.Appearance.ColumnFilterButtonActive.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvBookPeriod.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GvBookPeriod.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GvBookPeriod.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GvBookPeriod.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GvBookPeriod.Appearance.Empty.Options.UseBackColor = True
        Me.GvBookPeriod.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvBookPeriod.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GvBookPeriod.Appearance.EvenRow.Options.UseBackColor = True
        Me.GvBookPeriod.Appearance.EvenRow.Options.UseForeColor = True
        Me.GvBookPeriod.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvBookPeriod.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvBookPeriod.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvBookPeriod.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GvBookPeriod.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvBookPeriod.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GvBookPeriod.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GvBookPeriod.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GvBookPeriod.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GvBookPeriod.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White
        Me.GvBookPeriod.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GvBookPeriod.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GvBookPeriod.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(156, Byte), Integer))
        Me.GvBookPeriod.Appearance.FixedLine.Options.UseBackColor = True
        Me.GvBookPeriod.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GvBookPeriod.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GvBookPeriod.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GvBookPeriod.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GvBookPeriod.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(106, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.GvBookPeriod.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GvBookPeriod.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GvBookPeriod.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GvBookPeriod.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvBookPeriod.Appearance.FooterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvBookPeriod.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvBookPeriod.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GvBookPeriod.Appearance.FooterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvBookPeriod.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GvBookPeriod.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GvBookPeriod.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GvBookPeriod.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvBookPeriod.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvBookPeriod.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black
        Me.GvBookPeriod.Appearance.GroupButton.Options.UseBackColor = True
        Me.GvBookPeriod.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GvBookPeriod.Appearance.GroupButton.Options.UseForeColor = True
        Me.GvBookPeriod.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvBookPeriod.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvBookPeriod.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GvBookPeriod.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GvBookPeriod.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GvBookPeriod.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GvBookPeriod.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GvBookPeriod.Appearance.GroupPanel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvBookPeriod.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GvBookPeriod.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GvBookPeriod.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvBookPeriod.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(193, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GvBookPeriod.Appearance.GroupRow.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.GvBookPeriod.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GvBookPeriod.Appearance.GroupRow.Options.UseBackColor = True
        Me.GvBookPeriod.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GvBookPeriod.Appearance.GroupRow.Options.UseFont = True
        Me.GvBookPeriod.Appearance.GroupRow.Options.UseForeColor = True
        Me.GvBookPeriod.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvBookPeriod.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvBookPeriod.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.GvBookPeriod.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GvBookPeriod.Appearance.HeaderPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.GvBookPeriod.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GvBookPeriod.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GvBookPeriod.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GvBookPeriod.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(228, Byte), Integer))
        Me.GvBookPeriod.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GvBookPeriod.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GvBookPeriod.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GvBookPeriod.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GvBookPeriod.Appearance.HorzLine.Options.UseBackColor = True
        Me.GvBookPeriod.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GvBookPeriod.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GvBookPeriod.Appearance.OddRow.Options.UseBackColor = True
        Me.GvBookPeriod.Appearance.OddRow.Options.UseForeColor = True
        Me.GvBookPeriod.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GvBookPeriod.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(88, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(185, Byte), Integer))
        Me.GvBookPeriod.Appearance.Preview.Options.UseBackColor = True
        Me.GvBookPeriod.Appearance.Preview.Options.UseForeColor = True
        Me.GvBookPeriod.Appearance.Row.BackColor = System.Drawing.Color.White
        Me.GvBookPeriod.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GvBookPeriod.Appearance.Row.Options.UseBackColor = True
        Me.GvBookPeriod.Appearance.Row.Options.UseForeColor = True
        Me.GvBookPeriod.Appearance.RowSeparator.BackColor = System.Drawing.Color.White
        Me.GvBookPeriod.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GvBookPeriod.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.GvBookPeriod.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White
        Me.GvBookPeriod.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GvBookPeriod.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GvBookPeriod.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(99, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.GvBookPeriod.Appearance.VertLine.Options.UseBackColor = True
        Me.GvBookPeriod.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.thn_buku, Me.bln_buku, Me.nama_bulan, Me.attrib1, Me.attrib2, Me.status_close, Me.active})
        Me.GvBookPeriod.GridControl = Me.GcBookPeriod
        Me.GvBookPeriod.Name = "GvBookPeriod"
        Me.GvBookPeriod.OptionsCustomization.AllowColumnMoving = False
        Me.GvBookPeriod.OptionsView.EnableAppearanceEvenRow = True
        Me.GvBookPeriod.OptionsView.EnableAppearanceOddRow = True
        Me.GvBookPeriod.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GvBookPeriod.OptionsView.RowAutoHeight = True
        Me.GvBookPeriod.OptionsView.ShowGroupPanel = False
        Me.GvBookPeriod.PaintStyleName = "Office2003"
        '
        'thn_buku
        '
        Me.thn_buku.Caption = "Tahun Pembukuan"
        Me.thn_buku.FieldName = "thn_buku"
        Me.thn_buku.Name = "thn_buku"
        Me.thn_buku.Visible = True
        Me.thn_buku.VisibleIndex = 0
        Me.thn_buku.Width = 117
        '
        'bln_buku
        '
        Me.bln_buku.Caption = "Bulan Pembukuan"
        Me.bln_buku.FieldName = "bln_buku"
        Me.bln_buku.Name = "bln_buku"
        Me.bln_buku.Visible = True
        Me.bln_buku.VisibleIndex = 1
        Me.bln_buku.Width = 117
        '
        'nama_bulan
        '
        Me.nama_bulan.Caption = "Nama Bulan"
        Me.nama_bulan.FieldName = "nama_bulan"
        Me.nama_bulan.Name = "nama_bulan"
        Me.nama_bulan.Visible = True
        Me.nama_bulan.VisibleIndex = 2
        Me.nama_bulan.Width = 117
        '
        'attrib1
        '
        Me.attrib1.Caption = "Attribut 1"
        Me.attrib1.FieldName = "attrib1"
        Me.attrib1.Name = "attrib1"
        Me.attrib1.Visible = True
        Me.attrib1.VisibleIndex = 3
        Me.attrib1.Width = 117
        '
        'attrib2
        '
        Me.attrib2.Caption = "Attribut 2"
        Me.attrib2.FieldName = "attrib2"
        Me.attrib2.Name = "attrib2"
        Me.attrib2.Visible = True
        Me.attrib2.VisibleIndex = 4
        Me.attrib2.Width = 157
        '
        'status_close
        '
        Me.status_close.Caption = "Status Close"
        Me.status_close.ColumnEdit = Me.RepCek
        Me.status_close.FieldName = "status_close"
        Me.status_close.Name = "status_close"
        Me.status_close.Visible = True
        Me.status_close.VisibleIndex = 5
        Me.status_close.Width = 73
        '
        'RepCek
        '
        Me.RepCek.AutoHeight = False
        Me.RepCek.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.RepCek.Caption = "T"
        Me.RepCek.DisplayValueChecked = "Y"
        Me.RepCek.DisplayValueUnchecked = "T"
        Me.RepCek.Name = "RepCek"
        Me.RepCek.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.RepCek.ValueChecked = "Y"
        Me.RepCek.ValueUnchecked = "T"
        '
        'RepositoryItemComboBox1
        '
        Me.RepositoryItemComboBox1.AutoHeight = False
        Me.RepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemComboBox1.Items.AddRange(New Object() {"Y", "T"})
        Me.RepositoryItemComboBox1.Name = "RepositoryItemComboBox1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkGray
        Me.Panel2.Controls.Add(Me.btnDel)
        Me.Panel2.Controls.Add(Me.btnExit)
        Me.Panel2.Controls.Add(Me.cmdSimpan)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 351)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1004, 37)
        Me.Panel2.TabIndex = 28
        '
        'btnDel
        '
        Me.btnDel.Location = New System.Drawing.Point(473, 6)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(64, 27)
        Me.btnDel.TabIndex = 27
        Me.btnDel.Text = "&Hapus"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(591, 6)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(64, 27)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "e&Xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(392, 6)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(64, 27)
        Me.cmdSimpan.TabIndex = 24
        Me.cmdSimpan.Text = "&Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
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
        Me.Panel1.Size = New System.Drawing.Size(1004, 34)
        Me.Panel1.TabIndex = 30
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
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(399, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "          MAINTENANCE PERIODE PEMBUKUAN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'active
        '
        Me.active.Caption = "Active"
        Me.active.FieldName = "is_active"
        Me.active.Name = "active"
        Me.active.Visible = True
        Me.active.VisibleIndex = 6
        '
        'frmMstBookPeriod
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1004, 388)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmMstBookPeriod"
        Me.Text = "frmMstBookPeriod"
        Me.pnl.ResumeLayout(False)
        CType(Me.GcBookPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GvBookPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepCek, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GcBookPeriod As DevExpress.XtraGrid.GridControl
    Friend WithEvents GvBookPeriod As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents thn_buku As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bln_buku As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents nama_bulan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents attrib1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents attrib2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents status_close As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepCek As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents active As DevExpress.XtraGrid.Columns.GridColumn
End Class
