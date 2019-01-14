Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmincentifcentikrg1
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain
    Dim ds1, ds2, ds3, dsedit, dsedit1, dshapus As New DataSet
    Dim da1, da2, da3, da4, da5, da6, da7 As New SqlDataAdapter
    Dim row As DataRow
    Dim mb, mb1, mb2 As New SqlCommandBuilder
    Dim BTRANS As SqlTransaction
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim obj As Object
    Dim State As String
    Dim myBuilder As New SqlCommandBuilder
    Dim dsMon, dsNoRPH As New DataSet
    Dim daMon, daNoRPH As SqlDataAdapter
    Dim TEMPLATE As String
    Public Sub cancel_click()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        txtTgl_Awal.EditValue = Nothing
        txtTgl_Akhir.EditValue = Nothing
        If Not ds2.Tables("peg") Is Nothing Then ds2.Tables("peg").Clear()
        Me.Enabled = False
    End Sub
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Private Sub frmincentifcentikrg1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
    End Sub
    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub
    Sub reload()
        If Not ds1.Tables("krg") Is Nothing Then ds1.Tables("krg").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_insentif_centi_krg ", sqlconn))
        da1.Fill(ds1, "krg")


        If Not ds3.Tables("tampil") Is Nothing Then ds3.Tables("tampil").Clear()
        da3 = New SqlDataAdapter(New SqlCommand("select a.*,b.Kode_bagian from PROD.dbo.PROD_insentif_centi_krg a,SIF.dbo.SIF_Pegawai b  where a.kd_pegawai=b.Kode_Pegawai ", sqlconn))
        da3.Fill(ds3, "tampil")
        gc.DataSource = ds3.Tables("tampil")

        If Not ds2.Tables("peg") Is Nothing Then ds2.Tables("peg").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select Kode_Pegawai as kd_pegawai,Nama_Pegawai from SIF.dbo.SIF_Pegawai", sqlconn))
        da2.Fill(ds2, "peg")
        txtPegawai.Properties.DataSource = ds2.Tables("peg")
        txtPegawai.Properties.ValueMember = "kd_pegawai"
        txtPegawai.Properties.DisplayMember = "Nama_Pegawai"

        If Not ds2.Tables("reppeg") Is Nothing Then ds2.Tables("reppeg").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select Kode_Pegawai as kd_pegawai,Nama_Pegawai from SIF.dbo.SIF_Pegawai", sqlconn))
        da2.Fill(ds2, "reppeg")
        RepositoryItemLookUpEdit1.DataSource = ds2.Tables("reppeg")

        If Not dshapus.Tables("hapus") Is Nothing Then dshapus.Tables("hapus").Clear()
        da5 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_insentif_centi_krg where kd_pegawai='" & txtPegawai.EditValue & "'" & _
                                           " and kd_kegiatan= '" & txtkdbag.Text & "' and tanggal_absen = '" & Format(txtTgl_Awal.DateTime, "yyyy/MM/dd") & "' ", sqlconn))
        da5.Fill(dshapus, "hapus") '<-- menghapus data


    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data Absen Pegawai ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            State = "DELETE"
            If Not dshapus.Tables("hapus") Is Nothing Then delete(dshapus.Tables("hapus").Rows)

            Dim BTRANS As SqlTransaction
            mb = New SqlClient.SqlCommandBuilder(da5)
            da5.UpdateCommand = mb.GetUpdateCommand()
            da5.InsertCommand = mb.GetInsertCommand()
            da5.DeleteCommand = mb.GetDeleteCommand()



            BTRANS = sqlconn.BeginTransaction("1")
            da5.UpdateCommand.Transaction = BTRANS
            da5.InsertCommand.Transaction = BTRANS
            da5.DeleteCommand.Transaction = BTRANS

            Try

                da5.Update(dshapus.Tables("hapus"))

                dshapus.Tables("hapus").AcceptChanges()

                BTRANS.Commit()


                showMessages("Data Berhasil Dihapus")
                reload()
                txtTgl_Awal.EditValue = Nothing
                txtTgl_Akhir.EditValue = Nothing
                If Not ds2.Tables("peg") Is Nothing Then ds2.Tables("peg").Clear()
            Catch e As Exception
                BTRANS.Rollback()
                dshapus.Tables("hapus").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

            End Try



            cancel_click()
            STATE = ""
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

        'callReport(App_Path() & "\report\insentifrpt.rpt", "", "&KDPEG=" & txtPegawai.EditValue & " &KDKEG=" & txtKegiatan.EditValue & " &GROUP=" & txtJam.EditValue & " &TGLAWAL=" & Format(txtTgl_Awal.DateTime, "yyyy/MM/dd") & " &TGLAKHIR=" & Format(txtTgl_Akhir.DateTime, "yyyy/MM/dd") & " &vnama_report=" & TEMPLATE, False)

    End Sub

    Public Sub save_click()

        If txtTgl_Awal.EditValue Is vbNullString Then
            MessageBox.Show("tanggal tidak boleh kosong")
            Exit Sub
        End If
        If Not ds1.Tables("cek") Is Nothing Then ds1.Tables("cek").Clear()
        da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_insentif_centi_krg where kd_pegawai='" & txtPegawai.EditValue & "'" & _
                                                " and kd_kegiatan= '" & txtkdbag.Text & "' and REPLACE(CONVERT(varchar(10),tanggal_absen,102),'.','') = '" & Format(txtTgl_Awal.DateTime, "yyyyMMdd") & "' ", sqlconn))
        da4.Fill(ds1, "cek")
        If ds1.Tables("cek").Rows.Count > 0 Then

            MessageBox.Show("data Pegawai :" & txtPegawai.Text & " tanggal:" & txtTgl_Awal.EditValue & " sudah ada")
            Exit Sub
        End If



        If State = "ADD" Then '----------Simpan ADD

            Dim tgl As Date = getTanggal()

            Dim BTRANS As SqlTransaction
            mb = New SqlClient.SqlCommandBuilder(da1)
            da1.UpdateCommand = mb.GetUpdateCommand()
            da1.InsertCommand = mb.GetInsertCommand()
            da1.DeleteCommand = mb.GetDeleteCommand()



            BTRANS = sqlconn.BeginTransaction("1")
            da1.UpdateCommand.Transaction = BTRANS
            da1.InsertCommand.Transaction = BTRANS
            da1.DeleteCommand.Transaction = BTRANS


            Dim rowb1 As DataRow

            rowb1 = ds1.Tables("krg").NewRow
            rowb1("last_create_date") = tgl
            rowb1("last_created_by") = username
            rowb1("program_name") = Me.Name
            rowb1("kd_cabang") = kdcabang
            rowb1("kd_departemen") = kddep
            rowb1("kd_kegiatan") = txtkdbag.Text
            rowb1("tanggal_absen") = Format(txtTgl_Awal.DateTime, "yyyy/MM/dd")
            rowb1("tanggal") = Format(txtTgl_Awal.DateTime, "yyyy/MM/dd")
            rowb1("kd_pegawai") = txtPegawai.EditValue
            ds1.Tables("krg").Rows.Add(rowb1)




            Try

                da1.Update(ds1.Tables("krg"))

                ds1.Tables("krg").AcceptChanges()

                BTRANS.Commit()


                showMessages("Data Berhasil Disimpan")
                reload()
                txtTgl_Awal.EditValue = Nothing
                txtTgl_Akhir.EditValue = Nothing
                If Not ds2.Tables("peg") Is Nothing Then ds2.Tables("peg").Clear()
            Catch e As Exception
                BTRANS.Rollback()
                ds1.Tables("krg").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

            End Try
        ElseIf State = "EDIT" Then

            Dim tgl As Date = getTanggal()

            Dim BTRANS As SqlTransaction
            mb = New SqlClient.SqlCommandBuilder(da7)
            da7.UpdateCommand = mb.GetUpdateCommand()
            da7.InsertCommand = mb.GetInsertCommand()
            da7.DeleteCommand = mb.GetDeleteCommand()



            BTRANS = sqlconn.BeginTransaction("1")
            da7.UpdateCommand.Transaction = BTRANS
            da7.InsertCommand.Transaction = BTRANS
            da7.DeleteCommand.Transaction = BTRANS

            Dim rowb1 As DataRow



            rowb1 = dsedit.Tables("editkrg").Rows(0)
            rowb1("last_update_date") = tgl
            rowb1("last_updated_by") = username
            rowb1("program_name") = Me.Name
            rowb1("kd_cabang") = kdcabang
            rowb1("kd_departemen") = kddep
            rowb1("kd_kegiatan") = txtkdbag.Text
            rowb1("tanggal_absen") = Format(txtTgl_Awal.DateTime, "yyyy/MM/dd")
            rowb1("tanggal") = Format(txtTgl_Awal.DateTime, "yyyy/MM/dd")
            rowb1("kd_pegawai") = txtPegawai.EditValue





            Try

                da7.Update(dsedit.Tables("editkrg"))

                dsedit.Tables("editkrg").AcceptChanges()

                BTRANS.Commit()

                showMessages("Data Berhasil Diedit")
                If Not dsedit1.Tables("edittampil") Is Nothing Then dsedit1.Tables("edittampil").Clear()
                reload()
                txtTgl_Awal.EditValue = Nothing
                txtTgl_Akhir.EditValue = Nothing
                If Not ds2.Tables("peg") Is Nothing Then ds2.Tables("peg").Clear()
            Catch e As Exception
                BTRANS.Rollback()
                dsedit.Tables("editkrg").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Edit")

            End Try

        End If
    End Sub

    Private Sub txtPegawai_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPegawai.EditValueChanged

        If Not ds3.Tables("bag") Is Nothing Then ds3.Tables("bag").Clear()
        da4 = New SqlDataAdapter(New SqlCommand("select isnull(Kode_bagian,'') Kode_bagian from SIF.dbo.SIF_Pegawai where Kode_Pegawai= '" & txtPegawai.EditValue & "'", sqlconn))
        da4.Fill(ds3, "bag")
        txtkdbag.Text = ds3.Tables("bag").Rows(0).Item("Kode_Bagian")
    End Sub

    Private Sub txtTgl_Awal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTgl_Awal.EditValueChanged
        If txtTgl_Awal.EditValue Is vbNullString Then
            txtTgl_Akhir.EditValue = vbNullString
        Else
            txtTgl_Akhir.EditValue = Format(txtTgl_Awal.DateTime, "y")
        End If



    End Sub
    Public Sub edit_click()
        State = "EDIT"
        

        If Not ds3.Tables("tampil") Is Nothing Then ds3.Tables("tampil").Clear()
        If Not ds2.Tables("peg") Is Nothing Then ds2.Tables("peg").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select Kode_Pegawai as kd_pegawai,Nama_Pegawai from SIF.dbo.SIF_Pegawai", sqlconn))
        da2.Fill(ds2, "peg")
        txtPegawai.Properties.DataSource = ds2.Tables("peg")
        txtPegawai.Properties.ValueMember = "kd_pegawai"
        txtPegawai.Properties.DisplayMember = "Nama_Pegawai"

        If Not ds2.Tables("reppeg") Is Nothing Then ds2.Tables("reppeg").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select Kode_Pegawai as kd_pegawai,Nama_Pegawai from SIF.dbo.SIF_Pegawai", sqlconn))
        da2.Fill(ds2, "reppeg")
        RepositoryItemLookUpEdit1.DataSource = ds2.Tables("reppeg")
        ' bila menggunakan form cari
        dsedit = New DataSet
        da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.kd_pegawai KodePegawai, b.Nama_Pegawai Pegawai,a.tanggal_absen as TanggalAbsen, b.Kode_bagian Kegiatan  from PROD.dbo.PROD_insentif_centi_krg a,SIF.dbo.SIF_Pegawai b where a.kd_pegawai=b.Kode_Pegawai ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        da7.Fill(dsedit, "LOOKUP_PROD_INCENTIF_KRG")
        frmCari.set_dso(dsedit.Tables(0)) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV

        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih

            dsedit = New DataSet
            If Not dsedit.Tables("editkrg") Is Nothing Then dsedit.Tables("editkrg").Clear()
            da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_insentif_centi_krg where kd_pegawai='" & frmCari.row("KodePegawai").ToString & "'" & _
                                               " and kd_kegiatan= '" & frmCari.row("Kegiatan").ToString & "' and tanggal_absen = '" & Format(frmCari.row("TanggalAbsen"), "yyyy/MM/dd") & "' ", sqlconn))
            da7.Fill(dsedit, "editkrg") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)

            If Not dshapus.Tables("hapus") Is Nothing Then dshapus.Tables("hapus").Clear()
            da5 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_insentif_centi_krg where kd_pegawai='" & frmCari.row("KodePegawai").ToString & "'" & _
                                                     " and kd_kegiatan= '" & frmCari.row("Kegiatan").ToString & "' and tanggal_absen = '" & Format(frmCari.row("TanggalAbsen"), "yyyy/MM/dd") & "' ", sqlconn))
            da5.Fill(dshapus, "hapus") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)


            If Not dsedit1.Tables("edittampil") Is Nothing Then dsedit1.Tables("edittampil").Clear()
            da6 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.*,b.* from PROD.dbo.PROD_insentif_centi_krg a,SIF.dbo.SIF_Pegawai b  where a.kd_pegawai=b.Kode_Pegawai and a.kd_pegawai='" & frmCari.row("KodePegawai").ToString & "'" & _
                                               " and a.kd_kegiatan= '" & frmCari.row("Kegiatan").ToString & "' and a.tanggal_absen = '" & Format(frmCari.row("TanggalAbsen"), "yyyy/MM/dd") & "' ", sqlconn))
            da6.Fill(dsedit1, "edittampil")
            gc.DataSource = dsedit1.Tables("edittampil")
            txtPegawai.EditValue = dsedit.Tables("editkrg").Rows(0).Item("kd_pegawai").ToString
            txtTgl_Awal.EditValue = dsedit.Tables("editkrg").Rows(0).Item("tanggal_absen").ToString


            'default_add(prn)

            setStatus()
            prn.btnAdd.Enabled = False
            prn.btnSave.Enabled = True
            prn.btnCancel.Enabled = True
            prn.btnDelete.Enabled = True
            If dsedit.Tables(0).Rows.Count > 0 Then
            Else
                MsgBox("Data tidak diketemukan")
            End If
        End If
    End Sub

End Class