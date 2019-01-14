Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Windows.Forms
Imports DevExpress.XtraPrintingLinks

Public Class frmReCtk_QC
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Dim ds, ds_cari2, ds_cari, ds_cari1, dsLookUp As New DataSet
    Dim da, DALOOKUP1, DALOOKUP, DALOOKUP2 As SqlDataAdapter
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Dim prn As frmMain
    Private STATE As String
    Public btnSave As Boolean = True
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
        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = False
        setStatus()
    End Sub
    Public Sub cancel_click()

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
    End Sub
    Private Sub formate_yayak()
        thisThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        'GvMonQC.Columns("qty_order").SummaryItem.DisplayFormat = DevExpress.Utils.FormatType.Numeric
        'GvMonQC.Columns("qty_order").SummaryItem.DisplayFormat
        GvMonQC.Columns("qty_qc_pass").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvMonQC.Columns("qty_qc_pass").DisplayFormat.FormatString = "n2"
        GvMonQC.Columns("qty_order").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvMonQC.Columns("qty_order").DisplayFormat.FormatString = "n2"
        GvMonQC.Columns("hold").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvMonQC.Columns("hold").DisplayFormat.FormatString = "n2"
        GvMonQC.Columns("qty_qc_unpass").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GvMonQC.Columns("qty_qc_unpass").DisplayFormat.FormatString = "n2"
        'GvMonQC.Columns("qty_sisa").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'GvMonQC.Columns("qty_sisa").DisplayFormat.FormatString = "n2"
    End Sub



    Private Sub frmReCtk_QC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        ReloadTable()
        formate_yayak()

        GcMonQC.DataSource = ds.Tables("_MonQC")

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        DALOOKUP2.Fill(ds_cari2, "_lookup2")
        LookupBarang.DataSource = ds_cari2.Tables("_lookup2")
        LookupBarang.ValueMember = "Kode_Barang"
        LookupBarang.DisplayMember = "Nama_Barang"

        'DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select distinct(blthn) from INV.dbo.INV_QC", sqlconn))
        'DALOOKUP2.Fill(ds_cari2, "_lookup1")
        'LookupBlthn.Properties.DataSource = ds_cari2.Tables("_lookup1")

        'Loadblthn()

    End Sub

    'Private Sub Loadblthn()
    '    If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
    '    DALOOKUP2 = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
    '    DALOOKUP2.Fill(dsLookUp, "LookPeriode")
    '    'lookupBulanAwal.Properties.DataSource = dsLookUp.Tables("LookPeriode")
    '    'lookupBulanAwal.Properties.DisplayMember = "nama"
    '    'lookupBulanAwal.Properties.ValueMember = "thnbln"

    'End Sub

    Sub ReloadTable()
        Dim sqltgl As String = ""
        If tglDari.EditValue = vbNullString And tglsampai.EditValue = vbNullString Then
            sqltgl = "1=0"
        ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue = vbNullString Then
            sqltgl = " tgl_trans > convert(date,'" & tglDari.Text & "',103)"
        ElseIf tglDari.EditValue = vbNullString And tglsampai.EditValue <> vbNullString Then
            sqltgl = " tgl_trans < convert(date,'" & tglsampai.Text & "',103)"
        ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString Then
            sqltgl = " tgl_trans between convert(date,'" & tglDari.Text & "',103) and convert(date,'" & tglsampai.Text & "',103)"
            'ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString And lookupBulanAwal.EditValue <> vbNullString Then
            '   sqltgl = sqltgl & "and qc.blthn='" & lookupBulanAwal.EditValue & "'"
            'Else      '  LookupBlthn.EditValue <> vbNullString Then
            '   sqltgl = "qc.blthn='" & lookupBulanAwal.EditValue & "'"
        End If


        If Not ds.Tables("_MonQC") Is Nothing Then ds.Tables("_MonQC").Clear()
        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,0 as nomer from INV.dbo.INV_QC_M where " & sqltgl & "", sqlconn))
        da.Fill(ds, "_MonQC")
        GcMonQC.DataSource = ds.Tables("_MonQC")
    End Sub

    'Private Sub isitable()
    '    Dim i As Int16 = 1
    '    Dim sqldr As SqlDataReader = New SqlCommand("select qc.tgl_trans, qc.no_trans,qc.no_ref,po.kd_supplier,sup.Nama_Supplier, qc.kd_stok,qc.tgl_trans,qc.qty_datang,qc.qty_order,qc.qty_qc_pass,qc.qty_qc_unpass,qc.qty_hold,qc.qty_sisa,qc.rp_trans,qcm.jml_rp_trans, 0 as nomer from INV.dbo.INV_QC as qc INNER join PURC.dbo.PURC_PO as po on qc.no_ref=po.no_po LEFT JOIN INV.dbo.INV_QC_M as qcm on qc.no_trans=qcm.no_trans LEFT JOIN sif.dbo.SIF_Supplier as sup on po.kd_supplier=sup.Kode_Supplier where qc.blthn='" & LookupBlthn.EditValue & "'", sqlconn).ExecuteReader
    '    While sqldr.Read
    '        Dim row As DataRow = ds.Tables("_MonQC").NewRow
    '        row.Item("nomer") = i : i += 1
    '        row.Item("kd_stok") = sqldr.Item("kd_stok")
    '        row.Item("no_ref") = sqldr.Item("no_ref")
    '        row.Item("Nama_Supplier") = sqldr.Item("Nama_Supplier")
    '        row.Item("no_trans") = sqldr.Item("no_trans")
    '        row.Item("tgl_trans") = sqldr.Item("tgl_trans")
    '        row.Item("qty_order") = sqldr.Item("qty_order")
    '        row.Item("qty_datang") = sqldr.Item("qty_datang")
    '        row.Item("qty_qc_pass") = sqldr.Item("qty_qc_pass")
    '        row.Item("qty_qc_unpass") = sqldr.Item("qty_qc_unpass")
    '        row.Item("qty_hold") = sqldr.Item("qty_hold")
    '        row.Item("qty_sisa") = sqldr.Item("qty_sisa")

    '        ds.Tables("_MonQC").Rows.Add(row)
    '    End While
    '    sqldr.Close()
    'End Sub

    Private Sub isinomer()
        Dim i As Int16 = 1
        For Each row As DataRow In ds.Tables("_MonQC").Rows
            row.Item("nomer") = i : i += 1
        Next
    End Sub


    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        'MsgBox(lookupBulanAwal.EditValue)
        'MsgBox(lookupBulanAwal.Text)
        ReloadTable()
        isinomer()
    End Sub

    'Public Sub cetak_click()
    '    GcMonQC.Refresh()
    '    PrintingSystem1.ResetProgressReflector()
    '    PrintableComponentLink1.ShowPreview()
    'End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        tglDari.EditValue = vbNullString
        tglsampai.EditValue = vbNullString
    End Sub

    Public Sub save_click()
        Dim BTRANS As SqlTransaction
        Try
            Buildernya = New SqlClient.SqlCommandBuilder(da)
            da.UpdateCommand = Buildernya.GetUpdateCommand()
            da.InsertCommand = Buildernya.GetInsertCommand()
            da.DeleteCommand = Buildernya.GetDeleteCommand()

            'Buildernya = New SqlClient.SqlCommandBuilder(DA2)
            'DA2.UpdateCommand = Buildernya.GetUpdateCommand()
            'DA2.InsertCommand = Buildernya.GetInsertCommand()
            'DA2.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            da.UpdateCommand.Transaction = BTRANS
            da.InsertCommand.Transaction = BTRANS
            da.DeleteCommand.Transaction = BTRANS

            'DA2.UpdateCommand.Transaction = BTRANS
            'DA2.InsertCommand.Transaction = BTRANS
            'DA2.DeleteCommand.Transaction = BTRANS

            da.Update(ds.Tables("_MonQC"))
            'DA2.Update(dSO1.Tables("_bme_d"))


            BTRANS.Commit()
            showMessages("Data Berhasil disimpan")
            STATE = "EDIT"
            frmMain.btnSave.Enabled = False
        Catch e As Exception
            BTRANS.Rollback()
            ds.Tables("_MonQC").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Di Simpan")

        End Try

    End Sub

    Private Sub btn_deselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_deselect.Click
        btn_deselect.Enabled = True
        Btn_pilih.Enabled = False
        For Each klik As DataRow In ds.Tables("_MonQC").Rows
            klik.Item("cetak_ulang") = "T"
        Next
    End Sub

    Private Sub Btn_pilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_pilih.Click
        btn_deselect.Enabled = True
        Btn_pilih.Enabled = False
        For Each klik As DataRow In ds.Tables("_MonQC").Rows
            klik.Item("cetak_ulang") = "Y"
        Next
    End Sub
End Class