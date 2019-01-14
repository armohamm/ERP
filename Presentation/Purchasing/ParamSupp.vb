
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
        txtNoDPM.EditValue = vbNullString
        txtRef.EditValue = vbNullString
        txtKeterangan.Text = ""
        txtRef.EditValue = vbNullString
        txtStatus.EditValue = vbNullString
        'LookUpEditDep.EditValue = vbNullString
    End Sub

    Private Sub reload_table(ByVal kode As String)
        If Not ds3.Tables("PD") Is Nothing Then ds3.Tables("PD").Clear()
        If Not ds4.Tables("PDD") Is Nothing Then ds4.Tables("PDD").Clear()

        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_DPM where No_DPM='" & kode & "'", sqlconn))
        da3.Fill(ds3, "PD")

        da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_DPM_D where No_DPM='" & kode & "' order by No_Seq asc", sqlconn))
        da4.Fill(ds4, "PDD")
        'GC.DataSource = ds4.Tables("PDD")

        If ds3.Tables("PD").Rows.Count > 0 Then
            Dim row As DataRow

            row = ds3.Tables("PD").Rows(0)
            txtNoDPM.Text = row.Item("No_DPM").ToString
            ' LookUpEditDep..Text = row.Item("Tgl_sp").ToString
            LookUpEditDep.EditValue = row.Item("Departemen").ToString
            txtKeterangan.Text = row.Item("Keterangan").ToString
            dtTanggal.Text = row.Item("Tgl_DPM")
            txtRef.EditValue = row.Item("No_Ref")
            txtStatus.EditValue = row.Item("rec_stat").ToString
            txtKetApprove.Text = row.Item("Ket_Approve").ToString

        End If

    End Sub
    Public Sub edit_click()
        daedit = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_DPM as [Nomor], tgl_DPM as [Tanggal] from PURC.dbo.PURC_DPM where tipe_trans='MATERIAL' and rec_stat='ENTRY' or rec_stat='REJECT'", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
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
        callReport(App_Path() & "\report\rptDPM_J.rpt", "", "Nomor=" & Trim(txtNoDPM.Text))
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
    'Sub View_Barang()
    '    da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Barang", sqlconn))
    '    da2.Fill(ds2, "View_Barang")
    '    repBarang.DataSource = ds2.Tables("View_Barang")
    'End Sub
    Sub View_Departemen()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kd_Departemen,Nama_Departemen from sif.dbo.SIF_Departemen", sqlconn))
        DA.Fill(ds1, "View_D")
        LookUpEditDep.Properties.DataSource = ds1.Tables("View_D")
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
    Private Sub frmDPMJasa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()

        dtTanggal.Text = Date.Today
        View_Departemen()
        da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Barang", sqlconn))
        da2.Fill(dS, "VBarang")
        repBarang.DataSource = dS.Tables("VBARANG")
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_DPM where 1=0", sqlconn))
        da3.Fill(ds3, "PD")

        da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * ,'' As No from PURC.dbo.PURC_DPM_D where 1=0", sqlconn))
        da4.Fill(ds4, "PDD")
        GC.DataSource = ds4.Tables("PDD")
        AddHandler ds4.Tables("PDD").RowDeleted, AddressOf refreshNomer
        prn = getParent(Me)
        'If txtNoDPM.Text = "" Then
        'reload_table("xxx")
        'GC.DataSource = ds4.Tables("PDD")
        'End If
        LookUpEditDep.EditValue = kddep
    End Sub
    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction

        If Not isDelete Then
            If STATE = "ADD" Then

                row = ds3.Tables("PD").NewRow
                row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
                row.Item("tipe_trans") = "MATERIAL"
                'row.Item("No_DPM") = getNextNumberDPM(BTRANS)
                'txtNoDPM.Text = row.Item("No_DPM")
                row.Item("Tgl_DPM") = dtTanggal.EditValue
                row.Item("No_Ref") = txtRef.Text
                row.Item("Departemen") = LookUpEditDep.EditValue
                row.Item("Keterangan") = txtKeterangan.Text
                row.Item("rec_stat") = "ENTRY" 'IIf(cbStatus.Text = "AKTIF", "Y", "T")
                txtStatus.Text = row.Item("rec_stat")
                row.Item("Program_Name") = Me.Name
                row.Item("Last_Create_Date") = Now
                row.Item("Last_Created_By") = username
            ElseIf STATE = "EDIT" Then
                row = ds3.Tables("PD").Rows(0)
                row.Item("Last_Update_Date") = Now
                row.Item("Last_Updated_By") = username
            End If


            If STATE = "ADD" Then
                ds3.Tables("PD").Rows.Add(row)
            End If

            For Each rows As DataRow In ds4.Tables("PDD").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("No_DPM") = row.Item("No_DPM")
                    rows.Item("tipe_trans") = "MATERIAL"
                    rows.Item("Last_Create_Date") = Now
                    rows.Item("Last_Created_By") = username
                    rows.Item("kd_Cabang") = kdcabang
                    rows.Item("rec_stat") = "ENTRY"
                    rows.Item("Program_name") = Me.Name
                ElseIf Not rows.RowState = DataRowState.Deleted Then
                    rows.Item("Last_Update_Date") = Now
                    rows.Item("Last_Updated_By") = username
                End If


            Next
        End If



        Try
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
            If STATE = "ADD" Then
                row.Item("No_DPM") = getNoTrans("DPM-M", getTanggal(BTRANS), BTRANS)
                txtNoDPM.Text = row.Item("No_DPM")
                For Each rows As DataRow In ds4.Tables("PDD").Rows
                    If rows.RowState = DataRowState.Added Then
                        rows.Item("No_DPM") = row.Item("No_DPM")
                    End If
                Next
            End If



            da3.Update(ds3.Tables("PD"))
            da4.Update(ds4.Tables("PDD"))

            ds3.Tables("PD").AcceptChanges()
            ds4.Tables("PDD").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan..")
        Catch e As Exception
            BTRANS.Rollback()
            ds3.Tables("PD").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.GetRow(e.RowHandle).item("No_Seq") = GV.RowCount + 1
        GV.GetRow(e.RowHandle).item("Tgl_Diperlukan") = Now
    End Sub

    Private Sub GV_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        If e.Column Is Kd_Stok Then
            Dim rw As DataRow
            rw = dS.Tables("VBARANG").Select("Kode_Barang='" & e.Value & "'")(0)
            GV.GetRow(e.RowHandle).item("Satuan") = rw("Kd_Satuan")
        End If
        'If e.Column Is QTYPR Then
        '    GV.GetRow(e.RowHandle).item("Qty_sisa") = GV.GetRow(e.RowHandle).item("Qty").ToString - GV.GetRow(e.RowHandle).item("Qty_PR").ToString
        'End If
    End Sub

    'Private Sub btSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSimpan.Click
    '    If dtTanggal.Text = "" Then
    '        'showMessages("Tanggal Harap diisi !")
    '        MsgBox("Tanggal Harap diisi !")
    '        dtTanggal.Focus()
    '    End If
    '    save_click()
    'End Sub

    Private Sub GC_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GC.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Record Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar DPM") = MsgBoxResult.Yes Then
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
                For Each rwd As DataRow In ds4.Tables("PDD").Select("No_Seq=" & rw.Item("No_Seq"))

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
        If MsgBox("Hapus Data DPM ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            STATE = "DELETE"
            If Not ds3.Tables("PD") Is Nothing Then delete(ds3.Tables("PD").Rows)
            If Not ds4.Tables("PDD") Is Nothing Then delete(ds4.Tables("PDD").Rows)

            'ds3.Tables("PDD").Rows(0).Delete()

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
    'Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
    '    edit_click()
    'End Sub

    Private Sub GV_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        Dim isValid As Boolean = True
        If e.Row.item("Kd_Stok").ToString = "" Then
            isValid = False
            GV.SetColumnError(Kd_Stok, "Harap Memilih Barang Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("Qty").ToString = "" Or Not IsNumeric(e.Row.item("Qty").ToString) Then
            isValid = False
            GV.SetColumnError(ket, "Harap Mengisi Jumlah Kuantitas.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        ElseIf e.Row.item("Qty") <= 0 Then
            isValid = False
            GV.SetColumnError(ket, "Harap Mengisi Jumlah Kuantitas Dengan Benar.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        e.Valid = isValid
    End Sub

    Public Sub caridpmku(ByVal nodpmku As String) ' ============= cretaed by yaya =============
        sqlda = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_DPM where No_DPM='" & nodpmku & "'", sqlconn))
        sqlda.Fill(dsku, "_yaya")

        If dsku.Tables(0).Rows.Count Then
            txtNoDPM.Text = dsku.Tables(0).Rows(0).Item("No_DPM").ToString
            txtRef.Text = dsku.Tables(0).Rows(0).Item("No_ref").ToString
            txtKeterangan.Text = dsku.Tables(0).Rows(0).Item("Keterangan").ToString
            LookUpEditDep.EditValue = dsku.Tables(0).Rows(0).Item("Departemen").ToString
        End If
        sqlda1 = New SqlDataAdapter(New SqlCommand("select * from PURC.DBO.PURC_DPM_D where No_DPM='" & txtNoDPM.Text & "'", sqlconn))
        sqlda1.Fill(dsku1, "_yaya_d")
        GC.DataSource = dsku1.Tables("_yaya_d")
        'MsgBox(dsku1.Tables("_yaya_d").Rows.Count)
    End Sub
End Class