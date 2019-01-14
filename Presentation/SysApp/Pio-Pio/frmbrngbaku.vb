Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Public Class frmbrngbaku

    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False

    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim obj As Object
    Dim dSO, dsete, dsedit, ds1 As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Dim row, row1 As DataRow '<-- menampung row master
    Dim DA, DA2, daedit, Da5, dakota As SqlClient.SqlDataAdapter
    Dim myBuilder, myBuilder1 As New SqlClient.SqlCommandBuilder
    Dim kodex As Integer

    Dim a, b, c, d, e, f, g, h As String
    Dim sukses As String

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Sub View_Satuan()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Satuan,Nama_Satuan from sif.dbo.SIF_Satuan", sqlconn))
        DA.Fill(dSO, "View_Satuan")
        LookUpEditstuan.Properties.DataSource = dSO.Tables("View_Satuan")
        LookUpEditstuan.Properties.ValueMember = "Kode_Satuan"
        LookUpEditstuan.Properties.DisplayMember = "Nama_Satuan"
    End Sub

    Sub View_Departemen()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Departemen,Nama_Departemen from sif.dbo.SIF_Departemen", sqlconn))
        DA.Fill(dSO, "View_Departemen")
        LookUpEditdivisi.Properties.DataSource = dSO.Tables("View_Departemen")
        LookUpEditdivisi.Properties.ValueMember = "Kd_Departemen"
        LookUpEditdivisi.Properties.DisplayMember = "Nama_Departemen"
    End Sub
    Sub View_Jenis_Barang()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Jns_Brg,Nama_Jenis from sif.dbo.SIF_Jenis_Barang", sqlconn))
        DA.Fill(dSO, "View_Jenis_Barang")
        LookUpEditjnsbrg.Properties.DataSource = dSO.Tables("View_Jenis_Barang")
        LookUpEditjnsbrg.Properties.ValueMember = "Kd_Jns_Brg"
        LookUpEditjnsbrg.Properties.DisplayMember = "Nama_Jenis"
    End Sub
    Sub View_Merk()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Merk,Nama_Merk from sif.dbo.SIF_Merk", sqlconn))
        DA.Fill(dSO, "View_Merk")
        LookUpEditmerk.Properties.DataSource = dSO.Tables("View_Merk")
        LookUpEditmerk.Properties.ValueMember = "Kode_Merk"
        LookUpEditmerk.Properties.DisplayMember = "Nama_Merk"
    End Sub
    Sub View_Tipe()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Tipe,Nama_Tipe from sif.dbo.SIF_Tipe", sqlconn))
        DA.Fill(dSO, "View_Tipe")
        LookUpEdittpbrg.Properties.DataSource = dSO.Tables("View_Tipe")
        LookUpEdittpbrg.Properties.ValueMember = "Kode_Tipe"
        LookUpEdittpbrg.Properties.DisplayMember = "Nama_Tipe"
    End Sub
    Sub View_sub_Tipe()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Sub_Tipe,Nama_Sub_Tipe from sif.dbo.SIF_Sub_Tipe", sqlconn))
        DA.Fill(dSO, "View_sub_Tipe")
        LookUpEditsubtp.Properties.DataSource = dSO.Tables("View_sub_Tipe")
        LookUpEditsubtp.Properties.ValueMember = "Kd_Sub_Tipe"
        LookUpEditsubtp.Properties.DisplayMember = "Nama_Sub_Tipe"
    End Sub
    Sub View_Ukuran()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Ukuran,Nama_Ukuran from sif.dbo.SIF_Ukuran", sqlconn))
        DA.Fill(dSO, "View_Ukuran")
        LookUpEditukrn.Properties.DataSource = dSO.Tables("View_Ukuran")
        LookUpEditukrn.Properties.ValueMember = "Kode_Ukuran"
        LookUpEditukrn.Properties.DisplayMember = "Nama_Ukuran"
    End Sub
    Sub View_Kain()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Kain,Merk_Kain from sif.dbo.SIF_Kain", sqlconn))
        DA.Fill(dSO, "View_Kain")
        LookUpEditkain.Properties.DataSource = dSO.Tables("View_Kain")
        LookUpEditkain.Properties.ValueMember = "Kode_Kain"
        LookUpEditkain.Properties.DisplayMember = "Merk_Kain"
    End Sub
    Sub View_lokasi()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Gudang,Nama_Gudang from sif.dbo.SIF_Gudang", sqlconn))
        DA.Fill(dSO, "View_lokasi")
        LookUpEditlokasi.Properties.DataSource = dSO.Tables("View_lokasi")
        LookUpEditlokasi.Properties.ValueMember = "Kode_Gudang"
        LookUpEditlokasi.Properties.DisplayMember = "Nama_Gudang"
    End Sub
    Sub View_rek_penjualan1()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Buku_Besar,Nm_Buku_Besar from sif.dbo.SIF_Buku_Besar", sqlconn))
        DA.Fill(dSO, "rek_penjualan1")
        LookUpEditrekjual1.Properties.DataSource = dSO.Tables("rek_penjualan1")
        LookUpEditrekjual1.Properties.ValueMember = "Kd_Buku_Besar"
        LookUpEditrekjual1.Properties.DisplayMember = "Nm_Buku_Besar"
    End Sub
    Sub View_rek_penjualan2()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Buku_Besar,Nm_Buku_Besar from sif.dbo.SIF_Buku_Besar", sqlconn))
        DA.Fill(dSO, "rek_penjualan2")
        LookUpEditrekjual2.Properties.DataSource = dSO.Tables("rek_penjualan2")
        LookUpEditrekjual2.Properties.ValueMember = "Kd_Buku_Besar"
        LookUpEditrekjual2.Properties.DisplayMember = "Nm_Buku_Besar"
    End Sub

    Sub View_rek_persediaan()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Buku_Besar,Nm_Buku_Besar from sif.dbo.SIF_Buku_Besar", sqlconn))
        DA.Fill(dSO, "rek_persediaan")
        LookUpEditrekpersediaan.Properties.DataSource = dSO.Tables("rek_persediaan")
        LookUpEditrekpersediaan.Properties.ValueMember = "Kd_Buku_Besar"
        LookUpEditrekpersediaan.Properties.DisplayMember = "Nm_Buku_Besar"
    End Sub
    Private Sub frmbrngbaku_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect() ' untuk koneksi ke server, biasa kan ini ada disetiap form load
        View_Satuan()
        View_Departemen()
        View_Jenis_Barang()
        View_Merk()
        View_Tipe()
        View_sub_Tipe()
        View_Ukuran()
        View_Kain()
        View_lokasi()
        View_rek_penjualan1()
        View_rek_penjualan2()
        View_rek_persediaan()


        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_Barang Where kd_jns_persd= 3 ", sqlconn))
        DA2.Fill(dsete, "Barang")
        GridControl1.DataSource = dsete.Tables("Barang")
        GridView1.BestFitColumns()
        Txtjnsprs.Text = "Bahan Baku/Row Material"
        obj = getParent(Me)
        prn = obj
        Lookup()
        'Me.BackgroundImage = Parent.BackgroundImage 
        'pnl.Height = Me.Height - 2
        'pnl.Left = (Me.Width - pnl.Width) / 2
        'pnl.Top = (Me.Height - pnl.Height) / 2
        setStatus()
    End Sub
    Sub Lookup()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Satuan,Nama_Satuan from sif.dbo.SIF_Satuan", sqlconn))
        DA.Fill(dSO, "Satuan")
        lookupsatuan.DataSource = dSO.Tables("Satuan")
        lookupsatuan.ValueMember = "Kode_Satuan"
        lookupsatuan.DisplayMember = "Nama_Satuan"

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Departemen,Nama_Departemen from sif.dbo.SIF_Departemen", sqlconn))
        DA.Fill(dSO, "Departemen")
        lookupdepartemen.DataSource = dSO.Tables("Departemen")
        lookupdepartemen.ValueMember = "Kd_Departemen"
        lookupdepartemen.DisplayMember = "Nama_Departemen"

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Jns_Brg,Nama_Jenis from sif.dbo.SIF_Jenis_Barang", sqlconn))
        DA.Fill(dSO, "Jenis_Barang")
        lookupjenisbarang.DataSource = dSO.Tables("Jenis_Barang")
        lookupjenisbarang.ValueMember = "Kd_Jns_Brg"
        lookupjenisbarang.DisplayMember = "Nama_Jenis"

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Jns_Persd,Nama_Persediaan from sif.dbo.SIF_Jns_Persediaan", sqlconn))
        DA.Fill(dSO, "Jenis_Persediaan")
        lookupjnspersediaan.DataSource = dSO.Tables("Jenis_Persediaan")
        lookupjnspersediaan.ValueMember = "Kd_Jns_Persd"
        lookupjnspersediaan.DisplayMember = "Nama_Persediaan"

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Merk,Nama_Merk from sif.dbo.SIF_Merk", sqlconn))
        DA.Fill(dSO, "Merk")
        lookupmerk.DataSource = dSO.Tables("Merk")
        lookupmerk.ValueMember = "Kode_Merk"
        lookupmerk.DisplayMember = "Nama_Merk"

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Tipe,Nama_Tipe from sif.dbo.SIF_Tipe", sqlconn))
        DA.Fill(dSO, "Tipe")
        lookuptipe.DataSource = dSO.Tables("Tipe")
        lookuptipe.ValueMember = "Kode_Tipe"
        lookuptipe.DisplayMember = "Nama_Tipe"

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Sub_Tipe,Nama_Sub_Tipe from sif.dbo.SIF_Sub_Tipe", sqlconn))
        DA.Fill(dSO, "sub_Tipe")
        lookupsubtipe.DataSource = dSO.Tables("sub_Tipe")
        lookupsubtipe.ValueMember = "Kd_Sub_Tipe"
        lookupsubtipe.DisplayMember = "Nama_Sub_Tipe"

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Ukuran,Nama_Ukuran from sif.dbo.SIF_Ukuran", sqlconn))
        DA.Fill(dSO, "Ukuran")
        lookupukuran.DataSource = dSO.Tables("View_Ukuran")
        lookupukuran.ValueMember = "Kode_Ukuran"
        lookupukuran.DisplayMember = "Nama_Ukuran"

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Kain,Merk_Kain from sif.dbo.SIF_Kain", sqlconn))
        DA.Fill(dSO, "Kain")
        lookupkain.DataSource = dSO.Tables("Kain")
        lookupkain.ValueMember = "Kode_Kain"
        lookupkain.DisplayMember = "Merk_Kain"

        DA.Fill(dSO, "lokasi")
        lookuplokasi.DataSource = dSO.Tables("lokasi")
        lookuplokasi.ValueMember = "Kode_Gudang"
        lookuplokasi.DisplayMember = "Nama_Gudang"

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Buku_Besar,Nm_Buku_Besar from sif.dbo.SIF_Buku_Besar", sqlconn))
        DA.Fill(dSO, "rek_penjualan1")
        lookuppenj1.DataSource = dSO.Tables("rek_penjualan1")
        lookuppenj1.ValueMember = "Kd_Buku_Besar"
        lookuppenj1.DisplayMember = "Nm_Buku_Besar"

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Buku_Besar,Nm_Buku_Besar from sif.dbo.SIF_Buku_Besar", sqlconn))
        DA.Fill(dSO, "rek_penjualan2")
        lookuppenj2.DataSource = dSO.Tables("rek_penjualan2")
        lookuppenj2.ValueMember = "Kd_Buku_Besar"
        lookuppenj2.DisplayMember = "Nm_Buku_Besar"

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Buku_Besar,Nm_Buku_Besar from sif.dbo.SIF_Buku_Besar", sqlconn))
        DA.Fill(dSO, "rek_penjualan3")
        lookuppenj3.DataSource = dSO.Tables("rek_penjualan3")
        lookuppenj3.ValueMember = "Kd_Buku_Besar"
        lookuppenj3.DisplayMember = "Nm_Buku_Besar"

    End Sub
    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder
        nyala()
        GridControl1.Enabled = True
        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        btnDelete = True
        setStatus()
        STATE = "ADD" '<-- set state= add

    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        add_click() ' cuman manggil fungsi doang

    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim isvalid As Boolean = True
        'If Txtstokmin.Text = "" Then
        '    ErrorProvider1.SetError(Txtstokmin, "Nama belum diisi!")
        '    Exit Sub
        'Else
        '    ErrorProvider1.SetError(Txtstokmin, "")
        'End If
        'If TxtstokMax.Text = "" Then
        '    ErrorProvider2.SetError(TxtstokMax, "Alamat belum diisi!")
        '    ' isvalid = False
        '    Exit Sub
        'Else
        '    ErrorProvider2.SetError(TxtstokMax, "")
        'End If
        If Val(TxtstokMax.Text) <= Val(Txtstokmin.Text) Then
            ErrorProvider3.SetError(TxtstokMax, "Harus lebih besar dari stok minimal")
            'isvalid = False
            Exit Sub
        Else
            ErrorProvider3.SetError(TxtstokMax, "")
        End If

        Dim hasil, temp As String
        Dim sqlDR As SqlDataReader = New SqlCommand("select max( no_urut)+1  from SIF.dbo.SIF_Barang where kd_depart= '" & LookUpEditdivisi.EditValue & "' AND kd_jns_persd = '3'  AND kd_jenis= '" & LookUpEditjnsbrg.EditValue & "' AND kd_merk='" & LookUpEditmerk.EditValue & "' AND kd_tipe= '" & LookUpEdittpbrg.EditValue & "' AND kd_sub_tipe= '" & LookUpEditsubtp.EditValue & "' AND kd_ukuran='" & LookUpEditukrn.EditValue & "'AND kd_kain= '" & LookUpEditkain.EditValue & "' ", sqlconn).ExecuteReader
        sqlDR.Read()
        temp = ""
        hasil = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            temp = "001"
            hasil = LookUpEditdivisi.EditValue & "3" & LookUpEditjnsbrg.EditValue & LookUpEditmerk.EditValue & LookUpEdittpbrg.EditValue & LookUpEditsubtp.EditValue & LookUpEditukrn.EditValue & LookUpEditkain.EditValue & temp
        Else
            If sqlDR.Item(0) >= 1 And sqlDR.Item(0) <= 9 Then
                temp = "00" & sqlDR.Item(0)
                hasil = LookUpEditdivisi.EditValue & "3" & LookUpEditjnsbrg.EditValue & LookUpEditmerk.EditValue & LookUpEdittpbrg.EditValue & LookUpEditsubtp.EditValue & LookUpEditukrn.EditValue & LookUpEditkain.EditValue & temp
            ElseIf sqlDR.Item(0) >= 10 And sqlDR.Item(0) <= 99 Then
                temp = "0" & sqlDR.Item(0)
                hasil = LookUpEditdivisi.EditValue & "3" & LookUpEditjnsbrg.EditValue & LookUpEditmerk.EditValue & LookUpEdittpbrg.EditValue & LookUpEditsubtp.EditValue & LookUpEditukrn.EditValue & LookUpEditkain.EditValue & temp
            Else
                temp = sqlDR.Item(0)
                hasil = LookUpEditdivisi.EditValue & "3" & LookUpEditjnsbrg.EditValue & LookUpEditmerk.EditValue & LookUpEdittpbrg.EditValue & LookUpEditsubtp.EditValue & LookUpEditukrn.EditValue & LookUpEditkain.EditValue & temp
            End If
        End If
        sqlDR.Close()

        If Not isDelete Then
            If STATE = "ADD" Then
                Textkode.Text = hasil
                dSO = New DataSet
                ds1 = New DataSet
                DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Barang where 1=0", sqlconn))
                DA.Fill(dSO, "SIF_Barang") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
                row = dSO.Tables("SIF_Barang").NewRow
                row.Item("Kd_Cabang") = kdcabang
                row.Item("Kd_jns_persd") = "3"
                Textkode.Text = hasil
                row.Item("Kode_Barang") = Textkode.Text
                row.Item("no_urut") = temp

                row.Item("Kd_Satuan") = LookUpEditstuan.EditValue
                row.Item("tipe_stok") = ComboBoxEdittpstok.EditValue
                row.Item("kd_Depart") = LookUpEditdivisi.EditValue
                row.Item("kd_jenis") = LookUpEditjnsbrg.EditValue
                row.Item("kd_merk") = LookUpEditmerk.EditValue
                row.Item("kd_tipe") = LookUpEdittpbrg.EditValue
                row.Item("kd_sub_tipe") = LookUpEditsubtp.EditValue
                row.Item("kd_ukuran") = LookUpEditukrn.EditValue
                row.Item("kd_kain") = LookUpEditkain.EditValue
                row.Item("Nama_Barang") = TxtNama.Text
                row.Item("lokasi") = LookUpEditlokasi.EditValue
                row.Item("stok_min") = Txtstokmin.Text
                row.Item("stok_max_av") = TxtstokMax.Text
                row.Item("Keterangan") = TxtKet.Text
                row.Item("rek_penjualan1") = LookUpEditrekjual1.EditValue
                row.Item("rek_penjualan2") = LookUpEditrekjual2.EditValue
                row.Item("rek_persediaan") = LookUpEditrekpersediaan.EditValue
                row("Rec_Stat") = IIf(ComboBoxEditstatus.EditValue = "Aktif", "Y", "T")
                row.Item("Last_Create_Date") = Now
                row.Item("Last_Created_By") = umum.username
                row.Item("Last_Update_Date") = Now
                row.Item("Last_Updated_By") = umum.username
                row.Item("Program_Name") = Me.Name


            ElseIf STATE = "EDIT" Then


                row = ds1.Tables("SIF_Barang_Edit").Rows(0)
                row.Item("no_urut") = temp
                row.Item("tipe_stok") = ComboBoxEdittpstok.EditValue
                row.Item("kd_Depart") = LookUpEditdivisi.EditValue
                row.Item("kd_jenis") = LookUpEditjnsbrg.EditValue
                row.Item("kd_merk") = LookUpEditmerk.EditValue
                row.Item("kd_tipe") = LookUpEdittpbrg.EditValue
                row.Item("kd_sub_tipe") = LookUpEditsubtp.EditValue
                row.Item("kd_ukuran") = LookUpEditukrn.EditValue
                row.Item("kd_kain") = LookUpEditkain.EditValue
                row.Item("Nama_Barang") = TxtNama.Text
                row.Item("Kd_Satuan") = LookUpEditstuan.EditValue
                row.Item("lokasi") = LookUpEditlokasi.EditValue
                row.Item("stok_min") = Txtstokmin.Text
                row.Item("stok_max_av") = TxtstokMax.Text
                row.Item("Keterangan") = TxtKet.Text
                row.Item("rek_penjualan1") = LookUpEditrekjual1.EditValue
                row.Item("rek_penjualan2") = LookUpEditrekjual2.EditValue
                row.Item("rek_persediaan") = LookUpEditrekpersediaan.EditValue
                row("Rec_Stat") = IIf(ComboBoxEditstatus.EditValue = "Aktif", "Y", "T")
                row.Item("Last_Create_Date") = Now
                row.Item("Last_Created_By") = umum.username
                row.Item("Last_Update_Date") = Now
                row.Item("Last_Updated_By") = umum.username
                row.Item("Program_Name") = Me.Name

            End If
        End If
        If STATE = "ADD" Then

            dSO.Tables(0).Rows.Add(row) ' bisa juga ditulis seperti ini, pakai array index, menggantikan "SIF_WILAYAH"
            Try

                myBuilder = New SqlClient.SqlCommandBuilder(DA)
                DA.UpdateCommand = myBuilder.GetUpdateCommand()
                DA.InsertCommand = myBuilder.GetInsertCommand()
                DA.Update(dSO.Tables("SIF_Barang"))
                dSO.Tables("SIF_Barang").AcceptChanges()

                showMessages("Saved....")
                'Textkode.Text = row("Kode_Barang")
                'TxtNama.Text = row("Nama_Barang")

                isiGrid()
                bersihkan()
                btnadd = True
                btnSave = False
                btnEdit = False
                btnCancel = False
                btnDelete = False
                GridControl1.Enabled = False
                mati()
                setStatus()

            Catch e As Exception
                dSO.Tables(0).RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical)
            End Try
        ElseIf STATE = "EDIT" Then

            Try

                myBuilder1 = New SqlClient.SqlCommandBuilder(Da5)
                Da5.UpdateCommand = myBuilder1.GetUpdateCommand()
                Da5.Update(ds1.Tables("SIF_Barang_Edit"))
                ds1.Tables("SIF_Barang_Edit").AcceptChanges()
                STATE = "EDIT"
                showMessages("Edit Berhasil....")
                Textkode.Text = row("Kode_Barang")
                TxtNama.Text = row("Nama_Barang")

                If Not ds1 Is Nothing Then
                    ds1.Clear()
                End If
                Da5 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Barang ", sqlconn))
                Da5.Fill(ds1, "Db_data1")
                GridControl1.DataSource = ds1.Tables("Db_data1")


            Catch e As Exception
                ds1.Tables(0).RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical)
            End Try
        ElseIf STATE = "DELETE" Then
            Try

                myBuilder = New SqlClient.SqlCommandBuilder(DA)

                DA.DeleteCommand = myBuilder.GetInsertCommand()
                DA.Update(dSO.Tables("SIF_Barang"))
                dSO.Tables("SIF_Barang").AcceptChanges()

                showMessages("Hapus Berhasil....")


                isiGrid()


            Catch e As Exception
                dSO.Tables(0).RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical)
            End Try
        End If


    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        save_click()
    End Sub
    Public Sub bersihkan()

        'If State = "ADD" Then
        Textkode.ReadOnly = True
        Textkode.Text = ""
        Textkode.ReadOnly = False
        LookUpEditstuan.EditValue = vbNull
        TxtNama.Text = ""
        ComboBoxEdittpstok.Text = ""
        LookUpEditstuan.EditValue = vbNullString
        LookUpEditdivisi.EditValue = vbNullString
        LookUpEditjnsbrg.EditValue = vbNullString
        LookUpEditmerk.EditValue = vbNullString
        LookUpEdittpbrg.EditValue = vbNullString
        LookUpEditsubtp.EditValue = vbNullString
        LookUpEditukrn.EditValue = vbNullString
        LookUpEditkain.EditValue = vbNullString
        LookUpEditlokasi.EditValue = vbNullString
        Txtstokmin.Text = ""
        TxtstokMax.Text = ""
        TxtKet.Text = ""
        LookUpEditrekjual1.EditValue = vbNullString
        LookUpEditrekjual2.EditValue = vbNullString
        LookUpEditrekpersediaan.EditValue = vbNullString
        ComboBoxEditstatus.Text = ""

        'End If
    End Sub
    Public Sub nyala()

        'If State = "ADD" Then
        LookUpEditstuan.Enabled = True
        TxtNama.Enabled = True
        Textkode.Enabled = True
        ComboBoxEdittpstok.Enabled = True
        LookUpEditstuan.Enabled = True
        LookUpEditdivisi.Enabled = True
        LookUpEditjnsbrg.Enabled = True
        LookUpEditmerk.Enabled = True
        LookUpEdittpbrg.Enabled = True
        LookUpEditsubtp.Enabled = True
        LookUpEditukrn.Enabled = True
        LookUpEditkain.Enabled = True
        LookUpEditlokasi.Enabled = True
        Txtstokmin.Enabled = True
        TxtstokMax.Enabled = True
        TxtKet.Enabled = True
        LookUpEditrekjual1.Enabled = True
        LookUpEditrekjual2.Enabled = True
        LookUpEditrekpersediaan.Enabled = True
        ComboBoxEditstatus.Enabled = True

        'End If
    End Sub
    Public Sub mati()

        'If State = "ADD" Then
        LookUpEditstuan.Enabled = False
        TxtNama.Enabled = False
        Textkode.Enabled = False
        ComboBoxEdittpstok.Enabled = False
        LookUpEditstuan.Enabled = False
        LookUpEditdivisi.Enabled = False
        LookUpEditjnsbrg.Enabled = False
        LookUpEditmerk.Enabled = False
        LookUpEdittpbrg.Enabled = False
        LookUpEditsubtp.Enabled = False
        LookUpEditukrn.Enabled = False
        LookUpEditkain.Enabled = False
        LookUpEditlokasi.Enabled = False
        Txtstokmin.Enabled = False
        TxtstokMax.Enabled = False
        TxtKet.Enabled = False
        LookUpEditrekjual1.Enabled = False
        LookUpEditrekjual2.Enabled = False
        LookUpEditrekpersediaan.Enabled = False
        ComboBoxEditstatus.Enabled = False

        'End If
    End Sub
    Public Sub isiGrid()
        If Not dSO Is Nothing Then
            dSO.Clear()
        End If
        DA = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Barang ", sqlconn))
        DA.Fill(dSO, "Db_data1")
        GridControl1.DataSource = dSO.Tables("Db_data1")
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'edit_click()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cancel_click()
    End Sub
    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub
    Public Sub cancel_click()
        default_cancel(prn)
        Me.Enabled = False
        STATE = ""
        bersihkan()
        btnSave = False
        btnadd = True
        btnEdit = False
        setStatus()
    End Sub
    Public Sub delete_click()

        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then hapus_record()

    End Sub
    Public Sub hapus_record()
        Dim builder As New SqlCommandBuilder(DA)
        Dim row As DataRow
        Dim rows() As DataRow
        Dim i As Integer

        ReDim rows(GridView1.SelectedRowsCount - 1)
        For i = 0 To GridView1.SelectedRowsCount - 1
            rows(i) = GridView1.GetDataRow(GridView1.GetSelectedRows(i))
        Next
        GridView1.BeginSort()
        Try
            For Each row In rows
                row.Delete()
                showMessages("dihapus")
            Next
        Finally
            GridView1.EndSort()
        End Try
        STATE = "DELETE"
        save_click()
    End Sub
    Public Sub cetak_click()
        Try

            GridView1.OptionsPrint.Reset()
            GridView1.GridControl.ShowPrintPreview()
        Catch ex As Exception
            MsgBox("Error Printing : " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Printing")
        End Try
    End Sub
    Public Sub simpan()
        Dim builder As New SqlCommandBuilder(DA)

        For Each rw As DataRow In dSO.Tables("SIF_Barang").Rows
            If rw.RowState = DataRowState.Added Then
                rw("Kode_Barang") = "1"
                rw("Last_Create_Date") = Now
                rw("Last_Created_By") = umum.username
                rw("Program_Name") = Me.Name
            ElseIf rw.RowState = DataRowState.Modified Then
                rw.Item("Last_Update_Date") = Now
                rw.Item("Last_Updated_By") = username
            End If
        Next

        DA.InsertCommand = builder.GetInsertCommand()
        DA.UpdateCommand = builder.GetUpdateCommand()
        DA.DeleteCommand = builder.GetDeleteCommand()
        DA.Update(dSO, "SIF_Barang")
        dSO.Tables("SIF_Barang").AcceptChanges()
        showMessages("Data Berhasil di hapus..!", 14)
    End Sub
    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        delete_click()
    End Sub

    Private Sub GridView1_InitNewRow1(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        Dim View As ColumnView = sender
        View.SetRowCellValue(e.RowHandle, View.Columns("No"), GridView1.RowCount + 1)

    End Sub
    Private Sub GridView1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.DoubleClick
        ds1 = New DataSet
        Da5 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Barang where Kode_Barang='" & GridView1.GetRow(GridView1.GetSelectedRows(0)).item("Kode_Barang").ToString & "'", sqlconn))
        Da5.Fill(ds1, "SIF_Barang_Edit") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)


        Textkode.Text = GridView1.GetRow(GridView1.GetSelectedRows(0)).item("Kode_Barang")
        TxtNama.Text = GridView1.GetRow(GridView1.GetSelectedRows(0)).item("Nama_Barang")
        LookUpEditstuan.EditValue = GridView1.GetRow(GridView1.GetSelectedRows(0)).item("Kd_Satuan")
        ComboBoxEdittpstok.EditValue = GridView1.GetRow(GridView1.GetSelectedRows(0)).item("tipe_stok")
        LookUpEditdivisi.EditValue = GridView1.GetRow(GridView1.GetSelectedRows(0)).item("Kd_Depart")
        LookUpEditjnsbrg.EditValue = GridView1.GetRow(GridView1.GetSelectedRows(0)).item("kd_jenis")
        LookUpEditmerk.EditValue = GridView1.GetRow(GridView1.GetSelectedRows(0)).item("kd_merk")
        LookUpEdittpbrg.EditValue = GridView1.GetRow(GridView1.GetSelectedRows(0)).item("kd_tipe")
        LookUpEditsubtp.EditValue = GridView1.GetRow(GridView1.GetSelectedRows(0)).item("kd_sub_tipe")
        LookUpEditukrn.EditValue = GridView1.GetRow(GridView1.GetSelectedRows(0)).item("kd_ukuran")
        LookUpEditkain.EditValue = GridView1.GetRow(GridView1.GetSelectedRows(0)).item("kd_kain")
        LookUpEditlokasi.EditValue = GridView1.GetRow(GridView1.GetSelectedRows(0)).item("lokasi")
        Txtstokmin.Text = GridView1.GetRow(GridView1.GetSelectedRows(0)).item("stok_min").ToString
        TxtstokMax.Text = GridView1.GetRow(GridView1.GetSelectedRows(0)).item("stok_max_av").ToString
        TxtKet.Text = GridView1.GetRow(GridView1.GetSelectedRows(0)).item("Keterangan")
        LookUpEditrekjual1.EditValue = GridView1.GetRow(GridView1.GetSelectedRows(0)).item("rek_penjualan1")
        LookUpEditrekjual2.EditValue = GridView1.GetRow(GridView1.GetSelectedRows(0)).item("rek_penjualan2")
        LookUpEditrekpersediaan.EditValue = GridView1.GetRow(GridView1.GetSelectedRows(0)).item("rek_persediaan")
        sukses = GridView1.GetRow(GridView1.GetSelectedRows(0)).item("no_urut")
        ComboBoxEditstatus.EditValue = IIf(GridView1.GetRow(GridView1.GetSelectedRows(0)).item("Rec_Stat").ToString = "Y", "Aktif", "Tidak Aktif")
        STATE = "EDIT"
        setStatus()
        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        btnDelete = True
    End Sub


    Private Sub Txtstokmin_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txtstokmin.KeyPress
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

    Private Sub TxtstokMax_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtstokMax.KeyPress
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



    Private Sub LookUpEditjnsbrg_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LookUpEditjnsbrg.EditValueChanged
        TxtNama.Text = LookUpEditjnsbrg.Text + " " + LookUpEditmerk.Text + " " + LookUpEdittpbrg.Text + " " + LookUpEditsubtp.Text + " " + LookUpEditukrn.Text + " " + LookUpEditkain.Text
    End Sub

    Private Sub LookUpEditmerk_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LookUpEditmerk.EditValueChanged
        TxtNama.Text = LookUpEditjnsbrg.Text + " " + LookUpEditmerk.Text + " " + LookUpEdittpbrg.Text + " " + LookUpEditsubtp.Text + " " + LookUpEditukrn.Text + " " + LookUpEditkain.Text
    End Sub

    Private Sub LookUpEdittpbrg_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LookUpEdittpbrg.EditValueChanged
        TxtNama.Text = LookUpEditjnsbrg.Text + " " + LookUpEditmerk.Text + " " + LookUpEdittpbrg.Text + " " + LookUpEditsubtp.Text + " " + LookUpEditukrn.Text + " " + LookUpEditkain.Text
    End Sub

    Private Sub LookUpEditsubtp_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LookUpEditsubtp.EditValueChanged
        TxtNama.Text = LookUpEditjnsbrg.Text + " " + LookUpEditmerk.Text + " " + LookUpEdittpbrg.Text + " " + LookUpEditsubtp.Text + " " + LookUpEditukrn.Text + " " + LookUpEditkain.Text
    End Sub

    Private Sub LookUpEditukrn_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LookUpEditukrn.EditValueChanged
        TxtNama.Text = LookUpEditjnsbrg.Text + " " + LookUpEditmerk.Text + " " + LookUpEdittpbrg.Text + " " + LookUpEditsubtp.Text + " " + LookUpEditukrn.Text + " " + LookUpEditkain.Text
    End Sub

    Private Sub LookUpEditkain_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LookUpEditkain.EditValueChanged
        TxtNama.Text = LookUpEditjnsbrg.Text + " " + LookUpEditmerk.Text + " " + LookUpEdittpbrg.Text + " " + LookUpEditsubtp.Text + " " + LookUpEditukrn.Text + " " + LookUpEditkain.Text
    End Sub

End Class
