Imports System.Data
Public Class WilayahDAO
    Dim myBuilder As New SqlClient.SqlCommandBuilder
    Public errorMsg As String
    Public post As String
    Public kode As String
    Public tabel As String
    Public conn As New SqlClient.SqlConnection
    Public Function save(ByRef DSO As DataSet, ByRef DA As SqlClient.SqlDataAdapter, Optional ByVal state As String = "ADD") As Boolean
        Try
            If state = "ADD" Then DSO.Tables(0).Rows(0)("kode_wilayah") = getNextNumber()
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
        Dim hasil, temp As String
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(isnull(" & kode & ",'x1'),2,10) as numeric)) from " & tabel, conn).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = post & "0000001"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 5
                temp = "0" & temp
            Next
            hasil = post & temp & (hasil + 1)
        End If
        sqlDR.Close()
        Return hasil
    End Function
End Class
