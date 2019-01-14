Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms

Public Class frmRetur
    Dim dsete, dsete2 As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA As SqlDataAdapter
    Dim DAD As SqlDataAdapter
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean
    Public btnadd As Boolean
    Public btnCancel As Boolean
    Public btnDelete As Boolean
    Public btnCetak As Boolean
    Public btnEdit As Boolean
    Public State As String
    Public ONLOAD_STATE As Boolean
    Dim myBuilder As New SqlCommandBuilder
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
    Private Sub refreshNomer(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim j As Int16 = 1
        If State = "DELETE" Then Exit Sub
        For Each rw As DataRow In sender.Rows
            If rw.RowState <> DataRowState.Deleted Then
                For Each rwd As DataRow In dsete.Tables("SALES_RETUR_D").Rows
                    rwd("No_seq") = j
                    j += 1
                Next
            End If
        Next
    End Sub
    Public Sub add_click()
        State = "ADD"
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        cmbJenisSP.Text = "UMUM"
        setStatus()
    End Sub
    Private Sub reloadTable(ByVal kode As String)
        If Not dsete.Tables("SALES_RETUR") Is Nothing Then dsete.Tables("SALES_RETUR").Clear()
        If Not dsete.Tables("SALES_RETUR_D") Is Nothing Then dsete.Tables("SALES_RETUR_D").Clear()
        Dim sql As String
        DAD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, isnull(harga*qty - potongan_total,0) total from Sales.dbo.SALES_RETUR_D where No_retur='" & kode & "'", sqlconn))
        DAD.Fill(dsete, "SALES_RETUR_D")
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from Sales.dbo.SALES_RETUR where No_retur='" & kode & "'", sqlconn))
        DA.Fill(dsete, "SALES_RETUR")
        If dsete.Tables("SALES_RETUR").Rows.Count > 0 Then
            With dsete.Tables("SALES_RETUR").Rows(0)
                txtKeterangan.Text = .Item("Keterangan").ToString
                txtNomor.Text = .Item("No_retur").ToString
                tglRetur.Text = .Item("Tgl_retur").ToString
                txtCustomer.EditValue = .Item("Kd_Customer").ToString
                txtKodeCust.EditValue = .Item("Kd_Customer").ToString
                txtRef1.EditValue = .Item("No_ref1").ToString
                txtRef2.Text = .Item("No_ref2").ToString
                cmbJenisSP.Text = .Item("Jenis_Retur").ToString
                txtNamaAgen.Text = txtCustomer.Text
                txtAlamatAgen.Text = .Item("Almt_agen").ToString
                tglTarik.EditValue = .Item("Tgl_tarik").ToString
            End With
            lblTotal.EditValue = dsete.Tables("SALES_RETUR_D").Compute("SUM(total)", "")
            sql = "select * FROM sales.dbo.v_retur_gudang where tipe_trans='" & ReturGudangIn & "' and  no_trans='" & txtRef1.Text & "'"
        Else
            txtCustomer.EditValue = Nothing
            txtKeterangan.Text = ""
            txtNomor.Text = ""
            tglRetur.Text = ""
            txtKodeCust.EditValue = Nothing
            txtRef1.EditValue = Nothing
            cmbJenisSP.Text = "UMUM"
            txtRef2.Text = ""
            txtNamaAgen.Text = ""
            txtAlamatAgen.Text = ""
            tglTarik.EditValue = Nothing
            sql = "select a.* FROM sales.dbo.v_retur_gudang a where a.tipe_trans='" & ReturGudangIn & "' and no_qc like '%RTR%'"
            lblTotal.EditValue = 0
        End If
        If Not dsete.Tables("RETUR") Is Nothing Then dsete.Tables("RETUR").Clear()
        dadbe = New SqlClient.SqlDataAdapter(sql, sqlconn)
        dadbe.Fill(dsete, "RETUR")
        txtRef1.Properties.DataSource = dsete.Tables("RETUR")
    End Sub
    Private Sub frmRetur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Nama_Customer, Kd_Customer, Alamat1 from SIF.dbo.SIF_Customer where rec_stat='Y'", sqlconn))
        dadbe.Fill(dsete, "CUSTOMER")
        DT_TglSO.EditValue = getTanggal()
        Dim sqlcmd As New SqlCommand("select  b.Kd_Satuan, b.Nama_Barang, h.Harga_Dollar ,h.Harga_Rupiah, " & _
                " b.Kode_Barang , case kd_jenis when '038' then 1 when '039' then 1 else 0 end  as isset " & _
                " from SIF.dbo.SIF_Barang as b inner join sif.dbo.sif_harga as h on b.Kode_Barang=h.Kode_Barang " & _
                " inner join ( select kode_barang, max(start_date) start_date from  sif.dbo.sif_harga group by kode_barang ) h2 on h2.Kode_Barang=h.Kode_Barang and h2.Start_Date = h.Start_Date " & _
                " where b.rec_stat='Y' and b.kd_jns_persd in ('1','2','3') and @tgl >= h.start_date order  by Nama_Barang", sqlconn)
        sqlcmd.Parameters.Add("@tgl", SqlDbType.Date)
        sqlcmd.Parameters("@tgl").Value = DT_TglSO.EditValue
        dadbe = New SqlClient.SqlDataAdapter(sqlcmd)
        dadbe.Fill(dsete, "VBARANG")

        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Unit as Kd_Satuan, NAMA as Nama_Barang, 0 as Harga_Dollar , 0 as Harga_Rupiah, KD_SET as Kode_Barang, '1' as isset from SIF.dbo.SIF_SET_PRODUCT where Kd_Departemen='" & kddep & "'", sqlconn))
        dadbe.Fill(dsete, "VBARANG")

        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Id_Data, Desc_Data from [SIF].[dbo].[SIF_Gen_Reff_D] where [Id_Ref_File]='JNSRTR'  and [Id_Ref_Data] = 'JNSRTR' ", sqlconn))
        dadbe.Fill(dsete, "JNSRTR")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Id_Data, Desc_Data from [SIF].[dbo].[SIF_Gen_Reff_D] where [Id_Ref_File]='ALSNRTR'  and [Id_Ref_Data] = 'ALSNRTR' ", sqlconn))
        dadbe.Fill(dsete, "ALSNRTR")

        txtCustomer.Properties.DataSource = dsete.Tables("CUSTOMER")
        txtCustomer.Properties.DisplayMember = "Nama_Customer"
        txtCustomer.Properties.ValueMember = "Kd_Customer"

        repBarang.DataSource = dsete.Tables("VBARANG")
        repJNSRTR.DataSource = dsete.Tables("JNSRTR")
        repALSNRTR.DataSource = dsete.Tables("ALSNRTR")
        reloadTable("xxx")
        GC.DataSource = dsete.Tables("SALES_RETUR_D")
        State = "ADD"
        DT_TglSO.EditValue = getTanggal()
        DT_TglSO.Properties.MaxValue = DT_TglSO.EditValue
        prn = frmMain
        AddHandler dsete.Tables("SALES_RETUR_D").RowDeleted, AddressOf refreshNomer
        btnadd = True
        btnEdit = True
        setStatus()
    End Sub
    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim row As DataRow
        Dim BTRANS As SqlTransaction

        If Not isDelete Then
            If txtCustomer.EditValue = "" Then
                showMessages("Nama Customer Belum Diisi", "WARNING")
                txtCustomer.Focus()
                Exit Sub
            End If
            If txtRef1.EditValue = "" Then
                showMessages("Nomor Referensi Belum Diisi", "WARNING")
                txtRef1.Focus()
                Exit Sub
            End If

            If GV.RowCount = 0 Then
                showMessages("Daftar Barang Masih Kosong", "WARNING")
                GV.Focus()
                Exit Sub
            End If
        End If
        'With New SqlCommand("select * from [FIN].[dbo].[FIN_JURNAL] where no_ref1='" & txtNomor.Text & "' and not no_posting is null", sqlconn).ExecuteReader
        '    If .HasRows Then
        '        MsgBox("Data Sudah Di Posting", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
        '        cancel_click()

        '        Exit Sub
        '    End If
        '    .Close()
        'End With
        If Not isDelete Then
            If State = "ADD" Then              
                row = dsete.Tables("SALES_RETUR").NewRow
                row.Item("Last_Create_Date") = getTanggal()
                row.Item("Last_Created_By") = username
                If kddep = KD_DIV_SPRING Then
                    row.Item("Tipe_trans") = ReturSpringUmum
                Else
                    row.Item("Tipe_trans") = ReturSponUmum
                End If
            ElseIf State = "EDIT" Then
                row = dsete.Tables("SO").Rows(0)
                row.Item("Last_Update_Date") = getTanggal()
                row.Item("Last_Updated_By") = username
            End If
            row.Item("Kd_Cabang") = kdcabang
            row.Item("Tgl_retur") = tglRetur.Text
            row.Item("Jenis_Retur") = cmbJenisSP.Text
            row.Item("No_ref1") = txtRef1.Text
            row.Item("No_ref2") = txtRef2.Text
            row.Item("Kd_Customer") = txtCustomer.EditValue
            row.Item("Nama_agen") = txtNamaAgen.Text
            row.Item("Almt_agen") = txtAlamatAgen.Text
            ' row.Item("Tgl_tarik") = tglTarik.EditValue
            row.Item("Keterangan") = txtKeterangan.Text
            row.Item("departemen") = kddep
            row.Item("Status") = "OK"
            row.Item("Program_Name") = Me.Name

           
            Dim a As Integer = 1
            For Each rows As DataRow In dsete.Tables("SALES_RETUR_D").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("Last_Create_Date") = row.Item("Tgl_retur")
                    rows.Item("Last_Created_By") = username
                    rows.Item("kd_Cabang") = kdcabang
                    rows.Item("tipe_trans") = row.Item("Tipe_trans")
                    rows.Item("no_retur") = txtNomor.Text
                    rows.Item("Status") = "OK"
                    If kddep = KD_DIV_SPRING Then
                        row.Item("tipe_trans") = ReturSpringUmum
                    Else
                        row.Item("tipe_trans") = ReturSponUmum
                    End If
                    rows.Item("departemen") = kddep
                    rows.Item("Programe_name") = Me.Name
                ElseIf rows.RowState <> DataRowState.Deleted Then
                    rows.Item("Last_Update_Date") = getTanggal()
                    rows.Item("Last_Updated_By") = username
                    rows.Item("Programe_name") = Me.Name
                End If

            Next
        Else
            For i As Int16 = 0 To dsete.Tables("SALES_RETUR_D").Rows.Count - 1
                dsete.Tables("SALES_RETUR_D").Rows.RemoveAt(0)
            Next
            'For Each rows As DataRow In dsete.Tables("SALES_RETUR_D").Rows
            '    If rows.RowState <> DataRowState.Deleted Then
            '        rows.Delete()
            '    End If
            'Next
            For Each rows As DataRow In dsete.Tables("SALES_RETUR").Rows
                If rows.RowState <> DataRowState.Deleted Then
                    rows.Delete()
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

            BTRANS = sqlconn.BeginTransaction("1")
            If State = "ADD" Then
                row.Item("No_retur") = getNoTrans("SPRTR", getTanggal(BTRANS), BTRANS)
                txtNomor.Text = row.Item("No_retur")
               
                For Each rows As DataRow In dsete.Tables("SALES_RETUR_D").Rows
                    If rows.RowState = DataRowState.Added Then
                        rows.Item("No_retur") = txtNomor.Text
                    End If
                Next
                dsete.Tables("SALES_RETUR").Rows.Add(row)
            End If

            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            DAD.UpdateCommand.Transaction = BTRANS
            DAD.InsertCommand.Transaction = BTRANS
            DAD.DeleteCommand.Transaction = BTRANS

            dsete2 = dsete.Clone
            dsete2 = dsete.Copy

            DA.Update(dsete.Tables("SALES_RETUR"))
            DAD.Update(dsete.Tables("SALES_RETUR_D"))
            If Not isDelete Then
                Dim sqlcmd As New SqlCommand
                sqlcmd.Connection = sqlconn
                sqlcmd.Transaction = BTRANS
                sqlcmd.CommandType = CommandType.StoredProcedure
                sqlcmd.CommandText = "FIN.dbo.FIN_AUTOMAN_JURNAL"
                sqlcmd.Parameters.Add("@tipe_trans", SqlDbType.VarChar, 30)
                sqlcmd.Parameters.Add("@no_inv", SqlDbType.VarChar, 30)
                sqlcmd.Parameters("@tipe_trans").Value = row.Item("Tipe_trans")
                sqlcmd.Parameters("@no_inv").Value = txtNomor.Text
                sqlcmd.ExecuteNonQuery()
            Else
                With New SqlCommand("delete from [FIN].[dbo].[FIN_JURNAL] where no_ref1='" & txtNomor.Text & "' and no_posting is null", sqlconn, BTRANS).ExecuteNonQuery
                    If .ToString <> "0" Then
                        With New SqlCommand("delete from [FIN].[dbo].[FIN_JURNAL_D] where no_ref1='" & txtNomor.Text & "'", sqlconn, BTRANS).ExecuteNonQuery

                        End With
                        txtNomor.Text = ""
                        isDelete = False
                    Else
                        BTRANS.Rollback()
                        MsgBox("Data Tidak Diketemukan Atau Sudah Posting", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Warning")
                        cancel_click()
                        Exit Sub
                    End If
                End With
            End If
            State = "EDIT"
            BTRANS.Commit()

            showMessages("Data Telah Diproses")
            reloadTable(txtNomor.Text)
            btnSave = True
            btnadd = False
            btnEdit = False
            btnCancel = True
            btncetak = True
            btnDelete = True
            setStatus()
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
            GV.GetRow(e.RowHandle).item("Kd_satuan") = rw("Kd_Satuan")
            Dim drows As DataRow() = dsete.Tables("VBARANG").Select("Kode_Barang='" & e.Value & "'")
            If drows.Count = 0 Then
                GV.GetRow(e.RowHandle).item("Deskripsi") = "Item Not Found"
                Exit Sub
            End If

            GV.GetRow(e.RowHandle).item("qty") = 0
            GV.GetRow(e.RowHandle).item("total") = 0
            GV.GetRow(e.RowHandle).item("potongan_total") = 0

            rw = drows(0)
            GV.GetRow(e.RowHandle).item("Kd_satuan") = rw("Kd_Satuan")


            GV.GetRow(e.RowHandle).item("harga") = rw("Harga_Rupiah")
            GV.GetRow(e.RowHandle).item("total") = IIf(rw("Harga_Rupiah").ToString = "", 0, rw("Harga_Rupiah")) * IIf(GV.GetRow(e.RowHandle).item("Qty").ToString = "", 0, GV.GetRow(e.RowHandle).item("Qty"))



            Dim read As SqlClient.SqlDataReader
            read = New SqlCommand("select r.* FROM dbo.SIF_Barang B, dbo.SIF_Diskon_kesepakatan R where " & _
                                  " b.kd_merk = r.KD_MERK And Kode_Barang ='" & e.Value & "' and kd_customer='" & txtCustomer.EditValue & "' and getdate() between start_date and end_date and kd_tipe like kode_tipe and kd_ukuran like kode_ukuran", sqlconn).ExecuteReader
            read.Read()
            If Not read.HasRows Then
                read = New SqlCommand("select r.* FROM dbo.SIF_Barang B, dbo.SIF_Diskon_Reguler R where " & _
                                      " b.kd_jenis like r.kd_jenis and b.kd_merk = r.KD_MERK and b.kd_ukuran like  r.Ukuran  and b.kd_tipe=r.kode_tipe and Kode_Barang ='" & e.Value & "' order by kd_jenis, Ukuran desc", sqlconn).ExecuteReader
                read.Read()
            End If
            Dim ptotal As Double
            If read.HasRows Then
                GV.GetRow(e.RowHandle).item("nama_potongan") = read.Item("Kd_Diskon")
                If read.Item("Diskon1").ToString <> "" Then
                    ptotal = rw("Harga_Rupiah") * read.Item("Diskon1") / 100
                End If
                If read.Item("Diskon2").ToString <> "" Then
                    ptotal = ptotal + (rw("Harga_Rupiah") - ptotal) * read.Item("Diskon2") / 100
                End If
                If read.Item("Diskon3").ToString <> "" Then
                    ptotal = ptotal + (rw("Harga_Rupiah") - ptotal) * read.Item("Diskon3") / 100
                End If
                If read.Item("Diskon4").ToString <> "" Then
                    ptotal = ptotal + (rw("Harga_Rupiah") - ptotal) * read.Item("Diskon4") / 100
                End If
                If read.Item("Diskon5").ToString <> "" Then
                    ptotal = ptotal + (rw("Harga_Rupiah") - ptotal) * read.Item("Diskon5") / 100
                End If
                GV.GetRow(e.RowHandle).item("Potongan") = ptotal
            End If

            read.Close()
            read = Nothing
        ElseIf e.Column Is Qty Then
            GV.GetRow(e.RowHandle).item("potongan_total") = GV.GetRow(e.RowHandle).item("Potongan") * e.Value
            GV.GetRow(e.RowHandle).item("total") = (GV.GetRow(e.RowHandle).item("harga") * e.Value) - GV.GetRow(e.RowHandle).item("potongan_total")
        End If
    End Sub
    Private Sub GV_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.GetRow(e.RowHandle).item("No_seq") = GV.RowCount + 1
    End Sub
    Private Sub txtCustomer_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCustomer.EditValueChanged
        If sender.editValue <> vbNullString Then
            txtKodeCust.Text = txtCustomer.EditValue
            txtAlamatAgen.Text = txtCustomer.Properties.GetDataSourceValue("Alamat1", txtCustomer.ItemIndex).ToString()
            txtNamaAgen.Text = txtCustomer.Text
        End If
    End Sub
    Private Sub GV_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV.RowUpdated
        lblTotal.EditValue = dsete.Tables("SALES_RETUR_D").Compute("sum(total)", "")
    End Sub
    Private Sub btnBuku_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuku.Click
        frmBukuRetur.TopLevel = False
        Me.Controls.Add(frmBukuRetur)
        frmBukuService2.WindowState = FormWindowState.Maximized
        frmBukuRetur.Show()
        pnl.SendToBack()
    End Sub
    'Private Sub GV_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
    '    e.Valid = True
    '    Dim isValid As Boolean = True
    '    If e.Row.item("Kd_Stok") Is Nothing Then
    '        isValid = False
    '        GV.SetColumnError(Kd_Stok, "Harap Memilih Barang Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
    '        GV.FocusedColumn = Kd_Stok
    '    End If
    '    If e.Row.item("Qty").ToString = "" Or Not IsNumeric(e.Row.item("Qty").ToString) Then
    '        isValid = False
    '        GV.SetColumnError(Qty, "Harap Mengisi Jumlah Kuantitas.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
    '    ElseIf e.Row.item("Qty") <= 0 Then
    '        isValid = False
    '        GV.SetColumnError(Qty, "Harap Mengisi Jumlah Kuantitas Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
    '    End If

    '    e.Valid = isValid
    'End Sub
    Public Sub cancel_click()
        reloadTable("xxx")
        default_cancel(prn)
    End Sub
    Public Sub cetak_click()
        Try
            Dim i As Int16 = New SqlCommand("update sales.dbo.sales_retur set cetakke= isnull(CetakKe,0)+1, isPrinted='Y' where no_retur='" & txtNomor.Text & "' and isnull(isprinted,'') <> 'Y' ", sqlconn).ExecuteNonQuery
            'If i > 0 Then

            callReport(App_Path() & "\report\repNotaRetur.rpt", "", "nomor=" & txtNomor.Text, False, False, "DIM")
         
        Catch e As Exception
            MsgBox("Gagal Cetak " & e.Message)

        End Try
    End Sub
    Private Sub GC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GC.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV.RowCount > 0 Then
                If GV.SelectedRowsCount > 0 Then
                    dsete.Tables("SALES_RETUR_D").Rows(GV.GetSelectedRows(0)).Delete()
                End If
            End If
        End If
    End Sub
    Private Sub txtCustomer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCustomer.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtRef1.Focus()
        End If
    End Sub
    Private Sub txtRef1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRef1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtRef2.Focus()
        End If
    End Sub
    Private Sub txtRef2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRef2.KeyDown
        If e.KeyCode = Keys.Enter Then
            GV.Focus()
        End If
    End Sub
    Private Sub tglTarik_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tglTarik.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtNamaAgen.Focus()
        End If
    End Sub
    Private Sub txtNamaAgen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNamaAgen.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAlamatAgen.Focus()
        End If
    End Sub
    Private Sub txtAlamatAgen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtAlamatAgen.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtKeterangan.Focus()
        End If
    End Sub
    Private Sub txtKeterangan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKeterangan.KeyDown
        If e.KeyCode = Keys.Enter Then
            prn.btnSave.Focus()
        End If
    End Sub
    Private Sub GV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV.GetSelectedRows.Count = 0 Then Exit Sub
            If MsgBox("Hapus Data Retur Barang ? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Hapus") = MsgBoxResult.Yes Then
                GV.DeleteSelectedRows()
            End If
        End If
    End Sub
    Public Sub edit_click()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_retur as [Nomor], Tgl_retur as [Tanggal], [Nama_Customer] from sales.dbo.[VRETUR_REP] where no_posting is null order by tgl_retur ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dsete.Tables("lookup_so") Is Nothing Then dsete.Tables("lookup_so").Clear()
        dadbe.Fill(dsete, "lookup_so")
        frmCari.set_dso(dsete.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.GV.Columns(2).Visible = False
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            
            btnadd = False
            btnEdit = False
            ONLOAD_STATE = True
            reloadTable(frmCari.row(0))
            ONLOAD_STATE = False
            State = "EDIT"
            btnSave = True
            btnadd = False
            btnEdit = False
            btnCancel = True
            btncetak = True
            btnDelete = True
            Me.Enabled = True

            If txtNomor.Text = "" Then
                MsgBox("Data SP Pelanggan Tidak Diketemukan", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Missing File")
                cancel_click()

            End If
            setStatus()
        Else
            cancel_click()
            State = ""
        End If
    End Sub
    Private Sub DT_TglSO_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_TglSO.EditValueChanged
        tglRetur.Text = DT_TglSO.EditValue
    End Sub

    Private Sub txtRef1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRef1.EditValueChanged
        Dim i As Int16 = 0
        'If State = "ADD" Then Exit Sub
        If State = "ADD" Then
            dsete.Tables("SALES_RETUR_D").Clear()
            txtCustomer.EditValue = txtRef1.Properties.GetDataSourceValue("kd_customer", txtRef1.ItemIndex).ToString()
            With New SqlCommand("select * from inv.dbo.INV_GUDANG_IN_D where no_trans='" & txtRef1.EditValue & "' order by no_seq", sqlconn).ExecuteReader
                While .Read
                    Dim newRow As DataRow = dsete.Tables("SALES_RETUR_D").NewRow

                    newRow("No_seq") = .Item("no_seq")
                    newRow("kd_Cabang") = kdcabang
                    newRow("Kd_Stok") = .Item("kd_stok")
                    newRow("Qty") = .Item("qty_in")

                    Dim rw As DataRow
                    rw = dsete.Tables("VBARANG").Select("Kode_Barang='" & .Item("kd_stok") & "'")(0)
                    newRow("Kd_satuan") = rw("Kd_Satuan")
                    Dim drows As DataRow() = dsete.Tables("VBARANG").Select("Kode_Barang='" & .Item("kd_stok") & "'")
                    If drows.Count = 0 Then
                        newRow("Nama") = "Item Not Found"
                    Else
                        newRow("Nama") = drows(0)("Nama_Barang")
                    End If
                    newRow("Potongan") = 0
                    newRow("potongan_total") = 0

                    rw = drows(0)
                    newRow("Kd_satuan") = rw("Kd_Satuan")


                    newRow("harga") = rw("Harga_Rupiah")
                    newRow("total") = rw("Harga_Rupiah") * newRow("Qty")



                    Dim read As SqlClient.SqlDataReader
                    read = New SqlCommand("select r.* FROM dbo.SIF_Barang B, dbo.SIF_Diskon_kesepakatan R where " & _
                                          " b.kd_merk = r.KD_MERK And Kode_Barang ='" & .Item("kd_stok") & "' and kd_customer='" & txtCustomer.EditValue & "' and getdate() between start_date and end_date and kd_tipe like kode_tipe and kd_ukuran like kode_ukuran", sqlconn).ExecuteReader
                    read.Read()
                    If Not read.HasRows Then
                        read = New SqlCommand("select r.* FROM dbo.SIF_Barang B, dbo.SIF_Diskon_Reguler R where " & _
                                              " b.kd_jenis like r.kd_jenis and b.kd_merk = r.KD_MERK and b.kd_ukuran like  r.Ukuran  and b.kd_tipe=r.kode_tipe and Kode_Barang ='" & .Item("kd_stok") & "' order by kd_jenis, Ukuran desc", sqlconn).ExecuteReader
                        read.Read()
                    End If
                    Dim ptotal As Double
                    If read.HasRows Then
                        newRow("nama_potongan") = read.Item("Kd_Diskon")
                        If read.Item("Diskon1").ToString <> "" Then
                            ptotal = rw("Harga_Rupiah") * read.Item("Diskon1") / 100
                        End If
                        If read.Item("Diskon2").ToString <> "" Then
                            ptotal = ptotal + (rw("Harga_Rupiah") - ptotal) * read.Item("Diskon2") / 100
                        End If
                        If read.Item("Diskon3").ToString <> "" Then
                            ptotal = ptotal + (rw("Harga_Rupiah") - ptotal) * read.Item("Diskon3") / 100
                        End If
                        If read.Item("Diskon4").ToString <> "" Then
                            ptotal = ptotal + (rw("Harga_Rupiah") - ptotal) * read.Item("Diskon4") / 100
                        End If
                        If read.Item("Diskon5").ToString <> "" Then
                            ptotal = ptotal + (rw("Harga_Rupiah") - ptotal) * read.Item("Diskon5") / 100
                        End If
                        If ptotal = vbNullString Then ptotal = 0
                        newRow("Potongan") = ptotal
                    End If

                    read.Close()
                    read = Nothing
                    newRow("potongan_total") = newRow("Potongan") * .Item("qty_in")
                    newRow("total") = (newRow("harga") * .Item("qty_in")) - newRow("potongan_total")
                    dsete.Tables("SALES_RETUR_D").Rows.Add(newRow)
                End While
                .Close()
            End With

            lblTotal.EditValue = dsete.Tables("SALES_RETUR_D").Compute("SUM(total)", "")
        End If
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data Retur Penjualan?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Hapus Retur") = MsgBoxResult.Yes Then
            State = "DELETE"
            save_click(True)
            cancel_click()
        End If
    End Sub
End Class