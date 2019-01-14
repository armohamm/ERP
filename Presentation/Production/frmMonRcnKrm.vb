Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class frmMonRcnKrm
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
        If deTglMulai.DateTime = Nothing Or deTglSelesai.DateTime = Nothing Or (deTglMulai.DateTime = Nothing And deTglSelesai.DateTime = Nothing) Then
        Else
            dsNoTrans.Clear()
            daNoTrans = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_trans from prod.dbo.prod_rcn_krm_m where tanggal between '" & Format(deTglMulai.DateTime, "yyyy/MM/dd") & " 00:00' and '" & Format(deTglSelesai.DateTime, "yyyy/MM/dd") & " 00:00'", sqlconn))
            daNoTrans.Fill(dsNoTrans, "NoTrans")
            lueNoTrans.Properties.DataSource = dsNoTrans.Tables("NoTrans")
            lueNoTrans.Properties.ValueMember = "no_trans"
            lueNoTrans.Properties.DisplayMember = "no_trans"
            If dsNoTrans.Tables("NoTrans").Rows.Count = 0 Then
                lueNoTrans.Properties.NullText = "[Data Tidak Ditemukan]"
            Else
                lueNoTrans.Properties.NullText = "[Pilih No. Transaksi]"
            End If
        End If
    End Sub

    Private Sub LoadGrid()
        If Not lueNoTrans.EditValue Is Nothing Then
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
            Dim strQuery As String = "select m.no_trans, m.tanggal, d.no_sp,c.Nama_Customer, b.kode_barang, b.nama_barang, j.nama_jenis, " & _
            "b.tipe_stok, u.nama_ukuran, s.nama_satuan, isnull(so.qty,0) as qty, " & _
            "isnull(sj.qty_kirim,0) as qty_kirim, isnull(d.jumlah,0) as jumlah " & _
            "from prod.dbo.prod_rcn_krm_m m " & _
            "left join prod.dbo.prod_rcn_krm_d d on d.no_trans=m.no_trans  " & _
            "left join sales.dbo.sales_so_d so on d.no_sp=so.No_sp and d.no_sp_dtl=so.no_seq " & _
            "left join sales.dbo.SALES_SO som on som.No_sp = so.No_sp " & _
            "left join sif.dbo.SIF_Customer c ON c.Kd_Customer = som.Kd_Customer " & _
            "left join sif.dbo.sif_barang b on so.Kd_Stok=b.Kode_Barang " & _
            "left join sif.dbo.sif_jenis_barang j on j.Kd_Jns_Brg=b.kd_jenis " & _
            "left join sales.dbo.SALES_SJ sjm on sjm.no_dpb = d.no_dpb " & _
            "left join sales.dbo.sales_sj_d sj on sjm.no_sj=sj.no_sj and d.no_sp=sj.No_sp  " & _
            "and d.no_sp_dtl=sj.no_seq left join sif.dbo.sif_ukuran u on u.Kode_Ukuran=b.kd_ukuran " & _
            "left join sif.dbo.sif_satuan s on s.Kode_Satuan=b.kd_satuan " & _
            "where m.no_trans='" & lueNoTrans.EditValue & "'"
            dsMon.Clear()
            daMon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(strQuery, sqlconn))
            daMon.Fill(dsMon, "monrcnkrm")
            gc.DataSource = dsMon.Tables("monrcnkrm")
            gvMain.BestFitColumns()
        End If
    End Sub

    Private Sub deTanggal_DateTimeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles deTglMulai.DateTimeChanged, deTglSelesai.DateTimeChanged
        LoadLUE()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadGrid()
    End Sub

End Class