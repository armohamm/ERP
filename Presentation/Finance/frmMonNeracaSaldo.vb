'|-----------------------
'|  CREATED BY RENDY    |
'|  EDITED BY RENDY     |
'|-----------------------
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class frmMonNeracaSaldo
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = True
    Public prn As frmMain
    Dim err As String = ""
    Dim isvalid As Boolean

    Dim dsRekap, dsDetUt, dsLunas, dsValuta, dsSupp, dsSaldo, dsSalF As New DataSet
    Dim daRekap, daDetUt, daLunas, daValuta, daSupp, daSaldo, daSalF As SqlDataAdapter

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

    Private Sub frmMonNeracaSaldo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        BandedGV.BestFitColumns()

        txtThn.EditValue = Year(getTanggal())
        LookUpValuta.EditValue = "IDR"
        SaldoFull()
        valuta()

    End Sub

    Sub valuta()
        dsValuta.Clear()
        daValuta = New SqlDataAdapter(New SqlCommand("select Kode_Valuta, Nama_Valuta from KOPKAR.dbo.SIF_Valuta", sqlconn))
        daValuta.Fill(dsValuta, "Valuta")
        LookUpValuta.Properties.DataSource = dsValuta.Tables("Valuta")
        LookUpValuta.Properties.DisplayMember = "Nama_Valuta"
        LookUpValuta.Properties.ValueMember = "Kode_Valuta"
    End Sub


    Sub CekSaldo(Optional ByVal X As String = "", Optional ByVal Y As String = "")

        If Not dsSaldo.Tables("Saldo") Is Nothing Then dsSaldo.Tables("Saldo").Clear()

        daSaldo = New SqlDataAdapter(New SqlCommand("select X.kd_buku_besar , Y.nm_buku_besar , Y.tipe_rek , " & _
    "  (select nm_buku_besar from KOPKAR.dbo.m_buku_besar where kd_buku_besar = Y.grup_level1) as grup_level1, " & _
    "  (select isNull(SUM(jml_val_debet - jml_val_kredit ) ,0) " & _
    "  from FIN.dbo.FIN_NERACA_SALDO A  " & _
    "          where(bln_buku = 1) " & _
    "  and a.kd_buku_besar=x.kd_buku_besar  " & _
    "  ) as 'januari', " & _
    "  (select isNull(SUM(jml_val_debet - jml_val_kredit ) ,0) " & _
    "  from FIN.dbo.FIN_NERACA_SALDO A  " & _
    "          where(bln_buku = 2) " & _
    "  and a.kd_buku_besar=x.kd_buku_besar " & _
    "  ) as 'februari' , " & _
    "  (select isNull(SUM(jml_val_debet - jml_val_kredit ) ,0)  " & _
    "  from FIN.dbo.FIN_NERACA_SALDO A  " & _
    "          where(bln_buku = 3) " & _
    "  and a.kd_buku_besar=x.kd_buku_besar " & _
    "  ) as 'maret' , " & _
    "  (select isNull(SUM(jml_val_debet - jml_val_kredit ) ,0) " & _
    "  from FIN.dbo.FIN_NERACA_SALDO A " & _
    "        where(bln_buku = 4) " & _
    "  and a.kd_buku_besar=x.kd_buku_besar " & _
    "  ) as 'april' , " & _
    "  (select isNull(SUM(jml_val_debet - jml_val_kredit ) ,0)  " & _
    "  from FIN.dbo.FIN_NERACA_SALDO A  " & _
    "          where(bln_buku = 5) " & _
    "  and a.kd_buku_besar=x.kd_buku_besar " & _
    "  ) as 'mei' , " & _
    "  (select isNull(SUM(jml_val_debet - jml_val_kredit ) ,0)   " & _
    "  from FIN.dbo.FIN_NERACA_SALDO A" & _
    "          where(bln_buku = 6)" & _
    "  and a.kd_buku_besar=x.kd_buku_besar" & _
    "  ) as 'juni' , " & _
    "  (select isNull(SUM(jml_val_debet - jml_val_kredit ) ,0)   " & _
    "  from FIN.dbo.FIN_NERACA_SALDO A " & _
    "          where(bln_buku = 7) " & _
    "  and a.kd_buku_besar=x.kd_buku_besar " & _
    "  ) as 'juli' , " & _
    "  (select isNull(SUM(jml_val_debet - jml_val_kredit ) ,0) " & _
    "  from FIN.dbo.FIN_NERACA_SALDO A " & _
    "          where(bln_buku = 8)" & _
    "  and a.kd_buku_besar=x.kd_buku_besar" & _
    "  ) as 'agustus' ," & _
    "  (select isNull(SUM(jml_val_debet - jml_val_kredit ) ,0) " & _
    "  from FIN.dbo.FIN_NERACA_SALDO A " & _
    "          where(bln_buku = 9)" & _
    "  and a.kd_buku_besar=x.kd_buku_besar" & _
    "  ) as 'september'," & _
    "  (select isNull(SUM(jml_val_debet - jml_val_kredit ) ,0) " & _
    "  from FIN.dbo.FIN_NERACA_SALDO A " & _
    "          where(bln_buku = 10)" & _
    "  and a.kd_buku_besar=x.kd_buku_besar" & _
    "  ) as 'oktober' , " & _
    "  (select isNull(SUM(jml_val_debet - jml_val_kredit ) ,0) " & _
    "  from FIN.dbo.FIN_NERACA_SALDO A " & _
    "          where(bln_buku = 11)" & _
    "  and a.kd_buku_besar=x.kd_buku_besar" & _
    "  ) as 'november' , " & _
    "  (select isNull(SUM(jml_val_debet - jml_val_kredit ) ,0) " & _
    "  from FIN.dbo.FIN_NERACA_SALDO A " & _
    "          where(bln_buku = 12)" & _
    "  and a.kd_buku_besar=x.kd_buku_besar" & _
    "  ) as 'desember' " & _
    "  from KOPKAR.dbo.FIN_NERACA_SALDO X , KOPKAR.dbo.m_buku_besar Y" & _
    "  where thn_buku= '" & X & "' " & _
    "  and X.kd_valuta = '" & Y & "'  " & _
    "  and X.kd_buku_besar = Y.kd_buku_besar " & _
    "  group by X.kd_buku_besar , Y.nm_buku_besar , Y.tipe_rek , Y.grup_level1 ", sqlconn))


        daSaldo.Fill(dsSaldo, "Saldo")
        GC.DataSource = dsSaldo.Tables("Saldo")
        BandedGV.BestFitColumns()
    End Sub

    Sub SaldoFull()
        daSalF = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select A.kartu, A.bln_buku, A.thn_buku, A.kd_buku_besar, b.nm_buku_besar, A.kd_buku_pusat, c.nm_buku_pusat, A.status, a.jml_val_debet, a.jml_val_kredit from KOPKAR.dbo.FIN_NERACA_SALDO A , KOPKAR.dbo.m_buku_besar B, KOPKAR.dbo.SIF_buku_pusat C where(a.kd_buku_besar = b.kd_buku_besar) and a.kd_buku_pusat = C.kd_buku_pusat ", sqlconn))
        daSalF.Fill(dsSalF, "_saldo")
        LookUpSaldo.Properties.DataSource = dsSalF.Tables("_saldo")
        LookUpSaldo.Properties.ValueMember = "XXX"
        LookUpSaldo.Properties.DisplayMember = "XXX"

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        ErrorProvider1.Clear()

        If txtThn.EditValue = vbNullString Then
            ErrorProvider1.SetError(txtThn, "Tahun Tidak Boleh Kosong")

        ElseIf LookUpValuta.EditValue = vbNullString Then
            ErrorProvider1.SetError(LookUpValuta, "Valuta Tidak Boleh Kosong")
        Else
            CekSaldo(txtThn.EditValue, LookUpValuta.EditValue)
        End If
    End Sub

    'Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
    '    CekSaldo("2011", "IDR")
    'End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtThn.EditValue = Year(getTanggal())
        LookUpSaldo.EditValue = vbNullString
        LookUpValuta.EditValue = "IDR"
        dsSaldo.Clear()
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
End Class