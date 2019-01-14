Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports Microsoft
Imports System.Windows.Forms
Public Class frmRealPO
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
        Dim sql As String = ""
        If tglDari.Text = "" Then
            If tglsampai.Text <> "" Then
                sql = " where convert(varchar, tgl_po, 112) < " & tglsampai.Text
            End If
        Else

            If tglsampai.Text <> "" Then
                sql = " where convert(varchar, tgl_po, 112)  between '" & tglDari.Text & "' and '" & tglsampai.Text & "' "
            Else
                sql = " where convert(varchar, tgl_po, 112)  > " & tglDari.Text
            End If
        End If


        If Not dsete.Tables("POBatal") Is Nothing Then dsete.Tables("POBatal").Clear()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from [PURC].[dbo].[v_mon_pembelian] " & sql, sqlconn))
        dadbe.Fill(dsete, "POBatal")
        GC.DataSource = dsete.Tables("POBatal")

        
        For Each itm As CheckedListBoxItem In cmdkolom.Properties.Items
            'If Not itm.Value = "qty_total" Then
            '    GV.Columns(itm.Value).visible = False
            'End If
            'If Not itm.Value = "total_rp" Then
            '    GV.Columns(itm.Value).visible = False
            'End If
            GV.Columns(itm.Value).visible = False
            GV.Columns(itm.Value).UnGroup()
            If itm.CheckState = CheckState.Checked Then
                kolom &= itm.Value & ","
                GV.Columns(itm.Value).visible = True
            End If
        Next

        If kolom = "" Then Exit Sub
        kolom = kolom.Substring(0, Len(kolom) - 1)
        If Not dsete.Tables("sp") Is Nothing Then dsete.Tables("sp").Clear()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select " & kolom & " from [PURC].[dbo].[v_mon_pembelian] as s " & sql & " group by " & kolom, sqlconn))
        dadbe.Fill(dsete, "sp")
        GC.DataSource = dsete.Tables("sp")
    End Sub
    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        reloadTable()
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        tglDari.EditValue = vbNullString
        tglsampai.EditValue = vbNullString
    End Sub

    Private Sub cmdGroup_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        For Each item As Object In cmdkolom.Properties.Items
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
        'setStatus()
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
    End Sub
    Public Sub add_click()

    End Sub
End Class