'tgl 23/09/2001
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class formMonPiutLain2
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim dsPiut, dsDetil, dsLunas, dsLookUp As New DataSet
    Dim daLookKar, daLookBB, daLookKartu, daPiut, daPiutCari, daDetil, daDetilCari, daLunas, daLunasCari As SqlDataAdapter
    Dim err As String
    Dim isSearch As Boolean = True
    Dim kodeKary As String = ""
    Dim kodeInvo As String = ""

    Private Sub loadLookUp()
        dsLookUp = New DataSet
        daLookBB = New SqlDataAdapter(New SqlCommand("SELECT kd_buku_besar, nm_buku_besar FROM SIF.dbo.SIF_buku_besar", sqlconn))
        daLookBB.Fill(dsLookUp, "LookBB")
        lookBB.DataSource = dsLookUp.Tables("LookBB")
        lookBB.DisplayMember = "nm_buku_besar"
        lookBB.ValueMember = "kd_buku_besar"
        daLookKartu = New SqlDataAdapter(New SqlCommand("SELECT kode, nama FROM FIN.dbo.v_kartu", sqlconn))
        daLookKartu.Fill(dsLookUp, "LookKartu")
        lookKartu.DataSource = dsLookUp.Tables("LookKartu")
        lookKartu.DisplayMember = "nama"
        lookKartu.ValueMember = "kode"
        daLookKar = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT b.kd_cust, a.nama FROM FIN.dbo.v_kartu a, FIN.dbo.FIN_NOTA b WHERE a.kode=b.kd_cust AND b.tipe_trans LIKE 'JPJ%' AND jml_akhir > 0 UNION SELECT '00000', '[Semua Karyawan]'", sqlconn))
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
                If lueKaryawan.EditValue = "00000" Or lueKaryawan.EditValue = vbNullString Then
                    If deTglAkhir.EditValue = vbNullString Then
                        daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', kd_buku_besar, kd_cust, SUM(jml_akhir) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE tipe_trans = 'JKK-KPT-02' AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY kd_buku_besar, kd_cust", sqlconn))
                    Else
                        daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', kd_buku_besar, kd_cust, SUM(jml_akhir) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE tipe_trans = 'JKK-KPT-02' AND tgl_posting <= CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY kd_buku_besar, kd_cust", sqlconn))
                    End If
                Else
                    If deTglAkhir.EditValue = vbNullString Then
                        daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', kd_buku_besar, kd_cust, SUM(jml_akhir) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE tipe_trans = 'JKK-KPT-02' AND kd_cust LIKE '%" & lueKaryawan.EditValue & "%' AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY kd_buku_besar, kd_cust", sqlconn))
                    Else
                        daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', kd_buku_besar, kd_cust, SUM(jml_akhir) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE tipe_trans = 'JKK-KPT-02' AND kd_cust LIKE '%" & lueKaryawan.EditValue & "%' AND tgl_posting <= CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY kd_buku_besar, kd_cust", sqlconn))
                    End If
                End If
            Else
                If lueKaryawan.EditValue = "00000" Or lueKaryawan.EditValue = vbNullString Then
                    If deTglAkhir.EditValue = vbNullString Then
                        daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', kd_buku_besar, kd_cust, SUM(jml_akhir) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE tipe_trans = 'JKK-KPT-02' AND jml_akhir > 0 AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY kd_buku_besar, kd_cust", sqlconn))
                    Else
                        daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', kd_buku_besar, kd_cust, SUM(jml_akhir) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE tipe_trans = 'JKK-KPT-02' AND jml_akhir > 0 AND tgl_posting <= CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY kd_buku_besar, kd_cust", sqlconn))
                    End If
                Else
                    If deTglAkhir.EditValue = vbNullString Then
                        daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', kd_buku_besar, kd_cust, SUM(jml_akhir) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE tipe_trans = 'JKK-KPT-02' AND kd_cust LIKE '%" & lueKaryawan.EditValue & "%' AND jml_akhir > 0 AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY kd_buku_besar, kd_cust", sqlconn))
                    Else
                        daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', kd_buku_besar, kd_cust, SUM(jml_akhir) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE tipe_trans = 'JKK-KPT-02' AND kd_cust LIKE '%" & lueKaryawan.EditValue & "%' AND jml_akhir > 0 AND tgl_posting <= CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY kd_buku_besar, kd_cust", sqlconn))
                    End If
                End If
            End If
        Else
            daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', kd_buku_besar, kd_cust, SUM(jml_akhir) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE no_inv LIKE '%" & txtNoTrans.EditValue & "%' GROUP BY kd_buku_besar, kd_cust", sqlconn))
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
                If deTglAkhir.EditValue = vbNullString Then
                    daDetilCari = New SqlDataAdapter(New SqlCommand("SELECT no_inv, tgl_inv, no_jurnal, tgl_posting, keterangan, jml_tagihan, jml_bayar, jml_akhir, kd_cust FROM FIN.dbo.FIN_NOTA WHERE tipe_trans = 'JKK-KPT-02' AND kd_cust='" & kodeKar & "' AND kd_buku_besar ='" & kodeBB & "' AND NOT (no_posting IS NULL OR no_posting = '')", sqlconn))
                Else
                    daDetilCari = New SqlDataAdapter(New SqlCommand("SELECT no_inv, tgl_inv, no_jurnal, tgl_posting, keterangan, jml_tagihan, jml_bayar, jml_akhir, kd_cust FROM FIN.dbo.FIN_NOTA WHERE tipe_trans = 'JKK-KPT-02' AND kd_cust='" & kodeKar & "' AND kd_buku_besar ='" & kodeBB & "' AND tgl_posting <= CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '')", sqlconn))
                End If
            Else
                If deTglAkhir.EditValue = vbNullString Then
                    daDetilCari = New SqlDataAdapter(New SqlCommand("SELECT no_inv, tgl_inv, no_jurnal, tgl_posting, keterangan, jml_tagihan, jml_bayar, jml_akhir, kd_cust FROM FIN.dbo.FIN_NOTA WHERE tipe_trans = 'JKK-KPT-02' AND kd_cust='" & kodeKar & "' AND kd_buku_besar ='" & kodeBB & "' AND jml_akhir > 0 AND NOT (no_posting IS NULL OR no_posting = '')", sqlconn))
                Else
                    daDetilCari = New SqlDataAdapter(New SqlCommand("SELECT no_inv, tgl_inv, no_jurnal, tgl_posting, keterangan, jml_tagihan, jml_bayar, jml_akhir, kd_cust FROM FIN.dbo.FIN_NOTA WHERE tipe_trans = 'JKK-KPT-02' AND kd_cust='" & kodeKar & "' AND kd_buku_besar ='" & kodeBB & "' AND jml_akhir > 0 AND tgl_posting <= CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '')", sqlconn))
                End If
            End If
        Else
            daDetilCari = New SqlDataAdapter(New SqlCommand("SELECT no_inv, tgl_inv, no_jurnal, tgl_posting, keterangan, jml_tagihan, jml_bayar, jml_akhir, kd_cust FROM FIN.dbo.FIN_NOTA WHERE tipe_trans = 'JKK-KPT-01' AND no_inv='" & txtNoTrans.Text & "'", sqlconn))
        End If
        daDetilCari.Fill(dsDetil, "Detil")
        gcDetil.DataSource = dsDetil.Tables("Detil")
        gvDetil.BestFitColumns()
    End Sub

    Private Sub loadLunas(Optional ByVal kodeInv As String = "", Optional ByVal kodeKartu As String = "")
        dsLunas = New DataSet
        If Not dsLunas.Tables.Count <= 0 Then dsLunas.Tables.Clear()
        If txtNoTrans.Text = "" Then
            daLunasCari = New SqlDataAdapter(New SqlCommand("SELECT a.no_trans as no_trans_d, b.tgl_trans, b.no_trans, b.tgl_posting as tgl_posting_l, b.keterangan as keterangan_l, a.jml_bayar as jml_bayar_l FROM FIN.dbo.FIN_NOTA_LUNAS_D a, FIN.dbo.FIN_NOTA_LUNAS b WHERE a.no_trans=b.no_trans AND a.prev_no_inv = '" & kodeInv & "' AND a.kd_kartu = '" & kodeKartu & "' AND NOT (b.no_posting IS NULL OR b.no_posting = '')", sqlconn))
        Else
            daLunasCari = New SqlDataAdapter(New SqlCommand("SELECT a.no_trans as no_trans_d, b.tgl_trans, b.no_trans, b.tgl_posting as tgl_posting_l, b.keterangan as keterangan_l, a.jml_bayar as jml_bayar_l FROM FIN.dbo.FIN_NOTA_LUNAS_D a, FIN.dbo.FIN_NOTA_LUNAS b WHERE a.no_trans=b.no_trans AND a.prev_no_inv = '" & txtNoTrans.Text & "' AND NOT (b.no_posting IS NULL OR b.no_posting = '')", sqlconn))
        End If

        daLunasCari.Fill(dsLunas, "Lunas")
        gcLunas.DataSource = dsLunas.Tables("Lunas")
        gvLunas.BestFitColumns()
    End Sub

    Private Sub loadAll()
        Dim kBB As String
        Dim kKar As String
        Dim viewPiutang As ColumnView = gvPiutang
        Dim kInv As String
        Dim viewDetil As ColumnView = gvDetil
        Dim jml As Integer

        loadLookUp()
        loadPiutang()
        If Not gvPiutang.RowCount = 0 Then
            kBB = viewPiutang.GetFocusedRowCellValue("kd_buku_besar").ToString
            kKar = viewPiutang.GetFocusedRowCellValue("kd_cust").ToString
            loadDetil(kBB, kKar)
            jml = viewDetil.GetFocusedRowCellValue("jml_bayar")
            If Not jml <= 0 Then
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

    Private Sub formMonPiutLain2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        txtNoTrans.Text = ""
        lueKaryawan.EditValue = "00000"
        deTglAkhir.EditValue = getTanggal()
        chkAll.Checked = True
        loadAll()
    End Sub

    Private Sub gvPiutang_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvPiutang.Click
        Try
            Dim kBB As String
            Dim kKar As String
            Dim viewPiutang As ColumnView = gvPiutang
            Dim kInv As String
            Dim viewDetil As ColumnView = gvDetil
            Dim jml As Integer

            kBB = viewPiutang.GetFocusedRowCellValue("kd_buku_besar").ToString
            kKar = viewPiutang.GetFocusedRowCellValue("kd_cust").ToString
            kodeKary = kKar
            loadDetil(kBB, kKar)
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
        If Not kodeKary = "" Then
            If Not kodeInvo = "" Then
                callReport(App_Path() & "\report\repKartuRinciComm.rpt", "", "periode=" & Format(deTglAkhir.EditValue, "yyyyMM") & "&val=IDR&kartu=" & kodeKary & "&inv=" & kodeInvo, False)
            Else
                callReport(App_Path() & "\report\repKartuRinciComm.rpt", "", "periode=" & Format(deTglAkhir.EditValue, "yyyyMM") & "&val=IDR&kartu=" & kodeKary & "&inv=", False)
            End If
        Else
            MsgBox("Tidak ada data yang dipilih untuk dicetak. " & vbCrLf & "Pilih salah satu data dari tabel Rekapitulasi Data Piutang Usaha." & vbCrLf & "(Jika ingin mencetak nota yang spesifik, pilih pada tabel Data Detil Piutang Usaha)", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "PEMBERITAHUAN!")
        End If
        kodeKary = ""
        kodeInvo = ""
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
End Class
