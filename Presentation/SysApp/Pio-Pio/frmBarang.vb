Imports System.Data.SqlClient
Public Class frmBarang
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public obj As Object
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public dSO, dSO1, DsBrg As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Dim DA, DA2, DALOOKUP, DAs As SqlClient.SqlDataAdapter
    Dim newRow As DataRow
    Dim Buildernya As New SqlClient.SqlCommandBuilder
    Public Sub setStatus()
        With prn
            btnadd = .btnAdd.Enabled
            btnCancel = .btnCancel.Enabled
            btnDelete = .btnDelete.Enabled
            btnEdit = .btnEdit.Enabled
            btnSave = .btnSave.Enabled
        End With
    End Sub
    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain

        'With prn '<- untuk sementara dimatika klau sudah digabung dengan form main ini dinyalakan lagi
        '    .btnAdd.Enabled = False ' mendisable tombol add yang ada di frmUtama
        '    .btnCancel.Enabled = True
        '    .btnDelete.Enabled = False
        '    .btnEdit.Enabled = False
        '    .btnSave.Enabled = True
        'End With
        'setStatus()
        STATE = "ADD" '<-- set state= add
    End Sub
    Private Function AutoNum() As String
        Dim hasil, temp As String
        Dim sqlDR As SqlClient.SqlDataReader = New SqlClient.SqlCommand("select MAX(substring(Nomor,1,5)+1) from DBO.SIF_Barang", sqlconn).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "001"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 2
                temp = "0" & temp
            Next
        End If
        sqlDR.Close()
        Return hasil
    End Function
    Sub tampil_GC_Barang()
        DAs = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("Select B.Kode_Barang,B.Nama_Barang,M.Nama_Merk, JB.Nama_Jenis,TB.Nama_Tipe,U.Nama_Ukuran,B.Rec_Stat from SIF.dbo.SIF_Barang B, SIF.dbo.SIF_Merk M, SIF.dbo.SIF_Jenis_Barang JB,SIF.dbo.SIF_Tipe TB, SIF.dbo.SIF_Ukuran U Where(B.kd_merk = M.Kode_Merk And B.kd_jenis = JB.Kd_Jns_Brg And B.kd_tipe = TB.Kode_Tipe And B.kd_ukuran = U.Kode_Ukuran)", sqlconn))
        DAs.Fill(DsBrg, "Barang")
        GC_Barang.DataSource = DsBrg.Tables(0)
        GVSpon.BestFitColumns()
    End Sub
    Private Sub frmBarang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        obj = getParent(Me)
        prn = obj
        V_Satuan()
        V_Departemen()
        V_Jns_Persediaan()
        V_Jns_Barang()
        V_Merk()
        V_Tipe()
        V_Sub_Tipe()
        V_Ukuran()
        V_Kain()
        V_Lokasi()
        V_Rek_Penjualan()
        V_Rek_Persediaan()
        V_Rek_Biaya()
        V_Rek_Pusat_Biaya()
        tampil_GC_Barang()
    End Sub
    Private Sub V_Satuan()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Satuan", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "LOOKUP_Satuan")
        LookUpEditSat.Properties.DataSource = dSO.Tables("LOOKUP_Satuan")
        LookUpEditSat.Properties.ValueMember = "Kode_Satuan"
        LookUpEditSat.Properties.DisplayMember = "Nama_Satuan"
    End Sub
    Private Sub V_Departemen()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Departemen", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "LOOKUP_Departemen")
        LookUpEditDep.Properties.DataSource = dSO.Tables("LOOKUP_Departemen")
        LookUpEditDep.Properties.ValueMember = "Kd_Departemen"
        LookUpEditDep.Properties.DisplayMember = "Nama_Departemen"
    End Sub
    Private Sub V_Jns_Persediaan()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Jns_Persediaan", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "LOOKUP_Persediaan")
        LookUpEditJnsPsd.Properties.DataSource = dSO.Tables("LOOKUP_Persediaan")
        LookUpEditJnsPsd.Properties.ValueMember = "Kd_Jns_Persd"
        LookUpEditJnsPsd.Properties.DisplayMember = "Nama_Persediaan"
    End Sub
    Private Sub V_Jns_Barang()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Jenis_Barang", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "LOOKUP_Jns_Barang")
        LookUpEditJnsBrg.Properties.DataSource = dSO.Tables("LOOKUP_Jns_Barang")
        LookUpEditJnsBrg.Properties.ValueMember = "Kd_Jns_Brg"
        LookUpEditJnsBrg.Properties.DisplayMember = "Nama_Jenis"
    End Sub
    Private Sub V_Merk()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Merk", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "LOOKUP_Merk")
        LookUpEditMerk.Properties.DataSource = dSO.Tables("LOOKUP_Merk")
        LookUpEditMerk.Properties.ValueMember = "Kode_Merk"
        LookUpEditMerk.Properties.DisplayMember = "Nama_Merk"
    End Sub
    Private Sub V_Tipe()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Tipe", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "LOOKUP_Tipe")
        LookUpEditTipe.Properties.DataSource = dSO.Tables("LOOKUP_Tipe")
        LookUpEditTipe.Properties.ValueMember = "Kode_Tipe"
        LookUpEditTipe.Properties.DisplayMember = "Nama_Tipe"
    End Sub
    Private Sub V_Sub_Tipe()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Sub_Tipe", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "LOOKUP_Sub_Tipe")
        LookUpEditSubTipe.Properties.DataSource = dSO.Tables("LOOKUP_Sub_Tipe")
        LookUpEditSubTipe.Properties.ValueMember = "Kd_Sub_Tipe"
        LookUpEditSubTipe.Properties.DisplayMember = "Nama_Sub_Tipe"
    End Sub
    Private Sub V_Ukuran()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Ukuran", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "LOOKUP_Ukuran")
        LookUpEditUkuran.Properties.DataSource = dSO.Tables("LOOKUP_Ukuran")
        LookUpEditUkuran.Properties.ValueMember = "Kode_Ukuran"
        LookUpEditUkuran.Properties.DisplayMember = "Nama_Ukuran"
    End Sub
    Private Sub V_Kain()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Kain", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "LOOKUP_Kain")
        LookUpEditKain.Properties.DataSource = dSO.Tables("LOOKUP_Kain")
        LookUpEditKain.Properties.ValueMember = "Kode_Kain"
        LookUpEditKain.Properties.DisplayMember = "Merk_Kain"
    End Sub
    Private Sub V_Lokasi()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Gudang", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "LOOKUP_Gudang")
        LookUpEditLokasi.Properties.DataSource = dSO.Tables("LOOKUP_Gudang")
        LookUpEditLokasi.Properties.ValueMember = "Kode_Gudang"
        LookUpEditLokasi.Properties.DisplayMember = "Nama_Gudang"
    End Sub
    Private Sub V_Rek_Penjualan()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Buku_Besar", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "LOOKUP_Rek_Penjualan")
        LookUpEditBkBsr1.Properties.DataSource = dSO.Tables("LOOKUP_Rek_Penjualan")
        LookUpEditBkBsr1.Properties.ValueMember = "kd_buku_Besar"
        LookUpEditBkBsr1.Properties.DisplayMember = "nm_buku_Besar"
    End Sub
    Private Sub V_Rek_Persediaan()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Buku_Besar", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "LOOKUP_Rek_Persediaan")
        LookUpEditBkBsr2.Properties.DataSource = dSO.Tables("LOOKUP_Rek_Persediaan")
        LookUpEditBkBsr2.Properties.ValueMember = "kd_buku_Besar"
        LookUpEditBkBsr2.Properties.DisplayMember = "nm_buku_Besar"
    End Sub
    Private Sub V_Rek_Biaya()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Buku_Besar", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "LOOKUP_Rek_Biaya")
        LookUpEditBkBsr3.Properties.DataSource = dSO.Tables("LOOKUP_Rek_Biaya")
        LookUpEditBkBsr3.Properties.ValueMember = "kd_buku_Besar"
        LookUpEditBkBsr3.Properties.DisplayMember = "nm_buku_Besar"
    End Sub
    Private Sub V_Rek_Pusat_Biaya()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Buku_Pusat", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "LOOKUP_Rek_Pusat_Biaya")
        LookUpEditBkPusat.Properties.DataSource = dSO.Tables("LOOKUP_Rek_Pusat_Biaya")
        LookUpEditBkPusat.Properties.ValueMember = "kd_buku_pusat"
        LookUpEditBkPusat.Properties.DisplayMember = "nm_buku_pusat"
    End Sub
    Public Sub save_click()

        If STATE = "ADD" Then

            dSO1 = New DataSet
            DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Barang where 1=0", sqlconn))
            DA2.Fill(dSO1, "SIF_Barang") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_.....(nama table bisa diisi sembarang)
            row = dSO1.Tables("SIF_Barang").NewRow

            row.Item("Kd_Cabang") = 1 ' <-- hanya contoh, nanti diisi dengan yg bener
            row.Item("Kode_Barang") = txtKodeBarang.Text
            row("Kd_Satuan") = LookUpEditSat.EditValue
            row.Item("Nama_Barang") = txtNamaBarang.Text
            row("Kd_Depart") = LookUpEditDep.EditValue
            row("kd_jns_persd") = LookUpEditJnsPsd.EditValue
            row("kd_jenis") = LookUpEditJnsBrg.EditValue
            row("kd_merk") = LookUpEditMerk.EditValue
            row("kd_tipe") = LookUpEditTipe.EditValue
            row("kd_sub_tipe") = LookUpEditSubTipe.EditValue
            row("kd_ukuran") = LookUpEditUkuran.EditValue
            row("kd_kain") = LookUpEditKain.EditValue
            row("no_urut") = "00" ' AutoNum() 'LookUpEditArea.EditValue
            row("lokasi") = LookUpEditLokasi.EditValue
            row("stok_min") = txtSMin.Text
            row("stok_max_av") = txtSMak.Text
            row("keterangan") = txtketerangan.Text
            row("rek_penjualan") = LookUpEditBkBsr1.EditValue
            row("rek_persediaan") = LookUpEditBkBsr2.EditValue
            row("rek_biaya") = LookUpEditBkBsr3.EditValue
            row("rek_pusat_biaya") = LookUpEditBkPusat.EditValue
            row("Rec_Stat") = IIf(cbStatus.Text = "AKTIF", "Y", "T")
            row("Last_Create_Date") = Now
            row("Last_Created_By") = umum.username
            row("Last_Update_Date") = Now
            row("Last_Updated_By") = umum.username
            row("Program_Name") = Me.Name
            ''''''''''
        ElseIf STATE = "EDIT" Then
            row = dSO.Tables(0).Rows(0)
            row.Item("Nama_Barang") = txtNamaBarang.Text
            row("Keterangan") = txtketerangan.Text
            row("Rec_Stat") = IIf(cbStatus.Text = "AKTIF", "Y", "T")
            row("Last_Create_Date") = Now
            row("Last_Created_By") = umum.username
            row("Last_Update_Date") = Now
            row("Last_Updated_By") = umum.username
            row("Program_Name") = Me.Name
        End If

        If STATE = "ADD" Then
            dSO1.Tables(0).Rows.Add(row) ' bisa juga ditulis seperti ini, pakai array index, menggantikan "SIF_WILAYAH"
        End If


        ' Try
       
        Buildernya = New SqlClient.SqlCommandBuilder(DA2)
        DA2.InsertCommand = Buildernya.GetInsertCommand()

        DA2.Update(dSO1.Tables("SIF_Barang"))
        dSO1.Tables("SIF_Barang").AcceptChanges()
        STATE = "EDIT"
        txtKodeBarang.Text = row("Kode_Barang")
        MsgBox("Data Tersimpan !")
        'Catch e As Exception
        '    dSO.Tables(0).RejectChanges() ' untuk membatalkan row yg diupdate/insert
        '    MsgBox(e.Message)
        'End Try
    End Sub
    Public Sub edit_click()

        ' bila menggunakan form cari
        dSO = New DataSet
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Barang", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "LOOKUP_SIF_Barang")
        frmCari.set_dso(dSO.Tables(0))
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then
            dSO = New DataSet
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Barang where [Kode_Barang]='" & frmCari.row("Kode_Barang") & "'", sqlconn))
            DA.Fill(dSO, "Barang") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
            ' STATE = "EDIT"
            If dSO.Tables(0).Rows.Count > 0 Then
                txtKodeBarang.Text = dSO.Tables(0).Rows(0).Item("Kode_Barang").ToString
                txtNamaBarang.Text = dSO.Tables(0).Rows(0).Item("nama_Barang").ToString
                txtKeterangan.Text = dSO.Tables(0).Rows(0).Item("keterangan").ToString
                cbStatus.Text = IIf(dSO.Tables("Barang")(0)("Rec_Stat").ToString = "Y", "AKTIF", "TIDAK AKTIF")
                LookUpEditSat.EditValue = LookUpEditSat.Properties.GetKeyValueByDisplayValue(dSO.Tables(0).Rows(0).Item("Kd_Satuan").ToString)
                'LookUpEditDep.EditValue = LookUpEditDep.Properties.GetKeyValueByDisplayValue(dSO.Tables(0).Rows(0).Item("Kd_Depart").ToString)
                'LookUpEditJnsBrg.EditValue = LookUpEditJnsBrg.Properties.GetKeyValueByDisplayValue(dSO.Tables(0).Rows(0).Item("kd_jenis").ToString)
                'LookUpEditJnsPsd.EditValue = LookUpEditJnsPsd.Properties.GetKeyValueByDisplayValue(dSO.Tables(0).Rows(0).Item("kd_jns_persd").ToString)
                'LookUpEditMerk.EditValue = LookUpEditMerk.Properties.GetKeyValueByDisplayValue(dSO.Tables(0).Rows(0).Item("kd_merk").ToString)
                'LookUpEditTipe.EditValue = LookUpEditTipe.Properties.GetKeyValueByDisplayValue(dSO.Tables(0).Rows(0).Item("kd_tipe").ToString)
                'LookUpEditSubTipe.EditValue = LookUpEditSubTipe.Properties.GetKeyValueByDisplayValue(dSO.Tables(0).Rows(0).Item("kd_sub_tipe").ToString)
                'LookUpEditUkuran.EditValue = LookUpEditUkuran.Properties.GetKeyValueByDisplayValue(dSO.Tables(0).Rows(0).Item("kd_ukuran").ToString)
                'LookUpEditKain.EditValue = LookUpEditKain.Properties.GetKeyValueByDisplayValue(dSO.Tables(0).Rows(0).Item("kd_kain").ToString)
                'LookUpEditLokasi.EditValue = LookUpEditLokasi.Properties.GetKeyValueByDisplayValue(dSO.Tables(0).Rows(0).Item("lokasi").ToString)
                'LookUpEditBkBsr1.EditValue = LookUpEditBkBsr1.Properties.GetKeyValueByDisplayValue(dSO.Tables(0).Rows(0).Item("rek_penjualan1").ToString)
                'LookUpEditBkBsr2.EditValue = LookUpEditBkBsr2.Properties.GetKeyValueByDisplayValue(dSO.Tables(0).Rows(0).Item("rek_persediaan").ToString)
                'LookUpEditBkBsr3.EditValue = LookUpEditBkBsr3.Properties.GetKeyValueByDisplayValue(dSO.Tables(0).Rows(0).Item("rek_biaya").ToString)
                'LookUpEditBkPusat.EditValue = LookUpEditBkPusat.Properties.GetKeyValueByDisplayValue(dSO.Tables(0).Rows(0).Item("rek_pusat_biaya").ToString)

                STATE = "EDIT"
                prn.btnSave.Enabled = True
                prn.btnCancel.Enabled = True
                prn.btnDelete.Enabled = False
            Else
                MsgBox("Data tidak diketemukan")
            End If
        End If
    End Sub
    Public Sub cancel_click()
        clear_field()
        With prn '<- untuk sementara dimatika klau sudah digabung dengan form main ini dinyalakan lagi
            .btnAdd.Enabled = True ' mendisable tombol add yang ada di frmUtama
            .btnCancel.Enabled = False
            .btnDelete.Enabled = False
            .btnEdit.Enabled = True
            .btnSave.Enabled = False
        End With
        STATE = ""
        Me.Enabled = False
        setStatus()
    End Sub
    Private Sub clear_field()
        dSO = New DataSet
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Barang where 1=0", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "Barang")

        txtKeterangan.Text = ""
        txtKodeBarang.Text = ""
        txtNamaBarang.Text = ""
        cbStatus.Text = ""
    End Sub
   
End Class