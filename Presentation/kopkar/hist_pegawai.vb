Imports System.IO
Imports System.Data
Imports System.Data.SqlTypes
Imports System.Data.SqlClient

Public Class hist_pegawai
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public obj As Object
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, dSO1, ds1, ds2, ds3, ds4, dsdep, dsjab, dsedit, dsete As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Dim DA, DA1, daedit, DA2, DAdep, daJab As SqlClient.SqlDataAdapter
    'Dim myDAO As New DataAcess.CustomerDAO
    Dim Buildernya As New SqlClient.SqlCommandBuilder

    Dim pathFoto As String
    Dim gbrFoto As Image
    Dim fotoMemoryStream As IO.MemoryStream
    Dim foto() As Byte

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Private Sub hist_pegawai_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        'reload_table1("SPON")
        'GC.DataSource = dsete.Tables(0)
        'View_Departemen1()
        'DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from KOPKAR.dbo.anggota", sqlconn))
        'DA2.Fill(dsete, "PEGAWAI")
        'GC.DataSource = dsete.Tables("PEGAWAI")
        'GVSpon.BestFitColumns()
        View_Kota()
        'View_Bagian()
        'DAdep = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select depsec,nama_depsec from depsec", sqlconn))
        'DAdep.Fill(dsdep, "View_Departemen")
        'LookUpDPT.Properties.DataSource = dsdep.Tables("View_Departemen")
        'LookUpDPT.Properties.ValueMember = "depsec"
        'LookUpDPT.Properties.DisplayMember = "nama_depsec"

        daJab = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Job_id,job_nama from jabatan", sqlconn))
        daJab.Fill(dsjab, "View_Jabatan")
        LookUpJbt.Properties.DataSource = dsjab.Tables("View_Jabatan")
        LookUpJbt.Properties.ValueMember = "Job_id"
        LookUpJbt.Properties.DisplayMember = "job_nama"

        'View_Jabatan()
        'View_Departemen1()
        prn = getParent(Me)
        'masterpegawai.SelectedTabPage = XtraTabPage2
        'Me.Enabled = True
    End Sub
    Public Sub reload_table(ByVal kode As String)
        If Not dSO1.Tables("SIF_Pegawai") Is Nothing Then dSO1.Tables("SIF_Pegawai").Clear()

        DA1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from kredit k left OUTER join anggota a on a.nasabah_id=k.nasabah_id where k.nasabah_id='" & kode & "'", sqlconn))
        DA1.Fill(dSO1, "SIF_Pegawai")
        GcHist.DataSource = dSO1.Tables("SIF_Pegawai")
        Gv_hist.BestFitColumns()

        If dSO1.Tables("SIF_Pegawai").Rows.Count > 0 Then
            Dim row As DataRow
            Dim statusq As String
            Dim bolean As String
            Dim arr() As Byte
            Dim Pic As Object
            'Dim dataft As Byte() = DirectCast(row("Foto"), Byte())
            'Dim ms As New MemoryStream(dataft)

            row = dSO1.Tables("SIF_Pegawai").Rows(0)
            Pic = row.Item("Foto")

            'tboNIP.Text = row.Item("NIP").ToString
            tx_ktp.Text = row.Item("Id_serial").ToString
            'tboAbs.Text = row.Item("NABS").ToString
            tx_id.Text = row.Item("nasabah_id").ToString
            'tboNIP.Text = row.Item("nasabah_id").ToString
            tx_nama.Text = row.Item("nama").ToString
            TextAlamat1.Text = row.Item("Almt_asal").ToString
            LookupKota11.EditValue = row.Item("kode_kota").ToString
            'TextAlamat2.Text = row.Item("almt_skrg").ToString
            'TextTelpon1.Text = row.Item("telp_asal").ToString
            'lookupkota22.EditValue = row.Item("kode_kota2").ToString
            'TextTelpon2.Text = row.Item("telp_skrg").ToString
            'TextTempat.Text = row.Item("Tmp_Lahir").ToString
            'DateTimePicker3.Value = IIf(row.IsNull("Tgl_lahir"), DateTimePicker3.MinDate, row.Item("Tgl_lahir").ToString) '=isNull,"",
            'DateTimePicker3.Value = row.Item("Tgl_lahir").ToString
            'dtpMasuk.Value = row.Item("tgl_masuk").ToString

            'bolean = row.Item("jns_kel").ToString
            'ComboBoxJK.EditValue = IIf(bolean.ToString = "L", "Pria", "Wanita")
            'ComboBoxSP.EditValue = row.Item("stat_nikah").ToString
            c_statusk.EditValue = row.Item("status_kary").ToString
            'MsgBox(row.Item("depsec").ToString)

            'LookUpDPT.EditValue = row.Item("depsec")
            'LookUpBagian.EditValue = row.Item("Kode_Bagian").ToString
            LookUpJbt.EditValue = row.Item("Job_id")
            'MsgBox(LookUpDPT.Text + LookUpDPT.Text)
            TextNPWP.Text = row.Item("Peg_NPWP").ToString
            TextJamsostek.Text = row.Item("No_Jamsostek").ToString
            tx_bca1.Text = row.Item("REKBCA1").ToString
            'tboNamaBank.Text = row.Item("rekbank_alamat1").ToString
            'If row.Item("rekbank_alamat2")is nu

            tx_bca2.Text = row.Item("REKBCA2")
            'txb_cab2.Text = row.Item("rekbank_alamat2")
            tx_bca3.Text = row.Item("REKBCA3")
            ';txb_cab3.Text = row.Item("rekbank_alamat3")
            statusq = row.Item("Rec_Stat").ToString
            cbstatus.EditValue = IIf(statusq.ToString = True, "Aktif", "Tidak Aktif")
            'Txtket.Text = row.Item("Keterangan").ToString
            'MsgBox(row.Item("Foto"))
            arr = row.Item("Foto")
            If arr.Length = 0 Then
                PictureBox2.Image = Presentation.My.Resources.profile_photo
            Else
                ' arr = row.Item("Foto")
                PictureBox2.Image = Image.FromStream(New IO.MemoryStream(arr))
                'PictureBox2.Image = Image.FromStream(ms)
            End If
        End If
    End Sub

    Sub View_Kota()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kode_kota,nama_kota from kota", sqlconn))
        DA.Fill(ds2, "View_Kota2")
        LookupKota11.Properties.DataSource = ds2.Tables("View_Kota2")
        LookupKota11.Properties.ValueMember = "kode_kota"
        LookupKota11.Properties.DisplayMember = "nama_kota"
    End Sub
    'Sub View_Departemen()

    'End Sub
    'Sub View_Departemen1()
    '    DAdep = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Departemen,Nama_Departemen from sif.dbo.SIF_Departemen", sqlconn))
    '    DAdep.Fill(dSO, "View_Departemen1")
    '    lookupdepartemen.DataSource = dSO.Tables("View_Departemen1")
    '    lookupdepartemen.ValueMember = "Kd_Departemen"
    '    lookupdepartemen.DisplayMember = "Nama_Departemen"
    'End Sub
    'Sub View_Jabatan()

    'End Sub
    'Sub View_Bagian()
    '    DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Bagian,Nama_Bagian from sif.dbo.SIF_Bagian a, sif.dbo.SIF_Departemen b where a.Kd_Departemen=b.Kd_Departemen and b.Nama_Departemen = '" & LookUpDPT.Text & "' ", sqlconn))
    '    DA.Fill(dSO, "View_Bagian")
    '    LookUpBagian.Properties.DataSource = dSO.Tables("View_Bagian")
    '    LookUpBagian.Properties.ValueMember = "Kode_Bagian"
    '    LookUpBagian.Properties.DisplayMember = "Nama_Bagian"

    'End Sub

End Class