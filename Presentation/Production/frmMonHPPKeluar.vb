'|-----------------------
'|  CREATED BY RENDY    |
'|  EDITED BY RENDY     |
'|-----------------------
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraPrinting
Public Class frmMonHPPKeluar

    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
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
        daTipe = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_TIPE_TRANS", sqlconn))
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
        '7
        daBrg = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang ", sqlconn))
        daBrg.Fill(dsLOV, "barang")
        LOVBarang.Properties.DataSource = dsLOV.Tables("barang")
        LOVBarang.Properties.DisplayMember = "Nama_Barang"
        LOVBarang.Properties.ValueMember = "Kode_Barang"


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

    Sub searchJurnal(Optional ByVal jurnal As String = "", Optional ByVal tipe As String = "", Optional ByVal tgldari As String = "", Optional ByVal tglsampai As String = "", Optional ByVal valuta As String = "")
        'Try

        If Not dsJur.Tables("jurnal") Is Nothing Then
            dsJur.Tables("jurnal").Clear()
        End If




        If Not dsJur.Tables("jurnal_d") Is Nothing Then
            dsJur.Tables("jurnal_d").Clear()
        End If

        'dsStok.Clear()
        'dsStok.Relations.Clear()
        Dim sql1 As String = ""
        Dim sql As String = ""
        Dim sqlNoJur As String = ""

        If CEPost.Checked = True Then
            sql1 &= " isnull(m.no_posting,'')<>'' "
        Else
            sql1 &= " isnull(m.no_posting,'')='' "
        End If

        If LOVjurnal.EditValue <> vbNullString Then
            sql &= " and LEFT(tipe_trans ,3)='" & jurnal & "' "
        End If

        If LOVtipeTrans.EditValue <> vbNullString Then
            sql &= "  and tipe_trans = '" & tipe & "' "
        End If

        sqlNoJur = " SELECT ROW_NUMBER() OVER (ORDER BY m.tgl_trans , d.no_jur) as 'no',m.tipe_trans " & _
        ", d.no_jur,d.kd_buku_besar,m.tgl_trans, m.tgl_posting, d.no_ref1 as no_realisasi, d.kd_obyek as Kode_Barang , " & _
        "br.Nama_Barang,d.no_seq,  d.saldo_rp_kredit , d.val_ref1 as qty, d.harga harga_satuan, br.Kd_Satuan , d.tinggi, d.lebar, d.panjang " & _
        "From FIN.dbo.FIN_JURNAL_D d " & _
        "left join SIF.dbo.SIF_Barang br " & _
        "on br.Kode_Barang = d.kd_obyek " & _
        "left join FIN.dbo.FIN_JURNAL m " & _
        "on m.no_jur = d.no_jur " & _
        "where m.tipe_trans = 'JBM-KUT-02' " & _
        "and m.tgl_trans between  convert(date,'" & tgldari & "',103)  " & _
        "and convert(date,'" & tglsampai & "',103) " & _
        "and d.keterangan = 'Barang kurang' and " & sql1 & " " & _
        "order by m.tgl_trans , d.no_jur ASC "

        '"where m.thnbln = '201402' and m.tipe_trans = 'JBM-KUT-02' " & _

        '"and (d.saldo_rp_kredit >= 0 and d.saldo_rp_debet =0) and " & sql1 & " " & _

        'sql = " SELECT ROW_NUMBER() OVER (ORDER BY m.tgl_trans , d.no_jur) as 'no',m.tipe_trans " & _
        '", d.no_jur,m.tgl_trans,m.tgl_posting, d.no_ref1 as no_realisasi, d.kd_obyek as Kode_Barang , " & _
        '"br.Nama_Barang,br.Kd_Satuan,d.no_seq, d.saldo_rp_debet, " & _
        '"d.val_ref1 as qty, " & _
        '"REPLACE(CONVERT(varchar(20), CAST((d.saldo_rp_debet / d.val_ref1) AS money ), 1), '.00', SPACE(0)) as harga_satuan,  " & _
        '"d.tinggi, d.lebar, d.panjang  From FIN.dbo.FIN_JURNAL_D d " & _
        '"left join SIF.dbo.SIF_Barang br " & _
        '"on br.Kode_Barang = d.kd_obyek " & _
        '"left join FIN.dbo.FIN_JURNAL m " & _
        '"on m.no_jur = d.no_jur " & _
        '"where m.thnbln = '201402' and m.tipe_trans = 'JBM-KUT-02' " & _
        '"and m.tgl_trans between  convert(date,'" & tgldari & "',103) " & _
        '"and convert(date,'" & tglsampai & "',103) " & _
        '"and d.saldo_rp_debet > 0 and " & sql1 & " " & _
        '"order by m.tgl_trans , d.no_jur ASC  "

        'daJur = New SqlDataAdapter(New SqlCommand(sql, sqlconn))

        'daJur.Fill(dsJur, "jurnal")

        daJurDet = New SqlDataAdapter(New SqlCommand(sqlNoJur, sqlconn))

        daJurDet.Fill(dsJur, "jurnal_d")

        'Dim colA(0) As DataColumn
        'colA(0) = dsJur.Tables("jurnal").Columns("no_jur")

        'Dim colB(0) As DataColumn
        'colB(0) = dsJur.Tables("jurnal_d").Columns("no_jur")

        'rl = dsJur.Relations.Add("JurDet", colA, colB)
        'rl = dsJur.Relations.Add("RelJurDet", dsJur.Tables("jurnal").Columns("no_jur"), dsJur.Tables("jurnal_d").Columns("no_jur"))

        GC1.DataSource = dsJur.Tables("jurnal_d")

        'GC1.LevelTree.Nodes.Add("RelJurDet", GV2)

        GV1.BestFitColumns()
        ' GV2.BestFitColumns()

        Dim dr As SqlDataReader = New SqlClient.SqlCommand(" SELECT COUNT(d.no_jur)as jumlah_record From FIN.dbo.FIN_JURNAL_D d " & _
        "left join SIF.dbo.SIF_Barang br " & _
        "on br.Kode_Barang = d.kd_obyek " & _
        "left join FIN.dbo.FIN_JURNAL m " & _
        "on m.no_jur = d.no_jur " & _
        "where  m.tipe_trans = 'JBM-KUT-02' " & _
        "and m.tgl_trans between  convert(date,'" & tgldari & "',103)  " & _
        "and convert(date,'" & tglsampai & "',103) " & _
        "and d.keterangan = 'Barang kurang' and " & sql1 & " ", sqlconn).ExecuteReader
        dr.Read()

        '"where m.thnbln = '201402' and m.tipe_trans = 'JBM-KUT-02' " & _
        'lbl_jumlah_rph.Text = String.Format("{0:#,##0.00}", dr.Item("jumlah_rph"))
        'lbl_jumlah_spk.Text = String.Format("{0:#,##0.00}", dr.Item("jumlah_spk"))
        'jml_rph = dr.Item("jumlah_rph")
        lblError1.Text = dr.Item("jumlah_record")
        dr.Close()

        'Catch ex As Exception
        '    lblError1.Text = ex.Message & " , " & "Ada kesalahan data "
        'End Try
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExe.Click
        dsJur.Clear()
        dsJur.Relations.Clear()
        lblError1.Text = "..."

        If tglDari.EditValue > tglSampai.EditValue Then
            MsgBox("Tanggal dari lebih besar dari sampai", MsgBoxStyle.Critical, vbOK)
        Else
            searchJurnal(LOVjurnal.EditValue, LOVtipeTrans.EditValue, Format(tglDari.EditValue, "dd/MM/yyyy"), Format(tglSampai.EditValue, "dd/MM/yyyy"), LOVvaluta.EditValue)
        End If

    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        GV1.Columns("tgl_trans").Visible = False
        GV1.Columns("tgl_posting").Visible = False
        print_gc1(GC1, "                                                                        Daftar Pemakaian Bahan (PRODUKSI)     " & vbCrLf & _
                      "Tanggal Transaksi     : " & Format(tglDari.EditValue, "dd/MM/yyyy") & " s/d " & Format(tglSampai.EditValue, "dd/MM/yyyy"))
        GV1.Columns("tgl_trans").Visible = True
        GV1.Columns("tgl_posting").Visible = True
        'print_gc1(GC1, "Daftar Pemakaian Barang Kebutuhan Produksi")

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

    Sub print_gc1(ByVal xGc As Object, ByVal xreportHeader As String)
        Dim ps As New PrintingSystem()
        Dim link As New PrintableComponentLink(ps)
        Dim ph As DevExpress.XtraPrinting.PageHeaderFooter = CType(link.PageHeaderFooter, PageHeaderFooter)
        ph.Header.Content.Add("                                                                         " & umum.Perusahaan & vbCrLf & xreportHeader)
        ph.Header.Content.Add("")
        ph.Header.Content.Add(getTanggal.ToShortDateString)
        ph.Header.LineAlignment = BrickAlignment.Near
        ph.Footer.Content.Add("")
        ph.Footer.Content.Add("Lembar : [Page # of Pages #]")
        ph.Header.Font = New Font("Tahoma", 10, FontStyle.Bold)

        link.Component = xGc
        link.Margins.Left = 4
        link.Margins.Right = 4
        link.Margins.Bottom = 40
        link.Margins.Top = 130
        link.PaperKind = System.Drawing.Printing.PaperKind.A4
        link.CreateDocument()
        link.ShowPreview()

    End Sub
End Class