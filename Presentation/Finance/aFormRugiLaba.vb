'############## BY ANDY ##############

Imports System.Data.SqlClient

Public Class aFormRugiLaba
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
        If Not dsLookUp.Tables("LookDivisi") Is Nothing Then dsLookUp.Tables("LookDivisi").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        daLookUp.Fill(dsLookUp, "LookPeriode")
        lookupBulanAwal.Properties.DataSource = dsLookUp.Tables("LookPeriode")
        lookupBulanAwal.Properties.DisplayMember = "nama"
        lookupBulanAwal.Properties.ValueMember = "thnbln"

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT Kode_Valuta, Nama_Valuta FROM SIF.dbo.SIF_Valuta", sqlconn))
        daLookUp.Fill(dsLookUp, "LookValuta")
        lookupValuta.Properties.DataSource = dsLookUp.Tables("LookValuta")
        lookupValuta.Properties.DisplayMember = "Nama_Valuta"
        lookupValuta.Properties.ValueMember = "Kode_Valuta"

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT kd_buku_pusat as KodeBuku, nm_buku_pusat as NamaBuku FROM SIF.dbo.SIF_buku_pusat where not kd_buku_pusat in ('00000000','90000003') UNION ALL SELECT '00000000' KodeBuku, '[Semua Divisi]' NamaBuku", sqlconn))
        daLookUp.Fill(dsLookUp, "LookDivisi")
        lookupDivisi.Properties.DataSource = dsLookUp.Tables("LookDivisi")
        lookupDivisi.Properties.DisplayMember = "NamaBuku"
        lookupDivisi.Properties.ValueMember = "KodeBuku"
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
        ElseIf lookupValuta.EditValue = vbNullString Then
            isOK = False
            err &= "Valuta neraca masih belum dipilih." & vbCrLf
        ElseIf lookupDivisi.EditValue = vbNullString Then
            isOK = False
            err &= "Divisi neraca masih belum dipilih." & vbCrLf
        Else
            isOK = True
        End If
    End Sub

    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrev.Click
        cek()
        If isOK = True Then
            If lookupDivisi.EditValue = "00000000" Then
                callReport(App_Path() & "\report\repLabaRugi.rpt", "", "bulan=" & Microsoft.VisualBasic.Right(lookupBulanAwal.EditValue, 2) & "&tahun=" & Microsoft.VisualBasic.Left(lookupBulanAwal.EditValue, 4) & "&valuta=" & lookupValuta.EditValue, False)
            Else
                callReport(App_Path() & "\report\repLabaRugiDivisi1.rpt", "", "bulan=" & Microsoft.VisualBasic.Right(lookupBulanAwal.EditValue, 2) & "&tahun=" & Microsoft.VisualBasic.Left(lookupBulanAwal.EditValue, 4) & "&valuta=" & lookupValuta.EditValue & "&divisi=" & lookupDivisi.EditValue, False)
            End If
        Else
            MsgBox("Kesalahan dalam mengisi filter neraca :" & vbCrLf & err, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ERROR!")
            err = ""
        End If
    End Sub

    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        cek()
        If isOK = True Then
            If lookupDivisi.EditValue = "00000000" Then
                callReport(App_Path() & "\report\repLabaRugi.rpt", "", "bulan=" & Microsoft.VisualBasic.Right(lookupBulanAwal.EditValue, 2) & "&tahun=" & Microsoft.VisualBasic.Left(lookupBulanAwal.EditValue, 4) & "&valuta=" & lookupValuta.EditValue, True)
            Else
                callReport(App_Path() & "\report\repLabaRugiDivisi1.rpt", "", "bulan=" & Microsoft.VisualBasic.Right(lookupBulanAwal.EditValue, 2) & "&tahun=" & Microsoft.VisualBasic.Left(lookupBulanAwal.EditValue, 4) & "&valuta=" & lookupValuta.EditValue & "&divisi=" & lookupDivisi.EditValue, True)
            End If
        Else
            MsgBox("Kesalahan dalam mengisi filter neraca :" & vbCrLf & err, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ERROR!")
            err = ""
        End If
    End Sub
End Class