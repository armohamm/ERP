Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class aFormMFee
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public prn As frmMain
    Public STATE As String
    Dim dsFee As New DataSet
    Dim daFee, daLookUp As SqlDataAdapter
    Dim bldFee As New SqlCommandBuilder
    Dim BTRANS As SqlTransaction
    Dim isOK As Boolean

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

    Private Sub loadLookUp()
        If Not dsFee.Tables("BarangBOM") Is Nothing Then dsFee.Tables("BarangBOM").Clear()
        If Not dsFee.Tables("BarangFee") Is Nothing Then dsFee.Tables("BarangFee").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT kd_bom, nama_bom FROM SIF.dbo.SIF_bom", sqlconn))
        daLookUp.Fill(dsFee, "BarangBOM")
        repLookBarangBOM.DataSource = dsFee.Tables("BarangBOM")
        repLookBarangBOM.DisplayMember = "nama_bom"
        repLookBarangBOM.ValueMember = "kd_bom"

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT a.kd_bom, a.nama_bom FROM SIF.dbo.SIF_bom a, SIF.dbo.SIF_Barang b WHERE a.kd_bom = b.Kode_Barang AND NOT b.kd_jns_persd = '1'", sqlconn))
        daLookUp.Fill(dsFee, "BarangFee")
        repLookBarangFee.DataSource = dsFee.Tables("BarangFee")
        repLookBarangFee.DisplayMember = "nama_bom"
        repLookBarangFee.ValueMember = "kd_bom"
    End Sub

    Private Sub loadData()
        daFee = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_MST_FEE_SHARING", sqlconn))
        daFee.Fill(dsFee, "Fee")
        gcFee.DataSource = dsFee.Tables("Fee")
        gvFee.BestFitColumns()
    End Sub

    Private Sub aFormMFee_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        loadLookUp()
        loadData()
    End Sub

    Public Sub save_click()
        For Each rw As DataRow In dsFee.Tables("Fee").Rows
            If rw.RowState = DataRowState.Added Then
                isOK = True
                Exit For
            ElseIf rw.RowState = DataRowState.Modified Then
                isOK = True
                Exit For
            Else
                isOK = False
            End If
        Next

        If isOK Then
            Try
                For Each rw As DataRow In dsFee.Tables("Fee").Rows
                    If rw.RowState = DataRowState.Added Then
                        rw.Item("Kd_Cabang") = getKodeCabang()
                        rw.Item("rp_fee") = 0
                        rw.Item("Last_Create_Date") = Now
                        rw.Item("Last_Created_By") = username
                        rw.Item("Program_Name") = Me.Name
                    ElseIf rw.RowState = DataRowState.Modified Then
                        rw.Item("Last_update_date") = Now
                        rw.Item("Last_updated_by") = username
                    End If

                    bldFee = New SqlCommandBuilder(daFee)
                    daFee.InsertCommand = bldFee.GetInsertCommand()
                    daFee.UpdateCommand = bldFee.GetUpdateCommand()
                    daFee.DeleteCommand = bldFee.GetDeleteCommand()

                    BTRANS = sqlconn.BeginTransaction("1")
                    daFee.UpdateCommand.Transaction = BTRANS
                    daFee.InsertCommand.Transaction = BTRANS
                    daFee.DeleteCommand.Transaction = BTRANS

                    daFee.Update(dsFee, ("Fee"))
                    dsFee.Tables("Fee").AcceptChanges()

                    BTRANS.Commit()
                Next
                showMessages("Berhasil disimpan..")
            Catch e As Exception
                BTRANS.Rollback()
                dsFee.Tables("Fee").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
            End Try
        Else
            MsgBox("Gagal simpan." & vbCrLf & "Tidak ada data baru atau data yang diubah.", MsgBoxStyle.OkOnly, "ERROR!")
        End If
    End Sub

    Private Sub gvFee_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvFee.InitNewRow
        gvFee.SetRowCellValue(e.RowHandle, "prosen_fee", 0)
    End Sub

    Private Sub gvFee_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvFee.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub gvFee_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvFee.ValidateRow
        Try
            Dim view As ColumnView = CType(sender, ColumnView)
            Dim column1 As GridColumn = view.Columns("kd_brg_bom")
            Dim column2 As GridColumn = view.Columns("kd_brg_fee")
            'If view.GetRowCellValue(e.RowHandle, column1) = "" Or view.GetRowCellValue(e.RowHandle, column1) = vbNullString Then
            '    e.Valid = False
            '    view.SetColumnError(column1, "Barang BOM harus diisi.")
            '    If view.GetRowCellValue(e.RowHandle, column2) = "" Or view.GetRowCellValue(e.RowHandle, column2) = vbNullString Then
            '        view.SetColumnError(column2, "Barang Fee harus diisi.")
            '    End If
            'Else
            If view.GetRowCellValue(e.RowHandle, column2) = "" Or view.GetRowCellValue(e.RowHandle, column2) = vbNullString Then
                e.Valid = False
                view.SetColumnError(column2, "Barang Fee harus diisi.")
                'If view.GetRowCellValue(e.RowHandle, column1) = "" Or view.GetRowCellValue(e.RowHandle, column1) = vbNullString Then
                '    view.SetColumnError(column1, "Barang BOM harus diisi.")
                'End If
            Else
                'view.SetColumnError(column1, "")
                view.SetColumnError(column2, "")
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class