Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class FrmMaintenanceAnggaran
    Dim dsete, ds1, ds2, ds3, dsx, ds_klik As New DataSet
    Dim dadbe, DA, da1, da2, da3, dax, da_klik As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
    Dim prn As frmMain
    Dim BTRANS As SqlTransaction
    Dim data As SqlDataReader
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State, milih As String
    Dim myCommand As SqlClient.SqlCommand
    Dim objCommand As OleDb.OleDbCommand
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
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Private Sub reloadTable(ByVal kode As String)
        If Not dsete.Tables("DSERVICE") Is Nothing Then dsete.Tables("DSERVICE").Clear()
        If Not dsete.Tables("SOD") Is Nothing Then dsete.Tables("SOD").Clear()
        If Not dsete.Tables("SO") Is Nothing Then dsete.Tables("SO").Clear()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select thn_buku keterangan as periode from SIF_Periode_Buku", sqlconn))
        DA.Fill(dsete, "PERIODE")

        If dsete.Tables("PERIODE").Rows.Count > 0 Then
            Dim row As DataRow

            row = dsete.Tables("PERIODE").Rows(0)
            LookUpPeriode.Properties.DataSource = dsete.Tables("PERIODE")
            LookUpPeriode.Properties.DisplayMember = "keterangan"
            LookUpPeriode.Properties.ValueMember = "keterangan"
        Else
            LookUpPeriode.EditValue = vbNullString
        End If
    End Sub
    Private Sub frmTemplate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_buku_pusat, nm_buku_pusat from SIF_buku_pusat", sqlconn))
        DA.Fill(dsete, "VBARANG")
        rKode_BK_PST.DataSource = dsete.Tables("VBARANG")
        rKode_BK_PST.DisplayMember = "nm_buku_pusat"
        rKode_BK_PST.ValueMember = "kd_buku_pusat"

        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_buku_besar, nm_buku_besar from SIF_buku_besar", sqlconn))
        da1.Fill(ds1, "vBukuBesar")
        RnmBkBsr.DataSource = ds1.Tables("vBukuBesar")
        RnmBkBsr.DisplayMember = "nm_buku_besar"
        RnmBkBsr.ValueMember = "kd_buku_besar"

        'If Not dsete.Tables("PERIODE") Is Nothing Then dsete.Tables("PERIODE").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct thn_buku keterangan from SIF_Periode_Buku", sqlconn))
        DA.Fill(dsete, "PERIODE")


        If dsete.Tables("PERIODE").Rows.Count > 0 Then
            Dim row As DataRow

            row = dsete.Tables("PERIODE").Rows(0)
            LookUpPeriode.Properties.DataSource = dsete.Tables("PERIODE")
            LookUpPeriode.Properties.DisplayMember = "keterangan"
            LookUpPeriode.Properties.ValueMember = "keterangan"
        Else
            LookUpPeriode.EditValue = vbNullString
        End If

    End Sub
    Public Sub call_procedure()
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "SIF.dbo.SIFP_GEN_ANGGARAN"
        sqlCmd.Parameters.Add("@periode", SqlDbType.Char).Value = LookUpPeriode.EditValue
        Dim dr As SqlDataReader = sqlCmd.ExecuteReader

        showMessages("Menampilkan data.......")

    End Sub
    Public Sub call_procedure_dtl(ByVal vkd_bk_bsr As String, ByVal vNilai As Integer, ByVal vkd_bk_pst As String)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "SIF.dbo.SIFP_GEN_DTL_ANGGARAN"

        'showMessages("kd buku besar = " + vkd_bk_bsr + " Nilai = " + vNilai + " Periode = " + LookUpPeriode.EditValue)

        sqlCmd.Parameters.Add("@KD_BK_BESAR", SqlDbType.Char).Value = vkd_bk_bsr
        sqlCmd.Parameters.Add("@KD_BK_PUSAT", SqlDbType.Char).Value = vkd_bk_pst
        sqlCmd.Parameters.Add("@PERIODE", SqlDbType.Char).Value = LookUpPeriode.EditValue
        sqlCmd.Parameters.Add("@NILAI", SqlDbType.Char).Value = vNilai
        Dim dr As SqlDataReader = sqlCmd.ExecuteReader

        'showMessages("Generate detail data.......")

    End Sub
    Public Sub edit_click()


    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            showMessages("Deleted..")
            'cancel_click()
        End If
    End Sub
    Public Sub cancel_click()
        ' Klik Disini untuk melihat detail.
        Dim Gperiode, Gkd_bk_pusat As String

        milih = GV.GetRow(GV.GetSelectedRows(0)).Item(3).ToString()
        Gperiode = GV.GetRow(GV.GetSelectedRows(0)).Item(1).ToString()
        Gkd_bk_pusat = GV.GetRow(GV.GetSelectedRows(0)).Item(5).ToString()
        'showMessages("Form Detail Tampil" + milih)

        frmMaintenanceAnggaranDTL.GetAllVariable(milih, Gperiode, Gkd_bk_pusat)
        frmMaintenanceAnggaranDTL.ShowDialog()
    End Sub
    Private Sub simpan()
        mb = New SqlClient.SqlCommandBuilder(dax)

        dax.UpdateCommand = mb.GetUpdateCommand()
        dax.InsertCommand = mb.GetInsertCommand()
        dax.DeleteCommand = mb.GetDeleteCommand()

        BTRANS = sqlconn.BeginTransaction("1")

        dax.UpdateCommand.Transaction = BTRANS
        dax.InsertCommand.Transaction = BTRANS
        dax.DeleteCommand.Transaction = BTRANS

        Try
            dax.Update(dsx.Tables("SIF_anggaran"))
            dsx.Tables("SIF_anggaran").AcceptChanges()
            State = "EDIT"
            BTRANS.Commit()
            showMessages("Saved..")
        Catch e As Exception
            dsx.Tables("SIF_anggaran").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message)
            BTRANS.Rollback()
        End Try

    End Sub

    Public Sub bersihkan()
        If Not dsx Is Nothing Then
            dsx.Clear()
        End If

    End Sub

    Public Sub isiGrid()
        call_procedure()
        dax = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif_anggaran where bln_buku = 0 and thn_buku='" & LookUpPeriode.EditValue & "'", sqlconn))
        dax.Fill(dsx, "SIF_anggaran")
        GC.DataSource = dsx.Tables("SIF_anggaran")
    End Sub

    Private Sub LookUpPeriode_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LookUpPeriode.EditValueChanged
        bersihkan()
        isiGrid()
    End Sub
      Private Sub GV_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        If e.Column Is jml_trans Then
            Dim val1, val2 As String

            val1 = GV.GetRowCellValue(e.RowHandle, "kd_buku_besar")
            val2 = GV.GetRowCellValue(e.RowHandle, "kd_buku_pusat")

            call_procedure_dtl(val1, e.Value.ToString, val2)
            'showMessages("Saved.." + e.Value.ToString + val1)
        End If

        If e.Column Is PusatBiaya Then
            Dim rw As DataRow
            rw = dsete.Tables("VBARANG").Select("kd_buku_pusat='" & e.Value & "'")(0)
            'GV.GetRow(e.RowHandle).item("kd_buku_pusat") = rw("kd_buku_pusat")
        End If

        
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        simpan()
        'showMessages("OK")
    End Sub
    Private Sub GV_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs)
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'add_click()
    End Sub

    Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        edit_click()
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        delete_click()
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lnkDetail.Click
        cancel_click()
    End Sub
    Private Sub GV_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs)
        GV.UpdateCurrentRow()
    End Sub

End Class