Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports System.Drawing
Imports DevExpress.XtraPrinting

Public Class aFormKalkulasiJurnal
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public prn As frmMain
    Dim dsJurnal As New DataSet
    Dim daJurnal, daLookUp As SqlDataAdapter
    Dim drJurnal As SqlDataReader
    Dim sqlCmd As New SqlCommand

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Private Sub aFormKalkulasiJurnal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)

        loadLookUp()
        Me.Enabled = True
    End Sub

    Private Sub loadLookUp()
        If Not dsJurnal.Tables("Rekening") Is Nothing Then dsJurnal.Tables("Rekening").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT kd_buku_besar, nm_buku_besar FROM SIF.dbo.SIF_buku_besar WHERE grup_header = 'D'", sqlconn))
        daLookUp.Fill(dsJurnal, "Rekening")
        lookupRek.DataSource = dsJurnal.Tables("Rekening")
        lookupRek.DisplayMember = "nm_buku_besar"
        lookupRek.ValueMember = "kd_buku_besar"
    End Sub

    Public Sub cetak_click()
        MsgBox("Tidak ada fungsi cetak untuk Form ini.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "CATATAN!")
    End Sub

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click
        If Not txtNoJurnal.Text = vbNullString Or txtNoJurnal.Text = "" Or Microsoft.VisualBasic.Len(txtNoJurnal.Text) = 0 Then
            drJurnal = New SqlCommand("SELECT tipe_trans FROM FIN.dbo.FIN_JURNAL_D WHERE no_jur LIKE '" & txtNoJurnal.Text & "'", sqlconn).ExecuteReader
            drJurnal.Read()

            sqlCmd.Connection = sqlconn
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.CommandText = "FIN.dbo.FIN_AUTOMAN_JURNAL"

            sqlCmd.Parameters.Add("@tipe_trans", SqlDbType.Char).Value = drJurnal.Item(0).ToString
            sqlCmd.Parameters.Add("@no_inv", SqlDbType.Char).Value = txtNoJurnal.Text
            sqlCmd.ExecuteNonQuery()

            drJurnal.Close()
        End If
    End Sub

    Private Sub btnKalkulasi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKalkulasi.Click
        If Not txtNoJurnal.Text = vbNullString Or txtNoJurnal.Text = "" Or Microsoft.VisualBasic.Len(txtNoJurnal.Text) = 0 Then
            drJurnal = New SqlCommand("SELECT thnbln FROM FIN.dbo.FIN_JURNAL WHERE no_jur LIKE '" & txtNoJurnal.Text & "'", sqlconn).ExecuteReader
            drJurnal.Read()

            sqlCmd.Connection = sqlconn
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.CommandText = "FIN.dbo.FIN_KALKULASI_NERACA"

            sqlCmd.Parameters.Add("@vthnbln", SqlDbType.Char).Value = drJurnal.Item(0).ToString
            sqlCmd.ExecuteNonQuery()

            drJurnal.Close()
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        If Not dsJurnal.Tables("Jurnal") Is Nothing Then dsJurnal.Tables("Jurnal").Clear()
        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT kd_buku_besar, SUM(saldo_rp_debet) AS debet, SUM(saldo_rp_kredit) AS kredit FROM FIN.dbo.FIN_JURNAL_D WHERE no_jur LIKE '" & txtNoJurnal.Text & "' GROUP BY kd_buku_besar", sqlconn))
        daLookUp.Fill(dsJurnal, "Jurnal")
        gcJurnal.DataSource = dsJurnal.Tables("Jurnal")
        gvJurnal.BestFitColumns()
    End Sub
End Class