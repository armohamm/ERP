'tgl 23/09/2001
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports System.Drawing
Imports DevExpress.XtraPrinting

Public Class formMonPiutUshSpringTotal1
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

        daLookKar = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT b.kd_cust, a.nama FROM FIN.dbo.v_kartu a, FIN.dbo.FIN_NOTA b WHERE (b.tipe_trans LIKE 'JPJ-KPT-01%' or  b.tipe_trans LIKE 'JPJ-KPT-05%') AND a.kode=b.kd_cust AND jml_akhir > 0 UNION SELECT '00000', '[Semua Data]'", sqlconn))
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
                    'If deTglAwal.EditValue = vbNullString Then
                    '    daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', jns_inv, kd_cust, SUM(jml_akhir) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE (tipe_trans LIKE 'JPJ-KPT-01%' or  tipe_trans LIKE 'JPJ-KPT-05%') AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY jns_inv, kd_cust", sqlconn))
                    'Else
                    daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', kd_cust, SUM(jml_tagihan) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE (tipe_trans LIKE 'JPJ-KPT-01%' or  tipe_trans LIKE 'JPJ-KPT-05%') AND tgl_posting BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY kd_cust", sqlconn))
                    'End If
                Else
                    'If deTglAwal.EditValue = vbNullString Then
                    '    daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', jns_inv, kd_cust, SUM(jml_akhir) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE (tipe_trans LIKE 'JPJ-KPT-01%' or  tipe_trans LIKE 'JPJ-KPT-05%') AND kd_cust LIKE '%" & lueKaryawan.EditValue & "%' AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY jns_inv, kd_cust", sqlconn))
                    'Else
                    daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', kd_cust, SUM(jml_tagihan) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE (tipe_trans LIKE 'JPJ-KPT-01%' or  tipe_trans LIKE 'JPJ-KPT-05%') AND kd_cust LIKE '%" & lueKaryawan.EditValue & "%' AND tgl_posting BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY kd_cust", sqlconn))
                    'End If
                End If
            Else
                If lueKaryawan.EditValue = "00000" Or lueKaryawan.EditValue = vbNullString Then
                    'If deTglAwal.EditValue = vbNullString Then
                    '    daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', jns_inv, kd_cust, SUM(jml_akhir) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE (tipe_trans LIKE 'JPJ-KPT-01%' or  tipe_trans LIKE 'JPJ-KPT-05%') AND jml_akhir > 0 AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY kd_buku_besar, kd_cust", sqlconn))
                    'Else
                    daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', kd_cust, SUM(jml_tagihan) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE (tipe_trans LIKE 'JPJ-KPT-01%' or  tipe_trans LIKE 'JPJ-KPT-05%') AND jml_akhir > 0 AND tgl_posting BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY kd_cust", sqlconn))
                    'End If
                Else
                    'If deTglAwal.EditValue = vbNullString Then
                    '    daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', jns_inv, kd_cust, SUM(jml_akhir) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE (tipe_trans LIKE 'JPJ-KPT-01%' or  tipe_trans LIKE 'JPJ-KPT-05%') AND kd_cust LIKE '%" & lueKaryawan.EditValue & "%' AND jml_akhir > 0 AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY jns_inv, kd_cust", sqlconn))
                    'Else
                    daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', kd_cust, SUM(jml_tagihan) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE (tipe_trans LIKE 'JPJ-KPT-01%' or  tipe_trans LIKE 'JPJ-KPT-05%') AND kd_cust LIKE '%" & lueKaryawan.EditValue & "%' AND jml_akhir > 0 AND tgl_posting BETWEEN CONVERT(DATE,'" & deTglAwal.EditValue & "',103) AND CONVERT(DATE,'" & deTglAkhir.EditValue & "',103) AND NOT (no_posting IS NULL OR no_posting = '') GROUP BY kd_cust", sqlconn))
                    'End If
                End If
            End If
        Else
            daPiut = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT ROW_NUMBER() OVER (ORDER BY kd_cust) as 'nomer', kd_cust, SUM(jml_tagihan) as 'sisa' FROM FIN.dbo.FIN_NOTA WHERE no_inv LIKE '%" & txtNoTrans.EditValue & "%' GROUP BY kd_cust", sqlconn))
        End If
        daPiut.Fill(dsPiut, "Piutang")
        gcPiutang.DataSource = dsPiut.Tables("Piutang")
        gvPiutang.BestFitColumns()
    End Sub

    Private Sub loadAll()
        Dim kBB As String
        Dim kKar As String
        Dim viewPiutang As ColumnView = gvPiutang
        Dim kInv As String
        Dim jml As Integer

        loadLookUp()
        loadPiutang()
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
        loadAll()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        If isSearch = True Then
            loadAll()
        End If
        kodeKary = ""
        kodeInvo = ""
    End Sub

    Public Sub cetak_click()
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
    End Sub

    Private Sub lueKaryawan_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueKaryawan.EditValueChanged
        If Not gvPiutang.RowCount <= 0 Then
            gvPiutang.FocusedRowHandle = 0
        End If
    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If chkAll.Checked = True Then
            chkOutstanding.Checked = False
        End If
    End Sub

    Private Sub chkOutstanding_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If chkOutstanding.Checked = True Then
            chkAll.Checked = False
        End If
    End Sub

    Private Sub PrintableComponentLinkPiutang_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLinkPiutang.CreateReportHeaderArea
        Dim reportHeader As String = "REKAP DATA PIUTANG USAHA SPRING"
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
End Class
