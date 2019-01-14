Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Public Class formCairGiroMsk
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public prn As frmMain
    Public STATE As String
    Dim myBuilder As New SqlCommandBuilder
    Dim dsGiro, dsLook, dsEdit As New DataSet
    Dim daGiro, daClearGiro, daNama, daBank, daNoInv, daVGiro, daEdit, daLoad, daValuta As SqlDataAdapter
    Dim BTRANS As SqlTransaction
    Dim isValid As Boolean
    Dim err As String
    Dim noGiro, tipeTrans As String
    Dim row As DataRow
    Dim rowG As DataRow

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
        deTanggal.EditValue = Now
        luNoGiro.EditValue = vbNullString
        luNama.EditValue = vbNullString
        deTglJthTmp.EditValue = vbNullString
        luBank.EditValue = vbNullString
        lueValuta.EditValue = vbNullString
        txtKurs.EditValue = 0
        luNoInv.EditValue = vbNullString
        txtJumlah.Text = 0
        txtKeterangan.Text = ""
        btnadd = True
        btnCancel = False
        btnDelete = False
        btnEdit = False
        btnSave = False
        setStatus()
        Me.Enabled = False
    End Sub

    Private Sub loadGrid()
        If Not dsGiro.Tables("ClearGiro") Is Nothing Then dsGiro.Tables("ClearGiro").Clear()
        If Not dsGiro.Tables("SaveClearGiro") Is Nothing Then dsGiro.Tables("SaveClearGiro").Clear()
        daVGiro = New SqlDataAdapter(New SqlCommand("SELECT a.tgl_trans, a.no_giro, b.kartu, b.tgl_jth_tempo, b.kd_bank, a.no_inv, a.jml_trans, a.keterangan FROM FIN.dbo.FIN_TRANS_GIRO a, FIN.dbo.FIN_GIRO b WHERE a.no_giro=b.nomor AND a.tipe_trans='JKM-KPT-04' AND a.status='CLOSED'", sqlconn))
        daVGiro.Fill(dsGiro, "ClearGiro")
        gcGiro.DataSource = dsGiro.Tables("ClearGiro")
        daClearGiro = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_TRANS_GIRO WHERE tipe_trans='JKM-KPT-04' AND status='CLOSED'", sqlconn))
        daClearGiro.Fill(dsGiro, "SaveClearGiro")
    End Sub

    Private Sub loadLookUp()
        If Not dsLook.Tables("LookGiro") Is Nothing Then dsLook.Tables("LookGiro").Clear()
        If Not dsLook.Tables("LookNama") Is Nothing Then dsLook.Tables("LookNama").Clear()
        If Not dsLook.Tables("LookBank") Is Nothing Then dsLook.Tables("LookBank").Clear()
        If Not dsLook.Tables("LookInv") Is Nothing Then dsLook.Tables("LookInv").Clear()
        If Not dsLook.Tables("LookValuta") Is Nothing Then dsLook.Tables("LookValuta").Clear()
        If STATE = "EDIT" Then
            daVGiro = New SqlDataAdapter(New SqlCommand("SELECT b.no_giro, a.kartu, a.tgl_jth_tempo, a.kd_bank, b.jml_trans, b.no_inv, b.tgl_trans, b.keterangan, c.nama, d.nama_bank FROM FIN.dbo.FIN_GIRO a, FIN.dbo.FIN_TRANS_GIRO b, FIN.dbo.v_kartu c, SIF.dbo.SIF_Bank d WHERE a.nomor=b.no_giro AND b.status = 'CLOSED' AND b.tipe_trans = 'JRR-KPT-11' AND a.kartu=c.kode AND a.kd_bank=d.kd_bank", sqlconn))
            daVGiro.Fill(dsLook, "LookGiro")
        Else
            daVGiro = New SqlDataAdapter(New SqlCommand("SELECT b.no_giro, a.kartu, a.tgl_jth_tempo, a.kd_bank, b.jml_trans, b.no_inv, b.tgl_trans, b.keterangan, c.nama, d.nama_bank FROM FIN.dbo.FIN_GIRO a, FIN.dbo.FIN_TRANS_GIRO b, FIN.dbo.v_kartu c, SIF.dbo.SIF_Bank d WHERE a.nomor=b.no_giro AND b.status = 'CLEARING' AND b.tipe_trans = 'JRR-KPT-11' AND a.kartu=c.kode AND a.kd_bank=d.kd_bank", sqlconn))
            daVGiro.Fill(dsLook, "LookGiro")
        End If

        luNoGiro.Properties.DataSource = dsLook.Tables("LookGiro")
        luNoGiro.Properties.DisplayMember = "no_giro"
        luNoGiro.Properties.ValueMember = "no_giro"
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
        daNoInv = New SqlDataAdapter(New SqlCommand("SELECT a.no_inv, a.kd_cust, a.jml_akhir, b.nama FROM FIN.dbo.FIN_NOTA a, FIN.dbo.v_kartu b WHERE a.kd_cust=b.kode AND a.jml_akhir > 0 AND a.tipe_trans = 'JRR-KPT-10'", sqlconn))
        daNoInv.Fill(dsLook, "LookInv")
        luNoInv.Properties.DataSource = dsLook.Tables("LookInv")
        luNoInv.Properties.DisplayMember = "no_inv"
        luNoInv.Properties.ValueMember = "no_inv"
        daValuta = New SqlDataAdapter(New SqlCommand("SELECT Kode_valuta, Nama_Valuta FROM SIF.dbo.SIF_Valuta", sqlconn))
        daValuta.Fill(dsLook, "LookValuta")
        lueValuta.Properties.DataSource = dsLook.Tables("LookValuta")
        lueValuta.Properties.DisplayMember = "Nama_Valuta"
        lueValuta.Properties.ValueMember = "Kode_valuta"
        lookValuta.DataSource = dsLook.Tables("LookValuta")
        lookValuta.DisplayMember = "Nama_Valuta"
        lookValuta.ValueMember = "Kode_valuta"
    End Sub

    Private Sub formCairGiroMsk_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        loadLookUp()
        prn.btnAdd_Click(sender, New EventArgs)
    End Sub

    Private Sub luNoGiro_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles luNoGiro.EditValueChanged
        If Not luNoGiro.EditValue = vbNullString Then
            If Not dsLook.Tables("LoadDetil") Is Nothing Then dsLook.Tables("LoadDetil").Clear()
            daLoad = New SqlDataAdapter(New SqlCommand("SELECT a.jns_trans, a.nomor, a.kartu, a.tgl_jth_tempo, a.kd_bank, a.kd_valuta, a.kurs_valuta, b.jml_trans, b.no_inv, b.tgl_trans, b.keterangan FROM FIN.dbo.FIN_GIRO a, FIN.dbo.FIN_TRANS_GIRO b WHERE a.nomor=b.no_giro AND a.nomor='" & luNoGiro.EditValue & "'", sqlconn))
            daLoad.Fill(dsLook, "LoadDetil")
            luNoGiro.EditValue = dsLook.Tables("LoadDetil").Rows(0).Item("nomor")
            luNama.EditValue = dsLook.Tables("LoadDetil").Rows(0).Item("kartu")
            deTglJthTmp.EditValue = dsLook.Tables("LoadDetil").Rows(0).Item("tgl_jth_tempo")
            luBank.EditValue = dsLook.Tables("LoadDetil").Rows(0).Item("kd_bank")
            luNoInv.EditValue = dsLook.Tables("LoadDetil").Rows(0).Item("no_inv")
            deTanggalClearing.EditValue = dsLook.Tables("LoadDetil").Rows(0).Item("tgl_trans")
            txtJumlah.Text = dsLook.Tables("LoadDetil").Rows(0).Item("jml_trans")
            txtKeterangan.Text = dsLook.Tables("LoadDetil").Rows(0).Item("keterangan")
            lueValuta.EditValue = dsLook.Tables("LoadDetil").Rows(0).Item("kd_valuta")
            txtKurs.EditValue = dsLook.Tables("LoadDetil").Rows(0).Item("kurs_valuta")
            If dsLook.Tables("LoadDetil").Rows(0).Item("jns_trans").ToString = "BELI" Then
                tipeTrans = "JKK-KUT-06"
            ElseIf dsLook.Tables("LoadDetil").Rows(0).Item("jns_trans").ToString = "JUAL" Then
                tipeTrans = "JKM-KPT-07"
            End If
        End If
    End Sub

    Private Sub txtJumlah_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJumlah.EditValueChanged
        If txtJumlah.EditValue = "0" Or txtJumlah.EditValue = vbNullString Then
            txtJumlah.EditValue = "1"
        End If
    End Sub

    Private Sub txtJumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJumlah.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 8, 45, 127
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub cek()
        If luNoGiro.EditValue = vbNullString Then
            isValid = False
            err &= "No. Giro harus dipilih." & vbCrLf
            If luNoInv.EditValue = vbNullString Then
                err &= "No. Invoice harus dipilih." & vbCrLf
            End If
            If txtJumlah.Text = "" Then
                err &= "Jumlah harus diisi." & vbCrLf
            End If
        ElseIf luNoInv.EditValue = vbNullString Then
            isValid = False
            err &= "No. Invoice harus dipilih." & vbCrLf
            If luNoGiro.EditValue = vbNullString Then
                err &= "No. Giro harus dipilih." & vbCrLf
            End If
            If txtJumlah.Text = "" Then
                err &= "Jumlah harus diisi." & vbCrLf
            End If
        ElseIf txtJumlah.Text = "" Then
            isValid = False
            err &= "Jumlah harus diisi." & vbCrLf
            If luNoInv.EditValue = vbNullString Then
                err &= "No. Invoice harus dipilih." & vbCrLf
            End If
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
                    row = dsGiro.Tables("SaveClearGiro").NewRow
                    row.Item("Kd_cabang") = getKodeCabang() ' <-- hanya contoh, nanti diisi dengan yg bener
                    row.Item("tipe_trans") = tipeTrans
                    noGiro = luNoGiro.EditValue
                    row.Item("no_giro") = luNoGiro.EditValue
                    row.Item("tgl_trans") = deTanggal.EditValue
                    row.Item("no_inv") = luNoInv.EditValue
                    row.Item("jml_trans") = txtJumlah.Text
                    row.Item("kd_valuta") = lueValuta.EditValue
                    row.Item("kurs_valuta") = txtKurs.EditValue
                    row.Item("keterangan") = txtKeterangan.Text
                    row.Item("status") = "CLOSED"
                    row.Item("Last_create_date") = getTanggal()
                    row.Item("Last_created_by") = umum.username
                    row.Item("Program_name") = Me.Name
                    dsGiro.Tables("SaveClearGiro").Rows.Add(row)

                    'If Not dsGiro.Tables("Giro") Is Nothing Then dsGiro.Tables("Giro").Clear()
                    'daGiro = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_GIRO WHERE nomor = '" & luNoGiro.EditValue & "'", sqlconn))
                    'daGiro.Fill(dsGiro, "Giro")
                    'rowG = dsGiro.Tables("Giro").Rows(0)
                    'rowG.Item("status") = "CAIR"
                    'rowG.Item("Last_Update_Date") = Now
                    'rowG.Item("Last_Updated_By") = umum.username
                ElseIf STATE = "EDIT" Then
                    row = dsLook.Tables("GiroEdit").Rows(0)
                    row.Item("tgl_trans") = deTanggal.EditValue
                    row.Item("no_inv") = luNoInv.EditValue
                    row.Item("jml_trans") = txtJumlah.EditValue
                    row.Item("kurs_valuta") = txtKurs.EditValue
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
                Else
                    Try
                        myBuilder = New SqlCommandBuilder(daClearGiro)
                        daClearGiro.UpdateCommand = myBuilder.GetUpdateCommand()
                        daClearGiro.InsertCommand = myBuilder.GetInsertCommand()
                        daClearGiro.DeleteCommand = myBuilder.GetDeleteCommand()

                        'myBuilder = New SqlCommandBuilder(daGiro)
                        'daGiro.UpdateCommand = myBuilder.GetUpdateCommand()
                        'daGiro.InsertCommand = myBuilder.GetInsertCommand()
                        'daGiro.DeleteCommand = myBuilder.GetDeleteCommand()

                        BTRANS = sqlconn.BeginTransaction("1")
                        daClearGiro.UpdateCommand.Transaction = BTRANS
                        daClearGiro.InsertCommand.Transaction = BTRANS
                        daClearGiro.DeleteCommand.Transaction = BTRANS

                        'daGiro.UpdateCommand.Transaction = BTRANS
                        'daGiro.InsertCommand.Transaction = BTRANS
                        'daGiro.DeleteCommand.Transaction = BTRANS

                        daClearGiro.Update(dsGiro.Tables("SaveClearGiro"))
                        'daGiro.Update(dsGiro.Tables("Giro"))

                        'dsGiro.Tables("SaveClearGiro").AcceptChanges()
                        'dsGiro.Tables("Giro").AcceptChanges()

                        call_procedure(tipeTrans, noGiro, BTRANS)

                        BTRANS.Commit()
                        showMessages("Berhasil disimpan..")
                        'STATE = "EDIT"
                        isValid = False
                        luNoGiro.Properties.ReadOnly = False
                        clear()
                        loadLookUp()
                        loadGrid()
                    Catch ex As Exception
                        BTRANS.Rollback()
                        dsGiro.Tables("SaveClearGiro").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                        'dsGiro.Tables("Giro").RejectChanges()
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

                'myBuilder = New SqlCommandBuilder(daGiro)
                'daGiro.UpdateCommand = myBuilder.GetUpdateCommand()
                'daGiro.InsertCommand = myBuilder.GetInsertCommand()
                'daGiro.DeleteCommand = myBuilder.GetDeleteCommand()

                BTRANS = sqlconn.BeginTransaction("1")
                daEdit.UpdateCommand.Transaction = BTRANS
                daEdit.InsertCommand.Transaction = BTRANS
                daEdit.DeleteCommand.Transaction = BTRANS

                'daGiro.UpdateCommand.Transaction = BTRANS
                'daGiro.InsertCommand.Transaction = BTRANS
                'daGiro.DeleteCommand.Transaction = BTRANS

                daEdit.Update(dsLook.Tables("GiroEdit"))
                'daGiro.Update(dsGiro.Tables("Giro"))

                'dsGiro.Tables("SaveClearGiro").AcceptChanges()
                'dsGiro.Tables("Giro").AcceptChanges()

                BTRANS.Commit()
                showMessages("Berhasil disimpan..")
                'STATE = "EDIT"
                isValid = False
                luNoGiro.Properties.ReadOnly = False
                clear()
                loadLookUp()
                loadGrid()
            Catch ex As Exception
                BTRANS.Rollback()
                dsLook.Tables("GiroEdit").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                'dsGiro.Tables("Giro").RejectChanges()
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub txtJumlah_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJumlah.TextChanged
        If txtJumlah.Text = "0,00" Or txtJumlah.Text = "0.00" Then
            txtJumlah.Text = dsLook.Tables("LoadDetil").Rows(0).Item("jml_trans")
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
        'If Not dsGiro.Tables("Giro") Is Nothing Then dsGiro.Tables("Giro").Clear()
    End Sub

    Private Sub gvGiro_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvGiro.DoubleClick
        Dim viewGiro As ColumnView = gvGiro
        STATE = "EDIT"
        loadLookUp()
        If Not dsLook.Tables("GiroEdit") Is Nothing Then dsLook.Tables("GiroEdit").Clear()
        noGiro = viewGiro.GetFocusedRowCellValue("no_giro").ToString
        daEdit = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_TRANS_GIRO WHERE no_giro='" & noGiro & "'", sqlconn))
        daEdit.Fill(dsLook, "GiroEdit")
        deTanggal.EditValue = dsLook.Tables("GiroEdit").Rows(0).Item("tgl_trans")
        luNoGiro.EditValue = dsLook.Tables("GiroEdit").Rows(0).Item("no_giro")
        luNoGiro.Properties.ReadOnly = True
        luNoInv.EditValue = dsLook.Tables("GiroEdit").Rows(0).Item("no_inv")
        txtJumlah.EditValue = dsLook.Tables("GiroEdit").Rows(0).Item("jml_trans")
        lueValuta.EditValue = dsLook.Tables("GiroEdit").Rows(0).Item("kd_valuta")
        txtKurs.EditValue = dsLook.Tables("GiroEdit").Rows(0).Item("kurs_valuta")
        txtKeterangan.Text = dsLook.Tables("GiroEdit").Rows(0).Item("keterangan")
    End Sub

    Public Sub delete_click()
        Dim viewGiro As ColumnView = gvGiro
        noGiro = viewGiro.GetFocusedRowCellValue("no_giro").ToString
        If MsgBox("Hapus Jurnal dengan nomor " & noGiro & " ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "DELETE?") = MsgBoxResult.Yes Then
            If Not dsLook.Tables("GiroEdit") Is Nothing Then dsLook.Tables("GiroEdit").Clear()
            daEdit = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_TRANS_GIRO WHERE no_giro='" & noGiro & "'", sqlconn))
            daEdit.Fill(dsLook, "GiroEdit")
            For Each rw As DataRow In dsLook.Tables("GiroEdit").Rows
                rw.Delete()
            Next
            'If Not dsGiro.Tables("Giro") Is Nothing Then dsGiro.Tables("Giro").Clear()
            'daGiro = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_GIRO WHERE nomor = '" & noGiro & "'", sqlconn))
            'daGiro.Fill(dsGiro, "Giro")
            'rowG = dsGiro.Tables("Giro").Rows(0)
            'rowG.Item("status") = "CLEARING"
            'rowG.Item("Last_Update_Date") = Now
            'rowG.Item("Last_Updated_By") = umum.username
            save_click(True)
            STATE = "ADD"
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
        Dim dr As SqlDataReader = sqlCmd.ExecuteReader
        dr.Close()
    End Sub

    Private Sub txtKurs_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKurs.EditValueChanged
        If txtKurs.EditValue = "0" Or txtKurs.EditValue = vbNullString Then
            txtKurs.EditValue = "1"
        End If
    End Sub

    Private Sub txtKurs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKurs.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 8, 45, 127
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub lueValuta_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueValuta.EditValueChanged
        If lueValuta.EditValue = "IDR" Then
            txtKurs.Enabled = False
        Else
            txtKurs.Enabled = True
        End If
    End Sub
End Class