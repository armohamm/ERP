Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Windows.Forms
Imports DevExpress.XtraPrintingLinks
Imports DevExpress.XtraPrinting

Public Class frmMonQC
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Dim ds, ds_cari2, ds_cari, ds_cari1, dsLookUp As New DataSet
    Dim da, DALOOKUP1, DALOOKUP, DALOOKUP2 As SqlDataAdapter
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
    Private Sub formate_yayak()
        thisThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        'GvMonQC.Columns("qty_order").SummaryItem.DisplayFormat = DevExpress.Utils.FormatType.Numeric
        'GvMonQC.Columns("qty_order").SummaryItem.DisplayFormat
        GvMonQC.Columns("qty_qc_pass").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvMonQC.Columns("qty_qc_pass").DisplayFormat.FormatString = "n3"
        GvMonQC.Columns("qty_order").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvMonQC.Columns("qty_order").DisplayFormat.FormatString = "n3"
        GvMonQC.Columns("hold").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvMonQC.Columns("hold").DisplayFormat.FormatString = "n3"
        GvMonQC.Columns("hold_history").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvMonQC.Columns("hold_history").DisplayFormat.FormatString = "n3"
        GvMonQC.Columns("qty_qc_unpass").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvMonQC.Columns("qty_qc_unpass").DisplayFormat.FormatString = "n3"
        GvMonQC.Columns("qty_sisa").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvMonQC.Columns("qty_sisa").DisplayFormat.FormatString = "n3"
    End Sub


    Private Sub frmMonQC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        ReloadTable()
        formate_yayak()

        GcMonQC.DataSource = ds.Tables("_MonQC")

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        DALOOKUP2.Fill(ds_cari2, "_lookup2")
        LookupBarang.DataSource = ds_cari2.Tables("_lookup2")
        LookupBarang.ValueMember = "Kode_Barang"
        LookupBarang.DisplayMember = "Nama_Barang"

        'DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select distinct(blthn) from INV.dbo.INV_QC", sqlconn))
        'DALOOKUP2.Fill(ds_cari2, "_lookup1")
        'LookupBlthn.Properties.DataSource = ds_cari2.Tables("_lookup1")

        Loadblthn()

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
            sqltgl = " qc.tgl_trans > convert(date,'" & tglDari.Text & "',103)"
        ElseIf tglDari.EditValue = vbNullString And tglsampai.EditValue <> vbNullString Then
            sqltgl = " qc.tgl_trans < convert(date,'" & tglsampai.Text & "',103)"
        ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString Then
            sqltgl = " qc.tgl_trans between convert(date,'" & tglDari.Text & "',103) and convert(date,'" & tglsampai.Text & "',103)"
        ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString And lookupBulanAwal.EditValue <> vbNullString Then
            sqltgl = sqltgl & "and qc.blthn='" & lookupBulanAwal.EditValue & "'"
        Else      '  LookupBlthn.EditValue <> vbNullString Then
            sqltgl = "qc.blthn='" & lookupBulanAwal.EditValue & "'"
        End If


        If Not ds.Tables("_MonQC") Is Nothing Then ds.Tables("_MonQC").Clear()
        'da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select qc.tgl_trans,qc.no_trans,qc.no_ref,qcm.sj_supplier as no_sj,qc.kd_satuan,qc.kd_stok,qc.Last_Created_By,brg.Nama_Barang,brg.spek_brg,qc.tgl_trans,qc.qty_datang,qc.qty_order,qc.qty_qc_pass,qc.qty_qc_unpass,ISNULL(qc.hold,0) as hold,ISNULL(qc.hold_histroy,0) as hold_histroy,qc.qty_sisa,qc.rp_trans,qcm.jml_rp_trans, 0 as nomer from INV.dbo.INV_QC as qc LEFT JOIN INV.dbo.INV_QC_M as qcm on qc.no_trans=qcm.no_trans LEFT JOIN SIF.dbo.SIF_Barang as brg on qc.kd_stok= brg.Kode_Barang where " & sqltgl & "", sqlconn))
        'Dim sql As String = "SELECT     qc.tgl_trans, qc.no_trans, qc.no_ref, qcm.sj_supplier AS no_sj, qc.kd_satuan, qc.kd_stok, qc.Last_Created_By, brg.Nama_Barang, brg.spek_brg,  " & _
        '               " qc.qty_datang, qc.qty_order, qc.qty_qc_pass, qc.qty_qc_unpass, ISNULL(qc.hold, 0) AS hold, ISNULL(qc.hold_histroy, 0) AS hold_histroy, qc.qty_sisa, qc.rp_trans, " & _
        '               " qcm.jml_rp_trans, 0 AS nomer, qc.keterangan, SIF.dbo.SIF_Supplier.Nama_Supplier " & _
        '              " FROM         SIF.dbo.SIF_Supplier RIGHT OUTER JOIN " & _
        '              " inv.dbo.INV_QC_M AS qcm ON SIF.dbo.SIF_Supplier.Kode_Supplier = qcm.kd_supplier RIGHT OUTER JOIN " & _
        '              " inv.dbo.INV_QC AS qc ON qcm.no_trans = qc.no_trans LEFT OUTER JOIN " & _
        '              " SIF.dbo.SIF_Barang AS brg ON qc.kd_stok = brg.Kode_Barang "
        Dim sql As String = "select qc.tgl_trans, qc.no_trans, qc.no_ref, qcm.sj_supplier AS no_sj, " & _
                            "qc.kd_satuan, qc.kd_stok, upper(qc.Last_Created_By) as Last_Created_By, brg.Nama_Barang, brg.spek_brg, " & _
                            "qc.qty_datang, qc.qty_order, qc.qty_qc_pass, qc.qty_qc_unpass, ISNULL(qc.hold, 0) AS hold, " & _
                            "ISNULL(qc.hold_histroy, 0) AS hold_histroy, qc.qty_sisa, qc.rp_trans, " & _
                            "qcm.jml_rp_trans, 0 AS nomer, qc.keterangan, supp.Nama_Customer Nama_Supplier, jbm.nama_jenis " & _
                              "from inv.dbo.INV_QC_M AS qcm " & _
                            "INNER JOIN inv.dbo.INV_QC AS qc " & _
                                "ON qcm.no_trans = qc.no_trans " & _
                            "LEFT OUTER JOIN SIF.dbo.SIF_Barang AS brg " & _
                                "ON qc.kd_stok = brg.Kode_Barang " & _
                            "LEFT OUTER JOIN (select a.Kd_Customer, a.Nama_Customer from sif.dbo.sif_customer a union " & _
                            "select b.Kode_Supplier, b.Nama_Supplier from sif.dbo.SIF_Supplier b) AS supp " & _
                                "ON supp.Kd_Customer = qcm.kd_supplier " & _
                            "LEFT OUTER join INV.dbo.JENIS_BRG_MASUK jbm " & _
                                "ON jbm.kode = SUBSTRING(qcm.no_trans,12,2) "
        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(sql & " where " & sqltgl, sqlconn))
        da.Fill(ds, "_MonQC")
        GvMonQC.BestFitColumns()
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
        For Each row As DataRow In ds.Tables("_MonQC").Rows
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
        GcMonQC.Refresh()
        'GcMonQC.OptionsPrint.UsePrintStyles = True
        print_gc1(GcMonQC, "                                                                MONITORING INSPEKSI BARANG MASUK    " & vbCrLf & _
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
End Class