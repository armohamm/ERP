'|-----------------------
'|  CREATED BY RENDY    |
'|  EDITED BY RENDY     |
'|-----------------------
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Public Class frmMonitorHTGL1
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = True
    Public prn As frmMain
    Dim err As String = ""
    Dim isvalid As Boolean

    Dim saldoawal As String
    Dim saldohari As String
    Dim saldoakhir1 As String
    Dim saldoakhir2 As String

    Dim dsValuta, dsRek, dsGrid, dsSal As New DataSet
    Dim daValuta, daJurnalD, daRek, daGrid, daSal As SqlDataAdapter

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnDelete = True
        btnCancel = True
        btnCetak = True
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

    Private Sub frmMonitorHTGL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        loadList()
        Me.Enabled = True
        GVMonHTGL.BestFitColumns()

        ToolTip1.SetToolTip(Rekening, "Rekening wajib diisi")
        ToolTip1.SetToolTip(Valuta, "Valuta wajib diisi")
        ToolTip1.SetToolTip(tglDari, "Tanggal Sampai wajib diisi")
        ToolTip1.SetToolTip(tglsampai, "Tanggal Dari wajib diisi")

        Valuta.EditValue = "IDR"
        Rekening.ItemIndex = 0

        'select 
        'A.kartu , A.bln_buku , A.thn_buku , A.kd_buku_besar , b.nm_buku_besar, A.kd_buku_pusat , c.nm_buku_pusat , A.status ,a.jml_val_debet  ,a.jml_val_kredit
        'from FIN.dbo.FIN_NERACA_SALDO A , SIF.dbo.SIF_buku_besar B, SIF.dbo.SIF_buku_pusat C
        'where a.kd_buku_besar = b.kd_buku_besar 
        'and a.kd_buku_pusat = C.kd_buku_pusat 

        daSal = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select A.kartu, A.bln_buku, A.thn_buku, A.kd_buku_besar, b.nm_buku_besar, A.kd_buku_pusat, c.nm_buku_pusat, A.status, a.jml_val_debet, a.jml_val_kredit from KOPKAR.dbo.FIN_NERACA_SALDO A , KOPKAR.dbo.m_buku_besar B, KOPKAR.dbo.SIF_buku_pusat C where(a.kd_buku_besar = b.kd_buku_besar) and a.kd_buku_pusat = C.kd_buku_pusat ", sqlconn))
        daSal.Fill(dsSal, "_saldo")
        LookUpSaldo.Properties.DataSource = dsSal.Tables("_saldo")
        LookUpSaldo.Properties.ValueMember = "XXX"
        LookUpSaldo.Properties.DisplayMember = "XXX"

        tglDari.EditValue = getTanggal()
        tglsampai.EditValue = getTanggal()

        'Try
        '    Rekening.ItemIndex = 0
        '    Valuta.ItemIndex = 0
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub loadList()
        'dsJurnal.Tables("Valuta").Clear()
        'dsJurnal.Tables("BukuBesar").Clear()
        'dsJurnal.Tables("Kartu").Clear()
        'dsJurnal.Tables("BukuPusat").Clear()
        If Not dsValuta.Tables("Valuta") Is Nothing Then dsValuta.Tables("Valuta").Clear()
        If Not dsRek.Tables("Rekening") Is Nothing Then dsRek.Tables("Rekening").Clear()

        daValuta = New SqlDataAdapter(New SqlCommand("select Kode_Valuta, Nama_Valuta from KOPKAR.dbo.SIF_Valuta", sqlconn))
        daValuta.Fill(dsValuta, "Valuta")
        Valuta.Properties.DataSource = dsValuta.Tables("Valuta")
        Valuta.Properties.DisplayMember = "Nama_Valuta"
        Valuta.Properties.ValueMember = "Kode_Valuta"

        daRek = New SqlDataAdapter(New SqlCommand("SELECT kd_buku_besar, nm_buku_besar FROM KOPKAR.dbo.m_buku_besar WHERE grup_header='D' AND rec_stat = 'Y' ", sqlconn))
        daRek.Fill(dsRek, "Rekening")
        Rekening.Properties.DataSource = dsRek.Tables("Rekening")
        Rekening.Properties.DisplayMember = "nm_buku_besar"
        Rekening.Properties.ValueMember = "kd_buku_besar"

        'LOAD ALL DATABASE
        'daGrid = New SqlDataAdapter(New SqlCommand("select ROW_NUMBER() OVER (ORDER BY a.no_jur) as 'nomer', A.no_jur, tgl_trans,B.tgl_posting, B.no_ref1, B.no_ref3,nama, B.keterangan,kd_buku_besar,saldo_val_debet,saldo_val_kredit from fin.dbo.FIN_JURNAL_D A , fin.dbo.FIN_JURNAL B", sqlconn))
        ''daGrid = New SqlDataAdapter(New SqlCommand("select A.no_jur, tgl_trans,B.tgl_posting, B.no_ref1, B.no_ref3,nama, B.keterangan,kd_buku_besar,saldo_val_debet,saldo_val_kredit from fin.dbo.FIN_JURNAL_D A , fin.dbo.FIN_JURNAL B", sqlconn))
        'daGrid.Fill(dsGrid, "BukuBesar")
        'GCMonHTGL.DataSource = dsGrid.Tables("BukuBesar")
        'GVMonHTGL.BestFitColumns()


    End Sub

    Sub CekSaldoAwal()
        'Select SUM(jml_val_debet - jml_val_kredit)
        'from FIN.dbo.FIN_NERACA_SALDO
        'where kd_buku_besar = '1-121000'
        'and kd_valuta = 'IDR'
        'and thn_buku = '2011' and bln_buku = '8'

        'If tglDari.EditValue = vbNullString Then
        '    If tglsampai.EditValue = vbNullString Then
        '    Else
        '    End If
        'End If

        Try
            Dim dr2 As SqlDataReader = New SqlCommand("Select SUM(jml_val_debet - jml_val_kredit) " & _
            "  from FIN.dbo.FIN_NERACA_SALDO_copy  " & _
            "  where kd_buku_besar like '%" & Rekening.EditValue & "%' " & _
            "  and kd_valuta = '" & Valuta.EditValue & "' " & _
            "  and thn_buku = '" & tglDari.DateTime.Year & "' " & _
            "  and bln_buku = " & tglDari.DateTime.Month - 1, sqlconn).ExecuteReader

            dr2.Read()
            If dr2.HasRows Then
                txtSaldoAwalManual.EditValue = dr2.Item(0)
            End If
            Dim f As Long
            f = txtSaldoAwalManual.Text
            'txtSaldoAwal.Text = Format(f, "##,##0")
        Catch ex As Exception
            txtSaldoAwalManual.Text = 0
            'MsgBox(ex.Message)
            'MsgBox("SALDO AWAL TIDAK ADA")
        End Try

        'MsgBox(tglDari.DateTime.Month - 1)
    End Sub

    Sub ceksaldohaarian()
        'Select SUM(b.saldo_val_debet - b.saldo_val_kredit)
        'from FIN.dbo.FIN_JURNAL A, FIN.dbo.FIN_JURNAL_D B
        'where a.no_jur = b.no_jur
        'and a.tgl_posting  between '2011-9-06' and '2011-9-30'
        'and b.kd_buku_besar = '1-121000'
        'and a.kd_valuta = 'IDR'
        'and a.no_posting is not null

        Try
            Dim dr As SqlDataReader = New SqlCommand(" Select SUM(b.saldo_val_debet) - sum(b.saldo_val_kredit) " & _
            "  from KOPKAR.dbo.FIN_JURNAL A INNER JOIN KOPKAR.dbo.FIN_JURNAL_D B  " & _
            "  ON (A.no_jur = B.no_jur) " & _
            "  where A.tgl_trans between convert(date,'" & tglDari.EditValue & "',103) and convert(date,'" & tglsampai.EditValue & "',103)  " & _
            "  and B.kd_buku_besar = '" & Rekening.EditValue & "'  " & _
            "  and A.kd_valuta = '" & Valuta.EditValue & "' " & _
            "  and not(A.no_posting is null or A.no_posting = '')", sqlconn).ExecuteReader

            dr.Read()
            If dr.HasRows Then
                saldohari = dr.Item(0)
            End If

        Catch ex As Exception
            saldohari = 0
            'MsgBox(ex.Message)
        End Try

    End Sub

    'Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
    '    bersih()
    '    LoadAllData()
    '    GVMonHTGL.BestFitColumns()

    '    hitungDebetKredit()
    'End Sub

    Sub LoadAllData()
        'select ROW_NUMBER() OVER (ORDER BY a.no_jur) as 'nomer',
        'A.no_jur, tgl_trans,A.tgl_posting , A.no_ref1, A.no_ref3 , 
        'nama, B.keterangan, B.kd_buku_besar, C.nm_buku_besar, 
        'b.saldo_val_debet, b.saldo_val_kredit 
        'from FIN.dbo.FIN_JURNAL A, FIN.dbo.FIN_JURNAL_D B , SIF.dbo.SIF_buku_besar C 
        'where A.no_jur = B.no_jur
        'and B.kd_buku_besar = C.kd_buku_besar  
        'and A.no_posting is not null

        daGrid = New SqlDataAdapter(New SqlCommand("select ROW_NUMBER() OVER (ORDER BY a.no_jur) as 'nomer',  A.no_jur, tgl_trans,A.tgl_posting , A.no_ref1, A.no_ref3 , nama, B.keterangan, B.kd_buku_besar, C.nm_buku_besar, b.saldo_val_debet, b.saldo_val_kredit from KOPKAR.dbo.FIN_JURNAL A, KOPKAR.dbo.FIN_JURNAL_D B , KOPKAR.dbo.m_buku_besar C where(A.no_jur = B.no_jur) and B.kd_buku_besar = C.kd_buku_besar  and A.no_posting is not null", sqlconn))
        'daGrid = New SqlDataAdapter(New SqlCommand("select A.no_jur, tgl_trans,B.tgl_posting, B.no_ref1, B.no_ref3,nama, B.keterangan,kd_buku_besar,saldo_val_debet,saldo_val_kredit from fin.dbo.FIN_JURNAL_D A , fin.dbo.FIN_JURNAL B", sqlconn))
        daGrid.Fill(dsGrid, "BukuBesar")
        GCMonHTGL.DataSource = dsGrid.Tables("BukuBesar")
        GVMonHTGL.BestFitColumns()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'MsgBox(tglDari.DateTime.Year)
        'MsgBox(tglDari.DateTime.Month)
        MsgBox("Saldo Bulan ke : " & tglDari.DateTime.Month - 1 & " Tahun : " & tglDari.DateTime.Year)
        'cek()
        CekSaldoAwal()
    End Sub

    Sub refreshGrid()
        dsGrid.Clear()
        daGrid = New SqlDataAdapter(New SqlCommand("select ROW_NUMBER() OVER (ORDER BY a.no_jur) as 'nomer',  A.no_jur, tgl_trans,A.tgl_posting , A.no_ref1, A.no_ref3 , nama, B.keterangan, B.kd_buku_besar, C.nm_buku_besar, saldo_val_debet, saldo_val_kredit from FIN.dbo.FIN_JURNAL A, FIN.dbo.FIN_JURNAL_D B , SIF.dbo.SIF_buku_besar C where(A.no_jur = B.no_jur) and B.kd_buku_besar = C.kd_buku_besar  and A.no_posting is not null", sqlconn))
        daGrid.Fill(dsGrid, "BukuBesar")
        GCMonHTGL.DataSource = dsGrid.Tables("BukuBesar")
        GVMonHTGL.BestFitColumns()
    End Sub

    Sub ListHarian()
        If Not dsGrid.Tables("BukuBesar") Is Nothing Then dsGrid.Tables("BukuBesar").Clear()
        'select ROW_NUMBER() OVER (ORDER BY a.no_jur) as 'nomer',
        'A.no_jur, tgl_trans,A.tgl_posting , A.no_ref1, A.no_ref3 ,
        'nama, B.keterangan,B.kd_buku_besar,C.nm_buku_besar,b.saldo_val_debet,b.saldo_val_kredit 
        'from FIN.dbo.FIN_JURNAL A, FIN.dbo.FIN_JURNAL_D B , SIF.dbo.SIF_buku_besar C
        'where a.no_jur = b.no_jur 
        'and B.kd_buku_besar = C.kd_buku_besar 
        'and a.tgl_posting between '9/5/2011' and '9/30/2011' 
        'and b.kd_buku_besar = '1-121000' 
        'and A.kd_valuta = 'IDR'
        'and a.no_posting is not null

        dsGrid.Clear()
        daGrid = New SqlDataAdapter(New SqlCommand("select A.no_jur, A.tgl_trans, A.tgl_posting , A.no_ref1, A.no_ref3 , A.nama, B.keterangan, B.kd_buku_besar, C.nm_buku_besar, b.saldo_val_debet, b.saldo_val_kredit from KOPKAR.dbo.FIN_JURNAL A INNER JOIN KOPKAR.dbo.FIN_JURNAL_D B ON (A.no_jur = B.no_jur), KOPKAR.dbo.m_buku_besar C where B.kd_buku_besar = C.kd_buku_besar " & _
        "  and a.tgl_trans between convert(date, '" & tglDari.EditValue & "',103) and convert (date,'" & tglsampai.EditValue & "',103) and b.kd_buku_besar like '%" & Rekening.EditValue & "%' and A.kd_valuta = '" & Valuta.EditValue & "' and not(a.no_posting is null or a.no_posting = '') order by A.tgl_trans", sqlconn))
        daGrid.Fill(dsGrid, "BukuBesar")
        GCMonHTGL.DataSource = dsGrid.Tables("BukuBesar")
        GVMonHTGL.BestFitColumns()
        'refreshNomer(GVMonHTGL)
    End Sub

    Private Sub refreshNomer(ByVal grid As GridView)
        Dim x As Object
        Dim i As Int16
        If grid.RowCount = 0 Then
            Exit Sub
        Else
            x = CType(GCMonHTGL.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
            For i = 0 To GCMonHTGL.FocusedView.RowCount - 1
                GCMonHTGL.FocusedView.GetRow(i).Item("nomer") = i + 1
            Next
        End If
    End Sub

    Private Sub CekFinal()
        CekSaldoAwal()

        Dim dr As SqlDataReader = New SqlCommand("SELECT KOPKAR.dbo.hitungsaldoawal('" & Rekening.EditValue & "', '" & Valuta.EditValue & "','" & tglDari.DateTime.Year & "', '" & tglDari.DateTime.Month & "', '" & tglDari.DateTime.Day & "')", sqlconn).ExecuteReader
        dr.Read()
        If dr.HasRows Then
            txtSaldoAwal.EditValue = dr.Item(0)
            'txtSaldoAwal.EditValue = txtSaldoAwalManual.EditValue

            'Dim g As Long
            'g = txtSaldoAwal.EditValue
            'txtSaldoAwal.EditValue = Format(g, "##,##0")
        Else
            txtSaldoAwal.EditValue = "0"
        End If

        ListHarian()
        ceksaldohaarian()

        Try


            'OPSI JIKA MENGGUNAKAN QUERY SALDO HARIAN 
            'MsgBox(" Saldo Harian : " & saldohari)
            'saldoakhir1 = CDbl(txtSaldoAwal.Text) + saldohari
            saldoakhir1 = CDbl(txtSaldoAwal.EditValue) + saldohari

            'OPSI JIKA MENGGUNAKAN PENJUMLAHAN DENGAN GV.SUMMARYTEXT
            'MsgBox(" Saldo Harian : " & GVMonHTGL.Columns("saldo_val_debet").SummaryText - GVMonHTGL.Columns("saldo_val_kredit").SummaryText)
            'saldoakhir2 = CDbl(txtSaldoAwal.Text) + (GVMonHTGL.Columns("saldo_val_debet").SummaryText - GVMonHTGL.Columns("saldo_val_kredit").SummaryText)
            saldoakhir2 = txtSaldoAwal.EditValue + (GVMonHTGL.Columns("saldo_val_debet").SummaryText - GVMonHTGL.Columns("saldo_val_kredit").SummaryText)

            hitungDebetKredit()

            txtSaldoAkhir.EditValue = saldoakhir2

            'If saldohari <> (GVMonHTGL.Columns("saldo_val_debet").SummaryText - GVMonHTGL.Columns("saldo_val_kredit").SummaryText) Then
            '    lblError.Text = ("cek kembali proses perhitungan saldo step ceksaldohaarian() dan GV.SUMMARYTEXT")
            'ElseIf saldoakhir1 <> saldoakhir2 Then
            '    lblError.Text = ("cek kembali proses perhitungan saldoakhir1 dan saldoakhir2 ")
            'Else

            '    'Dim f As Long
            '    'f = txtSaldoAkhir.Text
            '    'txtSaldoAkhir.Text = Format(f, "##,##0")
            'End If
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try
    End Sub

    Sub hitungDebetKredit()
        TxtDebetKredit.EditValue = GVMonHTGL.Columns("saldo_val_debet").SummaryText - GVMonHTGL.Columns("saldo_val_kredit").SummaryText
        'Dim g As Long
        'g = TxtDebetKredit.EditValue
        'TxtDebetKredit.EditValue = Format(g, "##,##0")
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        bersih()
    End Sub

    Sub bersih()
        dsGrid.Clear()
        GCMonHTGL.DataSource = dsGrid.Tables("BukuBesar")
        GVMonHTGL.BestFitColumns()

        Rekening.ItemIndex = 0
        Valuta.EditValue = "IDR"
        tglDari.EditValue = getTanggal()
        tglsampai.EditValue = getTanggal()
        TxtDebetKredit.EditValue = 0
        txtSaldoAwal.EditValue = 0
        txtSaldoAkhir.EditValue = 0
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        ErrorProvider1.Clear()

        If Valuta.EditValue = vbNullString Or Valuta.EditValue = vbNullString Then
            ErrorProvider1.SetError(Valuta, "Valuta Tidak Boleh Kosong")
            isvalid = False
        ElseIf tglDari.EditValue = vbNullString Then
            ErrorProvider1.SetError(tglDari, "Tanggal dari Tidak Boleh Kosong")
            isvalid = False
        ElseIf tglsampai.EditValue = vbNullString Then
            ErrorProvider1.SetError(tglsampai, "Tanggal Sampai Tidak Boleh Kosong")
            isvalid = False
        ElseIf tglsampai.EditValue < tglDari.EditValue Then
            ErrorProvider1.SetError(tglsampai, "tanggal sampai tidak boleh kurang dari tanggal dari")
            isvalid = False
        ElseIf tglDari.EditValue > tglsampai.EditValue Then
            ErrorProvider1.SetError(tglsampai, "tanggal dari tidak boleh lebih dari tanggal sampai")
            isvalid = False
        Else
            lblLoad1.Visible = True

            CekFinal()

            lblLoad1.Visible = False
        End If

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
        ShowGridPreview(GCMonHTGL)
    End Sub

    Public Sub cetak_click()
        ShowGridPreview(GCMonHTGL)
    End Sub

    Private Sub tglDari_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tglDari.EditValueChanged
        If Not tglDari.EditValue = vbNullString Then
            tglsampai.EditValue = DateAdd(DateInterval.Month, 1, tglDari.EditValue)
            tglsampai.EditValue = DateAdd(DateInterval.Day, -1, tglsampai.EditValue)
        End If
    End Sub
End Class