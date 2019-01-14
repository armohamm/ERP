﻿Imports System.Data.SqlClient
Public Class frmKalkulasiNeraca
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain

    Dim dsLookUPValuta, dsLookUpRek, dsSal, dsThn, dsBln, dsLookUp As New DataSet
    Dim daLookUPValuta, daLookUpRek, daSal, daThn, daBln, daLookUp As SqlDataAdapter

    Dim VarTahun As String
    Dim VarBulan As String

    Dim err As String
    Dim isOK As Boolean = True
    Private Sub frmKalkulasiNeraca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True

        loadLookUp()
    End Sub

    Private Sub loadLookUp()
        If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        daLookUp.Fill(dsLookUp, "LookPeriode")
        lookupBulanAwal.Properties.DataSource = dsLookUp.Tables("LookPeriode")
        lookupBulanAwal.Properties.DisplayMember = "nama"
        lookupBulanAwal.Properties.ValueMember = "thnbln"
    End Sub

    Private Sub cmdExe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExe.Click
        Try
            call_procedure(lookupBulanAwal.EditValue)
            showMessages("Proses Berhasil Disimpan")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub call_procedure(ByVal noTrans As String)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_KALKULASI_NERACA"

        sqlCmd.Parameters.Add("@vthnbln", SqlDbType.Char).Value = noTrans
        sqlCmd.ExecuteNonQuery()

    End Sub
End Class