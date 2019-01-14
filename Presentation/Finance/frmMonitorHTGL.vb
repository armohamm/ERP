'|-----------------------
'|  CREATED BY RENDY    |
'|  EDITED BY RENDY     |
'|-----------------------
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Public Class frmMonitorHTGL
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
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

        'select 
        'A.kartu , A.bln_buku , A.thn_buku , A.kd_buku_besar , b.nm_buku_besar, A.kd_buku_pusat , c.nm_buku_pusat , A.status ,a.jml_val_debet  ,a.jml_val_kredit
        'from FIN.dbo.FIN_NERACA_SALDO A , SIF.dbo.SIF_buku_besar B, SIF.dbo.SIF_buku_pusat C
        'where a.kd_buku_besar = b.kd_buku_besar 
        'and a.kd_buku_pusat = C.kd_buku_pusat 

        daSal = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select A.kartu, A.bln_buku, A.thn_buku, A.kd_buku_besar, b.nm_buku_besar, A.kd_buku_pusat, c.nm_buku_pusat, A.status, a.jml_val_debet, a.jml_val_kredit from FIN.dbo.FIN_NERACA_SALDO A , SIF.dbo.SIF_buku_besar B, SIF.dbo.SIF_buku_pusat C where(a.kd_buku_besar = b.kd_buku_besar) and a.kd_buku_pusat = C.kd_buku_pusat ", sqlconn))
        daSal.Fill(dsSal, "_saldo")
        LookUpSaldo.Properties.DataSource = dsSal.Tables("_saldo")
        LookUpSaldo.Properties.ValueMember = "XXX"
        LookUpSaldo.Properties.DisplayMember = "XXX"
    End Sub

    Private Sub loadList()
        'dsJurnal.Tables("Valuta").Clear()
        'dsJurnal.Tables("BukuBesar").Clear()
        'dsJurnal.Tables("Kartu").Clear()
        'dsJurnal.Tables("BukuPusat").Clear()

        daValuta = New SqlDataAdapter(New SqlCommand("select Kode_Valuta, Nama_Valuta from SIF.dbo.SIF_Valuta", sqlconn))
        daValuta.Fill(dsValuta, "Valuta")
        Valuta.Properties.DataSource = dsValuta.Tables("Valuta")
        Valuta.Properties.DisplayMember = "Nama_Valuta"
        Valuta.Properties.ValueMember = "Kode_Valuta"

        daRek = New SqlDataAdapter(New SqlCommand("SELECT kd_buku_besar, nm_buku_besar FROM SIF.dbo.SIF_buku_besar WHERE grup_header='D'", sqlconn))
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
            "  from FIN.dbo.FIN_NERACA_SALDO  " & _
            "  where kd_buku_besar = '" & Rekening.EditValue & "' " & _
            "  and kd_valuta = '" & Valuta.EditValue & "' " & _
            "  and thn_buku = '" & tglDari.DateTime.Year & "' " & _
            "  and bln_buku <= '" & tglDari.DateTime.Month - 1 & "'", sqlconn).ExecuteReader

            dr2.Read()
            If dr2.HasRows Then
                txtSaldoAwal.Text = dr2.Item(0)
            End If
            Dim f As Long
            f = txtSaldoAwal.Text
            txtSaldoAwal.Text = Format(f, "##,##0")
        Catch ex As Exception
            txtSaldoAwal.Text = 0
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
            Dim dr As SqlDataReader = New SqlCommand(" Select SUM(b.saldo_val_debet - b.saldo_val_kredit) " & _
            "  from FIN.dbo.FIN_JURNAL A, FIN.dbo.FIN_JURNAL_D B  " & _
            "  where A.no_jur = B.no_jur " & _
            "  and A.tgl_posting  between convert(date,'" & tglDari.Text & "',103) and convert(date,'" & tglsampai.Text & "',103)  " & _
            "  and B.kd_buku_besar = '" & Rekening.EditValue & "'  " & _
            "  and A.kd_valuta = '" & Valuta.EditValue & "' " & _
            "  and A.no_posting is not null", sqlconn).ExecuteReader


            dr.Read()
            If dr.HasRows Then
                saldohari = dr.Item(0)
            End If

        Catch ex As Exception
            saldohari = 0
            'MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        bersih()
        LoadAllData()
        GVMonHTGL.BestFitColumns()

        hitungDebetKredit()
    End Sub

    Sub LoadAllData()
        'select ROW_NUMBER() OVER (ORDER BY a.no_jur) as 'nomer',
        'A.no_jur, tgl_trans,A.tgl_posting , A.no_ref1, A.no_ref3 , 
        'nama, B.keterangan, B.kd_buku_besar, C.nm_buku_besar, 
        'b.saldo_val_debet, b.saldo_val_kredit 
        'from FIN.dbo.FIN_JURNAL A, FIN.dbo.FIN_JURNAL_D B , SIF.dbo.SIF_buku_besar C 
        'where A.no_jur = B.no_jur
        'and B.kd_buku_besar = C.kd_buku_besar  
        'and A.no_posting is not null

        daGrid = New SqlDataAdapter(New SqlCommand("select ROW_NUMBER() OVER (ORDER BY a.no_jur) as 'nomer',  A.no_jur, tgl_trans,A.tgl_posting , A.no_ref1, A.no_ref3 , nama, B.keterangan, B.kd_buku_besar, C.nm_buku_besar, b.saldo_val_debet, b.saldo_val_kredit from FIN.dbo.FIN_JURNAL A, FIN.dbo.FIN_JURNAL_D B , SIF.dbo.SIF_buku_besar C where(A.no_jur = B.no_jur) and B.kd_buku_besar = C.kd_buku_besar  and A.no_posting is not null", sqlconn))
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
        daGrid = New SqlDataAdapter(New SqlCommand("select ROW_NUMBER() OVER (ORDER BY a.no_jur) as 'nomer', A.no_jur, tgl_trans,A.tgl_posting , A.no_ref1, A.no_ref3 , nama, B.keterangan, B.kd_buku_besar, C.nm_buku_besar, b.saldo_val_debet, b.saldo_val_kredit from FIN.dbo.FIN_JURNAL A, FIN.dbo.FIN_JURNAL_D B , SIF.dbo.SIF_buku_besar C where A.no_jur = B.no_jur  and B.kd_buku_besar = C.kd_buku_besar " & _
        "  and a.tgl_posting between convert(date, '" & tglDari.Text & "',103) and convert (date,'" & tglsampai.Text & "',103) and b.kd_buku_besar = '" & Rekening.EditValue & "' and A.kd_valuta = '" & Valuta.EditValue & "' and a.no_posting is not null", sqlconn))
        daGrid.Fill(dsGrid, "BukuBesar")
        GCMonHTGL.DataSource = dsGrid.Tables("BukuBesar")
        GVMonHTGL.BestFitColumns()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListHarian()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        CekFinal()
    End Sub

    Private Sub CekFinal()
        CekSaldoAwal()
        ListHarian()
        ceksaldohaarian()

        Try


            'OPSI JIKA MENGGUNAKAN QUERY SALDO HARIAN 
            'MsgBox(" Saldo Harian : " & saldohari)
            'saldoakhir1 = CDbl(txtSaldoAwal.Text) + saldohari
            saldoakhir1 = CDbl(txtSaldoAwal.Text) + saldohari

            'OPSI JIKA MENGGUNAKAN PENJUMLAHAN DENGAN GV.SUMMARYTEXT
            'MsgBox(" Saldo Harian : " & GVMonHTGL.Columns("saldo_val_debet").SummaryText - GVMonHTGL.Columns("saldo_val_kredit").SummaryText)
            'saldoakhir2 = CDbl(txtSaldoAwal.Text) + (GVMonHTGL.Columns("saldo_val_debet").SummaryText - GVMonHTGL.Columns("saldo_val_kredit").SummaryText)
            saldoakhir2 = txtSaldoAwal.Text + (GVMonHTGL.Columns("saldo_val_debet").SummaryText - GVMonHTGL.Columns("saldo_val_kredit").SummaryText)

            hitungDebetKredit()

            If saldohari <> (GVMonHTGL.Columns("saldo_val_debet").SummaryText - GVMonHTGL.Columns("saldo_val_kredit").SummaryText) Then
                lblError.Text = ("cek kembali proses perhitungan saldo step ceksaldohaarian() dan GV.SUMMARYTEXT")
            ElseIf saldoakhir1 <> saldoakhir2 Then
                lblError.Text = ("cek kembali proses perhitungan saldoakhir1 dan saldoakhir2 ")
            Else
                txtSaldoAkhir.Text = saldoakhir2
                Dim f As Long
                f = txtSaldoAkhir.Text
                txtSaldoAkhir.Text = Format(f, "##,##0")
            End If
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try
    End Sub

    Sub hitungDebetKredit()
        TxtDebetKredit.Text = GVMonHTGL.Columns("saldo_val_debet").SummaryText - GVMonHTGL.Columns("saldo_val_kredit").SummaryText
        Dim g As Long
        g = TxtDebetKredit.Text
        TxtDebetKredit.Text = Format(g, "##,##0")
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        bersih()
    End Sub

    Sub bersih()
        dsGrid.Clear()
        GCMonHTGL.DataSource = dsGrid.Tables("BukuBesar")
        GVMonHTGL.BestFitColumns()

        Rekening.EditValue = vbNullString
        Valuta.EditValue = vbNullString
        tglDari.EditValue = vbNullString
        tglsampai.EditValue = vbNullString
        TxtDebetKredit.Text = ""
        txtSaldoAwal.Text = ""
        txtSaldoAkhir.Text = ""
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        ErrorProvider1.Clear()

        If Rekening.Text = "" Or Rekening.Text = "Rekening" Then
            ErrorProvider1.SetError(Rekening, "Rekening Biaya Tidak Boleh Kosong")
            isvalid = False
        ElseIf Valuta.Text = "" Or Valuta.Text = "Valuta" Then
            ErrorProvider1.SetError(Valuta, "Valuta Tidak Boleh Kosong")
            isvalid = False
        ElseIf tglDari.Text = "" Then
            ErrorProvider1.SetError(tglDari, "Tanggal dari Tidak Boleh Kosong")
            isvalid = False
        ElseIf tglsampai.Text = "" Then
            ErrorProvider1.SetError(tglsampai, "Tanggal Sampai Tidak Boleh Kosong")
            isvalid = False
        ElseIf tglsampai.EditValue < tglDari.EditValue Then
            ErrorProvider1.SetError(tglsampai, "tanggal sampai tidak boleh kurang dari tanggal dari")
            isvalid = False
        ElseIf tglDari.EditValue > tglsampai.EditValue Then
            ErrorProvider1.SetError(tglsampai, "tanggal dari tidak boleh lebih dari tanggal sampai")
            isvalid = False
        Else
            CekFinal()
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
End Class