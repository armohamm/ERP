Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base

Public Class frmRcnRphCen
    Dim ds1, ds2, ds3 As New DataSet
    Dim da1, da2, da3 As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
    Dim BTRANS As SqlTransaction
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA As SqlDataAdapter
    Dim DAD As SqlDataAdapter
    Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Dim myBuilder As New SqlCommandBuilder
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
        'With Me
        '    .btAdd.Enabled = btnadd
        '    .btCancel.Enabled = btnCancel
        '    .btDel.Enabled = btnDelete
        '    .btEdit.Enabled = btnEdit
        '    .btSave.Enabled = btnSave
        'End With
    End Sub
    Private Sub frmRcnRph_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)

        If Not ds1.Tables("JDWKRJ") Is Nothing Then ds1.Tables("JDWKRJ").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='JDWKRJ'", sqlconn))
        da1.Fill(ds1, "JDWKRJ")
        txtJadwal.Properties.DataSource = ds1.Tables("JDWKRJ")

        'btnEdit = False
        'btnDelete = False
        setStatus()
        State = "ADD"
        reload()

        Dim colM(0), colSales(1), colSubsales(1) As DataColumn
        Dim colD(0) As DataColumn
        Dim rel, rel2 As DataRelation

        colM(0) = ds1.Tables("PROD").Columns("kd_jenis")

        colD(0) = ds1.Tables("SALES").Columns("kd_jenis")

        colSales(0) = ds1.Tables("SALES").Columns("no_sp")
        colSales(1) = ds1.Tables("SALES").Columns("kd_stok")

        colSubsales(0) = ds1.Tables("SUBSALES").Columns("No_sp")
        colSubsales(1) = ds1.Tables("SUBSALES").Columns("Kd_Stok")


        rel = ds1.Relations.Add("Detail", colM, colD, True)
        rel2 = ds1.Relations.Add("Sub", colSales, colSubsales, False)
        gc.LevelTree.Nodes.Add("Detail", gv).Nodes.Add("Sub", subGV)




    End Sub

    Private Sub reload()
        If State = "ADD" Then
            If Not ds1.Tables("SUBSALES") Is Nothing Then ds1.Tables("SUBSALES").Clear()
            If Not ds1.Tables("SALES") Is Nothing Then ds1.Tables("SALES").Clear()
            If Not ds1.Tables("PROD") Is Nothing Then ds1.Tables("PROD").Clear()


            da1 = New SqlDataAdapter(New SqlCommand("select * from SALES.dbo.SALES_SOBOX_D", sqlconn))
            da1.Fill(ds1, "SUBSALES")

            Dim dr As SqlDataReader

            da2 = New SqlDataAdapter(New SqlCommand("select *, '' Nama_Jenis from PROD.dbo.PROD_rcn_prod_m where 1=0", sqlconn))
            da2.Fill(ds1, "PROD")
            dr = New SqlClient.SqlCommand("select v.*, isnull(k.jumlah_kapasitas,0) jml_kapasitas from " & _
                                          "(select distinct(kd_jenis), nama_jenis, tipe_trans from PROD.dbo.PRODV_MON_SO where Len(no_sp) > 10 And qty_sisa_prod > 0" & _
                                          " and departement='" & kddep & "' and vol > 0 " & _
                                          ") v " & _
                                          "left join " & _
                                          "(select * from SIF.dbo.SIF_kapasitas where kegiatan_ppic='03') k " & _
                                          "on v.kd_jenis=k.kd_jenis", sqlconn).ExecuteReader
            While dr.Read
                Dim rwm As DataRow = ds1.Tables("PROD").NewRow
                rwm("Nama_Jenis") = dr.Item("nama_jenis")
                rwm("kd_jenis") = dr.Item("kd_jenis")
                rwm("tipe_trans") = dr.Item("tipe_trans")
                rwm("jml_kapasitas") = dr.Item("jml_kapasitas")
                ds1.Tables("PROD").Rows.Add(rwm)
            End While
            dr.Close()

            gc.DataSource = ds1.Tables("PROD")
            da3 = New SqlDataAdapter(New SqlCommand("select t.*,0.00 nilai,'N' simpan, 0 kd_jenis, '' Nama_Jenis, '' Nama_Barang,'' Sisa, '' tgl_kirim,'' kd_stok, '' prioritas from PROD.dbo.PROD_rcn_prod_d t where 1=0", sqlconn))
            da3.Fill(ds1, "SALES")
            dr = New SqlClient.SqlCommand("select v.*, ISNULL(i.nilai,0) nilai " & _
                                                               "from PROD.dbo.PRODV_MON_SO v " & _
                                                               "left join SIF.dbo.SIF_Barang b " & _
                                                               "on v.Kd_Stok = b.Kode_Barang " & _
                                                               "left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '02') i " & _
                                                               "on b.kd_jenis = i.kd_jenis and b.kd_tipe = i.kd_tipe and b.kd_ukuran = i.kd_ukuran " & _
                                                               "where(Len(v.no_sp) > 10 And v.qty_sisa_prod > 0 and v.vol > 0 " & _
                                                               " and departement='" & kddep & "' " & _
                                                               ") " & _
                                                               "order by v.No_sp, v.No_seq", sqlconn).ExecuteReader
            While dr.Read
                Dim rw As DataRow = ds1.Tables("SALES").NewRow
                rw("no_sp") = dr.Item("No_sp")
                rw("no_sp_dtl") = dr.Item("No_seq")
                rw("Sisa") = dr.Item("Qty_Sisa_Prod")
                rw("kd_stok") = dr.Item("kd_stok")
                rw("Nama_Barang") = dr.Item("Nama_Barang")
                rw("Nama_Jenis") = dr.Item("Nama_Jenis")
                rw("kd_jenis") = dr.Item("kd_jenis")
                rw("tgl_kirim") = dr.Item("tgl_kirim")
                rw("prioritas") = dr.Item("prioritas")
                rw("jumlah") = dr.Item("Qty_Sisa_Prod")
                rw("jml_indeks") = dr.Item("Qty_Sisa_Prod") * dr.Item("nilai")
                rw("nilai") = dr.Item("nilai")
                rw("simpan") = "N"
                rw("vol") = dr.Item("Qty_Sisa_Prod")

                ds1.Tables("SALES").Rows.Add(rw)
            End While
            dr.Close()
            txtTgl_Rph.Text = DateTime.Today
            txtDPB.Text = ""

        ElseIf State = "EDIT" Then
            If Not ds1.Tables("SUBSALES") Is Nothing Then ds1.Tables("SUBSALES").Clear()
            If Not ds1.Tables("SALES") Is Nothing Then ds1.Tables("SALES").Clear()
            If Not ds1.Tables("PROD") Is Nothing Then ds1.Tables("PROD").Clear()

            Dim dr As SqlDataReader

            da1 = New SqlDataAdapter(New SqlCommand("select * from SALES.dbo.SALES_SOBOX_D", sqlconn))
            da1.Fill(ds1, "SUBSALES")

            da2 = New SqlDataAdapter(New SqlCommand("select *, '' Nama_Jenis from PROD.dbo.PROD_rcn_prod_m where 1=0", sqlconn))
            da2.Fill(ds1, "PROD")
            'dr = New SqlClient.SqlCommand("select v.*, isnull(k.jumlah_kapasitas,0) jml_kapasitas from " & _
            '                              "(select distinct(kd_jenis), nama_jenis, tipe_trans from PROD.dbo.PRODV_MON_SO where Len(no_sp) > 10 And qty_sisa_prod > 0" & _
            '                              " and departement='" & kddep & "'  " & _
            '                              ") v " & _
            '                              "left join " & _
            '                              "(select * from SIF.dbo.SIF_kapasitas where kegiatan_ppic='03') k " & _
            '                              "on v.kd_jenis=k.kd_jenis", sqlconn).ExecuteReader
            dr = New SqlClient.SqlCommand("select J.*, isnull(K.jumlah_kapasitas,0) jml_kapasitas from ( " & _
                                          "select distinct(kd_jenis), nama_jenis, tipe_trans from PROD.dbo.PRODV_MON_SO V where V.Qty_Sisa_Prod>0 and len(V.No_sp)>10 and V.vol>0" & _
                                          "union " & _
                                          "select distinct(M.kd_jenis),SJ.Nama_Jenis nama_jenis, M.tipe_trans from PROD.dbo.PROD_rcn_prod_m M left join SIF.dbo.SIF_Jenis_Barang SJ on M.kd_jenis=SJ.Kd_Jns_Brg  where M.no_rph in (select no_rph from PROD.dbo.PROD_rcn_prod_d D where D.vol>0) " & _
                                          ") J " & _
                                          "left join (select * from SIF.dbo.SIF_kapasitas where kegiatan_ppic='03') K on J.kd_jenis=K.kd_jenis", sqlconn).ExecuteReader
            While dr.Read
                Dim rwm As DataRow = ds1.Tables("PROD").NewRow
                rwm("Nama_Jenis") = dr.Item("nama_jenis")
                rwm("kd_jenis") = dr.Item("kd_jenis")
                rwm("tipe_trans") = dr.Item("tipe_trans")
                rwm("jml_kapasitas") = dr.Item("jml_kapasitas")
                ds1.Tables("PROD").Rows.Add(rwm)
            End While
            dr.Close()

            gc.DataSource = ds1.Tables("PROD")

            da3 = New SqlDataAdapter(New SqlCommand("select t.*,0.00 nilai, 0 kd_jenis, '' Nama_Jenis, '' Nama_Barang,'' Sisa, '' tgl_kirim, '' prioritas, 'N' simpan from PROD.dbo.PROD_rcn_prod_d t where 1=0", sqlconn))
            da3.Fill(ds1, "SALES")
            Dim qstr As String = "select uni.*,ISNULL(i.nilai,0) nilai from (  " & _
