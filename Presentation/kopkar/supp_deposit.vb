Imports System.Data.SqlClient

Public Class supp_deposit

    Private STATE, kd_brg, kd_brg_old, notrans As String
    Private saldo_awal, jumlah, jumlah_old As Decimal
    Private DALOOKUP, DATrans As SqlDataAdapter
    Private DSLOOKUP As New DataSet
    Private Buildernya As New SqlClient.SqlCommandBuilder



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Public Sub simpan(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction
        Dim row As DataRow
        If Not isDelete Then
            If STATE = "ADD" Then
                notrans = frm_ritel3.get_notran()
                row = DSLOOKUP.Tables("_krd").NewRow
                row.Item("Last_Create_Date") = getTanggal()
                row.Item("Last_Created_By") = username
                row.Item("STATUS_AKTIF") = 1
            ElseIf STATE = "EDIT" Then
                row = DSLOOKUP.Tables("_krd").Rows(0)
                row.Item("Last_Update") = getTanggal()
                row.Item("Update_By") = username
            End If
            row.Item("status_lunas") = "LUNAS"

            row.Item("no_trans") = notrans
            row.Item("kd_kredit") = "U017"
            row.Item("jenis") = "DPST"
            row.Item("tgl_trans") = dt_tgl_trans.EditValue
            row.Item("nasabah_id") = "000000"
            row.Item("JML_PINJAMAN") = te_jumlah.EditValue
            row.Item("JML_POKOK") = te_jumlah.EditValue
            row.Item("stat_cair_approve") = 1
            row.Item("stat_approve") = 5
            row.Item("stat_cair") = 1
            row.Item("kabag_approve") = 0
            row.Item("LAMA_ANGS") = 1

            row.Item("kd_dep") = kddep
            row.Item("kd_brg") = le_supplier.EditValue
            row.Item("nama") = "DEPOSIT"
            row.Item("KETERANGAN") = "DEPOSIT " & le_supplier.Text

            row.Item("rp_awal") = te_saldo.EditValue
            row.Item("rp_trans") = te_jumlah.EditValue
            row.Item("rp_akhir") = te_saldo_akhir.EditValue
            row.Item("jenis_trans") = 2 '1:debet , 2:kredit
            If STATE = "ADD" Then
                DSLOOKUP.Tables("_krd").Rows.Add(row)
            End If
        End If
        Try
            Buildernya = New SqlClient.SqlCommandBuilder(DATrans)
            DATrans.UpdateCommand = Buildernya.GetUpdateCommand()
            DATrans.InsertCommand = Buildernya.GetInsertCommand()
            DATrans.DeleteCommand = Buildernya.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            DATrans.UpdateCommand.Transaction = BTRANS
            DATrans.InsertCommand.Transaction = BTRANS
            DATrans.DeleteCommand.Transaction = BTRANS
            DATrans.Update(DSLOOKUP.Tables("_krd"))
            DSLOOKUP.Tables("_krd").AcceptChanges()

            BTRANS.Commit()

            Dim sqlCmd As New SqlCommand
            sqlCmd.Connection = sqlconn
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.CommandText = "dbo.UPDATE_SUPPLIER"

            sqlCmd.Parameters.Add("@notrans", SqlDbType.Char).Value = notrans
            sqlCmd.Parameters.Add("@state", SqlDbType.Char).Value = STATE
            sqlCmd.Parameters.Add("@rp_trans_old", SqlDbType.Decimal).Value = jumlah_old
            sqlCmd.Parameters.Add("@kd_brg_old", SqlDbType.Char).Value = kd_brg_old
            sqlCmd.ExecuteNonQuery()

            showMessages("Berhasil disimpan")
            'btnSave = False
            'setStatus()
            STATE = "EDIT"
            jumlah_old = te_jumlah.EditValue
            kd_brg_old = le_supplier.EditValue
            'LoadStruktur(no_trn)
            'cari_brg()
        Catch e As Exception
            BTRANS.Rollback()
            DSLOOKUP.Tables("_krd").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try


    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Dim sqlCmd As New SqlCommand
        'sqlCmd.Connection = sqlconn
        'sqlCmd.CommandType = CommandType.StoredProcedure
        'sqlCmd.CommandText = "dbo.SUPPLIER_TOPUP"

        'sqlCmd.Parameters.Add("@tgl_trans", SqlDbType.Date).Value = dt_tgl_trans.EditValue
        'sqlCmd.Parameters.Add("@kd_brg", SqlDbType.Char).Value = le_supplier.EditValue
        'sqlCmd.Parameters.Add("@jumlah", SqlDbType.Decimal).Value = te_jumlah.EditValue
        'sqlCmd.Parameters.Add("@state", SqlDbType.Char).Value = STATE
        'sqlCmd.Parameters.Add("@jumlah_old", SqlDbType.Decimal).Value = jumlah_old
        'sqlCmd.Parameters.Add("@kd_brg_old", SqlDbType.Char).Value = kd_brg_old
        'sqlCmd.ExecuteNonQuery()
        'showMessages("Berhasil disimpan")
        ''bersihkan()
        'STATE = "EDIT"
        'lb_state.Text = "Mode: " & STATE
        'jumlah_old = te_jumlah.EditValue
        'kd_brg_old = le_supplier.EditValue
        simpan()
        loadgrid()
    End Sub
    Private Sub loadgrid()
        If Not DSLOOKUP.Tables("_hist") Is Nothing Then DSLOOKUP.Tables("_hist").Clear()
        DALOOKUP = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT * from retail where kd_brg= '" & le_supplier.EditValue & "' AND kd_kredit='U017' AND jenis='DPST' ORDER BY tgl_trans DESC, last_create_date DESC", sqlconn))
        DALOOKUP.Fill(DSLOOKUP, "_hist")
        GCTopup.DataSource = DSLOOKUP.Tables("_hist")
        GVTopup.ViewCaption = "Histori Top Up Deposit " & le_supplier.Text
    End Sub

    Private Sub cari()
        Dim sqlsupp As SqlDataReader
        sqlsupp = New SqlCommand("SELECT * FROM m_barang WHERE kd_brg='" & le_supplier.EditValue & "'", sqlconn).ExecuteReader
        sqlsupp.Read()
        te_saldo.EditValue = sqlsupp.Item("rp_akhir")
        sqlsupp.Close()
        loadgrid()


    End Sub
    Private Sub bersihkan()
        dt_tgl_trans.EditValue = DateTime.Now
        te_jumlah.EditValue = 0
        hitung()
    End Sub
    Private Sub baru()
        STATE = "ADD"
        lb_state.Text = "Mode: " & STATE
        dt_tgl_trans.EditValue = DateTime.Now
        le_supplier.EditValue = "00000001"
        te_jumlah.EditValue = 0
        jumlah_old = 0
        kd_brg_old = ""
        te_jumlah.Focus()
        hitung()
    End Sub
    Private Sub supp_topup_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not DSLOOKUP.Tables("_supp") Is Nothing Then DSLOOKUP.Tables("_supp").Clear()
        DALOOKUP = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_brg,nama from m_barang", sqlconn))
        DALOOKUP.Fill(DSLOOKUP, "_supp")
        le_supplier.Properties.DataSource = DSLOOKUP.Tables("_supp")
        le_supplier.Properties.ValueMember = "kd_brg"
        le_supplier.Properties.DisplayMember = "nama"
        'le_supplier.EditValue = "00000001"

        If Not DSLOOKUP.Tables("_krd") Is Nothing Then DSLOOKUP.Tables("_krd").Clear()
        DATrans = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from retail where no_trans='xxx'", sqlconn))
        DATrans.Fill(DSLOOKUP, "_krd")

        baru()
        cari()
        te_jumlah.EditValue = 0
        hitung()
    End Sub

    Private Sub le_supplier_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles le_supplier.EditValueChanged
        cari()
        te_jumlah.EditValue = 0
        hitung()
    End Sub

    Private Sub te_jumlah_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles te_jumlah.EditValueChanged
        hitung()
    End Sub

    Private Sub GVTopup_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GVTopup.DoubleClick
        notrans = GVTopup.GetRow(GVTopup.GetSelectedRows(0)).Item("no_trans").ToString()
        If Not DSLOOKUP.Tables("_krd") Is Nothing Then DSLOOKUP.Tables("_krd").Clear()
        DATrans = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from retail where no_trans='" & notrans & "'", sqlconn))
        DATrans.Fill(DSLOOKUP, "_krd")


        Dim tgl As DateTime = GVTopup.GetRow(GVTopup.GetSelectedRows(0)).Item("tgl_trans").ToString()
        dt_tgl_trans.EditValue = tgl
        saldo_awal = GVTopup.GetRow(GVTopup.GetSelectedRows(0)).Item("rp_awal").ToString()
        jumlah = GVTopup.GetRow(GVTopup.GetSelectedRows(0)).Item("JML_PINJAMAN").ToString()
        te_saldo.EditValue = saldo_awal
        te_jumlah.EditValue = jumlah
        STATE = "EDIT"
        lb_state.Text = "Mode: " & STATE
        jumlah_old = te_jumlah.EditValue
        kd_brg_old = le_supplier.EditValue
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        baru()
    End Sub
    Private Sub hitung()
        te_saldo_akhir.EditValue = te_saldo.EditValue + te_jumlah.EditValue
    End Sub
End Class