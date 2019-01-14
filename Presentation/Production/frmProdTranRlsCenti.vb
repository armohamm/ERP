Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Public Class frmProdTranRlsCenti

    Dim ds1, ds2, ds3, ds4, ds5, ds6, dsedit As New DataSet
    Dim da1, da2, da3, da4, da5, da6, daedit As New SqlDataAdapter
    Dim row, rows As DataRow
    Dim mb, mb1 As New SqlCommandBuilder
    Dim prn As frmMain
    Dim nilai As String
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Dim rl, rl1, rl2 As DataRelation
    Public State, kode, kode1, kode2, kode3, kode4, kode5, jumlah As String

    Dim l, k, j, m As Integer


    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Private Sub frmProdTranRlsCenti_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        State = "ADD"
        prn = getParent(Me)


        da1 = New SqlDataAdapter(New SqlCommand("select distinct no_rph from PROD.dbo.PROD_spk_centi_m where kd_departemen='" & kddep & "'", sqlconn))
        da1.Fill(ds1, "rph")
        lkrph.Properties.DataSource = ds1.Tables("rph")
        lkrph.Properties.ValueMember = "no_rph"
        lkrph.Properties.DisplayMember = "no_rph"

        da5 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_rls_spk_centi_m  ", sqlconn))
        da5.Fill(ds5, "SPKM")
    End Sub

    Public Sub add_click()

        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnAdd = False
        State = "ADD"
        setStatus()

        nyalalookup()
    End Sub

    Private Sub lkkegiatan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkkegiatan.EditValueChanged
        ds4.Relations.Clear()
        If Not ds4.Tables("SoBox") Is Nothing Then ds4.Tables("SoBox").Clear()
        If Not ds4.Tables("load") Is Nothing Then ds4.Tables("load").Clear()

        lkkegtn.EditValue = vbNullString

        If Not ds3.Tables("kegiatan") Is Nothing Then ds3.Tables("kegiatan").Clear()
        da3 = New SqlDataAdapter(New SqlCommand("select distinct kd_kegiatan_spk,desc_data from PROD.dbo.PROD_spk_centi_m a,SIF.dbo.SIF_Gen_Reff_D b where no_spk='" & lkspk.EditValue & "' and a.kd_kegiatan='" & lkkegiatan.EditValue & "' and a.no_rph='" & lkrph.EditValue & "' and b.ref_role='PROD' and b.id_Ref_File='SPK'and a.kd_kegiatan_spk=b.id_data ", sqlconn))
        da3.Fill(ds3, "kegiatan")
        lkkegtn.Properties.DataSource = ds3.Tables("kegiatan")
        lkkegtn.Properties.ValueMember = "kd_kegiatan_spk"
        lkkegtn.Properties.DisplayMember = "desc_data"

        If Not ds3.Tables("jamkerja") Is Nothing Then ds3.Tables("jamkerja").Clear()
        da3 = New SqlDataAdapter(New SqlCommand("select  id_data,desc_data from SIF.dbo.SIF_Gen_Reff_D where ref_role='PROD' and id_ref_file='JAMPROD'", sqlconn))
        da3.Fill(ds3, "jamkerja")
        lkjamkerja.Properties.DataSource = ds3.Tables("jamkerja")
        lkjamkerja.Properties.ValueMember = "id_data"
        lkjamkerja.Properties.DisplayMember = "desc_data"


    End Sub

    Private Sub loadGrid()
        ds4.Relations.Clear()
        If Not ds4.Tables("load") Is Nothing Then ds4.Tables("load").Clear()
        If Not ds4.Tables("SoBox") Is Nothing Then ds4.Tables("SoBox").Clear()
        If Not ds6.Tables("SPKMD") Is Nothing Then ds6.Tables("SPKMD").Clear()
        'da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.prod_spk_centi_d where no_spk='" & lkspk.EditValue & "' and kd_kegiatan ='" & lkkegiatan.EditValue & "'and kd_kegiatan_spk= '" & lkkegtn.EditValue & "'", sqlconn))
        da4 = New SqlDataAdapter(New SqlCommand("select a.no_rph, a.no_sp, a.no_sp_dtl, a.no_spk, a.kd_kegiatan, a.kd_kegiatan_spk," & _
                                                        "a.kd_barang, sum(isnull (a.jumlah_produksi, 0) - isnull (b.jumlah_kerja, 0)) as jumlah_produksi, " & _
                                                        "sum(isnull (b.jumlah_kerja, 0)) as jumlah_kerja, sum(isnull (a.jumlah_produksi, 0) - isnull (b.jumlah_kerja, 0)) as jumlah_sisa " & _
                                                "from prod.dbo.prod_spk_centi_d a " & _
                                                "left outer join prod.dbo.prod_rls_spk_centi_d b on (a.no_rph = b.no_rph) " & _
                                                "and (a.no_spk = b.no_spk) " & _
                                                "and (a.kd_kegiatan = b.kd_kegiatan) " & _
                                                "and (a.kd_kegiatan_spk = b.kd_kegiatan_spk) " & _
                                                "and (a.kd_barang = b.kd_barang) " & _
                                                "where a.no_rph='" & lkrph.EditValue & "' " & _
                                                "and a.no_spk='" & lkspk.EditValue & "' " & _
                                                "and a.kd_kegiatan ='" & lkkegiatan.EditValue & "' " & _
                                                "and a.kd_kegiatan_spk= '" & lkkegtn.EditValue & "' " & _
                                                "group by a.no_rph, a.no_sp, a.no_sp_dtl, a.no_spk, a.kd_kegiatan, a.kd_kegiatan_spk, a.kd_barang", sqlconn))
        da4.Fill(ds4, "load")
        gControl.DataSource = ds4.Tables("load")
        For B As Integer = 0 To ds4.Tables("load").Rows.Count - 1
            ds4.Tables("load").Rows(B).Item("jumlah_kerja") = ds4.Tables("load").Rows(B).Item("jumlah_produksi")
        Next

        da6 = New SqlDataAdapter(New SqlCommand("SELECT * from SALES.dbo.SALES_SOBOX_D ", sqlconn))
        da6.Fill(ds4, "SoBox")

        rl = ds4.Relations.Add("Detail", ds4.Tables("load").Columns("no_sp"), ds4.Tables("SoBox").Columns("No_sp"), False)

        gControl.DataSource = ds4.Tables("load")
        gControl.LevelTree.Nodes.Add("Detail", GridView1)

        da6 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_rls_spk_centi_d where no_spk='" & lkspk.EditValue & "' and kd_kegiatan='" & lkkegiatan.EditValue & "' and kd_kegiatan_spk= '" & lkkegtn.EditValue & "'", sqlconn))
        da6.Fill(ds6, "SPKMD")

    End Sub
    Private Sub loadlookup()
        If Not ds4.Tables("loadnama") Is Nothing Then ds4.Tables("loadnama").Clear()
        If Not ds4.Tables("loadtipe") Is Nothing Then ds4.Tables("loadtipe").Clear()
        If Not ds4.Tables("loadkain") Is Nothing Then ds4.Tables("loadkain").Clear()
        If Not ds4.Tables("loadukuran") Is Nothing Then ds4.Tables("loadukuran").Clear()

        da3 = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        da3.Fill(ds4, "loadnama")
        lkbarang.DataSource = ds4.Tables("loadnama")
        lkbarang.DisplayMember = "Nama_Barang"
        lkbarang.ValueMember = "Kode_Barang"
        da3 = New SqlDataAdapter(New SqlCommand("select a.Kode_Barang, b.Nama_Tipe from SIF.dbo.SIF_Barang a, SIF.dbo.SIF_Tipe b WHERE a.kd_tipe=b.Kode_Tipe", sqlconn))
        da3.Fill(ds4, "loadtipe")
        lktipe.DataSource = ds4.Tables("loadtipe")
        lktipe.DisplayMember = "Nama_Tipe"
        lktipe.ValueMember = "Kode_Barang"
        da3 = New SqlDataAdapter(New SqlCommand("select a.Kode_Barang, b.Merk_Kain from SIF.dbo.SIF_Barang a, SIF.dbo.SIF_Kain b WHERE a.kd_kain=b.Kode_Kain", sqlconn))
        da3.Fill(ds4, "loadkain")
        lkkain.DataSource = ds4.Tables("loadkain")
        lkkain.DisplayMember = "Merk_Kain"
        lkkain.ValueMember = "Kode_Barang"
        da3 = New SqlDataAdapter(New SqlCommand("select a.Kode_Barang, b.Nama_Ukuran from SIF.dbo.SIF_Barang a, SIF.dbo.SIF_Ukuran b where a.kd_ukuran=b.Kode_Ukuran", sqlconn))
        da3.Fill(ds4, "loadukuran")
        lkukuran.DataSource = ds4.Tables("loadukuran")
        lkukuran.DisplayMember = "Nama_Ukuran"
        lkukuran.ValueMember = "Kode_Barang"
    End Sub

    Public Sub save_click()
        If State = "ADD" Then


            kode5 = getNoTrans("PRODSPKRLS", getTanggal)
            row = ds5.Tables("SPKM").NewRow
            row.Item("no_spk_rls") = kode5
            row.Item("tanggal") = txttanggal.Text
            row.Item("no_rph") = lkrph.EditValue
            row.Item("no_spk") = lkspk.EditValue
            row.Item("kd_kegiatan_spk") = lkkegtn.EditValue
            row.Item("kd_kegiatan") = lkkegiatan.EditValue
            row.Item("kd_jam") = lkjamkerja.EditValue
            row.Item("kd_departemen") = kddep
            row.Item("kd_cabang") = getKodeCabang()
            row.Item("Last_Create_Date") = Now
            row.Item("Last_Created_By") = umum.username
            row.Item("Program_Name") = Me.Name
            ds5.Tables("SPKM").Rows.Add(row)

        ElseIf State = "EDIT" Then

            row = ds5.Tables("SPKMq").Rows(0)
            row.Item("tanggal") = txttanggal.Text
            row.Item("no_rph") = lkrph.EditValue
            row.Item("no_spk") = lkspk.EditValue
            row.Item("kd_kegiatan_spk") = lkkegtn.EditValue
            row.Item("kd_kegiatan") = lkkegiatan.EditValue
            row.Item("kd_jam") = lkjamkerja.EditValue
            row.Item("kd_departemen") = kddep
            row.Item("kd_cabang") = getKodeCabang()
            row.Item("Last_Create_Date") = Now
            row.Item("Last_Created_By") = umum.username
            row.Item("Program_Name") = Me.Name


        End If

        If State = "ADD" Then
            For l As Integer = 0 To gView.RowCount - 1

                rows = ds6.Tables("SPKMD").NewRow
                rows.Item("no_spk_rls") = kode5
                rows.Item("no_rph") = lkrph.EditValue
                rows.Item("no_spk") = lkspk.EditValue
                rows.Item("kd_kegiatan_spk") = lkkegtn.EditValue
                rows.Item("kd_kegiatan") = lkkegiatan.EditValue
                rows.Item("kd_departemen") = kddep
                rows.Item("kd_cabang") = getKodeCabang()
                rows.Item("Last_Create_Date") = Now
                rows.Item("Last_Created_By") = umum.username
                rows.Item("Program_Name") = Me.Name
                rows.Item("no_sp") = ds4.Tables("load").Rows(l).Item("no_sp").ToString
                rows.Item("no_sp_dtl") = ds4.Tables("load").Rows(l).Item("no_sp_dtl").ToString
                rows.Item("kd_barang") = ds4.Tables("load").Rows(l).Item("kd_barang").ToString
                rows.Item("jumlah_kerja") = ds4.Tables("load").Rows(l).Item("jumlah_kerja").ToString
                rows.Item("jumlah_produksi") = ds4.Tables("load").Rows(l).Item("jumlah_produksi").ToString
                rows.Item("jumlah_sisa") = ds4.Tables("load").Rows(l).Item("jumlah_sisa").ToString

                ds6.Tables("SPKMD").Rows.Add(rows)
            Next



        ElseIf State = "EDIT" Then


            For l As Integer = 0 To gView.RowCount - 1


                rows = ds4.Tables("loadq").Rows(0)
                rows.Item("no_rph") = lkrph.EditValue
                rows.Item("no_spk") = lkspk.EditValue

                rows.Item("kd_kegiatan_spk") = lkkegtn.EditValue
                rows.Item("kd_kegiatan") = lkkegiatan.EditValue
                rows.Item("kd_departemen") = kddep
                rows.Item("kd_cabang") = getKodeCabang()
                rows.Item("Last_Create_Date") = Now
                rows.Item("Last_Created_By") = umum.username
                rows.Item("Program_Name") = Me.Name
                rows.Item("no_sp") = ds4.Tables("no_sp").Rows(l).Item("no_sp").ToString
                rows.Item("no_sp_dtl") = ds4.Tables("loadq").Rows(l).Item("no_sp_dtl").ToString
                rows.Item("kd_barang") = ds4.Tables("loadq").Rows(l).Item("kd_barang").ToString
                rows.Item("jumlah_kerja") = ds4.Tables("loadq").Rows(l).Item("jumlah_kerja").ToString
                rows.Item("jumlah_produksi") = ds4.Tables("loadq").Rows(l).Item("jumlah_produksi").ToString
                rows.Item("jumlah_sisa") = ds4.Tables("loadq").Rows(l).Item("jumlah_sisa").ToString

            Next

        End If


        If State = "ADD" Then
            Try


                mb = New SqlClient.SqlCommandBuilder(da5)
                da5.UpdateCommand = mb.GetUpdateCommand()
                da5.InsertCommand = mb.GetInsertCommand()
                da5.DeleteCommand = mb.GetDeleteCommand()

                mb1 = New SqlClient.SqlCommandBuilder(da6)
                da6.UpdateCommand = mb1.GetUpdateCommand()
                da6.InsertCommand = mb1.GetInsertCommand()
                da6.DeleteCommand = mb1.GetDeleteCommand()



                da5.Update(ds5.Tables("SPKM"))
                da6.Update(ds6.Tables("SPKMD"))

                'ds5.Tables("SPKM").AcceptChanges()
                'ds6.Tables("SPKMD").AcceptChanges()
                showMessages("Saved..")

                txtjumlah.Text = kode5
                State = ""
                'State = "EDIT"
                'If Not ds4.Tables("load") Is Nothing Then ds4.Tables("load").Clear()
                'If Not ds6.Tables("SPKMD") Is Nothing Then ds6.Tables("SPKMD").Clear()



                'da6 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.prod_rls_spk_centi_d where no_spk='" & lkspk.EditValue & "' and kd_kegiatan='" & lkkegiatan.EditValue & "' and kd_kegiatan_spk= '" & lkkegtn.EditValue & "' and no_spk_rls='" & kode5 & "'", sqlconn))
                'da6.Fill(ds6, "load1")
                'If Not ds6.Tables("load1") Is Nothing Then ds6.Tables("load1").Clear()
                'da6 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.prod_rls_spk_centi_d where no_spk='" & lkspk.EditValue & "' and kd_kegiatan='" & lkkegiatan.EditValue & "' and kd_kegiatan_spk= '" & lkkegtn.EditValue & "' and no_spk_rls='" & kode5 & "'", sqlconn))
                'da6.Fill(ds6, "load1")
                'gControl.DataSource = ds6.Tables("load1")

            Catch e As Exception

                ds5.Tables("SPKM").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                ds6.Tables("SPKMD").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical)



            End Try

        ElseIf State = "EDIT" Then

            Try


                mb = New SqlClient.SqlCommandBuilder(da5)
                da5.UpdateCommand = mb.GetUpdateCommand()
                da5.InsertCommand = mb.GetInsertCommand()
                da5.DeleteCommand = mb.GetDeleteCommand()

                mb1 = New SqlClient.SqlCommandBuilder(da4)
                da4.UpdateCommand = mb1.GetUpdateCommand()
                da4.InsertCommand = mb1.GetInsertCommand()
                da4.DeleteCommand = mb1.GetDeleteCommand()



                da4.Update(ds4.Tables("loadq"))
                da5.Update(ds5.Tables("SPKMq"))

                'ds5.Tables("SPKMq").AcceptChanges()
                showMessages("EDIT SUCCES..")

                txtjumlah.Text = rows.Item("no_spk_rls").ToString
                If Not ds4.Tables("loadq") Is Nothing Then ds4.Tables("loadq").Clear()
                If Not ds5.Tables("SPKMq") Is Nothing Then ds5.Tables("SPKMq").Clear()


                da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.prod_rls_spk_centi_d a where  a.kd_departemen='" & kddep & "' and a.no_spk_rls='" & txtjumlah.Text & "'", sqlconn)) '<- query buat ditampilkan di LOV
                da4.Fill(ds4, "loadq")
                If Not ds4.Tables("loadq") Is Nothing Then ds4.Tables("loadq").Clear()
                da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.prod_rls_spk_centi_d a where  a.kd_departemen='" & kddep & "' and a.no_spk_rls='" & txtjumlah.Text & "'", sqlconn)) '<- query buat ditampilkan di LOV
                da4.Fill(ds4, "loadq")
                gControl.DataSource = ds4.Tables("loadq")
            Catch e As Exception

                ds4.Tables("loadq").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                ds5.Tables("SPKMq").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical)

            End Try

        End If

    End Sub
    Sub matilookup()
        lkspk.Enabled = False
        lkkegtn.Enabled = False
        lkkegiatan.Enabled = False


    End Sub
    Sub nyalalookup()
        lkspk.Enabled = True
        lkkegtn.Enabled = True
        lkkegiatan.Enabled = True

    End Sub

    Public Sub edit_click()

        State = "EDIT"

        dsedit = New DataSet
        daedit = New SqlDataAdapter(New SqlCommand("select no_rph as [NO RPH],no_spk as [No Spk] ,kd_kegiatan_spk as [KODE SPK],desc_data as [NAMA KEGIATAN],no_spk_rls as [NoSpkRealisasi]  from PROD.dbo.PROD_rls_spk_centi_m a,SIF.dbo.SIF_Gen_Reff_D b where b.ref_role='PROD' and b.id_Ref_File='SPK'and a.kd_kegiatan_spk=b.id_data and a.kd_departemen='" & kddep & "'", sqlconn)) '<- query buat ditampilkan di LOV
        daedit.Fill(dsedit, "LookSPK")
        frmCari.set_dso(dsedit.Tables("LookSPK"))
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then

            kode4 = frmCari.row("NoSpkRealisasi").ToString
            'kode1 = frmCari.row("No Spk").ToString
            kode3 = frmCari.row("KODE SPK").ToString

            da5 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rls_spk_centi_m a where  a.kd_departemen='" & kddep & "' and a.no_spk_rls='" & kode4 & "' and kd_kegiatan_spk='" & kode3 & "' ", sqlconn)) '<- query buat ditampilkan di LOV
            da5.Fill(ds5, "SPKMq")

            da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.prod_rls_spk_centi_d a where  a.kd_departemen='" & kddep & "' and a.no_spk_rls='" & kode4 & "' and kd_kegiatan_spk='" & kode3 & "' ", sqlconn)) '<- query buat ditampilkan di LOV
            da4.Fill(ds4, "loadq")


            gControl.DataSource = ds4.Tables("loadq")

            row = ds5.Tables("SPKMq").Rows(0)

            txttanggal.Text = row.Item("tanggal").ToString
            lkrph.EditValue = row.Item("no_rph").ToString
            lkspk.EditValue = row.Item("no_spk").ToString
            lkkegiatan.EditValue = row.Item("kd_kegiatan").ToString
            lkkegtn.EditValue = row.Item("kd_kegiatan_spk").ToString
            txtjumlah.Text = row.Item("no_spk_rls").ToString
            lkjamkerja.EditValue = row.Item("kd_jam").ToString
            txtjumlah.Text = row.Item("no_spk_rls").ToString

            matilookup()
            btnSave = True
            btnCancel = True
            btnAdd = False
            btnEdit = False
            btnDelete = True
            setStatus()


        Else
            cancel_click()
            State = ""
        End If

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
        State = ""
    End Sub
    Sub bersih()
        'ds4.Relations.Clear()
        'If Not ds4.Tables("SoBox") Is Nothing Then ds4.Tables("SoBox").Clear()
        ''If Not ds5.Tables("SPKM") Is Nothing Then ds5.Tables("SPKM").Clear()
        ''If Not ds5.Tables("SPKMq") Is Nothing Then ds5.Tables("SPKMq").Clear()
        'If Not ds4.Tables("load") Is Nothing Then ds4.Tables("load").Clear()
        'If Not ds4.Tables("loadq") Is Nothing Then ds4.Tables("loadq").Clear()
        'If Not ds6.Tables("load1") Is Nothing Then ds6.Tables("load1").Clear()
        'If Not ds6.Tables("SPKMD") Is Nothing Then ds6.Tables("SPKMD").Clear()


        'txttanggal.Text = Now.Date
        'lkrph.Text = ""
        'txtjdwl.Text = vbNullString
        'lkspk.Text = vbNullString
        'lkkegiatan.Text = vbNullString
        'txtjumlah.Text = vbNullString
        'lkkegtn.Text = vbNullString
        'lkjamkerja.Text = vbNullString

        nyalalookup()
    End Sub

    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data Realisasi SPK ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            State = "DELETE"
            If Not ds5.Tables("SPKMq") Is Nothing Then
                For Each rw As DataRow In ds5.Tables("SPKMq").Rows
                    rw.Delete()
                Next
            End If
            If Not ds4.Tables("loadq") Is Nothing Then
                For Each rw As DataRow In ds4.Tables("loadq").Rows
                    rw.Delete()
                Next
            End If
            Try


                mb = New SqlClient.SqlCommandBuilder(da5)
                da5.UpdateCommand = mb.GetUpdateCommand()
                da5.InsertCommand = mb.GetInsertCommand()
                da5.DeleteCommand = mb.GetDeleteCommand()

                mb1 = New SqlClient.SqlCommandBuilder(da4)
                da4.UpdateCommand = mb1.GetUpdateCommand()
                da4.InsertCommand = mb1.GetInsertCommand()
                da4.DeleteCommand = mb1.GetDeleteCommand()



                da4.Update(ds4.Tables("loadq"))
                da5.Update(ds5.Tables("SPKMq"))

                ds4.Tables("loadq").AcceptChanges()
                ds5.Tables("SPKMq").AcceptChanges()
                showMessages("hapus SUCCES..")



                da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.prod_rls_spk_centi_d a where  a.kd_departemen='" & kddep & "' and a.no_spk_rls='" & txtjumlah.Text & "'", sqlconn)) '<- query buat ditampilkan di LOV
                da4.Fill(ds4, "loadq")
                If Not ds4.Tables("loadq") Is Nothing Then ds4.Tables("loadq").Clear()
                da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.prod_rls_spk_centi_d a where  a.kd_departemen='" & kddep & "' and a.no_spk_rls='" & txtjumlah.Text & "'", sqlconn)) '<- query buat ditampilkan di LOV
                da4.Fill(ds4, "loadq")
                gControl.DataSource = ds4.Tables("loadq")
            Catch e As Exception

                ds4.Tables("loadq").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                ds5.Tables("SPKMq").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical)

            End Try
            State = ""
        End If
    End Sub

    Private Sub lkrph_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkrph.EditValueChanged
        ds4.Relations.Clear()
        If Not ds4.Tables("SoBox") Is Nothing Then ds4.Tables("SoBox").Clear()
        If Not ds4.Tables("load") Is Nothing Then ds4.Tables("load").Clear()
        lkspk.EditValue = vbNullString
        lkkegiatan.EditValue = vbNullString
        lkkegtn.EditValue = vbNullString


        If Not ds1.Tables("nospk") Is Nothing Then ds1.Tables("nospk").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select distinct no_spk from PROD.dbo.PROD_spk_centi_m where kd_departemen='" & kddep & "' and no_rph= '" & lkrph.EditValue & "'", sqlconn))
        da1.Fill(ds1, "nospk")
        lkspk.Properties.DataSource = ds1.Tables("nospk")
        lkspk.Properties.ValueMember = "no_spk"
        lkspk.Properties.DisplayMember = "no_spk"
    End Sub

    Private Sub lkspk_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkspk.EditValueChanged

        ds4.Relations.Clear()
        If Not ds4.Tables("SoBox") Is Nothing Then ds4.Tables("SoBox").Clear()
        If Not ds4.Tables("load") Is Nothing Then ds4.Tables("load").Clear()

        txttanggal.Text = vbNullString
        lkkegiatan.EditValue = vbNullString
        lkkegtn.EditValue = vbNullString

        If Not ds2.Tables("kegiatanspk") Is Nothing Then ds2.Tables("kegiatanspk").Clear()
        If Not ds1.Tables("isispk") Is Nothing Then ds1.Tables("isispk").Clear()

        da1 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rcn_prod_m a,PROD.dbo.PROD_spk_centi_m b,SIF.dbo.SIF_Gen_Reff_D c where b.no_spk='" & lkspk.EditValue & "' and a.no_rph=b.no_rph and a.kd_jadwal=c.id_data and c.ref_role='PROD' and c.id_Ref_File='JDWKRJ'", sqlconn))
        da1.Fill(ds1, "isispk")

        lkrph.EditValue = ds1.Tables("isispk").Rows(0).Item("no_rph").ToString
        txtjdwl.Text = ds1.Tables("isispk").Rows(0).Item("desc_data").ToString
        txttanggal.Text = Now.Date

        da2 = New SqlDataAdapter(New SqlCommand("select distinct kd_kegiatan,desc_data from PROD.dbo.PROD_spk_centi_m a,SIF.dbo.SIF_Gen_Reff_D b where a.no_spk='" & lkspk.EditValue & "' and a.no_rph='" & lkrph.EditValue & "'and b.ref_role='PROD' and b.id_Ref_File='KGTSPK'and a.kd_kegiatan=b.id_data  ", sqlconn))
        da2.Fill(ds2, "kegiatanspk")
        lkkegiatan.Properties.DataSource = ds2.Tables("kegiatanspk")
        lkkegiatan.Properties.ValueMember = "kd_kegiatan"
        lkkegiatan.Properties.DisplayMember = "desc_data"

    End Sub

    Private Sub lkkegtn_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkkegtn.EditValueChanged
        If State = "ADD" Then
            loadGrid()
            loadlookup()
        ElseIf State = "EDIT" Then
            loadlookup()

        End If

    End Sub

    Private Sub gView_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gView.CellValueChanged
        Dim view As ColumnView = sender

        If State = "EDIT" Then
            If e.Column Is jumlah_kerja Then
                jumlah = view.GetRowCellValue(e.RowHandle, "jumlah_produksi").ToString - view.GetRowCellValue(e.RowHandle, "jumlah_kerja").ToString

                view.SetRowCellValue(e.RowHandle, "jumlah_sisa", jumlah) '(ds4.Tables("load1").Rows(0).Item("jumlah_produksi") - ds4.Tables("load1").Rows(0).Item("jumlah_kerja")))

            End If


        ElseIf State = "ADD" Then


            If e.Column Is jumlah_kerja Then
                jumlah = view.GetRowCellValue(e.RowHandle, "jumlah_produksi").ToString - view.GetRowCellValue(e.RowHandle, "jumlah_kerja").ToString

                view.SetRowCellValue(e.RowHandle, "jumlah_sisa", jumlah)
            End If
        End If
    End Sub

    Private Sub gView_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gView.ValidateRow
        Dim isinvalid As Boolean = True
        If e.Row("jumlah_kerja") > e.Row("jumlah_produksi") Then
            gView.SetColumnError(jumlah_kerja, "Jumlah Dikerjakan tidak boleh lebih besar dari Jumlah Produksi")
            MsgBox("Jumlah Dikerjakan tidak boleh lebih besar dari Jumlah Produksi")
            isinvalid = False


        End If
        e.Valid = isinvalid

    End Sub
End Class