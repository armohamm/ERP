Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class frmSOkonsinyasi
    Dim dsete As New DataSet
    Dim dsete2 As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA As SqlDataAdapter
    Dim DAB As SqlDataAdapter
    Dim DAP As SqlDataAdapter
    Dim DAD As SqlDataAdapter
    Dim DADD As SqlDataAdapter
    Dim obj As Object
    Dim prn As frmMain
    Dim kriteria As String
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Public baru As Boolean
    Dim myBuilder As New SqlCommandBuilder
    Private clone As DataView
    Public no_sp As String = "XXX"
    Public tipe_transaksi As String = "XXX"
    Dim rhandel As Integer
    Public konsinyasi = "UMUM"
    Public ONLOAD_STATE As Boolean = False
    Public oldTotal As Double = 0
    Dim dvCustomer As New DataView
    Public isInternal As Boolean = False
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
        If State = "" Then
            lblState.Text = "IDLE"
        Else
            lblState.Text = State
        End If

    End Sub
    Private Sub reload_table(ByVal kode As String, ByVal tipe_trans As String)
        If Not dsete.Tables("SOD") Is Nothing Then dsete.Tables("SOD").Clear()
        If Not dsete.Tables("SODD") Is Nothing Then dsete.Tables("SODD").Clear()
        If Not dsete.Tables("SO") Is Nothing Then dsete.Tables("SO").Clear()
        If Not dsete.Tables("SOP") Is Nothing Then dsete.Tables("SOP").Clear()
        If Not dsete.Tables("SOB") Is Nothing Then dsete.Tables("SOB").Clear()

        DAD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, harga*qty-potongan_total as total,0 as state from Sales.dbo.SALES_SO_D where key_bonus is null and kd_parent is null and No_sp='" & kode & "' and nomor_bonus is null and tipe_trans='" & tipe_trans & "' order by len(no_seq), No_seq ", sqlconn))
        DAD.Fill(dsete, "SOD")
        DADD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, harga*qty-potongan_total as total,0 as state from Sales.dbo.SALES_SO_D where not kd_parent is null and No_sp='" & kode & "' and tipe_trans='" & tipe_trans & "'", sqlconn))
        DADD.Fill(dsete, "SODD")
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *  from Sales.dbo.SALES_SO where No_sp='" & kode & "' and tipe_trans='" & tipe_trans & "'", sqlconn))
        DA.Fill(dsete, "SO")
        DAP = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.*, (select nama_promo from sif.dbo.sif_promo where no_promo=a.kd_promo) PROMONAME from Sales.dbo.SALES_SO_D_PROMO a where a.No_sp='" & kode & "' and a.tipe_trans='" & tipe_trans & "'", sqlconn))
        DAP.Fill(dsete, "SOP")
        DAB = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from Sales.dbo.SALES_SO_BIAYA where No_sp='" & kode & "' and tipe_trans='" & tipe_trans & "'", sqlconn))
        DAB.Fill(dsete, "SOB")

        If dsete.Tables("SO").Rows.Count > 0 Then
            Dim row As DataRow

            row = dsete.Tables("SO").Rows(0)
            txtNomor.Text = row.Item("No_sp").ToString
            tglSO.Text = row.Item("Tgl_sp").ToString
            cmbJenisSP.Text = row("Jenis_sp").ToString
            txtCustomer.EditValue = row.Item("Kd_Customer").ToString
            txtNamaPnrm.Text = row.Item("Nama_pnrm").ToString
            txtAlamatKirim.Text = row.Item("Almt_pnrm").ToString
            tglKirimMarketing.EditValue = row.Item("Tgl_Kirim_Marketing")
            txtSales.EditValue = row.Item("Kd_sales").ToString
            txtKeterangan.Text = row.Item("Keterangan").ToString
            lblPromo.Text = row.Item("desc_promo").ToString
            vValas.EditValue = row.Item("Valas").ToString
            txtKurs.Text = row.Item("Kurs").ToString
            cmdWilayah.EditValue = row.Item("Kode_Wilayah").ToString
            txtMedia.EditValue = row("media").ToString
            tglKirim.EditValue = row.Item("Tgl_Kirim").ToString
            
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
            dr = Nothing
            If Len(txtNomor.Text) > 8 Then

                btnSave = False
                btnCancel = True
                btnDelete = False
            End If
            If row("isPrinted").ToString = "Y" Then
                prn.btnCetak.Enabled = False
            Else
                prn.btnCetak.Enabled = True
            End If
            setStatus()
        Else
            oldTotal = 0
            txtCustomer.EditValue = vbNullString
            txtSales.EditValue = vbNullString
            txtNomor.Text = vbNullString
            tglKirimMarketing.EditValue = vbNullString
            tglKirim.EditValue = vbNullString
            cmdWilayah.EditValue = vbNullString
            tglSO.Text = vbNullString
            txtNamaPnrm.Text = vbNullString

            lblPromo.Text = "-"
            lblStatus.Text = " [New]"
            vValas.EditValue = "IDR"
            txtMedia.EditValue = Nothing

        End If
        'cmbJenisSP.Text = konsinyasi
    End Sub
    Private Sub frmSO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbJenisSP.Properties.Items.Clear()
        cmbJenisSP.Properties.Items.Add("KONSINYASI")
        cmbJenisSP.EditValue = "KONSINYASI"

        connect()
        lblStateCR.Text = ""
        reload_master()

        cmdWilayah.Properties.DataSource = dsete.Tables("WILAYAH")

        'If kddep = 2 Then

        repBarang.DataSource = dsete.Tables("VBARANG")
        ' txtcari.AutoCompleteCustomSource.AddRange((From row As Object In dsete.Tables("VBARANG").Rows.Cast(Of DataRow)() Select CStr(row("Nama_Barang"))).ToArray())

        vValas.Properties.DataSource = dsete.Tables("VALAS")
        vValas.EditValue = "IDR"

        txtCustomer.Properties.DataSource = dsete.Tables("CUSTOMER")

        txtSales.Properties.DataSource = dsete.Tables("SALES")
        txtSales.Properties.DisplayMember = "Nama_Sales"
        txtSales.Properties.ValueMember = "Kode_Sales"

        reload_table(no_sp, tipe_transaksi)

        AddHandler dsete.Tables("SOD").RowDeleted, AddressOf refreshNomer
        'repbarang.DataSource = dsete.Tables("VBARANG")
        GC.DataSource = dsete.Tables("SOD")
        Dim r2 As DataRelation

        Dim dcolP2(2) As DataColumn
        Dim dColPROMO(2) As DataColumn
        '  If kddep = 2 Then
        Dim rl As DataRelation
        Dim dcolP(2) As DataColumn
        Dim dcolC(2) As DataColumn

        dcolP(0) = dsete.Tables("SOD").Columns("Kd_Stok")
        dcolP(1) = dsete.Tables("SOD").Columns("No_sp")
        dcolP(2) = dsete.Tables("SOD").Columns("No_Seq")

        dcolC(0) = dsete.Tables("SODD").Columns("kd_parent")
        dcolC(1) = dsete.Tables("SODD").Columns("No_sp")
        dcolC(2) = dsete.Tables("SODD").Columns("No")

        rl = dsete.Relations.Add("Detail", dcolP, dcolC, False)
        rl.Nested = True
        GC.LevelTree.Nodes.Add("Detail", GVD)

        'End If
        dcolP2(0) = dsete.Tables("SOD").Columns("Kd_Stok")
        dcolP2(1) = dsete.Tables("SOD").Columns("No_sp")
        dcolP2(2) = dsete.Tables("SOD").Columns("No_seq")

        dColPROMO(0) = dsete.Tables("SOP").Columns("KD_STOK")
        dColPROMO(1) = dsete.Tables("SOP").Columns("NO_SP")
        dColPROMO(2) = dsete.Tables("SOP").Columns("seq_sp")

        r2 = dsete.Relations.Add("Promo", dcolP2, dColPROMO, False)
        r2.Nested = True

        GC.LevelTree.Nodes.Add("Promo", GVP)
        State = "ADD"
        tglSO.Text = getTanggal()
        prn = frmMain

    End Sub
    Private Sub refreshNomer(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        Dim j As Int16 = 1
        If State = "DELETE" Then Exit Sub

        For Each rw As DataRow In sender.Rows
            If rw.RowState <> DataRowState.Deleted Then
                For Each rwd As DataRow In dsete.Tables("SODD").Select("NO=" & rw.Item("No_seq"))
                    rwd("NO") = i
                    rwd("No_seq") = i & "." & j
                    j += 1
                Next
                For Each rwd As DataRow In dsete.Tables("SOP").Select("seq_sp=" & rw.Item("No_seq"))
                    rwd("seq_sp") = i
                Next
                j = 1
                rw("No_seq") = i
                i += 1

            End If
        Next
    End Sub
    Public Function getCreditLimit(Optional ByVal btrans As SqlTransaction = Nothing) As Double
        Dim dr As SqlDataReader
        Dim hasil As Double = 0
        If btrans Is Nothing Then
            dr = New SqlCommand("select  isnull( sales.dbo.getCreditLimit('" & txtCustomer.EditValue & "', '" & vValas.EditValue & "'),0)", sqlconn).ExecuteReader
        Else
            dr = New SqlCommand("select isnull( sales.dbo.getCreditLimit('" & txtCustomer.EditValue & "', '" & vValas.EditValue & "'),0)", sqlconn, btrans).ExecuteReader
        End If
        dr.Read()
        If dr.HasRows Then hasil = CType(dr(0), Int64)
        dr.Close()
        dr = Nothing
        Return hasil
    End Function
    Private Sub txtCustomer_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomer.EditValueChanged

        txtKodeCust.Text = sender.editvalue

        If sender.editvalue <> vbNullString Then
            If cmbJenisSP.EditValue <> "INTERNAL" Then
                txtAlamatKirim.Text = txtCustomer.Properties.GetDataSourceValue("Alamat1", txtCustomer.ItemIndex).ToString()
                If Not dsete.Tables("SALES") Is Nothing Then dsete.Tables("SALES").Clear()
                txtSales.EditValue = vbNullString
                Dim area As String = txtCustomer.Properties.GetDataSourceValue("Kode_Area", txtCustomer.ItemIndex).ToString()
                Dim wil As String = txtCustomer.Properties.GetDataSourceValue("Kd_Wilayah", txtCustomer.ItemIndex).ToString()
                cmdWilayah.EditValue = wil
                dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Sales, Kode_Sales from SIF.dbo.SIF_Sales where kode_departemen='" & kddep & "' and kode_wilayah = '" & wil & "' and kode_area ='" & area & "' and rec_stat='Y'", sqlconn))
                dadbe.Fill(dsete, "SALES")

                txtCR.EditValue = getCreditLimit()
                If dsete.Tables("SALES").Rows.Count > 0 And State = "ADD" Then
                    txtSales.EditValue = dsete.Tables("SALES").Rows(0)("Kode_Sales")
                End If
                If State = "ADD" Then
                    Dim kdwil As String = txtCustomer.Properties.GetDataSourceValue("Kd_Wilayah", txtCustomer.ItemIndex).ToString
                    Dim kdarea As String = txtCustomer.Properties.GetDataSourceValue("Kode_Area", txtCustomer.ItemIndex).ToString
                    With dsete.Tables("AREA").Select("Kd_Wilayah = '" & kdwil & "' and Kode_Area='" & kdarea & "'")
                        If .Count > 0 Then tglKirimMarketing.EditValue = getTanggal.AddDays(.ElementAt(0).Item("Leat_Time")) : tglKirim.EditValue = tglKirimMarketing.EditValue
                    End With
                End If
            Else
                txtAlamatKirim.Text = ""
            End If
        Else
            txtAlamatKirim.Text = "X"
            txtSales.EditValue = vbNullString
        End If
        DXEP.SetError(txtKodeCust, "")
    End Sub
    Private Sub txtSales_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSales.EditValueChanged
        txtNamaSales.Text = sender.editvalue
        DXEP.SetError(txtNamaSales, "")
    End Sub
    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        If Not Me.Controls("frmBukuOrder") Is Nothing Then Exit Sub
        If Not Me.Controls("frmStatusSP") Is Nothing Then Exit Sub

        Dim row As DataRow
        Dim BTRANS As SqlTransaction
        Dim isError As Boolean = False
        If State <> "ADD" Then
            Dim dr As SqlDataReader = New SqlCommand("select [status] from sales.dbo.sales_so where no_sp='" & txtNomor.Text & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                If dr(0).ToString = "BATAL" Then
                    MsgBox("Data Sales Order Tersebut Sudah Dibatalkan, Data Akan Dibersihkan", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Peringatan")
                    cancel_click()
                    dr.Close()
                    Exit Sub
                End If
            Else
                MsgBox("Data Sales Order Tersebut Tidak Diketemukan, Data Akan Dibersihkan", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Peringatan")
                cancel_click()
                dr.Close()
                Exit Sub
            End If
            dr.Close()
        End If
        If Not isDelete Then
            If txtCustomer.EditValue = "" Then
                DXEP.SetError(txtKodeCust, "Nama Customer Belum Diisi")
                txtCustomer.Focus()
                isError = True
            End If
            If cmbJenisSP.EditValue <> "INTERNAL" Then
                If txtSales.EditValue = "" Then
                    DXEP.SetError(txtNamaSales, "Nama Sales Belum Diisi")
                    txtSales.Focus()
                    isError = True
                End If
            End If
            If cmbJenisSP.EditValue <> "INTERNAL" Then
                If txtAlamatKirim.EditValue = "" Then
                    DXEP.SetError(txtAlamatKirim, "Alamat Kirim Belum Diisi")
                    txtAlamatKirim.Focus()
                    isError = True
                End If
            End If
            If cmbJenisSP.EditValue <> "INTERNAL" Then
                If tglKirimMarketing.Text = "" Then
                    tglKirimMarketing.ErrorText = "Tanggal Kirim Belum Diisi"
                    tglKirimMarketing.Focus()
                    isError = True
                End If
            End If
            If cmbJenisSP.EditValue <> "INTERNAL" Then
                If DateDiff(DateInterval.Day, Convert.ToDateTime(tglSO.Text), tglKirimMarketing.EditValue) < 0 Then
                    tglKirimMarketing.ErrorText = "Tanggal Janji Kirim Harus Lebih Besar Dari Tanggal Order"
                    tglKirimMarketing.Focus()
                    isError = True
                End If
            End If
            If GV.RowCount <= 1 Then
                
                isError = True
            End If

        End If
        If isError = True Then
            showMessages("Isian Masih Belum Benar, Harap Periksa Kembali", 10, "WARNING")
            Exit Sub
        End If
        If cmbJenisSP.EditValue <> "INTERNAL" Then
            txtCR.EditValue = getCreditLimit()
        End If

        If Not isDelete Then
            If State = "ADD" Then
                dsete2 = dsete.Clone
                dsete2 = dsete.Copy
                row = dsete.Tables("SO").NewRow
                row.Item("Last_Create_Date") = getTanggal()
                row.Item("Last_Created_By") = username
            ElseIf State = "EDIT" Then
                
                dsete2 = dsete.Clone
                dsete2 = dsete.Copy
                row = dsete.Tables("SO").Rows(0)
                row.Item("Last_Update_Date") = getTanggal()
                row.Item("Last_Updated_By") = username
            End If
            row.Item("Kd_Cabang") = kdcabang  ' <-- hanya contoh, nanti diisi dengan yg bener
            tipetrans = SPKonsinyasi
            row.Item("Tipe_trans") = tipetrans
            row.Item("Tgl_sp") = getTanggal()
            row.Item("Kd_Customer") = txtCustomer.EditValue
            row.Item("Nama_pnrm") = txtNamaPnrm.Text
            row.Item("Almt_pnrm") = txtAlamatKirim.Text
            If Not cmdWilayah.EditValue Is Nothing Then row.Item("Kode_Wilayah") = cmdWilayah.EditValue
            If tglKirim.Text <> "" Then row.Item("Tgl_Kirim") = tglKirim.EditValue.ToString
            If tglKirimMarketing.Text <> "" Then row.Item("Tgl_Kirim_Marketing") = tglKirimMarketing.EditValue.ToString()
            row.Item("Kd_sales") = txtSales.EditValue
            row.Item("Keterangan") = txtKeterangan.Text
            row.Item("Media") = txtMedia.EditValue
            row.Item("Flag_Ppn") = ""
            row.Item("PPn") = "0"
            row.Item("Total_qty") = Qty.SummaryText
            row.Item("Departement") = kddep
            row.Item("Status") = IIf(frmPaswdOTP.PENDING, "PENDING", "OK")
            row.Item("JML_RP_TRANS") = 0
            row.Item("Valas") = vValas.EditValue
            row.Item("Kurs") = txtKurs.Text
            row.Item("JML_VALAS_TRANS") = 0
            row.Item("Biaya") = 0
            row.Item("Program_Name") = Me.Name

            row("Jenis_sp") = cmbJenisSP.Text
            If State = "ADD" Then
                dsete.Tables("SO").Rows.Add(row)
            End If
            Dim a As Integer = 1
            For Each rows As DataRow In dsete.Tables("SOD").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("Last_Create_Date") = getTanggal()
                    rows.Item("Last_Created_By") = username
                    rows.Item("kd_Cabang") = kdcabang
                    rows.Item("No_sp") = txtNomor.Text
                    rows.Item("tipe_trans") = tipetrans
                    rows.Item("Status") = "Y"
                    rows.Item("departemen") = kddep
                    rows.Item("Programe_name") = Me.Name
                    rows.Item("Qty_sisa") = rows.Item("Qty")
                    rows.Item("qty_prod") = 0
                    rows.Item("qty_kirim") = 0
                ElseIf rows.RowState <> DataRowState.Deleted Then
                    rows.Item("Last_Update_Date") = getTanggal()
                    rows.Item("Last_Updated_By") = username
                    rows.Item("Qty_sisa") = rows.Item("Qty")
                End If
            Next
            For Each rows As DataRow In dsete.Tables("SODD").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("Last_Create_Date") = getTanggal()
                    rows.Item("Last_Created_By") = username
                    rows.Item("kd_Cabang") = kdcabang
                    rows.Item("No_sp") = txtNomor.Text
                    rows.Item("tipe_trans") = tipetrans
                    rows.Item("Status") = "Y"
                    rows.Item("departemen") = kddep
                    rows.Item("Programe_name") = Me.Name
                ElseIf rows.RowState <> DataRowState.Deleted Then
                    rows.Item("Last_Update_Date") = getTanggal()
                    rows.Item("Last_Updated_By") = username
                End If
            Next
            For Each rows As DataRow In dsete.Tables("SOP").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("NO_SP") = txtNomor.Text
                    rows("tipe_trans") = tipetrans
                End If
            Next
            For Each rows As DataRow In dsete.Tables("SOB").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("Kd_Cabang") = kdcabang
                    rows.Item("No_sp") = txtNomor.Text
                    rows("tipe_trans") = tipetrans
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

            myBuilder = New SqlClient.SqlCommandBuilder(DADD)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            DADD.UpdateCommand = myBuilder.GetUpdateCommand()
            DADD.InsertCommand = myBuilder.GetInsertCommand()
            DADD.DeleteCommand = myBuilder.GetDeleteCommand()

            myBuilder = New SqlClient.SqlCommandBuilder(DAP)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            DAP.UpdateCommand = myBuilder.GetUpdateCommand()
            DAP.InsertCommand = myBuilder.GetInsertCommand()
            DAP.DeleteCommand = myBuilder.GetDeleteCommand()

            myBuilder = New SqlClient.SqlCommandBuilder(DAB)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            DAB.UpdateCommand = myBuilder.GetUpdateCommand()
            DAB.InsertCommand = myBuilder.GetInsertCommand()
            DAB.DeleteCommand = myBuilder.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")

            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            DAD.UpdateCommand.Transaction = BTRANS
            DAD.InsertCommand.Transaction = BTRANS
            DAD.DeleteCommand.Transaction = BTRANS

            DADD.UpdateCommand.Transaction = BTRANS
            DADD.InsertCommand.Transaction = BTRANS
            DADD.DeleteCommand.Transaction = BTRANS

            DAP.UpdateCommand.Transaction = BTRANS
            DAP.InsertCommand.Transaction = BTRANS
            DAP.DeleteCommand.Transaction = BTRANS

            DAB.UpdateCommand.Transaction = BTRANS
            DAB.InsertCommand.Transaction = BTRANS
            DAB.DeleteCommand.Transaction = BTRANS

            If State = "ADD" Then
                txtNomor.Text = getNoTrans("SPSPRT", row.Item("Tgl_sp"), BTRANS)
            End If
            row.Item("No_sp") = txtNomor.Text
            For Each rows As DataRow In dsete.Tables("SOD").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("No_sp") = txtNomor.Text
                End If
            Next
            For Each rows As DataRow In dsete.Tables("SODD").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("No_sp") = txtNomor.Text
                End If
            Next
            For Each rows As DataRow In dsete.Tables("SOP").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("NO_SP") = txtNomor.Text
                End If
            Next
            For Each rows As DataRow In dsete.Tables("SOB").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("No_sp") = txtNomor.Text
                End If
            Next

            lblState.Text = "SAVING..."

            DA.Update(dsete.Tables("SO"))
            DAD.Update(dsete.Tables("SOD"))
            DADD.Update(dsete.Tables("SODD"))
            DAB.Update(dsete.Tables("SOB"))
            If State <> "ADD" Then
                With New SqlCommand("delete from Sales.dbo.SALES_SO_D_PROMO where No_sp='" & txtNomor.Text & "' and Status='Y'", sqlconn, BTRANS).ExecuteNonQuery
                End With
            End If
            lblState.Text = State
            BTRANS.Commit()
            lblState.Text = "SAVED"
            showMessages("Transaksi Telah Tersimpan")
            State = "EDIT"
            reload_table(txtNomor.Text, tipetrans)
            lblState.Text = "EDIT"
        Catch e As Exception
            If Not BTRANS Is Nothing Then BTRANS.Rollback()
            lblState.Text = "GAGAL SIMPAN"
            dsete = dsete2.Clone
            dsete = dsete2.Copy
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

        End Try
    End Sub
    Private Sub GV_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        Dim Total As Double
        If e.Column Is Kd_Stok Then
            If e.Value.ToString = "" Then
                popCon.Show()
                Exit Sub
            End If
            Dim drows As DataRow() = dsete.Tables("VBARANG").Select("Kode_Barang='" & e.Value & "'")
            If drows.Count = 0 Then
                GV.GetRow(e.RowHandle).item("Deskripsi") = "Item Not Found"
                Exit Sub
            End If

            Dim rw As DataRow
            GV.GetRow(e.RowHandle).item("Deskripsi") = "Item Not Found"
            GV.GetRow(e.RowHandle).item("qty") = 0
            GV.GetRow(e.RowHandle).item("total") = 0
            GV.GetRow(e.RowHandle).item("potongan_total") = 0
            GV.SetRowCellValue(e.RowHandle, "ambil_bonus", vbNullString)
            rw = drows(0)
            GV.GetRow(e.RowHandle).item("Deskripsi") = rw("Nama_Barang")
            GV.GetRow(e.RowHandle).item("Kd_satuan") = rw("Kd_Satuan")

            GV.GetRow(e.RowHandle).item("set") = rw("isset")
            If rw("isset").ToString = "1" Then Exit Sub
            If cmbJenisSP.Text = "INTERNAL" Then
                GV.GetRow(e.RowHandle).item("harga") = 0
                GV.GetRow(e.RowHandle).item("total") = 0
                Exit Sub
            Else
                If vValas.EditValue = "IDR" Then
                    GV.GetRow(e.RowHandle).item("harga") = rw("Harga_Rupiah")
                    GV.GetRow(e.RowHandle).item("total") = IIf(rw("Harga_Rupiah").ToString = "", 0, rw("Harga_Rupiah")) * IIf(GV.GetRow(e.RowHandle).item("Qty").ToString = "", 0, GV.GetRow(e.RowHandle).item("Qty"))
                Else
                    GV.GetRow(e.RowHandle).item("harga") = rw("Harga_Dollar")
                    GV.GetRow(e.RowHandle).item("total") = IIf(rw("Harga_Dollar").ToString = "", 0, rw("Harga_Dollar")) * IIf(GV.GetRow(e.RowHandle).item("Qty").ToString = "", 0, GV.GetRow(e.RowHandle).item("Qty"))
                End If
            End If
            GV.GetRow(e.RowHandle).item("harga") = 0
            GV.GetRow(e.RowHandle).item("total") = 0

            Dim read As SqlClient.SqlDataReader
            read = New SqlCommand("select r.* FROM dbo.SIF_Barang B, dbo.SIF_Diskon_kesepakatan R where " & _
                                  " b.kd_merk = r.KD_MERK And Kode_Barang ='" & e.Value & "' and kd_customer='" & txtCustomer.EditValue & "' and getdate() between start_date and end_date", sqlconn).ExecuteReader
            read.Read()
            If Not read.HasRows Then
                read = New SqlCommand("select r.* FROM dbo.SIF_Barang B, dbo.SIF_Diskon_Reguler R where " & _
                                      " b.kd_merk = r.KD_MERK and b.kd_tipe=r.kode_tipe and Kode_Barang ='" & e.Value & "' ", sqlconn).ExecuteReader
                read.Read()
            End If
            If read.HasRows Then
                GV.GetRow(e.RowHandle).item("nama_potongan") = read.Item("Kd_Diskon")
                If read.Item("Diskon1").ToString <> "" Then
                    GV.GetRow(e.RowHandle).item("disc1") = read.Item("Diskon1")
                End If
                If read.Item("Diskon2").ToString <> "" Then
                    GV.GetRow(e.RowHandle).item("disc2") = read.Item("Diskon2")
                End If
                If read.Item("Diskon3").ToString <> "" Then
                    GV.GetRow(e.RowHandle).item("disc3") = read.Item("Diskon3")
                End If
                If read.Item("Diskon4").ToString <> "" Then
                    GV.GetRow(e.RowHandle).item("disc4") = read.Item("Diskon4")
                End If
                If read.Item("Diskon5").ToString <> "" Then
                    GV.GetRow(e.RowHandle).item("disc5") = read.Item("Diskon5")
                End If
            End If
            read.Close()
            read = Nothing
        ElseIf e.Column Is Qty Then
            If GV.GetRow(e.RowHandle).item("harga").ToString = "" Then Exit Sub
            If e.Value.ToString = "" Then Exit Sub
            If e.Value = 0 Then Exit Sub

            GV.GetRow(e.RowHandle).item("total") = GV.GetRow(e.RowHandle).item("harga") * e.Value
            Total = GV.GetRow(e.RowHandle).item("total")
            Dim disk1 As Double = 0
            Dim disk2 As Double = 0
            Dim disk3 As Double = 0
            Dim disk4 As Double = 0
            Dim disk5 As Double = 0
            If Total = 0 Then Exit Sub
            If GV.GetRow(e.RowHandle).item("disc1").ToString <> "" Then
                disk1 = GV.GetRow(e.RowHandle).item("disc1") * Total / 100
            End If
            If GV.GetRow(e.RowHandle).item("disc2").ToString <> "" Then
                disk2 = GV.GetRow(e.RowHandle).item("disc2") * (Total - disk1) / 100
            End If
            If GV.GetRow(e.RowHandle).item("disc3").ToString <> "" Then
                disk3 = GV.GetRow(e.RowHandle).item("disc3") * (Total - (disk2 + disk1)) / 100
            End If
            If GV.GetRow(e.RowHandle).item("disc4").ToString <> "" Then
                disk4 = GV.GetRow(e.RowHandle).item("disc4") * (Total - (disk1 + disk2 + disk3)) / 100
            End If
            If GV.GetRow(e.RowHandle).item("disc5").ToString <> "" Then
                disk5 = GV.GetRow(e.RowHandle).item("disc5") * (Total - (disk1 + disk2 + disk3 + disk4 + disk5)) / 100
            End If
            GV.GetRow(e.RowHandle).item("potongan_total") = disk1 + disk2 + disk3 + disk4 + disk5
            GV.GetRow(e.RowHandle).Item("total") = GV.GetRow(e.RowHandle).Item("total") - GV.GetRow(e.RowHandle).Item("potongan_total")
        ElseIf e.Column.Name = "tglKirims" Then
            If GV.GetRowCellValue(e.RowHandle, "tgl_kirim") Is Nothing Then GV.SetRowCellValue(e.RowHandle, "tgl_kirim", e.Value)

        End If

    End Sub
    Sub cariPromo(ByVal e As Object)
        Exit Sub ' untuk sementara tidak dipakai karena dihandle oeh manajemen promo
        If cmbJenisSP.Text <> "UMUM" Then Exit Sub ' klau sp konsinyasi tidak pakai perhitungan promo.
        For Each rw In dsete.Tables("SOP").Select("seq_sp='" & e("No_Seq") & "'")
            rw.Delete()
        Next
        Dim dr As SqlDataReader
        dr = New SqlCommand("select * from sales.dbo.baranggetPromo('" & e.item("Kd_Stok") & "' , GETDATE()   , " & e.item("Qty") & " ,0)", sqlconn).ExecuteReader
        While dr.Read
            Dim rr As DataRow = dsete.Tables("SOP").NewRow
            rr("tipe_trans") = e.item("tipe_trans")
            rr("Kd_Cabang") = kdcabang
            rr("KD_PROMO") = dr("KDPROMO")
            rr("JML_POINT") = dr("jml_point")
            rr("CASHBACK") = dr("cash_back")
            rr("KD_BRG_BONUS") = dr("kd_brg_bonus")
            rr("KD_BRG_HADIAH") = dr("KD_BRG_HADIAH")
            rr("POTONGAN") = dr("potongan")
            rr("POTONGAN2") = dr("Potongan2")
            rr("No_Seq") = dr("NOSEQ")
            rr("QTY") = dr("free_qty")
            rr("KD_STOK") = e.item("Kd_Stok")
            rr("PROMONAME") = dr("PROMONAME")
            rr("PROMO_DESC") = dr("PROMODESC")
            rr("seq_sp") = e.item("No_seq")
            rr("Ambil") = "Y"
            If txtNomor.Text <> "" Then rr("NO_SP") = txtNomor.Text
            dsete.Tables("SOP").Rows.Add(rr)
        End While
        dr.Close()
        dr = Nothing
    End Sub
    Private Sub GV_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanging
        If e.Column Is Kd_Stok Then
            If e.RowHandle < 0 Then Exit Sub
            If GV.GetRow(e.RowHandle).item("Kd_Stok").ToString <> "" Then
                For Each rw In dsete.Tables("SODD").Select("kd_parent='" & GV.GetRow(e.RowHandle).item("Kd_Stok") & "'")
                    rw.Delete()
                Next
            End If
        End If
    End Sub
    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        If txtCustomer.EditValue = "" Then
            BeginInvoke(New MethodInvoker(AddressOf GV.CancelUpdateCurrentRow))
            GV.DeleteRow(e.RowHandle)
            DXEP.SetError(txtKodeCust, "Nama Customer Belum Diisi")
            txtCustomer.Focus()
            Exit Sub
        End If
        GV.SetRowCellValue(e.RowHandle, "ambil_bonus", "Y")
        GV.SetRowCellValue(e.RowHandle, "prioritas", "Umum")
        GV.GetRow(e.RowHandle).item("No_seq") = GV.RowCount
        GV.GetRow(e.RowHandle).item("set") = 0
    End Sub
    Private Sub GV_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub GV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Daftar Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar SP") = MsgBoxResult.Yes Then
                    GV.DeleteSelectedRows()
                End If
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            tglKirimMarketing.Focus()
        End If

    End Sub
    Private Sub GV_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV.RowUpdated
        'rw.Row.RowState

        If e.Row Is Nothing Then Exit Sub

        Dim hargadtl As Double = 0
        Dim potdtl As Double = 0
        Dim totdtl As Double = 0
        Dim disk1 As Double = 0
        Dim disk2 As Double = 0
        Dim disk3 As Double = 0
        Dim disk4 As Double = 0
        Dim disk5 As Double = 0

        If e.Row.item("set").ToString = "1" Then
            Dim Total As Double = 0
            Dim tbl As SqlDataReader = New SqlCommand("select * from sif.dbo.SIF_set_product_d where kd_set='" & e.Row.row.item("Kd_Stok") & "'", sqlconn).ExecuteReader
            Dim i As Integer = 0
            If tbl.HasRows Then
                For Each rw As DataRow In dsete.Tables("SODD").Select("kd_parent='" & e.Row.item("Kd_Stok") & "'")
                    rw.Delete()
                Next
                While tbl.Read
                    Dim rws As DataRow = dsete.Tables("SODD").NewRow

                    i += 1
                    Dim tbls As SqlDataReader = New SqlCommand("select b.Kd_Satuan, b.Nama_Barang, h.Harga_Dollar " & _
                                                               ",h.Harga_Rupiah, b.Kode_Barang , '0' as isset " & _
                                                               "from SIF.dbo.SIF_Barang as b, sif.dbo.sif_harga as h " & _
                                                               " where b.Kode_Barang='" & tbl.Item("KD_STOK") & "' and " & _
                                                               "b.Kode_Barang=h.Kode_Barang", sqlconn).ExecuteReader
                    tbls.Read()

                    rws.Item("Kd_Stok") = tbl.Item("Kd_Stok")
                    rws.Item("kd_parent") = e.Row.item("Kd_Stok")
                    rws.Item("No") = e.Row.item("No_seq")
                    rws.Item("No_seq") = e.Row.item("No_seq") & "." & i
                    rws.Item("Deskripsi") = tbls.Item("Nama_Barang")
                    rws.Item("No_sp") = txtNomor.Text
                    rws.Item("Kd_Satuan") = tbls.Item("Kd_Satuan")
                    rws.Item("Qty") = tbl.Item("Qty") * e.Row.item("Qty")
                    If vValas.EditValue = "IDR" Then
                        rws.Item("harga") = tbls("Harga_Rupiah")
                        rws.Item("total") = IIf(tbls("Harga_Rupiah").ToString = "", 0, tbls("Harga_Rupiah")) * IIf(rws.Item("Qty").ToString = "", 0, rws.Item("Qty"))
                        hargadtl += tbls("Harga_Rupiah")
                    Else
                        rws.Item("harga") = tbls("Harga_Dollar")
                        rws.Item("total") = IIf(tbls("Harga_Dollar").ToString = "", 0, tbls("Harga_Dollar")) * IIf(rws.Item("Qty").ToString = "", 0, rws.Item("Qty"))
                        hargadtl += tbls("Harga_Dollar")
                    End If
                    rws.Item("harga") = 0
                    rws.Item("total") = 0
                    hargadtl = 0
                    rws.Item("set") = 0


                    Dim read As SqlClient.SqlDataReader = New SqlCommand("select * from sif.dbo.SIF_Diskon_Kesepakatan where kd_customer='" & txtCustomer.EditValue & "'", sqlconn).ExecuteReader
                    read.Read()
                    If Not read.HasRows Then
                        read = New SqlCommand("select * from sif.dbo.SIF_Diskon_Reguler", sqlconn).ExecuteReader
                        read.Read()
                    End If
                    If read.HasRows Then
                        rws.Item("nama_potongan") = read.Item("Kd_Diskon")
                        If read.Item("Diskon1").ToString <> "" Then
                            rws.Item("disc1") = read.Item("Diskon1")
                        End If
                        If read.Item("Diskon2").ToString <> "" Then
                            rws.Item("disc2") = read.Item("Diskon2")
                        End If
                        If read.Item("Diskon3").ToString <> "" Then
                            rws.Item("disc3") = read.Item("Diskon3")
                        End If
                        If read.Item("Diskon4").ToString <> "" Then
                            rws.Item("disc4") = read.Item("Diskon4")
                        End If
                        If read.Item("Diskon5").ToString <> "" Then
                            rws.Item("disc5") = read.Item("Diskon5")
                        End If
                    End If
                    read.Close()
                    read = Nothing
                    If rws.Item("total").ToString = "" Then Exit Sub
                    Total = rws.Item("total")

                    If rws.Item("disc1").ToString <> "" Then
                        disk1 = rws.Item("disc1") * Total / 100
                    End If
                    If rws.Item("disc2").ToString <> "" Then
                        disk2 = rws.Item("disc2") * (Total - disk1) / 100
                    End If
                    If rws.Item("disc3").ToString <> "" Then
                        disk3 = rws.Item("disc3") * (Total - (disk2 + disk1)) / 100
                    End If
                    If rws.Item("disc4").ToString <> "" Then
                        disk4 = rws.Item("disc4") * (Total - (disk1 + disk2 + disk3)) / 100
                    End If
                    If rws.Item("disc5").ToString <> "" Then
                        disk5 = rws.Item("disc5") * (Total - (disk1 + disk2 + disk3 + disk4 + disk5)) / 100
                    End If
                    rws.Item("potongan_total") = disk1 + disk2 + disk3 + disk4 + disk5
                    rws.Item("potongan") = rws.Item("potongan_total") / e.Row("Qty")
                    potdtl += rws.Item("potongan_total")
                    rws.Item("total") = rws.Item("total") - rws.Item("potongan_total")
                    totdtl += rws.Item("total")

                    dsete.Tables("SODD").Rows.Add(rws)
                    tbls.Close()
                    tbls = Nothing
                End While
            Else
                For Each rws As DataRow In dsete.Tables("SODD").Select("kd_parent='" & e.Row.item("Kd_Stok") & "'")
                    rws("Qty") = e.Row.item("Qty")
                    Total = rws("harga") * rws("Qty")
                    If rws.Item("disc1").ToString <> "" Then
                        disk1 = rws.Item("disc1") * Total / 100
                    End If
                    If rws.Item("disc2").ToString <> "" Then
                        disk2 = rws.Item("disc2") * (Total - disk1) / 100
                    End If
                    If rws.Item("disc3").ToString <> "" Then
                        disk3 = rws.Item("disc3") * (Total - (disk2 + disk1)) / 100
                    End If
                    If rws.Item("disc4").ToString <> "" Then
                        disk4 = rws.Item("disc4") * (Total - (disk1 + disk2 + disk3)) / 100
                    End If
                    If rws.Item("disc5").ToString <> "" Then
                        disk5 = rws.Item("disc5") * (Total - (disk1 + disk2 + disk3 + disk4 + disk5)) / 100
                    End If
                    rws.Item("potongan_total") = disk1 + disk2 + disk3 + disk4 + disk5
                    rws.Item("potongan") = rws.Item("potongan_total") / e.Row("Qty")
                    potdtl += rws.Item("potongan_total")
                    rws.Item("total") = Total - rws.Item("potongan_total")
                    totdtl += rws.Item("total")
                Next
            End If

            tbl.Close()
            tbl = Nothing
            e.Row("harga") = hargadtl
            e.Row("total") = totdtl
            e.Row("potongan_total") = potdtl
        Else
            For Each rw As DataRow In dsete.Tables("SODD").Select("kd_parent='" & e.Row.item("Kd_Stok") & "'")
                rw.Delete()
            Next
        End If
        'untuk mencari promo per-item
        e.Row("potongan") = e.Row("potongan_total") / e.Row("Qty")

        Dim x() As DataRow = dsete.Tables("SOP").Select("seq_sp = '" & e.Row.row.item("No_seq") & "'")
        If x.Length = 0 Then
            e.Row.row.item("ambil_bonus") = Nothing
        End If
        If e.Row.row.RowState = DataRowState.Modified Then
            e.Row.row.item("state") = 2
        Else
            e.Row.row.item("state") = 1
        End If
    End Sub
    Private Sub GV_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        Dim isValid As Boolean = True
        If e.Row Is Nothing Then Exit Sub
        If e.Row.item("Kd_Stok").ToString = "" Then
            isValid = False
            GV.SetColumnError(Kd_Stok, "Harap Memilih Barang Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            GV.FocusedColumn = Kd_Stok
        End If
        If e.Row.item("tgl_kirim").ToString <> "" Then
            If e.Row.item("tgl_kirim") < Convert.ToDateTime(tglSO.Text) Then
                isValid = False
                GV.SetColumnError(tglKirims, "Tanggal janji Kirim Harus Lebih Besar dari Tanggal Order", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                GV.FocusedColumn = tglKirims
            End If
        End If
        If e.Row.item("Qty").ToString = "" Or Not IsNumeric(e.Row.item("Qty").ToString) Then
            isValid = False
            GV.SetColumnError(Qty, "Harap Mengisi Jumlah Kuantitas.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        ElseIf e.Row.item("Qty") <= 0 Then
            isValid = False
            GV.SetColumnError(Qty, "Harap Mengisi Jumlah Kuantitas Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("Deskripsi").ToString = "Item Not Found" Then
            isValid = False
            GV.SetColumnError(Kd_Stok, "Harap Mengisi Barang Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        e.Valid = isValid

    End Sub
    Public Sub edit_click()
        If Not Me.Controls("frmBukuOrder") Is Nothing Then Exit Sub
        If Not Me.Controls("frmStatusSP") Is Nothing Then Exit Sub
        tipetrans = SPKonsinyasi
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_sp as [Nomor], tgl_sp as [Tanggal], tipe_trans , [Nama_Customer] from sales.dbo.[VSO_REP] where tipe_trans ='" & tipetrans & "' and isnull(isClosed,'')<>'Y' order by tgl_sp  ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dsete.Tables("lookup_so") Is Nothing Then dsete.Tables("lookup_so").Clear()
        dadbe.Fill(dsete, "lookup_so")
        frmCari.set_dso(dsete.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.GV.Columns(2).Visible = False
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            Dim dr As SqlDataReader = New SqlCommand("select sales.dbo.isSoProccesed('" & txtNomor.Text & "') ", sqlconn).ExecuteReader
            dr.Read()
            If dr.Item(0) > 0 Then
                With prn
                    .btnAdd.Enabled = btnadd
                    .btnCancel.Enabled = btnCancel
                    .btnDelete.Enabled = btnDelete
                    .btnEdit.Enabled = btnEdit
                    .btnSave.Enabled = btnSave
                End With
                btnSave = True

            Else
                With prn
                    .btnAdd.Enabled = btnadd
                    .btnCancel.Enabled = btnCancel
                    .btnDelete.Enabled = btnDelete
                    .btnEdit.Enabled = btnEdit
                    .btnSave.Enabled = btnSave
                End With
                btnSave = True
            End If
            dr.Close()
            dr = Nothing
            btnadd = False
            btnEdit = False
            ONLOAD_STATE = True
            reload_table(frmCari.row(0), frmCari.row(2))
            ONLOAD_STATE = False
            State = "EDIT"
            If dsete.Tables("SO").Rows(0)("Status") <> "OK" Then lblStatus.Text = dsete.Tables("SO").Rows(0)("Status")
            btnCancel = True
            Me.Enabled = True

            If txtNomor.Text = "" Then
                MsgBox("Data SP Pelanggan Tidak Diketemukan", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Missing File")
                cancel_click()
            End If
            If txtNomor.Text.Length > 10 Then
                btnDelete = False
                btnSave = True
            End If
            setStatus()
        Else
            cancel_click()
            State = ""
        End If
    End Sub
    Public Sub add_click()
        'popCon.Show()
        If Not Me.Controls("frmBukuOrder") Is Nothing Then Exit Sub
        If Not Me.Controls("frmStatusSP") Is Nothing Then Exit Sub

        State = "ADD"
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
        txtCustomer.Focus()
    End Sub
    Public Sub cancel_click()
        If Not Me.Controls("frmBukuOrder") Is Nothing Then Exit Sub
        If Not Me.Controls("frmStatusSP") Is Nothing Then Exit Sub
        reload_table("XXX", "XXX")
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        State = ""

        setStatus()
        Me.Enabled = False
        txtCustomer.EditValue = vbNullString
        txtSales.EditValue = vbNullString
        tglKirimMarketing.EditValue = vbNullString
        tglSO.Text = getTanggal()
        txtCR.EditValue = 0
        txtAlamatKirim.Text = ""
        txtKeterangan.Text = ""
        txtNamaPnrm.Text = ""
        txtNomor.Text = ""
        reload_master()

    End Sub
    Sub reload_master()
        If Not dsete.Tables("CUSTOMER") Is Nothing Then dsete.Tables("CUSTOMER").Clear()
        If Not dsete.Tables("SALES") Is Nothing Then dsete.Tables("SALES").Clear()
        If Not dsete.Tables("VALAS") Is Nothing Then dsete.Tables("VALAS").Clear()
        If Not dsete.Tables("AREA") Is Nothing Then dsete.Tables("AREA").Clear()
        If Not dsete.Tables("WILAYAH") Is Nothing Then dsete.Tables("WILAYAH").Clear()
        If Not dsete.Tables("VBARANG") Is Nothing Then dsete.Tables("VBARANG").Clear()

        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer, Kd_Customer, Alamat1,Kd_Wilayah , Kode_Area, limit_piutang_rupiah CreditLimit from SIF.dbo.SIF_Customer where rec_stat='Y'  and Kd_Customer not in ('INTERNAL','UMUM') and isnull(depostatus,'')='Y' order by Nama_Customer", sqlconn))
       
        dadbe.Fill(dsete, "CUSTOMER")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Sales, Kode_Sales from SIF.dbo.SIF_Sales where 1=0 and rec_stat='Y'", sqlconn))
        dadbe.Fill(dsete, "SALES")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select [Kode_Valuta] ,[Nama_Valuta] FROM [SIF].[dbo].[SIF_Valuta] where [Rec_Stat]='Y'", sqlconn))
        dadbe.Fill(dsete, "VALAS")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * FROM [SIF].[dbo].[SIF_Area] where [Rec_Stat]='Y'", sqlconn))
        dadbe.Fill(dsete, "AREA")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Wilayah, Nama_Wilayah from sif.dbo.sif_wilayah where rec_stat='Y' ", sqlconn))
        dadbe.Fill(dsete, "WILAYAH")
        'dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select b.Kd_Satuan, b.Nama_Barang, 0 as Harga_Dollar , 0 as Harga_Rupiah, b.Kode_Barang , case kd_jenis when '038' then 1 when '039' then 1 else 0 end  as isset from SIF.dbo.SIF_Barang as b where  b.rec_stat='Y' and b.Kd_Depart = '" & kddep & "' and kd_jns_persd in ('1','2','3') order by Nama_Barang", sqlconn))
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select b.Kd_Satuan, b.Nama_Barang, 0 as Harga_Dollar , 0 as Harga_Rupiah, b.Kode_Barang , case kd_jenis when '038' then 1 when '039' then 1 else 0 end  as isset from SIF.dbo.SIF_Barang as b where  b.rec_stat='Y' and b.Kd_Depart in ('" & kddep & "','1') and kd_jns_persd in ('1','2','3') order by Nama_Barang", sqlconn))
        dadbe.Fill(dsete, "VBARANG")
    End Sub
    Public Sub delete_click()
        If Not Me.Controls("frmBukuOrder") Is Nothing Then Exit Sub
        If Not Me.Controls("frmStatusSP") Is Nothing Then Exit Sub

        If MsgBox("Hapus Data SO ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            State = "DELETE"
            If Not dsete.Tables("SOD") Is Nothing Then delete(dsete.Tables("SOD").Rows)
            If Not dsete.Tables("SODD") Is Nothing Then delete(dsete.Tables("SODD").Rows)
            If Not dsete.Tables("SODP") Is Nothing Then delete(dsete.Tables("SODP").Rows)
            If Not dsete.Tables("SO") Is Nothing Then delete(dsete.Tables("SO").Rows)

            save_click(True)
            cancel_click()
            State = ""
        End If
    End Sub
    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub
    Private Sub tglKirim_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tglKirimMarketing.EditValueChanged
        tglKirimMarketing.ErrorText = ""
    End Sub
    Private Sub txtAlamatKirim_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAlamatKirim.EditValueChanged
        DXEP.SetError(txtAlamatKirim, "")
    End Sub
    Public Sub cetak_click()
        If State = "EDIT" And txtNomor.Text.Length > 10 Then
            Try
                lblState.Capture = "PRINTING..."
                Dim i As Int16 = New SqlCommand("update sales.dbo.sales_so set cetakke= isnull(CetakKe,0)+1, isPrinted='Y' where no_sp='" & txtNomor.Text & "' and isnull(isprinted,'') <> 'Y' ", sqlconn).ExecuteNonQuery
                If i > 0 Then
                    callReport(App_Path() & "\report\vSo.rpt", "", "PSO=" & txtNomor.Text, True, True)
                Else
                    MsgBox("Dokumen SP Sudah Pernah Dicetak ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Perhatian")
                End If
                lblState.Text = "[IDLE]"
            Catch e As Exception
                MsgBox("Gagal Cetak " & e.Message)
                lblState.Capture = "[IDLE]"
            End Try
        End If
    End Sub
    Private Sub GV_MasterRowGetLevelDefaultView(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs) Handles GV.MasterRowGetLevelDefaultView
        rhandel = e.RowHandle
    End Sub
    Private Sub txtCustomer_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles txtCustomer.EditValueChanging
        If ONLOAD_STATE Then Exit Sub
        If State = "" Then Exit Sub
        If GV.RowCount > 1 And Not e.NewValue Is Nothing Then
            If MessageBox.Show("Mengganti Customer Akan Menghapus Daftar SP" & vbCrLf & "Ganti Customer ?", "Peringatan", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = Windows.Forms.DialogResult.Cancel Then
                e.Cancel = True
            Else
                If Not dsete.Tables("SOD") Is Nothing Then dsete.Tables("SOD").Clear()
                If Not dsete.Tables("SODD") Is Nothing Then dsete.Tables("SODD").Clear()
            End If
        End If
    End Sub
    Private Sub txtCustomer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCustomer.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtSales.Focus()
        End If
    End Sub
    Private Sub txtCustomer_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtCustomer.QueryPopUp
        If State <> "ADD" Then
            e.Cancel = True
            showMessages("Tidak Dapat Mengubah Customer")
        End If
    End Sub
    Private Sub txtSales_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSales.KeyDown
        If e.KeyCode = Keys.Enter Then
            GV.Focus()
            GV.AddNewRow()
        End If
    End Sub
    Private Sub txtSales_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSales.QueryPopUp
        If State <> "ADD" Then
            e.Cancel = True
            showMessages("Tidak Dapat Mengubah Sales")
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

        txtCR.EditValue = 0
        lblStateCR.Text = ""
        tglKirimMarketing.EditValue = Nothing
        tglKirim.EditValue = Nothing
        txtAlamatKirim.Text = ""
        cmdWilayah.EditValue = Nothing
        txtNamaPnrm.Text = ""
        txtKeterangan.Text = ""
        If cmbJenisSP.Text = "KONSINYASI" Then
            cmbJenisSP.Properties.Appearance.BackColor = Color.Yellow
        ElseIf InStr("INTERNAL", cmbJenisSP.Text, CompareMethod.Text) > 0 Then
            cmbJenisSP.Properties.Appearance.BackColor = Color.GreenYellow
        Else
            cmbJenisSP.Properties.Appearance.BackColor = Color.White
        End If

        ' txtcari.AutoCompleteCustomSource.Clear()
        ' txtcari.AutoCompleteCustomSource.AddRange((From row As Object In dsete.Tables("VBARANG").Rows.Cast(Of DataRow)() Select CStr(row("Nama_Barang"))).ToArray())
    End Sub
    Private Sub tglKirim_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tglKirimMarketing.KeyDown
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
    Private Sub txtKeterangan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            prn.btnSave.Focus()
        End If
    End Sub
    Private Sub gvCari_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvCari.DoubleClick
        If gvCari.GetSelectedRows.Count > 0 Then
            If popCon.Tag = "GV" Then
                If GV.GetRowCellValue(GV.GetSelectedRows(0), "Kd_Stok") Is Nothing Then
                    SendKeys.Send(gvCari.GetRowCellValue(gvCari.GetSelectedRows(0), "Kode_Barang"))
                    SendKeys.Send(vbCrLf)
                Else
                    GV.SetRowCellValue(GV.GetSelectedRows(0), "Kd_Stok", gvCari.GetRowCellValue(gvCari.GetSelectedRows(0), "Kode_Barang"))
                End If
                popCon.Hide()
                GV.Focus()
            Else
                Dim x As Object = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Grid.GridView)
                If x.GetRowCellValue(x.GetSelectedRows(0), "Kd_Stok") Is Nothing Then
                    SendKeys.Send(gvCari.GetRowCellValue(gvCari.GetSelectedRows(0), "Kode_Barang"))
                Else
                    x.SetRowCellValue(x.GetSelectedRows(0), "Kd_Stok", gvCari.GetRowCellValue(gvCari.GetSelectedRows(0), "Kode_Barang"))
                End If
                popCon.Hide()
                x.Focus()
            End If
        End If
    End Sub
    Private Sub txtcari_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            gvCari.Columns("Nama_Barang").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Value, "Nama_Barang Like '%" & txtcari.Text & "%'")
        ElseIf e.KeyCode = Keys.Escape Then
            popCon.Hide()
        End If
    End Sub
    Private Sub gvCari_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gvCari.KeyDown
        If e.KeyCode = Keys.Enter Then
            gvCari_DoubleClick(sender, New EventArgs)
        ElseIf e.KeyCode = Keys.Escape Then
            popCon.Hide()
        End If
    End Sub
    Private Sub repDes_ButtonPressed(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repDes.ButtonPressed
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
    Private Sub repDes_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles repDes.QueryPopUp
        If GV.FocusedValue Is Nothing Then e.Cancel = True
    End Sub
    Private Sub txtCR_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCR.EditValueChanged
        If txtCR.EditValue < 0 Then
            txtCR.Properties.Appearance.ForeColor = Color.Red
            lblStateCR.Text = "Credit Limit Melampuhi Batas"
        Else
            txtCR.Properties.Appearance.ForeColor = Color.Black
            lblStateCR.Text = ""
        End If
    End Sub

    Private Sub vValas_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles vValas.EditValueChanged
        If ONLOAD_STATE Then Exit Sub
        If vValas.EditValue = "IDR" Then
            txtKurs.Text = "1"
        Else
            txtKurs.Text = ""
        End If
    End Sub
    Private Sub vValas_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles vValas.EditValueChanging
        If ONLOAD_STATE Then Exit Sub
        If GV.RowCount > 1 Then
            If MessageBox.Show("Mengganti Valas Akan Menghapus Daftar SP" & vbCrLf & "Ganti Valas ?", "Peringatan", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = Windows.Forms.DialogResult.Cancel Then
                e.Cancel = True
            Else
                If Not dsete.Tables("SOD") Is Nothing Then dsete.Tables("SOD").Clear()
                If Not dsete.Tables("SODD") Is Nothing Then dsete.Tables("SODD").Clear()
                If Not dsete.Tables("SOP") Is Nothing Then dsete.Tables("SOP").Clear()
            End If
        End If
    End Sub
    Private Sub vValas_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles vValas.QueryPopUp
        If GV.RowCount > 1 Then
            If State = "ADD" Then
                showMessages("Valas Tidak Bisa Dirubah", , "WARNING")
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub txtKurs_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKurs.GotFocus
        If vValas.EditValue = "IDR" Then
            txtKurs.Properties.ReadOnly = True
        Else
            txtKurs.Properties.ReadOnly = False
        End If
    End Sub
    Private Sub repPopD_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repPopD.ButtonClick

        popCon.Show()
    End Sub
    Private Sub GV_MasterRowExpanded(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs) Handles GV.MasterRowExpanded
        If GV.GetDetailView(e.RowHandle, 0) Is Nothing Then Exit Sub
        If GV.GetRowCellValue(e.RowHandle, "set") = 1 Then
            CType(GV.GetDetailView(e.RowHandle, 0), DevExpress.XtraGrid.Views.Grid.GridView).OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Else
            CType(GV.GetDetailView(e.RowHandle, 0), DevExpress.XtraGrid.Views.Grid.GridView).OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
        End If
    End Sub
    Private Sub RepPop_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles RepPop.ButtonClick
        popCon.Show()
    End Sub
    Private Sub RepPop_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles RepPop.QueryPopUp
        repPopD.PopupControl = Nothing
        RepPop.PopupControl = popCon
        gcCari.DataSource = ""
        txtcari.Text = ""
        popCon.Tag = "GVD"
        'gcCari.DataSource = dsete.Tables("VBARANG")
        gvCari.Columns("Nama_Barang").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Value, "Nama_Barang = ''")
    End Sub
    Private Sub repPopD_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles repPopD.QueryPopUp
        RepPop.PopupControl = Nothing
        repPopD.PopupControl = popCon
        kriteria = Mid(GV.GetRowCellValue(rhandel, "Kd_Stok"), 6, 17)
        clone = New DataView(dsete.Tables("VBARANG"))
        clone.RowFilter = "substring(kode_barang,6,17)= '" & kriteria & "' and isset=0"
        gcCari.DataSource = clone

    End Sub
    Private Sub GVD_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GVD.CellValueChanged
        Dim x As Object = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim qty As Integer = GV.GetRowCellValue(rhandel, "Qty")
        If e.Column.Name = "Kd_StokD" Then
            Dim drows As DataRow() = dsete.Tables("VBARANG").Select("Kode_Barang='" & e.Value & "'")
            If drows.Count = 0 Then
                x.GetRow(e.RowHandle).item("Deskripsi") = "Item Not Found"
                Exit Sub
            End If

            Dim rw As DataRow
            x.GetRow(e.RowHandle).item("Deskripsi") = "Item Not Found"
            x.GetRow(e.RowHandle).item("Qty") = qty
           
            rw = drows(0)
            x.GetRow(e.RowHandle).item("Deskripsi") = rw("Nama_Barang")
            x.GetRow(e.RowHandle).item("Kd_satuan") = rw("Kd_Satuan")

            If vValas.EditValue = "IDR" Then
                x.GetRow(e.RowHandle).item("harga") = rw("Harga_Rupiah")
                x.GetRow(e.RowHandle).item("total") = IIf(rw("Harga_Rupiah").ToString = "", 0, rw("Harga_Rupiah")) * IIf(x.GetRow(e.RowHandle).item("Qty").ToString = "", 0, x.GetRow(e.RowHandle).item("Qty"))
            Else
                x.GetRow(e.RowHandle).item("harga") = rw("Harga_Dollar")
                x.GetRow(e.RowHandle).item("total") = IIf(rw("Harga_Dollar").ToString = "", 0, rw("Harga_Dollar")) * IIf(x.GetRow(e.RowHandle).item("Qty").ToString = "", 0, x.GetRow(e.RowHandle).item("Qty"))
            End If
            x.GetRow(e.RowHandle).item("total") = 0
            x.GetRow(e.RowHandle).item("potongan") = 0

            If cmbJenisSP.Text = "INTERNAL" Then Exit Sub

            Dim read As SqlClient.SqlDataReader
            read = New SqlCommand("select r.* FROM dbo.SIF_Barang B, dbo.SIF_Diskon_kesepakatan R where " & _
                                  " b.kd_merk = r.KD_MERK And Kode_Barang ='" & e.Value & "' and kd_customer='" & txtCustomer.EditValue & "' and getdate() between start_date and end_date", sqlconn).ExecuteReader
            read.Read()
            If Not read.HasRows Then
                read = New SqlCommand("select r.* FROM dbo.SIF_Barang B, dbo.SIF_Diskon_Reguler R where " & _
                                      " b.kd_merk = r.KD_MERK and Kode_Barang ='" & e.Value & "' ", sqlconn).ExecuteReader
                read.Read()
            End If
            If read.HasRows Then
                x.GetRow(e.RowHandle).item("nama_potongan") = read.Item("Kd_Diskon")
                If read.Item("Diskon1").ToString <> "" Then
                    x.GetRow(e.RowHandle).item("disc1") = read.Item("Diskon1")
                End If
                If read.Item("Diskon2").ToString <> "" Then
                    x.GetRow(e.RowHandle).item("disc2") = read.Item("Diskon2")
                End If
                If read.Item("Diskon3").ToString <> "" Then
                    x.GetRow(e.RowHandle).item("disc3") = read.Item("Diskon3")
                End If
                If read.Item("Diskon4").ToString <> "" Then
                    x.GetRow(e.RowHandle).item("disc4") = read.Item("Diskon4")
                End If
                If read.Item("Diskon5").ToString <> "" Then
                    x.GetRow(e.RowHandle).item("disc5") = read.Item("Diskon5")
                End If
            End If
            read.Close()
            read = Nothing


            If x.GetRow(e.RowHandle).item("harga").ToString = "" Then Exit Sub
            If e.Value.ToString = "" Then Exit Sub
            If e.Value = 0 Then Exit Sub

            Dim Total As Double
            x.GetRow(e.RowHandle).item("total") = x.GetRow(e.RowHandle).item("harga") * qty
            Total = x.GetRow(e.RowHandle).item("total")

            Dim disk1 As Double = 0
            Dim disk2 As Double = 0
            Dim disk3 As Double = 0
            Dim disk4 As Double = 0
            Dim disk5 As Double = 0
            If Total = 0 Then Exit Sub
            If x.GetRow(e.RowHandle).item("disc1").ToString <> "" Then
                disk1 = x.GetRow(e.RowHandle).item("disc1") * Total / 100
            End If
            If x.GetRow(e.RowHandle).item("disc2").ToString <> "" Then
                disk2 = x.GetRow(e.RowHandle).item("disc2") * (Total - disk1) / 100
            End If
            If x.GetRow(e.RowHandle).item("disc3").ToString <> "" Then
                disk3 = x.GetRow(e.RowHandle).item("disc3") * (Total - (disk2 + disk1)) / 100
            End If
            If x.GetRow(e.RowHandle).item("disc4").ToString <> "" Then
                disk4 = x.GetRow(e.RowHandle).item("disc4") * (Total - (disk1 + disk2 + disk3)) / 100
            End If
            If x.GetRow(e.RowHandle).item("disc5").ToString <> "" Then
                disk5 = x.GetRow(e.RowHandle).item("disc5") * (Total - (disk1 + disk2 + disk3 + disk4 + disk5)) / 100
            End If
            x.GetRow(e.RowHandle).item("potongan_total") = disk1 + disk2 + disk3 + disk4 + disk5
            x.GetRow(e.RowHandle).Item("total") = x.GetRow(e.RowHandle).Item("total") - x.GetRow(e.RowHandle).Item("potongan_total")
        End If
    End Sub
    Private Sub GVD_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GVD.InitNewRow
        Dim x As Grid.GridView = CType(GC.FocusedView, Grid.GridView)
        x.SetRowCellValue(e.RowHandle, "No_seq", x.RowCount)
    End Sub
    Private Sub GVD_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GVD.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub GVD_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GVD.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim GVS As Grid.GridView = CType(GC.FocusedView, Grid.GridView)
            Dim i As Int16 = 1
            If GVS.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Daftar Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar SP") = MsgBoxResult.Yes Then
                    GVS.DeleteSelectedRows()
                    For Each rw As DataRow In dsete.Tables("SODD").Select("kd_parent = '" & GV.GetRowCellValue(rhandel, "Kd_Stok") & "'")
                        rw("no_seq") = i
                        i += 1
                    Next
                    GV.SetRowCellValue(rhandel, "potongan", CType(GC.FocusedView, Grid.GridView).Columns("potongan").SummaryText)
                    GV.SetRowCellValue(rhandel, "total", CType(GC.FocusedView, Grid.GridView).Columns("total").SummaryText)
                End If
            End If
        End If
    End Sub
    Private Sub GVD_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GVD.RowUpdated
        GV.SetRowCellValue(rhandel, "potongan", CType(GC.FocusedView, Grid.GridView).Columns("potongan").SummaryText)
        GV.SetRowCellValue(rhandel, "total", CType(GC.FocusedView, Grid.GridView).Columns("total").SummaryText)
    End Sub
    Private Sub GVD_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GVD.ValidateRow
        Dim isValid As Boolean = True
        Dim GVS As Object = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Grid.GridView)
        If e.Row Is Nothing Then Exit Sub
        If e.Row.item("Kd_Stok").ToString = "" Then
            isValid = False
            GVS.SetColumnError(Kd_StokD, "Harap Memilih Barang Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            GVS.FocusedColumn = Kd_Stok
        End If
        If e.Row.item("Deskripsi").ToString = "Item Not Found" Then
            isValid = False
            GVS.SetColumnError(Kd_StokD, "Harap Mengisi Barang Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        Dim rw() As DataRow = dsete.Tables("SODD").Select("Kd_Stok = '" & e.Row.item("Kd_Stok") & "' and kd_parent = '" & e.Row.item("kd_parent") & "'")
        If rw.Count = 1 Then
            If Not rw(0) Is e.Row.row Then
                isValid = False
                GVS.SetColumnError(GVS.Columns("Kd_Stok"), "Kode Barang Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If
        e.Valid = isValid
    End Sub
    Private Sub repDel_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repDel.ButtonClick
        If GV.GetSelectedRows.Count > 0 Then
            Dim i As Int16 = 1
            If GV.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Daftar Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar SP") = MsgBoxResult.Yes Then

                    GV.DeleteSelectedRows()
                    For Each rw As DataRow In dsete.Tables("SODD").Select("kd_parent = '" & GV.GetRowCellValue(rhandel, "Kd_Stok") & "'")
                        rw("no_seq") = i
                        i += 1
                    Next
                End If
            End If
        End If
    End Sub
    Private Sub tglKirimMarketing_QueryCloseUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles tglKirimMarketing.QueryCloseUp
        If tglKirim.EditValue Is Nothing Then
            tglKirim.EditValue = sender.editvalue
        ElseIf tglKirim.EditValue.ToString = "" Then
            tglKirim.EditValue = sender.editvalue
        End If
    End Sub
    Private Sub txtcari_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcari.KeyDown
        If e.KeyCode = Keys.Enter Then
            gcCari.DataSource = dsete.Tables("VBARANG")
            gvCari.Columns("Nama_Barang").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Value, "Nama_Barang Like '%" & txtcari.Text & "%'")
            If gvCari.RowCount = 1 Then
                gvCari.Focus()
                gvCari_DoubleClick(gvCari, New EventArgs)
            End If
        ElseIf e.KeyCode = Keys.Escape Then
            popCon.Hide()
        End If
    End Sub
  
    Private Sub repNum_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs)
        If e.OldValue Is Nothing Then Exit Sub
    End Sub
End Class