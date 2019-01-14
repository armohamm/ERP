'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2015                       =
'= Sebelum Coding Jangan Lupa kopi + JI Sam SU                        =
'======================================================================

Imports System.Data.SqlClient
Imports System.Globalization
Imports DevExpress.XtraGrid

Public Class frmPraExport
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, id_anggota, jns As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, ds_tbh, ds_cari3, dso2, ds_cari, ds_cari1, ds_gdg1, ds_gdg2 As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Private DA, DA2, DALOOKUP, DALOOKUP1, DA_gdg1, DA_gdg2 As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private bunga, tempo, pokok, bsr_pjm, angs, denda, t_bunga, total, recov, asr As Double
    Private BTRAN As SqlTransaction
    Public drl As DataRelation
    Dim bultah As String
    Private stat_tran As Boolean


    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        'Dim myBuilder As New SqlClient.SqlCommandBuilder
        btexport.Enabled = True
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
    Public Sub cancel_click()
        LoadStruktur()

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
        'bersihkan()
    End Sub
    Private Sub isinomer()
        Dim i As Int16 = 1
        For Each row As DataRow In dSO.Tables("_krd").Rows
            row.Item("nomer") = i : i += 1
        Next
    End Sub

    Public Sub cek_blthn()
        stat_tran = True

        Dim sqlr As SqlDataReader = New SqlCommand("select max(blthn) from export_log where blthn='" & bultah & "'", sqlconn).ExecuteReader
        While sqlr.Read()
            If Not TypeOf sqlr.Item(0) Is DBNull Then
                stat_tran = False
                MsgBox("Bulan Tahun ini (" & bultah & ") sudah melakukan Export.. lakukan pembatalan/delete transkasi lama dahulu")
                Exit Sub
                'If bl_max Is vbNullString Then
                '    MsgBox("tidak ada bulan baru, lanjut")
            End If
        End While
        sqlr.Close()
        'If sqlr.HasRows Then
        '    MsgBox("BULAN INI SUDAH DILAKUKAN EXPORT ke BCA BUSINESS.. lakukan pembatalan terlebih dahulu!!", MsgBoxStyle.Exclamation)
        '    stat_tran = False
        'End If
        'End If

        'MsgBox(notran)
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
    Public Sub enebel_centang()
        cb_POK.CheckState = CheckState.Checked
        cbBNS.CheckState = CheckState.Checked
        cbBRG.CheckState = CheckState.Checked
        cbGRP.CheckState = CheckState.Checked
        cbKHU.CheckState = CheckState.Checked
        cbNON.CheckState = CheckState.Checked
        cbNON1.CheckState = CheckState.Checked
        cbNOR.CheckState = CheckState.Checked
        cbQRB.CheckState = CheckState.Checked
        cbRLA.CheckState = CheckState.Checked
        cbSPC.CheckState = CheckState.Checked
        cbTAT.CheckState = CheckState.Checked
        cbTHR.CheckState = CheckState.Checked
        cbWJB.CheckState = CheckState.Checked
    End Sub
    Public Sub disebel_ctg()
        cb_POK.CheckState = CheckState.Unchecked
        cbBNS.CheckState = CheckState.Unchecked
        cbBRG.CheckState = CheckState.Unchecked
        cbGRP.CheckState = CheckState.Unchecked
        cbKHU.CheckState = CheckState.Unchecked
        cbNON.CheckState = CheckState.Unchecked
        cbNON1.CheckState = CheckState.Unchecked
        cbNOR.CheckState = CheckState.Unchecked
        cbQRB.CheckState = CheckState.Unchecked
        cbRLA.CheckState = CheckState.Unchecked
        cbSPC.CheckState = CheckState.Unchecked
        cbTAT.CheckState = CheckState.Unchecked
        cbTHR.CheckState = CheckState.Unchecked
        cbWJB.CheckState = CheckState.Unchecked
    End Sub
    Public Function App_Path() As String
        Return Application.StartupPath()
    End Function

    Public Sub LoadStruktur()
        If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()

        Dim item1 As GridGroupSummaryItem = New GridGroupSummaryItem

        'Dim sqltgl As String = ""
        
        If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
        'DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select 0 as nomer,a.REKBCA1,k.nasabah_id,k.jenis, k.no_trans, a.Nama, (k.JML_POKOK+k.JML_BUNGA) as rpangsuran from kredit k left join anggota a on k.nasabah_id=a.nasabah_id where k.stat_cair=1 and k.status_lunas='BELUM' ", sqlconn))
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select 0 as nomer,0 as total_d, a.nasabah_id,a.Nama, CASE when a.iuran_pokok=1 then 0 when a.iuran_pokok=0 THEN (select c.rp_pokok from m_konfig c where c.id_cabang=a.id_cabang) END  as pokok,  " & _
"ISNULL((SELECT iuran from tab_wajib t where t.nasabah_id=a.nasabah_id ),0) as wajib," & _
"ISNULL((SELECT SUM(rupiah) from gagaldebet t where t.nasabah_id=a.nasabah_id group by t.nasabah_id),0) as tundaan," & _
"ISNULL((select sum(b.iuran) from tabung b where SUBSTRING(b.no_tabungan,1,3)='TRL' AND b.STATUS_AKTIF='AKTIF' AND b.NASABAH_ID=a.nasabah_id group by b.NASABAH_ID ),0) as sukarela, " & _
"ISNULL((select sum(b.iuran) from tabung b where SUBSTRING(b.no_tabungan,1,3)='QRB' AND b.STATUS_AKTIF='AKTIF' AND  b.NASABAH_ID=a.nasabah_id group by b.NASABAH_ID ),0) as qurban, " & _
"ISNULL((select sum(k.JML_POKOK+k.JML_BUNGA) from kredit k where k.jenis='PTHR' and  k.stat_cair=1 and k.status_lunas='BELUM' and k.nasabah_id=a.nasabah_id group by k.nasabah_id ),0) as thr, " & _
"ISNULL((select sum(k.JML_POKOK+k.JML_BUNGA) from kredit k where k.jenis='PTAT' and  k.stat_cair=1 and k.status_lunas='BELUM' and k.nasabah_id=a.nasabah_id group by k.nasabah_id ),0) as tat, " & _
"ISNULL((select sum(k.JML_POKOK+k.JML_BUNGA) from kredit k where k.jenis='PBNS' and  k.stat_cair=1 and k.status_lunas='BELUM' and k.nasabah_id=a.nasabah_id group by k.nasabah_id ),0) as bns, " & _
"ISNULL((select sum(k.JML_POKOK+k.JML_BUNGA) from kredit k where k.jenis='PKHS' and  k.stat_cair=1 and k.status_lunas='BELUM' and k.nasabah_id=a.nasabah_id group by k.nasabah_id ),0) as khu, " & _
"ISNULL((select sum(k.JML_POKOK+k.JML_BUNGA) from kredit k where k.jenis='PBRG' and  k.stat_cair=1 and k.status_lunas='BELUM' and k.nasabah_id=a.nasabah_id group by k.nasabah_id ),0) as brg, " & _
"ISNULL((select sum(CASE when k.sisa_angs=1 then (sisa_pokok+k.JML_BUNGA) ELSE (k.JML_POKOK+k.JML_BUNGA) END) from kredit k where k.jenis='NOR ' and  k.stat_cair=1 and k.status_lunas='BELUM' and k.nasabah_id=a.nasabah_id group by k.nasabah_id ),0) as nor,  " & _
"ISNULL((select sum(CASE when k.sisa_angs=1 then (sisa_pokok+k.JML_BUNGA) ELSE (k.JML_POKOK+k.JML_BUNGA) END) from kredit k where k.jenis='NON ' and  k.stat_cair=1 and k.status_lunas='BELUM' and k.nasabah_id=a.nasabah_id group by k.nasabah_id ),0) as non, " & _
"ISNULL((select sum(k.JML_POKOK+k.JML_BUNGA) from retail k where k.jenis='BRG ' and  k.stat_cair=1 and k.status_lunas='BELUM' and k.nasabah_id=a.nasabah_id group by k.nasabah_id ),0) as rtl " & _
"from anggota a  ", sqlconn))
        DA.Fill(dSO, "_krd")

        Gc_nabung.DataSource = dSO.Tables("_krd")

        If dSO.Tables("_krd").Rows.Count > 0 Then
            If Not dSO1.Tables("_krd") Is Nothing Then dSO1.Tables("_krd").Clear()
            te_rtl.EditValue = GV_nabung.Columns("rtl").SummaryItem.SummaryValue
            TE_nor.EditValue = GV_nabung.Columns("nor").SummaryItem.SummaryValue
            te_non.EditValue = GV_nabung.Columns("non").SummaryItem.SummaryValue
            te_bns.EditValue = GV_nabung.Columns("bns").SummaryItem.SummaryValue
            te_brg.EditValue = GV_nabung.Columns("brg").SummaryItem.SummaryValue
            te_thr.EditValue = GV_nabung.Columns("thr").SummaryItem.SummaryValue
            TE_kurban.EditValue = GV_nabung.Columns("qurban").SummaryItem.SummaryValue
            TE_rela.EditValue = GV_nabung.Columns("sukarela").SummaryItem.SummaryValue
            te_tund.EditValue = GV_nabung.Columns("tundaan").SummaryItem.SummaryValue
            TE_wajib.EditValue = GV_nabung.Columns("wajib").SummaryItem.SummaryValue
            TE_rela.EditValue = GV_nabung.Columns("rtl").SummaryItem.SummaryValue
            TE_kurban.EditValue = GV_nabung.Columns("rtl").SummaryItem.SummaryValue
            TE_Pokok.EditValue = GV_nabung.Columns("pokok").SummaryItem.SummaryValue
            te_khu.EditValue = GV_nabung.Columns("khu").SummaryItem.SummaryValue
            te_tat.EditValue = GV_nabung.Columns("tat").SummaryItem.SummaryValue
            '    Dim sqdr As SqlDataReader = New SqlCommand("select isnull((select sum(k.JML_POKOK+k.JML_BUNGA) from kredit k left join anggota a on k.nasabah_id=a.nasabah_id where k.stat_cair=1 and k.status_lunas='BELUM' and k.jenis='NON ' group by k.jenis),0) as t_non, " & _
            '"ISNULL((select sum(k.JML_POKOK+k.JML_BUNGA)  from kredit k left join anggota a on k.nasabah_id=a.nasabah_id where k.stat_cair=1 and k.status_lunas='BELUM' and k.jenis='NOR ' group by k.jenis),0) as t_nor, " & _
            '"ISNULL((select Sum(k.JML_POKOK+k.JML_BUNGA)  from kredit k left join anggota a on k.nasabah_id=a.nasabah_id where k.stat_cair=1 and k.status_lunas='BELUM' and k.jenis='KHU ' group by k.jenis),0) as t_khu,  " & _
            '"ISNULL((select sum(k.JML_POKOK+k.JML_BUNGA) from kredit k left join anggota a on k.nasabah_id=a.nasabah_id where k.stat_cair=1 and k.status_lunas='BELUM' and k.jenis='BRG ' group by k.jenis),0) as t_brg, " & _
            '"ISNULL((select sum(k.JML_POKOK+k.JML_BUNGA) from retail k left join anggota a on k.nasabah_id=a.nasabah_id where k.stat_cair=1 and k.status_lunas='BELUM' and k.jenis='BRG ' group by k.jenis),0) as t_rtl, " & _
            '"ISNULL((select sum(k.JML_POKOK+k.JML_BUNGA) from kredit k left join anggota a on k.nasabah_id=a.nasabah_id where k.stat_cair=1 and k.status_lunas='BELUM' and k.jenis='THR ' group by k.jenis),0) as t_thr, " & _
            '"ISNULL((select sum(b.iuran) from tabung b left join anggota a on b.NASABAH_ID=a.nasabah_id where SUBSTRING(b.no_tabungan,1,3)='TRL'),0) as t_trl,  " & _
            '"ISNULL((select sum(b.iuran) from tabung b left join anggota a on b.NASABAH_ID=a.nasabah_id where SUBSTRING(b.no_tabungan,1,3)='QRB'),0) as t_qrb,  " & _
            '"ISNULL((select sum(k.JML_POKOK+k.JML_BUNGA) from kredit k left join anggota a on k.nasabah_id=a.nasabah_id where k.stat_cair=1 and k.status_lunas='BELUM' and k.jenis='BNS ' group by k.jenis),0) as t_bns, " & _
            '"ISNULL((select sum(iuran) from tab_wajib k left join anggota a on k.nasabah_id=a.nasabah_id),0) as t_wjb", sqlconn).ExecuteReader
            '    Dim i As Int16 = 1
            '    While sqdr.Read
            '        TE_nor.EditValue = sqdr.Item("t_nor")
            '        te_non.EditValue = sqdr.Item("t_non")
            '        te_bns.EditValue = sqdr.Item("t_bns")
            '        te_brg.EditValue = sqdr.Item("t_brg")
            '        te_tat.EditValue = sqdr.Item("t_tat")
            '        te_thr.EditValue = sqdr.Item("t_thr")
            '        te_rtl.EditValue = sqdr.Item("t_rtl")
            '        TE_wajib.EditValue = sqdr.Item("t_wjb")
            '        TE_rela.EditValue = sqdr.Item("t_trl")
            '        TE_kurban.EditValue = sqdr.Item("t_qrb")
            '        'TE_Pokok.EditValue = sqdr.Item("t_pokok")

            '    End While
            '    sqdr.Close()
        End If
        'item1.FieldName = "UnitPrice"
        'item1.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'item1.DisplayFormat = "Sum = {0:c2}"

        'TE_non.EditValue = 10720
        'TE_nor.EditValue = 3573
        'TE_total_all.EditValue = 14293
        isinomer()
    End Sub
    Public Sub save_click()

    End Sub
    Public Sub simpan()

    End Sub

    Private Sub frmPraExport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        LoadStruktur()
        bultah = blthn()

        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT kode,Nama FROM m_jns_upload", sqlconn))
        DALOOKUP.Fill(ds_cari, "LookTran")
        RL_jenis.DataSource = ds_cari.Tables("LookTran")
        RL_jenis.DisplayMember = "Nama"
        RL_jenis.ValueMember = "kode"

        GV_nabung.Columns("nomer").Fixed = Columns.FixedStyle.Left
        GV_nabung.Columns("nasabah_id").Fixed = Columns.FixedStyle.Left
        GV_nabung.Columns("Nama").Fixed = Columns.FixedStyle.Left


        enebel_centang()
        'DALOOKUP1 = New SqlDataAdapter(New SqlCommand("SELECT kode,Nama FROM m_jns_upload", sqlconn))
        'DALOOKUP1.Fill(ds_cari1, "set_pjm")
        'Lue_SetPjm.Properties.DataSource = ds_cari1.Tables("set_pjm")

        'Lue_SetPjm.Properties.DisplayMember = "Nama"
        'Lue_SetPjm.Properties.ValueMember = "kode"

    End Sub

 
    Private Sub btnprin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btexport.Click
        'frmExport.LoadStruktur()
        'Dim no_exp As String
        'Dim BTRANS1 As SqlTransaction
        'no_exp = getNoTrans("EXP", getTanggal(BTRANS1), BTRANS1)

        cek_blthn()
        If stat_tran = False Then
            If MsgBox("Apakah Akan pembatalan export bulan tahun " & bultah & " sebelumnya?? Yes=Pembatalan/ulang, No=tidak", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim sqlcmd1 As New SqlCommand("delete KOPKAR.dbo.export_log where blthn='" & bultah & "'", sqlconn)
                'sqlcmd1.Parameters.AddWithValue("@tgl", tgl_ex)
                sqlcmd1.ExecuteNonQuery()
                sqlcmd1.Dispose()
                'sqlcmd1.Connection.Close()
                showMessages("Sudah di hapus/dibatalkan...")
                btexport.Enabled = False
                Exit Sub
            Else
                Exit Sub
            End If

        End If
        frmExport.Show()
        'frmExport.LoadStruktur()
        'frmExport.pinjaman()

        'frmExport.Close()
        'umum.coll_form.Item(frmExport.Name).pinjaman()
    End Sub

End Class