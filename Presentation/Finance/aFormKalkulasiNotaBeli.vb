'############## BY ANDY ##############

Imports System.Data.SqlClient

Public Class aFormKalkulasiNotaBeli
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
    Dim drNota As SqlDataReader
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

    Private Sub loadPO()
        If Not dsNota.Tables("PO") Is Nothing Then dsNota.Tables("PO").Clear()
        daNota = New SqlDataAdapter(New SqlCommand("SELECT no_po FROM PURC.dbo.PURC_PO", sqlconn))
        daNota.Fill(dsNota, "PO")
        lckPO.Properties.DataSource = dsNota.Tables("PO")
        lckPO.Properties.DisplayMember = "no_po"
        lckPO.Properties.ValueMember = "no_po"
    End Sub

    Private Sub aFormNeracaSaldo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        daNota = New SqlDataAdapter(New SqlCommand("select no_trans from INV.dbo.INV_GUDANG_IN where 1=0", sqlconn))
        daNota.Fill(dsNota, "Nota")
        gcNota.DataSource = dsNota.Tables("Nota")
        gvNotaJual.BestFitColumns()
    End Sub

    Public Sub call_procedure(ByVal noSJ As String)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_INS_NOTA_BELI"

        sqlCmd.Parameters.Add("@vno_trans", SqlDbType.Char).Value = noSJ
        sqlCmd.ExecuteNonQuery()
    End Sub

    Private Sub btnKalkulasi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKalkulasi.Click
        If Not lckPO.EditValue = vbNullString Then
            For i As Integer = 0 To gvNotaJual.RowCount - 1
                call_procedure(gvNotaJual.GetRowCellValue(i, "no_trans").ToString)
            Next
            For j As Integer = 0 To gvNotaJual.RowCount
                gvNotaJual.DeleteRow(j)
            Next
        Else
            MsgBox("Isi data PO terlebih dahulu.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "PERINGATAN!")
        End If
    End Sub

    Private Sub lckPO_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lckPO.EditValueChanged
        If Not dsNota.Tables("Nota") Is Nothing Then dsNota.Tables("Nota").Clear()
        If Not lckPO.EditValue Is Nothing Then
            With New SqlCommand("SELECT no_trans FROM INV.dbo.INV_GUDANG_IN WHERE no_ref = '" & lckPO.EditValue & "'", sqlconn).ExecuteReader
                While .Read()
                    If .HasRows Then
                        Dim rowGrid As DataRow = dsNota.Tables("Nota").NewRow
                        rowGrid.Item("no_trans") = .Item(0)
                        dsNota.Tables("Nota").Rows.Add(rowGrid)
                    End If
                End While
                .Close()
            End With
        End If
    End Sub

    Private Sub lckPO_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lckPO.QueryPopUp
        loadPO()
    End Sub
End Class