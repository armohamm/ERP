'|---------------------------
'|  CREATED BY UNKNOWN      |
'|  EDITED BY RENDY         |
'|---------------------------
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns

Public Class frmPengeluaranGiro

    Dim BTRANS As SqlTransaction

    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = True
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public prn As frmMain
    Dim dSO, ds_cari As New DataSet
    Dim rl, r2 As DataRelation
    Dim DA, DAD, DALOOKUP, DALOOKUP1, daDel, daDel2 As SqlClient.SqlDataAdapter
    Dim noGiro() As String
    Dim nG() As String
    Dim stat() As String
    Dim tipe() As String
    Dim isOK As Boolean = False
    Dim isValid As Boolean = True
    Dim err, giro As String
    Dim rhandel As Integer

    Private Sub loadRek()
        If Not ds_cari.Tables("Rekening") Is Nothing Then ds_cari.Tables("Rekening").Clear()

        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT kd_buku_besar, nm_buku_besar FROM SIF.dbo.SIF_buku_besar WHERE Rec_stat = 'Y' AND div2 = 'Y'", sqlconn))
        DALOOKUP.Fill(ds_cari, "Rekening")
        lookUpRekening.DataSource = ds_cari.Tables("Rekening")
        lookUpRekening.ValueMember = "kd_buku_besar"
        lookUpRekening.DisplayMember = "nm_buku_besar"
        GridView1.Columns("kd_buku_besar").Visible = False
    End Sub

    Private Sub loadAll()
        dSO = New DataSet
        If Not ds_cari.Tables("_lookup4") Is Nothing Then ds_cari.Tables("_lookup4").Clear()
        If Not ds_cari.Tables("_lookup6") Is Nothing Then ds_cari.Tables("_lookup6").Clear()
        If Not ds_cari.Tables("_lookup7") Is Nothing Then ds_cari.Tables("_lookup7").Clear()
        If Not ds_cari.Tables("_lookup1") Is Nothing Then ds_cari.Tables("_lookup1").Clear()
        If Not ds_cari.Tables("_lookup3") Is Nothing Then ds_cari.Tables("_lookup3").Clear()
        loadRek()

        DA = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_GIRO WHERE jns_trans = 'BELI'", sqlconn))
        DA.Fill(dSO, "_SIF_COA")

        DAD = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_GIRO_D", sqlconn))
        DAD.Fill(dSO, "_SIF_COA_DET")

        rl = dSO.Relations.Add("Relation_SIF_COA", dSO.Tables("_SIF_COA").Columns("nomor"), dSO.Tables("_SIF_COA_DET").Columns("nomor"))

        GC.DataSource = dSO.Tables("_SIF_COA")

        GC.LevelTree.Nodes.Add("Relation_SIF_COA", GV2)
        GV.BestFitColumns()

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_TIPE_TRANS where tipe_trans in ('JRR-KUT-01','JRR-KUT-03','JRR-KUT-08','JRR-KUT-09')", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup4")
        lookupjns.DataSource = ds_cari.Tables("_lookup4")
        lookupjns.ValueMember = "tipe_trans"
        lookupjns.DisplayMember = "accronim_desc"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select * from sif.dbo.SIF_Gen_Reff_D where id_ref_data='JNSBYR' and rec_stat='Y'", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup6")
        lookupGiro.DataSource = ds_cari.Tables("_lookup6")
        lookupGiro.ValueMember = "Id_Data"
        lookupGiro.DisplayMember = "Desc_Data"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT x.* FROM (select Kode_Supplier kode , Nama_Supplier nama, 'SUPPLIER' stat from SIF.dbo.SIF_Supplier where Rec_Stat = 'Y' UNION ALL SELECT Kd_Customer kode, Nama_Customer nama, 'CUSTOMER' stat FROM SIF.dbo.SIF_Customer WHERE Rec_stat = 'Y') x ORDER BY x.nama ", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup7")
        lookUpSupplier.DataSource = ds_cari.Tables("_lookup7")
        lookUpSupplier.ValueMember = "kode"
        lookUpSupplier.DisplayMember = "nama"
        RepositoryItemGridLookUpEdit1View.Columns("kode").Visible = False

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select kd_bank, nama_bank from SIF.dbo.SIF_Bank ", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        lookupbank.DataSource = ds_cari.Tables("_lookup1")
        lookupbank.ValueMember = "kd_bank"
        lookupbank.DisplayMember = "nama_bank"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Valuta, Nama_Valuta from SIF.dbo.SIF_Valuta", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup3")
        lookupval.DataSource = ds_cari.Tables("_lookup3")
        lookupval.ValueMember = "Kode_Valuta"
        lookupval.DisplayMember = "Nama_Valuta"

        GenNoInv()
    End Sub

    Private Sub frmPengeluaranGiro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        loadAll()

        If GV.Columns("status").Visible = True Then
            GV.Columns("status").Visible = False
            GV.Columns("jns_trans").Visible = False
            GV.Columns("jns_giro").Visible = False
            cmdAdvance.Text = "Advance"
        End If

    End Sub

    Sub GenNoInv()
        Try
            If Not ds_cari.Tables("LOV_PEM") Is Nothing Then ds_cari.Tables("LOV_PEM").Clear()

            DALOOKUP = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_PEMBELIAN where kd_supplier = '" & GV.GetFocusedRowCellValue("kartu").ToString & "' and kd_valuta = '" & GV.GetFocusedRowCellValue("kd_valuta").ToString & "'", sqlconn))
            DALOOKUP.Fill(ds_cari, "LOV_PEM")
            LOVnoINV.DataSource = ds_cari.Tables("LOV_PEM")
            LOVnoINV.ValueMember = "no_inv"
            LOVnoINV.DisplayMember = "no_inv"
        Catch ex As Exception
            'MsgBox("First Data, Please input data")
        End Try
    End Sub

    Public Sub add_click()

        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = False
        btnDelete = True
        setStatus()
        'STATE = "ADD" '<-- set state add

    End Sub

    Sub delete_click()
        Dim viewGiro As ColumnView = GV
        giro = Microsoft.VisualBasic.Left(viewGiro.GetFocusedRowCellValue("idrec").ToString, 6)
        If MsgBox("Hapus giro dengan nomor " & giro & " ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "HAPUS?") = MsgBoxResult.Yes Then hapus_record()
    End Sub

    Private Sub loadHapus(ByVal kode As String)
        Dim row As DataRow
        If Not ds_cari.Tables("_SIF_COA") Is Nothing Then ds_cari.Tables("_SIF_COA").Clear()
        If Not ds_cari.Tables("_SIF_COA_DET") Is Nothing Then ds_cari.Tables("_SIF_COA_DET").Clear()
        If Not ds_cari.Tables("Jurnal") Is Nothing Then ds_cari.Tables("Jurnal").Clear()
        If Not ds_cari.Tables("JurnalD") Is Nothing Then ds_cari.Tables("JurnalD").Clear()

        DA = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_GIRO WHERE nomor = '" & kode & "'", sqlconn))
        DA.Fill(ds_cari, "_SIF_COA")

        DAD = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_GIRO_D WHERE nomor = '" & kode & "'", sqlconn))
        DAD.Fill(ds_cari, "_SIF_COA_DET")

        row = ds_cari.Tables("_SIF_COA").Rows(0)

        daDel = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_JURNAL WHERE no_jur = '" & row("no_jur") & "'", sqlconn))
        daDel.Fill(ds_cari, "Jurnal")

        daDel2 = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_JURNAL_D WHERE no_jur = '" & row("no_jur") & "'", sqlconn))
        daDel2.Fill(ds_cari, "JurnalD")

        If Not ds_cari.Tables("Jurnal").Rows.Count = 0 Then
            For Each rw As DataRow In ds_cari.Tables("Jurnal").Rows
                rw.Delete()
            Next
            For Each rw As DataRow In ds_cari.Tables("JurnalD").Rows
                rw.Delete()
            Next
        End If

        For Each rw As DataRow In ds_cari.Tables("_SIF_COA").Rows
            rw.Delete()
        Next
        For Each rw As DataRow In ds_cari.Tables("_SIF_COA_DET").Rows
            rw.Delete()
        Next
    End Sub

    Public Sub hapus_record()
        Dim builder As New SqlCommandBuilder(DA)
        Dim builderD As New SqlCommandBuilder(DAD)
        Dim row As DataRow
        Dim rows() As DataRow
        Dim i As Integer

        ReDim rows(GV.SelectedRowsCount - 1)
        For i = 0 To GV.SelectedRowsCount - 1
            rows(i) = GV.GetDataRow(GV.GetSelectedRows(i))
        Next
        GV.BeginSort()
        Try
            For Each row In rows
                If row("status") = "KELUAR" Then
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
            GV.EndSort()
        End Try
        simpan(True)
    End Sub

    Public Sub save_click()
        If MsgBox("Simpan data?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "SIMPAN?") = MsgBoxResult.Yes Then simpan()
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

    Public Sub simpan(Optional ByRef isDelete As Boolean = False)
        isOK = False
        isValid = True
        Dim builder As New SqlCommandBuilder(DA)
        Dim builderD As New SqlCommandBuilder(DAD)
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
                    rw("Kd_Cabang") = getKodeCabang()
                    rw("Last_Create_Date") = Now
                    rw("Last_Created_By") = umum.username
                    rw("Program_Name") = Me.Name

                    rw("jns_trans") = "BELI"
                    rw("jns_giro") = "01"
                    rw("status") = "KELUAR"
                    tipe(tipe.Length - 1) = rw.Item("tipe_trans")
                    ReDim Preserve noGiro(noGiro.Length)
                    ReDim Preserve tipe(tipe.Length)
                ElseIf rw.RowState = DataRowState.Modified Then
                    noGiro(noGiro.Length - 1) = rw.Item("idrec")
                    nG(nG.Length - 1) = rw.Item("nomor")
                    stat(stat.Length - 1) = rw.Item("status")
                    rw.Item("Last_Update_Date") = Now
                    rw.Item("Last_Updated_By") = username
                    tipe(tipe.Length - 1) = rw.Item("tipe_trans")
                    ReDim Preserve tipe(tipe.Length)
                    ReDim Preserve noGiro(noGiro.Length)
                    isOK = True
                End If
            Next

            For Each rwd As DataRow In dSO.Tables("_SIF_COA_DET").Rows
                If rwd.RowState = DataRowState.Added Then
                    rwd("Kd_Cabang") = getKodeCabang()
                    rwd("Last_Create_Date") = Now
                    rwd("Last_Created_By") = umum.username
                    rwd("Program_Name") = Me.Name

                ElseIf rwd.RowState = DataRowState.Modified Then
                    rwd("Kd_Cabang") = getKodeCabang()
                    rwd.Item("Last_Update_Date") = Now
                    rwd.Item("Last_Updated_By") = username
                End If
            Next

            If isOK = True Then
                For i As Integer = 0 To nG.Length - 1
                    If Not stat(i).Equals("KELUAR") Then
                        err &= "Status giro " & nG(i) & " sudah ditutup. Tidak boleh ada perubahan." & vbCrLf
                        isValid = False
                    Else
                        isValid = True
                    End If
                Next
                isOK = False
            End If

            If isValid = True Then
                Try
                    DA.InsertCommand = builder.GetInsertCommand()
                    DA.UpdateCommand = builder.GetUpdateCommand()
                    DA.DeleteCommand = builder.GetDeleteCommand()

                    DAD.InsertCommand = builderD.GetInsertCommand()
                    DAD.UpdateCommand = builderD.GetUpdateCommand()
                    DAD.DeleteCommand = builderD.GetDeleteCommand()

                    BTRANS = sqlconn.BeginTransaction("1")
                    DA.UpdateCommand.Transaction = BTRANS
                    DA.InsertCommand.Transaction = BTRANS
                    DA.DeleteCommand.Transaction = BTRANS

                    DAD.UpdateCommand.Transaction = BTRANS
                    DAD.InsertCommand.Transaction = BTRANS
                    DAD.DeleteCommand.Transaction = BTRANS

                    DA.Update(dSO, "_SIF_COA")
                    DAD.Update(dSO, "_SIF_COA_DET")

                    For jml As Integer = 0 To noGiro.Length - 2
                        call_procedure(tipe(jml), noGiro(jml), BTRANS)
                    Next

                    BTRANS.Commit()
                    showMessages("Data Berhasil di Update..!", 14)
                    loadAll()
                Catch ex As Exception
                    BTRANS.Rollback()
                    dSO.Tables("_SIF_COA").RejectChanges()
                    dSO.Tables("_SIF_COA_DET").RejectChanges()
                    err = ""
                    isValid = True
                    ReDim stat(0)
                    ReDim nG(0)
                End Try
            Else
                MsgBox("Ada kesalahan dalam pengisian data." & vbCrLf & err, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                dSO.Tables("_SIF_COA").RejectChanges()
                dSO.Tables("_SIF_COA_DET").RejectChanges()
                err = ""
                isValid = True
                ReDim stat(0)
                ReDim nG(0)
            End If
        Else
            Try
                DA.InsertCommand = builder.GetInsertCommand()
                DA.UpdateCommand = builder.GetUpdateCommand()
                DA.DeleteCommand = builder.GetDeleteCommand()

                DAD.InsertCommand = builderD.GetInsertCommand()
                DAD.UpdateCommand = builderD.GetUpdateCommand()
                DAD.DeleteCommand = builderD.GetDeleteCommand()

                daDel.InsertCommand = builder1.GetInsertCommand()
                daDel.UpdateCommand = builder1.GetUpdateCommand()
                daDel.DeleteCommand = builder1.GetDeleteCommand()

                daDel2.InsertCommand = builder2.GetInsertCommand()
                daDel2.UpdateCommand = builder2.GetUpdateCommand()
                daDel2.DeleteCommand = builder2.GetDeleteCommand()

                BTRANS = sqlconn.BeginTransaction("1")
                DA.UpdateCommand.Transaction = BTRANS
                DA.InsertCommand.Transaction = BTRANS
                DA.DeleteCommand.Transaction = BTRANS

                DAD.UpdateCommand.Transaction = BTRANS
                DAD.InsertCommand.Transaction = BTRANS
                DAD.DeleteCommand.Transaction = BTRANS

                daDel.UpdateCommand.Transaction = BTRANS
                daDel.InsertCommand.Transaction = BTRANS
                daDel.DeleteCommand.Transaction = BTRANS

                daDel2.UpdateCommand.Transaction = BTRANS
                daDel2.InsertCommand.Transaction = BTRANS
                daDel2.DeleteCommand.Transaction = BTRANS

                DA.Update(dSO, "_SIF_COA")
                DAD.Update(dSO, "_SIF_COA_DET")
                daDel.Update(dSO, "JurnalDel")
                daDel2.Update(dSO, "JurnalDDel")

                dSO.Tables("_SIF_COA").AcceptChanges()
                dSO.Tables("_SIF_COA_DET").AcceptChanges()
                dSO.Tables("JurnalDel").AcceptChanges()
                dSO.Tables("JurnalDDel").AcceptChanges()

                BTRANS.Commit()

                showMessages("Data berhasil dihapus.", 14)
                loadAll()
            Catch ex As Exception
                MsgBox("Gagal hapus data." & vbCrLf & ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                BTRANS.Rollback()
                dSO.Tables("_SIF_COA").RejectChanges()
                dSO.Tables("_SIF_COA_DET").RejectChanges()
                dSO.Tables("JurnalDel").RejectChanges()
                dSO.Tables("JurnalDDel").RejectChanges()
            End Try

        End If

        'dSO.Tables("_SIF_COA").AcceptChanges()
        'MsgBox(dSO.Tables("_SIF_COA").Rows(dSO.Tables("_SIF_COA").Rows.Count - 1).Item("tipe_trans") & "," & dSO.Tables("_SIF_COA").Rows(dSO.Tables("_SIF_COA").Rows.Count - 1).Item("nomor"))

        'For Each rwx As DataRow In dSO.Tables("_SIF_COA").Rows
        '    call_procedure(rwx("tipe_trans"), rwx("nomor"), BTRANS)
        'Next

    End Sub

    Public Sub call_procedure(ByVal noTrans As String, ByVal noInvoice As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_AUTOMAN_JURNAL"

        sqlCmd.Parameters.Add("@tipe_trans", SqlDbType.Char).Value = noTrans
        sqlCmd.Parameters.Add("@no_inv", SqlDbType.Char).Value = noInvoice
        sqlCmd.ExecuteNonQuery()

    End Sub

    'Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
    '    If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    'End Sub

    'Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
    '    If MsgBox("Form akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
    '    Me.Close()
    'End Sub

    Private Sub GV_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        If e.Column Is kurs_valuta Then
            If GV.GetRowCellValue(e.RowHandle, "kurs_valuta").ToString = "0,00" Or GV.GetRowCellValue(e.RowHandle, "kurs_valuta").ToString = "0.00" Or GV.GetRowCellValue(e.RowHandle, "kurs_valuta").ToString = vbNullString Then
                GV.SetRowCellValue(e.RowHandle, "kurs_valuta", "1")
            End If
        End If

        If e.Column Is kd_valuta Then
            If GV.GetRowCellValue(e.RowHandle, "kd_valuta").ToString = "IDR" Then
                GV.SetRowCellValue(e.RowHandle, "kurs_valuta", "1")
                GV.Columns.Item("kurs_valuta").OptionsColumn.AllowEdit = False
            Else
                GV.Columns.Item("kurs_valuta").OptionsColumn.AllowEdit = True
            End If
        End If
    End Sub

    Private Sub GV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV.DoubleClick
        loadHapus(GV.GetFocusedRowCellValue("nomor"))
    End Sub

    'Private Sub GV_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles GV.FocusedRowChanged
    '    If Not ds_cari.Tables("LOV_PEM") Is Nothing Then ds_cari.Tables("LOV_PEM").Clear()

    '    DALOOKUP = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_PEMBELIAN where kd_supplier = '" & GV.GetFocusedRowCellValue("kartu").ToString & "' and kd_valuta = '" & GV.GetFocusedRowCellValue("kd_valuta").ToString & "'", sqlconn))
    '    DALOOKUP.Fill(ds_cari, "LOV_PEM")
    '    LOVnoINV.DataSource = ds_cari.Tables("LOV_PEM")
    '    LOVnoINV.ValueMember = "no_inv"
    '    LOVnoINV.DisplayMember = "no_inv"
    'End Sub

    Private Sub GvMstCOA_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        Dim View As ColumnView = sender
        View.SetRowCellValue(e.RowHandle, View.Columns("tgl_trans"), getTanggal())
        View.SetRowCellValue(e.RowHandle, View.Columns("tgl_jth_tempo"), getTanggal())
        View.SetRowCellValue(e.RowHandle, View.Columns("tipe_trans"), "JRR-KUT-01")
        View.SetRowCellValue(e.RowHandle, View.Columns("kd_bank"), "01")
        View.SetRowCellValue(e.RowHandle, View.Columns("kartu"), "S00000")
        View.SetRowCellValue(e.RowHandle, View.Columns("jns_trans"), "BELI")
        View.SetRowCellValue(e.RowHandle, View.Columns("divisi"), 1)
        View.SetRowCellValue(e.RowHandle, View.Columns("kd_valuta"), "IDR")
        View.SetRowCellValue(e.RowHandle, View.Columns("kurs_valuta"), 1)
    End Sub

    Private Sub GV_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        'e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    'Private Sub cmdAdvance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdvance.Click
    '    If GV.Columns("status").Visible = True Then
    '        GV.Columns("status").Visible = False
    '        GV.Columns("jns_trans").Visible = False
    '        GV.Columns("jns_giro").Visible = False
    '        cmdAdvance.Text = "Advance"
    '    ElseIf GV.Columns("status").Visible = False Then
    '        GV.Columns("status").Visible = True
    '        GV.Columns("jns_trans").Visible = True
    '        GV.Columns("jns_giro").Visible = True
    '        cmdAdvance.Text = "Simple"
    '    End If
    'End Sub

    'Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
    '    'CLEAR
    '    dSO.Clear()
    '    GC.DataSource = dSO.Tables("_SIF_COA")
    '    'RELOAD
    '    DA = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_GIRO WHERE jns_trans = 'BELI'", sqlconn))
    '    DA.Fill(dSO, "_SIF_COA")
    '    GC.DataSource = dSO.Tables("_SIF_COA")
    'End Sub

    'Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
    '    'CLEAR
    '    dSO.Clear()
    '    GC.DataSource = dSO.Tables("_SIF_COA")
    'End Sub

    Private Sub GvMstCOA_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles GV.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub GV_MasterRowGetLevelDefaultView(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs) Handles GV.MasterRowGetLevelDefaultView
        rhandel = e.RowHandle
    End Sub

    Private Sub GV_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        Dim view As ColumnView = CType(sender, ColumnView)
        Dim column1 As GridColumn = view.Columns("nomor")
        Dim column2 As GridColumn = view.Columns("tgl_jth_tempo")
        Dim column3 As GridColumn = view.Columns("tgl_trans")
        Dim column4 As GridColumn = view.Columns("kd_buku_besar")
        Dim column5 As GridColumn = view.Columns("kd_bank")
        Dim column6 As GridColumn = view.Columns("kartu")
        Dim column7 As GridColumn = view.Columns("tipe_trans")

        e.Valid = True

        If view.GetRowCellValue(e.RowHandle, column1).ToString = vbNullString Then
            e.Valid = False
            view.SetColumnError(column1, "Nomor giro harus diisi.")
        End If

        If Not (view.GetRowCellValue(e.RowHandle, column3).ToString = vbNullString Or view.GetRowCellValue(e.RowHandle, column2).ToString = vbNullString) Then
            If view.GetRowCellValue(e.RowHandle, column3) > view.GetRowCellValue(e.RowHandle, column2) Then
                e.Valid = False
                view.SetColumnError(column3, "Tanggal transaksi melebihi tanggal jatuh tempo.")
            End If
        Else
            If view.GetRowCellValue(e.RowHandle, column3).ToString = vbNullString Then
                e.Valid = False
                view.SetColumnError(column3, "Tanggal transaksi tidak boleh kosong.")
            End If
            If view.GetRowCellValue(e.RowHandle, column2).ToString = vbNullString Then
                e.Valid = False
                view.SetColumnError(column2, "Tanggal jatuh tempo tidak boleh kosong.")
            End If
        End If


        If view.GetRowCellValue(e.RowHandle, column7).ToString = "JRR-KUT-08" Then
            If view.GetRowCellValue(e.RowHandle, column4).ToString = vbNullString Then
                e.Valid = False
                view.SetColumnError(column4, "Rekening harus dipilih untuk transaksi hutang lain-lain")
            End If
        End If

        If view.IsNewItemRow(e.RowHandle) Then
            Dim no As String = view.GetFocusedRowCellValue("nomor")
            Dim bank As Integer = view.GetFocusedRowCellValue("kd_bank")
            Dim kartu As String = view.GetFocusedRowCellValue("kartu")
            For i As Integer = 0 To GV.RowCount - 1
                If no = GV.GetRowCellValue(i, column1) And bank = GV.GetRowCellValue(i, column5).ToString And kartu = GV.GetRowCellValue(i, column6).ToString Then
                    e.Valid = False
                    view.SetColumnError(column1, "Kombinasi nomor giro, bank dan kartu sudah ada.")
                    view.SetColumnError(column5, "Kombinasi nomor giro, bank dan kartu sudah ada.")
                    view.SetColumnError(column6, "Kombinasi nomor giro, bank dan kartu sudah ada.")
                    Exit For
                Else
                    view.SetColumnError(column1, "")
                    view.SetColumnError(column5, "")
                    view.SetColumnError(column6, "")
                End If
            Next
        End If

        If e.Valid = True Then
            view.SetRowCellValue(e.RowHandle, "idrec", view.GetRowCellValue(e.RowHandle, "nomor").ToString & "BELI1" & CStr(view.GetRowCellValue(e.RowHandle, "kd_bank").ToString) & view.GetRowCellValue(e.RowHandle, "kartu").ToString)
        End If
    End Sub

    Private Sub GvMstCOA_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV.ValidatingEditor

        Try
            Dim vx As GridView = sender
            If vx.GetFocusedRowCellValue("status") = "KELUAR" Then
                If vx.FocusedColumn.FieldName = "nomor" Then
                    For i As Integer = 0 To GV.RowCount - 1
                        If e.Value = GV.GetRowCellValue(i, "nomor") Then
                            e.Valid = False
                            e.ErrorText = "No. giro kembar"
                            e.Value = vbNullString
                        End If
                    Next
                End If
                If vx.FocusedColumn.FieldName = "tgl_jth_tempo" Then
                    If e.Value < (vx.GetFocusedRowCellValue("tgl_trans")) Then
                        e.Valid = False
                        e.ErrorText = "Tanggal Jatuh Tempo Kurang Dari Tanggal Transaksi"
                    End If
                End If
            Else
                e.ErrorText = "Giro " & vx.GetFocusedRowCellValue("nomor").ToString & " sudah ditutup. Tidak boleh ada perubahan."
                e.Valid = False
            End If
            
        Catch ex As Exception

        End Try

    End Sub

    'Private Sub GcMstCOA_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GC.KeyDown
    '    If e.KeyCode = Keys.Delete Then
    '        If GV.GetSelectedRows.Count > 0 Then
    '            If MsgBox("Hapus data : " & GV.GetFocusedRowCellDisplayText("nomor") & " , Kartu : " & GV.GetFocusedRowCellDisplayText("kartu"), MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "HAPUS?") = MsgBoxResult.Yes Then
    '                GV.DeleteSelectedRows()
    '                simpan()
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Sub LOVnoINV_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles LOVnoINV.QueryPopUp
        GenNoInv()
    End Sub

    Private Sub GV2_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles GV2.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub GV2_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV2.ValidatingEditor
        Dim vx As GridView = GV
        If Not vx.GetRowCellValue(rhandel, "status") = "DITERIMA" Then
            e.ErrorText = "Giro " & vx.GetRowCellValue(rhandel, "nomor").ToString & " sudah ditutup. Tidak boleh ada perubahan."
            e.Valid = False
        End If
    End Sub

    Private Sub lookUpRekening_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lookUpRekening.QueryPopUp
        loadRek()
    End Sub
End Class