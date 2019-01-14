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


Public Class frmMnHold
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Dim ds, ds_cari2, ds_cari, ds_cari1, dsLookUp As New DataSet
    Dim da, DALOOKUP1, DALOOKUP, DALOOKUP2 As SqlDataAdapter
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
    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder
        btnSave = False
        btnEdit = False
        btnadd = False
        btnCancel = False
        setStatus()
    End Sub
    Public Sub cetak_click()
        GcMonQC.Refresh()
        PrintingSystem1.ResetProgressReflector()
        PrintableComponentLink1.ShowPreview()
    End Sub
    Sub ReloadTable()
        Dim sqltgl As String = ""
        If tglDari.EditValue = vbNullString And tglsampai.EditValue = vbNullString Then
            sqltgl = "1=0"
        ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue = vbNullString Then
            sqltgl = " qc.tgl_trans > convert(date,'" & tglDari.Text & "',103)"
        ElseIf tglDari.EditValue = vbNullString And tglsampai.EditValue <> vbNullString Then
            sqltgl = " qc.tgl_trans < convert(date,'" & tglsampai.Text & "',103)"
        ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString Then
            sqltgl = " qc.tgl_trans between convert(date,'" & tglDari.Text & "',103) and convert(date,'" & tglsampai.Text & "',103)"
            'ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString And lookupBulanAwal.EditValue <> vbNullString Then
            'sqltgl = sqltgl & "and qc.blthn='" & lookupBulanAwal.EditValue & "'"
            'Else      '   LookupBlthn.EditValue <> vbNullString Then
            '   sqltgl = "qc.blthn='" & lookupBulanAwal.EditValue & "'"
        End If


        If Not ds.Tables("_MonQC") Is Nothing Then ds.Tables("_MonQC").Clear()
        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select pod.no_po,pod.qty as qty_po,qc.qty_qc_pass,qcm.sj_supplier,qc.status_hold,qc.tgl_trans,qc.no_trans,qc.qty_order,qc.no_ref,qc.kd_satuan,qc.kd_stok,qc.Last_Created_By,brg.Nama_Barang,brg.spek_brg,isnull(qc.hold,0) as hold,isnull(qc.hold_history,0) as hold_history,isnull(qc.qty_release,0) as qty_release,isnull(qc.qty_reject_hold,0) as qty_reject_hold,qc.tgl_act_hold,isnull(qc.rp_trans,0) as rp_trans,isnull(qcm.jml_rp_trans,0) as jml_rp_trans, 0 as nomer from INV.dbo.INV_QC as qc INNER JOIN INV.dbo.INV_QC_M as qcm on qc.no_trans=qcm.no_trans INNER JOIN SIF.dbo.SIF_Barang as brg on qc.kd_stok= brg.Kode_Barang inner join PURC.dbo.PURC_PO_D as pod on qc.no_ref=pod.no_po where qc.status_hold<>'' and  " & sqltgl & "", sqlconn))
        da.Fill(ds, "_MonQC")
    End Sub

    Private Sub isinomer()
        Dim i As Int16 = 1
        For Each row As DataRow In ds.Tables("_MonQC").Rows
            row.Item("nomer") = i : i += 1
        Next
    End Sub

    Private Sub formate_yayak()
        thisThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        GvMonQC.Columns("hold").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvMonQC.Columns("hold").DisplayFormat.FormatString = "n3"
        GvMonQC.Columns("qty_release").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvMonQC.Columns("qty_release").DisplayFormat.FormatString = "n3"
        GvMonQC.Columns("hold_history").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvMonQC.Columns("hold_history").DisplayFormat.FormatString = "n3"
        GvMonQC.Columns("qty_reject_hold").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvMonQC.Columns("qty_reject_hold").DisplayFormat.FormatString = "n3"
    End Sub

    Private Sub frmMnHold_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        ReloadTable()
        formate_yayak()
        'dt_blthn.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime

        GcMonQC.DataSource = ds.Tables("_MonQC")

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

    'Private Sub Loadblthn()
    '    If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
    '    DALOOKUP2 = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
    '    DALOOKUP2.Fill(dsLookUp, "LookPeriode")
    '    lookupBulanAwal.Properties.DataSource = dsLookUp.Tables("LookPeriode")
    '    lookupBulanAwal.Properties.DisplayMember = "nama"
    '    lookupBulanAwal.Properties.ValueMember = "thnbln"

    'End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        ReloadTable()
        isinomer()
    End Sub

    Private Sub btnprin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprin.Click
        GcMonQC.Refresh()
        PrintingSystem1.ResetProgressReflector()
        PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        'lookupBulanAwal.EditValue = vbNullString
        tglDari.EditValue = vbNullString
        tglsampai.EditValue = vbNullString
    End Sub

End Class