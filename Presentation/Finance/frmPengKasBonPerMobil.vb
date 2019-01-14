'|-----------------------
'|  CREATED BY RENDY    |
'|  EDITED BY RENDY     |
'|-----------------------
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient
Public Class frmPengKasBonPerMobil

    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Public obj As Object

    Public STATE As String
    Dim row As DataRow

    Dim dsGrid, dsKasBon, dsLOV As New DataSet
    Dim daValuta, daSupp, daGrid, daKartu, dakasBon, daSopir, daKendaraan, daNoPol, daBiayaSop, daKota As SqlDataAdapter

    Dim myBuilder As New SqlCommandBuilder
    Dim BTRANS As SqlTransaction
    Dim NoPol As String

    Dim dr As SqlDataReader
    Dim param, ParamGenKode, bukuBesar As String

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

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = False
        btnadd = True
        setStatus()

        Me.Enabled = False

        STATE = "ADD"

        'lblState.Text = "ADD STATE"
        'txtNomor.Text = getNoTrans("JKK", getTanggal)

        bersih()
    End Sub

    Public Sub add_click()
        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnadd = False
        setStatus()

        STATE = "ADD"

        'txtNomor.Text = getNoTrans("JKK", getTanggal)
        'txtNoCabang.EditValue = getKodeCabang()

        lblState.Text = "ADD STATE"
    End Sub

    Private Sub frmPengKasBonPerMobil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)

        GenLOV()
        setPrimaryKey()
        loadTemp()

        TglPengajuan.EditValue = getTanggal()
        'MsgBox(Now)

        TanggalCari.EditValue = getTanggal()
    End Sub

    Sub SearchKasBon()

        dsGrid.Clear()
        daGrid = New SqlDataAdapter(New SqlCommand("select ROW_NUMBER() OVER (ORDER BY no_pol) as 'nomor',* from FIN.dbo.v_sj_kasbon where no_pol  = '" & LOVNoPol.EditValue & "' and Tgl_kirim = '" & Format(TanggalCari.EditValue, "MM/dd/yyyy") & "'", sqlconn))
        daGrid.Fill(dsGrid, "search")
        GCView.DataSource = dsGrid.Tables("search")
        GVView.BestFitColumns()
    End Sub

    Private Sub GVView_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GVView.InitNewRow
        'GV.GetRow(e.RowHandle).item("no_seq") = GV.RowCount + 1
        Dim View As ColumnView = sender
        View.SetRowCellValue(e.RowHandle, View.Columns("nomor"), GVView.RowCount + 1)
    End Sub

    Sub GenLOV()

        dsLOV.Clear()

        daKartu = New SqlDataAdapter(New SqlCommand("select  nama,kode from FIN.dbo.v_kartu", sqlconn))
        daKartu.Fill(dsLOV, "kartu")
        RepKartu.Properties.DataSource = dsLOV.Tables("kartu")
        RepKartu.Properties.DisplayMember = "nama"
        RepKartu.Properties.ValueMember = "kode"

        LOVKartu2.Properties.DataSource = dsLOV.Tables("kartu")
        LOVKartu2.Properties.DisplayMember = "nama"
        LOVKartu2.Properties.ValueMember = "kode"

        daNoPol = New SqlDataAdapter(New SqlCommand("select distinct (no_pol) from FIN.dbo.v_sj_kasbon", sqlconn))
        daNoPol.Fill(dsLOV, "nopol")
        LOVNoPol.Properties.DataSource = dsLOV.Tables("nopol")
        LOVNoPol.Properties.DisplayMember = "no_pol"
        LOVNoPol.Properties.ValueMember = "no_pol"

        daKendaraan = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Kendaraan", sqlconn))
        daKendaraan.Fill(dsLOV, "kendaraan")
        LOVJnsKend.Properties.DataSource = dsLOV.Tables("kendaraan")
        LOVJnsKend.Properties.DisplayMember = "Nama_Kendaraan"
        LOVJnsKend.Properties.ValueMember = "Nama_Kendaraan"

        daSopir = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Sopir", sqlconn))
        daSopir.Fill(dsLOV, "sopir")
        LOVSupir.Properties.DataSource = dsLOV.Tables("sopir")
        LOVSupir.Properties.DisplayMember = "Nama_Sopir"
        LOVSupir.Properties.ValueMember = "Kode_Sopir"

        daBiayaSop = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_tarif_biaya_sopir", sqlconn))
        daBiayaSop.Fill(dsLOV, "biaya_sopir")
        LOVSupir.Properties.DataSource = dsLOV.Tables("biaya_sopir")
        LOVSupir.Properties.DisplayMember = "nama"
        LOVSupir.Properties.ValueMember = "kode"

        daKota = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_kota", sqlconn))
        daKota.Fill(dsLOV, "kota")
        LOVKota.Properties.DataSource = dsLOV.Tables("kota")
        LOVKota.Properties.DisplayMember = "Nama_Kota"
        LOVKota.Properties.ValueMember = "Kode_Kota"

    End Sub

    Sub autoKendaraan()
        Try
            Dim dr As SqlDataReader = New SqlCommand(" select nama_kendaraan from FIN.dbo.v_sj_kasbon A,SIF.dbo.SIF_Kendaraan B where A.no_pol = b.No_Polisi and A.no_pol = '" & LOVNoPol.EditValue & "'", sqlconn).ExecuteReader

            dr.Read()
            If dr.HasRows Then
                LOVJnsKend.EditValue = dr.Item(0)
            End If

            dr.Close()
        Catch ex As Exception
            NoPol = ""
            'MsgBox(ex.Message)
        End Try

    End Sub

    Sub autoSopir()
        Try
            Dim dr As SqlDataReader = New SqlCommand(" select kd_sopir,nama_sopir from FIN.dbo.v_sj_kasbon A,SIF.dbo.SIF_Sopir B where A.kd_sopir =B.Kode_Sopir  and A.no_pol = '" & LOVNoPol.EditValue & "'", sqlconn).ExecuteReader

            dr.Read()
            If dr.HasRows Then
                LOVSupir.EditValue = dr.Item(0)
            End If

            dr.Close()
        Catch ex As Exception
            NoPol = ""
            'MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub LOVNoPol_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOVNoPol.EditValueChanged
        autoKendaraan()
        autoSopir()
    End Sub

    Sub setPrimaryKey(Optional ByVal no_kasbon As String = "*")
        If Not dsKasBon.Tables("kasbon") Is Nothing Then dsKasBon.Tables("kasbon").Clear()

        dakasBon = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_KAS_BON where nomor = '" & no_kasbon & "' ", sqlconn))
        dakasBon.Fill(dsKasBon, "kasbon")
    End Sub

    Sub GenBukuBesar()
        Try
            Dim dr As SqlDataReader = New SqlCommand("select kd_bb_besar1 from sif.dbo.SIF_TIPE_TRANS_D where tipe_trans = 'JKK-KBB-03' and tipe_desc ='KASBON' ", sqlconn).ExecuteReader

            dr.Read()
            If dr.HasRows Then
                bukuBesar = dr.Item(0)
            End If

            dr.Close()
        Catch ex As Exception
            bukuBesar = ""
            'MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub save_click(Optional ByVal isDelete As Boolean = False)
        Try

      
            If Not isDelete Then

                GenBukuBesar()

                If STATE = "ADD" Then

                    txtNomor.EditValue = getNoTrans("KBN", getTanggal)

                    row = dsKasBon.Tables("kasbon").NewRow

                    txtNoCabang.EditValue = getKodeCabang()

                    row.Item("Kd_cabang") = txtNoCabang.EditValue
                    row.Item("nomor") = txtNomor.EditValue
                    row.Item("tipe_trans") = "JKK-KBB-03"

                    row.Item("last_create_date") = getTanggal()
                    row.Item("last_created_by") = umum.username
                    row.Item("program_name") = Me.Name

                    dsKasBon.Tables("kasbon").Rows.Add(row)


                End If

                If STATE = "EDIT" Then

                    row = dsKasBon.Tables("kasbon").Rows(0)
                    row.Item("last_update_date") = getTanggal()
                    row.Item("last_updated_by") = umum.username

                End If

                row.Item("tgl_trans") = TglPengajuan.EditValue
                row.Item("kd_kartu") = LOVSupir.EditValue
                row.Item("kd_valuta") = "IDR"
                row.Item("kurs_valuta") = "1"
                row.Item("keterangan") = txtketerangan.EditValue
                row.Item("kd_divisi") = kddep
                row.Item("no_jur") = vbNullString
                row.Item("kd_tarif") = LOVTarifTujuan.EditValue
                row.Item("kd_buku_besar") = bukuBesar

                row.Item("jml_trans") = txtNilaiKasBon.EditValue
                row.Item("jml_bayar") = "0"
                row.Item("jml_akhir") = txtNilaiKasBon.EditValue
                row.Item("jml_tambahan") = txtJmlTambahan.EditValue

            End If

            myBuilder = New SqlCommandBuilder(dakasBon)
            dakasBon.UpdateCommand = myBuilder.GetUpdateCommand()
            dakasBon.InsertCommand = myBuilder.GetInsertCommand()
            dakasBon.DeleteCommand = myBuilder.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            dakasBon.UpdateCommand.Transaction = BTRANS
            dakasBon.InsertCommand.Transaction = BTRANS
            dakasBon.DeleteCommand.Transaction = BTRANS

            dakasBon.Update(dsKasBon.Tables("kasbon"))

            'dsAktiva.Tables("Aktiva").AcceptChanges()

            call_procedure("JKK-KBB-03", txtNomor.EditValue, BTRANS)

            BTRANS.Commit()
            showMessages("Data Berhasil Disimpan")
        Catch ex As Exception
            MsgBox("Periksa kembali isian form, Detail Error : " & ex.Message)
        End Try

        'Try
        '    BTRANS.Commit()
        '    showMessages("Data Baru Berhasil Disimpan")
        'Catch ex As Exception
        '    BTRANS.Rollback()
        '    dsKasBon.Tables("kasbon").RejectChanges()
        '    MsgBox(ex.Message)
        'End Try

        loadTemp()

    End Sub

    Public Sub call_procedure(ByVal noTrans As String, ByVal noInvoice As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_AUTOMAN_JURNAL"

        sqlCmd.Parameters.Add("@tipe_trans", SqlDbType.Char).Value = noTrans
        sqlCmd.Parameters.Add("@no_inv", SqlDbType.Char).Value = noInvoice
        Dim dr As SqlDataReader = sqlCmd.ExecuteReader
        dr.Close()
    End Sub

    Sub loadTemp()
        If Not dsKasBon.Tables("Temp") Is Nothing Then dsKasBon.Tables("Temp").Clear()
        dakasBon = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_KAS_BON ", sqlconn))
        dakasBon.Fill(dsKasBon, "Temp")
        GC.DataSource = dsKasBon.Tables("Temp")
        GV.BestFitColumns()
    End Sub

    Private Sub GV_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV.DoubleClick

        'row = dsAktiva.Tables("Temp").Rows(GV.GetSelectedRows(0))

        setPrimaryKey(GV.GetRow(GV.GetSelectedRows(0)).item("nomor"))

        txtNomor.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("nomor")
        TglPengajuan.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("tgl_trans")
        LOVSupir.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("kd_kartu")
        'LOVValuta.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("kd_valuta")
        'txtKursVal.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("kurs_valuta")
        txtNilaiKasBon.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("jml_trans")
        txtketerangan.EditValue = GV.GetRow(GV.GetSelectedRows(0)).item("keterangan")

        STATE = "EDIT"
        lblState.Text = "EDIT STATE"
    End Sub

    Sub bersih()
        txtNomor.EditValue = vbNullString
        TglPengajuan.EditValue = vbNullString
        LOVSupir.EditValue = vbNullString
        'LOVValuta.EditValue = vbNullString
        'txtKursVal.EditValue = vbNullString
        txtNilaiKasBon.EditValue = vbNullString
        txtketerangan.EditValue = vbNullString
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

    Public Sub delete_click()
        If Not dsKasBon.Tables("kasbon") Is Nothing Then
            For Each rw As DataRow In dsKasBon.Tables("kasbon").Rows
                rw.Delete()
            Next
        End If
        save_click(True)
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        ShowGridPreview(GV.GridControl)
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        loadTemp()
    End Sub

    Private Sub cmdSimpan_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        save_click()
    End Sub

    Private Sub cmdDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        delete_click()
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        bersih()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        SearchKasBon()
        lblSopir.Text = "..."

        If LOVSupir.Text = Nothing Then
            lblSopir.Text = "Sopir kosong, cek kembali master sopir"
        End If
    End Sub

    Private Sub TanggalCari_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TanggalCari.EditValueChanged
        If Not dsLOV.Tables("nopol") Is Nothing Then dsLOV.Tables("nopol").Clear()

        daNoPol = New SqlDataAdapter(New SqlCommand("select distinct (no_pol) from FIN.dbo.v_sj_kasbon where Tgl_kirim = '" & Format(TanggalCari.EditValue, "MM/dd/yyyy") & "'", sqlconn))
        daNoPol.Fill(dsLOV, "nopol")
        LOVNoPol.Properties.DataSource = dsLOV.Tables("nopol")
        LOVNoPol.Properties.DisplayMember = "no_pol"
        LOVNoPol.Properties.ValueMember = "no_pol"

        Try
            Dim dr As SqlDataReader = New SqlCommand("select distinct (no_pol) from FIN.dbo.v_sj_kasbon where Tgl_kirim = '" & Format(TanggalCari.EditValue, "MM/dd/yyyy") & "'", sqlconn).ExecuteReader

            dr.Read()
            If dr.HasRows Then
                LOVNoPol.EditValue = dr.Item(0)
            End If

            dr.Close()
        Catch ex As Exception
            LOVNoPol.EditValue = " "
            MsgBox(ex.Message)
        End Try
    End Sub
End Class