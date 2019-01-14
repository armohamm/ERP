'########## By Kentang ##########

Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class aFormAppPiutKar
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public prn As frmMain
    Public STATE As String
    Dim dsApp, dsLook As New DataSet
    Dim daApp, daLookNama As SqlDataAdapter
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
            .btnCetak.Enabled = btnCetak
        End With
    End Sub

    Public Sub loadData()
        If Not dsApp.Tables("Nota") Is Nothing Then dsApp.Tables("Nota").Clear()
        daApp = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA WHERE (no_posting IS NULL OR no_posting = '') AND tipe_trans IN ('JKK-KPT-01', 'JKK-KPT-02') AND [status] = 'MOHON'", sqlconn))
        daApp.Fill(dsApp, "Nota")
        gcApp.DataSource = dsApp.Tables("Nota")
        gvApp.BestFitColumns()
    End Sub

    Private Sub aFormAppPiutKar_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        daLookNama = New SqlDataAdapter(New SqlCommand("SELECT kode, nama FROM FIN.dbo.v_kartu", sqlconn))
        daLookNama.Fill(dsLook, "Nama")
        lueNama.DataSource = dsLook.Tables("Nama")
        lueNama.DisplayMember = "nama"
        lueNama.ValueMember = "kode"
        loadData()
    End Sub

    Public Sub save_click()
        For Each row As DataRow In dsApp.Tables("Nota").Rows
            If row.RowState = DataRowState.Modified Then
                If row.Item("status").ToString = "MOHON" Then
                    isOK = False
                Else
                    isOK = True
                    Exit For
                End If
            Else
                isOK = False
            End If
        Next
        If isOK Then
            If MsgBox("Transaksi akan diposting ke jurnal. Anda yakin?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                simpan()
                If Not dsApp Is Nothing Then
                    dsApp.Clear()
                    loadData()
                End If
            End If
        Else
            MsgBox("Status data piutang tidak ada yang diubah.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
        End If
    End Sub

    Public Sub simpan(Optional ByRef isDelete As Boolean = False)
        Dim OK As Boolean = False
        Try
            For Each rw As DataRow In dsApp.Tables("Nota").Rows
                If rw.Item("status").Equals(cmbStatus.Items(0).ToString) Then
                    rw.Item("Kd_cabang") = getKodeCabang()
                    rw.Item("Last_update_date") = Now
                    rw.Item("Last_updated_by") = username
                    noInv = rw.Item("no_inv")

                    bldApp = New SqlCommandBuilder(daApp)
                    daApp.InsertCommand = bldApp.GetInsertCommand()
                    daApp.UpdateCommand = bldApp.GetUpdateCommand()
                    daApp.DeleteCommand = bldApp.GetDeleteCommand()

                    BTRANS = sqlconn.BeginTransaction("1")
                    daApp.UpdateCommand.Transaction = BTRANS
                    daApp.InsertCommand.Transaction = BTRANS
                    daApp.DeleteCommand.Transaction = BTRANS

                    daApp.Update(dsApp, ("Nota"))

                    If rw.Item("tipe_trans") = "JKK-KPT-01" Then
                        call_procedure("JKK-KPT-01", noInv, BTRANS)
                    ElseIf rw.Item("tipe_trans") = "JKK-KPT-02" Then
                        call_procedure("JKK-KPT-02", noInv, BTRANS)
                    End If
                    noInv = ""
                    BTRANS.Commit()
                End If
            Next
            showMessages("Berhasil disimpan..")
        Catch e As Exception
            BTRANS.Rollback()
            dsApp.Tables("Nota").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
        Try
            umum.coll_form.Item("frmPMHPuitangKary").isiGrid()
            umum.coll_form.Item("frmPiutangLain").isiGrid()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        save_click()
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

    Private Sub gvApp_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvApp.CellValueChanging
        If e.Column Is status Then
            'If e.Value.ToString <> "MOHON" Then
            '    btnSave = True
            '    setStatus()
            'Else
            '    btnSave = False
            '    setStatus()
            'End If
            gvApp.SetRowCellValue(e.RowHandle, "tgl_approve", getTanggal())
        End If

        If e.Column Is tgl_approve Then
            If gvApp.GetRowCellValue(e.RowHandle, "tgl_approve").ToString = "" Then
                gvApp.SetRowCellValue(e.RowHandle, "tgl_approve", getTanggal())
            End If
        End If
    End Sub

    Private Sub gvApp_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles gvApp.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub gvApp_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles gvApp.ValidatingEditor
        Dim vx As GridView = sender
        If vx.FocusedColumn.FieldName = "jml_tagihan" Then
            If Not vx.GetFocusedRowCellValue("jml_tagihan") = vbNullString Then
                Dim jmltagihan As Double = Convert.ToDouble(e.Value)
                If jmltagihan > vx.GetFocusedRowCellValue("jml_val_trans") Then
                    e.Valid = False
                    e.ErrorText = "Jumlah bayar tidak boleh lebih dari sisa piutang."
                End If
            Else
                vx.SetFocusedRowCellValue("jml_tagihan", 0)
            End If

        End If
        If vx.FocusedColumn.FieldName = "tgl_approve" Then
            Dim tglApp As Date = Convert.ToDateTime(e.Value)
            If tglApp < vx.GetFocusedRowCellValue("tgl_inv") Then
                e.Valid = False
                e.ErrorText = "Tanggal pengajuan lebih besar daripada tanggal approve."
            End If
        End If
    End Sub
End Class