Imports System.Data.SqlClient
Public Class frmProsesPenyusutanAktiva
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain

    Dim dsLookUPValuta, dsLookUpRek, dsSal, dsThn, dsBln, dsLookUp As New DataSet
    Dim daLookUPValuta, daLookUpRek, daSal, daThn, daBln, daLookUp As SqlDataAdapter
    Dim drAktiva As SqlDataReader

    Dim VarTahun As String
    Dim VarBulan As String

    Dim err As String
    Dim BTRANS As SqlTransaction
    Dim isOK As Boolean = True

    Private Sub frmProsesPenyusutanAktiva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True

        loadLookUp()

    End Sub

    Private Sub loadLookUp()
        If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM KOPKAR.dbo.SIF_Periode_Buku", sqlconn))
        daLookUp.Fill(dsLookUp, "LookPeriode")
        lookupBulanAwal.Properties.DataSource = dsLookUp.Tables("LookPeriode")
        lookupBulanAwal.Properties.DisplayMember = "nama"
        lookupBulanAwal.Properties.ValueMember = "thnbln"
    End Sub

    Private Sub cmdExe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExe.Click
        Try
            Dim ok As Boolean = True

            drAktiva = New SqlCommand("SELECT COUNT(*) FROM KOPKAR.dbo.FIN_TRANS_AKTIVA_BLN a, KOPKAR.dbo.FIN_JURNAL b WHERE a.periode = b.thnbln AND b.tipe_trans = 'JRR-KBB-02' AND NOT (b.no_posting IS NULL OR b.no_posting = '') AND a.periode = '" & lookupBulanAwal.EditValue & "'", sqlconn).ExecuteReader
            While drAktiva.Read()
                If drAktiva.Item(0) > 0 Then
                    MsgBox("Jurnal penyusutan aktiva periode " & lookupBulanAwal.Text & " sudah diposting.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                    ok = False
                End If
            End While
            drAktiva.Close()

            If ok = True Then
                BTRANS = sqlconn.BeginTransaction("1")
                call_procedure(lookupBulanAwal.EditValue, "JRR-KBB-02", BTRANS)
                BTRANS.Commit()
                showMessages("Proses Berhasil Disimpan")
            End If
        Catch ex As Exception
            BTRANS.Rollback()
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub call_procedure(ByVal noInvoice As String, ByVal noTrans As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "KOPKAR.dbo.FIN_AUTOMAN_JURNAL"

        sqlCmd.Parameters.Add("@tipe_trans", SqlDbType.Char).Value = noTrans
        sqlCmd.Parameters.Add("@no_inv", SqlDbType.Char).Value = noInvoice
        sqlCmd.ExecuteNonQuery()
    End Sub
End Class