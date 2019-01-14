Imports System.Data.SqlClient
Imports System.Drawing
Imports DevExpress.XtraPrinting

Public Class frmMonPONonMaterialDetil
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False

    Public STATE As String
    'Public prn As frmMain '<-- untuk mengakses frmMain
    Public milih As String
    Public dtable As DataTable
    Private rw As DataRow
    Dim dSO, ds1, ds2, ds_cari, ds As New DataSet
    Dim DA, DA2, DA3, da_cari, DALOOKUP As SqlClient.SqlDataAdapter
    Dim dapodm As SqlClient.SqlDataAdapter

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = False
        btnEdit = False
        btnadd = False
        'setStatus()
        STATE = "ADD" '<-- set state add

    End Sub
    Sub Load_PO_Filter()
        dSO.Relations.Clear()
        If Not dSO.Tables("_DpmApprv_d") Is Nothing Then dSO.Tables("_DpmApprv_d").Clear()
        If Not dSO.Tables("_DpmApprv") Is Nothing Then dSO.Tables("_DpmApprv").Clear()


        Dim sql As String
        Dim sql1 As String
        'Dim kolom As String = ""
        If tglDari.Text = "" Then
            If tglsampai.Text <> "" Then
                sql = " AND convert(varchar, tgl_po, 103) < " & tglsampai.EditValue
            End If
        Else

            If tglsampai.Text <> "" Then
                sql = " WHERE tgl_po  between '" & Format(tglDari.EditValue, "yyyy/MM/dd") & "' and '" & Format(tglsampai.EditValue, "yyyy/MM/dd") & "' "
                '                sql1 = "group by  c.keterangan,c.tipe_trans, c.no_ref1, c.tgl_inv, c.kd_supplier, " & _
                '"x.Nama_Supplier, c.kd_valuta, b.kd_stok, a.Nama_Barang, s.Kode_Satuan, " & _
                '"b.qty, b.harga,c.jml_val_trans,qc.qty_qc_pass,qc.tgl_trans,z.tgl_kirim "
            Else
                sql = " WHERE convert(varchar, tgl_inv, 103)  > " & tglDari.EditValue
                '                sql1 = "group by  c.keterangan,c.tipe_trans, c.no_ref1, c.tgl_inv, c.kd_supplier, " & _
                '"x.Nama_Supplier, c.kd_valuta, b.kd_stok, a.Nama_Barang, s.Kode_Satuan, " & _
                '"b.qty, b.harga,c.jml_val_trans,qc.qty_qc_pass,qc.tgl_trans,z.tgl_kirim "
            End If
        End If
        '        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT  z.tgl_kirim as tgl_janji_kirim,c.keterangan,c.tipe_trans, c.no_ref1 no_po, c.tgl_inv  tgl_po, c.kd_supplier, " & _
        '"x.Nama_Supplier, c.kd_valuta, b.kd_stok  kd_stok, a.Nama_Barang  nama_brg, s.Kode_Satuan, " & _
        '"b.qty, b.harga,c.jml_val_trans total, '' as nstatus,sum(isnull(qc.qty_qc_pass,0)) as qty_in,qc.tgl_trans as tgl_dtg " & _
        '"FROM Fin.dbo.fin_pembelian c left join Fin.dbo.FIN_PEMBELIAN_D b on c.no_inv=b.no_inv and " & _
        '"c.tipe_trans=b.tipe_trans left join SIF.dbo.SIF_Satuan s on s.Kode_Satuan=b.satuan " & _
        '"left join SIF.dbo.SIF_Barang a on a.Kode_Barang=b.kd_stok " & _
        '"left join sif.dbo.SIF_Supplier x on x.Kode_Supplier=c.kd_supplier " & _
        '"left join PURC.dbo.PURC_PO w on c.no_ref1=w.no_po and c.kd_supplier=w.kd_supplier " & _
        '"INNER JOIN PURC.dbo.PURC_PO_D z ON (w.no_po = z.no_po) " & _
        '"INNER join INV.dbo.INV_QC qc on c.no_ref1=qc.no_ref " & _
        '"where c.tipe_trans='JPP-KUT-05' or c.tipe_trans='JPP-KUT-02' " & sql & sql1, sqlconn))
        DA = New SqlDataAdapter(New SqlCommand("Select * from [PURC].[dbo].[viewpojasa] " & sql, sqlconn))
        DA.Fill(dSO, "_DpmApprv")
        GcPO_Det.DataSource = dSO.Tables("_DpmApprv")

        dapodm = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_PO_D_BARANG where no_po in (Select no_po from [PURC].[dbo].[viewpojasa]) ", sqlconn))
        dapodm.Fill(dSO, "PODM")

        Dim colM(1) As DataColumn
        Dim colD(1) As DataColumn
        Dim rel As DataRelation

        colM(0) = dSO.Tables("_DpmApprv").Columns("kd_jasa")
        colM(1) = dSO.Tables("_DpmApprv").Columns("no_po")

        colD(0) = dSO.Tables("PODM").Columns("kd_jasa")
        colD(1) = dSO.Tables("PODM").Columns("no_po")

        rel = dSO.Relations.Add("Detail", colM, colD, False)
        GcPO_Det.LevelTree.Nodes.Add("Detail", GridView1)

        'connect()
        'DA = New SqlDataAdapter(New SqlCommand("SELECT *,'' as nstatus from PURC.dbo.PURC_PO" & sql, sqlconn))
        'DA.Fill(dSO, "_DpmApprv")
        'GcPO_Det.DataSource = dSO.Tables("_DpmApprv")

        ' ''=== >>> RELATION di OFFkan dulu
        'DA2 = New SqlDataAdapter(New SqlCommand("select no_trans, tgl_trans, no_ref, kd_stok, kd_satuan, sum(qty) qty from FIN.dbo.viewNonMaterial group by  no_trans,tgl_trans,no_ref, kd_stok, kd_satuan", sqlconn))
        'DA2.Fill(dSO, "_DpmApprv_d")

        ''DA3 = New SqlDataAdapter(New SqlCommand("SELECT * from INV.dbo.INV_GUDANG_IN where no_po in (select no_po from PURC.dbo.PURC_PO)", sqlconn))
        ''DA3.Fill(dSO, "_DpmApprv_dpr")
        'Dim rl, r2 As DataRelation
        'Dim dcolP(1) As DataColumn
        'Dim dcolC(1) As DataColumn

        'dcolP(1) = dSO.Tables("_DpmApprv").Columns("kd_stok")
        'dcolP(0) = dSO.Tables("_DpmApprv").Columns("no_po")

        'dcolC(1) = dSO.Tables("_DpmApprv_d").Columns("kd_stok")
        'dcolC(0) = dSO.Tables("_DpmApprv_d").Columns("no_po")

        'rl = dSO.Relations.Add("Detail", dcolP, dcolC, True)

        'rl.Nested = True
        'GcPO_Det.LevelTree.Nodes.Add("Detail", GridView1)

        'rl = dSO.Relations.Add("Detail", dSO.Tables("_DpmApprv").Columns("no_po"), dSO.Tables("_DpmApprv_d").Columns("no_ref"), False)
        'r2 = dSO.Relations.Add("Detail2", dSO.Tables("_DpmApprv").Columns("kd_stok"), dSO.Tables("_DpmApprv_d").Columns("kd_stok"), False)

        'GcPO_Det.DataSource = dSO.Tables("_DpmApprv")
        'GcPO_Det.LevelTree.Nodes.Add("Detail", GridView1) '.Nodes.Add("Detail_", GridView2)
        'GcPO_Det.LevelTree.Nodes.Add("Detail2", GridView1)

        'DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kd_Departemen,Nama_Departemen from SIF.dbo.SIF_Departemen", sqlconn))
        'DALOOKUP.Fill(ds_cari, "_lookup")
        'lookupDivisi.DataSource = ds_cari.Tables("_lookup")
        'lookupDivisi.ValueMember = "Kd_Departemen"
        'lookupDivisi.DisplayMember = "Nama_Departemen"

        'DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        'DALOOKUP.Fill(ds_cari, "_lookup1")
        'Lokupbarang.DataSource = ds_cari.Tables("_lookup1")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Supplier, Nama_Supplier from SIF.dbo.SIF_Supplier", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup2")
        lookupsupplier.DataSource = ds_cari.Tables("_lookup2")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select tipe_trans, accronim_desc from SIF.dbo.SIF_TIPE_TRANS", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup3")
        Lookuptipe.DataSource = ds_cari.Tables("_lookup3")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Gudang, Nama_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup4")
        lookupGudang.DataSource = ds_cari.Tables("_lookup4")

        For Each rw As DataRow In dSO.Tables("_DpmApprv").Rows
            rw("nstatus") = cek_status_PO(rw("no_po"))
        Next


    End Sub
    Private Sub frmMonPONonMaterialDetil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        tglDari.EditValue = Now.Date
        tglsampai.EditValue = Now.Date
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang, Nama_Barang  from sif.dbo.SIF_Barang where rec_stat = 'Y'", sqlconn))
        DA2.Fill(ds, "VBarang")
        Lokupbarang.DataSource = ds.Tables("VBARANG")
    End Sub


    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        Load_PO_Filter()
    End Sub

    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        GcPO_Det.Refresh()
        GcPO_Det.ShowPrintPreview()
    End Sub

    Public Sub cetak_click()
        If Not GVApprvDPM.RowCount <= 0 Then
            'ShowGridPreview(gcGiro)
            Dim ph As DevExpress.XtraPrinting.PageHeaderFooter = CType(PrintableComponentLink1.PageHeaderFooter, PageHeaderFooter)
            ph.Footer.Content.Add(username)
            ph.Footer.Content.Add("")
            ph.Footer.Content.Add("Hal. [Page #]")

            PrintableComponentLink1.CreateDocument()
            PrintableComponentLink1.ShowPreview()
        Else
            MsgBox("Tidak ada data yang dicetak. Silahkan mengisi filter tanggal lalu menekan tombol Refresh.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
        End If
    End Sub

    Private Sub GVApprvDPM_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVApprvDPM.DoubleClick
        milih = GVApprvDPM.GetFocusedRowCellValue("no_po").ToString()

        da_cari = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_PO where no_po='" & milih & "'", sqlconn))
        da_cari.Fill(ds1, "_crpo")

        'frmPO.cariPO(milih)
        'frmPO.ShowDialog()
    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "MONITORING PURCHASE ORDER DETIL"
        Dim reportHeader2 As String = ":"
        Dim reportHeader3 As String = "PT. Dynasti Indomegah"
        Dim reportHeader4 As String = "Tanggal Cetak"
        Dim reportHeader5 As String = getTanggal.ToLongDateString
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        e.Graph.BackColor = Color.White
        'MsgBox(e.Graph.ClientPageSize.Width / 2.ToString)
        'MsgBox(e.Graph.MeasureString(reportHeader, e.Graph.ClientPageSize.Width).Width)
        Dim rec As RectangleF = New RectangleF(404, 0, e.Graph.MeasureString(reportHeader, e.Graph.ClientPageSize.Width).Width, 20)
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

    Private Sub GcPO_Det_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GcPO_Det.Click

    End Sub


End Class