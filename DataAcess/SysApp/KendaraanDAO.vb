Imports System.Data
Public Class KendaraanDAO
    Dim myBuilder As New SqlClient.SqlCommandBuilder
    Public errorMsg As String
    Public conn As New SqlClient.SqlConnection


    Public Function save(ByRef DSO As DataSet, ByRef DA As SqlClient.SqlDataAdapter, Optional ByVal state As String = "ADD") As Boolean
        Try
            If state = "ADD" Then DSO.Tables(0).Rows(0)("kode_kendaraan") = getNextNumberKendaraan()
            '  DSO.Tables(0).Rows(0)("Kode_Gudang") = getNextNumberGudang()
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

    Public Function getNextNumberKendaraan() As String
        Dim hasil, temp As String
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(isnull(kode_Kendaraan,'K01'),2,3) as numeric)) from SIF_Kendaraan ", conn).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "K01"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 1
                temp = "0" & temp
            Next
            hasil = "K" & temp & (hasil + 1)
        End If
        sqlDR.Close()
        Return hasil
    End Function
End Class
