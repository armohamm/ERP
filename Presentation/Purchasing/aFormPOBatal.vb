Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Data.SqlClient

Public Class aFormPOBatal
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public btnCetak As Boolean = False
    Public prn As frmMain   '<-- untuk mengakses frmMain
    Public obj As Object
    Dim ds, dsedit, ds1, ds2, ds3, ds4, ds5, ds6, ds7, dss, dss1, ds8 As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Dim DA, daedit, da2, da3, da4, da5, da6, da7, da8, sqlda, sqlda1, sqlda2 As SqlDataAdapter
    Dim Buildernya, Buildernyb, Buildernyc As New SqlCommandBuilder
    Dim tgl As String
    Dim po As String
    Dim pr As String
    Dim supp As String
    Dim TemplatePur As String = "TemplatePur"

    Public Sub cetak_click()

        If txtNoPO.Text = "" Then
            MessageBox.Show("PO belum disimpan")
            Exit Sub
        End If
        callReport(App_Path() & "\report\rptPOM.rpt", "", "&no_po=" & Trim(txtNoPO.Text) & " &vnama_report=" & TemplatePur, False, False)
        'callReport(App_Path() & "\report\rptPOM.rpt", "", "no_po=" & Trim(txtNoPO.Text))
        'callReport(App_Path() & "\report\rptPOM.rpt", "", "no_po=" & Trim(txtNoPO.Text) & " &vnama_report=" & TemplatePur, False)
        Dim x As Int16



        ' If STATE = "EDIT" Then
        x = 1
        row = ds3.Tables("PO").Rows(0)
        If row.Item("jml_cetak") = 0 Then
            row.Item("jml_cetak") = x
        Else
            row.Item("jml_cetak") = x + 1
        End If
        row.Item("tgl_cetak") = getTanggal()
        '  End If




        Buildernya = New SqlClient.SqlCommandBuilder(da3)
        da3.UpdateCommand = Buildernya.GetUpdateCommand()
        'da3.InsertCommand = Buildernya.GetInsertCommand()

        da3.Update(ds3.Tables("PO"))

        ds3.Tables("PO").AcceptChanges()


    End Sub

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btnCetak
        End With

    End Sub
    Public Sub add_click()
        STATE = "ADD"
        View_PR_D()
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
        Me.Enabled = True
        controlOff(False)
    End Sub

    Private Function NomorPO(ByVal bgtrans As SqlTransaction) As String
        Dim hasil, temp As String
        Dim sqldr As SqlDataReader = New SqlCommand("select max(substring(IsNULL(no_po,'00001'),1,5))+1 from PURC.DBO.PURC_PO", sqlconn, bgtrans).ExecuteReader
        sqldr.Read()
        temp = ""
        If TypeOf sqldr.Item(0) Is DBNull Then
            Dim bln1 As String = Format(Now, "MM")
            Dim th1 As String = Format(Now, "yyyy")
            hasil = "00001" & "/" & "PO" & "/" & th1 & bln1
        Else
            hasil = sqldr.Item(0)
            For i As Int16 = Len(hasil) To 4
                temp = "0" & temp
            Next
            Dim th, bln As String
            bln = Format(Now, "MM")
            th = Format(Now, "yyyy")
            hasil = temp & (hasil) & "/" & "PO" & "/" & th & bln
        End If
        sqldr.Close()
        Return hasil
    End Function

    Private Sub bersih()
        CEPPN.Checked = False
        dtBayar.DateTime = Date.Today
        dtKirim.DateTime = Date.Today
        dtTanggal.DateTime = Date.Today
        LEPR.EditValue = vbNullString
        LESupllier.EditValue = vbNullString
        LEValuta.EditValue = "IDR"
        txtkurs.EditValue = "1"
        txtKeterangan.Text = ""
        txtTerm.Text = ""
        txtSubTotal.EditValue = vbNullString
        txtJmlDiskon1.EditValue = vbNullString
        txtJmlDiskon.EditValue = vbNullString
        txtJmlPPN.EditValue = vbNullString
        txtJmlTotal.EditValue = vbNullString
        txtNoRef.EditValue = vbNullString
        txtNoPO.EditValue = vbNullString
        txtstatus.EditValue = vbNullString

    End Sub

    Public Sub cancel_click()
        reload_table("XXX")
        bersih()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = False
        setStatus()
        controlOff(True)
        Me.Enabled = False
    End Sub

    Private Sub Init_Bayar()
        If Not ds6.Tables("View_Valuta") Is Nothing Then ds6.Tables("View_Valuta").Clear()
        da6 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Id_Data ,Desc_Data from sif.dbo.SIF_Gen_Reff_D WHERE Id_Ref_File='LMBYR'", sqlconn))
        da6.Fill(ds6, "View_Valuta")
        RentangBayar.Properties.DataSource = ds6.Tables("View_Valuta")
        RentangBayar.Properties.DisplayMember = "Desc_Data"
        RentangBayar.Properties.ValueMember = "Id_Data"
    End Sub

    Sub View_PR_D()
        'da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct no_pr from PURC.DBO.PURC_CHOICE_SUPP where status='APPROVE'", sqlconn))
        'da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct no_pr from PURC.DBO.PURC_PR_D where jns_dpm='MATERIAL'", sqlconn))
        If Not ds.Tables("View_PR_D") Is Nothing Then ds.Tables("View_PR_D").Clear()

        If STATE = "ADD" Then
            da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select DISTINCT PRD.no_pr, PRD.tgl_pr " & _
                                                                        "from PURC.dbo.PURC_PR_D PRD " & _
                                                                        "left join PURC.dbo.PURC_CHOICE_SUPP CSP on PRD.no_pr = CSP.no_pr " & _
                                                                        "and PRD.kd_stok=CSP.kd_stok " & _
                                                                        "where not csp.kd_supp_pilih is null and PRD.jns_dpm='MATERIAL' and CSP.rec_stat='APPROVE' " & _
                                                                        "and not EXISTS (select 1 from purc.dbo.purc_po a, purc.dbo.purc_po_d b " & _
                                                                        "where(a.no_po = b.no_po And PRD.no_pr = a.no_pr And PRD.kd_stok = b.kd_stok) " & _
                                                                        "and csp.kd_supp_pilih=a.kd_supplier)", sqlconn))
        ElseIf STATE = "EDIT" Then
            da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select DISTINCT PRD.no_pr, PRD.tgl_pr " & _
                                                                        "from PURC.dbo.PURC_PR_D PRD " & _
                                                                        "left join PURC.dbo.PURC_CHOICE_SUPP CSP on PRD.no_pr = CSP.no_pr and PRD.kd_stok=CSP.kd_stok " & _
                                                                        "left join PURC.dbo.PURC_PO PO on PRD.no_pr=PO.no_pr and CSP.kd_supp_pilih=PO.kd_supplier " & _
                                                                        "where PRD.jns_dpm='MATERIAL' and CSP.no_csp is not NULL and not(PO.no_po is NULL) and CSP.rec_stat='APPROVE' " & _
                                                                        "order by PRD.tgl_pr", sqlconn))
        End If

        da7.Fill(ds, "View_PR_D")
        LEPR.Properties.DataSource = ds.Tables("View_PR_D")
    End Sub

    Sub View_Valuta()
        da6 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Valuta,Nama_Valuta from sif.dbo.SIF_valuta", sqlconn))
        da6.Fill(ds6, "View_Valuta")
        LEValuta.Properties.DataSource = ds6.Tables("View_Valuta")

    End Sub

    Private Sub NO(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        For Each rw As DataRow In sender.Rows
            rw("no_seq") = i
            i += 1
        Next
    End Sub

    Public Sub edit_click()
        STATE = "EDIT"
        View_PR_D()
        View_Valuta()
        daedit = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_PO as [Nomor],tgl_PO as [Tanggal], rec_stat as Status from PURC.dbo.PURC_PO", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dsedit.Tables("lookup_PO") Is Nothing Then dsedit.Tables("lookup_PO").Clear()
        daedit.Fill(dsedit, "lookup_PO")
        frmCari.set_dso(dsedit.Tables("lookup_PO")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            reload_table(frmCari.row(0))
            If frmCari.row.Item("Status").ToString = "APPROVE" Then
                btnSave = True
                btnadd = False
                btnEdit = False
                btnDelete = False
                btnCancel = True
                setStatus()
                Me.Enabled = True
                controlOff(True)
                GV.OptionsBehavior.ReadOnly = False
                gvAdd.OptionsBehavior.ReadOnly = False
                RentangBayar.Properties.ReadOnly = False
                CEPPN.Properties.ReadOnly = False
            ElseIf frmCari.row.Item("Status").ToString <> "APPROVE" Then
                btnSave = True
                btnadd = False
                btnEdit = False
                btnDelete = False
                btnCancel = True
                setStatus()
                Me.Enabled = True
                controlOff(True)
                GV.OptionsBehavior.ReadOnly = False
                gvAdd.OptionsBehavior.ReadOnly = False
                RentangBayar.Properties.ReadOnly = False
                CEPPN.Properties.ReadOnly = False
            Else
                cancel_click()
                STATE = ""
            End If
        Else
            cancel_click()
        End If
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction
        Dim noPO As String

        If CEPPN.Checked = False Then
            hitung_total()

        End If

        If Not isDelete Then
            If LEPR.EditValue = "" Then
                MsgBox("No PR belum diisi", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                LEPR.Focus()
                Exit Sub
            End If

            If RentangBayar.EditValue = "" Then
                MsgBox("Rentang bayar belum diisi", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                RentangBayar.Focus()
                Exit Sub
            End If

            If LEValuta.EditValue = "" Then
                MsgBox("Valuta Belum Dipilih", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                LEValuta.Focus()
                Exit Sub
            End If

            If STATE = "ADD" Then
                row = ds3.Tables("PO").NewRow
                row.Item("Last_Create_Date") = Now
                row.Item("Last_Created_By") = username
            ElseIf STATE = "EDIT" Then
                row = ds3.Tables("PO").Rows(0)
                row.Item("Last_Update_Date") = Now
                row.Item("Last_Updated_By") = username
            End If

            Dim jatuh_tempo As Date
            jatuh_tempo = DateAdd(DateInterval.Day, 30, dtTanggal.EditValue)

            'row.Item("Kd_Cabang") = getKodeCabang() ' <-- hanya contoh, nanti diisi dengan yg bener
            ''txtNoPO.Text = row.Item("no_po")
            row.Item("tipe_trans") = "JPP-KUT-01"
            row.Item("tgl_po") = dtTanggal.EditValue
            row.Item("tgl_jth_tempo") = jatuh_tempo
            row.Item("jml_cetak") = 0
            row.Item("no_pr") = LEPR.EditValue
            row.Item("no_ref") = txtNoRef.Text
            row.Item("kd_supplier") = LESupllier.EditValue
            row.Item("kd_valuta") = LEValuta.EditValue
            row.Item("kurs_valuta") = txtkurs.Text
            row.Item("tgl_kirim") = dtKirim.EditValue
            row.Item("jml_rp_trans") = txtkurs.Text * txtSubTotal.Text
            row.Item("jml_val_trans") = txtSubTotal.Text
            row.Item("flag_ppn") = CEPPN.EditValue
            'row.Item("flag_diskon") = CheckEdit1.EditValue
            'row.Item("prosen_diskon") = txtJmlDiskon.Text
            'row.Item("jml_diskon") = txtJmlDiskon1.Text
            row.Item("jml_ppn") = txtJmlPPN.Text
            row.Item("keterangan") = txtKeterangan.Text
            row.Item("qty_total") = txtJmlTotal.EditValue
            row.Item("rec_stat") = "ENTRY"
            row.Item("status_po") = "BATAL"
            txtstatus.Text = row.Item("rec_stat")
            'row.Item("tgl_bayar") = dtBayar.EditValue
            'row.Item("lama_bayar") = RentangBayar.EditValue
            'row.Item("term_bayar") = txtTerm.Text
            'row.Item("Program_Name") = Me.Name

            If STATE = "ADD" Then
                ds3.Tables("PO").Rows.Add(row)
            End If

            For Each rows As DataRow In ds4.Tables("POD").Select("qty=0")
                rows.Delete()
            Next

            For Each rows As DataRow In ds4.Tables("POD").Rows

                'If rows.Item("tgl_kirim").ToString = "" Then
                '    GV.SetColumnError(tglkirim, "Tanggal kirim harap diisi Terlebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                '    Exit Sub
                'End If
                ' If Not rows.Item("qty") = 0 Then
                If rows.RowState = DataRowState.Added Then
                    rows.Item("no_po") = row.Item("no_po")
                    rows.Item("Last_Create_Date") = Now
                    rows.Item("Last_Created_By") = username

                    rows.Item("kd_Cabang") = kdcabang
                    rows.Item("tipe_trans") = "JPP-KUT-01"
                ElseIf rows.RowState = DataRowState.Modified Then

                    rows.Item("Last_Update_Date") = Now
                    rows.Item("Last_Updated_By") = username
                End If
                rows.Item("Program_name") = Me.Name
                'Else
                'rows.Delete()
                'End If
            Next

            Dim i As Integer = 1

            For Each rows As DataRow In ds4.Tables("POD").Rows
                If rows.RowState <> DataRowState.Deleted Then
                    rows.Item("no_seq") = i
                    i += 1
                End If
            Next

            For Each rows As DataRow In ds8.Tables("PODAdd").Select("qty=0")
                rows.Delete()
            Next

            For Each rows As DataRow In ds8.Tables("PODAdd").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("no_po") = row.Item("no_po")
                    rows.Item("Last_Create_Date") = Now
                    rows.Item("Last_Created_By") = username

                    rows.Item("kd_Cabang") = kdcabang
                    rows.Item("tipe_trans") = "JPP-KUT-01"
                ElseIf rows.RowState = DataRowState.Modified Then
                    rows.Item("Last_Update_Date") = Now
                    rows.Item("Last_Updated_By") = username
                End If
                rows.Item("Program_name") = Me.Name
            Next

            Dim j As Integer = GV.RowCount + 1

            For Each rows As DataRow In ds8.Tables("PODAdd").Rows
                If rows.RowState <> DataRowState.Deleted Then
                    rows.Item("no_seq") = i
                    j += 1
                End If
            Next
        End If
        Try


            Buildernya = New SqlClient.SqlCommandBuilder(da3)
            da3.UpdateCommand = Buildernya.GetUpdateCommand()
            da3.InsertCommand = Buildernya.GetInsertCommand()
            da3.DeleteCommand = Buildernya.GetDeleteCommand()

            Buildernya = New SqlClient.SqlCommandBuilder(da4)
            da4.UpdateCommand = Buildernya.GetUpdateCommand()
            da4.InsertCommand = Buildernya.GetInsertCommand()
            da4.DeleteCommand = Buildernya.GetDeleteCommand()

            Buildernya = New SqlClient.SqlCommandBuilder(da8)
            da8.UpdateCommand = Buildernya.GetUpdateCommand()
            da8.InsertCommand = Buildernya.GetInsertCommand()
            da8.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            da3.UpdateCommand.Transaction = BTRANS
            da3.InsertCommand.Transaction = BTRANS
            da3.DeleteCommand.Transaction = BTRANS

            da4.UpdateCommand.Transaction = BTRANS
            da4.InsertCommand.Transaction = BTRANS
            da4.DeleteCommand.Transaction = BTRANS

            da8.UpdateCommand.Transaction = BTRANS
            da8.InsertCommand.Transaction = BTRANS
            da8.DeleteCommand.Transaction = BTRANS

            If STATE = "ADD" Then
                If CEPPN.Checked = True Then
                    row.Item("No_po") = getNoTrans("PO-MP", getTanggal(BTRANS), BTRANS)
                Else
                    row.Item("No_po") = getNoTrans("PO-MNP", getTanggal(BTRANS), BTRANS)
                End If
                txtNoPO.Text = row.Item("No_po")
                noPO = txtNoPO.Text
                For Each rows As DataRow In ds4.Tables("POD").Rows
                    If rows.RowState = DataRowState.Added Then
                        rows.Item("No_po") = row.Item("No_po")
                    End If
                Next
                For Each rowx As DataRow In ds8.Tables("PODAdd").Rows
                    If rowx.RowState = DataRowState.Added Then
                        rowx.Item("No_po") = row.Item("No_po")
                    End If
                Next
            End If


            da3.Update(ds3.Tables("PO"))
            da4.Update(ds4.Tables("POD"))
            da8.Update(ds8.Tables("PODAdd"))

            ds3.Tables("PO").AcceptChanges()
            ds4.Tables("POD").AcceptChanges()
            ds8.Tables("PODAdd").AcceptChanges()

            STATE = "EDIT"
            BTRANS.Commit()

            'Dim sqldr As SqlDataReader = New SqlCommand("select max(tgl_kirim) from PURC.DBO.PURC_PO_D where no_po='" & txtNoPO.Text & "'", sqlconn).ExecuteReader
            'sqldr.Read()
            'tgl = Format(sqldr.Item(0), "dd/MM/yyyy").ToString
            'sqldr.Close()
            'Dim sqldrs As Integer = New SqlCommand("update PURC.dbo.PURC_PO SET tgl_kirim = CONVERT(DATE,'" & tgl & "',103) WHERE no_po='" & txtNoPO.Text & "'", sqlconn).ExecuteNonQuery

            controlOff(True)
            showMessages("Berhasil disimpan..")
            btnadd = False
            btnEdit = True
            btnSave = False
            btnDelete = False
            btnCancel = False
            btnCetak = False
            setStatus()
        Catch e As Exception
            BTRANS.Rollback()
            ds3.Tables("PO").RejectChanges()
            ds4.Tables("POD").RejectChanges()
            ds8.Tables("PODAdd").RejectChanges()
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    Private Sub controlOff(ByVal stat As Boolean)
        txtNoPO.Properties.ReadOnly = stat
        dtTanggal.Properties.ReadOnly = stat
        txtNoRef.Properties.ReadOnly = stat
        LEPR.Properties.ReadOnly = stat
        LESupllier.Properties.ReadOnly = stat
        LEValuta.Properties.ReadOnly = stat
        txtkurs.Properties.ReadOnly = stat
        dtKirim.Properties.ReadOnly = stat
        txtKeterangan.ReadOnly = stat
        txtstatus.Properties.ReadOnly = stat
        GV.OptionsBehavior.ReadOnly = stat
        gvAdd.OptionsBehavior.ReadOnly = stat
        RentangBayar.Properties.ReadOnly = stat
        dtBayar.Properties.ReadOnly = stat
        txtTerm.ReadOnly = stat
        CheckEdit1.Properties.ReadOnly = stat
        txtJmlDiskon.Properties.ReadOnly = stat
        txtJmlDiskon1.Properties.ReadOnly = stat
        txtSubTotal.Properties.ReadOnly = stat
        CEPPN.Properties.ReadOnly = stat
        txtJmlPPN.Properties.ReadOnly = stat
        txtJmlTotal.Properties.ReadOnly = stat
    End Sub

    Private Sub reload_table(ByVal kode As String)
        If Not ds3.Tables("PO") Is Nothing Then ds3.Tables("PO").Clear()
        If Not ds4.Tables("POD") Is Nothing Then ds4.Tables("POD").Clear()
        If Not ds8.Tables("PODAdd") Is Nothing Then ds8.Tables("PODAdd").Clear()

        GV.Columns("rec_stat").Visible = False
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_PO where no_po='" & kode & "'", sqlconn))
        da3.Fill(ds3, "PO")

        da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * ,'' As No ,'' as no_pr,'' as Nama_Barang ,qty*harga as total from PURC.dbo.PURC_PO_D where no_po= '" & kode & "'", sqlconn))
        da4.Fill(ds4, "POD")
        GC.DataSource = ds4.Tables("POD")
        'AddHandler ds4.Tables("POD").RowDeleted, AddressOf refreshNomer

        da8 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * ,'' As No ,'' as no_pr,'' as Nama_Barang ,qty*harga as total from PURC.dbo.PURC_PO_D where no_po= '" & kode & "' AND flag_bonus = 'B'", sqlconn))
        da8.Fill(ds8, "PODAdd")
        gcAdd.DataSource = ds8.Tables("PODAdd")
        'AddHandler ds8.Tables("PODAdd").RowDeleted, AddressOf refreshNomerAdd

        'JPP-KUT-01'
        If ds3.Tables("PO").Rows.Count > 0 Then
            Dim row As DataRow

            row = ds3.Tables("PO").Rows(0)
            txtNoPO.Text = row.Item("no_po").ToString
            pr = row.Item("no_pr").ToString
            supp = row.Item("kd_supplier").ToString
            LEPR.EditValue = pr
            LEValuta.EditValue = row.Item("kd_valuta").ToString
            txtkurs.EditValue = row.Item("kurs_valuta").ToString
            'LESupllier.EditValue = supp
            txtNoRef.Text = row.Item("no_ref").ToString
            dtTanggal.EditValue = row.Item("tgl_po")
            dtKirim.Text = row.Item("tgl_kirim")
            dtBayar.Text = row.Item("tgl_bayar")
            RentangBayar.EditValue = CStr(row.Item("lama_bayar"))
            txtTerm.Text = row.Item("term_bayar").ToString
            txtKeterangan.Text = row.Item("keterangan").ToString
            txtstatus.Text = row.Item("rec_stat").ToString
            CEPPN.EditValue = row.Item("flag_ppn").ToString
            txtJmlPPN.EditValue = row.Item("jml_ppn").ToString
            'CheckEdit1.EditValue = row.Item("flag_diskon").ToString
            'txtJmlDiskon.Text = row.Item("prosen_diskon").ToString
            'txtJmlDiskon1.Text = row.Item("jml_diskon").ToString
            txtSubTotal.EditValue = row.Item("jml_val_trans")
            txtJmlTotal.EditValue = row.Item("qty_total")
            txtTotalRupiah.EditValue = row.Item("qty_total") * row.Item("kurs_valuta").ToString
        End If


    End Sub

    Private Sub aFormPOBatal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtKirim.Properties.MinValue = dtTanggal.EditValue
        Reptglkirim.MinValue = Date.Today
        RepositoryItemDateEdit1.MinValue = Date.Today
        dtTanggal.DateTime = Date.Today
        dtKirim.DateTime = dtTanggal.EditValue
        dtBayar.DateTime = Date.Today
        LEValuta.EditValue = "IDR"
        txtkurs.Text = "1"

        connect()

        prn = getParent(Me)


        'View_Valuta()
        'viewBarang()
        'View_PR_D()
        Init_Bayar()
        If Not ds.Tables("VBarangq") Is Nothing Then ds.Tables("VBarangq").Clear()
        da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT Kode_Barang, Nama_Barang FROM SIF.dbo.SIF_Barang", sqlconn))
        da2.Fill(ds, "VBarangq")
        repBrg.DataSource = ds.Tables("VBarangq")
        edit_click()
        'dtTanggal.Text = Date.Today
        'V_Supplier()
        'If txtNoPO.Text = "" Then
        '    reload_table("xxx")
        '    GC.DataSource = ds4.Tables("POD")
        'End If

    End Sub

    Private Sub viewBarang(ByVal supp As String)
        If Not ds.Tables("VBarang") Is Nothing Then ds.Tables("VBarang").Clear()
        da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT a.kd_stok, b.Nama_Barang FROM PURC.dbo.PURC_CHOICE_SUPP a, SIF.dbo.SIF_Barang b WHERE a.kd_stok=b.Kode_Barang AND kd_supp_pilih = '" & supp & "'", sqlconn))
        da2.Fill(ds, "VBarang")
        RepositoryItemLookUpEdit1.DataSource = ds.Tables("VBarang")
        RepositoryItemLookUpEdit1.ValueMember = "kd_stok"
        RepositoryItemLookUpEdit1.DisplayMember = "Nama_Barang"
    End Sub

    Public Sub cariPO(ByVal nocsp As String) ' ============= cretaed by yaya =============
        STATE = "EDIT"
        View_PR_D()
        dss = New DataSet
        dss1 = New DataSet
        sqlda = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_PO where no_po='" & nocsp & "'", sqlconn))
        sqlda.Fill(dss, "_yaya")
        'MsgBox(dss.Tables(0).Rows(0).Item("no_po").ToString)
        If dss.Tables(0).Rows.Count Then
            'txtNoPO.Text = dss.Tables(0).Rows(0).Item("no_po").ToString
            'txtstatus.Text = dss.Tables(0).Rows(0).Item("rec_stat").ToString
            'dtTanggal.Text = dss.Tables(0).Rows(0).Item("tgl_po").ToString
            'LEPR.EditValue = dss.Tables(0).Rows(0).Item("no_pr").ToString
            'LESupllier.EditValue = dss.Tables(0).Rows(0).Item("kd_supplier").ToString
            'LEValuta.EditValue = dss.Tables(0).Rows(0).Item("kd_valuta").ToString
            'txtKeterangan.Text = dss.Tables(0).Rows(0).Item("keterangan").ToString
            row = dss.Tables("_yaya").Rows(0)
            txtNoPO.Text = row.Item("no_po").ToString
            supp = row.Item("kd_supplier").ToString
            LEPR.EditValue = row.Item("no_pr").ToString
            LEValuta.EditValue = row.Item("kd_valuta").ToString
            txtkurs.EditValue = row.Item("kurs_valuta").ToString
            LESupllier.EditValue = supp
            txtNoRef.Text = row.Item("no_ref").ToString
            dtTanggal.Text = row.Item("tgl_po")
            dtKirim.Text = row.Item("tgl_kirim")
            dtBayar.Text = row.Item("tgl_bayar")
            RentangBayar.EditValue = row.Item("lama_bayar")
            txtTerm.Text = row.Item("term_bayar").ToString
            txtKeterangan.Text = row.Item("keterangan").ToString
            txtstatus.Text = row.Item("rec_stat").ToString
            CEPPN.EditValue = row.Item("flag_ppn").ToString
            txtJmlPPN.EditValue = row.Item("jml_ppn").ToString
            'CheckEdit1.EditValue = row.Item("flag_diskon").ToString
            'txtJmlDiskon.Text = row.Item("prosen_diskon").ToString
            'txtJmlDiskon1.Text = row.Item("jml_diskon").ToString
            txtSubTotal.EditValue = row.Item("jml_val_trans")
            txtJmlTotal.EditValue = row.Item("qty_total")

        End If
        sqlda1 = New SqlDataAdapter(New SqlCommand("select * from PURC.DBO.PURC_PO_D where no_po='" & nocsp & "'", sqlconn))
        sqlda1.Fill(dss1, "_yaya_d")
        GC.DataSource = dss1.Tables("_yaya_d")

        sqlda2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * ,'' As No ,'' as no_pr,'' as Nama_Barang ,qty*harga as total from PURC.dbo.PURC_PO_D where no_po= '" & nocsp & "'", sqlconn))
        sqlda2.Fill(dss1, "_yaya_x")
        gcAdd.DataSource = dss1.Tables("_yaya_x")
        controlOff(True)
    End Sub

    Private Sub LEValuta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEValuta.EditValueChanged
        If LEValuta.EditValue = "IDR" Then
            txtkurs.Text = "1"
        Else
            txtkurs.Text = ""
            txtkurs.Focus()
        End If
    End Sub

    Private Sub btSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSimpan.Click
        save_click()
    End Sub

    Private Sub V_Supplier()
        da5 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Supplier,Nama_Supplier from sif.dbo.SIF_Supplier", sqlconn))
        da5.Fill(ds5, "View_Supplier")
        LESupllier.Properties.DataSource = ds5.Tables("View_Supplier")
    End Sub

    Private Sub V_Supplier2() 'filter berdasarkan PR
        If Not ds5.Tables("View_Supplier") Is Nothing Then ds5.Tables("View_Supplier").Clear()
        'LESupllier.EditValue = vbNullString
        'da5 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct Kode_Supplier,Nama_Supplier from sif.dbo.SIF_Supplier s,PURC.DBO.PURC_CHOICE_SUPP csp where kode_supplier=kd_supp_pilih and no_pr='" & LEPR.EditValue & "'and csp.rec_stat ='APPROVE'", sqlconn))

        If STATE = "ADD" Then
            da5 = New SqlDataAdapter(New SqlCommand("select DISTINCT sup.Kode_Supplier,sup.Nama_Supplier " & _
                                                    "from SIF.dbo.SIF_Supplier sup, PURC.dbo.PURC_PR_D PRD " & _
                                                    "left join PURC.dbo.PURC_CHOICE_SUPP CSP on PRD.no_pr = CSP.no_pr " & _
                                                    "and PRD.kd_stok=CSP.kd_stok " & _
                                                    "where not csp.kd_supp_pilih is null and PRD.jns_dpm='MATERIAL' and CSP.rec_stat='APPROVE' " & _
                                                    "and not EXISTS (select 1 from purc.dbo.purc_po a, purc.dbo.purc_po_d b " & _
                                                    "where(a.no_po = b.no_po And PRD.no_pr = a.no_pr And PRD.kd_stok = b.kd_stok) " & _
                                                    "and csp.kd_supp_pilih=a.kd_supplier) " & _
                                                    "and PRD.no_pr='" & LEPR.EditValue & "'" & _
                                                    "and sup.Kode_Supplier=csp.kd_supp_pilih", sqlconn))
        ElseIf STATE = "EDIT" Then
            da5 = New SqlDataAdapter(New SqlCommand("select distinct sup.Kode_Supplier,sup.Nama_Supplier from PURC.dbo.PURC_CHOICE_SUPP csp " & _
                                                    "left join SIF.dbo.SIF_Supplier sup on csp.kd_supp_pilih=sup.Kode_Supplier " & _
                                                    "left join PURC.dbo.PURC_PO po on csp.no_pr = po.no_pr and csp.kd_supp_pilih=po.kd_supplier " & _
                                                    "where csp.no_pr='" & LEPR.EditValue & "' and not(po.no_po is NULL)", sqlconn))
        End If
        da5.Fill(ds5, "View_Supplier")
        LESupllier.Properties.DataSource = ds5.Tables("View_Supplier")
    End Sub

    Private Sub LEPR_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEPR.EditValueChanged
        If STATE = "ADD" Then
            'Dim dr As SqlDataReader = New SqlCommand("select distinct Kode_Supplier from sif.dbo.SIF_Supplier s,PURC.DBO.PURC_CHOICE_SUPP csp  where kode_supplier=kd_supp_pilih and no_pr='" & LEPR.EditValue & "' and csp.rec_stat ='APPROVE'", sqlconn).ExecuteReader
            Dim dr As SqlDataReader = New SqlCommand("select distinct c.kd_supp_pilih from PURC.dbo.PURC_CHOICE_SUPP c " & _
                                                     "where c.no_pr='" & LEPR.EditValue & "'" & _
                                                     "and  not EXISTS (select 1 from PURC.dbo.purc_po a, PURC.dbo.PURC_PO_D b where a.no_po = b.no_po  " & _
                                                     "and a.no_pr ='' and kd_supplier=c.kd_supp_pilih and b.kd_stok=c.kd_stok)", sqlconn).ExecuteReader

            '"where csp.no_pr='" & LEPR.EditValue & "' and po.no_po is NULL", sqlconn).ExecuteReader

            dr.Read()
            If dr.HasRows Then
                V_Supplier2()
                LESupllier.EditValue = dr.Item(0)
            Else
                If Not ds5.Tables("View_Supplier") Is Nothing Then ds5.Tables("View_Supplier").Clear()
                LESupllier.EditValue = ""

            End If

            dr.Close()
        ElseIf STATE = "EDIT" Then
            'LEPR.EditValue = pr
            Dim dr As SqlDataReader = New SqlCommand("select distinct csp.kd_supp_pilih from PURC.dbo.PURC_CHOICE_SUPP csp " & _
                                                     "left join SIF.dbo.SIF_Supplier sup on csp.kd_supp_pilih=sup.Kode_Supplier " & _
                                                     "left join PURC.dbo.PURC_PO po on csp.no_pr = po.no_pr and csp.kd_supp_pilih=po.kd_supplier " & _
                                                     "where csp.no_pr='" & LEPR.EditValue & "' and not(po.no_po is NULL)", sqlconn).ExecuteReader

            dr.Read()
            If dr.HasRows Then
                V_Supplier2()
                LESupllier.EditValue = supp
            Else
                If Not ds5.Tables("View_Supplier") Is Nothing Then ds5.Tables("View_Supplier").Clear()
                LESupllier.EditValue = vbNullString

            End If
            dr.Close()
        End If


    End Sub

    Private Sub LESupllier_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LESupllier.EditValueChanged

        If LESupllier.Text = "" Then
            If Not ds4.Tables("POD") Is Nothing Then ds4.Tables("POD").Clear()
            Exit Sub
        End If
        If txtNoPO.Text = "" Then
            ds4.Tables("POD").Clear()
            'Dim dr As SqlDataReader = New SqlCommand(" select *,0 as prosen_diskon,0 as jml_diskon  from PURC.dbo.vBarangSuplierTerpilih where kd_supp_pilih='" & LESupllier.EditValue & "' and no_pr='" & LEPR.EditValue & "' and rec_stat='APPROVE'", sqlconn).ExecuteReader
            Dim dr As SqlDataReader = New SqlCommand("select *,0 as prosen_diskon,0 as jml_diskon " & _
                                                    "from  PURC.dbo.vBarangSuplierTerpilih " & _
                                                    "where kd_supp_pilih='" & LESupllier.EditValue & "' " & _
                                                    "and no_pr='" & LEPR.EditValue & "' " & _
                                                    "and rec_stat='APPROVE' " & _
                                                    "and kd_stok in( " & _
                                                    "Select PRD.kd_stok " & _
                                                    "from PURC.dbo.PURC_PR_D PRD " & _
                                                    "left join PURC.dbo.PURC_CHOICE_SUPP CSP on PRD.no_pr = CSP.no_pr " & _
                                                    "and PRD.kd_stok=CSP.kd_stok " & _
                                                    "where not csp.kd_supp_pilih is null and PRD.jns_dpm='MATERIAL' and CSP.rec_stat='APPROVE' " & _
                                                    "and not EXISTS (select 1 from purc.dbo.purc_po a, purc.dbo.purc_po_d b " & _
                                                    "where(a.no_po = b.no_po And PRD.no_pr = a.no_pr And PRD.kd_stok = b.kd_stok) " & _
                                                    "and csp.kd_supp_pilih=a.kd_supplier) " & _
                                                    "and PRD.no_pr='" & LEPR.EditValue & "' and csp.kd_supp_pilih='" & LESupllier.EditValue & "') ", sqlconn).ExecuteReader
            Dim i As Int16 = 1
            While dr.Read
                Dim rw As DataRow = ds4.Tables("POD").NewRow
                rw.Item("no_pr") = dr.Item("no_pr")
                rw.Item("kd_stok") = dr.Item("kd_stok")
                rw.Item("Nama_Barang") = dr.Item("Nama_Barang")
                rw.Item("kd_satuan") = dr.Item("kd_satuan")
                rw.Item("harga") = dr.Item("harga_baru")
                rw.Item("qty") = dr.Item("qty")
                'rw.Item("flag_diskon") = dr.Item("flag_diskon").ToString
                rw.Item("prosen_diskon") = dr.Item("prosen_diskon")
                'rw.Item("prosen_diskon") = CType(dr.Item("prosen_diskon"), Double).ToString
                rw.Item("jml_diskon") = dr.Item("jml_diskon")
                rw.Item("total") = dr.Item("total")
                rw.Item("keterangan") = dr.Item("Nama_Barang")
                rw.Item("no_seq") = i
                i += 1
                ds4.Tables("POD").Rows.Add(rw)
            End While
            dr.Close()
            txtSubTotal.EditValue = GV.Columns("total").SummaryText
            hitung_total()
        End If

    End Sub

    Private Sub CEPPN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEPPN.CheckedChanged
        If txtSubTotal.Text = "" Or txtSubTotal.Text = "0" Then
            'MsgBox("Sub Total Masih Kosong,Silahkan Lakukan Transaksi ", MsgBoxStyle.Information, "Perhatian")
            Exit Sub
        Else
            hitung_total()
        End If

    End Sub
    Function getTotal() As Double
        Dim ttl As Double

        For Each rw As DataRow In ds4.Tables("POD").Rows
            If TypeOf rw.Item("qty") Is DBNull Or rw.Item("qty") = 0 Then
                'MsgBox("QTY Masih Kosong, Harap diisi", MsgBoxStyle.Information)
                rw.Item("qty") = 0
                'Exit Function
            ElseIf TypeOf rw.Item("total") Is DBNull Then
                MsgBox(rw("total").ToString, MsgBoxStyle.OkOnly)
                'Else
                '    ttl += CDbl(rw("total"))
            End If

            ttl += CDbl(rw("total"))
        Next
        Return ttl
    End Function

    Private Sub refreshNomer(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        Dim j As Int16 = 1
        If STATE = "DELETE" Then Exit Sub
        For Each rw As DataRow In sender.Rows
            If rw.RowState <> DataRowState.Deleted Then
                For Each rwd As DataRow In ds4.Tables("POD").Select("NO=" & rw.Item("No_seq"))

                    rwd("NO") = i
                    rwd("No_seq") = i & "." & j
                    j += 1
                Next
                j = 1
                rw("No_seq") = i
                i += 1
            End If
        Next
    End Sub

    'Private Sub refreshNomerAdd(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
    '    Dim i As Int16 = GV.RowCount
    '    Dim j As Int16 = 1
    '    If STATE = "DELETE" Then Exit Sub
    '    For Each rw As DataRow In sender.Rows
    '        If rw.RowState <> DataRowState.Deleted Then
    '            For Each rwd As DataRow In ds8.Tables("PODAdd").Select("NO=" & rw.Item("No_seq"))

    '                rwd("NO") = i
    '                rwd("No_seq") = i + j
    '                j += 1
    '            Next
    '            j = 1
    '            rw("No_seq") = i
    '            i += 1
    '        End If
    '    Next
    'End Sub

    Private Sub txtkurs_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkurs.Leave
        'If LEValuta.EditValue <> "Rupiah" Then
        '    MsgBox("Kurs harus diisi !", MsgBoxStyle.Critical, "Perhatian")
        '    txtkurs.Focus()
        'End If
    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Data PO ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            STATE = "DELETE"
            If Not ds3.Tables("PO") Is Nothing Then delete(ds3.Tables("PO").Rows)
            If Not ds4.Tables("POD") Is Nothing Then delete(ds4.Tables("POD").Rows)


            save_click(True)
            'getTotal()
            cancel_click()
            STATE = ""
        End If
    End Sub

    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub
    Private Sub GC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GC.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Record Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar DPM") = MsgBoxResult.Yes Then
                    GV.DeleteSelectedRows()
                End If
            End If
        End If
    End Sub

    Private Sub GV_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles GV.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    'Private Sub GV_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanging
    '    If e.Column Is kd_stok Then
    '        Dim rw As DataRow
    '        rw = ds.Tables("VBARANG").Select("Kode_Barang='" & e.Value & "'")(0)
    '        GV.GetRow(e.RowHandle).item("kd_satuan") = rw("Kd_Satuan")
    '    End If

    '    If e.Column Is QTY Then
    '        'GV.GetRow(e.RowHandle).item("total") = GV.GetRow(e.RowHandle).item("harga").ToString * GV.GetRow(e.RowHandle).item("qty").ToString
    '        txtSubTotal.EditValue = getTotal()
    '    End If

    '    ' txtSubTotal.Text = Total.SummaryItem.SummaryValue
    '    ' txtSubTotal.Text = FormatCurrency(0, 2)
    'End Sub

    Private Sub GV_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.GetRow(e.RowHandle).item("no_seq") = GV.RowCount + 1
        GV.GetRow(e.RowHandle).item("harga") = 0
        GV.GetRow(e.RowHandle).item("qty") = 1
        GV.GetRow(e.RowHandle).item("prosen_diskon") = 0
        GV.GetRow(e.RowHandle).item("jml_diskon") = 0
        GV.GetRow(e.RowHandle).item("total") = 0
    End Sub

    Private Sub GV_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        'If e.Column Is kd_stok Then
        '    Dim rw As DataRow
        '    rw = ds.Tables("VBARANG").Select("Kode_Barang='" & e.Value & "'")(0)
        '    GV.GetRow(e.RowHandle).item("kd_satuan") = rw("Kd_Satuan")
        'End If

        'If e.Column Is QTY Then
        '    GV.GetRow(e.RowHandle).item("total") = GV.GetRow(e.RowHandle).item("harga").ToString * GV.GetRow(e.RowHandle).item("qty").ToString
        '    txtSubTotal.EditValue = getTotal()
        'End If


        If e.Column Is kd_stok Then
            Dim rw As DataRow
            rw = ds.Tables("VBARANG").Select("Kode_Barang='" & e.Value & "'")(0)
            GV.GetRow(e.RowHandle).item("kd_satuan") = rw("Kd_Satuan")
        End If

        Dim hasilX, hasilY As Integer
        If e.Column Is Harga Or e.Column Is QTY Then
            If GV.GetRow(e.RowHandle).item("qty").ToString = "" Then
                GV.SetRowCellValue(e.RowHandle, "qty", 0)
            End If
            Dim subharga As Decimal = GV.GetRow(e.RowHandle).item("harga").ToString * GV.GetRow(e.RowHandle).item("qty").ToString

            If GV.GetRow(e.RowHandle).item("prosen_diskon") = 0 Then
                GV.GetRow(e.RowHandle).item("jml_diskon") = subharga.ToString * (GV.GetRow(e.RowHandle).item("prosen_diskon") / 100).ToString
                GV.GetRow(e.RowHandle).item("total") = subharga.ToString - GV.GetRow(e.RowHandle).item("jml_diskon").ToString
            Else
                GV.GetRow(e.RowHandle).item("total") = subharga.ToString - GV.GetRow(e.RowHandle).item("jml_diskon").ToString
            End If
        End If

        If e.Column Is prosen_diskon Then
            GV.GetRow(e.RowHandle).item("jml_diskon") = 0
            hasilX = GV.GetRow(e.RowHandle).item("harga").ToString * GV.GetRow(e.RowHandle).item("qty").ToString
            GV.GetRow(e.RowHandle).item("jml_diskon") = hasilX.ToString * (GV.GetRow(e.RowHandle).item("prosen_diskon") / 100).ToString
            GV.GetRow(e.RowHandle).item("total") = hasilX.ToString - GV.GetRow(e.RowHandle).item("jml_diskon").ToString
        End If

        If e.Column Is jml_diskon Then
            GV.GetRow(e.RowHandle).item("prosen_diskon") = 0
            hasilY = GV.GetRow(e.RowHandle).item("harga").ToString * GV.GetRow(e.RowHandle).item("qty").ToString
            GV.GetRow(e.RowHandle).item("total") = hasilY.ToString - GV.GetRow(e.RowHandle).item("jml_diskon").ToString
        End If
        txtSubTotal.EditValue = getTotal()
        ' txtSubTotal.Text = Total.SummaryItem.SummaryValue
        ' txtSubTotal.Text = FormatCurrency(0, 2)
    End Sub

    Sub Ubah_Diskon()
        If CheckEdit1.Checked = True Then
            CheckEdit1.Text = "DISKON %"
            txtJmlDiskon.Properties.ReadOnly = False
            txtJmlDiskon1.Properties.ReadOnly = True
            txtJmlDiskon.Text = ""
            txtJmlDiskon1.Text = ""
            txtJmlDiskon1.EditValue = 0
            txtJmlDiskon.Focus()

        Else
            CheckEdit1.Text = "DISKON RP"
            txtJmlDiskon.Properties.ReadOnly = True
            txtJmlDiskon1.Properties.ReadOnly = False
            txtJmlDiskon.Text = ""
            txtJmlDiskon.EditValue = 0
            txtJmlDiskon1.Text = ""
            txtJmlDiskon1.Focus()

        End If
    End Sub

    Sub hitung_total()
        If CEPPN.Checked = True Then
            CEPPN.Text = "PPN"
            txtJmlPPN.EditValue = (txtSubTotal.EditValue - txtJmlDiskon1.EditValue) * (10 / 100)
        Else
            CEPPN.Text = "NON PPN"
            txtJmlPPN.EditValue = 0
        End If

        txtJmlTotal.EditValue = Val((txtSubTotal.EditValue - Val(txtJmlDiskon1.EditValue))) + Val(txtJmlPPN.EditValue)
        txtTotalRupiah.EditValue = Val(Val(txtJmlTotal.EditValue) * Val(txtkurs.EditValue))
    End Sub

    Private Sub txtSubTotal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubTotal.EditValueChanged
        hitung_total()
    End Sub

    Private Sub GV_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        Dim isValid As Boolean = True
        'If e.Row.item("tgl_kirim").ToString = "" Then
        '    isValid = False
        '    GV.SetColumnError(tglkirim, "Tanggal kirim harap diisi Terlebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        'End If
        e.Valid = isValid

    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        Ubah_Diskon()
    End Sub

    Private Sub txtJmlDiskon_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            txtJmlDiskon1.EditValue = txtSubTotal.EditValue * (txtJmlDiskon.EditValue / 100)
            hitung_total()
        End If
    End Sub

    Private Sub txtJmlDiskon1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJmlDiskon1.KeyPress
        If e.KeyChar = Chr(13) Then
            txtJmlDiskon1.EditValue = txtSubTotal.EditValue - txtJmlDiskon1.EditValue
            hitung_total()
        End If
    End Sub

    Private Sub dtKirim_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtKirim.EditValueChanged
        dtBayar.DateTime = dtKirim.DateTime.AddDays(RentangBayar.EditValue * 7)
        'If dtKirim.DateTime < dtTanggal.DateTime Then
        'showMessages(DateDiff(DateInterval.Day, dtKirim.DateTime, dtTanggal.DateTime).ToString)
        'If DateDiff(DateInterval.Day, dtKirim.DateTime, dtTanggal.DateTime) > 0 Then
        '    MsgBox("Tanggal janji kirim tidak boleh lebih kecil dari tanggal PO", MsgBoxStyle.Critical)
        '    dtKirim.DateTime = Date.Today
        'Else

        'End If
    End Sub

    Private Sub RentangBayar_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RentangBayar.EditValueChanged
        If Not RentangBayar.EditValue = "0" Then
            dtBayar.DateTime = dtKirim.DateTime.AddDays(RentangBayar.EditValue * 7)
        Else
            dtBayar.EditValue = dtTanggal.EditValue
        End If
    End Sub

    Private Sub GV_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV.ValidatingEditor
        Dim vx As GridView = sender
        'If vx.FocusedColumn.FieldName = "tgl_kirim" Then
        '    If Not GV.RowCount <= 0 Then
        '        If Not vx.GetFocusedRowCellValue("tgl_kirim").ToString = "" Then
        '            Dim noInv As String = e.Value
        '            'MsgBox(vx.GetRowCellValue(i, prev_no_inv))
        '            If noInv < dtTanggal.EditValue Then
        '                e.Valid = False
        '                e.ErrorText = "Tanggal kedatangan lebih dahulu daripada tanggal janji kirim."
        '            End If
        '        End If
        '    End If
        'Else
        If vx.FocusedColumn.FieldName = "prosen_diskon" Then
            If e.Value > 100 Then
                e.Valid = False
                e.ErrorText = "Diskon % tidak boleh lebih dari 100"
            End If
        End If
    End Sub

    Private Sub gvAdd_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvAdd.CellValueChanged
        Dim vx As GridView = gvAdd
        If e.Column Is addNama Then
            Dim drx As SqlDataReader = New SqlCommand(" select Kd_Satuan from SIF.dbo.SIF_Barang where Kode_Barang='" & vx.GetRowCellValue(e.RowHandle, "kd_stok").ToString & "'", sqlconn).ExecuteReader
            drx.Read()
            vx.SetRowCellValue(e.RowHandle, "kd_satuan", drx.Item(0))
            drx.Close()
        End If
    End Sub

    Private Sub gvAdd_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvAdd.InitNewRow
        gvAdd.GetRow(e.RowHandle).item("no_seq") = GV.RowCount + 1
        If gvAdd.RowCount = 0 Then
            gvAdd.GetRow(e.RowHandle).item("no_seq") = GV.RowCount + 1
        Else
            gvAdd.GetRow(e.RowHandle).item("no_seq") = GV.RowCount + gvAdd.RowCount
        End If
        gvAdd.GetRow(e.RowHandle).item("harga") = 0
        gvAdd.GetRow(e.RowHandle).item("qty") = 1
        gvAdd.GetRow(e.RowHandle).item("prosen_diskon") = 0
        gvAdd.GetRow(e.RowHandle).item("jml_diskon") = 0
        gvAdd.GetRow(e.RowHandle).item("total") = 0
        gvAdd.GetRow(e.RowHandle).item("flag_bonus") = "B"
    End Sub

    Private Sub dtTanggal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtTanggal.EditValueChanged
        dtKirim.Properties.MinValue = dtTanggal.EditValue
        dtKirim.EditValue = dtTanggal.EditValue
    End Sub

    Private Sub txtAngka_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAngka.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 'dari 0-9
                e.Handled = False
                'Case 32, 8, 46, 40, 41, 43
                '    e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub RepositoryItemLookUpEdit1_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles RepositoryItemLookUpEdit1.QueryPopUp
        viewBarang(LESupllier.EditValue)
    End Sub


End Class