Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class frmMonSP
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
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
    Sub reload_table()
        Dim sql As String = ""
        Dim kolom As String = ""
        If tglDari.Text = "" Then
            If tglsampai.Text <> "" Then
                sql = " and  tgl_inv < convert(date, '" & tglsampai.EditValue & "', 103)"
            End If
        Else
            If tglsampai.Text <> "" Then
                sql = " and tgl_inv  between convert(date, '" & tglDari.EditValue & "', 103) and  convert(date, '" & tglsampai.EditValue & "', 103)"
            Else
                sql = " and tgl_inv  > convert(date, '" & tglDari.EditValue & "', 103)"
            End If
        End If
        If Not dsete.Tables("sp") Is Nothing Then dsete.Tables("sp").Clear()

        For Each itm As CheckedListBoxItem In cmdGroup.Properties.Items
            GV.Columns(itm.Value).visible = False
            GV.Columns(itm.Value).UnGroup()
            If itm.CheckState = CheckState.Checked Then
                kolom &= "[" & itm.Value & "],"
                GV.Columns(itm.Value).visible = True
            End If
        Next
        If kolom = "" Then Exit Sub
        kolom = kolom.Substring(0, Len(kolom) - 1)
        'dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select Nama_Barang, sum(Qty*(harga-potongan)) Total, Merk_Kain, Warna,Nama_Ukuran, Nama_Tipe, Nama_Merk, Nama_Sub_Tipe, Nama_Jenis, Nama_Sales, Nama_Area, Nama_Wilayah, Thn, Thnbln from sales.dbo.vsod_rep as s where ISNULL(s.[set],0)=0 " & sql & " group by Nama_Barang,  Merk_Kain, Warna,Nama_Ukuran, Nama_Tipe, Nama_Merk, Nama_Sub_Tipe, Nama_Jenis, Nama_Sales, Nama_Area, Nama_Wilayah, Thn, Thnbln ", sqlconn))
        Dim cmd As SqlCommand
        cmd = New SqlClient.SqlCommand(" select  sum(Qty) Qty, sum(jml_rp_trans-jml_ppn) Total, " & kolom & " from sales.dbo.VSOD_OMZET as s where  tipe_trans not in  ('" & ServiceSpringUmum & "', '" & ServiceSponUmum & "') and  kd_customer <> 'INTERNAL'" & sql & " group by " & kolom, sqlconn)
        cmd.CommandTimeout = 0
        dadbe = New SqlClient.SqlDataAdapter(cmd)
        dadbe.Fill(dsete, "sp")
        GC.DataSource = dsete.Tables("sp")
    End Sub
    Private Sub frmMonSP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        reload_table()
        GC.DataSource = dsete.Tables("sp")
       
        dadbe = New SqlDataAdapter(New SqlCommand("select * from sif.dbo.sif_area", sqlconn))
        dadbe.Fill(dsete, "area")
        dadbe = New SqlDataAdapter(New SqlCommand("select * from sif.dbo.sif_wilayah", sqlconn))
        dadbe.Fill(dsete, "wilayah")
        prn = frmMain
        setStatus()
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        reload_table()
    End Sub

    Public Sub add_click()

    End Sub
    Public Sub cetak_click()
        print_gc(GC, "Laporan Omzet Penjualan" & vbCrLf & "Per-" & cmdGroup.Text & vbCrLf & "Periode " & tglDari.Text & " - " & tglsampai.Text)
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        cmdGroup.EditValue = vbNullString
        tglDari.EditValue = vbNullString
        tglsampai.EditValue = vbNullString
    End Sub

End Class