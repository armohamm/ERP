'|-----------------------
'|  CREATED BY RENDY    |
'|  EDITED BY RENDY     |
'|-----------------------
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Public Class frmMonJurnal

    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = True
    Public prn As frmMain
    Dim err As String = ""
    Dim isvalid As Boolean
    Dim rl, r2 As DataRelation

    Dim dsLookUp, dsJur, dsLOV As New DataSet
    Dim daLookUp, daValuta, daJur, daTipe, daFiltTipe, daJurDet, daKartu, daRek, daPus, daBrg As SqlDataAdapter

    Private Sub frmMonJurnal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True

        LoadLOV()

        pnlGridLeft.Visible = False
        Allcmd.Visible = False
        ResetCmd.Visible = False

        For a As Integer = 0 To GV1.Columns.Count - 1
            CCKListBoxKolom.Items.Add(GV1.Columns(a).Caption)
        Next

        tglDari.EditValue = getTanggal()
        tglSampai.EditValue = getTanggal()

        LOVvaluta.EditValue = "IDR"
    End Sub

    Sub LoadLOV()
        dsLOV.Clear()
        '1
        daValuta = New SqlDataAdapter(New SqlCommand("select Nama_Valuta, Kode_Valuta from KOPKAR.dbo.SIF_Valuta ", sqlconn))
        daValuta.Fill(dsLOV, "valuta")
        LOVvaluta.Properties.DataSource = dsLOV.Tables("valuta")
        LOVvaluta.Properties.DisplayMember = "Nama_Valuta"
        LOVvaluta.Properties.ValueMember = "Kode_Valuta"
        '2
        daJur = New SqlDataAdapter(New SqlCommand("select Desc_Data, Id_Data from KOPKAR.dbo.SIF_Gen_Reff_D where Id_Ref_Data = 'JNSJUR'", sqlconn))
        daJur.Fill(dsLOV, "jurnal")
        LOVjurnal.Properties.DataSource = dsLOV.Tables("jurnal")
        LOVjurnal.Properties.DisplayMember = "Desc_Data"
        LOVjurnal.Properties.ValueMember = "Id_Data"
        '3
        daTipe = New SqlDataAdapter(New SqlCommand("select tipe_desc, tipe_trans from KOPKAR.dbo.SIF_TIPE_TRANS", sqlconn))
        daTipe.Fill(dsLOV, "tipe")
        LOVtipeTrans.Properties.DataSource = dsLOV.Tables("tipe")
        LOVtipeTrans.Properties.DisplayMember = "tipe_desc"
        LOVtipeTrans.Properties.ValueMember = "tipe_trans"
        leTipetrans.DataSource = dsLOV.Tables("tipe")
        leTipetrans.DisplayMember = "tipe_desc"
        leTipetrans.ValueMember = "tipe_trans"
        '4
        daKartu = New SqlDataAdapter(New SqlCommand("select nama, kode from KOPKAR.dbo.v_kartu", sqlconn))
        daKartu.Fill(dsLOV, "kartu")
        LOVkartu.Properties.DataSource = dsLOV.Tables("kartu")
        LOVkartu.Properties.DisplayMember = "nama"
        LOVkartu.Properties.ValueMember = "kode"
        '5
        daRek = New SqlDataAdapter(New SqlCommand("select nm_buku_besar, kd_buku_besar from KOPKAR.dbo.m_buku_besar", sqlconn))
        daRek.Fill(dsLOV, "rekening")
        LOVrekening.Properties.DataSource = dsLOV.Tables("rekening")
        LOVrekening.Properties.DisplayMember = "nm_buku_besar"
        LOVrekening.Properties.ValueMember = "kd_buku_besar"
        '6
        daPus = New SqlDataAdapter(New SqlCommand("SELECT Id_Data kd_buku_pusat, Desc_Data nm_buku_pusat FROM KOPKAR.dbo.SIF_Gen_Reff_D WHERE Id_Ref_Data = 'UNITKOPKAR' AND Rec_Stat = 'Y' ", sqlconn))
        daPus.Fill(dsLOV, "pusat")
        LOVpusat.Properties.DataSource = dsLOV.Tables("pusat")
        LOVpusat.Properties.DisplayMember = "nm_buku_pusat"
        LOVpusat.Properties.ValueMember = "kd_buku_pusat"
        '7
        'daBrg = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang ", sqlconn))
        'daBrg.Fill(dsLOV, "barang")
        'LOVBarang.Properties.DataSource = dsLOV.Tables("barang")
        'LOVBarang.Properties.DisplayMember = "Nama_Barang"
        'LOVBarang.Properties.ValueMember = "Kode_Barang"


    End Sub

    Sub autoSelect()
        dsLOV.Tables("tipe").Clear()

        daFiltTipe = New SqlDataAdapter(New SqlCommand("select A.* from KOPKAR.dbo.SIF_TIPE_TRANS A,KOPKAR.dbo.SIF_Gen_Reff_D B  " & _
        "  where A.kd_jurnal = B.Id_Data " & _
        "  and B.Id_Ref_Data = 'JNSJUR' " & _
        "  and B.Id_Data = '" & LOVjurnal.EditValue & "'", sqlconn))
        daFiltTipe.Fill(dsLOV, "tipe")
        LOVtipeTrans.Properties.DataSource = dsLOV.Tables("tipe")
        LOVtipeTrans.Properties.DisplayMember = "tipe_desc"
        LOVtipeTrans.Properties.ValueMember = "tipe_trans"
    End Sub

    Private Sub LOVjurnal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOVjurnal.EditValueChanged
        autoSelect()

        If LOVjurnal.EditValue = vbNullString Then
            LOVtipeTrans.EditValue = vbNullString
        End If
    End Sub

    Sub searchJurnal(Optional ByVal jurnal As String = "", Optional ByVal tipe As String = "", Optional ByVal tgldari As String = "", Optional ByVal tglsampai As String = "", Optional ByVal valuta As String = "")
        'Try

        If Not dsJur.Tables("jurnal") Is Nothing Then dsJur.Tables("jurnal").Clear()
        If Not dsJur.Tables("jurnal_d") Is Nothing Then dsJur.Tables("jurnal_d").Clear()

        'dsStok.Clear()
        'dsStok.Relations.Clear()
        Dim sql As String = ""
        Dim sqlNoJur As String = ""

        If CEPost.Checked = True Then
            '    sql &= " not (no_posting = '' or no_posting is null) "
            'Else
            '    sql &= " (no_posting = '' or no_posting is null) "
        End If

        If Not LOVjurnal.EditValue = vbNullString Then
            sql &= " and LEFT(tipe_trans ,3)='" & jurnal & "' "
        End If

        If Not LOVtipeTrans.EditValue = vbNullString Then
            sql &= " and tipe_trans = '" & tipe & "' "
        End If

        sqlNoJur = "select no_jur from KOPKAR.dbo.FIN_JURNAL " & _
                    "where tgl_trans between convert(date,'" & tgldari & "',103) and convert(date,'" & tglsampai & "',103) "

        sql = "select *, null as alasan_salah, CASE WHEN (no_posting IS NULL OR no_posting = '') THEN 'Belum Posting' ELSE 'Sudah Posting' END 'stat' from KOPKAR.dbo.FIN_JURNAL " & _
                "where tgl_trans between convert(date,'" & tgldari & "',103) and convert(date,'" & tglsampai & "',103) "

        daJur = New SqlDataAdapter(New SqlCommand(sql, sqlconn))

        daJur.Fill(dsJur, "jurnal")

        daJurDet = New SqlDataAdapter(New SqlCommand("select ROW_NUMBER() OVER (ORDER BY no_jur) as 'no',* from KOPKAR.dbo.FIN_JURNAL_D d where no_jur in (" & sqlNoJur & ") ", sqlconn))


        daJurDet.SelectCommand.CommandTimeout = 0
        daJurDet.Fill(dsJur, "jurnal_d")

        'Dim colA(0) As DataColumn
        'colA(0) = dsJur.Tables("jurnal").Columns("no_jur")

        'Dim colB(0) As DataColumn
        'colB(0) = dsJur.Tables("jurnal_d").Columns("no_jur")

        'rl = dsJur.Relations.Add("JurDet", colA, colB)
        rl = dsJur.Relations.Add("RelJurDet", dsJur.Tables("jurnal").Columns("no_jur"), dsJur.Tables("jurnal_d").Columns("no_jur"))

        GC1.DataSource = dsJur.Tables("jurnal")

        GC1.LevelTree.Nodes.Add("RelJurDet", GV2)

        'Catch ex As Exception
        '    lblError1.Text = ex.Message & " , " & "Ada kesalahan data "
        'End Try
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExe.Click
        dsJur.Clear()
        dsJur.Relations.Clear()
        lblError1.Text = "..."
        LoadLOV()
        If tglDari.EditValue > tglSampai.EditValue Then
            MsgBox("Tanggal dari lebih besar dari sampai", MsgBoxStyle.Critical, vbOK)
        Else
            searchJurnal(LOVjurnal.EditValue, LOVtipeTrans.EditValue, tglDari.EditValue, tglSampai.EditValue, LOVvaluta.EditValue)

            GV1.BestFitColumns()
            For Each col As GridColumn In GV2.Columns
                col.BestFit()
            Next
        End If

    End Sub

    Public Sub cetak_click()
        print_gc(GC1, "TRANSAKSI JURNAL")
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        print_gc(GC1, "TRANSAKSI JURNAL")
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        LOVjurnal.EditValue = vbNullString
        LOVtipeTrans.EditValue = vbNullString
    End Sub

    Private Sub CEPost_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEPost.CheckedChanged
        If CEPost.Checked = True Then
            CENoPost.Checked = False
        Else
            CENoPost.Checked = True
        End If
    End Sub

    Private Sub CENoPost_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CENoPost.CheckedChanged
        If CENoPost.Checked = True Then
            CEPost.Checked = False
        Else
            CEPost.Checked = True
        End If
    End Sub

    Private Sub LOVtipeTrans_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOVtipeTrans.EditValueChanged
        If LOVjurnal.EditValue = vbNullString Then
            LOVtipeTrans.EditValue = vbNullString
        End If
    End Sub

    Private Sub LOVvaluta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOVvaluta.EditValueChanged
        If LOVvaluta.EditValue = vbNullString Then
            LOVvaluta.ItemIndex = 3
        End If
    End Sub

    Private Sub CCKListBoxKolom_ItemCheck(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles CCKListBoxKolom.ItemCheck
        For i As Integer = 0 To CCKListBoxKolom.Items.Count - 1
            GV1.Columns(i).Visible = False
        Next

        For a As Integer = 0 To GV1.Columns.Count - 1
            For i As Integer = 0 To CCKListBoxKolom.Items.Count - 1
                'MsgBox(CCKListBoxKolom.Items(i).ToString)
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
End Class