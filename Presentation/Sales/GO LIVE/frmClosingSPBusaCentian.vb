Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class frmClosingSPBusaCentian
    Dim dsete As New DataSet
    Dim DA As SqlDataAdapter
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = False
            .btnCancel.Enabled = False
            .btnDelete.Enabled = False
            .btnEdit.Enabled = False
            .btnSave.Enabled = True
            .btnCetak.Enabled = False
        End With

    End Sub
    Public Sub add_click()

    End Sub
    Public Sub save_click()
        Dim BTRANS As SqlTransaction
        Try
            Dim myBuilder As Object = New SqlClient.SqlCommandBuilder(DA)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            DA.UpdateCommand = myBuilder.GetUpdateCommand()
            DA.InsertCommand = myBuilder.GetInsertCommand()
            DA.DeleteCommand = myBuilder.GetDeleteCommand()

            If BTRANS Is Nothing Then BTRANS = sqlconn.BeginTransaction("1")

            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            DA.Update(dsete.Tables("SO"))
            BTRANS.Commit()
            showMessages("Data Sudah Disimpan")
            reload_table()
        Catch e As Exception
            If Not BTRANS Is Nothing Then BTRANS.Rollback()
            dsete.Tables("batal").RejectChanges()
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        reload_table()
    End Sub
    Sub reload_table()
        If Not dsete.Tables("SO") Is Nothing Then dsete.Tables("SO").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from Sales.dbo.SALES_SO where isnull(isClosed,'')='' and tipe_trans in ('" & CentianUmum & "','" & CentianInternal & "')", sqlconn))
        DA.Fill(dsete, "SO")

    End Sub

    Private Sub frmClosingSPBusaCentian_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        reload_table()
        gc.DataSource = dsete.Tables("SO")

    End Sub
End Class