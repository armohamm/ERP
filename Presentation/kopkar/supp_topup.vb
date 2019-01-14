Imports System.Data.SqlClient

Public Class supp_topup

    Private STATE, kd_brg, kd_brg_old As String
    Private saldo_awal, jumlah, jumlah_old As Decimal
    Private DALOOKUP As SqlDataAdapter
    Private DSLOOKUP As New DataSet



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "dbo.SUPPLIER_TOPUP"

        sqlCmd.Parameters.Add("@tgl_trans", SqlDbType.Date).Value = dt_tgl_trans.EditValue
        sqlCmd.Parameters.Add("@kd_brg", SqlDbType.Char).Value = le_supplier.EditValue
        sqlCmd.Parameters.Add("@jumlah", SqlDbType.Decimal).Value = te_jumlah.EditValue
        sqlCmd.Parameters.Add("@state", SqlDbType.Char).Value = STATE
        sqlCmd.Parameters.Add("@jumlah_old", SqlDbType.Decimal).Value = jumlah_old
        sqlCmd.Parameters.Add("@kd_brg_old", SqlDbType.Char).Value = kd_brg_old
        sqlCmd.ExecuteNonQuery()
        showMessages("Berhasil disimpan")
        'bersihkan()
        STATE = "EDIT"
        lb_state.Text = "Mode: " & STATE
        jumlah_old = te_jumlah.EditValue
        kd_brg_old = le_supplier.EditValue
        loadgrid()
    End Sub
    Private Sub loadgrid()
        If Not DSLOOKUP.Tables("_hist") Is Nothing Then DSLOOKUP.Tables("_hist").Clear()
        DALOOKUP = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT * from retail_supplier where kd_brg= '" & le_supplier.EditValue & "' ORDER BY tgl_trans DESC", sqlconn))
        DALOOKUP.Fill(DSLOOKUP, "_hist")
        GCTopup.DataSource = DSLOOKUP.Tables("_hist")
        GVTopup.ViewCaption = "Histori Top Up " & le_supplier.Text
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
        Dim tgl As DateTime = GVTopup.GetRow(GVTopup.GetSelectedRows(0)).Item("tgl_trans").ToString()
        dt_tgl_trans.EditValue = tgl
        saldo_awal = GVTopup.GetRow(GVTopup.GetSelectedRows(0)).Item("awal").ToString()
        jumlah = GVTopup.GetRow(GVTopup.GetSelectedRows(0)).Item("jumlah").ToString()
        te_saldo.EditValue = saldo_awal
        te_jumlah.EditValue = jumlah
        STATE = "EDIT"
        lb_state.Text = "Mode: " & STATE
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        baru()
    End Sub
    Private Sub hitung()
        te_saldo_akhir.EditValue = te_saldo.EditValue + te_jumlah.EditValue
    End Sub
End Class