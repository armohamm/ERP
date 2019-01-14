'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2015                       =
'= Sebelum Coding Jangan Lupa kopi + JI Sam SU                        =
'======================================================================

Imports System.Data.SqlClient
Imports System.Globalization
'Imports DevExpress.XtraPrintingLinksaa
'Imports DevExpress.XtraPrinting

Public Class frmDeps_Cair
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, id_anggota, jns As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, ds_cari3, dso2, ds_cari, ds_cari1, ds_gdg1, dsNama As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row1, rw, row2 As DataRow
    Private DA, DA2, DALOOKUP, DALOOKUP1, DA_gdg1, daNama As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private s1, s2, stor, TRX, angs, denda, bg, t_bunga, total, recov, asr As Double
    Private BTRAN As SqlTransaction
    Private ntran_cek, awalan, tgl_reg, tg_cair, no_trn As String
    Private bg_Bjln As Double

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        'Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        'bersihkan()
        'dtpTgl.EditValue = getTanggal()
        'enabel()
        'GvBKE_d.Columns("no_seq").Visible = False
        STATE = "ADD" '<-- set state add
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
            sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),3,4)as blthn", sqlconn).ExecuteReader
        Else
            'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn, btrans).ExecuteReader
            sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),3,4)as blthn", sqlconn, btrans).ExecuteReader
        End If
        sqlblth.Read()
        hasil = sqlblth.Item(0)
        'End If
        sqlblth.Close()
        Return hasil
    End Function

    Public Sub LoadStruktur(ByVal kode As String)
        If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
        If Not dSO1.Tables("_trans") Is Nothing Then dSO1.Tables("_trans").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,0 as nomer from tabung where NO_TABUNGAN='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_krd")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from tabtrans where 1=0", sqlconn))
        DA2.Fill(dSO1, "_trans")
        'Gc_nabung.DataSource = dSO1.Tables("_trans")
        cek_agenda()
        isinomer()
    End Sub

    Public Sub cek_agenda()
        If Not dSO.Tables("_krd") Is Nothing Then
            dSO.Tables("_krd").Clear()
        End If
        DALOOKUP = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,0 as nomer from tabung where  DAY(TGL_REGISTRASI) = DAY(GETDATE()) and jenis_tabungan='005' and rec_stat=1 and STATUS_AKTIF='AKTIF'", sqlconn))
        DALOOKUP.Fill(dSO, "_krd")
        Gc_nabung.DataSource = dSO.Tables("_krd")
        'gv_agenda.BestFitColumns()


    End Sub
    Public Sub save_click()
        If TE_Tarik.EditValue = vbNullString Then
            MsgBox("Nilai Setoran belim di isi/Kosong", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If MsgBox("Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Public Sub simpan()
        hitung()
        Dim BTRANS As SqlTransaction
        'If STATE = "ADD" Then
        '    rw = dSO.Tables("_krd").Rows(0)
        '    rw.Item("Last_Update") = getTanggal()
        '    rw.Item("Last_Update_By") = username
        '    rw.Item("tipe_trans") = "JKK-KBB-13"
        '    'stat_cair='T'
        'End If
        'row = dSO.Tables("_krd").NewRow

        ''row.Item("no_trans") = id_anggota + jns + blthn()
        ''MsgBox(id_anggota + jns + blthn())
        'row.Item("Last_Create_Date") = getTanggal()
        'row.Item("Last_Created_By") = username
        'row.Item("cetak_ke") = 0
        ''row.Item("blthn") = blthn()
        ''row.Item("tgl_trans") = getTanggal()

        'ElseIf STATE = "EDIT" Then
        'row = dSO.Tables("_krd").Rows(0)
        'row.Item("Last_Update_Date") = getTanggal()
        'row.Item("Last_Updated_By") = username
        'ElseIf STATE = "CETAK" Then
        'row.Item("cetak_ke") = row.Item("cetak_ke") + 1
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

        Try
            Buildernya = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = Buildernya.GetUpdateCommand()
            DA.InsertCommand = Buildernya.GetInsertCommand()
            DA.DeleteCommand = Buildernya.GetDeleteCommand()

            Buildernya = New SqlClient.SqlCommandBuilder(DA2)
            DA2.UpdateCommand = Buildernya.GetUpdateCommand()
            DA2.InsertCommand = Buildernya.GetInsertCommand()
            DA2.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            DA2.UpdateCommand.Transaction = BTRANS
            DA2.InsertCommand.Transaction = BTRANS
            DA2.DeleteCommand.Transaction = BTRANS

            'Dim sqlcmd1 As New SqlCommand("update tabung set SALDO_AKHIR=@nilai where NO_TABUNGAN='" & tx_noTbg.Text & "'", sqlconn, BTRANS)
            'sqlcmd1.Parameters.AddWithValue("@nilai", row1.Item("SALDO_AKHIR"))
            'sqlcmd1.ExecuteNonQuery()

            Dim sqlcmd2 As New SqlCommand("update tabung set STATUS_AKTIF='CAIR PENDING',TGL_AKHIR=getdate(),tgl_cair=getdate(),cair_by='" & namauser & "' where NO_TABUNGAN='" & lb_NoTBG.Text & "'", sqlconn, BTRANS)
            sqlcmd2.ExecuteNonQuery()

            DA.Update(dSO.Tables("_krd"))
            DA2.Update(dSO1.Tables("_trans"))

            'stprc_DpsCair(no_trn, de_tglCair.EditValue, BTRANS) 'ke verivikasi dulu
            'STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan")
            btnSave = False
            setStatus()
            LoadStruktur("xxx")
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_krd").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try


    End Sub

    Public Sub stprc_DpsCair(ByVal notransvc As String, ByVal tglx As Date, ByVal BTRAN As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRAN
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "KOPKAR.dbo.FIN_CREATE_JUR_CAIR_DEPOSITO"
        sqlCmd.Parameters.Add("@no_inv", SqlDbType.VarChar, 32).Value = notransvc
        sqlCmd.Parameters.Add("@tanggal", SqlDbType.Date, 32).Value = tglx
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub cancel_click()
        LoadStruktur("XXX")

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
        'bersihkan()
    End Sub
    Public Sub bersihkan()
        dSO1.Clear()

    End Sub


    Public Sub Cari()
        'bersihkan()
        If Not ds_gdg1.Tables("lookup_Pegawai") Is Nothing Then ds_gdg1.Tables("lookup_Pegawai").Clear()
        DA_gdg1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select tb.NO_TABUNGAN,isnull(a.nasabah_id,'') as nasabah_id,ISNULL(a.Nama,'') as [Nama],tb.TGL_REGISTRASI,tb.TGL_AKHIR,tb.SALDO_AWAL,tb.SALDO_AKHIR,a.jns_kel as [Jenis_kelamin],isnull(a.Almt_asal,'')as Almt_asal ,a.telp_skrg,a.REKBCA1,* from tabung tb left join anggota a on tb.NASABAH_ID=a.nasabah_id where tb.JENIS_TABUNGAN='005' and tb.NO_TABUNGAN='" & LUE_nama.EditValue & "' AND tb.STATUS_AKTIF='AKTIF'", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If LUE_nama.EditValue = Nothing Then
            Exit Sub
        End If

        DA_gdg1.Fill(ds_gdg1, "lookup_Pegawai")
        Dim row = ds_gdg1.Tables("lookup_Pegawai").Rows(0)
        'frmCari.set_dso(ds_gdg1.Tables("lookup_Pegawai")) '<-- memparsing hasil dataset ke LOV
        'frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not row Is Nothing Then
            'Txb_Nama.Text = frmCari.row("Nama")
            lb_nama.Text = row("Nama")
            lb_NIP.Text = row("nasabah_id")
            id_anggota = row("nasabah_id")
            s1 = row("SALDO_AWAL")
            lb_NoTBG.Text = row("NO_TABUNGAN")
            no_trn = row("NO_TABUNGAN")
            tglDari.EditValue = row("TGL_REGISTRASI")
            tgl_reg = row("TGL_REGISTRASI")
            bg = row("bunga")
            lb_saldo.Text = row("SALDO_AKHIR")
            s2 = row("SALDO_AKHIR")
            TE_Tarik.EditValue = row("SALDO_AKHIR")
            TRX = row("SALDO_AKHIR") 'rw.Item("tipe_trans") = "JKK-KBB-13"
            lb_bg.Text = bg

            'Dim sql_bg_jln As SqlDataReader = New SqlCommand("select KOPKAR.dbo.getbunga('" & lb_NoTBG.Text & "," & de_tglCair.EditValue & ")", sqlconn).ExecuteReader
            'jika cair Hari ini, maka getdate, jika cair besok lusa maka hitung()
            Dim sql_bg_jln As SqlDataReader = New SqlCommand("select KOPKAR.dbo.getbunga('" & lb_NoTBG.Text & "',GETDATE())", sqlconn).ExecuteReader
            If sql_bg_jln.Read Then
                bg_Bjln = sql_bg_jln.Item(0)
            Else
                MsgBox("Koneksi ada masalah!!")
            End If

            sql_bg_jln.Close()

            If tgl_reg.Substring(0, 2) = Today.Day Then
                bg_Bjln = 0
            End If
            lb1_bg_jln.Text = bg_Bjln.ToString("c2", New Globalization.CultureInfo("id-ID", False))
            lb_saldo.Text = s2.ToString("c2", New Globalization.CultureInfo("id-ID", False))
            'TE_Tarik.EditValue ' = TRX.ToString("c2", New Globalization.CultureInfo("id-ID", False))
            cb_bg_jln.Checked = False

            lb1_bg_jln.Enabled = False
        End If
    End Sub

    Public Sub hitung()
        'If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
        If Not dSO1.Tables("_trans") Is Nothing Then dSO1.Tables("_trans").Clear()

        Dim sql_bg_jln As SqlDataReader = New SqlCommand("select KOPKAR.dbo.getbunga('" & lb_NoTBG.Text & "',convert(date,'" & de_tglCair.EditValue & "',103))", sqlconn).ExecuteReader
        Clipboard.SetText("select KOPKAR.dbo.getbunga('" & lb_NoTBG.Text & "'," & de_tglCair.EditValue & ")")
        'Dim sql_bg_jln As SqlDataReader = New SqlCommand("select KOPKAR.dbo.getbunga('" & lb_NoTBG.Text & "',GETDATE())", sqlconn).ExecuteReader
        If sql_bg_jln.Read Then
            bg_Bjln = sql_bg_jln.Item(0)
        Else
            MsgBox("Koneksi ada masalah!!")
        End If

        sql_bg_jln.Close()
        'MsgBox(tgl_reg.Substring(0, 2))
        If tg_cair.Substring(0, 2) = tgl_reg.Substring(0, 2) Then
            bg_Bjln = 0
        End If
        lb1_bg_jln.Text = bg_Bjln.ToString("c2", New Globalization.CultureInfo("id-ID", False))


        Dim x As Integer = 0
        If LUE_nama.EditValue <> vbNullString Then
            stor = TE_Tarik.EditValue
            '## SETOR TUNAI
            row1 = dSO1.Tables("_trans").NewRow
            row1.Item("id_cabang") = getKodeCabang()
            row1.Item("URUTAN") = 1
            row1.Item("TGL_TRANS") = de_tglCair.EditValue
            row1.Item("NO_TRANS") = notran()
            row1.Item("NO_TABUNGAN") = lb_NoTBG.Text
            row1.Item("NASABAH_ID") = id_anggota
            row1.Item("KODE_TRANS") = "02" 'tarik TUNAI
            row1.Item("SALDO_AWAL") = s1
            row1.Item("kabag_approve") = 0
            row1.Item("stat_cair") = "T"
            row1.Item("Last_Update_Date") = getTanggal()
            row1.Item("Last_Updated_By") = username
            row1.Item("tipe_trans") = "JKK-KBB-13"
            row1.Item("bunga") = bg
            If cb_bg_jln.Checked = True Then
                row1.Item("rp_bunga_jln") = bg_Bjln
            Else
                row1.Item("rp_bunga_jln") = 0
            End If
            row1.Item("SALDO_TRANS") = TRX + bg_Bjln
            'row1.Item("SALDO_AKHIR") = 0
            dSO1.Tables("_trans").Rows.Add(row1)
            '## ADMIN

            'row2 = dSO1.Tables("_trans").NewRow()
            'row2.Item("URUTAN") = 2
            'row2.Item("TGL_TRANS") = getTanggal()
            'row2.Item("NO_TABUNGAN") = tx_noTbg.Text
            'row2.Item("NASABAH_ID") = id_anggota
            'row2.Item("KODE_TRANS") = "05" 'SETOR TUNAI
            'row2.Item("SALDO_AWAL") = s1 + stor 'SALDO AKHIR SETOR JD SALDO AWAL 05 ADMIN
            'row2.Item("SALDO_TRANS") = 5000
            'row2.Item("SALDO_AKHIR") = (s1 + stor) - 5000
            'dSO1.Tables("_trans").Rows.Add(row2)
            'save_click()
        End If
        lb1_bg_jln.Text = bg_Bjln.ToString("c2", New Globalization.CultureInfo("id-ID", False))
    End Sub

    Public Function notran() As String

        ''Lue_SetPjm.Properties.GetDataSourceValue("kd2", Lue_SetPjm.ItemIndex).ToString()
        Dim sql_no As SqlDataReader = New SqlCommand("select prefix_trn_tarikan from m_tabungan where kd_trans='DP1'", sqlconn).ExecuteReader
        If sql_no.Read Then
            awalan = sql_no.Item("prefix_trn_tarikan")
        Else
            MsgBox("Koneksi Terputus, mohon dicek")
        End If
        sql_no.Close()
        ntran_cek = awalan & blthn()
        'MsgBox(ntran_cek)
        Dim sqlr As SqlDataReader = New SqlCommand("select * from tabtrans where no_trans like '" & ntran_cek & "%'", sqlconn).ExecuteReader
        If sqlr.HasRows Then
            ntran_cek = awalan & blthn() & getNextNumber()
            'MsgBox(ntran_cek)
        Else
            ntran_cek = awalan & blthn() & "0001"
            'MsgBox(ntran_cek)
        End If
        sqlr.Close()
        Return ntran_cek
    End Function

    Public Function getNextNumber() As String
        Dim hasil, temp As String
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(no_trans,8,4)+1 as numeric)) from tabtrans where no_trans like '" & ntran_cek & "%'", sqlconn).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "001"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 3
                temp = "0" & temp
            Next
            hasil = temp & (hasil)
        End If
        sqlDR.Close()
        Return hasil
    End Function

    Private Sub isinomer()
        Dim i As Int16 = 1
        For Each row As DataRow In dSO.Tables("_krd").Rows
            row.Item("nomer") = i : i += 1
        Next
    End Sub


    Private Sub frmDeps_Cair_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        LoadStruktur("xxx")
        TE_Tarik.Enabled = False
        de_tglCair.EditValue = Today

      

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select nasabah_id,Nama from anggota", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_lookup")
        RL_nama.DataSource = ds_cari1.Tables("_lookup")
        RL_nama.ValueMember = "nasabah_id"
        RL_nama.DisplayMember = "Nama"

        daNama = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select t.NO_TABUNGAN,a.Nama from anggota a INNER JOIN tabung t on a.nasabah_id=t.NASABAH_ID where t.JENIS_TABUNGAN='005' AND t.STATUS_AKTIF='AKTIF'", sqlconn))
        daNama.Fill(dsNama, "_nm")
        LUE_nama.Properties.DataSource = dsNama.Tables("_nm")
        LUE_nama.Properties.ValueMember = "NO_TABUNGAN"
        LUE_nama.Properties.DisplayMember = "NO_TABUNGAN"
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)

    End Sub

    Private Sub bt_cari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_cari.Click
        Cari()
        If LUE_nama.EditValue <> vbNullString Then
            hitung()
        End If

    End Sub

    Private Sub Txb_Nama_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Cari()
    End Sub

    Private Sub bt_hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_hitung.Click
        hitung()
    End Sub

    Private Sub tx_TARIK_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        If e.KeyCode = Keys.Enter Then
            hitung()

        End If
    End Sub

    Private Sub de_tglCair_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles de_tglCair.EditValueChanged
        tg_cair = de_tglCair.EditValue
        'Dim sql_bg_jln As SqlDataReader = New SqlCommand("select KOPKAR.dbo.getbunga('" & lb_NoTBG.Text & "',GETDATE())", sqlconn).ExecuteReader
        'If sql_bg_jln.Read Then
        '    bg_Bjln = sql_bg_jln.Item(0)
        'Else
        '    MsgBox("Koneksi ada masalah!!")
        'End If

        'sql_bg_jln.Close()
        ''MsgBox(tgl_reg.Substring(0, 2))
        'If tgl_reg.Substring(0, 2) = Today.Day Then
        '    bg_Bjln = 0
        'End If
        lb1_bg_jln.Text = bg_Bjln.ToString("c2", New Globalization.CultureInfo("id-ID", False))
    End Sub

    Private Sub cb_bg_jln_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cb_bg_jln.CheckedChanged
        If cb_bg_jln.Checked = True Then
            lb1_bg_jln.Enabled = True
            hitung()
        Else
            hitung()
            lb1_bg_jln.Enabled = False
        End If
    End Sub

    Private Sub LUE_nama_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LUE_nama.KeyDown
        If e.KeyCode = Keys.Enter Then
            Cari()
        End If
    End Sub
End Class