Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Public Class FrmLaporanProduksi
    Dim ds1, ds2, ds3, ds4, ds5, ds6, dsedit As New DataSet
    Dim da1, da2, da3, da4, da5, da6, daedit As New SqlDataAdapter
    Public prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False

    Private Sub FrmLaporanProduksi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True



        da1 = New SqlDataAdapter(New SqlCommand("select distinct no_rph from PROD.dbo.PROD_spk_m", sqlconn))
        da1.Fill(ds1, "rph")
        LE_RPH1.Properties.DataSource = ds1.Tables("rph")
        LE_RPH1.Properties.ValueMember = "no_rph"
        LE_RPH1.Properties.DisplayMember = "no_rph"

        da2 = New SqlDataAdapter(New SqlCommand("select distinct no_rph from PROD.dbo.PROD_spk_m", sqlconn))
        da2.Fill(ds1, "rph1")
        LE_RPH2.Properties.DataSource = ds1.Tables("rph1")
        LE_RPH2.Properties.ValueMember = "no_rph"
        LE_RPH2.Properties.DisplayMember = "no_rph"


        da3 = New SqlDataAdapter(New SqlCommand("select distinct kd_kegiatan_spk,desc_data from PROD.dbo.PROD_spk_m a,SIF.dbo.SIF_Gen_Reff_D b where b.id_Ref_File='SPK'and a.kd_kegiatan_spk=b.id_data ", sqlconn))
        da3.Fill(ds3, "kegiatan")
        LE_Kegiatan.Properties.DataSource = ds3.Tables("kegiatan")
        LE_Kegiatan.Properties.ValueMember = "kd_kegiatan_spk"
        LE_Kegiatan.Properties.DisplayMember = "desc_data"
    End Sub

    'Sub CetakLaporan(Optional ByVal no_rph As String = "", Optional ByVal kegiatan As String = "", Optional ByVal Boll As String = "")

    '    Try
    '        ErrorProvider1.Clear()
    '        If LE_RPH1.EditValue = vbNullString Then
    '            ErrorProvider1.SetError(LE_RPH1, "Periode Tidak Boleh Kosong")
    '        ElseIf LE_RPH1.EditValue <> vbNullString Then
    '            callReport(App_Path() & "\report\Laporan_Produksi.rpt", "", "&rph1=" & no_rph & "&kegiatan=" & kegiatan, Boll)
    '            'callReport(App_Path() & "\report\CRGL1.rpt", "","", False)
    '        Else
    '            callReport(App_Path() & "\report\Laporan_Produksi.rpt", "", "", True)
    '            'MsgBox("Kesalahan dalam mengisi filter laporan :" & vbCrLf & err, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "ERROR!")

    '        End If
    '    Catch ex As Exception
    '        lblError.Text = ex.Message
    '    End Try

    'End Sub

    Public Sub callReport(ByVal rptName As String, ByVal formulas As String, ByVal params As String, Optional ByVal cetak_langsung As Boolean = False)
        Dim objForm As New frmViewReport
        'Dim tbl As New DataTable
        'Dim dadbe As SqlDataAdapter
        'dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from american_report.DBO.VSO_REP", sqlconn))
        'dadbe.Fill(tbl)

        objForm.cetak_langsung = cetak_langsung
        'objForm.tblName = "VSO_REP"
        'objForm.dtble = tbl
        objForm.ViewReport(rptName, formulas, params)

        objForm.Show()
    End Sub

    Private Sub cmdExe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExe.Click
        If cmbJenis_Laporan.Text = "Rinci" Then
            callReport(App_Path() & "\report\Laporan_Produksi.rpt", "", "&rph1=" & LE_RPH1.EditValue & "&kegiatan=" & LE_Kegiatan.EditValue, False)
        ElseIf cmbJenis_Laporan.Text = "Rekap" Then
            callReport(App_Path() & "\report\Laporan_Produksi(Rekap).rpt", "", "&rph1=" & LE_RPH1.EditValue & "&kegiatan=" & LE_Kegiatan.EditValue, False)
        End If
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        LE_RPH1.EditValue = vbNullString
        LE_Kegiatan.EditValue = vbNullString
    End Sub
End Class