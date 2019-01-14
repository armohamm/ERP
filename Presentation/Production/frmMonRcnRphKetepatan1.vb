Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class frmMonRcnRphKetepatan1
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain

    Dim dsMon, dsMon1, dsNoTrans, dsmon2, dsNoRPH As New DataSet
    Dim daMon, daMon1, daNoTrans, daNoRPH As SqlDataAdapter

    Private Sub frmMonRcnKrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        deTglMulai.DateTime = Now
        deTglSelesai.DateTime = Now
        Me.Enabled = True
        gvMain.BestFitColumns()
        LoadLUE()

    End Sub

    Private Sub LoadLUE()
        If kddep = "2" Then
            Dim strQuery As String = "select Kd_Departemen,Nama_Departemen from SIF.dbo.SIF_Departemen where Kd_Departemen='2'  "
            If Not dsmon2.Tables("dep") Is Nothing Then dsmon2.Tables("dep").Clear()
            daMon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(strQuery, sqlconn))
            daMon.Fill(dsmon2, "dep")
            lueDep.Properties.ReadOnly = False
            lueDep.Properties.DataSource = dsmon2.Tables("dep")
            lueDep.Properties.ValueMember = "Kd_Departemen"
            lueDep.Properties.DisplayMember = "Nama_Departemen"
            Dim row As DataRow
            row = dsmon2.Tables("dep").Rows(0)
            lueDep.EditValue = row.Item("Kd_Departemen").ToString
            lueDep.Properties.ReadOnly = True
            'LoadGrid()
        ElseIf kddep = "3" Then
            Dim strQuery As String = "select Kd_Departemen,Nama_Departemen from SIF.dbo.SIF_Departemen where Kd_Departemen='3'  "
            If Not dsmon2.Tables("dep") Is Nothing Then dsmon2.Tables("dep").Clear()
            daMon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(strQuery, sqlconn))
            daMon.Fill(dsmon2, "dep")
            lueDep.Properties.ReadOnly = False
            lueDep.Properties.DataSource = dsmon2.Tables("dep")
            lueDep.Properties.ValueMember = "Kd_Departemen"
            lueDep.Properties.DisplayMember = "Nama_Departemen"
            Dim row As DataRow
            row = dsmon2.Tables("dep").Rows(0)
            lueDep.EditValue = row.Item("Kd_Departemen").ToString

            lueDep.Properties.ReadOnly = True
            'LoadGrid()
        Else
            Dim strQuery As String = "select Kd_Departemen,Nama_Departemen from SIF.dbo.SIF_Departemen "
            If Not dsmon2.Tables("dep") Is Nothing Then dsmon2.Tables("dep").Clear()
            daMon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(strQuery, sqlconn))
            daMon.Fill(dsmon2, "dep")
            lueDep.Properties.ReadOnly = False
            lueDep.Properties.DataSource = dsmon2.Tables("dep")
            lueDep.Properties.ValueMember = "Kd_Departemen"
            lueDep.Properties.DisplayMember = "Nama_Departemen"
        End If

    End Sub

    Private Sub LoadGrid()
        'If Not lueNoTrans.EditValue Is Nothing Then
        '    Dim strQuery As String = "Select sm.no_rph,m.no_spk_man as no_spk_man_m , d.no_spk_man_rls, m.tanggal , " & _
        '    "d.no_spk_man as no_spk_man_d, keg.Desc_Data as nama_kegiatan , " & _
        '    "keg2.Desc_Data as nama_spk ,d.kd_barang, b.Nama_Barang , " & _
        '    "t.Nama_Tipe, k.Merk_Kain, u.Nama_Ukuran, d.jumlah_kerja, s.Nama_Satuan " & _
        '    "from PROD.dbo.PROD_rls_spk_man_d d " & _
        '    "left join PROD.dbo.PROD_rls_spk_man_m m " & _
        '    "on m.no_spk_man = d.no_spk_man and m.no_spk_man_rls = d.no_spk_man_rls " & _
        '    "and m.kd_kegiatan = d.kd_kegiatan and m.kd_kegiatan_spk = d.kd_kegiatan_spk " & _
        '    "left join SIF.dbo.SIF_Barang b " & _
        '    "on b.Kode_Barang = d.kd_barang " & _
        '    "left join SIF.dbo.SIF_Tipe t on b.kd_tipe = t.Kode_Tipe " & _
        '    "left join SIF.dbo.SIF_Kain k on b.kd_kain = k.Kode_Kain " & _
        '    "left join SIF.dbo.SIF_Ukuran u on b.kd_ukuran = u.Kode_Ukuran " & _
        '    "left join SIF.dbo.SIF_Satuan s on s.Kode_Satuan = b.Kd_Satuan " & _
        '    "left join PROD.dbo.PROD_spk_m sm " & _
        '    "on sm.no_spk = m.no_spk_man and sm.kd_kegiatan = m.kd_kegiatan  " & _
        '    "and sm.kd_kegiatan_spk = m.kd_kegiatan_spk " & _
        '    "left join (Select Id_Data, Desc_Data from SIF.dbo.SIF_Gen_Reff_D where Ref_Role = 'PROD' " & _
        '    "and Id_Ref_Data = 'KGTSPK' ) keg " & _
        '    "on keg.Id_Data = d.kd_kegiatan " & _
        '    "left join (Select Id_Data, Desc_Data from SIF.dbo.SIF_Gen_Reff_D where Ref_Role = 'PROD' " & _
        '    "and Id_Ref_Data = 'SPK' ) keg2 " & _
        '    "on keg2.Id_Data = d.kd_kegiatan_spk " & _
        '    "where m.tanggal  between '" & Format(deTglMulai.DateTime, "yyyy/MM/dd") & " 00:00' and '" & Format(deTglSelesai.DateTime, "yyyy/MM/dd") & " 00:00'"
        '    dsMon.Clear()
        '    daMon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(strQuery, sqlconn))
        '    daMon.Fill(dsMon, "monrcnkrm")
        '    gc.DataSource = dsMon.Tables("monrcnkrm")
        '    gvMain.BestFitColumns()
        'End If
        If lueNoRPH.EditValue = "ALL" Then
            Dim strQuery As String = "Select sm.no_rph,m.no_spk_man as no_spk_man_m , d.no_spk_man_rls, m.tanggal , " & _
        "r.tanggal_realisasi, d.no_spk_man as no_spk_man_d, keg.Desc_Data as nama_kegiatan , " & _
        "keg2.Desc_Data as nama_spk ,d.kd_barang, b.Nama_Barang , " & _
        "t.Nama_Tipe, k.Merk_Kain, u.Nama_Ukuran, d.jumlah_kerja, s.Nama_Satuan " & _
        "from PROD.dbo.PROD_rls_spk_man_d d " & _
        "left join PROD.dbo.PROD_rls_spk_man_m m " & _
        "on m.no_spk_man = d.no_spk_man and m.no_spk_man_rls = d.no_spk_man_rls " & _
        "and m.kd_kegiatan = d.kd_kegiatan and m.kd_kegiatan_spk = d.kd_kegiatan_spk " & _
        "left join SIF.dbo.SIF_Barang b " & _
        "on b.Kode_Barang = d.kd_barang " & _
        "left join SIF.dbo.SIF_Tipe t on b.kd_tipe = t.Kode_Tipe and b.kd_merk = t.Kode_Merk " & _
        "left join SIF.dbo.SIF_Kain k on b.kd_kain = k.Kode_Kain " & _
        "left join SIF.dbo.SIF_Ukuran u on b.kd_ukuran = u.Kode_Ukuran " & _
        "left join SIF.dbo.SIF_Satuan s on s.Kode_Satuan = b.Kd_Satuan " & _
        "left join PROD.dbo.PROD_spk_m sm " & _
        "on sm.no_spk = m.no_spk_man and sm.kd_kegiatan = m.kd_kegiatan  " & _
        "and sm.kd_kegiatan_spk = m.kd_kegiatan_spk " & _
        "left join PROD.dbo.PROD_rcn_prod_m r " & _
        "on r.no_rph = sm.no_rph " & _
        "left join (Select Id_Data, Desc_Data from SIF.dbo.SIF_Gen_Reff_D where Ref_Role = 'PROD' " & _
        "and Id_Ref_Data = 'KGTSPK' ) keg " & _
        "on keg.Id_Data = d.kd_kegiatan " & _
        "left join (Select Id_Data, Desc_Data from SIF.dbo.SIF_Gen_Reff_D where Ref_Role = 'PROD' " & _
        "and Id_Ref_Data = 'SPK' ) keg2 " & _
        "on keg2.Id_Data = d.kd_kegiatan_spk " & _
        "where d.kd_departemen ='" & lueDep.EditValue & "' and  m.tanggal  between '" & Format(deTglMulai.DateTime, "yyyy/MM/dd") & " 00:00' and '" & Format(deTglSelesai.DateTime, "yyyy/MM/dd") & " 00:00'"
            dsMon.Clear()
            daMon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(strQuery, sqlconn))
            daMon.Fill(dsMon, "monrcnkrm")
            gc.DataSource = dsMon.Tables("monrcnkrm")
            gvMain.BestFitColumns()

            Dim strQuery1 As String = "Select d.kd_barang, b.Nama_Barang , " & _
       "t.Nama_Tipe,k.Merk_Kain, u.Nama_Ukuran, Sum(d.jumlah_kerja) as jumlah_kerja, s.Nama_Satuan " & _
       "from PROD.dbo.PROD_rls_spk_man_d d " & _
       "left join PROD.dbo.PROD_rls_spk_man_m m " & _
       "on m.no_spk_man = d.no_spk_man and m.no_spk_man_rls = d.no_spk_man_rls " & _
       "and m.kd_kegiatan = d.kd_kegiatan and m.kd_kegiatan_spk = d.kd_kegiatan_spk " & _
       "left join SIF.dbo.SIF_Barang b " & _
       "on b.Kode_Barang = d.kd_barang " & _
       "left join SIF.dbo.SIF_Tipe t on b.kd_tipe = t.Kode_Tipe and b.kd_merk = t.Kode_Merk " & _
       "left join SIF.dbo.SIF_Kain k on b.kd_kain = k.Kode_Kain " & _
       "left join SIF.dbo.SIF_Ukuran u on b.kd_ukuran = u.Kode_Ukuran " & _
       "left join SIF.dbo.SIF_Satuan s on s.Kode_Satuan = b.Kd_Satuan " & _
       "left join PROD.dbo.PROD_spk_m sm " & _
       "on sm.no_spk = m.no_spk_man and sm.kd_kegiatan = m.kd_kegiatan  " & _
       "and sm.kd_kegiatan_spk = m.kd_kegiatan_spk " & _
       "left join (Select Id_Data, Desc_Data from SIF.dbo.SIF_Gen_Reff_D where Ref_Role = 'PROD' " & _
       "and Id_Ref_Data = 'KGTSPK' ) keg " & _
       "on keg.Id_Data = d.kd_kegiatan " & _
       "left join (Select Id_Data, Desc_Data from SIF.dbo.SIF_Gen_Reff_D where Ref_Role = 'PROD' " & _
       "and Id_Ref_Data = 'SPK' ) keg2 " & _
       "on keg2.Id_Data = d.kd_kegiatan_spk " & _
       "where d.kd_departemen ='" & lueDep.EditValue & "' and m.tanggal  between '" & Format(deTglMulai.DateTime, "yyyy/MM/dd") & " 00:00' and '" & Format(deTglSelesai.DateTime, "yyyy/MM/dd") & " 00:00'" & _
       "Group by d.kd_barang, b.Nama_Barang, t.Nama_Tipe, k.Merk_Kain, u.Nama_Ukuran, s.Nama_Satuan "
            dsMon1.Clear()
            daMon1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(strQuery1, sqlconn))
            daMon1.Fill(dsMon1, "monrcnkrm1")
            GC_Rekap.DataSource = dsMon1.Tables("monrcnkrm1")
            gvMain.BestFitColumns()
        Else
            Dim strQuery As String = "Select sm.no_rph,m.no_spk_man as no_spk_man_m , d.no_spk_man_rls, m.tanggal , " & _
        "r.tanggal_realisasi, d.no_spk_man as no_spk_man_d, keg.Desc_Data as nama_kegiatan , " & _
        "keg2.Desc_Data as nama_spk ,d.kd_barang, b.Nama_Barang , " & _
        "t.Nama_Tipe, k.Merk_Kain, u.Nama_Ukuran, d.jumlah_kerja, s.Nama_Satuan " & _
        "from PROD.dbo.PROD_rls_spk_man_d d " & _
        "left join PROD.dbo.PROD_rls_spk_man_m m " & _
        "on m.no_spk_man = d.no_spk_man and m.no_spk_man_rls = d.no_spk_man_rls " & _
        "and m.kd_kegiatan = d.kd_kegiatan and m.kd_kegiatan_spk = d.kd_kegiatan_spk " & _
        "left join SIF.dbo.SIF_Barang b " & _
        "on b.Kode_Barang = d.kd_barang " & _
        "left join SIF.dbo.SIF_Tipe t on b.kd_tipe = t.Kode_Tipe and b.kd_merk = t.Kode_Merk " & _
        "left join SIF.dbo.SIF_Kain k on b.kd_kain = k.Kode_Kain " & _
        "left join SIF.dbo.SIF_Ukuran u on b.kd_ukuran = u.Kode_Ukuran " & _
        "left join SIF.dbo.SIF_Satuan s on s.Kode_Satuan = b.Kd_Satuan " & _
        "left join PROD.dbo.PROD_spk_m sm " & _
        "on sm.no_spk = m.no_spk_man and sm.kd_kegiatan = m.kd_kegiatan  " & _
        "and sm.kd_kegiatan_spk = m.kd_kegiatan_spk " & _
        "left join PROD.dbo.PROD_rcn_prod_m r " & _
        "on r.no_rph = sm.no_rph " & _
        "left join (Select Id_Data, Desc_Data from SIF.dbo.SIF_Gen_Reff_D where Ref_Role = 'PROD' " & _
        "and Id_Ref_Data = 'KGTSPK' ) keg " & _
        "on keg.Id_Data = d.kd_kegiatan " & _
        "left join (Select Id_Data, Desc_Data from SIF.dbo.SIF_Gen_Reff_D where Ref_Role = 'PROD' " & _
        "and Id_Ref_Data = 'SPK' ) keg2 " & _
        "on keg2.Id_Data = d.kd_kegiatan_spk " & _
        "where d.kd_departemen ='" & lueDep.EditValue & "' and  m.tanggal  between '" & Format(deTglMulai.DateTime, "yyyy/MM/dd") & " 00:00' and '" & Format(deTglSelesai.DateTime, "yyyy/MM/dd") & " 00:00' " & _
        "and sm.no_rph = '" & lueNoRPH.EditValue & "'"
            dsMon.Clear()
            daMon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(strQuery, sqlconn))
            daMon.Fill(dsMon, "monrcnkrm")
            gc.DataSource = dsMon.Tables("monrcnkrm")
            gvMain.BestFitColumns()


            Dim strQuery1 As String = "Select d.kd_barang, b.Nama_Barang , " & _
     "t.Nama_Tipe,k.Merk_Kain, u.Nama_Ukuran, Sum(d.jumlah_kerja) as jumlah_kerja, s.Nama_Satuan " & _
     "from PROD.dbo.PROD_rls_spk_man_d d " & _
     "left join PROD.dbo.PROD_rls_spk_man_m m " & _
     "on m.no_spk_man = d.no_spk_man and m.no_spk_man_rls = d.no_spk_man_rls " & _
     "and m.kd_kegiatan = d.kd_kegiatan and m.kd_kegiatan_spk = d.kd_kegiatan_spk " & _
     "left join SIF.dbo.SIF_Barang b " & _
     "on b.Kode_Barang = d.kd_barang " & _
     "left join SIF.dbo.SIF_Tipe t on b.kd_tipe = t.Kode_Tipe and b.kd_merk = t.Kode_Merk " & _
     "left join SIF.dbo.SIF_Kain k on b.kd_kain = k.Kode_Kain " & _
     "left join SIF.dbo.SIF_Ukuran u on b.kd_ukuran = u.Kode_Ukuran " & _
     "left join SIF.dbo.SIF_Satuan s on s.Kode_Satuan = b.Kd_Satuan " & _
     "left join PROD.dbo.PROD_spk_m sm " & _
     "on sm.no_spk = m.no_spk_man and sm.kd_kegiatan = m.kd_kegiatan  " & _
     "and sm.kd_kegiatan_spk = m.kd_kegiatan_spk " & _
     "left join (Select Id_Data, Desc_Data from SIF.dbo.SIF_Gen_Reff_D where Ref_Role = 'PROD' " & _
     "and Id_Ref_Data = 'KGTSPK' ) keg " & _
     "on keg.Id_Data = d.kd_kegiatan " & _
     "left join (Select Id_Data, Desc_Data from SIF.dbo.SIF_Gen_Reff_D where Ref_Role = 'PROD' " & _
     "and Id_Ref_Data = 'SPK' ) keg2 " & _
     "on keg2.Id_Data = d.kd_kegiatan_spk " & _
     "where d.kd_departemen ='" & lueDep.EditValue & "' and m.tanggal  between '" & Format(deTglMulai.DateTime, "yyyy/MM/dd") & " 00:00' and '" & Format(deTglSelesai.DateTime, "yyyy/MM/dd") & " 00:00'" & _
     "and sm.no_rph = '" & lueNoRPH.EditValue & "' " & _
     "Group by d.kd_barang, b.Nama_Barang, t.Nama_Tipe, k.Merk_Kain, u.Nama_Ukuran, s.Nama_Satuan "
            dsMon1.Clear()
            daMon1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(strQuery1, sqlconn))
            daMon1.Fill(dsMon1, "monrcnkrm1")
            GC_Rekap.DataSource = dsMon1.Tables("monrcnkrm1")
            gvMain.BestFitColumns()
        End If


    End Sub

    Private Sub deTanggal_DateTimeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles deTglMulai.DateTimeChanged, deTglSelesai.DateTimeChanged
        LoadLUE()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadGrid()
    End Sub
    Public Sub cetak_click()

        frmCetakHasilProduksi.tanggal1 = Format(deTglMulai.DateTime, "yyyy/MM/dd")
        frmCetakHasilProduksi.tanggal2 = Format(deTglSelesai.DateTime, "yyyy/MM/dd")
        'frmCetakHasilProduksi.tanggal1 = deTglMulai.EditValue
        'frmCetakHasilProduksi.tanggal2 = deTglSelesai.EditValue
        frmCetakHasilProduksi.vkddep = lueDep.EditValue
        frmCetakHasilProduksi.ShowDialog()
        'Else

    End Sub
    Private Sub LoadLUE_NoRPH()
        If deTglMulai.DateTime = Nothing Or deTglSelesai.DateTime = Nothing Or (deTglMulai.DateTime = Nothing And deTglSelesai.DateTime = Nothing) Then
        Else
            dsNoRPH.Clear()
            'daNoRPH = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_rph from prod.dbo.prod_rcn_prod_m where tanggal between '" & Format(deTglMulai.DateTime, "yyyy/MM/dd") & " 00:00' and '" & Format(deTglSelesai.DateTime, "yyyy/MM/dd") & " 00:00' and kd_departemen = '" & lueDep.EditValue & "'", sqlconn))
            daNoRPH = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("Select no_rph from (Select  DISTINCT 'ALL' as no_rph from PROD.dbo.PROD_rcn_prod_m  " & _
                                                                            "union " & _
                                                                            "Select DISTINCT sm.no_rph " & _
                                                                            "from PROD.dbo.PROD_rls_spk_man_d d  " & _
                                                                            "left join PROD.dbo.PROD_rls_spk_man_m m  " & _
                                                                            "on m.no_spk_man = d.no_spk_man and m.no_spk_man_rls = d.no_spk_man_rls " & _
                                                                            "and m.kd_kegiatan = d.kd_kegiatan and m.kd_kegiatan_spk = d.kd_kegiatan_spk " & _
                                                                            "left join PROD.dbo.PROD_spk_m sm " & _
                                                                            "on sm.no_spk = m.no_spk_man and sm.kd_kegiatan = m.kd_kegiatan  " & _
                                                                            "and sm.kd_kegiatan_spk = m.kd_kegiatan_spk " & _
                                                                            "left join (Select Id_Data, Desc_Data from SIF.dbo.SIF_Gen_Reff_D where Ref_Role = 'PROD' " & _
                                                                            "and Id_Ref_Data = 'KGTSPK' ) keg " & _
                                                                            "on keg.Id_Data = d.kd_kegiatan  " & _
                                                                            "left join (Select Id_Data, Desc_Data from SIF.dbo.SIF_Gen_Reff_D where Ref_Role = 'PROD' " & _
                                                                            "and Id_Ref_Data = 'SPK' ) keg2 " & _
                                                                            "on keg2.Id_Data = d.kd_kegiatan_spk " & _
                                                                            "where d.kd_departemen ='" & lueDep.EditValue & "' " & _
                                                                            " and  m.tanggal between '" & Format(deTglMulai.DateTime, "yyyy/MM/dd") & " 00:00' and '" & Format(deTglSelesai.DateTime, "yyyy/MM/dd") & " 00:00') a order by no_rph desc ", sqlconn))


            daNoRPH.Fill(dsNoRPH, "NoRPH")
            lueNoRPH.Properties.DataSource = dsNoRPH.Tables("NoRPH")
            lueNoRPH.Properties.ValueMember = "no_rph"
            lueNoRPH.Properties.DisplayMember = "no_rph"
            If dsNoRPH.Tables("NoRPH").Rows.Count = 0 Then
                lueNoRPH.Properties.NullText = "[Data Tidak Ditemukan]"
            Else
                lueNoRPH.Properties.NullText = "[Pilih No. RPH]"
                If lueNoRPH.Text = "[Pilih No. RPH]" Then
                    lueNoRPH.EditValue = "ALL"
                End If
            End If
        End If
    End Sub

    Private Sub deTglSelesai_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTglSelesai.EditValueChanged
        LoadLUE_NoRPH()
    End Sub

    Private Sub lueDep_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueDep.EditValueChanged
        LoadLUE_NoRPH()
    End Sub

    Private Sub lueNoRPH_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueNoRPH.EditValueChanged

    End Sub

    Private Sub deTglMulai_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTglMulai.EditValueChanged
        LoadLUE_NoRPH()
    End Sub
End Class