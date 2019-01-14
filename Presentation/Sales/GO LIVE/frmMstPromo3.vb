Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Public Class frmMstPromo3
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public btncetak As Boolean = False
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Dim dSO, dsete2 As New DataSet
    Dim Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Dim DA, DA2, DA3, DA4, DA5, DALOOKUP As SqlClient.SqlDataAdapter
    Dim rhandel As Integer
    Dim clone As DataView
    Dim isLoad As Boolean = False

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btncetak
        End With
    End Sub
    Public Sub cancel_click()
        If MsgBox("Anda Yakin Membatalkan Transaksi ?", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Pembatalan") = MsgBoxResult.No Then Exit Sub
        refreshTable("xxx")
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        STATE = ""
        txbNamaPromo.Text = ""
        txbNoPromo.Text = ""
        dtpEnd.Text = vbNullString
        dtpStart.Text = vbNullString
        cmdStatusPromo.EditValue = vbNullString
        cbStat.EditValue = vbNullString
        setStatus()
        disabel()
        Me.Enabled = False
    End Sub
    Public Sub enabel()
        txbNoPromo.Enabled = True
        dtpStart.Enabled = True
        dtpEnd.Enabled = True
        rtbDep.Enabled = True
        cbStat.Enabled = True
        txbNamaPromo.Enabled = True
        'btnCrPromo.Enabled = True
    End Sub
    Public Sub btnstart()
        btAdd.Enabled = True
        btEdit.Enabled = True
        btnSimpan.Enabled = False
        btnDel.Enabled = False
    End Sub
    Public Sub disabel()
        txbNoPromo.Enabled = False
        txbNamaPromo.Enabled = False
        rtbDep.Enabled = False
        cbStat.Enabled = False
        dtpEnd.Enabled = False
        dtpStart.Enabled = False

    End Sub
    Public Sub bersihkan()
        txbNoPromo.Text = ""
        txbNamaPromo.Text = ""
        rtbDep.EditValue = kddep
        cbStat.Text = vbNullString
        dtpEnd.Text = vbNullString
        dtpStart.Text = vbNullString
    End Sub
    Public Function getNextNumber() As String
        Dim hasil, temp As String
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(isnull(no_promo,'x1'),4,10) as numeric)) from SIF.dbo.SIF_Promo", sqlconn).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "PRM000001"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 5
                temp = "0" & temp
            Next
            hasil = "PRM" & temp & (hasil + 1)
        End If
        sqlDR.Close()
        Return hasil
    End Function
    Public Sub save_click()
        If dSO.Tables("_promo_d").Rows.Count = 0 Then
            MsgBox("Data Promo Masih Kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Warning")
            Exit Sub
        End If
        If dSO.Tables("_promo_s").Rows.Count = 0 Then
            MsgBox("Data Promo Masih Kosong", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Warning")
            Exit Sub
        End If
        Dim BTRANS As SqlTransaction

        If STATE = "ADD" Then
            dsete2 = dSO.Clone
            dsete2 = dSO.Copy
            row = dSO.Tables("_promo").NewRow
            row.Item("Last_Create_Date") = getTanggal()
            row.Item("Last_Created_By") = username
            row.Item("no_promo") = getNextNumber()
            row.Item("kd_dept") = rtbDep.EditValue
        ElseIf STATE = "EDIT" Then
            dsete2 = dSO.Clone
            dsete2 = dSO.Copy
            row = dSO.Tables("_promo").Rows(0)
            row.Item("Last_Update_Date") = getTanggal()
            row.Item("Last_Updated_By") = username
        End If
        row.Item("Kd_Cabang") = kdcabang  ' <-- hanya contoh, nanti diisi dengan yg bener
        row.Item("Kelipatan") = cmdKelipatan.EditValue
        row.Item("start_date") = dtpStart.Text
        row.Item("end_date") = dtpEnd.Text
        If Not dtpHitung.EditValue Is Nothing Then row.Item("Tgl_Batas_Kirim") = dtpHitung.EditValue
        row.Item("isPoin") = cmbPoin.EditValue
        row.Item("perhitungan") = cmbHitung.EditValue
        row.Item("nama_promo") = txbNamaPromo.Text
        row.Item("Rec_Stat") = IIf(cbStat.Text = "AKTIF", "Y", "T")
        row.Item("jns_promo") = cmdStatusPromo.Text
        row.Item("Tipe_Promo") = cmbJenisPromo.EditValue
        row.Item("Program_Name") = Me.Name
        row.Item("Jenis_Omzet") = txtJenisOmzet.EditValue

        txbNoPromo.Text = row.Item("no_promo")

        If STATE = "ADD" Then
            dSO.Tables("_promo").Rows.Add(row)
        End If
        For Each rows As DataRow In dSO.Tables("_promo_d").Rows
            If rows.RowState = DataRowState.Added Then
                rows.Item("no_promo") = row.Item("no_promo")
                rows.Item("Last_Create_Date") = getTanggal()
                rows.Item("Last_Created_By") = username
                rows.Item("kd_Cabang") = kdcabang
                rows.Item("Program_name") = Me.Name
            ElseIf rows.RowState <> DataRowState.Deleted Then
                rows.Item("Last_Update_Date") = getTanggal()
                rows.Item("Last_Updated_By") = username
            End If
        Next
        For Each rows As DataRow In dSO.Tables("_promo_s").Rows
            If rows.RowState = DataRowState.Added Then
                rows.Item("no_promo") = row.Item("no_promo")
                rows.Item("Last_Create_Date") = getTanggal()
                rows.Item("Last_Created_By") = username
                rows.Item("Program_name") = Me.Name
            ElseIf rows.RowState <> DataRowState.Deleted Then
                rows.Item("Last_Update_Date") = getTanggal()
                rows.Item("Last_Updated_By") = username
            End If

        Next
        For Each rows As DataRow In dSO.Tables("_promo_p").Rows
            If rows.RowState = DataRowState.Added Then
                rows.Item("no_promo") = row.Item("no_promo")
                rows.Item("kd_Cabang") = kdcabang
                rows.Item("kd_dept") = kddep
                rows.Item("Last_Create_Date") = getTanggal()
                rows.Item("Last_Created_By") = username
                rows.Item("Program_name") = Me.Name
            ElseIf rows.RowState <> DataRowState.Deleted Then
                rows.Item("Last_Update_Date") = getTanggal()
                rows.Item("Last_Updated_By") = username
            End If

        Next

        For Each rows As DataRow In dSO.Tables("_promo_ex").Rows
            If rows.RowState = DataRowState.Added Then
                rows.Item("No_Promo") = row.Item("no_promo")
                rows.Item("kd_Cabang") = kdcabang
            End If
        Next
        Try
            Buildernya = New SqlClient.SqlCommandBuilder(DA)
            Buildernya.ConflictOption = ConflictOption.OverwriteChanges
            DA.UpdateCommand = Buildernya.GetUpdateCommand()
            DA.InsertCommand = Buildernya.GetInsertCommand()
            DA.DeleteCommand = Buildernya.GetDeleteCommand()

            Buildernya = New SqlClient.SqlCommandBuilder(DA2)
            Buildernya.ConflictOption = ConflictOption.OverwriteChanges
            DA2.UpdateCommand = Buildernya.GetUpdateCommand()
            DA2.InsertCommand = Buildernya.GetInsertCommand()
            DA2.DeleteCommand = Buildernya.GetDeleteCommand()

            Buildernya = New SqlClient.SqlCommandBuilder(DA3)
            Buildernya.ConflictOption = ConflictOption.OverwriteChanges
            DA3.UpdateCommand = Buildernya.GetUpdateCommand()
            DA3.InsertCommand = Buildernya.GetInsertCommand()
            DA3.DeleteCommand = Buildernya.GetDeleteCommand()

            Buildernya = New SqlClient.SqlCommandBuilder(DA4)
            Buildernya.ConflictOption = ConflictOption.OverwriteChanges
            DA4.UpdateCommand = Buildernya.GetUpdateCommand()
            DA4.InsertCommand = Buildernya.GetInsertCommand()
            DA4.DeleteCommand = Buildernya.GetDeleteCommand()

            Buildernya = New SqlClient.SqlCommandBuilder(DA5)
            Buildernya.ConflictOption = ConflictOption.OverwriteChanges
            DA5.UpdateCommand = Buildernya.GetUpdateCommand()
            DA5.InsertCommand = Buildernya.GetInsertCommand()
            DA5.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            DA2.UpdateCommand.Transaction = BTRANS
            DA2.InsertCommand.Transaction = BTRANS
            DA2.DeleteCommand.Transaction = BTRANS

            DA3.UpdateCommand.Transaction = BTRANS
            DA3.InsertCommand.Transaction = BTRANS
            DA3.DeleteCommand.Transaction = BTRANS

            DA4.UpdateCommand.Transaction = BTRANS
            DA4.InsertCommand.Transaction = BTRANS
            DA4.DeleteCommand.Transaction = BTRANS

            DA5.UpdateCommand.Transaction = BTRANS
            DA5.InsertCommand.Transaction = BTRANS
            DA5.DeleteCommand.Transaction = BTRANS

            DA.Update(dSO.Tables("_promo"))
            DA2.Update(dSO.Tables("_promo_d"))
            DA3.Update(dSO.Tables("_promo_s"))
            DA4.Update(dSO.Tables("_promo_p"))
            DA5.Update(dSO.Tables("_promo_ex"))

            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan..")
            gvd.CollapseAllDetails()
        Catch e As Exception
            dSO = dsete2.Clone
            dSO = dsete2.Copy
            If Not BTRANS Is Nothing Then BTRANS.Rollback()
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub
    Public Sub edit_klik()
        DA = New SqlDataAdapter(New SqlCommand("select no_promo, nama_promo from SIF.dbo.SIF_Promo", sqlconn))
        If Not dSO.Tables("_LookupPromo") Is Nothing Then dSO.Tables("_LookupPromo").Clear()

        DA.Fill(dSO, "_LookupPromo")
        frmCari.set_dso(dSO.Tables("_LookupPromo"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            isLoad = True
            refreshTable(frmCari.row.Item(0))
            isLoad = False
            btnSave = True
            btnCancel = True
            btnEdit = False
            btnadd = False
            btnDelete = False
            setStatus()
        Else
            btnSave = False
            btnCancel = False
            btnEdit = True
            btnadd = True
            btnDelete = False
            setStatus()
        End If
        'utk master detail
    End Sub
    Private Sub refreshTable(ByVal kode As String)
        If Not dSO.Tables("_promo") Is Nothing Then dSO.Tables("_promo").Clear()
        If Not dSO.Tables("_promo_d") Is Nothing Then dSO.Tables("_promo_d").Clear()
        If Not dSO.Tables("_promo_s") Is Nothing Then dSO.Tables("_promo_s").Clear()
        If Not dSO.Tables("_promo_p") Is Nothing Then dSO.Tables("_promo_p").Clear()
        If Not dSO.Tables("_promo_ex") Is Nothing Then dSO.Tables("_promo_ex").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Promo where no_promo='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_promo")

        DA2 = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_Promo_d where no_promo='" & kode & "'", sqlconn))
        DA2.Fill(dSO, "_promo_d")

        DA3 = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_Promo_syarat where no_promo='" & kode & "'", sqlconn))
        DA3.Fill(dSO, "_promo_s")

        DA4 = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_Promo_Poin where no_promo='" & kode & "'", sqlconn))
        DA4.Fill(dSO, "_promo_p")

        DA5 = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_PROMO_EXCLUDE_CUSTOMER where no_promo='" & kode & "'", sqlconn))
        DA5.Fill(dSO, "_promo_ex")

        If dSO.Tables("_promo").Rows.Count > 0 Then
            txbNoPromo.EditValue = dSO.Tables("_promo")(0)("no_promo").ToString
            txbNamaPromo.EditValue = dSO.Tables("_promo")(0)("nama_promo").ToString
            dtpStart.MinDate = dSO.Tables("_promo")(0)("start_date")
            dtpStart.Value = dSO.Tables("_promo")(0)("start_date")
            dtpEnd.Value = dSO.Tables("_promo")(0)("end_date")
            rtbDep.EditValue = dSO.Tables("_promo")(0)("kd_dept").ToString
            cbStat.EditValue = IIf(dSO.Tables("_promo")(0)("Rec_Stat").ToString = "Y", "AKTIF", "TIDAK AKTIF")
            cmdStatusPromo.EditValue = dSO.Tables("_promo")(0)("jns_promo")
            cmdKelipatan.EditValue = dSO.Tables("_promo")(0)("Kelipatan").ToString
            cmbJenisPromo.EditValue = dSO.Tables("_promo")(0)("Tipe_Promo").ToString
            txtJenisOmzet.EditValue = dSO.Tables("_promo")(0)("Jenis_Omzet").ToString
            cmbHitung.EditValue = dSO.Tables("_promo")(0)("perhitungan").ToString
            If dSO.Tables("_promo")(0)("Tgl_Batas_Kirim").ToString <> "" Then dtpHitung.EditValue = dSO.Tables("_promo")(0)("Tgl_Batas_Kirim")
            If dSO.Tables("_promo")(0)("isPoin").ToString <> "" Then cmbPoin.EditValue = dSO.Tables("_promo")(0)("isPoin").ToString
            cbStat.Properties.ReadOnly = False
        Else
            txbNoPromo.EditValue = vbNullString
            txbNamaPromo.EditValue = vbNullString
            cmdKelipatan.EditValue = "Y"
            cmbJenisPromo.EditValue = vbNullString
            rtbDep.EditValue = Nothing
            cmdStatusPromo.EditValue = "ALL"
            cbStat.EditValue = "Y"
            txtJenisOmzet.EditValue = "Per-Merk"
            dtpHitung.Text = vbNullString
            cmbPoin.EditValue = "T"
            cmbHitung.EditValue = "QTY"
        End If
    End Sub
    Private Sub frmMstPromo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        disabel()
        connect()
        prn = frmMain
        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Merk, Nama_Merk from SIF.dbo.SIF_Merk union all select '__', 'All' ", sqlconn))
        DALOOKUP.Fill(dSO, "_lookup1")
        repMerk.DataSource = dSO.Tables("_lookup1")
        repmerk2.DataSource = dSO.Tables("_lookup1")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select kd_jns, kode_tipe, nama_tipe, Kode_Merk from SIF.dbo.SIF_Tipe union all select  '_', '___', 'All', '__'", sqlconn))
        DALOOKUP.Fill(dSO, "_lookup2")
        repTipe.DataSource = dSO.Tables("_lookup2")
        repType2.DataSource = dSO.Tables("_lookup2")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kd_Customer, Nama_Customer from sif.dbo.sif_customer where isnull(rec_stat,'T')='Y'", sqlconn))
        DALOOKUP.Fill(dSO, "Customer")
        repCustomer.DataSource = dSO.Tables("Customer")
        repCustomer.ValueMember = "Kd_Customer"
        repCustomer.DisplayMember = "Nama_Customer"

        'DALOOKUP = New SqlDataAdapter(New SqlCommand("select KD_SET, NAMA from SIF.dbo.SIF_SET_PRODUCT union select null, null", sqlconn))
        'DALOOKUP.Fill(dSO, "set")
        'repSet.DataSource = dSO.Tables("set")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang union select null, null", sqlconn))
        DALOOKUP.Fill(dSO, "barang")
        repBarangBonus2.DataSource = dSO.Tables("barang")
        repBarang.DataSource = dSO.Tables("barang")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select KD_HADIAH, HADIAH from SIF.dbo.[SIF_BARANG_HADIAH] union select null, null", sqlconn))
        DALOOKUP.Fill(dSO, "hadiah")
        repBarangHadiah.DataSource = dSO.Tables("hadiah")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kd_Tipe,Kd_Sub_Tipe ,Nama_Sub_Tipe from [SIF].[dbo].[SIF_Sub_Tipe] union select '_', '___', 'All'", sqlconn))
        DALOOKUP.Fill(dSO, "sandaran")
        repSandaran.DataSource = dSO.Tables("sandaran")
        repSubType2.DataSource = dSO.Tables("sandaran")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Ukuran, Nama_Ukuran from SIF.dbo.SIF_ukuran union select '___', 'All' ", sqlconn))
        DALOOKUP.Fill(dSO, "ukuran")
        repUkuran.DataSource = dSO.Tables("ukuran")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kd_Departemen, Nama_Departemen from SIF.dbo.SIF_Departemen", sqlconn))
        DALOOKUP.Fill(dSO, "dep")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kd_Jns_Brg, Nama_Jenis, Kd_Jns_Persd, Kd_Departemen from SIF.dbo.SIF_Jenis_Barang where Kd_Jns_Persd='1' union select '___', 'All', '_','_'", sqlconn))
        DALOOKUP.Fill(dSO, "jenis_brg")

        dSO.Tables.Add("tipe_promo")
        dSO.Tables("tipe_promo").Columns.Add("kode")
        dSO.Tables("tipe_promo").Columns.Add("nama")
        Dim rw As DataRow = dSO.Tables("tipe_promo").NewRow()
        rw("kode") = "T"
        rw("nama") = "Per SP"
        dSO.Tables("tipe_promo").Rows.Add(rw)
        rw = dSO.Tables("tipe_promo").NewRow()
        rw("kode") = "Y"
        rw("nama") = "Akumulasi SP"
        dSO.Tables("tipe_promo").Rows.Add(rw)

        cmbJenisPromo.Properties.DataSource = dSO.Tables("tipe_promo")

        repTipePromo.DataSource = dSO.Tables("tipe_promo")
        repBarangHadiah.DataSource = dSO.Tables("hadiah")
        repjenisBarang.DataSource = dSO.Tables("jenis_brg")
        repJenis2.DataSource = dSO.Tables("jenis_brg")
        rtbDep.Properties.DataSource = dSO.Tables("dep")

        refreshTable("xxx")
        GcMstPromo_d.DataSource = dSO.Tables("_promo_d")
        GCP.DataSource = dSO.Tables("_promo_s")
        GC.DataSource = dSO.Tables("_promo_p")
        GCEx.DataSource = dSO.Tables("_promo_ex")
        cmbPoin.EditValue = "T"

    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Form akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub
    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        If MsgBox("Isian pada TextBox tersebut akan dibersihkan??", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        bersihkan()
    End Sub
    Public Sub Add_Click()
        bersihkan()
        enabel()
        STATE = "ADD"
        txtJenisOmzet.EditValue = "Gabungan"
        cmbJenisPromo.EditValue = "T"
        cbStat.EditValue = "AKTIF"
        cbStat.Properties.ReadOnly = True
        cmdKelipatan.EditValue = "Y"
        cmdStatusPromo.EditValue = "ALL"
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
        dtpStart.Value = getTanggal()
    End Sub
    Public Sub Edit_Click()
        enabel()
        btnDel.Enabled = True
        STATE = "EDIT"
        edit_klik()
    End Sub
    Private Sub gvd_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvd.CellValueChanged
        Try
            If (e.Column.FieldName = "kd_brg_bonus" And e.Value.ToString <> "") Or (e.Column.FieldName = "cash_back" And e.Value.ToString <> "") _
            Or (e.Column.FieldName = "Potongan" And e.Value.ToString <> "") Or (e.Column.FieldName = "kd_brg_hadiah" And e.Value.ToString <> "") _
            Or (e.Column.FieldName = "jml_point" And e.Value.ToString <> "") Then
                Dim eval = e.Value
                gvd.SetRowCellValue(e.RowHandle, "kd_brg_bonus", Nothing)
                gvd.SetRowCellValue(e.RowHandle, "cash_back", Nothing)
                gvd.SetRowCellValue(e.RowHandle, "Potongan", Nothing)
                If e.Column.FieldName <> "Potongan" Then gvd.SetRowCellValue(e.RowHandle, "Potongan2", Nothing)
                gvd.SetRowCellValue(e.RowHandle, "kd_brg_hadiah", Nothing)
                gvd.SetRowCellValue(e.RowHandle, "jml_point", Nothing)
                If e.Column.FieldName <> "cash_back" Then gvd.SetRowCellValue(e.RowHandle, "valas", Nothing)
                If e.Column.FieldName <> "kd_brg_bonus" Then
                    gvd.SetRowCellValue(e.RowHandle, "isNambah", Nothing)
                    gvd.SetRowCellValue(e.RowHandle, "isTerkecil", Nothing)
                End If
                gvd.GetRow(e.RowHandle).item(e.Column.FieldName) = eval
            End If
            If (e.Column.FieldName = "valas" And e.Value.ToString <> "") Then
                If gvd.GetRowCellValue(e.RowHandle, "cash_back") Is Nothing Then
                    gvd.SetRowCellValue(e.RowHandle, "valas", Nothing)
                ElseIf gvd.GetRowCellValue(e.RowHandle, "cash_back").ToString = "" Then
                    gvd.SetRowCellValue(e.RowHandle, "valas", Nothing)
                End If
            End If
        Catch ex As NullReferenceException
        End Try
    End Sub

    Private Sub gvd_HiddenEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvd.HiddenEditor
        If Not clone Is Nothing Then
            clone.Dispose()
            clone = Nothing
        End If
    End Sub
    Private Sub GVd_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvd.InitNewRow
        sender.GetRow(e.RowHandle).item("no_seq") = sender.RowCount
        If txtJenisOmzet.EditValue = "Per-Merk" Then
            sender.SetRowCellValue(e.RowHandle, "konjungsi", "AND")
        Else
            sender.SetRowCellValue(e.RowHandle, "konjungsi", "OR")
        End If
        gvd.SetRowCellValue(e.RowHandle, "free_qty", 1)
    End Sub
    Private Sub GVp_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GVP.CellValueChanged
        Dim row As DataRow
        row = sender.GetDataRow(sender.FocusedRowHandle)
        If e.Column.Name = KODE_SET.Name Then
            If e.Value.ToString = "" Then
                GBITEM.Visible = True
            Else
                GBITEM.Visible = False
            End If
        ElseIf e.Column.Name = jmlbeli.Name Then
            Try
                row("jml_rp") = 0
            Catch ex As NullReferenceException
            End Try
        ElseIf e.Column.Name = jmlrp.Name Then
            Try
                row("jml_beli") = 0
            Catch ex As NullReferenceException
            End Try
        ElseIf e.Column.Name = KodeMerk.Name Then
            Try
                row("kd_tipe") = vbNullString
            Catch ex As NullReferenceException
            End Try
        End If
    End Sub
    Private Sub GVP_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GVP.InitNewRow
        sender.SetRowCellValue(e.RowHandle, "seq_syarat", sender.RowCount)
    End Sub
    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        Add_Click()
    End Sub
    Private Sub GVP_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GVP.RowUpdated
        If Not GBITEM.Visible Then
            e.Row.item("kd_tipe") = vbNullString
            e.Row.item("kd_merk") = vbNullString
            e.Row.item("Ukuran") = vbNullString
            e.Row.item("Jns_Barang") = vbNullString
        ElseIf Not GBSET.Visible Then
            e.Row.item("kd_set") = vbNullString
        End If
    End Sub
    Private Sub gvp_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GVP.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub gvp_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GVP.ValidateRow
        Dim valid As Boolean = True
        If e.Row.item("jml_beli").ToString <> "" Then
            If e.Row.item("jml_beli") < 0 Then
                sender.SetColumnError(sender.Columns("jml_beli"), "Angka Tidak Valid", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                valid = False
            End If
        End If
        If e.Row.item("jml_rp").ToString <> "" Then
            If e.Row.item("jml_rp") < 0 Then
                sender.SetColumnError(sender.Columns("jml_rp"), "Angka Tidak Valid", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                valid = False
            End If
        End If

        If e.Row.item("Jns_Barang").ToString = "" Then
            sender.SetColumnError(sender.Columns("Jns_Barang"), "Field Tidak Boleh Kosong", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            valid = False
        End If
        If e.Row.item("kd_merk").ToString = "" Then
            sender.SetColumnError(sender.Columns("kd_merk"), "Field Tidak Boleh Kosong", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            valid = False
        End If
        If e.Row.item("kd_tipe").ToString = "" Then
            sender.SetColumnError(sender.Columns("kd_tipe"), "Field Tidak Boleh Kosong", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            valid = False
        End If
        If e.Row.item("kd_sub_tipe").ToString = "" Then
            sender.SetColumnError(sender.Columns("kd_sub_tipe"), "Field Tidak Boleh Kosong", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            valid = False
        End If
        If e.Row.item("Ukuran").ToString = "" Then
            sender.SetColumnError(sender.Columns("Ukuran"), "Field Tidak Boleh Kosong", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            valid = False
        End If
        e.Valid = valid
    End Sub
    Private Sub gvd_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvd.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub gvex_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GVEx.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub gvex_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GVEx.KeyDown
        Dim j As Int16 = 1
        If e.KeyCode = Keys.Delete Then
            If GVEx.SelectedRowsCount > 0 Then
                GVEx.DeleteSelectedRows()
            End If
        End If
    End Sub
    Private Sub gvd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gvd.KeyDown
        Dim j As Int16 = 1
        If e.KeyCode = Keys.Delete Then
            If gvd.SelectedRowsCount > 0 Then
                If MsgBox("Hapus Data Promo ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Promo") = MsgBoxResult.Yes Then
                    gvd.DeleteSelectedRows()
                    For i As Int16 = 0 To gvd.RowCount - 1
                        gvd.SetRowCellValue(i, "no_seq", i + 1)
                    Next
                End If
            End If
        End If
    End Sub

    Private Sub gvd_ShowingEditor(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles gvd.ShowingEditor
        If dtpHitung.Text <> "" Then
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView
            view = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
            On Error Resume Next
            If view.FocusedColumn.Name = kd_brg_bonus.Name Then
                e.Cancel = True
            ElseIf view.FocusedColumn.Name = Jenis_Barang.Name Then
                e.Cancel = True
            ElseIf view.FocusedColumn.Name = Merk_Barang.Name Then
                e.Cancel = True
            ElseIf view.FocusedColumn.Name = Type_barang.Name Then
                e.Cancel = True
            ElseIf view.FocusedColumn.Name = isNambah.Name Then
                e.Cancel = True
            ElseIf view.FocusedColumn.Name = Subtype_barang.Name Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub gvd_ShownEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvd.ShownEditor
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView
        view = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        On Error Resume Next
        If view.FocusedColumn.Name = Type_barang.Name Then
            Dim row As DataRow
            row = view.GetDataRow(view.FocusedRowHandle)
            If row("Merk").ToString = "" Then Exit Sub
            Dim edit As DevExpress.XtraEditors.LookUpEdit
            Dim table As DataTable
            edit = CType(view.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)
            table = CType(edit.Properties.DataSource, DataTable)
            clone = New DataView(table)

            clone.RowFilter = "Kode_Merk in ( '__', '" & row("Merk") & "')" 'CType(GcMstPromo_d.FocusedView, GridView).GetFocusedRow.item("kd_merk") & "')"
            edit.Properties.DataSource = clone
        ElseIf view.FocusedColumn.Name = Subtype_barang.Name Then
            Dim row As DataRow
            row = view.GetDataRow(view.FocusedRowHandle)
            If row("Tipe").ToString = "" Then Exit Sub
            Dim edit As DevExpress.XtraEditors.LookUpEdit
            Dim table As DataTable
            edit = CType(view.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)
            table = CType(edit.Properties.DataSource, DataTable)
            clone = New DataView(table)

            clone.RowFilter = "Kd_Tipe in ( '_', '" & row("Tipe") & "')"
            edit.Properties.DataSource = clone
        End If
    End Sub

    Private Sub gvd_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvd.ValidateRow
        Dim valid As Boolean = True
        If e.Row.item("jml_point").ToString = "" And e.Row.item("cash_back").ToString = "" And _
         e.Row.item("Potongan").ToString = "" And e.Row.item("kd_brg_bonus").ToString = "" And _
         e.Row.item("kd_brg_hadiah").ToString = "" And e.Row.item("Potongan").ToString = "" Then
            gvd.SetColumnError(jml_point, "Harap Mengisi Kolom hadiah", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            gvd.SetColumnError(cash_back, "Harap Mengisi Kolom hadiah", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            gvd.SetColumnError(potongan, "Harap Mengisi Kolom hadiah", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            gvd.SetColumnError(valasCB, "Harap Mengisi Kolom hadiah", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            gvd.SetColumnError(free_qty, "Harap Mengisi Kolom hadiah", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            gvd.SetColumnError(kd_brg_bonus, "Harap Mengisi Kolom hadiah", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            gvd.SetColumnError(kd_brg_hadiah, "Harap Mengisi Kolom hadiah", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)

            valid = False
        End If
        If e.Row.item("jml_point").ToString <> "" Then
            If e.Row.item("jml_point") <= 0 Then
                gvd.SetColumnError(jml_point, "Angka Tidak Valid", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                valid = False
            End If
        End If
        If e.Row.item("kd_brg_bonus").ToString <> "" Then
            If e.Row.item("isNambah").ToString = "" Then
                gvd.SetColumnError(isNambah, "Kolom Tidak Boleh Kosong", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                valid = False
            End If
            'If e.Row.item("isTerkecil").ToString = "" Then
            '    gvd.SetColumnError(terkecil, "Kolom Tidak Boleh Kosong", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            '    valid = False
            'End If
        End If
        If e.Row.item("cash_back").ToString <> "" Then
            If e.Row.item("cash_back") <= 0 Then
                gvd.SetColumnError(cash_back, "Angka Tidak Valid", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                valid = False
            ElseIf e.Row.item("valas").ToString = "" Then
                gvd.SetColumnError(valasCB, "Harap Mengisi Valas Cash Back", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                valid = False
            End If
        End If
        If e.Row.item("Potongan").ToString <> "" Then
            If e.Row.item("Potongan") <= 0 Or e.Row.item("Potongan") >= 100 Then
                gvd.SetColumnError(potongan, "Angka Tidak Valid", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                valid = False
            End If
        End If
        If e.Row.item("Potongan2").ToString <> "" Then
            If e.Row.item("Potongan2") <= 0 Or e.Row.item("Potongan2") >= 100 Then
                gvd.SetColumnError(potongan2, "Angka Tidak Valid", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                valid = False
            End If
        End If
        If e.Row.item("free_qty").ToString <> "" Then
            If e.Row.item("free_qty") <= 0 Then
                gvd.SetColumnError(free_qty, "Angka Tidak Valid", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                valid = False
            End If
        Else
            gvd.SetColumnError(free_qty, "Qty Tidak Boleh Kosong", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            valid = False
        End If

        e.Valid = valid
    End Sub
    Private Sub GVP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GVP.KeyDown

        If e.KeyCode = Keys.Delete Then
            If GVP.SelectedRowsCount > 0 Then
                GVP.DeleteSelectedRows()
                For i = 0 To GVP.RowCount - 1
                    GVP.GetRow(i).item("seq_syarat") = i + 1
                Next
            End If
        End If

    End Sub
    Private Sub cmdJenisPromo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdStatusPromo.TextChanged
        If cmdStatusPromo.Text = "" Then
            lblDescSB.Text = ""
        ElseIf cmdStatusPromo.Text = "ONLY ONE" Then
            lblDescSB.Text = "*) Hanya mendapatkan 1 hadiah saja"
        Else
            lblDescSB.Text = "*) Bisa mendapatkan lebih dari satu hadiah"
        End If
    End Sub
    Private Sub GVp_ShownEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVP.ShownEditor
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView
        view = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        On Error Resume Next
        If view.FocusedColumn.Name = KodeTipe.Name Then
            Dim row As DataRow
            row = view.GetDataRow(view.FocusedRowHandle)
            If row("kd_merk").ToString = "" Then Exit Sub
            Dim edit As DevExpress.XtraEditors.LookUpEdit
            Dim table As DataTable
            edit = CType(view.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)
            table = CType(edit.Properties.DataSource, DataTable)
            clone = New DataView(table)

            clone.RowFilter = "Kode_Merk in ( '__', '" & row("kd_merk") & "')" 'CType(GcMstPromo_d.FocusedView, GridView).GetFocusedRow.item("kd_merk") & "')"
            edit.Properties.DataSource = clone
        ElseIf view.FocusedColumn.Name = kd_sub_jenis.Name Then
            Dim row As DataRow
            row = view.GetDataRow(view.FocusedRowHandle)
            If row("kd_tipe").ToString = "" Then Exit Sub
            Dim edit As DevExpress.XtraEditors.LookUpEdit
            Dim table As DataTable
            edit = CType(view.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)
            table = CType(edit.Properties.DataSource, DataTable)
            clone = New DataView(table)

            clone.RowFilter = "Kd_Tipe in ( '_', '" & row("kd_tipe") & "')"
            edit.Properties.DataSource = clone
        ElseIf view.FocusedColumn.Name = JenisBarang.Name Then

            Dim row As DataRow
            row = view.GetDataRow(view.FocusedRowHandle)

            Dim edit As DevExpress.XtraEditors.LookUpEdit
            Dim table As DataTable
            edit = CType(view.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)
            table = CType(edit.Properties.DataSource, DataTable)
            clone = New DataView(table)

            clone.RowFilter = "Kd_Departemen in ('" & rtbDep.EditValue & "','_')" 'CType(GcMstPromo_d.FocusedView, GridView).GetFocusedRow.item("kd_merk") & "')"
            edit.Properties.DataSource = clone

        End If
    End Sub
    Private Sub GVp_HiddenEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles GVP.HiddenEditor
        If Not clone Is Nothing Then
            clone.Dispose()
            clone = Nothing
        End If
    End Sub
    Private Sub txtJenisOmzet_QueryCloseUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtJenisOmzet.QueryCloseUp
        If Not isLoad Then
            If dSO.Tables("_promo_d").Rows.Count > 0 Then
                If (MsgBox("Data Promo Akan Dibersihkan!. Lanjutkan Proses ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Perhatian")) = MsgBoxResult.No Then
                    e.Cancel = True
                Else
                    dSO.Tables("_promo_d").Rows.Clear()
                    dSO.Tables("_promo_p").Rows.Clear()
                End If
            End If
        End If
        If sender.text = "Per-Merk" Then
            bandGabungan.Visible = False
            bandTargetItem.Visible = True
        Else
            bandGabungan.Visible = True
            bandTargetItem.Visible = False

        End If
    End Sub

    Private Sub txtJenisOmzet_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJenisOmzet.SelectedIndexChanged
        txtJenisOmzet_QueryCloseUp(sender, New System.ComponentModel.CancelEventArgs)
    End Sub

    Private Sub rtbDep_QueryCloseUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles rtbDep.QueryCloseUp
        If Not isLoad Then
            If dSO.Tables("_promo_d").Rows.Count > 0 Then
                If (MsgBox("Data Promo Akan Dibersihkan!. Lanjutkan Proses ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Perhatian")) = MsgBoxResult.No Then
                    e.Cancel = True
                Else
                    dSO.Tables("_promo_d").Rows.Clear()
                    dSO.Tables("_promo_p").Rows.Clear()
                End If
            End If
        End If
    End Sub

    Private Sub rtbDep_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rtbDep.EditValueChanged
        rtbDep_QueryCloseUp(sender, New System.ComponentModel.CancelEventArgs)
    End Sub

    Private Sub dtpStart_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStart.ValueChanged
        dtpEnd.MinDate = dtpStart.Value
    End Sub

    Private Sub cmbJenisPromo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbJenisPromo.EditValueChanged
        If cmbJenisPromo.EditValue Is Nothing Then
            dtpHitung.Enabled = True
            dtpHitung.Text = vbNullString
        ElseIf cmbJenisPromo.EditValue = "T" Then
            dtpHitung.Enabled = True
            dtpHitung.Text = vbNullString
        Else
            dtpHitung.Enabled = True
            dtpHitung.Properties.MinValue = dtpEnd.Value
        End If
    End Sub

    Private Sub dtpEnd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEnd.ValueChanged
        If Not cmbJenisPromo.EditValue Is Nothing Then
            If cmbJenisPromo.EditValue = "Y" Then
                dtpHitung.Properties.MinValue = dtpEnd.Value
            End If
        End If
    End Sub

    Private Sub cmbPoin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPoin.SelectedIndexChanged
        If gvd.RowCount > 1 And isLoad = False Then
            Exit Sub
        ElseIf cmbPoin.Text = "Y" Then
            GBHadiah.Visible = False
            GBPoin.Visible = True
            btnPoin.Enabled = True
        Else
            GBHadiah.Visible = True
            GBPoin.Visible = False
            btnPoin.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPoin.Click
        If Not GC.Visible Then
            GcMstPromo_d.Visible = False
            GCP.Visible = False
            GC.Dock = DockStyle.Fill
            GC.Visible = True
            GCEx.Visible = False
        Else
            GcMstPromo_d.Visible = True
            GCP.Visible = True
            GC.Visible = False
            GCEx.Visible = False
        End If
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        save_click()
    End Sub

    
    Private Sub btnExclude_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExclude.Click
        If Not GCEx.Visible Then
            GcMstPromo_d.Visible = False
            GCP.Visible = False
            GCEx.Dock = DockStyle.Fill
            GC.Visible = False
            GCEx.Visible = True
        Else
            GcMstPromo_d.Visible = True
            GCP.Visible = True
            GC.Visible = False
            GCEx.Visible = False
        End If
    End Sub

    Private Sub GVEx_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GVEx.ValidateRow
        Dim isvalid As Boolean = True
        Dim rw() As DataRow = dSO.Tables("_promo_ex").Select("Kd_Customer = '" & e.Row.item("Kd_Customer") & "'")
        If rw.Count = 1 Then
            If Not rw(0) Is e.Row.row Then
                isvalid = False
                GVEx.SetColumnError(Kd_Customer, "Customer Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If
        e.Valid = isvalid
    End Sub

    Private Sub dtpHitung_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles dtpHitung.QueryPopUp
        If dSO.Tables("_promo_d").Select("isnull(kd_brg_bonus,'') =''").Count > 0 Then
            'MsgBox("Tanggal batas kirim hanya untuk hadiah berupa Cashback")
            dtpHitung.CancelPopup()
        ElseIf dSO.Tables("_promo_d").Select("isnull(Jenis,'') =''").Count > 0 Then
            'MsgBox("Tanggal batas kirim hanya untuk hadiah berupa Cashback")
            dtpHitung.CancelPopup()
        End If
    End Sub

   
End Class