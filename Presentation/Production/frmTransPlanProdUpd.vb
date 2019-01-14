Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms

Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Public Class frmTransPlanProdUpd
    Dim ds1, ds2, ds3 As New DataSet
    Dim da1, da2, da3, da4, da5 As New SqlDataAdapter
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
    End Sub

    Private Sub clearAll()
        ds1.Relations.Clear()
        If Not ds1.Tables("KIRIM") Is Nothing Then ds1.Tables("KIRIM").Clear()
        If Not ds1.Tables("MASTER") Is Nothing Then ds1.Tables("MASTER").Clear()
        'If Not ds1.Tables("JENIS") Is Nothing Then ds1.Tables("JENIS").Clear()
    End Sub

    Private Sub reload(ByVal no_rph As String)
        'If no_rph <> "x" Then

        If Not ds1.Tables("KIRIM") Is Nothing Then ds1.Tables("KIRIM").Clear()
        If Not ds1.Tables("MASTER") Is Nothing Then ds1.Tables("MASTER").Clear()
        'If Not ds1.Tables("JENIS") Is Nothing Then ds1.Tables("JENIS").Clear()

        'da1 = New SqlDataAdapter(New SqlCommand("select distinct(v.kd_jenis), j.nama_jenis from sif.dbo.sif_jenis_barang j, prod.dbo.PROD_rcn_prod_d v where v.kd_jenis=j.kd_jns_brg  and v.no_rph='" & no_rph & "'", sqlconn))
        'da1.Fill(ds1, "JENIS")

        da3 = New SqlDataAdapter(New SqlCommand("select m.kd_jenis,j.Nama_Jenis from prod.dbo.prod_rcn_prod_m m, sif.dbo.sif_jenis_barang j where m.kd_jenis=j.kd_jns_brg and m.no_rph='" & no_rph & "'", sqlconn))
        da3.Fill(ds1, "MASTER")

        da2 = New SqlDataAdapter(New SqlCommand("select d.kd_jenis,d.no_sp, j.Nama_Jenis, b.Nama_Barang,d.jumlah,s.qty_sisa, s.tgl_kirim, s.prioritas,d.jml_indeks,0.00 nilai from prod.dbo.PROD_rcn_prod_d d, sif.dbo.sif_jenis_barang j, prod.dbo.prodv_mon_so s,sif.dbo.sif_barang b where d.no_sp=s.No_sp and s.Kd_Stok=b.kode_barang and d.kd_jenis=j.Kd_Jns_Brg and d.no_rph='" & no_rph & "'", sqlconn))
        da2.Fill(ds1, "KIRIM")

        'Dim dr As SqlDataReader
        'dr = New SqlClient.SqlCommand("select distinct(v.kd_jenis), v.Nama_Jenis, k.jumlah_kapasitas, v.tipe_trans from sif.dbo.sif_kapasitas k, PROD.dbo.PRODV_MON_SO v where v.kd_jenis=k.kd_jenis and (Len(v.no_sp) > 10 And v.qty_sisa > 0)", sqlconn).ExecuteReader
        'While dr.Read
        '    Dim rwm As DataRow = ds1.Tables("MASTER").NewRow
        '    rwm("Nama_Jenis") = dr.Item("Nama_Jenis")
        '    rwm("tipe_trans") = dr.Item("tipe_trans")
        '    rwm("kd_jenis") = dr.Item("kd_jenis")
        '    rwm("jml_kapasitas") = dr.Item("jumlah_kapasitas")
        '    ds1.Tables("MASTER").Rows.Add(rwm)
        'End While
        'dr.Close()

        'dr = New SqlClient.SqlCommand("select v.*, ISNULL(i.nilai,0) nilai " & _
        '                              "from PROD.dbo.PRODV_MON_SO v " & _
        '                              "left join SIF.dbo.SIF_Barang b " & _
        '                              "on v.Kd_Stok = b.Kode_Barang " & _
        '                              "left join (select * from SIF.dbo.SIF_indeks_barang where jns_kegiatan = '02') i " & _
        '                              "on b.kd_jenis = i.kd_jenis and b.kd_tipe = i.kd_tipe and b.kd_sub_tipe = i.kd_sub_tipe and b.kd_ukuran = i.kd_ukuran " & _
        '                              "where(Len(v.no_sp) > 10 And v.qty_sisa > 0 " & _
        '                              "and departement='2') order by v.No_sp, v.No_seq", sqlconn).ExecuteReader
        'While dr.Read
        '    tipetrans = dr.Item("Tipe_trans")

        '    Dim rw As DataRow = ds1.Tables("KIRIM").NewRow
        '    rw("kd_cabang") = getKodeCabang()
        '    rw("tanggal") = getTanggal()
        '    rw("kd_jenis") = dr.Item("kd_jenis")
        '    rw("No_sp") = dr.Item("No_sp")
        '    rw("no_sp_dtl") = dr.Item("no_seq")
        '    rw("jumlah") = 0
        '    rw("jml_indeks") = 0
        '    rw("rec_stat") = vbNullString
        '    rw("program_name") = Me.Name
        '    rw("Nama_Jenis") = dr.Item("Nama_Jenis")
        '    rw("nama_barang") = dr.Item("Nama_Barang")
        '    rw("qty_order") = dr.Item("Qty_Order")
        '    rw("sisa") = dr.Item("Qty_Sisa")
        '    rw("tgl_kirim") = dr.Item("tgl_kirim")
        '    rw("prioritas") = dr.Item("prioritas")
        '    rw("nilai") = dr.Item("nilai")

        '    ds1.Tables("KIRIM").Rows.Add(rw)
        'End While
        'dr.Close()
        gc.DataSource = ds1.Tables("MASTER")

        no_sp.ColumnEdit = Nothing
        nama_barang.ColumnEdit = Nothing
        txtTanggal.Text = DateTime.Today
        'End If
    End Sub

    Private Sub frmRcnKrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        btnEdit = False
        btnDelete = False
        setStatus()
        State = "ADD"

        reload("")
        Dim rl As DataRelation
        rl = ds1.Relations.Add("DetailKirim", ds1.Tables("MASTER").Columns("kd_jenis"), ds1.Tables("KIRIM").Columns("kd_jenis"))
        gc.LevelTree.Nodes.Add("DetailKirim", gvDetail)

        da3 = New SqlDataAdapter(New SqlCommand("select m.no_rph,d.desc_data from prod.dbo.PROD_rcn_prod_m m, sif.dbo.sif_gen_reff_d d where m.kd_jadwal=d.id_data and d.ref_role='PROD' and d.id_ref_data='JDWKRJ'", sqlconn))
        da3.Fill(ds3, "RPH")
        looktrans.Properties.DataSource = ds3.Tables("RPH")
        looktrans.Properties.ValueMember = "no_rph"
        looktrans.Properties.DisplayMember = "no_rph"
    End Sub

    Public Sub add_click()
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        State = "ADD"
        setStatus()

        clearAll()
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

        Try
            da3.Update(ds1.Tables("MASTER"))
            da2.Update(ds1.Tables("KIRIM"))

            ds1.Tables("MASTER").AcceptChanges()
            ds1.Tables("KIRIM").AcceptChanges()
            BTRANS.Commit()
            showMessages("Data Berhasil Disimpan")
            looktrans.Text = notrans
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
        'Dim rw As DataRow

        If gvDetail.IsNewItemRow(e.RowHandle) = False Then
            If e.Column Is jumlah Then
                'rw = ds1.Tables("KIRIM").Select("no_sp = '" & gvDetail.GetRow(e.RowHandle).item("no_sp") & "'")(0)

                'gvDetail.SetRowCellValue(e.RowHandle, "jml_indeks", rw("nilai") * gvDetail.GetRow(e.RowHandle).item("jumlah"))
            End If
        Else
            'MsgBox(e.Column.Name)
            'Dim rw As DataRow
            'MsgBox(e.Column Is no_sp)

            Dim view As ColumnView = sender

            'da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_NOTA where kd_cust='" & lookcust.EditValue & "' and kd_valuta='" & LEValuta.EditValue & "' and tipe_trans in ('JPJ-KPT-01','JPJ-KPT-02') and jml_akhir>0 ", sqlconn))
            'da2.Fill(ds2, "vnotaload")
            'repBrg.DataSource = ds2.Tables("vnotaload")

            If e.Column.Name = "no_sp" Then
                If Not ds2.Tables("SPload") Is Nothing Then ds2.Tables("SPload").Clear()
                'MsgBox(gvMain.GetFocusedRowCellValue("Nama_Jenis"))
                'MsgBox(gvDetail.GetFocusedRowCellValue("no_sp"))
                MsgBox(gvDetail.GetRowCellValue(e.RowHandle, "no_sp"))
                'MsgBox(gvDetail.GetRow(e.RowHandle).item("no_sp").ToString) ''
                da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nama_barang,no_sp,nama_customer,qty_sisa,tgl_kirim,prioritas from PROD.dbo.PRODV_MON_SO where nama_jenis='" & gvMain.GetFocusedRowCellValue("Nama_Jenis") & "' and no_sp='" & lookupSP1.GetDataSourceValue("no_sp", e.RowHandle) & "'", sqlconn))
                da2.Fill(ds2, "SPload")

                view.SetRowCellValue(e.RowHandle, "no_sp", ds2.Tables("SPload").Rows(0).Item("no_sp"))
                view.SetRowCellValue(e.RowHandle, "nama_barang", ds2.Tables("SPload").Rows(0).Item("nama_barang"))
                view.SetRowCellValue(e.RowHandle, "qty_sisa", ds2.Tables("SPload").Rows(0).Item("qty_sisa"))
                view.SetRowCellValue(e.RowHandle, "tgl_kirim", ds2.Tables("SPload").Rows(0).Item("tgl_kirim"))
                view.SetRowCellValue(e.RowHandle, "prioritas", ds2.Tables("SPload").Rows(0).Item("prioritas"))
                view.SetRowCellValue(e.RowHandle, "jumlah", "0")
                view.SetRowCellValue(e.RowHandle, "jml_indeks", "0")
            ElseIf e.Column.Name = "nama_barang" Then
                MsgBox(gvDetail.GetRow(e.RowHandle).item("nama_barang"))

                If Not ds2.Tables("SPload") Is Nothing Then ds2.Tables("SPload").Clear()
                da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nama_barang,no_sp,nama_customer,qty_sisa,tgl_kirim,prioritas from PROD.dbo.PRODV_MON_SO where nama_jenis='" & gvMain.GetFocusedRowCellValue("Nama_Jenis") & "' and no_sp='" & gvDetail.GetRow(e.RowHandle).item("nama_barang") & "'", sqlconn))
                da2.Fill(ds2, "SPload")

                view.SetRowCellValue(e.RowHandle, "nama_barang", ds2.Tables("SPload").Rows(0).Item("nama_barang"))
                view.SetRowCellValue(e.RowHandle, view.Columns("qty_sisa"), ds2.Tables("SPload").Rows(0).Item("qty_sisa"))
                view.SetRowCellValue(e.RowHandle, view.Columns("tgl_kirim"), ds2.Tables("SPload").Rows(0).Item("tgl_kirim"))
                view.SetRowCellValue(e.RowHandle, view.Columns("prioritas"), ds2.Tables("SPload").Rows(0).Item("prioritas"))
                view.SetRowCellValue(e.RowHandle, view.Columns("jumlah"), "0")
                view.SetRowCellValue(e.RowHandle, view.Columns("jml_indeks"), "0")
            End If

            'If e.Column.Name = "no_sp" Then

            '    rw = ds1.Tables("SP").Select("no_sp = '" & gvDetail.GetRow(e.RowHandle).item("no_sp") & "'")(0)
            '    gvDetail.SetRowCellValue(e.RowHandle, "nama_barang", rw("nama_barang"))
            '    gvDetail.SetRowCellValue(e.RowHandle, "qty_sisa", rw("qty_sisa"))
            '    gvDetail.SetRowCellValue(e.RowHandle, "tgl_kirim", rw("tgl_kirim"))
            '    gvDetail.SetRowCellValue(e.RowHandle, "prioritas", rw("prioritas"))
            '    gvDetail.SetRowCellValue(e.RowHandle, "jumlah", 0)
            '    gvDetail.SetRowCellValue(e.RowHandle, "jml_indeks", 0)
            'ElseIf e.Column.Name = "nama_barang" Then
            '    rw = ds1.Tables("BRG").Select("no_sp = '" & lookupbarang.ValueMember & "'")(0)
            '    gvDetail.SetRowCellValue(e.RowHandle, "no_sp", rw("no_sp"))
            '    gvDetail.SetRowCellValue(e.RowHandle, "qty_sisa", rw("qty_sisa"))
            '    gvDetail.SetRowCellValue(e.RowHandle, "tgl_kirim", rw("tgl_kirim"))
            '    gvDetail.SetRowCellValue(e.RowHandle, "prioritas", rw("prioritas"))
            '    gvDetail.SetRowCellValue(e.RowHandle, "jumlah", 0)
            '    gvDetail.SetRowCellValue(e.RowHandle, "jml_indeks", 0)
            'End If
        End If
    End Sub

    Private Sub gv_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvDetail.DoubleClick
        Dim nosp As String = gvDetail.GetRowCellValue(gvDetail.GetRowHandle(gvDetail.FocusedRowHandle), "no_sp")
        If nosp <> "" Then
            Dim noseq = gvDetail.GetRowCellValue(gvDetail.GetRowHandle(gvDetail.FocusedRowHandle), "no_sp_dtl")

            Dim dr As SqlDataReader = New SqlClient.SqlCommand("select * from PROD.dbo.PRODV_MON_SO where no_sp='" & nosp & "' and no_seq='" & noseq & "' order by No_sp, No_seq", sqlconn).ExecuteReader
            dr.Read()
            frmDtlSO.nosp.Text = dr.Item("no_sp").ToString
            frmDtlSO.noseq.Text = dr.Item("no_seq").ToString
            frmDtlSO.cust.Text = dr.Item("Nama_Customer").ToString
            frmDtlSO.barang.Text = dr.Item("Nama_Barang").ToString
            frmDtlSO.jumlah.Text = dr.Item("Qty_Order").ToString
            frmDtlSO.tanggal.Text = dr.Item("tgl_kirim").ToString
            frmDtlSO.prioritas.Text = dr.Item("prioritas").ToString
            frmDtlSO.ShowDialog()
            dr.Close()
        End If

    End Sub

    Private Sub gvDetail_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvDetail.FocusedRowChanged
        If gvDetail.IsNewItemRow(e.FocusedRowHandle) = True Then
            no_sp.ColumnEdit = lookupnosp
            nama_barang.ColumnEdit = lookupbarang
        Else
            no_sp.ColumnEdit = Nothing
            nama_barang.ColumnEdit = Nothing
        End If
    End Sub

    Private Sub gvDetail_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvDetail.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub gvDetail_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvDetail.ValidateRow
        Dim isValid As Boolean = True
        If Not TypeOf (e.Row("qty_sisa")) Is DBNull And Not TypeOf (e.Row("jumlah")) Is DBNull Then
            If e.Row("jumlah") > e.Row("qty_sisa") Then
                gvDetail.SetColumnError(jumlah, "Jumlah Rencana Kirim Terlalu Banyak", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                isValid = False
            Else
                e.Row("jml_indeks") = e.Row("jumlah") * e.Row("nilai")
            End If
        End If
        e.Valid = isValid
    End Sub

    Private Sub looktrans_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles looktrans.EditValueChanged
        reload(looktrans.EditValue)
        txtJadwal.Text = looktrans.Properties.GetDataSourceValue("desc_data", looktrans.ItemIndex)
    End Sub

    Private Sub gvMain_MasterRowExpanding(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventArgs) Handles gvMain.MasterRowExpanding
        If Not ds3.Tables("SP") Is Nothing Then ds3.Tables("SP").Clear()
        da3 = New SqlDataAdapter(New SqlCommand("select no_sp,nama_customer,nama_barang,qty_sisa,tgl_kirim,prioritas from PROD.dbo.PRODV_MON_SO  where nama_jenis='" & gvMain.GetFocusedRowCellValue("Nama_Jenis") & "'", sqlconn))
        da3.Fill(ds3, "SP")
        lookupSP1.DataSource = ds3.Tables("SP")
        lookupSP1.ValueMember = "no_sp"
        lookupSP1.DisplayMember = "no_sp"

        'lookupnosp.DataSource = ds3.Tables("SP")
        'lookupnosp.ValueMember = "no_sp"
        'lookupnosp.DisplayMember = "no_sp"

        If Not ds3.Tables("BRG") Is Nothing Then ds3.Tables("BRG").Clear()
        da3 = New SqlDataAdapter(New SqlCommand("select nama_barang,no_sp,nama_customer,qty_sisa,tgl_kirim,prioritas from PROD.dbo.PRODV_MON_SO where nama_jenis='" & gvMain.GetFocusedRowCellValue("Nama_Jenis") & "'", sqlconn))
        da3.Fill(ds3, "BRG")
        lookupbarang.DataSource = ds3.Tables("BRG")
        lookupbarang.ValueMember = "no_sp"
        lookupbarang.DisplayMember = "nama_barang"
    End Sub

    Private Sub lookupbarang_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lookupbarang.EditValueChanged
        
    End Sub

    Private Sub lookupnosp_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lookupnosp.EditValueChanged
        gvDetail.SetFocusedRowCellValue("nama_barang", lookupnosp.GetDataSourceValue("nama_barang", lookupnosp.GetDataSourceRowIndex("nama_barang", e.ToString)))
        gvDetail.SetFocusedRowCellValue("no_sp", lookupnosp.GetDataSourceValue("no_sp", lookupnosp.GetDataSourceRowIndex("no_sp", e.ToString)))
    End Sub

    Private Sub lookupbarang_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles lookupbarang.EditValueChanging
        gvDetail.SetFocusedRowCellValue("nama_barang", lookupbarang.GetDataSourceRowByKeyValue(e.NewValue))
    End Sub

    Private Sub lookupnosp_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles lookupnosp.EditValueChanging
        'MsgBox(lookupnosp.GetDataSourceRowIndex("nama_barang", e.NewValue))
        'gvDetail.SetFocusedRowCellValue("nama_barang", lookupnosp.GetDataSourceValue("nama_barang", lookupnosp.GetDataSourceRowIndex("nama_barang", e.NewValue)))
        'gvDetail.SetFocusedRowCellValue("no_sp", lookupnosp.GetDataSourceValue("no_sp", lookupnosp.GetDataSourceRowIndex("no_sp", e.NewValue)))
    End Sub

End Class