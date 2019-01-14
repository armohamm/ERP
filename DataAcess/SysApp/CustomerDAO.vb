Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.Data
'-------------------------------------------
'Table : SIF.SIF_CUSTOMER
'Fungsi : menyinpan data informasi customer
'-------------------------------------------

Public Class CustomerDAO
    'Public Sub save(ByVal cust As DataSet)
    '    ' field kd_cabang= liat table sif_parameter, jns_table='MSCUST', id_table='FILE', last_create_date=now/sysdate, 
    '    ' last_created_by = user, program_name= nama form

    'End Sub

    'Public Sub edit(ByVal cust As DataSet)
    '    'field last_update_date = now/sysdate

    'End Sub

    'Public Sub delete(ByVal cust As DataSet)

    'End Sub

    'Public Function cekkd_double(ByVal kode_cust As Object)
    '    'mengecek agar data kode customer tidak double'

    'End Function

    'Public Function getLOV() As DataView
    '    'LOV data customer dengan rec_status='Y'

    'End Function

    'Public Function getLOVArea() As DataView
    '    'LOV data customer dengan rec_status='Y'

    'End Function

    Dim myBuilder As New SqlClient.SqlCommandBuilder
    Public errorMsg As String
    Public conn As New SqlClient.SqlConnection

   
    Public Function save(ByRef DSO As DataSet, ByRef DA As SqlClient.SqlDataAdapter, Optional ByVal state As String = "ADD") As Boolean
        Try
            If state = "ADD" Then DSO.Tables(0).Rows(0)("kode_customer") = getNextNumber()
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
        Dim sqlDR As SqlDataReader = New SqlCommand("select MAX( cast(substring(isnull(kode_customer,'C000001'),2,10) as numeric)) from SIF_Customer ", conn).ExecuteReader
        sqlDR.Read()
        temp = ""
        If TypeOf sqlDR.Item(0) Is DBNull Then
            hasil = "C0000001"
        Else
            hasil = sqlDR.Item(0)
            For i As Int16 = Len(hasil) To 6
                temp = "0" & temp
            Next
            hasil = "C" & temp & (hasil + 1)
        End If
        sqlDR.Close()
        Return hasil
    End Function
End Class