"select v.*, 0 jumlah, 0 jml_indeks, 'N' simpan " & _
"from PROD.dbo.PRODV_MON_SO v " & _
"left join PROD.dbo.PROD_rcn_prod_d d on v.no_sp = d.no_sp and v.no_seq=d.no_sp_dtl " & _
"where Len(v.no_sp) > 10 And v.qty_sisa_prod > 0 and v.vol > 0 and departement='" & kddep & "' and d.no_sp is null " & _
"UNION " & _
"select v.*, d.jumlah, d.jml_indeks, 'Y' simpan " & _
"from PROD.dbo.PROD_rcn_prod_d d " & _
"left join PROD.dbo.PRODV_MON_SO v on v.No_sp=d.no_sp and v.No_seq=d.no_sp_dtl " & _
"where d.no_rph='" & txtDPB.Text & "' " & _
") uni  " & _
"left join SIF.dbo.SIF_Barang b on uni.Kd_Stok = b.Kode_Barang " & _
"left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '02') i on b.kd_jenis = i.kd_jenis and b.kd_tipe = i.kd_tipe and b.kd_ukuran = i.kd_ukuran " & _
"order by uni.no_sp, uni.no_seq"
            dr = New SqlClient.SqlCommand(qstr, sqlconn).ExecuteReader

            While dr.Read
                Dim rw As DataRow = ds1.Tables("SALES").NewRow
                rw("no_sp") = dr.Item("No_sp")
                rw("no_sp_dtl") = dr.Item("No_seq")
                rw("Sisa") = dr.Item("Qty_Sisa_Prod") + dr.Item("jumlah")
                rw("Nama_Barang") = dr.Item("Nama_Barang")
                rw("Nama_Jenis") = dr.Item("Nama_Jenis")
                rw("kd_jenis") = dr.Item("kd_jenis")
                rw("tgl_kirim") = dr.Item("tgl_kirim")
                rw("prioritas") = dr.Item("prioritas")
                rw("jumlah") = dr.Item("jumlah")
                rw("jml_indeks") = dr.Item("jml_indeks")
                rw("nilai") = dr.Item("nilai")
                rw("vol") = dr.Item("vol")
                rw("simpan") = dr.Item("simpan")

                ds1.Tables("SALES").Rows.Add(rw)
            End While
            dr.Close()
        End If
    End Sub

    Public Sub add_click()
        State = "ADD"
        reload()

        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False

        setStatus()
    End Sub

    Public Sub edit_click()


        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select M.tanggal [Tanggal], M.no_rph [No RPH], S.Desc_Data [Jadwal Kerja]  from (select distinct no_rph from PROD.dbo.PROD_rcn_prod_d where vol>0) D " & _
                                                                    "left join PROD.dbo.PROD_rcn_prod_m M on M.no_rph=D.no_rph " & _
                                                                    "left join SIF.dbo.SIF_Gen_Reff_D S on M.kd_jadwal=S.Id_Data " & _
                                                                    "where S.Id_Ref_Data='JDWKRJ'", sqlconn))

        da3.Fill(ds3, "lookup_so")
        frmCari.set_dso(ds3.Tables("lookup_so"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then

            State = "EDIT"

            txtJadwal.Properties.ReadOnly = True
            txtDPB.Text = frmCari.row("No RPH")
            txtJadwal.Text = frmCari.row("Jadwal Kerja")
            txtJadwal.Properties.ReadOnly = False

            reload()
            btnSave = True
            btnadd = False
            btnEdit = False
            btnDelete = True
            btnCancel = True
            setStatus()
            Me.Enabled = True
        Else
            cancel_click()
        End If
    End Sub

    Public Sub save_click()
        If State = "ADD" Then '----------Simpan ADD
            Dim tgl As Date = getTanggal()

            If txtJadwal.EditValue = Nothing Then
                MessageBox.Show("Jadwal Kerja Belum Dipilih")
                Exit Sub
            End If

            Dim filledrow As Integer = ds1.Tables("SALES").Select("simpan='Y'").Count
            If filledrow = 0 Then
                MessageBox.Show("Jumlah Rencana Produksi Belum Ada Yang Dipilih")
                Exit Sub
            End If

            Dim BTRANS As SqlTransaction
            mb = New SqlClient.SqlCommandBuilder(da2)
            da2.UpdateCommand = mb.GetUpdateCommand()
            da2.InsertCommand = mb.GetInsertCommand()
            da2.DeleteCommand = mb.GetDeleteCommand()

            mb = New SqlClient.SqlCommandBuilder(da3)
            da3.UpdateCommand = mb.GetUpdateCommand()
            da3.InsertCommand = mb.GetInsertCommand()
            da3.DeleteCommand = mb.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            da2.UpdateCommand.Transaction = BTRANS
            da2.InsertCommand.Transaction = BTRANS
            da2.DeleteCommand.Transaction = BTRANS

            da3.UpdateCommand.Transaction = BTRANS
            da3.InsertCommand.Transaction = BTRANS
            da3.DeleteCommand.Transaction = BTRANS

            Dim notrans As String
            notrans = getNoTrans("RPHCEN", txtTgl_Rph.DateTime, BTRANS)
            txtDPB.Text = notrans

            For i = ds1.Tables("SALES").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = ds1.Tables("SALES").Rows(i)

                If rows("simpan") = "Y" Then
                    rows("tanggal") = tgl 'txtTgl_Rph.DateTime
                    rows("no_rph") = txtDPB.Text
                    rows("last_create_date") = tgl
                    rows("last_created_by") = username
                    rows("last_update_date") = tgl
                    rows("last_updated_by") = username
                    rows("program_name") = Me.Name
                    rows("kd_cabang") = kdcabang
                    rows("kd_departemen") = kddep
                Else
                    ds1.Tables("SALES").Rows(i).Delete()
                End If
                
            Next

            Dim mrow As DataRow
            For i = ds1.Tables("PROD").Rows.Count - 1 To 0 Step -1
                mrow = ds1.Tables("PROD").Rows(i)
                If mrow.GetChildRows("Detail").Count() = 0 Then
                    mrow.Delete()
                Else
                    mrow("no_rph") = notrans
                    mrow("tanggal") = tgl 'txtTgl_Rph.DateTime
                    mrow("kd_jadwal") = txtJadwal.EditValue
                    mrow("kd_cabang") = kdcabang
                    mrow("kd_departemen") = kddep
                    mrow("last_create_date") = tgl
                    mrow("last_created_by") = username
                    mrow("last_update_date") = tgl
                    mrow("last_updated_by") = username
                    mrow("program_name") = Me.Name


                End If
            Next

            Try

                da2.Update(ds1.Tables("PROD"))
                da3.Update(ds1.Tables("SALES"))
                ds1.Tables("PROD").AcceptChanges()
                ds1.Tables("SALES").AcceptChanges()

                State = "EDIT"
                BTRANS.Commit()
                btnSave = False
                setStatus()
                showMessages("Data Berhasil Disimpan")
            Catch e As Exception
                BTRANS.Rollback()
                ds1.Tables("SALES").RejectChanges()
                ds1.Tables("PROD").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

                txtDPB.Text = ""
                txtJadwal.EditValue = Nothing
                reload()
            End Try
        ElseIf State = "EDIT" Then '------------Simpan EDIT
            Dim tgl As Date = getTanggal()

            If txtJadwal.EditValue = Nothing Then
                MessageBox.Show("Jadwal Kerja Belum Dipilih")
                Exit Sub
            End If

            Dim filledrow As Integer = ds1.Tables("SALES").Select("simpan='Y'").Count
            If filledrow = 0 Then
                MessageBox.Show("Jumlah Rencana Produksi Belum Ada Yang Diisi")
                Exit Sub
            End If

            Dim BTRANS As SqlTransaction
            mb = New SqlClient.SqlCommandBuilder(da2)
            da2.UpdateCommand = mb.GetUpdateCommand()
            da2.InsertCommand = mb.GetInsertCommand()
            da2.DeleteCommand = mb.GetDeleteCommand()

            mb = New SqlClient.SqlCommandBuilder(da3)
            da3.UpdateCommand = mb.GetUpdateCommand()
            da3.InsertCommand = mb.GetInsertCommand()
            da3.DeleteCommand = mb.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            da2.UpdateCommand.Transaction = BTRANS
            da2.InsertCommand.Transaction = BTRANS
            da2.DeleteCommand.Transaction = BTRANS

            da3.UpdateCommand.Transaction = BTRANS
            da3.InsertCommand.Transaction = BTRANS
            da3.DeleteCommand.Transaction = BTRANS

            Dim notrans As String
            notrans = txtDPB.Text
            Dim dr As SqlDataReader
            Dim qstr As String
            qstr = "delete from PROD.dbo.PROD_rcn_prod_d where no_rph='" & notrans & "'"
            dr = New SqlClient.SqlCommand(qstr, sqlconn, BTRANS).ExecuteReader
            dr.Close()
            qstr = "delete from PROD.dbo.PROD_rcn_prod_m where no_rph='" & notrans & "'"
            dr = New SqlClient.SqlCommand(qstr, sqlconn, BTRANS).ExecuteReader
            dr.Close()
            'da3 = New SqlDataAdapter(New SqlCommand("delete from PROD.dbo.PROD_rcn_prod_d t where no_rph='" & notrans & "'", sqlconn, BTRANS))
            'da2 = New SqlDataAdapter(New SqlCommand("delete from PROD.dbo.PROD_rcn_prod_m t where no_rph='" & notrans & "'", sqlconn, BTRANS))

            For i = ds1.Tables("SALES").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = ds1.Tables("SALES").Rows(i)
                If rows("simpan") = "Y" Then
                    'rows("tanggal") = txtTgl_Rph.DateTime
                    rows("no_rph") = notrans
                    rows("last_update_date") = tgl
                    rows("last_updated_by") = username
                    rows("program_name") = Me.Name
                    rows("kd_cabang") = kdcabang
                    rows("kd_departemen") = kddep
                Else
                    ds1.Tables("SALES").Rows(i).Delete()
                End If
               
            Next

            Dim mrow As DataRow
            For i = ds1.Tables("PROD").Rows.Count - 1 To 0 Step -1
                mrow = ds1.Tables("PROD").Rows(i)
                If mrow.GetChildRows("Detail").Count() = 0 Then
                    mrow.Delete()
                Else
                    mrow("no_rph") = notrans
                    'mrow("tanggal") = txtTgl_Rph.DateTime
                    mrow("kd_jadwal") = txtJadwal.EditValue
                    mrow("kd_cabang") = kdcabang
                    mrow("kd_departemen") = kddep
                    mrow("last_update_date") = tgl
                    mrow("last_updated_by") = username
                    mrow("program_name") = Me.Name


                End If
            Next

            Try

                da2.Update(ds1.Tables("PROD"))
                da3.Update(ds1.Tables("SALES"))
                ds1.Tables("PROD").AcceptChanges()
                ds1.Tables("SALES").AcceptChanges()

                State = "EDIT"
                BTRANS.Commit()
                btnSave = False
                setStatus()
                showMessages("Data Berhasil Disimpan")
            Catch e As Exception
                BTRANS.Rollback()
                ds1.Tables("SALES").RejectChanges()
                ds1.Tables("PROD").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

                State = "EDIT"
                reload()
            End Try
        End If

    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            showMessages("Deleted..")
            'cancel_click()
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
    End Sub
    Private Sub gv_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gv.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gv_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gv.ValidateRow
        Dim isValid As Boolean = True
        If e.Row("jumlah") > e.Row("Sisa") Then
            gv.SetColumnError(Qty_Produksi, "Jumlah Rencana Produksi Terlalu Banyak", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            MessageBox.Show("Jumlah Rencana Produksi Terlalu Banyak")
            isValid = False
        Else
            e.Row("jml_indeks") = e.Row("jumlah") * e.Row("nilai")
        End If
        e.Valid = isValid
    End Sub

    Private Sub gv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gv.DoubleClick
        Dim nosp As ColumnView = sender
        Dim nospseq As ColumnView = sender
        nosp.GetFocusedRowCellValue("no_sp")
        nospseq.GetFocusedRowCellValue("no_sp_dtl")

        If nosp.GetFocusedRowCellValue("no_sp") <> "" Then
            Dim dr As SqlDataReader = New SqlClient.SqlCommand("select * from PROD.dbo.PRODV_MON_SO where no_sp='" & nosp.GetFocusedRowCellValue("no_sp") & "' and no_seq='" & nospseq.GetFocusedRowCellValue("no_sp_dtl") & "' order by No_sp, No_seq", sqlconn).ExecuteReader
            dr.Read()
            frmDtlSO.nosp.Text = dr.Item("no_sp").ToString
            frmDtlSO.noseq.Text = dr.Item("no_seq").ToString
            frmDtlSO.cust.Text = dr.Item("Nama_Customer").ToString
            frmDtlSO.barang.Text = dr.Item("Nama_Barang").ToString
            frmDtlSO.Qty_Order.Text = dr.Item("Qty_Order").ToString
            frmDtlSO.Qty_Rcn_Krm.Text = dr.Item("Qty_Rcn_Krm").ToString
            frmDtlSO.Qty_Rcn_Prod.Text = dr.Item("Qty_Rcn_Prod").ToString
            frmDtlSO.Qty_Sisa_Krm.Text = dr.Item("Qty_Sisa_Krm").ToString
            frmDtlSO.Qty_Sisa_Prod.Text = dr.Item("Qty_Sisa_Prod").ToString
            frmDtlSO.tanggal.Text = dr.Item("tgl_kirim").ToString
            frmDtlSO.Qty_Rcn_Prod.Text = dr.Item("prioritas").ToString
            frmDtlSO.ShowDialog()
            dr.Close()
        End If
    End Sub
End Class