Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports System.Data.SqlClient

Public Class frmRcnKrmCen
    Dim ds1, ds2, ds3 As New DataSet
    Dim da1, da2, da3, da4 As New SqlDataAdapter
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
    Dim tipetrans As String
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

    Private Sub reload()
        Dim dr As SqlDataReader
        dr = New SqlClient.SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='KGTPPIC' and Id_Data='02'", sqlconn).ExecuteReader
        dr.Read()
        tipetrans = dr.Item("Val_kode1")
        dr.Close()


        If State = "ADD" Then
            If Not ds1.Tables("SUBKIRIM") Is Nothing Then ds1.Tables("SUBKIRIM").Clear()
            If Not ds1.Tables("KIRIM") Is Nothing Then ds1.Tables("KIRIM").Clear()
            If Not ds1.Tables("MASTER") Is Nothing Then ds1.Tables("MASTER").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("select * from SALES.dbo.SALES_SOBOX_D", sqlconn))
            da1.Fill(ds1, "SUBKIRIM")
            'If Not ds1.Tables("JENIS") Is Nothing Then ds1.Tables("JENIS").Clear()
            If Not ds1.Tables("QTY") Is Nothing Then ds1.Tables("QTY").Clear()

            'da1 = New SqlDataAdapter(New SqlCommand("select distinct(v.kd_jenis), v.nama_jenis, k.jumlah_kapasitas, v.tipe_trans from sif.dbo.sif_kapasitas k, PROD.dbo.PRODV_MON_SO v where v.kd_jenis=k.kd_jenis and (Len(v.no_sp) > 10 And v.qty_sisa > 0)", sqlconn))
            'da1.Fill(ds1, "JENIS")

            da2 = New SqlDataAdapter(New SqlCommand("select t.*, '' nama_jenis, '' nama_barang,'' qty_order,'' sisa, '' tgl_kirim, '' prioritas,0.00 nilai, '' kd_stok, '' nama_customer, '' nama_wilayah, '' nama_area from PROD.dbo.PROD_rcn_krm_d t where 1=0", sqlconn))
            da2.Fill(ds1, "KIRIM")

            da3 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rcn_krm_m where 1=0", sqlconn))
            da3.Fill(ds1, "MASTER")
            Dim rwm As DataRow = ds1.Tables("MASTER").NewRow
            rwm("tipe_trans") = tipetrans
            ds1.Tables("MASTER").Rows.Add(rwm)

            da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PRODV_MON_STOCK", sqlconn))
            da4.Fill(ds1, "QTY")
            gc2.DataSource = ds1.Tables("QTY")
            dr = New SqlClient.SqlCommand("select v.*, ISNULL(i.nilai,0) nilai " & _
                                                               "from PROD.dbo.PRODV_MON_SO v " & _
                                                               "left join SIF.dbo.SIF_Barang b " & _
                                                               "on v.Kd_Stok = b.Kode_Barang " & _
                                                               "left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '02') i " & _
                                                               "on b.kd_jenis = i.kd_jenis and b.kd_tipe = i.kd_tipe and b.kd_ukuran = i.kd_ukuran " & _
                                                               "where(Len(v.no_sp) > 10 And v.qty_sisa_krm > 0 " & _
                                                               " and departement='" & kddep & "' and tipe_trans='" & tipetrans & "'" & _
                                                               ") " & _
                                                               "order by v.No_sp, v.No_seq", sqlconn).ExecuteReader

            'MsgBox(dr.HasRows)
            While dr.Read
                Dim rw As DataRow = ds1.Tables("KIRIM").NewRow
                rw("kd_cabang") = getKodeCabang()
                rw("tanggal") = getTanggal()
                rw("No_sp") = dr.Item("No_sp")
                rw("no_sp_dtl") = dr.Item("no_seq")
                rw("jumlah") = 0
                rw("jml_indeks") = 0
                rw("rec_stat") = vbNullString
                rw("program_name") = Me.Name
                rw("Nama_Jenis") = dr.Item("Nama_Jenis")
                rw("nama_customer") = dr.Item("Nama_Customer")
                rw("nama_wilayah") = dr.Item("Nama_Wilayah")
                rw("nama_area") = dr.Item("Nama_Area")
                rw("nama_barang") = dr.Item("Nama_Barang")
                rw("qty_order") = dr.Item("Qty_Order")
                rw("sisa") = dr.Item("Qty_Sisa_Krm")
                rw("tgl_kirim") = dr.Item("tgl_kirim")
                rw("prioritas") = dr.Item("prioritas")
                rw("nilai") = dr.Item("nilai")
                rw("kd_stok") = dr.Item("kd_stok")
                ds1.Tables("KIRIM").Rows.Add(rw)
            End While
            dr.Close()
            gc.DataSource = ds1.Tables("KIRIM")
            txtTanggal.Text = DateTime.Today
            txtNoTrans.Text = ""
        ElseIf State = "EDIT" Then
            If Not ds1.Tables("SUBKIRIM") Is Nothing Then ds1.Tables("SUBKIRIM").Clear()
            If Not ds1.Tables("KIRIM") Is Nothing Then ds1.Tables("KIRIM").Clear()
            If Not ds1.Tables("MASTER") Is Nothing Then ds1.Tables("MASTER").Clear()
            If Not ds1.Tables("QTY") Is Nothing Then ds1.Tables("QTY").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("select * from SALES.dbo.SALES_SOBOX_D", sqlconn))
            da1.Fill(ds1, "SUBKIRIM")

            da2 = New SqlDataAdapter(New SqlCommand("select t.*, '' nama_jenis, '' nama_barang,'' qty_order,'' sisa, '' tgl_kirim, '' prioritas,0.00 nilai, '' kd_stok, '' nama_customer, '' nama_wilayah, '' nama_area  from PROD.dbo.PROD_rcn_krm_d t where 1=0", sqlconn))
            da2.Fill(ds1, "KIRIM")

            da3 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rcn_krm_m where 1=0", sqlconn))
            da3.Fill(ds1, "MASTER")
            Dim rwm As DataRow = ds1.Tables("MASTER").NewRow
            rwm("tipe_trans") = tipetrans
            ds1.Tables("MASTER").Rows.Add(rwm)
            da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PRODV_MON_STOCK", sqlconn))
            da4.Fill(ds1, "QTY")
            gc2.DataSource = ds1.Tables("QTY")
            'Dim dr As SqlDataReader = New SqlClient.SqlCommand("select * from PROD.dbo.PRODV_MON_SO where LEN(no_sp) > 10 and qty_sisa > 0 order by No_sp, No_seq", sqlconn).ExecuteReader
            dr = New SqlClient.SqlCommand("select uni.*,ISNULL(i.nilai,0) nilai from (   " & _
                "select v.*, 0 jumlah, 0 jml_indeks  " & _
                "from PROD.dbo.PRODV_MON_SO v  " & _
                "left join PROD.dbo.PROD_rcn_krm_d d on v.no_sp = d.no_sp and v.no_seq=d.no_sp_dtl  " & _
                "where Len(v.no_sp) > 10 And v.qty_sisa_krm > 0 and departement='" & kddep & "' and d.no_sp is null and tipe_trans='" & tipetrans & "'   " & _
                "UNION  " & _
                "select v.*, d.jumlah, d.jml_indeks  " & _
                "from PROD.dbo.PROD_rcn_krm_d d  " & _
                "left join PROD.dbo.PRODV_MON_SO v on v.No_sp=d.no_sp and v.No_seq=d.no_sp_dtl  " & _
                "where d.no_trans='" & txtNoTrans.Text & "' " & _
                ") uni   " & _
                "left join SIF.dbo.SIF_Barang b on uni.Kd_Stok = b.Kode_Barang  " & _
                "left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '02') i on b.kd_jenis = i.kd_jenis and b.kd_tipe = i.kd_tipe and b.kd_ukuran = i.kd_ukuran  " & _
                "order by uni.no_sp, uni.no_seq", sqlconn).ExecuteReader

            While dr.Read

                Dim rw As DataRow = ds1.Tables("KIRIM").NewRow
                rw("kd_cabang") = getKodeCabang()
                rw("tanggal") = getTanggal()
                rw("No_sp") = dr.Item("No_sp")
                rw("no_sp_dtl") = dr.Item("no_seq")
                rw("jumlah") = dr.Item("jumlah")
                rw("jml_indeks") = dr.Item("jml_indeks")
                rw("rec_stat") = vbNullString
                rw("program_name") = Me.Name
                rw("Nama_Jenis") = dr.Item("Nama_Jenis")
                rw("nama_customer") = dr.Item("Nama_Customer")
                rw("nama_wilayah") = dr.Item("Nama_Wilayah")
                rw("nama_area") = dr.Item("Nama_Area")
                rw("nama_barang") = dr.Item("Nama_Barang")
                rw("qty_order") = dr.Item("Qty_Order")
                rw("sisa") = dr.Item("Qty_Sisa_Krm") + dr.Item("jumlah")
                rw("tgl_kirim") = dr.Item("tgl_kirim")
                rw("prioritas") = dr.Item("prioritas")
                rw("nilai") = dr.Item("nilai")
                rw("kd_stok") = dr.Item("kd_stok")


                ds1.Tables("KIRIM").Rows.Add(rw)
            End While
            dr.Close()
            gc.DataSource = ds1.Tables("KIRIM")
        End If



    End Sub

    Private Sub frmRcnKrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        btnEdit = True
        btnDelete = False
        setStatus()
        State = "ADD"
        reload()
        Dim colSales(1), colSubsales(1) As DataColumn
        Dim rel As DataRelation

        colSales(0) = ds1.Tables("KIRIM").Columns("no_sp")
        colSales(1) = ds1.Tables("KIRIM").Columns("kd_stok")

        colSubsales(0) = ds1.Tables("SUBKIRIM").Columns("No_sp")
        colSubsales(1) = ds1.Tables("SUBKIRIM").Columns("Kd_Stok")


        rel = ds1.Relations.Add("Detail", colSales, colSubsales, False)
        gc.LevelTree.Nodes.Add("Detail", gvCen)

        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Kendaraan order by Nama_Kendaraan", sqlconn))
        da1.Fill(ds1, "Kendaraan")
        txtKendaraan.Properties.DataSource = ds1.Tables("Kendaraan")
    End Sub
    Public Sub call_procedure(ByVal vnotrans As String, ByVal btrans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader

        Dim sqlCmd1 As New SqlCommand
        sqlCmd1.Connection = sqlconn
        sqlCmd1.Transaction = btrans
        sqlCmd1.CommandType = CommandType.StoredProcedure
        sqlCmd1.CommandText = "PROD.dbo.prodp_ins_rcn_rkp_krm"
        sqlCmd1.Parameters.Add("@vno_rph", SqlDbType.Char).Value = vnotrans 'frmCari.row("NO TRANS")
        dr = sqlCmd1.ExecuteReader
        dr.Close()

        Dim sqlCmd2 As New SqlCommand
        sqlCmd2.Connection = sqlconn
        sqlCmd2.Transaction = btrans
        sqlCmd2.CommandType = CommandType.StoredProcedure
        sqlCmd2.CommandText = "PROD.dbo.prodp_ins_qty_booked_in"
        sqlCmd2.Parameters.Add("@vno_trans", SqlDbType.Char).Value = vnotrans 'frmCari.row("NO TRANS")
        dr = sqlCmd2.ExecuteReader
        dr.Close()

        'sqlconn.Close()
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
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select P.tanggal Tanggal, P.no_trans [No Transaksi] from PROD.dbo.PROD_rcn_krm_m P " & _
                                                                    "left join SIF.dbo.SIF_Gen_Reff_D S on P.tipe_trans=S.Val_kode1 " & _
                                                                    "where S.Id_Ref_Data='KGTPPIC' and S.Id_Data='02'" & _
                                                                    "group by P.no_trans, P.tanggal order by P.tanggal desc, P.no_trans desc", sqlconn))

        da3.Fill(ds3, "lookup_so")
        frmCari.set_dso(ds3.Tables("lookup_so"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then

            State = "EDIT"


            txtNoTrans.Text = frmCari.row("No Transaksi")
            txtTanggal.DateTime = frmCari.row("Tanggal")
            Dim dr As SqlDataReader
            dr = New SqlClient.SqlCommand("select * from PROD.dbo.PROD_rcn_krm_m where no_trans='" & txtNoTrans.Text & "' ", sqlconn).ExecuteReader
            dr.Read()
            txtKendaraan.EditValue = dr.Item("kd_kendaraan")
            txtKapasitas.Text = dr.Item("jml_kapasitas")
            dr.Close()
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
        Dim notrans As String
        Dim tgl As Date = getTanggal()
        If State = "ADD" Then
            Dim filledrow As Integer = ds1.Tables("KIRIM").Select("jumlah>0").Count
            If filledrow = 0 Then
                MessageBox.Show("Jumlah Rencana Kirim Belum Ada Yang Diisi")
                Exit Sub
            End If

            Dim BTRANS As SqlTransaction
            mb = New SqlClient.SqlCommandBuilder(da3)
            da3.UpdateCommand = mb.GetUpdateCommand()
            da3.InsertCommand = mb.GetInsertCommand()
            da3.DeleteCommand = mb.GetDeleteCommand()

            mb = New SqlClient.SqlCommandBuilder(da2)
            da2.UpdateCommand = mb.GetUpdateCommand()
            da2.InsertCommand = mb.GetInsertCommand()
            da2.DeleteCommand = mb.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            da3.UpdateCommand.Transaction = BTRANS
            da3.InsertCommand.Transaction = BTRANS
            da3.DeleteCommand.Transaction = BTRANS

            da2.UpdateCommand.Transaction = BTRANS
            da2.InsertCommand.Transaction = BTRANS
            da2.DeleteCommand.Transaction = BTRANS
            notrans = getNoTrans("PRODKRM", txtTanggal.DateTime, BTRANS)


            For i = ds1.Tables("KIRIM").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = ds1.Tables("KIRIM").Rows(i)
                If Not TypeOf rows("jumlah") Is DBNull Then
                    If rows("jumlah") > 0 Then
                        rows("tanggal") = tgl
                        rows("no_trans") = notrans
                        rows("last_create_date") = tgl
                        rows("last_created_by") = username
                        rows("last_update_date") = tgl
                        rows("last_updated_by") = username
                        rows("program_name") = Me.Name
                        rows("kd_cabang") = kdcabang
                        rows("kd_departemen") = kddep
                    Else
                        ds1.Tables("KIRIM").Rows(i).Delete()
                    End If
                Else
                    ds1.Tables("KIRIM").Rows(i).Delete()
                End If
            Next

            Dim rwm As DataRow = ds1.Tables("MASTER").Rows(0)
            rwm("no_trans") = notrans
            rwm("kd_kendaraan") = txtKendaraan.EditValue
            rwm("jml_kapasitas") = txtKapasitas.Text
            rwm("tanggal") = tgl
            rwm("kd_cabang") = kdcabang
            rwm("kd_departemen") = kddep
            rwm("last_create_date") = tgl
            rwm("last_created_by") = username
            rwm("last_update_date") = tgl
            rwm("last_updated_by") = username
            rwm("program_name") = Me.Name
            Try

                da3.Update(ds1.Tables("MASTER"))
                da2.Update(ds1.Tables("KIRIM"))
                ds1.Tables("MASTER").AcceptChanges()
                ds1.Tables("KIRIM").AcceptChanges()
                call_procedure(notrans, BTRANS)
                BTRANS.Commit()
                txtNoTrans.Text = notrans

                showMessages("Data Berhasil Disimpan")
                btnSave = False

                setStatus()
            Catch ex As Exception
                BTRANS.Rollback()
                ds1.Tables("MASTER").RejectChanges()
                ds1.Tables("KIRIM").RejectChanges()
                MsgBox(ex.Message)
            End Try
        ElseIf State = "EDIT" Then
            Dim filledrow As Integer = ds1.Tables("KIRIM").Select("jumlah>0").Count
            If filledrow = 0 Then
                MessageBox.Show("Jumlah Rencana Kirim Belum Ada Yang Diisi")
                Exit Sub
            End If




            Dim BTRANS As SqlTransaction
            mb = New SqlClient.SqlCommandBuilder(da3)
            da3.UpdateCommand = mb.GetUpdateCommand()
            da3.InsertCommand = mb.GetInsertCommand()
            da3.DeleteCommand = mb.GetDeleteCommand()

            mb = New SqlClient.SqlCommandBuilder(da2)
            da2.UpdateCommand = mb.GetUpdateCommand()
            da2.InsertCommand = mb.GetInsertCommand()
            da2.DeleteCommand = mb.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            da3.UpdateCommand.Transaction = BTRANS
            da3.InsertCommand.Transaction = BTRANS
            da3.DeleteCommand.Transaction = BTRANS

            da2.UpdateCommand.Transaction = BTRANS
            da2.InsertCommand.Transaction = BTRANS
            da2.DeleteCommand.Transaction = BTRANS
            notrans = txtNoTrans.Text
            Dim qstr As String
            Dim dr As SqlDataReader
            qstr = "delete from PROD.dbo.PROD_rcn_krm_d where no_trans='" & notrans & "'"
            dr = New SqlClient.SqlCommand(qstr, sqlconn, BTRANS).ExecuteReader
            dr.Close()
            qstr = "delete from PROD.dbo.PROD_rcn_krm_m where no_trans='" & notrans & "'"
            dr = New SqlClient.SqlCommand(qstr, sqlconn, BTRANS).ExecuteReader
            dr.Close()

            For i = ds1.Tables("KIRIM").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = ds1.Tables("KIRIM").Rows(i)
                If Not TypeOf rows("jumlah") Is DBNull Then
                    If rows("jumlah") > 0 Then
                        rows("tanggal") = tgl
                        rows("no_trans") = notrans
                        rows("last_update_date") = tgl
                        rows("last_updated_by") = username
                        rows("program_name") = Me.Name
                        rows("kd_cabang") = kdcabang
                        rows("kd_departemen") = kddep
                    Else
                        ds1.Tables("KIRIM").Rows(i).Delete()
                    End If
                Else
                    ds1.Tables("KIRIM").Rows(i).Delete()
                End If
            Next
            Dim rwm As DataRow = ds1.Tables("MASTER").Rows(0)
            rwm("no_trans") = notrans
            rwm("tanggal") = tgl
            rwm("kd_cabang") = kdcabang
            rwm("kd_departemen") = kddep
            rwm("kd_kendaraan") = txtKendaraan.EditValue
            rwm("jml_kapasitas") = txtKapasitas.Text
            rwm("last_create_date") = txtTanggal.DateTime
            rwm("last_created_by") = username
            rwm("last_update_date") = tgl
            rwm("last_updated_by") = username
            rwm("program_name") = Me.Name

            Try

                da3.Update(ds1.Tables("MASTER"))
                da2.Update(ds1.Tables("KIRIM"))

                ds1.Tables("MASTER").AcceptChanges()
                ds1.Tables("KIRIM").AcceptChanges()
                call_procedure(notrans, BTRANS)
                BTRANS.Commit()
                showMessages("Data Berhasil Disimpan")
                txtNoTrans.Text = notrans

                btnSave = False

                setStatus()
            Catch ex As Exception
                BTRANS.Rollback()
                ds1.Tables("MASTER").RejectChanges()
                ds1.Tables("KIRIM").RejectChanges()
                MsgBox(ex.Message)
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
        txtKendaraan.EditValue = Nothing
        txtKapasitas.Text = ""
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
    End Sub
    Public Sub cetak_click()
        'If Trim(txtNoDPB.Text) <> "" And State = "EDIT" Then
        'callReport(App_Path() & "\report\rptPOM.rpt", "", "Nomor=" & Trim(txtNoPO.Text))

        'Dim notrans As String = Trim(txtNoDPB.Text)
        callReport(App_Path() & "\report\crProdRcnKrm1.rpt", "", "&pnotrans=" & txtNoTrans.Text)
        'Else
        'MessageBox.Show("Pilih data yang akan dicetak dalam mode EDIT!")
        'End If
    End Sub

    Private Sub gvDetail_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvDetail.CellValueChanged
        Dim rw As DataRow
        Dim View As ColumnView = sender
        If e.Column Is jumlah Then
            rw = ds1.Tables("KIRIM").Select("no_sp = '" & gvDetail.GetRow(e.RowHandle).item("no_sp") & "'")(0)

            gvDetail.SetRowCellValue(e.RowHandle, "jml_indeks", rw("nilai") * gvDetail.GetRow(e.RowHandle).item("jumlah"))
        End If
    End Sub

    Private Sub gvDetail_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvDetail.DoubleClick
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
            frmDtlSO.prioritas.Text = dr.Item("prioritas").ToString
            frmDtlSO.ShowDialog()
            dr.Close()
        End If
    End Sub

    Private Sub gvDetail_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvDetail.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub gvDetail_RowClick(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs) Handles gvDetail.RowClick
        Dim x As Object
        x = CType(gc.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        Dim kdstok As String = x.GetRowCellValue(e.RowHandle, "kd_stok")
        If Not ds1.Tables("QTY") Is Nothing Then ds1.Tables("QTY").Clear()
        da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PRODV_MON_STOCK  where kd_stok = '" & kdstok & "'", sqlconn))
        da4.Fill(ds1, "QTY")
        gc2.DataSource = ds1.Tables("QTY")
    End Sub

    'Private Sub gvDetail_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvDetail.FocusedRowChanged
    '    Dim kdstok As ColumnView = sender
    '    kdstok.GetFocusedRowCellValue("kd_stok")

    '    If Not ds1.Tables("QTY") Is Nothing Then ds1.Tables("QTY").Clear()
    '    da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PRODV_MON_STOCK  where kd_stok = '" & kdstok.GetFocusedRowCellValue("kd_stok") & "'", sqlconn))
    '    da4.Fill(ds1, "QTY")
    '    gc2.DataSource = ds1.Tables("QTY")
    'End Sub

    Private Sub gvDetail_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvDetail.ValidateRow
        Dim isValid As Boolean = True
        If e.Row("jumlah") > e.Row("Sisa") Then
            gvDetail.SetColumnError(jumlah, "Jumlah Rencana Kirim Terlalu Banyak", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            MessageBox.Show("Jumlah Rencana Kirim Terlalu Banyak")
            isValid = False
        Else
            e.Row("jml_indeks") = e.Row("jumlah") * e.Row("nilai")
        End If
        e.Valid = isValid
    End Sub

    Private Sub GridView2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView2.DoubleClick
        Dim vkd_brg As ColumnView = sender
        vkd_brg.GetFocusedRowCellValue("kd_stok")

        If vkd_brg.GetFocusedRowCellValue("kd_stok") <> "" Then
            call_form_manual("frmProdMonBooked")
            frmProdMonBooked.txtNama_Barang.EditValue = vkd_brg.GetFocusedRowCellValue("kd_stok").ToString
            frmProdMonBooked.LoadGrid()

            frmProdMonBooked.TopLevel = False
            'frmStatusSP.filter = txtNomor.Text
            frmProdMonBooked.txtNama_Barang.EditValue = vkd_brg.GetFocusedRowCellValue("kd_stok").ToString
            Me.Controls.Add(frmProdMonBooked)
            frmProdMonBooked.WindowState = FormWindowState.Maximized
            frmProdMonBooked.Show()
            pnl.SendToBack()

        End If

    End Sub

    Private Sub txtKendaraan_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKendaraan.EditValueChanged
        txtKapasitas.Text = txtKendaraan.GetColumnValue("Kapasitas")
    End Sub
End Class
