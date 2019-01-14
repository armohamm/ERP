'===================================================
'= dikerjakan oleh Yahya Drake Rozi                =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com =
'= Project: Dinasty group american pillow @2011    =
'===================================================
'-------------------------------------------
Imports System.Data

Public Class SupplierDAO
    Dim myBuilder As New SqlClient.SqlCommandBuilder
    Public errorMsg As String
    Public conn As New SqlClient.SqlConnection

    Public Function save(ByRef DSO As DataSet, ByRef DA As SqlClient.SqlDataAdapter, Optional ByVal state As String = "ADD") As Boolean
        Try
            If state = "ADD" Then DSO.Tables(0).Rows(0)("kode_supplier") = getNextNumber()
            myBuilder = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = myBuilder.GetUpdateCommand() '<- untuk mengenerate command insert, update, delete. hanya untuk table yang sederhana
            DA.Update(DSO.Tables(0))
            DSO.Tables(0).AcceptChanges()
            Return True
        Catch e As Exception
            DSO.Tables(0).RejectChanges()
            errorMsg = e.Message
            Return False
        End Try
    End Function
    Private Function getNextNumber() As String
        'If state = "EDIT" Then

        Dim hasil, temp As String
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(isnull(kode_supplier,'S000001'),2,6) as numeric)) from SIF_Supplier ", conn).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "S000001"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 5
                temp = "0" & temp
            Next
            hasil = "S" & temp & (hasil + 1)
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
