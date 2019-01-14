'|-----------------------
'|  CREATED BY RENDY    |
'|  EDITED BY RENDY     |
'|-----------------------
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraCharts

Public Class frmMonGraphNSSS
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim err As String = ""
    Dim isvalid As Boolean

    Dim dtSaldo, DSTemp As New DataTable
    Dim dsRekap, dsDetUt, dsLunas, dsValuta, dsSupp, dsSaldo, dsSalF As New DataSet
    Dim daRekap, daDetUt, daLunas, daValuta, daSupp, daSaldo, daSalF As SqlDataAdapter

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnDelete = True
        btnCancel = True
        setStatus()
        'STATE = "ADD" '<-- set state add

    End Sub

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Private Sub frmMonGraphNSSS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        SaldoFull()
        valuta()
        AddItem()

        DSTemp.Columns.Add("DIVISI")
        DSTemp.Columns.Add("BULAN")
        DSTemp.Columns.Add("TOTAL", System.Type.GetType("System.Double"))

        'CekSaldo()
    End Sub

    Sub valuta()
        dsValuta.Clear()
        daValuta = New SqlDataAdapter(New SqlCommand("select Kode_Valuta, Nama_Valuta from SIF.dbo.SIF_Valuta", sqlconn))
        daValuta.Fill(dsValuta, "Valuta")
        LookUpValuta.Properties.DataSource = dsValuta.Tables("Valuta")
        LookUpValuta.Properties.DisplayMember = "Nama_Valuta"
        LookUpValuta.Properties.ValueMember = "Kode_Valuta"
    End Sub

    Sub CekSaldo(Optional ByVal X As String = "", Optional ByVal Y As String = "")

        daSaldo = New SqlDataAdapter(New SqlCommand("select X.kd_buku_besar , Y.nm_buku_besar   , " & _
    "  (select isNull(SUM(jml_val_debet - jml_val_kredit ) ,0) " & _
    "  from FIN.dbo.FIN_NERACA_SALDO A  " & _
    "          where(bln_buku = 1) " & _
    "  and a.kd_buku_besar=x.kd_buku_besar  " & _
    "  ) as 'januari', " & _
    "  (select isNull(SUM(jml_val_debet - jml_val_kredit ) ,0) " & _
    "  from FIN.dbo.FIN_NERACA_SALDO A  " & _
    "          where(bln_buku = 2) " & _
    "  and a.kd_buku_besar=x.kd_buku_besar " & _
    "  ) as 'februari' , " & _
    "  (select isNull(SUM(jml_val_debet - jml_val_kredit ) ,0)  " & _
    "  from FIN.dbo.FIN_NERACA_SALDO A  " & _
    "          where(bln_buku = 3) " & _
    "  and a.kd_buku_besar=x.kd_buku_besar " & _
    "  ) as 'maret' , " & _
    "  (select isNull(SUM(jml_val_debet - jml_val_kredit ) ,0) " & _
    "  from FIN.dbo.FIN_NERACA_SALDO A " & _
    "        where(bln_buku = 4) " & _
    "  and a.kd_buku_besar=x.kd_buku_besar " & _
    "  ) as 'april' , " & _
    "  (select isNull(SUM(jml_val_debet - jml_val_kredit ) ,0)  " & _
    "  from FIN.dbo.FIN_NERACA_SALDO A  " & _
    "          where(bln_buku = 5) " & _
    "  and a.kd_buku_besar=x.kd_buku_besar " & _
    "  ) as 'mei' , " & _
    "  (select isNull(SUM(jml_val_debet - jml_val_kredit ) ,0)   " & _
    "  from FIN.dbo.FIN_NERACA_SALDO A" & _
    "          where(bln_buku = 6)" & _
    "  and a.kd_buku_besar=x.kd_buku_besar" & _
    "  ) as 'juni' , " & _
    "  (select isNull(SUM(jml_val_debet - jml_val_kredit ) ,0)   " & _
    "  from FIN.dbo.FIN_NERACA_SALDO A " & _
    "          where(bln_buku = 7) " & _
    "  and a.kd_buku_besar=x.kd_buku_besar " & _
    "  ) as 'juli' , " & _
    "  (select isNull(SUM(jml_val_debet - jml_val_kredit ) ,0) " & _
    "  from FIN.dbo.FIN_NERACA_SALDO A " & _
    "          where(bln_buku = 8)" & _
    "  and a.kd_buku_besar=x.kd_buku_besar" & _
    "  ) as 'agustus' ," & _
    "  (select isNull(SUM(jml_val_debet - jml_val_kredit ) ,0) " & _
    "  from FIN.dbo.FIN_NERACA_SALDO A " & _
    "          where(bln_buku = 9)" & _
    "  and a.kd_buku_besar=x.kd_buku_besar" & _
    "  ) as 'september'," & _
    "  (select isNull(SUM(jml_val_debet - jml_val_kredit ) ,0) " & _
    "  from FIN.dbo.FIN_NERACA_SALDO A " & _
    "          where(bln_buku = 10)" & _
    "  and a.kd_buku_besar=x.kd_buku_besar" & _
    "  ) as 'oktober' , " & _
    "  (select isNull(SUM(jml_val_debet - jml_val_kredit ) ,0) " & _
    "  from FIN.dbo.FIN_NERACA_SALDO A " & _
    "          where(bln_buku = 11)" & _
    "  and a.kd_buku_besar=x.kd_buku_besar" & _
    "  ) as 'november' , " & _
    "  (select isNull(SUM(jml_val_debet - jml_val_kredit ) ,0) " & _
    "  from FIN.dbo.FIN_NERACA_SALDO A " & _
    "          where(bln_buku = 12)" & _
    "  and a.kd_buku_besar=x.kd_buku_besar" & _
    "  ) as 'desember' " & _
    "  from FIN.dbo.FIN_NERACA_SALDO  X , SIF.dbo.SIF_buku_besar  Y" & _
    "  where thn_buku= '" & X & "' " & _
    "  and X.kd_valuta = '" & Y & "'  " & _
    "  and X.kd_buku_besar = Y.kd_buku_besar " & _
    "  and LEFT(X.kd_buku_besar, 5) IN ('4-120', '4-110' ) " & _
    "  group by X.kd_buku_besar , Y.nm_buku_besar ", sqlconn))

        dtSaldo.Clear()

        'daSaldo.Fill(dsSaldo, "Saldo")
        daSaldo.Fill(dtSaldo) 'Data Table Saldo

        DSTemp.Clear() ' Data Table Temp

        For Each RW As DataRow In dtSaldo.Rows
            Dim RWR As DataRow

            For i As Integer = 1 To 12
                RWR = DSTemp.NewRow

                RWR(0) = RW(1) 'INDEX NAMA KOLOM KE 1
                RWR(1) = dtSaldo.Columns(i + 1).Caption ' INDEX NAMA KOLOM KE 2 SAMPAI 13
                RWR(2) = RW.Item(i + 1) ' VALUE

                DSTemp.Rows.Add(RWR)
            Next

        Next

        'USING DATA TABLES
        CC.Series.Clear()
        CC.DataSource = DSTemp
        CC.SeriesDataMember = DSTemp.Columns("DIVISI").ToString
        CC.SeriesTemplate.ArgumentDataMember = DSTemp.Columns("BULAN").ToString
        CC.SeriesTemplate.ValueDataMembers.AddRange(New String(DSTemp.Columns("TOTAL").ToString))

        'USING DATA SET
        'CC.Series.Clear()
        'CC.DataSource = dsete.Tables("0")
        'CC.SeriesDataMember = dsete.Tables("0").Columns("divisi").ToString
        'CC.SeriesTemplate.ArgumentDataMember = dsete.Tables("0").Columns("bulan").ToString
        'CC.SeriesTemplate.ValueDataMembers.AddRange(New String(dsete.Tables("0").Columns("nilai").ToString))
        dsSaldo.Clear()

        daSaldo.Fill(dsSaldo, "Saldo")
        GC.DataSource = dsSaldo.Tables("Saldo")
        BandedGV.BestFitColumns()

    End Sub

    Sub SaldoFull()
        daSalF = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select A.kartu, A.bln_buku, A.thn_buku, A.kd_buku_besar, b.nm_buku_besar, A.kd_buku_pusat, c.nm_buku_pusat, A.status, a.jml_val_debet, a.jml_val_kredit from FIN.dbo.FIN_NERACA_SALDO A , SIF.dbo.SIF_buku_besar B, SIF.dbo.SIF_buku_pusat C where(a.kd_buku_besar = b.kd_buku_besar) and a.kd_buku_pusat = C.kd_buku_pusat ", sqlconn))
        daSalF.Fill(dsSalF, "_saldo")
        LookUpSaldo.Properties.DataSource = dsSalF.Tables("_saldo")
        LookUpSaldo.Properties.ValueMember = "XXX"
        LookUpSaldo.Properties.DisplayMember = "XXX"

    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        CekSaldo("2011", "IDR")
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        CekSaldo(txtThn.Text, LookUpValuta.EditValue)
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        dsSaldo.Clear()
        dtSaldo.Clear()

        txtThn.Text = ""
        LookUpValuta.EditValue = vbNullString
    End Sub

    Private Sub CBGraphStyle_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBGraphStyle.SelectedIndexChanged
        If CBGraphStyle.SelectedItem = "Stacked Bar" Then
            Dim SS1 As Series = CC.Series(0)
            SS1.ChangeView(ViewType.StackedBar)
            Dim SS2 As Series = CC.Series(1)
            SS2.ChangeView(ViewType.StackedBar)
        End If

        If CBGraphStyle.SelectedItem = "Area" Then
            Dim SS1 As Series = CC.Series(0)
            SS1.ChangeView(ViewType.Area)
            Dim SS2 As Series = CC.Series(1)
            SS2.ChangeView(ViewType.Area)
        End If

        If CBGraphStyle.SelectedItem = "Line" Then
            Dim SS1 As Series = CC.Series(0)
            SS1.ChangeView(ViewType.Line)
            Dim SS2 As Series = CC.Series(1)
            SS2.ChangeView(ViewType.Line)
        End If


        If CBGraphStyle.SelectedItem = "Spline" Then
            Dim SS1 As Series = CC.Series(0)
            SS1.ChangeView(ViewType.Spline)
            Dim SS2 As Series = CC.Series(1)
            SS2.ChangeView(ViewType.Spline)
        End If

        If CBGraphStyle.SelectedItem = "Spline Area" Then
            Dim SS1 As Series = CC.Series(0)
            SS1.ChangeView(ViewType.SplineArea)
            Dim SS2 As Series = CC.Series(1)
            SS2.ChangeView(ViewType.SplineArea)
        End If

    End Sub

    Sub AddItem()
        CBGraphStyle.Items.Add("Stacked Bar")
        CBGraphStyle.Items.Add("Area")
        CBGraphStyle.Items.Add("Line")
        CBGraphStyle.Items.Add("Spline")
        CBGraphStyle.Items.Add("Spline Area")
    End Sub

    Sub ShowChartPreview(ByVal chart As ChartControl)
        ' Check whether the ChartControl can be previewed.
        If Not chart.IsPrintingAvailable Then
            MessageBox.Show("The 'DevExpress.XtraPrinting.v7.2.dll' is not found", "Error")
            Return
        End If
        ' Opens the Preview window.
        chart.ShowPrintPreview()
    End Sub
    Sub PrintChart(ByVal chart As ChartControl)
        ' Check whether the ChartControl can be printed.
        If Not chart.IsPrintingAvailable Then
            MessageBox.Show("The 'DevExpress.XtraPrinting.v7.2.dll' is not found", "Error")
            Return
        End If
        ' Print.
        chart.Print()
    End Sub

    Sub ShowGridPreview(ByVal grid As DevExpress.XtraGrid.GridControl)
        ' Check whether the XtraGrid control can be previewed. 
        If Not grid.IsPrintingAvailable Then
            MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error")
            Return
        End If
        ' Opens the Preview window. 
        grid.ShowPreview()
    End Sub


    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        'ShowChartPreview(CC)
        'PrintChart(CC)
        'ShowGridPreview(GC)

        If CEPPChart.Checked = True Then
            ShowChartPreview(CC)
        ElseIf CEPPGrid.Checked = True Then
            ShowGridPreview(GC)
        End If
    End Sub

    Public Sub cetak_click()
        If CEPPChart.Checked = True Then
            ShowChartPreview(CC)
        ElseIf CEPPGrid.Checked = True Then
            ShowGridPreview(GC)
        End If
    End Sub

    Private Sub CEPPChart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEPPChart.CheckedChanged
        If CEPPChart.Checked = True Then
            CEPPGrid.Checked = False
        Else
            CEPPGrid.Checked = True
        End If
    End Sub

    Private Sub CEPPGrid_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEPPGrid.CheckedChanged
        If CEPPGrid.Checked = True Then
            CEPPChart.Checked = False
        Else
            CEPPChart.Checked = True
        End If
    End Sub
End Class