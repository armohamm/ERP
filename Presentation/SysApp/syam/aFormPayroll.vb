Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class aFormPayroll
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = True
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public prn As frmMain
    Public STATE As String
    Dim dsPayroll, dsLookUp As New DataSet
    Dim daPayroll, daLookUp As SqlDataAdapter
    Dim bldPayroll As New SqlCommandBuilder
    Dim BTRANS As SqlTransaction
    Dim isOK As Boolean = True
    Dim conn, SSQL, err As String
    Dim oleDA As OleDb.OleDbDataAdapter

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

    Public Sub loadData(ByVal kode As String)
        If Not dsPayroll.Tables("Payroll") Is Nothing Then dsPayroll.Tables("Payroll").Clear()
        daPayroll = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_PAYROLL WHERE thnbln = '" & kode & "'", sqlconn))
        daPayroll.Fill(dsPayroll, "Payroll")
        gcPayroll.DataSource = dsPayroll.Tables("Payroll")
        gvPayroll.BestFitColumns()
    End Sub

    Private Sub aFormPayroll_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        loadPeriode()
        lckPeriode.EditValue = Format(Now, "yyyyMM")
        dteTanggal.EditValue = Now
        loadData("XXX")
    End Sub

    Private Sub loadPeriode()
        If Not dsLookUp.Tables("Periode") Is Nothing Then dsLookUp.Tables("Periode").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS periode, nama_bulan + ' ' + thn_buku AS nama FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        daLookUp.Fill(dsLookUp, "Periode")
        lckPeriode.Properties.DataSource = dsLookUp.Tables("Periode")
        lckPeriode.Properties.DisplayMember = "nama"
        lckPeriode.Properties.ValueMember = "periode"
    End Sub

    Private Sub lckPeriode_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lckPeriode.QueryPopUp
        loadPeriode()
    End Sub

    Public Sub save_click(Optional ByVal del As Boolean = False)
        If Not del Then cek()

        If isOK Then
            Try
                bldPayroll = New SqlClient.SqlCommandBuilder(daPayroll)
                daPayroll.UpdateCommand = bldPayroll.GetUpdateCommand()
                daPayroll.InsertCommand = bldPayroll.GetInsertCommand()
                daPayroll.DeleteCommand = bldPayroll.GetDeleteCommand()
                daPayroll.Update(dsPayroll.Tables("Payroll"))

                If del Then
                    showMessages("Data terhapus.")
                Else
                    showMessages("Data tersimpan.")
                End If
                loadData("XXX")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Ada kesalahan : " & vbCrLf, MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "PERINGATAN!")
        End If
    End Sub

    Public Sub cancel_click()
        If Not dsPayroll.Tables("Payroll") Is Nothing Then dsPayroll.Tables("Payroll").Clear()
    End Sub

    Public Sub delete_click()
        If Not dsPayroll.Tables("Payroll") Is Nothing Then
            If MsgBox("Hapus data payroll periode " & lckPeriode.Text & " ?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "HAPUS?") = MsgBoxResult.Yes Then
                For Each row As DataRow In dsPayroll.Tables("Payroll").Rows
                    row.Delete()
                Next
                save_click(True)
            End If
        End If
    End Sub

    Public Sub call_procedure(ByVal tipeT As String, ByVal noG As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_JUR_PAYROLL"

        sqlCmd.ExecuteNonQuery()
    End Sub

    Private Sub cek()
        err = ""
        If gvPayroll.RowCount <= 0 Then
            isOK = False
            err += "Data belum di reload." & vbCrLf
        End If

        With New SqlCommand("select distinct thnbln from fin.dbo.fin_payroll", sqlconn).ExecuteReader
            While .Read()
                Try
                    If lckPeriode.EditValue = .Item(0) Then
                        isOK = False
                        err += "Periode payroll ini sudah terinput."
                        .Close()
                        Exit While
                    End If
                Catch ex As Exception
                    MsgBox("Error Occured : " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                    If Not .IsClosed Then .Close()
                End Try
            End While
        End With
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        OpenFileDialog1.ShowDialog()
        If OpenFileDialog1.FileName.ToString <> "" Then
            txtFile.EditValue = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnReload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReload.Click
        If Not dsPayroll.Tables("Payroll") Is Nothing Then dsPayroll.Tables("Payroll").Clear()
        If Not dsLookUp.Tables("file") Is Nothing Then dsLookUp.Tables("file").Clear()
        conn = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & txtFile.EditValue & ";Extended Properties=""Excel 8.0;"""
        SSQL = "SELECT nomor, nama, jumlah from `" & txtSheet.EditValue & "$`"
        oleDA = New OleDb.OleDbDataAdapter(SSQL, conn)
        oleDA.Fill(dsLookUp, "file")

        Dim i As Integer = 1

        For Each row As DataRow In dsLookUp.Tables("file").Rows
            Dim rowGrid As DataRow = dsPayroll.Tables("Payroll").NewRow
            rowGrid.Item("Kd_Cabang") = getKodeCabang()
            rowGrid.Item("tipe_trans") = "JKM-KBB-02"
            rowGrid.Item("thnbln") = lckPeriode.EditValue
            rowGrid.Item("no_sec") = i
            rowGrid.Item("tgl_input") = dteTanggal.EditValue
            rowGrid.Item("kd_kartu") = row.Item("nomor")
            rowGrid.Item("nm_kartu") = row.Item("nama")
            rowGrid.Item("jml_payroll") = row.Item("jumlah")
            rowGrid.Item("Last_Created_By") = username
            rowGrid.Item("Last_Create_Date") = Now
            rowGrid.Item("Program_Name") = Me.Name
            dsPayroll.Tables("Payroll").Rows.Add(rowGrid)
            i += 1
        Next
        gvPayroll.BestFitColumns()
    End Sub

    Private Sub btnLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoad.Click
        If Not lckPeriode.EditValue = vbNullString Then
            loadData(lckPeriode.EditValue)
        Else
            MsgBox("Pilih periode dahulu.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "PERINGATAN!")
            Exit Sub
        End If
    End Sub
End Class