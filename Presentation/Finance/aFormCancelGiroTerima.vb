Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Public Class aFormCancelGiroTerima
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain
    Public STATE As String
    Dim myBuilder As New SqlCommandBuilder
    Dim dsGiro, dsLook, dsEdit As New DataSet
    Dim daGiro, daClearGiro, daNama, daBank, daVGiro, daEdit, daLoad As SqlDataAdapter
    Dim BTRANS As SqlTransaction
    Dim isValid As Boolean
    Dim err As String
    Dim giro As String
    Dim row As DataRow
    Dim rowG As DataRow
    Dim jml As Integer = 0
    Dim isOK As Boolean
    Dim statu As String
    Dim noGiro As String

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
        deTanggal.EditValue = Now
        luNoGiro.EditValue = vbNullString
        luNama.EditValue = vbNullString
        deTglJthTmp.EditValue = vbNullString
        luBank.EditValue = vbNullString
        txtJumlah.EditValue = 0
        txtKeterangan.Text = ""
    End Sub

    Private Sub loadGrid()
        If Not dsGiro.Tables("ClearGiro") Is Nothing Then dsGiro.Tables("ClearGiro").Clear()
        If Not dsGiro.Tables("SaveClearGiro") Is Nothing Then dsGiro.Tables("SaveClearGiro").Clear()
        daVGiro = New SqlDataAdapter(New SqlCommand("SELECT a.tgl_trans, a.no_giro, b.kartu, b.tgl_jth_tempo, b.kd_bank, a.no_inv, a.jml_trans, a.keterangan FROM FIN.dbo.FIN_TRANS_GIRO a, FIN.dbo.FIN_GIRO b WHERE a.no_giro=b.nomor AND a.status LIKE 'TOLAK'", sqlconn))
        daVGiro.Fill(dsGiro, "ClearGiro")
        gcGiro.DataSource = dsGiro.Tables("ClearGiro")
        daClearGiro = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_TRANS_GIRO WHERE tipe_trans='JRR-KPT-12' AND status LIKE 'TOLAK'", sqlconn))
        daClearGiro.Fill(dsGiro, "SaveClearGiro")
        deTanggal.EditValue = getTanggal()
    End Sub

    Private Sub loadLookUp()
        If Not dsLook.Tables("LookGiro") Is Nothing Then dsLook.Tables("LookGiro").Clear()
        If Not dsLook.Tables("LookNama") Is Nothing Then dsLook.Tables("LookNama").Clear()
        If Not dsLook.Tables("LookBank") Is Nothing Then dsLook.Tables("LookBank").Clear()
        daVGiro = New SqlDataAdapter(New SqlCommand("SELECT a.nomor, a.kartu, a.tgl_jth_tempo, a.kd_bank, a.jml_trans, b.nama, c.nama_bank FROM FIN.dbo.FIN_GIRO a, FIN.dbo.v_kartu b, SIF.dbo.SIF_Bank c WHERE a.kartu=b.kode AND a.kd_bank=c.kd_bank AND a.status LIKE 'CLEARING'", sqlconn))
        daVGiro.Fill(dsLook, "LookGiro")
        luNoGiro.Properties.DataSource = dsLook.Tables("LookGiro")
        luNoGiro.Properties.DisplayMember = "nomor"
        luNoGiro.Properties.ValueMember = "nomor"
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

    Private Sub aFormCancelGiroTerima_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        loadLookUp()
        prn.btnAdd_Click(sender, New EventArgs)
    End Sub

    Private Sub luNoGiro_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles luNoGiro.EditValueChanged
        If Not luNoGiro.EditValue = vbNullString Then
            If Not dsLook.Tables("LoadDetil") Is Nothing Then dsLook.Tables("LoadDetil").Clear()
            daLoad = New SqlDataAdapter(New SqlCommand("SELECT a.kartu, a.kd_bank, a.jml_trans, a.tgl_jth_tempo, a.nomor FROM FIN.dbo.FIN_GIRO a WHERE a.nomor='" & luNoGiro.EditValue & "'", sqlconn))
            daLoad.Fill(dsLook, "LoadDetil")
            luNoGiro.EditValue = dsLook.Tables("LoadDetil").Rows(0).Item("nomor")
            luNama.EditValue = dsLook.Tables("LoadDetil").Rows(0).Item("kartu")
            deTglJthTmp.EditValue = dsLook.Tables("LoadDetil").Rows(0).Item("tgl_jth_tempo")
            luBank.EditValue = dsLook.Tables("LoadDetil").Rows(0).Item("kd_bank")
            If Not STATE = "EDIT" Then
                txtJumlah.EditValue = dsLook.Tables("LoadDetil").Rows(0).Item("jml_trans")
            End If
            loadLookUp()
        End If
    End Sub

    Private Sub txtJumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJumlah.KeyPress
        Select Case Asc(e.KeyChar)
            'Case 65 To 90 'dari a-z
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 32, 8, 46, 40, 41, 43
                e.Handled = False
            Case Else
                e.Handled = True
                'MsgBox("Diisi dengan angka.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "WARNING!")
        End Select
    End Sub

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
                    row.Item("Kd_cabang") = getKodeCabang() ' <-- hanya contoh, nanti diisi dengan yg bener
                    row.Item("tipe_trans") = "JRR-KPT-14"
                    row.Item("no_giro") = luNoGiro.EditValue
                    row.Item("tgl_trans") = deTanggal.EditValue
                    row.Item("jml_trans") = txtJumlah.EditValue
                    row.Item("keterangan") = txtKeterangan.Text
                    row.Item("status") = "TOLAK"
                    row.Item("Last_create_date") = Now
                    row.Item("Last_created_by") = umum.username
                    row.Item("Program_name") = Me.Name
                    dsGiro.Tables("SaveClearGiro").Rows.Add(row)

                    If Not dsGiro.Tables("Giro") Is Nothing Then dsGiro.Tables("Giro").Clear()
                    daGiro = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_GIRO WHERE nomor = '" & luNoGiro.EditValue & "'", sqlconn))
                    daGiro.Fill(dsGiro, "Giro")
                    rowG = dsGiro.Tables("Giro").Rows(0)
                    rowG.Item("status") = "TOLAK"
                    rowG.Item("Last_Update_Date") = Now
                    rowG.Item("Last_Updated_By") = umum.username
                ElseIf STATE = "EDIT" Then
                    noGiro = luNoGiro.EditValue
                    row.Item("tgl_trans") = deTanggal.EditValue
                    row.Item("jml_trans") = txtJumlah.EditValue
                    row.Item("keterangan") = txtKeterangan.Text
                    row.Item("Last_Update_Date") = Now
                    row.Item("Last_Updated_By") = umum.username
                End If

                If STATE = "EDIT" Then
                    Try
                        myBuilder = New SqlCommandBuilder(daEdit)
                        daEdit.UpdateCommand = myBuilder.GetUpdateCommand()
                        daEdit.InsertCommand = myBuilder.GetInsertCommand()
                        daEdit.DeleteCommand = myBuilder.GetDeleteCommand()

                        BTRANS = sqlconn.BeginTransaction("1")
                        daEdit.UpdateCommand.Transaction = BTRANS
                        daEdit.InsertCommand.Transaction = BTRANS
                        daEdit.DeleteCommand.Transaction = BTRANS

                        daEdit.Update(dsLook.Tables("GiroEdit"))
                        'call_procedure("JRR-KPT-14", noGiro, BTRANS)
                        BTRANS.Commit()

                        showMessages("Berhasil disimpan..")
                        STATE = "EDIT"
                        isValid = False
                        luNoGiro.Properties.ReadOnly = False
                        clear()
                        loadGrid()
                    Catch ex As Exception
                        BTRANS.Rollback()
                        dsGiro.Tables("GiroEdit").RejectChanges()
                        MsgBox(ex.Message)
                    End Try
                ElseIf STATE = "ADD" Then
                    Try
                        myBuilder = New SqlCommandBuilder(daClearGiro)
                        daClearGiro.UpdateCommand = myBuilder.GetUpdateCommand()
                        daClearGiro.InsertCommand = myBuilder.GetInsertCommand()
                        daClearGiro.DeleteCommand = myBuilder.GetDeleteCommand()

                        myBuilder = New SqlCommandBuilder(daGiro)
                        daGiro.UpdateCommand = myBuilder.GetUpdateCommand()
                        daGiro.InsertCommand = myBuilder.GetInsertCommand()
                        daGiro.DeleteCommand = myBuilder.GetDeleteCommand()

                        BTRANS = sqlconn.BeginTransaction("1")
                        daClearGiro.UpdateCommand.Transaction = BTRANS
                        daClearGiro.InsertCommand.Transaction = BTRANS
                        daClearGiro.DeleteCommand.Transaction = BTRANS

                        daGiro.UpdateCommand.Transaction = BTRANS
                        daGiro.InsertCommand.Transaction = BTRANS
                        daGiro.DeleteCommand.Transaction = BTRANS

                        daClearGiro.Update(dsGiro.Tables("SaveClearGiro"))
                        daGiro.Update(dsGiro.Tables("Giro"))

                        dsGiro.Tables("SaveClearGiro").AcceptChanges()
                        dsGiro.Tables("Giro").AcceptChanges()
                        'call_procedure("JRR-KPT-11", noGiro, BTRANS)
                        BTRANS.Commit()

                        showMessages("Berhasil disimpan..")
                        'STATE = "EDIT"
                        isValid = False
                        luNoGiro.Properties.ReadOnly = False
                        txtJumlah.Properties.ReadOnly = False
                        clear()
                        loadLookUp()
                        loadGrid()
                    Catch ex As Exception
                        BTRANS.Rollback()
                        dsGiro.Tables("SaveClearGiro").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                        dsGiro.Tables("Giro").RejectChanges()
                        MsgBox(ex.Message)
                    End Try
                End If
            Else
                MsgBox("Kesalahan dalam pengisian data berikut :" & vbCrLf & err, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR!")
                err = ""
            End If
        Else
            Try
                myBuilder = New SqlCommandBuilder(daEdit)
                daEdit.UpdateCommand = myBuilder.GetUpdateCommand()
                daEdit.InsertCommand = myBuilder.GetInsertCommand()
                daEdit.DeleteCommand = myBuilder.GetDeleteCommand()

                myBuilder = New SqlCommandBuilder(daGiro)
                daGiro.UpdateCommand = myBuilder.GetUpdateCommand()
                daGiro.InsertCommand = myBuilder.GetInsertCommand()
                daGiro.DeleteCommand = myBuilder.GetDeleteCommand()

                BTRANS = sqlconn.BeginTransaction("1")
                daEdit.UpdateCommand.Transaction = BTRANS
                daEdit.InsertCommand.Transaction = BTRANS
                daEdit.DeleteCommand.Transaction = BTRANS

                daGiro.UpdateCommand.Transaction = BTRANS
                daGiro.InsertCommand.Transaction = BTRANS
                daGiro.DeleteCommand.Transaction = BTRANS

                daEdit.Update(dsLook.Tables("GiroEdit"))
                daGiro.Update(dsGiro.Tables("Giro"))

                'dsGiro.Tables("SaveClearGiro").AcceptChanges()
                'dsGiro.Tables("Giro").AcceptChanges()

                BTRANS.Commit()

                'STATE = "EDIT"
                isValid = False
                luNoGiro.Properties.ReadOnly = False
                txtJumlah.Properties.ReadOnly = False
                clear()
                loadLookUp()
                loadGrid()
            Catch ex As Exception
                BTRANS.Rollback()
                dsLook.Tables("GiroEdit").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                dsGiro.Tables("Giro").RejectChanges()
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtJumlah_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJumlah.TextChanged
        If txtJumlah.EditValue = 0 Or txtJumlah.EditValue = 0 Then
            If luNoGiro.EditValue = vbNullString Then
                txtJumlah.EditValue = 0
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
        If Not dsLook.Tables("GiroEdit") Is Nothing Then dsLook.Tables("GiroEdit").Clear()
        If Not dsGiro.Tables("SaveClearGiro") Is Nothing Then dsGiro.Tables("SaveClearGiro").Clear()
        If Not dsGiro.Tables("Giro") Is Nothing Then dsGiro.Tables("Giro").Clear()
        If Not dsLook.Tables("LoadDetil") Is Nothing Then dsLook.Tables("LoadDetil").Clear()
        luNoGiro.Properties.ReadOnly = False
        loadLookUp()
        loadGrid()
    End Sub

    Private Sub gvGiro_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvGiro.DoubleClick
        Dim viewGiro As ColumnView = gvGiro
        STATE = "EDIT"
        loadLookUp()
        If Not dsLook.Tables("GiroEdit") Is Nothing Then dsLook.Tables("GiroEdit").Clear()
        giro = viewGiro.GetFocusedRowCellValue("no_giro").ToString
        daEdit = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_TRANS_GIRO WHERE no_giro='" & giro & "'", sqlconn))
        daEdit.Fill(dsLook, "GiroEdit")
        deTanggal.EditValue = dsLook.Tables("GiroEdit").Rows(0).Item("tgl_trans")
        luNoGiro.EditValue = dsLook.Tables("GiroEdit").Rows(0).Item("no_giro")
        luNoGiro.Properties.ReadOnly = True
        txtJumlah.EditValue = dsLook.Tables("GiroEdit").Rows(0).Item("jml_trans")
        txtJumlah.Properties.ReadOnly = True
        txtKeterangan.Text = dsLook.Tables("GiroEdit").Rows(0).Item("keterangan")
    End Sub

    Public Sub call_procedure(ByVal tipeT As String, ByVal noG As String, ByVal trans As SqlTransaction)

        Dim sqlCmd As New SqlCommand
        sqlCmd.Transaction = trans
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_CATALOG_MAKEJUR"

        sqlCmd.Parameters.Add("@tipe_trans", SqlDbType.Char).Value = tipeT
        sqlCmd.Parameters.Add("@no_inv", SqlDbType.Char).Value = noG
        Dim dr As SqlDataReader = sqlCmd.ExecuteReader
        dr.Close()
    End Sub

    Public Sub call_procedure_del(ByVal noG As String, ByVal tipe As String)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_DELJUR_GIRO"

        sqlCmd.Parameters.Add("@nogiro", SqlDbType.Char).Value = noG
        sqlCmd.Parameters.Add("@tipe", SqlDbType.Char).Value = tipe
        Dim dr As SqlDataReader = sqlCmd.ExecuteReader
        dr.Close()
    End Sub

    Public Sub delete_click()
        Dim viewGiro As ColumnView = gvGiro
        giro = viewGiro.GetFocusedRowCellValue("no_giro").ToString
        If MsgBox("Hapus Jurnal dengan nomor " & giro & " ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "DELETE?") = MsgBoxResult.Yes Then
            If Not dsLook.Tables("GiroEdit") Is Nothing Then dsLook.Tables("GiroEdit").Clear()
            daEdit = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_TRANS_GIRO WHERE no_giro='" & giro & "'", sqlconn))
            daEdit.Fill(dsLook, "GiroEdit")
            For Each rw As DataRow In dsLook.Tables("GiroEdit").Rows
                call_procedure_del(rw.Item("no_giro"), "CLEARING")
                rw.Delete()
            Next
            If Not dsGiro.Tables("Giro") Is Nothing Then dsGiro.Tables("Giro").Clear()
            daGiro = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_GIRO WHERE nomor = '" & giro & "'", sqlconn))
            daGiro.Fill(dsGiro, "Giro")
            rowG = dsGiro.Tables("Giro").Rows(0)
            rowG.Item("status") = "CLEARING"
            rowG.Item("Last_Update_Date") = Now
            rowG.Item("Last_Updated_By") = umum.username
            save_click(True)
            STATE = "ADD"
        End If
    End Sub

    Private Sub luBank_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles luBank.EditValueChanged
        Dim dr As SqlDataReader = New SqlCommand("SELECT no_rekening FROM SIF.dbo.SIF_Bank WHERE kd_bank = '" & luBank.EditValue & "'", sqlconn).ExecuteReader
        dr.Read()
        If dr.HasRows Then
            txtNoRek.EditValue = dr.Item(0)
        Else
            txtNoRek.EditValue = vbNullString
        End If
    End Sub
End Class