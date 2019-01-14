Imports System.Data.SqlClient
Imports System.Globalization

Public Class frmApprvQC
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public STATE, temp_po, p_np As String
    Private dSO, ds_qcm, ds_cari, ds_brg As New DataSet
    Private DA, DA_QCM, DALOOKUP, da_cari As SqlClient.SqlDataAdapter
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Private rw As DataRow
    Private BTRAN As SqlTransaction


    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        setStatus()
        STATE = "ADD" '<-- set state add

    End Sub

    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()

        'dSO.Clear()
        'DA = New SqlDataAdapter(New SqlCommand("select * from INV.dbo.INV_QC WHERE status_hold='HOLD' and hold <> 0", sqlconn)) ' where status <> 'APPROVE'
        'DA.Fill(dSO, "_hold")
        'GcApprvQC.DataSource = dSO.Tables("_hold")

        'Me.Refresh()
        'System.Threading.Thread.Sleep(1000)
    End Sub

    Public Sub cetak_click()
        callReport(App_Path() & "\report\ReleaseHold.rpt", "", "notrans_act=" & txbNoTrans.Text, False, False)
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

    Public Sub simpan()
        Dim BTRANS As SqlTransaction
        Dim notrans As String
        'If STATE = "ADD" Then
        '    rw = ds_qcm.Tables("_qcm").NewRow
        '    rw.Item("Last_Create_Date") = getTanggal()
        '    rw.Item("Last_Created_By") = username
        'ElseIf STATE = "EDIT" Then
        '    rw = ds_qcm.Tables("_qcm").Rows(0)
        '    rw.Item("Last_Update_Date") = getTanggal()
        '    rw.Item("Last_Updated_By") = username
        'End If
        'rw.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
        'rw.Item("trx_stat") = 0
        'rw.Item("no_trans") = LookupHold.EditValue + "H"
        'rw.Item("no_ref") = temp_po
        'rw.Item("tgl_trans") = getTanggal()
        'rw.Item("p_np") = p_np
        'rw.Item("jml_rp_trans") = GVApprvQC.Columns(9).SummaryItem.SummaryValue
        'rw.Item("blthn") = blthn(BTRANS)

        'rw.Item("Program_Name") = Me.Name
        ''txbNoTrans.Text = row.Item("no_trans")
        'If STATE = "ADD" Then
        '    ds_qcm.Tables("_qcm").Rows.Add(rw)
        'End If
        If STATE = "ADD" Then
            notrans = getNoTrans("QC-HOLD", getTanggal(BTRANS), BTRANS)
            For Each rw1 As DataRow In dSO.Tables("_hold").Rows
                If rw1.RowState = DataRowState.Modified Then
                    rw1.Item("Last_Update_Date") = getTanggal()
                    rw1.Item("Last_Updated_By") = username
                    rw1.Item("notrans_act") = notrans
                    rw1.Item("user_hold") = username
                    rw1.Item("tgl_act_hold") = getTanggal()
                    rw1.Item("jml_cetak_hold") = 1
                    'rw1.Item("Last_Created_By") = username
                    'rw1.Item("Kd_Cabang") = kdcabang
                    'row.Item(" _stat") = 0
                End If
                rw1.Item("Program_name") = Me.Name
                txbNoTrans.Text = notrans
            Next
        Else
            For Each rw1 As DataRow In dSO.Tables("_hold").Rows

                If rw1.RowState = DataRowState.Modified Then
                    rw1.Item("jml_cetak_hold") = rw1("jml_cetak_hold") + 1

                End If

            Next


        End If

        Buildernya = New SqlClient.SqlCommandBuilder(DA)
        DA.UpdateCommand = Buildernya.GetUpdateCommand()
        DA.InsertCommand = Buildernya.GetInsertCommand()

        Buildernya = New SqlClient.SqlCommandBuilder(DA_QCM)
        DA_QCM.UpdateCommand = Buildernya.GetUpdateCommand()
        DA_QCM.InsertCommand = Buildernya.GetInsertCommand()


        BTRANS = sqlconn.BeginTransaction("1")
        DA.UpdateCommand.Transaction = BTRANS
        DA.InsertCommand.Transaction = BTRANS

        DA_QCM.InsertCommand.Transaction = BTRANS
        DA_QCM.UpdateCommand.Transaction = BTRANS
        'DA2.DeleteCommand.Transaction = BTRANS

        'For Each rw1 As DataRow In dSO.Tables("_hold").Rows
        '    Dim sqlcmd As New SqlCommand("update INV.dbo.INV_QC set status_release ='Released',hold=0 where no_trans='" & LookupHold.EditValue & "' and kd_stok='" & rw1("kd_stok") & "'", sqlconn, BTRANS)
        '    sqlcmd.ExecuteNonQuery()
        'Next


        Try

            DA.Update(dSO, "_hold")
            DA_QCM.Update(ds_qcm, "_qcm")
            ''dSO.Tables("_ApprvQC").AcceptChanges()

            'For Each rw As DataRow In dSO.Tables("_hold").Rows
            'If row1.RowState = DataRowState.Added Then
            'Dim sqlcmd As New SqlCommand("update INV.dbo.INV_QC_M set status_hold ='qty_release' where no_trans='" & rw("no_trans") & "'", sqlconn, BTRANS)
            'sqlcmd.ExecuteNonQuery()
            'Next

            showMessages("Approval Status HOLD sukses di Update!")
            STATE = "EDIT"
            BTRANS.Commit()
            frmMain.btnSave.Enabled = False
            frmMain.btnCancel.Enabled = True
            LoadStruktur("xxx")
        Catch ex As Exception
            BTRANS.Rollback()
            dSO.Tables("_hold").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            ds_qcm.Tables("_qcm").RejectChanges()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Ada Kesalahan Data Gagal Simpan")
        End Try

    End Sub

    'Public Sub edit_click()

    '    DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_QC", sqlconn)) '
    '    If Not dSO1.Tables("lookup_qc") Is Nothing Then dSO1.Tables("lookup_qc").Clear()
    '    DA2.Fill(dSO1, "lookup_qc")
    '    frmCari.set_dso(dSO1.Tables("lookup_qc")) '<-- memparsing hasil dataset ke LOV
    '    frmCari.ShowDialog() '<-- menampilkan form LOV
    '    If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
    '        LoadStruktur(frmCari.row(0))
    '        btnadd = False
    '        btnEdit = False



    '        STATE = "EDIT"
    '        btnCancel = True
    '        Me.Enabled = True
    '        setStatus()

    '    Else
    '        cancel_click()
    '        STATE = ""
    '    End If
    'End Sub

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

    Private Sub frmApprvQC_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        GVApprvQC.Columns("harga").Visible = False
        GVApprvQC.Columns("status_hold").Visible = False
        GVApprvQC.Columns("rp_trans").Visible = False
        GVApprvQC.FocusedColumn = GVApprvQC.VisibleColumns(6)

        formate_yayak()

        LoadStruktur("xxxx")

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        DALOOKUP.Fill(ds_brg, "_lookup2")
        LookBrg.DataSource = ds_brg.Tables("_lookup2")
        LookBrg.ValueMember = "Kode_Barang"
        LookBrg.DisplayMember = "Nama_Barang"

    End Sub

    Private Sub LoadStruktur(ByVal kodepo As String)
        'If Not dSO.Tables("_bme") Is Nothing Then dSO.Tables("_bme").Clear()
        If Not dSO.Tables("_hold") Is Nothing Then dSO.Tables("_hold").Clear()

        'DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as petugas from INV.dbo.INV_QC where no_trans='" & kodepo & "'", sqlconn))
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_QC kd_stok where status_hold is not NULL and hold <> 0", sqlconn))
        DA.Fill(dSO, "_hold")
        GcApprvQC.DataSource = dSO.Tables("_hold")

        DA_QCM = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from INV.dbo.INV_QC_M where no_trans='" & kodepo & "'", sqlconn))
        DA_QCM.Fill(ds_qcm, "_qcm")
        'GcBME_d.DataSource = dso.Tables("_qcm")

        'da_cari = New SqlDataAdapter(New SqlCommand("select distinct(no_trans) from INV.dbo.INV_QC WHERE status_hold is not NULL and hold <> 0", sqlconn))
        'da_cari.Fill(ds_cari, "_lookHold")
        'LookupHold.Properties.DataSource = ds_cari.Tables("_lookHold")
        'LookupHold.Properties.DisplayMember = "no_trans"
        'LookupHold.Properties.ValueMember = "no_trans"


        If dSO.Tables("_hold").Rows.Count > 0 Then
            Dim rw As DataRow = dSO.Tables("_hold").Rows(0)
            'txbNoRef.Text = rw("no_ref").ToString
            'txbNoTrans.Text = rw("no_trans").ToString
            'LookupGudang.EditValue = rw("kode_gudang").ToString
            'LookupHold.EditValue = rw("no_trans").ToString
            'MsgBox(rw("no_ref").ToString)
        End If


    End Sub

    Private Sub formate_yayak()
        thisThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        GVApprvQC.Columns("qty_release").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GVApprvQC.Columns("qty_release").DisplayFormat.FormatString = "n3"
        GVApprvQC.Columns("qty_reject_hold").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GVApprvQC.Columns("qty_reject_hold").DisplayFormat.FormatString = "n3"
        GVApprvQC.Columns("hold").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GVApprvQC.Columns("hold").DisplayFormat.FormatString = "n3"
        GVApprvQC.Columns("rp_trans").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GVApprvQC.Columns("rp_trans").DisplayFormat.FormatString = "n2"
        GVApprvQC.Columns("harga").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GVApprvQC.Columns("harga").DisplayFormat.FormatString = "n2"
    End Sub


    'Private Sub LookupHold_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    If STATE = "ADD" Then
    '        If Not dSO.Tables("_hold") Is Nothing Then dSO.Tables("_hold").Clear()
    '        Dim sqldr As SqlDataReader = New SqlCommand("select qc.status_hold,qc.tgl_trans,qc.no_trans,qc.tgl_act_hold,qc.no_ref,qc.no_seq,qc.kd_stok,qc.spek_brg,qc.kd_satuan,qc.kd_ukuran,qc.qty_order,qc.hold, qc.reject_hold,qc.release_hold,qc.kd_buku_besar,qc.kd_buku_biaya,qc.Last_Created_By as petugas,qc.harga,qcm.blthn,qcm.p_np,brg.lokasi from INV.dbo.INV_QC as qc LEFT JOIN INV.dbo.INV_QC_M as qcm on qc.no_trans=qcm.no_trans LEFT JOIN SIF.dbo.SIF_Barang as brg on qc.kd_stok=brg.Kode_Barang WHERE status_hold is not NULL and hold <> 0 and qc.no_trans='" & LookupHold.EditValue & "'", sqlconn).ExecuteReader
    '        Dim i As Int16 = 1
    '        dSO.Tables("_hold").Clear()
    '        While sqldr.Read
    '            Dim rw1 As DataRow = dSO.Tables("_hold").NewRow
    '            'Dim rw_qcm As DataRow = ds_qcm.Tables("_qcm").NewRow
    '            'rw1("Kd_Cabang") = ("Kd_Cabang")
    '            rw1("no_trans") = sqldr.Item("no_trans") + "H"
    '            rw1("tgl_act_hold") = getTanggal()
    '            rw1("tgl_trans") = sqldr.Item("tgl_trans")
    '            rw1("no_ref") = sqldr.Item("no_ref")
    '            rw1("no_seq") = sqldr.Item("no_seq")
    '            rw1("kd_stok") = sqldr.Item("kd_stok")
    '            rw1("spek_brg") = sqldr.Item("spek_brg")
    '            rw1("kd_satuan") = sqldr.Item("kd_satuan")
    '            rw1("kd_ukuran") = sqldr.Item("kd_ukuran")
    '            rw1("status_hold") = sqldr.Item("status_hold")
    '            rw1("qty_order") = sqldr.Item("hold")
    '            'rw1("petugas") = sqldr.Item("petugas")
    '            rw1("qty_release") = sqldr.Item("release_hold")
    '            rw1("reject_hold") = sqldr.Item("reject_hold")
    '            rw1("harga") = sqldr.Item("harga")
    '            rw1("gudang_tujuan") = sqldr.Item("lokasi")
    '            rw1("blthn") = blthn()
    '            rw1("kd_buku_besar") = sqldr.Item("kd_buku_besar")
    '            rw1("kd_buku_biaya") = sqldr.Item("kd_buku_biaya")
    '            temp_po = sqldr.Item("no_ref")
    '            p_np = sqldr.Item("p_np")

    '            dSO.Tables("_hold").Rows.Add(rw1)
    '        End While

    '    End If

    'End Sub

    Private Sub GVApprvQC_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GVApprvQC.CellValueChanged
        If e.Column Is qty_release Then
            If GVApprvQC.GetRow(e.RowHandle).item("qty_release") > GVApprvQC.GetRow(e.RowHandle).item("hold") Then
                MsgBox("Qty Release Hold tidak boleh melebihi qty HOLD!!!")
                ';GVApprvQC.GetRow(e.RowHandle).item("qty_release") = 0
                'GVApprvQC.GetRow(e.RowHandle).item("qty_reject_hold") = 0

                Exit Sub
            Else
                GVApprvQC.GetRow(e.RowHandle).item("qty_reject_hold") = GVApprvQC.GetRow(e.RowHandle).item("hold") - GVApprvQC.GetRow(e.RowHandle).item("qty_release")
                GVApprvQC.GetRow(e.RowHandle).item("rp_trans") = GVApprvQC.GetRow(e.RowHandle).item("harga") * GVApprvQC.GetRow(e.RowHandle).item("qty_release")
                GVApprvQC.GetRow(e.RowHandle).item("hold") = 0
                GVApprvQC.GetRow(e.RowHandle).item("status_hold") = "DONE"

            End If

        End If

    End Sub

    'Private Sub LookupHold_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '    ds_cari.Clear()
    '    da_cari = New SqlDataAdapter(New SqlCommand("select distinct(no_trans) from INV.dbo.INV_QC WHERE status_hold is not NULL and hold <> 0", sqlconn))
    '    da_cari.Fill(ds_cari, "_lookHold")
    '    LookupHold.Properties.DataSource = ds_cari.Tables("_lookHold")
    '    LookupHold.Properties.DisplayMember = "no_trans"
    '    LookupHold.Properties.ValueMember = "no_trans"
    'End Sub
End Class
