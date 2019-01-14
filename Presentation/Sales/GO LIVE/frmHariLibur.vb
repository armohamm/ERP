Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports Microsoft
Imports System.Windows.Forms
Public Class frmHariLibur
    Dim dsete As New DataSet
    Dim daLibur As SqlDataAdapter
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btncetak As Boolean = False
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btncetak
        End With
    End Sub
    Public Sub add_click()
        btnadd = False
        btnSave = True
        setStatus()
    End Sub

    Public Sub cancel_click()
        reload()
    End Sub
    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction

        Try

            Dim myBuilder As SqlClient.SqlCommandBuilder
            myBuilder = New SqlClient.SqlCommandBuilder(daLibur)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            daLibur.UpdateCommand = myBuilder.GetUpdateCommand()
            daLibur.InsertCommand = myBuilder.GetInsertCommand()
            daLibur.DeleteCommand = myBuilder.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")

            daLibur.UpdateCommand.Transaction = BTRANS
            daLibur.InsertCommand.Transaction = BTRANS
            daLibur.DeleteCommand.Transaction = BTRANS


            daLibur.Update(dsete.Tables("LIBUR"))
            BTRANS.Commit()
            showMessages("Transaksi Telah Diproses")
        Catch e As Exception
            If Not BTRANS Is Nothing Then BTRANS.Rollback()
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub
    Private Sub reload()
        If Not dsete.Tables("LIBUR") Is Nothing Then dsete.Tables("LIBUR").Clear()
        daLibur = New SqlDataAdapter("select * from sif.dbo.sif_hari_libur", sqlconn)
        daLibur.Fill(dsete, "LIBUR")

    End Sub
    Private Sub frmHariLibur_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        reload()
        GC.DataSource = dsete.Tables("LIBUR")
        prn = frmMain
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
    End Sub

    Private Sub GV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV.KeyDown
        If e.KeyCode = Keys.Delete Then
            If sender.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Hapus") = MsgBoxResult.Ok Then
                    sender.DeleteSelectedRows()
                End If
            End If
        End If
    End Sub
    Private Sub GV_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub GV_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        Dim rw() As DataRow = dsete.Tables("LIBUR").Select("TGL = '" & e.Row.item("TGL") & "'", "")
        Dim isValid As Boolean = True
        If e.Row.item("TGL").ToString = "" Then
            isValid = False
            GV.SetColumnError(TGL, "Tanggal Belum Diisi", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If rw.Count = 1 Then
            If Not rw(0) Is e.Row.row Then
                isValid = False
                sender.SetColumnError(TGL, "Tanggal Sudah Ada Dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If
        e.Valid = isValid
    End Sub

    Private Sub btnBatalSP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatalSP.Click
        reload()
    End Sub
End Class