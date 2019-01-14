Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Windows.Forms
Imports DevExpress.XtraPrintingLinks
Imports DevExpress.XtraPrinting

Public Class MonBKReturPO
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Dim ds_cari3, ds_cari2, ds_cari, ds_cari1, dsLookUp As New DataSet
    Dim da, DA_gdg2, DAL, DALOOKUP1, DALOOKUP, DALOOKUP2 As SqlDataAdapter
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False


    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder
        btnSave = False
        btnEdit = False
        btnadd = False
        btnCancel = False
        setStatus()
    End Sub

    Private Sub Loadblthn()
        If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        DALOOKUP2.Fill(dsLookUp, "LookPeriode")
        lookupBulanAwal.Properties.DataSource = dsLookUp.Tables("LookPeriode")
        lookupBulanAwal.Properties.DisplayMember = "nama"
        lookupBulanAwal.Properties.ValueMember = "thnbln"

    End Sub

    Sub ReloadTable()
        Dim sqltgl As String = ""
        If tglDari.EditValue = vbNullString And tglsampai.EditValue = vbNullString And lookupBulanAwal.EditValue = vbNullString Then
            sqltgl = "1=0"
        ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue = vbNullString Then
            sqltgl = " gdo.tgl_trans > convert(date,'" & tglDari.Text & "',103)"
        ElseIf tglDari.EditValue = vbNullString And tglsampai.EditValue <> vbNullString Then
            sqltgl = " gdo.tgl_trans < convert(date,'" & tglsampai.Text & "',103)"
        ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString Then
            sqltgl = " gdo.tgl_trans between convert(date,'" & tglDari.Text & "',103) and convert(date,'" & tglsampai.Text & "',103)"
        ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString And lookupBulanAwal.EditValue <> vbNullString Then
            sqltgl = sqltgl & "and gdo.blthn='" & lookupBulanAwal.EditValue & "'"
        Else      '  LookupBlthn.EditValue <> vbNullString Then
            sqltgl = "gdo.blthn='" & lookupBulanAwal.EditValue & "'"
        End If


        If Not dsLookUp.Tables("_MonQC") Is Nothing Then dsLookUp.Tables("_MonQC").Clear()
        'Dim sql As String = "select *,case when gdod.qty_sisa_retur=0 then 'CLOSE' end as status_retur from INV.dbo.INV_GUDANG_OUT gdo inner join INV.dbo.INV_GUDANG_OUT_D gdod on gdo.no_trans=gdod.no_trans where SUBSTRING(gdo.no_trans,12,3)='RTR' "
        Dim sql As String = "select *,case when gdod.qty_sisa_retur=0 then 'CLOSE' ELSE 'OPEN' end as status_retur,0 as nomer " & _
        "from INV.dbo.INV_GUDANG_OUT gdo inner join INV.dbo.INV_GUDANG_OUT_D gdod on gdo.no_trans=gdod.no_trans " & _
        "where SUBSTRING(gdo.no_trans,12,3)='RTR'"
        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(sql & " and " & sqltgl, sqlconn))
        da.Fill(dsLookUp, "_MonQC")
        GvINV_Ret.BestFitColumns()
    End Sub

    'Private Sub isitable()
    '    Dim i As Int16 = 1
    '    Dim sqldr As SqlDataReader = New SqlCommand("select qc.tgl_trans, qc.no_trans,qc.no_ref,po.kd_supplier,sup.Nama_Supplier, qc.kd_stok,qc.tgl_trans,qc.qty_datang,qc.qty_order,qc.qty_qc_pass,qc.qty_qc_unpass,qc.qty_hold,qc.qty_sisa,qc.rp_trans,qcm.jml_rp_trans, 0 as nomer from INV.dbo.INV_QC as qc INNER join PURC.dbo.PURC_PO as po on qc.no_ref=po.no_po LEFT JOIN INV.dbo.INV_QC_M as qcm on qc.no_trans=qcm.no_trans LEFT JOIN sif.dbo.SIF_Supplier as sup on po.kd_supplier=sup.Kode_Supplier where qc.blthn='" & LookupBlthn.EditValue & "'", sqlconn).ExecuteReader
    '    While sqldr.Read
    '        Dim row As DataRow = ds.Tables("_MonQC").NewRow
    '        row.Item("nomer") = i : i += 1
    '        row.Item("kd_stok") = sqldr.Item("kd_stok")
    '        row.Item("no_ref") = sqldr.Item("no_ref")
    '        row.Item("Nama_Supplier") = sqldr.Item("Nama_Supplier")
    '        row.Item("no_trans") = sqldr.Item("no_trans")
    '        row.Item("tgl_trans") = sqldr.Item("tgl_trans")
    '        row.Item("qty_order") = sqldr.Item("qty_order")
    '        row.Item("qty_datang") = sqldr.Item("qty_datang")
    '        row.Item("qty_qc_pass") = sqldr.Item("qty_qc_pass")
    '        row.Item("qty_qc_unpass") = sqldr.Item("qty_qc_unpass")
    '        row.Item("qty_hold") = sqldr.Item("qty_hold")
    '        row.Item("qty_sisa") = sqldr.Item("qty_sisa")

    '        ds.Tables("_MonQC").Rows.Add(row)
    '    End While
    '    sqldr.Close()
    'End Sub

    Private Sub isinomer()
        Dim i As Int16 = 1
        For Each row As DataRow In dsLookUp.Tables("_MonQC").Rows
            row.Item("nomer") = i : i += 1
        Next
    End Sub


    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        'MsgBox(lookupBulanAwal.EditValue)
        'MsgBox(lookupBulanAwal.Text)
        ReloadTable()
        isinomer()
    End Sub
    Sub print_gc1(ByVal xGc As Object, ByVal xreportHeader As String)
        Dim ps As New PrintingSystem()
        Dim link As New PrintableComponentLink(ps)
        Dim ph As DevExpress.XtraPrinting.PageHeaderFooter = CType(link.PageHeaderFooter, PageHeaderFooter)
        ph.Header.Content.Add("                                                                         " & umum.Perusahaan & vbCrLf & xreportHeader)
        ph.Header.Content.Add("")
        ph.Header.Content.Add(getTanggal.ToShortDateString)
        ph.Header.LineAlignment = BrickAlignment.Near
        ph.Footer.Content.Add("")
        ph.Footer.Content.Add("Lembar : [Page # of Pages #]")
        ph.Header.Font = New Font("Tahoma", 10, FontStyle.Bold)

        link.Component = xGc
        link.Margins.Left = 4
        link.Margins.Right = 4
        link.Margins.Bottom = 40
        link.Margins.Top = 105
        link.PaperKind = System.Drawing.Printing.PaperKind.A4
        link.Landscape = True
        link.CreateDocument()
        link.ShowPreview()

    End Sub
    Public Sub cetak_click()
        GcINV_Ret.Refresh()
        'GcMonQC.OptionsPrint.UsePrintStyles = True
        print_gc1(GcINV_Ret, "                                                                MONITORING BARANG KELUAR RETUR PEMBELIAN (PO)   " & vbCrLf & _
                 "     ")
        'PrintingSystem1.ResetProgressReflector()
        'PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub btnprin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprin.Click
        cetak_click()
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        lookupBulanAwal.EditValue = vbNullString
        tglDari.EditValue = vbNullString
        tglsampai.EditValue = vbNullString
    End Sub

    Private Sub MonBKReturPO_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        ReloadTable()
        'formate_yayak()
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        GcINV_Ret.DataSource = dsLookUp.Tables("_MonQC")

        'prn = getParent(Me)
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        'prn = getParent(Me)
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)


        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang ", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        RepBarang.DataSource = ds_cari.Tables("_lookup1")
        RepBarang.ValueMember = "Kode_Barang"
        RepBarang.DisplayMember = "Nama_Barang"

        DAL = New SqlDataAdapter(New SqlCommand("SELECT Nama_Gudang,Kode_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DAL.Fill(ds_cari3, "_lookup")
        RL_GdgAsal.DataSource = ds_cari3.Tables("_lookup")
        RL_GdgAsal.ValueMember = "Kode_Gudang"
        RL_GdgAsal.DisplayMember = "Nama_Gudang"

        DA_gdg2 = New SqlDataAdapter(New SqlCommand("select Nama_Gudang,Kode_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DA_gdg2.Fill(ds_cari, "_luGdg7")
        RL_GdgTujuan.DataSource = ds_cari.Tables("_luGdg7")
        RL_GdgTujuan.ValueMember = "Kode_Gudang"
        RL_GdgTujuan.DisplayMember = "Nama_Gudang"

        'load_noretur()

        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select Kode_Supplier,Nama_Supplier from SIF.dbo.SIF_Supplier", sqlconn))
        DALOOKUP2.Fill(ds_cari2, "_LookupS")
        RepSupplier.DataSource = ds_cari2.Tables("_LookupS")
        RepSupplier.ValueMember = "Kode_Supplier"
        RepSupplier.DisplayMember = "Nama_Supplier"
        Loadblthn()
    End Sub
End Class