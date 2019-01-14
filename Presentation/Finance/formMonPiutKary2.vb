'tgl 19/06/2015
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports System.Drawing
Imports DevExpress.XtraPrinting

Public Class formMonPiutKary2
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = True
    Public prn As frmMain
    Dim dsPiut, dsDetil, dsLunas, dsLookUp, dsGiro As New DataSet
    Dim daLookKar, daLookBB, daLookKartu, daLookKartu1, daPiut, daPiutCari, daDetil, daDetilCari, daLunas, daLunasCari, daGiroCari As SqlDataAdapter
    Dim err As String
    Dim isSearch As Boolean = True
    Dim kodeKary As String = ""
    Dim kodeInvo As String = ""
    Dim kodetrans As String = ""
    Dim jumlah As String

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

    Private Sub loadLookUp()
        dsLookUp = New DataSet
        daLookBB = New SqlDataAdapter(New SqlCommand("SELECT Id_Data, Desc_Data FROM SIF.dbo.SIF_Gen_Reff_D WHERE Id_Ref_File = 'JNSINV'", sqlconn))
        daLookBB.Fill(dsLookUp, "LookBB")
        lookBB.DataSource = dsLookUp.Tables("LookBB")
        lookBB.DisplayMember = "Desc_Data"
        lookBB.ValueMember = "Id_Data"

        daLookKartu = New SqlDataAdapter(New SqlCommand("SELECT Kode_Pegawai, Nama_Pegawai FROM SIF.dbo.SIF_Pegawai where rec_stat = 'Y'", sqlconn))
        daLookKartu.Fill(dsLookUp, "LookKartu")
        lookKartu.DataSource = dsLookUp.Tables("LookKartu")
        lookKartu.DisplayMember = "Nama_Pegawai"
        lookKartu.ValueMember = "Kode_Pegawai"

        daLookKar = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT b.kd_cust, a.Nama_Pegawai FROM SIF.dbo.SIF_Pegawai a, FIN.dbo.FIN_NOTA b WHERE a.Kode_Pegawai=b.kd_cust AND b.tipe_trans LIKE 'JKK%' AND jml_akhir > 0 UNION SELECT '00000', '[Semua Karyawan]'", sqlconn))
        daLookKar.Fill(dsLookUp, "LookKar")
        lueKaryawan.Properties.DataSource = dsLookUp.Tables("LookKar")
        lueKaryawan.Properties.DisplayMember = "Nama_Pegawai"
        lueKaryawan.Properties.ValueMember = "kd_cust"
    End Sub

    Private Sub loadPiutang()
        dsPiut = New DataSet
        If Not dsPiut.Tables.Count <= 0 Then dsPiut.Tables.Clear()
        If txtNoTrans.Text = "" Then
            If chkAll.Checked Then
                If chkPosting.Checked Then
                    If lueKaryawan.EditValue = "00000" Or lueKaryawan.EditValue = vbNullString Then
                        daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', kd_cust, SUM(jml_tagihan) jml_tagihan, SUM(jml_bayar) jml_bayar, SUM(jml_total) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JKK-KPT-01' AND tgl_posting BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY kd_cust", sqlconn))
                    Else
                        daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', kd_cust, SUM(jml_tagihan) jml_tagihan, SUM(jml_bayar) jml_bayar, SUM(jml_total) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JKK-KPT-01' AND kd_cust LIKE '%" & lueKaryawan.EditValue & "%' AND tgl_posting BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY kd_cust", sqlconn))
                    End If
                Else
                    If lueKaryawan.EditValue = "00000" Or lueKaryawan.EditValue = vbNullString Then
                        daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY k.kd_cust) as 'nomer', k.kd_cust, SUM(k.jml_tagihan) jml_tagihan, SUM(k.jml_bayar) jml_bayar, SUM(k.sisa) sisa FROM (SELECT DISTINCT a.kd_cust, SUM(a.jml_tagihan) jml_tagihan, (SELECT ISNULL(SUM(x.jml_bayar),0) jmlbayar FROM FIN.dbo.FIN_NOTA_LUNAS_D x, FIN.dbo.FIN_NOTA y, FIN.dbo.FIN_NOTA_LUNAS z WHERE x.prev_no_inv = y.no_inv AND x.no_trans = z.no_trans AND z.kd_kartu = a.kd_cust AND x.prev_no_inv = a.no_inv) jml_bayar, SUM(a.jml_tagihan) - (SELECT ISNULL(SUM(x.jml_bayar),0) jmlbayar FROM FIN.dbo.FIN_NOTA_LUNAS_D x, FIN.dbo.FIN_NOTA y, FIN.dbo.FIN_NOTA_LUNAS z WHERE x.prev_no_inv = y.no_inv AND x.no_trans = z.no_trans AND z.kd_kartu = a.kd_cust AND x.prev_no_inv = a.no_inv) 'sisa' FROM FIN.dbo.FIN_NOTA a WHERE a.tipe_trans LIKE 'JKK-KPT-01' AND a.tgl_inv BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) GROUP BY a.no_inv, a.kd_cust) k GROUP BY k.kd_cust", sqlconn))
                    Else
                        daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY k.kd_cust) as 'nomer', k.kd_cust, SUM(k.jml_tagihan) jml_tagihan, SUM(k.jml_bayar) jml_bayar, SUM(k.sisa) sisa FROM (SELECT DISTINCT a.kd_cust, SUM(a.jml_tagihan) jml_tagihan, (SELECT ISNULL(SUM(x.jml_bayar),0) jmlbayar FROM FIN.dbo.FIN_NOTA_LUNAS_D x, FIN.dbo.FIN_NOTA y, FIN.dbo.FIN_NOTA_LUNAS z WHERE x.prev_no_inv = y.no_inv AND x.no_trans = z.no_trans AND z.kd_kartu = a.kd_cust AND x.prev_no_inv = a.no_inv) jml_bayar, SUM(a.jml_tagihan) - (SELECT ISNULL(SUM(x.jml_bayar),0) jmlbayar FROM FIN.dbo.FIN_NOTA_LUNAS_D x, FIN.dbo.FIN_NOTA y, FIN.dbo.FIN_NOTA_LUNAS z WHERE x.prev_no_inv = y.no_inv AND x.no_trans = z.no_trans AND z.kd_kartu = a.kd_cust AND x.prev_no_inv = a.no_inv) 'sisa' FROM FIN.dbo.FIN_NOTA a WHERE a.tipe_trans LIKE 'JKK-KPT-01' AND a.tgl_inv BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) AND a.kd_cust = '" & lueKaryawan.EditValue & "' GROUP BY a.no_inv, a.kd_cust) k GROUP BY k.kd_cust", sqlconn))
                    End If
                End If
            Else '#################################################################################################
                If chkPosting.Checked Then
                    If lueKaryawan.EditValue = "00000" Or lueKaryawan.EditValue = vbNullString Then
                        daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', kd_cust, SUM(jml_tagihan) jml_tagihan, SUM(jml_bayar) jml_bayar, SUM(jml_total) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JKK-KPT-01' AND jml_akhir > 0 AND tgl_posting BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY kd_cust", sqlconn))
                    Else
                        daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', kd_cust, SUM(jml_tagihan) jml_tagihan, SUM(jml_bayar) jml_bayar, SUM(jml_total) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JKK-KPT-01' AND kd_cust LIKE '%" & lueKaryawan.EditValue & "%' AND jml_akhir > 0 AND tgl_posting BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY kd_cust", sqlconn))
                    End If
                Else
                    If lueKaryawan.EditValue = "00000" Or lueKaryawan.EditValue = vbNullString Then
                        daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY k.kd_cust) as 'nomer', k.kd_cust, SUM(k.jml_tagihan) jml_tagihan, SUM(k.jml_bayar) jml_bayar, SUM(k.sisa) sisa FROM (SELECT DISTINCT a.kd_cust, SUM(a.jml_tagihan) jml_tagihan, (SELECT ISNULL(SUM(x.jml_bayar),0) jmlbayar FROM FIN.dbo.FIN_NOTA_LUNAS_D x, FIN.dbo.FIN_NOTA y, FIN.dbo.FIN_NOTA_LUNAS z WHERE x.prev_no_inv = y.no_inv AND x.no_trans = z.no_trans AND z.kd_kartu = a.kd_cust AND x.prev_no_inv = a.no_inv) jml_bayar, SUM(a.jml_tagihan) - (SELECT ISNULL(SUM(x.jml_bayar),0) jmlbayar FROM FIN.dbo.FIN_NOTA_LUNAS_D x, FIN.dbo.FIN_NOTA y, FIN.dbo.FIN_NOTA_LUNAS z WHERE x.prev_no_inv = y.no_inv AND x.no_trans = z.no_trans AND z.kd_kartu = a.kd_cust AND x.prev_no_inv = a.no_inv) 'sisa' FROM FIN.dbo.FIN_NOTA a WHERE a.tipe_trans LIKE 'JKK-KPT-01' AND a.jml_total > 0 AND a.tgl_inv BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) GROUP BY a.no_inv, a.kd_cust) k GROUP BY k.kd_cust", sqlconn))
                    Else
                        daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY k.kd_cust) as 'nomer', k.kd_cust, SUM(k.jml_tagihan) jml_tagihan, SUM(k.jml_bayar) jml_bayar, SUM(k.sisa) sisa FROM (SELECT DISTINCT a.kd_cust, SUM(a.jml_tagihan) jml_tagihan, (SELECT ISNULL(SUM(x.jml_bayar),0) jmlbayar FROM FIN.dbo.FIN_NOTA_LUNAS_D x, FIN.dbo.FIN_NOTA y, FIN.dbo.FIN_NOTA_LUNAS z WHERE x.prev_no_inv = y.no_inv AND x.no_trans = z.no_trans AND z.kd_kartu = a.kd_cust AND x.prev_no_inv = a.no_inv) jml_bayar, SUM(a.jml_tagihan) - (SELECT ISNULL(SUM(x.jml_bayar),0) jmlbayar FROM FIN.dbo.FIN_NOTA_LUNAS_D x, FIN.dbo.FIN_NOTA y, FIN.dbo.FIN_NOTA_LUNAS z WHERE x.prev_no_inv = y.no_inv AND x.no_trans = z.no_trans AND z.kd_kartu = a.kd_cust AND x.prev_no_inv = a.no_inv) 'sisa' FROM FIN.dbo.FIN_NOTA a WHERE a.tipe_trans LIKE 'JKK-KPT-01' AND a.jml_total > 0 AND a.tgl_inv BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) AND a.kd_cust = '" & lueKaryawan.EditValue & "' GROUP BY a.no_inv, a.kd_cust) k GROUP BY k.kd_cust", sqlconn))
                    End If
                End If
            End If
        Else
            daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', kd_cust, SUM(jml_tagihan) jml_tagihan, SUM(jml_bayar) jml_bayar, SUM(jml_total) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE no_inv LIKE '%" & txtNoTrans.EditValue & "%' GROUP BY kd_cust", sqlconn))
        End If
        daPiut.Fill(dsPiut, "Piutang")
        gcPiutang.DataSource = dsPiut.Tables("Piutang")
        gvPiutang.BestFitColumns()
    End Sub

    Private Sub loadDetil(Optional ByVal kodeKar As String = "")
        dsDetil = New DataSet
        If Not dsDetil.Tables.Count <= 0 Then dsDetil.Tables.Clear()
        If txtNoTrans.Text = "" Then
            If chkAll.Checked Then
                If chkPosting.Checked Then
                    daDetilCari = New SqlDataAdapter(New SqlCommand("SELECT no_inv, tgl_inv, no_jurnal, tgl_posting, keterangan, jml_tagihan, jml_bayar, jml_total, kd_cust FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JKK-KPT-01' AND kd_cust='" & kodeKar & "' AND tgl_posting BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') ORDER BY tgl_inv DESC", sqlconn))
                Else
                    daDetilCari = New SqlDataAdapter(New SqlCommand("SELECT a.no_inv, a.tgl_inv, a.no_jurnal, a.tgl_posting, a.keterangan, a.jml_tagihan, (SELECT ISNULL(SUM(x.jml_bayar),0) FROM FIN.dbo.FIN_NOTA_LUNAS_D x, FIN.dbo.FIN_NOTA y, FIN.dbo.FIN_NOTA_LUNAS z WHERE x.prev_no_inv = y.no_inv AND x.no_trans = z.no_trans AND z.kd_kartu = a.kd_cust AND x.prev_no_inv = a.no_inv) jml_bayar, a.jml_tagihan - (SELECT ISNULL(SUM(x.jml_bayar),0) FROM FIN.dbo.FIN_NOTA_LUNAS_D x, FIN.dbo.FIN_NOTA y, FIN.dbo.FIN_NOTA_LUNAS z WHERE x.prev_no_inv = y.no_inv AND x.no_trans = z.no_trans AND z.kd_kartu = a.kd_cust AND x.prev_no_inv = a.no_inv) jml_total, a.kd_cust FROM FIN.dbo.FIN_NOTA a WHERE a.tipe_trans LIKE 'JKK-KPT-01' AND a.kd_cust='" & kodeKar & "' AND a.tgl_inv BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) ORDER BY tgl_inv DESC", sqlconn))
                End If
            Else
                If chkPosting.Checked Then
                    daDetilCari = New SqlDataAdapter(New SqlCommand("SELECT no_inv, tgl_inv, no_jurnal, tgl_posting, keterangan, jml_tagihan, jml_bayar, jml_total, kd_cust FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JKK-KPT-01' AND kd_cust='" & kodeKar & "' AND jml_total > 0 AND tgl_posting BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') ORDER BY tgl_inv DESC", sqlconn))
                Else
                    daDetilCari = New SqlDataAdapter(New SqlCommand("SELECT a.no_inv, a.tgl_inv, a.no_jurnal, a.tgl_posting, a.keterangan, a.jml_tagihan, (SELECT ISNULL(SUM(x.jml_bayar),0) FROM FIN.dbo.FIN_NOTA_LUNAS_D x, FIN.dbo.FIN_NOTA y, FIN.dbo.FIN_NOTA_LUNAS z WHERE x.prev_no_inv = y.no_inv AND x.no_trans = z.no_trans AND z.kd_kartu = a.kd_cust AND x.prev_no_inv = a.no_inv) jml_bayar, a.jml_tagihan - (SELECT ISNULL(SUM(x.jml_bayar),0) FROM FIN.dbo.FIN_NOTA_LUNAS_D x, FIN.dbo.FIN_NOTA y, FIN.dbo.FIN_NOTA_LUNAS z WHERE x.prev_no_inv = y.no_inv AND x.no_trans = z.no_trans AND z.kd_kartu = a.kd_cust AND x.prev_no_inv = a.no_inv) jml_total, a.kd_cust FROM FIN.dbo.FIN_NOTA a WHERE a.tipe_trans LIKE 'JKK-KPT-01' AND a.kd_cust='" & kodeKar & "' AND jml_total > 0 AND a.tgl_inv BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) ORDER BY a.tgl_inv DESC", sqlconn))
                End If
            End If
        Else
            daDetilCari = New SqlDataAdapter(New SqlCommand("SELECT no_inv, tgl_inv, no_jurnal, tgl_posting, keterangan, jml_tagihan, jml_bayar, jml_total, kd_cust FROM FIN.dbo.FIN_NOTA WHERE tipe_trans LIKE 'JKK-KPT-01' AND no_inv='" & txtNoTrans.Text & "' ORDER BY tgl_inv DESC", sqlconn))
        End If
        daDetilCari.Fill(dsDetil, "Detil")
        gcDetil.DataSource = dsDetil.Tables("Detil")
        gvDetil.BestFitColumns()
    End Sub

    Private Sub loadLunas(Optional ByVal kodeInv As String = "", Optional ByVal kodeKartu As String = "")
        dsLunas = New DataSet
        If Not dsLunas.Tables.Count <= 0 Then dsLunas.Tables.Clear()
        If txtNoTrans.Text = "" Then
            If chkPosting.Checked Then
                daLunasCari = New SqlDataAdapter(New SqlCommand("SELECT a.no_trans as no_trans_d, b.tgl_trans, b.no_trans, b.tgl_posting as tgl_posting_l, b.keterangan as keterangan_l, b.Jns_bayar,a.jml_piut as jml_bayar_l FROM FIN.dbo.FIN_NOTA_LUNAS_D a, FIN.dbo.FIN_NOTA_LUNAS b WHERE a.no_trans=b.no_trans AND a.prev_no_inv = '" & kodeInv & "' AND a.kd_kartu = '" & kodeKartu & "' AND NOT (b.no_posting IS NULL OR b.no_posting = '') ORDER BY b.tgl_trans DESC", sqlconn))
            Else
                daLunasCari = New SqlDataAdapter(New SqlCommand("SELECT a.no_trans as no_trans_d, b.tgl_trans, b.no_trans, b.tgl_posting as tgl_posting_l, b.keterangan as keterangan_l, b.Jns_bayar,a.jml_piut as jml_bayar_l FROM FIN.dbo.FIN_NOTA_LUNAS_D a, FIN.dbo.FIN_NOTA_LUNAS b WHERE a.no_trans=b.no_trans AND a.prev_no_inv = '" & kodeInv & "' AND a.kd_kartu = '" & kodeKartu & "' ORDER BY b.tgl_trans DESC", sqlconn))
            End If
        Else
            If chkPosting.Checked Then
                daLunasCari = New SqlDataAdapter(New SqlCommand("SELECT a.no_trans as no_trans_d, b.tgl_trans, b.no_trans, b.tgl_posting as tgl_posting_l, b.keterangan as keterangan_l, b.Jns_bayar,a.jml_piut as jml_bayar_l FROM FIN.dbo.FIN_NOTA_LUNAS_D a, FIN.dbo.FIN_NOTA_LUNAS b WHERE a.no_trans=b.no_trans AND a.prev_no_inv = '" & txtNoTrans.Text & "' AND NOT (b.no_posting IS NULL OR b.no_posting = '') ORDER BY b.tgl_trans DESC", sqlconn))
            Else
                daLunasCari = New SqlDataAdapter(New SqlCommand("SELECT a.no_trans as no_trans_d, b.tgl_trans, b.no_trans, b.tgl_posting as tgl_posting_l, b.keterangan as keterangan_l, b.Jns_bayar,a.jml_piut as jml_bayar_l FROM FIN.dbo.FIN_NOTA_LUNAS_D a, FIN.dbo.FIN_NOTA_LUNAS b WHERE a.no_trans=b.no_trans AND a.prev_no_inv = '" & txtNoTrans.Text & "' ORDER BY b.tgl_trans DESC", sqlconn))
            End If
        End If

        daLunasCari.Fill(dsLunas, "Lunas")
        gcLunas.DataSource = dsLunas.Tables("Lunas")
        gvLunas.BestFitColumns()
    End Sub

    Private Sub loadAll()
        Dim kKar As String
        Dim viewPiutang As ColumnView = gvPiutang
        Dim kInv As String
        Dim viewDetil As ColumnView = gvDetil
        Dim viewLunas As ColumnView = gvLunas
        Dim jml As Integer

        loadLookUp()
        loadPiutang()
        If Not gvPiutang.RowCount = 0 Then
            kKar = viewPiutang.GetFocusedRowCellValue("kd_cust").ToString
            loadDetil(kKar)
            jml = viewDetil.GetFocusedRowCellValue("jml_bayar")
            jumlah = viewDetil.GetFocusedRowCellValue("jml_bayar")
            If Not jml <= 0 Then
                kodeInvo = viewDetil.GetFocusedRowCellValue("no_inv").ToString
                kInv = viewDetil.GetFocusedRowCellValue("no_inv").ToString
                loadLunas(kInv, kKar)
            Else
                If Not dsLunas.Tables("Lunas") Is Nothing Then dsLunas.Tables("Lunas").Clear()
            End If
        Else
            If txtNoTrans.Text = "" Then
                If Not dsDetil.Tables("Detil") Is Nothing Then dsDetil.Tables("Detil").Clear()
                If Not dsLunas.Tables("Lunas") Is Nothing Then dsLunas.Tables("Lunas").Clear()
            Else
                loadDetil()
                loadLunas()
            End If
        End If
    End Sub

    Private Sub formMonPiutUsh_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        txtNoTrans.Text = ""
        lueKaryawan.EditValue = "00000"
        deTglAwal.EditValue = getTanggal()
        deTglAkhir.EditValue = getTanggal()
        chkAll.Checked = True
        chkPosting.Checked = True
        loadAll()
    End Sub

    Private Sub gvPiutang_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvPiutang.Click
        Try
            Dim kBB As String
            Dim kKar As String
            Dim viewPiutang As ColumnView = gvPiutang
            Dim kInv As String
            Dim viewDetil As ColumnView = gvDetil
            Dim viewLunas As ColumnView = gvLunas
            Dim jml As Integer

            kKar = viewPiutang.GetFocusedRowCellValue("kd_cust").ToString

            kodeKary = kKar
            loadDetil(kKar)
            jml = viewDetil.GetFocusedRowCellValue("jml_bayar")
            If Not jml <= 0 Then
                kInv = viewDetil.GetFocusedRowCellValue("no_inv").ToString
                loadLunas(kInv, kKar)
            Else
                If Not dsLunas.Tables("Lunas") Is Nothing Then dsLunas.Tables("Lunas").Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub gvDetil_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvDetil.Click
        Try
            Dim kInv As String
            Dim kKar As String
            Dim viewPiutang As ColumnView = gvPiutang
            Dim viewDetil As ColumnView = gvDetil
            Dim viewLunas As ColumnView = gvLunas
            Dim jml As Integer

            kKar = viewPiutang.GetFocusedRowCellValue("kd_cust").ToString
            jml = viewDetil.GetFocusedRowCellValue("jml_bayar")
            kodeInvo = viewDetil.GetFocusedRowCellValue("no_inv").ToString
            If Not jml <= 0 Then
                kInv = viewDetil.GetFocusedRowCellValue("no_inv").ToString
                loadLunas(kInv, kKar)
            Else
                If Not dsLunas.Tables("Lunas") Is Nothing Then dsLunas.Tables("Lunas").Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        If isSearch = True Then
            loadAll()
        End If
        kodeKary = ""
        'kodeInvo = ""
    End Sub

    Private Sub chkPiut_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPiut.CheckedChanged
        If chkPiut.Checked = True Then
            chkDetil.Checked = False
            chkLunas.Checked = False
            pnlDetil.Visible = False
            pnlLunas.Visible = False
            pnlPiut.Dock = DockStyle.Fill
        ElseIf chkPiut.Checked = False Then
            pnlPiut.Dock = DockStyle.Top
            pnlDetil.Visible = True
            pnlLunas.Visible = True
        End If
    End Sub

    Private Sub chkDetil_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDetil.CheckedChanged
        If chkDetil.Checked = True Then
            chkPiut.Checked = False
            chkLunas.Checked = False
            pnlPiut.Visible = False
            pnlLunas.Visible = False
            pnlDetil.Dock = DockStyle.Fill
        ElseIf chkDetil.Checked = False Then
            pnlDetil.Dock = DockStyle.Top
            pnlPiut.Visible = True
            pnlLunas.Visible = True
        End If
    End Sub

    Private Sub chkLunas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLunas.CheckedChanged
        If chkLunas.Checked = True Then
            chkPiut.Checked = False
            chkDetil.Checked = False
            pnlPiut.Visible = False
            pnlDetil.Visible = False
        ElseIf chkLunas.Checked = False Then
            pnlPiut.Visible = True
            pnlDetil.Visible = True
        End If
    End Sub

    Public Sub cetak_click()
        If chkPiut.Checked = True Then
            If Not gvPiutang.RowCount <= 0 Then
                gvPiutang.OptionsView.ShowViewCaption = False
                'ShowGridPreview(gcGiro)
                Dim ph As DevExpress.XtraPrinting.PageHeaderFooter = CType(PrintableComponentLinkPiutang.PageHeaderFooter, PageHeaderFooter)
                ph.Footer.Content.Add(username)
                ph.Footer.Content.Add("")
                ph.Footer.Content.Add("Hal. [Page #]")

                PrintableComponentLinkPiutang.CreateDocument()
                PrintableComponentLinkPiutang.ShowPreview()
            Else
                MsgBox("Tidak ada data yang dicetak. Silahkan cek kelengkapan filter lalu menekan tombol Refresh.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
            End If
        ElseIf chkDetil.Checked = True Then
            If Not gvDetil.RowCount <= 0 Then
                gvDetil.OptionsView.ShowViewCaption = False
                'ShowGridPreview(gcGiro)
                Dim ph As DevExpress.XtraPrinting.PageHeaderFooter = CType(PrintableComponentLinkDetil.PageHeaderFooter, PageHeaderFooter)
                ph.Footer.Content.Add(username)
                ph.Footer.Content.Add("")
                ph.Footer.Content.Add("Hal. [Page #]")

                PrintableComponentLinkDetil.CreateDocument()
                PrintableComponentLinkDetil.ShowPreview()
            Else
                MsgBox("Tidak ada data yang dicetak. Silahkan cek kelengkapan filter lalu menekan tombol Refresh.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
            End If
        ElseIf chkLunas.Checked = True Then
            If Not gvLunas.RowCount <= 0 Then
                gvLunas.OptionsView.ShowViewCaption = False
                'ShowGridPreview(gcGiro)
                Dim ph As DevExpress.XtraPrinting.PageHeaderFooter = CType(PrintableComponentLinkLunas.PageHeaderFooter, PageHeaderFooter)
                ph.Footer.Content.Add(username)
                ph.Footer.Content.Add("")
                ph.Footer.Content.Add("Hal. [Page #]")

                PrintableComponentLinkLunas.CreateDocument()
                PrintableComponentLinkLunas.ShowPreview()
            Else
                MsgBox("Tidak ada data yang dicetak. Silahkan cek kelengkapan filter lalu menekan tombol Refresh.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
            End If
        End If

        gvPiutang.OptionsView.ShowViewCaption = True
        gvDetil.OptionsView.ShowViewCaption = True
        gvLunas.OptionsView.ShowViewCaption = True
    End Sub

    Private Sub lueKaryawan_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueKaryawan.EditValueChanged
        If Not gvPiutang.RowCount <= 0 Then
            gvPiutang.FocusedRowHandle = 0
        End If
    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAll.CheckedChanged
        If chkAll.Checked = True Then
            chkOutstanding.Checked = False
        End If
    End Sub

    Private Sub chkOutstanding_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkOutstanding.CheckedChanged
        If chkOutstanding.Checked = True Then
            chkAll.Checked = False
        End If
    End Sub

    Private Sub PrintableComponentLinkPiutang_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLinkPiutang.CreateReportHeaderArea
        Dim reportHeader As String = "REKAP DATA PIUTANG KARYAWAN"
        Dim reportHeader2 As String = ":"
        Dim reportHeader3 As String = "PT. Dynasti Indomegah"
        Dim reportHeader4 As String = "Tanggal Cetak"
        Dim reportHeader5 As String = Format(getTanggal, "d MMMM yyyy")
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        e.Graph.BackColor = Color.White
        'MsgBox(e.Graph.ClientPageSize.Width.ToString)
        'MsgBox(e.Graph.MeasureString(reportHeader, e.Graph.ClientPageSize.Width).Width)
        Dim rec As RectangleF = New RectangleF(269, 0, e.Graph.MeasureString(reportHeader, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec2 As RectangleF = New RectangleF(125, 60, e.Graph.MeasureString(reportHeader2, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec3 As RectangleF = New RectangleF(0, 0, e.Graph.MeasureString(reportHeader3, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec4 As RectangleF = New RectangleF(0, 60, e.Graph.MeasureString(reportHeader4, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec5 As RectangleF = New RectangleF(150, 60, e.Graph.MeasureString(reportHeader5, e.Graph.ClientPageSize.Width).Width, 20)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.Bottom)
        e.Graph.DrawString(reportHeader2, Color.Black, rec2, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportHeader3, Color.Black, rec3, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportHeader4, Color.Black, rec4, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportHeader5, Color.Black, rec5, DevExpress.XtraPrinting.BorderSide.None)
    End Sub

    Private Sub PrintableComponentLinkDetil_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLinkDetil.CreateReportHeaderArea
        Dim reportHeader As String = "REKAP DATA DETIL PIUTANG KARYAWAN"
        Dim reportHeader2 As String = ":"
        Dim reportHeader3 As String = "PT. Dynasti Indomegah"
        Dim reportHeader4 As String = "Tanggal Cetak"
        Dim reportHeader5 As String = getTanggal.ToLongDateString
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        e.Graph.BackColor = Color.White
        'MsgBox(e.Graph.ClientPageSize.Width / 2.ToString)
        'MsgBox(e.Graph.MeasureString(reportHeader, e.Graph.ClientPageSize.Width).Width)
        Dim rec As RectangleF = New RectangleF(269, 0, e.Graph.MeasureString(reportHeader, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec2 As RectangleF = New RectangleF(125, 60, e.Graph.MeasureString(reportHeader2, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec3 As RectangleF = New RectangleF(0, 0, e.Graph.MeasureString(reportHeader3, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec4 As RectangleF = New RectangleF(0, 60, e.Graph.MeasureString(reportHeader4, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec5 As RectangleF = New RectangleF(150, 60, e.Graph.MeasureString(reportHeader5, e.Graph.ClientPageSize.Width).Width, 20)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.Bottom)
        e.Graph.DrawString(reportHeader2, Color.Black, rec2, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportHeader3, Color.Black, rec3, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportHeader4, Color.Black, rec4, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportHeader5, Color.Black, rec5, DevExpress.XtraPrinting.BorderSide.None)
    End Sub

    Private Sub PrintableComponentLinkLunas_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLinkLunas.CreateReportHeaderArea
        Dim reportHeader As String = "REKAP DATA PEMBAYARAN PIUTANG KARYAWAN"
        Dim reportHeader2 As String = ":"
        Dim reportHeader4 As String = "Tanggal Cetak"
        Dim reportHeader5 As String = getTanggal.ToLongDateString
        Dim reportHeader6 As String = "No. Pinjaman"
        Dim reportHeader7 As String = kodeInvo
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        e.Graph.BackColor = Color.White
        'MsgBox(e.Graph.ClientPageSize.Width / 2.ToString)
        'MsgBox(e.Graph.MeasureString(reportHeader, e.Graph.ClientPageSize.Width).Width)
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 20)
        Dim rec2 As RectangleF = New RectangleF(125, 60, e.Graph.MeasureString(reportHeader2).Width, 20)
        Dim rec3 As RectangleF = New RectangleF(125, 80, e.Graph.MeasureString(reportHeader2).Width, 20)
        Dim rec4 As RectangleF = New RectangleF(0, 60, e.Graph.MeasureString(reportHeader4).Width + 2, 20)
        Dim rec5 As RectangleF = New RectangleF(150, 60, e.Graph.MeasureString(reportHeader5).Width + 2, 20)
        Dim rec6 As RectangleF = New RectangleF(0, 80, e.Graph.MeasureString(reportHeader6).Width + 2, 20)
        Dim rec7 As RectangleF = New RectangleF(150, 80, e.Graph.MeasureString(reportHeader7).Width + 2, 20)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportHeader2, Color.Black, rec2, DevExpress.XtraPrinting.BorderSide.All)
        e.Graph.DrawString(reportHeader2, Color.Black, rec3, DevExpress.XtraPrinting.BorderSide.All)
        e.Graph.DrawString(reportHeader4, Color.Black, rec4, DevExpress.XtraPrinting.BorderSide.All)
        e.Graph.DrawString(reportHeader5, Color.Black, rec5, DevExpress.XtraPrinting.BorderSide.All)
        e.Graph.DrawString(reportHeader6, Color.Black, rec6, DevExpress.XtraPrinting.BorderSide.All)
        e.Graph.DrawString(reportHeader7, Color.Black, rec7, DevExpress.XtraPrinting.BorderSide.All)
    End Sub

    Private Sub gvPiutang_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvPiutang.FocusedRowChanged
        Try
            Dim kBB As String
            Dim kKar As String
            Dim viewPiutang As ColumnView = gvPiutang
            Dim kInv As String
            Dim viewDetil As ColumnView = gvDetil
            Dim viewLunas As ColumnView = gvLunas
            Dim jml As Integer

            kKar = viewPiutang.GetFocusedRowCellValue("kd_cust").ToString

            kodeKary = kKar
            loadDetil(kKar)
            jml = viewDetil.GetFocusedRowCellValue("jml_bayar")
            If Not jml <= 0 Then
                kInv = viewDetil.GetFocusedRowCellValue("no_inv").ToString
                loadLunas(kInv, kKar)
            Else
                If Not dsLunas.Tables("Lunas") Is Nothing Then dsLunas.Tables("Lunas").Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub deTglAwal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTglAwal.EditValueChanged
        If Not deTglAwal.EditValue = vbNullString Then
            deTglAkhir.EditValue = DateAdd(DateInterval.Month, 1, deTglAwal.EditValue)
            deTglAkhir.EditValue = DateAdd(DateInterval.Day, -1, deTglAkhir.EditValue)
        End If
    End Sub

    Private Sub deTglAkhir_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTglAkhir.EditValueChanged
        If Not deTglAkhir.EditValue = vbNullString Then
            deTglAwal.Properties.MaxValue = deTglAkhir.EditValue
        End If
    End Sub

    Private Sub chkPosting_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPosting.CheckedChanged
        If chkPosting.Checked = True Then
            chkNonPosting.Checked = False
        End If
    End Sub

    Private Sub chkNonPosting_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNonPosting.CheckedChanged
        If chkNonPosting.Checked = True Then
            chkPosting.Checked = False
        End If
    End Sub
End Class
