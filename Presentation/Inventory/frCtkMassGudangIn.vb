'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================
'Imports CrystalDecisions.CrystalReports.Engine
'Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Windows.Forms
Imports DevExpress.XtraPrintingLinks


Public Class frCtkMassGudangIn
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Dim ds, ds_cari2, ds_cari, ds_cari1, dsLookUp As New DataSet
    Dim da, DALOOKUP1, DALOOKUP, DALOOKUP2 As SqlDataAdapter
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Dim prn As frmMain
    Private STATE As String
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
    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder
        btnSave = False
        btnEdit = False
        btnadd = False
        btnCancel = False
        setStatus()
    End Sub
    Private Sub formate_yayak()
        thisThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        'GvMonQC.Columns("qty_order").SummaryItem.DisplayFormat = DevExpress.Utils.FormatType.Numeric
        'GvMonQC.Columns("qty_order").SummaryItem.DisplayFormat
        GvPrintQC.Columns("qty_qc_pass").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvPrintQC.Columns("qty_qc_pass").DisplayFormat.FormatString = "n2"
        GvPrintQC.Columns("qty_order").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvPrintQC.Columns("qty_order").DisplayFormat.FormatString = "n2"
        GvPrintQC.Columns("hold").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvPrintQC.Columns("hold").DisplayFormat.FormatString = "n2"
        GvPrintQC.Columns("qty_qc_unpass").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvPrintQC.Columns("qty_qc_unpass").DisplayFormat.FormatString = "n2"
        'GvMonQC.Columns("qty_sisa").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'GvMonQC.Columns("qty_sisa").DisplayFormat.FormatString = "n2"
    End Sub


    Private Sub frCetakUlangQC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        ReloadTable()
        formate_yayak()

        GcPrintQC.DataSource = ds.Tables("_MonQC")

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        DALOOKUP2.Fill(ds_cari2, "_lookup2")
        LookupBarang.DataSource = ds_cari2.Tables("_lookup2")
        LookupBarang.ValueMember = "Kode_Barang"
        LookupBarang.DisplayMember = "Nama_Barang"

        'DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select distinct(blthn) from INV.dbo.INV_QC", sqlconn))
        'DALOOKUP2.Fill(ds_cari2, "_lookup1")
        'LookupBlthn.Properties.DataSource = ds_cari2.Tables("_lookup1")

        'Loadblthn()
    End Sub

    Sub ReloadTable()
        Dim sqltgl As String = ""
        If tglDari.EditValue = vbNullString And tglsampai.EditValue = vbNullString Then
            sqltgl = "1=0"
        ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue = vbNullString Then
            sqltgl = " tgl_trans > convert(date,'" & tglDari.Text & "',103)"
        ElseIf tglDari.EditValue = vbNullString And tglsampai.EditValue <> vbNullString Then
            sqltgl = " tgl_trans < convert(date,'" & tglsampai.Text & "',103)"
        ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString Then
            sqltgl = " tgl_trans between convert(date,'" & tglDari.Text & "',103) and convert(date,'" & tglsampai.Text & "',103)"
            'ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString And lookupBulanAwal.EditValue <> vbNullString Then
            '   sqltgl = sqltgl & "and qc.blthn='" & lookupBulanAwal.EditValue & "'"
            'Else      '  LookupBlthn.EditValue <> vbNullString Then
            '   sqltgl = "qc.blthn='" & lookupBulanAwal.EditValue & "'"
        End If


        If Not ds.Tables("_MonQC") Is Nothing Then ds.Tables("_MonQC").Clear()
        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,0 as nomer,'' as stat, isnull((select nama_jenis from INV.dbo.JENIS_BRG_MASUK where kode= SUBSTRING(no_qc,12,2)),'') nama_qc, isnull(SUBSTRING(no_qc,12,2),'') qc from INV.dbo.INV_GUDANG_IN where " & sqltgl & "", sqlconn))
        da.Fill(ds, "_MonQC")
        GcPrintQC.DataSource = ds.Tables("_MonQC")

        

    End Sub

    Private Sub isinomer()
        Dim i As Int16 = 1
        For Each row As DataRow In ds.Tables("_MonQC").Rows
            row.Item("nomer") = i : i += 1
        Next
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        ReloadTable()
        isinomer()
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        tglDari.EditValue = vbNullString
        tglsampai.EditValue = vbNullString
    End Sub

    Public Sub cetak_click()
        Dim spv As String
        For Each rw As DataRow In ds.Tables("_MonQC").Select("cetak_ulang='Y'")
            Try
                Dim i As Int16 = New SqlCommand("update INV.dbo.INV_GUDANG_IN set cetak_ulang='T', cetak_ke = cetak_ke + 1 where no_trans='" & rw.Item("no_trans").ToString & "'", sqlconn).ExecuteNonQuery
                If i > 0 Then
                    'callReport(App_Path() & "\report\BME.rpt", "", "notrans=" & rw.Item("no_trans"), True, False)
                    If rw("qc") = "QC" Then
                        spv = "SPV Logistik"
                    ElseIf rw("qc") = "QJ" Then
                        spv = "SPV Logistik"
                    ElseIf rw("qc") = "RT" Then
                        spv = "SPV Finance"
                    Else
                        spv = "SPV Logistik"
                    End If
                    If rw("nama_qc") = "" Then rw("nama_qc") = "Pembelian"
                    callReport(App_Path() & "\report\BME.rpt", "", "notrans=" & rw.Item("no_trans") & "&jenisBM=" & rw("nama_qc") & "&spv=" & spv, True, True)
                    rw("stat") = "OK"
                Else
                    rw("stat") = "Dokumen SP Sudah Pernah Dicetak"
                End If
            Catch e As Exception
                rw("status") = "Gagal Cetak : " & e.Message
                MsgBox("Gagal Cetak", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                Exit Sub
            End Try
        Next
        MsgBox("Data Telah Diproses", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Cetak")
        ds.Tables("_MonQC").Clear()
        'dsete.Tables("SOD").Clear()
    End Sub
End Class
