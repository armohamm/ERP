Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient

Public Class aFormCloseKasir
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public prn As frmMain
    Public obj As Object

    Dim dsClose, dsList As New DataSet
    Dim drClose, drList As SqlDataReader
    Dim daList As SqlDataAdapter

    Dim status As String

    Private Sub aFormCloseKasir_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        dteTanggal.EditValue = getTanggal()
        dteTanggal.Properties.MaxValue = getTanggal()
        load_closed()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        drClose = New SqlCommand("select COUNT(tgl_close) from FIN.dbo.FIN_PERIODE_CLOSE_KASIR WHERE tgl_close = CONVERT(DATE, '" & dteTanggal.EditValue & "',103)", sqlconn).ExecuteReader
        drClose.Read()
        If drClose.Item(0) = 0 Then
            Dim sqlx As New SqlCommand("INSERT INTO FIN.dbo.FIN_PERIODE_CLOSE_KASIR(tgl_close, isClosed, Last_create_date, Last_created_by, Program_name) VALUES (CONVERT(DATE, '" & dteTanggal.EditValue & "',103), 'Y', CONVERT(DATE, '" & Now & "',103), '" & username & "', '" & Me.Name & "')", sqlconn)
            sqlx.ExecuteNonQuery()
        Else
            MsgBox("Kasir tanggal " & dteTanggal.Text & " sudah di close.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "INFO")
        End If
        load_closed()
        drClose.Close()
    End Sub
    Private Sub load_closed()
        If Not dsList.Tables("Close") Is Nothing Then dsList.Tables("Close").Clear()
        daList = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT * FROM FIN.dbo.FIN_PERIODE_CLOSE_KASIR order by tgl_close desc", sqlconn))
        daList.Fill(dsList, "Close")
        GC.DataSource = dsList.Tables("Close")
    End Sub

    Private Sub GV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim sqlx As New SqlCommand("DELETE FIN.dbo.FIN_PERIODE_CLOSE_KASIR WHERE tgl_close = CONVERT(DATE, '" & GV.GetFocusedRowCellValue("tgl_close") & "',103)", sqlconn)
            sqlx.ExecuteNonQuery()
            load_closed()
        End If
    End Sub
End Class