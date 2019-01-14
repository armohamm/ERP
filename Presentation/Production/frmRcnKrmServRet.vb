Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms

Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Public Class frmRcnKrmServRet
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
        If Not ds1.Tables("KIRIM") Is Nothing Then ds1.Tables("KIRIM").Clear()
        If Not ds1.Tables("MASTER") Is Nothing Then ds1.Tables("MASTER").Clear()

        If Not ds1.Tables("JENIS") Is Nothing Then ds1.Tables("JENIS").Clear()
        If Not ds1.Tables("QTY") Is Nothing Then ds1.Tables("QTY").Clear()

        da1 = New SqlDataAdapter(New SqlCommand("select distinct(v.kd_jenis), v.nama_jenis, k.jumlah_kapasitas, v.tipe_trans from sif.dbo.sif_kapasitas k, PROD.dbo.PRODV_MON_SO v where v.kd_jenis=k.kd_jenis and (Len(v.no_sp) > 10 And v.qty_sisa > 0)", sqlconn))
        da1.Fill(ds1, "JENIS")

        da2 = New SqlDataAdapter(New SqlCommand("select t.*, '' Nama_Jenis, '' nama_barang,'' qty_order,'' sisa, '' tgl_kirim, '' prioritas,0.00 nilai, '' kd_stok, '' nama_customer from PROD.dbo.PROD_rcn_krm_d t where 1=0", sqlconn))
        da2.Fill(ds1, "KIRIM")

        da3 = New SqlDataAdapter(New SqlCommand("select *, '' Nama_Jenis from PROD.dbo.PROD_rcn_krm_m where 1=0", sqlconn))
        da3.Fill(ds1, "MASTER")

        Dim dr As SqlDataReader
        'dr = New SqlClient.SqlCommand("select distinct(v.kd_jenis), v.Nama_Jenis, k.jumlah_kapasitas, v.tipe_trans from sif.dbo.sif_kapasitas k, PROD.dbo.PRODV_MON_SO v where v.kd_jenis=k.kd_jenis and (Len(v.no_sp) > 10 And v.qty_sisa > 0)", sqlconn).ExecuteReader
        dr = New SqlClient.SqlCommand("select v.*, isnull(k.jumlah_kapasitas,0) jml_kapasitas from " & _
                                      "(select distinct(kd_jenis), nama_jenis, tipe_trans from PROD.dbo.PRODV_MON_SO where Len(no_sp) > 10 And qty_sisa > 0 " & _
                                      " and departement='" & kddep & "' " & _
                                      ") v " & _
                                      "left join " & _
                                      "(select * from SIF.dbo.SIF_kapasitas where kegiatan_ppic='02') k " & _
                                      "on v.kd_jenis=k.kd_jenis", sqlconn).ExecuteReader
        While dr.Read
            Dim rwm As DataRow = ds1.Tables("MASTER").NewRow
            rwm("Nama_Jenis") = dr.Item("nama_jenis")
            rwm("tipe_trans") = dr.Item("tipe_trans")
            rwm("kd_jenis") = dr.Item("kd_jenis")
            rwm("jml_kapasitas") = dr.Item("jml_kapasitas")
            ds1.Tables("MASTER").Rows.Add(rwm)
        End While
        dr.Close()

        da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PRODV_MON_STOCK", sqlconn))
        da4.Fill(ds1, "QTY")
        gc.DataSource = ds1.Tables("QTY")
        'Dim dr As SqlDataReader = New SqlClient.SqlCommand("select * from PROD.dbo.PRODV_MON_SO where LEN(no_sp) > 10 and qty_sisa > 0 order by No_sp, No_seq", sqlconn).ExecuteReader
        dr = New SqlClient.SqlCommand("select v.*, ISNULL(i.nilai,0) nilai " & _
                                                           "from PROD.dbo.PRODV_MON_SO v " & _
                                                           "left join SIF.dbo.SIF_Barang b " & _
                                                           "on v.Kd_Stok = b.Kode_Barang " & _
                                                           "left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '02') i " & _
                                                           "on b.kd_jenis = i.kd_jenis and b.kd_tipe = i.kd_tipe and b.kd_ukuran = i.kd_ukuran " & _
                                                           "where(Len(v.no_sp) > 10 And v.qty_sisa > 0 " & _
                                                           " and departement='" & kddep & "' " & _
                                                           ") " & _
                                                           "order by v.No_sp, v.No_seq", sqlconn).ExecuteReader

        'MsgBox(dr.HasRows)
        While dr.Read
            tipetrans = dr.Item("Tipe_trans")

            Dim rw As DataRow = ds1.Tables("KIRIM").NewRow
            rw("kd_cabang") = getKodeCabang()
            rw("tanggal") = getTanggal()
            rw("kd_jenis") = dr.Item("kd_jenis")
            rw("No_sp") = dr.Item("No_sp")
            rw("no_sp_dtl") = dr.Item("no_seq")
            rw("jumlah") = 0
            rw("jml_indeks") = 0
            rw("rec_stat") = vbNullString
            rw("program_name") = Me.Name
            rw("Nama_Jenis") = dr.Item("Nama_Jenis")
            rw("nama_customer") = dr.Item("Nama_Customer")
            rw("nama_barang") = dr.Item("Nama_Barang")
            rw("qty_order") = dr.Item("Qty_Order")
            rw("sisa") = dr.Item("Qty_Sisa")
            rw("tgl_kirim") = dr.Item("tgl_kirim")
            rw("prioritas") = dr.Item("prioritas")
            rw("nilai") = dr.Item("nilai")
            rw("kd_stok") = dr.Item("kd_stok")


            ds1.Tables("KIRIM").Rows.Add(rw)
        End While
        dr.Close()
        'gv.Columns("no_sp").Group()
        'gv.Columns("Nama_Jenis").Group()

        gc.DataSource = ds1.Tables("MASTER")
        txtTanggal.Text = DateTime.Today
        txtNoTrans.Text = ""
    End Sub

    Private Sub frmRcnKrmServRet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        btnEdit = False
        btnDelete = False
        setStatus()
        State = "ADD"
        reload()
        'Nama_Jenis.Group()

        Dim rl As DataRelation
        rl = ds1.Relations.Add("DetailKirim", ds1.Tables("MASTER").Columns("kd_jenis"), ds1.Tables("KIRIM").Columns("kd_jenis"))
        gc.LevelTree.Nodes.Add("DetailKirim", gvDetail)

    End Sub

    Public Sub add_click()
        reload()

        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        State = "ADD"
        setStatus()
    End Sub

    Public Sub edit_click()
        btnSave = True
        btnadd = False
        btnEdit = False
        btnDelete = True
        btnCancel = True
        setStatus()
        Me.Enabled = True
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
        Dim mrow As DataRow
        For i = ds1.Tables("MASTER").Rows.Count - 1 To 0 Step -1
            mrow = ds1.Tables("MASTER").Rows(i)
            If mrow.GetChildRows("DetailKirim").Count() = 0 Then
                mrow.Delete()
            Else
                mrow("no_trans") = notrans
                mrow("tanggal") = tgl
                mrow("kd_cabang") = kdcabang
                mrow("kd_departemen") = kddep
                mrow("last_create_date") = tgl
                mrow("last_created_by") = username
                mrow("last_update_date") = tgl
                mrow("last_updated_by") = username
                mrow("program_name") = Me.Name


            End If
        Next


        'For Each rows As DataRow In ds1.Tables("JENIS").Rows
        '    If State = "ADD" Then
        '        txtNoTrans.Text = notrans
        '        row = ds1.Tables("MASTER").NewRow

        '        row.Item("kd_cabang") = getKodeCabang()
        '        row.Item("kd_divisi") = 1
        '        row.Item("tanggal") = getTanggal()
        '        row.Item("no_trans") = notrans
        '        row.Item("tipe_trans") = rows("tipe_trans")
        '        row.Item("kd_jenis") = rows("kd_jenis")
        '        row.Item("jml_kapasitas") = rows("jumlah_kapasitas")
        '        row.Item("rec_stat") = vbNullString
        '        row.Item("keterangan") = vbNullString
        '        row.Item("Last_create_date") = getTanggal()
        '        row.Item("Last_created_by") = username
        '        row.Item("Program_name") = Me.Name

        '        ds1.Tables("MASTER").Rows.Add(row)
        '    ElseIf State = "EDIT" Then
        '        row = ds1.Tables("MASTER").NewRow

        '        row.Item("kd_cabang") = getKodeCabang()
        '        row.Item("kd_divisi") = 1
        '        row.Item("tanggal") = getTanggal()
        '        row.Item("no_trans") = txtNoTrans.Text
        '        row.Item("tipe_trans") = rows("tipe_trans")
        '        row.Item("kd_jenis") = rows("kd_jenis")
        '        row.Item("jml_kapasitas") = rows("jumlah_kapasitas")
        '        row.Item("rec_stat") = vbNullString
        '        row.Item("keterangan") = vbNullString
        '        row.Item("Last_update_date") = getTanggal()
        '        row.Item("Last_updated_by") = username
        '        row.Item("Program_name") = Me.Name
        '    End If
        'Next

        'For Each rows As DataRow In ds1.Tables("KIRIM").Rows
        '    If rows.RowState = DataRowState.Added Then
        '        rows.Item("no_trans") = notrans
        '        rows.Item("Last_Create_Date") = Now
        '        rows.Item("Last_Created_By") = username
        '    Else
        '        rows.Item("Last_Update_Date") = Now
        '        rows.Item("Last_UPdated_By") = username
        '    End If
        'Next

        Try


            da3.Update(ds1.Tables("MASTER"))
            da2.Update(ds1.Tables("KIRIM"))

            ds1.Tables("MASTER").AcceptChanges()
            ds1.Tables("KIRIM").AcceptChanges()
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
        btnEdit = False
        btnAdd = True
        setStatus()
        Me.Enabled = False
    End Sub

    Private Sub gvDetail_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvDetail.CellValueChanged
        Dim rw As DataRow
        Dim View As ColumnView = sender
        If e.Column Is jumlah Then
            rw = ds1.Tables("KIRIM").Select("no_sp = '" & gvDetail.GetRow(e.RowHandle).item("no_sp") & "'")(0)

            gvDetail.SetRowCellValue(e.RowHandle, "jml_indeks", rw("nilai") * gvDetail.GetRow(e.RowHandle).item("jumlah"))
            'gvDetail.GetRow(e.RowHandle).item("jml_indeks") = rw("nilai") * rw("jumlah")
        End If
        'MsgBox(e.RowHandle)
        'rw = ds1.Tables("KIRIM").Select("no_sp = '" & gvDetail.GetRow(e.RowHandle).item("no_sp") & "'")(0)

        'gvDetail.GetRow(e.RowHandle).item("jml_indeks") = rw("nilai") * rw("jumlah")
    End Sub

    Private Sub gv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvDetail.DoubleClick
        Dim nosp As String = gvDetail.GetRowCellValue(gvDetail.GetRowHandle(gvDetail.FocusedRowHandle), "no_sp")
        If nosp <> "" Then
            Dim noseq = gvDetail.GetRowCellValue(gvDetail.GetRowHandle(gvDetail.FocusedRowHandle), "no_sp_dtl")
            'MessageBox.Show(nosp)
            Dim dr As SqlDataReader = New SqlClient.SqlCommand("select * from PROD.dbo.PRODV_MON_SO where no_sp='" & nosp & "' and no_seq='" & noseq & "' order by No_sp, No_seq", sqlconn).ExecuteReader
            dr.Read()
            frmDtlSO.nosp.Text = dr.Item("no_sp").ToString
            frmDtlSO.noseq.Text = dr.Item("no_seq").ToString
            frmDtlSO.cust.Text = dr.Item("Nama_Customer").ToString
            frmDtlSO.barang.Text = dr.Item("Nama_Barang").ToString
            frmDtlSO.Qty_Order.Text = dr.Item("Qty_Order").ToString
            frmDtlSO.Qty_Rcn_Krm.Text = dr.Item("tgl_kirim").ToString
            frmDtlSO.Qty_Rcn_Prod.Text = dr.Item("prioritas").ToString
            frmDtlSO.ShowDialog()
            dr.Close()
        End If

    End Sub

    Private Sub gvDetail_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvDetail.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub


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

End Class