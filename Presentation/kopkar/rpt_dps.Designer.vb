﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rpt_dps
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_dps))
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.img = New System.Windows.Forms.ImageList(Me.components)
        Me.pnl = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cr_view = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnprin = New DevExpress.XtraEditors.SimpleButton
        Me.cmdClear = New DevExpress.XtraEditors.SimpleButton
        Me.cmdRefresh = New DevExpress.XtraEditors.SimpleButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.pnl.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(197, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(405, 52)
        Me.Panel6.TabIndex = 38
        '
        'img
        '
        Me.img.ImageStream = CType(resources.GetObject("img.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img.TransparentColor = System.Drawing.Color.Transparent
        Me.img.Images.SetKeyName(0, "error.ico")
        Me.img.Images.SetKeyName(1, "insert.ico")
        Me.img.Images.SetKeyName(2, "edit2.ico")
        Me.img.Images.SetKeyName(3, "ok.ico")
        Me.img.Images.SetKeyName(4, "save.ico")
        Me.img.Images.SetKeyName(5, "reload.ico")
        Me.img.Images.SetKeyName(6, "gohome.ico")
        Me.img.Images.SetKeyName(7, "remove.ico")
        Me.img.Images.SetKeyName(8, "clean.ico")
        Me.img.Images.SetKeyName(9, "forward.ico")
        Me.img.Images.SetKeyName(10, "printer.ico")
        Me.img.Images.SetKeyName(11, "chart.ico")
        Me.img.Images.SetKeyName(12, "sale.ico")
        Me.img.Images.SetKeyName(13, "users.ico")
        Me.img.Images.SetKeyName(14, "cut.ico")
        Me.img.Images.SetKeyName(15, "log_out.png")
        '
        'pnl
        '
        Me.pnl.Controls.Add(Me.Panel2)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(1135, 351)
        Me.pnl.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.cr_view)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 52)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1135, 299)
        Me.Panel2.TabIndex = 3
        '
        'cr_view
        '
        Me.cr_view.ActiveViewIndex = -1
        Me.cr_view.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cr_view.DisplayGroupTree = False
        Me.cr_view.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cr_view.Location = New System.Drawing.Point(0, 0)
        Me.cr_view.Name = "cr_view"
        Me.cr_view.SelectionFormula = ""
        Me.cr_view.Size = New System.Drawing.Size(1135, 299)
        Me.cr_view.TabIndex = 0
        Me.cr_view.ViewTimeSelectionFormula = ""
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnprin)
        Me.Panel1.Controls.Add(Me.cmdClear)
        Me.Panel1.Controls.Add(Me.cmdRefresh)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1135, 52)
        Me.Panel1.TabIndex = 2
        '
        'btnprin
        '
        Me.btnprin.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnprin.ImageIndex = 10
        Me.btnprin.ImageList = Me.img
        Me.btnprin.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnprin.Location = New System.Drawing.Point(700, 0)
        Me.btnprin.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnprin.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnprin.Name = "btnprin"
        Me.btnprin.Size = New System.Drawing.Size(53, 52)
        Me.btnprin.TabIndex = 41
        '
        'cmdClear
        '
        Me.cmdClear.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdClear.Location = New System.Drawing.Point(651, 0)
        Me.cmdClear.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdClear.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(49, 52)
        Me.cmdClear.TabIndex = 40
        Me.cmdClear.ToolTip = "Celar Filter"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmdRefresh.Image = CType(resources.GetObject("cmdRefresh.Image"), System.Drawing.Image)
        Me.cmdRefresh.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdRefresh.Location = New System.Drawing.Point(602, 0)
        Me.cmdRefresh.LookAndFeel.SkinName = "The Asphalt World"
        Me.cmdRefresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(49, 52)
        Me.cmdRefresh.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(197, 52)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "LAPORAN DEPOSITO AKTIF"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rpt_dps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 351)
        Me.Controls.Add(Me.pnl)
        Me.Name = "rpt_dps"
        Me.Text = "rpt_dps"
        Me.pnl.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents cmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents img As System.Windows.Forms.ImageList
    Friend WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents cr_view As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnprin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
