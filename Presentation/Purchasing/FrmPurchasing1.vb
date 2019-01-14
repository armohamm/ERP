Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraGrid.Views.Grid

Imports DevExpress.XtraGrid
Imports System.Drawing
Public Class FrmPurchasing1
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain   '<-- untuk mengakses frmMain
    Dim subReport As String
    Dim subReport1 As String
    Public obj As Object
    Public nopr As String = "xxx"
    Dim dS, dsedit, ds1, ds2, ds3, ds4 As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Dim DA, daedit, da2, da3, da4 As SqlClient.SqlDataAdapter
    Dim Buildernya As New SqlClient.SqlCommandBuilder
    Public no_pr As String = "XXX"
    Dim TemplatePur As String
    Dim rl As DataRelation
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With

    End Sub
    Sub print_gc1(ByVal xGc As Object, ByVal xreportHeader As String)
        Dim ps As New PrintingSystem()
        Dim link As New PrintableComponentLink(ps)
        Dim ph As DevExpress.XtraPrinting.PageHeaderFooter = CType(link.PageHeaderFooter, PageHeaderFooter)

        ph.Header.Content.Add("" & umum.Perusahaan & vbCrLf & xreportHeader)
        ph.Header.Content.Add("")
        ph.Header.Content.Add(username & vbCrLf & getTanggal.ToShortDateString)






        ph.Header.LineAlignment = BrickAlignment.Near
        ph.Footer.Content.Add("")


        ph.Footer.Content.Add("Lembar : [Page # of Pages #]" & vbCrLf & "Setelah Terima Fax Mohon Ditandatangani, Nama Terang &" & vbCrLf & "Fax Kembali Ke 031-8050874 MAX 1 Hari")
        ph.Footer.Content.Add("" & "SURABAYA" & vbCrLf & vbCrLf & getTanggal.ToShortDateString)

        ph.Footer.LineAlignment = BrickAlignment.Near

        ph.Header.Font = New Font("Tahoma", 8, FontStyle.Bold)




        link.Component = xGc
        link.Margins.Left = 4
        link.Margins.Right = 4
        link.Margins.Bottom = 150
        link.Margins.Top = 90
        link.PaperKind = System.Drawing.Printing.PaperKind.A4
        link.CreateDocument()
        link.ShowPreview()

    End Sub
    Public Sub cetak_click()
        'GV.ExpandMasterRow(0, "Detail")
        'GV.Columns("rec_stat").Visible = False
        'GV.Columns("no_urut").Visible = False
        'GV.Columns("satuan").AppearanceCell.BackColor = Color.White
        'print_gc1(GcPR, "PURCHASING MATERIAL    " & vbCrLf & _
        '                        "                                                                                                    " & "No PR       : " & txtNomor.Text)

        'GV.Columns("satuan").AppearanceCell.BackColor = Color.LightGreen
        '' callReport(App_Path() & "\report\rptPR.rpt", "", "&no_pr=" & Trim(txtNomor.Text) & " &vnama_report=" & TemplatePur, False, False)
        If Not GV.RowCount <= 0 Then
            'ShowGridPreview(GCMonHTGL)
            PrintableComponentLink1.CreateDocument()
            PrintableComponentLink1.ShowPreview()
        Else
            MsgBox("Tidak ada data yang dicetak. Silahkan mengisi filter dan menekan tombol Refresh.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "INFO")
        End If

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
    Public Sub cancel_click()

        'reload_table("XXX")
        awal()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        txtNomor.Text = ""
        setStatus()
        Me.Enabled = False
    End Sub
    Public Sub add_click()
        awal()
        STATE = "ADD"

        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
    End Sub
    'Sub View_NomorPR()
    '    DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_Pr from PURC.DBO.PURC_PR_D", sqlconn))
    '    DA.Fill(ds1, "View_D")
    '    LENomor.Properties.DataSource = ds1.Tables("View_D")
    'End Sub
    Private Sub NO(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        For Each rw As DataRow In sender.Rows
            rw("no_seq") = i
            i += 1
        Next

    End Sub

    Private Sub reload_table(ByVal kode As String)
        If Not ds4.Tables("PRD") Is Nothing Then ds4.Tables("PRD").Clear()
        da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as jns_dpm,'' as nama_barang,'' as Tgl_Diperlukan from PURC.DBO.PURC_PR_D where no_pr='" & kode & "'", sqlconn))
        da4.Fill(ds4, "PRD")
        Dim dr As SqlDataReader
        For Each rows As DataRow In ds4.Tables("PRD").Rows
            'MessageBox.Show(rows.Item("no_pr"))
            dr = New SqlCommand(" select PRD.no_pr, PRD.no_dpm, PRD.kd_stok, PRV.qty,PRV.qty_sisa,DPM.Tgl_Diperlukan " & _
                                "from PURC.dbo.purcv_dpmbarang PRV " & _
                                "left join PURC.dbo.PURC_PR_D PRD " & _
                                "on PRV.no_dpm=PRD.no_dpm AND PRD.kd_stok=PRV.kd_stok and prv.No_Seq = prd.no_seq " & _
                                 "LEFT  JOIN PURC.dbo.PURC_DPM_D DPM ON DPM.No_DPM = PRV.no_dpm " & _
                                "AND DPM.Kd_Stok = PRV.kd_stok " & _
                                "AND DPM.No_Seq = PRV.no_seq " & _
                                "where PRD.no_pr='" & kode & "' and PRV.kd_stok='" & rows.Item("kd_stok") & "' and PRV.No_Seq = '" & rows.Item("no_seq") & "' ", sqlconn).ExecuteReader
            dr.Read()
            rows.Item("qty_order") = dr.Item("qty_sisa") + rows.Item("qty_pr")
            rows.Item("qty_sisa") = dr.Item("qty_sisa")
            rows.Item("Tgl_Diperlukan") = FormatDateTime(dr.Item("Tgl_Diperlukan"), DateFormat.ShortDate)
            dr.Close()
        Next




        'If Not ds4.Tables("PRD") Is Nothing Then ds4.Tables("PRD").Clear()



        'da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as jns_dpm,'' as nama_barang,'' as Tgl_Diperlukan from PURC.DBO.PURC_PR_D where no_pr='" & kode & "'", sqlconn))
        'da4.Fill(ds4, "PRD")


        ''        
        ''Dim dr1 As SqlDataReader = New SqlCommand(" select dpr.no_dpm,dpr.kd_stok,dpr.satuan,dpr.qty_sisa,dp.tp_trans,dpr.qty_sisa,d from PURC.DBO.PURC_DPM_D dp, PURC.DBO.PURC_PR_D dpr  where  rec_stat='APPROVE' and tipe_trans='MATERIAL' and qty_sisa >0 and dp.No_DPM=dpr.no_dpm", sqlconn).ExecuteReader

        'da2 = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        'da2.Fill(ds2, "_lookup")
        'lookupbrg.DataSource = ds2.Tables("_lookup")
        'lookupbrg.ValueMember = "Kode_Barang"
        'lookupbrg.DisplayMember = "Nama_Barang"

        'If ds4.Tables("PRD").Rows.Count > 0 Then
        '    Dim row As DataRow

        '    row = ds4.Tables("PRD").Rows(0)
        '    txtNomor.Text = row.Item("no_pr").ToString
        '    dttglpr.EditValue = row.Item("tgl_pr")      'Tanggal = CONVERT(char(10),'" & Now.ToString("MM/dd/yyyy") & "',105)

        'End If
        'If STATE = "ADD" Then
        '    Dim dr As SqlDataReader = New SqlCommand(" select *  from PURC.DBO.PURC_DPM_D dp where  rec_stat='APPROVE' and tipe_trans='MATERIAL' and qty_sisa >0", sqlconn).ExecuteReader
        '    While dr.Read

        '        Dim rw As DataRow = ds4.Tables("PRD").NewRow

        '        rw.Item("no_dpm") = dr.Item("no_dpm")
        '        rw.Item("kd_stok") = dr.Item("kd_stok")
        '        rw.Item("satuan") = dr.Item("satuan")
        '        rw.Item("qty_order") = dr.Item("qty_sisa")
        '        rw.Item("jns_dpm") = dr.Item("tipe_trans")
        '        rw.Item("qty_sisa") = dr.Item("qty_sisa")
        '        rw.Item("qty_pr") = 0
        '        rw.Item("Tgl_Diperlukan") = dr.Item("Tgl_Diperlukan")
        '        ds4.Tables("PRD").Rows.Add(rw)

        '    End While
        '    'If STATE = "EDIT" Then
        '    '    MsgBox("OK", MsgBoxStyle.Information, "Tes")
        '    'End If
        '    dr.Close()
        'ElseIf STATE = "EDIT" Then
        '    If Not ds4.Tables("PRD") Is Nothing Then ds4.Tables("PRD").Clear()



        '    da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as jns_dpm,'' as nama_barang,'' as Tgl_Diperlukan from PURC.DBO.PURC_PR_D ", sqlconn))
        '    da4.Fill(ds4, "PRD")
        '    Dim dr As SqlDataReader = New SqlCommand("select *  from PURC.dbo.purcv_dpmbarang where qty_sisa>0 and no_pr='" & kode & "'", sqlconn).ExecuteReader
        '    While dr.Read

        '        Dim rw As DataRow = ds4.Tables("PRD").NewRow

        '        rw.Item("no_dpm") = dr.Item("no_dpm")
        '        rw.Item("kd_stok") = dr.Item("kd_stok")
        '        rw.Item("satuan") = dr.Item("satuan")
        '        rw.Item("qty_order") = dr.Item("qty_sisa")
        '        rw.Item("jns_dpm") = dr.Item("tipe_trans")
        '        rw.Item("qty_sisa") = dr.Item("qty_sisa")
        '        rw.Item("qty_pr") = 0
        '        rw.Item("Tgl_Diperlukan") = dr.Item("Tgl_Diperlukan")
        '        ds4.Tables("PRD").Rows.Add(rw)

        '    End While

        'End If
        ''GV.Columns(1).Group()

        GcPR.DataSource = ds4.Tables("PRD")

    End Sub

    Sub awal()
        connect()
        dttglpr.DateTime = Date.Today
        If Not ds4.Tables("PRD") Is Nothing Then
            ds4.Clear()
        End If

        If Not ds2.Tables("_lookup") Is Nothing Then
            ds2.Clear()
        End If

        da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as jns_dpm,'' as nama_barang,'' as Tgl_Diperlukan from PURC.DBO.PURC_PR_D where no_pr='" & nopr & "' ", sqlconn))
        da4.Fill(ds4, "PRD")
        GcPR.DataSource = ds4.Tables("PRD")


        'Dim dr As SqlDataReader = New SqlCommand(" select *  from PURC.DBO.PURC_DPM_D  where  rec_stat='APPROVE' and tipe_trans='MATERIAL' and qty_sisa >0", sqlconn).ExecuteReader
        da2 = New SqlDataAdapter(New SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        da2.Fill(ds2, "_lookup")
        lookupbrg.DataSource = ds2.Tables("_lookup")
        lookupbrg.ValueMember = "Kode_Barang"
        lookupbrg.DisplayMember = "Nama_Barang"

        Dim dr As SqlDataReader = New SqlCommand(" select *  from PURC.dbo.purcv_dpmbarang where qty_sisa>0", sqlconn).ExecuteReader
        While dr.Read
            Dim rw As DataRow = ds4.Tables("PRD").NewRow

            rw.Item("no_dpm") = dr.Item("no_dpm")
            rw.Item("kd_stok") = dr.Item("kd_stok")
            rw.Item("satuan") = dr.Item("satuan")
            rw.Item("qty_order") = dr.Item("qty_sisa")
            rw.Item("jns_dpm") = dr.Item("tipe_trans")
            rw.Item("qty_sisa") = dr.Item("qty_sisa")
            rw.Item("no_seq") = dr.Item("no_seq")
            rw.Item("qty_pr") = 0
            rw.Item("keterangan") = dr.Item("keterangan")
            If dr.Item("Tgl_Diperlukan").ToString <> "" Then
                rw.Item("Tgl_Diperlukan") = FormatDateTime(dr.Item("Tgl_Diperlukan"), DateFormat.ShortDate)
            End If
            ds4.Tables("PRD").Rows.Add(rw)

        End While
        'GV.Columns(1).Group()
        prn = getParent(Me)
        dr.Close()
    End Sub
    Private Sub FrmPurchasing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'connect()
        'DA = New SqlDataAdapter(New SqlCommand("SELECT * from PURC.dbo.PURC_PR_D", sqlconn))
        'DA.Fill(ds4, "PRD")
        'GC.DataSource = ds4.Tables("PRD")
        awal()

        'reload_table(no_pr)
    End Sub

    Private Sub GV_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        'If e.Column Is no_dpm Then
        '    Dim rw As DataRow
        '    rw = ds3.Tables("VDPM").Select("no_dpm='" & e.Value & "'")(0)
        '    GV.GetRow(e.RowHandle).item("nama_barang") = rw("nama_barang")
        '    GV.GetRow(e.RowHandle).item("satuan") = rw("Satuan")
        '    GV.GetRow(e.RowHandle).item("qty_order") = rw("QTY_ORDER")
        '    'GV.GetRow(e.RowHandle).item("kd_stok") = rw("kd_stok")
        'End If
        If e.Column Is qty_pr Then
            If GV.GetRow(e.RowHandle).item("qty_pr") > GV.GetRow(e.RowHandle).item("qty_order") Then
                MsgBox("Jumlah PR lebih besar dari Jumlah order DPM", MsgBoxStyle.Critical, "Konfirmasi")
                GV.GetRow(e.RowHandle).item("qty_pr") = 0
            ElseIf GV.GetRow(e.RowHandle).item("qty_pr") < GV.GetRow(e.RowHandle).item("qty_order") Then
                GV.GetRow(e.RowHandle).item("qty_sisa") = GV.GetRow(e.RowHandle).item("qty_order").ToString - GV.GetRow(e.RowHandle).item("qty_pr").ToString
            Else
                GV.GetRow(e.RowHandle).item("qty_sisa") = GV.GetRow(e.RowHandle).item("qty_order").ToString - GV.GetRow(e.RowHandle).item("qty_pr").ToString
            End If

        End If
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
        Dim tglnow As Date = getTanggal()
        Dim BTRANS As SqlTransaction

        Buildernya = New SqlClient.SqlCommandBuilder(da4)
        da4.UpdateCommand = Buildernya.GetUpdateCommand()
        da4.InsertCommand = Buildernya.GetInsertCommand()
        da4.DeleteCommand = Buildernya.GetDeleteCommand()

        BTRANS = sqlconn.BeginTransaction("1")

        da4.UpdateCommand.Transaction = BTRANS
        da4.InsertCommand.Transaction = BTRANS
        da4.DeleteCommand.Transaction = BTRANS

        If Not isDelete Then
            If STATE = "ADD" Then
                For Each row In ds4.Tables("PRD").Rows
                    If row.RowState = DataRowState.Added Then
                        row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
                        ' row.Item("No_PR") = txtNomor.Text
                        row.Item("Tgl_pr") = dttglpr.EditValue
                        row.Item("Program_Name") = Me.Name
                        row.Item("Last_Create_Date") = Now
                        row.Item("Last_Created_By") = username
                        'row.Item("approval") = "ENTRY"
                        row.Item("rec_stat") = "APPROVE"

                    Else ': STATE = "EDIT"
                        row = ds4.Tables("PRD").Rows(0)
                        row.Item("Last_Update_Date") = Now
                        row.Item("Last_Updated_By") = username
                    End If

                Next

            ElseIf STATE = "EDIT" Then
                For Each rows In ds4.Tables("PRD").Rows
                    rows.Item("no_pr") = txtNomor.Text
                    rows.Item("Last_Update_Date") = tglnow
                    rows.Item("Last_Updated_By") = username
                Next
            End If


            'For Each rw As DataRow In (ds4.Tables("PRD").Select("qty_pr =0"))
            '    rw.Delete()
            'Next

            For i = ds4.Tables("PRD").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = ds4.Tables("PRD").Rows(i)
                If rows("qty_pr") = 0.0 Then
                    ds4.Tables("PRD").Rows(i).Delete()
                End If

            Next


            'For Each row In ds4.Tables("PRD").Rows
            '    If row.RowState <> DataRowState.Deleted Then
            '        Dim dr As Integer = New SqlCommand("update PURC.DBO.PURC_DPM_D set Qty_sisa= " & row.Item("qty_sisa") & " where Kd_Stok='" & row.Item("Kd_Stok") & "' and  no_dpm='" & row.Item("No_DPM") & "'", sqlconn, BTRANS).ExecuteNonQuery
            '    End If                
            'Next
        End If
        Try

            If STATE = "ADD" Then
                row.Item("No_PR") = getNoTrans("PR-M", getTanggal(BTRANS), BTRANS)
                txtNomor.Text = row.Item("No_PR")
                For Each rows As DataRow In ds4.Tables("PRD").Rows
                    If rows.RowState = DataRowState.Added Then
                        rows.Item("No_PR") = row.Item("No_PR")
                    End If
                Next
            End If


            da4.Update(ds4.Tables("PRD"))
            ds4.Tables("PRD").AcceptChanges()

            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan..")

            after_save()
        Catch e As Exception
            BTRANS.Rollback()
            ds4.Tables("PRD").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
        'btn_supp.Enabled = True
    End Sub

    Public Sub after_save()

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True

        setStatus()
        Me.Enabled = False
    End Sub

    Public Sub edit_click()
        If Not dsedit.Tables("lookup_PR") Is Nothing Then dsedit.Tables("lookup_PR").Clear()
        'daedit = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct No_PR as [Nomor], tgl_PR as [Tanggal] from PURC.DBO.PURC_PR_D where jns_dpm='MATERIAL' and rec_stat='ENTRY' or rec_stat='REJECT' ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        daedit = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct PRD.no_pr as [Nomor], PRD.tgl_pr as [Tanggal] from PURC.DBO.PURC_PR_D PRD " & _
                                                                       "left join PURC.DBO.PURC_CHOICE_SUPP CSP on PRD.kd_stok=CSP.kd_stok and PRD.no_pr=CSP.no_pr " & _
                                                                       "where PRD.jns_dpm='MATERIAL' and CSP.no_csp is null order by PRD.no_pr desc", sqlconn))
        If Not dsedit.Tables("lookup_PR") Is Nothing Then dsedit.Tables("lookup_PR").Clear()
        daedit.Fill(dsedit, "lookup_PR")
        frmCari.set_dso(dsedit.Tables("lookup_PR")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            STATE = "EDIT"
            txtNomor.Text = frmCari.row(0).ToString
            dttglpr.DateTime = frmCari.row(1)
            reload_table(frmCari.row(0))
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
        If MsgBox("Hapus Data PURCHASING REQUEST MATERIAL ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
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
    Private Sub btSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
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


    Private Sub dttglpr_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dttglpr.EditValueChanged

    End Sub

    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportHeaderArea
        Dim reportHeader As String = "Purchasing Material"
        subReport = txtNomor.Text
        subReport1 = dttglpr.EditValue


        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Times New Roman", 12, FontStyle.Bold)
        e.Graph.BackColor = Color.White
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 20)
        Dim rec2 As RectangleF = New RectangleF(0, 20, e.Graph.ClientPageSize.Width, 50)
        Dim rec3 As RectangleF = New RectangleF(0, 40, e.Graph.ClientPageSize.Width, 80)
        e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None)
        e.Graph.DrawString(subReport, Color.Black, rec2, BorderSide.None)
        e.Graph.DrawString(subReport1, Color.Black, rec3, BorderSide.None)
    End Sub
    Private Sub PrintableComponentLink1_CreateReportFooterArea(ByVal sender As Object, ByVal e As DevExpress.XtraPrinting.CreateAreaEventArgs) Handles PrintableComponentLink1.CreateReportFooterArea
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Arial", 10, FontStyle.Regular)
        e.Graph.BackColor = Color.White
        Dim reportFooter1 As String = "Dibuat Oleh,"
        Dim reportFooter3 As String = "(_______________________)"
        Dim reportFooter4 As String = "Diketahui Oleh,"
        Dim reportFooter6 As String = "(_______________________)"

        Dim rec1 As RectangleF = New RectangleF((e.Graph.ClientPageSize.Width / 4) - 150, 100, 300, 20)
        Dim rec3 As RectangleF = New RectangleF((e.Graph.ClientPageSize.Width / 4) - 150, 200, 300, 20)
        Dim rec4 As RectangleF = New RectangleF(((e.Graph.ClientPageSize.Width / 4) * 3) - 150, 100, 300, 20)
        Dim rec6 As RectangleF = New RectangleF(((e.Graph.ClientPageSize.Width / 4) * 3) - 150, 200, 300, 20)

        e.Graph.DrawString(reportFooter1, Color.Black, rec1, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter3, Color.Black, rec3, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter4, Color.Black, rec4, DevExpress.XtraPrinting.BorderSide.None)
        e.Graph.DrawString(reportFooter6, Color.Black, rec6, DevExpress.XtraPrinting.BorderSide.None)

    End Sub
End Class