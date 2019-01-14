Imports System.Data.SqlClient
Imports System.Drawing
Imports DevExpress.XtraPrinting

Public Class frmMonPEM
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = True
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

    Sub Load_PO_Filter2()
        tglDari.EditValue = Nothing
        tglsampai.EditValue = Nothing
        dSO.Relations.Clear()
        If Not dSO.Tables("_DpmApprv_d") Is Nothing Then dSO.Tables("_DpmApprv_d").Clear()
        If Not dSO.Tables("_DpmApprv") Is Nothing Then dSO.Tables("_DpmApprv").Clear()


        Dim sql As String
        'Dim kolom As String = ""
        If tglDari2.Text = "" And tglsampai2.Text = "" Then
            MsgBox("Harap Mengisi Filter Tanggal", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
            Exit Sub
        End If

        If tglDari2.Text = "" And tglsampai2.Text <> "" Then
            sql = " and c.tgl_janji_kirim < convert(date,'" & tglsampai2.EditValue & "',103) "
        ElseIf tglDari2.Text <> "" And tglsampai2.Text = "" Then
            sql = " and c.tgl_janji_kirim > convert(date,'" & tglDari2.EditValue & "',103) "
        Else
            sql = " and c.tgl_janji_kirim  between convert(date,'" & tglDari2.EditValue & "',103) and convert(date,'" & tglsampai2.EditValue & "',103) " ' "
        End If

        If cbo_status_realisasi.Text = "" Then
            cbo_status_realisasi.Text = "ALL"
        End If

        Dim sqlcmd As New SqlCommand
        sqlcmd.CommandTimeout = 0
        sqlcmd.Connection = sqlconn

        If cbo_status_realisasi.Text = "ALL" Then
            sqlcmd.CommandText = "SELECT c.keterangan,c.tipe_trans, c.no_po, c.tgl_po, c.kd_supplier, c.Nama_Supplier, c.kd_valuta, c.kd_stok, c.nama_brg, c.kd_satuan, " & _
                                                                   "c.qty, c.harga, c.total, c.tgl_janji_kirim,c.tgl_kirim,c.qty_in,c.qty_dev,'' as nstatus, c.ket_ppn, c.total_tax " & _
                                                                   "FROM purc.dbo.v_po_in_gudang1 c where (c.Program_Name <> 'aFormPONonMaterial' and c.Program_Name <> 'frmPOJasa')  " & sql & "  " & _
                                                                   " order by c.tgl_janji_kirim asc"
            DA = New SqlClient.SqlDataAdapter(sqlcmd)
            DA.Fill(dSO, "_DpmApprv")
            GcPO_Det.DataSource = dSO.Tables("_DpmApprv")
        ElseIf cbo_status_realisasi.Text = "TEPAT WAKTU" Then
            sqlcmd.CommandText = "SELECT c.keterangan,c.tipe_trans, c.no_po, c.tgl_po, c.kd_supplier, c.Nama_Supplier, c.kd_valuta, c.kd_stok, c.nama_brg, c.kd_satuan, " & _
                                                                   "c.qty, c.harga, c.total, c.tgl_janji_kirim,c.tgl_kirim,c.qty_in,c.qty_dev,'' as nstatus, c.ket_ppn, c.total_tax " & _
                                                                   "FROM purc.dbo.v_po_in_gudang c where (c.Program_Name <> 'aFormPONonMaterial' and c.Program_Name <> 'frmPOJasa')  and not tgl_kirim is null " & sql & "  " & _
                                                                   " and isnull(c.tgl_kirim,'" & Format(getTanggal, "yyyy/MM/dd") & "') <= c.tgl_janji_kirim  " & _
                                                                   "order by c.tgl_janji_kirim asc"
            DA = New SqlClient.SqlDataAdapter(sqlcmd)
            DA.Fill(dSO, "_DpmApprv")
            GcPO_Det.DataSource = dSO.Tables("_DpmApprv")
        ElseIf cbo_status_realisasi.Text = "TERLAMBAT" Then
            sqlcmd.CommandText = "SELECT c.keterangan,c.tipe_trans, c.no_po, c.tgl_po, c.kd_supplier, c.Nama_Supplier, c.kd_valuta, c.kd_stok, c.nama_brg, c.kd_satuan, " & _
                                                                   "c.qty, c.harga, c.total, c.tgl_janji_kirim,c.tgl_kirim,c.qty_in,c.qty_dev,'' as nstatus, c.ket_ppn, c.total_tax " & _
                                                                   "FROM purc.dbo.v_po_in_gudang c where (c.Program_Name <> 'aFormPONonMaterial' and c.Program_Name <> 'frmPOJasa')   and not tgl_kirim is null " & sql & "  " & _
                                                                   " and isnull(c.tgl_kirim,'" & Format(getTanggal, "yyyy/MM/dd") & "') > c.tgl_janji_kirim  " & _
                                                                   "order by c.tgl_janji_kirim asc"
            DA = New SqlClient.SqlDataAdapter(sqlcmd)
            DA.Fill(dSO, "_DpmApprv")
            GcPO_Det.DataSource = dSO.Tables("_DpmApprv")

        End If


        lbl_jmlTerlambat.Text = dSO.Tables("_DpmApprv").Select("tgl_janji_kirim < tgl_kirim", "").Count
        lbl_jmlTepat.Text = dSO.Tables("_DpmApprv").Select("tgl_janji_kirim >= tgl_kirim", "").Count
        lbl_jumlahtotal.Text = dSO.Tables("_DpmApprv").Rows.Count
        lblOutstanding.Text = Val(lbl_jumlahtotal.Text - (Val(lbl_jmlTepat.Text) + Val(lbl_jmlTerlambat.Text)))

        DA2 = New SqlDataAdapter(New SqlCommand("select no_trans, tgl_trans, no_ref, kd_stok, kd_satuan, sum(qty_in) qty, sj_supplier from PURC.dbo.v_gudang_in_purc group by  no_trans,tgl_trans,no_ref, kd_stok, kd_satuan, sj_supplier", sqlconn))
        DA2.Fill(dSO, "_DpmApprv_d")

        'DA3 = New SqlDataAdapter(New SqlCommand("SELECT * from INV.dbo.INV_GUDANG_IN where no_po in (select no_po from PURC.dbo.PURC_PO)", sqlconn))
        'DA3.Fill(dSO, "_DpmApprv_dpr")
        Dim rl As DataRelation
        Dim dcolP(1) As DataColumn
        Dim dcolC(1) As DataColumn

        dcolP(1) = dSO.Tables("_DpmApprv").Columns("kd_stok")
        dcolP(0) = dSO.Tables("_DpmApprv").Columns("no_po")

        dcolC(1) = dSO.Tables("_DpmApprv_d").Columns("kd_stok")
        dcolC(0) = dSO.Tables("_DpmApprv_d").Columns("no_ref")

        rl = dSO.Relations.Add("Detail", dcolP, dcolC, False)
        'rl.Nested = True
        GcPO_Det.LevelTree.Nodes.Add("Detail", GridView1)

        'rl = dSO.Relations.Add("Detail", dSO.Tables("_DpmApprv").Columns("no_po"), dSO.Tables("_DpmApprv_d").Columns("no_ref"), False)
        'r2 = dSO.Relations.Add("Detail2", dSO.Tables("_DpmApprv").Columns("kd_stok"), dSO.Tables("_DpmApprv_d").Columns("kd_stok"), False)

        'GcPO_Det.DataSource = dSO.Tables("_DpmApprv")
        'GcPO_Det.LevelTree.Nodes.Add("Detail", GridView1) '.Nodes.Add("Detail_", GridView2)
        'GcPO_Det.LevelTree.Nodes.Add("Detail2", GridView1)

        'DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kd_Departemen,Nama_Departemen from SIF.dbo.SIF_Departemen", sqlconn))
        'DALOOKUP.Fill(ds_cari, "_lookup")
        'lookupDivisi.DataSource = ds_cari.Tables("_lookup")
        'lookupDivisi.ValueMember = "Kd_Departemen"
        'lookupDivisi.DisplayMember = "Nama_Departemen"

        'DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        'DALOOKUP.Fill(ds_cari, "_lookup1")
        'Lokupbarang.DataSource = ds_cari.Tables("_lookup1")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Supplier, Nama_Supplier from SIF.dbo.SIF_Supplier", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup2")
        lookupsupplier.DataSource = ds_cari.Tables("_lookup2")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select tipe_trans, accronim_desc from SIF.dbo.SIF_TIPE_TRANS", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup3")
        Lookuptipe.DataSource = ds_cari.Tables("_lookup3")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Gudang, Nama_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup4")
        lookupGudang.DataSource = ds_cari.Tables("_lookup4")

        For Each rw As DataRow In dSO.Tables("_DpmApprv").Rows
            rw("nstatus") = cek_status_PO(rw("no_po"))
        Next


    End Sub

    Private Sub loadSJ()
        If Not ds_cari.Tables("SJ") Is Nothing Then ds_cari.Tables("SJ").Clear()

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select distinct ISNULL(sj_supplier,'') no_sj from PURC.dbo.v_gudang_in_purc", sqlconn))
        DALOOKUP.Fill(ds_cari, "SJ")
        lckNoSJ.Properties.DataSource = ds_cari.Tables("SJ")
        lckNoSJ.Properties.DisplayMember = "no_sj"
        lckNoSJ.Properties.ValueMember = "no_sj"
    End Sub

    Sub Load_PO_Filter3()
        tglDari.EditValue = Nothing
        tglsampai.EditValue = Nothing
        dSO.Relations.Clear()
        If Not dSO.Tables("_DpmApprv_d") Is Nothing Then dSO.Tables("_DpmApprv_d").Clear()
        If Not dSO.Tables("_DpmApprv") Is Nothing Then dSO.Tables("_DpmApprv").Clear()


        Dim sql As String
        'Dim kolom As String = ""

        If tglDari2.Text = "" And tglsampai2.Text <> "" Then
            sql = " and c.tgl_janji_kirim < convert(date,'" & tglsampai2.EditValue & "',103) "
        ElseIf tglDari2.Text <> "" And tglsampai2.Text = "" Then
            sql = " and c.tgl_janji_kirim > convert(date,'" & tglDari2.EditValue & "',103) "
        Else
            sql = " and c.tgl_janji_kirim  between convert(date,'" & tglDari2.EditValue & "',103) and convert(date,'" & tglsampai2.EditValue & "',103) " ' "
        End If



        If cbo_status_realisasi.Text = "" Then
            cbo_status_realisasi.Text = "ALL"
        End If

        Dim sqlcmd As New SqlCommand
        sqlcmd.CommandTimeout = 0
        sqlcmd.Connection = sqlconn

        If cbo_status_realisasi.Text = "ALL" Then
            sqlcmd.CommandText = "SELECT c.keterangan,c.tipe_trans, c.no_po, c.tgl_po, c.kd_supplier, c.Nama_Supplier, c.kd_valuta, c.kd_stok, c.nama_brg, c.kd_satuan, " & _
                                                                   "c.qty, c.harga, c.total, c.tgl_janji_kirim,c.tgl_kirim,c.qty_in,c.qty_dev,'' as nstatus, c.ket_ppn, c.total_tax " & _
                                                                   "FROM purc.dbo.v_po_in_gudang_non c where (c.Program_Name <> 'aFormPONonMaterial' and c.Program_Name <> 'frmPOJasa')  " & sql & "  " & _
                                                                   "order by c.tgl_janji_kirim asc"
            DA = New SqlClient.SqlDataAdapter(sqlcmd)
            DA.Fill(dSO, "_DpmApprv")
            GcPO_Det.DataSource = dSO.Tables("_DpmApprv")
        ElseIf cbo_status_realisasi.Text = "TEPAT WAKTU" Then
            sqlcmd.CommandText = "SELECT c.keterangan,c.tipe_trans, c.no_po, c.tgl_po, c.kd_supplier, c.Nama_Supplier, c.kd_valuta, c.kd_stok, c.nama_brg, c.kd_satuan, " & _
                                                                   "c.qty, c.harga, c.total, c.tgl_janji_kirim,c.tgl_kirim,c.qty_in,c.qty_dev,'' as nstatus, c.ket_ppn, c.total_tax " & _
                                                                   "FROM purc.dbo.v_po_in_gudang_non c where (c.Program_Name <> 'aFormPONonMaterial' and c.Program_Name <> 'frmPOJasa') and not tgl_kirim is null " & sql & "  " & _
                                                                   " and isnull(c.tgl_kirim,'" & Format(getTanggal, "yyyy/MM/dd") & "') <= c.tgl_janji_kirim  " & _
                                                                   "order by c.tgl_janji_kirim asc"
            DA = New SqlClient.SqlDataAdapter(sqlcmd)
            DA.Fill(dSO, "_DpmApprv")
            GcPO_Det.DataSource = dSO.Tables("_DpmApprv")
        ElseIf cbo_status_realisasi.Text = "TERLAMBAT" Then
            sqlcmd.CommandText = "SELECT c.keterangan,c.tipe_trans, c.no_po, c.tgl_po, c.kd_supplier, c.Nama_Supplier, c.kd_valuta, c.kd_stok, c.nama_brg, c.kd_satuan, " & _
                                                                   "c.qty, c.harga, c.total, c.tgl_janji_kirim,c.tgl_kirim,c.qty_in,c.qty_dev,'' as nstatus, c.ket_ppn, c.total_tax " & _
                                                                   "FROM purc.dbo.v_po_in_gudang_non c where (c.Program_Name <> 'aFormPONonMaterial' and c.Program_Name <> 'frmPOJasa') and not tgl_kirim is null " & sql & "  " & _
                                                                   " and isnull(c.tgl_kirim,'" & Format(getTanggal, "yyyy/MM/dd") & "') > c.tgl_janji_kirim  " & _
                                                                   "order by c.tgl_janji_kirim asc"
            DA = New SqlClient.SqlDataAdapter(sqlcmd)
            DA.Fill(dSO, "_DpmApprv")
            GcPO_Det.DataSource = dSO.Tables("_DpmApprv")

        End If

        lbl_jmlTerlambat.Text = dSO.Tables("_DpmApprv").Select("tgl_janji_kirim < tgl_kirim", "").Count
        lbl_jmlTepat.Text = dSO.Tables("_DpmApprv").Select("tgl_janji_kirim >= tgl_kirim", "").Count
        lbl_jumlahtotal.Text = dSO.Tables("_DpmApprv").Rows.Count
        lblOutstanding.Text = Val(lbl_jumlahtotal.Text - (Val(lbl_jmlTepat.Text) + Val(lbl_jmlTerlambat.Text)))

        'lbl_jmlTerlambat.Text = dSO.Tables("_DpmApprv").Select("tgl_janji_kirim < tgl_kirim", "").Count
        'lbl_jmlTepat.Text = dSO.Tables("_DpmApprv").Select("tgl_janji_kirim >= tgl_kirim", "").Count
        'lbl_jumlahtotal.Text = dSO.Tables("_DpmApprv").Rows.Count


        'connect()
        'DA = New SqlDataAdapter(New SqlCommand("SELECT *,'' as nstatus from PURC.dbo.PURC_PO" & sql, sqlconn))
        'DA.Fill(dSO, "_DpmApprv")
        'GcPO_Det.DataSource = dSO.Tables("_DpmApprv")

        DA2 = New SqlDataAdapter(New SqlCommand("select no_trans, tgl_trans, no_ref, kd_stok, kd_satuan, sum(qty_in) qty, sj_supplier from PURC.dbo.v_gudang_in_purc group by  no_trans,tgl_trans,no_ref, kd_stok, kd_satuan, sj_supplier", sqlconn))
        DA2.Fill(dSO, "_DpmApprv_d")

        'DA3 = New SqlDataAdapter(New SqlCommand("SELECT * from INV.dbo.INV_GUDANG_IN where no_po in (select no_po from PURC.dbo.PURC_PO)", sqlconn))
        'DA3.Fill(dSO, "_DpmApprv_dpr")
        Dim rl As DataRelation
        Dim dcolP(1) As DataColumn
        Dim dcolC(1) As DataColumn

        dcolP(1) = dSO.Tables("_DpmApprv").Columns("kd_stok")
        dcolP(0) = dSO.Tables("_DpmApprv").Columns("no_po")

        dcolC(1) = dSO.Tables("_DpmApprv_d").Columns("kd_stok")
        dcolC(0) = dSO.Tables("_DpmApprv_d").Columns("no_ref")

        rl = dSO.Relations.Add("Detail", dcolP, dcolC, False)
        'rl.Nested = True
        GcPO_Det.LevelTree.Nodes.Add("Detail", GridView1)

        'rl = dSO.Relations.Add("Detail", dSO.Tables("_DpmApprv").Columns("no_po"), dSO.Tables("_DpmApprv_d").Columns("no_ref"), False)
        'r2 = dSO.Relations.Add("Detail2", dSO.Tables("_DpmApprv").Columns("kd_stok"), dSO.Tables("_DpmApprv_d").Columns("kd_stok"), False)

        'GcPO_Det.DataSource = dSO.Tables("_DpmApprv")
        'GcPO_Det.LevelTree.Nodes.Add("Detail", GridView1) '.Nodes.Add("Detail_", GridView2)
        'GcPO_Det.LevelTree.Nodes.Add("Detail2", GridView1)

        'DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kd_Departemen,Nama_Departemen from SIF.dbo.SIF_Departemen", sqlconn))
        'DALOOKUP.Fill(ds_cari, "_lookup")
        'lookupDivisi.DataSource = ds_cari.Tables("_lookup")
        'lookupDivisi.ValueMember = "Kd_Departemen"
        'lookupDivisi.DisplayMember = "Nama_Departemen"

        'DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        'DALOOKUP.Fill(ds_cari, "_lookup1")
        'Lokupbarang.DataSource = ds_cari.Tables("_lookup1")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Supplier, Nama_Supplier from SIF.dbo.SIF_Supplier", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup2")
        lookupsupplier.DataSource = ds_cari.Tables("_lookup2")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select tipe_trans, accronim_desc from SIF.dbo.SIF_TIPE_TRANS", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup3")
        Lookuptipe.DataSource = ds_cari.Tables("_lookup3")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Gudang, Nama_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup4")
        lookupGudang.DataSource = ds_cari.Tables("_lookup4")

        For Each rw As DataRow In dSO.Tables("_DpmApprv").Rows
            rw("nstatus") = cek_status_PO(rw("no_po"))
        Next


    End Sub
    Sub Load_PO_Filter()
        tglDari2.EditValue = Nothing
        tglsampai2.EditValue = Nothing
        dSO.Relations.Clear()
        If Not dSO.Tables("_DpmApprv_d") Is Nothing Then dSO.Tables("_DpmApprv_d").Clear()
        If Not dSO.Tables("_DpmApprv") Is Nothing Then dSO.Tables("_DpmApprv").Clear()


        Dim sql As String
        'Dim kolom As String = ""
        If tglDari.Text = "" And tglsampai.Text <> "" Then
            sql = " and c.tgl_po < convert(date,'" & tglsampai.EditValue & "',103) "
        ElseIf tglDari2.Text <> "" And tglsampai2.Text = "" Then
            sql = " and c.tgl_po > convert(date,'" & tglDari.EditValue & "',103) "
        Else
            sql = " and c.tgl_po between convert(date,'" & tglDari.EditValue & "',103) and convert(date,'" & tglsampai.EditValue & "',103) " ' "
        End If



        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT c.keterangan,c.status_po,c.tipe_trans, c.no_po, c.tgl_po,c.ket_batal, c.kd_supplier, c.Nama_Supplier, c.kd_valuta, c.kd_stok, c.nama_brg, c.kd_satuan, " & _
                                                                    "c.qty, c.harga, c.total, c.tgl_janji_kirim, c.tgl_kirim, c.qty_in,c.qty_dev,'' as nstatus, c.ket_ppn, c.total_tax " & _
                                                                    "FROM purc.dbo.v_po_in_gudang1 c where c.Program_Name not in('aFormPONonMaterial','frmPOJasa') " & sql, sqlconn))
        DA.Fill(dSO, "_DpmApprv")


        Dim m, o As String
        Dim jml As Integer
        m = dSO.Tables("_DpmApprv").Select("tgl_janji_kirim <= tgl_kirim", "").Count

        jml = 0
        If Val(m) > 0 Then
            For i As Integer = 0 To m

                If dSO.Tables("_DpmApprv").Rows(i).Item("status_po") = "CLOSE" Then
                    jml = jml + 1

                End If

            Next
        Else
            jml = 0
        End If
        lbl_jmlTerlambat.Text = Val(m) - jml

        lbl_jmlTepat.Text = dSO.Tables("_DpmApprv").Select("tgl_janji_kirim > tgl_kirim", "").Count
        lbl_jumlahtotal.Text = dSO.Tables("_DpmApprv").Rows.Count
        lblOutstanding.Text = Val(lbl_jumlahtotal.Text - (Val(lbl_jmlTepat.Text) + Val(lbl_jmlTerlambat.Text)))

        DA2 = New SqlDataAdapter(New SqlCommand("select no_trans, tgl_trans, no_ref, kd_stok, kd_satuan, qty_in qty, sj_supplier from PURC.dbo.v_gudang_in_purc1", sqlconn))
        DA2.Fill(dSO, "_DpmApprv_d")

        Dim rl As DataRelation
        Dim dcolP(1) As DataColumn
        Dim dcolC(1) As DataColumn

        dcolP(1) = dSO.Tables("_DpmApprv").Columns("kd_stok")
        dcolP(0) = dSO.Tables("_DpmApprv").Columns("no_po")

        dcolC(1) = dSO.Tables("_DpmApprv_d").Columns("kd_stok")
        dcolC(0) = dSO.Tables("_DpmApprv_d").Columns("no_ref")

        rl = dSO.Relations.Add("Detail", dcolP, dcolC, False)
        GcPO_Det.DataSource = dSO.Tables("_DpmApprv")
        'rl.Nested = True
        GcPO_Det.LevelTree.Nodes.Add("Detail", GridView1)

        For Each rw As DataRow In dSO.Tables("_DpmApprv").Rows
            rw("nstatus") = cek_status_PO(rw("no_po"))
            If rw("status_po") <> "" Then
                If rw("status_po") = "CLOSE" Then
                    rw("qty_dev") = 0
                End If
            End If
        Next

    End Sub
    Sub Load_PO_Filtern1()
        tglDari2.EditValue = Nothing
        tglsampai2.EditValue = Nothing
        dSO.Relations.Clear()
        If Not dSO.Tables("_DpmApprv_d") Is Nothing Then dSO.Tables("_DpmApprv_d").Clear()
        If Not dSO.Tables("_DpmApprv") Is Nothing Then dSO.Tables("_DpmApprv").Clear()


        Dim sql As String
        'Dim kolom As String = ""
        If tglDari.Text = "" And tglsampai.Text <> "" Then
            sql = " and c.tgl_po < convert(date,'" & tglsampai.EditValue & "',103) "
        ElseIf tglDari2.Text <> "" And tglsampai2.Text = "" Then
            sql = " and c.tgl_po > convert(date,'" & tglDari.EditValue & "',103) "
        Else
            sql = " and c.tgl_po  between convert(date,'" & tglDari.EditValue & "',103) and convert(date,'" & tglsampai.EditValue & "',103) " ' "
        End If

        'DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT c.keterangan,c.tipe_trans, c.no_po, c.tgl_po, c.kd_supplier, c.Nama_Supplier, c.kd_valuta, c.kd_stok, c.nama_brg, c.kd_satuan, " & _
        '                                                            "c.qty, c.harga, c.total, c.tgl_janji_kirim,c.tgl_kirim,c.qty_in,c.qty_dev,'' as nstatus " & _
        '                                                            "FROM purc.dbo.v_po_in_gudang c where (c.Program_Name <> 'aFormPONonMaterial' and c.Program_Name <> 'frmPOJasa') " & sql, sqlconn))
        'DA.Fill(dSO, "_DpmApprv")
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT c.keterangan,c.tipe_trans, c.no_po, c.tgl_po, c.kd_supplier, c.Nama_Supplier, " & _
            "c.kd_valuta, c.kd_stok, c.nama_brg, c.kd_satuan, " & _
            "c.qty, c.harga, c.total, c.tgl_janji_kirim, " & _
            "c.tgl_kirim,c.qty_in,c.qty_dev,'' as nstatus, c.ket_ppn, c.total_tax " & _
            "FROM purc.dbo.v_po_in_gudang_non c WHERE c.Program_Name not in('aFormPONonMaterial','frmPOJasa')  " & sql, sqlconn))
        DA.Fill(dSO, "_DpmApprv")
        GcPO_Det.DataSource = dSO.Tables("_DpmApprv")

        lbl_jmlTerlambat.Text = dSO.Tables("_DpmApprv").Select("tgl_janji_kirim <= tgl_kirim", "").Count
        lbl_jmlTepat.Text = dSO.Tables("_DpmApprv").Select("tgl_janji_kirim > tgl_kirim", "").Count
        lbl_jumlahtotal.Text = dSO.Tables("_DpmApprv").Rows.Count
        lblOutstanding.Text = Val(lbl_jumlahtotal.Text - (Val(lbl_jmlTepat.Text) + Val(lbl_jmlTerlambat.Text)))

        DA2 = New SqlDataAdapter(New SqlCommand("select no_trans, tgl_trans, no_ref, kd_stok, kd_satuan, sum(qty_in) qty, sj_supplier from PURC.dbo.v_gudang_in_purc group by  no_trans,tgl_trans,no_ref, kd_stok, kd_satuan, sj_supplier", sqlconn))
        DA2.Fill(dSO, "_DpmApprv_d")


        Dim rl As DataRelation
        Dim dcolP(1) As DataColumn
        Dim dcolC(1) As DataColumn

        dcolP(1) = dSO.Tables("_DpmApprv").Columns("kd_stok")
        dcolP(0) = dSO.Tables("_DpmApprv").Columns("no_po")

        dcolC(1) = dSO.Tables("_DpmApprv_d").Columns("kd_stok")
        dcolC(0) = dSO.Tables("_DpmApprv_d").Columns("no_ref")

        rl = dSO.Relations.Add("Detail", dcolP, dcolC, False)
        'rl.Nested = True
        GcPO_Det.LevelTree.Nodes.Add("Detail", GridView1)

        'rl = dSO.Relations.Add("Detail", dSO.Tables("_DpmApprv").Columns("no_po"), dSO.Tables("_DpmApprv_d").Columns("no_ref"), False)
        'r2 = dSO.Relations.Add("Detail2", dSO.Tables("_DpmApprv").Columns("kd_stok"), dSO.Tables("_DpmApprv_d").Columns("kd_stok"), False)

        'GcPO_Det.DataSource = dSO.Tables("_DpmApprv")
        'GcPO_Det.LevelTree.Nodes.Add("Detail", GridView1) '.Nodes.Add("Detail_", GridView2)
        'GcPO_Det.LevelTree.Nodes.Add("Detail2", GridView1)

        'DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kd_Departemen,Nama_Departemen from SIF.dbo.SIF_Departemen", sqlconn))
        'DALOOKUP.Fill(ds_cari, "_lookup")
        'lookupDivisi.DataSource = ds_cari.Tables("_lookup")
        'lookupDivisi.ValueMember = "Kd_Departemen"
        'lookupDivisi.DisplayMember = "Nama_Departemen"

        'DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        'DALOOKUP.Fill(ds_cari, "_lookup1")
        'Lokupbarang.DataSource = ds_cari.Tables("_lookup1")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Supplier, Nama_Supplier from SIF.dbo.SIF_Supplier", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup2")
        lookupsupplier.DataSource = ds_cari.Tables("_lookup2")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select tipe_trans, accronim_desc from SIF.dbo.SIF_TIPE_TRANS", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup3")
        Lookuptipe.DataSource = ds_cari.Tables("_lookup3")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Gudang, Nama_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup4")
        lookupGudang.DataSource = ds_cari.Tables("_lookup4")

        For Each rw As DataRow In dSO.Tables("_DpmApprv").Rows
            rw("nstatus") = cek_status_PO(rw("no_po"))
        Next
    End Sub
    Private Sub frmMonPEM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        tglDari.EditValue = Now.Date
        tglsampai.EditValue = Now.Date

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Supplier, Nama_Supplier from SIF.dbo.SIF_Supplier", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup2")
        lookupsupplier.DataSource = ds_cari.Tables("_lookup2")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select tipe_trans, accronim_desc from SIF.dbo.SIF_TIPE_TRANS", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup3")
        Lookuptipe.DataSource = ds_cari.Tables("_lookup3")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Gudang, Nama_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup4")
        lookupGudang.DataSource = ds_cari.Tables("_lookup4")
    End Sub


    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        If ComboBox1.Text = "PRODUKSI MATERIAL" Then
            Load_PO_Filter()
        ElseIf ComboBox1.Text = "NON PRODUKSI MATERIAL" Then
            Load_PO_Filtern1()
        ElseIf ComboBox1.Text = "" Then
            MessageBox.Show("PILIH JENIS BARANG")
        End If


    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click

        GcPO_Det.Refresh()
        GcPO_Det.ShowPrintPreview()

    End Sub

    Public Sub cetak_click()
        If Not GVApprvDPM.RowCount <= 0 Then
            'ShowGridPreview(gcGiro)
            'Hrg_Brg.Visible = False
            'kd_valuta.Visible = False
            'jml_val_trans.Visible = False
            'keterangan.Visible = False
            'GVApprvDPM.BestFitColumns()
            'Dim info As String = "Total Item : " & lbl_jumlahtotal.Text & vbCrLf & "Item Tepat Waktu : " & lbl_jmlTepat.Text & vbCrLf & "Item Terlambat : " & lbl_jmlTerlambat.Text & vbCrLf & "Item Belum Datang : " & lblOutstanding.Text
            Dim ph As DevExpress.XtraPrinting.PageHeaderFooter = CType(PrintableComponentLink1.PageHeaderFooter, PageHeaderFooter)
            ph.Footer.Content.Add("*) Total Item : " & lbl_jumlahtotal.Text & "   *) Item Belum Datang : " & lblOutstanding.Text & "  *) Item Tepat Waktu : " & lbl_jmlTepat.Text & "   *) Item Terlambat : " & lbl_jmlTerlambat.Text)
            ph.Footer.Content.Add(username)
            ph.Footer.Content.Add("Page : [Page # of Pages #]")

            PrintableComponentLink1.CreateDocument()
            PrintableComponentLink1.ShowPreview()
            'print_gc(GcPO_Det, "Laporan Purchase Order Detail", True)
            'Hrg_Brg.Visible = True
            'kd_valuta.Visible = True
            'jml_val_trans.Visible = True
            'keterangan.Visible = True
        Else
            MsgBox("Tidak ada data yang dicetak. Silahkan mengisi filter tanggal lalu menekan tombol Refresh.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
        End If
    End Sub

    Private Sub GVApprvDPM_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVApprvDPM.DoubleClick
        Try
            milih = GVApprvDPM.GetFocusedRowCellValue("no_po").ToString()

            da_cari = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_PO where no_po='" & milih & "'", sqlconn))
            da_cari.Fill(ds1, "_crpo")

            frmPO.cariPO(milih)
            frmPO.ShowDialog()

        Catch ex As Exception

        End Try
    End Sub
    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "LAPORAN PURCHASE ORDER DETIL"
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


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If ComboBox1.Text = "PRODUKSI MATERIAL" Then
            Load_PO_Filter2()
        ElseIf ComboBox1.Text = "NON PRODUKSI MATERIAL" Then
            Load_PO_Filter3()
        ElseIf ComboBox1.Text = "" Then
            MessageBox.Show("PILIH JENIS BARANG")
        End If
    End Sub

    Private Sub lckNoSJ_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lckNoSJ.QueryPopUp
        loadSJ()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If ComboBox1.Text = "PRODUKSI MATERIAL" Then
            Load_PO_Filter4()
        ElseIf ComboBox1.Text = "NON PRODUKSI MATERIAL" Then
            Load_PO_Filter5()
        ElseIf ComboBox1.Text = "" Then
            MessageBox.Show("PILIH JENIS BARANG")
        End If
    End Sub

    Sub Load_PO_Filter4()
        dSO.Relations.Clear()
        If Not dSO.Tables("_DpmApprv_d") Is Nothing Then dSO.Tables("_DpmApprv_d").Clear()
        If Not dSO.Tables("_DpmApprv") Is Nothing Then dSO.Tables("_DpmApprv").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT c.keterangan,c.tipe_trans, c.no_po, c.tgl_po, c.kd_supplier, c.Nama_Supplier, c.kd_valuta, c.kd_stok, c.nama_brg, c.kd_satuan, " & _
                                                                    "c.qty, c.harga, c.total, c.tgl_janji_kirim, c.tgl_kirim, c.qty_in,c.qty_dev,'' as nstatus, c.ket_ppn, c.total_tax " & _
                                                                    "FROM purc.dbo.v_po_in_gudang c where c.Program_Name not in('aFormPONonMaterial','frmPOJasa') " & _
                                                                        " AND c.no_po IN (" & _
                                                                        "Select no_ref from PURC.dbo.v_gudang_in_purc1" & _
                                                                        " where sj_supplier like '%" & lckNoSJ.EditValue & "%' )" & _
                                                                        " AND c.kd_stok IN (" & _
                                                                        " Select kd_stok from PURC.dbo.v_gudang_in_purc1" & _
                                                                        " where sj_supplier like '%" & lckNoSJ.EditValue & "%' )", sqlconn))
        DA.Fill(dSO, "_DpmApprv")

        lbl_jmlTerlambat.Text = dSO.Tables("_DpmApprv").Select("tgl_janji_kirim <= tgl_kirim", "").Count
        lbl_jmlTepat.Text = dSO.Tables("_DpmApprv").Select("tgl_janji_kirim > tgl_kirim", "").Count
        lbl_jumlahtotal.Text = dSO.Tables("_DpmApprv").Rows.Count
        lblOutstanding.Text = Val(lbl_jumlahtotal.Text - (Val(lbl_jmlTepat.Text) + Val(lbl_jmlTerlambat.Text)))

        DA2 = New SqlDataAdapter(New SqlCommand("select no_trans, tgl_trans, no_ref, kd_stok, kd_satuan, sum(qty_in) qty, sj_supplier from PURC.dbo.v_gudang_in_purc1 where sj_supplier like '%" & lckNoSJ.EditValue & "%' group by  no_trans,tgl_trans,no_ref, kd_stok, kd_satuan, sj_supplier", sqlconn))
        DA2.Fill(dSO, "_DpmApprv_d")

        Dim rl As DataRelation
        Dim dcolP(1) As DataColumn
        Dim dcolC(1) As DataColumn

        dcolP(1) = dSO.Tables("_DpmApprv").Columns("kd_stok")
        dcolP(0) = dSO.Tables("_DpmApprv").Columns("no_po")

        dcolC(1) = dSO.Tables("_DpmApprv_d").Columns("kd_stok")
        dcolC(0) = dSO.Tables("_DpmApprv_d").Columns("no_ref")

        rl = dSO.Relations.Add("Detail", dcolP, dcolC, False)
        GcPO_Det.DataSource = dSO.Tables("_DpmApprv")
        'rl.Nested = True
        GcPO_Det.LevelTree.Nodes.Add("Detail", GridView1)

        For Each rw As DataRow In dSO.Tables("_DpmApprv").Rows
            rw("nstatus") = cek_status_PO(rw("no_po"))
        Next
    End Sub

    Sub Load_PO_Filter5()
        dSO.Relations.Clear()
        If Not dSO.Tables("_DpmApprv_d") Is Nothing Then dSO.Tables("_DpmApprv_d").Clear()
        If Not dSO.Tables("_DpmApprv") Is Nothing Then dSO.Tables("_DpmApprv").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT c.keterangan,c.tipe_trans, c.no_po, c.tgl_po, c.kd_supplier, c.Nama_Supplier, c.kd_valuta, c.kd_stok, c.nama_brg, c.kd_satuan, " & _
                                                                    "c.qty, c.harga, c.total, c.tgl_janji_kirim, c.tgl_kirim, c.qty_in,c.qty_dev,'' as nstatus, c.ket_ppn, c.total_tax " & _
                                                                    "FROM purc.dbo.v_po_in_gudang_non c where c.Program_Name not in('aFormPONonMaterial','frmPOJasa') " & _
                                                                        " AND c.no_po IN (" & _
                                                                        "Select no_ref from PURC.dbo.v_po_in_gudang_non" & _
                                                                        " where sj_supplier like '%" & lckNoSJ.EditValue & "%' )", sqlconn))
        DA.Fill(dSO, "_DpmApprv")

        lbl_jmlTerlambat.Text = dSO.Tables("_DpmApprv").Select("tgl_janji_kirim <= tgl_kirim", "").Count
        lbl_jmlTepat.Text = dSO.Tables("_DpmApprv").Select("tgl_janji_kirim > tgl_kirim", "").Count
        lbl_jumlahtotal.Text = dSO.Tables("_DpmApprv").Rows.Count
        lblOutstanding.Text = Val(lbl_jumlahtotal.Text - (Val(lbl_jmlTepat.Text) + Val(lbl_jmlTerlambat.Text)))

        DA2 = New SqlDataAdapter(New SqlCommand("select no_trans, tgl_trans, no_ref, kd_stok, kd_satuan, sum(qty_in) qty, sj_supplier from PURC.dbo.v_gudang_in_purc where sj_supplier like '%" & lckNoSJ.EditValue & "%' group by  no_trans,tgl_trans,no_ref, kd_stok, kd_satuan, sj_supplier", sqlconn))
        DA2.Fill(dSO, "_DpmApprv_d")

        Dim rl As DataRelation
        Dim dcolP(1) As DataColumn
        Dim dcolC(1) As DataColumn

        dcolP(1) = dSO.Tables("_DpmApprv").Columns("kd_stok")
        dcolP(0) = dSO.Tables("_DpmApprv").Columns("no_po")

        dcolC(1) = dSO.Tables("_DpmApprv_d").Columns("kd_stok")
        dcolC(0) = dSO.Tables("_DpmApprv_d").Columns("no_ref")

        rl = dSO.Relations.Add("Detail", dcolP, dcolC, False)
        GcPO_Det.DataSource = dSO.Tables("_DpmApprv")
        'rl.Nested = True
        GcPO_Det.LevelTree.Nodes.Add("Detail", GridView1)

        For Each rw As DataRow In dSO.Tables("_DpmApprv").Rows
            rw("nstatus") = cek_status_PO(rw("no_po"))
        Next
    End Sub
End Class

