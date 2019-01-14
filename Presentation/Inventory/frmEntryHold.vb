'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================
'Imports CrystalDecisions.CrystalReports.Engine
'Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmEntryHold
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, dso2, ds_cari, ds_cari1, ds_keypress As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Private DA, DA2, DA3, DALOOKUP, DALOOKUP1, DA_keypres As SqlClient.SqlDataAdapter
    Private x As Int16 = 1

    'Public Sub btnstart()
    '    btnTambah.Enabled = True
    '    btnUbah.Enabled = True
    '    btnSimpan.Enabled = False
    '    btnHapus.Enabled = False
    'End Sub
    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        'dtpTgl.EditValue = getTanggal()
        'enabel()
        'GvBKE_d.Columns("no_seq").Visible = False
        STATE = "ADD" '<-- set state add
    End Sub

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Public Sub save_click()
        'If LookupGudang.EditValue = vbNullString Then
        '    MsgBox("Gudang Tujuan belum di Set!", MsgBoxStyle.Critical, " Lengkapi data sebelum menyimpan!")
        '    Exit Sub
        'End If
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Public Sub cancel_click()
        LoadStruktur("XXX")
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
        'bersihkan()
    End Sub
    Public Sub edit_click()
        'enabel()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.DBO.QC where ", sqlconn)) '
        If Not dSO.Tables("lookup_bmi") Is Nothing Then dSO.Tables("lookup_bmi").Clear()
        DA.Fill(dSO, "lookup_bmi")
        frmCari.set_dso(dSO.Tables("lookup_bmi")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            LoadStruktur(frmCari.row(1))
            STATE = "EDIT"
            btnSave = True
            btnadd = False
            btnEdit = False
            btnDelete = True
            btnCancel = True
            setStatus()
            Me.Enabled = True

        Else
            cancel_click()
            STATE = ""
        End If
    End Sub

    Public Sub simpan()
        Dim BTRANS As SqlTransaction


        'STATE = "ADD"
        If STATE = "ADD" Then
            row = dSO.Tables("_qcm").NewRow
            row.Item("Last_Create_Date") = getTanggal()
            row.Item("Last_Created_By") = username
        ElseIf STATE = "EDIT" Then
            row = dSO.Tables("_qcm").Rows(0)
            row.Item("Last_Update_Date") = getTanggal()
            row.Item("Last_Updated_By") = username
        End If
        row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener

        row.Item("no_trans") = getNoTrans("HOLDPO", getTanggal(BTRANS), BTRANS)
        'row.Item("status_hold") = "HOLD_PO"
        row.Item("tgl_trans") = getTanggal()
        row.Item("jml_rp_trans") = GvHoldPO.Columns(5).SummaryItem.SummaryValue
        ''row.Item("penyerah") = TxbPenerima.Text
        'row.Item("gudang_tujuan") = LookupGudang.EditValue
        'row.Item("Rec_Stat") = IIf(cbStat.Text = "AKTIF", "Y", "T")
        row.Item("blthn") = blthn()
        row.Item("Program_Name") = Me.Name
        txbNoTrans.Text = row.Item("no_trans")
        If STATE = "ADD" Then
            dSO.Tables("_qcm").Rows.Add(row)
        End If
        For Each row1 As DataRow In dSO1.Tables("_qc").Rows
            If row1.RowState = DataRowState.Added Then
                row1.Item("no_trans") = row.Item("no_trans")
                row1.Item("tgl_trans") = row.Item("tgl_trans")
                row1.Item("Last_Create_Date") = row.Item("tgl_trans")
                row1.Item("Last_Created_By") = username
                row1.Item("kd_Cabang") = kdcabang
            Else
                row1.Item("Last_Update_Date") = row.Item("tgl_trans")
                row1.Item("Last_Updated_By") = username
            End If
            row1.Item("Program_name") = Me.Name

        Next
        txbNoTrans.Text = row.Item("no_trans")



        Try
            Buildernya = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = Buildernya.GetUpdateCommand()
            DA.InsertCommand = Buildernya.GetInsertCommand()
            DA.DeleteCommand = Buildernya.GetDeleteCommand()

            Buildernya = New SqlClient.SqlCommandBuilder(DA2)
            DA2.UpdateCommand = Buildernya.GetUpdateCommand()
            DA2.InsertCommand = Buildernya.GetInsertCommand()
            DA2.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            DA2.UpdateCommand.Transaction = BTRANS
            DA2.InsertCommand.Transaction = BTRANS
            DA2.DeleteCommand.Transaction = BTRANS

            If STATE = "ADD" Then
                'row.Item("no_trans") = getNoTrans("QC", getTanggal(BTRANS), BTRANS)
                txbNoTrans.Text = row.Item("no_trans")
                For Each row1 As DataRow In dSO1.Tables("_qc").Rows
                    If row1.RowState = DataRowState.Added Then
                        row1.Item("no_trans") = row.Item("no_trans")
                        row1.Item("blthn") = blthn(BTRANS)
                    End If
                Next
            End If


            DA.Update(dSO.Tables("_qcm"))
            DA2.Update(dSO1.Tables("_qc"))
            ''sp1
            'For Each row1 As DataRow In dSO1.Tables("_qc").Rows
            '    If STATE = "ADD" Then
            '        'setor_prosedur("201106", "0121203010100018006201", "UNIT", "G001", 2, BTRANS)
            '        setor_prosedur(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row("kode_gudang").ToString, row1("qty_in"), BTRANS)
            '    End If
            'Next
            '' ## sp 2
            'For Each row1 As DataRow In dSO1.Tables("_qc").Rows
            '    If STATE = "ADD" Then
            '        'setor_prosedur("201106", "0121203010100018006201", "UNIT", "G001", 2, BTRANS)
            '        setor_prosedur2(kdcabang, blthn(BTRANS), row1("kd_stok").ToString, row1("kd_satuan").ToString, row1("qty_in"), row1("rp_trans"), BTRANS)
            '    End If
            'Next

            'dSO.Tables("_qcm").AcceptChanges()
            'dSO1.Tables("_qc").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan")
        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_qcm").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    'Private Sub txtcari_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcari.KeyDown
    '    If e.KeyCode = Keys.Enter Then
    '        GcBM.DataSource = dSO1.Tables("VBARANG")
    '        GvBM.Columns("Nama_Barang").FilterInfo = New DevExpress.XtraGrid.Columns.ColumnFilterInfo(DevExpress.XtraGrid.Columns.ColumnFilterType.Value, "Nama_Barang Like '%" & txtcari.Text & "%'")
    '        If GvBM.RowCount = 1 Then
    '            GvBM.Focus()
    '            'GvBM_DoubleClick(GvBM, New EventArgs)
    '        End If
    '    ElseIf e.KeyCode = Keys.Escape Then
    '        'popCon.Hide()
    '    End If
    'End Sub
    Private Function blthn(Optional ByVal btrans As Object = Nothing) As String
        Dim hasil As String
        Dim sqlblth As SqlDataReader
        If btrans Is Nothing Then
            'blthn=082011
            'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn).ExecuteReader
            '##blthn=201108
            sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),1,6)as blthn", sqlconn).ExecuteReader
        Else
            'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn, btrans).ExecuteReader
            sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),1,6) as blthn", sqlconn, btrans).ExecuteReader
        End If
        sqlblth.Read()
        hasil = sqlblth.Item(0)
        'End If
        sqlblth.Close()
        Return hasil
    End Function

    Private Sub frmEntryHold_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        prn = getParent(Me)
        GvHoldPO.Columns("harga").Visible = False
        GvHoldPO.Columns("rp_trans").Visible = False

        LoadStruktur("xxxxx")
        formate_yayak()

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang ", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_lookupBrg")
        RL_Barang.DataSource = ds_cari1.Tables("_lookupBrg")
        RL_Barang.ValueMember = "Kode_Barang"
        RL_Barang.DisplayMember = "Nama_Barang"

        txtcari.AutoCompleteCustomSource.AddRange((From row As Object In ds_cari.Tables("_vbrg").Rows.Cast(Of DataRow)() Select CStr(row("Nama_Barang"))).ToArray())
    End Sub

    Private Sub LoadStruktur(ByVal kode As String)
        'If Not dSO.Tables("_bme") Is Nothing Then dSO.Tables("_bme").Clear()
        If Not dSO1.Tables("_qc") Is Nothing Then dSO1.Tables("_qc").Clear()

        DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as nama_barang from INV.dbo.INV_QC where no_trans='" & kode & "'", sqlconn))
        DA2.Fill(dSO1, "_qc")
        GcHoldPO.DataSource = dSO1.Tables("_qc")

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_QC_M where no_trans='" & kode & "'", sqlconn))
        DA.Fill(dSO, "_qcm")
        'GcBME_d.DataSource = dso.Tables("_qcm")
        DALOOKUP = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang,Nama_Barang,Kd_Satuan,spek_brg from SIF.dbo.SIF_Barang where kd_jns_persd='3'", sqlconn))
        DALOOKUP.Fill(ds_cari, "_vbrg")

        If dSO1.Tables("_qc").Rows.Count > 0 Then
            Dim rw As DataRow = dSO1.Tables("_qc").Rows(0)
            txbNoTrans.Text = rw("no_trans").ToString
            'LookupGudang.EditValue = rw("kode_gudang").ToString
            'MsgBox(rw("no_ref").ToString)
        End If
    End Sub

    Private Sub formate_yayak()
        thisThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        GvHoldPO.Columns("hold_po").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvHoldPO.Columns("hold_po").DisplayFormat.FormatString = "n0"
    End Sub

    Private Sub txtKdBrg_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then

        End If
    End Sub
    Sub tunda()
        Me.Refresh()
        System.Threading.Thread.Sleep(1200)
    End Sub
    Function getPosisi(ByVal dr As DataRow) As Integer
        Dim i As Int16 = 0
        For Each rw As DataRow In dSO1.Tables("_holdpo").Rows
            If dr Is rw Then
                Return i
            Else
                i += 1
            End If

        Next
    End Function

    Private Sub txtcari_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcari.KeyDown
        If Not ds_keypress.Tables("_keypres") Is Nothing Then ds_keypress.Tables("_keypres").Clear()
        Dim ok As Boolean = False
        If e.KeyCode = Keys.Enter Then
            DA_keypres = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select brg.Nama_Barang,brg.Kode_Barang,brg.lokasi,brg.Kd_Satuan,brg.kd_ukuran,brg.rek_persediaan,brg.rek_biaya,0 as hold_po,stok.nilai_rata as harga  from INV.dbo.INV_STOK_SALDO as stok inner join SIF.dbo.SIF_Barang as brg on stok.kd_stok=brg.Kode_Barang where brg.kd_jns_persd='3' and brg.Nama_Barang ='" & txtcari.Text & "'", sqlconn))
            DA_keypres.Fill(ds_keypress, "_keypres")
            If ds_keypress.Tables("_keypres").Rows.Count <> 0 Then
                Dim dtrow() As DataRow = dSO1.Tables("_qc").Select("nama_barang='" & txtcari.Text & "'")
                lblNmBrg.ForeColor = Color.Yellow
                lblStatus.ForeColor = Color.Yellow
                'For i As Int16 = 0 To dtrow.Count - 1
                'Application.DoEvents()
                If dtrow.Count = 0 Then
                    Dim rwx As DataRow = ds_keypress.Tables("_keypres").Rows(0)
                    Dim rw As DataRow = dSO1.Tables("_qc").NewRow
                    rw.Item("no_seq") = x : x += 1
                    rw.Item("kd_stok") = rwx.Item("Kode_Barang")
                    rw.Item("nama_barang") = rwx.Item("Nama_Barang")
                    rw.Item("kd_satuan") = rwx.Item("Kd_Satuan")
                    rw.Item("kd_ukuran") = rwx.Item("kd_ukuran")
                    rw.Item("kd_buku_besar") = rwx.Item("rek_persediaan")
                    rw.Item("kd_buku_biaya") = rwx.Item("rek_biaya")
                    rw.Item("hold_po") = rwx.Item("hold_po") + 1
                    rw.Item("status_hold") = "HOLD_PO"
                    rw.Item("gudang_tujuan") = rwx.Item("lokasi")
                    rw.Item("harga") = rwx.Item("harga")
                    rw.Item("rp_trans") = rw("harga") * rw("hold_po")
                    dSO1.Tables("_qc").Rows.Add(rw)

                    lblStatus.Text = "OK"
                    lblNmBrg.Text = rw.Item("Nama_Barang")
                    txtcari.SelectAll()
                    tunda()
                    txtcari.Text = ""
                    lblNmBrg.Text = ""
                    lblStatus.Text = ""
                    txtcari.Focus()
                    Exit Sub
                Else
                    For i As Int16 = 0 To dtrow.Count - 1
                        'Application.DoEvents()
                        lblStatus.Text = "OK"
                        lblNmBrg.Text = dtrow(i)("nama_barang").ToString
                        txtcari.SelectAll()
                        'If dtrow(i)("qty_ord") > dtrow(i)("qty_in") Then  ' jika sisa masih ada maka ble terus transaksi barcode
                        'If dtrow.Count > 0 Then
                        dtrow(i)("hold_po") = dtrow(i)("hold_po") + 1
                        dtrow(i)("rp_trans") = dtrow(i)("hold_po") * dtrow(i)("harga")

                        'dtrow(i)("qty_sisa") = dtrow(i)("qty_ord") - dtrow(i)("qty_out")
                        ok = True
                        'BindingContext(GcBKI_d.DataSource).Position = getPosisi(dtrow(i))
                        tunda()
                        txtcari.Text = ""
                        lblNmBrg.Text = ""
                        lblStatus.Text = ""
                        txtcari.Focus()
                        'MsgBox("barang ada")
                        Exit Sub
                        'End If
                    Next

                End If
            Else
                lblNmBrg.ForeColor = Color.Magenta
                lblStatus.ForeColor = Color.Magenta

                lblNmBrg.Text = "Item tidak ada dalam Daftar"
                lblStatus.Text = "KOSONG"
                tunda()
                txtcari.Text = ""
                lblNmBrg.Text = ""
                lblStatus.Text = ""
                txtcari.Focus()
            End If
            txtcari.SelectAll()
        End If
        ds_keypress.Clear()

        '------
        'Dim ok As Boolean = False
        'If e.KeyCode = Keys.Enter Then
        '    Dim sqlread As SqlDataReader = New SqlCommand("select brg.Nama_Barang,brg.Kode_Barang,brg.lokasi,brg.Kd_Satuan,brg.kd_ukuran,brg.rek_persediaan,brg.rek_biaya,0 as hold_po,stok.nilai_rata as harga  from INV.dbo.INV_STOK_SALDO as stok inner join SIF.dbo.SIF_Barang as brg on stok.kd_stok=brg.Kode_Barang where brg.kd_jns_persd='3' and brg.Nama_Barang ='" & txtcari.Text & "'", sqlconn).ExecuteReader
        '    If sqlread.Read Then
        '        Dim dtrow() As DataRow = dSO1.Tables("_qc").Select("nama_barang='" & txtcari.Text & "'")
        '        'lblNmBrg.ForeColor = Color.Yellow
        '        'lblStatus.ForeColor = Color.Yellow
        '        'For i As Int16 = 0 To dtrow.Count - 1
        '        'Application.DoEvents()
        '        If dtrow.Count = 0 Then
        '            Dim rw As DataRow = dSO1.Tables("_qc").NewRow
        '            rw.Item("no_seq") = x : x += 1
        '            rw.Item("kd_stok") = sqlread.Item("Kode_Barang")
        '            rw.Item("nama_barang") = sqlread.Item("Nama_Barang")
        '            rw.Item("kd_satuan") = sqlread.Item("Kd_Satuan")
        '            rw.Item("kd_ukuran") = sqlread.Item("kd_ukuran")
        '            rw.Item("kd_buku_besar") = sqlread.Item("rek_persediaan")
        '            rw.Item("kd_buku_biaya") = sqlread.Item("rek_biaya")
        '            rw.Item("hold_po") = sqlread.Item("hold_po") + 1
        '            rw.Item("status_hold") = "HOLD_PO"
        '            rw.Item("gudang_tujuan") = sqlread.Item("lokasi")
        '            rw.Item("harga") = sqlread.Item("harga")
        '            rw.Item("rp_trans") = rw("harga") * rw("hold_po")
        '            dSO1.Tables("_qc").Rows.Add(rw)
        '        Else
        '            For i As Int16 = 0 To dtrow.Count - 1
        '                'Application.DoEvents()
        '                lblStatus.Text = "OK"
        '                lblNmBrg.Text = dtrow(i)("nama_barang").ToString
        '                txtcari.SelectAll()
        '                'If dtrow(i)("qty_ord") > dtrow(i)("qty_in") Then  ' jika sisa masih ada maka ble terus transaksi barcode
        '                'If dtrow.Count > 0 Then
        '                dtrow(i)("hold_po") = dtrow(i)("hold_po") + 1
        '                dtrow(i)("rp_trans") = dtrow(i)("hold_po") * dtrow(i)("harga")

        '                'dtrow(i)("qty_sisa") = dtrow(i)("qty_ord") - dtrow(i)("qty_out")
        '                ok = True
        '                'BindingContext(GcBKI_d.DataSource).Position = getPosisi(dtrow(i))
        '                tunda()
        '                txtcari.Text = ""
        '                lblNmBrg.Text = ""
        '                lblStatus.Text = ""
        '                txtcari.Focus()
        '                'MsgBox("barang ada")
        '                Exit Sub
        '                'End If
        '            Next
        '        End If

        '        'BindingContext(GcBKI_d.DataSource).Position = getPosisi(rw(i))
        '        'tunda()
        '        txtcari.Text = ""
        '        lblNmBrg.Text = ""
        '        lblStatus.Text = ""
        '        txtcari.Focus()
        '        sqlread.Close()
        '        'Next

        '    Else
        '        lblNmBrg.ForeColor = Color.Magenta
        '        lblStatus.ForeColor = Color.Magenta

        '        lblNmBrg.Text = "Barang tidak terdaftar di Master"
        '        lblStatus.Text = "KOSONG"
        '        tunda()
        '        txtcari.Text = ""
        '        lblNmBrg.Text = ""
        '        lblStatus.Text = ""
        '        txtcari.Focus()

        '        'MsgBox("barang tidak ada")
        '        'ElseIf Not ok Then
        '        '    lblNmBrg.Text = "Barang sudah terdaftar semua"
        '        '    lblStatus.Text = "STOP!"
        '    End If
        '    txtcari.SelectAll()
        '    sqlread.Close()
        'End If


    End Sub


    Private Sub GvHoldPO_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GvHoldPO.CellValueChanged
        If e.Column Is hold_po Then
            GvHoldPO.GetRow(e.RowHandle).item("rp_trans") = GvHoldPO.GetRow(e.RowHandle).item("harga") * GvHoldPO.GetRow(e.RowHandle).item("hold_po")
        End If
    End Sub

    Private Sub TxbKdBrg_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxbKdBrg.KeyDown
        If Not ds_keypress.Tables("_keypres") Is Nothing Then ds_keypress.Tables("_keypres").Clear()
        Dim ok As Boolean = False
        If e.KeyCode = Keys.Enter Then
            DA_keypres = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select brg.Nama_Barang,brg.Kode_Barang,brg.lokasi,brg.Kd_Satuan,brg.kd_ukuran,brg.rek_persediaan,brg.rek_biaya,0 as hold_po,stok.nilai_rata as harga  from INV.dbo.INV_STOK_SALDO as stok inner join SIF.dbo.SIF_Barang as brg on stok.kd_stok=brg.Kode_Barang where brg.kd_jns_persd='3' and brg.Kode_Barang ='" & TxbKdBrg.Text & "'", sqlconn))
            DA_keypres.Fill(ds_keypress, "_keypres")
            If ds_keypress.Tables("_keypres").Rows.Count <> 0 Then
                Dim dtrow() As DataRow = dSO1.Tables("_qc").Select("kd_stok='" & TxbKdBrg.Text & "'")
                lblNmBrg.ForeColor = Color.Yellow
                lblStatus.ForeColor = Color.Yellow
                'For i As Int16 = 0 To dtrow.Count - 1
                'Application.DoEvents()
                If dtrow.Count = 0 Then
                    Dim rwx As DataRow = ds_keypress.Tables("_keypres").Rows(0)
                    Dim rw As DataRow = dSO1.Tables("_qc").NewRow
                    rw.Item("no_seq") = x : x += 1
                    rw.Item("kd_stok") = rwx.Item("Kode_Barang")
                    rw.Item("nama_barang") = rwx.Item("Nama_Barang")
                    rw.Item("kd_satuan") = rwx.Item("Kd_Satuan")
                    rw.Item("kd_ukuran") = rwx.Item("kd_ukuran")
                    rw.Item("kd_buku_besar") = rwx.Item("rek_persediaan")
                    rw.Item("kd_buku_biaya") = rwx.Item("rek_biaya")
                    rw.Item("hold_po") = rwx.Item("hold_po") + 1
                    rw.Item("status_hold") = "HOLD_PO"
                    rw.Item("gudang_tujuan") = rwx.Item("lokasi")
                    rw.Item("harga") = rwx.Item("harga")
                    rw.Item("rp_trans") = rw("harga") * rw("hold_po")
                    dSO1.Tables("_qc").Rows.Add(rw)

                    lblStatus.Text = "OK"
                    lblNmBrg.Text = rw.Item("Nama_Barang")
                    TxbKdBrg.SelectAll()
                    tunda()
                    TxbKdBrg.Text = ""
                    lblNmBrg.Text = ""
                    lblStatus.Text = ""
                    TxbKdBrg.Focus()
                    Exit Sub
                Else
                    For i As Int16 = 0 To dtrow.Count - 1
                        'Application.DoEvents()
                        lblStatus.Text = "OK"
                        lblNmBrg.Text = dtrow(i)("nama_barang").ToString
                        TxbKdBrg.SelectAll()
                        'If dtrow(i)("qty_ord") > dtrow(i)("qty_in") Then  ' jika sisa masih ada maka ble terus transaksi barcode
                        'If dtrow.Count > 0 Then
                        dtrow(i)("hold_po") = dtrow(i)("hold_po") + 1
                        dtrow(i)("rp_trans") = dtrow(i)("hold_po") * dtrow(i)("harga")

                        'dtrow(i)("qty_sisa") = dtrow(i)("qty_ord") - dtrow(i)("qty_out")
                        ok = True
                        'BindingContext(GcBKI_d.DataSource).Position = getPosisi(dtrow(i))
                        tunda()
                        TxbKdBrg.Text = ""
                        lblNmBrg.Text = ""
                        lblStatus.Text = ""
                        TxbKdBrg.Focus()
                        'MsgBox("barang ada")
                        Exit Sub
                        'End If
                    Next

                End If
            Else
                lblNmBrg.ForeColor = Color.Magenta
                lblStatus.ForeColor = Color.Magenta

                lblNmBrg.Text = "Item tidak ada dalam Daftar"
                lblStatus.Text = "KOSONG"
                tunda()
                TxbKdBrg.Text = ""
                lblNmBrg.Text = ""
                lblStatus.Text = ""
                TxbKdBrg.Focus()
            End If
            txtcari.SelectAll()
        End If
        ds_keypress.Clear()
    End Sub
End Class