Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient
Public Class frmINVKonvBrg
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain   '<-- untuk mengakses frmMain
    Public obj As Object
    Dim dS, ds1, ds2, ds3, ds4, dsku, dsku1, dsku2, dsedit As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Public notrans As String = "xxxx"
    Dim row As DataRow
    Dim a As String
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Dim DA, da2, da3, da4, sqlda, daedit, sqlda1, sqlda2, da9 As SqlClient.SqlDataAdapter
    Dim Buildernya As New SqlClient.SqlCommandBuilder

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With

    End Sub
    Private Sub bersih()
        txtKonv.EditValue = vbNullString
        Jumlah_Tujuan.EditValue = vbNullString

        Nilai_Tujuan.EditValue = vbNullString
        'LookUpEditDep.EditValue = vbNullString
    End Sub

    Private Sub reload_table(ByVal kode As String)
        If Not ds3.Tables("PD") Is Nothing Then ds3.Tables("PD").Clear()
        If Not ds4.Tables("PDDM") Is Nothing Then ds4.Tables("PDDM").Clear()
        If Not ds4.Tables("PDD") Is Nothing Then ds4.Tables("PDD").Clear()

        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_DPM where No_DPM='" & kode & "'", sqlconn))
        da3.Fill(ds3, "PD")

        da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_DPM_D where No_DPM='" & kode & "' order by No_Seq asc", sqlconn))
        da4.Fill(ds4, "PDD")


        da9 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_DPM_D_BARANG where no_dpm='" & kode & "' order by no_urut", sqlconn))
        da9.Fill(ds4, "PDDM")
        Dim cnt As Integer = ds4.Tables("PDDM").Rows.Count
        'GC.DataSource = ds4.Tables("PDD")
        If ds3.Tables("PD").Rows.Count > 0 Then
            Dim row As DataRow

            row = ds3.Tables("PD").Rows(0)
            txtKonv.Text = row.Item("No_DPM").ToString
            ' LookUpEditDep..Text = row.Item("Tgl_sp").ToString
            lkBarangTujuan.EditValue = row.Item("Departemen").ToString

            dtTanggal.Text = row.Item("Tgl_DPM")
            Jumlah_Tujuan.EditValue = row.Item("No_Ref")
            Nilai_Tujuan.EditValue = row.Item("rec_stat").ToString


            If row.Item("rec_stat").ToString = "APPROVE" Then
                a = "APPROVE"
            Else
                a = "ENTRY"

            End If
        End If
        GV.CollapseAllDetails()

    End Sub
    Public Sub edit_click()
        daedit = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_trans as [Nomor], tgl_trans as [Tanggal] from INV.dbo.INV_KONVERSI_BARANG", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dsedit.Tables("lookup_DPM") Is Nothing Then dsedit.Tables("lookup_DPM").Clear()
        daedit.Fill(dsedit, "lookup_DPM")
        frmCari.set_dso(dsedit.Tables("lookup_DPM")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            reload_table(frmCari.row(0))

            STATE = "EDIT"

       

            btnSave = True
            btnadd = False
            btnEdit = False
            btnCancel = True
            btnDelete = True
            setStatus()
            Me.Enabled = True


        Else
        cancel_click()
        STATE = ""
        End If
    End Sub
    Public Sub cetak_click()
        'callReport(App_Path() & "\report\rptDPM_M.rpt", "", "Nomor=0014/DPM/201106")
        callReport(App_Path() & "\report\rptDPM_J.rpt", "", "Nomor=" & Trim(txtKonv.Text))
    End Sub
    Public Sub add_click()
        STATE = "ADD"
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()

    End Sub
    'Sub View_Barang()
    '    da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Barang", sqlconn))
    '    da2.Fill(ds2, "View_Barang")
    '    repBarang.DataSource = ds2.Tables("View_Barang")
    'End Sub
    Sub View_Departemen()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Departemen,Nama_Departemen from sif.dbo.SIF_Departemen", sqlconn))
        DA.Fill(ds1, "View_D")
        lkBarangTujuan.Properties.DataSource = ds1.Tables("View_D")
    End Sub
    Private Sub No_Seq(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        For Each rw As DataRow In sender.Rows
            rw("No_Seq") = i
            i += 1
        Next

    End Sub
    Public Function getNextNumberDPM(ByVal bgtrans As SqlTransaction) As String
        Dim hasil, temp As String
        Dim sqldr As SqlDataReader = New SqlCommand("select max(substring(IsNULL(No_DPM,'0001'),1,4))+1 from PURC.dbo.PURC_DPM", sqlconn, bgtrans).ExecuteReader
        sqldr.Read()
        temp = ""
        If TypeOf sqldr.Item(0) Is DBNull Then
            Dim bln1 As String = Format(Now, "MM")
            Dim th1 As String = Format(Now, "yyyy")
            hasil = "0001" & "/" & "DPM" & "/" & th1 & bln1
        Else
            hasil = sqldr.Item(0)
            For i As Int16 = Len(hasil) To 3
                temp = "0" & temp
            Next
            Dim th, bln As String
            bln = Format(Now, "MM")
            th = Format(Now, "yyyy")
            hasil = temp & (hasil) & "/" & "DPM" & "/" & th & bln
        End If
        sqldr.Close()
        Return hasil
    End Function
    Public Sub cancel_click()
        reload_table("XXX")
        bersih()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
    End Sub
    Private Sub frmDPMJasa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        If Not ds4.Relations("Detail") Is Nothing Then ds4.Relations.Clear()
        If Not ds4.Tables("PDD") Is Nothing Then ds4.Tables("PDD").Clear()
        If Not ds4.Tables("PDDM") Is Nothing Then ds4.Tables("PDDM").Clear()


        dtTanggal.DateTime = Date.Today
        View_Departemen()
        da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select b.*,isnull(h.harga_rupiah,0) harga from sif.dbo.SIF_Barang b " & _
            " left join sif.dbo.sif_harga h on b.kode_barang=h.kode_barang " & _
            " where b.kd_jns_persd <> 4", sqlconn))
        da2.Fill(dS, "VBarang")
        repBarang.DataSource = dS.Tables("VBarang")
        da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Barang where kd_jns_persd = 4", sqlconn))
        da2.Fill(dS, "VJasa")
        repJasa.DataSource = dS.Tables("VJasa")
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_KONVERSI_BARANG where no_trans='" & notrans & "'", sqlconn))
        da3.Fill(ds3, "PD")

        da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_KONVERSI_BARANG_D where no_trans='" & notrans & "'", sqlconn))
        da4.Fill(ds4, "PDD")
        'da9 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_DPM_D_BARANG where no_dpm='" & notrans & "'", sqlconn))
        'da9.Fill(ds4, "PDDM")

        'Dim colM(1) As DataColumn
        'Dim colD(1) As DataColumn
        'Dim rel As DataRelation

        'colM(0) = ds4.Tables("PDD").Columns("no_dpm")
        'colM(1) = ds4.Tables("PDD").Columns("kd_stok")

        'colD(0) = ds4.Tables("PDDM").Columns("no_dpm")
        'colD(1) = ds4.Tables("PDDM").Columns("kd_jasa")


        'rel = ds4.Relations.Add("Detail", colM, colD, False)
        'GC.LevelTree.Nodes.Add("Detail", GVDetail)

        GC.DataSource = ds4.Tables("PDD")
        AddHandler ds4.Tables("PDD").RowDeleted, AddressOf refreshNomer
        prn = getParent(Me)
        yayak()
        'If txtNoDPM.Text = "" Then
        'reload_table("xxx")
        'GC.DataSource = ds4.Tables("PDD")
        'End If
        lkBarangTujuan.Properties.DataSource = dS.Tables("VBarang")


    End Sub
    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        'Dim notrans As String
        Dim BTRANS As SqlTransaction

        Buildernya = New SqlClient.SqlCommandBuilder(da3)
        da3.UpdateCommand = Buildernya.GetUpdateCommand()
        da3.InsertCommand = Buildernya.GetInsertCommand()
        da3.DeleteCommand = Buildernya.GetDeleteCommand()

        Buildernya = New SqlClient.SqlCommandBuilder(da4)
        da4.UpdateCommand = Buildernya.GetUpdateCommand()
        da4.InsertCommand = Buildernya.GetInsertCommand()
        da4.DeleteCommand = Buildernya.GetDeleteCommand()

        'Buildernya = New SqlClient.SqlCommandBuilder(da9)
        'da9.UpdateCommand = Buildernya.GetUpdateCommand()
        'da9.InsertCommand = Buildernya.GetInsertCommand()
        'da9.DeleteCommand = Buildernya.GetDeleteCommand()

        BTRANS = sqlconn.BeginTransaction("1")
        da3.UpdateCommand.Transaction = BTRANS
        da3.InsertCommand.Transaction = BTRANS
        da3.DeleteCommand.Transaction = BTRANS
        da4.UpdateCommand.Transaction = BTRANS
        da4.InsertCommand.Transaction = BTRANS
        da4.DeleteCommand.Transaction = BTRANS
        'da9.UpdateCommand.Transaction = BTRANS
        'da9.InsertCommand.Transaction = BTRANS
        'da9.DeleteCommand.Transaction = BTRANS
        If STATE = "ADD" Then
            notrans = getNoTrans("KONV-BRG", getTanggal(BTRANS), BTRANS)
        End If

        If Not isDelete Then
            If STATE = "ADD" Then

                row = ds3.Tables("PD").NewRow

                row.Item("kd_cabang") = kdcabang
                row.Item("no_trans") = notrans
                row.Item("tgl_trans") = dtTanggal.EditValue
                row.Item("kd_barang_tujuan") = lkBarangTujuan.EditValue
                row.Item("kd_satuan_tujuan") = Satuan_Tujuan.EditValue
                row.Item("jumlah_tujuan") = Jumlah_Tujuan.EditValue
                row.Item("nilai_tujuan") = Nilai_Tujuan.EditValue
                row.Item("rec_stat") = "Y"
                row.Item("last_create_date") = Now
                row.Item("last_created_by") = username
                row.Item("program_name") = Me.Name

            ElseIf STATE = "EDIT" Then
                row = ds3.Tables("PD").Rows(0)
                row.Item("last_update_date") = Now
                row.Item("last_updated_by") = username
            End If


            If STATE = "ADD" Then
                ds3.Tables("PD").Rows.Add(row)
            End If

            For Each rows As DataRow In ds4.Tables("PDD").Rows
                If rows.RowState = DataRowState.Added Then

                    rows.Item("no_trans") = notrans
                    'rows.Item("Kd_Stok") = 
                    'rows.Item("Satuan") = 
                    'rows.Item("Qty") = 
                    rows.Item("nilai_asal") = 1
                    rows.Item("last_create_date") = Now
                    rows.Item("last_created_by") = username
                    rows.Item("program_name") = Me.Name
                ElseIf Not rows.RowState = DataRowState.Deleted Then
                    rows.Item("last_update_date") = Now
                    rows.Item("last_updated_by") = username
                End If


            Next
        End If



        Try
            txtKonv.EditValue = notrans
            'If STATE = "ADD" Then
            '    txtNoDPM.Text = notrans
            '    row.Item("No_DPM") = txtNoDPM.Text

            '    For Each rows As DataRow In ds4.Tables("PDD").Rows
            '        If rows.RowState = DataRowState.Added Then
            '            rows.Item("No_DPM") = txtNoDPM.Text
            '        End If
            '    Next
            'End If

            'For Each drows As DataRow In ds4.Tables("PDDM").Rows
            '    If STATE = "ADD" Then
            '        drows.Item("Last_Create_Date") = Now
            '        drows.Item("Last_Created_By") = username
            '    End If
            '    drows.Item("no_dpm") = txtNoDPM.Text
            '    drows.Item("Program_name") = Me.Name
            '    drows.Item("Last_Update_Date") = Now
            '    drows.Item("Last_Updated_By") = username
            'Next



            da3.Update(ds3.Tables("PD"))
            da4.Update(ds4.Tables("PDD"))
            'da9.Update(ds4.Tables("PDDM"))

            ds3.Tables("PD").AcceptChanges()
            ds4.Tables("PDD").AcceptChanges()
            'ds4.Tables("PDDM").AcceptChanges()

            If STATE = "ADD" Then
                Dim rw As DataRow
                rw = dS.Tables("VBarang").Select("Kode_Barang='" & row.Item("kd_barang_tujuan").ToString & "'")(0)
                stprc_gudang_in(kdcabang, blthn(BTRANS), row.Item("kd_barang_tujuan").ToString, row.Item("kd_satuan_tujuan").ToString, 0, "XXXXX", rw("lokasi").ToString, row.Item("jumlah_tujuan"), BTRANS)
                stprc_saldo_in(kdcabang, blthn(BTRANS), row.Item("kd_barang_tujuan").ToString, row.Item("kd_satuan_tujuan").ToString, 0.ToString, row.Item("jumlah_tujuan"), row.Item("jumlah_tujuan") * rw("harga"), BTRANS)
            End If

            For Each rows As DataRow In ds4.Tables("PDD").Rows
                If STATE = "ADD" Then
                    Dim rw As DataRow
                    rw = dS.Tables("VBarang").Select("Kode_Barang='" & rows("Kd_Stok").ToString & "'")(0)
                    stprc_gdout(kdcabang, blthn(BTRANS), rows("Kd_Stok").ToString, rows("Satuan").ToString, 0, rw("lokasi").ToString, "XXXXX", rows("Qty"), BTRANS)
                    stprc_saldo(kdcabang, blthn(BTRANS), rows("Kd_Stok").ToString, rows("Satuan").ToString, 0, rows("Qty"), rows("Qty") * rw("harga"), BTRANS)
                End If
            Next



            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan..")
            GV.CollapseAllDetails()
        Catch e As Exception
            BTRANS.Rollback()
            ds3.Tables("PD").RejectChanges()
            ds4.Tables("PDD").RejectChanges()
            'ds4.Tables("PDDM").RejectChanges()
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub
    Public Sub stprc_gudang_in(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal satuanx As String, ByVal kd_ukuranx As String, ByVal gdg_asal As String, ByVal gudang7an As String, ByVal qty_inx As Decimal, ByVal BTRANS As SqlTransaction)

        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRANS
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_stok_saldo_gudang"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 10).Value = bultah
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 22).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 3).Value = kd_ukuranx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 16).Value = satuanx
        sqlCmd.Parameters.Add("@tinggi", SqlDbType.Decimal).Value = 0
        sqlCmd.Parameters.Add("@lebar", SqlDbType.Decimal).Value = 0
        sqlCmd.Parameters.Add("@panjang", SqlDbType.Decimal).Value = 0
        sqlCmd.Parameters.Add("@kdgdng_awal", SqlDbType.VarChar, 8).Value = gdg_asal
        sqlCmd.Parameters.Add("@kdgdng_akhir", SqlDbType.VarChar, 8).Value = gudang7an
        sqlCmd.Parameters.Add("@qty_in", SqlDbType.Decimal).Value = qty_inx
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub stprc_saldo_in(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal kd_satuanx As String, ByVal kd_ukuranx As String, ByVal qty_inx As Decimal, ByVal rpnilai As Decimal, ByVal BTRAN As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRAN
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_onstok_saldo_in"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 30).Value = bultah
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 30).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 30).Value = kd_satuanx
        sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 3).Value = kd_ukuranx
        sqlCmd.Parameters.Add("@tinggi", SqlDbType.Decimal).Value = 0
        sqlCmd.Parameters.Add("@lebar", SqlDbType.Decimal).Value = 0
        sqlCmd.Parameters.Add("@panjang", SqlDbType.Decimal).Value = 0
        sqlCmd.Parameters.Add("@onstok_in", SqlDbType.Decimal).Value = qty_inx
        sqlCmd.Parameters.Add("@vnilai", SqlDbType.Decimal, 30).Value = rpnilai
        sqlCmd.ExecuteNonQuery()
    End Sub
    Public Sub stprc_gdout(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal satuanx As String, ByVal kd_ukuranx As String, ByVal gdg_asal As String, ByVal gudang7an As String, ByVal qty_outx As Decimal, ByVal BTRANS As SqlTransaction)

        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRANS
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_stok_saldo_gudang_out"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 10).Value = bultah
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 22).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 3).Value = kd_ukuranx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 16).Value = satuanx
        sqlCmd.Parameters.Add("@kode_gudang", SqlDbType.VarChar, 8).Value = gdg_asal
        sqlCmd.Parameters.Add("@tinggi", SqlDbType.Decimal).Value = 0
        sqlCmd.Parameters.Add("@lebar", SqlDbType.Decimal).Value = 0
        sqlCmd.Parameters.Add("@panjang", SqlDbType.Decimal).Value = 0
        sqlCmd.Parameters.Add("@qty_out", SqlDbType.Decimal).Value = qty_outx
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub stprc_saldo(ByVal kd_cabangx As String, ByVal bultah As String, ByVal kd_stokx As String, ByVal kd_satuanx As String, ByVal kd_ukuranx As String, ByVal qty_inx As Decimal, ByVal rpnilai As Decimal, ByVal BTRAN As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = BTRAN
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "INV.dbo.inv_onstok_saldo_out"
        sqlCmd.Parameters.Add("@kd_cabang", SqlDbType.VarChar, 2).Value = kd_cabangx
        sqlCmd.Parameters.Add("@bultah", SqlDbType.VarChar, 30).Value = bultah
        sqlCmd.Parameters.Add("@kd_stok", SqlDbType.VarChar, 30).Value = kd_stokx
        sqlCmd.Parameters.Add("@kd_satuan", SqlDbType.VarChar, 30).Value = kd_satuanx
        sqlCmd.Parameters.Add("@kd_ukuran", SqlDbType.VarChar, 3).Value = kd_ukuranx
        sqlCmd.Parameters.Add("@tinggi", SqlDbType.Decimal).Value = 0
        sqlCmd.Parameters.Add("@lebar", SqlDbType.Decimal).Value = 0
        sqlCmd.Parameters.Add("@panjang", SqlDbType.Decimal).Value = 0
        sqlCmd.Parameters.Add("@onstok_out", SqlDbType.Decimal).Value = qty_inx
        sqlCmd.Parameters.Add("@vnilai", SqlDbType.Decimal, 30).Value = rpnilai
        sqlCmd.ExecuteNonQuery()
    End Sub
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

    Private Sub GV_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.GetRow(e.RowHandle).item("Qty") = 1
        GV.GetRow(e.RowHandle).item("No_Seq") = GV.RowCount
        'GV.GetRow(e.RowHandle).item("Tgl_Diperlukan") = Now
    End Sub

    Private Sub GV_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        If e.Column Is Kd_Stok Then
            Dim rw As DataRow
            rw = dS.Tables("VBarang").Select("Kode_Barang='" & e.Value & "'")(0)
            GV.GetRow(e.RowHandle).item("Satuan") = rw("Kd_Satuan")
        End If
        'If e.Column Is QTYPR Then
        '    GV.GetRow(e.RowHandle).item("Qty_sisa") = GV.GetRow(e.RowHandle).item("Qty").ToString - GV.GetRow(e.RowHandle).item("Qty_PR").ToString
        'End If
    End Sub
    Private Sub yayak()
        thisThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        GV.Columns("Qty").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GV.Columns("Qty").DisplayFormat.FormatString = "n0"
    End Sub
    'Private Sub btSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSimpan.Click
    '    If dtTanggal.Text = "" Then
    '        'showMessages("Tanggal Harap diisi !")
    '        MsgBox("Tanggal Harap diisi !")
    '        dtTanggal.Focus()
    '    End If
    '    save_click()
    'End Sub

    Private Sub GC_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GC.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Record Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar DPM") = MsgBoxResult.Yes Then
                    GV.DeleteSelectedRows()
                End If
            End If
        End If
    End Sub
    Private Sub refreshNomer(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        Dim j As Int16 = 1
        If STATE = "DELETE" Then Exit Sub
        For Each rw As DataRow In sender.Rows
            If rw.RowState <> DataRowState.Deleted Then
                For Each rwd As DataRow In ds4.Tables("PDD").Select("No_Seq=" & rw.Item("No_Seq"))

                    rwd("No_Seq") = i
                    j = 1
                    rw("No_Seq") = i
                    '  i += 1
                Next
                j = 1
                rw("No_Seq") = i
                i += 1
            End If
        Next
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data DPM ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            STATE = "DELETE"
            If Not ds3.Tables("PD") Is Nothing Then delete(ds3.Tables("PD").Rows)
            If Not ds4.Tables("PDD") Is Nothing Then delete(ds4.Tables("PDD").Rows)

            'ds3.Tables("PDD").Rows(0).Delete()

            save_click(True)
            cancel_click()
            STATE = ""
        End If
    End Sub
    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub
    'Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
    '    edit_click()
    'End Sub

    Private Sub GV_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        Dim isValid As Boolean = True
        If e.Row.item("Kd_Stok").ToString = "" Then
            isValid = False
            GV.SetColumnError(Kd_Stok, "Harap Memilih Jasa Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("Qty").ToString = "" Or Not IsNumeric(e.Row.item("Qty").ToString) Then
            isValid = False
            GV.SetColumnError(Qty, "Harap Mengisi Jumlah Kuantitas.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        ElseIf e.Row.item("Qty") <= 0 Then
            isValid = False
            GV.SetColumnError(Qty, "Harap Mengisi Jumlah Kuantitas Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        e.Valid = isValid
    End Sub

    Private Sub GVDetail_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GVDetail.CellValueChanged
        'showMessages(e.Column.Name)
        If e.Column.Name = "clBarang" Then
            Dim rw As DataRow
            Dim x As Object
            rw = dS.Tables("VBarang").Select("Kode_Barang='" & e.Value & "'")(0)
            'showMessages(rw("Kd_Satuan"))
            x = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
            x.GetRow(e.RowHandle).item("kd_satuan") = rw("Kd_Satuan")
            x.GetRow(e.RowHandle).item("spek_brg") = rw("spek_brg")
        End If
    End Sub

    Private Sub GVDetail_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GVDetail.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub GVDetail_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GVDetail.ValidateRow
        Dim isValid As Boolean = True
        Dim x As Object
        x = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        If e.Row.item("Kd_Stok").ToString = "" Then
            isValid = False
            MessageBox.Show("Harap Memilih Barang Telebih Dahulu.")
            'x.SetColumnError(Kd_Stok, "Harap Memilih Barang Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("Qty").ToString = "" Or Not IsNumeric(e.Row.item("Qty").ToString) Then
            isValid = False
            'x.SetColumnError(QTY, "Harap Mengisi Jumlah Dengan Benar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            MessageBox.Show("Harap Mengisi Jumlah Dengan Benar")
        ElseIf e.Row.item("Qty") <= 0 Then
            isValid = False
            'x.SetColumnError(QTY, "Harap Mengisi Jumlah Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            MessageBox.Show("Harap Mengisi Jumlah Dengan Benar")
        End If
        e.Valid = isValid
    End Sub

    Private Sub lkBarangTujuan_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lkBarangTujuan.EditValueChanged
        Dim rw As DataRow
        rw = dS.Tables("VBarang").Select("Kode_Barang='" & lkBarangTujuan.EditValue & "'")(0)
        Jumlah_Tujuan.EditValue = 1
        Satuan_Tujuan.EditValue = rw("kd_satuan")
        Nilai_Tujuan.EditValue = rw("harga")
    End Sub
End Class