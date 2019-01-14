Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO

Public Class rptDPMM
    Dim ds As New DataSet
    'Public koneksi As New SqlConnection
    'Public koneksikefile As New StreamReader("Conn.inf")
    'Public isi As String

    'Sub Konek()
    '    isi = koneksikefile.ReadLine
    '    koneksi.ConnectionString = isi
    '    koneksi.Open()
    'End Sub


    'Public Sub koneksi()
    '    Dim sqlcon As New SqlConnection
    '    Dim inicls As New INICLASS
    '    Dim inifile As String = App_Path() & "\ConString.ini"
    '    If Not sqlcon.State = ConnectionState.Open Then
    '        sqlcon.ConnectionString = inicls.INIRead(inifile, "CSQL", "SIF")
    '        If Not sqlcon.State = ConnectionState.Open Then
    '            Try
    '                sqlcon.Open()
    '                MsgBox("Opened", MsgBoxStyle.Information)
    '            Catch ex As Exception
    '                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error Connection")
    '                End
    '            End Try
    '        End If
    '    End If
    'End Sub
    Private Function PushDataToDataSet() As DataSet
        Dim dsReport As New DataSet
        ' Using sqlConn As New SqlConnection(My.Settings.sas)
        'Using sqlConn As New SqlConnection(sqlConn.ConnectionString = "Data Source=192.168.1.2;Initial Catalog=SIF;Integrated Security=true;user=DINASTY;password=dinasty")
        'Using sqlConn As New SqlConnection(Presentation.umum.sqlconn.ConnectionString)
        Using sqlconn As New SqlConnection("Data Source=192.168.1.2;Initial Catalog=SIF;Integrated Security=false;user=DINASTY;password=dinasty")

            'Using sqlDa As New SqlDataAdapter("select distinct Kode_Barang,Nama_Barang,Kd_Satuan from sif.dbo.SIF_Barang", sqlconn)
            '    sqlDa.Fill(dsReport, "Barang")
            'End Using
            'Using sqlDa As New SqlDataAdapter("select * from PURC.dbo.AMREICAN_REPORT " & _
            '                                  "where No_DPM=' " & TextBox1.Text & "'", sqlconn)
            '    sqlDa.Fill(dsReport, "DPM")
            'End Using
            'Using sqlDa As New SqlDataAdapter("select Param_KetKode1 from  SIF.dbo.SIF_Parameter", sqlconn)
            '    sqlDa.Fill(dsReport, "Param")
            'End Using
            Using sqlDa As New SqlDataAdapter("select * from AMERICAN_REPORT.dbo.V_DPM where No_DPM=' " & TextBox1.Text & "'", sqlconn)
                sqlDa.Fill(dsReport, "Param")
            End Using
            'Using sqlDa As New SqlDataAdapter("select No_Seq,  Qty, Keterangan, Tgl_Diperlukan from PURC.dbo.PURC_DPM_D", sqlconn)
            '    sqlDa.Fill(dsReport, "DPMD")
            'End Using
            'Using sqlDa As New SqlDataAdapter("select Nama_Bagian from sif.dbo.SIF_Bagian", sqlconn)
            '    sqlDa.Fill(dsReport, "Departement")
            'End Using
        End Using
        Return dsReport
    End Function

    Private Sub rptDPMM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        'Dim sqlDa As New SqlDataAdapter("select * from AMERICAN_REPORT.dbo.V_DPM where No_DPM=' " & TextBox1.Text & "'", sqlconn)


        'Dim ds = New DataSet
        'sqlDa.Fill(ds, "Param")
        'objRepDOC = New rptDPM_M
        'objRepDOC.SetDataSource(ds)

        'DataGridView1.DataSource = ds
        'DataGridView1.DataMember = "Param"

        'CrystalReportViewer1.ReportSource = objRepDOC
    End Sub
    Private objRepDOC As ReportDocument

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        'objRepDOC = New rptDPM_M
        'objRepDOC.SetDataSource(PushDataToDataSet())
        ''objRepDOC.SetParameterValue("Param", TextBox1.Text)
        ''objRepDOC.SetParameterValue("PeriodeAkhir", dtAkhir.Value)
        'CrystalReportViewer1.ReportSource = objRepDOC

        'objRepDOC = New rptDPM_M
        'objRepDOC.SetDataSource(PushDataToDataSet())
        ''objRepDOC.SetParameterValue("PeriodeMulai", dtMulai.Value)
        ''objRepDOC.SetParameterValue("PeriodeAkhir", dtAkhir.Value)
        'CrystalReportViewer1.ReportSource = objRepDOC

    End Sub
End Class