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
Public Class frMnBatal
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

    Sub ReloadTable()
        Dim sqltgl As String = ""
        If tglDari.EditValue = vbNullString And tglsampai.EditValue = vbNullString Then
            sqltgl = "1=0"
        ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue = vbNullString Then
            sqltgl = " tgl_trans >= convert(date,'" & tglDari.Text & "',103)"
        ElseIf tglDari.EditValue = vbNullString And tglsampai.EditValue <> vbNullString Then
            sqltgl = " tgl_trans <= convert(date,'" & tglsampai.Text & "',103)"
        ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString Then
            sqltgl = " tgl_trans between convert(date,'" & tglDari.Text & "',103) and convert(date,'" & tglsampai.Text & "',103)"
            'ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString And lookupBulanAwal.EditValue <> vbNullString Then
            'sqltgl = sqltgl & "and qc.blthn='" & lookupBulanAwal.EditValue & "'"
            'Else      '   LookupBlthn.EditValue <> vbNullString Then
            'sqltgl = "qc.blthn='" & lookupBulanAwal.EditValue & "'"
        End If


        If Not ds.Tables("_MonQC") Is Nothing Then ds.Tables("_MonQC").Clear()
        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT *,0 as nomer from INV.dbo.INV_BATAL where " & sqltgl & "", sqlconn))
        da.Fill(ds, "_MonQC")
    End Sub

    Private Sub isinomer()
        Dim i As Int16 = 1
        For Each row As DataRow In ds.Tables("_MonQC").Rows
            row.Item("nomer") = i : i += 1
        Next
    End Sub

    Private Sub frMnBatal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        ReloadTable()
        'formate_yayak()
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

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        'lookupBulanAwal.EditValue = vbNullString
        tglDari.EditValue = vbNullString
        tglsampai.EditValue = vbNullString
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        ReloadTable()
        isinomer()
    End Sub
End Class