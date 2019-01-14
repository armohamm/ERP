'tgl 19/06/2015
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Public Class aFormUMHutang
    Public btnSave As Boolean = True
    Public btnAdd As Boolean = False
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Dim dsUM, dsLookUp As New DataSet
    Dim daUM, daLookUp As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
    Dim prn As frmMain
    Public STATE As String
    Public kode, kodeCari As String
    Dim err, noJurnal, x As String
    Dim BTRANS As SqlTransaction
    Dim isOK As Boolean = True
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
        Me.Enabled = True
        'State = "ADD"
        STATE = "ADD"
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        loadKartu()
        loadJenisBayar()
        loadValuta()
        loadBank()

        isiGrid()
        loadData("XXX")

        dttgl_inv.EditValue = getTanggal()
        lookupJenis.EditValue = "03"
        Lookvaluta.EditValue = "IDR"
    End Sub

    Public Sub bersih()
        'If Not ds1.Tables("Db_data1") Is Nothing Then ds1.Tables("Db_data1").Clear()
        txtno_inv.EditValue = vbNullString
        txtjml_val_trans.EditValue = 0
        Lookkaryawan.EditValue = vbNullString
        txtketerangan.EditValue = vbNullString
        lookupJenis.EditValue = "03"
        txtkurs_valuta.EditValue = 1
        Lookvaluta.EditValue = "IDR"
        lookupPO.EditValue = vbNullString
        lookBank.EditValue = vbNullString
        lookupGiro.EditValue = vbNullString
    End Sub

    Public Sub isiGrid()
        If Not dsUM.Tables("VUMH") Is Nothing Then dsUM.Tables("VUMH").Clear()
        daUM = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_UM where tipe_trans IN ('JKK-KUT-02','JKK-KUT-06') ORDER BY tanggal DESC", sqlconn)) 'nomor,tanggal,kartu,jml_val_trans,keterangan from FIN.dbo.FIN_UM", sqlconn))
        daUM.Fill(dsUM, "VUMH")
        GC.DataSource = dsUM.Tables("VUMH")
        GV.BestFitColumns()
    End Sub

    Public Sub loadData(ByVal kodex As String)
        If Not dsUM.Tables("UMH") Is Nothing Then dsUM.Tables("UMH").Clear()
        daUM = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_UM where nomor = '" & kodex & "'", sqlconn)) 'nomor,tanggal,kartu,jml_val_trans,keterangan from FIN.dbo.FIN_UM", sqlconn))
        daUM.Fill(dsUM, "UMH")
    End Sub

    Public Sub save_click(Optional ByVal isDelete As Boolean = False)
        If Not isDelete Then
            cek()
            If isOK = True Then
                If STATE = "ADD" Then
                    txtno_inv.EditValue = getNoTrans("DO", Now, BTRANS)
                    row = dsUM.Tables("UMH").NewRow
                    row.Item("nomor") = txtno_inv.EditValue
                    row.Item("Kd_cabang") = getKodeCabang()
                    row.Item("Last_create_date") = Now
                    row.Item("Last_created_by") = username
                    row.Item("Program_name") = Me.Name
                ElseIf STATE = "EDIT" Then
                    row = dsUM.Tables("UMH").Rows(0)
                    row.Item("Last_update_date") = getTanggal()
                    row.Item("Last_updated_by") = username
                End If

                row.Item("tanggal") = dttgl_inv.EditValue
                row.Item("kartu") = Lookkaryawan.EditValue
                row.Item("no_ref1") = lookupPO.EditValue
                row.Item("keterangan") = txtketerangan.EditValue
                row.Item("jml_val_trans") = txtjml_val_trans.EditValue
                row.Item("jml_rp_trans") = txtjml_val_trans.EditValue * txtkurs_valuta.EditValue
                row.Item("jml_tagihan") = txtjml_val_trans.EditValue * txtkurs_valuta.EditValue
                row.Item("jml_bayar") = 0
                row.Item("jml_akhir") = 0
                row.Item("kd_valuta") = Lookvaluta.EditValue
                row.Item("kurs_valuta") = txtkurs_valuta.EditValue
                row.Item("kd_buku_besar") = IIf(lookupJenis.EditValue = "04", x, "2013005")
                row.Item("jns_byr") = lookupJenis.EditValue

                If lookupJenis.EditValue = "01" Or lookupJenis.EditValue = "02" Then
                    row.Item("tipe_trans") = "JKK-KUT-06"
                    row.Item("no_ref_giro") = lookupGiro.EditValue
                    'row.Item("no_jurnal") = noJurnal
                Else
                    row.Item("tipe_trans") = "JKK-KUT-02"
                    row.Item("no_ref_giro") = IIf(lookBank.EditValue = vbNullString, "NONE", lookBank.EditValue)
                End If

                If STATE = "ADD" Then
                    dsUM.Tables("UMH").Rows.Add(row)
                End If
            Else
                MsgBox("Ada kesalahan dalam mengisi data : " & vbCrLf & err, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                err = ""
                Exit Sub
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

            daUM.Update(dsUM.Tables("UMH"))

            dsUM.Tables("UMH").AcceptChanges()

            If isDelete Then
                call_procedure_del(kodeCari, BTRANS)
            Else
                If lookupJenis.EditValue = "01" Or lookupJenis.EditValue = "02" Then
                    call_procedure("JKK-KUT-06", txtno_inv.EditValue, BTRANS)
                Else
                    call_procedure("JKK-KUT-02", txtno_inv.EditValue, BTRANS)
                End If
            End If

            BTRANS.Commit()
            If isDelete Then
                showMessages("Data Telah Dihapus")
                cancel_click()
            Else
                showMessages("Data Telah Disimpan")
                bersih()
            End If
            'cetak_click()
            loadData("XXX")
            isiGrid()
            If STATE = "EDIT" Then
                STATE = "ADD"
            End If
        Catch ex As Exception
            BTRANS.Rollback()
            dsUM.Tables("UMH").RejectChanges()
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            For Each rw As DataRow In dsUM.Tables("UMH").Rows
                rw.Delete()
            Next
            save_click(True)
        End If
    End Sub

    Public Sub cancel_click()
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnAdd = False
        setStatus()
        Me.Enabled = False
        bersih()
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        isiGrid()
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

    Private Sub loadKartu()
        If Not dsLookUp.Tables("Supplier") Is Nothing Then dsLookUp.Tables("Supplier").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("select Kode_Supplier, Nama_Supplier from SIF.dbo.SIF_Supplier where Rec_Stat = 'Y' order by Nama_Supplier", sqlconn)) '<- query buat ditampilkan di LOV
        daLookUp.Fill(dsLookUp, "Supplier")
        Lookkaryawan.Properties.DataSource = dsLookUp.Tables("Supplier")
        Lookkaryawan.Properties.DisplayMember = "Nama_Supplier"
        Lookkaryawan.Properties.ValueMember = "Kode_Supplier"
        lookupNama.DataSource = dsLookUp.Tables("Supplier")
        lookupNama.DisplayMember = "Nama_Supplier"
        lookupNama.ValueMember = "Kode_Supplier"
    End Sub

    Private Sub loadJenisBayar()
        If Not dsLookUp.Tables("Jenis") Is Nothing Then dsLookUp.Tables("Jenis").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("select Desc_Data, Id_Data from sif.dbo.SIF_gen_reff_d where id_ref_data='JNSBYR'", sqlconn))
        daLookUp.Fill(dsLookUp, "Jenis")
        lookupJenis.Properties.DataSource = dsLookUp.Tables("Jenis")
        lookupJenis.Properties.DisplayMember = "Desc_Data"
        lookupJenis.Properties.ValueMember = "Id_Data"
    End Sub

    Private Sub loadValuta()
        If Not dsLookUp.Tables("Valuta") Is Nothing Then dsLookUp.Tables("Valuta").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("select Kode_Valuta, Nama_Valuta from SIF.dbo.SIF_Valuta", sqlconn)) '<- query buat ditampilkan di LOV
        daLookUp.Fill(dsLookUp, "Valuta")
        Lookvaluta.Properties.DataSource = dsLookUp.Tables("Valuta")
        lookValuta.Properties.DisplayMember = "Nama_Valuta"
        lookValuta.Properties.ValueMember = "Kode_Valuta"
    End Sub

    Private Sub loadGiro()
        If Not dsLookUp.Tables("Giro") Is Nothing Then dsLookUp.Tables("Giro").Clear()

        If STATE = "ADD" Then
            lookupGiro.Enabled = True
            daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.idrec, a.nomor, a.keterangan, a.tgl_jth_tempo, a.jml_trans, b.Nama_Valuta, a.kurs_valuta from FIN.dbo.FIN_GIRO a, SIF.dbo.SIF_Valuta b where a.kd_valuta = b.Kode_Valuta AND a.kd_valuta = '" & Lookvaluta.EditValue & "' AND a.kartu='" & Lookkaryawan.EditValue & "' and a.jns_giro='" & lookupJenis.EditValue & "' and a.jns_trans='BELI' and a.tipe_trans='JRR-KUT-03' and a.status LIKE 'KELUAR%' and a.idrec not in (select distinct isnull(no_ref_giro,'kosong') from FIN.dbo.FIN_UM) AND NOT (a.no_jur IS NULL OR a.no_jur = '') ORDER BY a.nomor", sqlconn))
        Else
            lookupGiro.Enabled = True
            daLookUp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.idrec, a.nomor, a.keterangan, a.tgl_jth_tempo, a.jml_trans, b.Nama_Valuta, a.kurs_valuta from FIN.dbo.FIN_GIRO a, SIF.dbo.SIF_Valuta b where a.kd_valuta = b.Kode_Valuta AND a.kd_valuta = '" & Lookvaluta.EditValue & "' AND a.kartu='" & Lookkaryawan.EditValue & "' and a.jns_giro='" & lookupJenis.EditValue & "' and a.jns_trans='BELI' and a.tipe_trans='JRR-KUT-03' and a.status LIKE 'KELUAR%'", sqlconn))
        End If

        daLookUp.Fill(dsLookUp, "Giro")
        lookupGiro.Properties.DataSource = dsLookUp.Tables("Giro")
        lookupGiro.Properties.DisplayMember = "nomor"
        lookupGiro.Properties.ValueMember = "idrec"
    End Sub

    Private Sub loadBank()
        If Not dsLookUp.Tables("Bank") Is Nothing Then dsLookUp.Tables("Bank").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("select kd_bank, nama_bank, Kd_Bk_Besar from SIF.dbo.SIF_Bank", sqlconn))
        daLookUp.Fill(dsLookUp, "Bank")
        lookBank.Properties.DataSource = dsLookUp.Tables("Bank")
        lookBank.Properties.ValueMember = "kd_bank"
        lookBank.Properties.DisplayMember = "nama_bank"
    End Sub

    Private Sub loadInv()
        If Not dsLookUp.Tables("Invoice") Is Nothing Then dsLookUp.Tables("Invoice").Clear()

        If STATE = "ADD" Then
            daLookUp = New SqlDataAdapter(New SqlCommand("SELECT no_po, tgl_po, no_pr AS no_ref1, jml_val_trans FROM PURC.dbo.PURC_PO WHERE rec_stat = 'APPROVE' AND tipe_trans ='JPP-KUT-01' AND kd_supplier = '" & Lookkaryawan.EditValue & "' AND kd_valuta = '" & Lookvaluta.EditValue & "' AND NOT no_po IN (SELECT no_ref FROM INV.dbo.INV_QC_M)", sqlconn))
        Else
            daLookUp = New SqlDataAdapter(New SqlCommand("SELECT no_po, tgl_po, no_pr AS no_ref1, jml_val_trans FROM PURC.dbo.PURC_PO WHERE rec_stat = 'APPROVE' AND tipe_trans ='JPP-KUT-01' AND kd_supplier = '" & Lookkaryawan.EditValue & "' AND kd_valuta = '" & Lookvaluta.EditValue & "'", sqlconn))
        End If

        daLookUp.Fill(dsLookUp, "Invoice")
        lookupPO.Properties.DataSource = dsLookUp.Tables("Invoice")
        lookupPO.Properties.DisplayMember = "no_po"
        lookupPO.Properties.ValueMember = "no_po"
    End Sub

    Private Sub controlOff(ByVal stat As Boolean)
        txtno_inv.Properties.ReadOnly = stat
        txtjml_val_trans.Properties.ReadOnly = stat
        Lookkaryawan.Properties.ReadOnly = stat
        txtketerangan.Properties.ReadOnly = stat
        lookupJenis.Properties.ReadOnly = stat
        txtkurs_valuta.Properties.ReadOnly = stat
        Lookvaluta.Properties.ReadOnly = stat
        lookupPO.Properties.ReadOnly = stat
        lookupGiro.Properties.ReadOnly = stat
        lookBank.Properties.ReadOnly = stat
        GV.OptionsBehavior.ReadOnly = stat
    End Sub

    Private Sub GV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV.DoubleClick
        Dim viewGiro As ColumnView = GV
        STATE = "EDIT"

        loadData(viewGiro.GetFocusedRowCellValue("nomor").ToString)

        txtno_inv.EditValue = dsUM.Tables("UMH").Rows(0).Item("nomor")
        dttgl_inv.EditValue = dsUM.Tables("UMH").Rows(0).Item("tanggal")
        txtjml_val_trans.EditValue = dsUM.Tables("UMH").Rows(0).Item("jml_val_trans")
        Lookkaryawan.EditValue = dsUM.Tables("UMH").Rows(0).Item("kartu")
        txtketerangan.EditValue = dsUM.Tables("UMH").Rows(0).Item("keterangan")
        lookupJenis.EditValue = dsUM.Tables("UMH").Rows(0).Item("jns_byr")
        txtkurs_valuta.EditValue = dsUM.Tables("UMH").Rows(0).Item("kurs_valuta")
        Lookvaluta.EditValue = dsUM.Tables("UMH").Rows(0).Item("kd_valuta")
        lookupPO.EditValue = dsUM.Tables("UMH").Rows(0).Item("no_ref1")
        kodeCari = dsUM.Tables("UMH").Rows(0).Item("no_jurnal")
        If dsUM.Tables("UM").Rows(0).Item("jns_byr") = "04" Then
            lookBank.EditValue = dsUM.Tables("UM").Rows(0).Item("no_ref_giro")
            txtjml_val_trans.Enabled = False
        ElseIf dsUM.Tables("UM").Rows(0).Item("jns_byr") = "02" Or dsUM.Tables("UM").Rows(0).Item("jns_byr") = "01" Then
            lookupGiro.EditValue = dsUM.Tables("UM").Rows(0).Item("no_ref_giro")
            txtjml_val_trans.Enabled = False
        Else
            txtjml_val_trans.Enabled = True
        End If

        drUM = New SqlCommand("SELECT no_posting FROM FIN.dbo.FIN_JURNAL WHERE no_jur = '" & viewGiro.GetFocusedRowCellValue("no_jurnal").ToString & "'", sqlconn).ExecuteReader
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
            txtkurs_valuta.Text = 1
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
            If lookupPO.EditValue = vbNullString Then
                err &= "No. PO tidak boleh kosong." & vbCrLf
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
            If lookupPO.EditValue = vbNullString Then
                err &= "No. PO tidak boleh kosong." & vbCrLf
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
            If lookupPO.EditValue = vbNullString Then
                err &= "No. PO tidak boleh kosong." & vbCrLf
            End If
        ElseIf lookupPO.EditValue = vbNullString Then
            isOK = False
            err &= "No. PO tidak boleh kosong." & vbCrLf
            If Lookkaryawan.EditValue = vbNullString Then
                err &= "Kartu harus dipilih." & vbCrLf
            End If
            If lookupJenis.EditValue = "01" Or lookupJenis.EditValue = "02" Then
                If lookupGiro.EditValue = vbNullString Then
                    err &= "Giro harus dipilih." & vbCrLf
                End If
            End If
            If txtjml_val_trans.EditValue = vbNullString Then
                err &= "Jumlah tidak boleh kosong." & vbCrLf
            End If
        Else
            isOK = True
            err = ""
        End If
    End Sub

    Private Sub dttgl_inv_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dttgl_inv.EditValueChanged
        If dttgl_inv.EditValue = vbNullString Then
            dttgl_inv.EditValue = getTanggal()
        End If
    End Sub

    Private Sub Lookkaryawan_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lookkaryawan.EditValueChanged
        loadGiro()
        loadInv()
    End Sub

    Private Sub btnGiro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGiro.Click
        call_form_manual("frmPengeluaranGiro")
    End Sub

    Private Sub lookupPO_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lookupPO.QueryPopUp
        loadInv()
    End Sub

    Private Sub Lookvaluta_EditValueChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles Lookvaluta.EditValueChanged
        loadInv()
        loadGiro()
    End Sub

    Private Sub Lookkaryawan_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Lookkaryawan.QueryPopUp
        loadKartu()
    End Sub

    Private Sub lookBank_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lookBank.EditValueChanged
        If Not lookBank.EditValue = vbNullString Then
            x = dsLookUp.Tables("Bank").Select("kd_bank=" & lookBank.EditValue)(0).Item("Kd_Bk_Besar").ToString
        End If
    End Sub

    Private Sub lookBank_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lookBank.QueryPopUp
        loadBank()
    End Sub
End Class