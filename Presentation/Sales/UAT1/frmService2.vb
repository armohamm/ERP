Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmService2
    Dim dsete, dsete2 As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA As SqlDataAdapter
    Dim DAD As SqlDataAdapter
    Dim DAS, DAB, DAM As SqlDataAdapter
    Dim obj As Object
    Dim prn As frmMain
    Public noso As String = ""
    Public tipetransx As String = ""
    Public statusService As String = ""
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Dim myBuilder As New SqlCommandBuilder
    Public no_sp As String = "XXX"
    Public tipe_transaksi As String = "XXX"
    Public tipe_trans As String
    Dim rl, r2 As DataRelation
    Dim clone As DataView
    Dim kd_jns_brg As String
    Dim rhandel As Int16
    Dim ONLOAD_STATE As Boolean = False
    Dim dvCustomer As New DataView
    Dim status_service As String

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = True
        End With
    End Sub
    Public Sub add_click()
        State = "ADD"
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
        lblStatus.Text = "[New]"
    End Sub
    Public Sub cancel_click()
        reloadTable("XXX", "XXX")
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
        txtCustomer.EditValue = vbNullString
        tglKirim.EditValue = vbNullString
        tglSO.Text = Now
        txtAlamatKirim.Text = ""
        txtKeterangan.Text = ""
        txtNamaPnrm.Text = ""
        txtNomor.Text = ""
        lblStatus.Text = "[IDLE]"
    End Sub
    Public Sub delete_click()
        If MsgBox("Batalkan Transaksi Service ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            Dim i As Int16
            i = New SqlCommand("update sales.sif.so set status ='CANCEL' and isClosed='Y' where status='OK' and isnull(isPrinted,'')='' ", sqlconn).ExecuteNonQuery
            cancel_click()
            State = ""
            If i > 0 Then
                showMessages("Service Telah Dibatalkan")
            Else
                showMessages("Service Tidak Bisa Dibatalkan")
            End If
        End If
    End Sub
    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub
    Private Sub reloadTable(ByVal kode As String, ByVal tipe_trans As String)
        If Not dsete.Tables("DSERVICE") Is Nothing Then dsete.Tables("DSERVICE").Clear()
        If Not dsete.Tables("SOM") Is Nothing Then dsete.Tables("SOM").Clear()
        If Not dsete.Tables("SOD") Is Nothing Then dsete.Tables("SOD").Clear()
        If Not dsete.Tables("SO") Is Nothing Then dsete.Tables("SO").Clear()
        If Not dsete.Tables("SOB") Is Nothing Then dsete.Tables("SOB").Clear()

        ONLOAD_STATE = True
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from Sales.dbo.SALES_SO where no_sp='" & kode & "' and tipe_trans='" & tipe_trans & "'", sqlconn))
        DA.Fill(dsete, "SO")
        DAD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, 1 as NO, case when 1=0 then 0 else isnull(BIAYA_SERVICE,0) end as biaya_lama from Sales.dbo.SALES_SO_D where no_sp='" & kode & "' and tipe_trans='" & tipe_trans & "' order by No_seq", sqlconn))
        DAD.Fill(dsete, "SOD")
        DAS = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from Sales.dbo.SALES_PRODUK_SERVICE where Nomor_SO='" & kode & "'", sqlconn))
        DAS.Fill(dsete, "DSERVICE")
        DAB = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from Sales.dbo.SALES_SO_BIAYA where No_sp='" & kode & "' and tipe_trans='" & tipe_trans & "'", sqlconn))
        DAB.Fill(dsete, "SOB")
        DAM = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from Sales.dbo.SALES_BOM_SERVICE where No_sp='" & kode & "'", sqlconn))
        DAM.Fill(dsete, "SOM")

        If dsete.Tables("SO").Rows.Count > 0 Then
            Dim row As DataRow

            row = dsete.Tables("SO").Rows(0)
            txtNomor.Text = row.Item("No_sp").ToString
            tglSO.Text = row.Item("Tgl_sp").ToString
            DT_TglSO.EditValue = row.Item("Tgl_sp")
            txtCustomer.EditValue = row.Item("Kd_Customer").ToString
            txtNamaPnrm.Text = row.Item("Nama_pnrm").ToString
            txtAlamatKirim.Text = row.Item("Almt_pnrm").ToString
            tglKirim.EditValue = row.Item("Tgl_Kirim")
            txtKeterangan.Text = row.Item("Keterangan").ToString
            txtNomor.Text = row.Item("No_sp").ToString
            cmbJenisSP.Text = row("Jenis_sp").ToString
            txtBiaya.EditValue = row("Biaya").ToString
            If Not row.Item("Alamat_Tarik") Is Nothing Then txtAlamatTarik.Text = row.Item("Alamat_Tarik").ToString
            lblTotal.EditValue = row("JML_RP_TRANS")
            txtTelp.Text = row("No_Telp").ToString
            txtSales.EditValue = row("Kd_sales").ToString
            JamKirim.EditValue = row("JamKirim").ToString
            tglLahir.EditValue = row.Item("tgl_lahir_umum").ToString
            Tgl_Masuk.EditValue = row.Item("TGL_BARANG_MASUK").ToString
            txtKota.EditValue = row.Item("KOTA").ToString
            Dim dr As SqlDataReader = New SqlCommand("select * from prod.dbo.prod_rcn_prod_d where no_sp='" & txtNomor.Text & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                lblStatus.Text = " On Production Planing"
            End If
            dr.Close()

            dr = New SqlCommand("select * from prod.dbo.PROD_rcn_krm_d where no_sp='" & txtNomor.Text & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                lblStatus.Text = " On Delivery Planing"
            End If
            dr.Close()

            dr = New SqlCommand("select * from sales.dbo.sales_sj where no_sp='" & txtNomor.Text & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                lblStatus.Text = " On Delivery"
            End If
            dr.Close()
            btnCancel = True

            btnDelete = False
            'If row("isPrinted").ToString <> "" Then btnSave = False
            setStatus()
            For Each item As DataRow In dsete.Tables("SOD").Select("Status='BATAL'")
                item.Item("biaya") = 0
            Next
        Else
            txtCustomer.EditValue = vbNullString
            txtNomor.Text = vbNullString
            tglKirim.EditValue = vbNullString
            txtNamaPnrm.Text = vbNullString
            tglSO.Text = vbNullString
            Tgl_Masuk.Text = vbNullString
            txtKeterangan.Text = vbNullString
            txtBiaya.EditValue = 0
            lblTotal.EditValue = 0
            txtAlamatTarik.Text = vbNullString
            txtTelp.Text = vbNullString
            txtAlamatKirim.Text = vbNullString
            JamKirim.EditValue = vbNullString
            cmbJenisSP.Text = "UMUM"
            txtSales.EditValue = vbNullString
            tglLahir.EditValue = vbNullString
            txtKota.EditValue = vbNullString
        End If
        ONLOAD_STATE = False
    End Sub
    Private Sub frmSO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        tipetrans = IIf(kddep = KD_DIV_SPRING, ServiceSpringUmum, ServiceSponUmum)
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer, Kd_Customer, Alamat1 from SIF.dbo.SIF_Customer where rec_stat='Y'", sqlconn))
        dadbe.Fill(dsete, "CUSTOMER")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Kain, Merk_Kain + ' ' + isnull(Warna,'')  as Kain from SIF.dbo.SIF_Kain where rec_stat='Y'", sqlconn))
        dadbe.Fill(dsete, "KAIN")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select b.Kd_Satuan, b.Nama_Barang, b.Kode_Barang, b.kd_merk  from SIF.dbo.SIF_Barang as b where b.kd_jns_persd in ('1','2') and  b.Rec_Stat='Y' and Kd_Depart='" & kddep & "' order  by Nama_Barang", sqlconn))
        dadbe.Fill(dsete, "VBARANG")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select b.Kd_Satuan, b.Nama_Barang, b.Kode_Barang  from SIF.dbo.SIF_Barang as b where b.kd_jns_persd not in ('1','2') and  b.Rec_Stat='Y' and Kd_Depart='" & kddep & "' order  by Nama_Barang", sqlconn))
        dadbe.Fill(dsete, "VBARANG2")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Merk, Kode_Tipe, Nama_Tipe from SIF.dbo.SIF_TIPE where rec_stat='Y' union select '', '', 'IDEM' ", sqlconn))
        dadbe.Fill(dsete, "TIPE")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select id_data as kd_biaya, Desc_Data as deskripsi from sif.dbo.sif_gen_reff_d where ref_role='SOD' and id_ref_file='BIAYA' and id_ref_data='BIAYA' ", sqlconn))
        dadbe.Fill(dsete, "BIAYA")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Id_Data, Desc_Data, Val_kode1, Val_kode2 from [SIF].[dbo].[SIF_Gen_Reff_D] where [Id_Ref_File]='JNSSRVSH'  and [Id_Ref_Data] = 'JNSSRVSH' ", sqlconn))
        dadbe.Fill(dsete, "JNSSRVSH")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_service, nama_service from [SIF].[dbo].SIF_bom_service where rec_stat='Y' ", sqlconn))
        dadbe.Fill(dsete, "Bom_Service")

        reloadTable(no_sp, tipe_transaksi)
        AddHandler dsete.Tables("SOD").RowDeleted, AddressOf refreshNomer
        rl = dsete.Relations.Add("Service", dsete.Tables("SOD").Columns("no_seq"), dsete.Tables("DSERVICE").Columns("sp_seq"), True)
        rl = dsete.Relations.Add("Bom", dsete.Tables("SOD").Columns("no_seq"), dsete.Tables("SOM").Columns("NO_SEQ_SP"), True)

        txtCustomer.Properties.DataSource = dsete.Tables("CUSTOMER")
        txtCustomer.Properties.DisplayMember = "Nama_Customer"
        txtCustomer.Properties.ValueMember = "Kd_Customer"

        repBom.DataSource = dsete.Tables("Bom_Service")
        repKdKain.DataSource = dsete.Tables("KAIN")
        repbarang.DataSource = dsete.Tables("VBARANG")
        repJNSSRVSH.DataSource = dsete.Tables("JNSSRVSH")
        repkain.DataSource = dsete.Tables("TIPE")
        repBarang2.DataSource = dsete.Tables("VBARANG2")

        GC.DataSource = dsete.Tables("SOD")
        GC.LevelTree.Nodes.Add("Service", gvd)
        GC.LevelTree.Nodes.Add("Bom", gvm)
        GC_Biaya.DataSource = dsete.Tables("SOB")

        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Sales, Kode_Sales from SIF.dbo.SIF_Sales where rec_stat='Y'", sqlconn))
        dadbe.Fill(dsete, "SALES")
        txtSales.Properties.DataSource = dsete.Tables("SALES")
        txtSales.Properties.DisplayMember = "Nama_Sales"
        txtSales.Properties.ValueMember = "Kode_Sales"

        tglSO.Text = getTanggal()
        repBiaya.DataSource = dsete.Tables("BIAYA")
        prn = frmMain
        tipe_trans = "SPV"
    End Sub
    Public Sub edit_click()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_sp as [Nomor], tgl_sp as [Tanggal], tipe_trans, case Nama_Customer when 'UMUM' then Nama_pnrm else Nama_Customer end as [Customer / Toko], no_telp [Telp], sales.dbo.status_inspeksi(No_sp) as [Status Service], isnull(isPrinted,'T') Cetak,sales.dbo.status_konfirmasi(No_sp) as [Status Confirmasi], Last_Created_By Owner  from sales.dbo.VSO_REP where tipe_trans = ('" & IIf(kddep = KD_DIV_SPRING, ServiceSpringUmum, ServiceSponUmum) & "') and isnull(isclosed,'X') <> 'Y' AND status = 'OK'", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dsete.Tables("lookup_so") Is Nothing Then dsete.Tables("lookup_so").Clear()
        dadbe.Fill(dsete, "lookup_so")
        frmCari.set_dso(dsete.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.GV.Columns(2).Visible = False
        frmCari.GV.Columns(6).Visible = False
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            btnadd = False
            btnEdit = False
            btnDelete = True
            btnSave = True

            reloadTable(frmCari.row(0), frmCari.row(2))
            GV.Focus()
            GV.ExpandAllGroups()
            status_service = frmCari.row(5)
            State = "EDIT"
            lblStatus.Text = "[EDIT]"
            setStatus()
            Me.Enabled = btnSave

        Else
            cancel_click()
            State = ""
        End If
    End Sub
    Private Sub txtCustomer_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomer.EditValueChanged
        txtKodeCustomer.Text = txtCustomer.EditValue
        If sender.editvalue <> vbNullString Then
            txtAlamatKirim.Text = txtCustomer.Properties.GetDataSourceValue("Alamat1", txtCustomer.ItemIndex).ToString()
        Else
            txtAlamatKirim.Text = ""
        End If
    End Sub
    Public Sub cetak_click()
        If State = "EDIT" Then
            Try
                Dim j, k As Int16
                prn.btnCetak.Enabled = False
                With (New SqlCommand("select count(1) from SALES.dbo.sales_so_d dd where dd.no_sp= '" & txtNomor.Text & "'", sqlconn).ExecuteReader)
                    .Read()
                    j = .Item(0)
                    .Close()
                End With
                With (New SqlCommand("select count(distinct sp_seq) from sales.dbo.sales_produk_service ss where ss.nomor_so='" & txtNomor.Text & "'", sqlconn).ExecuteReader)
                    .Read()
                    k = .Item(0)
                    .Close()
                End With
                If j = k Then
                    Dim i As Int16 = New SqlCommand("update sales.dbo.sales_so set cetakke= isnull(CetakKe,0)+1, isPrinted='Y' where no_sp='" & txtNomor.Text & "'", sqlconn).ExecuteNonQuery
                    'If i > 0 Then
                    showMessages("Printing...", , "LOADING")
                    If kddep = KD_DIV_SPRING Then
                        callReport(App_Path() & "\report\vSoV.rpt", "", "PSO=" & txtNomor.Text, True, True, "DIM")
                    Else
                        callReport(App_Path() & "\report\vSoVSpon.rpt", "", "PSO=" & txtNomor.Text, True, True, "DIM")
                    End If

                    frmMessage.Hide()
                    btnSave = False
                    btnDelete = False
                    setStatus()

                    'Else
                    'MsgBox("Dokumen SP Service Sudah Pernah Dicetak ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Perhatian")
                    'End If
                Else
                MsgBox("Dokumen SP Service Belum Selesai di Inspeksi", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Perhatian")
                End If
                prn.btnCetak.Enabled = True
            Catch e As Exception
                MsgBox("Gagal Cetak " & e.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Printing")
                prn.btnCetak.Enabled = True
            End Try
        End If
    End Sub
    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim row As DataRow
        Dim BTRANS As SqlTransaction
        Dim iserror As Boolean = False
        If Not isDelete Then
            If txtCustomer.EditValue = "" Then
                DXEP.SetError(txtKodeCustomer, "Nama Customer Belum Diisi")
                txtCustomer.Focus()
                iserror = True
            End If
            If tglKirim.Text = "" Then
                showMessages("Tanggal Kirim Belum Diisi", , "WARNING")
                tglKirim.Focus()
                Exit Sub
            End If
            If tglLahir.Text = "" And txtCustomer.Text = "UMUM" Then
                showMessages("Tanggal Lahir Belum Diisi", , "WARNING")
                tglLahir.Focus()
                Exit Sub
            End If
            If txtKota.Text = "" And txtCustomer.Text = "UMUM" Then
                showMessages("Kota Belum Diisi", , "WARNING")
                txtKota.Focus()
                Exit Sub
            End If
            If GV.RowCount = 0 Then
                showMessages("Daftar Barang Masih Kosong", , "WARNING")
                GV.Focus()
                Exit Sub
            End If
        End If

        If State = "EDIT" Then
            If status_service = "Proses Inspeksi" Then
                MsgBox("Inspeksi Belum Selesai", MsgBoxStyle.Exclamation, "Peringatan")
                Exit Sub
            End If
            For Each rows As DataRow In dsete.Tables("SOB").Rows
                If rows.Item("Terima_Rekomendasi") Is Nothing Then
                    MsgBox("Ada Kolom Terima Rekomendasi Yang Belum Diisi", MsgBoxStyle.Exclamation, "Peringatan")
                    Exit Sub
                End If
            Next
        End If
        If Not isDelete Then
            If State = "ADD" Then
                row = dsete.Tables("SO").NewRow
                row.Item("Last_Create_Date") = getTanggal()
                row.Item("Last_Created_By") = username

            ElseIf State = "EDIT" Then
                row = dsete.Tables("SO").Rows(0)
                row.Item("Last_Update_Date") = getTanggal()
                row.Item("Last_Updated_By") = username
            End If
            row.Item("Kd_Cabang") = kdcabang
            row.Item("Tipe_trans") = IIf(kddep = KD_DIV_SPRING, ServiceSpringUmum, ServiceSponUmum)
            'row.Item("Tgl_sp") = getTanggal()
            If txtNamaSales.Text <> "" Then row.Item("Kd_sales") = txtSales.EditValue
            row.Item("Tgl_sp") = tglSO.Text
            row.Item("Kd_Customer") = txtCustomer.EditValue
            row.Item("Atas_Nama") = IIf(txtCustomer.EditValue <> "UMUM", txtCustomer.Text, txtNamaPnrm.Text)
            row.Item("Nama_pnrm") = txtNamaPnrm.Text
            row.Item("Almt_pnrm") = txtAlamatKirim.Text
            row.Item("Tgl_Kirim") = tglKirim.EditValue
            row.Item("Keterangan") = txtKeterangan.Text
            row.Item("Alamat_Tarik") = txtAlamatTarik.Text
            row.Item("PPn") = "0"
            row.Item("No_Telp") = txtTelp.Text
            row.Item("Total_qty") = Qty.SummaryText
            row.Item("Departement") = kddep
            row.Item("Status") = "OK"
            If tglLahir.Text <> "" Then row.Item("tgl_lahir_umum") = tglLahir.EditValue
            row.Item("KOTA") = txtKota.Text
            If Tgl_Masuk.Text <> "" Then row.Item("TGL_BARANG_MASUK") = Tgl_Masuk.EditValue
            row.Item("Biaya") = txtBiaya.EditValue
            row.Item("JML_RP_TRANS") = lblTotal.EditValue
            row("Jenis_sp") = cmbJenisSP.Text
            If JamKirim.Text <> "" Then row("JamKirim") = JamKirim.Text
            row.Item("Program_Name") = Me.Name

            If State = "ADD" Then
                dsete.Tables("SO").Rows.Add(row)
            End If
            Dim a As Integer = 1
            For Each rows As DataRow In dsete.Tables("SOD").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("Last_Create_Date") = getTanggal()
                    rows.Item("Last_Created_By") = username
                    rows.Item("kd_Cabang") = kdcabang
                    rows.Item("tipe_trans") = row.Item("Tipe_trans")
                    rows.Item("Status") = "Y"
                    rows.Item("departemen") = kddep
                ElseIf Not rows.RowState = DataRowState.Deleted Then
                    rows.Item("Last_Update_Date") = getTanggal()
                    rows.Item("Last_Updated_By") = username
                    If rows.Item("Status_Inspeksi").ToString = "" Then
                        rows.Item("Status_Inspeksi") = "AWAL"
                        rows.Item("CONFIRMED") = "1"
                    ElseIf rows.Item("Status_Inspeksi").ToString = "AKHIR" Then
                        rows.Item("CONFIRMED") = "2"
                        row.Item("Confirmed") = "2"
                    End If
                    rows.Item("Programe_name") = Me.Name
                End If
            Next

            For Each rows As DataRow In dsete.Tables("SOB").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("Kd_Cabang") = kdcabang
                    rows.Item("No_sp") = txtNomor.Text
                    rows("tipe_trans") = row.Item("Tipe_trans")
                End If
            Next

        End If
        Try

            myBuilder = New SqlClient.SqlCommandBuilder(DA)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            DA.UpdateCommand = myBuilder.GetUpdateCommand()
            DA.InsertCommand = myBuilder.GetInsertCommand()
            DA.DeleteCommand = myBuilder.GetDeleteCommand()

            myBuilder = New SqlClient.SqlCommandBuilder(DAD)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            DAD.UpdateCommand = myBuilder.GetUpdateCommand()
            DAD.InsertCommand = myBuilder.GetInsertCommand()
            DAD.DeleteCommand = myBuilder.GetDeleteCommand()

            myBuilder = New SqlClient.SqlCommandBuilder(DAB)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            DAB.UpdateCommand = myBuilder.GetUpdateCommand()
            DAB.InsertCommand = myBuilder.GetInsertCommand()
            DAB.DeleteCommand = myBuilder.GetDeleteCommand()

            myBuilder = New SqlClient.SqlCommandBuilder(DAS)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            DAS.UpdateCommand = myBuilder.GetUpdateCommand()
            DAS.InsertCommand = myBuilder.GetInsertCommand()
            DAS.DeleteCommand = myBuilder.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            If State = "ADD" Then
                txtNomor.Text = getNoTrans("SPSRVT", row.Item("Tgl_sp"), BTRANS)
                row.Item("No_sp") = txtNomor.Text
            End If
            For Each rows As DataRow In dsete.Tables("SOD").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("No_sp") = txtNomor.Text
                End If
            Next

            For Each rows As DataRow In dsete.Tables("SOB").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("No_sp") = txtNomor.Text
                End If
            Next

            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            DAD.UpdateCommand.Transaction = BTRANS
            DAD.InsertCommand.Transaction = BTRANS
            DAD.DeleteCommand.Transaction = BTRANS

            DAB.UpdateCommand.Transaction = BTRANS
            DAB.InsertCommand.Transaction = BTRANS
            DAB.DeleteCommand.Transaction = BTRANS

            DAS.UpdateCommand.Transaction = BTRANS
            DAS.InsertCommand.Transaction = BTRANS
            DAS.DeleteCommand.Transaction = BTRANS

            dsete2 = dsete.Clone
            dsete2 = dsete.Copy

            DA.Update(dsete.Tables("SO"))
            DAD.Update(dsete.Tables("SOD"))
            DAB.Update(dsete.Tables("SOB"))
            DAS.Update(dsete.Tables("DSERVICE"))

            State = "EDIT"
            BTRANS.Commit()
            showMessages("Transaksi Telah Diproses")
            lblStatus.Text = "[EDIT]"
        Catch e As Exception
            If Not BTRANS Is Nothing Then BTRANS.Rollback()
            dsete = dsete2.Clone
            dsete = dsete2.Copy
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

        End Try
    End Sub

    Private Sub GV_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        If e.Column Is Kd_Stok Then
            Dim rw As DataRow
            rw = dsete.Tables("VBARANG").Select("Kode_Barang='" & e.Value & "'")(0)
            GV.SetRowCellValue(e.RowHandle, "Kd_satuan", rw("kd_satuan"))
            Dim i As Int16 = 0
            For Each rw In dsete.Tables("DSERVICE").Select("sp_seq='" & GV.GetRowCellValue(e.RowHandle, "No_seq") & "'")
                If rw.RowState <> DataRowState.Deleted Then
                    rw.Delete()
                End If
            Next
            For Each rw In dsete.Tables("SOM").Select("NO_SEQ_SP='" & GV.GetRowCellValue(e.RowHandle, "No_seq") & "'")
                If rw.RowState <> DataRowState.Deleted Then
                    rw.Delete()
                End If
            Next
            If i = 1 Then
                GV.GetRow(e.RowHandle)("harga") = GV.GetRowCellValue(e.RowHandle, "BIAYA_SERVICE") + dsete.Tables("DSERVICE").Compute("sum(biaya)", "sp_seq='" & GV.GetRowCellValue(e.RowHandle, "No_seq") & "'")
                lblTotal.EditValue = txtBiaya.EditValue + dsete.Tables("SOD").Compute("sum(harga)", "")
            End If
            GV.GetRow(e.RowHandle)("Deskripsi") = GV.GetRowCellDisplayText(e.RowHandle, "Kd_Stok")
            txtDesk.Text = GV.GetRowCellDisplayText(e.RowHandle, "Kd_Stok")
        ElseIf e.Column Is BIAYA_SERVICE Then
            If GV.GetRowCellValue(e.RowHandle, "biaya_lama").ToString <> "" Then
                GV.GetRow(e.RowHandle)("harga") = (GV.GetRowCellValue(e.RowHandle, "harga") + e.Value) - GV.GetRowCellValue(e.RowHandle, "biaya_lama")
            End If
            GV.GetRow(e.RowHandle)("biaya_lama") = e.Value
        End If
    End Sub
    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.SetRowCellValue(e.RowHandle, "No_seq", GV.RowCount + 1)
        GV.SetRowCellValue(e.RowHandle, "Qty", 1)
        GV.SetRowCellValue(e.RowHandle, "KOMPLAIN", "T")
        GV.SetRowCellValue(e.RowHandle, "harga", 0)
        GV.SetRowCellValue(e.RowHandle, "BIAYA_SERVICE", 0)
    End Sub
    Private Sub GV_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gvd_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvd.CellValueChanged
        If e.Column.Name = "Terima_Rekomendasi" Then
            Dim total As Double = 0
            For i As Int16 = 0 To sender.RowCount - 1
                If sender.GetRowCellValue(i, "Terima_Rekomendasi").ToString = "Y" Then
                    If sender.GetRowCellValue(i, "Garansi").ToString = "T" Then total += sender.GetRowCellValue(i, "biaya")
                End If
            Next
            total += GV.GetRowCellValue(rhandel, "BIAYA_SERVICE")
            'GV.SetRowCellValue(rhandel, "harga", total)
            dsete.Tables("SOD").Rows(rhandel)("harga") = total
            lblTotal.EditValue = txtBiaya.EditValue + dsete.Tables("SOD").Compute("sum(harga)", "")
        End If
    End Sub

    Private Sub gvd_HiddenEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvd.HiddenEditor
        If Not clone Is Nothing Then
            clone.Dispose()
            clone = Nothing
        End If
    End Sub

    Private Sub Gvr_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvd.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub GV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV.GetSelectedRows.Count = 0 Then Exit Sub
            If Not btnSave Then Exit Sub
            If MsgBox("Hapus Data Service Barang ? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Hapus") = MsgBoxResult.Yes Then
                GV.DeleteSelectedRows()
            End If
        End If
    End Sub
    Private Sub GV_MasterRowExpanded(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs) Handles GV.MasterRowExpanded
        kd_jns_brg = Mid(GV.GetRowCellValue(e.RowHandle, "Kd_Stok"), 3, 3)
        With New SqlCommand("select [group] from sif.dbo.sif_jenis_barang where kd_jns_brg='" & kd_jns_brg & "'", sqlconn).ExecuteReader
            .Read()
            If .HasRows Then
                kd_jns_brg = .Item(0).ToString
            End If
            .Close()
        End With
        clone = New DataView(dsete.Tables("JNSSRVSH"))
        clone.RowFilter = "Val_kode1= '" & kd_jns_brg & "'"
        repJNSSRVSH.DataSource = clone
    End Sub

    Private Sub GV_MasterRowExpanding(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventArgs) Handles GV.MasterRowExpanding
        If GV.GetRowCellValue(e.RowHandle, "Status").ToString = "BATAL" Then e.Allow = False
    End Sub
    Private Sub GV_MasterRowGetLevelDefaultView(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs) Handles GV.MasterRowGetLevelDefaultView
        rhandel = e.RowHandle
    End Sub
    Private Sub GV_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV.RowUpdated
        lblTotal.EditValue = dsete.Tables("SOD").Compute("sum(harga)", "") + txtBiaya.EditValue
    End Sub
    Private Function getTarif(ByVal kd_bom As String, ByVal kd_stok As String, Optional ByVal kd_kain As String = "")
        Dim dr, dr2 As SqlDataReader
        Dim hasil As Double = 0
        dr = New SqlCommand("select * from sif.dbo.sif_barang where Kode_Barang='" & kd_stok & "'", sqlconn).ExecuteReader
        dr.Read()
        If dr.HasRows Then
            If kd_kain = "" Then kd_kain = dr("kd_tipe")
            dr2 = New SqlCommand("select Tarif from sif.dbo.SIF_Tarif_Service where Merk='" & dr("kd_merk") & "' and Tipe='" & kd_kain & "' and Jenis='" & dr("kd_jenis") & "' and Ukuran='" & dr("kd_ukuran") & "' and Service='" & kd_bom & "'", sqlconn).ExecuteReader
            dr2.Read()
            If dr2.HasRows Then
                hasil = dr2(0)
            Else
                hasil = 0
            End If
            dr2.Close()

        End If
        dr.Close()

        Return hasil
    End Function

    Private Sub GV_ShowingEditor(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles GV.ShowingEditor
        If State = "ADD" Then Exit Sub
        If status_service <> "Belum Inspeksi" And sender.FocusedColumn.Name = Kd_Stok.Name Then e.Cancel = True
    End Sub

    Private Sub GV_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        Dim isValid As Boolean = True
        If Not e.Row("Qty") Is Nothing Then
            If e.Row("Qty").ToString = "" Then
                isValid = False
                GV.SetColumnError(Qty, "Inputan Jumlah Salah", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            ElseIf e.Row("Qty") < 0 Then
                isValid = False
                GV.SetColumnError(Qty, "Inputan Jumlah Salah", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If
        If Not e.Row("Kd_Stok") Is Nothing Then
            If e.Row("Kd_Stok").ToString = "" Then
                isValid = False
                GV.SetColumnError(Kd_Stok, "Kode Stok Kosong", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If
        If Not e.Row("BIAYA_SERVICE") Is Nothing Then
            If e.Row("BIAYA_SERVICE") < 0 Then
                isValid = False
                GV.SetColumnError(BIAYA_SERVICE, "Inputan Biaya Service Salah", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If
        e.Valid = isValid
    End Sub
    Private Sub refreshNomer(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        Dim j As Int16 = 1
        If State = "DELETE" Then Exit Sub
        For Each rw As DataRow In sender.Rows
            If rw.RowState <> DataRowState.Deleted Then
                rw("No_seq") = i
                For Each rwd As DataRow In dsete.Tables("DSERVICE").Select("sp_seq=" & rw.Item("No_seq"))
                    rwd("sp_seq") = i
                Next
                For Each rwd As DataRow In dsete.Tables("SOM").Select("NO_SEQ_SP=" & rw.Item("No_seq"))
                    rwd("SP_SEQ_SP") = i
                Next
                i += 1
            End If
        Next
        GV.CollapseAllDetails()
    End Sub
    Private Sub Gvd_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvd.InitNewRow
        sender.SetRowCellValue(e.RowHandle, "no_seq", sender.RowCount)
        sender.SetRowCellValue(e.RowHandle, "Garansi", "T")
        sender.SetRowCellValue(e.RowHandle, "kd_stok", GV.GetRowCellValue(rhandel, "Kd_Stok"))
        sender.SetRowCellValue(e.RowHandle, "sp_seq", GV.GetRowCellValue(rhandel, "No_seq"))
    End Sub
    Private Sub btnBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuku.Click
        call_form_manual("frmBukuService")
    End Sub
    Private Sub GridView1_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvd.ValidateRow
        Dim isValid As Boolean = True
        If sender.GetRow(e.RowHandle).item("Kode_Service").ToString = "" Then
            isValid = False
            sender.SetColumnError(sender.Columns("Kode_Service"), "Kode Service Tidak Boleh Kosong", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        e.Valid = isValid
    End Sub
    Private Sub tglKirim_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tglKirim.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAlamatKirim.Focus()
        End If
    End Sub
    Private Sub txtNamaPnrm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNamaPnrm.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtKeterangan.Focus()
        End If
    End Sub
    Private Sub txtAlamatKirim_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlamatKirim.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNamaPnrm.Focus()
        End If
    End Sub
    Private Sub txtKeterangan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKeterangan.KeyDown
        If e.KeyCode = Keys.Enter Then
            prn.btnSave.Focus()
        End If
    End Sub
    Private Sub txtCustomer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCustomer.KeyDown
        If e.KeyCode = Keys.Enter Then
            GV.Focus()
        End If
    End Sub
    Private Sub GridView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gvd.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim idx As Int32 = sender.GetRowCellValue(sender.GetSelectedRows(0), "sp_seq")
            Dim i As Int16 = 1
            sender.DeleteSelectedRows()
            For Each rw In dsete.Tables("DSERVICE").Select("sp_seq='" & idx & "'")
                If rw.RowState <> DataRowState.Deleted Then
                    rw("no_seq") = i
                    i += 1
                End If
            Next
        End If
    End Sub
    Private Sub frmService_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        pnl.Height = Me.Height - 15
    End Sub

    Private Sub gvd_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gvd.RowUpdated
        lblTotal.EditValue = txtBiaya.EditValue + dsete.Tables("SOD").Compute("sum(harga)", "")
    End Sub
    Private Sub txtBiaya_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles txtBiaya2.ButtonClick
        popBiaya.Show()
    End Sub
    Private Sub GV_Biaya_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV_Biaya.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub GV_Biaya_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV_Biaya.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV_Biaya.SelectedRowsCount > 0 Then
                GV_Biaya.DeleteSelectedRows()
                txtBiaya.EditValue = dsete.Tables("SOB").Compute("sum(biaya)", "")
            End If
        End If
    End Sub
    Private Sub GV_Biaya_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV_Biaya.RowUpdated
        txtBiaya.EditValue = dsete.Tables("SOB").Compute("sum(biaya)", "")
    End Sub
    Private Sub GV_Biaya_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV_Biaya.ValidateRow
        Dim isValid As Boolean = True
        If e.Row.item("kd_biaya").ToString = "" Then
            isValid = False
            GV_Biaya.SetColumnError(kd_biaya, "Harap Mengisi Nama Biaya", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("biaya").ToString = "" Then
            isValid = False
            GV_Biaya.SetColumnError(biaya, "Harap Mengisi Besar Biaya", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        ElseIf e.Row.item("biaya") <= 0 Then
            isValid = False
            GV_Biaya.SetColumnError(biaya, "Harap Mengisi Besar Biaya Dengan Benar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        Dim rw() As DataRow = dsete.Tables("SOB").Select("kd_biaya = '" & e.Row.item("kd_biaya") & "'")
        If rw.Count = 1 Then
            If Not rw(0) Is e.Row.row Then
                isValid = False
                GV_Biaya.SetColumnError(kd_biaya, "Nama Biaya Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If
        e.Valid = isValid
    End Sub
    Private Sub txtBiaya_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBiaya.EditValueChanged
        If lblTotal.EditValue Is Nothing Then lblTotal.EditValue = 0
        If txtBiaya.EditValue Is Nothing Then txtBiaya.EditValue = 0
        lblTotal.EditValue = txtBiaya.EditValue + dsete.Tables("SOD").Compute("sum(harga)", "")
    End Sub

    Private Sub gvd_ShownEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvd.ShownEditor
        If sender.FocusedColumn.Name = Kain.Name Then

            Dim row As DataRow
            row = sender.GetDataRow(sender.FocusedRowHandle)

            Dim edit As DevExpress.XtraEditors.LookUpEdit
            Dim table As DataTable
            edit = CType(sender.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)
            table = CType(edit.Properties.DataSource, DataTable)
            clone = New DataView(table)

            clone.RowFilter = "Kode_Merk ='" & Mid(GV.GetRowCellValue(rhandel, "Kd_Stok").ToString, 6, 2) & "'" 'CType(GcMstPromo_d.FocusedView, GridView).GetFocusedRow.item("kd_merk") & "')"
            edit.Properties.DataSource = clone
            'ElseIf sender.FocusedColumn.Name = kd_kain.Name Then

            '    Dim row As DataRow
            '    row = sender.GetDataRow(sender.FocusedRowHandle)

            '    Dim edit As DevExpress.XtraEditors.LookUpEdit
            '    Dim table As DataTable
            '    edit = CType(sender.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)
            '    table = CType(edit.Properties.DataSource, DataTable)
            '    clone = New DataView(table)

            '    clone.RowFilter = "Kode_Merk ='" & Mid(GV.GetRowCellValue("Kd_Stok", rhandel), 6, 2) & "'" 'CType(GcMstPromo_d.FocusedView, GridView).GetFocusedRow.item("kd_merk") & "')"
            '    edit.Properties.DataSource = clone
        End If
    End Sub

    Private Sub cmbJenisSP_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles cmbJenisSP.EditValueChanging
        If ONLOAD_STATE Then Exit Sub
        If State = "" Then Exit Sub
        If dsete.Tables("SOD").Rows.Count = 0 Then Exit Sub
        If MsgBox("Mengganti Jenis SP Akan Mereset Semua Kolom Isian, Ganti Jenis SP ?", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel, "Peingatan") = MsgBoxResult.Cancel Then
            e.Cancel = True

        Else
            If Not dsete.Tables("DSERVICE") Is Nothing Then dsete.Tables("DSERVICE").Clear()
            If Not dsete.Tables("SOD") Is Nothing Then dsete.Tables("SOD").Clear()
        End If
    End Sub
    Private Sub cmbJenisSP_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles cmbJenisSP.QueryPopUp
        If State = "ADD" Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub cmbJenisSP_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbJenisSP.SelectedIndexChanged
        tglKirim.EditValue = Nothing
        txtAlamatKirim.Text = ""
        txtNamaPnrm.Text = ""
        txtKeterangan.Text = ""
        txtBiaya.EditValue = 0
        lblTotal.EditValue = 0
        dsete.Tables("SOB").Rows.Clear()
        If cmbJenisSP.Text = "KONSINYASI" Then
            cmbJenisSP.Properties.Appearance.BackColor = Color.Yellow
        ElseIf cmbJenisSP.Text = "INTERNAL" Then
            cmbJenisSP.Properties.Appearance.BackColor = Color.GreenYellow
            dvCustomer = New DataView(dsete.Tables("CUSTOMER"))
            dvCustomer.RowFilter = "Kd_Customer = 'INTERNAL'"
            If dvCustomer.Count > 0 Then
                txtCustomer.EditValue = dvCustomer.Item(0)("Kd_customer")
            End If
        Else
            cmbJenisSP.Properties.Appearance.BackColor = Color.White
            dvCustomer = New DataView(dsete.Tables("CUSTOMER"))
            dvCustomer.RowFilter = "Kd_Customer <> 'INTERNAL'"
            txtCustomer.EditValue = Nothing
        End If
        txtCustomer.Properties.DataSource = dvCustomer

        dsete.Tables("VBARANG").Clear()
        If sender.text = "INTERNAL" Then
            dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select b.Kd_Satuan, b.Nama_Barang, h.Harga_Dollar ,h.Harga_Rupiah, b.Kode_Barang , case kd_jenis when '038' then 1 when '039' then 1 else 0 end  as isset from SIF.dbo.SIF_Barang as b, sif.dbo.sif_harga as h where b.Kd_Depart = '" & kddep & "' and b.kd_jns_persd in ('1','2') and b.Kode_Barang=h.Kode_Barang and b.rec_stat='Y' order  by Nama_Barang", sqlconn))
            dadbe.Fill(dsete, "VBARANG")
        Else
            dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select b.Kd_Satuan, b.Nama_Barang, h.Harga_Dollar ,h.Harga_Rupiah, b.Kode_Barang , case kd_jenis when '038' then 1 when '039' then 1 else 0 end  as isset from SIF.dbo.SIF_Barang as b, sif.dbo.sif_harga as h where b.Kd_Depart = '" & kddep & "' and b.Kode_Barang=h.Kode_Barang and b.rec_stat='Y' order  by Nama_Barang", sqlconn))
            dadbe.Fill(dsete, "VBARANG")
        End If
    End Sub

    Private Sub gvm_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvm.CellValueChanged
        If e.Column.Name = KD_BARANG.Name Then
            With New SqlCommand("select nilai_rata from inv.dbo.inv_stok_saldo where kd_stok='" & e.Value & "' and bultah = (select max(bultah) from inv.dbo.inv_stok_saldo where kd_stok='" & e.Value & "')", sqlconn).ExecuteReader
                .Read()
                If .HasRows Then
                    sender.SetRowCellValue(e.RowHandle, "HARGA", .Item(0))
                End If
                .Close()
            End With
        End If
    End Sub
    Private Sub gvm_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvm.InitNewRow
        sender.SetRowCellValue(e.RowHandle, "NO_SEQ", sender.RowCount)
        sender.SetRowCellValue(e.RowHandle, "MARGIN", MarginService)
    End Sub

    Private Sub gvm_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvm.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gvm_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gvm.RowUpdated
        e.Row.item("TOTAL") = (e.Row.item("HARGA") + (e.Row.item("HARGA") * e.Row.item("MARGIN") / 100)) * e.Row.item("QTY")
        lblTotal.EditValue = txtBiaya.EditValue + CType("0" & sender.Columns("TOTAL").SummaryText, Double) + CType("0" & biaya.SummaryText, Double)
    End Sub

    Private Sub gvm_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvm.ValidateRow
        Dim isValid As Boolean = True
        If e.Row("KD_BARANG").ToString = "" Then
            isValid = False
            sender.SetColumnError(KD_BARANG, "Harap Mengisi Kode Barang Dengan Benar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row("QTY").ToString = "" Then
            isValid = False
            sender.SetColumnError(QTY2, "Harap Mengisi Jumlah Barang Dengan Benar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        ElseIf e.Row("QTY") <= 0 Then
            isValid = False
            sender.SetColumnError(QTY2, "Harap Mengisi Jumlah Barang Dengan Benar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        e.Valid = isValid
    End Sub

    Public Sub loadData()
        If noso <> "" Then
            prn = frmMain
            
            btnadd = False
            btnEdit = False
            btnDelete = True
            btnSave = True
            status_service = statusService
            State = "EDIT"
            CObj(prn.pnlDisplay2.Controls(0)).Enabled = True
            setStatus()
            txtCustomer.Focus()
            GV.CollapseAllDetails()
            reloadTable(noso, tipetransx)
            tipetransx = ""
            noso = ""
            statusService = ""
            GV.Focus()
            GV.ExpandAllGroups()

        End If
    End Sub

    Private Sub DT_TglSO_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_TglSO.EditValueChanged
        tglSO.Text = DT_TglSO.EditValue
    End Sub

    Private Sub tglSO_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tglSO.TextChanged
        DT_TglSO.EditValue = tglSO.Text
    End Sub

    Private Sub txtSales_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSales.EditValueChanged
        If txtSales.Text.ToString <> "" Then
            txtNamaSales.Text = txtSales.EditValue
        Else
            txtNamaSales.EditValue = ""
        End If
    End Sub

    Private Sub repDes_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repDes.ButtonClick
        If GV.FocusedValue Is Nothing Then Exit Sub
        popDesk.Show()
        txtDesk.Text = GV.FocusedValue.ToString
    End Sub

   
    Private Sub txtDesk_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDesk.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtDesk.Text = "" Then Exit Sub
            GV.GetFocusedDataRow.Item("Deskripsi") = txtDesk.Text
            popDesk.Hide()
            GV.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            popDesk.Hide()
            GV.Focus()
        End If
    End Sub

    Private Sub CetakSP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CetakSP.Click
        If State = "EDIT" Then
            Try
                If kddep = KD_DIV_SPRING Then
                    CetakSP.Enabled = False
                    callReport(App_Path() & "\report\vSRV.rpt", "", "NO_SRV=" & txtNomor.Text, True, True, "DIM")
                    CetakSP.Enabled = True
                Else
                    CetakSP.Enabled = False
                    callReport(App_Path() & "\report\vSRV2.rpt", "", "NO_SRV=" & txtNomor.Text, True, True, "DIM")
                    CetakSP.Enabled = True
                End If
            Catch ex As Exception
                MsgBox("Error : " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Printing")
                CetakSP.Enabled = True
            End Try
        End If
    End Sub

    Private Sub btnBatalSP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatalSP.Click
        If txtNomor.Text = "" Then Exit Sub
        If MsgBox("Batalkan Konfirmasi?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Batal") = MsgBoxResult.Yes Then
            With New SqlCommand("update sales.dbo.sales_so set Confirmed = null, isPrinted=null where no_sp = '" & txtNomor.Text & "'", sqlconn).ExecuteNonQuery

            End With
            With New SqlCommand("update sales.dbo.sales_so_d set Status_Inspeksi='AKHIR', CONFIRMED = null where isnull(CONFIRMED,'1')='2' and no_sp = '" & txtNomor.Text & "'", sqlconn).ExecuteNonQuery

            End With
            With New SqlCommand("update sales.dbo.Sales_produk_service set Terima_Rekomendasi = null where Nomor_SO = '" & txtNomor.Text & "'", sqlconn).ExecuteNonQuery

            End With
            showMessages("Service Sudah di Batal Konfirmasi")
            reloadTable(txtNomor.Text, dsete.Tables("SO")(0)("tipe_trans"))

        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatalInsp.Click

    End Sub
End Class