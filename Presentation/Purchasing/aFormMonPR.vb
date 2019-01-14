Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class aFormMonPR
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim dsLookUp, dsPR As New DataSet
    Dim daLookUp, daPR As SqlDataAdapter
    Dim isValid As Boolean

    Private Sub aFormMonPR_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        loadLookUp()
        dtpAwal.EditValue = getTanggal()
        dtpAkhir.EditValue = getTanggal()
    End Sub

    Private Sub loadLookUp()
        If Not dsLookUp.Tables("LookBarang") Is Nothing Then dsLookUp.Tables("LookBarang").Clear()
        If Not dsLookUp.Tables("LookSupplier") Is Nothing Then dsLookUp.Tables("LookSupplier").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT Nama_Barang, Kode_Barang FROM SIF.dbo.SIF_Barang", sqlconn))
        daLookUp.Fill(dsLookUp, "LookBarang")
        LOVbarang.DataSource = dsLookUp.Tables("LookBarang")
        LOVbarang.DisplayMember = "Nama_Barang"
        LOVbarang.ValueMember = "Kode_Barang"

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT Nama_Supplier, Kode_Supplier FROM SIF.dbo.SIF_Supplier", sqlconn))
        daLookUp.Fill(dsLookUp, "LookSupplier")
        LOVSupplier.DataSource = dsLookUp.Tables("LookSupplier")
        LOVSupplier.DisplayMember = "Nama_Supplier"
        LOVSupplier.ValueMember = "Kode_Supplier"
    End Sub

    Private Sub loadGrid(ByVal awal As String, ByVal akhir As String)
        awal = dtpAwal.EditValue
        akhir = dtpAkhir.EditValue
        If Not dsPR.Tables("PR") Is Nothing Then dsPR.Tables("PR").Clear()
        'daPR = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY a.no_pr) as 'nomor', a.no_pr, a.tgl_pr, a.kd_stok, a.satuan, a.qty_order, a.qty_pr, b.no_csp, b.kd_supp_pilih FROM PURC.dbo.PURC_PR_D a RIGHT OUTER JOIN PURC.dbo.PURC_CHOICE_SUPP b ON (a.no_pr = b.no_pr) WHERE a.kd_stok = b.kd_stok AND tgl_pr BETWEEN CONVERT(DATE,'" & awal & "',103) AND CONVERT(DATE,'" & akhir & "',103)", sqlconn))
        daPR = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY a.no_pr) as 'nomor', " & _
                                                 "a.no_pr, a.tgl_pr, a.kd_stok, a.satuan, a.qty_order, " & _
                                                 "CASE " & _
                                                 "when (select COUNT(no_pr) from PURC.dbo.PURC_PO x where x.no_pr= a.no_pr) > 0 then 'Sudah PO' else 'Belum PO' end as Status_PO, " & _
                                                 "(select COUNT(no_pr) from PURC.dbo.PURC_PO x where x.no_pr= a.no_pr) as jml, " & _
                                                 "a.qty_pr, b.no_csp, b.kd_supp_pilih FROM PURC.dbo.PURC_PR_D a " & _
                                                 "RIGHT OUTER JOIN PURC.dbo.PURC_CHOICE_SUPP b ON (a.no_pr = b.no_pr) " & _
                                                 "WHERE(a.kd_stok = b.kd_stok) " & _
                                                 "AND tgl_pr BETWEEN CONVERT(DATE,'" & awal & "',103) " & _
                                                 "AND CONVERT(DATE,'" & akhir & "',103)", sqlconn))
        daPR.Fill(dsPR, "PR")
        gcPR.DataSource = dsPR.Tables("PR")
    End Sub

    Private Sub cek()
        isValid = True
        If dtpAwal.EditValue = vbNullString Then
            err.SetError(dtpAwal, "Tanggal filter awal belum dipilih.")
            err.SetIconAlignment(dtpAwal, ErrorIconAlignment.MiddleRight)
            isValid = False
        Else
            err.SetError(dtpAwal, "")
            isValid = True
        End If
        If dtpAkhir.EditValue = vbNullString Then
            err.SetError(dtpAkhir, "Tanggal filter akhir belum dipilih.")
            err.SetIconAlignment(dtpAkhir, ErrorIconAlignment.MiddleRight)
            isValid = False
        Else
            err.SetError(dtpAkhir, "")
            isValid = True
        End If
        If dtpAwal.EditValue > dtpAkhir.EditValue Then
            err.SetError(dtpAwal, "Filter Tanggal awal melebihi tanggal akhir.")
            err.SetIconAlignment(dtpAwal, ErrorIconAlignment.MiddleRight)
            isValid = False
        Else
            err.SetError(dtpAwal, "")
            isValid = True
        End If
        If dtpAkhir.EditValue < dtpAwal.EditValue Then
            err.SetError(dtpAkhir, "Filter Tanggal akhir kurang dari tanggal awal.")
            err.SetIconAlignment(dtpAkhir, ErrorIconAlignment.MiddleRight)
            isValid = False
        Else
            err.SetError(dtpAkhir, "")
            isValid = True
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        cek()
        If isValid = True Then
            loadGrid(dtpAwal.EditValue, dtpAkhir.EditValue)
        End If
    End Sub

    Public Sub cetak_click()
        gcPR.Refresh()
        gcPR.ShowPrintPreview()
    End Sub

    Private Sub LabelControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class