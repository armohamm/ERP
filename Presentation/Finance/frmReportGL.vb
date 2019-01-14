'|-----------------------
'|  CREATED BY RENDY    |
'|  EDITED BY RENDY     |
'|-----------------------
Imports System.Data.SqlClient
Public Class frmReportGL
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = True
    Public prn As frmMain

    Dim dsLookUPValuta, dsLookUpRek, dsSal As New DataSet
    Dim daLookUPValuta, daLookUpRek, daSal As SqlDataAdapter

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

    Private Sub frmReportGL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True

        lookUpLoad()

        lookPeriode.EditValue = CStr(Year(getTanggal())) + IIf(Microsoft.VisualBasic.Len(CStr(Month(getTanggal()))) = 1, "0" + CStr(Month(getTanggal())), CStr(Month(getTanggal())))
        lookVal.EditValue = "IDR"
        lookRekening.EditValue = ""
    End Sub

    Sub CekSaldoAwal()
        txtSaldoAwal.EditValue = 0
        Try
            'Dim dr2 As SqlDataReader = New SqlCommand("Select SUM(jml_val_debet - jml_val_kredit) from FIN.dbo.FIN_NERACA_SALDO where kd_buku_besar like '%" & lookRekening.EditValue & "%' and kd_valuta like '%" & lookVal.EditValue & "%' and thn_buku like '%" & tglDari.DateTime.Year & "%' and bln_buku like '%" & tglDari.DateTime.Month - 1 & "%'", sqlconn).ExecuteReader
            Dim dr2 As SqlDataReader = New SqlCommand("SELECT ISNULL(SUM(jml_val_debet - jml_val_kredit),0) FROM FIN.dbo.FIN_NERACA_SALDO WHERE kd_buku_besar LIKE '%" & lookRekening.EditValue & "%' AND kd_valuta = '" & lookVal.EditValue & "' AND thn_buku = '" & Microsoft.VisualBasic.Left(lookPeriode.EditValue, 4) & "' AND bln_buku <= " & CInt(Microsoft.VisualBasic.Right(lookPeriode.EditValue, 2)) - 1, sqlconn).ExecuteReader
            dr2.Read()
            If dr2.HasRows Then
                txtSaldoAwal.EditValue = dr2.Item(0)
            End If
            dr2.Close()
        Catch ex As Exception
            txtSaldoAwal.EditValue = 0
        End Try
    End Sub

    'Sub CekSaldoAwalTgl()
    '    Try
    '        Dim dr2 As SqlDataReader = New SqlCommand("Select SUM(jml_val_debet - jml_val_kredit) from FIN.dbo.FIN_NERACA_SALDO  where thn_buku = '" & tglDari.DateTime.Year & "' and bln_buku = '" & tglDari.DateTime.Month - 1 & "'", sqlconn).ExecuteReader
    '        dr2.Read()
    '        If dr2.HasRows Then
    '            txtSaldoAwal.EditValue = dr2.Item(0)
    '        End If
    '        Dim f As Long
    '        f = txtSaldoAwal.EditValue
    '        'txtSaldoAwal.EditValue = Format(f, "##,##0")
    '        dr2.Close()
    '    Catch ex As Exception
    '        txtSaldoAwal.EditValue = 0
    '    End Try

    'End Sub

    'Sub CekSaldoAwalVal()
    '    Try
    '        Dim dr2 As SqlDataReader = New SqlCommand("Select SUM(jml_val_debet - jml_val_kredit) from FIN.dbo.FIN_NERACA_SALDO  where kd_valuta = '" & lookVal.EditValue & "' ", sqlconn).ExecuteReader
    '        dr2.Read()
    '        If dr2.HasRows Then
    '            txtSaldoAwal.EditValue = dr2.Item(0)
    '        End If
    '        Dim f As Long
    '        f = txtSaldoAwal.EditValue
    '        'txtSaldoAwal.EditValue = Format(f, "##,##0")
    '        dr2.Close()
    '    Catch ex As Exception
    '        txtSaldoAwal.EditValue = 0
    '    End Try

    'End Sub

    Sub lookUpLoad()
        If Not dsLookUPValuta.Tables("Valuta") Is Nothing Then dsLookUPValuta.Tables("Valuta").Clear()
        If Not dsLookUpRek.Tables("Rekening") Is Nothing Then dsLookUpRek.Tables("Rekening").Clear()
        If Not dsLookUpRek.Tables("Periode") Is Nothing Then dsLookUpRek.Tables("Periode").Clear()

        daLookUPValuta = New SqlDataAdapter(New SqlCommand("select Kode_Valuta, Nama_Valuta from SIF.dbo.SIF_Valuta", sqlconn))
        daLookUPValuta.Fill(dsLookUPValuta, "Valuta")
        lookVal.Properties.DataSource = dsLookUPValuta.Tables("Valuta")
        lookVal.Properties.DisplayMember = "Nama_Valuta"
        lookVal.Properties.ValueMember = "Kode_Valuta"

        daLookUpRek = New SqlDataAdapter(New SqlCommand("SELECT kd_buku_besar, nm_buku_besar FROM SIF.dbo.SIF_buku_besar WHERE grup_header='D' UNION ALL SELECT '', '[Semua Rekening]'", sqlconn))
        daLookUpRek.Fill(dsLookUpRek, "Rekening")
        lookRekening.Properties.DataSource = dsLookUpRek.Tables("Rekening")
        lookRekening.Properties.DisplayMember = "nm_buku_besar"
        lookRekening.Properties.ValueMember = "kd_buku_besar"

        daLookUpRek = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku as kode, nama_bulan + ' ' + thn_buku as nama FROM SIF.dbo.SIF_periode_buku", sqlconn))
        daLookUpRek.Fill(dsLookUpRek, "Periode")
        lookPeriode.Properties.DataSource = dsLookUpRek.Tables("Periode")
        lookPeriode.Properties.DisplayMember = "nama"
        lookPeriode.Properties.ValueMember = "kode"

        daSal = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select A.kartu, A.bln_buku, A.thn_buku, A.kd_buku_besar, b.nm_buku_besar, A.kd_buku_pusat, c.nm_buku_pusat, A.status, a.jml_val_debet, a.jml_val_kredit from FIN.dbo.FIN_NERACA_SALDO A , SIF.dbo.SIF_buku_besar B, SIF.dbo.SIF_buku_pusat C where(a.kd_buku_besar = b.kd_buku_besar) and a.kd_buku_pusat = C.kd_buku_pusat ", sqlconn))
        daSal.Fill(dsSal, "_saldo")
        LookUpSaldo.Properties.DataSource = dsSal.Tables("_saldo")
        LookUpSaldo.Properties.ValueMember = "XXX"
        LookUpSaldo.Properties.DisplayMember = "XXX"
    End Sub

    'Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
    '    lookVal.EditValue = vbNullString
    '    lookRekening.EditValue = vbNullString
    '    tglDari.EditValue = vbNullString
    '    txtSaldoAwal.EditValue = vbNullString
    '    txtModulSaldoAwal.EditValue = vbNullString
    'End Sub

    'Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
    '    If lookVal.EditValue <> vbNullString And lookRekening.EditValue = vbNullString And tglDari.EditValue = vbNullString Then
    '        CekSaldoAwalVal()
    '    ElseIf lookVal.EditValue = vbNullString And lookRekening.EditValue = vbNullString And tglDari.EditValue <> vbNullString Then
    '        CekSaldoAwalTgl()
    '    Else
    '        CekSaldoAwal()
    '    End If
    '    CetakLaporan(lookVal.EditValue, lookRekening.EditValue, txtSaldoAwal.EditValue, tglDari.EditValue, "true")
    'End Sub

    'Sub ModulCetakSaldoAwal()
    '    txtModulSaldoAwal.EditValue = "0"

    '    Dim dr As SqlDataReader = New SqlCommand("SELECT SIF.dbo.hitungsaldoawal('" & lookRekening.EditValue & "', 'IDR','" & tglDari.DateTime.Year & "', '" & tglDari.DateTime.Month & "', '" & tglDari.DateTime.Day & "')", sqlconn).ExecuteReader
    '    dr.Read()
    '    If dr.HasRows Then
    '        txtModulSaldoAwal.EditValue = dr.Item(0)

    '        Dim g As Long
    '        g = txtModulSaldoAwal.EditValue
    '        'txtModulSaldoAwal.EditValue = Format(g, "##,##0")
    '    Else
    '        txtModulSaldoAwal.EditValue = "0"
    '    End If

    '    dr.Close()
    'End Sub

    'Private Sub cmdExe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExe.Click
    '    If lookVal.EditValue <> vbNullString And lookRekening.EditValue = vbNullString And tglDari.EditValue = vbNullString Then
    '        CekSaldoAwalVal()
    '    ElseIf lookVal.EditValue = vbNullString And lookRekening.EditValue = vbNullString And tglDari.EditValue <> vbNullString Then
    '        CekSaldoAwalTgl()
    '    Else
    '        CekSaldoAwal()
    '        ModulCetakSaldoAwal()
    '    End If
    '    'CetakLaporan(lookVal.EditValue, lookRekening.EditValue, txtSaldoAwal.EditValue, Format(tglDari.EditValue, "MM/dd/yyyy"), "false")
    '    CetakLaporan(lookVal.EditValue, lookRekening.EditValue, txtModulSaldoAwal.EditValue, Format(tglDari.EditValue, "MM/dd/yyyy"), False)
    'End Sub

    Public Sub cetak_click()
        'If Not tglDari.EditValue = vbNullString Then
        '    callReport(App_Path() & "\report\CRGL1Tgl.rpt", "", "&tgl_trans=" & tglDari.EditValue & "&saldo_awal=" & txtSaldoAwal.EditValue, False)
        'End If
        'CekSaldoAwal()
        'If Not lookRekening.EditValue = vbNullString Then

        'Else
        '    MsgBox("Rekening tolong diisi terlebih dahulu.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
        '    Exit Sub
        'End If
        Try
            callReport(App_Path() & "\report\CRGL2.rpt", "", "valuta=" & lookVal.EditValue & "&rekening=" & lookRekening.EditValue & "&saldo_awal=" & txtSaldoAwal.EditValue & "&periode=" & lookPeriode.EditValue, False)
        Catch ex As Exception
            MsgBox("Error Program." & vbCrLf & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR")
        End Try
    End Sub

    'Sub CetakLaporan(Optional ByVal Vall As String = "", Optional ByVal Rekk As String = "", Optional ByVal Sall As Integer = 0, Optional ByVal Tgll As String = "", Optional ByVal Boll As Boolean = False)
    '    'CekSaldoAwal()
    '    'MsgBox(txtSaldoAwal.EditValue)
    '    ErrorProvider1.Clear()

    '    If tglDari.EditValue <> vbNullString And lookVal.EditValue = vbNullString And lookRekening.EditValue = vbNullString Then
    '        MsgBox("Tanggal yang diinputkan : " & Tgll)
    '        callReport(App_Path() & "\report\CRGL1Tgl.rpt", "", "&tgl_trans=" & Tgll & "&saldo_awal=" & Sall, Boll)
    '    End If

    '    If lookVal.EditValue <> vbNullString And tglDari.EditValue = vbNullString And lookRekening.EditValue = vbNullString Then
    '        MsgBox("Valuta yang diinputkan : " & Vall)
    '        callReport(App_Path() & "\report\CRGL1Valuta.rpt", "", "&valuta=" & Vall & "&saldo_awal=" & Sall, Boll)
    '    End If

    '    If lookVal.EditValue <> vbNullString And lookRekening.EditValue <> vbNullString And tglDari.EditValue <> vbNullString Then
    '        MsgBox("Data yang diinputkan : " & Vall & " " & Rekk & " " & Tgll & " " & Sall)
    '        callReport(App_Path() & "\report\CRGL1.rpt", "", "&valuta=" & Vall & "&rekening=" & Rekk & "&saldo_awal=" & Sall & "&tgl_trans=" & Tgll, Boll)
    '    End If

    'End Sub

    Private Sub lookPeriode_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lookPeriode.EditValueChanged
        If Not (lookRekening.EditValue = vbNullString And lookVal.EditValue = vbNullString) Then
            CekSaldoAwal()
        End If
    End Sub

    Private Sub lookRekening_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lookRekening.EditValueChanged
        If Not (lookPeriode.EditValue = vbNullString And lookVal.EditValue = vbNullString) Then
            CekSaldoAwal()
        End If
    End Sub

    Private Sub lookVal_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lookVal.EditValueChanged
        If Not (lookPeriode.EditValue = vbNullString And lookRekening.EditValue = vbNullString) Then
            CekSaldoAwal()
        End If
    End Sub
End Class