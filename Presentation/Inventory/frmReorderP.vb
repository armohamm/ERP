'Imports DevExpress.XtraEditors.Repository
'Imports DevExpress.XtraEditors.Controls
'Imports System.Data
'Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports DevExpress.XtraPrintingLinks
Imports System.Math


Public Class frmReorderP
    Dim ds, ds1, ds_cari1 As New DataSet
    Dim da, da1, DALOOKUP1 As SqlDataAdapter
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Private STATE As String

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
        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        STATE = "ADD"
        'dtpTgl.EditValue = getTanggal()
        'bersihkan()
        'LookupGudang.EditValue = "G0000"
        '<-- set state add
    End Sub

    Public Sub cetak_click()
        GcReorder.Refresh()
        'PrintingSystem1.ResetProgressReflector()
        'PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub isinomer()
        Dim i As Int16 = 1
        For Each row As DataRow In ds.Tables("_rop").Rows
            row.Item("nomer") = i : i += 1
        Next
    End Sub

    Private Sub frmReorderP_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        ReloadTable()

        'dt_blthn.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        RG_Jenis.EditValue = 1
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_lookup2")
        RL_Barang.DataSource = ds_cari1.Tables("_lookup2")
        RL_Barang.ValueMember = "Kode_Barang"
        RL_Barang.DisplayMember = "Nama_Barang"

        

    End Sub
    'fungs pe
    Public Overloads Function DateAdd(ByVal Interval As DateInterval, ByVal Number As Double, ByVal DateValue As DateTime) As DateTime

    End Function
    Sub ReloadTable()

        If Not ds.Tables("_rop") Is Nothing Then ds.Tables("_rop").Clear()
        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_REORDERPOINT where 1=0", sqlconn))
        da.Fill(ds, "_rop")
        GcReorder.DataSource = ds.Tables("_rop")
        gvReorder.Columns("lead_time").SortOrder = DevExpress.Data.ColumnSortOrder.Descending
        'RG_Jenis.SelectedIndex = 2
    End Sub


    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        If STATE = "ADD" Then
            If Not ds.Tables("_rop") Is Nothing Then ds.Tables("_rop").Clear()

            Dim cap_min As Integer
            Dim sqljenis As String = ""
            Dim i As Int16 = 1

            If RG_Jenis.EditValue = vbNullString And RG_Jenis.EditValue = vbNullString And RG_Jenis.EditValue = vbNullString Then
                sqljenis = "1=0"
            ElseIf RG_Jenis.EditValue = 11 Then
                sqljenis = "brg.kd_jns_persd=1"
            ElseIf RG_Jenis.EditValue = 22 Then
                sqljenis = "brg.kd_jns_persd=2"
            ElseIf RG_Jenis.EditValue = 33 Then
                sqljenis = "brg.kd_jns_persd=3"
            ElseIf RG_Jenis.EditValue = 44 Then
                sqljenis = "brg.kd_jns_persd in(1,2,3)"
                'ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue = vbNullString Then
                '    sqltgl = " qc.tgl_trans  > '" & tglDari.EditValue & "'"
                'ElseIf tglDari.EditValue = vbNullString And tglsampai.EditValue <> vbNullString Then
                '    sqltgl = " qc.tgl_trans < '" & tglsampai.EditValue & "'"
                'ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString Then
                '    sqltgl = " qc.tgl_trans between '" & tglDari.EditValue & "' and '" & tglsampai.EditValue & "' "
                'ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString And LookupBlthn.EditValue <> vbNullString Then
                '    sqltgl = sqltgl & "and qc.blthn='" & LookupBlthn.Text & "'"
                'Else      '   LookupBlthn.EditValue <> vbNullString Then
                '    sqltgl = sqltgl & "qc.blthn='" & LookupBlthn.Text & "'"
            End If

            Dim sqldr As SqlDataReader = New SqlCommand("select brg.Kode_Barang,brg.spek_brg,brg.Kd_Satuan,isnull(sld.akhir_qty_onstok,0) as akhir_qty_onstok,sld.bultah,isnull(brg.stok_max_av,0) as stok_max_av,isnull(brg.stok_min,0) as stok_min,isnull(brg.rata_pakai,0) as rata_pakai,isnull(brg.lead_time,0) as lead_time,0 as nomer from SIF.dbo.SIF_Barang as brg LEFT JOIN INV.dbo.INV_STOK_SALDO as sld on brg.Kode_Barang=sld.kd_stok where sld.bultah=(select max(bultah) from INV.dbo.INV_STOK_SALDO) and " & sqljenis & "", sqlconn).ExecuteReader
            While sqldr.Read

                Dim rw As DataRow = ds.Tables("_rop").NewRow
                rw.Item("nomer") = i : i += 1
                rw.Item("kd_stok") = sqldr.Item("Kode_Barang")
                rw.Item("spek_brg") = sqldr.Item("spek_brg")
                rw.Item("satuan") = sqldr.Item("Kd_Satuan")
                rw.Item("stok_barang") = sqldr.Item("akhir_qty_onstok")
                rw.Item("stok_max") = sqldr.Item("stok_max_av")
                rw.Item("stok_min") = sqldr.Item("stok_min")
                rw.Item("rata_pakai") = sqldr.Item("rata_pakai")
                rw.Item("lead_time") = sqldr.Item("lead_time")
                If rw.Item("rata_pakai") <> 0 Then
                    cap_min = (rw.Item("stok_barang") - rw.Item("stok_min")) / rw.Item("rata_pakai")
                Else
                    cap_min = 0
                End If
                If cap_min < 0 Then
                    cap_min = 0
                ElseIf cap_min > 365 Then
                    cap_min = 365
                End If
                rw.Item("stok_capai_min") = Now.AddDays(cap_min)
                rw.Item("reorder_poin") = Now.AddDays(cap_min + rw.Item("lead_time"))
                ds.Tables("_rop").Rows.Add(rw)
            End While
            'isinomer()
        End If
    End Sub
End Class
