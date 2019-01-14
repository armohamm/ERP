Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient

Public Class aFormTarifSupir
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = True
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public prn As frmMain
    Public STATE As String
    Dim row As DataRow
    Dim bld As New SqlCommandBuilder
    Dim BTRANS As SqlTransaction
    Dim dsTarif, dsLookup As New DataSet
    Dim daTarif, daKendaraan As SqlDataAdapter
    Dim kodeTarif As String

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btnCetak
        End With
    End Sub

    Public Sub cancel_click()
        dtpTanggal.EditValue = getTanggal()
        If Not dsTarif.Tables("Tarif") Is Nothing Then dsTarif.Tables("Tarif").Clear()
    End Sub

    Private Sub loadLookup()
        If Not dsLookup.Tables("Kendaraan") Is Nothing Then dsLookup.Tables("Kendaraan").Clear()
        daKendaraan = New SqlDataAdapter(New SqlCommand("SELECT Id_Data, Desc_Data FROM SIF.dbo.SIF_Gen_Reff_D WHERE Id_Ref_Data = 'JNSKDRN'", sqlconn))
        daKendaraan.Fill(dsLookup, "Kendaraan")
        lckKendaraan.DataSource = dsLookup.Tables("Kendaraan")
        lckKendaraan.ValueMember = "Id_Data"
        lckKendaraan.DisplayMember = "Desc_Data"
    End Sub

    Private Sub loadTarif()
        If Not dsTarif.Tables("Tarif") Is Nothing Then dsTarif.Tables("Tarif").Clear()
        daTarif = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_tarif_biaya_sopir WHERE tgl_berlaku = CONVERT(DATE,'" & dtpTanggal.EditValue & "',103)", sqlconn))
        daTarif.Fill(dsTarif, "Tarif")
        gcTarif.DataSource = dsTarif.Tables("Tarif")
        gvTarif.BestFitColumns()
    End Sub

    Private Sub genKode()
        If gvTarif.RowCount > 0 Then
            If gvTarif.RowCount < 10 Then
                kodeTarif = ("0000" & (gvTarif.RowCount + 1))
            ElseIf gvTarif.RowCount > 9 Then
                kodeTarif = ("000" & (gvTarif.RowCount + 1))
            ElseIf gvTarif.RowCount > 99 Then
                kodeTarif = ("00" & (gvTarif.RowCount + 1))
            ElseIf gvTarif.RowCount > 999 Then
                kodeTarif = ("0" & (gvTarif.RowCount + 1))
            ElseIf gvTarif.RowCount > 9999 Then
                kodeTarif = (gvTarif.RowCount + 1)
            End If
        End If
    End Sub

    Private Sub aFormTarifSupir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        dtpTanggal.EditValue = getTanggal()
        loadLookup()
        loadTarif()
    End Sub

    Private Sub gvTarif_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvTarif.InitNewRow
        Dim view As ColumnView = sender
        If gvTarif.RowCount <= 0 Then
            view.SetFocusedRowCellValue("kode", "00001")
            view.SetFocusedRowCellValue("jarak", 0)
            view.SetFocusedRowCellValue("bensin", 0)
            view.SetFocusedRowCellValue("solar", 0)
            view.SetFocusedRowCellValue("jml_biaya", 0)
        Else
            genKode()
            view.SetFocusedRowCellValue("kode", kodeTarif)
            kodeTarif = ""
            view.SetFocusedRowCellValue("jarak", 0)
            view.SetFocusedRowCellValue("bensin", 0)
            view.SetFocusedRowCellValue("solar", 0)
            view.SetFocusedRowCellValue("jml_biaya", 0)
        End If
    End Sub

    Private Sub txtAngka_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 8, 127 'backspace + delete
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtNominal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNominal.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 8, 127 'backspace + delete
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub dtpTanggal_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpTanggal.EditValueChanged
        loadTarif()
    End Sub

    Public Sub save_click()
        If gvTarif.RowCount <= 0 Then
            MsgBox("Data kosong. Mohon isi data terlebih dahulu.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "PERINGATAN!")
            Exit Sub
        End If
        For Each row As DataRow In dsTarif.Tables("Tarif").Rows
            If row.RowState = DataRowState.Added Then
                row.Item("Kd_Cabang") = getKodeCabang()
                row.Item("tgl_berlaku") = dtpTanggal.EditValue
                row.Item("Last_Create_Date") = getTanggal()
                row.Item("Last_Created_By") = username
                row.Item("Program_Name") = Me.Name
            ElseIf row.RowState = DataRowState.Modified Then
                row.Item("Last_Update_Date") = getTanggal()
                row.Item("Last_Updated_By") = username
            End If
        Next

        Try
            bld = New SqlCommandBuilder(daTarif)
            daTarif.InsertCommand = bld.GetInsertCommand()
            daTarif.UpdateCommand = bld.GetUpdateCommand()
            daTarif.DeleteCommand = bld.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            daTarif.UpdateCommand.Transaction = BTRANS
            daTarif.InsertCommand.Transaction = BTRANS
            daTarif.DeleteCommand.Transaction = BTRANS

            daTarif.Update(dsTarif, ("Tarif"))
            dsTarif.Tables("Tarif").AcceptChanges()

            BTRANS.Commit()
        Catch ex As Exception
            BTRANS.Rollback()
            dsTarif.Tables("Tarif").RejectChanges()
            MsgBox(ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR!")
        End Try
        showMessages("Berhasil disimpan..")
    End Sub

    Public Sub delete_click()
        If Not gvTarif.GetSelectedRows.Count > 0 Then
            MsgBox("Tidak ada data yang dihapus. Mohon isi data terlebih dahulu.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "PERINGATAN!")
        Else
            gvTarif.DeleteSelectedRows()
            For j As Integer = 0 To gvTarif.RowCount - 1
                If j < 10 Then
                    gvTarif.GetDataRow(j).Item("kode") = "0000" & j + 1
                ElseIf gvTarif.RowCount > 9 Then
                    gvTarif.GetDataRow(j).Item("kode") = "000" & j + 1
                ElseIf gvTarif.RowCount > 99 Then
                    gvTarif.GetDataRow(j).Item("kode") = "00" & j + 1
                ElseIf gvTarif.RowCount > 999 Then
                    gvTarif.GetDataRow(j).Item("kode") = "0" & j + 1
                ElseIf gvTarif.RowCount > 9999 Then
                    gvTarif.GetDataRow(j).Item("kode") = j + 1
                End If
            Next
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        save_click()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        delete_click()
    End Sub
End Class