Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Public Class frmPLNSKasBon

    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain
    Public obj As Object
    Dim xDS, dsNoKasBon, dsBukuBesar, dsBukuPusat, dsSupp, dsTemp, dsLunasKasBon, dsLunasKasBonD As New DataSet
    Dim xDA, daNoKasBon, daBukuBesar, daBukuPusat, daSupp, daTemp, daLunasKasBon, daLunasKasBonD, daNomorKB As SqlClient.SqlDataAdapter

    Dim kode, tampung, cabang As String
    Dim jml_akhir As Integer
    Dim Tipetrans As String
    Dim TipetransD As String
    Dim namaKartu, kartu As String

    Public STATE, no As String
    Dim row As DataRow

    Dim myBuilder, myBuilderD As New SqlCommandBuilder
    Dim BTRANS As SqlTransaction
    Dim dr As SqlDataReader
    Dim param, ParamGenKode As String

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
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
        controlOff(False)
    End Sub

    Sub LoadDataGrid(ByVal kode As String)
        If Not dsLunasKasBon.Tables("lunas_kasbon") Is Nothing Then dsLunasKasBon.Tables("lunas_kasbon").Clear()
        If Not dsLunasKasBonD.Tables("lunas_kasbon_d") Is Nothing Then dsLunasKasBonD.Tables("lunas_kasbon_d").Clear()
        daLunasKasBonD = New SqlDataAdapter(New SqlCommand("select * from KOPKAR.dbo.FIN_LUNAS_KAS_BON_D where nomor = '" & kode & "'", sqlconn))
        daLunasKasBonD.Fill(dsLunasKasBonD, "lunas_kasbon_d")
        GC.DataSource = dsLunasKasBonD.Tables("lunas_kasbon_d")
        GV.BestFitColumns()

        daLunasKasBon = New SqlDataAdapter(New SqlCommand("select * from KOPKAR.dbo.FIN_LUNAS_KAS_BON where nomor = '" & kode & "'", sqlconn))
        daLunasKasBon.Fill(dsLunasKasBon, "lunas_kasbon")


        If STATE = "EDIT" Then
            dr = New SqlCommand("SELECT a.kd_kartu FROM KOPKAR.dbo.FIN_KAS_BON a, KOPKAR.dbo.FIN_LUNAS_KAS_BON b WHERE b.prev_nomor=a.nomor AND b.nomor = '" & dsLunasKasBon.Tables("lunas_kasbon")(0).Item("nomor").ToString & "'", sqlconn).ExecuteReader
            dr.Read()
            kartu = dr.Item(0)
            dr.Close()
        End If

        If dsLunasKasBon.Tables("lunas_kasbon").Rows.Count > 0 Then
            With dsLunasKasBon.Tables("lunas_kasbon")(0)
                txtNoTrans.EditValue = .Item("nomor")
                Tanggal.EditValue = .Item("tgl_trans")
                LOVKartu.EditValue = kartu
                LOVNoKasBon.EditValue = .Item("prev_nomor")
                txtKeterangan.EditValue = .Item("keterangan")
                'IIf(.Item("sts_hutang") = "Y", chkHutang.Checked = True, chkHutang.Checked = False)
                If .Item("sts_hutang") = "Y" Then
                    chkHutang.Checked = True
                Else
                    chkHutang.Checked = False
                End If
                txtSelisih.EditValue = .Item("sisa_hutang")
            End With
        End If
    End Sub

    Private Sub bersih()
        txtNoTrans.EditValue = vbNullString
        'Tanggal.EditValue = getTanggal()
        LOVNoKasBon.EditValue = vbNullString
        txtKeterangan.EditValue = vbNullString
        LOVKartu.EditValue = vbNullString
        chkHutang.Checked = False
        txtSelisih.EditValue = vbNullString
        txtJmlAkhir.EditValue = vbNullString
    End Sub

    Sub GenLOV()

        dsNoKasBon.Clear()

        'daNoKasBon = New SqlDataAdapter(New SqlCommand("select kd_kartu ,nomor,nama from FIN.dbo.FIN_KAS_BON A, FIN.dbo.v_kartu B where A.kd_kartu = B.kode ", sqlconn))

            
        If STATE = "EDIT" Then
            daNoKasBon = New SqlDataAdapter(New SqlCommand("select A.kd_kartu ,A.nomor,B.nama,A.jml_trans ,A.jml_akhir  " & _
          "  from KOPKAR.dbo.FIN_KAS_BON A, KOPKAR.dbo.v_kartu B" & _
          "  where A.kd_kartu = B.kode " & _
          "  and A.nomor='" & no & "'", sqlconn))
        Else
            daNoKasBon = New SqlDataAdapter(New SqlCommand("select A.kd_kartu ,A.nomor,B.nama,A.jml_trans ,A.jml_akhir  " & _
            "  from KOPKAR.dbo.FIN_KAS_BON A, KOPKAR.dbo.v_kartu B" & _
            "  where A.kd_kartu = B.kode " & _
            "  and A.jml_akhir > 0" & _
            "  and a.nomor not in (select c.prev_nomor from KOPKAR.dbo.FIN_LUNAS_KAS_BON c) " & _
            "  and A.kd_kartu = '" & LOVKartu.EditValue & "'", sqlconn))
        End If

        daNoKasBon.Fill(dsNoKasBon, "NoKasBon")
        LOVNoKasBon.Properties.DataSource = dsNoKasBon.Tables("NoKasBon")
        LOVNoKasBon.Properties.DisplayMember = "nomor"
        LOVNoKasBon.Properties.ValueMember = "nomor"

        daNomorKB = New SqlDataAdapter(New SqlCommand("select * from KOPKAR.dbo.FIN_LUNAS_KAS_BON ", sqlconn))
        daNomorKB.Fill(dsNoKasBon, "NomorKB")
        LOVnomorKB.Properties.DataSource = dsNoKasBon.Tables("NomorKB")
        LOVnomorKB.Properties.DisplayMember = "nomor"
        LOVnomorKB.Properties.ValueMember = "nomor"

       

    End Sub

    Sub v_kartu()
        dsSupp.Clear()

        daSupp = New SqlDataAdapter(New SqlCommand("SELECT b.kode, b.nama From KOPKAR.dbo.v_kartu b ORDER BY b.nama", sqlconn))
        daSupp.Fill(dsSupp, "kartu")
        LOVKartu.Properties.DataSource = dsSupp.Tables("kartu")
        LOVKartu.Properties.DisplayMember = "nama"
        LOVKartu.Properties.ValueMember = "kode"
    End Sub

    Sub GenLOVbuku()
        dsBukuBesar.Clear()
        'daBukuBesar = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_buku_besar ", sqlconn))
        daBukuBesar = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("  SELECT * FROM KOPKAR.dbo.m_buku_besar WHERE grup_header='D' and div1 = 'Y' and pola_entry = '" & LOV_Unit.EditValue & "'", sqlconn))
        daBukuBesar.Fill(dsBukuBesar, "rekening")
        LOVRekBiaya.DataSource = dsBukuBesar.Tables("rekening")
        LOVRekBiaya.Properties.DisplayMember = "nm_buku_besar"
        LOVRekBiaya.Properties.ValueMember = "kd_buku_besar"

        dsBukuPusat.Clear()
        daBukuPusat = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.Val_kode1 kd_buku_pusat,a.Desc_Data nm_buku_pusat from kopkar.dbo.SIF_Gen_Reff_D a where a.Id_Ref_Data = 'UNITKOPKAR'", sqlconn))
        'daBukuPusat = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from KOPKAR.dbo.SIF_buku_pusat where not kd_buku_pusat = '90000003'", sqlconn))
        daBukuPusat.Fill(dsBukuPusat, "pusat")
        'LOVPusBiaya.DataSource = dsBukuPusat.Tables("pusat")
        'LOVPusBiaya.Properties.DisplayMember = "nm_buku_pusat"
        'LOVPusBiaya.Properties.ValueMember = "kd_buku_pusat"
        LOV_Unit.Properties.DataSource = dsBukuPusat.Tables("pusat")
        LOV_Unit.Properties.DisplayMember = "nm_buku_pusat"
        LOV_Unit.Properties.ValueMember = "kd_buku_pusat"


    End Sub

    Private Sub frmPLNSKasBon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)

        LoadDataGrid("xxx")

        GenLOV()
        v_kartu()
        GenLOVbuku()

        Tanggal.EditValue = getTanggal()

    End Sub

    Private Sub GV_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        Dim view As ColumnView = sender

        If Not dsTemp.Tables("LoadLunasKasBon") Is Nothing Then dsTemp.Tables("LoadLunasKasBon").Clear()
        daTemp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from KOPKAR.dbo.FIN_KAS_BON where nomor ='" & LOVNoKasBon.EditValue & "'", sqlconn))
        daTemp.Fill(dsTemp, "LoadLunasKasBon")

        'If e.Column Is prev_no_inv Then

        '    view.SetRowCellValue(e.RowHandle, "jml_tagihan", "0" & dsTemp.Tables("LoadBeliLunas").Rows(0).Item("jml_tagihan").ToString)
        '    'view.SetRowCellValue(e.RowHandle, "jml_ppn", "0" & dsTemp.Tables("LoadBeliLunas").Rows(0).Item("jml_val_ppn").ToString)
        '    'view.SetRowCellValue(e.RowHandle, "jml_bayar", (dsTemp.Tables("LoadBeliLunas").Rows(0).Item("jml_tagihan") + dsTemp.Tables("LoadBeliLunas").Rows(0).Item("jml_val_ppn")))
        '    view.SetRowCellValue(e.RowHandle, "kd_buku_besar", dsTemp.Tables("LoadBeliLunas").Rows(0).Item("kd_buku_besar").ToString)

        'End If

        If e.Column Is jml_trans Then
            If Not (e.Value.ToString = vbNullString Or e.Value.ToString = "") Then
                Dim jumlah As Integer = 0
                'txtSelisih.EditValue = CInt(txtJmlAkhir.EditValue) - CInt("0" & GV.GetFocusedRowCellValue("jml_trans"))
                'txtSelisih.EditValue = CInt(txtJmlAkhir.EditValue) - CInt("0" & GV.Columns("jml_trans").SummaryText)
                For i As Integer = 0 To GV.RowCount - 1
                    jumlah += CInt(GV.GetRowCellValue(i, "jml_trans"))
                Next
                txtSelisih.EditValue = CInt(txtJmlAkhir.EditValue) - jumlah
            Else
                GV.GetRow(e.RowHandle).item("jml_trans") = 0
            End If
        End If
    End Sub

    'Private Sub GV_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GV.KeyPress
    '    If Asc(e.KeyChar) = 13 Then
    '        txtSelisih.EditValue = CInt(txtJmlAkhir.EditValue) - CInt(GV.Columns("jml_trans").SummaryText)
    '    End If
    'End Sub

    'Private Sub GV_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV.RowUpdated
    '    txtSelisih.EditValue = CInt(txtJmlAkhir.EditValue) - CInt(GV.Columns("jml_trans").SummaryText)
    'End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        'GV.GetRow(e.RowHandle).item("no_seq") = GV.RowCount + 1
        Dim View As ColumnView = sender
        View.SetRowCellValue(e.RowHandle, View.Columns("no_seq"), GV.RowCount + 1)
        View.SetRowCellValue(e.RowHandle, View.Columns("jml_trans"), 0)
        ' View.SetRowCellValue(e.RowHandle, View.Columns("pusat_biaya"), "00000000")

    End Sub

    Sub cekJmlAkhir()
        Try
            Dim dr As SqlDataReader = New SqlCommand(" select jml_akhir from KOPKAR.dbo.FIN_KAS_BON where nomor = '" & LOVNoKasBon.EditValue & "'", sqlconn).ExecuteReader

            dr.Read()
            If dr.HasRows Then
                jml_akhir = dr.Item(0)
            End If

            dr.Close()
        Catch ex As Exception
            jml_akhir = 0
            'MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub save_click(Optional ByVal isDelete As Boolean = False)
        If LOVNoKasBon.EditValue = vbNullString Or GV.RowCount <= 0 Then
            MsgBox("Tolong isi data dengan lengkap.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            Exit Sub
        End If

        If Not isDelete Then
            cekJmlAkhir()
            If jml_akhir < GV.Columns("jml_trans").SummaryText Then
                Tipetrans = "JKK"
                TipetransD = "-KBB-04"
            Else
                Tipetrans = "JKK"
                TipetransD = "-KBB-09"
            End If

            If STATE = "ADD" Then

                txtNoTrans.EditValue = getNoTrans(Tipetrans, getTanggal(), BTRANS)
                kode = txtNoTrans.EditValue
                row = dsLunasKasBon.Tables("lunas_kasbon").NewRow

                row.Item("Kd_cabang") = "1"
                row.Item("tipe_trans") = Tipetrans & TipetransD
                row.Item("nomor") = txtNoTrans.EditValue
                row.Item("sts_hutang") = IIf(chkHutang.Checked = True, "Y", "T")
                row.Item("sisa_hutang") = txtSelisih.EditValue
                row.Item("prev_nomor") = LOVNoKasBon.EditValue
                row.Item("kd_kartu") = LOVKartu.EditValue

                row.Item("tgl_trans") = Tanggal.EditValue
                row.Item("jml_trans") = GV.Columns("jml_trans").SummaryText
                row.Item("keterangan") = txtKeterangan.EditValue

                row.Item("program_name") = Me.Name
                row.Item("last_create_date") = getTanggal()
                row.Item("last_created_by") = umum.username

                dsLunasKasBon.Tables("lunas_kasbon").Rows.Add(row)

            ElseIf STATE = "EDIT" Then

                row = dsLunasKasBon.Tables("lunas_kasbon").Rows(0)

                row.Item("tgl_trans") = Tanggal.EditValue
                row.Item("jml_trans") = GV.Columns("jml_trans").SummaryText
                row.Item("keterangan") = txtKeterangan.EditValue
                row.Item("sts_hutang") = IIf(chkHutang.Checked = True, "Y", "T")
                row.Item("sisa_hutang") = txtSelisih.EditValue
                row.Item("program_name") = Me.Name
                row.Item("last_update_date") = getTanggal()
                row.Item("last_updated_by") = username
            End If
        End If

        For Each rows As DataRow In dsLunasKasBonD.Tables("lunas_kasbon_d").Rows
            If rows.RowState = DataRowState.Added Then

                rows.Item("Kd_Cabang") = "1"
                rows.Item("tipe_trans") = Tipetrans & TipetransD
                rows.Item("nomor") = txtNoTrans.EditValue
                rows.Item("prev_nomor") = LOVNoKasBon.EditValue
                rows.Item("pusat_biaya") = LOV_Unit.EditValue
                rows.Item("Programe_name") = Me.Name
                rows.Item("Last_Create_Date") = getTanggal()
                rows.Item("Last_Created_By") = umum.username
            ElseIf rows.RowState = DataRowState.Modified Then
                rows.Item("Last_Update_Date") = Now
                rows.Item("Last_Updated_By") = username
            End If
        Next

        If isDelete Then
            For Each RW As DataRow In dsLunasKasBon.Tables(0).Rows
                RW.Delete()
            Next

            For Each RW As DataRow In dsLunasKasBonD.Tables(0).Rows
                RW.Delete()
            Next
        End If

        'MsgBox(Tipetrans & TipetransD & " , " & txtNoTrans.EditValue)
        'call_procedure(Tipetrans & TipetransD, txtNoTrans.EditValue, BTRANS)
        Try
            myBuilder = New SqlCommandBuilder(daLunasKasBon)
            daLunasKasBon.UpdateCommand = myBuilder.GetUpdateCommand()
            daLunasKasBon.InsertCommand = myBuilder.GetInsertCommand()
            daLunasKasBon.DeleteCommand = myBuilder.GetDeleteCommand()

            myBuilderD = New SqlCommandBuilder(daLunasKasBonD)
            daLunasKasBonD.UpdateCommand = myBuilderD.GetUpdateCommand()
            daLunasKasBonD.InsertCommand = myBuilderD.GetInsertCommand()
            daLunasKasBonD.DeleteCommand = myBuilderD.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            daLunasKasBon.UpdateCommand.Transaction = BTRANS
            daLunasKasBon.InsertCommand.Transaction = BTRANS
            daLunasKasBon.DeleteCommand.Transaction = BTRANS

            'BTRANS = sqlconn.BeginTransaction("1")
            daLunasKasBonD.UpdateCommand.Transaction = BTRANS
            daLunasKasBonD.InsertCommand.Transaction = BTRANS
            daLunasKasBonD.DeleteCommand.Transaction = BTRANS

            daLunasKasBon.Update(dsLunasKasBon.Tables("lunas_kasbon"))
            daLunasKasBonD.Update(dsLunasKasBonD.Tables("lunas_kasbon_d"))

            'MsgBox(Tipetrans & TipetransD & " , " & txtNoTrans.EditValue)
            call_procedure(Tipetrans & TipetransD, txtNoTrans.EditValue, BTRANS)
            If STATE = "EDIT" Then
                call_procedure_edit(txtNoTrans.EditValue, BTRANS)
            End If
            'BTRANS.Commit()
            'showMessages("Data Baru Berhasil Disimpan")

            'dsLunasKasBon.Tables("lunas_kasbon").AcceptChanges()

            Try
                BTRANS.Commit()
                If isDelete Then
                    showMessages("Berhasil Dihapus.")
                    cancel_click()
                Else
                    showMessages("Data Baru Berhasil Disimpan.")
                    If STATE = "ADD" Then
                        cetak_click()
                    End If
                    GenLOV()
                    v_kartu()
                    GenLOVbuku()
                    'bersih()
                    btnDelete = False
                    setStatus()
                    'LoadDataGrid("xxx")
                    'txtNoTrans.EditValue = getNoTrans(Tipetrans, getTanggal)
                End If
            Catch ex As Exception
                BTRANS.Rollback()
                dsLunasKasBon.Tables("lunas_kasbon").RejectChanges()
                dsLunasKasBonD.Tables("lunas_kasbon_d").RejectChanges()
                MsgBox(ex.Message)
            End Try

        Catch ex As Exception
            MsgBox("Cek kembali isian data, inputan wajib jangan sampai kosong. Detail Error : " & ex.Message)
        End Try
    End Sub

    Public Sub call_procedure(ByVal noTrans As String, ByVal noInvoice As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "KOPKAR.dbo.FIN_AUTOMAN_JURNAL"

        sqlCmd.Parameters.Add("@tipe_trans", SqlDbType.Char).Value = noTrans
        sqlCmd.Parameters.Add("@no_inv", SqlDbType.Char).Value = noInvoice
        Dim dr As SqlDataReader = sqlCmd.ExecuteReader
        dr.Close()
    End Sub

    Public Sub call_procedure_edit(ByVal noInvoice As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "KOPKAR.dbo.FIN_kalkulasi_kasbon_oneone"

        sqlCmd.Parameters.Add("@vno_trans", SqlDbType.Char).Value = noInvoice
        Dim dr As SqlDataReader = sqlCmd.ExecuteReader
        dr.Close()
    End Sub

    Private Sub controlOff(ByVal stat As Boolean)
        Tanggal.Properties.ReadOnly = stat
        LOVNoKasBon.Properties.ReadOnly = stat
        LOVKartu.Properties.ReadOnly = stat
        txtKeterangan.Properties.ReadOnly = stat
        GV.OptionsBehavior.ReadOnly = stat
    End Sub

    Public Sub edit_click()
        STATE = "EDIT"
        daTemp = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.nomor as 'No. Pelunasan', c.nama as 'Nama', a.prev_nomor as 'No. Kas Bon', a.tgl_trans as 'Tanggal Transaksi', a.jml_trans as 'Jumlah' from KOPKAR.dbo.FIN_LUNAS_KAS_BON a, KOPKAR.dbo.FIN_KAS_BON b, KOPKAR.dbo.v_kartu c where a.prev_nomor = b.nomor AND b.kd_kartu = c.kode", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca

        If Not dsTemp.Tables("lookup_so") Is Nothing Then dsTemp.Tables("lookup_so").Clear()
        daTemp.Fill(dsTemp, "lookup_so")
        frmCari.set_dso(dsTemp.Tables("lookup_so")) '<-- memparsing hasil dataset ke LOV
        frmCari.GV.Columns("Tanggal Transaksi").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        frmCari.GV.Columns("Jumlah").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        frmCari.GV.Columns("Tanggal Transaksi").DisplayFormat.FormatString = "d MMMM yyyy"
        frmCari.GV.Columns("Jumlah").DisplayFormat.FormatString = "n2"
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            dr = New SqlCommand("SELECT COUNT(b.no_posting) FROM KOPKAR.dbo.FIN_LUNAS_KAS_BON a, KOPKAR.dbo.FIN_JURNAL b WHERE a.nomor=b.no_jur AND NOT (b.no_posting = '' OR b.no_posting IS NULL) AND a.nomor = '" & frmCari.row("No. Pelunasan") & "'", sqlconn).ExecuteReader
            dr.Read()
            Dim indeks As Integer = dr.Item(0)
            dr.Close()
            If indeks = 0 Then
                no = ""
                btnadd = False
                btnEdit = False
                btnDelete = True
                btnSave = True
                btnCancel = True
                setStatus()
                no = frmCari.row("No. Kas Bon")
                GenLOV()
                v_kartu()
                LoadDataGrid(frmCari.row("No. Pelunasan"))
                Me.Enabled = True
            Else
                no = ""
                MsgBox("Data sudah diposting, tidak dapat diubah.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                no = frmCari.row("No. Kas Bon")
                GenLOV()
                v_kartu()
                LoadDataGrid(frmCari.row("No. Pelunasan"))
                bersih()
                btnadd = False
                btnEdit = False
                btnDelete = False
                btnSave = False
                btnCancel = True
                setStatus()
                controlOff(True)
            End If
        Else
            STATE = ""
            cancel_click()
        End If
    End Sub

    Public Sub cancel_click()
        STATE = ""
        GenLOV()
        v_kartu()
        GenLOVbuku()

        bersih()
        LoadDataGrid("XXX")
        btnadd = True
        btnEdit = True
        btnDelete = False
        btnSave = False
        btnCancel = False
        setStatus()
        controlOff(False)
        Me.Enabled = False

    End Sub

    Public Sub delete_click()
        If MsgBox("Apakah anda ingin menghapus ?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            STATE = "DELETE"
            For Each RW As DataRow In dsLunasKasBon.Tables(0).Rows
                Dim sqlx As New SqlCommand("delete from KOPKAR.dbo.fin_jurnal where no_jur='" & RW.Item("no_jur") & "'", sqlconn)
                sqlx.ExecuteNonQuery()
            Next
            For Each RW As DataRow In dsLunasKasBonD.Tables(0).Rows
                Dim sqlx As New SqlCommand("delete from KOPKAR.dbo.fin_jurnal_d where no_jur='" & RW.Item("no_jur") & "'", sqlconn)
                sqlx.ExecuteNonQuery()
            Next

            save_click(True)
            cancel_click()
        End If
    End Sub

    Sub autoKartuNoKasbon()
        Try
            Dim dr As SqlDataReader = New SqlCommand(" select nama,kode from KOPKAR.dbo.FIN_KAS_BON A, KOPKAR.dbo.v_kartu B where A.kd_kartu = B.kode  and A.nomor = '" & LOVNoKasBon.EditValue & "' ", sqlconn).ExecuteReader

            dr.Read()
            If dr.HasRows Then
                LOVKartu.EditValue = dr.Item(1)
            End If

            dr.Close()
        Catch ex As Exception
            namaKartu = ""
            'MsgBox(ex.Message)
        End Try

        Try

            Dim dr As SqlDataReader = New SqlCommand(" select A.jml_akhir, A.kd_divisi  " & _
            "   from KOPKAR.dbo.FIN_KAS_BON A " & _
            "   where A.nomor = '" & LOVNoKasBon.EditValue & "'", sqlconn).ExecuteReader

            dr.Read()
            If dr.HasRows Then
                txtJmlAkhir.EditValue = dr.Item(0)
                LOV_Unit.EditValue = dr.Item(1)
                LOV_Unit.Properties.ReadOnly = True
            End If

            dr.Close()
        Catch ex As Exception
            namaKartu = ""
            'MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub LOVNoKasBon_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOVNoKasBon.EditValueChanged
        autoKartuNoKasbon()
    End Sub

    Public Sub cetak_click()
        If Not txtNoTrans.EditValue.ToString = "" Then
            If MsgBox("Cetak langsung?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "CETAK?") = MsgBoxResult.Yes Then
                Dim sqlx As New SqlCommand("update KOPKAR.dbo.fin_lunas_kas_bon set jml_cetak=isnull(jml_cetak,0)+1, tgl_cetak=getdate() where nomor='" & txtNoTrans.EditValue & "'", sqlconn)
                sqlx.ExecuteNonQuery()
                callReport(App_Path() & "\report\CRBuktiJKK.rpt", "", "jurnal=" & txtNoTrans.EditValue & "&nomor=" & txtNoTrans.EditValue, True)
            Else
                ' callReport(App_Path() & "\report\CRBuktiJKK.rpt", "", "jurnal=" & txtNoTrans.EditValue & "&nomor=" & txtNoTrans.EditValue, True, False, "", False)
            End If
        End If
    End Sub

    Private Sub LOVnomorKB_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOVnomorKB.EditValueChanged
        If Not LOVnomorKB.EditValue.ToString = "" Then
            callReport(App_Path() & "\report\CRBuktiJKK.rpt", "", "jurnal=" & LOVnomorKB.EditValue & "&nomor=" & LOVnomorKB.EditValue, False)
        End If
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.Checked = True Then
            LOVnomorKB.Visible = True
        Else
            LOVnomorKB.Visible = False
        End If
    End Sub

    Private Sub GV_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles GV.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub GV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV.KeyDown
        If e.KeyCode = Keys.Delete Then
            Dim x As Object
            x = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
            x.DeleteSelectedRows()
            For i = 0 To GC.FocusedView.RowCount - 1
                GC.FocusedView.GetRow(i).Item("no_seq") = i + 1
            Next
        End If
    End Sub

    Private Sub GV_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV.RowUpdated

        Dim jumlah As Integer = 0
        For i As Integer = 0 To GV.RowCount - 1
            jumlah += CInt(GV.GetRowCellValue(i, "jml_trans"))
        Next
        txtSelisih.EditValue = CInt(txtJmlAkhir.EditValue) - jumlah
    End Sub

    Private Sub LOVKartu_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOVKartu.EditValueChanged
        GenLOV()
    End Sub

    Private Sub GV_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles GV.ValidatingEditor
        Dim vx As GridView = sender
        If vx.FocusedColumn.FieldName = "pusat_biaya" Then
            If Not (GV.RowCount <= 0 Or GV.RowCount = 1) Then
                For i As Integer = 0 To GV.RowCount
                    If Not (TypeOf vx.GetRowCellValue(i, pusat_biaya) Is DBNull Or TypeOf e.Value Is DBNull Or vx.GetRowCellValue(i, pusat_biaya) Is Nothing) Then
                        If Not e.Value = vx.GetRowCellValue(i, pusat_biaya) Then
                            e.Valid = False
                            e.ErrorText = "Pusat biaya tidak sama."
                        Else
                            e.Valid = True
                        End If
                    End If
                Next
            End If
        End If

        If vx.FocusedColumn.FieldName = "jml_trans" Then
            If e.Value = 0 Then
                e.Valid = False
                e.ErrorText = "Jumlah transaksi tidak bisa 0."
            Else
                e.Valid = True
            End If
        End If
    End Sub

    Private Sub txtSelisih_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSelisih.EditValueChanged
        If txtSelisih.EditValue < 0 Then
            chkHutang.Enabled = False
        Else
            chkHutang.Enabled = True
        End If
    End Sub

    Private Sub LOV_Unit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOV_Unit.EditValueChanged
        GenLOVbuku()
    End Sub
End Class