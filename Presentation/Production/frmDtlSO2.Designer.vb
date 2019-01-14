<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDtlSO2
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
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDtlSO2))
        Me.Col_SisaStok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.XT_DetilSO = New DevExpress.XtraTab.XtraTabControl
        Me.Detil_BOM = New DevExpress.XtraTab.XtraTabPage
        Me.GC_DetilBOM = New DevExpress.XtraGrid.GridControl
        Me.GV_BOM = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.col_kdBarang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Col_NamaComp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col_jns_persediaan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Col_Satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Col_Total = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Col_Available = New DevExpress.XtraGrid.Columns.GridColumn
        Me.pnl = New DevExpress.XtraEditors.PanelControl
        Me.pnlbawah = New System.Windows.Forms.Panel
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.btn_close = New DevExpress.XtraEditors.SimpleButton
        Me.pnlAtas = New System.Windows.Forms.Panel
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        CType(Me.XT_DetilSO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XT_DetilSO.SuspendLayout()
        Me.Detil_BOM.SuspendLayout()
        CType(Me.GC_DetilBOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_BOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl.SuspendLayout()
        Me.pnlbawah.SuspendLayout()
        Me.pnlAtas.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Col_SisaStok
        '
        Me.Col_SisaStok.AppearanceHeader.Options.UseTextOptions = True
        Me.Col_SisaStok.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_SisaStok.Caption = "Sisa Stok"
        Me.Col_SisaStok.FieldName = "sisa_stok"
        Me.Col_SisaStok.Name = "Col_SisaStok"
        Me.Col_SisaStok.OptionsColumn.AllowEdit = False
        Me.Col_SisaStok.Visible = True
        Me.Col_SisaStok.VisibleIndex = 6
        '
        'XT_DetilSO
        '
        Me.XT_DetilSO.Location = New System.Drawing.Point(6, 34)
        Me.XT_DetilSO.Name = "XT_DetilSO"
        Me.XT_DetilSO.SelectedTabPage = Me.Detil_BOM
        Me.XT_DetilSO.Size = New System.Drawing.Size(826, 376)
        Me.XT_DetilSO.TabIndex = 1
        Me.XT_DetilSO.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.Detil_BOM})
        '
        'Detil_BOM
        '
        Me.Detil_BOM.Controls.Add(Me.GC_DetilBOM)
        Me.Detil_BOM.Name = "Detil_BOM"
        Me.Detil_BOM.Size = New System.Drawing.Size(819, 347)
        Me.Detil_BOM.Text = "Detail Kebutuhan Bahan"
        '
        'GC_DetilBOM
        '
        Me.GC_DetilBOM.Location = New System.Drawing.Point(3, 8)
        Me.GC_DetilBOM.MainView = Me.GV_BOM
        Me.GC_DetilBOM.Name = "GC_DetilBOM"
        Me.GC_DetilBOM.Size = New System.Drawing.Size(813, 336)
        Me.GC_DetilBOM.TabIndex = 0
        Me.GC_DetilBOM.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_BOM})
        '
        'GV_BOM
        '
        Me.GV_BOM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_kdBarang, Me.Col_NamaComp, Me.col_jns_persediaan, Me.Col_Satuan, Me.Col_Total, Me.Col_Available, Me.Col_SisaStok})
        StyleFormatCondition1.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseBackColor = True
        StyleFormatCondition1.Column = Me.Col_SisaStok
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition1.Expression = "[sisa_stok] < 0"
        StyleFormatCondition2.Column = Me.Col_SisaStok
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition2.Expression = "[sisa_stok] >= 0"
        Me.GV_BOM.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1, StyleFormatCondition2})
        Me.GV_BOM.GridControl = Me.GC_DetilBOM
        Me.GV_BOM.Name = "GV_BOM"
        Me.GV_BOM.OptionsView.ShowGroupPanel = False
        '
        'col_kdBarang
        '
        Me.col_kdBarang.AppearanceHeader.Options.UseTextOptions = True
        Me.col_kdBarang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_kdBarang.Caption = "Kode Barang"
        Me.col_kdBarang.FieldName = "kd_brg"
        Me.col_kdBarang.Name = "col_kdBarang"
        Me.col_kdBarang.OptionsColumn.AllowEdit = False
        Me.col_kdBarang.Visible = True
        Me.col_kdBarang.VisibleIndex = 0
        Me.col_kdBarang.Width = 131
        '
        'Col_NamaComp
        '
        Me.Col_NamaComp.AppearanceHeader.Options.UseTextOptions = True
        Me.Col_NamaComp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_NamaComp.Caption = "Nama Barang"
        Me.Col_NamaComp.FieldName = "nama_barang"
        Me.Col_NamaComp.Name = "Col_NamaComp"
        Me.Col_NamaComp.OptionsColumn.AllowEdit = False
        Me.Col_NamaComp.Visible = True
        Me.Col_NamaComp.VisibleIndex = 1
        Me.Col_NamaComp.Width = 305
        '
        'col_jns_persediaan
        '
        Me.col_jns_persediaan.AppearanceHeader.Options.UseTextOptions = True
        Me.col_jns_persediaan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_jns_persediaan.Caption = "Jenis Persediaan"
        Me.col_jns_persediaan.FieldName = "Nama_Persediaan"
        Me.col_jns_persediaan.Name = "col_jns_persediaan"
        Me.col_jns_persediaan.OptionsColumn.AllowEdit = False
        Me.col_jns_persediaan.Visible = True
        Me.col_jns_persediaan.VisibleIndex = 2
        Me.col_jns_persediaan.Width = 90
        '
        'Col_Satuan
        '
        Me.Col_Satuan.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Col_Satuan.AppearanceCell.Options.UseBackColor = True
        Me.Col_Satuan.AppearanceHeader.Options.UseTextOptions = True
        Me.Col_Satuan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_Satuan.Caption = "Satuan"
        Me.Col_Satuan.FieldName = "satuan"
        Me.Col_Satuan.Name = "Col_Satuan"
        Me.Col_Satuan.OptionsColumn.AllowEdit = False
        Me.Col_Satuan.Visible = True
        Me.Col_Satuan.VisibleIndex = 3
        Me.Col_Satuan.Width = 69
        '
        'Col_Total
        '
        Me.Col_Total.AppearanceHeader.Options.UseTextOptions = True
        Me.Col_Total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_Total.Caption = "Total"
        Me.Col_Total.FieldName = "jumlah"
        Me.Col_Total.Name = "Col_Total"
        Me.Col_Total.OptionsColumn.AllowEdit = False
        Me.Col_Total.Visible = True
        Me.Col_Total.VisibleIndex = 4
        Me.Col_Total.Width = 64
        '
        'Col_Available
        '
        Me.Col_Available.AppearanceHeader.Options.UseTextOptions = True
        Me.Col_Available.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_Available.Caption = "Jumlah Stok"
        Me.Col_Available.FieldName = "jml_available"
        Me.Col_Available.Name = "Col_Available"
        Me.Col_Available.OptionsColumn.AllowEdit = False
        Me.Col_Available.Visible = True
        Me.Col_Available.VisibleIndex = 5
        Me.Col_Available.Width = 58
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.pnlbawah)
        Me.pnl.Controls.Add(Me.pnlAtas)
        Me.pnl.Controls.Add(Me.XT_DetilSO)
        Me.pnl.Location = New System.Drawing.Point(3, 4)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(837, 452)
        Me.pnl.TabIndex = 2
        '
        'pnlbawah
        '
        Me.pnlbawah.BackColor = System.Drawing.Color.Maroon
        Me.pnlbawah.Controls.Add(Me.SimpleButton1)
        Me.pnlbawah.Controls.Add(Me.btn_close)
        Me.pnlbawah.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlbawah.Location = New System.Drawing.Point(2, 415)
        Me.pnlbawah.Name = "pnlbawah"
        Me.pnlbawah.Size = New System.Drawing.Size(833, 35)
        Me.pnlbawah.TabIndex = 3
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(657, 6)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Cetak"
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(738, 6)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(75, 23)
        Me.btn_close.TabIndex = 0
        Me.btn_close.Text = "Keluar"
        '
        'pnlAtas
        '
        Me.pnlAtas.BackColor = System.Drawing.Color.Maroon
        Me.pnlAtas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlAtas.Controls.Add(Me.LabelControl1)
        Me.pnlAtas.Controls.Add(Me.PictureBox1)
        Me.pnlAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlAtas.Location = New System.Drawing.Point(2, 2)
        Me.pnlAtas.Name = "pnlAtas"
        Me.pnlAtas.Size = New System.Drawing.Size(833, 31)
        Me.pnlAtas.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial Narrow", 15.75!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Gold
        Me.LabelControl1.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.LabelControl1.Location = New System.Drawing.Point(37, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(368, 29)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "DETAIL KEBUTUHAN BAHAN"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 29)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'frmDtlSO2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(844, 464)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDtlSO2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detail "
        CType(Me.XT_DetilSO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XT_DetilSO.ResumeLayout(False)
        Me.Detil_BOM.ResumeLayout(False)
        CType(Me.GC_DetilBOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_BOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl.ResumeLayout(False)
        Me.pnlbawah.ResumeLayout(False)
        Me.pnlAtas.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents XT_DetilSO As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents Detil_BOM As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents GC_DetilBOM As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_BOM As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Col_NamaComp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_Total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_Available As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_SisaStok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_Satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents pnl As DevExpress.XtraEditors.PanelControl
    Friend WithEvents pnlAtas As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents pnlbawah As System.Windows.Forms.Panel
    Friend WithEvents btn_close As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_kdBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_jns_persediaan As DevExpress.XtraGrid.Columns.GridColumn
End Class
