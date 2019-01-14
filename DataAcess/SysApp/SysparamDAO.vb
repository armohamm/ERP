Imports System.Collections.Generic
Imports System.Data.SqlClient
Imports System.Data

'-------------------------------------------
'Table : SIF.SIF_PARAMETER
'Fungsi : menyinpan data informasi parameter aplikasi
'-------------------------------------------
Public Class SysparamDAO
    Public Sub save(ByVal sysparam As DataSet)
        ' field kd_cabang= liat table sif_parameter, jns_table='MSUP', id_table='FILE', last_create_date=now/sysdate, 
        ' last_created_by = user, program_name= nama form

    End Sub

    Public Sub edit(ByVal sysparam As DataSet)
        'field last_update_date = now/sysdate

    End Sub

    Public Sub delete(ByVal sysparam As DataSet)

    End Sub

    Public Function cekkd_double(ByVal kode_supplier As Object)
        'mengecek agar data kode supplier tidak double'

    End Function

    Public Function getLOV() As DataView
        'LOV data supplier dengan rec_status='Y'

    End Function
End Class
