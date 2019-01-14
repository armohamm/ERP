Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Windows.Forms
Imports DevExpress.XtraPrintingLinks

Public Class frmCetakProduksi
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



    Private Sub frmCetakProduksi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        ReloadTable()


        GcMultiBME.DataSource = ds.Tables("_MonQC")

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        ComboBox1.SelectedIndex = 0



        'DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select distinct(blthn) from INV.dbo.INV_QC", sqlconn))
        'DALOOKUP2.Fill(ds_cari2, "_lookup1")
        'LookupBlthn.Properties.DataSource = ds_cari2.Tables("_lookup1")

        'Loadblthn()
    End Sub
    Sub ReloadTable()
        Dim sqltgl As String = ""



        If Not ds.Tables("_MonQC") Is Nothing Then ds.Tables("_MonQC").Clear()
        'da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select M.tanggal [tanggal], M.no_rph no_rph, S.Desc_Data desc_data,M.sts_centi sts_centi,M.cetak_ulang cetak_ulang from (select distinct no_rph from PROD.dbo.PROD_rcn_prod_d where vol=0 or vol is null and bom_service is null) D  " & _
        '                                                            "left join PROD.dbo.PROD_rcn_prod_m M on M.no_rph=D.no_rph  " & _
        '                                                            "left join SIF.dbo.SIF_Gen_Reff_D S on M.kd_jadwal=S.Id_Data  " & _
        '                                                            "where S.Id_Ref_Data='JDWKRJ' and M.no_rph_asal IS Null ORDER by m.no_rph DESC", sqlconn))

        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select m.tanggal [tanggal], d.Nama_Departemen, m.no_rph no_rph, s.desc_data desc_data, m.sts_centi sts_centi, m.cetak_ulang " & _
                                                                    "from prod.dbo.prod_rcn_prod_m m " & _
                                                                    "left join sif.dbo.sif_gen_reff_d s " & _
                                                                    "on m.kd_jadwal = s.id_data " & _
                                                                    "left join sif.dbo.SIF_Departemen d " & _
                                                                    "on m.kd_departemen = d.Kd_Departemen " & _
                                                                    "where s.id_ref_data='JDWKRJ' " & _
                                                                    "and m.no_rph_asal is null " & _
                                                                    "order by m.tanggal, m.no_rph", sqlconn))

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
        For Each rw As DataRow In ds.Tables("_MonQC").Select("cetak_ulang='Y'")
            Try
                Dim i As Int16 = New SqlCommand("update PROD.dbo.PROD_rcn_prod_m set cetak_ulang='T', cetak_ke = cetak_ke + 1 where no_rph='" & rw.Item("no_rph") & "'", sqlconn, BTRANZ).ExecuteNonQuery
                If i > 0 Then
                    MsgBox(rw.Item("no_trans").ToString)
                    Dim a As String = ""
                    a = rw.Item("no_trans")
                    MsgBox(a)
                    callReport(App_Path() & "\report\PROD_RcnKrm.rpt", "", "no_trans=" & a)
                    rw("sts_centi") = "Y"
                Else
                    rw("sts_centi") = "Y"
                End If
            Catch e As Exception
                rw("sts_centi") = "T"
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
            klik.Item("cetak_ulang") = "Y"
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
            klik.Item("cetak_ulang") = "T"
        Next
    End Sub
End Class