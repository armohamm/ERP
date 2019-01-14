Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Public Class aFormCancelGiroTerima1
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public btnCetak As Boolean = False
    Public prn As frmMain
    Public STATE As String
    Dim myBuilderM, myBuilderD As New SqlCommandBuilder
    Dim dsGiro, dsLook, dsEdit As New DataSet
    Dim daGiro, daClearGiro, daNama, daBank, daVGiro, daEdit, daLoad As SqlDataAdapter
    Dim drGiro As SqlDataReader
    Dim BTRANS As SqlTransaction
    Dim isValid As Boolean
    Dim err As String
    Dim giro As String
    Dim row As DataRow
    Dim rowG As DataRow
    Dim jml As Integer = 0
    Dim isOK As Boolean
    Dim statu As String
    Dim update As Integer
    Dim noGiro, kdVal As String

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

    Public Sub add_click()
        STATE = "ADD"
        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        btnDelete = True
        setStatus()
        loadGrid()
    End Sub

    Private Sub clear()
        deTanggal.EditValue = getTanggal()
        luNoGiro.EditValue = vbNullString
        luNama.EditValue = vbNullString
        deTglJthTmp.EditValue = vbNullString
        luBank.EditValue = vbNullString
        txtJumlah.EditValue = vbNullString
        txtNoRek.EditValue = vbNullString
        txtKeterangan.Text = ""
    End Sub

    Private Sub loadGrid()
        If Not dsGiro.Tables("ClearGiro") Is Nothing Then dsGiro.Tables("ClearGiro").Clear()
        daVGiro = New SqlDataAdapter(New SqlCommand("SELECT a.tgl_trans, a.no_giro, b.kartu, b.tgl_jth_tempo, b.kd_bank, a.no_inv, a.jml_trans, a.keterangan FROM FIN.dbo.FIN_TRANS_GIRO a, FIN.dbo.FIN_GIRO b WHERE a.idrec = b.idrec AND a.tipe_trans LIKE 'JRR-KPT-14' AND a.status = 'TOLAK' ORDER BY tgl_trans DESC", sqlconn))
        daVGiro.Fill(dsGiro, "ClearGiro")
        gcGiro.DataSource = dsGiro.Tables("ClearGiro")
        gvGiro.BestFitColumns()
    End Sub

    Private Sub loadData(ByVal kodeG As String)
        If Not dsGiro.Tables("SaveClearGiro") Is Nothing Then dsGiro.Tables("SaveClearGiro").Clear()
        daClearGiro = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_TRANS_GIRO WHERE idrec = '" & kodeG & "'", sqlconn))
        daClearGiro.Fill(dsGiro, "SaveClearGiro")
    End Sub

    Private Sub loadGiro()
        If Not dsLook.Tables("LookGiro") Is Nothing Then dsLook.Tables("LookGiro").Clear()

        'daVGiro = New SqlDataAdapter(New SqlCommand("SELECT a.idrec, a.nomor, a.kartu, a.tgl_jth_tempo, a.kd_bank, a.jml_trans, b.nama, c.nama_bank FROM FIN.dbo.FIN_GIRO a, FIN.dbo.v_kartu b, SIF.dbo.SIF_Bank c WHERE a.kartu=b.kode AND a.kd_bank=c.kd_bank AND a.status LIKE 'DITERIMA' " & _
        '                                            " union all " & _
        '                                            " SELECT a.idrec, a.nomor, a.kartu, a.tgl_jth_tempo, a.kd_bank, a.jml_trans, b.nama, c.nama_bank " & _
        '                                            " FROM FIN.dbo.FIN_GIRO a, FIN.dbo.v_kartu b, " & _
        '                                            " SIF.dbo.SIF_Bank c, fin.dbo.fin_jurnal d, FIN.dbo.FIN_TRANS_GIRO e " & _
        '                                            " WHERE(a.kartu = b.kode)AND a.kd_bank=c.kd_bank and a.idrec = e.idrec and e.no_jur = d.no_jur " & _
        '                                            " AND e.status LIKE 'CLEARING' and NOT (d.no_posting is null or d.no_posting = '')", sqlconn))
        daVGiro = New SqlDataAdapter(New SqlCommand("SELECT a.idrec, a.nomor, a.kartu, a.tgl_jth_tempo, a.kd_bank, a.jml_trans, b.nama, " & _
                                                    "c.nama_bank " & _
                                                    "FROM FIN.dbo.FIN_GIRO a, FIN.dbo.v_kartu b, SIF.dbo.SIF_Bank c, FIN.dbo.FIN_JURNAL d " & _
                                                    "WHERE(a.kartu = b.kode) " & _
                                                    "AND a.kd_bank=c.kd_bank " & _
                                                    "AND a.no_jur = d.no_jur " & _
                                                    "AND NOT (d.no_posting IS NULL OR d.no_posting = '') " & _
                                                    "AND a.status LIKE 'DITERIMA' " & _
                                                    "AND NOT a.nomor IN ( " & _
                                                        "SELECT nomor " & _
                                                        "FROM FIN.dbo.FIN_TRANS_GIRO " & _
                                                        "WHERE status = 'TOLAK' " & _
                                                    ")", sqlconn))
        daVGiro.Fill(dsLook, "LookGiro")
        luNoGiro.Properties.DataSource = dsLook.Tables("LookGiro")
        luNoGiro.Properties.DisplayMember = "nomor"
        luNoGiro.Properties.ValueMember = "idrec"
    End Sub

    Private Sub loadLookUp()
        If Not dsLook.Tables("LookNama") Is Nothing Then dsLook.Tables("LookNama").Clear()
        If Not dsLook.Tables("LookBank") Is Nothing Then dsLook.Tables("LookBank").Clear()

        daNama = New SqlDataAdapter(New SqlCommand("SELECT kode, nama FROM FIN.dbo.v_kartu", sqlconn))
        daNama.Fill(dsLook, "LookNama")
        luNama.Properties.DataSource = dsLook.Tables("LookNama")
        luNama.Properties.DisplayMember = "nama"
        luNama.Properties.ValueMember = "kode"
        lookNama.DataSource = dsLook.Tables("LookNama")
        lookNama.DisplayMember = "nama"
        lookNama.ValueMember = "kode"

        daBank = New SqlDataAdapter(New SqlCommand("SELECT kd_bank, nama_bank FROM SIF.dbo.SIF_Bank", sqlconn))
        daBank.Fill(dsLook, "LookBank")
        luBank.Properties.DataSource = dsLook.Tables("LookBank")
        luBank.Properties.DisplayMember = "nama_bank"
        luBank.Properties.ValueMember = "kd_bank"
        lookBank.DataSource = dsLook.Tables("LookBank")
        lookBank.DisplayMember = "nama_bank"
        lookBank.ValueMember = "kd_bank"
    End Sub

    Private Sub aFormCancelGiroTerima1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        loadLookUp()
        prn.btnAdd_Click(sender, New EventArgs)
        deTanggal.EditValue = getTanggal()
        loadGrid()
        loadData("XXX")
    End Sub

    Private Sub luNoGiro_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles luNoGiro.EditValueChanged
        If Not luNoGiro.EditValue = vbNullString Then
            If Not dsLook.Tables("LoadDetil") Is Nothing Then dsLook.Tables("LoadDetil").Clear()
            daLoad = New SqlDataAdapter(New SqlCommand("SELECT a.idrec, a.kartu, a.kd_bank, a.jml_trans, a.tgl_jth_tempo, a.nomor, a.kd_valuta FROM FIN.dbo.FIN_GIRO a WHERE a.idrec ='" & luNoGiro.EditValue & "'", sqlconn))
            daLoad.Fill(dsLook, "LoadDetil")
            luNoGiro.EditValue = dsLook.Tables("LoadDetil").Rows(0).Item("idrec")
            luNama.EditValue = dsLook.Tables("LoadDetil").Rows(0).Item("kartu")
            deTglJthTmp.EditValue = dsLook.Tables("LoadDetil").Rows(0).Item("tgl_jth_tempo")
            luBank.EditValue = dsLook.Tables("LoadDetil").Rows(0).Item("kd_bank")
            kdVal = dsLook.Tables("LoadDetil").Rows(0).Item("kd_valuta")
            If Not STATE = "EDIT" Then
                txtJumlah.EditValue = dsLook.Tables("LoadDetil").Rows(0).Item("jml_trans")
            End If
            'loadLookUp()
        End If
    End Sub

    Private Function isPosting(ByVal jur As String)
        Dim OK As String
        drGiro = New SqlCommand("SELECT no_posting FROM FIN.dbo.FIN_JURNAL WHERE no_jur = '" & jur & "'", sqlconn).ExecuteReader
        drGiro.Read()
        OK = drGiro.Item(0)
        If Not OK = "" Or OK = vbNullString Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub cek()
        If luNoGiro.EditValue = vbNullString Then
            isValid = False
            err &= "No. Giro harus dipilih." & vbCrLf
            If txtJumlah.Text = "" Then
                err &= "Jumlah harus diisi." & vbCrLf
            End If
        ElseIf txtJumlah.Text = "" Then
            isValid = False
            err &= "Jumlah harus diisi." & vbCrLf
            If luNoGiro.EditValue = vbNullString Then
                err &= "No. Giro harus dipilih." & vbCrLf
            End If
        Else
            isValid = True
        End If
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        If Not isDelete Then
            cek()
            If isValid Then
                If STATE = "ADD" Then
                    noGiro = luNoGiro.EditValue
                    row = dsGiro.Tables("SaveClearGiro").NewRow
                    row.Item("Kd_cabang") = getKodeCabang()
                    row.Item("tipe_trans") = "JRR-KPT-14"
                    row.Item("status") = "TOLAK"
                    row.Item("Last_create_date") = Now
                    row.Item("Last_created_by") = umum.username
                    row.Item("Program_name") = Me.Name
                ElseIf STATE = "EDIT" Then
                    noGiro = luNoGiro.EditValue
                    row = dsGiro.Tables("SaveClearGiro").Rows(0)
                    row.Item("Last_Update_Date") = Now
                    row.Item("Last_Updated_By") = umum.username
                End If

                row.Item("idrec") = luNoGiro.EditValue
                row.Item("no_giro") = Microsoft.VisualBasic.Left(luNoGiro.EditValue, 6)
                row.Item("kd_valuta") = kdVal
                row.Item("kd_bank") = luBank.EditValue
                row.Item("tgl_trans") = deTanggal.EditValue
                row.Item("jml_trans") = txtJumlah.EditValue
                row.Item("keterangan") = txtKeterangan.Text

                If STATE = "ADD" Then
                    dsGiro.Tables("SaveClearGiro").Rows.Add(row)
                End If
            Else
                MsgBox("Kesalahan dalam pengisian data berikut :" & vbCrLf & err, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR!")
                err = ""
            End If
        End If

        Try
            myBuilderM = New SqlCommandBuilder(daClearGiro)
            daClearGiro.UpdateCommand = myBuilderM.GetUpdateCommand()
            daClearGiro.InsertCommand = myBuilderM.GetInsertCommand()
            daClearGiro.DeleteCommand = myBuilderM.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            daClearGiro.UpdateCommand.Transaction = BTRANS
            daClearGiro.InsertCommand.Transaction = BTRANS
            daClearGiro.DeleteCommand.Transaction = BTRANS

            daClearGiro.Update(dsGiro.Tables("SaveClearGiro"))

            dsGiro.Tables("SaveClearGiro").AcceptChanges()

            call_procedure("JRR-KPT-14", noGiro, BTRANS)

            update = New SqlCommand("UPDATE FIN.dbo.FIN_GIRO SET status = 'TOLAK', Last_Update_Date = GETDATE(), Last_Updated_By = '" & umum.username & "' WHERE idrec = '" & luNoGiro.EditValue & "'", sqlconn, BTRANS).ExecuteNonQuery

            BTRANS.Commit()

            'If Not dsGiro.Tables("Giro") Is Nothing Then dsGiro.Tables("Giro").Clear()
            'daGiro = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_GIRO WHERE idrec = '" & luNoGiro.EditValue & "'", sqlconn))
            'daGiro.Fill(dsGiro, "Giro")
            'rowG = dsGiro.Tables("Giro").Rows(0)
            'rowG.Item("status") = "TOLAK"
            'rowG.Item("Last_Update_Date") = Now
            'rowG.Item("Last_Updated_By") = umum.username

            showMessages("Berhasil disimpan...")
            'STATE = "EDIT"
            isValid = False
            luNoGiro.Properties.ReadOnly = False
            txtJumlah.Properties.ReadOnly = False
            clear()
            loadLookUp()
            loadGrid()
            loadData("XXX")
        Catch ex As Exception
            BTRANS.Rollback()
            dsGiro.Tables("SaveClearGiro").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtJumlah_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJumlah.EditValueChanged
        If txtJumlah.EditValue = 0 Or txtJumlah.EditValue = 0 Then
            If luNoGiro.EditValue = vbNullString Then
                txtJumlah.EditValue = vbNullString
            Else
                If Not STATE = "EDIT" Then
                    txtJumlah.EditValue = dsLook.Tables("LoadDetil").Rows(0).Item("jml_trans")
                End If
            End If
        End If
    End Sub

    Public Sub cancel_click()
        'btnadd = True
        'btnCancel = False
        'btnDelete = False
        'btnEdit = True
        'btnSave = False
        'setStatus()
        'Me.Enabled = False
        clear()
        STATE = "ADD"
        If Not dsGiro.Tables("SaveClearGiro") Is Nothing Then dsGiro.Tables("SaveClearGiro").Clear()
        If Not dsGiro.Tables("Giro") Is Nothing Then dsGiro.Tables("Giro").Clear()
        If Not dsLook.Tables("LoadDetil") Is Nothing Then dsLook.Tables("LoadDetil").Clear()
        luNoGiro.Properties.ReadOnly = False
        loadLookUp()
        loadGrid()
        loadData("XXX")
    End Sub

    Private Sub gvGiro_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvGiro.DoubleClick
        Dim viewGiro As ColumnView = gvGiro
        giro = viewGiro.GetFocusedRowCellValue("idrec").ToString
        If Not isPosting(viewGiro.GetFocusedRowCellValue("no_jur").ToString) Then
            STATE = "EDIT"
            'loadLookUp()
            'If Not dsLook.Tables("GiroEdit") Is Nothing Then dsLook.Tables("GiroEdit").Clear()
            'daEdit = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_TRANS_GIRO WHERE idrec='" & giro & "'", sqlconn))
            'daEdit.Fill(dsLook, "GiroEdit")
            loadData(giro)
            deTanggal.EditValue = dsGiro.Tables("SaveClearGiro").Rows(0).Item("tgl_trans")
            luNoGiro.EditValue = dsGiro.Tables("SaveClearGiro").Rows(0).Item("no_giro")
            luNoGiro.Properties.ReadOnly = True
            txtJumlah.EditValue = dsGiro.Tables("SaveClearGiro").Rows(0).Item("jml_trans")
            txtJumlah.Properties.ReadOnly = True
            txtKeterangan.Text = dsGiro.Tables("SaveClearGiro").Rows(0).Item("keterangan")
        Else
            MsgBox("Pembatalan giro " & viewGiro.GetFocusedRowCellValue("no_giro").ToString & " sudah diposting. Data tidak dapat diubah.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            Exit Sub
        End If
    End Sub

    Public Sub call_procedure(ByVal tipeT As String, ByVal noG As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Transaction = trans
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_AUTOMAN_JURNAL"

        sqlCmd.Parameters.Add("@tipe_trans", SqlDbType.Char).Value = tipeT
        sqlCmd.Parameters.Add("@no_inv", SqlDbType.Char).Value = noG
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub call_procedure_del(ByVal noG As String, ByVal tipe As String)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_DELJUR_GIRO"

        sqlCmd.Parameters.Add("@nogiro", SqlDbType.Char).Value = noG
        sqlCmd.Parameters.Add("@tipe", SqlDbType.Char).Value = tipe
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub delete_click()
        Dim viewGiro As ColumnView = gvGiro
        giro = viewGiro.GetFocusedRowCellValue("idrec").ToString
        If Not isPosting(viewGiro.GetFocusedRowCellValue("no_jur").ToString) Then
            If MsgBox("Hapus Jurnal dengan nomor " & viewGiro.GetFocusedRowCellValue("no_giro").ToString & " ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "DELETE?") = MsgBoxResult.Yes Then
                For Each rw As DataRow In dsGiro.Tables("SaveClearGiro").Rows
                    call_procedure_del(rw.Item("no_giro"), "TERIMA")
                    rw.Delete()
                Next
                save_click(True)
                STATE = "ADD"
            End If
        Else
            MsgBox("Pembatalan giro " & giro & " sudah diposting. Data tidak dapat dihapus.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            Exit Sub
        End If
    End Sub

    Private Sub luBank_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luBank.EditValueChanged
        If Not luBank.EditValue = vbNullString Then
            Dim dr As SqlDataReader = New SqlCommand("SELECT no_rekening FROM SIF.dbo.SIF_Bank WHERE kd_bank = '" & luBank.EditValue & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                txtNoRek.EditValue = dr.Item(0)
            Else
                txtNoRek.EditValue = vbNullString
            End If
            dr.Close()
        End If
    End Sub

    Private Sub luNoGiro_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles luNoGiro.QueryPopUp
        loadGiro()
    End Sub
End Class