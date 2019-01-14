'|-----------------------
'|  CREATED BY RENDY    |
'|  EDITED BY RENDY     |
'|-----------------------
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Public Class frmMonRealBiayaDanPendapatan
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim err As String = ""
    Dim isvalid As Boolean
    Dim rl, r2 As DataRelation
    Dim dsGrid1, dsGrid2, dsLookUp As New DataSet
    Dim daGrid1, daGrid2, daLookUp As SqlDataAdapter
    Dim dr, dr2 As SqlDataReader

    Dim DebetKreditBiaya As String
    Dim DebetKreditpendapatan As String
    Dim tahunX As String = Microsoft.VisualBasic.Left(lookupBulanAwal.EditValue, 4)
    Dim bulanX As String = Microsoft.VisualBasic.Right(lookupBulanAwal.EditValue, 2)

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

    Private Sub loadLookUp()
        If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        daLookUp.Fill(dsLookUp, "LookPeriode")
        lookupBulanAwal.Properties.DataSource = dsLookUp.Tables("LookPeriode")
        lookupBulanAwal.Properties.DisplayMember = "nama"
        lookupBulanAwal.Properties.ValueMember = "thnbln"
    End Sub

    Private Sub frmMonRealBiayaDanPendapatan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        loadLookUp()
        LoadAllData()

        HitungDebetKredit()

        GV1.Columns("jml_val_kredit").Visible = False
        GV1.Columns("jml_val_debet").Visible = False
        GV2.Columns("jml_val_kredit").Visible = False
        GV2.Columns("jml_val_debet").Visible = False
    End Sub

    Sub LoadAllData()

        'select  ROW_NUMBER() OVER (ORDER BY A.kd_buku_besar) as 'nomor',
        'A.kd_buku_besar , A.kd_buku_pusat  , B.nm_buku_besar , D.nm_buku_pusat , C.jml_trans , A.jml_val_kredit , A.jml_val_debet 
        'from FIN .dbo.FIN_NERACA_SALDO A, SIF.dbo.SIF_buku_besar B , SIF.dbo.SIF_anggaran C , SIF.dbo.SIF_buku_pusat D
        'where A.thn_buku = C.thn_buku
        'and A.bln_buku = C.bln_buku 
        'and A.kd_buku_besar = B.kd_buku_besar
        'and A.kd_buku_pusat = D.kd_buku_pusat
        'and (A.kd_buku_besar like '4%' or A.kd_buku_besar like '6%' or A.kd_buku_besar like '8%')

        dsGrid1.Clear()
        dsGrid2.Clear()

        daGrid1 = New SqlDataAdapter(New SqlCommand("select  ROW_NUMBER() OVER (ORDER BY A.kd_buku_besar) as 'nomor', " & _
        "   A.kd_buku_besar, B.nm_buku_besar, C.jml_trans, A.jml_val_kredit, A.jml_val_debet " & _
        "   from FIN .dbo.FIN_NERACA_SALDO A, SIF.dbo.SIF_buku_besar B , SIF.dbo.SIF_anggaran C " & _
        "   where   A.thn_buku = C.thn_buku  " & _
        "   and A.bln_buku = C.bln_buku  " & _
        "   and A.kd_buku_besar = B.kd_buku_besar  " & _
        "   and (A.kd_buku_besar like '41%' or A.kd_buku_besar like '7%' )", sqlconn))

        daGrid2 = New SqlDataAdapter(New SqlCommand("select  ROW_NUMBER() OVER (ORDER BY A.kd_buku_besar) as 'nomor', " & _
        "   A.kd_buku_besar, A.kd_buku_pusat, B.nm_buku_besar, D.nm_buku_pusat, C.jml_trans, A.jml_val_kredit, A.jml_val_debet " & _
        "   from FIN .dbo.FIN_NERACA_SALDO A, SIF.dbo.SIF_buku_besar B , SIF.dbo.SIF_anggaran C , SIF.dbo.SIF_buku_pusat D " & _
        "   where(A.thn_buku = C.thn_buku) " & _
        "   and A.bln_buku = C.bln_buku  " & _
        "   and A.kd_buku_besar = B.kd_buku_besar " & _
        "   and A.kd_buku_pusat = D.kd_buku_pusat " & _
        "   and (A.kd_buku_besar like '5%' or A.kd_buku_besar like '6%' or A.kd_buku_besar like '8%') ", sqlconn))


        daGrid1.Fill(dsGrid1, "Pendapatan")
        GC1.DataSource = dsGrid1.Tables("Pendapatan")

        daGrid2.Fill(dsGrid2, "Biaya")
        GC2.DataSource = dsGrid2.Tables("Biaya")

        GV1.BestFitColumns()
        GV2.BestFitColumns()



    End Sub
    Sub HitungDebetKredit()

        dr = New SqlCommand(" select  SUM(A.jml_val_kredit - A.jml_val_debet)  " & _
       "   from FIN .dbo.FIN_NERACA_SALDO A, SIF.dbo.SIF_buku_besar B , SIF.dbo.SIF_anggaran C  " & _
        "   where(A.thn_buku = C.thn_buku) " & _
       "   and A.bln_buku = C.bln_buku  " & _
       "   and A.kd_buku_besar = B.kd_buku_besar  " & _
       "   and (A.kd_buku_besar like '41%' or A.kd_buku_besar like '7%' )", sqlconn).ExecuteReader

        dr.Read()

        Try
            If dr.HasRows Then
                TxtDebetKreditPendapatan.Text = dr.Item(0)
            End If
        Catch ex As Exception
            TxtDebetKreditPendapatan.Text = "0"
        End Try

        Dim f As Long
        f = TxtDebetKreditPendapatan.Text
        TxtDebetKreditPendapatan.Text = Format(f, "##,##0")

        dr.Close()


        dr2 = New SqlCommand("  select  SUM(A.jml_val_kredit - A.jml_val_debet)   " & _
        "   from FIN .dbo.FIN_NERACA_SALDO A, SIF.dbo.SIF_buku_besar B , SIF.dbo.SIF_anggaran C , SIF.dbo.SIF_buku_pusat D   " & _
        "   where(A.thn_buku = C.thn_buku)  " & _
        "   and A.bln_buku = C.bln_buku    " & _
        "   and A.kd_buku_besar = B.kd_buku_besar   " & _
        "   and A.kd_buku_pusat = D.kd_buku_pusat   " & _
        "   and (A.kd_buku_besar like '5%' or A.kd_buku_besar like '6%' or A.kd_buku_besar like '8%') ", sqlconn).ExecuteReader

        dr2.Read()

        Try
            If dr2.HasRows Then
                TxtDebetKreditBiaya.Text = dr2.Item(0)
            End If
        Catch ex As Exception
            TxtDebetKreditBiaya.Text = "0"
        End Try

        Dim g As Long
        g = TxtDebetKreditBiaya.Text
        TxtDebetKreditBiaya.Text = Format(g, "##,##0")

        dr2.Close()

    End Sub
    Private Sub cmdExe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExe.Click

        dsGrid1.Clear()
        dsGrid2.Clear()

        daGrid1 = New SqlDataAdapter(New SqlCommand("select  ROW_NUMBER() OVER (ORDER BY A.kd_buku_besar) as 'nomor', " & _
            "   A.kd_buku_besar, B.nm_buku_besar, C.jml_trans, A.jml_val_kredit, A.jml_val_debet " & _
            "   from FIN .dbo.FIN_NERACA_SALDO A, SIF.dbo.SIF_buku_besar B , SIF.dbo.SIF_anggaran C " & _
            "   where   A.thn_buku = C.thn_buku  " & _
            "   and A.bln_buku = C.bln_buku  " & _
            "   and A.kd_buku_besar = B.kd_buku_besar  " & _
            "   and (A.kd_buku_besar like '41%' or A.kd_buku_besar like '7%' )  " & _
            "   and A.bln_buku = '" & bulanX & "'  " & _
            "   and A.thn_buku = '" & tahunX & "' ", sqlconn))

        daGrid2 = New SqlDataAdapter(New SqlCommand("select  ROW_NUMBER() OVER (ORDER BY A.kd_buku_besar) as 'nomor', " & _
            "   A.kd_buku_besar, A.kd_buku_pusat, B.nm_buku_besar, D.nm_buku_pusat, C.jml_trans, A.jml_val_kredit, A.jml_val_debet " & _
            "   from FIN .dbo.FIN_NERACA_SALDO A, SIF.dbo.SIF_buku_besar B , SIF.dbo.SIF_anggaran C , SIF.dbo.SIF_buku_pusat D " & _
            "   where(A.thn_buku = C.thn_buku) " & _
            "   and A.bln_buku = C.bln_buku  " & _
            "   and A.kd_buku_besar = B.kd_buku_besar " & _
            "   and A.kd_buku_pusat = D.kd_buku_pusat " & _
            "   and (A.kd_buku_besar like '5%' or A.kd_buku_besar like '6%' or A.kd_buku_besar like '8%')  " & _
            "   and A.bln_buku = '" & bulanX & "'  " & _
            "   and A.thn_buku = '" & tahunX & "' ", sqlconn))

        daGrid1.Fill(dsGrid1, "Pendapatan")
        GC1.DataSource = dsGrid1.Tables("Pendapatan")

        daGrid2.Fill(dsGrid2, "Biaya")
        GC2.DataSource = dsGrid2.Tables("Biaya")

        HitungDebetKredit()

        GV1.BestFitColumns()
        GV2.BestFitColumns()

    End Sub

    Private Sub tglFilter_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tglFilter.EditValueChanged
        txtBln.Text = tglFilter.DateTime.Month
        txtTahun.Text = tglFilter.DateTime.Year
    End Sub

    Sub bersih()
        dsGrid1.Clear()
        dsGrid2.Clear()
        tglFilter.EditValue = vbNullString
        txtBln.Text = ""
        txtTahun.Text = ""
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        bersih()
        LoadAllData()
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        bersih()
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

    Private Sub cmdGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintPendapatan.Click
        'ShowGridPreview(GV1.GridControl)
        'ShowGridPreview(GV2.GridControl)

        If CEPPPendapatan.Checked = True Then
            ShowGridPreview(GC1)
        ElseIf CEPPBiaya.Checked = True Then
            ShowGridPreview(GC2)
        End If

    End Sub

    Private Sub CEPPPendapatan_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEPPPendapatan.CheckedChanged
        If CEPPPendapatan.Checked = True Then
            CEPPBiaya.Checked = False
        Else
            CEPPBiaya.Checked = True
        End If
    End Sub

    Private Sub CEPPBiaya_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEPPBiaya.CheckedChanged
        If CEPPBiaya.Checked = True Then
            CEPPPendapatan.Checked = False
        Else
            CEPPPendapatan.Checked = True
        End If
    End Sub

    Private Sub lookupBulanAwal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookupBulanAwal.EditValueChanged
        txtTahun.EditValue = Microsoft.VisualBasic.Left(lookupBulanAwal.EditValue, 4)
        txtBln.EditValue = Microsoft.VisualBasic.Right(lookupBulanAwal.EditValue, 2)
    End Sub
End Class