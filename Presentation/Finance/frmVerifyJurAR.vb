Imports System.Data.SqlClient

Public Class frmVerifyJurAR
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public prn As frmMain
    Dim dsJurnalAR As New DataSet
    Dim daNota, daNotaD, daTT, daKartu, daBarang As SqlDataAdapter
    Public STATE As String
    Dim rl, r2 As DataRelation
    Dim BTRANS As SqlTransaction
    Dim myBuilder As New SqlCommandBuilder

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

    Private Sub loadData()
        If STATE = "SAVED" Then
            daNota = New SqlDataAdapter(New SqlCommand("select * FROM FIN.dbo.FIN_NOTA WHERE no_jurnal IS NULL or no_jurnal = ''", sqlconn))
            daNota.Fill(dsJurnalAR, "Nota")
            daNotaD = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA_D WHERE no_inv IN (select no_inv FROM FIN.dbo.FIN_NOTA WHERE no_jurnal IS NULL or no_jurnal = '')", sqlconn))
            daNotaD.Fill(dsJurnalAR, "NotaD")
            STATE = ""
        Else
            daNota = New SqlDataAdapter(New SqlCommand("select * FROM FIN.dbo.FIN_NOTA WHERE no_jurnal IS NULL or no_jurnal = ''", sqlconn))
            daNota.Fill(dsJurnalAR, "Nota")
            daNotaD = New SqlDataAdapter(New SqlCommand("SELECT * FROM FIN.dbo.FIN_NOTA_D WHERE no_inv IN (select no_inv FROM FIN.dbo.FIN_NOTA WHERE no_jurnal IS NULL or no_jurnal = '')", sqlconn))
            daNotaD.Fill(dsJurnalAR, "NotaD")
            rl = dsJurnalAR.Relations.Add("DetailNota", dsJurnalAR.Tables("Nota").Columns("no_inv"), dsJurnalAR.Tables("NotaD").Columns("no_inv"))
            gcJAR.DataSource = dsJurnalAR.Tables("Nota")
            gcJAR.LevelTree.Nodes.Add("DetailNota", gvNotaDetil)
            gvNota.BestFitColumns()
            gvNotaDetil.BestFitColumns()
        End If


        daKartu = New SqlDataAdapter(New SqlCommand("select kode, nama from FIN.dbo.v_kartu", sqlconn))
        daKartu.Fill(dsJurnalAR, "LookKartu")
        lueLookKartu.DataSource = dsJurnalAR.Tables("LookKartu")
        lueLookKartu.ValueMember = "kode"
        lueLookKartu.DisplayMember = "nama"

        daBarang = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        daBarang.Fill(dsJurnalAR, "LookBarang")
        lueLookBarang.DataSource = dsJurnalAR.Tables("LookBarang")
        lueLookBarang.ValueMember = "Kode_Barang"
        lueLookBarang.DisplayMember = "Nama_Barang"

        daTT = New SqlDataAdapter(New SqlCommand("select tipe_trans, tipe_desc from SIF.dbo.SIF_TIPE_TRANS", sqlconn))
        daTT.Fill(dsJurnalAR, "LookTT")
        lueLookTT.DataSource = dsJurnalAR.Tables("LookTT")
        lueLookTT.ValueMember = "tipe_trans"
        lueLookTT.DisplayMember = "tipe_desc"
    End Sub

    Private Sub frmVerifyJurAR_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        Me.Enabled = True
        loadData()
    End Sub

    Private Sub gvNota_CellValueChanging(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvNota.CellValueChanging
        If e.Column Is sts_jurnal Then
            If e.Value.Equals(CekStat.ValueChecked) Then
                btnSave = True
                setStatus()
            Else
                btnSave = False
                setStatus()
            End If
        End If
    End Sub

    Public Sub simpan(Optional ByRef isDelete As Boolean = False)
        For Each rw As DataRow In dsJurnalAR.Tables("Nota").Rows
            If rw.RowState = DataRowState.Modified Then
                rw.Item("Last_update_date") = Now
                rw.Item("Last_updated_by") = username
            End If
        Next

        Try
            myBuilder = New SqlCommandBuilder(daNota)
            daNota.InsertCommand = myBuilder.GetInsertCommand()
            daNota.UpdateCommand = myBuilder.GetUpdateCommand()
            daNota.DeleteCommand = myBuilder.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            daNota.UpdateCommand.Transaction = BTRANS
            daNota.InsertCommand.Transaction = BTRANS
            daNota.DeleteCommand.Transaction = BTRANS

            BTRANS.Commit()
            daNota.Update(dsJurnalAR, ("Nota"))
            dsJurnalAR.Tables("Nota").AcceptChanges()
            For Each rw As DataRow In dsJurnalAR.Tables("Nota").Rows
                If rw.Item("sts_jurnal").Equals(CekStat.ValueChecked) Then
                    call_procedure(rw.Item("tipe_trans"), rw.Item("no_inv"))
                End If
            Next
            STATE = "SAVED"
            showMessages("Berhasil disimpan..")
        Catch e As Exception
            dsJurnalAR.Tables("Nota").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
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

    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            simpan()
            If Not dsJurnalAR Is Nothing Then
                dsJurnalAR.Clear()
                loadData()
            End If
            STATE = ""
            btnSave = False
            setStatus()
        End If
    End Sub
End Class