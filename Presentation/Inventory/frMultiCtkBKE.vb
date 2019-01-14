Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraPrintingLinks

Public Class frMultiCtkBKE
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
        btnSave = True
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
        If tglDari.EditValue = vbNullString And tglsampai.EditValue = vbNullString Then
            sqltgl = "1=0"
        ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue = vbNullString Then
            sqltgl = " bke.tgl_trans > convert(date,'" & tglDari.Text & "',103)"
        ElseIf tglDari.EditValue = vbNullString And tglsampai.EditValue <> vbNullString Then
            sqltgl = " bke.tgl_trans < convert(date,'" & tglsampai.Text & "',103)"
        ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString Then
            sqltgl = " bke.tgl_trans between convert(date,'" & tglDari.Text & "',103) and convert(date,'" & tglsampai.Text & "',103)"
            'ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString Then
            '    sqltgl = sqltgl & "and gdo.blthn='" & lookupBulanAwal.EditValue & "'"
            'Else
            '    'jika tgl dari kosong,tgl akhir kosong maka
            '    sqltgl = sqltgl & " gdo.blthn='" & lookupBulanAwal.EditValue & "'"
        End If

        If Not ds.Tables("_mgdo") Is Nothing Then ds.Tables("_mgdo").Clear()
        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select bke.no_trans, bke.no_ref, bke.tgl_trans, " & _
                                                                   " p.Nama_Pegawai as Last_Created_By, isnull(bke.cetak_ke,0) cetak_ke, bke.cetak_ulang, 0 as nomer, " & _
                                                                   " bke.Last_Update_Date, " & _
                                                                   " case when isnull(gdo.sudah_sj,0)=0 then 'NOT' else 'OK' end sudah_sj, " & _
                                                                   " kdr.No_Polisi, spr.Nama_Sopir, krnt.Nama_Sopir as Nama_Kenek " & _
                                                                   " from inv.dbo.inv_bke bke " & _
                                                                   " left join INV.dbo.INV_GUDANG_OUT as gdo on bke.no_trans = gdo.no_trans " & _
                                                                   " inner join prod.dbo.PROD_rcn_krm_m as krm on bke.no_ref = krm.no_trans " & _
                                                                   " left join sif.dbo.sif_kendaraan as kdr on kdr.kode_kendaraan = krm.kd_kendaraan " & _
                                                                   " left join sif.dbo.sif_sopir as spr on spr.kode_sopir = krm.kd_sopir " & _
                                                                   " left join sif.dbo.sif_sopir as krnt on krnt.kode_sopir = krm.kd_kenek " & _
                                                                   " left join sif.dbo.muser as m on m.userid = bke.Last_Created_By " & _
                                                                   " left join SIF.dbo.sif_pegawai as p on p.kode_pegawai = m.nip " & _
                                                                   " where substring(bke.no_trans,12,3)='BKE' and " & sqltgl & "", sqlconn))
        da.Fill(ds, "_mgdo")

    End Sub


    Private Sub frMultiCtkBKE_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        ReloadTable()
        GcMultiBKE.DataSource = ds.Tables("_mgdo")
        'GvMultiBKE.BestFitColumns()


        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kd_Jns_Persd,Nama_Persediaan from SIF.dbo.SIF_Jns_Persediaan", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup2")
        LookupBarang.DataSource = ds_cari.Tables("_lookup2")
        LookupBarang.ValueMember = "Kd_Jns_Persd"
        LookupBarang.DisplayMember = "Nama_Persediaan"
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = False
        btnadd = False

        
        'Loadblthn()
    End Sub

    Private Sub isinomer()
        Dim i As Int16 = 1
        For Each row As DataRow In ds.Tables("_mgdo").Rows
            row.Item("nomer") = i : i += 1
        Next
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        frmMain.btnCetak.Enabled = True
        ReloadTable()
        isinomer()

    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        'lookupBulanAwal.EditValue = vbNullString
        tglDari.EditValue = vbNullString
        tglsampai.EditValue = vbNullString

    End Sub
    Public Sub cetak_click()
        'Dim BTRANZ As SqlTransaction
        'BTRANZ = sqlconn.BeginTransaction("1")
        For Each rw As DataRow In ds.Tables("_mgdo").Select("cetak_ulang='Y'")
            Try
                Dim i As Int16 = New SqlCommand("update INV.dbo.INV_BKE set cetak_ulang='T', cetak_ke = isnull(cetak_ke,0) + 1, Last_Update_Date = getDate() where no_trans='" & rw.Item("no_trans").ToString & "'", sqlconn).ExecuteNonQuery

                If i > 0 Then
                    'MsgBox(rw.Item("no_trans").ToString)
                    callReport(App_Path() & "\report\BKE.rpt", "", "notrans=" & rw.Item("no_trans"), True, False)
                    'rw("stat") = "OK"
                Else
                    rw("stat") = "Dokumen Sudah Pernah Dicetak"
                End If
            Catch e As Exception
                rw("stat") = "Gagal Cetak : " & e.Message
                MsgBox("Gagal Cetak", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                Exit Sub
            End Try
        Next
        MsgBox("Data Telah Diproses", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Cetak")
        ds.Tables("_mgdo").Clear()
        'dsete.Tables("SOD").Clear()
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
End Class