Imports CrystalDecisions.Shared

Public Class frmViewReport
    Public dtble As DataTable
    Public tblName As String
    Public cetak_langsung As Boolean = False
    Public use_login As Boolean = False
    Public kertas As String
    Public ToolBar As Boolean
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
        Dim PkSize As New System.Drawing.Printing.PaperSize
        Dim ObjPrinterSetting As New System.Drawing.Printing.PrinterSettings
        Try

            'Load the report

            objReport.Load(sReportName)

            'Check if there are parameters or not in report.

            intCounter = objReport.DataDefinition.ParameterFields.Count

            'As parameter fields collection also picks the selection 

            ' formula which is not the parameter

            ' so if total parameter count is 1 then we check whether 

            ' its a parameter or selection formula.
            objReport.ReportOptions.EnableSaveDataWithReport = False
            objReport.DataDefinition.ParameterFields.Reset()
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
            ConInfo.ConnectionInfo.Type = ConnectionInfoType.SQL
            ConInfo.ConnectionInfo.AllowCustomConnection = True
            ConInfo.ConnectionInfo.UserID = uname
            ConInfo.ConnectionInfo.Password = passwd
            'ConInfo.ConnectionInfo.UserID = "sqluser"
            'ConInfo.ConnectionInfo.Password = "Mjtqs123"
            ConInfo.ConnectionInfo.ServerName = server_ip
            rptViewer.DisplayToolbar = ToolBar
            If use_login Then
                ConInfo.ConnectionInfo.DatabaseName = "KOPKAR"
            End If

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
                            Next
                        End If
                    End With
                Next
            Next

            Dim CrTables As CrystalDecisions.CrystalReports.Engine.Tables = objReport.Database.Tables
            For Each CrTable In CrTables
                CrTable.ApplyLogOnInfo(ConInfo)
            Next
            If tblName <> "" Then
                CrTables(tblName).SetDataSource(dtble)
            End If

            'If there is a selection formula passed to this function then use that

            If sSelectionFormula.Length > 0 Then
                objReport.RecordSelectionFormula = sSelectionFormula
            End If
            'Re setting control 

            rptViewer.ReportSource = Nothing

            'Set the current report object to report.

            rptViewer.ReportSource = objReport

            'Show the report

            If cetak_langsung Then
                If defaultPrinter = "" Then
                    getDefaultPrinterName()
                End If
                Try
                    objReport.PrintOptions.PrinterName = defaultPrinter
                    'objReport.PrintOptions.PaperSource = PaperSource.Auto
                    If kertas <> "" Then

                        For i As Integer = 0 To ObjPrinterSetting.PaperSizes.Count - 1
                            If ObjPrinterSetting.PaperSizes.Item(i).PaperName = "DIM" Then
                                PkSize = ObjPrinterSetting.PaperSizes.Item(i)
                                Exit For
                            End If
                        Next
                        If PkSize Is Nothing Then PkSize = New System.Drawing.Printing.PaperSize("DIM", 21, 14)
                        If PkSize IsNot Nothing Then
                            objReport.PrintOptions.PaperSize = CType(PkSize.RawKind, CrystalDecisions.Shared.PaperSize)
                        End If
                    End If
                    objReport.PrintToPrinter(1, False, 1, -1)
                Catch ex As Exception
                    MsgBox("Cetak Gagal : " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Error Cetak Dokumen")
                    'rptViewer.PrintReport()
                End Try
            Else

                rptViewer.Show()
            End If

            ViewReport = True
        Catch ex As System.Exception
            MsgBox("Gagal Cetak " & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Printing")
            ViewReport = False
        End Try

    End Function

    Private Sub rptViewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rptViewer.Load

    End Sub
End Class