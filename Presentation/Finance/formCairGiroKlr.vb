'tgl 19/06/2015
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Public Class formCairGiroKlr
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public prn As frmMain
    Public STATE As String
    Dim myBuilder As New SqlCommandBuilder
    Dim dsGiro, dsLook, dsEdit As New DataSet
    Dim daGiro, daClearGiro, daNama, daBank, daNoInv, daVGiro, daEdit, daLoad, daValuta As SqlDataAdapter
    Dim drGiro As SqlDataReader
    Dim BTRANS As SqlTransaction
    Dim isValid As Boolean
    Dim err, tipeTrans As String
    Dim noGiro As String
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

    Private Sub clear()
        deTanggal.EditValue = Now
        luNoGiro.EditValue = vbNullString
        luNama.EditValue = vbNullString
        deTglJthTmp.EditValue = vbNullString
        luBank.EditValue = vbNullString
        lueValuta.EditValue = vbNullString
        txtKurs.EditValue = 0
        txtJumlah.EditValue = 0
        txtKeterangan.Text = ""
        btnadd = False
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnSave = True
        setStatus()
    End Sub

    Private Sub loadGrid()
        If Not dsGiro.Tables("ClearGiro") Is Nothing Then dsGiro.Tables("ClearGiro").Clear()
        daVGiro = New SqlDataAdapter(New SqlCommand("SELECT a.idrec, a.tgl_trans, a.no_giro, b.kartu, b.tgl_jth_tempo, b.kd_bank, a.no_inv, a.jml_trans, a.kd_valuta, a.kurs_valuta, a.keterangan FROM FIN.dbo.FIN_TRANS_GIRO a, FIN.dbo.FIN_GIRO b WHERE a.idrec=b.idrec AND a.tipe_trans IN ('JKK-KUT-09', 'JKK-KUT-07') AND a.status='CLOSED' ORDER BY tgl_trans DESC", sqlconn))
        daVGiro.Fill(dsGiro, "ClearGiro")
        gcGiro.DataSource = dsGiro.Tables("ClearGiro")
        gvGiro.BestFitColumns()
    End Sub

    Private Sub loadData(ByVal kode As String)
        If Not dsGiro.Tables("SaveClearGiro") Is Nothing Then dsGiro.Tables("SaveClearGiro").Clear()

        daClearGiro = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_TRANS_GIRO WHERE idrec = '" & kode & "'", sqlconn))
        daClearGiro.Fill(dsGiro, "SaveClearGiro")
    End Sub

    Private Sub loadLookUp()
        If Not dsLook.Tables("LookGiro") Is Nothing Then dsLook.Tables("LookGiro").Clear()
        If Not dsLook.Tables("LookNama") Is Nothing Then dsLook.Tables("LookNama").Clear()
        If Not dsLook.Tables("LookBank") Is Nothing Then dsLook.Tables("LookBank").Clear()
        If Not dsLook.Tables("LookValuta") Is Nothing Then dsLook.Tables("LookValuta").Clear()

        If STATE = "EDIT" Then
            daVGiro = New SqlDataAdapter(New SqlCommand("SELECT a.idrec, b.no_giro, a.kartu, a.tgl_jth_tempo, a.kd_bank, b.jml_trans, b.tgl_trans, b.keterangan, c.nama, d.nama_bank FROM FIN.dbo.FIN_GIRO a, FIN.dbo.FIN_TRANS_GIRO b, FIN.dbo.v_kartu c, SIF.dbo.SIF_Bank d WHERE a.idrec=b.idrec AND b.tipe_trans IN ('JRR-KUT-09','JRR-KUT-08') AND a.kartu=c.kode AND a.kd_bank=d.kd_bank", sqlconn))
            daVGiro.Fill(dsLook, "LookGiro")
        Else
            daVGiro = New SqlDataAdapter(New SqlCommand("SELECT a.idrec, a.nomor, a.kartu, a.tgl_jth_tempo, a.kd_bank, c.nama, d.nama_bank, a.jml_trans FROM FIN.dbo.FIN_GIRO a, FIN.dbo.v_kartu c, SIF.dbo.SIF_Bank d WHERE a.kartu=c.kode AND a.kd_bank=d.kd_bank AND a.status = 'KELUAR' AND a.tipe_trans IN ('JRR-KUT-09','JRR-KUT-08') ORDER BY a.nomor", sqlconn))
            daVGiro.Fill(dsLook, "LookGiro")
        End If

        luNoGiro.Properties.DataSource = dsLook.Tables("LookGiro")
        luNoGiro.Properties.DisplayMember = "nomor"
        luNoGiro.Properties.ValueMember = "idrec"

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
        Me.Enabled = True
        loadLookUp()
        loadGrid()
        loadData("XXX")
        STATE = "ADD"
        deTanggal.EditValue = Now
        'prn.btnAdd_Click(sender, New EventArgs)
    End Sub

    Private Sub luNoGiro_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles luNoGiro.EditValueChanged
        If Not luNoGiro.EditValue = vbNullString Then
            If Not dsLook.Tables("LoadDetil") Is Nothing Then dsLook.Tables("LoadDetil").Clear()
            daLoad = New SqlDataAdapter(New SqlCommand("SELECT a.tipe_trans, a.idrec, a.nomor, a.kartu, a.tgl_jth_tempo, a.kd_bank, a.kd_valuta, a.kurs_valuta, a.jml_trans FROM FIN.dbo.FIN_GIRO a WHERE a.idrec='" & luNoGiro.EditValue & "'", sqlconn))
            daLoad.Fill(dsLook, "LoadDetil")
            'luNoGiro.EditValue = dsLook.Tables("LoadDetil").Rows(0).Item("idrec")
            luNama.EditValue = dsLook.Tables("LoadDetil").Rows(0).Item("kartu")
            deTglJthTmp.EditValue = dsLook.Tables("LoadDetil").Rows(0).Item("tgl_jth_tempo")
            luBank.EditValue = dsLook.Tables("LoadDetil").Rows(0).Item("kd_bank")
            txtJumlah.EditValue = dsLook.Tables("LoadDetil").Rows(0).Item("jml_trans")
            lueValuta.EditValue = dsLook.Tables("LoadDetil").Rows(0).Item("kd_valuta")
            tipeTrans = dsLook.Tables("LoadDetil").Rows(0).Item("tipe_trans")
            If Not STATE = "EDIT" Then
                txtKurs.EditValue = dsLook.Tables("LoadDetil").Rows(0).Item("kurs_valuta")
            End If
        End If
    End Sub

    Private Sub txtJumlah_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtJumlah.EditValueChanged
        If txtJumlah.EditValue = "0" Or txtJumlah.EditValue = vbNullString Then
            If luNoGiro.EditValue = vbNullString Then
                txtJumlah.EditValue = "1"
            Else
                txtJumlah.EditValue = dsLook.Tables("LoadDetil").Rows(0).Item("jml_trans")
            End If
        End If
    End Sub

    Private Sub cek()
        If luNoGiro.EditValue = vbNullString Then
            isValid = False
            err &= "No. Giro harus dipilih." & vbCrLf
            If txtJumlah.EditValue = 0 Then
                err &= "Jumlah harus diisi." & vbCrLf
            End If
        ElseIf txtJumlah.EditValue = 0 Then
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
                    row = dsGiro.Tables("SaveClearGiro").NewRow
                    noGiro = luNoGiro.EditValue
                    row.Item("idrec") = noGiro
                    row.Item("Kd_cabang") = getKodeCabang() ' <-- hanya contoh, nanti diisi dengan yg bener
                    row.Item("tipe_trans") = IIf(tipeTrans = "JRR-KUT-09", "JKK-KUT-09", "JKK-KUT-07")
                    row.Item("no_giro") = luNoGiro.Text
                    row.Item("tgl_trans") = deTanggal.EditValue
                    row.Item("kd_bank") = luBank.EditValue
                    row.Item("jml_trans") = txtJumlah.EditValue
                    row.Item("kd_valuta") = lueValuta.EditValue
                    row.Item("kurs_valuta") = txtKurs.EditValue
                    row.Item("keterangan") = txtKeterangan.Text
                    row.Item("status") = "CLOSED"
                    row.Item("Last_create_date") = getTanggal()
                    row.Item("Last_created_by") = umum.username
                    row.Item("Program_name") = Me.Name
                    dsGiro.Tables("SaveClearGiro").Rows.Add(row)
                ElseIf STATE = "EDIT" Then
                    row = dsGiro.Tables("SaveClearGiro").Rows(0)
                    row.Item("tgl_trans") = deTanggal.EditValue
                    row.Item("jml_trans") = txtJumlah.EditValue
                    row.Item("kurs_valuta") = txtKurs.EditValue
                    row.Item("keterangan") = txtKeterangan.Text
                    row.Item("Last_Update_Date") = Now
                    row.Item("Last_Updated_By") = umum.username
                End If
            Else
                MsgBox("Kesalahan dalam pengisian data berikut :" & vbCrLf & err, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR!")
                err = ""
                Exit Sub
            End If
        End If

        Try
            myBuilder = New SqlCommandBuilder(daClearGiro)
            daClearGiro.UpdateCommand = myBuilder.GetUpdateCommand()
            daClearGiro.InsertCommand = myBuilder.GetInsertCommand()
            daClearGiro.DeleteCommand = myBuilder.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            daClearGiro.UpdateCommand.Transaction = BTRANS
            daClearGiro.InsertCommand.Transaction = BTRANS
            daClearGiro.DeleteCommand.Transaction = BTRANS

            daClearGiro.Update(dsGiro.Tables("SaveClearGiro"))

            If Not isDelete Then
                call_procedure(IIf(tipeTrans = "JRR-KUT-09", "JKK-KUT-09", "JKK-KUT-07"), noGiro, BTRANS)
            Else
                With New SqlCommand("DELETE FROM FIN.dbo.FIN_JURNAL WHERE tipe_trans = '" & IIf(tipeTrans = "JRR-KUT-09", "JKK-KUT-09", "JKK-KUT-07") & "' AND no_ref3 = '" & noGiro & "'", sqlconn, BTRANS)
                    .ExecuteNonQuery()
                End With
                With New SqlCommand("DELETE FROM FIN.dbo.FIN_JURNAL_D WHERE tipe_trans = '" & IIf(tipeTrans = "JRR-KUT-09", "JKK-KUT-09", "JKK-KUT-07") & "' AND no_ref3 = '" & noGiro & "'", sqlconn, BTRANS)
                    .ExecuteNonQuery()
                End With
            End If

            BTRANS.Commit()
            If Not isDelete Then
                showMessages("Berhasil disimpan.")
                isValid = False
                luNoGiro.Properties.ReadOnly = False
                clear()
                loadLookUp()
                loadGrid()
                loadData("XXX")
            Else
                showMessages("Berhasil dihapus.")
                cancel_click()
            End If
            STATE = "ADD"
        Catch ex As Exception
            BTRANS.Rollback()
            dsGiro.Tables("SaveClearGiro").RejectChanges()
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub cancel_click()
        clear()
        STATE = "ADD"
        loadData("XXX")
    End Sub

    Private Sub controlOff(ByVal stat As Boolean)
        deTanggal.Properties.ReadOnly = stat
        luNoGiro.Properties.ReadOnly = stat
        txtKurs.Properties.ReadOnly = stat
        txtJumlah.Properties.ReadOnly = stat
        txtKeterangan.ReadOnly = stat
        gvGiro.OptionsBehavior.ReadOnly = stat
    End Sub

    Private Sub gvGiro_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvGiro.DoubleClick
        Dim viewGiro As ColumnView = gvGiro
        STATE = "EDIT"
        loadLookUp()
        noGiro = viewGiro.GetFocusedRowCellValue("idrec").ToString
        loadData(noGiro)

        deTanggal.EditValue = dsGiro.Tables("SaveClearGiro").Rows(0).Item("tgl_trans")
        luNoGiro.EditValue = noGiro
        luNoGiro.Properties.ReadOnly = True
        txtJumlah.EditValue = dsGiro.Tables("SaveClearGiro").Rows(0).Item("jml_trans")
        lueValuta.EditValue = dsGiro.Tables("SaveClearGiro").Rows(0).Item("kd_valuta")
        txtKurs.EditValue = dsGiro.Tables("SaveClearGiro").Rows(0).Item("kurs_valuta")
        txtKeterangan.Text = dsGiro.Tables("SaveClearGiro").Rows(0).Item("keterangan")

        drGiro = New SqlCommand("SELECT ISNULL(no_posting,'-') FROM FIN.dbo.FIN_JURNAL WHERE no_jur = '" & dsGiro.Tables("SaveClearGiro").Rows(0).Item("no_jur") & "'", sqlconn).ExecuteReader

        While drGiro.Read()
            If Not (drGiro.Item(0) = "-") Then
                MsgBox("Giro " & dsGiro.Tables("SaveClearGiro").Rows(0).Item("nomor") & " sudah diposting. Tidak boleh ada perubahan.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN")
                controlOff(True)
                btnSave = False
                btnDelete = False
                btnCancel = True
                setStatus()
            Else
                controlOff(False)
                luNoGiro.Properties.ReadOnly = True
                btnSave = True
                btnDelete = True
                setStatus()
            End If
        End While
        drGiro.Close()
    End Sub

    Public Sub delete_click()
        'Dim viewGiro As ColumnView = gvGiro
        'noGiro = dsGiro.Tables("SaveClearGiro").Rows(0).Item("idrec")
        If MsgBox("Hapus pencairan giro dengan nomor " & Microsoft.VisualBasic.Left(noGiro, 6) & " ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "DELETE?") = MsgBoxResult.Yes Then
            For Each rw As DataRow In dsGiro.Tables("SaveClearGiro").Rows
                rw.Delete()
            Next
            save_click(True)
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

    Private Sub lueValuta_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueValuta.EditValueChanged
        If lueValuta.EditValue = "IDR" Then
            txtKurs.Enabled = False
        Else
            txtKurs.Enabled = True
        End If
    End Sub
End Class