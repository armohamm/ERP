Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Data

Public Class frmProdTranSpkServ


    Dim ds1, ds2, ds3, ds4, ds5, ds6, ds8, dsedit As New DataSet
    Dim da1, da2, da3, da4, da5, da6, da8, daedit As New SqlDataAdapter
    Dim row, rows As DataRow
    Dim mb, mb1 As New SqlCommandBuilder
    Dim prn As frmMain
    Dim nilai As String
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Dim Lebar3, Lebar4, Lebar5, x As Double
    Dim Lebar1, Lebar2 As String
    Public State, kode, kode1, kode2, kode3, kode4, kode5, TEMPLATE As String
    Private Sub kapasits_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles kapasits.KeyPress
        Select Case Asc(e.KeyChar)
            'Case 65 To 90 'dari a-z
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 32, 8, 46, 40, 41, 43
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
    Public Sub setStatus()

        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Private Sub frmProdTranSpk_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()

        prn = getParent(Me)
        If Not ds1.Tables("rph") Is Nothing Then ds1.Tables("rph").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select distinct a.no_rph from " & _
                                                "PROD.dbo.PROD_spk_m a " & _
                                                "inner join PROD.dbo.PROD_rcn_prod_m m " & _
                                                "on m.no_rph = a.no_rph " & _
                                                "where a.kd_departemen='" & kddep & "' and m.jns_produksi = 'SERVICE'", sqlconn))
        da1.Fill(ds1, "rph")
        lkrph.Properties.DataSource = ds1.Tables("rph")
        lkrph.Properties.ValueMember = "no_rph"
        lkrph.Properties.DisplayMember = "no_rph"
        da5 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_spk_m  ", sqlconn))
        da5.Fill(ds5, "SPKM")

    End Sub

    Public Sub add_click()
        State = "EDIT"
        txttanggal.Text = Now.Date

        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnAdd = False

        setStatus()
    End Sub

    Private Sub loadGrid()
        If Not ds4.Tables("loadab") Is Nothing Then ds4.Tables("loadab").Clear()

        da4 = New SqlDataAdapter(New SqlCommand("select  a.*,br.kd_ukuran, isnull(b.nilai_konv,1)* isnull(a.jumlah_kerja,1) indeks from PROD.dbo.PROD_spk_d a " & _
"INNER JOIN SIF.dbo.SIF_konv_prod b " & _
"ON a.kd_kegiatan = b.kd_kegiatan " & _
"INNER JOIN SIF.dbo.SIF_Barang br " & _
"on a.kd_barang = br.Kode_Barang and br.kd_ukuran = b.kd_ukuran and br.kd_tipe=b.kd_tipe " & _
"where a.no_spk='" & lkspk.EditValue & "' and b.kd_kegiatan='" & lkkegiatan.EditValue & "' " & _
"and a.kd_kegiatan_spk= '" & lkkegtn.EditValue & "' and a.no_rph='" & lkrph.EditValue & "' ", sqlconn))
        da4.Fill(ds4, "loadab")


        If Not ds4.Tables("load") Is Nothing Then ds4.Tables("load").Clear()
        da4 = New SqlDataAdapter(New SqlCommand("select  a.*,br.kd_ukuran, isnull(b.nilai_konv,1)* isnull(a.jumlah_kerja,1) indeks from PROD.dbo.PROD_spk_d a " & _
"LEFT JOIN SIF.dbo.SIF_konv_prod b " & _
"ON a.kd_kegiatan = b.kd_kegiatan " & _
"LEFT JOIN SIF.dbo.SIF_Barang br " & _
"on a.kd_barang = br.Kode_Barang and br.kd_ukuran = b.kd_ukuran and br.kd_tipe=b.kd_tipe " & _
"where a.no_spk='" & lkspk.EditValue & "' and b.kd_kegiatan='" & lkkegiatan.EditValue & "' " & _
"and a.kd_kegiatan_spk= '" & lkkegtn.EditValue & "' and a.no_rph='" & lkrph.EditValue & "' ", sqlconn))
        da4.Fill(ds4, "load")

        If ds4.Tables("loadab").Rows.Count > 0 Then

            gControl.DataSource = ds4.Tables("loadab")
        ElseIf ds4.Tables("loadab").Rows.Count = 0 Then


            gControl.DataSource = ds4.Tables("load")
        End If

        'For B As Integer = 0 To ds4.Tables("").Rows.Count - 1
        '    ds4.Tables("load").Rows(B).Item("jumlah_kerja") = ds4.Tables("load").Rows(B).Item("jumlah_produksi")
        '    ds4.Tables("load").Rows(B).Item("indeks") = ds4.Tables("kegiatanq1").Rows(0).Item("nilai_konv") * ds4.Tables("load").Rows(B).Item("jumlah_produksi")
        'Next


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


        If State = "EDIT" Then

            row = ds5.Tables("SPKM").Rows(0)
            row.Item("jumlah") = txtjumlah.Text
            row.Item("kapasitas") = kapasits.Text
            row.Item("tanggal") = txttanggal.Text

        End If

        If State = "EDIT" Then

            For Each rows As DataRow In ds4.Tables("loadabc").Rows
                rows.Item("Last_Update_Date") = Now
                rows.Item("Last_Updated_By") = username
                rows.Item("kd_departemen") = kddep
                rows.Item("jumlah_sisa") = rows.Item("jumlah_produksi") - rows.Item("jumlah_kerja")
            Next

        End If

        If State = "EDIT" Then
            Try
                mb = New SqlClient.SqlCommandBuilder(da5)
                da5.UpdateCommand = mb.GetUpdateCommand()
                da5.InsertCommand = mb.GetInsertCommand()
                da5.DeleteCommand = mb.GetDeleteCommand()

                mb1 = New SqlClient.SqlCommandBuilder(da4)
                da4.UpdateCommand = mb1.GetUpdateCommand()
                da4.InsertCommand = mb1.GetInsertCommand()
                da4.DeleteCommand = mb1.GetDeleteCommand()

                da5.Update(ds5.Tables("SPKM"))
                da4.Update(ds4.Tables("loadabc"))


                ds5.Tables("SPKM").AcceptChanges()
                ds4.Tables("loadabc").AcceptChanges()


                showMessages("Saved..")



            Catch e As Exception

                ds5.Tables("SPKM").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                ds4.Tables("loadabc").RejectChanges()

                MsgBox(e.Message, MsgBoxStyle.Critical)

            End Try

        End If


    End Sub

    Public Sub edit_click()

        State = "EDIT"
        ' bila menggunakan form cari
        matilookup()
        dsedit = New DataSet
        daedit = New SqlDataAdapter(New SqlCommand("select no_rph as [NO RPH],no_spk as [NO SPK],kd_kegiatan_spk as [KODE KEGIATAN SPK],kd_kegiatan as [KODE KEGIATAN], desc_data as [NAMAKEGIATAN] from PROD.dbo.PROD_spk_d a,SIF.dbo.SIF_Gen_Reff_D b where b.ref_role='PROD' and b.id_Ref_File='SPK' and  a.kd_kegiatan_spk=b.id_data and a.kd_departemen='" & kddep & "'and a.jumlah_kerja > 0", sqlconn)) '<- query buat ditampilkan di LOV
        daedit.Fill(dsedit, "LookSPK")
        frmCari.set_dso(dsedit.Tables("LookSPK"))
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then
            kode = frmCari.row("NO RPH").ToString
            kode1 = frmCari.row("NO SPK").ToString
            kode2 = frmCari.row("KODE KEGIATAN").ToString
            kode3 = frmCari.row("KODE KEGIATAN SPK").ToString



            da5 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_spk_m where no_rph  = '" & kode & "' and  no_spk  = '" & kode1 & "' and  kd_departemen ='" & kddep & "' and kd_kegiatan ='" & kode2 & "' and kd_kegiatan_spk='" & kode3 & "' ", sqlconn)) '<- query buat ditampilkan di LOV
            da5.Fill(ds5, "SPKM")
            da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_spk_d where no_rph  = '" & kode & "' and  no_spk  = '" & kode1 & "' and  kd_departemen ='" & kddep & "' and kd_kegiatan ='" & kode2 & "' and kd_kegiatan_spk='" & kode3 & "' ", sqlconn))
            da4.Fill(ds4, "load") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
            gControl.DataSource = ds4.Tables("load")

            row = ds5.Tables("SPKM").Rows(0)
            txttanggal.Text = row.Item("tanggal").ToString
            lkrph.EditValue = kode
            lkspk.EditValue = kode1
            lkkegiatan.EditValue = row.Item("kd_kegiatan").ToString
            lkkegtn.EditValue = row.Item("kd_kegiatan_spk").ToString
            txtjumlah.Text = row.Item("jumlah").ToString
            kapasits.Text = row.Item("kapasitas").ToString

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
        If Not ds4.Tables("load") Is Nothing Then ds4.Tables("load").Clear()
        If Not ds4.Tables("loadab") Is Nothing Then ds4.Tables("loadab").Clear()
        If Not ds4.Tables("loadabc") Is Nothing Then ds4.Tables("loadabc").Clear()
        If Not ds5.Tables("SPKM") Is Nothing Then ds5.Tables("SPKM").Clear()
        txttanggal.Text = vbNullString
        lkrph.EditValue = vbNullString
        txtjdwl.Text = vbNullString
        lkspk.EditValue = vbNullString
        lkkegiatan.EditValue = vbNullString
        lkkegtn.EditValue = vbNullString
        txtjumlah.Text = vbNullString
        kapasits.Text = vbNullString

        nyalalookup()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = False
        btnAdd = True
        setStatus()
        Me.Enabled = False
    End Sub

    Sub nyalalookup()
        lkspk.Enabled = True
        lkkegtn.Enabled = True
        lkkegiatan.Enabled = True
    End Sub

    Sub matilookup()
        lkspk.Enabled = False
        lkkegtn.Enabled = False
        lkkegiatan.Enabled = False
    End Sub

    Public Sub cetak_click()
        'callReport(App_Path() & "\report\Reportspkq.rpt", "", "0,'201111/RPH/PROD/00007',1,'02', 2,'111'", False)
        'callReport(App_Path() & "\report\Reportspkq.rpt", "", "&norph=201111/RPH/PROD/00007 &kdkegiatanspk=02 &kdjenis=000", False)
        callReport(App_Path() & "\report\Reportspk_serv.rpt", "", "&norph=" & lkrph.EditValue & " &nospk=" & lkspk.EditValue & " &kdkegiatan=" & lkkegiatan.EditValue & " &kapasitas=" & kapasits.Text & " &kdkegiatanspk=" & lkkegtn.EditValue & " &vnama_report=" & TEMPLATE, False)
        'MsgBox('&norph=" & lkrph.EditValue & " &kdkegiatanspk=" & lkkegtn.EditValue & " &kdjenis=" & lkjnsbrg.EditValue, False)')
    End Sub

    Private Sub lkrph_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkrph.EditValueChanged
        If Not ds4.Tables("load") Is Nothing Then ds4.Tables("load").Clear()
        If Not ds4.Tables("loadab") Is Nothing Then ds4.Tables("loadab").Clear()
        If Not ds4.Tables("loadabc") Is Nothing Then ds4.Tables("loadabc").Clear()
        lkspk.EditValue = vbNullString
        lkkegiatan.EditValue = vbNullString
        lkkegtn.EditValue = vbNullString
        txtjumlah.Text = vbNullString
        kapasits.Text = vbNullString

        If Not ds1.Tables("nospk") Is Nothing Then ds1.Tables("nospk").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select distinct no_spk from PROD.dbo.PROD_spk_m where kd_departemen='" & kddep & "' and no_rph= '" & lkrph.EditValue & "'", sqlconn))
        da1.Fill(ds1, "nospk")
        lkspk.Properties.DataSource = ds1.Tables("nospk")
        lkspk.Properties.ValueMember = "no_spk"
        lkspk.Properties.DisplayMember = "no_spk"
    End Sub

    Private Sub lkkegiatan_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lkkegiatan.EditValueChanged
        If Not ds4.Tables("load") Is Nothing Then ds4.Tables("load").Clear()
        If Not ds4.Tables("loadab") Is Nothing Then ds4.Tables("loadab").Clear()
        If Not ds4.Tables("loadabc") Is Nothing Then ds4.Tables("loadabc").Clear()
        lkkegtn.EditValue = vbNullString
        txtjumlah.Text = vbNullString
        kapasits.Text = vbNullString


        If Not ds3.Tables("kegiatan") Is Nothing Then ds3.Tables("kegiatan").Clear()

        da3 = New SqlDataAdapter(New SqlCommand("select distinct isnull(a.kd_kegiatan_spk,b.kd_service) kd_kegiatan_spk ,b.nama_service as desc_data " & _
                                                "from PROD.dbo.PROD_spk_m a,SIF.dbo.SIF_bom_service b " & _
                                                "where no_spk='" & lkspk.EditValue & "' and a.kd_kegiatan='" & lkkegiatan.EditValue & "' " & _
                                                "and a.no_rph='" & lkrph.EditValue & "' and " & _
                                                "a.kd_kegiatan_spk=b.kd_service", sqlconn))
        da3.Fill(ds3, "kegiatan")
        lkkegtn.Properties.DataSource = ds3.Tables("kegiatan")
        lkkegtn.Properties.ValueMember = "kd_kegiatan_spk"
        lkkegtn.Properties.DisplayMember = "desc_data"



    End Sub


    Private Sub lkkegtn_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lkkegtn.EditValueChanged
        txtjumlah.Text = vbNullString
        kapasits.Text = vbNullString


        If Not ds3.Tables("kegiatan1") Is Nothing Then ds3.Tables("kegiatan1").Clear()
        da3 = New SqlDataAdapter(New SqlCommand("select jumlah,kapasitas from PROD.dbo.PROD_spk_m a,SIF.dbo.SIF_Gen_Reff_D b where no_spk='" & lkspk.EditValue & "' and a.kd_kegiatan='" & lkkegiatan.EditValue & "' and a.no_rph='" & lkrph.EditValue & "' and a.kd_kegiatan_spk='" & lkkegtn.EditValue & "'", sqlconn))
        da3.Fill(ds3, "kegiatan1")
        Dim a As Integer
        Dim b As Integer
        For i As Integer = 0 To ds3.Tables("kegiatan1").Rows.Count - 1

            a = ds3.Tables("kegiatan1").Rows(i).Item("jumlah").ToString
            txtjumlah.Text = CInt(a)

            b = ds3.Tables("kegiatan1").Rows(i).Item("kapasitas").ToString
            kapasits.Text = CInt(b)
        Next

        'loadGrid()

        If Not ds4.Tables("loada") Is Nothing Then ds4.Tables("loada").Clear()

        da4 = New SqlDataAdapter(New SqlCommand("select  a.*,br.kd_ukuran, (b.nilai_konv * a.jumlah_produksi) indeks from PROD.dbo.PROD_spk_d a " & _
        "INNER JOIN SIF.dbo.SIF_konv_prod b " & _
        "ON a.kd_kegiatan = b.kd_kegiatan " & _
        "INNER JOIN SIF.dbo.SIF_Barang br " & _
        "on a.kd_barang = br.Kode_Barang and br.kd_ukuran = b.kd_ukuran and br.kd_tipe=b.kd_tipe " & _
        "where a.no_spk='" & lkspk.EditValue & "' and a.kd_kegiatan='" & lkkegiatan.EditValue & "' " & _
        "and a.kd_kegiatan_spk= '" & lkkegtn.EditValue & "' and a.no_rph='" & lkrph.EditValue & "' ", sqlconn))
        da4.Fill(ds4, "loada")

        If ds4.Tables("loada").Rows.Count = 0 Then
            x = 0
            If Not ds4.Tables("loadab") Is Nothing Then ds4.Tables("loadab").Clear()
            If Not ds4.Tables("load") Is Nothing Then ds4.Tables("load").Clear()

            da4 = New SqlDataAdapter(New SqlCommand("select  a.kd_barang,floor(a.jumlah_produksi) as jumlah_produksi,a.jumlah_kerja as jumlah_kerja,a.no_spk,a.kd_kegiatan_spk,a.kd_kegiatan,a.no_rph,br.kd_ukuran,br.kd_tipe,  floor(1 * (ISNULL(a.jumlah_produksi,0))) as indeks from PROD.dbo.PROD_spk_d a " & _
            "LEFT JOIN SIF.dbo.SIF_Barang br " & _
            "on a.kd_barang = br.Kode_Barang " & _
            "where a.no_spk='" & lkspk.EditValue & "' and a.kd_kegiatan='" & lkkegiatan.EditValue & "' " & _
            "and a.kd_kegiatan_spk= '" & lkkegtn.EditValue & "' and a.no_rph='" & lkrph.EditValue & "'", sqlconn))
            da4.Fill(ds4, "load")
            gControl.DataSource = ds4.Tables("load")
        Else
            x = 1
            If Not ds4.Tables("load") Is Nothing Then ds4.Tables("load").Clear()
            If Not ds4.Tables("loadab") Is Nothing Then ds4.Tables("loadab").Clear()

            da4 = New SqlDataAdapter(New SqlCommand("select  a.*,br.kd_ukuran, isnull((b.nilai_konv * a.jumlah_produksi),1) indeks from PROD.dbo.PROD_spk_d a " & _
            "INNER JOIN SIF.dbo.SIF_Barang br " & _
            "on a.kd_barang = br.Kode_Barang " & _
               "LEFT JOIN SIF.dbo.SIF_konv_prod b " & _
                "on b.jns_kegiatan = a.kd_kegiatan and b.kd_kegiatan = a.kd_kegiatan_spk " & _
                "and br.kd_ukuran = b.kd_ukuran and br.kd_tipe=b.kd_tipe " & _
                "where a.no_spk='" & lkspk.EditValue & "' and a.kd_kegiatan='" & lkkegiatan.EditValue & "' " & _
                "and a.kd_kegiatan_spk= '" & lkkegtn.EditValue & "' and a.no_rph='" & lkrph.EditValue & "' ", sqlconn))

            da4.Fill(ds4, "loadab")
            gControl.DataSource = ds4.Tables("loadab")
        End If

        loadlookup()
        If Not ds4.Tables("loadabc") Is Nothing Then ds4.Tables("loadabc").Clear()
        da4 = New SqlDataAdapter(New SqlCommand("select  a.* from PROD.dbo.PROD_spk_d a " & _
    "where a.no_spk='" & lkspk.EditValue & "' and a.kd_kegiatan='" & lkkegiatan.EditValue & "' " & _
    "and a.kd_kegiatan_spk= '" & lkkegtn.EditValue & "' and a.no_rph='" & lkrph.EditValue & "' ", sqlconn))
        da4.Fill(ds4, "loadabc")



    End Sub

    Private Sub lkspk_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lkspk.EditValueChanged
        If Not ds4.Tables("load") Is Nothing Then ds4.Tables("load").Clear()
        If Not ds4.Tables("loadab") Is Nothing Then ds4.Tables("loadab").Clear()
        If Not ds4.Tables("loadabc") Is Nothing Then ds4.Tables("loadabc").Clear()
        txttanggal.Text = vbNullString
        lkkegiatan.EditValue = vbNullString
        lkkegtn.EditValue = vbNullString
        txtjumlah.Text = vbNullString
        kapasits.Text = vbNullString

        If Not ds2.Tables("kegiatanspk") Is Nothing Then ds2.Tables("kegiatanspk").Clear()

        da1 = New SqlDataAdapter(New SqlCommand("select desc_data from PROD.dbo.PROD_rcn_prod_m a,PROD.dbo.PROD_spk_m b,SIF.dbo.SIF_Gen_Reff_D c where b.no_spk='" & lkspk.EditValue & "' and a.no_rph=b.no_rph and a.kd_jadwal=c.id_data and c.ref_role='PROD' and c.id_Ref_File='JDWKRJ'", sqlconn))
        da1.Fill(ds1, "isispk")
        For i As Integer = 0 To ds1.Tables("isispk").Rows.Count - 1
            txtjdwl.Text = ds1.Tables("isispk").Rows(i).Item("desc_data").ToString
        Next
        txttanggal.Text = Now.Date

        da2 = New SqlDataAdapter(New SqlCommand("select distinct kd_kegiatan,desc_data from PROD.dbo.PROD_spk_m a, " & _
                                                "SIF.dbo.SIF_Gen_Reff_D b where a.no_spk='" & lkspk.EditValue & "' " & _
                                                "and a.no_rph='" & lkrph.EditValue & "' and b.ref_role='PROD' " & _
                                                "and b.id_Ref_File='KGTSPK'and a.kd_kegiatan=b.id_data ", sqlconn))
        da2.Fill(ds2, "kegiatanspk")
        lkkegiatan.Properties.DataSource = ds2.Tables("kegiatanspk")
        lkkegiatan.Properties.ValueMember = "kd_kegiatan"
        lkkegiatan.Properties.DisplayMember = "desc_data"

    End Sub

    Private Sub gView_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gView.ValidateRow
        Dim isinvalid As Boolean = True
        If e.Row("jumlah_kerja") > e.Row("jumlah_produksi") Then
            isinvalid = False
            Dim x As Object
            x = CType(gControl.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
            x.SetColumnError(jumlah_kerja, "Jumlah Dikerjakan tidak boleh lebih besar dari Jumlah Produksi")
            MsgBox("Jumlah Dikerjakan tidak boleh lebih besar dari Jumlah Produksi")

        End If
        e.Valid = isinvalid
    End Sub
End Class