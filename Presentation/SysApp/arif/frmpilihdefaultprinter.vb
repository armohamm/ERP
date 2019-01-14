Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Management.Instrumentation
Public Class frmpilihdefaultprinter
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain   '<-- untuk mengakses frmMain
    Public obj As Object
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim prtdoc As New PrintDocument
    Dim strDefaultPrinter As String = prtdoc.PrinterSettings.PrinterName

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With

    End Sub
    Private Sub frmpilihdefaultprinter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()

        prn = getParent(Me)
        printerq()
        DefaultPrinterName()
        txtprint.EditValue = DefaultPrinterName()
    End Sub
    Public Shared Function DefaultPrinterName() As String
        Try
            If defaultPrinter = "" Then getDefaultPrinterName()
            DefaultPrinterName = defaultPrinter
        Catch ex As System.Exception
            DefaultPrinterName = ""
        End Try
    End Function
    Sub printerq()
       
        Dim strPrinter As String
        For Each strPrinter In PrinterSettings.InstalledPrinters
            cboprinter.Items.Add(strPrinter)
            If strPrinter = strDefaultPrinter Then
                cboprinter.SelectedIndex = cboprinter.Items.IndexOf(strPrinter)
            End If
        Next strPrinter

    End Sub

    Private Sub cmdSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSet.Click
        defaultPrinter = cboprinter.SelectedValue
        showMessages("Printer Telah Diset")
        Me.Dispose()
    End Sub
End Class