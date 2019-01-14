Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmSOBOXInternal
    Dim dsete, dsete2 As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA As SqlDataAdapter
    Dim DAD As SqlDataAdapter
    Dim DAB As SqlDataAdapter
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Const volume = 0
    Dim oldTotal As Double = 0
    Dim rhandle As Int16
    Public isLoading As Boolean = False
    Public tblr As New DataTable
    Dim myBuilder As New SqlCommandBuilder
    Dim kd_stok_old As String
    Dim dvCustomer As New DataView
    Dim no_seqdelete As String
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Public Sub loadTable(ByVal no_sp As String)
        If Not dsete.Tables("SOB") Is Nothing Then dsete.Tables("SOB").Clear()
        If Not dsete.Tables("SO") Is Nothing Then dsete.Tables("SO").Clear()
        If Not dsete.Tables("SOD") Is Nothing Then dsete.Tables("SOD").Clear()

        DAD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, qty*harga-potongan as total from Sales.dbo.SALES_SO_D where no_sp='" & no_sp & "' order by len(no_Seq), no_seq ", sqlconn))
        DAD.Fill(dsete, "SOD")
        DAB = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from Sales.dbo.SALES_SOBOX_D where no_sp='" & no_sp & "' order by len(no_seq), no_seq", sqlconn))
        DAB.Fill(dsete, "SOB")
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from Sales.dbo.SALES_SO where no_sp='" & no_sp & "'", sqlconn))
        DA.Fill(dsete, "SO")
   

        If dsete.Tables("SO").Rows.Count = 0 Then
            txtNomor.Text = ""
            tglSO.Text = ""
            oldTotal = 0
        Else
            Dim row As DataRow = dsete.Tables("SO").Rows(0)
            txtNomor.Text = row("No_sp").ToString
            DT_TglSO.EditValue = row("Tgl_sp").ToString
            oldTotal = row("JML_RP_TRANS")
            Dim dr As SqlDataReader = New SqlCommand("select * from prod.dbo.prod_rcn_prod_d where no_sp='" & txtNomor.Text & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                lblStatus.Text = " On Production Planing"
                btnDelete = False
                btnSave = False
                setStatus()
            End If
        End If
        setStatus()
    End Sub
    Private Sub setReadOnly()
        GV.OptionsBehavior.Editable = btnSave
        repSim.Buttons(0).Enabled = btnSave
        repSim.Buttons(1).Enabled = btnSave
        repDelD.Buttons(0).Enabled = btnSave
        GV.OptionsView.NewItemRowPosition = IIf(btnSave, 1, 0)
    End Sub
    Private Sub frmSO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = frmMain
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select b.* " & _
                                                        "from SIF.dbo.SIF_Barang as b where Kd_Depart='" & KD_DIV_SPON & "' and kd_jns_persd in ('1','2') and kd_jenis in ('072','085') and b.rec_stat='Y'", sqlconn))

        '"from SIF.dbo.SIF_Barang as b where Kd_Depart='" & KD_DIV_SPON & "' and kd_jns_persd in ('1','2') and kd_jenis in ('007','040') and b.rec_stat='Y'", sqlconn))
        dadbe.Fill(dsete, "VBARANG")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.sif_ukuran where rec_stat='Y' and isnull(Tinggi,0) > 0 and isnull(Panjang,0) > 0 and isnull(Lebar,0) > 0 ", sqlconn))
        dadbe.Fill(dsete, "UKURAN")
        loadTable("xxx")
        AddHandler dsete.Tables("SOD").RowDeleted, AddressOf refreshNomer
        AddHandler dsete.Tables("SOB").RowDeleted, AddressOf refreshNomer2
        Dim rl As DataRelation
        Dim dcolP(2), dColPROMO(2), dcolC(2) As DataColumn

        dcolP(0) = dsete.Tables("SOD").Columns("Kd_Stok")
        dcolP(1) = dsete.Tables("SOD").Columns("No_sp")
        dcolP(2) = dsete.Tables("SOD").Columns("No_seq")

        dcolC(0) = dsete.Tables("SOB").Columns("kd_Stok")
        dcolC(1) = dsete.Tables("SOB").Columns("No_sp")
        dcolC(2) = dsete.Tables("SOB").Columns("no_seq_d")

        rl = dsete.Relations.Add("Detail", dcolP, dcolC, False)
        GC.LevelTree.Nodes.Add("Detail", gv2)

        repbarang.DataSource = dsete.Tables("VBARANG")
        repUkuran.DataSource = dsete.Tables("UKURAN")

        GC.DataSource = dsete.Tables("SOD")
        State = "ADD"
        DT_TglSO.EditValue = getTanggal()
        DT_TglSO.Properties.MaxValue = DT_TglSO.EditValue

    End Sub
    Private Sub refreshNomer(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        For Each rw As DataRow In sender.Rows
            If rw.RowState <> DataRowState.Deleted Then
                For Each rwd As DataRow In dsete.Tables("SOB").Select("no_seq_d=" & rw.Item("No_seq"))
                    rwd("no_seq_d") = i
                Next
                rw("No_seq") = i
                i += 1
            End If
        Next

    End Sub
    Private Sub refreshNomer2(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
       
        For Each rw As DataRow In dsete.Tables("SOB").Select("no_seq_d='" & no_seqdelete & "'")
            If rw.RowState <> DataRowState.Deleted Then
                rw("No_seq") = i
                i += 1
            End If
        Next
    End Sub
    Public Sub save_click(Optional ByVal isdelete As Boolean = False)
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

        If Not isdelete Then
            If GV.RowCount = 0 Then
                MsgBox("Daftar Barang Masih Kosong", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error")
                isError = True
            End If

            Dim i As Int16 = 0
            For Each rows As DataRow In dsete.Tables("SOD").Rows
                If rows.RowState <> DataRowState.Deleted Then
                    If dsete.Tables("SOB").Select("Kd_Stok='" & rows("Kd_Stok") & "'").Count() = 0 Then
                        showMessages("Detail Irisan Blok Masih Ada Yang Kosong", 12)
                        GV.SelectRow(i)
                        GV.ExpandMasterRow(i, "Detail")
                        isError = True
                    End If
                    i += 1
                End If
            Next
        End If
        If isError = True Then
            Exit Sub
        End If

        If State = "ADD" Then
            dsete2 = dsete.Clone
            dsete2 = dsete.Copy
            row = dsete.Tables("SO").NewRow
            row.Item("Tgl_sp") = tglSO.Text
            txtNomor.Text = getNoTrans("SPSRIT", row.Item("Tgl_sp"), BTRANS)
            row.Item("No_sp") = txtNomor.Text
            row.Item("Last_Create_Date") = row.Item("Tgl_sp")
            row.Item("Last_Created_By") = username
            row.Item("sts_centi") = "Y"
            row.Item("No_sp") = txtNomor.Text
        ElseIf State = "EDIT" Then
            dsete2 = dsete.Clone
            dsete2 = dsete.Copy
            row = dsete.Tables("SO").Rows(0)
            row.Item("Tgl_sp") = tglSO.Text
            row.Item("Last_Update_Date") = getTanggal()
            row.Item("Last_Updated_By") = username
        End If
        row("JML_RP_TRANS") = 0
        row("Valas") = "IDR"
        row("Kurs") = 1
        row("JML_VALAS_TRANS") = 0

        row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
        row.Item("Tipe_trans") = CentianInternal
        row.Item("Kd_Customer") = "INTERNAL"
        row.Item("Flag_Ppn") = "Y"
        row.Item("Jenis_sp") = "INTERNAL"
        row.Item("PPn") = "0"
        row.Item("Total_qty") = Qty.SummaryText
        row.Item("Departement") = KD_DIV_SPON
        row.Item("Status") = IIf(frmPaswdOTP.PENDING, "PENDING", "OK")
        row.Item("Program_Name") = Me.Name
        row("JML_RP_TRANS") = 0
        If State = "ADD" Then
            dsete.Tables("SO").Rows.Add(row)
        End If
        Dim a As Integer = 1
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
            BTRANS = sqlconn.BeginTransaction
            For Each rows As DataRow In dsete.Tables("SOD").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("Last_Create_Date") = tglSO.Text
                    rows.Item("Last_Created_By") = username
                    rows.Item("kd_Cabang") = kdcabang
                    rows.Item("No_sp") = txtNomor.Text
                    rows.Item("tipe_trans") = row.Item("Tipe_trans")
                    rows.Item("Status") = "OK"
                    rows.Item("departemen") = KD_DIV_SPON
                    rows.Item("Programe_name") = Me.Name
                ElseIf rows.RowState <> DataRowState.Deleted Then
                    rows.Item("Last_Update_Date") = getTanggal(BTRANS)
                    rows.Item("Last_Updated_By") = username
                    rows.Item("Programe_name") = Me.Name
                End If
            Next

            For Each rows As DataRow In dsete.Tables("SOB").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("Last_Create_Date") = tglSO.Text
                    rows.Item("Last_Created_By") = username
                    rows.Item("kd_Cabang") = kdcabang
                    rows.Item("No_sp") = txtNomor.Text
                    rows.Item("Status") = "Y"
                    rows.Item("departemen") = KD_DIV_SPON
                    rows.Item("Programe_name") = Me.Name
                ElseIf rows.RowState <> DataRowState.Deleted Then
                    rows.Item("Last_Update_Date") = getTanggal(BTRANS)
                    rows.Item("Last_Updated_By") = username
                    rows.Item("Programe_name") = Me.Name
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

            DA.Update(dsete.Tables("SO"))
            DAD.Update(dsete.Tables("SOD"))
            DAB.Update(dsete.Tables("SOB"))

            'untuk insert kode ukuran apabila kosiong
            'Dim cmd As New SqlCommand
            'cmd.Connection = sqlconn
            'cmd.Transaction = BTRANS
            'cmd.CommandText = "SALES.[dbo].add_ukuran_box"
            'cmd.ExecuteNonQuery()

            BTRANS.Commit()
            State = "EDIT"
            showMessages("Transaksi Telah Diproses")
            If Not dsete.Tables("SOB") Is Nothing Then dsete.Tables("SOB").Clear()
            DAB = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from Sales.dbo.SALES_SOBOX_D where no_sp='" & txtNomor.Text & "'", sqlconn))
            DAB.Fill(dsete, "SOB")
            If Not dsete.Tables("UKURAN") Is Nothing Then dsete.Tables("UKURAN").Clear()
            dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.sif_ukuran where rec_stat='Y' and isnull(Tinggi,0) > 0 and isnull(Panjang,0) > 0 and isnull(Lebar,0) > 0 ", sqlconn))
            dadbe.Fill(dsete, "UKURAN")

            GV.CollapseAllDetails()
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
            Dim harga As Double = 0
            If GV.GetRow(e.RowHandle).item("qty").ToString = "" Then GV.GetRow(e.RowHandle).item("qty") = 0
            GV.GetRow(e.RowHandle).item("Total") = 0

            rw = dsete.Tables("VBARANG").Select("Kode_Barang='" & e.Value & "'")(0)
            GV.GetRow(e.RowHandle).item("Kd_satuan") = rw("Kd_Satuan")

            'If rw("isset").ToString = "1" Then Exit Sub
            GV.GetRow(e.RowHandle).item("harga") = 0
            GV.GetRow(e.RowHandle).item("total") = 0
   
            For Each rwx As DataRow In dsete.Tables("SOB").Select("no_seq_d='" & GV.GetRowCellValue(e.RowHandle, "No_seq") & "'")
                rwx("Kd_Stok") = e.Value
            Next

        End If
    End Sub
    Private Sub GV_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanging
        If GV.GetRowCellValue(e.RowHandle, "Kd_Stok") Is Nothing Then Exit Sub
        kd_stok_old = GV.GetRowCellValue(e.RowHandle, "Kd_Stok").ToString
        'For Each rwx As DataRow In dsete.Tables("SOB").Select("no_seq_d='" & GV.GetRowCellValue(e.RowHandle, "No_seq") & "'")
        '    If rwx.RowState <> DataRowState.Deleted Then rwx("kd_stok") = e.Value
        'Next
    End Sub
    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.GetRow(e.RowHandle).item("No_seq") = GV.RowCount + 1
        GV.SetRowCellValue(e.RowHandle, "Qty", 1)

    End Sub
    Private Sub GV_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub gv2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gv2.CellValueChanged
        'Dim gvd As Object = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Grid.GridView)
        If e.Column.Name = "Kode_Ukuran" Then
            With dsete.Tables("UKURAN").Select("Kode_Ukuran='" & e.Value & "'")(0)
                sender.SetRowCellValue(e.RowHandle, "panjang", .Item("Panjang"))
                sender.SetRowCellValue(e.RowHandle, "lebar", .Item("Lebar"))
                sender.SetRowCellValue(e.RowHandle, "tebal", .Item("Tinggi"))
            End With
        End If
    End Sub

    Private Sub gv2_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gv2.InitNewRow
        sender.SetRowCellValue(e.RowHandle, "No_seq", sender.RowCount)
    End Sub
    Private Sub GV2_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gv2.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Private Sub GV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Daftar Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar SP") = MsgBoxResult.Yes Then
                    For Each row In dsete.Tables("SOB").Select("no_seq_d='" & GV.GetRowCellValue(GV.GetSelectedRows(0), "No_seq") & "'")
                        row.Delete()
                    Next
                    GV.DeleteSelectedRows()

                End If
            End If
        End If
    End Sub
    Private Sub gv2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gv2.KeyDown
        If e.KeyCode = Keys.Delete Then
            If MsgBox("Hapus Daftar Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar SP") = MsgBoxResult.Yes Then
                no_seqdelete = sender.GetRowCellValue(sender.GetSelectedRows(0), "no_seq_d")
                sender.DeleteSelectedRows()
                hitung_total()
            End If
        End If
    End Sub
    Private Sub GV2_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gv2.RowUpdated


        Dim sql As String = "Tinggi = '" & e.Row("tebal") & "' and Lebar = '" & e.Row("lebar") & "' and Panjang = '" & e.Row.item("panjang") & "'"
        Dim x As DataRow() = dsete.Tables("UKURAN").Select(sql)
        If x.Count = 0 Then
            e.Row.item("Kode_Ukuran") = vbNullString
        Else
            e.Row.item("Kode_Ukuran") = x(0)("Kode_Ukuran").ToString
        End If

        hitung_total()

    End Sub
    Private Sub GV2_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gv2.ValidateRow
        Dim isValid As Boolean = True
        'Dim GVS As DevExpress.XtraGrid.Views.Grid.GridView = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Grid.GridView)
        set_tebal_lebar(sender, e)
        If e.Row.item("tebal").ToString = "" Then
            isValid = False
            sender.SetColumnError(sender.Columns("tebal"), "Harap Mengisi Jumlah Tebal.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        ElseIf e.Row.item("tebal") < 0 Then
            isValid = False
            sender.SetColumnError(sender.Columns("tebal"), "Harap Mengisi Jumlah Tebal Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("lebar").ToString = "" Then
            isValid = False
            sender.SetColumnError(sender.Columns("lebar"), "Harap Mengisi Jumlah Lebar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        ElseIf e.Row.item("lebar") < 0 Then
            isValid = False
            sender.SetColumnError(sender.Columns("lebar"), "Harap Mengisi Jumlah Lebar Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("panjang").ToString = "" Then
            isValid = False
            sender.SetColumnError(sender.Columns("panjang"), "Harap Mengisi Jumlah Panjang.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        ElseIf e.Row.item("panjang") < 0 Then
            isValid = False
            sender.SetColumnError(sender.Columns("panjang"), "Harap Mengisi Jumlah Panjang Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("tebal").ToString = "" Then
            isValid = False
            sender.SetColumnError(sender.Columns("tebal"), "Harap Mengisi Jumlah Tebal.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        ElseIf e.Row.item("tebal") < 0 Then
            isValid = False
            sender.SetColumnError(sender.Columns("tebal"), "Harap Mengisi Jumlah Tebal Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("Qty").ToString <> "" Then
            If e.Row.item("Qty") <= 0 Then
                isValid = False
                sender.SetColumnError(sender.Columns("Qty"), "Harap Mengisi Jumlah Kuantitas Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        Else
            isValid = False
            sender.SetColumnError(sender.Columns("Qty"), "Harap Mengisi Jumlah Kuantitas.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        e.Valid = isValid
    End Sub
    Private Sub set_tebal_lebar(ByVal sender As Object, ByVal e As Object)
        Exit Sub
        If (e.RowHandle < 0 And sender.RowCount > 1) Or e.RowHandle > 0 Then
            With sender.GetRow(0)
                sender.SetRowCellValue(e.RowHandle, "tebal", .item("tebal"))
                sender.SetRowCellValue(e.RowHandle, "lebar", .item("lebar"))
            End With
            sender.FocusedColumn = sender.Columns("panjang")
        ElseIf e.RowHandle = 0 And sender.RowCount > 1 Then
            For i As Int16 = 1 To sender.RowCount - 2
                With sender.GetRow(0)
                    sender.SetRowCellValue(i, "tebal", .item("tebal"))
                    sender.SetRowCellValue(i, "lebar", .item("lebar"))
                End With
            Next
        End If
    End Sub
    Private Sub GV_MasterRowExpanding(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventArgs) Handles GV.MasterRowExpanding
        If Microsoft.VisualBasic.Right(Microsoft.VisualBasic.Left(GV.GetRowCellValue(e.RowHandle, "Kd_Stok"), 6), 3) = "040" Then
            e.Allow = False
        End If
    End Sub
    Private Sub GV_MasterRowGetLevelDefaultView(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs) Handles GV.MasterRowGetLevelDefaultView
        rhandle = e.RowHandle

    End Sub
    Private Sub GV_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV.RowUpdated
        GV.ExpandMasterRow(GV.GetSelectedRows(0), "Detail")
    End Sub
    Private Sub GV_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        Dim isValid As Boolean = True
        If e.Row.item("Kd_Stok").ToString = "" Then
            isValid = False
            GV.SetColumnError(Kd_Stok, "Harap Memilih Barang Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("Qty") < 0 Then
            isValid = False
            GV.SetColumnError(Qty, "Harap Mengisi Jumlah Kuantitas Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        Dim rw() As DataRow = dsete.Tables("SOD").Select("Kd_Stok = '" & e.Row.item("Kd_Stok") & "'")
        If rw.Count = 1 Then
            If Not rw(0) Is e.Row.row Then
                isValid = False
                GV.SetColumnError(Kd_Stok, "Kode Barang Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            End If
        End If
        e.Valid = isValid
    End Sub
    Public Sub add_click()
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        State = "ADD"
        setStatus()
        setReadOnly()
    End Sub
    Public Sub cancel_click()
        State = ""
        DT_TglSO.EditValue = Now.Date
        GV.CollapseAllDetails()
        loadTable("XXX")
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
    End Sub
   
    Public Sub edit_click()
        If Not Me.Controls("frmBukuOrder") Is Nothing Then Exit Sub
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_sp as [Nomor], tgl_sp as [Tanggal], tipe_trans , [Nama_Customer] from sales.dbo.[VSO_REP] where tipe_trans =  '" & CentianInternal & "' order by tgl_sp ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        
        If Not dsete.Tables("lookup_so") Is Nothing Then dsete.Tables("lookup_so").Clear()
        dadbe.Fill(dsete, "lookup_so")
        frmCari.set_dso(dsete.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.GV.Columns(2).Visible = False
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            btnadd = False
            btnEdit = False
            btnSave = True
            btnDelete = True
            isLoading = True
            loadTable(frmCari.row(0))
            isLoading = False
            State = "EDIT"
            If dsete.Tables("SO").Rows(0)("Status") <> "OK" Then lblStatus.Text = dsete.Tables("SO").Rows(0)("Status")
            DT_TglSO.EditValue = dsete.Tables("SO").Rows(0)("Tgl_sp")
            btnCancel = True
            Me.Enabled = True

            setStatus()
            setReadOnly()
        Else
            cancel_click()
            State = ""
        End If
    End Sub
    Private Sub repket_ButtonClick1(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repket.ButtonClick
        If GV.FocusedValue Is Nothing Then Exit Sub
        popDesk.Show()
        txtDesk.Text = GV.FocusedValue.ToString
    End Sub
    Private Sub txtDesk_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDesk.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtDesk.Text = "" Then Exit Sub
            GV.GetFocusedDataRow.Item("Keterangan") = txtDesk.Text
            popDesk.Hide()
            GV.Focus()
        ElseIf e.KeyCode = Keys.Escape Then
            popDesk.Hide()
            GV.Focus()
        End If
    End Sub
    Private Function getdataTable(ByVal i As Integer, ByVal rel As Integer) As DataTable
        Dim tbl As New DataTable
        Dim rw As DataRow
        tbl.Columns.Add("T", System.Type.GetType("System.Double"))
        tbl.Columns.Add("L", System.Type.GetType("System.Double"))
        tbl.Columns.Add("P", System.Type.GetType("System.Double"))
        tbl.Columns.Add("%", System.Type.GetType("System.Double"))
        tbl.Columns.Add("V", System.Type.GetType("System.Double"))
        tbl.Columns.Add("J", System.Type.GetType("System.Double"))
        tbl.Columns.Add("Q", System.Type.GetType("System.Double"))
        tbl.Columns.Add("QR", System.Type.GetType("System.Double"))
        tbl.Columns.Add("QQ", System.Type.GetType("System.Double"))
        tbl.Columns.Add("Kode_Ukuran", System.Type.GetType("System.String"))
        For Each rws As DataRow In dsete.Tables("SOB").Select("no_seq_d = '" & GV.GetRowCellValue(i, "No_seq") & "'")
            rw = tbl.NewRow()
            rw("T") = rws("tebal")
            rw("L") = rws("lebar")
            rw("P") = rws("panjang")
            rw("Q") = rws("Qty")
            rw("QR") = rws("Qty")
            rw("Kode_Ukuran") = rws("Kode_Ukuran")
            tbl.Rows.Add(rw)
        Next

        Return tbl
    End Function
    Private Sub repSim_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repSim.ButtonClick

        If e.Button.Tag = "H" Then
            If GV.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Daftar Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar SP") = MsgBoxResult.Yes Then
                    For Each row In dsete.Tables("SOB").Select("no_seq_d='" & GV.GetRowCellValue(GV.GetSelectedRows(0), "No_seq") & "'")
                        row.Delete()
                    Next
                    GV.DeleteSelectedRows()

                End If
            End If
        Else
            Dim i As Int16 = rhandle
            If Not frmSimulasi.tbl Is Nothing Then frmSimulasi.tbl.Clear()
            frmSimulasi.tbl = getdataTable(i, 0)
            frmSimulasi.lblBox.Text = GV.GetRowCellDisplayText(i, "Kd_Stok")
            frmSimulasi.lblQty.Text = GV.GetRowCellValue(i, "Qty")
            frmSimulasi.ShowDialog()
            If frmSimulasi.ret Then
                'Dim rw As DataRow
                Dim vol3 As Double = 0
                For Each rws As DataRow In frmSimulasi.tbl.Rows
                    For Each rwx As DataRow In dsete.Tables("SOB").Select("no_seq_d = '" & GV.GetRowCellValue(i, "No_seq") & "'")
                        If (rwx("tebal") & "-" & rwx("lebar") & "-" & rwx("panjang")) = (rws("T") & "-" & rws("L") & "-" & rws("P")) Then
                            'If rwx("Kode_Ukuran") = rws("Kode_Ukuran") Then
                            rwx("Qty") = IIf(rws("QQ").ToString = "", rws("Q"), rws("QQ"))
                            If State = "EDIT" Then rwx("No_sp") = txtNomor.Text
                            rwx("Kd_Cabang") = kdcabang
                            vol3 += rwx("tebal") * rwx("lebar") * rwx("panjang") * rwx("Qty")
                            Exit For

                        End If
                    Next
                Next
                If vol3 > 0 Then
                    GV.SetRowCellValue(rhandle, "vol", vol3 / 1000000)
                Else
                    GV.SetRowCellValue(rhandle, "vol", 0)
                End If
            End If
        End If
    End Sub
    
    Public Sub cetak_click()
        If State = "EDIT" And txtNomor.Text.Length > 10 Then
            Try
                Dim i As Int16 = New SqlCommand("update sales.dbo.sales_so set cetakke= isnull(CetakKe,0)+1, isPrinted='Y' where no_sp='" & txtNomor.Text & "' and isnull(isprinted,'') <> 'Y' ", sqlconn).ExecuteNonQuery
                If i > 0 Then
                    callReport(App_Path() & "\report\cSoBox.rpt", "", "PSO=" & txtNomor.Text, True, True)
                Else
                    MsgBox("Dokumen Sudah Pernah Dicetak ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Perhatian")
                End If
            Catch e As Exception
                MsgBox("Gagal Cetak " & e.Message)
            End Try
        End If
    End Sub
   
    Private Sub repDelD_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repDelD.ButtonClick
        ' perlu perbaikan lebih lanjut
        Dim gvs As DevExpress.XtraGrid.Views.Grid.GridView = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Grid.GridView)
        If gvs.GetSelectedRows.Count > 0 Then
            If MsgBox("Hapus Daftar Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar SP") = MsgBoxResult.Yes Then
                no_seqdelete = gvs.GetRowCellValue(gvs.GetSelectedRows(0), "no_seq_d")
                gvs.DeleteSelectedRows()
                hitung_total()
            End If
        End If
    End Sub
    Private Sub hitung_total()
        Dim volum As Double = 0
        For Each row As DataRow In dsete.Tables("SOB").Select("no_seq_d=" & GV.GetRowCellValue(rhandle, "No_seq"))

            If "0" & row("qty").ToString > 0 Then volum += row("qty") * row("panjang") * row("lebar") * row("tebal")
        Next

        If volum > 0 Then
            GV.SetRowCellValue(rhandle, "vol", volum / 1000000)
        Else
            GV.SetRowCellValue(rhandle, "vol", 0)
        End If
    End Sub
    Private Sub DT_TglSO_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DT_TglSO.EditValueChanged
        tglSO.Text = DT_TglSO.EditValue
    End Sub
End Class