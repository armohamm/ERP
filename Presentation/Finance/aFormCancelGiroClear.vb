Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Public Class aFormCancelGiroClear
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public prn As frmMain
    Public STATE As String
    Dim myBuilderM, myBuilderD As New SqlCommandBuilder
    Dim dsGiro, dsLook, dsEdit As New DataSet
    Dim daGiro, daClearGiro, daNama, daBank, daVGiro, daEdit, daLoad As SqlDataAdapter
    Dim drGiro As SqlDataReader
    Dim BTRANS As SqlTransaction
    Dim isValid As Boolean
    Dim err, err1 As String
    Dim giro As String
    Dim rowG As DataRow
    Dim jml As Integer = 0
    Dim isOK As Boolean
    Dim statu, jenis, kddivisi, jur As String
    Dim noGiro As String

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

    Public Sub controlOff(ByVal stat As Boolean)
        deTanggal.Properties.ReadOnly = stat
        luNoGiro.Properties.ReadOnly = stat
        txtJumlah.Properties.ReadOnly = stat
        'txtNoRek.Properties.ReadOnly = stat
        'luBank.Properties.ReadOnly = stat
        txtKeterangan.ReadOnly = stat
        luBank.Properties.ReadOnly = stat
        'luNama.Properties.ReadOnly = stat
        'deTglJthTmp.Properties.ReadOnly = stat
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
        txtNoRek.EditValue = vbNullString
        txtJumlah.EditValue = 0
        txtKeterangan.Text = ""
        controlOff(False)
    End Sub

    Private Sub reload_table(ByVal kode As String)
        If Not dsGiro.Tables("SaveClearGiro") Is Nothing Then dsGiro.Tables("SaveClearGiro").Clear()
        daClearGiro = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_TRANS_GIRO WHERE idrec = '" & kode & "'", sqlconn))
        daClearGiro.Fill(dsGiro, "SaveClearGiro")

        If Not dsGiro.Tables("SaveClearGiro").Rows.Count <= 0 Then
            deTanggal.EditValue = dsGiro.Tables("SaveClearGiro").Rows(0).Item("tgl_trans")
            luNoGiro.EditValue = dsGiro.Tables("SaveClearGiro").Rows(0).Item("idrec")
            luNoGiro.Properties.ReadOnly = True
            Dim rwsx As DataRow = dsLook.Tables("LookGiro").Select("idrec='" & luNoGiro.EditValue & "'")(0)
            luNama.EditValue = rwsx.Item("kartu")
            deTglJthTmp.EditValue = rwsx.Item("tgl_jth_tempo")
            luBank.EditValue = rwsx.Item("kd_bank")
            'txtNoRek.EditValue = rwsx.Item("kd_valuta")
            txtJumlah.EditValue = dsGiro.Tables("SaveClearGiro").Rows(0).Item("jml_trans")
            txtKeterangan.Text = IIf(IsNothing(dsGiro.Tables("SaveClearGiro").Rows(0).Item("keterangan")), "", dsGiro.Tables("SaveClearGiro").Rows(0).Item("keterangan"))
        End If
    End Sub

    Private Sub loadGrid()
        If Not dsGiro.Tables("ClearGiro") Is Nothing Then dsGiro.Tables("ClearGiro").Clear()
        daVGiro = New SqlDataAdapter(New SqlCommand("SELECT a.tgl_trans, a.no_giro, b.kartu, b.tgl_jth_tempo, b.kd_bank, a.no_inv, a.jml_trans, a.keterangan, a.no_jur, a.idrec FROM FIN.dbo.FIN_TRANS_GIRO a, FIN.dbo.FIN_GIRO b WHERE a.idrec=b.idrec AND a.tipe_trans='JRR-KPT-12' AND MONTH(a.tgl_trans) in (MONTH(GETDATE()), MONTH(DATEADD(mm, -1, GETDATE())), MONTH(DATEADD(mm, -2, GETDATE())), MONTH(DATEADD(mm, -3, GETDATE()))) ORDER BY a.tgl_trans desc, a.no_giro desc", sqlconn))
        daVGiro.Fill(dsGiro, "ClearGiro")
        gcGiro.DataSource = dsGiro.Tables("ClearGiro")
        gvGiro.BestFitColumns()
    End Sub

    Private Sub lookGiro()
        If Not dsLook.Tables("LookGiro") Is Nothing Then dsLook.Tables("LookGiro").Clear()

        If STATE = "ADD" Then
            daVGiro = New SqlDataAdapter(New SqlCommand("SELECT a.idrec, a.jns_trans, a.nomor, a.kartu, a.tgl_jth_tempo, a.kd_bank, a.divisi, " & _
                                                        " a.jml_trans, b.nama, c.nama_bank " & _
                                                        " FROM FIN.dbo.FIN_GIRO a, FIN.dbo.v_kartu b, SIF.dbo.SIF_Bank c, fin.dbo.fin_jurnal d, " & _
                                                        " FIN.dbo.FIN_TRANS_GIRO e " & _
                                                        " WHERE(a.kartu = b.kode) " & _
                                                        " AND a.kd_bank=c.kd_bank " & _
                                                        " and a.idrec = e.idrec " & _
                                                        " and e.no_jur = d.no_jur " & _
                                                        " AND a.status LIKE 'CLEARING%' " & _
                                                        " and a.jns_trans = 'JUAL'" & _
                                                        " and not (d.no_posting is null or d.no_posting = '') " & _
                                                        " order by a.nomor", sqlconn))
        Else
            daVGiro = New SqlDataAdapter(New SqlCommand("SELECT a.idrec, a.nomor, a.kartu, a.tgl_jth_tempo, a.kd_bank, a.jml_trans, b.nama, c.nama_bank " & _
                                   " FROM FIN.dbo.FIN_GIRO a, FIN.dbo.v_kartu b, " & _
                                   " SIF.dbo.SIF_Bank c, fin.dbo.fin_jurnal d, FIN.dbo.FIN_TRANS_GIRO e " & _
                                   " WHERE(a.kartu = b.kode) AND a.kd_bank=c.kd_bank and a.idrec = e.idrec and e.no_jur = d.no_jur ", sqlconn))
        End If
       
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

    Private Sub aFormCancelGiroClear_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        STATE = "ADD"
        prn = getParent(Me)
        loadLookUp()
        loadGrid()
        clear()
        deTanggal.EditValue = getTanggal()
        reload_table("xxx")
        Me.Enabled = True
        'prn.btnAdd_Click(sender, New EventArgs)
    End Sub

    Private Sub luNoGiro_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles luNoGiro.EditValueChanged
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
        Dim row As DataRow
        If Not isDelete Then
            cek()
            If isValid Then
                If STATE = "ADD" Then
                    noGiro = Microsoft.VisualBasic.Left(luNoGiro.EditValue, 6)
                    row = dsGiro.Tables("SaveClearGiro").NewRow
                    row.Item("Kd_cabang") = getKodeCabang() ' <-- hanya contoh, nanti diisi dengan yg bener
                    row.Item("tipe_trans") = "JRR-KPT-12"
                    row.Item("idrec") = luNoGiro.EditValue
                    row.Item("divisi") = kddivisi
                    row.Item("no_giro") = noGiro
                    row.Item("status") = "TOLAK"
                    row.Item("kd_bank") = luBank.EditValue
                    row.Item("tgl_trans") = deTanggal.EditValue
                    row.Item("jml_trans") = txtJumlah.EditValue
                    row.Item("keterangan") = txtKeterangan.Text
                    row.Item("Last_create_date") = Now
                    row.Item("Last_created_by") = umum.username
                    row.Item("Program_name") = Me.Name
                ElseIf STATE = "EDIT" Then
                    noGiro = Microsoft.VisualBasic.Left(luNoGiro.EditValue, 6)
                    row = dsGiro.Tables("SaveClearGiro").Rows(0)
                    row.Item("tgl_trans") = deTanggal.EditValue
                    row.Item("jml_trans") = txtJumlah.EditValue
                    row.Item("keterangan") = txtKeterangan.Text
                    row.Item("Last_Update_Date") = Now
                    row.Item("Last_Updated_By") = umum.username
                End If

            Else
                MsgBox("Kesalahan dalam pengisian data berikut :" & vbCrLf & err, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR!")
                err = ""
            End If
        End If

        If isDelete Then
            row.Item("status") = "CLEARING"
        ElseIf STATE = "ADD" Then
            dsGiro.Tables("SaveClearGiro").Rows.Add(row)
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

            If Not isDelete Then
                call_procedure("JRR-KPT-12", luNoGiro.EditValue, BTRANS)
            Else
                call_procedure_del(jur, "X")
            End If

            BTRANS.Commit()
            If Not isDelete Then
                showMessages("Berhasil disimpan.")
            Else
                showMessages("Berhasil dihapus.")
            End If
            'STATE = "EDIT"
            isValid = False
            luNoGiro.Properties.ReadOnly = False
            txtJumlah.Properties.ReadOnly = False
            clear()
            loadLookUp()
            loadGrid()
            reload_table("xxx")
            If STATE = "EDIT" Then STATE = "ADD"
        Catch ex As Exception
            BTRANS.Rollback()
            dsGiro.Tables("SaveClearGiro").RejectChanges()
            MsgBox(ex.Message)
        End Try
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
        STATE = "ADD"
        'STATE = "ADD"
        luNoGiro.Properties.ReadOnly = False
        loadLookUp()
        loadGrid()
        reload_table("XXX")
    End Sub

    Private Sub gvGiro_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvGiro.DoubleClick
        Dim viewGiro As ColumnView = gvGiro
        If Not dsLook.Tables("CekJurnal") Is Nothing Then dsLook.Tables("CekJurnal").Clear()
        giro = viewGiro.GetFocusedRowCellValue("no_giro").ToString
        STATE = "EDIT"
        lookGiro()
        reload_table(viewGiro.GetFocusedRowCellValue("idrec").ToString)
        daEdit = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_JURNAL WHERE no_jur='" & dsGiro.Tables("SaveClearGiro").Rows(0).Item("no_jur").ToString & "'", sqlconn))
        daEdit.Fill(dsLook, "CekJurnal")
        If Not (dsLook.Tables("CekJurnal").Rows(0).Item("no_posting").ToString = vbNullString Or dsLook.Tables("CekJurnal").Rows(0).Item("no_posting").ToString = "" Or TypeOf dsLook.Tables("CekJurnal").Rows(0).Item("no_posting") Is DBNull) Then
            controlOff(True)
            btnSave = False
            btnDelete = False
            setStatus()
            MsgBox("Pembatalan clearing untuk giro " & giro & " sudah diposting. Tidak boleh ada perubahan atau dihapus.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN")
            Exit Sub
        Else
            controlOff(False)
            btnSave = True
            btnDelete = True
            setStatus()
            luNoGiro.Properties.ReadOnly = True
            err = ""
            isOK = True
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
        If isOK = True Then
            If MsgBox("Hapus giro dengan nomor " & luNoGiro.Text & " ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "DELETE?") = MsgBoxResult.Yes Then
                For Each rw As DataRow In dsGiro.Tables("SaveClearGiro").Rows
                    'statu = rw.Item("status")
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
        lookGiro()
    End Sub
End Class