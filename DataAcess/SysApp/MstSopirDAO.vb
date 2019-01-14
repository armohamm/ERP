'===================================================
'= dikerjakan oleh Yahya Drake Rozi                =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com =
'= Project: Dinasty group american pillow @2011    =
'===================================================

Imports System.Data
Public Class MstSopirDAO

    Dim myBuilder As New SqlClient.SqlCommandBuilder
    Public errorMsg As String
    Public conn As New SqlClient.SqlConnection

    Public Function save(ByRef DSO As DataSet, ByRef DA As SqlClient.SqlDataAdapter, Optional ByVal state As String = "ADD") As Boolean
        Try
            If state = "ADD" Then DSO.Tables("_SIF_SOPIR").Rows(0)("Kode_Sopir") = getNextNumber()
            myBuilder = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = myBuilder.GetUpdateCommand() '<- untuk mengenerate command insert, update, delete. hanya untuk table yang sederhana
            DA.Update(DSO.Tables("_SIF_SOPIR"))
            DSO.Tables("_SIF_SOPIR").AcceptChanges()
            Return True
        Catch e As Exception
            DSO.Tables("_SIF_SOPIR").RejectChanges()
            errorMsg = e.Message
            Return False
        End Try
    End Function

    Private Function getNextNumber() As String

        Dim hasil, temp As String
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX(isnull(Kode_Sopir,'001')) as kode_Sopir from SIF_Sopir", conn).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "001"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 2
                temp = "0" & temp
            Next
            hasil = temp & (hasil + 1)
        End If
        sqlDR.Close()
        Return hasil

    End Function


    'Public Function save(ByRef DSO As DataSet, ByRef DA As SqlClient.SqlDataAdapter) As Boolean
    '    Try
    '        myBuilder = New SqlClient.SqlCommandBuilder(DA)
    '        DA.UpdateCommand = myBuilder.GetUpdateCommand() '<- untuk mengenerate command insert, update, delete. hanya untuk table yang sederhana
    '        DA.Update(DSO.Tables(0))
    '        DSO.Tables(0).AcceptChanges()
    '        Return True
    '    Catch e As SqlException
    '        DSO.Tables(0).RejectChanges()
    '        errorMsg = e.Message
    '        Return False
    '    End Try
    'End Function

End Class

