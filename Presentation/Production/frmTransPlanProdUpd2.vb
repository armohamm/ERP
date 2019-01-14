Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms

Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid

Public Class frmTransPlanProdUpd2

#Region "    inisialisasi"
    Dim dsGV, dsSave, dsTrans, dsSP, dsBarang As New DataSet
    Dim daMaster, daDetail, daMSave, daDSave, daTrans, daSP, daBarang As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
    Dim BTRANS As SqlTransaction
    Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Dim myBuilder As New SqlCommandBuilder
#End Region

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Private Sub reload(ByVal nomorid As String)
        If Not dsGV.Tables("DETAIL") Is Nothing Then dsGV.Tables("DETAIL").Clear()
        If Not dsGV.Tables("MASTER") Is Nothing Then dsGV.Tables("MASTER").Clear()

        daMaster = New SqlDataAdapter(New SqlCommand("select m.kd_jenis,j.Nama_Jenis from prod.dbo.prod_rcn_prod_m m, sif.dbo.sif_jenis_barang j where m.kd_jenis=j.kd_jns_brg and m.no_rph='" & nomorid & "'", sqlconn))
        daMaster.Fill(dsGV, "MASTER")

        daDetail = New SqlDataAdapter(New SqlCommand("select d.kd_jenis,d.no_sp, j.Nama_Jenis, b.Nama_Barang,d.jumlah,s.qty_sisa, s.tgl_kirim, s.prioritas,d.jml_indeks,0.00 nilai from prod.dbo.PROD_rcn_prod_d d, sif.dbo.sif_jenis_barang j, prod.dbo.prodv_mon_so s,sif.dbo.sif_barang b where d.no_sp=s.No_sp and s.Kd_Stok=b.kode_barang and d.kd_jenis=j.Kd_Jns_Brg and d.no_rph='" & nomorid & "'", sqlconn))
        daDetail.Fill(dsGV, "DETAIL")

        gcData.DataSource = dsGV.Tables("MASTER")

        no_sp.ColumnEdit = Nothing
        nama_barang.ColumnEdit = Nothing
        tboTanggal.Text = DateTime.Today
    End Sub

    Private Sub isiCombo()
        If Not dsTrans.Tables("RPH") Is Nothing Then dsTrans.Tables("RPH").Clear()

        daTrans = New SqlDataAdapter(New SqlCommand("select m.no_rph,d.desc_data from prod.dbo.PROD_rcn_prod_m m, sif.dbo.sif_gen_reff_d d where m.kd_jadwal=d.id_data and d.ref_role='PROD' and d.id_ref_data='JDWKRJ'", sqlconn))
        daTrans.Fill(dsTrans, "RPH")
        lueTrans.Properties.DataSource = dsTrans.Tables("RPH")
        lueTrans.Properties.ValueMember = "no_rph"
        lueTrans.Properties.DisplayMember = "no_rph"
    End Sub

    Private Sub frmTransPlanProdUpd2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        btnEdit = False
        btnDelete = False
        setStatus()
        State = "ADD"

        isiCombo()
        reload("")
        Dim rl As DataRelation
        rl = dsGV.Relations.Add("DetailKirim", dsGV.Tables("MASTER").Columns("kd_jenis"), dsGV.Tables("DETAIL").Columns("kd_jenis"))
        gcData.LevelTree.Nodes.Add("DetailKirim", gvDetail)
    End Sub

    Private Sub lueTrans_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueTrans.EditValueChanged
        reload(lueTrans.EditValue)
        tboJadwal.Text = lueTrans.Properties.GetDataSourceValue("desc_data", lueTrans.ItemIndex)
    End Sub

    Private Sub gvMain_MasterRowExpanding(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowCanExpandEventArgs) Handles gvMain.MasterRowExpanding
        If Not dsSP.Tables("SP") Is Nothing Then dsSP.Tables("SP").Clear()
        daSP = New SqlDataAdapter(New SqlCommand("select no_sp,nama_customer,nama_barang,qty_sisa,tgl_kirim,prioritas from PROD.dbo.PRODV_MON_SO  where nama_jenis='" & gvMain.GetFocusedRowCellValue("Nama_Jenis") & "'", sqlconn))
        daSP.Fill(dsSP, "SP")
        lueNoSP.DataSource = dsSP.Tables("SP")
        lueNoSP.ValueMember = "no_sp"
        lueNoSP.DisplayMember = "no_sp"

        If Not dsBarang.Tables("BARANG") Is Nothing Then dsBarang.Tables("BARANG").Clear()
        daBarang = New SqlDataAdapter(New SqlCommand("select nama_barang,no_sp,nama_customer,qty_sisa,tgl_kirim,prioritas from PROD.dbo.PRODV_MON_SO where nama_jenis='" & gvMain.GetFocusedRowCellValue("Nama_Jenis") & "'", sqlconn))
        daBarang.Fill(dsBarang, "BARANG")
        lueBarang.DataSource = dsBarang.Tables("BARANG")
        lueBarang.ValueMember = "no_sp"
        lueBarang.DisplayMember = "nama_barang"
    End Sub

    Private Sub gvDetail_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvDetail.CellValueChanged
        If gvDetail.IsNewItemRow(e.RowHandle) = False Then
            If e.Column Is jumlah Then
                Dim rw As DataRow
                rw = dsGV.Tables("DETAIL").Select("no_sp = '" & gvDetail.GetRow(e.RowHandle).item("no_sp") & "'")(0)

                gvDetail.SetRowCellValue(e.RowHandle, "jml_indeks", rw("nilai") * gvDetail.GetRow(e.RowHandle).item("jumlah"))
            End If
        End If
    End Sub

    Private Sub gvDetail_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvDetail.ValidateRow
        Dim isValid As Boolean = True
        If gvDetail.IsNewItemRow(e.RowHandle) = True Then
            If gvDetail.GetRowCellValue(e.RowHandle, "nama_barang") = "" AndAlso gvDetail.GetRowCellValue(e.RowHandle, "nama_barang") = "" AndAlso gvDetail.GetRowCellValue(e.RowHandle, "sisa") = "" AndAlso gvDetail.GetRowCellValue(e.RowHandle, "tgl_kirim") = "" AndAlso gvDetail.GetRowCellValue(e.RowHandle, "prioritas") = "" Then
                isValid = False
            End If
        End If
        If Not TypeOf (e.Row("qty_sisa")) Is DBNull And Not TypeOf (e.Row("jumlah")) Is DBNull Then
            If e.Row("jumlah") > e.Row("qty_sisa") Then
                gvDetail.SetColumnError(jumlah, "Jumlah Rencana Kirim Terlalu Banyak", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                isValid = False
            Else
                e.Row("jml_indeks") = e.Row("jumlah") * e.Row("nilai")
            End If
        End If
        e.Valid = isValid
    End Sub

    Private Sub gvDetail_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gvDetail.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.Ignore
    End Sub

    Private Sub gvDetail_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles gvDetail.FocusedRowChanged
        If gvDetail.IsNewItemRow(e.FocusedRowHandle) = True Then
            no_sp.ColumnEdit = lueNoSP
            nama_barang.ColumnEdit = lueBarang
        Else
            no_sp.ColumnEdit = Nothing
            nama_barang.ColumnEdit = Nothing
        End If
    End Sub

    Private Sub lueNoSP_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lueNoSP.EditValueChanged
        MsgBox(gvDetail.GetRowCellValue(-1, "no_sp"))
        'MsgBox(gvDetail.GetRowCellValue()
    End Sub

End Class