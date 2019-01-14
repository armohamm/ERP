Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports Microsoft
Imports System.Windows.Forms
Public Class frmMonBatalPOM
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
        Dim sql As String
        If tglDari.Text = "" And tglsampai.Text <> "" Then
            sql = " where tgl_po < convert(date,'" & tglsampai.EditValue & "',103) "
      
        Else
            sql = " where tgl_po between convert(date,'" & tglDari.EditValue & "',103) and convert(date,'" & tglsampai.EditValue & "',103) " ' "
        End If


        If Not dsete.Tables("POBatal") Is Nothing Then dsete.Tables("POBatal").Clear()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from [PURC].[dbo].[V_monPOBatal] " & sql, sqlconn))
        dadbe.Fill(dsete, "POBatal")
        GC.DataSource = dsete.Tables("POBatal")


        'For Each item As Object In GV.Columns
        '    Dim ck As New DevExpress.XtraEditors.Controls.CheckedListBoxItem
        '    ck.CheckState = CheckState.Unchecked
        '    ck.Description = item.Caption
        '    ck.Value = item.FieldName
        '    cmdGroup.Properties.Items.Add(ck)
        'Next
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

    Private Sub cmdGroup_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdGroup.EditValueChanged
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
        'reloadTable()
        'dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from [PURC].[dbo].[V_monPOBatal]", sqlconn))
        'dadbe.Fill(dsete, "POBatal")
        'GC.DataSource = dsete.Tables("POBatal")
        'prn = frmMain
        'setStatus()

        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        For Each item As Object In GV.Columns
            Dim ck As New DevExpress.XtraEditors.Controls.CheckedListBoxItem
            ck.CheckState = CheckState.Unchecked
            ck.Description = item.Caption
            ck.Value = item.FieldName
            cmdGroup.Properties.Items.Add(ck)
        Next
    End Sub
End Class