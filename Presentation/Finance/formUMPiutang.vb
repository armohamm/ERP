Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Public Class formUMPiutang
    Dim dsUM, dsLookUp As New DataSet
    Dim daUM, daLookUp, daJur As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
    Dim prn As frmMain
    Public btnSave As Boolean = True
    Public btnAdd As Boolean = False
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public State As String
    Public kode, kodeCari As String
    Dim err, noJurnal, x As String
    Dim isOK As Boolean = True
    Dim table As DataTable
    Dim drUM As SqlDataReader

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btnCetak
        End With
    End Sub

    Private Sub formUMPiutang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        State = "ADD"
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        Me.Enabled = True

        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnAdd = False
        State = "ADD"
        setStatus()

        loadLookUp()
        bersihkan()
        isiGrid()

        loadData("XXX")

        dttgl_inv.EditValue = getTanggal()
        lookupJenis.EditValue = "03"
    End Sub

    Public Sub bersihkan()
        'If Not ds1.Tables("Db_data1") Is Nothing Then ds1.Tables("Db_data1").Clear()
        txtno_inv.EditValue = vbNullString
        txtjml_val_trans.EditValue = vbNullString
        Lookkaryawan.EditValue = vbNullString
        txtketerangan.EditValue = vbNullString
        lookupJenis.EditValue = "03"
        txtkurs_valuta.EditValue = 1
        Lookvaluta.EditValue = "IDR"
        lookBank.EditValue = vbNullString
        lookupGiro.EditValue = vbNullString
        If Not dsLookUp.Tables("VUM") Is Nothing Then dsLookUp.Tables("VUM").Clear()
    End Sub

    Public Sub isiGrid()
        If Not dsLookUp.Tables("VUM") Is Nothing Then dsLookUp.Tables("VUM").Clear()
        daLookUp = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_UM where tipe_trans IN ('JKM-KPT-04', 'JKM-KPT-05') AND NOT (no_jurnal IS NULL OR no_jurnal = '')", sqlconn)) 'nomor,tanggal,kartu,jml_val_trans,keterangan from FIN.dbo.FIN_UM", sqlconn))
        daLookUp.Fill(dsLookUp, "VUM")
        GC.DataSource = dsLookUp.Tables("VUM")
        GV.BestFitColumns()
    End Sub

    Private Sub loadData(ByVal kode As String)
        If Not dsUM.Tables("UM") Is Nothing Then dsUM.Tables("UM").Clear()

        daUM = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_UM where nomor = '" & kode & "'", sqlconn)) 'nomor,tanggal,kartu,jml_val_trans,keterangan from FIN.dbo.FIN_UM", sqlconn))
        daUM.Fill(dsUM, "UM")
    End Sub

    Public Sub save_click(Optional ByVal isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction
        If Not isDelete Then
            cek()
            If isOK = True Then
                If State = "ADD" Then
                    txtno_inv.EditValue = getNoTrans("DO", dttgl_inv.EditValue, BTRANS)
                    row = dsUM.Tables("UM").NewRow
                    row.Item("Kd_cabang") = getKodeCabang()
                    row.Item("nomor") = txtno_inv.EditValue
                    row.Item("Last_create_date") = getTanggal()
                    row.Item("Last_created_by") = username
                    row.Item("Program_name") = Me.Name
                ElseIf State = "EDIT" Then
                    row = dsUM.Tables("UM").Rows(0)
                    row.Item("Last_update_date") = getTanggal()
                    row.Item("Last_updated_by") = username
                End If

                row.Item("tanggal") = dttgl_inv.EditValue
                row.Item("kartu") = Lookkaryawan.EditValue
                row.Item("keterangan") = txtketerangan.EditValue
                row.Item("jml_val_trans") = txtjml_val_trans.EditValue
                row.Item("jml_rp_trans") = txtjml_val_trans.EditValue * txtkurs_valuta.EditValue
                row.Item("jml_tagihan") = txtjml_val_trans.EditValue * txtkurs_valuta.EditValue
                row.Item("jml_bayar") = 0
                row.Item("kd_valuta") = Lookvaluta.EditValue
                row.Item("kurs_valuta") = txtkurs_valuta.EditValue
                row.Item("kd_buku_besar") = "2013005"
                row.Item("jns_byr") = lookupJenis.EditValue
                If lookupJenis.EditValue = "01" Or lookupJenis.EditValue = "02" Then
                    row.Item("tipe_trans") = "JKM-KPT-05"
                    row.Item("no_ref_giro") = lookupGiro.EditValue
                    'row.Item("no_jurnal") = noJurnal
                Else
                    row.Item("tipe_trans") = "JKM-KPT-04"
                    row.Item("no_ref_giro") = IIf(lookBank.EditValue = vbNullString, "NONE", lookBank.EditValue)
                End If

                If State = "ADD" Then
                    dsUM.Tables("UM").Rows.Add(row)
                End If
            Else
                MsgBox("Ada kesalahan dalam mengisi data : " & vbCrLf & err, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                err = ""
            End If
        End If

        Try
            mb = New SqlClient.SqlCommandBuilder(daUM)
            daUM.UpdateCommand = mb.GetUpdateCommand()
            daUM.InsertCommand = mb.GetInsertCommand()
            daUM.DeleteCommand = mb.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            daUM.UpdateCommand.Transaction = BTRANS
            daUM.InsertCommand.Transaction = BTRANS
            daUM.DeleteCommand.Transaction = BTRANS

            daUM.Update(dsUM.Tables("UM"))

            If isDelete Then
                call_procedure_del(kodeCari, BTRANS)
            Else
                If lookupJenis.EditValue = "01" Or lookupJenis.EditValue = "02" Then
                    call_procedure("JKM-KPT-05", txtno_inv.EditValue, BTRANS)
                Else
                    call_procedure("JKM-KPT-04", txtno_inv.EditValue, BTRANS)
                End If
            End If

            BTRANS.Commit()
            If isDelete Then
                showMessages("Data Telah Dihapus.")
                cancel_click()
            Else
                showMessages("Data Telah Disimpan.")
                bersihkan()
            End If
            'cetak_click()
            loadData("XXX")
            isiGrid()
            loadLookUp()
            State = "ADD"
        Catch ex As Exception
            BTRANS.Rollback()
            dsUM.Tables("UM").RejectChanges()
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            For Each rw As DataRow In dsUM.Tables("UM").Rows
                rw.Delete()
            Next
            save_click(True)
        End If
    End Sub

    Public Sub cancel_click()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        isiGrid()
        bersihkan()
        loadData("XXX")
    End Sub

    Private Sub loadLookUp()
        loadCustomer()
        loadJenis()
        loadGiro()
        loadValuta()
        loadBank()
    End Sub

    Public Sub cetak_click()
        If Not txtno_inv.EditValue = vbNullString Then
            If MsgBox("Cetak Bukti ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "CETAK?") = MsgBoxResult.Yes Then
                callReport(App_Path() & "\report\repNotaDO.rpt", "", "nomor=" & txtno_inv.EditValue, False)
            End If
        Else
            MsgBox("Belum ada nomor yang disimpan.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
        End If
    End Sub

    Private Sub loadCustomer()
        If Not dsLookUp.Tables("Customer") Is Nothing Then dsLookUp.Tables("Customer").Clear()

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT Kd_Customer as kode, Nama_customer as nama, Alamat1 FROM SIF.dbo.SIF_Customer WHERE Rec_stat = 'Y' ORDER BY Nama_Customer", sqlconn))
        daLookUp.Fill(dsLookUp, "Customer")
        Lookkaryawan.Properties.DataSource = dsLookUp.Tables("Customer")
        Lookkaryawan.Properties.ValueMember = "kode"
        Lookkaryawan.Properties.DisplayMember = "nama"
        lookupNama.DataSource = dsLookUp.Tables("Customer")
        lookupNama.ValueMember = "kode"
        lookupNama.DisplayMember = "nama"
    End Sub

    Private Sub loadJenis()
        If Not dsLookUp.Tables("Jenis") Is Nothing Then dsLookUp.Tables("Jenis").Clear()

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Id_Data, Desc_Data from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='JNSBYR'", sqlconn))
        daLookUp.Fill(dsLookUp, "Jenis")
        lookupJenis.Properties.DataSource = dsLookUp.Tables("Jenis")
        lookupJenis.Properties.ValueMember = "Id_Data"
        lookupJenis.Properties.DisplayMember = "Desc_Data"
    End Sub

    Private Sub loadValuta()
        If Not dsLookUp.Tables("Valuta") Is Nothing Then dsLookUp.Tables("Valuta").Clear()

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Valuta, Nama_Valuta from SIF.dbo.sif_valuta", sqlconn))
        daLookUp.Fill(dsLookUp, "Valuta")
        Lookvaluta.Properties.DataSource = dsLookUp.Tables("Valuta")
        Lookvaluta.Properties.ValueMember = "Kode_Valuta"
        Lookvaluta.Properties.DisplayMember = "Nama_Valuta"
    End Sub

    Private Sub loadBank()
        If Not dsLookUp.Tables("Bank") Is Nothing Then dsLookUp.Tables("Bank").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("select kd_bank, nama_bank, Kd_Bk_Besar from SIF.dbo.SIF_Bank", sqlconn))
        daLookUp.Fill(dsLookUp, "Bank")
        lookBank.Properties.DataSource = dsLookUp.Tables("Bank")
        lookBank.Properties.ValueMember = "kd_bank"
        lookBank.Properties.DisplayMember = "nama_bank"
    End Sub

    Private Sub loadGiro()
        If Not dsLookUp.Tables("Giro") Is Nothing Then dsLookUp.Tables("Giro").Clear()

        daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.idrec, a.nomor, b.nama, a.jml_trans from FIN.dbo.FIN_GIRO a, FIN.dbo.v_kartu b where a.kartu=b.kode and a.tipe_trans = 'JRR-KPT-13' and a.status like 'CLEARING' and a.kartu='" & Lookkaryawan.EditValue & "' AND NOT (a.no_jur IS NULL OR a.no_jur = '')", sqlconn))
        daLookUp.Fill(dsLookUp, "Giro")
        lookupGiro.Properties.DataSource = dsLookUp.Tables("Giro")
        lookupGiro.Properties.ValueMember = "idrec"
        lookupGiro.Properties.DisplayMember = "nomor"
    End Sub

    Private Sub controlOff(ByVal stat As Boolean)
        txtno_inv.Properties.ReadOnly = stat
        txtjml_val_trans.Properties.ReadOnly = stat
        Lookkaryawan.Properties.ReadOnly = stat
        txtketerangan.Properties.ReadOnly = stat
        lookupJenis.Properties.ReadOnly = stat
        txtkurs_valuta.Properties.ReadOnly = stat
        Lookvaluta.Properties.ReadOnly = stat
        GV.OptionsBehavior.ReadOnly = stat
    End Sub

    Private Sub GV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV.DoubleClick
        Dim viewGiro As ColumnView = GV
        State = "EDIT"

        loadData(viewGiro.GetFocusedRowCellValue("nomor").ToString)

        txtno_inv.EditValue = dsUM.Tables("UM").Rows(0).Item("nomor")
        dttgl_inv.EditValue = dsUM.Tables("UM").Rows(0).Item("tanggal")
        txtjml_val_trans.EditValue = dsUM.Tables("UM").Rows(0).Item("jml_val_trans")
        Lookkaryawan.EditValue = dsUM.Tables("UM").Rows(0).Item("kartu")
        txtketerangan.EditValue = dsUM.Tables("UM").Rows(0).Item("keterangan")
        lookupJenis.EditValue = dsUM.Tables("UM").Rows(0).Item("jns_byr")
        txtkurs_valuta.EditValue = dsUM.Tables("UM").Rows(0).Item("kurs_valuta")
        Lookvaluta.EditValue = dsUM.Tables("UM").Rows(0).Item("kd_valuta")
        kodeCari = dsUM.Tables("UM").Rows(0).Item("no_jurnal")
        If dsUM.Tables("UM").Rows(0).Item("jns_byr") = "04" Then
            lookBank.EditValue = dsUM.Tables("UM").Rows(0).Item("no_ref_giro")
            txtjml_val_trans.Enabled = False
        ElseIf dsUM.Tables("UM").Rows(0).Item("jns_byr") = "02" Or dsUM.Tables("UM").Rows(0).Item("jns_byr") = "01" Then
            lookupGiro.EditValue = dsUM.Tables("UM").Rows(0).Item("no_ref_giro")
            txtjml_val_trans.Enabled = False
        Else
            txtjml_val_trans.Enabled = True
        End If

        drUM = New SqlCommand("SELECT no_posting FROM FIN.dbo.FIN_JURNAL WHERE no_jur = '" & dsUM.Tables("UM").Rows(0).Item("no_jurnal").ToString & "'", sqlconn).ExecuteReader
        While drUM.Read()
            If Not (TypeOf drUM.Item("no_posting") Is DBNull Or drUM.Item("no_posting") Is Nothing) Then
                MsgBox("Uang Muka sudah diposting, tidak dapat diubah.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PEMBERITAHUAN!")
                controlOff(True)
                btnSave = False
                btnDelete = False
                btnCancel = True
                setStatus()
            Else
                btnSave = True
                btnDelete = True
                btnCancel = True
                setStatus()
            End If
        End While
        drUM.Close()
    End Sub

    Private Sub Lookvaluta_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lookvaluta.EditValueChanged
        If Lookvaluta.EditValue = "IDR" Then
            txtkurs_valuta.EditValue = 1
            txtkurs_valuta.Enabled = False
        Else
            txtkurs_valuta.Enabled = True
        End If
    End Sub

    Public Sub call_procedure(ByVal tipeT As String, ByVal noG As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_AUTOMAN_JURNAL"

        sqlCmd.Parameters.Add("@tipe_trans", SqlDbType.Char).Value = tipeT
        sqlCmd.Parameters.Add("@no_inv", SqlDbType.Char).Value = noG
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub call_procedure_del(ByVal no As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_DELJUR_GIRO"

        sqlCmd.Parameters.Add("@nogiro", SqlDbType.Char).Value = no
        sqlCmd.Parameters.Add("@tipe", SqlDbType.Char).Value = "X"
        sqlCmd.ExecuteNonQuery()
    End Sub

    Private Sub lookupGiro_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lookupGiro.EditValueChanged
        If Not lookupGiro.EditValue = vbNullString Then
            If Not Lookkaryawan.EditValue = vbNullString Then
                lookupGiro.Enabled = True
                txtjml_val_trans.EditValue = dsLookUp.Tables("Giro").Select("idrec='" & lookupGiro.EditValue & "'")(0).Item("jml_trans")
                txtjml_val_trans.Enabled = False
                'noJurnal = ds5.Tables("giropilih").Rows(0).Item("no_jur")
            Else
                lookupGiro.Enabled = False
                txtjml_val_trans.Enabled = True
            End If

        End If
    End Sub

    Private Sub lookupGiro_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lookupGiro.QueryPopUp
        loadGiro()
    End Sub

    Private Sub lookupJenis_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookupJenis.EditValueChanged
        If lookupJenis.EditValue = "01" Or lookupJenis.EditValue = "02" Then
            pnlGiro.Visible = True
            If Lookkaryawan.EditValue = vbNullString Then
                lookupGiro.Enabled = False
            Else
                lookupGiro.Enabled = True
            End If
        ElseIf lookupJenis.EditValue = "04" Then
            pnlBank.Visible = True
        Else
            pnlGiro.Visible = False
            pnlBank.Visible = False
            txtjml_val_trans.Enabled = True
        End If
    End Sub

    Private Sub cek()
        If Lookkaryawan.EditValue = vbNullString Then
            isOK = False
            err &= "Kartu harus dipilih." & vbCrLf
            If lookupJenis.EditValue = "01" Or lookupJenis.EditValue = "02" Then
                If lookupGiro.EditValue = vbNullString Then
                    err &= "Giro harus dipilih." & vbCrLf
                End If
            End If
            If txtjml_val_trans.EditValue = vbNullString Then
                err &= "Jumlah tidak boleh kosong." & vbCrLf
            End If
        ElseIf lookupJenis.EditValue = "01" Or lookupJenis.EditValue = "02" Then
            If lookupGiro.EditValue = vbNullString Then
                isOK = False
                err &= "Giro harus dipilih." & vbCrLf
            End If
            If Lookkaryawan.EditValue = vbNullString Then
                err &= "Kartu harus dipilih." & vbCrLf
            End If
            If txtjml_val_trans.EditValue = vbNullString Then
                err &= "Jumlah tidak boleh kosong." & vbCrLf
            End If
        ElseIf txtjml_val_trans.EditValue = vbNullString Then
            isOK = False
            err &= "Jumlah tidak boleh kosong." & vbCrLf
            If lookupJenis.EditValue = "01" Or lookupJenis.EditValue = "02" Then
                If lookupGiro.EditValue = vbNullString Then
                    err &= "Giro harus dipilih." & vbCrLf
                End If
            End If
            If Lookkaryawan.EditValue = vbNullString Then
                err &= "Kartu harus dipilih." & vbCrLf
            End If
        Else
            isOK = True
        End If
    End Sub

    Private Sub dttgl_inv_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dttgl_inv.EditValueChanged
        If dttgl_inv.EditValue = vbNullString Then
            dttgl_inv.EditValue = getTanggal()
        End If
    End Sub

    'Private Sub txtkurs_valuta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkurs_valuta.EditValueChanged
    '    If txtkurs_valuta.EditValue = 0 Or txtkurs_valuta.EditValue = vbNullString Then
    '        txtkurs_valuta.EditValue = 1
    '    Else
    '        txtjml_val_trans.EditValue = txtkurs_valuta.EditValue * GV.GetFocusedRowCellValue("jml_tagihan")
    '    End If
    'End Sub

    Private Sub Lookkaryawan_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lookkaryawan.EditValueChanged
        loadGiro()
    End Sub

    Private Sub btnGiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGiro.Click
        call_form_manual("formTerimaGiroPiut")
    End Sub

    Private Sub Lookkaryawan_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Lookkaryawan.QueryPopUp
        loadCustomer()
    End Sub

    Private Sub lookBank_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lookBank.QueryPopUp
        loadBank()
    End Sub
End Class