Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Data
Public Class frmMaintenanceAnggaranDTL
    Dim ds1, ds2, ds3, dsx As New DataSet
    Dim da1, da2, da3, dax As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State, vfilter, vperiode, vkd_bk_pusat As String
    Dim BTRANS As SqlTransaction

    Public Sub setStatus()
        With prn
            '.btnAdd.Enabled = btnAdd
            '.btnCancel.Enabled = btnCancel
            '.btnDelete.Enabled = btnDelete
            '.btnEdit.Enabled = btnEdit
            '.btnSave.Enabled = btnSave
            Close()
        End With
    End Sub

    Private Sub frmTemplate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        collect_image()
        ds1 = New DataSet
        ds2 = New DataSet
        ds3 = New DataSet

        'showMessages("kode buku besar = " + vfilter)

        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_buku_besar, nm_buku_besar from SIF_buku_besar", sqlconn))
        da1.Fill(ds1, "bk_besar")

        LookUpBKBesar.DataSource = ds1.Tables("bk_besar")
        LookUpBKBesar.DisplayMember = "nm_buku_besar"
        LookUpBKBesar.ValueMember = "kd_buku_besar"

        da2 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.sif_anggaran where bln_buku <> 0 and thn_buku = '" & vperiode & "' and kd_buku_besar='" & vfilter & "' order by cast(bln_buku as integer)", sqlconn))
        da2.Fill(ds2, "_vdata_d")
        GC.DataSource = ds2.Tables("_vdata_d")

        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_buku_pusat, nm_buku_pusat from SIF_buku_pusat", sqlconn))
        da3.Fill(ds3, "bk_pusat")

        RnmBkPst.DataSource = ds3.Tables("bk_pusat")
        RnmBkPst.DisplayMember = "nm_buku_pusat"
        RnmBkPst.ValueMember = "kd_buku_pusat"
    End Sub

    Public Sub add_click()
        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnAdd = False
        State = "ADD"
        setStatus()
    End Sub

    Public Sub edit_click()
        Dim qstr As String = "select columns as [] " & _
                "from SIF.dbo.table "
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(qstr, sqlconn))
        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        da3.Fill(ds3, "lookup_so")
        frmCari.set_dso(ds3.Tables("lookup_so"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then


            State = "EDIT"
            btnSave = True
            btnAdd = False
            btnEdit = False
            btnDelete = True
            btnCancel = True
            setStatus()
            Me.Enabled = True
        End If
    End Sub
    Public Sub call_procedure()
        'vfilter = GbkBesar
        'vperiode = Gperiode
        'vkd_bk_pusat = Gkd_bk_pusat

        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "SIF.dbo.SIFP_UPD_HDR_ANGGARAN"
        sqlCmd.Parameters.Add("@PERIODE", SqlDbType.Char).Value = vperiode
        sqlCmd.Parameters.Add("@KD_BK_pst", SqlDbType.Char).Value = vkd_bk_pusat
        sqlCmd.Parameters.Add("@KD_BK_BESAR", SqlDbType.Char).Value = vfilter
        Dim dr As SqlDataReader = sqlCmd.ExecuteReader

        'MsgBox("data : " + vperiode + "," + vkd_bk_pusat + "," + vfilter)

    End Sub

    Public Sub save_click()
        mb = New SqlClient.SqlCommandBuilder(da2)

        da2.UpdateCommand = mb.GetUpdateCommand()
        da2.InsertCommand = mb.GetInsertCommand()
        da2.DeleteCommand = mb.GetDeleteCommand()

        BTRANS = sqlconn.BeginTransaction("1")

        da2.UpdateCommand.Transaction = BTRANS
        da2.InsertCommand.Transaction = BTRANS
        da2.DeleteCommand.Transaction = BTRANS

        Try
            da2.Update(ds2.Tables("_vdata_d"))
            ds2.Tables("_vdata_d").AcceptChanges()
            State = "EDIT"
            BTRANS.Commit()
            'showMessages("Saved..")
        Catch e As Exception
            ds2.Tables("_vdata_d").RejectChanges() 'untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message)
            BTRANS.Rollback()
        End Try
        call_procedure()
        FrmMaintenanceAnggaran.bersihkan()
        FrmMaintenanceAnggaran.isiGrid()
    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            showMessages("Deleted..")
            'cancel_click()
        End If
    End Sub

    Public Sub cancel_click()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
    End Sub

    Private Sub GV_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        Dim az, ab As String

        If e.Column Is kd_buku_pusat Then
            az = e.Value
        End If

        If e.Column Is nm_buku_besar Then
            ab = e.Value
        End If

        'MsgBox("test : " + az + ab)

    End Sub

    Private Sub GV_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub btAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btAdd.Click
        add_click()
    End Sub

    Private Sub btEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btEdit.Click
        edit_click()
    End Sub

    Private Sub btSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSave.Click
        save_click()
        'MsgBox("Data Tersimpan")
    End Sub

    Private Sub btDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btDel.Click
        delete_click()
    End Sub

    Private Sub btCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btCancel.Click
        cancel_click()
    End Sub
    Public Sub GetAllVariable(ByVal GbkBesar As String, ByVal Gperiode As String, ByVal Gkd_bk_pusat As String)
        ' ============= cretaed by Ming =============
        ' Get All Variabel yang dipasing dari form sebelumnya.
        vfilter = GbkBesar
        vperiode = Gperiode
        vkd_bk_pusat = Gkd_bk_pusat
    End Sub


End Class