'tgl 19/06/2015
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports System.Drawing
Imports DevExpress.XtraPrinting

Public Class formMonPiutUshSpon1
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim dsPiut, dsDetil, dsLunas, dsLookUp, dsGiro As New DataSet
    Dim daLookKar, daLookBB, daLookKartu, daLookKartu1, daPiut, daPiutCari, daDetil, daDetilCari, daLunas, daLunasCari, daGiroCari As SqlDataAdapter
    Dim err As String
    Dim isSearch As Boolean = True
    Dim kodeKary As String = ""
    Dim kodeInvo As String = ""
    Dim kodetrans As String = ""


    Private Sub loadLookUp()
        dsLookUp = New DataSet
        daLookBB = New SqlDataAdapter(New SqlCommand("SELECT Id_Data, Desc_Data FROM SIF.dbo.SIF_Gen_Reff_D WHERE Id_Ref_File = 'JNSINV'", sqlconn))
        daLookBB.Fill(dsLookUp, "LookBB")
        lookBB.DataSource = dsLookUp.Tables("LookBB")
        lookBB.DisplayMember = "Desc_Data"
        lookBB.ValueMember = "Id_Data"

        daLookKartu = New SqlDataAdapter(New SqlCommand("SELECT kode, nama FROM FIN.dbo.v_kartu", sqlconn))
        daLookKartu.Fill(dsLookUp, "LookKartu")
        lookKartu.DataSource = dsLookUp.Tables("LookKartu")
        lookKartu.DisplayMember = "nama"
        lookKartu.ValueMember = "kode"

        daLookKartu1 = New SqlDataAdapter(New SqlCommand("Select d.Id_Data, d.Desc_Data From SIF.dbo.SIF_Gen_Reff_D d " & _
                                                      "where d.Id_Ref_Data = 'JNSBYR' and d.Id_Ref_File = 'JNSBYRPJ'", sqlconn))
        daLookKartu1.Fill(dsLookUp, "LookJnsByr")
        RepLE_JenisBayar.DataSource = dsLookUp.Tables("LookJnsByr")
        RepLE_JenisBayar.DisplayMember = "Desc_Data"
        RepLE_JenisBayar.ValueMember = "Id_Data"

        daLookKar = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT b.kd_cust, a.nama FROM FIN.dbo.v_kartu a, FIN.dbo.FIN_NOTA b WHERE (b.tipe_trans LIKE 'JPJ-KPT-02%' or  b.tipe_trans LIKE 'JPJ-KPT-04%') AND a.kode=b.kd_cust AND jml_akhir > 0 UNION SELECT '00000', '[Semua Data]'", sqlconn))
        daLookKar.Fill(dsLookUp, "LookKar")
        lueKaryawan.Properties.DataSource = dsLookUp.Tables("LookKar")
        lueKaryawan.Properties.DisplayMember = "nama"
        lueKaryawan.Properties.ValueMember = "kd_cust"
    End Sub

    Private Sub loadPiutang()
        dsPiut = New DataSet
        If Not dsPiut.Tables.Count <= 0 Then dsPiut.Tables.Clear()
        If txtNoTrans.Text = "" Then
            If chkAll.Checked Then
                If chkPosting.Checked Then
                    If lueKaryawan.EditValue = "00000" Or lueKaryawan.EditValue = vbNullString Then
                        'If deTglAwal.EditValue = vbNullString Then
                        '    daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', jns_inv, kd_cust, SUM(jml_akhir) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE (tipe_trans LIKE 'JPJ-KPT-01%' or  tipe_trans LIKE 'JPJ-KPT-05%') AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY jns_inv, kd_cust", sqlconn))
                        'Else
                        daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', jns_inv, kd_cust, SUM(jml_tagihan) jml_tagihan, SUM(jml_bayar) jml_bayar, SUM(jml_total) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE (tipe_trans LIKE 'JPJ-KPT-02%' or  tipe_trans LIKE 'JPJ-KPT-04%') AND tgl_posting BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY jns_inv, kd_cust", sqlconn))
                        'End If
                    Else
                        'If deTglAwal.EditValue = vbNullString Then
                        '    daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', jns_inv, kd_cust, SUM(jml_akhir) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE (tipe_trans LIKE 'JPJ-KPT-01%' or  tipe_trans LIKE 'JPJ-KPT-05%') AND kd_cust LIKE '%" & lueKaryawan.EditValue & "%' AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY jns_inv, kd_cust", sqlconn))
                        'Else
                        daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', jns_inv, kd_cust, SUM(jml_tagihan) jml_tagihan, SUM(jml_bayar) jml_bayar, SUM(jml_total) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE (tipe_trans LIKE 'JPJ-KPT-02%' or  tipe_trans LIKE 'JPJ-KPT-04%') AND kd_cust LIKE '%" & lueKaryawan.EditValue & "%' AND tgl_posting BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY jns_inv, kd_cust", sqlconn))
                        'End If
                    End If
                Else
                    If lueKaryawan.EditValue = "00000" Or lueKaryawan.EditValue = vbNullString Then
                        'If deTglAwal.EditValue = vbNullString Then
                        '    daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', jns_inv, kd_cust, SUM(jml_akhir) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE (tipe_trans LIKE 'JPJ-KPT-01%' or  tipe_trans LIKE 'JPJ-KPT-05%') AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY jns_inv, kd_cust", sqlconn))
                        'Else
                        daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY k.kd_cust) as 'nomer', k.jns_inv, k.kd_cust, SUM(k.jml_tagihan) jml_tagihan, SUM(k.jml_bayar) jml_bayar, SUM(k.sisa) sisa FROM (SELECT DISTINCT a.jns_inv, a.kd_cust, SUM(a.jml_tagihan) jml_tagihan, (SELECT ISNULL(SUM(x.jml_bayar),0) jmlbayar FROM FIN.dbo.FIN_NOTA_LUNAS_D x, FIN.dbo.FIN_NOTA y, FIN.dbo.FIN_NOTA_LUNAS z WHERE x.prev_no_inv = y.no_inv AND x.no_trans = z.no_trans AND z.kd_kartu = a.kd_cust AND x.prev_no_inv = a.no_inv AND y.jns_inv = a.jns_inv) jml_bayar, SUM(a.jml_tagihan) - (SELECT ISNULL(SUM(x.jml_bayar),0) jmlbayar FROM FIN.dbo.FIN_NOTA_LUNAS_D x, FIN.dbo.FIN_NOTA y, FIN.dbo.FIN_NOTA_LUNAS z WHERE x.prev_no_inv = y.no_inv AND x.no_trans = z.no_trans AND z.kd_kartu = a.kd_cust AND x.prev_no_inv = a.no_inv AND y.jns_inv = a.jns_inv) 'sisa' FROM FIN.dbo.FIN_NOTA a WHERE (a.tipe_trans LIKE 'JPJ-KPT-02%' or a.tipe_trans LIKE 'JPJ-KPT-04%') AND a.tgl_inv BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) GROUP BY a.no_inv, a.jns_inv, a.kd_cust) k GROUP BY k.jns_inv, k.kd_cust", sqlconn))
                        'End If
                    Else
                        'If deTglAwal.EditValue = vbNullString Then
                        '    daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', jns_inv, kd_cust, SUM(jml_akhir) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE (tipe_trans LIKE 'JPJ-KPT-01%' or  tipe_trans LIKE 'JPJ-KPT-05%') AND kd_cust LIKE '%" & lueKaryawan.EditValue & "%' AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY jns_inv, kd_cust", sqlconn))
                        'Else
                        daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY k.kd_cust) as 'nomer', k.jns_inv, k.kd_cust, SUM(k.jml_tagihan) jml_tagihan, SUM(k.jml_bayar) jml_bayar, SUM(k.sisa) sisa FROM (SELECT DISTINCT a.jns_inv, a.kd_cust, SUM(a.jml_tagihan) jml_tagihan, (SELECT ISNULL(SUM(x.jml_bayar),0) jmlbayar FROM FIN.dbo.FIN_NOTA_LUNAS_D x, FIN.dbo.FIN_NOTA y, FIN.dbo.FIN_NOTA_LUNAS z WHERE x.prev_no_inv = y.no_inv AND x.no_trans = z.no_trans AND z.kd_kartu = a.kd_cust AND x.prev_no_inv = a.no_inv AND y.jns_inv = a.jns_inv) jml_bayar, SUM(a.jml_tagihan) - (SELECT ISNULL(SUM(x.jml_bayar),0) jmlbayar FROM FIN.dbo.FIN_NOTA_LUNAS_D x, FIN.dbo.FIN_NOTA y, FIN.dbo.FIN_NOTA_LUNAS z WHERE x.prev_no_inv = y.no_inv AND x.no_trans = z.no_trans AND z.kd_kartu = a.kd_cust AND x.prev_no_inv = a.no_inv AND y.jns_inv = a.jns_inv) 'sisa' FROM FIN.dbo.FIN_NOTA a WHERE (a.tipe_trans LIKE 'JPJ-KPT-02%' or a.tipe_trans LIKE 'JPJ-KPT-04%') AND a.tgl_inv BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) AND a.kd_cust = '" & lueKaryawan.EditValue & "' GROUP BY a.no_inv, a.jns_inv, a.kd_cust) k GROUP BY k.jns_inv, k.kd_cust", sqlconn))
                        'End If
                    End If
                End If
            Else
                If chkPosting.Checked Then
                    If lueKaryawan.EditValue = "00000" Or lueKaryawan.EditValue = vbNullString Then
                        'If deTglAwal.EditValue = vbNullString Then
                        '    daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', jns_inv, kd_cust, SUM(jml_akhir) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE (tipe_trans LIKE 'JPJ-KPT-01%' or  tipe_trans LIKE 'JPJ-KPT-05%') AND jml_akhir > 0 AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY kd_buku_besar, kd_cust", sqlconn))
                        'Else
                        daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', jns_inv, kd_cust, SUM(jml_tagihan) jml_tagihan, SUM(jml_bayar) jml_bayar, SUM(jml_total) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE (tipe_trans LIKE 'JPJ-KPT-02%' or  tipe_trans LIKE 'JPJ-KPT-04%') AND jml_akhir > 0 AND tgl_posting BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY jns_inv, kd_cust", sqlconn))
                        'End If
                    Else
                        'If deTglAwal.EditValue = vbNullString Then
                        '    daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', jns_inv, kd_cust, SUM(jml_akhir) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE (tipe_trans LIKE 'JPJ-KPT-01%' or  tipe_trans LIKE 'JPJ-KPT-05%') AND kd_cust LIKE '%" & lueKaryawan.EditValue & "%' AND jml_akhir > 0 AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY jns_inv, kd_cust", sqlconn))
                        'Else
                        daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', jns_inv, kd_cust, SUM(jml_tagihan) jml_tagihan, SUM(jml_bayar) jml_bayar, SUM(jml_total) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE (tipe_trans LIKE 'JPJ-KPT-02%' or  tipe_trans LIKE 'JPJ-KPT-04%') AND kd_cust LIKE '%" & lueKaryawan.EditValue & "%' AND jml_akhir > 0 AND tgl_posting BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY jns_inv, kd_cust", sqlconn))
                        'End If
                    End If
                Else
                    If lueKaryawan.EditValue = "00000" Or lueKaryawan.EditValue = vbNullString Then
                        'If deTglAwal.EditValue = vbNullString Then
                        '    daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', jns_inv, kd_cust, SUM(jml_akhir) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE (tipe_trans LIKE 'JPJ-KPT-01%' or  tipe_trans LIKE 'JPJ-KPT-05%') AND jml_akhir > 0 AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY kd_buku_besar, kd_cust", sqlconn))
                        'Else
                        daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY k.kd_cust) as 'nomer', k.jns_inv, k.kd_cust, SUM(k.jml_tagihan) jml_tagihan, SUM(k.jml_bayar) jml_bayar, SUM(k.sisa) sisa FROM (SELECT DISTINCT a.jns_inv, a.kd_cust, SUM(a.jml_tagihan) jml_tagihan, (SELECT ISNULL(SUM(x.jml_bayar),0) jmlbayar FROM FIN.dbo.FIN_NOTA_LUNAS_D x, FIN.dbo.FIN_NOTA y, FIN.dbo.FIN_NOTA_LUNAS z WHERE x.prev_no_inv = y.no_inv AND x.no_trans = z.no_trans AND z.kd_kartu = a.kd_cust AND x.prev_no_inv = a.no_inv AND y.jns_inv = a.jns_inv) jml_bayar, SUM(a.jml_tagihan) - (SELECT ISNULL(SUM(x.jml_bayar),0) jmlbayar FROM FIN.dbo.FIN_NOTA_LUNAS_D x, FIN.dbo.FIN_NOTA y, FIN.dbo.FIN_NOTA_LUNAS z WHERE x.prev_no_inv = y.no_inv AND x.no_trans = z.no_trans AND z.kd_kartu = a.kd_cust AND x.prev_no_inv = a.no_inv AND y.jns_inv = a.jns_inv) 'sisa' FROM FIN.dbo.FIN_NOTA a WHERE (a.tipe_trans LIKE 'JPJ-KPT-02%' or a.tipe_trans LIKE 'JPJ-KPT-04%') AND a.jml_total > 0 AND a.tgl_inv BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) GROUP BY a.no_inv, a.jns_inv, a.kd_cust) k GROUP BY k.jns_inv, k.kd_cust", sqlconn))
                        'End If
                    Else
                        'If deTglAwal.EditValue = vbNullString Then
                        '    daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', jns_inv, kd_cust, SUM(jml_akhir) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE (tipe_trans LIKE 'JPJ-KPT-01%' or  tipe_trans LIKE 'JPJ-KPT-05%') AND kd_cust LIKE '%" & lueKaryawan.EditValue & "%' AND jml_akhir > 0 AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY jns_inv, kd_cust", sqlconn))
                        'Else
                        daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY k.kd_cust) as 'nomer', k.jns_inv, k.kd_cust, SUM(k.jml_tagihan) jml_tagihan, SUM(k.jml_bayar) jml_bayar, SUM(k.sisa) sisa FROM (SELECT DISTINCT a.jns_inv, a.kd_cust, SUM(a.jml_tagihan) jml_tagihan, (SELECT ISNULL(SUM(x.jml_bayar),0) jmlbayar FROM FIN.dbo.FIN_NOTA_LUNAS_D x, FIN.dbo.FIN_NOTA y, FIN.dbo.FIN_NOTA_LUNAS z WHERE x.prev_no_inv = y.no_inv AND x.no_trans = z.no_trans AND z.kd_kartu = a.kd_cust AND x.prev_no_inv = a.no_inv AND y.jns_inv = a.jns_inv) jml_bayar, SUM(a.jml_tagihan) - (SELECT ISNULL(SUM(x.jml_bayar),0) jmlbayar FROM FIN.dbo.FIN_NOTA_LUNAS_D x, FIN.dbo.FIN_NOTA y, FIN.dbo.FIN_NOTA_LUNAS z WHERE x.prev_no_inv = y.no_inv AND x.no_trans = z.no_trans AND z.kd_kartu = a.kd_cust AND x.prev_no_inv = a.no_inv AND y.jns_inv = a.jns_inv) 'sisa' FROM FIN.dbo.FIN_NOTA a WHERE (a.tipe_trans LIKE 'JPJ-KPT-02%' or a.tipe_trans LIKE 'JPJ-KPT-04%') AND a.jml_total > 0 AND a.tgl_inv BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) AND a.kd_cust = '" & lueKaryawan.EditValue & "' GROUP BY a.no_inv, a.jns_inv, a.kd_cust) k GROUP BY k.jns_inv, k.kd_cust", sqlconn))
                        'End If
                    End If
                End If
            End If
        Else
            daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', jns_inv, kd_cust, SUM(jml_tagihan) jml_tagihan, SUM(jml_bayar) jml_bayar, SUM(jml_total) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE no_inv LIKE '%" & txtNoTrans.EditValue & "%' GROUP BY jns_inv, kd_cust", sqlconn))
        End If
        daPiut.Fill(dsPiut, "Piutang")
        gcPiutang.DataSource = dsPiut.Tables("Piutang")
        gvPiutang.BestFitColumns()
    End Sub

    Private Sub loadDetil(Optional ByVal kodeBB As String = "", Optional ByVal kodeKar As String = "")
        dsDetil = New DataSet
        If Not dsDetil.Tables.Count <= 0 Then dsDetil.Tables.Clear()
        If txtNoTrans.Text = "" Then
            If chkAll.Checked Then
                If chkPosting.Checked Then
                    'If deTglAwal.EditValue = vbNullString Then
                    '    daDetilCari = New SqlDataAdapter(New SqlCommand("SELECT no_inv, tgl_inv, no_jurnal, tgl_posting, keterangan, jml_tagihan, jml_bayar, jml_akhir, kd_cust FROM FIN.dbo.FIN_NOTA WHERE (tipe_trans LIKE 'JPJ-KPT-01%' or  tipe_trans LIKE 'JPJ-KPT-05%') AND kd_cust='" & kodeKar & "' AND jns_inv ='" & kodeBB & "' AND NOT (no_posting IS NULL OR no_posting = '')", sqlconn))
                    'Else
                    daDetilCari = New SqlDataAdapter(New SqlCommand("SELECT no_inv, tgl_inv, no_jurnal, tgl_posting, keterangan, jml_tagihan, jml_bayar, jml_total, kd_cust FROM FIN.dbo.FIN_NOTA WHERE (tipe_trans LIKE 'JPJ-KPT-02%' or  tipe_trans LIKE 'JPJ-KPT-04%') AND kd_cust='" & kodeKar & "' AND jns_inv ='" & kodeBB & "' AND tgl_posting BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '')", sqlconn))
                    'End If
                Else
                    'If deTglAwal.EditValue = vbNullString Then
                    '    daDetilCari = New SqlDataAdapter(New SqlCommand("SELECT no_inv, tgl_inv, no_jurnal, tgl_posting, keterangan, jml_tagihan, jml_bayar, jml_akhir, kd_cust FROM FIN.dbo.FIN_NOTA WHERE (tipe_trans LIKE 'JPJ-KPT-01%' or  tipe_trans LIKE 'JPJ-KPT-05%') AND kd_cust='" & kodeKar & "' AND jns_inv ='" & kodeBB & "' AND NOT (no_posting IS NULL OR no_posting = '')", sqlconn))
                    'Else
                    daDetilCari = New SqlDataAdapter(New SqlCommand("SELECT a.no_inv, a.tgl_inv, a.no_jurnal, a.tgl_posting, a.keterangan, a.jml_tagihan, (SELECT ISNULL(SUM(x.jml_bayar),0) FROM FIN.dbo.FIN_NOTA_LUNAS_D x, FIN.dbo.FIN_NOTA y, FIN.dbo.FIN_NOTA_LUNAS z WHERE x.prev_no_inv = y.no_inv AND x.no_trans = z.no_trans AND z.kd_kartu = a.kd_cust AND x.prev_no_inv = a.no_inv AND y.jns_inv = a.jns_inv) jml_bayar, a.jml_tagihan - (SELECT ISNULL(SUM(x.jml_bayar),0) FROM FIN.dbo.FIN_NOTA_LUNAS_D x, FIN.dbo.FIN_NOTA y, FIN.dbo.FIN_NOTA_LUNAS z WHERE x.prev_no_inv = y.no_inv AND x.no_trans = z.no_trans AND z.kd_kartu = a.kd_cust AND x.prev_no_inv = a.no_inv AND y.jns_inv = a.jns_inv) jml_total, a.kd_cust FROM FIN.dbo.FIN_NOTA a WHERE (a.tipe_trans LIKE 'JPJ-KPT-02%' OR a.tipe_trans LIKE 'JPJ-KPT-04%') AND a.kd_cust='" & kodeKar & "' AND a.jns_inv ='" & kodeBB & "' AND a.tgl_inv BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103)", sqlconn))
                    'End If
                End If
            Else
                If chkPosting.Checked Then
                    'If deTglAwal.EditValue = vbNullString Then
                    '    daDetilCari = New SqlDataAdapter(New SqlCommand("SELECT no_inv, tgl_inv, no_jurnal, tgl_posting, keterangan, jml_tagihan, jml_bayar, jml_akhir, kd_cust FROM FIN.dbo.FIN_NOTA WHERE (tipe_trans LIKE 'JPJ-KPT-01%' or  tipe_trans LIKE 'JPJ-KPT-05%') AND kd_cust='" & kodeKar & "' AND jns_inv ='" & kodeBB & "' AND jml_akhir > 0 AND NOT (no_posting IS NULL OR no_posting = '')", sqlconn))
                    'Else
                    daDetilCari = New SqlDataAdapter(New SqlCommand("SELECT no_inv, tgl_inv, no_jurnal, tgl_posting, keterangan, jml_tagihan, jml_bayar, jml_total, kd_cust FROM FIN.dbo.FIN_NOTA WHERE (tipe_trans LIKE 'JPJ-KPT-02%' or  tipe_trans LIKE 'JPJ-KPT-04%') AND kd_cust='" & kodeKar & "' AND jns_inv ='" & kodeBB & "' AND jml_akhir > 0 AND tgl_posting BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '')", sqlconn))
                    'End If
                Else
                    'If deTglAwal.EditValue = vbNullString Then
                    '    daDetilCari = New SqlDataAdapter(New SqlCommand("SELECT no_inv, tgl_inv, no_jurnal, tgl_posting, keterangan, jml_tagihan, jml_bayar, jml_akhir, kd_cust FROM FIN.dbo.FIN_NOTA WHERE (tipe_trans LIKE 'JPJ-KPT-01%' or  tipe_trans LIKE 'JPJ-KPT-05%') AND kd_cust='" & kodeKar & "' AND jns_inv ='" & kodeBB & "' AND jml_akhir > 0 AND NOT (no_posting IS NULL OR no_posting = '')", sqlconn))
                    'Else
                    daDetilCari = New SqlDataAdapter(New SqlCommand("SELECT a.no_inv, a.tgl_inv, a.no_jurnal, a.tgl_posting, a.keterangan, a.jml_tagihan, (SELECT ISNULL(SUM(x.jml_bayar),0) FROM FIN.dbo.FIN_NOTA_LUNAS_D x, FIN.dbo.FIN_NOTA y, FIN.dbo.FIN_NOTA_LUNAS z WHERE x.prev_no_inv = y.no_inv AND x.no_trans = z.no_trans AND z.kd_kartu = a.kd_cust AND x.prev_no_inv = a.no_inv AND y.jns_inv = a.jns_inv) jml_bayar, a.jml_tagihan - (SELECT ISNULL(SUM(x.jml_bayar),0) FROM FIN.dbo.FIN_NOTA_LUNAS_D x, FIN.dbo.FIN_NOTA y, FIN.dbo.FIN_NOTA_LUNAS z WHERE x.prev_no_inv = y.no_inv AND x.no_trans = z.no_trans AND z.kd_kartu = a.kd_cust AND x.prev_no_inv = a.no_inv AND y.jns_inv = a.jns_inv) jml_total, a.kd_cust FROM FIN.dbo.FIN_NOTA a WHERE (a.tipe_trans LIKE 'JPJ-KPT-02%' OR a.tipe_trans LIKE 'JPJ-KPT-04%') AND a.kd_cust='" & kodeKar & "' AND a.jns_inv ='" & kodeBB & "' AND jml_total > 0 AND a.tgl_inv BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103)", sqlconn))
                    'End If
                End If
            End If
        Else
            daDetilCari = New SqlDataAdapter(New SqlCommand("SELECT no_inv, tgl_inv, no_jurnal, tgl_posting, keterangan, jml_tagihan, jml_bayar, jml_total, kd_cust FROM FIN.dbo.FIN_NOTA WHERE (tipe_trans LIKE 'JPJ-KPT-02%' or  tipe_trans LIKE 'JPJ-KPT-04%') AND no_inv='" & txtNoTrans.Text & "'", sqlconn))
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
                daLunasCari = New SqlDataAdapter(New SqlCommand("SELECT a.no_trans as no_trans_d, b.tgl_trans, b.no_trans, b.tgl_posting as tgl_posting_l, b.keterangan as keterangan_l, b.Jns_bayar,a.jml_piut as jml_bayar_l FROM FIN.dbo.FIN_NOTA_LUNAS_D a, FIN.dbo.FIN_NOTA_LUNAS b WHERE a.no_trans=b.no_trans AND a.prev_no_inv = '" & kodeInv & "' AND a.kd_kartu = '" & kodeKartu & "' AND NOT (b.no_posting IS NULL OR b.no_posting = '')", sqlconn))
            Else
                daLunasCari = New SqlDataAdapter(New SqlCommand("SELECT a.no_trans as no_trans_d, b.tgl_trans, b.no_trans, b.tgl_posting as tgl_posting_l, b.keterangan as keterangan_l, b.Jns_bayar,a.jml_piut as jml_bayar_l FROM FIN.dbo.FIN_NOTA_LUNAS_D a, FIN.dbo.FIN_NOTA_LUNAS b WHERE a.no_trans=b.no_trans AND a.prev_no_inv = '" & kodeInv & "' AND a.kd_kartu = '" & kodeKartu & "'", sqlconn))
            End If
        Else
            If chkPosting.Checked Then
                daLunasCari = New SqlDataAdapter(New SqlCommand("SELECT a.no_trans as no_trans_d, b.tgl_trans, b.no_trans, b.tgl_posting as tgl_posting_l, b.keterangan as keterangan_l, b.Jns_bayar,a.jml_piut as jml_bayar_l FROM FIN.dbo.FIN_NOTA_LUNAS_D a, FIN.dbo.FIN_NOTA_LUNAS b WHERE a.no_trans=b.no_trans AND a.prev_no_inv = '" & txtNoTrans.Text & "'", sqlconn))
            Else
                daLunasCari = New SqlDataAdapter(New SqlCommand("SELECT a.no_trans as no_trans_d, b.tgl_trans, b.no_trans, b.tgl_posting as tgl_posting_l, b.keterangan as keterangan_l, b.Jns_bayar,a.jml_piut as jml_bayar_l FROM FIN.dbo.FIN_NOTA_LUNAS_D a, FIN.dbo.FIN_NOTA_LUNAS b WHERE a.no_trans=b.no_trans AND a.prev_no_inv = '" & txtNoTrans.Text & "'", sqlconn))
            End If
        End If

        daLunasCari.Fill(dsLunas, "Lunas")
        gcLunas.DataSource = dsLunas.Tables("Lunas")
        gvLunas.BestFitColumns()
    End Sub

    Private Sub loadGiro(Optional ByVal kdTrans As String = "")
        dsGiro = New DataSet
        If Not dsGiro.Tables.Count <= 0 Then dsGiro.Tables.Clear()
        If txtNoTrans.Text = "" Then
            daGiroCari = New SqlDataAdapter(New SqlCommand("SELECT c.no_giro as no_giro,c.jml_trans as jml_trans,c.status as status " & _
            " FROM FIN.dbo.FIN_TRANS_GIRO c," & _
            "(SELECT max(c.nomor)as max_giro FROM FIN.dbo.FIN_NOTA_LUNAS_D a, FIN.dbo.FIN_NOTA_LUNAS b,FIN.dbo.FIN_TRANS_GIRO c WHERE a.no_trans=b.no_trans AND b.no_giro = c.no_giro AND a.no_trans = '" & kdTrans & "' AND NOT (b.no_posting IS NULL OR b.no_posting = ''))d " & _
            " WHERE c.nomor =d.max_giro", sqlconn))
        Else
            If kdTrans = "" Then
                daGiroCari = New SqlDataAdapter(New SqlCommand("SELECT c.no_giro as no_giro,c.jml_trans as jml_trans,c.status as status " & _
                        " FROM FIN.dbo.FIN_TRANS_GIRO c ,(SELECT max(c.nomor)as max_giro FROM FIN.dbo.FIN_NOTA_LUNAS_D a, FIN.dbo.FIN_NOTA_LUNAS b,FIN.dbo.FIN_TRANS_GIRO c WHERE a.no_trans = b.no_trans and b.no_giro = c.no_giro AND a.prev_no_inv = '" & txtNoTrans.Text & "' AND NOT (b.no_posting IS NULL OR b.no_posting = ''))d " & _
                        " WHERE c.nomor = d.max_giro", sqlconn))
            Else
                daGiroCari = New SqlDataAdapter(New SqlCommand("SELECT c.no_giro as no_giro,c.jml_trans as jml_trans,c.status as status " & _
                            " FROM FIN.dbo.FIN_TRANS_GIRO c ,(SELECT max(c.nomor)as max_giro FROM FIN.dbo.FIN_NOTA_LUNAS_D a, FIN.dbo.FIN_NOTA_LUNAS b,FIN.dbo.FIN_TRANS_GIRO c WHERE a.no_trans = b.no_trans AND a.no_trans = '" & kdTrans & "' and b.no_giro = c.no_giro AND a.prev_no_inv = '" & txtNoTrans.Text & "' AND NOT (b.no_posting IS NULL OR b.no_posting = ''))d " & _
                            " WHERE c.nomor = d.max_giro", sqlconn))
            End If
        End If

        daGiroCari.Fill(dsGiro, "Giro")
        gcGiro.DataSource = dsGiro.Tables("Giro")
        gvGiro.BestFitColumns()
    End Sub

    Private Sub loadAll()
        Dim kBB As String
        Dim kKar As String
        Dim viewPiutang As ColumnView = gvPiutang
        Dim kInv As String
        Dim viewDetil As ColumnView = gvDetil
        Dim viewLunas As ColumnView = gvLunas
        Dim jml As Integer

        loadLookUp()
        loadPiutang()
        If Not gvPiutang.RowCount = 0 Then
            kBB = viewPiutang.GetFocusedRowCellValue("jns_inv").ToString
            kKar = viewPiutang.GetFocusedRowCellValue("kd_cust").ToString
            loadDetil(kBB, kKar)
            jml = viewDetil.GetFocusedRowCellValue("jml_bayar")
            If Not jml <= 0 Then
                kInv = viewDetil.GetFocusedRowCellValue("no_inv").ToString
                loadLunas(kInv, kKar)
                kodetrans = viewLunas.GetFocusedRowCellValue("no_trans_d").ToString
                loadGiro(kodetrans)
            Else
                If Not dsLunas.Tables("Lunas") Is Nothing Then dsLunas.Tables("Lunas").Clear()
            End If
        Else
            If txtNoTrans.Text = "" Then
                If Not dsDetil.Tables("Detil") Is Nothing Then dsDetil.Tables("Detil").Clear()
                If Not dsLunas.Tables("Lunas") Is Nothing Then dsLunas.Tables("Lunas").Clear()
                If Not dsGiro.Tables("Giro") Is Nothing Then dsGiro.Tables("Giro").Clear()
            Else
                loadDetil()
                loadLunas()
                loadGiro()
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

            kBB = viewPiutang.GetFocusedRowCellValue("jns_inv").ToString
            kKar = viewPiutang.GetFocusedRowCellValue("kd_cust").ToString

            kodeKary = kKar
            loadDetil(kBB, kKar)
            jml = viewDetil.GetFocusedRowCellValue("jml_bayar")
            If Not jml <= 0 Then
                kInv = viewDetil.GetFocusedRowCellValue("no_inv").ToString
                loadLunas(kInv, kKar)
                kodetrans = viewLunas.GetFocusedRowCellValue("no_trans_d").ToString
                loadGiro(kodetrans)
            Else
                If Not dsLunas.Tables("Lunas") Is Nothing Then dsLunas.Tables("Lunas").Clear()
                If Not dsGiro.Tables("Giro") Is Nothing Then dsGiro.Tables("Giro").Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub gvLunas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvLunas.Click
        Try

            Dim viewPiutang As ColumnView = gvPiutang
            Dim viewDetil As ColumnView = gvDetil
            Dim viewLunas As ColumnView = gvLunas
            Dim viewGiro As ColumnView = gvGiro
            Dim vgiro As Integer
            Dim jml As Integer

            jml = viewDetil.GetFocusedRowCellValue("jml_bayar")
            If Not jml <= 0 Then
                kodetrans = viewLunas.GetFocusedRowCellValue("no_trans_d").ToString
                loadGiro(kodetrans)
                vgiro = viewGiro.GetFocusedRowCellValue("no_trans_d").ToString
                If vgiro <= 0 Then
                    If Not dsGiro.Tables("Giro") Is Nothing Then dsGiro.Tables("Giro").Clear()
                End If
            Else
                If Not dsGiro.Tables("Giro") Is Nothing Then dsGiro.Tables("Giro").Clear()
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
            'kodetrans = viewLunas.GetFocusedRowCellValue("no_trans_d").ToString
            If Not jml <= 0 Then
                kInv = viewDetil.GetFocusedRowCellValue("no_inv").ToString
                loadLunas(kInv, kKar)
                'loadGiro(kodetrans)
            Else
                If Not dsLunas.Tables("Lunas") Is Nothing Then dsLunas.Tables("Lunas").Clear()
                If Not dsGiro.Tables("Giro") Is Nothing Then dsGiro.Tables("Giro").Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        If isSearch = True Then
            loadAll()
        End If
        kodeKary = ""
        kodeInvo = ""
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
        'If Not kodeKary = "" Then
        '    If Not kodeInvo = "" Then
        '        callReport(App_Path() & "\report\repKartuRinciComm.rpt", "", "periode=" & Format(deTglAkhir.EditValue, "yyyyMM") & "&val=IDR&kartu=" & kodeKary & "&inv=" & kodeInvo, False)
        '    Else
        '        callReport(App_Path() & "\report\repKartuRinciComm.rpt", "", "periode=" & Format(deTglAkhir.EditValue, "yyyyMM") & "&val=IDR&kartu=" & kodeKary & "&inv=", False)
        '    End If
        'Else
        '    MsgBox("Tidak ada data yang dipilih untuk dicetak. " & vbCrLf & "Pilih salah satu data dari tabel Rekapitulasi Data Piutang Usaha." & vbCrLf & "(Jika ingin mencetak nota yang spesifik, pilih pada tabel Data Detil Piutang Usaha)", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "PEMBERITAHUAN!")
        'End If
        'kodeKary = ""
        'kodeInvo = ""
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
        Dim reportHeader As String = "REKAP DATA PIUTANG USAHA SPON"
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
        Dim reportHeader As String = "REKAP DATA DETIL PIUTANG USAHA SPON"
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
        Dim reportHeader As String = "REKAP DATA PELUNASAN PIUTANG USAHA SPON"
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

    Private Sub gvPiutang_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvPiutang.FocusedRowChanged
        Try
            Dim kBB As String
            Dim kKar As String
            Dim viewPiutang As ColumnView = gvPiutang
            Dim kInv As String
            Dim viewDetil As ColumnView = gvDetil
            Dim viewLunas As ColumnView = gvLunas
            Dim jml As Integer

            kBB = viewPiutang.GetFocusedRowCellValue("jns_inv").ToString
            kKar = viewPiutang.GetFocusedRowCellValue("kd_cust").ToString

            kodeKary = kKar
            loadDetil(kBB, kKar)
            jml = viewDetil.GetFocusedRowCellValue("jml_bayar")
            If Not jml <= 0 Then
                kInv = viewDetil.GetFocusedRowCellValue("no_inv").ToString
                loadLunas(kInv, kKar)
                kodetrans = viewLunas.GetFocusedRowCellValue("no_trans_d").ToString
                loadGiro(kodetrans)
            Else
                If Not dsLunas.Tables("Lunas") Is Nothing Then dsLunas.Tables("Lunas").Clear()
                If Not dsGiro.Tables("Giro") Is Nothing Then dsGiro.Tables("Giro").Clear()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub deTglAwal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTglAwal.EditValueChanged
        If Not deTglAwal.EditValue = vbNullString Then
            deTglAkhir.Properties.MinValue = deTglAwal.EditValue
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
