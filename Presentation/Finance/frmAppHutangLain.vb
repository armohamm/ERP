Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class frmAppHutangLain

    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Public STATE As String
    Dim dsAppHL, dsLook As New DataSet
    Dim daAppHL, daLookNama As SqlDataAdapter
    Dim bldApp As New SqlCommandBuilder
    Dim BTRANS As SqlTransaction
    Dim isOK As Boolean
    Dim noInv As String

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Private Sub loadData()
        dsLook.Clear()
        daLookNama = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.v_kartu", sqlconn))
        daLookNama.Fill(dsLook, "Nama")
        LOVNama.DataSource = dsLook.Tables("Nama")
        LOVNama.DisplayMember = "nama"
        LOVNama.ValueMember = "kode"

        dsAppHL.Clear()
        daAppHL = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_PEMBELIAN WHERE tipe_trans IN ('JKM-KUT-01') AND status = 'MOHON'", sqlconn))
        daAppHL.Fill(dsAppHL, "pembelian")
        gcApp.DataSource = dsAppHL.Tables("pembelian")
        gvApp.BestFitColumns()
    End Sub

    Sub LoadAllData()
        dsAppHL.Clear()
        daAppHL = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_PEMBELIAN WHERE tipe_trans IN ('JKM-KUT-01')", sqlconn))
        daAppHL.Fill(dsAppHL, "pembelian")
        gcApp.DataSource = dsAppHL.Tables("pembelian")
        gvApp.BestFitColumns()
    End Sub

    Private Sub frmAppHutangLain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        loadData()
    End Sub

    Public Sub save_click()

        'Try
        For Each rw As DataRow In dsAppHL.Tables("pembelian").Rows

            If rw.RowState = DataRowState.Modified Then
                rw.Item("Last_update_date") = Now
                rw.Item("Last_updated_by") = username
                noInv = rw.Item("no_inv")
            End If

            bldApp = New SqlCommandBuilder(daAppHL)
            daAppHL.InsertCommand = bldApp.GetInsertCommand()
            daAppHL.UpdateCommand = bldApp.GetUpdateCommand()
            daAppHL.DeleteCommand = bldApp.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            daAppHL.UpdateCommand.Transaction = BTRANS
            daAppHL.InsertCommand.Transaction = BTRANS
            daAppHL.DeleteCommand.Transaction = BTRANS

            daAppHL.Update(dsAppHL, ("pembelian"))
            dsAppHL.Tables("pembelian").AcceptChanges()

            call_procedure("JKM-KUT-01", rw.Item("no_inv"), BTRANS)
            BTRANS.Commit()
        Next

        showMessages("Berhasil disimpan..")
        noInv = ""
        'Catch e As Exception
        '    BTRANS.Rollback()
        '    dsAppHL.Tables("Nota").RejectChanges() ' untuk membatalkan row yg diupdate/insert
        '    MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        'End Try
        loadData()
    End Sub
    Public Sub call_procedure(ByVal noTrans As String, ByVal noInvoice As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_AUTOMAN_JURNAL"

        sqlCmd.Parameters.Add("@tipe_trans", SqlDbType.Char).Value = noTrans
        sqlCmd.Parameters.Add("@no_inv", SqlDbType.Char).Value = noInvoice
        Dim dr As SqlDataReader = sqlCmd.ExecuteReader
        dr.Close()
    End Sub
    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        save_click()
    End Sub

    Private Sub CEShowAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEShowAll.CheckedChanged
        If CEShowAll.Checked = True Then
            LoadAllData()
        Else
            loadData()
        End If
    End Sub

    Private Sub gvApp_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvApp.CellValueChanged
        If e.Column Is status Then
            gvApp.SetFocusedRowCellValue("tgl_approve", getTanggal)
        End If
    End Sub
End Class