Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmSuratJalan2
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA As SqlDataAdapter
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Dim myBuilder As New SqlCommandBuilder
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = False
            .btnCancel.Enabled = False
            .btnDelete.Enabled = False
            .btnEdit.Enabled = False
            .btnSave.Enabled = True
            .btnCetak.Enabled = False
        End With
    End Sub
    Private Sub frmSuratJalan2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()

        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct no_trans_krm, no_pol, kd_sopir, kd_kenek , '0' as cetak, getdate() TGLCETAK from prod.dbo.PROD_dpb_m where no_trans_krm in (select no_ref from inv.[dbo].INV_GUDANG_OUT) and no_trans not in (select isnull(no_dpb,'') from sales.dbo.sales_sj)", sqlconn))
        dadbe.Fill(dsete, "MOBIL")

        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, '0' as cetak, '' as no_sj, getDate() as tgl_cetak , '' as Status, '' as Alasan, (select tanggal from prod.dbo.prod_rcn_krm_m where no_trans=no_trans_krm) tgl_rcn from prod.dbo.PROD_dpb_m where no_trans_krm in (select no_ref from inv.[dbo].INV_GUDANG_OUT) and no_trans not in (select isnull(no_dpb,'') from sales.dbo.sales_sj)", sqlconn))
        dadbe.Fill(dsete, "DPB")
        
        Dim rl As DataRelation
        Dim parentCol(1) As DataColumn
        Dim ChildCol(1) As DataColumn

        parentCol(0) = dsete.Tables("MOBIL").Columns("no_trans_krm")
        parentCol(1) = dsete.Tables("MOBIL").Columns("no_pol")

        ChildCol(0) = dsete.Tables("DPB").Columns("no_trans_krm")
        ChildCol(1) = dsete.Tables("DPB").Columns("no_pol")

        'rl = dsete.Relations.Add("Detail", dsete.Tables("MOBIL").Columns("no_pol"), dsete.Tables("DPB").Columns("no_pol"), False)
        rl = dsete.Relations.Add("Detail", parentCol, ChildCol, False)

        rl.Nested = True
        GC.LevelTree.Nodes.Add("Detail", GV)

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, '0' as cetak from sales.dbo.sales_sj where isnull(isPrinted,'') <> 'Y'", sqlconn))
        DA.Fill(dsete, "SJ")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Kendaraan, (Nama_Kendaraan + '-' + No_Polisi) as Nama_Kendaraan from sif.dbo.SIF_Kendaraan", sqlconn))
        dadbe.Fill(dsete, "Kendaraan")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Sopir", sqlconn))
        dadbe.Fill(dsete, "Sopir")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Customer, Nama_Customer from sif.dbo.SIF_Customer", sqlconn))
        dadbe.Fill(dsete, "Customer")
        GC.DataSource = dsete.Tables("MOBIL")
        repCustomer.DataSource = dsete.Tables("Customer")
        repNoPol.DataSource = dsete.Tables("Kendaraan")
        repSopir.DataSource = dsete.Tables("Sopir")
        GV.BestFitColumns()

        prn = frmMain
        setStatus()
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

    End Sub
    Public Sub add_click()

    End Sub
    Public Sub save_click()
        If GC.MainView.Name = GVM.Name Then
            btnSave = False
            setStatus()
            showMessages("Printing..", , "LOADING")
            frmMessage.Refresh()
            For Each dr As DataRow In dsete.Tables("DPB").Select("cetak='1'", "")
                dr("no_sj") = proses(dr)
                If Mid(dr("no_sj"), 1, 1) <> "!" Then
                    Dim i As Int16 = New SqlCommand("update sales.dbo.sales_sj set cetakke= isnull(CetakKe,0)+1, isPrinted='Y' where no_sp='" & dr("no_sp") & "' and isnull(isprinted,'') <> 'Y' ", sqlconn).ExecuteNonQuery
                    If i > 0 Then
                        If callReport(App_Path() & "\report\vSj.rpt", "", "NOSJ=" & dr("no_sj"), True, True, "DIM") Then
                            dr("Status") = "OK"
                        Else
                            dr("Status") = "! Gagal Cetak"
                        End If
                    Else
                        dr("Status") = "! Sudah Pernah Cetak"
                    End If
                End If
            Next
            frmMessage.Close()
            btnSave = True
            setStatus()
        Else
            btnSave = False
            setStatus()
            For Each dr As DataRow In dsete.Tables("SJ").Select("cetak='1'", "")
                Try
                    Dim i As Int16 = New SqlCommand("update sales.dbo.sales_sj set cetakke= isnull(CetakKe,0)+1, isPrinted='Y' where no_sj='" & dr("no_sj") & "'", sqlconn).ExecuteNonQuery
                    If i > 0 Then
                        If "1" = "1" Then
                            Dim cmd As New SqlCommand
                            cmd.Connection = sqlconn
                            cmd.CommandText = "SALES.[dbo].[buatUlangSuratJalan]"
                            cmd.CommandType = CommandType.StoredProcedure
                            cmd.Parameters.Add("@no_sj", SqlDbType.VarChar, 30)
                            cmd.Parameters.Add("@kdpeg", SqlDbType.VarChar, 30)
                            cmd.Parameters("@no_sj").Value = dr("no_sj")
                            cmd.Parameters("@kdpeg").Value = kdpeg
                            cmd.ExecuteNonQuery()
                        End If
                        If callReport(App_Path() & "\report\vSj.rpt", "", "NOSJ=" & dr("no_sj"), True, True, "DIM") Then
                            dr("Sts") = "OK"
                        Else
                            dr("Sts") = "! Gagal Cetak"
                        End If
                    Else
                        dr("Sts") = "Dokumen Pernah Dicetak"

                    End If

                Catch ex As Exception

                    dr("Sts") = "! Failed"
                End Try
            Next
            btnSave = True
            setStatus()
        End If
        ' cmdRefresh_Click(cmdRefresh, New EventArgs)
    End Sub

    Private Function proses(ByVal dr As DataRow) As String
        Dim btrans As SqlTransaction
        Try
            btrans = sqlconn.BeginTransaction
            Dim sqlcmd As New SqlCommand
            Dim no_sj As String
            Dim thnbln As String
            Dim tgl As Date = getTanggal(btrans).Date
            thnbln = tgl.Year.ToString & ("0" & tgl.Month.ToString).Substring(0, 2)
            sqlcmd.Connection = sqlconn
            sqlcmd.Transaction = btrans
            sqlcmd.CommandType = CommandType.StoredProcedure
            sqlcmd.CommandText = "sales.dbo.buatSuratJalan"
            sqlcmd.Parameters.Add("@no_gdng_out", SqlDbType.VarChar, 40).Value = dr("no_trans")
            sqlcmd.Parameters.Add("@no_sp", SqlDbType.VarChar, 40).Value = dr("no_sp")
            sqlcmd.Parameters.Add("@kdpeg", SqlDbType.VarChar, 40).Value = username
            sqlcmd.Parameters.Add("@tglsj", SqlDbType.Date).Value = dr("tgl_cetak")
            sqlcmd.Parameters.Add("@no_sj2", SqlDbType.VarChar, 100)
            sqlcmd.Parameters("@no_sj2").Direction = ParameterDirection.Output
            sqlcmd.ExecuteNonQuery()
            no_sj = sqlcmd.Parameters("@no_sj2").Value.ToString

            Dim sqlcmd2 As New SqlCommand
            sqlcmd2.Connection = sqlconn
            sqlcmd2.Transaction = btrans
            sqlcmd2.CommandType = CommandType.StoredProcedure
            sqlcmd2.CommandText = "sales.[dbo].ExecBookedOut"
            sqlcmd2.Parameters.AddWithValue("@no_sj", no_sj)
            sqlcmd2.ExecuteNonQuery()

            'untuk sementara dimark karena masih error
            'With New SqlCommand("select sjd.kd_cabang, kode_barang, sjd.kd_satuan, kd_ukuran, qty_kirim from sales.dbo.sales_sj_d sjd, sif.dbo.sif_barang brg where no_sj = '" & no_sj & "' and kd_stok=kode_barang", sqlconn, btrans).ExecuteReader
            '    While .Read
            '        Dim sqlcmd2 As New SqlCommand
            '        sqlcmd2.Connection = sqlconn
            '        sqlcmd2.Transaction = btrans
            '        sqlcmd2.CommandType = CommandType.StoredProcedure
            '        sqlcmd2.CommandText = "inv.[dbo].[inv_stok_saldo_booked_out]"
            '        sqlcmd2.Parameters.AddWithValue("@kd_cabang", .Item("kd_cabang"))
            '        sqlcmd2.Parameters.AddWithValue("@bultah", thnbln)
            '        sqlcmd2.Parameters.AddWithValue("@kd_stok", .Item("kode_barang"))
            '        sqlcmd2.Parameters.AddWithValue("@kd_satuan", .Item("kd_satuan"))
            '        sqlcmd2.Parameters.AddWithValue("@kd_ukuran", .Item("kd_ukuran"))
            '        sqlcmd2.Parameters.AddWithValue("@tinggi", .Item("tinggi"))
            '        sqlcmd2.Parameters.AddWithValue("@lebar", .Item("lebar"))
            '        sqlcmd2.Parameters.AddWithValue("@panjang", .Item("panjang"))
            '        sqlcmd2.Parameters.AddWithValue("@booked_out", .Item("qty_kirim"))
            '        sqlcmd2.ExecuteNonQuery()
            '    End While
            '    .Close()
            'End With
            btrans.Commit()
            Return no_sj
        Catch ex As Exception
            If Not btrans Is Nothing Then btrans.Rollback()
            proses = "! Failed " & ex.Message
        End Try
    End Function

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        If Not dsete.Tables("MOBIL") Is Nothing Then dsete.Tables("MOBIL").Clear()
        If Not dsete.Tables("DPB") Is Nothing Then dsete.Tables("DPB").Clear()

        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct no_trans_krm, no_pol, kd_sopir, kd_kenek , '0' as cetak, getdate() as TGLCETAK from prod.dbo.PROD_dpb_m where no_trans_krm in (select no_ref from inv.[dbo].INV_GUDANG_OUT) and no_trans not in (select isnull(no_dpb,'') from sales.dbo.sales_sj)", sqlconn))
        dadbe.Fill(dsete, "MOBIL")

        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, '0' as cetak, '' as no_sj, getDate() as tgl_cetak , '' as Status, '' as Alasan, (select tanggal from prod.dbo.prod_rcn_krm_m where no_trans=no_trans_krm) tgl_rcn from prod.dbo.PROD_dpb_m where no_trans_krm in (select no_ref from inv.[dbo].INV_GUDANG_OUT) and no_trans not in (select isnull(no_dpb,'') from sales.dbo.sales_sj)", sqlconn))
        dadbe.Fill(dsete, "DPB")

        If Not dsete.Tables("SJ") Is Nothing Then dsete.Tables("SJ").Clear()

        'DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * ,'0' as cetak, '0' as BU, '' Sts from sales.dbo.sales_sj where (status='OK' and tgl_kirim is null) or isnull(isPrinted,'')=''", sqlconn))
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * ,'0' as cetak, '0' as BU, '' Sts from sales.dbo.sales_sj where status='OK' and isnull(isPrinted,'')='Y'", sqlconn))
        DA.Fill(dsete, "SJ")

        GC.RefreshDataSource()

    End Sub

    Private Sub SJ_BARU_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SJ_BARU.Click
        GC.MainView = GVM
        If Not dsete.Tables("MOBIL") Is Nothing Then dsete.Tables("MOBIL").Clear()
        If Not dsete.Tables("DPB") Is Nothing Then dsete.Tables("DPB").Clear()

        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct no_trans_krm, no_pol, kd_sopir, kd_kenek , '0' as cetak from prod.dbo.PROD_dpb_m where no_trans_krm in (select no_ref from inv.[dbo].INV_GUDANG_OUT) and no_trans not in (select isnull(no_dpb,'') from sales.dbo.sales_sj)", sqlconn))
        dadbe.Fill(dsete, "MOBIL")

        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *, '0' as cetak, '' as no_sj, getDate() as tgl_cetak , '' as Status, '' as Alasan, (select tanggal from prod.dbo.prod_rcn_krm_m where no_trans=no_trans_krm) tgl_rcn from prod.dbo.PROD_dpb_m where no_trans_krm in (select no_ref from inv.[dbo].INV_GUDANG_OUT) and no_trans not in (select isnull(no_dpb,'') from sales.dbo.sales_sj)", sqlconn))
        dadbe.Fill(dsete, "DPB")

        'dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct no_pol, kd_sopir, kd_kenek , '0' as cetak from prod.dbo.PROD_dpb_m where no_trans_krm in (select no_ref from inv.[dbo].INV_GUDANG_OUT) and no_trans not in (select isnull(no_dpb,'') from sales.dbo.sales_sj)", sqlconn))
        'dadbe.Fill(dsete, "MOBIL")

        'dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select dpb.*, '0' as cetak, '' as no_sj, getDate() as tgl_cetak , '' as Status from prod.dbo.PROD_dpb_m dpb, sales.dbo.SALES_SO  so " & _
        '"where no_trans_krm in (select no_ref from inv.[dbo].INV_GUDANG_OUT) and no_trans not in (select isnull(no_dpb,'') from sales.dbo.sales_sj)" & _
        '"and dpb.no_sp=so.No_sp and departement like '" & rJenisSp.EditValue & "'", sqlconn))
        'dadbe.Fill(dsete, "DPB")

        GC.DataSource = dsete.Tables("MOBIL")
        GC.RefreshDataSource()
    End Sub

    Private Sub Cetak_Ulang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cetak_Ulang.Click
        GC.MainView = GVD
        GC.DataSource = dsete.Tables("SJ")
        If Not dsete.Tables("SJ") Is Nothing Then dsete.Tables("SJ").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * ,'0' as cetak, '0' as BU ,'' Sts from sales.dbo.sales_sj where status='OK' and isnull(sts_nota,'')=''", sqlconn))
        DA.Fill(dsete, "SJ")
        GC.RefreshDataSource()
    End Sub


    Private Sub repCetaku_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles repCetaku.ButtonClick
        Dim rhandle As Int16 = GVD.GetSelectedRows(0)
        If GVD.GetRowCellValue(rhandle, "Alasan").ToString = "" Then
            GVD.SetColumnError(Alasan, "Harap Mengisi Alasan Cetak Ulang", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        Else
            GVD.ClearColumnErrors()
            Dim i As Int16 = ("0" & GVD.GetRowCellValue(rhandle, "cetak_ke").ToString) + 1
            GVD.SetFocusedRowCellValue("cetak_ke", i.ToString)
            GVD.SetFocusedRowCellValue("Tgl_Cetak", getTanggal.ToString)
        End If
        myBuilder = New SqlClient.SqlCommandBuilder(DA)
        myBuilder.ConflictOption = ConflictOption.OverwriteChanges
        DA.UpdateCommand = myBuilder.GetUpdateCommand()
        GVD.UpdateCurrentRow()
        DA.Update(dsete.Tables("SJ"))
    End Sub

    Private Sub GVM_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GVM.CellValueChanged
        If e.Column Is cetakM Then
            For Each rw As DataRow In dsete.Tables("DPB").Select("no_pol='" & GVM.GetRowCellValue(e.RowHandle, "no_pol").ToString & "' and no_trans_krm = '" & GVM.GetRowCellValue(e.RowHandle, "no_trans_krm").ToString & "'", "")
                rw("cetak") = e.Value
                GVM.ExpandMasterRow(e.RowHandle, "Detail")
            Next
        ElseIf e.Column Is TGLCETAK Then
            For Each rw As DataRow In dsete.Tables("DPB").Select("no_pol='" & GVM.GetRowCellValue(e.RowHandle, "no_pol").ToString & "' and no_trans_krm = '" & GVM.GetRowCellValue(e.RowHandle, "no_trans_krm").ToString & "'", "")
                rw("tgl_cetak") = e.Value
                GVM.ExpandMasterRow(e.RowHandle, "Detail")
            Next
        End If
    End Sub

    Private Sub rJenisSp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rJenisSp.SelectedIndexChanged
        cmdRefresh_Click(cmdRefresh, New EventArgs)
    End Sub
End Class