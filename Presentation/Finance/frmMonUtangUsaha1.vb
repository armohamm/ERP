'|-----------------------
'|  CREATED BY RENDY    |
'|  EDITED BY RENDY     |
'|-----------------------
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Public Class frmMonUtangUsaha1
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = True
    Public prn As frmMain
    Dim err As String = ""
    Dim isvalid As Boolean

    Dim dsRekap, dsDetUt, dsLunas, dsLOV As New DataSet
    Dim daRekap, daDetUt, daLunas, daValuta, daSupp, daSub As SqlDataAdapter

    Dim rl As DataRelation

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

    Private Sub loadAll()
        Dim kSp As String
        Dim kNoInv As String
        LoadGrid1()
        If Not GVlvl1.RowCount = 0 Then
            Dim viewLvl1 As ColumnView = GVlvl1
            kSp = viewLvl1.GetFocusedRowCellValue("kd_supplier").ToString
            LoadHutang(kSp)
            If Not GVlvl2.RowCount = 0 Then
                Dim viewLvl2 As ColumnView = GVlvl2
                kNoInv = viewLvl2.GetFocusedRowCellValue("no_inv").ToString

                loadPiutang(kNoInv)
                loadLunas(kNoInv)
            Else
                If Not dsLunas.Tables("_Lunas") Is Nothing Then dsLunas.Tables("_Lunas").Clear()
                If Not dsLunas.Tables("v_Lunas") Is Nothing Then dsLunas.Tables("v_Lunas").Clear()
            End If
        Else
            dsDetUt.Clear()
            If Not dsLunas.Tables("_Lunas") Is Nothing Then dsLunas.Tables("_Lunas").Clear()
            If Not dsLunas.Tables("v_Lunas") Is Nothing Then dsLunas.Tables("v_Lunas").Clear()
        End If
    End Sub

    Private Sub frmMonUtangUsaha1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.GotFocus
        btnCetak = True
        setStatus()
    End Sub


    Private Sub frmMonUtangUsaha1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        CElunas.Checked = True
        btnCetak = True
        setStatus()
        'LoadGrid1()
        'LoadGrid2()
        'LoadGrid3()

        loadLookUP()
        'ColVisible()
        Me.Enabled = True
        GVlvl1.BestFitColumns()
        GVlvl2.BestFitColumns()
        GVlvl3.BestFitColumns()
        GVlunas.BestFitColumns()

        tglDari.EditValue = getTanggal()
        Supplier.ItemIndex = 0
        Valuta.ItemIndex = 3
        loadAll()
        'Try
        '    Dim kSp As String
        '    Dim viewLvl1 As ColumnView = GVlvl1
        '    kSp = viewLvl1.GetFocusedRowCellValue("kd_supplier").ToString

        '    LoadHutang(kSp)

        '    Dim kNoInv As String
        '    Dim viewLvl2 As ColumnView = GVlvl2
        '    kNoInv = viewLvl2.GetFocusedRowCellValue("no_inv").ToString

        '    loadPiutang(kNoInv)
        '    loadLunas(kNoInv)
        'Catch ex As Exception
        '    lblError.Text = ex.Message
        'End Try
    End Sub

    Sub LoadGrid1()
       
        dsRekap.Clear()
        daRekap = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select ROW_NUMBER() OVER (ORDER BY kd_supplier) as 'nomer', " & _
        "   a.kd_supplier,c.Nama_Supplier,sum(a.jml_akhir) as 'total'  " & _
        "   from FIN.dbo.FIN_PEMBELIAN A, SIF.dbo.SIF_Supplier C  " & _
        "   where  a.kd_supplier = c.Kode_Supplier   " & _
        "   and a.tipe_trans like 'JPP%'  " & _
        "   and not (a.no_posting is null or a.no_posting = '')  " & _
        "   group by a.kd_supplier  , c.Nama_Supplier", sqlconn))


        daRekap.Fill(dsRekap, "_rekap")
        GClvl1.DataSource = dsRekap.Tables("_rekap")
        GVlvl1.BestFitColumns()
    End Sub

    Sub LoadGrid2()

        dsDetUt.Clear()
        daDetUt = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("   select  ROW_NUMBER() OVER (ORDER BY kd_supplier) as 'nomer',  " & _
        "   a.tipe_trans,  a.kd_supplier,a.no_inv,a.no_ref1,a.tgl_inv ,a.tgl_jth_tempo ,  " & _
        "   a.no_jurnal,c.Nama_Supplier,a.nm_supplier ,a.kd_buku_besar,  " & _
        "   d.nm_buku_besar,a.keterangan ,  a.no_posting, a.tgl_posting,  " & _
        "   a.jml_val_ppn, a.jml_rp_ppn, a.jml_diskon, a.jml_tagihan,  " & _
        "   a.jml_bayar, a.jml_akhir  ,E.nomor as 'nomor_giro' " & _
        "   from SIF.dbo.SIF_Supplier C , SIF.dbo.SIF_buku_besar D,  FIN.dbo.FIN_PEMBELIAN A left outer join FIN.dbo.FIN_GIRO_D E on (A.no_inv = E.no_inv) " & _
        "   where  a.kd_supplier = c.Kode_Supplier    " & _
        "   and a.kd_buku_besar = d.kd_buku_besar   " & _
        "   and a.tipe_trans like 'JPP%'    " & _
        "   and not(a.no_posting is null)  ", sqlconn))
        daDetUt.Fill(dsDetUt, "_DetUt")
        GClvl2.DataSource = dsDetUt.Tables("_DetUt")
        GVlvl2.BestFitColumns()
    End Sub

    Sub LoadGrid3()

        dsLunas.Clear()
        daLunas = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  ROW_NUMBER() OVER (ORDER BY a.no_trans) as 'nomer',  " & _
        "   a.no_trans ,a.tipe_trans, a.tgl_trans , a.no_ref1 ,  " & _
        "   a.kd_kartu ,  a.kd_giro , a.keterangan , b.prev_no_inv ,  " & _
        "   a.kd_valuta, b.jml_tagihan , b.jml_piut , b.jml_pph ,  " & _
        "   b.jml_ppn, b.jml_diskon, b.pendp_lain, b.biaya_lain, b.jml_bayar  " & _
        "   from FIN.dbo.FIN_BELI_LUNAS A , FIN.dbo.FIN_BELI_LUNAS_D B   " & _
        "   where a.no_trans = b.no_trans", sqlconn))
        daLunas.Fill(dsLunas, "_Lunas")
        GClvl3.DataSource = dsLunas.Tables("_Lunas")
        GVlvl3.BestFitColumns()
    End Sub

    Sub LoadGrid4()

        dsLunas.Clear()
        daLunas = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.v_lunas_hutang_detail", sqlconn))
        daLunas.Fill(dsLunas, "v_Lunas")
        GClunas.DataSource = dsLunas.Tables("v_Lunas")
        GVlunas.BestFitColumns()
    End Sub

    Sub loadLookUP()

        dsLOV.Clear()

        daValuta = New SqlDataAdapter(New SqlCommand("select Kode_Valuta, Nama_Valuta from SIF.dbo.SIF_Valuta", sqlconn))
        daValuta.Fill(dsLOV, "Valuta")
        Valuta.Properties.DataSource = dsLOV.Tables("Valuta")
        Valuta.Properties.DisplayMember = "Nama_Valuta"
        Valuta.Properties.ValueMember = "Kode_Valuta"

        daSupp = New SqlDataAdapter(New SqlCommand("select Nama_Supplier,Kode_Supplier from SIF.dbo.SIF_Supplier where rec_stat = 'Y' order by Nama_Supplier", sqlconn))
        daSupp.Fill(dsLOV, "Supplier")
        Supplier.Properties.DataSource = dsLOV.Tables("Supplier")
        Supplier.Properties.DisplayMember = "Nama_Supplier"
        Supplier.Properties.ValueMember = "Kode_Supplier"
    End Sub


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExe.Click
        ErrorProvider1.Clear()

        If tglDari.EditValue = vbNullString Then
            tglDari.EditValue = getTanggal()
        End If

        ListShortingGC1(Supplier.EditValue, Valuta.EditValue, tglDari.Text)

    End Sub

    Sub ListShortingGC1(Optional ByVal SUPP As String = "", Optional ByVal CURRENCY As String = "", Optional ByVal DATETO As String = "")

        If Not dsRekap.Tables("_rekap") Is Nothing Then dsRekap.Tables("_rekap").Clear()



        'Dim sql As String = ""
        'Dim sqlq As String = ""

        'If Supplier.EditValue = vbNullString Then
        '    sql &= " and a.kd_supplier = a.kd_supplier  " & _
        '    "   and a.kd_valuta ='" & Valuta.EditValue & "'  " & _
        '    "   and a.tgl_posting <= convert(date,'" & tglDari.EditValue & "',103) " & _
        '    "   group by a.kd_supplier  , c.Nama_Supplier"
        'End If

        'If Valuta.EditValue = vbNullString Then
        '    sql &= " and a.kd_supplier ='" & Supplier.EditValue & "'  " & _
        '     "   and a.kd_valuta = a.kd_valuta  " & _
        '     "   and a.tgl_posting <= convert(date,'" & tglDari.EditValue & "',103) " & _
        '     "   group by a.kd_supplier , c.Nama_Supplier"
        'End If

        'If Valuta.EditValue = vbNullString And Supplier.EditValue = vbNullString Then
        '    sql &= " and a.kd_supplier =a.kd_supplier  " & _
        '     "   and a.kd_valuta = a.kd_valuta  " & _
        '     "   and a.tgl_posting <= convert(date,'" & tglDari.EditValue & "',103) " & _
        '     "   group by a.kd_supplier  , c.Nama_Supplier"
        'End If

        'If Supplier.EditValue <> "" And Valuta.EditValue <> "" Then
        '    sql &= " and a.kd_supplier ='" & Supplier.EditValue & "'  " & _
        '      "   and a.kd_valuta ='" & Valuta.EditValue & "'  " & _
        '      "   and a.tgl_posting <= convert(date,'" & tglDari.EditValue & "',103) " & _
        '      "   group by a.kd_supplier  , c.Nama_Supplier"
        'End If

        'sqlq = " select ROW_NUMBER() OVER (ORDER BY kd_supplier) as 'nomer',   " & _
        '    "   a.kd_supplier,c.Nama_Supplier,sum(jml_akhir) as 'total'  " & _
        '    "   from FIN.dbo.FIN_PEMBELIAN A , SIF.dbo.SIF_Supplier C   " & _
        '    "   where a.kd_supplier = c.Kode_Supplier  " & _
        '    "   and a.tipe_trans like 'JPP%' " & sql
        'daRekap = New SqlDataAdapter(New SqlCommand(Sql, sqlconn))

        daRekap = New SqlDataAdapter(New SqlCommand("select ROW_NUMBER() OVER (ORDER BY kd_supplier) as 'nomer', a.kd_supplier, c.Nama_Supplier, sum(jml_akhir) as 'total' from FIN.dbo.FIN_PEMBELIAN A, SIF.dbo.SIF_Supplier C where a.kd_supplier = c.Kode_Supplier and a.tipe_trans like 'JPP%' and a.kd_supplier ='" & Supplier.EditValue & "' and a.kd_valuta ='" & Valuta.EditValue & "' and a.tgl_posting <= convert(DATE,'" & tglDari.EditValue & "',103) group by a.kd_supplier, c.Nama_Supplier", sqlconn))
        daRekap.Fill(dsRekap, "_rekap")
        GClvl1.DataSource = dsRekap.Tables("_rekap")
        GVlvl1.BestFitColumns()

        'If SUPP = vbNullString Then
        '    dsRekap.Clear()
        '    daRekap = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select ROW_NUMBER() OVER (ORDER BY kd_supplier) as 'nomer',   " & _
        '    "   a.kd_supplier,c.Nama_Supplier,sum(jml_akhir) as 'total'  " & _
        '    "   from FIN.dbo.FIN_PEMBELIAN A , SIF.dbo.SIF_Supplier C   " & _
        '    "   where   a.kd_supplier = c.Kode_Supplier  " & _
        '    "   and a.tipe_trans like 'JPP%'   " & _
        '    "   and a.kd_supplier = a.kd_supplier  " & _
        '    "   and a.kd_valuta ='" & CURRENCY & "'  " & _
        '    "   and a.tgl_posting <= convert(date,'" & DATETO & "',103) " & _
        '    "   group by a.kd_supplier  , c.Nama_Supplier", sqlconn))
        '    daRekap.Fill(dsRekap, "_rekap")
        '    GClvl1.DataSource = dsRekap.Tables("_rekap")
        '    GVlvl1.BestFitColumns()
        'End If

        'If CURRENCY = vbNullString Then
        '    dsRekap.Clear()
        '    daRekap = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select ROW_NUMBER() OVER (ORDER BY kd_supplier) as 'nomer',   " & _
        '    "   a.kd_supplier,c.Nama_Supplier,sum(jml_akhir) as 'total'  " & _
        '    "   from FIN.dbo.FIN_PEMBELIAN A , SIF.dbo.SIF_Supplier C   " & _
        '    "   where   a.kd_supplier = c.Kode_Supplier  " & _
        '    "   and a.tipe_trans like 'JPP%'   " & _
        '    "   and a.kd_supplier ='" & SUPP & "'  " & _
        '    "   and a.kd_valuta = a.kd_valuta  " & _
        '    "   and a.tgl_posting <= convert(date,'" & DATETO & "',103) " & _
        '    "   group by a.kd_supplier  , c.Nama_Supplier", sqlconn))
        '    daRekap.Fill(dsRekap, "_rekap")
        '    GClvl1.DataSource = dsRekap.Tables("_rekap")
        '    GVlvl1.BestFitColumns()
        'End If

        'If CURRENCY = vbNullString And SUPP = vbNullString Then
        '    dsRekap.Clear()
        '    daRekap = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select ROW_NUMBER() OVER (ORDER BY kd_supplier) as 'nomer',   " & _
        '    "   a.kd_supplier,c.Nama_Supplier,sum(jml_akhir) as 'total'  " & _
        '    "   from FIN.dbo.FIN_PEMBELIAN A , SIF.dbo.SIF_Supplier C   " & _
        '    "   where   a.kd_supplier = c.Kode_Supplier  " & _
        '    "   and a.tipe_trans like 'JPP%'   " & _
        '    "   and a.kd_supplier =a.kd_supplier  " & _
        '    "   and a.kd_valuta = a.kd_valuta  " & _
        '    "   and a.tgl_posting <= convert(date,'" & DATETO & "',103) " & _
        '    "   group by a.kd_supplier  , c.Nama_Supplier", sqlconn))
        '    daRekap.Fill(dsRekap, "_rekap")
        '    GClvl1.DataSource = dsRekap.Tables("_rekap")
        '    GVlvl1.BestFitColumns()
        'End If

        'If SUPP <> "" And CURRENCY <> "" Then
        '    dsRekap.Clear()
        '    daRekap = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select ROW_NUMBER() OVER (ORDER BY kd_supplier) as 'nomer',   " & _
        '    "   a.kd_supplier,c.Nama_Supplier,sum(jml_akhir) as 'total'  " & _
        '    "   from FIN.dbo.FIN_PEMBELIAN A , SIF.dbo.SIF_Supplier C   " & _
        '    "   where   a.kd_supplier = c.Kode_Supplier  " & _
        '    "   and a.tipe_trans like 'JPP%'   " & _
        '    "   and a.kd_supplier ='" & SUPP & "'  " & _
        '    "   and a.kd_valuta ='" & CURRENCY & "'  " & _
        '    "   and a.tgl_posting <= convert(date,'" & DATETO & "',103) " & _
        '    "   group by a.kd_supplier  , c.Nama_Supplier", sqlconn))
        '    daRekap.Fill(dsRekap, "_rekap")
        '    GClvl1.DataSource = dsRekap.Tables("_rekap")
        '    GVlvl1.BestFitColumns()
        'End If

    End Sub

    Sub bersih()
        Supplier.EditValue = vbNullString
        Valuta.EditValue = vbNullString
    End Sub
    'Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
    '    dsRekap.Clear()
    '    dsDetUt.Clear()
    '    dsLunas.Clear()
    '    bersih()
    'End Sub
    'Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
    '    'LoadGrid1()
    '    'LoadGrid2()
    '    'LoadGrid3()
    '    'loadLunas()
    '    loadAll()
    '    loadLookUP()
    'End Sub

    Sub LoadHutang(Optional ByVal supplier As String = "")
        lblError.Text = "..."
        Try
            'If Not dsDetUt.Tables("_DetUt") Is Nothing Then dsDetUt.Tables("_DetUt").Clear()
            'If Not dsDetUt.Tables("_Sub") Is Nothing Then dsDetUt.Tables("_Sub").Clear()
            dsDetUt.Clear()
            dsDetUt.Relations.Clear()
            daDetUt = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("   select ROW_NUMBER() OVER (ORDER BY a.no_inv) as 'nomer', a.tipe_trans,a.kd_supplier,a.no_inv,a.no_ref1,a.tgl_inv ,a.tgl_jth_tempo , " & _
            "   a.no_jurnal,c.Nama_Supplier,a.nm_supplier ,a.kd_buku_besar, " & _
            "   d.nm_buku_besar,a.keterangan , a.no_sj, a.sts_tagihan, a.no_posting, a.tgl_posting,  " & _
            "   a.jml_val_ppn, a.jml_rp_ppn, a.jml_diskon, a.jml_tagihan,  " & _
            "   a.jml_bayar, a.jml_akhir" & _
            "   from SIF.dbo.SIF_Supplier C , SIF.dbo.SIF_buku_besar D , FIN.dbo.FIN_PEMBELIAN A" & _
            "   where a.kd_supplier = c.Kode_Supplier " & _
            "   and a.kd_buku_besar = d.kd_buku_besar   " & _
            "   and a.tipe_trans like 'JPP%'   " & _
            "   and a.kd_supplier = '" & supplier & "'  " & _
            "   and not (a.no_posting is null or a.no_posting = '') ", sqlconn))

            daDetUt.Fill(dsDetUt, "_DetUt")
            GClvl2.DataSource = dsDetUt.Tables("_DetUt")
            GVlvl2.BestFitColumns()

            If dsDetUt.Tables("_DetUt").Rows.Count = 0 Then
                Exit Sub
            Else
                daSub = New SqlDataAdapter(New SqlCommand("SELECT a.no_inv, isnull(b.nomor,'') AS no_giro,b.jml_trans FROM FIN.dbo.FIN_PEMBELIAN a LEFT OUTER JOIN FIN.dbo.FIN_GIRO_D b ON (a.no_inv = b.no_inv) where a.tipe_trans like '%JPP%'", sqlconn))
                daSub.Fill(dsDetUt, "_Sub")

                rl = dsDetUt.Relations.Add("Detail", dsDetUt.Tables("_DetUt").Columns("no_inv"), dsDetUt.Tables("_Sub").Columns("no_inv"))

                GClvl2.LevelTree.Nodes.Add("Detail", GVlvl2sub1)

                GVlvl2sub1.BestFitColumns()
            End If
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try
    End Sub

    Private Sub GClvl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GClvl1.Click
        lblError.Text = "..."
        lblError2.Text = "..."

        'SELECT GRID 2
        Try
            Dim kSp As String
            Dim viewLvl1 As ColumnView = GVlvl1
            kSp = viewLvl1.GetFocusedRowCellValue("kd_supplier").ToString

            LoadHutang(kSp)
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try
        'SELECT GRID 3
        If Not GVlvl2.RowCount = 0 Then
            Try
                Dim kNoInv As String
                Dim viewLvl2 As ColumnView = GVlvl2
                kNoInv = viewLvl2.GetFocusedRowCellValue("no_inv").ToString

                loadPiutang(kNoInv)
                loadLunas(kNoInv)
            Catch ex As Exception
                lblError2.Text = ex.Message
            End Try
        Else
            If Not dsLunas.Tables("_Lunas") Is Nothing Then dsLunas.Tables("_Lunas").Clear()
            If Not dsLunas.Tables("v_Lunas") Is Nothing Then dsLunas.Tables("v_Lunas").Clear()
        End If
    End Sub

    Sub loadPiutang(Optional ByVal invoice As String = "")
        lblError.Text = "..."
        Try

            dsLunas.Clear()
            daLunas = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("  select  ROW_NUMBER() OVER (ORDER BY a.no_trans) as 'nomer', " & _
            "   a.tipe_trans ,a.no_trans, a.tgl_trans , a.no_ref1 , a.kd_kartu , " & _
            "   a.kd_giro , a.kd_valuta  , a.keterangan ,  b.prev_no_inv , " & _
            "   b.jml_tagihan , b.jml_piut , b.jml_pph , b.jml_ppn , " & _
            "   b.jml_diskon, b.pendp_lain, b.biaya_lain, b.jml_bayar " & _
            "   from FIN.dbo.FIN_BELI_LUNAS A , FIN.dbo.FIN_BELI_LUNAS_D B  " & _
            "   where  a.no_trans = b.no_trans " & _
            "   and prev_no_inv = '" & invoice & "'", sqlconn))

            daLunas.Fill(dsLunas, "_Lunas")
            GClvl3.DataSource = dsLunas.Tables("_Lunas")
            GVlvl3.BestFitColumns()
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try

    End Sub

    Sub loadLunas(Optional ByVal invoice As String = "")
        lblError.Text = "..."
        Try

            dsLunas.Clear()
            daLunas = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.v_lunas_hutang_detail where prev_no_inv = '" & invoice & "'", sqlconn))

            daLunas.Fill(dsLunas, "v_Lunas")
            GClunas.DataSource = dsLunas.Tables("v_Lunas")
            GVlunas.BestFitColumns()
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try


    End Sub

    'Private Sub GClvl2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GClvl2.Click
    '    Try
    '        Dim kNoInv As String
    '        Dim viewLvl2 As ColumnView = GVlvl2
    '        kNoInv = viewLvl2.GetFocusedRowCellValue("no_inv").ToString

    '        loadPiutang(kNoInv)
    '        loadLunas(kNoInv)
    '    Catch ex As Exception
    '        lblError.Text = ex.Message
    '    End Try

    'End Sub

    Private Sub cmdAdvance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdvance.Click
        ColVisible()
    End Sub

    Sub ColVisible()
        If GVlvl2.Columns("kd_supplier").Visible = True Then

            'GVlvl1.Columns("kd_supplier").Visible = False

            'GVlvl2.Columns("tipe_trans").Visible = False
            'GVlvl2.Columns("kd_supplier").Visible = False
            GVlvl2.Columns("kd_buku_besar").Visible = False
            GVlvl2.Columns("no_posting").Visible = False
            GVlvl2.Columns("tgl_posting").Visible = False
            GVlvl2.Columns("keterangan").Visible = False

            'GVlvl3.Columns("kd_kartu").Visible = False
            GVlvl3.Columns("tipe_trans").Visible = False
            GVlvl3.Columns("kd_valuta").Visible = False
            GVlvl3.Columns("keterangan").Visible = False

            'cmdAdvance.Text = "Advance"
        ElseIf GVlvl2.Columns("kd_supplier").Visible = False Then

            GVlvl1.Columns("kd_supplier").Visible = True

            'GVlvl2.Columns("tipe_trans").Visible = True
            'GVlvl2.Columns("kd_supplier").Visible = True
            'GVlvl2.Columns("kd_buku_besar").Visible = True
            'GVlvl2.Columns("no_posting").Visible = True
            'GVlvl2.Columns("tgl_posting").Visible = True
            GVlvl2.Columns("keterangan").Visible = True

            'GVlvl3.Columns("kd_kartu").Visible = True
            'GVlvl3.Columns("tipe_trans").Visible = True
            GVlvl3.Columns("kd_valuta").Visible = True
            GVlvl3.Columns("keterangan").Visible = True

            'cmdAdvance.Text = "Simple"
        End If
    End Sub

    Private Sub CE_GC1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CE_GC1.CheckedChanged
        If CE_GC1.Checked = True Then
            CE_GC2.Checked = False
            CE_GC3.Checked = False
            SplitContainerControlMaster.SplitterPosition = 1500
            SplitContainerControlSub.SplitterPosition = 265
        ElseIf CE_GC1.Checked = False Then
            SplitContainerControlMaster.SplitterPosition = 300
            SplitContainerControlSub.SplitterPosition = 265
        End If
    End Sub

    Private Sub CE_GC2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CE_GC2.CheckedChanged
        If CE_GC2.Checked = True Then
            CE_GC1.Checked = False
            CE_GC3.Checked = False
            SplitContainerControlMaster.SplitterPosition = 0
            SplitContainerControlSub.SplitterPosition = 1500
        ElseIf CE_GC2.Checked = False Then
            SplitContainerControlMaster.SplitterPosition = 300
            SplitContainerControlSub.SplitterPosition = 265
        End If
    End Sub

    Private Sub CE_GC3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CE_GC3.CheckedChanged
        If CE_GC3.Checked = True Then
            CE_GC1.Checked = False
            CE_GC2.Checked = False
            SplitContainerControlMaster.SplitterPosition = 0
            SplitContainerControlSub.SplitterPosition = 0
        ElseIf CE_GC3.Checked = False Then
            SplitContainerControlMaster.SplitterPosition = 300
            SplitContainerControlSub.SplitterPosition = 265
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
        ErrorProvider1.Clear()

        If CE_GC1.Checked = False And CE_GC2.Checked = False And CE_GC3.Checked = False Then
            ErrorProvider1.SetError(CE_GC1, "pilih salah satu yang akan dicetak")
            ErrorProvider1.SetError(CE_GC2, "pilih salah satu yang akan dicetak")
            ErrorProvider1.SetError(CE_GC3, "pilih salah satu yang akan dicetak")
        Else
            If CE_GC1.Checked = True Then
                ShowGridPreview(GClvl1)
            ElseIf CE_GC2.Checked = True Then
                ShowGridPreview(GClvl2)
            ElseIf CE_GC3.Checked = True Then
                ShowGridPreview(GClvl3)
            End If
        End If

    End Sub

    Private Sub CElunas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CElunas.CheckedChanged
        If CElunas.Checked = True Then
            GClunas.BringToFront()
        Else
            GClvl3.BringToFront()
        End If
    End Sub

    Public Sub cetak_click()
        ErrorProvider1.Clear()

        If CE_GC1.Checked = False And CE_GC2.Checked = False And CE_GC3.Checked = False Then
            ErrorProvider1.SetError(CE_GC1, "pilih salah satu yang akan dicetak")
            ErrorProvider1.SetError(CE_GC2, "pilih salah satu yang akan dicetak")
            ErrorProvider1.SetError(CE_GC3, "pilih salah satu yang akan dicetak")
        Else
            If CE_GC1.Checked = True Then
                ShowGridPreview(GClvl1)
            ElseIf CE_GC2.Checked = True Then
                ShowGridPreview(GClvl2)
            ElseIf CE_GC3.Checked = True Then
                ShowGridPreview(GClvl3)
            End If
        End If
    End Sub

    Private Sub GVlvl2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVlvl2.Click
        Try
            Dim kNoInv As String
            Dim viewLvl2 As ColumnView = GVlvl2
            kNoInv = viewLvl2.GetFocusedRowCellValue("no_inv").ToString

            loadPiutang(kNoInv)
            loadLunas(kNoInv)
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try
    End Sub
End Class