'############## BY ANDY ##############

Imports System.Data.SqlClient

Public Class aFormNeracaSaldo
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCtk As Boolean = False
    Public prn As frmMain
    Dim dsLookUp As New DataSet
    Dim daLookUp As SqlDataAdapter
    Dim err As String
    Dim isOK As Boolean = True
    Dim bln, thn As String

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btnCtk
        End With
    End Sub

    Private Sub loadLookUp()
        If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
        If Not dsLookUp.Tables("LookValuta") Is Nothing Then dsLookUp.Tables("LookValuta").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM SIF_Periode_Buku WHERE status_close = 'Y'", sqlconn))
        daLookUp.Fill(dsLookUp, "LookPeriode")
        lookupBulanAwal.Properties.DataSource = dsLookUp.Tables("LookPeriode")
        lookupBulanAwal.Properties.DisplayMember = "nama"
        lookupBulanAwal.Properties.ValueMember = "thnbln"

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT Kode_Valuta, Nama_Valuta FROM SIF_Valuta", sqlconn))
        daLookUp.Fill(dsLookUp, "LookValuta")
        lookupValuta.Properties.DataSource = dsLookUp.Tables("LookValuta")
        lookupValuta.Properties.DisplayMember = "Nama_Valuta"
        lookupValuta.Properties.ValueMember = "Kode_Valuta"
    End Sub

    Private Sub aFormNeracaSaldo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        loadLookUp()
        lookupValuta.EditValue = "IDR"
    End Sub

    Private Sub cek()
        If lookupBulanAwal.EditValue = vbNullString Then
            isOK = False
            err &= "Periode neraca masih belum dipilih." & vbCrLf
        Else
            isOK = True
        End If
    End Sub
    Sub FinLabaRugi()
        If Not Microsoft.VisualBasic.Right(lookupBulanAwal.EditValue, 2).ToString = "00" Then
            'If no_realisasi = vbNullString Or no_realisasi = "" Then
            '    MsgBox("Transasksi realisasi belum disimpan.", MsgBoxStyle.Information)
            '    Exit Sub
            'End If
            bln = Microsoft.VisualBasic.Right(lookupBulanAwal.EditValue, 2)
            thn = Microsoft.VisualBasic.Left(lookupBulanAwal.EditValue, 4)
            ' MsgBox(bln & " dan " & thn, MsgBoxStyle.Information)
            Dim sqlCmd As New SqlCommand
            Dim dr As SqlDataReader
            sqlCmd.CommandTimeout = 0
            sqlCmd.Connection = sqlconn
            ' sqlCmd.Transaction = btrans
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.CommandText = "FIN_LABA_RUGI_BLN"
            sqlCmd.Parameters.Add("@thn", SqlDbType.VarChar, 4).Value = thn
            sqlCmd.Parameters.Add("@bln", SqlDbType.VarChar, 2).Value = bln
            dr = sqlCmd.ExecuteReader
            dr.Close()
            'MsgBox("HPP Created", MsgBoxStyle.Information)
        End If
    End Sub
    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        cek()
        If Not Microsoft.VisualBasic.Right(lookupBulanAwal.EditValue, 2) = "09" Then
            FinLabaRugi()
        End If
        If isOK = True Then
            callReport(App_Path() & "\report\repAktivaPasiva.rpt", "", "bulan=" & Microsoft.VisualBasic.Right(lookupBulanAwal.EditValue, 2) & "&tahun=" & Microsoft.VisualBasic.Left(lookupBulanAwal.EditValue, 4) & "&valuta=" & lookupValuta.EditValue, False)
        Else
            MsgBox("Kesalahan dalam mengisi filter neraca :" & vbCrLf & err, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ERROR!")
            err = ""
        End If
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        cek()
        If Not Microsoft.VisualBasic.Right(lookupBulanAwal.EditValue, 2) = "09" Then
            FinLabaRugi()
        End If
        If isOK = True Then
            callReport(App_Path() & "\report\repAktivaPasiva.rpt", "", "bulan=" & Microsoft.VisualBasic.Right(lookupBulanAwal.EditValue, 2) & "&tahun=" & Microsoft.VisualBasic.Left(lookupBulanAwal.EditValue, 4) & "&valuta=" & lookupValuta.EditValue, True)
        Else
            MsgBox("Kesalahan dalam mengisi filter neraca :" & vbCrLf & err, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ERROR!")
            err = ""
        End If
    End Sub
End Class