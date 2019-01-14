<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmzMonProdBOM2
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
        Dim StyleFormatCondition3 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition4 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmzMonProdBOM2))
        Me.pnl = New System.Windows.Forms.Panel
        Me.GC_DetilBOM = New DevExpress.XtraGrid.GridControl
        Me.GV_BOM = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.col_kdBarang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Col_NamaComp = New DevExpress.XtraGrid.Columns.GridColumn
        Me.col_jns_persediaan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Col_Tgl_update = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Col_UpdatedBy = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.btnLoad = New DevExpress.XtraEditors.SimpleButton
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.txtNama_Barang = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlTitle = New System.Windows.Forms.Panel
        Me.lblTitle = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.pnl.SuspendLayout()
        CType(Me.GC_DetilBOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_BOM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.txtNama_Barang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.pnlTitle.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnl.Controls.Add(Me.GC_DetilBOM)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.pnlTitle)
        Me.pnl.Location = New System.Drawing.Point(12, 12)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1038, 498)
        Me.pnl.TabIndex = 1
        '
        'GC_DetilBOM
        '
        Me.GC_DetilBOM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC_DetilBOM.Location = New System.Drawing.Point(0, 68)
        Me.GC_DetilBOM.MainView = Me.GV_BOM
        Me.GC_DetilBOM.Name = "GC_DetilBOM"
        Me.GC_DetilBOM.Size = New System.Drawing.Size(1038, 430)
        Me.GC_DetilBOM.TabIndex = 6
        Me.GC_DetilBOM.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_BOM})
        '
        'GV_BOM
        '
        Me.GV_BOM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_kdBarang, Me.Col_NamaComp, Me.col_jns_persediaan, Me.Col_Tgl_update, Me.Col_UpdatedBy})
        StyleFormatCondition3.Appearance.BackColor = System.Drawing.Color.Red
        StyleFormatCondition3.Appearance.Options.UseBackColor = True
        StyleFormatCondition3.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition3.Expression = "[sisa_stok] < 0"
        StyleFormatCondition4.Condition = DevExpress.XtraGrid.FormatConditionEnum.Expression
        StyleFormatCondition4.Expression = "[sisa_stok] >= 0"
        Me.GV_BOM.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition3, StyleFormatCondition4})
        Me.GV_BOM.GridControl = Me.GC_DetilBOM
        Me.GV_BOM.Name = "GV_BOM"
        Me.GV_BOM.OptionsView.ShowGroupPanel = False
        '
        'col_kdBarang
        '
        Me.col_kdBarang.AppearanceHeader.Options.UseTextOptions = True
        Me.col_kdBarang.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_kdBarang.Caption = "Kode BOM"
        Me.col_kdBarang.FieldName = "kd_bom"
        Me.col_kdBarang.Name = "col_kdBarang"
        Me.col_kdBarang.OptionsColumn.AllowEdit = False
        Me.col_kdBarang.Visible = True
        Me.col_kdBarang.VisibleIndex = 0
        Me.col_kdBarang.Width = 146
        '
        'Col_NamaComp
        '
        Me.Col_NamaComp.AppearanceHeader.Options.UseTextOptions = True
        Me.Col_NamaComp.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_NamaComp.Caption = "Nama Barang"
        Me.Col_NamaComp.FieldName = "Nama_Barang"
        Me.Col_NamaComp.Name = "Col_NamaComp"
        Me.Col_NamaComp.OptionsColumn.AllowEdit = False
        Me.Col_NamaComp.Visible = True
        Me.Col_NamaComp.VisibleIndex = 1
        Me.Col_NamaComp.Width = 342
        '
        'col_jns_persediaan
        '
        Me.col_jns_persediaan.AppearanceHeader.Options.UseTextOptions = True
        Me.col_jns_persediaan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_jns_persediaan.Caption = "Revisi"
        Me.col_jns_persediaan.FieldName = "revisi"
        Me.col_jns_persediaan.Name = "col_jns_persediaan"
        Me.col_jns_persediaan.OptionsColumn.AllowEdit = False
        Me.col_jns_persediaan.Visible = True
        Me.col_jns_persediaan.VisibleIndex = 2
        Me.col_jns_persediaan.Width = 100
        '
        'Col_Tgl_update
        '
        Me.Col_Tgl_update.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Col_Tgl_update.AppearanceCell.Options.UseBackColor = True
        Me.Col_Tgl_update.AppearanceHeader.Options.UseTextOptions = True
        Me.Col_Tgl_update.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_Tgl_update.Caption = "Tanggal Update"
        Me.Col_Tgl_update.FieldName = "last_update_date"
        Me.Col_Tgl_update.Name = "Col_Tgl_update"
        Me.Col_Tgl_update.OptionsColumn.AllowEdit = False
        Me.Col_Tgl_update.Visible = True
        Me.Col_Tgl_update.VisibleIndex = 3
        Me.Col_Tgl_update.Width = 88
        '
        'Col_UpdatedBy
        '
        Me.Col_UpdatedBy.AppearanceHeader.Options.UseTextOptions = True
        Me.Col_UpdatedBy.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Col_UpdatedBy.Caption = "Diupdate Oleh"
        Me.Col_UpdatedBy.FieldName = "last_updated_by"
        Me.Col_UpdatedBy.Name = "Col_UpdatedBy"
        Me.Col_UpdatedBy.OptionsColumn.AllowEdit = False
        Me.Col_UpdatedBy.Visible = True
        Me.Col_UpdatedBy.VisibleIndex = 4
        Me.Col_UpdatedBy.Width = 63
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 34)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1038, 34)
        Me.Panel1.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnLoad)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(537, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(183, 34)
        Me.Panel3.TabIndex = 7
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(6, 4)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(81, 27)
        Me.btnLoad.TabIndex = 2
        Me.btnLoad.Text = "&Refresh"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtNama_Barang)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(191, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(346, 34)
        Me.Panel2.TabIndex = 6
        '
        'txtNama_Barang
        '
        Me.txtNama_Barang.Location = New System.Drawing.Point(0, 7)
        Me.txtNama_Barang.Name = "txtNama_Barang"
        Me.txtNama_Barang.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtNama_Barang.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Barang", "Kode Barang", 24, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", 50, "Nama Barang"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Status_Barang", "Status_Barang")})
        Me.txtNama_Barang.Properties.NullText = "[Pilih Barang]"
        Me.txtNama_Barang.Size = New System.Drawing.Size(346, 20)
        Me.txtNama_Barang.TabIndex = 6
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(191, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(847, 34)
        Me.Panel7.TabIndex = 5
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(191, 34)
        Me.Panel6.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Nama Barang : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.pnlTitle.Size = New System.Drawing.Size(1038, 34)
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
        Me.lblTitle.Size = New System.Drawing.Size(499, 32)
        Me.lblTitle.TabIndex = 8
        Me.lblTitle.Text = "MONITORING BAHAN BAKU PADA BOM PRODUKSI"
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
        'frmzMonProdBOM2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 522)
        Me.Controls.Add(Me.pnl)
        Me.Name = "frmzMonProdBOM2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmzMonProdBOM"
        Me.pnl.ResumeLayout(False)
        CType(Me.GC_DetilBOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_BOM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.txtNama_Barang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.pnlTitle.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTitle As System.Windows.Forms.Panel
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtNama_Barang As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnLoad As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GC_DetilBOM As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_BOM As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_kdBarang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_NamaComp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_jns_persediaan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_UpdatedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Col_Tgl_update As DevExpress.XtraGrid.Columns.GridColumn
End Class
