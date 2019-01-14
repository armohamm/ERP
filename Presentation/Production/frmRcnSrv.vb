Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base

Public Class frmRcnSrv
    Dim ds1, ds2, ds3 As New DataSet
    Dim da1, da2, da3, da4, da5, da6, da7, daP As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
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
    Private Sub frmRcnRph_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)

        If Not ds1.Tables("JDWKRJ") Is Nothing Then ds1.Tables("JDWKRJ").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='JDWKRJ'", sqlconn))
        da1.Fill(ds1, "JDWKRJ")
        txtJadwal.Properties.DataSource = ds1.Tables("JDWKRJ")

        'btnEdit = False
        'btnDelete = False
        setStatus()
        State = "ADD"
        reload()

        Dim colM(2) As DataColumn
        Dim colD(2) As DataColumn
        Dim colD1(1) As DataColumn
        Dim colD2(1) As DataColumn
        Dim rel, rel1 As DataRelation

        

        colD1(0) = ds1.Tables("SALES").Columns("no_sp")
        colD1(1) = ds1.Tables("SALES").Columns("no_sp_dtl")
        'colD1(2) = ds1.Tables("SALES").Columns("no_seq")

        colD2(0) = ds1.Tables("SOBOX").Columns("no_sp")
        colD2(1) = ds1.Tables("SOBOX").Columns("no_sp_dtl")
        'colD2(2) = ds1.Tables("SOBOX").Columns("no_seq")

        colM(0) = ds1.Tables("SOBOX").Columns("no_sp")
        colM(1) = ds1.Tables("SOBOX").Columns("no_sp_dtl")
        colM(2) = ds1.Tables("SOBOX").Columns("no_bom_service")


        colD(0) = ds1.Tables("SOBOX1").Columns("NO_SP")
        colD(1) = ds1.Tables("SOBOX1").Columns("NO_SEQ_SP")
        colD(2) = ds1.Tables("SOBOX1").Columns("Kd_Service")




        rel1 = ds1.Relations.Add("Detail Services", colD1, colD2, False)
        rel = ds1.Relations.Add("DetailBOM", colM, colD, False)
        gc.LevelTree.Nodes.Add("Detail Services", GV_Centi).Nodes.Add("DetailBOM", GV_BomService)
        'gc.DataSource = ds1.Tables("PROD")



    End Sub

    Private Sub reload()
        Dim dr, dr1 As SqlDataReader
        dr = New SqlClient.SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='KGTPPIC' and Id_Data='01'", sqlconn).ExecuteReader
        dr.Read()
        tipetrans = dr.Item("Val_kode1")
        dr.Close()
        If State = "ADD" Then
            If Not ds1.Tables("SOBOX1") Is Nothing Then ds1.Tables("SOBOX1").Clear()
            If Not ds1.Tables("SOBOX") Is Nothing Then ds1.Tables("SOBOX").Clear()
            If Not ds1.Tables("SALES") Is Nothing Then ds1.Tables("SALES").Clear()
            If Not ds1.Tables("PROD") Is Nothing Then ds1.Tables("PROD").Clear()
            If Not ds1.Tables("PROD1") Is Nothing Then ds1.Tables("PROD1").Clear()
            If Not ds1.Tables("SOBOX2") Is Nothing Then ds1.Tables("SOBOX2").Clear()
            If Not ds1.Tables("SOBOX3") Is Nothing Then ds1.Tables("SOBOX3").Clear()

          


            da6 = New SqlDataAdapter(New SqlCommand("select t.*,0.00 nilai, 0 kd_jenis,'' nama_service ,'' Nama_Jenis, '' Nama_Barang,'' Sisa, '' tgl_kirim, '' prioritas  from PROD.dbo.PROD_rcn_prod_d t where 1=0", sqlconn))
            da6.Fill(ds1, "SOBOX2")

            da7 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rcn_srv t where 1=0", sqlconn))
            da7.Fill(ds1, "SOBOX3")

            da2 = New SqlDataAdapter(New SqlCommand("select *,'' Nama_Jenis from PROD.dbo.PROD_rcn_prod_m where 1=0", sqlconn))
            da2.Fill(ds1, "PROD")
           
            Dim rwm As DataRow = ds1.Tables("PROD").NewRow
            rwm("tipe_trans") = tipetrans
            ds1.Tables("PROD").Rows.Add(rwm)


            da3 = New SqlDataAdapter(New SqlCommand("select t.*,0.00 nilai, 0 kd_jenis,'' nama_service ,'' Nama_Jenis, '' Nama_Barang,'' Sisa,'' Jenis_Group,'' Nama_Jenis_Group, '' tgl_kirim, '' prioritas  from PROD.dbo.PROD_rcn_prod_d t where 1=0", sqlconn))
            da3.Fill(ds1, "SALES")
           
            dr = New SqlClient.SqlCommand("select Distinct v.Departement,V.Kd_Cabang,V.Kd_Stok,V.No_sp,v.no_seq_d, v.No_sp_box,v.kd_jenis, " & _
                                          "ISNULL(i.nilai,0) nilai, v.Nama_Barang,v.qty_order,v.prioritas, v.tgl_kirim ,v.qty_sisa_prod " & _
                                          "from PROD.dbo.PRODV_MON_SRV_2 v " & _
                                          "left join SIF.dbo.SIF_Barang b " & _
                                          "on v.Kd_Stok = b.Kode_Barang  " & _
                                          "left join SIF.dbo.SIF_bom_service s " & _
                                          "on s.kd_service = v.Kode_Service " & _
                                          "left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '03') i " & _
                                          "on b.kd_jenis = i.kd_jenis and b.kd_tipe = i.kd_tipe and b.kd_ukuran = i.kd_ukuran " & _
                                          "where(Len(v.No_sp) > 10 And v.qty_sisa_prod > 0 " & _
                                          "and v.Departement= '" & kddep & "' ) and v.Terima_Rekomendasi = 'Y' " & _
                                          "order by v.No_sp, v.no_seq_d", sqlconn).ExecuteReader
            While dr.Read
                Dim rw As DataRow = ds1.Tables("SALES").NewRow
                rw("no_sp") = dr.Item("No_sp")
                rw("no_sp_dtl") = dr.Item("no_seq_d")
                rw("no_seq") = dr.Item("No_sp_box")
                rw("no_urut_brg") = 1
                rw("Sisa") = dr.Item("qty_sisa_prod")
                rw("kd_barang") = dr.Item("Kd_Stok")
                rw("Nama_Barang") = dr.Item("Nama_Barang")
                rw("panjang") = 0
                rw("lebar") = 0
                rw("tinggi") = 0
                rw("Nama_Jenis") = ""
                rw("kd_jenis") = dr.Item("kd_jenis")
                rw("Jenis_Group") = ""
                rw("Nama_Jenis_Group") = ""
                rw("tgl_kirim") = dr.Item("tgl_kirim")
                rw("prioritas") = dr.Item("prioritas")
                rw("jumlah") = 0
                rw("jml_indeks") = 0
                rw("nilai") = dr.Item("nilai")
                ds1.Tables("SALES").Rows.Add(rw)
            End While
            dr.Close()
            txtTgl_Rph.Text = DateTime.Today
            txtDPB.Text = ""


            da4 = New SqlDataAdapter(New SqlCommand("select t.*,0.00 nilai, 0 kd_jenis,'' nama_service ,'' Nama_Jenis, '' Nama_Barang,'' Sisa, '' tgl_kirim, '' prioritas ,'' no_bom_service,'' Nama_service from PROD.dbo.PROD_rcn_prod_d t where 1=0", sqlconn))
            da4.Fill(ds1, "SOBOX")
            dr = New SqlClient.SqlCommand("select v.*, ISNULL(i.nilai,0) nilai, s.nama_service " & _
                                          "from PROD.dbo.PRODV_MON_SRV_2 v " & _
                                          "left join SIF.dbo.SIF_Barang b " & _
                                          "on v.Kd_Stok = b.Kode_Barang " & _
                                          "left join SIF.dbo.SIF_bom_service s " & _
                                          "on s.kd_service = v.Kode_Service " & _
                                          "left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '03') i " & _
                                          "on b.kd_jenis = i.kd_jenis and b.kd_tipe = i.kd_tipe and b.kd_ukuran = i.kd_ukuran " & _
                                          "where(Len(v.No_sp) > 10 And v.qty_sisa_prod > 0 " & _
                                          "and departement= '" & kddep & "' and v.Terima_Rekomendasi ='Y' ) " & _
                                          "order by v.No_sp, v.no_seq_d", sqlconn).ExecuteReader
            While dr.Read
                Dim rwd As DataRow = ds1.Tables("SOBOX").NewRow
                rwd("no_sp") = dr.Item("No_sp")
                rwd("no_sp_dtl") = dr.Item("no_seq_d")
                rwd("no_seq") = dr.Item("No_sp_box")
                rwd("no_urut_brg") = 1
                rwd("no_bom_service") = dr.Item("Kode_Service")
                rwd("nama_service") = dr.Item("nama_service")
                rwd("Sisa") = dr.Item("Qty_Sisa_Prod")
                rwd("kd_barang") = dr.Item("Kd_Stok")
                rwd("Nama_Barang") = dr.Item("Nama_Barang")
                rwd("Nama_Jenis") = dr.Item("Nama_Jenis")
                rwd("kd_jenis") = dr.Item("kd_jenis")
                rwd("tgl_kirim") = dr.Item("tgl_kirim")
                rwd("prioritas") = dr.Item("prioritas")
                rwd("jumlah") = 0
                rwd("jml_indeks") = 0
                rwd("nilai") = dr.Item("nilai")
                rwd("bom_service") = dr.Item("Kode_Service")
                rwd("nama_service") = dr.Item("nama_service")
                ds1.Tables("SOBOX").Rows.Add(rwd)
            End While
            dr.Close()

            da5 = New SqlDataAdapter(New SqlCommand("Select b.*, br.Nama_Barang,br.Kd_Satuan " & _
                                                    "From SALES.dbo.SALES_BOM_SERVICE b " & _
                                                    "left Join SIF.dbo.SIF_Barang br " & _
                                                    "on br.Kode_Barang = b.KD_BARANG", sqlconn))
            da5.Fill(ds1, "SOBOX1")
           
            gc.DataSource = ds1.Tables("SALES")

        ElseIf State = "EDIT" Then
            If Not ds1.Tables("SOBOX1") Is Nothing Then ds1.Tables("SOBOX1").Clear()
            If Not ds1.Tables("SOBOX") Is Nothing Then ds1.Tables("SOBOX").Clear()
            If Not ds1.Tables("SALES") Is Nothing Then ds1.Tables("SALES").Clear()
            If Not ds1.Tables("PROD") Is Nothing Then ds1.Tables("PROD").Clear()
            If Not ds1.Tables("PROD1") Is Nothing Then ds1.Tables("PROD1").Clear()
            If Not ds1.Tables("SOBOX2") Is Nothing Then ds1.Tables("SOBOX2").Clear()
            If Not ds1.Tables("SOBOX3") Is Nothing Then ds1.Tables("SOBOX3").Clear()

          

            da6 = New SqlDataAdapter(New SqlCommand("select t.*,0.00 nilai, 0 kd_jenis,'' nama_service ,'' Nama_Jenis, '' Nama_Barang,'' Sisa, '' tgl_kirim, '' prioritas  from PROD.dbo.PROD_rcn_prod_d t where 1=0", sqlconn))
            da6.Fill(ds1, "SOBOX2")

            da7 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rcn_srv t where 1=0", sqlconn))
            da7.Fill(ds1, "SOBOX3")

            da2 = New SqlDataAdapter(New SqlCommand("select *, '' Nama_Jenis from PROD.dbo.PROD_rcn_prod_m where 1=0", sqlconn))
            da2.Fill(ds1, "PROD1")
            dr = New SqlClient.SqlCommand("select *, '' Nama_Jenis from PROD.dbo.PROD_rcn_prod_m where no_rph ='" & txtDPB.Text & "'", sqlconn).ExecuteReader

            While dr.Read
                Dim rwm As DataRow = ds1.Tables("PROD1").NewRow
                rwm("kd_cabang") = dr.Item("kd_cabang")
                rwm("kd_departemen") = dr.Item("kd_departemen")
                rwm("tanggal") = dr.Item("tanggal")
                rwm("no_rph") = dr.Item("no_rph")
                rwm("kd_jadwal") = dr.Item("kd_jadwal")
                rwm("tipe_trans") = tipetrans
                rwm("last_create_date") = dr.Item("last_create_date")
                rwm("last_created_by") = dr.Item("last_created_by")
                ds1.Tables("PROD1").Rows.Add(rwm)

            End While

            

            dr1 = New SqlClient.SqlCommand("select * from PROD.dbo.PROD_rcn_prod_m where no_rph = '" & txtDPB.Text & "' and rec_stat='R'", sqlconn).ExecuteReader
            dr1.Read()
            If dr1.HasRows Then

                da3 = New SqlDataAdapter(New SqlCommand("select t.*,0.00 nilai, 0 kd_jenis, '' Nama_Jenis, '' Nama_Barang,'' Jenis_Group,'' Nama_Jenis_Group,'' Sisa, '' tgl_kirim, '' prioritas  from PROD.dbo.PROD_rcn_prod_d t where 1=0", sqlconn))
                da3.Fill(ds1, "SALES")
                'Dim qstr As String = 
                dr = New SqlClient.SqlCommand("select UNI.*,ISNULL(i.nilai,0) nilai from (Select distinct v.Departement,V.Kd_Cabang,V.Kd_Stok,V.No_sp,v.no_seq_d, " & _
                                              "v.Nama_Barang, v.qty_order, v.prioritas, v.tgl_kirim, v.qty_sisa_prod, v.qty_rcn_prod " & _
                                              ",d.no_rph, d.jumlah, d.jml_indeks ,d.last_create_date, d.last_created_by " & _
                                              "from PROD.dbo.PROD_rcn_prod_d d " & _
                                              "left join PROD.dbo.PRODV_MON_SRV_2 v on v.No_sp=d.no_sp and " & _
                                              "v.no_seq_d = d.no_sp_dtl " & _
                                              "where d.no_rph= '" & txtDPB.Text & "' ) uni  " & _
                                              "left join SIF.dbo.SIF_Barang b on uni.Kd_Stok = b.Kode_Barang " & _
                                              "left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '01') i " & _
                                              "on b.kd_jenis = i.kd_jenis " & _
                                              "and b.kd_tipe = i.kd_tipe and b.kd_ukuran = i.kd_ukuran " & _
                                              "order by uni.No_sp, uni.no_seq_d", sqlconn).ExecuteReader

                While dr.Read
                    Dim rw As DataRow = ds1.Tables("SALES").NewRow
                    rw("no_sp") = dr.Item("No_sp")
                    rw("no_sp_dtl") = dr.Item("no_seq_d")
                    rw("no_seq") = 1
                    rw("no_urut_brg") = 1
                    rw("Sisa") = CInt(dr.Item("Qty_Sisa_Prod")) + CInt(dr.Item("jumlah"))
                    rw("kd_barang") = dr.Item("Kd_Stok")
                    rw("Nama_Barang") = dr.Item("Nama_Barang")
                    rw("panjang") = 0
                    rw("lebar") = 0
                    rw("tinggi") = 0
                    rw("Nama_Jenis") = ""
                    rw("kd_jenis") = ""
                    rw("Jenis_Group") = ""
                    rw("Nama_Jenis_Group") = ""
                    rw("tgl_kirim") = dr.Item("tgl_kirim")
                    rw("prioritas") = dr.Item("prioritas")
                    rw("jumlah") = dr.Item("jumlah")
                    rw("jml_indeks") = dr.Item("jml_indeks")
                    rw("nilai") = dr.Item("nilai")

                    ds1.Tables("SALES").Rows.Add(rw)
                    gv.OptionsBehavior.Editable = False
                End While
                dr.Close()
            Else
                da3 = New SqlDataAdapter(New SqlCommand("select t.*,0.00 nilai, 0 kd_jenis, '' Nama_Jenis, '' Nama_Barang,'' Sisa,'' Nama_Jenis_Group,'' Jenis_Group, '' tgl_kirim, '' prioritas from PROD.dbo.PROD_rcn_prod_d t where 1=0", sqlconn))
                da3.Fill(ds1, "SALES")
                Dim qstr As String = "select uni.*,ISNULL(i.nilai,0) nilai from ( " & _
                "Select Subquery1.* From (select Distinct v.Departement,V.Kd_Cabang,V.Kd_Stok,V.No_sp,v.no_seq_d, " & _
                "v.Nama_Barang, v.qty_order, v.prioritas, v.tgl_kirim, v.qty_sisa_prod, v.qty_rcn_prod " & _
                ",'' no_rph, 0 jumlah, 0 jml_indeks ,d.last_create_date, d.last_created_by " & _
                "from PROD.dbo.PRODV_MON_SRV_2 v " & _
                "left join PROD.dbo.PROD_rcn_prod_d d on v.No_sp = d.no_sp and " & _
                "v.no_seq_d = d.no_sp_dtl " & _
                "LEFT OUTER JOIN (Select Distinct a.no_rph, a.no_sp, a.no_sp_dtl From PROD.dbo.PROD_rcn_prod_d a " & _
                "INNER Join " & _
                "(Select no_sp,no_sp_dtl from PROD.dbo.PROD_rcn_prod_d " & _
                "where no_rph ='" & txtDPB.Text & "') d2 " & _
                "on a.no_sp = d2.no_sp and a.no_sp_dtl = d2.no_sp_dtl ) b " & _
                "on d.no_rph = b.no_rph and d.no_sp=b.no_sp and d.no_sp_dtl = b.no_sp_dtl " & _
                "where(Len(v.no_sp) > 10 And v.qty_sisa_prod > 0) " & _
                "and V.departement='" & kddep & "' and  d.no_rph <> '" & txtDPB.Text & "' and v.Terima_Rekomendasi = 'Y' " & _
                "OR  Len(v.no_sp) > 10 And v.qty_sisa_prod > 0 " & _
                "and V.departement='" & kddep & "' and  d.no_rph is Null and v.Terima_Rekomendasi = 'Y' ) Subquery1 " & _
                "LEFT OUTER JOIN " & _
                "(select Distinct v.Departement,V.Kd_Cabang,V.Kd_Stok,V.No_sp,v.no_seq_d, " & _
                "v.Nama_Barang, v.qty_order, v.prioritas, v.tgl_kirim, v.qty_sisa_prod, v.qty_rcn_prod " & _
                ",d.no_rph, d.jumlah, d.jml_indeks " & _
                "from PROD.dbo.PROD_rcn_prod_d d " & _
                "left join PROD.dbo.PRODV_MON_SRV_2 v on v.No_sp=d.no_sp and " & _
                "v.no_seq_d = d.no_sp_dtl " & _
                "where d.no_rph= '" & txtDPB.Text & "' ) Subquery2 " & _
                "on Subquery1.No_sp = Subquery2.No_sp and  Subquery1.no_seq_d = Subquery2.no_seq_d " & _
                "where(Subquery2.no_rph Is Null) " & _
                "UNION " & _
                "select distinct v.Departement,V.Kd_Cabang,V.Kd_Stok,V.No_sp,v.no_seq_d, " & _
                "v.Nama_Barang, v.qty_order, v.prioritas, v.tgl_kirim, v.qty_sisa_prod, v.qty_rcn_prod " & _
                ",d.no_rph, d.jumlah, d.jml_indeks ,d.last_create_date, d.last_created_by " & _
                "from PROD.dbo.PROD_rcn_prod_d d " & _
                "left join PROD.dbo.PRODV_MON_SRV_2 v on v.No_sp=d.no_sp and " & _
                "v.no_seq_d = d.no_sp_dtl " & _
                "where d.no_rph= '" & txtDPB.Text & "' and v.Terima_Rekomendasi = 'Y' ) uni  " & _
                "left join SIF.dbo.SIF_Barang b on uni.Kd_Stok = b.Kode_Barang " & _
                "left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '01') i " & _
                "on b.kd_jenis = i.kd_jenis " & _
                "and b.kd_tipe = i.kd_tipe and b.kd_ukuran = i.kd_ukuran " & _
                "order by uni.No_sp, uni.no_seq_d "

                dr = New SqlClient.SqlCommand(qstr, sqlconn).ExecuteReader

                While dr.Read
                    Dim rw As DataRow = ds1.Tables("SALES").NewRow
                    rw("no_sp") = dr.Item("No_sp")
                    rw("no_sp_dtl") = dr.Item("no_seq_d")
                    rw("no_seq") = 1
                    rw("no_urut_brg") = 1
                    rw("Sisa") = CInt(dr.Item("Qty_Sisa_Prod")) + CInt(dr.Item("jumlah"))
                    rw("kd_barang") = dr.Item("Kd_Stok")
                    rw("Nama_Barang") = dr.Item("Nama_Barang")
                    rw("panjang") = 0
                    rw("lebar") = 0
                    rw("tinggi") = 0
                    rw("Nama_Jenis") = ""
                    rw("kd_jenis") = ""
                    rw("Jenis_Group") = ""
                    rw("Nama_Jenis_Group") = ""
                    rw("tgl_kirim") = dr.Item("tgl_kirim")
                    rw("prioritas") = dr.Item("prioritas")
                    rw("jumlah") = dr.Item("jumlah")
                    rw("jml_indeks") = dr.Item("jml_indeks")
                    rw("nilai") = dr.Item("nilai")

                    ds1.Tables("SALES").Rows.Add(rw)
                End While
                dr.Close()
            End If
            dr1.Close()

            txtTgl_Rph.Properties.ReadOnly = True
            txtJadwal.Properties.ReadOnly = True



            da4 = New SqlDataAdapter(New SqlCommand("select t.*,0.00 nilai, 0 kd_jenis,'' nama_service , '' Nama_Jenis, '' Nama_Barang,'' Sisa, '' tgl_kirim, '' prioritas from PROD.dbo.PROD_rcn_prod_d t where 1=0", sqlconn))
            da4.Fill(ds1, "SOBOX")
            dr = New SqlClient.SqlCommand("select uni.*,ISNULL(i.nilai,0) nilai, nama_service from ( " & _
                                          "Select Subquery1.* From (select v.*,'' no_rph, 0 jumlah, 0 jml_indeks ,d.last_create_date, d.last_created_by " & _
                                          "from PROD.dbo.PRODV_MON_SRV_2 v " & _
                                          "left join PROD.dbo.PROD_rcn_prod_d d on v.No_sp = d.no_sp and " & _
                                          "v.no_seq_d = d.no_sp_dtl And v.No_sp_box = d.no_seq " & _
                                          "LEFT OUTER JOIN (Select Distinct a.no_rph, a.no_sp, a.no_sp_dtl,a.no_seq From PROD.dbo.PROD_rcn_prod_d a " & _
                                          "INNER Join " & _
                                          "(Select no_sp,no_sp_dtl,no_seq from PROD.dbo.PROD_rcn_prod_d " & _
                                          "where no_rph ='" & txtDPB.Text & "') d2 " & _
                                          "on a.no_sp = d2.no_sp and a.no_sp_dtl = d2.no_sp_dtl and a.no_seq = d2.no_seq) b " & _
                                          "on d.no_rph = b.no_rph and d.no_sp=b.no_sp and d.no_sp_dtl = b.no_sp_dtl and d.no_seq = b.no_seq " & _
                                          "where(Len(v.no_sp) > 10 And v.qty_sisa_prod > 0) " & _
                                          "and V.departement='" & kddep & "' and  d.no_rph <> '" & txtDPB.Text & "' " & _
                                          "OR  Len(v.no_sp) > 10 And v.qty_sisa_prod > 0 " & _
                                          "and V.departement='" & kddep & "' and  d.no_rph is Null) Subquery1 " & _
                                          "LEFT OUTER JOIN " & _
                                          "(select v.*,d.no_rph, d.jumlah, d.jml_indeks " & _
                                          "from PROD.dbo.PROD_rcn_prod_d d " & _
                                          "left join PROD.dbo.PRODV_MON_SRV_2 v on v.No_sp=d.no_sp and " & _
                                          "v.no_seq_d = d.no_sp_dtl And v.No_sp_box = d.no_seq " & _
                                          "where d.no_rph='" & txtDPB.Text & "' ) Subquery2 " & _
                                          "on Subquery1.No_sp = Subquery2.No_sp and  Subquery1.no_seq_d = Subquery2.no_seq_d " & _
                                          "and Subquery1.No_sp_box = Subquery2.No_sp_box " & _
                                          "where(Subquery2.no_rph Is Null) " & _
                                          "UNION " & _
                                          "select v.*,d.no_rph, d.jumlah, d.jml_indeks ,d.last_create_date, d.last_created_by " & _
                                          "from PROD.dbo.PROD_rcn_prod_d d " & _
                                          "left join PROD.dbo.PRODV_MON_SRV_2 v on v.No_sp=d.no_sp and " & _
                                          "v.no_seq_d = d.no_sp_dtl And v.No_sp_box = d.no_seq " & _
                                          "where d.no_rph='" & txtDPB.Text & "' and v.Terima_Rekomendasi = 'Y' ) uni  " & _
                                          "left join SIF.dbo.SIF_Barang b on uni.Kd_Stok = b.Kode_Barang " & _
                                          "left join SIF.dbo.SIF_bom_service s " & _
                                          "on s.kd_service = uni.Kode_Service " & _
                                          "left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '01') i  " & _
                                          "on b.kd_jenis = i.kd_jenis " & _
                                          "and b.kd_tipe = i.kd_tipe and b.kd_ukuran = i.kd_ukuran " & _
                                          "order by uni.No_sp, uni.no_seq_d , uni.No_sp_box", sqlconn).ExecuteReader
            While dr.Read
                Dim rwd As DataRow = ds1.Tables("SOBOX").NewRow
                rwd("no_sp") = dr.Item("No_sp")
                rwd("no_sp_dtl") = dr.Item("no_seq_d")
                rwd("no_seq") = dr.Item("No_sp_box")
                rwd("no_bom_service") = dr.Item("Kode_Service")
                rwd("nama_service") = dr.Item("nama_service")
                rwd("Sisa") = dr.Item("Qty_Sisa_Prod")
                rwd("kd_barang") = dr.Item("Kd_Stok")
                rwd("Nama_Barang") = dr.Item("Nama_Barang")
                rwd("Nama_Jenis") = dr.Item("Nama_Jenis")
                rwd("kd_jenis") = dr.Item("kd_jenis")
                rwd("tgl_kirim") = dr.Item("tgl_kirim")
                rwd("prioritas") = dr.Item("prioritas")
                rwd("jumlah") = dr.Item("jumlah")
                rwd("jml_indeks") = dr.Item("jml_indeks")
                rwd("nilai") = dr.Item("nilai")
                rwd("bom_service") = dr.Item("Kode_Service")
                rwd("nama_service") = dr.Item("nama_service")
                rwd("last_create_date") = dr.Item("last_create_date")
                rwd("last_created_by") = dr.Item("last_created_by")
                ds1.Tables("SOBOX").Rows.Add(rwd)
            End While
            dr.Close()

            da5 = New SqlDataAdapter(New SqlCommand("Select b.*, br.Nama_Barang,br.Kd_Satuan " & _
                                                    "From SALES.dbo.SALES_BOM_SERVICE b " & _
                                                    "left Join SIF.dbo.SIF_Barang br " & _
                                                    "on br.Kode_Barang = b.KD_BARANG", sqlconn))
            da5.Fill(ds1, "SOBOX1")

            gc.DataSource = ds1.Tables("SALES")
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

    Public Sub edit_click()


        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        'da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select P.tanggal Tanggal, P.no_rph [No RPH], S.Desc_Data [Jadwal Kerja] from PROD.dbo.PROD_rcn_prod_m P left join SIF.dbo.SIF_Gen_Reff_D S on P.kd_jadwal=S.Id_Data " & _
        '                                                            "where S.Id_Ref_Data='JDWKRJ' group by no_rph, tanggal, desc_data order by P.no_rph desc", sqlconn))
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select M.tanggal [Tanggal], M.no_rph [No RPH], S.Desc_Data [Jadwal Kerja]  from (select distinct no_rph from PROD.dbo.PROD_rcn_prod_d where vol=0 or vol is null and bom_service IS NOT NULL) D  " & _
                                                                    "left join PROD.dbo.PROD_rcn_prod_m M on M.no_rph=D.no_rph  " & _
                                                                    "left join SIF.dbo.SIF_Gen_Reff_D S on M.kd_jadwal=S.Id_Data  " & _
                                                                    "where S.Id_Ref_Data='JDWKRJ'", sqlconn))

        da3.Fill(ds3, "lookup_so")
        frmCari.set_dso(ds3.Tables("lookup_so"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then

            State = "EDIT"

            txtTgl_Rph.DateTime = frmCari.row("Tanggal")
            txtDPB.Text = frmCari.row("No RPH")
            txtJadwal.Text = frmCari.row("Jadwal Kerja")
            txtJadwal.Properties.ReadOnly = True
            txtJadwal.Properties.ReadOnly = False
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

            If txtJadwal.EditValue = Nothing Then
                MessageBox.Show("Jadwal Kerja Belum Dipilih")
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

            mb = New SqlClient.SqlCommandBuilder(da6)
            da6.UpdateCommand = mb.GetUpdateCommand()
            da6.InsertCommand = mb.GetInsertCommand()
            da6.DeleteCommand = mb.GetDeleteCommand()

            mb = New SqlClient.SqlCommandBuilder(da7)
            da7.UpdateCommand = mb.GetUpdateCommand()
            da7.InsertCommand = mb.GetInsertCommand()
            da7.DeleteCommand = mb.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            da2.UpdateCommand.Transaction = BTRANS
            da2.InsertCommand.Transaction = BTRANS
            da2.DeleteCommand.Transaction = BTRANS

            da6.UpdateCommand.Transaction = BTRANS
            da6.InsertCommand.Transaction = BTRANS
            da6.DeleteCommand.Transaction = BTRANS

            da7.UpdateCommand.Transaction = BTRANS
            da7.InsertCommand.Transaction = BTRANS
            da7.DeleteCommand.Transaction = BTRANS

            Dim notrans As String
            notrans = getNoTrans("PRODSRV", txtTgl_Rph.DateTime, BTRANS)
            txtDPB.Text = notrans

            For i = ds1.Tables("SALES").Rows.Count - 1 To 0 Step -1
                Dim rowsd1 As DataRow = ds1.Tables("SALES").Rows(i)
                If Not TypeOf rowsd1("jumlah") Is DBNull Then
                    If rowsd1("jumlah") > 0 Then
                        For i1 = ds1.Tables("SOBOX").Rows.Count - 1 To 0 Step -1
                            Dim rowsx2 As DataRow = ds1.Tables("SOBOX").Rows(i1)
                            If rowsx2("no_sp") = rowsd1("no_sp") And rowsx2("no_sp_dtl") = rowsd1("no_sp_dtl") Then
                                Dim rowsd2 As DataRow = ds1.Tables("SOBOX3").NewRow
                                rowsd2("tanggal") = txtTgl_Rph.DateTime
                                rowsd2("no_rph") = notrans
                                rowsd2("no_sp") = rowsx2("no_sp")
                                rowsd2("no_sp_dtl") = rowsx2("no_sp_dtl")
                                rowsd2("no_bom_service") = rowsx2("no_bom_service")
                                rowsd2("nama_service") = rowsx2("nama_service")
                                rowsd2("no_sp_dtl") = rowsx2("no_sp_dtl")
                                rowsd2("last_create_date") = tgl
                                rowsd2("last_created_by") = username
                                rowsd2("program_name") = Me.Name
                                rowsd2("kd_cabang") = kdcabang
                                rowsd2("kd_departemen") = kddep
                                rowsd2("jumlah") = rowsd1("jumlah")
                                ds1.Tables("SOBOX3").Rows.Add(rowsd2)

                            Else

                            End If
                        Next

                        For i1 = ds1.Tables("SALES").Rows.Count - 1 To 0 Step -1
                            Dim rowsx1 As DataRow = ds1.Tables("SALES").Rows(i1)
                            If rowsx1("no_sp") = rowsd1("no_sp") And rowsx1("no_sp_dtl") = rowsd1("no_sp_dtl") Then
                                Dim rows1 As DataRow = ds1.Tables("SOBOX2").NewRow
                                rows1("tanggal") = txtTgl_Rph.DateTime
                                rows1("no_rph") = notrans
                                rows1("no_sp") = rowsx1("no_sp")
                                rows1("no_sp_dtl") = rowsx1("no_sp_dtl")
                                rows1("no_seq") = rowsx1("no_seq")
                                rows1("no_urut_brg") = rowsx1("no_urut_brg")
                                rows1("kd_jenis") = rowsx1("kd_jenis")
                                rows1("kd_barang") = rowsx1("kd_barang")
                                rows1("tinggi") = rowsx1("tinggi")
                                rows1("lebar") = rowsx1("lebar")
                                rows1("panjang") = rowsx1("panjang")
                                rows1("vol") = rowsx1("vol")
                                rows1("jml_indeks") = rowsx1("jml_indeks")
                                rows1("barcode") = rowsx1("barcode")
                                rows1("rec_stat") = rowsx1("rec_stat")
                                rows1("bom_service") = "Service"
                                rows1("last_create_date") = tgl
                                rows1("last_created_by") = username
                                rows1("program_name") = Me.Name
                                rows1("kd_cabang") = kdcabang
                                rows1("kd_departemen") = kddep
                                rows1("jumlah") = rowsd1("jumlah")
                                ds1.Tables("SOBOX2").Rows.Add(rows1)

                            Else

                            End If
                        Next

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
            mrow("kd_jadwal") = txtJadwal.EditValue
            mrow("kd_cabang") = kdcabang
            mrow("kd_departemen") = kddep
            mrow("last_create_date") = tgl
            mrow("last_created_by") = username
            mrow("last_update_date") = tgl
            mrow("last_updated_by") = username
            mrow("program_name") = Me.Name
            mrow("jns_produksi") = "SERVICE"



        Try

            da2.Update(ds1.Tables("PROD"))
            da6.Update(ds1.Tables("SOBOX2"))
            da7.Update(ds1.Tables("SOBOX3"))
            ds1.Tables("PROD").AcceptChanges()
            ds1.Tables("SOBOX2").AcceptChanges()
            ds1.Tables("SOBOX3").AcceptChanges()
            call_procedure(notrans, BTRANS)
            State = "EDIT"
            BTRANS.Commit()
            btnSave = False
            setStatus()
            showMessages("Data Berhasil Disimpan")
        Catch e As Exception
            BTRANS.Rollback()
            ds1.Tables("PROD").RejectChanges()
            ds1.Tables("SOBOX2").RejectChanges()
            ds1.Tables("SOBOX3").RejectChanges()
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

            txtDPB.Text = ""
            txtJadwal.EditValue = Nothing
            reload()
        End Try


        ElseIf State = "EDIT" Then '------------Simpan EDIT


            Dim tgl As Date = getTanggal()

            If txtJadwal.EditValue = Nothing Then
                MessageBox.Show("Jadwal Kerja Belum Dipilih")
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

            mb = New SqlClient.SqlCommandBuilder(da6)
            da6.UpdateCommand = mb.GetUpdateCommand()
            da6.InsertCommand = mb.GetInsertCommand()
            da6.DeleteCommand = mb.GetDeleteCommand()

            mb = New SqlClient.SqlCommandBuilder(da7)
            da7.UpdateCommand = mb.GetUpdateCommand()
            da7.InsertCommand = mb.GetInsertCommand()
            da7.DeleteCommand = mb.GetDeleteCommand()


            BTRANS = sqlconn.BeginTransaction("1")
            da2.UpdateCommand.Transaction = BTRANS
            da2.InsertCommand.Transaction = BTRANS
            da2.DeleteCommand.Transaction = BTRANS

            da6.UpdateCommand.Transaction = BTRANS
            da6.InsertCommand.Transaction = BTRANS
            da6.DeleteCommand.Transaction = BTRANS

            da7.UpdateCommand.Transaction = BTRANS
            da7.InsertCommand.Transaction = BTRANS
            da7.DeleteCommand.Transaction = BTRANS

            Dim notrans As String
            notrans = txtDPB.Text
            Dim dr As SqlDataReader
            Dim qstr As String

            qstr = "delete from PROD.dbo.PROD_rcn_srv where no_rph='" & notrans & "'"
            dr = New SqlClient.SqlCommand(qstr, sqlconn, BTRANS).ExecuteReader
            dr.Close()
            qstr = "delete from PROD.dbo.PROD_rcn_prod_d where no_rph='" & notrans & "'"
            dr = New SqlClient.SqlCommand(qstr, sqlconn, BTRANS).ExecuteReader
            dr.Close()
            qstr = "delete from PROD.dbo.PROD_rcn_prod_m where no_rph='" & notrans & "'"
            dr = New SqlClient.SqlCommand(qstr, sqlconn, BTRANS).ExecuteReader
            dr.Close()

            For i = ds1.Tables("SALES").Rows.Count - 1 To 0 Step -1
                Dim rowsd1 As DataRow = ds1.Tables("SALES").Rows(i)
                If Not TypeOf rowsd1("jumlah") Is DBNull Then
                    If rowsd1("jumlah") > 0 Then
                        For i1 = ds1.Tables("SOBOX").Rows.Count - 1 To 0 Step -1
                            Dim rowsx2 As DataRow = ds1.Tables("SOBOX").Rows(i1)
                            If rowsx2("no_sp") = rowsd1("no_sp") And rowsx2("no_sp_dtl") = rowsd1("no_sp_dtl") Then
                                Dim rowsd2 As DataRow = ds1.Tables("SOBOX3").NewRow
                                rowsd2("tanggal") = txtTgl_Rph.DateTime
                                rowsd2("no_rph") = notrans
                                rowsd2("no_sp") = rowsx2("no_sp")
                                rowsd2("no_sp_dtl") = rowsx2("no_sp_dtl")
                                rowsd2("no_bom_service") = rowsx2("no_bom_service")
                                rowsd2("nama_service") = rowsx2("nama_service")
                                rowsd2("no_sp_dtl") = rowsx2("no_sp_dtl")
                                rowsd2("last_create_date") = rowsx2("last_create_date")
                                rowsd2("last_created_by") = rowsx2("last_created_by")
                                rowsd2("last_update_date") = tgl
                                rowsd2("last_updated_by") = username
                                rowsd2("program_name") = Me.Name
                                rowsd2("kd_cabang") = kdcabang
                                rowsd2("kd_departemen") = kddep
                                rowsd2("jumlah") = rowsd1("jumlah")
                                ds1.Tables("SOBOX3").Rows.Add(rowsd2)

                            Else

                            End If
                        Next
                        

                        For i1 = ds1.Tables("SOBOX").Rows.Count - 1 To 0 Step -1
                            Dim rowsx1 As DataRow = ds1.Tables("SOBOX").Rows(i1)
                            If rowsx1("no_sp") = rowsd1("no_sp") And rowsx1("no_sp_dtl") = rowsd1("no_sp_dtl") Then
                                Dim rows1 As DataRow = ds1.Tables("SOBOX2").NewRow
                                rows1("tanggal") = txtTgl_Rph.DateTime
                                rows1("no_rph") = notrans
                                rows1("no_sp") = rowsx1("no_sp")
                                rows1("no_sp_dtl") = rowsx1("no_sp_dtl")
                                rows1("no_seq") = rowsx1("no_seq")
                                rows1("kd_jenis") = rowsx1("kd_jenis")
                                rows1("kd_barang") = rowsx1("kd_barang")
                                rows1("tinggi") = rowsx1("tinggi")
                                rows1("lebar") = rowsx1("lebar")
                                rows1("panjang") = rowsx1("panjang")
                                rows1("vol") = rowsx1("vol")
                                rows1("jml_indeks") = rowsx1("jml_indeks")
                                rows1("barcode") = rowsx1("barcode")
                                rows1("rec_stat") = rowsx1("rec_stat")
                                rows1("bom_service") = rowsx1("no_bom_service")
                                rows1("last_create_date") = rowsx1("last_create_date")
                                rows1("last_created_by") = rowsx1("last_created_by")
                                rows1("last_update_date") = tgl
                                rows1("last_updated_by") = username
                                rows1("program_name") = Me.Name
                                rows1("kd_cabang") = kdcabang
                                rows1("kd_departemen") = kddep
                                rows1("jumlah") = rowsd1("jumlah")
                                ds1.Tables("SOBOX2").Rows.Add(rows1)

                            Else

                            End If
                        Next

                    Else
                        ds1.Tables("SALES").Rows(i).Delete()
                    End If
                Else
                    ds1.Tables("SALES").Rows(i).Delete()
                End If
            Next

            Dim mrow1 As DataRow = ds1.Tables("PROD1").Rows(0)
            Dim mrow As DataRow = ds1.Tables("PROD").NewRow
            mrow("no_rph") = notrans
            mrow("tanggal") = mrow1("tanggal")
            mrow("kd_jadwal") = mrow1("kd_jadwal")
            mrow("kd_cabang") = mrow1("kd_cabang")
            mrow("kd_departemen") = mrow1("kd_departemen")
            mrow("last_update_date") = tgl
            mrow("last_updated_by") = username
            mrow("tipe_trans") = mrow1("tipe_trans")
            mrow("last_create_date") = mrow1("last_create_date")
            mrow("last_created_by") = mrow1("last_created_by")
            mrow("program_name") = Me.Name
            mrow("jns_produksi") = "SERVICE"
            ds1.Tables("PROD").Rows.Add(mrow)


            da2.Update(ds1.Tables("PROD"))
            da6.Update(ds1.Tables("SOBOX2"))
            da7.Update(ds1.Tables("SOBOX3"))
            ds1.Tables("PROD").AcceptChanges()
            ds1.Tables("SOBOX2").AcceptChanges()
            ds1.Tables("SOBOX3").AcceptChanges()
            call_procedure(notrans, BTRANS)
            State = "EDIT"
            BTRANS.Commit()
            btnSave = False
            setStatus()
            showMessages("Data Berhasil Disimpan")
            'Dim mrow1 As DataRow
            'For i = ds1.Tables("PROD1").Rows.Count - 1 To 0 Step -1
            '    mrow1 = ds1.Tables("PROD1").Rows(i)
            '    If mrow1.GetChildRows("Detail").Count() = 0 Then
            '        mrow1.Delete()
            '    Else

            '    End If
            'Next

            'Try

            '    da2.Update(ds1.Tables("PROD"))
            '    da6.Update(ds1.Tables("SOBOX2"))
            '    da7.Update(ds1.Tables("SOBOX3"))
            '    ds1.Tables("PROD").AcceptChanges()
            '    ds1.Tables("SOBOX2").AcceptChanges()
            '    ds1.Tables("SOBOX3").AcceptChanges()
            '    call_procedure(notrans, BTRANS)
            '    State = "EDIT"
            '    BTRANS.Commit()
            '    btnSave = False
            '    setStatus()
            '    showMessages("Data Berhasil Disimpan")
            'Catch e As Exception
            '    BTRANS.Rollback()
            '    ds1.Tables("PROD").RejectChanges()
            '    ds1.Tables("SOBOX2").RejectChanges()
            '    ds1.Tables("SOBOX3").RejectChanges()
            '    MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

            '    State = "EDIT"
            '    reload()
            'End Try
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
        btnAdd = True
        setStatus()
        Me.Enabled = False
        txtJadwal.EditValue = Nothing
        txtTgl_Rph.Properties.ReadOnly = False
        txtJadwal.Properties.ReadOnly = False
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
        'Dim nosp As ColumnView = sender
        'Dim nospseq As ColumnView = sender
        'nosp.GetFocusedRowCellValue("no_sp")
        'nospseq.GetFocusedRowCellValue("no_sp_dtl")

        'If nosp.GetFocusedRowCellValue("no_sp") <> "" Then
        '    Dim dr As SqlDataReader = New SqlClient.SqlCommand("select * from PROD.dbo.PRODV_MON_SRV2 where NO_SP='" & nosp.GetFocusedRowCellValue("no_sp") & "' and no_seq_d='" & nospseq.GetFocusedRowCellValue("no_sp_dtl") & "' order by No_sp, no_seq_d", sqlconn).ExecuteReader
        '    dr.Read()
        '    frmDtlSO.nosp.Text = dr.Item("No_sp").ToString
        '    frmDtlSO.noseq.Text = dr.Item("no_seq_d").ToString
        '    frmDtlSO.cust.Text = dr.Item("Nama_Customer").ToString
        '    frmDtlSO.barang.Text = dr.Item("Nama_Barang").ToString
        '    frmDtlSO.Qty_Order.Text = dr.Item("Qty_Order").ToString
        '    frmDtlSO.Qty_Rcn_Krm.Text = dr.Item("Qty_Rcn_Krm").ToString
        '    frmDtlSO.Qty_Rcn_Prod.Text = dr.Item("Qty_Rcn_Prod").ToString
        '    frmDtlSO.Qty_Sisa_Krm.Text = dr.Item("Qty_Sisa_Krm").ToString
        '    frmDtlSO.Qty_Sisa_Prod.Text = dr.Item("Qty_Sisa_Prod").ToString
        '    frmDtlSO.tanggal.Text = dr.Item("tgl_kirim").ToString
        '    frmDtlSO.Qty_Rcn_Prod.Text = dr.Item("prioritas").ToString
        '    frmDtlSO.ShowDialog()
        '    dr.Close()
        'End If
    End Sub

   End Class