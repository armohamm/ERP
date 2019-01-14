Imports System.Globalization
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient

Public Class aFormMutasiBrgStok
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public btnCetak As Boolean = False
    Public prn As frmMain
    Dim dsMutasi, dsMutasi1, ds2, ds3 As New DataSet
    Dim builderM, builderD As New SqlCommandBuilder

    Dim daMutasiM, daMutasiD, daBarang, daSatuan, daGudang, daUkuran, daProsedur, daMutasi1, da2, da3 As SqlDataAdapter
    Dim drStok As SqlDataReader
    Dim noMutasi As String
    Dim row As DataRow
    Dim cabang() As String
    Dim thnbln() As String
    Dim stok() As String
    Dim satuan() As String
    Dim awal() As String
    Dim akhir() As String
    Dim ukuran() As String
    Dim jml() As Integer
    Dim panjang(), tinggi(), lebar() As Double
    Private BTRAN As SqlTransaction

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Public Sub bersihkan()
        txtGudangAsal.EditValue = vbNullString
        txtGudangTujuan.EditValue = vbNullString
        txtNomor.EditValue = vbNullString
        'dtpTanggal.EditValue = to
        txtKeterangan.Text = ""
        'txbToko.Text = ""
        'dsMutasi1.Tables("MutasiM").Clear()
        'dsMutasi1.Tables("MutasiD").Clear()

    End Sub

    Public Sub add_click()
        STATE = "ADD"
        cancel_click()
        dtpTanggal.EditValue = getTanggal()
        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnadd = False
        setStatus()
        Me.Enabled = True
        btnCetak = False


        'reload()
    End Sub
    Public Sub edit_click()
        STATE = "EDIT"
        frmMain.btnCetak.Enabled = True
        If Not dsMutasi1.Tables("lookup_mts") Is Nothing Then dsMutasi1.Tables("lookup_mts").Clear()
        daMutasi1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_trans as [Nomor], tgl_trans, last_created_by from inv.dbo.inv_gudang_out where tipe_trans = 'JPB-KUT-99' ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca

        daMutasi1.Fill(dsMutasi1, "lookup_mts")
        frmCari.set_dso(dsMutasi1.Tables("lookup_mts")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            'da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.DBO.INV_GUDANG_OUT where no_trans='" & frmCari.row("Nomor") & "'", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
            'If Not ds2.Tables("GdOut") Is Nothing Then ds2.Tables("GdOut").Clear()
            'da2.Fill(ds2, "GdOut")
            'row = ds2.Tables("GdOut").Rows(0)
            'txtNomor.Text = row.Item("no_trans")
            'txtKeterangan.Text = row.Item("keterangan")
            'dtpTanggal.DateTime = row.Item("tgl_trans")

            'da3 = New SqlDataAdapter(New SqlCommand("select * from INV.DBO.INV_GUDANG_OUT where no_trans='" & frmCari.row("no_trans") & "'", sqlconn))
            'If Not ds3.Tables("GdOutD") Is Nothing Then ds3.Tables("GdOutD").Clear()
            'da3.Fill(ds3, "GdOutD")
            'gcMutasi.DataSource = ds3.Tables("GdOutD")
            loadLookUp()
            loadData(frmCari.row(0))
            btnSave = False
            btnadd = False
            btnEdit = False
            btnDelete = False
            btnCancel = True
            setStatus()
            Me.Enabled = True
        Else
            cancel_click()
        End If
    End Sub

    Public Sub cetak_click()
        callReport(App_Path() & "\report\BK_mtsi.rpt", "", "no_mtsi=" & txtNomor.Text, False, True)
        Dim sqcmd As New SqlCommand("update INV.dbo.INV_GUDANG_OUT set cetak_ulang='T', cetak_ke = cetak_ke + 1 where no_trans='" & txtNomor.Text & "'", sqlconn, BTRAN)
        sqcmd.ExecuteNonQuery()
    End Sub

    Public Sub cancel_click()
        bersihkan()
        loadData("xxx")
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False

    End Sub

    Private Sub loadLookUp()
        If Not dsMutasi.Tables("Barang") Is Nothing Then dsMutasi.Tables("Barang").Clear()
        If Not dsMutasi.Tables("Satuan") Is Nothing Then dsMutasi.Tables("Satuan").Clear()
        If Not dsMutasi.Tables("Gudang") Is Nothing Then dsMutasi.Tables("Gudang").Clear()
        If Not dsMutasi.Tables("Ukuran") Is Nothing Then dsMutasi.Tables("Ukuran").Clear()

        daBarang = New SqlDataAdapter(New SqlCommand("SELECT Kode_Barang, Nama_Barang FROM SIF.dbo.SIF_Barang WHERE kd_jns_persd not in ('4','5') and rec_stat <> 'T' order by nama_barang", sqlconn))
        daBarang.Fill(dsMutasi, "Barang")
        lckBarang.DataSource = dsMutasi.Tables("Barang")
        lckBarang.ValueMember = "Kode_Barang"
        lckBarang.DisplayMember = "Nama_Barang"

        daUkuran = New SqlDataAdapter(New SqlCommand("SELECT Kode_Ukuran, Nama_Ukuran FROM SIF.dbo.SIF_Ukuran", sqlconn))
        daUkuran.Fill(dsMutasi, "Ukuran")
        lckUkuran.DataSource = dsMutasi.Tables("Ukuran")
        lckUkuran.ValueMember = "Kode_Ukuran"
        lckUkuran.DisplayMember = "Nama_Ukuran"

        daSatuan = New SqlDataAdapter(New SqlCommand("SELECT Kode_Satuan, Nama_Satuan FROM SIF.dbo.SIF_Satuan", sqlconn))
        daSatuan.Fill(dsMutasi, "Satuan")
        lckSatuan.DataSource = dsMutasi.Tables("Satuan")
        lckSatuan.ValueMember = "Kode_Satuan"
        lckSatuan.DisplayMember = "Nama_Satuan"

        daGudang = New SqlDataAdapter(New SqlCommand("SELECT Kode_Gudang, Nama_Gudang FROM SIF.dbo.SIF_Gudang", sqlconn))
        daGudang.Fill(dsMutasi, "Gudang")
        lckGudang1.DataSource = dsMutasi.Tables("Gudang")
        lckGudang1.ValueMember = "Kode_Gudang"
        lckGudang1.DisplayMember = "Nama_Gudang"
        lckGudang2.DataSource = dsMutasi.Tables("Gudang")
        lckGudang2.ValueMember = "Kode_Gudang"
        lckGudang2.DisplayMember = "Nama_Gudang"
        txtGudangAsal.Properties.DataSource = dsMutasi.Tables("Gudang")
        txtGudangAsal.Properties.ValueMember = "Kode_Gudang"
        txtGudangAsal.Properties.DisplayMember = "Nama_Gudang"
        txtGudangTujuan.Properties.DataSource = dsMutasi.Tables("Gudang")
        txtGudangTujuan.Properties.ValueMember = "Kode_Gudang"
        txtGudangTujuan.Properties.DisplayMember = "Nama_Gudang"
    End Sub

    Private Sub loadData(ByVal kode As String)
        If Not dsMutasi.Tables("Mutasi") Is Nothing Then dsMutasi.Tables("Mutasi").Clear()
        If Not dsMutasi.Tables("MutasiD") Is Nothing Then dsMutasi.Tables("MutasiD").Clear()

        daMutasiM = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT * FROM INV.dbo.inv_gudang_out WHERE no_trans = '" & kode & "'", sqlconn))
        daMutasiM.Fill(dsMutasi, "MutasiM")
        daMutasiD = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT *, 0.0 saldo FROM INV.dbo.inv_gudang_out_d WHERE no_trans = '" & kode & "'", sqlconn))
        daMutasiD.Fill(dsMutasi, "MutasiD")
        gcMutasi.DataSource = dsMutasi.Tables("MutasiD")
        If dsMutasi.Tables("MutasiM").Rows.Count > 0 Then
            If STATE = "EDIT" Then
                'MsgBox(dsMutasi.Tables("MutasiD").Rows(0).Item("gudang_asal").ToString)
                'MsgBox(dsMutasi.Tables("MutasiD").Rows(0).Item("gudang_tujuan").ToString)
                txtGudangAsal.EditValue = dsMutasi.Tables("MutasiD").Rows(0).Item("gudang_asal").ToString
                txtGudangTujuan.EditValue = dsMutasi.Tables("MutasiD").Rows(0).Item("gudang_tujuan").ToString
            End If
            txtNomor.Text = dsMutasi.Tables("MutasiM").Rows(0).Item("no_trans").ToString
            dtpTanggal.Text = dsMutasi.Tables("MutasiM").Rows(0).Item("tgl_trans").ToString
            If Not TypeOf dsMutasi.Tables("MutasiM").Rows(0).Item("keterangan") Is DBNull Then
                txtKeterangan.Text = dsMutasi.Tables("MutasiM").Rows(0).Item("keterangan")
            Else
                txtKeterangan.Text = ""
            End If

        Else
            txtNomor.Text = ""
            dtpTanggal.Text = ""
            txtKeterangan.Text = ""
        End If
    End Sub

    Private Sub aFormMutasiBrgStok_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        'Me.Enabled = True
        btnEdit = True
        btnDelete = False
        loadLookUp()
        loadData("xxx")
        dtpTanggal.EditValue = getTanggal()
    End Sub

    Private Sub refreshNo()
        Dim i As Integer = 1
        If gvMutasi.RowCount = 0 Then
            Exit Sub
        Else
            For j As Integer = 0 To gvMutasi.RowCount - 1
                gvMutasi.GetDataRow(j).Item("no_seq") = i
                i += 1
            Next
        End If
    End Sub

    Private Sub txtAngka_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAngka.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 'dari 0-9
                e.Handled = False
            Case 8, 127
                e.Handled = False
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub gvMutasi_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvMutasi.CellValueChanged
        Dim ok As String = ""

        If e.Column Is kd_stok Then
            drStok = New SqlCommand("SELECT a.Kd_Satuan, a.rek_persediaan, a.kd_ukuran, b.panjang, b.tinggi, b.lebar FROM SIF.dbo.SIF_Barang a, SIF.dbo.SIF_Ukuran b WHERE a.kd_ukuran = b.Kode_Ukuran AND a.Kode_Barang = '" & gvMutasi.GetRowCellValue(e.RowHandle, "kd_stok") & "'", sqlconn).ExecuteReader
            While drStok.Read()
                gvMutasi.SetFocusedRowCellValue("kd_satuan", drStok.Item("Kd_Satuan"))
                gvMutasi.SetFocusedRowCellValue("panjang", drStok.Item("panjang"))
                gvMutasi.SetFocusedRowCellValue("tinggi", drStok.Item("tinggi"))
                gvMutasi.SetFocusedRowCellValue("lebar", drStok.Item("lebar"))
                gvMutasi.SetFocusedRowCellValue("kd_buku_besar", drStok.Item("rek_persediaan"))
                If Not TypeOf drStok.Item("kd_ukuran") Is DBNull Then gvMutasi.SetFocusedRowCellValue("kd_ukuran", drStok.Item("kd_ukuran")) Else gvMutasi.SetFocusedRowCellValue("kd_ukuran", "000")

            End While
            ok = "OK"
            drStok.Close()

        End If

        If ok = "OK" Then
            If Not gvMutasi.GetRowCellValue(e.RowHandle, "kd_ukuran") = "000" Then
                gvMutasi.Columns.Item("kd_ukuran").OptionsColumn.AllowEdit = False
            Else
                gvMutasi.Columns.Item("kd_ukuran").OptionsColumn.AllowEdit = True
            End If
            ok = ""
        End If

        If e.Column Is kd_stok Or e.Column Is kode_gudang1 Then
            If Not gvMutasi.GetRow(e.RowHandle)("kd_stok") Is DBNull.Value And Not gvMutasi.GetRow(e.RowHandle)("gudang_asal") Is DBNull.Value Then
                Dim dr As SqlDataReader = New SqlCommand("select sum(isnull(akhir_qty,0)) akhir_qty, count(1) jml from inv.dbo.inv_stok_gudang where bultah = '" & Format(dtpTanggal.EditValue, "yyyyMM") & "' and kode_gudang = '" & gvMutasi.GetRow(e.RowHandle)("gudang_asal") & "' and kd_stok = '" & gvMutasi.GetRow(e.RowHandle)("kd_stok") & "'", sqlconn).ExecuteReader
                dr.Read()
                If Not TypeOf dr.Item(0) Is System.DBNull Then

                    gvMutasi.GetRow(e.RowHandle)("saldo") = dr.Item(0)
                Else
                    gvMutasi.GetRow(e.RowHandle)("saldo") = 0
                End If
                dr.Close()
            End If
        End If
    End Sub

    Private Sub gcMutasi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gcMutasi.KeyDown
        If e.KeyCode = Keys.Delete Then
            If gvMutasi.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus detil mutasi yang dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "HAPUS?") = MsgBoxResult.Yes Then
                    gvMutasi.DeleteSelectedRows()
                    refreshNo()
                End If
            End If
        End If
    End Sub

    Private Sub formate_yayak()
        thisThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        gvMutasi.Columns("qty").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        gvMutasi.Columns("qty").DisplayFormat.FormatString = "n3"
        gvMutasi.Columns("saldo").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        gvMutasi.Columns("saldo").DisplayFormat.FormatString = "n3"
    End Sub

    Public Sub save_click()
        Dim BTRANS As SqlTransaction
        ReDim cabang(0)
        ReDim thnbln(0)
        ReDim stok(0)
        ReDim satuan(0)
        ReDim awal(0)
        ReDim akhir(0)
        ReDim jml(0)
        ReDim panjang(0)
        ReDim tinggi(0)
        ReDim lebar(0)
        ReDim ukuran(0)
        If gvMutasi.RowCount <= 0 Then
            MsgBox("Detil mutasi masih belum diisi.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "PERINGATAN!")
            Exit Sub
        End If

        If MsgBox("Data akan disimpan?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "SIMPAN?") = MsgBoxResult.Yes Then
            Try
                noMutasi = getNoTrans("MTS", getTanggal())
                txtNomor.EditValue = noMutasi
                row = dsMutasi.Tables("MutasiM").NewRow
                row.Item("Kd_Cabang") = getKodeCabang()
                row.Item("no_trans") = txtNomor.EditValue
                row.Item("tipe_trans") = "JPB-KUT-99"
                row.Item("tgl_trans") = dtpTanggal.EditValue
                row.Item("jml_rp_trans") = 0
                row.Item("keterangan") = txtKeterangan.EditValue
                row.Item("blthn") = Format(dtpTanggal.EditValue, "yyyyMM")
                row.Item("Last_Create_Date") = getTanggal()
                row.Item("Last_Created_By") = username
                row.Item("Program_Name") = Me.Name
                dsMutasi.Tables("MutasiM").Rows.Add(row)

                For Each rows As DataRow In dsMutasi.Tables("MutasiD").Rows
                    If rows.RowState = DataRowState.Added Then
                        rows.Item("Kd_Cabang") = getKodeCabang()
                        rows.Item("no_trans") = txtNomor.EditValue
                        rows.Item("tipe_trans") = "JPB-KUT-99"
                        rows.Item("qty_out") = rows.Item("qty_order")
                        rows.Item("no_ref") = txtNomor.EditValue
                        rows.Item("blthn") = Format(dtpTanggal.EditValue, "yyyyMM")
                        rows.Item("Last_Create_Date") = getTanggal()
                        rows.Item("Last_Created_By") = username
                        rows.Item("Program_Name") = Me.Name
                        cabang(cabang.Length - 1) = rows.Item("Kd_Cabang")
                        thnbln(thnbln.Length - 1) = Format(dtpTanggal.EditValue, "yyyyMM")
                        stok(stok.Length - 1) = rows.Item("kd_stok")
                        satuan(satuan.Length - 1) = rows.Item("kd_satuan")
                        awal(awal.Length - 1) = rows.Item("gudang_asal")
                        akhir(akhir.Length - 1) = rows.Item("gudang_tujuan")
                        jml(jml.Length - 1) = rows.Item("qty_order")
                        panjang(panjang.Length - 1) = rows.Item("panjang")
                        tinggi(tinggi.Length - 1) = rows.Item("tinggi")
                        lebar(lebar.Length - 1) = rows.Item("lebar")
                        ukuran(ukuran.Length - 1) = rows.Item("kd_ukuran")
                        ReDim Preserve cabang(cabang.Length)
                        ReDim Preserve thnbln(thnbln.Length)
                        ReDim Preserve stok(stok.Length)
                        ReDim Preserve satuan(satuan.Length)
                        ReDim Preserve awal(awal.Length)
                        ReDim Preserve akhir(akhir.Length)
                        ReDim Preserve jml(jml.Length)
                        ReDim Preserve panjang(panjang.Length)
                        ReDim Preserve tinggi(tinggi.Length)
                        ReDim Preserve lebar(lebar.Length)
                        ReDim Preserve ukuran(ukuran.Length)
                    End If
                Next

                builderM = New SqlCommandBuilder(daMutasiM)
                daMutasiM.UpdateCommand = builderM.GetUpdateCommand()
                daMutasiM.InsertCommand = builderM.GetInsertCommand()
                daMutasiM.DeleteCommand = builderM.GetDeleteCommand()

                builderD = New SqlCommandBuilder(daMutasiD)
                daMutasiD.UpdateCommand = builderD.GetUpdateCommand()
                daMutasiD.InsertCommand = builderD.GetInsertCommand()
                daMutasiD.DeleteCommand = builderD.GetDeleteCommand()

                BTRANS = sqlconn.BeginTransaction()
                daMutasiM.UpdateCommand.Transaction = BTRANS
                daMutasiM.InsertCommand.Transaction = BTRANS
                daMutasiM.DeleteCommand.Transaction = BTRANS

                daMutasiD.UpdateCommand.Transaction = BTRANS
                daMutasiD.InsertCommand.Transaction = BTRANS
                daMutasiD.DeleteCommand.Transaction = BTRANS

                daMutasiM.Update(dsMutasi.Tables("MutasiM"))
                daMutasiD.Update(dsMutasi.Tables("MutasiD"))

                dsMutasi.Tables("MutasiM").AcceptChanges()
                dsMutasi.Tables("MutasiD").AcceptChanges()

                For i As Integer = 0 To cabang.Length - 2
                    call_procedure(cabang(i), thnbln(i), stok(i), satuan(i), awal(i), akhir(i), jml(i), panjang(i), lebar(i), tinggi(i), ukuran(i), BTRANS)
                    'MsgBox(cabang(i) & " " & thnbln(i) & " " & stok(i) & " " & satuan(i) & " " & awal(i) & " " & akhir(i) & " " & jml(i))
                Next


                call_procedure_in(BTRANS)
                BTRANS.Commit()
                showMessages("Berhasil disimpan..")
                btnSave = False
                btnCancel = True
                btnDelete = False
                btnEdit = True
                btnadd = True
                setStatus()
                'cancel_click()
            Catch ex As Exception
                dsMutasi.Tables("MutasiM").RejectChanges()
                dsMutasi.Tables("MutasiD").RejectChanges()
                If Not BTRANS Is Nothing Then BTRANS.Rollback()
                MsgBox(ex.Message, MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR!")
            End Try
        End If

    End Sub
    Public Sub call_procedure_in(ByVal btrans As SqlTransaction)
        Dim sqlCmd1 As New SqlCommand
        sqlCmd1.Connection = sqlconn
        sqlCmd1.CommandType = CommandType.StoredProcedure
        sqlCmd1.CommandText = "INV.dbo.invp_gudang_in"
        sqlCmd1.Transaction = btrans

        sqlCmd1.Parameters.Add("@vno_trans", SqlDbType.Char).Value = txtNomor.EditValue
        sqlCmd1.Parameters.Add("@vbultah", SqlDbType.Char).Value = Format(dtpTanggal.EditValue, "yyyyMM")
        sqlCmd1.ExecuteNonQuery()

    End Sub

    Public Sub call_procedure(ByVal cabang As String, ByVal thnbln As String, ByVal stok As String, ByVal satuan As String, ByVal awal As String, ByVal akhir As String, ByVal qty As Integer, ByVal panjang As Double, ByVal lebar As Double, ByVal tinggi As Double, ByVal ukuran As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_stok_saldo_gudang"

        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.Char).Value = cabang
        sqlCmd.Parameters.Add("@bultah", SqlDbType.Char).Value = thnbln
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.Char).Value = stok
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.Char).Value = satuan
        sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.Char).Value = ukuran
        sqlCmd.Parameters.Add("@kdgdng_awal", SqlDbType.Char).Value = awal
        sqlCmd.Parameters.Add("@kdgdng_akhir", SqlDbType.Char).Value = akhir
        sqlCmd.Parameters.Add("@tinggi", SqlDbType.Decimal).Value = tinggi
        sqlCmd.Parameters.Add("@lebar", SqlDbType.Decimal).Value = lebar
        sqlCmd.Parameters.Add("@panjang", SqlDbType.Decimal).Value = panjang
        sqlCmd.Parameters.Add("@qty_in", SqlDbType.Decimal).Value = qty
        sqlCmd.ExecuteNonQuery()

    End Sub

    Private Sub gvMutasi_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvMutasi.InitNewRow
        gvMutasi.SetFocusedRowCellValue("no_seq", gvMutasi.RowCount + 1)
        gvMutasi.SetFocusedRowCellValue("qty_order", 0)
        If txtGudangAsal.Text <> "" Then gvMutasi.SetFocusedRowCellValue("gudang_asal", txtGudangAsal.EditValue)
        If txtGudangTujuan.Text <> "" Then gvMutasi.SetFocusedRowCellValue("gudang_tujuan", txtGudangTujuan.EditValue)
    End Sub

    Private Sub gvMutasi_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvMutasi.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gvMutasi_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles gvMutasi.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gvMutasi_MasterRowCollapsed(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs) Handles gvMutasi.MasterRowCollapsed

    End Sub

    Private Sub gvMutasi_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvMutasi.ValidateRow
        Dim bultah1 As String
        Dim qty, sisa As Double
        Dim view As ColumnView = CType(sender, ColumnView)
        Dim column2 As GridColumn = view.Columns("gudang_asal")
        Dim column3 As GridColumn = view.Columns("kd_stok")
        Dim column4 As GridColumn = view.Columns("qty_order")

        bultah1 = Format(dtpTanggal.EditValue, "yyyyMM")

        Dim dr As SqlDataReader = New SqlCommand("select sum(isnull(akhir_qty,0)) akhir_qty, count(1) jml from inv.dbo.inv_stok_gudang where bultah = '" & bultah1 & "' and kode_gudang = '" & e.Row("gudang_asal") & "' and kd_stok = '" & e.Row("kd_stok").ToString & "'", sqlconn).ExecuteReader
        dr.Read()
        If Not TypeOf dr.Item(0) Is System.DBNull Then
            sisa = (dr.Item(0))
            e.Row("saldo") = sisa
        End If
        dr.Close()
        qty = Val(view.GetRowCellValue(e.RowHandle, "qty_order").ToString)

        'Dim drPost As SqlDataReader
        'drPost = New SqlCommand("select akhir_qty from inv.dbo.inv_stok_gudang where kode_gudang = '" & view.GetRowCellValue(e.RowHandle, column2).ToString & "' kd_stok = '" & view.GetRowCellValue(e.RowHandle, column3).ToString & "'", sqlconn).ExecuteReader
        'Do While drPost.Read()
        '    varTmp1 = (drPost.Item(0))
        '    varTmp2 = (drPost.Item(1))
        'Loop
        'drPost.Close()

        If TypeOf e.Row("kd_stok") Is System.DBNull Then
            e.Valid = False
            view.SetColumnError(column3, "Barang belum diisi.")
        End If
        If TypeOf e.Row("qty_order") Is System.DBNull Then
            e.Valid = False
            view.SetColumnError(column4, "Jumlah belum diisi.")
        ElseIf e.Row("qty_order") <= 0 Then
            e.Valid = False
            view.SetColumnError(column4, "Jumlah Qty Salah.")
        End If

        If qty > sisa Then
            e.Valid = False
            view.SetColumnError(column4, "Stok Gudang Asal Tidak Mencukupi untuk Mutasi.")
        End If

        'Try
        '    Dim bultah As String
        '    Dim qty, sisa As Double
        '    Dim view As ColumnView = CType(sender, ColumnView)
        '    Dim column2 As GridColumn = view.Columns("gudang_asal")
        '    Dim column3 As GridColumn = view.Columns("kd_stok")
        '    Dim column4 As GridColumn = view.Columns("qty_order")

        '    bultah = Format(dtpTanggal.EditValue, "yyyyMM")
        '    Dim dr As SqlDataReader = New SqlCommand("select akhir_qty from inv.dbo.inv_stok_gudang where bultah and kode_gudang = '" & view.GetRowCellValue(e.RowHandle, column2).ToString & "' kd_stok = '" & view.GetRowCellValue(e.RowHandle, column3).ToString & "'", sqlconn).ExecuteReader
        '    dr.Read()

        '    sisa = (dr.Item(0))
        '    'Dim drPost As SqlDataReader
        '    'drPost = New SqlCommand("select akhir_qty from inv.dbo.inv_stok_gudang where kode_gudang = '" & view.GetRowCellValue(e.RowHandle, column2).ToString & "' kd_stok = '" & view.GetRowCellValue(e.RowHandle, column3).ToString & "'", sqlconn).ExecuteReader
        '    'Do While drPost.Read()
        '    '    varTmp1 = (drPost.Item(0))
        '    '    varTmp2 = (drPost.Item(1))
        '    'Loop
        '    'drPost.Close()

        '    If TypeOf view.GetRowCellValue(e.RowHandle, column3) Is System.DBNull Then
        '        e.Valid = False
        '        view.SetColumnError(column3, "Barang belum diisi.")
        '    End If
        '    If TypeOf view.GetRowCellValue(e.RowHandle, column4) Is System.DBNull Then
        '        e.Valid = False
        '        view.SetColumnError(column4, "Jumlah belum diisi.")
        '    End If

        '    If qty > sisa Then
        '        e.Valid = False
        '        view.SetColumnError(column4, "Stok Gudang Asal Tidak Mencukupi untuk Mutasi.")
        '    End If
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub gvMutasi_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles gvMutasi.ValidatingEditor
        Dim view As ColumnView = sender
        If view.FocusedColumn.FieldName = "kd_stok" Then
            For i As Integer = 0 To gvMutasi.RowCount
                'MsgBox(vx.GetRowCellValue(i, prev_no_inv))
                If e.Value = view.GetRowCellValue(i, kd_stok) Then
                    e.Valid = False
                    e.ErrorText = "Barang sudah ada."
                End If
                If TypeOf view.GetRowCellValue(i, kd_stok) Is System.DBNull Then
                    e.Valid = False
                    e.ErrorText = "Tidak boleh kosong."
                End If
            Next
        End If

        If view.FocusedColumn.FieldName = "gudang_asal" Then
            'MsgBox(vx.GetRowCellValue(i, prev_no_inv))
            If Not TypeOf view.GetFocusedRowCellValue("gudang_tujuan") Is System.DBNull Then
                If e.Value = view.GetFocusedRowCellValue("gudang_tujuan") Then
                    e.Valid = False
                    e.ErrorText = "Gudang asal tidak boleh sama dengan gudang tujuan."
                End If
            End If
        End If

        If view.FocusedColumn.FieldName = "gudang_tujuan" Then
            'MsgBox(vx.GetRowCellValue(i, prev_no_inv))
            If Not TypeOf view.GetFocusedRowCellValue("gudang_asal") Is System.DBNull Then
                If e.Value = view.GetFocusedRowCellValue("gudang_asal") Then
                    e.Valid = False
                    e.ErrorText = "Gudang tujuan tidak boleh sama dengan gudang asal."
                End If
            End If
        End If
    End Sub

    Private Sub dtpTanggal_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpTanggal.EditValueChanged
        If dtpTanggal.Text <> "" Then
            If dtpTanggal.EditValue <= getTanggal() Then
                dtpTanggal.EditValue = getTanggal()
            End If
        End If
    End Sub
End Class