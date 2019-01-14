Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared


Public Class frmformulirpngaduan
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain   '<-- untuk mengakses frmMain
    Public obj As Object
    Dim ds, dsedit, ds1, ds2, ds3, ds4, ds5, ds6, ds7, dss, dss1, ds9 As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Dim kode, tampung, cabang As String
    Dim DA, daedit, da1, da2, da3, da4, da5, da6, da7, sqlda, sqlda1 As SqlClient.SqlDataAdapter
    Dim Buildernya, Buildernya1 As New SqlClient.SqlCommandBuilder
    Dim rw, rows, row1 As DataRow
    Dim a As Double
    Dim c As Double

    Dim b As Double

    Private Sub V_Sales()
        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  Kode_Sales,Nama_Sales from sif.dbo.SIF_Sales", sqlconn))
        da1.Fill(ds1, "View_Sales")
        lueSales.Properties.DataSource = ds1.Tables("View_Sales")
        lueSales.Properties.ValueMember = "Kode_Sales"
        lueSales.Properties.DisplayMember = "Nama_Sales"

    End Sub
    Private Sub V_Toko()
        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  Kd_Customer,Nama_Customer from sif.dbo.SIF_Customer ", sqlconn))
        da1.Fill(ds1, "View_Toko")
        Luecustomer.Properties.DataSource = ds1.Tables("View_Toko")
        Luecustomer.Properties.ValueMember = "Kd_Customer"
        Luecustomer.Properties.DisplayMember = "Nama_Customer"
    End Sub
    Private Sub V_Barang()
        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  Id_Data,Desc_Data from sif.dbo.SIF_Gen_Reff_D Where Ref_Role= 'SOD' and id_Ref_File='JNSSRVSH' and id_Ref_Data='JNSSRVSH'", sqlconn))
        da1.Fill(ds1, "View_Barang")
        LueBarang.Properties.DataSource = ds1.Tables("View_Barang")
        LueBarang.Properties.ValueMember = "Id_Data"
        LueBarang.Properties.DisplayMember = "Desc_Data"
    End Sub
    Private Sub V_Pelayanan()
        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  Id_Data,Desc_Data  from sif.dbo.SIF_Gen_Reff_D Where Ref_Role= 'SOD' and id_Ref_File='PGDHN1' and id_Ref_Data='PGDHN'", sqlconn))
        da1.Fill(ds1, "View_Pelayanan")
        LuePelayanan.Properties.DataSource = ds1.Tables("View_Pelayanan")
        LuePelayanan.Properties.ValueMember = "Id_Data"
        LuePelayanan.Properties.DisplayMember = "Desc_Data"
    End Sub
    Private Sub V_Pengaduan()
        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  Id_Data,Desc_Data from sif.dbo.SIF_Gen_Reff_D Where Ref_Role= 'SOD 'and id_Ref_File='PGDHN2' and id_Ref_Data='PGDHN'", sqlconn))
        da1.Fill(ds1, "View_Pengaduan")
        LuePengaduan.Properties.DataSource = ds1.Tables("View_Pengaduan")
        LuePengaduan.Properties.ValueMember = "Id_Data"
        LuePengaduan.Properties.DisplayMember = "Desc_Data"
    End Sub

    Private Sub frmformulirpngaduan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        connect()

        prn = getParent(Me)
        txttanggal.Text = getTanggal()
        V_Toko()
        V_Sales()
        V_Barang()
        V_Pelayanan()
        V_Pengaduan()

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
    Public Sub add_click()

        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
        STATE = "ADD"
    End Sub
    Public Sub save_click(Optional ByRef isDelete As Boolean = False)

        If Luecustomer.EditValue = "" Then
            showMessages("Nama Toko Diisi")
            Luecustomer.Focus()
            Exit Sub
        End If


        If lueSales.EditValue = "" Then
            showMessages("Sales Belum Dipilih")
            lueSales.Focus()
            Exit Sub
        End If

        If Not isDelete Then


            If STATE = "ADD" Then
                da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SALES.dbo.SALES_PENGADUAN where Nomor = '" & kode & "' ", sqlconn))
                da2.Fill(ds2, "PGD")

               
                'untuk menyimpan tabel sales_pengaduan
                row = ds2.Tables("PGD").NewRow
                row.Item("Kd_cabang") = getKodeCabang()
                cabang = row.Item("Kd_cabang")
                row.Item("Nomor") = getNoTrans("PGN", getTanggal)
                tampung = row.Item("Nomor")
                row.Item("Tanggal") = txttanggal.Text
                row.Item("Kd_cust") = Luecustomer.EditValue
                row.Item("Kd_sales") = lueSales.EditValue
                row.Item("keterangan") = txtKeterangan.Text
                row.Item("Status") = "AKTIF"
                row.Item("Program_Name") = Me.Name
                row.Item("Last_Create_Date") = Now
                row.Item("Last_Created_By") = username
                ds2.Tables("PGD").Rows.Add(row)

                'untuk menyimpan tabel sales_pengaduan_detil
                da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SALES.dbo.SALES_PENGADUAN_D where Nomor= '" & kode & "'", sqlconn))
                da3.Fill(ds3, "PGDD")

                rows = ds3.Tables("PGDD").NewRow
                rows.Item("Kd_cabang") = cabang
                rows.Item("Nomor") = tampung
                rows.Item("No_seq") = 1
                rows.Item("Kd_stok") = LueBarang.EditValue
                rows.Item("Kd_pelayanan") = LuePelayanan.EditValue
                rows.Item("kd_pengaduan") = LuePengaduan.EditValue
                rows.Item("Penanganan") = cbpenanganan.Text
                rows.Item("Keluhan") = txtxkeluhan.Text
                rows.Item("Departemen") = cbDepartemen.Text
                rows.Item("Status") = "AKTIF"
                rows.Item("keterangan") = txtKeterangan.Text
                rows.Item("penyelesaian") = txtpenyelesaian.Text
                rows.Item("tanggapan") = txttanggapan.Text

                rows.Item("Program_Name") = Me.Name
                rows.Item("Last_Create_Date") = Now
                rows.Item("Last_Created_By") = username
                ds3.Tables("PGDD").Rows.Add(rows)


            ElseIf STATE = "EDIT" Then
                'untuk mengedit PGDcari
                da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SALES.dbo.SALES_PENGADUAN where Nomor = '" & kode & "' ", sqlconn))
                da2.Fill(dsedit, "PGDcari")


                row = dsedit.Tables("PGDcari").Rows(0)
                row.Item("Kd_cabang") = cabang
                row.Item("Nomor") = txtno.Text
                row.Item("Tanggal") = txttanggal.Text
                row.Item("Kd_cust") = Luecustomer.EditValue
                row.Item("Kd_sales") = lueSales.EditValue
                row.Item("keterangan") = txtKeterangan.Text
                row.Item("Status") = "AKTIF"

                row.Item("Program_Name") = Me.Name
                row.Item("Last_Create_Date") = Now
                row.Item("Last_Created_By") = username
                row.Item("Last_Update_Date") = Now
                row.Item("Last_Updated_By") = username

                'untuk mengedit PGD detil cari
                da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SALES.dbo.SALES_PENGADUAN_D where Nomor= '" & kode & "'", sqlconn))
                da3.Fill(dsedit, "PGDDcari")

                rows = dsedit.Tables("PGDDcari").Rows(0)
                rows.Item("Kd_cabang") = cabang
                rows.Item("Nomor") = txtno.Text
                rows.Item("No_seq") = 1
                rows.Item("Kd_stok") = LueBarang.EditValue
                rows.Item("Kd_pelayanan") = LuePelayanan.EditValue
                rows.Item("kd_pengaduan") = LuePengaduan.EditValue
                rows.Item("Penanganan") = cbpenanganan.Text
                rows.Item("Keluhan") = txtxkeluhan.Text
                rows.Item("Departemen") = cbDepartemen.Text
                rows.Item("Status") = "AKTIF"
                rows.Item("keterangan") = txtKeterangan.Text
                rows.Item("penyelesaian") = txtpenyelesaian.Text
                rows.Item("tanggapan") = txttanggapan.Text

                rows.Item("Program_Name") = Me.Name
                rows.Item("Last_Create_Date") = Now
                rows.Item("Last_Created_By") = username
                rows.Item("Last_Update_Date") = Now
                rows.Item("Last_Updated_By") = username
            End If

        End If
      


        If STATE = "ADD" Then
            Try

                Buildernya = New SqlClient.SqlCommandBuilder(da2)
                da2.UpdateCommand = Buildernya.GetUpdateCommand()
                da2.InsertCommand = Buildernya.GetInsertCommand()
                da2.DeleteCommand = Buildernya.GetDeleteCommand()

                Buildernya1 = New SqlClient.SqlCommandBuilder(da3)
                da3.UpdateCommand = Buildernya1.GetUpdateCommand()
                da3.InsertCommand = Buildernya1.GetInsertCommand()
                da3.DeleteCommand = Buildernya1.GetDeleteCommand()

                da2.Update(ds2.Tables("PGD"))
                da3.Update(ds3.Tables("PGDD"))

                ds2.Tables("PGD").AcceptChanges()
                ds3.Tables("PGDD").AcceptChanges()

                STATE = "EDIT"
               
                showMessages("Berhasil disimpan..")

                txtno.Text = row.Item("Nomor")

            Catch e As Exception

                ds2.Tables("PGD").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                ds3.Tables("PGDD").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

            End Try
        ElseIf STATE = "EDIT" Then


            Try


                Buildernya = New SqlClient.SqlCommandBuilder(da2)
                da2.UpdateCommand = Buildernya.GetUpdateCommand()
                da2.InsertCommand = Buildernya.GetInsertCommand()
                da2.DeleteCommand = Buildernya.GetDeleteCommand()

                Buildernya1 = New SqlClient.SqlCommandBuilder(da3)
                da3.UpdateCommand = Buildernya1.GetUpdateCommand()
                da3.InsertCommand = Buildernya1.GetInsertCommand()
                da3.DeleteCommand = Buildernya1.GetDeleteCommand()

             
                da2.Update(dsedit.Tables("PGDcari"))
                da3.Update(dsedit.Tables("PGDDcari"))

                
                STATE = "EDIT"

                showMessages("Berhasil diedit..")


            Catch e As Exception

                dsedit.Tables("PGDcari").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                dsedit.Tables("PGDDcari").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

            End Try
        ElseIf STATE = "DELETE" Then
            Try
                Buildernya = New SqlClient.SqlCommandBuilder(da2)
                da2.UpdateCommand = Buildernya.GetUpdateCommand()
                da2.InsertCommand = Buildernya.GetInsertCommand()
                da2.DeleteCommand = Buildernya.GetDeleteCommand()

                Buildernya1 = New SqlClient.SqlCommandBuilder(da3)
                da3.UpdateCommand = Buildernya1.GetUpdateCommand()
                da3.InsertCommand = Buildernya1.GetInsertCommand()
                da3.DeleteCommand = Buildernya1.GetDeleteCommand()

                da2.Update(dsedit.Tables("PGDcari"))
                da3.Update(dsedit.Tables("PGDDcari"))

                dsedit.Tables("PGDcari").AcceptChanges()
                dsedit.Tables("PGDDcari").AcceptChanges()
                bersih()


              
                showMessages("Berhasil dihapus..")


            Catch e As Exception

                dsedit.Tables("PGDcari").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                dsedit.Tables("PGDDcari").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Hapus")

            End Try
        End If

    End Sub
    Public Sub cetak_click()
        callReport(App_Path() & "\report\rptpengaduan.rpt", "", "")
    End Sub



    Public Sub edit_click()

        STATE = "EDIT"
        ' bila menggunakan form cari
        dsedit = New DataSet
        da2 = New SqlDataAdapter(New SqlCommand("select * from SALES.dbo.SALES_PENGADUAN a,SALES.dbo.SALES_PENGADUAN_D b where a.Nomor=b.Nomor  ", sqlconn)) '<- query buat ditampilkan di LOV
        da2.Fill(dsedit, "LookSALES")
        frmCari.set_dso(dsedit.Tables("LookSALES"))
        frmCari.ShowDialog()


        If Not frmCari.row Is Nothing Then
            kode = frmCari.row("Nomor").ToString
            cabang = frmCari.row("kd_cabang").ToString
            da2 = New SqlDataAdapter(New SqlCommand("select * from SALES.dbo.SALES_PENGADUAN where Nomor  = '" & kode & "'", sqlconn)) '<- query buat ditampilkan di LOV
            da2.Fill(dsedit, "PGDcari")
            da3 = New SqlDataAdapter(New SqlCommand("select * from SALES.dbo.SALES_PENGADUAN_D where Nomor = '" & kode & "'", sqlconn))
            da3.Fill(dsedit, "PGDDcari") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)

            'memasukkan ke teks masing-masing
            txtno.Text = kode
            txttanggal.Text = frmCari.row("Tanggal").ToString
            Luecustomer.EditValue = frmCari.row("Kd_cust").ToString
            lueSales.EditValue = frmCari.row("Kd_sales").ToString
            LueBarang.EditValue = frmCari.row("Kd_stok").ToString
            LuePelayanan.EditValue = frmCari.row("Kd_pelayanan").ToString
            LuePengaduan.EditValue = frmCari.row("kd_pengaduan").ToString
            cbpenanganan.Text = frmCari.row("Penanganan").ToString
            cbDepartemen.Text = frmCari.row("Departemen").ToString
            txtKeterangan.Text = frmCari.row("keterangan").ToString
            txtxkeluhan.Text = frmCari.row("Keluhan").ToString
            txtpenyelesaian.Text = frmCari.row.Item("penyelesaian").ToString
            txttanggapan.Text = frmCari.row.Item("tanggapan").ToString

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
    Public Sub bersih()
        txtno.Text = ""
        txttanggal.Text = ""
        Luecustomer.EditValue = vbNullString
        lueSales.EditValue = vbNullString
        LueBarang.EditValue = vbNullString
        LuePelayanan.EditValue = vbNullString
        LuePengaduan.EditValue = vbNullString
        cbpenanganan.Text = ""
        cbDepartemen.Text = ""
        txtKeterangan.Text = ""
        txtxkeluhan.Text = ""
        txtpenyelesaian.Text = ""
        txttanggapan.Text = ""

    End Sub
    Public Sub cancel_click()

        bersih()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
    End Sub

    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data Pengaduan  ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            STATE = "DELETE"
            If Not dsedit.Tables("PGDcari") Is Nothing Then
                For Each rw As DataRow In dsedit.Tables("PGDcari").Rows
                    rw.Delete()
                Next
            End If
            If Not dsedit.Tables("PGDDcari") Is Nothing Then
                For Each rw As DataRow In dsedit.Tables("PGDDcari").Rows
                    rw.Delete()
                Next
            End If
            save_click(True)
            STATE = ""
        End If
    End Sub


    Private Sub btSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSimpan.Click
        save_click()
    End Sub

    Private Sub cmdadd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        add_click()
    End Sub

 
End Class