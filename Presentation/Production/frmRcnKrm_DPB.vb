Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports System.Data.SqlClient

Public Class frmRcnKrm_DPB
    Dim ds1, ds2, ds3, ds_dpb As New DataSet
    Dim da1, da2, da3, da4, da5 As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
    Dim BTRANS As SqlTransaction
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA, DA_DPB, DAD As SqlDataAdapter
    Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode
    Dim obj As Object
    Dim prn As frmMain
    Dim tipetrans As String
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
        
    End Sub
    Private Sub Reload_Simpan()
        Dim dr As SqlDataReader
        If Not ds1.Tables("KIRIM") Is Nothing Then ds1.Tables("KIRIM").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select t.*, '' nama_jenis, '' nama_barang,'' qty_order,0 sisa, '' as tgl_kirim, '' prioritas,0.00 nilai, '' kd_stok, '' nama_customer, '' nama_wilayah, '' nama_area  from PROD.dbo.PROD_rcn_krm_d t where 1=0", sqlconn))
        da2.Fill(ds1, "KIRIM")
        dr = New SqlClient.SqlCommand("select uni.*,ISNULL(i.nilai,0) nilai from (  " & _
                                          "select v.*, d.no_trans,d.jumlah, d.jml_indeks, ISNULL(d.jml_m3,0) as jml_m3,d.no_dpb " & _
                                          "from PROD.dbo.PROD_rcn_krm_d d " & _
                                          "left join PROD.dbo.PRODV_MON_SO v on v.No_sp=d.no_sp and " & _
                                          "v.No_seq_d = d.no_sp_dtl And v.No_sp_box = d.no_seq " & _
                                          "where d.no_trans='" & txtNoTrans.Text & "' ) uni " & _
                                          "left join SIF.dbo.SIF_Barang b on uni.Kd_Stok = b.Kode_Barang  " & _
                                          "left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '02') i " & _
                                          "on b.kd_jenis = i.kd_jenis and b.kd_tipe = i.kd_tipe and b.kd_ukuran = i.kd_ukuran " & _
                                          "order by uni.no_sp, uni.no_seq_d, uni.No_sp_box", sqlconn).ExecuteReader

        While dr.Read

            Dim rw As DataRow = ds1.Tables("KIRIM").NewRow
            rw("kd_cabang") = getKodeCabang()
            rw("tanggal") = getTanggal()
            rw("no_trans") = dr.Item("no_trans")
            rw("No_sp") = dr.Item("No_sp")
            rw("no_sp_dtl") = dr.Item("no_seq_d")
            rw("no_seq") = dr.Item("No_sp_box")
            rw("kd_barang") = dr.Item("Kd_Stok")
            rw("jumlah") = CInt(dr.Item("jumlah"))
            rw("jml_indeks") = dr.Item("jml_indeks")
            rw("jml_m3") = dr.Item("jml_m3")
            rw("tinggi") = dr.Item("tebal")
            rw("lebar") = dr.Item("lebar")
            rw("panjang") = dr.Item("panjang")
            rw("rec_stat") = vbNullString
            rw("program_name") = Me.Name
            rw("Nama_Jenis") = dr.Item("Nama_Jenis")
            rw("nama_customer") = dr.Item("Nama_Customer")
            rw("nama_wilayah") = dr.Item("Nama_Wilayah")
            rw("nama_area") = dr.Item("Nama_Area")
            rw("nama_barang") = dr.Item("Nama_Barang")
            rw("qty_order") = dr.Item("Qty_Order")
            rw("sisa") = CInt(dr.Item("Qty_Sisa_Krm")) + CInt(dr.Item("jumlah"))
            'rw("tgl_kirim") = dr.Item("Tgl_Kirim")
            rw("tgl_kirim") = IIf(dr.Item("tgl_kirim_SO") Is DBNull.Value, dr.Item("Tgl_Kirim"), dr.Item("tgl_kirim_SO"))
            'rw("tgl_kirim") = Format(IIf(dr.Item("tgl_kirim_SO") Is DBNull.Value, dr.Item("Tgl_Kirim"), dr.Item("tgl_kirim_SO")), "dd/MM/yyyy")
            rw("prioritas") = dr.Item("prioritas")
            rw("nilai") = dr.Item("nilai")
            rw("kd_stok") = dr.Item("kd_stok")
            rw("no_dpb") = dr.Item("no_dpb")


            ds1.Tables("KIRIM").Rows.Add(rw)
        End While
        dr.Close()
        gc.DataSource = ds1.Tables("KIRIM")


    End Sub

    Private Sub reload()

        Dim dr As SqlDataReader
        dr = New SqlClient.SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='KGTPPIC' and Id_Data='02'", sqlconn).ExecuteReader
        dr.Read()
        tipetrans = dr.Item("Val_kode1")
        dr.Close()


        If State = "ADD" Then
            If Not ds1.Tables("SOBOX") Is Nothing Then ds1.Tables("SOBOX").Clear()
            If Not ds1.Tables("KIRIM") Is Nothing Then ds1.Tables("KIRIM").Clear()
            If Not ds1.Tables("MASTER") Is Nothing Then ds1.Tables("MASTER").Clear()


            'If Not ds1.Tables("JENIS") Is Nothing Then ds1.Tables("JENIS").Clear()
            If Not ds1.Tables("QTY") Is Nothing Then ds1.Tables("QTY").Clear()

            'da1 = New SqlDataAdapter(New SqlCommand("select distinct(v.kd_jenis), v.nama_jenis, k.jumlah_kapasitas, v.tipe_trans from sif.dbo.sif_kapasitas k, PROD.dbo.PRODV_MON_SO v where v.kd_jenis=k.kd_jenis and (Len(v.no_sp) > 10 And v.qty_sisa > 0)", sqlconn))
            'da1.Fill(ds1, "JENIS")

            da2 = New SqlDataAdapter(New SqlCommand("select t.*, '' nama_jenis, '' nama_barang,'' qty_order,'' sisa, '' tgl_kirim, '' prioritas, 0.00 nilai, 0.00 nilai_m3, '' kd_stok, '' nama_customer, '' nama_wilayah, '' nama_area from PROD.dbo.PROD_rcn_krm_d t where 1=0", sqlconn))
            da2.Fill(ds1, "KIRIM")

            da3 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rcn_krm_m where 1=0", sqlconn))
            da3.Fill(ds1, "MASTER")
            Dim rwm As DataRow = ds1.Tables("MASTER").NewRow
            rwm("tipe_trans") = tipetrans
            ds1.Tables("MASTER").Rows.Add(rwm)

            da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PRODV_MON_STOCK", sqlconn))
            da4.Fill(ds1, "QTY")
            gc2.DataSource = ds1.Tables("QTY")
            dr = New SqlClient.SqlCommand("select v.*, ISNULL(i.nilai,0) nilai, ISNULL(i.nilai_m3,0) nilai_m3,'' as no_dpb " & _
                                                               "from PROD.dbo.PRODV_MON_SO v " & _
                                                               "left join SIF.dbo.SIF_Barang b " & _
                                                               "on v.Kd_Stok = b.Kode_Barang " & _
                                                               "left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '02') i " & _
                                                               "on b.kd_jenis = i.kd_jenis and b.kd_tipe = i.kd_tipe and b.kd_ukuran = i.kd_ukuran " & _
                                                               "where(Len(v.no_sp) > 10 And v.qty_sisa_krm > 0 and v.no_sp like '%SP%' " & _
                                                               ") " & _
                                                               "order by v.No_sp, v.No_seq_d", sqlconn).ExecuteReader

            'MsgBox(dr.HasRows)
            While dr.Read
                Dim rw As DataRow = ds1.Tables("KIRIM").NewRow
                rw("kd_cabang") = getKodeCabang()
                rw("tanggal") = getTanggal()
                rw("No_sp") = dr.Item("No_sp")
                rw("no_sp_dtl") = dr.Item("No_seq_d")
                rw("no_seq") = dr.Item("No_sp_box")
                rw("kd_barang") = dr.Item("Kd_Stok")
                rw("jumlah") = 0
                rw("jml_indeks") = 0
                rw("jml_m3") = 0
                rw("rec_stat") = vbNullString
                rw("tinggi") = dr.Item("tebal")
                rw("lebar") = dr.Item("lebar")
                rw("panjang") = dr.Item("panjang")
                rw("program_name") = Me.Name
                rw("Nama_Jenis") = dr.Item("Nama_Jenis")
                rw("nama_customer") = dr.Item("Nama_Customer")
                rw("nama_wilayah") = dr.Item("Nama_Wilayah")
                rw("nama_area") = dr.Item("Nama_Area")
                rw("nama_barang") = dr.Item("Nama_Barang")
                rw("qty_order") = dr.Item("Qty_Order")
                rw("sisa") = CInt(dr.Item("Qty_Sisa_Krm"))
                'rw("tgl_kirim") = dr.Item("Tgl_Kirim")
                rw("tgl_kirim") = IIf(dr.Item("tgl_kirim_SO") Is DBNull.Value, dr.Item("Tgl_Kirim"), dr.Item("tgl_kirim_SO"))
                'rw("tgl_kirim") = Format(IIf(dr.Item("tgl_kirim_SO") Is DBNull.Value, dr.Item("Tgl_Kirim"), dr.Item("tgl_kirim_SO")), "dd/MM/yyyy")
                rw("prioritas") = dr.Item("prioritas")
                rw("nilai") = dr.Item("nilai")
                rw("nilai_m3") = dr.Item("nilai_m3")
                rw("kd_stok") = dr.Item("kd_stok")
                rw("no_dpb") = dr.Item("no_dpb")
                rw("state_edited") = "0"
                ds1.Tables("KIRIM").Rows.Add(rw)
            End While
            dr.Close()


            da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PRODV_MON_SO where panjang <> 0 and lebar <> 0 and tebal <> 0 and vol <> 0 ", sqlconn))
            da4.Fill(ds1, "SOBOX")


            gc.DataSource = ds1.Tables("KIRIM")
            txtTanggal.Text = DateTime.Today
            txtNoTrans.Text = ""



        ElseIf State = "EDIT" Then

            If Not ds1.Tables("SOBOX") Is Nothing Then ds1.Tables("SOBOX").Clear()
            If Not ds1.Tables("KIRIM") Is Nothing Then ds1.Tables("KIRIM").Clear()
            If Not ds1.Tables("MASTER") Is Nothing Then ds1.Tables("MASTER").Clear()
            If Not ds1.Tables("QTY") Is Nothing Then ds1.Tables("QTY").Clear()
            If Not ds1.Tables("KIRIM_SAVE") Is Nothing Then ds1.Tables("KIRIM_SAVE").Clear()

            da5 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rcn_krm_d d  " & _
                                                    "where d.no_trans='" & txtNoTrans.Text & "' " & _
                                                    "order by d.no_sp,d.no_sp_dtl, d.no_seq", sqlconn))
            da5.Fill(ds1, "KIRIM_SAVE")

            da2 = New SqlDataAdapter(New SqlCommand("select t.*, '' nama_jenis, '' nama_barang,'' qty_order,0 sisa, '' tgl_kirim, '' prioritas,0.00 nilai, '' kd_stok, '' nama_customer, '' nama_wilayah, '' nama_area  from PROD.dbo.PROD_rcn_krm_d t where 1=0", sqlconn))
            da2.Fill(ds1, "KIRIM")

            da3 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rcn_krm_m where no_trans='" & txtNoTrans.Text & "' ", sqlconn))
            da3.Fill(ds1, "MASTER")
            'Dim rwm As DataRow = ds1.Tables("MASTER").NewRow
            'rwm("tipe_trans") = tipetrans
            'ds1.Tables("MASTER").Rows.Add(rwm)
            da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PRODV_MON_STOCK", sqlconn))
            da4.Fill(ds1, "QTY")
            gc2.DataSource = ds1.Tables("QTY")
            'Dim dr As SqlDataReader = New SqlClient.SqlCommand("select * from PROD.dbo.PRODV_MON_SO where LEN(no_sp) > 10 and qty_sisa > 0 order by No_sp, No_seq", sqlconn).ExecuteReader
            dr = New SqlClient.SqlCommand("select uni.*,ISNULL(i.nilai,0) nilai from (  " & _
                                          "Select Subquery1.* From (select v.*, ''  no_trans,0 jumlah, 0 jml_indeks, 0 jml_m3,'' no_dpb  " & _
                                          "from PROD.dbo.PRODV_MON_SO v  " & _
                                          "left join PROD.dbo.PROD_rcn_krm_d d on v.no_sp = d.no_sp " & _
                                          "and v.no_seq_d=d.no_sp_dtl and v.No_sp_box = d.no_seq " & _
                                          "LEFT OUTER JOIN (Select Distinct a.no_trans, a.no_sp, a.no_sp_dtl,a.no_seq From PROD.dbo.PROD_rcn_krm_d a  " & _
                                          "INNER Join " & _
                                          "(Select no_sp,no_sp_dtl,no_seq from PROD.dbo.PROD_rcn_krm_d " & _
                                          "where no_trans ='" & txtNoTrans.Text & "') d2 " & _
                                          "on a.no_sp = d2.no_sp and a.no_sp_dtl = d2.no_sp_dtl and a.no_seq = d2.no_seq) b " & _
                                          "on d.no_trans <> b.no_trans and d.no_sp<>b.no_sp and d.no_sp_dtl <> b.no_sp_dtl and d.no_seq <> b.no_seq " & _
                                          "where Len(v.no_sp) > 10 And v.qty_sisa_krm > 0 and v.no_sp like '%SP%' and  d.no_trans <> '" & txtNoTrans.Text & "' " & _
                                          "or Len(v.no_sp) > 10 And v.qty_sisa_krm > 0 and v.no_sp like '%SP%' and d.no_trans is Null) Subquery1 " & _
                                          "LEFT OUTER JOIN " & _
                                          "(select v.*, d.no_trans,d.jumlah, d.jml_indeks, ISNULL(d.jml_m3,0)as jml_m3,d.no_dpb " & _
                                          "from PROD.dbo.PROD_rcn_krm_d d " & _
                                          "left join PROD.dbo.PRODV_MON_SO v on v.No_sp=d.no_sp and " & _
                                          "v.No_seq_d = d.no_sp_dtl And v.No_sp_box = d.no_seq " & _
                                          "where d.no_trans='" & txtNoTrans.Text & "') Subquery2 " & _
                                          "on Subquery1.no_sp = Subquery2.no_sp and  Subquery1.no_seq_d = Subquery2.no_seq_d " & _
                                          "and Subquery1.No_sp_box = Subquery2.No_sp_box " & _
                                          "where(Subquery2.no_trans Is Null) " & _
                                          "UNION " & _
                                          "select v.*, d.no_trans,d.jumlah, d.jml_indeks, ISNULL(d.jml_m3,0),d.no_dpb " & _
                                          "from PROD.dbo.PROD_rcn_krm_d d " & _
                                          "left join PROD.dbo.PRODV_MON_SO v on v.No_sp=d.no_sp and " & _
                                          "v.No_seq_d = d.no_sp_dtl And v.No_sp_box = d.no_seq " & _
                                          "where d.no_trans='" & txtNoTrans.Text & "' ) uni " & _
                                          "left join SIF.dbo.SIF_Barang b on uni.Kd_Stok = b.Kode_Barang  " & _
                                          "left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '02') i " & _
                                          "on b.kd_jenis = i.kd_jenis and b.kd_tipe = i.kd_tipe and b.kd_ukuran = i.kd_ukuran " & _
                                          "order by uni.no_sp, uni.no_seq_d, uni.No_sp_box", sqlconn).ExecuteReader

            While dr.Read

                Dim rw As DataRow = ds1.Tables("KIRIM").NewRow
                rw("kd_cabang") = getKodeCabang()
                rw("tanggal") = getTanggal()
                rw("no_trans") = dr.Item("no_trans")
                rw("No_sp") = dr.Item("No_sp")
                rw("no_sp_dtl") = dr.Item("no_seq_d")
                rw("no_seq") = dr.Item("No_sp_box")
                rw("kd_barang") = dr.Item("Kd_Stok")
                rw("jumlah") = CInt(dr.Item("jumlah"))
                rw("jml_indeks") = dr.Item("jml_indeks")
                rw("jml_m3") = dr.Item("jml_m3")
                rw("tinggi") = dr.Item("tebal")
                rw("lebar") = dr.Item("lebar")
                rw("panjang") = dr.Item("panjang")
                rw("rec_stat") = vbNullString
                rw("program_name") = Me.Name
                rw("Nama_Jenis") = dr.Item("Nama_Jenis")
                rw("nama_customer") = dr.Item("Nama_Customer")
                rw("nama_wilayah") = dr.Item("Nama_Wilayah")
                rw("nama_area") = dr.Item("Nama_Area")
                rw("nama_barang") = dr.Item("Nama_Barang")
                rw("qty_order") = dr.Item("Qty_Order")
                rw("sisa") = CInt(dr.Item("Qty_Sisa_Krm")) + CInt(dr.Item("jumlah"))
                'rw("tgl_kirim") = dr.Item("Tgl_Kirim")
                rw("tgl_kirim") = IIf(dr.Item("tgl_kirim_SO") Is DBNull.Value, dr.Item("Tgl_Kirim"), dr.Item("tgl_kirim_SO"))
                'rw("tgl_kirim") = Format(IIf(dr.Item("tgl_kirim_SO") Is DBNull.Value, dr.Item("Tgl_Kirim"), dr.Item("tgl_kirim_SO")), "dd/MM/yyyy")
                rw("prioritas") = dr.Item("prioritas")
                rw("nilai") = dr.Item("nilai")
                rw("kd_stok") = dr.Item("kd_stok")
                rw("no_dpb") = dr.Item("no_dpb")
                rw("state_edited") = "1"
                ds1.Tables("KIRIM").Rows.Add(rw)
            End While
            dr.Close()

            da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PRODV_MON_SO where panjang <> 0 and lebar <> 0 and tebal <> 0 and vol <> 0 ", sqlconn))
            da4.Fill(ds1, "SOBOX")


        End If

    End Sub

    Private Sub frmRcnKrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        btnEdit = True
        btnDelete = False
        setStatus()
        State = "ADD"
        reload()


        Dim colD1(2) As DataColumn
        Dim colD2(2) As DataColumn
        Dim rel1 As DataRelation

        colD1(0) = ds1.Tables("KIRIM").Columns("no_sp")
        colD1(1) = ds1.Tables("KIRIM").Columns("no_sp_dtl")
        colD1(2) = ds1.Tables("KIRIM").Columns("no_seq")

        colD2(0) = ds1.Tables("SOBOX").Columns("No_sp")
        colD2(1) = ds1.Tables("SOBOX").Columns("No_seq_d")
        colD2(2) = ds1.Tables("SOBOX").Columns("No_sp_box")

        rel1 = ds1.Relations.Add("Detail Busa", colD1, colD2, False)
        gc.LevelTree.Nodes.Add("Detail Busa", GV_BusaCenti)
        gc.DataSource = ds1.Tables("KIRIM")

        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Sopir", sqlconn))
        da1.Fill(ds1, "Sopir")
        txtSopir.Properties.DataSource = ds1.Tables("Sopir")
        txtKernet.Properties.DataSource = ds1.Tables("Sopir")

        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Kendaraan order by Nama_Kendaraan", sqlconn))
        da1.Fill(ds1, "Kendaraan")
        txtKendaraan.Properties.DataSource = ds1.Tables("Kendaraan")

    End Sub
    Public Sub call_procedure(ByVal vnotrans As String, ByVal btrans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader

        Dim sqlCmd2 As New SqlCommand
        sqlCmd2.Connection = sqlconn
        sqlCmd2.Transaction = btrans
        sqlCmd2.CommandType = CommandType.StoredProcedure
        sqlCmd2.CommandText = "PROD.dbo.prodp_ins_qty_booked_in"
        sqlCmd2.Parameters.Add("@vno_trans", SqlDbType.Char).Value = vnotrans 'frmCari.row("NO TRANS")
        dr = sqlCmd2.ExecuteReader
        dr.Close()

        'sqlconn.Close()
    End Sub
    Public Sub call_procedure_minus(ByVal vnotrans As String, ByVal btrans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader

        Dim sqlCmd2 As New SqlCommand
        sqlCmd2.Connection = sqlconn
        sqlCmd2.Transaction = btrans
        sqlCmd2.CommandType = CommandType.StoredProcedure
        sqlCmd2.CommandText = "PROD.dbo.prodp_min_qty_booked_in"
        sqlCmd2.Parameters.Add("@vno_trans", SqlDbType.Char).Value = vnotrans 'frmCari.row("NO TRANS")
        dr = sqlCmd2.ExecuteReader
        dr.Close()

        'sqlconn.Close()
    End Sub
    Public Sub add_click()
        State = "ADD"
        reload()
        'Load_GC()

        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False

        setStatus()
    End Sub

    Public Sub edit_click()

        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select P.tanggal Tanggal, P.no_trans [No Transaksi] from PROD.dbo.PROD_rcn_krm_m P " & _
                                                                    "group by P.no_trans, P.tanggal order by P.tanggal desc, P.no_trans desc", sqlconn))

        da3.Fill(ds3, "lookup_so")
        frmCari.set_dso(ds3.Tables("lookup_so"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then

            State = "EDIT"


            txtNoTrans.Text = frmCari.row("No Transaksi")
            txtTanggal.DateTime = frmCari.row("Tanggal")
            txtTanggal.Properties.ReadOnly = True
            Dim dr As SqlDataReader
            dr = New SqlClient.SqlCommand("select * from PROD.dbo.PROD_rcn_krm_m where no_trans='" & txtNoTrans.Text & "' ", sqlconn).ExecuteReader
            dr.Read()
            txtKendaraan.EditValue = dr.Item("kd_kendaraan")
            txtKapasitas.Text = dr.Item("jml_kapasitas")
            txtSopir.EditValue = dr.Item("kd_sopir")
            txtKernet.EditValue = dr.Item("kd_kenek")
            dr.Close()
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
        Dim notrans As String
        Dim tgl As Date = getTanggal()
        If State = "ADD" Then
            Dim filledrow As Integer = ds1.Tables("KIRIM").Select("jumlah>0").Count
            If filledrow = 0 Then
                MessageBox.Show("Jumlah Rencana Kirim Belum Ada Yang Diisi")
                Exit Sub
            End If

            If txtKendaraan.EditValue = Nothing Then
                MessageBox.Show("Jenis kendaraan belum dipilih !")
                Exit Sub
            End If

            Dim BTRANS As SqlTransaction
            mb = New SqlClient.SqlCommandBuilder(da3)
            da3.UpdateCommand = mb.GetUpdateCommand()
            da3.InsertCommand = mb.GetInsertCommand()
            da3.DeleteCommand = mb.GetDeleteCommand()

            mb = New SqlClient.SqlCommandBuilder(da2)
            da2.UpdateCommand = mb.GetUpdateCommand()
            da2.InsertCommand = mb.GetInsertCommand()
            da2.DeleteCommand = mb.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            da3.UpdateCommand.Transaction = BTRANS
            da3.InsertCommand.Transaction = BTRANS
            da3.DeleteCommand.Transaction = BTRANS

            da2.UpdateCommand.Transaction = BTRANS
            da2.InsertCommand.Transaction = BTRANS
            da2.DeleteCommand.Transaction = BTRANS
            notrans = getNoTrans("PRODKRM", txtTanggal.DateTime, BTRANS)


            For i = ds1.Tables("KIRIM").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = ds1.Tables("KIRIM").Rows(i)
                If Not TypeOf rows("jumlah") Is DBNull Then
                    If rows("jumlah") > 0 Then
                        rows("tanggal") = txtTanggal.EditValue
                        rows("no_trans") = notrans
                        rows("last_create_date") = tgl
                        rows("last_created_by") = username
                        rows("last_update_date") = tgl
                        rows("last_updated_by") = username
                        rows("program_name") = Me.Name
                        rows("kd_cabang") = kdcabang
                        rows("kd_departemen") = kddep
                        rows("state_edited") = "0"
                    Else
                        ds1.Tables("KIRIM").Rows(i).Delete()
                    End If
                Else
                    ds1.Tables("KIRIM").Rows(i).Delete()
                End If
            Next

            Dim rwm As DataRow = ds1.Tables("MASTER").Rows(0)
            rwm("no_trans") = notrans
            rwm("kd_kendaraan") = txtKendaraan.EditValue
            rwm("kd_sopir") = txtKetSopir.Text
            rwm("kd_kenek") = txtKetKernet.Text
            rwm("jml_kapasitas") = txtKapasitas.Text
            rwm("tanggal") = txtTanggal.EditValue
            rwm("kd_cabang") = kdcabang
            rwm("kd_departemen") = kddep
            rwm("last_create_date") = tgl
            rwm("last_created_by") = username
            'rwm("last_update_date") = tgl
            'rwm("last_updated_by") = username
            rwm("program_name") = Me.Name
            Try

                da3.Update(ds1.Tables("MASTER"))
                da2.Update(ds1.Tables("KIRIM"))
                ds1.Tables("MASTER").AcceptChanges()
                ds1.Tables("KIRIM").AcceptChanges()
                'call_procedure(notrans, BTRANS)
                BTRANS.Commit()
                txtNoTrans.Text = notrans

                showMessages("Data Berhasil Disimpan")
                generate_dpb()
                btnSave = False

                setStatus()
            Catch ex As Exception
                BTRANS.Rollback()
                ds1.Tables("MASTER").RejectChanges()
                ds1.Tables("KIRIM").RejectChanges()
                MsgBox(ex.Message)
            End Try

        ElseIf State = "EDIT" Then  '------------Simpan EDIT
            Dim filledrow As Integer = ds1.Tables("KIRIM").Select("jumlah>0").Count
            If filledrow = 0 Then
                MessageBox.Show("Jumlah Rencana Kirim Belum Ada Yang Diisi")
                Exit Sub
            End If

            Dim BTRANS As SqlTransaction
            mb = New SqlClient.SqlCommandBuilder(da3)
            da3.UpdateCommand = mb.GetUpdateCommand()
            da3.InsertCommand = mb.GetInsertCommand()
            da3.DeleteCommand = mb.GetDeleteCommand()

            mb = New SqlClient.SqlCommandBuilder(da5)
            da5.UpdateCommand = mb.GetUpdateCommand()
            da5.InsertCommand = mb.GetInsertCommand()
            da5.DeleteCommand = mb.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            da3.UpdateCommand.Transaction = BTRANS
            da3.InsertCommand.Transaction = BTRANS
            da3.DeleteCommand.Transaction = BTRANS

            da5.UpdateCommand.Transaction = BTRANS
            da5.InsertCommand.Transaction = BTRANS
            da5.DeleteCommand.Transaction = BTRANS
            notrans = txtNoTrans.Text
            'Dim qstr As String
            'Dim dr As SqlDataReader
           

            'Filter Berdasar Jumlah Kirim
            For i = ds1.Tables("KIRIM").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = ds1.Tables("KIRIM").Rows(i)
                If rows("jumlah") = 0 Then
                    ds1.Tables("KIRIM").Rows(i).Delete()
                End If
            Next
            'MsgBox(ds1.Tables("KIRIM").Rows.Count, MsgBoxStyle.Information)

            ''**Update Jika ada datanya
            For i1 = ds1.Tables("KIRIM_SAVE").Rows.Count - 1 To 0 Step -1
                Dim rows1 As DataRow = ds1.Tables("KIRIM_SAVE").Rows(i1)
                For i = ds1.Tables("KIRIM").Rows.Count - 1 To 0 Step -1
                    Dim rows As DataRow = ds1.Tables("KIRIM").Rows(i)
                    If rows1("no_trans") = rows("no_trans") And rows1("no_sp") = rows("no_sp") And rows1("no_sp_dtl") = rows("no_sp_dtl") And rows1("no_seq") = rows("no_seq") Then
                        rows1("state_edited") = "1"
                        rows1("last_update_date") = tgl
                        rows1("last_updated_by") = username
                        rows1("program_name") = Me.Name
                        rows1("jumlah") = rows("jumlah")
                        rows1("jml_indeks") = rows("jml_indeks")
                        rows1("jml_m3") = rows("jml_m3")

                    End If
                Next
            Next


            '** Hapus data
            For i1 = ds1.Tables("KIRIM_SAVE").Rows.Count - 1 To 0 Step -1
                Dim rows1 As DataRow = ds1.Tables("KIRIM_SAVE").Rows(i1)
                Dim rw() As DataRow = ds1.Tables("KIRIM").Select("no_trans='" & rows1("no_trans") & "' and no_sp='" & rows1("no_sp") & "' and " & _
                                                                 "no_sp_dtl='" & rows1("no_sp_dtl") & "' and no_seq='" & rows1("no_seq") & "'")
                If rw.Count = 0 Then
                    rows1.Delete()
                End If
            Next

            '** Menambah data
            For i = ds1.Tables("KIRIM").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = ds1.Tables("KIRIM").Rows(i)
                If rows("no_trans") = vbNullString Then
                    Dim rw As DataRow = ds1.Tables("KIRIM_SAVE").NewRow
                    rw("no_trans") = rows("no_trans")
                    rw("no_sp") = rows("no_sp")
                    rw("no_sp_dtl") = rows("no_sp_dtl")
                    rw("no_seq") = rows("no_seq")
                    rw("kd_barang") = rows("kd_barang")
                    rw("tinggi") = rows("tinggi")
                    rw("lebar") = rows("lebar")
                    rw("panjang") = rows("panjang")
                    rw("jumlah") = rows("jumlah")
                    rw("jml_indeks") = rows("jml_indeks")
                    rw("jml_m3") = rows("jml_m3")
                    rw("tanggal") = txtTanggal.EditValue
                    rw("no_trans") = notrans
                    rw("rec_stat") = "Y"
                    rw("last_create_date") = tgl
                    rw("last_created_by") = username
                    rw("program_name") = Me.Name
                    rw("kd_cabang") = kdcabang
                    rw("kd_departemen") = kddep
                    rw("state_edited") = "1"
                    ds1.Tables("KIRIM_SAVE").Rows.Add(rw)
                End If
            Next

            'Dim rw1() As DataRow = ds1.Tables("KIRIM").Select("no_trans='" & vbNullString & "'")
            'If rw1.Count > 0 Then
            '    MsgBox(rw1.Count, MsgBoxStyle.Information)
            'End If

            Dim rwm As DataRow = ds1.Tables("MASTER").Rows(0)
            'rwm("no_trans") = notrans
            rwm("tanggal") = txtTanggal.EditValue
            rwm("kd_cabang") = kdcabang
            rwm("kd_departemen") = kddep
            rwm("kd_kendaraan") = txtKendaraan.EditValue
            rwm("kd_sopir") = txtKetSopir.Text
            rwm("kd_kenek") = txtKetKernet.Text
            rwm("jml_kapasitas") = txtKapasitas.Text
            'rwm("last_create_date") = txtTanggal.DateTime
            'rwm("last_created_by") = username
            rwm("last_update_date") = tgl
            rwm("last_updated_by") = username
            rwm("program_name") = Me.Name

            Try
                'call_procedure_minus(notrans, BTRANS)
                da3.Update(ds1.Tables("MASTER"))
                da5.Update(ds1.Tables("KIRIM_SAVE"))

                ds1.Tables("MASTER").AcceptChanges()
                ds1.Tables("KIRIM_SAVE").AcceptChanges()
                'call_procedure(notrans, BTRANS)
                BTRANS.Commit()
                showMessages("Data Berhasil Disimpan")
                txtNoTrans.Text = notrans
                Reload_Simpan()
                generate_dpb()
                btnSave = False

                setStatus()
            Catch ex As Exception
                BTRANS.Rollback()
                ds1.Tables("MASTER").RejectChanges()
                ds1.Tables("KIRIM_SAVE").RejectChanges()
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Function proses(ByVal i As Int16) As String
        Dim rows_dpb As DataRow = ds_dpb.Tables("DPB_M").Rows(i)
        Dim tgl As Date = getTanggal()
        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = sqlconn
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.CommandText = "PROD.dbo.buatDPB"
        sqlcmd.Parameters.Add("@no_trans_krm", SqlDbType.VarChar, 40).Value = txtNoTrans.EditValue
        sqlcmd.Parameters.Add("@no_sp", SqlDbType.VarChar, 40).Value = rows_dpb("no_sp")
        sqlcmd.Parameters.Add("@kdpeg", SqlDbType.VarChar, 40).Value = username
        sqlcmd.Parameters.Add("@tgldpb", SqlDbType.Date).Value = tgl
        sqlcmd.Parameters.Add("@no_dpb2", SqlDbType.VarChar, 100)
        sqlcmd.Parameters("@no_dpb2").Direction = ParameterDirection.Output
        sqlcmd.ExecuteNonQuery()
        Return sqlcmd.Parameters("@no_dpb2").Value.ToString
    End Function
    Sub generate_dpb()
        Dim no_dpb As String
        If Not ds_dpb.Tables("DPB_M") Is Nothing Then ds_dpb.Tables("DPB_M").Clear()
        DA_DPB = New SqlDataAdapter(New SqlCommand("select distinct t.no_sp, '' as no_dpb ,t.no_trans,v.Kd_Customer, " & _
                                                  "v.Nama_Customer, v.Nama_Wilayah, v.Nama_Area " & _
                                                  "from PROD.dbo.PROD_rcn_krm_d t " & _
                                                  "left join PROD.dbo.PRODV_MON_SO v " & _
                                                  "on v.No_sp=t.no_sp and v.No_seq_d=t.no_sp_dtl " & _
                                                  "LEFT JOIN PROD.dbo.PROD_dpb_m m " & _
                                                  "on m.no_trans_krm = t.no_trans and m.no_sp = t.no_sp " & _
                                                  "LEFT JOIN PROD.dbo.PROD_dpb_d d " & _
                                                  "on m.no_sp = d.no_sp and m.no_trans = d.no_trans " & _
                                                  "where t.no_trans='" & txtNoTrans.EditValue & "' and d.no_sp is NULL  ", sqlconn))
        DA_DPB.Fill(ds_dpb, "DPB_M")
        'If State = "ADD" Then
        For i1 As Int16 = 0 To ds_dpb.Tables("DPB_M").Rows.Count - 1
            Dim row_dpb1 As DataRow = ds_dpb.Tables("DPB_M").Rows(i1)
            'MsgBox(row_dpb1("no_sp"), MsgBoxStyle.Information)
            no_dpb = proses(i1)

            'For i2 As Int16 = 0 To gvDetail.RowCount - 1
            '    If gvDetail.GetRowCellValue(i2, "no_dpb") Is DBNull.Value Or gvDetail.GetRowCellValue(i2, "no_dpb") = "" Then
            '        MsgBox(gvDetail.GetRowCellValue(i2, "no_sp") & " dan" & row_dpb1("no_sp"), MsgBoxStyle.Information)
            '        If gvDetail.GetRowCellValue(i2, "no_sp") = row_dpb1("no_sp") Then
            '            gvDetail.SetRowCellValue(i2, "no_dpb", no_dpb)
            '            gvDetail.RefreshRow(i2)
            '        End If
            '    End If
            'Next
        Next
        Reload_Simpan()
        showMessages("Data DPB berhasil disimpan")
        'btnSave = True
        'End If
    End Sub

    Public Sub delete_click()
       
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            showMessages("Deleted..")
            'cancel_click()
        End If
    End Sub

    Public Sub cancel_click()
        ds1.Tables("SOBOX").Clear()
        ds1.Tables("KIRIM").Clear()
        'If Not ds1.Tables("MASTER") Is Nothing Then ds1.Tables("MASTER").Clear()
        'If Not ds1.Tables("QTY") Is Nothing Then ds1.Tables("QTY").Clear()
        txtTanggal.Properties.ReadOnly = False
        txtKendaraan.EditValue = Nothing
        txtKapasitas.Text = ""
        txtNoTrans.Text = ""
        txtSopir.EditValue = Nothing
        txtKernet.EditValue = Nothing
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
    End Sub
    Public Sub cetak_click()
        'If Trim(txtNoDPB.Text) <> "" And State = "EDIT" Then
        'callReport(App_Path() & "\report\rptPOM.rpt", "", "Nomor=" & Trim(txtNoPO.Text))

        'Dim notrans As String = Trim(txtNoDPB.Text)
        callReport(App_Path() & "\report\PROD_RcnKrm.rpt", "", "&no_trans=" & txtNoTrans.Text)
        'Else
        'MessageBox.Show("Pilih data yang akan dicetak dalam mode EDIT!")
        'End If
    End Sub

    Private Sub gvDetail_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvDetail.CellValueChanged
        Dim rw As DataRow
        Dim View As ColumnView = sender
        If e.Column Is jumlah Then
            rw = ds1.Tables("KIRIM").Select("no_sp = '" & gvDetail.GetRow(e.RowHandle).item("no_sp") & "'")(0)

            gvDetail.SetRowCellValue(e.RowHandle, "jml_indeks", rw("nilai") * gvDetail.GetRow(e.RowHandle).item("jumlah"))
            gvDetail.SetRowCellValue(e.RowHandle, "jml_m3", IIf(rw("nilai_m3") Is DBNull.Value, 1, rw("nilai_m3")) * gvDetail.GetRow(e.RowHandle).item("jumlah"))
            'If gvDetail.GetRow(e.RowHandle).item("jumlah") = 0 Then
            '    State = "EDIT"
            '    reload()
            'End If
        End If
    End Sub

    Private Sub gvDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvDetail.DoubleClick
        Dim nosp As ColumnView = sender
        Dim nospseq As ColumnView = sender
        Dim no_seq As ColumnView = sender
        Dim sisa_prod As Integer
        nosp.GetFocusedRowCellValue("no_sp")
        nospseq.GetFocusedRowCellValue("no_sp_dtl")
        no_seq.GetFocusedRowCellValue("no_seq")

        If nosp.GetFocusedRowCellValue("no_sp") <> "" Then
            Dim dr As SqlDataReader = New SqlClient.SqlCommand("select * from PROD.dbo.PRODV_MON_SO where no_sp='" & nosp.GetFocusedRowCellValue("no_sp") & "' and no_seq_d='" & nospseq.GetFocusedRowCellValue("no_sp_dtl") & "' and No_sp_box='" & no_seq.GetFocusedRowCellValue("no_seq") & "' order by No_sp, No_seq_d,No_sp_box ", sqlconn).ExecuteReader
            dr.Read()
            If dr.Item("Qty_Sisa_Prod") < 0 Then
                sisa_prod = 0
            Else
                sisa_prod = dr.Item("Qty_Sisa_Prod")
            End If
            frmDtlSO.nosp.Text = dr.Item("no_sp").ToString
            frmDtlSO.noseq.Text = dr.Item("no_seq_d").ToString
            frmDtlSO.no_seq_d.Text = dr.Item("No_sp_box").ToString
            frmDtlSO.cust.Text = dr.Item("Nama_Customer").ToString
            frmDtlSO.barang.Text = dr.Item("Nama_Barang").ToString
            frmDtlSO.Qty_Order.Text = dr.Item("Qty_Order").ToString
            frmDtlSO.Qty_Rcn_Krm.Text = dr.Item("Qty_Rcn_Krm").ToString
            frmDtlSO.Qty_Rcn_Prod.Text = dr.Item("Qty_Rcn_Prod").ToString
            frmDtlSO.Qty_Sisa_Krm.Text = dr.Item("Qty_Sisa_Krm").ToString
            frmDtlSO.Qty_Sisa_Prod.Text = sisa_prod
            frmDtlSO.tanggal.Text = dr.Item("tgl_kirim").ToString
            frmDtlSO.prioritas.Text = dr.Item("prioritas").ToString
            frmDtlSO.ShowDialog()
            dr.Close()
        End If
    End Sub

    'Private Sub gvDetail_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvDetail.FocusedRowChanged
    '    Dim x As Object
    '    x = CType(gc.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
    '    Dim kdstok As String = x.GetRowCellValue(e.FocusedRowHandle, "kd_stok")
    '    If Not ds1.Tables("QTY") Is Nothing Then ds1.Tables("QTY").Clear()
    '    da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PRODV_MON_STOCK  where kd_stok = '" & kdstok & "'", sqlconn))
    '    da4.Fill(ds1, "QTY")
    '    gc2.DataSource = ds1.Tables("QTY")
    'End Sub

    Private Sub gvDetail_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvDetail.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gvDetail_RowClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvDetail.RowClick
        Dim x As Object
        x = CType(gc.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        Dim kdstok As String = x.GetRowCellValue(e.RowHandle, "kd_stok")
        If Not ds1.Tables("QTY") Is Nothing Then ds1.Tables("QTY").Clear()
        da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PRODV_MON_STOCK  where kd_stok = '" & kdstok & "'", sqlconn))
        da4.Fill(ds1, "QTY")
        gc2.DataSource = ds1.Tables("QTY")
    End Sub

    Private Sub gvDetail_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvDetail.FocusedRowChanged
        Dim x As Object
        x = CType(gc.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        Dim kdstok As String = x.GetRowCellValue(e.FocusedRowHandle, "kd_stok")
        If Not ds1.Tables("QTY") Is Nothing Then ds1.Tables("QTY").Clear()
        da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PRODV_MON_STOCK  where kd_stok = '" & kdstok & "'", sqlconn))
        da4.Fill(ds1, "QTY")
        gc2.DataSource = ds1.Tables("QTY")
    End Sub

    Private Sub gvDetail_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvDetail.ValidateRow
        Dim isValid As Boolean = True
        If e.Row("jumlah") > e.Row("Sisa") Then
            gvDetail.SetColumnError(jumlah, "Jumlah Rencana Kirim Terlalu Banyak", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            MessageBox.Show("Jumlah Rencana Kirim Terlalu Banyak")
            isValid = False
        Else
            e.Row("jml_indeks") = e.Row("jumlah") * e.Row("nilai")
            e.Row("jml_m3") = e.Row("jumlah") * IIf(e.Row("nilai_m3") Is DBNull.Value, 1, e.Row("nilai_m3"))
        End If
        e.Valid = isValid
    End Sub

    Private Sub GridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView2.DoubleClick
        Dim vkd_brg As ColumnView = sender
        vkd_brg.GetFocusedRowCellValue("kd_stok")
        If GridView2.FocusedColumn Is jml_booked Then
            frmProdMonBooked.txtNama_Barang.EditValue = vkd_brg.GetFocusedRowCellValue("kd_stok").ToString
            frmProdMonBooked.LoadGrid()
            frmProdMonBooked.ShowDialog()
        End If
        'If vkd_brg.GetFocusedRowCellValue("kd_stok") <> "" Then
        '    call_form_manual("frmProdMonBooked")
        '    frmProdMonBooked.txtNama_Barang.EditValue = vkd_brg.GetFocusedRowCellValue("kd_stok").ToString
        '    frmProdMonBooked.LoadGrid()

        '    frmProdMonBooked.TopLevel = False
        '    'frmStatusSP.filter = txtNomor.Text
        '    frmProdMonBooked.txtNama_Barang.EditValue = vkd_brg.GetFocusedRowCellValue("kd_stok").ToString
        '    Me.Controls.Add(frmProdMonBooked)
        '    frmProdMonBooked.WindowState = FormWindowState.Maximized
        '    frmProdMonBooked.Show()
        '    pnl.SendToBack()

        'End If

    End Sub

    Private Sub txtKendaraan_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKendaraan.EditValueChanged
        txtKapasitas.Text = txtKendaraan.GetColumnValue("Kapasitas")
        TxtM3.Text = txtKendaraan.GetColumnValue("Kapasitas_m3")
        txtketKendaraan.Text = txtKendaraan.EditValue
    End Sub

    Private Sub txtSopir_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSopir.EditValueChanged
        txtKetSopir.Text = txtSopir.EditValue
    End Sub

    Private Sub txtKernet_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKernet.EditValueChanged
        txtKetKernet.Text = txtKernet.EditValue
    End Sub

    Private Sub txtNoTrans_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
