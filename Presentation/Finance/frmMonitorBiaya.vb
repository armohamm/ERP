'|-----------------------
'|  CREATED BY RENDY    |
'|  EDITED BY RENDY     |
'|-----------------------
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Public Class frmMonitorBiaya
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

    Dim dsPusBiaya, dsPost, dsRekBiaya, dsGrid As New DataSet
    Dim daDetil, daPost, daPusBiaya, daJurnalD, daRekBiaya, daGrid As SqlDataAdapter
    Dim rl, r2 As DataRelation

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
    Private Sub frmMonitorBiaya_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        loadList()
        Me.Enabled = True
        GVMonBiaya.BestFitColumns()

        tglDari.EditValue = getTanggal()
        tglsampai.EditValue = getTanggal()

        ToolTip1.SetToolTip(RekBiaya, "Rekening Biaya wajib diisi")
        ToolTip1.SetToolTip(PusBiaya, "Pusat Biaya wajib diisi")
        ToolTip1.SetToolTip(tglDari, "Tanggal Sampai opsional")
        ToolTip1.SetToolTip(tglsampai, "Tanggal Dari opsional")
    End Sub

    Private Sub loadList()
        'dsJurnal.Tables("Valuta").Clear()
        'dsJurnal.Tables("BukuBesar").Clear()
        'dsJurnal.Tables("Kartu").Clear()
        'dsJurnal.Tables("BukuPusat").Clear()

        daPusBiaya = New SqlDataAdapter(New SqlCommand("select Kd_buku_pusat, nm_buku_pusat from SIF.dbo.SIF_buku_pusat WHERE grup_header='D'", sqlconn))
        daPusBiaya.Fill(dsPusBiaya, "PusBiaya")
        PusBiaya.Properties.DataSource = dsPusBiaya.Tables("PusBiaya")
        PusBiaya.Properties.DisplayMember = "nm_buku_pusat"
        PusBiaya.Properties.ValueMember = "Kd_buku_pusat"

        daRekBiaya = New SqlDataAdapter(New SqlCommand("SELECT kd_buku_besar, nm_buku_besar FROM SIF.dbo.SIF_buku_besar WHERE grup_header='D' and kd_buku_besar like '5%'", sqlconn))
        daRekBiaya.Fill(dsRekBiaya, "RekBiaya")
        RekBiaya.Properties.DataSource = dsRekBiaya.Tables("RekBiaya")
        RekBiaya.Properties.DisplayMember = "nm_buku_besar"
        RekBiaya.Properties.ValueMember = "kd_buku_besar"

        'daGrid = New SqlDataAdapter(New SqlCommand("select ROW_NUMBER() OVER (ORDER BY a.no_jur) as 'nomer', A.no_jur, tgl_trans,B.tgl_posting, B.no_ref1, B.no_ref3,nama, B.keterangan,kd_buku_besar,kd_buku_pusat,saldo_val_debet,saldo_val_kredit from fin.dbo.FIN_JURNAL_D A , fin.dbo.FIN_JURNAL B", sqlconn))
        'daGrid = New SqlDataAdapter(New SqlCommand("select A.no_jur, tgl_trans,B.tgl_posting, B.no_ref1, B.no_ref3,nama, B.keterangan,kd_buku_besar,saldo_val_debet,saldo_val_kredit from fin.dbo.FIN_JURNAL_D A , fin.dbo.FIN_JURNAL B", sqlconn))
        'daGrid.Fill(dsGrid, "BukuBesar")
        'GCMonBiaya.DataSource = dsGrid.Tables("BukuBesar")
        'GVMonBiaya.BestFitColumns()


    End Sub


    Sub ListHarianBiaya()
        Try
            dsGrid.Clear()

            If RekBiaya.Text <> "Rekening" Then
                dsGrid.Clear()
                daGrid = New SqlDataAdapter(New SqlCommand("select ROW_NUMBER() OVER (ORDER BY a.no_jur) as 'nomer', A.no_jur, tgl_trans,A.tgl_posting , A.no_ref1, A.no_ref3 ,nama, B.keterangan, B.kd_buku_besar,C.nm_buku_besar  , B.kd_buku_pusat, D.nm_buku_pusat , saldo_val_debet, saldo_val_kredit from  FIN.dbo.FIN_JURNAL A, FIN.dbo.FIN_JURNAL_D B , SIF.dbo.SIF_buku_besar C , SIF.dbo.SIF_buku_pusat D where A.no_jur = B.no_jur and B.kd_buku_besar = C.kd_buku_besar and B.kd_buku_pusat = D.kd_buku_pusat and B.kd_buku_besar = '" & RekBiaya.EditValue & "' and A.no_posting is not null", sqlconn))
                daGrid.Fill(dsGrid, "Biaya")
                GCMonBiaya.DataSource = dsGrid.Tables("Biaya")
                GVMonBiaya.BestFitColumns()

            ElseIf PusBiaya.Text <> "Biaya" Then
                dsGrid.Clear()
                daGrid = New SqlDataAdapter(New SqlCommand("select ROW_NUMBER() OVER (ORDER BY a.no_jur) as 'nomer', A.no_jur, tgl_trans,A.tgl_posting , A.no_ref1, A.no_ref3 ,nama, B.keterangan, B.kd_buku_besar,C.nm_buku_besar  , B.kd_buku_pusat, D.nm_buku_pusat , saldo_val_debet, saldo_val_kredit from  FIN.dbo.FIN_JURNAL A, FIN.dbo.FIN_JURNAL_D B , SIF.dbo.SIF_buku_besar C , SIF.dbo.SIF_buku_pusat D where A.no_jur = B.no_jur and B.kd_buku_besar = C.kd_buku_besar and B.kd_buku_pusat = D.kd_buku_pusat and B.kd_buku_pusat = '" & PusBiaya.EditValue & "' and A.no_posting is not null", sqlconn))
                daGrid.Fill(dsGrid, "Biaya")
                GCMonBiaya.DataSource = dsGrid.Tables("Biaya")
                GVMonBiaya.BestFitColumns()

            End If

            If tglDari.Text <> "" And tglsampai.Text <> "" Then
                dsGrid.Clear()
                daGrid = New SqlDataAdapter(New SqlCommand("select ROW_NUMBER() OVER (ORDER BY a.no_jur) as 'nomer', A.no_jur, tgl_trans,A.tgl_posting , A.no_ref1,  A.no_ref3 ,nama, B.keterangan, B.kd_buku_besar,C.nm_buku_besar  , B.kd_buku_pusat, D.nm_buku_pusat , saldo_val_debet, saldo_val_kredit from  FIN.dbo.FIN_JURNAL A, FIN.dbo.FIN_JURNAL_D B , SIF.dbo.SIF_buku_besar C , SIF.dbo.SIF_buku_pusat D where A.no_jur = B.no_jur and A.tgl_posting between convert(date,'" & tglDari.Text & "',103) and convert(date,'" & tglsampai.Text & "',103) and B.kd_buku_besar = C.kd_buku_besar and B.kd_buku_pusat = D.kd_buku_pusat  and B.kd_buku_besar = '" & RekBiaya.EditValue & "'  and B.kd_buku_pusat = '" & PusBiaya.EditValue & "' and A.no_posting is not null", sqlconn))

                daGrid.Fill(dsGrid, "Biaya")
                GCMonBiaya.DataSource = dsGrid.Tables("Biaya")
                GVMonBiaya.BestFitColumns()

            ElseIf PusBiaya.Text <> "Biaya" And RekBiaya.Text <> "Rekening" Then
                dsGrid.Clear()
                daGrid = New SqlDataAdapter(New SqlCommand("select ROW_NUMBER() OVER (ORDER BY a.no_jur) as 'nomer', A.no_jur, tgl_trans,A.tgl_posting , A.no_ref1, A.no_ref3 ,nama, B.keterangan, B.kd_buku_besar,C.nm_buku_besar  , B.kd_buku_pusat, D.nm_buku_pusat , saldo_val_debet, saldo_val_kredit from  FIN.dbo.FIN_JURNAL A, FIN.dbo.FIN_JURNAL_D B , SIF.dbo.SIF_buku_besar C , SIF.dbo.SIF_buku_pusat D where A.no_jur = B.no_jur  and B.kd_buku_besar = C.kd_buku_besar  and B.kd_buku_pusat = D.kd_buku_pusat and B.kd_buku_besar = '" & RekBiaya.EditValue & "' and B.kd_buku_pusat = '" & PusBiaya.EditValue & "' and A.no_posting is not null", sqlconn))
                daGrid.Fill(dsGrid, "Biaya")
                GCMonBiaya.DataSource = dsGrid.Tables("Biaya")
                GVMonBiaya.BestFitColumns()
            End If

            If tglDari.Text <> "" And tglsampai.Text <> "" And RekBiaya.Text <> "Rekening" Then
                dsGrid.Clear()
                daGrid = New SqlDataAdapter(New SqlCommand("select ROW_NUMBER() OVER (ORDER BY a.no_jur) as 'nomer', A.no_jur, tgl_trans,A.tgl_posting , A.no_ref1,  A.no_ref3 ,nama, B.keterangan,  B.kd_buku_besar,C.nm_buku_besar  , B.kd_buku_pusat, D.nm_buku_pusat, saldo_val_debet, saldo_val_kredit from  FIN.dbo.FIN_JURNAL A, FIN.dbo.FIN_JURNAL_D B , SIF.dbo.SIF_buku_besar C , SIF.dbo.SIF_buku_pusat D where(A.no_jur = B.no_jur) and A.tgl_posting between convert(date,'" & tglDari.Text & "',103) and convert(date,'" & tglsampai.Text & "',103) and B.kd_buku_besar = C.kd_buku_besar and B.kd_buku_pusat = D.kd_buku_pusat and B.kd_buku_besar = '" & RekBiaya.EditValue & "'  and A.no_posting is not null", sqlconn))
                daGrid.Fill(dsGrid, "Biaya")
                GCMonBiaya.DataSource = dsGrid.Tables("Biaya")
                GVMonBiaya.BestFitColumns()
            ElseIf tglDari.Text <> "" And tglsampai.Text <> "" And PusBiaya.Text <> "Biaya" Then
                dsGrid.Clear()
                daGrid = New SqlDataAdapter(New SqlCommand("select ROW_NUMBER() OVER (ORDER BY a.no_jur) as 'nomer', A.no_jur, tgl_trans,A.tgl_posting , A.no_ref1,  A.no_ref3 ,nama, B.keterangan, B.kd_buku_besar,C.nm_buku_besar  , B.kd_buku_pusat, D.nm_buku_pusat, saldo_val_debet, saldo_val_kredit from  FIN.dbo.FIN_JURNAL A, FIN.dbo.FIN_JURNAL_D B , SIF.dbo.SIF_buku_besar C , SIF.dbo.SIF_buku_pusat D where(A.no_jur = B.no_jur) and A.tgl_posting between convert(date,'" & tglDari.Text & "',103) and convert(date,'" & tglsampai.Text & "',103) and B.kd_buku_besar = C.kd_buku_besar and B.kd_buku_pusat = D.kd_buku_pusat and B.kd_buku_pusat = '" & PusBiaya.EditValue & "' and A.no_posting is not null", sqlconn))
                daGrid.Fill(dsGrid, "Biaya")
                GCMonBiaya.DataSource = dsGrid.Tables("Biaya")
                GVMonBiaya.BestFitColumns()
            End If

            hitungDebetKredit()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'select ROW_NUMBER() OVER (ORDER BY a.no_jur) as 'nomer',
        'A.no_jur, tgl_trans,A.tgl_posting , A.no_ref1, 
        'A.no_ref3 ,nama, B.keterangan,
        'B.kd_buku_besar,C.nm_buku_besar  ,
        'B.kd_buku_pusat, D.nm_buku_pusat ,
        'saldo_val_debet,saldo_val_kredit 
        'from  FIN.dbo.FIN_JURNAL A, FIN.dbo.FIN_JURNAL_D B , SIF.dbo.SIF_buku_besar C , SIF.dbo.SIF_buku_pusat D
        ' where A.no_jur = B.no_jur 
        ' and B.kd_buku_besar = C.kd_buku_besar 
        ' and B.kd_buku_pusat = D.kd_buku_pusat 
        ' and B.kd_buku_besar = '5-121000' 
        ' and A.no_posting is not null

        'select ROW_NUMBER() OVER (ORDER BY a.no_jur) as 'nomer',
        'A.no_jur, tgl_trans,A.tgl_posting , A.no_ref1, 
        'A.no_ref3 ,nama, B.keterangan,
        'B.kd_buku_besar,C.nm_buku_besar  ,
        'B.kd_buku_pusat, D.nm_buku_pusat ,
        'saldo_val_debet,saldo_val_kredit 
        'from  FIN.dbo.FIN_JURNAL A, FIN.dbo.FIN_JURNAL_D B , SIF.dbo.SIF_buku_besar C , SIF.dbo.SIF_buku_pusat D
        ' where A.no_jur = B.no_jur 
        ' and A.tgl_posting between '9/5/2011' and '10/30/2011'
        ' and B.kd_buku_besar = C.kd_buku_besar 
        ' and B.kd_buku_pusat = D.kd_buku_pusat 
        ' and B.kd_buku_besar = '5-121000' 
        ' and B.kd_buku_pusat = '9-000001' 
        ' and A.no_posting is not null

        'select ROW_NUMBER() OVER (ORDER BY a.no_jur) as 'nomer',
        ' A.no_jur, tgl_trans,A.tgl_posting , A.no_ref1, 
        ' A.no_ref3 ,nama, B.keterangan,
        ' B.kd_buku_besar,C.nm_buku_besar  ,
        ' B.kd_buku_pusat, D.nm_buku_pusat ,
        ' saldo_val_debet,saldo_val_kredit 
        ' from  FIN.dbo.FIN_JURNAL A, FIN.dbo.FIN_JURNAL_D B , SIF.dbo.SIF_buku_besar C , SIF.dbo.SIF_buku_pusat D
        '  where A.no_jur = B.no_jur 
        '  and B.kd_buku_besar = C.kd_buku_besar 
        '  and B.kd_buku_pusat = D.kd_buku_pusat 
        '  and B.kd_buku_besar = '5-121000' 
        '  and B.kd_buku_pusat = '9-000001' 
        '  and A.no_posting is not null

        'select ROW_NUMBER() OVER (ORDER BY a.no_jur) as 'nomer',
        'A.no_jur, tgl_trans,A.tgl_posting ,
        'A.no_ref1,  A.no_ref3 ,nama, B.keterangan, 
        'B.kd_buku_besar,C.nm_buku_besar  , B.kd_buku_pusat,
        'D.nm_buku_pusat , saldo_val_debet, saldo_val_kredit 
        'from  FIN.dbo.FIN_JURNAL A, FIN.dbo.FIN_JURNAL_D B , SIF.dbo.SIF_buku_besar C , SIF.dbo.SIF_buku_pusat D 
        'where A.no_jur = B.no_jur 
        'and A.tgl_posting between '" & tglDari.EditValue & "' and '" & tglsampai.EditValue & "'
        'and B.kd_buku_besar = C.kd_buku_besar 
        'and B.kd_buku_pusat = D.kd_buku_pusat 
        'and B.kd_buku_besar = '" & RekBiaya.EditValue & "'  
        'and A.no_posting is not null

    End Sub

    Sub hitungDebetKredit()
        TxtDebetKredit.Text = GVMonBiaya.Columns("saldo_val_debet").SummaryText - GVMonBiaya.Columns("saldo_val_kredit").SummaryText
        Dim g As Long
        g = TxtDebetKredit.Text
        TxtDebetKredit.Text = Format(g, "##,##0")
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAct.Click
        ErrorProvider1.Clear()

        If RekBiaya.Text = "Rekening" And PusBiaya.Text = "Biaya" Then
            ErrorProvider1.SetError(RekBiaya, "Rekening Biaya Tidak Boleh Kosong , pilih salah satu")
            ErrorProvider1.SetError(PusBiaya, "Rekening Biaya Tidak Boleh Kosong , pilih salah satu")
            isvalid = False
        ElseIf tglDari.EditValue > tglsampai.EditValue Then

        Else
            ListHarianBiaya()
        End If

    End Sub

    Sub bersih()
        dsGrid.Clear()
        GCMonBiaya.DataSource = dsGrid.Tables("Biaya")
        GVMonBiaya.BestFitColumns()
        RekBiaya.EditValue = vbNullString
        PusBiaya.EditValue = vbNullString
        tglDari.EditValue = vbNullString
        tglsampai.EditValue = vbNullString
        TxtDebetKredit.Text = ""
    End Sub

    Sub LoadAllData()
        '   select ROW_NUMBER() OVER (ORDER BY a.no_jur) as 'nomer',
        '   A.no_jur, tgl_trans,B.tgl_posting,
        '   B.no_ref1, B.no_ref3,nama, B.keterangan, 
        '   A.kd_buku_besar, C.nm_buku_besar, A.kd_buku_pusat,
        '   D.nm_buku_pusat, saldo_val_debet, saldo_val_kredit
        '   from fin.dbo.FIN_JURNAL_D A , fin.dbo.FIN_JURNAL B , SIF.dbo.SIF_buku_besar C, SIF.dbo.SIF_buku_pusat D 
        '   where A.no_jur = B.no_jur 
        '   and A.kd_buku_besar = C.kd_buku_besar
        '   and A.kd_buku_pusat = D.kd_buku_pusat
        '   and B.no_posting is not null

        daGrid = New SqlDataAdapter(New SqlCommand("select ROW_NUMBER() OVER (ORDER BY a.no_jur) as 'nomer', A.no_jur, tgl_trans,B.tgl_posting, B.no_ref1, B.no_ref3,nama, B.keterangan,  A.kd_buku_besar, C.nm_buku_besar, A.kd_buku_pusat, D.nm_buku_pusat, saldo_val_debet, saldo_val_kredit from fin.dbo.FIN_JURNAL_D A , fin.dbo.FIN_JURNAL B , SIF.dbo.SIF_buku_besar C, SIF.dbo.SIF_buku_pusat D  where(A.no_jur = B.no_jur) and A.kd_buku_besar = C.kd_buku_besar and A.kd_buku_pusat = D.kd_buku_pusat and B.no_posting is not null", sqlconn))
        'daGrid = New SqlDataAdapter(New SqlCommand("select A.no_jur, tgl_trans,B.tgl_posting, B.no_ref1, B.no_ref3,nama, B.keterangan,kd_buku_besar,saldo_val_debet,saldo_val_kredit from fin.dbo.FIN_JURNAL_D A , fin.dbo.FIN_JURNAL B", sqlconn))
        daGrid.Fill(dsGrid, "Biaya")
        GCMonBiaya.DataSource = dsGrid.Tables("Biaya")
        GVMonBiaya.BestFitColumns()
    End Sub

    Private Sub cmdClear_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        bersih()
    End Sub

    Private Sub cmdRefresh_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        bersih()
        LoadAllData()
        hitungDebetKredit()
        GVMonBiaya.BestFitColumns()
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

    Public Sub cetak_click()
        ShowGridPreview(GCMonBiaya)
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        'ShowGridPreview(GVMonBiaya.GridControl)
        ShowGridPreview(GCMonBiaya)
    End Sub

End Class