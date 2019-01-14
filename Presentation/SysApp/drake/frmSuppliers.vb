'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.DXErrorProvider

Public Class frmSuppliers
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, dSO1, dsedit, dsSupp, ds2, dsLook, dskota1, dskota2 As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Dim row As DataRow '<-- menampung row master
    Dim DA, DA1, DA2, daedit, daSupp, daLookKota1, daLookKota2 As SqlDataAdapter
    Dim myDAO As New DataAcess.SupplierDAO
    Dim myBuilder1, myBuilder2 As New SqlCommandBuilder

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        STATE = "ADD" '<-- set state add
        XtraTabControl1.SelectedTabPage = tabForm
        txbNama.Focus()

    End Sub

    'Public Sub save_click()
    '    If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    'End Sub

    'Public Sub exit_click()
    '    If MsgBox("Form Approve akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
    '    Me.Close()
    'End Sub

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Public Sub cancel_click()
        btnSave = True
        btnEdit = False
        btnadd = False
        btnDelete = False
        btnCancel = True
        setStatus()
        XtraTabControl1.SelectedTabPage = tabList
        STATE = "ADD"
        bersihkan()
        'Me.Enabled = False
    End Sub

 

    Private Sub bersihkan()
        txbKdSup.Text = ""
        txbNama.Text = ""
        txbAlamat1.Text = ""
        LEKota1.EditValue = vbNullString
        txbTelp1.Text = ""
        txbAlamat2.Text = ""
        LEKota2.EditValue = vbNullString
        txbTelp2.Text = ""
        txbFax.Text = ""
        txbNPWP.Text = ""
        txbEmail.Text = ""
        txbCP.Text = ""
        cbGrade.Text = "NEW"
        'txbJnsUsaha.Text = ""
        txbRekRP.Text = ""
        txbRekVls.Text = ""
        txbKet.Text = ""
        cbStatus.Text = ""
        cb_stsGroup.Text = ""
        If Not dSO1.Tables("SPD") Is Nothing Then
            dSO1.Tables("SPD").Clear()
        End If
    End Sub

    Private Sub frmSuppliers_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect() ' untuk koneksi ke server, biasa kan ini ada disetiap form load
        da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Barang", sqlconn))
        da2.Fill(ds2, "VBarang")
        RepositoryItemLookUpEdit1.DataSource = ds2.Tables("VBARANG")
        'AddHandler dSO1.Tables("SPD").RowDeleted, AddressOf refreshNomer()

        STATE = "ADD"
        cbGrade.Text = "NEW"
        reload_table("xxx")
        txbKdSup.Enabled = False
        View_Kota1()
        View_Kota2()
        loadSuppList()
        loadLook()
        prn = getParent(Me)
        XtraTabControl1.SelectedTabPage = tabForm
        Me.Enabled = True
    End Sub
    Public Sub edit_click()
        DA1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Supplier", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dSO1.Tables("LOOKUP_SIF_SUPPLIER") Is Nothing Then dSO1.Tables("LOOKUP_SIF_SUPPLIER").Clear()
        DA1.Fill(dSO1, "LOOKUP_SIF_SUPPLIER")
        frmCari.set_dso(dSO1.Tables(0)) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            reload_table(frmCari.row(1))

            STATE = "EDIT"
            btnDelete = False
            btnSave = True
            btnEdit = False
            btnadd = False
            btnCancel = True
            XtraTabControl1.SelectedTabPage = tabForm
            setStatus()
        End If
      
    End Sub
    Public Sub reload_table(ByVal kode As String)
        'dSO = New DataSet
        If Not dSO.Tables("_m_sup") Is Nothing Then dSO.Tables("_m_sup").Clear()
        If Not dSO1.Tables("SPD") Is Nothing Then dSO1.Tables("SPD").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Supplier where Kode_Supplier='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_m_sup") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
        DA1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as Nama_Barang from sif.dbo.SIF_Produk_Supplier where Kd_Supplier='" & kode & "'", sqlconn))
        DA1.Fill(dSO1, "SPD")
        gc.DataSource = dSO1.Tables("SPD")

        If dSO.Tables("_m_sup").Rows.Count > 0 Then
            Dim row As DataRow
            Dim bolean, bolean1 As String
            row = dSO.Tables("_m_sup").Rows(0)
            txbKdSup.Text = row.Item("Kode_Supplier").ToString
            txbNama.Text = row.Item("nama_Supplier").ToString
            txbAlamat1.Text = row.Item("Alamat1").ToString
            LEKota1.EditValue = row.Item("Kota1").ToString
            txbTelp1.Text = row.Item("No_Telepon1").ToString
            txbAlamat2.Text = row.Item("Alamat2").ToString
            LEKota2.EditValue = row.Item("Kota2").ToString
            txbTelp2.Text = row.Item("No_Telepon2").ToString
            txbFax.Text = row.Item("No_Fax").ToString
            txbNPWP.Text = row.Item("No_NPWP").ToString
            txbEmail.Text = row.Item("Email").ToString
            'txbJnsUsaha.Text = row.Item("Jenis_Usaha").ToString
            txbCP.Text = row.Item("Kontak_Person").ToString
            cbGrade.Text = row.Item("Grade").ToString
            bolean = row.Item("Rec_Stat").ToString
            cbStatus.Text = IIf(bolean.ToString = "Y", "AKTIF", "TIDAK AKTIF")
            txbKet.Text = row.Item("keterangan").ToString
            txbRekRP.Text = row.Item("Norek_Bank_Rupiah").ToString
            txbRekVls.Text = row.Item("Norek_Bank_Valas").ToString
            bolean1 = row.Item("sts_group").ToString
            cb_stsGroup.Text = IIf(bolean1.ToString = "Y", "YA", "TIDAK")
        End If
    End Sub

    Sub View_Kota1()
        daLookKota1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Kota,Nama_Kota from sif.dbo.SIF_Kota", sqlconn))
        daLookKota1.Fill(dskota1, "View_Kota1")
        LEKota1.Properties.DataSource = dskota1.Tables("View_Kota1")
        LEKota1.Properties.ValueMember = "Kode_Kota"
        LEKota1.Properties.DisplayMember = "Nama_Kota"

    End Sub
    Sub View_Kota2()
        daLookKota2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Kota,Nama_Kota from sif.dbo.SIF_Kota", sqlconn))
        daLookKota2.Fill(dskota2, "View_Kota2")
        LEKota2.Properties.DataSource = dskota2.Tables("View_Kota2")
        LEKota2.Properties.ValueMember = "Kode_Kota"
        LEKota2.Properties.DisplayMember = "Nama_Kota"

    End Sub
    Private Sub No_Seq(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        For Each rw As DataRow In sender.Rows
            rw("no_seq") = i
            i += 1
        Next

    End Sub
    'Private Sub refreshNomer(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
    '    Dim i As Int16 = 1
    '    Dim j As Int16 = 1
    '    If STATE = "DELETE" Then Exit Sub
    '    For Each rw As DataRow In dSO1.Tables("SPD").Rows
    '        If rw.RowState <> DataRowState.Deleted Then
    '            For Each rwd As DataRow In dSO1.Tables("SPD").Select("no_seq=" & rw.Item("no_seq"))

    '                rwd("no_seq") = i
    '                j = 1
    '                rw("no_seq") = i
    '                '  i += 1
    '            Next
    '            j = 1
    '            rw("no_seq") = i
    '            i += 1
    '        End If
    '    Next
    'End Sub
    Private Sub refreshNomer()
        Dim i As Integer = 1
        If STATE = "ADD" Then
            If gv.RowCount = 0 Then
                Exit Sub
            Else
                For j As Integer = 0 To gv.RowCount - 1
                    gv.GetDataRow(j).Item("no_seq") = i
                    i += 1
                Next
            End If
        Else
            If gv.RowCount = 0 Then
                Exit Sub
            Else
                For Each rw As DataRow In dSO1.Tables("SPD").Rows
                    If rw.RowState <> DataRowState.Deleted Then
                        rw("no_seq") = i
                        i += 1
                    End If
                Next
            End If
        End If
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data Supplier ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            Dim BTRANS As SqlTransaction
            Dim sqlcmd1 As New SqlCommand("delete SIF.dbo.SIF_Supplier where Kode_Supplier='" & txbKdSup.Text & "'", sqlconn, BTRANS)
            sqlcmd1.ExecuteNonQuery()

            Dim sqlcmd2 As New SqlCommand("delete sif.dbo.SIF_Produk_Supplier where kd_supplier='" & txbKdSup.Text & "' ", sqlconn, BTRANS)
            sqlcmd2.ExecuteNonQuery()
            'STATE = "DELETE"
            'If Not dSO.Tables("_m_sup") Is Nothing Then delete(dSO.Tables("_m_sup").Rows)
            'If Not dSO1.Tables("SPD") Is Nothing Then delete(dSO1.Tables("SPD").Rows)

            showMessages("Data Supplier dan Produk terhapus!")
            bersihkan()
            dsSupp.Clear()
            loadSuppList()
            frmMain.btnDelete.Enabled = False
            STATE = "ADD"
        End If
    End Sub
    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub
    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        'Dim isvalid As Boolean = True
        'txbKdSup.Text = getNoTrans("MSUP", getTanggal())
        'If txbNama.Text = "" Then
        '    ErrorProvider1.SetError(txbNama, "Nama belum diisi!")
        '    isvalid = False
        'Else
        '    ErrorProvider1.SetError(txbNama, "")
        'End If
        'If txbAlamat1.Text = "" Then
        '    ErrorProvider1.SetError(txbAlamat1, "Alamat belum diisi!")
        '    isvalid = False
        'Else
        '    ErrorProvider1.SetError(txbAlamat1, "")
        'End If
        'If txbTelp1.Text = "" Then
        '    ErrorProvider1.SetError(txbTelp1, "No Telp belum diisi!")
        '    isvalid = False
        'Else
        '    ErrorProvider1.SetError(txbTelp1, "")
        'End If

        'If txbFax.Text = "" Then
        '    ErrorProvider1.SetError(txbFax, "No FAX belum diisi!")
        '    isvalid = False
        'Else
        '    ErrorProvider1.SetError(txbFax, "")
        'End If

        'If isvalid = True Then
        If Not isDelete Then
            If STATE = "ADD" Then
                'dSO = New DataSet
                'DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Supplier where 1=0", sqlconn))
                'DA.Fill(dSO, "_m_sup") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
                'DA1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Produk_Supplier where 1=0", sqlconn))
                'DA1.Fill(dSO1, "SPD")

                row = dSO.Tables("_m_sup").NewRow
                row.Item("Kd_Cabang") = getKodeCabang()
                txbKdSup.Text = getNoTrans("MSUP", getTanggal())
                row("Kode_Supplier") = txbKdSup.Text
                row("Nama_Supplier") = txbNama.Text
                row("Kota1") = LEKota1.EditValue
                row("No_Telepon1") = txbTelp1.Text
                row("Alamat1") = txbAlamat1.Text
                row("Alamat2") = txbAlamat2.Text
                row("Kota2") = LEKota2.EditValue
                row("No_Telepon2") = txbTelp2.Text
                row("No_Fax") = txbFax.Text
                row("No_NPWP") = txbNPWP.Text
                row("Email") = txbEmail.Text
                'row("Jenis_Usaha") = txbJnsUsaha.Text
                row("Kontak_Person") = txbCP.Text
                row("Grade") = cbGrade.Text
                row("Norek_Bank_Rupiah") = txbRekRP.Text
                row("Norek_Bank_Valas") = txbRekVls.Text
                row("Keterangan") = txbKet.Text
                row("Rec_Stat") = IIf(cbStatus.Text = "AKTIF", "Y", "T")
                row("Last_Create_Date") = Now
                row("Last_Created_By") = umum.username
                row("Last_Update_Date") = Now
                row("Last_Updated_By") = umum.username
                row("Program_Name") = Me.Name
                row("sts_group") = IIf(cb_stsGroup.Text = "YA", "Y", "T")
                dSO.Tables("_m_sup").Rows.Add(row)
            ElseIf STATE = "EDIT" Then
                row = dSO.Tables("_m_sup").Rows(0)
                row.Item("Nama_Supplier") = txbNama.Text
                row("Alamat1") = txbAlamat1.Text
                row("Kota1") = LEKota1.EditValue
                row("No_Telepon1") = txbTelp1.Text
                row("Alamat2") = txbAlamat2.Text
                row("Kota2") = LEKota2.EditValue
                row("No_Telepon2") = txbTelp2.Text
                row("No_Fax") = txbFax.Text
                row("No_NPWP") = txbNPWP.Text
                row("Email") = txbEmail.Text
                row("Kontak_Person") = txbCP.Text
                row("Grade") = cbGrade.Text
                row("Norek_Bank_Rupiah") = txbRekRP.Text
                row("Norek_Bank_Valas") = txbRekVls.Text
                row("Keterangan") = txbKet.Text
                row("Rec_Stat") = IIf(cbStatus.Text = "AKTIF", "Y", "T")
                row("Last_Create_Date") = Now
                row("Last_Created_By") = umum.username
                row("Last_Update_Date") = Now
                row("Last_Updated_By") = umum.username
                row("Program_Name") = Me.Name
                row("sts_group") = IIf(cb_stsGroup.Text = "YA", "Y", "T")
            End If
            'End If

            For Each rows As DataRow In dSO1.Tables("SPD").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("kd_supplier") = row.Item("Kode_Supplier")
                    rows.Item("Last_Create_Date") = Now
                    rows.Item("Last_Created_By") = username

                    rows.Item("kd_Cabang") = kdcabang
                    rows.Item("Program_name") = Me.Name
                ElseIf Not rows.RowState = DataRowState.Deleted Then
                    rows.Item("Last_Update_Date") = Now
                    rows.Item("Last_Updated_By") = username
                End If
            Next
        End If

        If STATE = "ADD" Then
            ' bisa juga ditulis seperti ini, pakai array index, menggantikan "SIF_SALES"
            Try
                myBuilder1 = New SqlClient.SqlCommandBuilder(DA)
                DA.UpdateCommand = myBuilder1.GetUpdateCommand()
                DA.InsertCommand = myBuilder1.GetInsertCommand()
                DA.DeleteCommand = myBuilder1.GetDeleteCommand()

                myBuilder2 = New SqlClient.SqlCommandBuilder(DA1)
                DA1.UpdateCommand = myBuilder2.GetUpdateCommand()
                DA1.InsertCommand = myBuilder2.GetInsertCommand()
                DA1.DeleteCommand = myBuilder2.GetDeleteCommand()


                DA.Update(dSO.Tables("_m_sup"))
                dSO.Tables("_m_sup").AcceptChanges()
                DA1.Update(dSO1.Tables("SPD"))
                dSO1.Tables("SPD").AcceptChanges()
                STATE = "EDIT"
                showMessages("Berhasil disimpan..")
                cancel_click()
            Catch ex As Exception
                dSO.Tables("_m_sup").RejectChanges()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Saving Data")
            End Try
        ElseIf STATE = "EDIT" Then
            Try
                myBuilder1 = New SqlClient.SqlCommandBuilder(DA)
                DA.UpdateCommand = myBuilder1.GetUpdateCommand()
                DA.InsertCommand = myBuilder1.GetInsertCommand()
                DA.DeleteCommand = myBuilder1.GetDeleteCommand()

                myBuilder2 = New SqlClient.SqlCommandBuilder(DA1)
                DA1.UpdateCommand = myBuilder2.GetUpdateCommand()
                DA1.InsertCommand = myBuilder2.GetInsertCommand()
                DA1.DeleteCommand = myBuilder2.GetDeleteCommand()


                DA.Update(dSO.Tables("_m_sup"))
                dSO.Tables("_m_sup").AcceptChanges()
                DA1.Update(dSO1.Tables("SPD"))
                dSO1.Tables("SPD").AcceptChanges()
                STATE = "EDIT"
                showMessages("Berhasil disimpan..")
                cancel_click()
            Catch ex As Exception
                dSO.Tables("_m_sup").RejectChanges()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Saving Data")
            End Try
        End If
        frmMain.btnSave.Enabled = False
        dsSupp.Clear()
        loadSuppList()
    End Sub

    Private Sub validasi_entry(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Char.IsLetter(e.KeyChar)) Then
            ErrorProvider1.SetError(sender, "Peringatan! Mohon isi data dengan BENAR")
            e.Handled = True

            'If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsPunctuation(e.KeyChar)) Then
            '    'invaled karakter
            '    ErrorProvider1.SetError(sender, "Inputan tidak boleh Huruf alfabet")
            '    e.Handled = True

        Else
            ErrorProvider1.SetError(sender, "")
        End If
    End Sub


    'Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If txbNama.Text = "" Then
    '        MsgBox("Lengkapi Data sebelum menyimpan!", MsgBoxStyle.Critical, "Isi Data Supplier")
    '        Exit Sub
    '    Else
    '        save_click()
    '    End If

    'End Sub

    'Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    txbKdSup.Enabled = False
    '    txbNama.Focus()
    '    bersihkan()
    '    add_click() ' cuman manggil fungsi doang

    'End Sub

    'Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    STATE = "EDIT"
    '    edit_click()
    'End Sub

    'Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    cancel_click()
    'End Sub

    'Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    delete_click()
    '    bersihkan()
    'End Sub

    'Private Sub txbRekRP_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbRekRP.KeyPress
    '    validasi_entry(sender, e)
    'End Sub

    Private Sub txbRekVls_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbRekVls.KeyPress
        validasi_entry(sender, e)
    End Sub

    Private Sub txbTelp1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbTelp1.KeyPress
        validasi_entry(sender, e)
    End Sub

    Private Sub txbFax_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbFax.KeyPress
        validasi_entry(sender, e)
    End Sub

    'Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As Syste  m.EventArgs)
    '    Me.Close()
    'End Sub

    Private Sub txbNPWP_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbNPWP.KeyPress
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

    Private Sub txbTelp1_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbTelp1.KeyPress
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

    Private Sub txbTelp2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbTelp2.KeyPress
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

    Private Sub txbFax_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbFax.KeyPress
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

    Private Sub txbRekRP_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbRekRP.KeyPress
        Select Case Asc(e.KeyChar)
            'Case 65 To 90 'dari a-z
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 32, 8, 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub txbRekVls_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txbRekVls.KeyPress
        Select Case Asc(e.KeyChar)
            'Case 65 To 90 'dari a-z
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 32, 8, 46
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub loadSuppList()
        dsSupp = New DataSet
        daSupp = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_Supplier ORDER BY Nama_Supplier", sqlconn))
        daSupp.Fill(dsSupp, "Supplier")
        gcSupplier.DataSource = dsSupp.Tables("Supplier")
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
    End Sub


    Private Sub gcSupplier_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gcSupplier.DoubleClick
        reload_table(gvSupplier.GetRow(gvSupplier.GetSelectedRows(0)).item("Kode_Supplier").ToString)
        STATE = "EDIT"
        prn.btnSave.Enabled = True
        prn.btnCancel.Enabled = True
        prn.btnDelete.Enabled = False
        prn.btnAdd.Enabled = False
        prn.btnEdit.Enabled = False
        XtraTabControl1.SelectedTabPage = tabForm
    End Sub

    Private Sub gc_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gc.KeyDown
        If e.KeyCode = Keys.Delete Then
            If gv.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Record Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar Dari Pemilihan Supplier") = MsgBoxResult.Yes Then
                    gv.DeleteSelectedRows()
                    refreshNomer()
                End If
            End If
        End If
    End Sub

    Private Sub gv_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gv.InitNewRow
        gv.GetRow(e.RowHandle).item("no_seq") = gv.RowCount + 1
    End Sub

    Private Sub gv_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles gv.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub gv_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles gv.ValidatingEditor
        Dim vx As GridView = sender
        If vx.FocusedColumn.FieldName = "kd_barang" Then
            If Not gv.RowCount <= 0 Then
                Dim noInv As String = e.Value
                For i As Integer = 0 To gv.RowCount
                    'MsgBox(vx.GetRowCellValue(i, prev_no_inv))
                    If noInv = vx.GetRowCellValue(i, nama) Then
                        e.Valid = False
                        e.ErrorText = "Barang sudah ada, mohon pilih Barang yang lain."
                    End If
                Next
            End If
        End If
    End Sub
End Class