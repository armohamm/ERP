Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraPrintingLinks

Public Class frmMonStokSaldo
    Dim ds, ds_cari2, ds_cari, ds_cari1, ds_cari3, ds_cari4, dsLookUp, ds_vbrg As New DataSet
    Dim da, DALOOKUP1, da_brg, DALOOKUP, DALOOKUP2, DALOOKUP3, DALOOKUP4 As SqlDataAdapter
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Private itung As Integer


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
        btnCancel = True
        setStatus()
    End Sub
    Public Sub cancel_click()
        ReloadTable()
        ds.Clear()
        lookupBulanAwal.EditValue = vbNullString
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
        'bersihkan()
    End Sub

    Sub ReloadTable()
        Dim sqltgl As String = ""
        If lookupBulanAwal.EditValue = vbNullString Then
            sqltgl = "1=0"
            'ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue = vbNullString Then
            '    sqltgl = " tgl_trans > '" & tglDari.EditValue & "'"
            'ElseIf tglDari.EditValue = vbNullString And tglsampai.EditValue <> vbNullString Then
            '    sqltgl = " tgl_trans < '" & tglsampai.EditValue & "'"
            'ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString Then
            '    sqltgl = " tgl_trans between '" & tglDari.EditValue & "' and '" & tglsampai.EditValue & "' "
            'ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString And LookupBlthn.EditValue <> vbNullString Then
            '    sqltgl = sqltgl & "and blthn='" & LookupBlthn.Text & "'"
        Else
            'jika tgl dari kosong,tgl akhir kosong maka
            sqltgl = sqltgl & " sld.bultah='" & lookupBulanAwal.EditValue & "'"
        End If

        If Not ds.Tables("_MonSaldo") Is Nothing Then ds.Tables("_MonSaldo").Clear()
        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT SLD.kd_stok,sld.kd_satuan,sld.panjang,sld.lebar,sld.tinggi,brg.lokasi,brg.Kd_Depart,brg.kd_jenis,brg.kd_jns_persd,sld.akhir_booked,sld.akhir_qty_kony,sld.qty_available,sld.awal_qty_onstok,sld.qty_onstok_in, sld.qty_onstok_out,sld.akhir_qty_onstok,brg.Nama_Barang,'' as nm_brg,0 as nomer from INV.dbo.INV_STOK_SALDO sld left join SIF.dbo.SIF_Barang brg on sld.kd_stok=brg.Kode_Barang where " & sqltgl & "", sqlconn))
        da.Fill(ds, "_MonSaldo")

        da_brg = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang,Nama_Barang,Kd_Satuan,spek_brg from SIF.dbo.SIF_Barang where kd_jns_persd<>'4'", sqlconn))
        da_brg.Fill(ds_vbrg, "_vbrg")

    End Sub

    Private Sub frmMonStokSaldo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        ReloadTable()
        GcMonBK.DataSource = ds.Tables("_MonSaldo")

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup")
        LookupBarang.DataSource = ds_cari.Tables("_lookup")
        LookupBarang.ValueMember = "Kode_Barang"
        LookupBarang.DisplayMember = "Nama_Barang"

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select Kode_Gudang,Nama_Gudang from SIF.dbo.SIF_Gudang", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_gudang")
        rpGudang.DataSource = ds_cari1.Tables("_gudang")
        rpGudang.ValueMember = "Kode_Gudang"
        rpGudang.DisplayMember = "Nama_Gudang"

        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select Kd_Jns_Persd,Nama_Persediaan from SIF.dbo.SIF_Jns_Persediaan", sqlconn))
        DALOOKUP2.Fill(ds_cari2, "_lookup2")
        RepLookupPersd.DataSource = ds_cari2.Tables("_lookup2")
        RepLookupPersd.ValueMember = "Kd_Jns_Persd"
        RepLookupPersd.DisplayMember = "Nama_Persediaan"

        DALOOKUP4 = New SqlDataAdapter(New SqlCommand("select Kd_Departemen,Nama_Departemen from SIF.dbo.SIF_Departemen", sqlconn))
        DALOOKUP4.Fill(ds_cari4, "_dept")
        rpDept.DataSource = ds_cari4.Tables("_dept")
        rpDept.ValueMember = "Kd_Departemen"
        rpDept.DisplayMember = "Nama_Departemen"


        DALOOKUP3 = New SqlDataAdapter(New SqlCommand("select Kd_Jns_Brg,Nama_Jenis from SIF.dbo.SIF_Jenis_Barang", sqlconn))
        DALOOKUP3.Fill(ds_cari3, "_lookup3")
        RepLookupJenis.DataSource = ds_cari3.Tables("_lookup3")
        RepLookupJenis.ValueMember = "Kd_Jns_Brg"
        RepLookupJenis.DisplayMember = "Nama_Jenis"

        
        'DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select distinct(bultah) from INV.dbo.INV_STOK_SALDO", sqlconn))
        'DALOOKUP1.Fill(ds_cari1, "_lookup1")
        'LookupBlthn.Properties.DataSource = ds_cari1.Tables("_lookup1")

        'If ds_cari1.Tables("_lookup1").Rows.Count > 0 Then
        '    LookupBlthn.EditValue = ds_cari1.Tables("_lookup1").Rows(0).Item(0)
        'End If


        Loadblthn()
        txtcari.AutoCompleteCustomSource.AddRange((From row As Object In ds_vbrg.Tables("_vbrg").Rows.Cast(Of DataRow)() Select CStr(row("Nama_Barang"))).ToArray())
    End Sub

    Private Sub Loadblthn()
        If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        DALOOKUP.Fill(dsLookUp, "LookPeriode")
        lookupBulanAwal.Properties.DataSource = dsLookUp.Tables("LookPeriode")
        lookupBulanAwal.Properties.DisplayMember = "nama"
        lookupBulanAwal.Properties.ValueMember = "thnbln"

    End Sub

    Private Sub isitabel17()
        Dim i As Int16 = 1
        Dim sqldr As SqlDataReader = New SqlCommand("SELECT sld.kd_stok,brg.Nama_Barang,sld.akhir_booked,sld.akhir_qty_prod,sld.akhir_qty_kony,sld.qty_available,sld.awal_qty_onstok,sld.qty_onstok_in,sld.qty_onstok_out,sld.akhir_qty_onstok from INV.dbo.INV_STOK_SALDO as sld inner join SIF.dbo.SIF_Barang brg on sld.kd_stok=brg.Kode_Barang where sld.bultah='" & lookupBulanAwal.EditValue & "'", sqlconn).ExecuteReader
        While sqldr.Read
            Dim row As DataRow = ds.Tables("_MonSaldo").NewRow
            row.Item("nomer") = i : i += 1
            'row.Item("kd_stok") = sqldr.Item("kd_stok")
            row.Item("nm_brg") = sqldr.Item("Nama_Barang")
            row.Item("akhir_booked") = sqldr.Item("akhir_booked")
            'row.Item("diliver") = sqldr.Item("diliver")
            row.Item("akhir_qty_prod") = sqldr.Item("akhir_qty_prod")
            row.Item("akhir_qty_kony") = sqldr.Item("akhir_qty_kony")
            row.Item("qty_available") = sqldr.Item("qty_available")
            row.Item("awal_qty_onstok") = sqldr.Item("awal_qty_onstok")
            row.Item("qty_onstok_in") = sqldr.Item("qty_onstok_in")
            row.Item("qty_onstok_out") = sqldr.Item("qty_onstok_out")
            row.Item("akhir_qty_onstok") = sqldr.Item("akhir_qty_onstok")

            ds.Tables("_MonSaldo").Rows.Add(row)
            itung = row.Item("nomer")
        End While
        sqldr.Close()
        'ProgressBar1.Value = 0
        'ProgressBar1.Minimum = 0
        'ProgressBar1.Maximum = itung
        'ProgressBar1.Step = 100
        '' ProgressBar1.Step = 10
        ''For x = 0 To itung

    End Sub

    Private Sub isinomer()
        Dim i As Int16 = 1
        For Each row As DataRow In ds.Tables("_MonSaldo").Rows
            row.Item("nomer") = i : i += 1
        Next
    End Sub


    Public Sub cetak_click()

        GcMonBK.Refresh()
        PrintingSystem1.ResetProgressReflector()
        PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        pnlLoad.Visible = True
        pnlLoad.Refresh()
        ds.Clear()
        ReloadTable()
        isinomer()
        pnlLoad.Visible = False
    End Sub

    Private Sub btnprin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprin.Click
        cetak_click()
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        lookupBulanAwal.EditValue = vbNullString
    End Sub

 
    Private Sub txtcari_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtcari.KeyDown
        Dim ok As Boolean = False
        If e.KeyCode = Keys.Enter Then
            Dim dtrow() As DataRow = ds.Tables("_MonSaldo").Select("Nama_Barang='" & txtcari.Text & "'")
            If dtrow.Count = 0 Then
                txtcari.Text = ""
                'lblNmBrg.Text = ""
                'lblStatus.Text = ""
                'lblNmBrg.ForeColor = Color.DarkRed
                'lblStatus.ForeColor = Color.DarkRed
                'lblNmBrg.Text = "Item tidak ada dalam Daftar"
                'lblStatus.Text = "KOSONG"
                tunda()

                txtcari.Focus()
            Else
                txtcari.Text = ""
                'lblNmBrg.Text = ""
                'lblStatus.Text = ""
                'lblNmBrg.ForeColor = Color.Yellow
                'lblStatus.ForeColor = Color.Yellow
                'For i As Int16 = 0 To dtrow.Count - 1
                'Application.DoEvents()
                'lblStatus.Text = "OK, Barang ditemukan di list, silahkan di ADJUST!"
                'lblNmBrg.Text = dtrow(0)("nama_barang").ToString
                txtcari.SelectAll()
                'If dtrow(i)("qty_order") > dtrow(i)("qty_out") Then  ' jika sisa masih ada maka ble terus transaksi barcode
                'If dtrow.Count > 0 Then
                'dtrow(i)("qty_out") = dtrow(i)("qty_out") + 1
                'dtrow(i)("rp_trans") = dtrow(i)("qty_out") * dtrow(i)("harga")
                'dtrow(i)("qty_sisa") = dtrow(i)("qty_order") - dtrow(i)("qty_out")
                ok = True
                BindingContext(GcMonBK.DataSource).Position = getPosisi(dtrow(0))
                'tunda()

                txtcari.Focus()
                'MsgBox("barang ada")
                'Exit Sub
                'End If
                'Next


                'MsgBox("barang tidak ada")
                'ElseIf Not ok Then
                '    lblNmBrg.Text = "Barang sudah terdaftar semua"
                '    lblStatus.Text = "STOP!"
            End If
            txtcari.SelectAll()
        End If
    End Sub

    Sub tunda()
        Me.Refresh()
        System.Threading.Thread.Sleep(2000)
    End Sub
    Function getPosisi(ByVal dr As DataRow) As Integer
        Dim i As Int16 = 0
        For Each rw As DataRow In ds.Tables("_MonSaldo").Rows
            If dr Is rw Then
                Return i
            Else
                i += 1
            End If
        Next
    End Function
End Class