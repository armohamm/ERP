Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Public Class frmzRlsSpkInsentif2
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Dim myBuilder As New SqlCommandBuilder
    Dim ds1, ds2, ds3, ds4 As New DataSet
    Dim da1, da2, da3, da4 As New SqlDataAdapter
    Dim jumlah As Integer
    Dim dread As SqlDataReader

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

        If Not ds1.Tables("spkmPeg") Is Nothing Then ds1.Tables("spkmPeg").Clear()
        da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rls_spk_man_p where 1=0", sqlconn))
        da4.Fill(ds1, "spkmPeg")


        If Not ds1.Tables("Mst_peg_gc") Is Nothing Then ds1.Tables("Mst_peg_gc").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select Kode_Pegawai, Nama_Pegawai from SIF.dbo.SIF_Pegawai where 1=0", sqlconn))
        da1.Fill(ds1, "Mst_peg_gc")
        GC_Pegawai.DataSource = ds1.Tables("Mst_peg_gc")

        If Not ds1.Tables("Mst_peg") Is Nothing Then ds1.Tables("Mst_peg").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select Kode_Pegawai, Nama_Pegawai from SIF.dbo.SIF_Pegawai", sqlconn))
        da1.Fill(ds1, "Mst_peg")
        LE_Peg.DataSource = ds1.Tables("Mst_peg")
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
        If Not ds1.Tables("spkmPeg") Is Nothing Then ds1.Tables("spkmPeg").Clear()
        If Not ds1.Tables("spkmDetail") Is Nothing Then ds1.Tables("spkmDetail").Clear()
        If Not ds1.Tables("spkmMaster") Is Nothing Then ds1.Tables("spkmMaster").Clear()
        If Not ds1.Tables("spkmPeg") Is Nothing Then ds1.Tables("spkmPeg").Clear()

        da1 = New SqlDataAdapter(New SqlCommand("select distinct(a.no_spk),a.no_rph " & _
                                                "from PROD.dbo.PROD_spk_m a " & _
                                                "inner join PROD.dbo.PROD_rcn_prod_m m " & _
                                                "on m.no_rph = a.no_rph " & _
                                                "where a.kd_departemen= '" & kddep & "' and m.jns_produksi <> 'SERVICE' " & _
                                                "or a.kd_departemen= '" & kddep & "' and m.jns_produksi is null order by no_spk", sqlconn))
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
        If Not ds1.Tables("detil") Is Nothing Then ds1.Tables("detil").Clear()
        'da1 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_spk_d where no_spk='" & txtNoSpk.EditValue & "'", sqlconn))
        da1 = New SqlDataAdapter(New SqlCommand("select d.kd_barang,b.nama_barang,t.nama_tipe,m.merk_kain,u.nama_ukuran,floor(d.jumlah_produksi) as jumlah_realisasi,floor(isnull(c.jumlah_kerja,0)) as jumlah_kerja,floor(d.jumlah_sisa) as jumlah_sisa,0 as jumlah_rework,0 as jumlah_delay,ISNULL(k.nilai_konv,1) * isnull(c.jumlah_kerja,1) as indeks " & _
                        "from PROD.dbo.PROD_spk_d d " & _
                         "left join(Select SUM(jumlah_kerja)as jumlah_kerja,no_spk_man,kd_kegiatan, " & _
                                                   "kd_barang from prod.dbo.prod_rls_spk_man_d " & _
                                                   "Group by no_spk_man,kd_kegiatan,kd_barang) c " & _
                                                  "on (d.no_spk = c.no_spk_man) " & _
                                                   "and (d.kd_kegiatan = c.kd_kegiatan) " & _
                                                   "and (d.kd_barang = c.kd_barang) " & _
                                                   "left join SIF.dbo.Sif_barang b on d.kd_barang=b.kode_barang " & _
                        "left join sif.dbo.sif_tipe t on b.kd_tipe=t.kode_tipe " & _
                        "left join sif.dbo.sif_kain m on b.kd_kain=m.kode_kain " & _
                         "left join SIF.dbo.SIF_konv_prod k " & _
                                    "on k.jns_kegiatan = d.kd_kegiatan and k.kd_kegiatan = d.kd_kegiatan_spk " & _
                                    "and k.kd_ukuran = b.kd_ukuran and k.kd_tipe = b.kd_tipe " & _
                        "left join sif.dbo.SIF_ukuran u on b.kd_ukuran=u.kode_ukuran " & _
                        "where d.no_spk='" & txtNoSpk.EditValue & "' and d.kd_kegiatan='" & txtkgtn.EditValue & "' and d.kd_kegiatan_spk='" & txtKegiatan.EditValue & "'", sqlconn))
        da1.Fill(ds1, "detil")
        da1 = New SqlDataAdapter(New SqlCommand("select d.jumlah_produksi,d.no_spk,d.kd_kegiatan " & _
                        "from PROD.dbo.PROD_spk_d d " & _
                        "left join SIF.dbo.Sif_barang b on d.kd_barang=b.kode_barang " & _
                        "left join sif.dbo.sif_tipe t on b.kd_tipe=t.kode_tipe " & _
                        "left join sif.dbo.sif_kain m on b.kd_kain=m.kode_kain " & _
                        "left join sif.dbo.SIF_ukuran u on b.kd_ukuran=u.kode_ukuran " & _
                        "where d.no_spk='" & txtNoSpk.EditValue & "' and d.kd_kegiatan='" & txtkgtn.EditValue & "' and d.kd_kegiatan_spk='" & txtKegiatan.EditValue & "' group by d.jumlah_produksi,d.no_spk,d.kd_kegiatan", sqlconn))
        da1.Fill(ds1, "cekProduksi")
        'MsgBox("d.no_spk_man='" & txtNoSpk.EditValue & "' and d.kd_kegiatan='" & txtkgtn.EditValue & "'")
        da1 = New SqlDataAdapter(New SqlCommand("select sum(d.jumlah_kerja)as jumlah_kerja,d.no_spk_man,d.kd_kegiatan " & _
                "from PROD.dbo.PROD_rls_spk_man_d d " & _
                "left join SIF.dbo.Sif_barang b on d.kd_barang=b.kode_barang " & _
                "left join sif.dbo.sif_tipe t on b.kd_tipe=t.kode_tipe " & _
                "left join sif.dbo.sif_kain m on b.kd_kain=m.kode_kain " & _
                "left join sif.dbo.SIF_ukuran u on b.kd_ukuran=u.kode_ukuran " & _
                "where d.no_spk_man='" & txtNoSpk.EditValue & "' and d.kd_kegiatan='" & txtkgtn.EditValue & "' group by d.kd_kegiatan,d.no_spk_man", sqlconn))
        da1.Fill(ds1, "cekKerja")
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
                If Not ds1.Tables("jadwal") Is Nothing Then ds1.Tables("jadwal").Clear()
                If Not ds1.Tables("jnsKdKeg") Is Nothing Then ds1.Tables("jnsKdKeg").Clear()
                If Not ds1.Tables("kd_keg") Is Nothing Then ds1.Tables("kd_keg").Clear()
                If Not ds1.Tables("jnsKeg") Is Nothing Then ds1.Tables("jnsKeg").Clear()

                dread = New SqlClient.SqlCommand("select * FROM " & _
                            "(select distinct(no_rph)  from PROD.dbo.PROD_spk_m where no_spk='" & txtNoSpk.EditValue & "' ) spk " & _
                            "left join  " & _
                            "(select no_rph, kd_jadwal from PROD.dbo.PROD_rcn_prod_m) rph " & _
                            "on spk.no_rph=rph.no_rph", sqlconn).ExecuteReader
                dread.Read()
                txtJadwal.EditValue = dread.Item("kd_jadwal")
                dread.Close()

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
                da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='JDWKRJ' and Id_Data='" & ds1.Tables("kd_keg").Rows(0).Item(0).ToString & "'", sqlconn))
                da1.Fill(ds1, "jadwal")

                txtJadwal.Properties.DataSource = ds1.Tables("jadwal")
                txtJadwal.Properties.ReadOnly = False

                da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D reff  " & _
                        "left join PROD.dbo.PROD_spk_m spk on reff.Id_Data=spk.kd_kegiatan_spk " & _
                        "where spk.no_spk='" & txtNoSpk.EditValue & "' and kd_kegiatan='" & txtkgtn.EditValue & "' and reff.id_ref_file='SPK' ", sqlconn))
                da1.Fill(ds1, "jnsKeg")
                txtKegiatan.Properties.DataSource = ds1.Tables("jnsKeg")
                txtKegiatan.Properties.ReadOnly = False

                isiDetil()
            ElseIf State = "EDIT" Then

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
        Dim qstr As String = "select tanggal [Tanggal], no_spk_man_rls [No SPK Rls], no_spk_man [No SPK]  " & _
                "from PROD.dbo.PROD_rls_spk_man_m order by tanggal "
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

            qstr = "select P.* from PROD.dbo.PROD_rls_spk_man_m P where P.no_spk_man_rls='" & frmCari.row("No SPK Rls") & "'"
            If Not ds1.Tables("spkmMaster") Is Nothing Then ds1.Tables("spkmMaster").Clear()
            da2 = New SqlDataAdapter(New SqlCommand(qstr, sqlconn))
            da2.Fill(ds1, "spkmMaster")
            Dim rowm As DataRow = ds1.Tables("spkmMaster").Rows(0)

            txtNoSpkRls.Text = rowm("no_spk_man_rls")
            txtTgl.DateTime = rowm("tanggal")
            txtNoSpk.EditValue = rowm("no_spk_man")
            txtGroup.EditValue = rowm("group_kerja")
            txtPegawai.EditValue = rowm("kd_pegawai")
            txtMesin.EditValue = rowm("kd_mesin")
            txtKegiatan.EditValue = rowm("kd_kegiatan_spk")
            txtkgtn.EditValue = rowm("kd_kegiatan")
            txtJadwal.EditValue = rowm("kd_jam")

            If Not ds1.Tables("spkmDetil") Is Nothing Then ds1.Tables("spkmDetil").Clear()
            da3 = New SqlDataAdapter(New SqlCommand("select *, '' nama_barang,'' nama_tipe,'' merk_kain,'' nama_ukuran,0 as indeks,jumlah_delay from PROD.dbo.PROD_rls_spk_man_d where no_spk_man='" & txtNoSpk.EditValue & "' and kd_kegiatan='" & txtkgtn.EditValue & "' and no_spk_man_rls='" & frmCari.row("No SPK Rls") & "' order by kd_barang", sqlconn))

            da3.Fill(ds1, "spkmDetil")
            Dim dr As SqlDataReader
            For Each rw As DataRow In ds1.Tables("spkmDetil").Rows


                dr = New SqlClient.SqlCommand("select d.kd_barang,d.jumlah_delay,b.nama_barang,t.nama_tipe,m.merk_kain,u.nama_ukuran,d.jumlah_realisasi,d.jumlah_kerja,d.jumlah_sisa,0 as jumlah_rework,0 as jumlah_delay,isnull(k.nilai_konv,1) * d.jumlah_kerja as indeks  " & _
                "from PROD.dbo.PROD_rls_spk_man_d d " & _
                "left join SIF.dbo.Sif_barang b on d.kd_barang=b.kode_barang " & _
                "left join sif.dbo.sif_tipe t on b.kd_tipe=t.kode_tipe " & _
                "left join sif.dbo.sif_kain m on b.kd_kain=m.kode_kain " & _
                "left join SIF.dbo.SIF_konv_prod k " & _
                "on k.jns_kegiatan = d.kd_kegiatan  and k.kd_kegiatan =d.kd_kegiatan_spk " & _
                "left join sif.dbo.SIF_ukuran u on b.kd_ukuran=u.kode_ukuran " & _
                "where d.no_spk_man='" & txtNoSpk.EditValue & "' and d.kd_kegiatan='" & txtkgtn.EditValue & "' and no_spk_man_rls='" & frmCari.row("No SPK Rls") & "'", sqlconn).ExecuteReader


                While dr.Read
                    If rw.Item("kd_barang") = dr.Item("kd_barang") Then
                        rw.Item("nama_ukuran") = dr.Item("nama_ukuran")
                        rw.Item("nama_tipe") = dr.Item("nama_tipe")
                        rw.Item("merk_kain") = dr.Item("merk_kain")
                        rw.Item("nama_barang") = dr.Item("nama_barang")
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

            Dim rw1() As DataRow = ds1.Tables("spkmDetil").Select("no_posting = '" & vbNullString & "' or no_posting =''")
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

    Sub Simpan_Hpp_Produksi(ByVal btrans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = btrans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "PROD.dbo.prodp_ins_hpp_produksi"
        sqlCmd.Parameters.Add("@no_rls_spk_man", SqlDbType.VarChar, 40).Value = txtNoSpkRls.Text
        dr = sqlCmd.ExecuteReader
        dr.Close()
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

    Public Sub save_click()
        Dim tgl As Date = getTanggal()

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
            If filledrow = 0 Then
                MessageBox.Show("Jumlah Kerja Belum Ada Yang Diisi")
                Exit Sub
            End If


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

            mb = New SqlClient.SqlCommandBuilder(da4)
            da4.UpdateCommand = mb.GetUpdateCommand()
            da4.InsertCommand = mb.GetInsertCommand()
            da4.DeleteCommand = mb.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            da2.UpdateCommand.Transaction = BTRANS
            da2.InsertCommand.Transaction = BTRANS
            da2.DeleteCommand.Transaction = BTRANS

            da3.UpdateCommand.Transaction = BTRANS
            da3.InsertCommand.Transaction = BTRANS
            da3.DeleteCommand.Transaction = BTRANS

            da4.UpdateCommand.Transaction = BTRANS
            da4.InsertCommand.Transaction = BTRANS
            da4.DeleteCommand.Transaction = BTRANS

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

            For i = ds1.Tables("detil").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = ds1.Tables("detil").Rows(i)
                If Not TypeOf rows("jumlah_kerja") Is DBNull Then
                    If rows("jumlah_kerja") > 0 Then
                        Dim nr As DataRow = ds1.Tables("spkmDetil").NewRow()
                        nr("kd_cabang") = kdcabang
                        nr("kd_departemen") = kddep
                        'nr("no_rph") = rphtmp
                        nr("no_spk_man") = txtNoSpk.Text
                        nr("no_spk_man_rls") = notrans
                        nr("kd_kegiatan") = txtkgtn.EditValue
                        'nr("kd_kegiatan") = txtKegiatan.EditValue
                        nr("kd_barang") = rows("kd_barang")
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
                        'Else
                        '    ds1.Tables("spkmDetail").Rows(i).Delete()
                    End If
                    'Else
                    '    ds1.Tables("spkmDetail").Rows(i).Delete()
                End If
            Next

            For i = ds1.Tables("Mst_peg_gc").Rows.Count - 1 To 0 Step -1
                Dim rows1 As DataRow = ds1.Tables("Mst_peg_gc").Rows(i)

                Dim rowm1 As DataRow = ds1.Tables("spkmPeg").NewRow()
                rowm1("kd_cabang") = kdcabang
                rowm1("kd_departemen") = kddep
                rowm1("tanggal") = tgl
                'rowm("no_rph") = rphtmp
                rowm1("no_spk_man") = txtNoSpk.Text
                rowm1("no_spk_man_rls") = notrans
                rowm1("kd_kegiatan") = txtkgtn.EditValue
                rowm1("kd_kegiatan_spk") = txtKegiatan.EditValue
                rowm1("group_kerja") = txtGroup.EditValue
                rowm1("kd_pegawai") = rows1("Kode_Pegawai")
                rowm1("kd_mesin") = txtMesin.EditValue
                rowm1("kd_jam") = txtJam.EditValue
                rowm1("last_create_date") = tgl
                rowm1("last_created_by") = username
                rowm1("last_update_date") = tgl
                rowm1("last_updated_by") = username
                rowm1("program_name") = Me.Name
                ds1.Tables("spkmPeg").Rows.Add(rowm1)

            Next

            Try

                da2.Update(ds1.Tables("spkmMaster"))
                da3.Update(ds1.Tables("spkmDetil"))
                da4.Update(ds1.Tables("spkmPeg"))
                ds1.Tables("spkmMaster").AcceptChanges()
                ds1.Tables("spkmDetil").AcceptChanges()
                ds1.Tables("spkmPeg").AcceptChanges()

                Simpan_Hpp_Produksi(BTRANS)

                BTRANS.Commit()
                showMessages("Data Berhasil Disimpan")
                State = "EDIT"
                btnSave = False
                setStatus()

            Catch e As Exception
                BTRANS.Rollback()
                ds1.Tables("spkmMaster").RejectChanges()
                ds1.Tables("spkmDetil").RejectChanges()
                ds1.Tables("spkmPeg").RejectChanges()
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

            mb = New SqlClient.SqlCommandBuilder(da4)
            da4.UpdateCommand = mb.GetUpdateCommand()
            da4.InsertCommand = mb.GetInsertCommand()
            da4.DeleteCommand = mb.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            da2.UpdateCommand.Transaction = BTRANS
            da2.InsertCommand.Transaction = BTRANS
            da2.DeleteCommand.Transaction = BTRANS

            da3.UpdateCommand.Transaction = BTRANS
            da3.InsertCommand.Transaction = BTRANS
            da3.DeleteCommand.Transaction = BTRANS

            da4.UpdateCommand.Transaction = BTRANS
            da4.InsertCommand.Transaction = BTRANS
            da4.DeleteCommand.Transaction = BTRANS

            Dim rowm As DataRow
            rowm = ds1.Tables("spkmMaster").Rows(0)
            rowm("group_kerja") = txtGroup.EditValue
            rowm("kd_pegawai") = txtPegawai.EditValue
            rowm("kd_mesin") = txtMesin.EditValue

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
                ds1.Tables("spkmMaster").AcceptChanges()
                ds1.Tables("spkmDetil").AcceptChanges()

                Simpan_Hpp_Produksi(BTRANS)

                BTRANS.Commit()
                showMessages("Data Berhasil Disimpan")
                State = "EDIT"
                btnSave = False
                setStatus()

            Catch e As Exception
                BTRANS.Rollback()
                ds1.Tables("spkmMaster").RejectChanges()
                ds1.Tables("spkmDetil").RejectChanges()
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


                Dim int As Integer = view.GetRowCellValue(e.RowHandle, "jumlah_kerja")
                Dim s As Integer = ds4.Tables("cek1").Rows(0).Item("jumlah_kerja")


                If int < s Then

                    jumlah = int - s
                Else

                    jumlah = int - s
                End If
                view.SetRowCellValue(e.RowHandle, "jumlah_sisa", jumlah)


            End If


        ElseIf State = "ADD" Then
            If e.Column Is jumlah_kerja Then

                If Not ds4.Tables("cekadd") Is Nothing Then ds4.Tables("cekadd").Clear()

                da4 = New SqlDataAdapter(New SqlCommand("select a.no_rph no_rph, a.no_spk, a.kd_kegiatan, a.kd_kegiatan_spk, " & _
                                                  " a.kd_barang kd_barang, floor(a.jumlah_produksi)  as jumlah_produksi,floor(isnull(b.jumlah_rework,0)) as jumlah_rework, " & _
                                                                 "  floor(isnull(b.jumlah_kerja,0)) as jumlah_kerja,0 as jumlah_sisa,ISNULL(k.nilai_konv,1) as indeks  " & _
                                                   "from prod.dbo.prod_spk_d a " & _
                                                   "left join(Select SUM(jumlah_kerja)as jumlah_kerja,no_spk_man,kd_kegiatan,jumlah_rework, " & _
                                                   "kd_barang from prod.dbo.prod_rls_spk_man_d " & _
                                                   "Group by no_spk_man,kd_kegiatan,kd_barang,jumlah_rework) b " & _
                                                   "on (a.no_spk = b.no_spk_man) " & _
                                                   "and (a.kd_kegiatan = b.kd_kegiatan) " & _
                                                   "and (a.kd_barang = b.kd_barang) " & _
                                                    "INNER JOIN SIF.dbo.SIF_Barang br " & _
                                                    "on br.Kode_Barang = a.kd_barang " & _
                                                    "left join SIF.dbo.SIF_konv_prod k " & _
                                                    "on k.jns_kegiatan = a.kd_kegiatan and k.kd_kegiatan = a.kd_kegiatan_spk " & _
                                                    "and k.kd_ukuran = br.kd_ukuran and k.kd_tipe = br.kd_tipe " & _
                                                   "where a.no_spk='" & txtNoSpk.EditValue & "' " & _
                                                          "and a.kd_kegiatan ='" & txtkgtn.EditValue & "' " & _
                                                          "and a.kd_kegiatan_spk= '" & txtKegiatan.EditValue & "' ", sqlconn))
                da4.Fill(ds4, "cekadd")

                Dim int As Integer = view.GetRowCellValue(e.RowHandle, "jumlah_kerja")
                Dim s As Integer = ds4.Tables("cekadd").Rows(0).Item("jumlah_kerja")


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
        If Not ds4.Tables("load123") Is Nothing Then ds4.Tables("load123").Clear()
        da4 = New SqlDataAdapter(New SqlCommand("select a.no_rph, a.no_spk, a.kd_kegiatan, a.kd_kegiatan_spk, " & _
                               " a.kd_barang, a.jumlah_produksi,a.jumlah_produksi - floor(isnull (b.jumlah_kerja,0)) as jumlahq,floor(isnull (b.jumlah_kerja,0)) as jumlah_kerja, " & _
                                              " b.jumlah_kerja " & _
                                "from prod.dbo.prod_spk_d a " & _
                                "left join(Select SUM(jumlah_kerja)as jumlah_kerja,no_spk_man,kd_kegiatan, " & _
                                "kd_barang from prod.dbo.prod_rls_spk_man_d " & _
                                "Group by no_spk_man,kd_kegiatan,kd_barang) b " & _
                                "on (a.no_spk = b.no_spk_man) " & _
                                "and (a.kd_kegiatan = b.kd_kegiatan) " & _
                                "and (a.kd_barang = b.kd_barang) " & _
                                "where a.no_spk='" & txtNoSpk.EditValue & "' " & _
                                       "and a.kd_kegiatan ='" & txtkgtn.EditValue & "' " & _
                                       "and a.kd_kegiatan_spk= '" & txtKegiatan.EditValue & "' ", sqlconn))
        da4.Fill(ds4, "load123")
        Dim total As Integer
        total = ds4.Tables("load123").Rows(0).Item("jumlah_kerja") + jumlah


        If ds4.Tables("load123").Rows(0).Item("jumlah_produksi") < total Then


            gv.SetColumnError(jumlah_kerja, "Jumlah Dikerjakan tidak boleh lebih besar dari Jumlah Produksi", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            showMessages("Data kelebihan:" & total - ds4.Tables("load123").Rows(0).Item("jumlah_produksi"))
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

    Private Sub SimpleButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pilih_peg.Click
        pop_pegawai.Show()
    End Sub

    Private Sub SimpleButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton6.Click
        pop_pegawai.Hide()
    End Sub

    Private Sub txtGroup_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGroup.EditValueChanged
        If txtGroup.EditValue <> "01" Then
            btn_pilih_peg.Visible = True
            txtPegawai.EditValue = Nothing
            txtPegawai.Enabled = False
        ElseIf txtGroup.EditValue = "01" Then
            btn_pilih_peg.Visible = False
            txtPegawai.Enabled = True
        End If


    End Sub
End Class