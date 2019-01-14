Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base

Public Class frmRcnRph
    Dim ds1, ds2, ds3 As New DataSet
    Dim da1, da2, da3, da4, da5, da6, da7 As New SqlDataAdapter
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
    Public btnCetak As Boolean = True
    Public State As String
    Dim state_hapus, rec_stat As String
    Dim myBuilder As New SqlCommandBuilder
    Dim notrans_simulasi1 As String
    Dim hari_realisasi, jam_realisasi As String

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btnCetak
        End With
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
        'reload()
        'ds1.Relations.Clear()
        'Dim colM(0) As DataColumn
        'Dim colD(0) As DataColumn
        'Dim colD1(2) As DataColumn
        'Dim colD2(2) As DataColumn
        'Dim rel, rel1 As DataRelation

        'colM(0) = ds1.Tables("PROD1").Columns("Jenis_Group")

        'colD(0) = ds1.Tables("SALES").Columns("Jenis_Group")

        'colD1(0) = ds1.Tables("SALES").Columns("no_sp")
        'colD1(1) = ds1.Tables("SALES").Columns("no_sp_dtl")
        'colD1(2) = ds1.Tables("SALES").Columns("no_seq")

        'colD2(0) = ds1.Tables("SOBOX").Columns("No_sp")
        'colD2(1) = ds1.Tables("SOBOX").Columns("No_seq_d")
        'colD2(2) = ds1.Tables("SOBOX").Columns("No_sp_box")

        'rel = ds1.Relations.Add("Detail", colM, colD, False)
        'rel1 = ds1.Relations.Add("Detail Busa", colD1, colD2, False)
        'gc.LevelTree.Nodes.Add("Detail", gv).Nodes.Add("Detail Busa", GV_Centi)
        'gc.DataSource = ds1.Tables("SALES")
        Hitung_Tanggal()
        
    End Sub
    Sub Hitung_Tanggal()
        Dim dr, dr1 As SqlDataReader
        Dim tglrph As Date
        If txtTgl_Rph.DateTime = Nothing Then
            txtTgl_Rph.DateTime = Now.Date
        Else


        End If

        'dr = New SqlClient.SqlCommand("select Val_kode1 from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='TGLRPH'", sqlconn).ExecuteReader
        dr = New SqlClient.SqlCommand("Select SALES.dbo.FN_CekDueDate('" & Format(txtTgl_Rph.DateTime, "yyyy/MM/dd") & "') as tgl_realisasi", sqlconn).ExecuteReader
        hari_realisasi = Format(txtTgl_Rph.EditValue, "yyyy/MM/dd")
        dr.Read()
        If dr.HasRows Then
            hari_realisasi = dr.Item("tgl_realisasi")
        End If
        dr.Close()

        dr = New SqlClient.SqlCommand("select Val_kode2 from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='TGLRPH'", sqlconn).ExecuteReader
        dr.Read()
        If dr.HasRows Then
            jam_realisasi = dr.Item("Val_kode2")
        End If
        dr.Close()

        txt_tglRealisasi.EditValue = hari_realisasi



        'txt_tglRealisasi.EditValue = DateAdd(DateInterval.Day, hari_realisasi, txtTgl_Rph.EditValue)
        'txt_tglRealisasi.Properties.MinValue = txtTgl_Rph.EditValue
    End Sub
    Private Sub reload()
        Dim dr, dr1 As SqlDataReader

        dr = New SqlClient.SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='KGTPPIC' and Id_Data='01'", sqlconn).ExecuteReader
        dr.Read()
        tipetrans = dr.Item("Val_kode1")
        dr.Close()

        If State = "ADD" Then
            If Not ds1.Tables("SOBOX") Is Nothing Then ds1.Tables("SOBOX").Clear()
            If Not ds1.Tables("SALES") Is Nothing Then ds1.Tables("SALES").Clear()
            If Not ds1.Tables("PROD") Is Nothing Then ds1.Tables("PROD").Clear()
            If Not ds1.Tables("PROD1") Is Nothing Then ds1.Tables("PROD1").Clear()


            da5 = New SqlDataAdapter(New SqlCommand("select *, '' Nama_Jenis_Group,'' Jenis_Group from PROD.dbo.PROD_rcn_prod_m where 1=0", sqlconn))
            da5.Fill(ds1, "PROD1")
            dr = New SqlClient.SqlCommand("select v.*, isnull(k.jumlah_kapasitas,0) jml_kapasitas from " & _
                                          "(select distinct Jenis_Group,Nama_Jenis_Group from PROD.dbo.PRODV_MON_SO where Len(no_sp) > 10 And qty_sisa_prod > 0" & _
                                          " and departement='" & kddep & "' " & _
                                          " or kd_merk in (select id_data from sif.dbo.SIF_Gen_Reff_d where ref_role = 'PROD' and id_ref_file = 'LINTASSPR') " & _
                                          " and tipe_trans not in (select val_kode1 from SIF.dbo.SIF_Gen_Reff_D where Ref_role = 'PROD' and Id_ref_file = 'TIPESRV') " & _
                                          " and (sts_centi = 'N' or sts_centi is null) " & _
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

            da3 = New SqlDataAdapter(New SqlCommand("select t.*,0.00 nilai, 0 kd_jenis, '' Nama_Customer, '' Nama_Wilayah, '' Nama_Area, '' Nama_Jenis, '' Nama_Barang,'' Jenis_Group,'' Nama_Jenis_Group,'' Sisa, cast('' as date) tgl_kirim, cast('' as date) tgl_kirim_ppic,'' prioritas, '' Nama_Satuan, '' Tipe_trans, '' Keterangan , '' keterangan_krm , cast('' As date) Tgl_SP, '' old_num from PROD.dbo.PROD_rcn_prod_d t where 1=0", sqlconn))
            da3.Fill(ds1, "SALES")
            dr = New SqlClient.SqlCommand("select v.*, ISNULL(i.nilai,0) nilai " & _
                                                               "from PROD.dbo.PRODV_MON_SO v " & _
                                                               "left join SIF.dbo.SIF_Barang b " & _
                                                               "on v.Kd_Stok = b.Kode_Barang " & _
                                                               "left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '01') i " & _
                                                               "on b.kd_jenis = i.kd_jenis and b.kd_tipe = i.kd_tipe and b.kd_ukuran = i.kd_ukuran " & _
                                                               "where(Len(v.no_sp) > 10  " & _
                                                               " and (v.Departement='" & kddep & "' " & _
                                                               " or v.kd_merk in (select id_data from sif.dbo.SIF_Gen_Reff_d where ref_role = 'PROD' and id_ref_file = 'LINTASSPR')) " & _
                                                               " and v.tipe_trans not in (select val_kode1 from SIF.dbo.SIF_Gen_Reff_D where Ref_role = 'PROD' and Id_ref_file = 'TIPESRV'))     " & _
                                                               " and (v.sts_centi = 'N' or v.sts_centi is null) and (v.isClosed is null  or v.isClosed = 'N' ) And v.qty_sisa_prod > 0 " & _
                                                               "order by v.No_sp, CASE WHEN v.no_seq_d like '%.B' THEN Convert( Int,REPLACE(v.No_seq_d,'.B',0))" & _
                                                               "else  Convert( Int,REPLACE(v.No_seq_d,'.',0)) END ", sqlconn).ExecuteReader

            '"order by v.No_sp, Convert(Int,v.No_seq_d) asc ", sqlconn).ExecuteReader
            While dr.Read
                Dim rw As DataRow = ds1.Tables("SALES").NewRow
                rw("Tipe_trans") = dr.Item("Tipe_trans")
                rw("Tgl_SP") = dr.Item("Tgl_sp")
                rw("no_sp") = dr.Item("No_sp")
                rw("old_num") = dr.Item("old_num")
                rw("no_sp_dtl") = dr.Item("No_seq_d")
                rw("no_seq") = dr.Item("No_sp_box")
                rw("no_urut_brg") = 1
                rw("nama_customer") = dr.Item("Nama_Customer")
                rw("nama_wilayah") = dr.Item("Nama_Wilayah")
                rw("nama_area") = dr.Item("Nama_Area")
                rw("Sisa") = CInt(dr.Item("Qty_Sisa_Prod"))
                'rw("Sisa") = dr.Item("Qty_Sisa_Prod")
                rw("kd_barang") = dr.Item("Kd_Stok")
                rw("Nama_Barang") = dr.Item("Nama_Barang")
                rw("Keterangan") = dr.Item("Keterangan")
                rw("keterangan_krm") = dr.Item("keterangan_krm")
                rw("panjang") = dr.Item("panjang")
                rw("lebar") = dr.Item("lebar")
                rw("tinggi") = dr.Item("tebal")
                rw("Nama_Jenis") = dr.Item("Nama_Jenis")
                rw("kd_jenis") = dr.Item("kd_jenis")
                rw("Jenis_Group") = dr.Item("Jenis_Group")
                rw("Nama_Jenis_Group") = dr.Item("Nama_Jenis_Group")
                'rw("tgl_kirim") = IIf(dr.Item("tgl_kirim_SO") Is DBNull.Value, dr.Item("Tgl_Kirim"), dr.Item("tgl_kirim_SO"))
                rw("tgl_kirim") = dr.Item("tgl_kirim_SO")
                rw("tgl_kirim_ppic") = dr.Item("Tgl_Kirim")
                rw("prioritas") = dr.Item("prioritas")
                rw("Nama_Satuan") = dr.Item("Nama_Satuan")
                rw("jumlah") = 0
                rw("jml_indeks") = 0
                rw("nilai") = dr.Item("nilai")
                rw("last_created_by") = dr.Item("last_created_by")
                ds1.Tables("SALES").Rows.Add(rw)
            End While
            dr.Close()
            txtTgl_Rph.Text = DateTime.Today
            txtDPB.Text = ""


            da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PRODV_MON_SO where panjang <> 0 and lebar <> 0 and tebal <> 0 and vol <> 0  ", sqlconn))
            da4.Fill(ds1, "SOBOX")

            Dim colM(0) As DataColumn
            Dim colD(0) As DataColumn
            Dim colD1(2) As DataColumn
            Dim colD2(2) As DataColumn
            Dim rel, rel1 As DataRelation
            ds1.Relations.Clear()
            colM(0) = ds1.Tables("PROD1").Columns("Jenis_Group")

            colD(0) = ds1.Tables("SALES").Columns("Jenis_Group")

            colD1(0) = ds1.Tables("SALES").Columns("no_sp")
            colD1(1) = ds1.Tables("SALES").Columns("no_sp_dtl")
            colD1(2) = ds1.Tables("SALES").Columns("no_seq")

            colD2(0) = ds1.Tables("SOBOX").Columns("No_sp")
            colD2(1) = ds1.Tables("SOBOX").Columns("No_seq_d")
            colD2(2) = ds1.Tables("SOBOX").Columns("No_sp_box")

            rel = ds1.Relations.Add("Detail", colM, colD, False)
            rel1 = ds1.Relations.Add("Detail Busa", colD1, colD2, False)
            gc.LevelTree.Nodes.Add("Detail", gv).Nodes.Add("Detail Busa", GV_Centi)
            gc.MainView = MainGV

            gc.DataSource = Nothing
            gc.DataSource = ds1.Tables("PROD1")
            'gc.DataSource = ds1.Tables("SALES")
        ElseIf State = "EDIT" Then
            If Not ds1.Tables("SOBOX") Is Nothing Then ds1.Tables("SOBOX").Clear()
            If Not ds1.Tables("SALES") Is Nothing Then ds1.Tables("SALES").Clear()
            If Not ds1.Tables("PROD") Is Nothing Then ds1.Tables("PROD").Clear()
            If Not ds1.Tables("PROD1") Is Nothing Then ds1.Tables("PROD1").Clear()


            da5 = New SqlDataAdapter(New SqlCommand("select *, '' Nama_Jenis_Group,'' Jenis_Group from PROD.dbo.PROD_rcn_prod_m where 1=0", sqlconn))
            da5.Fill(ds1, "PROD1")
            dr = New SqlClient.SqlCommand("select v.*, isnull(k.jumlah_kapasitas,0) jml_kapasitas from " & _
                                          "(select distinct Jenis_Group,Nama_Jenis_Group from PROD.dbo.PRODV_MON_SO where Len(no_sp) > 10 And qty_sisa_prod >= 0" & _
                                          " and departement='" & kddep & "' " & _
                                          " or kd_merk in (select id_data from sif.dbo.SIF_Gen_Reff_d where ref_role = 'PROD' and id_ref_file = 'LINTASSPR') " & _
                                          " and tipe_trans not in (select val_kode1 from SIF.dbo.SIF_Gen_Reff_D where Ref_role = 'PROD' and Id_ref_file = 'TIPESRV') " & _
                                          " and (sts_centi = 'N' or sts_centi is null) " & _
                                          ") v " & _
                                          "left join (select * from SIF.dbo.SIF_kapasitas where kegiatan_ppic='01') k " & _
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

            dr1 = New SqlClient.SqlCommand("select * from PROD.dbo.PROD_rcn_prod_m where no_rph = '" & txtDPB.Text & "' and rec_stat='R'", sqlconn).ExecuteReader
            dr1.Read()
            If dr1.HasRows Then
                state_hapus = "Y"
                rec_stat = "R"

                da3 = New SqlDataAdapter(New SqlCommand("select t.*,0.00 nilai, 0 kd_jenis, '' Nama_Customer, '' Nama_Wilayah, '' Nama_Area, '' Nama_Jenis, '' Nama_Barang,'' Jenis_Group,'' Nama_Jenis_Group,'' Sisa, cast('' as date) tgl_kirim, cast('' as date) tgl_kirim_ppic, '' prioritas, '' Nama_Satuan,'' Tipe_trans, '' Keterangan,'' keterangan_krm, cast('' as date) Tgl_SP, '' old_num  from PROD.dbo.PROD_rcn_prod_d t where 1=0", sqlconn))
                da3.Fill(ds1, "SALES")
                'Dim qstr As String = 
                Dim sqlcmd As New SqlCommand
                sqlcmd.CommandTimeout = 0
                sqlcmd.Connection = sqlconn
                ' sqlcmd.CommandType = CommandType.
                sqlcmd.CommandText = "select v.*, ISNULL(i.nilai,0) nilai, d.jumlah, d.jml_indeks " & _
                                     "from PROD.dbo.PROD_rcn_prod_d d " & _
                                     "left join PROD.dbo.PRODV_MON_SO v on v.No_sp=d.no_sp and v.no_seq_d = d.no_sp_dtl " & _
                                     "and v.No_sp_box = d.no_seq " & _
                                     "left join SIF.dbo.SIF_Barang b on d.kd_barang = b.Kode_Barang " & _
                                     "left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '02') i on b.kd_jenis = i.kd_jenis " & _
                                     "and b.kd_tipe = i.kd_tipe  and b.kd_ukuran = i.kd_ukuran " & _
                                     "where d.no_rph='" & txtDPB.Text & "' and (v.sts_centi = 'N' or v.sts_centi is null) " & _
                                     "order by v.No_sp, CASE WHEN v.no_seq_d like '%.B' THEN Convert( Int,REPLACE(v.No_seq_d,'.B',0))" & _
                                                               "else  Convert( Int,REPLACE(v.No_seq_d,'.',0)) END asc "
                dr = sqlcmd.ExecuteReader
                'dr = New SqlClient.SqlCommand("select v.*, ISNULL(i.nilai,0) nilai, d.jumlah, d.jml_indeks " & _
                '                     "from PROD.dbo.PROD_rcn_prod_d d " & _
                '                     "left join PROD.dbo.PRODV_MON_SO v on v.No_sp=d.no_sp and v.no_seq_d = d.no_sp_dtl " & _
                '                     "and v.No_sp_box = d.no_seq " & _
                '                     "left join SIF.dbo.SIF_Barang b on d.kd_barang = b.Kode_Barang " & _
                '                     "left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '02') i on b.kd_jenis = i.kd_jenis " & _
                '                     "and b.kd_tipe = i.kd_tipe  and b.kd_ukuran = i.kd_ukuran " & _
                '                     "where d.no_rph='" & txtDPB.Text & "' and (v.sts_centi = 'N' or v.sts_centi is null) " & _
                '                     "order by v.No_sp, CASE WHEN v.no_seq_d like '%.B' THEN Convert( Int,REPLACE(v.No_seq_d,'.B',0))" & _
                '                                               "else  Convert( Int,REPLACE(v.No_seq_d,'.',0)) END asc ", sqlconn).ExecuteReader
                '"order by v.No_sp, Convert(Int,v.No_seq_d) asc ", sqlconn).ExecuteReader

                While dr.Read
                    Dim rw As DataRow = ds1.Tables("SALES").NewRow
                    rw("Tipe_trans") = dr.Item("Tipe_trans")
                    rw("Tgl_SP") = dr.Item("Tgl_sp")
                    rw("no_sp") = dr.Item("No_sp")
                    rw("old_num") = dr.Item("old_num")
                    rw("no_sp_dtl") = dr.Item("No_seq_d")
                    rw("no_seq") = dr.Item("No_sp_box")
                    rw("no_urut_brg") = 1
                    rw("nama_customer") = dr.Item("Nama_Customer")
                    rw("nama_wilayah") = dr.Item("Nama_Wilayah")
                    rw("nama_area") = dr.Item("Nama_Area")
                    rw("Sisa") = CInt(dr.Item("Qty_Sisa_Prod")) + CInt(dr.Item("jumlah"))
                    rw("panjang") = dr.Item("panjang")
                    rw("lebar") = dr.Item("lebar")
                    rw("tinggi") = dr.Item("tebal")
                    rw("kd_barang") = dr.Item("Kd_Stok")
                    rw("Nama_Barang") = dr.Item("Nama_Barang")
                    rw("Keterangan") = dr.Item("Keterangan")
                    rw("keterangan_krm") = dr.Item("keterangan_krm")
                    rw("Nama_Jenis") = dr.Item("Nama_Jenis")
                    rw("kd_jenis") = dr.Item("kd_jenis")
                    rw("Jenis_Group") = dr.Item("Jenis_Group")
                    rw("Nama_Jenis_Group") = dr.Item("Nama_Jenis_Group")
                    'rw("tgl_kirim") = IIf(dr.Item("tgl_kirim_SO") Is DBNull.Value, dr.Item("Tgl_Kirim"), dr.Item("tgl_kirim_SO"))
                    rw("tgl_kirim") = dr.Item("tgl_kirim_SO")
                    rw("tgl_kirim_ppic") = dr.Item("Tgl_Kirim")
                    rw("prioritas") = dr.Item("prioritas")
                    rw("Nama_Satuan") = dr.Item("Nama_Satuan")
                    rw("jumlah") = CInt(dr.Item("jumlah"))
                    rw("jml_indeks") = dr.Item("jml_indeks")
                    rw("nilai") = dr.Item("nilai")
                    rw("last_created_by") = dr.Item("last_created_by")
                    ds1.Tables("SALES").Rows.Add(rw)
                    gv.OptionsBehavior.Editable = False
                End While
                dr.Close()
            Else
                state_hapus = "T"
                rec_stat = vbNullString
                da3 = New SqlDataAdapter(New SqlCommand("select t.*,0.00 nilai, 0 kd_jenis, '' Nama_Customer, '' Nama_Wilayah, '' Nama_Area, '' Nama_Jenis, '' Nama_Barang,'' Jenis_Group,'' Nama_Jenis_Group,'' Sisa, '' tgl_kirim,'' tgl_kirim_ppic,'' prioritas, '' Nama_Satuan, '' Tipe_trans, '' Keterangan,'' keterangan_krm, '' Tgl_SP, '' old_num  from PROD.dbo.PROD_rcn_prod_d t where 1=0", sqlconn))
                da3.Fill(ds1, "SALES")
                'Dim qstr As String = "select uni.*,ISNULL(i.nilai,0) nilai from ( " & _
                '"Select Subquery1.* From (select v.*,'' no_rph, 0 jumlah, 0 jml_indeks " & _
                '"from PROD.dbo.PRODV_MON_SO v " & _
                '"left join PROD.dbo.PROD_rcn_prod_d d on v.no_sp = d.no_sp and " & _
                '"v.no_seq_d = d.no_sp_dtl And v.No_sp_box = d.no_seq " & _
                '"LEFT OUTER JOIN (Select Distinct a.no_rph, a.no_sp, a.no_sp_dtl,a.no_seq From PROD.dbo.PROD_rcn_prod_d a " & _
                '"INNER Join " & _
                '"(Select no_sp,no_sp_dtl,no_seq from PROD.dbo.PROD_rcn_prod_d " & _
                '"where no_rph ='" & txtDPB.Text & "') d2 " & _
                '"on a.no_sp = d2.no_sp and a.no_sp_dtl = d2.no_sp_dtl and a.no_seq = d2.no_seq) b " & _
                '"on d.no_rph = b.no_rph and d.no_sp=b.no_sp and d.no_sp_dtl = b.no_sp_dtl and d.no_seq = b.no_seq " & _
                '"where(Len(v.no_sp) > 10 And v.qty_sisa_prod > 0 And (v.vol = 0 Or v.vol Is null)) " & _
                '"and V.departement='" & kddep & "' and  d.no_rph <> '" & txtDPB.Text & "' " & _
                '"OR  Len(v.no_sp) > 10 And v.qty_sisa_prod > 0 And (v.vol = 0 Or v.vol Is null) " & _
                '"and V.departement='" & kddep & "' " & _
                '"and tipe_trans not in (select val_kode1 from SIF.dbo.SIF_Gen_Reff_D where Ref_role = 'PROD' and Id_ref_file = 'TIPESRV') " & _
                '"and  d.no_rph is Null and (v.sts_centi = 'N' or v.sts_centi is null)) Subquery1 " & _
                '"LEFT OUTER JOIN " & _
                '"(select v.*,d.no_rph, d.jumlah, d.jml_indeks " & _
                '"from PROD.dbo.PROD_rcn_prod_d d " & _
                '"left join PROD.dbo.PRODV_MON_SO v on v.No_sp=d.no_sp and " & _
                '"v.no_seq_d = d.no_sp_dtl And v.No_sp_box = d.no_seq " & _
                '"where d.no_rph='" & txtDPB.Text & "' and (v.sts_centi = 'N' or v.sts_centi is null) ) Subquery2 " & _
                '"on Subquery1.no_sp = Subquery2.no_sp and  Subquery1.no_seq_d = Subquery2.no_seq_d " & _
                '"and Subquery1.No_sp_box = Subquery2.No_sp_box " & _
                '"where(Subquery2.no_rph Is Null) " & _
                '"UNION " & _
                '"select v.*,d.no_rph, d.jumlah, d.jml_indeks " & _
                '"from PROD.dbo.PROD_rcn_prod_d d " & _
                '"left join PROD.dbo.PRODV_MON_SO v on v.No_sp=d.no_sp and " & _
                '"v.no_seq_d = d.no_sp_dtl And v.No_sp_box = d.no_seq " & _
                '"where d.no_rph='" & txtDPB.Text & "' and (v.sts_centi = 'N' or v.sts_centi is null)) uni  " & _
                '"left join SIF.dbo.SIF_Barang b on uni.Kd_Stok = b.Kode_Barang " & _
                '"left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '01') i " & _
                '"on b.kd_jenis = i.kd_jenis " & _
                '"and b.kd_tipe = i.kd_tipe and b.kd_ukuran = i.kd_ukuran " & _
                '"order by uni.no_sp, uni.no_seq_d , uni.No_sp_box"

                Dim qstr As String = "select uni.*,ISNULL(i.nilai,0) nilai from ( " & _
                "Select Subquery1.* From (select v.*,'' no_rph, 0 jumlah, 0 jml_indeks " & _
                "from PROD.dbo.PRODV_MON_SO v " & _
                "left join PROD.dbo.PROD_rcn_prod_d d on v.no_sp = d.no_sp and " & _
                "v.no_seq_d = d.no_sp_dtl And v.No_sp_box = d.no_seq " & _
                "LEFT OUTER JOIN (Select Distinct a.no_rph, a.no_sp, a.no_sp_dtl,a.no_seq " & _
                "From PROD.dbo.PROD_rcn_prod_d a  " & _
                "INNER Join " & _
                "(Select no_sp,no_sp_dtl,no_seq from PROD.dbo.PROD_rcn_prod_d " & _
                "where no_rph ='" & txtDPB.Text & "') d2 " & _
                "on a.no_sp = d2.no_sp and a.no_sp_dtl = d2.no_sp_dtl and a.no_seq = d2.no_seq) b " & _
                "on d.no_rph = b.no_rph and d.no_sp=b.no_sp and d.no_sp_dtl = b.no_sp_dtl " & _
                "and d.no_seq = b.no_seq " & _
                "where(Len(v.no_sp) > 10 And v.qty_sisa_prod > 0 And (v.vol = 0 Or v.vol Is null) " & _
                "and V.departement='" & kddep & "' and tipe_trans not in (select val_kode1 from SIF.dbo.SIF_Gen_Reff_D where Ref_role = 'PROD' " & _
                "and Id_ref_file = 'TIPESRV') " & _
                "or v.kd_merk in (select id_data from sif.dbo.SIF_Gen_Reff_d where ref_role = 'PROD' and id_ref_file = 'LINTASSPR') " & _
                "and  d.no_rph <> '" & txtDPB.Text & "' and (v.sts_centi = 'N' or v.sts_centi is null) " & _
                "and (v.isClosed is null  or v.isClosed = 'N' )) " & _
                "OR  (Len(v.no_sp) > 10 And v.qty_sisa_prod > 0 And (v.vol = 0 Or v.vol Is null) " & _
                "and V.departement='" & kddep & "' " & _
                "or v.kd_merk in (select id_data from sif.dbo.SIF_Gen_Reff_d where ref_role = 'PROD' and id_ref_file = 'LINTASSPR') " & _
                "and tipe_trans not in (select val_kode1 from SIF.dbo.SIF_Gen_Reff_D where Ref_role = 'PROD' " & _
                "and Id_ref_file = 'TIPESRV') " & _
                "and  d.no_rph is Null and (v.sts_centi = 'N' or v.sts_centi is null) " & _
                "and (v.isClosed is null  or v.isClosed = 'N' ))) Subquery1 " & _
                "LEFT OUTER JOIN " & _
                "(select v.*,d.no_rph, d.jumlah, d.jml_indeks " & _
                "from PROD.dbo.PROD_rcn_prod_d d " & _
                "left join PROD.dbo.PRODV_MON_SO v on v.No_sp=d.no_sp and " & _
                "v.no_seq_d = d.no_sp_dtl And v.No_sp_box = d.no_seq " & _
                "where d.no_rph='" & txtDPB.Text & "' and (v.sts_centi = 'N' or v.sts_centi is null) " & _
                "and (v.isClosed is null  or v.isClosed = 'N' )) Subquery2 " & _
                "on Subquery1.no_sp = Subquery2.no_sp and  Subquery1.no_seq_d = Subquery2.no_seq_d " & _
                "and Subquery1.No_sp_box = Subquery2.No_sp_box " & _
                "where(Subquery2.no_rph Is Null) " & _
                "UNION " & _
                "select v.*,d.no_rph, d.jumlah, d.jml_indeks " & _
                "from PROD.dbo.PROD_rcn_prod_d d " & _
                "left join PROD.dbo.PRODV_MON_SO v on v.No_sp=d.no_sp and " & _
                "v.no_seq_d = d.no_sp_dtl And v.No_sp_box = d.no_seq " & _
                "where d.no_rph='" & txtDPB.Text & "' and (v.sts_centi = 'N' or v.sts_centi is null)) uni " & _
                "left join SIF.dbo.SIF_Barang b on uni.Kd_Stok = b.Kode_Barang " & _
                "left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '01') i " & _
                "on b.kd_jenis = i.kd_jenis " & _
                "and b.kd_tipe = i.kd_tipe and b.kd_ukuran = i.kd_ukuran " & _
                "order by uni.no_sp, CASE WHEN uni.no_seq_d like '%.B' THEN Convert( Int,REPLACE(uni.no_seq_d,'.B',0)) " & _
                "else  Convert( Int,REPLACE(uni.no_seq_d,'.',0)) END   , CASE WHEN uni.No_sp_box like '%.B' THEN Convert( Int,REPLACE(uni.No_sp_box,'.B',0)) " & _
                "else Convert(Int,REPLACE(uni.No_sp_box,'.',0)) END  asc "

                '"order by uni.no_sp, Convert(int,uni.no_seq_d) , Convert(int,uni.No_sp_box) asc "
                Dim sqlCmd1 As New SqlCommand
                sqlCmd1.CommandTimeout = 0
                sqlCmd1.Connection = sqlconn
                'sqlCmd1.CommandType = CommandType.StoredProcedure
                sqlCmd1.CommandText = qstr
                dr = sqlCmd1.ExecuteReader
                'showMessages("LOADING..")
                ' dr = New SqlClient.SqlCommand(qstr, sqlconn).ExecuteReader

                While dr.Read
                    Dim rw As DataRow = ds1.Tables("SALES").NewRow
                    rw("Tipe_trans") = dr.Item("Tipe_trans")
                    rw("Tgl_SP") = dr.Item("Tgl_sp")
                    rw("no_sp") = dr.Item("No_sp")
                    rw("old_num") = dr.Item("old_num")
                    rw("no_sp_dtl") = dr.Item("No_seq_d")
                    rw("no_seq") = dr.Item("No_sp_box")
                    rw("no_urut_brg") = 1
                    rw("nama_customer") = IIf(dr.Item("Nama_Customer") Is DBNull.Value, "", dr.Item("Nama_Customer"))
                    rw("nama_wilayah") = IIf(dr.Item("Nama_Wilayah") Is DBNull.Value, "", dr.Item("Nama_Wilayah"))
                    rw("nama_area") = IIf(dr.Item("Nama_Area") Is DBNull.Value, "", dr.Item("Nama_Area"))
                    rw("Sisa") = CInt(IIf(TypeOf dr.Item("Qty_Sisa_Prod") Is DBNull, 0, dr.Item("Qty_Sisa_Prod"))) + CInt(IIf(TypeOf dr.Item("jumlah") Is DBNull, 0, dr.Item("jumlah")))
                    rw("lebar") = dr.Item("lebar")
                    rw("tinggi") = dr.Item("tebal")
                    rw("kd_barang") = dr.Item("Kd_Stok")
                    rw("Nama_Barang") = dr.Item("Nama_Barang")
                    rw("Keterangan") = dr.Item("Keterangan")
                    rw("keterangan_krm") = dr.Item("keterangan_krm")
                    rw("Nama_Jenis") = dr.Item("Nama_Jenis")
                    rw("kd_jenis") = dr.Item("kd_jenis")
                    rw("Jenis_Group") = dr.Item("Jenis_Group")
                    rw("Nama_Jenis_Group") = dr.Item("Nama_Jenis_Group")
                    'rw("tgl_kirim") = IIf(dr.Item("tgl_kirim_SO") Is DBNull.Value, dr.Item("Tgl_Kirim"), dr.Item("tgl_kirim_SO"))
                    rw("tgl_kirim") = dr.Item("tgl_kirim_SO")
                    rw("tgl_kirim_ppic") = dr.Item("Tgl_Kirim")
                    rw("prioritas") = dr.Item("prioritas")
                    rw("Nama_Satuan") = dr.Item("Nama_Satuan")
                    rw("jumlah") = CInt(dr.Item("jumlah"))
                    rw("jml_indeks") = dr.Item("jml_indeks")
                    rw("nilai") = dr.Item("nilai")
                    rw("last_created_by") = dr.Item("last_created_by")
                    ds1.Tables("SALES").Rows.Add(rw)
                End While
                dr.Close()
            End If
            dr1.Close()

            txtTgl_Rph.Properties.ReadOnly = False
            txtJadwal.Properties.ReadOnly = False

            da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PRODV_MON_SO where panjang <> 0 and lebar <> 0 and tebal <> 0 and vol <> 0 ", sqlconn))
            da4.Fill(ds1, "SOBOX")

            Dim colM(0) As DataColumn
            Dim colD(0) As DataColumn
            Dim colD1(2) As DataColumn
            Dim colD2(2) As DataColumn
            Dim rel, rel1 As DataRelation
            ds1.Relations.Clear()
            colM(0) = ds1.Tables("PROD1").Columns("Jenis_Group")

            colD(0) = ds1.Tables("SALES").Columns("Jenis_Group")

            colD1(0) = ds1.Tables("SALES").Columns("no_sp")
            colD1(1) = ds1.Tables("SALES").Columns("no_sp_dtl")
            colD1(2) = ds1.Tables("SALES").Columns("no_seq")

            colD2(0) = ds1.Tables("SOBOX").Columns("No_sp")
            colD2(1) = ds1.Tables("SOBOX").Columns("No_seq_d")
            colD2(2) = ds1.Tables("SOBOX").Columns("No_sp_box")

            rel = ds1.Relations.Add("Detail", colM, colD, False)
            rel1 = ds1.Relations.Add("Detail Busa", colD1, colD2, False)
            gc.LevelTree.Nodes.Add("Detail", gv).Nodes.Add("Detail Busa", GV_Centi)
            gc.MainView = MainGV

            gc.DataSource = Nothing
            gc.DataSource = ds1.Tables("PROD1")
        End If
    End Sub

    Public Sub add_click()
        State = "ADD"
        reload()
        btnSave = True
        btnCetak = True
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
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select M.tanggal [Tanggal], M.no_rph [No RPH], S.Desc_Data [Jadwal Kerja]  from (select distinct no_rph from PROD.dbo.PROD_rcn_prod_d where vol=0 or vol is null and bom_service is null) D  " & _
                                                                    "left join PROD.dbo.PROD_rcn_prod_m M on M.no_rph=D.no_rph  " & _
                                                                    "left join SIF.dbo.SIF_Gen_Reff_D S on M.kd_jadwal=S.Id_Data  " & _
                                                                    "where S.Id_Ref_Data='JDWKRJ' and M.no_rph_asal IS Null and M.kd_departemen ='" & kddep & "' and (M.sts_centi = 'N' or M.sts_centi is null) ORDER by m.no_rph DESC", sqlconn))

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
            btnCetak = True
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
        connect()
        hapus_data_temp()
        Dim dr, dr1 As SqlDataReader

        ' simpan_simulasi()

        '--- Untuk mengecek ketersediaan bahan baku --------
        'dr1 = New SqlClient.SqlCommand("select COUNT(isnull(d.jumlah_stok,0)-isnull(d.jumlah,0))  from PROD.dbo.PROD_simul_bhn_d_temp d " & _
        '                               "where no_trans = '" & notrans_simulasi1 & "' and isnull(d.jumlah_stok,0)-isnull(d.jumlah,0)  <= 0", sqlconn).ExecuteReader
        'dr1.Read()
        'If dr1.HasRows Then
        '    If dr1.Item(0) > 0 Then
        '        MsgBox("Bahan baku tidak mencukupi, RPH tidak bisa diproses")
        '        dr1.Close()
        '        frmDtlSO2.notrans_simulasi = notrans_simulasi1
        '        frmDtlSO2.ShowDialog()
        '        Exit Sub
        '    End If
        'End If
        'dr1.Close()

        '-----------------------------------------------------------------------------------



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

            Dim notrans As String
            notrans = getNoTrans("PRODRPH", txtTgl_Rph.DateTime, BTRANS)
            txtDPB.Text = notrans

            For i = ds1.Tables("SALES").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = ds1.Tables("SALES").Rows(i)
                If Not TypeOf rows("jumlah") Is DBNull Then
                    If rows("jumlah") > 0 Then
                        rows("tanggal") = txtTgl_Rph.DateTime
                        rows("no_rph") = notrans
                        rows("last_create_date") = tgl
                        rows("last_created_by") = username
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
            'mrow("tanggal_realisasi") = txt_tglRealisasi.EditValue
            mrow("tanggal_realisasi") = txt_tglRealisasi.EditValue & " " & jam_realisasi
            mrow("kd_jadwal") = txtJadwal.EditValue
            mrow("kd_cabang") = kdcabang
            mrow("kd_departemen") = kddep
            mrow("last_create_date") = tgl
            mrow("last_created_by") = username
            mrow("last_update_date") = tgl
            mrow("last_updated_by") = username
            mrow("program_name") = Me.Name
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
                btnCetak = True
                setStatus()
                showMessages("Data Berhasil Disimpan")
            Catch e As Exception
                BTRANS.Rollback()
                ds1.Tables("SALES").RejectChanges()
                ds1.Tables("PROD").RejectChanges()
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

            Dim notrans As String
            notrans = txtDPB.Text

            Dim qstr As String
            qstr = "delete from PROD.dbo.PROD_rcn_prod_d where no_rph='" & notrans & "'"
            dr = New SqlClient.SqlCommand(qstr, sqlconn, BTRANS).ExecuteReader
            dr.Close()
            qstr = "delete from PROD.dbo.PROD_rcn_prod_m where no_rph='" & notrans & "'"
            dr = New SqlClient.SqlCommand(qstr, sqlconn, BTRANS).ExecuteReader
            dr.Close()

            For i = ds1.Tables("SALES").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = ds1.Tables("SALES").Rows(i)
                If Not TypeOf rows("jumlah") Is DBNull Then
                    If rows("jumlah") > 0 Then
                        rows("tanggal") = txtTgl_Rph.DateTime
                        rows("no_rph") = txtDPB.Text
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
            mrow("no_rph") = txtDPB.Text
            mrow("tanggal") = txtTgl_Rph.DateTime
            'mrow("tanggal_realisasi") = txt_tglRealisasi.EditValue
            mrow("tanggal_realisasi") = txt_tglRealisasi.EditValue & " " & jam_realisasi
            mrow("kd_jadwal") = txtJadwal.EditValue
            mrow("kd_cabang") = kdcabang
            mrow("kd_departemen") = kddep
            mrow("last_create_date") = tgl
            mrow("last_created_by") = username
            mrow("last_update_date") = tgl
            mrow("last_updated_by") = username
            mrow("program_name") = Me.Name
            mrow("jns_produksi") = "PRODUKSI"
            mrow("rec_stat") = rec_stat
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
                btnCetak = True
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
    Private Function proses(ByVal vnotrans As String) As String
        Dim tgl As Date = getTanggal()
        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = sqlconn
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.CommandText = "PROD.dbo.prodp_hapus_rph"
        sqlcmd.Parameters.Add("@vno_rph", SqlDbType.VarChar, 50).Value = txtDPB.Text
        sqlcmd.Parameters.Add("@vmessage", SqlDbType.VarChar, 200)
        sqlcmd.Parameters("@vmessage").Direction = ParameterDirection.Output
        sqlcmd.ExecuteNonQuery()
        Return sqlcmd.Parameters("@vmessage").Value.ToString
    End Function
    
    Public Sub delete_click()
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            showMessages(proses(txtDPB.Text))
        End If
    End Sub

    Public Sub cancel_click()
        hapus_data_temp()
        btnCetak = True
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True

        setStatus()
        txtTgl_Rph.Text = DateTime.Today
        txtDPB.Text = ""
        gv.OptionsBehavior.Editable = True
        txtTgl_Rph.Properties.ReadOnly = False
        txtJadwal.Properties.ReadOnly = False
        Me.Enabled = False
    End Sub
    Public Sub cetak_click()
        'If Trim(txtNoDPB.Text) <> "" And State = "EDIT" Then
        'callReport(App_Path() & "\report\rptPOM.rpt", "", "Nomor=" & Trim(txtNoPO.Text))

        'Dim notrans As String = Trim(txtNoDPB.Text)
        callReport(App_Path() & "\report\ProdPlanRph.rpt", "", "&vno_rph=" & txtDPB.Text, False, False)
        'Else
        'MessageBox.Show("Pilih data yang akan dicetak dalam mode EDIT!")
        'End If
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
            Dim dr As SqlDataReader = New SqlClient.SqlCommand("select * from PROD.dbo.PRODV_MON_SO where no_sp='" & nosp.GetFocusedRowCellValue("no_sp") & "' and no_seq_d='" & nospseq.GetFocusedRowCellValue("no_sp_dtl") & "' order by No_sp, No_seq_d", sqlconn).ExecuteReader
            dr.Read()
            frmDtlSO.nosp.Text = dr.Item("no_sp").ToString
            frmDtlSO.noseq.Text = dr.Item("no_seq_d").ToString
            frmDtlSO.no_seq_d.Text = dr.Item("No_sp_box").ToString
            frmDtlSO.cust.Text = dr.Item("Nama_Customer").ToString
            frmDtlSO.barang.Text = dr.Item("Nama_Barang").ToString
            frmDtlSO.Qty_Order.Text = dr.Item("Qty_Order").ToString
            frmDtlSO.Qty_Rcn_Krm.Text = dr.Item("Qty_Rcn_Krm").ToString
            frmDtlSO.Qty_Rcn_Prod.Text = dr.Item("Qty_Rcn_Prod").ToString
            frmDtlSO.Qty_Sisa_Krm.Text = dr.Item("Qty_Sisa_Krm").ToString
            frmDtlSO.Qty_Sisa_Prod.Text = dr.Item("Qty_Sisa_Prod").ToString
            frmDtlSO.tanggal.Text = dr.Item("tgl_kirim").ToString
            frmDtlSO.prioritas.Text = dr.Item("prioritas").ToString
            frmDtlSO.ShowDialog()
            dr.Close()
        End If
    End Sub
    Sub simpan_simulasi()
        Dim dr As SqlDataReader
        If Not ds1.Tables("Barang") Is Nothing Then ds1.Tables("Barang").Clear()
        da6 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_simul_bhn_m_temp_mstr where 1=0  ", sqlconn))
        da6.Fill(ds1, "Barang")

        Dim BTRANS As SqlTransaction
        mb1 = New SqlClient.SqlCommandBuilder(da6)
        da6.UpdateCommand = mb1.GetUpdateCommand()
        da6.InsertCommand = mb1.GetInsertCommand()
        da6.DeleteCommand = mb1.GetDeleteCommand()

        BTRANS = sqlconn.BeginTransaction("1")
        da6.UpdateCommand.Transaction = BTRANS
        da6.InsertCommand.Transaction = BTRANS
        da6.DeleteCommand.Transaction = BTRANS
        Dim notrans_simulasi As String
        notrans_simulasi = getNoTrans("SMLBHNTEM", txtTgl_Rph.DateTime, BTRANS)
        notrans_simulasi1 = notrans_simulasi

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
                    rw("Tipe_trans") = rows("Tipe_trans")
                    ds1.Tables("Barang").Rows.Add(rw)

                Else

                End If
            Else

            End If
        Next


        da6.Update(ds1.Tables("Barang"))
        ds1.Tables("Barang").AcceptChanges()



        BTRANS.Commit()


        If Not ds1.Tables("Barang_d") Is Nothing Then ds1.Tables("Barang_d").Clear()
        da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_simul_bhn_m_temp where 1=0 ", sqlconn))
        da7.Fill(ds1, "Barang_d")

        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        'dr = New SqlClient.SqlCommand("SELECT PROD_simul_bhn_m_temp.kd_cabang, " & _
        '                                                            "PROD_simul_bhn_m_temp.kd_departemen,sum(PROD_simul_bhn_m_temp.jumlah)as jumlah, " & _
        '                                                            "PROD_simul_bhn_m_temp.no_trans, " & _
        '                                                            "PROD_simul_bhn_m_temp.kd_brg AS kd_barang " & _
        '                                                            "FROM PROD.dbo.PROD_simul_bhn_m_temp_mstr PROD_simul_bhn_m_temp " & _
        '                                                            "WHERE PROD_simul_bhn_m_temp.no_trans = '" & notrans_simulasi & "' " & _
        '                                                            "GROUP BY   PROD_simul_bhn_m_temp.kd_cabang, " & _
        '                                                            "PROD_simul_bhn_m_temp.kd_departemen, " & _
        '                                                            "PROD_simul_bhn_m_temp.kd_brg, " & _
        '                                                            "PROD_simul_bhn_m_temp.no_trans", sqlconn).ExecuteReader

        dr = New SqlClient.SqlCommand("SELECT PROD_simul_bhn_m_temp.Tipe_trans, PROD_simul_bhn_m_temp.kd_cabang, " & _
                                                                    "PROD_simul_bhn_m_temp.kd_departemen,sum(PROD_simul_bhn_m_temp.jumlah)as jumlah, " & _
                                                                    "PROD_simul_bhn_m_temp.no_trans, " & _
                                                                    "PROD_simul_bhn_m_temp.kd_brg AS kd_barang " & _
                                                                    "FROM PROD.dbo.PROD_simul_bhn_m_temp_mstr PROD_simul_bhn_m_temp " & _
                                                                    "WHERE PROD_simul_bhn_m_temp.no_trans = '" & notrans_simulasi & "' " & _
                                                                    "GROUP BY   PROD_simul_bhn_m_temp.Tipe_trans, PROD_simul_bhn_m_temp.kd_cabang, " & _
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
            rw("Tipe_trans") = dr.Item("Tipe_trans")
            rw("program_name") = Me.Name
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
        sqlCmd.CommandText = "PROD.dbo.prodp_ins_simul_bahan_temp2"
        sqlCmd.Parameters.Add("@vno_trans", SqlDbType.Char).Value = notrans_simulasi
        dr = sqlCmd.ExecuteReader
        dr.Close()
        'showMessages("Processing.....")
        'frmDtlSO2.notrans_simulasi = notrans_simulasi
        'frmDtlSO2.ShowDialog()
    End Sub

    Sub hapus_data_temp()
        Dim qstr As String
        Dim dr As SqlDataReader
        qstr = "delete from Prod.dbo.PROD_simul_bhn_m_temp_mstr "
        dr = New SqlClient.SqlCommand(qstr, sqlconn).ExecuteReader
        dr.Close()

        qstr = "delete from Prod.dbo.PROD_simul_bhn_m_temp "
        dr = New SqlClient.SqlCommand(qstr, sqlconn).ExecuteReader
        dr.Close()

        qstr = "delete from Prod.dbo.PROD_simul_bhn_d_temp "
        dr = New SqlClient.SqlCommand(qstr, sqlconn).ExecuteReader
        dr.Close()

    End Sub
    Private Sub btn_gen_simulBahan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_gen_simulBahan.Click
        Dim dr As SqlDataReader
        If Not ds1.Tables("Barang") Is Nothing Then ds1.Tables("Barang").Clear()
        da6 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_simul_bhn_m_temp_mstr where 1=0  ", sqlconn))
        da6.Fill(ds1, "Barang")

        Dim BTRANS As SqlTransaction
        mb1 = New SqlClient.SqlCommandBuilder(da6)
        da6.UpdateCommand = mb1.GetUpdateCommand()
        da6.InsertCommand = mb1.GetInsertCommand()
        da6.DeleteCommand = mb1.GetDeleteCommand()

        BTRANS = sqlconn.BeginTransaction("1")
        da6.UpdateCommand.Transaction = BTRANS
        da6.InsertCommand.Transaction = BTRANS
        da6.DeleteCommand.Transaction = BTRANS
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
                    rw("Tipe_trans") = rows("Tipe_trans")
                    ds1.Tables("Barang").Rows.Add(rw)

                Else

                End If
            Else

            End If
        Next


        da6.Update(ds1.Tables("Barang"))
        ds1.Tables("Barang").AcceptChanges()



        BTRANS.Commit()


        If Not ds1.Tables("Barang_d") Is Nothing Then ds1.Tables("Barang_d").Clear()
        da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_simul_bhn_m_temp where 1=0 ", sqlconn))
        da7.Fill(ds1, "Barang_d")

        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        dr = New SqlClient.SqlCommand("SELECT PROD_simul_bhn_m_temp.Tipe_trans, PROD_simul_bhn_m_temp.kd_cabang, " & _
                                                                    "PROD_simul_bhn_m_temp.kd_departemen,sum(PROD_simul_bhn_m_temp.jumlah)as jumlah, " & _
                                                                    "PROD_simul_bhn_m_temp.no_trans, " & _
                                                                    "PROD_simul_bhn_m_temp.kd_brg AS kd_barang " & _
                                                                    "FROM PROD.dbo.PROD_simul_bhn_m_temp_mstr PROD_simul_bhn_m_temp " & _
                                                                    "WHERE PROD_simul_bhn_m_temp.no_trans = '" & notrans_simulasi & "' " & _
                                                                    "GROUP BY   PROD_simul_bhn_m_temp.Tipe_trans, PROD_simul_bhn_m_temp.kd_cabang, " & _
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
            rw("Tipe_trans") = dr.Item("Tipe_trans")
            rw("program_name") = Me.Name
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
        sqlCmd.CommandText = "PROD.dbo.prodp_ins_simul_bahan_temp2"
        sqlCmd.Parameters.Add("@vno_trans", SqlDbType.Char).Value = notrans_simulasi
        dr = sqlCmd.ExecuteReader
        dr.Close()
        showMessages("Processing.....")
        frmDtlSO2.notrans_simulasi = notrans_simulasi
        frmDtlSO2.ShowDialog()



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim colM(0) As DataColumn
        Dim colD(0) As DataColumn
        Dim colD1(2) As DataColumn
        Dim colD2(2) As DataColumn
        Dim rel, rel1 As DataRelation
        ds1.Relations.Clear()

        'colM(0) = ds1.Tables("PROD1").Columns("Jenis_Group")

        'colD(0) = ds1.Tables("SALES").Columns("Jenis_Group")

        colD1(0) = ds1.Tables("SALES").Columns("no_sp")
        colD1(1) = ds1.Tables("SALES").Columns("no_sp_dtl")
        colD1(2) = ds1.Tables("SALES").Columns("no_seq")

        colD2(0) = ds1.Tables("SOBOX").Columns("No_sp")
        colD2(1) = ds1.Tables("SOBOX").Columns("No_seq_d")
        colD2(2) = ds1.Tables("SOBOX").Columns("No_sp_box")

        ' rel = ds1.Relations.Add("Detail", colM, colD, False)
        rel1 = ds1.Relations.Add("Detail Busa", colD1, colD2, False)
        gc.MainView = gv
        gc.LevelTree.Nodes.Clear()
        gc.LevelTree.Nodes.Add("Detail Busa", GV_Centi)

        gc.DataSource = Nothing
        'gc.DataSource = ds1.Tables("PROD1")
        gc.DataSource = ds1.Tables("SALES")


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim colM(0) As DataColumn
        Dim colD(0) As DataColumn
        Dim colD1(2) As DataColumn
        Dim colD2(2) As DataColumn
        Dim rel, rel1 As DataRelation
        ds1.Relations.Clear()
        colM(0) = ds1.Tables("PROD1").Columns("Jenis_Group")

        colD(0) = ds1.Tables("SALES").Columns("Jenis_Group")

        colD1(0) = ds1.Tables("SALES").Columns("no_sp")
        colD1(1) = ds1.Tables("SALES").Columns("no_sp_dtl")
        colD1(2) = ds1.Tables("SALES").Columns("no_seq")

        colD2(0) = ds1.Tables("SOBOX").Columns("No_sp")
        colD2(1) = ds1.Tables("SOBOX").Columns("No_seq_d")
        colD2(2) = ds1.Tables("SOBOX").Columns("No_sp_box")

        rel = ds1.Relations.Add("Detail", colM, colD, False)
        rel1 = ds1.Relations.Add("Detail Busa", colD1, colD2, False)
        gc.LevelTree.Nodes.Add("Detail", gv).Nodes.Add("Detail Busa", GV_Centi)
        gc.MainView = MainGV

        gc.DataSource = Nothing
        gc.DataSource = ds1.Tables("PROD1")
        'gc.DataSource = ds1.Tables("SALES")
    End Sub


    Private Sub txtTgl_Rph_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTgl_Rph.EditValueChanged
        Hitung_Tanggal()
    End Sub
End Class