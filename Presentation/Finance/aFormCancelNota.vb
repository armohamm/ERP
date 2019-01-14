Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class aFormCancelNota
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, ds_cari, ds_cari1 As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    'Private rw As DataRow
    Dim DA, DA1, DA2, DALOOKUP, DALOOKUP1 As SqlClient.SqlDataAdapter
    Dim rhandle As Int16
    Dim kon As Boolean = True

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnDelete = False
        btnCancel = False
        setStatus()
        'STATE = "ADD" '<-- set state add

    End Sub

    Public Sub save_click()
        If MsgBox("Batalkan jurnal?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim viewx As ColumnView = Gvheader.Columns.View
            If lookJenis.EditValue = "penj" Then
                For Each rw As DataRow In dSO.Tables("_invheader").Select("cek='Y'")
                    Dim sqlcmdJurnalD As New SqlCommand("DELETE FROM FIN.dbo.FIN_JURNAL_D WHERE no_jur IN (SELECT no_jur FROM FIN.dbo.FIN_JURNAL WHERE no_ref3='" & rw("no_inv") & "')", sqlconn)
                    sqlcmdJurnalD.ExecuteNonQuery()
                    Dim sqlcmdJurnal As New SqlCommand("DELETE FROM FIN.dbo.FIN_JURNAL WHERE no_ref3='" & rw("no_inv") & "'", sqlconn)
                    sqlcmdJurnal.ExecuteNonQuery()
                    Dim sqlcmdNotaD As New SqlCommand("DELETE FROM FIN.dbo.FIN_NOTA_D WHERE no_inv='" & rw("no_inv") & "'", sqlconn)
                    sqlcmdNotaD.ExecuteNonQuery()
                    Dim sqlcmdNota As New SqlCommand("DELETE FROM FIN.dbo.FIN_NOTA WHERE no_inv='" & rw("no_inv") & "'", sqlconn)
                    sqlcmdNota.ExecuteNonQuery()
                    Dim sqlcmdSJ As New SqlCommand("UPDATE SALES.dbo.SALES_SJ SET sts_nota = Null WHERE no_sj='" & rw("no_ref1") & "'", sqlconn)
                    sqlcmdSJ.ExecuteNonQuery()
                Next
            Else
                For Each rw As DataRow In dSO.Tables("_invheader").Select("cek='Y'")
                    Dim sqlcmdJurnalD As New SqlCommand("DELETE FROM FIN.dbo.FIN_JURNAL_D WHERE no_jur IN (SELECT no_jur FROM FIN.dbo.FIN_JURNAL WHERE no_ref3='" & rw("no_inv") & "')", sqlconn)
                    sqlcmdJurnalD.ExecuteNonQuery()
                    Dim sqlcmdJurnal As New SqlCommand("DELETE FROM FIN.dbo.FIN_JURNAL WHERE no_ref3='" & rw("no_inv") & "'", sqlconn)
                    sqlcmdJurnal.ExecuteNonQuery()
                    Dim sqlcmdNotaD As New SqlCommand("DELETE FROM FIN.dbo.FIN_PEMBELIAN_D WHERE no_inv='" & rw("no_inv") & "'", sqlconn)
                    sqlcmdNotaD.ExecuteNonQuery()
                    Dim sqlcmdNota As New SqlCommand("DELETE FROM FIN.dbo.FIN_PEMBELIAN WHERE no_inv='" & rw("no_inv") & "'", sqlconn)
                    sqlcmdNota.ExecuteNonQuery()
                    'Dim sqlcmdSJ As New SqlCommand("UPDATE PURC.dbo.PURC_PO SET rec_stat = 'ENTRY' WHERE no_po='" & rw("no_ref") & "'", sqlconn)
                    'sqlcmdSJ.ExecuteNonQuery()
                Next
            End If
            kon = True

            reloadGrid()
        End If
    End Sub

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
            .btnCetak.Enabled = btnCetak
        End With
    End Sub

    Private Sub frmMstTipeTranKeu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        v_jenis()

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kd_Customer, Nama_Customer from SIF.dbo.SIF_Customer", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        Lookupcust.DataSource = ds_cari.Tables("_lookup1")
        Lookupcust.ValueMember = "Kd_Customer"
        Lookupcust.DisplayMember = "Nama_Customer"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup2")
        Lookupbrg.DataSource = ds_cari.Tables("_lookup2")
        Lookupbrg.ValueMember = "Kode_Barang"
        Lookupbrg.DisplayMember = "Nama_Barang"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select kd_buku_besar, nm_buku_besar from SIF.dbo.SIF_buku_besar", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup3")
        lookuprekening.DataSource = ds_cari.Tables("_lookup3")
        lookuprekening.ValueMember = "kd_buku_besar"
        lookuprekening.DisplayMember = "nm_buku_besar"

        deTglAwal.EditValue = DateAdd(DateInterval.Month, -1, getTanggal())
        deTglAkhir.EditValue = getTanggal()
        lookJenis.ItemIndex = 0

    End Sub

    Public Sub bersihkan()
        If Not dSO Is Nothing Then
            dSO.Clear()
        End If
        ckcetak.Checked = False
    End Sub

    Private Sub v_jenis()
        If Not ds_cari.Tables("Jenis") Is Nothing Then ds_cari.Tables("Jenis").Clear()

        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT 'pemb' kode, 'Pembelian' nama UNION ALL SELECT 'penj' kode, 'Penjualan' nama", sqlconn))
        DALOOKUP.Fill(ds_cari, "Jenis")
        lookJenis.Properties.DataSource = ds_cari.Tables("Jenis")
        lookJenis.Properties.ValueMember = "kode"
        lookJenis.Properties.DisplayMember = "nama"
    End Sub

    Private Sub v_jenis2()
        If Not ds_cari.Tables("Jenis2") Is Nothing Then ds_cari.Tables("Jenis2").Clear()

        If lookJenis.EditValue = "pemb" Then
            DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT tipe_trans, tipe_desc nama FROM SIF.dbo.SIF_TIPE_TRANS WHERE tipe_trans LIKE 'JPP%' UNION ALL SELECT '0000000000' as tipe_trans, '[Semua Pembelian]' as nama", sqlconn))
        Else
            DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT tipe_trans,tipe_desc nama FROM SIF.dbo.SIF_TIPE_TRANS WHERE tipe_trans LIKE 'JPJ%' AND tipe_trans NOT IN ('JPJ-KPT-08') UNION ALL SELECT '0000000000' as tipe_trans, '[Semua Penjualan]' as nama", sqlconn))
        End If

        DALOOKUP.Fill(ds_cari, "Jenis2")
        lookJenis2.Properties.DataSource = ds_cari.Tables("Jenis2")
        lookJenis2.Properties.ValueMember = "tipe_trans"
        lookJenis2.Properties.DisplayMember = "nama"
    End Sub

    Public Sub reloadGrid()
        'DA = New SqlDataAdapter(New SqlCommand("select * from FIN.DBO.FIN_NOTA where tipe_trans not in ('JPJ-KPT-08')", sqlconn))
        'DA.Fill(dSO, "_invheader")
        'GcInvoice.DataSource = dSO.Tables("_invheader")
        dSO = New DataSet
        If lookJenis.EditValue = "penj" Then
            If lookJenis2.EditValue = "0000000000" Then
                DA = New SqlDataAdapter(New SqlCommand("select '' as cek, a.*, (SELECT Tgl_sp FROM SALES.dbo.SALES_SO WHERE No_sp = a.no_ref2) tgl_sp, a.no_ref2 no_ref from FIN.DBO.FIN_NOTA a where a.tipe_trans like 'JPJ%' and a.tipe_trans not in ('JPJ-KPT-08') and not a.program_name = 'MIGPIUTANG' and tgl_inv between CONVERT(date, '" & deTglAwal.EditValue & "', 103) and CONVERT(date, '" & deTglAkhir.EditValue & "', 103) AND (no_posting IS NULL OR no_posting = '')", sqlconn))
                DA1 = New SqlDataAdapter(New SqlCommand("SELECT * from FIN.DBO.FIN_NOTA_D where no_inv in (select no_inv from FIN.DBO.FIN_NOTA where tipe_trans like 'JPJ%' and tipe_trans not in ('JPJ-KPT-08') and not program_name = 'MIGPIUTANG' and tgl_inv between CONVERT(date, '" & deTglAwal.EditValue & "', 103) and CONVERT(date, '" & deTglAkhir.EditValue & "', 103) AND (no_posting IS NULL OR no_posting = ''))", sqlconn))
                DA2 = New SqlDataAdapter(New SqlCommand("select * from FIN.DBO.v_jurnal_det where no_ref3 in (select no_inv from FIN.DBO.FIN_NOTA where tipe_trans like 'JPJ%' and tipe_trans not in ('JPJ-KPT-08') and not program_name = 'MIGPIUTANG' and tgl_inv between CONVERT(date, '" & deTglAwal.EditValue & "', 103) and CONVERT(date, '" & deTglAkhir.EditValue & "', 103) AND (no_posting IS NULL OR no_posting = '')) ", sqlconn))
            Else
                DA = New SqlDataAdapter(New SqlCommand("select '' as cek, a.*, (SELECT Tgl_sp FROM SALES.dbo.SALES_SO WHERE No_sp = a.no_ref2) tgl_sp, a.no_ref2 no_ref from FIN.DBO.FIN_NOTA a where a.tipe_trans like '" & lookJenis2.EditValue & "' and a.tipe_trans not in ('JPJ-KPT-08') and not a.program_name = 'MIGPIUTANG' and a.tgl_inv between CONVERT(date, '" & deTglAwal.EditValue & "', 103) and CONVERT(date, '" & deTglAkhir.EditValue & "', 103) AND (no_posting IS NULL OR no_posting = '')", sqlconn))
                DA1 = New SqlDataAdapter(New SqlCommand("SELECT * from FIN.DBO.FIN_NOTA_D where no_inv in (select no_inv from FIN.DBO.FIN_NOTA where tipe_trans like '" & lookJenis2.EditValue & "' and tipe_trans not in ('JPJ-KPT-08') and not program_name = 'MIGPIUTANG' and tgl_inv between CONVERT(date, '" & deTglAwal.EditValue & "', 103) and CONVERT(date, '" & deTglAkhir.EditValue & "', 103) AND (no_posting IS NULL OR no_posting = ''))", sqlconn))
                DA2 = New SqlDataAdapter(New SqlCommand("select * from FIN.DBO.v_jurnal_det where no_ref3 in (select no_inv from FIN.DBO.FIN_NOTA where tipe_trans like '" & lookJenis2.EditValue & "' and tipe_trans not in ('JPJ-KPT-08') and not program_name = 'MIGPIUTANG' and tgl_inv between CONVERT(date, '" & deTglAwal.EditValue & "', 103) and CONVERT(date, '" & deTglAkhir.EditValue & "', 103) AND (no_posting IS NULL OR no_posting = '')) ", sqlconn))
            End If
        Else
            If lookJenis2.EditValue = "0000000000" Then
                DA = New SqlDataAdapter(New SqlCommand("select '' cek, a.*, (SELECT tgl_po FROM PURC.dbo.PURC_PO WHERE no_po = a.no_ref1) tgl_order, a.no_ref1 no_ref from FIN.DBO.FIN_PEMBELIAN a where a.tipe_trans like 'JPP%' and not a.program_name = 'MIGPIUTANG' and tgl_inv between CONVERT(date, '" & deTglAwal.EditValue & "', 103) and CONVERT(date, '" & deTglAkhir.EditValue & "', 103) AND (no_posting IS NULL OR no_posting = '')", sqlconn))
                DA1 = New SqlDataAdapter(New SqlCommand("SELECT * from FIN.DBO.FIN_PEMBELIAN_D where no_inv in (select no_inv from FIN.DBO.FIN_PEMBELIAN where tipe_trans like 'JPP%' and not program_name = 'MIGPIUTANG' and tgl_inv between CONVERT(date, '" & deTglAwal.EditValue & "', 103) and CONVERT(date, '" & deTglAkhir.EditValue & "', 103) AND (no_posting IS NULL OR no_posting = ''))", sqlconn))
                DA2 = New SqlDataAdapter(New SqlCommand("select * from FIN.DBO.v_jurnal_det where no_ref3 in (select no_inv from FIN.DBO.FIN_PEMBELIAN where tipe_trans like 'JPP%' and not program_name = 'MIGPIUTANG' and tgl_inv between CONVERT(date, '" & deTglAwal.EditValue & "', 103) and CONVERT(date, '" & deTglAkhir.EditValue & "', 103) AND (no_posting IS NULL OR no_posting = '')) ", sqlconn))
            Else
                DA = New SqlDataAdapter(New SqlCommand("select '' cek, a.*, (SELECT tgl_po FROM PURC.dbo.PURC_PO WHERE no_po = a.no_ref1) tgl_order, a.no_ref1 no_ref from FIN.DBO.FIN_PEMBELIAN a where a.tipe_trans like '" & lookJenis2.EditValue & "' and not a.program_name = 'MIGPIUTANG' and a.tgl_inv between CONVERT(date, '" & deTglAwal.EditValue & "', 103) and CONVERT(date, '" & deTglAkhir.EditValue & "', 103) AND (no_posting IS NULL OR no_posting = '')", sqlconn))
                DA1 = New SqlDataAdapter(New SqlCommand("SELECT * from FIN.DBO.FIN_PEMBELIAN_D where no_inv in (select no_inv from FIN.DBO.FIN_PEMBELIAN where tipe_trans like '" & lookJenis2.EditValue & "' and not program_name = 'MIGPIUTANG' and tgl_inv between CONVERT(date, '" & deTglAwal.EditValue & "', 103) and CONVERT(date, '" & deTglAkhir.EditValue & "', 103) AND (no_posting IS NULL OR no_posting = ''))", sqlconn))
                DA2 = New SqlDataAdapter(New SqlCommand("select * from FIN.DBO.v_jurnal_det where no_ref3 in (select no_inv from FIN.DBO.FIN_PEMBELIAN where tipe_trans like '" & lookJenis2.EditValue & "' and not program_name = 'MIGPIUTANG' and tgl_inv between CONVERT(date, '" & deTglAwal.EditValue & "', 103) and CONVERT(date, '" & deTglAkhir.EditValue & "', 103) AND (no_posting IS NULL OR no_posting = ''))", sqlconn))
            End If
        End If
        DA.Fill(dSO, "_invheader")
        DA1.Fill(dSO, "_invdetailsj")
        DA2.Fill(dSO, "_invdetailsp")

        Dim rl, r2 As DataRelation
        rl = dSO.Relations.Add("DetailInv", dSO.Tables("_invheader").Columns("no_inv"), dSO.Tables("_invdetailsj").Columns("no_inv"))
        r2 = dSO.Relations.Add("DetailJurnal", dSO.Tables("_invheader").Columns("no_inv"), dSO.Tables("_invdetailsp").Columns("no_ref3"))

        GcInvoice.DataSource = dSO.Tables("_invheader")
        GcInvoice.LevelTree.Nodes.Add("DetailInv", gvdetailSJ)
        GcInvoice.LevelTree.Nodes.Add("DetailJurnal", gvdetailSP)
        Gvheader.BestFitColumns()
        gvdetailSJ.BestFitColumns()
        gvdetailSP.BestFitColumns()

    End Sub

    Private Sub ckcetak_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckcetak.CheckedChanged
        'If ckcetak.Checked = True Then
        '    For Each rw As DataRow In dSO.Tables("_invheader").Rows
        '        rw.Item("status") = "NOTA"
        '    Next
        'Else
        '    For Each rw As DataRow In dSO.Tables("_invheader").Rows
        '        rw.Item("status") = "SJ"
        '    Next
        'End If
    End Sub

    Private Sub deTglAwal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTglAwal.EditValueChanged
        deTglAkhir.Properties.MinValue = deTglAwal.EditValue
        deTglAkhir.EditValue = deTglAwal.EditValue
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        reloadGrid()
    End Sub

    Private Sub lookJenis_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lookJenis.QueryPopUp
        v_jenis()
    End Sub

    Private Sub lookJenis2_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lookJenis2.QueryPopUp
        v_jenis2()
    End Sub
End Class