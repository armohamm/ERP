Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Drawing
Imports DevExpress.XtraPrinting

Public Class aFormCetakSJHutang
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim dsLookUp, dsNota As New DataSet
    Dim daLookCust, daNota As SqlDataAdapter
    Dim BTRANS As SqlTransaction
    Dim bld As New SqlCommandBuilder
    Dim isOK As Boolean
    Dim milih As String

    Private Sub loadLookUp()
        If Not dsLookUp.Tables("LookSupp") Is Nothing Then dsLookUp.Tables("LookSupp").Clear()
        daLookCust = New SqlDataAdapter(New SqlCommand("SELECT Kode_Supplier, Nama_Supplier FROM SIF.dbo.SIF_Supplier ORDER BY Nama_Supplier", sqlconn))
        daLookCust.Fill(dsLookUp, "LookSupp")
        lckCustomer.Properties.DataSource = dsLookUp.Tables("LookSupp")
        lckCustomer.Properties.DisplayMember = "Nama_Supplier"
        lckCustomer.Properties.ValueMember = "Kode_Supplier"
    End Sub

    Private Sub loadNota(Optional ByVal cetak As Boolean = False)
        If Not dsNota.Tables("Nota") Is Nothing Then dsNota.Tables("Nota").Clear()
        If cetak = False Then
            daNota = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT * FROM FIN.dbo.FIN_PEMBELIAN WHERE jml_akhir >= 0 AND NOT (no_posting IS NULL OR no_posting = '') AND tipe_trans LIKE 'JPP%' AND kd_supplier LIKE '" & lckCustomer.EditValue & "'", sqlconn))
        Else
            daNota = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT * FROM FIN.dbo.FIN_PEMBELIAN WHERE jml_akhir >= 0 AND NOT (no_posting IS NULL OR no_posting = '') AND tipe_trans LIKE 'JPP%' AND kd_supplier LIKE '" & lckCustomer.EditValue & "' AND sts_tagihan = '1'", sqlconn))
        End If

        daNota.Fill(dsNota, "Nota")
        gcDetil.DataSource = dsNota.Tables("Nota")
        gvDetil.BestFitColumns()
    End Sub

    Private Sub aFormCetakSJ_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        'lblForm.Text = "CETAK NOTA OUTSTANDING CUSTOMER PER " & Format(getTanggal(), "d/MMM/yyyy").ToUpper
        loadLookUp()
        lckCustomer.ItemIndex = 0
    End Sub

    Private Sub btnCari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCari.Click
        If Not lckCustomer.EditValue = vbNullString Or lckCustomer.EditValue = "S00000" Then
            'Dim i As Integer = New SqlCommand("update FIN.dbo.FIN_PEMBELIAN set sts_tagihan='0' where kd_supplier like '" & lckCustomer.EditValue & "'", sqlconn).ExecuteNonQuery
            loadNota()
            For Each rw As DataRow In dsNota.Tables("Nota").Rows
                rw.Item("sts_tagihan") = "0"
            Next
        Else
            MsgBox("Customer belum dipilih.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "ERROR!")
            Exit Sub
        End If
    End Sub

    Public Sub cetak_click()
        For Each rw As DataRow In dsNota.Tables("Nota").Rows
            If rw.RowState = DataRowState.Modified Then
                If rw.Item("sts_tagihan").Equals(chkCetak.ValueChecked) Then
                    isOK = True
                    Exit For
                Else
                    isOK = False
                End If
            Else
                isOK = False
            End If
        Next

        If isOK Then
            If Not dsNota.Tables("Nota").Rows.Count <= 0 Then
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
                    loadNota(True)
                    gvDetil.Columns("sts_tagihan").Visible = False

                    Dim ph As DevExpress.XtraPrinting.PageHeaderFooter = CType(PrintableComponentLink1.PageHeaderFooter, PageHeaderFooter)
                    ph.Footer.Content.Add(username)
                    ph.Footer.Content.Add("")
                    ph.Footer.Content.Add("Hal. [Page #]")

                    PrintableComponentLink1.CreateDocument()
                    PrintableComponentLink1.ShowPreview()

                    gvDetil.Columns("sts_tagihan").Visible = True
                    loadNota()
                    For Each rw As DataRow In dsNota.Tables("Nota").Rows
                        rw.Item("sts_tagihan") = "0"
                    Next
                    'System.Threading.Thread.Sleep(1000)
                    'callReport(App_Path() & "\report\repNotaOutstanding.rpt", "", "cust=" & lckCustomer.EditValue, False)

                Catch e As Exception
                    BTRANS.Rollback()
                    dsNota.Tables("Nota").RejectChanges()
                    MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Cetak")
                End Try
            End If
        Else
            MsgBox("Tidak ada data yang dipilih untuk dicetak.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "PEMBERITAHUAN!")
        End If
    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "TAGIHAN OUTSTANDING SUPPLIER"
        Dim reportHeader2 As String = ":"
        Dim reportHeader3 As String = "PT. Dynasti Indomegah"
        Dim reportHeader4 As String = "Tanggal Cetak"
        Dim reportHeader5 As String = Format(getTanggal, "d MMMM yyyy")
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        e.Graph.BackColor = Color.White
        'MsgBox(e.Graph.ClientPageSize.Width.ToString)
        'MsgBox(e.Graph.MeasureString(reportHeader, e.Graph.ClientPageSize.Width).Width)
        Dim rec As RectangleF = New RectangleF(269, 0, e.Graph.MeasureString(reportHeader, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec2 As RectangleF = New RectangleF(125, 60, e.Graph.MeasureString(reportHeader2, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec3 As RectangleF = New RectangleF(0, 0, e.Graph.MeasureString(reportHeader3, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec4 As RectangleF = New RectangleF(0, 60, e.Graph.MeasureString(reportHeader4, e.Graph.ClientPageSize.Width).Width, 20)
        Dim rec5 As RectangleF = New RectangleF(150, 60, e.Graph.MeasureString(reportHeader5, e.Graph.ClientPageSize.Width).Width, 20)
        e.Graph.DrawString(reportHeader, Color.Black, rec, DevExpress.XtraPrinting.BorderSide.Bottom)
        e.Graph.DrawString(reportHeader2, Color.Black, rec2, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportHeader3, Color.Black, rec3, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportHeader4, Color.Black, rec4, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportHeader5, Color.Black, rec5, DevExpress.XtraPrinting.BorderSide.None)
    End Sub

    Private Sub gvDetil_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvDetil.DoubleClick
        milih = gvDetil.GetFocusedRowCellValue("no_inv").ToString()

        'daNota = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_PO where no_po='" & milih & "'", sqlconn))
        'daNota.Fill(dsLookUp, "_crpo")

        frmInvBME.STATE = "EDIT"
        frmInvBME.v_qc()
        frmInvBME.controlOff(True)
        frmInvBME.LoadStruktur(milih)
        frmInvBME.ShowDialog()
    End Sub
End Class