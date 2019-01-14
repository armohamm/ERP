'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi + JI Sam SU                        =
'======================================================================

Imports System.Data.SqlClient
Imports System.Globalization


Public Class frm_ritel2

    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, kd2, adm, prv, ntran_lama, jns, id_anggota, tgl_uplod_lalu, tgl_uplod_skrg, tgl_uplod_next As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, ds_cari3, ds_brg, dso2, ds_cari, ds_cari1, ds_gdg1, ds_sup, ds_gdg2, dsJab, dsNama As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row, rw, row2 As DataRow
    Private DA, DA1, DA2, DALOOKUP, DALOOKUP1, DA_gdg1, da_sup, DA_gdg2, daNama, daJab As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private s1, s2, stor, bsr_pjm, angs, pokok_pertama, pokok_akhir, t_bunga, denda, total, recov, asr, bunga, m_prv, bg_jln, qt_awl, qt_trn, qt_akr, rp_awl, rp_trn, rp_akr, rp_trans_old As Double
    Private BTRAN As SqlTransaction
    Private awalan, ntran_cek, no_trn, idJab, kd_supp_old As String
    'Dim arr() As Byte
    'Dim Pic As Object
    Dim pathFoto As String
    Dim gbrFoto As Image
    Dim fotoMemoryStream As IO.MemoryStream
    Dim foto() As Byte
    Dim tempo As Integer



    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        'Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        bersihkan()
        'dtpTgl.EditValue = getTanggal()
        'enabel()
        'GvBKE_d.Columns("no_seq").Visible = False
        STATE = "ADD" '<-- set state add
        LUE_nama.Focus()
        tgl_uplod_lalu = "25/" & Month(de_tgl.EditValue) - 1 & "/" & Year(de_tgl.EditValue).ToString
        tgl_uplod_next = "25/" & Month(de_tgl.EditValue) + 1 & "/" & Year(de_tgl.EditValue).ToString
        tgl_uplod_skrg = "25/" & Month(de_tgl.EditValue) & "/" & Year(de_tgl.EditValue).ToString 'MsgBox(tgl_uplod_lalu)
        cb_bg.Checked = True
        tx1_LamaPJM.Text = 1
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data ENTRY ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data?") = MsgBoxResult.Yes Then
            STATE = "DELETE"
            If Not dSO.Tables("_krd") Is Nothing Then
                For Each rw As DataRow In dSO.Tables("_krd").Rows
                    rw.Delete()
                Next
            End If
            'If Not dSO1.Tables("_qc") Is Nothing Then
            '    For Each rw As DataRow In dSO1.Tables("_qc").Rows
            '        rw.Delete()
            '    Next
            'End If

            save_click(True)
            cancel_click()
            STATE = ""
        End If
    End Sub

    Public Sub call_procedure(ByVal no_pengajuan As String, ByVal tipe_trans As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "KOPKAR.dbo.FIN_AUTOMAN_JURNAL"

        sqlCmd.Parameters.Add("@tipe_trans", SqlDbType.VarChar).Value = tipe_trans
        sqlCmd.Parameters.Add("@no_inv", SqlDbType.VarChar).Value = no_pengajuan

        Dim dr As SqlDataReader = sqlCmd.ExecuteReader
        dr.Close()
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
    Private Function blthn(Optional ByVal btrans As Object = Nothing) As String
        Dim hasil As String
        Dim sqlblth As SqlDataReader
        If btrans Is Nothing Then
            'blthn=082011
            'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn).ExecuteReader
            '##blthn=201108
            sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),3,6)as blthn", sqlconn).ExecuteReader 'get th-bl-hr
        Else
            'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn, btrans).ExecuteReader
            sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),3,6) as blthn", sqlconn, btrans).ExecuteReader
        End If
        sqlblth.Read()
        hasil = sqlblth.Item(0)
        'End If
        sqlblth.Close()
        Return hasil
    End Function

    Public Sub LoadStruktur(ByVal kode As String)
        If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
        'If Not dSO1.Tables("_trans") Is Nothing Then dSO1.Tables("_trans").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from retail where no_trans='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_krd")
        'DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from retail where no_trans='" & kode & "'", sqlconn))
        'DA2.Fill(dSO1, "_trans")
        'gc_agenda.DataSource = dSO1.Tables("_trans")
        rp_trans_old = 0
        kd_supp_old = ""
        If dSO.Tables("_krd").Rows.Count > 0 Then

            Dim row As DataRow = dSO.Tables("_krd").Rows(0)
            no_trn = row("no_trans").ToString
            lb_notrans.Text = no_trn
            de_tgl.EditValue = Convert.ToDateTime(row("tgl_trans")).ToString("dd/MM/yyyy")
            LUE_nama.EditValue = row("nasabah_id").ToString
            'LuE_Jab.EditValue = idJab
            txb_norek.Text = row("no_rek").ToString
            'tx_id.Text = row("nasabah_id").ToString
            TE_BsrPJM1.EditValue = row("JML_PINJAMAN")
            tx1_LamaPJM.Text = row("LAMA_ANGS").ToString
            tempo = tx1_LamaPJM.Text
            tx1_ket.Text = row("keterangan").ToString
            t_bunga = row("JML_BUNGA")
            'lb1_bunga.Text = t_bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
            Jenis_Bayar.EditValue = row("jns_bayar").ToString
            id_anggota = row("nasabah_id")
            'tx_id.Text = id_anggota
            Lue_Brg.EditValue = row("kd_brg")
            cari_brg()
            Lue_Jns_brg.EditValue = row("kd_jns_brg")
            barang_changed()
            tx_nama_supp.Text = IIf(IsDBNull(row("nama_supp").ToString), "", row("nama_supp").ToString)
            tx_nama_brg.Text = IIf(IsDBNull(row("nama_barang").ToString), "", row("nama_barang").ToString)
            If Lue_Brg.EditValue = "00000004" Then
                TE_Fee.EditValue = row("rp_trans")
                lb_fee.Text = "Jumlah"
            Else
                TE_Fee.EditValue = row("JML_ADMIN")
                lb_fee.Text = "Fee Koperasi"
            End If

            'lb_nama.Text = row("Nama")

            rp_akr = IIf(IsDBNull(row("rp_awal")), 0, row("rp_awal"))
            rp_trans_old = IIf(IsDBNull(row("rp_trans")), 0, row("rp_trans"))
            kd_supp_old = IIf(IsDBNull(row("kd_brg")), "", row("kd_brg"))
            te_pokok.EditValue = row("JML_POKOK")
            te_bunga.EditValue = row("JML_BUNGA")
        End If
    End Sub
    Public Function getNextNumber() As String
        Dim hasil, temp As String
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(no_trans,8,3)+1 as numeric)) from retail where no_trans like '" & ntran_cek & "%'", sqlconn).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "001"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 2
                temp = "0" & temp
            Next
            hasil = temp & (hasil)
        End If
        sqlDR.Close()
        Return hasil
    End Function


    Public Function get_notran() As String
        'stat_tran = True

        'Lue_SetPjm.Properties.GetDataSourceValue("kd2", Lue_SetPjm.ItemIndex).ToString()
        ntran_cek = "R" & blthn()
        'MsgBox(ntran_cek)
        Dim sqlr As SqlDataReader = New SqlCommand("select * from retail where no_trans like '" & ntran_cek & "%'", sqlconn).ExecuteReader
        If sqlr.HasRows Then
            ntran_cek = "R" & blthn() & getNextNumber()
            'MsgBox(ntran_cek)
        Else
            ntran_cek = "R" & blthn() & "001"
            'MsgBox(ntran_cek)
        End If
        sqlr.Close()
        Return ntran_cek
    End Function

    Public Sub save_click(Optional ByRef isDel As Boolean = False)
        If LUE_nama.EditValue = vbNullString Then
            MsgBox("Data belum di isi/Kosong", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If tx_nama.Text = vbNullString Then
            tx_nama.Focus()
            MsgBox("Nama Nasabah belum diisi", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Lue_Brg.EditValue = "00000008" And tx_nama_supp.Text = vbNullString Then
            MsgBox("Nama Supplier lain belum diisi", MsgBoxStyle.Exclamation)
            tx_nama_supp.Focus()
            Exit Sub
        End If

        If Lue_Jns_brg.EditValue = 0 And tx_nama_brg.Text = vbNullString Then
            MsgBox("Nama Barang lain belum diisi", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        hitung_angsuran()
        If STATE <> "DELETE" Then
            If MsgBox("Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan(isDel)
        Else
            simpan(isDel)
        End If

    End Sub

    Public Sub edit_click()
        'LookupPO.Hide()
        STATE = "EDIT"
        Dim sqlstr As String = "select  r.tgl_trans as [Tanggal Transaksi], r.no_trans as [No Transaksi], r.nasabah_id as [NIP], isnull(r.nama, a.Nama) as Nama,isnull(r.JML_PINJAMAN,0) as Nilai, s.nama as [Nama Supplier], b.nama as [Nama Barang], r.KETERANGAN as [Keterangan], a.job_nama as Dinas from retail r inner join anggota a on a.nasabah_id=r.nasabah_id inner join m_barang s on s.kd_brg=r.kd_brg inner join m_jns_barang b on b.kd_jns=r.kd_jns_brg where r.Last_Created_By='" & username & "' order by  r.tgl_trans desc, r.Last_Create_Date desc  "
        'sqlstr = "select  r.nasabah_id,a.Nama,r.no_trans,isnull(r.JML_POKOK,0) as Nilai, isnull(r.JML_BUNGA,0)as JML_BUNGA,(isnull(r.JML_BUNGA,0)+isnull(r.JML_POKOK,0)) as totalx, isnull(a.Foto,'') as Foto,* from retail r inner join anggota a on a.nasabah_id=r.nasabah_id where r.Last_Created_By='" & username & "' order by r.tgl_trans desc  "
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(sqlstr, sqlconn))
        If Not dSO1.Tables("lookup_") Is Nothing Then dSO1.Tables("lookup_").Clear()
        DA2.Fill(dSO1, "lookup_")
        frmCari.set_dso(dSO1.Tables("lookup_")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        STATE = "EDIT"
        'btCari.Enabled = False
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            Dim rwL As DataRow = dSO1.Tables("lookup_").Rows(0)
            lb_nama.Text = frmCari.row.Item("Nama")
            tx_nama.Text = frmCari.row.Item("Nama")
            id_anggota = frmCari.row("NIP")
            lb_dinas.Text = IIf(frmCari.row.IsNull("Dinas"), "", frmCari.row.Item("Dinas").ToString)
            txb_bank.Text = "BCA"
            LoadStruktur(frmCari.row(1))

            btnSave = True
            btnEdit = False
            btnadd = False
            btnCancel = True
        Else
            cancel_click()
            'add_click()
            'btnSave = False
            'LookupPO.Enabled = False
            STATE = ""
        End If
        setStatus()
    End Sub

    Private Sub bersihkan()
        Lue_member.EditValue = 1
        txb_norek.Text = ""
        Lue_Brg.EditValue = Nothing
        lb_sld_awal.Text = ""
        Lue_Jns_brg.EditValue = Nothing
        Jenis_Bayar.EditValue = "1"
        TE_BsrPJM1.EditValue = 0
        TE_Fee.EditValue = 0
        te_pokok.EditValue = 0
        te_bunga.EditValue = 0
        tx1_LamaPJM.Text = 0
        tx1_ket.Text = ""
        tx_nama.Text = ""
        tx_nama_brg.Text = ""
        tx_nama_supp.Text = ""

        rp_trans_old = 0
        kd_supp_old = ""
        lb_notrans.Text = ""
        lb_dinas.Text = ""
        LUE_nama.EditValue = vbNullString
        lb_nama.Text = ""
        tx_nama_supp.Text = ""
        lb_bg.Text = ""
        'LuE_Jab.EditValue = vbNullString
        'tx_id.Text = ""
        'lb_alamat.Text = ""
        'lb_hp.Text = ""
        'lb_kota.Text = ""
        'lb_stat.Text = ""
        'lb_reg.Text = ""
    End Sub
    Public Sub simpan(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction
        Dim rp_trans As Decimal
        If Not isDelete Then
            If STATE = "ADD" Then
                no_trn = get_notran()
                lb_notrans.Text = no_trn
                row = dSO.Tables("_krd").NewRow
                row.Item("Last_Create_Date") = getTanggal()
                row.Item("Last_Created_By") = username


                row.Item("STATUS_AKTIF") = 1
            ElseIf STATE = "EDIT" Then
                row = dSO.Tables("_krd").Rows(0)
                row.Item("Last_Update") = getTanggal()
                row.Item("Update_By") = username
            ElseIf STATE = "CETAK" Then
                row.Item("cetak_ke") = row.Item("cetak_ke") + 1
            End If
            If Jenis_Bayar.EditValue = "2" Then
                row.Item("status_lunas") = "BELUM" '-- debet gaji
            Else
                row.Item("status_lunas") = "LUNAS"
            End If


            row.Item("tgl_trans") = de_tgl.EditValue

            row.Item("no_trans") = no_trn
            row.Item("JML_PINJAMAN") = bsr_pjm
            row.Item("JML_POKOK") = pokok_pertama
            row.Item("JML_BUNGA") = t_bunga
            row.Item("JML_TERIMA") = bsr_pjm
            row.Item("sisa_pokok") = bsr_pjm
            row.Item("JML_POKOK_TERAKHIR") = pokok_akhir
            row.Item("no_rek") = txb_norek.Text
            row.Item("stat_cair_approve") = 1
            row.Item("stat_approve") = 5
            row.Item("stat_cair") = 1
            row.Item("kabag_approve") = 0
            row.Item("rek_pencairan") = "111.01.06"
            row.Item("nasabah_id") = LUE_nama.EditValue
            row.Item("bunga") = bunga
            row.Item("jns_bayar") = Jenis_Bayar.EditValue
            row.Item("LAMA_ANGS") = tx1_LamaPJM.Text
            row.Item("sisa_angs") = tx1_LamaPJM.Text
            row.Item("KETERANGAN") = tx1_ket.Text
            row.Item("kd_kredit") = Lue_SetPjm.EditValue
            row.Item("jenis") = Lue_SetPjm.EditValue
            row.Item("kd_dep") = kddep
            row.Item("kd_brg") = Lue_Brg.EditValue
            row.Item("kd_jns_brg") = Lue_Jns_brg.EditValue
            row.Item("jenis_trans") = 1 '1:debet , 2:kredit
            row.Item("nama") = tx_nama.Text
            row.Item("stat_anggota") = Lue_member.EditValue
            row.Item("nama_supp") = tx_nama_supp.Text
            row.Item("nama_barang") = tx_nama_brg.Text
            If Lue_Brg.EditValue = "00000004" Then
                rp_trans = TE_Fee.EditValue
                row.Item("JML_ADMIN") = DBNull.Value
            Else
                row.Item("JML_ADMIN") = TE_Fee.EditValue
                rp_trans = TE_BsrPJM1.EditValue - TE_Fee.EditValue
            End If

            row.Item("rp_trans") = rp_trans
            row.Item("rp_akhir") = rp_akr - rp_trans
            'End If
            If STATE = "ADD" Then
                row.Item("rp_awal") = rp_akr
                dSO.Tables("_krd").Rows.Add(row)
                'ElseIf STATE = "ADD" Then
                '    row1 = dSO.Tables("_krd").Rows(0)
            End If

            '    row = dSO.Tables("_krd").NewRow

            '    'row.Item("no_trans") = id_anggota + jns + blthn()
            '    'MsgBox(id_anggota + jns + blthn())
            '    row.Item("Last_Create_Date") = getTanggal()
            '    row.Item("Last_Created_By") = username
            '    row.Item("cetak_ke") = 0
            '    'row.Item("blthn") = blthn()
            '    'row.Item("tgl_trans") = getTanggal()

            'ElseIf STATE = "EDIT" Then
            '    row = dSO.Tables("_krd").Rows(0)
            '    row.Item("Last_Update_Date") = getTanggal()
            '    row.Item("Last_Updated_By") = username
            'ElseIf STATE = "CETAK" Then
            '    row.Item("cetak_ke") = row.Item("cetak_ke") + 1
            'End If

            'row.Item("SALDO_AKHIR") = tx_saldo2.Text
            'row.Item("JENIS_TABUNGAN") = LUE_jnsTab.EditValue
            'row.Item("NO_TABUNGAN") = id_anggota + LUE_jnsTab.EditValue
            'row.Item("TGL_REGISTRASI") = dtp_tgl.Text
            'row.Item("SALDO_AWAL") = tx1_setoran.Text
            'row.Item("SALDO_AKHIR") = tx1_setoran.Text
            ''row.Item("JML_DENDA") = t_admin.Text
            'row.Item("STATUS_AKTIF") = "PENGAJUAN"
            'row.Item("jns_bayar") = cb_byr.Text
            'row.Item("approve1_by") = "OutStanding"
            'row.Item("stat_approve") = 0
            'row.Item("stat_cair") = 0
            'row.Item("KETERANGAN") = tx1_ket.Text

            'dSO.Tables("_krd").Rows.Add(row)
        End If
        Try
            Buildernya = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = Buildernya.GetUpdateCommand()
            DA.InsertCommand = Buildernya.GetInsertCommand()
            DA.DeleteCommand = Buildernya.GetDeleteCommand()

            'Buildernya = New SqlClient.SqlCommandBuilder(DA2)
            'DA2.UpdateCommand = Buildernya.GetUpdateCommand()
            'DA2.InsertCommand = Buildernya.GetInsertCommand()
            'DA2.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            'DA2.UpdateCommand.Transaction = BTRANS
            'DA2.InsertCommand.Transaction = BTRANS
            'DA2.DeleteCommand.Transaction = BTRANS
            'Dim sqlLns As New SqlCommand("update m_barang set rp_akhir=@n_akhir,rp_trans=@n_tran where kd_brg='" & Lue_Brg.EditValue & "'", sqlconn, BTRANS)
            'sqlLns.Parameters.AddWithValue("@n_akhir", row.Item("rp_akhir"))
            'sqlLns.Parameters.AddWithValue("@n_tran", row.Item("rp_trans"))
            'sqlLns.ExecuteNonQuery()


            'Dim sqlcmd1 As New SqlCommand("update anggota set Rec_stat=0,status_anggota='RESIGN', Keterangan='" & tx1_ket.Text & "',tgl_keluar=@nilai where nasabah_id='" & LUE_nama.EditValue & "'", sqlconn, BTRANS)
            'sqlcmd1.Parameters.AddWithValue("@nilai", getTanggal(BTRANS))
            'Clipboard.SetText("update anggota set Rec_stat=0,Keterangan='" & tx1_ket.Text & "',tgl_keluar=@nilai where nasabah_id='" & LUE_nama.EditValue & "'")
            'sqlcmd1.ExecuteNonQuery()
            'If Not STATE = "DELETE" Then
            DA.Update(dSO.Tables("_krd"))
            dSO.Tables("_krd").AcceptChanges()
            ' End If

            'DA2.Update(dSO1.Tables("_trans"))
            'call_procedure(no_trn, "JPJ-KPT-04", BTRANS)
            ''STATE = "EDIT"
            BTRANS.Commit()

            Dim sqlCmd As New SqlCommand
            sqlCmd.Connection = sqlconn
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.CommandText = "dbo.UPDATE_SUPPLIER"

            sqlCmd.Parameters.Add("@notrans", SqlDbType.Char).Value = no_trn
            sqlCmd.Parameters.Add("@state", SqlDbType.Char).Value = STATE
            sqlCmd.Parameters.Add("@rp_trans_old", SqlDbType.Decimal).Value = rp_trans_old
            sqlCmd.Parameters.Add("@kd_brg_old", SqlDbType.Char).Value = kd_supp_old
            sqlCmd.ExecuteNonQuery()

            showMessages("Berhasil disimpan")
            'btnSave = False
            'setStatus()
            STATE = "EDIT"
            rp_trans_old = rp_trans
            kd_supp_old = Lue_Brg.EditValue
            LoadStruktur(no_trn)
            'cari_brg()
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_krd").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try


    End Sub

    Public Sub hitung_ang()
        If Lue_SetPjm.EditValue = vbNullString Or TE_BsrPJM1.EditValue = vbNullString Or tx1_LamaPJM.Text = "" Or LUE_nama.EditValue = vbNullString Then
            ' MsgBox("Lengkapi isian", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim tday, jml_hr, hr_ini, hrdbt, jm_hr_lalu, bln_skrg, jm_hr_bln, jm_bl_lalu, jm_bl_skrg, hr_k_dbt, jm_hr_today As Integer
        Dim dbt_next, debet_lalu As String
        Dim sqdr1 As SqlDataReader = New SqlCommand("SELECT DAY(convert(date,'" & de_tgl.EditValue & "',103)) as tday, month(getdate()) as bln_skrg, " & _
                                                        " convert(date,'" & tgl_uplod_lalu & "',103) as debet_lalu,convert(date,'" & tgl_uplod_next & "',103) as debet_next, " & _
                                                        " datediff(day, DATEADD(month, DATEDIFF(month, 0, convert(date,'" & de_tgl.EditValue & "',103)), 0) , convert(date,'" & de_tgl.EditValue & "',103) ) as jm_hr_today, " & _
                                                        " DATEDIFF(DAY,convert(date,'" & de_tgl.EditValue & "',103),convert(date,'" & tgl_uplod_skrg & "',103))as hr_k_dbt, " & _
                                                        " day(convert(date,'" & de_tgl.EditValue & "',103)) as hr_ini, " & _
                                                        " day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,convert(date,'21/06/2017',103)),0))) as jm_bl_lalu,    " & _
                                                        " day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,convert(date,'21/06/2017',103))+1,0))) as jm_bl_skrg ", sqlconn).ExecuteReader
        '" day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,convert(date,'" & dt_tgl.EditValue & "',103)),0))) as jm_bl_lalu,  " & _
        '" day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,convert(date,'" & dt_tgl.EditValue & "',103))+1,0))) as jm_bl_skrg  ", sqlconn).ExecuteReader
        '##ini jml hr asli '" datediff(day, DATEADD(month, DATEDIFF(month, 0, convert(date,'" & dt_tgl.EditValue & "',103)), 0) , convert(date,'" & dt_tgl.EditValue & "',103) ) as jm_hr_today, " & _
        'blnx =DateDiff(DateInterval.Month,dt_tgl.EditValue,
        sqdr1.Read()
        If sqdr1.HasRows Then
            'tgl_uplod = sqdr1.Item("tgl")
            'blnx = sqdr1.Item("blnx")

            'tgl_uplod = sqdr1.Item("tgl_uplod")
            'bln_dbt = sqdr1.Item("ke_blnDebt")
            tday = sqdr1.Item("tday")
            bln_skrg = sqdr1.Item("bln_skrg")
            debet_lalu = sqdr1.Item("debet_lalu")
            dbt_next = sqdr1.Item("debet_next")
            jm_hr_today = sqdr1.Item("jm_hr_today")
            hr_k_dbt = sqdr1.Item("hr_k_dbt")
            jm_bl_lalu = sqdr1.Item("jm_bl_lalu")
            jm_bl_skrg = sqdr1.Item("jm_bl_skrg")
            hr_ini = sqdr1.Item("hr_ini")
        End If
        sqdr1.Close()
        jml_hr = jm_bl_skrg - (hr_ini - 1)

        If kddep = 3 Then
            If tday <= 25 Then
                'hrdbt = jml_hr - hr_ini
                'bg_jln = ((bsr_pjm * (bunga / 100)) / jm_bl_skrg) * hrdbt 'proporsi
                bg_jln = bsr_pjm * (bunga / 100) 'dikenakan full sebulan

            Else
                bg_jln = 0
            End If
        ElseIf kddep = 2 Then 'omi ga kena bunga
            bg_jln = 0
        End If

        bsr_pjm = TE_BsrPJM1.EditValue + bg_jln
        If tempo > 1 Then
            pokok_pertama = Math.Floor(bsr_pjm / tempo)
            pokok_akhir = bsr_pjm - (pokok_pertama * (tempo - 1))
            t_bunga = bsr_pjm * (bunga / 100)
        Else
            pokok_pertama = TE_BsrPJM1.EditValue
            pokok_akhir = TE_BsrPJM1.EditValue
            t_bunga = 0
        End If
        'lb_pokok.Text = pokok_pertama.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb1_bunga.Text = t_bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb_bg.Text = bg_jln.ToString("c", New Globalization.CultureInfo("id-ID", False))
    End Sub


    Public Sub hitung_angsuran()
        'If LUE_nama.EditValue = vbNullString Then
        '    MsgBox("Nama Nasabah belum dipilih")
        '    Exit Sub
        'End If
        If Lue_SetPjm.EditValue = vbNullString Or TE_BsrPJM1.EditValue = vbNullString Or tx1_LamaPJM.Text = "" Or LUE_nama.EditValue = vbNullString Then
            ' MsgBox("Lengkapi isian", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        Dim tday, jml_hr, hr_ini, hrdbt, jm_hr_lalu, bln_skrg, jm_hr_bln, jm_bl_lalu, jm_bl_skrg, hr_k_dbt, jm_hr_today As Integer
        Dim dbt_next, debet_lalu As String
        Dim sqdr1 As SqlDataReader = New SqlCommand("SELECT DAY(convert(date,'" & de_tgl.EditValue & "',103)) as tday, month(getdate()) as bln_skrg, " & _
                                                        " convert(date,'" & tgl_uplod_lalu & "',103) as debet_lalu,convert(date,'" & tgl_uplod_next & "',103) as debet_next, " & _
                                                        " datediff(day, DATEADD(month, DATEDIFF(month, 0, convert(date,'" & de_tgl.EditValue & "',103)), 0) , convert(date,'" & de_tgl.EditValue & "',103) ) as jm_hr_today, " & _
                                                        " DATEDIFF(DAY,convert(date,'" & de_tgl.EditValue & "',103),convert(date,'" & tgl_uplod_skrg & "',103))as hr_k_dbt, " & _
                                                        " day(convert(date,'" & de_tgl.EditValue & "',103)) as hr_ini, " & _
                                                        " day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,convert(date,'21/06/2017',103)),0))) as jm_bl_lalu,    " & _
                                                        " day(DATEADD(s,-1,DATEADD(mm, DATEDIFF(m,0,convert(date,'21/06/2017',103))+1,0))) as jm_bl_skrg ", sqlconn).ExecuteReader
        sqdr1.Read()
        If sqdr1.HasRows Then
            tday = sqdr1.Item("tday")
            bln_skrg = sqdr1.Item("bln_skrg")
            debet_lalu = sqdr1.Item("debet_lalu")
            dbt_next = sqdr1.Item("debet_next")
            jm_hr_today = sqdr1.Item("jm_hr_today")
            hr_k_dbt = sqdr1.Item("hr_k_dbt")
            jm_bl_lalu = sqdr1.Item("jm_bl_lalu")
            jm_bl_skrg = sqdr1.Item("jm_bl_skrg")
            hr_ini = sqdr1.Item("hr_ini")
        End If
        sqdr1.Close()
        jml_hr = jm_bl_skrg - (hr_ini - 1)
        bsr_pjm = TE_BsrPJM1.EditValue
        t_bunga = 0
        If kddep = 3 Then
            If cb_bg.Checked = True Then
                If Lue_Brg.EditValue <> "00000004" Then
                    If tday >= 21 Then
                        'hrdbt = jml_hr - hr_ini
                        'bg_jln = ((bsr_pjm * (bunga / 100)) / jm_bl_skrg) * hrdbt 'proporsi
                        t_bunga = bsr_pjm * (bunga / 100) 'dikenakan full sebulan
                    Else
                        If tempo > 1 Then
                            t_bunga = bsr_pjm * (bunga / 100)
                        Else
                            t_bunga = 0
                        End If
                    End If
                End If
            End If
        ElseIf kddep = 2 Then 'omi ga kena bunga
            t_bunga = 0
        End If


        If tempo > 1 Then
            pokok_pertama = Math.Floor(bsr_pjm / tempo)
            pokok_akhir = bsr_pjm - (pokok_pertama * (tempo - 1))
        Else
            pokok_pertama = TE_BsrPJM1.EditValue
            pokok_akhir = TE_BsrPJM1.EditValue
        End If
        'lb_pokok.Text = pokok_pertama.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb1_bunga.Text = t_bunga.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb_bg.Text = bg_jln.ToString("c", New Globalization.CultureInfo("id-ID", False))
        te_pokok.EditValue = pokok_pertama
        te_bunga.EditValue = t_bunga
    End Sub

    Public Sub cancel_click()
        'LoadStruktur("XXX")
        bersihkan()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
        'bersihkan()
    End Sub


    Public Sub cari_brg()
        tx_nama_supp.Visible = False
        lb_nama_supp.Visible = False
        If Lue_Brg.EditValue = "00000004" Then ' jika MATERAI
            Lue_Jns_brg.EditValue = 1
            lb_fee.Text = "Jumlah"
        ElseIf Lue_Brg.EditValue = "00000008" Then ' jika Lain2
            Lue_Jns_brg.EditValue = 2
            lb_fee.Text = "Jumlah"
            tx_nama_supp.Visible = True
            lb_nama_supp.Visible = True
            If STATE = "ADD" Then
                tx_nama_supp.Text = ""
            End If
        Else
            Lue_Jns_brg.EditValue = 2
            lb_fee.Text = "Fee Koperasi"
        End If

        If Not ds_brg.Tables("_brg1") Is Nothing Then ds_brg.Tables("_brg1").Clear()
        DALOOKUP1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from m_barang where kd_brg='" & Lue_Brg.EditValue & "'", sqlconn)) '<- query buat domitampilkan di LOV, pakailah alias colom biar enak dibaca
        If Lue_Brg.EditValue = Nothing Then
            Exit Sub
        End If
        DALOOKUP1.Fill(ds_brg, "_brg1")
        Dim row_brg = ds_brg.Tables("_brg1").Rows(0)
        If Not row_brg Is Nothing Then
            qt_awl = IIf(row_brg.IsNull("qty_awal"), 0, row_brg.Item("qty_awal")) 'row_brg("qty_awal")
            qt_akr = IIf(row_brg.IsNull("qty_akhir"), 0, row_brg.Item("qty_akhir")) 'row_brg("qty_akhir")
            rp_awl = IIf(row_brg.IsNull("rp_awal"), 0, row_brg.Item("rp_awal"))  'row_brg("rp_awal")
            rp_akr = IIf(row_brg.IsNull("rp_akhir"), 0, row_brg.Item("rp_akhir"))  'row_brg("rp_akhir")
            If Lue_Brg.EditValue = "00000004" Then
                lb_sld_awal.Text = rp_akr.ToString("n0")
            Else
                lb_sld_awal.Text = rp_akr.ToString("c", New Globalization.CultureInfo("id-ID", False))
            End If
        End If
    End Sub
    Public Sub Cari()
        tx_nama.Text = ""
        lb_dinas.Text = ""
        If LUE_nama.EditValue = "000000" Then
            Lue_member.EditValue = 0
        Else
            Lue_member.EditValue = 1
        End If
        Dim arr() As Byte
        Dim Pic As Object

        If Not ds_gdg1.Tables("lookup_Pegawai") Is Nothing Then ds_gdg1.Tables("lookup_Pegawai").Clear()
        DA_gdg1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select isnull(Foto,'') as Foto,* from anggota where nasabah_id='" & LUE_nama.EditValue & "'", sqlconn)) '<- query buat domitampilkan di LOV, pakailah alias colom biar enak dibaca
        If LUE_nama.EditValue = Nothing Then
            Exit Sub
        End If

        DA_gdg1.Fill(ds_gdg1, "lookup_Pegawai")
        Dim row = ds_gdg1.Tables("lookup_Pegawai").Rows(0)
        If Not row Is Nothing Then
            lb_nama.Text = row("Nama")
            tx_nama.Text = row("Nama")
            If LUE_nama.EditValue = "000000" Then
                tx_nama.Text = ""
            End If
            id_anggota = row("nasabah_id")
            'tx_id.Text = row("nasabah_id")
            'id_anggota = row("nasabah_id")
            'lb_alamat.Text = IIf(row.IsNull("Almt_asal"), "", row.Item("Almt_asal").ToString)  'row("Almt_asal")
            'lb_reg.Text = IIf(row.IsNull("tgl_masuk"), "", row.Item("tgl_masuk").ToString) 'row("tgl_masuk")
            lb_dinas.Text = IIf(row.IsNull("job_nama"), "", row.Item("job_nama").ToString)  'row("job_nama")
            'lb_hp.Text = IIf(row.IsNull("telp_asal"), "", row.Item("telp_asal").ToString)   'row("telp_asal")
            txb_norek.Text = row("REKBCA1")
            txb_bank.Text = "BCA"
            'lb_stat.Text = IIf(row.IsNull("status_anggota"), "", row.Item("status_anggota").ToString)  'row("status_anggota")
            'LuE_Jab.EditValue = IIf(row.IsNull("job_id"), 0, row.Item("job_id")) 'row("job_id")
            arr = row.Item("Foto") 'IIf(row.IsNull(row.Item("Foto"), 0, row.Item("Foto")))
            'If arr.Length = 0 Then
            '    PictureBox2.Image = Presentation.My.Resources.profile_photo
            'Else
            '    ' arr = row.Item("Foto")
            '    PictureBox2.Image = Image.FromStream(New IO.MemoryStream(arr))
            '    'PictureBox2.Image = Image.FromStream(ms)
            'End If


            'cek_agenda()
            cek_hist()
            tx1_LamaPJM.Text = 1
        End If
    End Sub

    'Public Sub cek_agenda()
    '    If Not ds_cari.Tables("_agd") Is Nothing Then ds_cari.Tables("_agd").Clear()
    '    'If Not dso2.Tables("_agd") Is Nothing Then
    '    '    dso2.Tables("_agd").Clear()
    '    'End If
    '    DA1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from kredit where nasabah_id= '" & id_anggota & "' and stat_approve < 5", sqlconn))
    '    DA1.Fill(ds_cari, "_agd")
    '    gc_agenda.DataSource = ds_cari.Tables("_agd")
    '    gv_agenda.BestFitColumns()


    'End Sub
    Public Sub cek_hist()
        If Not ds_cari1.Tables("_hist") Is Nothing Then ds_cari1.Tables("_hist").Clear()
        'If Not dSO1.Tables("_hist") Is Nothing Then
        '    dSO1.Tables("_hist").Clear()
        'End If
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select isnull(JML_POKOK_TERAKHIR,0) as JML_POKOK_TERAKHIR,* from kredit where nasabah_id= '" & id_anggota & "' and status_lunas<>'LUNAS' and stat_approve > 4", sqlconn))
        DA2.Fill(ds_cari1, "_hist")
        GcHist.DataSource = ds_cari1.Tables("_hist")
        'Gv_hist.BestFitColumns()


    End Sub

    Private Sub frm_anggota_kluar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        de_tgl.EditValue = Today
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        daNama = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama,nasabah_id from anggota ", sqlconn))
        daNama.Fill(dsNama, "_nm")
        LUE_nama.Properties.DataSource = dsNama.Tables("_nm")
        LUE_nama.Properties.ValueMember = "nasabah_id"
        LUE_nama.Properties.DisplayMember = "nasabah_id"

        'DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT * FROM m_jns_upload where tipe_trans='RTL' OR tipe_trans='BNS'", sqlconn))
        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT * FROM m_jns_upload where tipe_trans='RTL'", sqlconn))
        DALOOKUP.Fill(ds_cari, "LookTran")
        Lue_SetPjm.Properties.DataSource = ds_cari.Tables("LookTran")
        Lue_SetPjm.Properties.DisplayMember = "Nama"
        Lue_SetPjm.Properties.ValueMember = "kode"

        'daJab = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select job_id,job_nama from m_jabatan", sqlconn))
        'daJab.Fill(dsJab, "View_Jabatan")
        'LuE_Jab.Properties.DataSource = dsJab.Tables("View_Jabatan")
        'LuE_Jab.Properties.ValueMember = "job_id"
        'LuE_Jab.Properties.DisplayMember = "job_nama"

        DA_gdg1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_jns,nama from m_jns_barang order by nama", sqlconn))
        DA_gdg1.Fill(ds_gdg1, "_jnsbrg")
        Lue_Jns_brg.Properties.DataSource = ds_gdg1.Tables("_jnsbrg")
        Lue_Jns_brg.Properties.ValueMember = "kd_jns"
        Lue_Jns_brg.Properties.DisplayMember = "nama"
        Lue_Jns_brg.EditValue = Nothing

        DA_gdg2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_member,nama from m_jns_member", sqlconn))
        DA_gdg2.Fill(ds_gdg2, "_mbr")
        Lue_member.Properties.DataSource = ds_gdg2.Tables("_mbr")
        Lue_member.Properties.ValueMember = "kd_member"
        Lue_member.Properties.DisplayMember = "nama"
        Lue_member.EditValue = 1

        
        DALOOKUP1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_brg,nama from m_barang", sqlconn))
        DALOOKUP1.Fill(ds_cari3, "_brg")
        Lue_Brg.Properties.DataSource = ds_cari3.Tables("_brg")
        Lue_Brg.Properties.ValueMember = "kd_brg"
        Lue_Brg.Properties.DisplayMember = "nama"
        Lue_Brg.EditValue = Nothing


        DALOOKUP1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select '1' as id_jenis_bayar, 'Tunai' as nama_jenis_bayar union select '2' as id_jenis_bayar, 'Debet Gaji' as nama_jenis_bayar union select '3' as id_jenis_bayar, 'Transfer' as nama_jenis_bayar", sqlconn))
        DALOOKUP1.Fill(ds_cari3, "_jenis_bayar")
        Jenis_Bayar.Properties.DataSource = ds_cari3.Tables("_jenis_bayar")
        Jenis_Bayar.Properties.ValueMember = "id_jenis_bayar"
        Jenis_Bayar.Properties.DisplayMember = "nama_jenis_bayar"
        Jenis_Bayar.EditValue = "1"

        'Lue_SetPjm.EditValue = "NOR "
        LoadStruktur("xxx")
        If kddep = 2 Then
            Lue_SetPjm.EditValue = "U005"
        ElseIf kddep = 3 Then
            Lue_SetPjm.EditValue = "U017"
            bunga = 1.2
        End If

    End Sub

    Private Sub LUE_nama_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LUE_nama.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cari()
            txb_norek.Focus()

        End If
    End Sub

    Private Sub TE_BsrPJM_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TE_BsrPJM1.EditValueChanged
        'If STATE
        'bsr_pjm = TE_BsrPJM1.EditValue
        If TE_BsrPJM1.EditValue <> vbNullString And tx1_LamaPJM.Text <> "" And LUE_nama.EditValue <> vbNullString And Lue_SetPjm.EditValue <> vbNullString Then
            'hitung_ang()
        End If
    End Sub


    Private Sub TE_BsrPJM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_BsrPJM1.KeyDown
        If e.KeyCode = Keys.Enter Then
            tempo = tx1_LamaPJM.Text
            hitung_angsuran()
            TE_Fee.Focus()
        End If
    End Sub

    Private Sub tx1_ket_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tx1_ket.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    save_click()
        'End If
    End Sub

    Private Sub Lue_SetPjm_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lue_SetPjm.EditValueChanged
        'If STATE = "ADD" Then
        Dim i As Integer

        'If Not ds_cari.Tables("LookTran") Is Nothing Then ds_cari.Tables("LookTran").Clear()
        Dim dr() As DataRow = ds_cari.Tables("LookTran").Select("kode='" & Lue_SetPjm.EditValue & "'")
        'MsgBox(dr(i))

        'lb_plafon.Text = dr(i).Item("nilai")

        bunga = dr(i).Item("Bunga_KSP")
        lb_bunga.Text = bunga
        lb_admin.Text = dr(i).Item("Adm")
        adm = dr(i).Item("Adm")
        'tx_asr.Text = dr(i).Item("Asuransi")
        lb_prvs.Text = dr(i).Item("provisi")
        m_prv = dr(i).Item("provisi")
        lb_denda.Text = dr(i).Item("Denda")
        lb_admin.Text = dr(i).Item("Adm")
        prv = dr(i).Item("provisi")
        lb_prvs.Text = prv

        jns = dr(i).Item("kode")
        kd2 = Lue_SetPjm.EditValue

        'End If
    End Sub

    Private Sub cb_bg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_bg.CheckedChanged
        If cb_bg.Checked = False Then
            t_bunga = 0
            te_bunga.EditValue = t_bunga
        Else
            hitung_angsuran()
        End If
    End Sub


    Private Sub TE_Fee_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_Fee.KeyDown
        If e.KeyCode = Keys.Enter Then
            hitung_angsuran()
            tx1_LamaPJM.Focus()
        End If
    End Sub

    Private Sub Lue_member_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lue_member.EditValueChanged
        If Lue_member.EditValue = 0 Then
            LUE_nama.EditValue = "000000"
            txb_norek.Text = "000000"
            lb_dinas.Text = ""
            tx_nama.Text = ""
            '            TE_BsrPJM1.Focus()
        End If
    End Sub

    Private Sub LUE_nama_Closed(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles LUE_nama.Closed
        Cari()
        cari_brg()
    End Sub



    Private Sub Lue_Brg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Lue_Brg.KeyDown
        If e.KeyCode = Keys.Enter Then
            cari_brg()
            Lue_Jns_brg.Focus()
        End If
    End Sub

    Private Sub txb_norek_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txb_norek.KeyDown
        If e.KeyCode = Keys.Enter Then
            Lue_Brg.Focus()
        End If
    End Sub

    Private Sub Lue_Jns_brg_Closed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles Lue_Jns_brg.Closed
        barang_changed()
    End Sub

    Private Sub barang_changed()
        lb_nama_brg.Visible = False
        tx_nama_brg.Visible = False


        If Lue_Jns_brg.EditValue = 0 Then
            lb_nama_brg.Visible = True
            tx_nama_brg.Visible = True
            If STATE = "ADD" Then
                tx_nama_brg.Text = ""
            End If
        End If

        If Lue_Jns_brg.EditValue = 1 Then
            Lue_Brg.EditValue = "00000004"
            lb_fee.Text = "Jumlah"
            cari_brg()
        Else
            If Lue_Brg.EditValue = "00000004" Then
                Lue_Brg.EditValue = "00000001"
                lb_fee.Text = "Fee Koperasi"
                cari_brg()
            End If
        End If
    End Sub


    Private Sub Lue_Jns_brg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Lue_Jns_brg.KeyDown
        If e.KeyCode = Keys.Enter Then
            TE_BsrPJM1.Focus()
        End If
    End Sub

    Private Sub tx1_LamaPJM_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tx1_LamaPJM.KeyDown
        If e.KeyCode = Keys.Enter Then
            tempo = tx1_LamaPJM.Text
            hitung_angsuran()
            tx1_ket.Focus()
        End If
    End Sub

    Private Sub LueSupp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Lue_Brg.Focus()
        End If
    End Sub

    Private Sub Lue_Brg_Closed(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles Lue_Brg.Closed
        'tx_nama_supp.Visible = False
        'lb_nama_supp.Visible = False
        'If Lue_Brg.EditValue = "00000004" Then ' jika MATERAI
        '    Lue_Jns_brg.EditValue = 1
        '    lb_fee.Text = "Jumlah"
        'ElseIf Lue_Brg.EditValue = "00000008" Then ' jika Lain2
        '    Lue_Jns_brg.EditValue = 2
        '    lb_fee.Text = "Jumlah"
        '    tx_nama_supp.Visible = True
        '    lb_nama_supp.Visible = True
        '    If STATE = "ADD" Then
        '        tx_nama_supp.Text = ""
        '    End If
        'Else
        '    Lue_Jns_brg.EditValue = 2
        '    lb_fee.Text = "Fee Koperasi"
        'End If
        cari_brg()
    End Sub

    Private Sub btnTopUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTopUp.Click

        supp_topup.ShowDialog()
    End Sub
End Class
