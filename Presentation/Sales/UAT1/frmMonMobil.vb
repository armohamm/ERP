Imports System.Data.SqlClient
Public Class frmMonMobil
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
    Public Sub add_click()

    End Sub

    Private Sub frmMonMobil_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        Dim sql_kendaraan As String = "select [Kode_Kendaraan] ,[Nama_Kendaraan], [No_Polisi] from [SIF].[dbo].[SIF_Kendaraan]"
        Dim sql_data As String = "select [no_sj], [Tgl_kirim] ,[Jam_kirim] ,[Tgl_terima],[Jam_terima],[Tgl_balik] ,[Jam_balik] from [SALES].[dbo].[SALES_SJ] where 1=0"
        dadbe = New SqlDataAdapter(sql_kendaraan, sqlconn)
        dadbe.Fill(dsete, "KENDARAAN")
        'dadbe = New SqlDataAdapter(sql_data, sqlconn)
        'dadbe.Fill(dsete, "DATA")
        'GC.DataSource = dsete.Tables("DATA")
        cmbNopol.Properties.DataSource = dsete.Tables("KENDARAAN")
        'prn = frmMain
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        'setStatus()
    End Sub

    Private Sub cmbNopol_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNopol.EditValueChanged
        If cmbNopol.Text <> "" Then
            lblKendaraan.Text = cmbNopol.GetSelectedDataRow.item("Nama_Kendaraan")
        Else
            lblKendaraan.Text = ""
        End If
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click

    End Sub
End Class