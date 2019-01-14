Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraPrinting

Public Class frmMonRcnKrmDetail
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain

    Dim dsMon, dsNoTrans As New DataSet
    Dim daMon, daNoTrans As SqlDataAdapter

    Private Sub frmMonRcnKrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        deTglMulai.DateTime = Now
        deTglSelesai.DateTime = Now
        Me.Enabled = True
        gvMain.BestFitColumns()
    End Sub

    Private Sub LoadLUE()
        'If deTglMulai.DateTime = Nothing Or deTglSelesai.DateTime = Nothing Or (deTglMulai.DateTime = Nothing And deTglSelesai.DateTime = Nothing) Then
        'Else
        '    dsNoTrans.Clear()
        '    daNoTrans = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_trans from prod.dbo.prod_rcn_krm_m where tanggal between '" & Format(deTglMulai.DateTime, "yyyy/MM/dd") & " 00:00' and '" & Format(deTglSelesai.DateTime, "yyyy/MM/dd") & " 00:00'", sqlconn))
        '    daNoTrans.Fill(dsNoTrans, "NoTrans")
        '    lueNoTrans.Properties.DataSource = dsNoTrans.Tables("NoTrans")
        '    lueNoTrans.Properties.ValueMember = "no_trans"
        '    lueNoTrans.Properties.DisplayMember = "no_trans"
        '    If dsNoTrans.Tables("NoTrans").Rows.Count = 0 Then
        '        lueNoTrans.Properties.NullText = "[Data Tidak Ditemukan]"
        '    Else
        '        lueNoTrans.Properties.NullText = "[Pilih No. Transaksi]"
        '    End If
        'End If
    End Sub

    Private Sub LoadGrid()
        '  If Not lueNoTrans.EditValue Is Nothing Then
        'Dim strQuery As String = "select m.no_trans, m.tanggal, d.no_sp, b.kode_barang, b.nama_barang, j.nama_jenis, b.tipe_stok, u.nama_ukuran, s.nama_satuan, isnull(so.qty,0) as qty, isnull(sj.qty_kirim,0) as qty_kirim, isnull(d.jumlah,0) as jumlah " & _
        '"from prod.dbo.prod_rcn_krm_m m " & _
        '"left join prod.dbo.prod_rcn_krm_d d on d.no_trans=m.no_trans " & _
        '"left join sales.dbo.sales_so_d so on d.no_sp=so.No_sp and d.no_sp_dtl=so.no_seq " & _
        '"left join sif.dbo.sif_barang b on so.Kd_Stok=b.Kode_Barang " & _
        '"left join sif.dbo.sif_jenis_barang j on j.Kd_Jns_Brg=b.kd_jenis " & _
        '"left join sales.dbo.SALES_SJ sjm on sjm.no_dpb = d.no_dpb " & _
        '"left join sales.dbo.sales_sj_d sj on sjm.no_sj=sj.no_sj and d.no_sp=sj.No_sp and d.no_sp_dtl=sj.no_seq " & _
        '"left join sif.dbo.sif_ukuran u on u.Kode_Ukuran=b.kd_ukuran " & _
        '"left join sif.dbo.sif_satuan s on s.Kode_Satuan=b.kd_satuan " & _
        '"where m.no_trans='" & lueNoTrans.EditValue & "'"
        Dim strQuery As String = "select m.no_trans, m.tanggal as tanggal_rcn_krm, sjm.no_sj, sjm.Tgl_kirim as tanggal_kirim_sj " & _
        ", sjm.Tgl_terima as tanggal_terima_sj, g.no_trans as no_gudang_out, " & _
        "g.tgl_trans as tanggal_gudang_out ,g.sudah_sj,d.no_sp, isnull(som.Keterangan,'') as Keterangan_krm " & _
        ", so.Keterangan,c.Nama_Customer,  " & _
        "b.kode_barang, so.Deskripsi as Nama_Barang, j.nama_jenis, b.tipe_stok, u.nama_ukuran, " & _
        "s.nama_satuan, isnull(so.qty,0) as qty_order, isnull(sj.qty_kirim,0) as qty_kirim_sj, " & _
        "isnull(d.jumlah,0) as qty_rcn_kirim , isnull(gd.qty_out,0) as qty_gudang_out, " & _
        "isnull(sj.Qty_balik,0) as qty_balik_sj " & _
        "from prod.dbo.prod_rcn_krm_m m " & _
        "left join prod.dbo.prod_rcn_krm_d d on d.no_trans=m.no_trans " & _
        "left join sales.dbo.sales_so_d so on d.no_sp=so.No_sp and d.no_sp_dtl=so.no_seq  " & _
        "left join sales.dbo.SALES_SO som on som.No_sp = so.No_sp  " & _
        "left join sif.dbo.SIF_Customer c ON c.Kd_Customer = som.Kd_Customer " & _
        "left join sif.dbo.sif_barang b on so.Kd_Stok=b.Kode_Barang " & _
        "left join sif.dbo.sif_jenis_barang j on j.Kd_Jns_Brg=b.kd_jenis " & _
        "left join sales.dbo.SALES_SJ sjm on sjm.no_dpb = d.no_dpb  and sjm.no_krm = m.no_trans " & _
        "left join sales.dbo.sales_sj_d sj on sjm.no_sj=sj.no_sj and d.no_sp=sj.No_sp  " & _
        "and d.no_sp_dtl=sj.no_seq_kirim " & _
        "left join inv.dbo.INV_GUDANG_OUT g " & _
        "on g.no_ref = m.no_trans and g.no_ref = sjm.no_krm " & _
        "left join inv.dbo.inv_gudang_out_d gd " & _
        " on gd.no_trans = g.no_trans and gd.no_sp = d.no_sp and gd.no_sp_dtl = d.no_sp_dtl " & _
        "and gd.seq_dpb = d.no_seq " & _
        "left join sif.dbo.sif_ukuran u on u.Kode_Ukuran=b.kd_ukuran " & _
        "left join sif.dbo.sif_satuan s on s.Kode_Satuan=b.kd_satuan " & _
        "where m.tanggal between '" & Format(deTglMulai.DateTime, "yyyy/MM/dd") & " 00:00' and '" & Format(deTglSelesai.DateTime, "yyyy/MM/dd") & " 00:00'"
        '"where m.no_trans='" & lueNoTrans.EditValue & "' and m.kd_departemen =" & kddep &  "'"
        dsMon.Clear()
        daMon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(strQuery, sqlconn))
        daMon.Fill(dsMon, "monrcnkrm")
        gc.DataSource = dsMon.Tables("monrcnkrm")
        gvMain.BestFitColumns()
        ColNmCust.Group()
        ' End If
    End Sub

    Private Sub deTanggal_DateTimeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles deTglMulai.DateTimeChanged, deTglSelesai.DateTimeChanged
        LoadLUE()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadGrid()
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
        link.Margins.Top = 130
        link.PaperKind = System.Drawing.Printing.PaperKind.A4
        link.CreateDocument()
        link.ShowPreview()

    End Sub
    Public Sub cetak_click()
        gvMain.OptionsPrint.UsePrintStyles = True
        print_gc1(gc, "                                                                Monitoring Rencana Kirim    " & vbCrLf & _
                 "     " & vbCrLf & _
                 vbCrLf & "Tanggal:  " & Format(deTglMulai.EditValue, "dd/MM/yyyy") & "  s/d  " & Format(deTglSelesai.EditValue, "dd/MM/yyyy"))
    End Sub

End Class