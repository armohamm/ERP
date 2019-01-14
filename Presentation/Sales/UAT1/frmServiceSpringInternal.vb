Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmServiceSpringInternal
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
        tglSO.Text = Now
        txtNomor.Text = ""
        lblStatus.Text = "[New]"
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
        If Not dsete.Tables("SOD") Is Nothing Then dsete.Tables("SOD").Clear()
        If Not dsete.Tables("SO") Is Nothing Then dsete.Tables("SO").Clear()

        ONLOAD_STATE = True
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from Sales.dbo.SALES_SO where no_sp='" & kode & "' and tipe_trans='" & tipe_trans & "'", sqlconn))
        DA.Fill(dsete, "SO")
        DAD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, 1 as NO from Sales.dbo.SALES_SO_D where no_sp='" & kode & "' and tipe_trans='" & tipe_trans & "'", sqlconn))
        DAD.Fill(dsete, "SOD")

        If dsete.Tables("SO").Rows.Count > 0 Then
            Dim row As DataRow

            row = dsete.Tables("SO").Rows(0)
            txtNomor.Text = row.Item("No_sp").ToString
            tglSO.Text = row.Item("Tgl_sp").ToString
            txtNomor.Text = row.Item("No_sp").ToString
            cmbAsalService.EditValue = row.Item("AsalService").ToString
            txtNoRef.Text = row.Item("SP_REFF").ToString

            Dim dr As SqlDataReader = New SqlCommand("select * from prod.dbo.prod_rcn_prod_d where no_sp='" & txtNomor.Text & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                lblStatus.Text = " On Production Planing"
            End If
            dr.Close()
            btnCancel = True

            btnDelete = False
            If row("isPrinted").ToString <> "" Then btnSave = False
            setStatus()

        Else
            txtNomor.Text = vbNullString
            tglSO.Text = vbNullString
            cmbAsalService.EditValue = vbNullString
            txtNoRef.Text = ""
        End If
        ONLOAD_STATE = False
    End Sub
    Private Sub frmSO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        tipetrans = ServiceSpringInternal
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select b.Kd_Satuan, b.Nama_Barang, b.Kode_Barang, b.kd_merk  from SIF.dbo.SIF_Barang as b where b.kd_jns_persd=1 and  b.Rec_Stat='Y' and Kd_Depart='" & KD_DIV_SPRING & "'", sqlconn))
        dadbe.Fill(dsete, "VBARANG")
        repbarang.DataSource = dsete.Tables("VBARANG")
        reloadTable(no_sp, tipe_transaksi)
        AddHandler dsete.Tables("SOD").RowDeleted, AddressOf refreshNomer
       
        GC.DataSource = dsete.Tables("SOD")
        Dim tbl As New DataTable
        tbl.Columns.Add("no_sj")
        repNoReff.DataSource = tbl
        tglSO.Text = getTanggal()
        prn = frmMain
        tipe_trans = "SPV"
    End Sub
    Public Sub edit_click()
        'dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_sp as [Nomor], tgl_sp as [Tanggal], tipe_trans, Nama_Customer from sales.dbo.VSO_REP where tipe_trans = '" & tipetrans & "'", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_sp as [Nomor], tgl_sp as [Tanggal], tipe_trans, 'INTERNAL' [Customer / Toko], substring(sales.dbo.status_inspeksi(No_sp),3,30) [Status Service], left(sales.dbo.status_inspeksi(No_sp),0)   from sales.dbo.VSO_REP where tipe_trans = '" & ServiceSpringInternal & "'", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dsete.Tables("lookup_so") Is Nothing Then dsete.Tables("lookup_so").Clear()
        dadbe.Fill(dsete, "lookup_so")
        frmCari.set_dso(dsete.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.GV.Columns(2).Visible = False
        frmCari.GV.Columns(5).Visible = False
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
            setStatus()
            Me.Enabled = True

        Else
            cancel_click()
            State = ""
        End If
    End Sub
    Public Sub cetak_click()
        If State = "EDIT" Then
            If status_service <> "2" Then
                MsgBox("Inspeksi Akhir Belum Selesai", MsgBoxStyle.Exclamation, "Peringatan")
                Exit Sub
            End If
            Try
                Dim i As Int16 = New SqlCommand("update sales.dbo.sales_so set cetakke= isnull(CetakKe,0)+1, isPrinted='Y' where no_sp='" & txtNomor.Text & "' and isnull(isprinted,'') <> 'Y' ", sqlconn).ExecuteNonQuery
                Dim j, k As Int16
                If i > 0 Then
                    With (New SqlCommand("select count(1) from SALES.dbo.sales_so_d dd where dd.no_sp= '" & txtNomor.Text & "'", sqlconn).ExecuteReader)
                        .Read()
                        j = .Item(0)
                    End With
                    With (New SqlCommand("select count(1) from sales.dbo.sales_produk_service ss where ss.nomor_so='" & txtNomor.Text & "'", sqlconn).ExecuteReader)
                        .Read()
                        k = .Item(0)
                    End With
                    If j = k Then
                        callReport(App_Path() & "\report\vService.rpt", "", "PSO=" & txtNomor.Text, True, True)
                        btnSave = False
                        btnDelete = False
                        setStatus()
                    Else
                        MsgBox("Dokumen SP Service Belum Selesai di Inspeksi", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Perhatian")
                    End If
                Else
                    MsgBox("Dokumen SP Service Sudah Pernah Dicetak ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Perhatian")
                End If
            Catch e As Exception
                MsgBox("Gagal Cetak " & e.Message)
            End Try
        End If
    End Sub
    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim row As DataRow
        Dim BTRANS As SqlTransaction
        Dim iserror As Boolean = False
        If Not isDelete Then
            If GV.RowCount = 0 Then
                showMessages("Daftar Barang Masih Kosong")
                GV.Focus()
                Exit Sub
            End If
        End If
        'If status_service <> "5" Then
        '    If status_service = "1" Then
        '        MsgBox("Inspeksi Akhir Belum Selesai", MsgBoxStyle.Exclamation, "Peringatan")
        '        Exit Sub
        '    ElseIf status_service = "3" Then
        '        MsgBox("Inspeksi Awal Belum Selesai", MsgBoxStyle.Exclamation, "Peringatan")
        '        Exit Sub
        '    End If
        'End If
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

            row.Item("Tipe_trans") = IIf(kddep = KD_DIV_SPRING, ServiceSpringInternal, ServiceSponInternal)
            row.Item("Tgl_sp") = getTanggal()
            row.Item("Kd_Customer") = "INTERNAL"
            row.Item("PPn") = "0"
            row.Item("Total_qty") = Qty.SummaryText
            row.Item("Departement") = KD_DIV_SPRING
            row.Item("Status") = "OK"
            row.Item("Biaya") = 0
            row.Item("JML_RP_TRANS") = 0
            row("Jenis_sp") = "INTERNAL"
            row.Item("AsalService") = cmbAsalService.EditValue
            row.Item("SP_REFF") = txtNoRef.Text
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
                    rows.Item("departemen") = KD_DIV_SPRING
                Else
                    rows.Item("Last_Update_Date") = getTanggal()
                    rows.Item("Last_Updated_By") = username
                End If
                rows.Item("Programe_name") = Me.Name

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
                txtNomor.Text = getNoTrans("SPSRVT", row.Item("Tgl_sp"), BTRANS)
                row.Item("No_sp") = txtNomor.Text
            End If
            For Each rows As DataRow In dsete.Tables("SOD").Rows
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

            dsete2 = dsete.Clone
            dsete2 = dsete.Copy

            DA.Update(dsete.Tables("SO"))
            DAD.Update(dsete.Tables("SOD"))


            BTRANS.Commit()
            State = "EDIT"
            showMessages("Transaksi Telah Diproses")
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
        End If
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.SetRowCellValue(e.RowHandle, "No_seq", GV.RowCount + 1)
        GV.SetRowCellValue(e.RowHandle, "Qty", 1)
        GV.SetRowCellValue(e.RowHandle, "harga", 0)
    End Sub
    Private Sub GV_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub GV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV.GetSelectedRows.Count = 0 Then Exit Sub
            If MsgBox("Hapus Data Service Barang ? ", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Hapus") = MsgBoxResult.Yes Then
                GV.DeleteSelectedRows()
            End If
        End If
    End Sub

    Private Sub GV_ShownEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV.ShownEditor
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView
        Dim clone As DataView
        view = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        On Error Resume Next
        If view.FocusedColumn Is NO_REFF Then
            Dim edit As DevExpress.XtraEditors.LookUpEdit
            Dim table As New DataTable
            Dim row As DataRow

            edit = CType(view.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)
            With New SqlDataAdapter("select distinct no_sj from sales.dbo.sales_sj_d where kd_stok='" & GV.GetRowCellValue(GV.GetSelectedRows(0), "Kd_Stok") & "' and isnull(qty_balik,0) > 0 and tipe_trans='" & SpringUmum & "'", sqlconn)
                .Fill(table)
            End With

            clone = New DataView(table)
            row = view.GetDataRow(view.FocusedRowHandle)
            edit.Properties.DataSource = clone
        End If
    End Sub
    Private Sub GV_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        Dim isValid As Boolean = True
        If e.Row("Qty").ToString = "" Then
            isValid = False
            GV.SetColumnError(Qty, "Inputan Jumlah Salah", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        ElseIf e.Row("Qty") < 0 Then
            isValid = False
            GV.SetColumnError(Qty, "Inputan Jumlah Salah", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row("Kd_Stok").ToString = "" Then
            isValid = False
            GV.SetColumnError(Kd_Stok, "Kode Stok Kosong", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
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
    Private Sub Gvd_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)
        Dim x As Object = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Grid.GridView)
        x.SetRowCellValue(e.RowHandle, "no_seq", x.RowCount)
        x.SetRowCellValue(e.RowHandle, "Garansi", "T")
        x.SetRowCellValue(e.RowHandle, "kd_stok", GV.GetRowCellValue(rhandel, "Kd_Stok"))
        x.SetRowCellValue(e.RowHandle, "sp_seq", GV.GetRowCellValue(rhandel, "No_seq"))
    End Sub
    Private Sub frmService_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        pnl.Height = Me.Height - 15
    End Sub

    Private Sub GV_Biaya_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs)
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
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
            reloadTable(noso, tipetransx)
            tipetransx = ""
            noso = ""
            statusService = ""
            GV.Focus()
        End If
    End Sub

    Private Sub GC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GC.Click

    End Sub

    Private Sub repNoReff_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles repNoReff.QueryPopUp
        If GV.GetRowCellValue(GV.GetSelectedRows(0), "Kd_Stok").ToString Is Nothing Then
            e.Cancel = True
        End If
    End Sub
End Class