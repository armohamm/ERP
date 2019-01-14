Imports System.Data.SqlClient
Public Class frmReportArusKas

    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = True

    Public prn As frmMain

    Dim dsLookUPValuta, dsLookUpRek, dsSal, dsThn, dsBln, dsLookUp As New DataSet
    Dim daLookUPValuta, daLookUpRek, daSal, daThn, daBln, daLookUp As SqlDataAdapter

    Dim VarTahun As String
    Dim VarBulan As String

    Dim err As String
    Dim isOK As Boolean = True

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

    Private Sub frmReportArusKas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        loadLookUp()
        'lookUpLoad()
    End Sub

    Private Sub loadLookUp()
        If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        daLookUp.Fill(dsLookUp, "LookPeriode")
        lookupBulanAwal.Properties.DataSource = dsLookUp.Tables("LookPeriode")
        lookupBulanAwal.Properties.DisplayMember = "nama"
        lookupBulanAwal.Properties.ValueMember = "thnbln"
    End Sub

    Sub lookUpLoad()
        daSal = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select A.kartu, A.bln_buku, A.thn_buku, A.kd_buku_besar, b.nm_buku_besar, A.kd_buku_pusat, c.nm_buku_pusat, A.status, a.jml_val_debet, a.jml_val_kredit from FIN.dbo.FIN_NERACA_SALDO A , SIF.dbo.SIF_buku_besar B, SIF.dbo.SIF_buku_pusat C where(a.kd_buku_besar = b.kd_buku_besar) and a.kd_buku_pusat = C.kd_buku_pusat ", sqlconn))
        daSal.Fill(dsSal, "_saldo")
        LookUpSaldo.Properties.DataSource = dsSal.Tables("_saldo")
        LookUpSaldo.Properties.ValueMember = "XXX"
        LookUpSaldo.Properties.DisplayMember = "XXX"
    End Sub

    Sub CetakLaporan(Optional ByVal tahun As String = "", Optional ByVal bulan As String = "", Optional ByVal thnbln As String = "", Optional ByVal Boll As Boolean = False)

        Try
            ErrorProvider1.Clear()
            If lookupBulanAwal.EditValue = vbNullString Then
                ErrorProvider1.SetError(lookupBulanAwal, "Pilih periode terlebih dahulu")
            ElseIf lookupBulanAwal.EditValue <> vbNullString Then
                callReport(App_Path() & "\report\CRArusKas.rpt", "", "thnbln=" & thnbln & "&tahun=" & tahun & "&bulan=" & bulan, Boll)
                ErrorProvider1.SetError(lookupBulanAwal, "")
            End If
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try

    End Sub

    Sub bersih()
        lookupBulanAwal.EditValue = vbNullString
    End Sub

    Public Sub cetak_click()
        CetakLaporan(VarTahun, VarBulan, lookupBulanAwal.EditValue)
    End Sub

    Private Sub cmdExe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExe.Click
        CetakLaporan(VarTahun, VarBulan, lookupBulanAwal.EditValue)
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        bersih()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        CetakLaporan(VarTahun, VarBulan, lookupBulanAwal.EditValue, "true")
    End Sub

    Private Sub lookupBulanAwal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookupBulanAwal.EditValueChanged
        VarTahun = Microsoft.VisualBasic.Left(lookupBulanAwal.EditValue, 4)
        VarBulan = Microsoft.VisualBasic.Right(lookupBulanAwal.EditValue, 2)
        'MsgBox(VarTahun)
        'MsgBox(VarBulan)
    End Sub
End Class