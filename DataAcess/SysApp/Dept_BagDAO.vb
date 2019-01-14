Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.Data
Public Class Dept_BagDAO
    Dim myBuilder As New SqlClient.SqlCommandBuilder
    Public errorMsg As String
    Public conn As New SqlClient.SqlConnection


    Public Function save(ByRef DSO As DataSet, ByRef DA As SqlClient.SqlDataAdapter, Optional ByVal state As String = "ADD") As Boolean
        Try
            If state = "ADD" Then DSO.Tables(0).Rows(0)("kode_departemen") = getNextNumberDept()
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
    Private Function getNextNumberDept() As String
        Dim hasil, temp As String
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(isnull(kode_depa,'C000001'),2,10) as numeric)) from SIF_Customer ", conn).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "DPT001"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 4
                temp = "0" & temp
            Next
            hasil = "DPT" & temp & (hasil + 1)
        End If
        sqlDR.Close()
        Return hasil
    End Function


End Class
