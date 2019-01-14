'|-----------------------
'|  CREATED BY RENDY    |
'|  EDITED BY RENDY     |
'|-----------------------
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Public Class frmMonUtangLain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim err As String = ""
    Dim isvalid As Boolean

    Dim dsRekap, dsDetUt, dsLunas, dsLOV As New DataSet
    Dim daRekap, daDetUt, daLunas, daValuta, daSupp As SqlDataAdapter
    Private Sub frmMonUtangLain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)

        LoadGrid1()
        LoadGrid2()
        LoadGrid3()

        Try
            Dim kSp As String
            Dim viewLvl1 As ColumnView = GVlvl1
            kSp = viewLvl1.GetFocusedRowCellValue("kd_supplier").ToString
            loadHutang(kSp)

            Dim kNoInv As String
            Dim viewLvl2 As ColumnView = GVlvl2
            kNoInv = viewLvl2.GetFocusedRowCellValue("no_inv").ToString
            LoadPiutang(kNoInv)
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try

        loadLookUP()
        ColVisible()
        Me.Enabled = True
        GVlvl1.BestFitColumns()
        GVlvl2.BestFitColumns()
        GVlvl3.BestFitColumns()

        tglDari.EditValue = getTanggal()
        Kartu.ItemIndex = 0
        Valuta.ItemIndex = 0
    End Sub
    Sub LoadGrid1()
        'select 
        'ROW_NUMBER() OVER (ORDER BY kd_supplier) as 'nomer', 
        'a.kd_supplier,c.nama,sum(jml_akhir) as 'total'
        'from FIN.dbo.FIN_PEMBELIAN A , FIN.dbo.v_kartu C
        'where a.kd_supplier = c.kode
        'and a.tipe_trans like 'JKM%'
        'and a.no_posting is not null
        'group by a.kd_supplier  , c.nama

        dsRekap.Clear()
        daRekap = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("	select  ROW_NUMBER() OVER (ORDER BY kd_supplier) as 'nomer', " & _
        "   a.kd_supplier,c.nama,sum(jml_akhir) as 'total'  " & _
        "   from FIN.dbo.FIN_PEMBELIAN A , FIN.dbo.v_kartu C  " & _
        "   where  a.kd_supplier = c.kode " & _
        "   and a.tipe_trans like 'JKM%' " & _
        "   and a.no_posting is not null " & _
        "   group by a.kd_supplier  , c.nama", sqlconn))

        daRekap.Fill(dsRekap, "_rekap")
        GClvl1.DataSource = dsRekap.Tables("_rekap")
        GVlvl1.BestFitColumns()
    End Sub

    Sub LoadGrid2()
        'select 
        'ROW_NUMBER() OVER (ORDER BY kd_supplier) as 'nomer', 
        'a.tipe_trans,a.kd_supplier,a.no_inv,a.tgl_inv ,a.tgl_jth_tempo ,a.no_jurnal,
        'c.nama,a.nm_supplier ,a.kd_buku_besar,d.nm_buku_besar,a.keterangan ,
        'a.no_posting,a.tgl_posting ,a.jml_val_ppn , a.jml_rp_ppn , a.jml_diskon , a.jml_tagihan , a.jml_bayar , a.jml_akhir 
        'from FIN.dbo.FIN_PEMBELIAN A , FIN.dbo.v_kartu C , SIF.dbo.SIF_buku_besar D
        'where a.kd_supplier = c.kode
        'and a.kd_buku_besar = d.kd_buku_besar
        'and a.no_posting is not null
        'and a.tipe_trans like 'JKM%'


        'select 
        'ROW_NUMBER() OVER (ORDER BY kd_supplier) as 'nomer', *
        'from FIN.dbo.FIN_PEMBELIAN
        'where 
        'tipe_trans like 'JKM%'

        dsDetUt.Clear()
        daDetUt = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select  ROW_NUMBER() OVER (ORDER BY kd_supplier) as 'nomer', " & _
        "   a.tipe_trans,a.kd_supplier,a.no_inv,a.tgl_inv , " & _
        "   a.tgl_jth_tempo ,a.no_jurnal,  c.nama,a.nm_supplier , " & _
        "   a.kd_buku_besar,d.nm_buku_besar,a.keterangan ,   " & _
        "   a.no_posting, a.tgl_posting, a.jml_val_ppn, a.jml_rp_ppn, " & _
        "   a.jml_diskon, a.jml_tagihan, a.jml_bayar, a.jml_akhir " & _
        "   from FIN.dbo.FIN_PEMBELIAN A , FIN.dbo.v_kartu C , SIF.dbo.SIF_buku_besar D   " & _
        "   where  a.kd_supplier = c.kode   " & _
        "   and a.kd_buku_besar = d.kd_buku_besar  " & _
        "   and a.no_posting is not null " & _
        "   and a.tipe_trans like 'JKM%'", sqlconn))
        daDetUt.Fill(dsDetUt, "_DetUt")
        GClvl2.DataSource = dsDetUt.Tables("_DetUt")
        GVlvl2.BestFitColumns()
    End Sub

    Sub LoadGrid3()

        'select 
        'ROW_NUMBER() OVER (ORDER BY a.no_trans) as 'nomer', 
        'a.no_trans ,a.tipe_trans, a.tgl_trans , a.no_ref1 , a.kd_kartu , 
        'a.kd_giro , a.keterangan , b.prev_no_inv , a.kd_valuta,
        'b.jml_tagihan , b.jml_piut , b.jml_pph , b.jml_ppn ,
        'b.jml_diskon , b.pendp_lain , b.biaya_lain , b.jml_bayar 
        'from FIN.dbo.FIN_BELI_LUNAS A , FIN.dbo.FIN_BELI_LUNAS_D B
        'where a.no_trans = b.no_trans

        dsLunas.Clear()
        daLunas = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  ROW_NUMBER() OVER (ORDER BY a.no_trans) as 'nomer', " & _
        "   a.no_trans ,a.tipe_trans, a.tgl_trans , a.no_ref1 , " & _
        "   a.kd_kartu ,  a.kd_giro , a.keterangan , b.prev_no_inv ,  " & _
        "   a.kd_valuta, b.jml_tagihan , b.jml_piut , b.jml_pph , " & _
        "   b.jml_ppn , b.jml_diskon, " & _
        "   b.pendp_lain, b.biaya_lain, b.jml_bayar " & _
        "   from FIN.dbo.FIN_BELI_LUNAS A , FIN.dbo.FIN_BELI_LUNAS_D B  " & _
        "   where a.no_trans = b.no_trans", sqlconn))

        daLunas.Fill(dsLunas, "_Lunas")
        GClvl3.DataSource = dsLunas.Tables("_Lunas")
        GVlvl3.BestFitColumns()
    End Sub

    Sub loadLookUP()

        dsLOV.Clear()

        daValuta = New SqlDataAdapter(New SqlCommand("select Kode_Valuta, Nama_Valuta from SIF.dbo.SIF_Valuta", sqlconn))
        daValuta.Fill(dsLOV, "Valuta")
        Valuta.Properties.DataSource = dsLOV.Tables("Valuta")
        Valuta.Properties.DisplayMember = "Nama_Valuta"
        Valuta.Properties.ValueMember = "Kode_Valuta"

        daSupp = New SqlDataAdapter(New SqlCommand("select nama,kode from FIN.dbo.v_kartu", sqlconn))
        daSupp.Fill(dsLOV, "kartu")
        Kartu.Properties.DataSource = dsLOV.Tables("kartu")
        Kartu.Properties.DisplayMember = "nama"
        Kartu.Properties.ValueMember = "kode"
    End Sub


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExe.Click
        ErrorProvider1.Clear()

        If tglDari.EditValue = vbNullString Then
            tglDari.EditValue = getTanggal()
        End If

        ListShortingGC1(Kartu.EditValue, Valuta.EditValue, tglDari.Text)

    End Sub

    Sub ListShortingGC1(Optional ByVal CARD As String = "", Optional ByVal CURRENCY As String = "", Optional ByVal DATETO As String = "")
        'select ROW_NUMBER() OVER (ORDER BY kd_supplier) as 'nomer', 
        'a.kd_supplier,c.nama,sum(jml_akhir) as 'total' 
        'from FIN.dbo.FIN_PEMBELIAN A , FIN.dbo.v_kartu C
        'where  a.kd_supplier = c.kode 
        'and a.tipe_trans like 'JKM%' 
        'and a.kd_supplier = '" & Kartu.EditValue & "'
        'and a.kd_valuta = '" & Valuta.EditValue & "' 
        'and a.tgl_posting between '" & tglDari.EditValue & "' and '" & tglsampai.EditValue & "' 
        'group by a.kd_supplier  , c.nama

        'Try

        If CARD = vbNullString Then
            dsRekap.Clear()
            daRekap = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select ROW_NUMBER() OVER (ORDER BY kd_supplier) as 'nomer',   " & _
            "   a.kd_supplier,c.nama,sum(jml_akhir) as 'total'   " & _
            "   from FIN.dbo.FIN_PEMBELIAN A , FIN.dbo.v_kartu C    " & _
            "   where  a.kd_supplier = c.kode    " & _
            "   and a.tipe_trans like 'JKM%'   " & _
            "   and a.kd_supplier = a.kd_supplier  " & _
            "   and a.kd_valuta = '" & CURRENCY & "'   " & _
            "   and a.tgl_posting <= convert(date,'" & DATETO & "',103)   " & _
            "   group by a.kd_supplier  , c.nama", sqlconn))

            daRekap.Fill(dsRekap, "_rekap")
            GClvl1.DataSource = dsRekap.Tables("_rekap")
            GVlvl1.BestFitColumns()
        End If

        If CURRENCY = vbNullString Then
            dsRekap.Clear()
            daRekap = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select ROW_NUMBER() OVER (ORDER BY kd_supplier) as 'nomer',   " & _
            "   a.kd_supplier,c.nama,sum(jml_akhir) as 'total'   " & _
            "   from FIN.dbo.FIN_PEMBELIAN A , FIN.dbo.v_kartu C    " & _
            "   where  a.kd_supplier = c.kode    " & _
            "   and a.tipe_trans like 'JKM%'   " & _
            "   and a.kd_supplier = '" & CARD & "'  " & _
            "   and a.kd_valuta = a.kd_valuta   " & _
            "   and a.tgl_posting <= convert(date,'" & DATETO & "',103)   " & _
            "   group by a.kd_supplier  , c.nama", sqlconn))

            daRekap.Fill(dsRekap, "_rekap")
            GClvl1.DataSource = dsRekap.Tables("_rekap")
            GVlvl1.BestFitColumns()
        End If

        If CARD = vbNullString And CURRENCY = vbNullString Then
            dsRekap.Clear()
            daRekap = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select ROW_NUMBER() OVER (ORDER BY kd_supplier) as 'nomer',   " & _
            "   a.kd_supplier,c.nama,sum(jml_akhir) as 'total'   " & _
            "   from FIN.dbo.FIN_PEMBELIAN A , FIN.dbo.v_kartu C    " & _
            "   where  a.kd_supplier = c.kode    " & _
            "   and a.tipe_trans like 'JKM%'   " & _
            "   and a.kd_supplier = a.kd_supplier  " & _
            "   and a.kd_valuta = a.kd_valuta   " & _
            "   and a.tgl_posting <= convert(date,'" & DATETO & "',103)   " & _
            "   group by a.kd_supplier  , c.nama", sqlconn))

            daRekap.Fill(dsRekap, "_rekap")
            GClvl1.DataSource = dsRekap.Tables("_rekap")
            GVlvl1.BestFitColumns()
        End If

        If CARD <> vbNullString And CURRENCY <> vbNullString Then
            dsRekap.Clear()
            daRekap = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select ROW_NUMBER() OVER (ORDER BY kd_supplier) as 'nomer',   " & _
            "   a.kd_supplier,c.nama,sum(jml_akhir) as 'total'   " & _
            "   from FIN.dbo.FIN_PEMBELIAN A , FIN.dbo.v_kartu C    " & _
            "   where  a.kd_supplier = c.kode    " & _
            "   and a.tipe_trans like 'JKM%'   " & _
            "   and a.kd_supplier = '" & CARD & "'  " & _
            "   and a.kd_valuta = '" & CURRENCY & "'   " & _
            "   and a.tgl_posting <= convert(date,'" & DATETO & "',103)   " & _
            "   group by a.kd_supplier  , c.nama", sqlconn))

            daRekap.Fill(dsRekap, "_rekap")
            GClvl1.DataSource = dsRekap.Tables("_rekap")
            GVlvl1.BestFitColumns()

        End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Sub bersih()
        Kartu.EditValue = vbNullString
        Valuta.EditValue = vbNullString
        tglDari.EditValue = vbNullString
    End Sub
    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        dsRekap.Clear()
        dsDetUt.Clear()
        dsLunas.Clear()
        bersih()
    End Sub
    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        LoadGrid1()
        LoadGrid2()
        LoadGrid3()
        loadLookUP()
    End Sub

    Sub loadHutang(Optional ByVal supplier As String = "")
        lblError.Text = "..."
        Try
            'Dim kSp As String
            'Dim viewLvl1 As ColumnView = GVlvl1
            'kSp = viewLvl1.GetFocusedRowCellValue("kd_supplier").ToString

            'select 
            'ROW_NUMBER() OVER (ORDER BY kd_supplier) as 'nomer', 
            'a.tipe_trans,a.kd_supplier,a.no_inv,a.tgl_inv ,a.tgl_jth_tempo ,a.no_jurnal,c.nama,a.nm_supplier ,a.kd_buku_besar,d.nm_buku_besar,a.keterangan ,
            'a.no_posting,a.tgl_posting ,a.jml_val_ppn , a.jml_rp_ppn , a.jml_diskon , a.jml_tagihan , a.jml_bayar , a.jml_akhir 
            'from FIN.dbo.FIN_PEMBELIAN A , FIN.dbo.v_kartu C , SIF.dbo.SIF_buku_besar D
            'where a.kd_supplier = c.kode
            'and a.kd_buku_besar = d.kd_buku_besar
            'and a.tipe_trans like 'JKM%'
            'and a.kd_supplier = 'S000002'

            dsDetUt.Clear()
            daDetUt = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  ROW_NUMBER() OVER (ORDER BY kd_supplier) as 'nomer', " & _
            "  a.tipe_trans , a.kd_supplier , a.no_inv , a.tgl_inv , a.tgl_jth_tempo ," & _
            "  a.no_jurnal, c.nama, a.nm_supplier, a.kd_buku_besar, d.nm_buku_besar, " & _
            "  a.keterangan, a.no_posting, a.tgl_posting, " & _
            "  a.jml_val_ppn, a.jml_rp_ppn, a.jml_diskon, a.jml_tagihan, a.jml_bayar, a.jml_akhir " & _
            "  from FIN.dbo.FIN_PEMBELIAN A , FIN.dbo.v_kartu C , SIF.dbo.SIF_buku_besar D  " & _
            "  where  a.kd_supplier = c.kode  " & _
            "   and a.kd_buku_besar = d.kd_buku_besar " & _
            "  and a.tipe_trans like 'JKM%'  " & _
            "  and a.kd_supplier = '" & supplier & "'  ", sqlconn))

            daDetUt.Fill(dsDetUt, "_DetUt")
            GClvl2.DataSource = dsDetUt.Tables("_DetUt")
            GVlvl2.BestFitColumns()

        Catch ex As Exception
            lblError.Text = ex.Message
        End Try
    End Sub


    Private Sub GClvl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GClvl1.Click
        'SELECT GRID 2
        Try
            Dim kSp As String
            Dim viewLvl1 As ColumnView = GVlvl1
            kSp = viewLvl1.GetFocusedRowCellValue("kd_supplier").ToString

            loadHutang(kSp)
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try
        'SELECT GRID 3
        Try
            Dim kNoInv As String
            Dim viewLvl2 As ColumnView = GVlvl2
            kNoInv = viewLvl2.GetFocusedRowCellValue("no_inv").ToString

            LoadPiutang(kNoInv)
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try
    End Sub

    Sub LoadPiutang(Optional ByVal invoice As String = "")
        lblError.Text = "..."
        Try

            'Dim kNoInv As String
            'Dim viewLvl2 As ColumnView = GVlvl2
            'kNoInv = viewLvl2.GetFocusedRowCellValue("no_inv").ToString

            'select 
            'ROW_NUMBER() OVER (ORDER BY a.no_trans) as 'nomer', 
            'a.tipe_trans ,a.no_trans, a.tgl_trans , a.no_ref1 , a.kd_kartu , 
            'a.kd_giro , a.kd_valuta  , a.keterangan ,
            ' b.prev_no_inv , b.jml_tagihan , b.jml_piut , b.jml_pph , b.jml_ppn ,
            'b.jml_diskon , b.pendp_lain , b.biaya_lain , b.jml_bayar 
            'from FIN.dbo.FIN_BELI_LUNAS A , FIN.dbo.FIN_BELI_LUNAS_D B
            'where a.no_trans = b.no_trans
            'and prev_no_inv = '20110713/PUR-8/00001'

            dsLunas.Clear()
            daLunas = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  ROW_NUMBER() OVER (ORDER BY a.no_trans) as 'nomer',   " & _
            "  a.tipe_trans ,a.no_trans, a.tgl_trans , a.no_ref1 , a.kd_kartu ,   " & _
            "  a.kd_giro , a.kd_valuta  , a.keterangan ,   " & _
            "  b.prev_no_inv , b.jml_tagihan , b.jml_piut , b.jml_pph , b.jml_ppn ,    " & _
            "  b.jml_diskon, b.pendp_lain, b.biaya_lain, b.jml_bayar  " & _
            "  from FIN.dbo.FIN_BELI_LUNAS A , FIN.dbo.FIN_BELI_LUNAS_D B   " & _
            "  where   a.no_trans = b.no_trans   " & _
            "  and prev_no_inv = '" & invoice & "'", sqlconn))
            daLunas.Fill(dsLunas, "_Lunas")
            GClvl3.DataSource = dsLunas.Tables("_Lunas")
            GVlvl3.BestFitColumns()

        Catch ex As Exception
            lblError.Text = ex.Message
        End Try
    End Sub

    Private Sub GClvl2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GClvl2.Click
        Try
            Dim kNoInv As String
            Dim viewLvl2 As ColumnView = GVlvl2
            kNoInv = viewLvl2.GetFocusedRowCellValue("no_inv").ToString

            LoadPiutang(kNoInv)
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try
    End Sub

    Private Sub cmdAdvance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdvance.Click
        ColVisible()
    End Sub

    Sub ColVisible()
        If GVlvl2.Columns("kd_supplier").Visible = True Then

            GVlvl1.Columns("kd_supplier").Visible = False

            GVlvl2.Columns("tipe_trans").Visible = False
            GVlvl2.Columns("kd_supplier").Visible = False
            GVlvl2.Columns("kd_buku_besar").Visible = False
            GVlvl2.Columns("no_posting").Visible = False
            GVlvl2.Columns("tgl_posting").Visible = False
            GVlvl2.Columns("keterangan").Visible = False

            GVlvl3.Columns("kd_kartu").Visible = False
            GVlvl3.Columns("tipe_trans").Visible = False
            GVlvl3.Columns("kd_valuta").Visible = False
            GVlvl3.Columns("keterangan").Visible = False

            cmdAdvance.Text = "Advance"
        ElseIf GVlvl2.Columns("kd_supplier").Visible = False Then

            GVlvl1.Columns("kd_supplier").Visible = True

            GVlvl2.Columns("tipe_trans").Visible = True
            GVlvl2.Columns("kd_supplier").Visible = True
            GVlvl2.Columns("kd_buku_besar").Visible = True
            GVlvl2.Columns("no_posting").Visible = True
            GVlvl2.Columns("tgl_posting").Visible = True
            GVlvl2.Columns("keterangan").Visible = True

            GVlvl3.Columns("kd_kartu").Visible = True
            GVlvl3.Columns("tipe_trans").Visible = True
            GVlvl3.Columns("kd_valuta").Visible = True
            GVlvl3.Columns("keterangan").Visible = True

            cmdAdvance.Text = "Simple"
        End If
    End Sub

    Private Sub CE_GC1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CE_GC1.CheckedChanged
        If CE_GC1.Checked = True Then
            CE_GC2.Checked = False
            CE_GC3.Checked = False
            SplitContainerControlMaster.SplitterPosition = 1500
            SplitContainerControlSub.SplitterPosition = 280
        ElseIf CE_GC1.Checked = False Then
            SplitContainerControlMaster.SplitterPosition = 300
            SplitContainerControlSub.SplitterPosition = 280
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
            SplitContainerControlSub.SplitterPosition = 280
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
            SplitContainerControlSub.SplitterPosition = 280
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
        If CE_GC1.Checked = True Then
            ShowGridPreview(GClvl1)
        ElseIf CE_GC2.Checked = True Then
            ShowGridPreview(GClvl2)
        ElseIf CE_GC3.Checked = True Then
            ShowGridPreview(GClvl3)
        End If
    End Sub

End Class