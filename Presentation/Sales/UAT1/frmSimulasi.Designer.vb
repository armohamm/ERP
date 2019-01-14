<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSimulasi
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSimulasi))
        Me.pnl = New System.Windows.Forms.Panel
        Me.gc = New DevExpress.XtraGrid.GridControl
        Me.gv = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.T = New DevExpress.XtraGrid.Columns.GridColumn
        Me.L = New DevExpress.XtraGrid.Columns.GridColumn
        Me.P = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PRS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.V = New DevExpress.XtraGrid.Columns.GridColumn
        Me.J = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Q = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QR = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QQ = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.L_UP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.T_UP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.lblQty = New System.Windows.Forms.Label
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton
        Me.lblBox = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtWaste = New DevExpress.XtraEditors.TextEdit
        Me.lblJudul = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdAply = New DevExpress.XtraEditors.SimpleButton
        Me.cmdTutup = New DevExpress.XtraEditors.SimpleButton
        Me.lblWaste = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnl.SuspendLayout()
        CType(Me.gc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.txtWaste.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.gc)
        Me.pnl.Controls.Add(Me.Panel3)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(624, 329)
        Me.pnl.TabIndex = 0
        '
        'gc
        '
        Me.gc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gc.Location = New System.Drawing.Point(0, 68)
        Me.gc.MainView = Me.gv
        Me.gc.Name = "gc"
        Me.gc.Size = New System.Drawing.Size(624, 228)
        Me.gc.TabIndex = 4
        Me.gc.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gv})
        '
        'gv
        '
        Me.gv.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.T, Me.L, Me.P, Me.PRS, Me.V, Me.J, Me.Q, Me.QR, Me.QQ, Me.GridColumn1, Me.L_UP, Me.T_UP})
        Me.gv.GridControl = Me.gc
        Me.gv.Name = "gv"
        Me.gv.OptionsView.EnableAppearanceEvenRow = True
        Me.gv.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.gv.OptionsView.ShowFooter = True
        Me.gv.OptionsView.ShowGroupPanel = False
        Me.gv.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.T, DevExpress.Data.ColumnSortOrder.Descending)})
        '
        'T
        '
        Me.T.Caption = "Tebal"
        Me.T.FieldName = "T"
        Me.T.Name = "T"
        Me.T.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value
        Me.T.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.T.Visible = True
        Me.T.VisibleIndex = 0
        Me.T.Width = 107
        '
        'L
        '
        Me.L.Caption = "Lebar"
        Me.L.FieldName = "L"
        Me.L.Name = "L"
        Me.L.Visible = True
        Me.L.VisibleIndex = 1
        Me.L.Width = 107
        '
        'P
        '
        Me.P.Caption = "Panjang"
        Me.P.FieldName = "P"
        Me.P.Name = "P"
        Me.P.Visible = True
        Me.P.VisibleIndex = 2
        Me.P.Width = 107
        '
        'PRS
        '
        Me.PRS.Caption = "%"
        Me.PRS.FieldName = "%"
        Me.PRS.Name = "PRS"
        Me.PRS.Width = 107
        '
        'V
        '
        Me.V.Caption = "V"
        Me.V.FieldName = "V"
        Me.V.Name = "V"
        Me.V.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.V.Width = 107
        '
        'J
        '
        Me.J.Caption = "J"
        Me.J.FieldName = "J"
        Me.J.Name = "J"
        Me.J.Width = 107
        '
        'Q
        '
        Me.Q.Caption = "Qty Prorata"
        Me.Q.FieldName = "Q"
        Me.Q.Name = "Q"
        Me.Q.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Q.Visible = True
        Me.Q.VisibleIndex = 3
        Me.Q.Width = 92
        '
        'QR
        '
        Me.QR.Caption = "Qty Request"
        Me.QR.FieldName = "QR"
        Me.QR.Name = "QR"
        Me.QR.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.QR.Visible = True
        Me.QR.VisibleIndex = 4
        Me.QR.Width = 113
        '
        'QQ
        '
        Me.QQ.Caption = "Qty Akhir"
        Me.QQ.FieldName = "QQ"
        Me.QQ.Name = "QQ"
        Me.QQ.Visible = True
        Me.QQ.VisibleIndex = 5
        Me.QQ.Width = 124
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.FieldName = "Kode_Ukuran"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'L_UP
        '
        Me.L_UP.Caption = "L_UP"
        Me.L_UP.FieldName = "L_UP"
        Me.L_UP.Name = "L_UP"
        '
        'T_UP
        '
        Me.T_UP.Caption = "T_UP"
        Me.T_UP.FieldName = "L_UP"
        Me.T_UP.Name = "T_UP"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.Controls.Add(Me.SimpleButton1)
        Me.Panel3.Controls.Add(Me.lblBox)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 37)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(624, 31)
        Me.Panel3.TabIndex = 6
        '
        'lblQty
        '
        Me.lblQty.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQty.ForeColor = System.Drawing.Color.White
        Me.lblQty.Location = New System.Drawing.Point(464, 4)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(55, 31)
        Me.lblQty.TabIndex = 3
        Me.lblQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblQty.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Dock = System.Windows.Forms.DockStyle.Right
        Me.SimpleButton1.Location = New System.Drawing.Point(560, 0)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(64, 31)
        Me.SimpleButton1.TabIndex = 9
        Me.SimpleButton1.Text = "Proses"
        '
        'lblBox
        '
        Me.lblBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblBox.ForeColor = System.Drawing.Color.White
        Me.lblBox.Location = New System.Drawing.Point(55, 0)
        Me.lblBox.Name = "lblBox"
        Me.lblBox.Size = New System.Drawing.Size(499, 31)
        Me.lblBox.TabIndex = 1
        Me.lblBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Busa : "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblQty)
        Me.Panel1.Controls.Add(Me.txtWaste)
        Me.Panel1.Controls.Add(Me.lblJudul)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(624, 37)
        Me.Panel1.TabIndex = 3
        '
        'txtWaste
        '
        Me.txtWaste.Location = New System.Drawing.Point(309, 10)
        Me.txtWaste.Name = "txtWaste"
        Me.txtWaste.Size = New System.Drawing.Size(100, 20)
        Me.txtWaste.TabIndex = 10
        Me.txtWaste.Visible = False
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(540, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = " FORM SIMULASI BOX"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(38, 35)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.cmdAply)
        Me.Panel2.Controls.Add(Me.cmdTutup)
        Me.Panel2.Controls.Add(Me.lblWaste)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 296)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(624, 33)
        Me.Panel2.TabIndex = 5
        '
        'cmdAply
        '
        Me.cmdAply.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAply.Appearance.Options.UseFont = True
        Me.cmdAply.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdAply.Location = New System.Drawing.Point(468, 0)
        Me.cmdAply.Name = "cmdAply"
        Me.cmdAply.Size = New System.Drawing.Size(78, 33)
        Me.cmdAply.TabIndex = 11
        Me.cmdAply.Text = "Terapkan"
        '
        'cmdTutup
        '
        Me.cmdTutup.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTutup.Appearance.Options.UseFont = True
        Me.cmdTutup.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdTutup.Location = New System.Drawing.Point(546, 0)
        Me.cmdTutup.Name = "cmdTutup"
        Me.cmdTutup.Size = New System.Drawing.Size(78, 33)
        Me.cmdTutup.TabIndex = 10
        Me.cmdTutup.Text = "Tutup"
        '
        'lblWaste
        '
        Me.lblWaste.BackColor = System.Drawing.Color.Black
        Me.lblWaste.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblWaste.ForeColor = System.Drawing.Color.White
        Me.lblWaste.Location = New System.Drawing.Point(55, 0)
        Me.lblWaste.Name = "lblWaste"
        Me.lblWaste.Size = New System.Drawing.Size(226, 33)
        Me.lblWaste.TabIndex = 2
        Me.lblWaste.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Sisa : "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmSimulasi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 329)
        Me.Controls.Add(Me.pnl)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSimulasi"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSimulasi"
        Me.pnl.ResumeLayout(False)
        CType(Me.gc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.txtWaste.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents gc As DevExpress.XtraGrid.GridControl
    Friend WithEvents gv As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents T As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents L As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents P As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PRS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents V As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents J As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Q As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QR As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtWaste As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblQty As System.Windows.Forms.Label
    Friend WithEvents lblBox As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblWaste As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdAply As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdTutup As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents L_UP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents T_UP As DevExpress.XtraGrid.Columns.GridColumn
End Class
