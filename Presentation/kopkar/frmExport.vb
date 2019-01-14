'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi + JI Sam SU                        =
'======================================================================

Imports System.Data.SqlClient
Imports System.Globalization
Imports System.IO
Imports DevExpress.XtraExport
Imports DevExpress.XtraGrid.Export


Public Class frmExport
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Dim ciUSA As CultureInfo = New CultureInfo("en-US")
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Private no_exp As String
    Private noseqx As Integer
    'Private x As Int16 = 1
    Private bultah As String
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, id_anggota, jns As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, ds_cari3, dso2, ds_cari, ds_cari1, ds_gdg1, ds_gdg2 As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row, rw, row2, row1 As DataRow
    Private DA, DA2, DALOOKUP, DALOOKUP1, DA_gdg1, DA_gdg2 As SqlClient.SqlDataAdapter
    Private x As Integer
    Private s1, s2, stor, bsr_pjm, angs, denda, t_bunga, total, recov, asr As Double
    Private BTRAN As SqlTransaction
    Private header1, header2, header3, rek_kop, blnskrg As String
    Private rptot, rec As Decimal
    Public suksess As Boolean
    Dim tgl_ex As Date
   

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        'Dim myBuilder As New SqlClient.SqlCommandBuilder
        'Dim sqlRek As SqlDataReader = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),1,6)as blthn", sqlconn).ExecuteReader
        'sqlRek.Read()
        'rek_kop = sqlRek.Item(0)
        'sqlRek.Close()
        suksess = True
        bt_exp.Enabled = True
        btnSave = False
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        'bersihkan()
        'dtpTgl.EditValue = getTanggal()
        'enabel()
        'GvBKE_d.Columns("no_seq").Visible = False
        STATE = "ADD" '<-- set state add
        'bt_exp.Enabled = False
    End Sub

    Public Sub setStatus()
        With (prn)
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
            sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),1,6)as blthn", sqlconn).ExecuteReader
        Else
            'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn, btrans).ExecuteReader
            sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),1,6) as blthn", sqlconn, btrans).ExecuteReader
        End If
        sqlblth.Read()
        hasil = sqlblth.Item(0)
        'End If
        sqlblth.Close()
        Return hasil
    End Function



    'Public Sub bersihkan()
    '    tx_id.Text = ""
    '    tx_nama.Text = ""
    '    'tx_iuran.Text = ""
    '    tx_setor.Text = ""
    '    tx_kembali.Clear()

    'End Sub

    Public Function App_Path() As String
        Return Application.StartupPath()
    End Function

    Private Sub frmExport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        'DALOOKUP = New SqlDataAdapter(New SqlCommand("select nasabah_id,Nama from anggota ", sqlconn))
        'DALOOKUP.Fill(ds_cari, "_lookup1")
        'RLnama.DataSource = ds_cari.Tables("_lookup1")
        'RLnama.ValueMember = "nasabah_id"
        'RLnama.DisplayMember = "Nama"

        LoadStruktur()



        baca_bln()
        'Lue_bln.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup


        rupiah.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        rupiah.DisplayFormat.Format = New CultureInfo("en-US")
        'rupiah.SummaryItem.DisplayFormat = DevExpress.Utils.FormatType.Custom
        'rupiah.SummaryItem.Format = New CultureInfo("en-US")
        baca_konfig()
        dtp_tahun.Text = Now
        cbTgl.Text = "25"
        refres()
    End Sub

    Public Sub baca_bln()

        Dim sqlbc1 As SqlDataReader = New SqlCommand("SELECT SUBSTRING(CONVERT(nvarchar(6),getdate(), 112),5,2)", sqlconn).ExecuteReader
        While sqlbc1.Read
            blnskrg = sqlbc1.Item(0)
            'header1 = sqlbc.Item("header1")
            'header2 = sqlbc.Item("header2")
            'header3 = sqlbc.Item("header3")
        End While
        sqlbc1.Close()
        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("SELECT id,kode,nama_bulan from m_bulan", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_bln")
        Lue_bln.Properties.DataSource = ds_cari1.Tables("_bln")
        Lue_bln.Properties.DisplayMember = "nama_bulan"
        Lue_bln.Properties.ValueMember = "kode"
        Lue_bln.EditValue = blnskrg

    End Sub


    Public Sub baca_konfig()
        Dim sqlbc As SqlDataReader = New SqlCommand("select * from m_konfig", sqlconn).ExecuteReader
        While sqlbc.Read
            rek_kop = sqlbc.Item("norek")
            header1 = sqlbc.Item("header1")
            header2 = sqlbc.Item("header2")
            header3 = sqlbc.Item("header3")
        End While
        sqlbc.Close()
        txb_norekKOP.Text = rek_kop
    End Sub
    'Private Sub formate_yayak()
    '    thisThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
    '    GV_nabung.Columns("rupiah").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
    '    GV_nabung.Columns("rupiah").DisplayFormat.FormatString = "{0:000000000000.00}"
    'End Sub

    Public Sub export_txt()

        Dim no_exp As String
        Dim recx As String = String.Format(ciUSA, "{0:00000}", rec)
        Dim rptotx As String = String.Format(ciUSA, "{0:0000000000000.00}", rptot)
        Dim link As BaseExportLink
        Dim nama As String = Lue_bln.EditValue + dtp_tahun.Text
        Dim provider As New ExportTxtProvider("D:\Debet" & nama & ".txt")


        Try

            provider.Separator = ""

            provider.AlignColumnWidth = True

            link = GV_export.CreateExportLink(provider)

            link.ExportTo(True)

            'Try
            '    GV_nabung.ExportToTextOld("d:\xx.txt")
            '    'Gc_nabung.exportto()

            '    'Diagnostics.Process.Start(App_Path())
            'Catch ex As Exception
            '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Gagal Simpan")
            'End Try
            'MsgBox(rptotx & " dan " & recx)

            'AppendAtPosition("d:\debet.txt", 0, "00000000000008800055    " & cbTgl.Text & "010" & txb_norekKOP.Text & "00MF" & recx & "" & rptotx & "" & Lue_bln.EditValue & "" & dtp_tahun.Text)
            simpan()
            If suksess = True Then
                AppendAtPosition("D:\Debet" & nama & ".txt", 0, header1 & cbTgl.Text & header2 & rek_kop & header3 & recx & "" & rptotx & "" & Lue_bln.EditValue & "" & dtp_tahun.Text)
                showMessages("Export TXT Berhasil di drive D:.")
                bt_exp.Enabled = False
            Else
                MsgBox("Export Gagal, silahkan cek data", MsgBoxStyle.Exclamation)
            End If
            
        Catch ex As Exception
            'BTRANS.Rollback()
            'dSO.Tables("_krd").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try


    End Sub

    Private Sub btnprin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_exp.Click
        If Lue_bln.EditValue = vbNullString Then
            MsgBox("Lengkapi Pilihan Tanggal dan Bulan exekusi")
            Exit Sub
        End If
        export_txt()
    End Sub

    Public Sub AppendAtPosition(ByVal ltFilePath As String, ByVal liAppendLine As Integer, ByVal ltAppendLine As String)

        Dim thefile As String = ltFilePath
        Dim lines() As String = System.IO.File.ReadAllLines(ltFilePath)

        lines(liAppendLine) = ltAppendLine

        System.IO.File.WriteAllLines(ltFilePath, lines)


    End Sub

    Public Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        refres()
    End Sub

    Public Sub refres()

        If Lue_bln.EditValue = vbNullString Then
            MsgBox("Lengkapi Pilihan Tanggal dan Bulan exekusi")
            Exit Sub
        End If 'wajib()
        tgl_ex = Date.ParseExact(cbTgl.EditValue & "/" & Lue_bln.EditValue & "/" & dtp_tahun.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
        bultah = dtp_tahun.Text + Lue_bln.EditValue
        pinjaman()
        ritel()
        wajib()
        haji()
        qurban()
        sukarela()
        ssb()
        ext()
        'rec = notrans_eksport.SummaryItem.SummaryValue

        'rptot = rupiah.SummaryItem.SummaryValue
    End Sub

    Private Sub isinomer()
        Dim i As Int16 = 1
        For Each row As DataRow In dSO.Tables("_krd").Rows
            row.Item("no_seq") = i : i += 1
        Next
    End Sub

    Public Sub LoadStruktur()
        If Not dSO.Tables("_exp") Is Nothing Then dSO.Tables("_exp").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from export_log where 1=0", sqlconn))
        DA.Fill(dSO, "_exp")
        'DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as Nama,0 as sisa_angs from simpanan_anggota_bayar where 1=0", sqlconn))
        'DA2.Fill(dSO1, "_trans")
        'Gc_nabung.DataSource = dSO.Tables("_exp")
    End Sub
    Public Sub ritel()

        'Dim BTRANS1 As SqlTransaction
        
        Dim sqldr As SqlDataReader = New SqlCommand("select k.nasabah_id,k.jenis,k.sisa_pokok,k.LAMA_ANGS,k.JML_PINJAMAN,k.sisa_angs,CASE WHEN (k.no_rek ='' or k.no_rek is null ) then '0'+a.REKBCA1 else '0'+k.no_rek END as no_rek,k.no_trans,SUBSTRING(a.Nama,1,30) as Nama,k.JML_POKOK as pokok,k.JML_BUNGA,(k.JML_POKOK+k.JML_BUNGA) as rupiah from retail k left join anggota a on k.nasabah_id=a.nasabah_id where k.stat_cair=1 and k.status_lunas='BELUM'", sqlconn).ExecuteReader
        'Dim x As Int16 = 1
        'dSO.Tables("_krd").Clear()
        'no_exp = getNoTrans("EXP", getTanggal(BTRANS1), BTRANS1)
        While sqldr.Read
            noseqx = noseqx + 1
            'Dim no_seqx As String = String.Format(ciUSA, "{0:000000}", noseqx)

            Dim rw As DataRow = dSO.Tables("_exp").NewRow
            rw.Item("notrans_eksport") = no_exp
            rw.Item("no_seq") = noseqx
            rw.Item("blthn") = bultah
            rw.Item("REKBCA1") = IIf(TypeOf sqldr.Item("no_rek") Is DBNull, "0000000", sqldr.Item("no_rek"))
            rw.Item("no_trans") = sqldr.Item("no_trans")
            rw.Item("jenis_debit") = sqldr.Item("jenis")
            rw.Item("jenis") = sqldr.Item("jenis")
            rw.Item("jml_pinjaman") = sqldr.Item("JML_PINJAMAN")
            rw.Item("pokok") = sqldr.Item("pokok")
            rw.Item("sisa_pokok") = sqldr.Item("sisa_pokok")
            rw.Item("lama_angs") = sqldr.Item("LAMA_ANGS")
            rw.Item("sisa_angs") = sqldr.Item("sisa_angs")
            rw.Item("bunga") = sqldr.Item("JML_BUNGA")
            rw.Item("Nama") = sqldr.Item("Nama")
            rw.Item("nasabah_id") = sqldr.Item("nasabah_id")
            rw.Item("rupiah") = sqldr.Item("rupiah")
            rw.Item("createdby") = username
            rw.Item("create_date") = Now
            rw.Item("export_ke") = 1
            'Clipboard.SetText(Date.Parse(cbTgl.Text & " - " & Lue_bln.EditValue & " - " & dtp_tahun.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            rw.Item("tgl_eksekusi") = Date.ParseExact(cbTgl.EditValue & "/" & Lue_bln.EditValue & "/" & dtp_tahun.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            'Clipboard.SetText(Date.Parse(dtp_tahun.Text & " - " & Lue_bln.EditValue & " - " & cbTgl.Text))

            dSO.Tables("_exp").Rows.Add(rw)
            'TxbPenerima.Text = supp
            'p_np = sqldr.Item("flag_ppn")
        End While
        sqldr.Close()

        'Lue_bln.EditValue = Now.Month
        'MsgBox(Now.Month)


        Gc_nabung.DataSource = dSO.Tables("_exp")

        'rec = notrans_eksport.SummaryItem.SummaryValue

        'rptot = rupiah.SummaryItem.SummaryValue

    End Sub
    Public Sub qurban()
        Dim sqldr As SqlDataReader = New SqlCommand("select  k.NASABAH_ID,CASE WHEN (no_rek ='' or no_rek is null ) then '0'+isnull(k.no_rek,a.REKBCA1) else no_rek END as no_rek,k.NO_TABUNGAN,SUBSTRING(a.Nama,1,30) as Nama,k.iuran as rupiah from tabung k left join anggota a on k.nasabah_id=a.nasabah_id  where k.JENIS_TABUNGAN='002'", sqlconn).ExecuteReader
        'Dim x As Int16 = 1
        'dSO.Tables("_krd").Clear()

        While sqldr.Read
            If sqldr.HasRows = False Then Exit Sub
            noseqx = noseqx + 1
            'Dim no_seqx As String = String.Format(ciUSA, "{0:000000}", noseqx)

            Dim rw As DataRow = dSO.Tables("_exp").NewRow
            rw.Item("notrans_eksport") = no_exp
            rw.Item("no_seq") = noseqx
            rw.Item("blthn") = bultah
            rw.Item("REKBCA1") = IIf(TypeOf sqldr.Item("no_rek") Is DBNull, "0000000", sqldr.Item("no_rek"))
            rw.Item("no_trans") = sqldr.Item("NO_TABUNGAN")
            rw.Item("jenis") = "QURB"
            rw.Item("jenis_debit") = "QURB"
            'rw.Item("bunga") = sqldr.Item("JML_BUNGA")
            rw.Item("Nama") = sqldr.Item("Nama")
            rw.Item("nasabah_id") = sqldr.Item("NASABAH_ID")
            rw.Item("rupiah") = sqldr.Item("rupiah")
            rw.Item("createdby") = username
            rw.Item("create_date") = Now
            rw.Item("export_ke") = 1
            'Clipboard.SetText(Date.Parse(cbTgl.Text & " - " & Lue_bln.EditValue & " - " & dtp_tahun.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            rw.Item("tgl_eksekusi") = Date.ParseExact(cbTgl.EditValue & "/" & Lue_bln.EditValue & "/" & dtp_tahun.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            'Clipboard.SetText(Date.Parse(dtp_tahun.Text & " - " & Lue_bln.EditValue & " - " & cbTgl.Text))

            dSO.Tables("_exp").Rows.Add(rw)
            'TxbPenerima.Text = supp
            'p_np = sqldr.Item("flag_ppn")
        End While
        sqldr.Close()

        'Lue_bln.EditValue = Now.Month
        'MsgBox(Now.Month)


        Gc_nabung.DataSource = dSO.Tables("_exp")
        sqldr.Close()

    End Sub

    Public Sub haji()
        Dim sqldr As SqlDataReader = New SqlCommand("select k.NASABAH_ID,CASE WHEN (no_rek ='' or no_rek is null ) then '0'+isnull(k.no_rek,a.REKBCA1) END as no_rek,k.NO_TABUNGAN,SUBSTRING(a.Nama,1,30) as Nama,k.iuran as rupiah from tabung k left join anggota a on k.nasabah_id=a.nasabah_id  where k.JENIS_TABUNGAN='003'", sqlconn).ExecuteReader
        'Dim x As Int16 = 1
        'dSO.Tables("_krd").Clear()

        While sqldr.Read
            If sqldr.HasRows = False Then Exit Sub
            noseqx = noseqx + 1
            'Dim no_seqx As String = String.Format(ciUSA, "{0:000000}", noseqx)

            Dim rw As DataRow = dSO.Tables("_exp").NewRow
            rw.Item("notrans_eksport") = no_exp
            rw.Item("no_seq") = noseqx
            rw.Item("blthn") = bultah
            rw.Item("REKBCA1") = IIf(TypeOf sqldr.Item("no_rek") Is DBNull, "0000000", sqldr.Item("no_rek"))
            rw.Item("no_trans") = sqldr.Item("NO_TABUNGAN")
            rw.Item("jenis") = "QRB"
            'rw.Item("pokok") = sqldr.Item("pokok")
            'rw.Item("bunga") = sqldr.Item("JML_BUNGA")
            rw.Item("Nama") = sqldr.Item("Nama")
            rw.Item("nasabah_id") = sqldr.Item("NASABAH_ID")
            rw.Item("rupiah") = sqldr.Item("rupiah")
            rw.Item("createdby") = username
            rw.Item("create_date") = Now
            rw.Item("export_ke") = 1
            'Clipboard.SetText(Date.Parse(cbTgl.Text & " - " & Lue_bln.EditValue & " - " & dtp_tahun.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            rw.Item("tgl_eksekusi") = Date.ParseExact(cbTgl.EditValue & "/" & Lue_bln.EditValue & "/" & dtp_tahun.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            'Clipboard.SetText(Date.Parse(dtp_tahun.Text & " - " & Lue_bln.EditValue & " - " & cbTgl.Text))

            dSO.Tables("_exp").Rows.Add(rw)
            'TxbPenerima.Text = supp
            'p_np = sqldr.Item("flag_ppn")
        End While
        sqldr.Close()

        'Lue_bln.EditValue = Now.Month
        'MsgBox(Now.Month)


        Gc_nabung.DataSource = dSO.Tables("_exp")
        sqldr.Close()

    End Sub

    Public Sub sukarela()
        Dim sqldr As SqlDataReader = New SqlCommand("select k.NASABAH_ID,CASE WHEN (k.no_rek ='' or k.no_rek is null) then '0'+isnull(k.no_rek,a.REKBCA1) ELSE  k.no_rek END as no_rek,k.NO_TABUNGAN,SUBSTRING(a.Nama,1,30) as Nama,k.iuran as rupiah from tabung k left join anggota a on k.nasabah_id=a.nasabah_id  where k.JENIS_TABUNGAN='006'", sqlconn).ExecuteReader
        'Dim x As Int16 = 1
        'dSO.Tables("_krd").Clear()

        While sqldr.Read
            If sqldr.HasRows = False Then Exit Sub
            noseqx = noseqx + 1
            'Dim no_seqx As String = String.Format(ciUSA, "{0:000000}", noseqx)

            Dim rw As DataRow = dSO.Tables("_exp").NewRow
            rw.Item("notrans_eksport") = no_exp
            rw.Item("no_seq") = noseqx
            rw.Item("blthn") = bultah
            rw.Item("REKBCA1") = IIf(TypeOf sqldr.Item("no_rek") Is DBNull, "0000000", sqldr.Item("no_rek"))
            rw.Item("no_trans") = sqldr.Item("NO_TABUNGAN")
            rw.Item("jenis") = "RLA "
            rw.Item("jenis_debit") = "RELA"
            'rw.Item("bunga") = sqldr.Item("JML_BUNGA")
            rw.Item("Nama") = sqldr.Item("Nama")
            rw.Item("nasabah_id") = sqldr.Item("NASABAH_ID")
            rw.Item("rupiah") = sqldr.Item("rupiah")
            rw.Item("createdby") = username
            rw.Item("create_date") = Now
            rw.Item("export_ke") = 1
            'Clipboard.SetText(Date.Parse(cbTgl.Text & " - " & Lue_bln.EditValue & " - " & dtp_tahun.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            rw.Item("tgl_eksekusi") = Date.ParseExact(cbTgl.EditValue & "/" & Lue_bln.EditValue & "/" & dtp_tahun.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            'Clipboard.SetText(Date.Parse(dtp_tahun.Text & " - " & Lue_bln.EditValue & " - " & cbTgl.Text))

            dSO.Tables("_exp").Rows.Add(rw)
            'TxbPenerima.Text = supp
            'p_np = sqldr.Item("flag_ppn")
        End While
        sqldr.Close()

        'Lue_bln.EditValue = Now.Month
        'MsgBox(Now.Month)


        Gc_nabung.DataSource = dSO.Tables("_exp")
        sqldr.Close()
    End Sub


    Public Sub ssb()
        Dim sqldr As SqlDataReader = New SqlCommand("select  isnull(norek,0000000000) as norek,jenis,no_trans,nip,SUBSTRING(nama,1,30) as nama,debet from m_ssb where rec_stat=1", sqlconn).ExecuteReader
        'Dim x As Int16 = 1
        'dSO.Tables("_krd").Clear()

        While sqldr.Read
            If sqldr.HasRows = False Then Exit Sub
            noseqx = noseqx + 1
            'Dim no_seqx As String = String.Format(ciUSA, "{0:000000}", noseqx)

            Dim rw As DataRow = dSO.Tables("_exp").NewRow
            rw.Item("notrans_eksport") = no_exp
            rw.Item("no_seq") = noseqx
            rw.Item("blthn") = bultah
            rw.Item("REKBCA1") = sqldr.Item("norek")
            rw.Item("no_trans") = sqldr.Item("no_trans")
            rw.Item("jenis") = sqldr.Item("jenis")
            rw.Item("jenis_debit") = sqldr.Item("jenis")
            'rw.Item("bunga") = sqldr.Item("JML_BUNGA")
            rw.Item("Nama") = sqldr.Item("nama")
            rw.Item("nasabah_id") = sqldr.Item("nip")
            rw.Item("rupiah") = sqldr.Item("debet")
            rw.Item("createdby") = username
            rw.Item("create_date") = Now
            rw.Item("export_ke") = 1
            'Clipboard.SetText(Date.Parse(cbTgl.Text & " - " & Lue_bln.EditValue & " - " & dtp_tahun.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            rw.Item("tgl_eksekusi") = Date.ParseExact(cbTgl.EditValue & "/" & Lue_bln.EditValue & "/" & dtp_tahun.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            'Clipboard.SetText(Date.Parse(dtp_tahun.Text & " - " & Lue_bln.EditValue & " - " & cbTgl.Text))

            dSO.Tables("_exp").Rows.Add(rw)
            'TxbPenerima.Text = supp
            'p_np = sqldr.Item("flag_ppn")
        End While
        sqldr.Close()

        'Lue_bln.EditValue = Now.Month
        'MsgBox(Now.Month)


        Gc_nabung.DataSource = dSO.Tables("_exp")
        sqldr.Close()
    End Sub

    Public Sub ext()
        Dim sqldr As SqlDataReader = New SqlCommand("select '0'+isnull(no_rek,'0000000000') as no_rek,no_trans,kd_grup,nip,SUBSTRING(nama,1,30) as nama,total_debet from m_debet_ext where rec_stat=1", sqlconn).ExecuteReader
        'Dim x As Int16 = 1
        'dSO.Tables("_krd").Clear()

        While sqldr.Read
            If sqldr.HasRows = False Then Exit Sub
            noseqx = noseqx + 1
            'Dim no_seqx As String = String.Format(ciUSA, "{0:000000}", noseqx)

            Dim rw As DataRow = dSO.Tables("_exp").NewRow
            rw.Item("notrans_eksport") = no_exp
            rw.Item("no_seq") = noseqx
            rw.Item("blthn") = bultah
            rw.Item("REKBCA1") = sqldr.Item("no_rek")
            rw.Item("no_trans") = sqldr.Item("no_trans")
            rw.Item("jenis") = sqldr.Item("kd_grup")
            rw.Item("jenis_debit") = sqldr.Item("kd_grup")
            'rw.Item("bunga") = sqldr.Item("JML_BUNGA")
            rw.Item("Nama") = sqldr.Item("nama")
            rw.Item("nasabah_id") = sqldr.Item("nip")
            rw.Item("rupiah") = sqldr.Item("total_debet")
            rw.Item("createdby") = username
            rw.Item("create_date") = Now
            rw.Item("export_ke") = 1
            'Clipboard.SetText(Date.Parse(cbTgl.Text & " - " & Lue_bln.EditValue & " - " & dtp_tahun.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            rw.Item("tgl_eksekusi") = Date.ParseExact(cbTgl.EditValue & "/" & Lue_bln.EditValue & "/" & dtp_tahun.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            'Clipboard.SetText(Date.Parse(dtp_tahun.Text & " - " & Lue_bln.EditValue & " - " & cbTgl.Text))

            dSO.Tables("_exp").Rows.Add(rw)
            'TxbPenerima.Text = supp
            'p_np = sqldr.Item("flag_ppn")
        End While
        sqldr.Close()

        'Lue_bln.EditValue = Now.Month
        'MsgBox(Now.Month)


        Gc_nabung.DataSource = dSO.Tables("_exp")
        sqldr.Close()
    End Sub

    Public Sub pinjaman()
        x = 1
        If Not dSO.Tables("_exp") Is Nothing Then dSO.Tables("_exp").Clear()
        Dim sqldr As SqlDataReader = New SqlCommand("select k.nasabah_id,k.sisa_pokok,k.LAMA_ANGS,k.JML_PINJAMAN,k.sisa_angs,case when (k.no_rek ='' or k.no_rek is null ) then '0'+a.REKBCA1 else '0'+k.no_rek END as no_rek,k.no_trans,SUBSTRING(a.Nama,1,30) as Nama,case when k.sisa_angs=1 then (k.JML_POKOK_TERAKHIR) else k.JML_POKOK end as pokok,k.JML_BUNGA,case WHEN k.sisa_angs=1 then (k.JML_POKOK_TERAKHIR+k.JML_BUNGA) else (k.JML_POKOK+k.JML_BUNGA) END as rupiah,k.jenis from kredit k left join anggota a on k.nasabah_id=a.nasabah_id where k.status_lunas='BELUM' and k.stat_approve=5 and k.jenis not in ('PKHS','PBNS','PTAT','PTHR')", sqlconn).ExecuteReader
        While sqldr.Read
            noseqx = x : x += 1
            Dim rw As DataRow = dSO.Tables("_exp").NewRow
            rw.Item("notrans_eksport") = no_exp
            rw.Item("no_seq") = noseqx
            rw.Item("blthn") = bultah
            rw.Item("REKBCA1") = IIf(TypeOf sqldr.Item("no_rek") Is DBNull, "0000000", sqldr.Item("no_rek"))
            rw.Item("no_trans") = sqldr.Item("no_trans")
            rw.Item("jenis_debit") = sqldr.Item("jenis")
            rw.Item("jenis") = sqldr.Item("jenis")
            rw.Item("jml_pinjaman") = sqldr.Item("JML_PINJAMAN")
            rw.Item("pokok") = sqldr.Item("pokok")
            rw.Item("sisa_pokok") = sqldr.Item("sisa_pokok")
            rw.Item("lama_angs") = sqldr.Item("LAMA_ANGS")
            rw.Item("sisa_angs") = sqldr.Item("sisa_angs")
            rw.Item("bunga") = sqldr.Item("JML_BUNGA")
            rw.Item("Nama") = sqldr.Item("Nama")
            rw.Item("nasabah_id") = sqldr.Item("nasabah_id")
            rw.Item("rupiah") = sqldr.Item("rupiah")
            rw.Item("createdby") = username
            rw.Item("create_date") = Now
            rw.Item("export_ke") = 1
            'Clipboard.SetText(Date.Parse(cbTgl.Text & " - " & Lue_bln.EditValue & " - " & dtp_tahun.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            rw.Item("tgl_eksekusi") = Date.ParseExact(cbTgl.EditValue & "/" & Lue_bln.EditValue & "/" & dtp_tahun.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            'Clipboard.SetText(Date.Parse(dtp_tahun.Text & " - " & Lue_bln.EditValue & " - " & cbTgl.Text))

            dSO.Tables("_exp").Rows.Add(rw)
            'TxbPenerima.Text = supp
            'p_np = sqldr.Item("flag_ppn")
        End While
        sqldr.Close()

        'Lue_bln.EditValue = Now.Month
        'MsgBox(Now.Month)


        Gc_nabung.DataSource = dSO.Tables("_exp")

        'rec = notrans_eksport.SummaryItem.SummaryValue

        'rptot = rupiah.SummaryItem.SummaryValue

    End Sub

    
    Public Sub wajib()
        Dim sqldr As SqlDataReader = New SqlCommand("select t.no_tab,CASE WHEN a.REKBCA1 ='' or a.REKBCA1 is null then  '0'+isnull(a.REKBCA1,0000000000) else a.REKBCA1 END as no_rek,a.nasabah_id,SUBSTRING(a.Nama,1,30) as Nama,t.nilai_wajib as rupiah,'    ' as ekor from tab_wajib t left outer join anggota a on  t.nasabah_id=a.nasabah_id where a.Rec_Stat=1", sqlconn).ExecuteReader
        'Dim x As Int16 = 1
        'dSO.Tables("_krd").Clear()

        While sqldr.Read
            If sqldr.HasRows = False Then Exit Sub
            noseqx = noseqx + 1
            'Dim no_seqx As String = String.Format(ciUSA, "{0:000000}", noseqx)

            Dim rw As DataRow = dSO.Tables("_exp").NewRow
            rw.Item("notrans_eksport") = no_exp
            rw.Item("no_seq") = noseqx
            rw.Item("blthn") = bultah
            rw.Item("REKBCA1") = IIf(TypeOf sqldr.Item("no_rek") Is DBNull, "0000000", sqldr.Item("no_rek"))
            rw.Item("no_trans") = sqldr.Item("no_tab")
            rw.Item("jenis") = "    "
            rw.Item("jenis_debit") = "    "
            'rw.Item("bunga") = sqldr.Item("JML_BUNGA")
            rw.Item("Nama") = sqldr.Item("Nama")
            rw.Item("nasabah_id") = sqldr.Item("nasabah_id")
            rw.Item("rupiah") = sqldr.Item("rupiah")
            rw.Item("createdby") = username
            rw.Item("create_date") = Now
            rw.Item("export_ke") = 1
            'Clipboard.SetText(Date.Parse(cbTgl.Text & " - " & Lue_bln.EditValue & " - " & dtp_tahun.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            rw.Item("tgl_eksekusi") = Date.ParseExact(cbTgl.EditValue & "/" & Lue_bln.EditValue & "/" & dtp_tahun.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
            'Clipboard.SetText(Date.Parse(dtp_tahun.Text & " - " & Lue_bln.EditValue & " - " & cbTgl.Text))

            dSO.Tables("_exp").Rows.Add(rw)
            'TxbPenerima.Text = supp
            'p_np = sqldr.Item("flag_ppn")
        End While
        sqldr.Close()

        'Lue_bln.EditValue = Now.Month
        'MsgBox(Now.Month)


        Gc_nabung.DataSource = dSO.Tables("_exp")
        sqldr.Close()
    End Sub
    'Public Sub wajibz()

    '    tgl_ex = Date.ParseExact(cbTgl.EditValue & "/" & Lue_bln.EditValue & "/" & dtp_tahun.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
    '    If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
    '    'Dim sqdr As SqlDataReader = New SqlCommand("select sales.dbo.SALES_SO_D.kd_stok as kd_stok,PROD.DBO.PROD_rcn_krm.jumlah as jumlah,SALES.dbo.SALES_SO_D.Kd_satuan as Kd_satuan,0 as qty_out from PROD.DBO.PROD_rcn_krm LEFT JOIN sales.dbo.SALES_SO_D ON PROD.DBO.PROD_rcn_krm.no_sp = sales.dbo.SALES_SO_D.no_sp and PROD.DBO.PROD_rcn_krm.no_sp_dtl=sales.dbo.SALES_SO_D.No_seq where PROD.DBO.PROD_rcn_krm.no_dpb='" & LookupDPB.EditValue & "'", sqlconn).ExecuteReader
    '    'MsgBox(LookupNoRetur.Text)
    '    Dim sqldr As SqlDataReader = New SqlCommand("select REKBCA1,nasabah_id,'    ' as kode,SUBSTRING(Nama,1,30) as Nama,'100000' as rupiah,'    ' as ekor from anggota", sqlconn).ExecuteReader
    '    'Dim i As Int16 = 1
    '    'Dim x As Int16 = 1
    '    'dSO.Tables("_krd").Clear()

    '    While sqldr.Read
    '        Dim rw As DataRow = dSO.Tables("_krd").NewRow
    '        rw.Item("no_seq") = x : x += 1
    '        rw.Item("blthn") = dtp_tahun.Value.Year & "" & Lue_bln.EditValue
    '        rw.Item("REKBCA1") = sqldr.Item("REKBCA1")
    '        rw.Item("nasabah_id") = sqldr.Item("nasabah_id")
    '        rw.Item("kode") = sqldr.Item("kode")
    '        rw.Item("Nama") = sqldr.Item("Nama")
    '        rw.Item("rupiah") = sqldr.Item("rupiah")
    '        rw.Item("tgl_eksekusi") = Date.ParseExact(cbTgl.EditValue & "/" & Lue_bln.EditValue & "/" & dtp_tahun.Text, "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo)
    '        'Clipboard.SetText(Date.Parse(dtp_tahun.Text & " - " & Lue_bln.EditValue & " - " & cbTgl.Text))
    '        dSO.Tables("_krd").Rows.Add(rw)
    '        'TxbPenerima.Text = supp
    '        'p_np = sqldr.Item("flag_ppn")
    '    End While
    '    sqldr.Close()
    '    rec = notrans_eksport.SummaryItem.SummaryValue
    '    rptot = rupiah.SummaryItem.SummaryValue

    'End Sub

    Private Sub GV_nabung_CustomDrawFooterCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs) Handles GV_export.CustomDrawFooterCell
        If e.Column Is rupiah Then
            Dim parsed As Decimal = CDec(e.Info.Value)
            Dim text As String = String.Format(ciUSA, "{0:000000000000.00}", parsed)
            e.Info.DisplayText = text

        Else
            Dim parsed As Decimal = CDec(e.Info.Value)
            Dim text1 As String = String.Format(ciUSA, "{0:00000}", parsed)
            e.Info.DisplayText = text1

        End If
    End Sub

    Public Sub simpan()
        Dim BTRANS As SqlTransaction
        prc_bckp(BTRANS)
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
            Dim sqlcmd1 As New SqlCommand("update KOPKAR.dbo.m_konfig set last_debet=@tgl, last_upload=GETDATE()", sqlconn, BTRANS)
            sqlcmd1.Parameters.AddWithValue("@tgl", tgl_ex)
            sqlcmd1.ExecuteNonQuery()
            Dim sqlcmd2 As New SqlCommand("UPDATE kredit set sudah_upload=1", sqlconn, BTRANS)
            sqlcmd2.ExecuteNonQuery()
            Dim sqlcmd3 As New SqlCommand("UPDATE retail set sudah_upload=1", sqlconn, BTRANS)
            sqlcmd3.ExecuteNonQuery()

            no_exp = getNoTrans("EXP", getTanggal(BTRANS), BTRANS)
            For Each rw As DataRow In dSO.Tables("_exp").Rows
                rw.Item("notrans_eksport") = no_exp
            Next
            DA.Update(dSO.Tables("_exp"))

            STATE = "EDIT"
            BTRANS.Commit()
            BTRANS.Dispose()
            showMessages("Berhasil disimpan ke database")
            LoadStruktur()
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_krd").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
            suksess = False
        End Try


    End Sub
    Public Sub prc_bckp(ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "KOPKAR.dbo.bckp_db"
        'sqlCmd.Parameters.Add("@tanggal", SqlDbType.Date).Value = tglx
        Dim dr As SqlDataReader = sqlCmd.ExecuteReader
        dr.Close()
    End Sub
    'Private Sub Lue_bln_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lue_bln.EditValueChanged
    '    MsgBox(Lue_bln.EditValue)
    'End Sub
End Class