Imports System.Data.SqlClient

Public Class frmBiayaPacking
    Public btnSave As Boolean = True
    Public btnAdd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim DS, DSnj, DS2 As New DataSet
    Dim Builder As New SqlClient.SqlCommandBuilder
    Private Row As DataRow
    Dim DA, DAnj, DA2 As New SqlClient.SqlDataAdapter

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Public Sub save_click()
        Dim BTRANS As SqlTransaction
        Try
            'Dim drow As DataRow
            'For Each row As DataRow In DS.Tables("Packing").Rows
            '    'If row.RowState = DataRowState.Added Then
            '    drow = DS.Tables("Packing").NewRow
            '    drow.Item("kd_Cabang") = kdcabang
            '    drow.Item("kd_departemen") = kddep
            '    drow.Item("jenis_barang") = row.Item("jenis_barang")
            '    drow.Item("panjang_min") = row.Item("panjang_min")
            '    drow.Item("panjang_max") = row.Item("panjang_max")
            '    drow.Item("harga") = row.Item("harga")
            '    DS2.Tables("Packing").Rows.Add(drow)
            '    'Else
            '    'drow.Item("kd_Cabang") = kdcabang
            '    'drow.Item("kd_departemen") = kddep
            '    'drow.Item("jenis_barang") = row.Item("jenis_barang")
            '    'drow.Item("panjang_min") = row.Item("panjang_min")
            '    'drow.Item("panjang_max") = row.Item("panjang_max")
            '    'drow.Item("harga") = row.Item("harga")
            '    'End If
            'Next

            Builder = New SqlClient.SqlCommandBuilder(DA)
            DA.UpdateCommand = Builder.GetUpdateCommand()
            DA.InsertCommand = Builder.GetInsertCommand()
            DA.DeleteCommand = Builder.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            DA.UpdateCommand.Transaction = BTRANS
            DA.InsertCommand.Transaction = BTRANS
            DA.DeleteCommand.Transaction = BTRANS
            DA.Update(DS.Tables("Packing"))

            BTRANS.Commit()
            showMessages("Berhasil disimpan..!")
        Catch e As Exception
            BTRANS.Rollback()
            DS.Tables("Packing").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    Private Sub frmBiayaPacking_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        prn = getParent(Me)
        setStatus()
        connect()
        loadData()
        Me.Enabled = True
    End Sub

    Private Sub loadData()
        'DA2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.DBO.SIF_BIAYA_PACKING where 1=0", sqlconn))
        'If Not DS2.Tables("Packing") Is Nothing Then DS2.Tables("Packing").Clear()
        'DA2.Fill(DS2, "Packing")

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.DBO.SIF_BIAYA_PACKING", sqlconn))
        If Not DS.Tables("Packing") Is Nothing Then DS.Tables("Packing").Clear()
        If Not DSnj.Tables("Jenis") Is Nothing Then DSnj.Tables("Jenis").Clear()

        DA.Fill(DS, "Packing")
        gcPacking.DataSource = DS.Tables("Packing")

        DAnj = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kd_jns_brg,nama_jenis from sif.dbo.SIF_Jenis_Barang", sqlconn))
        If Not DSnj.Tables("Jenis") Is Nothing Then DSnj.Tables("Jenis").Clear()
        DAnj.Fill(DSnj, "Jenis")
        luvNamaJenis.DataSource = DSnj.Tables("Jenis")
        luvNamaJenis.DisplayMember = "nama_jenis"
        luvNamaJenis.ValueMember = "kd_jns_brg"
    End Sub

End Class