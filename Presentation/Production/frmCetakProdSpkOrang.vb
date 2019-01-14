Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Windows.Forms
Imports DevExpress.XtraPrintingLinks

Public Class frmCetakProdSpkOrang
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Dim ds, ds_cari2, ds_cari, ds_cari1, dsLookUp As New DataSet
    Dim da, DALOOKUP1, DALOOKUP, DALOOKUP2 As SqlDataAdapter
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Dim prn As frmMain
    Private STATE As String
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder
        btnSave = False
        btnEdit = False
        btnadd = False
        btnCancel = False
        setStatus()
    End Sub
    Private Sub formate_yayak()
        thisThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        'GvMonQC.Columns("qty_order").SummaryItem.DisplayFormat = DevExpress.Utils.FormatType.Numeric
        'GvMonQC.Columns("qty_order").SummaryItem.DisplayFormat
        Gv.Columns("qty_qc_pass").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Gv.Columns("qty_qc_pass").DisplayFormat.FormatString = "n2"
        Gv.Columns("qty_order").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Gv.Columns("qty_order").DisplayFormat.FormatString = "n2"
        Gv.Columns("hold").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Gv.Columns("hold").DisplayFormat.FormatString = "n2"
        Gv.Columns("qty_qc_unpass").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Gv.Columns("qty_qc_unpass").DisplayFormat.FormatString = "n2"
        'GvMonQC.Columns("qty_sisa").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'GvMonQC.Columns("qty_sisa").DisplayFormat.FormatString = "n2"
    End Sub



    Private Sub frmCetakProdSpkOrang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        ReloadTable()

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
       

        'DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select distinct(blthn) from INV.dbo.INV_QC", sqlconn))
        'DALOOKUP2.Fill(ds_cari2, "_lookup1")
        'LookupBlthn.Properties.DataSource = ds_cari2.Tables("_lookup1")

        'Loadblthn()
    End Sub
    Sub ReloadTable()
        Dim sqltgl As String = ""



        If Not ds.Tables("_MonQC") Is Nothing Then ds.Tables("_MonQC").Clear()
        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select m.rec_stat rec_stat,m.tanggal Tanggal, m.no_spk_man_rls No_SPK_Rls,m.no_spk_man No_SPK, " & _
            "g.Desc_Data KEGIATAN,g1.Desc_Data KEGIATAN_SPK,p.Nama_Pegawai PEGAWAI, " & _
            "g2.Desc_Data GROUP_KERJA,u.kd_mesin MESIN,s.no_rph NO_RPH, m.no_posting " & _
            "from PROD.dbo.PROD_rls_spk_man_m m " & _
            "left join SIF.dbo.SIF_Gen_Reff_D g " & _
            "on g.Id_Data=m.kd_kegiatan " & _
            "left join SIF.dbo.SIF_Gen_Reff_D g1 " & _
            "on g1.Id_Data=m.kd_kegiatan_spk " & _
            "left join SIF.dbo.SIF_Gen_Reff_D g2 " & _
            "on g2.Id_Data=m.group_kerja " & _
            "left join SIF.dbo.SIF_Pegawai p " & _
            "on p.Kode_Pegawai=m.kd_pegawai " & _
            "left join SIF.dbo.SIF_mesin_prod u " & _
            "on u.kd_mesin=m.kd_mesin " & _
            "left join PROD.dbo.PROD_spk_m s " & _
            "on s.no_spk=m.no_spk_man " & _
            "and s.kd_kegiatan=m.kd_kegiatan " & _
            "and s.kd_kegiatan_spk=m.kd_kegiatan_spk " & _
            "where g1.Id_Ref_File='SPK' and s.no_rph is not null " & _
            "and g.Id_Ref_File='KGTSPK' and g2.Id_Ref_File='GRPKERJA' " & _
            "order by m.tanggal  ", sqlconn))
        da.Fill(ds, "_MonQC")
        GcMultiBME.DataSource = ds.Tables("_MonQC")
    End Sub

    Private Sub isinomer()
        Dim i As Int16 = 1
        For Each row As DataRow In ds.Tables("_MonQC").Rows
            row.Item("nomer") = i : i += 1
        Next
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        ReloadTable()

    End Sub

    Public Sub cetak_click()
        Dim BTRANZ As SqlTransaction
        BTRANZ = sqlconn.BeginTransaction("1")
        For Each rw As DataRow In ds.Tables("_MonQC").Select("rec_stat='Y'")
            Try
                Dim i As Int16 = New SqlCommand("update PROD.dbo.PROD_rcn_krm_m set cetak_ulang='T', cetak_ke = cetak_ke + 1 where no_trans='" & rw.Item("no_trans") & "'", sqlconn, BTRANZ).ExecuteNonQuery
                If i > 0 Then
                    MsgBox(rw.Item("no_spk_man").ToString)
                    Dim a As String = ""
                    a = rw.Item("no_spk_man")
                    MsgBox(a)
                    callReport(App_Path() & "\report\PROD_RcnKrm.rpt", "", "no_trans=" & a)

                Else

                End If
            Catch e As Exception

                MsgBox("Gagal Cetak", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                Exit Sub
            End Try
        Next
        'Dim a As String
        'a = "201305/KRM/00008"
        'callReport(App_Path() & "\report\PROD_RcnKrm.rpt", "", "no_trans=" & a)
        MsgBox("Data Telah Diproses", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Cetak")
        ds.Tables("_MonQC").Clear()
        'dsete.Tables("SOD").Clear()
    End Sub


    Private Sub Btn_pilih_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_pilih.Click
        btn_deselect.Enabled = True
        Btn_pilih.Enabled = False
        For Each klik As DataRow In ds.Tables("_MonQC").Rows
            klik.Item("rec_stat") = "Y"
        Next
    End Sub
    Private Sub Btn_pilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btn_deselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_deselect_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_deselect.Click
        btn_deselect.Enabled = False
        Btn_pilih.Enabled = True
        For Each klik As DataRow In ds.Tables("_MonQC").Rows
            klik.Item("rec_stat") = "T"
        Next
    End Sub
End Class