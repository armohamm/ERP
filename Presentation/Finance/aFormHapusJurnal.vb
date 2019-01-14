Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class aFormHapusJurnal
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public prn As frmMain
    Public STATE, role, err As String
    Dim dsPost, dsLookUp As New DataSet
    Dim daPost, daDetil, daLookTrans, daLookBB, daPostEdit, daDetilEdit, daLookBB1, daLookBarang As SqlDataAdapter
    Dim BTRANS As SqlTransaction
    Dim myBuilderM, myBuilderD As New SqlCommandBuilder
    Dim rl, r2 As DataRelation
    Dim isOK As Boolean = True
    Dim delay As Int16 = 60
    Dim jumlah As Integer

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

    Private Sub loadData()
        If Not dsLookUp.Tables("TipeTrans") Is Nothing Then dsLookUp.Tables("TipeTrans").Clear()
        If Not dsLookUp.Tables("LookBukuBesar") Is Nothing Then dsLookUp.Tables("LookBukuBesar").Clear()
        If Not dsLookUp.Tables("LookBarang") Is Nothing Then dsLookUp.Tables("LookBarang").Clear()

        daLookTrans = New SqlDataAdapter(New SqlCommand("SELECT tipe_trans, tipe_desc FROM KOPKAR.dbo.SIF_TIPE_TRANS WHERE attribut2 = 'Y'", sqlconn))
        daLookTrans.Fill(dsLookUp, "TipeTrans")
        lueTrans.DataSource = dsLookUp.Tables("TipeTrans")
        lueTrans.DisplayMember = "tipe_desc"
        lueTrans.ValueMember = "tipe_trans"
        daLookBB1 = New SqlDataAdapter(New SqlCommand("SELECT kd_buku_besar, nm_buku_besar FROM KOPKAR.dbo.m_buku_besar WHERE grup_header = 'D' AND Rec_Stat = 'Y'", sqlconn))
        daLookBB1.Fill(dsLookUp, "LookBukuBesar")
        lueLookBB.DataSource = dsLookUp.Tables("LookBukuBesar")
        lueLookBB.DisplayMember = "nm_buku_besar"
        lueLookBB.ValueMember = "kd_buku_besar"
        daLookBarang = New SqlDataAdapter(New SqlCommand("SELECT Id_Data kd_buku_pusat, Desc_Data nm_buku_pusat FROM KOPKAR.dbo.SIF_Gen_Reff_D WHERE Id_Ref_Data = 'UNITKOPKAR' AND Rec_Stat = 'Y'", sqlconn))
        daLookBarang.Fill(dsLookUp, "BukuPusat")
        lueBarang.DataSource = dsLookUp.Tables("BukuPusat")
        lueBarang.DisplayMember = "nm_buku_pusat"
        lueBarang.ValueMember = "kd_buku_pusat"
        'daPost = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_JURNAL WHERE no_posting IS NULL OR no_posting = ''", sqlconn))
    End Sub

    Private Sub loadJurnal()
        dsPost = New DataSet

        daPost = New SqlDataAdapter(New SqlCommand("SELECT *, 'T' cek_hapus FROM KOPKAR.dbo.FIN_JURNAL_BATAL WHERE (alasan_salah IS NULL OR alasan_salah = '')", sqlconn))
        daDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM KOPKAR.dbo.FIN_JURNAL_D_BATAL WHERE no_jur IN (SELECT no_jur FROM KOPKAR.dbo.FIN_JURNAL_BATAL WHERE (alasan_salah IS NULL OR alasan_salah = '')) order by CAST(no_seq AS INT)", sqlconn))

        daPost.Fill(dsPost, "Jurnal")
        daDetil.Fill(dsPost, "JurnalD")
        rl = dsPost.Relations.Add("DetailJurnal", dsPost.Tables("Jurnal").Columns("no_jur"), dsPost.Tables("JurnalD").Columns("no_jur"))
        gcPost.DataSource = dsPost.Tables("Jurnal")
        gcPost.LevelTree.Nodes.Add("DetailJurnal", gvDetil)
        gvPost.BestFitColumns()
        gvDetil.BestFitColumns()
        'If Not gvPost.RowCount <= 0 Then
        '    For i As Integer = 0 To gvPost.RowCount - 1
        '        gvPost.SetRowCellValue(i, "cek_post", "T")
        '    Next
        'End If
    End Sub

    Private Sub frmPostingJurnal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        loadData()
        'loadJurnal()
        btnCetak = False
        setStatus()
        tglAwal.EditValue = getTanggal()
        tglAkhir.EditValue = getTanggal()
    End Sub

    Public Sub call_procedure(ByVal no_jur As String, ByVal tipe_trans As String, ByVal stat As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "KOPKAR.dbo.FIN_CATALOG_DELJUR"

        sqlCmd.Parameters.Add("@tipe_trans", SqlDbType.Char).Value = tipe_trans
        sqlCmd.Parameters.Add("@no_inv", SqlDbType.Char).Value = no_jur
        sqlCmd.Parameters.Add("@post", SqlDbType.Char).Value = stat
        sqlCmd.ExecuteNonQuery()
    End Sub

    Private Sub loadDataGrid()
        Dim daGrid As SqlDataAdapter
        If Not dsLookUp.Tables("NotaGrid") Is Nothing Then dsLookUp.Tables("NotaGrid").Clear()
        If Not dsLookUp.Tables("NotaDGrid") Is Nothing Then dsLookUp.Tables("NotaDGrid").Clear()

        daGrid = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT * FROM KOPKAR.dbo.FIN_JURNAL WHERE tgl_trans BETWEEN CONVERT(DATE, '" & tglAwal.EditValue & "', 103) AND CONVERT(DATE, '" & tglAkhir.EditValue & "', 103)", sqlconn))
        daGrid.Fill(dsLookUp, "NotaGrid")
        daGrid = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT * FROM KOPKAR.dbo.FIN_JURNAL_D WHERE no_jur IN (SELECT no_jur FROM KOPKAR.dbo.FIN_JURNAL WHERE tgl_trans BETWEEN CONVERT(DATE, '" & tglAwal.EditValue & "', 103) AND CONVERT(DATE, '" & tglAkhir.EditValue & "', 103)) order by CAST(no_seq AS INT)", sqlconn))
        daGrid.Fill(dsLookUp, "NotaDGrid")
        Dim i As Integer = 1

        For Each rowcok As DataRow In dsLookUp.Tables("NotaGrid").Rows
            Dim rowGrid As DataRow = dsPost.Tables("Jurnal").NewRow
            'Yang Harus diisi di tabel jurnal
            For x As Integer = 0 To dsLookUp.Tables("NotaGrid").Columns.Count - 1
                rowGrid.Item(x) = rowcok.Item(x)
            Next
            'rowGrid.Item("Kd_cabang") = rowcok.Item("Kd_cabang")
            'rowGrid.Item("no_jur") = rowcok.Item("no_jur")
            'rowGrid.Item("tipe_trans") = rowcok.Item("tipe_trans")
            'rowGrid.Item("tgl_trans") = rowcok.Item("tgl_trans")
            'rowGrid.Item("kd_valuta") = rowcok.Item("kd_valuta")
            'rowGrid.Item("kurs_valuta") = rowcok.Item("kurs_valuta")

            ''Yang ditampilkan di grid
            'rowGrid.Item("no_ref1") = rowcok.Item("no_ref1")
            'rowGrid.Item("jml_val_trans") = rowcok.Item("jml_val_trans")
            'rowGrid.Item("jml_rp_trans") = rowcok.Item("jml_rp_trans")

            ''Pelengkap
            'rowGrid.Item("no_ref2") = rowcok.Item("no_ref2")
            'rowGrid.Item("no_ref3") = rowcok.Item("no_ref3")
            'rowGrid.Item("thnbln") = rowcok.Item("thnbln")
            'rowGrid.Item("kd_kartu") = rowcok.Item("kd_kartu")
            'rowGrid.Item("kurs_valuta") = rowcok.Item("kurs_valuta")
            'rowGrid.Item("Last_create_date") = rowcok.Item("Last_create_date")
            'rowGrid.Item("Last_created_by") = rowcok.Item("Last_created_by")
            'rowGrid.Item("Last_update_date") = rowcok.Item("Last_update_date")
            'rowGrid.Item("Last_updated_by") = rowcok.Item("Last_updated_by")
            dsPost.Tables("Jurnal").Rows.Add(rowGrid)
        Next

        For Each rowcok As DataRow In dsLookUp.Tables("NotaDGrid").Rows
            Dim rowGrid As DataRow = dsPost.Tables("JurnalD").NewRow
            For x As Integer = 0 To dsLookUp.Tables("NotaDGrid").Columns.Count - 1
                rowGrid.Item(x) = rowcok.Item(x)
            Next
            dsPost.Tables("JurnalD").Rows.Add(rowGrid)
        Next
    End Sub

    Public Sub save_click()
        Dim i As Integer = 0

        For Each rw As DataRow In dsPost.Tables("Jurnal").Select("cek_hapus='Y'")
            i += 1
        Next

        If i > 0 Then
            isOK = True
        Else
            isOK = False
        End If

        If isOK Then
            err = ""
            If MsgBox("Jurnal akan dihapus. Anda yakin?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                For Each item As DataRow In dsPost.Tables("Jurnal").Select("isnull(cek_hapus,'T')<>'Y'")
                    For Each itemD As DataRow In dsPost.Tables("JurnalD").Select("no_jur='" & item.Item("no_jur") & "'")
                        If Not itemD.RowState = DataRowState.Deleted Then itemD.Delete()
                    Next
                    If Not item.RowState = DataRowState.Deleted Then item.Delete()
                Next

                For Each rw As DataRow In dsPost.Tables("Jurnal").Rows
                    Try
                        myBuilderM = New SqlCommandBuilder(daPost)
                        daPost.UpdateCommand = myBuilderM.GetUpdateCommand()
                        daPost.InsertCommand = myBuilderM.GetInsertCommand()
                        daPost.DeleteCommand = myBuilderM.GetDeleteCommand()

                        myBuilderD = New SqlCommandBuilder(daDetil)
                        daDetil.UpdateCommand = myBuilderD.GetUpdateCommand()
                        daDetil.InsertCommand = myBuilderD.GetInsertCommand()
                        daDetil.DeleteCommand = myBuilderD.GetDeleteCommand()

                        BTRANS = sqlconn.BeginTransaction("1")

                        daPost.UpdateCommand.Transaction = BTRANS
                        daPost.InsertCommand.Transaction = BTRANS
                        daPost.DeleteCommand.Transaction = BTRANS

                        daDetil.UpdateCommand.Transaction = BTRANS
                        daDetil.InsertCommand.Transaction = BTRANS
                        daDetil.DeleteCommand.Transaction = BTRANS

                        daPost.Update(dsPost.Tables("Jurnal"))
                        daDetil.Update(dsPost.Tables("JurnalD"))

                        call_procedure(rw.Item("no_jur"), rw.Item("tipe_trans"), IIf(rw.Item("no_posting") = vbNullString Or rw.Item("no_posting") = "", "NP", "P"), BTRANS)
                        If rw.Item("no_posting") = vbNullString Or rw.Item("no_posting") = "" Then

                            Dim sqlJurnal As New SqlCommand("DELETE KOPKAR.dbo.FIN_JURNAL WHERE no_jur = '" & rw.Item("no_jur") & "'", sqlconn, BTRANS)
                            sqlJurnal.ExecuteNonQuery()
                            Dim sqlJurnalD As New SqlCommand("DELETE KOPKAR.dbo.FIN_JURNAL_D WHERE no_jur = '" & rw.Item("no_jur") & "'", sqlconn, BTRANS)
                            sqlJurnalD.ExecuteNonQuery()
                        End If
                        BTRANS.Commit()

                    Catch e As Exception
                        err &= rw.Item("no_jur") & vbCrLf
                        If Not BTRANS Is Nothing Then BTRANS.Rollback()
                    End Try
                Next

                'showMessages("Berhasil disimpan.")
                If err.Length > 0 Then
                    MsgBox("Jurnal-jurnal berikut tidak dapat di-update :" & vbCrLf & err, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "INFO")
                End If

                loadJurnal()
                loadDataGrid()
            End If
        Else
            MsgBox("Tidak ada data yang dipilih atau detil jurnal yang dipilih tidak sama antara nominal debet dan kreditnya.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
        End If
    End Sub

    Private Sub btnCentang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCentang.Click
        For i As Integer = 0 To gvPost.RowCount - 1
            gvPost.SetRowCellValue(i, "cek_hapus", "Y")
        Next
    End Sub

    Private Sub btnCentang2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCentang2.Click
        For i As Integer = 0 To gvPost.RowCount - 1
            gvPost.SetRowCellValue(i, "cek_hapus", "T")
        Next
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        If CDate(tglAwal.EditValue) > CDate(tglAkhir.EditValue) Then
            MsgBox("Tanggal awal jurnal lebih besar dari tanggal akhirnya.", MsgBoxStyle.Exclamation = MsgBoxStyle.OkOnly, "PERINGATAN!")
            Exit Sub
        End If
        If CDate(tglAkhir.EditValue) < CDate(tglAwal.EditValue) Then
            MsgBox("Tanggal akhir jurnal lebih kecil dari tanggal awalnya.", MsgBoxStyle.Exclamation = MsgBoxStyle.OkOnly, "PERINGATAN!")
            Exit Sub
        End If
        loadJurnal()
        loadDataGrid()
        gvPost.BestFitColumns()
        gvDetil.BestFitColumns()
    End Sub

    Private Sub tglAwal_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tglAwal.EditValueChanged
        If Not tglAwal.EditValue = vbNullString Then
            tglAkhir.EditValue = DateAdd(DateInterval.Month, 1, tglAwal.EditValue)
            tglAkhir.EditValue = DateAdd(DateInterval.Day, -1, tglAkhir.EditValue)
        End If
    End Sub

    Private Sub gvPost_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvPost.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub gvPost_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvPost.ValidateRow
        Try
            Dim view As ColumnView = CType(sender, ColumnView)
            Dim column1 As GridColumn = view.Columns("alasan_salah")

            If view.GetRowCellValue(e.RowHandle, column1) = vbNullString Then
                e.Valid = False
                view.SetColumnError(column1, "Keterangan salah harus diisi.")
            Else
                e.Valid = True
                view.SetColumnError(column1, "")
            End If

        Catch ex As Exception

        End Try
    End Sub
End Class