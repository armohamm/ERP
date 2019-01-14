'|-----------------------
'|  CREATED BY RENDY    |
'|  EDITED BY RENDY     |
'|-----------------------
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class frmMonTransKasBon
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim err As String = ""
    Dim isvalid As Boolean
    Dim rl, r2 As DataRelation

    Dim dsLookUp, dsJur, dsLOV As New DataSet
    Dim daLookUp, daValuta, daJur, daTipe, daFiltTipe, daJurDet, daKartu, daRek, daPus As SqlDataAdapter
    Private Sub frmMonTransKasBon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        tglDariX.EditValue = getTanggal()
        tglSampaiX.EditValue = getTanggal()

        LOVvaluta.ItemIndex = 3
    End Sub

    Sub LoadLOV()
        dsLOV.Clear()
        '1
        daValuta = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Valuta ", sqlconn))
        daValuta.Fill(dsLOV, "valuta")
        LOVvaluta.Properties.DataSource = dsLOV.Tables("valuta")
        LOVvaluta.Properties.DisplayMember = "Nama_Valuta"
        LOVvaluta.Properties.ValueMember = "Kode_Valuta"
        '2
        daJur = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data = 'JNSJUR'", sqlconn))
        daJur.Fill(dsLOV, "jurnal")
        LOVjurnal.Properties.DataSource = dsLOV.Tables("jurnal")
        LOVjurnal.Properties.DisplayMember = "Desc_Data"
        LOVjurnal.Properties.ValueMember = "Id_Data"

        '3
        daTipe = New SqlDataAdapter(New SqlCommand("select distinct(A.tipe_trans),B.tipe_desc ,B.kd_subsis , B.kd_jurnal " & _
        "  from FIN.dbo.FIN_JURNAL A,SIF.dbo.SIF_TIPE_TRANS B   " & _
        "  where A.tipe_trans = B.tipe_trans and A.tipe_trans in ('JKK-KBB-04','JKK-KBB-03','JKM-KBB-03')", sqlconn))
        daTipe.Fill(dsLOV, "tipe")
        LOVtipeTrans.Properties.DataSource = dsLOV.Tables("tipe")
        LOVtipeTrans.Properties.DisplayMember = "tipe_desc"
        LOVtipeTrans.Properties.ValueMember = "tipe_trans"

        '4
        daKartu = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.v_kartu", sqlconn))
        daKartu.Fill(dsLOV, "kartu")
        LOVkartu.Properties.DataSource = dsLOV.Tables("kartu")
        LOVkartu.Properties.DisplayMember = "nama"
        LOVkartu.Properties.ValueMember = "kode"

        '5
        daRek = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_buku_besar", sqlconn))
        daRek.Fill(dsLOV, "rekening")
        LOVrekening.Properties.DataSource = dsLOV.Tables("rekening")
        LOVrekening.Properties.DisplayMember = "nm_buku_besar"
        LOVrekening.Properties.ValueMember = "kd_buku_besar"

        '6
        daPus = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_buku_pusat ", sqlconn))
        daPus.Fill(dsLOV, "pusat")
        LOVpusat.Properties.DataSource = dsLOV.Tables("pusat")
        LOVpusat.Properties.DisplayMember = "nm_buku_pusat"
        LOVpusat.Properties.ValueMember = "kd_buku_pusat"


    End Sub

    Sub autoSelect()
        dsLOV.Tables("tipe").Clear()

        daFiltTipe = New SqlDataAdapter(New SqlCommand("select A.* from SIF.dbo.SIF_TIPE_TRANS A,SIF.dbo.SIF_Gen_Reff_D B  " & _
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

    Sub LoadGrid1()

        dsJur.Clear()
        daJur = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select ROW_NUMBER() OVER (ORDER BY no_jur) as 'no',* from FIN.dbo.FIN_JURNAL ", sqlconn))
        daJur.Fill(dsJur, "jurnal")
        GC1.DataSource = dsJur.Tables("jurnal")
        GV1.BestFitColumns()

    End Sub

    Sub LoadGrid2()

        dsJur.Clear()
        daJurDet = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select ROW_NUMBER() OVER (ORDER BY no_jur) as 'no',* from FIN.dbo.FIN_JURNAL_D", sqlconn))
        daJurDet.Fill(dsJur, "jurnal_d")
        GC1.DataSource = dsJur.Tables("jurnal_d")
        GV2.BestFitColumns()

    End Sub
    Sub allJurnal(Optional ByVal jurnal As String = "", Optional ByVal tipe As String = "", Optional ByVal tgldari As String = "", Optional ByVal tglsampai As String = "", Optional ByVal valuta As String = "")
        'Try

        txtSaldoAwal.EditValue = "0"
        Dim dr As SqlDataReader = New SqlCommand("SELECT SIF.dbo.hitungsaldoawal('1011003', 'IDR','" & tglDariX.DateTime.Year & "', '" & tglDariX.DateTime.Month & "', '" & tglDariX.DateTime.Day & "')", sqlconn).ExecuteReader
        dr.Read()
        If dr.HasRows Then
            txtSaldoAwal.EditValue = dr.Item(0)

            Dim g As Long
            g = txtSaldoAwal.EditValue
            txtSaldoAwal.EditValue = Format(g, "##,##0")
        Else
            txtSaldoAwal.EditValue = "0"
        End If

        'If Not dsJur.Relations("RelJurDet") Is Nothing Then
        '    dsJur.Relations.Clear()
        'End If

        If Not dsJur.Tables("jurnal") Is Nothing Then
            dsJur.Tables("jurnal").Clear()
        End If

        If Not dsJur.Tables("jurnal_d") Is Nothing Then
            dsJur.Tables("jurnal_d").Clear()
        End If

        'dsStok.Clear()
        'dsStok.Relations.Clear()

        Dim sql As String = ""
        Dim sqlNoJur As String = ""


        'If CBEtipeTrans.EditValue = "Permohonan" Then
        '    sql &= " tipe_trans in ('JKK-KBB-03') "
        'End If

        'If CBEtipeTrans.EditValue = "Pelunasan" Then
        '    sql &= " tipe_trans in ('JKM-KBB-03','JKK-KBB-04') "
        'End If

        sqlNoJur = "   select A.no_jur from FIN.dbo.FIN_JURNAL A , FIN.dbo.FIN_JURNAL_D B   " & _
        "  where  A.no_jur = B.no_jur  " & _
        "  and B.kd_buku_besar ='1011001'  " & _
        "  and A.tgl_trans between  convert(date,'" & tgldari & "',103) and convert(date,'" & tglsampai & "',103)  " & _
        "  and A.tipe_trans in ('JKM-KBB-03','JKK-KBB-03','JKK-KBB-04') " & sql
      
        sql = " select ROW_NUMBER() OVER (ORDER BY A.no_jur) as 'no',A.*,A.no_jur, A.tgl_trans, B.saldo_val_Debet debet, B.saldo_val_kredit kredit  " & _
        "  from FIN.dbo.FIN_JURNAL A , FIN.dbo.FIN_JURNAL_D B  " & _
        "  where  A.no_jur = B.no_jur   " & _
        "  and B.kd_buku_besar ='1011001'  " & _
        "  and A.tgl_trans between  convert(date,'" & tgldari & "',103) and convert(date,'" & tglsampai & "',103)  " & _
        "  and A.tipe_trans in ('JKM-KBB-03','JKK-KBB-03','JKK-KBB-04') " & sql

        daJur = New SqlDataAdapter(New SqlCommand(sql, sqlconn))

        daJur.Fill(dsJur, "jurnal")

        daJurDet = New SqlDataAdapter(New SqlCommand("select ROW_NUMBER() OVER (ORDER BY no_jur) as 'no',* from FIN.dbo.FIN_JURNAL_D where kd_buku_besar ='1011001' and no_jur in (" & sqlNoJur & ")", sqlconn))

        daJurDet.Fill(dsJur, "jurnal_d")

        'Dim colA(0) As DataColumn
        'colA(0) = dsJur.Tables("jurnal").Columns("no_jur")

        'Dim colB(0) As DataColumn
        'colB(0) = dsJur.Tables("jurnal_d").Columns("no_jur")

        'rl = dsJur.Relations.Add("JurDet", colA, colB)

        rl = dsJur.Relations.Add("RelJurDet", dsJur.Tables("jurnal").Columns("no_jur"), dsJur.Tables("jurnal_d").Columns("no_jur"))

        GC1.DataSource = dsJur.Tables("jurnal")

        GC1.LevelTree.Nodes.Add("RelJurDet", GV2)

        GV1.BestFitColumns()
        GV2.BestFitColumns()

        'Catch ex As Exception
        '    lblError1.Text = ex.Message & " , " & "Ada kesalahan data "
        'End Try
    End Sub

    Sub searchJurnal(Optional ByVal jurnal As String = "", Optional ByVal tipe As String = "", Optional ByVal tgldari As String = "", Optional ByVal tglsampai As String = "", Optional ByVal valuta As String = "")
        'Try

        txtSaldoAwal.EditValue = "0"
        Dim dr As SqlDataReader = New SqlCommand("SELECT SIF.dbo.hitungsaldoawal('1011003', 'IDR','" & tglDariX.DateTime.Year & "', '" & tglDariX.DateTime.Month & "', '" & tglDariX.DateTime.Day & "')", sqlconn).ExecuteReader
        dr.Read()
        If dr.HasRows Then
            txtSaldoAwal.EditValue = dr.Item(0)

            Dim g As Long
            g = txtSaldoAwal.EditValue
            txtSaldoAwal.EditValue = Format(g, "##,##0")
        Else
            txtSaldoAwal.EditValue = "0"
        End If

        'If Not dsJur.Relations("RelJurDet") Is Nothing Then
        '    dsJur.Relations.Clear()
        'End If

        If Not dsJur.Tables("jurnal") Is Nothing Then
            dsJur.Tables("jurnal").Clear()
        End If

        If Not dsJur.Tables("jurnal_d") Is Nothing Then
            dsJur.Tables("jurnal_d").Clear()
        End If

        'dsStok.Clear()
        'dsStok.Relations.Clear()
        Dim sql As String = ""
        Dim sqlNoJur As String = ""

        'If CEPost.Checked = True Then
        '    sql &= " isnull(no_posting,'')<>'' "
        'Else
        '    sql &= " isnull(no_posting,'')='' "
        'End If

        'If LOVjurnal.EditValue <> vbNullString Then
        '    sql &= " and LEFT(tipe_trans ,3)='" & jurnal & "' "
        'End If

        'If LOVvaluta.EditValue <> vbNullString Then
        '    sql &= "  and kd_valuta  = '" & valuta & "' "
        'End If

        'If LOVtipeTrans.EditValue <> vbNullString Then
        '    sql &= "  and tipe_trans = '" & tipe & "' "
        'End If

        'If LOVtipeTrans.EditValue <> vbNullString Then
        '    sql &= " tipe_trans = '" & tipe & "' "
        'End If

        If CBEtipeTrans.EditValue = "Permohonan" Then
            sql &= " A.tipe_trans in ('JKK-KBB-03') "
        End If

        If CBEtipeTrans.EditValue = "Pelunasan" Then
            sql &= " A.tipe_trans in ('JKM-KBB-03','JKK-KBB-04') "
        End If

        sqlNoJur = " select A.no_jur from FIN.dbo.FIN_JURNAL A , FIN.dbo.FIN_JURNAL_D B   " & _
        "  where A.no_jur = B.no_jur   " & _
        "  and B.kd_buku_besar ='1011001'   " & _
        "  and A.tgl_trans between  convert(date,'" & tgldari & "',103) and convert(date,'" & tglsampai & "',103)  " & _
        "  and " & sql

        '"  and A.tipe_trans in ('JKK-KBB-03')   " & _
        '"  and kd_valuta  = '" & valuta & "'  " & _

        sql = " select ROW_NUMBER() OVER (ORDER BY A.no_jur) as 'no',A.*,A.no_jur, A.tgl_trans, B.saldo_val_Debet debet, B.saldo_val_kredit kredit   " & _
        "  from FIN.dbo.FIN_JURNAL A , FIN.dbo.FIN_JURNAL_D B   " & _
        "  where A.no_jur = B.no_jur   " & _
        "  and B.kd_buku_besar ='1011001'   " & _
        "  and A.tgl_trans between  convert(date,'" & tgldari & "',103) and convert(date,'" & tglsampai & "',103)  " & _
        "  and " & sql

        '"  and A.tipe_trans in ('JKK-KBB-03','JKM-KBB-03','JKK-KBB-04')   " & _
        '"  and kd_valuta  = '" & valuta & "'  " & _

        daJur = New SqlDataAdapter(New SqlCommand(sql, sqlconn))

        daJur.Fill(dsJur, "jurnal")

        daJurDet = New SqlDataAdapter(New SqlCommand("select ROW_NUMBER() OVER (ORDER BY no_jur) as 'no',* from FIN.dbo.FIN_JURNAL_D where no_jur in (" & sqlNoJur & ")", sqlconn))

        daJurDet.Fill(dsJur, "jurnal_d")

        'Dim colA(0) As DataColumn
        'colA(0) = dsJur.Tables("jurnal").Columns("no_jur")

        'Dim colB(0) As DataColumn
        'colB(0) = dsJur.Tables("jurnal_d").Columns("no_jur")

        'rl = dsJur.Relations.Add("JurDet", colA, colB)
        rl = dsJur.Relations.Add("RelJurDet", dsJur.Tables("jurnal").Columns("no_jur"), dsJur.Tables("jurnal_d").Columns("no_jur"))

        GC1.DataSource = dsJur.Tables("jurnal")

        GC1.LevelTree.Nodes.Add("RelJurDet", GV2)

        GV1.BestFitColumns()
        GV2.BestFitColumns()

        'Catch ex As Exception
        '    lblError1.Text = ex.Message & " , " & "Ada kesalahan data "
        'End Try
    End Sub

    Sub search()
        dsJur.Clear()
        dsJur.Relations.Clear()
        lblError1.Text = "..."

        If tglDariX.EditValue > tglSampaiX.EditValue Then
            MsgBox("Tanggal dari lebih besar dari sampai", MsgBoxStyle.Critical, vbOK)
        Else
            searchJurnal(LOVjurnal.EditValue, LOVtipeTrans.EditValue, tglDariX.EditValue, tglSampaiX.EditValue, LOVvaluta.EditValue)
        End If
    End Sub

    Sub searchAll()
        dsJur.Clear()
        dsJur.Relations.Clear()
        lblError1.Text = "..."

        If tglDariX.EditValue > tglSampaiX.EditValue Then
            MsgBox("Tanggal dari lebih besar dari sampai", MsgBoxStyle.Critical, vbOK)
        Else
            allJurnal(LOVjurnal.EditValue, LOVtipeTrans.EditValue, tglDariX.EditValue, tglSampaiX.EditValue, LOVvaluta.EditValue)
        End If
    End Sub

    Private Sub cmdExe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExe.Click
        search()
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        searchAll()
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
        ShowGridPreview(GC1)
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

    Private Sub LOVtipeTrans_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
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