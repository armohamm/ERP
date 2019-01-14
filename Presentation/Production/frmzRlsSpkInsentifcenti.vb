Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Public Class frmzRlsSpkInsentifcenti
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Dim myBuilder, mb2 As New SqlCommandBuilder
    Dim ds1, ds2, ds3, ds4 As New DataSet
    Dim da1, da2, da3, da4, da5, da6, da7 As New SqlDataAdapter
    Dim jumlah As Integer
    Dim colD1(1) As DataColumn
    Dim colD2(1) As DataColumn
    Dim colD(0) As DataColumn
    Dim colDq(0) As DataColumn
    Dim notrans_simulasi1 As String
    Dim rl As DataRelation
    Dim dread, dr As SqlDataReader

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
   
    End Sub
    Private Sub frmSpkMan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        'reload()
        If State = "ADD" Then
            If Not ds1.Tables("spkmMaster") Is Nothing Then ds1.Tables("spkmMaster").Clear()
            da2 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rls_spk_man_m where 1=0", sqlconn))
            da2.Fill(ds1, "spkmMaster")
            If Not ds1.Tables("spkmDetil") Is Nothing Then ds1.Tables("spkmDetil").Clear()
            da3 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rls_spk_man_d where 1=0", sqlconn))
            da3.Fill(ds1, "spkmDetil")
        End If
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

        da1 = New SqlDataAdapter(New SqlCommand("select distinct(no_spk), no_rph from PROD.dbo.PROD_spk_m where kd_departemen='" & kddep & "' and sts_centi='Y' order by no_spk", sqlconn))
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

        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Pegawai where Kode_Departemen='" & kddep & "' order by Nama_Pegawai ", sqlconn))
        'da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Pegawai order by Nama_Pegawai ", sqlconn))
        da1.Fill(ds1, "pegawai")
        txtPegawai.Properties.DataSource = ds1.Tables("pegawai")

        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where id_ref_file='KGTSPK'", sqlconn))
        da1.Fill(ds1, "jnsKdKeg")
        txtkgtn.Properties.DataSource = ds1.Tables("jnsKdKeg")

        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where id_ref_file='SPK'", sqlconn))
        da1.Fill(ds1, "jnsKeg")
        txtKegiatan.Properties.DataSource = ds1.Tables("jnsKeg")

        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_mesin_prod where kd_departemen='" & kddep & "' order by deskripsi ", sqlconn))
        da1.Fill(ds1, "mesin")
        txtMesin.Properties.DataSource = ds1.Tables("mesin")

        If Not ds1.Tables("spkmMaster") Is Nothing Then ds1.Tables("spkmMaster").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rls_spk_man_m where 1=0", sqlconn))
        da2.Fill(ds1, "spkmMaster")
        If Not ds1.Tables("spkmDetil") Is Nothing Then ds1.Tables("spkmDetil").Clear()
        da3 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rls_spk_man_d where 1=0", sqlconn))
        da3.Fill(ds1, "spkmDetil")

        'da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_jenis_barang where kd_departemen='" & kddep & "'", sqlconn))
        'da1.Fill(ds1, "jnsBrg")

        gc.DataSource = Nothing
    End Sub

    Private Sub isiDetil()
        'ds1.Relations.Clear()
        'MsgBox("d.kd_kegiatan='" & txtkgtn.EditValue & "' and d.kd_kegiatan_spk='" & txtKegiatan.EditValue & "'")
        If Not ds1.Tables("detil") Is Nothing Then ds1.Tables("detil").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select b.volume,d.no_rph,d.no_urut_brg,d.kd_barang,b.nama_barang, " & _
                                                "t.nama_tipe,m.merk_kain,u.nama_ukuran,floor(d.jumlah_produksi) as jumlah_realisasi, " & _
                                                "0 as jumlah_kerja, " & _
                                                "(floor(d.jumlah_produksi)-floor(isnull(c.jumlah_kerja,0))) as jumlah_sisa, " & _
                                                "0 as jumlah_rework,0 as jumlah_delay,ISNULL(k.nilai_konv,1) * isnull(c.jumlah_kerja,1) as indeks " & _
                                                "from PROD.dbo.PROD_spk_d d " & _
                                                "left join(Select SUM(jumlah_kerja)as jumlah_kerja,no_spk_man,kd_kegiatan,kd_kegiatan_spk, " & _
                                                "kd_barang, no_urut from prod.dbo.prod_rls_spk_man_d " & _
                                                "Group by no_spk_man,kd_kegiatan,kd_kegiatan_spk,kd_barang,no_urut) c " & _
                                                "on (d.no_spk = c.no_spk_man) " & _
                                                "and (d.kd_kegiatan = c.kd_kegiatan) " & _
                                                "and (d.kd_kegiatan_spk = c.kd_kegiatan_spk) " & _
                                                "and (d.kd_barang = c.kd_barang) " & _
                                                "and (d.no_urut_brg=c.no_urut) " & _
                                                "left join SIF.dbo.Sif_barang b on d.kd_barang=b.kode_barang " & _
                                                "left join sif.dbo.sif_tipe t on b.kd_tipe=t.kode_tipe and b.kd_merk = t.kode_merk " & _
                                                "left join sif.dbo.sif_kain m on b.kd_kain=m.kode_kain " & _
                                                "left join SIF.dbo.SIF_konv_prod k " & _
                                                "on k.jns_kegiatan = '01' and k.kd_kegiatan =  d.kd_kegiatan_spk and b.kd_jenis = k.kd_jenis " & _
                                                "and k.kd_ukuran = b.kd_ukuran and k.kd_tipe = b.kd_tipe " & _
                                                "left join sif.dbo.SIF_ukuran u on b.kd_ukuran=u.kode_ukuran " & _
                                                "where d.no_spk='" & txtNoSpk.EditValue & "' and d.kd_kegiatan='" & txtkgtn.EditValue & "' and d.kd_kegiatan_spk='" & txtKegiatan.EditValue & "' ", sqlconn))
        ' "and (floor(d.jumlah_produksi)-floor(isnull(c.jumlah_kerja,0))) > 0", sqlconn))

        'da1 = New SqlDataAdapter(New SqlCommand("select b.volume,d.no_rph,d.no_urut_brg,d.kd_barang,b.nama_barang,t.nama_tipe,m.merk_kain,u.nama_ukuran,floor(d.jumlah_produksi) as jumlah_realisasi,floor(isnull(c.jumlah_kerja,0)) as jumlah_kerja,floor(d.jumlah_sisa) as jumlah_sisa,0 as jumlah_rework,0 as jumlah_delay,ISNULL(k.nilai_konv,1) * isnull(c.jumlah_kerja,1) as indeks " & _
        '                "from PROD.dbo.PROD_spk_d d " & _
        '                 "left join(Select SUM(jumlah_kerja)as jumlah_kerja,no_spk_man,kd_kegiatan,kd_kegiatan_spk, " & _
        '                                           "kd_barang from prod.dbo.prod_rls_spk_man_d " & _
        '                                           "Group by no_spk_man,kd_kegiatan,kd_kegiatan_spk,kd_barang) c " & _
        '                                          "on (d.no_spk = c.no_spk_man) " & _
        '                                           "and (d.kd_kegiatan = c.kd_kegiatan) " & _
        '                                           "and (d.kd_kegiatan_spk = c.kd_kegiatan_spk) " & _
        '                                           "and (d.kd_barang = c.kd_barang) " & _
        '                                           "left join SIF.dbo.Sif_barang b on d.kd_barang=b.kode_barang " & _
        '                "left join sif.dbo.sif_tipe t on b.kd_tipe=t.kode_tipe " & _
        '                "left join sif.dbo.sif_kain m on b.kd_kain=m.kode_kain " & _
        '                 "left join SIF.dbo.SIF_konv_prod k " & _
        '                            "on k.jns_kegiatan = d.kd_kegiatan and k.kd_kegiatan = d.kd_kegiatan_spk " & _
        '                            "and k.kd_ukuran = b.kd_ukuran and k.kd_tipe = b.kd_tipe " & _
        '                "left join sif.dbo.SIF_ukuran u on b.kd_ukuran=u.kode_ukuran " & _
        '                "where d.no_spk='" & txtNoSpk.EditValue & "' and d.kd_kegiatan='" & txtkgtn.EditValue & "' and d.kd_kegiatan_spk='" & txtKegiatan.EditValue & "'", sqlconn))
        da1.Fill(ds1, "detil")
        da1 = New SqlDataAdapter(New SqlCommand("select d.jumlah_produksi,d.no_spk,d.kd_kegiatan " & _
                        "from PROD.dbo.PROD_spk_d d " & _
                        "left join SIF.dbo.Sif_barang b on d.kd_barang=b.kode_barang " & _
                        "left join sif.dbo.sif_tipe t on b.kd_tipe=t.kode_tipe " & _
                        "left join sif.dbo.sif_kain m on b.kd_kain=m.kode_kain " & _
                        "left join sif.dbo.SIF_ukuran u on b.kd_ukuran=u.kode_ukuran " & _
                        "where d.no_spk='" & txtNoSpk.EditValue & "' and d.kd_kegiatan='" & txtkgtn.EditValue & "' and d.kd_kegiatan_spk='" & txtKegiatan.EditValue & "' group by d.jumlah_produksi,d.no_spk,d.kd_kegiatan", sqlconn))
        da1.Fill(ds1, "cekProduksi")

        da1 = New SqlDataAdapter(New SqlCommand("select sum(d.jumlah_kerja)as jumlah_kerja,d.no_spk_man,d.kd_kegiatan,d.jumlah_delay " & _
                "from PROD.dbo.PROD_rls_spk_man_d d " & _
                "left join SIF.dbo.Sif_barang b on d.kd_barang=b.kode_barang " & _
                "left join sif.dbo.sif_tipe t on b.kd_tipe=t.kode_tipe " & _
                "left join sif.dbo.sif_kain m on b.kd_kain=m.kode_kain " & _
                "left join sif.dbo.SIF_ukuran u on b.kd_ukuran=u.kode_ukuran " & _
                "where d.no_spk_man='" & txtNoSpk.EditValue & "' and d.kd_kegiatan='" & txtkgtn.EditValue & "' group by d.kd_kegiatan,d.no_spk_man,jumlah_delay", sqlconn))
        da1.Fill(ds1, "cekKerja")
        
        gc.DataSource = ds1.Tables("detil")
        If Not ds1.Tables("SoBox") Is Nothing Then ds1.Tables("SoBox").Clear()
        'da6 = New SqlDataAdapter(New SqlCommand("SELECT d.*, s.kd_kegiatan,s.kd_kegiatan_spk, " & _
        '                                        "s.kd_barang as kode_barang_spk, b.Nama_Barang, ((d.panjang*d.lebar*d.tinggi*d.jumlah)/1000000) as jml_volume from PROD.dbo.PROD_rcn_prod_d d " & _
        '                                        "inner join PROD.dbo.PROD_spk_d s " & _
        '                                        "on s.no_rph = d.no_rph and s.no_urut_brg = d.no_urut_brg " & _
        '                                        "left join SIF.dbo.SIF_Barang b " & _
        '                                        "on b.Kode_Barang = s.kd_barang " & _
        '                                        "where s.no_spk = '" & txtNoSpk.EditValue & "' " & _
        '                                        "and s.kd_kegiatan ='" & txtkgtn.EditValue & "' and s.kd_kegiatan_spk = '" & txtKegiatan.EditValue & "' ", sqlconn))
        da6 = New SqlDataAdapter(New SqlCommand("SELECT d.*, so.Nama_Customer,s.kd_kegiatan,s.kd_kegiatan_spk,  " & _
                              "s.kd_barang as kode_barang_spk, b.Nama_Barang, 0.0 jumlah_kerja, " & _
                              "((d.panjang*d.lebar*d.tinggi*d.jumlah)/1000000) as jml_volume from PROD.dbo.PROD_rcn_prod_d d " & _
                              "inner join PROD.dbo.PROD_spk_d s " & _
                              "on s.no_rph = d.no_rph and s.no_urut_brg = d.no_urut_brg  " & _
                              "left join SIF.dbo.SIF_Barang b " & _
                              "on b.Kode_Barang = s.kd_barang " & _
                              "left join PROD.dbo.PRODV_MON_SO so " & _
                             " on so.No_sp = d.no_sp and so.no_seq_d = d.no_sp_dtl  " & _
                             "and so.No_sp_box = d.no_seq " & _
                             "where s.no_spk = '" & txtNoSpk.EditValue & "' " & _
                             "and s.kd_kegiatan ='" & txtkgtn.EditValue & "'  " & _
                             "and s.kd_kegiatan_spk = '" & txtKegiatan.EditValue & "'", sqlconn))

        da6.Fill(ds1, "SoBox")



        'ds1.Relations.Clear()
        'colD1(0) = ds1.Tables("detil").Columns("no_rph")
        'colD1(1) = ds1.Tables("detil").Columns("no_urut_brg")

        'colD2(0) = ds1.Tables("SoBox").Columns("no_rph")
        'colD2(1) = ds1.Tables("SoBox").Columns("no_urut_brg")

        'rl = ds1.Relations.Add("Detail", colD1, colD2, False)

        gc.DataSource = ds1.Tables("detil")
        GC2.DataSource = ds1.Tables("SoBox")
        'gc.LevelTree.Nodes.Add("Detail", GridView1)
        
       

        
    End Sub

    Private Sub txtNoSpk_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoSpk.EditValueChanged, txtkgtn.EditValueChanged, txtKegiatan.EditValueChanged
        If sender.EditValue <> Nothing Then
            If State = "ADD" Then
                If Not ds1.Tables("jadwal") Is Nothing Then ds1.Tables("jadwal").Clear()
                If Not ds1.Tables("jnsKdKeg") Is Nothing Then ds1.Tables("jnsKdKeg").Clear()
                If Not ds1.Tables("kd_keg") Is Nothing Then ds1.Tables("kd_keg").Clear()
                If Not ds1.Tables("jnsKeg") Is Nothing Then ds1.Tables("jnsKeg").Clear()

               

                da1 = New SqlDataAdapter(New SqlCommand("select distinct(spk.kd_kegiatan) Id_Data, reff.Desc_Data from SIF.dbo.SIF_Gen_Reff_D reff  " & _
                                                        "left join PROD.dbo.PROD_spk_m spk on reff.Id_Data=spk.kd_kegiatan  " & _
                                                        "where spk.no_spk='" & txtNoSpk.EditValue & "' and reff.Id_Ref_Data='KGTSPK'", sqlconn))
                da1.Fill(ds1, "jnsKdKeg")
                txtkgtn.Properties.DataSource = ds1.Tables("jnsKdKeg")
                txtkgtn.Properties.ReadOnly = False
                txtGroup.Properties.ReadOnly = False
                txtPegawai.Properties.ReadOnly = False
                txtMesin.Properties.ReadOnly = False

                da1 = New SqlDataAdapter(New SqlCommand("select kd_kegiatan from PROD.dbo.PROD_spk_m where no_spk='" & txtNoSpk.EditValue & "'", sqlconn)) ' and Id_Data='"&  &"'
                da1.Fill(ds1, "kd_keg")
                'da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='JDWKRJ' and Id_Data='" & ds1.Tables("kd_keg").Rows(0).Item(0).ToString & "'", sqlconn))
                da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='JDWKRJ'", sqlconn))
                da1.Fill(ds1, "jadwal")

                

                txtJadwal.Properties.DataSource = ds1.Tables("jadwal")
                txtJadwal.Properties.ReadOnly = False
                dread = New SqlClient.SqlCommand("select * FROM " & _
                           "(select distinct(no_rph)  from PROD.dbo.PROD_spk_m where no_spk='" & txtNoSpk.EditValue & "' ) spk " & _
                           "left join  " & _
                           "(select no_rph, kd_jadwal from PROD.dbo.PROD_rcn_prod_m) rph " & _
                           "on spk.no_rph=rph.no_rph", sqlconn).ExecuteReader
                dread.Read()
                txtJadwal.EditValue = dread.Item("kd_jadwal")
                dread.Close()

                da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D reff  " & _
                        "left join PROD.dbo.PROD_spk_m spk on reff.Id_Data=spk.kd_kegiatan_spk " & _
                        "where spk.no_spk='" & txtNoSpk.EditValue & "' and kd_kegiatan='" & txtkgtn.EditValue & "' and reff.id_ref_file='SPK' ", sqlconn))
                da1.Fill(ds1, "jnsKeg")
                txtKegiatan.Properties.DataSource = ds1.Tables("jnsKeg")
                txtKegiatan.Properties.ReadOnly = False



                dr = New SqlClient.SqlCommand("Select g.Val_kode1 from SIF.dbo.SIF_Gen_Reff_D g " & _
                                              "where g.Ref_Role = 'PROD' and g.Id_Ref_File = 'SPK' " & _
                                              "and g.Id_Data ='" & IIf(txtKegiatan.EditValue = Nothing, "", txtKegiatan.EditValue) & "'", sqlconn).ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    If dr.Item(0) = "D" Then
                        GC2.Visible = True
                        GC2.Enabled = True
                        gc.Visible = False
                    Else
                        GC2.Visible = False
                        gc.Visible = True
                        gc.Enabled = True
                    End If
                    dr.Close()
                End If
                


                isiDetil()
            ElseIf State = "EDIT" Then

            End If

        End If

    End Sub

    Public Sub add_click()
        State = "ADD"
        gc.Enabled = True
        GC2.Enabled = True
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
        Dim tgl As Date = getTanggal()
        Dim qstr As String = "select m.tanggal [Tanggal], m.no_spk_man_rls [No SPK Rls],m.no_spk_man [No SPK], " & _
            "g.Desc_Data [KEGIATAN],g1.Desc_Data [KEGIATAN SPK],p.Nama_Pegawai [PEGAWAI], " & _
            "g2.Desc_Data [GROUP KERJA],u.kd_mesin [MESIN],s.no_rph [NO RPH] " & _
            "from PROD.dbo.PROD_rls_spk_man_m m " & _
            "left join SIF.dbo.SIF_Gen_Reff_D g " & _
            "on g.Id_Data=m.kd_kegiatan " & _
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
            "where (m.sts_centi='Y') and g1.Id_Ref_File='SPK' and s.no_rph is not null " & _
            "and g.Id_Ref_File='KGTSPK' and m.kd_departemen='" & kddep & "' and g2.Id_Ref_File='GRPKERJA' " & _
            "order by m.tanggal  "

        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(qstr, sqlconn))
        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        da3.Fill(ds3, "lookup_so")

        frmCari.set_dso(ds3.Tables("lookup_so"))

        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            State = "EDIT"
            reload()

            If Not ds1.Tables("nospk") Is Nothing Then ds1.Tables("nospk").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("select distinct(no_spk_man_rls), no_spk_man as no_spk from PROD.dbo.PROD_rls_spk_man_m order by no_spk_man", sqlconn))
            da1.Fill(ds1, "nospk")
            txtNoSpk.Properties.DataSource = ds1.Tables("nospk")

            If Not ds1.Tables("spkmMaster") Is Nothing Then ds1.Tables("spkmMaster").Clear()
            qstr = "select * from PROD.dbo.PROD_rls_spk_man_m  where no_spk_man_rls='" & frmCari.row("No SPK Rls") & "'"
            If Not ds1.Tables("spkmMaster") Is Nothing Then ds1.Tables("spkmMaster").Clear()
            da2 = New SqlDataAdapter(New SqlCommand(qstr, sqlconn))
            da2.Fill(ds1, "spkmMaster")
            Dim rowm As DataRow = ds1.Tables("spkmMaster").Rows(0)

            'dread = New SqlClient.SqlCommand("select * FROM " & _
            '               "(select distinct(no_rph)  from PROD.dbo.PROD_spk_m where no_spk='" & frmCari.row("No SPK") & "' ) spk " & _
            '               "left join  " & _
            '               "(select no_rph, kd_jadwal from PROD.dbo.PROD_rcn_prod_m) rph " & _
            '               "on spk.no_rph=rph.no_rph", sqlconn).ExecuteReader
            'While dread.Read()
            '    txtJadwal.EditValue = dread.Item("kd_jadwal")
            'End While
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

            da3 = New SqlDataAdapter(New SqlCommand("select *,'' nama_barang,'' nama_tipe,'' merk_kain,'' nama_ukuran, " & _
                                                    "0 as indeks,0 as volume from PROD.dbo.PROD_rls_spk_man_d " & _
                                                    "where 1=0 ", sqlconn))

            da3.Fill(ds1, "spkmDetil")
            Dim dr As SqlDataReader

            dr = New SqlClient.SqlCommand("select d.*,b.nama_barang,b.volume,t.nama_tipe,m.merk_kain,u.nama_ukuran,d.jumlah_realisasi,d.jumlah_kerja,d.jumlah_sisa,0 as jumlah_rework,0 as jumlah_delay,isnull(k.nilai_konv,1) * d.jumlah_kerja as indeks " & _
            "from PROD.dbo.PROD_rls_spk_man_d d " & _
            "left join SIF.dbo.Sif_barang b on d.kd_barang=b.kode_barang " & _
            "left join sif.dbo.sif_tipe t on b.kd_tipe=t.kode_tipe and b.kd_merk = t.Kode_Merk " & _
            "left join sif.dbo.sif_kain m on b.kd_kain=m.kode_kain " & _
            "left join sif.dbo.SIF_ukuran u on b.kd_ukuran=u.kode_ukuran " & _
            "left join SIF.dbo.SIF_konv_prod k " & _
            "on k.jns_kegiatan = '01' and k.kd_kegiatan =  d.kd_kegiatan_spk and b.kd_jenis = k.kd_jenis " & _
            "and k.kd_ukuran = b.kd_ukuran and k.kd_tipe = b.kd_tipe and b.kd_sub_tipe = k.kd_subtipe " & _
            "where d.no_spk_man='" & txtNoSpk.EditValue & "' and d.kd_kegiatan='" & txtkgtn.EditValue & "' and kd_kegiatan_spk='" & txtKegiatan.EditValue & "' and no_spk_man_rls='" & frmCari.row("No SPK Rls") & "'", sqlconn).ExecuteReader


            While dr.Read
                Dim rw As DataRow = ds1.Tables("spkmDetil").NewRow()
                rw("kd_cabang") = dr.Item("kd_cabang")
                rw("kd_departemen") = dr.Item("kd_departemen")
                rw("no_urut") = dr.Item("no_urut")
                rw("no_spk_man") = dr.Item("no_spk_man")
                rw("no_spk_man_rls") = dr.Item("no_spk_man_rls")
                rw("kd_kegiatan") = dr.Item("kd_kegiatan")
                rw("kd_kegiatan_spk") = dr.Item("kd_kegiatan_spk")
                rw("kd_barang") = dr.Item("kd_barang")
                rw("nama_barang") = dr.Item("nama_barang")
                rw("nama_tipe") = dr.Item("nama_tipe")
                rw("merk_kain") = dr.Item("merk_kain")
                rw("nama_ukuran") = dr.Item("nama_ukuran")
                rw("jumlah_delay") = dr.Item("jumlah_delay")
                rw("jumlah_realisasi") = dr.Item("jumlah_realisasi")
                rw("jumlah_kerja") = dr.Item("jumlah_kerja")
                rw("jumlah_rework") = dr.Item("jumlah_rework")
                rw("jumlah_sisa") = dr.Item("jumlah_sisa")
                rw("indeks") = dr.Item("indeks")
                rw("volume") = dr.Item("volume")
                rw("last_create_date") = dr.Item("last_create_date")
                rw("last_created_by") = dr.Item("last_created_by")
                rw("last_update_date") = tgl
                rw("last_updated_by") = username
                rw("program_name") = dr.Item("program_name")
                ds1.Tables("spkmDetil").Rows.Add(rw)

            End While
            dr.Close()



            If Not ds1.Tables("SoBox") Is Nothing Then ds1.Tables("SoBox").Clear()
            da5 = New SqlDataAdapter(New SqlCommand("SELECT *,'' Nama_Barang, '' kode_barang_spk,'' Nama_Customer, 0.0 jumlah_kerja from PROD.dbo.PROD_rls_spk_man_sp where 1=0 ", sqlconn))
            da5.Fill(ds1, "SoBox")

            dr = New SqlClient.SqlCommand("SELECT d.*,so.Nama_Customer, s.kd_barang as kode_barang_spk, b.Nama_Barang " & _
                                          ", d.jumlah as jumlah_kerja, s.jumlah as jumlah_prod " & _
                                          "from PROD.dbo.PROD_rls_spk_man_sp d " & _
                                          "inner join PROD.dbo.PROD_spk_sp s " & _
                                          "on s.no_spk = d.no_spk_man " & _
                                          "and s.kd_kegiatan = d.kd_kegiatan " & _
                                          "and s.kd_kegiatan_spk = d.kd_kegiatan_spk " & _
                                          "and s.no_urut_brg = d.no_urut " & _
                                          "and s.no_sp = d.no_sp and s.no_sp_dtl = d.no_sp_dtl and s.no_seq = d.no_seq  " & _
                                          "left join SIF.dbo.SIF_Barang b " & _
                                          "on b.Kode_Barang = d.kd_barang " & _
                                          "left join PROD.dbo.PRODV_MON_SO so " & _
                                         " on so.No_sp = d.no_sp and so.no_seq_d = d.no_sp_dtl  " & _
                                         "and so.No_sp_box = d.no_seq " & _
                                          "where d.no_spk_man_rls = '" & txtNoSpkRls.Text & "' and " & _
                                          "d.no_spk_man = '" & txtNoSpk.EditValue & "' " & _
                                          "and d.kd_kegiatan ='" & txtkgtn.EditValue & "' " & _
                                          "and d.kd_kegiatan_spk = '" & txtKegiatan.EditValue & "'", sqlconn).ExecuteReader

            'dr = New SqlClient.SqlCommand("SELECT d.*, so.Nama_Customer,s.kd_kegiatan,s.kd_kegiatan_spk,  " & _
            '                              "s.kd_barang as kode_barang_spk, b.Nama_Barang, 0.0 jumlah_kerja, " & _
            '                              "((d.panjang*d.lebar*d.tinggi*d.jumlah)/1000000) as jml_volume from PROD.dbo.PROD_rcn_prod_d d " & _
            '                              "inner join PROD.dbo.PROD_spk_d s " & _
            '                              "on s.no_rph = d.no_rph and s.no_urut_brg = d.no_urut_brg  " & _
            '                              "left join SIF.dbo.SIF_Barang b " & _
            '                              "on b.Kode_Barang = s.kd_barang " & _
            '                              "left join PROD.dbo.PRODV_MON_SO so " & _
            '                             " on so.No_sp = d.no_sp and so.no_seq_d = d.no_sp_dtl  " & _
            '                             "and so.No_sp_box = d.no_seq and so.Kd_Stok = d.kd_barang " & _
            '                             "where s.no_spk = '" & txtNoSpk.EditValue & "' " & _
            '                             "and s.kd_kegiatan ='" & txtkgtn.EditValue & "'  " & _
            '                             "and s.kd_kegiatan_spk = '" & txtKegiatan.EditValue & "'", sqlconn).ExecuteReader

            While dr.Read
                Dim nr1 As DataRow = ds1.Tables("SoBox").NewRow()
                nr1("kd_cabang") = dr.Item("kd_cabang")
                nr1("kd_departemen") = dr.Item("kd_departemen")
                nr1("no_spk_man") = dr.Item("no_spk_man")
                nr1("no_spk_man_rls") = dr.Item("no_spk_man_rls")
                nr1("kd_kegiatan") = dr.Item("kd_kegiatan")
                nr1("kd_kegiatan_spk") = dr.Item("kd_kegiatan_spk")
                nr1("no_urut") = dr.Item("no_urut")
                nr1("kd_barang") = dr.Item("kd_barang")
                nr1("kode_barang_spk") = dr.Item("kode_barang_spk")
                nr1("Nama_Barang") = dr.Item("Nama_Barang")
                nr1("no_sp") = dr.Item("no_sp")
                nr1("Nama_Customer") = dr.Item("Nama_Customer")
                nr1("no_sp_dtl") = dr.Item("no_sp_dtl")
                nr1("no_seq") = dr.Item("no_seq")
                nr1("tinggi") = dr.Item("tinggi")
                nr1("lebar") = dr.Item("lebar")
                nr1("panjang") = dr.Item("panjang")
                nr1("jumlah_kerja") = dr.Item("jumlah_kerja")
                nr1("jumlah") = dr.Item("jumlah_prod")
                nr1("keterangan") = "No SP detil SPK Potong Spon"
                nr1("last_create_date") = dr.Item("last_create_date")
                nr1("last_created_by") = dr.Item("last_created_by")
                nr1("last_update_date") = tgl
                nr1("last_updated_by") = username
                nr1("program_name") = dr.Item("program_name")
                ds1.Tables("SoBox").Rows.Add(nr1)

            End While
            dr.Close()



            gc.DataSource = ds1.Tables("spkmDetil")
            
            GC2.DataSource = ds1.Tables("SoBox")
            gc.Enabled = False
            GC2.Enabled = False

            Dim p, l, t, jumlah, vol As Double
            p = GV_Detil_SP.GetRowCellValue(0, "panjang")
            l = GV_Detil_SP.GetRowCellValue(0, "lebar")
            t = GV_Detil_SP.GetRowCellValue(0, "tinggi")
            jumlah = GV_Detil_SP.GetRowCellValue(0, "jumlah")
            vol = (p * l * t * jumlah) / 1000000

            GV_Detil_SP.SetRowCellValue(0, "jml_volume", vol)

            txtTgl.Enabled = False
            txtNoSpk.Properties.ReadOnly = True
            txtJadwal.Properties.ReadOnly = True
            txtkgtn.Properties.ReadOnly = True
            txtKegiatan.Properties.ReadOnly = True

            Dim state_edit As String
            dr = New SqlClient.SqlCommand("Select g.Val_kode1 from SIF.dbo.SIF_Gen_Reff_D g " & _
                                               "where g.Ref_Role = 'PROD' and g.Id_Ref_File = 'SPK' " & _
                                               "and g.Id_Data ='" & IIf(txtKegiatan.EditValue = Nothing, "", txtKegiatan.EditValue) & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                If dr.Item(0) = "D" Then
                    state_edit = "D"
                Else
                    state_edit = "H"
                End If
                dr.Close()
            End If

            If state_edit = "D" Then
                gc.Visible = False
                GC2.Visible = True
                GC2.Enabled = True
            ElseIf state_edit = "H" Then
                gc.Visible = True
                gc.Enabled = True
                GC2.Visible = False
            End If

            btnSave = False
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
                    rw("no_trans") = notrans_simulasi
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
    Public Sub save_click()
        'Dim tgl As Date = getTanggal()
        Dim tgl As Date = txtTgl.EditValue

        Dim state_save As String
        'simul()

        'Dim dr1 As SqlDataReader
        ''--- Untuk mengecek ketersediaan bahan baku --------'
        'dr1 = New SqlClient.SqlCommand("select COUNT(isnull(d.jumlah_stok,0)-isnull(d.jumlah,0))  from PROD.dbo.PROD_simul_bhn_d_temp d " & _
        '                               "where no_trans = '" & notrans_simulasi1 & "' and isnull(d.jumlah_stok,0)-isnull(d.jumlah,0)  < 0", sqlconn).ExecuteReader
        'dr1.Read()
        'If dr1.HasRows Then
        '    If dr1.Item(0) > 0 Then
        '        MsgBox("Bahan baku tidak mencukupi, Generate HPP tidak bisa diproses", MsgBoxStyle.Critical)
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

        dr = New SqlClient.SqlCommand("Select g.Val_kode1 from SIF.dbo.SIF_Gen_Reff_D g " & _
                                           "where g.Ref_Role = 'PROD' and g.Id_Ref_File = 'SPK' " & _
                                           "and g.Id_Data ='" & IIf(txtKegiatan.EditValue = Nothing, "", txtKegiatan.EditValue) & "'", sqlconn).ExecuteReader
        dr.Read()
        If dr.HasRows Then
            If dr.Item(0) = "D" Then
                state_save = "D"
            Else
                state_save = "H"
            End If

        End If
        dr.Close()
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
            If txtKegiatan.EditValue = "" Then
                MessageBox.Show("Kegiatan Belum Dipilih")
                Exit Sub
            End If
            If state_save <> "D" Then
                If filledrow = 0 Then
                    MessageBox.Show("Jumlah Kerja Belum Ada Yang Diisi")
                    Exit Sub
                End If
            End If


            dread = New SqlClient.SqlCommand("select distinct(no_rph) from PROD.dbo.PROD_spk_m where no_spk='" & txtNoSpk.EditValue & "'", sqlconn).ExecuteReader
            dread.Read()
            Dim rphtmp = dread.Item("no_rph")
            dread.Close()

            If state_save = "D" Then
                If Not ds1.Tables("spk_man_sp") Is Nothing Then ds1.Tables("spk_man_sp").Clear()
                da5 = New SqlDataAdapter(New SqlCommand("SELECT * FROM  PROD.dbo.PROD_rls_spk_man_sp where 1=0", sqlconn))
                da5.Fill(ds1, "spk_man_sp")
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

            If state_save = "D" Then
                mb = New SqlClient.SqlCommandBuilder(da5)
                da5.UpdateCommand = mb.GetUpdateCommand()
                da5.InsertCommand = mb.GetInsertCommand()
                da5.DeleteCommand = mb.GetDeleteCommand()
            End If




            BTRANS = sqlconn.BeginTransaction("1")
            da2.UpdateCommand.Transaction = BTRANS
            da2.InsertCommand.Transaction = BTRANS
            da2.DeleteCommand.Transaction = BTRANS

            da3.UpdateCommand.Transaction = BTRANS
            da3.InsertCommand.Transaction = BTRANS
            da3.DeleteCommand.Transaction = BTRANS
            If state_save = "D" Then
                da5.UpdateCommand.Transaction = BTRANS
                da5.InsertCommand.Transaction = BTRANS
                da5.DeleteCommand.Transaction = BTRANS
            End If


            Dim notrans As String
            notrans = getNoTrans("PRODSPKRLS", tgl, BTRANS)
            txtNoSpkRls.Text = notrans

            Dim rowm As DataRow
            rowm = ds1.Tables("spkmMaster").NewRow
            rowm("kd_cabang") = kdcabang
            rowm("kd_departemen") = kddep
            rowm("tanggal") = tgl
            'rowm("no_rph") = rphtmp
            rowm("no_spk_man") = txtNoSpk.Text
            rowm("sts_centi") = "Y"
            rowm("no_spk_man_rls") = notrans
            rowm("kd_kegiatan") = txtkgtn.EditValue
            rowm("kd_kegiatan_spk") = txtKegiatan.EditValue
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

            If state_save = "D" Then
                For i = ds1.Tables("detil").Rows.Count - 1 To 0 Step -1
                    Dim rows As DataRow = ds1.Tables("detil").Rows(i)
                    Dim nr As DataRow = ds1.Tables("spkmDetil").NewRow()
                    nr("kd_cabang") = kdcabang
                    nr("kd_departemen") = kddep
                    nr("no_urut") = rows("no_urut_brg")
                    nr("no_spk_man") = txtNoSpk.Text
                    nr("no_spk_man_rls") = notrans
                    nr("kd_kegiatan") = txtkgtn.EditValue
                    nr("kd_kegiatan_spk") = txtKegiatan.EditValue
                    nr("kd_barang") = rows("kd_barang")
                    nr("jumlah_delay") = 0
                    nr("jumlah_realisasi") = 0
                    nr("jumlah_kerja") = 0
                    nr("jumlah_rework") = 0
                    nr("jumlah_sisa") = 0
                    nr("last_create_date") = tgl
                    nr("last_created_by") = username
                    'nr("last_update_date") = tgl
                    'nr("last_updated_by") = username
                    nr("program_name") = Me.Name
                    ds1.Tables("spkmDetil").Rows.Add(nr)
                Next
            Else
                For i = ds1.Tables("detil").Rows.Count - 1 To 0 Step -1
                    Dim rows As DataRow = ds1.Tables("detil").Rows(i)
                    If Not TypeOf rows("jumlah_kerja") Is DBNull Then
                        If rows("jumlah_kerja") > 0 Then
                            Dim nr As DataRow = ds1.Tables("spkmDetil").NewRow()
                            nr("kd_cabang") = kdcabang
                            nr("kd_departemen") = kddep
                            nr("no_urut") = rows("no_urut_brg")
                            nr("no_spk_man") = txtNoSpk.Text
                            nr("no_spk_man_rls") = notrans
                            nr("kd_kegiatan") = txtkgtn.EditValue
                            nr("kd_kegiatan_spk") = txtKegiatan.EditValue
                            nr("kd_barang") = rows("kd_barang")
                            nr("jumlah_delay") = rows("jumlah_delay")
                            nr("jumlah_realisasi") = rows("jumlah_realisasi")
                            nr("jumlah_kerja") = rows("jumlah_kerja")
                            nr("jumlah_rework") = rows("jumlah_rework")
                            nr("jumlah_sisa") = rows("jumlah_sisa")
                            nr("last_create_date") = tgl
                            nr("last_created_by") = username

                            'nr("last_updated_by") = username
                            nr("program_name") = Me.Name
                            ds1.Tables("spkmDetil").Rows.Add(nr)
                            'Else
                            '    ds1.Tables("spkmDetail").Rows(i).Delete()
                        End If
                        'Else
                        '    ds1.Tables("spkmDetail").Rows(i).Delete()
                    End If
                Next
            End If



            If state_save = "D" Then
                For i = ds1.Tables("SoBox").Rows.Count - 1 To 0 Step -1
                    Dim rows1 As DataRow = ds1.Tables("SoBox").Rows(i)
                    If Not TypeOf rows1("jumlah_kerja") Is DBNull Then
                        If rows1("jumlah_kerja") > 0 Then
                            Dim nr1 As DataRow = ds1.Tables("spk_man_sp").NewRow()
                            nr1("kd_cabang") = kdcabang
                            nr1("kd_departemen") = kddep
                            nr1("no_spk_man") = txtNoSpk.Text
                            nr1("no_spk_man_rls") = notrans
                            nr1("kd_kegiatan") = txtkgtn.EditValue
                            nr1("kd_kegiatan_spk") = txtKegiatan.EditValue
                            nr1("no_urut") = rows1("no_urut_brg")
                            nr1("kd_barang") = rows1("kode_barang_spk")
                            nr1("no_sp") = rows1("no_sp")
                            nr1("no_sp_dtl") = rows1("no_sp_dtl")
                            nr1("no_seq") = rows1("no_seq")
                            nr1("tinggi") = rows1("tinggi")
                            nr1("lebar") = rows1("lebar")
                            nr1("panjang") = rows1("panjang")
                            nr1("jumlah") = rows1("jumlah_kerja")
                            nr1("jml_volume") = (rows1("tinggi") * rows1("lebar") * rows1("panjang") * rows1("jumlah")) / 100000
                            nr1("keterangan") = "No SP detil SPK Potong Spon"
                            nr1("last_create_date") = tgl
                            nr1("last_created_by") = username
                            nr1("last_update_date") = tgl
                            nr1("last_updated_by") = username
                            nr1("program_name") = Me.Name
                            ds1.Tables("spk_man_sp").Rows.Add(nr1)
                            'Else
                            '    ds1.Tables("spkmDetail").Rows(i).Delete()
                        End If
                        'Else
                        '    ds1.Tables("spkmDetail").Rows(i).Delete()
                    End If
                Next
            End If

            Try

                da2.Update(ds1.Tables("spkmMaster"))
                da3.Update(ds1.Tables("spkmDetil"))
                ds1.Tables("spkmMaster").AcceptChanges()
                ds1.Tables("spkmDetil").AcceptChanges()
                If state_save = "D" Then
                    da5.Update(ds1.Tables("spk_man_sp"))
                    ds1.Tables("spk_man_sp").AcceptChanges()
                    Update_QTY(BTRANS)
                    ' Simpan_HPP_Prod_Centian(BTRANS)
                ElseIf state_save = "H" Then

                    ' Simpan_HPP_Prod(BTRANS)
                End If

                State = "EDIT"
                BTRANS.Commit()
                btnSave = False
                setStatus()
                showMessages("Data Berhasil Disimpan")

            Catch e As Exception
                BTRANS.Rollback()
                ds1.Tables("spkmMaster").RejectChanges()
                ds1.Tables("spkmDetil").RejectChanges()
                If state_save = "D" Then
                    ds1.Tables("spk_man_sp").RejectChanges()
                End If
                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

                txtNoSpkRls.Text = ""
                txtJadwal.EditValue = Nothing
                reload()
            End Try

        ElseIf State = "EDIT" Then
            If state_save <> "D" Then
                Dim filledrow As Integer = ds1.Tables("spkmDetil").Select("jumlah_kerja>0").Count
                If filledrow = 0 Then
                    MessageBox.Show("Jumlah Kerja Belum Ada Yang Diisi")
                    Exit Sub
                End If
            End If



            'Dim qstr As String
            'qstr = "delete from PROD.dbo.PROD_rls_spk_man_d where no_spk_man_rls='" & txtNoSpkRls.Text & "'"
            'dr = New SqlClient.SqlCommand(qstr, sqlconn).ExecuteReader
            'dr.Close()

            'qstr = "delete from PROD.dbo.PROD_rls_spk_man_sp where no_spk_man_rls='" & txtNoSpkRls.Text & "'"
            'dr = New SqlClient.SqlCommand(qstr, sqlconn).ExecuteReader
            'dr.Close()

            Dim BTRANS As SqlTransaction
            Dim mb As New SqlCommandBuilder

            mb = New SqlClient.SqlCommandBuilder(da2)
            da2.UpdateCommand = mb.GetUpdateCommand()
            da2.InsertCommand = mb.GetInsertCommand()
            da2.DeleteCommand = mb.GetDeleteCommand()

            'mb = New SqlClient.SqlCommandBuilder(da3)
            'da3.UpdateCommand = mb.GetUpdateCommand()
            'da3.InsertCommand = mb.GetInsertCommand()
            'da3.DeleteCommand = mb.GetDeleteCommand()

            'If state_save = "D" Then
            '    mb = New SqlClient.SqlCommandBuilder(da5)
            '    da5.UpdateCommand = mb.GetUpdateCommand()
            '    da5.InsertCommand = mb.GetInsertCommand()
            '    da5.DeleteCommand = mb.GetDeleteCommand()
            'End If




            BTRANS = sqlconn.BeginTransaction("1")
            da2.UpdateCommand.Transaction = BTRANS
            da2.InsertCommand.Transaction = BTRANS
            da2.DeleteCommand.Transaction = BTRANS

            'da3.UpdateCommand.Transaction = BTRANS
            'da3.InsertCommand.Transaction = BTRANS
            'da3.DeleteCommand.Transaction = BTRANS
            'If state_save = "D" Then
            '    da5.UpdateCommand.Transaction = BTRANS
            '    da5.InsertCommand.Transaction = BTRANS
            '    da5.DeleteCommand.Transaction = BTRANS
            'End If


            Dim rowm As DataRow = ds1.Tables("spkmMaster").Rows(0)
            rowm("group_kerja") = txtGroup.EditValue
            rowm("kd_pegawai") = txtPegawai.EditValue
            rowm("kd_mesin") = txtMesin.EditValue
            rowm("kd_jam") = txtJam.EditValue

            'Dim mybuilder As New SqlCommandBuilder(da2)
            'da2.UpdateCommand = mybuilder.GetUpdateCommand
            Try
                da2.Update(ds1.Tables("spkmMaster"))
                ds1.Tables("spkmMaster").AcceptChanges()
                BTRANS.Commit()

                'If state_save = "D" Then
                '    'For i = ds1.Tables("spkmDetil").Rows.Count - 1 To 0 Step -1
                '    '    Dim rows As DataRow = ds1.Tables("spkmDetil").Rows(i)
                '    '    rows("last_update_date") = tgl
                '    '    rows("last_updated_by") = username
                '    'Next
                '    For Each rows As DataRow In ds1.Tables("spkmDetil").Rows
                '        If rows.RowState = DataRowState.Added Then
                '            rows.Item("Kd_Cabang") = getKodeCabang()
                '            rows.Item("Last_Create_Date") = getTanggal()
                '            rows.Item("Last_Created_By") = username
                '            rows.Item("Last_Update_Date") = getTanggal()
                '            rows.Item("Last_Updated_By") = username
                '            rows.Item("Program_Name") = Me.Name
                '            'kd_kain = kd_kain + 1
                '        ElseIf rows.RowState = DataRowState.Modified Then
                '            rows.Item("Last_Update_Date") = getTanggal()
                '            rows.Item("Last_Updated_By") = username
                '            rows.Item("Program_Name") = Me.Name
                '        End If
                '    Next
                'Else
                '    'For i = ds1.Tables("spkmDetil").Rows.Count - 1 To 0 Step -1
                '    '    Dim rows As DataRow = ds1.Tables("spkmDetil").Rows(i)
                '    '    If Not TypeOf rows("jumlah_kerja") Is DBNull Then
                '    '        If rows("jumlah_kerja") > 0 Then
                '    '            rows("last_update_date") = tgl
                '    '            rows("last_updated_by") = username
                '    '        Else
                '    '            ds1.Tables("spkmDetil").Rows(i).Delete()
                '    '        End If
                '    '    Else
                '    '        ds1.Tables("spkmDetil").Rows(i).Delete()
                '    '    End If
                '    'Next
                '    For Each rows As DataRow In ds1.Tables("spkmDetil").Rows
                '        If rows.RowState = DataRowState.Added Then
                '            rows.Item("Kd_Cabang") = getKodeCabang()
                '            rows.Item("Last_Create_Date") = getTanggal()
                '            rows.Item("Last_Created_By") = username
                '            rows.Item("Last_Update_Date") = getTanggal()
                '            rows.Item("Last_Updated_By") = username
                '            rows.Item("Program_Name") = Me.Name
                '            'kd_kain = kd_kain + 1
                '        ElseIf rows.RowState = DataRowState.Modified Then
                '            rows.Item("Last_Update_Date") = getTanggal()
                '            rows.Item("Last_Updated_By") = username
                '            rows.Item("Program_Name") = Me.Name
                '        End If
                '    Next
                'End If


                ''Dim mybuilder2 As New SqlCommandBuilder(da3)
                ''da3.UpdateCommand = mybuilder2.GetUpdateCommand
                'da3.Update(ds1.Tables("spkmDetil"))
                'ds1.Tables("spkmDetil").AcceptChanges()

                'If state_save = "D" Then
                '    'For i = ds1.Tables("SoBox").Rows.Count - 1 To 0 Step -1
                '    '    Dim rows1 As DataRow = ds1.Tables("SoBox").Rows(i)
                '    '    If Not TypeOf rows1("jumlah") Is DBNull Then
                '    '        If rows1("jumlah") > 0 Then
                '    '            rows1("last_update_date") = tgl
                '    '            rows1("last_updated_by") = username
                '    '        Else
                '    '            ds1.Tables("SoBox").Rows(i).Delete()
                '    '        End If
                '    '    Else
                '    '        ds1.Tables("SoBox").Rows(i).Delete()
                '    '    End If


                '    'Next
                '    For Each rows As DataRow In ds1.Tables("SoBox").Rows
                '        If rows.RowState = DataRowState.Added Then
                '            rows.Item("Kd_Cabang") = getKodeCabang()
                '            rows.Item("Last_Create_Date") = getTanggal()
                '            rows.Item("Last_Created_By") = username
                '            rows.Item("Last_Update_Date") = getTanggal()
                '            rows.Item("Last_Updated_By") = username
                '            rows.Item("Program_Name") = Me.Name
                '            'kd_kain = kd_kain + 1
                '        ElseIf rows.RowState = DataRowState.Modified Then
                '            rows.Item("Last_Update_Date") = getTanggal()
                '            rows.Item("Last_Updated_By") = username
                '            rows.Item("Program_Name") = Me.Name
                '        End If
                '    Next
                '    'Dim mybuilder3 As New SqlCommandBuilder(da5)
                '    'da5.UpdateCommand = mybuilder2.GetUpdateCommand
                '    da5.Update(ds1.Tables("SoBox"))
                '    ds1.Tables("SoBox").AcceptChanges()
                If state_save = "D" Then
                    'Simpan_HPP_Prod(BTRANS)
                End If
                showMessages("Data Berhasil Diedit")
            Catch e As Exception
                BTRANS.Rollback()
                ds1.Tables("spkmMaster").RejectChanges()

                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
            End Try

        End If


    End Sub
    'Sub cek_bahan()
    '    Dim dr1 As SqlDataReader

    '    '--- Untuk mengecek ketersediaan bahan baku --------'
    '    dr1 = New SqlClient.SqlCommand("select COUNT(isnull(d.jumlah_stok,0)-isnull(d.jumlah,0))  from PROD.dbo.PROD_simul_bhn_d_temp d " & _
    '                                   "where no_trans = '" & notrans_simulasi1 & "' and isnull(d.jumlah_stok,0)-isnull(d.jumlah,0)  < 0", sqlconn).ExecuteReader
    '    dr1.Read()
    '    If dr1.HasRows Then
    '        If dr1.Item(0) > 0 Then
    '            MsgBox("Bahan baku tidak mencukupi, Generate HPP tidak bisa diproses", MsgBoxStyle.Critical)
    '            dr1.Close()
    '            frmDtlSO3.notrans_simulasi = notrans_simulasi1
    '            frmDtlSO3.ShowDialog()

    '            Exit Sub
    '        Else
    '            dr1.Close()

    '        End If
    '    Else
    '        dr1.Close()
    '    End If
    'End Sub
    Sub Update_QTY(ByVal btrans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = btrans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "PROD.dbo.Update_Qty_SoBox"
        sqlCmd.Parameters.Add("@no_rls_spk_man", SqlDbType.VarChar, 40).Value = txtNoSpkRls.Text
        dr = sqlCmd.ExecuteReader
        dr.Close()
    End Sub
    Sub Simpan_HPP_Prod(ByVal btrans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader
        sqlCmd.CommandTimeout = 0
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = btrans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "PROD.dbo.prodp_ins_hpp_produksi"
        sqlCmd.Parameters.Add("@no_rls_spk_man", SqlDbType.VarChar, 40).Value = txtNoSpkRls.Text
        dr = sqlCmd.ExecuteReader
        dr.Close()
        MsgBox("HPP Created", MsgBoxStyle.Information)
    End Sub
    Sub Simpan_HPP_Prod_Centian(ByVal btrans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = btrans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "PROD.dbo.prodp_ins_hpp_produksi_centian"
        sqlCmd.Parameters.Add("@no_rls_spk_man", SqlDbType.VarChar, 40).Value = txtNoSpkRls.Text
        dr = sqlCmd.ExecuteReader
        dr.Close()
    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            showMessages("Deleted..")
            'cancel_click()
        End If
    End Sub
    Sub clear()
        'ds1.Relations.Clear()
        If Not ds1.Tables("spkmDetil") Is Nothing Then ds1.Tables("spkmDetil").Clear()
        If Not ds1.Tables("SoBox") Is Nothing Then ds1.Tables("SoBox").Clear()
        gv.Columns.Item("jumlah_kerja").OptionsColumn.AllowEdit = True
        txtNoSpk.EditValue = Nothing
        txtNoSpkRls.Text = vbNullString
        txtkgtn.EditValue = Nothing
        txtKegiatan.EditValue = Nothing
        gc.DataSource = Nothing
        GC2.DataSource = Nothing
        txtGroup.EditValue = Nothing
        txtPegawai.EditValue = Nothing
        txtMesin.EditValue = Nothing
        txtJadwal.EditValue = Nothing
        txtJam.EditValue = Nothing
    End Sub
    Public Sub cancel_click()
        'ds1.Relations.Clear()
        'If Not ds1.Tables("spkmDetil") Is Nothing Then ds1.Tables("spkmDetil").Clear()
        'If Not ds1.Tables("SoBox") Is Nothing Then ds1.Tables("SoBox").Clear()
        clear()
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
        Dim isValid As Boolean = True
       
        If e.Column Is jumlah_kerja Then

        End If
        'If State = "EDIT" Then
        '    If e.Column Is jumlah_kerja Then


        '        If Not ds4.Tables("cek1") Is Nothing Then ds4.Tables("cek1").Clear()
        '        da1 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rls_spk_man_d where no_spk_man='" & txtNoSpk.EditValue & "' and kd_kegiatan='" & txtkgtn.EditValue & "' and kd_kegiatan_spk = '" & txtKegiatan.EditValue & "' and no_spk_man_rls= '" & txtNoSpkRls.Text & "'  ", sqlconn)) '<- query buat ditampilkan di LOV
        '        da1.Fill(ds4, "cek1")


        '        Dim int As Integer = view.GetRowCellValue(e.RowHandle, "jumlah_kerja")
        '        Dim s As Integer = ds4.Tables("cek1").Rows(0).Item("jumlah_kerja")


        '        If int < s Then

        '            jumlah = int - s
        '        Else

        '            jumlah = int - s
        '        End If
        '        view.SetRowCellValue(e.RowHandle, "jumlah_sisa", jumlah)


        '    End If


        'ElseIf State = "ADD" Then
        '    If e.Column Is jumlah_kerja Then

        '        If Not ds4.Tables("cekadd") Is Nothing Then ds4.Tables("cekadd").Clear()

        '        da4 = New SqlDataAdapter(New SqlCommand("select a.no_rph no_rph, a.no_spk, a.kd_kegiatan, a.kd_kegiatan_spk, " & _
        '                                          " a.kd_barang kd_barang, floor(a.jumlah_produksi)  as jumlah_produksi,floor(isnull(b.jumlah_rework,0)) as jumlah_rework, " & _
        '                                                         "  floor(isnull(b.jumlah_kerja,0)) as jumlah_kerja,0 as jumlah_sisa,ISNULL(k.nilai_konv,1) as indeks  " & _
        '                                           "from prod.dbo.prod_spk_d a " & _
        '                                           "left join(Select SUM(jumlah_kerja)as jumlah_kerja,no_spk_man,kd_kegiatan,jumlah_rework, " & _
        '                                           "kd_barang from prod.dbo.prod_rls_spk_man_d " & _
        '                                           "Group by no_spk_man,kd_kegiatan,kd_barang,jumlah_rework) b " & _
        '                                           "on (a.no_spk = b.no_spk_man) " & _
        '                                           "and (a.kd_kegiatan = b.kd_kegiatan) " & _
        '                                           "and (a.kd_barang = b.kd_barang) " & _
        '                                            "INNER JOIN SIF.dbo.SIF_Barang br " & _
        '                                            "on br.Kode_Barang = a.kd_barang " & _
        '                                            "left join SIF.dbo.SIF_konv_prod k " & _
        '                                            "on k.jns_kegiatan = a.kd_kegiatan and k.kd_kegiatan = a.kd_kegiatan_spk " & _
        '                                            "and k.kd_ukuran = br.kd_ukuran and k.kd_tipe = br.kd_tipe " & _
        '                                           "where a.no_spk='" & txtNoSpk.EditValue & "' " & _
        '                                                  "and a.kd_kegiatan ='" & txtkgtn.EditValue & "' " & _
        '                                                  "and a.kd_kegiatan_spk= '" & txtKegiatan.EditValue & "' ", sqlconn))
        '        da4.Fill(ds4, "cekadd")

        '        Dim int As Integer = view.GetRowCellValue(e.RowHandle, "jumlah_kerja")
        '        Dim s As Integer = ds4.Tables("cekadd").Rows(0).Item("jumlah_kerja")


        '        If int < s Then

        '            jumlah = int
        '        Else

        '            jumlah = int
        '        End If
        '        view.SetRowCellValue(e.RowHandle, "jumlah_sisa", jumlah)

        '    End If

        'End If
    End Sub



    Private Sub gv_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gv.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gv_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gv.ValidateRow



        Dim isValid As Boolean = True
        If e.Row("jumlah_kerja") > e.Row("jumlah_sisa") Then
            gv.SetColumnError(jumlah_kerja, "Jumlah Rencana Produksi Terlalu Banyak", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            MessageBox.Show("Jumlah Rencana Produksi Terlalu Banyak")
            isValid = False
        Else
            ' e.Row("jml_indeks") = e.Row("jumlah") * e.Row("nilai")
        End If
        e.Valid = isValid


        'If ds4.Tables("load123").Rows(0).Item("jumlah_produksi") < total Then


        '    gv.SetColumnError(jumlah_kerja, "Jumlah Dikerjakan tidak boleh lebih besar dari Jumlah Produksi", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        '    showMessages("Data kelebihan:" & total - ds4.Tables("load123").Rows(0).Item("jumlah_produksi"))
        '    isValid = False

        'End If
        'e.Valid = isValid


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

    Private Sub GV_Detil_SP_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV_Detil_SP.CellValueChanged
        Dim view As ColumnView = sender
        If e.Column Is GridColumn5 Then


            Dim p, l, t, jumlah, vol As Double
            p = view.GetRowCellValue(e.RowHandle, "panjang")
            l = view.GetRowCellValue(e.RowHandle, "lebar")
            t = view.GetRowCellValue(e.RowHandle, "tinggi")
            jumlah = view.GetRowCellValue(e.RowHandle, "jumlah")
            vol = (p * l * t * jumlah) / 1000000


            view.SetRowCellValue(e.RowHandle, "jml_volume", vol)


        End If
    End Sub
End Class