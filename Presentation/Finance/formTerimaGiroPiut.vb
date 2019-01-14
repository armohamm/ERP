Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns

Public Class formTerimaGiroPiut
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = True
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, ds_cari, ds_cari1 As New DataSet
    'Private rw As DataRow
    Dim DA, DALOOKUP, DALOOKUP1, daDel, daDel2 As SqlDataAdapter
    Dim noGiro() As String
    Dim nG() As String
    Dim stat() As String
    Dim jml As Integer = 0
    Dim isValid As Boolean = True
    Dim err As String
    Dim giro As String
    Dim statE As Boolean = False
    Dim isOK As Boolean = False
    Dim tipe() As String
    Dim BTRANS As SqlTransaction

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = False
        btnDelete = True
        setStatus()
        'STATE = "ADD" '<-- set state add

    End Sub

    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    'Public Sub exit_click()
    '    If MsgBox("Form Approve akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
    '    Me.Close()
    'End Sub

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

    Public Sub simpan(Optional ByRef isDelete As Boolean = False)
        Dim builder As New SqlCommandBuilder(DA)
        Dim builder1 As New SqlCommandBuilder(daDel)
        Dim builder2 As New SqlCommandBuilder(daDel2)
        ReDim noGiro(0)
        ReDim stat(0)
        ReDim nG(0)
        ReDim tipe(0)
        If Not isDelete = True Then
            For Each rw As DataRow In dSO.Tables("_SIF_COA").Rows
                If rw.RowState = DataRowState.Added Then
                    noGiro(noGiro.Length - 1) = rw.Item("idrec")
                    rw("Last_Create_Date") = Now
                    rw("Last_Created_By") = umum.username
                    rw("Program_Name") = Me.Name
                    rw("jns_trans") = "JUAL"
                    rw("Kd_Cabang") = getKodeCabang()
                    rw("status") = "DITERIMA"
                    tipe(tipe.Length - 1) = rw.Item("tipe_trans")
                    ReDim Preserve noGiro(noGiro.Length)
                    ReDim Preserve tipe(tipe.Length)
                ElseIf rw.RowState = DataRowState.Modified Then
                    noGiro(noGiro.Length - 1) = rw.Item("idrec")
                    nG(nG.Length - 1) = rw.Item("idrec")
                    stat(stat.Length - 1) = rw.Item("status")
                    rw.Item("Last_Update_Date") = Now
                    rw.Item("Last_Updated_By") = username
                    tipe(tipe.Length - 1) = rw.Item("tipe_trans")
                    ReDim Preserve tipe(tipe.Length)
                    ReDim Preserve noGiro(noGiro.Length)
                    'isOK = True
                End If
            Next

            'If isOK = True Then
            '    For i As Integer = 0 To nG.Length - 1
            '        If Not stat(i).Equals("DITERIMA") Then
            '            err &= "Status giro " & nG(i) & " sudah ditutup. Tidak boleh ada perubahan." & vbCrLf
            '            isValid = False
            '        Else
            '            isValid = True
            '        End If
            '    Next
            '    isOK = False
            'End If

            'If isValid = True Then
            Try
                DA.InsertCommand = builder.GetInsertCommand()
                DA.UpdateCommand = builder.GetUpdateCommand()
                DA.DeleteCommand = builder.GetDeleteCommand()

                BTRANS = sqlconn.BeginTransaction("1")
                DA.UpdateCommand.Transaction = BTRANS
                DA.InsertCommand.Transaction = BTRANS
                DA.DeleteCommand.Transaction = BTRANS

                DA.Update(dSO, "_SIF_COA")
                dSO.Tables("_SIF_COA").AcceptChanges()
                For jml As Integer = 0 To noGiro.Length - 2
                    call_procedure(tipe(jml), noGiro(jml), BTRANS)
                Next
                BTRANS.Commit()
                showMessages("Data Berhasil di Update..!", 14)
                loadAll()
            Catch ex As Exception
                If ex.Message.Contains("PRIMARY") Then
                    MsgBox("Detail data baru yang diinputkan sama dengan data yang lama", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                End If
                BTRANS.Rollback()
                dSO.Tables("_SIF_COA").RejectChanges()
                err = ""
                isValid = True
                ReDim stat(0)
                ReDim nG(0)
            End Try
            'Else
            '    MsgBox("Ada kesalahan dalam pengisian data." & vbCrLf & err, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            '    dSO.Tables("_SIF_COA").RejectChanges()
            '    err = ""
            '    isValid = True
            '    ReDim stat(0)
            '    ReDim nG(0)
            'End If
        Else
            DA.InsertCommand = builder.GetInsertCommand()
            DA.UpdateCommand = builder.GetUpdateCommand()
            DA.DeleteCommand = builder.GetDeleteCommand()

            daDel.InsertCommand = builder1.GetInsertCommand()
            daDel.UpdateCommand = builder1.GetUpdateCommand()
            daDel.DeleteCommand = builder1.GetDeleteCommand()

            daDel2.InsertCommand = builder2.GetInsertCommand()
            daDel2.UpdateCommand = builder2.GetUpdateCommand()
            daDel2.DeleteCommand = builder2.GetDeleteCommand()

            DA.Update(dSO, "_SIF_COA")
            daDel.Update(dSO, "JurnalDel")
            daDel2.Update(dSO, "JurnalDDel")

            dSO.Tables("_SIF_COA").AcceptChanges()
            showMessages("Data Berhasil di Hapus..!", 14)
            loadAll()
        End If
    End Sub

    Public Sub hapus_record()
        Dim builder As New SqlCommandBuilder(DA)
        Dim row As DataRow
        Dim rows() As DataRow
        Dim i As Integer

        ReDim rows(GvMstCOA.SelectedRowsCount - 1)
        For i = 0 To GvMstCOA.SelectedRowsCount - 1
            rows(i) = GvMstCOA.GetDataRow(GvMstCOA.GetSelectedRows(i))
        Next
        GvMstCOA.BeginSort()
        Try
            For Each row In rows
                If row("status") = "DITERIMA" Then
                    If Not row("no_jur") = vbNullString Or row("no_jur") = "" Then
                        If Not dSO.Tables("JurnalDel") Is Nothing Then dSO.Tables("JurnalDel").Clear()
                        daDel = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_JURNAL WHERE no_jur = '" & row("no_jur") & "'", sqlconn))
                        daDel.Fill(dSO, "JurnalDel")
                        For Each rw As DataRow In dSO.Tables("JurnalDel").Rows
                            rw.Delete()
                        Next
                        If Not dSO.Tables("JurnalDDel") Is Nothing Then dSO.Tables("JurnalDDel").Clear()
                        daDel2 = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_JURNAL_D WHERE no_jur = '" & row("no_jur") & "'", sqlconn))
                        daDel2.Fill(dSO, "JurnalDDel")
                        For Each rw As DataRow In dSO.Tables("JurnalDDel").Rows
                            rw.Delete()
                        Next
                        row.Delete()
                    End If
                Else
                    MsgBox("Status giro " & row("nomor") & " sudah ditutup. Tidak boleh ada perubahan", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                    Exit Sub
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GvMstCOA.EndSort()
        End Try
        simpan(True)
    End Sub

    Private Sub formTerimaGiroPiut_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        loadAll()

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        'If formUMPiutang.transfer = "KIRIM" Then
        '    GvMstCOA.AddNewRow()
        '    Dim newRowHandle As Integer = GvMstCOA.FocusedRowHandle
        '    Dim newRow As Object = GvMstCOA.GetRow(newRowHandle)
        '    GvMstCOA.SetRowCellValue(newRowHandle, "tgl_trans", formUMPiutang.DOtanggal)
        '    GvMstCOA.SetRowCellValue(newRowHandle, "jns_giro", formUMPiutang.DOjenis)
        '    GvMstCOA.SetRowCellValue(newRowHandle, "tipe_trans", "JRR-KPT-13")
        '    GvMstCOA.SetRowCellValue(newRowHandle, "kartu", formUMPiutang.DOkartu)
        '    GvMstCOA.SetRowCellValue(newRowHandle, "kd_valuta", formUMPiutang.DOvaluta)
        '    GvMstCOA.SetRowCellValue(newRowHandle, "jml_trans", formUMPiutang.DOjml)
        '    GvMstCOA.SetRowCellValue(newRowHandle, "keterangan", keterangan)
        '    GvMstCOA.UpdateCurrentRow()
        'End If
    End Sub

    Public Sub call_procedure(ByVal tipeT As String, ByVal noG As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_AUTOMAN_JURNAL"

        sqlCmd.Parameters.Add("@tipe_trans", SqlDbType.Char).Value = tipeT
        sqlCmd.Parameters.Add("@no_inv", SqlDbType.Char).Value = noG
        Dim dr As SqlDataReader = sqlCmd.ExecuteReader
        dr.Close()
    End Sub

    Private Sub GvMstCOA_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvMstCOA.CellValueChanged
        If e.Column Is kurs_valuta Then
            If GvMstCOA.GetRowCellValue(e.RowHandle, "kurs_valuta").ToString = "0,00" Or GvMstCOA.GetRowCellValue(e.RowHandle, "kurs_valuta").ToString = "0.00" Or GvMstCOA.GetRowCellValue(e.RowHandle, "kurs_valuta").ToString = vbNullString Then
                GvMstCOA.SetRowCellValue(e.RowHandle, "kurs_valuta", "1")
            End If
        End If

        If e.Column Is kd_valuta Then
            If GvMstCOA.GetRowCellValue(e.RowHandle, "kd_valuta").ToString = "IDR" Then
                GvMstCOA.SetRowCellValue(e.RowHandle, "kurs_valuta", "1")
                GvMstCOA.Columns.Item("kurs_valuta").OptionsColumn.AllowEdit = False
            Else
                GvMstCOA.Columns.Item("kurs_valuta").OptionsColumn.AllowEdit = True
            End If
        End If
    End Sub

    Private Sub GvMstCOA_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GvMstCOA.InitNewRow
        Dim View As ColumnView = sender
        
        'View.SetRowCellValue(e.RowHandle, View.Columns("tgl_trans"), getTanggal)
        View.SetRowCellValue(e.RowHandle, View.Columns("tipe_trans"), "JRR-KPT-10")
        View.SetRowCellValue(e.RowHandle, View.Columns("kd_valuta"), "IDR")
        View.SetRowCellValue(e.RowHandle, View.Columns("divisi"), IIf(userRole = "FINRASPRING", "2", "3"))
        View.SetRowCellValue(e.RowHandle, View.Columns("kurs_valuta"), 1)
        View.SetRowCellValue(e.RowHandle, View.Columns("jns_giro"), "01")
        View.SetRowCellValue(e.RowHandle, View.Columns("kd_bank"), 1)
        View.SetRowCellValue(e.RowHandle, View.Columns("kartu"), "UMUM")
        View.SetRowCellValue(e.RowHandle, View.Columns("tgl_trans"), getTanggal())
        View.SetRowCellValue(e.RowHandle, View.Columns("tgl_jth_tempo"), getTanggal())
        View.SetRowCellValue(e.RowHandle, View.Columns("jml_trans"), 0)

    End Sub

    Private Sub loadAll()
        If Not dSO.Tables("_SIF_COA") Is Nothing Then dSO.Tables("_SIF_COA").Clear()
        If Not ds_cari.Tables("_lookup1") Is Nothing Then ds_cari.Tables("_lookup1").Clear()
        If Not ds_cari.Tables("_lookup2") Is Nothing Then ds_cari.Tables("_lookup2").Clear()
        If Not ds_cari.Tables("_lookup3") Is Nothing Then ds_cari.Tables("_lookup3").Clear()
        If Not ds_cari.Tables("_lookup5") Is Nothing Then ds_cari.Tables("_lookup5").Clear()
        If Not ds_cari.Tables("jenis") Is Nothing Then ds_cari.Tables("jenis").Clear()
        If Not ds_cari.Tables("dept") Is Nothing Then ds_cari.Tables("dept").Clear()

        DA = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_GIRO WHERE jns_trans='JUAL' and divisi = '" & IIf(userRole = "FINRASPRING", "2", "3") & "'", sqlconn))
        DA.Fill(dSO, "_SIF_COA")
        GcMstCOA.DataSource = dSO.Tables("_SIF_COA")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select kd_bank, nama_bank from SIF.dbo.SIF_Bank", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        lookupbank.DataSource = ds_cari.Tables("_lookup1")
        lookupbank.ValueMember = "kd_bank"
        lookupbank.DisplayMember = "nama_bank"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kd_Departemen, Nama_Departemen from SIF.dbo.SIF_Departemen where Kd_Departemen = '" & IIf(userRole = "FINRASPRING", "2", "3") & "'", sqlconn))
        DALOOKUP.Fill(ds_cari, "dept")
        lookupdivisi.DataSource = ds_cari.Tables("dept")
        lookupdivisi.ValueMember = "Kd_Departemen"
        lookupdivisi.DisplayMember = "Nama_Departemen"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select kd_customer kode, nama_customer nama from SIF.dbo.SIF_Customer where rec_stat = 'Y' order by nama", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup2")
        lookupkartu.DataSource = ds_cari.Tables("_lookup2")
        lookupkartu.ValueMember = "kode"
        lookupkartu.DisplayMember = "nama"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Valuta, Nama_Valuta from SIF.dbo.SIF_Valuta", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup3")
        lookupval.DataSource = ds_cari.Tables("_lookup3")
        lookupval.ValueMember = "Kode_Valuta"
        lookupval.DisplayMember = "Nama_Valuta"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select tipe_trans, attribut1 from SIF.dbo.SIF_TIPE_TRANS WHERE tipe_trans='JRR-KPT-10' OR tipe_trans='JRR-KPT-13'", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup5")
        lookupGiro.DataSource = ds_cari.Tables("_lookup5")
        lookupGiro.ValueMember = "tipe_trans"
        lookupGiro.DisplayMember = "attribut1"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT Id_Data, Desc_Data FROM SIF.dbo.SIF_Gen_Reff_D WHERE Id_Ref_Data='JNSBYR' AND Id_Data IN ('01','02')", sqlconn))
        DALOOKUP.Fill(ds_cari, "jenis")
        lookupJenis.DataSource = ds_cari.Tables("jenis")
        lookupJenis.ValueMember = "Id_Data"
        lookupJenis.DisplayMember = "Desc_Data"
    End Sub

    Public Sub delete_click()
        Dim viewGiro As ColumnView = GvMstCOA
        giro = viewGiro.GetFocusedRowCellValue("nomor").ToString
        If MsgBox("Hapus giro dengan nomor " & giro & " ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "HAPUS?") = MsgBoxResult.Yes Then hapus_record()
    End Sub

    Private Sub GvMstCOA_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GvMstCOA.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub GvMstCOA_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles GvMstCOA.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub GvMstCOA_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GvMstCOA.KeyDown
        Dim x As Object
        x = CType(GcMstCOA.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)

        If e.KeyCode = Keys.Delete Then
            x.DeleteSelectedRows()
        End If
    End Sub

    Private Sub GvMstCOA_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GvMstCOA.ValidateRow
        Dim view As ColumnView = CType(sender, ColumnView)
        Dim column1 As GridColumn = view.Columns("nomor")
        Dim column2 As GridColumn = view.Columns("tgl_jth_tempo")
        Dim column3 As GridColumn = view.Columns("tgl_trans")
        Dim column4 As GridColumn = view.Columns("divisi")
        Dim column5 As GridColumn = view.Columns("kd_bank")
        Dim column6 As GridColumn = view.Columns("kartu")
        Dim column7 As GridColumn = view.Columns("jml_trans")
        If Not (view.GetRowCellValue(e.RowHandle, column3).ToString = vbNullString Or view.GetRowCellValue(e.RowHandle, column2).ToString = vbNullString) Then
            'If view.GetRowCellValue(e.RowHandle, column3) > view.GetRowCellValue(e.RowHandle, column2) Then
            '    e.Valid = False
            '    view.SetColumnError(column3, "Tanggal transaksi melebihi tanggal jatuh tempo.")
            'End If
        Else
            If view.GetRowCellValue(e.RowHandle, column3).ToString = vbNullString Then
                e.Valid = False
                view.SetColumnError(column3, "Tanggal transaksi tidak boleh kosong.")
            Else
                e.Valid = True
            End If
            If view.GetRowCellValue(e.RowHandle, column2).ToString = vbNullString Then
                e.Valid = False
                view.SetColumnError(column2, "Tanggal jatuh tempo tidak boleh kosong.")
            Else
                e.Valid = True
            End If
        End If

        If view.GetRowCellValue(e.RowHandle, column1).ToString = vbNullString Then
            e.Valid = False
            view.SetColumnError(column1, "Nomor giro harus diisi.")
        Else
            e.Valid = True
        End If

        If view.GetRowCellValue(e.RowHandle, column4).ToString = vbNullString Then
            view.SetRowCellValue(e.RowHandle, column4, "2")
        End If

        If view.IsNewItemRow(e.RowHandle) Then
            Dim no As String = view.GetFocusedRowCellValue("nomor")
            Dim divisi As String = view.GetFocusedRowCellValue("divisi")
            Dim bank As Integer = view.GetFocusedRowCellValue("kd_bank")
            Dim kartu As String = view.GetFocusedRowCellValue("kartu")
            Dim jml As String = view.GetFocusedRowCellValue("jml_trans")
            For i As Integer = 0 To GvMstCOA.RowCount - 1
                If no = GvMstCOA.GetRowCellValue(i, column1) And divisi = GvMstCOA.GetRowCellValue(i, column4).ToString And bank = GvMstCOA.GetRowCellValue(i, column5).ToString And kartu = GvMstCOA.GetRowCellValue(i, column6).ToString Then
                    e.Valid = False
                    view.SetColumnError(column1, "Kombinasi nomor giro, divisi, bank dan kartu sudah ada.")
                    view.SetColumnError(column4, "Kombinasi nomor giro, divisi, bank dan kartu sudah ada.")
                    view.SetColumnError(column5, "Kombinasi nomor giro, divisi, bank dan kartu sudah ada.")
                    view.SetColumnError(column6, "Kombinasi nomor giro, divisi, bank dan kartu sudah ada.")
                    Exit For
                Else
                    e.Valid = True
                    view.SetColumnError(column1, "")
                    view.SetColumnError(column4, "")
                    view.SetColumnError(column5, "")
                    view.SetColumnError(column6, "")
                End If

                If Not no.Length = 6 Then
                    e.Valid = False
                    view.SetColumnError(column1, "Nomor giro harus 6 digit.")
                End If

                If jml = 0 Then
                    e.Valid = False
                    view.SetColumnError(column7, "Jumlah tidak boleh 0.")
                End If
            Next
        End If

        If e.Valid = True Then
            view.SetRowCellValue(e.RowHandle, "idrec", view.GetRowCellValue(e.RowHandle, "nomor").ToString & "JUAL" & view.GetRowCellValue(e.RowHandle, "divisi").ToString & CStr(view.GetRowCellValue(e.RowHandle, "kd_bank").ToString) & view.GetRowCellValue(e.RowHandle, "kartu").ToString)
        End If
    End Sub

    Private Sub GvMstCOA_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GvMstCOA.ValidatingEditor

        Dim vx As GridView = sender
        'If vx.FocusedColumn.FieldName = "tgl_jth_tempo" Then
        '    Dim tglApp As Date = Convert.ToDateTime(e.Value)
        '    If tglApp < vx.GetFocusedRowCellValue("tgl_trans") Then
        '        e.Valid = False
        '        e.ErrorText = "Tanggal jatuh tempo tidak boleh sebelum tanggal transaksi."
        '    End If
        'End If

        Try
            If vx.GetFocusedRowCellValue("status") = "DITERIMA" Then
                Dim no As String = e.Value
                Dim divisi As String = vx.GetFocusedRowCellValue("divisi")
                Dim bank As Integer = vx.GetFocusedRowCellValue("kd_bank")
                Dim kartu As String = vx.GetFocusedRowCellValue("kartu")
                For i As Integer = 0 To GvMstCOA.RowCount - 1
                    If no = GvMstCOA.GetRowCellValue(i, "nomor") And divisi = GvMstCOA.GetRowCellValue(i, "divisi") And bank = GvMstCOA.GetRowCellValue(i, "kd_bank") And kartu = GvMstCOA.GetRowCellValue(i, "kartu") Then
                        'e.Valid = False
                        e.ErrorText = "Nomor giro kembar."
                        MsgBox("Nomor giro kembar.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                        'e.Value = vbNullString
                    End If
                Next
            Else
                e.ErrorText = "Giro " & vx.GetFocusedRowCellValue("nomor").ToString & " sudah ditutup. Tidak boleh ada perubahan."
                e.Valid = False
            End If
        Catch ex As Exception

        End Try
    End Sub
    
    Private Sub txtnominal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtnominal.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 8, 45, 127
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub
End Class