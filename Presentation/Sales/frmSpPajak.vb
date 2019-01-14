Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmSpPajak
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA As SqlDataAdapter
    Dim DAL As SqlDataAdapter
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Dim myBuilder As New SqlCommandBuilder
    Dim delay As Int16 = 60
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = False
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = False
            .btnEdit.Enabled = False
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = False

        End With
    End Sub
    Public Sub add_click()
        State = "ADD"
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
    End Sub
    Sub reloadTable()
        If Not dsete.Tables("SO") Is Nothing Then dsete.Tables("SO").Clear()
        'txtGTotal.EditValue = 0
        'DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, SALES.dbo.getCustomerByKode(kd_customer) Nama_Customer, jml_rp_trans VALTRANS, FLAG_PPN isPpn , PPn valPpn , sales.dbo.getCreditLimit(kd_customer, Valas) as SCR  from sales.dbo.sales_SO where len(no_sp) < 10 and status='OK' order by Tgl_sp", sqlconn))
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, SALES.dbo.getCustomerByKode(m.kd_customer) Nama_Customer, " & _
                                                                   "jml_rp_trans VALTRANS, FLAG_PPN isPpn , PPn valPpn, 0 as SCR " & _
                                                                   "from sales.dbo.sales_SO m " & _
                                                                   "where len(m.no_sp) < 10 and m.[Status]='OK' and isnull(m.Kunci,'T') <> 'Y' order by Tgl_sp", sqlconn))
        '"left join SIF.dbo.SIF_Customer c " & _
        '"on c.Kd_Customer = m.Kd_Customer " & _
        DA.Fill(dsete, "SO")
        GC.DataSource = dsete.Tables("SO")
        'If dsete.Tables("SO").Rows.Count = 0 Then
        If dsete.Tables("SO").Rows.Count > 0 Then

            btnSave = True
            btnCancel = False
            btnDelete = False
            btnEdit = False
            btnadd = False
            setStatus()
        End If
        With New SqlCommand("select isnull(target,0) from sales.dbo.sales_target_pajak where thnbln = convert(varchar(6), getdate(), 112)", sqlconn).ExecuteReader
            .Read()
            If .HasRows Then
                txtTarget.EditValue = .Item(0)
            Else
                txtTarget.EditValue = 0
            End If
            .Close()
        End With
    End Sub
    Sub reloadTable2()
        If Not dsete.Tables("SOLAMA") Is Nothing Then dsete.Tables("SOLAMA").Clear()

        DAL = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, SALES.dbo.getCustomerByKode(kd_customer) Nama_Customer, jml_rp_trans VALTRANS, FLAG_PPN isPpn ,FLAG_PPN isPpn2 , PPn valPpn from sales.dbo.sales_SO where len(no_sp) > 10 and isnull(isCLosed,'')<>'Y' and status='OK' and  Tipe_trans in ('" & SpringUmum & "','" & SponUmum & "') ", sqlconn))
        DAl.Fill(dsete, "SOLAMA")
        GC2.DataSource = dsete.Tables("SOLAMA")
        'If dsete.Tables("SOLAMA").Rows.Count = 0 Then
        If dsete.Tables("SOLAMA").Rows.Count > 0 Then

            btnSave = True
            btnCancel = False
            btnDelete = False
            btnEdit = False
            btnadd = False
            setStatus()
        End If
    End Sub
    Private Sub frmSpPajak_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        Timer1.Enabled = True
        getTodayP()
        getMonthP()
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select [tipe_trans],[tipe_desc] from [SIF].[dbo].[SIF_TIPE_TRANS]", sqlconn))
        dadbe.Fill(dsete, "tipe_trans")
        repTipeTrans.DataSource = dsete.Tables("tipe_trans")
        repTipeTrans2.DataSource = dsete.Tables("tipe_trans")
        prn = frmMain
        reloadTable()

        frmMain.btnAdd_Click(frmMain.btnAdd, New EventArgs)
        btnSave = True
        btnCancel = False
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
    End Sub
    Private Sub GV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV.DoubleClick
        If GV.GetSelectedRows.Count > 0 Then
            Dim tipetrans As String = GV.GetRow(GV.GetSelectedRows(0)).item("Tipe_trans")
            Dim noso As String = GV.GetRow(GV.GetSelectedRows(0)).item("No_sp")
            Dim x As Object
            If tipetrans = "JPJ-KPT-01" Or tipetrans = "JPJ-KPT-02" Then
                x = New frmSO
                x.tipe_transaksi = tipetrans
            ElseIf tipetrans = "JPJ-KPT-04" Then
                x = New frmSOBOX
            End If
            x.no_sp = noso
            x.TopMost = True
            x.Show(frmMain)

        End If
    End Sub
    Public Sub save_click()
        If TabSO.SelectedTabPage Is tabSpBaru Then
            save_baru()
        Else
            save_lama()
        End If
    End Sub
    Private Sub save_lama()
        Dim cmd As New SqlCommand
        Dim btrans As SqlTransaction
        Dim xparam As String
        Dim rw As DataRow

        If GV2.RowCount = 0 Then Exit Sub

        myBuilder = New SqlClient.SqlCommandBuilder(DAL)
        DAL.UpdateCommand = myBuilder.GetUpdateCommand()
        DAL.InsertCommand = myBuilder.GetInsertCommand()
        DAL.DeleteCommand = myBuilder.GetDeleteCommand()

        btrans = sqlconn.BeginTransaction("1")

        DAL.UpdateCommand.Transaction = btrans
        DAL.InsertCommand.Transaction = btrans
        DAL.DeleteCommand.Transaction = btrans
        Try
            For Each rw In dsete.Tables("SOLAMA").Select("isPpn <> isPpn2")

                Dim tengah As String = IIf(rw("isPpn").ToString = "Y", "0", "1")
                Dim drx As SqlDataReader = New SqlCommand("select kd_bukti from sif.dbo.sif_no_trans_param where kd_departemen='" & rw("Departement") & "' and tengah = " & tengah, sqlconn, btrans).ExecuteReader
                drx.Read()
                If drx.HasRows Then xparam = drx(0)
                drx.Close()
                rw("No_sp") = getNoTrans(xparam, rw("tgl_sp"), btrans)
                rw("isPrinted") = ""
            Next

            DAL.Update(dsete.Tables("SOLAMA"))
            btrans.Commit()
            showMessages("Transaksi Telah Disimpan")
            reloadTable()
            reloadTable2()
            getTodayP()
            getMonthP()
        Catch
            btrans.Rollback()
            MsgBox("Error : " & Chr(10) & Chr(13) & Err.Description, MsgBoxStyle.Critical, "Gagal Simpan")
            reloadTable()
        End Try
        Timer1.Enabled = True
    End Sub

    Private Sub save_baru()
        Dim cmd As New SqlCommand
        Dim btrans As SqlTransaction
        Dim xparam As String
        Dim rw As DataRow
        If GV.RowCount = 0 Then Exit Sub
        myBuilder = New SqlClient.SqlCommandBuilder(DA)
        myBuilder.ConflictOption = ConflictOption.OverwriteChanges
        DA.UpdateCommand = myBuilder.GetUpdateCommand()
        DA.InsertCommand = myBuilder.GetInsertCommand()
        DA.DeleteCommand = myBuilder.GetDeleteCommand()

        btrans = sqlconn.BeginTransaction("1")

        DA.UpdateCommand.Transaction = btrans
        DA.InsertCommand.Transaction = btrans
        DA.DeleteCommand.Transaction = btrans
        Try
            For Each rw In dsete.Tables("SO").Rows
                If Not rw("isPpn") Is Nothing Then
                    If rw("isPpn").ToString <> "" Then
                        Dim dry As SqlDataReader = New SqlCommand("select isnull(Kunci,'T') pending from sales.dbo.sales_so where no_sp='" & rw("no_sp") & "'", sqlconn, btrans).ExecuteReader
                        dry.Read()
                        If dry.HasRows Then
                            If dry.Item(0) = "T" Or dry.Item(0) = "" Then
                                Dim tengah As String = IIf(rw("isPpn").ToString = "Y", "0", "1")
                                Dim drx As SqlDataReader = New SqlCommand("select kd_bukti from sif.dbo.sif_no_trans_param where kd_departemen='" & rw("Departement") & "' and tengah = " & tengah, sqlconn, btrans).ExecuteReader
                                drx.Read()
                                If drx.HasRows Then xparam = drx(0)
                                drx.Close()
                                rw("No_sp") = getNoTrans(xparam, rw("tgl_sp"), btrans)
                            Else
                                rw("isPpn") = DBNull.Value
                            End If
                        End If
                        dry.Close()
                    End If

                End If
            Next

            DA.Update(dsete.Tables("SO"))
            btrans.Commit()
            showMessages("Transaksi Telah Disimpan")
            reloadTable()
            reloadTable2()
            txtToday.EditValue = 0
            getTodayP()
            getMonthP()

        Catch
            btrans.Rollback()
            MsgBox("Error : " & Chr(10) & Chr(13) & Err.Description, MsgBoxStyle.Critical, "Gagal Simpan")
            reloadTable()
        End Try

        Timer1.Enabled = True
    End Sub
    Public Sub cancel_click()
        reloadTable()
        reloadTable2()
        delay = 60
        Timer1.Enabled = True
    End Sub
    Private Sub GV_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV.RowUpdated
       
        If e.Row("isPpn") = "Y" Then
            e.Row("valPpn") = e.Row("VALTRANS") - e.Row("VALTRANS") / 1.1
        Else
            e.Row("valPpn") = 0
        End If
        txtTotal.EditValue = dsete.Tables("SO").Compute("sum(VALTRANS)", "isPpn='Y'")
        Timer1.Enabled = False
    End Sub
    Private Sub TabSO_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles TabSO.SelectedPageChanged
        If e.Page Is tabSpLama Then
            If dsete.Tables("SOLAMA") Is Nothing Then reloadTable2()
        End If
    End Sub
    Private Sub getTodayP()
        Dim dr As SqlDataReader = New SqlCommand("select isnull(sum(jml_rp_trans),0) from sales.dbo.sales_so where  ppn > 0 and status='OK' and convert(varchar(8), tgl_sp,112) = convert(varchar(8), getDate(),112)  ", sqlconn).ExecuteReader
        dr.Read()
        If dr(0) > 0 Then
            txtToday.EditValue = dr(0)
        Else
            txtToday.EditValue = 0
        End If
        dr.Close()
    End Sub
    Private Sub getMonthP()
        Dim dr As SqlDataReader = New SqlCommand("select isnull(sum(jml_rp_trans),0) from sales.dbo.sales_so where  ppn > 0 and status='OK' and convert(varchar(6), tgl_sp,112) = convert(varchar(6), getDate(),112) ", sqlconn).ExecuteReader
        dr.Read()
        If dr(0) > 0 Then
            txtGTotal.EditValue = dr(0)
        Else
            txtGTotal.EditValue = 0
        End If
        dr.Close()
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        reloadTable()
        reloadTable2()
        delay = 60
        Timer1.Enabled = True
        With New SqlCommand("select isnull(target,0) from sales.dbo.sales_target_pajak where thnbln = convert(varchar(6), getdate(), 112)", sqlconn).ExecuteReader
            .Read()
            If .HasRows Then
                txtTarget.EditValue = .Item(0)
            Else
                txtTarget.EditValue = 0
            End If
            .Close()
        End With
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If delay = 0 Then
            reloadTable()
            reloadTable2()
            delay = 60
        Else
            delay -= 1
            cmdRefresh.Text = delay
        End If
    End Sub

    Private Sub repPPN2_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles repPPn2.EditValueChanging
        If GV2.GetRowCellValue(GV2.FocusedRowHandle, "isPpn2") = "Y" Then
            e.Cancel = True
            GV2.SetColumnError(status2, "Tidak Bisa Merubah Status Pajak", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            Dim i As Int16 = 0
            Dim no_sp As String = GV2.GetRowCellValue(GV2.FocusedRowHandle, "No_sp")
            With (New SqlCommand("select isnull(count(1),0) from prod.dbo.prod_rcn_prod_d where no_sp = '" & no_sp & "'", sqlconn).ExecuteReader)
                .Read()
                i += .Item(0)
                If .Item(0) > 0 Then GV2.SetColumnError(status2, "SP Sudah Ada di RPH", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                .Close()
            End With
            With (New SqlCommand("select isnull(count(1),0) from prod.dbo.prod_rcn_krm_d where no_sp = '" & no_sp & "'", sqlconn).ExecuteReader)
                .Read()
                i += .Item(0)
                If .Item(0) > 0 Then GV2.SetColumnError(status2, "SP Sudah Ada di Rencana Pengiriman", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                .Close()
            End With
            If i > 0 Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub GV2_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV2.RowUpdated
        If e.Row("isPpn") = "Y" Then
            e.Row("valPpn") = e.Row("VALTRANS") - e.Row("VALTRANS") / 1.1
        Else
            e.Row("valPpn") = 0
        End If
        txtTotal.EditValue = dsete.Tables("SO").Compute("sum(VALTRANS)", "isPpn='Y'")
        Timer1.Enabled = False
    End Sub
    Private Sub GV_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub repPPN_EditValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ChangingEventArgs) Handles repPPN.EditValueChanging
        Dim dry As SqlDataReader = New SqlCommand("select isnull(Kunci,'T') pending from sales.dbo.sales_so where no_sp='" & GV.GetRowCellValue(GV.FocusedRowHandle, "No_sp") & "'", sqlconn).ExecuteReader
        dry.Read()
        If dry.HasRows Then
            If dry.Item(0) = "Y" Then
                GV.SetColumnError(isPpn, "Nomor SP Dikunci Oleh User!", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                e.Cancel = True
            End If
        End If
        dry.Close()
    End Sub
End Class