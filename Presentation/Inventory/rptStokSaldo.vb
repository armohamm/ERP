﻿'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================
Imports CrystalDecisions.CrystalReports.Engine
Imports System.Windows.Forms
Imports System.Data.SqlClient


Public Class rptStokSaldo
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Private ds_cari, ds_cari1, dsLookUp, ds_vbrg, ds_keypress As New DataSet
    Private DALOOKUP, DALOOKUP1, da_vbrg, DA_keypres As SqlClient.SqlDataAdapter

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        'Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
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

    Private Sub rptStokSaldo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        'DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT kd_stok,Nama_Barang FROM AMERICAN_REPORT.dbo.vym_saldocard", sqlconn))
        'DALOOKUP.Fill(ds_cari, "_lookup2")
        'LookupBrg.Properties.DataSource = ds_cari.Tables("_lookup2")
        'LookupBrg.Properties.ValueMember = "kd_stok"
        'LookupBrg.Properties.DisplayMember = "Nama_Barang"

        'DALOOKUP1 = New SqlDataAdapter(New SqlCommand("SELECT distinct(blthn) FROM AMERICAN_REPORT.dbo.vy_saldocard", sqlconn))
        'DALOOKUP1.Fill(ds_cari1, "_lookup")
        'LookupBlthn.Properties.DataSource = ds_cari1.Tables("_lookup")

        da_vbrg = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select b.Kode_Barang,b.Nama_Barang from SIF.dbo.SIF_Barang b inner join INV.dbo.inv_barang_depo d on  b.Kode_Barang=d.kd_stok", sqlconn))
        da_vbrg.Fill(ds_vbrg, "_vbrg")
        'LookupBlthn.Properties.ValueMember = "kd_stok"
        'LookupBlthn.Properties.DisplayMember = "Nama_Barang"
        txtcari.AutoCompleteCustomSource.AddRange((From row As Object In ds_vbrg.Tables("_vbrg").Rows.Cast(Of DataRow)() Select CStr(row("Nama_Barang"))).ToArray())
        Loadblthn()
    End Sub

    Private Sub Loadblthn()
        If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        DALOOKUP.Fill(dsLookUp, "LookPeriode")
        lookupBulanAwal.Properties.DataSource = dsLookUp.Tables("LookPeriode")
        lookupBulanAwal.Properties.DisplayMember = "nama"
        lookupBulanAwal.Properties.ValueMember = "thnbln"

    End Sub

    Public Sub cetak_click()
        'If txbKdBrg.Text <> "" And tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString And lookupBulanAwal.EditValue <> vbNullString Then
        ViewReport(App_Path() & "\report\kartustokSaldo.rpt", "", "kodebarang=" & txbKdBrg.Text & "&thnbl=" & lookupBulanAwal.EditValue & "&tgldari=" & tglDari.EditValue & "&tglsampai=" & tglsampai.EditValue)
        'Else
        'MsgBox("Silahkan Lengkapi data: Nama Barang, Tgl awal, Tanggal sampai dengan, Bulan Tahun Periode")
        'End If
        'callReport(App_Path() & "\report\kartustokSaldo.rpt", "", "kodebarang=" & txbKdBrg.Text & "&thnbl=" & lookupBulanAwal.EditValue & "&tgldari=" & tglDari.EditValue & "&tglsampai=" & tglsampai.EditValue, True, True)

    End Sub
    Public Function App_Path() As String
        Return Application.StartupPath()
    End Function
    Public cetak_langsung As Boolean = False
    Public Function ViewReport(ByVal sReportName As String, Optional ByVal sSelectionFormula As String = "", Optional ByVal param As String = "") As Boolean

        'Declaring variablesables

        Dim intCounter As Integer
        Dim intCounter1 As Integer

        'Crystal Report's report document object

        Dim objReport As New  _
            CrystalDecisions.CrystalReports.Engine.ReportDocument

        'object of table Log on info of Crystal report

        Dim ConInfo As New CrystalDecisions.Shared.TableLogOnInfo

        'Parameter value object of crystal report 

        ' parameters used for adding the value to parameter.

        Dim paraValue As New CrystalDecisions.Shared.ParameterDiscreteValue

        'Current parameter value object(collection) of crystal report parameters.

        Dim currValue As CrystalDecisions.Shared.ParameterValues

        'Sub report object of crystal report.

        Dim mySubReportObject As  _
            CrystalDecisions.CrystalReports.Engine.SubreportObject

        'Sub report document of crystal report.

        Dim mySubRepDoc As New  _
            CrystalDecisions.CrystalReports.Engine.ReportDocument

        Dim strParValPair() As String
        Dim strVal() As String
        Dim index As Integer

        Try

            'Load the report

            objReport.Load(sReportName)

            'Check if there are parameters or not in report.

            intCounter = objReport.DataDefinition.ParameterFields.Count

            'As parameter fields collection also picks the selection 

            ' formula which is not the parameter

            ' so if total parameter count is 1 then we check whether 

            ' its a parameter or selection formula.


            If intCounter = 1 Then
                If InStr(objReport.DataDefinition.ParameterFields(0).ParameterFieldName, ".", CompareMethod.Text) > 0 Then
                    intCounter = 0
                End If
            End If

            'If there are parameters in report and 

            'user has passed them then split the 

            'parameter string and Apply the values 

            'to their concurrent parameters.


            If intCounter > 0 And Trim(param) <> "" Then
                strParValPair = param.Split("&")

                For index = 0 To UBound(strParValPair)
                    If InStr(strParValPair(index), "=") > 0 Then
                        strVal = strParValPair(index).Split("=")
                        paraValue.Value = strVal(1)
                        currValue = objReport.DataDefinition.ParameterFields(strVal(0)).CurrentValues
                        currValue.Add(paraValue)
                        objReport.DataDefinition.ParameterFields(strVal(0)).ApplyCurrentValues(currValue)
                    End If
                Next
            End If

            'Set the connection information to ConInfo 

            'object so that we can apply the 

            'connection information on each table in the report
            'ConInfo.ConnectionInfo.UserID = "dinasty"
            'ConInfo.ConnectionInfo.Password = "dinasty"
            ConInfo.ConnectionInfo.UserID = uname
            ConInfo.ConnectionInfo.Password = passwd
            ConInfo.ConnectionInfo.ServerName = server_ip
            ConInfo.ConnectionInfo.DatabaseName = "KOPKAR"

            For intCounter = 0 To objReport.Database.Tables.Count - 1
                objReport.Database.Tables(intCounter).ApplyLogOnInfo(ConInfo)
            Next

            ' Loop through each section on the report then look 

            ' through each object in the section

            ' if the object is a subreport, then apply logon info 

            ' on each table of that sub report


            For index = 0 To objReport.ReportDefinition.Sections.Count - 1
                For intCounter = 0 To objReport.ReportDefinition.Sections(index).ReportObjects.Count - 1
                    With objReport.ReportDefinition.Sections(index)
                        If .ReportObjects(intCounter).Kind = _
                        CrystalDecisions.Shared.ReportObjectKind.SubreportObject Then
                            mySubReportObject = CType(.ReportObjects(intCounter), CrystalDecisions.CrystalReports.Engine.SubreportObject)
                            mySubRepDoc = mySubReportObject.OpenSubreport(mySubReportObject.SubreportName)
                            For intCounter1 = 0 To mySubRepDoc.Database.Tables.Count - 1
                                mySubRepDoc.Database.Tables(intCounter1).ApplyLogOnInfo(ConInfo)
                                mySubRepDoc.Database.Tables(intCounter1).ApplyLogOnInfo(ConInfo)
                            Next
                        End If
                    End With
                Next
            Next
            'If there is a selection formula passed to this function then use that

            If sSelectionFormula.Length > 0 Then
                objReport.RecordSelectionFormula = sSelectionFormula
            End If
            'Re setting control 

            cr_view.ReportSource = Nothing

            'Set the current report object to report.

            cr_view.ReportSource = objReport

            'Show the report
            If cetak_langsung Then
                cr_view.PrintReport()
            Else
                cr_view.Show()
            End If

            Return True
        Catch ex As System.Exception
            MsgBox(ex.Message)
        End Try

    End Function

    Private Sub btnprin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprin.Click
        cr_view.PrintReport()
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click

        If txbKdBrg.Text <> "" And tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString And lookupBulanAwal.EditValue <> vbNullString Then
            cetak_click()
        Else
            MsgBox("Silahkan Lengkapi data: Nama Barang, Tgl awal, Tanggal sampai dengan, Bulan Tahun Periode")
        End If

    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        'tgl_akhir.EditValue = vbNullString
        'tgl_awal.EditValue = vbNullString
        lookupBulanAwal.EditValue = vbNullString
        txbKdBrg.Text = ""
    End Sub

    Private Sub txtcari_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcari.KeyDown
        If Not ds_keypress.Tables("_keypres") Is Nothing Then ds_keypress.Tables("_keypres").Clear()
        Dim ok As Boolean = False
        If e.KeyCode = Keys.Enter Then
            DA_keypres = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang where Nama_Barang ='" & txtcari.Text & "'", sqlconn))
            DA_keypres.Fill(ds_keypress, "_keypres")

            If ds_keypress.Tables("_keypres").Rows.Count <> 0 Then
                Dim rwx As DataRow = ds_keypress.Tables("_keypres").Rows(0)
                txbKdBrg.Text = rwx.Item(0) ' Kode Barang
                'MsgBox(rwx.Item(0))
                'cetak_click()
            End If
            txtcari.SelectAll()
        End If

    End Sub

    'Private Sub txtcari_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcari.KeyDown
    '    If MsgBox("Perlu Preview sebelum cetak tekan YES, jika CETAK LANGSUNG tekan NO", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '        cetak_click()
    '    Else
    '        cetak_langsung()
    '    End If
    'End Sub


End Class