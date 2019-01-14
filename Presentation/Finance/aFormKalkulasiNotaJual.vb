'############## BY ANDY ##############

Imports System.Data.SqlClient

Public Class aFormKalkulasiNotaJual
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCtk As Boolean = False
    Public prn As frmMain
    Dim err As String
    Dim isOK As Boolean = True
    Dim daNota As SqlDataAdapter
    Dim dsNota As New DataSet

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btnCtk
        End With
    End Sub

    Private Sub aFormNeracaSaldo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        daNota = New SqlDataAdapter(New SqlCommand("select no_sj from SALES.dbo.SALES_SJ where 1=0", sqlconn))
        daNota.Fill(dsNota, "Nota")
        gcNota.DataSource = dsNota.Tables("Nota")
        gvNotaJual.BestFitColumns()
    End Sub

    Private Sub loadSJ()
        If Not dsNota.Tables("SJ") Is Nothing Then dsNota.Tables("SJ").Clear()
        daNota = New SqlDataAdapter(New SqlCommand("SELECT no_sj FROM SALES.DBO.SALES_SJ WHERE sts_nota = 'NOTA'", sqlconn))
        daNota.Fill(dsNota, "SJ")
        lookupSJ.DataSource = dsNota.Tables("SJ")
        lookupSJ.DisplayMember = "no_sj"
        lookupSJ.ValueMember = "no_sj"
    End Sub

    Public Sub call_procedure(ByVal noSJ As String)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_INS_NOTA_JUAL"

        sqlCmd.Parameters.Add("@no_sj", SqlDbType.Char).Value = noSJ
        sqlCmd.ExecuteNonQuery()
    End Sub

    Private Sub btnKalkulasi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKalkulasi.Click
        If Not gvNotaJual.RowCount <= 0 Then
            For i As Integer = 0 To gvNotaJual.RowCount - 1
                call_procedure(gvNotaJual.GetRowCellValue(i, "no_sj").ToString)
            Next
            For j As Integer = 0 To gvNotaJual.RowCount - 1
                gvNotaJual.DeleteRow(j)
            Next
        Else
            MsgBox("Isi data SJ terlebih dahulu.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "PERINGATAN!")
        End If
    End Sub

    Private Sub lookupSJ_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lookupSJ.QueryPopUp
        loadSJ()
    End Sub

    Private Sub gvNotaJual_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles gvNotaJual.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub gvNotaJual_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles gvNotaJual.ValidatingEditor
        For i As Integer = 0 To gvNotaJual.RowCount - 1
            If gvNotaJual.GetRowCellValue(i, "no_sj").Equals(e.Value) Then
                e.Valid = False
                e.ErrorText = "No. SJ sudah ada ditabel."
            End If
        Next
    End Sub
End Class