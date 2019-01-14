<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSO
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
        Me.components = New System.ComponentModel.Container
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode
        Dim StyleFormatCondition1 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim StyleFormatCondition2 As DevExpress.XtraGrid.StyleFormatCondition = New DevExpress.XtraGrid.StyleFormatCondition
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSO))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject
        Dim SuperToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip
        Dim ToolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem
        Dim ToolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem
        Me.GVD = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.NoD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Kd_StokD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repPopD = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.UnitD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QtyD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.HargaD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Disc1D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Disc2D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Disc3D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Disc4D = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Disc5d = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PotonganD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.TotalD = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Nama_Barang = New DevExpress.XtraGrid.Columns.GridColumn
        Me.nama_potongan2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GC = New DevExpress.XtraGrid.GridControl
        Me.GVP = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.NoSeqP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.QtyP = New DevExpress.XtraGrid.Columns.GridColumn
        Me.PROMO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.KDPROMO = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ambilBonus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repBonus = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.GV = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.No_seq = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Sete = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repSet = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Kd_Stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repBarang = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.Deskripsi = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repDes = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.popDesk = New DevExpress.XtraEditors.PopupContainerControl
        Me.txtDesk = New DevExpress.XtraEditors.MemoEdit
        Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repQty = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.Kd_satuan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Keterangan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.tglKirims = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repTglKirim = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
        Me.tgl_kirim_ppic = New DevExpress.XtraGrid.Columns.GridColumn
        Me.harga = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repHarga = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.Potongan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Total = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Priority = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repPrioritas = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Me.states = New DevExpress.XtraGrid.Columns.GridColumn
        Me.disc1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.disc2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.disc3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.disc4 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.disc5 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.potTotal = New DevExpress.XtraGrid.Columns.GridColumn
        Me.ambil_bonus = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDel = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repDel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Me.Nama_Potongan = New DevExpress.XtraGrid.Columns.GridColumn
        Me.BNS = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repBns = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.Stok = New DevExpress.XtraGrid.Columns.GridColumn
        Me.isLocked = New DevExpress.XtraGrid.Columns.GridColumn
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.repKeterangan = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
        Me.RepPop = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
        Me.RepDesk = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
        Me.RepositoryItemCheckEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
        Me.popCon = New DevExpress.XtraEditors.PopupContainerControl
        Me.popBiaya = New DevExpress.XtraEditors.PopupContainerControl
        Me.GC_Biaya = New DevExpress.XtraGrid.GridControl
        Me.GV_Biaya = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.kd_biaya = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repBiaya = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
        Me.biaya = New DevExpress.XtraGrid.Columns.GridColumn
        Me.repNum = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
        Me.gcCari = New DevExpress.XtraGrid.GridControl
        Me.gvCari = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn
        Me.Panel21 = New System.Windows.Forms.Panel
        Me.txtcari = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.pnl = New System.Windows.Forms.Panel
        Me.pnlTengah = New System.Windows.Forms.Panel
        Me.pnlTengahBawah = New System.Windows.Forms.Panel
        Me.Panel18 = New System.Windows.Forms.Panel
        Me.btnKunci = New DevExpress.XtraEditors.SimpleButton
        Me.lblPromo = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtKurs = New DevExpress.XtraEditors.TextEdit
        Me.vValas = New DevExpress.XtraEditors.LookUpEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbJenisSP = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.pnlTengahAtas = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.spReff = New DevExpress.XtraEditors.LookUpEdit
        Me.DT_TglSO = New DevExpress.XtraEditors.DateEdit
        Me.tglSO = New DevExpress.XtraEditors.TextEdit
        Me.txtNomor = New DevExpress.XtraEditors.TextEdit
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.ckPPN = New DevExpress.XtraEditors.CheckEdit
        Me.Panel7 = New System.Windows.Forms.Panel
        Me.Panel9 = New System.Windows.Forms.Panel
        Me.txtNamaSales = New DevExpress.XtraEditors.TextEdit
        Me.txtSales = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel25 = New System.Windows.Forms.Panel
        Me.lblStateCR = New System.Windows.Forms.Label
        Me.cmbAtasNama = New DevExpress.XtraEditors.ComboBoxEdit
        Me.Panel6 = New System.Windows.Forms.Panel
        Me.lblStatus = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtKodeCust = New DevExpress.XtraEditors.TextEdit
        Me.txtCustomer = New DevExpress.XtraEditors.LookUpEdit
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.pnlbawah = New System.Windows.Forms.Panel
        Me.Panel14 = New System.Windows.Forms.Panel
        Me.Panel16 = New System.Windows.Forms.Panel
        Me.Panel19 = New System.Windows.Forms.Panel
        Me.Panel15 = New System.Windows.Forms.Panel
        Me.Panel23 = New System.Windows.Forms.Panel
        Me.txtBiaya2 = New DevExpress.XtraEditors.PopupContainerEdit
        Me.txtBiaya = New DevExpress.XtraEditors.SpinEdit
        Me.lblTotal = New DevExpress.XtraEditors.SpinEdit
        Me.Panel22 = New System.Windows.Forms.Panel
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl
        Me.Panel17 = New System.Windows.Forms.Panel
        Me.Panel20 = New System.Windows.Forms.Panel
        Me.btnBuku = New DevExpress.XtraEditors.SimpleButton
        Me.cmdViewStatusSp = New DevExpress.XtraEditors.SimpleButton
        Me.btnPromo = New DevExpress.XtraEditors.SimpleButton
        Me.Panel11 = New System.Windows.Forms.Panel
        Me.txtKeterangan = New DevExpress.XtraEditors.MemoEdit
        Me.cmdWilayah = New DevExpress.XtraEditors.LookUpEdit
        Me.tglKirim = New DevExpress.XtraEditors.DateEdit
        Me.Panel24 = New System.Windows.Forms.Panel
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl
        Me.Panel10 = New System.Windows.Forms.Panel
        Me.Panel13 = New System.Windows.Forms.Panel
        Me.txtMedia = New DevExpress.XtraEditors.ComboBoxEdit
        Me.txtNamaPnrm = New System.Windows.Forms.TextBox
        Me.txtAlamatKirim = New DevExpress.XtraEditors.MemoEdit
        Me.menuAlamat = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PilihAlamat = New System.Windows.Forms.ToolStripMenuItem
        Me.Alamat1 = New System.Windows.Forms.ToolStripMenuItem
        Me.Alamat2 = New System.Windows.Forms.ToolStripMenuItem
        Me.Alamat3 = New System.Windows.Forms.ToolStripMenuItem
        Me.tglKirimMarketing = New DevExpress.XtraEditors.DateEdit
        Me.Panel8 = New System.Windows.Forms.Panel
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblJudul = New System.Windows.Forms.Label
        Me.Panel12 = New System.Windows.Forms.Panel
        Me.txtCR = New DevExpress.XtraEditors.SpinEdit
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblState = New System.Windows.Forms.Label
        Me.ColorWithAlpha4 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha5 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha6 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha1 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha2 = New BlueActivity.Controls.ColorWithAlpha
        Me.ColorWithAlpha3 = New BlueActivity.Controls.ColorWithAlpha
        Me.DXEP = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.GVD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repPopD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repBonus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repDes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popDesk, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popDesk.SuspendLayout()
        CType(Me.txtDesk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repTglKirim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repTglKirim.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repHarga, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repPrioritas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repDel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repBns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repKeterangan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepPop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepDesk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.popCon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popCon.SuspendLayout()
        CType(Me.popBiaya, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.popBiaya.SuspendLayout()
        CType(Me.GC_Biaya, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GV_Biaya, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repBiaya, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repNum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcCari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvCari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel21.SuspendLayout()
        Me.pnl.SuspendLayout()
        Me.pnlTengah.SuspendLayout()
        Me.pnlTengahBawah.SuspendLayout()
        Me.Panel18.SuspendLayout()
        CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vValas.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbJenisSP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTengahAtas.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.spReff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_TglSO.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_TglSO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglSO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.ckPPN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.txtNamaSales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSales.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel25.SuspendLayout()
        CType(Me.cmbAtasNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.txtKodeCust.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.pnlbawah.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel19.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel23.SuspendLayout()
        CType(Me.txtBiaya2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBiaya.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel22.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel20.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdWilayah.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglKirim.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglKirim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel24.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel13.SuspendLayout()
        CType(Me.txtMedia.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAlamatKirim.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuAlamat.SuspendLayout()
        CType(Me.tglKirimMarketing.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tglKirimMarketing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.txtCR.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DXEP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GVD
        '
        Me.GVD.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVD.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVD.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVD.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVD.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVD.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVD.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVD.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVD.Appearance.Empty.Options.UseBackColor = True
        Me.GVD.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVD.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVD.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVD.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVD.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVD.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVD.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVD.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVD.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVD.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVD.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.GVD.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVD.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVD.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVD.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVD.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GVD.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVD.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVD.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVD.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVD.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVD.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVD.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVD.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVD.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVD.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVD.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVD.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVD.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVD.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVD.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVD.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVD.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVD.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVD.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVD.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVD.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVD.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVD.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.GVD.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVD.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVD.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVD.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVD.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVD.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.OddRow.Options.UseBackColor = True
        Me.GVD.Appearance.OddRow.Options.UseForeColor = True
        Me.GVD.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GVD.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVD.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GVD.Appearance.Preview.Options.UseBackColor = True
        Me.GVD.Appearance.Preview.Options.UseFont = True
        Me.GVD.Appearance.Preview.Options.UseForeColor = True
        Me.GVD.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVD.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVD.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVD.Appearance.Row.Options.UseBackColor = True
        Me.GVD.Appearance.Row.Options.UseBorderColor = True
        Me.GVD.Appearance.Row.Options.UseForeColor = True
        Me.GVD.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVD.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVD.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVD.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GVD.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVD.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVD.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVD.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVD.Appearance.VertLine.Options.UseBackColor = True
        Me.GVD.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NoD, Me.Kd_StokD, Me.UnitD, Me.QtyD, Me.HargaD, Me.Disc1D, Me.Disc2D, Me.Disc3D, Me.Disc4D, Me.Disc5d, Me.PotonganD, Me.TotalD, Me.Nama_Barang, Me.nama_potongan2})
        Me.GVD.GridControl = Me.GC
        Me.GVD.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "harga", Me.HargaD, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total", Me.Nama_Barang, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "potongan", Me.PotonganD, "")})
        Me.GVD.Name = "GVD"
        Me.GVD.OptionsBehavior.SummariesIgnoreNullValues = True
        Me.GVD.OptionsCustomization.AllowColumnMoving = False
        Me.GVD.OptionsCustomization.AllowGroup = False
        Me.GVD.OptionsCustomization.AllowQuickHideColumns = False
        Me.GVD.OptionsCustomization.AllowSort = False
        Me.GVD.OptionsView.EnableAppearanceEvenRow = True
        Me.GVD.OptionsView.EnableAppearanceOddRow = True
        Me.GVD.OptionsView.ShowGroupPanel = False
        Me.GVD.OptionsView.ShowHorzLines = False
        Me.GVD.OptionsView.ShowIndicator = False
        Me.GVD.OptionsView.ShowVertLines = False
        '
        'NoD
        '
        Me.NoD.AppearanceCell.BackColor = System.Drawing.Color.Silver
        Me.NoD.AppearanceCell.Options.UseBackColor = True
        Me.NoD.AppearanceCell.Options.UseTextOptions = True
        Me.NoD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.NoD.AppearanceHeader.Options.UseTextOptions = True
        Me.NoD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.NoD.Caption = "No"
        Me.NoD.FieldName = "No_seq"
        Me.NoD.Name = "NoD"
        Me.NoD.OptionsColumn.AllowEdit = False
        Me.NoD.Visible = True
        Me.NoD.VisibleIndex = 0
        Me.NoD.Width = 37
        '
        'Kd_StokD
        '
        Me.Kd_StokD.Caption = "Kode"
        Me.Kd_StokD.ColumnEdit = Me.repPopD
        Me.Kd_StokD.FieldName = "Kd_Stok"
        Me.Kd_StokD.Name = "Kd_StokD"
        Me.Kd_StokD.Width = 162
        '
        'repPopD
        '
        Me.repPopD.AutoHeight = False
        Me.repPopD.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repPopD.Name = "repPopD"
        Me.repPopD.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.repPopD.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        '
        'UnitD
        '
        Me.UnitD.Caption = "Satuan"
        Me.UnitD.FieldName = "Kd_satuan"
        Me.UnitD.Name = "UnitD"
        Me.UnitD.OptionsColumn.AllowEdit = False
        Me.UnitD.Visible = True
        Me.UnitD.VisibleIndex = 2
        Me.UnitD.Width = 63
        '
        'QtyD
        '
        Me.QtyD.Caption = "Qty"
        Me.QtyD.FieldName = "Qty"
        Me.QtyD.Name = "QtyD"
        Me.QtyD.Visible = True
        Me.QtyD.VisibleIndex = 3
        Me.QtyD.Width = 54
        '
        'HargaD
        '
        Me.HargaD.AppearanceCell.Options.UseTextOptions = True
        Me.HargaD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.HargaD.AppearanceHeader.Options.UseTextOptions = True
        Me.HargaD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.HargaD.Caption = "Harga"
        Me.HargaD.DisplayFormat.FormatString = "N2"
        Me.HargaD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.HargaD.FieldName = "harga"
        Me.HargaD.Name = "HargaD"
        Me.HargaD.OptionsColumn.AllowEdit = False
        Me.HargaD.OptionsColumn.AllowFocus = False
        Me.HargaD.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.HargaD.ToolTip = "Harga Per-Item"
        Me.HargaD.Visible = True
        Me.HargaD.VisibleIndex = 4
        Me.HargaD.Width = 116
        '
        'Disc1D
        '
        Me.Disc1D.Caption = "Disc1"
        Me.Disc1D.FieldName = "disc1"
        Me.Disc1D.Name = "Disc1D"
        Me.Disc1D.Width = 61
        '
        'Disc2D
        '
        Me.Disc2D.Caption = "Disc2"
        Me.Disc2D.FieldName = "disc2"
        Me.Disc2D.Name = "Disc2D"
        Me.Disc2D.Width = 61
        '
        'Disc3D
        '
        Me.Disc3D.Caption = "Disc3"
        Me.Disc3D.FieldName = "disc3"
        Me.Disc3D.Name = "Disc3D"
        Me.Disc3D.Width = 61
        '
        'Disc4D
        '
        Me.Disc4D.Caption = "Disc4"
        Me.Disc4D.FieldName = "disc4"
        Me.Disc4D.Name = "Disc4D"
        Me.Disc4D.Width = 61
        '
        'Disc5d
        '
        Me.Disc5d.Caption = "Disc5"
        Me.Disc5d.FieldName = "disc5"
        Me.Disc5d.Name = "Disc5d"
        Me.Disc5d.Width = 61
        '
        'PotonganD
        '
        Me.PotonganD.AppearanceCell.BackColor = System.Drawing.Color.Red
        Me.PotonganD.AppearanceCell.ForeColor = System.Drawing.Color.White
        Me.PotonganD.AppearanceCell.Options.UseBackColor = True
        Me.PotonganD.AppearanceCell.Options.UseForeColor = True
        Me.PotonganD.AppearanceCell.Options.UseTextOptions = True
        Me.PotonganD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.PotonganD.AppearanceHeader.Options.UseTextOptions = True
        Me.PotonganD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.PotonganD.Caption = "Potongan"
        Me.PotonganD.DisplayFormat.FormatString = "C2"
        Me.PotonganD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.PotonganD.FieldName = "potongan"
        Me.PotonganD.Name = "PotonganD"
        Me.PotonganD.OptionsColumn.AllowEdit = False
        Me.PotonganD.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.PotonganD.ToolTip = "Potongan Harga"
        Me.PotonganD.Width = 118
        '
        'TotalD
        '
        Me.TotalD.AppearanceCell.Options.UseTextOptions = True
        Me.TotalD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TotalD.AppearanceHeader.Options.UseTextOptions = True
        Me.TotalD.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.TotalD.Caption = "Total"
        Me.TotalD.DisplayFormat.FormatString = "N2"
        Me.TotalD.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.TotalD.FieldName = "total"
        Me.TotalD.Name = "TotalD"
        Me.TotalD.OptionsColumn.AllowEdit = False
        Me.TotalD.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.TotalD.ToolTip = "Total Harga"
        Me.TotalD.Visible = True
        Me.TotalD.VisibleIndex = 6
        Me.TotalD.Width = 164
        '
        'Nama_Barang
        '
        Me.Nama_Barang.Caption = "Deskripsi"
        Me.Nama_Barang.FieldName = "Deskripsi"
        Me.Nama_Barang.Name = "Nama_Barang"
        Me.Nama_Barang.OptionsColumn.AllowEdit = False
        Me.Nama_Barang.Visible = True
        Me.Nama_Barang.VisibleIndex = 1
        Me.Nama_Barang.Width = 442
        '
        'nama_potongan2
        '
        Me.nama_potongan2.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.nama_potongan2.AppearanceCell.Options.UseForeColor = True
        Me.nama_potongan2.Caption = "Potongan"
        Me.nama_potongan2.FieldName = "nama_potongan"
        Me.nama_potongan2.Name = "nama_potongan2"
        Me.nama_potongan2.Visible = True
        Me.nama_potongan2.VisibleIndex = 5
        Me.nama_potongan2.Width = 90
        '
        'GC
        '
        Me.GC.Dock = System.Windows.Forms.DockStyle.Fill
        GridLevelNode1.LevelTemplate = Me.GVD
        GridLevelNode1.RelationName = "Level1"
        GridLevelNode2.LevelTemplate = Me.GVP
        GridLevelNode2.RelationName = "Level2"
        Me.GC.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.GC.Location = New System.Drawing.Point(0, 23)
        Me.GC.LookAndFeel.SkinName = "Blue"
        Me.GC.MainView = Me.GV
        Me.GC.Name = "GC"
        Me.GC.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repPrioritas, Me.repTglKirim, Me.repKeterangan, Me.repSet, Me.repBonus, Me.RepPop, Me.repDes, Me.repQty, Me.repPopD, Me.repDel, Me.repBarang, Me.RepDesk, Me.repBns, Me.repHarga, Me.RepositoryItemCheckEdit1, Me.RepositoryItemCheckEdit2})
        Me.GC.Size = New System.Drawing.Size(990, 379)
        Me.GC.TabIndex = 0
        Me.GC.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GVP, Me.GV, Me.GVD})
        '
        'GVP
        '
        Me.GVP.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVP.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVP.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GVP.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GVP.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GVP.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GVP.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVP.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVP.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GVP.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GVP.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GVP.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GVP.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVP.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GVP.Appearance.Empty.Options.UseBackColor = True
        Me.GVP.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVP.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GVP.Appearance.EvenRow.Options.UseBackColor = True
        Me.GVP.Appearance.EvenRow.Options.UseForeColor = True
        Me.GVP.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVP.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVP.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GVP.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GVP.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GVP.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GVP.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVP.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GVP.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVP.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GVP.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GVP.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.GVP.Appearance.FixedLine.Options.UseBackColor = True
        Me.GVP.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GVP.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GVP.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GVP.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GVP.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GVP.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GVP.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GVP.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GVP.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVP.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVP.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GVP.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GVP.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GVP.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GVP.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVP.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVP.Appearance.GroupButton.Options.UseBackColor = True
        Me.GVP.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GVP.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVP.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVP.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GVP.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GVP.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GVP.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GVP.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVP.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GVP.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GVP.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GVP.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GVP.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVP.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVP.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GVP.Appearance.GroupRow.Options.UseBackColor = True
        Me.GVP.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GVP.Appearance.GroupRow.Options.UseForeColor = True
        Me.GVP.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVP.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GVP.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GVP.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GVP.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GVP.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GVP.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.GVP.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVP.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GVP.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GVP.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVP.Appearance.HorzLine.Options.UseBackColor = True
        Me.GVP.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GVP.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GVP.Appearance.OddRow.Options.UseBackColor = True
        Me.GVP.Appearance.OddRow.Options.UseForeColor = True
        Me.GVP.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GVP.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GVP.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GVP.Appearance.Preview.Options.UseBackColor = True
        Me.GVP.Appearance.Preview.Options.UseFont = True
        Me.GVP.Appearance.Preview.Options.UseForeColor = True
        Me.GVP.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVP.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GVP.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GVP.Appearance.Row.Options.UseBackColor = True
        Me.GVP.Appearance.Row.Options.UseBorderColor = True
        Me.GVP.Appearance.Row.Options.UseForeColor = True
        Me.GVP.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GVP.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GVP.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GVP.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GVP.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GVP.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GVP.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GVP.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GVP.Appearance.VertLine.Options.UseBackColor = True
        Me.GVP.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.NoSeqP, Me.QtyP, Me.PROMO, Me.KDPROMO, Me.ambilBonus})
        StyleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red
        StyleFormatCondition1.Appearance.Options.UseForeColor = True
        StyleFormatCondition1.ApplyToRow = True
        StyleFormatCondition1.Column = Me.ambilBonus
        StyleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition1.Value1 = "T"
        Me.GVP.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition1})
        Me.GVP.GridControl = Me.GC
        Me.GVP.Name = "GVP"
        Me.GVP.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GVP.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GVP.OptionsView.EnableAppearanceEvenRow = True
        Me.GVP.OptionsView.EnableAppearanceOddRow = True
        Me.GVP.OptionsView.ShowGroupPanel = False
        Me.GVP.OptionsView.ShowHorzLines = False
        Me.GVP.OptionsView.ShowIndicator = False
        Me.GVP.OptionsView.ShowPreview = True
        Me.GVP.OptionsView.ShowVertLines = False
        Me.GVP.PreviewFieldName = "PROMONAME"
        Me.GVP.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.NoSeqP, DevExpress.Data.ColumnSortOrder.Ascending)})
        '
        'NoSeqP
        '
        Me.NoSeqP.Caption = "No"
        Me.NoSeqP.FieldName = "No_Seq"
        Me.NoSeqP.Name = "NoSeqP"
        Me.NoSeqP.OptionsColumn.AllowEdit = False
        Me.NoSeqP.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText
        Me.NoSeqP.Width = 55
        '
        'QtyP
        '
        Me.QtyP.Caption = "Qty"
        Me.QtyP.FieldName = "QTY"
        Me.QtyP.Name = "QtyP"
        Me.QtyP.OptionsColumn.AllowEdit = False
        Me.QtyP.Visible = True
        Me.QtyP.VisibleIndex = 0
        Me.QtyP.Width = 60
        '
        'PROMO
        '
        Me.PROMO.Caption = "Promo"
        Me.PROMO.FieldName = "PROMO_DESC"
        Me.PROMO.Name = "PROMO"
        Me.PROMO.OptionsColumn.AllowEdit = False
        Me.PROMO.Visible = True
        Me.PROMO.VisibleIndex = 1
        Me.PROMO.Width = 873
        '
        'KDPROMO
        '
        Me.KDPROMO.Caption = "KDPROMO"
        Me.KDPROMO.FieldName = "KD_PROMO"
        Me.KDPROMO.Name = "KDPROMO"
        Me.KDPROMO.Width = 64
        '
        'ambilBonus
        '
        Me.ambilBonus.Caption = "Promo"
        Me.ambilBonus.ColumnEdit = Me.repBonus
        Me.ambilBonus.FieldName = "Ambil"
        Me.ambilBonus.Name = "ambilBonus"
        Me.ambilBonus.Visible = True
        Me.ambilBonus.VisibleIndex = 2
        Me.ambilBonus.Width = 54
        '
        'repBonus
        '
        Me.repBonus.AutoHeight = False
        Me.repBonus.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.repBonus.DisplayValueChecked = "Ambil"
        Me.repBonus.DisplayValueUnchecked = "Tidak Ambil"
        Me.repBonus.Name = "repBonus"
        Me.repBonus.ValueChecked = "Y"
        Me.repBonus.ValueUnchecked = "T"
        '
        'GV
        '
        Me.GV.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.Empty.Options.UseBackColor = True
        Me.GV.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GV.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.GV.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GV.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GV.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GV.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.OddRow.Options.UseBackColor = True
        Me.GV.Appearance.OddRow.Options.UseForeColor = True
        Me.GV.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GV.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GV.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GV.Appearance.Preview.Options.UseBackColor = True
        Me.GV.Appearance.Preview.Options.UseFont = True
        Me.GV.Appearance.Preview.Options.UseForeColor = True
        Me.GV.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV.Appearance.Row.Options.UseForeColor = True
        Me.GV.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GV.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GV.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GV.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV.Appearance.VertLine.Options.UseBackColor = True
        Me.GV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GV.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.No_seq, Me.Sete, Me.Kd_Stok, Me.Deskripsi, Me.Qty, Me.Kd_satuan, Me.Keterangan, Me.tglKirims, Me.tgl_kirim_ppic, Me.harga, Me.Potongan, Me.Total, Me.Priority, Me.states, Me.disc1, Me.disc2, Me.disc3, Me.disc4, Me.disc5, Me.potTotal, Me.ambil_bonus, Me.colDel, Me.Nama_Potongan, Me.BNS, Me.Stok, Me.isLocked})
        StyleFormatCondition2.Appearance.BackColor = System.Drawing.Color.LightYellow
        StyleFormatCondition2.Appearance.Options.UseBackColor = True
        StyleFormatCondition2.ApplyToRow = True
        StyleFormatCondition2.Column = Me.states
        StyleFormatCondition2.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal
        StyleFormatCondition2.Value1 = "2"
        Me.GV.FormatConditions.AddRange(New DevExpress.XtraGrid.StyleFormatCondition() {StyleFormatCondition2})
        Me.GV.GridControl = Me.GC
        Me.GV.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Qty", Me.Qty, ""), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "total", Me.Total, "")})
        Me.GV.Name = "GV"
        Me.GV.NewItemRowText = "Klik Disini Untuk Menambah Item Baru"
        Me.GV.OptionsBehavior.SummariesIgnoreNullValues = True
        Me.GV.OptionsCustomization.AllowFilter = False
        Me.GV.OptionsCustomization.AllowGroup = False
        Me.GV.OptionsCustomization.AllowQuickHideColumns = False
        Me.GV.OptionsCustomization.AllowSort = False
        Me.GV.OptionsDetail.AllowOnlyOneMasterRowExpanded = True
        Me.GV.OptionsDetail.ShowDetailTabs = False
        Me.GV.OptionsDetail.SmartDetailHeight = True
        Me.GV.OptionsView.ColumnAutoWidth = False
        Me.GV.OptionsView.EnableAppearanceOddRow = True
        Me.GV.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Me.GV.OptionsView.RowAutoHeight = True
        Me.GV.OptionsView.ShowGroupPanel = False
        Me.GV.OptionsView.ShowHorzLines = False
        Me.GV.OptionsView.ShowVertLines = False
        Me.GV.PaintStyleName = "Skin"
        Me.GV.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.[Default]
        '
        'No_seq
        '
        Me.No_seq.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.No_seq.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.No_seq.AppearanceCell.Options.UseFont = True
        Me.No_seq.AppearanceCell.Options.UseTextOptions = True
        Me.No_seq.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.No_seq.Caption = "No"
        Me.No_seq.FieldName = "No_seq"
        Me.No_seq.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.No_seq.Name = "No_seq"
        Me.No_seq.OptionsColumn.AllowEdit = False
        Me.No_seq.OptionsColumn.AllowFocus = False
        Me.No_seq.OptionsColumn.ReadOnly = True
        Me.No_seq.Visible = True
        Me.No_seq.VisibleIndex = 1
        Me.No_seq.Width = 40
        '
        'Sete
        '
        Me.Sete.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Sete.Caption = "Set"
        Me.Sete.ColumnEdit = Me.repSet
        Me.Sete.FieldName = "set"
        Me.Sete.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.Sete.Name = "Sete"
        Me.Sete.Width = 40
        '
        'repSet
        '
        Me.repSet.AutoHeight = False
        Me.repSet.Caption = ""
        Me.repSet.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.repSet.Name = "repSet"
        Me.repSet.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        Me.repSet.ValueChecked = "1"
        Me.repSet.ValueGrayed = "0"
        Me.repSet.ValueUnchecked = "0"
        '
        'Kd_Stok
        '
        Me.Kd_Stok.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Kd_Stok.Caption = "Deskripsi"
        Me.Kd_Stok.ColumnEdit = Me.repBarang
        Me.Kd_Stok.FieldName = "Kd_Stok"
        Me.Kd_Stok.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.Kd_Stok.Name = "Kd_Stok"
        Me.Kd_Stok.Visible = True
        Me.Kd_Stok.VisibleIndex = 2
        Me.Kd_Stok.Width = 326
        '
        'repBarang
        '
        Me.repBarang.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.repBarang.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup
        Me.repBarang.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.DropDown)})
        Me.repBarang.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Barang", 450, "Deskripsi"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Satuan", 50, "Satuan")})
        Me.repBarang.DisplayMember = "Nama_Barang"
        Me.repBarang.DropDownRows = 15
        Me.repBarang.HideSelection = False
        Me.repBarang.Name = "repBarang"
        Me.repBarang.NullText = ""
        Me.repBarang.PopupWidth = 500
        Me.repBarang.ShowFooter = False
        Me.repBarang.ShowHeader = False
        Me.repBarang.ShowLines = False
        Me.repBarang.ShowPopupShadow = False
        Me.repBarang.ValueMember = "Kode_Barang"
        '
        'Deskripsi
        '
        Me.Deskripsi.Caption = "Alias"
        Me.Deskripsi.ColumnEdit = Me.repDes
        Me.Deskripsi.FieldName = "Deskripsi"
        Me.Deskripsi.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.Deskripsi.Name = "Deskripsi"
        Me.Deskripsi.OptionsColumn.AllowShowHide = False
        Me.Deskripsi.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow
        Me.Deskripsi.Visible = True
        Me.Deskripsi.VisibleIndex = 3
        Me.Deskripsi.Width = 42
        '
        'repDes
        '
        Me.repDes.AutoHeight = False
        Me.repDes.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repDes.Name = "repDes"
        Me.repDes.PopupControl = Me.popDesk
        Me.repDes.ShowPopupShadow = False
        Me.repDes.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        '
        'popDesk
        '
        Me.popDesk.Controls.Add(Me.txtDesk)
        Me.popDesk.Location = New System.Drawing.Point(659, 71)
        Me.popDesk.LookAndFeel.SkinName = "Money Twins"
        Me.popDesk.Name = "popDesk"
        Me.popDesk.Padding = New System.Windows.Forms.Padding(2)
        Me.popDesk.Size = New System.Drawing.Size(356, 114)
        Me.popDesk.TabIndex = 4
        '
        'txtDesk
        '
        Me.txtDesk.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDesk.Location = New System.Drawing.Point(2, 2)
        Me.txtDesk.Name = "txtDesk"
        Me.txtDesk.Size = New System.Drawing.Size(352, 110)
        Me.txtDesk.TabIndex = 0
        '
        'Qty
        '
        Me.Qty.AppearanceCell.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Qty.AppearanceCell.Options.UseTextOptions = True
        Me.Qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Qty.AppearanceHeader.Options.UseTextOptions = True
        Me.Qty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Qty.Caption = "Qty"
        Me.Qty.ColumnEdit = Me.repQty
        Me.Qty.FieldName = "Qty"
        Me.Qty.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.Qty.Name = "Qty"
        Me.Qty.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Qty.Visible = True
        Me.Qty.VisibleIndex = 4
        Me.Qty.Width = 52
        '
        'repQty
        '
        Me.repQty.AutoHeight = False
        Me.repQty.DisplayFormat.FormatString = "n0"
        Me.repQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repQty.Name = "repQty"
        Me.repQty.SpinStyle = DevExpress.XtraEditors.Controls.SpinStyles.Horizontal
        '
        'Kd_satuan
        '
        Me.Kd_satuan.AppearanceCell.Options.UseFont = True
        Me.Kd_satuan.AppearanceHeader.Options.UseFont = True
        Me.Kd_satuan.Caption = "Satuan"
        Me.Kd_satuan.FieldName = "Kd_satuan"
        Me.Kd_satuan.Name = "Kd_satuan"
        Me.Kd_satuan.OptionsColumn.AllowEdit = False
        Me.Kd_satuan.OptionsColumn.AllowFocus = False
        Me.Kd_satuan.Visible = True
        Me.Kd_satuan.VisibleIndex = 7
        Me.Kd_satuan.Width = 54
        '
        'Keterangan
        '
        Me.Keterangan.Caption = "Keterangan"
        Me.Keterangan.FieldName = "Keterangan"
        Me.Keterangan.Name = "Keterangan"
        Me.Keterangan.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor
        Me.Keterangan.Visible = True
        Me.Keterangan.VisibleIndex = 12
        Me.Keterangan.Width = 164
        '
        'tglKirims
        '
        Me.tglKirims.Caption = "Janji Kirim SO"
        Me.tglKirims.ColumnEdit = Me.repTglKirim
        Me.tglKirims.FieldName = "Tgl_Kirim_Marketing"
        Me.tglKirims.Name = "tglKirims"
        Me.tglKirims.Visible = True
        Me.tglKirims.VisibleIndex = 10
        Me.tglKirims.Width = 94
        '
        'repTglKirim
        '
        Me.repTglKirim.AutoHeight = False
        Me.repTglKirim.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repTglKirim.Name = "repTglKirim"
        Me.repTglKirim.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        '
        'tgl_kirim_ppic
        '
        Me.tgl_kirim_ppic.Caption = "Janji Kirim PPIC"
        Me.tgl_kirim_ppic.ColumnEdit = Me.repTglKirim
        Me.tgl_kirim_ppic.FieldName = "tgl_kirim"
        Me.tgl_kirim_ppic.Name = "tgl_kirim_ppic"
        Me.tgl_kirim_ppic.Visible = True
        Me.tgl_kirim_ppic.VisibleIndex = 11
        Me.tgl_kirim_ppic.Width = 103
        '
        'harga
        '
        Me.harga.AppearanceCell.Options.UseTextOptions = True
        Me.harga.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.harga.AppearanceHeader.Options.UseTextOptions = True
        Me.harga.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.harga.Caption = "Harga"
        Me.harga.ColumnEdit = Me.repHarga
        Me.harga.DisplayFormat.FormatString = "n2"
        Me.harga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.harga.FieldName = "harga"
        Me.harga.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.harga.Name = "harga"
        Me.harga.OptionsColumn.AllowFocus = False
        Me.harga.Visible = True
        Me.harga.VisibleIndex = 5
        Me.harga.Width = 86
        '
        'repHarga
        '
        Me.repHarga.AutoHeight = False
        Me.repHarga.DisplayFormat.FormatString = "n2"
        Me.repHarga.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repHarga.EditFormat.FormatString = "n2"
        Me.repHarga.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.repHarga.Name = "repHarga"
        '
        'Potongan
        '
        Me.Potongan.AppearanceCell.BackColor = System.Drawing.Color.Red
        Me.Potongan.AppearanceCell.ForeColor = System.Drawing.Color.White
        Me.Potongan.AppearanceCell.Options.UseBackColor = True
        Me.Potongan.AppearanceCell.Options.UseFont = True
        Me.Potongan.AppearanceCell.Options.UseForeColor = True
        Me.Potongan.AppearanceCell.Options.UseTextOptions = True
        Me.Potongan.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Potongan.AppearanceHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Potongan.AppearanceHeader.ForeColor = System.Drawing.Color.Red
        Me.Potongan.AppearanceHeader.Options.UseBackColor = True
        Me.Potongan.AppearanceHeader.Options.UseForeColor = True
        Me.Potongan.AppearanceHeader.Options.UseTextOptions = True
        Me.Potongan.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Potongan.Caption = "Potongan"
        Me.Potongan.DisplayFormat.FormatString = "n2"
        Me.Potongan.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Potongan.FieldName = "potongan"
        Me.Potongan.Name = "Potongan"
        Me.Potongan.OptionsColumn.AllowEdit = False
        Me.Potongan.OptionsColumn.AllowFocus = False
        Me.Potongan.Width = 77
        '
        'Total
        '
        Me.Total.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Total.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Total.AppearanceCell.Options.UseBackColor = True
        Me.Total.AppearanceCell.Options.UseFont = True
        Me.Total.AppearanceCell.Options.UseTextOptions = True
        Me.Total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Total.AppearanceHeader.Options.UseTextOptions = True
        Me.Total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Total.Caption = "Total"
        Me.Total.DisplayFormat.FormatString = "n2"
        Me.Total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.Total.FieldName = "total"
        Me.Total.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.Total.Name = "Total"
        Me.Total.OptionsColumn.AllowEdit = False
        Me.Total.OptionsColumn.AllowFocus = False
        Me.Total.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.Total.SummaryItem.Tag = "Total Order"
        Me.Total.Visible = True
        Me.Total.VisibleIndex = 19
        Me.Total.Width = 152
        '
        'Priority
        '
        Me.Priority.Caption = "Prioritas"
        Me.Priority.ColumnEdit = Me.repPrioritas
        Me.Priority.FieldName = "prioritas"
        Me.Priority.Name = "Priority"
        Me.Priority.Visible = True
        Me.Priority.VisibleIndex = 9
        Me.Priority.Width = 90
        '
        'repPrioritas
        '
        Me.repPrioritas.AutoHeight = False
        Me.repPrioritas.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repPrioritas.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.repPrioritas.ImmediatePopup = True
        Me.repPrioritas.Items.AddRange(New Object() {"", "Penting"})
        Me.repPrioritas.Name = "repPrioritas"
        Me.repPrioritas.PopupFormMinSize = New System.Drawing.Size(200, 200)
        Me.repPrioritas.PopupFormSize = New System.Drawing.Size(200, 200)
        Me.repPrioritas.PopupSizeable = True
        '
        'states
        '
        Me.states.Caption = "state"
        Me.states.FieldName = "state"
        Me.states.Name = "states"
        '
        'disc1
        '
        Me.disc1.Caption = "disc1"
        Me.disc1.ColumnEdit = Me.repHarga
        Me.disc1.FieldName = "disc1"
        Me.disc1.Name = "disc1"
        Me.disc1.Visible = True
        Me.disc1.VisibleIndex = 13
        '
        'disc2
        '
        Me.disc2.Caption = "disc2"
        Me.disc2.ColumnEdit = Me.repHarga
        Me.disc2.FieldName = "disc2"
        Me.disc2.Name = "disc2"
        Me.disc2.Visible = True
        Me.disc2.VisibleIndex = 14
        '
        'disc3
        '
        Me.disc3.Caption = "disc3"
        Me.disc3.ColumnEdit = Me.repHarga
        Me.disc3.FieldName = "disc3"
        Me.disc3.Name = "disc3"
        Me.disc3.Visible = True
        Me.disc3.VisibleIndex = 15
        '
        'disc4
        '
        Me.disc4.Caption = "disc4"
        Me.disc4.ColumnEdit = Me.repHarga
        Me.disc4.FieldName = "disc4"
        Me.disc4.Name = "disc4"
        Me.disc4.Visible = True
        Me.disc4.VisibleIndex = 16
        '
        'disc5
        '
        Me.disc5.Caption = "disc5"
        Me.disc5.ColumnEdit = Me.repHarga
        Me.disc5.FieldName = "disc5"
        Me.disc5.Name = "disc5"
        Me.disc5.Visible = True
        Me.disc5.VisibleIndex = 17
        '
        'potTotal
        '
        Me.potTotal.Caption = "potTotal"
        Me.potTotal.FieldName = "potongan_total"
        Me.potTotal.Name = "potTotal"
        '
        'ambil_bonus
        '
        Me.ambil_bonus.Caption = "Promo"
        Me.ambil_bonus.ColumnEdit = Me.repBonus
        Me.ambil_bonus.FieldName = "ambil_bonus"
        Me.ambil_bonus.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.ambil_bonus.Name = "ambil_bonus"
        Me.ambil_bonus.Width = 51
        '
        'colDel
        '
        Me.colDel.ColumnEdit = Me.repDel
        Me.colDel.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.colDel.Name = "colDel"
        Me.colDel.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.[False]
        Me.colDel.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
        Me.colDel.Visible = True
        Me.colDel.VisibleIndex = 20
        Me.colDel.Width = 30
        '
        'repDel
        '
        Me.repDel.AutoHeight = False
        Me.repDel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("repDel.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "Hapus Data", Nothing, Nothing, True)})
        Me.repDel.Name = "repDel"
        '
        'Nama_Potongan
        '
        Me.Nama_Potongan.AppearanceCell.ForeColor = System.Drawing.Color.Red
        Me.Nama_Potongan.AppearanceCell.Options.UseForeColor = True
        Me.Nama_Potongan.Caption = "Potongan"
        Me.Nama_Potongan.FieldName = "nama_potongan"
        Me.Nama_Potongan.Name = "Nama_Potongan"
        Me.Nama_Potongan.OptionsColumn.AllowEdit = False
        Me.Nama_Potongan.OptionsColumn.AllowFocus = False
        Me.Nama_Potongan.Visible = True
        Me.Nama_Potongan.VisibleIndex = 8
        '
        'BNS
        '
        Me.BNS.AppearanceCell.Options.UseTextOptions = True
        Me.BNS.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BNS.AppearanceHeader.Options.UseTextOptions = True
        Me.BNS.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.BNS.Caption = "Bns"
        Me.BNS.ColumnEdit = Me.repBns
        Me.BNS.FieldName = "Bonus"
        Me.BNS.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right
        Me.BNS.Name = "BNS"
        Me.BNS.Visible = True
        Me.BNS.VisibleIndex = 18
        Me.BNS.Width = 47
        '
        'repBns
        '
        Me.repBns.AutoHeight = False
        Me.repBns.Name = "repBns"
        Me.repBns.ValueChecked = "Y"
        Me.repBns.ValueUnchecked = "T"
        '
        'Stok
        '
        Me.Stok.AppearanceHeader.Options.UseTextOptions = True
        Me.Stok.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.Stok.Caption = "Stok"
        Me.Stok.ColumnEdit = Me.repQty
        Me.Stok.FieldName = "Stok"
        Me.Stok.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.Stok.Name = "Stok"
        Me.Stok.OptionsColumn.AllowEdit = False
        Me.Stok.OptionsColumn.AllowFocus = False
        Me.Stok.Visible = True
        Me.Stok.VisibleIndex = 6
        Me.Stok.Width = 50
        '
        'isLocked
        '
        Me.isLocked.Caption = " "
        Me.isLocked.ColumnEdit = Me.RepositoryItemCheckEdit1
        Me.isLocked.FieldName = "isLocked"
        Me.isLocked.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        Me.isLocked.Name = "isLocked"
        Me.isLocked.OptionsColumn.AllowEdit = False
        Me.isLocked.OptionsColumn.AllowFocus = False
        Me.isLocked.OptionsColumn.AllowMove = False
        Me.isLocked.OptionsColumn.AllowSize = False
        Me.isLocked.Visible = True
        Me.isLocked.VisibleIndex = 0
        Me.isLocked.Width = 26
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.PictureChecked = CType(resources.GetObject("RepositoryItemCheckEdit1.PictureChecked"), System.Drawing.Image)
        Me.RepositoryItemCheckEdit1.PictureGrayed = CType(resources.GetObject("RepositoryItemCheckEdit1.PictureGrayed"), System.Drawing.Image)
        Me.RepositoryItemCheckEdit1.PictureUnchecked = CType(resources.GetObject("RepositoryItemCheckEdit1.PictureUnchecked"), System.Drawing.Image)
        Me.RepositoryItemCheckEdit1.ReadOnly = True
        Me.RepositoryItemCheckEdit1.ValueChecked = "1"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "0"
        '
        'repKeterangan
        '
        Me.repKeterangan.AutoHeight = False
        Me.repKeterangan.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repKeterangan.Name = "repKeterangan"
        Me.repKeterangan.ValidateOnEnterKey = True
        '
        'RepPop
        '
        Me.RepPop.AutoHeight = False
        Me.RepPop.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepPop.Name = "RepPop"
        Me.RepPop.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.RepPop.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        '
        'RepDesk
        '
        Me.RepDesk.Name = "RepDesk"
        '
        'RepositoryItemCheckEdit2
        '
        Me.RepositoryItemCheckEdit2.AutoHeight = False
        Me.RepositoryItemCheckEdit2.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined
        Me.RepositoryItemCheckEdit2.Name = "RepositoryItemCheckEdit2"
        Me.RepositoryItemCheckEdit2.PictureChecked = CType(resources.GetObject("RepositoryItemCheckEdit2.PictureChecked"), System.Drawing.Image)
        Me.RepositoryItemCheckEdit2.PictureGrayed = CType(resources.GetObject("RepositoryItemCheckEdit2.PictureGrayed"), System.Drawing.Image)
        Me.RepositoryItemCheckEdit2.PictureUnchecked = CType(resources.GetObject("RepositoryItemCheckEdit2.PictureUnchecked"), System.Drawing.Image)
        Me.RepositoryItemCheckEdit2.ValueChecked = "1"
        Me.RepositoryItemCheckEdit2.ValueUnchecked = "0"
        '
        'popCon
        '
        Me.popCon.Appearance.BackColor = System.Drawing.Color.Red
        Me.popCon.Appearance.Options.UseBackColor = True
        Me.popCon.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.popCon.Controls.Add(Me.popBiaya)
        Me.popCon.Controls.Add(Me.gcCari)
        Me.popCon.Controls.Add(Me.Panel21)
        Me.popCon.Location = New System.Drawing.Point(3, 83)
        Me.popCon.LookAndFeel.SkinName = "Money Twins"
        Me.popCon.LookAndFeel.UseDefaultLookAndFeel = False
        Me.popCon.Name = "popCon"
        Me.popCon.Padding = New System.Windows.Forms.Padding(2)
        Me.popCon.Size = New System.Drawing.Size(819, 318)
        Me.popCon.TabIndex = 3
        '
        'popBiaya
        '
        Me.popBiaya.Controls.Add(Me.GC_Biaya)
        Me.popBiaya.Location = New System.Drawing.Point(121, 55)
        Me.popBiaya.LookAndFeel.SkinName = "Money Twins"
        Me.popBiaya.Name = "popBiaya"
        Me.popBiaya.Padding = New System.Windows.Forms.Padding(2)
        Me.popBiaya.Size = New System.Drawing.Size(398, 156)
        Me.popBiaya.TabIndex = 13
        '
        'GC_Biaya
        '
        Me.GC_Biaya.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GC_Biaya.Location = New System.Drawing.Point(2, 2)
        Me.GC_Biaya.LookAndFeel.SkinName = "The Asphalt World"
        Me.GC_Biaya.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GC_Biaya.MainView = Me.GV_Biaya
        Me.GC_Biaya.Name = "GC_Biaya"
        Me.GC_Biaya.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repBiaya, Me.repNum})
        Me.GC_Biaya.Size = New System.Drawing.Size(394, 152)
        Me.GC_Biaya.TabIndex = 0
        Me.GC_Biaya.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GV_Biaya})
        '
        'GV_Biaya
        '
        Me.GV_Biaya.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_Biaya.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_Biaya.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Black
        Me.GV_Biaya.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GV_Biaya.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Biaya.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Biaya.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Black
        Me.GV_Biaya.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GV_Biaya.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV_Biaya.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GV_Biaya.Appearance.Empty.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GV_Biaya.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GV_Biaya.Appearance.EvenRow.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.EvenRow.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_Biaya.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_Biaya.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black
        Me.GV_Biaya.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GV_Biaya.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV_Biaya.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.White
        Me.GV_Biaya.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_Biaya.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(218, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.GV_Biaya.Appearance.FixedLine.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.FocusedCell.BackColor = System.Drawing.Color.White
        Me.GV_Biaya.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black
        Me.GV_Biaya.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(154, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GV_Biaya.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White
        Me.GV_Biaya.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_Biaya.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_Biaya.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_Biaya.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GV_Biaya.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Biaya.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Biaya.Appearance.GroupButton.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GV_Biaya.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Biaya.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Biaya.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black
        Me.GV_Biaya.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GV_Biaya.Appearance.GroupFooter.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV_Biaya.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White
        Me.GV_Biaya.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_Biaya.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Biaya.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Biaya.Appearance.GroupRow.ForeColor = System.Drawing.Color.Black
        Me.GV_Biaya.Appearance.GroupRow.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GV_Biaya.Appearance.GroupRow.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Biaya.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.GV_Biaya.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GV_Biaya.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GV_Biaya.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(183, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.GV_Biaya.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV_Biaya.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_Biaya.Appearance.HorzLine.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.OddRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GV_Biaya.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GV_Biaya.Appearance.OddRow.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.OddRow.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(254, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.GV_Biaya.Appearance.Preview.Font = New System.Drawing.Font("Verdana", 7.5!)
        Me.GV_Biaya.Appearance.Preview.ForeColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(146, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.GV_Biaya.Appearance.Preview.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.Preview.Options.UseFont = True
        Me.GV_Biaya.Appearance.Preview.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GV_Biaya.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(CType(CType(253, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GV_Biaya.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GV_Biaya.Appearance.Row.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.Row.Options.UseBorderColor = True
        Me.GV_Biaya.Appearance.Row.Options.UseForeColor = True
        Me.GV_Biaya.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.GV_Biaya.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GV_Biaya.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.GV_Biaya.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GV_Biaya.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GV_Biaya.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(177, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.GV_Biaya.Appearance.VertLine.Options.UseBackColor = True
        Me.GV_Biaya.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.kd_biaya, Me.biaya})
        Me.GV_Biaya.GridControl = Me.GC_Biaya
        Me.GV_Biaya.Name = "GV_Biaya"
        Me.GV_Biaya.OptionsView.EnableAppearanceEvenRow = True
        Me.GV_Biaya.OptionsView.EnableAppearanceOddRow = True
        Me.GV_Biaya.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top
        Me.GV_Biaya.OptionsView.ShowFooter = True
        Me.GV_Biaya.OptionsView.ShowGroupPanel = False
        Me.GV_Biaya.OptionsView.ShowHorzLines = False
        Me.GV_Biaya.OptionsView.ShowVertLines = False
        '
        'kd_biaya
        '
        Me.kd_biaya.Caption = "Nama Biaya"
        Me.kd_biaya.ColumnEdit = Me.repBiaya
        Me.kd_biaya.FieldName = "kd_biaya"
        Me.kd_biaya.Name = "kd_biaya"
        Me.kd_biaya.Visible = True
        Me.kd_biaya.VisibleIndex = 0
        Me.kd_biaya.Width = 244
        '
        'repBiaya
        '
        Me.repBiaya.AutoHeight = False
        Me.repBiaya.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.repBiaya.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("deskripsi", "Biaya")})
        Me.repBiaya.DisplayMember = "deskripsi"
        Me.repBiaya.Name = "repBiaya"
        Me.repBiaya.NullText = ""
        Me.repBiaya.ValueMember = "kd_biaya"
        '
        'biaya
        '
        Me.biaya.Caption = "Besar Biaya"
        Me.biaya.ColumnEdit = Me.repNum
        Me.biaya.DisplayFormat.FormatString = "n2"
        Me.biaya.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.biaya.FieldName = "biaya"
        Me.biaya.Name = "biaya"
        Me.biaya.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        Me.biaya.Visible = True
        Me.biaya.VisibleIndex = 1
        Me.biaya.Width = 133
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
        'gcCari
        '
        Me.gcCari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gcCari.Location = New System.Drawing.Point(5, 25)
        Me.gcCari.LookAndFeel.SkinName = "Lilian"
        Me.gcCari.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gcCari.MainView = Me.gvCari
        Me.gcCari.Name = "gcCari"
        Me.gcCari.Size = New System.Drawing.Size(809, 288)
        Me.gcCari.TabIndex = 1
        Me.gcCari.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvCari})
        '
        'gvCari
        '
        Me.gvCari.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3})
        Me.gvCari.GridControl = Me.gcCari
        Me.gvCari.Name = "gvCari"
        Me.gvCari.OptionsBehavior.Editable = False
        Me.gvCari.OptionsBehavior.ReadOnly = True
        Me.gvCari.OptionsCustomization.AllowColumnMoving = False
        Me.gvCari.OptionsView.ShowGroupPanel = False
        Me.gvCari.OptionsView.ShowHorzLines = False
        Me.gvCari.OptionsView.ShowIndicator = False
        Me.gvCari.OptionsView.ShowPreviewLines = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Kode"
        Me.GridColumn1.FieldName = "Kode_Barang"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 162
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Nama Barang"
        Me.GridColumn2.FieldName = "Nama_Barang"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 532
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Unit"
        Me.GridColumn3.FieldName = "Kd_Satuan"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 121
        '
        'Panel21
        '
        Me.Panel21.Controls.Add(Me.txtcari)
        Me.Panel21.Controls.Add(Me.Label7)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel21.Location = New System.Drawing.Point(5, 5)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(809, 20)
        Me.Panel21.TabIndex = 0
        '
        'txtcari
        '
        Me.txtcari.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.txtcari.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtcari.BackColor = System.Drawing.Color.White
        Me.txtcari.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtcari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtcari.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtcari.Location = New System.Drawing.Point(86, 0)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(723, 21)
        Me.txtcari.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Search :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnl
        '
        Me.pnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnl.Controls.Add(Me.pnlTengah)
        Me.pnl.Controls.Add(Me.pnlbawah)
        Me.pnl.Controls.Add(Me.Panel1)
        Me.pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl.Location = New System.Drawing.Point(0, 0)
        Me.pnl.Name = "pnl"
        Me.pnl.Size = New System.Drawing.Size(992, 609)
        Me.pnl.TabIndex = 1
        '
        'pnlTengah
        '
        Me.pnlTengah.Controls.Add(Me.pnlTengahBawah)
        Me.pnlTengah.Controls.Add(Me.pnlTengahAtas)
        Me.pnlTengah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTengah.Location = New System.Drawing.Point(0, 37)
        Me.pnlTengah.Name = "pnlTengah"
        Me.pnlTengah.Size = New System.Drawing.Size(990, 466)
        Me.pnlTengah.TabIndex = 4
        '
        'pnlTengahBawah
        '
        Me.pnlTengahBawah.Controls.Add(Me.popDesk)
        Me.pnlTengahBawah.Controls.Add(Me.popCon)
        Me.pnlTengahBawah.Controls.Add(Me.GC)
        Me.pnlTengahBawah.Controls.Add(Me.Panel18)
        Me.pnlTengahBawah.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTengahBawah.Location = New System.Drawing.Point(0, 64)
        Me.pnlTengahBawah.Name = "pnlTengahBawah"
        Me.pnlTengahBawah.Size = New System.Drawing.Size(990, 402)
        Me.pnlTengahBawah.TabIndex = 1
        '
        'Panel18
        '
        Me.Panel18.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel18.Controls.Add(Me.btnKunci)
        Me.Panel18.Controls.Add(Me.lblPromo)
        Me.Panel18.Controls.Add(Me.Label6)
        Me.Panel18.Controls.Add(Me.txtKurs)
        Me.Panel18.Controls.Add(Me.vValas)
        Me.Panel18.Controls.Add(Me.Label9)
        Me.Panel18.Controls.Add(Me.cmbJenisSP)
        Me.Panel18.Controls.Add(Me.Label1)
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel18.Location = New System.Drawing.Point(0, 0)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Padding = New System.Windows.Forms.Padding(1)
        Me.Panel18.Size = New System.Drawing.Size(990, 23)
        Me.Panel18.TabIndex = 1
        '
        'btnKunci
        '
        Me.btnKunci.Appearance.BackColor = System.Drawing.Color.Lime
        Me.btnKunci.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnKunci.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKunci.Appearance.ForeColor = System.Drawing.Color.White
        Me.btnKunci.Appearance.Options.UseBackColor = True
        Me.btnKunci.Appearance.Options.UseBorderColor = True
        Me.btnKunci.Appearance.Options.UseFont = True
        Me.btnKunci.Appearance.Options.UseForeColor = True
        Me.btnKunci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnKunci.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.btnKunci.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnKunci.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnKunci.Location = New System.Drawing.Point(831, 1)
        Me.btnKunci.LookAndFeel.SkinName = "The Asphalt World"
        Me.btnKunci.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.btnKunci.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnKunci.LookAndFeel.UseWindowsXPTheme = True
        Me.btnKunci.Name = "btnKunci"
        Me.btnKunci.Size = New System.Drawing.Size(158, 21)
        Me.btnKunci.TabIndex = 22
        Me.btnKunci.Tag = "Kunci SP"
        Me.btnKunci.Text = "BUKA"
        Me.btnKunci.ToolTip = "Klik Untuk Kunci SP"
        Me.btnKunci.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.btnKunci.ToolTipTitle = "Kunci SP"
        '
        'lblPromo
        '
        Me.lblPromo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPromo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPromo.ForeColor = System.Drawing.Color.Yellow
        Me.lblPromo.Location = New System.Drawing.Point(522, 1)
        Me.lblPromo.Name = "lblPromo"
        Me.lblPromo.Size = New System.Drawing.Size(467, 21)
        Me.lblPromo.TabIndex = 21
        Me.lblPromo.Text = "-"
        Me.lblPromo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(450, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 21)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Promo : "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtKurs
        '
        Me.txtKurs.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtKurs.EditValue = 0
        Me.txtKurs.EnterMoveNextControl = True
        Me.txtKurs.Location = New System.Drawing.Point(376, 1)
        Me.txtKurs.Name = "txtKurs"
        Me.txtKurs.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtKurs.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtKurs.Properties.Appearance.Options.UseBackColor = True
        Me.txtKurs.Properties.Appearance.Options.UseForeColor = True
        Me.txtKurs.Properties.Appearance.Options.UseTextOptions = True
        Me.txtKurs.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txtKurs.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtKurs.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtKurs.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtKurs.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtKurs.Properties.DisplayFormat.FormatString = "n2"
        Me.txtKurs.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtKurs.Size = New System.Drawing.Size(74, 20)
        Me.txtKurs.TabIndex = 5
        '
        'vValas
        '
        Me.vValas.Dock = System.Windows.Forms.DockStyle.Left
        Me.vValas.Location = New System.Drawing.Point(300, 1)
        Me.vValas.Name = "vValas"
        Me.vValas.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.vValas.Properties.Appearance.Options.UseBackColor = True
        Me.vValas.Properties.Appearance.Options.UseTextOptions = True
        Me.vValas.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.vValas.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.vValas.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.vValas.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.vValas.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.vValas.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.vValas.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vValas.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.vValas.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.vValas.Properties.AppearanceFocused.Options.UseFont = True
        Me.vValas.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.vValas.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.vValas.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Valuta", 25, "Valas"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Valuta", 100, "Keterangan")})
        Me.vValas.Properties.DisplayMember = "Kode_Valuta"
        Me.vValas.Properties.DropDownRows = 15
        Me.vValas.Properties.HideSelection = False
        Me.vValas.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.vValas.Properties.NullText = ""
        Me.vValas.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.vValas.Properties.PopupFormMinSize = New System.Drawing.Size(100, 100)
        Me.vValas.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.vValas.Properties.PopupWidth = 175
        Me.vValas.Properties.ShowHeader = False
        Me.vValas.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.vValas.Properties.ValueMember = "Kode_Valuta"
        Me.vValas.Size = New System.Drawing.Size(76, 20)
        Me.vValas.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(234, 1)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 21)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "* Valas :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbJenisSP
        '
        Me.cmbJenisSP.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmbJenisSP.EditValue = "UMUM"
        Me.cmbJenisSP.Location = New System.Drawing.Point(111, 1)
        Me.cmbJenisSP.Name = "cmbJenisSP"
        Me.cmbJenisSP.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmbJenisSP.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbJenisSP.Properties.Appearance.Options.UseBackColor = True
        Me.cmbJenisSP.Properties.Appearance.Options.UseFont = True
        Me.cmbJenisSP.Properties.Appearance.Options.UseTextOptions = True
        Me.cmbJenisSP.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cmbJenisSP.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmbJenisSP.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cmbJenisSP.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmbJenisSP.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmbJenisSP.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbJenisSP.Properties.Items.AddRange(New Object() {"UMUM", "INTERNAL", "KONSINYASI"})
        Me.cmbJenisSP.Properties.LookAndFeel.SkinName = "Blue"
        Me.cmbJenisSP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbJenisSP.Size = New System.Drawing.Size(123, 20)
        Me.cmbJenisSP.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 21)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "* Jenis Order :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlTengahAtas
        '
        Me.pnlTengahAtas.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pnlTengahAtas.Controls.Add(Me.Panel2)
        Me.pnlTengahAtas.Controls.Add(Me.Panel3)
        Me.pnlTengahAtas.Controls.Add(Me.Panel5)
        Me.pnlTengahAtas.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTengahAtas.ForeColor = System.Drawing.Color.White
        Me.pnlTengahAtas.Location = New System.Drawing.Point(0, 0)
        Me.pnlTengahAtas.Name = "pnlTengahAtas"
        Me.pnlTengahAtas.Padding = New System.Windows.Forms.Padding(1)
        Me.pnlTengahAtas.Size = New System.Drawing.Size(990, 64)
        Me.pnlTengahAtas.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(718, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(113, 62)
        Me.Panel2.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(0, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "SP Reff :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Tanggal :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nomor :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.spReff)
        Me.Panel3.Controls.Add(Me.DT_TglSO)
        Me.Panel3.Controls.Add(Me.tglSO)
        Me.Panel3.Controls.Add(Me.txtNomor)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(831, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(158, 62)
        Me.Panel3.TabIndex = 6
        '
        'spReff
        '
        Me.spReff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spReff.Location = New System.Drawing.Point(0, 40)
        Me.spReff.Name = "spReff"
        Me.spReff.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.spReff.Properties.Appearance.Options.UseBackColor = True
        Me.spReff.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.spReff.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.spReff.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.spReff.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.spReff.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.spReff.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.spReff.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.spReff.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.spReff.Properties.AppearanceFocused.Options.UseFont = True
        Me.spReff.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.spReff.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.spReff.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("NO_SP", 125, "Nomor"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("TGL_SP", 75, "Tanggal")})
        Me.spReff.Properties.DisplayMember = "NO_SP"
        Me.spReff.Properties.HideSelection = False
        Me.spReff.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.spReff.Properties.NullText = "[SP REFF]"
        Me.spReff.Properties.PopupWidth = 300
        Me.spReff.Properties.ShowHeader = False
        Me.spReff.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.spReff.Properties.ValueMember = "NO_SP"
        Me.spReff.Size = New System.Drawing.Size(158, 20)
        Me.spReff.TabIndex = 8
        '
        'DT_TglSO
        '
        Me.DT_TglSO.EditValue = Nothing
        Me.DT_TglSO.Location = New System.Drawing.Point(0, 20)
        Me.DT_TglSO.Name = "DT_TglSO"
        Me.DT_TglSO.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DT_TglSO.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.DT_TglSO.Size = New System.Drawing.Size(158, 20)
        Me.DT_TglSO.TabIndex = 7
        '
        'tglSO
        '
        Me.tglSO.Dock = System.Windows.Forms.DockStyle.Top
        Me.tglSO.Enabled = False
        Me.tglSO.Location = New System.Drawing.Point(0, 20)
        Me.tglSO.Name = "tglSO"
        Me.tglSO.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tglSO.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglSO.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.tglSO.Properties.Appearance.Options.UseBackColor = True
        Me.tglSO.Properties.Appearance.Options.UseFont = True
        Me.tglSO.Properties.Appearance.Options.UseForeColor = True
        Me.tglSO.Properties.Appearance.Options.UseTextOptions = True
        Me.tglSO.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.tglSO.Properties.AutoHeight = False
        Me.tglSO.Properties.DisplayFormat.FormatString = "N0"
        Me.tglSO.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.tglSO.Size = New System.Drawing.Size(158, 20)
        Me.tglSO.TabIndex = 5
        '
        'txtNomor
        '
        Me.txtNomor.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtNomor.Enabled = False
        Me.txtNomor.Location = New System.Drawing.Point(0, 0)
        Me.txtNomor.Name = "txtNomor"
        Me.txtNomor.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNomor.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNomor.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtNomor.Properties.Appearance.Options.UseBackColor = True
        Me.txtNomor.Properties.Appearance.Options.UseFont = True
        Me.txtNomor.Properties.Appearance.Options.UseForeColor = True
        Me.txtNomor.Properties.Appearance.Options.UseTextOptions = True
        Me.txtNomor.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtNomor.Properties.AutoHeight = False
        Me.txtNomor.Properties.DisplayFormat.FormatString = "N0"
        Me.txtNomor.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtNomor.Properties.ReadOnly = True
        Me.txtNomor.Size = New System.Drawing.Size(158, 20)
        Me.txtNomor.TabIndex = 6
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.ckPPN)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(1, 1)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(738, 62)
        Me.Panel5.TabIndex = 3
        '
        'ckPPN
        '
        Me.ckPPN.Location = New System.Drawing.Point(535, 35)
        Me.ckPPN.Name = "ckPPN"
        Me.ckPPN.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckPPN.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Window
        Me.ckPPN.Properties.Appearance.Options.UseFont = True
        Me.ckPPN.Properties.Appearance.Options.UseForeColor = True
        Me.ckPPN.Properties.Caption = ""
        Me.ckPPN.Properties.LookAndFeel.SkinName = "Black"
        Me.ckPPN.Size = New System.Drawing.Size(26, 21)
        Me.ckPPN.TabIndex = 12
        Me.ckPPN.Visible = False
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Controls.Add(Me.Panel25)
        Me.Panel7.Controls.Add(Me.Panel6)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(110, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(628, 62)
        Me.Panel7.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.txtNamaSales)
        Me.Panel9.Controls.Add(Me.txtSales)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(0, 41)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(628, 22)
        Me.Panel9.TabIndex = 2
        '
        'txtNamaSales
        '
        Me.txtNamaSales.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtNamaSales.Enabled = False
        Me.txtNamaSales.Location = New System.Drawing.Point(234, 0)
        Me.txtNamaSales.Name = "txtNamaSales"
        Me.txtNamaSales.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNamaSales.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtNamaSales.Properties.Appearance.Options.UseBackColor = True
        Me.txtNamaSales.Properties.Appearance.Options.UseForeColor = True
        Me.txtNamaSales.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtNamaSales.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtNamaSales.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtNamaSales.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtNamaSales.Properties.ReadOnly = True
        Me.txtNamaSales.Size = New System.Drawing.Size(105, 20)
        Me.txtNamaSales.TabIndex = 7
        '
        'txtSales
        '
        Me.txtSales.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtSales.Location = New System.Drawing.Point(0, 0)
        Me.txtSales.Name = "txtSales"
        Me.txtSales.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtSales.Properties.Appearance.Options.UseBackColor = True
        Me.txtSales.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtSales.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtSales.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtSales.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtSales.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtSales.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSales.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.txtSales.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtSales.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtSales.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtSales.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtSales.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kode_Sales", 50, "Kode"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Sales", 150, "Nama")})
        Me.txtSales.Properties.HideSelection = False
        Me.txtSales.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.txtSales.Properties.NullText = "[Pilih Sales]"
        Me.txtSales.Properties.PopupWidth = 300
        Me.txtSales.Properties.ShowHeader = False
        Me.txtSales.Size = New System.Drawing.Size(234, 20)
        Me.txtSales.TabIndex = 2
        '
        'Panel25
        '
        Me.Panel25.Controls.Add(Me.lblStateCR)
        Me.Panel25.Controls.Add(Me.cmbAtasNama)
        Me.Panel25.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel25.Location = New System.Drawing.Point(0, 20)
        Me.Panel25.Name = "Panel25"
        Me.Panel25.Size = New System.Drawing.Size(628, 21)
        Me.Panel25.TabIndex = 6
        '
        'lblStateCR
        '
        Me.lblStateCR.AutoSize = True
        Me.lblStateCR.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateCR.ForeColor = System.Drawing.Color.Yellow
        Me.lblStateCR.Location = New System.Drawing.Point(345, 3)
        Me.lblStateCR.Name = "lblStateCR"
        Me.lblStateCR.Size = New System.Drawing.Size(38, 13)
        Me.lblStateCR.TabIndex = 5
        Me.lblStateCR.Text = "Label9"
        '
        'cmbAtasNama
        '
        Me.cmbAtasNama.Dock = System.Windows.Forms.DockStyle.Left
        Me.cmbAtasNama.EditValue = ""
        Me.cmbAtasNama.Location = New System.Drawing.Point(0, 0)
        Me.cmbAtasNama.Name = "cmbAtasNama"
        Me.cmbAtasNama.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmbAtasNama.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAtasNama.Properties.Appearance.Options.UseBackColor = True
        Me.cmbAtasNama.Properties.Appearance.Options.UseFont = True
        Me.cmbAtasNama.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.cmbAtasNama.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.cmbAtasNama.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.cmbAtasNama.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.cmbAtasNama.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmbAtasNama.Properties.Items.AddRange(New Object() {"UMUM", "INTERNAL", "KONSINYASI"})
        Me.cmbAtasNama.Properties.LookAndFeel.SkinName = "Blue"
        Me.cmbAtasNama.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cmbAtasNama.Size = New System.Drawing.Size(339, 20)
        Me.cmbAtasNama.TabIndex = 4
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.lblStatus)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.txtKodeCust)
        Me.Panel6.Controls.Add(Me.txtCustomer)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(628, 20)
        Me.Panel6.TabIndex = 1
        Me.Panel6.TabStop = True
        '
        'lblStatus
        '
        Me.lblStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblStatus.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Yellow
        Me.lblStatus.Location = New System.Drawing.Point(411, 0)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(217, 20)
        Me.lblStatus.TabIndex = 16
        Me.lblStatus.Text = " [ New ]"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(339, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 20)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Status :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtKodeCust
        '
        Me.txtKodeCust.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtKodeCust.Enabled = False
        Me.txtKodeCust.EnterMoveNextControl = True
        Me.txtKodeCust.Location = New System.Drawing.Point(234, 0)
        Me.txtKodeCust.Name = "txtKodeCust"
        Me.txtKodeCust.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtKodeCust.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txtKodeCust.Properties.Appearance.Options.UseBackColor = True
        Me.txtKodeCust.Properties.Appearance.Options.UseForeColor = True
        Me.txtKodeCust.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtKodeCust.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtKodeCust.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtKodeCust.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtKodeCust.Properties.ReadOnly = True
        Me.txtKodeCust.Size = New System.Drawing.Size(105, 20)
        Me.txtKodeCust.TabIndex = 1
        '
        'txtCustomer
        '
        Me.txtCustomer.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtCustomer.EnterMoveNextControl = True
        Me.txtCustomer.Location = New System.Drawing.Point(0, 0)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtCustomer.Properties.Appearance.Options.UseBackColor = True
        Me.txtCustomer.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.White
        Me.txtCustomer.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black
        Me.txtCustomer.Properties.AppearanceDisabled.Options.UseBackColor = True
        Me.txtCustomer.Properties.AppearanceDisabled.Options.UseForeColor = True
        Me.txtCustomer.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtCustomer.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomer.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.txtCustomer.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtCustomer.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtCustomer.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtCustomer.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit
        Me.txtCustomer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtCustomer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtCustomer.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kd_Customer", "Kode", 5, DevExpress.Utils.FormatType.None, "", False, DevExpress.Utils.HorzAlignment.[Default]), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Customer", 150, "Nama"), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Alamat1", 200, "Alamat")})
        Me.txtCustomer.Properties.DisplayMember = "Nama_Customer"
        Me.txtCustomer.Properties.DropDownRows = 15
        Me.txtCustomer.Properties.HideSelection = False
        Me.txtCustomer.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.txtCustomer.Properties.ImmediatePopup = True
        Me.txtCustomer.Properties.NullText = "[Pilih Pelanggan]"
        Me.txtCustomer.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.Style3D
        Me.txtCustomer.Properties.PopupResizeMode = DevExpress.XtraEditors.Controls.ResizeMode.LiveResize
        Me.txtCustomer.Properties.PopupWidth = 400
        Me.txtCustomer.Properties.ShowHeader = False
        Me.txtCustomer.Properties.ShowPopupShadow = False
        Me.txtCustomer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtCustomer.Properties.ThrowExceptionOnInvalidLookUpEditValueType = True
        Me.txtCustomer.Properties.UseCtrlScroll = True
        Me.txtCustomer.Properties.ValidateOnEnterKey = True
        Me.txtCustomer.Properties.ValueMember = "Kd_Customer"
        Me.txtCustomer.Size = New System.Drawing.Size(234, 20)
        Me.txtCustomer.TabIndex = 1
        Me.txtCustomer.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.txtCustomer.ToolTipTitle = "Nama Customer"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(110, 62)
        Me.Panel4.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(0, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "* Sales :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(0, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 20)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "* Atas Nama :"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "* Customer :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlbawah
        '
        Me.pnlbawah.Controls.Add(Me.Panel14)
        Me.pnlbawah.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlbawah.Location = New System.Drawing.Point(0, 503)
        Me.pnlbawah.Name = "pnlbawah"
        Me.pnlbawah.Size = New System.Drawing.Size(990, 104)
        Me.pnlbawah.TabIndex = 3
        '
        'Panel14
        '
        Me.Panel14.BackColor = System.Drawing.Color.Black
        Me.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel14.Controls.Add(Me.Panel16)
        Me.Panel14.Controls.Add(Me.Panel11)
        Me.Panel14.Controls.Add(Me.Panel10)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(990, 104)
        Me.Panel14.TabIndex = 3
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.Panel19)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel16.Location = New System.Drawing.Point(640, 0)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(348, 102)
        Me.Panel16.TabIndex = 4
        '
        'Panel19
        '
        Me.Panel19.Controls.Add(Me.Panel15)
        Me.Panel19.Controls.Add(Me.Panel17)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel19.Location = New System.Drawing.Point(0, 0)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(348, 102)
        Me.Panel19.TabIndex = 6
        '
        'Panel15
        '
        Me.Panel15.BackColor = System.Drawing.Color.Black
        Me.Panel15.Controls.Add(Me.Panel23)
        Me.Panel15.Controls.Add(Me.Panel22)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel15.Location = New System.Drawing.Point(89, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(259, 44)
        Me.Panel15.TabIndex = 0
        '
        'Panel23
        '
        Me.Panel23.Controls.Add(Me.txtBiaya2)
        Me.Panel23.Controls.Add(Me.txtBiaya)
        Me.Panel23.Controls.Add(Me.lblTotal)
        Me.Panel23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel23.Location = New System.Drawing.Point(105, 0)
        Me.Panel23.Name = "Panel23"
        Me.Panel23.Size = New System.Drawing.Size(154, 44)
        Me.Panel23.TabIndex = 6
        '
        'txtBiaya2
        '
        Me.txtBiaya2.EditValue = ""
        Me.txtBiaya2.Enabled = False
        Me.txtBiaya2.Location = New System.Drawing.Point(0, 1)
        Me.txtBiaya2.Name = "txtBiaya2"
        Me.txtBiaya2.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.txtBiaya2.Properties.Appearance.BorderColor = System.Drawing.Color.Red
        Me.txtBiaya2.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBiaya2.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtBiaya2.Properties.Appearance.Options.UseBackColor = True
        Me.txtBiaya2.Properties.Appearance.Options.UseBorderColor = True
        Me.txtBiaya2.Properties.Appearance.Options.UseFont = True
        Me.txtBiaya2.Properties.Appearance.Options.UseForeColor = True
        Me.txtBiaya2.Properties.Appearance.Options.UseTextOptions = True
        Me.txtBiaya2.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtBiaya2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtBiaya2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, True, DevExpress.XtraEditors.ImageLocation.MiddleCenter, CType(resources.GetObject("txtBiaya2.Properties.Buttons"), System.Drawing.Image), New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject2, "", Nothing, Nothing, True)})
        Me.txtBiaya2.Properties.CloseOnLostFocus = False
        Me.txtBiaya2.Properties.CloseOnOuterMouseClick = False
        Me.txtBiaya2.Properties.DisplayFormat.FormatString = "n2"
        Me.txtBiaya2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBiaya2.Properties.PopupControl = Me.popBiaya
        Me.txtBiaya2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtBiaya2.Size = New System.Drawing.Size(26, 22)
        Me.txtBiaya2.TabIndex = 5
        '
        'txtBiaya
        '
        Me.txtBiaya.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtBiaya.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtBiaya.Location = New System.Drawing.Point(0, 0)
        Me.txtBiaya.Name = "txtBiaya"
        Me.txtBiaya.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.txtBiaya.Properties.Appearance.BorderColor = System.Drawing.Color.Red
        Me.txtBiaya.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBiaya.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.txtBiaya.Properties.Appearance.Options.UseBackColor = True
        Me.txtBiaya.Properties.Appearance.Options.UseBorderColor = True
        Me.txtBiaya.Properties.Appearance.Options.UseFont = True
        Me.txtBiaya.Properties.Appearance.Options.UseForeColor = True
        Me.txtBiaya.Properties.Appearance.Options.UseTextOptions = True
        Me.txtBiaya.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txtBiaya.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txtBiaya.Properties.DisplayFormat.FormatString = "n2"
        Me.txtBiaya.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtBiaya.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtBiaya.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtBiaya.Properties.ReadOnly = True
        Me.txtBiaya.Size = New System.Drawing.Size(154, 22)
        Me.txtBiaya.TabIndex = 6
        '
        'lblTotal
        '
        Me.lblTotal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblTotal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.lblTotal.Location = New System.Drawing.Point(0, 22)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.lblTotal.Properties.Appearance.BorderColor = System.Drawing.Color.Red
        Me.lblTotal.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Properties.Appearance.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Properties.Appearance.Options.UseBackColor = True
        Me.lblTotal.Properties.Appearance.Options.UseBorderColor = True
        Me.lblTotal.Properties.Appearance.Options.UseFont = True
        Me.lblTotal.Properties.Appearance.Options.UseForeColor = True
        Me.lblTotal.Properties.Appearance.Options.UseTextOptions = True
        Me.lblTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lblTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.lblTotal.Properties.DisplayFormat.FormatString = "n2"
        Me.lblTotal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.lblTotal.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.lblTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.lblTotal.Properties.ReadOnly = True
        Me.lblTotal.Size = New System.Drawing.Size(154, 22)
        Me.lblTotal.TabIndex = 4
        '
        'Panel22
        '
        Me.Panel22.Controls.Add(Me.LabelControl6)
        Me.Panel22.Controls.Add(Me.LabelControl5)
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel22.Location = New System.Drawing.Point(0, 0)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(105, 44)
        Me.Panel22.TabIndex = 5
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.BackColor = System.Drawing.Color.Maroon
        Me.LabelControl6.Appearance.BorderColor = System.Drawing.Color.Gray
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl6.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabelControl6.Appearance.Options.UseBackColor = True
        Me.LabelControl6.Appearance.Options.UseBorderColor = True
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Appearance.Options.UseTextOptions = True
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelControl6.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(105, 22)
        Me.LabelControl6.TabIndex = 4
        Me.LabelControl6.Text = "Biaya Lain : "
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.BackColor = System.Drawing.Color.Maroon
        Me.LabelControl5.Appearance.BorderColor = System.Drawing.Color.Gray
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl5.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabelControl5.Appearance.Options.UseBackColor = True
        Me.LabelControl5.Appearance.Options.UseBorderColor = True
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Appearance.Options.UseTextOptions = True
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabelControl5.Location = New System.Drawing.Point(0, 22)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(105, 22)
        Me.LabelControl5.TabIndex = 3
        Me.LabelControl5.Text = "Total : "
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.Panel20)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel17.Location = New System.Drawing.Point(0, 44)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(348, 58)
        Me.Panel17.TabIndex = 5
        '
        'Panel20
        '
        Me.Panel20.BackColor = System.Drawing.Color.Black
        Me.Panel20.Controls.Add(Me.btnBuku)
        Me.Panel20.Controls.Add(Me.cmdViewStatusSp)
        Me.Panel20.Controls.Add(Me.btnPromo)
        Me.Panel20.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel20.Location = New System.Drawing.Point(0, 22)
        Me.Panel20.Name = "Panel20"
        Me.Panel20.Size = New System.Drawing.Size(348, 36)
        Me.Panel20.TabIndex = 10
        '
        'btnBuku
        '
        Me.btnBuku.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuku.Appearance.Options.UseFont = True
        Me.btnBuku.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBuku.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnBuku.Image = CType(resources.GetObject("btnBuku.Image"), System.Drawing.Image)
        Me.btnBuku.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnBuku.Location = New System.Drawing.Point(275, 0)
        Me.btnBuku.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnBuku.Name = "btnBuku"
        Me.btnBuku.Size = New System.Drawing.Size(37, 36)
        Me.btnBuku.TabIndex = 0
        Me.btnBuku.Tag = "Buku Order"
        Me.btnBuku.ToolTip = "Klik untuk melihat buku order spring"
        Me.btnBuku.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.btnBuku.ToolTipTitle = "Buku Order"
        '
        'cmdViewStatusSp
        '
        Me.cmdViewStatusSp.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdViewStatusSp.Appearance.Options.UseFont = True
        Me.cmdViewStatusSp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdViewStatusSp.Dock = System.Windows.Forms.DockStyle.Right
        Me.cmdViewStatusSp.Image = CType(resources.GetObject("cmdViewStatusSp.Image"), System.Drawing.Image)
        Me.cmdViewStatusSp.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.cmdViewStatusSp.Location = New System.Drawing.Point(312, 0)
        Me.cmdViewStatusSp.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cmdViewStatusSp.Name = "cmdViewStatusSp"
        Me.cmdViewStatusSp.Size = New System.Drawing.Size(36, 36)
        Me.cmdViewStatusSp.TabIndex = 11
        Me.cmdViewStatusSp.Tag = "Status SP"
        Me.cmdViewStatusSp.ToolTip = "Klik Untuk Melihat Status SP"
        Me.cmdViewStatusSp.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.cmdViewStatusSp.ToolTipTitle = "Status SP"
        '
        'btnPromo
        '
        Me.btnPromo.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPromo.Appearance.Options.UseFont = True
        Me.btnPromo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPromo.Image = CType(resources.GetObject("btnPromo.Image"), System.Drawing.Image)
        Me.btnPromo.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btnPromo.Location = New System.Drawing.Point(56, 0)
        Me.btnPromo.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btnPromo.Name = "btnPromo"
        Me.btnPromo.Size = New System.Drawing.Size(42, 42)
        Me.btnPromo.TabIndex = 9
        Me.btnPromo.Tag = "Proses Promo"
        Me.btnPromo.ToolTip = "Klik Untuk Proses Promo"
        Me.btnPromo.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        Me.btnPromo.ToolTipTitle = "Proses Promo"
        Me.btnPromo.Visible = False
        '
        'Panel11
        '
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.txtKeterangan)
        Me.Panel11.Controls.Add(Me.cmdWilayah)
        Me.Panel11.Controls.Add(Me.tglKirim)
        Me.Panel11.Controls.Add(Me.Panel24)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(319, 0)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(321, 102)
        Me.Panel11.TabIndex = 2
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtKeterangan.Location = New System.Drawing.Point(97, 40)
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtKeterangan.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKeterangan.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.txtKeterangan.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtKeterangan.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtKeterangan.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtKeterangan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txtKeterangan.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtKeterangan.Size = New System.Drawing.Size(222, 60)
        Me.txtKeterangan.TabIndex = 8
        '
        'cmdWilayah
        '
        Me.cmdWilayah.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdWilayah.Location = New System.Drawing.Point(97, 20)
        Me.cmdWilayah.Name = "cmdWilayah"
        Me.cmdWilayah.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cmdWilayah.Properties.Appearance.Options.UseBackColor = True
        Me.cmdWilayah.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.cmdWilayah.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdWilayah.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.cmdWilayah.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.cmdWilayah.Properties.AppearanceFocused.Options.UseFont = True
        Me.cmdWilayah.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.cmdWilayah.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cmdWilayah.Properties.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nama_Wilayah", 150, "Wilayah")})
        Me.cmdWilayah.Properties.DisplayMember = "Nama_Wilayah"
        Me.cmdWilayah.Properties.HideSelection = False
        Me.cmdWilayah.Properties.HighlightedItemStyle = DevExpress.XtraEditors.HighlightStyle.Skinned
        Me.cmdWilayah.Properties.NullText = "[Pilih Wilayah]"
        Me.cmdWilayah.Properties.PopupWidth = 300
        Me.cmdWilayah.Properties.ShowHeader = False
        Me.cmdWilayah.Properties.ValueMember = "Kode_Wilayah"
        Me.cmdWilayah.Size = New System.Drawing.Size(222, 20)
        Me.cmdWilayah.TabIndex = 7
        '
        'tglKirim
        '
        Me.tglKirim.Dock = System.Windows.Forms.DockStyle.Top
        Me.tglKirim.EditValue = Nothing
        Me.DXEP.SetIconAlignment(Me.tglKirim, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.tglKirim.Location = New System.Drawing.Point(97, 0)
        Me.tglKirim.Name = "tglKirim"
        Me.tglKirim.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.tglKirim.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglKirim.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.tglKirim.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.tglKirim.Properties.AppearanceFocused.Options.UseFont = True
        Me.tglKirim.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.tglKirim.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglKirim.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglKirim.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglKirim.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglKirim.Size = New System.Drawing.Size(222, 20)
        Me.tglKirim.TabIndex = 4
        '
        'Panel24
        '
        Me.Panel24.BackColor = System.Drawing.Color.Maroon
        Me.Panel24.Controls.Add(Me.LabelControl4)
        Me.Panel24.Controls.Add(Me.LabelControl7)
        Me.Panel24.Controls.Add(Me.LabelControl9)
        Me.Panel24.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel24.Location = New System.Drawing.Point(0, 0)
        Me.Panel24.Name = "Panel24"
        Me.Panel24.Size = New System.Drawing.Size(97, 100)
        Me.Panel24.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.BackColor = System.Drawing.Color.Maroon
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl4.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LabelControl4.Appearance.Options.UseBackColor = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LabelControl4.Location = New System.Drawing.Point(0, 40)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(97, 60)
        Me.LabelControl4.TabIndex = 1
        Me.LabelControl4.Text = " Keterangan : "
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Appearance.Options.UseTextOptions = True
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl7.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl7.Location = New System.Drawing.Point(0, 20)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(97, 20)
        Me.LabelControl7.TabIndex = 2
        Me.LabelControl7.Text = "Wilayah : "
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Appearance.Options.UseTextOptions = True
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl9.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl9.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(97, 20)
        Me.LabelControl9.TabIndex = 0
        Me.LabelControl9.Text = "* Janji Kirim PPIC : "
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.Transparent
        Me.Panel10.Controls.Add(Me.Panel13)
        Me.Panel10.Controls.Add(Me.Panel8)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(319, 102)
        Me.Panel10.TabIndex = 1
        '
        'Panel13
        '
        Me.Panel13.Controls.Add(Me.txtMedia)
        Me.Panel13.Controls.Add(Me.txtNamaPnrm)
        Me.Panel13.Controls.Add(Me.txtAlamatKirim)
        Me.Panel13.Controls.Add(Me.tglKirimMarketing)
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.Location = New System.Drawing.Point(97, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(222, 102)
        Me.Panel13.TabIndex = 5
        '
        'txtMedia
        '
        Me.txtMedia.Location = New System.Drawing.Point(0, 82)
        Me.txtMedia.Name = "txtMedia"
        Me.txtMedia.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtMedia.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMedia.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.txtMedia.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtMedia.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtMedia.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtMedia.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtMedia.Properties.Items.AddRange(New Object() {"TELEPON", "FAX", "EMAIL", "LANGSUNG", "LAINNYA"})
        Me.txtMedia.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.txtMedia.Size = New System.Drawing.Size(222, 20)
        Me.txtMedia.TabIndex = 4
        '
        'txtNamaPnrm
        '
        Me.txtNamaPnrm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNamaPnrm.Location = New System.Drawing.Point(0, 61)
        Me.txtNamaPnrm.Name = "txtNamaPnrm"
        Me.txtNamaPnrm.Size = New System.Drawing.Size(222, 21)
        Me.txtNamaPnrm.TabIndex = 3
        '
        'txtAlamatKirim
        '
        Me.txtAlamatKirim.Location = New System.Drawing.Point(0, 20)
        Me.txtAlamatKirim.Name = "txtAlamatKirim"
        Me.txtAlamatKirim.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.txtAlamatKirim.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamatKirim.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.txtAlamatKirim.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.txtAlamatKirim.Properties.AppearanceFocused.Options.UseFont = True
        Me.txtAlamatKirim.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.txtAlamatKirim.Properties.ContextMenuStrip = Me.menuAlamat
        Me.txtAlamatKirim.Size = New System.Drawing.Size(222, 41)
        SuperToolTip1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.[True]
        ToolTipTitleItem1.Text = "Info"
        ToolTipItem1.LeftIndent = 6
        ToolTipItem1.Text = "<i> Klik Kanan  Untuk Menampilkan Pilihan Alamat"
        SuperToolTip1.Items.Add(ToolTipTitleItem1)
        SuperToolTip1.Items.Add(ToolTipItem1)
        Me.txtAlamatKirim.SuperTip = SuperToolTip1
        Me.txtAlamatKirim.TabIndex = 2
        '
        'menuAlamat
        '
        Me.menuAlamat.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PilihAlamat})
        Me.menuAlamat.Name = "menuAlamat"
        Me.menuAlamat.Size = New System.Drawing.Size(139, 26)
        '
        'PilihAlamat
        '
        Me.PilihAlamat.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Alamat1, Me.Alamat2, Me.Alamat3})
        Me.PilihAlamat.Image = CType(resources.GetObject("PilihAlamat.Image"), System.Drawing.Image)
        Me.PilihAlamat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PilihAlamat.Name = "PilihAlamat"
        Me.PilihAlamat.Size = New System.Drawing.Size(138, 22)
        Me.PilihAlamat.Text = "Pilih Alamat"
        Me.PilihAlamat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Alamat1
        '
        Me.Alamat1.Image = CType(resources.GetObject("Alamat1.Image"), System.Drawing.Image)
        Me.Alamat1.Name = "Alamat1"
        Me.Alamat1.Size = New System.Drawing.Size(239, 22)
        Me.Alamat1.Text = "Pilih Customer Terlebih Dahulu"
        '
        'Alamat2
        '
        Me.Alamat2.Image = CType(resources.GetObject("Alamat2.Image"), System.Drawing.Image)
        Me.Alamat2.Name = "Alamat2"
        Me.Alamat2.Size = New System.Drawing.Size(239, 22)
        Me.Alamat2.Text = "Pilih Customer Terlebih Dahulu"
        '
        'Alamat3
        '
        Me.Alamat3.Name = "Alamat3"
        Me.Alamat3.Size = New System.Drawing.Size(239, 22)
        Me.Alamat3.Text = "Pilih Customer Terlebih Dahulu"
        '
        'tglKirimMarketing
        '
        Me.tglKirimMarketing.Dock = System.Windows.Forms.DockStyle.Top
        Me.tglKirimMarketing.EditValue = Nothing
        Me.DXEP.SetIconAlignment(Me.tglKirimMarketing, System.Windows.Forms.ErrorIconAlignment.MiddleLeft)
        Me.tglKirimMarketing.Location = New System.Drawing.Point(0, 0)
        Me.tglKirimMarketing.Name = "tglKirimMarketing"
        Me.tglKirimMarketing.Properties.AppearanceFocused.BackColor = System.Drawing.Color.RoyalBlue
        Me.tglKirimMarketing.Properties.AppearanceFocused.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglKirimMarketing.Properties.AppearanceFocused.ForeColor = System.Drawing.Color.White
        Me.tglKirimMarketing.Properties.AppearanceFocused.Options.UseBackColor = True
        Me.tglKirimMarketing.Properties.AppearanceFocused.Options.UseFont = True
        Me.tglKirimMarketing.Properties.AppearanceFocused.Options.UseForeColor = True
        Me.tglKirimMarketing.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.tglKirimMarketing.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[True]
        Me.tglKirimMarketing.Properties.VistaEditTime = DevExpress.Utils.DefaultBoolean.[False]
        Me.tglKirimMarketing.Properties.VistaTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton})
        Me.tglKirimMarketing.Size = New System.Drawing.Size(222, 20)
        Me.tglKirimMarketing.TabIndex = 1
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.Maroon
        Me.Panel8.Controls.Add(Me.LabelControl10)
        Me.Panel8.Controls.Add(Me.LabelControl3)
        Me.Panel8.Controls.Add(Me.LabelControl8)
        Me.Panel8.Controls.Add(Me.LabelControl2)
        Me.Panel8.Controls.Add(Me.LabelControl1)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(97, 102)
        Me.Panel8.TabIndex = 0
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl10.Appearance.Options.UseForeColor = True
        Me.LabelControl10.Appearance.Options.UseTextOptions = True
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl10.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl10.Location = New System.Drawing.Point(0, 81)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(97, 21)
        Me.LabelControl10.TabIndex = 4
        Me.LabelControl10.Text = "Media : "
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl3.Location = New System.Drawing.Point(0, 61)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(97, 20)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Nama Pemesan : "
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.Appearance.Options.UseTextOptions = True
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl8.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl8.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl8.Location = New System.Drawing.Point(0, 20)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(97, 41)
        Me.LabelControl8.TabIndex = 3
        Me.LabelControl8.Text = "* Alamat Kirim : "
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl2.Location = New System.Drawing.Point(0, 20)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(97, 0)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Alamat Kirim : "
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.LabelControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl1.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(97, 20)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "* Janji Kirim SO : "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Maroon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblJudul)
        Me.Panel1.Controls.Add(Me.Panel12)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.lblState)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(990, 37)
        Me.Panel1.TabIndex = 2
        '
        'lblJudul
        '
        Me.lblJudul.BackColor = System.Drawing.Color.Transparent
        Me.lblJudul.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.ForeColor = System.Drawing.Color.Gold
        Me.lblJudul.Location = New System.Drawing.Point(38, 0)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(357, 35)
        Me.lblJudul.TabIndex = 8
        Me.lblJudul.Text = " FORM SURAT PEMESANAN"
        Me.lblJudul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.txtCR)
        Me.Panel12.Location = New System.Drawing.Point(500, 10)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(83, 20)
        Me.Panel12.TabIndex = 5
        Me.Panel12.Visible = False
        '
        'txtCR
        '
        Me.txtCR.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtCR.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCR.Enabled = False
        Me.txtCR.Location = New System.Drawing.Point(0, 0)
        Me.txtCR.Name = "txtCR"
        Me.txtCR.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCR.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCR.Properties.Appearance.Options.UseBackColor = True
        Me.txtCR.Properties.Appearance.Options.UseFont = True
        Me.txtCR.Properties.AutoHeight = False
        Me.txtCR.Properties.DisplayFormat.FormatString = "N0"
        Me.txtCR.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtCR.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
        Me.txtCR.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
        Me.txtCR.Properties.ReadOnly = True
        Me.txtCR.Size = New System.Drawing.Size(46, 20)
        Me.txtCR.TabIndex = 4
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
        'lblState
        '
        Me.lblState.BackColor = System.Drawing.Color.Transparent
        Me.lblState.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblState.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.ForeColor = System.Drawing.Color.Yellow
        Me.lblState.Location = New System.Drawing.Point(786, 0)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(202, 35)
        Me.lblState.TabIndex = 16
        Me.lblState.Text = " [ IDLE ]"
        Me.lblState.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'ColorWithAlpha4
        '
        Me.ColorWithAlpha4.Alpha = 255
        Me.ColorWithAlpha4.Color = System.Drawing.Color.Gray
        Me.ColorWithAlpha4.Parent = Nothing
        '
        'ColorWithAlpha5
        '
        Me.ColorWithAlpha5.Alpha = 255
        Me.ColorWithAlpha5.Color = System.Drawing.SystemColors.ControlText
        Me.ColorWithAlpha5.Parent = Nothing
        '
        'ColorWithAlpha6
        '
        Me.ColorWithAlpha6.Alpha = 255
        Me.ColorWithAlpha6.Color = System.Drawing.Color.Gray
        Me.ColorWithAlpha6.Parent = Nothing
        '
        'ColorWithAlpha1
        '
        Me.ColorWithAlpha1.Alpha = 255
        Me.ColorWithAlpha1.Color = System.Drawing.Color.Maroon
        Me.ColorWithAlpha1.Parent = Nothing
        '
        'ColorWithAlpha2
        '
        Me.ColorWithAlpha2.Alpha = 75
        Me.ColorWithAlpha2.Color = System.Drawing.Color.Maroon
        Me.ColorWithAlpha2.Parent = Nothing
        '
        'ColorWithAlpha3
        '
        Me.ColorWithAlpha3.Alpha = 255
        Me.ColorWithAlpha3.Color = System.Drawing.Color.Maroon
        Me.ColorWithAlpha3.Parent = Nothing
        '
        'DXEP
        '
        Me.DXEP.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.DXEP.ContainerControl = Me
        '
        'frmSO
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 609)
        Me.Controls.Add(Me.pnl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.LookAndFeel.SkinName = "The Asphalt World"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSO"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GVD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repPopD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repBonus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repBarang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repDes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popDesk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popDesk.ResumeLayout(False)
        CType(Me.txtDesk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repTglKirim.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repTglKirim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repHarga, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repPrioritas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repDel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repBns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repKeterangan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepPop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepDesk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.popCon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popCon.ResumeLayout(False)
        CType(Me.popBiaya, System.ComponentModel.ISupportInitialize).EndInit()
        Me.popBiaya.ResumeLayout(False)
        CType(Me.GC_Biaya, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GV_Biaya, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repBiaya, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repNum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcCari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvCari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel21.ResumeLayout(False)
        Me.Panel21.PerformLayout()
        Me.pnl.ResumeLayout(False)
        Me.pnlTengah.ResumeLayout(False)
        Me.pnlTengahBawah.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        CType(Me.txtKurs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vValas.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbJenisSP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTengahAtas.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.spReff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_TglSO.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_TglSO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglSO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNomor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.ckPPN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        CType(Me.txtNamaSales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSales.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel25.ResumeLayout(False)
        Me.Panel25.PerformLayout()
        CType(Me.cmbAtasNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.txtKodeCust.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCustomer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.pnlbawah.ResumeLayout(False)
        Me.Panel14.ResumeLayout(False)
        Me.Panel16.ResumeLayout(False)
        Me.Panel19.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel23.ResumeLayout(False)
        CType(Me.txtBiaya2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBiaya.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel22.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.Panel20.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        CType(Me.txtKeterangan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdWilayah.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglKirim.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglKirim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel24.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel13.ResumeLayout(False)
        Me.Panel13.PerformLayout()
        CType(Me.txtMedia.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAlamatKirim.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuAlamat.ResumeLayout(False)
        CType(Me.tglKirimMarketing.Properties.VistaTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tglKirimMarketing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        CType(Me.txtCR.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DXEP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents pnl As System.Windows.Forms.Panel
    Friend WithEvents pnlTengah As System.Windows.Forms.Panel
    Friend WithEvents pnlTengahBawah As System.Windows.Forms.Panel
    Friend WithEvents pnlTengahAtas As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents txtKodeCust As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pnlbawah As System.Windows.Forms.Panel
    Friend WithEvents Panel11 As System.Windows.Forms.Panel
    Friend WithEvents Panel10 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GC As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents No_seq As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_Stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_satuan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Keterangan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtCustomer As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tglKirimMarketing As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtNamaPnrm As System.Windows.Forms.TextBox
    Friend WithEvents txtSales As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents txtNamaSales As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tglKirims As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents harga As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Priority As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repPrioritas As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents repTglKirim As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents repKeterangan As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents ColorWithAlpha1 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha2 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha3 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents states As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Potongan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents disc1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents disc2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents disc3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents disc4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents disc5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ckPPN As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Sete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repSet As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents GVD As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NoD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Kd_StokD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents UnitD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QtyD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents HargaD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Disc1D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Disc2D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Disc4D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Disc5d As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PotonganD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents TotalD As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Disc3D As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Nama_Barang As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel14 As System.Windows.Forms.Panel
    Friend WithEvents Panel15 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GVP As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents NoSeqP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents QtyP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PROMO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents KDPROMO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DXEP As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel12 As System.Windows.Forms.Panel
    Friend WithEvents Panel13 As System.Windows.Forms.Panel
    Friend WithEvents Panel16 As System.Windows.Forms.Panel
    Friend WithEvents Panel17 As System.Windows.Forms.Panel
    Friend WithEvents btnBuku As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents potTotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ambil_bonus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repBonus As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Panel18 As System.Windows.Forms.Panel
    Friend WithEvents btnPromo As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel19 As System.Windows.Forms.Panel
    Friend WithEvents Panel20 As System.Windows.Forms.Panel
    Friend WithEvents Deskripsi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepPop As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents popCon As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents Panel21 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents gcCari As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvCari As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repDes As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents popDesk As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents txtDesk As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents repQty As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents lblStateCR As System.Windows.Forms.Label
    Friend WithEvents cmdViewStatusSp As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ColorWithAlpha4 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha5 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents ColorWithAlpha6 As BlueActivity.Controls.ColorWithAlpha
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents vValas As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents txtKurs As DevExpress.XtraEditors.TextEdit
    Friend WithEvents repPopD As DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents Panel23 As System.Windows.Forms.Panel
    Friend WithEvents Panel22 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents popBiaya As DevExpress.XtraEditors.PopupContainerControl
    Friend WithEvents txtBiaya2 As DevExpress.XtraEditors.PopupContainerEdit
    Friend WithEvents GC_Biaya As DevExpress.XtraGrid.GridControl
    Friend WithEvents GV_Biaya As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents kd_biaya As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents biaya As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repBiaya As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents colDel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repDel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents ambilBonus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel24 As System.Windows.Forms.Panel
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents tglKirim As DevExpress.XtraEditors.DateEdit
    Friend WithEvents tgl_kirim_ppic As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtKeterangan As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents cmdWilayah As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtMedia As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Nama_Potongan As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txtAlamatKirim As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents tglSO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNomor As DevExpress.XtraEditors.TextEdit
    Friend WithEvents nama_potongan2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmbJenisSP As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents repBarang As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    Friend WithEvents repNum As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents txtCR As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txtBiaya As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblTotal As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents lblPromo As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents menuAlamat As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PilihAlamat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Alamat1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Alamat2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DT_TglSO As DevExpress.XtraEditors.DateEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel25 As System.Windows.Forms.Panel
    Friend WithEvents cmbAtasNama As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents RepDesk As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents spReff As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents BNS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents repBns As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents Alamat3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnKunci As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents repHarga As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents Stok As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents isLocked As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents RepositoryItemCheckEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
End Class
