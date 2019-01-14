'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================
Imports System.Data.SqlClient

Public Class frmMasterSales
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, dsO1, DsSales As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Dim row As DataRow '<-- menampung row master
    Dim DA, DAs, daPeg, daWil, daArea, daDept, daLookNama As SqlDataAdapter
    'Dim SalesDAO As New DataAcess.MstSalesDAO
    Dim kode As String
    Dim myBuilder As New SqlCommandBuilder
    Dim rwx As String

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnDelete = False
        btnCancel = True
        XtraTabControl1.SelectedTabPage = XtraTabPage1
        setStatus()
        STATE = "ADD" '<-- set state add

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
        btnSave = False
        btnEdit = True
        btnadd = True
        btnDelete = False
        btnCancel = False
        XtraTabControl1.SelectedTabPage = XtraTabPage2
        setStatus()
        STATE = ""
        bersihkan()

    End Sub

    'Private Sub enabel()
    '    txbKdSales.Enabled = False

    'End Sub
    Sub Tampil_GC_Sales()
        If Not DsSales.Tables("Sales") Is Nothing Then DsSales.Tables("Sales").Clear()
        DAs = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("Select S.Kode_Sales, S.Nama_Sales,D.Nama_Departemen,W.Nama_Wilayah,A.Nama_Area,S.Keterangan,S.Rec_Stat from SIF.dbo.SIF_Sales S, SIF.dbo.SIF_Area A, SIF.dbo.SIF_Wilayah W, SIF.dbo.SIF_Departemen D where S.kode_departemen=D.Kd_Departemen and S.kode_area = A.Kode_Area and S.kode_wilayah = W.Kode_Wilayah and A.Kd_Wilayah = W.Kode_Wilayah", sqlconn))
        DAs.Fill(DsSales, "Sales")
        GC_Sales.DataSource = DsSales.Tables("Sales")
        GVSpon.BestFitColumns()
    End Sub
    Private Sub frmMasterSales_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect() ' untuk koneksi ke server, biasa kan ini ada disetiap form load
        'SalesDAO.conn = sqlconn
        'enabel()
        prn = getParent(Me) '// bila load dr form utama
        XtraTabControl1.SelectedTabPage = XtraTabPage2
        Me.Enabled = True
        'button_int()
        loadPegawai()
        loadDept()
        loadWilayah()
        Tampil_GC_Sales()
        'lblKdPeg.Hide()
        'lblKdArea.Hide()
        'lblKdWil.Hide()
    End Sub

    Private Sub bersihkan()
        'txbKdSales.Text = ""
        txbKet.Text = ""
        txtNama.Text = ""
        cbStatus.SelectedValue = vbNullString
        luePegawai.EditValue = vbNullString
        lueWilayah.EditValue = vbNullString
        lueDept.EditValue = vbNullString
        lueArea.EditValue = vbNullString
    End Sub

    Private Sub entry_angka(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Char.IsLetter(e.KeyChar)) Then
            'ErrorProvider1.SetError(sender, "Peringatan! isian tidak boleh Huruf Alfabet")
            e.Handled = True

            'If Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Or Char.IsPunctuation(e.KeyChar)) Then
            '    'invaled karakter
            '    ErrorProvider1.SetError(sender, "Inputan tidak boleh Huruf alfabet")
            '    e.Handled = True

        Else
            'ErrorProvider1.SetError(sender, "")
        End If
    End Sub

    'Public Sub cek_pegawai()
    '    'dSO = New DataSet
    '    DAs = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Pegawai", sqlconn))  'query table pegawai
    '    If Not dSO.Tables("da2") Is Nothing Then
    '        dSO.Tables("da2").Clear()
    '    End If
    '    DAs.Fill(dSO, "da2")

    '    frmCari.set_dso(dSO.Tables("da2"))
    '    frmCari.ShowDialog()
    '    If Not frmCari.row Is Nothing Then
    '        txbKdPeg.Text = frmCari.row("Kode_Pegawai").ToString
    '        lblKdPeg.Text = frmCari.row("Nama_Pegawai").ToString
    '    End If
    'End Sub

    'Public Sub cek_wilayah()

    '    DAs = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Wilayah", sqlconn))
    '    If Not dSO.Tables("da1") Is Nothing Then
    '        dSO.Tables("da1").Clear()
    '    End If
    '    DAs.Fill(dSO, "da1")
    '    frmCari.set_dso(dSO.Tables("da1"))
    '    frmCari.ShowDialog()
    '    If Not frmCari.row Is Nothing Then
    '        txbKdWil.Text = frmCari.row("Kode_Wilayah").ToString
    '        lblKdWil.Text = frmCari.row("Nama_Wilayah").ToString
    '    End If
    '    '  dSO.Dispose()
    'End Sub

    'Public Sub cek_area()
    '    'dSO = New DataSet
    '    DAs = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Area where  kode_wilayah='" & txbKdWil.Text & "'", sqlconn)) 'query lov tabel area
    '    If Not dSO.Tables("da") Is Nothing Then
    '        dSO.Tables("da").Clear()
    '    End If
    '    DAs.Fill(dSO, "da")

    '    frmCari.set_dso(dSO.Tables("da"))
    '    frmCari.ShowDialog()
    '    If Not frmCari.row Is Nothing Then
    '        txbKdArea.Text = frmCari.row("Kode_Area").ToString
    '        lblKdArea.Text = frmCari.row("Nama_Area").ToString
    '    End If
    'End Sub

    Public Sub delete_click()
        If MsgBox("delete", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            For Each dr As DataRow In dSO.Tables("Sales").Rows
                dr.Delete()
            Next
            'If STATE = "EDIT" Then
            '    DA.Update(dSO.Tables("Sales"))
            '    dSO.Tables("Sales").AcceptChanges()
            'End If
            save_click(True)
        End If
    End Sub

    Public Sub edit_click()

        ' bila menggunakan form cari
        dSO = New DataSet
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Sales", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        DA.Fill(dSO, "LOOKUP_SIF_SALES")
        frmCari.set_dso(dSO.Tables("LOOKUP_SIF_SALES")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            rwx = frmCari.row("Kode_Sales").ToString
            dSO = New DataSet
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Sales where Kode_Sales='" & frmCari.row("Kode_Sales") & "'", sqlconn))
            DA.Fill(dSO, "Sales") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_SALES(nama table bisa diisi sembarang)
            STATE = "EDIT"
            If dSO.Tables("Sales").Rows.Count > 0 Then
                Dim xx As String = frmCari.row("Rec_Stat").ToString
                luePegawai.EditValue = dSO.Tables("Sales").Rows(0).Item("Kode_Pegawai").ToString
                txtNama.Text = dSO.Tables("Sales").Rows(0).Item("Nama_Sales").ToString
                lueDept.EditValue = dSO.Tables("Sales").Rows(0).Item("kode_departemen").ToString
                lueArea.EditValue = dSO.Tables("Sales").Rows(0).Item("kode_area").ToString
                lueWilayah.EditValue = dSO.Tables("Sales").Rows(0).Item("kode_wilayah").ToString
                txbKet.Text = dSO.Tables("Sales").Rows(0).Item("keterangan").ToString
                'cbStatus.SelectedValue = IIf(xx = "Y", "AKTIF", "TIDAK AKTIF")
                If xx = "Y" Then
                    cbStatus.Text = "AKTIF"
                Else
                    cbStatus.Text = "TIDAK AKTIF"
                End If
            Else
                MsgBox("Data tidak diketemukan")
            End If
        End If
        STATE = "EDIT"
        btnDelete = True
        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        XtraTabControl1.SelectedTabPage = XtraTabPage1
        setStatus()
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction
        kode = getNoTrans("MSALES", getTanggal())
        If Not isDelete Then

            If lueArea.Text = "" Or lueArea.EditValue = vbNullString Then
                MsgBox("Area tidak boleh kosong")
                Exit Sub
            End If

            If lueWilayah.Text = "" Or lueWilayah.EditValue = vbNullString Then
                MsgBox("Area tidak boleh kosong")
                Exit Sub
            End If

            If STATE = "ADD" Then
                dSO = New DataSet
                DA = New SqlDataAdapter(New SqlCommand("select * from sif.dbo.SIF_Sales where 1=0", sqlconn))
                DA.Fill(dSO, "SIF_SALES") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
                row = dSO.Tables("SIF_SALES").NewRow
                row.Item("Kd_Cabang") = getKodeCabang() ' <-- hanya contoh, nanti diisi dengan yg bener
                ''>>>>>>>>>>>>>>>>
                row.Item("Kode_Sales") = kode ' klau edit ini tidak boleh diubah
                row.Item("Kode_Pegawai") = luePegawai.EditValue
                row("Nama_Sales") = txtNama.Text
                row("kode_departemen") = lueDept.EditValue
                row("kode_area") = lueArea.EditValue
                row("kode_wilayah") = lueWilayah.EditValue
                row("Keterangan") = txbKet.Text
                row("Rec_Stat") = IIf(cbStatus.Text = "AKTIF", "Y", "T")
                row("Last_Create_Date") = Now
                row("Last_Created_By") = umum.username
                row("Program_Name") = Me.Name
                dSO.Tables("SIF_SALES").Rows.Add(row)
            ElseIf STATE = "EDIT" Then
                row = dSO.Tables("Sales").Rows(0)
                row.Item("Kode_Pegawai") = luePegawai.EditValue
                row("Nama_Sales") = txtNama.Text
                row("kode_departemen") = lueDept.EditValue
                row("kode_area") = lueArea.EditValue
                row("kode_wilayah") = lueWilayah.EditValue
                row("Keterangan") = txbKet.Text
                row("Rec_Stat") = IIf(cbStatus.Text = "AKTIF", "Y", "T")
                row("Last_Update_Date") = Now
                row("Last_Updated_By") = umum.username
                row("Program_Name") = Me.Name
            End If
        End If

        If STATE = "ADD" Then
            ' bisa juga ditulis seperti ini, pakai array index, menggantikan "SIF_SALES"
            Try
                myBuilder = New SqlClient.SqlCommandBuilder(DA)
                DA.UpdateCommand = myBuilder.GetUpdateCommand()
                DA.InsertCommand = myBuilder.GetInsertCommand()
                DA.DeleteCommand = myBuilder.GetDeleteCommand()

                BTRANS = sqlconn.BeginTransaction("1")
                DA.UpdateCommand.Transaction = BTRANS
                DA.InsertCommand.Transaction = BTRANS
                DA.DeleteCommand.Transaction = BTRANS

                DA.Update(dSO.Tables("SIF_SALES"))
                dSO.Tables("SIF_SALES").AcceptChanges()
                STATE = "EDIT"
                BTRANS.Commit()
                showMessages("Berhasil disimpan..")
                Tampil_GC_Sales()
                cancel_click()
                STATE = ""
            Catch ex As Exception
                dSO.Tables("SIF_SALES").RejectChanges()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Saving Data")
            End Try
        ElseIf STATE = "EDIT" Then
            Try
                myBuilder = New SqlClient.SqlCommandBuilder(DA)
                DA.UpdateCommand = myBuilder.GetUpdateCommand()
                DA.InsertCommand = myBuilder.GetInsertCommand()
                DA.DeleteCommand = myBuilder.GetDeleteCommand()

                BTRANS = sqlconn.BeginTransaction("1")
                DA.UpdateCommand.Transaction = BTRANS
                DA.InsertCommand.Transaction = BTRANS
                DA.DeleteCommand.Transaction = BTRANS

                DA.Update(dSO.Tables("Sales"))
                dSO.Tables("Sales").AcceptChanges()
                STATE = "EDIT"
                BTRANS.Commit()
                showMessages("Berhasil disimpan..")
                Tampil_GC_Sales()
                cancel_click()
            Catch ex As Exception
                dSO.Tables("Sales").RejectChanges()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Saving Data")
            End Try
        End If

    End Sub

    'Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
    '    If txbNamaPeg.Text = "" Then
    '        MsgBox("Lengkapi Data sebelum menyimpan!", MsgBoxStyle.Critical, "Mainternance Master Sales")
    '        Exit Sub
    '    Else
    '        save_click()
    '    End If

    'End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        STATE = "EDIT"
        edit_click()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        cancel_click()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        delete_click()
        bersihkan()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    'Private Sub button_int()
    '    cmdAdd.Hide()
    '    cmdEdit.Hide()
    '    cmdCancel.Hide()
    '    cmdSave.Hide()
    '    cmdExit.Hide()
    '    cmdDelete.Hide()
    'End Sub

    'Private Sub txbKdArea_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txbKdArea.TextChanged
    '    Dim sqlread As SqlDataReader = New SqlCommand("select NAMA_AREA from sif.dbo.SIF_AREA where kode_area=" & txbKdArea.Text, sqlconn).ExecuteReader
    '    sqlread.Read()
    '    lblKdArea.Text = sqlread.Item(0)
    '    sqlread.Close()
    '    'frmCari()
    'End Sub

    Sub loadPegawai()
        daPeg = New SqlDataAdapter(New SqlCommand("select Kode_Pegawai, Nama_Pegawai from sif.dbo.SIF_Pegawai", sqlconn))
        daPeg.Fill(dSO, "pegawai")
        luePegawai.Properties.DataSource = dSO.Tables("pegawai")
        luePegawai.Properties.DisplayMember = "Nama_Pegawai"
        luePegawai.Properties.ValueMember = "Kode_Pegawai"
    End Sub

    Sub loadWilayah()
        daWil = New SqlDataAdapter(New SqlCommand("select Kode_Wilayah, Nama_Wilayah from sif.dbo.SIF_Wilayah", sqlconn))
        daWil.Fill(dSO, "wil")
        lueWilayah.Properties.DataSource = dSO.Tables("wil")
        lueWilayah.Properties.DisplayMember = "Nama_Wilayah"
        lueWilayah.Properties.ValueMember = "Kode_Wilayah"
    End Sub

    Sub loadArea()
        daArea = New SqlDataAdapter(New SqlCommand("select Kode_Area, Nama_Area from sif.dbo.SIF_Area where Kd_Wilayah='" & lueWilayah.EditValue & "'", sqlconn))
        daArea.Fill(dSO, "area")
        lueArea.Properties.DataSource = dSO.Tables("area")
        lueArea.Properties.DisplayMember = "Nama_Area"
        lueArea.Properties.ValueMember = "Kode_Area"
    End Sub

    Sub loadDept()
        If Not dSO.Tables("dept") Is Nothing Then dSO.Tables("dept").Clear()
        daDept = New SqlDataAdapter(New SqlCommand("select Kd_Departemen, Nama_Departemen from sif.dbo.SIF_Departemen", sqlconn))
        daDept.Fill(dSO, "dept")
        lueDept.Properties.DataSource = dSO.Tables("dept")
        lueDept.Properties.DisplayMember = "Nama_Departemen"
        lueDept.Properties.ValueMember = "Kd_Departemen"
    End Sub

    Sub loadDept1()
        If Not dSO.Tables("dept") Is Nothing Then dSO.Tables("dept").Clear()
        daDept = New SqlDataAdapter(New SqlCommand("select P.Kode_Departemen, D.Nama_Departemen from sif.dbo.SIF_Departemen D, SIF.dbo.SIF_Pegawai P where P.Kode_Departemen=D.Kd_Departemen and P.Kode_Pegawai='" & luePegawai.EditValue & "'", sqlconn))
        daDept.Fill(dSO, "dept")
        lueDept.Properties.DataSource = dSO.Tables("dept")
        lueDept.Properties.DisplayMember = "Nama_Departemen"
        lueDept.Properties.ValueMember = "Kode_Departemen"
    End Sub

    Sub IsiLuDept()

        Dim dr As SqlDataReader = New SqlCommand("select P.Kode_Departemen, D.Nama_Departemen from sif.dbo.SIF_Departemen D, SIF.dbo.SIF_Pegawai P where P.Kode_Departemen=D.Kd_Departemen and P.Kode_Pegawai='" & luePegawai.EditValue & "'", sqlconn).ExecuteReader
        If dr.Read() Then
            lueDept.EditValue = dr.Item(0)

        Else
            lueDept.EditValue = vbNullString
        End If

        dr.Close()
    End Sub

    Private Sub lueWilayah_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueWilayah.EditValueChanged
        If Not dSO.Tables("area") Is Nothing Then dSO.Tables("area").Clear()
        loadArea()
        'If Not lueWilayah_EditValueChanged.EditValue Is Nothing Then loadArea()
        'Dim dr As SqlDataReader = New SqlCommand("select Kode_Area,Nama_Area from sif.dbo.SIF_Area,sif.dbo.SIF_wilayah  where kode_wilayah=kd_wilayah and kode_wilayah='" & LEWil.EditValue & "'", sqlconn).ExecuteReader
        ''Dim dr As SqlDataReader = New SqlCommand("select distinct Kode_Area,Nama_Area from sif.dbo.SIF_Area,sif.dbo.SIF_wilayah  where kode_wilayah=kd_wilayah ", sqlconn).ExecuteReader
        'If dr.Read() Then
        '    LookUpEditArea.EditValue = dr(0)
        'Else
        '    LookUpEditArea.EditValue = vbNullString
        'End If

        'dr.Close()
    End Sub

    Private Sub luePegawai_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luePegawai.EditValueChanged
        IsiLuDept()
        loadDept1()
        If Not dSO.Tables("nama") Is Nothing Then dSO.Tables("nama").Clear()
        If luePegawai.EditValue = vbNullString Then Exit Sub
        daLookNama = New SqlDataAdapter(New SqlCommand("SELECT Nama_Pegawai FROM SIF.dbo.SIF_Pegawai WHERE Kode_Pegawai='" & luePegawai.EditValue & "'", sqlconn))
        daLookNama.Fill(dSO, "nama")
        txtNama.Text = dSO.Tables("nama").Rows(0).Item("Nama_Pegawai").ToString
    End Sub


    Private Sub GC_Sales_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GC_Sales.DoubleClick
        dSO = New DataSet
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Sales where Kode_Sales='" & GVSpon.GetRow(GVSpon.GetSelectedRows(0)).item("Kode_Sales").ToString & "'", sqlconn))
        DA.Fill(dSO, "Sales") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)

        Dim xx As String = dSO.Tables("Sales").Rows(0).Item("Rec_Stat").ToString
        luePegawai.EditValue = dSO.Tables("Sales").Rows(0).Item("Kode_Pegawai").ToString
        txtNama.Text = GVSpon.GetRow(GVSpon.GetSelectedRows(0)).item("Nama_Sales").ToString
        lueDept.EditValue = dSO.Tables("Sales").Rows(0).Item("kode_departemen").ToString
        lueArea.EditValue = dSO.Tables("Sales").Rows(0).Item("kode_area").ToString
        lueWilayah.EditValue = dSO.Tables("Sales").Rows(0).Item("kode_wilayah").ToString
        txbKet.Text = dSO.Tables("Sales").Rows(0).Item("keterangan").ToString
        If xx = "Y" Then
            cbStatus.Text = "AKTIF"
        Else
            cbStatus.Text = "TIDAK AKTIF"
        End If
        STATE = "EDIT"
        setStatus()
        prn.btnSave.Enabled = True
        prn.btnCancel.Enabled = True
        prn.btnDelete.Enabled = True
        prn.btnAdd.Enabled = False
        prn.btnEdit.Enabled = False
        XtraTabControl1.SelectedTabPage = XtraTabPage1
        txtNama.Focus()
    End Sub
End Class