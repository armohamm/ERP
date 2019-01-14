Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Public Class frmzRlsSpkInsentifService
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Dim tgl As Date
    Dim myBuilder, mb1, mb2 As New SqlCommandBuilder
    Public ds1, ds2, ds3, ds4 As New DataSet
    Public da1, da2, da3, da4, da5, da6, da7, da8 As New SqlDataAdapter
    Dim tabel_peg As DataTable
    Dim jumlah As Double
    Dim dread As SqlDataReader
    Dim notrans_simulasi1 As String
    Dim status_posting As String

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
        'With Me
        '    .btAdd.Enabled = btnadd
        '    .btCancel.Enabled = btnCancel
        '    .btDel.Enabled = btnDelete
        '    .btEdit.Enabled = btnEdit
        '    .btSave.Enabled = btnSave
        'End With
    End Sub
    Private Sub frmSpkMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        'reload()
        If Not ds1.Tables("spkmMaster") Is Nothing Then ds1.Tables("spkmMaster").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rls_spk_man_m where 1=0", sqlconn))
        da2.Fill(ds1, "spkmMaster")
        If Not ds1.Tables("spkmDetil") Is Nothing Then ds1.Tables("spkmDetil").Clear()
        da3 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rls_spk_man_d where 1=0", sqlconn))
        da3.Fill(ds1, "spkmDetil")
        If Not ds1.Tables("spkmDetilSP") Is Nothing Then ds1.Tables("spkmDetilSP").Clear()
        da8 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rls_spk_man_sp where 1=0", sqlconn))
        da8.Fill(ds1, "spkmDetilSP")
        If Not ds1.Tables("spkmDetilPegawai") Is Nothing Then ds1.Tables("spkmDetilPegawai").Clear()
        da5 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rls_spk_man_p where 1=0", sqlconn))
        da5.Fill(ds1, "spkmDetilPegawai")


    End Sub
    Private Sub reload(Optional ByVal notrans As String = "")
        If Not ds1.Tables("nospk") Is Nothing Then ds1.Tables("nospk").Clear()
        If Not ds1.Tables("group") Is Nothing Then ds1.Tables("group").Clear()
        If Not ds1.Tables("jadwal") Is Nothing Then ds1.Tables("jadwal").Clear()
        If Not ds1.Tables("jam") Is Nothing Then ds1.Tables("jam").Clear()
        If Not ds1.Tables("jnsKdKeg") Is Nothing Then ds1.Tables("jnsKdKeg").Clear()
        If Not ds1.Tables("jnsKeg") Is Nothing Then ds1.Tables("jnsKeg").Clear()
        If Not ds1.Tables("jnsBrg") Is Nothing Then ds1.Tables("jnsBrg").Clear()
        If Not ds1.Tables("mesin") Is Nothing Then ds1.Tables("mesin").Clear()
        If Not ds1.Tables("pegawai") Is Nothing Then ds1.Tables("pegawai").Clear()
        If Not ds1.Tables("spkmDetail") Is Nothing Then ds1.Tables("spkmDetail").Clear()
        If Not ds1.Tables("spkmMaster") Is Nothing Then ds1.Tables("spkmMaster").Clear()

        da1 = New SqlDataAdapter(New SqlCommand("select distinct(a.no_spk),a.no_rph " & _
                                               "from PROD.dbo.PROD_spk_m a " & _
                                               "inner join PROD.dbo.PROD_rcn_prod_m m " & _
                                               "on m.no_rph = a.no_rph " & _
                                               "where a.kd_departemen= '" & kddep & "' and m.jns_produksi = 'SERVICE' " & _
                                               "or a.kd_departemen= '" & kddep & "' and m.jns_produksi is null and (a.sts_centi='N' or a.sts_centi is NULL) order by no_spk", sqlconn))
        da1.Fill(ds1, "nospk")
        txtNoSpk.Properties.DataSource = ds1.Tables("nospk")

        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where id_ref_file='GRPKERJA'", sqlconn))
        da1.Fill(ds1, "group")
        txtGroup.Properties.DataSource = ds1.Tables("group")

        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='JAMPROD'", sqlconn))
        da1.Fill(ds1, "jam")
        txtJam.Properties.DataSource = ds1.Tables("jam")

        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='JDWKRJ'", sqlconn))
        da1.Fill(ds1, "jadwal")
        txtJadwal.Properties.DataSource = ds1.Tables("jadwal")

        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Pegawai order by Nama_Pegawai", sqlconn))
        da1.Fill(ds1, "pegawai")
        txtPegawai.Properties.DataSource = ds1.Tables("pegawai")

        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where id_ref_file='KGTSPK'", sqlconn))
        da1.Fill(ds1, "jnsKdKeg")
        txtkgtn.Properties.DataSource = ds1.Tables("jnsKdKeg")

        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where id_ref_file='SPK'", sqlconn))
        da1.Fill(ds1, "jnsKeg")
        txtKegiatan.Properties.DataSource = ds1.Tables("jnsKeg")

        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_mesin_prod order by deskripsi ", sqlconn))
        da1.Fill(ds1, "mesin")
        txtMesin.Properties.DataSource = ds1.Tables("mesin")

        'da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_jenis_barang where kd_departemen='" & kddep & "'", sqlconn))
        'da1.Fill(ds1, "jnsBrg")

        gc.DataSource = Nothing
    End Sub

    Private Sub isiDetil()
        'MsgBox("d.kd_kegiatan='" & txtkgtn.EditValue & "' and d.kd_kegiatan_spk='" & txtKegiatan.EditValue & "'")
        ds1.Relations.Clear()
        If Not ds1.Tables("sobox") Is Nothing Then ds1.Tables("sobox").Clear()
        If Not ds1.Tables("detil1") Is Nothing Then ds1.Tables("detil1").Clear()
        If Not ds1.Tables("detil") Is Nothing Then ds1.Tables("detil").Clear()
        'da1 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_spk_d where no_spk='" & txtNoSpk.EditValue & "'", sqlconn))
        'da1 = New SqlDataAdapter(New SqlCommand("select distinct d.kd_barang,d.no_urut_brg,b.nama_barang,t.nama_tipe,m.merk_kain,u.nama_ukuran,d.jumlah_produksi as jumlah_realisasi,(d.jumlah_produksi- isnull(c.jumlah_kerja,0)) as sisa_rencana_prod,0.00 as jumlah_kerja, d.jumlah_sisa as jumlah_sisa,0.00 as jumlah_rework,0.00 as jumlah_delay,ISNULL(k.nilai_konv,1) * isnull(c.jumlah_kerja,1) as indeks " & _
        '                "from PROD.dbo.PROD_spk_d d " & _
        '                 "left join(Select SUM(jumlah_kerja)as jumlah_kerja,no_spk_man,kd_kegiatan, kd_kegiatan_spk, " & _
        '                                           "kd_barang from prod.dbo.prod_rls_spk_man_d  " & _
        '                                           "Group by no_spk_man,kd_kegiatan,kd_kegiatan_spk,kd_barang ) c " & _
        '                                          "on (d.no_spk = c.no_spk_man) " & _
        '                                           "and (d.kd_kegiatan = c.kd_kegiatan) " & _
        '                                           " and (d.kd_kegiatan_spk = c.kd_kegiatan_spk) " & _
        '                                           "and (d.kd_barang = c.kd_barang) " & _
        '                                           "left join SIF.dbo.Sif_barang b on d.kd_barang=b.kode_barang " & _
        '                "left join sif.dbo.sif_tipe t on b.kd_tipe=t.kode_tipe " & _
        '                "left join sif.dbo.sif_kain m on b.kd_kain=m.kode_kain " & _
        '                 "left join SIF.dbo.SIF_konv_prod k " & _
        '                "on k.jns_kegiatan = '01' and k.kd_kegiatan = d.kd_kegiatan_spk and b.kd_jenis = k.kd_jenis " & _
        '                "and k.kd_ukuran = b.kd_ukuran and k.kd_tipe = b.kd_tipe and k.kd_subtipe = b.kd_sub_tipe" & _
        '                "left join sif.dbo.SIF_ukuran u on b.kd_ukuran=u.kode_ukuran " & _
        '                "where d.no_spk='" & txtNoSpk.EditValue & "' and d.kd_kegiatan='" & txtkgtn.EditValue & "' and d.kd_kegiatan_spk='" & txtKegiatan.EditValue & "'", sqlconn))
        'da1.Fill(ds1, "detil")
        'da1 = New SqlDataAdapter(New SqlCommand("select distinct d.kd_barang,d.no_urut_brg,b.nama_barang,t.nama_tipe,m.merk_kain,u.nama_ukuran,d.jumlah_produksi as jumlah_realisasi,(d.jumlah_produksi- isnull(c.jumlah_kerja,0)) as sisa_rencana_prod,0.00 as jumlah_kerja, d.jumlah_sisa as jumlah_sisa,0.00 as jumlah_rework,0.00 as jumlah_delay,isnull(c.jumlah_kerja,1) as indeks " & _
        '                "from PROD.dbo.PROD_spk_d d " & _
        '                 "left join(Select SUM(jumlah_kerja)as jumlah_kerja,no_spk_man,kd_kegiatan, kd_kegiatan_spk, " & _
        '                                           "kd_barang from prod.dbo.prod_rls_spk_man_d  " & _
        '                                           "Group by no_spk_man,kd_kegiatan,kd_kegiatan_spk,kd_barang ) c " & _
        '                                          "on (d.no_spk = c.no_spk_man) " & _
        '                                           "and (d.kd_kegiatan = c.kd_kegiatan) " & _
        '                                           " and (d.kd_kegiatan_spk = c.kd_kegiatan_spk) " & _
        '                                           "and (d.kd_barang = c.kd_barang) " & _
        '                                           "left join SIF.dbo.Sif_barang b on d.kd_barang=b.kode_barang " & _
        '                "left join sif.dbo.sif_tipe t on b.kd_tipe=t.kode_tipe " & _
        '                "left join sif.dbo.sif_kain m on b.kd_kain=m.kode_kain " & _
        '                "left join sif.dbo.SIF_ukuran u on b.kd_ukuran=u.kode_ukuran " & _
        '                "where d.no_spk='" & txtNoSpk.EditValue & "' and d.kd_kegiatan='" & txtkgtn.EditValue & "' and d.kd_kegiatan_spk='" & txtKegiatan.EditValue & "'", sqlconn))
        'da1.Fill(ds1, "detil")

        da1 = New SqlDataAdapter(New SqlCommand(" select distinct d.no_sp, d.no_sp_dtl,d.no_seq, d.kd_barang,d.no_urut_brg,b.nama_barang,d.keterangan ket_barang,t.nama_tipe,m.merk_kain,u.nama_ukuran, " & _
                                                "d.jumlah as jumlah_realisasi, (d.jumlah - isnull(c.jumlah_kerja,0)) as sisa_rencana_prod, " & _
                                                "0.00 as jumlah_kerja, 0.00 jumlah_sisa,0.00 as jumlah_rework, " & _
                                                "0.00 as jumlah_delay,isnull(c.jumlah_kerja,1) as indeks  from PROD.dbo.PROD_spk_sp d " & _
                                                "left join(Select SUM(sp.jumlah)as jumlah_kerja,sp.no_spk_man,sp.kd_kegiatan, sp.kd_kegiatan_spk, " & _
                                                "sp.no_sp,sp.no_sp_dtl,sp.no_seq,sp.kd_barang,sp.no_urut from prod.dbo.PROD_rls_spk_man_sp sp " & _
                                                "Group by sp.no_spk_man,sp.kd_kegiatan, sp.kd_kegiatan_spk,  sp.no_sp,sp.no_sp_dtl,sp.no_seq,sp.kd_barang,sp.no_urut) c " & _
                                                "on (d.no_spk = c.no_spk_man) and (d.kd_kegiatan = c.kd_kegiatan)  and (d.kd_kegiatan_spk = c.kd_kegiatan_spk) " & _
                                                "and (d.kd_barang = c.kd_barang) and (d.no_sp = c.no_sp) and (d.no_sp_dtl = c.no_sp_dtl)  " & _
                                                "and (d.no_seq = c.no_seq)  left join SIF.dbo.Sif_barang b on d.kd_barang=b.kode_barang  " & _
                                                "left join sif.dbo.sif_tipe t on b.kd_tipe=t.kode_tipe  left join sif.dbo.sif_kain m on b.kd_kain=m.kode_kain " & _
                                                "left join sif.dbo.SIF_ukuran u on b.kd_ukuran=u.kode_ukuran  where d.no_spk='" & txtNoSpk.EditValue & "' and d.kd_kegiatan='" & txtkgtn.EditValue & "'", sqlconn))
        da1.Fill(ds1, "detil")

        da1 = New SqlDataAdapter(New SqlCommand(" select  d.no_sp, d.no_sp_dtl,d.no_seq, d.kd_barang,d.kd_kegiatan_spk,srv.nama_service,d.no_urut_brg,d.keterangan nama_barang,t.nama_tipe,m.merk_kain,u.nama_ukuran, " & _
                                               "d.jumlah as jumlah_realisasi, (d.jumlah - isnull(c.jumlah_kerja,0)) as sisa_rencana_prod, " & _
                                               "0.00 as jumlah_kerja, 0.00 jumlah_sisa,0.00 as jumlah_rework, " & _
                                               "0.00 as jumlah_delay,isnull(c.jumlah_kerja,1) as indeks  from PROD.dbo.PROD_spk_sp d " & _
                                               "left join(Select SUM(sp.jumlah)as jumlah_kerja,sp.no_spk_man,sp.kd_kegiatan, sp.kd_kegiatan_spk, " & _
                                               "sp.no_sp,sp.no_sp_dtl,sp.no_seq,sp.kd_barang,sp.no_urut from prod.dbo.PROD_rls_spk_man_sp sp " & _
                                               "Group by sp.no_spk_man,sp.kd_kegiatan, sp.kd_kegiatan_spk,  sp.no_sp,sp.no_sp_dtl,sp.no_seq,sp.kd_barang,sp.no_urut) c " & _
                                               "on (d.no_spk = c.no_spk_man) and (d.kd_kegiatan = c.kd_kegiatan)  and (d.kd_kegiatan_spk = c.kd_kegiatan_spk) " & _
                                               "and (d.kd_barang = c.kd_barang) and (d.no_sp = c.no_sp) and (d.no_sp_dtl = c.no_sp_dtl)  " & _
                                               "and (d.no_seq = c.no_seq)  left join SIF.dbo.Sif_barang b on d.kd_barang=b.kode_barang  " & _
                                               "left join sif.dbo.sif_tipe t on b.kd_tipe=t.kode_tipe  left join sif.dbo.sif_kain m on b.kd_kain=m.kode_kain " & _
                                               "left join sif.dbo.SIF_bom_service srv on srv.kd_service = d.kd_kegiatan_spk " & _
                                               "left join sif.dbo.SIF_ukuran u on b.kd_ukuran=u.kode_ukuran  where d.no_spk='" & txtNoSpk.EditValue & "' and d.kd_kegiatan='" & txtkgtn.EditValue & "'  ORDER BY d.no_sp,d.no_sp_dtl ASC ", sqlconn))
        da1.Fill(ds1, "detil1")

        da1 = New SqlDataAdapter(New SqlCommand("Select b.*, br.Nama_Barang,br.Kd_Satuan " & _
                                                  "From SALES.dbo.SALES_BOM_SERVICE b " & _
                                                  "left Join SIF.dbo.SIF_Barang br " & _
                                                  "on br.Kode_Barang = b.KD_BARANG", sqlconn))
        da1.Fill(ds1, "SOBOX")

        Dim colM(4) As DataColumn
        Dim colD(4) As DataColumn
        Dim colD1(2) As DataColumn
        Dim colD2(2) As DataColumn
        Dim rel, rel1 As DataRelation
        'Dim rel As DataRelation

        colM(0) = ds1.Tables("detil").Columns("no_sp")
        colM(1) = ds1.Tables("detil").Columns("no_sp_dtl")
        colM(2) = ds1.Tables("detil").Columns("no_seq")
        colM(3) = ds1.Tables("detil").Columns("kd_barang")
        colM(4) = ds1.Tables("detil").Columns("no_urut_brg")

        colD(0) = ds1.Tables("detil1").Columns("no_sp")
        colD(1) = ds1.Tables("detil1").Columns("no_sp_dtl")
        colD(2) = ds1.Tables("detil1").Columns("no_seq")
        colD(3) = ds1.Tables("detil1").Columns("kd_barang")
        colD(4) = ds1.Tables("detil1").Columns("no_urut_brg")

        colD1(0) = ds1.Tables("detil1").Columns("no_sp")
        colD1(1) = ds1.Tables("detil1").Columns("no_sp_dtl")
        colD1(2) = ds1.Tables("detil1").Columns("kd_kegiatan_spk")


        colD2(0) = ds1.Tables("SOBOX").Columns("NO_SP")
        colD2(1) = ds1.Tables("SOBOX").Columns("NO_SEQ_SP")
        colD2(2) = ds1.Tables("SOBOX").Columns("Kd_Service")

        rel = ds1.Relations.Add("Detail Services", colM, colD, False)
        rel1 = ds1.Relations.Add("Detail BOM Services", colD1, colD2, False)
        gc.LevelTree.Nodes.Add("Detail Services", GV_Detail).Nodes.Add("Detail BOM Services", GV_BOM)

        'da1 = New SqlDataAdapter(New SqlCommand("select distinct d.jumlah_produksi,d.no_spk,d.kd_kegiatan " & _
        '                "from PROD.dbo.PROD_spk_d d " & _
        '                "left join SIF.dbo.Sif_barang b on d.kd_barang=b.kode_barang " & _
        '                "left join sif.dbo.sif_tipe t on b.kd_tipe=t.kode_tipe " & _
        '                "left join sif.dbo.sif_kain m on b.kd_kain=m.kode_kain " & _
        '                "left join sif.dbo.SIF_ukuran u on b.kd_ukuran=u.kode_ukuran " & _
        '                "where d.no_spk='" & txtNoSpk.EditValue & "' and d.kd_kegiatan='" & txtkgtn.EditValue & "' and d.kd_kegiatan_spk='" & txtKegiatan.EditValue & "' group by d.jumlah_produksi,d.no_spk,d.kd_kegiatan", sqlconn))
        'da1.Fill(ds1, "cekProduksi")
        ''MsgBox("d.no_spk_man='" & txtNoSpk.EditValue & "' and d.kd_kegiatan='" & txtkgtn.EditValue & "'")
        'da1 = New SqlDataAdapter(New SqlCommand("select sum(d.jumlah_kerja)as jumlah_kerja,d.no_spk_man,d.kd_kegiatan " & _
        '        "from PROD.dbo.PROD_rls_spk_man_d d " & _
        '        "left join SIF.dbo.Sif_barang b on d.kd_barang=b.kode_barang " & _
        '        "left join sif.dbo.sif_tipe t on b.kd_tipe=t.kode_tipe " & _
        '        "left join sif.dbo.sif_kain m on b.kd_kain=m.kode_kain " & _
        '        "left join sif.dbo.SIF_ukuran u on b.kd_ukuran=u.kode_ukuran " & _
        '        "where d.no_spk_man='" & txtNoSpk.EditValue & "' and d.kd_kegiatan='" & txtkgtn.EditValue & "' group by d.kd_kegiatan,d.no_spk_man", sqlconn))
        'da1.Fill(ds1, "cekKerja")
        'MsgBox(txtNoSpk.EditValue & "-" & txtkgtn.EditValue)
        'If ds1.Tables("cekKerja").Rows.Count > 0 Then
        '    For i As Integer = 0 To ds1.Tables("detil").Rows.Count - 1
        '        ds1.Tables("detil").Rows(i).Item("jumlah_realisasi") = CInt(ds1.Tables("detil").Rows(i).Item("jumlah_realisasi")) - CInt(ds1.Tables("cekKerja").Rows(i).Item("jumlah_kerja"))
        '    Next
        'End If
        gc.DataSource = ds1.Tables("detil")
    End Sub

    Private Sub txtNoSpk_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoSpk.EditValueChanged, txtkgtn.EditValueChanged, txtKegiatan.EditValueChanged
        If sender.EditValue <> Nothing Then
            If State = "ADD" Then
                'txtGroup.EditValue = Nothing
                'txtPegawai.EditValue = Nothing
                'txtJadwal.EditValue = Nothing
                'txtkgtn.EditValue = Nothing
                'txtKegiatan.EditValue = Nothing
                'txtMesin.EditValue = Nothing

                If Not ds1.Tables("jadwal") Is Nothing Then ds1.Tables("jadwal").Clear()
                If Not ds1.Tables("jnsKdKeg") Is Nothing Then ds1.Tables("jnsKdKeg").Clear()
                If Not ds1.Tables("kd_keg") Is Nothing Then ds1.Tables("kd_keg").Clear()
                If Not ds1.Tables("jnsKeg") Is Nothing Then ds1.Tables("jnsKeg").Clear()

                'dread = New SqlClient.SqlCommand("select * FROM " & _
                '            "(select distinct(no_rph)  from PROD.dbo.PROD_spk_m where no_spk='" & txtNoSpk.EditValue & "' ) spk " & _
                '            "left join  " & _
                '            "(select no_rph, kd_jadwal from PROD.dbo.PROD_rcn_prod_m) rph " & _
                '            "on spk.no_rph=rph.no_rph", sqlconn).ExecuteReader
                'dread.Read()
                'txtJadwal.EditValue = dread.Item("kd_jadwal")
                'dread.Close()

                'da1 = New SqlDataAdapter(New SqlCommand("select distinct(spk.kd_kegiatan) Id_Data, reff.Desc_Data from SIF.dbo.SIF_Gen_Reff_D reff  " & _
                '                                        "left join PROD.dbo.PROD_spk_m spk on reff.Id_Data=spk.kd_kegiatan  " & _
                '                                        "where spk.no_spk='" & txtNoSpk.EditValue & "' and reff.Id_Ref_Data='KGTSPK'", sqlconn))

                da1 = New SqlDataAdapter(New SqlCommand("Select subquery1.Id_Data, subquery1.Desc_Data from " & _
                                                        "(select distinct(spk.kd_kegiatan) Id_Data, reff.Desc_Data , " & _
                                                        "isnull(a.jumlah_kerja,0) as jumlah_kerja, " & _
                                                        "sum(spk.jumlah) as jumlah_prod " & _
                                                        "from SIF.dbo.SIF_Gen_Reff_D reff " & _
                                                        "left join PROD.dbo.PROD_spk_m spk  " & _
                                                        "on reff.Id_Data=spk.kd_kegiatan " & _
                                                        "left join (Select d.no_spk_man, d.kd_kegiatan, sum(d.jumlah_kerja) as jumlah_kerja, " & _
                                                        "reff.Desc_Data from PROD.dbo.PROD_rls_spk_man_d d " & _
                                                        "left join SIF.dbo.SIF_Gen_Reff_D reff  " & _
                                                        "on reff.Id_Data = d.kd_kegiatan " & _
                                                        "where reff.Id_Ref_Data='KGTSPK' " & _
                                                        "group by d.no_spk_man,d.kd_kegiatan,reff.Desc_Data) a " & _
                                                        "on a.no_spk_man = spk.no_spk and a.kd_kegiatan = spk.kd_kegiatan " & _
                                                        "where spk.no_spk='" & txtNoSpk.EditValue & "' and reff.Id_Ref_Data='KGTSPK' " & _
                                                        "group by spk.kd_kegiatan, reff.Desc_Data, a.jumlah_kerja) subquery1 " & _
                                                        "where subquery1.jumlah_kerja < subquery1.jumlah_prod", sqlconn))

                da1.Fill(ds1, "jnsKdKeg")
                txtkgtn.Properties.DataSource = ds1.Tables("jnsKdKeg")
                txtkgtn.Properties.ReadOnly = False
                txtGroup.Properties.ReadOnly = False
                txtPegawai.Properties.ReadOnly = False
                txtMesin.Properties.ReadOnly = False

                da1 = New SqlDataAdapter(New SqlCommand("select kd_kegiatan from PROD.dbo.PROD_spk_m where no_spk='" & txtNoSpk.EditValue & "'", sqlconn)) ' and Id_Data='"&  &"'
                da1.Fill(ds1, "kd_keg")
                da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='JDWKRJ' and Id_Data='" & ds1.Tables("kd_keg").Rows(0).Item(0).ToString & "'", sqlconn))
                da1.Fill(ds1, "jadwal")

                txtJadwal.Properties.DataSource = ds1.Tables("jadwal")
                txtJadwal.Properties.ReadOnly = False

                'da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D reff  " & _
                '        "left join PROD.dbo.PROD_spk_m spk on reff.Id_Data=spk.kd_kegiatan_spk " & _
                '        "where spk.no_spk='" & txtNoSpk.EditValue & "' and kd_kegiatan='" & txtkgtn.EditValue & "' and reff.id_ref_file='SPK' ", sqlconn))

                'da1 = New SqlDataAdapter(New SqlCommand("Select subquery1.Id_Data, subquery1.Desc_Data from " & _
                '                                        "(select distinct(spk.kd_kegiatan_spk) Id_Data, reff.Desc_Data , " & _
                '                                        "isnull(a.jumlah_kerja,0) as jumlah_kerja, " & _
                '                                        "sum(spk.jumlah) as jumlah_prod  " & _
                '                                        "from SIF.dbo.SIF_Gen_Reff_D reff " & _
                '                                        "left join PROD.dbo.PROD_spk_m spk " & _
                '                                        "on reff.Id_Data=spk.kd_kegiatan_spk " & _
                '                                        "left join (Select d.no_spk_man, d.kd_kegiatan,d.kd_kegiatan_spk, sum(d.jumlah_kerja) as jumlah_kerja, " & _
                '                                        "reff.Desc_Data, reff1.Desc_Data as SPK " & _
                '                                        "from PROD.dbo.PROD_rls_spk_man_d d " & _
                '                                        "left join SIF.dbo.SIF_Gen_Reff_D reff " & _
                '                                        "on reff.Id_Data = d.kd_kegiatan " & _
                '                                        "left join SIF.dbo.SIF_Gen_Reff_D reff1 " & _
                '                                        "on reff1.Id_Data = d.kd_kegiatan_spk " & _
                '                                        "where reff1.Id_Ref_Data='SPK' and reff.Id_Ref_Data='KGTSPK' " & _
                '                                        "group by d.no_spk_man,d.kd_kegiatan,d.kd_kegiatan_spk,reff.Desc_Data, reff1.Desc_Data) a " & _
                '                                        "on a.no_spk_man = spk.no_spk and a.kd_kegiatan = spk.kd_kegiatan " & _
                '                                        "and a.kd_kegiatan_spk = spk.kd_kegiatan_spk " & _
                '                                        "where spk.no_spk='" & txtNoSpk.EditValue & "' and spk.kd_kegiatan ='" & txtkgtn.EditValue & "' and reff.Id_Ref_Data='SPK' " & _
                '                                        "group by spk.kd_kegiatan_spk , reff.Desc_Data, a.jumlah_kerja) subquery1 " & _
                '                                        "where subquery1.jumlah_kerja < subquery1.jumlah_prod ", sqlconn))

                'Sementara dimatikan
                'da1 = New SqlDataAdapter(New SqlCommand("Select subquery1.Id_Data, subquery1.Desc_Data from (select distinct(spk.kd_kegiatan_spk) Id_Data, reff.nama_service Desc_Data , " & _
                '                                        "isnull(a.jumlah_kerja,0) as jumlah_kerja, sum(spk.jumlah) as jumlah_prod  " & _
                '                                        "from SIF.dbo.SIF_bom_service reff " & _
                '                                        "left join PROD.dbo.PROD_spk_m spk on reff.kd_service=spk.kd_kegiatan_spk  " & _
                '                                        "left join (Select d.no_spk_man, d.kd_kegiatan,d.kd_kegiatan_spk, sum(d.jumlah_kerja) as jumlah_kerja, " & _
                '                                        "reff.Desc_Data, reff1.nama_service as SPK from PROD.dbo.PROD_rls_spk_man_d d " & _
                '                                        "left join SIF.dbo.SIF_Gen_Reff_D reff on reff.Id_Data = d.kd_kegiatan " & _
                '                                        "left join SIF.dbo.SIF_bom_service reff1 on reff1.kd_service = d.kd_kegiatan_spk  " & _
                '                                        "where reff.Id_Ref_Data='KGTSPK' " & _
                '                                        "group by d.no_spk_man,d.kd_kegiatan,d.kd_kegiatan_spk,reff.Desc_Data, reff1.nama_service) a  " & _
                '                                        "on a.no_spk_man = spk.no_spk and a.kd_kegiatan = spk.kd_kegiatan " & _
                '                                        "and a.kd_kegiatan_spk = spk.kd_kegiatan_spk where spk.no_spk='" & txtNoSpk.EditValue & "' " & _
                '                                        "and spk.kd_kegiatan ='" & txtkgtn.EditValue & "' " & _
                '                                        "group by spk.kd_kegiatan_spk , " & _
                '                                        "reff.nama_service, a.jumlah_kerja) subquery1 where subquery1.jumlah_kerja < subquery1.jumlah_prod ", sqlconn))

                'da1.Fill(ds1, "jnsKeg")
                'txtKegiatan.Properties.DataSource = ds1.Tables("jnsKeg")
                'txtKegiatan.Properties.ReadOnly = False

                isiDetil()
            ElseIf State = "EDIT" Then

                If Not ds1.Tables("jadwal") Is Nothing Then ds1.Tables("jadwal").Clear()
                If Not ds1.Tables("jnsKdKeg") Is Nothing Then ds1.Tables("jnsKdKeg").Clear()
                If Not ds1.Tables("kd_keg") Is Nothing Then ds1.Tables("kd_keg").Clear()
                If Not ds1.Tables("jnsKeg") Is Nothing Then ds1.Tables("jnsKeg").Clear()


                da1 = New SqlDataAdapter(New SqlCommand("select distinct(spk.kd_kegiatan) Id_Data, reff.Desc_Data from SIF.dbo.SIF_Gen_Reff_D reff  " & _
                                                        "left join PROD.dbo.PROD_spk_m spk on reff.Id_Data=spk.kd_kegiatan  " & _
                                                        "where spk.no_spk='" & txtNoSpk.EditValue & "' and reff.Id_Ref_Data='KGTSPK'", sqlconn))

                'da1 = New SqlDataAdapter(New SqlCommand("Select subquery1.Id_Data, subquery1.Desc_Data from " & _
                '                                        "(select distinct(spk.kd_kegiatan) Id_Data, reff.Desc_Data , " & _
                '                                        "isnull(a.jumlah_kerja,0) as jumlah_kerja, " & _
                '                                        "sum(spk.jumlah) as jumlah_prod " & _
                '                                        "from SIF.dbo.SIF_Gen_Reff_D reff " & _
                '                                        "left join PROD.dbo.PROD_spk_m spk  " & _
                '                                        "on reff.Id_Data=spk.kd_kegiatan " & _
                '                                        "left join (Select d.no_spk_man, d.kd_kegiatan, sum(d.jumlah_kerja) as jumlah_kerja, " & _
                '                                        "reff.Desc_Data from PROD.dbo.PROD_rls_spk_man_d d " & _
                '                                        "left join SIF.dbo.SIF_Gen_Reff_D reff  " & _
                '                                        "on reff.Id_Data = d.kd_kegiatan " & _
                '                                        "where reff.Id_Ref_Data='KGTSPK' " & _
                '                                        "group by d.no_spk_man,d.kd_kegiatan,reff.Desc_Data) a " & _
                '                                        "on a.no_spk_man = spk.no_spk and a.kd_kegiatan = spk.kd_kegiatan " & _
                '                                        "where spk.no_spk='" & txtNoSpk.EditValue & "' and reff.Id_Ref_Data='KGTSPK' " & _
                '                                        "group by spk.kd_kegiatan, reff.Desc_Data, a.jumlah_kerja) subquery1 " & _
                '                                        "where subquery1.jumlah_kerja < subquery1.jumlah_prod", sqlconn))

                da1.Fill(ds1, "jnsKdKeg")
                txtkgtn.Properties.DataSource = ds1.Tables("jnsKdKeg")
                txtkgtn.Properties.ReadOnly = False
                txtGroup.Properties.ReadOnly = False
                txtPegawai.Properties.ReadOnly = False
                txtMesin.Properties.ReadOnly = False

                da1 = New SqlDataAdapter(New SqlCommand("select kd_kegiatan from PROD.dbo.PROD_spk_m where no_spk='" & txtNoSpk.EditValue & "'", sqlconn)) ' and Id_Data='"&  &"'
                da1.Fill(ds1, "kd_keg")
                da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='JDWKRJ' and Id_Data='" & ds1.Tables("kd_keg").Rows(0).Item(0).ToString & "'", sqlconn))
                da1.Fill(ds1, "jadwal")

                txtJadwal.Properties.DataSource = ds1.Tables("jadwal")
                txtJadwal.Properties.ReadOnly = False

                da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D reff  " & _
                        "left join PROD.dbo.PROD_spk_m spk on reff.Id_Data=spk.kd_kegiatan_spk " & _
                        "where spk.no_spk='" & txtNoSpk.EditValue & "' and kd_kegiatan='" & txtkgtn.EditValue & "' and reff.id_ref_file='SPK' ", sqlconn))

                'da1 = New SqlDataAdapter(New SqlCommand("Select subquery1.Id_Data, subquery1.Desc_Data from " & _
                '                                        "(select distinct(spk.kd_kegiatan_spk) Id_Data, reff.Desc_Data , " & _
                '                                        "isnull(a.jumlah_kerja,0) as jumlah_kerja, " & _
                '                                        "sum(spk.jumlah) as jumlah_prod  " & _
                '                                        "from SIF.dbo.SIF_Gen_Reff_D reff " & _
                '                                        "left join PROD.dbo.PROD_spk_m spk " & _
                '                                        "on reff.Id_Data=spk.kd_kegiatan_spk " & _
                '                                        "left join (Select d.no_spk_man, d.kd_kegiatan,d.kd_kegiatan_spk, sum(d.jumlah_kerja) as jumlah_kerja, " & _
                '                                        "reff.Desc_Data, reff1.Desc_Data as SPK " & _
                '                                        "from PROD.dbo.PROD_rls_spk_man_d d " & _
                '                                        "left join SIF.dbo.SIF_Gen_Reff_D reff " & _
                '                                        "on reff.Id_Data = d.kd_kegiatan " & _
                '                                        "left join SIF.dbo.SIF_Gen_Reff_D reff1 " & _
                '                                        "on reff1.Id_Data = d.kd_kegiatan_spk " & _
                '                                        "where reff1.Id_Ref_Data='SPK' and reff.Id_Ref_Data='KGTSPK' " & _
                '                                        "group by d.no_spk_man,d.kd_kegiatan,d.kd_kegiatan_spk,reff.Desc_Data, reff1.Desc_Data) a " & _
                '                                        "on a.no_spk_man = spk.no_spk and a.kd_kegiatan = spk.kd_kegiatan " & _
                '                                        "and a.kd_kegiatan_spk = spk.kd_kegiatan_spk " & _
                '                                        "where spk.no_spk='" & txtNoSpk.EditValue & "' and spk.kd_kegiatan ='" & txtkgtn.EditValue & "' and reff.Id_Ref_Data='SPK' " & _
                '                                        "group by spk.kd_kegiatan_spk , reff.Desc_Data, a.jumlah_kerja) subquery1 " & _
                '                                        "where subquery1.jumlah_kerja < subquery1.jumlah_prod ", sqlconn))


                da1.Fill(ds1, "jnsKeg")
                txtKegiatan.Properties.DataSource = ds1.Tables("jnsKeg")
                txtKegiatan.Properties.ReadOnly = False

                isiDetil()

            End If

        End If

    End Sub

    Public Sub add_click()
        State = "ADD"
        reload()
        txtTgl.DateTime = Date.Today
        txtNoSpkRls.Text = ""
        txtTgl.Enabled = True
        txtNoSpk.Properties.ReadOnly = False
        txtGroup.Properties.ReadOnly = False
        txtPegawai.Properties.ReadOnly = False
        txtJadwal.Properties.ReadOnly = False
        txtkgtn.Properties.ReadOnly = False
        txtKegiatan.Properties.ReadOnly = False
        txtMesin.Properties.ReadOnly = False

        txtNoSpk.EditValue = Nothing
        txtGroup.EditValue = Nothing
        txtPegawai.EditValue = Nothing
        txtJadwal.EditValue = Nothing
        txtkgtn.EditValue = Nothing
        txtKegiatan.EditValue = Nothing
        txtMesin.EditValue = Nothing

        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False

        setStatus()
    End Sub

    Public Sub edit_click()
        Dim qstr As String = "select distinct m.tanggal [Tanggal_Realisasi], m.no_spk_man_rls [No_SPK_Rls],m.no_spk_man [No_SPK], " & _
            "sm.tanggal [Tanggal_SPK], g.Desc_Data [KEGIATAN],g1.Desc_Data [KEGIATAN_SPK],p.Nama_Pegawai [PEGAWAI], " & _
            "g2.Desc_Data [GROUP_KERJA],u.kd_mesin [MESIN],s.no_rph [NO_RPH], " & _
            "sts_posting = CASE when d.no_posting  Is NOT NULL THEN 'Sudah Posting' else '' end " & _
            "from PROD.dbo.PROD_rls_spk_man_m m " & _
            "left join PROD.dbo.PROD_rls_spk_man_d d " & _
            "on d.no_spk_man = m.no_spk_man and d.no_spk_man_rls = m.no_spk_man_rls  " & _
            "and d.kd_kegiatan = m.kd_kegiatan and d.kd_kegiatan_spk = m.kd_kegiatan_spk " & _
            "left join SIF.dbo.SIF_Gen_Reff_D g " & _
            "on g.Id_Data=m.kd_kegiatan " & _
            "left join PROD.dbo.PROD_spk_m sm " & _
            "on sm.no_spk = m.no_spk_man and sm.kd_kegiatan = m.kd_kegiatan " & _
            "and sm.kd_kegiatan_spk = m.kd_kegiatan_spk " & _
            "left join SIF.dbo.SIF_Gen_Reff_D g1 " & _
            "on g1.Id_Data=m.kd_kegiatan_spk " & _
            "left join SIF.dbo.SIF_Gen_Reff_D g2 " & _
            "on g2.Id_Data=m.group_kerja " & _
            "left join SIF.dbo.SIF_Pegawai p " & _
            "on p.Kode_Pegawai=m.kd_pegawai " & _
            "left join SIF.dbo.SIF_mesin_prod u " & _
            "on u.kd_mesin=m.kd_mesin " & _
            "left join PROD.dbo.PROD_spk_m s " & _
            "on s.no_spk=m.no_spk_man " & _
            "and s.kd_kegiatan=m.kd_kegiatan " & _
            "and s.kd_kegiatan_spk=m.kd_kegiatan_spk " & _
            "where (m.sts_centi='N' or m.sts_centi is NULL) and g1.Id_Ref_File='SPK' and s.no_rph is not null " & _
            "and g.Id_Ref_File='KGTSPK' and m.kd_departemen='" & kddep & "' and g2.Id_Ref_File='GRPKERJA' " & _
            "order by m.tanggal  "

        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(qstr, sqlconn))
        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        da1.Fill(ds3, "lookup_so")

        frmCari.set_dso(ds3.Tables("lookup_so"))

        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            State = "EDIT"
            reload()
            If Not ds1.Tables("nospk") Is Nothing Then ds1.Tables("nospk").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("select distinct(no_spk_man_rls), no_spk_man as no_spk from PROD.dbo.PROD_rls_spk_man_m order by no_spk_man", sqlconn))
            da1.Fill(ds1, "nospk")
            txtNoSpk.Properties.DataSource = ds1.Tables("nospk")

            status_posting = frmCari.row("sts_posting")


            If Not ds1.Tables("spkmMaster") Is Nothing Then ds1.Tables("spkmMaster").Clear()
            qstr = "select P.* from PROD.dbo.PROD_rls_spk_man_m P where P.no_spk_man_rls='" & frmCari.row("No_SPK_Rls") & "'"
            If Not ds1.Tables("spkmMaster") Is Nothing Then ds1.Tables("spkmMaster").Clear()
            da2 = New SqlDataAdapter(New SqlCommand(qstr, sqlconn))
            da2.Fill(ds1, "spkmMaster")
            Dim rowm As DataRow = ds1.Tables("spkmMaster").Rows(0)

            'dread = New SqlClient.SqlCommand("select * FROM " & _
            '                "(select distinct(no_rph)  from PROD.dbo.PROD_spk_m where no_spk='" & frmCari.row("No SPK") & "' ) spk " & _
            '                "left join  " & _
            '                "(select no_rph, kd_jadwal from PROD.dbo.PROD_rcn_prod_m) rph " & _
            '                "on spk.no_rph=rph.no_rph", sqlconn).ExecuteReader
            'dread.Read()
            'txtJadwal.EditValue = dread.Item("kd_jadwal")
            'dread.Close()

            txtNoSpkRls.Text = rowm("no_spk_man_rls")
            txtTgl.DateTime = rowm("tanggal")
            txtNoSpk.EditValue = rowm("no_spk_man")
            txtGroup.EditValue = rowm("group_kerja")
            txtPegawai.EditValue = rowm("kd_pegawai")
            txtMesin.EditValue = rowm("kd_mesin")
            txtKegiatan.EditValue = rowm("kd_kegiatan_spk")
            txtkgtn.EditValue = rowm("kd_kegiatan")
            txtJam.EditValue = rowm("kd_jam")



            If Not ds1.Tables("spkmDetil") Is Nothing Then ds1.Tables("spkmDetil").Clear()
            da3 = New SqlDataAdapter(New SqlCommand("select *, '' nama_barang,'' nama_tipe,'' merk_kain,'' nama_ukuran,0 as indeks,0 as sisa_rencana_prod  from PROD.dbo.PROD_rls_spk_man_d where no_spk_man='" & txtNoSpk.EditValue & "' and kd_kegiatan='" & txtkgtn.EditValue & "' and no_spk_man_rls='" & frmCari.row("No_SPK_Rls") & "' order by kd_barang", sqlconn))

            da3.Fill(ds1, "spkmDetil")
            Dim dr As SqlDataReader
            For Each rw As DataRow In ds1.Tables("spkmDetil").Rows

                'dr = New SqlClient.SqlCommand("select d.kd_barang,d.no_urut,d.jumlah_delay,b.nama_barang,t.nama_tipe,m.merk_kain,u.nama_ukuran,d.jumlah_realisasi,d.jumlah_kerja,d.jumlah_sisa,0 as jumlah_rework,0 as jumlah_delay,isnull(k.nilai_konv,1) * d.jumlah_kerja as indeks,(floor(w.sisa_rencana_prod)+floor(isnull(d.jumlah_kerja,0))) as sisa_rencana_prod " & _
                '"from PROD.dbo.PROD_rls_spk_man_d d " & _
                '"Left join " & _
                '"(select s.kd_kegiatan,s.no_spk,s.kd_barang,s.no_urut_brg,s.jumlah_produksi as jumlah_produksi,(s.jumlah_produksi - isnull(c.jumlah_kerja,0)) as sisa_rencana_prod " & _
                '    "from PROD.dbo.PROD_spk_d s " & _
                '    "left join(Select SUM(jumlah_kerja)as jumlah_kerja,no_spk_man,kd_kegiatan, " & _
                '    "kd_barang from prod.dbo.prod_rls_spk_man_d " & _
                '    "Group by no_spk_man,kd_kegiatan,kd_barang) c " & _
                '     "on (s.no_spk = c.no_spk_man) " & _
                '     "and (s.kd_kegiatan = c.kd_kegiatan) " & _
                '     "and (s.kd_barang = c.kd_barang)) w " & _
                '     "on (w.no_spk = d.no_spk_man) " & _
                '     "and (w.kd_kegiatan = d.kd_kegiatan) " & _
                '     "and (w.kd_barang = d.kd_barang) " & _
                '     "left join SIF.dbo.Sif_barang b on d.kd_barang=b.kode_barang " & _
                '     "left join sif.dbo.sif_tipe t on b.kd_tipe=t.kode_tipe " & _
                '      "left join sif.dbo.sif_kain m on b.kd_kain=m.kode_kain " & _
                '      "left join SIF.dbo.SIF_konv_prod k " & _
                '      "on k.jns_kegiatan = '01' and k.kd_kegiatan = d.kd_kegiatan and k.kd_kegiatan_spk = d.kd_kegiatan_spk " & _
                '       "left join sif.dbo.SIF_ukuran u on b.kd_ukuran=u.kode_ukuran " & _
                '        "where d.no_spk_man='" & txtNoSpk.EditValue & "' and d.kd_kegiatan='" & txtkgtn.EditValue & "' and no_spk_man_rls='" & frmCari.row.Item("No_SPK_Rls") & "'", sqlconn).ExecuteReader

                dr = New SqlClient.SqlCommand("select d.kd_barang,d.no_urut,d.jumlah_delay,b.nama_barang,t.nama_tipe,m.merk_kain,u.nama_ukuran,d.jumlah_realisasi,d.jumlah_kerja,d.jumlah_sisa,0 as jumlah_rework,0 as jumlah_delay,d.jumlah_kerja as indeks,(floor(w.sisa_rencana_prod)+floor(isnull(d.jumlah_kerja,0))) as sisa_rencana_prod " & _
                "from PROD.dbo.PROD_rls_spk_man_d d " & _
                "Left join " & _
                "(select s.kd_kegiatan,s.no_spk,s.kd_barang,s.no_urut_brg,s.jumlah_produksi as jumlah_produksi,(s.jumlah_produksi - isnull(c.jumlah_kerja,0)) as sisa_rencana_prod " & _
                    "from PROD.dbo.PROD_spk_d s " & _
                    "left join(Select SUM(jumlah_kerja)as jumlah_kerja,no_spk_man,kd_kegiatan, " & _
                    "kd_barang from prod.dbo.prod_rls_spk_man_d " & _
                    "Group by no_spk_man,kd_kegiatan,kd_barang) c " & _
                     "on (s.no_spk = c.no_spk_man) " & _
                     "and (s.kd_kegiatan = c.kd_kegiatan) " & _
                     "and (s.kd_barang = c.kd_barang)) w " & _
                     "on (w.no_spk = d.no_spk_man) " & _
                     "and (w.kd_kegiatan = d.kd_kegiatan) " & _
                     "and (w.kd_barang = d.kd_barang) " & _
                     "left join SIF.dbo.Sif_barang b on d.kd_barang=b.kode_barang " & _
                     "left join sif.dbo.sif_tipe t on b.kd_tipe=t.kode_tipe " & _
                     "left join sif.dbo.sif_kain m on b.kd_kain=m.kode_kain " & _
                     "left join sif.dbo.SIF_ukuran u on b.kd_ukuran=u.kode_ukuran " & _
                     "where d.no_spk_man='" & txtNoSpk.EditValue & "' and d.kd_kegiatan='" & txtkgtn.EditValue & "' and no_spk_man_rls='" & frmCari.row.Item("No_SPK_Rls") & "'", sqlconn).ExecuteReader

                While dr.Read
                    If rw.Item("kd_barang") = dr.Item("kd_barang") Then
                        rw.Item("nama_ukuran") = dr.Item("nama_ukuran")
                        rw.Item("nama_tipe") = dr.Item("nama_tipe")
                        rw.Item("merk_kain") = dr.Item("merk_kain")
                        rw.Item("nama_barang") = dr.Item("nama_barang")
                        rw.Item("no_urut") = dr.Item("no_urut")
                        rw.Item("sisa_rencana_prod") = dr.Item("sisa_rencana_prod")
                        rw.Item("jumlah_kerja") = dr.Item("jumlah_kerja")
                        rw.Item("jumlah_sisa") = dr.Item("jumlah_sisa")
                        rw.Item("jumlah_rework") = dr.Item("jumlah_rework")
                        rw.Item("jumlah_delay") = dr.Item("jumlah_delay")
                        rw.Item("indeks") = dr.Item("indeks")
                    Else

                    End If

                End While
                dr.Close()
            Next

            gc.DataSource = ds1.Tables("spkmDetil")

            For i As Int16 = 0 To gv.RowCount - 1
                If gv.GetRowCellValue(i, "no_posting") Is DBNull.Value Then
                    gv.Columns.Item("jumlah_kerja").OptionsColumn.AllowEdit = True
                ElseIf gv.GetRowCellValue(i, "no_posting") = "" Then
                    gv.Columns.Item("jumlah_kerja").OptionsColumn.AllowEdit = True
                Else
                    gv.Columns.Item("jumlah_kerja").OptionsColumn.AllowEdit = False
                End If

            Next

            'Dim rw1() As DataRow = ds1.Tables("spkmDetil").Select("no_posting = '" & vbNullString & "' or no_posting =''")
            Dim rw1() As DataRow = ds1.Tables("spkmDetil").Select("no_posting Is Null or no_posting =''")

            If rw1.Count > 0 Then
                btnSave = True
            Else
                btnSave = False
            End If


            txtTgl.Enabled = False
            txtNoSpk.Properties.ReadOnly = True
            txtJadwal.Properties.ReadOnly = True
            txtkgtn.Properties.ReadOnly = True
            txtKegiatan.Properties.ReadOnly = True


            btnadd = False
            btnEdit = False
            btnDelete = False
            btnCancel = True
            setStatus()
            Me.Enabled = True
        Else
            cancel_click()
        End If
    End Sub

    Sub Update_Stok_saldo_Edit()
        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "PROD.dbo.Update_Stok_Realisasi_Kurang"
        sqlCmd.Parameters.Add("@no_spk_man_rls", SqlDbType.VarChar, 40).Value = txtNoSpkRls.Text
        dr = sqlCmd.ExecuteReader
        dr.Close()
    End Sub

    'Sub Simpan_Hpp_Produksi(ByVal btrans As SqlTransaction)
    Sub Simpan_Hpp_Produksi()
        If txtNoSpkRls.Text = vbNullString Or txtNoSpkRls.Text = "" Then
            MsgBox("Transasksi realisasi belum disimpan.", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader
        sqlCmd.CommandTimeout = 0
        sqlCmd.Connection = sqlconn
        ' sqlCmd.Transaction = btrans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "PROD.dbo.prodp_ins_hpp_produksi"
        sqlCmd.Parameters.Add("@no_rls_spk_man", SqlDbType.VarChar, 40).Value = txtNoSpkRls.Text
        dr = sqlCmd.ExecuteReader
        dr.Close()
        MsgBox("HPP Created", MsgBoxStyle.Information)
    End Sub
    Sub Update_stok_realisasi()
        For i As Int16 = 0 To gv.RowCount - 1
            Dim sqlCmd As New SqlCommand
            Dim dr As SqlDataReader
            sqlCmd.Connection = sqlconn
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.CommandText = "PROD.dbo.Update_Stok_Realisasi"
            sqlCmd.Parameters.Add("@kd_bom", SqlDbType.VarChar, 40).Value = gv.GetRowCellValue(i, "kd_barang")
            sqlCmd.Parameters.Add("@jumlah", SqlDbType.Decimal, 40).Value = gv.GetRowCellValue(i, "jumlah_kerja")
            dr = sqlCmd.ExecuteReader
            dr.Close()
        Next
    End Sub
    Sub Simpan_Hpp_Produksi_Edit()
        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "PROD.dbo.prodp_ins_hpp_produksi_edit"
        sqlCmd.Parameters.Add("@no_rls_spk_man", SqlDbType.VarChar, 40).Value = txtNoSpkRls.Text
        dr = sqlCmd.ExecuteReader
        dr.Close()
    End Sub
    Sub hapus_data_temp()
        Dim qstr As String
        Dim dr As SqlDataReader


        qstr = "delete from Prod.dbo.PROD_simul_bhn_m_temp where no_trans = '" & notrans_simulasi1 & "' "
        dr = New SqlClient.SqlCommand(qstr, sqlconn).ExecuteReader
        dr.Close()

        qstr = "delete from Prod.dbo.PROD_simul_bhn_d_temp where no_trans ='" & notrans_simulasi1 & "'  "
        dr = New SqlClient.SqlCommand(qstr, sqlconn).ExecuteReader
        dr.Close()

    End Sub

    Public Sub save_click()
        Dim tgl As Date = getTanggal()
        Dim dr1 As SqlDataReader
        'simul()
        ''--- Untuk mengecek ketersediaan bahan baku --------'
        'dr1 = New SqlClient.SqlCommand("select COUNT(isnull(d.jumlah_stok_gudang,0)-isnull(d.jumlah,0))  from PROD.dbo.PROD_simul_bhn_d_temp d " & _
        '                               "where no_trans = '" & notrans_simulasi1 & "' and isnull(d.jumlah_stok_gudang,0)-isnull(d.jumlah,0)  < 0", sqlconn).ExecuteReader
        'dr1.Read()
        'If dr1.HasRows Then
        '    If dr1.Item(0) > 0 Then
        '        MsgBox("Bahan baku tidak mencukupi, Realisasi tidak bisa diproses")
        '        dr1.Close()
        '        frmDtlSO3.notrans_simulasi = notrans_simulasi1
        '        frmDtlSO3.ShowDialog()

        '        Exit Sub
        '    Else
        '        dr1.Close()

        '    End If
        'Else
        '    dr1.Close()
        'End If

        If State = "ADD" Then
            Dim filledrow As Integer = ds1.Tables("detil").Select("jumlah_kerja>0").Count
            If txtTgl.Text = "" Then
                MessageBox.Show("Tanggal Belum Diisi")
                Exit Sub
            End If
            If txtNoSpk.EditValue = "" Then
                MessageBox.Show("No SPK Belum Dipilih")
                Exit Sub
            End If
            If txtGroup.EditValue = "" Then
                MessageBox.Show("Group Kerja Belum Dipilih")
                Exit Sub
            End If
            'If txtKegiatan.EditValue = "" Then
            '    MessageBox.Show("Kegiatan Belum Dipilih")
            '    Exit Sub
            'End If
            If filledrow = 0 Then
                MessageBox.Show("Jumlah Kerja Belum Ada Yang Diisi")
                Exit Sub
            End If


            'If Not ds1.Tables("spkmDetil") Is Nothing Then ds1.Tables("spkmDetil").Clear()
            'da3 = New SqlDataAdapter(New SqlCommand("select *, '' nama_barang,'' nama_tipe,'' merk_kain,'' nama_ukuran,0 as indeks,jumlah_delay,0 as sisa_rencana_prod  from PROD.dbo.PROD_rls_spk_man_d where no_spk_man='" & txtNoSpk.EditValue & "' and kd_kegiatan='" & txtkgtn.EditValue & "' and no_spk_man_rls='" & frmCari.row("No SPK Rls") & "' order by kd_barang", sqlconn))

            'da3.Fill(ds1, "spkmDetil")


            dread = New SqlClient.SqlCommand("select distinct(no_rph) from PROD.dbo.PROD_spk_m where no_spk='" & txtNoSpk.EditValue & "'", sqlconn).ExecuteReader
            dread.Read()
            Dim rphtmp = dread.Item("no_rph")
            dread.Close()

            Dim BTRANS As SqlTransaction
            Dim mb As New SqlCommandBuilder
            mb = New SqlClient.SqlCommandBuilder(da2)
            da2.UpdateCommand = mb.GetUpdateCommand()
            da2.InsertCommand = mb.GetInsertCommand()
            da2.DeleteCommand = mb.GetDeleteCommand()

            mb = New SqlClient.SqlCommandBuilder(da3)
            da3.UpdateCommand = mb.GetUpdateCommand()
            da3.InsertCommand = mb.GetInsertCommand()
            da3.DeleteCommand = mb.GetDeleteCommand()

            mb = New SqlClient.SqlCommandBuilder(da5)
            da5.UpdateCommand = mb.GetUpdateCommand()
            da5.InsertCommand = mb.GetInsertCommand()
            da5.DeleteCommand = mb.GetDeleteCommand()

            mb = New SqlClient.SqlCommandBuilder(da8)
            da8.UpdateCommand = mb.GetUpdateCommand()
            da8.InsertCommand = mb.GetInsertCommand()
            da8.DeleteCommand = mb.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            da2.UpdateCommand.Transaction = BTRANS
            da2.InsertCommand.Transaction = BTRANS
            da2.DeleteCommand.Transaction = BTRANS

            da3.UpdateCommand.Transaction = BTRANS
            da3.InsertCommand.Transaction = BTRANS
            da3.DeleteCommand.Transaction = BTRANS

            da5.UpdateCommand.Transaction = BTRANS
            da5.InsertCommand.Transaction = BTRANS
            da5.DeleteCommand.Transaction = BTRANS

            da8.UpdateCommand.Transaction = BTRANS
            da8.InsertCommand.Transaction = BTRANS
            da8.DeleteCommand.Transaction = BTRANS

            Dim notrans As String
            notrans = getNoTrans("PRODSPKRLS", tgl, BTRANS)
            txtNoSpkRls.Text = notrans

            For i = ds1.Tables("detil").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = ds1.Tables("detil").Rows(i)
                If Not TypeOf rows("jumlah_kerja") Is DBNull Then
                    If rows("jumlah_kerja") > 0 Then
                        For i1 = ds1.Tables("detil1").Rows.Count - 1 To 0 Step -1
                            Dim rows1 As DataRow = ds1.Tables("detil1").Rows(i1)
                            If rows1("no_sp") = rows("no_sp") And rows1("no_sp_dtl") = rows1("no_sp_dtl") And rows1("kd_barang") = rows("kd_barang") Then
                                rows1("jumlah_kerja") = rows1("sisa_rencana_prod")
                                rows1("jumlah_realisasi") = rows1("sisa_rencana_prod")
                            Else

                            End If

                        Next
                        'Else
                        '    ds1.Tables("spkmDetail").Rows(i).Delete()
                    End If
                    'Else
                    '    ds1.Tables("spkmDetail").Rows(i).Delete()
                End If
            Next

            Dim rowm As DataRow
            rowm = ds1.Tables("spkmMaster").NewRow
            rowm("kd_cabang") = kdcabang
            rowm("kd_departemen") = kddep
            rowm("tanggal") = tgl
            'rowm("no_rph") = rphtmp
            rowm("no_spk_man") = txtNoSpk.Text
            rowm("sts_centi") = "N"
            rowm("no_spk_man_rls") = notrans
            rowm("kd_kegiatan") = txtkgtn.EditValue
            rowm("kd_kegiatan_spk") = "SERVICE"
            rowm("group_kerja") = txtGroup.EditValue
            rowm("kd_pegawai") = txtPegawai.EditValue
            rowm("kd_mesin") = txtMesin.EditValue
            rowm("kd_jam") = txtJam.EditValue
            rowm("last_create_date") = tgl
            rowm("last_created_by") = username
            rowm("last_update_date") = tgl
            rowm("last_updated_by") = username
            rowm("program_name") = Me.Name

            ds1.Tables("spkmMaster").Rows.Add(rowm)

            'For i = ds1.Tables("detil1").Rows.Count - 1 To 0 Step -1
            '    Dim rows As DataRow = ds1.Tables("detil1").Rows(i)
            '    If Not TypeOf rows("jumlah_kerja") Is DBNull Then
            '        If rows("jumlah_kerja") > 0 Then

            '            With ds1.Tables("spkmMaster").Select("kd_kegiatan_spk='" & rows("kd_kegiatan_spk") & "'")
            '                If .Count > 0 Then
            '                    ' .ElementAt(0)("jumlah") = .ElementAt(0)("jumlah") + rows("jumlah_kerja")
            '                Else
            '                    Dim rowm As DataRow
            '                    rowm = ds1.Tables("spkmMaster").NewRow
            '                    rowm("kd_cabang") = kdcabang
            '                    rowm("kd_departemen") = kddep
            '                    rowm("tanggal") = tgl
            '                    'rowm("no_rph") = rphtmp
            '                    rowm("no_spk_man") = txtNoSpk.Text
            '                    rowm("sts_centi") = "N"
            '                    rowm("no_spk_man_rls") = notrans
            '                    rowm("kd_kegiatan") = txtkgtn.EditValue
            '                    rowm("kd_kegiatan_spk") = rows("kd_kegiatan_spk")
            '                    rowm("group_kerja") = txtGroup.EditValue
            '                    rowm("kd_pegawai") = txtPegawai.EditValue
            '                    rowm("kd_mesin") = txtMesin.EditValue
            '                    rowm("kd_jam") = txtJam.EditValue
            '                    rowm("last_create_date") = tgl
            '                    rowm("last_created_by") = username
            '                    rowm("last_update_date") = tgl
            '                    rowm("last_updated_by") = username
            '                    rowm("program_name") = Me.Name

            '                    ds1.Tables("spkmMaster").Rows.Add(rowm)
            '                End If
            '            End With

            '        End If
            '    End If



            'Next


            For i = ds1.Tables("detil1").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = ds1.Tables("detil1").Rows(i)
                If Not TypeOf rows("jumlah_kerja") Is DBNull Then
                    If rows("jumlah_kerja") > 0 Then

                        With ds1.Tables("spkmDetil").Select("kd_kegiatan_spk='" & rows("kd_kegiatan_spk") & "' and kd_barang ='" & rows("kd_barang") & "'")
                            If .Count > 0 Then
                                .ElementAt(0)("jumlah_kerja") = .ElementAt(0)("jumlah_kerja") + rows("jumlah_kerja")
                            Else
                                Dim nr As DataRow = ds1.Tables("spkmDetil").NewRow()
                                nr("kd_cabang") = kdcabang
                                nr("kd_departemen") = kddep
                                'nr("no_rph") = rphtmp
                                nr("no_spk_man") = txtNoSpk.Text
                                nr("no_spk_man_rls") = notrans
                                nr("kd_kegiatan") = txtkgtn.EditValue
                                nr("kd_kegiatan_spk") = rows("kd_kegiatan_spk")
                                nr("kd_barang") = rows("kd_barang")
                                nr("no_urut") = rows("no_urut_brg")
                                nr("jumlah_delay") = rows("jumlah_delay")
                                nr("jumlah_realisasi") = rows("jumlah_realisasi")
                                nr("jumlah_kerja") = rows("jumlah_kerja")
                                nr("jumlah_rework") = rows("jumlah_rework")
                                nr("jumlah_sisa") = rows("jumlah_sisa")
                                nr("last_create_date") = tgl
                                nr("last_created_by") = username
                                nr("last_update_date") = tgl
                                nr("last_updated_by") = username
                                nr("program_name") = Me.Name
                                ds1.Tables("spkmDetil").Rows.Add(nr)
                            End If
                        End With

                    End If
                End If



            Next

          


            For i = ds1.Tables("detil1").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = ds1.Tables("detil1").Rows(i)
                If Not TypeOf rows("jumlah_kerja") Is DBNull Then
                    If rows("jumlah_kerja") > 0 Then
                        Dim nr As DataRow = ds1.Tables("spkmDetilSP").NewRow()
                        nr("kd_cabang") = kdcabang
                        nr("kd_departemen") = kddep
                        'nr("no_rph") = rphtmp
                        nr("no_spk_man") = txtNoSpk.Text
                        nr("no_spk_man_rls") = notrans
                        nr("kd_kegiatan") = txtkgtn.EditValue
                        nr("kd_kegiatan_spk") = rows("kd_kegiatan_spk")
                        nr("kd_barang") = rows("kd_barang")
                        nr("no_urut") = rows("no_urut_brg")

                        nr("no_sp") = rows("no_sp")
                        nr("no_sp_dtl") = rows("no_sp_dtl")
                        nr("no_seq") = rows("no_seq")
                        nr("jumlah") = rows("jumlah_kerja")
                        nr("last_create_date") = tgl
                        nr("last_created_by") = username
                        nr("last_update_date") = tgl
                        nr("last_updated_by") = username
                        nr("program_name") = Me.Name
                        ds1.Tables("spkmDetilSP").Rows.Add(nr)
                        'Else
                        '    ds1.Tables("spkmDetail").Rows(i).Delete()
                    End If
                    'Else
                    '    ds1.Tables("spkmDetail").Rows(i).Delete()
                End If
            Next

            For i = ds1.Tables("spkmDetilPegawai").Rows.Count - 1 To 0 Step -1
                Dim rows1 As DataRow = ds1.Tables("spkmDetilPegawai").Rows(i)
                rows1("no_spk_man_rls") = notrans
            Next

            Try
                da2.Update(ds1.Tables("spkmMaster"))
                da3.Update(ds1.Tables("spkmDetil"))
                da8.Update(ds1.Tables("spkmDetilSP"))
                If txtGroup.EditValue <> "01" Then
                    da5.Update(ds1.Tables("spkmDetilPegawai"))
                    ds1.Tables("spkmDetilPegawai").AcceptChanges()
                End If

                ds1.Tables("spkmMaster").AcceptChanges()
                ds1.Tables("spkmDetil").AcceptChanges()
                ds1.Tables("spkmDetilSP").AcceptChanges()

                BTRANS.Commit()

                '  Simpan_Hpp_Produksi()
                showMessages("Data Berhasil Disimpan")

                hapus_data_temp()
                State = "EDIT"
                btnSave = False
                btnCancel = False
                btnDelete = False
                btnEdit = True
                btnadd = True
                setStatus()

            Catch e As Exception
                BTRANS.Rollback()
                ds1.Tables("spkmMaster").RejectChanges()
                ds1.Tables("spkmDetil").RejectChanges()
                ds1.Tables("spkmDetilPegawai").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

                txtNoSpkRls.Text = ""
                txtJadwal.EditValue = Nothing
                reload()
            End Try
        ElseIf State = "EDIT" Then
            Dim filledrow As Integer = ds1.Tables("spkmDetil").Select("jumlah_kerja>0").Count
            If filledrow = 0 Then
                MessageBox.Show("Jumlah Kerja Belum Ada Yang Diisi")
                Exit Sub
            End If

            Dim BTRANS As SqlTransaction
            Dim mb As New SqlCommandBuilder
            mb = New SqlClient.SqlCommandBuilder(da2)
            da2.UpdateCommand = mb.GetUpdateCommand()
            da2.InsertCommand = mb.GetInsertCommand()
            da2.DeleteCommand = mb.GetDeleteCommand()

            mb = New SqlClient.SqlCommandBuilder(da3)
            da3.UpdateCommand = mb.GetUpdateCommand()
            da3.InsertCommand = mb.GetInsertCommand()
            da3.DeleteCommand = mb.GetDeleteCommand()

            mb = New SqlClient.SqlCommandBuilder(da5)
            da5.UpdateCommand = mb.GetUpdateCommand()
            da5.InsertCommand = mb.GetInsertCommand()
            da5.DeleteCommand = mb.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            da2.UpdateCommand.Transaction = BTRANS
            da2.InsertCommand.Transaction = BTRANS
            da2.DeleteCommand.Transaction = BTRANS

            da3.UpdateCommand.Transaction = BTRANS
            da3.InsertCommand.Transaction = BTRANS
            da3.DeleteCommand.Transaction = BTRANS

            da5.UpdateCommand.Transaction = BTRANS
            da5.InsertCommand.Transaction = BTRANS
            da5.DeleteCommand.Transaction = BTRANS

            Dim rowm As DataRow
            rowm = ds1.Tables("spkmMaster").Rows(0)
            rowm("group_kerja") = txtGroup.EditValue
            rowm("kd_pegawai") = txtPegawai.EditValue
            rowm("kd_mesin") = txtMesin.EditValue
            rowm("kd_jam") = txtJam.EditValue

            'Dim mybuilder As New SqlCommandBuilder(da2)
            'da2.UpdateCommand = mybuilder.GetUpdateCommand
            'da2.Update(ds1.Tables("spkmMaster"))
            'ds1.Tables("spkmMaster").AcceptChanges()

            For i = ds1.Tables("spkmDetil").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = ds1.Tables("spkmDetil").Rows(i)
                If Not TypeOf rows("jumlah_kerja") Is DBNull Then
                    If rows("jumlah_kerja") > 0 Then
                        rows("last_update_date") = tgl
                        rows("last_updated_by") = username
                    Else
                        ds1.Tables("spkmDetil").Rows(i).Delete()
                    End If
                Else
                    ds1.Tables("spkmDetil").Rows(i).Delete()
                End If
            Next

            'Dim mybuilder2 As New SqlCommandBuilder(da3)
            'da3.UpdateCommand = mybuilder2.GetUpdateCommand
            'Update_Stok_saldo_Edit()
            'da3.Update(ds1.Tables("spkmDetil"))
            'ds1.Tables("spkmDetil").AcceptChanges()

            'Simpan_Hpp_Produksi_Edit()
            'showMessages("Data Berhasil Disimpan")

            Try

                da2.Update(ds1.Tables("spkmMaster"))
                da3.Update(ds1.Tables("spkmDetil"))
                da5.Update(ds1.Tables("spkmDetilPegawai"))
                ds1.Tables("spkmMaster").AcceptChanges()
                ds1.Tables("spkmDetil").AcceptChanges()
                ds1.Tables("spkmDetilPegawai").AcceptChanges()




                ' Simpan_Hpp_Produksi(BTRANS)

                BTRANS.Commit()
                showMessages("Data Berhasil Disimpan")
                'hapus_data_temp()
                State = "EDIT"
                btnSave = False
                btnCancel = False
                btnDelete = False
                btnEdit = True
                btnadd = True
                setStatus()

            Catch e As Exception


                BTRANS.Rollback()
                ds1.Tables("spkmMaster").RejectChanges()
                ds1.Tables("spkmDetil").RejectChanges()
                ds1.Tables("spkmDetilPegawai").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

                'txtNoSpkRls.Text = ""
                'txtJadwal.EditValue = Nothing
                'reload()
            End Try


        End If

    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            showMessages("Deleted..")
            'cancel_click()
        End If
    End Sub

    Public Sub cancel_click()
        ds1.Relations.Clear()
        If Not ds1.Tables("spkmDetil") Is Nothing Then ds1.Tables("spkmDetil").Clear()
        If Not ds1.Tables("SoBox") Is Nothing Then ds1.Tables("SoBox").Clear()
        gv.Columns.Item("jumlah_kerja").OptionsColumn.AllowEdit = True
        Button3.Visible = False
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
    End Sub

    Private Sub txtKegiatan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If State = "ADD" Then
            If Not txtKegiatan.EditValue Is Nothing Then
                'If Not ds1.Tables("jnsBrg") Is Nothing Then ds1.Tables("jnsBrg").Clear()
                'da1 = New SqlDataAdapter(New SqlCommand("select distinct(spk.kd_jenis) Kd_Jns_Brg, Nama_Jenis from SIF.dbo.SIF_jenis_barang reff " & _
                '                                        "left join PROD.dbo.PROD_spk_m spk on reff.kd_jns_brg=spk.kd_jenis " & _
                '                                        "where spk.no_spk='" & txtNoSpk.EditValue & "' and spk.kd_kegiatan_spk='" & txtKegiatan.EditValue & "' and reff.kd_departemen='" & kddep & "'", sqlconn))
                'da1.Fill(ds1, "jnsBrg")
                'txtkgtn.Properties.DataSource = ds1.Tables("jnsBrg")
                'txtkgtn.Properties.ReadOnly = False
                'txtkgtn.EditValue = ds1.Tables("jnsBrg").Rows(0).Item("Kd_Jns_Brg")

                isiDetil()
                'loadDetail()
            End If
        End If

    End Sub

    Private Sub loadKapasitas()
        txtkgtn.Text = 0
        da1 = New SqlDataAdapter(New SqlCommand("select * " & _
                                                "from PROD.dbo.prod_spk_m " & _
                                                "where no_trans='" & txtNoSpk.EditValue & "' " & _
                                                "and kd_kegiatan = '" & txtKegiatan.EditValue & "'", sqlconn))
        If Not ds1.Tables("rph") Is Nothing Then ds1.Tables("rph").Clear()
        da1.Fill(ds1, "rph")
        If ds1.Tables("rph").Rows.Count > 0 Then
            txtkgtn.Text = ds1.Tables("rph").Rows(0).Item("kapasitas")
        End If
    End Sub

    Private Sub loadDetail()
        If Not ds1.Tables("spkmDetail") Is Nothing Then ds1.Tables("spkmDetail").Clear()
        da3 = New SqlDataAdapter(New SqlCommand("select d.*, '' nama_barang,'' Nama_Tipe,'' Merk_Kain,'' Nama_Ukuran, 0 sisa from PROD.dbo.PROD_rls_spk_man_d  d where 1=0", sqlconn))
        da3.Fill(ds1, "spkmDetail")
        Dim dr As SqlDataReader = New SqlClient.SqlCommand("select P.*,S.kd_jenis,S.Nama_Barang, T.Nama_Tipe, K.Merk_Kain, U.Nama_Ukuran " & _
                                                           "from PROD.dbo.PROD_spk_man_d P " & _
                                                           "left join SIF.dbo.SIF_Barang S on P.kd_barang = S.Kode_Barang " & _
                                                           "left join SIF.dbo.SIF_Tipe T on S.kd_jenis=T.Kd_Jns and S.kd_tipe=T.Kode_Tipe " & _
                                                           "left join SIF.dbo.SIF_Ukuran U on S.kd_ukuran=U.Kode_Ukuran " & _
                                                           "left join SIF.dbo.SIF_Kain K on S.kd_kain=K.Kode_Kain " & _
                                                           "where P.no_spk='" & txtNoSpk.EditValue & "' and p.kd_kegiatan='" & txtkgtn.EditValue & "' and P.kd_kegiatan_spk='" & txtKegiatan.EditValue & "' " & _
                                                           "order by kd_barang", sqlconn).ExecuteReader

        While dr.Read
            Dim rw As DataRow = ds1.Tables("spkmDetail").NewRow
            rw("no_rph") = dr.Item("no_rph")
            rw("no_spk_man") = dr.Item("no_spk")
            rw("kd_kegiatan_spk") = dr.Item("kd_kegiatan_spk")
            rw("kd_barang") = dr.Item("kd_barang")
            rw("kd_kegiatan") = dr.Item("kd_kegiatan")
            rw("Nama_Ukuran") = dr.Item("Nama_Ukuran")
            rw("Nama_Tipe") = dr.Item("Nama_Tipe")
            rw("Merk_Kain") = dr.Item("Merk_Kain")
            rw("jumlah_realisasi") = dr.Item("jumlah_produksi")
            rw("nama_barang") = dr.Item("Nama_Barang")
            rw("jumlah_kerja") = 0

            ds1.Tables("spkmDetail").Rows.Add(rw)
        End While
        dr.Close()
        gc.DataSource = ds1.Tables("spkmDetail")
    End Sub

    Private Sub gv_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gv.CellValueChanged
        Dim view As ColumnView = sender

        If State = "EDIT" Then
            If e.Column Is jumlah_kerja Then


                If Not ds4.Tables("cek1") Is Nothing Then ds4.Tables("cek1").Clear()
                da1 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rls_spk_man_d where no_spk_man='" & txtNoSpk.EditValue & "' and kd_kegiatan='" & txtkgtn.EditValue & "' and no_spk_man_rls= '" & txtNoSpkRls.Text & "'  ", sqlconn)) '<- query buat ditampilkan di LOV
                da1.Fill(ds4, "cek1")


                Dim int As Double = view.GetRowCellValue(e.RowHandle, "jumlah_kerja")
                Dim s As Double = ds4.Tables("cek1").Rows(0).Item("jumlah_kerja")


                If int < s Then
                    jumlah = int - s
                Else
                    jumlah = int - s
                End If
                view.SetRowCellValue(e.RowHandle, "jumlah_sisa", jumlah)


            End If


        ElseIf State = "ADD" Then
            If e.Column Is jumlah_kerja Then

                'If Not ds4.Tables("cekadd") Is Nothing Then ds4.Tables("cekadd").Clear()

                'da4 = New SqlDataAdapter(New SqlCommand("select a.no_rph no_rph, a.no_spk, a.kd_kegiatan, a.kd_kegiatan_spk, " & _
                '                                " a.kd_barang kd_barang, a.jumlah_produksi  as jumlah_produksi,isnull(b.jumlah_rework,0) as jumlah_rework, " & _
                '                                               "  isnull(b.jumlah_kerja,0) as jumlah_kerja,0 as jumlah_sisa,ISNULL(k.nilai_konv,1) as indeks  " & _
                '                                 "from prod.dbo.prod_spk_d a " & _
                '                                 "left join(Select SUM(jumlah_kerja)as jumlah_kerja,no_spk_man,kd_kegiatan,jumlah_rework, " & _
                '                                 "kd_barang from prod.dbo.prod_rls_spk_man_d " & _
                '                                 "Group by no_spk_man,kd_kegiatan,kd_barang,jumlah_rework) b " & _
                '                                 "on (a.no_spk = b.no_spk_man) " & _
                '                                 "and (a.kd_kegiatan = b.kd_kegiatan) " & _
                '                                 "and (a.kd_barang = b.kd_barang) " & _
                '                                  "INNER JOIN SIF.dbo.SIF_Barang br " & _
                '                                  "on br.Kode_Barang = a.kd_barang " & _
                '                                  "left join SIF.dbo.SIF_konv_prod k " & _
                '                                  "on k.jns_kegiatan = '01' and k.kd_kegiatan = a.kd_kegiatan_spk and k.kd_jenis = br.kd_jenis " & _
                '                                  "and k.kd_ukuran = br.kd_ukuran and k.kd_tipe = br.kd_tipe " & _
                '                                 "where a.no_spk='" & txtNoSpk.EditValue & "' " & _
                '                                        "and a.kd_kegiatan ='" & txtkgtn.EditValue & "' " & _
                '                                        "and a.kd_kegiatan_spk= '" & txtKegiatan.EditValue & "' ", sqlconn))

                'da4 = New SqlDataAdapter(New SqlCommand("select a.no_rph no_rph, a.no_spk, a.kd_kegiatan, a.kd_kegiatan_spk, " & _
                '                                " a.kd_barang kd_barang, a.jumlah_produksi  as jumlah_produksi,isnull(b.jumlah_rework,0) as jumlah_rework, " & _
                '                                               "  isnull(b.jumlah_kerja,0) as jumlah_kerja,0 as jumlah_sisa,ISNULL(b.jumlah_kerja,1) as indeks  " & _
                '                                 "from prod.dbo.prod_spk_d a " & _
                '                                 "left join(Select SUM(jumlah_kerja)as jumlah_kerja,no_spk_man,kd_kegiatan,jumlah_rework, " & _
                '                                 "kd_barang from prod.dbo.prod_rls_spk_man_d " & _
                '                                 "Group by no_spk_man,kd_kegiatan,kd_barang,jumlah_rework) b " & _
                '                                 "on (a.no_spk = b.no_spk_man) " & _
                '                                 "and (a.kd_kegiatan = b.kd_kegiatan) " & _
                '                                 "and (a.kd_barang = b.kd_barang) " & _
                '                                  "INNER JOIN SIF.dbo.SIF_Barang br " & _
                '                                  "on br.Kode_Barang = a.kd_barang " & _
                '                                 "where a.no_spk='" & txtNoSpk.EditValue & "' " & _
                '                                        "and a.kd_kegiatan ='" & txtkgtn.EditValue & "' " & _
                '                                        "and a.kd_kegiatan_spk= '" & txtKegiatan.EditValue & "' ", sqlconn))
                ''da4 = New SqlDataAdapter(New SqlCommand(" select d.kd_barang,d.no_urut_brg,d.keterangan nama_barang,t.nama_tipe,m.merk_kain,u.nama_ukuran, " & _
                ''                                "d.jumlah as jumlah_realisasi, (d.jumlah - isnull(c.jumlah_kerja,0)) as sisa_rencana_prod, " & _
                ''                                "0.00 as jumlah_kerja, 0.00 jumlah_sisa,0.00 as jumlah_rework, " & _
                ''                                "0.00 as jumlah_delay,isnull(c.jumlah_kerja,1) as indeks  from PROD.dbo.PROD_spk_sp d " & _
                ''                                "left join(Select SUM(sp.jumlah)as jumlah_kerja,sp.no_spk_man,sp.kd_kegiatan, sp.kd_kegiatan_spk, " & _
                ''                                "sp.no_sp,sp.no_sp_dtl,sp.no_seq,sp.kd_barang,sp.no_urut from prod.dbo.PROD_rls_spk_man_sp sp " & _
                ''                                "Group by sp.no_spk_man,sp.kd_kegiatan, sp.kd_kegiatan_spk,  sp.no_sp,sp.no_sp_dtl,sp.no_seq,sp.kd_barang,sp.no_urut) c " & _
                ''                                "on (d.no_spk = c.no_spk_man) and (d.kd_kegiatan = c.kd_kegiatan)  and (d.kd_kegiatan_spk = c.kd_kegiatan_spk) " & _
                ''                                "and (d.kd_barang = c.kd_barang) and (d.no_sp = c.no_sp) and (d.no_sp_dtl = c.no_sp_dtl)  " & _
                ''                                "and (d.no_seq = c.no_seq)  left join SIF.dbo.Sif_barang b on d.kd_barang=b.kode_barang  " & _
                ''                                "left join sif.dbo.sif_tipe t on b.kd_tipe=t.kode_tipe  left join sif.dbo.sif_kain m on b.kd_kain=m.kode_kain " & _
                ''                                "left join sif.dbo.SIF_ukuran u on b.kd_ukuran=u.kode_ukuran  where d.no_spk='" & txtNoSpk.EditValue & "' and d.kd_kegiatan='" & txtkgtn.EditValue & "'", sqlconn))

                'da4.Fill(ds4, "cekadd")

                Dim int As Double = view.GetRowCellValue(e.RowHandle, "jumlah_kerja")
                Dim s As Double = view.GetRowCellValue(e.RowHandle, "sisa_rencana_prod")
                'Dim s As Double = ds4.Tables("cekadd").Rows(0).Item("jumlah_kerja")
                ' Dim indexkeg As Double = int * ds4.Tables("cekadd").Rows(0).Item("indeks")

                'Dim indexkeg As Double = int * view.GetRowCellValue(e.RowHandle, "indeks")
                '  view.SetRowCellValue(e.RowHandle, "indeks", indexkeg)

                If int < s Then
                    jumlah = int
                Else
                    jumlah = int
                End If
                view.SetRowCellValue(e.RowHandle, "jumlah_sisa", jumlah)

            End If

        End If
    End Sub



    Private Sub gv_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gv.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gv_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gv.ValidateRow



        Dim isValid As Boolean = True
        Dim x As Object
        Dim qty, sisa As Double
        x = CType(gc.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        'menghitung blok
        qty = x.GetRowCellValue(e.RowHandle, "jumlah_kerja")
        sisa = x.GetRowCellValue(e.RowHandle, "sisa_rencana_prod")
        If qty > sisa Then
            'If Not ds4.Tables("load123") Is Nothing Then ds4.Tables("load123").Clear()
            'da4 = New SqlDataAdapter(New SqlCommand("select a.no_rph, a.no_spk, a.kd_kegiatan, a.kd_kegiatan_spk, " & _
            '                       " a.kd_barang, a.jumlah_produksi,a.jumlah_produksi - floor(isnull (b.jumlah_kerja,0)) as jumlahq,floor(isnull (b.jumlah_kerja,0)) as jumlah_kerja " & _
            '                        "from prod.dbo.prod_spk_d a " & _
            '                        "left join(Select SUM(jumlah_kerja)as jumlah_kerja,no_spk_man,kd_kegiatan, " & _
            '                        "kd_barang from prod.dbo.prod_rls_spk_man_d " & _
            '                        "Group by no_spk_man,kd_kegiatan,kd_barang) b " & _
            '                        "on (a.no_spk = b.no_spk_man) " & _
            '                        "and (a.kd_kegiatan = b.kd_kegiatan) " & _
            '                        "and (a.kd_barang = b.kd_barang) " & _
            '                        "where a.no_spk='" & txtNoSpk.EditValue & "' " & _
            '                               "and a.kd_kegiatan ='" & txtkgtn.EditValue & "' " & _
            '                               "and a.kd_kegiatan_spk= '" & txtKegiatan.EditValue & "' ", sqlconn))
            'da4.Fill(ds4, "load123")
            'Dim total As Integer
            'total = ds4.Tables("load123").Rows(0).Item("jumlah_kerja") + jumlah


            'If ds4.Tables("load123").Rows(0).Item("jumlah_produksi") < total Then


            gv.SetColumnError(jumlah_kerja, "Jumlah Dikerjakan tidak boleh lebih besar dari Jumlah Produksi", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            showMessages("Data kelebihan:" & qty - sisa)
            isValid = False

        End If
        e.Valid = isValid


    End Sub

    Private Sub txtJnsBrg_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If State = "ADD" Then
            If Not txtkgtn.EditValue Is Nothing Then

            End If
        End If
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        add_click()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        edit_click()
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        cancel_click()
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        delete_click()
    End Sub

    Private Sub SimpleButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton4.Click
        save_click()
    End Sub

    Public Sub cetak_click()
        Dim TEMPLATE As String
        'callReport(App_Path() & "\report\Prod_SPK_Insentif.rpt", "", "&vnama_report =" & TEMPLATE & " &spk_man=" & txtNoSpk.Text & " &spk_man_rls =" & txtNoSpkRls.Text & " &kd_kegiatan=" & txtkgtn.EditValue, False)
        callReport(App_Path() & "\report\Prod_SPK_Insentif.rpt", "", "&spk_man=" & txtNoSpk.Text & " &spk_man_rls=" & txtNoSpkRls.Text & " &kd_kegiatan=" & txtkgtn.EditValue & " &vnama_report=" & TEMPLATE, False)

    End Sub
    Sub simul()
        Dim dr As SqlDataReader
        Dim BTRANS As SqlTransaction
        Dim notrans_simulasi, no_spk As String

        notrans_simulasi = getNoTrans("SMLBHNTEM", txtTgl.DateTime, BTRANS)
        notrans_simulasi1 = notrans_simulasi
        no_spk = txtNoSpk.EditValue


        If Not ds1.Tables("Barang_d") Is Nothing Then ds1.Tables("Barang_d").Clear()
        da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_simul_bhn_m_temp where 1=0 ", sqlconn))
        da7.Fill(ds1, "Barang_d")

        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++



        For i = gv.RowCount - 1 To 0 Step -1

            If Not TypeOf gv.GetRowCellValue(i, "jumlah_kerja") Is DBNull Then
                If gv.GetRowCellValue(i, "jumlah_kerja") > 0 Then
                    Dim rw As DataRow = ds1.Tables("Barang_d").NewRow
                    rw("kd_cabang") = kdcabang
                    rw("kd_departemen") = kddep
                    rw("no_trans") = notrans_simulasi1
                    rw("kd_brg") = gv.GetRowCellValue(i, "kd_barang")
                    rw("jumlah") = gv.GetRowCellValue(i, "jumlah_kerja")
                    rw("tipe_trans") = "3"
                    ds1.Tables("Barang_d").Rows.Add(rw)

                Else

                End If
            Else

            End If
        Next

        Dim BTRANS1 As SqlTransaction
        mb2 = New SqlClient.SqlCommandBuilder(da7)
        da7.UpdateCommand = mb2.GetUpdateCommand()
        da7.InsertCommand = mb2.GetInsertCommand()
        da7.DeleteCommand = mb2.GetDeleteCommand()

        BTRANS1 = sqlconn.BeginTransaction("1")
        da7.UpdateCommand.Transaction = BTRANS1
        da7.InsertCommand.Transaction = BTRANS1
        da7.DeleteCommand.Transaction = BTRANS1

        da7.Update(ds1.Tables("Barang_d"))
        ds1.Tables("Barang_d").AcceptChanges()



        BTRANS1.Commit()


        Dim sqlCmd As New SqlCommand

        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "PROD.dbo.prodp_ins_simul_bahan_temp3"
        sqlCmd.Parameters.Add("@vno_trans", SqlDbType.Char).Value = notrans_simulasi1
        sqlCmd.Parameters.Add("@vno_spk_m", SqlDbType.Char).Value = no_spk
        dr = sqlCmd.ExecuteReader
        dr.Close()


    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim dr As SqlDataReader
        Dim BTRANS As SqlTransaction
        Dim notrans_simulasi, no_spk As String
        Dim notrans_simulasi1 As String
        notrans_simulasi = getNoTrans("SMLBHNTEM", txtTgl.DateTime, BTRANS)
        notrans_simulasi1 = notrans_simulasi
        no_spk = txtNoSpk.EditValue



        If Not ds1.Tables("Barang_d") Is Nothing Then ds1.Tables("Barang_d").Clear()
        da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_simul_bhn_m_temp where 1=0 ", sqlconn))
        da7.Fill(ds1, "Barang_d")

        '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++



        For i = gv.RowCount - 1 To 0 Step -1

            If Not TypeOf gv.GetRowCellValue(i, "jumlah_kerja") Is DBNull Or gv.GetRowCellValue(i, "jumlah_kerja") = 0 Then
                If gv.GetRowCellValue(i, "jumlah_kerja") > 0 Then
                    Dim rw As DataRow = ds1.Tables("Barang_d").NewRow
                    rw("kd_cabang") = kdcabang
                    rw("kd_departemen") = kddep
                    rw("no_trans") = notrans_simulasi
                    rw("kd_brg") = gv.GetRowCellValue(i, "kd_barang")
                    rw("jumlah") = gv.GetRowCellValue(i, "jumlah_kerja")
                    rw("tipe_trans") = "3"
                    rw("program_name") = "frmzRlsSpkInsentif"
                    ds1.Tables("Barang_d").Rows.Add(rw)

                Else

                End If
            Else
                'MsgBox("Jumlah kerja harus diisi atau tidak boleh 0", MsgBoxStyle.Information)
                'Exit Sub
            End If
        Next

        Dim BTRANS1 As SqlTransaction
        mb2 = New SqlClient.SqlCommandBuilder(da7)
        da7.UpdateCommand = mb2.GetUpdateCommand()
        da7.InsertCommand = mb2.GetInsertCommand()
        da7.DeleteCommand = mb2.GetDeleteCommand()

        BTRANS1 = sqlconn.BeginTransaction("1")
        da7.UpdateCommand.Transaction = BTRANS1
        da7.InsertCommand.Transaction = BTRANS1
        da7.DeleteCommand.Transaction = BTRANS1

        da7.Update(ds1.Tables("Barang_d"))
        ds1.Tables("Barang_d").AcceptChanges()



        BTRANS1.Commit()


        Dim sqlCmd As New SqlCommand
        sqlCmd.CommandTimeout = 0
        sqlCmd.Connection = sqlconn
        'sqlCmd.CommandTimeout = 0
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "PROD.dbo.prodp_ins_simul_bahan_temp3"
        sqlCmd.Parameters.Add("@vno_trans", SqlDbType.Char).Value = notrans_simulasi
        sqlCmd.Parameters.Add("@vno_spk_m", SqlDbType.Char).Value = no_spk

        dr = sqlCmd.ExecuteReader
        dr.Close()
        showMessages("Processing.....")
        frmDtlSO3.notrans_simulasi = notrans_simulasi
        frmDtlSO3.ShowDialog()



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If status_posting = "Sudah Posting" Then
            MsgBox("HPP sudah diposting, generate HPP gagal", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim dr1 As SqlDataReader
        simul()
        '--- Untuk mengecek ketersediaan bahan baku --------'
        dr1 = New SqlClient.SqlCommand("select COUNT(isnull(d.jumlah_stok,0)-isnull(d.jumlah,0))  from PROD.dbo.PROD_simul_bhn_d_temp d " & _
                                       "where no_trans = '" & notrans_simulasi1 & "' and isnull(d.jumlah_stok,0)-isnull(d.jumlah,0)  < 0", sqlconn).ExecuteReader
        dr1.Read()
        If dr1.HasRows Then
            If dr1.Item(0) > 0 Then
                MsgBox("Bahan baku tidak mencukupi, Generate HPP tidak bisa diproses", MsgBoxStyle.Critical)
                dr1.Close()
                frmDtlSO3.notrans_simulasi = notrans_simulasi1
                frmDtlSO3.ShowDialog()

                Exit Sub
            Else
                dr1.Close()

            End If
        Else
            dr1.Close()
        End If
        'Simpan_Hpp_Produksi()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If State = "ADD" Then
            'If Not ds1.Tables("spkmDetilPegawai") Is Nothing Then ds1.Tables("spkmDetilPegawai").Clear()
            da5 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rls_spk_man_p where 1=0", sqlconn))
            da5.Fill(ds1, "spkmDetilPegawai")
            frmDtlPegawaiRealisasi.state = "ADD"
        ElseIf State = "EDIT" Then
            If Not ds1.Tables("spkmDetilPegawai") Is Nothing Then ds1.Tables("spkmDetilPegawai").Clear()
            da5 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rls_spk_man_p where no_spk_man_rls = '" & txtNoSpkRls.EditValue & "'", sqlconn))
            da5.Fill(ds1, "spkmDetilPegawai")
            frmDtlPegawaiRealisasi.state = "EDIT"
            frmDtlPegawaiRealisasi.no_rls = txtNoSpkRls.Text
        End If
        frmDtlPegawaiRealisasi.ShowDialog()
    End Sub
    Sub set_dso_peg(ByVal table_peg As DataTable)
        tabel_peg = table_peg
        set_dspeg()
    End Sub


    Sub set_dspeg()
        Dim tgl As Date
        tgl = getTanggal()
        If State = "ADD" Then
            For i = tabel_peg.Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = tabel_peg.Rows(i)
                Dim rowm As DataRow = ds1.Tables("spkmDetilPegawai").NewRow
                rowm("kd_cabang") = kdcabang
                rowm("kd_departemen") = kddep
                rowm("tanggal") = tgl
                'rowm("no_rph") = rphtmp
                rowm("no_spk_man") = txtNoSpk.Text
                'rowm("sts_centi") = "N"
                ' rowm("no_spk_man_rls") = notrans
                rowm("kd_kegiatan") = txtkgtn.EditValue
                rowm("kd_kegiatan_spk") = txtKegiatan.EditValue
                rowm("group_kerja") = txtGroup.EditValue
                rowm("kd_pegawai") = rows("kd_pegawai")
                rowm("kd_mesin") = txtMesin.EditValue
                rowm("kd_jam") = txtJam.EditValue
                rowm("last_create_date") = tgl
                rowm("last_created_by") = username
                rowm("last_update_date") = tgl
                rowm("last_updated_by") = username
                rowm("program_name") = Me.Name
                ds1.Tables("spkmDetilPegawai").Rows.Add(rowm)
            Next

        ElseIf State = "EDIT" Then
            For i1 = ds1.Tables("spkmDetilPegawai").Rows.Count - 1 To 0 Step -1
                ds1.Tables("spkmDetilPegawai").Rows(i1).Delete()
            Next

            For i = tabel_peg.Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = tabel_peg.Rows(i)
                Dim rowm As DataRow = ds1.Tables("spkmDetilPegawai").NewRow
                rowm("kd_cabang") = kdcabang
                rowm("kd_departemen") = kddep
                rowm("tanggal") = tgl
                'rowm("no_rph") = rphtmp
                rowm("no_spk_man") = txtNoSpk.Text
                'rowm("sts_centi") = "N"
                rowm("no_spk_man_rls") = txtNoSpkRls.Text
                rowm("kd_kegiatan") = txtkgtn.EditValue
                rowm("kd_kegiatan_spk") = txtKegiatan.EditValue
                rowm("group_kerja") = txtGroup.EditValue
                rowm("kd_pegawai") = rows("kd_pegawai")
                rowm("kd_mesin") = txtMesin.EditValue
                rowm("kd_jam") = txtJam.EditValue
                rowm("last_create_date") = tgl
                rowm("last_created_by") = username
                rowm("last_update_date") = tgl
                rowm("last_updated_by") = username
                rowm("program_name") = Me.Name
                ds1.Tables("spkmDetilPegawai").Rows.Add(rowm)
            Next
        End If


    End Sub

    Private Sub txtGroup_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGroup.EditValueChanged

        If txtGroup.EditValue <> "01" Then
            Button3.Visible = True
        Else
            Button3.Visible = False
        End If

    End Sub
End Class