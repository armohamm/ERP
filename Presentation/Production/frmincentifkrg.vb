Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base

Public Class frmincentifkrg
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim ds1, ds2, ds3 As New DataSet
    Dim da1, da2, da3, da4, da5, da6, da7 As New SqlDataAdapter
    Dim row As DataRow
    Dim mb, mb1, mb2 As New SqlCommandBuilder
    Dim BTRANS As SqlTransaction
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim obj As Object
    Dim state As String
    Dim myBuilder As New SqlCommandBuilder
    Dim dsMon, dsNoRPH As New DataSet
    Dim daMon, daNoRPH As SqlDataAdapter
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Private Sub frmincentifkrg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        setStatus()
        Me.Enabled = True
        gvMain.BestFitColumns()
        reload()
        
    End Sub
        sub reload()

        If Not ds1.Tables("krg") Is Nothing Then ds1.Tables("krg").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_insentif_centi_krg ", sqlconn))
        da1.Fill(ds1, "krg")


        If Not ds1.Tables("tampil") Is Nothing Then ds1.Tables("tampil").Clear()
        da3 = New SqlDataAdapter(New SqlCommand("select a.*,b.Kode_bagian from PROD.dbo.PROD_insentif_centi_krg a,SIF.dbo.SIF_Pegawai b where 1=0 ", sqlconn))
        da3.Fill(ds1, "tampil")
        gc.DataSource = ds1.Tables("tampil")

        If Not ds1.Tables("peg") Is Nothing Then ds1.Tables("peg").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select Kode_Pegawai as kd_pegawai,Nama_Pegawai from SIF.dbo.SIF_Pegawai", sqlconn))
        da2.Fill(ds1, "peg")
        lepegawai.DataSource = ds1.Tables("peg")
    End Sub




    Public Sub add_click()

        state = "ADD"
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
    End Sub

    Private Sub gvMain_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvMain.CellValueChanged
        If e.Column.Name = "kd_pegawai" Then

            Dim u As Object
            Dim pegawai, bagian As String
            u = CType(gc.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
            pegawai = u.GetRowCellValue(e.RowHandle, "kd_pegawai")



            If Not ds1.Tables("bag") Is Nothing Then ds1.Tables("bag").Clear()
            da4 = New SqlDataAdapter(New SqlCommand("select isnull(Kode_bagian,'') Kode_bagian from SIF.dbo.SIF_Pegawai where Kode_Pegawai= '" & pegawai & "'", sqlconn))
            da4.Fill(ds1, "bag")
            bagian = ds1.Tables("bag").Rows(0).Item("Kode_bagian")
            u.SetRowCellValue(e.RowHandle, "Kode_bagian", bagian)

        End If
        If e.Column.Name = "tanggal_absen" Then
            Dim x As Object
            Dim tglabsn, tgl As String
            x = CType(gc.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
            tglabsn = x.GetRowCellValue(e.RowHandle, "tanggal_absen")
            tgl = x.SetRowCellValue(e.RowHandle, "tanggal", tglabsn)

        End If
    End Sub
    Public Sub save_click()
        If state = "ADD" Then '----------Simpan ADD

            Dim tgl As Date = getTanggal()

            Dim BTRANS As SqlTransaction
            mb = New SqlClient.SqlCommandBuilder(da1)
            da1.UpdateCommand = mb.GetUpdateCommand()
            da1.InsertCommand = mb.GetInsertCommand()
            da1.DeleteCommand = mb.GetDeleteCommand()



            BTRANS = sqlconn.BeginTransaction("1")
            da1.UpdateCommand.Transaction = BTRANS
            da1.InsertCommand.Transaction = BTRANS
            da1.DeleteCommand.Transaction = BTRANS


         

            Dim rowb1 As DataRow

            For i As Integer = 0 To ds1.Tables("tampil").Rows.Count - 1
               
                rowb1 = ds1.Tables("krg").NewRow
                rowb1("last_create_date") = tgl
                rowb1("last_created_by") = username
                rowb1("program_name") = Me.Name
                rowb1("kd_cabang") = kdcabang
                rowb1("kd_departemen") = kddep
                rowb1("kd_kegiatan") = gvMain.GetRowCellValue(i, "Kode_bagian").ToString
                rowb1("tanggal_absen") = gvMain.GetRowCellValue(i, "tanggal_absen").ToString
                rowb1("tanggal") = gvMain.GetRowCellValue(i, "tanggal").ToString
                rowb1("kd_pegawai") = gvMain.GetRowCellValue(i, "kd_pegawai").ToString
                ds1.Tables("krg").Rows.Add(rowb1)



            Next

            Try

                da1.Update(ds1.Tables("krg"))

                ds1.Tables("krg").AcceptChanges()

                BTRANS.Commit()


                showMessages("Data Berhasil Disimpan")
                state = "ADD"
                reload()
            Catch e As Exception
                BTRANS.Rollback()
                ds1.Tables("krg").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

            End Try
        ElseIf state = "ADD" Then

            Dim tgl As Date = getTanggal()

            Dim BTRANS As SqlTransaction
            mb = New SqlClient.SqlCommandBuilder(da1)
            da1.UpdateCommand = mb.GetUpdateCommand()
            da1.InsertCommand = mb.GetInsertCommand()
            da1.DeleteCommand = mb.GetDeleteCommand()



            BTRANS = sqlconn.BeginTransaction("1")
            da1.UpdateCommand.Transaction = BTRANS
            da1.InsertCommand.Transaction = BTRANS
            da1.DeleteCommand.Transaction = BTRANS

            Dim rowb1 As DataRow
            Dim row As DataRow
            For i As Integer = 0 To ds1.Tables("tampil").Rows.Count - 1

                rowb1 = ds1.Tables("krg").NewRow
                rowb1("last_create_date") = tgl
                rowb1("last_created_by") = username
                rowb1("program_name") = Me.Name
                rowb1("kd_cabang") = kdcabang
                rowb1("kd_departemen") = kddep
                rowb1("kd_kegiatan") = gvMain.GetRowCellValue(i, "Kode_bagian").ToString
                rowb1("tanggal_absen") = gvMain.GetRowCellValue(i, "tanggal_absen").ToString
                rowb1("tanggal") = gvMain.GetRowCellValue(i, "tanggal").ToString
                rowb1("kd_pegawai") = gvMain.GetRowCellValue(i, "kd_pegawai").ToString
                ds1.Tables("krg").Rows.Add(rowb1)


            Next

            Try

                da1.Update(ds1.Tables("krg"))

                ds1.Tables("krg").AcceptChanges()

                BTRANS.Commit()


                showMessages("Data Berhasil Disimpan")
                state = "ADD"
                reload()
            Catch e As Exception
                BTRANS.Rollback()
                ds1.Tables("krg").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")

            End Try

        End If
    End Sub

    Public Sub cancel_click()
        
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = False
        btnadd = True
        setStatus()
        Me.Enabled = False
    End Sub
    Private Sub gvMain_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvMain.ValidateRow
        Dim isinvalid As Boolean = True

        If Not ds1.Tables("cek") Is Nothing Then ds1.Tables("cek").Clear()
        da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_insentif_centi_krg where kd_pegawai='" & e.Row("kd_pegawai") & "'" & _
                                                " and kd_kegiatan= '" & e.Row("Kode_bagian") & "' and REPLACE(CONVERT(varchar(10),tanggal_absen,102),'.','') = '" & Format(e.Row("tanggal_absen"), "yyyyMMdd") & "' ", sqlconn))
        da4.Fill(ds1, "cek")
        If ds1.Tables("cek").Rows.Count > 0 Then
            isinvalid = False
            Dim x As Object
            x = CType(gc.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
            x.SetColumnError(kd_pegawai, "Data tidak boleh kembar")
            MsgBox("Data tidak boleh kembar")

        End If
        e.Valid = isinvalid
       

    End Sub


End Class