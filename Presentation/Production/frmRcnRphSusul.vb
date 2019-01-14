Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base

Public Class frmRcnRphSusul
    Dim ds1, ds2, ds3, ds4, dsreff, dsData As New DataSet
    Dim da1, da2, da3, da4, da5, da6, da7, da8, dareff, daData As New SqlDataAdapter
    Dim row As DataRow
    Dim mb, mb1, mb2 As New SqlCommandBuilder
    Dim BTRANS As SqlTransaction
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA As SqlDataAdapter
    Dim DAD As SqlDataAdapter
    Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Dim myBuilder As New SqlCommandBuilder

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
        'With Me
        '    .btAdd.Enabled = btnadd
        '    .btCancel.Enabled = btnCancel
        '    .btDel.Enabled = btnDelete
        '    .btEdit.Enabled = btnEdit
        '    .btSave.Enabled = btnSave
        'End With
    End Sub

    Private Sub isiNoReff()
        If Not ds4.Tables("NoReff") Is Nothing Then ds4.Tables("NoReff").Clear()
        da4 = New SqlDataAdapter(New SqlCommand("select distinct(no_rph) from prod.dbo.prod_rcn_prod_m where no_rph_asal is NULL", sqlconn))
        da4.Fill(ds4, "NoReff")

        txtReff.Properties.DataSource = ds4.Tables("NoReff")
        txtReff.Properties.ValueMember = "no_rph"
        txtReff.Properties.DisplayMember = "no_rph"

        If ds4.Tables("NoReff").Rows.Count = 0 Then
            txtReff.Properties.NullText = "[Data Tidak Ada]"
        End If
    End Sub

    Private Sub frmRcnRphSusul_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)

        'If Not ds1.Tables("JDWKRJ") Is Nothing Then ds1.Tables("JDWKRJ").Clear()
        'da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='JDWKRJ'", sqlconn))
        'da1.Fill(ds1, "JDWKRJ")
        'txtJadwal.Properties.DataSource = ds1.Tables("JDWKRJ")

        'btnEdit = False
        'btnDelete = False
        setStatus()
        State = "ADD"
        isiNoReff()

        reload()

        Dim colM(0) As DataColumn
        Dim colD(0) As DataColumn
        Dim colD1(2) As DataColumn
        Dim colD2(2) As DataColumn
        Dim rel, rel1 As DataRelation

        colM(0) = ds1.Tables("PROD1").Columns("Jenis_Group")

        colD(0) = ds1.Tables("SALES").Columns("Jenis_Group")

        colD1(0) = ds1.Tables("SALES").Columns("no_sp")
        colD1(1) = ds1.Tables("SALES").Columns("no_sp_dtl")
        colD1(2) = ds1.Tables("SALES").Columns("no_seq")

        colD2(0) = ds1.Tables("SOBOX").Columns("No_sp")
        colD2(1) = ds1.Tables("SOBOX").Columns("no_seq_d")
        colD2(2) = ds1.Tables("SOBOX").Columns("No_sp_box")


        rel = ds1.Relations.Add("Detail", colM, colD, False)
        rel1 = ds1.Relations.Add("Detail Busa", colD1, colD2, False)
        gc.LevelTree.Nodes.Add("Detail", gv).Nodes.Add("Detail Busa", GV_DetailCenti)
        'gc.DataSource = ds1.Tables("PROD")
    End Sub

    Private Sub reload()
        Dim dr As SqlDataReader
        dr = New SqlClient.SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='KGTPPIC' and Id_Data='01'", sqlconn).ExecuteReader
        dr.Read()
        tipetrans = dr.Item("Val_kode1")
        dr.Close()
        If State = "ADD" Then
            If Not ds1.Tables("SOBOX") Is Nothing Then ds1.Tables("SOBOX").Clear()
            If Not ds1.Tables("SALES") Is Nothing Then ds1.Tables("SALES").Clear()
            If Not ds1.Tables("PROD") Is Nothing Then ds1.Tables("PROD").Clear()
            If Not ds1.Tables("PROD1") Is Nothing Then ds1.Tables("PROD1").Clear()

            da6 = New SqlDataAdapter(New SqlCommand("select *, '' Nama_Jenis_Group,'' Jenis_Group from PROD.dbo.PROD_rcn_prod_m where 1=0", sqlconn))
            da6.Fill(ds1, "PROD1")
            dr = New SqlClient.SqlCommand("select v.*, isnull(k.jumlah_kapasitas,0) jml_kapasitas from " & _
                                          "(select distinct Jenis_Group,Nama_Jenis_Group from PROD.dbo.PRODV_MON_SO where Len(no_sp) > 10 And qty_sisa_prod > 0" & _
                                          " and departement='" & kddep & "' and tipe_trans <> 'JPJ-KPT-06' and (sts_centi = 'N' or sts_centi is null)  " & _
                                          ") v " & _
                                          "left join " & _
                                          "(select * from SIF.dbo.SIF_kapasitas where kegiatan_ppic='01') k " & _
                                          "on v.Jenis_Group=k.kd_jenis", sqlconn).ExecuteReader
            While dr.Read
                Dim rwm1 As DataRow = ds1.Tables("PROD1").NewRow
                rwm1("Nama_Jenis_Group") = dr.Item("Nama_Jenis_Group")
                'rwm1("kd_jenis") = dr.Item("kd_jenis")
                rwm1("Jenis_Group") = dr.Item("Jenis_Group")
                rwm1("jml_kapasitas") = dr.Item("jml_kapasitas")
                ds1.Tables("PROD1").Rows.Add(rwm1)
            End While
            dr.Close()


            da2 = New SqlDataAdapter(New SqlCommand("select *, '' Nama_Jenis from PROD.dbo.PROD_rcn_prod_m where 1=0", sqlconn))
            da2.Fill(ds1, "PROD")
           
            Dim rwm As DataRow = ds1.Tables("PROD").NewRow
           
            rwm("tipe_trans") = tipetrans
            ds1.Tables("PROD").Rows.Add(rwm)
           

            da3 = New SqlDataAdapter(New SqlCommand("select t.*,0.00 nilai, 0 kd_jenis, '' Nama_Customer, '' Nama_Wilayah, '' Nama_Area,'' Nama_Jenis, '' Nama_Barang,'' Sisa, '' Jenis_Group,'' Nama_Jenis_Group,'' tgl_kirim, '' prioritas from PROD.dbo.PROD_rcn_prod_d t where 1=0", sqlconn))
            da3.Fill(ds1, "SALES")
            dr = New SqlClient.SqlCommand("select v.*, ISNULL(i.nilai,0) nilai " & _
                                          "from PROD.dbo.PRODV_MON_SO v " & _
                                          "left join SIF.dbo.SIF_Barang b " & _
                                          "on v.Kd_Stok = b.Kode_Barang " & _
                                          "left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '01') i " & _
                                          "on b.kd_jenis = i.kd_jenis and b.kd_tipe = i.kd_tipe and b.kd_ukuran = i.kd_ukuran " & _
                                          "where(Len(v.no_sp) > 10 And v.qty_sisa_prod > 0 " & _
                                          " and V.departement='" & kddep & "' and V.tipe_trans <> 'JPJ-KPT-06' and (v.sts_centi = 'N' or v.sts_centi is null)  " & _
                                          ") " & _
                                          "order by v.No_sp, v.No_seq_d", sqlconn).ExecuteReader
            While dr.Read
                Dim rw As DataRow = ds1.Tables("SALES").NewRow
                'rw("no_sp") = dr.Item("No_sp")
                'rw("no_sp_dtl") = dr.Item("No_seq_d")
                'rw("no_seq") = dr.Item("No_sp_box")
                'rw("no_urut_brg") = 1
                'rw("Sisa") = CInt(dr.Item("Qty_Sisa_Prod"))
                'rw("kd_barang") = dr.Item("Kd_Stok")
                'rw("Nama_Barang") = dr.Item("Nama_Barang")
                'rw("Nama_Jenis") = dr.Item("Nama_Jenis")
                'rw("kd_jenis") = dr.Item("kd_jenis")
                'rw("Jenis_Group") = dr.Item("Jenis_Group")
                'rw("Nama_Jenis_Group") = dr.Item("Nama_Jenis_Group")
                'rw("tgl_kirim") = IIf(dr.Item("tgl_kirim_SO") Is DBNull.Value, dr.Item("Tgl_Kirim"), dr.Item("tgl_kirim_SO"))
                'rw("prioritas") = dr.Item("prioritas")
                'rw("jumlah") = 0
                'rw("jml_indeks") = 0
                'rw("nilai") = dr.Item("nilai")

                rw("no_sp") = dr.Item("No_sp")
                rw("no_sp_dtl") = dr.Item("No_seq_d")
                rw("no_seq") = dr.Item("No_sp_box")
                rw("no_urut_brg") = 1
                rw("nama_customer") = dr.Item("Nama_Customer")
                rw("nama_wilayah") = dr.Item("Nama_Wilayah")
                rw("nama_area") = dr.Item("Nama_Area")
                rw("Sisa") = CInt(dr.Item("Qty_Sisa_Prod"))
                rw("kd_barang") = dr.Item("Kd_Stok")
                rw("Nama_Barang") = dr.Item("Nama_Barang")
                rw("panjang") = dr.Item("panjang")
                rw("lebar") = dr.Item("lebar")
                rw("tinggi") = dr.Item("tebal")
                rw("Nama_Jenis") = dr.Item("Nama_Jenis")
                rw("kd_jenis") = dr.Item("kd_jenis")
                rw("Jenis_Group") = dr.Item("Jenis_Group")
                rw("Nama_Jenis_Group") = dr.Item("Nama_Jenis_Group")
                rw("tgl_kirim") = IIf(dr.Item("tgl_kirim_SO") Is DBNull.Value, dr.Item("Tgl_Kirim"), dr.Item("tgl_kirim_SO"))
                rw("prioritas") = dr.Item("prioritas")
                rw("jumlah") = 0
                rw("jml_indeks") = 0
                rw("nilai") = dr.Item("nilai")

                ds1.Tables("SALES").Rows.Add(rw)
            End While
            dr.Close()
            txtTgl_Rph.Text = DateTime.Today

            txtJadwal.Text = ""
            txtDPB.Text = ""


            da5 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PRODV_MON_SO where panjang <> 0 and lebar <> 0 and tebal <> 0 and vol <> 0 ", sqlconn))
            da5.Fill(ds1, "SOBOX")
            gc.DataSource = ds1.Tables("PROD1")




        ElseIf State = "EDIT" Then
            If Not ds1.Tables("SOBOX") Is Nothing Then ds1.Tables("SOBOX").Clear()
            If Not ds1.Tables("SALES") Is Nothing Then ds1.Tables("SALES").Clear()
            If Not ds1.Tables("PROD") Is Nothing Then ds1.Tables("PROD").Clear()
            If Not ds1.Tables("PROD1") Is Nothing Then ds1.Tables("PROD1").Clear()

            da6 = New SqlDataAdapter(New SqlCommand("select *, '' Nama_Jenis_Group, '' Jenis_Group from PROD.dbo.PROD_rcn_prod_m where 1=0", sqlconn))
            da6.Fill(ds1, "PROD1")
            dr = New SqlClient.SqlCommand("select v.*, isnull(k.jumlah_kapasitas,0) jml_kapasitas from " & _
                                          "(select distinct Jenis_Group,Nama_Jenis_Group from PROD.dbo.PRODV_MON_SO where Len(no_sp) > 10 And qty_sisa_prod >= 0" & _
                                          " and departement='" & kddep & "' and tipe_trans <> 'JPJ-KPT-06' and (v.sts_centi = 'N' or v.sts_centi is null)  " & _
                                          ") v " & _
                                          "left join " & _
                                          "(select * from SIF.dbo.SIF_kapasitas where kegiatan_ppic='01') k " & _
                                          "on v.Jenis_Group=k.kd_jenis", sqlconn).ExecuteReader
            While dr.Read
                Dim rwm1 As DataRow = ds1.Tables("PROD1").NewRow
                rwm1("Nama_Jenis_Group") = dr.Item("Nama_Jenis_Group")
                'rwm1("kd_jenis") = dr.Item("kd_jenis")
                rwm1("Jenis_Group") = dr.Item("Jenis_Group")
                rwm1("jml_kapasitas") = dr.Item("jml_kapasitas")
                ds1.Tables("PROD1").Rows.Add(rwm1)
            End While
            dr.Close()

            da2 = New SqlDataAdapter(New SqlCommand("select *, '' Nama_Jenis from PROD.dbo.PROD_rcn_prod_m where 1=0", sqlconn))
            da2.Fill(ds1, "PROD")
           
            Dim rwm As DataRow = ds1.Tables("PROD").NewRow
            rwm("tipe_trans") = tipetrans
            ds1.Tables("PROD").Rows.Add(rwm)
           

            da3 = New SqlDataAdapter(New SqlCommand("select t.*,0.00 nilai, 0 kd_jenis,'' Nama_Wilayah, '' Nama_Area, '' Nama_Jenis, '' Nama_Jenis, '' Nama_Barang,'' Sisa,'' Jenis_Group, '' Nama_Jenis_Group, '' tgl_kirim, '' prioritas from PROD.dbo.PROD_rcn_prod_d t where 1=0", sqlconn))
            da3.Fill(ds1, "SALES")
            Dim qstr As String = "select uni.*,ISNULL(i.nilai,0) nilai from ( " & _
                "Select Subquery1.* From (select v.*,'' no_rph, 0 jumlah, 0 jml_indeks " & _
                "from PROD.dbo.PRODV_MON_SO v " & _
                "left join PROD.dbo.PROD_rcn_prod_d d on v.no_sp = d.no_sp and " & _
                "v.no_seq_d = d.no_sp_dtl And v.No_sp_box = d.no_seq " & _
                "LEFT OUTER JOIN (Select Distinct a.no_rph, a.no_sp, a.no_sp_dtl,a.no_seq From PROD.dbo.PROD_rcn_prod_d a " & _
                "INNER Join " & _
                "(Select no_sp,no_sp_dtl,no_seq from PROD.dbo.PROD_rcn_prod_d " & _
                "where no_rph ='" & txtDPB.Text & "') d2 " & _
                "on a.no_sp = d2.no_sp and a.no_sp_dtl = d2.no_sp_dtl and a.no_seq = d2.no_seq) b " & _
                "on d.no_rph = b.no_rph and d.no_sp=b.no_sp and d.no_sp_dtl = b.no_sp_dtl and d.no_seq = b.no_seq " & _
                "where(Len(v.no_sp) > 10 And v.qty_sisa_prod > 0 And (v.vol = 0 Or v.vol Is null)) " & _
                "and V.departement='2'  and  d.no_rph <> '" & txtDPB.Text & "' " & _
                "OR  Len(v.no_sp) > 10 And v.qty_sisa_prod > 0 And (v.vol = 0 Or v.vol Is null) " & _
                "and V.departement='2'  and  d.no_rph is Null and (v.sts_centi = 'N' or v.sts_centi is null) ) Subquery1 " & _
                "LEFT OUTER JOIN " & _
                "(select v.*,d.no_rph, d.jumlah, d.jml_indeks " & _
                "from PROD.dbo.PROD_rcn_prod_d d " & _
                "left join PROD.dbo.PRODV_MON_SO v on v.No_sp=d.no_sp and " & _
                "v.no_seq_d = d.no_sp_dtl And v.No_sp_box = d.no_seq " & _
                "where d.no_rph='" & txtDPB.Text & "' and (v.sts_centi = 'N' or v.sts_centi is null)) Subquery2 " & _
                "on Subquery1.no_sp = Subquery2.no_sp and  Subquery1.no_seq_d = Subquery2.no_seq_d " & _
                "and Subquery1.No_sp_box = Subquery2.No_sp_box " & _
                "where(Subquery2.no_rph Is Null) " & _
                "UNION " & _
                "select v.*,d.no_rph, d.jumlah, d.jml_indeks " & _
                "from PROD.dbo.PROD_rcn_prod_d d " & _
                "left join PROD.dbo.PRODV_MON_SO v on v.No_sp=d.no_sp and " & _
                "v.no_seq_d = d.no_sp_dtl And v.No_sp_box = d.no_seq " & _
                "where d.no_rph='" & txtDPB.Text & "' and (v.sts_centi = 'N' or v.sts_centi is null)) uni  " & _
                "left join SIF.dbo.SIF_Barang b on uni.Kd_Stok = b.Kode_Barang " & _
                "left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '01') i " & _
                "on b.kd_jenis = i.kd_jenis " & _
                "and b.kd_tipe = i.kd_tipe and b.kd_ukuran = i.kd_ukuran " & _
                "order by uni.no_sp, uni.no_seq_d , uni.No_sp_box"

            'Dim qstr As String = "select uni.*,ISNULL(i.nilai,0) nilai from (select v.*, 0 jumlah, 0 jml_indeks " & _
            '                     "from PROD.dbo.PRODV_MON_SO v " & _
            '                     "left join PROD.dbo.PROD_rcn_prod_d d on v.no_sp = d.no_sp and v.no_seq_d=d.no_sp_dtl  and v.No_sp_box = d.no_seq " & _
            '                     "left join PROD.dbo.PRODV_MON_SRV_2 SR " & _
            '                     "on SR.Nomor_SO = v.No_sp  " & _
            '                     "where(Len(v.no_sp) > 10 And v.qty_sisa_prod > 0 And (v.vol = 0 Or v.vol Is null)) " & _
            '                     "and V.departement='" & kddep & "' and d.no_sp is null and SR.Nomor_SO is null " & _
            '                     "UNION " & _
            '                     "select v.*, d.jumlah, d.jml_indeks " & _
            '                     "from PROD.dbo.PROD_rcn_prod_d d " & _
            '                     "left join PROD.dbo.PRODV_MON_SO v on v.No_sp=d.no_sp and v.no_seq_d = d.no_sp_dtl and v.No_sp_box = d.no_seq " & _
            '                     "left join PROD.dbo.PRODV_MON_SRV_2 SR " & _
            '                     "on SR.Nomor_SO = v.No_sp  " & _
            '                     "where d.no_rph='" & txtDPB.Text & "' and SR.Nomor_SO is null " & _
            '                     ") uni  " & _
            '                     "left join SIF.dbo.SIF_Barang b on uni.Kd_Stok = b.Kode_Barang " & _
            '                     "left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '01') i on b.kd_jenis = i.kd_jenis " & _
            '                     "and b.kd_tipe = i.kd_tipe and b.kd_ukuran = i.kd_ukuran order by uni.no_sp, uni.no_seq_d "
            dr = New SqlClient.SqlCommand(qstr, sqlconn).ExecuteReader

            While dr.Read
                Dim rw As DataRow = ds1.Tables("SALES").NewRow
                'rw("no_sp") = dr.Item("No_sp")
                'rw("no_sp_dtl") = dr.Item("No_seq_d")
                'rw("no_seq") = dr.Item("No_sp_box")
                'rw("Sisa") = CInt(dr.Item("Qty_Sisa_Prod")) + CInt(dr.Item("jumlah"))
                'rw("kd_barang") = dr.Item("Kd_Stok")
                'rw("Nama_Barang") = dr.Item("Nama_Barang")
                'rw("Nama_Jenis") = dr.Item("Nama_Jenis")
                'rw("kd_jenis") = dr.Item("kd_jenis")
                'rw("Jenis_Group") = dr.Item("Jenis_Group")
                'rw("Nama_Jenis_Group") = dr.Item("Nama_Jenis_Group")
                'rw("tgl_kirim") = IIf(dr.Item("tgl_kirim_SO") Is DBNull.Value, dr.Item("Tgl_Kirim"), dr.Item("tgl_kirim_SO"))
                'rw("prioritas") = dr.Item("prioritas")
                'rw("jumlah") = CInt(dr.Item("jumlah"))
                'rw("jml_indeks") = dr.Item("jml_indeks")
                'rw("nilai") = dr.Item("nilai")

                rw("no_sp") = dr.Item("No_sp")
                rw("no_sp_dtl") = dr.Item("No_seq_d")
                rw("no_seq") = dr.Item("No_sp_box")
                rw("no_urut_brg") = 1
                rw("nama_customer") = dr.Item("Nama_Customer")
                rw("nama_wilayah") = dr.Item("Nama_Wilayah")
                rw("nama_area") = dr.Item("Nama_Area")
                rw("Sisa") = CInt(dr.Item("Qty_Sisa_Prod")) + CInt(dr.Item("jumlah"))
                rw("lebar") = dr.Item("lebar")
                rw("tinggi") = dr.Item("tebal")
                rw("kd_barang") = dr.Item("Kd_Stok")
                rw("Nama_Barang") = dr.Item("Nama_Barang")
                rw("Nama_Jenis") = dr.Item("Nama_Jenis")
                rw("kd_jenis") = dr.Item("kd_jenis")
                rw("Jenis_Group") = dr.Item("Jenis_Group")
                rw("Nama_Jenis_Group") = dr.Item("Nama_Jenis_Group")
                rw("tgl_kirim") = IIf(dr.Item("tgl_kirim_SO") Is DBNull.Value, dr.Item("Tgl_Kirim"), dr.Item("tgl_kirim_SO"))
                rw("prioritas") = dr.Item("prioritas")
                rw("jumlah") = CInt(dr.Item("jumlah"))
                rw("jml_indeks") = dr.Item("jml_indeks")
                rw("nilai") = dr.Item("nilai")

                ds1.Tables("SALES").Rows.Add(rw)
            End While
            dr.Close()

            txtTgl_Rph.Properties.ReadOnly = True
            txtJadwal.ReadOnly = True

            da5 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PRODV_MON_SO where panjang <> 0 and lebar <> 0 and tebal <> 0 ", sqlconn))
            da5.Fill(ds1, "SOBOX")
            gc.DataSource = ds1.Tables("PROD1")
        End If
    End Sub

    Public Sub add_click()
        State = "ADD"
        reload()

        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False

        setStatus()
    End Sub
    Public Sub cetak_click()
        
        callReport(App_Path() & "\report\ProdPlanRph.rpt", "", "&vno_rph=" & txtDPB.Text)
       
    End Sub
    Private id_data As String
    Dim notrans As String
    Public Sub edit_click()


        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        'da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select P.tanggal Tanggal, P.no_rph [No RPH], S.Desc_Data [Jadwal Kerja] from PROD.dbo.PROD_rcn_prod_m P left join SIF.dbo.SIF_Gen_Reff_D S on P.kd_jadwal=S.Id_Data " & _
        '                                                            "where S.Id_Ref_Data='JDWKRJ' group by no_rph, tanggal, desc_data order by P.no_rph desc", sqlconn))
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select M.tanggal [Tanggal], M.no_rph [No RPH], M.no_rph_asal [No RPH Asal],S.Desc_Data [Jadwal Kerja], S.id_data  from (select distinct no_rph from PROD.dbo.PROD_rcn_prod_d where vol=0 or vol is null) D  " & _
                                                                    "left join PROD.dbo.PROD_rcn_prod_m M on M.no_rph=D.no_rph  " & _
                                                                    "left join SIF.dbo.SIF_Gen_Reff_D S on M.kd_jadwal=S.Id_Data  " & _
                                                                    "where S.Id_Ref_Data='JDWKRJ' and M.no_rph_asal IS NOT Null and (M.sts_centi = 'N' or M.sts_centi is null) Order By M.no_rph desc", sqlconn))

        da3.Fill(ds3, "lookup_so")
        frmCari.set_dso(ds3.Tables("lookup_so"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then

            State = "EDIT"

            txtDPB.Text = frmCari.row("No RPH")
            txtJadwal.Text = frmCari.row("Jadwal Kerja")
            id_data = frmCari.row("id_data")
            txtReff.EditValue = frmCari.row("No RPH Asal")
            'txtJadwal.Properties.ReadOnly = True
            'txtJadwal.Properties.ReadOnly = False
            reload()
            btnSave = True
            btnadd = False
            btnEdit = False
            btnDelete = True
            btnCancel = True
            setStatus()
            Me.Enabled = True
        Else
            cancel_click()
        End If
    End Sub

    Public Sub save_click()
        If State = "ADD" Then '----------Simpan ADD
            Dim tgl As Date = getTanggal()

            If txtReff.EditValue = vbNullString Then
                MessageBox.Show("No. Referensi Belum Dipilih")
                Exit Sub
            End If

            Dim filledrow As Integer = ds1.Tables("SALES").Select("jumlah>0").Count
            If filledrow = 0 Then
                MessageBox.Show("Jumlah Rencana Produksi Belum Ada Yang Diisi")
                Exit Sub
            End If

            Dim BTRANS As SqlTransaction
            mb = New SqlClient.SqlCommandBuilder(da2)
            da2.UpdateCommand = mb.GetUpdateCommand()
            da2.InsertCommand = mb.GetInsertCommand()
            da2.DeleteCommand = mb.GetDeleteCommand()

            mb = New SqlClient.SqlCommandBuilder(da3)
            da3.UpdateCommand = mb.GetUpdateCommand()
            da3.InsertCommand = mb.GetInsertCommand()
            da3.DeleteCommand = mb.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            da2.UpdateCommand.Transaction = BTRANS
            da2.InsertCommand.Transaction = BTRANS
            da2.DeleteCommand.Transaction = BTRANS

            da3.UpdateCommand.Transaction = BTRANS
            da3.InsertCommand.Transaction = BTRANS
            da3.DeleteCommand.Transaction = BTRANS


            'notrans = getNoTrans("PRODRPH", txtTgl_Rph.DateTime, BTRANS)
            txtDPB.Text = notrans

            For i = ds1.Tables("SALES").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = ds1.Tables("SALES").Rows(i)
                If Not TypeOf rows("jumlah") Is DBNull Then
                    If rows("jumlah") > 0 Then
                        rows("tanggal") = txtTgl_Rph.DateTime
                        rows("no_rph") = txtDPB.Text
                        rows("last_create_date") = tgl
                        rows("last_created_by") = username
                        'rows("last_update_date") = tgl
                        'rows("last_updated_by") = username
                        rows("program_name") = Me.Name
                        rows("kd_cabang") = kdcabang
                        rows("kd_departemen") = kddep
                    Else
                        ds1.Tables("SALES").Rows(i).Delete()
                    End If
                Else
                    ds1.Tables("SALES").Rows(i).Delete()
                End If
            Next


            Dim mrow As DataRow = ds1.Tables("PROD").Rows(0)
            mrow("no_rph") = notrans
            mrow("tanggal") = txtTgl_Rph.DateTime
            mrow("kd_jadwal") = id_data 'txtJadwal.EditValue
            mrow("kd_cabang") = kdcabang
            mrow("kd_departemen") = kddep
            mrow("last_create_date") = tgl
            mrow("last_created_by") = username
            'mrow("last_update_date") = tgl
            mrow("program_name") = Me.Name
            mrow("no_rph_asal") = txtReff.EditValue
            mrow("jns_produksi") = "PRODUKSI"
            mrow("sts_centi") = "N"

            Dim mrow1 As DataRow
            For i = ds1.Tables("PROD1").Rows.Count - 1 To 0 Step -1
                mrow1 = ds1.Tables("PROD1").Rows(i)
                If mrow1.GetChildRows("Detail").Count() = 0 Then
                    mrow1.Delete()
                Else

                End If
            Next

            Try

                da2.Update(ds1.Tables("PROD"))
                da3.Update(ds1.Tables("SALES"))
                ds1.Tables("PROD").AcceptChanges()
                ds1.Tables("SALES").AcceptChanges()
                call_procedure(notrans, BTRANS)
                State = "EDIT"
                BTRANS.Commit()
                btnSave = False
                setStatus()
                showMessages("Data Berhasil Disimpan")
            Catch e As Exception
                BTRANS.Rollback()
                ds1.Tables("SALES").RejectChanges()
                ds1.Tables("PROD").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

                txtDPB.Text = ""
                txtJadwal.Text = ""
                reload()
            End Try
        ElseIf State = "EDIT" Then '------------Simpan EDIT
            Dim tgl As Date = getTanggal()

            Dim filledrow As Integer = ds1.Tables("SALES").Select("jumlah>0").Count
            If filledrow = 0 Then
                MessageBox.Show("Jumlah Rencana Produksi Belum Ada Yang Diisi")
                Exit Sub
            End If

            Dim BTRANS As SqlTransaction
            mb = New SqlClient.SqlCommandBuilder(da2)
            da2.UpdateCommand = mb.GetUpdateCommand()
            da2.InsertCommand = mb.GetInsertCommand()
            da2.DeleteCommand = mb.GetDeleteCommand()

            mb = New SqlClient.SqlCommandBuilder(da3)
            da3.UpdateCommand = mb.GetUpdateCommand()
            da3.InsertCommand = mb.GetInsertCommand()
            da3.DeleteCommand = mb.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            da2.UpdateCommand.Transaction = BTRANS
            da2.InsertCommand.Transaction = BTRANS
            da2.DeleteCommand.Transaction = BTRANS

            da3.UpdateCommand.Transaction = BTRANS
            da3.InsertCommand.Transaction = BTRANS
            da3.DeleteCommand.Transaction = BTRANS


            notrans = txtDPB.Text
            Dim dr As SqlDataReader
            Dim qstr As String
            qstr = "delete from PROD.dbo.PROD_rcn_prod_d where no_rph='" & notrans & "'"
            dr = New SqlClient.SqlCommand(qstr, sqlconn, BTRANS).ExecuteReader
            dr.Close()
            qstr = "delete from PROD.dbo.PROD_rcn_prod_m where no_rph='" & notrans & "'"
            dr = New SqlClient.SqlCommand(qstr, sqlconn, BTRANS).ExecuteReader
            dr.Close()
            'da3 = New SqlDataAdapter(New SqlCommand("delete from PROD.dbo.PROD_rcn_prod_d t where no_rph='" & notrans & "'", sqlconn, BTRANS))
            'da2 = New SqlDataAdapter(New SqlCommand("delete from PROD.dbo.PROD_rcn_prod_m t where no_rph='" & notrans & "'", sqlconn, BTRANS))

            For i = ds1.Tables("SALES").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = ds1.Tables("SALES").Rows(i)
                If Not TypeOf rows("jumlah") Is DBNull Then
                    If rows("jumlah") > 0 Then
                        rows("tanggal") = txtTgl_Rph.DateTime
                        rows("no_rph") = notrans
                        rows("last_update_date") = tgl
                        rows("last_updated_by") = username
                        rows("program_name") = Me.Name
                        rows("kd_cabang") = kdcabang
                        rows("kd_departemen") = kddep
                    Else
                        ds1.Tables("SALES").Rows(i).Delete()
                    End If
                Else
                    ds1.Tables("SALES").Rows(i).Delete()
                End If
            Next

            Dim mrow As DataRow = ds1.Tables("PROD").Rows(0)
            mrow("no_rph") = notrans
            mrow("tanggal") = txtTgl_Rph.DateTime
            mrow("kd_jadwal") = id_data
            mrow("kd_cabang") = kdcabang
            mrow("kd_departemen") = kddep
            mrow("last_update_date") = tgl
            mrow("last_updated_by") = username
            mrow("program_name") = Me.Name
            mrow("no_rph_asal") = txtReff.EditValue
            mrow("jns_produksi") = "PRODUKSI"
            mrow("sts_centi") = "N"

            Dim mrow1 As DataRow
            For i = ds1.Tables("PROD1").Rows.Count - 1 To 0 Step -1
                mrow1 = ds1.Tables("PROD1").Rows(i)
                If mrow1.GetChildRows("Detail").Count() = 0 Then
                    mrow1.Delete()
                Else

                End If
            Next
            Try

                da2.Update(ds1.Tables("PROD"))
                da3.Update(ds1.Tables("SALES"))
                ds1.Tables("PROD").AcceptChanges()
                ds1.Tables("SALES").AcceptChanges()
                call_procedure(notrans, BTRANS)
                State = "EDIT"
                BTRANS.Commit()
                btnSave = False
                setStatus()
                showMessages("Data Berhasil Disimpan")
            Catch e As Exception
                BTRANS.Rollback()
                ds1.Tables("SALES").RejectChanges()
                ds1.Tables("PROD").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

                State = "EDIT"
                reload()
            End Try
        End If

    End Sub
    Public Sub call_procedure(ByVal vnotrans As String, ByVal btrans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader

        Dim sqlCmd1 As New SqlCommand
        sqlCmd1.Connection = sqlconn
        sqlCmd1.Transaction = btrans
        sqlCmd1.CommandType = CommandType.StoredProcedure
        sqlCmd1.CommandText = "PROD.dbo.prodp_ins_prod_b"
        sqlCmd1.Parameters.Add("@vno_rph", SqlDbType.Char).Value = vnotrans 'frmCari.row("NO TRANS")
        dr = sqlCmd1.ExecuteReader
        dr.Close()

        'sqlconn.Close()
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            showMessages("Deleted..")
            'cancel_click()
        End If
    End Sub

    Public Sub cancel_click()

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        txtTgl_Rph.Properties.ReadOnly = False
        txtJadwal.ReadOnly = False
        setStatus()
        Me.Enabled = False
    End Sub
    Private Sub gv_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gv.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gv_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gv.ValidateRow
        Dim isValid As Boolean = True
        If e.Row("jumlah") > e.Row("Sisa") Then
            gv.SetColumnError(Qty_Produksi, "Jumlah Rencana Produksi Terlalu Banyak", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            MessageBox.Show("Jumlah Rencana Produksi Terlalu Banyak")
            isValid = False
        Else
            e.Row("jml_indeks") = e.Row("jumlah") * e.Row("nilai")
        End If
        e.Valid = isValid
    End Sub

    Private Sub gv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gv.DoubleClick
        Dim nosp As ColumnView = sender
        Dim nospseq As ColumnView = sender
        Dim jumlah As ColumnView = sender
        nosp.GetFocusedRowCellValue("no_sp")
        nospseq.GetFocusedRowCellValue("no_sp_dtl")
        jumlah.GetFocusedRowCellValue("jumlah")

        If nosp.GetFocusedRowCellValue("no_sp") <> "" Then
            'Dim dr As SqlDataReader = New SqlClient.SqlCommand("select * from PROD.dbo.PRODV_MON_SO where no_sp='" & nosp.GetFocusedRowCellValue("no_sp") & "' and no_seq_d='" & nospseq.GetFocusedRowCellValue("no_sp_dtl") & "' order by No_sp, No_seq_d", sqlconn).ExecuteReader
            'dr.Read()
            'frmDtlSO.nosp.Text = dr.Item("no_sp").ToString
            'frmDtlSO.noseq.Text = dr.Item("no_seq_d").ToString
            'frmDtlSO.cust.Text = dr.Item("Nama_Customer").ToString
            'frmDtlSO.barang.Text = dr.Item("Nama_Barang").ToString
            'frmDtlSO.Qty_Order.Text = dr.Item("Qty_Order").ToString
            'frmDtlSO.Qty_Rcn_Krm.Text = dr.Item("Qty_Rcn_Krm").ToString
            'frmDtlSO.Qty_Rcn_Prod.Text = dr.Item("Qty_Rcn_Prod").ToString
            'frmDtlSO.Qty_Sisa_Krm.Text = dr.Item("Qty_Sisa_Krm").ToString
            'frmDtlSO.Qty_Sisa_Prod.Text = dr.Item("Qty_Sisa_Prod").ToString
            'frmDtlSO.tanggal.Text = dr.Item("tgl_kirim").ToString
            'frmDtlSO.prioritas.Text = dr.Item("prioritas").ToString
            'frmDtlSO.ShowDialog()

            'frmDtlSO2.nosp.Text = dr.Item("no_sp").ToString
            'frmDtlSO2.noseq.Text = dr.Item("no_seq_d").ToString
            'frmDtlSO2.cust.Text = dr.Item("Nama_Customer").ToString
            'frmDtlSO2.barang.Text = dr.Item("Nama_Barang").ToString
            'frmDtlSO2.Qty_Order.Text = dr.Item("Qty_Order").ToString
            'frmDtlSO2.Qty_Rcn_Krm.Text = dr.Item("Qty_Rcn_Krm").ToString
            'frmDtlSO2.Qty_Rcn_Prod.Text = dr.Item("Qty_Rcn_Prod").ToString
            'frmDtlSO2.Qty_Sisa_Krm.Text = dr.Item("Qty_Sisa_Krm").ToString
            'frmDtlSO2.Qty_Sisa_Prod.Text = dr.Item("Qty_Sisa_Prod").ToString
            'frmDtlSO2.tanggal.Text = dr.Item("tgl_kirim").ToString
            'frmDtlSO2.Qty_Rcn_Prod.Text = dr.Item("prioritas").ToString
            'frmDtlSO2.jml_barang = jumlah.GetFocusedRowCellValue("jumlah")
            'frmDtlSO2.kd_bom = dr.Item("Kd_Stok").ToString
            'frmDtlSO2.ShowDialog()
            'dr.Close()
            If nosp.GetFocusedRowCellValue("no_sp") <> "" Then
                Dim dr As SqlDataReader = New SqlClient.SqlCommand("select * from PROD.dbo.PRODV_MON_SO where no_sp='" & nosp.GetFocusedRowCellValue("no_sp") & "' and no_seq_d='" & nospseq.GetFocusedRowCellValue("no_sp_dtl") & "' order by No_sp, No_seq_d", sqlconn).ExecuteReader
                dr.Read()
                frmDtlSO.nosp.Text = dr.Item("no_sp").ToString
                frmDtlSO.noseq.Text = dr.Item("no_seq_d").ToString
                frmDtlSO.cust.Text = dr.Item("Nama_Customer").ToString
                frmDtlSO.barang.Text = dr.Item("Nama_Barang").ToString
                frmDtlSO.Qty_Order.Text = dr.Item("Qty_Order").ToString
                frmDtlSO.Qty_Rcn_Krm.Text = dr.Item("Qty_Rcn_Krm").ToString
                frmDtlSO.Qty_Rcn_Prod.Text = dr.Item("Qty_Rcn_Prod").ToString
                frmDtlSO.Qty_Sisa_Krm.Text = dr.Item("Qty_Sisa_Krm").ToString
                frmDtlSO.Qty_Sisa_Prod.Text = dr.Item("Qty_Sisa_Prod").ToString
                frmDtlSO.tanggal.Text = dr.Item("tgl_kirim").ToString
                frmDtlSO.Qty_Rcn_Prod.Text = dr.Item("prioritas").ToString
                frmDtlSO.ShowDialog()
                dr.Close()
            End If
        End If
    End Sub

    Private Sub txtReff_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtReff.EditValueChanged
        'If txtReff.EditValue = Nothing Then
        '    txtDPB.Text = ""
        'Else
        If Not dsreff.Tables("Reff") Is Nothing Then dsreff.Tables("Reff").Clear()
        dareff = New SqlDataAdapter(New SqlCommand("select count(no_rph)as no_urut from prod.dbo.prod_rcn_prod_m where no_rph_asal='" & txtReff.EditValue & "' group by no_rph", sqlconn))
        dareff.Fill(dsreff, "Reff")

        If Not dsData.Tables("Data") Is Nothing Then dsData.Tables("Data").Clear()
        daData = New SqlDataAdapter(New SqlCommand("select m.*,d.desc_data from prod.dbo.PROD_rcn_prod_m m, SIF.dbo.SIF_Gen_Reff_D d where d.Id_Data=m.kd_jadwal and d.Id_Ref_Data='JDWKRJ' and m.no_rph='" & txtReff.EditValue & "'", sqlconn))
        daData.Fill(dsData, "Data")

        If dsreff.Tables("Reff").Rows.Count = 0 Then
            notrans = txtReff.EditValue & "-" & 1
            txtJadwal.Text = dsData.Tables("Data").Rows(0).Item("desc_data")
            id_data = dsData.Tables("Data").Rows(0).Item("kd_jadwal")
        Else
            notrans = txtReff.EditValue & "-" & CInt(dsreff.Tables("Reff").Rows(0).Item(0)) + 1
            txtJadwal.Text = dsData.Tables("Data").Rows(0).Item("desc_data")
            id_data = dsData.Tables("Data").Rows(0).Item("kd_jadwal")
        End If
        'End If
    End Sub

    Private Sub btn_gen_simulBahan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gen_simulBahan.Click
        Dim dr As SqlDataReader
        If Not ds1.Tables("Barang") Is Nothing Then ds1.Tables("Barang").Clear()
        da8 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_simul_bhn_m_temp_mstr where 1=0  ", sqlconn))
        da8.Fill(ds1, "Barang")

        Dim BTRANS As SqlTransaction
        mb1 = New SqlClient.SqlCommandBuilder(da8)
        da8.UpdateCommand = mb1.GetUpdateCommand()
        da8.InsertCommand = mb1.GetInsertCommand()
        da8.DeleteCommand = mb1.GetDeleteCommand()

        BTRANS = sqlconn.BeginTransaction("1")
        da8.UpdateCommand.Transaction = BTRANS
        da8.InsertCommand.Transaction = BTRANS
        da8.DeleteCommand.Transaction = BTRANS
        Dim notrans_simulasi As String
        notrans_simulasi = getNoTrans("SMLBHNTEM", txtTgl_Rph.DateTime, BTRANS)

        For i = ds1.Tables("SALES").Rows.Count - 1 To 0 Step -1
            Dim rows As DataRow = ds1.Tables("SALES").Rows(i)
            If Not TypeOf rows("jumlah") Is DBNull Then
                If rows("jumlah") > 0 Then
                    Dim rw As DataRow = ds1.Tables("Barang").NewRow
                    rw("kd_cabang") = kdcabang
                    rw("kd_departemen") = kddep
                    rw("no_trans") = notrans_simulasi
                    rw("kd_brg") = rows("kd_barang")
                    rw("jumlah") = rows("jumlah")
                    rw("no_sp") = rows("no_sp")
                    rw("no_sp_dtl") = rows("no_sp_dtl")
                    rw("no_seq") = rows("no_seq")

                    ds1.Tables("Barang").Rows.Add(rw)

                Else

                End If
            Else

            End If
        Next


        da8.Update(ds1.Tables("Barang"))
        ds1.Tables("Barang").AcceptChanges()



        BTRANS.Commit()


        If Not ds1.Tables("Barang_d") Is Nothing Then ds1.Tables("Barang_d").Clear()
        da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_simul_bhn_m_temp where 1=0 ", sqlconn))
        da7.Fill(ds1, "Barang_d")

        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        dr = New SqlClient.SqlCommand("SELECT PROD_simul_bhn_m_temp.kd_cabang, " & _
                                                                    "PROD_simul_bhn_m_temp.kd_departemen,sum(PROD_simul_bhn_m_temp.jumlah)as jumlah, " & _
                                                                    "PROD_simul_bhn_m_temp.no_trans, " & _
                                                                    "PROD_simul_bhn_m_temp.kd_brg AS kd_barang " & _
                                                                    "FROM PROD.dbo.PROD_simul_bhn_m_temp_mstr PROD_simul_bhn_m_temp " & _
                                                                    "WHERE PROD_simul_bhn_m_temp.no_trans = '" & notrans_simulasi & "' " & _
                                                                    "GROUP BY   PROD_simul_bhn_m_temp.kd_cabang, " & _
                                                                    "PROD_simul_bhn_m_temp.kd_departemen, " & _
                                                                    "PROD_simul_bhn_m_temp.kd_brg, " & _
                                                                    "PROD_simul_bhn_m_temp.no_trans", sqlconn).ExecuteReader

        While dr.Read
            Dim rw As DataRow = ds1.Tables("Barang_d").NewRow
            rw("kd_cabang") = dr.Item("kd_cabang")
            rw("kd_departemen") = dr.Item("kd_departemen")
            rw("no_trans") = dr.Item("no_trans")
            rw("kd_brg") = dr.Item("kd_barang")
            rw("jumlah") = dr.Item("jumlah")
            ds1.Tables("Barang_d").Rows.Add(rw)
        End While
        dr.Close()

        Dim BTRANS1 As SqlTransaction
        mb2 = New SqlClient.SqlCommandBuilder(da7)
        da7.UpdateCommand = mb2.GetUpdateCommand()
        da7.InsertCommand = mb2.GetInsertCommand()
        da7.DeleteCommand = mb2.GetDeleteCommand()

        BTRANS1 = sqlconn.BeginTransaction("1")
        da7.UpdateCommand.Transaction = BTRANS1
        da7.InsertCommand.Transaction = BTRANS1
        da7.DeleteCommand.Transaction = BTRANS1

        da7.Update(ds1.Tables("Barang_d"))
        ds1.Tables("Barang_d").AcceptChanges()



        BTRANS1.Commit()


        Dim sqlCmd As New SqlCommand

        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "PROD.dbo.prodp_ins_simul_bahan_temp"
        sqlCmd.Parameters.Add("@vno_trans", SqlDbType.Char).Value = notrans_simulasi
        dr = sqlCmd.ExecuteReader
        dr.Close()
        showMessages("Processing.....")
        frmDtlSO2.notrans_simulasi = notrans_simulasi
        frmDtlSO2.ShowDialog()

    End Sub
End Class