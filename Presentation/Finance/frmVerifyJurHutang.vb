Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlDataAdapter
Public Class frmVerifyJurHutang
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dSO, ds_cari, ds_cari1 As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    'Private rw As DataRow
    Dim DA, DA1, DA2, DALOOKUP, DALOOKUP1 As SqlClient.SqlDataAdapter
    Dim rhandle As Int16

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

    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            simpan()
            If Not dSO Is Nothing Then
                dSO.Clear()
                reloadGrid()
            End If
            STATE = ""
            btnSave = False
            setStatus()
        End If
    End Sub

    Public Sub cancel_click()
        If MsgBox("Perubahan data yang belum TERSIMPAN akan dikembalikan seperti semula, Batal?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub

    'Public Sub delete_click()
    '    If MsgBox("Form Approve akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus_record()
    'End Sub

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Public Sub simpan(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction

        For Each rw As DataRow In dSO.Tables("_invheader").Rows
            If rw.RowState = DataRowState.Modified Then
                rw.Item("Last_Update_Date") = Now
                rw.Item("Last_Updated_By") = username
            End If
        Next

        Try
            Dim builder As New SqlCommandBuilder(DA)
            DA.InsertCommand = builder.GetInsertCommand()
            DA.UpdateCommand = builder.GetUpdateCommand()
            DA.DeleteCommand = builder.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS

            BTRANS.Commit()
            DA.Update(dSO, ("_invheader"))
            dSO.Tables("_invheader").AcceptChanges()

            For Each rw As DataRow In dSO.Tables("_invheader").Rows
                If rw.Item("sts_jur").Equals(CekStat.ValueChecked) Then
                    call_procedure(rw.Item("tipe_trans"), rw.Item("no_inv"))
                End If
            Next
            STATE = "EDIT"
            showMessages("Berhasil disimpan..")
        Catch e As Exception
            dSO.Tables("_invheader").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            'dSO.Tables("_tipe_trans_d").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try

    End Sub

    Private Sub frmMstTipeTranKeu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        DA = New SqlDataAdapter(New SqlCommand("select * from FIN.DBO.FIN_PEMBELIAN where tipe_trans like '%KUT%' and (tgl_posting is null or tgl_posting ='') and (no_jurnal is null or no_jurnal ='')", sqlconn))
        DA.Fill(dSO, "_invheader")

        DA1 = New SqlDataAdapter(New SqlCommand("SELECT * from FIN.DBO.FIN_PEMBELIAN_D where no_inv in (select no_inv from FIN.DBO.FIN_PEMBELIAN where tipe_trans like '%KUT%' and (tgl_posting is null or tgl_posting ='') and (no_jurnal is null or no_jurnal =''))", sqlconn))
        DA1.Fill(dSO, "_invdetailBL")

        DA2 = New SqlDataAdapter(New SqlCommand("select * from FIN.DBO.FIN_JURNAL_D where no_jur in (select no_inv from FIN.DBO.FIN_PEMBELIAN where tipe_trans like '%KUT%' and (tgl_posting is null or tgl_posting ='') and (no_jurnal is null or no_jurnal =''))", sqlconn))
        DA2.Fill(dSO, "_invdetailJR")

        Dim rl, r2 As DataRelation
        rl = dSO.Relations.Add("DetailHUT", dSO.Tables("_invheader").Columns("no_inv"), dSO.Tables("_invdetailBL").Columns("no_inv"))
        r2 = dSO.Relations.Add("DetailJUR", dSO.Tables("_invheader").Columns("no_inv"), dSO.Tables("_invdetailJR").Columns("no_jur"))

        GcInvoice.DataSource = dSO.Tables("_invheader")
        GcInvoice.LevelTree.Nodes.Add("DetailHUT", gvdetailSJ)
        GcInvoice.LevelTree.Nodes.Add("DetailJUR", gvdetailSP)

        prn = getParent(Me)
        'prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        Me.Enabled = True
        'cmdSimpan.Show()
        'btnExit.Hide()
        'btnDel.Hide()

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select kode, nama from FIN.dbo.v_kartu", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup1")
        Lookupkartu.DataSource = ds_cari.Tables("_lookup1")
        Lookupkartu.ValueMember = "kode"
        Lookupkartu.DisplayMember = "nama"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup2")
        Lookupbrg.DataSource = ds_cari.Tables("_lookup2")
        Lookupbrg.ValueMember = "Kode_Barang"
        Lookupbrg.DisplayMember = "Nama_Barang"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select kd_buku_besar, nm_buku_besar from SIF.dbo.SIF_buku_besar", sqlconn))
        DALOOKUP.Fill(ds_cari, "_lookup3")
        lookuprek.DataSource = ds_cari.Tables("_lookup3")
        lookuprek.ValueMember = "kd_buku_besar"
        lookuprek.DisplayMember = "nm_buku_besar"

        DALOOKUP = New SqlDataAdapter(New SqlCommand("select tipe_trans, tipe_desc from SIF.dbo.SIF_TIPE_TRANS", sqlconn))
        DALOOKUP.Fill(ds_cari, "LookTT")
        lookupTrans.DataSource = ds_cari.Tables("LookTT")
        lookupTrans.ValueMember = "tipe_trans"
        lookupTrans.DisplayMember = "tipe_desc"

    End Sub

    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        'If MsgBox("Data akan simpan & di cetak mas bro ...??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '    simpan()
        '    cetak_inv()
        'End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If MsgBox("Form akan ditutup, Anda Yakin Exit???", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()
    End Sub

    Private Sub cetak_inv()
        For Each rw As DataRow In dSO.Tables("_invheader").Rows
            If rw.Item("sts_nota") = CekStat.ValueChecked Then
                call_procedure_dtl(rw.Item("no_sj"))
                callReport(App_Path() & "\report\InvoiceJual.rpt", "", "vno_sj=" & rw.Item("no_sj"), False)
            End If
        Next
        bersihkan()
        reloadGrid()
    End Sub

    Public Sub call_procedure_dtl(ByVal vnosj As String)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_INS_NOTA_JUAL"

        sqlCmd.Parameters.Add("@no_sj", SqlDbType.Char).Value = vnosj
        Dim dr As SqlDataReader = sqlCmd.ExecuteReader
        'showMessages("Generate detail data.......")
    End Sub

    Public Sub bersihkan()
        If Not dSO Is Nothing Then
            dSO.Clear()
        End If
        ckcetak.Checked = False
    End Sub

    Public Sub reloadGrid()
        'DA = New SqlDataAdapter(New SqlCommand("select *,(select tgl_sp from SALES.dbo.SALES_SO b where b.No_sp=a.no_sp) tgl_order from SALES.DBO.SALES_SJ a where (a.sts_nota is null or a.sts_nota ='') ", sqlconn))
        'DA.Fill(dSO, "_invheader")
        'GcInvoice.DataSource = dSO.Tables("_invheader")

        DA = New SqlDataAdapter(New SqlCommand("select * from FIN.DBO.FIN_PEMBELIAN where tipe_trans like '%KUT%' and (tgl_posting is null or tgl_posting ='') and (no_jurnal is null or no_jurnal ='')", sqlconn))
        DA.Fill(dSO, "_invheader")

        DA1 = New SqlDataAdapter(New SqlCommand("SELECT * from FIN.DBO.FIN_PEMBELIAN_D where no_inv in (select no_inv from FIN.DBO.FIN_PEMBELIAN where tipe_trans like '%KUT%' and (tgl_posting is null or tgl_posting ='') and (no_jurnal is null or no_jurnal =''))", sqlconn))
        DA1.Fill(dSO, "_invdetailBL")

        DA2 = New SqlDataAdapter(New SqlCommand("select * from FIN.DBO.FIN_JURNAL_D where no_jur in (select no_inv from FIN.DBO.FIN_PEMBELIAN where tipe_trans like '%KUT%' and (tgl_posting is null or tgl_posting ='') and (no_jurnal is null or no_jurnal =''))", sqlconn))
        DA2.Fill(dSO, "_invdetailJR")
    End Sub

    Private Sub ckcetak_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckcetak.CheckedChanged
        If ckcetak.Checked = True Then
            For Each rw As DataRow In dSO.Tables("_invheader").Rows
                rw.Item("sts_nota") = "NOTA"
            Next
        Else
            For Each rw As DataRow In dSO.Tables("_invheader").Rows
                rw.Item("sts_nota") = ""
            Next
        End If

    End Sub

    Private Sub Gvheader_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles Gvheader.CellValueChanging
        If e.Column Is sts_jur Then
            If e.Value.Equals(CekStat.ValueChecked) Then
                btnSave = True
                setStatus()
            Else
                btnSave = False
                setStatus()
            End If
        End If
    End Sub

    Public Sub call_procedure(ByVal no_jur As String, ByVal no_post As String)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_CATALOG_MAKEJUR"

        sqlCmd.Parameters.Add("@tipe_trans", SqlDbType.Char).Value = no_jur
        sqlCmd.Parameters.Add("@no_inv", SqlDbType.Char).Value = no_post
        Dim dr As SqlDataReader = sqlCmd.ExecuteReader
        dr.Close()
    End Sub
End Class