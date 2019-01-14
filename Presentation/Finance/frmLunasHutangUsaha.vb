Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid
Public Class frmLunasHutangUsaha
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





    Public Sub cetak_click()
        callReport(App_Path() & "\report\rptPOJ.rpt", "", "Nomor=" & Trim(txtNomor.Text))
    End Sub

    Public Sub edit_click()

        STATE = "EDIT"
        ' bila menggunakan form cari
        dsedit = New DataSet
        da3 = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_BELI_LUNAS ", sqlconn)) '<- query buat ditampilkan di LOV
        da3.Fill(dsedit, "LookJurnal")
        frmCari.set_dso(dsedit.Tables("LookJurnal"))
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then
            kode = frmCari.row("no_trans").ToString
            cabang = frmCari.row("Kd_Cabang").ToString
            da3 = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_BELI_LUNAS where no_trans  = '" & kode & "'", sqlconn)) '<- query buat ditampilkan di LOV
            da3.Fill(dsedit, "POcari")
            da4 = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_BELI_LUNAS_D where no_trans = '" & kode & "'", sqlconn))
            da4.Fill(dsedit, "PODcari") '<-- memasukan hasil query da ke dalam dso dengan nama table SIF_WILAYAH(nama table bisa diisi sembarang)
            GC.DataSource = dsedit.Tables("PODcari")
            'AddHandler ds4.Tables("PODcari").RowDeleted, AddressOf refreshNomer
            'If dSO.Tables("SIF_AREA").Rows.Count > 0 Then
            txtNomor.Text = kode
            'dtpTanggal.Value = frmCari.row("Tanggal Transaksi").ToString

            txtNoRef.Text = frmCari.row("no_ref1").ToString
            LEValuta.EditValue = frmCari.row("kd_valuta").ToString
            txtkurs.EditValue = frmCari.row("kurs_valuta").ToString
            dtTanggal.EditValue = frmCari.row("tgl_trans").ToString
            txtKeterangan.Text = frmCari.row("keterangan").ToString
            lookcust.EditValue = frmCari.row("kd_kartu").ToString
            txtSubTotal.EditValue = frmCari.row("jml_val_trans").ToString
            lookbayar.EditValue = frmCari.row("jns_bayar").ToString
            Lookgiro.EditValue = frmCari.row("kd_giro").ToString
            'cbStatus.EditValue = IIf(frmCari.row("Rec_Stat").ToString = "Y", "AKTIF", "TIDAK AKTIF")
            'Else
            '    MsgBox("Data tidak diketemukan")
            'End If
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



    Sub View_Valuta()
        da6 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Valuta,Nama_Valuta from sif.dbo.SIF_valuta", sqlconn))
        da6.Fill(ds6, "View_Valuta")
        LEValuta.Properties.DataSource = ds6.Tables("View_Valuta")
    End Sub

    Private Sub v_nota()
        da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_PEMBELIAN where kd_supplier='" & lookcust.EditValue & "' and kd_valuta='" & LEValuta.EditValue & "' and tipe_trans ='JPP-KUT-01' and jml_akhir>0 ", sqlconn))
        da2.Fill(ds2, "vnota")
        repBrg.DataSource = ds2.Tables("vnota")
        'no_inv, tgl_inv, jml_val_trans, jml_val_ppn, jml_val_trans+jml_val_ppn as jml_tagihan, tgl_jth_tempo
    End Sub

    Private Sub V_Supplier()
        da5 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  Kode_Supplier, Nama_Supplier, Alamat1 from sif.dbo.SIF_supplier", sqlconn))
        da5.Fill(ds5, "View_Supplier")
        lookcust.Properties.DataSource = ds5.Tables("View_Supplier")
        
    End Sub

    Private Sub V_pembayaran()
        da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Gen_Reff_D where Id_Ref_File='JNSBYRPJ' ", sqlconn))
        da7.Fill(ds7, "View_bayar")
        lookbayar.Properties.DataSource = ds7.Tables("View_bayar")
    End Sub

    Private Sub V_giro()
        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nomor, keterangan,tgl_jth_tempo, jml_trans from FIN.dbo.FIN_GIRO where kartu='" & lookcust.EditValue & "' and jns_giro='" & lookbayar.EditValue & "' and kd_valuta='" & LEValuta.EditValue & "' and jns_trans='BELI' ", sqlconn))
        da1.Fill(ds1, "View_giro")
        Lookgiro.Properties.DataSource = ds1.Tables("View_giro")
    End Sub

    Private Sub NO(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        For Each rw As DataRow In sender.Rows
            rw("no_seq") = i
            i += 1
        Next
    End Sub

    Private Sub bersih()
        lookcust.EditValue = vbNullString
        lookbayar.EditValue = vbNullString
        Lookgiro.EditValue = vbNullString
        LEValuta.EditValue = vbNullString
        txtkurs.EditValue = vbNullString
        txtKeterangan.Text = ""
        txtNoRef.Text = ""
        txtSubTotal.EditValue = vbNullString
        txtNomor.EditValue = vbNullString
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)

        'Dim BTRANS As SqlTransaction
        'Dim BTRANS1 As SqlTransaction
        If dtTanggal.EditValue = "" Then
            showMessages("Tanggal Belum Diisi")
            dtTanggal.Focus()
            Exit Sub
        End If

        If lookcust.EditValue = "" Then
            showMessages("Kartu Belum Diisi")
            lookcust.Focus()
            Exit Sub
        End If


        If LEValuta.EditValue = "" Then
            showMessages("Valuta Belum Dipilih")
            LEValuta.Focus()
            Exit Sub
        End If

        If Not isDelete Then


            If STATE = "ADD" Then
                da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_BELI_LUNAS where no_trans = '" & kode & "' ", sqlconn))
                da3.Fill(ds3, "PO")

                da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_BELI_LUNAS_D where no_trans= '" & kode & "'", sqlconn))
                da4.Fill(ds4, "POD")
                GC.DataSource = ds4.Tables("POD")
                row = ds3.Tables("PO").NewRow
                row.Item("no_trans") = getNoTrans("JKK", getTanggal)
                tampung = row.Item("no_trans")
                row.Item("Last_Create_Date") = Now
                row.Item("Last_Created_By") = username
                'Dim jatuh_tempo As Date
                'jatuh_tempo = DateAdd(DateInterval.Day, 30, dtTanggal.EditValue)
                row.Item("Kd_cabang") = getKodeCabang()
                cabang = row.Item("Kd_cabang")
                row.Item("tipe_trans") = "JKK-KUT-01"
                row.Item("tgl_trans") = dtTanggal.EditValue
                row.Item("no_ref1") = txtNoRef.Text
                row.Item("kd_kartu") = lookcust.EditValue
                row.Item("kd_valuta") = LEValuta.EditValue
                row.Item("keterangan") = txtKeterangan.Text
                row.Item("kurs_valuta") = txtkurs.Text
                row.Item("jml_rp_trans") = GV.Columns("jml_bayar").SummaryText 'txtSubTotal.EditValue
                row.Item("jml_val_trans") = GV.Columns("jml_bayar").SummaryText * txtkurs.Text
                row.Item("jns_bayar") = lookbayar.EditValue
                row.Item("kd_giro") = Lookgiro.EditValue
                row.Item("Program_Name") = Me.Name
                row.Item("thnbln") = dtTanggal.DateTime.Year & Microsoft.VisualBasic.Right("0" & dtTanggal.DateTime.Month, 2)
                ds3.Tables("PO").Rows.Add(row)
            ElseIf STATE = "EDIT" Then
                'da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_BELI_LUNAS where no_trans = '" & kode & "' ", sqlconn))
                'da3.Fill(dsedit, "POcari")

                'da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_BELI_LUNAS_D where no_trans= '" & kode & "'", sqlconn))
                'da4.Fill(dsedit, "PODcari")
                'GC.DataSource = dsedit.Tables("PODcari")
                row = dsedit.Tables("POcari").Rows(0)
                row.Item("Kd_Cabang") = cabang
                row.Item("tipe_trans") = "JKK-KUT-01"
                row.Item("tgl_trans") = dtTanggal.EditValue
                'Dim jatuh_tempo As Date
                row.Item("no_ref1") = txtNoRef.Text
                row.Item("kd_kartu") = lookcust.EditValue
                row.Item("keterangan") = txtKeterangan.Text
                row.Item("kd_valuta") = LEValuta.EditValue
                row.Item("kurs_valuta") = txtkurs.Text
                row.Item("jml_rp_trans") = GV.Columns("jml_bayar").SummaryText
                row.Item("jml_val_trans") = GV.Columns("jml_bayar").SummaryText * txtkurs.Text
                row.Item("jns_bayar") = lookbayar.EditValue
                row.Item("kd_giro") = Lookgiro.EditValue
                row.Item("thnbln") = dtTanggal.DateTime.Year & Microsoft.VisualBasic.Right("0" & dtTanggal.DateTime.Month, 2)
                row.Item("Program_Name") = Me.Name
                row.Item("Last_Update_Date") = Now
                row.Item("Last_Updated_By") = username
            End If

        End If
        'row.Item("Last_Create_Date") = Now
        'row.Item("Last_Created_By") = username


        If STATE = "ADD" Then

            For Each rows As DataRow In ds4.Tables("POD").Rows
                If rows.RowState = DataRowState.Added Then
                    'rows.Item("no_po") = row.Item("no_po")

                    rows.Item("Last_Create_Date") = Now
                    rows.Item("Last_Created_By") = username

                    rows.Item("Kd_Cabang") = cabang
                    rows.Item("tipe_trans") = "JKK-KUT-01"
                    rows.Item("no_trans") = tampung
                    rows.Item("Last_Update_Date") = Now
                    rows.Item("Last_Updated_By") = username
                    rows.Item("Programe_name") = Me.Name
                    rows.Item("kd_kartu") = lookcust.EditValue
                    'rows.Item("status") = "ENTRY"
                ElseIf rows.RowState = DataRowState.Modified Then
                    rows.Item("no_trans") = tampung
                    rows.Item("Last_Update_Date") = Now
                    rows.Item("Last_Updated_By") = username


                End If

            Next



        ElseIf STATE = "EDIT" Then

            For Each rows As DataRow In dsedit.Tables("PODcari").Rows
                If rows.RowState = DataRowState.Added Then
                    'rows.Item("no_po") = row.Item("no_po")
                    row.Item("Kd_cabang") = cabang
                    rows.Item("Last_Create_Date") = Now
                    rows.Item("Last_Created_By") = username
                    rows.Item("tipe_trans") = "JKK-KUT-01"
                    rows.Item("no_trans") = kode
                    rows.Item("Last_Update_Date") = Now
                    rows.Item("Last_Updated_By") = username
                    rows.Item("Programe_name") = Me.Name
                    rows.Item("kd_kartu") = lookcust.EditValue
                    'rows.Item("status") = "ENTRY"
                ElseIf rows.RowState = DataRowState.Modified Then
                    rows.Item("no_trans") = kode
                    rows.Item("Last_Update_Date") = Now
                    rows.Item("Last_Updated_By") = username

                End If

            Next

        End If


        If STATE = "ADD" Then
            Try

                Buildernya = New SqlClient.SqlCommandBuilder(da3)
                'da3.UpdateCommand = Buildernya.GetUpdateCommand()
                da3.InsertCommand = Buildernya.GetInsertCommand()
                'da3.DeleteCommand = Buildernya.GetDeleteCommand()

                Buildernya1 = New SqlClient.SqlCommandBuilder(da4)
                'da4.UpdateCommand = Buildernya1.GetUpdateCommand()
                da4.InsertCommand = Buildernya1.GetInsertCommand()
                'da4.DeleteCommand = Buildernya1.GetDeleteCommand()

                'BTRANS = sqlconn.BeginTransaction("1")
                'da3.UpdateCommand.Transaction = BTRANS
                'da3.InsertCommand.Transaction = BTRANS
                'da3.DeleteCommand.Transaction = BTRANS

                'BTRANS1 = sqlconn.BeginTransaction("1")
                'da4.UpdateCommand.Transaction = BTRANS1
                'da4.InsertCommand.Transaction = BTRANS1
                'da4.DeleteCommand.Transaction = BTRANS1

                'If STATE = "ADD" Then
                '    'If CEPPN.Checked = True Then
                '    row.Item("no_trans") = getNoTrans("JKM", getTanggal(BTRANS), BTRANS)
                '    'Else
                '    '    row.Item("No_po") = getNoTrans("PO-JNP", getTanggal(BTRANS), BTRANS)
                '    'End If
                '    txtNomor.Text = row.Item("no_trans")
                '    For Each rows As DataRow In ds4.Tables("POD").Rows
                '        If rows.RowState = DataRowState.Added Then
                '            rows.Item("no_trans") = row.Item("no_trans")
                '        End If
                '    Next
                'End If

                da3.Update(ds3.Tables("PO"))
                da4.Update(ds4.Tables("POD"))

                ds3.Tables("PO").AcceptChanges()
                ds4.Tables("POD").AcceptChanges()
                STATE = "EDIT"
                'BTRANS.Commit()
                'BTRANS1.Commit()
                showMessages("Berhasil disimpan..")

                txtNomor.Text = row.Item("no_trans")

            Catch e As Exception

                ds3.Tables("PO").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                ds4.Tables("POD").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

            End Try
        ElseIf STATE = "EDIT" Then



            For Each rows As DataRow In dsedit.Tables("PODcari").Rows
                If rows.RowState = DataRowState.Added Then
                    'rows.Item("no_po") = row.Item("no_po")
                    rows.Item("Kd_Cabang") = cabang
                    rows.Item("Last_Create_Date") = Now
                    rows.Item("Last_Created_By") = username
                    rows.Item("tipe_trans") = "JKM-KUT-01"
                    rows.Item("no_trans") = kode
                    rows.Item("Last_Update_Date") = Now
                    rows.Item("Last_Updated_By") = username
                    rows.Item("Programe_name") = Me.Name
                    rows.Item("kd_kartu") = lookcust.EditValue
                    'rows.Item("status") = "ENTRY"
                ElseIf rows.RowState = DataRowState.Modified Then
                    rows.Item("no_trans") = kode
                    rows.Item("Last_Update_Date") = Now
                    rows.Item("Last_Updated_By") = username

                End If

            Next

            Try

                'If Not dsedit.Tables("PODcari") Is Nothing Then ds4.Tables("PODcari").Clear()
                Buildernya = New SqlClient.SqlCommandBuilder(da3)
                da3.UpdateCommand = Buildernya.GetUpdateCommand()
                da3.InsertCommand = Buildernya.GetInsertCommand()
                da3.DeleteCommand = Buildernya.GetDeleteCommand()

                Buildernya1 = New SqlClient.SqlCommandBuilder(da4)
                da4.UpdateCommand = Buildernya1.GetUpdateCommand()
                da4.InsertCommand = Buildernya1.GetInsertCommand()
                da4.DeleteCommand = Buildernya1.GetDeleteCommand()

                'BTRANS = sqlconn.BeginTransaction("1")
                'da3.UpdateCommand.Transaction = BTRANS
                'da3.InsertCommand.Transaction = BTRANS
                'da3.DeleteCommand.Transaction = BTRANS

                'BTRANS1 = sqlconn.BeginTransaction("1")
                'da4.UpdateCommand.Transaction = BTRANS1
                'da4.InsertCommand.Transaction = BTRANS1
                'da4.DeleteCommand.Transaction = BTRANS1

                'If STATE = "ADD" Then
                '    'If CEPPN.Checked = True Then
                '    row.Item("no_trans") = getNoTrans("JKM", getTanggal(BTRANS), BTRANS)
                '    'Else
                '    '    row.Item("No_po") = getNoTrans("PO-JNP", getTanggal(BTRANS), BTRANS)
                '    'End If
                '    txtNomor.Text = row.Item("no_trans")
                '    For Each rows As DataRow In ds4.Tables("POD").Rows
                '        If rows.RowState = DataRowState.Added Then
                '            rows.Item("no_trans") = row.Item("no_trans")
                '        End If
                '    Next
                'End If

                da3.Update(dsedit.Tables("POcari"))
                da4.Update(dsedit.Tables("PODcari"))

                'da4.Update(dsedit.Tables("PODcari"))
                'da4 = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS_D ", sqlconn))
                'DA.Fill(dsedit, "PODcari")

                dsedit.Tables("POcari").AcceptChanges()
                dsedit.Tables("PODcari").AcceptChanges()
                'dsedit.Clear()

                'da4.Update(dsedit.Tables("PODcari"))
                'da4 = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_BELI_LUNAS_D ", sqlconn))
                'da4.Fill(dsedit, "PODcari")
                'GC.DataSource = dsedit.Tables("PODcari")
                'GV.RefreshData()




                STATE = "EDIT"                'BTRANS.Commit()
                'BTRANS1.Commit()
                showMessages("Berhasil diedit..")

                'txtNomor.Text = row.Item("no_trans")


            Catch e As Exception

                dsedit.Tables("POcari").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                dsedit.Tables("PODcari").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

            End Try
        ElseIf STATE = "DELETE" Then
            Try
                Buildernya = New SqlClient.SqlCommandBuilder(da3)
                da3.UpdateCommand = Buildernya.GetUpdateCommand()
                da3.InsertCommand = Buildernya.GetInsertCommand()
                da3.DeleteCommand = Buildernya.GetDeleteCommand()

                Buildernya1 = New SqlClient.SqlCommandBuilder(da4)
                da4.UpdateCommand = Buildernya1.GetUpdateCommand()
                da4.InsertCommand = Buildernya1.GetInsertCommand()
                da4.DeleteCommand = Buildernya1.GetDeleteCommand()

                'BTRANS = sqlconn.BeginTransaction("1")
                'da3.UpdateCommand.Transaction = BTRANS
                'da3.InsertCommand.Transaction = BTRANS
                'da3.DeleteCommand.Transaction = BTRANS

                'BTRANS1 = sqlconn.BeginTransaction("1")
                'da4.UpdateCommand.Transaction = BTRANS1
                'da4.InsertCommand.Transaction = BTRANS1
                'da4.DeleteCommand.Transaction = BTRANS1

                'If STATE = "ADD" Then
                '    'If CEPPN.Checked = True Then
                '    row.Item("no_trans") = getNoTrans("JKM", getTanggal(BTRANS), BTRANS)
                '    'Else
                '    '    row.Item("No_po") = getNoTrans("PO-JNP", getTanggal(BTRANS), BTRANS)
                '    'End If
                '    txtNomor.Text = row.Item("no_trans")
                '    For Each rows As DataRow In ds4.Tables("POD").Rows
                '        If rows.RowState = DataRowState.Added Then
                '            rows.Item("no_trans") = row.Item("no_trans")
                '        End If
                '    Next
                'End If

                da3.Update(dsedit.Tables("POcari"))
                da4.Update(dsedit.Tables("PODcari"))

                dsedit.Tables("POcari").AcceptChanges()
                dsedit.Tables("PODcari").AcceptChanges()
                bersih()


                'BTRANS.Commit()
                'BTRANS1.Commit()
                showMessages("Berhasil dihapus..")


            Catch e As Exception

                dsedit.Tables("POcari").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                dsedit.Tables("PODcari").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

            End Try
        End If

    End Sub

    Private Sub reload_table(ByVal kode As String)


        If Not ds3.Tables("PO") Is Nothing Then ds3.Tables("PO").Clear()
        If Not ds4.Tables("POD") Is Nothing Then ds4.Tables("POD").Clear()


        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_BELI_LUNAS where no_trans = '" & kode & "' ", sqlconn))
        da3.Fill(ds3, "PO")

        da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_BELI_LUNAS_D where no_trans= '" & kode & "'", sqlconn))
        da4.Fill(ds4, "POD")
        GC.DataSource = ds4.Tables("POD")
        'AddHandler ds4.Tables("PODcari").RowDeleted, AddressOf refreshNomer

        If ds3.Tables("PO").Rows.Count > 0 Then
            Dim row As DataRow

            row = ds3.Tables("PO").Rows(0)
            txtNomor.Text = row.Item("no_trans").ToString
            txtNoRef.Text = row.Item("no_ref1").ToString
            LEValuta.EditValue = row.Item("kd_valuta").ToString
            txtkurs.EditValue = row.Item("kurs_valuta").ToString

            dtTanggal.EditValue = row.Item("tgl_trans").ToString
            txtKeterangan.Text = row.Item("keterangan").ToString
            lookcust.EditValue = row.Item("Kode_Supplier").ToString
            'txtSubTotal.EditValue = row.Item("jml_val_trans")

        End If
        'If Not ds9.Tables("PO") Is Nothing Then ds3.Tables("PO").Clear()

        'DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN_NOTA_LUNAS where no_trans='" & kode & "'", sqlconn))
        'DA.Fill(ds3, "PO")



        'If ds3.Tables("PO").Rows.Count > 0 Then
        '    Dim row As DataRow

        '    row = ds3.Tables("SIF_Jabatan").Rows(0)
        '    txtNomor.Text = row.Item("no_trans").ToString
        '    txtNoRef.Text = row.Item("no_ref1").ToString
        '    LEValuta.EditValue = row.Item("kd_valuta").ToString
        '    txtkurs.EditValue = row.Item("kurs_valuta").ToString

        '    dtTanggal.EditValue = row.Item("tgl_trans").ToString
        '    txtKeterangan.Text = row.Item("keterangan").ToString
        '    lookcust.EditValue = row.Item("kd_supplier").ToString
        '    'txtSubTotal.EditValue = row.Item("jml_val_trans")
        'End If

    End Sub

    Private Sub frmLunasHutangUsaha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtTanggal.Text = Date.Today
        connect()
        prn = getParent(Me)
        LEValuta.EditValue = "IDR"
        txtkurs.Text = "1"
        da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_NOTA_LUNAS_D where no_trans= '" & kode & "'", sqlconn))
        da4.Fill(dsedit, "PODcari")
        'GC.DataSource = ds4.Tables("POD")
        'prn = getParent(Me)

        View_Valuta()
        V_Supplier()
        V_pembayaran()
        V_giro()

        If txtNomor.Text = "" Then
            reload_table("xxx")

            'GC.DataSource = ds4.Tables("POD")
        End If

    End Sub

    'Public Sub cariPO(ByVal nocsp As String) ' ============= cretaed by yaya =============
    '    dss = New DataSet
    '    dss1 = New DataSet
    '    sqlda = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_PO where no_po='" & nocsp & "'", sqlconn))
    '    sqlda.Fill(dss, "_yaya")
    '    'MsgBox(dss.Tables(0).Rows(0).Item("no_po").ToString)
    '    If dss.Tables(0).Rows.Count Then
    '        txtNoPO.Text = dss.Tables(0).Rows(0).Item("no_po").ToString
    '        txtstatus.Text = dss.Tables(0).Rows(0).Item("status").ToString
    '        dtTanggal.Text = dss.Tables(0).Rows(0).Item("tgl_po").ToString
    '        LEPR.EditValue = dss.Tables(0).Rows(0).Item("no_pr").ToString
    '        LESupllier.EditValue = dss.Tables(0).Rows(0).Item("kd_supplier").ToString
    '        LEValuta.EditValue = dss.Tables(0).Rows(0).Item("kd_valuta").ToString
    '        txtKeterangan.Text = dss.Tables(0).Rows(0).Item("keterangan").ToString

    '    End If
    '    sqlda1 = New SqlDataAdapter(New SqlCommand("select * from PURC.DBO.PURC_PO_D where no_po='" & txtNoPO.Text & "'", sqlconn))
    '    sqlda1.Fill(dss1, "_yaya_d")
    '    GC.DataSource = dss1.Tables("_yaya_d")

    'End Sub

    Private Sub LEValuta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEValuta.EditValueChanged
        If LEValuta.EditValue = "IDR" Then
            txtkurs.Text = "1"
        Else
            txtkurs.Text = ""
            txtkurs.Focus()
        End If
        lookbayar.EditValue = System.DBNull.Value
        Lookgiro.EditValue = System.DBNull.Value
        v_nota()
    End Sub

    Private Sub btSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSimpan.Click
        save_click()
    End Sub

    'Private Sub LEPR_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEPR.EditValueChanged
    '    Dim dr As SqlDataReader = New SqlCommand("select distinct Kode_Supplier from sif.dbo.SIF_Supplier,PURC.DBO.PURC_CHOICE_SUPP  where kode_supplier=kd_supp_pilih and no_pr='" & LEPR.EditValue & "'", sqlconn).ExecuteReader
    '    If dr.Read() Then
    '        lookcust.EditValue = dr(0)
    '    Else
    '        lookcust.EditValue = vbNullString
    '    End If

    '    dr.Close()

    'End Sub


    'Private Sub CEPPN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEPPN.CheckedChanged
    '    If txtSubTotal.Text = "" Or txtSubTotal.Text = "0" Then
    '        MsgBox("Sub Total Masih Kosong,Silahkan Lakukan Transaksi ", MsgBoxStyle.Information, "Perhatian")
    '        Exit Sub
    '    Else
    '        hitung_total()
    '    End If

    'End Sub

    Function getTotal() As Double
        Dim ttl As Double
        For Each rw As DataRow In ds4.Tables("POD").Rows
            If TypeOf rw.Item("jml_bayar") Is DBNull Or rw.Item("jml_bayar") = 0 Then
                MsgBox("Nota/Invoice Masih Kosong, Harap diisi", MsgBoxStyle.Information)
                rw.Item("jml_bayar") = 0
                Exit Function
            Else
                ttl += rw("jml_piut") + rw("jml_ppn") + rw("pendp_lain") - rw("biaya_lain")

            End If

        Next

        Return ttl

    End Function
    Function getTotaledit() As Double
        Dim ttl As Double
        If Not ds3.Tables("PO") Is Nothing Then ds3.Tables("PO").Clear()
        If Not ds4.Tables("POD") Is Nothing Then ds4.Tables("POD").Clear()

        For Each rw As DataRow In dsedit.Tables("PODcari").Rows
            rw.BeginEdit()
            If TypeOf rw.Item("jml_bayar") Is DBNull Or rw.Item("jml_bayar") = 0 Then
                MsgBox("Nota/Invoice Masih Kosong, Harap diisi", MsgBoxStyle.Information)
                rw.Item("jml_bayar") = 0
                Exit Function
            Else
                ttl += rw("jml_piut") + rw("jml_ppn") + rw("pendp_lain") - rw("biaya_lain")

            End If
            rw.EndEdit()
        Next

        Return ttl

    End Function

    Sub hitung_total()
        txtSubTotal.EditValue = getTotal()
    End Sub
    Sub hitung_total1()
        txtSubTotal.EditValue = getTotaledit()
    End Sub

    Private Sub refreshNomer(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        Dim j As Int16 = 1
        If State = "DELETE" Then Exit Sub
        For Each rw As DataRow In sender.Rows
            If rw.RowState <> DataRowState.Deleted Then
                For Each rwd As DataRow In ds4.Tables("POD").Select("NO=" & rw.Item("no_seq"))
                    rwd("NO") = i
                    rwd("no_seq") = i & "." & j
                    j += 1
                Next
                j = 1
                rw("no_seq") = i
                i += 1
            End If
        Next
    End Sub

    'Private Sub txtkurs_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkurs.Leave
    '    If LEValuta.EditValue <> "Rupiah" Then
    '        MsgBox("Kurs harus diisi !", MsgBoxStyle.Critical, "Perhatian")
    '        txtkurs.Focus()
    '    End If
    'End Sub

    'Private Sub txtJmlDiskon_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJmlDiskon.KeyPress
    '    If e.KeyChar = Chr(13) Then
    '        ' txtSubTotal.EditValue = txtSubTotal.EditValue - txtJmlDiskon.EditValue
    '        'CEPPN.Focus()
    '        'If txtJmlDiskon.Then Then
    '        '    txtJmlDiskon.Text = 0
    '        'End If
    '        hitung_total()
    '    End If
    'End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data PO ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            STATE = "DELETE"
            If Not dsedit.Tables("POcari") Is Nothing Then
                For Each rw As DataRow In dsedit.Tables("POcari").Rows
                    rw.Delete()
                Next
            End If
            If Not dsedit.Tables("PODcari") Is Nothing Then
                For Each rw As DataRow In dsedit.Tables("PODcari").Rows
                    rw.Delete()
                Next
            End If
            save_click(True)
            STATE = ""
        End If
    End Sub
    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub

    Private Sub txtSubTotal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubTotal.EditValueChanged
      
    End Sub

    Private Sub GV_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
      
        a = 0
        b = 0
        Dim view As ColumnView = sender

        If STATE = "ADD" Then
            da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_PEMBELIAN where no_inv='" & GV.GetRow(e.RowHandle).item("prev_no_inv") & "'", sqlconn))
            da2.Fill(ds2, "vnotaload1")
            'da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_NOTA where kd_cust='" & lookcust.EditValue & "' and kd_valuta='" & LEValuta.EditValue & "' and tipe_trans in ('JPJ-KPT-01','JPJ-KPT-02') and jml_akhir>0 ", sqlconn))
            'da2.Fill(ds2, "vnotaload")
            'repBrg.DataSource = ds2.Tables("vnotaload")
            If e.Column Is prev_no_inv Then

                view.SetRowCellValue(e.RowHandle, view.Columns("jml_piut"), ds2.Tables("vnotaload1").Rows(0).Item("jml_val_trans"))
                view.SetRowCellValue(e.RowHandle, view.Columns("jml_ppn"), ds2.Tables("vnotaload1").Rows(0).Item("jml_val_ppn"))
                view.SetRowCellValue(e.RowHandle, view.Columns("jml_bayar"), ds2.Tables("vnotaload1").Rows(0).Item("jml_val_trans") + ds2.Tables("vnotaload1").Rows(0).Item("jml_val_ppn"))
                view.SetRowCellValue(e.RowHandle, view.Columns("pendp_lain"), "0")
                view.SetRowCellValue(e.RowHandle, view.Columns("biaya_lain"), "0")
            End If
            If e.Column Is pendp_lain Then
                If Not GV.GetRow(e.RowHandle).item("pendp_lain").Equals(vbNull) Then
                    view.SetRowCellValue(e.RowHandle, view.Columns("jml_bayar"), ds2.Tables("vnotaload1").Rows(0).Item("jml_val_trans") + ds2.Tables("vnotaload1").Rows(0).Item("jml_val_ppn") + GV.GetRow(e.RowHandle).item("pendp_lain"))
                End If
            End If
            If e.Column Is biaya_lain Then
                If Not GV.GetRow(e.RowHandle).item("biaya_lain").Equals(vbNull) Then
                    view.SetRowCellValue(e.RowHandle, view.Columns("jml_bayar"), (ds2.Tables("vnotaload1").Rows(0).Item("jml_val_trans") + ds2.Tables("vnotaload1").Rows(0).Item("jml_val_ppn") + GV.GetRow(e.RowHandle).item("pendp_lain")) - GV.GetRow(e.RowHandle).item("biaya_lain"))
                End If
            End If

        Else
            da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_PEMBELIAN where no_inv='" & GV.GetRow(e.RowHandle).item("prev_no_inv") & "'", sqlconn))
            da2.Fill(ds2, "vnotaload")
            'da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_NOTA where kd_cust='" & lookcust.EditValue & "' and kd_valuta='" & LEValuta.EditValue & "' and tipe_trans in ('JPJ-KPT-01','JPJ-KPT-02') and jml_akhir>0 ", sqlconn))
            'da2.Fill(ds2, "vnotaload")
            'repBrg.DataSource = ds2.Tables("vnotaload")
            If e.Column Is prev_no_inv Then

                view.SetRowCellValue(e.RowHandle, view.Columns("jml_piut"), ds2.Tables("vnotaload").Rows(0).Item("jml_val_trans"))
                view.SetRowCellValue(e.RowHandle, view.Columns("jml_ppn"), ds2.Tables("vnotaload").Rows(0).Item("jml_val_ppn"))
                view.SetRowCellValue(e.RowHandle, view.Columns("jml_bayar"), ds2.Tables("vnotaload").Rows(0).Item("jml_val_trans") + ds2.Tables("vnotaload").Rows(0).Item("jml_val_ppn"))
                view.SetRowCellValue(e.RowHandle, view.Columns("pendp_lain"), "0")
                view.SetRowCellValue(e.RowHandle, view.Columns("biaya_lain"), "0")
            End If
            If e.Column Is pendp_lain Then
                If Not GV.GetRow(e.RowHandle).item("pendp_lain").Equals(vbNull) Then
                    view.SetRowCellValue(e.RowHandle, view.Columns("jml_bayar"), ds2.Tables("vnotaload").Rows(0).Item("jml_val_trans") + ds2.Tables("vnotaload").Rows(0).Item("jml_val_ppn") + GV.GetRow(e.RowHandle).item("pendp_lain"))
                End If
            End If
            If e.Column Is biaya_lain Then
                If Not GV.GetRow(e.RowHandle).item("biaya_lain").Equals(vbNull) Then
                    view.SetRowCellValue(e.RowHandle, view.Columns("jml_bayar"), (ds2.Tables("vnotaload").Rows(0).Item("jml_val_trans") + ds2.Tables("vnotaload").Rows(0).Item("jml_val_ppn") + GV.GetRow(e.RowHandle).item("pendp_lain")) - GV.GetRow(e.RowHandle).item("biaya_lain"))
                End If
            End If

            'v_nota()
            'rw = ds2.Tables("vnota").Select("no_inv= '" & e.Value & "'")(0)
            ''GV.GetRow(e.RowHandle).item("prev_no_inv ") = repBrg.ValueMember

            'GV.GetRow(e.RowHandle).item("pendp_lain") = 0
            'GV.GetRow(e.RowHandle).item("biaya_lain") = 0
            'GV.GetRow(e.RowHandle).item("jml_piut") = rw("jml_val_trans")
            'GV.GetRow(e.RowHandle).item("jml_ppn") = rw("jml_val_ppn")


            'GV.GetRow(e.RowHandle).item("jml_bayar") = GV.GetRow(e.RowHandle).item("jml_piut") + GV.GetRow(e.RowHandle).item("jml_ppn") + GV.GetRow(e.RowHandle).item("pendp_lain") - GV.GetRow(e.RowHandle).item("biaya_lain")


        End If

    End Sub

   


    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        'GV.GetRow(e.RowHandle).item("no_seq") = GV.RowCount + 1
        Dim View As ColumnView = sender
        View.SetRowCellValue(e.RowHandle, View.Columns("no_seq"), GV.RowCount + 1)
        'If STATE = "EDIT" Then

        '    rw = ds2.Tables("vnota").Select("no_inv= '" & e.Value & "'")(0)



        '    GV.GetRow(e.RowHandle).item("jml_piut") = rw("jml_val_trans")
        '    GV.GetRow(e.RowHandle).item("jml_ppn") = rw("jml_val_ppn")
        '    GV.GetRow(e.RowHandle).item("pendp_lain") = 0
        '    GV.GetRow(e.RowHandle).item("biaya_lain") = 0
        '    a = GV.GetRow(e.RowHandle).item("pendp_lain")
        '    b = GV.GetRow(e.RowHandle).item("biaya_lain")
        '    GV.GetRow(e.RowHandle).item("jml_bayar") = rw("jml_val_trans") + rw("jml_val_ppn") + a - b

        'End If
    End Sub

    Private Sub GV_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV.RowUpdated

        '    If STATE = "ADD" Then

        '        hitung_total()
        '    ElseIf STATE = "EDIT" Then



        '    ElseIf STATE = "DELETE" Then
        '        hitung_total1()

        '    End If

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
    'Private Sub LESupllier_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookcust.EditValueChanged
    '    If lookcust.Text = "" Then
    '        If Not ds4.Tables("POD") Is Nothing Then ds4.Tables("POD").Clear()
    '        Exit Sub
    '    End If
    '    If txtNomor.Text = "" Then
    '        ds4.Tables("POD").Clear()
    '        Dim dr As SqlDataReader = New SqlCommand(" select *,'' as no_pr  from PURC.dbo.vBarangSuplierTerpilih where kd_supp_pilih='" & 111 & "' and no_pr='" & 111 & "' ", sqlconn).ExecuteReader
    '        Dim i As Int16 = 1
    '        While dr.Read
    '            Dim rw As DataRow = ds4.Tables("POD").NewRow
    '            rw.Item("no_pr") = dr.Item("no_pr")
    '            rw.Item("kd_stok") = dr.Item("kd_stok")
    '            rw.Item("Nama_Barang") = dr.Item("Nama_Barang")
    '            rw.Item("kd_satuan") = dr.Item("kd_satuan")
    '            rw.Item("harga") = dr.Item("harga_baru")
    '            rw.Item("qty") = 0
    '            rw.Item("no_seq") = i
    '            i += 1
    '            ds4.Tables("POD").Rows.Add(rw)
    '        End While
    '        dr.Close()
    '    End If
    'End Sub
    Private Sub lookcust_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookcust.EditValueChanged
        lookbayar.EditValue = System.DBNull.Value
        Lookgiro.EditValue = System.DBNull.Value
        v_nota()
        'V_pembayaran()
        'V_giro()
    End Sub


    Private Sub lookbayar_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookbayar.EditValueChanged
        Lookgiro.EditValue = System.DBNull.Value
        ds1.Clear()
        V_giro()
    End Sub


    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        save_click()
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        edit_click()
    End Sub

    Private Sub cmdadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdadd.Click
        add_click()
    End Sub

End Class