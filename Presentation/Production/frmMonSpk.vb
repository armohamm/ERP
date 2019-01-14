Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Imports DevExpress.XtraGrid


Public Class frmMonSpk
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim awal As String
    Dim colD1(1) As DataColumn
    Dim colD2(1) As DataColumn
    Dim colDR1(4), colDR2(4) As DataColumn
    Dim colDC1(2), colDC2(2) As DataColumn
    Dim rl As DataRelation
    Dim r2, r3 As DataRelation
    Dim dsMon, dsNoTrans, dsrls As New DataSet
    Dim daMon, daNoTrans, dadet, darls, darls1, darls2 As SqlDataAdapter

    Private Sub frmMonSpk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        deTglMulai.DateTime = Now
        deTglSelesai.DateTime = Now
        Me.Enabled = True
        gvMain.BestFitColumns()
        awal = "awal"
    End Sub


    Sub LoadGrid()
        dsMon.Relations.Clear()
        If Not dsMon.Tables("monspk") Is Nothing Then dsMon.Tables("monspk").Clear()
        If Not dsMon.Tables("mondspk") Is Nothing Then dsMon.Tables("mondspk").Clear()
        Dim strQuery As String = "SELECT distinct PROD.dbo.PROD_spk_d.no_rph, PROD.dbo.PROD_spk_d.no_spk " & _
                  "FROM PROD.dbo.PROD_spk_d INNER JOIN " & _
                 "PROD.dbo.PROD_spk_m ON PROD.dbo.PROD_spk_d.no_rph = PROD.dbo.PROD_spk_m.no_rph AND PROD.dbo.PROD_spk_d.no_spk = PROD.dbo.PROD_spk_m.no_spk AND " & _
                 "PROD.dbo.PROD_spk_d.kd_kegiatan = PROD.dbo.PROD_spk_m.kd_kegiatan AND PROD.dbo.PROD_spk_d.kd_kegiatan_spk = PROD.dbo.PROD_spk_m.kd_kegiatan_spk and PROD.dbo.PROD_spk_m.tanggal between '" & Format(deTglMulai.DateTime, "yyyy/MM/dd") & " 00:00' and '" & Format(deTglSelesai.DateTime, "yyyy/MM/dd") & " 00:00' "



        daMon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(strQuery, sqlconn))
        daMon.Fill(dsMon, "monspk")
        gc.DataSource = dsMon.Tables("monspk")
        gvMain.BestFitColumns()

        Dim strQuery1 As String = "SELECT Distinct  PROD.dbo.PROD_spk_d.no_rph,PROD.dbo.PROD_spk_d.kd_kegiatan, " & _
        "PROD.dbo.PROD_spk_d.kd_kegiatan_spk, PROD.dbo.PROD_spk_d.no_spk, " & _
        "SIF.dbo.SIF_Gen_Reff_D.Desc_Data as JadwalKerja, PROD.dbo.PROD_rcn_prod_m.tanggal, " & _
        "PROD.dbo.PROD_spk_m.kapasitas, " & _
        "SIF_Gen_Reff_D_1.Desc_Data AS areakegiatan, SIF_Gen_Reff_D_2.Desc_Data AS Kegiatan, " & _
        "isnull(PROD.dbo.PROD_spk_m.jumlah,a.jumlah_produksi) as jumlah_produksi ,isnull(a.jumlah_relaisasi,0) as jumlah_relaisasi, " & _
        "'' Status FROM PROD.dbo.PROD_spk_d INNER JOIN  " & _
        "PROD.dbo.PROD_spk_m ON PROD.dbo.PROD_spk_d.no_rph = PROD.dbo.PROD_spk_m.no_rph " & _
        "AND PROD.dbo.PROD_spk_d.no_spk = PROD.dbo.PROD_spk_m.no_spk AND " & _
        "PROD.dbo.PROD_spk_d.kd_kegiatan = PROD.dbo.PROD_spk_m.kd_kegiatan " & _
        "AND PROD.dbo.PROD_spk_d.kd_kegiatan_spk = PROD.dbo.PROD_spk_m.kd_kegiatan_spk INNER JOIN " & _
        "PROD.dbo.PROD_rcn_prod_m ON PROD.dbo.PROD_spk_m.no_rph = PROD.dbo.PROD_rcn_prod_m.no_rph " & _
        "INNER JOIN SIF.dbo.SIF_Gen_Reff_D  " & _
        "ON PROD.dbo.PROD_rcn_prod_m.kd_jadwal = SIF.dbo.SIF_Gen_Reff_D.Id_Data " & _
        "AND SIF.dbo.SIF_Gen_Reff_D.Ref_Role = 'PROD' AND  " & _
        "SIF.dbo.SIF_Gen_Reff_D.Id_Ref_File = 'JDWKRJ' INNER JOIN  " & _
        "SIF.dbo.SIF_Gen_Reff_D AS SIF_Gen_Reff_D_1 " & _
        "ON PROD.dbo.PROD_spk_m.kd_kegiatan = SIF_Gen_Reff_D_1.Id_Data " & _
        "AND SIF_Gen_Reff_D_1.Ref_Role = 'PROD' AND " & _
        "SIF_Gen_Reff_D_1.Id_Ref_File = 'KGTSPK' " & _
        "INNER Join SIF.dbo.SIF_Gen_Reff_D AS SIF_Gen_Reff_D_2 " & _
        "ON PROD.dbo.PROD_spk_m.kd_kegiatan_spk = SIF_Gen_Reff_D_2.Id_Data " & _
        "AND SIF_Gen_Reff_D_2.Ref_Role = 'PROD' AND " & _
        "SIF_Gen_Reff_D_2.Id_Ref_File = 'SPK'  " & _
        "left join (Select rd.no_spk_man,rd.kd_kegiatan,rd.kd_kegiatan_spk,sum(rd.jumlah_realisasi) as jumlah_produksi " & _
        ", sum(rd.jumlah_kerja) as jumlah_relaisasi " & _
        "from PROD.dbo.PROD_rls_spk_man_d rd " & _
        "Group by rd.no_spk_man,rd.kd_kegiatan,rd.kd_kegiatan_spk) a " & _
        "on a.no_spk_man = PROD.dbo.PROD_spk_d.no_spk and a.kd_kegiatan = PROD.dbo.PROD_spk_d.kd_kegiatan " & _
        "and a.kd_kegiatan_spk = PROD.dbo.PROD_spk_d.kd_kegiatan_spk " & _
        "where PROD.dbo.PROD_rcn_prod_m.tanggal between '" & Format(deTglMulai.DateTime, "yyyy/MM/dd") & " 00:00' and '" & Format(deTglSelesai.DateTime, "yyyy/MM/dd") & " 00:00' "




        dadet = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(strQuery1, sqlconn))
        dadet.Fill(dsMon, "mondspk")

        colD1(0) = dsMon.Tables("monspk").Columns("no_rph")
        colD1(1) = dsMon.Tables("monspk").Columns("no_spk")

        colD2(0) = dsMon.Tables("mondspk").Columns("no_rph")
        colD2(1) = dsMon.Tables("mondspk").Columns("no_spk")

        rl = dsMon.Relations.Add("Detail", colD1, colD2, False)
        gc.DataSource = dsMon.Tables("monspk")
        gc.LevelTree.Nodes.Add("Detail", GridView1)
        gvMain.BestFitColumns()
        awal = "a"
    End Sub
    Sub LoadOpen()
        If awal = "a" Then
            dsMon.Relations.Clear()
            If Not dsMon.Tables("monspk") Is Nothing Then dsMon.Tables("monspk").Clear()
            If Not dsMon.Tables("mondspk") Is Nothing Then dsMon.Tables("mondspk").Clear()
            Dim strQuery As String = "SELECT distinct PROD.dbo.PROD_spk_d.no_rph, PROD.dbo.PROD_spk_d.no_spk " & _
                      "FROM PROD.dbo.PROD_spk_d INNER JOIN " & _
                     "PROD.dbo.PROD_spk_m ON PROD.dbo.PROD_spk_d.no_rph = PROD.dbo.PROD_spk_m.no_rph AND PROD.dbo.PROD_spk_d.no_spk = PROD.dbo.PROD_spk_m.no_spk AND " & _
                     "PROD.dbo.PROD_spk_d.kd_kegiatan = PROD.dbo.PROD_spk_m.kd_kegiatan AND PROD.dbo.PROD_spk_d.kd_kegiatan_spk = PROD.dbo.PROD_spk_m.kd_kegiatan_spk and PROD.dbo.PROD_spk_m.tanggal between '" & Format(deTglMulai.DateTime, "yyyy/MM/dd") & " 00:00' and '" & Format(deTglSelesai.DateTime, "yyyy/MM/dd") & " 00:00' "



            daMon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(strQuery, sqlconn))
            daMon.Fill(dsMon, "monspk")
            gc.DataSource = dsMon.Tables("monspk")
            gvMain.BestFitColumns()

            'Dim strQuery1 As String = "SELECT PROD.dbo.PROD_spk_d.no_rph,PROD.dbo.PROD_spk_d.kd_kegiatan," & _
            '                      "PROD.dbo.PROD_spk_d.kd_kegiatan_spk, PROD.dbo.PROD_spk_d.no_spk, " & _
            '                      "SIF.dbo.SIF_Gen_Reff_D.Desc_Data as JadwalKerja, PROD.dbo.PROD_rcn_prod_m.tanggal, " & _
            '                      "PROD.dbo.PROD_spk_m.kapasitas, " & _
            '                      "SIF_Gen_Reff_D_1.Desc_Data AS areakegiatan, SIF_Gen_Reff_D_2.Desc_Data AS Kegiatan, " & _
            '                      "a.jumlah_produksi, isnull(a.jumlah_relaisasi,0) as jumlah_relaisasi,'' Status " & _
            '                      "FROM PROD.dbo.PROD_spk_d INNER JOIN " & _
            '                      "PROD.dbo.PROD_spk_m ON PROD.dbo.PROD_spk_d.no_rph = PROD.dbo.PROD_spk_m.no_rph " & _
            '                      "AND PROD.dbo.PROD_spk_d.no_spk = PROD.dbo.PROD_spk_m.no_spk AND " & _
            '                      "PROD.dbo.PROD_spk_d.kd_kegiatan = PROD.dbo.PROD_spk_m.kd_kegiatan " & _
            '                      "AND PROD.dbo.PROD_spk_d.kd_kegiatan_spk = PROD.dbo.PROD_spk_m.kd_kegiatan_spk INNER JOIN " & _
            '                      "PROD.dbo.PROD_rcn_prod_m ON PROD.dbo.PROD_spk_m.no_rph = PROD.dbo.PROD_rcn_prod_m.no_rph " & _
            '                      "INNER JOIN SIF.dbo.SIF_Gen_Reff_D " & _
            '                      "ON PROD.dbo.PROD_rcn_prod_m.kd_jadwal = SIF.dbo.SIF_Gen_Reff_D.Id_Data " & _
            '                      "AND SIF.dbo.SIF_Gen_Reff_D.Ref_Role = 'PROD' AND " & _
            '                      "SIF.dbo.SIF_Gen_Reff_D.Id_Ref_File = 'JDWKRJ' INNER JOIN " & _
            '                      "SIF.dbo.SIF_Gen_Reff_D AS SIF_Gen_Reff_D_1 " & _
            '                      "ON PROD.dbo.PROD_spk_m.kd_kegiatan = SIF_Gen_Reff_D_1.Id_Data " & _
            '                      "AND SIF_Gen_Reff_D_1.Ref_Role = 'PROD' AND " & _
            '                      "SIF_Gen_Reff_D_1.Id_Ref_File = 'KGTSPK' " & _
            '                      "INNER Join SIF.dbo.SIF_Gen_Reff_D AS SIF_Gen_Reff_D_2 " & _
            '                      "ON PROD.dbo.PROD_spk_m.kd_kegiatan_spk = SIF_Gen_Reff_D_2.Id_Data " & _
            '                      "AND SIF_Gen_Reff_D_2.Ref_Role = 'PROD' AND " & _
            '                      "SIF_Gen_Reff_D_2.Id_Ref_File = 'SPK'  " & _
            '                      "inner join(Select DISTINCT d.no_spk,d.kd_kegiatan,d.kd_kegiatan_spk,br.Nama_Barang,d.jumlah_produksi " & _
            '                      ", sum(rd.jumlah_kerja) as jumlah_relaisasi " & _
            '                      "from PROD.dbo.PROD_spk_d d " & _
            '                      "left JOIN PROD.dbo.PROD_rls_spk_man_d rd " & _
            '                      "on rd.no_spk_man = d.no_spk and rd.kd_kegiatan=d.kd_kegiatan " & _
            '                      "and rd.kd_kegiatan_spk=d.kd_kegiatan_spk and rd.kd_barang = d.kd_barang " & _
            '                      "left join SIF.dbo.SIF_Barang br " & _
            '                      "on br.Kode_Barang = d.kd_barang " & _
            '                      "Group by d.no_spk,d.kd_kegiatan,d.kd_kegiatan_spk, " & _
            '                      "d.kd_barang,d.no_urut_brg ,br.Nama_Barang,d.jumlah_produksi) a " & _
            '                      "on a.no_spk = PROD.dbo.PROD_spk_d.no_spk and a.kd_kegiatan = PROD.dbo.PROD_spk_d.kd_kegiatan " & _
            '                      "and a.kd_kegiatan_spk = PROD.dbo.PROD_spk_d.kd_kegiatan_spk " & _
            '                      "where PROD.dbo.PROD_rcn_prod_m.tanggal between '" & Format(deTglMulai.DateTime, "yyyy/MM/dd") & " 00:00' and '" & Format(deTglSelesai.DateTime, "yyyy/MM/dd") & " 00:00' and PROD.dbo.PROD_rcn_prod_m.rec_stat <>'R' "

            Dim strQuery1 As String = "SELECT Distinct  PROD.dbo.PROD_spk_d.no_rph,PROD.dbo.PROD_spk_d.kd_kegiatan, " & _
           "PROD.dbo.PROD_spk_d.kd_kegiatan_spk, PROD.dbo.PROD_spk_d.no_spk, " & _
           "SIF.dbo.SIF_Gen_Reff_D.Desc_Data as JadwalKerja, PROD.dbo.PROD_rcn_prod_m.tanggal, " & _
           "PROD.dbo.PROD_spk_m.kapasitas, " & _
           "SIF_Gen_Reff_D_1.Desc_Data AS areakegiatan, SIF_Gen_Reff_D_2.Desc_Data AS Kegiatan, " & _
           "isnull(PROD.dbo.PROD_spk_m.jumlah,a.jumlah_produksi) as jumlah_produksi ,isnull(a.jumlah_relaisasi,0) as jumlah_relaisasi, " & _
           "'' Status FROM PROD.dbo.PROD_spk_d INNER JOIN  " & _
           "PROD.dbo.PROD_spk_m ON PROD.dbo.PROD_spk_d.no_rph = PROD.dbo.PROD_spk_m.no_rph " & _
           "AND PROD.dbo.PROD_spk_d.no_spk = PROD.dbo.PROD_spk_m.no_spk AND " & _
           "PROD.dbo.PROD_spk_d.kd_kegiatan = PROD.dbo.PROD_spk_m.kd_kegiatan " & _
           "AND PROD.dbo.PROD_spk_d.kd_kegiatan_spk = PROD.dbo.PROD_spk_m.kd_kegiatan_spk INNER JOIN " & _
           "PROD.dbo.PROD_rcn_prod_m ON PROD.dbo.PROD_spk_m.no_rph = PROD.dbo.PROD_rcn_prod_m.no_rph " & _
           "INNER JOIN SIF.dbo.SIF_Gen_Reff_D  " & _
           "ON PROD.dbo.PROD_rcn_prod_m.kd_jadwal = SIF.dbo.SIF_Gen_Reff_D.Id_Data " & _
           "AND SIF.dbo.SIF_Gen_Reff_D.Ref_Role = 'PROD' AND  " & _
           "SIF.dbo.SIF_Gen_Reff_D.Id_Ref_File = 'JDWKRJ' INNER JOIN  " & _
           "SIF.dbo.SIF_Gen_Reff_D AS SIF_Gen_Reff_D_1 " & _
           "ON PROD.dbo.PROD_spk_m.kd_kegiatan = SIF_Gen_Reff_D_1.Id_Data " & _
           "AND SIF_Gen_Reff_D_1.Ref_Role = 'PROD' AND " & _
           "SIF_Gen_Reff_D_1.Id_Ref_File = 'KGTSPK' " & _
           "INNER Join SIF.dbo.SIF_Gen_Reff_D AS SIF_Gen_Reff_D_2 " & _
           "ON PROD.dbo.PROD_spk_m.kd_kegiatan_spk = SIF_Gen_Reff_D_2.Id_Data " & _
           "AND SIF_Gen_Reff_D_2.Ref_Role = 'PROD' AND " & _
           "SIF_Gen_Reff_D_2.Id_Ref_File = 'SPK'  " & _
           "left join (Select rd.no_spk_man,rd.kd_kegiatan,rd.kd_kegiatan_spk,sum(rd.jumlah_realisasi) as jumlah_produksi " & _
           ", sum(rd.jumlah_kerja) as jumlah_relaisasi " & _
           "from PROD.dbo.PROD_rls_spk_man_d rd " & _
           "Group by rd.no_spk_man,rd.kd_kegiatan,rd.kd_kegiatan_spk) a " & _
           "on a.no_spk_man = PROD.dbo.PROD_spk_d.no_spk and a.kd_kegiatan = PROD.dbo.PROD_spk_d.kd_kegiatan " & _
           "and a.kd_kegiatan_spk = PROD.dbo.PROD_spk_d.kd_kegiatan_spk " & _
           "where PROD.dbo.PROD_rcn_prod_m.tanggal between '" & Format(deTglMulai.DateTime, "yyyy/MM/dd") & " 00:00' and '" & Format(deTglSelesai.DateTime, "yyyy/MM/dd") & " 00:00' " & _
           "and isnull(PROD.dbo.PROD_spk_m.jumlah,a.jumlah_produksi) > isnull(a.jumlah_relaisasi,0) "

            'Dim strQuery1 As String = "SELECT PROD.dbo.PROD_spk_d.no_rph, PROD.dbo.PROD_spk_d.kd_kegiatan,PROD.dbo.PROD_spk_d.kd_kegiatan_spk, PROD.dbo.PROD_spk_d.no_spk, SIF.dbo.SIF_Gen_Reff_D.Desc_Data as JadwalKerja, PROD.dbo.PROD_rcn_prod_m.tanggal, PROD.dbo.PROD_spk_m.kapasitas, " & _
            '         "SIF_Gen_Reff_D_1.Desc_Data AS areakegiatan, SIF_Gen_Reff_D_2.Desc_Data AS Kegiatan " & _
            '         "FROM PROD.dbo.PROD_spk_d INNER JOIN " & _
            '         "PROD.dbo.PROD_spk_m ON PROD.dbo.PROD_spk_d.no_rph = PROD.dbo.PROD_spk_m.no_rph AND PROD.dbo.PROD_spk_d.no_spk = PROD.dbo.PROD_spk_m.no_spk AND " & _
            '         "PROD.dbo.PROD_spk_d.kd_kegiatan = PROD.dbo.PROD_spk_m.kd_kegiatan AND PROD.dbo.PROD_spk_d.kd_kegiatan_spk = PROD.dbo.PROD_spk_m.kd_kegiatan_spk INNER JOIN " & _
            '         "PROD.dbo.PROD_rcn_prod_m ON PROD.dbo.PROD_spk_m.no_rph = PROD.dbo.PROD_rcn_prod_m.no_rph INNER JOIN " & _
            '         "SIF.dbo.SIF_Gen_Reff_D ON PROD.dbo.PROD_rcn_prod_m.kd_jadwal = SIF.dbo.SIF_Gen_Reff_D.Id_Data AND SIF.dbo.SIF_Gen_Reff_D.Ref_Role = 'PROD' AND " & _
            '         "SIF.dbo.SIF_Gen_Reff_D.Id_Ref_File = 'JDWKRJ' INNER JOIN " & _
            '         "SIF.dbo.SIF_Gen_Reff_D AS SIF_Gen_Reff_D_1 ON PROD.dbo.PROD_spk_m.kd_kegiatan = SIF_Gen_Reff_D_1.Id_Data AND SIF_Gen_Reff_D_1.Ref_Role = 'PROD' AND " & _
            '         "SIF_Gen_Reff_D_1.Id_Ref_File = 'KGTSPK' " & _
            '         "INNER Join " & _
            '         "SIF.dbo.SIF_Gen_Reff_D AS SIF_Gen_Reff_D_2 ON PROD.dbo.PROD_spk_m.kd_kegiatan_spk = SIF_Gen_Reff_D_2.Id_Data AND SIF_Gen_Reff_D_2.Ref_Role = 'PROD' AND " & _
            '         "SIF_Gen_Reff_D_2.Id_Ref_File = 'SPK'  where PROD.dbo.PROD_rcn_prod_m.tanggal between '" & Format(deTglMulai.DateTime, "yyyy/MM/dd") & " 00:00' and '" & Format(deTglSelesai.DateTime, "yyyy/MM/dd") & " 00:00' and PROD.dbo.PROD_rcn_prod_m.rec_stat <>'N' "


            dadet = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(strQuery1, sqlconn))
            dadet.Fill(dsMon, "mondspk")

            colD1(0) = dsMon.Tables("monspk").Columns("no_rph")
            colD1(1) = dsMon.Tables("monspk").Columns("no_spk")

            colD2(0) = dsMon.Tables("mondspk").Columns("no_rph")
            colD2(1) = dsMon.Tables("mondspk").Columns("no_spk")

            rl = dsMon.Relations.Add("Detail", colD1, colD2, False)
            gc.DataSource = dsMon.Tables("monspk")
            gc.LevelTree.Nodes.Add("Detail", GridView1)
            gvMain.BestFitColumns()
        End If

    End Sub
    Sub LoadClose()
        If awal = "a" Then
            dsMon.Relations.Clear()
            If Not dsMon.Tables("monspk") Is Nothing Then dsMon.Tables("monspk").Clear()
            If Not dsMon.Tables("mondspk") Is Nothing Then dsMon.Tables("mondspk").Clear()
            Dim strQuery As String = "SELECT distinct PROD.dbo.PROD_spk_d.no_rph, PROD.dbo.PROD_spk_d.no_spk " & _
                      "FROM PROD.dbo.PROD_spk_d INNER JOIN " & _
                     "PROD.dbo.PROD_spk_m ON PROD.dbo.PROD_spk_d.no_rph = PROD.dbo.PROD_spk_m.no_rph AND PROD.dbo.PROD_spk_d.no_spk = PROD.dbo.PROD_spk_m.no_spk AND " & _
                     "PROD.dbo.PROD_spk_d.kd_kegiatan = PROD.dbo.PROD_spk_m.kd_kegiatan AND PROD.dbo.PROD_spk_d.kd_kegiatan_spk = PROD.dbo.PROD_spk_m.kd_kegiatan_spk and PROD.dbo.PROD_spk_m.tanggal between '" & Format(deTglMulai.DateTime, "yyyy/MM/dd") & " 00:00' and '" & Format(deTglSelesai.DateTime, "yyyy/MM/dd") & " 00:00' "



            daMon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(strQuery, sqlconn))
            daMon.Fill(dsMon, "monspk")
            'gc.DataSource = dsMon.Tables("monspk")
            gvMain.BestFitColumns()

            'Dim strQuery1 As String = "SELECT PROD.dbo.PROD_spk_d.no_rph,PROD.dbo.PROD_spk_d.kd_kegiatan," & _
            '                      "PROD.dbo.PROD_spk_d.kd_kegiatan_spk, PROD.dbo.PROD_spk_d.no_spk, " & _
            '                      "SIF.dbo.SIF_Gen_Reff_D.Desc_Data as JadwalKerja, PROD.dbo.PROD_rcn_prod_m.tanggal, " & _
            '                      "PROD.dbo.PROD_spk_m.kapasitas, " & _
            '                      "SIF_Gen_Reff_D_1.Desc_Data AS areakegiatan, SIF_Gen_Reff_D_2.Desc_Data AS Kegiatan, " & _
            '                      "a.jumlah_produksi, isnull(a.jumlah_relaisasi,0) as jumlah_relaisasi,'' Status " & _
            '                      "FROM PROD.dbo.PROD_spk_d INNER JOIN " & _
            '                      "PROD.dbo.PROD_spk_m ON PROD.dbo.PROD_spk_d.no_rph = PROD.dbo.PROD_spk_m.no_rph " & _
            '                      "AND PROD.dbo.PROD_spk_d.no_spk = PROD.dbo.PROD_spk_m.no_spk AND " & _
            '                      "PROD.dbo.PROD_spk_d.kd_kegiatan = PROD.dbo.PROD_spk_m.kd_kegiatan " & _
            '                      "AND PROD.dbo.PROD_spk_d.kd_kegiatan_spk = PROD.dbo.PROD_spk_m.kd_kegiatan_spk INNER JOIN " & _
            '                      "PROD.dbo.PROD_rcn_prod_m ON PROD.dbo.PROD_spk_m.no_rph = PROD.dbo.PROD_rcn_prod_m.no_rph " & _
            '                      "INNER JOIN SIF.dbo.SIF_Gen_Reff_D " & _
            '                      "ON PROD.dbo.PROD_rcn_prod_m.kd_jadwal = SIF.dbo.SIF_Gen_Reff_D.Id_Data " & _
            '                      "AND SIF.dbo.SIF_Gen_Reff_D.Ref_Role = 'PROD' AND " & _
            '                      "SIF.dbo.SIF_Gen_Reff_D.Id_Ref_File = 'JDWKRJ' INNER JOIN " & _
            '                      "SIF.dbo.SIF_Gen_Reff_D AS SIF_Gen_Reff_D_1 " & _
            '                      "ON PROD.dbo.PROD_spk_m.kd_kegiatan = SIF_Gen_Reff_D_1.Id_Data " & _
            '                      "AND SIF_Gen_Reff_D_1.Ref_Role = 'PROD' AND " & _
            '                      "SIF_Gen_Reff_D_1.Id_Ref_File = 'KGTSPK' " & _
            '                      "INNER Join SIF.dbo.SIF_Gen_Reff_D AS SIF_Gen_Reff_D_2 " & _
            '                      "ON PROD.dbo.PROD_spk_m.kd_kegiatan_spk = SIF_Gen_Reff_D_2.Id_Data " & _
            '                      "AND SIF_Gen_Reff_D_2.Ref_Role = 'PROD' AND " & _
            '                      "SIF_Gen_Reff_D_2.Id_Ref_File = 'SPK'  " & _
            '                      "inner join(Select DISTINCT d.no_spk,d.kd_kegiatan,d.kd_kegiatan_spk,br.Nama_Barang,d.jumlah_produksi " & _
            '                      ", sum(rd.jumlah_kerja) as jumlah_relaisasi " & _
            '                      "from PROD.dbo.PROD_spk_d d " & _
            '                      "left JOIN PROD.dbo.PROD_rls_spk_man_d rd " & _
            '                      "on rd.no_spk_man = d.no_spk and rd.kd_kegiatan=d.kd_kegiatan " & _
            '                      "and rd.kd_kegiatan_spk=d.kd_kegiatan_spk and rd.kd_barang = d.kd_barang " & _
            '                      "left join SIF.dbo.SIF_Barang br " & _
            '                      "on br.Kode_Barang = d.kd_barang " & _
            '                      "Group by d.no_spk,d.kd_kegiatan,d.kd_kegiatan_spk, " & _
            '                      "d.kd_barang,d.no_urut_brg ,br.Nama_Barang,d.jumlah_produksi) a " & _
            '                      "on a.no_spk = PROD.dbo.PROD_spk_d.no_spk and a.kd_kegiatan = PROD.dbo.PROD_spk_d.kd_kegiatan " & _
            '                      "and a.kd_kegiatan_spk = PROD.dbo.PROD_spk_d.kd_kegiatan_spk " & _
            '                      "where PROD.dbo.PROD_rcn_prod_m.tanggal between '" & Format(deTglMulai.DateTime, "yyyy/MM/dd") & " 00:00' and '" & Format(deTglSelesai.DateTime, "yyyy/MM/dd") & " 00:00' and PROD.dbo.PROD_rcn_prod_m.rec_stat <>'N' "

            Dim strQuery1 As String = "SELECT Distinct  PROD.dbo.PROD_spk_d.no_rph,PROD.dbo.PROD_spk_d.kd_kegiatan, " & _
            "PROD.dbo.PROD_spk_d.kd_kegiatan_spk, PROD.dbo.PROD_spk_d.no_spk, " & _
            "SIF.dbo.SIF_Gen_Reff_D.Desc_Data as JadwalKerja, PROD.dbo.PROD_rcn_prod_m.tanggal, " & _
            "PROD.dbo.PROD_spk_m.kapasitas, " & _
            "SIF_Gen_Reff_D_1.Desc_Data AS areakegiatan, SIF_Gen_Reff_D_2.Desc_Data AS Kegiatan, " & _
            "isnull(PROD.dbo.PROD_spk_m.jumlah,a.jumlah_produksi) as jumlah_produksi ,isnull(a.jumlah_relaisasi,0) as jumlah_relaisasi, " & _
            "'' Status FROM PROD.dbo.PROD_spk_d INNER JOIN  " & _
            "PROD.dbo.PROD_spk_m ON PROD.dbo.PROD_spk_d.no_rph = PROD.dbo.PROD_spk_m.no_rph " & _
            "AND PROD.dbo.PROD_spk_d.no_spk = PROD.dbo.PROD_spk_m.no_spk AND " & _
            "PROD.dbo.PROD_spk_d.kd_kegiatan = PROD.dbo.PROD_spk_m.kd_kegiatan " & _
            "AND PROD.dbo.PROD_spk_d.kd_kegiatan_spk = PROD.dbo.PROD_spk_m.kd_kegiatan_spk INNER JOIN " & _
            "PROD.dbo.PROD_rcn_prod_m ON PROD.dbo.PROD_spk_m.no_rph = PROD.dbo.PROD_rcn_prod_m.no_rph " & _
            "INNER JOIN SIF.dbo.SIF_Gen_Reff_D  " & _
            "ON PROD.dbo.PROD_rcn_prod_m.kd_jadwal = SIF.dbo.SIF_Gen_Reff_D.Id_Data " & _
            "AND SIF.dbo.SIF_Gen_Reff_D.Ref_Role = 'PROD' AND  " & _
            "SIF.dbo.SIF_Gen_Reff_D.Id_Ref_File = 'JDWKRJ' INNER JOIN  " & _
            "SIF.dbo.SIF_Gen_Reff_D AS SIF_Gen_Reff_D_1 " & _
            "ON PROD.dbo.PROD_spk_m.kd_kegiatan = SIF_Gen_Reff_D_1.Id_Data " & _
            "AND SIF_Gen_Reff_D_1.Ref_Role = 'PROD' AND " & _
            "SIF_Gen_Reff_D_1.Id_Ref_File = 'KGTSPK' " & _
            "INNER Join SIF.dbo.SIF_Gen_Reff_D AS SIF_Gen_Reff_D_2 " & _
            "ON PROD.dbo.PROD_spk_m.kd_kegiatan_spk = SIF_Gen_Reff_D_2.Id_Data " & _
            "AND SIF_Gen_Reff_D_2.Ref_Role = 'PROD' AND " & _
            "SIF_Gen_Reff_D_2.Id_Ref_File = 'SPK'  " & _
            "left join (Select rd.no_spk_man,rd.kd_kegiatan,rd.kd_kegiatan_spk,sum(rd.jumlah_realisasi) as jumlah_produksi " & _
            ", sum(rd.jumlah_kerja) as jumlah_relaisasi " & _
            "from PROD.dbo.PROD_rls_spk_man_d rd " & _
            "Group by rd.no_spk_man,rd.kd_kegiatan,rd.kd_kegiatan_spk) a " & _
            "on a.no_spk_man = PROD.dbo.PROD_spk_d.no_spk and a.kd_kegiatan = PROD.dbo.PROD_spk_d.kd_kegiatan " & _
            "and a.kd_kegiatan_spk = PROD.dbo.PROD_spk_d.kd_kegiatan_spk " & _
            "where PROD.dbo.PROD_rcn_prod_m.tanggal between '" & Format(deTglMulai.DateTime, "yyyy/MM/dd") & " 00:00' and '" & Format(deTglSelesai.DateTime, "yyyy/MM/dd") & " 00:00' " & _
            "and isnull(PROD.dbo.PROD_spk_m.jumlah,a.jumlah_produksi) = isnull(a.jumlah_relaisasi,0) "



            'Dim strQuery1 As String = "SELECT PROD.dbo.PROD_spk_d.no_rph, PROD.dbo.PROD_spk_d.kd_kegiatan,PROD.dbo.PROD_spk_d.kd_kegiatan_spk,PROD.dbo.PROD_spk_d.no_spk, SIF.dbo.SIF_Gen_Reff_D.Desc_Data as JadwalKerja, PROD.dbo.PROD_rcn_prod_m.tanggal, PROD.dbo.PROD_spk_m.kapasitas, " & _
            '         "SIF_Gen_Reff_D_1.Desc_Data AS areakegiatan, SIF_Gen_Reff_D_2.Desc_Data AS Kegiatan " & _
            '         "FROM PROD.dbo.PROD_spk_d INNER JOIN " & _
            '         "PROD.dbo.PROD_spk_m ON PROD.dbo.PROD_spk_d.no_rph = PROD.dbo.PROD_spk_m.no_rph AND PROD.dbo.PROD_spk_d.no_spk = PROD.dbo.PROD_spk_m.no_spk AND " & _
            '         "PROD.dbo.PROD_spk_d.kd_kegiatan = PROD.dbo.PROD_spk_m.kd_kegiatan AND PROD.dbo.PROD_spk_d.kd_kegiatan_spk = PROD.dbo.PROD_spk_m.kd_kegiatan_spk INNER JOIN " & _
            '         "PROD.dbo.PROD_rcn_prod_m ON PROD.dbo.PROD_spk_m.no_rph = PROD.dbo.PROD_rcn_prod_m.no_rph INNER JOIN " & _
            '         "SIF.dbo.SIF_Gen_Reff_D ON PROD.dbo.PROD_rcn_prod_m.kd_jadwal = SIF.dbo.SIF_Gen_Reff_D.Id_Data AND SIF.dbo.SIF_Gen_Reff_D.Ref_Role = 'PROD' AND " & _
            '         "SIF.dbo.SIF_Gen_Reff_D.Id_Ref_File = 'JDWKRJ' INNER JOIN " & _
            '         "SIF.dbo.SIF_Gen_Reff_D AS SIF_Gen_Reff_D_1 ON PROD.dbo.PROD_spk_m.kd_kegiatan = SIF_Gen_Reff_D_1.Id_Data AND SIF_Gen_Reff_D_1.Ref_Role = 'PROD' AND " & _
            '         "SIF_Gen_Reff_D_1.Id_Ref_File = 'KGTSPK' " & _
            '         "INNER Join " & _
            '         "SIF.dbo.SIF_Gen_Reff_D AS SIF_Gen_Reff_D_2 ON PROD.dbo.PROD_spk_m.kd_kegiatan_spk = SIF_Gen_Reff_D_2.Id_Data AND SIF_Gen_Reff_D_2.Ref_Role = 'PROD' AND " & _
            '         "SIF_Gen_Reff_D_2.Id_Ref_File = 'SPK'  where PROD.dbo.PROD_rcn_prod_m.tanggal between '" & Format(deTglMulai.DateTime, "yyyy/MM/dd") & " 00:00' and '" & Format(deTglSelesai.DateTime, "yyyy/MM/dd") & " 00:00' and PROD.dbo.PROD_rcn_prod_m.rec_stat ='N' "


            dadet = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(strQuery1, sqlconn))
            dadet.Fill(dsMon, "mondspk")

            colD1(0) = dsMon.Tables("monspk").Columns("no_rph")
            colD1(1) = dsMon.Tables("monspk").Columns("no_spk")

            colD2(0) = dsMon.Tables("mondspk").Columns("no_rph")
            colD2(1) = dsMon.Tables("mondspk").Columns("no_spk")

            rl = dsMon.Relations.Add("Detail", colD1, colD2, False)
            gc.DataSource = dsMon.Tables("monspk")
            gc.LevelTree.Nodes.Add("Detail", GridView1)
            gvMain.BestFitColumns()
        End If

    End Sub


    Private Sub deTanggal_DateTimeChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        'LoadLUE()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        If awal = "awal" Then
            LoadGrid()
            If Not dsrls.Tables("monrspk") Is Nothing Then dsrls.Tables("monrspk").Clear()
            awal = "a"
        ElseIf awal = "a" Then

            If CEKuning.Checked = True And CEHijau.Checked = False And CEMerah.Checked = False Then

                LoadGrid()
                If Not dsrls.Tables("monrspk") Is Nothing Then dsrls.Tables("monrspk").Clear()
            ElseIf CEMerah.Checked = True And CEHijau.Checked = False And CEKuning.Checked = False Then

                LoadClose()
                If Not dsrls.Tables("monrspk") Is Nothing Then dsrls.Tables("monrspk").Clear()
            ElseIf CEHijau.Checked = True And CEKuning.Checked = False And CEMerah.Checked = False Then

                LoadOpen()
                If Not dsrls.Tables("monrspk") Is Nothing Then dsrls.Tables("monrspk").Clear()
            End If
        End If

    End Sub


    Private Sub CEMerah_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CEMerah.Click
        CEKuning.Checked = False

        CEHijau.Checked = False
    End Sub

    Private Sub CEHijau_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CEHijau.Click

        CEKuning.Checked = False
        CEMerah.Checked = False

    End Sub

    Private Sub CEKuning_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CEKuning.Click
        CEMerah.Checked = False
        CEHijau.Checked = False

    End Sub
    Public Sub cetak_click()
        MsgBox("Fungsi Cetak tidak tersedia untuk monitoring ini. Terimakasih ", MsgBoxStyle.Information)
    End Sub
    Private Sub GridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GridView1.FocusedRowChanged
        Dim x As Object
        Dim nospk, kd, keg As String
        Try
            x = CType(gc.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)

            nospk = x.GetRowCellValue(e.FocusedRowHandle, "no_spk").ToString
            kd = x.GetRowCellValue(e.FocusedRowHandle, "kd_kegiatan").ToString
            keg = x.GetRowCellValue(e.FocusedRowHandle, "kd_kegiatan_spk").ToString
        Catch ex As Exception

        End Try


        If kd = "" Then


        Else

            dsrls.Relations.Clear()
            If Not dsrls.Tables("monrspk") Is Nothing Then dsrls.Tables("monrspk").Clear()
            If Not dsrls.Tables("monrspkd") Is Nothing Then dsrls.Tables("monrspkd").Clear()
            If Not dsrls.Tables("monrspkcentian") Is Nothing Then dsrls.Tables("monrspkcentian").Clear()

            Dim strQuery3 As String = "Select DISTINCT d.no_spk,d.kd_kegiatan,d.kd_kegiatan_spk, d.kd_barang,d.no_urut_brg ,br.Nama_Barang,d.jumlah_produksi " & _
            ", isnull((sum(rd.jumlah_kerja)),0.00) as jumlah_realisasi " & _
            "from PROD.dbo.PROD_spk_d d " & _
            "left JOIN PROD.dbo.PROD_rls_spk_man_d rd " & _
            "on rd.no_spk_man = d.no_spk and rd.kd_kegiatan=d.kd_kegiatan " & _
            "and rd.kd_kegiatan_spk=d.kd_kegiatan_spk and rd.kd_barang = d.kd_barang " & _
            "left join SIF.dbo.SIF_Barang br " & _
            "on br.Kode_Barang = d.kd_barang " & _
            "where d.no_spk ='" & nospk & "' and d.kd_kegiatan = '" & kd & "' and d.kd_kegiatan_spk = '" & keg & "' " & _
            "Group by d.no_spk,d.kd_kegiatan,d.kd_kegiatan_spk, d.kd_barang,d.no_urut_brg ,br.Nama_Barang,d.jumlah_produksi "

            Dim strQuery4 As String = "Select d.no_spk_man as no_spk, d.no_spk_man_rls,d.kd_kegiatan,d.kd_kegiatan_spk, " & _
            "d.kd_barang, b.Nama_Barang, k.Merk_Kain, u.Nama_Ukuran, t.Nama_Tipe, d.no_urut, d.jumlah_kerja " & _
            "From PROD.dbo.PROD_rls_spk_man_d d " & _
            "inner join SIF.dbo.SIF_Barang b " & _
            "on b.Kode_Barang = d.kd_barang " & _
            "inner join SIF.dbo.SIF_Kain k " & _
            "on k.Kode_Kain = b.kd_kain " & _
            "inner join SIF.dbo.SIF_Ukuran u " & _
            "on u.Kode_Ukuran = b.kd_ukuran " & _
            "inner join SIF.dbo.SIF_Tipe t " & _
            "on t.Kode_Tipe = b.kd_tipe and t.Kode_Merk=b.kd_merk " & _
            "where d.no_spk_man ='" & nospk & "' and d.kd_kegiatan = '" & kd & "' and d.kd_kegiatan_spk = '" & keg & "' "

            Dim strQuery5 As String = "Select d.no_spk_man, d.no_spk_man_rls, d.kd_barang,d.no_urut, b.Nama_Barang," & _
            "d.tinggi, d.lebar, d.panjang, d.jumlah " & _
            "from PROD.dbo.PROD_rls_spk_man_sp d " & _
            "LEFT JOIN SIF.dbo.SIF_Barang b " & _
            "on b.Kode_Barang = d.kd_barang " & _
            "where d.no_spk_man = '" & nospk & "' and d.kd_kegiatan = '" & kd & "' and d.kd_kegiatan_spk = '" & keg & "'"

            darls = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(strQuery3, sqlconn))
            darls.Fill(dsrls, "monrspk")
            darls1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(strQuery4, sqlconn))
            darls1.Fill(dsrls, "monrspkd")

            darls2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(strQuery5, sqlconn))
            darls2.Fill(dsrls, "monrspkcentian")

            '   GridControl1.DataSource = dsrls.Tables("monrspk")

            colDR1(0) = dsrls.Tables("monrspk").Columns("no_spk")
            colDR1(1) = dsrls.Tables("monrspk").Columns("kd_kegiatan")
            colDR1(2) = dsrls.Tables("monrspk").Columns("kd_kegiatan_spk")
            colDR1(3) = dsrls.Tables("monrspk").Columns("kd_barang")
            colDR1(4) = dsrls.Tables("monrspk").Columns("no_urut_brg")


            colDR2(0) = dsrls.Tables("monrspkd").Columns("no_spk")
            colDR2(1) = dsrls.Tables("monrspkd").Columns("kd_kegiatan")
            colDR2(2) = dsrls.Tables("monrspkd").Columns("kd_kegiatan_spk")
            colDR2(3) = dsrls.Tables("monrspkd").Columns("kd_barang")
            colDR2(4) = dsrls.Tables("monrspkd").Columns("no_urut")



            colDC1(0) = dsrls.Tables("monrspkd").Columns("no_spk_man_rls")
            colDC1(1) = dsrls.Tables("monrspkd").Columns("kd_barang")
            colDC1(2) = dsrls.Tables("monrspkd").Columns("no_urut")

            colDC2(0) = dsrls.Tables("monrspkcentian").Columns("no_spk_man_rls")
            colDC2(1) = dsrls.Tables("monrspkcentian").Columns("kd_barang")
            colDC2(2) = dsrls.Tables("monrspkcentian").Columns("no_urut")

            r2 = dsrls.Relations.Add("Detail1", colDR1, colDR2, False)


            r3 = dsrls.Relations.Add("DetailCenti", colDC1, colDC2, False)


            GridControl1.DataSource = dsrls.Tables("monrspk")
            GridControl1.LevelTree.Nodes.Add("Detail1", gv_detil).Nodes.Add("DetailCenti", gv_detilcentian)
            GV_RealisasiHeader.BestFitColumns()
        End If

    End Sub





    Private Sub GridView1_RowClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles GridView1.RowClick
        Dim x As Object

        x = CType(gc.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        Dim nospk, kd, keg As String
        nospk = x.GetRowCellValue(e.RowHandle, "no_spk").ToString
        kd = x.GetRowCellValue(e.RowHandle, "kd_kegiatan").ToString
        keg = x.GetRowCellValue(e.RowHandle, "kd_kegiatan_spk").ToString

        If kd = "" Then


        Else

            dsrls.Relations.Clear()
            If Not dsrls.Tables("monrspk") Is Nothing Then dsrls.Tables("monrspk").Clear()
            If Not dsrls.Tables("monrspkd") Is Nothing Then dsrls.Tables("monrspkd").Clear()
            If Not dsrls.Tables("monrspkcentian") Is Nothing Then dsrls.Tables("monrspkcentian").Clear()

            Dim strQuery3 As String = "Select DISTINCT d.no_spk,d.kd_kegiatan,d.kd_kegiatan_spk, d.kd_barang,d.no_urut_brg ,br.Nama_Barang,d.jumlah_produksi " & _
            ", isnull((sum(rd.jumlah_kerja)),0.00) as jumlah_realisasi " & _
            "from PROD.dbo.PROD_spk_d d " & _
            "left JOIN PROD.dbo.PROD_rls_spk_man_d rd " & _
            "on rd.no_spk_man = d.no_spk and rd.kd_kegiatan=d.kd_kegiatan " & _
            "and rd.kd_kegiatan_spk=d.kd_kegiatan_spk and rd.kd_barang = d.kd_barang " & _
            "left join SIF.dbo.SIF_Barang br " & _
            "on br.Kode_Barang = d.kd_barang " & _
            "where d.no_spk ='" & nospk & "' and d.kd_kegiatan = '" & kd & "' and d.kd_kegiatan_spk = '" & keg & "' " & _
            "Group by d.no_spk,d.kd_kegiatan,d.kd_kegiatan_spk, d.kd_barang,d.no_urut_brg ,br.Nama_Barang,d.jumlah_produksi "

            Dim strQuery4 As String = "Select d.no_spk_man as no_spk, d.no_spk_man_rls,d.kd_kegiatan,d.kd_kegiatan_spk, " & _
            "d.kd_barang, b.Nama_Barang, k.Merk_Kain, u.Nama_Ukuran, t.Nama_Tipe, d.no_urut, d.jumlah_kerja " & _
            "From PROD.dbo.PROD_rls_spk_man_d d " & _
            "inner join SIF.dbo.SIF_Barang b " & _
            "on b.Kode_Barang = d.kd_barang " & _
            "inner join SIF.dbo.SIF_Kain k " & _
            "on k.Kode_Kain = b.kd_kain " & _
            "inner join SIF.dbo.SIF_Ukuran u " & _
            "on u.Kode_Ukuran = b.kd_ukuran " & _
            "inner join SIF.dbo.SIF_Tipe t " & _
            "on t.Kode_Tipe = b.kd_tipe and t.Kode_Merk=b.kd_merk " & _
            "where d.no_spk_man ='" & nospk & "' and d.kd_kegiatan = '" & kd & "' and d.kd_kegiatan_spk = '" & keg & "' "

            Dim strQuery5 As String = "Select distinct d.no_spk_man, d.no_spk_man_rls, d.kd_barang,d.no_urut, b.Nama_Barang," & _
            "d.tinggi, d.lebar, d.panjang, d.jumlah " & _
            "from PROD.dbo.PROD_rls_spk_man_sp d " & _
            "LEFT JOIN SIF.dbo.SIF_Barang b " & _
            "on b.Kode_Barang = d.kd_barang " & _
            "where d.no_spk_man = '" & nospk & "' and d.kd_kegiatan = '" & kd & "' and d.kd_kegiatan_spk = '" & keg & "'"

            darls = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(strQuery3, sqlconn))
            darls.Fill(dsrls, "monrspk")
            darls1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(strQuery4, sqlconn))
            darls1.Fill(dsrls, "monrspkd")

            darls2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(strQuery5, sqlconn))
            darls2.Fill(dsrls, "monrspkcentian")

            ' GridControl1.DataSource = dsrls.Tables("monrspk")

            colDR1(0) = dsrls.Tables("monrspk").Columns("no_spk")
            colDR1(1) = dsrls.Tables("monrspk").Columns("kd_kegiatan")
            colDR1(2) = dsrls.Tables("monrspk").Columns("kd_kegiatan_spk")
            colDR1(3) = dsrls.Tables("monrspk").Columns("kd_barang")
            colDR1(4) = dsrls.Tables("monrspk").Columns("no_urut_brg")


            colDR2(0) = dsrls.Tables("monrspkd").Columns("no_spk")
            colDR2(1) = dsrls.Tables("monrspkd").Columns("kd_kegiatan")
            colDR2(2) = dsrls.Tables("monrspkd").Columns("kd_kegiatan_spk")
            colDR2(3) = dsrls.Tables("monrspkd").Columns("kd_barang")
            colDR2(4) = dsrls.Tables("monrspkd").Columns("no_urut")



            colDC1(0) = dsrls.Tables("monrspkd").Columns("no_spk_man_rls")
            colDC1(1) = dsrls.Tables("monrspkd").Columns("kd_barang")
            colDC1(2) = dsrls.Tables("monrspkd").Columns("no_urut")

            colDC2(0) = dsrls.Tables("monrspkcentian").Columns("no_spk_man_rls")
            colDC2(1) = dsrls.Tables("monrspkcentian").Columns("kd_barang")
            colDC2(2) = dsrls.Tables("monrspkcentian").Columns("no_urut")

            r2 = dsrls.Relations.Add("Detail1", colDR1, colDR2, False)


            r3 = dsrls.Relations.Add("DetailCenti", colDC1, colDC2, False)


            GridControl1.DataSource = dsrls.Tables("monrspk")
            GridControl1.LevelTree.Nodes.Add("Detail1", gv_detil).Nodes.Add("DetailCenti", gv_detilcentian)
            GV_RealisasiHeader.BestFitColumns()


            'GridView3.BestFitColumns()



        End If
    End Sub


End Class