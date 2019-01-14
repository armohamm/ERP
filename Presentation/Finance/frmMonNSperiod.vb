'|-----------------------
'|  CREATED BY RENDY    |
'|  EDITED BY RENDY     |
'|-----------------------
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class frmMonNSperiod
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = True
    Public prn As frmMain
    Dim err, milih As String
    Dim isvalid As Boolean

    Dim dsRekap, dsDetUt, dsLunas, dsValuta, dsSupp, dsSaldo, dsSalF, dsLookUp As New DataSet
    Dim daRekap, daDetUt, daLunas, daValuta, daSupp, daSaldo, daSalF, daLookUp As SqlDataAdapter

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnDelete = True
        btnCancel = True
        setStatus()
        'STATE = "ADD" '<-- set state add

    End Sub

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

    Private Sub frmMonNSperiod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        BandedGV.BestFitColumns()
        'SaldoFull()
        loadLookUp()
        lookupBulanAwal.EditValue = CStr(Year(getTanggal())) + IIf(Microsoft.VisualBasic.Len(CStr(Month(getTanggal()))) = 1, "0" + CStr(Month(getTanggal())), CStr(Month(getTanggal())))
    End Sub

    Private Sub loadLookUp()
        If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM KOPKAR.dbo.SIF_Periode_Buku", sqlconn))
        daLookUp.Fill(dsLookUp, "LookPeriode")
        lookupBulanAwal.Properties.DataSource = dsLookUp.Tables("LookPeriode")
        lookupBulanAwal.Properties.DisplayMember = "nama"
        lookupBulanAwal.Properties.ValueMember = "thnbln"
    End Sub

    Sub CekSaldoCari(Optional ByVal XY As String = "")
        dsSaldo.Clear()
        'dsSaldo.Tables("SaldoCari").Clear()

        daSaldo = New SqlDataAdapter(New SqlCommand("select a.kd_buku_besar,b.nm_buku_besar,  " & _
    "  (select isnull(sum(b.jml_val_debet-b.jml_val_kredit),0)  " & _
    "  from  FIN_NERACA_SALDO b  " & _
    "  where b.thn_buku+b.bln_buku < " & XY & " and b.kd_buku_besar=a.kd_buku_besar) as saldo_awal,  " & _
    "  (select isnull(sum(dd.jml_val_debet),0)  " & _
    "  from  FIN_NERACA_SALDO dd   " & _
    "  where dd.thn_buku+dd.bln_buku = " & XY & " and dd.kd_buku_besar=a.kd_buku_besar) as debet,  " & _
    "  (select isnull(sum(kk.jml_val_kredit),0)  " & _
    "  from  FIN_NERACA_SALDO kk   " & _
    "  where kk.thn_buku+kk.bln_buku = " & XY & " and kk.kd_buku_besar=a.kd_buku_besar) as kredit,  " & _
    "  sum(a.jml_val_debet-a.jml_val_kredit) saldo_akhir  " & _
    "  from FIN_NERACA_SALDO a , m_buku_besar b  " & _
    "  where(a.kd_buku_besar = b.kd_buku_besar)  " & _
    "  and a.thn_buku+a.bln_buku = " & XY & "  " & _
    "  group by a.kd_buku_besar,b.nm_buku_besar", sqlconn))

        daSaldo.Fill(dsSaldo, "SaldoCari")
        GC.DataSource = dsSaldo.Tables("SaldoCari")
        BandedGV.BestFitColumns()
    End Sub

    Sub CekSaldoAll()
        dsSaldo.Clear()
        'dsSaldo.Tables("SaldoAll").Clear()

        daSaldo = New SqlDataAdapter(New SqlCommand("select a.kd_buku_besar,b.nm_buku_besar,  " & _
        "  (select isnull(sum(b.jml_val_debet-b.jml_val_kredit),0)  " & _
        "  from  FIN_NERACA_SALDO b   " & _
        "  where b.kd_buku_besar=a.kd_buku_besar) as saldo_awal,  " & _
        "  (select isnull(sum(dd.jml_val_debet),0)  " & _
        "  from  FIN_NERACA_SALDO dd   " & _
        "  where dd.kd_buku_besar=a.kd_buku_besar) as debet,  " & _
        "  (select isnull(sum(kk.jml_val_kredit),0)  " & _
        "  from  FIN_NERACA_SALDO kk   " & _
        "  where kk.kd_buku_besar=a.kd_buku_besar) as kredit,  " & _
        "  sum(a.jml_val_debet-a.jml_val_kredit) saldo_akhir  " & _
        "  from  FIN_NERACA_SALDO a ,  m_buku_besar b  " & _
        "  where(a.kd_buku_besar = b.kd_buku_besar)  " & _
        "  group by a.kd_buku_besar,b.nm_buku_besar ", sqlconn))

        daSaldo.Fill(dsSaldo, "SaldoAll")
        GC.DataSource = dsSaldo.Tables("SaldoAll")
        BandedGV.BestFitColumns()
    End Sub

    Sub SaldoFull()
        daSalF = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select A.kartu, A.bln_buku, A.thn_buku, A.kd_buku_besar, b.nm_buku_besar, A.kd_buku_pusat, c.nm_buku_pusat, A.status, a.jml_val_debet, a.jml_val_kredit from  FIN_NERACA_SALDO A ,  m_buku_besar B,  SIF_buku_pusat C where(a.kd_buku_besar = b.kd_buku_besar) and a.kd_buku_pusat = C.kd_buku_pusat ", sqlconn))
        daSalF.Fill(dsSalF, "_saldo")
        LookUpSaldo.Properties.DataSource = dsSalF.Tables("_saldo")
        LookUpSaldo.Properties.ValueMember = "XXX"
        LookUpSaldo.Properties.DisplayMember = "XXX"

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        ErrorProvider1.Clear()

        If lookupBulanAwal.EditValue = vbNullString Then
            ErrorProvider1.SetError(lookupBulanAwal, "Periode Tidak Boleh Kosong")
        Else
            'CekSaldoCari(txtThn.EditValue, txtBulan.EditValue)
            CekSaldoCari(lookupBulanAwal.EditValue)
        End If
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtThn.EditValue = vbNullString
        txtBulan.EditValue = vbNullString
        LookUpSaldo.EditValue = vbNullString
        dsSaldo.Clear()
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        CekSaldoCari(lookupBulanAwal.EditValue)
    End Sub

    Sub ShowGridPreview(ByVal grid As DevExpress.XtraGrid.GridControl)
        ' Check whether the XtraGrid control can be previewed. 
        If Not grid.IsPrintingAvailable Then
            MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error")
            Return
        End If
        ' Opens the Preview window. 
        grid.ShowPreview()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        'ShowGridPreview(BandedGV.GridControl)
        ShowGridPreview(GC)
    End Sub

    Public Sub cetak_click()
        ShowGridPreview(GC)
    End Sub

    'Private Sub lookupBulanAwal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookupBulanAwal.EditValueChanged
    '    Dim tahun As String = Microsoft.VisualBasic.Left(lookupBulanAwal.EditValue, 4)
    '    Dim bulan As String = Microsoft.VisualBasic.Right(lookupBulanAwal.EditValue, 2)
    'End Sub

    Private Sub BandedGV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles BandedGV.DoubleClick
        milih = BandedGV.GetFocusedRowCellValue("kd_buku_besar").ToString()

        aFormViewJurnalDetil.cariJurnal(milih, lookupBulanAwal.EditValue)
        aFormViewJurnalDetil.ShowDialog()
    End Sub
End Class