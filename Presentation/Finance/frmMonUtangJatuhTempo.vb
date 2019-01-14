'|-----------------------
'|  CREATED BY RENDY    |
'|  EDITED BY RENDY     |
'|-----------------------
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Public Class frmMonUtangJatuhTempo
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim err As String = ""
    Dim isvalid As Boolean
    Dim rl, r2 As DataRelation
    Dim dsRekap, dsDetUt, dsLunas, dsValuta, dsSupp, dsSaldo, dsSalF, dsSup, dsGC, dsGcDet As New DataSet
    Dim daRekap, daDetUt, daLunas, daValuta, daSupp, daSaldo, daSalF, daSup, daGC, daGcDet As SqlDataAdapter

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnDelete = True
        btnCancel = True
        setStatus()
        'STATE = "ADD" '<-- set state add

    End Sub

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Private Sub frmMonUtangJatuhTempo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True

        Supplier()
        LoadAllData()
    End Sub

    Sub Supplier()
        dsSup.Clear()
        daSup = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Supplier ", sqlconn))
        daSup.Fill(dsSup, "_Supplier")
        LookUpSupplier.Properties.DataSource = dsSup.Tables("_Supplier")
        LookUpSupplier.Properties.DisplayMember = "Nama_Supplier"
        LookUpSupplier.Properties.ValueMember = "Kode_Supplier"
    End Sub

    Sub LoadAllData()
        Try
            lblError.Text = "..."
    
            dsGC.Clear()
            dsGC.Relations.Clear()

            'select ROW_NUMBER() OVER (ORDER BY A.no_inv) as 'nomer', 
            'A.no_inv , A.no_ref2 , A.tgl_inv , A.kd_supplier , 
            'B.Nama_Supplier , B.Alamat1 , B.Alamat2 , A.keterangan ,
            'A.tgl_jth_tempo , A.jml_val_trans , A.jml_rp_trans , A.jml_diskon , 
            'A.jml_tagihan, A.jml_bayar, A.jml_akhir 
            'from FIN.dbo.FIN_PEMBELIAN A , SIF.dbo.SIF_Supplier B 
            'where A.kd_supplier = B.Kode_Supplier

            daGC = New SqlDataAdapter(New SqlCommand("select ROW_NUMBER() OVER (ORDER BY A.no_inv) as 'nomer', " & _
            "  A.no_inv , A.no_ref2 , A.tgl_inv , A.kd_supplier , " & _
            "  B.Nama_Supplier , B.Alamat1 , B.Alamat2 , A.keterangan , " & _
            "  A.tgl_jth_tempo , A.jml_val_trans , A.jml_rp_trans , A.jml_diskon , " & _
            "  A.jml_tagihan, A.jml_bayar, A.jml_akhir " & _
            "  from FIN.dbo.FIN_PEMBELIAN A , SIF.dbo.SIF_Supplier B " & _
            "  where A.kd_supplier = B.Kode_Supplier", sqlconn))

            daGC.Fill(dsGC, "_HJT")

            'select A.no_inv , A.kd_stok , B.Nama_Barang , A.satuan , A.qty ,
            'A.harga , A.jml_diskon ,  A.jml_rp_trans , A.jml_val_trans ,
            'A.keterangan, A.status
            'from FIN.dbo.FIN_PEMBELIAN_D A , SIF.dbo.SIF_Barang B 
            'where A.kd_stok = B.Kode_Barang

            daGcDet = New SqlDataAdapter(New SqlCommand("select A.no_inv , A.kd_stok , B.Nama_Barang , A.satuan , A.qty , " & _
            "  A.harga , A.jml_diskon ,  A.jml_rp_trans , A.jml_val_trans , " & _
            "  A.keterangan, A.status " & _
            "  from FIN.dbo.FIN_PEMBELIAN_D A , SIF.dbo.SIF_Barang B " & _
            "  where A.kd_stok = B.Kode_Barang", sqlconn))

            daGcDet.Fill(dsGC, "_HJT_DET")

            rl = dsGC.Relations.Add("Detail_HJT", dsGC.Tables("_HJT").Columns("no_inv"), dsGC.Tables("_HJT_DET").Columns("no_inv"))

            GC.DataSource = dsGC.Tables("_HJT")
            GC.LevelTree.Nodes.Add("Detail_HJT", GVlvl2)

            GVlvl1.BestFitColumns()
            GVlvl2.BestFitColumns()

        Catch ex As Exception
            lblError.Text = ex.Message
        End Try
    End Sub

    'Sub searchTglNota()
    '    dsGC.Clear()
    '    dsGC.Relations.Clear()

    '    daGC = New SqlDataAdapter(New SqlCommand("select ROW_NUMBER() OVER (ORDER BY A.no_inv) as 'nomer', " & _
    '    "  A.no_inv , A.no_ref2 , A.tgl_inv , A.kd_supplier , " & _
    '    "  B.Nama_Supplier , B.Alamat1 , B.Alamat2 , A.keterangan , " & _
    '    "  A.tgl_jth_tempo , A.jml_val_trans , A.jml_rp_trans , A.jml_diskon , " & _
    '    "  A.jml_tagihan, A.jml_bayar, A.jml_akhir " & _
    '    "  from FIN.dbo.FIN_PEMBELIAN A , SIF.dbo.SIF_Supplier B " & _
    '    "  where A.kd_supplier = B.Kode_Supplier " & _
    '    "  and A.tgl_inv between '" & NotaTglAwal.EditValue & "' and '" & NotaTglAkhir.EditValue & "'  " & _
    '    "  and A.kd_supplier = '" & LookUpSupplier.EditValue & "' ", sqlconn))

    '    daGC.Fill(dsGC, "_HJT")

    '    daGcDet = New SqlDataAdapter(New SqlCommand("select A.no_inv , A.kd_stok , B.Nama_Barang , A.satuan , A.qty , " & _
    '   "  A.harga , A.jml_diskon ,  A.jml_rp_trans , A.jml_val_trans , " & _
    '   "  A.keterangan, A.status " & _
    '   "  from FIN.dbo.FIN_PEMBELIAN_D A , SIF.dbo.SIF_Barang B " & _
    '   "  where A.kd_stok = B.Kode_Barang", sqlconn))

    '    daGcDet.Fill(dsGC, "_HJT_DET")

    '    rl = dsGC.Relations.Add("Detail_HJT", dsGC.Tables("_HJT").Columns("no_inv"), dsGC.Tables("_HJT_DET").Columns("no_inv"))

    '    GC.DataSource = dsGC.Tables("_HJT")
    '    GC.LevelTree.Nodes.Add("Detail_HJT", GVlvl2)

    '    GVlvl1.BestFitColumns()
    '    GVlvl2.BestFitColumns()
    'End Sub

    Sub searchNOTAandJthTempo(Optional ByVal X As String = "", Optional ByVal Y As String = "", Optional ByVal Z As String = "")

        Try


            dsGC.Clear()
            dsGC.Tables("_HJT").Clear()
            dsGC.Tables("_HJT_DET").Clear()
            dsGC.Relations.Clear()

            daGC = New SqlDataAdapter(New SqlCommand("select ROW_NUMBER() OVER (ORDER BY A.no_inv) as 'nomer', " & _
            "  A.no_inv , A.no_ref2 , A.tgl_inv , A.kd_supplier , " & _
            "  B.Nama_Supplier , B.Alamat1 , B.Alamat2 , A.keterangan , " & _
            "  A.tgl_jth_tempo , A.jml_val_trans , A.jml_rp_trans , A.jml_diskon , " & _
            "  A.jml_tagihan, A.jml_bayar, A.jml_akhir " & _
            "  from FIN.dbo.FIN_PEMBELIAN A , SIF.dbo.SIF_Supplier B " & _
            "  where A.kd_supplier = B.Kode_Supplier " & _
            "  and A.tgl_inv between convert(date,'" & X & "',103) and convert(date,'" & Y & "',103)  " & _
            "  and A.kd_supplier = '" & Z & "' ", sqlconn))

            daGC.Fill(dsGC, "_HJT")

            daGcDet = New SqlDataAdapter(New SqlCommand("select A.no_inv , A.kd_stok , B.Nama_Barang , A.satuan , A.qty , " & _
           "  A.harga , A.jml_diskon ,  A.jml_rp_trans , A.jml_val_trans , " & _
           "  A.keterangan, A.status " & _
           "  from FIN.dbo.FIN_PEMBELIAN_D A , SIF.dbo.SIF_Barang B " & _
           "  where A.kd_stok = B.Kode_Barang " & _
            "  and A.no_inv in (select  A.no_inv " & _
          "   from FIN.dbo.FIN_PEMBELIAN A)", sqlconn))

            daGcDet.Fill(dsGC, "_HJT_DET")


            rl = dsGC.Relations.Add("Relation_HJT", dsGC.Tables("_HJT").Columns("no_inv"), dsGC.Tables("_HJT_DET").Columns("no_inv"))

            GC.DataSource = dsGC.Tables("_HJT")

            GC.LevelTree.Nodes.Add("Relation_HJT", GVlvl2)

            GVlvl1.BestFitColumns()
            GVlvl2.BestFitColumns()

        Catch ex As Exception
            'MsgBox(ex.Message)
            lblError.Text = ex.Message
        End Try
    End Sub

    Sub searchNOTAandJthTempoTanggal(Optional ByVal X As String = "", Optional ByVal Y As String = "")

        Try


            dsGC.Clear()
            dsGC.Tables("_HJT").Clear()
            dsGC.Tables("_HJT_DET").Clear()
            dsGC.Relations.Clear()

            daGC = New SqlDataAdapter(New SqlCommand("select ROW_NUMBER() OVER (ORDER BY A.no_inv) as 'nomer', " & _
            "  A.no_inv , A.no_ref2 , A.tgl_inv , A.kd_supplier , " & _
            "  B.Nama_Supplier , B.Alamat1 , B.Alamat2 , A.keterangan , " & _
            "  A.tgl_jth_tempo , A.jml_val_trans , A.jml_rp_trans , A.jml_diskon , " & _
            "  A.jml_tagihan, A.jml_bayar, A.jml_akhir " & _
            "  from FIN.dbo.FIN_PEMBELIAN A , SIF.dbo.SIF_Supplier B " & _
            "  where A.kd_supplier = B.Kode_Supplier " & _
            "  and A.tgl_inv between convert(date,'" & X & "',103) and convert(date,'" & Y & "',103)  ", sqlconn))

            daGC.Fill(dsGC, "_HJT")

            daGcDet = New SqlDataAdapter(New SqlCommand("select A.no_inv , A.kd_stok , B.Nama_Barang , A.satuan , A.qty , " & _
           "  A.harga , A.jml_diskon ,  A.jml_rp_trans , A.jml_val_trans , " & _
           "  A.keterangan, A.status " & _
           "  from FIN.dbo.FIN_PEMBELIAN_D A , SIF.dbo.SIF_Barang B " & _
           "  where A.kd_stok = B.Kode_Barang " & _
            "  and A.no_inv in (select  A.no_inv " & _
          "   from FIN.dbo.FIN_PEMBELIAN A)", sqlconn))

            daGcDet.Fill(dsGC, "_HJT_DET")


            rl = dsGC.Relations.Add("Relation_HJT", dsGC.Tables("_HJT").Columns("no_inv"), dsGC.Tables("_HJT_DET").Columns("no_inv"))

            GC.DataSource = dsGC.Tables("_HJT")

            GC.LevelTree.Nodes.Add("Relation_HJT", GVlvl2)

            GVlvl1.BestFitColumns()
            GVlvl2.BestFitColumns()

        Catch ex As Exception
            'MsgBox(ex.Message)
            lblError.Text = ex.Message
        End Try
    End Sub

    Sub searchNOTAandJthTempoSupplier(Optional ByVal Z As String = "")

        Try


            dsGC.Clear()
            dsGC.Tables("_HJT").Clear()
            dsGC.Tables("_HJT_DET").Clear()
            dsGC.Relations.Clear()

            daGC = New SqlDataAdapter(New SqlCommand("select ROW_NUMBER() OVER (ORDER BY A.no_inv) as 'nomer', " & _
            "  A.no_inv , A.no_ref2 , A.tgl_inv , A.kd_supplier , " & _
            "  B.Nama_Supplier , B.Alamat1 , B.Alamat2 , A.keterangan , " & _
            "  A.tgl_jth_tempo , A.jml_val_trans , A.jml_rp_trans , A.jml_diskon , " & _
            "  A.jml_tagihan, A.jml_bayar, A.jml_akhir " & _
            "  from FIN.dbo.FIN_PEMBELIAN A , SIF.dbo.SIF_Supplier B " & _
            "  where A.kd_supplier = B.Kode_Supplier " & _
            "  and A.kd_supplier = '" & Z & "' ", sqlconn))

            daGC.Fill(dsGC, "_HJT")

            daGcDet = New SqlDataAdapter(New SqlCommand("select A.no_inv , A.kd_stok , B.Nama_Barang , A.satuan , A.qty , " & _
           "  A.harga , A.jml_diskon ,  A.jml_rp_trans , A.jml_val_trans , " & _
           "  A.keterangan, A.status " & _
           "  from FIN.dbo.FIN_PEMBELIAN_D A , SIF.dbo.SIF_Barang B " & _
           "  where A.kd_stok = B.Kode_Barang " & _
            "  and A.no_inv in (select  A.no_inv " & _
          "   from FIN.dbo.FIN_PEMBELIAN A)", sqlconn))

            daGcDet.Fill(dsGC, "_HJT_DET")


            rl = dsGC.Relations.Add("Relation_HJT", dsGC.Tables("_HJT").Columns("no_inv"), dsGC.Tables("_HJT_DET").Columns("no_inv"))

            GC.DataSource = dsGC.Tables("_HJT")

            GC.LevelTree.Nodes.Add("Relation_HJT", GVlvl2)

            GVlvl1.BestFitColumns()
            GVlvl2.BestFitColumns()

        Catch ex As Exception
            'MsgBox(ex.Message)
            lblError.Text = ex.Message
        End Try
    End Sub

    'Sub searchTglJthTempo()
    '    dsGC.Clear()
    '    dsGC.Relations.Clear()

    '    daGC = New SqlDataAdapter(New SqlCommand("select ROW_NUMBER() OVER (ORDER BY A.no_inv) as 'nomer', " & _
    '   "  A.no_inv , A.no_ref2 , A.tgl_inv , A.kd_supplier , " & _
    '   "  B.Nama_Supplier , B.Alamat1 , B.Alamat2 , A.keterangan , " & _
    '   "  A.tgl_jth_tempo , A.jml_val_trans , A.jml_rp_trans , A.jml_diskon , " & _
    '   "  A.jml_tagihan, A.jml_bayar, A.jml_akhir " & _
    '   "  from FIN.dbo.FIN_PEMBELIAN A , SIF.dbo.SIF_Supplier B " & _
    '   "  where A.kd_supplier = B.Kode_Supplier " & _
    '   "  and A.tgl_jth_tempo between '" & JthTmpTglAwal.EditValue & "' and '" & JthTmpTglAkhir.EditValue & "'  " & _
    '   "  and A.kd_supplier = '" & LookUpSupplier.EditValue & "' ", sqlconn))

    '    daGC.Fill(dsGC, "_HJT")

    '    daGcDet = New SqlDataAdapter(New SqlCommand("select A.no_inv , A.kd_stok , B.Nama_Barang , A.satuan , A.qty , " & _
    ' "  A.harga , A.jml_diskon ,  A.jml_rp_trans , A.jml_val_trans , " & _
    ' "  A.keterangan, A.status " & _
    ' "  from FIN.dbo.FIN_PEMBELIAN_D A , SIF.dbo.SIF_Barang B " & _
    ' "  where A.kd_stok = B.Kode_Barang", sqlconn))

    '    daGcDet.Fill(dsGC, "_HJT_DET")

    '    rl = dsGC.Relations.Add("Detail_HJT", dsGC.Tables("_HJT").Columns("no_inv"), dsGC.Tables("_HJT_DET").Columns("no_inv"))

    '    GC.DataSource = dsGC.Tables("_HJT")
    '    GC.LevelTree.Nodes.Add("Detail_HJT", GVlvl2)

    '    GVlvl1.BestFitColumns()
    '    GVlvl2.BestFitColumns()
    'End Sub


    Private Sub CENota_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CENota.CheckedChanged
        ResetPosition()

        If CENota.Checked = True Then
            CEJthTmp.Checked = False
            JthTmpTglAwal.EditValue = vbNullString
            JthTmpTglAkhir.EditValue = vbNullString
            JthTmpTglAwal.Enabled = False
            JthTmpTglAkhir.Enabled = False

            SplitContainerControlSubSec.SplitterPosition = 472
        Else
            JthTmpTglAwal.Enabled = True
            JthTmpTglAkhir.Enabled = True
        End If

        If CENota.Checked = False And CEJthTmp.Checked = False Then
            ResetPosition
        End If
    End Sub

    Sub ResetPosition()
        SplitContainerControlSubPrim.SplitterPosition = 337
        SplitContainerControlSubSec.SplitterPosition = 733
        SplitContainerControlMst.SplitterPosition = 198
    End Sub

    Private Sub CEJthTmp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEJthTmp.CheckedChanged
        ResetPosition()

        If CEJthTmp.Checked = True Then
            CENota.Checked = False
            NotaTglAwal.EditValue = vbNullString
            NotaTglAkhir.EditValue = vbNullString
            NotaTglAwal.Enabled = False
            NotaTglAkhir.Enabled = False

            SplitContainerControlSubPrim.SplitterPosition = 81
            SplitContainerControlSubSec.SplitterPosition = 472
        Else
            NotaTglAwal.Enabled = True
            NotaTglAkhir.Enabled = True
        End If

        If CENota.Checked = False And CEJthTmp.Checked = False Then
           ResetPosition
        End If
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        ErrorProvider1.Clear()
        If CENota.Checked = True Then

            If NotaTglAwal.EditValue <> vbNullString And NotaTglAkhir.EditValue <> vbNullString And LookUpSupplier.EditValue <> vbNullString Then
                searchNOTAandJthTempo(NotaTglAwal.Text, NotaTglAkhir.Text, LookUpSupplier.EditValue)
            End If

            If NotaTglAwal.EditValue = vbNullString And NotaTglAkhir.EditValue = vbNullString And LookUpSupplier.EditValue <> vbNullString Then
                searchNOTAandJthTempoSupplier(LookUpSupplier.EditValue)
            End If

            If NotaTglAwal.EditValue <> vbNullString And NotaTglAkhir.EditValue <> vbNullString And LookUpSupplier.EditValue = vbNullString Then
                searchNOTAandJthTempoTanggal(NotaTglAwal.Text, NotaTglAkhir.Text)
            End If

            GVlvl1.ViewCaption = "MONITOR HUTANG / NOTA"
        End If

        If CEJthTmp.Checked = True Then

            If JthTmpTglAwal.EditValue <> vbNullString And JthTmpTglAkhir.EditValue <> vbNullString And LookUpSupplier.EditValue <> vbNullString Then
                searchNOTAandJthTempo(JthTmpTglAwal.Text, JthTmpTglAkhir.Text, LookUpSupplier.EditValue)
            End If

            If JthTmpTglAwal.EditValue = vbNullString And JthTmpTglAkhir.EditValue = vbNullString And LookUpSupplier.EditValue <> vbNullString Then
                searchNOTAandJthTempoSupplier(LookUpSupplier.EditValue)
            End If

            If JthTmpTglAwal.EditValue <> vbNullString And JthTmpTglAkhir.EditValue <> vbNullString And LookUpSupplier.EditValue = vbNullString Then
                searchNOTAandJthTempoTanggal(JthTmpTglAwal.Text, JthTmpTglAkhir.Text)
            End If

            GVlvl1.ViewCaption = "MONITOR HUTANG / JATUH TEMPO"
        End If

        If CENota.Checked = False And CEJthTmp.Checked = False Then
            ErrorProvider1.SetError(CENota, "Pilih Salah Satu")
            ErrorProvider1.SetError(CEJthTmp, "Pilih Salah Satu")
        End If
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        LoadAllData()
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        dsGC.Clear()
        dsGC.Relations.Clear()
        JthTmpTglAwal.EditValue = vbNullString
        JthTmpTglAkhir.EditValue = vbNullString
        NotaTglAwal.EditValue = vbNullString
        NotaTglAkhir.EditValue = vbNullString
        LookUpSupplier.EditValue = vbNullString

    End Sub

    Private Sub CEMerah_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEMerah.CheckedChanged
        If CEMerah.Checked = True Then
            CEKuning.Checked = False
            CEHijau.Checked = False
            GVlvl1.ActiveFilterString = "GetDate(Now()) >= tgl_jth_tempo"

        ElseIf CEMerah.Checked = False Then
            GVlvl1.ActiveFilterString = ""
        End If
    End Sub

    Private Sub CEKuning_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEKuning.CheckedChanged
        If CEKuning.Checked = True Then
            CEHijau.Checked = False
            CEMerah.Checked = False
            GVlvl1.ActiveFilterString = "GetDate(Now()) < tgl_jth_tempo And GetDate(Now()) >= GetDate(AddDays(tgl_jth_tempo, -7))"
        ElseIf CEKuning.Checked = False Then
            GVlvl1.ActiveFilterString = ""
        End If
    End Sub

    Private Sub CEHijau_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEHijau.CheckedChanged
        If CEHijau.Checked = True Then
            CEKuning.Checked = False
            CEMerah.Checked = False
            GVlvl1.ActiveFilterString = "GetDate(Now()) < GetDate(AddDays(tgl_jth_tempo, -7))"
        ElseIf CEHijau.Checked = False Then
            GVlvl1.ActiveFilterString = ""
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
        ShowGridPreview(GC)
    End Sub

End Class