Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Public Class frmProdTranBarcodeUlang
    Dim ds1, ds2, ds3, ds4, ds5, ds6, dsedit As New DataSet
    Dim da1, da2, da3, da4, da5, da6, daedit, dsPost As New SqlDataAdapter
    Dim row, rows, row1, row2 As DataRow
    Dim mb, mb1, mb2, mb3 As New SqlCommandBuilder
    Dim prn As frmMain
    Dim nilai As String
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Dim isinvalid As Boolean
    Public State, kode, kode1, kode2, kode4, kode5 As String
    Public kode3 As String
    Dim rl, rl1, rl2, rl3 As DataRelation
    Dim l, k, j, m As Integer
    Dim drPost As SqlDataReader
    Dim norph, kdstok, cetak As String




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
        da1 = New SqlDataAdapter(New SqlCommand("select distinct no_rph from PROD.dbo.PROD_ctk_barcode_d where kd_departemen='" & kddep & "' and cetak_barcode='Y'", sqlconn))
        da1.Fill(ds1, "norph")
        lkrph.Properties.DataSource = ds1.Tables("norph")
        lkrph.Properties.ValueMember = "no_rph"
        lkrph.Properties.DisplayMember = "no_rph"
    End Sub
    Private Sub frmProdTranBarcodeUlang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        da2 = New SqlDataAdapter(New SqlCommand("select distinct  kd_jns_brg,Nama_Jenis from PROD.dbo.PROD_ctk_barcode_d u,SIF.dbo.SIF_barang d,SIF.dbo.SIF_Jenis_Barang h where  u.kd_barang=d.kode_barang and u.no_rph= '" & lkrph.EditValue & "' and   u.Kd_Departemen= '" & kddep & "' and d.kd_jenis=h.Kd_Jns_brg  and u.cetak_barcode='Y'", sqlconn))
        da2.Fill(ds2, "QIC")
        da3 = New SqlDataAdapter(New SqlCommand("select  * from PROD.dbo.PROD_ctk_barcode_d b,SIF.dbo.SIF_barang d,SIF.dbo.SIF_Kain e,SIF.dbo.SIF_Ukuran f where  b.kd_barang=d.kode_barang and d.kd_kain=e.kode_kain and d.kd_ukuran=f.kode_ukuran  and b.no_rph= '" & lkrph.EditValue & "' and b.cetak_barcode='Y' and  d.kd_jenis in (select   kd_jns_brg from PROD.dbo.PROD_ctk_barcode_d u,SIF.dbo.SIF_barang d,SIF.dbo.SIF_Jenis_Barang h where  u.kd_barang=d.kode_barang and u.no_rph= '" & lkrph.EditValue & "' and   u.Kd_Departemen= '" & kddep & "' and d.kd_jenis=h.Kd_Jns_brg  and u.cetak_barcode='Y') ", sqlconn))
        da3.Fill(ds2, "QICD")
        rl = ds2.Relations.Add("Detailq", ds2.Tables("QIC").Columns("kd_jns_brg"), ds2.Tables("QICD").Columns("kd_jenis"))
        GridControl1.DataSource = ds2.Tables("QIC")
        GridControl1.LevelTree.Nodes.Add("Detailq", GridView2)
        For Each rows3 As DataRow In ds2.Tables("QICD").Rows
            rows3.Item("keterangan") = "False"


        Next
        GridView1.BestFitColumns()
        GridView2.BestFitColumns()



    End Sub
    Private Sub lkrph_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkrph.EditValueChanged
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
    End Sub

    Public Sub save_click()
        

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
            If kode3 = "True" Then
                If k = 1 Then
                    da6 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_ctk_barcode_d where no_rph= '" & norph & "' and cetak_barcode='Y' and  kd_barang='" & kdstok & "' ", sqlconn))
                    da6.Fill(ds3, "ulang")

                    For Each rows As DataRow In ds3.Tables("ulang").Rows

                        rows.Item("cetak_ulang") = rows.Item("cetak_ulang").ToString + 1
                        rows.Item("Last_Create_Date") = Now
                        rows.Item("Last_Created_By") = umum.username
                        rows.Item("Program_Name") = Me.Name



                    Next
                ElseIf k >= 1 Then
                    da6 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_ctk_barcode_d where keterangan='True' ", sqlconn))
                    da6.Fill(ds3, "ulang")

                    For Each rows As DataRow In ds3.Tables("ulang").Rows

                        rows.Item("cetak_ulang") = rows.Item("cetak_ulang").ToString + 1
                        rows.Item("Last_Create_Date") = Now
                        rows.Item("Last_Created_By") = umum.username
                        rows.Item("Program_Name") = Me.Name



                    Next
                End If
            Else
                For Each rows As DataRow In ds2.Tables("QICD").Rows


                    rows.Item("Last_Create_Date") = Now
                    rows.Item("Last_Created_By") = umum.username
                    rows.Item("Program_Name") = Me.Name



                Next
            End If




        ElseIf State = "EDIT" Then
            If RepositoryItemCheckEdit1.ValueChecked = "True" Then
                If k = 1 Then
                    da6 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_ctk_barcode_d where no_rph= '" & norph & "' and cetak_barcode='Y' ", sqlconn))
                    da6.Fill(ds3, "ulang")

                    For Each rows As DataRow In ds3.Tables("ulang").Rows

                        rows.Item("cetak_ulang") = rows.Item("cetak_ulang").ToString + 1
                        rows.Item("Last_Create_Date") = Now
                        rows.Item("Last_Created_By") = umum.username
                        rows.Item("Program_Name") = Me.Name



                    Next
                ElseIf k >= 1 Then
                    da6 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_ctk_barcode_d where keterangan='True' ", sqlconn))
                    da6.Fill(ds3, "ulang")

                    For Each rows As DataRow In ds3.Tables("ulang").Rows

                        rows.Item("cetak_ulang") = rows.Item("cetak_ulang").ToString + 1
                        rows.Item("Last_Create_Date") = Now
                        rows.Item("Last_Created_By") = umum.username
                        rows.Item("Program_Name") = Me.Name



                    Next
                End If
            Else
                For Each rows As DataRow In ds3.Tables("QICd").Rows


                    rows.Item("Last_update_Date") = Now
                    rows.Item("Last_updated_By") = umum.username
                    rows.Item("Program_Name") = Me.Name


                Next
            End If

          
        End If




            If State = "EDIT1" Then
                Try

                    mb = New SqlClient.SqlCommandBuilder(da4)
                    da4.UpdateCommand = mb.GetUpdateCommand()
                    da4.InsertCommand = mb.GetInsertCommand()
                    da4.DeleteCommand = mb.GetDeleteCommand()

                'mb1 = New SqlClient.SqlCommandBuilder(da3)
                'da3.UpdateCommand = mb1.GetUpdateCommand()
                'da3.InsertCommand = mb1.GetInsertCommand()
                'da3.DeleteCommand = mb1.GetDeleteCommand()

                mb2 = New SqlClient.SqlCommandBuilder(da6)
                da6.UpdateCommand = mb2.GetUpdateCommand()
                da6.InsertCommand = mb2.GetInsertCommand()
                da6.DeleteCommand = mb2.GetDeleteCommand()



                da4.Update(ds4.Tables("QICM"))
                'da3.Update(ds2.Tables("QICD"))
                da6.Update(ds3.Tables("ulang"))

                    ds4.Tables("QICM").AcceptChanges()
                'ds2.Tables("QICD").AcceptChanges()
                    ds3.Tables("ulang").AcceptChanges()

                showMessages("Saved..")
                btnSave = False
                btnCancel = True
                btnDelete = False
                btnEdit = False
                btnAdd = False
                setStatus()
                Me.Enabled = False



                Catch e As Exception

                    ds4.Tables("QICM").RejectChanges()
                'ds2.Tables("QICD").RejectChanges()
                    ds3.Tables("ulang").RejectChanges()

                    MsgBox(e.Message, MsgBoxStyle.Critical)

                End Try



            ElseIf State = "EDIT" Then

                Try

                    mb = New SqlClient.SqlCommandBuilder(da4)
                    da4.UpdateCommand = mb.GetUpdateCommand()
                    da4.InsertCommand = mb.GetInsertCommand()
                    da4.DeleteCommand = mb.GetDeleteCommand()

                'mb1 = New SqlClient.SqlCommandBuilder(da3)
                'da3.UpdateCommand = mb1.GetUpdateCommand()
                'da3.InsertCommand = mb1.GetInsertCommand()
                'da3.DeleteCommand = mb1.GetDeleteCommand()

                mb2 = New SqlClient.SqlCommandBuilder(da6)
                da6.UpdateCommand = mb2.GetUpdateCommand()
                da6.InsertCommand = mb2.GetInsertCommand()
                da6.DeleteCommand = mb2.GetDeleteCommand()



                da4.Update(ds4.Tables("QICM"))
                'da3.Update(ds5.Tables("QICd"))
                da6.Update(ds3.Tables("ulang"))



                    ds4.Tables("QICM").AcceptChanges()
                'ds5.Tables("QICd").AcceptChanges()
                ds3.Tables("ulang").AcceptChanges()

                showMessages("EDIT..")

                btnSave = False
                btnCancel = True
                btnDelete = False
                btnEdit = False
                btnAdd = False
                setStatus()
                Me.Enabled = False
                Catch e As Exception

                    ds4.Tables("QICM").RejectChanges()
                'ds5.Tables("QICd").RejectChanges()
                ds3.Tables("ulang").RejectChanges()
                    MsgBox(e.Message, MsgBoxStyle.Critical)


                End Try


            End If




    End Sub
    Public Sub edit_click()

        State = "EDIT"
        matilookup()


        ' bila menggunakan form cari
        dsedit = New DataSet
        daedit = New SqlDataAdapter(New SqlCommand("select distinct b.no_rph ,a.tanggal,b.cetak_barcode from PROD.dbo.PROD_ctk_barcode_m a,PROD.dbo.PROD_ctk_barcode_d b where a.kd_departemen='" & kddep & "' and a.no_rph=b.no_rph and b.cetak_barcode='Y'", sqlconn)) '<- query buat ditampilkan di LOV
        daedit.Fill(dsedit, "Look")
        frmCari.set_dso(dsedit.Tables("Look"))
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then

            If Not ds1.Tables("norph") Is Nothing Then ds1.Tables("norph").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("select distinct no_rph from PROD.dbo.PROD_ctk_barcode_d where kd_departemen='" & kddep & "' and cetak_barcode='Y'", sqlconn))
            da1.Fill(ds1, "norph")
            lkrph.Properties.DataSource = ds1.Tables("norph")
            lkrph.Properties.ValueMember = "no_rph"
            lkrph.Properties.DisplayMember = "no_rph"

            kode1 = frmCari.row("no_rph").ToString
            kode2 = frmCari.row("cetak_barcode").ToString

            ds5.Relations.Clear()
            If Not ds5.Tables("QICdm") Is Nothing Then ds5.Tables("QICdm").Clear()
            If Not ds5.Tables("QICd") Is Nothing Then ds5.Tables("QICd").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("select  distinct kd_jns_brg,Nama_Jenis from PROD.dbo.PROD_ctk_barcode_d k,SIF.dbo.SIF_barang d,SIF.dbo.SIF_Jenis_Barang h where  k.kd_barang=d.kode_barang and k.no_rph= '" & kode1 & "' and   k.Kd_Departemen= '" & kddep & "' and d.kd_jenis=h.Kd_Jns_brg and k.cetak_barcode='Y' ", sqlconn)) '<- query buat ditampilkan di LOV
            da1.Fill(ds5, "QICdm")
            GridControl1.DataSource = ds5.Tables("QICdm")
            da3 = New SqlDataAdapter(New SqlCommand("select  * from PROD.dbo.PROD_ctk_barcode_d b,SIF.dbo.SIF_barang d,SIF.dbo.SIF_Kain e,SIF.dbo.SIF_Ukuran f where  b.kd_barang=d.kode_barang and d.kd_kain=e.kode_kain and d.kd_ukuran=f.kode_ukuran  and b.no_rph= '" & kode1 & "' and b.cetak_barcode='Y' and   d.kd_jenis in (select   kd_jns_brg from PROD.dbo.PROD_ctk_barcode_d u,SIF.dbo.SIF_barang d,SIF.dbo.SIF_Jenis_Barang h where  u.kd_barang=d.kode_barang and u.no_rph= '" & kode1 & "' and   u.Kd_Departemen= '" & kddep & "' and d.kd_jenis=h.Kd_Jns_brg and u.cetak_barcode='Y') ", sqlconn))
            da3.Fill(ds5, "QICd")


            rl1 = ds5.Relations.Add("Detail", ds5.Tables("QICdm").Columns("kd_jns_brg"), ds5.Tables("QICd").Columns("kd_jenis"))
            GridControl1.DataSource = ds5.Tables("QICdm")
            GridControl1.LevelTree.Nodes.Add("Detail", GridView2)
            GridView1.BestFitColumns()
            GridView2.BestFitColumns()

            loadlookup()

            row1 = ds5.Tables("QICd").Rows(0)
            lkrph.EditValue = row1("no_rph").ToString
            For Each row3 As DataRow In ds5.Tables("QICd").Rows

                row3("keterangan") = "False"



            Next

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
        GridControl1.DataSource = vbNull
        ds2.Clear()
        ds2.Relations.Clear()
        ds5.Clear()
        ds5.Relations.Clear()
        k = 0
        If Not ds5.Tables("QICdm") Is Nothing Then ds5.Tables("QICdm").Clear()
        If Not ds3.Tables("ulang") Is Nothing Then ds3.Tables("ulang").Clear()
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
    Sub bersihq()

        GridControl1.DataSource = vbNull
        ds2.Clear()
        ds2.Relations.Clear()
        ds5.Clear()
        ds5.Relations.Clear()
        If Not ds5.Tables("QICdm") Is Nothing Then ds5.Tables("QICdm").Clear()
        If Not ds5.Tables("QICd") Is Nothing Then ds5.Tables("QICd").Clear()
        If Not ds2.Tables("QIC") Is Nothing Then ds2.Tables("QIC").Clear()
        If Not ds2.Tables("QICD") Is Nothing Then ds2.Tables("QICD").Clear()
        If Not ds4.Tables("QICMD") Is Nothing Then ds4.Tables("QICMD").Clear()
    End Sub

    Private Sub GridView2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged
        Dim view As ColumnView = sender
        kode3 = view.GetRowCellValue(e.RowHandle, "keterangan").ToString
        norph = view.GetRowCellValue(e.RowHandle, "no_rph")
        kdstok = view.GetRowCellValue(e.RowHandle, "kd_barang")
        cetak = view.GetRowCellValue(e.RowHandle, "cetak_ulang")

        If kode3 = "True" Then
            k += 1

        ElseIf kode3 = "False" Then
            k -= 1

        End If


    End Sub
    Public Sub cetak_report()
        callReport(App_Path() & "\report\Barcode_Textfile.rpt", "", "vno_rph=" & lkrph.EditValue.ToString)
    End Sub

    Public Sub cetak_click()
        callReport(App_Path() & "\report\Barcode_Textfile.rpt", "", "vno_rph=" & lkrph.EditValue.ToString)
    End Sub

End Class