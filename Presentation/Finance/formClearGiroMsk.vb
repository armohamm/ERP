Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Public Class formClearGiroMsk
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
    Dim daGiro, daClearGiro, daNama, daBank, daVGiro, daEdit, daLoad, daValuta, daCek As SqlDataAdapter
    Dim BTRANS As SqlTransaction
    Dim isValid As Boolean
    Dim err, giro As String
    Dim rowG As DataRow
    Dim jml As Integer = 0
    Dim isOK As Boolean
    Dim statu, jur As String
    Dim noGiro, kddivisi As String
    Dim jenis As String

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

    'Public Sub add_click()
    '    STATE = "ADD"
    '    btnSave = True
    '    btnEdit = False
    '    btnadd = False
    '    btnCancel = True
    '    btnDelete = True
    '    setStatus()
    '    loadGrid()
    'End Sub

    Private Sub clear()
        deTanggal.EditValue = getTanggal()
        luNoGiro.EditValue = vbNullString
        luNama.EditValue = vbNullString
        deTglJthTmp.EditValue = vbNullString
        luBank.EditValue = vbNullString
        lueValuta.EditValue = vbNullString
        txtKurs.EditValue = 0
        txtJumlah.EditValue = 0
        txtKeterangan.Text = ""
        controlOff(False)
        'btnadd = True
        'btnCancel = False
        'btnDelete = False
        'btnEdit = False
        'btnSave = False
        'setStatus()
        'Me.Enabled = False
    End Sub

    Private Sub reload_table(ByVal kode As String)
        If Not dsGiro.Tables("SaveClearGiro") Is Nothing Then dsGiro.Tables("SaveClearGiro").Clear()
        daClearGiro = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_TRANS_GIRO WHERE idrec = '" & kode & "'", sqlconn))
        daClearGiro.Fill(dsGiro, "SaveClearGiro")

        If dsGiro.Tables("SaveClearGiro").Rows.Count > 0 Then
            deTanggal.EditValue = dsGiro.Tables("SaveClearGiro").Rows(0).Item("tgl_trans")
            luNoGiro.EditValue = dsGiro.Tables("SaveClearGiro").Rows(0).Item("idrec")
            luNoGiro.Properties.ReadOnly = True
            Dim rwsx As DataRow = dsLook.Tables("LookGiro").Select("idrec='" & luNoGiro.EditValue & "'")(0)
            luNama.EditValue = rwsx.Item("kartu")
            deTglJthTmp.EditValue = rwsx.Item("tgl_jth_tempo")
            luBank.EditValue = rwsx.Item("kd_bank")
            lueValuta.EditValue = rwsx.Item("kd_valuta")
            txtKurs.EditValue = rwsx.Item("kurs_valuta")
            txtJumlah.EditValue = dsGiro.Tables("SaveClearGiro").Rows(0).Item("jml_trans")
            txtKeterangan.Text = IIf(IsNothing(dsGiro.Tables("SaveClearGiro").Rows(0).Item("keterangan")), "", dsGiro.Tables("SaveClearGiro").Rows(0).Item("keterangan"))
        End If
    End Sub

    Private Sub loadGrid()
        If Not dsGiro.Tables("ClearGiro") Is Nothing Then dsGiro.Tables("ClearGiro").Clear()
        daVGiro = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT a.tgl_trans, a.divisi, d.nama_departemen, a.no_giro, SUBSTRING(a.idrec,13,8) kartu, (SELECT tgl_jth_tempo x FROM FIN.dbo.FIN_GIRO WHERE idrec = a.idrec) tgl_jth_tempo, a.kd_valuta, a.kurs_valuta, a.kd_bank, a.no_inv, a.jml_trans, a.keterangan, SUBSTRING(a.idrec,11,1) jns_trans, a.idrec FROM FIN.dbo.FIN_TRANS_GIRO a, SIF.dbo.SIF_Departemen d WHERE SUBSTRING(a.idrec,12,1)=d.Kd_Departemen AND a.status='CLEARING' AND MONTH(a.tgl_trans) in (MONTH(GETDATE()), MONTH(DATEADD(mm, -1, GETDATE())), MONTH(DATEADD(mm, -2, GETDATE())), MONTH(DATEADD(mm, -3, GETDATE()))) ORDER BY a.tgl_trans desc, a.no_giro desc", sqlconn))
        daVGiro.Fill(dsGiro, "ClearGiro")
        gcGiro.DataSource = dsGiro.Tables("ClearGiro")
        'gvGiro.BestFitColumns()
        'deTanggal.EditValue = getTanggal()
    End Sub

    Private Sub lookGiro()
        If Not dsLook.Tables("LookGiro") Is Nothing Then dsLook.Tables("LookGiro").Clear()

        If STATE = "EDIT" Then
            daVGiro = New SqlDataAdapter(New SqlCommand("SELECT a.idrec, SUBSTRING(a.idrec,1,6) nomor, SUBSTRING(a.idrec,7,4) jns_trans, SUBSTRING(a.idrec,13,8) kartu, (SELECT tgl_jth_tempo x FROM FIN.dbo.FIN_GIRO WHERE idrec = a.idrec) tgl_jth_tempo, a.kd_bank, a.jml_trans, b.nama, c.nama_bank, a.kd_valuta, a.kurs_valuta, SUBSTRING(a.idrec,11,1) divisi, e.Nama_Departemen FROM FIN.dbo.FIN_TRANS_GIRO a, FIN.dbo.v_kartu b, SIF.dbo.SIF_Bank c, SIF.dbo.SIF_Departemen e WHERE SUBSTRING(a.idrec,13,8)=b.kode AND a.kd_bank=c.kd_bank AND a.divisi = e.Kd_Departemen AND SUBSTRING(a.idrec,7,4) = 'JUAL' AND a.[status] = 'CLEARING'", sqlconn))
            daVGiro.Fill(dsLook, "LookGiro")
        Else
            daVGiro = New SqlDataAdapter(New SqlCommand("SELECT a.idrec, a.nomor, a.jns_trans, a.kartu, a.tgl_jth_tempo, a.kd_bank, a.jml_trans, b.nama, c.nama_bank, a.kd_valuta, a.kurs_valuta, a.divisi, e.Nama_Departemen FROM FIN.dbo.FIN_GIRO a, FIN.dbo.v_kartu b, SIF.dbo.SIF_Bank c, FIN.dbo.FIN_JURNAL d, SIF.dbo.SIF_Departemen e WHERE a.kartu=b.kode AND a.kd_bank=c.kd_bank AND a.no_jur = d.no_jur AND a.divisi = e.Kd_Departemen AND (a.status LIKE 'DITERIMA%' OR a.status LIKE 'TOLAK%') AND a.jns_trans = 'JUAL' AND a.no_jur IN (SELECT DISTINCT no_jur FROM FIN.dbo.FIN_JURNAL WHERE NOT (no_posting IS NULL OR no_posting='')) ORDER BY a.nomor", sqlconn))
            daVGiro.Fill(dsLook, "LookGiro")
            'MsgBox(dsLook.Tables("LookGiro").Rows.Count)
        End If

        luNoGiro.Properties.DataSource = dsLook.Tables("LookGiro")
        luNoGiro.Properties.DisplayMember = "nomor"
        luNoGiro.Properties.ValueMember = "idrec"
    End Sub

    Private Sub loadLookUp()
        If Not dsLook.Tables("LookValuta") Is Nothing Then dsLook.Tables("LookValuta").Clear()
        If Not dsLook.Tables("LookNama") Is Nothing Then dsLook.Tables("LookNama").Clear()
        If Not dsLook.Tables("LookBank") Is Nothing Then dsLook.Tables("LookBank").Clear()
        If Not dsLook.Tables("LookDivisi") Is Nothing Then dsLook.Tables("LookDivisi").Clear()

        daNama = New SqlDataAdapter(New SqlCommand("SELECT Kd_Departemen, Nama_Departemen FROM SIF.dbo.SIF_Departemen", sqlconn))
        daNama.Fill(dsLook, "LookDivisi")
        lookDivisi.DataSource = dsLook.Tables("LookDivisi")
        lookDivisi.DisplayMember = "Nama_Departemen"
        lookDivisi.ValueMember = "Kd_Departemen"

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

    Private Sub formClearGiroMsk_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        STATE = "ADD"
        prn = getParent(Me)
        loadLookUp()
        loadGrid()
        clear()
        Me.Enabled = True
        deTanggal.EditValue = getTanggal()
        reload_table("xxx")
        'prn.btnAdd_Click(sender, New EventArgs)
    End Sub

    Private Sub luNoGiro_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles luNoGiro.EditValueChanged
        'loadLookUp()
        If Not luNoGiro.EditValue = vbNullString Then
            Dim giro As String = Microsoft.VisualBasic.Left(luNoGiro.EditValue, 6)
            Dim jeniss As String = Microsoft.VisualBasic.Mid(luNoGiro.EditValue, 7, 4)
            Dim divisi As String = Microsoft.VisualBasic.Mid(luNoGiro.EditValue, 11, 1)
            Dim bank As Integer = Microsoft.VisualBasic.Mid(luNoGiro.EditValue, 12, 1)
            Dim kartu As String = Microsoft.VisualBasic.Mid(luNoGiro.EditValue, 13)
            If Not STATE = "EDIT" Then
                Dim rowx As DataRow = dsLook.Tables("LookGiro").Select("nomor='" & giro & "' and jns_trans='" & jeniss & "' and divisi='" & divisi & "' and kd_bank='" & bank & "' and kartu='" & kartu & "'")(0)
                luNama.EditValue = rowx.Item("kartu")
                deTglJthTmp.EditValue = rowx.Item("tgl_jth_tempo")
                luBank.EditValue = rowx.Item("kd_bank")
                lueValuta.EditValue = rowx.Item("kd_valuta")
                txtKurs.EditValue = rowx.Item("kurs_valuta")
                jenis = rowx.Item("jns_trans")
                kddivisi = rowx.Item("divisi")
                txtJumlah.EditValue = rowx.Item("jml_trans")
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
        Dim row As DataRow

        If Not isDelete Then
            cek()
            If isValid Then
                If STATE = "ADD" Then
                    noGiro = Microsoft.VisualBasic.Left(luNoGiro.EditValue, 6)
                    row = dsGiro.Tables("SaveClearGiro").NewRow
                    row.Item("Kd_cabang") = getKodeCabang()
                    row.Item("tipe_trans") = "JRR-KPT-11"
                    row.Item("idrec") = luNoGiro.EditValue
                    row.Item("divisi") = kddivisi
                    row.Item("no_giro") = Microsoft.VisualBasic.Left(luNoGiro.EditValue, 6)
                    row.Item("tgl_trans") = deTanggal.EditValue
                    row.Item("jml_trans") = txtJumlah.EditValue
                    row.Item("kd_valuta") = lueValuta.EditValue
                    row.Item("kurs_valuta") = txtKurs.EditValue
                    'row.Item("kartu") = luNama.EditValue
                    row.Item("kd_bank") = luBank.EditValue
                    row.Item("keterangan") = txtKeterangan.Text
                    row.Item("status") = "CLEARING"
                    row.Item("Last_create_date") = getTanggal()
                    row.Item("Last_created_by") = umum.username
                    row.Item("Program_name") = Me.Name
                    dsGiro.Tables("SaveClearGiro").Rows.Add(row)
                ElseIf STATE = "EDIT" Then
                    row = dsGiro.Tables("SaveClearGiro").Rows(0)
                    noGiro = Microsoft.VisualBasic.Left(luNoGiro.EditValue, 6)
                    row.Item("divisi") = kddivisi
                    'row.Item("kartu") = luNama.EditValue
                    row.Item("tgl_trans") = deTanggal.EditValue
                    row.Item("jml_trans") = txtJumlah.EditValue
                    row.Item("kd_bank") = luBank.EditValue
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

        If isDelete Then
            With New SqlCommand("DELETE FROM FIN.dbo.FIN_JURNAL WHERE no_jur = '" & jur & "'", sqlconn, BTRANS)
                .ExecuteNonQuery()
            End With
            With New SqlCommand("DELETE FROM FIN.dbo.FIN_JURNAL_D WHERE no_jur = '" & jur & "'", sqlconn, BTRANS)
                .ExecuteNonQuery()
            End With
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
                call_procedure("JRR-KPT-11", luNoGiro.EditValue, BTRANS)
            End If

            BTRANS.Commit()

            If Not isDelete Then
                showMessages("Berhasil disimpan.")
            Else
                showMessages("Berhasil dihapus.")
            End If

            isValid = False
            luNoGiro.Properties.ReadOnly = False
            btnDelete = False
            setStatus()
            loadLookUp()
            loadGrid()
            clear()
            reload_table("xxx")
            If STATE = "EDIT" Then STATE = "ADD"
        Catch ex As Exception
            BTRANS.Rollback()
            dsGiro.Tables("SaveClearGiro").RejectChanges()
            MsgBox(ex.Message)
        End Try
        'MsgBox(dsGiro.Tables("SaveClearGiro").Rows.Count)
    End Sub

    Public Sub cancel_click()
        btnadd = False
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnSave = True
        setStatus()
        'Me.Enabled = False
        clear()
        'STATE = "ADD"
        luNoGiro.Properties.ReadOnly = False
        loadLookUp()
        loadGrid()
    End Sub

    'Private Sub gvGiro_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvGiro.Click
    '    Dim viewGiro As ColumnView = gvGiro
    '    giro = viewGiro.GetFocusedRowCellValue("no_giro").ToString

    '    If Not dsLook.Tables("GiroEdit") Is Nothing Then dsLook.Tables("GiroEdit").Clear()
    '    daEdit = New SqlDataAdapter(New SqlCommand("SELECT no_jur FROM FIN.dbo.FIN_TRANS_GIRO WHERE no_giro='" & giro & "'", sqlconn))
    '    daEdit.Fill(dsLook, "GiroEdit")
    'End Sub

    Private Sub gvGiro_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvGiro.DoubleClick
        Dim viewGiro As ColumnView = gvGiro
        STATE = "EDIT"
        'loadLookUp()
        'If Not dsLook.Tables("GiroEdit") Is Nothing Then dsLook.Tables("GiroEdit").Clear()
        If Not dsLook.Tables("CekJurnal") Is Nothing Then dsLook.Tables("CekJurnal").Clear()
        'daEdit = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_TRANS_GIRO WHERE no_giro='" & giro & "'", sqlconn))
        'daEdit.Fill(dsLook, "GiroEdit")
        'noGiro = viewGiro.GetFocusedRowCellValue("idrec").ToString
        lookGiro()
        reload_table(viewGiro.GetFocusedRowCellValue("idrec").ToString)
        daCek = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_JURNAL WHERE no_jur='" & dsGiro.Tables("SaveClearGiro").Rows(0).Item("no_jur").ToString & "'", sqlconn))
        daCek.Fill(dsLook, "CekJurnal")
        'daCek = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_JURNAL_D WHERE no_jur='" & dsGiro.Tables("SaveClearGiro").Rows(0).Item("no_jur").ToString & "'", sqlconn))
        'daCek.Fill(dsLook, "CekJurnalD")
        If Not dsLook.Tables("CekJurnal").Rows.Count <= 0 Then
            If Not (dsLook.Tables("CekJurnal").Rows(0).Item("no_posting").ToString = vbNullString Or dsLook.Tables("CekJurnal").Rows(0).Item("no_posting").ToString = "" Or TypeOf dsLook.Tables("CekJurnal").Rows(0).Item("no_posting") Is DBNull) Then
                controlOff(True)
                btnSave = False
                btnDelete = False
                setStatus()
                luNoGiro.Properties.ReadOnly = True
                MsgBox("Giro " & giro & " sudah diposting. Tidak boleh ada perubahan.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN")
            Else
                controlOff(False)
                luNoGiro.Properties.ReadOnly = True
                btnSave = True
                btnDelete = True
                setStatus()
                err = ""
                isOK = True
            End If
        Else
            isOK = True
            btnDelete = True
            setStatus()
        End If
    End Sub

    Public Sub controlOff(ByVal stat As Boolean)
        deTanggal.Properties.ReadOnly = stat
        luNoGiro.Properties.ReadOnly = stat
        txtJumlah.Properties.ReadOnly = stat
        lueValuta.Properties.ReadOnly = stat
        txtKurs.Properties.ReadOnly = stat
        txtKeterangan.ReadOnly = stat
        luBank.Properties.ReadOnly = stat
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

    Public Sub call_procedure_del(ByVal noG As String, ByVal tipe As String, ByVal trans As SqlTransaction)

        Dim sqlCmd As New SqlCommand
        sqlCmd.Transaction = trans
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
        'giro = viewGiro.GetFocusedRowCellValue("no_giro").ToString
        'If dsLook.Tables("GiroEdit").Rows(0).Item("no_jur") Is Nothing Or dsLook.Tables("GiroEdit").Rows(0).Item("no_jur") = vbNullString Or dsLook.Tables("GiroEdit").Rows(0).Item("no_jur") = "" Then
        If isOK = True Then
            If MsgBox("Hapus giro dengan nomor " & luNoGiro.Text & " ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "DELETE?") = MsgBoxResult.Yes Then
                For Each rw As DataRow In dsGiro.Tables("SaveClearGiro").Rows
                    statu = rw.Item("status")
                    jur = rw.Item("no_jur")
                    rw.Delete()
                Next
                'If Not dsGiro.Tables("Giro") Is Nothing Then dsGiro.Tables("Giro").Clear()
                'daGiro = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_GIRO WHERE nomor = '" & giro & "'", sqlconn))
                'daGiro.Fill(dsGiro, "Giro")
                'rowG = dsGiro.Tables("Giro").Rows(0)
                'rowG.Item("status") = "DITERIMA"
                'rowG.Item("Last_Update_Date") = Now
                'rowG.Item("Last_Updated_By") = umum.username
                save_click(True)
                STATE = "ADD"
            End If
        Else
            MsgBox("Giro tidak dapat dihapus, karena sudah diposting.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN")
            Exit Sub
        End If
    End Sub

    Private Sub lueValuta_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueValuta.EditValueChanged
        Try
            If Not (lueValuta.EditValue = vbNullString Or TypeOf lueValuta.EditValue Is DBNull) Then
                If lueValuta.EditValue = "IDR" Then
                    txtKurs.EditValue = 1
                    txtKurs.Enabled = False
                Else
                    txtKurs.Enabled = True
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub luNoGiro_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles luNoGiro.QueryPopUp
        lookGiro()
    End Sub
End Class