
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient
Public Class frmParamSupp
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain   '<-- untuk mengakses frmMain
    Public obj As Object
    Dim dS, ds1, ds2, ds3, ds4, dsku, dsku1, dsku2, dsedit As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Dim DA, da2, da3, da4, sqlda, daedit, sqlda1, sqlda2 As SqlClient.SqlDataAdapter
    Dim Buildernya As New SqlClient.SqlCommandBuilder

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With

    End Sub
    Private Sub bersih()
        txtNo.EditValue = vbNullString

       
        'LookUpEditDep.EditValue = vbNullString
    End Sub

    Private Sub reload_table(ByVal kode As String)
        If Not ds3.Tables("EVSUP") Is Nothing Then ds3.Tables("EVSUP").Clear()
        If Not ds4.Tables("EVSUPD") Is Nothing Then ds4.Tables("EVSUPD").Clear()

        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_eval_supplier where kode='" & kode & "'", sqlconn))
        da3.Fill(ds3, "EVSUP")

        da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_eval_supplier_d where kode='" & kode & "' order by No_Seq asc", sqlconn))
        da4.Fill(ds4, "EVSUPD")
        'GC.DataSource = ds4.Tables("EVSUPD")

        If ds3.Tables("EVSUP").Rows.Count > 0 Then
            Dim row As DataRow

            row = ds3.Tables("EVSUP").Rows(0)
            txtNo.Text = row.Item("kode").ToString
            dttglmulai.Text = row.Item("start_date")
            dttglakhir.Text = row.Item("end_date")


        End If

    End Sub
    Public Sub edit_click()
        daedit = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kode as [Nomor], start_date [Start Date], end_date [End Date] from SIF.dbo.SIF_eval_supplier ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dsedit.Tables("lookup_DPM") Is Nothing Then dsedit.Tables("lookup_DPM").Clear()
        daedit.Fill(dsedit, "lookup_DPM")
        frmCari.set_dso(dsedit.Tables("lookup_DPM")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            reload_table(frmCari.row(0))
            STATE = "EDIT"
            btnSave = True
            btnadd = False
            btnEdit = False
            btnCancel = True
            btnDelete = True
            setStatus()
            Me.Enabled = True
        Else
            cancel_click()
            STATE = ""
        End If
    End Sub
    Public Sub cetak_click()
        'callReport(App_Path() & "\report\rptDPM_M.rpt", "", "Nomor=0014/DPM/201106")
        callReport(App_Path() & "\report\rptDPM_J.rpt", "", "Nomor=" & Trim(txtNo.Text))
    End Sub
    Public Sub add_click()
        STATE = "ADD"
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()

    End Sub
 
    Private Sub No_Seq(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        For Each rw As DataRow In sender.Rows
            rw("No_Seq") = i
            i += 1
        Next

    End Sub
    Public Function getNextNumberDPM(ByVal bgtrans As SqlTransaction) As String
        Dim hasil, temp As String
        Dim sqldr As SqlDataReader = New SqlCommand("select max(substring(IsNULL(No_DPM,'0001'),1,4))+1 from PURC.dbo.PURC_DPM", sqlconn, bgtrans).ExecuteReader
        sqldr.Read()
        temp = ""
        If TypeOf sqldr.Item(0) Is DBNull Then
            Dim bln1 As String = Format(Now, "MM")
            Dim th1 As String = Format(Now, "yyyy")
            hasil = "0001" & "/" & "DPM" & "/" & th1 & bln1
        Else
            hasil = sqldr.Item(0)
            For i As Int16 = Len(hasil) To 3
                temp = "0" & temp
            Next
            Dim th, bln As String
            bln = Format(Now, "MM")
            th = Format(Now, "yyyy")
            hasil = temp & (hasil) & "/" & "DPM" & "/" & th & bln
        End If
        sqldr.Close()
        Return hasil
    End Function
    Public Sub cancel_click()
        reload_table("XXX")
        bersih()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction
        Buildernya = New SqlClient.SqlCommandBuilder(da3)
        da3.UpdateCommand = Buildernya.GetUpdateCommand()
        da3.InsertCommand = Buildernya.GetInsertCommand()
        da3.DeleteCommand = Buildernya.GetDeleteCommand()

        Buildernya = New SqlClient.SqlCommandBuilder(da4)
        da4.UpdateCommand = Buildernya.GetUpdateCommand()
        da4.InsertCommand = Buildernya.GetInsertCommand()
        da4.DeleteCommand = Buildernya.GetDeleteCommand()

        BTRANS = sqlconn.BeginTransaction("1")
        da3.UpdateCommand.Transaction = BTRANS
        da3.InsertCommand.Transaction = BTRANS
        da3.DeleteCommand.Transaction = BTRANS
        da4.UpdateCommand.Transaction = BTRANS
        da4.InsertCommand.Transaction = BTRANS
        da4.DeleteCommand.Transaction = BTRANS
        If Not isDelete Then
            If STATE = "ADD" Then

                row = ds3.Tables("EVSUP").NewRow
                row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
             
                row.Item("start_date") = dttglmulai.EditValue
                row.Item("end_date") = dttglakhir.EditValue
                row.Item("Program_Name") = Me.Name
                row.Item("Last_Create_Date") = Now
                row.Item("Last_Created_By") = username
            ElseIf STATE = "EDIT" Then
                row = ds3.Tables("EVSUP").Rows(0)
                row.Item("Last_Update_Date") = Now
                row.Item("Last_Updated_By") = username
            End If


            If STATE = "ADD" Then
                ds3.Tables("EVSUP").Rows.Add(row)
            End If

            For Each rows As DataRow In ds4.Tables("EVSUPD").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("kode") = row.Item("kode")
                    rows.Item("Last_Create_Date") = Now
                    rows.Item("Last_Created_By") = username
                    rows.Item("kd_Cabang") = kdcabang
                    rows.Item("Program_name") = Me.Name
                ElseIf Not rows.RowState = DataRowState.Deleted Then
                    rows.Item("Last_Update_Date") = Now
                    rows.Item("Last_Updated_By") = username
                End If


            Next
        End If



        Try
            
            If STATE = "ADD" Then
                row.Item("kode") = getNoTrans("P-SUP", getTanggal(BTRANS), BTRANS)
                txtNo.Text = row.Item("kode")
                For Each rows As DataRow In ds4.Tables("EVSUPD").Rows
                    If rows.RowState = DataRowState.Added Then
                        rows.Item("kode") = row.Item("kode")
                    End If
                Next
            End If



            da3.Update(ds3.Tables("EVSUP"))
            da4.Update(ds4.Tables("EVSUPD"))

            ds3.Tables("EVSUP").AcceptChanges()
            ds4.Tables("EVSUPD").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan..")
        Catch e As Exception
            BTRANS.Rollback()
            ds3.Tables("EVSUP").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.GetRow(e.RowHandle).item("No_Seq") = GV.RowCount + 1

    End Sub

   
    Private Sub GC_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GC.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Record Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus dari Daftar ") = MsgBoxResult.Yes Then
                    GV.DeleteSelectedRows()
                End If
            End If
        End If
    End Sub
    Private Sub refreshNomer(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        Dim j As Int16 = 1
        If STATE = "DELETE" Then Exit Sub
        For Each rw As DataRow In sender.Rows
            If rw.RowState <> DataRowState.Deleted Then
                For Each rwd As DataRow In ds4.Tables("EVSUPD").Select("No_Seq=" & rw.Item("No_Seq"))

                    rwd("No_Seq") = i
                    j = 1
                    rw("No_Seq") = i
                    '  i += 1
                Next
                j = 1
                rw("No_Seq") = i
                i += 1
            End If
        Next
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data  ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            STATE = "DELETE"
            If Not ds3.Tables("EVSUP") Is Nothing Then delete(ds3.Tables("EVSUP").Rows)
            If Not ds4.Tables("EVSUPD") Is Nothing Then delete(ds4.Tables("EVSUPD").Rows)

            'ds3.Tables("EVSUPD").Rows(0).Delete()

            save_click(True)
            cancel_click()
            STATE = ""
        End If
    End Sub
    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub
 
    Private Sub GV_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        Dim isValid As Boolean = True
        If e.Row.item("kriteria").ToString = "" Then
            isValid = False
            GV.SetColumnError(kriteria, "Harap Mengisi Kriteria.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If

        If e.Row.item("ket").ToString = "" Then
            isValid = False
            GV.SetColumnError(ket, "Harap Mengisi keterangan.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("nilai").ToString = "" Then
            isValid = False
            GV.SetColumnError(nilai, "Harap Mengisi Nilai.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("bobot_max").ToString = "" Then
            isValid = False
            GV.SetColumnError(bobotmax, "Harap Mengisi Bobot MAX.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("bobot_min").ToString = "" Then
            isValid = False
            GV.SetColumnError(bobotmin, "Harap Mengisi Bobot MIN.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        e.Valid = isValid
    End Sub

    Public Sub caridpmku(ByVal nodpmku As String) ' ============= cretaed by yaya =============
        'sqlda = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_DPM where kode='" & nodpmku & "'", sqlconn))
        'sqlda.Fill(dsku, "_yaya")

        If dsku.Tables(0).Rows.Count Then
            txtNo.Text = dsku.Tables(0).Rows(0).Item("kode").ToString
          
        End If
        sqlda1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_eval_supplier_d where kode='" & txtNo.Text & "'", sqlconn))
        sqlda1.Fill(dsku1, "_yaya_d")
        GC.DataSource = dsku1.Tables("_yaya_d")
        'MsgBox(dsku1.Tables("_yaya_d").Rows.Count)
    End Sub

    Private Sub frmParamSupp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()

        dttglmulai.Text = Date.Today
        dttglakhir.Text = Date.Today
        'from sif.dbo.SIF_Barang
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_eval_supplier where 1=0", sqlconn))
        da3.Fill(ds3, "EVSUP")

        da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from SIF.dbo.SIF_eval_supplier_d where 1=0", sqlconn))
        da4.Fill(ds4, "EVSUPD")
        GC.DataSource = ds4.Tables("EVSUPD")
        AddHandler ds4.Tables("EVSUPD").RowDeleted, AddressOf refreshNomer
        prn = getParent(Me)
    End Sub
End Class