Imports CrystalDecisions.CrystalReports.Engine
Imports System.Windows.Forms
Imports System.Data.SqlClient
'adadadasd

Public Class aFormLK
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public prn As frmMain '<-- untuk mengakses frmMain
    Private dsLK, dsLookUp As New DataSet
    Private daLookUp, daLK As SqlClient.SqlDataAdapter
    Dim isOK As Boolean
    Dim err As String

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

    Private Sub rptStokSaldo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        Me.Enabled = True
        prn = getParent(Me)
        loadPeriode()
        loadUnit()
        lckPeriode.EditValue = Format(Today, "yyyyMM")
        lckUnit.EditValue = "00"
    End Sub

    Private Sub loadPeriode()
        If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku kode, nama_bulan + ' ' + thn_buku nama FROM KOPKAR.dbo.SIF_Periode_Buku", sqlconn))
        daLookUp.Fill(dsLookUp, "LookPeriode")
        lckPeriode.Properties.DataSource = dsLookUp.Tables("LookPeriode")
        lckPeriode.Properties.DisplayMember = "nama"
        lckPeriode.Properties.ValueMember = "kode"
    End Sub

    Private Sub loadUnit()
        If Not dsLookUp.Tables("Unit") Is Nothing Then dsLookUp.Tables("Unit").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT Id_Data kode, Desc_Data nama FROM KOPKAR.dbo.SIF_Gen_Reff_D WHERE Id_Ref_Data = 'UNITKOPKAR' UNION ALL SELECT '00' kode, '[Semua Unit]' nama", sqlconn))
        daLookUp.Fill(dsLookUp, "Unit")
        lckUnit.Properties.DataSource = dsLookUp.Tables("Unit")
        lckUnit.Properties.DisplayMember = "nama"
        lckUnit.Properties.ValueMember = "kode"
    End Sub

    Public Sub cetak_click()
        If chkNeraca.Checked Then
            If lckUnit.EditValue = "00" Then
                ViewReport(App_Path() & "\report\repNeracaAuditVerAll.rpt", "", "thn=" & Microsoft.VisualBasic.Left(lckPeriode.EditValue, 4) & " &bln=" & Microsoft.VisualBasic.Right(lckPeriode.EditValue, 2), False)
            Else
                ViewReport(App_Path() & "\report\repNeracaAuditVer.rpt", "", "thn=" & Microsoft.VisualBasic.Left(lckPeriode.EditValue, 4) & " &bln=" & Microsoft.VisualBasic.Right(lckPeriode.EditValue, 2) & " &ent=" & lckUnit.EditValue, False)
            End If
        End If

        If chkSHU.Checked Then
            If lckUnit.EditValue = "00" Then
                ViewReport(App_Path() & "\report\repLabaRugiAuditVerAll.rpt", "", "thn=" & Microsoft.VisualBasic.Left(lckPeriode.EditValue, 4) & " &bln=" & Microsoft.VisualBasic.Right(lckPeriode.EditValue, 2), False)
            Else
                ViewReport(App_Path() & "\report\repLabaRugiAuditVer.rpt", "", "thn=" & Microsoft.VisualBasic.Left(lckPeriode.EditValue, 4) & " &bln=" & Microsoft.VisualBasic.Right(lckPeriode.EditValue, 2) & " &ent=" & lckUnit.EditValue, False)
            End If
        End If

        If chkEkuitas.Checked Then
            ViewReport(App_Path() & "\report\repEkuitasAuditVer.rpt", "", "thn=" & Microsoft.VisualBasic.Left(lckPeriode.EditValue, 4) & " &bln=" & Microsoft.VisualBasic.Right(lckPeriode.EditValue, 2), False)
        End If

        If chkKas.Checked Then
            ViewReport(App_Path() & "\report\repArusKasAuditVer.rpt", "", "thn=" & Microsoft.VisualBasic.Left(lckPeriode.EditValue, 4) & " &bln=" & Microsoft.VisualBasic.Right(lckPeriode.EditValue, 2), False)
        End If

    End Sub

    Public Function App_Path() As String
        Return Application.StartupPath()
    End Function

    Public Function ViewReport(ByVal sReportName As String, Optional ByVal SelectionFormula As String = "", Optional ByVal param As String = "", Optional ByVal stat As Boolean = True) As Boolean

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
            ConInfo.ConnectionInfo.UserID = "msbca"
            ConInfo.ConnectionInfo.Password = "Sikap123"
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

            If SelectionFormula.Length > 0 Then
                objReport.RecordSelectionFormula = SelectionFormula
            End If
            'Re setting control 

            cr_view.ReportSource = Nothing

            'Set the current report object to report.

            cr_view.ReportSource = objReport

            'Show the report
            If stat Then
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
        cek()

        If isOK Then
            cetak_click()
        Else
            MsgBox("Ada kesalahan dalam pengisian data.", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "ERROR!")
        End If
    End Sub

    Private Sub cek()
        If lckPeriode.EditValue = vbNullString Then
            isOK = False
            lckPeriode.ErrorText = "Pilih periode laporan terlebih dahulu"
        Else
            isOK = True
            lckPeriode.ErrorText = ""
        End If

        If lckUnit.EditValue = vbNullString Then
            isOK = False
            lckUnit.ErrorText = "Pilih unit laporan terlebih dahulu"
        Else
            isOK = True
            lckUnit.ErrorText = ""
        End If

        If Not lckUnit.EditValue = "00" Then
            If Not (chkNeraca.Checked = True Or chkSHU.EditValue = True) Then
                isOK = False
                If chkEkuitas.Checked Then
                    chkEkuitas.ErrorText = "Pilih [Semua Unit] untuk Laporan Perubahan Ekuitas"
                Else
                    chkKas.ErrorText = "Pilih [Semua Unit] untuk Laporan Arus Kas"
                End If
            Else
                isOK = True
                chkEkuitas.ErrorText = ""
                chkKas.ErrorText = ""
            End If
        Else
            isOK = True
            chkEkuitas.ErrorText = ""
            chkKas.ErrorText = ""
        End If
    End Sub

    Private Sub chkNeraca_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkNeraca.CheckedChanged
        If chkNeraca.Checked Then
            chkEkuitas.Checked = False
            chkSHU.Checked = False
            chkKas.Checked = False
        End If
    End Sub

    Private Sub chkSHU_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkSHU.CheckedChanged
        If chkSHU.Checked Then
            chkEkuitas.Checked = False
            chkNeraca.Checked = False
            chkKas.Checked = False
        End If
    End Sub

    Private Sub chkKas_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkKas.CheckedChanged
        If chkKas.Checked Then
            chkEkuitas.Checked = False
            chkNeraca.Checked = False
            chkSHU.Checked = False
        End If
    End Sub

    Private Sub chkEkuitas_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkEkuitas.CheckedChanged
        If chkEkuitas.Checked Then
            chkKas.Checked = False
            chkNeraca.Checked = False
            chkSHU.Checked = False
        End If
    End Sub
End Class