Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class frmSOInternal
    Dim dsete As New DataSet
    Dim dsete2 As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA As SqlDataAdapter
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
    Public btnCetak As Boolean = False
    Public State As String
    Public baru As Boolean
    Dim myBuilder As New SqlCommandBuilder
    Private clone As DataView
    Public no_sp As String = "XXX"
    Dim rhandel As Integer
    Public ONLOAD_STATE As Boolean = False
    Public oldTotal As Double = 0
    Private tipetrans As String = IIf(kddep = KD_DIV_SPRING, SpringInternal, SponInternal)
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btnCetak
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

        DAD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, harga*qty-potongan_total as total,0 as state from Sales.dbo.SALES_SO_D where key_bonus is null and kd_parent is null and No_sp='" & kode & "' and nomor_bonus is null and tipe_trans='" & tipe_trans & "' order by len(no_seq), No_seq ", sqlconn))
        DAD.Fill(dsete, "SOD")
        DADD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, harga*qty-potongan_total as total,0 as state from Sales.dbo.SALES_SO_D where not kd_parent is null and No_sp='" & kode & "' and tipe_trans='" & tipe_trans & "'", sqlconn))
        DADD.Fill(dsete, "SODD")
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *  from Sales.dbo.SALES_SO where No_sp='" & kode & "' and tipe_trans='" & tipe_trans & "'", sqlconn))
        DA.Fill(dsete, "SO")


        If dsete.Tables("SO").Rows.Count > 0 Then
            Dim row As DataRow

            row = dsete.Tables("SO").Rows(0)
            txtNomor.Text = row.Item("No_sp").ToString
            DT_TglSO.EditValue = row.Item("Tgl_sp").ToString

            Dim dr As SqlDataReader = New SqlCommand("select * from prod.dbo.prod_rcn_prod_d where no_sp='" & txtNomor.Text & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                lblStatus.Text = " On Production Planing"
                btnDelete = False
                btnSave = False
                setStatus()
            End If
            dr.Close()
            dr = Nothing
            If row("isPrinted").ToString = "Y" Then
                btnCetak = False
            Else
                btnCetak = True
            End If
            setStatus()
        Else
            oldTotal = 0
            txtNomor.Text = vbNullString
            DT_TglSO.EditValue = vbNullString
            lblStatus.Text = " [New]"
        End If
    End Sub
    Private Sub frmSO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        reload_master()
        repBarang.DataSource = dsete.Tables("VBARANG")
        RepGridLUEBarang.DataSource = dsete.Tables("VBARANG")
        RepGridLUEBarang.DisplayMember = "Nama_Barang"
        RepGridLUEBarang.ValueMember = "Kode_Barang"
        RepositoryItemGridLookUpEdit1View.Columns("Harga_Dollar").Visible = False
        RepositoryItemGridLookUpEdit1View.Columns("Harga_Rupiah").Visible = False
        RepositoryItemGridLookUpEdit1View.Columns("isset").Visible = False

        RepositoryItemGridLookUpEdit1View.Columns("Kd_Satuan").Caption = "Satuan"
        RepositoryItemGridLookUpEdit1View.Columns("Kode_Barang").Caption = "Kode Barang"
        RepositoryItemGridLookUpEdit1View.Columns("Nama_Barang").Caption = "Nama Barang"

        gcCari.DataSource = dsete.Tables("VBARANG")
        reload_table(no_sp, tipetrans)

        AddHandler dsete.Tables("SOD").RowDeleted, AddressOf refreshNomer
        GC.DataSource = dsete.Tables("SOD")

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
        State = "ADD"
        DT_TglSO.EditValue = getTanggal()
        DT_TglSO.Properties.MaxValue = DT_TglSO.EditValue
        prn = frmMain

    End Sub
    Private Sub refreshNomer(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        Dim j As Int16 = 1
        If State = "DELETE" Then Exit Sub

        For Each rw As DataRow In sender.Rows
            If rw.RowState <> DataRowState.Deleted Then
                rw("No_seq") = i
                i += 1
            End If
        Next
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
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
            If GV.RowCount <= 1 Then
                MsgBox("Daftar Barang Masih Kosong", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
                isError = True
            End If

        End If
        If isError = True Then
            showMessages("Isian Masih Belum Benar, Harap Periksa Kembali", 10, "WARNING")
            Exit Sub
        End If

        If Not isDelete Then
            If State = "ADD" Then
                dsete2 = dsete.Clone
                dsete2 = dsete.Copy
                row = dsete.Tables("SO").NewRow
                row.Item("Last_Create_Date") = getTanggal()
                row.Item("Last_Created_By") = username
                txtNomor.Text = getNoTrans("SPSRIT", row.Item("Last_Create_Date"), BTRANS)
            ElseIf State = "EDIT" Then

                dsete2 = dsete.Clone
                dsete2 = dsete.Copy
                row = dsete.Tables("SO").Rows(0)
                row.Item("Last_Update_Date") = getTanggal()
                row.Item("Last_Updated_By") = username
            End If

            row.Item("Tgl_sp") = tglSO.Text
            row.Item("No_sp") = txtNomor.Text

            row.Item("Kd_Cabang") = kdcabang  ' <-- hanya contoh, nanti diisi dengan yg bener
            row.Item("Tipe_trans") = tipetrans
            row.Item("Kd_Customer") = "INTERNAL"
            row.Item("Flag_Ppn") = "Y"
            row.Item("PPn") = "0"
            row.Item("Total_qty") = Qty.SummaryText
            row.Item("Departement") = kddep
            row.Item("Status") = IIf(frmPaswdOTP.PENDING, "PENDING", "OK")
            row.Item("JML_RP_TRANS") = 0
            row.Item("JML_VALAS_TRANS") = 0
            row.Item("Biaya") = 0
            row.Item("Program_Name") = Me.Name

            row("Jenis_sp") = "INTERNAL"
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

            lblState.Text = "SAVING..."

            DA.Update(dsete.Tables("SO"))
            DAD.Update(dsete.Tables("SOD"))
            DADD.Update(dsete.Tables("SODD"))
            BTRANS.Commit()
            lblState.Text = "SAVED"
            showMessages("Transaksi Telah Tersimpan")
            State = "EDIT"
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
        If e.Column Is Kd_Stok Then
            If e.Value.ToString = "" Then
                'popCon.Show()
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
            GV.GetRow(e.RowHandle).item("harga") = 0
            GV.GetRow(e.RowHandle).item("total") = 0
        ElseIf e.Column Is Qty Then
            If GV.GetRow(e.RowHandle).item("harga").ToString = "" Then Exit Sub
            If e.Value.ToString = "" Then Exit Sub
            If e.Value = 0 Then Exit Sub

            GV.GetRow(e.RowHandle).item("total") = 0
        End If
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
        End If
    End Sub
    Private Sub GV_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV.RowUpdated
        'rw.Row.RowState

        If e.Row Is Nothing Then Exit Sub

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
                    rws.Item("harga") = 0
                    rws.Item("total") = 0
                    rws.Item("set") = 0

                    dsete.Tables("SODD").Rows.Add(rws)
                    tbls.Close()
                    tbls = Nothing
                End While
            End If

            tbl.Close()
            tbl = Nothing
            e.Row("harga") = 0
            e.Row("total") = 0
        Else
            For Each rw As DataRow In dsete.Tables("SODD").Select("kd_parent='" & e.Row.item("Kd_Stok") & "'")
                rw.Delete()
            Next
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
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_sp as [Nomor], tgl_sp as [Tanggal], tipe_trans , 'INTERNAL' as [Nama_Customer] from sales.dbo.[VSO_REP] where tipe_trans ='" & tipetrans & "' order by tgl_sp ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dsete.Tables("lookup_so") Is Nothing Then dsete.Tables("lookup_so").Clear()
        dadbe.Fill(dsete, "lookup_so")
        frmCari.set_dso(dsete.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.GV.Columns(2).Visible = False
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            Dim dr As SqlDataReader = New SqlCommand("select sales.dbo.isSoProccesed('" & txtNomor.Text & "') ", sqlconn).ExecuteReader
            dr.Read()
            If dr.Item(0) > 0 Then
                btnSave = False
            Else
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
            setStatus()
            setReadOnly()
            If btnSave = False Then
                lblState.Text = "LOCKED"
            End If
        Else
            cancel_click()
            State = ""
        End If
    End Sub
    Private Sub setReadOnly()
        GV.OptionsBehavior.Editable = btnSave
        repDel.Buttons(0).Enabled = btnSave
        GV.OptionsView.NewItemRowPosition = IIf(btnSave, 2, 0)
    End Sub
    Public Sub add_click()
        State = "ADD"
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        btnCetak = False
        setStatus()
        setReadOnly()
    End Sub
    Public Sub cancel_click()
        reload_table("XXX", "XXX")
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        btnCetak = False
        State = ""

        setStatus()
        Me.Enabled = False
        tglSO.Text = getTanggal()
        txtNomor.Text = ""
        reload_master()

    End Sub
    Sub reload_master()
        If Not dsete.Tables("VBARANG") Is Nothing Then dsete.Tables("VBARANG").Clear()

        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  b.Kode_Barang , b.Nama_Barang ,b.Kd_Satuan, 0 as Harga_Dollar , 0 as Harga_Rupiah, case kd_jenis when '038' then 1 when '039' then 1 else 0 end  as isset from SIF.dbo.SIF_Barang as b where  b.rec_stat='Y' and (b.Kd_Depart = '" & kddep & "' or kd_merk in ( select id_data from sif.dbo.sif_gen_reff_d where ref_role='SOD' and id_ref_file='SPI' and id_ref_data='SPI' and rec_stat='Y')) and kd_jns_persd in ('1','2') order by Nama_Barang", sqlconn))
        'dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select b.Kd_Satuan, b.Nama_Barang, 0 as Harga_Dollar , 0 as Harga_Rupiah, b.Kode_Barang , case kd_jenis when '038' then 1 when '039' then 1 else 0 end  as isset from SIF.dbo.SIF_Barang as b where  b.rec_stat='Y' and kd_jns_persd in ('1','2') order by Nama_Barang", sqlconn))
        dadbe.Fill(dsete, "VBARANG")
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data SO ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            State = "DELETE"
            If Not dsete.Tables("SOD") Is Nothing Then delete(dsete.Tables("SOD").Rows)
            If Not dsete.Tables("SODD") Is Nothing Then delete(dsete.Tables("SODD").Rows)
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
    Private Sub btnBatalSP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtNomor.Text = "" Then Exit Sub
        frmForceOpenSP.TopLevel = False
        Me.Controls.Add(frmForceOpenSP)
        frmForceOpenSP.WindowState = FormWindowState.Maximized
        frmForceOpenSP.Show()
        pnl.SendToBack()
    End Sub
    Private Sub cmdViewStatusSp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        call_form_manual("frmStatusSP")
    End Sub
    Private Sub repPopD_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repPopD.ButtonClick

        'popCon.Show()
    End Sub
    Private Sub GV_MasterRowExpanded(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs) Handles GV.MasterRowExpanded
        If GV.GetDetailView(e.RowHandle, 0) Is Nothing Then Exit Sub
        If GV.GetRowCellValue(e.RowHandle, "set") = 1 Then
            CType(GV.GetDetailView(e.RowHandle, 0), DevExpress.XtraGrid.Views.Grid.GridView).OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
        Else
            CType(GV.GetDetailView(e.RowHandle, 0), DevExpress.XtraGrid.Views.Grid.GridView).OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.None
        End If
    End Sub
    Private Sub RepPop_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        'popCon.Show()
    End Sub
    Private Sub RepPop_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        repPopD.PopupControl = Nothing
        gcCari.DataSource = ""
        txtcari.Text = ""
        popCon.Tag = "GVD"
        'gcCari.DataSource = dsete.Tables("VBARANG")
        gvCari.Columns("Nama_Barang").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Value, "Nama_Barang = ''")
    End Sub
    Private Sub repPopD_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles repPopD.QueryPopUp
        repPopD.PopupControl = popCon
        kriteria = Mid(GV.GetRowCellValue(rhandel, "Kd_Stok"), 6, 17)
        clone = New DataView(dsete.Tables("VBARANG"))
        clone.RowFilter = "substring(kode_barang,6,17)= '" & kriteria & "' and isset=0"
        gcCari.DataSource = clone
    End Sub
    Private Sub GVD_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GVD.CellValueChanged
        Dim x As Object = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Grid.GridView)
        Dim qty As Integer = GV.GetRowCellValue(GV.FocusedRowHandle, "Qty")
        If e.Column.Name = "Kd_StokD" Then
            Dim drows As DataRow() = dsete.Tables("VBARANG").Select("Kode_Barang='" & e.Value & "'")
            If drows.Count = 0 Then
                x.GetRow(e.RowHandle).item("Deskripsi") = "Item Not Found"
                Exit Sub
            End If

            Dim rw As DataRow
            x.GetRow(e.RowHandle).item("Deskripsi") = "Item Not Found"
            x.GetRow(e.RowHandle).item("Qty") = qty
            x.GetRow(e.RowHandle).item("total") = 0
            x.GetRow(e.RowHandle).item("potongan") = 0
            rw = drows(0)
            x.GetRow(e.RowHandle).item("Deskripsi") = rw("Nama_Barang")
            x.GetRow(e.RowHandle).item("Kd_satuan") = rw("Kd_Satuan")

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
                End If
            End If
        End If
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
    Private Sub DT_TglSO_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_TglSO.EditValueChanged
        tglSO.Text = DT_TglSO.EditValue
    End Sub
End Class