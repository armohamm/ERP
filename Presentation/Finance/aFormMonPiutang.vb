Imports System.Data.SqlClient
Imports System.Drawing
Imports DevExpress.XtraPrinting

Public Class aFormMonPiutang
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Dim dsMon As New DataSet
    Dim daMon, daCust, daStok, daRek, daTipeTrans, daTT As SqlDataAdapter
    Dim subReport As String

    Private Sub reload_table()
        If dtpTglAwal.EditValue > dtpTglAkhir.EditValue Then
            MsgBox("Tanggal awal tidak boleh lebih besar dari tanggal akhir.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            Exit Sub
        ElseIf dtpTglAkhir.EditValue < dtpTglAwal.EditValue Then
            MsgBox("Tanggal akhir tidak boleh lebih kecil dari tanggal awal.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            Exit Sub
        Else
            Dim param As String = ""
            Dim kolom As String = ""
            If dtpTglAwal.Text = "" Then
                If Not dtpTglAkhir.Text = "" Then
                    If lckTipeTrans.EditValue = vbNullString Or lckTipeTrans.EditValue = "00000" Then
                        param = " where not (no_posting is null or no_posting = '') and tgl_inv < convert(date,'" & dtpTglAkhir.EditValue & "',103)"
                    ElseIf lckTipeTrans.EditValue = "JPJ-KPT-00" Then
                        param = " where not (no_posting is null or no_posting = '') and tgl_inv < convert(date,'" & dtpTglAkhir.EditValue & "',103) and tipe_trans LIKE 'JPJ-KPT-%'"
                    Else
                        param = " where not (no_posting is null or no_posting = '') and tgl_inv < convert(date,'" & dtpTglAkhir.EditValue & "',103) and tipe_trans LIKE '" & lckTipeTrans.EditValue & "'"
                    End If
                Else
                    If lckTipeTrans.EditValue = vbNullString Or lckTipeTrans.EditValue = "00000" Then
                        param = " where not (no_posting is null or no_posting = '')"
                    ElseIf lckTipeTrans.EditValue = "JPJ-KPT-00" Then
                        param = " where not (no_posting is null or no_posting = '') AND tipe_trans LIKE 'JPJ-KPT-%'"
                    Else
                        param = " where not (no_posting is null or no_posting = '') AND tipe_trans LIKE '" & lckTipeTrans.EditValue & "'"
                    End If
                End If
            Else
                If Not dtpTglAkhir.Text = "" Then
                    If lckTipeTrans.EditValue = vbNullString Or lckTipeTrans.EditValue = "00000" Then
                        param = " where not (no_posting is null or no_posting = '') and tgl_inv between convert(date,'" & dtpTglAwal.EditValue & "',103) and convert(date,'" & dtpTglAkhir.EditValue & "',103)"
                    ElseIf lckTipeTrans.EditValue = "JPJ-KPT-00" Then
                        param = " where not (no_posting is null or no_posting = '') and tipe_trans LIKE 'JPJ-KPT-%' and tgl_inv between convert(date,'" & dtpTglAwal.EditValue & "',103) and convert(date,'" & dtpTglAkhir.EditValue & "',103)"
                    Else
                        param = " where not (no_posting is null or no_posting = '') and tipe_trans LIKE '" & lckTipeTrans.EditValue & "' and tgl_inv between convert(date,'" & dtpTglAwal.EditValue & "',103) and convert(date,'" & dtpTglAkhir.EditValue & "',103)"
                    End If
                Else
                    If lckTipeTrans.EditValue = vbNullString Or lckTipeTrans.EditValue = "00000" Then
                        param = " where not (no_posting is null or no_posting = '') and tgl_inv > convert(date,'" & dtpTglAwal.EditValue & "',103)"
                    ElseIf lckTipeTrans.EditValue = "JPJ-KPT-00" Then
                        param = " where not (no_posting is null or no_posting = '') and tgl_inv > convert(date,'" & dtpTglAwal.EditValue & "',103) and tipe_trans LIKE 'JPJ-KPT-%'"
                    Else
                        param = " where not (no_posting is null or no_posting = '') and tgl_inv > convert(date,'" & dtpTglAwal.EditValue & "',103) and tipe_trans LIKE '" & lckTipeTrans.EditValue & "'"
                    End If
                End If
            End If

            For Each itm As Object In cmbKolom.Properties.Items
                gvMon.Columns(itm.Value).Visible = False
                'gvMon.Columns(itm.Value).UnGroup()
                If itm.CheckState = CheckState.Checked Then
                    kolom &= itm.Value & ", "
                    gvMon.Columns(itm.Value).Visible = True
                End If
            Next

            If kolom = "" Then Exit Sub
            kolom = kolom.Substring(0, Len(kolom) - 2)
            If Not dsMon.Tables("Piutang") Is Nothing Then dsMon.Tables("Piutang").Clear()
            daMon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT " & kolom & " FROM FIN.dbo.v_trans_AR " & param, sqlconn))
            daMon.Fill(dsMon, "Piutang")
            gcMon.DataSource = dsMon.Tables("Piutang")
            gvMon.BestFitColumns()
        End If

    End Sub

    Private Sub loadLookUp()
        If Not dsMon.Tables("Cust") Is Nothing Then dsMon.Tables("Cust").Clear()
        If Not dsMon.Tables("Stok") Is Nothing Then dsMon.Tables("Stok").Clear()
        If Not dsMon.Tables("TipeTrans") Is Nothing Then dsMon.Tables("TipeTrans").Clear()
        If Not dsMon.Tables("Rekening") Is Nothing Then dsMon.Tables("Rekening").Clear()
        If Not dsMon.Tables("TT") Is Nothing Then dsMon.Tables("TT").Clear()

        daCust = New SqlDataAdapter(New SqlCommand("SELECT kode, nama FROM FIN.dbo.v_kartu", sqlconn))
        daCust.Fill(dsMon, "Cust")
        lckCust.DataSource = dsMon.Tables("Cust")
        lckCust.DisplayMember = "nama"
        lckCust.ValueMember = "kode"

        daStok = New SqlDataAdapter(New SqlCommand("SELECT Kode_Barang, Nama_Barang FROM SIF.dbo.SIF_Barang", sqlconn))
        daStok.Fill(dsMon, "Stok")
        lckStok.DataSource = dsMon.Tables("Stok")
        lckStok.DisplayMember = "Nama_Barang"
        lckStok.ValueMember = "Kode_Barang"

        daRek = New SqlDataAdapter(New SqlCommand("SELECT kd_buku_besar, nm_buku_besar FROM SIF.dbo.SIF_buku_besar", sqlconn))
        daRek.Fill(dsMon, "Rekening")
        lckBB.DataSource = dsMon.Tables("Rekening")
        lckBB.DisplayMember = "nm_buku_besar"
        lckBB.ValueMember = "kd_buku_besar"

        daTipeTrans = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT a.tipe_desc, b.tipe_trans FROM SIF.dbo.SIF_TIPE_TRANS a, FIN.dbo.v_trans_AR b WHERE a.tipe_trans=b.tipe_trans AND a.tipe_trans IN ('JKK-KPT-01','JKK-KPT-02') UNION SELECT 'Jurnal Permohonan Piutang Usaha', 'JPJ-KPT-00' UNION SELECT 'Semua transaksi', '00000'", sqlconn))
        daTipeTrans.Fill(dsMon, "TipeTrans")
        lckTipeTrans.Properties.DataSource = dsMon.Tables("TipeTrans")
        lckTipeTrans.Properties.DisplayMember = "tipe_desc"
        lckTipeTrans.Properties.ValueMember = "tipe_trans"

        daTT = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT a.tipe_desc, b.tipe_trans FROM SIF.dbo.SIF_TIPE_TRANS a, FIN.dbo.v_trans_AR b WHERE a.tipe_trans=b.tipe_trans", sqlconn))
        daTT.Fill(dsMon, "TT")
        lckTT.DataSource = dsMon.Tables("TT")
        lckTT.DisplayMember = "tipe_desc"
        lckTT.ValueMember = "tipe_trans"
    End Sub

    Private Sub aFormMonPiutang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        loadLookUp()
        lckTipeTrans.EditValue = "00000"
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        If cmbKolom.EditValue = "00000" Or cmbKolom.Text = "" Then
            For Each itmx As Object In cmbKolom.Properties.Items
                itmx.CheckState = CheckState.Checked
            Next
        End If
        reload_table()
    End Sub

    Public Sub cetak_click()
        If Not gvMon.RowCount <= 0 Then
            'ShowGridPreview(gcGiro)
            PrintableComponentLink1.CreateDocument()
            PrintableComponentLink1.ShowPreview()
        Else
            MsgBox("Tidak ada data yang dicetak. Silahkan mengisi filter dan menekan tombol Refresh.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
        End If
    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "MONITORING PIUTANG"
        If dtpTglAwal.EditValue = vbNullString Then
            If dtpTglAkhir.EditValue = vbNullString Then
                subReport = "Semua Data"
            Else
                subReport = "Tanggal " & Format(dtpTglAkhir.EditValue, "d MMMM yyyy").ToString
            End If
        Else
            If dtpTglAkhir.EditValue = vbNullString Then
                subReport = Format(dtpTglAwal.EditValue, "d MMMM yyyy").ToString & " s/d " & Format(getTanggal(), "d MMMM yyyy").ToString
            Else
                subReport = Format(dtpTglAwal.EditValue, "d MMMM yyyy").ToString & " s/d " & Format(dtpTglAkhir.EditValue, "d MMMM yyyy").ToString
            End If
        End If

        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        e.Graph.BackColor = Color.White
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 20)
        Dim rec2 As RectangleF = New RectangleF(0, 20, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None)
        e.Graph.DrawString(subReport, Color.Black, rec2, BorderSide.None)
    End Sub
End Class