Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmSpkManCenti
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Dim myBuilder As New SqlCommandBuilder
    Dim ds1, ds2, ds3 As New DataSet
    Dim da1, da2, da3, da6 As New SqlDataAdapter
    Dim colD1(1) As DataColumn
    Dim colD2(1) As DataColumn
    Dim colD(0) As DataColumn
    Dim colDq(0) As DataColumn
    Dim rl As DataRelation
    Dim dread As SqlDataReader

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
        'With Me
        '    .btAdd.Enabled = btnadd
        '    .btCancel.Enabled = btnCancel
        '    .btDel.Enabled = btnDelete
        '    .btEdit.Enabled = btnEdit
        '    .btSave.Enabled = btnSave
        'End With
    End Sub
    Private Sub frmSpkMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        'reload()

    End Sub
    Private Sub reload(Optional ByVal notrans As String = "")
        If Not ds1.Tables("nospk") Is Nothing Then ds1.Tables("nospk").Clear()
        If Not ds1.Tables("group") Is Nothing Then ds1.Tables("group").Clear()
        If Not ds1.Tables("jadwal") Is Nothing Then ds1.Tables("jadwal").Clear()
        If Not ds1.Tables("jnsKdKeg") Is Nothing Then ds1.Tables("jnsKdKeg").Clear()
        If Not ds1.Tables("jnsKeg") Is Nothing Then ds1.Tables("jnsKeg").Clear()
        If Not ds1.Tables("jnsBrg") Is Nothing Then ds1.Tables("jnsBrg").Clear()
        If Not ds1.Tables("mesin") Is Nothing Then ds1.Tables("mesin").Clear()
        If Not ds1.Tables("pegawai") Is Nothing Then ds1.Tables("pegawai").Clear()
        If Not ds1.Tables("spkmDetail") Is Nothing Then ds1.Tables("spkmDetail").Clear()
        If Not ds1.Tables("spkmMaster") Is Nothing Then ds1.Tables("spkmMaster").Clear()


        da1 = New SqlDataAdapter(New SqlCommand("select distinct(a.no_spk),a.no_rph " & _
                                                "from PROD.dbo.PROD_spk_m a " & _
                                                "inner join PROD.dbo.PROD_rcn_prod_m m " & _
                                                "on m.no_rph = a.no_rph " & _
                                                "where a.kd_departemen= '" & kddep & "' and m.jns_produksi <> 'SERVICE' " & _
                                                "or a.kd_departemen= '" & kddep & "' and m.jns_produksi is null and (a.sts_centi='Y') order by no_spk", sqlconn))
        da1.Fill(ds1, "nospk")
        txtNoSpk.Properties.DataSource = ds1.Tables("nospk")

        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where id_ref_file='GRPKERJA'", sqlconn))
        da1.Fill(ds1, "group")
        txtGroup.Properties.DataSource = ds1.Tables("group")

        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='JDWKRJ'", sqlconn))
        da1.Fill(ds1, "jadwal")
        txtJadwal.Properties.DataSource = ds1.Tables("jadwal")


        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Pegawai order by Nama_Pegawai", sqlconn))
        da1.Fill(ds1, "pegawai")
        txtPegawai.Properties.DataSource = ds1.Tables("pegawai")


        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where id_ref_file='KGTSPK'", sqlconn))
        da1.Fill(ds1, "jnsKdKeg")
        txtkgtn.Properties.DataSource = ds1.Tables("jnsKdKeg")

        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where id_ref_file='SPK'", sqlconn))
        da1.Fill(ds1, "jnsKeg")
        txtKegiatan.Properties.DataSource = ds1.Tables("jnsKeg")

        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_mesin_prod order by deskripsi ", sqlconn))
        da1.Fill(ds1, "mesin")
        txtMesin.Properties.DataSource = ds1.Tables("mesin")

        'da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_jenis_barang where kd_departemen='" & kddep & "'", sqlconn))
        'da1.Fill(ds1, "jnsBrg")



    End Sub

    Private Sub txtNoSpk_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoSpk.EditValueChanged
        If txtNoSpk.EditValue <> Nothing Then
            If State = "ADD" Then
                dread = New SqlClient.SqlCommand("select * FROM " & _
                            "(select distinct(no_rph)  from PROD.dbo.PROD_spk_m where no_spk='" & txtNoSpk.EditValue & "' ) spk " & _
                            "left join  " & _
                            "(select no_rph, kd_jadwal from PROD.dbo.PROD_rcn_prod_m) rph " & _
                            "on spk.no_rph=rph.no_rph", sqlconn).ExecuteReader
                dread.Read()
                txtJadwal.EditValue = dread.Item("kd_jadwal")
                dread.Close()

                If Not ds1.Tables("jnsKdKeg") Is Nothing Then ds1.Tables("jnsKdKeg").Clear()
                da1 = New SqlDataAdapter(New SqlCommand("select distinct(spk.kd_kegiatan) Id_Data, reff.Desc_Data from SIF.dbo.SIF_Gen_Reff_D reff  " & _
                                                        "left join PROD.dbo.PROD_spk_m spk on reff.Id_Data=spk.kd_kegiatan  " & _
                                                        "where spk.no_spk='" & txtNoSpk.EditValue & "' and reff.Id_Ref_Data='KGTSPK'", sqlconn))
                da1.Fill(ds1, "jnsKdKeg")
                txtkgtn.Properties.DataSource = ds1.Tables("jnsKdKeg")
                txtkgtn.Properties.ReadOnly = False
                txtGroup.Properties.ReadOnly = False
                txtPegawai.Properties.ReadOnly = False
                txtMesin.Properties.ReadOnly = False
            ElseIf State = "EDIT" Then

            End If

        End If

    End Sub
    Public Sub add_click()
        State = "ADD"
        reload()
        txtTgl.DateTime = Date.Today
        txtNoSpkMan.Text = ""
        txtNoSpk.Properties.ReadOnly = False
        txtGroup.Properties.ReadOnly = True
        txtPegawai.Properties.ReadOnly = True
        txtJadwal.Properties.ReadOnly = True
        txtkgtn.Properties.ReadOnly = True
        txtKegiatan.Properties.ReadOnly = True
        txtMesin.Properties.ReadOnly = True

        txtNoSpk.EditValue = Nothing
        txtGroup.EditValue = Nothing
        txtPegawai.EditValue = Nothing
        txtJadwal.EditValue = Nothing
        txtkgtn.EditValue = Nothing
        txtKegiatan.EditValue = Nothing
        txtMesin.EditValue = Nothing

        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False

        setStatus()
    End Sub

    Public Sub edit_click()
        Dim qstr As String = "select tanggal [Tanggal], no_spk_man [No SPK Man], no_spk [No SPK]  " & _
                "from PROD.dbo.PROD_spk_man_m where sts_centi='Y' order by tanggal "
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(qstr, sqlconn))
        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        da3.Fill(ds3, "lookup_so")

        frmCari.set_dso(ds3.Tables("lookup_so"))

        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            State = "EDIT"
            reload()
            If Not ds1.Tables("nospk") Is Nothing Then ds1.Tables("nospk").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("select distinct(no_spk), no_rph from PROD.dbo.PROD_spk_man_m order by no_spk", sqlconn))
            da1.Fill(ds1, "nospk")
            txtNoSpk.Properties.DataSource = ds1.Tables("nospk")

            qstr = "select P.* from PROD.dbo.PROD_spk_man_m P where P.no_spk_man='" & frmCari.row("No SPK Man") & "'"
            If Not ds1.Tables("spkmMaster") Is Nothing Then ds1.Tables("spkmMaster").Clear()
            da2 = New SqlDataAdapter(New SqlCommand(qstr, sqlconn))
            da2.Fill(ds1, "spkmMaster")
            Dim rowm As DataRow = ds1.Tables("spkmMaster").Rows(0)

            txtNoSpkMan.Text = rowm("no_spk_man")
            txtTgl.DateTime = rowm("tanggal")
            txtNoSpk.EditValue = rowm("no_spk")
            txtGroup.EditValue = rowm("group_kerja")
            txtPegawai.EditValue = rowm("kd_pegawai")
            txtMesin.EditValue = rowm("kd_mesin")
            txtKegiatan.EditValue = rowm("kd_kegiatan_spk")
            txtkgtn.EditValue = rowm("kd_kegiatan")

            If Not ds1.Tables("spkmDetail") Is Nothing Then ds1.Tables("spkmDetail").Clear()
            da3 = New SqlDataAdapter(New SqlCommand("select d.*, '' nama_barang,'' Nama_Tipe,'' Merk_Kain,'' Nama_Ukuran, 0 sisa from PROD.dbo.PROD_spk_man_d  d where no_spk='" & txtNoSpk.EditValue & "' and kd_kegiatan_spk='" & txtKegiatan.EditValue & "'  order by kd_barang", sqlconn))

            da3.Fill(ds1, "spkmDetail")
            Dim dr As SqlDataReader
            For Each rw As DataRow In ds1.Tables("spkmDetail").Rows
                dr = New SqlClient.SqlCommand("select S.kd_jenis,S.Nama_Barang, T.Nama_Tipe, K.Merk_Kain, U.Nama_Ukuran " & _
                                                               "from SIF.dbo.SIF_Barang S " & _
                                                               "left join SIF.dbo.SIF_Tipe T on S.kd_jenis=T.Kd_Jns and S.kd_tipe=T.Kode_Tipe " & _
                                                               "left join SIF.dbo.SIF_Ukuran U on S.kd_ukuran=U.Kode_Ukuran " & _
                                                               "left join SIF.dbo.SIF_Kain K on S.kd_kain=K.Kode_Kain " & _
                                                               "where S.kode_barang='" & rw.Item("kd_barang") & "'  ", sqlconn).ExecuteReader
                While dr.Read
                    rw.Item("Nama_Ukuran") = dr.Item("Nama_Ukuran")
                    rw.Item("Nama_Tipe") = dr.Item("Nama_Tipe")
                    rw.Item("Merk_Kain") = dr.Item("Merk_Kain")
                    rw.Item("nama_barang") = dr.Item("Nama_Barang")
                End While
                dr.Close()
            Next

            gc.DataSource = ds1.Tables("spkmDetail")

            If Not ds1.Tables("SoBox") Is Nothing Then ds1.Tables("SoBox").Clear()
            da6 = New SqlDataAdapter(New SqlCommand("SELECT * from PROD.dbo.PROD_rcn_prod_d ", sqlconn))
            da6.Fill(ds1, "SoBox")

            colD(0) = ds1.Tables("spkmDetil").Columns("no_rph")

            colDq(0) = ds1.Tables("SoBox").Columns("no_rph")

            rl = ds1.Relations.Add("Detail", colD, colDq, False)

            gc.DataSource = ds1.Tables("spkmDetil")
            gc.LevelTree.Nodes.Add("Detail", GridView1)


            txtNoSpk.Properties.ReadOnly = True
            txtJadwal.Properties.ReadOnly = True
            'txtkgtn.Properties.ReadOnly = True
            txtKegiatan.Properties.ReadOnly = True

            btnSave = True
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
        Dim tgl As Date = getTanggal()

        If State = "ADD" Then
            Dim filledrow As Integer = ds1.Tables("spkmDetail").Select("jumlah_kerja>0").Count
            If txtTgl.Text = "" Then
                MessageBox.Show("Tanggal Belum Diisi")
                Exit Sub
            End If
            If txtNoSpk.EditValue = "" Then
                MessageBox.Show("No SPK Belum Dipilih")
                Exit Sub
            End If
            If txtGroup.EditValue = "" Then
                MessageBox.Show("Group Kerja Belum Dipilih")
                Exit Sub
            End If
            If txtKegiatan.EditValue = "" Then
                MessageBox.Show("Kegiatan Belum Dipilih")
                Exit Sub
            End If
            If filledrow = 0 Then
                MessageBox.Show("Jumlah Kerja Belum Ada Yang Diisi")
                Exit Sub
            End If
            If Not ds1.Tables("spkmMaster") Is Nothing Then ds1.Tables("spkmMaster").Clear()
            da2 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_spk_man_m  d where 1=0", sqlconn))
            da2.Fill(ds1, "spkmMaster")

            dread = New SqlClient.SqlCommand("select distinct(no_rph)  from PROD.dbo.PROD_spk_m where no_spk='" & txtNoSpk.EditValue & "'", sqlconn).ExecuteReader
            dread.Read()
            Dim rphtmp = dread.Item("no_rph")
            dread.Close()


            Dim BTRANS As SqlTransaction
            Dim mb As New SqlCommandBuilder
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
            notrans = getNoTrans("PRODSPKM", tgl, BTRANS)
            txtNoSpkMan.Text = notrans


            Dim rowm As DataRow
            rowm = ds1.Tables("spkmMaster").NewRow
            rowm("tanggal") = tgl
            rowm("no_rph") = rphtmp
            rowm("no_spk") = txtNoSpk.Text
            rowm("sts_centi") = "Y"
            rowm("no_spk_man") = notrans
            rowm("kd_kegiatan_spk") = txtKegiatan.EditValue
            rowm("kd_kegiatan") = txtkgtn.EditValue
            rowm("group_kerja") = txtGroup.EditValue
            rowm("kd_pegawai") = txtPegawai.EditValue
            rowm("kd_mesin") = txtMesin.EditValue
            rowm("kd_cabang") = kdcabang
            rowm("kd_departemen") = kddep
            rowm("last_create_date") = tgl
            rowm("last_created_by") = username
            rowm("last_update_date") = tgl
            rowm("last_updated_by") = username
            rowm("program_name") = Me.Name

            ds1.Tables("spkmMaster").Rows.Add(rowm)

            For i = ds1.Tables("spkmDetail").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = ds1.Tables("spkmDetail").Rows(i)
                If Not TypeOf rows("jumlah_kerja") Is DBNull Then
                    If rows("jumlah_kerja") > 0 Then
                        rows("no_spk_man") = notrans
                        rows("last_create_date") = tgl
                        rows("last_created_by") = username
                        rows("last_update_date") = tgl
                        rows("last_updated_by") = username
                        rows("program_name") = Me.Name
                        rows("kd_cabang") = kdcabang
                        rows("kd_departemen") = kddep
                    Else
                        ds1.Tables("spkmDetail").Rows(i).Delete()
                    End If
                Else
                    ds1.Tables("spkmDetail").Rows(i).Delete()
                End If
            Next

            Try

                da2.Update(ds1.Tables("spkmMaster"))
                da3.Update(ds1.Tables("spkmDetail"))
                ds1.Tables("spkmMaster").AcceptChanges()
                ds1.Tables("spkmDetail").AcceptChanges()

                State = "EDIT"
                BTRANS.Commit()
                btnSave = False
                setStatus()
                showMessages("Data Berhasil Disimpan")
            Catch e As Exception
                BTRANS.Rollback()
                ds1.Tables("spkmMaster").RejectChanges()
                ds1.Tables("spkmDetail").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

                txtNoSpkMan.Text = ""
                txtJadwal.EditValue = Nothing
                reload()
            End Try
        ElseIf State = "EDIT" Then
            Dim filledrow As Integer = ds1.Tables("spkmDetail").Select("jumlah_kerja>0").Count
            If filledrow = 0 Then
                MessageBox.Show("Jumlah Kerja Belum Ada Yang Diisi")
                Exit Sub
            End If

            Dim rowm As DataRow
            rowm = ds1.Tables("spkmMaster").Rows(0)
            rowm("group_kerja") = txtGroup.EditValue
            rowm("kd_pegawai") = txtPegawai.EditValue
            rowm("kd_mesin") = txtMesin.EditValue
            rowm("sts_centi") = "Y"
            Dim mybuilder As New SqlCommandBuilder(da2)
            da2.UpdateCommand = mybuilder.GetUpdateCommand
            da2.Update(ds1.Tables("spkmMaster"))
            ds1.Tables("spkmMaster").AcceptChanges()

            For i = ds1.Tables("spkmDetail").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = ds1.Tables("spkmDetail").Rows(i)
                If Not TypeOf rows("jumlah_kerja") Is DBNull Then
                    If rows("jumlah_kerja") > 0 Then
                        rows("last_update_date") = tgl
                        rows("last_updated_by") = username
                    Else
                        ds1.Tables("spkmDetail").Rows(i).Delete()
                    End If
                Else
                    ds1.Tables("spkmDetail").Rows(i).Delete()
                End If
            Next

            Dim mybuilder2 As New SqlCommandBuilder(da3)
            da3.UpdateCommand = mybuilder2.GetUpdateCommand
            da3.Update(ds1.Tables("spkmDetail"))
            ds1.Tables("spkmDetail").AcceptChanges()
            showMessages("Data Berhasil Disimpan")

        End If

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
        btnadd = True
        setStatus()
        Me.Enabled = False
    End Sub

    Private Sub txtKegiatan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKegiatan.EditValueChanged
        If State = "ADD" Then
            If Not txtKegiatan.EditValue Is Nothing Then
                loadDetail()
            End If
        End If

    End Sub

    Private Sub loadKapasitas()
        txtkgtn.Text = 0
        da1 = New SqlDataAdapter(New SqlCommand("select * " & _
                                                "from PROD.dbo.prod_spk_m " & _
                                                "where no_trans='" & txtNoSpk.EditValue & "' " & _
                                                "and kd_kegiatan = '" & txtKegiatan.EditValue & "'", sqlconn))
        If Not ds1.Tables("rph") Is Nothing Then ds1.Tables("rph").Clear()
        da1.Fill(ds1, "rph")
        If ds1.Tables("rph").Rows.Count > 0 Then
            txtkgtn.Text = ds1.Tables("rph").Rows(0).Item("kapasitas")
        End If
    End Sub
    Private Sub loadDetail()
        If Not ds1.Tables("spkmDetail") Is Nothing Then ds1.Tables("spkmDetail").Clear()
        da3 = New SqlDataAdapter(New SqlCommand("select d.*, '' nama_barang,0.0 no_urut_brg,'' Nama_Tipe,'' Merk_Kain,'' Nama_Ukuran, 0 sisa from PROD.dbo.PROD_spk_man_d  d where 1=0", sqlconn))
        da3.Fill(ds1, "spkmDetail")
        Dim dr As SqlDataReader = New SqlClient.SqlCommand("select P.*,S.kd_jenis,S.Nama_Barang, T.Nama_Tipe, K.Merk_Kain, U.Nama_Ukuran " & _
                                                           "from PROD.dbo.PROD_spk_d P " & _
                                                           "left join SIF.dbo.SIF_Barang S on P.kd_barang = S.Kode_Barang " & _
                                                           "left join SIF.dbo.SIF_Tipe T on S.kd_jenis=T.Kd_Jns and S.kd_tipe=T.Kode_Tipe " & _
                                                           "left join SIF.dbo.SIF_Ukuran U on S.kd_ukuran=U.Kode_Ukuran " & _
                                                           "left join SIF.dbo.SIF_Kain K on S.kd_kain=K.Kode_Kain " & _
                                                           "where P.no_spk='" & txtNoSpk.EditValue & "' " & _
                                                           "and P.kd_kegiatan_spk='" & txtKegiatan.EditValue & "'  " & _
                                                           "and P.kd_kegiatan ='" & txtkgtn.EditValue & "' " & _
                                                           "order by kd_barang", sqlconn).ExecuteReader

        While dr.Read
            Dim rw As DataRow = ds1.Tables("spkmDetail").NewRow
            rw("no_rph") = dr.Item("no_rph")
            rw("no_spk") = dr.Item("no_spk")
            rw("kd_kegiatan_spk") = dr.Item("kd_kegiatan_spk")
            rw("kd_barang") = dr.Item("kd_barang")
            rw("no_urut_brg") = dr.Item("no_urut_brg")
            rw("kd_kegiatan") = dr.Item("kd_kegiatan")
            rw("Nama_Ukuran") = dr.Item("Nama_Ukuran")
            rw("Nama_Tipe") = dr.Item("Nama_Tipe")
            rw("Merk_Kain") = dr.Item("Merk_Kain")
            rw("jumlah_produksi") = dr.Item("jumlah_produksi")
            rw("nama_barang") = dr.Item("Nama_Barang")
            rw("jumlah_kerja") = 0

            ds1.Tables("spkmDetail").Rows.Add(rw)
        End While
        dr.Close()
        If Not ds1.Tables("SoBox") Is Nothing Then ds1.Tables("SoBox").Clear()
        da6 = New SqlDataAdapter(New SqlCommand("SELECT d.* from PROD.dbo.PROD_rcn_prod_d d " & _
                                                "inner join PROD.dbo.PROD_spk_d s " & _
                                                "on s.no_rph = d.no_rph and s.no_urut_brg = d.no_urut_brg " & _
                                                "where s.no_spk='" & txtNoSpk.EditValue & "' " & _
                                                "and s.kd_kegiatan ='" & txtkgtn.EditValue & "' " & _
                                                "and s.kd_kegiatan_spk = '" & txtKegiatan.EditValue & "' ", sqlconn))
        da6.Fill(ds1, "SoBox")


        colD1(0) = ds1.Tables("spkmDetail").Columns("no_rph")
        'colD1(1) = ds1.Tables("spkmDetail").Columns("kd_barang")
        colD1(1) = ds1.Tables("spkmDetail").Columns("no_urut_brg")


        colD2(0) = ds1.Tables("SoBox").Columns("no_rph")
        'colD2(1) = ds1.Tables("SoBox").Columns("kd_barang")
        colD2(1) = ds1.Tables("SoBox").Columns("no_urut_brg")
        ds1.Relations.Clear()

        rl = ds1.Relations.Add("Detail", colD1, colD2, False)
        gc.DataSource = ds1.Tables("spkmDetail")
        gc.LevelTree.Nodes.Add("Detail", GV_Detail)
    End Sub

    Private Sub gv_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gv.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gv_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gv.ValidateRow
        Dim isValid As Boolean = True
        If e.Row("jumlah_kerja") > e.Row("jumlah_produksi") Then
            gv.SetColumnError(jumlah_kerja, "Jumlah Kerja Terlalu Banyak", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            isValid = False
        End If
        e.Valid = isValid
    End Sub

    Private Sub txtkgtn_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtkgtn.EditValueChanged
        If State = "ADD" Then
            If Not txtkgtn.EditValue Is Nothing Then
                If Not ds1.Tables("jnsKeg") Is Nothing Then ds1.Tables("jnsKeg").Clear()
                da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D reff  " & _
                        "left join PROD.dbo.PROD_spk_m spk on reff.Id_Data=spk.kd_kegiatan_spk " & _
                        "where spk.no_spk='" & txtNoSpk.EditValue & "' and kd_kegiatan='" & txtkgtn.EditValue & "' and reff.id_ref_file='SPK' ", sqlconn))
                da1.Fill(ds1, "jnsKeg")
                txtKegiatan.Properties.DataSource = ds1.Tables("jnsKeg")
                txtKegiatan.Properties.ReadOnly = False
            End If
        End If
    End Sub
End Class