'####### by KENTANG ######

Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraEditors.Controls

Public Class frmNoTransaksi
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = True
    Public btnEdit As Boolean = False
    Public prn As frmMain '<-- untuk mengakses frmMain
    Dim dsNT, dsDept As New DataSet
    Dim daNT, daLookUpDept, daKode As SqlDataAdapter

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Public Sub add_click()
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = False
        btnDelete = True
        setStatus()
    End Sub

    Public Sub save_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()
    End Sub

    Public Sub delete_click()
        If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then hapus()
    End Sub

    Public Sub simpan()
        Dim builder As New SqlCommandBuilder(daNT)

        For Each rw As DataRow In dsNT.Tables("SIF_NT").Rows
            If rw.RowState = DataRowState.Added Then
                rw("Kd_Cabang") = getKodeCabang()
                rw("Last_Create_Date") = Now
                rw("Last_Created_By") = umum.username
                rw("Program_Name") = Me.Name

            ElseIf rw.RowState = DataRowState.Modified Then
                rw.Item("Last_Update_Date") = Now
                rw.Item("Last_Updated_By") = username
            End If
        Next

        daNT.InsertCommand = builder.GetInsertCommand()
        daNT.UpdateCommand = builder.GetUpdateCommand()
        daNT.DeleteCommand = builder.GetDeleteCommand()
        daNT.Update(dsNT, "SIF_NT")
        dsNT.Tables("SIF_NT").AcceptChanges()
        showMessages("Data Berhasil di Update..!", 14)
    End Sub

    Public Sub hapus()
        Dim builder As New SqlCommandBuilder(daNT)
        Dim row As DataRow
        Dim rows() As DataRow
        Dim i As Integer

        ReDim rows(gvNoTrans.SelectedRowsCount - 1)
        For i = 0 To gvNoTrans.SelectedRowsCount - 1
            rows(i) = gvNoTrans.GetDataRow(gvNoTrans.GetSelectedRows(i))
        Next
        gvNoTrans.BeginSort()
        Try
            For Each row In rows
                row.Delete()
            Next
        Finally
            gvNoTrans.EndSort()
        End Try
        simpan()
    End Sub

    Private Sub frmNoTransaksi_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        daNT = New SqlDataAdapter(New SqlCommand("SELECT * FROM SIF.dbo.SIF_no_trans_param", sqlconn))
        daNT.Fill(dsNT, "SIF_NT")
        gcNoTrans.DataSource = dsNT.Tables("SIF_NT")
        fillDept()
        fillPeriode()
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
    End Sub

    Private Sub fillDept()
        daLookUpDept = New SqlDataAdapter(New SqlCommand("select Kd_Departemen, Nama_Departemen from SIF.dbo.SIF_Departemen", sqlconn))
        daLookUpDept.Fill(dsDept, "cari_Dept")
        LookUpEditDept.DataSource = dsDept.Tables("cari_Dept")
        LookUpEditDept.ValueMember = "Kd_Departemen"
        LookUpEditDept.DisplayMember = "Nama_Departemen"
    End Sub

    Private Sub fillPeriode()
        Dim tPer As DataTable = New DataTable("Periode")
        Dim tCol As DataColumn
        Dim tRow As DataRow
        tCol = New DataColumn
        tCol.DataType = System.Type.GetType("System.String")
        tCol.ColumnName = "Periode"
        tCol.Caption = "Periode"
        tCol.ReadOnly = False
        tCol.Unique = True
        tPer.Columns.Add(tCol)
        tRow = tPer.NewRow()
        tRow(0) = "HARI"
        tPer.Rows.Add(tRow)
        tRow = tPer.NewRow()
        tRow(0) = "BLN"
        tPer.Rows.Add(tRow)
        tRow = tPer.NewRow()
        tRow(0) = "THN"
        tPer.Rows.Add(tRow)
        tRow = tPer.NewRow()
        tRow(0) = "ALL"
        tPer.Rows.Add(tRow)
        LookUpEditPeriode.DataSource = tPer
        LookUpEditPeriode.ValueMember = "Periode"
        LookUpEditPeriode.DisplayMember = "Periode"
        LookUpEditPeriode.NullText = "[Pilih Disini]"
    End Sub
End Class