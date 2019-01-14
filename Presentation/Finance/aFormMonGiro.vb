'sss
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports System.Drawing
Imports DevExpress.XtraPrinting

Public Class aFormMonGiro
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = True
    Public prn As frmMain
    Dim dsGiro, dsLookUp As New DataSet
    Dim daGiro, daGiroDetil, daLookCust, daLookBank, daLookValuta As SqlDataAdapter
    Dim relNota As DataRelation
    Dim err As String
    Dim isSearch As Boolean = True
    Dim subReport As String

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

    Public Sub loadLookUp()
        '############ LOAD CUSTOMER ############
        If Not dsLookUp.Tables("LookCust") Is Nothing Then dsLookUp.Tables("LookCust").Clear()
        daLookCust = New SqlDataAdapter(New SqlCommand("SELECT kode, nama FROM FIN.dbo.v_kartu", sqlconn))
        daLookCust.Fill(dsLookUp, "LookCust")
        lookupKartu.DataSource = dsLookUp.Tables("LookCust")
        lookupKartu.DisplayMember = "nama"
        lookupKartu.ValueMember = "kode"

        '############ LOAD BANK ############
        If Not dsLookUp.Tables("LookBank") Is Nothing Then dsLookUp.Tables("LookBank").Clear()
        daLookBank = New SqlDataAdapter(New SqlCommand("SELECT kd_bank, nama_bank FROM SIF.dbo.SIF_Bank", sqlconn))
        daLookBank.Fill(dsLookUp, "LookBank")
        lookupBank.DataSource = dsLookUp.Tables("LookBank")
        lookupBank.DisplayMember = "nama_bank"
        lookupBank.ValueMember = "kd_bank"

        '############ LOAD VALUTA ############
        If Not dsLookUp.Tables("LookValuta") Is Nothing Then dsLookUp.Tables("LookValuta").Clear()
        daLookValuta = New SqlDataAdapter(New SqlCommand("SELECT Kode_Valuta, Nama_Valuta FROM SIF.dbo.SIF_Valuta", sqlconn))
        daLookValuta.Fill(dsLookUp, "LookValuta")
        lookupValuta.DataSource = dsLookUp.Tables("LookValuta")
        lookupValuta.DisplayMember = "Nama_Valuta"
        lookupValuta.ValueMember = "Kode_Valuta"

        If Not dsLookUp.Tables("LookDivisi") Is Nothing Then dsLookUp.Tables("LookDivisi").Clear()
        daLookValuta = New SqlDataAdapter(New SqlCommand("SELECT Kd_Departemen, Nama_Departemen FROM SIF.dbo.SIF_Departemen", sqlconn))
        daLookValuta.Fill(dsLookUp, "LookDivisi")
        lookupDivisi.DataSource = dsLookUp.Tables("LookDivisi")
        lookupDivisi.DisplayMember = "Nama_Departemen"
        lookupDivisi.ValueMember = "Kd_Departemen"
    End Sub

    Public Sub loadData(Optional ByVal x As String = "Semua")
        dsGiro.Clear()
        dsGiro.Relations.Clear()
        'If Not dsNota.Tables("Nota") Is Nothing Then dsNota.Tables("Nota").Clear()
        'If Not dsNota.Tables("NotaDetil") Is Nothing Then dsNota.Tables("NotaDetil").Clear()

        If x = "Semua" Then
            If cmbJenis.Text = "Jual" Then
                If deTglAwal.EditValue = vbNullString Or deTglAkhir.EditValue = vbNullString Then
                    daGiro = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_GIRO WHERE jns_trans='JUAL' and divisi = '" & IIf(userRole = "FINRASPRING", "2", "3") & "'", sqlconn))
                    daGiro.Fill(dsGiro, "Giro")
                    daGiroDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_TRANS_GIRO WHERE no_giro IN (SELECT nomor FROM FIN.dbo.FIN_GIRO WHERE jns_trans='JUAL' and divisi = '" & IIf(userRole = "FINRASPRING", "2", "3") & "')", sqlconn))
                    daGiroDetil.Fill(dsGiro, "GiroDetil")
                ElseIf deTglAwal.EditValue = deTglAkhir.EditValue Then
                    daGiro = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_GIRO WHERE jns_trans='JUAL' and divisi = '" & IIf(userRole = "FINRASPRING", "2", "3") & "' AND tgl_trans = CONVERT(DATE,'" & Format(deTglAwal.EditValue, "dd/MM/yyyy") & "',103)", sqlconn))
                    daGiro.Fill(dsGiro, "Giro")
                    daGiroDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_TRANS_GIRO WHERE no_giro IN (SELECT nomor FROM FIN.dbo.FIN_GIRO WHERE jns_trans='JUAL' and divisi = '" & IIf(userRole = "FINRASPRING", "2", "3") & "' AND tgl_trans = CONVERT(DATE,'" & Format(deTglAwal.EditValue, "dd/MM/yyyy") & "',103))", sqlconn))
                    daGiroDetil.Fill(dsGiro, "GiroDetil")
                Else
                    daGiro = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_GIRO WHERE jns_trans='JUAL' and divisi = '" & IIf(userRole = "FINRASPRING", "2", "3") & "' AND tgl_trans BETWEEN CONVERT(DATE,'" & Format(deTglAwal.EditValue, "dd/MM/yyyy") & "',103) AND CONVERT(DATE,'" & Format(deTglAkhir.EditValue, "dd/MM/yyyy") & "',103)", sqlconn))
                    daGiro.Fill(dsGiro, "Giro")
                    daGiroDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_TRANS_GIRO WHERE no_giro IN (SELECT nomor FROM FIN.dbo.FIN_GIRO WHERE jns_trans='JUAL' and divisi = '" & IIf(userRole = "FINRASPRING", "2", "3") & "' AND tgl_trans BETWEEN CONVERT(DATE,'" & Format(deTglAwal.EditValue, "dd/MM/yyyy") & "',103) AND CONVERT(DATE,'" & Format(deTglAkhir.EditValue, "dd/MM/yyyy") & "',103))", sqlconn))
                    daGiroDetil.Fill(dsGiro, "GiroDetil")
                End If
            ElseIf cmbJenis.Text = "Beli" Then
                If deTglAwal.EditValue = vbNullString Or deTglAkhir.EditValue = vbNullString Then
                    daGiro = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_GIRO WHERE jns_trans='BELI'", sqlconn))
                    daGiro.Fill(dsGiro, "Giro")
                    daGiroDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_TRANS_GIRO WHERE no_giro IN (SELECT nomor FROM FIN.dbo.FIN_GIRO WHERE jns_trans='BELI')", sqlconn))
                    daGiroDetil.Fill(dsGiro, "GiroDetil")
                ElseIf deTglAwal.EditValue = deTglAkhir.EditValue Then
                    daGiro = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_GIRO WHERE jns_trans='BELI' AND tgl_trans = CONVERT(DATE,'" & Format(deTglAwal.EditValue, "dd/MM/yyyy") & "',103)", sqlconn))
                    daGiro.Fill(dsGiro, "Giro")
                    daGiroDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_TRANS_GIRO WHERE no_giro IN (SELECT nomor FROM FIN.dbo.FIN_GIRO WHERE jns_trans='BELI' AND tgl_trans = CONVERT(DATE,'" & Format(deTglAwal.EditValue, "dd/MM/yyyy") & "',103))", sqlconn))
                    daGiroDetil.Fill(dsGiro, "GiroDetil")
                Else
                    daGiro = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_GIRO WHERE jns_trans='BELI' AND tgl_trans BETWEEN CONVERT(DATE,'" & Format(deTglAwal.EditValue, "dd/MM/yyyy") & "',103) AND CONVERT(DATE,'" & Format(deTglAkhir.EditValue, "dd/MM/yyyy") & "',103)", sqlconn))
                    daGiro.Fill(dsGiro, "Giro")
                    daGiroDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_TRANS_GIRO WHERE no_giro IN (SELECT nomor FROM FIN.dbo.FIN_GIRO WHERE jns_trans='BELI' AND tgl_trans BETWEEN CONVERT(DATE,'" & Format(deTglAwal.EditValue, "dd/MM/yyyy") & "',103) AND CONVERT(DATE,'" & Format(deTglAkhir.EditValue, "dd/MM/yyyy") & "',103))", sqlconn))
                    daGiroDetil.Fill(dsGiro, "GiroDetil")
                End If
                'ElseIf cmbJenis.Text = "[Semua Transaksi]" Then
                '    If deTglAwal.EditValue = vbNullString Or deTglAkhir.EditValue = vbNullString Then
                '        daGiro = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_GIRO", sqlconn))
                '        daGiro.Fill(dsGiro, "Giro")
                '        daGiroDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_TRANS_GIRO WHERE no_giro IN (SELECT nomor FROM FIN.dbo.FIN_GIRO)", sqlconn))
                '        daGiroDetil.Fill(dsGiro, "GiroDetil")
                '    Else
                '        daGiro = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_GIRO WHERE (jns_trans='BELI' OR jns_trans='JUAL')  AND tgl_trans BETWEEN CONVERT(DATE,'" & Format(deTglAwal.EditValue, "dd/MM/yyyy") & "',103) AND CONVERT(DATE,'" & Format(deTglAkhir.EditValue, "dd/MM/yyyy") & "',103)", sqlconn))
                '        daGiro.Fill(dsGiro, "Giro")
                '        daGiroDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_TRANS_GIRO WHERE no_giro IN (SELECT nomor FROM FIN.dbo.FIN_GIRO WHERE tgl_trans BETWEEN CONVERT(DATE,'" & Format(deTglAwal.EditValue, "dd/MM/yyyy") & "',103) AND CONVERT(DATE,'" & Format(deTglAkhir.EditValue, "dd/MM/yyyy") & "',103))", sqlconn))
                '        daGiroDetil.Fill(dsGiro, "GiroDetil")
                '    End If
            End If
        ElseIf x = "Hari Ini" Then
            daGiro = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_GIRO WHERE tgl_trans = CONVERT(DATE,'" & Format(getTanggal(), "dd/MM/yyyy") & "',103)", sqlconn))
            daGiro.Fill(dsGiro, "Giro")
            daGiroDetil = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_TRANS_GIRO WHERE no_giro IN (SELECT nomor FROM FIN.dbo.FIN_GIRO WHERE tgl_trans = CONVERT(DATE,'" & Format(getTanggal(), "dd/MM/yyyy") & "',103))", sqlconn))
            daGiroDetil.Fill(dsGiro, "GiroDetil")
        End If

        relNota = dsGiro.Relations.Add("DetilGiro", dsGiro.Tables("Giro").Columns("nomor"), dsGiro.Tables("GiroDetil").Columns("no_giro"))
        gcGiro.DataSource = dsGiro.Tables("Giro")
        gcGiro.LevelTree.Nodes.Add("DetilGiro", gvGiroTrans)
        gvGiro.BestFitColumns()
        gvGiroTrans.BestFitColumns()
    End Sub

    Private Sub aFormMonGiro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        deTglAwal.EditValue = getTanggal()
        deTglAkhir.EditValue = getTanggal()
        cmbJenis.Text = "Jual"
        loadLookUp()
        loadData("Hari Ini")
        btnCetak = True
        setStatus()
    End Sub

    Private Sub deTglAwal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTglAwal.EditValueChanged
        If Not deTglAwal.EditValue = vbNullString Then
            If deTglAkhir.EditValue < deTglAwal.EditValue Then
                err &= "Filter tanggal awal transaksi tidak boleh lebih dari tanggal akhir." & vbCrLf
                isSearch = False
            Else
                err = ""
                isSearch = True
            End If
        ElseIf deTglAwal.EditValue = getTanggal() Then
            err = ""
            isSearch = True
        Else
            'deTglAwal.EditValue = getTanggal()
        End If
    End Sub

    Private Sub deTglAkhir_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTglAkhir.EditValueChanged
        If Not deTglAkhir.EditValue = vbNullString Then
            If deTglAkhir.EditValue < deTglAwal.EditValue Then
                err &= "Filter tanggal akhir transaksi tidak boleh kurang dari tanggal awal." & vbCrLf
                isSearch = False
            Else
                err = ""
                isSearch = True
            End If
        ElseIf deTglAkhir.EditValue = getTanggal() Then
            err = ""
            isSearch = True
        Else
            'deTglAkhir.EditValue = getTanggal()
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        If isSearch = True Then
            loadData()
        Else
            MsgBox(err, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR!")
            err = ""
        End If
    End Sub

    Private Sub chkJt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkJt.CheckedChanged
        If chkJt.Checked = True Then
            chkMin7.Checked = False
            chkMax7.Checked = False
            gvGiro.ActiveFilterString = "GetDate(Now()) >= tgl_jth_tempo"
        ElseIf chkJt.Checked = False Then
            gvGiro.ActiveFilterString = ""
        End If
    End Sub

    Private Sub chkMin7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMin7.CheckedChanged
        If chkMin7.Checked = True Then
            chkJt.Checked = False
            chkMax7.Checked = False
            gvGiro.ActiveFilterString = "GetDate(Now()) < tgl_jth_tempo And GetDate(Now()) >= GetDate(AddDays(tgl_jth_tempo, -7))"
        ElseIf chkJt.Checked = False Then
            gvGiro.ActiveFilterString = ""
        End If
    End Sub

    Private Sub chkMax7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkMax7.CheckedChanged
        If chkMax7.Checked = True Then
            chkJt.Checked = False
            chkMin7.Checked = False
            gvGiro.ActiveFilterString = "GetDate(Now()) < GetDate(AddDays(tgl_jth_tempo, -7))"
        ElseIf chkJt.Checked = False Then
            gvGiro.ActiveFilterString = ""
        End If
    End Sub

    Sub ShowGridPreview(ByVal grid As DevExpress.XtraGrid.GridControl)
        ' Check whether the XtraGrid control can be previewed. 
        If Not grid.IsPrintingAvailable Then
            MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error")
            Return
        End If
        ' Opens the Preview window. 
        grid.ShowPrintPreview()
    End Sub

    Public Sub cetak_click()
        If Not gvGiro.RowCount <= 0 Then
            'ShowGridPreview(gcGiro)
            PrintableComponentLink1.CreateDocument()
            PrintableComponentLink1.ShowPreview()
        Else
            MsgBox("Tidak ada data yang dicetak. Silahkan mengisi filter dan menekan tombol Refresh.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
        End If
    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "MONITORING GIRO"
        If deTglAwal.EditValue = deTglAkhir.EditValue Then
            subReport = "Per tanggal " & Format(deTglAkhir.EditValue, "d MMMM yyyy").ToString
        Else
            subReport = Format(deTglAwal.EditValue, "d MMMM yyyy").ToString & " s/d " & Format(deTglAkhir.EditValue, "d MMMM yyyy").ToString
        End If

        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        e.Graph.BackColor = Color.White
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 20)
        Dim rec2 As RectangleF = New RectangleF(0, 20, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None)
        e.Graph.DrawString(subReport, Color.Black, rec2, BorderSide.None)
    End Sub

    Private Sub btnToday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToday.Click
        If isSearch = True Then
            loadData("Hari Ini")
            deTglAwal.EditValue = vbNullString
            deTglAkhir.EditValue = vbNullString
        Else
            MsgBox(err, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR!")
            err = ""
        End If
    End Sub
End Class