﻿'tgl 19/06/2015
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class aFormCetakSJ1
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = True
    Public prn As frmMain
    Dim dsLookUp, dsNota As New DataSet
    Dim daLookUp, daNota As SqlDataAdapter
    Dim BTRANS As SqlTransaction
    Dim bld As New SqlCommandBuilder
    Dim role As String

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btnCetak
        End With
    End Sub

    Private Sub loadLookUp()
        'If Not dsLookUp.Tables("LookCust") Is Nothing Then dsLookUp.Tables("LookCust").Clear()
        If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS kode, nama_bulan + ' ' + thn_buku AS nama FROM SIF.dbo.SIF_Periode_Buku union all select '000000', '[Semua Periode]'", sqlconn))
        daLookUp.Fill(dsLookUp, "LookPeriode")
        lookPeriode.Properties.DataSource = dsLookUp.Tables("LookPeriode")
        lookPeriode.Properties.DisplayMember = "nama"
        lookPeriode.Properties.ValueMember = "kode"

        'daLookUp = New SqlDataAdapter(New SqlCommand("SELECT Kd_Customer, Nama_Customer FROM SIF.dbo.SIF_Customer ORDER BY Nama_Customer", sqlconn))
        'daLookUp.Fill(dsLookUp, "LookCust")
        'lckCustomer.Properties.DataSource = dsLookUp.Tables("LookCust")
        'lckCustomer.Properties.DisplayMember = "Nama_Customer"
        'lckCustomer.Properties.ValueMember = "Kd_Customer"

    End Sub

    Private Sub loadSales()
        If Not dsLookUp.Tables("LookSales") Is Nothing Then dsLookUp.Tables("LookSales").Clear()

        Dim drPost As SqlDataReader = New SqlCommand("select IDROLE from SIF.dbo.MUSER_ROLE where IDUSER = '" & username & "'", sqlconn).ExecuteReader

        drPost.Read()
        If drPost.HasRows Then
            role = drPost.Item(0)
        End If

        drPost.Close()

        If Not role = "FINARSPRING" Then
            daLookUp = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT Nama_Sales, Kode_Sales, kode_area, kode_wilayah FROM SIF.dbo.SIF_SALES WHERE Rec_Stat = 'Y' AND kode_departemen = '2' ORDER BY Nama_Sales", sqlconn))
        Else
            daLookUp = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT Nama_Sales, Kode_Sales, kode_area, kode_wilayah FROM SIF.dbo.SIF_SALES WHERE Rec_Stat = 'Y' AND kode_departemen = '3' ORDER BY Nama_Sales", sqlconn))
        End If
        daLookUp.Fill(dsLookUp, "LookSales")
        lckCustomer.Properties.DataSource = dsLookUp.Tables("LookSales")
        lckCustomer.Properties.DisplayMember = "Nama_Sales"
        lckCustomer.Properties.ValueMember = "Kode_Sales"
        GridView1.Columns("Kode_Sales").Visible = False
        GridView1.Columns("kode_area").Visible = False
        GridView1.Columns("kode_wilayah").Visible = False
    End Sub

    Private Sub loadNota()
        If Not dsNota.Tables("Nota") Is Nothing Then dsNota.Tables("Nota").Clear()

        Dim drPost As SqlDataReader = New SqlCommand("select IDROLE from SIF.dbo.MUSER_ROLE where IDUSER = '" & username & "'", sqlconn).ExecuteReader

        drPost.Read()
        If drPost.HasRows Then
            role = drPost.Item(0)
        End If

        drPost.Close()

        'If lookPeriode.EditValue = "000000" Then
        '    daNota = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT *,'' as divisi FROM FIN.dbo.FIN_NOTA WHERE jml_akhir > 0 AND NOT (no_posting IS NULL OR no_posting = '') AND tipe_trans LIKE 'JPJ%' AND tgl_inv < GETDATE() AND cek_sj = 'T' AND kd_cust LIKE '" & lckCustomer.EditValue & "'", sqlconn))
        'Else
        '    daNota = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT *,'' as divisi FROM FIN.dbo.FIN_NOTA WHERE jml_akhir > 0 AND NOT (no_posting IS NULL OR no_posting = '') AND tipe_trans LIKE 'JPJ%' AND tgl_inv < GETDATE() AND cek_sj = 'T' AND kd_cust LIKE '" & lckCustomer.EditValue & "' AND MONTH(tgl_inv) = " & Microsoft.VisualBasic.Right(lookPeriode.EditValue, 2) & " AND YEAR(tgl_inv) = " & Microsoft.VisualBasic.Left(lookPeriode.EditValue, 4), sqlconn))
        'End If
        If lookPeriode.EditValue = "000000" Then
            If role = "FINRASPRING" Then
                'daNota = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT x.nm_cust, x.no_inv, x.tgl_inv, x.no_sj, x.jml_tagihan, x.jml_bayar, x.jml_akhir, y.Desc_Data AS keterangan FROM FIN.dbo.FIN_NOTA x, SIF.dbo.SIF_Gen_Reff_D y WHERE x.jns_inv = y.Id_Data AND x.jml_akhir > 0 AND NOT (x.no_posting IS NULL OR x.no_posting = '') AND x.cek_sj = 'T' AND y.Id_Ref_File = 'JNSINV' AND x.tipe_trans = '" & SpringUmum & "' AND x.kd_cust IN (SELECT DIStINCT Kd_Customer FROM SIF.dbo.SIF_Customer WHERE Kd_Wilayah = '" & dsLookUp.Tables("LookSales").Select("Kode_Sales='" & lckCustomer.EditValue & "'")(0).Item("kode_wilayah").ToString & "' AND Kode_Area = '" & dsLookUp.Tables("LookSales").Select("Kode_Sales='" & lckCustomer.EditValue & "'")(0).Item("kode_area").ToString & "') ORDER BY x.nm_cust, y.Desc_Data, x.no_inv", sqlconn))
                daNota = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT x.*, (SELECT Desc_Data FROM SIF.dbo.SIF_Gen_Reff_D WHERE Id_Ref_File = 'JNSINV' AND Id_Data = x.jns_inv) as keteranganD FROM FIN.dbo.FIN_NOTA x WHERE x.jml_akhir > 0 AND NOT (x.no_posting IS NULL OR x.no_posting = '') AND x.tipe_trans = '" & SpringUmum & "' ORDER BY x.nm_cust, x.jns_inv, x.no_inv", sqlconn))
            Else
                daNota = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT x.*, (SELECT Desc_Data FROM SIF.dbo.SIF_Gen_Reff_D WHERE Id_Ref_File = 'JNSINV' AND Id_Data = x.jns_inv) as keteranganD FROM FIN.dbo.FIN_NOTA x WHERE x.jml_akhir > 0 AND NOT (x.no_posting IS NULL OR x.no_posting = '') AND x.tipe_trans = '" & SponUmum & "' ORDER BY x.nm_cust, x.jns_inv, x.no_inv", sqlconn))
                'daNota = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT x.nm_cust, x.no_inv, x.tgl_inv, x.no_sj, x.jml_tagihan, x.jml_bayar, x.jml_akhir, y.Desc_Data AS keterangan FROM FIN.dbo.FIN_NOTA x, SIF.dbo.SIF_Gen_Reff_D y WHERE x.jns_inv = y.Id_Data AND x.jml_akhir > 0 AND NOT (x.no_posting IS NULL OR x.no_posting = '') AND x.cek_sj = 'T' AND y.Id_Ref_File = 'JNSINV' AND x.tipe_trans = '" & SponUmum & "' AND x.kd_cust IN (SELECT DIStINCT Kd_Customer FROM SIF.dbo.SIF_Customer WHERE Kd_Wilayah = '" & dsLookUp.Tables("LookSales").Select("Kode_Sales='" & lckCustomer.EditValue & "'")(0).Item("kode_wilayah").ToString & "' AND Kode_Area = '" & dsLookUp.Tables("LookSales").Select("Kode_Sales='" & lckCustomer.EditValue & "'")(0).Item("kode_area").ToString & "') ORDER BY x.nm_cust, y.Desc_Data, x.no_inv", sqlconn))
            End If
        Else
            If role = "FINRASPRING" Then
                daNota = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT x.*, (SELECT Desc_Data FROM SIF.dbo.SIF_Gen_Reff_D WHERE Id_Ref_File = 'JNSINV' AND Id_Data = x.jns_inv) as keteranganD FROM FIN.dbo.FIN_NOTA x WHERE x.jml_akhir > 0 AND NOT (x.no_posting IS NULL OR x.no_posting = '') AND x.tipe_trans = '" & SpringUmum & "' AND MONTH(tgl_inv) = " & Microsoft.VisualBasic.Right(lookPeriode.EditValue, 2) & " AND YEAR(tgl_inv) = " & Microsoft.VisualBasic.Left(lookPeriode.EditValue, 4) & " ORDER BY x.nm_cust, x.jns_inv, x.no_inv", sqlconn))
            Else
                daNota = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT x.*, (SELECT Desc_Data FROM SIF.dbo.SIF_Gen_Reff_D WHERE Id_Ref_File = 'JNSINV' AND Id_Data = x.jns_inv) as keteranganD  FROM FIN.dbo.FIN_NOTA x WHERE x.jml_akhir > 0 AND NOT (x.no_posting IS NULL OR x.no_posting = '') AND x.tipe_trans = '" & SponUmum & "' AND MONTH(tgl_inv) = " & Microsoft.VisualBasic.Right(lookPeriode.EditValue, 2) & " AND YEAR(tgl_inv) = " & Microsoft.VisualBasic.Left(lookPeriode.EditValue, 4) & " ORDER BY x.nm_cust, x.jns_inv, x.no_inv", sqlconn))
            End If
            'daNota = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT *,'' as divisi FROM FIN.dbo.FIN_NOTA WHERE jml_akhir > 0 AND NOT (no_posting IS NULL OR no_posting = '') AND tipe_trans LIKE 'JPJ%' AND tgl_inv < GETDATE() AND cek_sj = 'T' AND kd_cust LIKE '" & lckCustomer.EditValue & "' AND MONTH(tgl_inv) = " & Microsoft.VisualBasic.Right(lookPeriode.EditValue, 2) & " AND YEAR(tgl_inv) = " & Microsoft.VisualBasic.Left(lookPeriode.EditValue, 4), sqlconn))
        End If
        daNota.Fill(dsNota, "Nota")
        gcDetil.DataSource = dsNota.Tables("Nota")
        'For Each row As DataRow In dsNota.Tables("Nota").Rows
        '    row.Item("divisi") = getDivisi(row.Item("no_inv"))
        '    row.Item("keterangan") = getKeterangan(row.Item("no_inv"))
        'Next
        gvDetil.BestFitColumns()
    End Sub

    Private Sub aFormCetakSJ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        'lblForm.Text = "         CETAK NOTA OUTSTANDING CUSTOMER PER " & Format(getTanggal(), "d/MMM/yyyy").ToUpper
        loadLookUp()
        lookPeriode.EditValue = "000000"
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        'If Not lckCustomer.EditValue = vbNullString Then
        'Else
        '    MsgBox("Customer belum dipilih.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ERROR!")
        '    Exit Sub
        'End If
        Dim x As Integer = New SqlCommand("update FIN.dbo.FIN_NOTA set cek_sj = 'T' where tipe_trans = '" & IIf(role = "FINRASPRING", "JPJ-KPT-01", "JPJ-KPT-02") & "' AND MONTH(tgl_inv) = " & Microsoft.VisualBasic.Right(lookPeriode.EditValue, 2) & " AND YEAR(tgl_inv) = " & Microsoft.VisualBasic.Left(lookPeriode.EditValue, 4), sqlconn).ExecuteNonQuery
        loadNota()
    End Sub

    Public Sub cetak_click()
        If Not dsNota.Tables("Nota").Rows.Count <= 0 Then

            For Each row As DataRow In dsNota.Tables("Nota").Rows
                If row.RowState = DataRowState.Modified Then
                    row.Item("tgl_rekap") = getTanggal()
                    row.Item("Last_update_date") = getTanggal()
                    row.Item("Last_updated_by") = username
                End If
            Next

            Try
                bld = New SqlCommandBuilder(daNota)
                daNota.InsertCommand = bld.GetInsertCommand()
                daNota.UpdateCommand = bld.GetUpdateCommand()
                daNota.DeleteCommand = bld.GetDeleteCommand()

                BTRANS = sqlconn.BeginTransaction("1")
                daNota.UpdateCommand.Transaction = BTRANS
                daNota.InsertCommand.Transaction = BTRANS
                daNota.DeleteCommand.Transaction = BTRANS

                daNota.Update(dsNota, "Nota")
                dsNota.Tables("Nota").AcceptChanges()

                BTRANS.Commit()
                'System.Threading.Thread.Sleep(1000)
                If role = "FINRASPRING" Then
                    callReport(App_Path() & "\report\repNotaOutstanding.rpt", "", "tipe=" & SpringUmum, False)
                Else
                    callReport(App_Path() & "\report\repNotaOutstanding.rpt", "", "tipe=" & SponUmum, False)
                End If
            Catch e As Exception
                BTRANS.Rollback()
                dsNota.Tables("Nota").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Cetak")
            End Try
        Else
            MsgBox("Tidak ada data yang dipilih untuk dicetak.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "PEMBERITAHUAN!")
        End If
    End Sub

    Private Function getDivisi(ByVal no_inv As String)
        Dim drNota As SqlDataReader = New SqlCommand("SELECT DISTINCT b.Nama_Departemen FROM FIN.dbo.FIN_NOTA a, SIF.dbo.SIF_Departemen b, SIF.dbo.SIF_TIPE_TRANS c WHERE a.tipe_trans = c.tipe_trans AND b.Kd_Departemen = c.kd_dept AND a.no_inv = '" & no_inv & "'", sqlconn).ExecuteReader
        drNota.Read()
        Dim hasil As String = drNota.Item(0)
        drNota.Close()
        Return hasil
    End Function

    Private Function getKeterangan(ByVal no_inv As String)
        Dim drNota As SqlDataReader = New SqlCommand("SELECT a.Desc_Data as keterangan FROM SIF.dbo.SIF_Gen_Reff_D a, FIN.dbo.FIN_NOTA b WHERE a.Id_Data = b.jns_inv AND a.Id_Ref_File = 'JNSINV' AND b.no_inv = '" & no_inv & "'", sqlconn).ExecuteReader
        drNota.Read()
        Dim hasil As String = drNota.Item(0)
        drNota.Close()
        Return hasil
    End Function

    Private Sub btnCentang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCentang.Click
        For i As Integer = 0 To gvDetil.RowCount - 1
            gvDetil.SetRowCellValue(i, "cek_sj", "Y")
        Next
        'For Each row As DataRow In dsNota.Tables("Nota").Rows
        '    row.Item("cek_sj") = "Y"
        'Next
    End Sub

    Private Sub btnCentang2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCentang2.Click
        For i As Integer = 0 To gvDetil.RowCount - 1
            gvDetil.SetRowCellValue(i, "cek_sj", "T")
        Next
        'For Each row As DataRow In dsNota.Tables("Nota").Rows
        '    row.Item("cek_sj") = "T"
        'Next
    End Sub

    Private Sub lckCustomer_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lckCustomer.QueryPopUp
        'loadSales()
    End Sub

    Private Sub lookPeriode_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lookPeriode.QueryPopUp
        loadLookUp()
    End Sub
End Class