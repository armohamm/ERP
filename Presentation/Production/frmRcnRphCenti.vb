Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base


Public Class frmRcnRphCenti
    Dim ds1, ds2, ds3, ds4, ds5, ds6, ds7, ds8, dsbaru As New DataSet
    Dim da1, da2, da3, da4, da5, da6, da7, da8, da9, da10, da11, da12, da13, da14, dabaru, dabaru1 As New SqlDataAdapter
    Dim row, mrow As DataRow
    Dim mb, mb1, mb2 As New SqlCommandBuilder
    Dim BTRANS As SqlTransaction
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA As SqlDataAdapter
    Dim DAD As SqlDataAdapter
    Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode
    Dim obj As Object
    Dim prn As frmMain
    Dim jumlah As Integer
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Dim Lebar3, Lebar2, Lebar1 As Double
    Dim Lebar5, Lebar4, Lebar6 As Double
    Public State As String
    Dim B, C, D, A, F, G, H, O, F1, G1 As Integer
    Dim statusq, coba As String
    Dim itung As Integer = 0
    Dim tambah As Integer = 0
    Dim x1, x2, x3, x4, i, x5, x6, x7, x8, x9, x10, x14, i2, i3, x15 As Double
    Dim x11, x12, x13 As String
    Dim tot, view1, lebarq, jumlah_sisa, jumlah_blok As Double
    Dim no_urut_b, no_urut_b_temp, no_urut_d, no_urut_d_temp As Integer
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
    Private Sub frmRcnRph_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        A = 100
        If Not ds1.Tables("JDWKRJ") Is Nothing Then ds1.Tables("JDWKRJ").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='JDWKRJ'", sqlconn))
        da1.Fill(ds1, "JDWKRJ")
        txtJadwal.Properties.DataSource = ds1.Tables("JDWKRJ")

        'btnEdit = False
        'btnDelete = False
        setStatus()
        State = "ADD"
        If State = "ADD" Then
            reload()
            If Not ds7.Tables("detilq12345") Is Nothing Then ds7.Tables("detilq12345").Clear()
            da9 = New SqlDataAdapter(New SqlCommand("SELECT MIN(SIF_Ukuran.Lebar) Lebar FROM SIF.dbo.SIF_Barang SIF_Barang, SIF.dbo.SIF_Ukuran SIF_Ukuran WHERE(SIF_Barang.kd_ukuran = SIF_Ukuran.Kode_Ukuran)AND (SIF_Barang.kd_jenis = '007' AND SIF_Barang.kd_jns_persd = '1')and SIF_Ukuran.Lebar  >= " & Lebar2 & " ", sqlconn))
            da9.Fill(ds7, "detilq12345")

            If Not ds7.Tables("detilq1234a") Is Nothing Then ds7.Tables("detilq1234a").Clear()
            da9 = New SqlDataAdapter(New SqlCommand("SELECT MIN(SIF_Ukuran.Lebar) Lebar FROM SIF.dbo.SIF_Barang SIF_Barang, SIF.dbo.SIF_Ukuran SIF_Ukuran WHERE(SIF_Barang.kd_ukuran = SIF_Ukuran.Kode_Ukuran)AND (SIF_Barang.kd_jenis = '007' AND SIF_Barang.kd_jns_persd = '1')and SIF_Ukuran.Lebar  >= " & lebarq & " ", sqlconn))
            da9.Fill(ds7, "detilq1234a")
            Button1.Visible = False


            'Dim colM(0) As DataColumn
            'Dim colD(0) As DataColumn
            'Dim colD1(2) As DataColumn
            'Dim colD2(2) As DataColumn
            'Dim rel1 As DataRelation

            'colM(0) = ds1.Tables("PROD").Columns("kd_jenis")

            'colD(0) = ds1.Tables("SALES").Columns("kd_jenis")

            'colD1(0) = ds1.Tables("SALES").Columns("no_sp")
            'colD1(1) = ds1.Tables("SALES").Columns("no_sp_dtl")
            'colD1(2) = ds1.Tables("SALES").Columns("no_seq")

            'colD2(0) = ds1.Tables("SOBOX").Columns("No_sp")
            'colD2(1) = ds1.Tables("SOBOX").Columns("No_seq_d")
            'colD2(2) = ds1.Tables("SOBOX").Columns("No_sp_box")


            'rel1 = ds1.Relations.Add("Detail Busa", colD1, colD2, False)

            'gc.LevelTree.Nodes.Add("Detail Busa", GV_Centi)
        End If



    End Sub

    Private Sub reload()
        If State = "ADD" Then
            If Not ds8.Tables("btemp") Is Nothing Then ds8.Tables("btemp").Clear()
            If Not ds1.Tables("SOB") Is Nothing Then ds1.Tables("SOB").Clear()
            If Not ds8.Tables("dtemp") Is Nothing Then ds8.Tables("dtemp").Clear()
            If Not ds1.Tables("SOBOX") Is Nothing Then ds1.Tables("SOBOX").Clear()
            If Not ds1.Tables("SALES") Is Nothing Then ds1.Tables("SALES").Clear()
            If Not ds1.Tables("PROD") Is Nothing Then ds1.Tables("PROD").Clear()
            If Not ds4.Tables("detilq") Is Nothing Then ds4.Tables("detilq").Clear()
            If Not ds1.Tables("RCNPRODM") Is Nothing Then ds1.Tables("RCNPRODM").Clear()

            ds1 = New DataSet
            da14 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_rcn_prod_m", sqlconn))
            da14.Fill(ds1, "RCNPRODM") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)

            Dim dr As SqlDataReader

            da2 = New SqlDataAdapter(New SqlCommand("select *, '' Nama_Jenis from PROD.dbo.PROD_rcn_prod_m where 1=0", sqlconn))
            da2.Fill(ds1, "PROD")
            dr = New SqlClient.SqlCommand("select v.*, isnull(k.jumlah_kapasitas,0) jml_kapasitas from " & _
                                          "(select distinct(kd_jenis), nama_jenis, tipe_trans from PROD.dbo.PRODV_MON_SO_Centi where Len(no_sp) > 10 And qty_sisa_prod >= 0" & _
                                          " and departement='" & kddep & "' and tipe_trans NOT IN ('JPJ-KPT-06','JPJ-KPT-09') and sts_centi='Y' " & _
                                          ") v " & _
                                          "left join " & _
                                          "(select * from SIF.dbo.SIF_kapasitas where kegiatan_ppic='03') k " & _
                                          "on v.kd_jenis=k.kd_jenis where v.kd_jenis LIKE '07%'", sqlconn).ExecuteReader
            While dr.Read
                Dim rwm As DataRow = ds1.Tables("PROD").NewRow
                rwm("Nama_Jenis") = dr.Item("nama_jenis")
                rwm("kd_jenis") = dr.Item("kd_jenis")
                rwm("tipe_trans") = dr.Item("tipe_trans")
                rwm("jml_kapasitas") = dr.Item("jml_kapasitas")
                ds1.Tables("PROD").Rows.Add(rwm)
            End While
            dr.Close()


            da3 = New SqlDataAdapter(New SqlCommand("select * ,'' Tgl_sp ,0.00 nilai,0.00 jml_blok, 0 kd_jenis,0.00 jumlahq, '' Nama_Jenis, '' Nama_Customer, '' Nama_Wilayah, '' Nama_Area, '' Nama_Barang,'' Sisa, '' tgl_kirim, '' prioritas,'' old_num, 0 as no_urut_d  from PROD.dbo.PROD_rcn_prod_d  where 1=0", sqlconn))
            da3.Fill(ds1, "SALES")
            dr = New SqlClient.SqlCommand("select v.*, ISNULL(i.nilai,0) nilai " & _
                                                               "from PROD.dbo.PRODV_MON_SO_Centi v " & _
                                                               "left join SIF.dbo.SIF_Barang b " & _
                                                               "on v.Kd_Stok = b.Kode_Barang " & _
                                                               "left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '01') i " & _
                                                               "on b.kd_jenis = i.kd_jenis and b.kd_tipe = i.kd_tipe and b.kd_ukuran = i.kd_ukuran " & _
                                                               "where(Len(v.no_sp) > 10 And v.qty_sisa_prod > 0 and (v.sts_centi='Y') " & _
                                                               " and departement='" & kddep & "' and tipe_trans <> 'JPJ-KPT-06' and (v.isClosed is null  or v.isClosed = 'N' ) " & _
                                                               ") " & _
                                                               "order by v.No_sp, v.No_seq_d", sqlconn).ExecuteReader
            While dr.Read
                Dim rw As DataRow = ds1.Tables("SALES").NewRow
                rw("no_sp") = dr.Item("No_sp")
                rw("old_num") = dr.Item("old_num")
                rw("Tgl_sp") = dr.Item("Tgl_sp")
                rw("nama_customer") = dr.Item("Nama_Customer")
                rw("nama_wilayah") = dr.Item("Nama_Wilayah")
                rw("nama_area") = dr.Item("Nama_Area")
                rw("no_sp_dtl") = dr.Item("no_seq_d")
                rw("no_seq") = dr.Item("No_sp_box")
                rw("Sisa") = dr.Item("Qty_Sisa_Prod")
                rw("kd_barang") = dr.Item("Kd_Stok")
                rw("Nama_Barang") = dr.Item("Nama_Barang")
                rw("panjang") = dr.Item("panjang")
                rw("lebar") = dr.Item("lebar")
                rw("tinggi") = dr.Item("tebal")
                rw("Nama_Jenis") = dr.Item("Nama_Jenis")
                rw("kd_jenis") = dr.Item("kd_jenis")
                rw("tgl_kirim") = dr.Item("tgl_kirim")
                rw("prioritas") = dr.Item("prioritas")
                rw("jumlah") = 0
                rw("jumlahq") = 0
                rw("jml_indeks") = 0
                rw("jml_blok") = 0
                rw("nilai") = dr.Item("nilai")

                ds1.Tables("SALES").Rows.Add(rw)
            End While
            dr.Close()
            txtTgl_Rph.Text = DateTime.Today
            txtDPB.Text = ""


            da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PRODV_MON_SO_Centi where panjang <> 0 and lebar <> 0 and tebal <> 0 and sts_centi='Y' ", sqlconn))
            da4.Fill(ds1, "SOBOX")

            da6 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rcn_prod_b where 1=0", sqlconn))
            da6.Fill(ds1, "SOB")


            da11 = New SqlDataAdapter(New SqlCommand("select *, 0.00 panjang,0.00 lebar,0.00 tinggi,0.00 jumlah_prod,0.00 jumlah_sisa, 0 no_urut_b from PROD.dbo.PROD_rcn_prod_b_temp1 where 1=0", sqlconn))
            da11.Fill(ds8, "btemp")
            da12 = New SqlDataAdapter(New SqlCommand("select *,0.00 nilai,0.00 jml_blok, 0 kd_jenis,0.00 jumlahq, '' Nama_Jenis, '' Nama_Customer, '' Nama_Wilayah, '' Nama_Area, '' Nama_Barang,'' Sisa, '' tgl_kirim, '' prioritas  from PROD.dbo.PROD_rcn_prod_d_temp  where 1=0", sqlconn))
            da12.Fill(ds8, "dtemp")

            Dim colM(0) As DataColumn
            Dim colD(0) As DataColumn
            Dim colD1(2) As DataColumn
            Dim colD2(2) As DataColumn
            Dim rel1 As DataRelation

            colM(0) = ds1.Tables("PROD").Columns("kd_jenis")

            colD(0) = ds1.Tables("SALES").Columns("kd_jenis")

            colD1(0) = ds1.Tables("SALES").Columns("no_sp")
            colD1(1) = ds1.Tables("SALES").Columns("no_sp_dtl")
            colD1(2) = ds1.Tables("SALES").Columns("no_seq")

            colD2(0) = ds1.Tables("SOBOX").Columns("No_sp")
            colD2(1) = ds1.Tables("SOBOX").Columns("No_seq_d")
            colD2(2) = ds1.Tables("SOBOX").Columns("No_sp_box")


            'rel1 = ds1.Relations.Add("Detail Busa", colD1, colD2, False)

            'gc.LevelTree.Nodes.Add("Detail Busa", GV_Centi)

            gc.DataSource = ds1.Tables("SALES")
        ElseIf State = "EDIT" Then
            Dim dr As SqlDataReader
            Dim dr1 As SqlDataReader
            If Not ds1.Tables("SOB") Is Nothing Then ds1.Tables("SOB").Clear()
            If Not ds1.Tables("SOBOX") Is Nothing Then ds1.Tables("SOBOX").Clear()
            If Not ds1.Tables("SALES") Is Nothing Then ds1.Tables("SALES").Clear()
            If Not ds1.Tables("PROD") Is Nothing Then ds1.Tables("PROD").Clear()
            If Not ds4.Tables("detilq") Is Nothing Then ds4.Tables("detilq").Clear()



            da2 = New SqlDataAdapter(New SqlCommand("select *, '' Nama_Jenis from PROD.dbo.PROD_rcn_prod_m where 1=0", sqlconn))
            da2.Fill(ds1, "PROD")
            dr = New SqlClient.SqlCommand("select v.*, isnull(k.jumlah_kapasitas,0) jml_kapasitas from " & _
            "(select distinct(kd_jenis), nama_jenis, tipe_trans from PROD.dbo.PRODV_MON_SO_Centi where Len(no_sp) > 10 And qty_sisa_prod >= 0 and vol>=0 and (sts_centi='Y') " & _
            " and departement='" & kddep & "' " & _
            ") v " & _
            "left join " & _
            "(select * from SIF.dbo.SIF_kapasitas where kegiatan_ppic='03') k " & _
            "on v.kd_jenis=k.kd_jenis where v.kd_jenis ='007'", sqlconn).ExecuteReader
            While dr.Read
                Dim rwm As DataRow = ds1.Tables("PROD").NewRow
                rwm("Nama_Jenis") = dr.Item("nama_jenis")
                rwm("kd_jenis") = dr.Item("kd_jenis")
                rwm("tipe_trans") = dr.Item("tipe_trans")
                rwm("jml_kapasitas") = dr.Item("jml_kapasitas")
                ds1.Tables("PROD").Rows.Add(rwm)
            End While
            dr.Close()

            da3 = New SqlDataAdapter(New SqlCommand("select t.*,0.00 nilai, 0 kd_jenis,0.00 jumlahq, 0.00 jml_blok,'' Nama_Jenis, '' Nama_Barang,'' Sisa, '' tgl_kirim, '' prioritas from PROD.dbo.PROD_rcn_prod_d t where 1=0", sqlconn))
            da3.Fill(ds1, "SALES")
            Dim qstr As String = "select uni.*,ISNULL(i.nilai,0) nilai from " & _
            "( select v.*, d.jumlah, d.jml_indeks " & _
                "from PROD.dbo.PROD_rcn_prod_d d " & _
                "left join PROD.dbo.PRODV_MON_SO_Centi v on v.No_sp=d.no_sp and v.no_seq_d = d.no_sp_dtl and v.No_sp_box = d.no_seq " & _
                "where d.no_rph='" & txtDPB.Text & "' and (v.sts_centi='Y')  " & _
            ") uni " & _
                "left join SIF.dbo.SIF_Barang b on uni.Kd_Stok = b.Kode_Barang " & _
                "left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '01') i on b.kd_jenis = i.kd_jenis " & _
                "and b.kd_tipe = i.kd_tipe and b.kd_ukuran = i.kd_ukuran order by uni.no_sp, uni.no_seq_d "
            dr = New SqlClient.SqlCommand(qstr, sqlconn).ExecuteReader

            While dr.Read
                Dim rw As DataRow = ds1.Tables("SALES").NewRow
                rw("no_sp") = dr.Item("No_sp")
                rw("nama_customer") = dr.Item("Nama_Customer")
                rw("nama_wilayah") = dr.Item("Nama_Wilayah")
                rw("nama_area") = dr.Item("Nama_Area")
                rw("no_sp_dtl") = dr.Item("No_seq_d")
                rw("no_seq") = dr.Item("No_sp_box")
                rw("Sisa") = dr.Item("Qty_Sisa_Prod") + dr.Item("jumlah")
                rw("panjang") = dr.Item("panjang")
                rw("lebar") = dr.Item("lebar")
                If rw("lebar") < 100 Then
                    rw("jumlahq") = dr.Item("lebar") * 2
                    rw("jml_blok") = ((dr.Item("jumlah") * dr.Item("tebal")) / 100) / 2
                ElseIf rw("lebar") >= 100 Then
                    rw("jumlahq") = dr.Item("lebar")
                    rw("jml_blok") = ((dr.Item("jumlah") * dr.Item("tebal")) / 100)
                End If
                rw("tinggi") = dr.Item("tebal")
                rw("kd_barang") = dr.Item("Kd_Stok")
                rw("Nama_Barang") = dr.Item("Nama_Barang")
                rw("Nama_Jenis") = dr.Item("Nama_Jenis")
                rw("kd_jenis") = dr.Item("kd_jenis")
                rw("tgl_kirim") = dr.Item("tgl_kirim")
                rw("prioritas") = dr.Item("prioritas")
                rw("jumlah") = dr.Item("jumlah")
                rw("jml_indeks") = dr.Item("jml_indeks")
                rw("nilai") = dr.Item("nilai")

                ds1.Tables("SALES").Rows.Add(rw)
            End While
            dr.Close()

            da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PRODV_MON_SO_Centi where panjang <> 0 and lebar <> 0 and tebal <> 0 ", sqlconn))
            da4.Fill(ds1, "SOBOX")

            da6 = New SqlDataAdapter(New SqlCommand("Select *,0.00 Tinggi,0.00 Panjang,0.00 Lebar,0.00 jml_sisa from PROD.dbo.PROD_rcn_prod_b where no_rph ='" & txtDPB.Text & "'", sqlconn))
            da6.Fill(ds1, "SOB")



            'If Not ds4.Tables("detilq") Is Nothing Then ds4.Tables("detilq").Clear()
            'da8 = New SqlDataAdapter(New SqlCommand("SELECT distinct ISNULL(SIF_Barang.volume,0.00) volume,SIF_Barang.Kode_Barang,SIF_Barang.Kd_Satuan,SIF_Barang.Nama_Barang,b.jumlah as jml_prod, b.jumlah_prod as jml_sisa,ISNULL(SIF_Barang.volume,0.00) * ceiling(b.jumlah_prod) as meter, " & _
            '"SIF_Ukuran.Tinggi, SIF_Ukuran.Lebar, SIF_Ukuran.Panjang,ceiling(b.jumlah_prod) as jumlah_prod " & _
            '"FROM SIF.dbo.SIF_Barang SIF_Barang " & _
            '"INNER JOIN SIF.dbo.SIF_Ukuran SIF_Ukuran ON SIF_Barang.kd_ukuran = SIF_Ukuran.Kode_Ukuran " & _
            '"INNER JOIN PROD.dbo.PROD_rcn_prod_b b on b.kd_barang =SIF_Barang.Kode_Barang " & _
            '"where SIF_Barang.kd_jenis = '007' AND SIF_Barang.kd_jns_persd = '2' or SIF_Barang.kd_jns_persd = '1' and Kd_Depart= '" & kddep & "' " & _
            '"AND b.no_rph= '" & txtDPB.Text & "' and b.jumlah_prod is not null or b.jumlah_prod > 0 ", sqlconn))
            'da8.Fill(ds4, "detilq")

            If Not ds4.Tables("detilq") Is Nothing Then ds4.Tables("detilq").Clear()
            da8 = New SqlDataAdapter(New SqlCommand("SELECT distinct ISNULL(SIF_Barang.volume,0.00) volume,SIF_Barang.Kode_Barang,SIF_Barang.Kd_Satuan,SIF_Barang.Nama_Barang,b.jumlah as jml_prod, b.jumlah_prod as jml_sisa,ISNULL(SIF_Barang.volume,0.00) * ceiling(b.jumlah_prod) as meter, " & _
            "SIF_Ukuran.Tinggi, SIF_Ukuran.Lebar, SIF_Ukuran.Panjang,ceiling(b.jumlah_prod) as jumlah_prod " & _
            "FROM PROD.dbo.PROD_rcn_prod_b b " & _
            "INNER JOIN   SIF.dbo.SIF_Barang SIF_Barang on b.kd_barang =SIF_Barang.Kode_Barang " & _
            "INNER JOIN SIF.dbo.SIF_Ukuran SIF_Ukuran ON SIF_Barang.kd_ukuran = SIF_Ukuran.Kode_Ukuran " & _
            "where  b.no_rph= '" & txtDPB.Text & "' ", sqlconn))
            da8.Fill(ds4, "detilq")




            GridControl1.DataSource = ds4.Tables("detilq")
            gc.DataSource = ds1.Tables("SALES")
        End If
    End Sub

    Public Sub add_click()
        State = "ADD"
        statusq = "hidup"
        GridControl2.Visible = False
        GridControl1.Visible = True
        reload()
        F = 0
        G = 0
        H = 0
        O = 0
        F1 = 0
        G1 = 0

        btnSave = False
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        itung = 0
        x3 = 0
        setStatus()
    End Sub

    Public Sub edit_click()
        statusq = "hidup"
        itung = 0
        x3 = 0
        F = 0
        G = 0
        H = 0
        O = 0
        F1 = 0
        G1 = 0
        GridControl2.Visible = False
        GridControl1.Visible = True
        Button1.Visible = True
        txtJadwal.Enabled = False
        txtTgl_Rph.Enabled = False

        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()

        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select M.tanggal [Tanggal], D.no_rph [No RPH], S.Desc_Data [Jadwal Kerja]  from (select distinct no_rph from PROD.dbo.PROD_rcn_prod_d where vol=0 or vol is null) D  " & _
                                                                    "left join PROD.dbo.PROD_rcn_prod_m M on M.no_rph=D.no_rph  " & _
                                                                    "left join SIF.dbo.SIF_Gen_Reff_D S on M.kd_jadwal=S.Id_Data  " & _
                                                                    "where S.Id_Ref_Data='JDWKRJ' and M.kd_jenis like '07%' and (M.sts_centi='Y') ", sqlconn))

        da3.Fill(ds3, "lookup_so")
        frmCari.set_dso(ds3.Tables("lookup_so"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then

            State = "EDIT"


            txtDPB.Text = frmCari.row("No RPH")
            txtJadwal.Text = frmCari.row("Jadwal Kerja")
            txtJadwal.Properties.ReadOnly = True
            txtJadwal.Properties.ReadOnly = False
            reload()

            btnSave = False
            btnadd = False
            btnEdit = False
            btnDelete = False
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

            'Dim filledrow As Integer = ds1.Tables("SALES").Select("jumlah>0").Count
            'If filledrow = 0 Then
            '    MessageBox.Show("Jumlah Rencana Produksi Belum Ada Yang Diisi")
            '    Exit Sub
            'End If
            'If Not ds4.Tables("SOBdet") Is Nothing Then ds4.Tables("SOBdet").Clear()

            Dim BTRANS As SqlTransaction
            

            mb = New SqlClient.SqlCommandBuilder(da2)
            da2.UpdateCommand = mb.GetUpdateCommand()
            da2.InsertCommand = mb.GetInsertCommand()
            da2.DeleteCommand = mb.GetDeleteCommand()
            mb = New SqlClient.SqlCommandBuilder(da5)
            da5.UpdateCommand = mb.GetUpdateCommand()
            da5.InsertCommand = mb.GetInsertCommand()
            da5.DeleteCommand = mb.GetDeleteCommand()

            mb = New SqlClient.SqlCommandBuilder(da6)
            da6.UpdateCommand = mb.GetUpdateCommand()
            da6.InsertCommand = mb.GetInsertCommand()
            da6.DeleteCommand = mb.GetDeleteCommand()



            BTRANS = sqlconn.BeginTransaction("1")
            da2.UpdateCommand.Transaction = BTRANS
            da2.InsertCommand.Transaction = BTRANS
            da2.DeleteCommand.Transaction = BTRANS


            da5.UpdateCommand.Transaction = BTRANS
            da5.InsertCommand.Transaction = BTRANS
            da5.DeleteCommand.Transaction = BTRANS


            da6.UpdateCommand.Transaction = BTRANS
            da6.InsertCommand.Transaction = BTRANS
            da6.DeleteCommand.Transaction = BTRANS


            Dim notrans As String
            notrans = getNoTrans("PRODRPH", txtTgl_Rph.DateTime, BTRANS)
            txtDPB.Text = notrans




            For i = ds1.Tables("SALES2").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = ds1.Tables("SALES2").Rows(i)
                If Not TypeOf rows("jumlah") Is DBNull Then
                    If rows("jumlah") > 0.001 Then
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
                        ds1.Tables("SALES2").Rows(i).Delete()
                    End If
                Else
                    ds1.Tables("SALES2").Rows(i).Delete()
                End If
            Next


         

            'mrow = ds1.Tables("PROD").NewRow
            'mrow.Item("kd_cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
            '''''''''''
            'mrow.Item("no_rph") = notrans
            'mrow.Item("tanggal") = txtTgl_Rph.DateTime
            'mrow.Item("sts_centi") = "Y"
            'mrow.Item("kd_jadwal") = txtJadwal.EditValue

            'mrow.Item("kd_departemen") = kddep
            'mrow.Item("last_create_date") = tgl
            'mrow.Item("last_created_by") = username
            'mrow.Item("last_update_date") = tgl
            'mrow.Item("last_updated_by") = username
            'mrow.Item("program_name") = Me.Name
            'mrow.Item("program_name") = Me.Name
            'ds1.Tables("PROD").Rows.Add(mrow)
            Dim mrow As DataRow
            For i As Integer = ds1.Tables("PROD").Rows.Count - 1 To 0 Step -1

                mrow = ds1.Tables("PROD").Rows(i)
                If mrow.GetChildRows("Detail").Count() = 0 Then


                    mrow("no_rph") = notrans
                    mrow("tanggal") = txtTgl_Rph.DateTime
                    mrow("sts_centi") = "Y"
                    mrow("kd_jadwal") = txtJadwal.EditValue
                    mrow("kd_cabang") = kdcabang
                    mrow("kd_departemen") = kddep
                    mrow("last_create_date") = tgl
                    mrow("last_created_by") = username
                    mrow("last_update_date") = tgl
                    mrow("last_updated_by") = username
                    mrow("program_name") = Me.Name
                    mrow("program_name") = Me.Name
                    mrow("jns_produksi") = "PRODUKSI"


                Else
                    mrow("no_rph") = notrans
                    mrow("tanggal") = tgl 'txtTgl_Rph.DateTime
                    mrow("kd_jadwal") = txtJadwal.EditValue
                    mrow("sts_centi") = "Y"
                    mrow("kd_cabang") = kdcabang
                    mrow("kd_departemen") = kddep
                    mrow("last_create_date") = tgl
                    mrow("last_created_by") = username
                    mrow("last_update_date") = tgl
                    mrow("last_updated_by") = username
                    mrow("program_name") = Me.Name
                    mrow("jns_produksi") = "PRODUKSI"


                End If

            Next




                    Dim rowb1 As DataRow

                    For i As Integer = dsbaru.Tables("btemp1").Rows.Count - 1 To 0 Step -1

                        rowb1 = ds1.Tables("SOB").NewRow
                        rowb1("no_urut_brg") = GridView4.GetRowCellValue(i, "no_urut_brg")
                        rowb1("no_rph") = notrans
                        rowb1("kd_barang") = GridView4.GetRowCellValue(i, "kd_barang").ToString
                        rowb1("jumlah") = GridView4.GetRowCellValue(i, "jumlah").ToString
                        rowb1("jumlah_prod") = GridView4.GetRowCellValue(i, "jumlah_prod").ToString
                        rowb1("vol") = GridView4.GetRowCellValue(i, "vol").ToString
                        rowb1("last_update_date") = tgl
                        rowb1("last_updated_by") = username
                        rowb1("program_name") = Me.Name
                        rowb1("kd_cabang") = kdcabang
                        rowb1("kd_departemen") = kddep


                        ds1.Tables("SOB").Rows.Add(rowb1)

                    Next

                    Try




                        da5.Update(ds1.Tables("SALES2"))
                        da2.Update(ds1.Tables("PROD"))
                        da6.Update(ds1.Tables("SOB"))

                        ds1.Tables("SALES2").AcceptChanges()
                        ds1.Tables("PROD").AcceptChanges()
                        ds1.Tables("SOB").AcceptChanges()



                        BTRANS.Commit()
                        btnSave = False
                        setStatus()
                        showMessages("Data Berhasil Disimpan")
                        If Not ds4.Tables("detilq") Is Nothing Then ds4.Tables("detilq").Clear()
                        txtDPB.Text = notrans
                    Catch e As Exception
                        BTRANS.Rollback()
                        ds1.Tables("SALES").RejectChanges()
                        ds1.Tables("RCNPRODM").RejectChanges()
                        ds1.Tables("SOB").RejectChanges()


                        MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

                        txtDPB.Text = ""
                        txtJadwal.EditValue = Nothing
                        reload()
                    End Try

                    Dim dr As SqlDataReader
                    Dim qstr As String
                    qstr = "delete from PROD.dbo.PROD_rcn_prod_d_temp "
                    dr = New SqlClient.SqlCommand(qstr, sqlconn, BTRANS).ExecuteReader
                    dr.Close()
                    qstr = "delete from PROD.dbo.PROD_rcn_prod_b_temp1 "
                    dr = New SqlClient.SqlCommand(qstr, sqlconn, BTRANS).ExecuteReader
                    dr.Close()

                ElseIf State = "EDIT" Then
                    Dim tgl As Date = getTanggal()

                    If txtJadwal.EditValue = Nothing Then
                        MessageBox.Show("Jadwal Kerja Belum Dipilih")
                        Exit Sub
                    End If

                    'Dim filledrow As Integer = ds1.Tables("SALES").Select("jumlah>0").Count
                    'If filledrow = 0 Then
                    '    MessageBox.Show("Jumlah Rencana Produksi Belum Ada Yang Diisi")
                    '    Exit Sub
                    'End If
                    'If Not ds4.Tables("SOBdet") Is Nothing Then ds4.Tables("SOBdet").Clear()

                    Dim BTRANS As SqlTransaction
                    mb = New SqlClient.SqlCommandBuilder(da2)
                    da2.UpdateCommand = mb.GetUpdateCommand()
                    da2.InsertCommand = mb.GetInsertCommand()
                    da2.DeleteCommand = mb.GetDeleteCommand()

                    'mb = New SqlClient.SqlCommandBuilder(da3)
                    'da3.UpdateCommand = mb.GetUpdateCommand()
                    'da3.InsertCommand = mb.GetInsertCommand()
                    'da3.DeleteCommand = mb.GetDeleteCommand()
                    mb = New SqlClient.SqlCommandBuilder(da5)
                    da5.UpdateCommand = mb.GetUpdateCommand()
                    da5.InsertCommand = mb.GetInsertCommand()
                    da5.DeleteCommand = mb.GetDeleteCommand()

                    mb = New SqlClient.SqlCommandBuilder(da6)
                    da6.UpdateCommand = mb.GetUpdateCommand()
                    da6.InsertCommand = mb.GetInsertCommand()
                    da6.DeleteCommand = mb.GetDeleteCommand()



                    BTRANS = sqlconn.BeginTransaction("1")
                    da2.UpdateCommand.Transaction = BTRANS
                    da2.InsertCommand.Transaction = BTRANS
                    da2.DeleteCommand.Transaction = BTRANS


                    da5.UpdateCommand.Transaction = BTRANS
                    da5.InsertCommand.Transaction = BTRANS
                    da5.DeleteCommand.Transaction = BTRANS


                    da6.UpdateCommand.Transaction = BTRANS
                    da6.InsertCommand.Transaction = BTRANS
                    da6.DeleteCommand.Transaction = BTRANS


                    Dim notrans As String
                    notrans = txtDPB.Text

                    Dim dr As SqlDataReader
                    Dim qstr As String
                    qstr = "delete from PROD.dbo.PROD_rcn_prod_d where no_rph='" & notrans & "'"
                    dr = New SqlClient.SqlCommand(qstr, sqlconn, BTRANS).ExecuteReader
                    dr.Close()
                    qstr = "delete from PROD.dbo.PROD_rcn_prod_m where no_rph='" & notrans & "'"
                    dr = New SqlClient.SqlCommand(qstr, sqlconn, BTRANS).ExecuteReader
                    dr.Close()


                    For i = ds1.Tables("SALES2").Rows.Count - 1 To 0 Step -1
                        Dim rows As DataRow = ds1.Tables("SALES2").Rows(i)
                        If Not TypeOf rows("jumlah") Is DBNull Then
                            If rows("jumlah") > 0.001 Then
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
                                ds1.Tables("SALES2").Rows(i).Delete()
                            End If
                        Else
                            ds1.Tables("SALES2").Rows(i).Delete()
                        End If
                    Next



                    Dim mrow As DataRow
                    For i As Integer = ds1.Tables("PROD").Rows.Count - 1 To 0 Step -1

                        mrow = ds1.Tables("PROD").Rows(i)
                        If mrow.GetChildRows("Detail").Count() = 0 Then


                            mrow("no_rph") = notrans
                            mrow("tanggal") = txtTgl_Rph.DateTime
                            mrow("sts_centi") = "Y"
                            mrow("kd_jadwal") = txtJadwal.EditValue
                            mrow("kd_cabang") = kdcabang
                            mrow("kd_departemen") = kddep
                            mrow("last_create_date") = tgl
                            mrow("last_created_by") = username
                            mrow("last_update_date") = tgl
                            mrow("last_updated_by") = username
                            mrow("program_name") = Me.Name
                            mrow("program_name") = Me.Name


                        Else
                            mrow("no_rph") = notrans
                            mrow("tanggal") = tgl 'txtTgl_Rph.DateTime
                            mrow("kd_jadwal") = txtJadwal.EditValue
                            mrow("sts_centi") = "Y"
                            mrow("kd_cabang") = kdcabang
                            mrow("kd_departemen") = kddep
                            mrow("last_create_date") = tgl
                            mrow("last_created_by") = username
                            mrow("last_update_date") = tgl
                            mrow("last_updated_by") = username
                            mrow("program_name") = Me.Name



                        End If

                    Next




                    Dim rowb1 As DataRow

                    For i As Integer = ds8.Tables("btemp").Rows.Count - 1 To 0 Step -1

                        rowb1 = ds1.Tables("SOB").Rows(i)
                        rowb1("no_urut_brg") = GridView4.GetRowCellValue(i, "no_urut_brg")
                        rowb1("no_rph") = notrans
                        rowb1("kd_barang") = GridView4.GetRowCellValue(i, "kd_barang").ToString
                        rowb1("jumlah") = GridView4.GetRowCellValue(i, "jumlah").ToString
                        rowb1("jumlah_prod") = GridView4.GetRowCellValue(i, "jumlah_prod").ToString
                        rowb1("vol") = GridView4.GetRowCellValue(i, "vol").ToString
                        rowb1("last_update_date") = tgl
                        rowb1("last_updated_by") = username
                        rowb1("program_name") = Me.Name
                        rowb1("kd_cabang") = kdcabang
                        rowb1("kd_departemen") = kddep




                    Next

                    Try

                        da5.Update(ds1.Tables("SALES2"))
                        da2.Update(ds1.Tables("PROD"))
                        da6.Update(ds1.Tables("SOB"))

                        ds1.Tables("SALES2").AcceptChanges()
                        ds1.Tables("PROD").AcceptChanges()
                        ds1.Tables("SOB").AcceptChanges()



                        BTRANS.Commit()
                        btnSave = False
                        setStatus()
                        showMessages("Data Berhasil Disimpan")
                        If Not ds4.Tables("detilq") Is Nothing Then ds4.Tables("detilq").Clear()

                    Catch e As Exception
                        BTRANS.Rollback()
                        ds1.Tables("SALES2").RejectChanges()
                        ds1.Tables("PROD").RejectChanges()
                        ds1.Tables("SOB").RejectChanges()


                        MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

                        txtDPB.Text = ""
                        txtJadwal.EditValue = Nothing
                        reload()
                    End Try

                    Dim dr1 As SqlDataReader
                    Dim qstr1 As String
                    qstr1 = "delete from PROD.dbo.PROD_rcn_prod_d_temp "
                    dr1 = New SqlClient.SqlCommand(qstr1, sqlconn, BTRANS).ExecuteReader
                    dr1.Close()
                    qstr1 = "delete from PROD.dbo.PROD_rcn_prod_b_temp1 "
                    dr1 = New SqlClient.SqlCommand(qstr1, sqlconn, BTRANS).ExecuteReader
                    dr1.Close()

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
    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub

    Public Sub cancel_click()
        If Not ds4.Tables("detilq") Is Nothing Then ds4.Tables("detilq").Clear()

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False

        Button1.Visible = False
        txtJadwal.Enabled = True
        txtTgl_Rph.Enabled = True
        Dim dr As SqlDataReader
        Dim qstr As String
        qstr = "delete from PROD.dbo.PROD_rcn_prod_d_temp "
        dr = New SqlClient.SqlCommand(qstr, sqlconn).ExecuteReader
        dr.Close()
        qstr = "delete from PROD.dbo.PROD_rcn_prod_b_temp1 "
        dr = New SqlClient.SqlCommand(qstr, sqlconn).ExecuteReader
        dr.Close()

    End Sub

    Private Sub gv_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gv.CellValueChanged

        Button1.Visible = True
        If x3 = 0 Then
            '


            If e.Column.Name = "Qty_Produksi" And statusq = "hidup" Then
                statusq = "hidup"
                GridControl1.Visible = True
                GridControl2.Visible = False
                Dim x As Object
                Dim qty, tinggi, jml_blok, lebar, noseq, panjang, tot, sisa, prod, volume, simpan As Double
                x = CType(gc.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
                'menghitung blok
                qty = x.GetRowCellValue(e.RowHandle, "jumlah")
                sisa = x.GetRowCellValue(e.RowHandle, "Sisa")

                tinggi = x.GetRowCellValue(e.RowHandle, "tinggi")

                tot = sisa - qty

                noseq = x.GetRowCellValue(e.RowHandle, "no_seq")
                x10 = x.GetRowCellValue(e.RowHandle, "lebar")
                x11 = x.GetRowCellValue(e.RowHandle, "Nama_Barang")

                ' MsgBox(x10, MsgBoxStyle.Information)

                If x10 <= 100 Then
                    lebar = x.GetRowCellValue(e.RowHandle, "lebar") * 2

                    lebarq = lebar
                    jml_blok = ((qty * tinggi) / A) / 2

                    x.SetRowCellValue(e.RowHandle, "jml_blok", jml_blok)
                    x.SetRowCellValue(e.RowHandle, "jumlahq", lebar)
                    For j As Integer = 0 To gv.RowCount - 1
                        tot += gv.GetRowCellValue(j, jml_blok)
                    Next

                ElseIf x10 > 100 Then
                    lebar = x.GetRowCellValue(e.RowHandle, "lebar")
                    lebarq = lebar
                    jml_blok = ((qty * tinggi) / A)

                    x.SetRowCellValue(e.RowHandle, "jml_blok", jml_blok)
                    x.SetRowCellValue(e.RowHandle, "jumlahq", lebar)

                    For j As Integer = 0 To gv.RowCount - 1
                        tot += gv.GetRowCellValue(j, jml_blok)
                    Next


                End If
                If State = "ADD" Then
                    If itung = 0 Then

                        If Not ds4.Tables("detilq") Is Nothing Then ds4.Tables("detilq").Clear()
                        da8 = New SqlDataAdapter(New SqlCommand("SELECT  ISNULL(SIF_Barang.volume,0.00) volume,SIF_Barang.Kode_Barang,SIF_Barang.Kd_Satuan, " & _
                                                                "SIF_Barang.Nama_Barang,0 as no_urut_b, 0.00 as jml_sisa,0.00 as jml_prod, " & _
                                                                "0.00 as meter,SIF_Ukuran.Tinggi,SIF_Ukuran.Lebar,SIF_Ukuran.Panjang " & _
                                                                "FROM SIF.dbo.SIF_Barang SIF_Barang " & _
                                                                "INNER JOIN SIF.dbo.SIF_Ukuran SIF_Ukuran on " & _
                                                                "SIF_Barang.kd_ukuran = SIF_Ukuran.Kode_Ukuran " & _
                                                                "INNER JOIN SIF.dbo.SIF_Jenis_Barang jb " & _
                                                                "on jb.Kd_Jns_Brg = SIF_Barang.kd_jenis " & _
                                                                "WHERE jb.[group] = '06' AND Kd_Depart= '" & kddep & "' and SIF_Barang.rec_stat ='Y' " & _
                                                                "order by SIF_Ukuran.Lebar", sqlconn))
                        'da8 = New SqlDataAdapter(New SqlCommand("SELECT  ISNULL(SIF_Barang.volume,0.00) volume,SIF_Barang.Kode_Barang,SIF_Barang.Kd_Satuan,SIF_Barang.Nama_Barang,0 as no_urut_b, 0.00 as jml_sisa,0.00 as jml_prod,0.00 as meter,SIF_Ukuran.Tinggi,SIF_Ukuran.Lebar,SIF_Ukuran.Panjang FROM SIF.dbo.SIF_Barang SIF_Barang, SIF.dbo.SIF_Ukuran SIF_Ukuran WHERE(SIF_Barang.kd_ukuran = SIF_Ukuran.Kode_Ukuran)AND SIF_Barang.kd_jenis = '072' AND Kd_Depart= '" & kddep & "' and SIF_Barang.rec_stat ='Y'   order by SIF_Ukuran.Lebar", sqlconn))
                        da8.Fill(ds4, "detilq")
                        GridControl1.DataSource = ds4.Tables("detilq")
                        itung = 1

                    End If
                ElseIf State = "EDIT" Then
                    If itung = 0 Then
                        If Not ds4.Tables("detilq") Is Nothing Then ds4.Tables("detilq").Clear()
                        da8 = New SqlDataAdapter(New SqlCommand("SELECT distinct ISNULL(SIF_Barang.volume,0.00) volume,SIF_Barang.Kode_Barang,SIF_Barang.Kd_Satuan,SIF_Barang.Nama_Barang,b.jumlah as jml_prod, 0.00 as jml_sisa,0.00 as meter, " & _
                        "SIF_Ukuran.Tinggi, SIF_Ukuran.Lebar, SIF_Ukuran.Panjang,b.jumlah_prod " & _
                        "FROM SIF.dbo.SIF_Barang SIF_Barang " & _
                        "INNER JOIN SIF.dbo.SIF_Ukuran SIF_Ukuran ON SIF_Barang.kd_ukuran = SIF_Ukuran.Kode_Ukuran " & _
                        "INNER JOIN PROD.dbo.PROD_rcn_prod_b b on b.kd_barang =SIF_Barang.Kode_Barang " & _
                        "where b.no_rph= '" & txtDPB.Text & "'  AND SIF_Barang.kd_jns_persd = '2' or SIF_Barang.kd_jns_persd = '1' and Kd_Depart= '" & kddep & "' ", sqlconn))
                        '"where b.no_rph= '" & txtDPB.Text & "' AND SIF_Barang.kd_jenis = '007' AND SIF_Barang.kd_jns_persd = '2' or SIF_Barang.kd_jns_persd = '1' and Kd_Depart= '" & kddep & "' ", sqlconn))

                        da8.Fill(ds4, "detilq")
                        GridControl1.DataSource = ds4.Tables("detilq")



                        itung = 1
                    End If
                End If


                Dim Lebar1, Lebar2, param1, jumlah_prod As Double

                no_urut_d = 0
                no_urut_b = 0
                no_urut_d_temp = 0
                'no_urut_b_temp = 0
                If no_urut_d_temp = 0 Then
                    no_urut_d_temp = 0
                Else
                    no_urut_d_temp = no_urut_d_temp
                End If
                For i As Integer = 0 To Gv1.RowCount - 1
                    Lebar1 = Gv1.GetRowCellValue(i, "Lebar")
                    x12 = Gv1.GetRowCellValue(i, "Nama_Barang")
                    jumlah_sisa = 0



                    For i2 As Integer = 0 To gv.RowCount - 1
                        x13 = gv.GetRowCellValue(i2, "Nama_Barang")
                        Lebar2 = gv.GetRowCellValue(i2, "jumlahq")
                        jumlah_prod = gv.GetRowCellValue(i2, "jumlah")


                        If jumlah_prod <> 0 Then
                            Dim dr3, dr4 As SqlDataReader
                            dr3 = New SqlClient.SqlCommand("Select d.Val_kode1 From SIF.dbo.SIF_Gen_Reff_D d " & _
                                                           "where d.Ref_Role = 'PROD' and d.Id_Ref_File = 'UKPRODSPN' order by d.Val_kode1 asc ", sqlconn).ExecuteReader
                            Dim param_temp As Double
                            param_temp = 0

                            While dr3.Read
                                param1 = dr3.Item("Val_kode1")
                                If Lebar2 <= param1 And param_temp = 0 Then
                                    param_temp = param1
                                ElseIf Lebar2 <= param1 And param1 > param_temp Then
                                    param_temp = param_temp
                                End If
                            End While
                            dr3.Close()
                            ' MsgBox(param_temp, MsgBoxStyle.Information)

                            Dim panjangKata As Int32
                            panjangKata = x13.Length
                            Dim nama_barang As String
                            nama_barang = Microsoft.VisualBasic.Left(x12, panjangKata)
                            If x13 = nama_barang And Lebar2 <= Lebar1 And Lebar1 <= param_temp Then
                                'If Lebar2 <= Lebar3 And Lebar1 = Lebar3 And x13 <> x12 Then
                                jumlah_blok = gv.GetRowCellValue(i2, "jml_blok")
                                jumlah_sisa += jumlah_blok
                                'jumlah_sisa = jumlah_blok
                                If no_urut_d_temp = 0 Then
                                    no_urut_d_temp = 1
                                    gv.SetRowCellValue(i2, "no_urut_d", no_urut_d_temp)
                                Else
                                    no_urut_d_temp = no_urut_d_temp
                                    gv.SetRowCellValue(i2, "no_urut_d", no_urut_d_temp)
                                End If

                                prod = -Int(-(jumlah_sisa))
                                Gv1.SetRowCellValue(i, "jml_sisa", jumlah_sisa)
                                Gv1.SetRowCellValue(i, "jml_prod", prod)
                                volume = Gv1.GetRowCellValue(i, "jml_prod") * Gv1.GetRowCellValue(i, "volume")
                                Gv1.SetRowCellValue(i, "meter", volume)
                                Gv1.SetRowCellValue(i, "no_urut_b", no_urut_d_temp)


                            ElseIf x13 = x12 Then
                                'jumlah_blok = gv.GetRowCellValue(i2, "jml_blok")
                                'jumlah_sisa += jumlah_blok
                                ''jumlah_sisa = jumlah_blok
                                'If no_urut_d_temp = 0 Then
                                '    no_urut_d_temp = 1
                                '    gv.SetRowCellValue(i2, "no_urut_d", no_urut_d_temp)
                                'Else
                                '    no_urut_d_temp = no_urut_d_temp
                                '    gv.SetRowCellValue(i2, "no_urut_d", no_urut_d_temp)
                                'End If

                                'prod = -Int(-(jumlah_sisa))
                                'Gv1.SetRowCellValue(i, "jml_sisa", jumlah_sisa)
                                'Gv1.SetRowCellValue(i, "jml_prod", prod)
                                'volume = Gv1.GetRowCellValue(i, "jml_prod") * Gv1.GetRowCellValue(i, "volume")
                                'Gv1.SetRowCellValue(i, "meter", volume)
                                'Gv1.SetRowCellValue(i, "no_urut_b", no_urut_d_temp)
                            End If
                        End If

                        'If Lebar1 >= Lebar2 Then

                        'If x12 <> x13 And Lebar2 < Lebar1 Then
                        '    If Not ds7.Tables("detilq1234") Is Nothing Then ds7.Tables("detilq1234").Clear()
                        '    da10 = New SqlDataAdapter(New SqlCommand("SELECT isnull(MIN(SIF_Ukuran.Lebar),0) Lebar FROM SIF.dbo.SIF_Barang SIF_Barang, SIF.dbo.SIF_Ukuran SIF_Ukuran WHERE(SIF_Barang.kd_ukuran = SIF_Ukuran.Kode_Ukuran)AND (SIF_Barang.kd_jenis = '007' AND SIF_Barang.kd_jns_persd = '1')and SIF_Ukuran.Lebar  >= " & Lebar2 & " ", sqlconn))
                        '    da10.Fill(ds7, "detilq1234")

                        'If ds7.Tables("detilq1234").Rows.Count > 0 Then
                        '    Lebar3 = ds7.Tables("detilq1234").Rows(0).Item("Lebar")


                        'ElseIf x12 = x13 Then

                        'jumlah_blok = gv.GetRowCellValue(i2, "jml_blok")
                        'jumlah_sisa += jumlah_blok
                        'End If
                        'ElseIf x12 = x13 Then

                        '    jumlah_blok = gv.GetRowCellValue(i2, "jml_blok")
                        '    jumlah_sisa += jumlah_blok

                        'End If
                        'ElseIf Lebar1 > Lebar2 Then

                        'jumlah_blok = gv.GetRowCellValue(i2, "jml_blok")
                        'jumlah_sisa += jumlah_blok

                        'End If

                    Next

                    no_urut_d_temp += 1


                    prod = -Int(-(jumlah_sisa))
                    Gv1.SetRowCellValue(i, "jml_sisa", jumlah_sisa)
                    Gv1.SetRowCellValue(i, "jml_prod", prod)
                    volume = Gv1.GetRowCellValue(i, "jml_prod") * Gv1.GetRowCellValue(i, "volume")
                    Gv1.SetRowCellValue(i, "meter", volume)
                    'Gv1.SetRowCellValue(i, "no_urut_b", no_urut_d_temp)

                    'no_urut_d_temp += 1

                Next



            End If
        End If




    End Sub
    Private Sub gv_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gv.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gv_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gv.ValidateRow
        Dim isValid As Boolean = True
        If e.Row("jumlah") > e.Row("Sisa") And statusq = "hidup" Then
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

        nosp.GetFocusedRowCellValue("no_sp")
        nospseq.GetFocusedRowCellValue("no_sp_dtl")

        If nosp.GetFocusedRowCellValue("no_sp") <> "" Then
            Dim dr As SqlDataReader = New SqlClient.SqlCommand("select * from PROD.dbo.PRODV_MON_SO_Centi where no_sp='" & nosp.GetFocusedRowCellValue("no_sp") & "' and no_seq_d='" & nospseq.GetFocusedRowCellValue("no_sp_dtl") & "' order by No_sp, No_seq_d", sqlconn).ExecuteReader
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
    End Sub

    Private Sub GV_Centi_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV_Centi.CellValueChanged
        If e.Column.Name = "Nama_Jenis" Then
            itung = 0
        End If
    End Sub

    Private Sub Gv1_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs)
        Dim isValid As Boolean = True
        If e.Row("jml_prod") < e.Row("jml_sisa") Then
            Gv1.SetColumnError(jml_prod, "Jumlah Blok Produksi Terlalu Banyak")
            MessageBox.Show("Jumlah Blok Produksi Terlalu Banyak")
            isValid = False
        End If
        e.Valid = isValid
    End Sub


    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    '    btnSave = True
    '    btnadd = False
    '    btnEdit = False
    '    btnDelete = True
    '    btnCancel = True
    '    setStatus()


    '    txtJadwal.Enabled = True
    '    txtTgl_Rph.Enabled = True


    '    F = F + 1
    '    G = G + 1
    '    H = H + 1
    '    O = O + 1

    '    dsbaru.Relations.Clear()
    '    If Not ds8.Tables("btemp") Is Nothing Then ds8.Tables("btemp").Clear()
    '    If Not ds8.Tables("dtemp") Is Nothing Then ds8.Tables("dtemp").Clear()
    '    da11 = New SqlDataAdapter(New SqlCommand("select *, 0.00 panjang,0.00 lebar,0.00 tinggi,0.00 jumlah_prod,0.00 jumlah_sisa from PROD.dbo.PROD_rcn_prod_b_temp1 ", sqlconn))
    '    da11.Fill(ds8, "btemp")
    '    da12 = New SqlDataAdapter(New SqlCommand("select *,0.00 nilai,0.00 jml_blok, 0 kd_jenis,0.00 jumlahq, '' Nama_Jenis, '' Nama_Customer, '' Nama_Wilayah, '' Nama_Area, '' Nama_Barang,'' Sisa, '' tgl_kirim, '' prioritas  from PROD.dbo.PROD_rcn_prod_d_temp  ", sqlconn))
    '    da12.Fill(ds8, "dtemp")
    '    Dim tgl1 As Date = getTanggal()



    '    Dim BTRANS As SqlTransaction



    '    mb = New SqlClient.SqlCommandBuilder(da11)
    '    da11.UpdateCommand = mb.GetUpdateCommand()
    '    da11.InsertCommand = mb.GetInsertCommand()
    '    da11.DeleteCommand = mb.GetDeleteCommand()
    '    mb = New SqlClient.SqlCommandBuilder(da12)
    '    da12.UpdateCommand = mb.GetUpdateCommand()
    '    da12.InsertCommand = mb.GetInsertCommand()
    '    da12.DeleteCommand = mb.GetDeleteCommand()

    '    BTRANS = sqlconn.BeginTransaction("1")
    '    da11.UpdateCommand.Transaction = BTRANS
    '    da11.InsertCommand.Transaction = BTRANS
    '    da11.DeleteCommand.Transaction = BTRANS

    '    da12.UpdateCommand.Transaction = BTRANS
    '    da12.InsertCommand.Transaction = BTRANS
    '    da12.DeleteCommand.Transaction = BTRANS


    '    Dim rowb1 As DataRow
    '    Dim j As Integer = 1
    '    For i As Integer = ds4.Tables("detilq").Rows.Count - 1 To 0 Step -1
    '        Dim row2 As DataRow = ds4.Tables("detilq").Rows(i)
    '        If Not TypeOf row2("jml_sisa") Is DBNull Then

    '            If row2("jml_sisa") > 0.001 Then

    '                Lebar6 = Gv1.GetRowCellValue(i, "jml_sisa")


    '                If Lebar6 > 0.001 Then
    '                    If Gv1.GetRowCellValue(i, "Nama_Barang") = GridView4.GetRowCellValue(i, "Nama_Barang") Then


    '                        rowb1 = ds8.Tables("btemp").NewRow

    '                        rowb1.Item("kd_barang") = Gv1.GetRowCellValue(i, "Kode_Barang").ToString
    '                        rowb1.Item("Nama_Barang") = Gv1.GetRowCellValue(i, "Nama_Barang").ToString
    '                        rowb1.Item("tinggi") = Gv1.GetRowCellValue(i, "Tinggi").ToString
    '                        rowb1.Item("panjang") = Gv1.GetRowCellValue(i, "Panjang").ToString
    '                        rowb1.Item("lebar") = Gv1.GetRowCellValue(i, "Lebar").ToString
    '                        rowb1.Item("jumlah") = Gv1.GetRowCellValue(i, "jml_prod").ToString
    '                        rowb1.Item("jumlah_prod") = Gv1.GetRowCellValue(i, "jml_sisa").ToString
    '                        rowb1.Item("vol") = Gv1.GetRowCellValue(i, "meter").ToString
    '                        rowb1.Item("last_update_date") = tgl1
    '                        rowb1.Item("last_updated_by") = username
    '                        rowb1.Item("program_name") = Me.Name
    '                        rowb1.Item("kd_cabang") = kdcabang
    '                        rowb1.Item("kd_departemen") = kddep
    '                        rowb1.Item("no_urut_brg") = 0
    '                        ds8.Tables("btemp").Rows.Add(rowb1)
    '                    Else
    '                        rowb1 = ds8.Tables("btemp").NewRow

    '                        rowb1.Item("kd_barang") = Gv1.GetRowCellValue(i, "Kode_Barang").ToString
    '                        rowb1.Item("Nama_Barang") = Gv1.GetRowCellValue(i, "Nama_Barang").ToString
    '                        rowb1.Item("tinggi") = Gv1.GetRowCellValue(i, "Tinggi").ToString
    '                        rowb1.Item("panjang") = Gv1.GetRowCellValue(i, "Panjang").ToString
    '                        rowb1.Item("lebar") = Gv1.GetRowCellValue(i, "Lebar").ToString
    '                        rowb1.Item("jumlah") = Gv1.GetRowCellValue(i, "jml_prod").ToString
    '                        rowb1.Item("jumlah_prod") = Gv1.GetRowCellValue(i, "jml_sisa").ToString
    '                        rowb1.Item("vol") = Gv1.GetRowCellValue(i, "meter").ToString
    '                        rowb1.Item("last_update_date") = tgl1
    '                        rowb1.Item("last_updated_by") = username
    '                        rowb1.Item("program_name") = Me.Name
    '                        rowb1.Item("kd_cabang") = kdcabang
    '                        rowb1.Item("kd_departemen") = kddep
    '                        rowb1.Item("no_urut_brg") = 0
    '                        ds8.Tables("btemp").Rows.Add(rowb1)

    '                    End If


    '                End If


    '            End If

    '        End If

    '    Next

    '    Dim mbrow As DataRow

    '    For i2 As Integer = ds1.Tables("SALES").Rows.Count - 1 To 0 Step -1
    '        mbrow = ds1.Tables("SALES").Rows(i2)

    '        If Not TypeOf mbrow("jml_blok") Is DBNull Then

    '            If mbrow("jml_blok") > 0.001 Then



    '                Dim rows As DataRow = ds8.Tables("dtemp").NewRow

    '                rows("last_create_date") = tgl1
    '                rows("last_created_by") = username
    '                rows("last_update_date") = tgl1
    '                rows("last_updated_by") = username
    '                rows("program_name") = Me.Name
    '                rows("kd_cabang") = kdcabang
    '                rows("panjang") = mbrow("panjang")
    '                rows("lebar") = mbrow("lebar")
    '                rows("tinggi") = mbrow("tinggi")
    '                rows("kd_jenis") = mbrow("kd_jenis")
    '                rows("no_sp") = mbrow("no_sp")
    '                rows("no_sp_dtl") = mbrow("no_sp_dtl")
    '                rows("no_seq") = mbrow("no_seq")
    '                rows("kd_departemen") = kddep
    '                rows("jumlah_prod") = mbrow("jumlah")
    '                rows("jml_blok") = mbrow("jml_blok")
    '                rows("nilai") = mbrow("nilai")
    '                rows("jumlahq") = mbrow("jumlahq")
    '                rows("Nama_Customer") = mbrow("Nama_Customer")
    '                rows("Nama_Wilayah") = mbrow("Nama_Wilayah")
    '                rows("Nama_Area") = mbrow("Nama_Area")
    '                rows("Nama_Barang") = mbrow("Nama_Barang")
    '                rows("kd_barang") = mbrow("kd_barang")
    '                rows("jumlah_sisa") = mbrow("Sisa")
    '                rows("tgl_kirim") = mbrow("tgl_kirim")
    '                rows("prioritas") = mbrow("prioritas")
    '                rows("vol") = mbrow("vol")
    '                rows("jml_indeks") = mbrow("jml_indeks")
    '                rows("no_urut_brg") = 0
    '                ds8.Tables("dtemp").Rows.Add(rows)
    '            End If
    '        End If

    '    Next

    '    Try


    '        da11.Update(ds8.Tables("btemp"))
    '        da12.Update(ds8.Tables("dtemp"))


    '        ds8.Tables("btemp").AcceptChanges()
    '        ds8.Tables("dtemp").AcceptChanges()


    '        BTRANS.Commit()

    '        'showMessages("Data Berhasil Disimpan")
    '    Catch a As Exception
    '        BTRANS.Rollback()

    '        ds8.Tables("btemp").RejectChanges()
    '        ds8.Tables("dtemp").RejectChanges()
    '        MsgBox(a.Message, MessageBoxButtons.OK)


    '        reload()
    '    End Try



    '    GridControl2.Visible = True
    '    GridControl1.Visible = False


    '    If Not ds4.Tables("detilq") Is Nothing Then ds4.Tables("detilq").Clear()
    '    da8 = New SqlDataAdapter(New SqlCommand("SELECT  ISNULL(SIF_Barang.volume,0.00) volume,SIF_Barang.Kode_Barang,SIF_Barang.Kd_Satuan,SIF_Barang.Nama_Barang, 0.00 as jml_sisa,0.00 as jml_prod,0.00 as meter,SIF_Ukuran.Tinggi,SIF_Ukuran.Lebar,SIF_Ukuran.Panjang FROM SIF.dbo.SIF_Barang SIF_Barang, SIF.dbo.SIF_Ukuran SIF_Ukuran WHERE(SIF_Barang.kd_ukuran = SIF_Ukuran.Kode_Ukuran)AND (SIF_Barang.kd_jenis = '007' AND SIF_Barang.kd_jns_persd = '1' or SIF_Barang.kd_jns_persd = '2' and Kd_Depart= '" & kddep & "' )  order by SIF_Ukuran.Lebar", sqlconn))
    '    da8.Fill(ds4, "detilq")
    '    GridControl1.DataSource = ds4.Tables("detilq")




    '    If Not dsbaru.Tables("btemp1") Is Nothing Then dsbaru.Tables("btemp1").Clear()
    '    If Not dsbaru.Tables("dtemp1") Is Nothing Then dsbaru.Tables("dtemp1").Clear()

    '    dabaru = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rcn_prod_b_temp1 order by kd_barang ", sqlconn))
    '    dabaru.Fill(dsbaru, "btemp1")

    '    dabaru1 = New SqlDataAdapter(New SqlCommand("select *  from PROD.dbo.PROD_rcn_prod_d_temp order by kd_barang  ", sqlconn))
    '    dabaru1.Fill(dsbaru, "dtemp1")

    '    GridControl2.DataSource = dsbaru.Tables("btemp1")

    '    If dsbaru.Tables("btemp1").Rows(0).Item("no_urut_brg") = 0 Then
    '        tambah = 0

    '        Dim BTRANS1 As SqlTransaction


    '        'update table
    '        mb2 = New SqlClient.SqlCommandBuilder(dabaru)
    '        dabaru.UpdateCommand = mb2.GetUpdateCommand()
    '        dabaru.InsertCommand = mb2.GetInsertCommand()
    '        dabaru.DeleteCommand = mb2.GetDeleteCommand()

    '        mb2 = New SqlClient.SqlCommandBuilder(dabaru1)
    '        dabaru1.UpdateCommand = mb2.GetUpdateCommand()
    '        dabaru1.InsertCommand = mb2.GetInsertCommand()
    '        dabaru1.DeleteCommand = mb2.GetDeleteCommand()

    '        BTRANS1 = sqlconn.BeginTransaction("1")
    '        dabaru.UpdateCommand.Transaction = BTRANS1
    '        dabaru.InsertCommand.Transaction = BTRANS1
    '        dabaru.DeleteCommand.Transaction = BTRANS1

    '        dabaru1.UpdateCommand.Transaction = BTRANS1
    '        dabaru1.InsertCommand.Transaction = BTRANS1
    '        dabaru1.DeleteCommand.Transaction = BTRANS1


    '        Dim k As Integer
    '        Dim m, l As String
    '        k = 2
    '        For p = 0 To dsbaru.Tables("btemp1").Rows.Count - 1
    '            If k Mod 2 = 0 Then
    '                m = dsbaru.Tables("btemp1").Rows(p).Item("kd_barang")
    '            ElseIf k Mod 2 = 1 Then
    '                l = dsbaru.Tables("btemp1").Rows(p).Item("kd_barang")
    '            End If
    '            If m = l Then
    '                dsbaru.Tables("btemp1").Rows(p).Item("no_urut_brg") = F - 1

    '            ElseIf m <> l Then
    '                F = F + 1
    '                dsbaru.Tables("btemp1").Rows(p).Item("no_urut_brg") = F - 1
    '            End If
    '            k = k + 1
    '        Next

    '        Dim z As Integer
    '        Dim n, y As String
    '        z = 2
    '        For p1 = 0 To dsbaru.Tables("dtemp1").Rows.Count - 1
    '            If z Mod 2 = 0 Then
    '                n = dsbaru.Tables("dtemp1").Rows(p1).Item("kd_barang")
    '            ElseIf z Mod 2 = 1 Then
    '                y = dsbaru.Tables("dtemp1").Rows(p1).Item("kd_barang")
    '            End If
    '            If n = y Then
    '                dsbaru.Tables("dtemp1").Rows(p1).Item("no_urut_brg") = G - 1

    '            ElseIf n <> y Then
    '                G = G + 1
    '                dsbaru.Tables("dtemp1").Rows(p1).Item("no_urut_brg") = G - 1
    '            End If
    '            z = z + 1
    '        Next
    '        Try


    '            dabaru.Update(dsbaru.Tables("btemp1"))
    '            dabaru1.Update(dsbaru.Tables("dtemp1"))


    '            dsbaru.Tables("btemp1").AcceptChanges()
    '            dsbaru.Tables("dtemp1").AcceptChanges()


    '            BTRANS1.Commit()

    '            'showMessages("Data Berhasil Disimpan yes")
    '        Catch a As Exception
    '            BTRANS1.Rollback()

    '            dsbaru.Tables("btemp1").RejectChanges()
    '            dsbaru.Tables("dtemp1").RejectChanges()
    '            MsgBox(a.Message, MessageBoxButtons.OK)



    '        End Try



    '    ElseIf dsbaru.Tables("btemp1").Rows(0).Item("no_urut_brg") > 0 Then
    '        tambah = 1
    '        If Not dsbaru.Tables("btemp1") Is Nothing Then dsbaru.Tables("btemp1").Clear()
    '        If Not dsbaru.Tables("dtemp1") Is Nothing Then dsbaru.Tables("dtemp1").Clear()

    '        dabaru = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rcn_prod_b_temp1  where no_urut_brg=0 order by kd_barang", sqlconn))
    '        dabaru.Fill(dsbaru, "btemp1")

    '        dabaru1 = New SqlDataAdapter(New SqlCommand("select *  from PROD.dbo.PROD_rcn_prod_d_temp  where no_urut_brg=0 order by kd_barang ", sqlconn))
    '        dabaru1.Fill(dsbaru, "dtemp1")

    '        GridControl2.DataSource = dsbaru.Tables("btemp1")

    '        Dim dr1, dr2 As SqlDataReader
    '        dr1 = New SqlClient.SqlCommand("select max(no_urut_brg) from PROD.dbo.PROD_rcn_prod_b_temp1 ", sqlconn).ExecuteReader

    '        While dr1.Read
    '            F1 = CInt(dr1.Item(0))
    '        End While
    '        dr1.Close()

    '        dr2 = New SqlClient.SqlCommand("select max(no_urut_brg) from PROD.dbo.PROD_rcn_prod_d_temp ", sqlconn).ExecuteReader
    '        While dr2.Read

    '            G1 = CInt(dr2.Item(0))

    '        End While
    '        dr2.Close()

    '        F1 = F1 + 1
    '        G1 = G1 + 1
    '        Dim BTRANS1 As SqlTransaction
    '        'update table add 2x
    '        mb2 = New SqlClient.SqlCommandBuilder(dabaru)
    '        dabaru.UpdateCommand = mb2.GetUpdateCommand()
    '        dabaru.InsertCommand = mb2.GetInsertCommand()
    '        dabaru.DeleteCommand = mb2.GetDeleteCommand()

    '        mb2 = New SqlClient.SqlCommandBuilder(dabaru1)
    '        dabaru1.UpdateCommand = mb2.GetUpdateCommand()
    '        dabaru1.InsertCommand = mb2.GetInsertCommand()
    '        dabaru1.DeleteCommand = mb2.GetDeleteCommand()

    '        BTRANS1 = sqlconn.BeginTransaction("1")
    '        dabaru.UpdateCommand.Transaction = BTRANS1
    '        dabaru.InsertCommand.Transaction = BTRANS1
    '        dabaru.DeleteCommand.Transaction = BTRANS1

    '        dabaru1.UpdateCommand.Transaction = BTRANS1
    '        dabaru1.InsertCommand.Transaction = BTRANS1
    '        dabaru1.DeleteCommand.Transaction = BTRANS1

    '        Dim k As Integer
    '        Dim m, l As String
    '        k = 2
    '        For p = 0 To dsbaru.Tables("btemp1").Rows.Count - 1
    '            If k Mod 2 = 0 Then
    '                m = dsbaru.Tables("btemp1").Rows(p).Item("kd_barang")
    '            ElseIf k Mod 2 = 1 Then
    '                l = dsbaru.Tables("btemp1").Rows(p).Item("kd_barang")
    '            End If
    '            If m = l Then
    '                dsbaru.Tables("btemp1").Rows(p).Item("no_urut_brg") = F1 - 1

    '            ElseIf m <> l Then
    '                F1 = F1 + 1
    '                dsbaru.Tables("btemp1").Rows(p).Item("no_urut_brg") = F1 - 1
    '            End If
    '            k = k + 1
    '        Next

    '        Dim z As Integer
    '        Dim n, y As String
    '        z = 2

    '        For p1 = 0 To dsbaru.Tables("dtemp1").Rows.Count - 1
    '            If z Mod 2 = 0 Then
    '                n = dsbaru.Tables("dtemp1").Rows(p1).Item("kd_barang")
    '            ElseIf z Mod 2 = 1 Then
    '                y = dsbaru.Tables("dtemp1").Rows(p1).Item("kd_barang")
    '            End If
    '            If n = y Then

    '                dsbaru.Tables("dtemp1").Rows(p1).Item("no_urut_brg") = G1 - 1

    '            ElseIf n <> y Then
    '                G1 = G1 + 1
    '                dsbaru.Tables("dtemp1").Rows(p1).Item("no_urut_brg") = G1 - 1
    '            End If
    '            z = z + 1
    '        Next
    '        Try


    '            dabaru.Update(dsbaru.Tables("btemp1"))
    '            dabaru1.Update(dsbaru.Tables("dtemp1"))


    '            dsbaru.Tables("btemp1").AcceptChanges()
    '            dsbaru.Tables("dtemp1").AcceptChanges()


    '            BTRANS1.Commit()

    '            'showMessages("Data Berhasil Disimpan ya")
    '        Catch a As Exception
    '            BTRANS1.Rollback()

    '            dsbaru.Tables("btemp1").RejectChanges()
    '            dsbaru.Tables("dtemp1").RejectChanges()
    '            MsgBox(a.Message, MessageBoxButtons.OK)

    '        End Try


    '    End If

    '    If Not dsbaru.Tables("btemp1") Is Nothing Then dsbaru.Tables("btemp1").Clear()
    '    If Not dsbaru.Tables("dtemp1") Is Nothing Then dsbaru.Tables("dtemp1").Clear()

    '    dabaru = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rcn_prod_b_temp1 order by kd_barang ", sqlconn))
    '    dabaru.Fill(dsbaru, "btemp1")

    '    dabaru1 = New SqlDataAdapter(New SqlCommand("select a.*,b.Nama_Barang  from PROD.dbo.PROD_rcn_prod_d_temp a,SIF.dbo.SIF_Barang b where a.kd_barang=b.Kode_Barang order by kd_barang  ", sqlconn))
    '    dabaru1.Fill(dsbaru, "dtemp1")

    '    GridControl2.DataSource = dsbaru.Tables("btemp1")

    '    Dim colq1(1) As DataColumn
    '    Dim colq2(1) As DataColumn

    '    Dim relw As DataRelation

    '    colq1(0) = dsbaru.Tables("dtemp1").Columns("kd_barang")
    '    colq1(1) = dsbaru.Tables("dtemp1").Columns("no_urut_brg")

    '    colq2(0) = dsbaru.Tables("btemp1").Columns("kd_barang")
    '    colq2(1) = dsbaru.Tables("btemp1").Columns("no_urut_brg")

    '    relw = dsbaru.Relations.Add("Detailrls", colq2, colq1, False)


    '    GridControl2.DataSource = dsbaru.Tables("btemp1")
    '    GridControl2.LevelTree.Nodes.Add("Detailrls", GridView7)


    '    Dim dr As SqlDataReader
    '    If Not ds1.Tables("SALES2") Is Nothing Then ds1.Tables("SALES2").Clear()


    '    'If Not ds1.Tables("SALES") Is Nothing Then ds1.Tables("SALES").Clear()

    '    'da3 = New SqlDataAdapter(New SqlCommand("select * ,0.00 nilai,0.00 jml_blok, 0 kd_jenis,0.00 jumlahq, '' Nama_Jenis, '' Nama_Customer, '' Nama_Wilayah, '' Nama_Area, '' Nama_Barang,'' Sisa, '' tgl_kirim, '' prioritas  from PROD.dbo.PROD_rcn_prod_d  where 1=0", sqlconn))
    '    'da3.Fill(ds1, "SALES")
    '    'dr = New SqlClient.SqlCommand("select v.*, ISNULL(i.nilai,0) nilai " & _
    '    '                                                   "from PROD.dbo.PRODV_MON_SO v " & _
    '    '                                                   "left join SIF.dbo.SIF_Barang b " & _
    '    '                                                   "on v.Kd_Stok = b.Kode_Barang " & _
    '    '                                                   "left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '01') i " & _
    '    '                                                   "on b.kd_jenis = i.kd_jenis and b.kd_tipe = i.kd_tipe and b.kd_ukuran = i.kd_ukuran " & _
    '    '                                                   "where(Len(v.no_sp) > 10 And v.qty_sisa_prod > 0 " & _
    '    '                                                   " and departement='" & kddep & "' and tipe_trans <> 'JPJ-KPT-06' " & _
    '    '                                                   ") " & _
    '    '                                                   "order by v.No_sp, v.No_seq_d", sqlconn).ExecuteReader
    '    'While dr.Read
    '    '    Dim rw As DataRow = ds1.Tables("SALES").NewRow
    '    '    rw("no_sp") = dr.Item("No_sp")
    '    '    rw("nama_customer") = dr.Item("Nama_Customer")
    '    '    rw("nama_wilayah") = dr.Item("Nama_Wilayah")
    '    '    rw("nama_area") = dr.Item("Nama_Area")
    '    '    rw("no_sp_dtl") = dr.Item("No_seq_d")
    '    '    rw("no_seq") = dr.Item("No_sp_box")
    '    '    rw("Sisa") = dr.Item("Qty_Sisa_Prod")
    '    '    rw("kd_barang") = dr.Item("Kd_Stok")
    '    '    rw("Nama_Barang") = dr.Item("Nama_Barang")
    '    '    rw("panjang") = dr.Item("panjang")
    '    '    rw("lebar") = dr.Item("lebar")
    '    '    rw("tinggi") = dr.Item("tebal")
    '    '    rw("Nama_Jenis") = dr.Item("Nama_Jenis")
    '    '    rw("kd_jenis") = dr.Item("kd_jenis")
    '    '    rw("tgl_kirim") = dr.Item("tgl_kirim")
    '    '    rw("prioritas") = dr.Item("prioritas")
    '    '    rw("jumlah") = 0
    '    '    rw("jumlahq") = 0
    '    '    rw("jml_indeks") = 0
    '    '    rw("jml_blok") = 0
    '    '    rw("nilai") = dr.Item("nilai")

    '    '    ds1.Tables("SALES").Rows.Add(rw)
    '    'End While
    '    'dr.Close()
    '    'gc.DataSource = ds1.Tables("SALES")

    '    da5 = New SqlDataAdapter(New SqlCommand("select * ,0.00 nilai,0.00 jml_blok, 0 kd_jenis,0.00 jumlahq, '' Nama_Jenis, '' Nama_Customer, '' Nama_Wilayah, '' Nama_Area, '' Nama_Barang,'' Sisa, '' tgl_kirim, '' prioritas  from PROD.dbo.PROD_rcn_prod_d  where 1=0", sqlconn))
    '    da5.Fill(ds1, "SALES2")
    '    dr = New SqlClient.SqlCommand("select a.*,b.Nama_Barang  from PROD.dbo.PROD_rcn_prod_d_temp a,SIF.dbo.SIF_Barang b where a.kd_barang=b.Kode_Barang", sqlconn).ExecuteReader
    '    While dr.Read
    '        Dim rw As DataRow = ds1.Tables("SALES2").NewRow
    '        rw("nama_customer") = dr.Item("Nama_Customer")
    '        rw("nama_wilayah") = dr.Item("Nama_Wilayah")
    '        rw("nama_area") = dr.Item("Nama_Area")
    '        rw("no_sp_dtl") = dr.Item("no_sp_dtl")
    '        rw("no_seq") = dr.Item("no_seq")
    '        rw("no_sp") = dr.Item("no_sp")
    '        rw("Sisa") = dr.Item("jumlah_sisa")
    '        rw("kd_barang") = dr.Item("kd_barang")
    '        rw("Nama_Barang") = dr.Item("Nama_Barang")
    '        rw("panjang") = dr.Item("panjang")
    '        rw("lebar") = dr.Item("lebar")
    '        rw("tinggi") = dr.Item("tinggi")
    '        rw("kd_jenis") = dr.Item("kd_jenis")
    '        rw("tgl_kirim") = dr.Item("tgl_kirim")
    '        rw("jumlah") = dr.Item("jumlah_prod")
    '        rw("vol") = dr.Item("vol")
    '        rw("jml_indeks") = dr.Item("jml_indeks")
    '        rw("jml_blok") = dr.Item("jml_blok")
    '        rw("no_urut_brg") = dr.Item("no_urut_brg")
    '        ds1.Tables("SALES2").Rows.Add(rw)
    '    End While
    '    dr.Close()


    '    statusq = "mati"
    '    Dim x As Object
    '    Dim qty, tinggi, jml_blok, lebar, sisa, noseq, tot As Double
    '    x = CType(gc.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
    '    For e1 As Integer = 0 To gv.RowCount - 1
    '        qty = x.GetRowCellValue(e1, "jumlah")
    '        sisa = x.GetRowCellValue(e1, "Sisa")
    '        tot = sisa - qty
    '        If tot = 0 Then
    '            gv.DeleteRow(e1)
    '        ElseIf tot > 0 Then
    '            x.SetRowCellValue(e1, "Sisa", tot)
    '            x.SetRowCellValue(e1, "nilai", qty)
    '            x.SetRowCellValue(e1, "jumlah", 0)
    '            x.SetRowCellValue(e1, "jml_blok", 0)



    '        End If
    '    Next

    '    If Not ds8.Tables("dtemp1") Is Nothing Then ds8.Tables("dtemp1").Clear()
    '    da13 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rcn_prod_d_temp", sqlconn))
    '    da13.Fill(ds8, "dtemp1")

    '    statusq = "hidup"


    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        btnSave = True
        btnadd = False
        btnEdit = False
        btnDelete = True
        btnCancel = True
        setStatus()
        Dim dr1, dr2 As SqlDataReader
        dr1 = New SqlClient.SqlCommand("select isnull(max(no_urut_brg),0) from PROD.dbo.PROD_rcn_prod_b_temp1 ", sqlconn).ExecuteReader
        If dr1.HasRows Then
            dr1.Read()
            no_urut_d = CInt(dr1.Item(0))
            dr1.Close()
        Else
            no_urut_d = 0
        End If
        

        txtJadwal.Enabled = True
        txtTgl_Rph.Enabled = True


        F = F + 1
        G = G + 1
        H = H + 1
        O = O + 1

        dsbaru.Relations.Clear()
        'If Not ds8.Tables("btemp") Is Nothing Then ds8.Tables("btemp").Clear()
        'If Not ds8.Tables("dtemp") Is Nothing Then ds8.Tables("dtemp").Clear()
        ds8.Tables("btemp").Clear()
        ds8.Tables("dtemp").Clear()
        da11 = New SqlDataAdapter(New SqlCommand("select *, 0.00 panjang,0.00 lebar,0.00 tinggi,0.00 jumlah_prod,0.00 jumlah_sisa from PROD.dbo.PROD_rcn_prod_b_temp1 ", sqlconn))
        da11.Fill(ds8, "btemp")
        da12 = New SqlDataAdapter(New SqlCommand("select *,0.00 nilai,0.00 jml_blok, 0 kd_jenis,0.00 jumlahq, '' Nama_Jenis, '' Nama_Customer, '' Nama_Wilayah, '' Nama_Area, '' Nama_Barang,'' Sisa, '' tgl_kirim, '' prioritas  from PROD.dbo.PROD_rcn_prod_d_temp  ", sqlconn))
        da12.Fill(ds8, "dtemp")
        Dim tgl1 As Date = getTanggal()



        Dim BTRANS As SqlTransaction



        mb = New SqlClient.SqlCommandBuilder(da11)
        da11.UpdateCommand = mb.GetUpdateCommand()
        da11.InsertCommand = mb.GetInsertCommand()
        da11.DeleteCommand = mb.GetDeleteCommand()
        mb = New SqlClient.SqlCommandBuilder(da12)
        da12.UpdateCommand = mb.GetUpdateCommand()
        da12.InsertCommand = mb.GetInsertCommand()
        da12.DeleteCommand = mb.GetDeleteCommand()

        BTRANS = sqlconn.BeginTransaction("1")
        da11.UpdateCommand.Transaction = BTRANS
        da11.InsertCommand.Transaction = BTRANS
        da11.DeleteCommand.Transaction = BTRANS

        da12.UpdateCommand.Transaction = BTRANS
        da12.InsertCommand.Transaction = BTRANS
        da12.DeleteCommand.Transaction = BTRANS


        Dim rowb1 As DataRow
        Dim j As Integer = 1
        For i As Integer = Gv1.RowCount - 1 To 0 Step -1
            Dim row2 As DataRow = ds4.Tables("detilq").Rows(i)
            If Not TypeOf row2("jml_sisa") Is DBNull Then

                If Gv1.GetRowCellValue(i, "jml_prod") > 0.001 Then

                    'Lebar6 = Gv1.GetRowCellValue(i, "jml_sisa")

                    'Dim panjangKata As Int32
                    'panjangKata = Gv1.GetRowCellValue(i, "Nama_Barang").Length
                    'Dim nama_barang As String
                    'nama_barang = Microsoft.VisualBasic.Left(ds4.Tables("detilq").Rows(i).Item("Nama_Barang"), panjangKata)


                    'If Gv1.GetRowCellValue(i, "Nama_Barang") = nama_barang Then


                    rowb1 = ds8.Tables("btemp").NewRow

                    rowb1.Item("kd_barang") = Gv1.GetRowCellValue(i, "Kode_Barang").ToString
                    rowb1.Item("Nama_Barang") = Gv1.GetRowCellValue(i, "Nama_Barang").ToString
                    rowb1.Item("tinggi") = Gv1.GetRowCellValue(i, "Tinggi").ToString
                    rowb1.Item("panjang") = Gv1.GetRowCellValue(i, "Panjang").ToString
                    rowb1.Item("lebar") = Gv1.GetRowCellValue(i, "Lebar").ToString
                    rowb1.Item("jumlah") = Gv1.GetRowCellValue(i, "jml_prod").ToString
                    rowb1.Item("jumlah_prod") = Gv1.GetRowCellValue(i, "jml_sisa").ToString
                    rowb1.Item("vol") = Gv1.GetRowCellValue(i, "meter").ToString
                    rowb1.Item("last_update_date") = tgl1
                    rowb1.Item("last_updated_by") = username
                    rowb1.Item("program_name") = Me.Name
                    rowb1.Item("kd_cabang") = kdcabang
                    rowb1.Item("kd_departemen") = kddep
                    rowb1.Item("no_urut_brg") = Gv1.GetRowCellValue(i, "no_urut_b")
                    'rowb1.Item("no_urut_brg") = 0
                    ds8.Tables("btemp").Rows.Add(rowb1)
                Else
                    'rowb1 = ds8.Tables("btemp").NewRow

                    'rowb1.Item("kd_barang") = Gv1.GetRowCellValue(i, "Kode_Barang").ToString
                    'rowb1.Item("Nama_Barang") = Gv1.GetRowCellValue(i, "Nama_Barang").ToString
                    'rowb1.Item("tinggi") = Gv1.GetRowCellValue(i, "Tinggi").ToString
                    'rowb1.Item("panjang") = Gv1.GetRowCellValue(i, "Panjang").ToString
                    'rowb1.Item("lebar") = Gv1.GetRowCellValue(i, "Lebar").ToString
                    'rowb1.Item("jumlah") = Gv1.GetRowCellValue(i, "jml_prod").ToString
                    'rowb1.Item("jumlah_prod") = Gv1.GetRowCellValue(i, "jml_sisa").ToString
                    'rowb1.Item("vol") = Gv1.GetRowCellValue(i, "meter").ToString
                    'rowb1.Item("last_update_date") = tgl1
                    'rowb1.Item("last_updated_by") = username
                    'rowb1.Item("program_name") = Me.Name
                    'rowb1.Item("kd_cabang") = kdcabang
                    'rowb1.Item("kd_departemen") = kddep
                    'rowb1.Item("no_urut_brg") = 0
                    'ds8.Tables("btemp").Rows.Add(rowb1)

                End If



            End If


        Next

        Dim mbrow, mbrow1 As DataRow

        For i2 As Integer = ds1.Tables("SALES").Rows.Count - 1 To 0 Step -1
            mbrow = ds1.Tables("SALES").Rows(i2)

            If Not TypeOf mbrow("jml_blok") Is DBNull Then

                If mbrow("jml_blok") > 0.001 Then



                    Dim rows As DataRow = ds8.Tables("dtemp").NewRow
                    If mbrow.RowState <> DataRowState.Deleted Then
                        rows("last_create_date") = tgl1
                        rows("last_created_by") = username
                        rows("last_update_date") = tgl1
                        rows("last_updated_by") = username
                        rows("program_name") = Me.Name
                        rows("kd_cabang") = kdcabang
                        rows("panjang") = mbrow("panjang")
                        rows("lebar") = mbrow("lebar")
                        rows("tinggi") = mbrow("tinggi")
                        rows("kd_jenis") = mbrow("kd_jenis")
                        rows("no_sp") = mbrow("no_sp")
                        rows("no_sp_dtl") = mbrow("no_sp_dtl")
                        rows("no_seq") = mbrow("no_seq")
                        rows("kd_departemen") = kddep
                        rows("jumlah_prod") = mbrow("jumlah")
                        rows("jml_blok") = mbrow("jml_blok")
                        rows("nilai") = mbrow("nilai")
                        rows("jumlahq") = mbrow("jumlahq")
                        rows("Nama_Customer") = mbrow("Nama_Customer")
                        rows("Nama_Wilayah") = mbrow("Nama_Wilayah")
                        rows("Nama_Area") = mbrow("Nama_Area")
                        rows("Nama_Barang") = mbrow("Nama_Barang")
                        rows("kd_barang") = mbrow("kd_barang")
                        rows("jumlah_sisa") = mbrow("Sisa")
                        rows("tgl_kirim") = mbrow("tgl_kirim")
                        rows("prioritas") = mbrow("prioritas")
                        rows("vol") = mbrow("vol")
                        rows("jml_indeks") = mbrow("jml_indeks")
                        'rows("no_urut_brg") = 0
                        rows("no_urut_brg") = mbrow("no_urut_d")
                        ds8.Tables("dtemp").Rows.Add(rows)
                    End If
                   
                End If
            End If

        Next

        For i4 As Integer = ds8.Tables("btemp").Rows.Count - 1 To 0 Step -1
            mbrow = ds8.Tables("btemp").Rows(i4)
            If mbrow.RowState = DataRowState.Added Then
                no_urut_d += 1
                For i5 As Integer = ds8.Tables("dtemp").Rows.Count - 1 To 0 Step -1
                    mbrow1 = ds8.Tables("dtemp").Rows(i5)

                    If mbrow1.RowState = DataRowState.Added Then
                        'MsgBox(mbrow("no_urut_brg") & " " & mbrow1("no_urut_brg"))
                        If mbrow("no_urut_brg") = mbrow1("no_urut_brg") Then
                            mbrow1("no_urut_brg") = no_urut_d

                        End If


                    End If
                Next
                mbrow("no_urut_brg") = no_urut_d
            End If
           


        Next


        Try


            da11.Update(ds8.Tables("btemp"))
            da12.Update(ds8.Tables("dtemp"))


            ds8.Tables("btemp").AcceptChanges()
            ds8.Tables("dtemp").AcceptChanges()


            BTRANS.Commit()

            'showMessages("Data Berhasil Disimpan")
        Catch a As Exception
            BTRANS.Rollback()

            ds8.Tables("btemp").RejectChanges()
            ds8.Tables("dtemp").RejectChanges()
            MsgBox(a.Message, MessageBoxButtons.OK)


            reload()
        End Try



        GridControl2.Visible = True
        GridControl1.Visible = False


        If Not ds4.Tables("detilq") Is Nothing Then ds4.Tables("detilq").Clear()
        da8 = New SqlDataAdapter(New SqlCommand("SELECT  ISNULL(SIF_Barang.volume,0.00) volume,SIF_Barang.Kode_Barang,SIF_Barang.Kd_Satuan,SIF_Barang.Nama_Barang, 0.00 as jml_sisa,0.00 as jml_prod,0.00 as meter,SIF_Ukuran.Tinggi,SIF_Ukuran.Lebar,SIF_Ukuran.Panjang FROM SIF.dbo.SIF_Barang SIF_Barang, SIF.dbo.SIF_Ukuran SIF_Ukuran WHERE(SIF_Barang.kd_ukuran = SIF_Ukuran.Kode_Ukuran)AND (SIF_Barang.kd_jenis = '007' AND SIF_Barang.kd_jns_persd = '1' or SIF_Barang.kd_jns_persd = '2' and Kd_Depart= '" & kddep & "' )  order by SIF_Ukuran.Lebar", sqlconn))
        da8.Fill(ds4, "detilq")
        GridControl1.DataSource = ds4.Tables("detilq")




        'If Not dsbaru.Tables("btemp1") Is Nothing Then dsbaru.Tables("btemp1").Clear()
        'If Not dsbaru.Tables("dtemp1") Is Nothing Then dsbaru.Tables("dtemp1").Clear()

        'dabaru = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rcn_prod_b_temp1 order by kd_barang ", sqlconn))
        'dabaru.Fill(dsbaru, "btemp1")

        'dabaru1 = New SqlDataAdapter(New SqlCommand("select *  from PROD.dbo.PROD_rcn_prod_d_temp order by kd_barang  ", sqlconn))
        'dabaru1.Fill(dsbaru, "dtemp1")

        'GridControl2.DataSource = dsbaru.Tables("btemp1")

        'If dsbaru.Tables("btemp1").Rows(0).Item("no_urut_brg") = 0 Then
        '    tambah = 0

        '    Dim BTRANS1 As SqlTransaction


        '    'update table
        '    mb2 = New SqlClient.SqlCommandBuilder(dabaru)
        '    dabaru.UpdateCommand = mb2.GetUpdateCommand()
        '    dabaru.InsertCommand = mb2.GetInsertCommand()
        '    dabaru.DeleteCommand = mb2.GetDeleteCommand()

        '    mb2 = New SqlClient.SqlCommandBuilder(dabaru1)
        '    dabaru1.UpdateCommand = mb2.GetUpdateCommand()
        '    dabaru1.InsertCommand = mb2.GetInsertCommand()
        '    dabaru1.DeleteCommand = mb2.GetDeleteCommand()

        '    BTRANS1 = sqlconn.BeginTransaction("1")
        '    dabaru.UpdateCommand.Transaction = BTRANS1
        '    dabaru.InsertCommand.Transaction = BTRANS1
        '    dabaru.DeleteCommand.Transaction = BTRANS1

        '    dabaru1.UpdateCommand.Transaction = BTRANS1
        '    dabaru1.InsertCommand.Transaction = BTRANS1
        '    dabaru1.DeleteCommand.Transaction = BTRANS1


        '    Dim k As Integer
        '    Dim m, l As String
        '    k = 2
        '    For p = 0 To dsbaru.Tables("btemp1").Rows.Count - 1
        '        If k Mod 2 = 0 Then
        '            m = dsbaru.Tables("btemp1").Rows(p).Item("kd_barang")
        '        ElseIf k Mod 2 = 1 Then
        '            l = dsbaru.Tables("btemp1").Rows(p).Item("kd_barang")
        '        End If
        '        If m = l Then
        '            dsbaru.Tables("btemp1").Rows(p).Item("no_urut_brg") = F - 1

        '        ElseIf m <> l Then
        '            F = F + 1
        '            dsbaru.Tables("btemp1").Rows(p).Item("no_urut_brg") = F - 1
        '        End If
        '        k = k + 1
        '    Next

        '    Dim z As Integer
        '    Dim n, y As String
        '    z = 2
        '    For p1 = 0 To dsbaru.Tables("dtemp1").Rows.Count - 1
        '        If z Mod 2 = 0 Then
        '            n = dsbaru.Tables("dtemp1").Rows(p1).Item("kd_barang")
        '        ElseIf z Mod 2 = 1 Then
        '            y = dsbaru.Tables("dtemp1").Rows(p1).Item("kd_barang")
        '        End If
        '        If n = y Then
        '            dsbaru.Tables("dtemp1").Rows(p1).Item("no_urut_brg") = G - 1

        '        ElseIf n <> y Then
        '            G = G + 1
        '            dsbaru.Tables("dtemp1").Rows(p1).Item("no_urut_brg") = G - 1
        '        End If
        '        z = z + 1
        '    Next
        '    Try


        '        dabaru.Update(dsbaru.Tables("btemp1"))
        '        dabaru1.Update(dsbaru.Tables("dtemp1"))


        '        dsbaru.Tables("btemp1").AcceptChanges()
        '        dsbaru.Tables("dtemp1").AcceptChanges()


        '        BTRANS1.Commit()

        '        'showMessages("Data Berhasil Disimpan yes")
        '    Catch a As Exception
        '        BTRANS1.Rollback()

        '        dsbaru.Tables("btemp1").RejectChanges()
        '        dsbaru.Tables("dtemp1").RejectChanges()
        '        MsgBox(a.Message, MessageBoxButtons.OK)



        '    End Try



        'ElseIf dsbaru.Tables("btemp1").Rows(0).Item("no_urut_brg") > 0 Then
        '    tambah = 1
        '    If Not dsbaru.Tables("btemp1") Is Nothing Then dsbaru.Tables("btemp1").Clear()
        '    If Not dsbaru.Tables("dtemp1") Is Nothing Then dsbaru.Tables("dtemp1").Clear()

        '    dabaru = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rcn_prod_b_temp1  where no_urut_brg=0 order by kd_barang", sqlconn))
        '    dabaru.Fill(dsbaru, "btemp1")

        '    dabaru1 = New SqlDataAdapter(New SqlCommand("select *  from PROD.dbo.PROD_rcn_prod_d_temp  where no_urut_brg=0 order by kd_barang ", sqlconn))
        '    dabaru1.Fill(dsbaru, "dtemp1")

        '    GridControl2.DataSource = dsbaru.Tables("btemp1")

        '    Dim dr1, dr2 As SqlDataReader
        '    dr1 = New SqlClient.SqlCommand("select max(no_urut_brg) from PROD.dbo.PROD_rcn_prod_b_temp1 ", sqlconn).ExecuteReader

        '    While dr1.Read
        '        F1 = CInt(dr1.Item(0))
        '    End While
        '    dr1.Close()

        '    dr2 = New SqlClient.SqlCommand("select max(no_urut_brg) from PROD.dbo.PROD_rcn_prod_d_temp ", sqlconn).ExecuteReader
        '    While dr2.Read

        '        G1 = CInt(dr2.Item(0))

        '    End While
        '    dr2.Close()

        '    F1 = F1 + 1
        '    G1 = G1 + 1
        '    Dim BTRANS1 As SqlTransaction
        '    'update table add 2x
        '    mb2 = New SqlClient.SqlCommandBuilder(dabaru)
        '    dabaru.UpdateCommand = mb2.GetUpdateCommand()
        '    dabaru.InsertCommand = mb2.GetInsertCommand()
        '    dabaru.DeleteCommand = mb2.GetDeleteCommand()

        '    mb2 = New SqlClient.SqlCommandBuilder(dabaru1)
        '    dabaru1.UpdateCommand = mb2.GetUpdateCommand()
        '    dabaru1.InsertCommand = mb2.GetInsertCommand()
        '    dabaru1.DeleteCommand = mb2.GetDeleteCommand()

        '    BTRANS1 = sqlconn.BeginTransaction("1")
        '    dabaru.UpdateCommand.Transaction = BTRANS1
        '    dabaru.InsertCommand.Transaction = BTRANS1
        '    dabaru.DeleteCommand.Transaction = BTRANS1

        '    dabaru1.UpdateCommand.Transaction = BTRANS1
        '    dabaru1.InsertCommand.Transaction = BTRANS1
        '    dabaru1.DeleteCommand.Transaction = BTRANS1

        '    Dim k As Integer
        '    Dim m, l As String
        '    k = 2
        '    For p = 0 To dsbaru.Tables("btemp1").Rows.Count - 1
        '        If k Mod 2 = 0 Then
        '            m = dsbaru.Tables("btemp1").Rows(p).Item("kd_barang")
        '        ElseIf k Mod 2 = 1 Then
        '            l = dsbaru.Tables("btemp1").Rows(p).Item("kd_barang")
        '        End If
        '        If m = l Then
        '            dsbaru.Tables("btemp1").Rows(p).Item("no_urut_brg") = F1 - 1

        '        ElseIf m <> l Then
        '            F1 = F1 + 1
        '            dsbaru.Tables("btemp1").Rows(p).Item("no_urut_brg") = F1 - 1
        '        End If
        '        k = k + 1
        '    Next

        '    Dim z As Integer
        '    Dim n, y As String
        '    z = 2

        '    For p1 = 0 To dsbaru.Tables("dtemp1").Rows.Count - 1
        '        If z Mod 2 = 0 Then
        '            n = dsbaru.Tables("dtemp1").Rows(p1).Item("kd_barang")
        '        ElseIf z Mod 2 = 1 Then
        '            y = dsbaru.Tables("dtemp1").Rows(p1).Item("kd_barang")
        '        End If
        '        If n = y Then

        '            dsbaru.Tables("dtemp1").Rows(p1).Item("no_urut_brg") = G1 - 1

        '        ElseIf n <> y Then
        '            G1 = G1 + 1
        '            dsbaru.Tables("dtemp1").Rows(p1).Item("no_urut_brg") = G1 - 1
        '        End If
        '        z = z + 1
        '    Next
        '    Try


        '        dabaru.Update(dsbaru.Tables("btemp1"))
        '        dabaru1.Update(dsbaru.Tables("dtemp1"))


        '        dsbaru.Tables("btemp1").AcceptChanges()
        '        dsbaru.Tables("dtemp1").AcceptChanges()


        '        BTRANS1.Commit()

        '        'showMessages("Data Berhasil Disimpan ya")
        '    Catch a As Exception
        '        BTRANS1.Rollback()

        '        dsbaru.Tables("btemp1").RejectChanges()
        '        dsbaru.Tables("dtemp1").RejectChanges()
        '        MsgBox(a.Message, MessageBoxButtons.OK)

        '    End Try


        'End If

        If Not dsbaru.Tables("btemp1") Is Nothing Then dsbaru.Tables("btemp1").Clear()
        If Not dsbaru.Tables("dtemp1") Is Nothing Then dsbaru.Tables("dtemp1").Clear()

        dabaru = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rcn_prod_b_temp1 b " & _
                                                   "where b.no_urut_brg in (Select distinct d.no_urut_brg from PROD.dbo.PROD_rcn_prod_d_temp d) ", sqlconn))
        dabaru.Fill(dsbaru, "btemp1")

        dabaru1 = New SqlDataAdapter(New SqlCommand("select a.*,b.Nama_Barang  from PROD.dbo.PROD_rcn_prod_d_temp a,SIF.dbo.SIF_Barang b where a.kd_barang=b.Kode_Barang order by kd_barang  ", sqlconn))
        dabaru1.Fill(dsbaru, "dtemp1")

        'GridControl2.DataSource = dsbaru.Tables("btemp1")

        Dim colq1(0) As DataColumn
        Dim colq2(0) As DataColumn

        Dim relw As DataRelation

        colq1(0) = dsbaru.Tables("dtemp1").Columns("no_urut_brg")
        'colq1(1) = dsbaru.Tables("dtemp1").Columns("no_urut_brg")

        colq2(0) = dsbaru.Tables("btemp1").Columns("no_urut_brg")
        'colq2(1) = dsbaru.Tables("btemp1").Columns("no_urut_brg")

        relw = dsbaru.Relations.Add("Detailrls", colq2, colq1, False)



        GridControl2.LevelTree.Nodes.Add("Detailrls", GridView7)
        GridControl2.DataSource = dsbaru.Tables("btemp1")

        Dim dr As SqlDataReader
        If Not ds1.Tables("SALES2") Is Nothing Then ds1.Tables("SALES2").Clear()


        'If Not ds1.Tables("SALES") Is Nothing Then ds1.Tables("SALES").Clear()

        'da3 = New SqlDataAdapter(New SqlCommand("select * ,0.00 nilai,0.00 jml_blok, 0 kd_jenis,0.00 jumlahq, '' Nama_Jenis, '' Nama_Customer, '' Nama_Wilayah, '' Nama_Area, '' Nama_Barang,'' Sisa, '' tgl_kirim, '' prioritas  from PROD.dbo.PROD_rcn_prod_d  where 1=0", sqlconn))
        'da3.Fill(ds1, "SALES")
        'dr = New SqlClient.SqlCommand("select v.*, ISNULL(i.nilai,0) nilai " & _
        '                                                   "from PROD.dbo.PRODV_MON_SO v " & _
        '                                                   "left join SIF.dbo.SIF_Barang b " & _
        '                                                   "on v.Kd_Stok = b.Kode_Barang " & _
        '                                                   "left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '01') i " & _
        '                                                   "on b.kd_jenis = i.kd_jenis and b.kd_tipe = i.kd_tipe and b.kd_ukuran = i.kd_ukuran " & _
        '                                                   "where(Len(v.no_sp) > 10 And v.qty_sisa_prod > 0 " & _
        '                                                   " and departement='" & kddep & "' and tipe_trans <> 'JPJ-KPT-06' " & _
        '                                                   ") " & _
        '                                                   "order by v.No_sp, v.No_seq_d", sqlconn).ExecuteReader
        'While dr.Read
        '    Dim rw As DataRow = ds1.Tables("SALES").NewRow
        '    rw("no_sp") = dr.Item("No_sp")
        '    rw("nama_customer") = dr.Item("Nama_Customer")
        '    rw("nama_wilayah") = dr.Item("Nama_Wilayah")
        '    rw("nama_area") = dr.Item("Nama_Area")
        '    rw("no_sp_dtl") = dr.Item("No_seq_d")
        '    rw("no_seq") = dr.Item("No_sp_box")
        '    rw("Sisa") = dr.Item("Qty_Sisa_Prod")
        '    rw("kd_barang") = dr.Item("Kd_Stok")
        '    rw("Nama_Barang") = dr.Item("Nama_Barang")
        '    rw("panjang") = dr.Item("panjang")
        '    rw("lebar") = dr.Item("lebar")
        '    rw("tinggi") = dr.Item("tebal")
        '    rw("Nama_Jenis") = dr.Item("Nama_Jenis")
        '    rw("kd_jenis") = dr.Item("kd_jenis")
        '    rw("tgl_kirim") = dr.Item("tgl_kirim")
        '    rw("prioritas") = dr.Item("prioritas")
        '    rw("jumlah") = 0
        '    rw("jumlahq") = 0
        '    rw("jml_indeks") = 0
        '    rw("jml_blok") = 0
        '    rw("nilai") = dr.Item("nilai")

        '    ds1.Tables("SALES").Rows.Add(rw)
        'End While
        'dr.Close()
        'gc.DataSource = ds1.Tables("SALES")

        da5 = New SqlDataAdapter(New SqlCommand("select * ,0.00 nilai,0.00 jml_blok, 0 kd_jenis,0.00 jumlahq, '' Nama_Jenis, '' Nama_Customer, '' Nama_Wilayah, '' Nama_Area, '' Nama_Barang,'' Sisa, '' tgl_kirim, '' prioritas  from PROD.dbo.PROD_rcn_prod_d  where 1=0", sqlconn))
        da5.Fill(ds1, "SALES2")
        dr = New SqlClient.SqlCommand("select a.*,b.Nama_Barang  from PROD.dbo.PROD_rcn_prod_d_temp a,SIF.dbo.SIF_Barang b where a.kd_barang=b.Kode_Barang", sqlconn).ExecuteReader
        While dr.Read
            Dim rw As DataRow = ds1.Tables("SALES2").NewRow
            rw("nama_customer") = dr.Item("Nama_Customer")
            rw("nama_wilayah") = dr.Item("Nama_Wilayah")
            rw("nama_area") = dr.Item("Nama_Area")
            rw("no_sp_dtl") = dr.Item("no_sp_dtl")
            rw("no_seq") = dr.Item("no_seq")
            rw("no_sp") = dr.Item("no_sp")
            rw("Sisa") = dr.Item("jumlah_sisa")
            rw("kd_barang") = dr.Item("kd_barang")
            rw("Nama_Barang") = dr.Item("Nama_Barang")
            rw("panjang") = dr.Item("panjang")
            rw("lebar") = dr.Item("lebar")
            rw("tinggi") = dr.Item("tinggi")
            rw("kd_jenis") = dr.Item("kd_jenis")
            rw("tgl_kirim") = dr.Item("tgl_kirim")
            rw("jumlah") = dr.Item("jumlah_prod")
            rw("vol") = dr.Item("vol")
            rw("jml_indeks") = dr.Item("jml_indeks")
            rw("jml_blok") = dr.Item("jml_blok")
            rw("no_urut_brg") = dr.Item("no_urut_brg")
            ds1.Tables("SALES2").Rows.Add(rw)
        End While
        dr.Close()


        statusq = "mati"
        Dim x As Object
        Dim qty, tinggi, jml_blok, lebar, sisa, noseq, tot As Double
        Dim no_sp, nama_barang, Nama_lebar, panjang, tebal As String

        x = CType(gc.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        ' For e1 As Integer = 0 To gv.RowCount - 1
        ' MsgBox(gv.RowCount)
        For i6 As Integer = ds1.Tables("SALES").Rows.Count - 1 To 0 Step -1
            mbrow = ds1.Tables("SALES").Rows(i6)

            If Not TypeOf mbrow("jumlah") Is DBNull Then
                If mbrow("jumlah") > 0 Then
                    If mbrow("Sisa") - mbrow("jumlah") = 0 Then
                        ds1.Tables("SALES").Rows(i6).Delete()
                    Else
                        mbrow("Sisa") = mbrow("Sisa") - mbrow("jumlah")
                        mbrow("jumlah") = 0
                    End If
                End If
            End If
        Next
        gc.DataSource = ds1.Tables("SALES")

        'For Each item As DataRow In ds1.Tables("SALES").Select("jumlah > 0")
        '    sisa = item("Sisa")
        '    qty = item("jumlah")
        '    tot = sisa - qty
        '    If tot = 0 Then

        '    End If
        'Next


        'For e1 As Integer = 0 To gv.RowCount

        '    qty = x.GetRowCellValue(e1, "jumlah")

        '    If qty > 0 Then
        '        sisa = x.GetRowCellValue(e1, "Sisa")
        '        no_sp = x.GetRowCellValue(e1, "no_sp")
        '        nama_barang = x.GetRowCellValue(e1, "Nama_Barang")
        '        lebar = x.GetRowCellValue(e1, "lebar")
        '        panjang = x.GetRowCellValue(e1, "panjang")
        '        tebal = x.GetRowCellValue(e1, "tinggi")
        '        MsgBox(no_sp & " " & nama_barang & " " & tebal & " " & panjang & " " & Nama_lebar)
        '        tot = sisa - qty
        '        If tot = 0 Then
        '            gv.DeleteRow(e1)
        '        ElseIf tot > 0 Then
        '            x.SetRowCellValue(e1, "Sisa", tot)
        '            x.SetRowCellValue(e1, "nilai", qty)
        '            x.SetRowCellValue(e1, "jumlah", 0)
        '            x.SetRowCellValue(e1, "jml_blok", 0)



        '        End If
        '    End If


        'Next

        If Not ds8.Tables("dtemp1") Is Nothing Then ds8.Tables("dtemp1").Clear()
        da13 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rcn_prod_d_temp", sqlconn))
        da13.Fill(ds8, "dtemp1")

        statusq = "hidup"


    End Sub


    Private Sub Gv1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles Gv1.CellValueChanged

        'Dim x As Object
        'Dim volume, simpan, volumehasil As Double
        'x = CType(GridControl1.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        ''menghitung blok
        'For i As Integer = 0 To ds4.Tables("detilq").Rows.Count - 1
        '    simpan = x.GetRowCellValue(i, "jumlah_prod")
        '    volume = x.GetRowCellValue(i, "volume")

        '    volumehasil = simpan * volume

        '    x.SetRowCellValue(i, "meter", volumehasil)
        'Next

    End Sub


    Private Sub gc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gc.Click

    End Sub

    Public Sub cetak_click()
        Dim TemplatePur As String
        TemplatePur = "TemplateRPH"
        callReport(App_Path() & "\report\ProdPlanRphCenti.rpt", "", "vno_rph=" & txtDPB.Text & " &vnama_report=" & TemplatePur, False, False)

    End Sub
End Class