Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base

Public Class frmRcnRphSusulCenti
    Dim ds1, ds2, ds3, ds4, ds5, ds6, dsreff, dsData As New DataSet
    Dim da1, da2, da3, da4, da5, da6, da7, da8, dareff, daData As New SqlDataAdapter
    Dim row As DataRow
    Dim mb, mb1 As New SqlCommandBuilder
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
    Public State As String
    Dim B, C, D, A As Integer
    Dim itung As Integer = 0
    Dim x1, x2, x3, x4, i, x5, x6, x7, x8, x9, x10, x11, x12 As Double
    Dim tot, view1, lebarq, jumlah_sisa, jumlah_blok As Double
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
        A = 100
        'If Not ds1.Tables("JDWKRJ") Is Nothing Then ds1.Tables("JDWKRJ").Clear()
        'da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='JDWKRJ'", sqlconn))
        'da1.Fill(ds1, "JDWKRJ")
        'txtReff.Properties.DataSource = ds1.Tables("JDWKRJ")

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
        Dim rel1 As DataRelation

        colM(0) = ds1.Tables("PROD").Columns("kd_jenis")

        colD(0) = ds1.Tables("SALES").Columns("kd_jenis")

        colD1(0) = ds1.Tables("SALES").Columns("no_sp")
        colD1(1) = ds1.Tables("SALES").Columns("no_sp_dtl")
        colD1(2) = ds1.Tables("SALES").Columns("no_seq")

        colD2(0) = ds1.Tables("SOBOX").Columns("No_sp")
        colD2(1) = ds1.Tables("SOBOX").Columns("No_seq_d")
        colD2(2) = ds1.Tables("SOBOX").Columns("No_sp_box")


        'rel = ds1.Relations.Add("Detail", colM, colD, True)
        rel1 = ds1.Relations.Add("Detail Busa", colD1, colD2, False)
        'gc.LevelTree.Nodes.Add("Detail", gv).Nodes.Add("Detail Busa", GV_Centi)
        gc.LevelTree.Nodes.Add("Detail Busa", GV_Centi)




    End Sub

    Private Sub reload()
        If State = "ADD" Then
            If Not ds1.Tables("SOB") Is Nothing Then ds1.Tables("SOB").Clear()
            If Not ds1.Tables("SOBOX") Is Nothing Then ds1.Tables("SOBOX").Clear()
            If Not ds1.Tables("SALES") Is Nothing Then ds1.Tables("SALES").Clear()
            If Not ds1.Tables("PROD") Is Nothing Then ds1.Tables("PROD").Clear()


            Dim dr As SqlDataReader

            da2 = New SqlDataAdapter(New SqlCommand("select *, '' Nama_Jenis from PROD.dbo.PROD_rcn_prod_m where 1=0", sqlconn))
            da2.Fill(ds1, "PROD")
            dr = New SqlClient.SqlCommand("select v.*, isnull(k.jumlah_kapasitas,0) jml_kapasitas from " & _
                                          "(select distinct(kd_jenis), nama_jenis, tipe_trans from PROD.dbo.PRODV_MON_SO where Len(no_sp) > 10 And qty_sisa_prod >= 0" & _
                                          " and departement='" & kddep & "' and tipe_trans <> 'JPJ-KPT-06' " & _
                                          ") v " & _
                                          "left join " & _
                                          "(select * from SIF.dbo.SIF_kapasitas where kegiatan_ppic='03') k " & _
                                          "on v.kd_jenis=k.kd_jenis where v.kd_jenis = '007'", sqlconn).ExecuteReader
            While dr.Read
                Dim rwm As DataRow = ds1.Tables("PROD").NewRow
                rwm("Nama_Jenis") = dr.Item("nama_jenis")
                rwm("kd_jenis") = dr.Item("kd_jenis")
                rwm("tipe_trans") = dr.Item("tipe_trans")
                rwm("jml_kapasitas") = dr.Item("jml_kapasitas")
                ds1.Tables("PROD").Rows.Add(rwm)
            End While
            dr.Close()


            da3 = New SqlDataAdapter(New SqlCommand("select t.*,0.00 nilai,0.00 jml_blok, 0 kd_jenis, '' Nama_Jenis, '' Nama_Barang,'' Sisa, '' tgl_kirim, '' prioritas  from PROD.dbo.PROD_rcn_prod_d t where 1=0", sqlconn))
            da3.Fill(ds1, "SALES")
            dr = New SqlClient.SqlCommand("select v.*, ISNULL(i.nilai,0) nilai " & _
                                                               "from PROD.dbo.PRODV_MON_SO v " & _
                                                               "left join SIF.dbo.SIF_Barang b " & _
                                                               "on v.Kd_Stok = b.Kode_Barang " & _
                                                               "left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '02') i " & _
                                                               "on b.kd_jenis = i.kd_jenis and b.kd_tipe = i.kd_tipe and b.kd_ukuran = i.kd_ukuran " & _
                                                               "where(Len(v.no_sp) > 10 And v.qty_sisa_prod > 0 " & _
                                                               " and departement='" & kddep & "' and tipe_trans <> 'JPJ-KPT-06' " & _
                                                               ") " & _
                                                               "order by v.No_sp, v.No_seq_d", sqlconn).ExecuteReader
            While dr.Read
                Dim rw As DataRow = ds1.Tables("SALES").NewRow
                rw("no_sp") = dr.Item("No_sp")
                rw("no_sp_dtl") = dr.Item("No_seq_d")
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
                rw("jml_indeks") = 0
                rw("jml_blok") = 0
                rw("nilai") = dr.Item("nilai")

                ds1.Tables("SALES").Rows.Add(rw)
            End While
            dr.Close()
            txtTgl_Rph.Text = DateTime.Today
            txtDPB.Text = ""


            da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PRODV_MON_SO where panjang <> 0 and lebar <> 0 and tebal <> 0  ", sqlconn))
            da4.Fill(ds1, "SOBOX")

            da6 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rcn_prod_b where 1=0", sqlconn))
            da6.Fill(ds1, "SOB")
            gc.DataSource = ds1.Tables("SALES")




        ElseIf State = "EDIT" Then
            If Not ds1.Tables("SOB") Is Nothing Then ds1.Tables("SOB").Clear()
            If Not ds1.Tables("SOBOX") Is Nothing Then ds1.Tables("SOBOX").Clear()
            If Not ds1.Tables("SALES") Is Nothing Then ds1.Tables("SALES").Clear()
            If Not ds1.Tables("PROD") Is Nothing Then ds1.Tables("PROD").Clear()

            Dim dr As SqlDataReader

            da2 = New SqlDataAdapter(New SqlCommand("select *, '' Nama_Jenis from PROD.dbo.PROD_rcn_prod_m where 1=0", sqlconn))
            da2.Fill(ds1, "PROD")
            dr = New SqlClient.SqlCommand("select v.*, isnull(k.jumlah_kapasitas,0) jml_kapasitas from " & _
                                          "(select distinct(kd_jenis), nama_jenis, tipe_trans from PROD.dbo.PRODV_MON_SO where Len(no_sp) > 10 And qty_sisa_prod >= 0 and vol>=0 " & _
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



            da3 = New SqlDataAdapter(New SqlCommand("select t.*,0.00 nilai, 0 kd_jenis, '' Nama_Jenis, '' Nama_Barang,'' Sisa, '' tgl_kirim, '' prioritas from PROD.dbo.PROD_rcn_prod_d t where 1=0", sqlconn))
            da3.Fill(ds1, "SALES")
            Dim qstr As String = "select v.*, d.jumlah, d.jml_indeks,ISNULL(i.nilai,0) nilai " & _
            "from PROD.dbo.PROD_rcn_prod_d d " & _
            "left  join PROD.dbo.PRODV_MON_SO v on v.No_sp=d.no_sp  and v.no_seq_d=d.no_sp_dtl and v.No_sp_box = d.no_seq " & _
            "left join SIF.dbo.SIF_Barang b on v.Kd_Stok = b.Kode_Barang " & _
            "left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '02') i on b.kd_jenis = i.kd_jenis and b.kd_tipe = i.kd_tipe and b.kd_ukuran = i.kd_ukuran " & _
            "where Len(v.no_sp) > 10 And v.qty_sisa_prod >= 0  and departement= '" & kddep & "'  and d.no_rph= '" & txtDPB.Text & " ' " & _
            "order by v.no_sp, v.no_seq_d, v.No_sp_box "
            dr = New SqlClient.SqlCommand(qstr, sqlconn).ExecuteReader

            While dr.Read
                Dim rw As DataRow = ds1.Tables("SALES").NewRow
                rw("no_sp") = dr.Item("No_sp")
                rw("no_sp_dtl") = dr.Item("No_seq_d")
                rw("no_seq") = dr.Item("No_sp_box")
                rw("Sisa") = dr.Item("Qty_Sisa_Prod") + dr.Item("jumlah")
                rw("panjang") = dr.Item("panjang")
                rw("lebar") = dr.Item("lebar")
                rw("tinggi") = dr.Item("tebal")
                rw("kd_barang") = dr.Item("Kd_Stok")
                rw("Nama_Barang") = dr.Item("Nama_Barang")
                rw("Nama_Jenis") = dr.Item("Nama_Jenis")
                rw("kd_jenis") = dr.Item("kd_jenis")
                rw("tgl_kirim") = dr.Item("tgl_kirim")
                rw("prioritas") = dr.Item("prioritas")
                rw("jumlah") = dr.Item("jumlah")
                rw("jml_indeks") = dr.Item("jml_indeks")
                rw("jml_blok") = 0

                rw("nilai") = dr.Item("nilai")

                ds1.Tables("SALES").Rows.Add(rw)
            End While
            dr.Close()

            da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PRODV_MON_SO where panjang <> 0 and lebar <> 0 and tebal <> 0 ", sqlconn))
            da4.Fill(ds1, "SOBOX")

            da6 = New SqlDataAdapter(New SqlCommand("Select * from PROD.dbo.PROD_rcn_prod_b where no_rph ='" & txtDPB.Text & "'", sqlconn))
            da6.Fill(ds1, "SOB")

            If Not ds4.Tables("detilq") Is Nothing Then ds4.Tables("detilq").Clear()
            da8 = New SqlDataAdapter(New SqlCommand("SELECT SIF_Barang.Kode_Barang,SIF_Barang.Kd_Satuan,SIF_Barang.Nama_Barang,b.jumlah as jml_prod, 0.00 as jml_sisa, " & _
                                                    "SIF_Ukuran.Tinggi, SIF_Ukuran.Lebar, SIF_Ukuran.Panjang " & _
                                                    "FROM SIF.dbo.SIF_Barang SIF_Barang " & _
                                                    "INNER JOIN  SIF.dbo.SIF_Ukuran SIF_Ukuran ON SIF_Barang.kd_ukuran = SIF_Ukuran.Kode_Ukuran " & _
                                                    "LEFT JOIN PROD.dbo.PROD_rcn_prod_b b on b.kd_barang =SIF_Barang.Kode_Barang " & _
                                                    "where SIF_Barang.kd_jenis = '007' AND SIF_Barang.kd_jns_persd = '1' " & _
                                                    "AND b.no_rph= '" & txtDPB.Text & "'", sqlconn))
            da8.Fill(ds4, "detilq")
            GridControl1.DataSource = ds4.Tables("detilq")
          

            gc.DataSource = ds1.Tables("SALES")
        End If
    End Sub

    Public Sub add_click()
        State = "ADD"
        isiNoReff()
        reload()

        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        itung = 0
        x3 = 0
        setStatus()
    End Sub

    Public Sub edit_click()


        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        'da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select P.tanggal Tanggal, P.no_rph [No RPH], S.Desc_Data [Jadwal Kerja] from PROD.dbo.PROD_rcn_prod_m P left join SIF.dbo.SIF_Gen_Reff_D S on P.kd_jadwal=S.Id_Data " & _
        '                                                            "where S.Id_Ref_Data='JDWKRJ' group by no_rph, tanggal, desc_data order by P.no_rph desc", sqlconn))
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select M.tanggal [Tanggal], M.no_rph [No RPH], S.Desc_Data [Jadwal Kerja],S.id_data,M.no_rph_asal [No RPHASAL]  from (select distinct no_rph from PROD.dbo.PROD_rcn_prod_d where vol=0 or vol is null) D  " & _
                                                                    "left join PROD.dbo.PROD_rcn_prod_m M on M.no_rph=D.no_rph  " & _
                                                                    "left join SIF.dbo.SIF_Gen_Reff_D S on M.kd_jadwal=S.Id_Data  " & _
                                                                    "where S.Id_Ref_Data='JDWKRJ' and M.kd_jenis='007' and no_rph_asal is not NULL", sqlconn))

        da3.Fill(ds3, "lookup_so")
        frmCari.set_dso(ds3.Tables("lookup_so"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then

            State = "EDIT"


            txtDPB.Text = frmCari.row("No RPH")
            txtJadwal.Text = frmCari.row("Jadwal Kerja")
            txtReff.EditValue = frmCari.row("No RPHASAL")
            txtReff.Properties.ReadOnly = True

            reload()

            btnSave = True
            btnadd = False
            btnEdit = False
            btnDelete = True
            btnCancel = True
            setStatus()
            Me.Enabled = True
            'da6 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rcn_prod_b where no_rph='" & txtDPB.Text & "' ", sqlconn))
            'da6.Fill(ds1, "SOB")
        Else
            cancel_click()
        End If
    End Sub

    Public Sub save_click()
        If State = "ADD" Then '----------Simpan ADD
            Dim tgl As Date = getTanggal()

            If txtReff.EditValue = Nothing Then
                MessageBox.Show("No Reff Belum Dipilih")
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

            mb = New SqlClient.SqlCommandBuilder(da6)
            da6.UpdateCommand = mb.GetUpdateCommand()
            da6.InsertCommand = mb.GetInsertCommand()
            da6.DeleteCommand = mb.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            da2.UpdateCommand.Transaction = BTRANS
            da2.InsertCommand.Transaction = BTRANS
            da2.DeleteCommand.Transaction = BTRANS

            da3.UpdateCommand.Transaction = BTRANS
            da3.InsertCommand.Transaction = BTRANS
            da3.DeleteCommand.Transaction = BTRANS


            da6.UpdateCommand.Transaction = BTRANS
            da6.InsertCommand.Transaction = BTRANS
            da6.DeleteCommand.Transaction = BTRANS
            Dim rowb3 As DataRow
           
            txtDPB.Text = notrans

            For i = ds1.Tables("SALES").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = ds1.Tables("SALES").Rows(i)
                If Not TypeOf rows("jumlah") Is DBNull Then
                    If rows("jumlah") > 0 Then
                        For i1 As Integer = ds4.Tables("detilq").Rows.Count - 1 To 0 Step -1
                            rowb3 = ds4.Tables("detilq").Rows(i)
                            If Not TypeOf rowb3("Lebar") Is DBNull Then

                                If Gv1.GetRowCellValue(i1, "Lebar") = lebarq Then

                                    rows("tanggal") = tgl 'txtTgl_Rph.DateTime
                                    rows("no_rph") = txtDPB.Text
                                    rows("last_create_date") = tgl
                                    rows("last_created_by") = username
                                    rows("last_update_date") = tgl
                                    rows("last_updated_by") = username
                                    rows("program_name") = Me.Name
                                    rows("kd_cabang") = kdcabang
                                    rows("kd_departemen") = kddep
                                    rows("kd_barang") = Gv1.GetRowCellValue(i1, "Kode_Barang").ToString
                                End If
                            End If
                        Next
                        '

                    Else
                        ds1.Tables("SALES").Rows(i).Delete()
                    End If
                Else
                    ds1.Tables("SALES").Rows(i).Delete()
                End If
            Next


            Dim mrow As DataRow
            For i = ds1.Tables("PROD").Rows.Count - 1 To 0 Step -1
                mrow = ds1.Tables("PROD").Rows(i)
                If mrow.GetChildRows("Detail").Count() = 0 Then

                    'mrow.Delete()

                    mrow("no_rph") = notrans
                    mrow("no_rph_asal") = txtReff.EditValue
                    mrow("tanggal") = txtTgl_Rph.DateTime
                    mrow("kd_jadwal") = id_data
                    mrow("kd_cabang") = kdcabang
                    mrow("kd_departemen") = kddep
                    mrow("last_create_date") = tgl
                    mrow("last_created_by") = username
                    mrow("last_update_date") = tgl
                    mrow("last_updated_by") = username
                    mrow("program_name") = Me.Name

                Else
                    mrow("no_rph") = notrans
                    mrow("no_rph_asal") = txtReff.EditValue
                    mrow("tanggal") = tgl 'txtTgl_Rph.DateTime
                    mrow("kd_jadwal") = id_data
                    mrow("kd_cabang") = kdcabang
                    mrow("kd_departemen") = kddep
                    mrow("last_create_date") = tgl
                    mrow("last_created_by") = username
                    mrow("last_update_date") = tgl
                    mrow("last_updated_by") = username
                    mrow("program_name") = Me.Name


                End If
            Next



            Dim rowb As DataRow
            Dim rowb1 As DataRow
            For i = ds4.Tables("detilq").Rows.Count - 1 To 0 Step -1
                rowb = ds4.Tables("detilq").Rows(i)
                If Not TypeOf rowb("Lebar") Is DBNull Then

                    If Gv1.GetRowCellValue(i, "Lebar") = lebarq Then

                        rowb1 = ds1.Tables("SOB").NewRow
                        'rows("tanggal") = txtTgl_Rph.DateTime
                        rowb1.Item("no_rph") = notrans
                        rowb1.Item("kd_barang") = Gv1.GetRowCellValue(i, "Kode_Barang").ToString
                        rowb1.Item("jumlah") = Gv1.GetRowCellValue(i, "jml_prod").ToString
                        rowb1.Item("last_update_date") = tgl
                        rowb1.Item("last_updated_by") = username
                        rowb1.Item("program_name") = Me.Name
                        rowb1.Item("kd_cabang") = kdcabang
                        rowb1.Item("kd_departemen") = kddep
                        ds1.Tables("SOB").Rows.Add(rowb1)

                    End If

                End If
            Next

            Try

                da2.Update(ds1.Tables("PROD"))
                da3.Update(ds1.Tables("SALES"))
                da6.Update(ds1.Tables("SOB"))

                ds1.Tables("PROD").AcceptChanges()
                ds1.Tables("SALES").AcceptChanges()
                ds1.Tables("SOB").AcceptChanges()

                'call_procedure(notrans, BTRANS)
                State = "EDIT"
                BTRANS.Commit()
                btnSave = False
                setStatus()
                showMessages("Data Berhasil Disimpan")
            Catch e As Exception
                BTRANS.Rollback()
                ds1.Tables("SALES").RejectChanges()
                ds1.Tables("PROD").RejectChanges()
                ds1.Tables("SOB").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

                txtDPB.Text = ""
                txtReff.EditValue = Nothing
                reload()
            End Try

        ElseIf State = "EDIT" Then '------------Simpan EDIT
            Dim tgl As Date = getTanggal()

            If txtReff.EditValue = Nothing Then
                MessageBox.Show("No Reff Belum Dipilih")
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

            mb1 = New SqlClient.SqlCommandBuilder(da6)
            da6.UpdateCommand = mb1.GetUpdateCommand()
            da6.InsertCommand = mb1.GetInsertCommand()
            da6.DeleteCommand = mb1.GetDeleteCommand()


            BTRANS = sqlconn.BeginTransaction("1")
            da2.UpdateCommand.Transaction = BTRANS
            da2.InsertCommand.Transaction = BTRANS
            da2.DeleteCommand.Transaction = BTRANS

            da3.UpdateCommand.Transaction = BTRANS
            da3.InsertCommand.Transaction = BTRANS
            da3.DeleteCommand.Transaction = BTRANS

            da6.UpdateCommand.Transaction = BTRANS
            da6.InsertCommand.Transaction = BTRANS
            da6.DeleteCommand.Transaction = BTRANS

            Dim notrans As String
            notrans = txtDPB.Text
            Dim dr As SqlDataReader
            Dim qstr As String
            qstr = "delete from PROD.dbo.PROD_rcn_prod_b where no_rph='" & notrans & "'"
            dr = New SqlClient.SqlCommand(qstr, sqlconn, BTRANS).ExecuteReader
            dr.Close()
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
                        'rows("tanggal") = txtTgl_Rph.DateTime
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

            Dim mrow As DataRow
            For i = ds1.Tables("PROD").Rows.Count - 1 To 0 Step -1
                mrow = ds1.Tables("PROD").Rows(i)
                If mrow.GetChildRows("Detail").Count() = 0 Then
                    'mrow.Delete()
                    mrow("no_rph") = notrans
                    mrow("no_rph_asal") = txtReff.EditValue
                    mrow("tanggal") = txtTgl_Rph.DateTime
                    mrow("kd_jadwal") = txtJadwal.Text
                    mrow("kd_cabang") = kdcabang
                    mrow("kd_departemen") = kddep
                    mrow("last_update_date") = tgl
                    mrow("last_updated_by") = username
                    mrow("program_name") = Me.Name
                Else
                    mrow("no_rph") = notrans
                    mrow("no_rph_asal") = txtReff.EditValue
                    mrow("tanggal") = txtTgl_Rph.DateTime
                    mrow("kd_jadwal") = txtJadwal.Text
                    mrow("kd_cabang") = kdcabang
                    mrow("kd_departemen") = kddep
                    mrow("last_update_date") = tgl
                    mrow("last_updated_by") = username
                    mrow("program_name") = Me.Name


                End If
            Next
            Dim rowb As DataRow
            Dim rowb1 As DataRow
            For i = ds4.Tables("detilq").Rows.Count - 1 To 0 Step -1
                rowb = ds4.Tables("detilq").Rows(i)
                If Not TypeOf rowb("Lebar") Is DBNull Then

                    If Gv1.GetRowCellValue(i, "Lebar") = lebarq Then

                        rowb1 = ds1.Tables("SOB").NewRow
                        'rows("tanggal") = txtTgl_Rph.DateTime
                        rowb1.Item("no_rph") = notrans
                        rowb1.Item("kd_barang") = Gv1.GetRowCellValue(i, "Kode_Barang").ToString
                        rowb1.Item("jumlah") = Gv1.GetRowCellValue(i, "jml_prod").ToString
                        rowb1.Item("last_update_date") = tgl
                        rowb1.Item("last_updated_by") = username
                        rowb1.Item("program_name") = Me.Name
                        rowb1.Item("kd_cabang") = kdcabang
                        rowb1.Item("kd_departemen") = kddep
                        ds1.Tables("SOB").Rows.Add(rowb1)

                    End If

                End If
            Next
     

            Try
                da2.Update(ds1.Tables("PROD"))
                da3.Update(ds1.Tables("SALES"))
                da6.Update(ds1.Tables("SOB"))
                ds1.Tables("PROD").AcceptChanges()
                ds1.Tables("SALES").AcceptChanges()
                ds1.Tables("SOB").AcceptChanges()
                State = "EDIT"
                BTRANS.Commit()
                btnSave = False
                setStatus()
                showMessages("Data Berhasil Disimpan")

            Catch e As Exception
                BTRANS.Rollback()
                ds1.Tables("SALES").RejectChanges()
                ds1.Tables("PROD").RejectChanges()
                ds1.Tables("SOB").RejectChanges()
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
        's

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
    End Sub

    Private Sub gv_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gv.CellValueChanged
        If State = "ADD" Then

            If x3 = 0 Then

                If e.Column.Name = "Qty_Produksi" Then
                    Dim x As Object
                    Dim qty, tinggi, jml_blok, lebar, noseq As Double
                    x = CType(gc.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)

                    qty = x.GetRowCellValue(e.RowHandle, "jumlah")

                    tinggi = x.GetRowCellValue(e.RowHandle, "tinggi")
                    lebar = x.GetRowCellValue(e.RowHandle, "lebar")
                    noseq = x.GetRowCellValue(e.RowHandle, "no_seq")

                    lebarq = lebar
                    jml_blok = (qty * tinggi) / A

                    'x1 += jml_blok
                    x.SetRowCellValue(e.RowHandle, "jml_blok", jml_blok)
                    For j As Integer = 0 To gv.RowCount - 1
                        tot += gv.GetRowCellValue(j, jml_blok)
                    Next




                    If Not ds4.Tables("detilq1") Is Nothing Then ds4.Tables("detilq1").Clear()
                    da7 = New SqlDataAdapter(New SqlCommand("SELECT SIF_Barang.Kode_Barang,SIF_Barang.Kd_Satuan,SIF_Barang.Nama_Barang, 0.00 as jml_sisa,0.00 as jml_prod,SIF_Ukuran.Tinggi,SIF_Ukuran.Lebar,SIF_Ukuran.Panjang FROM SIF.dbo.SIF_Barang SIF_Barang, SIF.dbo.SIF_Ukuran SIF_Ukuran WHERE(SIF_Barang.kd_ukuran = SIF_Ukuran.Kode_Ukuran)AND (SIF_Barang.kd_jenis = '007' AND SIF_Barang.kd_jns_persd = '1') AND SIF_Ukuran.Lebar='" & lebar & "'", sqlconn))
                    da7.Fill(ds4, "detilq1")


                    If ds4.Tables("detilq1").Rows.Count > 0 Then



                        If itung = 0 Then


                            If Not ds4.Tables("detilq") Is Nothing Then ds4.Tables("detilq").Clear()
                            da8 = New SqlDataAdapter(New SqlCommand("SELECT SIF_Barang.Kode_Barang,SIF_Barang.Kd_Satuan,SIF_Barang.Nama_Barang, 0.00 as jml_sisa,0.00 as jml_prod,SIF_Ukuran.Tinggi,SIF_Ukuran.Lebar,SIF_Ukuran.Panjang FROM SIF.dbo.SIF_Barang SIF_Barang, SIF.dbo.SIF_Ukuran SIF_Ukuran WHERE(SIF_Barang.kd_ukuran = SIF_Ukuran.Kode_Ukuran)AND (SIF_Barang.kd_jenis = '007' AND SIF_Barang.kd_jns_persd = '1') ", sqlconn))
                            da8.Fill(ds4, "detilq")

                            GridControl1.DataSource = ds4.Tables("detilq")
                            itung = 1
                            'dr1.Close()
                        End If



                    End If

                    Dim Lebar1, Lebar2 As Double
                    For i As Integer = 0 To Gv1.RowCount - 1
                        jumlah_sisa = 0
                        For i2 As Integer = 0 To gv.RowCount - 1
                            Lebar1 = Gv1.GetRowCellValue(i, "Lebar")
                            Lebar2 = gv.GetRowCellValue(i2, "lebar")
                            If Lebar1 = Lebar2 Then
                                jumlah_blok = gv.GetRowCellValue(i2, "jml_blok")
                                jumlah_sisa += jumlah_blok
                                'MsgBox(jumlah_sisa, MsgBoxStyle.Information, "Jumlah Blok")
                            Else


                            End If

                        Next
                        Gv1.SetRowCellValue(i, "jml_sisa", jumlah_sisa)
                        Gv1.SetRowCellValue(i, "jml_prod", jumlah_sisa)
                    Next

                End If

            End If


        ElseIf State = "EDIT" Then

            If x3 = 0 Then
                If e.Column.Name = "Qty_Produksi" Then
                    Dim x As Object
                    Dim qty, tinggi, jml_blok, lebar As Double
                    x = CType(gc.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
                    qty = x.GetRowCellValue(e.RowHandle, "jumlah")
                    tinggi = x.GetRowCellValue(e.RowHandle, "tinggi")
                    lebar = x.GetRowCellValue(e.RowHandle, "lebar")
                    lebarq = lebar
                    jml_blok = (qty * tinggi) / A
                    'x1 += jml_blok
                    x.SetRowCellValue(e.RowHandle, "jml_blok", jml_blok)
                    For j As Integer = 0 To gv.RowCount - 1
                        tot += gv.GetRowCellValue(j, jml_blok)
                    Next




                    If Not ds4.Tables("detilq1") Is Nothing Then ds4.Tables("detilq1").Clear()
                    da7 = New SqlDataAdapter(New SqlCommand("SELECT SIF_Barang.Kode_Barang,SIF_Barang.Kd_Satuan,SIF_Barang.Nama_Barang,b.jumlah as jml_prod, 0.00 as jml_sisa, " & _
                                                                    "SIF_Ukuran.Tinggi, SIF_Ukuran.Lebar, SIF_Ukuran.Panjang " & _
                                                                    "FROM SIF.dbo.SIF_Barang SIF_Barang " & _
                                                                    "INNER JOIN  SIF.dbo.SIF_Ukuran SIF_Ukuran ON SIF_Barang.kd_ukuran = SIF_Ukuran.Kode_Ukuran " & _
                                                                    "LEFT JOIN PROD.dbo.PROD_rcn_prod_b b on b.kd_barang =SIF_Barang.Kode_Barang " & _
                                                                    "where SIF_Barang.kd_jenis = '007' AND SIF_Barang.kd_jns_persd = '1' " & _
                                                                    "AND b.no_rph= '" & txtDPB.Text & "' AND SIF_Ukuran.Lebar='" & lebar & "'", sqlconn))
                    da7.Fill(ds4, "detilq1")


                    If ds4.Tables("detilq1").Rows.Count > 0 Then
                        ds4.Tables("detilq1").Rows(0).Item("jml_sisa") = jml_blok + x1
                        x2 = ds4.Tables("detilq1").Rows(0).Item("jml_sisa")
                        x1 = jml_blok


                        If itung = 0 Then


                            Dim dr As SqlDataReader
                            If Not ds4.Tables("detilq") Is Nothing Then ds4.Tables("detilq").Clear()
                            da8 = New SqlDataAdapter(New SqlCommand("SELECT SIF_Barang.Kode_Barang,SIF_Barang.Kd_Satuan,SIF_Barang.Nama_Barang,b.jumlah as jml_prod, 0.00 as jml_sisa, " & _
                                                                    "SIF_Ukuran.Tinggi, SIF_Ukuran.Lebar, SIF_Ukuran.Panjang " & _
                                                                    "FROM SIF.dbo.SIF_Barang SIF_Barang " & _
                                                                    "INNER JOIN  SIF.dbo.SIF_Ukuran SIF_Ukuran ON SIF_Barang.kd_ukuran = SIF_Ukuran.Kode_Ukuran " & _
                                                                    "LEFT JOIN PROD.dbo.PROD_rcn_prod_b b on b.kd_barang =SIF_Barang.Kode_Barang " & _
                                                                    "where SIF_Barang.kd_jenis = '007' AND SIF_Barang.kd_jns_persd = '1' " & _
                                                                    "AND b.no_rph= '" & txtDPB.Text & "'", sqlconn))
                            da8.Fill(ds4, "detilq")


                            GridControl1.DataSource = ds4.Tables("detilq")
                            itung = 1
                            'dr1.Close()
                        End If



                    End If

                    Dim Lebar1, Lebar2 As Double
                    For i As Integer = 0 To Gv1.RowCount - 1
                        jumlah_sisa = 0
                        For i2 As Integer = 0 To gv.RowCount - 1
                            Lebar1 = Gv1.GetRowCellValue(i, "Lebar")
                            Lebar2 = gv.GetRowCellValue(i2, "lebar")
                            If Lebar1 = Lebar2 Then
                                jumlah_blok = gv.GetRowCellValue(i2, "jml_blok")
                                jumlah_sisa += jumlah_blok

                            Else


                            End If

                        Next
                        Gv1.SetRowCellValue(i, "jml_sisa", jumlah_sisa)
                        Gv1.SetRowCellValue(i, "jml_prod", jumlah_sisa)
                    Next

                End If



            End If


        End If

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
        nosp.GetFocusedRowCellValue("no_sp")
        nospseq.GetFocusedRowCellValue("no_sp_dtl")

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
    End Sub

    Private Sub GV_Centi_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV_Centi.CellValueChanged
        If e.Column.Name = "Nama_Jenis" Then
            itung = 0
        End If
    End Sub

    Private Sub Gv1_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles Gv1.ValidateRow
        Dim isValid As Boolean = True
        If e.Row("jml_prod") < e.Row("jml_sisa") Then
            Gv1.SetColumnError(jml_prod, "Jumlah Blok Produksi Terlalu Banyak")
            MessageBox.Show("Jumlah Blok Produksi Terlalu Banyak")
            isValid = False

        End If
        e.Valid = isValid
    End Sub

    Private Sub txtReff_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtReff.EditValueChanged
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
    End Sub
    Private id_data As String
    Dim notrans As String
End Class