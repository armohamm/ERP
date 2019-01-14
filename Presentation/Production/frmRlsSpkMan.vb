Imports System.Data.SqlClient
Public Class frmRlsSpkMan
    Dim ds1, ds2, ds3, ds4 As New DataSet
    Dim da1, da2, da3, da4 As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
        'With Me
        '    .btAdd.Enabled = btnAdd
        '    .btCancel.Enabled = btnCancel
        '    .btDel.Enabled = btnDelete
        '    .btEdit.Enabled = btnEdit
        '    .btSave.Enabled = btnSave
        'End With
    End Sub

    Private Sub frmTemplate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        reload()
        prn = getParent(Me)
    End Sub

    Private Sub reload()
        If Not ds1.Tables("MRLS") Is Nothing Then ds1.Tables("MRLS").Clear()
        If Not ds1.Tables("DRLS") Is Nothing Then ds1.Tables("DRLS").Clear()
        If Not ds1.Tables("noSPK") Is Nothing Then ds1.Tables("noSPK").Clear()
        If Not ds1.Tables("jamKerja") Is Nothing Then ds1.Tables("jamKerja").Clear()
        If Not ds1.Tables("jnsKeg") Is Nothing Then ds1.Tables("jnsKeg").Clear()

        da1 = New SqlDataAdapter(New SqlCommand("select distinct(no_spk_man) from PROD.dbo.PROD_spk_man_m order by no_spk_man", sqlconn))
        da1.Fill(ds1, "noSPK")
        da1 = New SqlDataAdapter(New SqlCommand("select Id_Data, Desc_Data from SIF.dbo.SIF_Gen_Reff_D where id_ref_file='JAMPROD'", sqlconn))
        da1.Fill(ds1, "jamKerja")
        da1 = New SqlDataAdapter(New SqlCommand("select d.*, '' nama_barang from PROD.dbo.PROD_rls_spk_man_d  d where 1=0", sqlconn))
        da1.Fill(ds1, "DRLS")
        For i As Integer = 0 To ds1.Tables("DRLS").Rows.Count - 1
            ds1.Tables("DRLS").Rows(i).Item("jumlah_realisasi") = 0
        Next

        txtNoSPK.Properties.DataSource = ds1.Tables("noSPK")
        txtNoSPK.Properties.ValueMember = "no_spk_man"
        txtNoSPK.Properties.DisplayMember = "no_spk_man"

        txtJamKerja.Properties.DataSource = ds1.Tables("jamKerja")
        txtJamKerja.Properties.ValueMember = "Id_Data"
        txtJamKerja.Properties.DisplayMember = "Desc_Data"
    End Sub

    Public Sub add_click()
        reload()
        txtTanggal.DateTime = Date.Today
        'txtTanggal.Properties.ReadOnly = False
        txtNoSPKRls.Text = ""
        txtNoSPK.EditValue = Nothing
        txtNoSPK.Properties.ReadOnly = False
        txtJamKerja.EditValue = Nothing
        txtJamKerja.Properties.ReadOnly = False

        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnAdd = False
        State = "ADD"
        setStatus()
    End Sub

    Public Sub edit_click()
        Dim qstr As String = "select P.tanggal Tanggal, P.no_spk_man_rls [No Transaksi],  S.Desc_Data [Group Kerja] " & _
        "from PROD.dbo.PROD_rls_spk_man_m P " & _
        "left join SIF.dbo.SIF_Gen_Reff_D S " & _
        "on P.kd_jam = S.Id_Data " & _
        "where S.Id_Ref_Data = 'JAMPROD'"
        'MessageBox.Show(qstr)
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(qstr, sqlconn))
        If Not ds3.Tables("cari") Is Nothing Then ds3.Tables("cari").Clear()
        da3.Fill(ds3, "cari")
        frmCari.set_dso(ds3.Tables("cari"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            If Not ds1.Tables("MRLS") Is Nothing Then ds1.Tables("MRLS").Clear()
            If Not ds1.Tables("DRLS") Is Nothing Then ds1.Tables("DRLS").Clear()
            da2 = New SqlDataAdapter(New SqlCommand("select m.*, '' nama_barang from PROD.dbo.PROD_rls_spk_man_m  m where no_spk_man_rls='" & frmCari.row("No Transaksi") & "'", sqlconn))
            da2.Fill(ds1, "MRLS")
            row = ds1.Tables("MRLS").Rows(0)
            txtTanggal.DateTime = row.Item("tanggal")
            txtTanggal.Properties.ReadOnly = True
            txtNoSPK.Text = row.Item("no_spk_man")
            txtNoSPK.Properties.ReadOnly = True
            txtJamKerja.EditValue = row.Item("kd_jam")
            'txtJamKerja.Properties.ReadOnly = True
            txtNoSPKRls.Text = row.Item("no_spk_man_rls")

            da1 = New SqlDataAdapter(New SqlCommand("select d.*, '' nama_barang from PROD.dbo.PROD_rls_spk_man_d  d where d.no_spk_man_rls='" & frmCari.row("No Transaksi") & "'", sqlconn))

            da1.Fill(ds1, "DRLS")
            For Each rw As DataRow In ds1.Tables("DRLS").Rows
                Dim dr As SqlDataReader
                dr = New SqlClient.SqlCommand("select S.Nama_Barang " & _
                                                                   " from SIF.dbo.SIF_Barang S " & _
                                                                   "where S.Kode_Barang='" & rw.Item("kd_barang") & "' ", sqlconn).ExecuteReader
                While dr.Read
                    rw.Item("nama_barang") = dr.Item("Nama_Barang")
                End While
                dr.Close()
            Next

            GC.DataSource = ds1.Tables("DRLS")

            State = "EDIT"
            btnSave = True
            btnAdd = False
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
        If State = "ADD" Then

            Dim filledrow As Integer = ds1.Tables("DRLS").Select("jumlah_realisasi > 0").Count
            If txtTanggal.Text = "" Then
                MessageBox.Show("Tanggal Belum Diisi")
                Exit Sub
            End If
            If txtNoSPK.EditValue = "" Then
                MessageBox.Show("No SPK Belum Dipilih")
                Exit Sub
            End If
            If txtJamKerja.EditValue = "" Then
                MessageBox.Show("Jam Kerja Belum Dipilih")
                Exit Sub
            End If

            If filledrow = 0 Then
                MessageBox.Show("Jumlah Realisasi Belum Ada Yang Diisi")
                Exit Sub
            End If

            Dim notrans As String
            notrans = getNoTrans("PRODRLSPKM", txtTanggal.DateTime)
            txtNoSPKRls.Text = notrans

            If Not ds1.Tables("MRLS") Is Nothing Then ds1.Tables("MRLS").Clear()
            da2 = New SqlDataAdapter(New SqlCommand("select d.* from PROD.dbo.PROD_rls_spk_man_m  d where 1=0", sqlconn))
            da2.Fill(ds1, "MRLS")
            Dim dr As SqlDataReader
            dr = New SqlClient.SqlCommand("select P.* " & _
                                          "from PROD.dbo.PROD_spk_man_m P " & _
                                          "where P.no_spk='" & txtNoSPK.EditValue & "' ", sqlconn).ExecuteReader

            dr.Read()
            Dim tgl As Date = getTanggal()
            Dim rowm As DataRow
            rowm = ds1.Tables("MRLS").NewRow
            rowm("no_spk_man_rls") = txtNoSPKRls.Text
            rowm("tanggal") = tgl
            rowm("kd_jam") = txtJamKerja.EditValue
            rowm("no_spk_man") = txtNoSPK.Text
            rowm("last_create_date") = tgl
            rowm("last_created_by") = username
            rowm("program_name") = Me.Name
            rowm("kd_cabang") = kdcabang
            rowm("kd_departemen") = kddep
            dr.Close()
            ds1.Tables("MRLS").Rows.Add(rowm)
            mb = New SqlCommandBuilder(da2)
            da2.UpdateCommand = mb.GetUpdateCommand
            da2.Update(ds1.Tables("MRLS"))
            ds1.Tables("MRLS").AcceptChanges()


            For i = ds1.Tables("DRLS").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = ds1.Tables("DRLS").Rows(i)
                If Not TypeOf rows("jumlah_realisasi") Is DBNull Then
                    If rows("jumlah_realisasi") > 0 Then
                        rows("no_spk_man_rls") = txtNoSPKRls.Text
                        rows("last_create_date") = tgl
                        rows("last_created_by") = username
                        rows("last_update_date") = tgl
                        rows("last_updated_by") = username
                        rows("program_name") = Me.Name
                        rows("kd_cabang") = kdcabang
                        rows("kd_departemen") = kddep
                    Else
                        ds1.Tables("DRLS").Rows(i).Delete()
                    End If
                Else
                    ds1.Tables("DRLS").Rows(i).Delete()
                End If
            Next
            GC.DataSource = ds1.Tables("DRLS")
            mb = New SqlCommandBuilder(da1)
            da1.UpdateCommand = mb.GetUpdateCommand
            da1.Update(ds1.Tables("DRLS"))
            ds1.Tables("DRLS").AcceptChanges()
            showMessages("Data Berhasil Disimpan")
            State = "EDIT"
            'btnSave = False
            btnSave = False
            cancel_click()
            setStatus()
        ElseIf State = "EDIT" Then
            Dim filledrow As Integer = ds1.Tables("DRLS").Select("jumlah_kerja>0").Count
            If filledrow = 0 Then
                MessageBox.Show("Jumlah Kerja Belum Ada Yang Diisi")
                Exit Sub
            End If

            Dim tgl As Date = getTanggal()
            row = ds1.Tables("MRLS").Rows(0)
            row.Item("kd_jam") = txtJamKerja.EditValue
            row.Item("last_update_date") = tgl
            row.Item("last_updated_by") = username
            mb = New SqlCommandBuilder(da2)
            da2.UpdateCommand = mb.GetUpdateCommand
            da2.Update(ds1.Tables("MRLS"))
            ds1.Tables("MRLS").AcceptChanges()
            For i = ds1.Tables("DRLS").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = ds1.Tables("DRLS").Rows(i)
                If Not TypeOf rows("jumlah_realisasi") Is DBNull Then
                    If rows("jumlah_realisasi") > 0 Then
                        rows("last_update_date") = tgl
                        rows("last_updated_by") = username
                    Else
                        ds1.Tables("DRLS").Rows(i).Delete()
                    End If
                Else
                    ds1.Tables("DRLS").Rows(i).Delete()
                End If
            Next
            mb = New SqlCommandBuilder(da1)
            da1.UpdateCommand = mb.GetUpdateCommand
            da1.Update(ds1.Tables("DRLS"))
            ds1.Tables("DRLS").AcceptChanges()
            showMessages("Data Berhasil Disimpan")

        End If
    End Sub

    Private Sub loadDetail()
        If Not ds1.Tables("DRLS") Is Nothing Then ds1.Tables("DRLS").Clear()


        da1 = New SqlDataAdapter(New SqlCommand("select d.*, '' nama_barang from PROD.dbo.PROD_rls_spk_man_d  d where 1=0", sqlconn))
        da1.Fill(ds1, "DRLS")
        Dim dr As SqlDataReader
        dr = New SqlClient.SqlCommand("select P.*,S.Nama_Barang " & _
                                                           "from PROD.dbo.PROD_spk_man_d P " & _
                                                           "left join SIF.dbo.SIF_Barang S " & _
                                                           "on P.kd_barang = S.Kode_Barang " & _
                                                           "where P.no_spk_man='" & txtNoSPK.EditValue & "' order by kd_barang", sqlconn).ExecuteReader
        While dr.Read
            Dim rw As DataRow = ds1.Tables("DRLS").NewRow
            rw("no_spk_man") = dr.Item("no_spk_man")
            rw("kd_kegiatan") = dr.Item("kd_kegiatan_spk")
            rw("kd_barang") = dr.Item("kd_barang")
            rw("jumlah") = dr.Item("jumlah_produksi")
            rw("nama_barang") = dr.Item("Nama_Barang")
            rw("jumlah_kerja") = dr.Item("jumlah_kerja")
            rw("jumlah_realisasi") = 0


            ds1.Tables("DRLS").Rows.Add(rw)
        End While
        dr.Close()
        GC.DataSource = ds1.Tables("DRLS")
    End Sub
    Private Sub loadlookup()

        If Not ds4.Tables("loadtipe") Is Nothing Then ds4.Tables("loadtipe").Clear()
        If Not ds4.Tables("loadkain") Is Nothing Then ds4.Tables("loadkain").Clear()
        If Not ds4.Tables("loadukuran") Is Nothing Then ds4.Tables("loadukuran").Clear()

       
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
    End Sub



    Private Sub GV_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub txtNoSPK_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoSPK.EditValueChanged

        If State = "ADD" Then
            loadDetail()
            loadlookup()
        End If


        'If Not ds1.Tables("jnsKeg") Is Nothing Then ds1.Tables("jnsKeg").Clear()
        'da1 = New SqlDataAdapter(New SqlCommand("select P.kd_kegiatan,S.Desc_Data,S.Id_Data " & _
        '                                        "from PROD.dbo.prod_spk_man_m P " & _
        '                                        "left join SIF.dbo.sif_gen_reff_d S " & _
        '                                        "on P.kd_kegiatan=S.id_data " & _
        '                                        "where P.no_spk='" & txtNoSPK.EditValue & "' " & _
        '                                        "and S.id_ref_data = 'KGTSPK'", sqlconn))

        'da1.Fill(ds1, "jnsKeg")
        'txtKegiatan.Properties.DataSource = ds1.Tables("jnsKeg")
        'txtKegiatan.EditValue = Nothing

        'txtKegiatan.Properties.ValueMember = "Id_Data"
        'txtKegiatan.Properties.DisplayMember = "Desc_Data"

        'If Not ds1.Tables("DRLS") Is Nothing Then ds1.Tables("DRLS").Clear()

        'da1 = New SqlDataAdapter(New SqlCommand("select d.*, '' nama_barang, 0 jumlah_realisasi from PROD.dbo.PROD_spk_man_d  d where 1=0", sqlconn))
        'da1.Fill(ds1, "DRLS")
        'Dim dr As SqlDataReader = New SqlClient.SqlCommand("select P.*,S.Nama_Barang " & _
        '                                                   "from PROD.dbo.PROD_spk_man_d P " & _
        '                                                   "left join SIF.dbo.SIF_Barang S " & _
        '                                                   "on P.kd_barang = S.Kode_Barang " & _
        '                                                   "where P.no_spk='" & txtNoSPK.EditValue & "' order by kd_barang", sqlconn).ExecuteReader
        'While dr.Read
        '    Dim rw As DataRow = ds1.Tables("DRLS").NewRow
        '    rw("no_spk") = dr.Item("no_spk")
        '    rw("kd_barang") = dr.Item("kd_barang")
        '    rw("jumlah_produksi") = dr.Item("jumlah_produksi")
        '    rw("nama_barang") = dr.Item("Nama_Barang")
        '    rw("jumlah_kerja") = dr.Item("jumlah_kerja")
        '    rw("jumlah_realisasi") = 0

        '    ds1.Tables("DRLS").Rows.Add(rw)
        'End While
        'dr.Close()
        'GC.DataSource = ds1.Tables("DRLS")
    End Sub

    Private Sub txtKegiatan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub GV_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        Dim isValid As Boolean = True
        If e.Row("jumlah_realisasi") > e.Row("jumlah_kerja") Then
            GV.SetColumnError(clRealisasi, "Jumlah Realisasi Terlalu Banyak", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            isValid = False
        End If
        e.Valid = isValid
    End Sub
End Class