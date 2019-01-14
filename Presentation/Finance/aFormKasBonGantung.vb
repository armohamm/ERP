'tgl 19/06/2015
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Data.SqlClient

Public Class aFormKasBonGantung
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = True
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = True
    Public prn As frmMain
    Public obj As Object
    Public STATE As String
    Dim row As DataRow

    Dim dsLookUp, dsKasBon As New DataSet
    Dim daLookUp, daKasBon As SqlDataAdapter
    Dim drKasBon As SqlDataReader
    Dim myBuilder As New SqlCommandBuilder
    Dim BTRANS As SqlTransaction
    Dim isOK As Boolean
    Dim no As Integer

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btnCetak
        End With
    End Sub

    Sub bersih()
        dtTanggal.EditValue = getTanggal()
        lckKartu.EditValue = vbNullString
        lckRealisasi.EditValue = vbNullString
        txtKeterangan.EditValue = vbNullString
        txtJumlah.EditValue = 0
        txtSisa.EditValue = 0
    End Sub

    Private Sub loadKartu()
        If Not dsLookUp.Tables("Kartu") Is Nothing Then dsLookUp.Tables("Kartu").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("select a.stat, a.nama, a.kode from (select CASE WHEN SUBSTRING(kode_pegawai,1,1) = 'P' THEN 'Pegawai' ELSE 'Supir' END stat, nama_pegawai nama, kode_pegawai kode from sif.dbo.SIF_Pegawai where not Kode_Pegawai in (select Kd_pegawai from sif.dbo.SIF_sopir) AND Rec_stat = 'Y' union all select CASE WHEN SUBSTRING(kode_sopir,1,1) = 'P' THEN 'Pegawai' ELSE 'Supir' END stat, nama_sopir nama, kode_sopir kode from sif.dbo.SIF_sopir where Rec_stat = 'Y') a order by a.nama", sqlconn))
        daLookUp.Fill(dsLookUp, "Kartu")
        lckKartu.Properties.DataSource = dsLookUp.Tables("Kartu")
        lckKartu.Properties.DisplayMember = "nama"
        lckKartu.Properties.ValueMember = "kode"
        GridLookUpEdit1View.Columns("kode").Visible = False
        lookKartu.Properties.DataSource = dsLookUp.Tables("Kartu")
        lookKartu.Properties.DisplayMember = "nama"
        lookKartu.Properties.ValueMember = "kode"
    End Sub

    Private Sub loadRealisasi()
        If Not dsLookUp.Tables("Realisasi") Is Nothing Then dsLookUp.Tables("Realisasi").Clear()

        If STATE = "ADD" Then
            daLookUp = New SqlDataAdapter(New SqlCommand("SELECT a.nomor, a.tgl_trans, a.prev_nomor, a.sisa_hutang, a.keterangan, 'TILANGAN' stat FROM FIN.dbo.FIN_KAS_BON_TILANG a WHERE a.sisa_hutang > 0 AND a.kd_kartu = '" & lckKartu.EditValue & "' AND a.nomor IN (SELECT MAX(nomor) FROM FIN.dbo.FIN_KAS_BON_TILANG WHERE prev_nomor = a.prev_nomor) UNION ALL SELECT IDENT_CURRENT('FIN.dbo.FIN_KAS_BON_TILANG') + 1 AS nomor, x.tgl_trans, x.nomor as prev_nomor, x.jml_trans, x.keterangan, 'KAS BON' stat FROM FIN.dbo.FIN_KAS_BON x WHERE x.kd_kartu = '" & lckKartu.EditValue & "' AND x.jml_bayar = 0 AND x.no_jur IN (SELECT no_jur FROM FIN.dbo.FIN_JURNAL WHERE no_jur = x.no_jur AND NOT (no_posting IS NULL OR no_posting = ''))", sqlconn))
        Else
            daLookUp = New SqlDataAdapter(New SqlCommand("SELECT a.nomor, a.tgl_trans, a.prev_nomor, a.sisa_hutang, a.keterangan, 'TILANGAN' stat FROM FIN.dbo.FIN_KAS_BON_TILANG a WHERE a.kd_kartu = '" & lckKartu.EditValue & "' AND a.nomor IN (SELECT MAX(nomor) FROM FIN.dbo.FIN_KAS_BON_TILANG WHERE prev_nomor = a.prev_nomor) UNION ALL SELECT IDENT_CURRENT('dbo.FIN_KAS_BON_TILANG') AS nomor, x.tgl_trans, x.nomor as prev_nomor, x.jml_trans, x.keterangan, 'KAS BON' stat FROM FIN.dbo.FIN_KAS_BON x WHERE x.kd_kartu = '" & lckKartu.EditValue & "' AND x.no_jur IN (SELECT no_jur FROM FIN.dbo.FIN_JURNAL WHERE no_jur = x.no_jur AND NOT (no_posting IS NULL OR no_posting = ''))", sqlconn))
        End If

        daLookUp.Fill(dsLookUp, "Realisasi")
        lckRealisasi.Properties.DataSource = dsLookUp.Tables("Realisasi")
        lckRealisasi.Properties.DisplayMember = "prev_nomor"
        lckRealisasi.Properties.ValueMember = "prev_nomor"
    End Sub

    Private Sub loadData(ByVal nomor As Integer, ByVal tanggal As String, ByVal inv As String)
        If Not dsKasBon.Tables("KasBonGantung") Is Nothing Then dsKasBon.Tables("KasBonGantung").Clear()

        daKasBon = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_KAS_BON_TILANG WHERE nomor = " & nomor & "AND tgl_trans = CONVERT(DATE, '" & tanggal & "', 103) AND prev_nomor = '" & inv & "'", sqlconn))
        daKasBon.Fill(dsKasBon, "KasBonGantung")
    End Sub

    Private Sub loadGrid()
        If Not dsKasBon.Tables("VKasBonGantung") Is Nothing Then dsKasBon.Tables("VKasBonGantung").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_KAS_BON_TILANG ORDER BY kd_kartu", sqlconn))
        daLookUp.Fill(dsKasBon, "VKasBonGantung")
        gcKasBon.DataSource = dsKasBon.Tables("VKasBonGantung")
        gvKasBon.BestFitColumns()
    End Sub

    Private Sub controlOff(ByVal stat As Boolean)
        dtTanggal.Properties.ReadOnly = stat
        lckKartu.Properties.ReadOnly = stat
        lckRealisasi.Properties.ReadOnly = stat
        txtKeterangan.Properties.ReadOnly = stat
        txtJumlah.Properties.ReadOnly = stat
        gvKasBon.OptionsBehavior.ReadOnly = stat
    End Sub

    Public Sub cancel_click()
        bersih()
        btnSave = True
        btnDelete = False
        btnadd = False
        btnEdit = False
        btnCancel = True
        setStatus()
    End Sub

    Public Sub delete_click()
        If MsgBox("Apakah anda ingin menghapus ?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            save_click(True)
            cancel_click()
        End If
    End Sub

    Public Sub call_procedure(ByVal nomor As Integer, ByVal noInvoice As String, ByVal tanggal As Date, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_MAKEJUR_KAS_BON_LAIN"

        sqlCmd.Parameters.Add("@no_inv", SqlDbType.Char).Value = noInvoice
        sqlCmd.Parameters.Add("@tanggal", SqlDbType.Date).Value = tanggal
        sqlCmd.Parameters.Add("@nomor", SqlDbType.Int).Value = nomor
        sqlCmd.ExecuteNonQuery()
    End Sub

    Private Sub refreshNomer()
        Dim x As Object
        Dim i As Int16
        x = CType(gcKasBon.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
        For i = 0 To gcKasBon.FocusedView.RowCount - 1
            gcKasBon.FocusedView.GetRow(i).Item("no_seq") = i + 1
        Next
    End Sub

    Private Sub cek()
        If dtTanggal.EditValue = vbNullString Then
            isOK = False
            DxErrorProvider1.SetError(dtTanggal, "Isi tanggal terlebih.")
            If lckKartu.EditValue = vbNullString Then
                DxErrorProvider1.SetError(lckKartu, "Pilih kartu.")
            Else
                DxErrorProvider1.SetError(lckKartu, "")
            End If
            If lckRealisasi.EditValue = vbNullString Then
                DxErrorProvider1.SetError(lckRealisasi, "Pilih nomor realisasi.")
            Else
                DxErrorProvider1.SetError(lckRealisasi, "")
            End If
            If txtJumlah.EditValue = vbNullString Or txtJumlah.EditValue = 0 Then
                DxErrorProvider1.SetError(txtJumlah, "Jumlah tidak boleh kosong atau 0.")
            Else
                DxErrorProvider1.SetError(txtJumlah, "")
            End If
            If txtJumlah.EditValue > txtSisa.EditValue Then
                DxErrorProvider1.SetError(txtJumlah, "Jumlah lebih besar dari sisa kas bon.")
            Else
                DxErrorProvider1.SetError(txtJumlah, "")
            End If
        ElseIf lckKartu.EditValue = vbNullString Then
            isOK = False
            DxErrorProvider1.SetError(lckKartu, "Pilih kartu.")
            If dtTanggal.EditValue = vbNullString Then
                DxErrorProvider1.SetError(dtTanggal, "Isi tanggal terlebih.")
            Else
                DxErrorProvider1.SetError(dtTanggal, "")
            End If
            If lckRealisasi.EditValue = vbNullString Then
                DxErrorProvider1.SetError(lckRealisasi, "Pilih nomor realisasi.")
            Else
                DxErrorProvider1.SetError(lckRealisasi, "")
            End If
            If txtJumlah.EditValue = vbNullString Or txtJumlah.EditValue = 0 Then
                DxErrorProvider1.SetError(txtJumlah, "Jumlah tidak boleh kosong atau 0.")
            Else
                DxErrorProvider1.SetError(txtJumlah, "")
            End If
            If txtJumlah.EditValue > txtSisa.EditValue Then
                DxErrorProvider1.SetError(txtJumlah, "Jumlah lebih besar dari sisa kas bon.")
            Else
                DxErrorProvider1.SetError(txtJumlah, "")
            End If
        ElseIf lckRealisasi.EditValue = vbNullString Then
            isOK = False
            DxErrorProvider1.SetError(dtTanggal, "Pilih nomor realisasi.")
            If dtTanggal.EditValue = vbNullString Then
                DxErrorProvider1.SetError(dtTanggal, "Isi tanggal terlebih.")
            Else
                DxErrorProvider1.SetError(dtTanggal, "")
            End If
            If lckKartu.EditValue = vbNullString Then
                DxErrorProvider1.SetError(lckKartu, "Pilih kartu.")
            Else
                DxErrorProvider1.SetError(lckKartu, "")
            End If
            If txtJumlah.EditValue = vbNullString Or txtJumlah.EditValue = 0 Then
                DxErrorProvider1.SetError(txtJumlah, "Jumlah tidak boleh kosong atau 0.")
            Else
                DxErrorProvider1.SetError(txtJumlah, "")
            End If
            If txtJumlah.EditValue > txtSisa.EditValue Then
                DxErrorProvider1.SetError(txtJumlah, "Jumlah lebih besar dari sisa kas bon.")
            Else
                DxErrorProvider1.SetError(txtJumlah, "")
            End If
        ElseIf txtJumlah.EditValue = vbNullString Or txtJumlah.EditValue = 0 Then
            isOK = False
            DxErrorProvider1.SetError(dtTanggal, "Jumlah tidak boleh kosong atau 0.")
            If dtTanggal.EditValue = vbNullString Then
                DxErrorProvider1.SetError(dtTanggal, "Isi tanggal terlebih.")
            Else
                DxErrorProvider1.SetError(dtTanggal, "")
            End If
            If lckKartu.EditValue = vbNullString Then
                DxErrorProvider1.SetError(lckKartu, "Pilih kartu.")
            Else
                DxErrorProvider1.SetError(lckKartu, "")
            End If
            If lckRealisasi.EditValue = vbNullString Then
                DxErrorProvider1.SetError(lckRealisasi, "Pilih nomor realisasi.")
            Else
                DxErrorProvider1.SetError(lckRealisasi, "")
            End If
            If txtJumlah.EditValue > txtSisa.EditValue Then
                DxErrorProvider1.SetError(txtJumlah, "Jumlah lebih besar dari sisa kas bon.")
            Else
                If Not isOK = False Then
                    DxErrorProvider1.SetError(txtJumlah, "")
                End If
            End If
        ElseIf txtJumlah.EditValue > txtSisa.EditValue Then
            isOK = False
            DxErrorProvider1.SetError(txtJumlah, "Jumlah lebih besar dari sisa kas bon.")
            If dtTanggal.EditValue = vbNullString Then
                DxErrorProvider1.SetError(dtTanggal, "Isi tanggal terlebih.")
            Else
                DxErrorProvider1.SetError(dtTanggal, "")
            End If
            If lckKartu.EditValue = vbNullString Then
                DxErrorProvider1.SetError(lckKartu, "Pilih kartu.")
            Else
                DxErrorProvider1.SetError(lckKartu, "")
            End If
            If lckRealisasi.EditValue = vbNullString Then
                DxErrorProvider1.SetError(lckRealisasi, "Pilih nomor realisasi.")
            Else
                DxErrorProvider1.SetError(lckRealisasi, "")
            End If
            If txtJumlah.EditValue = vbNullString Or txtJumlah.EditValue = 0 Then
                DxErrorProvider1.SetError(txtJumlah, "Jumlah tidak boleh kosong atau 0.")
            Else
                If Not isOK = False Then
                    DxErrorProvider1.SetError(txtJumlah, "")
                End If
            End If
        Else
            isOK = True
            'DxErrorProvider1.SetError(dtTanggal, "")
            'DxErrorProvider1.SetError(lckKartu, "")
            'DxErrorProvider1.SetError(lckRealisasi, "")
            'DxErrorProvider1.SetError(txtJumlah, "")
            DxErrorProvider1.ClearErrors()
        End If
    End Sub

    Public Sub save_click(Optional ByVal isDelete As Boolean = False)
        If Not isDelete Then
            cek()

            Dim dr As SqlDataReader = New SqlCommand("SELECT IDENT_CURRENT('FIN.dbo.FIN_KAS_BON_TILANG') + 1", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                no = dr.Item(0)
            End If
            dr.Close()

            If isOK Then
                If STATE = "ADD" Then
                    row = dsKasBon.Tables("KasBonGantung").NewRow
                    row.Item("kd_cabang") = getKodeCabang()
                    row.Item("tipe_trans") = "JKK-KBB-10"
                    row.Item("Last_Create_Date") = Now
                    row.Item("Last_Created_By") = username
                    row.Item("Program_Name") = Me.Name
                    row.Item("kd_buku_besar") = "1011003"
                ElseIf STATE = "EDIT" Then
                    row = dsKasBon.Tables("KasBonGantung").Rows(0)
                    row.Item("Last_Update_Date") = Now
                    row.Item("Last_Updated_By") = username
                    row.Item("Program_Name") = Me.Name
                End If

                row.Item("tgl_trans") = dtTanggal.EditValue
                row.Item("prev_nomor") = lckRealisasi.EditValue
                row.Item("kd_kartu") = lckKartu.EditValue
                row.Item("jml_trans") = txtSisa.EditValue
                row.Item("jml_bayar") = txtJumlah.EditValue
                'row.Item("sisa_hutang") = txtSisa.EditValue - txtJumlah.EditValue
                row.Item("keterangan") = txtKeterangan.EditValue

                If STATE = "ADD" Then
                    dsKasBon.Tables("KasBonGantung").Rows.Add(row)
                End If
            Else
                MsgBox("Cek data input.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR!")
                Exit Sub
            End If
        Else
            For Each rw As DataRow In dsKasBon.Tables("KasBonGantung").Rows
                Dim sqlx As New SqlCommand("delete from fin.dbo.fin_jurnal where no_jur='" & rw.Item("no_jur") & "'", sqlconn, BTRANS)
                sqlx.ExecuteNonQuery()
                Dim sqly As New SqlCommand("delete from fin.dbo.fin_jurnal_d where no_jur='" & rw.Item("no_jur") & "'", sqlconn, BTRANS)
                sqly.ExecuteNonQuery()
                rw.Delete()
            Next
        End If

        myBuilder = New SqlCommandBuilder(daKasBon)
        daKasBon.UpdateCommand = myBuilder.GetUpdateCommand()
        daKasBon.InsertCommand = myBuilder.GetInsertCommand()
        daKasBon.DeleteCommand = myBuilder.GetDeleteCommand()

        BTRANS = sqlconn.BeginTransaction("1")
        daKasBon.UpdateCommand.Transaction = BTRANS
        daKasBon.InsertCommand.Transaction = BTRANS
        daKasBon.DeleteCommand.Transaction = BTRANS

        daKasBon.Update(dsKasBon.Tables("KasBonGantung"))

        If Not isDelete Then
            call_procedure(no, lckRealisasi.EditValue, dtTanggal.EditValue, BTRANS)
        End If

        Try
            BTRANS.Commit()

            If Not isDelete Then
                showMessages("Data Berhasil Disimpan.")
            Else
                showMessages("Data Berhasil Dihapus.")
            End If
            bersih()
            loadData(99, "01/01/2014", "XXX")
            loadGrid()
            STATE = "ADD"
        Catch ex As Exception
            BTRANS.Rollback()
            dsKasBon.Tables("KasBonGantung").RejectChanges()
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub aFormKasBonGantung_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        STATE = "ADD"
        loadKartu()
        loadRealisasi()
        loadData(99, "01/01/2014", "XXX")
        loadGrid()
        bersih()
        controlOff(False)
        dtTanggal.EditValue = getTanggal()
        dtTanggal.Properties.MaxValue = getTanggal()
    End Sub

    Private Sub lckKartu_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lckKartu.EditValueChanged
        loadRealisasi()
    End Sub

    Private Sub lckKartu_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lckKartu.QueryPopUp
        loadKartu()
    End Sub

    Private Sub lckRealisasi_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lckRealisasi.EditValueChanged
        If Not lckRealisasi.EditValue = vbNullString Then
            txtSisa.EditValue = dsLookUp.Tables("Realisasi").Select("prev_nomor='" & lckRealisasi.EditValue & "'")(0).Item("sisa_hutang")
            'no = dsLookUp.Tables("Realisasi").Select("prev_nomor='" & lckRealisasi.EditValue & "'")(0).Item("nomor")
        End If
        If InStr(lckRealisasi.EditValue, "BN") > 0 Then
            txtJumlah.EditValue = txtSisa.EditValue
        End If
    End Sub

    Private Sub gvKasBon_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles gvKasBon.DoubleClick
        STATE = "EDIT"
        controlOff(False)
        Dim jumlah As Integer = 0

        loadData(gvKasBon.GetRow(gvKasBon.GetSelectedRows(0)).item("nomor"), gvKasBon.GetRow(gvKasBon.GetSelectedRows(0)).item("tgl_trans"), gvKasBon.GetRow(gvKasBon.GetSelectedRows(0)).item("prev_nomor"))

        dtTanggal.EditValue = dsKasBon.Tables("KasBonGantung").Rows(0).Item("tgl_trans")
        lckKartu.EditValue = dsKasBon.Tables("KasBonGantung").Rows(0).Item("kd_kartu")
        lckRealisasi.EditValue = dsKasBon.Tables("KasBonGantung").Rows(0).Item("prev_nomor")
        txtSisa.EditValue = dsKasBon.Tables("KasBonGantung").Rows(0).Item("jml_trans")
        txtKeterangan.EditValue = dsKasBon.Tables("KasBonGantung").Rows(0).Item("keterangan")
        txtJumlah.EditValue = dsKasBon.Tables("KasBonGantung").Rows(0).Item("jml_bayar")

        Dim dr As SqlDataReader = New SqlCommand("select COUNT(no_jur) from FIN.dbo.FIN_JURNAL where no_jur= '" & dsKasBon.Tables("KasBonGantung").Rows(0).Item("no_jur") & "' AND NOT (no_posting IS NULL AND no_posting = '')", sqlconn).ExecuteReader
        dr.Read()
        If dr.HasRows Then
            jumlah = dr.Item(0)
        End If
        dr.Close()

        If jumlah > 0 Then
            MsgBox("Realisasi ini sudah terjurnal. Tidak dapat diubah", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "INFORMASI!")
            btnSave = False
            btnDelete = False
            btnadd = False
            btnEdit = False
            setStatus()
            controlOff(True)
            'bersih()
        Else
            btnSave = True
            btnDelete = True
            btnadd = False
            btnEdit = False
            setStatus()
            controlOff(False)
        End If
    End Sub

    Private Sub lckRealisasi_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lckRealisasi.QueryPopUp
        loadRealisasi()
    End Sub
End Class