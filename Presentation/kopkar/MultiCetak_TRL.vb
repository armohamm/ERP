Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraPrintingLinks

Public Class MultiCetak_TRL
    Dim ds, ds_cari, dsLookUp, ds_cari2, ds_gdg1, ds_gdg2 As New DataSet
    Dim da, DALOOKUP, DALOOKUP2, DA_gdg1, DA_gdg2 As SqlDataAdapter
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False

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

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
        Me.Enabled = False
    End Sub
    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder
        btnSave = False
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
    End Sub

    'Public Sub cetak_click()
    '    GcMultiBKE.Refresh()
    '    PrintingSystem1.ResetProgressReflector()
    '    PrintableComponentLink1.ShowPreview()
    'End Sub

    Sub ReloadTable()
        Dim sqltgl As String = ""
        'If lookupBulanAwal.EditValue = vbNullString Then
        '    sqltgl = "1=0"
        '    'ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue = vbNullString Then
        '    '    sqltgl = " bke.tgl_trans > convert(date,'" & tglDari.Text & "',103)"
        '    'ElseIf tglDari.EditValue = vbNullString And tglsampai.EditValue <> vbNullString Then
        '    '    sqltgl = " bke.tgl_trans < convert(date,'" & tglsampai.Text & "',103)"
        '    'ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString Then
        '    '    sqltgl = " bke.tgl_trans between convert(date,'" & tglDari.Text & "',103) and convert(date,'" & tglsampai.Text & "',103)"
        '    'ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString Then
        '    '    sqltgl = sqltgl & "and gdo.blthn='" & lookupBulanAwal.EditValue & "'"
        'Else
        '    '    'jika tgl dari kosong,tgl akhir kosong maka
        '    sqltgl = sqltgl & " blthn='" & lookupBulanAwal.EditValue & "'"
        'End If

        If Not ds.Tables("_mgdo") Is Nothing Then ds.Tables("_mgdo").Clear()
        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select *,0 as nomer from tabung WHERE SUBSTRING(NO_TABUNGAN,1,3)='TRL' ", sqlconn))
        '                                                           " p.Nama_Pegawai as Last_Created_By, isnull(bke.cetak_ke,0) cetak_ke, bke.cetak_ulang, 0 as nomer, " & _
        '                                                           " bke.Last_Update_Date, " & _
        '                                                           " case when isnull(gdo.sudah_sj,0)=0 then 'NOT' else 'OK' end sudah_sj, " & _
        '                                                           " kdr.No_Polisi, spr.Nama_Sopir, krnt.Nama_Sopir as Nama_Kenek " & _
        '                                                           " from inv.dbo.inv_bke bke " & _
        '                                                           " left join INV.dbo.INV_GUDANG_OUT as gdo on bke.no_trans = gdo.no_trans " & _
        '                                                           " inner join prod.dbo.PROD_rcn_krm_m as krm on bke.no_ref = krm.no_trans " & _
        '                                                           " left join sif.dbo.sif_kendaraan as kdr on kdr.kode_kendaraan = krm.kd_kendaraan " & _
        '                                                           " left join sif.dbo.sif_sopir as spr on spr.kode_sopir = krm.kd_sopir " & _
        '                                                           " left join sif.dbo.sif_sopir as krnt on krnt.kode_sopir = krm.kd_kenek " & _
        '                                                           " left join sif.dbo.muser as m on m.userid = bke.Last_Created_By " & _
        '                                                           " left join SIF.dbo.sif_pegawai as p on p.kode_pegawai = m.nip " & _
        '                                                           " where substring(bke.no_trans,12,3)='BKE' and " & sqltgl & "", sqlconn))
        da.Fill(ds, "_mgdo")

    End Sub
    Private Sub isinomer()
        Dim i As Int16 = 1
        For Each row As DataRow In ds.Tables("_mgdo").Rows
            row.Item("nomer") = i : i += 1
        Next
    End Sub

    Public Sub cetak_click()
        'Dim BTRANZ As SqlTransaction
        'BTRANZ = sqlconn.BeginTransaction("1")
        For Each rw As DataRow In ds.Tables("_mgdo").Select("cetak_ulang='Y'")
            Try
                Dim i As Int16 = New SqlCommand("update tabung set cetak_ulang='T', cetak_ke = isnull(cetak_ke,0) + 1, Last_Update = getDate() where NO_TABUNGAN='" & rw.Item("NO_TABUNGAN").ToString & "'", sqlconn).ExecuteNonQuery

                If i > 0 Then
                    'MsgBox(rw.Item("no_trans").ToString)
                    callReport(App_Path() & "\report\tab_relaberjangka.rpt", "", "no_tbg=" & rw.Item("NO_TABUNGAN") & "&nip=" & rw.Item("NASABAH_ID"), True, True)
                    'rw("stat") = "OK"
                Else
                    rw("stat_cetak") = "Dokumen Sudah Pernah Dicetak"
                End If
            Catch e As Exception
                rw("stat_cetak") = "Gagal Cetak : " & e.Message
                MsgBox("Gagal Cetak", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                Exit Sub
            End Try
        Next
        MsgBox("Data Telah Diproses", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Cetak")
        ds.Tables("_mgdo").Clear()
        'dsete.Tables("SOD").Clear()
    End Sub

    'Private Sub Loadblthn()
    '    If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
    '    DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM SIF_Periode_Buku", sqlconn))
    '    DALOOKUP.Fill(dsLookUp, "LookPeriode")
    '    lookupBulanAwal.Properties.DataSource = dsLookUp.Tables("LookPeriode")
    '    lookupBulanAwal.Properties.DisplayMember = "nama"
    '    lookupBulanAwal.Properties.ValueMember = "thnbln"

    'End Sub

    Private Sub MultiCetak_TRL_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        ReloadTable()
        GcMultiBKE.DataSource = ds.Tables("_mgdo")
        'GvMultiBKE.BestFitColumns()


        prn = getParent(Me)


        DALOOKUP = New SqlDataAdapter(New SqlCommand("select nasabah_id,Nama from anggota", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup2")
        LookupNama.DataSource = ds_cari.Tables("_lookup2")
        LookupNama.ValueMember = "nasabah_id"
        LookupNama.DisplayMember = "Nama"
        'btnSave = False
        'btnCancel = False
        'btnDelete = False
        'btnEdit = False
        'btnadd = False
        'Loadblthn()
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
    End Sub

    Private Sub Btn_pilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_pilih.Click
        btn_deselect.Enabled = True
        Btn_pilih.Enabled = False
        For Each klik As DataRow In ds.Tables("_mgdo").Rows
            klik.Item("cetak_ulang") = "Y"
        Next
    End Sub

    Private Sub btn_deselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_deselect.Click
        btn_deselect.Enabled = False
        Btn_pilih.Enabled = True
        For Each klik As DataRow In ds.Tables("_mgdo").Rows
            klik.Item("cetak_ulang") = "T"
        Next
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        frmMain.btnCetak.Enabled = True
        ReloadTable()
        isinomer()
    End Sub

    Private Sub btnprin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprin.Click
        'If GvMultiBKE.Columns("nilai").SummaryItem.SummaryValue = 0 Then
        '    MsgBox("Belum ada data yg dipilih utk di cetak")
        '    Exit Sub
        'Else
        '    cetak_click()
        'End If
        cetak_click()
    End Sub
End Class