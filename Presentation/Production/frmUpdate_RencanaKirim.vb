Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Public Class frmUpdate_RencanaKirim
    Dim ds1, ds2, ds3, dslookup As New DataSet
    Dim da1, da2, da3, da4, da_blthn As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
    Dim BTRANS As SqlTransaction
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA, DAD As SqlDataAdapter
    Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode
    Dim noGiro() As String
    Dim obj As Object
    Dim prn As frmMain
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False

    Public State As String
    Dim myBuilder As New SqlCommandBuilder

    Public Sub call_procedure(ByVal noG As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "PROD.dbo.prodp_upd_sopir"

        sqlCmd.Parameters.Add("@vno_trans", SqlDbType.Char).Value = noG
        sqlCmd.ExecuteNonQuery()
    End Sub

    Private Sub frmUpdate_RencanaKirim_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        Loadblthn()
        'reload_data()
        kendaraan()
        sopir()
        karni()

    End Sub

    Private Sub kendaraan()
        If Not ds1.Tables("Kendaraan") Is Nothing Then ds1.Tables("Kendaraan").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Kendaraan where rec_stat = 'Y' order by Nama_Kendaraan", sqlconn))
        da1.Fill(ds1, "Kendaraan")
        lknopol.DataSource = ds1.Tables("Kendaraan")
    End Sub

    Private Sub sopir()
        If Not ds1.Tables("Sopir") Is Nothing Then ds1.Tables("Sopir").Clear()
        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Sopir where rec_stat ='Y' and Stat_job = upper('sopir')", sqlconn))
        da1.Fill(ds1, "Sopir")
        lksopir.DataSource = ds1.Tables("Sopir")
    End Sub

    Private Sub karni()
        If Not ds1.Tables("Karni") Is Nothing Then ds1.Tables("Karni").Clear()
        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Sopir where rec_stat ='Y' and Stat_job = upper('kerani')", sqlconn))
        da1.Fill(ds1, "Karni")
        lk_kenek.DataSource = ds1.Tables("Karni")
    End Sub

    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder

        btnSave = True
        btnEdit = False
        btnadd = False
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

    Sub reload_data()
        Dim sql As String
        If Not ds1.Tables("MASTER") Is Nothing Then ds1.Tables("MASTER").Clear()

        sql = " and no_trans like '" & lookupBulanAwal.EditValue & "%'"
        da2 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rcn_krm_m where (rec_stat <> 'N' or rec_stat is null)" & sql, sqlconn))
        da2.Fill(ds1, "MASTER")
        GC_Kirim.DataSource = ds1.Tables("MASTER")
    End Sub
    Public Sub save_click()
        'If MsgBox("Perubahan Data akan disimpan dalam Database??", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan()

        'showMessages("Data Berhasil Disimpan")
        simpan()
    End Sub
    Public Sub simpan()
        Dim builder As New SqlCommandBuilder(da2)
        ReDim noGiro(0)

        For Each rw As DataRow In ds1.Tables("MASTER").Rows
            If rw.RowState = DataRowState.Added Then
                noGiro(noGiro.Length - 1) = rw.Item("no_trans")
                rw("Kd_Cabang") = getKodeCabang()
                rw("Last_Create_Date") = Now
                rw("Last_Created_By") = umum.username
                rw("Program_Name") = Me.Name
                ReDim Preserve noGiro(noGiro.Length)
            ElseIf rw.RowState = DataRowState.Modified Then
                noGiro(noGiro.Length - 1) = rw.Item("no_trans")
                rw.Item("Last_Update_Date") = Now
                rw.Item("Last_Updated_By") = username
                rw("upd_sopir") = "Y"
                ReDim Preserve noGiro(noGiro.Length)
            End If
        Next

        da2.InsertCommand = builder.GetInsertCommand()
        da2.UpdateCommand = builder.GetUpdateCommand()
        da2.DeleteCommand = builder.GetDeleteCommand()

        BTRANS = sqlconn.BeginTransaction("1")
        da2.UpdateCommand.Transaction = BTRANS
        da2.InsertCommand.Transaction = BTRANS
        da2.DeleteCommand.Transaction = BTRANS

        da2.Update(ds1, "MASTER")
        ds1.Tables("MASTER").AcceptChanges()

        For jml As Integer = 0 To noGiro.Length - 2
            call_procedure(noGiro(jml), BTRANS)
        Next

        BTRANS.Commit()
        showMessages("Data Berhasil di Update..!", 14)
    End Sub
    Private Sub Loadblthn()
        If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
        da_blthn = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        da_blthn.Fill(dsLookUp, "LookPeriode")
        lookupBulanAwal.Properties.DataSource = dsLookUp.Tables("LookPeriode")
        lookupBulanAwal.Properties.DisplayMember = "nama"
        lookupBulanAwal.Properties.ValueMember = "thnbln"

    End Sub

    Private Sub lookupBulanAwal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookupBulanAwal.EditValueChanged
        reload_data()
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        reload_data()
    End Sub

    Private Sub lk_kenek_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lk_kenek.QueryPopUp
        karni()
    End Sub

    Private Sub lksopir_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lksopir.QueryPopUp
        sopir()
    End Sub

    Private Sub lknopol_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lknopol.QueryPopUp
        kendaraan()
    End Sub
End Class