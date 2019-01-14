'Dilarang mengklaim kringet org kwkwkwkekekke
Imports System.IO
Imports System.Data
Imports System.Data.SqlTypes
Imports System.Data.SqlClient
Public Class frmPegawai
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public obj As Object
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, dSO1, ds1, ds2, ds3, ds4, dsdep, dsPeg, dsjab, dsedit, dsete As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Dim DA, DA1, daedit, DA2, DAdep, daJab, daPeg As SqlClient.SqlDataAdapter
    'Dim myDAO As New DataAcess.CustomerDAO
    Dim Buildernya As New SqlClient.SqlCommandBuilder

    Dim pathFoto As String
    Dim gbrFoto As Image
    Dim fotoMemoryStream As IO.MemoryStream
    Dim foto() As Byte


    Private Sub frmPegawai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        'reload_table1("SPON")
        'GC.DataSource = dsete.Tables(0)
        'View_Departemen1()
        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from KOPKAR.dbo.anggota where Rec_Stat=1 order by tgl_masuk desc", sqlconn))
        DA2.Fill(dsete, "PEGAWAI")
        GC.DataSource = dsete.Tables("PEGAWAI")
        GVSpon.BestFitColumns()
        View_Kota()
        'View_Bagian()
        DAdep = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select depsec,nama_depsec from depsec", sqlconn))
        DAdep.Fill(dsdep, "View_Departemen")
        LookUpDPT.Properties.DataSource = dsdep.Tables("View_Departemen")
        LookUpDPT.Properties.ValueMember = "depsec"
        LookUpDPT.Properties.DisplayMember = "nama_depsec"

        daJab = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select job_id,job_nama from m_jabatan", sqlconn))
        daJab.Fill(dsjab, "View_Jabatan")
        LookUpJbt.Properties.DataSource = dsjab.Tables("View_Jabatan")
        LookUpJbt.Properties.ValueMember = "job_id"
        LookUpJbt.Properties.DisplayMember = "job_nama"

        daPeg = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select id,nama from m_stat_peg", sqlconn))
        daPeg.Fill(dsPeg, "_peg")
        LE_Peg.Properties.DataSource = dsPeg.Tables("_peg")
        LE_Peg.Properties.ValueMember = "id"
        LE_Peg.Properties.DisplayMember = "nama"

        'View_Jabatan()
        'View_Departemen1()
        prn = getParent(Me)
        masterpegawai.SelectedTabPage = XtraTabPage2
        disabel()
        Me.Enabled = True
    End Sub
    Private Sub enabel()
        tboNIP.Enabled = True
        TextBoxnama.Enabled = True
        TextAlamat1.Enabled = True
        TextTelpon1.Enabled = True
        txb_rek.Enabled = True

    End Sub
    Private Sub disabel()
        tboNIP.Enabled = False
        TextBoxnama.Enabled = False
        TextAlamat1.Enabled = False
        TextTelpon1.Enabled = False
        txb_rek.Enabled = False
    End Sub
    'Private Sub reload_table1(ByVal kode As String)
    '    Dim sql1 As String
    '    If Not dsete.Tables("SOB") Is Nothing Then dsete.Tables("SOB").Clear()
    '    If LookUpEditpegawai.Text <> "" Then
    '        sql1 = " and nasabah_id='" & LookUpEditpegawai.EditValue & "'"
    '    End If

    '    If Not Me.Parent Is Nothing Then
    '        If Me.Parent.Name = "frmPegawai" Then
    '            DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_Pegawai where  like nasabah_id like '%P%'  " & sql1, sqlconn))
    '        Else
    '            DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_Pegawai where nasabah_id not like '%P%'  " & sql1, sqlconn))
    '        End If
    '        DA2.Fill(dsete, "SOB")
    '    End If

    '    ' No_sp.Group()

    'End Sub
    'Sub View_Kota1()
    '    DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kode_kota,Nama_Kota from sif.dbo.SIF_Kota", sqlconn))
    '    DA.Fill(dSO, "View_Kota1")
    '    LEKota1.Properties.DataSource = dSO.Tables("View_Kota1")
    '    LEKota1.Properties.ValueMember = "kode_kota"
    '    LEKota1.Properties.DisplayMember = "Nama_Kota"
    'End Sub
    Sub View_Kota()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kode_kota,nama_kota from kota", sqlconn))
        DA.Fill(dSO, "View_Kota")
        'lookupkota22.Properties.DataSource = dSO.Tables("View_Kota")
        'lookupkota22.Properties.ValueMember = "kode_kota"
        'lookupkota22.Properties.DisplayMember = "nama_kota"

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kode_kota,nama_kota from kota", sqlconn))
        DA.Fill(ds2, "View_Kota2")
        LookupKota11.Properties.DataSource = ds2.Tables("View_Kota2")
        LookupKota11.Properties.ValueMember = "kode_kota"
        LookupKota11.Properties.DisplayMember = "nama_kota"
    End Sub
    Sub View_Departemen()

    End Sub
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



    Private Sub Clear_ALL()
        TextBoxKode.Text = ""
        tboAbs.Text = ""
        tboNIP.Text = ""
        tboKTP.Text = ""
        TextBoxnama.Text = ""
        TextAlamat1.Text = ""
        'txt_Ket_Jab.Text = ""
        txt_Ket_Jab.Text = ""
        Txtket.Text = ""
        TextJamsostek.Text = ""
        TextNPWP.Text = ""
        TextTempat.Text = ""
        DateTimePicker3.Value = Now
        dtpMasuk.Value = Now
        cbstatus.EditValue = ""
        ComboBoxJK.EditValue = ""
        ComboBoxSP.EditValue = ""
        c_statusk.EditValue = ""
        LookUpDPT.EditValue = ""
        'LookUpBagian.EditValue = ""
        LookUpJbt.EditValue = ""
        TextTelpon1.Text = ""
        TextTelpon2.Text = ""
        txb_rek.Text = ""
        tboNamaBank.Text = ""
        PictureBox2.Image = Presentation.My.Resources.Resources.profile_photo
    End Sub
    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub
    Public Sub cancel_click()
        Clear_ALL()
        disabel()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        masterpegawai.SelectedTabPage = XtraTabPage2
        'Me.Enabled = False
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data Pegawai ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            STATE = "DELETE"
            If Not dSO1.Tables("SIF_Pegawai") Is Nothing Then delete(dSO1.Tables("SIF_Pegawai").Rows)
            save_click(True)
            cancel_click()
            STATE = ""
        End If
    End Sub
    Private Sub reload_table(ByVal kode As String)
        If Not dSO1.Tables("SIF_Pegawai") Is Nothing Then dSO1.Tables("SIF_Pegawai").Clear()

        DA1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select isnull(Foto,'') as Foto,* from anggota where nasabah_id='" & kode & "'", sqlconn))
        DA1.Fill(dSO1, "SIF_Pegawai")

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

            tboNIP.Text = row.Item("NIP").ToString
            tboNIP.Text = row.Item("nasabah_id").ToString
            tboKTP.Text = row.Item("Id_serial").ToString
            tboAbs.Text = row.Item("NABS").ToString
            TextBoxKode.Text = row.Item("nasabah_id").ToString
            TextBoxnama.Text = row.Item("nama").ToString
            TextAlamat1.Text = row.Item("Almt_asal").ToString
            LookupKota11.EditValue = row.Item("kode_kota").ToString
            txt_Ket_Jab.Text = row.Item("almt_skrg").ToString
            TextTelpon1.Text = row.Item("telp_asal").ToString
            row.Item("job_nama") = txt_Ket_Jab.Text
            TextTelpon2.Text = row.Item("telp_skrg").ToString
            TextTempat.Text = row.Item("Tmp_Lahir").ToString
            DateTimePicker3.Value = IIf(row.IsNull("Tgl_lahir"), DateTimePicker3.MinDate, row.Item("Tgl_lahir").ToString) '=isNull,"",
            'DateTimePicker3.Value = row.Item("Tgl_lahir").ToString
            dtpMasuk.Value = row.Item("tgl_masuk").ToString

            bolean = row.Item("jns_kel").ToString
            ComboBoxJK.EditValue = IIf(bolean.ToString = "L", "Pria", "Wanita")
            ComboBoxSP.EditValue = row.Item("stat_nikah").ToString
            c_statusk.EditValue = row.Item("status_anggota").ToString
            'MsgBox(row.Item("depsec").ToString)

            LookUpDPT.EditValue = row.Item("depsec")
            'LookUpBagian.EditValue = row.Item("Kode_Bagian").ToString
            LookUpJbt.EditValue = row.Item("job_id")
            'MsgBox(LookUpDPT.Text + LookUpDPT.Text)
            TextNPWP.Text = row.Item("Peg_NPWP").ToString
            TextJamsostek.Text = row.Item("No_Jamsostek").ToString
            txb_rek.Text = row.Item("REKBCA1").ToString
            tboNamaBank.Text = row.Item("rekbank_alamat1").ToString
            LE_Peg.EditValue = row.Item("sts_anggota")

            txb_bca2.Text = IIf(row.IsNull("REKBCA2"), 0, row.Item("REKBCA2")) 'row.Item("REKBCA2")
            txb_cab2.Text = IIf(row.IsNull("rekbank_alamat2"), 0, row.Item("rekbank_alamat2")) 'row.Item("REKBCA2") row.Item("rekbank_alamat2")
            txb_bca3.Text = IIf(row.IsNull("REKBCA3"), 0, row.Item("REKBCA3")) 'row.Item("REKBCA2") row.Item("REKBCA3")
            txb_cab3.Text = IIf(row.IsNull("rekbank_alamat3"), 0, row.Item("rekbank_alamat3"))
            statusq = row.Item("Rec_Stat").ToString
            cbstatus.EditValue = IIf(statusq.ToString = True, "Aktif", "Tidak Aktif")
            Txtket.Text = row.Item("Keterangan").ToString
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
    Public Sub edit_click()

        daedit = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nasabah_id,Nama ,foto as [foto],jns_kel as [Jenis_kelamin] from anggota", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dsedit.Tables("lookup_Pegawai") Is Nothing Then dsedit.Tables("lookup_Pegawai").Clear()
        daedit.Fill(dsedit, "lookup_Pegawai")
        frmCari.set_dso(dsedit.Tables("lookup_Pegawai")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then
            reload_table(frmCari.row(0))

            STATE = "EDIT"
            btnDelete = False
            btnSave = True
            btnEdit = False
            btnCancel = True
            btnadd = False
            setStatus()
        Else
            cancel_click()
            STATE = ""
        End If
        ' End If
    End Sub
    Private Function IsEmptyText(ByVal objText() As System.Windows.Forms.TextBox) As Boolean
        Dim i As Integer

        For i = 0 To objText.GetUpperBound(0) ' lakukan perulangan sebanyak array objek
            If Not (objText(i).Text.Length > 0) Then ' validas inputkan text, klo enggak diisi tampilkan peringatan
                MessageBox.Show("Maaf isian data belum lengkap !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                objText(i).Focus()

                Return True
            End If
        Next
        Return False
    End Function

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        'Dim BTRANS As SqlTransactionFoto

        Dim isvalid As Boolean = True
        If txb_rek.Text = "" Then
            MsgBox("Lengkapi isian: No Rek blm di isi", MsgBoxStyle.Exclamation)
            Exit Sub

        ElseIf tboNIP.Text = "" Then
            MsgBox("Lengkapi isian: NIP Nasabah ID blm di isi", MsgBoxStyle.Exclamation)
            Exit Sub
            'ElseIf LookUpJbt.EditValue = vbNullString Then

        End If

        If TextBoxnama.Text = "" Then
            ErrorProvider1.SetError(TextBoxnama, "Nama belum diisi!")
            Exit Sub
        Else
            ErrorProvider1.SetError(TextBoxnama, "")
        End If
        If TextAlamat1.Text = "" Then
            ErrorProvider2.SetError(TextAlamat1, "Alamat belum diisi!")
            ' isvalid = False
            Exit Sub
        Else
            ErrorProvider2.SetError(TextAlamat1, "")
        End If
        If TextTelpon1.Text = "" Then
            ErrorProvider3.SetError(TextTelpon1, "No Telp belum diisi!")
            'isvalid = False
            Exit Sub
        Else
            ErrorProvider3.SetError(TextTelpon1, "")
        End If

        If Not isDelete Then
            If PictureBox1.ImageLocation = "" Then
                Dim tmpFoto As Image = PictureBox2.Image
                Dim asalFoto As New Bitmap(tmpFoto)

                Dim tinggi As Integer = (180 / asalFoto.Width) * asalFoto.Height
                Dim hasilFoto As New Bitmap(180, tinggi)

                Dim gbr As Graphics = Graphics.FromImage(hasilFoto)
                gbr.DrawImage(asalFoto, 0, 0, hasilFoto.Width + 1, hasilFoto.Height + 1)

                'gbrFoto = Image.FromFile(pathFoto)
                gbrFoto = hasilFoto

                'Image to byte[]     
                fotoMemoryStream = New IO.MemoryStream()
                foto = Nothing
                gbrFoto.Save(fotoMemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
                foto = fotoMemoryStream.GetBuffer()

                'Byte[] to image     
                fotoMemoryStream = New IO.MemoryStream(foto)
                gbrFoto = Drawing.Image.FromStream(fotoMemoryStream)

                If STATE = "ADD" Then

                    dSO1 = New DataSet
                    DA1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from anggota where 1=0", sqlconn))
                    DA1.Fill(dSO1, "SIF_Pegawai") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
                    row = dSO1.Tables("SIF_Pegawai").NewRow
                    'row.Item("id_cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
                    ''''''''''''''''''''''''''''''''''''''''''
                    row.Item("nasabah_id") = tboNIP.Text 'getNoTrans("MPEG", getTanggal)
                    row.Item("NIP") = tboNIP.Text
                    row.Item("NABS") = getNoTrans("MPEG", getTanggal)
                    row.Item("Id_serial") = tboKTP.Text
                    row.Item("nama") = TextBoxnama.Text
                    row.Item("sts_anggota") = LE_Peg.EditValue
                    row.Item("Almt_asal") = TextAlamat1.Text
                    row.Item("almt_skrg") = txt_Ket_Jab.Text
                    row.Item("job_nama") = txt_Ket_Jab.Text
                    row.Item("kode_kota") = LookupKota11.EditValue
                    row.Item("telp_asal") = TextTelpon1.Text
                    row.Item("telp_skrg") = TextTelpon2.Text
                    row.Item("Tmp_lahir") = TextTempat.Text
                    row.Item("Tgl_lahir") = DateTimePicker3.Value
                    row.Item("jns_kel") = IIf(ComboBoxJK.Text = "PRIA", "P", "W")
                    row.Item("stat_nikah") = ComboBoxSP.EditValue
                    row.Item("tgl_masuk") = dtpMasuk.Value
                    row.Item("status_anggota") = c_statusk.EditValue
                    row.Item("depsec") = IIf(LookUpDPT.EditValue = vbNullString, 0, LookUpDPT.EditValue)
                    'row.Item("Kode_Bagian") = LookUpBagian.EditValue
                    row.Item("job_id") = LookUpJbt.EditValue
                    row.Item("Keterangan") = Txtket.Text
                    row.Item("Peg_NPWP") = TextNPWP.Text
                    row.Item("No_Jamsostek") = TextJamsostek.Text
                    row.Item("REKBCA1") = txb_rek.Text
                    row.Item("rekbank_alamat1") = tboNamaBank.Text
                    row.Item("REKBCA2") = txb_bca2.Text
                    row.Item("rekbank_alamat2") = txb_cab2.Text
                    row.Item("REKBCA3") = txb_bca3.Text
                    row.Item("rekbank_alamat3") = txb_cab3.Text
                    row.Item("Rec_Stat") = IIf(cbstatus.Text = "AKTIF", True, False)
                    row.Item("Keterangan") = Txtket.Text
                    row("Foto") = foto
                    row.Item("Last_Create_Date") = Now
                    row.Item("Last_Created_By") = umum.username
                    row.Item("Program_Name") = Me.Name

                    ''''''''''
                ElseIf STATE = "EDIT" Then
                    row = dSO1.Tables(0).Rows(0)
                    row.Item("nasabah_id") = tboNIP.Text 'getNoTrans("MPEG", getTanggal)
                    row.Item("NIP") = tboNIP.Text
                    row.Item("NABS") = tboAbs.Text
                    row.Item("Id_serial") = tboKTP.Text
                    row.Item("nama") = TextBoxnama.Text
                    'row.Item("sts_kb") = CheckEdit1.EditValue
                    row.Item("Almt_asal") = TextAlamat1.Text
                    row.Item("almt_skrg") = txt_Ket_Jab.Text
                    row.Item("job_nama") = txt_Ket_Jab.Text
                    row.Item("kode_kota") = LookupKota11.EditValue
                    row.Item("telp_asal") = TextTelpon1.Text
                    row.Item("telp_skrg") = TextTelpon2.Text
                    row.Item("Tmp_lahir") = TextTempat.Text
                    row.Item("Tgl_lahir") = DateTimePicker3.Value
                    row.Item("jns_kel") = IIf(ComboBoxJK.Text = "PRIA", "P", "W")
                    row.Item("stat_nikah") = ComboBoxSP.EditValue
                    row.Item("tgl_masuk") = dtpMasuk.Value
                    row.Item("status_anggota") = c_statusk.EditValue
                    row.Item("depsec") = IIf(LookUpDPT.EditValue = vbNullString, 0, LookUpDPT.EditValue)
                    'row.Item("Kode_Bagian") = LookUpBagian.EditValue
                    row.Item("job_id") = LookUpJbt.EditValue
                    row.Item("Keterangan") = Txtket.Text
                    row.Item("Peg_NPWP") = TextNPWP.Text
                    row.Item("No_Jamsostek") = TextJamsostek.Text
                    row.Item("REKBCA1") = txb_rek.Text
                    row.Item("rekbank_alamat1") = tboNamaBank.Text
                    row.Item("REKBCA2") = txb_bca2.Text
                    row.Item("rekbank_alamat2") = txb_cab2.Text
                    row.Item("REKBCA3") = txb_bca3.Text
                    row.Item("rekbank_alamat3") = txb_cab3.Text
                    row.Item("Rec_Stat") = IIf(cbstatus.Text = "AKTIF", True, False)
                    row.Item("Keterangan") = Txtket.Text
                    row("Foto") = foto
                    row.Item("Last_Create_Date") = Now
                    row.Item("Last_Created_By") = umum.username
                    row.Item("Program_Name") = Me.Name
                End If

            Else
                If STATE = "ADD" Then

                    dSO1 = New DataSet
                    DA1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from anggota where 1=0", sqlconn))
                    DA1.Fill(dSO1, "SIF_Pegawai") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
                    row = dSO1.Tables("SIF_Pegawai").NewRow
                    row.Item("id_cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
                    ''''''''''''''''''''''''''''''''''''''''''
                    row.Item("nasabah_id") = tboNIP.Text ' getNoTrans("MPEG", getTanggal)
                    row.Item("NIP") = tboNIP.Text
                    row.Item("NABS") = getNoTrans("MPEG", getTanggal)
                    'row.Item("sts_kb") = CheckEdit1.EditValue
                    row.Item("Id_serial") = tboKTP.Text
                    row.Item("nama") = TextBoxnama.Text
                    row.Item("Almt_asal") = TextAlamat1.Text
                    row.Item("almt_skrg") = txt_Ket_Jab.Text
                    row.Item("kode_kota") = LookupKota11.EditValue
                    row.Item("job_nama") = txt_Ket_Jab.Text
                    row.Item("telp_asal") = TextTelpon1.Text
                    row.Item("telp_skrg") = TextTelpon2.Text
                    row.Item("Tmp_lahir") = TextTempat.Text
                    row.Item("Tgl_lahir") = DateTimePicker3.Value
                    row.Item("jns_kel") = IIf(ComboBoxJK.Text = "PRIA", "P", "W")
                    row.Item("stat_nikah") = ComboBoxSP.EditValue
                    row.Item("tgl_masuk") = dtpMasuk.Value
                    row.Item("status_anggota") = c_statusk.EditValue
                    row.Item("depsec") = IIf(LookUpDPT.EditValue = vbNullString, 0, LookUpDPT.EditValue)
                    'row.Item("Kode_Bagian") = LookUpBagian.EditValue
                    row.Item("job_id") = LookUpJbt.EditValue
                    row.Item("Keterangan") = Txtket.Text
                    row.Item("Peg_NPWP") = TextNPWP.Text
                    row.Item("No_Jamsostek") = TextJamsostek.Text
                    row.Item("REKBCA1") = txb_rek.Text
                    row.Item("rekbank_alamat1") = tboNamaBank.Text
                    row.Item("REKBCA2") = txb_bca2.Text
                    row.Item("rekbank_alamat2") = txb_cab2.Text
                    row.Item("REKBCA3") = txb_bca3.Text
                    row.Item("rekbank_alamat3") = txb_cab3.Text
                    row.Item("Rec_Stat") = IIf(cbstatus.Text = "AKTIF", True, False)
                    row.Item("Keterangan") = Txtket.Text
                    row("Foto") = foto
                    row.Item("Last_Create_Date") = Now
                    row.Item("Last_Created_By") = umum.username
                    row.Item("Program_Name") = Me.Name

                    ''''''''''
                ElseIf STATE = "EDIT" Then
                    row = dSO1.Tables(0).Rows(0)
                    row.Item("NIP") = tboNIP.Text
                    row.Item("NABS") = tboAbs.Text
                    row.Item("Id_serial") = tboKTP.Text
                    row.Item("nama") = TextBoxnama.Text
                    'row.Item("sts_kb") = CheckEdit1.EditValue
                    row.Item("Almt_asal") = TextAlamat1.Text
                    row.Item("almt_skrg") = txt_Ket_Jab.Text
                    row.Item("kode_kota") = LookupKota11.EditValue
                    row.Item("job_nama") = txt_Ket_Jab.Text
                    row.Item("telp_asal") = TextTelpon1.Text
                    row.Item("telp_skrg") = TextTelpon2.Text
                    row.Item("Tmp_lahir") = TextTempat.Text
                    row.Item("Tgl_lahir") = DateTimePicker3.Value
                    row.Item("jns_kel") = IIf(ComboBoxJK.Text = "PRIA", "P", "W")
                    row.Item("stat_nikah") = ComboBoxSP.EditValue
                    row.Item("tgl_masuk") = dtpMasuk.Value
                    row.Item("status_anggota") = c_statusk.EditValue
                    row.Item("depsec") = IIf(LookUpDPT.EditValue = vbNullString, 0, LookUpDPT.EditValue)
                    'row.Item("Kode_Bagian") = LookUpBagian.EditValue
                    row.Item("job_id") = LookUpJbt.EditValue
                    row.Item("Keterangan") = Txtket.Text
                    row.Item("Peg_NPWP") = TextNPWP.Text
                    row.Item("No_Jamsostek") = TextJamsostek.Text
                    row.Item("REKBCA1") = txb_rek.Text
                    row.Item("rekbank_alamat1") = tboNamaBank.Text
                    row.Item("REKBCA2") = txb_bca2.Text
                    row.Item("rekbank_alamat2") = txb_cab2.Text
                    row.Item("REKBCA3") = txb_bca3.Text
                    row.Item("rekbank_alamat3") = txb_cab3.Text
                    row.Item("Rec_Stat") = IIf(cbstatus.Text = "AKTIF", True, False)
                    row.Item("Keterangan") = Txtket.Text
                    row("Foto") = foto
                    row.Item("Last_Create_Date") = Now
                    row.Item("Last_Created_By") = umum.username
                    row.Item("Program_Name") = Me.Name
                End If
            End If
        End If
        If STATE = "ADD" Then
            dSO1.Tables(0).Rows.Add(row) ' bisa juga ditulis seperti ini, pakai array index, menggantikan "SIF_WILAYAH"
        End If
        Try
            Buildernya = New SqlClient.SqlCommandBuilder(DA1)
            DA1.UpdateCommand = Buildernya.GetUpdateCommand()
            DA1.InsertCommand = Buildernya.GetInsertCommand()
            'DA1.DeleteCommand = Buildernya.GetDeleteCommand()

            'BTRANS = sqlconn.BeginTransaction("1")
            'DA1.UpdateCommand.Transaction = BTRANS
            'DA1.InsertCommand.Transaction = BTRANS
            'DA1.DeleteCommand.Transaction = BTRANS

            DA1.Update(dSO1.Tables("SIF_Pegawai"))
            dSO1.Tables("SIF_Pegawai").AcceptChanges()
            STATE = "EDIT"
            TextBoxKode.Text = row("nasabah_id")
            'BTRANS.Commit()
            showMessages("Berhasil disimpan..")
            cancel_click()
            If Not dSO1 Is Nothing Then
                dSO1.Clear()
            End If
            DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from anggota", sqlconn))
            DA2.Fill(dsete, "PEGAWAI")

            dsete.Tables("PEGAWAI").Clear()
            DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from anggota order by tgl_masuk desc", sqlconn))
            DA2.Fill(dsete, "PEGAWAI")
            GC.DataSource = dsete.Tables("PEGAWAI")
            disabel()
        Catch e As Exception
            'BTRANS.Rollback()
            dSO1.Tables(0).RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message)
        End Try
        'setStatus()
        'btnadd = True
        'btnSave = True

        'End If
    End Sub

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder
        STATE = "ADD" '<-- set state add
        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        btnDelete = False
        enabel()
        'masterpegawai.Enabled = True
        masterpegawai.SelectedTabPage = XtraTabPage1
        setStatus()

        c_statusk.EditValue = "BIASA"
        cbstatus.EditValue = "AKTIF"
        LookUpJbt.EditValue = 2
        ComboBoxJK.EditValue = "Pria"
        txtNama.Focus()

    End Sub
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        save_click()
        setStatus()


    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        add_click()


    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cancel_click()
        Clear_ALL()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        delete_click()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        edit_click()
        STATE = "EDIT"
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Browse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            OpenFileDialog1.Filter = "jpg (*.jpg)|*.jpg|jpeg (*.jpeg)|*.jpeg|bmp (*.bmp)|*.bmp|png (*.png)|*.png|gif (*.gif)|*.gif"
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName <> "" Then
                pathFoto = OpenFileDialog1.FileName
                PictureBox2.ImageLocation = pathFoto

                Dim tmpFoto As Image = Image.FromFile(pathFoto)
                Dim asalFoto As New Bitmap(tmpFoto)

                Dim tinggi As Integer = (180 / asalFoto.Width) * asalFoto.Height
                Dim hasilFoto As New Bitmap(180, tinggi)

                Dim gbr As Graphics = Graphics.FromImage(hasilFoto)
                gbr.DrawImage(asalFoto, 0, 0, hasilFoto.Width + 1, hasilFoto.Height + 1)

                'gbrFoto = Image.FromFile(pathFoto)
                gbrFoto = hasilFoto

                'Image to byte[]     
                fotoMemoryStream = New IO.MemoryStream()
                foto = Nothing
                gbrFoto.Save(fotoMemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
                foto = fotoMemoryStream.GetBuffer()

                'Byte[] to image     
                fotoMemoryStream = New IO.MemoryStream(foto)
                gbrFoto = Drawing.Image.FromStream(fotoMemoryStream)

                'frame.Image = gbrFoto
            End If
        Catch ex As Exception
            'frame.Image = frame.InitialImage
        End Try
    End Sub

    Private Sub validasi_entry(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Char.IsLetter(e.KeyChar)) Then
            ErrorProvider1.SetError(sender, "Peringatan! Mohon isi data dengan BENAR")
            e.Handled = True

        Else
            ErrorProvider1.SetError(sender, "")
        End If
    End Sub


    Private Sub Browse_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browse.Click
        Try
            OpenFileDialog1.Filter = "jpg (*.jpg)|*.jpg|jpeg (*.jpeg)|*.jpeg|bmp (*.bmp)|*.bmp|png (*.png)|*.png|gif (*.gif)|*.gif"
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName <> "" Then
                pathFoto = OpenFileDialog1.FileName
                PictureBox2.ImageLocation = pathFoto

                Dim tmpFoto As Image = Image.FromFile(pathFoto)
                Dim asalFoto As New Bitmap(tmpFoto)

                Dim tinggi As Integer = (180 / asalFoto.Width) * asalFoto.Height
                Dim hasilFoto As New Bitmap(180, tinggi)

                Dim gbr As Graphics = Graphics.FromImage(hasilFoto)
                gbr.DrawImage(asalFoto, 0, 0, hasilFoto.Width + 1, hasilFoto.Height + 1)

                'gbrFoto = Image.FromFile(pathFoto)
                gbrFoto = hasilFoto

                'Image to byte[]     
                fotoMemoryStream = New IO.MemoryStream()
                foto = Nothing
                gbrFoto.Save(fotoMemoryStream, System.Drawing.Imaging.ImageFormat.Jpeg)
                foto = fotoMemoryStream.GetBuffer()

                'Byte[] to image     
                fotoMemoryStream = New IO.MemoryStream(foto)
                gbrFoto = Drawing.Image.FromStream(fotoMemoryStream)

                'frame.Image = gbrFoto
            End If
        Catch ex As Exception
            'frame.Image = frame.InitialImage
        End Try
    End Sub

    Public Sub cetak_click()
        Try

            GVSpon.OptionsPrint.Reset()
            GVSpon.GridControl.ShowPrintPreview()
        Catch ex As Exception
            MsgBox("Error Printing : " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Printing")
        End Try
    End Sub


    Private Sub TextTelpon1_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextTelpon1.KeyPress
        Select Case Asc(e.KeyChar)
            'Case 65 To 90 'dari a-z
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 32, 8, 46, 40, 41, 43
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub TextTelpon2_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextTelpon2.KeyPress
        Select Case Asc(e.KeyChar)
            'Case 65 To 90 'dari a-z
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 32, 8, 46, 40, 41, 43
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub TextNPWP_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextNPWP.KeyPress
        Select Case Asc(e.KeyChar)
            'Case 65 To 90 'dari a-z
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 32, 8, 46, 40, 41, 43
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub TextRek_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txb_rek.KeyPress
        'Select Case Asc(e.KeyChar)
        '    'Case 65 To 90 'dari a-z
        '    Case 48 To 57 'dari 0-9
        '        e.Handled = False
        '    Case 32, 8, 46, 40, 41, 43
        '        e.Handled = False
        '    Case Else
        '        e.Handled = True
        'End Select
    End Sub


    'Private Sub LookUpDPT_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LookUpDPT.EditValueChanged
    '    View_Bagian()
    '    dSO.Tables("View_Bagian").Clear()
    '    View_Bagian()

    'End Sub


    Private Sub GC_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GC.DoubleClick
        reload_table(GVSpon.GetRow(GVSpon.GetSelectedRows(0)).item("nasabah_id").ToString)
        enabel()
        tboNIP.Enabled = False
        STATE = "EDIT"
        prn.btnSave.Enabled = True
        prn.btnCancel.Enabled = True
        prn.btnDelete.Enabled = False
        prn.btnEdit.Enabled = False
        prn.btnAdd.Enabled = False
        masterpegawai.SelectedTabPage = XtraTabPage1
    End Sub




End Class