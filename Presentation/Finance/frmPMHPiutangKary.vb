Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Public Class frmPMHPiutangKary
    Dim ds1, ds2, ds3, ds4, ds5 As New DataSet
    Dim da1, da2, da3, da4, da5, dax As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
    Dim prn As frmMain
    Public btnSave As Boolean = True
    Public btnAdd As Boolean = False
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = True
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public State As String
    Public dipilih As String
    Dim table As DataTable
    Dim noInv, tampung As String
    Dim isOK As Boolean = True
    Dim err As String

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btnCetak
        End With
    End Sub

    Private Sub loadLookUp()
        If Not ds5.Tables("_karyawan") Is Nothing Then ds5.Tables("_karyawan").Clear()
        If Not ds5.Tables("_rekening") Is Nothing Then ds5.Tables("_rekening").Clear()
        If Not ds5.Tables("_rekening2") Is Nothing Then ds5.Tables("_rekening2").Clear()

        da5 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Pegawai, Nama_Pegawai from SIF.dbo.SIF_Pegawai", sqlconn))
        da5.Fill(ds5, "_karyawan")
        lookupPeg.DataSource = ds5.Tables("_karyawan")
        lookupPeg.ValueMember = "Kode_Pegawai"
        lookupPeg.DisplayMember = "Nama_Pegawai"
        Lookkaryawan.Properties.DataSource = ds5.Tables("_karyawan")
        Lookkaryawan.Properties.ValueMember = "Kode_Pegawai"
        Lookkaryawan.Properties.DisplayMember = "Nama_Pegawai"

        da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_buku_besar, nm_buku_besar from SIF.dbo.SIF_buku_besar where kd_buku_besar = '' and grup_header='D'", sqlconn))
        da2.Fill(ds5, "_rekening")
        lookuprek.DataSource = ds5.Tables("_rekening")
        lookuprek.ValueMember = "kd_buku_besar"
        lookuprek.DisplayMember = "nm_buku_besar"

        da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_buku_besar, nm_buku_besar from SIF.dbo.SIF_buku_besar where kd_buku_besar like '101%' and grup_header='D'", sqlconn))
        da2.Fill(ds5, "_rekening2")
        lookPelunasan.Properties.DataSource = ds5.Tables("_rekening2")
        lookPelunasan.Properties.ValueMember = "kd_buku_besar"
        lookPelunasan.Properties.DisplayMember = "nm_buku_besar"
    End Sub

    Private Sub frmTemplate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnAdd = False
        setStatus()
        State = "ADD"
        loadLookUp()
        bersihkan()
        loadGrid()
        isiGrid("xxx")
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        'da1 = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA where tipe_trans='JPJ-KPT-08'", sqlconn))
        'da1.Fill(ds1, "Db_data1")

        'txtno_inv.Enabled = False
        'Lookrekening.EditValue = "1-421000"

    End Sub

    'Public Sub add_click()
    '    bersihkan()
    'End Sub

    'Public Sub hapus_record()
    '    If Not ds1.Tables("Db_data3") Is Nothing Then
    '        For Each rw As DataRow In ds1.Tables("Db_data3").Rows
    '            rw.Delete()
    '        Next
    '    End If
    '    save_click(True)
    'End Sub

    Public Sub bersihkan()
        txtno_inv.Text = ""
        txtjml_val_trans.EditValue = 0
        Lookkaryawan.ItemIndex = 0
        lookPelunasan.ItemIndex = 0
        txtketerangan.Text = ""
        dttgl_inv.EditValue = getTanggal()
        'Lookrekening.EditValue = vbNullString
        'If Not ds1.Tables("Db_data1") Is Nothing Then ds1.Tables("Db_data1").Clear()
    End Sub

    Private Sub loadGrid()
        If Not ds1.Tables("Db_data2") Is Nothing Then ds1.Tables("Db_data2").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA where tipe_trans = 'JKK-KPT-01' ORDER BY tgl_inv DESC", sqlconn))
        da1.Fill(ds1, "Db_data2")
        GC.DataSource = ds1.Tables("Db_data2")
    End Sub

    Public Sub isiGrid(ByVal kode As String)
        If Not ds1.Tables("Db_data1") Is Nothing Then ds1.Tables("Db_data1").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA where no_inv = '" & kode & "'", sqlconn))
        da1.Fill(ds1, "Db_data1")
        'GC.DataSource = ds1.Tables("Db_data1")

        If Not ds1.Tables("Db_data1").Rows.Count <= 0 Then
            txtno_inv.Text = ds1.Tables("Db_data1").Rows(0).Item("no_inv").ToString
            txtjml_val_trans.EditValue = ds1.Tables("Db_data1").Rows(0).Item("jml_val_trans").ToString
            Lookkaryawan.EditValue = ds1.Tables("Db_data1").Rows(0).Item("kd_cust").ToString
            txtketerangan.Text = ds1.Tables("Db_data1").Rows(0).Item("keterangan").ToString
            lookPelunasan.EditValue = ds1.Tables("Db_data1").Rows(0).Item("kd_bb_kas").ToString
        End If
    End Sub

    Public Sub call_procedure(ByVal tipeT As String, ByVal noG As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_AUTOMAN_JURNAL"

        sqlCmd.Parameters.Add("@tipe_trans", SqlDbType.Char).Value = tipeT
        sqlCmd.Parameters.Add("@no_inv", SqlDbType.Char).Value = noG
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub save_click(Optional ByVal isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction

        If Not isDelete Then
            cek()
            If isOK = True Then
                If State = "ADD" Then
                    noInv = getNoTrans("PIUTKAR", dttgl_inv.EditValue, BTRANS)
                    txtno_inv.Text = noInv
                    row = ds1.Tables("Db_data1").NewRow
                    row.Item("no_inv") = txtno_inv.Text
                    row.Item("Kd_cabang") = getKodeCabang()
                    row.Item("tipe_trans") = "JKK-KPT-01"
                    row.Item("status") = "MOHON"
                    row.Item("kd_bb_kas") = lookPelunasan.EditValue
                    row.Item("kd_buku_besar") = "1037002"
                    row.Item("thnbln") = dttgl_inv.DateTime.Year & Microsoft.VisualBasic.Right("0" & dttgl_inv.DateTime.Month, 2)
                    row.Item("Last_create_date") = getTanggal()
                    row.Item("Last_created_by") = username
                    row.Item("Program_name") = Me.Name
                ElseIf State = "EDIT" Then
                    row = ds1.Tables("Db_data2").Rows(0)
                    row.Item("Last_update_date") = getTanggal()
                    row.Item("Last_updated_by") = username
                End If

                If (State = "ADD" Or State = "EDIT") Then
                    row.Item("tgl_inv") = dttgl_inv.EditValue
                    row.Item("kd_cust") = Lookkaryawan.EditValue
                    row.Item("keterangan") = txtketerangan.Text
                    row.Item("jml_val_trans") = txtjml_val_trans.EditValue
                    row.Item("jml_rp_trans") = txtjml_val_trans.EditValue
                    row.Item("jml_tagihan") = txtjml_val_trans.EditValue
                    row.Item("jml_bayar") = 0
                    row.Item("kd_valuta") = "IDR"
                    row.Item("kurs_valuta") = 1
                End If

                If State = "ADD" Then
                    ds1.Tables("Db_data1").Rows.Add(row)
                End If
            Else
                MsgBox("Ada kesalahan dalam mengisi data : " & vbCrLf & err, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                err = ""
                Exit Sub
            End If
        End If

        Try
            mb = New SqlClient.SqlCommandBuilder(da1)
            da1.UpdateCommand = mb.GetUpdateCommand()
            da1.InsertCommand = mb.GetInsertCommand()
            da1.DeleteCommand = mb.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            da1.UpdateCommand.Transaction = BTRANS
            da1.InsertCommand.Transaction = BTRANS
            da1.DeleteCommand.Transaction = BTRANS

            da1.Update(ds1.Tables("Db_data1"))
            ds1.Tables("Db_data1").AcceptChanges()

            'If Not State = "DELETE" Then
            '    call_procedure("JKK-KPT-01", noInv, BTRANS)
            'End If

            BTRANS.Commit()

            If Not isDelete Then
                showMessages("Data Telah Disimpan..!")
            Else
                showMessages("Data Telah Dihapus..!")
            End If
            cancel_click()
            loadGrid()
            'refreshNo()
        Catch ex As Exception
            BTRANS.Rollback()
            ds1.Tables("Db_data1").RejectChanges()
            MsgBox(ex.Message)
        End Try
        Try
            'umum.coll_form.Item("aFormAppPiutKar").loadData()
        Catch ex As Exception

        End Try
    End Sub

    Public Sub delete_click()
        If Not ds1.Tables("Db_data1") Is Nothing Then
            For Each rw As DataRow In ds1.Tables("Db_data1").Rows
                If Not (rw.Item("no_jurnal") Is Nothing Or TypeOf rw.Item("no_jurnal") Is DBNull) Then
                    tampung = rw.Item("no_jurnal")
                    With New SqlCommand("DELETE FROM FIN.dbo.FIN_JURNAL WHERE no_jur = '" & tampung & "'", sqlconn)
                        .ExecuteNonQuery()
                    End With
                    With New SqlCommand("DELETE FROM FIN.dbo.FIN_JURNAL_D WHERE no_jur = '" & tampung & "'", sqlconn)
                        .ExecuteNonQuery()
                    End With
                End If
                rw.Delete()
            Next
        End If
        save_click(True)
    End Sub

    Sub refreshNo()
        If Not GV.RowCount <= 0 Then
            For i As Integer = 1 To GV.RowCount
                GV.SetRowCellValue(i, "no", i)
            Next
        End If
    End Sub

    Public Sub cancel_click()
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        State = "ADD"
        isiGrid("xxx")
    End Sub

    'Private Sub GV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV.Click
    '    State = "DELETE"
    '    isiGrid(GV.GetFocusedRowCellValue("no_inv"))
    '    btnSave = False
    '    btnDelete = True
    '    btnCancel = False
    '    setStatus()
    'End Sub

    Private Sub GV_CustomColumnDisplayText(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs) Handles GV.CustomColumnDisplayText
        Dim Col As DevExpress.XtraGrid.Columns.GridColumn = e.Column
        If Col.Name = "no" Then
            e.DisplayText = (e.RowHandle + 1).ToString
        End If
    End Sub

    Private Sub controlOff(ByVal stat As Boolean)
        txtno_inv.ReadOnly = stat
        dttgl_inv.Properties.ReadOnly = stat
        Lookkaryawan.Properties.ReadOnly = stat
        txtjml_val_trans.Properties.ReadOnly = stat
        txtketerangan.ReadOnly = stat
    End Sub

    Private Sub GV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV.DoubleClick
        If Not ds2.Tables("carijur") Is Nothing Then ds2.Tables("carijur").Clear()
        da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_JURNAL where no_jur = '" & txtno_inv.Text & "' and not (no_posting = '' or no_posting is null)", sqlconn))
        da2.Fill(ds2, "carijur")
        isiGrid(GV.GetFocusedRowCellValue("no_inv"))
        If Not ds2.Tables("carijur").Rows.Count <= 0 Then
            MsgBox("Nota dengan nomor : " & GV.GetFocusedRowCellValue("no_inv") & " telah diposting. Data tidak dapat diubah.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            controlOff(True)
            btnAdd = False
            btnEdit = False
            btnSave = False
            btnDelete = False
            btnCancel = True
            setStatus()
        Else
            State = "EDIT"
            controlOff(False)
            btnSave = True
            btnDelete = True
            btnCancel = True
            setStatus()
        End If
    End Sub

    Private Sub cek()
        If Lookkaryawan.EditValue = vbNullString Then
            isOK = False
            err &= "Karyawan harus dipilih." & vbCrLf
            If txtjml_val_trans.Text = vbNullString Or txtjml_val_trans.Text = "" Then
                err &= "Jumlah tidak boleh kosong." & vbCrLf
            End If
        ElseIf txtjml_val_trans.Text = vbNullString Or txtjml_val_trans.Text = "" Then
            isOK = False
            err &= "Jumlah tidak boleh kosong." & vbCrLf
            If Lookkaryawan.EditValue = vbNullString Then
                err &= "Karyawan harus dipilih." & vbCrLf
            End If
        Else
            isOK = True
        End If
    End Sub

    Private Sub dttgl_inv_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dttgl_inv.EditValueChanged
        If dttgl_inv.EditValue = vbNullString Then
            dttgl_inv.EditValue = getTanggal()
        End If
    End Sub
End Class