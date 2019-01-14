'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi + JI Sam SU                        =
'======================================================================

Imports System.Data.SqlClient
Imports System.Globalization
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid

Public Class frmMExternal_nonAGT
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Public STATE, id_anggota, jns As String '<-- untuk mengecek status saat ini (ADD, EDIT, delete)
    Private dSO, dSO1, ds_cari3, dso2, ds_cari, ds_cari1, ds_gdg1, ds_gdg2, dsPayroll, dsLookUp As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private row As DataRow
    Private DA, DA2, DALOOKUP, DALOOKUP1, DA_gdg1, DA_gdg2 As SqlClient.SqlDataAdapter
    Private x As Int16 = 1
    Private bunga, tempo, pokok, bsr_pjm, angs, denda, t_bunga, total, recov, asr As Double
    Private BTRAN As SqlTransaction
    Dim isOK As Boolean = True
    Dim conn, SSQL, err, kdgrp, notranz As String
    Dim oleDA As OleDb.OleDbDataAdapter

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        'Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnDelete = False
        btnCancel = True
        setStatus()
        'bersihkan()
        'dtpTgl.EditValue = getTanggal()
        'enabel()
        'GvBKE_d.Columns("no_seq").Visible = False
        STATE = "ADD" '<-- set state add
    End Sub

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Public Sub cancel_click()
        LoadStruktur()

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
        'bersihkan()
    End Sub
    Private Sub isinomer()
        Dim i As Int16 = 1
        For Each row As DataRow In dSO.Tables("_krd").Rows
            row.Item("nomer") = i : i += 1
        Next
    End Sub


    Private Function blthn(Optional ByVal btrans As Object = Nothing) As String
        Dim hasil As String
        Dim sqlblth As SqlDataReader
        If btrans Is Nothing Then
            'blthn=082011
            'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn).ExecuteReader
            '##blthn=201108
            sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),1,6)as blthn", sqlconn).ExecuteReader
        Else
            'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn, btrans).ExecuteReader
            sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),1,6) as blthn", sqlconn, btrans).ExecuteReader
        End If
        sqlblth.Read()
        hasil = sqlblth.Item(0)
        'End If
        sqlblth.Close()
        Return hasil
    End Function

    Public Sub LoadStruktur()
        If Not dSO.Tables("_krd") Is Nothing Then dSO.Tables("_krd").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,0 as nomer from kredit where STATUS_LUNAS='BELUM' and stat_anggota=0 order by jenis ", sqlconn)) '0 non anggota
        DA.Fill(dSO, "_krd")
        Gc_nabung.DataSource = dSO.Tables("_krd")
    End Sub
    Public Sub save_click()
        If MsgBox("Perubahan Data akan di simpan?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            simpanx()
        End If
    End Sub
    'Public Sub simpan()

    'End Sub
    Public Sub simpanx()
        Dim BTRANS As SqlTransaction
        If STATE = "ADD" Then
            For Each row As DataRow In dSO.Tables("_krd").Rows
                If row.RowState = DataRowState.Added Then
                    row.Item("Last_Create_Date") = getTanggal()
                    row.Item("Last_Created_By") = username
                ElseIf row.RowState = DataRowState.Modified Then
                    row.Item("Last_Update") = getTanggal()
                    row.Item("Last_Updated_By") = username
                End If
            Next
            '    If row.RowState = DataRowState.Added Then

            'row = dSO.Tables("_krd").NewRow
            'For Each row As DataRow In dSO.Tables("_krd").Rows()

            'Next
        End If
        'If STATE = "EDIT" Then
        '    row = dSO.Tables("_krd").Rows(0)
        '    row.Item("Last_Update") = getTanggal()
        '    row.Item("Last_Updated_By") = username
        'End If

        Try
            Buildernya = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = Buildernya.GetUpdateCommand()
            DA.InsertCommand = Buildernya.GetInsertCommand()
            DA.DeleteCommand = Buildernya.GetDeleteCommand()


            BTRANS = sqlconn.BeginTransaction("1")
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS



            DA.Update(dSO.Tables("_krd"))
            'DA2.Update(dSO1.Tables("_krd"))

            'STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil di Maintenance")
            btnSave = False
            cancel_click()
            setStatus()

        Catch e As Exception
            BTRANS.Rollback()
            dSO.Tables("_krd").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try

    End Sub

    Private Sub frmMDebetExt_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        LoadStruktur()
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select kode,Nama from m_jns_upload ", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        RL_grup.DataSource = ds_cari.Tables("_lookup1")
        RL_grup.ValueMember = "kode"
        RL_grup.DisplayMember = "Nama"

        DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select nasabah_id,Nama from anggota", sqlconn))
        DALOOKUP1.Fill(ds_cari1, "_nm")
        RL_nama.DataSource = ds_cari1.Tables("_nm")
        RL_nama.ValueMember = "nasabah_id"
        RL_nama.DisplayMember = "Nama"

        'DALOOKUP1 = New SqlDataAdapter(New SqlCommand("select nasabah_id,Nama from anggota", sqlconn))
        'DALOOKUP1.Fill(ds_cari1, "_nm")
        'RL_nama.DataSource = ds_cari1.Tables("_nm")
        'RL_nama.ValueMember = "nasabah_id"
        'RL_nama.DisplayMember = "Nama"

    End Sub

    'Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    OpenFileDialog1.ShowDialog()
    '    If OpenFileDialog1.FileName.ToString <> "" Then
    '        txtFile.EditValue = OpenFileDialog1.FileName
    '    End If
    'End Sub

    'Private Sub btnprin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    load_xls()
    'End Sub

    'Public Sub load_xls()
    '    If Not dsPayroll.Tables("Payroll") Is Nothing Then dsPayroll.Tables("Payroll").Clear()
    '    If Not dsLookUp.Tables("file") Is Nothing Then dsLookUp.Tables("file").Clear()
    '    conn = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" & txtFile.EditValue & ";Extended Properties=""Excel 8.0;"""
    '    SSQL = "SELECT * from `" & txtSheet.EditValue & "$`"
    '    oleDA = New OleDb.OleDbDataAdapter(SSQL, conn)
    '    oleDA.Fill(dsLookUp, "file")

    '    Dim i As Integer = 1

    '    For Each row As DataRow In dsLookUp.Tables("file").Rows
    '        Dim rowGrid As DataRow = dSO.Tables("_krd").NewRow
    '        rowGrid.Item("Kd_Cabang") = getKodeCabang()
    '        'rowGrid.Item("Start_Date") = dteTanggal.EditValue
    '        rowGrid.Item("Kode_Barang") = row("Kode_Barang")
    '        rowGrid.Item("nm_stok") = row("Nama_Barang")
    '        rowGrid.Item("Harga_Rupiah") = row("harga_principal")
    '        rowGrid.Item("harga_jual") = row("harga_retail")
    '        rowGrid.Item("harga_gro") = row("harga_grocery")
    '        rowGrid.Item("harga_free") = row("harga_freelance")
    '        dsPayroll.Tables("_krd").Rows.Add(rowGrid)
    '        i += 1
    '    Next
    '    GV_export.BestFitColumns()
    'End Sub



    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        LoadStruktur()
    End Sub



    Private Sub GV_export_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV_export.InitNewRow
        'kdgrp = GV_export.GetRow(e.RowHandle).item("kd_grup")
        'notranz = "EXT" & GV_export.GetRow(e.RowHandle).item("kd_grup") & getNextNumber()
        GV_export.GetRow(e.RowHandle).item("no_trans") = "yayak"
        GV_export.GetRow(e.RowHandle).item("stat_anggota") = 0
        GV_export.GetRow(e.RowHandle).item("kd_kredit") = "EXT"

        'MsgBox(kdgrp & " dan " & notranz)
    End Sub




    Private Sub GV_export_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV_export.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV_export.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus data dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "HAPUS?") = MsgBoxResult.Yes Then
                    GV_export.DeleteSelectedRows()
                    STATE = "DELETE"
                    simpanx()
                    LoadStruktur()
                End If
            End If
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        LoadStruktur()
    End Sub

    Private Sub GV_export_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV_export.CellValueChanged
        If e.Column Is sisa_angs Then
            'GV_export.GetRow(e.RowHandle).item("sisa_pokok") = GV_export.GetRow(e.RowHandle).item("JML_POKOK") * GV_export.GetRow(e.RowHandle).item("LAMA_ANGS")) - GV_export.GetRow(e.RowHandle).item("JML_POKOK")* GV_export.GetRow(e.RowHandle).item("LAMA_ANGS")-(GV_export.GetRow(e.RowHandle).item("sisa_angs"))
            GV_export.GetRow(e.RowHandle).item("sisa_pokok") = (GV_export.GetRow(e.RowHandle).item("JML_POKOK") * GV_export.GetRow(e.RowHandle).item("LAMA_ANGS")) - (GV_export.GetRow(e.RowHandle).item("JML_POKOK") * (GV_export.GetRow(e.RowHandle).item("LAMA_ANGS") - GV_export.GetRow(e.RowHandle).item("sisa_angs")))
        End If
        If e.Column Is jml_angsuran Then
            GV_export.GetRow(e.RowHandle).item("JML_POKOK") = GV_export.GetRow(e.RowHandle).item("jml_angsuran") - GV_export.GetRow(e.RowHandle).item("JML_BUNGA")
        End If

        If e.Column Is JML_POKOK Then
            GV_export.GetRow(e.RowHandle).item("jml_angsuran") = GV_export.GetRow(e.RowHandle).item("jml_angsuran") + GV_export.GetRow(e.RowHandle).item("JML_BUNGA")
        End If
    End Sub
End Class