Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class FrmCtkUlangNotaJual
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = True
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, ds_cari, ds_cari1 As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    'Private rw As DataRow
    Dim DA, DA1, DA2, DALOOKUP, DALOOKUP1 As SqlClient.SqlDataAdapter
    Dim rhandle As Int16
    Dim kon As Boolean = True
    Dim isOK As Boolean

    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            isOK = False

            For Each rw As DataRow In dSO.Tables("_invheader").Select("sts_nota <> ''", "")
                isOK = True
                Exit For
            Next

            If isOK Then
                For Each rw As DataRow In dSO.Tables("_invheader").Select("sts_nota <> ''", "")
                    With New SqlCommand("UPDATE FIN.dbo.FIN_NOTA SET sts_nota = 'NOTA' WHERE no_inv = '" & rw.Item("no_inv") & "'", sqlconn).ExecuteNonQuery

                    End With
                Next

                showMessages("Berhasil disimpan.")
                reloadGrid()
            Else
                MsgBox("Belum ada data yang dipilih.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "PERINGATAN")
                Exit Sub
            End If
        End If
    End Sub

    Public Sub cancel_click()
        If MsgBox("Perubahan data yang belum TERSIMPAN akan dikembalikan seperti semula, Batal?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
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
        Me.Enabled = True
        deTglAwal.EditValue = DateAdd(DateInterval.Month, -1, getTanggal())
        deTglAkhir.EditValue = getTanggal()
        lookJenis.EditValue = "0000000000"

        reloadGrid()

        prn = getParent(Me)
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        'cmdSimpan.Show()
        btnExit.Hide()
        btnDel.Hide()

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

    End Sub

    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        kon = False
        cetak_click()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Form akan ditutup, anda yakin akan keluar?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub

    Private Sub cetak_inv()
        For Each rw As DataRow In dSO.Tables("_invheader").Rows
            If rw.Item("status") = CekStat.ValueChecked Then
                'call_procedure_dtl(rw.Item("no_sj"))
                'callReport(App_Path() & "\report\repNotaJual.rpt", "", "no_sj=" & rw.Item("no_ref1"), True)
                MsgBox(rw.Item("no_ref1").ToString)
                'Dim sqlcmd As New SqlCommand("update fin.dbo.fin_nota set jml_cetak=isnull(jml_cetak,0)+1, tgl_cetak=getdate() where no_inv='" & rw.Item("no_inv") & "'", sqlconn)
                'sqlcmd.ExecuteNonQuery()
            End If
        Next
    End Sub

    Public Sub call_procedure_dtl(ByVal vnosj As String)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_INS_NOTA_JUAL"

        sqlCmd.Parameters.Add("@no_sj", SqlDbType.Char).Value = vnosj
        sqlCmd.ExecuteNonQuery()
        'showMessages("Generate detail data.......")
    End Sub

    Public Sub bersihkan()
        If Not dSO Is Nothing Then
            dSO.Clear()
        End If
        ckcetak.Checked = False
    End Sub

    Private Sub v_jenis()
        If Not ds_cari.Tables("Jenis") Is Nothing Then ds_cari.Tables("Jenis").Clear()

        DALOOKUP = New SqlDataAdapter(New SqlCommand("SELECT tipe_trans, SUBSTRING(tipe_desc, 8, 50) as nama FROM SIF.dbo.SIF_TIPE_TRANS WHERE tipe_trans LIKE 'JPJ%' AND tipe_trans NOT IN ('JPJ-KPT-08') UNION ALL SELECT '0000000000' as tipe_trans, '[Semua Penjualan]' as nama", sqlconn))
        DALOOKUP.Fill(ds_cari, "Jenis")
        lookJenis.Properties.DataSource = ds_cari.Tables("Jenis")
        lookJenis.Properties.ValueMember = "tipe_trans"
        lookJenis.Properties.DisplayMember = "nama"
    End Sub

    Public Sub reloadGrid()
        'DA = New SqlDataAdapter(New SqlCommand("select * from FIN.DBO.FIN_NOTA where tipe_trans not in ('JPJ-KPT-08')", sqlconn))
        'DA.Fill(dSO, "_invheader")
        'GcInvoice.DataSource = dSO.Tables("_invheader")
        dSO = New DataSet
        If lookJenis.EditValue = "0000000000" Then
            DA = New SqlDataAdapter(New SqlCommand("select a.*, (SELECT Tgl_sp FROM SALES.dbo.SALES_SO WHERE No_sp = a.no_ref2) tgl_sp from FIN.DBO.FIN_NOTA a where a.tipe_trans like 'JPJ%' and a.tipe_trans not in ('JPJ-KPT-08') and not a.program_name = 'MIGPIUTANG' and tgl_inv between CONVERT(date, '" & deTglAwal.EditValue & "', 103) and CONVERT(date, '" & deTglAkhir.EditValue & "', 103)", sqlconn))
            DA1 = New SqlDataAdapter(New SqlCommand("SELECT * from FIN.DBO.FIN_NOTA_D where no_inv in (select no_inv from FIN.DBO.FIN_NOTA where tipe_trans like 'JPJ%' and tipe_trans not in ('JPJ-KPT-08') and not program_name = 'MIGPIUTANG' and tgl_inv between CONVERT(date, '" & deTglAwal.EditValue & "', 103) and CONVERT(date, '" & deTglAkhir.EditValue & "', 103))", sqlconn))
            DA2 = New SqlDataAdapter(New SqlCommand("select * from FIN.DBO.v_jurnal_det where no_ref3 in (select no_inv from FIN.DBO.FIN_NOTA where tipe_trans like 'JPJ%' and tipe_trans not in ('JPJ-KPT-08') and not program_name = 'MIGPIUTANG' and tgl_inv between CONVERT(date, '" & deTglAwal.EditValue & "', 103) and CONVERT(date, '" & deTglAkhir.EditValue & "', 103)) ", sqlconn))
        Else
            DA = New SqlDataAdapter(New SqlCommand("select a.*, (SELECT Tgl_sp FROM SALES.dbo.SALES_SO WHERE No_sp = a.no_ref2) tgl_sp from FIN.DBO.FIN_NOTA a where a.tipe_trans like '" & lookJenis.EditValue & "' and a.tipe_trans not in ('JPJ-KPT-08') and not a.program_name = 'MIGPIUTANG' and a.tgl_inv between CONVERT(date, '" & deTglAwal.EditValue & "', 103) and CONVERT(date, '" & deTglAkhir.EditValue & "', 103)", sqlconn))
            DA1 = New SqlDataAdapter(New SqlCommand("SELECT * from FIN.DBO.FIN_NOTA_D where no_inv in (select no_inv from FIN.DBO.FIN_NOTA where tipe_trans like '" & lookJenis.EditValue & "' and tipe_trans not in ('JPJ-KPT-08') and not program_name = 'MIGPIUTANG' and tgl_inv between CONVERT(date, '" & deTglAwal.EditValue & "', 103) and CONVERT(date, '" & deTglAkhir.EditValue & "', 103))", sqlconn))
            DA2 = New SqlDataAdapter(New SqlCommand("select * from FIN.DBO.v_jurnal_det where no_ref3 in (select no_inv from FIN.DBO.FIN_NOTA where tipe_trans like '" & lookJenis.EditValue & "' and tipe_trans not in ('JPJ-KPT-08') and not program_name = 'MIGPIUTANG' and tgl_inv between CONVERT(date, '" & deTglAwal.EditValue & "', 103) and CONVERT(date, '" & deTglAkhir.EditValue & "', 103)) ", sqlconn))
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
        If ckcetak.Checked = True Then
            For Each rw As DataRow In dSO.Tables("_invheader").Rows
                rw.Item("status") = "NOTA"
            Next
        Else
            For Each rw As DataRow In dSO.Tables("_invheader").Rows
                rw.Item("status") = "SJ"
            Next
        End If

    End Sub

    Public Sub cetak_click()
        Dim viewx As ColumnView = Gvheader.Columns.View
        For Each rw As DataRow In dSO.Tables("_invheader").Select("sts_nota <> ''", "")

            If TypeOf rw.Item("status") Is DBNull Then
                MsgBox("Cetak ulang untuk nota ini masih belum di approve.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "PERINGATAN")
                Exit Sub
            ElseIf rw.Item("status") = "T" Then
                MsgBox("Cetak ulang untuk nota ini masih belum di approve.", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "PERINGATAN")
                Exit Sub
            End If

            Dim sqlcmd As New SqlCommand("update fin.dbo.fin_nota set jml_cetak=isnull(jml_cetak,0)+1, tgl_cetak=getdate(), status = 'T' where no_inv='" & rw("no_inv") & "'", sqlconn)
            sqlcmd.ExecuteNonQuery()

            If rw("sts_nota") = "NOTA" And rw("tipe_trans").ToString = SpringUmum Then
                'MsgBox(viewx.GetRowCellValue(rw, "sts_nota").ToString)
                'call_procedure_dtl(viewx.GetRowCellValue(rw, "no_sj").ToString)
                callReport(App_Path() & "\report\repNotaJualSpring.rpt", "", "no_sj=" & rw("no_sj"), True, False, "DIM")

            ElseIf rw("sts_nota") = "NOTA" And rw("tipe_trans").ToString = SponUmum Then
                'call_procedure_dtl(viewx.GetRowCellValue(rw, "no_sj").ToString)
                callReport(App_Path() & "\report\repNotaJualSpon.rpt", "", "no_sj=" & rw("no_sj"), True, False, "DIM")

            Else
                callReport(App_Path() & "\report\repNotaJualCentian.rpt", "", "no_sj=" & rw("no_sj"), True, False, "DIM")
            End If
        Next
        reloadGrid()
        kon = True
    End Sub

    Private Sub deTglAwal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deTglAwal.EditValueChanged
        deTglAkhir.Properties.MinValue = deTglAwal.EditValue
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        reloadGrid()
    End Sub

    Private Sub lookJenis_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lookJenis.QueryPopUp
        v_jenis()
    End Sub

    Private Sub Gvheader_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles Gvheader.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub Gvheader_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles Gvheader.ValidatingEditor
        Dim vx As GridView = sender

        'If vx.FocusedColumn.FieldName = "sts_nota" Then
        '    Dim dr As SqlDataReader = New SqlCommand("SELECT status FROM FIN.dbo.FIN_NOTA WHERE no_inv = '" & vx.GetFocusedRowCellValue("no_inv") & "'", sqlconn).ExecuteReader

        '    dr.Read()

        '    If TypeOf dr.Item(0) Is DBNull Then
        '        e.Valid = False
        '        e.ErrorText = "Cetak ulang untuk nota ini masih belum di approve."
        '    ElseIf dr.Item(0) = "T" Then
        '        e.Valid = False
        '        e.ErrorText = "Cetak ulang untuk nota ini masih belum di approve."
        '    Else
        '        e.Valid = True
        '        e.ErrorText = ""
        '    End If

        '    dr.Close()
        'End If
    End Sub
End Class