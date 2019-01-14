'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi + JI Sam SU                        =
'======================================================================

Imports System.Data.SqlClient
Imports System.Globalization

Public Class nabung
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, id_anggota, jns As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, ds_cari3, dso2, ds_cari, ds_cari1, ds_gdg1, ds_gdg2 As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row, rw, row2, row1 As DataRow
    Private DA, DA2, DALOOKUP, DALOOKUP1, DA_gdg1, DA_gdg2 As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private s1, s2, stor, bsr_pjm, angs, denda, t_bunga, total, recov, asr As Double
    Private no_tbg, ntran_cek As String
    Private stat_tran As Boolean
    Private BTRAN As SqlTransaction


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
    'Private Function blthn(Optional ByVal btrans As Object = Nothing) As String
    '    Dim hasil As String
    '    Dim sqlblth As SqlDataReader
    '    If btrans Is Nothing Then
    '        'blthn=082011
    '        'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn).ExecuteReader
    '        '##blthn=201108
    '        sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),1,6)as blthn", sqlconn).ExecuteReader
    '    Else
    '        'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn, btrans).ExecuteReader
    '        sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),1,6) as blthn", sqlconn, btrans).ExecuteReader
    '    End If
    '    sqlblth.Read()
    '    hasil = sqlblth.Item(0)
    '    'End If
    '    sqlblth.Close()
    '    Return hasil
    'End Function

    Public Sub LoadStruktur(ByVal kode As String)
        If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from tabung where NO_TABUNGAN='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_krd")
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from tabtrans where 1=0", sqlconn))
        DA2.Fill(dSO1, "_trans")
        Gc_nabung.DataSource = dSO1.Tables("_trans")
    End Sub

    Public Sub save_click()
        If TE_Setor.EditValue = vbNullString Then
            MsgBox("Nilai Setoran belim di isi/Kosong", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        If MsgBox("Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Public Sub simpan()
        Dim BTRANS As SqlTransaction
        'If STATE = "ADD" Then

        If STATE = "EDIT" Then
            row = dSO.Tables("_trans").Rows(0)
            row.Item("Last_Update_Date") = getTanggal()
            row.Item("Last_Updated_By") = username
        ElseIf STATE = "CETAK" Then
            row.Item("cetak_ke") = row.Item("cetak_ke") + 1
        End If

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

            Dim sqlcmd1 As New SqlCommand("update tabung set SALDO_AKHIR=@nilai where NO_TABUNGAN='" & tx_noTbg.Text & "'", sqlconn, BTRANS)
            sqlcmd1.Parameters.AddWithValue("@nilai", row1.Item("SALDO_AKHIR"))
            sqlcmd1.ExecuteNonQuery()

            DA.Update(dSO.Tables("_krd"))
            DA2.Update(dSO1.Tables("_trans"))

            'STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan")
            'cancel_click()
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_krd").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try


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
    Public Function blthn(Optional ByVal btrans As Object = Nothing) As String
        Dim hasil As String
        Dim sqlblth As SqlDataReader
        If btrans Is Nothing Then
            'blthn=082011
            'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn).ExecuteReader
            '##blthn=201108
            'sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),1,6)as blthn", sqlconn).ExecuteReader
            sqlblth = New SqlCommand("select KOPKAR.dbo.getkodeperiode()", sqlconn).ExecuteReader
        Else
            'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn, btrans).ExecuteReader
            'sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),1,6)as blthn", sqlconn).ExecuteReader
            sqlblth = New SqlCommand("select KOPKAR.dbo.getkodeperiode()", sqlconn).ExecuteReader
        End If
        sqlblth.Read()
        hasil = sqlblth.Item(0)
        'End If
        sqlblth.Close()
        Return hasil
    End Function

    Public Function getNextNumber() As String
        Dim hasil, temp As String
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(no_trans,14,3) as numeric)) from tabtrans where no_trans like '" & ntran_cek & "%'", sqlconn).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "001"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 2
                temp = "0" & temp
            Next
            hasil = temp & (hasil + 1)
        End If
        sqlDR.Close()
        Return hasil
    End Function

    Public Function cek_notran() As String
        'stat_tran = True

        'Lue_SetPjm.Properties.GetDataSourceValue("kd2", Lue_SetPjm.ItemIndex).ToString()
        ntran_cek = no_tbg & blthn()
        'MsgBox(ntran_cek)
        Dim sqlr As SqlDataReader = New SqlCommand("select * from tabtrans where no_trans like '" & ntran_cek & "%'", sqlconn).ExecuteReader
        Clipboard.SetText("select * from tabtrans where no_trans like '" & ntran_cek & "%'")

        If sqlr.HasRows Then
            ntran_cek = no_tbg & blthn() & getNextNumber()
            'MsgBox(ntran_cek)
        Else
            ntran_cek = no_tbg & blthn() & "001"
            'MsgBox(ntran_cek)
        End If
        sqlr.Close()
        Return ntran_cek
    End Function


    Public Sub Cari()
        DA_gdg1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.nasabah_id,a.Nama as [Nama],tb.NO_TABUNGAN,tb.SALDO_AWAL,tb.SALDO_AKHIR,a.jns_kel as [Jenis_kelamin],a.Almt_asal,a.telp_skrg,a.REKBCA1 from tabung tb left join anggota a on tb.NASABAH_ID=a.nasabah_id", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not ds_gdg1.Tables("lookup_Pegawai") Is Nothing Then ds_gdg1.Tables("lookup_Pegawai").Clear()
        DA_gdg1.Fill(ds_gdg1, "lookup_Pegawai")
        frmCari.set_dso(ds_gdg1.Tables("lookup_Pegawai")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then
            tx_nama.Text = frmCari.row("Nama")
            tx_id.Text = frmCari.row("nasabah_id")
            'tx_alamant.Text = frmCari.row("Almt_asal")
            id_anggota = frmCari.row("nasabah_id")
            s1 = frmCari.row("SALDO_AWAL")
            no_tbg = frmCari.row("NO_TABUNGAN")
            tx_saldo1.Text = frmCari.row("SALDO_AKHIR")

            tx_noTbg.Text = no_tbg

        End If
    End Sub

    Public Sub cetak_click()
        callReport(App_Path() & "\report\pengajuan.rpt", "", "no_trn=" & tx_noTbg.Text)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Cari()
        TE_Setor.Focus()
    End Sub

    Private Sub nabung_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        LoadStruktur("xxx")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select nasabah_id,Nama from anggota", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup")
        RLnama.DataSource = ds_cari.Tables("_lookup")
        RLnama.ValueMember = "nasabah_id"
        RLnama.DisplayMember = "Nama"

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select KODE_TRANS,DESKRIPSI_TRANS from kodetranstabungan", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_lookup1")
        RL_kdTrans.DataSource = ds_cari1.Tables("_lookup1")
        RL_kdTrans.ValueMember = "KODE_TRANS"
        RL_kdTrans.DisplayMember = "DESKRIPSI_TRANS"
    End Sub
    Private Sub tx_setor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

    End Sub

    Private Sub TE_Setor_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TE_Setor.KeyDown

        If e.KeyCode = Keys.Enter Then
            'cek_notran()
            Dim x As Integer = 0
            If tx_id.Text <> "" Then
                stor = TE_Setor.EditValue
                '## SETOR TUNAI
                row1 = dSO1.Tables("_trans").NewRow
                row1.Item("URUTAN") = 1
                row1.Item("TGL_TRANS") = getTanggal()
                row1.Item("NO_TABUNGAN") = tx_noTbg.Text
                row1.Item("NASABAH_ID") = id_anggota
                row1.Item("KODE_TRANS") = "01" 'SETOR TUNAI
                row1.Item("SALDO_AWAL") = tx_saldo1.Text
                row1.Item("SALDO_TRANS") = TE_Setor.EditValue
                row1.Item("SALDO_AKHIR") = s1 + stor

                row1.Item("no_trans") = cek_notran()
                row1.Item("Last_Create_Date") = getTanggal()
                row1.Item("Last_Created_By") = username
                row1.Item("cetak_ke") = 0

                MsgBox(cek_notran())
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

            End If


            save_click()
        End If
    End Sub
End Class