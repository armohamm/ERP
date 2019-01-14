Imports System.Data.SqlClient
Public Class frmCustomer1
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public obj As Object
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, dSO1, dsedit, dsCust, dsLook As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Dim DA, DA1, daedit, daCust, daLookKota1, daLookKota2, daLookWil, daLookArea As SqlDataAdapter
    'Dim myDAO As New DataAcess.CustomerDAO
    Dim Buildernya As New SqlCommandBuilder

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
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder
        STATE = "ADD" '<-- set state add
        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        XtraTabControl1.SelectedTabPage = tabForm
        txtNamaCust.Focus()

    End Sub
    Private Function getCustomer() As String
        Dim hasil, temp As String
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(isnull(Kd_Customer,'x1'),4,10) as numeric)) from SIF.DBO.SIF_Customer", sqlconn).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "CST000001"
        Else
            hasil = sqlDR.Item(0) + 1
            For i As Int16 = Len(hasil) To 5
                temp = "0" & temp
            Next
            hasil = "CST" & temp & hasil
        End If
        sqlDR.Close()
        Return hasil
    End Function
    Public Sub cancel_click()
        'default_cancel(prn)

        btnadd = True
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnSave = False
        setStatus()
        XtraTabControl1.SelectedTabPage = tabList
        STATE = ""
        Clear_ALL()
    End Sub
    Private Sub Clear_ALL()
        txtKodeCust.Text = ""
        txtNamaCust.Text = ""
        txtAlamat1.Text = ""
        LEKota1.EditValue = vbNullString
        txtTlp1.Text = ""
        txtAlamat2.Text = ""
        LEKota2.EditValue = vbNullString
        txtTlp2.Text = ""
        txtFax.Text = ""
        txtNpwp.Text = ""
        txtEmail.Text = ""
        txtJnsUsaha.Text = ""
        txtCP.Text = ""
        cbGrade.Text = ""
        LEWil.EditValue = vbNullString
        LookUpEditArea.EditValue = vbNullString
        cbStatus.Text = ""
        txtKet.Text = ""
        txtRupiah.Text = ""
        txtValas.Text = ""
        txtlimitPIDR2.Text = "0"
        txtLimitPValas2.Text = "0"
        txtAtribut1.Text = ""
        txtAtribut2.Text = ""
        txtAtribut3.Text = ""
        txtAtribut4.Text = ""
        txtAtribut5.Text = ""
    End Sub
    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub
    Public Sub delete_click()

        If MsgBox("Hapus Data Customer ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            STATE = "DELETE"
            If Not dSO1.Tables("SIF_Customer") Is Nothing Then delete(dSO1.Tables("SIF_Customer").Rows)


            save_click(True)
            cancel_click()
            STATE = ""
        End If
    End Sub

    Private Sub reload_table(ByVal kode As String)
        If Not dSO1.Tables("SIF_Customer") Is Nothing Then dSO1.Tables("SIF_Customer").Clear()

        DA1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF_Customer where Kd_Customer='" & kode & "'", sqlconn))
        DA1.Fill(dSO1, "SIF_Customer")

        If dSO1.Tables("SIF_Customer").Rows.Count > 0 Then
            Dim row As DataRow
            Dim bolean, bolean1, bolean2 As String
            row = dSO1.Tables("SIF_Customer").Rows(0)
            txtKodeCust.Text = row.Item("Kd_Customer").ToString
            txtalias.Text = row.Item("alias").ToString
            DT_TglLahir.EditValue = row.Item("Tgl_Lahir")
            txtNamaCust.Text = row.Item("Nama_Customer").ToString
            txtAlamat1.Text = row.Item("Alamat1").ToString
            LEKota1.EditValue = row.Item("Kota1")
            txtTlp1.Text = row.Item("No_Telepon1").ToString
            txtAlamat2.Text = row.Item("Alamat2").ToString
            LEKota2.EditValue = row.Item("Kota2")
            txtTlp2.Text = row.Item("No_Telepon2").ToString
            txtFax.Text = row.Item("No_Fax").ToString
            txt_Nama_NPWP.Text = row.Item("nm_npwp").ToString
            txtNpwp.Text = row.Item("No_NPWP").ToString
            txtEmail.Text = row.Item("Email").ToString
            txtJnsUsaha.Text = row.Item("Jenis_Usaha").ToString
            txtCP.Text = row.Item("Kontak_Person").ToString
            cbGrade.Text = row.Item("Grade").ToString
            LEWil.EditValue = row.Item("Kd_Wilayah").ToString
            LookUpEditArea.EditValue = row.Item("Kode_Area")
            bolean = row.Item("Rec_Stat").ToString
            cbStatus.Text = IIf(bolean.ToString = "Y", "AKTIF", "TIDAK AKTIF")
            bolean1 = row.Item("sts_group").ToString
            CbStatuGroup.Text = IIf(bolean1.ToString = "Y", "YA", "TIDAK")
            bolean2 = row.Item("depostatus").ToString
            ComboBox1.Text = IIf(bolean2.ToString = "Y", "YA", "TIDAK")
            txtKet.Text = row.Item("Keterangan").ToString
            txtRupiah.Text = row.Item("Norek_Bank_Rupiah").ToString
            txtValas.Text = row.Item("Norek_Bank_Valas").ToString
            txtlimitPIDR2.Text = row.Item("Limit_Piutang_Rupiah").ToString
            txtLimitPValas2.Text = row.Item("Limit_Piutang_Valas").ToString
            txtAtribut1.Text = row.Item("Attribute1").ToString
            txtAtribut2.Text = row.Item("Attribute2").ToString
            txtAtribut3.Text = row.Item("Attribute3").ToString
            txtAtribut4.Text = row.Item("Attribute4").ToString
            txtAtribut5.Text = row.Item("Attribute5").ToString
        End If

    End Sub
    Public Sub edit_click()


        daedit = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Customer as [Nomor],Nama_Customer as [NamaCustomer] from SIF_Customer", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dsedit.Tables("lookup_Customer") Is Nothing Then dsedit.Tables("lookup_Customer").Clear()
        daedit.Fill(dsedit, "lookup_Customer")
        frmCari.set_dso(dsedit.Tables("lookup_Customer")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then


            reload_table(frmCari.row(0))


            STATE = "EDIT"
            btnDelete = True
            btnSave = True
            btnCancel = True
            btnEdit = False
            btnadd = False
            XtraTabControl1.SelectedTabPage = tabForm
            setStatus()
        Else
            cancel_click()
            STATE = ""
        End If
        ' End If
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction
        Dim isvalid As Boolean = True
        If txtNamaCust.Text = "" Then
            ErrorProvider1.SetError(txtNamaCust, "Nama belum diisi!")
            isvalid = False
        Else
            ErrorProvider1.SetError(txtNamaCust, "")
        End If
        If txtAlamat1.Text = "" Then
            ErrorProvider1.SetError(txtAlamat1, "Alamat belum diisi!")
            isvalid = False
        Else
            ErrorProvider1.SetError(txtAlamat1, "")
        End If
        If txtTlp1.Text = "" Then
            ErrorProvider1.SetError(txtTlp1, "No Telp belum diisi!")
            isvalid = False
        Else
            ErrorProvider1.SetError(txtTlp1, "")
        End If
        If Not isDelete Then
            If STATE = "ADD" Then
                dSO1 = New DataSet
                DA1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Customer where 1=0", sqlconn))
                DA1.Fill(dSO1, "SIF_Customer") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
                row = dSO1.Tables("SIF_Customer").NewRow
                row.Item("Kd_Cabang") = getKodeCabang() ' <-- hanya contoh, nanti diisi dengan yg bener
                '''''''''''''''''''''''''''''''''''''''''''
                'row.Item("Kd_Customer") = get_next_counter_master("C", Nothing)
                row.Item("Kd_Customer") = getNoTrans("MCST", getTanggal())
                txtKodeCust.Text = row.Item("Kd_Customer")
                row.Item("Nama_Customer") = txtNamaCust.Text
                row.Item("Tgl_Lahir") = DT_TglLahir.EditValue
                row("Alamat1") = txtAlamat1.Text
                row("Kota1") = LEKota1.EditValue
                row("alias") = txtalias.Text
                row("No_Telepon1") = txtTlp1.Text
                row("Kota2") = LEKota2.EditValue
                row("Alamat2") = txtAlamat2.Text
                row("No_Telepon2") = txtTlp2.Text
                row("No_FAX") = txtFax.Text
                row("nm_npwp") = txt_Nama_NPWP.Text
                row("No_NPWP") = txtNpwp.Text
                row("Email") = txtEmail.Text
                row("Jenis_Usaha") = txtJnsUsaha.Text
                row("Kontak_Person") = txtCP.Text
                row("Grade") = cbGrade.Text
                row("Kode_Area") = LookUpEditArea.EditValue
                row("Kd_Wilayah") = LEWil.EditValue
                row("Keterangan") = txtKet.Text
                row("Norek_Bank_Rupiah") = txtRupiah.Text
                row("Norek_Bank_Valas") = txtValas.Text
                row("Limit_Piutang_Rupiah") = txtlimitPIDR2.Text
                row("Limit_Piutang_Valas") = txtLimitPValas2.Text
                row("Rec_Stat") = IIf(cbStatus.Text = "AKTIF", "Y", "T")
                row("Last_Create_Date") = Now
                row("Last_Created_By") = umum.username
                row("Attribute1") = txtAtribut1.Text
                row("Attribute2") = txtAtribut2.Text
                row("Attribute3") = txtAtribut3.Text
                row("Attribute4") = txtAtribut4.Text
                row("Attribute5") = txtAtribut5.Text
                row("sts_group") = IIf(CbStatuGroup.Text = "YA", "Y", "T")
                row("depostatus") = IIf(ComboBox1.Text = "YA", "Y", "T")
                row("Program_Name") = Me.Name
                ''''''''''
            ElseIf STATE = "EDIT" Then
                row = dSO1.Tables(0).Rows(0)
                row.Item("Nama_customer") = txtNamaCust.Text
                row.Item("Tgl_Lahir") = DT_TglLahir.EditValue
                row("Alamat1") = txtAlamat1.Text
                row("alias") = txtalias.Text
                row("Kota1") = LEKota1.EditValue
                row("No_Telepon1") = txtTlp1.Text
                row("Kota2") = LEKota1.EditValue
                row("Alamat2") = txtAlamat2.Text
                row("No_Telepon2") = txtTlp2.Text
                row("No_FAX") = txtFax.Text
                row("nm_npwp") = txt_Nama_NPWP.Text
                row("No_NPWP") = txtNpwp.Text
                row("Email") = txtEmail.Text
                row("Jenis_Usaha") = txtJnsUsaha.Text
                row("Kontak_Person") = txtCP.Text
                row("Grade") = cbGrade.Text
                row("Kode_Area") = LookUpEditArea.EditValue
                row("Kd_Wilayah") = LEWil.EditValue
                row("Keterangan") = txtKet.Text
                row("Norek_Bank_Rupiah") = txtRupiah.Text
                row("Norek_Bank_Valas") = txtValas.Text
                row("Limit_Piutang_Rupiah") = txtlimitPIDR2.Text
                row("Limit_Piutang_Valas") = txtLimitPValas2.Text
                row("Rec_Stat") = IIf(cbStatus.Text = "AKTIF", "Y", "T")
                row("Attribute1") = txtAtribut1.Text
                row("Attribute2") = txtAtribut2.Text
                row("Attribute3") = txtAtribut3.Text
                row("Attribute4") = txtAtribut4.Text
                row("Attribute5") = txtAtribut5.Text
                row("sts_group") = IIf(CbStatuGroup.Text = "YA", "Y", "T")
                row("depostatus") = IIf(ComboBox1.Text = "YA", "Y", "T")
                row("Last_Update_Date") = Now
                row("Last_Updated_By") = umum.username
                row("Program_Name") = Me.Name
            End If
        End If

        If STATE = "ADD" Then
            dSO1.Tables(0).Rows.Add(row) ' bisa juga ditulis seperti ini, pakai array index, menggantikan "SIF_WILAYAH"
        End If
        Try
            Buildernya = New SqlClient.SqlCommandBuilder(DA1)
            DA1.UpdateCommand = Buildernya.GetUpdateCommand()
            DA1.InsertCommand = Buildernya.GetInsertCommand()
            DA1.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            DA1.UpdateCommand.Transaction = BTRANS
            DA1.InsertCommand.Transaction = BTRANS
            DA1.DeleteCommand.Transaction = BTRANS

            DA1.Update(dSO1.Tables("SIF_Customer"))
            dSO1.Tables("SIF_Customer").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan..")
            loadCusList()
            cancel_click()


        Catch e As Exception
            BTRANS.Rollback()
            dSO1.Tables(0).RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message)
        End Try


    End Sub


    'Public Sub save_click(Optional ByRef isDelete As Boolean = False)
    '    Dim BTRANS As SqlTransaction
    '    Dim isvalid As Boolean = True
    '    If txtNamaCust.Text = "" Then
    '        ErrorProvider1.SetError(txtNamaCust, "Nama belum diisi!")
    '        isvalid = False
    '    Else
    '        ErrorProvider1.SetError(txtNamaCust, "")
    '    End If
    '    If txtAlamat1.Text = "" Then
    '        ErrorProvider1.SetError(txtAlamat1, "Alamat belum diisi!")
    '        isvalid = False
    '    Else
    '        ErrorProvider1.SetError(txtAlamat1, "")
    '    End If
    '    If txtTlp1.Text = "" Then
    '        ErrorProvider1.SetError(txtTlp1, "No Telp belum diisi!")
    '        isvalid = False
    '    Else
    '        ErrorProvider1.SetError(txtTlp1, "")
    '    End If
    '    If Not isDelete Then
    '        If STATE = "ADD" Then
    '            dSO1 = New DataSet
    '            DA1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Customer where 1=0", sqlconn))
    '            DA1.Fill(dSO1, "SIF_Customer") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
    '            row = dSO1.Tables("SIF_Customer").NewRow
    '            row.Item("Kd_Cabang") = 1 ' <-- hanya contoh, nanti diisi dengan yg bener
    '            ''''''''''''''''''''''''''''''''''''''''''
    '            row.Item("Kd_Customer") = get_next_counter_master("C", Nothing)
    '            row.Item("Nama_Customer") = txtNamaCust.Text
    '            row("Alamat1") = txtAlamat1.Text
    '            row("Kota1") = LEKota1.EditValue
    '            row("No_Telepon1") = txtTlp1.Text
    '            row("Kota2") = LEKota2.EditValue
    '            row("Alamat2") = txtAlamat2.Text
    '            row("No_Telepon2") = txtTlp2.Text
    '            row("No_FAX") = txtFax.Text
    '            row("No_NPWP") = txtNpwp.Text
    '            row("Email") = txtEmail.Text
    '            row("Jenis_Usaha") = txtJnsUsaha.Text
    '            row("Kontak_Person") = txtCP.Text
    '            row("Grade") = cbGrade.Text
    '            row("Kode_Area") = LookUpEditArea.EditValue
    '            row("Kd_Wilayah") = LEWil.EditValue
    '            row("Keterangan") = txtKet.Text
    '            row("Norek_Bank_Rupiah") = txtRupiah.Text
    '            row("Norek_Bank_Valas") = txtValas.Text
    '            row("Limit_Piutang_Rupiah") = txtlimitPIDR.Text
    '            row("Limit_Piutang_Valas") = txtLimitPValas.Text
    '            row("Rec_Stat") = IIf(cbStatus.Text = "AKTIF", "Y", "T")
    '            row("Last_Create_Date") = Now
    '            row("Last_Created_By") = umum.username

    '            row("Program_Name") = Me.Name
    '            ''''''''''
    '        ElseIf STATE = "EDIT" Then
    '            row = dSO1.Tables(0).Rows(0)
    '            row.Item("Nama_customer") = txtNamaCust.Text
    '            row("Alamat1") = txtAlamat1.Text
    '            row("Kota1") = LEKota1.EditValue
    '            row("No_Telepon1") = txtTlp1.Text
    '            row("Kota2") = LEKota1.EditValue
    '            row("Alamat2") = txtAlamat2.Text
    '            row("No_Telepon2") = txtTlp2.Text
    '            row("No_FAX") = txtFax.Text
    '            row("No_NPWP") = txtNpwp.Text
    '            row("Email") = txtEmail.Text
    '            row("Jenis_Usaha") = txtJnsUsaha.Text
    '            row("Kontak_Person") = txtCP.Text
    '            row("Grade") = cbGrade.Text
    '            row("Kode_Area") = LookUpEditArea.EditValue
    '            row("Kd_Wilayah") = LEWil.EditValue
    '            row("Keterangan") = txtKet.Text
    '            row("Norek_Bank_Rupiah") = txtRupiah.Text
    '            row("Norek_Bank_Valas") = txtValas.Text
    '            row("Limit_Piutang_Rupiah") = txtlimitPIDR.Text
    '            row("Limit_Piutang_Valas") = txtLimitPValas.Text
    '            row("Rec_Stat") = IIf(cbStatus.Text = "AKTIF", "Y", "T")

    '            row("Last_Update_Date") = Now
    '            row("Last_Updated_By") = umum.username
    '            row("Program_Name") = Me.Name
    '        End If
    '    End If

    '    If STATE = "ADD" Then
    '        dSO1.Tables(0).Rows.Add(row) ' bisa juga ditulis seperti ini, pakai array index, menggantikan "SIF_WILAYAH"
    '    End If
    '    Try
    '        Buildernya = New SqlClient.SqlCommandBuilder(DA1)
    '        DA1.InsertCommand = Buildernya.GetInsertCommand()

    '        DA1.Update(dSO1.Tables("SIF_Customer"))
    '        dSO1.Tables("SIF_Customer").AcceptChanges()
    '        STATE = "EDIT"
    '        txtKodeCust.Text = row("Kd_Customer")
    '        MsgBox("Data Tersimpan !")
    '    Catch e As Exception
    '        dSO1.Tables(0).RejectChanges() ' untuk membatalkan row yg diupdate/insert
    '        MsgBox(e.Message)
    '    End Try


    'End Sub
    Private Sub view_Area()
        'If Not dSO.Tables("LOOKUP_SIF_AREA") Is Nothing Then dSO.Tables("LOOKUP_SIF_AREA").Clear()
        'DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_wilayah,Kode_Area,Nama_Area from sif.dbo.SIF_Area", sqlconn)) '<- query buat ditampilkan di LOV
        'DA.Fill(dSO, "LOOKUP_SIF_AREA")
        'LookUpEditArea.Properties.DataSource = dSO.Tables("LOOKUP_SIF_AREA")


        If Not dSO.Tables("LOOKUP_SIF_AREA") Is Nothing Then dSO.Tables("LOOKUP_SIF_AREA").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Area, Nama_Area from sif.dbo.SIF_Area where kd_wilayah='" & LEWil.EditValue.ToString & "'", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "LOOKUP_SIF_AREA")
        LookUpEditArea.Properties.DataSource = dSO.Tables("LOOKUP_SIF_AREA")
        LookUpEditArea.Properties.ValueMember = "Kode_Area"
        LookUpEditArea.Properties.DisplayMember = "Nama_Area"
    End Sub
    Private Sub view_Wilayah()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Wilayah, Nama_Wilayah from sif.dbo.SIF_Wilayah", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "Wilayah")
        LEWil.Properties.DataSource = dSO.Tables("Wilayah")

    End Sub
    Private Sub frmCustomer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        view_Wilayah()
        'view_Area()
        View_Kota1()
        View_Kota2()
        loadCusList()
        loadLook()
        prn = getParent(Me)
        XtraTabControl1.SelectedTabPage = tabList
        Me.Enabled = True
    End Sub
    Sub View_Kota1()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Kota,Nama_Kota from sif.dbo.SIF_Kota", sqlconn))
        DA.Fill(dSO, "View_Kota1")
        LEKota1.Properties.DataSource = dSO.Tables("View_Kota1")

    End Sub
    Sub View_Kota2()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Kota,Nama_Kota from sif.dbo.SIF_Kota", sqlconn))
        DA.Fill(dSO, "View_Kota2")
        LEKota2.Properties.DataSource = dSO.Tables("View_Kota2")

    End Sub

    Private Sub validasi_entry(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Char.IsLetter(e.KeyChar)) Then
            ErrorProvider1.SetError(sender, "Peringatan! Mohon isi data dengan BENAR")
            e.Handled = True

        Else
            ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    Private Sub txtTlp1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTlp1.KeyPress
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

    Private Sub txtTlp2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTlp2.KeyPress
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

    Private Sub txtNpwp_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNpwp.KeyPress
        'validasi_entry(sender, e)

        Select Case Asc(e.KeyChar)
            'Case 65 To 90 'dari a-z
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 32, 8, 46 'spasi dan bekspes
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txtFax_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFax.KeyPress
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

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        save_click()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        add_click()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        cancel_click()
        Clear_ALL()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        delete_click()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        edit_click()
        STATE = "EDIT"
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub LEWil_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEWil.EditValueChanged
        If Not LEWil.EditValue Is Nothing Then view_Area()
        Dim dr As SqlDataReader = New SqlCommand("select Kode_Area,Nama_Area from sif.dbo.SIF_Area,sif.dbo.SIF_wilayah  where kode_wilayah=kd_wilayah and kode_wilayah='" & LEWil.EditValue & "'", sqlconn).ExecuteReader
        'Dim dr As SqlDataReader = New SqlCommand("select distinct Kode_Area,Nama_Area from sif.dbo.SIF_Area,sif.dbo.SIF_wilayah  where kode_wilayah=kd_wilayah ", sqlconn).ExecuteReader
        If dr.Read() Then
            LookUpEditArea.EditValue = dr(0)
        Else
            LookUpEditArea.EditValue = vbNullString
        End If

        dr.Close()
        'view_Area()
    End Sub

    Private Sub loadCusList()
        dsCust = New DataSet
        daCust = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_Customer", sqlconn))
        daCust.Fill(dsCust, "_SIF_Customer")
        gcCustomer.DataSource = dsCust.Tables("_SIF_Customer")
        gvCustomer.BestFitColumns()
    End Sub

    Private Sub loadLook()
        daLookKota1 = New SqlDataAdapter(New SqlCommand("SELECT Kode_Kota, Nama_Kota FROM SIF.dbo.SIF_Kota", sqlconn))
        daLookKota1.Fill(dsLook, "kota1")
        lueKota1.DataSource = dsLook.Tables("kota1")
        lueKota1.DisplayMember = "Nama_Kota"
        lueKota1.ValueMember = "Kode_Kota"
        daLookKota2 = New SqlDataAdapter(New SqlCommand("SELECT Kode_Kota, Nama_Kota FROM SIF.dbo.SIF_Kota", sqlconn))
        daLookKota2.Fill(dsLook, "kota2")
        lueKota2.DataSource = dsLook.Tables("kota2")
        lueKota2.DisplayMember = "Nama_Kota"
        lueKota2.ValueMember = "Kode_Kota"
        daLookWil = New SqlDataAdapter(New SqlCommand("SELECT Kode_Wilayah, Nama_Wilayah FROM SIF.dbo.SIF_Wilayah", sqlconn))
        daLookWil.Fill(dsLook, "wil")
        lueWil.DataSource = dsLook.Tables("wil")
        lueWil.DisplayMember = "Nama_Wilayah"
        lueWil.ValueMember = "Kode_Wilayah"
        daLookArea = New SqlDataAdapter(New SqlCommand("SELECT Kode_Area, Nama_Area FROM SIF.dbo.SIF_Area", sqlconn))
        daLookArea.Fill(dsLook, "area")
        lueArea.DataSource = dsLook.Tables("area")
        lueArea.DisplayMember = "Nama_Area"
        lueArea.ValueMember = "Kode_Area"
    End Sub

    Public Sub cetak_click()
        gcCustomer.Refresh()
        gcCustomer.ShowPrintPreview()
    End Sub

    Private Sub gcCustomer_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gcCustomer.DoubleClick
        reload_table(gvCustomer.GetRow(gvCustomer.GetSelectedRows(0)).item("Kd_Customer").ToString)
        STATE = "EDIT"
        prn.btnSave.Enabled = True
        prn.btnCancel.Enabled = True
        prn.btnDelete.Enabled = True
        prn.btnAdd.Enabled = False
        prn.btnEdit.Enabled = False
        XtraTabControl1.SelectedTabPage = tabForm
    End Sub

   





End Class