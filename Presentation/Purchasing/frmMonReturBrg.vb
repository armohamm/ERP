Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports Microsoft
Imports System.Windows.Forms
Public Class frmMonReturBrg
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

    Private Sub reloadTable()
        Dim kolom As String = ""
        Dim sql As String
        If tglDari.Text = "" And tglsampai.Text <> "" Then
            sql = " where tanggal < convert(date,'" & tglsampai.EditValue & "',103) "

        Else
            sql = " where tanggal between convert(date,'" & tglDari.EditValue & "',103) and convert(date,'" & tglsampai.EditValue & "',103) " ' "
        End If


        If Not dsete.Tables("ReturBrg") Is Nothing Then dsete.Tables("ReturBrg").Clear()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,status from [PURC].[dbo].[V_monReturBrg] " & sql, sqlconn))
        dadbe.Fill(dsete, "ReturBrg")
        GC.DataSource = dsete.Tables("ReturBrg")

        For Each itm As CheckedListBoxItem In cmdGroup.Properties.Items
            If Not itm.Value = "qty_total" Then
                GV.Columns(itm.Value).visible = False
            End If
            If Not itm.Value = "total_rp" Then
                GV.Columns(itm.Value).visible = False
            End If
            GV.Columns(itm.Value).UnGroup()
            If itm.CheckState = CheckState.Checked Then
                kolom &= itm.Value & ","
                GV.Columns(itm.Value).visible = True
            End If
        Next
        If kolom = "" Then Exit Sub
        If Not dsete.Tables("ReturBrg") Is Nothing Then dsete.Tables("ReturBrg").Clear()
        kolom = kolom.Substring(0, Len(kolom) - 1)
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select sum(qty) as qty_total,sum(jml_rp_trans) as total_rp, " & kolom & " from PURC.dbo.V_monReturBrg as s " & sql & " group by " & kolom, sqlconn))
        dadbe.Fill(dsete, "ReturBrg")
        GC.DataSource = dsete.Tables("ReturBrg")
    End Sub
    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        reloadTable()
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        tglDari.EditValue = vbNullString
        tglsampai.EditValue = vbNullString
    End Sub

    Public Sub add_click()

    End Sub

    Private Sub cmdGroup_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        For Each item As Object In cmdGroup.Properties.Items
            If item.CheckState = CheckState.Checked Then
                GV.Columns(item.Value).Group()
            Else
                GV.Columns(item.Value).unGroup()
            End If
        Next
    End Sub

    Private Sub frmMonBatalPOM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()

        prn = frmMain
        setStatus()
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
    End Sub

    Public Sub cetak_click()
        GC.Refresh()
        GC.ShowPrintPreview()
    End Sub
End Class