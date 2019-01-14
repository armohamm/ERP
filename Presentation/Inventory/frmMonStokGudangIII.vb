'|-----------------------
'|  CREATED BY RENDY    |
'|  EDITED BY RENDY     |
'|-----------------------
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports System.Threading
Public Class frmMonStokGudangIII
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim err As String = ""
    Dim isvalid As Boolean
    Dim rl, r2 As DataRelation
    Dim dsLookUp, dsStok, dsStokGudang, dsPers, dsLOV As New DataSet

    Dim daLookUp, daStok, daStokDet, daStokGudang, daStokGudangDet As SqlDataAdapter
    Dim daPers, daBrg, daSat, daMerk, daTipe, daSubTipe, daKain, daUkuran As SqlDataAdapter
    Private Sub frmMonStokGudangIII_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True

        loadLookUp()
        LoadLOV()

        For a As Integer = 0 To GV1.Columns.Count - 1
            CCKListBoxKolom.Items.Add(GV1.Columns(a).Caption)
        Next


        For b As Integer = 0 To GV2.Columns.Count - 1
            CCKListBoxKolom2.Items.Add(GV2.Columns(b).Caption)
        Next

        pnlGridLeft.Visible = False
        Allcmd.Visible = False
        ResetCmd.Visible = False

        'LoadGrid1()
        'LoadGrid2()
    End Sub


    Private Sub loadLookUp()
        If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        daLookUp.Fill(dsLookUp, "LookPeriode")
        lookupBulanAwal.Properties.DataSource = dsLookUp.Tables("LookPeriode")
        lookupBulanAwal.Properties.DisplayMember = "nama"
        lookupBulanAwal.Properties.ValueMember = "thnbln"

    End Sub


    Sub LoadLOV()
        dsLOV.Clear()
        '1
        daPers = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Jns_Persediaan ", sqlconn))
        daPers.Fill(dsLOV, "persediaan")
        LOVpersediaan.Properties.DataSource = dsLOV.Tables("persediaan")
        LOVpersediaan.Properties.DisplayMember = "Nama_Persediaan"
        LOVpersediaan.Properties.ValueMember = "Kd_Jns_Persd"
        '2
        daBrg = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Jenis_Barang", sqlconn))
        daBrg.Fill(dsLOV, "barang")
        LOVjenisBarang.Properties.DataSource = dsLOV.Tables("barang")
        LOVjenisBarang.Properties.DisplayMember = "Nama_Jenis"
        LOVjenisBarang.Properties.ValueMember = "Kd_Jns_Brg"
        '3
        daSat = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Satuan", sqlconn))
        daSat.Fill(dsLOV, "satuan")
        LOVsatuan.Properties.DataSource = dsLOV.Tables("satuan")
        LOVsatuan.Properties.DisplayMember = "Nama_Satuan"
        LOVsatuan.Properties.ValueMember = "Kode_Satuan"

        LOVsatuan2.Properties.DataSource = dsLOV.Tables("satuan")
        LOVsatuan2.Properties.DisplayMember = "Nama_Satuan"
        LOVsatuan2.Properties.ValueMember = "Kode_Satuan"
        '4
        daMerk = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Merk", sqlconn))
        daMerk.Fill(dsLOV, "merk")
        LOVmerk.Properties.DataSource = dsLOV.Tables("merk")
        LOVmerk.Properties.DisplayMember = "Nama_Merk"
        LOVmerk.Properties.ValueMember = "Kode_Merk"

        LOVmerk2.Properties.DataSource = dsLOV.Tables("merk")
        LOVmerk2.Properties.DisplayMember = "Nama_Merk"
        LOVmerk2.Properties.ValueMember = "Kode_Merk"
        '5
        daTipe = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Tipe", sqlconn))
        daTipe.Fill(dsLOV, "tipe")
        LOVtipe.Properties.DataSource = dsLOV.Tables("tipe")
        LOVtipe.Properties.DisplayMember = "Nama_Tipe"
        LOVtipe.Properties.ValueMember = "Kode_Tipe"

        LOVtipe2.Properties.DataSource = dsLOV.Tables("tipe")
        LOVtipe2.Properties.DisplayMember = "Nama_Tipe"
        LOVtipe2.Properties.ValueMember = "Kode_Tipe"
        '6
        daSubTipe = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Sub_Tipe", sqlconn))
        daSubTipe.Fill(dsLOV, "subtipe")
        LOVsubtipe.Properties.DataSource = dsLOV.Tables("subtipe")
        LOVsubtipe.Properties.DisplayMember = "Nama_Sub_Tipe"
        LOVsubtipe.Properties.ValueMember = "Kd_Sub_Tipe"

        LOVsubtipe2.Properties.DataSource = dsLOV.Tables("subtipe")
        LOVsubtipe2.Properties.DisplayMember = "Nama_Sub_Tipe"
        LOVsubtipe2.Properties.ValueMember = "Kd_Sub_Tipe"
        '7
        daKain = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Kain", sqlconn))
        daKain.Fill(dsLOV, "kain")
        LOVkain.Properties.DataSource = dsLOV.Tables("kain")
        LOVkain.Properties.DisplayMember = "Merk_Kain"
        LOVkain.Properties.ValueMember = "Kode_Kain"

        LOVkain2.Properties.DataSource = dsLOV.Tables("kain")
        LOVkain2.Properties.DisplayMember = "Merk_Kain"
        LOVkain2.Properties.ValueMember = "Kode_Kain"
        '8
        daUkuran = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Ukuran", sqlconn))
        daUkuran.Fill(dsLOV, "ukuran")
        LOVukuran.Properties.DataSource = dsLOV.Tables("ukuran")
        LOVukuran.Properties.DisplayMember = "Nama_Ukuran"
        LOVukuran.Properties.ValueMember = "Kode_Ukuran"

        LOVukuran2.Properties.DataSource = dsLOV.Tables("ukuran")
        LOVukuran2.Properties.DisplayMember = "Nama_Ukuran"
        LOVukuran2.Properties.ValueMember = "Kode_Ukuran"


    End Sub

    Sub LoadGrid1()

        dsStok.Clear()
        daStok = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select ROW_NUMBER() OVER (ORDER BY kd_stok) as 'nomor',* from INV.dbo.v_monstok_aseli", sqlconn))
        daStok.Fill(dsStok, "stok")
        GC1.DataSource = dsStok.Tables("stok")
        GV1.BestFitColumns()

    End Sub

    Sub LoadGrid2()

        dsStokGudang.Clear()
        daStokGudang = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_Gudang A, INV.dbo.INV_STOK_GUDANG B where A.Kode_Gudang = B.kode_gudang where  ", sqlconn))
        daStokGudang.Fill(dsStokGudang, "detstok")
        'GC2.DataSource = dsStokGudang.Tables("detstok")
        'GV2.BestFitColumns()

    End Sub

    Sub searchStok(Optional ByVal X As String = "")
        Try


            If Not dsStok.Tables("stok") Is Nothing Then
                dsStok.Tables("stok").Clear()
            End If


            If Not dsStok.Tables("stok_det") Is Nothing Then
                dsStok.Tables("stok_det").Clear()
            End If

            'dsStok.Clear()
            'dsStok.Relations.Clear()

            daStok = New SqlDataAdapter(New SqlCommand("select ROW_NUMBER() OVER (ORDER BY kd_stok) as 'nomor',*  " & _
            "  from INV.dbo.v_monstok_aseli " & _
            "  where bultah = '" & X & "'", sqlconn))

            daStok.Fill(dsStok, "stok")


            'daStokDet = New SqlDataAdapter(New SqlCommand("select * from INV.dbo.INV_STOK_GUDANG where kd_stok + bultah in (select kd_stok + bultah from INV.dbo.v_monstok_aseli where bultah = '" & X & "' )", sqlconn))
            daStokDet = New SqlDataAdapter(New SqlCommand("select B.Kode_Gudang ,B.Nama_Gudang,A.akhir_qty,B.Keterangan,A.kd_stok ,A.bultah ,A.kd_satuan ,A.kd_ukuran ,A.panjang ,A.lebar ,A.tinggi    " & _
            "  from INV.dbo.INV_STOK_GUDANG A,SIF.dbo.SIF_Gudang B  " & _
            "  where A.kode_gudang = B.Kode_Gudang and bultah =  '" & X & "' and kd_stok in (select kd_stok from INV.dbo.v_monstok_aseli  where bultah = '" & X & "')", sqlconn))
            'MsgBox(lookupBulanAwal.EditValue)
            daStokDet.Fill(dsStok, "stok_det")

            Dim colM(6) As DataColumn
            colM(0) = dsStok.Tables("stok").Columns("kd_Stok")
            colM(1) = dsStok.Tables("stok").Columns("bultah")
            colM(2) = dsStok.Tables("stok").Columns("kd_ukuran")
            colM(3) = dsStok.Tables("stok").Columns("kd_satuan")

            colM(4) = dsStok.Tables("stok").Columns("panjang")
            colM(5) = dsStok.Tables("stok").Columns("lebar")
            colM(6) = dsStok.Tables("stok").Columns("tinggi")

            Dim colD(6) As DataColumn
            colD(0) = dsStok.Tables("stok_det").Columns("kd_Stok")
            colD(1) = dsStok.Tables("stok_det").Columns("bultah")
            colD(2) = dsStok.Tables("stok_det").Columns("kd_ukuran")
            colD(3) = dsStok.Tables("stok_det").Columns("kd_satuan")

            colD(4) = dsStok.Tables("stok_det").Columns("panjang")
            colD(5) = dsStok.Tables("stok_det").Columns("lebar")
            colD(6) = dsStok.Tables("stok_det").Columns("tinggi")

            rl = dsStok.Relations.Add("StokToGudang", colM(0), colD(0), False)
            'rl = dsStok.Relations.Add("Relation_stok_1", dsStok.Tables("stok").Columns("kd_Stok"), dsStok.Tables("stok_det").Columns("kd_Stok"))
            'r2 = dsStok.Relations.Add("Relation_stok_2", dsStok.Tables("stok").Columns("bultah"), dsStok.Tables("stok_det").Columns("bultah"))

            GC1.DataSource = dsStok.Tables("stok")

            GC1.LevelTree.Nodes.Add("StokToGudang", GV1Det)
            'GC1.LevelTree.Nodes.Add("Relation_stok_2", GV1Det)

            GV1.BestFitColumns()
            GV1Det.BestFitColumns()

        Catch ex As Exception
            lblError1.Text = ex.Message & " , " & "Ada kesalahan data Stok"
        End Try
    End Sub

    Sub searchStokGudang(Optional ByVal X As String = "")
        Try


            If Not dsStokGudang.Tables("stok_gudang") Is Nothing Then
                dsStokGudang.Tables("stok_gudang").Clear()
            End If


            If Not dsStokGudang.Tables("stok_det_gudang") Is Nothing Then
                dsStokGudang.Tables("stok_det_gudang").Clear()
            End If

            daStokGudang = New SqlDataAdapter(New SqlCommand(" select B.Kode_Gudang ,B.Nama_Gudang, A.kd_stok, A.bultah,A.akhir_qty " & _
            "  from INV.dbo.INV_STOK_GUDANG A,SIF.dbo.SIF_Gudang B  " & _
            "  where A.kode_gudang = B.Kode_Gudang  " & _
            "  and bultah = '" & X & "'", sqlconn))

            daStokGudang.Fill(dsStokGudang, "stok_gudang")

            daStokGudangDet = New SqlDataAdapter(New SqlCommand("select ROW_NUMBER() OVER (ORDER BY kd_stok) as 'nomor',*  " & _
            "  from INV.dbo.v_monstok_aseli where  kd_stok + bultah in  " & _
            "  (select A.kd_stok + A.bultah  " & _
            "  from INV.dbo.INV_STOK_GUDANG A,SIF.dbo.SIF_Gudang B  " & _
            "  where A.kode_gudang = B.Kode_Gudang  " & _
            "  and bultah = '" & X & "') ", sqlconn))

            daStokGudangDet.Fill(dsStokGudang, "stok_det_gudang")

            Dim colX(1) As DataColumn
            colX(0) = dsStokGudang.Tables("stok_gudang").Columns("kd_Stok")
            colX(1) = dsStokGudang.Tables("stok_gudang").Columns("bultah")

            Dim colY(1) As DataColumn
            colY(0) = dsStokGudang.Tables("stok_det_gudang").Columns("kd_Stok")
            colY(1) = dsStokGudang.Tables("stok_det_gudang").Columns("bultah")

            r2 = dsStokGudang.Relations.Add("GudangToStok", colX, colY)

            'GC2.DataSource = dsStokGudang.Tables("stok_gudang")

            'GC2.LevelTree.Nodes.Add("GudangToStok", GV2Det)

            'GV2.BestFitColumns()
            'GV2Det.BestFitColumns()


        Catch ex As Exception
            lblError2.Text = ex.Message & " , " & "Ada kesalahan data Gudang"
        End Try
    End Sub

    Sub GudangDanStok(Optional ByVal X As String = "")

        'dsStokGudang.Clear()
        daStokGudang = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select ROW_NUMBER() OVER (ORDER BY A.kd_stok) as 'nomor',  " & _
        "  B.Kode_Gudang ,B.Nama_Gudang, A.kd_stok, A.bultah, C.Nama_Barang,sum(A.akhir_qty)as akhir_qty,  " & _
        "  C.Kd_Satuan, C.kd_merk, C.kd_tipe,C.kd_sub_tipe,C.kd_kain,C.kd_ukuran  " & _
        "  from INV.dbo.INV_STOK_GUDANG A,SIF.dbo.SIF_Gudang B, INV.dbo.v_monstok_aseli C   " & _
        "  where(A.kode_gudang = B.Kode_Gudang)  " & _
        "  and A.kd_stok = C.kd_stok  " & _
        "  and A.bultah =  C.bultah  " & _
        "  and A.bultah = '" & X & "'  " & _
        "  group by B.Kode_Gudang ,B.Nama_Gudang, A.kd_stok, A.bultah,C.Nama_Barang,C.Kd_Satuan,C.kd_merk,C.kd_tipe,C.kd_sub_tipe,C.kd_kain,C.kd_ukuran", sqlconn))
        daStokGudang.Fill(dsStokGudang, "stok_gudang")
        GC2.DataSource = dsStokGudang.Tables("stok_gudang")
        GV2.BestFitColumns()
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

        dsStok.Clear()
        dsStok.Relations.Clear()

        dsStokGudang.Clear()
        dsStokGudang.Relations.Clear()

        lblError1.Text = ""
        lblError2.Text = ""

        'lblLoad1.Visible = True
        lblLoad2.Visible = True

        'lblLoad1.Refresh()
        lblLoad2.Refresh()

        searchStok(lookupBulanAwal.EditValue)
        'searchStokGudang(lookupBulanAwal.EditValue)
        'GudangDanStok(lookupBulanAwal.EditValue)

        'lblLoad1.Visible = False
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

        For j As Integer = 0 To CCKListBoxKolom2.Items.Count - 1
            GV2.Columns(j).Visible = False
        Next

        'show selected
        For a As Integer = 0 To GV1.Columns.Count - 1
            For i As Integer = 0 To CCKListBoxKolom.Items.Count - 1
                'MsgBox(CCKListBoxKolom.Items(i).ToString)
                If GV1.Columns(a).Caption = CCKListBoxKolom.Items(i).Value And CCKListBoxKolom.Items(i).CheckState = CheckState.Checked Then
                    GV1.Columns(a).Visible = True
                End If
            Next
        Next

        For b As Integer = 0 To GV2.Columns.Count - 1
            For j As Integer = 0 To CCKListBoxKolom2.Items.Count - 1
                'MsgBox(CCKListBoxKolom.Items(i).ToString)
                If GV2.Columns(b).Caption = CCKListBoxKolom.Items(j).Value And CCKListBoxKolom.Items(j).CheckState = CheckState.Checked Then
                    GV2.Columns(b).Visible = True
                End If
            Next
        Next
    End Sub

    Private Sub Allcmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Allcmd.Click
        For i As Integer = 0 To CCKListBoxKolom.Items.Count - 1
            CCKListBoxKolom.Items(i).CheckState = CheckState.Checked
        Next

        For j As Integer = 0 To CCKListBoxKolom2.Items.Count - 1
            CCKListBoxKolom2.Items(j).CheckState = CheckState.Checked
        Next
    End Sub

    Private Sub ResetCmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetCmd.Click
        For i As Integer = 0 To CCKListBoxKolom.Items.Count - 1
            CCKListBoxKolom.Items(i).CheckState = CheckState.Unchecked
        Next

        For j As Integer = 0 To CCKListBoxKolom2.Items.Count - 1
            CCKListBoxKolom2.Items(j).CheckState = CheckState.Unchecked
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

    Private Sub CEMonStok_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEMonStok.CheckedChanged
        If CEMonStok.Checked = True Then
            CEMonStokGud.Checked = False

            SCpnlMaster.SplitterPosition = 1000
        Else
            CEMonStokGud.Checked = True

            SCpnlMaster.SplitterPosition = 0
        End If
    End Sub

    Private Sub CEMonStokGud_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEMonStokGud.CheckedChanged
        If CEMonStokGud.Checked = True Then
            CEMonStok.Checked = False

            SCpnlMaster.SplitterPosition = 0
        Else
            CEMonStok.Checked = True

            SCpnlMaster.SplitterPosition = 1000
        End If
    End Sub

    Private Sub CEStokMerah_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEStokMerah.CheckedChanged
        If CEStokMerah.Checked = True Then
            GV1.ActiveFilterString = "akhir_qty_onstok <= stok_min  *  lead_time  "
        Else
            GV1.ActiveFilterString = False
        End If
    End Sub

    Private Sub CEStokHijau_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEStokHijau.CheckedChanged
        If CEStokHijau.Checked = True Then
            GV1.ActiveFilterString = "akhir_qty_onstok >= stok_min  *  lead_time  "
        Else
            GV1.ActiveFilterString = False
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

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        DxErrorProvider1.ClearErrors()

        If CEMonStokFull.Checked = False And CEMonStokGudangFull.Checked = False Then
            DxErrorProvider1.SetError(CEMonStokFull, "Silahkan pilih salah satu", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Information)
            DxErrorProvider1.SetError(CEMonStokGudangFull, "Silahkan pilih salah satu", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Information)
        End If

        If CEMonStokFull.Checked = True Then
            GV1.FormatConditions.Item(0).Appearance.BackColor = Color.White
            GV1.FormatConditions.Item(1).Appearance.BackColor = Color.White
            ShowGridPreview(GV1.GridControl)
            GV1.FormatConditions.Item(0).Appearance.BackColor = Color.LightCoral
            GV1.FormatConditions.Item(1).Appearance.BackColor = Color.LightGreen
        End If

        If CEMonStokGudangFull.Checked = True Then
            ShowGridPreview(GV2.GridControl)
        End If

    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEMonStokFull.CheckedChanged
        If CEMonStokFull.Checked = False And CEMonStokGudangFull.Checked = False Then
            SCpnlMaster.SplitterPosition = SCpnlMaster.Size.Height / 2
        ElseIf CEMonStokFull.Checked = True And CEMonStokGudangFull.Checked = True Then
            SCpnlMaster.SplitterPosition = SCpnlMaster.Size.Height / 2
        ElseIf CEMonStokFull.Checked = True And CEMonStokGudangFull.Checked = False Then
            SCpnlMaster.SplitterPosition = SCpnlMaster.Size.Height
        Else
            SCpnlMaster.SplitterPosition = 0
        End If

    End Sub

    Private Sub CheckEdit2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEMonStokGudangFull.CheckedChanged
        If CEMonStokFull.Checked = False And CEMonStokGudangFull.Checked = False Then
            SCpnlMaster.SplitterPosition = SCpnlMaster.Size.Height / 2
        ElseIf CEMonStokFull.Checked = True And CEMonStokGudangFull.Checked = True Then
            SCpnlMaster.SplitterPosition = SCpnlMaster.Size.Height / 2
        ElseIf CEMonStokGudangFull.Checked = True And CEMonStokFull.Checked = False Then
            SCpnlMaster.SplitterPosition = 0
        Else
            SCpnlMaster.SplitterPosition = SCpnlMaster.Size.Height
        End If
    End Sub

  
    Private Sub GV1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV1.Click
        If Not dsStokGudang.Tables("stok_gudang") Is Nothing Then
            dsStokGudang.Tables("stok_gudang").Clear()
        End If
        daStokGudang = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select ROW_NUMBER() OVER (ORDER BY A.kd_stok) as 'nomor',  " & _
        "  B.Kode_Gudang ,B.Nama_Gudang, A.kd_stok, A.bultah, C.Nama_Barang,sum(A.akhir_qty)as akhir_qty,  " & _
        "  C.Kd_Satuan, C.kd_merk, C.kd_tipe,C.kd_sub_tipe,C.kd_kain,C.kd_ukuran  " & _
        "  from INV.dbo.INV_STOK_GUDANG A,SIF.dbo.SIF_Gudang B, INV.dbo.v_monstok_aseli C   " & _
        "  where(A.kode_gudang = B.Kode_Gudang)  " & _
        "  and A.kd_stok = C.kd_stok  " & _
        "  and A.bultah =  C.bultah  " & _
        "  and A.kd_stok = '" & GV1.GetFocusedRowCellValue("Kode_Barang") & "' and A.bultah='" & lookupBulanAwal.EditValue & "' " & _
        "  group by B.Kode_Gudang ,B.Nama_Gudang, A.kd_stok, A.bultah,C.Nama_Barang,C.Kd_Satuan,C.kd_merk,C.kd_tipe,C.kd_sub_tipe,C.kd_kain,C.kd_ukuran", sqlconn))
        daStokGudang.Fill(dsStokGudang, "stok_gudang")
        GC2.DataSource = dsStokGudang.Tables("stok_gudang")
        GV2.BestFitColumns()
    End Sub
End Class