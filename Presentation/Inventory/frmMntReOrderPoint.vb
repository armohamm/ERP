'|-------------------------
'|  CREATED BY HAZZARD    |
'|  EDITED BY HAZZARD     |
'|-------------------------
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports System.Threading

Public Class frmMntReOrderPoint
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim err As String = ""
    Dim isvalid As Boolean
    Dim rl, r2 As DataRelation
    Dim dsLookUp, dsStok, dsStokGudang, dsPers, dsLOV As New DataSet

    Dim daLookUp, daStok, daStokDet, daStokGudang, daStokGudangDet, daSave, daSave1 As SqlDataAdapter
    Dim daPers, daBrg, daSat, daMerk, daTipe, daSubTipe, daKain, daUkuran As SqlDataAdapter

    Dim row, rows As DataRow
    Dim myBuilder As New SqlCommandBuilder
    Dim BTRANS As SqlTransaction
    Dim isOK As Boolean
    Dim noTransaksi As String


    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Private Sub frmMntReOrderPoint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True

        loadLookUp()
        'LoadLOV()

        For a As Integer = 0 To GV1.Columns.Count - 1
            CCKListBoxKolom.Items.Add(GV1.Columns(a).Caption)
        Next


        pnlGridLeft.Visible = False
        Allcmd.Visible = False
        ResetCmd.Visible = False

        SCpnlMaster.SplitterPosition = 1000
        SplitContainerControl1.SplitterPosition = 1000

        'LoadLastPeriod()
    End Sub


    Private Sub loadLookUp()
        If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
        If Not dsLookUp.Tables("LookBarang") Is Nothing Then dsLookUp.Tables("LookBarang").Clear()
        If Not dsLookUp.Tables("persediaan") Is Nothing Then dsLookUp.Tables("persediaan").Clear()
        If Not dsLookUp.Tables("barang") Is Nothing Then dsLookUp.Tables("barang").Clear()
        If Not dsLookUp.Tables("satuan") Is Nothing Then dsLookUp.Tables("satuan").Clear()
        If Not dsLookUp.Tables("ukuran") Is Nothing Then dsLookUp.Tables("ukuran").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        daLookUp.Fill(dsLookUp, "LookPeriode")
        lookupBulanAwal.Properties.DataSource = dsLookUp.Tables("LookPeriode")
        lookupBulanAwal.Properties.DisplayMember = "nama"
        lookupBulanAwal.Properties.ValueMember = "thnbln"

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT Kode_Barang, Nama_Barang FROM SIF.dbo.SIF_Barang", sqlconn))
        daLookUp.Fill(dsLookUp, "LookBarang")
        LOVbarang.DataSource = dsLookUp.Tables("LookBarang")
        LOVbarang.DisplayMember = "Nama_Barang"
        LOVbarang.ValueMember = "Kode_Barang"

        daPers = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Jns_Persediaan ", sqlconn))
        daPers.Fill(dsLOV, "persediaan")
        LOVpersediaan.DataSource = dsLOV.Tables("persediaan")
        LOVpersediaan.DisplayMember = "Nama_Persediaan"
        LOVpersediaan.ValueMember = "Kd_Jns_Persd"

        daBrg = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Jenis_Barang", sqlconn))
        daBrg.Fill(dsLOV, "barang")
        LOVjenisBarang.DataSource = dsLOV.Tables("barang")
        LOVjenisBarang.DisplayMember = "Nama_Jenis"
        LOVjenisBarang.ValueMember = "Kd_Jns_Brg"

        daSat = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Satuan", sqlconn))
        daSat.Fill(dsLOV, "satuan")
        LOVsatuan.DataSource = dsLOV.Tables("satuan")
        LOVsatuan.DisplayMember = "Nama_Satuan"
        LOVsatuan.ValueMember = "Kode_Satuan"

        daUkuran = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Ukuran", sqlconn))
        daUkuran.Fill(dsLOV, "ukuran")
        LOVukuran.DataSource = dsLOV.Tables("ukuran")
        LOVukuran.DisplayMember = "Nama_Ukuran"
        LOVukuran.ValueMember = "Kode_Ukuran"
    End Sub

    Sub LoadLastPeriod()
        Try
            Dim dr As SqlDataReader = New SqlCommand("SELECT MAX(thn_buku + bln_buku) AS 'thnbln' FROM SIF.dbo.SIF_Periode_Buku", sqlconn).ExecuteReader

            dr.Read()
            If dr.HasRows Then
                lookupBulanAwal.EditValue = dr.Item(0)
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'Sub LoadLOV()
    '    dsLOV.Clear()


    '    '4
    '    daMerk = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Merk", sqlconn))
    '    daMerk.Fill(dsLOV, "merk")
    '    LOVmerk.Properties.DataSource = dsLOV.Tables("merk")
    '    LOVmerk.Properties.DisplayMember = "Nama_Merk"
    '    LOVmerk.Properties.ValueMember = "Kode_Merk"

    '    '5
    '    daTipe = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Tipe", sqlconn))
    '    daTipe.Fill(dsLOV, "tipe")
    '    LOVtipe.Properties.DataSource = dsLOV.Tables("tipe")
    '    LOVtipe.Properties.DisplayMember = "Nama_Tipe"
    '    LOVtipe.Properties.ValueMember = "Kode_Tipe"

    '    '6
    '    daSubTipe = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Sub_Tipe", sqlconn))
    '    daSubTipe.Fill(dsLOV, "subtipe")
    '    LOVsubtipe.Properties.DataSource = dsLOV.Tables("subtipe")
    '    LOVsubtipe.Properties.DisplayMember = "Nama_Sub_Tipe"
    '    LOVsubtipe.Properties.ValueMember = "Kd_Sub_Tipe"

    '    '7
    '    daKain = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Kain", sqlconn))
    '    daKain.Fill(dsLOV, "kain")
    '    LOVkain.Properties.DataSource = dsLOV.Tables("kain")
    '    LOVkain.Properties.DisplayMember = "Merk_Kain"
    '    LOVkain.Properties.ValueMember = "Kode_Kain"

    '    '8

    'End Sub

    Sub LoadGrid1()

        dsStok.Clear()
        daStok = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select ROW_NUMBER() OVER (ORDER BY kd_stok) as 'nomor',* from INV.dbo.v_monstok_aseli", sqlconn))
        daStok.Fill(dsStok, "stok")
        GC1.DataSource = dsStok.Tables("stok")
        GV1.BestFitColumns()

    End Sub

    Sub searchStok(Optional ByVal X As String = "")
        Try
            'If Not dsStok.Tables("stok") Is Nothing Then dsStok.Tables("stok").Clear()
            'If Not dsStok.Tables("stok_det") Is Nothing Then dsStok.Tables("stok_det").Clear()
            dsStok = New DataSet

            daStok = New SqlDataAdapter(New SqlCommand("select ROW_NUMBER() OVER (ORDER BY kd_stok) as 'nomor', *, '' as cek " & _
            "  from INV.dbo.v_monstok_aseli " & _
            "  where bultah = '" & X & "' and kd_jns_persd in ('1','2','3')", sqlconn))
            daStok.Fill(dsStok, "stok")


            'daStokDet = New SqlDataAdapter(New SqlCommand("select B.Kode_Gudang ,B.Nama_Gudang,A.akhir_qty,B.Keterangan,A.kd_stok ,A.bultah ,A.kd_satuan ,A.kd_ukuran ,A.panjang ,A.lebar ,A.tinggi    " & _
            '"  from INV.dbo.INV_STOK_GUDANG A,SIF.dbo.SIF_Gudang B  " & _
            '"  where A.kode_gudang = B.Kode_Gudang and bultah =  '" & X & "' and kd_stok in (select kd_stok from INV.dbo.v_monstok_aseli  where bultah = '" & X & "')", sqlconn))
            'daStokDet.Fill(dsStok, "stok_det")

            'Dim colM(6) As DataColumn
            'colM(0) = dsStok.Tables("stok").Columns("kd_Stok")
            'colM(1) = dsStok.Tables("stok").Columns("bultah")
            'colM(2) = dsStok.Tables("stok").Columns("kd_ukuran")
            'colM(3) = dsStok.Tables("stok").Columns("kd_satuan")
            'colM(4) = dsStok.Tables("stok").Columns("panjang")
            'colM(5) = dsStok.Tables("stok").Columns("lebar")
            'colM(6) = dsStok.Tables("stok").Columns("tinggi")

            'Dim colD(6) As DataColumn
            'colD(0) = dsStok.Tables("stok_det").Columns("kd_Stok")
            'colD(1) = dsStok.Tables("stok_det").Columns("bultah")
            'colD(2) = dsStok.Tables("stok_det").Columns("kd_ukuran")
            'colD(3) = dsStok.Tables("stok_det").Columns("kd_satuan")
            'colD(4) = dsStok.Tables("stok_det").Columns("panjang")
            'colD(5) = dsStok.Tables("stok_det").Columns("lebar")
            'colD(6) = dsStok.Tables("stok_det").Columns("tinggi")

            'rl = dsStok.Relations.Add("StokToGudang", colM, colD)

            GC1.DataSource = dsStok.Tables("stok")

            'GC1.LevelTree.Nodes.Add("StokToGudang", GV1Det)

            GV1.BestFitColumns()
            'GV1Det.BestFitColumns()

        Catch ex As Exception
            lblError1.Text = ex.Message & " , " & "Ada kesalahan data Stok"
        End Try
    End Sub

    Private Sub lookupBulanAwal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookupBulanAwal.EditValueChanged
        Eksekusi()
    End Sub

    Sub Eksekusi()
        DxErrorProvider1.ClearErrors()

        If lookupBulanAwal.EditValue = "" Then
            DxErrorProvider1.SetError(lookupBulanAwal, "Silahkan pilih periode", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            Exit Sub
        End If

        'dsStok.Clear()
        'dsStok.Relations.Clear()

        dsStokGudang.Clear()
        dsStokGudang.Relations.Clear()

        lblError1.Text = "..."
        lblError2.Text = "..."

        lblLoad1.Visible = True
        lblLoad2.Visible = True

        lblLoad1.Refresh()
        lblLoad2.Refresh()

        searchStok(lookupBulanAwal.EditValue)

        lblLoad1.Visible = False
        lblLoad2.Visible = False

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Eksekusi()
    End Sub

    Private Sub CCKListBoxKolom_ItemCheck(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles CCKListBoxKolom.ItemCheck
        'reset
        For i As Integer = 0 To CCKListBoxKolom.Items.Count - 1
            GV1.Columns(i).Visible = False
        Next

        'show selected
        For a As Integer = 0 To GV1.Columns.Count - 1
            For i As Integer = 0 To CCKListBoxKolom.Items.Count - 1

                If GV1.Columns(a).Caption = CCKListBoxKolom.Items(i).Value And CCKListBoxKolom.Items(i).CheckState = CheckState.Checked Then
                    GV1.Columns(a).Visible = True
                End If

            Next
        Next

    End Sub

    Private Sub Allcmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Allcmd.Click
        For i As Integer = 0 To CCKListBoxKolom.Items.Count - 1
            CCKListBoxKolom.Items(i).CheckState = CheckState.Checked
        Next

    End Sub

    Private Sub ResetCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetCmd.Click
        For i As Integer = 0 To CCKListBoxKolom.Items.Count - 1
            CCKListBoxKolom.Items(i).CheckState = CheckState.Unchecked
        Next

    End Sub

    Private Sub CCKBOXSetting_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CCKBOXSetting.CheckedChanged
        If CCKBOXSetting.Checked = True Then
            pnlGridLeft.Visible = True
            Allcmd.Visible = True
            ResetCmd.Visible = True
        Else
            pnlGridLeft.Visible = False
            Allcmd.Visible = False
            ResetCmd.Visible = False
        End If
    End Sub

    Private Sub CEStokMerah_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEStokMerah.CheckedChanged
        If CEStokMerah.Checked = True Then
            If CEStokHijau.Checked = True Then
                GV1.ActiveFilterString = ""
            Else
                GV1.ActiveFilterString = "akhir_qty_onstok <= (stok_min*lead_time)"
            End If
        Else
            If CEStokHijau.Checked = True Then
                GV1.ActiveFilterString = "akhir_qty_onstok >= (stok_min*lead_time)"
            Else
                GV1.ActiveFilterString = ""
            End If
        End If
    End Sub

    Private Sub CEStokHijau_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEStokHijau.CheckedChanged
        If CEStokHijau.Checked = True Then
            If CEStokMerah.Checked = True Then
                GV1.ActiveFilterString = ""
            Else
                GV1.ActiveFilterString = "akhir_qty_onstok >= (stok_min*lead_time)"
            End If
        Else
            If CEStokMerah.Checked = True Then
                GV1.ActiveFilterString = "akhir_qty_onstok <= (stok_min*lead_time)"
            Else
                GV1.ActiveFilterString = ""
            End If
        End If
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

    Public Sub cetak_click()
        If Not GV1.RowCount <= 0 Then
            GV1.FormatConditions.Item(0).Appearance.BackColor = Color.White
            GV1.FormatConditions.Item(1).Appearance.BackColor = Color.White
            ShowGridPreview(GV1.GridControl)
            GV1.FormatConditions.Item(0).Appearance.BackColor = Color.LightCoral
            GV1.FormatConditions.Item(1).Appearance.BackColor = Color.LightGreen
        Else
            MsgBox("Tidak ada data yang dicetak.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "PERINGATAN!")
        End If
    End Sub

    Private Sub loadData(ByVal kdStok As String)
        'If Not dsStok.Tables("Save") Is Nothing Then dsStok.Tables("Save").Clear()
        'If Not dsStok.Tables("SaveBaru") Is Nothing Then dsStok.Tables("SaveBaru").Clear()

        daSave1 = New SqlDataAdapter(New SqlCommand("select distinct * from INV.dbo.v_monstok_aseli where bultah = '" & lookupBulanAwal.EditValue & "' and kd_stok = '" & kdStok & "'", sqlconn))
        daSave1.Fill(dsStok, "Save")
        daSave = New SqlDataAdapter(New SqlCommand("select * from INV.dbo.INV_RDR_POINT_DPM where no_trans = '" & noTransaksi & "'", sqlconn))
        daSave.Fill(dsStok, "SaveBaru")
        row = dsStok.Tables("Save").Rows(0)
        rows = dsStok.Tables("SaveBaru").NewRow
        rows("Kd_Cabang") = getKodeCabang()
        rows("no_trans") = noTransaksi
        rows("tgl_trans") = Format(getTanggal(), "dd/MM/yyyy")
        rows("kd_stok") = kdStok
        rows("kd_satuan") = row("Kd_Satuan")
        rows("kd_ukuran") = row("kd_ukuran")
        rows("tinggi") = row("tinggi")
        rows("lebar") = row("lebar")
        rows("panjang") = row("panjang")
        rows("kd_jns_persd") = row("kd_jns_persd")
        rows("kd_jenis") = row("kd_jenis")
        rows("akhir_booked") = row("akhir_booked")
        rows("akhir_qty_onstok") = row("akhir_qty_onstok")
        rows("qty_available") = row("qty_available")
        rows("Last_Create_Date") = getTanggal()
        rows("Last_Created_By") = username
        rows("Program_Name") = Me.Name
        dsStok.Tables("SaveBaru").Rows.Add(rows)
    End Sub

    Public Sub save_click()
        For Each rw As DataRow In dsStok.Tables("stok").Rows
            If rw.RowState = DataRowState.Modified Then
                If rw.Item("cek").Equals("Y") Then
                    isOK = True
                    Exit For
                Else
                    isOK = False
                End If
            Else
                isOK = False
            End If
        Next

        If isOK = True Then
            noTransaksi = getNoTrans("DPM-M", getTanggal(), BTRANS)
            Try
                For Each rw As DataRow In dsStok.Tables("stok").Rows
                    If rw.Item("cek").Equals(ReCE.ValueChecked) Then
                        loadData(rw.Item("kd_stok"))
                    End If
                Next
                myBuilder = New SqlCommandBuilder(daSave)
                daSave.InsertCommand = myBuilder.GetInsertCommand()
                daSave.UpdateCommand = myBuilder.GetUpdateCommand()
                daSave.DeleteCommand = myBuilder.GetDeleteCommand()

                BTRANS = sqlconn.BeginTransaction("1")
                daSave.UpdateCommand.Transaction = BTRANS
                daSave.InsertCommand.Transaction = BTRANS
                daSave.DeleteCommand.Transaction = BTRANS

                daSave.Update(dsStok, ("SaveBaru"))
                dsStok.Tables("SaveBaru").AcceptChanges()

                call_procedure(noTransaksi, kddep, BTRANS)

                BTRANS.Commit()
                showMessages("Berhasil disimpan")
                searchStok(lookupBulanAwal.EditValue)
            Catch ex As Exception
                BTRANS.Rollback()
                dsStok.Tables("SaveBaru").RejectChanges()
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Gagal Simpan")
            End Try
        Else
            MsgBox("Tidak ada data yang dipilih", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
        End If

    End Sub

    Public Sub call_procedure(ByVal noTrans As String, ByVal dept As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Transaction = trans
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "PURC.dbo.purc_dpm_rdrpoint"

        sqlCmd.Parameters.Add("@vno_trans", SqlDbType.Char).Value = noTrans
        sqlCmd.Parameters.Add("@dept", SqlDbType.Char).Value = dept
        sqlCmd.ExecuteNonQuery()
    End Sub
End Class