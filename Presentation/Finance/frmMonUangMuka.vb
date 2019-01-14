'|-----------------------
'|  CREATED BY RENDY    |
'|  EDITED BY RENDY     |
'|-----------------------
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Public Class frmMonUangMuka
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim err As String = ""
    Dim isvalid As Boolean

    Dim a, dsDetkasBon, dsDetUt, dsSupp, dsVal As New DataSet
    Dim b, daDetkasBon, daDetUt, daSupp, daVal As SqlDataAdapter

    Private Sub frmMonUangMuka_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)

        LoadGrid1All()
        'GenLOVbuku()

        Try
            Dim kKb As String
            Dim viewLvl1 As ColumnView = GV1
            kKb = viewLvl1.GetFocusedRowCellValue("nomor").ToString

            loadPelunasan(kKb)
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try

        loadLookUP()
        Me.Enabled = True
        GV1.BestFitColumns()
        GV2.BestFitColumns()

        Tanggal.EditValue = getTanggal()
        Kartu.ItemIndex = 0
    End Sub

    Sub LoadGrid1All()

        dsDetkasBon.Clear()
        daDetkasBon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  ROW_NUMBER() OVER (ORDER BY A.nomor) as 'no',A.nomor,A.tanggal,A.no_ref1,A.kartu,A.kd_valuta,A.jml_tagihan,A.jml_bayar,A.jml_akhir " & _
        "   from FIN.dbo.FIN_UM A, FIN.dbo.FIN_JURNAL B  " & _
        "   where A.no_jurnal = B.no_jur " & _
        "   and A.tipe_trans like '%KUT%' " & _
        "   and B.no_posting is not null", sqlconn))

        daDetkasBon.Fill(dsDetkasBon, "detUM")
        GC1.DataSource = dsDetkasBon.Tables("detUM")
        GV1.BestFitColumns()

    End Sub

    Sub LoadGrid1OutStanding()

        dsDetkasBon.Clear()
        daDetkasBon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  ROW_NUMBER() OVER (ORDER BY A.nomor) as 'no',A.nomor,A.tanggal,A.no_ref1,A.kartu,A.kd_valuta,A.jml_tagihan,A.jml_bayar,A.jml_akhir " & _
        "   from FIN.dbo.FIN_UM A, FIN.dbo.FIN_JURNAL B  " & _
        "   where A.no_jurnal = B.no_jur " & _
        "   and A.tipe_trans like '%KUT%' " & _
        "   and B.no_posting is not null " & _
        "   and A.jml_akhir > 0", sqlconn))

        daDetkasBon.Fill(dsDetkasBon, "detUM")
        GC1.DataSource = dsDetkasBon.Tables("detUM")
        GV1.BestFitColumns()

    End Sub

    Sub LoadGrid2()

        dsDetUt.Clear()
        daDetUt = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select ROW_NUMBER() OVER (ORDER BY A.no_trans) as 'no',A.no_trans,A.prev_no_inv ,A.no_ref2,A.tgl_trans ,A.keterangan ,A.jml_bayar  " & _
        "   from FIN.dbo.v_lunas_hutang_detail A,FIN.dbo.FIN_JURNAL B  " & _
        "   where A.no_trans = B.no_jur " & _
        "   and B.no_posting is not null", sqlconn))
        daDetUt.Fill(dsDetUt, "pelunasan")
        GC2.DataSource = dsDetUt.Tables("pelunasan")
        GV2.BestFitColumns()

    End Sub

    Sub loadLookUP()
        dsSupp.Clear()
        daSupp = New SqlDataAdapter(New SqlCommand("select nama,kode from FIN.dbo.v_kartu", sqlconn))
        daSupp.Fill(dsSupp, "kartu")
        Kartu.Properties.DataSource = dsSupp.Tables("kartu")
        Kartu.Properties.DisplayMember = "nama"
        Kartu.Properties.ValueMember = "kode"

        dsSupp.Clear()
        daSupp = New SqlDataAdapter(New SqlCommand("select nama,kode from FIN.dbo.v_kartu", sqlconn))
        daSupp.Fill(dsSupp, "kartu")
        LOVKartu.Properties.DataSource = dsSupp.Tables("kartu")
        LOVKartu.Properties.DisplayMember = "nama"
        LOVKartu.Properties.ValueMember = "kode"

        dsVal.Clear()
        daVal = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Valuta", sqlconn))
        daVal.Fill(dsVal, "valuta")
        LOVvaluta.Properties.DataSource = dsVal.Tables("valuta")
        LOVvaluta.Properties.DisplayMember = "Nama_Valuta"
        LOVvaluta.Properties.ValueMember = "Kode_Valuta"
    End Sub

    Private Sub cmdExe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExe.Click
        listShortingGrid1()

        Try
            Dim kKb As String
            Dim viewLvl1 As ColumnView = GV1
            kKb = viewLvl1.GetFocusedRowCellValue("nomor").ToString

            loadPelunasan(kKb)

        Catch ex As Exception
            lblError.Text = ex.Message
        End Try
    End Sub

    Sub listShortingGrid1()

        If CEPPAll.Checked = True Then

            dsDetkasBon.Clear()
            daDetkasBon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  ROW_NUMBER() OVER (ORDER BY A.nomor) as 'no',  " & _
            "   A.nomor,A.tipe_trans,A.tanggal,A.no_ref1,A.kartu,A.kd_valuta,A.jml_tagihan,A.jml_bayar,A.jml_akhir  " & _
            "   from FIN.dbo.FIN_UM A, FIN.dbo.FIN_JURNAL B  " & _
            "   where A.no_jurnal = B.no_jur   " & _
            "   and B.no_posting is not null " & _
            "   and A.tipe_trans like '%KUT%' " & _
            "   and A.kartu = '" & Kartu.EditValue & "'  " & _
            "   and A.tanggal <= convert(date,'" & Tanggal.Text & "',103) ", sqlconn))

            daDetkasBon.Fill(dsDetkasBon, "detUM")
            GC1.DataSource = dsDetkasBon.Tables("detUM")
            GV1.BestFitColumns()

        End If

        If CEPPOutStanding.Checked = True Then

            dsDetkasBon.Clear()
            daDetkasBon = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  ROW_NUMBER() OVER (ORDER BY A.nomor) as 'no', " & _
            "   A.nomor,A.tipe_trans,A.tanggal,A.no_ref1,A.kartu,A.kd_valuta,A.jml_tagihan,A.jml_bayar,A.jml_akhir " & _
            "   from FIN.dbo.FIN_UM A, FIN.dbo.FIN_JURNAL B  " & _
            "   where A.no_jurnal = B.no_jur  " & _
            "   and B.no_posting is not null " & _
            "   and A.tipe_trans like '%KUT%' " & _
            "   and A.jml_akhir > 0 " & _
            "   and A.kartu = '" & Kartu.EditValue & "' " & _
            "   and A.tanggal <= convert(date,'" & Tanggal.Text & "',103) ", sqlconn))

            daDetkasBon.Fill(dsDetkasBon, "detUM")
            GC1.DataSource = dsDetkasBon.Tables("detUM")
            GV1.BestFitColumns()

        End If

    End Sub

    Sub bersih()
        Tanggal.EditValue = getTanggal()
        'Kartu.ItemIndex = 0
        Kartu.EditValue = vbNullString
    End Sub

    Sub loadPelunasan(Optional ByVal nomorINV As String = "")
        lblError.Text = "..."
        Try

            dsDetUt.Clear()
            daDetUt = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select ROW_NUMBER() OVER (ORDER BY A.no_trans) as 'no',A.no_trans,A.prev_no_inv ,A.no_ref2,A.tgl_trans ,A.keterangan ,A.jmldebet as jml_bayar  " & _
            "   from FIN.dbo.v_lunas_hutang_detail A,FIN.dbo.FIN_JURNAL B  " & _
            "   where A.no_trans = B.no_jur " & _
            "   and B.no_posting is not null " & _
            "   and A.no_ref2 = '" & nomorINV & "'  ", sqlconn))

            daDetUt.Fill(dsDetUt, "pelunasan")
            GC2.DataSource = dsDetUt.Tables("pelunasan")
            GV2.BestFitColumns()

        Catch ex As Exception
            lblError.Text = ex.Message
        End Try
    End Sub

    Private Sub GC1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GC1.Click
        'SELECT GRID 2
        Try
            Dim kKb As String
            Dim viewLvl1 As ColumnView = GV1
            kKb = viewLvl1.GetFocusedRowCellValue("nomor").ToString

            loadPelunasan(kKb)

            'MsgBox(kKb)
        Catch ex As Exception
            lblError.Text = ex.Message
        End Try
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        LoadGrid1All()
        LoadGrid2()
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        bersih()
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

    Private Sub cmdPrintPendapatan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintPendapatan.Click
        If CEGV1.Checked = True Then
            ShowGridPreview(GC1)
        Else
            ShowGridPreview(GC2)
        End If
    End Sub

    Private Sub CEPPAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEPPAll.CheckedChanged
        If CEPPAll.Checked = True Then
            CEPPOutStanding.Checked = False
        Else
            CEPPOutStanding.Checked = True
        End If
    End Sub

    Private Sub CEPPOutStanding_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEPPOutStanding.CheckedChanged
        If CEPPOutStanding.Checked = True Then
            CEPPAll.Checked = False
        Else
            CEPPAll.Checked = True
        End If
    End Sub

    Private Sub CEGV1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEGV1.CheckedChanged
        If CEGV1.Checked = True Then
            CEGV2.Checked = False
        Else
            CEGV2.Checked = True
        End If
    End Sub

    Private Sub CEGV2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEGV2.CheckedChanged
        If CEGV2.Checked = True Then
            CEGV1.Checked = False
        Else
            CEGV1.Checked = True
        End If
    End Sub
End Class