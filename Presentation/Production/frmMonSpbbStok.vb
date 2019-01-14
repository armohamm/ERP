Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class frmMonSpbbStok
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain

    Dim dsMon, dsNoRPH As New DataSet
    Dim daMon, daNoRPH As SqlDataAdapter

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
            dsNoRPH.Clear()
            daNoRPH = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_rph from prod.dbo.prod_rcn_prod_m where tanggal between '" & Format(deTglMulai.DateTime, "yyyy/MM/dd") & " 00:00' and '" & Format(deTglSelesai.DateTime, "yyyy/MM/dd") & " 00:00'", sqlconn))
            daNoRPH.Fill(dsNoRPH, "NoRPH")
            lueNoRPH.Properties.DataSource = dsNoRPH.Tables("NoRPH")
            lueNoRPH.Properties.ValueMember = "no_rph"
            lueNoRPH.Properties.DisplayMember = "no_rph"
            If dsNoRPH.Tables("NoRPH").Rows.Count = 0 Then
                lueNoRPH.Properties.NullText = "[Data Tidak Ditemukan]"
            Else
                lueNoRPH.Properties.NullText = "[Pilih No. RPH]"
            End If
        End If
    End Sub

    Private Sub LoadGrid()
        If Not lueNoRPH.EditValue Is Nothing Then
            '            Dim strQuery As String = "select m.no_rph, m.tanggal, d.no_sp, b.kode_barang, b.nama_barang, j.nama_jenis, b.tipe_stok, u.nama_ukuran, s.nama_satuan, isnull(so.qty,0) as qty, isnull(d.jumlah,0) as jumlah " & _
            '"from prod.dbo.prod_rcn_prod_m m " & _
            '"left join prod.dbo.prod_rcn_prod_d d on d.no_rph=m.no_rph " & _
            '"left join sales.dbo.sales_so_d so on d.no_sp=so.No_sp and d.no_sp_dtl=so.no_seq " & _
            '"left join sif.dbo.sif_barang b on so.Kd_Stok=b.Kode_Barang " & _
            '"left join sif.dbo.sif_jenis_barang j on j.Kd_Jns_Brg=b.kd_jenis " & _
            '"left join sif.dbo.sif_ukuran u on u.Kode_Ukuran=b.kd_ukuran " & _
            '"left join sif.dbo.sif_satuan s on s.Kode_Satuan=b.kd_satuan " & _
            Dim strQuery As String = "Select d.no_rph,d.no_sppb,m.tanggal, d.kd_barang, br.Nama_Barang, " & _
            "sum(d.jumlah) jumlah, kd.qty_available, kd.Nama_Satuan " & _
            "From  PROD.dbo.PROD_sppb_d d " & _
            "inner join PROD.dbo.PROD_sppb_m m " & _
            "on m.no_rph = d.no_rph and m.no_sppb = d.no_sppb and m.kd_kegiatan = d.kd_kegiatan " & _
            "left join SIF.dbo.SIF_Barang br on br.Kode_Barang = d.kd_barang " & _
            "left join (select B.Kode_Barang,B.Nama_Barang,S.Kode_Satuan,S.Nama_Satuan , L.nilai_rata, L.bultah, L.qty_available " & _
            "from SIF.dbo.SIF_Barang B left join SIF.dbo.SIF_Satuan S on B.Kd_Satuan=S.Kode_Satuan " & _
            "LEFT JOIN INV.dbo.INV_STOK_SALDO L ON B.Kode_Barang = L.kd_stok " & _
            "where  L.bultah = (select MAX(SL.bultah)  from INV.dbo.INV_STOK_SALDO SL where SL.kd_stok = B.Kode_Barang)) as kd " & _
            "ON kd.Kode_Barang = d.kd_barang where d.no_rph = '" & lueNoRPH.EditValue & "'" & _
            "GROUP BY d.no_rph,d.no_sppb, d.kd_barang, br.Nama_Barang, m.tanggal,kd.qty_available, kd.Nama_Satuan"
            dsMon.Clear()
            daMon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(strQuery, sqlconn))
            daMon.Fill(dsMon, "monprod")
            gc.DataSource = dsMon.Tables("monprod")
            gvMain.BestFitColumns()
        End If
    End Sub

    Private Sub deTanggal_DateTimeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles deTglMulai.DateTimeChanged, deTglSelesai.DateTimeChanged
        LoadLUE()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadGrid()
    End Sub

    Private Sub deTglSelesai_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTglSelesai.EditValueChanged
        LoadLUE()
    End Sub

    Private Sub deTglMulai_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTglMulai.EditValueChanged
        LoadLUE()
    End Sub

  
End Class