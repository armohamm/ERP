'|-----------------------
'|  CREATED BY RENDY    |
'|  EDITED BY RENDY     |
'|-----------------------
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient
Public Class frmBebanBiayaDmuka

    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Public obj As Object

    Public STATE As String
    Dim row, rowD As DataRow

    Dim dsJurnal, dsCari, dsAktiva, dsLOV, dsAktivaTemp As New DataSet
    Dim daAktiva, daLOVBbiaya, daLOVBpusat, daAktivaD As SqlDataAdapter

    Dim rl, r2 As DataRelation
    Dim myBuilder, myBuilderD As New SqlCommandBuilder
    Dim BTRANS As SqlTransaction
    Dim dr As SqlDataReader
    Dim param, ParamGenKode As String
    Dim SeqGenKode As Integer
    Dim Bulan As Integer

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Public Sub Cancel_click()
        'If MsgBox("Perubahan Data akan disimpan dalam Database ??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then save_click()
        MsgBox("Silahkan masukkan data baru")

        STATE = "ADD"
        lblState.Text = "ADD STATE"
        GenKode()
        txtNomor.Text = ParamGenKode

        bersih()
    End Sub

    Public Sub add_click()
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
        STATE = "ADD"
        GenKode()
        txtNomor.EditValue = ParamGenKode
        lblState.Text = "ADD STATE"
    End Sub

    Private Sub frmBebanBiayaDmuka_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)

        GenLOV()
        setPrimaryKey()
        loadTemp()

        tglBerlaku.EditValue = getTanggal()
        tglBerakhir.EditValue = getTanggal()

        Try
            LOVbukuPusat.ItemIndex = 0
            LOVrekBiaya.ItemIndex = 0
            LOVstatus.EditValue = "AKTIVE"
        Catch ex As Exception
            MsgBox(ex.Message & " , " & "Ada masalah dalam mengisi List Of View")
        End Try
    End Sub

    Sub loadTemp()
        lblError.Text = "..."
        Try

            dsAktiva.Relations.Clear()
            If Not dsAktiva.Tables("TempD") Is Nothing Then dsAktiva.Tables("TempD").Clear()
            If Not dsAktiva.Tables("Temp") Is Nothing Then dsAktiva.Tables("Temp").Clear()

            daAktiva = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_MST_BIAYA_DIMUKA ", sqlconn))
            daAktiva.Fill(dsAktiva, "Temp")

            daAktivaD = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_MST_BIAYA_DIMUKA_D ", sqlconn))
            daAktivaD.Fill(dsAktiva, "TempD")

            rl = dsAktiva.Relations.Add("BiayaDimuka", dsAktiva.Tables("Temp").Columns("no_trans"), dsAktiva.Tables("TempD").Columns("no_trans"))

            GC.DataSource = dsAktiva.Tables("Temp")
            GC.LevelTree.Nodes.Add("BiayaDimuka", GV2)
            GV.BestFitColumns()
            GV2.BestFitColumns()

            'Dim colM(0) As DataColumn
            'colM(0) = dsAktiva.Tables("Temp").Columns("no_trans")

            'Dim colD(0) As DataColumn
            'colD(0) = dsAktiva.Tables("TempD").Columns("no_trans")

            'rl = dsAktiva.Relations.Add("BiayaDimuka", colM, colD)
            'GC.DataSource = dsAktiva.Tables("Temp")
            'GV.BestFitColumns()

        Catch ex As Exception
            lblError.Text = ex.Message
        End Try
    End Sub

    Sub GenLOV()

        dsLOV.Clear()

        daLOVBbiaya = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_buku_besar ", sqlconn))
        daLOVBbiaya.Fill(dsLOV, "biaya")

        LOVrekBiaya.Properties.DataSource = dsLOV.Tables("biaya")
        LOVrekBiaya.Properties.DisplayMember = "nm_buku_besar"
        LOVrekBiaya.Properties.ValueMember = "kd_buku_besar"

        LOVrekening.Properties.DataSource = dsLOV.Tables("biaya")
        LOVrekening.Properties.DisplayMember = "nm_buku_besar"
        LOVrekening.Properties.ValueMember = "kd_buku_besar"


        daLOVBpusat = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_buku_pusat ", sqlconn))
        daLOVBpusat.Fill(dsLOV, "pusat")

        LOVbukuPusat.Properties.DataSource = dsLOV.Tables("pusat")
        LOVbukuPusat.Properties.DisplayMember = "nm_buku_pusat"
        LOVbukuPusat.Properties.ValueMember = "kd_buku_pusat"

        RepLOVbukuPusat.DataSource = dsLOV.Tables("pusat")
        RepLOVbukuPusat.Properties.DisplayMember = "nm_buku_pusat"
        RepLOVbukuPusat.Properties.ValueMember = "kd_buku_pusat"

        RepBukuPusat.DataSource = dsLOV.Tables("pusat")
        RepBukuPusat.Properties.DisplayMember = "nm_buku_pusat"
        RepBukuPusat.Properties.ValueMember = "kd_buku_pusat"
    End Sub

    Sub setPrimaryKey(Optional ByVal no_trans As String = "*")
        If Not dsAktiva.Tables("Aktiva") Is Nothing Then dsAktiva.Tables("Aktiva").Clear()

        daAktiva = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_MST_BIAYA_DIMUKA where no_trans = '" & no_trans & "' ", sqlconn))
        daAktiva.Fill(dsAktiva, "Aktiva")

        '-----------------------------------------------------------

        If Not dsAktiva.Tables("AktivaD") Is Nothing Then dsAktiva.Tables("AktivaD").Clear()

        daAktivaD = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_MST_BIAYA_DIMUKA_D where no_trans = '" & no_trans & "' ", sqlconn))
        daAktivaD.Fill(dsAktiva, "AktivaD")

        GCDet.DataSource = dsAktiva.Tables("AktivaD")
    End Sub

    Sub GenKode()
        Try
            Dim dr2 As SqlDataReader = New SqlCommand("select COUNT(no_trans) from FIN.dbo.FIN_MST_BIAYA_DIMUKA ", sqlconn).ExecuteReader
            dr2.Read()
            If dr2.HasRows Then
                If dr2.Item(0) < 10 Then
                    ParamGenKode = ("0000" & (dr2.Item(0) + 1))
                ElseIf dr2.Item(0) > 9 Then
                    ParamGenKode = ("000" & (dr2.Item(0) + 1))
                ElseIf dr2.Item(0) > 99 Then
                    ParamGenKode = ("00" & (dr2.Item(0) + 1))
                ElseIf dr2.Item(0) > 999 Then
                    ParamGenKode = ("0" & (dr2.Item(0) + 1))
                ElseIf dr2.Item(0) > 9999 Then
                    ParamGenKode = (dr2.Item(0) + 1)
                End If

            End If

            dr2.Close()
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try

    End Sub

    Private Function GenKodeSeq() As Integer
        Try
            Dim dr2 As SqlDataReader = New SqlCommand("select COUNT(no_trans) from FIN.dbo.FIN_MST_BIAYA_DIMUKA_D ", sqlconn).ExecuteReader
            dr2.Read()
            If dr2.HasRows Then
                SeqGenKode = CInt(dr2.Item(0) + 1)
            End If

            dr2.Close()
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try
        Return SeqGenKode
    End Function

    Private Sub GV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV.DoubleClick


        'row = dsAktiva.Tables("Temp").Rows(GV.GetSelectedRows(0))

        setPrimaryKey(GV.GetRow(GV.GetSelectedRows(0)).item("no_trans"))

        txtKdCabang.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("Kd_cabang")
        txtNama.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("nama_biaya")
        tglBerlaku.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("tgl_awal")
        tglBerakhir.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("tgl_akhir")
        txtNilaiTotal.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("nilai_total")
        txtNilaiPembeban.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("nilai_pembebanan")
        txtKeterangan.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("keterangan")
        LOVrekBiaya.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("rek_biaya")
        LOVbukuPusat.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("rek_pusat_biaya")
        LOVstatus.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("status")

        STATE = "EDIT"
        lblState.Text = "EDIT STATE"
        MsgBox("Anda akan melakukan edit : " & GV.GetRow(GV.GetSelectedRows(0)).item("no_trans") & " Nama Biaya : " & GV.GetRow(GV.GetSelectedRows(0)).item("nama_biaya") & _
               " ,Nilai Total : " & GV.GetRow(GV.GetSelectedRows(0)).item("nilai_total"))

    End Sub

    Public Sub save_click()
        Try

            If STATE = "ADD" Then

                GenKode()
                GenKodeSeq()

                txtNomor.EditValue = ParamGenKode

                row = dsAktiva.Tables("Aktiva").NewRow
                rowD = dsAktiva.Tables("AktivaD").NewRow

                txtKdCabang.EditValue = getKodeCabang()

                row.Item("Kd_cabang") = getKodeCabang()
                row.Item("no_trans") = txtNomor.EditValue
                row.Item("tipe_trans") = "JKK-KBB-06"

                row.Item("nama_biaya") = txtNama.EditValue
                row.Item("tgl_awal") = tglBerlaku.EditValue
                row.Item("tgl_akhir") = tglBerakhir.EditValue
                row.Item("jml_bln") = txtBulan.EditValue
                row.Item("nilai_total") = txtNilaiTotal.EditValue
                'row.Item("nilai_pembebanan") = txtNilaiPembeban.EditValue
                row.Item("keterangan") = txtKeterangan.EditValue
                row.Item("rek_biaya") = LOVrekBiaya.EditValue
                'row.Item("rek_pusat_biaya") = LOVpusatBiaya.EditValue
                row.Item("status") = LOVstatus.EditValue

                row.Item("last_create_date") = getTanggal()
                row.Item("last_created_by") = umum.username
                row.Item("program_name") = Me.Name

                dsAktiva.Tables("Aktiva").Rows.Add(row)
                '----------------------------------------------
                Dim counter As Integer = CInt(GenKodeSeq())

                For Each rowS As DataRow In dsAktiva.Tables("AktivaD").Rows
                    If rowS.RowState = DataRowState.Added Then
                        rowS.Item("Kd_cabang") = getKodeCabang()
                        rowS.Item("no_trans") = txtNomor.EditValue

                        rowS.Item("no_seq") = counter
                        counter += 1

                        rowS.Item("tipe_trans") = "JKK-KBB-06"
                        'rowS.Item("rek_pusat_biaya") =
                        'rowS.Item("val_bulanan") = 
                        'rowS.Item("val_total") = 
                        'rowS.Item("sisa_val") = 
                        rowS.Item("keterangan") = txtKeterangan.EditValue
                        rowS.Item("status") = LOVstatus.EditValue

                        rowS.Item("last_create_date") = getTanggal()
                        rowS.Item("last_created_by") = umum.username
                        rowS.Item("program_name") = Me.Name
                    ElseIf rowS.RowState = DataRowState.Modified Then
                        rowS.Item("Last_update_date") = getTanggal()
                        rowS.Item("Last_updated_by") = username
                    End If
                Next


            End If

            If STATE = "EDIT" Then

                row = dsAktiva.Tables("Aktiva").Rows(0)

                row.Item("nama_biaya") = txtNama.EditValue
                row.Item("tgl_awal") = tglBerlaku.EditValue
                row.Item("tgl_akhir") = tglBerakhir.EditValue
                row.Item("jml_bln") = txtBulan.EditValue
                row.Item("nilai_total") = txtNilaiTotal.EditValue
                'row.Item("nilai_pembebanan") = txtNilaiPembeban.EditValue
                row.Item("keterangan") = txtKeterangan.EditValue
                row.Item("rek_biaya") = LOVrekBiaya.EditValue
                'row.Item("rek_pusat_biaya") = LOVpusatBiaya.EditValue
                row.Item("status") = LOVstatus.EditValue

                row.Item("last_update_date") = getTanggal()
                row.Item("last_updated_by") = umum.username

                '----------------------------------------------
                Dim counter As Integer = CInt(GenKodeSeq())

                For Each rowS As DataRow In dsAktiva.Tables("AktivaD").Rows
                    If rowS.RowState = DataRowState.Added Then
                        rowS.Item("Kd_cabang") = txtKdCabang.EditValue
                        rowS.Item("no_trans") = txtNomor.EditValue

                        rowS.Item("no_seq") = counter
                        counter += 1

                        rowS.Item("tipe_trans") = "JKK-KBB-06"
                        'rowS.Item("rek_pusat_biaya") = 
                        'rowS.Item("val_bulanan") = 
                        'rowS.Item("val_total") = 
                        'rowS.Item("sisa_val") = 
                        rowS.Item("keterangan") = txtKeterangan.EditValue
                        rowS.Item("status") = LOVstatus.EditValue

                        rowS.Item("Last_Create_Date") = Now
                        rowS.Item("Last_Created_By") = username

                        rowS.Item("last_create_date") = getTanggal()
                        rowS.Item("last_created_by") = umum.username
                    ElseIf rowS.RowState = DataRowState.Modified Then
                        rowS.Item("Last_Update_Date") = Now
                        rowS.Item("Last_Updated_By") = username
                        rowS.Item("program_name") = Me.Name
                    End If
                Next

            End If


            myBuilder = New SqlCommandBuilder(daAktiva)
            daAktiva.UpdateCommand = myBuilder.GetUpdateCommand()
            daAktiva.InsertCommand = myBuilder.GetInsertCommand()
            daAktiva.DeleteCommand = myBuilder.GetDeleteCommand()

            myBuilderD = New SqlCommandBuilder(daAktivaD)
            daAktivaD.UpdateCommand = myBuilderD.GetUpdateCommand()
            daAktivaD.InsertCommand = myBuilderD.GetInsertCommand()
            daAktivaD.DeleteCommand = myBuilderD.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            daAktiva.UpdateCommand.Transaction = BTRANS
            daAktiva.InsertCommand.Transaction = BTRANS
            daAktiva.DeleteCommand.Transaction = BTRANS

            daAktivaD.UpdateCommand.Transaction = BTRANS
            daAktivaD.InsertCommand.Transaction = BTRANS
            daAktivaD.DeleteCommand.Transaction = BTRANS

            daAktiva.Update(dsAktiva.Tables("Aktiva"))
            daAktivaD.Update(dsAktiva.Tables("AktivaD"))

            'dsAktiva.Tables("Aktiva").AcceptChanges()

            Try
                BTRANS.Commit()
                showMessages("Data Baru Berhasil Disimpan")
            Catch ex As Exception
                BTRANS.Rollback()
                dsAktiva.Tables("Aktiva").RejectChanges()
                MsgBox(ex.Message)
            End Try

            loadTemp()  ' RESET GRID BEBAN
            GenKode()   ' GEN NOMOR URUT
            txtNomor.EditValue = ParamGenKode   ' TAMPIL NO URUT
            setPrimaryKey() ' CLEAR DETAIL GRID
            clearIsian()  ' CLEAR TEXTBOX
        Catch ex As Exception
            MsgBox("Ada masalah dalam menyimpan data. Detail Error : " & ex.Message)
        End Try
    End Sub

    Sub clearIsian()
        txtNama.EditValue = ""
        txtKeterangan.EditValue = ""
        txtNilaiTotal.EditValue = 0
    End Sub

    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        save_click()
    End Sub

    Sub bersih()
        txtKeterangan.EditValue = vbNullString
        txtNilaiTotal.EditValue = vbNullString
        txtNilaiPembeban.EditValue = vbNullString
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        bersih()
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        loadTemp()
    End Sub

    Sub ShowGridPreview(ByVal grid As DevExpress.XtraGrid.GridControl)
        ' Check whether the XtraGrid control can be previewed. 
        If Not grid.IsPrintingAvailable Then
            MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error")
            Return
        End If
        ' Opens the Preview window. 
        grid.ShowPreview()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        ShowGridPreview(GV.GridControl)
    End Sub

    Private Sub tglBerakhir_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tglBerakhir.EditValueChanged
        Bulan = 0
        txtBulan.EditValue = 0
        Bulan = tglBerakhir.DateTime.Month - tglBerlaku.DateTime.Month
        txtBulan.EditValue = Bulan
    End Sub

    Private Sub tglBerlaku_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tglBerlaku.EditValueChanged
        Bulan = 0
        txtBulan.EditValue = 0
        Bulan = tglBerakhir.DateTime.Month - tglBerlaku.DateTime.Month
        txtBulan.EditValue = Bulan
    End Sub

    Private Sub GridView1_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GVDet.CellValueChanged
        Dim view As ColumnView = sender
        If e.Column Is val_total3 Then
            view.SetRowCellValue(e.RowHandle, "val_jumlah", CInt(txtNilaiTotal.EditValue) - CInt(view.GetFocusedRowCellValue("val_total")))
        End If

        If e.Column Is val_jumlah3 Then
            view.SetRowCellValue(e.RowHandle, "val_bulanan", CInt(view.GetFocusedRowCellValue("val_jumlah")) / CInt(txtBulan.EditValue))
        End If
    End Sub
End Class

