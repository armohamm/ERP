Imports System.Data.SqlClient
Public Class Frm_PMH_Piutang
    Dim ds1, ds2, ds3, ds4, ds5 As New DataSet
    Dim da1, da2, da3, da4, da5 As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String

    Public Sub setStatus()
        With prn
            '.btnAdd.Enabled = btnAdd
            '.btnCancel.Enabled = btnCancel
            '.btnDelete.Enabled = btnDelete
            '.btnEdit.Enabled = btnEdit
            '.btnSave.Enabled = btnSave
        End With
    End Sub

    Private Sub frmTemplate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        'prn = getParent(Me)
        State = "ADD"
        'prn = getParent(Me)


        da1 = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA", sqlconn))
        da1.Fill(ds1, "Db_data1")

        'da2 = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA where tipe_trans = 'JPJ-KPT-08'", sqlconn))
        'da2.Fill(ds2, "Db_data2")
        isiGrid()

        da4 = New SqlDataAdapter(New SqlCommand("select Kode_Pegawai, nama_Pegawai from SIF.dbo.SIF_Pegawai", sqlconn))
        da4.Fill(ds4, "Db_data4")

        'gControl.Refresh()
        'gControl.DataSource = ds2.Tables("dtlKapasitas")

        'lkKegiatan.DataSource = ds1.Tables("jnsKeg")
        'lkKegiatan.ValueMember = "Id_Data"
        'lkKegiatan.DisplayMember = "Desc_Data"



        'gView.Columns(0).ColumnEdit = lkKegiatan
        'gView.Columns(3).ColumnEdit = ckStatus
        txtno_inv.Enabled = False
        dttgl_inv.Focus()

    End Sub

    Public Sub add_click()
        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnAdd = False
        State = "ADD"
        setStatus()
        bersihkan()
    End Sub

    Public Sub edit_click()
        'dSO = New DataSet
        da5 = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA where tipe_trans = 'JPJ-KPT-08'", sqlconn))
        da5.Fill(ds5, "_bom")
        frmCari.set_dso(ds5.Tables("_bom"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            txtno_inv.Text = frmCari.row("no_inv").ToString
            txtjml_val_trans.Text = frmCari.row("jml_val_trans").ToString
            txtkd_cust.Text = frmCari.row("kd_cust").ToString
            txtketerangan.Text = frmCari.row("keterangan").ToString
            TxtNama.Text = frmCari.row("nm_cust").ToString
            'dttgl_inv = frmCari.row("tgl_inv")

        End If

        'dso1 = New DataSet
        'DALOOKUP2 = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_bom_d where kd_BOM='" & txbKdBOM.Text & "'", sqlconn))
        'DALOOKUP2.Fill(dso1, "_bom_d")
        'GcMstBOM_d.DataSource = dso1.Tables("_bom_d")
    End Sub
    Public Function getNoTrans(ByVal kdBukti As String, ByVal tgl As Date, Optional ByVal BTRANS As SqlTransaction = Nothing) As String
        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = sqlconn
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.CommandText = "SIF.dbo.sifp_get_no_trans"
        If Not BTRANS Is Nothing Then
            sqlcmd.Transaction = BTRANS
        End If
        sqlcmd.Parameters.Add("@vkd_bukti", SqlDbType.VarChar, 10)
        sqlcmd.Parameters.Add("@vtgl_trans", SqlDbType.Date)
        sqlcmd.Parameters.Add("@vno_trans", SqlDbType.VarChar, 100)
        sqlcmd.Parameters("@vkd_bukti").Value = kdBukti
        sqlcmd.Parameters("@vtgl_trans").Value = tgl
        sqlcmd.Parameters("@vno_trans").Direction = ParameterDirection.Output
        sqlcmd.ExecuteNonQuery()
        Return sqlcmd.Parameters("@vno_trans").Value.ToString
    End Function


    Public Sub bersihkan()
        If Not ds2 Is Nothing Then
            ds2.Clear()
        End If
        If State = "ADD" Then
            txtno_inv.Text = ""
            txtjml_val_trans.Text = ""
            txtkd_cust.Text = ""
            txtketerangan.Text = ""
            TxtNama.Text = ""
        End If
    End Sub
    Public Sub isiGrid()
        bersihkan()
        da2 = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_NOTA where tipe_trans = 'JPJ-KPT-08'", sqlconn))
        da2.Fill(ds2, "Db_data2")
        GC.DataSource = ds2.Tables("Db_data2")
    End Sub

    Public Sub save_click()
        Dim BTRANS As SqlTransaction
        Dim tmpNo As String = ""

        If txtno_inv.Text = "" Then
            txtno_inv.Text = getNoTrans("PIUTKAR", Now)
        End If

        mb = New SqlClient.SqlCommandBuilder(da1)
        da1.UpdateCommand = mb.GetUpdateCommand()
        da1.InsertCommand = mb.GetInsertCommand()
        da1.DeleteCommand = mb.GetDeleteCommand()


        BTRANS = sqlconn.BeginTransaction("1")
        da1.UpdateCommand.Transaction = BTRANS
        da1.InsertCommand.Transaction = BTRANS
        da1.DeleteCommand.Transaction = BTRANS


        If State = "ADD" Then
            If Not ds1.Tables("Db_data1") Is Nothing Then ds1.Tables("Db_data1").Clear()
            row = ds1.Tables("Db_data1").NewRow

            'txtno_inv.Text = getNoTrans("PIUTKAR", Now)

            row.Item("no_inv") = txtno_inv.Text
            row.Item("tgl_inv") = dttgl_inv.DateTime
            row.Item("kd_cust") = txtkd_cust.Text
            row.Item("nm_cust") = TxtNama.Text
            row.Item("keterangan") = txtketerangan.Text
            row.Item("jml_val_trans") = txtjml_val_trans.Text

            ' ga boleh null 
            row.Item("Kd_cabang") = getKodeCabang()
            row.Item("tipe_trans") = "JPJ-KPT-08"

            ds1.Tables("Db_data1").Rows.Add(row)
            da1.Update(ds1.Tables("Db_data1"))

            ds1.Tables("Db_data1").AcceptChanges()
            BTRANS.Commit()

            showMessages("Data Telah Disimpan..!")
            isiGrid()

        ElseIf State = "EDIT" Then
            'tmpNo = ds1.Tables("Db_data1").Rows(0).Item("no_trans")
            'row = ds2.Tables("mstKeg").Rows(0)
            'row.Item("no_trans") = txtNomor.Text
            'row.Item("keterangan") = txtketerangan.Text
            'row.Item("tgl_mulai") = dttgl_inv.DateTime
            'row.Item("tgl_akhir") = dtAkhir.DateTime
        End If

        'For Each rows As DataRow In ds3.Tables("dtlKeg").Rows
        '    If rows.RowState <> DataRowState.Deleted Then
        '        'rows.Item("no_trans") = txtNomor.Text
        '    End If
        'Next

        'Try

        '    da1.Update(ds1.Tables("Db_data1"))
        '    'da3.Update(ds3.Tables("dtlKeg"))
        '    ds1.Tables("Db_data1").AcceptChanges()
        '    'ds3.Tables("dtlKeg").AcceptChanges()

        '    State = "EDIT"
        '    BTRANS.Commit()
        '    showMessages("Saved..")
        'Catch e As Exception
        '    BTRANS.Rollback()
        '    ds1.Tables("Db_data1").RejectChanges() ' untuk membatalkan row yg diupdate/insert
        '    'ds3.Tables("dtlKeg").RejectChanges()
        '    MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

        '    If State = "EDIT" Then
        '        da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from FIN.dbo.FIN_NOTA where no_inv='" & txtno_inv.Text & "'", sqlconn))
        '        If Not ds1.Tables("Db_data1") Is Nothing Then ds1.Tables("Db_data1").Clear()
        '        'da2.Fill(ds2, "mstKeg")
        '        'row = ds2.Tables("mstKeg").Rows(0)
        '        'txtNomor.Text = row.Item("no_trans")
        '        'txtketerangan.Text = row.Item("keterangan")
        '        'dttgl_inv.DateTime = row.Item("tgl_mulai")
        '        'dtAkhir.DateTime = row.Item("tgl_akhir")

        '        'da3 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_target_prod_d where no_trans='" & tmpNo & "'", sqlconn))
        '        'If Not ds3.Tables("dtlKeg") Is Nothing Then ds3.Tables("dtlKeg").Clear()
        '        'da3.Fill(ds3, "dtlKeg")
        '        'gControl.DataSource = ds3.Tables("dtlKeg")
        '    ElseIf State = "ADD" Then
        '        'txtNomor.Text = ""
        '        txtketerangan.Text = ""
        '        dttgl_inv.DateTime = Now
        '        'dtAkhir.DateTime = DateAdd(DateInterval.Month, 1, Now)
        '        If Not ds2.Tables("mstKeg") Is Nothing Then ds2.Tables("mstKeg").Clear()
        '        If Not ds3.Tables("dtlKeg") Is Nothing Then ds3.Tables("dtlKeg").Clear()
        '    End If
        'End Try


        'MsgBox("Tersimpan...!")


    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            showMessages("Deleted..")
            'cancel_click()
        End If
    End Sub

    Public Sub cancel_click()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
    End Sub

    Private Sub GV_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        add_click()
        dttgl_inv.Focus()
    End Sub

    Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEdit.Click
        edit_click()
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        save_click()
    End Sub

    Private Sub btDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDel.Click
        delete_click()
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        cancel_click()
    End Sub
    Public Sub call_frmCari()
        frmCari.set_dso(ds4.Tables("Db_data4"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            txtkd_cust.Text = frmCari.row("Kode_Pegawai").ToString
            TxtNama.Text = frmCari.row("nama_pegawai").ToString
            'txbNoDocBOM.Text = frmCari.row("no_dokumen_BOM").ToString
            'txbJenisBOM.Text = frmCari.row("jenis_BOM").ToString
            'rtbKet.Text = frmCari.row("keterangan").ToString
            'cbStatus.Text = IIf(frmCari.row("Rec_Stat").ToString = "Y", "AKTIF", "NonAKTIF")
        End If

    End Sub
    Private Sub LOV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOV.Click
        call_frmCari()
    End Sub

    Private Sub txtkd_cust_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtkd_cust.KeyPress
        If txtkd_cust.Text = " " Then
            call_frmCari()
        End If

    End Sub
End Class