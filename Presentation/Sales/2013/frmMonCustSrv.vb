Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class frmMonCustSrv
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Dim rl As DataRelation
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = True
        End With
    End Sub
    Public Sub add_click()

    End Sub
    Private Sub frmMonSJ_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = frmMain
        setStatus()
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        loadBulan()
    End Sub

    Public Sub cetak_click()
        print_gc(GC, "Laporan Customer Service " & vbCrLf, False)
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        Dim sql As String = ""
        'If lckBlnAwal.Text = "" Then
        '    If lckBlnAkhir.Text <> "" Then
        '        sql = " and  tgl_lahir_umum <= convert(date, '" & lckBlnAkhir.EditValue & "', 103)"
        '    End If
        'Else
        '    If lckBlnAkhir.Text <> "" Then
        '        sql = " and tgl_lahir_umum  between convert(date, '" & lckBlnAwal.EditValue & "', 103) and  convert(date, '" & lckBlnAkhir.EditValue & "', 103)"
        '    Else
        '        sql = " and tgl_lahir_umum  >= convert(date, '" & lckBlnAwal.EditValue & "', 103)"
        '    End If
        'End If

        If Not lckBlnAwal.EditValue = vbNullString Then
            sql += " and MONTH(tgl_lahir_umum) <= " & lckBlnAkhir.EditValue
        End If

        If Not lckBlnAkhir.EditValue = vbNullString Then
            sql += " and MONTH(tgl_lahir_umum) >= " & lckBlnAwal.EditValue
        End If

        If Not dsete.Tables("sj") Is Nothing Then dsete.Tables("sj").Clear()

        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_sp, Nama_pnrm, Alamat_Tarik, KOTA, No_Telp, tgl_lahir_umum from sales.dbo.sales_so where Tipe_trans = 'JPJ-KPT-05' and Kd_Customer = 'UMUM'" & sql & " ORDER BY Nama_pnrm", sqlconn))
        dadbe.Fill(dsete, "sj")
        GC.DataSource = dsete.Tables("sj")
        GV.BestFitColumns()
    End Sub

    Private Sub loadBulan()
        If Not dsete.Tables("bulan") Is Nothing Then dsete.Tables("bulan").Clear()

        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT DISTINCT bln_buku, nama_bulan FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        dadbe.Fill(dsete, "bulan")
        lckBlnAwal.Properties.DataSource = dsete.Tables("bulan")
        lckBlnAwal.Properties.ValueMember = "bln_buku"
        lckBlnAwal.Properties.DisplayMember = "nama_bulan"
        lckBlnAkhir.Properties.DataSource = dsete.Tables("bulan")
        lckBlnAkhir.Properties.ValueMember = "bln_buku"
        lckBlnAkhir.Properties.DisplayMember = "nama_bulan"
    End Sub
End Class