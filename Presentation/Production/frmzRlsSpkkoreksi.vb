Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Public Class frmzRlsSpkkoreksi
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Dim myBuilder As New SqlCommandBuilder
    Dim ds1, ds2, ds3, ds4 As New DataSet
    Dim da1, da2, da3, da4 As New SqlDataAdapter
    Dim jumlah As Integer
    Dim dread As SqlDataReader
    Dim y As Integer
    Dim j As Integer
    Dim total As Integer
    Dim s As Integer
    Dim u As Integer
    Dim isValid As Boolean = True
    Dim awal As Boolean

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
      
    End Sub
    Private Sub frmzRlsSpkkoreksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)

        If Not ds1.Tables("spkmMaster") Is Nothing Then ds1.Tables("spkmMaster").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rls_spk_man_koreksi_m where 1=0", sqlconn))
        da2.Fill(ds1, "spkmMaster")
        If Not ds1.Tables("spkmDetil") Is Nothing Then ds1.Tables("spkmDetil").Clear()
        da3 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rls_spk_man_koreksi_d where 1=0", sqlconn))
        da3.Fill(ds1, "spkmDetil")

    End Sub
    Private Sub reload()
       
        If Not ds1.Tables("nospk") Is Nothing Then ds1.Tables("nospk").Clear()
        If Not ds1.Tables("group") Is Nothing Then ds1.Tables("group").Clear()
        If Not ds1.Tables("jadwal") Is Nothing Then ds1.Tables("jadwal").Clear()
        If Not ds1.Tables("jam") Is Nothing Then ds1.Tables("jam").Clear()
        If Not ds1.Tables("jnsKdKeg") Is Nothing Then ds1.Tables("jnsKdKeg").Clear()
        If Not ds1.Tables("jnsKeg") Is Nothing Then ds1.Tables("jnsKeg").Clear()
        If Not ds1.Tables("jnsBrg") Is Nothing Then ds1.Tables("jnsBrg").Clear()
        If Not ds1.Tables("mesin") Is Nothing Then ds1.Tables("mesin").Clear()
        If Not ds1.Tables("pegawai") Is Nothing Then ds1.Tables("pegawai").Clear()


    
        da1 = New SqlDataAdapter(New SqlCommand("select no_spk_man from PROD.dbo.PROD_rls_spk_man_m where no_spk_man_rls='" & lkspkreal.EditValue & "'", sqlconn))
        da1.Fill(ds1, "nospk")
        lkspk.Properties.DataSource = ds1.Tables("nospk")

        For i As Integer = 0 To ds1.Tables("nospk").Rows.Count - 1
            lkspk.EditValue = IIf(ds1.Tables("nospk").Rows.Count > 0, ds1.Tables("nospk").Rows(i).Item("no_spk_man"), "")
        Next

        da1 = New SqlDataAdapter(New SqlCommand("select a.Desc_Data,a.Id_Data from SIF.dbo.SIF_Gen_Reff_D a inner join PROD.dbo.PROD_rls_spk_man_m b on a.id_Data=b.group_kerja where id_ref_file='GRPKERJA' and b.no_spk_man_rls='" & lkspkreal.EditValue & "' ", sqlconn))
        da1.Fill(ds1, "group")
        txtGroup.Properties.DataSource = ds1.Tables("group")

        txtGroup.EditValue = IIf(ds1.Tables("group").Rows.Count > 0, ds1.Tables("group").Rows(0).Item("ID_Data"), "")

        da1 = New SqlDataAdapter(New SqlCommand("select a.Desc_Data,a.Id_Data from SIF.dbo.SIF_Gen_Reff_D a inner join PROD.dbo.PROD_rls_spk_man_m b on a.id_Data=b.kd_jam where Id_Ref_Data='JAMPROD' and b.no_spk_man_rls='" & lkspkreal.EditValue & "' ", sqlconn))
        da1.Fill(ds1, "jam")
        txtJam.Properties.DataSource = ds1.Tables("jam")

        txtJam.EditValue = IIf(ds1.Tables("jam").Rows.Count > 0, ds1.Tables("jam").Rows(0).Item("Id_Data"), "")

        da1 = New SqlDataAdapter(New SqlCommand("select a.Desc_Data,a.Id_Data from SIF.dbo.SIF_Gen_Reff_D a inner join PROD.dbo.PROD_rls_spk_man_m b on a.id_Data=b.kd_jam  where Id_Ref_Data='JDWKRJ' and b.no_spk_man_rls='" & lkspkreal.EditValue & "'", sqlconn))
        da1.Fill(ds1, "jadwal")
        txtJadwal.Properties.DataSource = ds1.Tables("jadwal")

        txtJadwal.EditValue = IIf(ds1.Tables("jadwal").Rows.Count > 0, ds1.Tables("jadwal").Rows(0).Item("Id_Data"), "")

        da1 = New SqlDataAdapter(New SqlCommand("select a.Nama_Pegawai,a.Kode_Pegawai from SIF.dbo.SIF_Pegawai a inner join PROD.dbo.PROD_rls_spk_man_m b on a.Kode_Pegawai=b.kd_pegawai where b.no_spk_man_rls='" & lkspkreal.EditValue & "'", sqlconn))
        da1.Fill(ds1, "pegawai")
        txtPegawai.Properties.DataSource = ds1.Tables("pegawai")

        txtPegawai.EditValue = IIf(ds1.Tables("pegawai").Rows.Count > 0, ds1.Tables("pegawai").Rows(0).Item("Kode_Pegawai"), "")

        da1 = New SqlDataAdapter(New SqlCommand("select a.Desc_Data,a.Id_Data from SIF.dbo.SIF_Gen_Reff_D a inner join PROD.dbo.PROD_rls_spk_man_m b on a.id_Data=b.kd_kegiatan_spk where id_ref_file='KGTSPK' and b.no_spk_man_rls='" & lkspkreal.EditValue & "'", sqlconn))
        da1.Fill(ds1, "jnsKdKeg")
        txtkgtn.Properties.DataSource = ds1.Tables("jnsKdKeg")

        txtkgtn.EditValue = IIf(ds1.Tables("jnsKdKeg").Rows.Count > 0, ds1.Tables("jnsKdKeg").Rows(0).Item("Id_Data"), "")

        da1 = New SqlDataAdapter(New SqlCommand("select  a.Desc_Data,a.Id_Data  from SIF.dbo.SIF_Gen_Reff_D a  inner join PROD.dbo.PROD_rls_spk_man_m b on a.id_Data=b.kd_kegiatan where id_ref_file='SPK' and b.no_spk_man_rls='" & lkspkreal.EditValue & "'", sqlconn))
        da1.Fill(ds1, "jnsKeg")
        txtKegiatan.Properties.DataSource = ds1.Tables("jnsKeg")

        txtKegiatan.EditValue = IIf(ds1.Tables("jnsKeg").Rows.Count > 0, ds1.Tables("jnsKeg").Rows(0).Item("Id_Data"), "")

        da1 = New SqlDataAdapter(New SqlCommand("select a.deskripsi,a.kd_mesin from SIF.dbo.SIF_mesin_prod a  inner join PROD.dbo.PROD_rls_spk_man_m b on a.kd_mesin=b.kd_mesin where b.no_spk_man_rls='" & lkspkreal.EditValue & "'", sqlconn))
        da1.Fill(ds1, "mesin")
        txtMesin.Properties.DataSource = ds1.Tables("mesin")

        txtMesin.EditValue = IIf(ds1.Tables("mesin").Rows.Count > 0, ds1.Tables("mesin").Rows(0).Item("kd_mesin"), "")

    End Sub

  
    Sub isidetil()
        If Not ds1.Tables("detil") Is Nothing Then ds1.Tables("detil").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select u.Nama_Ukuran,m.Merk_Kain,t.Nama_Tipe,b.Nama_Barang,a.no_spk_man,a.no_spk_man_rls,a.kd_cabang,a.jumlah,a.jumlah_delay,a.jumlah_delay,a.jumlah_kerja,a.jumlah_realisasi,a.jumlah_rework,a.jumlah_sisa,a.kd_barang,a.kd_cabang,a.kd_departemen,a.kd_kegiatan,a.keterangan,a.kd_kegiatan_spk,'0' jumlah_koreksi,sum(isnull(k.jumlah_koreksi,0)) jumlahk from PROD.dbo.PROD_rls_spk_man_d a " & _
                                                "left join PROD.dbo.PROD_rls_spk_man_koreksi_d k on k.no_spk_man_rls=a.no_spk_man_rls and k.no_spk_man=a.no_spk_man and k.kd_barang=a.kd_barang and k.kd_kegiatan=a.kd_kegiatan " & _
                                              "left join SIF.dbo.Sif_barang b on a.kd_barang=b.kode_barang " & _
                                              "left join sif.dbo.sif_tipe t on b.kd_tipe=t.kode_tipe " & _
                                              "left join sif.dbo.sif_kain m on b.kd_kain=m.kode_kain " & _
                                              "left join sif.dbo.SIF_ukuran u on b.kd_ukuran=u.kode_ukuran " & _
                                              "where a.no_spk_man_rls='" & lkspkreal.EditValue & "' " & _
                                              "group by u.Nama_Ukuran,m.Merk_Kain,t.Nama_Tipe,b.Nama_Barang,a.no_spk_man,a.no_spk_man_rls,a.kd_cabang,a.jumlah,a.jumlah_delay,a.jumlah_delay,a.jumlah_kerja,a.jumlah_realisasi,a.jumlah_rework,a.jumlah_sisa,a.kd_barang,a.kd_cabang,a.kd_departemen,a.kd_kegiatan,a.keterangan,a.kd_kegiatan_spk ", sqlconn))
        da1.Fill(ds1, "detil")

        gc.DataSource = ds1.Tables("detil")
    End Sub
    Public Sub add_click()
        State = "ADD"


        If Not ds1.Tables("nospkrealisasi") Is Nothing Then ds1.Tables("nospkrealisasi").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select no_spk_man_rls  from PROD.dbo.PROD_rls_spk_man_m where kd_departemen ='" & kddep & "'", sqlconn))
        da1.Fill(ds1, "nospkrealisasi")
        lkspkreal.Properties.DataSource = ds1.Tables("nospkrealisasi")

        lkspkreal.Properties.ReadOnly = False
        lkspk.Properties.ReadOnly = True
        txtGroup.Properties.ReadOnly = True
        txtPegawai.Properties.ReadOnly = True
        txtJadwal.Properties.ReadOnly = True
        txtkgtn.Properties.ReadOnly = True
        txtKegiatan.Properties.ReadOnly = True
        txtMesin.Properties.ReadOnly = True

        lkspk.EditValue = Nothing
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
        awal = True
        Dim qstr As String = "select no_spk_man_koreksi [NO KOREKSI], tanggal [Tanggal], no_spk_man_rls [No SPK Rls], no_spk_man [No SPK]  " & _
                "from PROD.dbo.PROD_rls_spk_man_koreksi_m order by tanggal "
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(qstr, sqlconn))
        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        da3.Fill(ds3, "lookup_so")

        frmCari.set_dso(ds3.Tables("lookup_so"))

        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            State = "EDIT"

            If State = "EDIT" Then
                lkspkreal.Properties.ReadOnly = True
                If Not ds1.Tables("spkmMaster") Is Nothing Then ds1.Tables("spkmMaster").Clear()
                qstr = "select * from PROD.dbo.PROD_rls_spk_man_koreksi_m  where no_spk_man_koreksi='" & frmCari.row("NO KOREKSI") & "'"
                da2 = New SqlDataAdapter(New SqlCommand(qstr, sqlconn))
                da2.Fill(ds1, "spkmMaster")
                lkspkreal.Properties.DataSource = ds1.Tables("spkmMaster")
                Dim rowm As DataRow = ds1.Tables("spkmMaster").Rows(0)

                TextEdit1.Text = rowm("no_spk_man_koreksi")
                lkspkreal.EditValue = rowm("no_spk_man_rls")
                
                If Not ds1.Tables("spkmDetil") Is Nothing Then ds1.Tables("spkmDetil").Clear()
                da3 = New SqlDataAdapter(New SqlCommand("select *, '' Nama_Barang,'' Nama_Tipe,'' Merk_Kain,'' Nama_Ukuran,jumlah_delay,jumlah_koreksi,jumlah jumlahk from PROD.dbo.PROD_rls_spk_man_koreksi_d  where  no_spk_man_koreksi='" & frmCari.row("NO KOREKSI") & "' order by kd_barang", sqlconn))

                da3.Fill(ds1, "spkmDetil")

                Dim dr As SqlDataReader
                For Each rw As DataRow In ds1.Tables("spkmDetil").Rows


                    dr = New SqlClient.SqlCommand("select d.kd_barang,d.jumlah_delay,b.Nama_Barang,t.Nama_Tipe,m.Merk_Kain,u.Nama_Ukuran,d.jumlah_realisasi,d.jumlah_kerja,d.jumlah_sisa,0 as jumlah_rework,0 as jumlah_delay,d.jumlah_koreksi,sum(d.jumlah_koreksi) as jumlahk " & _
                    "from PROD.dbo.PROD_rls_spk_man_koreksi_d d " & _
                    "left join SIF.dbo.Sif_barang b on d.kd_barang=b.kode_barang " & _
                    "left join sif.dbo.sif_tipe t on b.kd_tipe=t.kode_tipe " & _
                    "left join sif.dbo.sif_kain m on b.kd_kain=m.kode_kain " & _
                    "left join sif.dbo.SIF_ukuran u on b.kd_ukuran=u.kode_ukuran " & _
                    "where  d.no_spk_man_koreksi='" & frmCari.row("NO KOREKSI") & "'" & _
                    "group by  d.kd_barang,d.jumlah_delay,b.Nama_Barang,t.Nama_Tipe,m.Merk_Kain,u.Nama_Ukuran,d.jumlah_realisasi,d.jumlah_kerja,d.jumlah_sisa,jumlah_rework,jumlah_delay,d.jumlah_koreksi", sqlconn).ExecuteReader


                    While dr.Read
                        If rw.Item("kd_barang") = dr.Item("kd_barang") Then
                            rw.Item("Nama_Ukuran") = dr.Item("Nama_Ukuran")
                            rw.Item("Nama_Tipe") = dr.Item("Nama_Tipe")
                            rw.Item("Merk_Kain") = dr.Item("Merk_Kain")
                            rw.Item("Nama_Barang") = dr.Item("Nama_Barang")
                            rw.Item("jumlah_kerja") = dr.Item("jumlah_kerja")
                            rw.Item("jumlah_sisa") = dr.Item("jumlah_sisa")
                            rw.Item("jumlah_rework") = dr.Item("jumlah_rework")
                            rw.Item("jumlah_delay") = dr.Item("jumlah_delay")
                            rw.Item("jumlah_koreksi") = dr.Item("jumlah_koreksi")
                            rw.Item("jumlahk") = dr.Item("jumlah_koreksi")
                        Else

                        End If
                    End While
                    dr.Close()
                Next

                gc.DataSource = ds1.Tables("spkmDetil")


                txtKegiatan.Properties.ReadOnly = True
                txtJadwal.Properties.ReadOnly = True
                txtkgtn.Properties.ReadOnly = True
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
        End If
    End Sub
    Public Sub save_click()

        Dim tgl As Date = getTanggal()



        If State = "ADD" Then
            Dim filledrow As Integer = ds1.Tables("detil").Select("jumlah_kerja>0").Count

            If txtKegiatan.EditValue = "" Then
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

            If awal = True Then
                Dim notrans As String
                notrans = getNoTrans("SPKKOR", tgl, BTRANS)
                TextEdit1.Text = notrans
            End If

            Dim rowm As DataRow
            rowm = ds1.Tables("spkmMaster").NewRow
            rowm("no_spk_man_koreksi") = TextEdit1.Text
            rowm("kd_cabang") = kdcabang
            rowm("kd_departemen") = kddep
            rowm("tanggal") = tgl
            rowm("no_spk_man") = lkspk.EditValue
            rowm("no_spk_man_rls") = lkspkreal.EditValue
            rowm("kd_kegiatan") = txtKegiatan.EditValue
            rowm("kd_kegiatan_spk") = txtkgtn.EditValue
            rowm("group_kerja") = txtGroup.EditValue
            rowm("kd_pegawai") = txtPegawai.EditValue
            rowm("kd_mesin") = txtMesin.EditValue
            rowm("kd_jam") = txtJam.EditValue
            rowm("last_create_date") = tgl
            rowm("last_created_by") = username
            rowm("last_update_date") = tgl
            rowm("last_updated_by") = username
            rowm("program_name") = Me.Name



            ds1.Tables("spkmMaster").Rows.Add(rowm)

            For i = ds1.Tables("detil").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = ds1.Tables("detil").Rows(i)
                If Not TypeOf rows("jumlah_kerja") Is DBNull Then
                    If rows("jumlah_kerja") > 0 Then
                        Dim nr As DataRow = ds1.Tables("spkmDetil").NewRow()
                        nr("kd_cabang") = kdcabang
                        nr("kd_departemen") = kddep
                        nr("no_spk_man") = lkspk.EditValue
                        nr("no_spk_man_koreksi") = TextEdit1.Text
                        nr("no_spk_man_rls") = lkspkreal.EditValue
                        nr("kd_kegiatan") = txtKegiatan.EditValue
                        nr("kd_kegiatan_spk") = txtkgtn.EditValue
                        nr("kd_barang") = rows("kd_barang")
                        nr("jumlah_delay") = rows("jumlah_delay")
                        nr("jumlah_realisasi") = rows("jumlah_realisasi")
                        nr("jumlah_kerja") = rows("jumlah_kerja")
                        nr("jumlah_rework") = rows("jumlah_rework")
                        nr("jumlah_sisa") = rows("jumlah_sisa")
                        nr("jumlah_koreksi") = rows("jumlah_koreksi")
                        nr("last_create_date") = tgl
                        nr("last_created_by") = username
                        nr("last_update_date") = tgl
                        nr("last_updated_by") = username
                        nr("program_name") = Me.Name
                        ds1.Tables("spkmDetil").Rows.Add(nr)

                    End If

                End If
            Next

            Try

                da2.Update(ds1.Tables("spkmMaster"))
                da3.Update(ds1.Tables("spkmDetil"))
                ds1.Tables("spkmMaster").AcceptChanges()
                ds1.Tables("spkmDetil").AcceptChanges()

                State = "EDIT"
                BTRANS.Commit()
                btnSave = False
                setStatus()
                showMessages("Data Berhasil Disimpan")

            Catch e As Exception
                BTRANS.Rollback()
                ds1.Tables("spkmMaster").RejectChanges()
                ds1.Tables("spkmDetil").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
                isidetil()

                txtJadwal.EditValue = Nothing

            End Try
        ElseIf State = "EDIT" Then


            Dim rowm As DataRow
            rowm = ds1.Tables("spkmMaster").Rows(0)
            rowm("group_kerja") = txtGroup.EditValue
            rowm("kd_pegawai") = txtPegawai.EditValue
            rowm("kd_mesin") = txtMesin.EditValue
            Dim mybuilder As New SqlCommandBuilder(da2)
            da2.UpdateCommand = mybuilder.GetUpdateCommand
            da2.Update(ds1.Tables("spkmMaster"))
            ds1.Tables("spkmMaster").AcceptChanges()

            For i = ds1.Tables("spkmDetil").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = ds1.Tables("spkmDetil").Rows(i)
                If Not TypeOf rows("jumlah_kerja") Is DBNull Then
                    If rows("jumlah_kerja") > 0 Then
                        rows("last_update_date") = tgl
                        rows("last_updated_by") = username
                    Else
                        ds1.Tables("spkmDetil").Rows(i).Delete()
                    End If
                Else
                    ds1.Tables("spkmDetil").Rows(i).Delete()
                End If
            Next
        End If
        Dim mybuilder2 As New SqlCommandBuilder(da3)
        da3.UpdateCommand = mybuilder2.GetUpdateCommand
        da3.Update(ds1.Tables("spkmDetil"))
        ds1.Tables("spkmDetil").AcceptChanges()
        showMessages("Data Berhasil Disimpan")
        'Simpan_Hpp_Produksi()



    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            showMessages("Deleted..")
            'cancel_click()
        End If
    End Sub

    Public Sub cancel_click()
        If State = "ADD" Then
            isValid = True
            If Not ds1.Tables("spkmDetil") Is Nothing Then ds1.Tables("spkmDetil").Clear()
            If Not ds1.Tables("detil") Is Nothing Then ds1.Tables("detil").Clear()
            If Not ds1.Tables("nospk") Is Nothing Then ds1.Tables("nospk").Clear()
            If Not ds1.Tables("group") Is Nothing Then ds1.Tables("group").Clear()
            If Not ds1.Tables("jadwal") Is Nothing Then ds1.Tables("jadwal").Clear()
            If Not ds1.Tables("jam") Is Nothing Then ds1.Tables("jam").Clear()
            If Not ds1.Tables("jnsKdKeg") Is Nothing Then ds1.Tables("jnsKdKeg").Clear()
            If Not ds1.Tables("jnsKeg") Is Nothing Then ds1.Tables("jnsKeg").Clear()
            If Not ds1.Tables("jnsBrg") Is Nothing Then ds1.Tables("jnsBrg").Clear()
            If Not ds1.Tables("mesin") Is Nothing Then ds1.Tables("mesin").Clear()
            If Not ds1.Tables("pegawai") Is Nothing Then ds1.Tables("pegawai").Clear()


        ElseIf State = "EDIT" Then
            If Not ds1.Tables("detil") Is Nothing Then ds1.Tables("detil").Clear()
            If Not ds1.Tables("spkmDetil") Is Nothing Then ds1.Tables("spkmDetil").Clear()
            If Not ds1.Tables("nospk") Is Nothing Then ds1.Tables("nospk").Clear()
            If Not ds1.Tables("group") Is Nothing Then ds1.Tables("group").Clear()
            If Not ds1.Tables("jadwal") Is Nothing Then ds1.Tables("jadwal").Clear()
            If Not ds1.Tables("jam") Is Nothing Then ds1.Tables("jam").Clear()
            If Not ds1.Tables("jnsKdKeg") Is Nothing Then ds1.Tables("jnsKdKeg").Clear()
            If Not ds1.Tables("jnsKeg") Is Nothing Then ds1.Tables("jnsKeg").Clear()
            If Not ds1.Tables("jnsBrg") Is Nothing Then ds1.Tables("jnsBrg").Clear()
            If Not ds1.Tables("mesin") Is Nothing Then ds1.Tables("mesin").Clear()
            If Not ds1.Tables("pegawai") Is Nothing Then ds1.Tables("pegawai").Clear()
        End If

        gc.DataSource = ""

        TextEdit1.Text = ""
        isValid = True
        jumlah = 0
        y = 0
        j = 0
        total = 0
        s = 0
        u = 0

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
    End Sub

    Private Sub gv_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gv.CellValueChanged
        Dim view As ColumnView = sender

        If State = "ADD" Then
            If e.Column Is jumlah_koreksi Then

                If awal = True Then
                    If Not ds1.Tables("cekjml") Is Nothing Then ds1.Tables("cekjml").Clear()
                    da1 = New SqlDataAdapter(New SqlCommand("select *,'0.00' jumlah_koreksi,'0.00' jumlahk from PROD.dbo.PROD_rls_spk_man_d a " & _
                                                  "left join SIF.dbo.Sif_barang b on a.kd_barang=b.kode_barang  " & _
                                                  "left join sif.dbo.sif_tipe t on b.kd_tipe=t.kode_tipe  " & _
                                                  "left join sif.dbo.sif_kain m on b.kd_kain=m.kode_kain " & _
                                                  "left join sif.dbo.SIF_ukuran u on b.kd_ukuran=u.kode_ukuran " & _
                                                  "where no_spk_man_rls='" & lkspkreal.EditValue & "'", sqlconn))
                    da1.Fill(ds1, "cekjml")


                Else
                    If Not ds1.Tables("cekjml") Is Nothing Then ds1.Tables("cekjml").Clear()
                    da1 = New SqlDataAdapter(New SqlCommand("select no_spk_man,no_spk_man_rls,sum(jumlah_koreksi) jumlahk from PROD.dbo.PROD_rls_spk_man_koreksi_d  " & _
                                                              "where no_spk_man_rls='" & lkspkreal.EditValue & "' and no_spk_man='" & lkspk.EditValue & "'" & _
                                                              "group by no_spk_man,no_spk_man_rls", sqlconn))
                    da1.Fill(ds1, "cekjml")


                End If



                total = view.GetRowCellValue(e.RowHandle, "jumlah_kerja")
                s = view.GetRowCellValue(e.RowHandle, "jumlah_koreksi")

                y = view.GetRowCellValue(e.RowHandle, "jumlahk") + s


                If y > total Then

                    gv.SetColumnError(jumlah_kerja, "Jumlah Dikerjakan tidak boleh lebih besar dari Jumlah Koreksi", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                    showMessages("Data kelebihan:" & y - total)
                End If
            End If
        ElseIf State = "EDIT" Then
            If e.Column Is jumlah_koreksi Then


    
                If Not ds1.Tables("cekjmlq") Is Nothing Then ds1.Tables("cekjmlq").Clear()
                da1 = New SqlDataAdapter(New SqlCommand("select no_spk_man,no_spk_man_rls,jumlah_koreksi from PROD.dbo.PROD_rls_spk_man_koreksi_d  " & _
                                                          "where no_spk_man_rls='" & frmCari.row("NO SPK Rls") & "' and no_spk_man='" & frmCari.row("NO SPK") & "' and  no_spk_man_koreksi='" & frmCari.row("NO KOREKSI") & "'", sqlconn))
                da1.Fill(ds1, "cekjmlq")

                total = view.GetRowCellValue(e.RowHandle, "jumlah_kerja")
                s = view.GetRowCellValue(e.RowHandle, "jumlah_koreksi")
                u = view.GetRowCellValue(e.RowHandle, "jumlahk")
              


                If s < total Then
                    If s > u Then
                        j = s - u
                        If Not ds1.Tables("cekjml") Is Nothing Then ds1.Tables("cekjml").Clear()
                        da1 = New SqlDataAdapter(New SqlCommand("select sum(jumlah_koreksi) jumlahk from PROD.dbo.PROD_rls_spk_man_koreksi_d  " & _
                                                                  "where no_spk_man_rls='" & frmCari.row("NO SPK Rls") & "' and no_spk_man='" & frmCari.row("NO SPK") & "'", sqlconn))
                        da1.Fill(ds1, "cekjml")
                        For i As Integer = 0 To ds1.Tables("cekjml").Rows.Count - 1
                            y = ds1.Tables("cekjml").Rows(i).Item("jumlahk") + j
                        Next

                    Else
                        j = u - s
                        If Not ds1.Tables("cekjml") Is Nothing Then ds1.Tables("cekjml").Clear()
                        da1 = New SqlDataAdapter(New SqlCommand("select sum(jumlah_koreksi) jumlahk from PROD.dbo.PROD_rls_spk_man_koreksi_d  " & _
                                                                  "where no_spk_man_rls='" & frmCari.row("NO SPK Rls") & "' and no_spk_man='" & frmCari.row("NO SPK") & "'", sqlconn))
                        da1.Fill(ds1, "cekjml")
                        For i As Integer = 0 To ds1.Tables("cekjml").Rows.Count - 1
                            y = ds1.Tables("cekjml").Rows(i).Item("jumlahk") - j
                        Next


                    End If
                Else
                    gv.SetColumnError(jumlah_kerja, "Jumlah Dikerjakan tidak boleh lebih besar dari Jumlah Koreksi", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                    showMessages("Data kelebihan:" & s - total)
                End If

            End If

        End If

    End Sub



    Private Sub gv_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gv.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub txtJnsBrg_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If State = "ADD" Then
            If Not txtkgtn.EditValue Is Nothing Then

            End If
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        add_click()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        edit_click()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        cancel_click()
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        delete_click()
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        save_click()
    End Sub

    Public Sub cetak_click()
        Dim TEMPLATE As String
        'callReport(App_Path() & "\report\Prod_SPK_Insentif.rpt", "", "&vnama_report =" & TEMPLATE & " &spk_man=" & txtNoSpk.Text & " &spk_man_rls =" & txtNoSpkRls.Text & " &kd_kegiatan=" & txtkgtn.EditValue, False)
        callReport(App_Path() & "\report\Prod_SPK_koreksi.rpt", "", "&spkman=" & TextEdit1.Text & " &vnama_report=" & TEMPLATE, False)

    End Sub

    Private Sub lkspkreal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkspkreal.EditValueChanged
        If State = "ADD" Then
            If Not ds1.Tables("cek") Is Nothing Then ds1.Tables("cek").Clear()
            If Not ds1.Tables("cek") Is Nothing Then ds1.Tables("cek").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("select *,'0.00' jumlah_koreksi from PROD.dbo.PROD_rls_spk_man_koreksi_d a " & _
                                                  "left join SIF.dbo.Sif_barang b on a.kd_barang=b.kode_barang  " & _
                                                  "left join sif.dbo.sif_tipe t on b.kd_tipe=t.kode_tipe  " & _
                                                  "left join sif.dbo.sif_kain m on b.kd_kain=m.kode_kain " & _
                                                  "left join sif.dbo.SIF_ukuran u on b.kd_ukuran=u.kode_ukuran " & _
                                                  "where no_spk_man_rls='" & lkspkreal.EditValue & "' and no_spk_man='" & lkspk.EditValue & "'", sqlconn))
            da1.Fill(ds1, "cek")
            If ds1.Tables("cek").Rows.Count = 0 Then
                reload()
                isidetil()
                awal = True
            Else
                reload()
                isidetil()
                awal = False

            End If
            
        ElseIf State = "EDIT" Then
            reload()
        End If
    End Sub


    Private Sub gv_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gv.ValidateRow
        If awal = True Then

            If y > total Then
                gv.SetColumnError(jumlah_kerja, "Jumlah Dikerjakan tidak boleh lebih besar dari Jumlah Koreksi", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                showMessages("Data kelebihan:" & y - total)
                isValid = False
            End If
            e.Valid = isValid
        Else
            e.Valid = isValid
        End If
    End Sub

    Private Sub txtkgtn_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkgtn.EditValueChanged

    End Sub
End Class