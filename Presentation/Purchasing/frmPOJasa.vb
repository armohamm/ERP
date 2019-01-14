Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient
Public Class frmPOJasa
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btncetak As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Dim tgl As String

    Public btnEdit As Boolean = True
    Public prn As frmMain   '<-- untuk mengakses frmMain
    Public obj As Object
    Dim ds, ds8, dsedit, ds1, ds2, ds3, ds4, ds5, ds6, ds7, dss, dss1 As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Dim DA, daedit, da2, da3, da4, da5, da6, da7, sqlda, sqlda1, dapodm As SqlClient.SqlDataAdapter
    Dim Buildernya As New SqlClient.SqlCommandBuilder
    Dim rhandle As Int16
    Dim TemplatePur As String = "TemplatePur"
    Dim pr As String


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
    Public Sub add_click()
        LESupllier.Properties.ReadOnly = False
        LESupllier.Enabled = True
        CEPPN.Checked = False
        STATE = "ADD"
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()

    End Sub
    Public Sub cetak_click()

        'callReport(App_Path() & "\report\repPOJ.rpt", "", "no_po=" & Trim(txtNoPO.Text))
        callReport(App_Path() & "\report\repPOJ.rpt", "", "vnama_report=" & TemplatePur & " &no_po=" & txtNoPO.Text)

        'callReport(App_Path() & "\report\repPOJ.rpt", "", "&no_po=" & Trim(txtNoPO.Text) & " &vnama_report=" & TemplatePur, False, False)
        Dim x As Int16
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
    Private Sub Init_Bayar()
        If Not ds6.Tables("View_Valuta2") Is Nothing Then ds6.Tables("View_Valuta2").Clear()
        da6 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Id_Data ,Desc_Data from sif.dbo.SIF_Gen_Reff_D WHERE Id_Ref_File='LMBYR'", sqlconn))
        da6.Fill(ds6, "View_Valuta2")
        RentangBayar.Properties.DataSource = ds6.Tables("View_Valuta2")
        RentangBayar.Properties.DisplayMember = "Desc_Data"
        RentangBayar.Properties.ValueMember = "Id_Data"
    End Sub
    Public Sub edit_click()


        STATE = "EDIT"
        LESupllier.Properties.ReadOnly = True
        LESupllier.Enabled = False
        View_Valuta()
        If Not ds7.Tables("View_PR_D") Is Nothing Then ds7.Tables("View_PR_D").Clear()
        da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select DISTINCT PRD.no_pr, PRD.tgl_pr " & _
                                                                         "from PURC.dbo.PURC_PR_D PRD " & _
                                                                         "left join PURC.dbo.PURC_CHOICE_SUPP CSP on PRD.no_pr = CSP.no_pr and PRD.kd_stok=CSP.kd_stok " & _
                                                                         "left join PURC.dbo.PURC_PO PO on PRD.no_pr=PO.no_pr and CSP.kd_supp_pilih=PO.kd_supplier " & _
                                                                         "where PRD.jns_dpm='JASA' and CSP.no_csp is not NULL and not(PO.no_po is NULL) and CSP.rec_stat='APPROVE' " & _
                                                                           "order by PRD.tgl_pr", sqlconn))


        da7.Fill(ds7, "View_PR_D")
        LEPR.Properties.DataSource = ds7.Tables("View_PR_D")

        daedit = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_PO as [Nomor],tgl_PO as [Tanggal],no_pr as [no_pr],rec_stat  from PURC.dbo.PURC_PO where tipe_trans='JPP-KUT-02'", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dsedit.Tables("lookup_PO") Is Nothing Then dsedit.Tables("lookup_PO").Clear()
        daedit.Fill(dsedit, "lookup_PO")
        frmCari.set_dso(dsedit.Tables("lookup_PO")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            reload_table(frmCari.row(0))
            If frmCari.row.Item("rec_stat").ToString = "APPROVE" Then
                btnSave = False

                setStatus()
                Me.Enabled = True

                GV.OptionsBehavior.ReadOnly = False

                RentangBayar.Properties.ReadOnly = False
                CEPPN.Properties.ReadOnly = False
            ElseIf frmCari.row.Item("rec_stat").ToString <> "APPROVE" Then
                btnSave = True
                btnadd = False
                btnEdit = False
                btnDelete = True
                btnCancel = True
                btncetak = True

                setStatus()
                Me.Enabled = True

                GV.OptionsBehavior.ReadOnly = False

                RentangBayar.Properties.ReadOnly = False
                CEPPN.Properties.ReadOnly = False
            Else
                STATE = ""
                cancel_click()

            End If
        Else
            cancel_click()
        End If



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
    Public Sub cancel_click()

        reload_table("XXX")
        bersih()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
    End Sub
    Sub View_PR_D()
        'da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct no_pr from PURC.DBO.PURC_CHOICE_SUPP where status='APPROVE'", sqlconn))
        If Not ds7.Tables("View_PR_D") Is Nothing Then ds7.Tables("View_PR_D").Clear()


        da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select DISTINCT PRD.no_pr, PRD.tgl_pr " & _
                                                                    "from PURC.dbo.PURC_PR_D PRD " & _
                                                                    "left join PURC.dbo.PURC_CHOICE_SUPP CSP on PRD.no_pr = CSP.no_pr " & _
                                                                    "and PRD.kd_stok=CSP.kd_stok " & _
                                                                    "where not csp.kd_supp_pilih is null and PRD.jns_dpm='JASA' and CSP.rec_stat='APPROVE' " & _
                                                                    "and not EXISTS (select 1 from purc.dbo.purc_po a, purc.dbo.purc_po_d b " & _
                                                                    "where(a.no_po = b.no_po And PRD.no_pr = a.no_pr And PRD.kd_stok = b.kd_stok) " & _
                                                                    "and csp.kd_supp_pilih=a.kd_supplier)", sqlconn))


        da7.Fill(ds7, "View_PR_D")
        LEPR.Properties.DataSource = ds7.Tables("View_PR_D")
    End Sub
    Sub View_Valuta()
        If Not ds6.Tables("View_Valuta") Is Nothing Then ds6.Tables("View_Valuta").Clear()
        da6 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Valuta,Nama_Valuta from sif.dbo.SIF_valuta", sqlconn))
        da6.Fill(ds6, "View_Valuta")
        LEValuta.Properties.DataSource = ds6.Tables("View_Valuta")

    End Sub
    Private Sub V_Supplier()
        da5 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Supplier,Nama_Supplier from sif.dbo.SIF_Supplier", sqlconn))
        da5.Fill(ds5, "View_Supplier")
        LESupllier.Properties.DataSource = ds5.Tables("View_Supplier")
    End Sub

    Private Sub V_Supplier2() 'filter berdasarkan PR
        If Not ds5.Tables("View_Supplier") Is Nothing Then ds5.Tables("View_Supplier").Clear()
        LESupllier.EditValue = vbNullString
        da5 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct Kode_Supplier,Nama_Supplier from sif.dbo.SIF_Supplier s,PURC.DBO.PURC_CHOICE_SUPP csp  where kode_supplier=kd_supp_pilih and no_pr='" & LEPR.EditValue & "' and csp.rec_stat ='APPROVE'", sqlconn))
        da5.Fill(ds5, "View_Supplier")
        LESupllier.Properties.DataSource = ds5.Tables("View_Supplier")
    End Sub
    'Private Sub NO(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
    '    Dim i As Int16 = 1
    '    For Each rw As DataRow In sender.Rows
    '        rw("no_seq") = i
    '        i += 1
    '    Next
    'End Sub

    Private Sub bersih()
        LEPR.EditValue = vbNullString
        LESupllier.EditValue = vbNullString
        LEValuta.EditValue = vbNullString
        txtkurs.EditValue = vbNullString
        txtKeterangan.Text = ""
        txtTerm.Text = ""
        txtSubTotal.EditValue = vbNullString
        txtJmlDiskon1.EditValue = vbNullString
        txtJmlPPN.EditValue = vbNullString
        txtJmlTotal.EditValue = vbNullString
        txtNoRef.EditValue = vbNullString
        txtNoPO.EditValue = vbNullString
        txtstatus.EditValue = vbNullString
    End Sub
    Public Sub save_click(Optional ByRef isDelete As Boolean = False)


        Dim notrans As String
        Dim BTRANS As SqlTransaction

       
        If Not isDelete Then
            If LEPR.EditValue = "" Then
                showMessages("No PR Belum Diisi")
                LEPR.Focus()
                Exit Sub
            End If


            If RentangBayar.EditValue = "" Then
                showMessages("Lama Bayar Belum Dipilih")
                RentangBayar.Focus()
                Exit Sub
            End If

            If LEValuta.EditValue = "" Then
                showMessages("Valuta Belum Dipilih")
                LEValuta.Focus()
                Exit Sub
            End If


            






            If STATE = "ADD" Then

                row = ds3.Tables("PO").NewRow
                row.Item("Last_Create_Date") = getTanggal()

                'row.Item("no_po") = NomorPO(BTRANS)
                'txtNoPO.Text = row.Item("no_po")

                'row.Item("Last_Created_By") = username
            ElseIf STATE = "EDIT" Then
                row = ds3.Tables("PO").Rows(0)
                row.Item("Last_Update_Date") = getTanggal()

                row.Item("Last_Updated_By") = username
            End If


            If STATE = "ADD" Then

                If CEPPN.Checked = True Then
                    notrans = getNoTrans("PO-JP", getTanggal(BTRANS), BTRANS)
                Else
                    notrans = getNoTrans("PO-JNP", getTanggal(BTRANS), BTRANS)
                End If
                txtNoPO.Text = notrans
                row.Item("No_po") = txtNoPO.Text

            End If

            Dim jatuh_tempo As Date
            jatuh_tempo = DateAdd(DateInterval.Day, 30, dtTanggal.EditValue)
            row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
            'txtNoPO.Text = row.Item("no_po")
            row("sts_ctk_ulang") = "Y"
            row.Item("jml_cetak") = 0
            row.Item("tipe_trans") = "JPP-KUT-02"
            row.Item("tgl_po") = dtTanggal.EditValue
            row.Item("tgl_jth_tempo") = jatuh_tempo
            row.Item("no_pr") = LEPR.EditValue
            row.Item("no_ref") = txtNoRef.Text
            row.Item("kd_supplier") = LESupllier.EditValue
            row.Item("kd_valuta") = LEValuta.EditValue
            row.Item("kurs_valuta") = txtkurs.Text



            'row.Item("flag_diskon") = CheckEdit1.EditValue
            'row.Item("prosen_diskon") = txtJmlDiskon.Text
            'row.Item("jml_diskon") = txtJmlDiskon1.Text
            row.Item("flag_ppn") = CEPPN.EditValue
            row.Item("flag_tagih") = CheckEdit2.EditValue
            row.Item("jml_ppn") = txtJmlPPN.Text
            row.Item("tgl_bayar") = dtBayar.EditValue
            row.Item("lama_bayar") = RentangBayar.EditValue
            row.Item("term_bayar") = txtTerm.Text
            row.Item("keterangan") = txtKeterangan.Text
            row.Item("no_ref") = txtNoRef.Text
            row.Item("qty_total") = txtSubTotal.Text
            row.Item("jml_val_trans") = txtJmlTotal.EditValue
            row.Item("jml_rp_trans") = txtkurs.Text * txtJmlTotal.Text
            row.Item("rec_stat") = "ENTRY"
            txtstatus.Text = row.Item("rec_stat")
            row.Item("Program_Name") = Me.Name

            If STATE = "ADD" Then
                ds3.Tables("PO").Rows.Add(row)
            End If



            For Each rows As DataRow In ds4.Tables("POD").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("no_po") = txtNoPO.Text
                    rows.Item("Last_Create_Date") = getTanggal()

                    rows.Item("Last_Created_By") = username
                    rows.Item("kd_Cabang") = kdcabang
                    'rows.Item("rec_stat") = "ENTRY"
                    rows.Item("tipe_trans") = "JPP-KUT-02"
                Else
                    rows.Item("Last_Update_Date") = getTanggal()

                    rows.Item("Last_Updated_By") = username
                End If
                rows.Item("Program_name") = Me.Name

            Next

            For Each drows As DataRow In ds4.Tables("PODM").Rows
                drows.Item("no_po") = txtNoPO.Text
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

            Buildernya = New SqlClient.SqlCommandBuilder(dapodm)
            dapodm.UpdateCommand = Buildernya.GetUpdateCommand()
            dapodm.InsertCommand = Buildernya.GetInsertCommand()
            dapodm.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            da3.UpdateCommand.Transaction = BTRANS
            da3.InsertCommand.Transaction = BTRANS
            da3.DeleteCommand.Transaction = BTRANS

            da4.UpdateCommand.Transaction = BTRANS
            da4.InsertCommand.Transaction = BTRANS
            da4.DeleteCommand.Transaction = BTRANS

            dapodm.UpdateCommand.Transaction = BTRANS
            dapodm.InsertCommand.Transaction = BTRANS
            dapodm.DeleteCommand.Transaction = BTRANS



            da3.Update(ds3.Tables("PO"))
            da4.Update(ds4.Tables("POD"))
            dapodm.Update(ds4.Tables("PODM"))

            ds3.Tables("PO").AcceptChanges()
            ds4.Tables("POD").AcceptChanges()
            ds4.Tables("PODM").AcceptChanges()

            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Data tersimpan")
            cancel_click()

        Catch e As Exception
            BTRANS.Rollback()
            ds3.Tables("PO").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            ds4.Tables("POD").RejectChanges()
            ds4.Tables("PODM").RejectChanges()
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try



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
    Private Sub reload_table(ByVal kode As String)
        If Not ds3.Tables("PO") Is Nothing Then ds3.Tables("PO").Clear()
        If Not ds4.Tables("POD") Is Nothing Then ds4.Tables("POD").Clear()
        If Not ds4.Tables("PODM") Is Nothing Then ds4.Tables("PODM").Clear()


        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_PO where no_po='" & kode & "'", sqlconn))
        da3.Fill(ds3, "PO")

        da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * ,'' As No,'' as no_pr,'' as Nama_Barang ,qty*harga as total from PURC.dbo.PURC_PO_D where no_po= '" & kode & "'", sqlconn))
        da4.Fill(ds4, "POD")
        'GC.DataSource = ds4.Tables("POD")

        dapodm = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_PO_D_BARANG where no_po='" & kode & "'", sqlconn))
        dapodm.Fill(ds4, "PODM")
        'showMessages(ds4.Tables("PODM").Rows.Count.ToString)
        'showMessages(kode)
        'AddHandler ds4.Tables("POD").RowDeleted, AddressOf refreshNomer

        'JPP-KUT-02'
        If ds3.Tables("PO").Rows.Count > 0 Then
            
            Dim row As DataRow

            row = ds3.Tables("PO").Rows(0)

            If row("sts_ctk_ulang") = "T" Then
                btncetak = False

            Else
                btncetak = True


            End If
            setStatus()

            'If row("flag_tagih") = "T" Then
            '    btncetak = False
            '    setStatus()
            'ElseIf row("flag_tagih") = "Y" Then
            '    btncetak = True
            '    setStatus()

            'End If
            txtNoPO.Text = row.Item("no_po").ToString
            pr = row.Item("no_pr").ToString
            LEPR.EditValue = pr
            LEValuta.EditValue = row.Item("kd_valuta").ToString
            txtkurs.EditValue = row.Item("kurs_valuta").ToString
            txtNoRef.Text = row.Item("no_ref").ToString
            dtTanggal.Text = row.Item("tgl_po")

            txtKeterangan.Text = row.Item("keterangan").ToString
            dtBayar.Text = row.Item("tgl_bayar")
            RentangBayar.EditValue = CStr(row.Item("lama_bayar"))
            txtTerm.Text = row.Item("term_bayar").ToString
            LESupllier.EditValue = row.Item("kd_supplier").ToString
            txtstatus.Text = row.Item("rec_stat").ToString
            CEPPN.EditValue = row.Item("flag_ppn").ToString
            CheckEdit2.EditValue = row.Item("flag_tagih").ToString
            txtJmlPPN.EditValue = row.Item("jml_ppn").ToString
            'CheckEdit1.EditValue = row.Item("flag_diskon").ToString
            'txtJmlDiskon.Text = row.Item("prosen_diskon").ToString
            'txtJmlDiskon1.Text = row.Item("jml_diskon").ToString
            txtSubTotal.EditValue = row.Item("qty_total")
            txtJmlTotal.EditValue = row.Item("jml_val_trans")

        End If


    End Sub

    Private Sub frmPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtTanggal.DateTime = Date.Today



        dtBayar.DateTime = Date.Today
        connect()
        LEValuta.EditValue = "IDR"
        txtkurs.Text = "1"
        prn = getParent(Me)
        da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang, Nama_Barang  from sif.dbo.SIF_Barang where rec_stat = 'Y'", sqlconn))
        da2.Fill(ds, "VBarang")
        repBrg.DataSource = ds.Tables("VBARANG")

        Init_Bayar()

        View_Valuta()
        View_PR_D()
        'V_Supplier()

        da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_PO_D where 1=0", sqlconn))
        da4.Fill(ds4, "POD")
        dapodm = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_PO_D_BARANG where 1=0", sqlconn))
        dapodm.Fill(ds4, "PODM")

        Dim colM(0) As DataColumn
        Dim colD(0) As DataColumn
        Dim rel As DataRelation

        colM(0) = ds4.Tables("POD").Columns("kd_stok")

        colD(0) = ds4.Tables("PODM").Columns("kd_jasa")


        rel = ds4.Relations.Add("Detail", colM, colD, False)
        GC.LevelTree.Nodes.Add("Detail", GVDetail)

        If txtNoPO.Text = "" Then
            reload_table("xxx")
            GC.DataSource = ds4.Tables("POD")

        End If


    End Sub

    Public Sub cariPO(ByVal nocsp As String) ' ============= cretaed by yaya =============
        dss = New DataSet
        dss1 = New DataSet
        sqlda = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_PO where no_po='" & nocsp & "'", sqlconn))
        sqlda.Fill(dss, "_yaya")
        'MsgBox(dss.Tables(0).Rows(0).Item("no_po").ToString)
        If dss.Tables(0).Rows.Count Then
            txtNoPO.Text = dss.Tables(0).Rows(0).Item("no_po").ToString
            txtstatus.Text = dss.Tables(0).Rows(0).Item("rec_stat").ToString
            dtTanggal.Text = dss.Tables(0).Rows(0).Item("tgl_po").ToString
            LEPR.EditValue = dss.Tables(0).Rows(0).Item("no_pr").ToString
            LESupllier.EditValue = dss.Tables(0).Rows(0).Item("kd_supplier").ToString
            LEValuta.EditValue = dss.Tables(0).Rows(0).Item("kd_valuta").ToString
            txtKeterangan.Text = dss.Tables(0).Rows(0).Item("keterangan").ToString
            txtNoRef.Text = row.Item("no_ref").ToString

        End If
        sqlda1 = New SqlDataAdapter(New SqlCommand("select * from PURC.DBO.PURC_PO_D where no_po='" & txtNoPO.Text & "'", sqlconn))
        sqlda1.Fill(dss1, "_yaya_d")
        GC.DataSource = dss1.Tables("_yaya_d")

    End Sub




    Private Sub LEValuta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEValuta.EditValueChanged
        If LEValuta.EditValue = "IDR" Then
            txtkurs.Text = "1"
        Else
            txtkurs.Text = "0"

        End If
    End Sub

    Private Sub btSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        save_click()
    End Sub

    Private Sub LEPR_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEPR.EditValueChanged
        If STATE = "EDIT" Then
            Dim dr As SqlDataReader = New SqlCommand("select distinct S.Kode_Supplier from sif.dbo.SIF_Supplier S,PURC.DBO.PURC_PO P where S.kode_supplier=P.kd_suPPLIER and P.no_pr='" & LEPR.EditValue & "' and P.no_po='" & txtNoPO.EditValue & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                V_Supplier2()
                LESupllier.EditValue = dr(0)
            Else
                If Not ds5.Tables("View_Supplier") Is Nothing Then ds5.Tables("View_Supplier").Clear()
                LESupllier.EditValue = vbNullString
            End If

            dr.Close()
        End If
        If STATE = "ADD" Then
            Dim dr As SqlDataReader = New SqlCommand("select distinct c.kd_supp_pilih from PURC.dbo.PURC_CHOICE_SUPP c " & _
                                                 "where c.no_pr='" & LEPR.EditValue & "'" & _
                                                 "and  not EXISTS (select 1 from PURC.dbo.purc_po a, PURC.dbo.PURC_PO_D_BARANG b where a.no_po = b.no_po  " & _
                                                 "and a.no_pr ='' and kd_supplier=c.kd_supp_pilih and b.kd_stok=c.kd_stok)", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows = True Then
                V_Supplier2()
                LESupllier.EditValue = dr(0)
            Else
                If Not ds5.Tables("View_Supplier") Is Nothing Then ds5.Tables("View_Supplier").Clear()
                LESupllier.EditValue = vbNullString
            End If

            dr.Close()
        End If


    End Sub

    Private Sub LESupllier_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LESupllier.EditValueChanged
        If LESupllier.Text = "" Then
            If Not ds4.Tables("PODM") Is Nothing Then ds4.Tables("PODM").Clear()
            If Not ds4.Tables("POD") Is Nothing Then ds4.Tables("POD").Clear()
            Exit Sub
        End If
        If txtNoPO.Text = "" Then
            If Not ds4.Tables("PODM") Is Nothing Then ds4.Tables("PODM").Clear()
            If Not ds4.Tables("POD") Is Nothing Then ds4.Tables("POD").Clear()
            Dim dr As SqlDataReader = New SqlCommand(" select  distinct no_pr, kd_supp_pilih, kd_stok, kd_satuan   from PURC.dbo.vBarangSuplierTerpilih where kd_supp_pilih='" & LESupllier.EditValue & "' and no_pr='" & LEPR.EditValue & "' ", sqlconn).ExecuteReader
            Dim i As Int16 = 1
            While dr.Read

                Dim rw As DataRow = ds4.Tables("POD").NewRow
                rw.Item("no_pr") = dr.Item("no_pr")
                rw.Item("kd_stok") = dr.Item("kd_stok")
                'rw.Item("Nama_Barang") = dr.Item("Nama_Barang")
                rw.Item("kd_satuan") = dr.Item("kd_satuan")
                rw.Item("harga") = 0 'dr.Item("harga_baru")
                rw.Item("qty") = 1 'dr.Item("qty")
                rw.Item("prosen_diskon") = 0 ' dr.Item("prosen_diskon")
                rw.Item("jml_diskon") = 0 'dr.Item("jml_diskon")
                rw.Item("total") = 0 'dr.Item("total")
                rw.Item("tgl_kirim") = Now.AddDays(7)

                rw("no_seq") = i
                i += 1


                ds4.Tables("POD").Rows.Add(rw)

                Dim x As Int16 = 1
                Dim drstok As SqlDataReader = New SqlCommand(" select distinct kd_stok, kd_substok,Kd_Satuan2, harga_baru,qty_stok,flagbonus  from PURC.dbo.vBarangSuplierTerpilih where kd_supp_pilih='" & LESupllier.EditValue & "' and no_pr='" & LEPR.EditValue & "' and kd_stok='" & dr.Item("kd_stok") & "' ", sqlconn).ExecuteReader
                While drstok.Read

                    Dim rwstok As DataRow = ds4.Tables("PODM").NewRow
                    'rwstok.Item("no_pr") = dr.Item("no_pr")
                    rwstok.Item("kd_jasa") = drstok.Item("kd_stok")
                    rwstok.Item("kd_stok") = drstok.Item("kd_substok")
                    rwstok.Item("tgl_kirim") = Now.Date
                    'rwstok.Item("Nama_Barang") = dr.Item("Nama_Barang2")
                    rwstok.Item("kd_satuan") = drstok.Item("Kd_Satuan2")
                    rwstok.Item("harga") = drstok.Item("harga_baru")
                    rwstok.Item("qty") = drstok.Item("qty_stok")
                    rwstok.Item("prosen_diskon") = 0
                    rwstok.Item("jml_diskon") = 0
                    rwstok.Item("flagbonus") = drstok.Item("flagbonus")
                    rwstok.Item("total") = drstok.Item("harga_baru") * drstok.Item("qty_stok")
                    rwstok("no_seq") = x
                    x += 1
                    ds4.Tables("PODM").Rows.Add(rwstok)
                    rw.Item("total") = rw.Item("total") + rwstok.Item("total")
                End While
                drstok.Close()


            End While
            dr.Close()


            txtSubTotal.EditValue = getTotal()
            hitung_total()
        End If
    End Sub

    Private Sub CEPPN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEPPN.CheckedChanged
        If txtSubTotal.Text = "" Or txtSubTotal.Text = "0" Then
            MsgBox("Sub Total Masih Kosong,Silahkan Lakukan Transaksi ", MsgBoxStyle.Information, "Perhatian")
            Exit Sub
        Else
            hitung_total()
        End If

    End Sub
    Function getTotal() As Double
        Dim ttl As Double

        For Each rw As DataRow In ds4.Tables("POD").Rows
            If TypeOf rw.Item("qty") Is DBNull Or rw.Item("qty") = 0 Then
                MsgBox("QTY Masih Kosong, Harap diisi", MsgBoxStyle.Information)
                rw.Item("qty") = 0
                Exit Function
            Else
                ttl += rw("total")
            End If

        Next
        Return ttl
    End Function
    Function getTotal2() As Double
        Dim ttl As Double

        For Each rw As DataRow In ds4.Tables("PODM").Rows
            If TypeOf rw.Item("qty") Is DBNull Or rw.Item("qty") = 0 Then
                MsgBox("QTY Masih Kosong, Harap diisi", MsgBoxStyle.Information)
                rw.Item("qty") = 0
                Exit Function
            Else
                ttl += rw("total")
            End If

        Next
        Return ttl
    End Function

    Sub hitung_total()
        'txtSubTotal.EditValue = getTotal()
        If CEPPN.Checked = True Then
            CEPPN.Text = "PPN"
            txtJmlPPN.EditValue = (txtSubTotal.EditValue - txtJmlDiskon1.EditValue) * (10 / 100)
        Else
            CEPPN.Text = "NON PPN"
            txtJmlPPN.EditValue = 0
        End If

        txtJmlTotal.EditValue = Val((txtSubTotal.EditValue - Val(txtJmlDiskon1.EditValue))) + Val(txtJmlPPN.EditValue)
    End Sub
    'Private Sub refreshNomer(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
    '    Dim i As Int16 = 1
    '    Dim j As Int16 = 1
    '    If State = "DELETE" Then Exit Sub
    '    For Each rw As DataRow In sender.Rows
    '        If rw.RowState <> DataRowState.Deleted Then
    '            For Each rwd As DataRow In ds4.Tables("POD").Select("NO=" & rw.Item("no_seq"))

    '                rwd("NO") = i
    '                rwd("no_seq") = i & "." & j
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



    Private Sub txtJmlDiskon_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJmlDiskon1.KeyPress
        If e.KeyChar = Chr(13) Then
            txtJmlDiskon1.EditValue = txtSubTotal.EditValue - txtJmlDiskon1.EditValue
            hitung_total()
        End If
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data PO ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            STATE = "DELETE"
            If Not ds3.Tables("PO") Is Nothing Then delete(ds3.Tables("PO").Rows)
            If Not ds4.Tables("POD") Is Nothing Then delete(ds4.Tables("POD").Rows)


            save_click(True)
            cancel_click()
            STATE = ""
        End If
    End Sub
    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub


    Private Sub txtJmlDiskon_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJmlDiskon1.EditValueChanged
        'hitung_total()
    End Sub

    Private Sub txtSubTotal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubTotal.EditValueChanged
        hitung_total()
    End Sub

    Private Sub GC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            If GV.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Record Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar DPM") = MsgBoxResult.Yes Then
                    GV.DeleteSelectedRows()
                End If
            End If
        End If
    End Sub

  

    Private Sub txtJmlDiskon_KeyPress_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJmlDiskon.KeyPress
        If e.KeyChar = Chr(13) Then
            txtJmlDiskon1.EditValue = txtSubTotal.EditValue * (txtJmlDiskon.EditValue / 100)
            hitung_total()
        End If

    End Sub

    Private Sub GV_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        If e.Column Is kd_stok Then
            Dim rw As DataRow
            rw = ds.Tables("VBARANG").Select("Kode_Barang='" & e.Value & "'")(0)
            GV.GetRow(e.RowHandle).item("kd_satuan") = rw("Kd_Satuan")
        End If
        Dim hasilX, hasilY As Integer
        If e.Column Is prosen_diskon Then
            GV.GetRow(e.RowHandle).item("jml_diskon") = 0
            '    hasilX = GV.GetRow(e.RowHandle).item("harga").ToString * GV.GetRow(e.RowHandle).item("qty").ToString
            hasilX = getTotal2()
            GV.GetRow(e.RowHandle).item("jml_diskon") = hasilX.ToString * (GV.GetRow(e.RowHandle).item("prosen_diskon") / 100).ToString
            GV.GetRow(e.RowHandle).item("total") = hasilX.ToString - GV.GetRow(e.RowHandle).item("jml_diskon").ToString
            txtSubTotal.EditValue = getTotal()
        End If

        If e.Column Is jml_diskon Then
            GV.GetRow(e.RowHandle).item("prosen_diskon") = 0
            hasilY = GV.GetRow(e.RowHandle).item("harga").ToString * GV.GetRow(e.RowHandle).item("qty").ToString
            GV.GetRow(e.RowHandle).item("total") = hasilY.ToString - GV.GetRow(e.RowHandle).item("jml_diskon").ToString
            txtSubTotal.EditValue = getTotal()
        End If
    End Sub

  

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.GetRow(e.RowHandle).item("no_seq") = GV.RowCount + 1
    End Sub

    Private Sub GV_MasterRowGetLevelDefaultView(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs) Handles GV.MasterRowGetLevelDefaultView
        rhandle = e.RowHandle
    End Sub

    Private Sub GV_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV.RowUpdated
        txtSubTotal.EditValue = getTotal()
    End Sub

   

    Private Sub GV_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        'Dim isValid As Boolean = True
        'If e.Row.item("tgl_kirim").ToString = "" Then
        '    isValid = False
        '    GV.SetColumnError(tglkirim, "Tanggal kirim harap diisi Terlebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        'End If

        'e.Valid = isValid
    End Sub

    Private Sub GVDetail_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GVDetail.CellValueChanged
        Dim x, fview As Object
        fview = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        x = CType(GV.GetDetailView(rhandle, 0), DevExpress.XtraGrid.Views.Base.BaseView)
        If e.Column.Name = "dtotal" Then
            showMessages(GV.GetDetailView(rhandle, 0).RowCount.ToString)

        ElseIf e.Column.Name = "dprosen_diskon" Then
            x.GetRow(e.RowHandle).item("jml_diskon") = 0
            x.GetRow(e.RowHandle).item("jml_diskon") = (x.GetRow(e.RowHandle).item("harga") * x.GetRow(e.RowHandle).item("qty") * e.Value) / 100
            x.GetRow(e.RowHandle).item("total") = (x.GetRow(e.RowHandle).item("harga") * x.GetRow(e.RowHandle).item("qty")) - x.GetRow(e.RowHandle).item("jml_diskon")
            Dim crow As Integer = GV.GetDetailView(rhandle, 0).RowCount
            Dim subtotal As Decimal = 0
            For i As Integer = 0 To crow - 1
                subtotal = subtotal + x.GetRowCellValue(i, "total")
            Next
            GV.GetRow(rhandle).item("total") = subtotal
            txtSubTotal.EditValue = getTotal()
        ElseIf e.Column.Name = "djml_diskon" Then
            x.GetRow(e.RowHandle).item("prosen_diskon") = 0
            x.GetRow(e.RowHandle).item("total") = (x.GetRow(e.RowHandle).item("harga") * x.GetRow(e.RowHandle).item("qty")) - e.Value
            Dim crow As Integer = GV.GetDetailView(rhandle, 0).RowCount
            Dim subtotal As Decimal = 0
            For i As Integer = 0 To crow - 1
                subtotal = subtotal + x.GetRowCellValue(i, "total")
            Next
            GV.GetRow(rhandle).item("total") = subtotal
            txtSubTotal.EditValue = getTotal()

        End If

        If e.Column.Name = "flagbonus" Then
            'If IIf(GV.GetRow(e.RowHandle).item("flagbonus") = "T", GV.GetRow(e.RowHandle).item("flagbonus") = "T", GV.GetRow(e.RowHandle).item("flagbonus") = "Y") Then
            'MessageBox.Show(x.GetRow(e.RowHandle).item("flagbonus"))
            '    MessageBox.Show(RCHBNS.ValueChecked)
            If x.GetRow(e.RowHandle).item("flagbonus") = "Y" Then
                x.GetRow(e.RowHandle).item("harga") = 0
                x.GetRow(e.RowHandle).item("keterangan") = "Bonus"
                x.GetRow(e.RowHandle).item("total") = 0

                GV.GetRow(0).item("total") = getTotal2()
                txtSubTotal.EditValue = getTotal()
               

            ElseIf x.GetRow(e.RowHandle).item("flagbonus") = "T" Then
                If Not ds7.Tables("harga") Is Nothing Then ds7.Tables("harga").Clear()
                da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select harga_baru,kd_substok  from PURC.dbo.vBarangSuplierTerpilih where kd_supp_pilih='" & LESupllier.EditValue & "' and no_pr='" & LEPR.EditValue & "' and kd_stok='" & GV.GetRow(0).item("kd_stok") & "' ", sqlconn))
                da7.Fill(ds7, "harga")




                If ds7.Tables("harga").Rows.Count > 0 Then
                    For i As Integer = 0 To ds7.Tables("harga").Rows.Count - 1


                        If x.GetRow(e.RowHandle).item("kd_stok") = ds7.Tables("harga").Rows(i).Item("kd_substok") Then

                            x.GetRow(e.RowHandle).item("harga") = ds7.Tables("harga").Rows(i).Item("harga_baru")
                            'GVDetail.SetRowCellValue(e.RowHandle, "harga", ds7.Tables("harga").Rows(i).Item("harga_baru"))
                            x.GetRow(e.RowHandle).item("total") = (x.GetRow(e.RowHandle).item("harga") * x.GetRow(e.RowHandle).item("qty"))
                            x.GetRow(e.RowHandle).item("keterangan") = ""
                          
                            GV.GetRow(0).item("total") = getTotal2()
                            txtSubTotal.EditValue = getTotal()

                        End If
                    Next
                End If
               
               


                

            End If
            'End If
        End If
        

    End Sub

    Private Sub RentangBayar_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RentangBayar.EditValueChanged
        If Not RentangBayar.EditValue = "0" Then
            dtBayar.DateTime = dtBayar.DateTime.AddDays(RentangBayar.EditValue * 7)
        Else
            dtBayar.EditValue = dtTanggal.EditValue
        End If
    End Sub

    Private Sub GVDetail_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GVDetail.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    
    Private Sub GVDetail_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GVDetail.ValidateRow
        Dim isvalid As Boolean = True
        If e.Row.item("prosen_diskon").ToString <> "" Then
            If e.Row.item("prosen_diskon") < 0 Or e.Row.item("prosen_diskon") > 100 Then
                isvalid = False
                sender.SetColumnError(dprosen_diskon, "Input Data Diskon Salah", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If
        If e.Row.item("jml_diskon").ToString <> "" Then
            If e.Row.item("jml_diskon") < 0 Or e.Row.item("jml_diskon") > e.Row.item("harga") Then
                isvalid = False
                sender.SetColumnError(djml_diskon, "Input Data Diskon Salah", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If
        'If e.Row.item("tgl_kirim").ToString <> "" Then
        '    If TypeOf e.Row.item("tgl_kirim") Is DBNull Or e.Row.item("tgl_kirim") = "" Then
        '        isvalid = False
        '        sender.SetColumnError(GridColumn11, "Silahkan Isi Tanggal Kedatangan", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        '    End If
        'End If
        e.Valid = isvalid
    End Sub
End Class