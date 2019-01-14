Imports System.Data

Public Class AreaDAO
    Dim myBuilder As New SqlClient.SqlCommandBuilder
    Public errorMsg As String
    Public Function save(ByRef DSO As DataSet, ByRef DA As SqlClient.SqlDataAdapter) As Boolean
        Try
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
End Class
