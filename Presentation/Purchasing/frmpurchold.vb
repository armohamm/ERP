'======================================================================
'= Dikerjakan oleh Yahya Drake Rozi   http://yayakdrake.blogspot.com  =
'= yahya.rozi@quadras.co.id // yahyarozi@gmail.com                    =
'= Project: Dinasty group american pillow @2011                       =
'= Sebelum Coding Jangan Lupa kopi +Surya 16                          =
'======================================================================
'Imports CrystalDecisions.CrystalReports.Engine
'Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Windows.Forms
Imports DevExpress.XtraPrintingLinks


Public Class frmpurchold
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Dim ds, ds_cari2, ds_cari, ds_cari1, dsLookUp, ds1, ds2, ds_sup As New DataSet
    Dim da, DALOOKUP1, DALOOKUP, DALOOKUP2, da4, da5, da_sup As SqlDataAdapter
    Dim prn As frmMain
    Dim notrans, nodpm, kd_barang, no_seq_qc As String
    Dim jumlah_dpm As Double
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Dim y As Int16 = 1
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Private Buildernya As New SqlClient.SqlCommandBuilder
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
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder
        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        setStatus()
        GvMonHold2.FocusedColumn = GvMonHold2.VisibleColumns(11)
    End Sub
    Public Sub insert_dpm_m()
        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader
        Try
            sqlCmd.Connection = sqlconn
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.CommandText = "PURC.dbo.insertdpm_m"

           
            sqlCmd.Parameters.Add("@nodpm", SqlDbType.Char).Value = nodpm
            sqlCmd.Parameters.Add("@tgldpm", SqlDbType.Date).Value = Now.Date
            sqlCmd.Parameters.Add("@departemen", SqlDbType.Char).Value = kddep
            sqlCmd.Parameters.Add("@cabang", SqlDbType.Char).Value = kdcabang


            dr = sqlCmd.ExecuteReader
            dr.Close()

        Catch e As Exception


        End Try

    End Sub

    Public Sub call_procedure()
        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader
        Try
            sqlCmd.Connection = sqlconn
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.CommandText = "PURC.dbo.procdure1"

            sqlCmd.Parameters.Add("@no_trans", SqlDbType.Char).Value = notrans
            sqlCmd.Parameters.Add("@kdstok", SqlDbType.Char).Value = kd_barang
            sqlCmd.Parameters.Add("@seq_qc", SqlDbType.Char).Value = no_seq_qc
            sqlCmd.Parameters.Add("@nodpm", SqlDbType.Char).Value = nodpm
            sqlCmd.Parameters.Add("@tgldpm", SqlDbType.Date).Value = Now.Date
            sqlCmd.Parameters.Add("@departemen", SqlDbType.Char).Value = kddep
            sqlCmd.Parameters.Add("@qty_realese", SqlDbType.Decimal).Value = jumlah_dpm

            sqlCmd.Parameters.Add("@seq", SqlDbType.Char).Value = y

            dr = sqlCmd.ExecuteReader
            dr.Close()

        Catch e As Exception


        End Try

    End Sub


    Public Sub save_click()
        Dim BTRANS As SqlTransaction
        nodpm = getNoTrans("DPM-MH", getTanggal(BTRANS), BTRANS)
        insert_dpm_m()

        For i As Integer = 0 To ds.Tables("_MonQC").Rows.Count - 1
           
            If IIf(ds.Tables("_MonQC").Rows(i).Item("sudah_dpm") Is DBNull.Value, "N", ds.Tables("_MonQC").Rows(i).Item("sudah_dpm")) = "Y" Then

                notrans = ds.Tables("_MonQC").Rows(i).Item("no_trans")
                kd_barang = ds.Tables("_MonQC").Rows(i).Item("kd_stok")
                no_seq_qc = ds.Tables("_MonQC").Rows(i).Item("no_seq")
                jumlah_dpm = ds.Tables("_MonQC").Rows(i).Item("qty_release")

                call_procedure()
                y += 1
            End If

        Next
        ReloadTable()
        showMessages("berhasil disimpan")
        TextBox1.Text = nodpm

        'Try
        '    Buildernya = New SqlClient.SqlCommandBuilder(da)
        '    da.UpdateCommand = Buildernya.GetUpdateCommand()
        '    da.InsertCommand = Buildernya.GetInsertCommand()
        '    da.DeleteCommand = Buildernya.GetDeleteCommand()

        '    'Buildernya = New SqlClient.SqlCommandBuilder(DA2)
        '    'DA2.UpdateCommand = Buildernya.GetUpdateCommand()
        '    'DA2.InsertCommand = Buildernya.GetInsertCommand()
        '    'DA2.DeleteCommand = Buildernya.GetDeleteCommand()

        '    BTRANS = sqlconn.BeginTransaction("1")
        '    da.UpdateCommand.Transaction = BTRANS
        '    da.InsertCommand.Transaction = BTRANS
        '    da.DeleteCommand.Transaction = BTRANS

        '    'DA2.UpdateCommand.Transaction = BTRANS
        '    'DA2.InsertCommand.Transaction = BTRANS
        '    'DA2.DeleteCommand.Transaction = BTRANS

        '    da.Update(ds.Tables("_MonQC"))
        '    'DA2.Update(dSO1.Tables("_bme_d"))


        '    BTRANS.Commit()
        '    showMessages("Data Berhasil disimpan")
        '    STATE = "EDIT"
        '    frmMain.btnSave.Enabled = False
        'Catch e As Exception
        '    BTRANS.Rollback()
        '    ds.Tables("_MonQC").RejectChanges() ' untuk membatalkan row yg diupdate/insert
        '    MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Di Simpan")

        'End Try

    End Sub

    Public Sub cetak_click()
        GcMonHOLD2.Refresh()
        PrintingSystem1.ResetProgressReflector()
        PrintableComponentLink1.ShowPreview()
    End Sub
    Sub ReloadTable()
        Dim sqltgl As String = ""
        If tglDari.EditValue = vbNullString And tglsampai.EditValue = vbNullString Then
            sqltgl = "1=0"
        ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue = vbNullString Then
            sqltgl = " qc.tgl_trans > convert(date,'" & tglDari.EditValue & "',103)"
        ElseIf tglDari.EditValue = vbNullString And tglsampai.EditValue <> vbNullString Then
            sqltgl = " qc.tgl_trans < convert(date,'" & tglsampai.EditValue & "',103)"
        ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString Then
            sqltgl = " qc.tgl_trans between convert(date,'" & tglDari.EditValue & "',103) and convert(date,'" & tglsampai.EditValue & "',103)"
            'ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString And lookupBulanAwal.EditValue <> vbNullString Then
            'sqltgl = sqltgl & "and qc.blthn='" & lookupBulanAwal.EditValue & "'"
            'Else      '   LookupBlthn.EditValue <> vbNullString Then
            '   sqltgl = "qc.blthn='" & lookupBulanAwal.EditValue & "'"
        End If

        If Not ds.Tables("_MonQC") Is Nothing Then ds.Tables("_MonQC").Clear()
        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select qc.tgl_trans,qc.no_trans,qc.no_ref,qc.no_seq,qcm.kd_supplier,qc.kd_stok,qc.qty_release,qc.kd_satuan,qc.keterangan,qc.sudah_dpm, 0 as nomer,(select Nama_Barang from sif.dbo.sif_barang where kode_barang=kd_stok) as nama_barang from INV.dbo.INV_QC qc INNER join INV.dbo.INV_QC_M qcm on qcm.no_trans=qc.no_trans where qc.status_hold = 'DONE' and ISNULL(qc.sudah_dpm,'T') <>'Y' and  " & sqltgl & "", sqlconn))
        'da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select qc.tgl_trans,qc.no_ref,qcm.kd_supplier,qc.kd_stok,qc.qty_release,qc.kd_satuan,qc.keterangan,qc.sudah_dpm, 0 as nomer,(select Nama_Barang from sif.dbo.sif_barang where kode_barang=kd_stok) as nama_barang from INV.dbo.INV_QC qc INNER join INV.dbo.INV_QC_M qcm on qcm.no_trans=qc.no_trans where qc.status_hold = 'DONE' and ISNULL(qc.sudah_dpm,'T') <>'Y' and  " & sqltgl & "", sqlconn))
        da.Fill(ds, "_MonQC")
        GcMonHOLD2.DataSource = ds.Tables("_MonQC")



    End Sub

    Private Sub isinomer()
        Dim i As Int16 = 1
        For Each row As DataRow In ds.Tables("_MonQC").Rows
            row.Item("nomer") = i : i += 1
        Next
    End Sub

    Private Sub formate_yayak()
        'thisThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        'GvMonHold2.Columns("hold").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'GvMonHold2.Columns("hold").DisplayFormat.FormatString = "n0"
        'GvMonHold2.Columns("qty_release").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'GvMonHold2.Columns("qty_release").DisplayFormat.FormatString = "n0"
        ''GvMonHold2.Columns("release_hold").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        ''GvMonHold2.Columns("release_hold").DisplayFormat.FormatString = "n0"
        'GvMonHold2.Columns("qty_reject_hold").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'GvMonHold2.Columns("qty_reject_hold").DisplayFormat.FormatString = "n0"
    End Sub

    Private Sub frmpurchold_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        ReloadTable()
        formate_yayak()
        'dt_blthn.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime

        'GcMonQC.DataSource = ds.Tables("_MonQC")

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        DALOOKUP2.Fill(ds_cari2, "_lookup2")
        LookupBarang.DataSource = ds_cari2.Tables("_lookup2")
        LookupBarang.ValueMember = "Kode_Barang"
        LookupBarang.DisplayMember = "Nama_Barang"

        da_sup = New SqlDataAdapter(New SqlCommand("SELECT Kode_Supplier,Nama_Supplier from SIF.dbo.SIF_Supplier", sqlconn))
        da_sup.Fill(ds_sup, "_sup")
        RepLookSup.DataSource = ds_sup.Tables("_sup")
        RepLookSup.ValueMember = "Kode_Supplier"
        RepLookSup.DisplayMember = "Nama_Supplier"
        'Loadblthn()
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        ReloadTable()
        isinomer()
    End Sub

    Private Sub btnprin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprin.Click
        GcMonHOLD2.Refresh()
        PrintingSystem1.ResetProgressReflector()
        PrintableComponentLink1.ShowPreview()
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        tglDari.EditValue = vbNullString
        tglsampai.EditValue = vbNullString
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            For i As Integer = 0 To ds.Tables("_MonQC").Rows.Count - 1

                ds.Tables("_MonQC").Rows(i).Item("sudah_dpm") = "Y"

            Next
        Else
            For i As Integer = 0 To ds.Tables("_MonQC").Rows.Count - 1

                ds.Tables("_MonQC").Rows(i).Item("sudah_dpm") = "T"

            Next
        End If
    End Sub

    Public Sub cancel_click()
        TextBox1.Text = ""
        ReloadTable()
        isinomer()
    End Sub
    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class

