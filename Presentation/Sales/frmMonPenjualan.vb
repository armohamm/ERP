Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports Microsoft
Imports System.Windows.Forms
Public Class frmMonPenjualan
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
    Private Sub frmMonPenjualan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from [SALES].[dbo].[VSO_REP]", sqlconn))
        dadbe.Fill(dsete, "SO")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Departemen, Nama_Departemen from sif.dbo.SIF_Departemen", sqlconn))
        dadbe.Fill(dsete, "dep")
        repDep.DataSource = dsete.Tables("dep")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select [tipe_trans] ,[tipe_desc] from sif.dbo.SIF_TIPE_TRANS", sqlconn))
        dadbe.Fill(dsete, "trans")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select b.Kd_Satuan, b.Nama_Barang, b.Kode_Barang from SIF.dbo.SIF_Barang as b where b.kd_jns_persd=1", sqlconn))
        dadbe.Fill(dsete, "VBARANG")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Unit as Kd_Satuan, NAMA as Nama_Barang, KD_SET as Kode_Barang from SIF.dbo.SIF_SET_PRODUCT", sqlconn))
        dadbe.Fill(dsete, "VBARANG")
        cmdBarang.Properties.DataSource = dsete.Tables("VBARANG")
        repTrans.DataSource = dsete.Tables("trans")
        GC.DataSource = dsete.Tables("SO")
        prn = frmMain
        setStatus()

        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        For Each item As Object In GV.Columns
            Dim ck As New DevExpress.XtraEditors.Controls.CheckedListBoxItem
            ck.CheckState = CheckState.Unchecked
            ck.Description = item.Caption
            ck.Value = item.FieldName
            cmdGroup.Properties.Items.Add(ck)
        Next
        Departement.Group()
    End Sub
    Private Sub reloadTable()
        Dim sql As String
        If tglDari.Text = "" Then
            If tglsampai.Text <> "" Then
                sql = " where convert(varchar, tgl_sp, 112) < " & tglsampai.Text
            End If
        Else

            If tglsampai.Text <> "" Then
                sql = " where convert(varchar, tgl_sp, 112)  between '" & tglDari.Text & "' and '" & tglsampai.Text & "' "
            Else
                sql = " where convert(varchar, tgl_sp, 112)  > " & tglDari.Text
            End If
        End If
        'If cmdBarang.Text <> "" Then
        ' If tglsampai.Text <> "" Then
        ' sql = sql & " and Kode_Barang = '" & cmdBarang.EditValue & "'"
        ' Else
        ' sql = " where Kode_Barang = '" & cmdBarang.EditValue & "'"
        ' End If
        'End If
        If Not dsete.Tables("SO") Is Nothing Then dsete.Tables("SO").Clear()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from [SALES].[dbo].[VSO_REP] " & sql, sqlconn))
        dadbe.Fill(dsete, "SO")
    End Sub
    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        reloadTable()
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        cmdBarang.EditValue = vbNullString
        tglDari.EditValue = vbNullString
        tglsampai.EditValue = vbNullString
    End Sub

    Public Sub add_click()

    End Sub

    Private Sub cmdGroup_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdGroup.EditValueChanged
        For Each item As Object In cmdGroup.Properties.Items
            If item.CheckState = CheckState.Checked Then
                GV.Columns(item.Value).Group()
            Else
                GV.Columns(item.Value).unGroup()
            End If
        Next
    End Sub
End Class