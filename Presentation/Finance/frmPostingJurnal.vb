Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class frmPostingJurnal
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public prn As frmMain
    Public STATE, role As String
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
        'If Not dsLookUp.Tables("LookBarang") Is Nothing Then dsLookUp.Tables("LookBarang").Clear()

        daLookTrans = New SqlDataAdapter(New SqlCommand("SELECT tipe_trans, tipe_desc FROM KOPKAR.dbo.SIF_TIPE_TRANS", sqlconn))
        daLookTrans.Fill(dsLookUp, "TipeTrans")
        lueTrans.DataSource = dsLookUp.Tables("TipeTrans")
        lueTrans.DisplayMember = "tipe_desc"
        lueTrans.ValueMember = "tipe_trans"
        daLookBB1 = New SqlDataAdapter(New SqlCommand("SELECT kd_buku_besar, nm_buku_besar FROM KOPKAR.dbo.m_buku_besar WHERE grup_header = 'D' AND Rec_Stat = 'Y'", sqlconn))
        daLookBB1.Fill(dsLookUp, "LookBukuBesar")
        lueLookBB.DataSource = dsLookUp.Tables("LookBukuBesar")
        lueLookBB.DisplayMember = "nm_buku_besar"
        lueLookBB.ValueMember = "kd_buku_besar"
        'daLookBarang = New SqlDataAdapter(New SqlCommand("SELECT Kode_Barang, Nama_Barang FROM SIF.dbo.SIF_Barang", sqlconn))
        'daLookBarang.Fill(dsLookUp, "LookBarang")
        'lueBarang.DataSource = dsLookUp.Tables("LookBarang")
        'lueBarang.DisplayMember = "Nama_Barang"
        'lueBarang.ValueMember = "Kode_Barang"

        'daPost = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_JURNAL WHERE no_posting IS NULL OR no_posting = ''", sqlconn))
    End Sub

    Private Sub loadJurnal()
        dsPost = New DataSet

        Dim drPost As SqlDataReader = New SqlCommand("select IDROLE from KOPKAR.dbo.MUSER_ROLE where IDUSER = '" & username & "'", sqlconn).ExecuteReader

        drPost.Read()
        If drPost.HasRows Then
            role = drPost.Item(0)
        End If

        drPost.Close()

        If Not role = "Kasir" Then
            daPost = New SqlDataAdapter(New SqlCommand("SELECT * FROM KOPKAR.dbo.FIN_JURNAL WHERE (no_posting IS NULL OR no_posting='') AND (verifikasi='Y' OR verifikasi IS NULL) AND tgl_trans BETWEEN CONVERT(DATE, '" & tglAwal.EditValue & "', 103) AND CONVERT(DATE, '" & tglAkhir.EditValue & "', 103)", sqlconn))
            daDetil = New SqlDataAdapter(New SqlCommand("SELECT D.*,bb.nm_buku_besar FROM KOPKAR.dbo.FIN_JURNAL_D D left join KOPKAR.dbo.m_buku_besar bb on bb.kd_buku_besar = D.kd_buku_besar  WHERE no_jur IN (SELECT no_jur FROM KOPKAR.dbo.FIN_JURNAL WHERE (no_posting IS NULL OR no_posting='') AND (verifikasi='Y' OR verifikasi IS NULL) AND tgl_trans BETWEEN CONVERT(DATE, '" & tglAwal.EditValue & "', 103) AND CONVERT(DATE, '" & tglAkhir.EditValue & "', 103)) order by CAST(no_seq AS INT)", sqlconn))
        Else
            daPost = New SqlDataAdapter(New SqlCommand("SELECT * FROM KOPKAR.dbo.FIN_JURNAL WHERE (no_posting IS NULL OR no_posting='') AND (verifikasi='Y' OR verifikasi IS NULL) AND tgl_trans BETWEEN CONVERT(DATE, '" & tglAwal.EditValue & "', 103) AND CONVERT(DATE, '" & tglAkhir.EditValue & "', 103) AND tipe_trans IN ('JKK-KBB-03', 'JKK-KBB-10')", sqlconn))
            daDetil = New SqlDataAdapter(New SqlCommand("SELECT D.*,bb.nm_buku_besar FROM KOPKAR.dbo.FIN_JURNAL_D D left join KOPKAR.dbo.m_buku_besar bb on bb.kd_buku_besar = D.kd_buku_besar  WHERE no_jur IN (SELECT no_jur FROM KOPKAR.dbo.FIN_JURNAL WHERE (no_posting IS NULL OR no_posting='') AND (verifikasi='Y' OR verifikasi IS NULL) AND tgl_trans BETWEEN CONVERT(DATE, '" & tglAwal.EditValue & "', 103) AND CONVERT(DATE, '" & tglAkhir.EditValue & "', 103) AND tipe_trans IN ('JKK-KBB-03', 'JKK-KBB-10')) order by CAST(no_seq AS INT)", sqlconn))
        End If
        daPost.Fill(dsPost, "Jurnal")
        daDetil.Fill(dsPost, "JurnalD")
        rl = dsPost.Relations.Add("DetailJurnal", dsPost.Tables("Jurnal").Columns("no_jur"), dsPost.Tables("JurnalD").Columns("no_jur"))
        gcPost.DataSource = dsPost.Tables("Jurnal")
        gcPost.LevelTree.Nodes.Add("DetailJurnal", gvDetil)
        'gvPost.BestFitColumns()
        'gvDetil.BestFitColumns()
        If Not gvPost.RowCount <= 0 Then
            For i As Integer = 0 To gvPost.RowCount - 1
                gvPost.SetRowCellValue(i, "cek_post", "T")
            Next
        End If
    End Sub

    Private Sub frmPostingJurnal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        loadData()
        loadJurnal()
        dtpPosting.MaxValue = Today
        checkMonthClosed()
        btnCetak = False
        setStatus()
        tglAwal.EditValue = getTanggal()
        tglAkhir.EditValue = getTanggal()
        Timer1.Enabled = True
    End Sub
    Private Sub checkMonthClosed()
        'Dim dr As SqlDataReader
        'Dim result As Date

        'dr = New SqlCommand("select TOP 1 DATEADD(MONTH,1,CAST(thn_buku + '-' + bln_buku + '-' + CAST(1 AS varchar) AS DATETIME)) MINDATE " & _
        '"from KOPKAR.dbo.SIF_Periode_Buku " & _
        '"where CAST(bln_buku as int)>0 AND  " & _
        '"CONVERT(DATE,DATEADD(MONTH,-1,GETDATE())) >= CAST(thn_buku + '-' + bln_buku + '-' + CAST(1 AS varchar) AS DATETIME) " & _
        '"AND UPPER(status_close)='Y' " & _
        '"ORDER BY thn_buku desc, bln_buku desc", sqlconn, BTRANS).ExecuteReader
        'dr.Read()
        'result = dr(0)
        'dr.Close()
        'dr = Nothing


        'If Not String.IsNullOrEmpty(result) Then

        '    dtpPosting.MinValue = result
        'End If
    End Sub
    Public Sub call_procedure(ByVal no_jur As String, ByVal tgl_post As String, ByVal no_post As String, ByVal user As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "KOPKAR.dbo.FIN_POSTING"

        sqlCmd.Parameters.Add("@vnojur", SqlDbType.Char).Value = no_jur
        sqlCmd.Parameters.Add("@vtgl", SqlDbType.Date).Value = tgl_post
        sqlCmd.Parameters.Add("@vno_posting", SqlDbType.Char).Value = no_post
        sqlCmd.Parameters.Add("@vuser", SqlDbType.Char).Value = user
        Dim dr As SqlDataReader = sqlCmd.ExecuteReader
        dr.Close()
    End Sub

    Public Sub save_click()

        For Each rw As DataRow In dsPost.Tables("Jurnal").Select("cek_post='Y'")
            If gvDetil.Columns("saldo_val_debet").SummaryText = gvDetil.Columns("saldo_val_kredit").SummaryText Then
                isOK = True
                Exit For
            Else
                isOK = False
            End If
        Next

        If isOK Then
            If MsgBox("Transaksi akan diposting ke jurnal. Anda yakin?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                myBuilderM = New SqlCommandBuilder(daPost)
                daPost.InsertCommand = myBuilderM.GetInsertCommand()
                daPost.UpdateCommand = myBuilderM.GetUpdateCommand()
                daPost.DeleteCommand = myBuilderM.GetDeleteCommand()

                'myBuilderD = New SqlCommandBuilder(daDetil)
                'daDetil.InsertCommand = myBuilderD.GetInsertCommand()
                'daDetil.UpdateCommand = myBuilderD.GetUpdateCommand()
                'daDetil.DeleteCommand = myBuilderD.GetDeleteCommand()


                daPost.UpdateCommand.Transaction = BTRANS
                daPost.InsertCommand.Transaction = BTRANS
                daPost.DeleteCommand.Transaction = BTRANS

                'daDetil.UpdateCommand.Transaction = BTRANS
                'daDetil.InsertCommand.Transaction = BTRANS
                'daDetil.DeleteCommand.Transaction = BTRANS

                daPost.Update(dsPost, ("Jurnal"))
                'daDetil.Update(dsPost, ("JurnalD"))
                dsPost.Tables("Jurnal").AcceptChanges()
                'dsPost.Tables("JurnalD").AcceptChanges()


                For Each rw As DataRow In dsPost.Tables("Jurnal").Rows
                    If rw.Item("cek_post").Equals(ceCek.ValueChecked) Then
                        'rw.Item("Last_update_date") = Now
                        'rw.Item("Last_updated_by") = username

                        'For Each rwx As DataRow In dsPost.Tables("JurnalD").Rows
                        '    If rwx.RowState = DataRowState.Modified Then
                        '        rwx.Item("Last_update_date") = Now
                        '        rwx.Item("Last_updated_by") = username
                        '    End If
                        'Next
                        Try

                            BTRANS = sqlconn.BeginTransaction("1")
                            call_procedure(rw.Item("no_jur"), rw.Item("tgl_posting"), vbNull, username, BTRANS)
                            With New SqlCommand("UPDATE KOPKAR.dbo.FIN_JURNAL SET tgl_posting = CONVERT(DATE, '" & rw.Item("tgl_posting") & "', 103) WHERE no_jur = '" & rw.Item("no_jur") & "'", sqlconn, BTRANS).ExecuteNonQuery

                            End With

                            'Nitip insert yaaa
                            'MsgBox(rw.Item("no_ref1"))
                            Dim sqlcmd1 As New SqlCommand("update kredit set STATUS_AKTIF=1 where no_trans='" & rw.Item("no_ref1") & "'", sqlconn, BTRANS)
                            'sqlcmd1.Parameters.AddWithValue("@nilai", row1.Item("sisa_angs"))
                            sqlcmd1.ExecuteNonQuery()

                            For Each rwx As DataRow In dsPost.Tables("JurnalD").Select("no_jur='" & rw.Item("no_jur") & "'")
                                If rwx.RowState = DataRowState.Modified Then
                                    With New SqlCommand("UPDATE KOPKAR.dbo.FIN_JURNAL_D SET kd_buku_besar = '" & rwx.Item("kd_buku_besar") & "' WHERE no_jur = '" & rw.Item("no_jur") & "' AND no_seq = '" & rwx.Item("no_seq") & "'", sqlconn, BTRANS).ExecuteNonQuery

                                    End With


                                End If
                            Next
                            BTRANS.Commit()

                        Catch e As Exception
                            If Not BTRANS Is Nothing Then BTRANS.Rollback()
                        End Try
                    End If
                Next

                showMessages("Berhasil disimpan..")

                Timer1.Enabled = True

                loadJurnal()
            End If
        Else
            MsgBox("Tidak ada data yang dipilih atau detil jurnal yang dipilih tidak sama antara nominal debet dan kreditnya.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
        End If
    End Sub

    Private Sub gvPost_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvPost.CellValueChanged
        If e.Column Is cek_post Then
            Dim tgl As String = gvPost.GetRowCellValue(e.RowHandle, "tgl_posting").ToString
            If e.Value = "Y" Then
                If tgl = vbNullString Or tgl = "" Then
                    gvPost.SetRowCellValue(e.RowHandle, "tgl_posting", gvPost.GetRowCellValue(e.RowHandle, "tgl_trans"))
                End If
            Else
                If tgl = vbNullString Or tgl = "" Then
                    gvPost.SetRowCellValue(e.RowHandle, "tgl_posting", vbNullString)
                End If
            End If
        End If
    End Sub

    Private Sub gvPost_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles gvPost.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub gvPost_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gvPost.RowUpdated

        Timer1.Enabled = False
    End Sub

    Private Sub gvPost_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles gvPost.ValidatingEditor
        Dim vx As GridView = sender
        'If vx.FocusedColumn.FieldName = "tgl_posting" Then
        '    Dim tglApp As Date = Convert.ToDateTime(e.Value)
        '    If tglApp < vx.GetFocusedRowCellValue("tgl_trans") Then
        '        e.Valid = False
        '        e.ErrorText = "Tanggal posting lebih kecil daripada tanggal transaksi."
        '    End If
        'End If
    End Sub

    Private Sub btnCentang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCentang.Click
        For i As Integer = 0 To gvPost.RowCount - 1
            Dim tgl As String = gvPost.GetRowCellValue(i, "tgl_posting").ToString
            gvPost.SetRowCellValue(i, "cek_post", "Y")
            If tgl = vbNullString Or tgl = "" Then
                gvPost.SetRowCellValue(i, "tgl_posting", gvPost.GetRowCellValue(i, "tgl_trans"))
            End If
        Next
    End Sub

    Private Sub btnCentang2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCentang2.Click
        For i As Integer = 0 To gvPost.RowCount - 1
            Dim tgl As String = gvPost.GetRowCellValue(i, "tgl_posting").ToString
            gvPost.SetRowCellValue(i, "cek_post", "T")
            If tgl = vbNullString Or tgl = "" Then
                gvPost.SetRowCellValue(i, "tgl_posting", vbNullString)
            End If
        Next
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        jumlah = dsPost.Tables("Jurnal").Rows.Count
        If tglAwal.EditValue > tglAkhir.EditValue Then
            MsgBox("Tanggal awal jurnal lebih besar dari tanggal akhirnya.", MsgBoxStyle.Exclamation = MsgBoxStyle.OkOnly, "PERINGATAN!")
            Exit Sub
        End If
        If tglAkhir.EditValue < tglAwal.EditValue Then
            MsgBox("Tanggal akhir jurnal lebih kecil dari tanggal awalnya.", MsgBoxStyle.Exclamation = MsgBoxStyle.OkOnly, "PERINGATAN!")
            Exit Sub
        End If
        loadJurnal()
        If Not jumlah = dsPost.Tables("Jurnal").Rows.Count Then
            MsgBox("Ada data baru untuk diposting. Tolong di cek.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
        End If
        Timer1.Enabled = True
        checkMonthClosed()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If delay = 0 Then
            btnRefresh_Click(btnRefresh, New EventArgs)
            delay = 60
        Else
            delay -= 1
            cmdRefresh.Text = delay
        End If
    End Sub

    Private Sub tglAwal_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tglAwal.EditValueChanged
        If Not tglAwal.EditValue = vbNullString Then
            tglAkhir.EditValue = DateAdd(DateInterval.Month, 1, tglAwal.EditValue)
            tglAkhir.EditValue = DateAdd(DateInterval.Day, -1, tglAkhir.EditValue)
        End If
    End Sub
End Class