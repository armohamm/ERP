Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.Data

'-------------------------------------------
'Table : SIF.SIF_AREA
'Fungsi : menyinpan data informasi AREA
'-------------------------------------------
Public Class Area
    Public Sub save(ByVal cust As DataSet)
        ' field kd_cabang= liat table sif_parameter, last_create_date=now/sysdate, 
        ' last_created_by = user, program_name= nama form

    End Sub

    Public Sub edit(ByVal cust As DataSet)
        'field last_update_date = now/sysdate

    End Sub

    Public Sub delete(ByVal cust As DataSet)

    End Sub

    Public Function cekkd_double(ByVal kode_cust As Object)
        'mengecek agar primary key tidak double'

    End Function

    Public Function getLOV() As DataView
        'LOV data customer dengan rec_status='Y'

    End Function

    Public Function getLOVWilayah() As DataView
        'LOV data customer dengan rec_status='Y'

    End Function
End Class
