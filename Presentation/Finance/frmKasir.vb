Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class frmKasir
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public prn As frmMain
    Public STATE As String
    Dim dsPost As New DataSet
    Dim daPost, daDetil, daLookTrans, daLookBB, daPostEdit, daDetilEdit, daLookBB1, daLookBP As SqlDataAdapter
    Dim drPost As SqlDataReader
    Dim BTRANS As SqlTransaction
    Dim myBuilder As New SqlCommandBuilder
    Dim rl, r2 As DataRelation
    Dim isOK As Boolean = True

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
        dsPost = New DataSet
        daLookTrans = New SqlDataAdapter(New SqlCommand("SELECT tipe_trans, tipe_desc FROM SIF.dbo.SIF_TIPE_TRANS", sqlconn))
        daLookTrans.Fill(dsPost, "TipeTrans")
        lueTrans.DataSource = dsPost.Tables("TipeTrans")
        lueTrans.DisplayMember = "tipe_desc"
        lueTrans.ValueMember = "tipe_trans"
        daLookBB = New SqlDataAdapter(New SqlCommand("SELECT kd_buku_besar, nm_buku_besar FROM SIF.dbo.SIF_buku_besar WHERE grup_level1 LIKE '101%' AND grup_header = 'D'", sqlconn))
        daLookBB.Fill(dsPost, "BukuBesar")
        lueBB.DataSource = dsPost.Tables("BukuBesar")
        lueBB.DisplayMember = "nm_buku_besar"
        lueBB.ValueMember = "kd_buku_besar"
        daLookBB1 = New SqlDataAdapter(New SqlCommand("SELECT kd_buku_besar, nm_buku_besar FROM SIF.dbo.SIF_buku_besar where grup_header = 'D'", sqlconn))
        daLookBB1.Fill(dsPost, "LookBukuBesar")
        lueLookBB.DataSource = dsPost.Tables("LookBukuBesar")
        lueLookBB.DisplayMember = "nm_buku_besar"
        lueLookBB.ValueMember = "kd_buku_besar"
        daLookBP = New SqlDataAdapter(New SqlCommand("SELECT kd_buku_pusat, nm_buku_pusat FROM SIF.dbo.SIF_buku_pusat", sqlconn))
        daLookBP.Fill(dsPost, "LookBukuPusat")
        lueLookBP.DataSource = dsPost.Tables("LookBukuPusat")
        lueLookBP.DisplayMember = "nm_buku_pusat"
        lueLookBP.ValueMember = "kd_buku_pusat"
        daLookBP = New SqlDataAdapter(New SqlCommand("SELECT nama, kode FROM FIN.dbo.v_kartu", sqlconn))
        daLookBP.Fill(dsPost, "LookSupplier")
        lookSupplier.DataSource = dsPost.Tables("LookSupplier")
        lookSupplier.DisplayMember = "nama"
        lookSupplier.ValueMember = "kode"

        daPost = New SqlDataAdapter(New SqlCommand("SELECT a.* " & _
                                                    "FROM FIN.dbo.FIN_JURNAL a " & _
                                                    "WHERE (a.no_posting IS NULL OR a.no_posting = '' ) " & _
                                                    "AND (a.tipe_trans LIKE 'JKK-KPT%' OR a.tipe_trans LIKE 'JKM-KPT%' OR a.tipe_trans LIKE 'JKK-KUT%' OR a.tipe_trans LIKE 'JKM-KUT%') " & _
                                                    "AND (a.verifikasi IS NULL OR a.verifikasi = 'T' OR a.verifikasi = '') " & _
                                                    "AND (a.cek_post IS NULL OR a.cek_post = '') " & _
                                                    "ORDER BY a.tgl_trans", sqlconn))
        daPost.Fill(dsPost, "Jurnal")
        daDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_JURNAL_D WHERE no_jur IN (SELECT no_jur FROM FIN.dbo.FIN_JURNAL WHERE (no_posting IS NULL OR no_posting = '' ) AND (tipe_trans LIKE 'JKK-KPT%' OR tipe_trans LIKE 'JKM-KPT%' OR tipe_trans LIKE 'JKK-KUT%' OR tipe_trans LIKE 'JKM-KUT%') AND (verifikasi IS NULL OR verifikasi = 'T' OR verifikasi = '') AND (cek_post IS NULL OR cek_post = ''))", sqlconn))
        daDetil.Fill(dsPost, "JurnalD")
        rl = dsPost.Relations.Add("DetailJurnal", dsPost.Tables("Jurnal").Columns("no_jur"), dsPost.Tables("JurnalD").Columns("no_jur"))
        gcPost.DataSource = dsPost.Tables("Jurnal")
        gcPost.LevelTree.Nodes.Add("DetailJurnal", gvDetil)
        gvPost.BestFitColumns()
        gvDetil.BestFitColumns()
    End Sub

    Private Sub frmKasir_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        loadData()
    End Sub

    Public Sub save_click()
        Dim BTRANS As SqlTransaction

        For Each rw As DataRow In dsPost.Tables("Jurnal").Rows
            If rw.RowState = DataRowState.Modified Then
                If rw.Item("verifikasi").Equals(ceCek.ValueChecked) Then
                    isOK = True
                    Exit For
                Else
                    isOK = False
                End If
            Else
                isOK = False
            End If
        Next

        If isOK Then
            If MsgBox("Transaksi akan diverifikasi. Anda yakin?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                For Each rw As DataRow In dsPost.Tables("Jurnal").Rows
                    If rw.Item("verifikasi").Equals(ceCek.ValueChecked) Then
                        If rw.RowState = DataRowState.Modified Then
                            rw.Item("Last_update_date") = Now
                            rw.Item("Last_updated_by") = username
                        Else
                            rw.Item("verifikasi") = ceCek.ValueUnchecked
                        End If
                        For Each rwx As DataRow In dsPost.Tables("JurnalD").Select("no_jur='" & rw.Item("no_jur") & "'")
                            If rwx.RowState = DataRowState.Modified Then
                                rwx.Item("Last_update_date") = Now
                                rwx.Item("Last_updated_by") = username
                            End If
                        Next
                    End If

                    If rw.Item("verifikasi").Equals(ceCek.ValueChecked) Then
                        Try
                            myBuilder = New SqlCommandBuilder(daPost)
                            daPost.InsertCommand = myBuilder.GetInsertCommand()
                            daPost.UpdateCommand = myBuilder.GetUpdateCommand()
                            daPost.DeleteCommand = myBuilder.GetDeleteCommand()

                            myBuilder = New SqlCommandBuilder(daDetil)
                            daDetil.InsertCommand = myBuilder.GetInsertCommand()
                            daDetil.UpdateCommand = myBuilder.GetUpdateCommand()
                            daDetil.DeleteCommand = myBuilder.GetDeleteCommand()

                            BTRANS = sqlconn.BeginTransaction("1")
                            daPost.UpdateCommand.Transaction = BTRANS
                            daPost.InsertCommand.Transaction = BTRANS
                            daPost.DeleteCommand.Transaction = BTRANS

                            daDetil.UpdateCommand.Transaction = BTRANS
                            daDetil.InsertCommand.Transaction = BTRANS
                            daDetil.DeleteCommand.Transaction = BTRANS

                            daPost.Update(dsPost, ("Jurnal"))
                            daDetil.Update(dsPost, ("JurnalD"))
                            dsPost.Tables("Jurnal").AcceptChanges()
                            dsPost.Tables("JurnalD").AcceptChanges()

                            BTRANS.Commit()

                        Catch e As Exception
                            dsPost.Tables("Jurnal").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                            dsPost.Tables("JurnalD").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
                        End Try
                        'Else
                        '    Try
                        '        myBuilder = New SqlCommandBuilder(daDetil)
                        '        daDetil.InsertCommand = myBuilder.GetInsertCommand()
                        '        daDetil.UpdateCommand = myBuilder.GetUpdateCommand()
                        '        daDetil.DeleteCommand = myBuilder.GetDeleteCommand()

                        '        BTRANS = sqlconn.BeginTransaction("1")
                        '        daDetil.UpdateCommand.Transaction = BTRANS
                        '        daDetil.InsertCommand.Transaction = BTRANS
                        '        daDetil.DeleteCommand.Transaction = BTRANS

                        '        daDetil.Update(dsPost, ("JurnalD"))
                        '        dsPost.Tables("JurnalD").AcceptChanges()

                        '        BTRANS.Commit()

                        'Catch e As Exception
                        '    dsPost.Tables("JurnalD").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                        '    MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
                        'End Try
                    End If
                Next
                showMessages("Berhasil disimpan..")
                loadData()
            End If
        Else
            MsgBox("Tidak ada data yang dipilih.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
        End If
        btnSave = False
        setStatus()
    End Sub

    Private Sub gvPost_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvPost.CellValueChanged
        Dim View As ColumnView = sender
        Dim rw As DataRow
        If e.Column Is rek_attribute1 Then
            drPost = New SqlCommand("SELECT * FROM FIN.dbo.FIN_JURNAL_D WHERE no_jur = '" & gvPost.GetRow(e.RowHandle).item("no_jur") & "' AND kd_buku_besar LIKE '101%'", sqlconn).ExecuteReader
            While drPost.Read()
                rw = dsPost.Tables("JurnalD").Select("no_seq='" & drPost.Item("no_seq").ToString & "' AND no_jur='" & gvPost.GetRow(e.RowHandle).item("no_jur") & "'")(0)
                If Mid(rw("kd_buku_besar"), 1, 3) = "101" Then
                    rw.Item("kd_buku_besar") = gvPost.GetRow(e.RowHandle).item("rek_attribute1")
                End If
            End While
            drPost.Close()
        End If

        If e.Column Is verifikasi Then
            Dim tgl As String = gvPost.GetRowCellValue(e.RowHandle, "tgl_posting").ToString
            If e.Value = "Y" Then
                If tgl = vbNullString Or tgl = "" Then
                    gvPost.SetRowCellValue(e.RowHandle, "tgl_posting", getTanggal())
                    Exit Sub
                End If
            Else
                gvPost.SetRowCellValue(e.RowHandle, "tgl_posting", vbNullString)
            End If
        End If
    End Sub

    Private Sub gvPost_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvPost.CellValueChanging
        If e.Column Is verifikasi Then
            If e.Value.Equals(ceCek.ValueChecked) Then
                btnSave = True
                setStatus()
            End If
            gvPost.SetRowCellValue(e.RowHandle, "tgl_posting", getTanggal())
        End If
    End Sub

    Private Sub gvDetil_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvDetil.CellValueChanged
        If e.Column Is kd_buku_besar Or e.Column Is kd_buku_pusat Then
            btnSave = True
            setStatus()
            gvPost.SetRowCellValue(e.RowHandle, "tgl_posting", getTanggal())
        End If
    End Sub

    Private Sub btnCentang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCentang.Click
        For i As Integer = 0 To gvPost.RowCount - 1
            Dim tgl As String = gvPost.GetRowCellValue(i, "tgl_posting").ToString
            gvPost.SetRowCellValue(i, "verifikasi", "Y")
            If tgl = vbNullString Or tgl = "" Then
                gvPost.SetRowCellValue(i, "tgl_posting", getTanggal())
            End If
        Next
    End Sub

    Private Sub btnCentang2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCentang2.Click
        For i As Integer = 0 To gvPost.RowCount - 1
            Dim tgl As String = gvPost.GetRowCellValue(i, "tgl_posting").ToString
            gvPost.SetRowCellValue(i, "verifikasi", "T")
            'If tgl = vbNullString Or tgl = "" Then
            '    gvPost.SetRowCellValue(i, "tgl_posting", vbNullString)
            'End If
        Next
    End Sub
End Class