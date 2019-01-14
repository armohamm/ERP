Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class frmMonSJ
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
    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        Dim sql As String = ""
        If tglDari.Text = "" Then
            If tglsampai.Text <> "" Then
                sql = " and  tglsj <= convert(date, '" & tglsampai.EditValue & "', 103)"
            End If
        Else
            If tglsampai.Text <> "" Then
                sql = " and tglsj  between convert(date, '" & tglDari.EditValue & "', 103) and  convert(date, '" & tglsampai.EditValue & "', 103)"
            Else
                sql = " and tglsj  >= convert(date, '" & tglDari.EditValue & "', 103)"
            End If
        End If
        If Not dsete.Tables("sjd") Is Nothing Then dsete.Tables("sjd").Clear()
        If Not dsete.Tables("sj") Is Nothing Then dsete.Tables("sj").Clear()

        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sales.dbo.sales_sj where 1=1 " & sql, sqlconn))
        dadbe.Fill(dsete, "sj")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Barang, Kd_satuan, Qty_kirim, Qty_balik, Qty_batal,Keterangan, no_sj from sales.dbo.v_sjd d where exists (select 1 from sales.dbo.sales_sj a  where a.no_sj=d.no_sj " & sql & ")", sqlconn))
        dadbe.Fill(dsete, "sjd")
        If rl Is Nothing Then
            rl = dsete.Relations.Add("Detail", dsete.Tables("sj").Columns("no_sj"), dsete.Tables("sjd").Columns("no_sj"), False)
            rl.Nested = True
            GC.LevelTree.Nodes.Add("Detail", GVD)
            GC.DataSource = dsete.Tables("sj")
        End If
    End Sub

    Private Sub frmMonSJ_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        dadbe = New SqlClient.SqlDataAdapter("select kode_kendaraan, no_polisi from sif.dbo.sif_kendaraan", sqlconn)
        dadbe.Fill(dsete, "nopol")
        repNopol.DataSource = dsete.Tables("nopol")

        dadbe = New SqlClient.SqlDataAdapter("select Kode_Sopir, Nama_Sopir from sif.dbo.sif_sopir", sqlconn)
        dadbe.Fill(dsete, "sopir")
        repSopir.DataSource = dsete.Tables("sopir")
        prn = frmMain
        setStatus()
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
    End Sub

    Private Sub tglDari_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tglDari.EditValueChanged
        tglsampai.Properties.MinValue = tglDari.EditValue
    End Sub
    Public Sub cetak_click()
        print_gc(GC, "Laporan Surat Jalan" & vbCrLf & "Periode : " & tglDari.Text & " - " & tglsampai.Text, False)
    End Sub
End Class