Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class frmProdTranSpk

    Dim ds1, ds2, ds3, ds4, ds5, ds6, dsedit As New DataSet
    Dim da1, da2, da3, da4, da5, da6, daedit As New SqlDataAdapter
    Dim row, rows As DataRow
    Dim mb, mb1 As New SqlCommandBuilder
    Dim prn As frmMain
    Dim nilai As String
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State, kode, kode1, kode2, kode3, kode4, kode5 As String

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Private Sub frmProdTranSpk_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        State = "ADD"
        prn = getParent(Me)

        da1 = New SqlDataAdapter(New SqlCommand("select distinct no_spk from PROD.dbo.PROD_spk_m where kd_departemen='" & kddep & "'", sqlconn))
        da1.Fill(ds1, "nospk")
        lkspk.Properties.DataSource = ds1.Tables("nospk")
        lkspk.Properties.ValueMember = "no_spk"
        lkspk.Properties.DisplayMember = "no_spk"

        da5 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_spk_m  ", sqlconn))
        da5.Fill(ds5, "SPKM")

        'loadGrid()
       
       

    End Sub

    Public Sub add_click()
        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnAdd = False
        State = "EDIT"
        setStatus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        save_click()
    End Sub

    Private Sub lkspk_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lkspk.EditValueChanged
        da1 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rcn_prod_m a,PROD.dbo.PROD_spk_m b,SIF.dbo.SIF_Gen_Reff_D c where b.no_spk='" & lkspk.EditValue & "' and a.no_rph=b.no_rph and a.kd_jadwal=c.id_data and c.ref_role='PROD' and c.id_Ref_File='JDWKRJ'", sqlconn))
        da1.Fill(ds1, "isispk")

        txtrph.Text = ds1.Tables("isispk").Rows(0).Item("no_rph").ToString
        txtjdwl.Text = ds1.Tables("isispk").Rows(0).Item("desc_data").ToString
        txttanggal.Text = Now.Date

        da2 = New SqlDataAdapter(New SqlCommand("select distinct kd_jenis,Nama_Jenis from PROD.dbo.PROD_spk_m a,SIF.dbo.SIF_Jenis_Barang b where a.kd_jenis=b.kd_jns_brg", sqlconn))
        da2.Fill(ds2, "jenisbarang")
        lkjnsbrg.Properties.DataSource = ds2.Tables("jenisbarang")
        lkjnsbrg.Properties.ValueMember = "kd_jenis"
        lkjnsbrg.Properties.DisplayMember = "Nama_Jenis"


    End Sub
 
    Private Sub lkjnsbrg_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkjnsbrg.EditValueChanged
        da3 = New SqlDataAdapter(New SqlCommand("select distinct kd_kegiatan_spk,desc_data from PROD.dbo.PROD_spk_m a,SIF.dbo.SIF_Gen_Reff_D b where no_spk='" & lkspk.EditValue & "' and a.kd_jenis='" & lkjnsbrg.EditValue & "'and b.ref_role='PROD' and b.id_Ref_File='SPK'and a.kd_kegiatan_spk=b.id_data ", sqlconn))
        da3.Fill(ds3, "kegiatan")
        lkkegtn.Properties.DataSource = ds3.Tables("kegiatan")
        lkkegtn.Properties.ValueMember = "kd_kegiatan_spk"
        lkkegtn.Properties.DisplayMember = "desc_data"

       

    End Sub

    Private Sub lkkegtn_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkkegtn.EditValueChanged
        da3 = New SqlDataAdapter(New SqlCommand("select jumlah,kapasitas from PROD.dbo.PROD_spk_m a,SIF.dbo.SIF_Gen_Reff_D b where no_spk='" & lkspk.EditValue & "' and a.kd_jenis='" & lkjnsbrg.EditValue & "'and b.ref_role='PROD' and b.id_Ref_File='SPK'and a.kd_kegiatan_spk=b.id_data ", sqlconn))
        da3.Fill(ds3, "kegiatan1")
        txtjumlah.Text = ds3.Tables("kegiatan1").Rows(0).Item("jumlah").ToString
        kapasits.Text = ds3.Tables("kegiatan1").Rows(0).Item("kapasitas").ToString

        loadGrid()
        loadlookup()

        'lkbarang.DataSource = ds4.Tables("load")
        'lkbarang.DisplayMember = "Nama_Barang"
        'lkbarang.ValueMember = "kd_barang"

    End Sub
    Private Sub loadGrid()
        If Not ds4.Tables("load") Is Nothing Then ds4.Tables("load").Clear()
        If Not ds6.Tables("SPKMD") Is Nothing Then ds6.Tables("SPKMD").Clear()
        da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_spk_d where no_spk='" & lkspk.EditValue & "' and kd_jenis='" & lkjnsbrg.EditValue & "'and kd_kegiatan_spk= '" & lkkegtn.EditValue & "'", sqlconn))
        da4.Fill(ds4, "load")
        gControl.DataSource = ds4.Tables("load")

        da6 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_spk_d where no_spk='" & lkspk.EditValue & "' and kd_jenis='" & lkjnsbrg.EditValue & "' and kd_kegiatan_spk= '" & lkkegtn.EditValue & "'", sqlconn))
        da6.Fill(ds6, "SPKMD")

    End Sub

    Private Sub loadlookup()
        da3 = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        da3.Fill(ds4, "loadnama")
        lkbarang.DataSource = ds4.Tables("loadnama")
        lkbarang.DisplayMember = "Nama_Barang"
        lkbarang.ValueMember = "Kode_Barang"
        da3 = New SqlDataAdapter(New SqlCommand("select Kode_Barang, tipe_stok from SIF.dbo.SIF_Barang", sqlconn))
        da3.Fill(ds4, "loadtipe")
        lktipe.DataSource = ds4.Tables("loadtipe")
        lktipe.DisplayMember = "tipe_stok"
        lktipe.ValueMember = "Kode_Barang"
        da3 = New SqlDataAdapter(New SqlCommand("select a.Kode_Barang, b.Merk_Kain from SIF.dbo.SIF_Barang a, SIF.dbo.SIF_Kain b WHERE a.kd_kain=b.Kode_Kain", sqlconn))
        da3.Fill(ds4, "loadkain")
        lkkain.DataSource = ds4.Tables("loadkain")
        lkkain.DisplayMember = "Merk_Kain"
        lkkain.ValueMember = "Kode_Barang"
        da3 = New SqlDataAdapter(New SqlCommand("select a.Kode_Barang, b.Nama_Ukuran from SIF.dbo.SIF_Barang a, SIF.dbo.SIF_Ukuran b where a.kd_ukuran=b.Kode_Ukuran", sqlconn))
        da3.Fill(ds4, "loadukuran")
        lkukuran.DataSource = ds4.Tables("loadukuran")
        lkukuran.DisplayMember = "Nama_Ukuran"
        lkukuran.ValueMember = "Kode_Barang"
    End Sub

    Public Sub save_click()



       
        If State = "EDIT" Then

            row = ds5.Tables("SPKM").Rows(0)

            row.Item("kapasitas") = kapasits.Text
            row.Item("tanggal") = txttanggal.Text

        End If

        If State = "EDIT" Then
            For Each rows As DataRow In ds4.Tables("load").Rows


                rows.Item("Last_Update_Date") = Now
                rows.Item("Last_Updated_By") = username



            Next

        End If

        If State = "EDIT" Then

            Try




                mb = New SqlClient.SqlCommandBuilder(da5)
                da5.UpdateCommand = mb.GetUpdateCommand()
                da5.InsertCommand = mb.GetInsertCommand()
                da5.DeleteCommand = mb.GetDeleteCommand()

                mb1 = New SqlClient.SqlCommandBuilder(da4)
                da4.UpdateCommand = mb1.GetUpdateCommand()
                da4.InsertCommand = mb1.GetInsertCommand()
                da4.DeleteCommand = mb1.GetDeleteCommand()



                da5.Update(ds5.Tables("SPKM"))
                da4.Update(ds4.Tables("load"))


                showMessages("Saved..")

                loadGrid()

            Catch e As Exception

                ds5.Tables("SPKM").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                ds4.Tables("load").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical)

            End Try

        End If


    End Sub

    Public Sub edit_click()

        STATE = "EDIT"
        ' bila menggunakan form cari
        dsedit = New DataSet
        daedit = New SqlDataAdapter(New SqlCommand("select no_rph as [NO RPH],no_spk as [NO SPK],desc_data as [NAMAKEGIATAN] from PROD.dbo.PROD_spk_m a,SIF.dbo.SIF_Gen_Reff_D b where b.ref_role='PROD' and b.id_Ref_File='SPK'and a.kd_kegiatan_spk=b.id_data and a.kd_departemen='" & kddep & "'", sqlconn)) '<- query buat ditampilkan di LOV
        daedit.Fill(dsedit, "LookSPK")
        frmCari.set_dso(dsedit.Tables("LookSPK"))
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then
            kode = frmCari.row("NO RPH").ToString
            kode1 = frmCari.row("NO SPK").ToString
            kode3 = frmCari.row("NAMAKEGIATAN").ToString

            da5 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_spk_m a,SIF.dbo.SIF_Gen_Reff_D b  where  a.no_spk  = '" & kode1 & "' and a.kd_kegiatan_spk = b.id_data and b.desc_data ='" & kode3 & "'  ", sqlconn)) '<- query buat ditampilkan di LOV
            da5.Fill(ds5, "SPKM")
            da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_spk_d where no_rph  = '" & kode & "' and  no_spk  = '" & kode1 & "' and  kd_kegiatan_spk = '" & kode3 & "'   ", sqlconn))
            da4.Fill(ds4, "load") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
            gControl.DataSource = ds4.Tables("load")

            row = ds5.Tables("SPKM").Rows(0)
            txttanggal.Text = row.Item("tanggal").ToString
            txtrph.Text = kode
            lkspk.EditValue = kode1
            lkjnsbrg.EditValue = row.Item("kd_jenis").ToString
            lkkegtn.EditValue = row.Item("kd_kegiatan_spk").ToString
            txtjumlah.Text = row.Item("jumlah").ToString
            kapasits.Text = row.Item("kapasitas").ToString
           
            btnSave = True
            btnCancel = True
            btnadd = False
            btnEdit = False
            btnDelete = True
            setStatus()
        Else
            cancel_click()
            STATE = ""
        End If

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        edit_click()
    End Sub
    Sub bersih()
        If Not ds4.Tables("load") Is Nothing Then ds4.Tables("load").Clear()
        txttanggal.Text = Now.Date
        txtrph.Text = ""
        txtjdwl.Text = ""
        lkspk.EditValue = vbNullString
        lkjnsbrg.EditValue = vbNullString
        lkkegtn.EditValue = vbNullString
        txtjumlah.Text = ""
        kapasits.Text = ""
    End Sub
    Public Sub cancel_click()
        bersih()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        cancel_click()
    End Sub
End Class