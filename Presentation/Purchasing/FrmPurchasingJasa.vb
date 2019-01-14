Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient
Public Class FrmPurchasingJasa
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain   '<-- untuk mengakses frmMain
    Public obj As Object
    Public nopr As String = "xxxx"
    Dim dS, dsedit, ds1, ds2, ds3, ds4 As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row, rytt As DataRow
    Dim DA, daedit, da2, da3, da4, da9 As SqlClient.SqlDataAdapter
    Dim Buildernya As New SqlClient.SqlCommandBuilder
    Public no_pr As String = "XXX"
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With

    End Sub
    Private Function NomorPR(ByVal bgtrans As SqlTransaction) As String

        Dim hasil, temp As String
        Dim sqldr As SqlDataReader = New SqlCommand("select max(substring(IsNULL(no_pr,'0001'),1,4))+1 from PURC.DBO.PURC_PR_D", sqlconn, bgtrans).ExecuteReader
        sqldr.Read()
        temp = ""
        If TypeOf sqldr.Item(0) Is DBNull Then
            Dim bln1 As String = Format(Now, "MM")
            Dim th1 As String = Format(Now, "yyyy")
            hasil = "0001" & "/" & "PR" & "/" & th1 & bln1
        Else
            hasil = sqldr.Item(0)
            For i As Int16 = Len(hasil) To 3
                temp = "0" & temp
            Next
            Dim th, bln As String
            bln = Format(Now, "MM")
            th = Format(Now, "yyyy")
            hasil = temp & (hasil) & "/" & "PR" & "/" & th & bln
        End If
        sqldr.Close()
        Return hasil
    End Function
    Public Sub add_click()
        STATE = "ADD"
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()

    End Sub
    Public Sub cancel_click()
        'reload_table("XXX")
        awal()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
    End Sub
    Private Sub reload_table(ByVal kode As String)
        If Not ds4.Tables("PRDM") Is Nothing Then ds4.Tables("PRDM").Clear()
        If Not ds4.Tables("PRD") Is Nothing Then ds4.Tables("PRD").Clear()
        da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as jns_dpm,'' as nama_barang, '' as Tgl_Diperlukan from PURC.DBO.PURC_PR_D where no_pr='" & kode & "'", sqlconn))
        da4.Fill(ds4, "PRD")
        Dim dr As SqlDataReader
        For Each rows As DataRow In ds4.Tables("PRD").Rows
            'dr = New SqlCommand(" select PRD.no_pr, PRD.no_dpm, PRD.kd_stok, PRV.qty,PRV.qty_sisa " & _
            '                    "from PURC.dbo.purcv_dpmbarang PRV " & _
            '                    "left join PURC.dbo.PURC_PR_D PRD " & _
            '                    "on PRV.no_dpm=PRD.no_dpm AND PRV.kd_stok=PRV.kd_stok " & _
            '                    "where PRD.no_pr='" & kode & "' and PRV.kd_stok='" & rows.Item("kd_stok") & "'", sqlconn).ExecuteReader
            'dr.Read()
            'rows.Item("qty_order") = dr.Item("qty_sisa") + rows.Item("qty_pr")
            'rows.Item("qty_sisa") = dr.Item("qty_sisa")
            'dr.Close()
        Next

        GcPRJ.DataSource = ds4.Tables("PRD")

        da9 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_PR_D_BARANG where no_pr = '" & kode & "'", sqlconn))
        da9.Fill(ds4, "PRDM")
        For Each rows As DataRow In ds4.Tables("PRDM").Rows
            dr = New SqlCommand(" select PRD.no_pr, PRD.no_dpm, PRD.kd_stok, PRV.qty,PRV.qty_sisa " & _
                                "from PURC.dbo.purcv_dpmjasa PRV " & _
                                "left join PURC.dbo.PURC_PR_D PRD " & _
                                "on PRV.no_dpm=PRD.no_dpm AND PRV.kd_stok=PRV.kd_stok " & _
                                "where PRD.no_pr='" & kode & "' and PRV.kd_stok='" & rows.Item("kd_stok") & "'", sqlconn).ExecuteReader
            dr.Read()
            rows.Item("qty") = dr.Item("qty_sisa") + rows.Item("qty_pr")
            rows.Item("qty_sisa") = dr.Item("qty_sisa")
            dr.Close()
        Next
        
    End Sub
   
    'Private Sub NO(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
    '    Dim i As Int16 = 1
    '    For Each rw As DataRow In sender.Rows
    '        rw("No_Seq") = i
    '        i += 1
    '    Next

    'End Sub
    'Private Sub refreshNomer(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
    '    Dim i As Int16 = 1
    '    Dim j As Int16 = 1
    '    If State = "DELETE" Then Exit Sub
    '    For Each rw As DataRow In sender.Rows
    '        If rw.RowState <> DataRowState.Deleted Then
    '            For Each rwd As DataRow In ds4.Tables("PDD").Select("NO=" & rw.Item("No_seq"))

    '                rwd("NO") = i
    '                rwd("No_seq") = i & "." & j
    '                j += 1
    '            Next
    '            j = 1
    '            rw("No_seq") = i
    '            i += 1
    '        End If
    '    Next
    'End Sub
    Sub awal()
        connect()
        dttglpr.DateTime = Date.Today

        If Not ds4.Tables("PRD") Is Nothing Then
            ds4.Clear()
        End If

        If Not ds2.Tables("_lookup") Is Nothing Then
            ds4.Clear()
        End If

        


        
        da2 = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        da2.Fill(ds2, "_lookup")
        lookupbrg.DataSource = ds2.Tables("_lookup")
        lookupbrg.ValueMember = "Kode_Barang"
        lookupbrg.DisplayMember = "Nama_Barang"

        da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as nama_barang, '' as jns_dpm, '' as Tgl_Diperlukan from PURC.DBO.PURC_PR_D where no_pr = '" & nopr & "'", sqlconn))
        da4.Fill(ds4, "PRD")
        GcPRJ.DataSource = ds4.Tables("PRD")

        Dim dr As SqlDataReader = New SqlCommand("select *  from PURC.DBO.PURC_DPM_D where no_dpm in (select distinct DPMJ.no_dpm from PURC.dbo.purcv_dpmjasa DPMJ where DPMJ.qty_sisa > 0)", sqlconn).ExecuteReader

        While dr.Read
            Dim rw As DataRow = ds4.Tables("PRD").NewRow
            rw.Item("no_dpm") = dr.Item("no_dpm")
            rw.Item("kd_stok") = dr.Item("kd_stok")
            rw.Item("satuan") = dr.Item("satuan")
            rw.Item("qty_order") = dr.Item("qty")
            rw.Item("jns_dpm") = dr.Item("tipe_trans")
            'rw.Item("Tgl_Diperlukan") = FormatDateTime(dr.Item("Tgl_Diperlukan"), DateFormat.ShortDate)
            rw.Item("Tgl_Diperlukan") = dr.Item("Tgl_Diperlukan")
            ds4.Tables("PRD").Rows.Add(rw)
        End While
        
        dr.Close()
        da9 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_PR_D_BARANG where no_pr = '" & nopr & "'", sqlconn))
        da9.Fill(ds4, "PRDM")
        dr = New SqlCommand("select * from PURC.dbo.purcv_dpmjasa where qty_sisa>0", sqlconn).ExecuteReader
        While dr.Read
            Dim rw As DataRow = ds4.Tables("PRDM").NewRow
            rw.Item("no_dpm") = dr.Item("no_dpm")
            rw.Item("kd_stok") = dr.Item("kd_stok")
            rw.Item("spek_brg") = dr.Item("spek_brg")
            rw.Item("kd_satuan") = dr.Item("kd_satuan")
            rw.Item("kd_jasa") = dr.Item("kd_jasa")
            rw.Item("qty") = dr.Item("qty_sisa")
            rw.Item("qty_pr") = 0
            rw.Item("qty_sisa") = dr.Item("qty_sisa")
            '    rw.Item("qty_pr") = 0
            '    rw.Item("Tgl_Diperlukan") = FormatDateTime(dr.Item("Tgl_Diperlukan"), DateFormat.ShortDate)
            ds4.Tables("PRDM").Rows.Add(rw)
        End While

        dr.Close()

        'reload_table(no_pr)
    End Sub
    Private Sub FrmPurchasing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)

        da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as nama_barang, '' as jns_dpm, '' as Tgl_Diperlukan from PURC.DBO.PURC_PR_D where 1=0", sqlconn))
        da4.Fill(ds4, "PRD")
        da9 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_PR_D_BARANG where 1=0", sqlconn))
        da9.Fill(ds4, "PRDM")
        'dr = New SqlClient.SqlCommand("select * from PURC.dbo.PURC_DPM_D_BARANG", sqlconn).ExecuteReader
        'dr.Read()
        'GC.FocusedView.GetRow(e.RowHandle).Item("satuan") = dr.Item("Nama_Satuan")
        'dr.Close()
        Dim colM(1) As DataColumn
        Dim colD(1) As DataColumn
        Dim rel As DataRelation


        colM(0) = ds4.Tables("PRD").Columns("no_dpm")
        colM(1) = ds4.Tables("PRD").Columns("kd_stok")
        'colM(2) = ds4.Tables("PRD").Columns("no_pr")


        colD(0) = ds4.Tables("PRDM").Columns("no_dpm")
        colD(1) = ds4.Tables("PRDM").Columns("kd_jasa")
        'colD(2) = ds4.Tables("PRDM").Columns("no_pr")

        rel = ds4.Relations.Add("Detail", colM, colD, False)
        GcPRJ.LevelTree.Nodes.Add("Detail", GVDetail)
        GcPRJ.DataSource = ds4.Tables("PRD")
        awal()
    End Sub


    Private Sub GV_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)
        ' GV.GetRow(e.RowHandle).item("no_seq") = GV.RowCount + 1
    End Sub

    Private Sub GV_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs)
        'Dim isValid As Boolean = True
        'If e.Row.item("Kd_Stok").ToString = "" Then
        '    isValid = False
        '    GV.SetColumnError(Kd_Stok, "Harap Memilih Barang Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        'End If
        'If e.Row.item("qty_pr").ToString = "" Then
        '    isValid = False
        '    GV.SetColumnError(qty_pr, "Harap Mengisi Jumlah Kuantitas.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        'ElseIf e.Row.item("qty_pr") > e.Row.item("qty_order") Then
        '    isValid = False
        '    GV.SetColumnError(qty_pr, "QTY PR tidak boleh melebihi QTY ORDER !", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)

        'ElseIf dS.Tables("PRD").Select("Kd_Stok = '" & e.Row.item("Kd_Stok") & "'").Count > 1 Then
        '    isValid = False
        '    GV.SetColumnError(Kd_Stok, "Kode Barang Sudah Ada dalam Daftar", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        'End If
        'e.Valid = isValid
    End Sub
    'Public Sub simpan()
    '    For Each rows As DataRow In ds4.Tables("PRD").Rows
    '        Dim builder As New SqlCommandBuilder(DA)
    '        If row.RowState = DataRowState.Modified Then
    '            row.Item("Last_Update_Date") = Now

    '            row.Item("Last_Updated_By") = username

    '        End If
    '    Next
    '    DA.InsertCommand = builder.GetInsertCommand()
    '    DA.UpdateCommand = builder.GetUpdateCommand()
    '    DA.DeleteCommand = builder.GetDeleteCommand()
    '    DA.Update(dSO, "_DpmApprv")
    '    dSO.Tables("_DpmApprv").AcceptChanges()
    'End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)


        Dim BTRANS As SqlTransaction
        Buildernya = New SqlClient.SqlCommandBuilder(da4)
        da4.UpdateCommand = Buildernya.GetUpdateCommand()
        da4.InsertCommand = Buildernya.GetInsertCommand()
        da4.DeleteCommand = Buildernya.GetDeleteCommand()

        Buildernya = New SqlClient.SqlCommandBuilder(da9)
        da9.UpdateCommand = Buildernya.GetUpdateCommand()
        da9.InsertCommand = Buildernya.GetInsertCommand()
        da9.DeleteCommand = Buildernya.GetDeleteCommand()

        BTRANS = sqlconn.BeginTransaction("1")

        da4.UpdateCommand.Transaction = BTRANS
        da4.InsertCommand.Transaction = BTRANS
        da4.DeleteCommand.Transaction = BTRANS

        da9.UpdateCommand.Transaction = BTRANS
        da9.InsertCommand.Transaction = BTRANS
        da9.DeleteCommand.Transaction = BTRANS

        If Not isDelete Then
            'For Each rw As DataRow In (ds4.Tables("PRD").Select("qty_pr =0"))
            '    rw.Delete()
            'Next

            If STATE = "ADD" Then
                'txtNomor.Text = NomorPR(BTRANS)
                For Each row In ds4.Tables("PRD").Rows
                    row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
                    'row.Item("No_PR") = txtNomor.Text
                    row.Item("Tgl_pr") = dttglpr.EditValue
                    row.Item("Program_Name") = Me.Name
                    row.Item("qty_pr") = row.Item("qty_order")
                    row.Item("Last_Create_Date") = Now
                    row.Item("Last_Created_By") = username
                    row.Item("rec_stat") = "ENTRY"
                    'Dim dr As Integer = New SqlCommand("update PURC.DBO.PURC_DPM_D set Qty_sisa= '" & row.Item("qty_sisa") & "' where Kd_Stok='" & row.Item("Kd_Stok") & "' and  no_dpm='" & row.Item("No_DPM") & "'", sqlconn, BTRANS).ExecuteNonQuery
                    'Dim dr As Integer = New SqlCommand("update PURC.DBO.PURC_DPM_D set Qty_sisa= " & IIf(row.Item("qty_sisa").ToString = "", 0, row.Item("qty_sisa")) & " where Kd_Stok='" & row.Item("No_DPM") & "' and  no_dpm='" & row.Item("No_DPM") & "'", sqlconn, BTRANS).ExecuteNonQuery
                Next
            Else
                For Each row In ds4.Tables("PRD").Rows
                    row.Item("qty_pr") = row.Item("qty_order")
                    row.Item("Last_Update_Date") = Now
                    row.Item("Last_Updated_By") = username
                Next
            End If
            For Each rw As DataRow In (ds4.Tables("PRDM").Select("qty_pr =0"))
                rw.Delete()
            Next
            Dim mrow As DataRow
            For i = ds4.Tables("PRD").Rows.Count - 1 To 0 Step -1
                mrow = ds4.Tables("PRD").Rows(i)
                If mrow.GetChildRows("Detail").Count() = 0 Then
                    mrow.Delete()
                End If

            Next
        End If
        If STATE = "ADD" Then
            Dim notrans As String = getNoTrans("PR-J", getTanggal(BTRANS), BTRANS)
            txtNomor.Text = notrans
            For Each rows As DataRow In ds4.Tables("PRD").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("No_PR") = notrans
                End If
            Next
            For Each rows As DataRow In ds4.Tables("PRDM").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("no_pr") = notrans
                End If
            Next
        End If

        Try

            da4.Update(ds4.Tables("PRD"))
            ds4.Tables("PRD").AcceptChanges()

            da9.Update(ds4.Tables("PRDM"))
            ds4.Tables("PRDM").AcceptChanges()

            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan..")
        Catch e As Exception
            BTRANS.Rollback()
            ds4.Tables("PRD").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            ds4.Tables("PRDM").RejectChanges()
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
        btn_supp.Enabled = True

    End Sub
    Public Sub edit_click()
        If Not dsedit.Tables("lookup_PR") Is Nothing Then dsedit.Tables("lookup_PR").Clear()
        daedit = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct No_PR as [Nomor], tgl_PR as [Tanggal] from PURC.DBO.PURC_PR_D where jns_dpm='JASA' and rec_stat='ENTRY' or rec_stat='REJECT' ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dsedit.Tables("lookup_PR") Is Nothing Then dsedit.Tables("lookup_PR").Clear()
        daedit.Fill(dsedit, "lookup_PR")
        frmCari.set_dso(dsedit.Tables("lookup_PR")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            STATE = "EDIT"
            reload_table(frmCari.row(0))
            txtNomor.Text = frmCari.row(0)
            btnSave = True
            btnadd = False
            btnEdit = False
            btnDelete = True
            btnCancel = True
            setStatus()
            Me.Enabled = True
        Else
            cancel_click()
            STATE = ""
        End If
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data PURCHASING REQUEST JASA ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            STATE = "DELETE"
            If Not ds4.Tables("PRD") Is Nothing Then delete(ds4.Tables("PRD").Rows)

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
    Private Sub btSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSimpan.Click
        save_click()
    End Sub
    Private Sub centerMe(ByVal pnl As Object)
        pnl.visible = False
        pnl.left = (pnl.parent.width - pnl.width) / 2
        If pnl.Left < 0 Then pnl.left = 0
        pnl.top = 5 ' (pnl.parent.height - pnl.height) / 2
        pnl.visible = True
    End Sub
    Private Sub centerMe()
        If frmMain.pnlDisplay2.Controls.Count = 1 Then
            If TypeOf frmMain.pnlDisplay2.Controls(0) Is Form Then
                frmMain.pnlDisplay2.VerticalScroll.Visible = False
                frmMain.pnlDisplay2.HorizontalScroll.Visible = False
                If frmMain.pnlDisplay2.Controls(0).Controls("pnl").Width < frmMain.pnlDisplay2.Width Then
                    frmMain.pnlDisplay2.Controls(0).Width = frmMain.pnlDisplay2.Width
                    frmMain.pnlDisplay2.HorizontalScroll.Visible = False
                Else
                    frmMain.pnlDisplay2.Controls(0).Width = frmMain.pnlDisplay2.Controls(0).Controls("pnl").Width
                    frmMain.pnlDisplay2.HorizontalScroll.Visible = True
                End If
                If frmMain.pnlDisplay2.Controls(0).Controls("pnl").Height < frmMain.pnlDisplay2.Height Then
                    frmMain.pnlDisplay2.Controls(0).Height = frmMain.pnlDisplay2.Height
                    frmMain.pnlDisplay2.VerticalScroll.Visible = False
                Else
                    frmMain.pnlDisplay2.Controls(0).Height = frmMain.pnlDisplay2.Controls(0).Controls("pnl").Height
                    frmMain.pnlDisplay2.VerticalScroll.Visible = True
                End If
                centerMe(frmMain.pnlDisplay2.Controls(0).Controls("pnl"))
            End If
        End If
    End Sub
    Sub btnsupp()
        frmMain.pnlDisplay2.Controls.Clear()
        Dim obj As Form
        obj = FrmPilihSupplier
        add_pnl(obj)
        set_pos_frm(obj)
        obj.BackgroundImage = frmMain.pnlDisplay2.BackgroundImage
        obj.BackgroundImageLayout = ImageLayout.Center
        obj.BackColor = Color.White
        frmMain.pnlDisplay2.Controls.Add(obj)
        'coll_form.Add(obj, obj.Name.ToString)
        'obj.Text = sender.caption
        obj.Enabled = True
        centerMe()
        obj.Show()
    End Sub

    Private Sub btn_supp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_supp.Click
        FrmPilihSupplier.LEPR.EditValue = txtNomor.Text
        FrmPilihSupplier.LEPR.Enabled = False
        'FrmPilihSupplier.SimpleButton1.Visible = True
        'FrmPilihSupplier.btSimpan.Visible = True
        FrmPilihSupplier.STATE = "ADD"
        'FrmPilihSupplier.ShowDialog()
        btnsupp()
    End Sub

    Private Sub GVDetail_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GVDetail.CellValueChanged


        If e.Column.Name = "dqty_pr" Then
            Dim x As Object
            x = CType(GcPRJ.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
            Dim qorder As Decimal = x.GetRowCellValue(e.RowHandle, "qty")
            Dim qpr As Decimal = x.GetRowCellValue(e.RowHandle, "qty_pr")
            
            If qpr > qorder Then
                MsgBox("Jumlah PR lebih besar dari Jumlah order DPM", MsgBoxStyle.Critical, "Konfirmasi")
                'x.GetRowCellValue(e.RowHandle, "qty_pr") = 0
                x.GetRow(e.RowHandle).item("qty_pr") = 0
                x.GetRow(e.RowHandle).item("qty_sisa") = qorder

            Else
                'GVDetail.GetRow(e.RowHandle).item("qty_sisa") = qorder - qpr
                'x.SetRowCellValue(e.RowHandle, "qty_pr", qorder - qpr)
                x.GetRow(e.RowHandle).item("qty_sisa") = qorder - qpr
            End If

        End If
    End Sub
End Class