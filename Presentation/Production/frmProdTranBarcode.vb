Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Public Class frmProdTranBarcode
    Dim ds1, ds2, ds3, ds4, ds5, ds6, dsedit As New DataSet
    Dim da1, da2, da3, da4, da5, da6, daedit, dsPost As New SqlDataAdapter
    Dim row, rows, row1 As DataRow
    Dim mb, mb1 As New SqlCommandBuilder
    Dim prn As frmMain
    Dim nilai As String
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Dim isinvalid As Boolean
    Public State, kode, kode1, kode2, kode3, kode4, kode5 As String
    Dim rl, rl1 As DataRelation
    Dim l, k, j, m As Integer
    Dim drPost As SqlDataReader
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Public Sub add_click()

        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnAdd = False
        State = "EDIT1"
        setStatus()
        If Not ds1.Tables("norph") Is Nothing Then ds1.Tables("norph").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select distinct no_rph from PROD.dbo.PROD_ctk_barcode_d where kd_departemen='" & kddep & "' and cetak_barcode='T'", sqlconn))
        da1.Fill(ds1, "norph")
        lkrph.Properties.DataSource = ds1.Tables("norph")
        lkrph.Properties.ValueMember = "no_rph"
        lkrph.Properties.DisplayMember = "no_rph"


    End Sub
    Private Sub frmProdTranBarcode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)

       

        If Not ds4.Tables("QICM") Is Nothing Then ds4.Tables("QICM").Clear()
        If Not ds4.Tables("QICMD") Is Nothing Then ds4.Tables("QICMD").Clear()
        da4 = New SqlDataAdapter(New SqlCommand("select* from PROD.dbo.PROD_ctk_barcode_m", sqlconn))
        da4.Fill(ds4, "QICM")
        da5 = New SqlDataAdapter(New SqlCommand("select* from PROD.dbo.PROD_ctk_barcode_d ", sqlconn))
        da5.Fill(ds4, "QICMD")

    End Sub
    Private Sub loadlookup()
        If Not ds1.Tables("loadnama") Is Nothing Then ds1.Tables("loadnama").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        da1.Fill(ds1, "loadnama")
        lkkdbarang.DataSource = ds1.Tables("loadnama")
        lkkdbarang.DisplayMember = "Nama_Barang"
        lkkdbarang.ValueMember = "Kode_Barang"

        If Not ds1.Tables("loadtipe") Is Nothing Then ds1.Tables("loadtipe").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select a.Kode_Barang, b.Nama_tipe from SIF.dbo.SIF_Barang a, SIF.dbo.SIF_tipe b WHERE a.kd_tipe=b.Kode_tipe", sqlconn))
        da1.Fill(ds1, "loadtipe")
        lktipe.DataSource = ds1.Tables("loadtipe")
        lktipe.DisplayMember = "Nama_tipe"
        lktipe.ValueMember = "Kode_Barang"

        If Not ds1.Tables("loadkain") Is Nothing Then ds1.Tables("loadkain").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select a.Kode_Barang, b.Merk_Kain from SIF.dbo.SIF_Barang a, SIF.dbo.SIF_Kain b WHERE a.kd_kain=b.Kode_Kain", sqlconn))
        da1.Fill(ds1, "loadkain")
        lkkain.DataSource = ds1.Tables("loadkain")
        lkkain.DisplayMember = "Merk_Kain"
        lkkain.ValueMember = "Kode_Barang"

        If Not ds1.Tables("loadukuran") Is Nothing Then ds1.Tables("loadukuran").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select a.Kode_Barang, b.Nama_Ukuran from SIF.dbo.SIF_Barang a, SIF.dbo.SIF_Ukuran b where a.kd_ukuran=b.Kode_Ukuran", sqlconn))
        da1.Fill(ds1, "loadukuran")
        lkukuran.DataSource = ds1.Tables("loadukuran")
        lkukuran.DisplayMember = "Nama_Ukuran"
        lkukuran.ValueMember = "Kode_Barang"


    End Sub
    Private Sub loadData()


        ds2.Clear()
        ds2.Relations.Clear()

        If Not ds2.Tables("QIC") Is Nothing Then ds2.Tables("QIC").Clear()
        If Not ds2.Tables("QICD") Is Nothing Then ds2.Tables("QICD").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select distinct  kd_jns_brg,Nama_Jenis from PROD.dbo.PROD_ctk_barcode_d u,SIF.dbo.SIF_barang d,SIF.dbo.SIF_Jenis_Barang h where  u.kd_barang=d.kode_barang and u.no_rph= '" & lkrph.EditValue & "' and   u.Kd_Departemen= '" & kddep & "' and d.kd_jenis=h.Kd_Jns_brg  and u.cetak_barcode='T'", sqlconn))
        da2.Fill(ds2, "QIC")
        da3 = New SqlDataAdapter(New SqlCommand("select  * from PROD.dbo.PROD_ctk_barcode_d b,SIF.dbo.SIF_barang d,SIF.dbo.SIF_Kain e,SIF.dbo.SIF_Ukuran f where  b.kd_barang=d.kode_barang and d.kd_kain=e.kode_kain and d.kd_ukuran=f.kode_ukuran  and b.no_rph= '" & lkrph.EditValue & "' and b.cetak_barcode='T' and  d.kd_jenis in (select   kd_jns_brg from PROD.dbo.PROD_ctk_barcode_d u,SIF.dbo.SIF_barang d,SIF.dbo.SIF_Jenis_Barang h where  u.kd_barang=d.kode_barang and u.no_rph= '" & lkrph.EditValue & "' and   u.Kd_Departemen= '" & kddep & "' and d.kd_jenis=h.Kd_Jns_brg  and u.cetak_barcode='T') ", sqlconn))
        da3.Fill(ds2, "QICD")
        rl = ds2.Relations.Add("Detailq", ds2.Tables("QIC").Columns("kd_jns_brg"), ds2.Tables("QICD").Columns("kd_jenis"))
        GridControl1.DataSource = ds2.Tables("QIC")
        GridControl1.LevelTree.Nodes.Add("Detailq", GridView2)
        GridView1.BestFitColumns()
        GridView2.BestFitColumns()



    End Sub

    Private Sub lkrph_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkrph.EditValueChanged
        Try
            If State = "EDIT1" Then
                If Not ds1.Tables("isirph") Is Nothing Then ds1.Tables("isirph").Clear()
                da1 = New SqlDataAdapter(New SqlCommand("select distinct desc_data from PROD.dbo.PROD_rcn_prod_m a,SIF.dbo.SIF_Gen_Reff_D c where a.no_rph='" & lkrph.EditValue & "' and a.kd_jadwal=c.id_data and c.ref_role='PROD' and c.id_Ref_File='JDWKRJ'", sqlconn))
                da1.Fill(ds1, "isirph")


                txtjdwl.Text = ds1.Tables("isirph").Rows(0).Item("desc_data").ToString
                txttanggal.Text = Now.Date
                loadData()
                loadlookup()


            ElseIf State = "EDIT" Then
                If Not ds1.Tables("isirph") Is Nothing Then ds1.Tables("isirph").Clear()
                da1 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rcn_prod_m a,SIF.dbo.SIF_Gen_Reff_D c where a.no_rph='" & lkrph.EditValue & "' and a.kd_jadwal=c.id_data and c.ref_role='PROD' and c.id_Ref_File='JDWKRJ'", sqlconn))
                da1.Fill(ds1, "isirph")


                txtjdwl.Text = ds1.Tables("isirph").Rows(0).Item("desc_data").ToString
                txttanggal.Text = Now.Date


            End If
        Catch ex As Exception

        End Try
       
    End Sub

    Public Sub save_click()
        Dim notrans As String

        If State = "EDIT1" Then

            row = ds4.Tables("QICM").Rows(0)

            
            row.Item("Last_update_Date") = Now
            row.Item("Last_updated_By") = umum.username

        ElseIf State = "EDIT" Then
            row = ds4.Tables("QICM").Rows(0)

            row.Item("Last_update_Date") = Now
            row.Item("Last_updated_By") = umum.username

        End If
        

        If State = "EDIT1" Then
            notrans = getNoTrans("BRCD", Now.Date)
            For Each rows As DataRow In ds2.Tables("QICD").Rows
                If rows("cetak_barcode") = "Y" Then
                    rows.Item("keterangan") = notrans
                    rows.Item("Last_Create_Date") = Now
                    rows.Item("Last_Created_By") = umum.username
                    rows.Item("Program_Name") = Me.Name

                End If



            Next

        ElseIf State = "EDIT" Then
            notrans = getNoTrans("BRCD", Now.Date)
            For Each rows As DataRow In ds5.Tables("QICd").Rows
                If rows("cetak_barcode") = "Y" Then
                    rows.Item("keterangan") = notrans
                    rows.Item("Last_Create_Date") = Now
                    rows.Item("Last_Created_By") = umum.username
                    rows.Item("Program_Name") = Me.Name

                End If


            Next

        End If

        If State = "EDIT1" Then
            Try

                mb = New SqlClient.SqlCommandBuilder(da4)
                da4.UpdateCommand = mb.GetUpdateCommand()
                da4.InsertCommand = mb.GetInsertCommand()
                da4.DeleteCommand = mb.GetDeleteCommand()

                mb1 = New SqlClient.SqlCommandBuilder(da5)
                da5.UpdateCommand = mb1.GetUpdateCommand()
                da5.InsertCommand = mb1.GetInsertCommand()
                da5.DeleteCommand = mb1.GetDeleteCommand()

                da4.Update(ds4.Tables("QICM"))
                da5.Update(ds2.Tables("QICD"))

                ds4.Tables("QICM").AcceptChanges()
                ds2.Tables("QICD").AcceptChanges()
                showMessages("Saved..")

                ds2.Clear()
                ds2.Relations.Clear()
                If Not ds2.Tables("QICD") Is Nothing Then ds2.Tables("QICD").Clear()
                If Not ds2.Tables("QIC") Is Nothing Then ds2.Tables("QIC").Clear()

                da2 = New SqlDataAdapter(New SqlCommand("select distinct  kd_jns_brg,Nama_Jenis from PROD.dbo.PROD_ctk_barcode_d u,SIF.dbo.SIF_barang d,SIF.dbo.SIF_Jenis_Barang h where  u.kd_barang=d.kode_barang and u.no_rph= '" & lkrph.EditValue & "' and   u.Kd_Departemen= '" & kddep & "' and d.kd_jenis=h.Kd_Jns_brg  and u.cetak_barcode='T'", sqlconn))
                da2.Fill(ds2, "QIC")
                da3 = New SqlDataAdapter(New SqlCommand("select  * from PROD.dbo.PROD_ctk_barcode_d b,SIF.dbo.SIF_barang d,SIF.dbo.SIF_Kain e,SIF.dbo.SIF_Ukuran f where  b.kd_barang=d.kode_barang and d.kd_kain=e.kode_kain and d.kd_ukuran=f.kode_ukuran  and b.no_rph= '" & lkrph.EditValue & "' and b.cetak_barcode='T' and  d.kd_jenis in (select   kd_jns_brg from PROD.dbo.PROD_ctk_barcode_d u,SIF.dbo.SIF_barang d,SIF.dbo.SIF_Jenis_Barang h where  u.kd_barang=d.kode_barang and u.no_rph= '" & lkrph.EditValue & "' and   u.Kd_Departemen= '" & kddep & "' and d.kd_jenis=h.Kd_Jns_brg  and u.cetak_barcode='T') ", sqlconn))
                da3.Fill(ds2, "QICD")
                rl = ds2.Relations.Add("Detailq", ds2.Tables("QIC").Columns("kd_jns_brg"), ds2.Tables("QICD").Columns("kd_jenis"))
                GridControl1.DataSource = ds2.Tables("QIC")
                GridControl1.LevelTree.Nodes.Add("Detailq", GridView2)
                GridView1.BestFitColumns()
                GridView2.BestFitColumns()

                btnSave = False
                btnCancel = True
                btnDelete = False
                btnEdit = False
                btnAdd = False
                setStatus()
                generate_barcode(notrans)
                'Me.Enabled = False

            Catch e As Exception

                ds4.Tables("QICM").RejectChanges()
                ds2.Tables("QICD").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical)

            End Try



        ElseIf State = "EDIT" Then

            Try

                mb = New SqlClient.SqlCommandBuilder(da4)
                da4.UpdateCommand = mb.GetUpdateCommand()
                da4.InsertCommand = mb.GetInsertCommand()
                da4.DeleteCommand = mb.GetDeleteCommand()

                mb1 = New SqlClient.SqlCommandBuilder(da5)
                da5.UpdateCommand = mb1.GetUpdateCommand()
                da5.InsertCommand = mb1.GetInsertCommand()
                da5.DeleteCommand = mb1.GetDeleteCommand()

                da4.Update(ds4.Tables("QICM"))
                da5.Update(ds5.Tables("QICd"))

                ds4.Tables("QICM").AcceptChanges()
                ds5.Tables("QICd").AcceptChanges()
                showMessages("EDIT..")

                ds5.Clear()
                ds5.Relations.Clear()
                If Not ds5.Tables("QICdm") Is Nothing Then ds5.Tables("QICdm").Clear()
                If Not ds5.Tables("QICd") Is Nothing Then ds5.Tables("QICd").Clear()

                da1 = New SqlDataAdapter(New SqlCommand("select   distinct kd_jns_brg,Nama_Jenis from PROD.dbo.PROD_ctk_barcode_d u,SIF.dbo.SIF_barang d,SIF.dbo.SIF_Jenis_Barang h where  u.kd_barang=d.kode_barang and u.no_rph= '" & kode1 & "' and   h.Kd_Departemen= '" & kddep & "' and d.kd_jenis=h.Kd_Jns_brg and u.cetak_barcode='Y'", sqlconn))
                da1.Fill(ds5, "QICdm")
                da2 = New SqlDataAdapter(New SqlCommand(" select  * from PROD.dbo.PROD_ctk_barcode_d b,SIF.dbo.SIF_barang d,SIF.dbo.SIF_Kain e,SIF.dbo.SIF_Ukuran f where  b.kd_barang=d.kode_barang and d.kd_kain=e.kode_kain and d.kd_ukuran=f.kode_ukuran  and b.no_rph= '" & kode1 & "' and b.cetak_barcode='Y' and  d.kd_jenis in (select   kd_jns_brg from PROD.dbo.PROD_ctk_barcode_d u,SIF.dbo.SIF_barang d,SIF.dbo.SIF_Jenis_Barang h where  u.kd_barang=d.kode_barang and u.no_rph= '" & kode1 & "' and   h.Kd_Departemen= '" & kddep & "' and d.kd_jenis=h.Kd_Jns_brg and b.cetak_barcode='Y') ", sqlconn))
                da2.Fill(ds5, "QICd")
                rl = ds5.Relations.Add("Detail", ds5.Tables("QICdm").Columns("kd_jns_brg"), ds5.Tables("QICd").Columns("kd_jenis"))
                GridControl1.DataSource = ds5.Tables("QICdm")
                GridControl1.LevelTree.Nodes.Add("Detail", GridView2)
                GridView1.BestFitColumns()
                GridView2.BestFitColumns()

                btnSave = False
                btnCancel = True
                btnDelete = False
                btnEdit = False
                btnAdd = False
                setStatus()
                generate_barcode(notrans)
                'Me.Enabled = False


            Catch e As Exception

                ds4.Tables("QICM").RejectChanges()
                ds5.Tables("QICd").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical)


            End Try


        End If

      


    End Sub
    Public Sub edit_click()

        State = "EDIT"
        matilookup()


        ' bila menggunakan form cari
        dsedit = New DataSet
        daedit = New SqlDataAdapter(New SqlCommand("select distinct b.no_rph no_rph,a.tanggal,b.cetak_barcode from PROD.dbo.PROD_ctk_barcode_m a,PROD.dbo.PROD_ctk_barcode_d b where a.kd_departemen='" & kddep & "' and a.no_rph=b.no_rph and b.cetak_barcode='T'", sqlconn)) '<- query buat ditampilkan di LOV
        daedit.Fill(dsedit, "Look")
        frmCari.set_dso(dsedit.Tables("Look"))
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then

            If Not ds1.Tables("norph") Is Nothing Then ds1.Tables("norph").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("select distinct no_rph from PROD.dbo.PROD_ctk_barcode_d where kd_departemen='" & kddep & "' and cetak_barcode='T'", sqlconn))
            da1.Fill(ds1, "norph")
            lkrph.Properties.DataSource = ds1.Tables("norph")
            lkrph.Properties.ValueMember = "no_rph"
            lkrph.Properties.DisplayMember = "no_rph"


            kode1 = frmCari.row("no_rph").ToString
            kode2 = frmCari.row("cetak_barcode").ToString

            ds5.Relations.Clear()
            If Not ds5.Tables("QICdm") Is Nothing Then ds5.Tables("QICdm").Clear()
            If Not ds5.Tables("QICd") Is Nothing Then ds5.Tables("QICd").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("select  distinct kd_jns_brg,Nama_Jenis from PROD.dbo.PROD_ctk_barcode_d k,SIF.dbo.SIF_barang d,SIF.dbo.SIF_Jenis_Barang h where  k.kd_barang=d.kode_barang and k.no_rph= '" & kode1 & "' and   k.Kd_Departemen= '" & kddep & "' and d.kd_jenis=h.Kd_Jns_brg and k.cetak_barcode='T' ", sqlconn)) '<- query buat ditampilkan di LOV
            da1.Fill(ds5, "QICdm")
            GridControl1.DataSource = ds5.Tables("QICdm")
            da2 = New SqlDataAdapter(New SqlCommand("select  * from PROD.dbo.PROD_ctk_barcode_d b,SIF.dbo.SIF_barang d,SIF.dbo.SIF_Kain e,SIF.dbo.SIF_Ukuran f where  b.kd_barang=d.kode_barang and d.kd_kain=e.kode_kain and d.kd_ukuran=f.kode_ukuran  and b.no_rph= '" & kode1 & "' and b.cetak_barcode='T' and   d.kd_jenis in (select   kd_jns_brg from PROD.dbo.PROD_ctk_barcode_d u,SIF.dbo.SIF_barang d,SIF.dbo.SIF_Jenis_Barang h where  u.kd_barang=d.kode_barang and u.no_rph= '" & kode1 & "' and   u.Kd_Departemen= '" & kddep & "' and d.kd_jenis=h.Kd_Jns_brg and u.cetak_barcode='T') ", sqlconn))
            da2.Fill(ds5, "QICd")


            rl1 = ds5.Relations.Add("Detail1", ds5.Tables("QICdm").Columns("kd_jns_brg"), ds5.Tables("QICd").Columns("kd_jenis"))
            GridControl1.DataSource = ds5.Tables("QICdm")
            GridControl1.LevelTree.Nodes.Add("Detail1", GridView2)
            GridView1.BestFitColumns()
            GridView2.BestFitColumns()

            loadlookup()

            row1 = ds5.Tables("QICd").Rows(0)
            lkrph.EditValue = row1("no_rph").ToString
            
            btnSave = True
            btnCancel = True
            btnadd = False
            btnEdit = False
            btnDelete = True
            setStatus()


        Else
            cancel_click()
            STATE = ""
        End If

    End Sub
    Sub matilookup()
        lkrph.Enabled = False


    End Sub
    Sub nyalalookup()

        lkrph.Enabled = True


    End Sub
    Sub bersih()
        nyalalookup()
        ds2.Clear()
        ds2.Relations.Clear()
        ds5.Clear()
        ds5.Relations.Clear()
        If Not ds5.Tables("QICdm") Is Nothing Then ds5.Tables("QICdm").Clear()
        If Not dsedit.Tables("Look") Is Nothing Then dsedit.Tables("Look").Clear()
        If Not ds5.Tables("QICd") Is Nothing Then ds5.Tables("QICd").Clear()
        If Not ds2.Tables("QIC") Is Nothing Then ds2.Tables("QIC").Clear()
        If Not ds2.Tables("QICD") Is Nothing Then ds2.Tables("QICD").Clear()
        If Not ds4.Tables("QICMD") Is Nothing Then ds4.Tables("QICMD").Clear()
        If Not ds4.Tables("QICD") Is Nothing Then ds4.Tables("QICD").Clear()

        txttanggal.Text = Now.Date

        txtjdwl.Text = vbNullString

        lkrph.Properties.DataSource = Nothing


    End Sub
    Public Sub cancel_click()
        bersih()
        lkrph.EditValue = Nothing
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        cancel_click()
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data Barcode ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            State = "DELETE"
            da1 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_ctk_barcode_m a where  a.kd_departemen='" & kddep & "' and a.no_rph='" & lkrph.EditValue & "' ", sqlconn)) '<- query buat ditampilkan di LOV
            da1.Fill(ds3, "deleteq")
            da2 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_ctk_barcode_d a where  a.kd_departemen='" & kddep & "' and a.no_rph='" & lkrph.EditValue & "' ", sqlconn)) '<- query buat ditampilkan di LOV
            da2.Fill(ds3, "deleteq1")

            If Not ds3.Tables("deleteq") Is Nothing Then
                For Each rw As DataRow In ds3.Tables("deleteq").Rows
                    rw.Delete()
                Next
            End If
            If Not ds3.Tables("deleteq1") Is Nothing Then
                For Each rw As DataRow In ds3.Tables("deleteq1").Rows
                    rw.Delete()
                Next
            End If
            Try


                mb = New SqlClient.SqlCommandBuilder(da1)
                da1.UpdateCommand = mb.GetUpdateCommand()
                da1.InsertCommand = mb.GetInsertCommand()
                da1.DeleteCommand = mb.GetDeleteCommand()

                mb1 = New SqlClient.SqlCommandBuilder(da2)
                da2.UpdateCommand = mb1.GetUpdateCommand()
                da2.InsertCommand = mb1.GetInsertCommand()
                da2.DeleteCommand = mb1.GetDeleteCommand()

                da1.Update(ds3.Tables("deleteq"))
                da2.Update(ds3.Tables("deleteq1"))

                ds3.Tables("deleteq").AcceptChanges()
                ds3.Tables("deleteq1").AcceptChanges()
                showMessages("hapus SUCCES..")


                bersih()
                btnSave = False
                btnCancel = False
                btnDelete = False
                btnEdit = True
                btnAdd = True
                setStatus()


            Catch e As Exception

                ds3.Tables("deleteq").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                ds3.Tables("deleteq1").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical)

            End Try
            State = ""
        End If
    End Sub
    Sub generate_barcode(ByVal notrans As String)
        Dim dr, dr2 As SqlDataReader
        Dim n As Integer = 0
        Dim hitung_minggu, hitung_bulan As Integer
        Dim hari, minggu, bulan, tahun, tanggal_print As String
        Dim actualdate, date1, date2 As Date
        Dim kd_barang, kd_barang2, tipe_barang, ukuran_barang, Subtipe_Barang, jenis_barang, Merk_barang, Merk_Kain, tanggal_prod As String
        Dim jumlah_prod As Integer
        date1 = DateSerial(Now.Year, 1, 1)
        date2 = Now.Date
        hari = Now.DayOfWeek
        tahun = Now.Year.ToString.Substring(2, 2)
        hitung_bulan = Now.Month
        If hitung_bulan < 10 Then
            bulan = "0" & hitung_bulan
        Else
            bulan = hitung_bulan
        End If
        hitung_minggu = DatePart(DateInterval.WeekOfYear, date2, FirstDayOfWeek.Monday, FirstWeekOfYear.System)
        If hitung_minggu < 10 Then
            minggu = "0" & hitung_minggu.ToString
        Else
            minggu = hitung_minggu.ToString
        End If

        'MsgBox(tahun & bulan & hari & minggu)
        tanggal_print = tahun & bulan & hari & minggu
        dr = New SqlClient.SqlCommand("select b.*,d.Nama_Barang,d.kd_kain,e.Merk_Kain,f.Nama_Ukuran, " & _
                                      "t.Nama_Tipe,st.Nama_Sub_Tipe, j.Nama_Jenis, m.Nama_Merk, bm.tanggal, rp.kd_jadwal " & _
                                      "from PROD.dbo.PROD_ctk_barcode_d b " & _
                                      "INNER JOIN SIF.dbo.SIF_barang d " & _
                                      "on b.kd_barang = d.Kode_Barang " & _
                                      "INNER JOIN SIF.dbo.SIF_Kain e " & _
                                      "on d.kd_kain = e.Kode_Kain " & _
                                      "INNER JOIN SIF.dbo.SIF_Ukuran f  " & _
                                      "on d.kd_ukuran=f.kode_ukuran  " & _
                                      "INNER JOIN SIF.dbo.SIF_Tipe t " & _
                                      "on d.kd_tipe= t.Kode_Tipe " & _
                                      "inner join SIF.dbo.SIF_Sub_Tipe st " & _
                                      "on st.Kd_Sub_Tipe = d.kd_sub_tipe " & _
                                      "INNER JOIN SIF.dbo.SIF_Jenis_Barang j " & _
                                      "on d.kd_jenis = j.Kd_Jns_Brg " & _
                                      "INNER JOIN SIF.dbo.SIF_Merk m " & _
                                      "on d.kd_merk = m.Kode_Merk " & _
                                      "INNER JOIN PROD.dbo.PROD_ctk_barcode_m bm " & _
                                      "on b.no_rph = bm.no_rph " & _
                                      "INNER JOIN  PROD.dbo.PROD_rcn_prod_m rp " & _
                                      "on rp.no_rph = bm.no_rph " & _
                                      "and b.no_rph= '" & lkrph.EditValue & "' and b.keterangan='" & notrans & "' and b.cetak_barcode='Y'", sqlconn).ExecuteReader
        While dr.Read
            kd_barang = dr.Item("kd_barang")
            dr2 = New SqlClient.SqlCommand("select b.*,d.Nama_Barang,d.kd_kain,e.Merk_Kain,f.Nama_Ukuran, ISNULL(sod.Keterangan,f.Nama_Ukuran) as Keterangan, " & _
                                           "t.Nama_Tipe, st.Nama_Sub_Tipe, j.Nama_Jenis, m.Nama_Merk, bm.tanggal, rp.kd_jadwal, bd.cetak_barcode " & _
                                           "from PROD.dbo.PROD_rcn_prod_d b " & _
                                           "left join SALES.dbo.SALES_SO_D sod " & _
                                           "on b.no_sp = sod.No_sp and b.no_sp_dtl = sod.No_seq " & _
                                           "left join PROD.dbo.PROD_ctk_barcode_d bd " & _
                                           "on bd.no_rph = b.no_rph and bd.kd_barang = b.kd_barang " & _
                                           "INNER JOIN SIF.dbo.SIF_barang d  " & _
                                           "on b.kd_barang = d.Kode_Barang  " & _
                                           "INNER JOIN SIF.dbo.SIF_Kain e  " & _
                                           "on d.kd_kain = e.Kode_Kain  " & _
                                           "INNER JOIN SIF.dbo.SIF_Ukuran f  " & _
                                           "on d.kd_ukuran=f.kode_ukuran  " & _
                                           "INNER JOIN SIF.dbo.SIF_Tipe t  " & _
                                           "on d.kd_tipe= t.Kode_Tipe and t.Kode_Merk = d.kd_merk " & _
                                           "inner join SIF.dbo.SIF_Sub_Tipe st " & _
                                           "on st.Kd_Sub_Tipe = d.kd_sub_tipe " & _
                                           "INNER JOIN SIF.dbo.SIF_Jenis_Barang j " & _
                                           "on d.kd_jenis = j.Kd_Jns_Brg  " & _
                                           "INNER JOIN SIF.dbo.SIF_Merk m " & _
                                           "on d.kd_merk = m.Kode_Merk " & _
                                           "INNER JOIN PROD.dbo.PROD_ctk_barcode_m bm " & _
                                           "on b.no_rph = bm.no_rph " & _
                                           "INNER JOIN  PROD.dbo.PROD_rcn_prod_m rp " & _
                                           "on rp.no_rph = bm.no_rph " & _
                                           "and b.no_rph= '" & lkrph.EditValue & "' " & _
                                           "and b.kd_barang = '" & kd_barang & "' " & _
                                           "and bd.cetak_barcode='Y'", sqlconn).ExecuteReader
            While dr2.Read
                n += 1
                kd_barang2 = dr2.Item("kd_barang")
                tipe_barang = IIf(dr2.Item("Nama_Tipe") = "N/A", "", dr2.Item("Nama_Tipe"))
                ukuran_barang = IIf(dr2.Item("Keterangan") = "N/A", "", dr2.Item("Keterangan"))
                Subtipe_Barang = IIf(dr2.Item("Nama_Sub_Tipe") = "N/A", "", dr2.Item("Nama_Sub_Tipe"))
                Merk_Kain = IIf(dr2.Item("Merk_Kain") = "N/A", "", dr2.Item("Merk_Kain"))
                jenis_barang = IIf(dr2.Item("Nama_Jenis") = "N/A", "", dr2.Item("Nama_Jenis"))
                Merk_barang = IIf(dr2.Item("Nama_Merk") = "N/A", "", dr2.Item("Nama_Merk"))
                ' MsgBox(dr.Item("tanggal"), MsgBoxStyle.Information)
                tanggal_prod = Mid(dr2.Item("tanggal"), 9, 2) & Mid(dr2.Item("tanggal"), 4, 2) & Mid(dr2.Item("tanggal"), 1, 2) & Mid(dr2.Item("kd_jadwal"), 2, 1)
                jumlah_prod = dr2.Item("jumlah")


                Dim i As Integer = FreeFile()
                FileOpen(i, App_Path() & "\contoh" & n & ".txt", OpenMode.Output)
                ' FileOpen(i, App_Path() & "\contoh.txt", OpenMode.Output)
                PrintLine(i, "SYSVAR(18)=0")
                PrintLine(i, "INPUT OFF")
                PrintLine(i, "NEW")
                PrintLine(i, "OPEN " & """tmp:setup.sys""" & " for output as #2")
                PrintLine(i, "PRINT#2, " & """MEDIA,MEDIA SIZE,LENGTH,599""")
                PrintLine(i, "PRINT#2, " & """MEDIA,MEDIA SIZE,XSTART,0""")
                PrintLine(i, "PRINT#2, " & """MEDIA,MEDIA SIZE,WIDTH,832""")
                PrintLine(i, "PRINT#2, " & """MEDIA,MEDIA TYPE,LABEL (w GAPS)""")
                PrintLine(i, "PRINT#2, " & """FEEDADJ,STARTADJ,-80""")
                PrintLine(i, "PRINT#2, " & """FEEDADJ,STOPADJ,0""")
                PrintLine(i, "PRINT#2, " & """PRINT DEFS,PRINT SPEED,150""")
                PrintLine(i, "PRINT#2, " & """MEDIA,PAPER TYPE,TRANSFER""")
                PrintLine(i, "PRINT#2, " & """MEDIA,PAPER TYPE,TRANSFER,RIBBON CONSTANT,90""")
                PrintLine(i, "PRINT#2, " & """MEDIA,PAPER TYPE,TRANSFER,RIBBON FACTOR,25""")
                PrintLine(i, "PRINT#2, " & """MEDIA,PAPER TYPE,TRANSFER,LABEL OFFSET,0""")
                PrintLine(i, "PRINT#2, " & """MEDIA,CONTRAST,+0%""")
                PrintLine(i, "PRINT#2, " & """RFID,OFF""")
                PrintLine(i, "CLOSE #2")
                PrintLine(i, "Setup " & """tmp:setup.sys""")
                PrintLine(i, "Kill " & """tmp:setup.sys""")
                PrintLine(i, "OPTIMIZE " & """BATCH""" & " ON")
                PrintLine(i, "LTS& OFF")
                PrintLine(i, "SYSVAR(48)=0")
                PrintLine(i, "FORMAT INPUT CHR$(2),CHR$(3),CHR$(13)")
                PrintLine(i, "LAYOUT INPUT " & """tmp:LBLSOFT.LAY""")
                PrintLine(i, "CLIP ON")
                PrintLine(i, "CLIP BARCODE ON")
                PrintLine(i, "XORMODE OFF")
                PrintLine(i, "AN 7")
                PrintLine(i, "MAG 1,1")
                PrintLine(i, "BF " & """Monospace 821 BT""" & ",7,0,0,1,1 ON")
                PrintLine(i, "PP 33,184:DIR 1:BT " & """CODE128""" & ":BM 2:BH 112:PB """ & kd_barang2 & """")
                PrintLine(i, "NASC 8")
                PrintLine(i, "AN 7")
                PrintLine(i, "DIR 1:PP 38,517:FT " & """Swiss 721 Bold Condensed BT""" & ",14,0,100:NI:PT """ & tipe_barang & " " & Subtipe_Barang & """")
                PrintLine(i, "PP 40,416:NI:PT """ & ukuran_barang & """")
                PrintLine(i, "PP 40,367:NI:PT """ & Merk_Kain & """")
                PrintLine(i, "PP 40,467:NI:PT """ & jenis_barang & """")
                PrintLine(i, "PP 40,568:NI:PT """ & Merk_barang & """")
                PrintLine(i, "PP 31,221:FT " & """Swiss 721 Bold Condensed BT""" & ",11,0,100:NI:PT """ & tanggal_print & """")
                PrintLine(i, "LAYOUT END")
                PrintLine(i, "LAYOUT RUN " & """tmp:LBLSOFT.LAY""")
                PrintLine(i, "INPUT ON")
                PrintLine(i, "PF " & jumlah_prod)
                PrintLine(i, "PRINT KEY OFF")
                FileClose(i)
                '  MsgBox("File tercreate", MsgBoxStyle.Information)

                Dim p As New Process
                Dim info As New ProcessStartInfo
                info.FileName = App_Path() & "\contoh" & n & ".txt"
                'info.FileName = App_Path() & "\contoh.txt"
                info.Verb = "print"
                p.StartInfo = info
                p.Start()
            End While
            dr2.Close()
        End While
        dr.Close()
    End Sub
    Public Sub cetak_click()
        



       

        'Dim tp As New TextPrint(My.Computer.FileSystem.ReadAllText("D:\contoh.txt"))
        'tp.Print()
        'Dim viewx As ColumnView = GridView2.Columns.View
        'For rw As Integer = 0 To GridView2.RowCount - 1

        '    If viewx.GetRowCellValue(rw, "cetak_barcode").ToString = "Y" Then
        '        'If viewx.GetRowCellValue(rw, "sts_nota") = "NOTA" Then
        '        'MsgBox(viewx.GetRowCellValue(rw, "sts_nota").ToString)
        'callReport(App_Path() & "\report\Barcode_Textfile.rpt", "", "vno_rph=" & lkrph.EditValue.ToString)
        'End If
        'End If


        'Next


    End Sub

    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        delete_click()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        save_click()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        edit_click()
    End Sub

    Private Sub GridControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridControl1.Click

    End Sub
End Class