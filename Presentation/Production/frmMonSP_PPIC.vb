Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Public Class frmMonSP_PPIC
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain

    Dim dsMon, dsNoTrans As New DataSet
    Dim daMon, daMon1, daMon2, daMon3, daMon4, daNoTrans As SqlClient.SqlDataAdapter
    Private Sub frmMonSP_PPIC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'connect()
        prn = getParent(Me)
        'deTglMulai.DateTime = Now
        'deTglSelesai.DateTime = Now
        Me.Enabled = True
        gvMain.BestFitColumns()
        LoadGrid()
    End Sub

    Private Sub LoadGrid()
        If Not dsMon.Relations("Produksi") Is Nothing Then dsMon.Relations.Clear()
        If Not dsMon.Relations("Kirim") Is Nothing Then dsMon.Relations.Clear()
        If Not dsMon.Tables("monprod") Is Nothing Then dsMon.Tables("monprod").Clear()
        If Not dsMon.Tables("monrcnkrm") Is Nothing Then dsMon.Tables("monrcnkrm").Clear()
        If Not dsMon.Tables("monsp") Is Nothing Then dsMon.Tables("monsp").Clear()
        Dim col1(1), col2(1), col3(2), col4(2), col5(2), col51(2), col6(2) As DataColumn

        daMon = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PRODV_MON_SO ", sqlconn))
        daMon.SelectCommand.CommandTimeout = 0
        daMon.Fill(dsMon, "monsp")

        daMon1 = New SqlDataAdapter(New SqlCommand("select m.no_trans, m.Tanggal, d.no_sp,so.Kd_Stok," & _
        "isnull(so.qty,0.00) as qty, isnull(d.jumlah,0.00) as jumlah, (ISNULL(d.jumlah_balik,0.00) + ISNULL(d.jumlah_batal,0.00) + ISNULL(d.jumlah_batal_sj,0.00)) as jumlah_balik " & _
        "from prod.dbo.prod_rcn_krm_m m " & _
        "left join prod.dbo.prod_rcn_krm_d d on d.no_trans=m.no_trans " & _
        "left join sales.dbo.sales_so_d so on d.no_sp=so.No_sp and d.no_sp_dtl=so.no_seq ", sqlconn))
        daMon1.SelectCommand.CommandTimeout = 0
        daMon1.Fill(dsMon, "monrcnkrm")


        daMon2 = New SqlDataAdapter(New SqlCommand("select d.no_rph, m.Tanggal, d.no_sp,d.no_sp_dtl,d.no_seq, so.Kd_Stok," & _
                                                   "isnull(so.qty,0.00) as qty, isnull(d.jumlah,0.00) as jumlah " & _
                                                   "from prod.dbo.prod_rcn_prod_m m " & _
                                                   "left join prod.dbo.prod_rcn_prod_d d on d.no_rph=m.no_rph " & _
                                                   "LEFT join sales.dbo.sales_so_d so on d.no_sp=so.No_sp and d.no_sp_dtl=so.no_seq ", sqlconn))
        daMon2.SelectCommand.CommandTimeout = 0
        daMon2.Fill(dsMon, "monprod")

        daMon3 = New SqlDataAdapter(New SqlCommand("SELECT jb.Nama_Jenis,b.kd_jenis, sb.No_sp,sb.no_seq_d,sb.No_seq,b.nama_barang, a.Kd_Stok," & _
                                                   "sb.panjang,0.00 as jml_blok, sb.lebar, sb.tebal, sb.Qty " & _
                                                   "from SALES.dbo.SALES_SO_D a " & _
                                                   "INNER JOIN SIF.dbo.SIF_BARANG b on a.Kd_Stok=b.Kode_Barang " & _
                                                   "INNER JOIN SIF.dbo.SIF_Jenis_Barang jb on b.kd_jenis =jb.Kd_Jns_Brg " & _
                                                   "INNER JOIN SALES.dbo.SALES_SOBOX_D sb on a.No_sp = sb.No_sp " & _
                                                   "where sb.panjang > 0.00 and sb.lebar > 0 and sb.tebal > 0", sqlconn))
        daMon3.SelectCommand.CommandTimeout = 0
        daMon3.Fill(dsMon, "monprod_detail")

        daMon4 = New SqlDataAdapter(New SqlCommand("select d.no_rph, m.Tanggal, d.no_sp, d.kd_barang,d.no_sp_dtl,d.no_seq," & _
                                                   "d.panjang, d.lebar, d.tinggi,so.Qty, isnull(d.jumlah,0) as jumlah " & _
                                                   "from prod.dbo.prod_rcn_prod_m m " & _
                                                   "left join prod.dbo.prod_rcn_prod_d d on d.no_rph=m.no_rph " & _
                                                   "INNER join sales.dbo.SALES_SOBOX_D so on d.no_sp=so.No_sp " & _
                                                   "and d.no_sp_dtl=so.no_seq_d and d.no_seq = so.No_seq " & _
                                                   "where d.panjang > 0.00 and d.lebar > 0 and d.tinggi > 0", sqlconn))
        daMon4.SelectCommand.CommandTimeout = 0
        daMon4.Fill(dsMon, "monprod_detail1")



        col1(0) = dsMon.Tables("monsp").Columns("No_sp")
        col1(1) = dsMon.Tables("monsp").Columns("Kd_Stok")

        col2(0) = dsMon.Tables("monrcnkrm").Columns("no_sp")
        col2(1) = dsMon.Tables("monrcnkrm").Columns("Kd_Stok")

        col51(0) = dsMon.Tables("monsp").Columns("No_sp")
        col51(1) = dsMon.Tables("monsp").Columns("Kd_Stok")
        col51(2) = dsMon.Tables("monsp").Columns("No_sp_box")

        col3(0) = dsMon.Tables("monprod").Columns("no_sp")
        col3(1) = dsMon.Tables("monprod").Columns("Kd_Stok")
        col3(2) = dsMon.Tables("monprod").Columns("no_seq")

        col4(0) = dsMon.Tables("monsp").Columns("No_sp")
        col4(1) = dsMon.Tables("monsp").Columns("No_seq_d")
        col4(2) = dsMon.Tables("monsp").Columns("No_sp_box")

        'col5(0) = dsMon.Tables("monprod_detail").Columns("No_sp")
        'col5(1) = dsMon.Tables("monprod_detail").Columns("no_seq_d")
        'col5(2) = dsMon.Tables("monprod_detail").Columns("No_seq")

        'col51(0) = dsMon.Tables("monprod_detail").Columns("No_sp")
        'col51(1) = dsMon.Tables("monprod_detail").Columns("no_seq_d")
        'col51(2) = dsMon.Tables("monprod_detail").Columns("No_seq")

        col5(0) = dsMon.Tables("monprod_detail1").Columns("no_sp")
        col5(1) = dsMon.Tables("monprod_detail1").Columns("no_sp_dtl")
        col5(2) = dsMon.Tables("monprod_detail1").Columns("no_seq")


        Dim rl1, rl2, rl3, rl4 As DataRelation

        rl2 = dsMon.Relations.Add("Produksi", col51, col3, False)
        rl1 = dsMon.Relations.Add("Kirim", col1, col2, False)
        rl3 = dsMon.Relations.Add("Detail Produksi Centian", col4, col5, False)

        gc.DataSource = dsMon.Tables("monsp")
        gc.LevelTree.Nodes.Add("Kirim", GV_Kirim)
        gc.LevelTree.Nodes.Add("Produksi", GV_Produksi)
        gc.LevelTree.Nodes.Add("Detail Produksi Centian", GV_DetailSOBOX)
        'gvMain.BestFitColumns()
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        LoadGrid()
        CEHijau.Checked = False
        CEMerah.Checked = False
        CEKuning.Checked = False
        gvDetail.ActiveFilterString = ""
    End Sub

    Private Sub CEKuning_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEKuning.CheckedChanged
        If CEKuning.Checked = True Then
            CEHijau.Checked = False
            CEMerah.Checked = False
            gvDetail.ActiveFilterString = "qty_rcn_krm > 0 And qty_rcn_prod = 0"
        ElseIf CEKuning.Checked = False Then
            gvDetail.ActiveFilterString = ""
        End If
    End Sub

    Private Sub CEHijau_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEHijau.CheckedChanged
        If CEHijau.Checked = True Then
            CEKuning.Checked = False
            CEMerah.Checked = False
            gvDetail.ActiveFilterString = "qty_rcn_prod > 0 And qty_rcn_krm = 0"
        ElseIf CEHijau.Checked = False Then
            gvDetail.ActiveFilterString = ""
        End If
    End Sub

    Private Sub CEMerah_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEMerah.CheckedChanged
        If CEMerah.Checked = True Then
            CEKuning.Checked = False
            CEHijau.Checked = False
            gvDetail.ActiveFilterString = "qty_rcn_prod > 0 AND qty_rcn_krm > 0 "

        ElseIf CEMerah.Checked = False Then
            gvDetail.ActiveFilterString = ""
        End If
    End Sub
End Class