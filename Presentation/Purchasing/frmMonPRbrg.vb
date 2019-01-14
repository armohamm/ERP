'|-----------------------
'|  CREATED BY RENDY    |
'|  EDITED BY RENDY     |
'|-----------------------
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports System.Threading
Public Class frmMonPRbrg
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
    Private Sub frmMonPRbrg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True

        loadNoPR()
        LoadLOV()

        For a As Integer = 0 To GV1.Columns.Count - 1
            CCKListBoxKolom.Items.Add(GV1.Columns(a).Caption)
        Next

        pnlGridLeft.Visible = False
        Allcmd.Visible = False
        ResetCmd.Visible = False

        'LoadGrid1()
        'LoadGrid2()
    End Sub


    Sub loadNoPR()
        If Not dsLookUp.Tables("LUNoPR") Is Nothing Then dsLookUp.Tables("LUNoPR").Clear()
        daLookUp = New SqlDataAdapter(New SqlCommand("select distinct(no_pr)from PURC.dbo.PURC_PR_D", sqlconn))
        daLookUp.Fill(dsLookUp, "LUNoPR")
        LookUpPR.Properties.DataSource = dsLookUp.Tables("LUNoPR")
        LookUpPR.Properties.DisplayMember = "no_pr"
        LookUpPR.Properties.ValueMember = "no_pr"
    End Sub


    Sub LoadLOV()
        dsLOV.Clear()
        '1
        daBrg = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Barang ", sqlconn))
        daBrg.Fill(dsLOV, "barang")
        LOVbarang.Properties.DataSource = dsLOV.Tables("barang")
        LOVbarang.Properties.DisplayMember = "Nama_Barang"
        LOVbarang.Properties.ValueMember = "Kode_Barang"

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
        daStokGudang = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_Gudang A, INV.dbo.INV_STOK_GUDANG B where A.Kode_Gudang = B.kode_gudang ", sqlconn))
        daStokGudang.Fill(dsStokGudang, "detstok")
        'GC2.DataSource = dsStokGudang.Tables("detstok")
        'GV2.BestFitColumns()

    End Sub

    Sub searchStok(Optional ByVal X As String = "")
        Try

            If Not dsStok.Tables("stok") Is Nothing Then
                dsStok.Tables("stok").Clear()
            End If

            daStok = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_PR_D " & _
            "  where no_pr = '" & X & "'", sqlconn))

            daStok.Fill(dsStok, "stok")

            GC1.DataSource = dsStok.Tables("stok")

            GV1.BestFitColumns()

        Catch ex As Exception
            lblError1.Text = ex.Message & " , " & "Ada kesalahan data Purchase"
        End Try
    End Sub

    Private Sub lookupBulanAwal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Eksekusi()
    End Sub

    Sub Eksekusi()
        DxErrorProvider1.ClearErrors()

        If LookUpPR.EditValue = "" Then
            DxErrorProvider1.SetError(LookUpPR, "Silahkan pilih No PR", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            Exit Sub
        End If

        dsStok.Clear()
        dsStok.Relations.Clear()

        lblError1.Text = "..."
        lblError2.Text = "..."

        lblLoad2.Visible = True

        lblLoad2.Refresh()

        searchStok(LookUpPR.EditValue)
       
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

    Private Sub CEStokMerah_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEStokMerah.CheckedChanged
        If CEStokMerah.Checked = True Then
            GV1.ActiveFilterString = "stok_min  *  2 <= akhir_qty_onstok"
        Else
            GV1.ActiveFilterString = False
        End If
    End Sub

    Private Sub CEStokHijau_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEStokHijau.CheckedChanged
        If CEStokHijau.Checked = True Then
            GV1.ActiveFilterString = "stok_min  *  2 > akhir_qty_onstok"
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

        GV1.FormatConditions.Item(0).Appearance.BackColor = Color.White
        GV1.FormatConditions.Item(1).Appearance.BackColor = Color.White
        ShowGridPreview(GV1.GridControl)
        GV1.FormatConditions.Item(0).Appearance.BackColor = Color.LightCoral
        GV1.FormatConditions.Item(1).Appearance.BackColor = Color.LightGreen

    End Sub

    Private Sub LookUpPR_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LookUpPR.EditValueChanged
        Eksekusi()
    End Sub
End Class