Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmMonOmzetSales
    Dim dsete As New DataSet
    Dim DA As SqlDataAdapter
    Dim prn As frmMain
    Dim STATE As String
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Dim lanjut As Boolean = False
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Private Sub frmMonOmzetSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sales.dbo.getOmzetSales('" & txtSales.EditValue & "','" & txtTahun.Text & "')", sqlconn))

        DA.Fill(dsete, "data")
        GC.DataSource = dsete.Tables("data")
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Sales, Nama_Sales from sif.dbo.sif_sales union select '%%','ALL' ", sqlconn))
        DA.Fill(dsete, "CUSTOMER")
        txtSales.Properties.DataSource = dsete.Tables("CUSTOMER")

        prn = frmMain
        setStatus()
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
    End Sub
    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        If txtTahun.Text = "" Then
            showMessages("Harap Mengisi Periode", , "WARNING")
            Exit Sub
        End If
        If rTampilan.EditValue = "G" And txtSales.EditValue Is Nothing Then
            showMessages("Harap Mengisi Sales", , "WARNING")
            Exit Sub
        End If
        If rTampilan.EditValue = "G" And txtSales.Text.ToString = "%%" Then
            showMessages("Harap Mengisi Sales", , "WARNING")
            Exit Sub
        End If
        lblStatusLoading.Visible = True
        cmdRefresh.Enabled = False
        If Not dsete.Tables("data") Is Nothing Then dsete.Tables.Remove("data")
        Dim cmd As SqlCommand

        If optTipe.EditValue = "R" Then
            cmd = New SqlClient.SqlCommand("select * from sales.dbo.getOmzetSalesRekap('" & txtTahun.Text & "','" & IIf(txtSales.EditValue Is Nothing, "%%", txtSales.EditValue) & "')", sqlconn)
            cmd.CommandTimeout = 0
            DA = New SqlClient.SqlDataAdapter(cmd)
            DA.Fill(dsete, "data")
            GC.MainView = GV2

        Else
            cmd = New SqlClient.SqlCommand("select * from sales.dbo.getOmzetSales('" & txtSales.EditValue & "','" & txtTahun.Text & "')", sqlconn)
            cmd.CommandTimeout = 0
            DA = New SqlClient.SqlDataAdapter(cmd)
            DA.Fill(dsete, "data")
            GC.MainView = GV
           
        End If
        GC.DataSource = dsete.Tables("data")
        GV2.BestFitColumns()
        GV.BestFitColumns()
        lanjut = True
        showGraph()
        ' showGraphBar()
        lblStatusLoading.Visible = False
        cmdRefresh.Enabled = True
    End Sub
    Public Sub add_click()
    End Sub
    Public Sub cetak_click()
        If CC.Visible Then
            Try
                Dim method As Reflection.MethodInfo = Me.GetType.GetMethod("cetak_grafik")
                method.Invoke(Me, Nothing)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            print_gc(GC, "Laporan Omzet Sales : " & txtSales.Text & vbCrLf & "Tahun : " & txtTahun.Text, True)
        End If
    End Sub
    Sub cetak_grafik()
        Dim ttl As New DevExpress.XtraCharts.ChartTitle
        ttl.Text = "Omzet Sales " & txtSales.Text & vbCrLf & "Tahun " & txtTahun.Text
        ttl.Alignment = StringAlignment.Center
        CC.Titles.Add(ttl)
        CC.ShowPrintPreview(DevExpress.XtraCharts.Printing.PrintSizeMode.Stretch)
    End Sub
    Public Sub showGraphbar()
        CharBar.Visible = False
        If Not dsete.Tables("dataG") Is Nothing Then dsete.Tables.Remove("dataG")
        With dsete.Tables.Add("dataG")
            .Columns.Add("thnbln")
            .Columns.Add("tipe")
            .Columns.Add("omzet", System.Type.GetType("System.Double"))
        End With
        CharBar.Series.Clear()
        CharBar.DataSource = dsete.Tables("dataG")
        For i As Int16 = 0 To 11
            For Each item As DataRow In dsete.Tables("data").Rows
                Dim rw As DataRow
                Dim j As Int16
                rw = dsete.Tables("dataG").NewRow
                With rw
                    .Item("thnbln") = txtTahun.Text & "-" & Microsoft.VisualBasic.Right("0" & (i + 1).ToString, 2)
                    .Item("tipe") = "Target " & item("Nama_Sales")
                    j = 4 + i * 3
                    .Item("omzet") = IIf(dsete.Tables("data")(0)(j).ToString = "", "0", dsete.Tables("data")(0)(j))
                End With
                dsete.Tables("dataG").Rows.Add(rw)
                rw = dsete.Tables("dataG").NewRow
                With rw
                    .Item("thnbln") = txtTahun.Text & "-" & Microsoft.VisualBasic.Right("0" & (i + 1).ToString, 2)
                    .Item("tipe") = "Realisasi " & item("Nama_Sales")
                    j = 5 + i * 3
                    .Item("omzet") = IIf(dsete.Tables("data")(0)(j).ToString = "", "0", dsete.Tables("data")(0)(j))
                End With

                dsete.Tables("dataG").Rows.Add(rw)
            Next
        Next
        CharBar.SeriesDataMember = dsete.Tables("dataG").Columns("thnbln").ToString 'series
        CharBar.SeriesTemplate.ArgumentDataMember = dsete.Tables("dataG").Columns("tipe").ToString ' X axis
        CharBar.SeriesTemplate.ValueDataMembers.AddRange(New String(dsete.Tables("dataG").Columns("omzet").ToString)) ' Y axis
        'CharBar.Series("Target").View.Color = Color.Blue
        'CharBar.Series("Realisasi").View.Color = Color.Red
        CharBar.Visible = True
        CharBar.Dock = DockStyle.Fill
    End Sub
    Public Sub showGraph()
        CC.Visible = False
        If Not lanjut Then Exit Sub
        If optTipe.EditValue = "R" And Not txtSales.EditValue Is Nothing Then
            If txtSales.EditValue.ToString = "" Then Exit Sub
            If rTampilan.EditValue <> "G" Then Exit Sub
            If txtTahun.Text = "" Then Exit Sub
            If dsete.Tables("data") Is Nothing Then Exit Sub
            If dsete.Tables("data").Rows.Count = 0 Then Exit Sub
            If Not dsete.Tables("dataG") Is Nothing Then dsete.Tables.Remove("dataG")
            With dsete.Tables.Add("dataG")
                .Columns.Add("thnbln")
                .Columns.Add("tipe")
                .Columns.Add("omzet", System.Type.GetType("System.Double"))
            End With
            CC.Series.Clear()
            CC.DataSource = dsete.Tables("dataG")
            For i As Int16 = 0 To 11
                Dim rw As DataRow
                Dim j As Int16
                rw = dsete.Tables("dataG").NewRow
                With rw
                    .Item("thnbln") = txtTahun.Text & "-" & Microsoft.VisualBasic.Right("0" & (i + 1).ToString, 2)
                    .Item("tipe") = "Target"
                    j = 4 + i * 3
                    .Item("omzet") = IIf(dsete.Tables("data")(0)(j).ToString = "", "0", dsete.Tables("data")(0)(j))
                End With
                dsete.Tables("dataG").Rows.Add(rw)
                rw = dsete.Tables("dataG").NewRow
                With rw
                    .Item("thnbln") = txtTahun.Text & "-" & Microsoft.VisualBasic.Right("0" & (i + 1).ToString, 2)
                    .Item("tipe") = "Realisasi"
                    j = 5 + i * 3
                    .Item("omzet") = IIf(dsete.Tables("data")(0)(j).ToString = "", "0", dsete.Tables("data")(0)(j))
                End With

                dsete.Tables("dataG").Rows.Add(rw)
            Next
            CC.SeriesDataMember = dsete.Tables("dataG").Columns("tipe").ToString 'series
            CC.SeriesTemplate.ArgumentDataMember = dsete.Tables("dataG").Columns("thnbln").ToString ' X axis
            CC.SeriesTemplate.ValueDataMembers.AddRange(New String(dsete.Tables("dataG").Columns("omzet").ToString)) ' Y axis
            CC.Series("Target").View.Color = Color.Blue
            CC.Series("Realisasi").View.Color = Color.Red
            CC.Dock = DockStyle.Fill
            CC.Visible = True
        End If

    End Sub

    Private Sub rTampilan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rTampilan.SelectedIndexChanged
        If rTampilan.EditValue = "G" Then
            optTipe.EditValue = "R"
            showGraph()
        Else
            CC.Visible = False
        End If

    End Sub

    Private Sub optTipe_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optTipe.SelectedIndexChanged
        lanjut = False
        If optTipe.EditValue = "C" Then
            rTampilan.EditValue = "T"
        End If
    End Sub
End Class