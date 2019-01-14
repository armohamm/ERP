'|-----------------------
'|  CREATED BY RENDY    |
'|  EDITED BY RENDY     |
'|-----------------------
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports System.Drawing
Imports DevExpress.XtraPrinting

Public Class frmMonHutUsLain

    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim err As String = ""
    Dim isvalid As Boolean

    Dim dsUsaha, dsLain, dsTipeTrans, dsSupp, dsBB, dsBarang, dsDept As New DataSet
    Dim daUsaha, daLain, daTipeTrans, daSupp, daBB, daBarang As SqlDataAdapter

    Private Sub frmMonHutUsLain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)

        loadLookUP()
        Me.Enabled = True
        GV.BestFitColumns()
        tglDari.EditValue = getTanggal()
        tglsampai.EditValue = getTanggal()

        For a As Integer = 0 To GV.Columns.Count - 1
            CCKListBoxKolom.Items.Add(GV.Columns(a).Caption)
            CCKBOXcolom.Properties.Items.Add(GV.Columns(a).Caption)
        Next

        pnlGridLeft.Visible = False
        Allcmd.Visible = False
        ResetCmd.Visible = False
    End Sub

    Sub loadLookUP()
        dsDept.Clear()
        daTipeTrans = New SqlDataAdapter(New SqlCommand("select Kd_Departemen, Nama_Departemen from SIF.dbo.SIF_Departemen", sqlconn))
        daTipeTrans.Fill(dsDept, "dept")
        RepDepartemen.DataSource = dsDept.Tables("dept")
        RepDepartemen.DisplayMember = "Nama_Departemen"
        RepDepartemen.ValueMember = "Kd_Departemen"

        dsTipeTrans.Clear()
        daTipeTrans = New SqlDataAdapter(New SqlCommand("select distinct(A.tipe_trans),A.kd_jurnal,A.kd_subsis ,A.tipe_desc  from SIF.dbo.SIF_TIPE_TRANS A ,FIN.dbo.v_trans_AP B where A.tipe_trans = B.tipe_trans  ", sqlconn))
        daTipeTrans.Fill(dsTipeTrans, "tipe")
        LOVtipe.Properties.DataSource = dsTipeTrans.Tables("tipe")
        LOVtipe.Properties.DisplayMember = "tipe_desc"
        LOVtipe.Properties.ValueMember = "kd_jurnal"

        dsSupp.Clear()
        daSupp = New SqlDataAdapter(New SqlCommand("select nama,kode from FIN.dbo.v_kartu", sqlconn))
        daSupp.Fill(dsSupp, "kartu")
        LOVKartu.DataSource = dsSupp.Tables("kartu")
        LOVKartu.DisplayMember = "nama"
        LOVKartu.ValueMember = "kode"

        dsBB.Clear()
        daBB = New SqlDataAdapter(New SqlCommand("select kd_buku_besar,nm_buku_besar from SIF.dbo.SIF_buku_besar", sqlconn))
        daBB.Fill(dsBB, "rekening")
        LOVrekening.DataSource = dsBB.Tables("rekening")
        LOVrekening.DisplayMember = "nm_buku_besar"
        LOVrekening.ValueMember = "kd_buku_besar"

        dsBarang.Clear()
        daBarang = New SqlDataAdapter(New SqlCommand("select * from sif.dbo.sif_barang", sqlconn))
        daBarang.Fill(dsBarang, "barang")
        RepBarang.DataSource = dsBarang.Tables("barang")
        RepBarang.DisplayMember = "Nama_Barang"
        RepBarang.ValueMember = "Kode_Barang"
    End Sub

    Sub loadData()
        Dim sql As String = ""

        If Not tglDari.EditValue > tglsampai.EditValue Then
            sql = " tgl_posting between convert(date, '" & tglDari.EditValue & "',103) and convert(date, '" & tglsampai.EditValue & "',103)"
        Else
            ErrorProvider1.SetError(tglDari, "Tanggal dari tidak boleh lebih Dari tanggal sampai")
            Exit Sub
        End If

        If LOVtipe.EditValue = "JPP" Or CEUsaha.Checked = True Then
            If Not dsUsaha.Tables("gridUsaha") Is Nothing Then dsUsaha.Tables("gridUsaha").Clear()
            daUsaha = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select ROW_NUMBER() OVER (ORDER BY no_inv) as 'nomor',* from FIN.dbo.v_trans_AP where tipe_trans like 'JPP%' and" & sql, sqlconn))

            daUsaha.Fill(dsUsaha, "gridUsaha")
            GC.DataSource = dsUsaha.Tables("gridUsaha")
            GV.BestFitColumns()
        ElseIf LOVtipe.EditValue = "JKM" Or CELain.Checked = True Then
            If Not dsUsaha.Tables("gridLain") Is Nothing Then dsUsaha.Tables("gridLain").Clear()
            daUsaha = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select ROW_NUMBER() OVER (ORDER BY no_inv) as 'nomor',* from FIN.dbo.v_trans_AP where tipe_trans like 'JKM%' and" & sql, sqlconn))

            daUsaha.Fill(dsUsaha, "gridLain")
            GC.DataSource = dsUsaha.Tables("gridLain")
            GV.BestFitColumns()
        ElseIf LOVtipe.EditValue = vbNullString Or LOVtipe.EditValue = "" Then
            If Not dsUsaha.Tables("gridAll") Is Nothing Then dsUsaha.Tables("gridAll").Clear()
            daUsaha = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select ROW_NUMBER() OVER (ORDER BY no_inv) as 'nomor',* from FIN.dbo.v_trans_AP where" & sql, sqlconn))

            daUsaha.Fill(dsUsaha, "gridAll")
            GC.DataSource = dsUsaha.Tables("gridAll")
            GV.BestFitColumns()
        End If
    End Sub

    Private Sub CEUsaha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEUsaha.CheckedChanged
        If CEUsaha.Checked = True Then
            CELain.Checked = False
        Else
            CELain.Checked = True
        End If

        loadData()
    End Sub

    Private Sub CELain_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CELain.CheckedChanged
        If CELain.Checked = True Then
            CEUsaha.Checked = False
        Else
            CEUsaha.Checked = True
        End If

        loadData()
    End Sub

    Private Sub CCKListBoxKolom_ItemCheck(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ItemCheckEventArgs) Handles CCKListBoxKolom.ItemCheck
        'reset
        For i As Integer = 0 To CCKListBoxKolom.Items.Count - 1
            GV.Columns(i).Visible = False
        Next

        'show selected
        For a As Integer = 0 To GV.Columns.Count - 1
            For i As Integer = 0 To CCKListBoxKolom.Items.Count - 1
                'MsgBox(CCKListBoxKolom.Items(i).ToString)
                If GV.Columns(a).Caption = CCKListBoxKolom.Items(i).Value And CCKListBoxKolom.Items(i).CheckState = CheckState.Checked Then
                    GV.Columns(a).Visible = True
                End If
            Next
        Next

    End Sub

    Private Sub CCKBOXcolom_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CCKBOXcolom.TextChanged

        For i As Integer = 0 To CCKBOXcolom.Properties.Items.Count - 1
            GV.Columns(i).Visible = False
        Next

        For a As Integer = 0 To CCKListBoxKolom.Items.Count - 1
            For i As Integer = 0 To CCKBOXcolom.Properties.Items.Count - 1
                'MsgBox(CCKListBoxKolom.Items(i).ToString)
                If CCKListBoxKolom.Items(a).ToString = CCKBOXcolom.Properties.Items(i).Value And CCKBOXcolom.Properties.Items(i).CheckState = CheckState.Checked Then
                    CCKListBoxKolom.Items(i).CheckState = CheckState.Checked
                    'GV.Columns(a).Visible = True
                End If
            Next
        Next

    End Sub

    Private Sub BtnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetCmd.Click
        For i As Integer = 0 To CCKListBoxKolom.Items.Count - 1
            CCKListBoxKolom.Items(i).CheckState = CheckState.Unchecked
        Next
    End Sub

    Private Sub Allcmd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Allcmd.Click
        For i As Integer = 0 To CCKListBoxKolom.Items.Count - 1
            CCKListBoxKolom.Items(i).CheckState = CheckState.Checked
        Next
    End Sub

    Private Sub LOVtipe_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOVtipe.EditValueChanged
        'If LOVtipe.EditValue = "JPP" Then
        '    LoadGridUsaha()
        'ElseIf LOVtipe.EditValue = "JKM" Then
        '    LoadGridLain()
        'End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CCKBOXSetting.CheckedChanged
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

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        loadData()
    End Sub

    'Sub ShowGridPreview(ByVal grid As DevExpress.XtraGrid.GridControl)
    '    ' Check whether the XtraGrid control can be previewed. 
    '    If Not grid.IsPrintingAvailable Then
    '        MessageBox.Show("The 'DevExpress.XtraPrinting' Library is not found", "Error")
    '        Return
    '    End If
    '    ' Opens the Preview window. 
    '    grid.ShowPreview()
    'End Sub

    'Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
    '    ShowGridPreview(GC)
    'End Sub

    Public Sub cetak_click()
        If Not GV.RowCount <= 0 Then
            'ShowGridPreview(gcGiro)
            Dim ph As DevExpress.XtraPrinting.PageHeaderFooter = CType(PrintableComponentLink1.PageHeaderFooter, PageHeaderFooter)
            ph.Footer.Content.Add(username)
            ph.Footer.Content.Add("")
            ph.Footer.Content.Add("Hal. [Page #]")

            PrintableComponentLink1.CreateDocument()
            PrintableComponentLink1.ShowPreview()
        Else
            MsgBox("Tidak ada data yang dicetak. Silahkan mengisi filter diatas lalu menekan tombol Refresh.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
        End If
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        If Not GV.RowCount <= 0 Then
            'ShowGridPreview(gcGiro)
            Dim ph As DevExpress.XtraPrinting.PageHeaderFooter = CType(PrintableComponentLink1.PageHeaderFooter, PageHeaderFooter)
            ph.Footer.Content.Add(username)
            ph.Footer.Content.Add("")
            ph.Footer.Content.Add("Hal. [Page #]")

            PrintableComponentLink1.CreateDocument()
            PrintableComponentLink1.ShowPreview()
        Else
            MsgBox("Tidak ada data yang dicetak. Silahkan mengisi filter diatas lalu menekan tombol Refresh.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
        End If
    End Sub
End Class