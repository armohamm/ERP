Imports System.Data.SqlClient
Imports System.Drawing
Imports DevExpress.XtraPrinting
'Imports DevExpress.XtraPrintingLinks

Public Class FrmMonPObrg

    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public STATE As String
    'Public prn As frmMain '<-- untuk mengakses frmMain
    Public milih As String
    Public dtable As DataTable
    Private rw As DataRow
    Dim dSO, ds1, ds2, ds_cari As New DataSet
    Dim DA, DA2, DA3, da_cari, DALOOKUP As SqlClient.SqlDataAdapter



    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = False
        btnEdit = False
        btnadd = False
        'setStatus()
        STATE = "ADD" '<-- set state add

    End Sub

    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    'Public Sub exit_click()
    '    If MsgBox("Form Approve akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
    '    Me.Close()
    'End Sub

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub


    Public Sub simpan()
        Dim builder As New SqlCommandBuilder(DA)
        For Each rw As DataRow In dSO.Tables("_DpmApprv").Rows
            If rw.RowState = DataRowState.Added Then
                rw("Kd_Cabang") = kdcabang
                rw("Last_Create_Date") = Now
                rw("Last_Created_By") = umum.username
                rw("Program_Name") = Me.Name

            ElseIf rw.RowState = DataRowState.Modified Then
                rw.Item("Last_Update_Date") = Now
                rw.Item("Last_Updated_By") = username
                rw("tgl_approve") = Now
                rw("user_approve") = umum.username
            End If
        Next

        'For Each rw1 As DataRow In ds2.Tables("_DpmApprv_d").Rows
        '    If rw1.RowState = DataRowState.Modified Then

        '        rw1("status") = rw("status")
        '    End If
        'Next

        DA.InsertCommand = builder.GetInsertCommand()
        DA.UpdateCommand = builder.GetUpdateCommand()
        DA.DeleteCommand = builder.GetDeleteCommand()

        DA.Update(dSO, "_DpmApprv")
        dSO.Tables("_DpmApprv").AcceptChanges()

        DA2.Update(ds2, "_DpmApprv_d")
        ds2.Tables("_DpmApprv_d").AcceptChanges()

        showMessages("Approval DPM berhasil di Update!")
    End Sub

    Public Sub hapus_record()
        Dim builder As New SqlCommandBuilder(DA)
        Dim row As DataRow
        Dim rows() As DataRow
        Dim i As Integer

        ReDim rows(GVApprvDPM.SelectedRowsCount - 1)
        For i = 0 To GVApprvDPM.SelectedRowsCount - 1
            rows(i) = GVApprvDPM.GetDataRow(GVApprvDPM.GetSelectedRows(i))
        Next
        GVApprvDPM.BeginSort()
        Try
            For Each row In rows
                row.Delete()
            Next
        Finally
            GVApprvDPM.EndSort()
        End Try
        simpan()
    End Sub
    Sub Load_PO_Filter()
        If Not dSO.Relations("Gudang") Is Nothing Then dSO.Relations.Clear()
        If Not dSO.Relations("Detail") Is Nothing Then dSO.Relations.Clear()
        If Not dSO.Tables("_DpmApprv_dpr") Is Nothing Then dSO.Tables("_DpmApprv_dpr").Clear()
        If Not dSO.Tables("_DpmApprv_d") Is Nothing Then dSO.Tables("_DpmApprv_d").Clear()
        If Not dSO.Tables("_DpmApprv") Is Nothing Then dSO.Tables("_DpmApprv").Clear()


        Dim sql As String
        'Dim kolom As String = ""
        ''If tglDari.Text = "" Then
        ''    If tglsampai.Text <> "" Then
        ''        sql = " where convert(varchar, tgl_po, 112) < " & tglsampai.Text
        ''    End If
        ''Else

        ''    If tglsampai.Text <> "" Then
        ''        sql = " where convert(varchar, tgl_po, 112)  between '" & tglDari.Text & "' and '" & tglsampai.Text & "' "
        ''    Else
        ''        sql = " where convert(varchar, tgl_po, 112)  > " & tglDari.Text
        ''    End If
        ''End If

        If tglDari.Text = "" Then
            If tglsampai.Text <> "" Then
                sql = " convert(varchar, tgl_po, 103) < " & tglsampai.EditValue
            End If
        Else

            If tglsampai.Text <> "" Then
                sql = " tgl_po  between '" & Format(tglDari.EditValue, "yyyy/MM/dd") & "' and '" & Format(tglsampai.EditValue, "yyyy/MM/dd") & "' "
            Else
                sql = " convert(varchar, tgl_po, 103) > " & tglDari.EditValue
            End If
        End If

        'connect()
        DA = New SqlDataAdapter(New SqlCommand("SELECT *,'' as nstatus from PURC.dbo.PURC_PO WHERE" & sql, sqlconn))
        DA.Fill(dSO, "_DpmApprv")
        GcApprvDPM.DataSource = dSO.Tables("_DpmApprv")

        DA2 = New SqlDataAdapter(New SqlCommand("SELECT a.no_po, a.no_seq, ISNULL(a.keterangan, b.Nama_Barang) as keterangan, a.kd_satuan, " & _
                                                "a.qty, sum(c.jumlah) as qty_kirim,a.harga, a.total " & _
                                                "FROM SIF.dbo.SIF_Barang b, PURC.dbo.v_gudang_in c left outer join PURC.dbo.PURC_PO_D a on (c.no_ref=a.no_po and c.kd_Stok = a.kd_stok and c.keterangan = a.keterangan) " & _
                                                "WHERE(a.kd_stok = b.Kode_Barang) " & _
                                                "group by a.no_po, a.no_seq, ISNULL(a.keterangan, b.Nama_Barang), a.kd_satuan, " & _
                                                "a.qty,a.harga, a.total", sqlconn))
        DA2.Fill(dSO, "_DpmApprv_d")

        DA3 = New SqlDataAdapter(New SqlCommand("SELECT * from INV.dbo.INV_GUDANG_IN where no_ref in (select no_po from PURC.dbo.PURC_PO)", sqlconn))
        DA3.Fill(dSO, "_DpmApprv_dpr")

        Dim rl, r2 As DataRelation
        rl = dSO.Relations.Add("Detail", dSO.Tables("_DpmApprv").Columns("no_po"), dSO.Tables("_DpmApprv_d").Columns("no_po"), False)
        r2 = dSO.Relations.Add("Gudang", dSO.Tables("_DpmApprv").Columns("no_po"), dSO.Tables("_DpmApprv_dpr").Columns("no_ref"), False)

        GcApprvDPM.DataSource = dSO.Tables("_DpmApprv")
        GcApprvDPM.LevelTree.Nodes.Add("Detail", GridView1) '.Nodes.Add("Detail_", GridView2)
        GcApprvDPM.LevelTree.Nodes.Add("Gudang", GridView2)

        'DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kd_Departemen,Nama_Departemen from SIF.dbo.SIF_Departemen", sqlconn))
        'DALOOKUP.Fill(ds_cari, "_lookup")
        'lookupDivisi.DataSource = ds_cari.Tables("_lookup")
        'lookupDivisi.ValueMember = "Kd_Departemen"
        'lookupDivisi.DisplayMember = "Nama_Departemen"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        Lokupbarang.DataSource = ds_cari.Tables("_lookup1")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Supplier, Nama_Supplier from SIF.dbo.SIF_Supplier", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup2")
        lookupsupplier.DataSource = ds_cari.Tables("_lookup2")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select tipe_trans, accronim_desc from SIF.dbo.SIF_TIPE_TRANS", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup3")
        Lookuptipe.DataSource = ds_cari.Tables("_lookup3")

        For Each rw As DataRow In dSO.Tables("_DpmApprv").Rows
            rw("nstatus") = cek_status_PO(rw("no_po"))
        Next

    End Sub
    Private Sub FrmApproveDPM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'connect()
        'DA = New SqlDataAdapter(New SqlCommand("SELECT *,'' as nstatus from PURC.dbo.PURC_PO", sqlconn))
        'DA.Fill(dSO, "_DpmApprv")
        'GcApprvDPM.DataSource = dSO.Tables("_DpmApprv")

        'DA2 = New SqlDataAdapter(New SqlCommand("SELECT * from PURC.dbo.PURC_PO_D", sqlconn))
        'DA2.Fill(dSO, "_DpmApprv_d")

        'DA3 = New SqlDataAdapter(New SqlCommand("SELECT * from INV.dbo.INV_GUDANG_IN where no_po in (select no_po from PURC.dbo.PURC_PO)", sqlconn))
        'DA3.Fill(dSO, "_DpmApprv_dpr")

        'Dim rl, r2 As DataRelation
        'rl = dSO.Relations.Add("Detail", dSO.Tables("_DpmApprv").Columns("no_po"), dSO.Tables("_DpmApprv_d").Columns("no_po"))
        'r2 = dSO.Relations.Add("Gudang", dSO.Tables("_DpmApprv").Columns("no_po"), dSO.Tables("_DpmApprv_dpr").Columns("no_po"))

        'GcApprvDPM.DataSource = dSO.Tables("_DpmApprv")
        'GcApprvDPM.LevelTree.Nodes.Add("Detail", GridView1) '.Nodes.Add("Detail_", GridView2)
        'GcApprvDPM.LevelTree.Nodes.Add("Gudang", GridView2)

        ''DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kd_Departemen,Nama_Departemen from SIF.dbo.SIF_Departemen", sqlconn))
        ''DALOOKUP.Fill(ds_cari, "_lookup")
        ''lookupDivisi.DataSource = ds_cari.Tables("_lookup")
        ''lookupDivisi.ValueMember = "Kd_Departemen"
        ''lookupDivisi.DisplayMember = "Nama_Departemen"

        'DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        'DALOOKUP.Fill(ds_cari, "_lookup1")
        'Lokupbarang.DataSource = ds_cari.Tables("_lookup1")

        'DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Supplier, Nama_Supplier from SIF.dbo.SIF_Supplier", sqlconn))
        'DALOOKUP.Fill(ds_cari, "_lookup2")
        'lookupsupplier.DataSource = ds_cari.Tables("_lookup2")

        'DALOOKUP = New SqlDataAdapter(New SqlCommand("select tipe_trans, accronim_desc from SIF.dbo.SIF_TIPE_TRANS", sqlconn))
        'DALOOKUP.Fill(ds_cari, "_lookup3")
        'Lookuptipe.DataSource = ds_cari.Tables("_lookup3")

        'For Each rw As DataRow In dSO.Tables("_DpmApprv").Rows
        '    rw("nstatus") = cek_status_PO(rw("no_po"))
        'Next



        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        tglDari.EditValue = Now.Date
        tglsampai.EditValue = Now.Date
        'btnSimpan.Hide()
        'btnExit.Hide()
        'btnSave = False
        'btnEdit = False
        'btnadd = False
        'setStatus()



    End Sub

    Private Sub GVApprvDPM_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVApprvDPM.DoubleClick
        milih = GVApprvDPM.GetFocusedRowCellValue("no_po").ToString()

        da_cari = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_PO where no_po='" & milih & "'", sqlconn))
        da_cari.Fill(ds1, "_crpo")

        frmPO.cariPO(milih)
        frmPO.ShowDialog()
    End Sub


    ''Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
    ''    If MsgBox("Warning Data yang terhapus tidak akan dapat dikembalikan, Yakin??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_record()
    ''End Sub


    'Private Sub GVApprvDPM_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)

    '    milih = GVApprvDPM.GetRow(GVApprvDPM.GetSelectedRows(0)).Item(2).ToString()

    '    'showMessages(milih)
    '    'dtable.Rows(GVApprvDPM.GetSelectedRows(0)).Item(2).ToString() 'datatable adalah sebuah dataset, bkan properti gridview
    '    'rw = dtable.Rows(GVApprvDPM.GetSelectedRows(0))

    '    da_cari = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_DPM where No_DPM='" & milih & "'", sqlconn))
    '    da_cari.Fill(ds1, "_dpm")

    '    frmDPM.caridpmku(milih)
    '    frmDPM.ShowDialog()

    'End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Form Approve akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        GcApprvDPM.Refresh()
        GcApprvDPM.ShowPrintPreview()

    End Sub

    Public Sub cetak_click()
        If Not GVApprvDPM.RowCount <= 0 Then
            'ShowGridPreview(gcGiro)
            Dim ph As DevExpress.XtraPrinting.PageHeaderFooter = CType(PrintableComponentLink1.PageHeaderFooter, PageHeaderFooter)
            ph.Footer.Content.Add(username)
            ph.Footer.Content.Add("")
            ph.Footer.Content.Add("Hal. [Page #]")

            PrintableComponentLink1.CreateDocument()
            PrintableComponentLink1.ShowPreview()
        Else
            MsgBox("Tidak ada data yang dicetak. Silahkan mengisi filter tanggal lalu menekan tombol Refresh.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
        End If
    End Sub

  
    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        Load_PO_Filter()
    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "MONITORING PURCHASE ORDER"
        Dim reportHeader2 As String = ":"
        Dim reportHeader3 As String = "PT. Dynasti Indomegah"
        Dim reportHeader4 As String = "Tanggal Cetak"
        Dim reportHeader5 As String = getTanggal.ToLongDateString
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        e.Graph.BackColor = Color.White
        'MsgBox(e.Graph.ClientPageSize.Width / 2.ToString)
        'MsgBox(e.Graph.MeasureString(reportHeader, e.Graph.ClientPageSize.Width).Width)
        Dim rec As RectangleF = New RectangleF(404, 0, e.Graph.MeasureString(reportHeader, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec2 As RectangleF = New RectangleF(125, 60, e.Graph.MeasureString(reportHeader2, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec3 As RectangleF = New RectangleF(0, 0, e.Graph.MeasureString(reportHeader3, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec4 As RectangleF = New RectangleF(0, 60, e.Graph.MeasureString(reportHeader4, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec5 As RectangleF = New RectangleF(150, 60, e.Graph.MeasureString(reportHeader5, e.Graph.ClientPageSize.Width).Width, 20)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.Bottom)
        e.Graph.DrawString(reportHeader2, Color.Black, rec2, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportHeader3, Color.Black, rec3, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportHeader4, Color.Black, rec4, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportHeader5, Color.Black, rec5, DevExpress.XtraPrinting.BorderSide.None)
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class