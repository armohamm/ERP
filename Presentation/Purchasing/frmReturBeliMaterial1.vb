Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid
Imports DevExpress.XtraPrinting
Imports System.Data.SqlClient

Public Class frmReturBeliMaterial1
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public btnCetak As Boolean = True
    Public prn As frmMain   '<-- untuk mengakses frmMain
    Public obj As Object
    Public a, j, u As String
    Dim b As Date
    Dim n As Decimal
    Dim k As String

    Dim dSO As New DataSet
    Dim ds, dsedit, ds1, ds2, ds3, ds4, ds5, ds6, ds7, dss, dss1,dsINV As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row, rows, rows1 As DataRow
    Dim DA, dalok, daedit, da2, da3, da4, da5, da6, da7, sqlda, sqlda1, daINV As SqlClient.SqlDataAdapter
    Dim Buildernya As New SqlClient.SqlCommandBuilder
    Private Sub V_Supplier()
        da5 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Supplier,Nama_Supplier from sif.dbo.SIF_Supplier", sqlconn))
        da5.Fill(ds5, "View_Supplier")
        LESupllier.Properties.DataSource = ds5.Tables("View_Supplier")
    End Sub
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
    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder
        btnadd = False ' mendisable tombol add yang ada di frmUtama
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnSave = True
        With prn '<- untuk sementara dimatika klau sudah digabung dengan form main ini dinyalakan lagi
            .btnAdd.Enabled = False ' mendisable tombol add yang ada di frmUtama
            .btnCancel.Enabled = True
            .btnDelete.Enabled = False
            .btnEdit.Enabled = False
            .btnSave.Enabled = True

        End With
        setStatus()
        STATE = "ADD" '<-- set state add
        dtTanggal.EditValue = getTanggal()
        controlOff(False)
    End Sub

    Private Sub bersih()
        LEPO.EditValue = vbNullString
        LESupllier.EditValue = vbNullString
        txtNoRetur.EditValue = vbNullString
        txtNoRef.EditValue = vbNullString
        txtKeterangan.Text = ""
        txtstatus.EditValue = vbNullString
        txtJmlTotal.EditValue = vbNullString
        CheckBox1.Checked = False
    End Sub
    Public Sub cancel_click()
        reload_table("XXX")
        bersih()
        btnadd = True ' mendisable tombol add yang ada di frmUtama
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnSave = False
        With prn '<- untuk sementara dimatika klau sudah digabung dengan form main ini dinyalakan lagi
            .btnAdd.Enabled = True ' mendisable tombol add yang ada di frmUtama
            .btnCancel.Enabled = False
            .btnDelete.Enabled = False
            .btnEdit.Enabled = True
            .btnSave.Enabled = False

        End With
        setStatus()
        Me.Enabled = False
    End Sub
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        

        edit_click()
        STATE = "EDIT"
      
        With prn '<- untuk sementara dimatika klau sudah digabung dengan form main ini dinyalakan lagi
            .btnAdd.Enabled = False ' mendisable tombol add yang ada di frmUtama
            .btnCancel.Enabled = True
            .btnDelete.Enabled = True
            .btnEdit.Enabled = False
            .btnSave.Enabled = True

        End With
        setStatus()
        Me.Enabled = False
    End Sub

    Private Sub controlOff(ByVal stat As Boolean)
        LEPO.Properties.ReadOnly = stat
        LEINV.Properties.ReadOnly = stat
        LESupllier.Properties.ReadOnly = stat
        dtTanggal.Properties.ReadOnly = stat
        txtNoRef.Properties.ReadOnly = stat
        txtKeterangan.ReadOnly = stat
        txtstatus.Properties.ReadOnly = stat
        ' GV.OptionsBehavior.ReadOnly = stat
        GV.Columns("satuan").OptionsColumn.ReadOnly = stat
        GV.Columns("kd_stok").OptionsColumn.ReadOnly = stat
        GV.Columns("harga").OptionsColumn.ReadOnly = False
        GV.Columns("keterangan").OptionsColumn.ReadOnly = stat
        GV.Columns("qty").OptionsColumn.ReadOnly = stat
    End Sub

    Public Sub call_procedure(ByVal noSJ As String, ByVal trans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_RTR_PEMBELIAN_EDIT"

        sqlCmd.Parameters.Add("@vno_trans", SqlDbType.Char).Value = noSJ
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub edit_click()
       
        dSO = New DataSet
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.no_retur NoRetur,a.tanggal,a.no_po,b.Nama_Supplier,a.jml_rp_trans Jumlah,a.keterangan  from PURC.dbo.PURC_RETUR_BELI a " & _
                                                                   "inner join sif.dbo.SIF_Supplier b on a.kd_supplier=b.Kode_Supplier " & _
                                                                   "where a.no_retur like '%RTR-M%' order by a.tanggal desc", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "LOOKUP_SIF_Customer")
        frmCari.set_dso(dSO.Tables(0))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then

            da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *  from PURC.dbo.PURC_RETUR_BELI a " & _
                                                                   "inner join sif.dbo.SIF_Supplier b on a.kd_supplier=b.Kode_Supplier " & _
                                                                   "where a.no_retur like '%RTR-M%' and a.no_retur='" & frmCari.row("NoRetur") & "' order by tanggal desc", sqlconn))
            da3.Fill(ds3, "RTR")

            STATE = "EDIT"
            If ds3.Tables("RTR").Rows.Count > 0 Then
                txtNoRetur.Text = ds3.Tables(0).Rows(0).Item("no_retur").ToString
                LEPO.EditValue = ds3.Tables(0).Rows(0).Item("no_po").ToString
                LESupllier.EditValue = ds3.Tables(0).Rows(0).Item("kd_supplier").ToString
                dtTanggal.EditValue = ds3.Tables(0).Rows(0).Item("tanggal")
                '  MessageBox.Show(dtTanggal.EditValue)
                LEINV.EditValue = ds3.Tables(0).Rows(0).Item("no_ref1").ToString
                txtNoRef.EditValue = ds3.Tables(0).Rows(0).Item("no_ref").ToString
                txtKeterangan.Text = ds3.Tables(0).Rows(0).Item("keterangan").ToString

                n = ds3.Tables(0).Rows(0).Item("jml_rp_trans").ToString
                txtJmlTotal.EditValue = n.ToString("C2")
                u = ds3.Tables(0).Rows(0).Item("status").ToString

                If u = "Y" Then
                    CheckBox1.Checked = True
                ElseIf u = "N" Then
                    CheckBox1.Checked = False
                End If
            End If
            'neurebian weaver skuchi 
            'controlOff(True)
            da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' As No,'' as no_po , '' as kd_satuan ,qty*harga as total from PURC.dbo.PURC_RETUR_BELI_D  where no_retur= '" & frmCari.row("NoRetur") & "'", sqlconn))
            da4.Fill(ds4, "RTRD")
            GC.DataSource = ds4.Tables("RTRD")

            If Not ds3.Tables("cekretur") Is Nothing Then ds3.Tables("cekretur").Clear()
            da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *  from PURC.dbo.PURC_RETUR_BELI  " & _
                                                                 "where no_retur in (select no_ref from inv.dbo.INV_GUDANG_OUT where no_trans like '%/INV/RTR%')" & _
                                                                 "and no_retur like '%RTR-M%' and no_retur='" & frmCari.row("NoRetur") & "'", sqlconn))
            da3.Fill(ds3, "cekretur")
            If ds3.Tables("cekretur").Rows.Count > 0 Then

                txtstatus.Text = "BARANG KELUAR"

                controlOff(True)

            ElseIf ds3.Tables("cekretur").Rows.Count <= 0 Then
                controlOff(False)
                txtstatus.Text = ds3.Tables(0).Rows(0).Item("rec_stat").ToString
            End If

            btnadd = False ' mendisable tombol add yang ada di frmUtama
            btnCancel = True
            btnDelete = True
            btnEdit = False
            btnSave = True
            btnCetak = True
            With prn '<- untuk sementara dimatika klau sudah digabung dengan form main ini dinyalakan lagi
                .btnAdd.Enabled = False ' mendisable tombol add yang ada di frmUtama
                .btnCancel.Enabled = True
                .btnDelete.Enabled = True
                .btnEdit.Enabled = False
                .btnSave.Enabled = True
                .btnCetak.Enabled = True
            End With
            setStatus()


        Else
            cancel_click()
            controlOff(False)
        End If
        



    End Sub
    Private Function NomorRTR(ByVal bgtrans As SqlTransaction) As String
        Dim hasil, temp As String
        Dim sqldr As SqlDataReader = New SqlCommand("select max(substring(IsNULL(no_retur,'00001'),1,5))+1 from PURC.DBO.PURC_RETUR_BELI", sqlconn, bgtrans).ExecuteReader
        sqldr.Read()
        temp = ""
        If TypeOf sqldr.Item(0) Is DBNull Then
            Dim bln1 As String = Format(Now, "MM")
            Dim th1 As String = Format(Now, "yyyy")
            hasil = "00001" & "/" & "RTR" & "/" & th1 & bln1
        Else
            hasil = sqldr.Item(0)
            For i As Int16 = Len(hasil) To 4
                temp = "0" & temp
            Next
            Dim th, bln As String
            bln = Format(Now, "MM")
            th = Format(Now, "yyyy")
            hasil = temp & (hasil) & "/" & "RTR" & "/" & th & bln
        End If
        sqldr.Close()
        Return hasil
    End Function
    Sub View_barang()
        'da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_po from PURC.DBO.PURC_PO where tipe_trans='JPP-KUT-01'", sqlconn))
        dalok = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang kd_stok,Nama_Barang from  sif.dbo.SIF_Barang where kd_jns_persd in ('1','2','3')", sqlconn))
        dalok.Fill(ds3, "View_barang")

        repBarang.DataSource = ds3.Tables("View_barang")
        repBarang.DisplayMember = "Nama_Barang"
        repBarang.ValueMember = "kd_stok"
    End Sub

    Sub View_barang1()
        If Not ds3.Tables("View_barang1") Is Nothing Then ds3.Tables("View_barang1").Clear()
        'da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_po from PURC.DBO.PURC_PO where tipe_trans='JPP-KUT-01'", sqlconn))
        dalok = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang kd_stok,Nama_Barang from  sif.dbo.SIF_Barang where kd_jns_persd in ('1','2','3')", sqlconn))
        dalok.Fill(ds3, "View_barang1")

        repBarang1.DataSource = ds3.Tables("View_barang1")
        repBarang1.DisplayMember = "Nama_Barang"
        repBarang1.ValueMember = "kd_stok"
        RepositoryItemGridLookUpEdit1View.Columns("kd_stok").Visible = False
    End Sub

    Sub View_RTR_D()
        'da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_po from PURC.DBO.PURC_PO where tipe_trans='JPP-KUT-01'", sqlconn))
        da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct a.no_po no_ref1,b.Nama_Supplier from  sif.dbo.SIF_Supplier b left join purc.dbo.purc_po a on a.kd_supplier=b.Kode_Supplier inner join purc.dbo.purc_po_d c on c.no_po=a.no_po  where a.no_po is not null and a.tipe_trans='JPP-KUT-01' and c.inv_stat=1 order by a.no_po desc", sqlconn))
        da7.Fill(ds7, "View_RTR_D")
        LEPO.Properties.DataSource = ds7.Tables("View_RTR_D")
        LEPO.Properties.DisplayMember = "no_ref1"
        LEPO.Properties.ValueMember = "no_ref1"
    End Sub

    Private Sub NO(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        For Each rw As DataRow In sender.Rows
            rw("no_seq") = i
            i += 1
        Next
    End Sub


    Public Sub cetak_click()

        'callReport(App_Path() & "\report\rptDPM_M.rpt", "", "Nomor=0014/DPM/201106")
        callReport(App_Path() & "\report\rptRTRM.rpt", "", "Nomor=" & Trim(txtNoRetur.Text), False, True)


        If Not ds3.Tables("RTR") Is Nothing Then ds3.Tables("RTR").Clear()
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_RETUR_BELI where no_retur='" & txtNoRetur.Text & "'", sqlconn))
        da3.Fill(ds3, "RTR")

        row = ds3.Tables("RTR").Rows(0)
        row.Item("jumlah_cetak") = row.Item("jumlah_cetak") + 1


        Buildernya = New SqlClient.SqlCommandBuilder(da3)
        da3.UpdateCommand = Buildernya.GetUpdateCommand()
        'da3.InsertCommand = Buildernya.GetInsertCommand()

        da3.Update(ds3.Tables("RTR"))

        ds3.Tables("RTR").AcceptChanges()
       
    


    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction



        If Not isDelete Then

            If STATE = "ADD" Then

                row = ds3.Tables("RTR").NewRow
                row.Item("No_retur") = getNoTrans("RTR-M", getTanggal(BTRANS), BTRANS)

                txtNoRetur.Text = row.Item("No_retur")
                row.Item("No_retur") = row.Item("No_retur")
                row.Item("Last_Create_Date") = getTanggal()

            ElseIf STATE = "EDIT" Then
                row = ds3.Tables("RTR").Rows(0)
                row.Item("Last_Update_Date") = getTanggal()

                row.Item("Last_Updated_By") = username
            End If
            
            row.Item("status") = IIf(CheckBox1.Checked = False, "N", "Y")
            row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
            row.Item("tanggal") = dtTanggal.EditValue
            row.Item("no_po") = LEPO.EditValue
            row.Item("no_ref") = txtNoRef.Text
            row.Item("no_ref1") = LEINV.EditValue
            row.Item("kd_supplier") = LESupllier.EditValue
            row.Item("keterangan") = txtKeterangan.Text
            row.Item("jml_rp_trans") = GV.Columns("total").SummaryText
            row.Item("jumlah_cetak") = 0
            row.Item("rec_stat") = "ENTRY"
            txtstatus.Text = row.Item("rec_stat")
            row.Item("Program_Name") = Me.Name

            If STATE = "ADD" Then
                ds3.Tables("RTR").Rows.Add(row)
            End If


            If LEPO.EditValue <> vbNullString Then
                For Each rows As DataRow In ds4.Tables("RTRD").Select("qty > 0")

                    If rows.RowState = DataRowState.Added Then
                        'rows.Item("no_po") = row.Item("no_po")
                        ' rows.Item("No_retur") = row.Item("No_retur")
                        rows.Item("Last_Create_Date") = getTanggal()

                        rows.Item("Last_Created_By") = username
                        rows.Item("rec_stat") = "ENTRY"
                        rows.Item("Kd_Cabang") = rows.Item("Kd_Cabang")
                        rows.Item("qty_sisa") = rows.Item("qty")
                        'rows.Item("tipe_trans") = "JPP-KUT-01"
                        rows.Item("Program_name") = Me.Name

                    ElseIf rows.RowState = DataRowState.Modified Then
                        rows.Item("No_retur") = txtNoRetur.Text
                        rows.Item("Kd_Cabang") = kdcabang
                        rows.Item("Last_Update_Date") = getTanggal()

                        rows.Item("Last_Updated_By") = username
                        rows.Item("Program_name") = Me.Name
                    End If
                    ' If rows.RowState = DataRowState.Deleted Then rows.Delete()

                Next

                If LEPO.EditValue <> vbNullString Then
                    For Each rows As DataRow In ds4.Tables("RTRD").Select("qty =0")

                        rows.Delete()

                    Next

                End If



            ElseIf LEPO.EditValue = vbNullString Then


                For Each rows As DataRow In ds4.Tables("RTRD").Rows

                    If rows.RowState = DataRowState.Added Then
                        'rows.Item("no_po") = row.Item("no_po")
                        'rows.Item("No_retur") = row.Item("No_retur")
                        rows.Item("Last_Create_Date") = Now
                        rows.Item("Last_Created_By") = username
                        rows.Item("rec_stat") = "ENTRY"
                        rows.Item("Kd_Cabang") = kdcabang
                        rows.Item("qty_sisa") = rows.Item("qty")
                        'rows.Item("tipe_trans") = "JPP-KUT-01"
                        rows.Item("Program_name") = Me.Name
                    ElseIf rows.RowState = DataRowState.Modified Then
                        'rows.Item("No_retur") = txtNoRetur.Text
                        rows.Item("Kd_Cabang") = kdcabang
                        rows.Item("Last_Update_Date") = Now
                        rows.Item("Last_Updated_By") = username
                        rows.Item("Program_name") = Me.Name
                    End If


                Next
            End If
        End If
        Try

            If LEPO.EditValue = vbNullString Then
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

            ElseIf LEPO.EditValue <> vbNullString Then
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

                'da3.Update(ds3.Tables("RTR"))

                'da4.Update(ds4.Tables("RTRD"))

                'ds3.Tables("RTR").AcceptChanges()

                'ds4.Tables("RTRD").AcceptChanges()
                'STATE = "EDIT"
                'BTRANS.Commit()
                'showMessages("Berhasil disimpan..")
            End If
            If STATE = "ADD" Then
                '    If LEPO.EditValue <> vbNullString Then

                '        row.Item("No_retur") = getNoTrans("RTR-M", getTanggal(BTRANS), BTRANS)

                '        txtNoRetur.Text = row.Item("No_retur")
                '        For Each rows As DataRow In ds4.Tables("RTRD").Rows
                '            If rows.Item("qty") > 0 Then
                '                If rows.RowState = DataRowState.Added Then
                '                    rows.Item("No_retur") = row.Item("No_retur")
                '                ElseIf rows.RowState = DataRowState.Modified Then
                '                    rows.Item("No_retur") = txtNoRetur.Text
                '                End If

                '                da3.Update(ds3.Tables("RTR"))

                '                da4.Update(ds4.Tables("RTRD"))

                '                ds3.Tables("RTR").AcceptChanges()

                '                ds4.Tables("RTRD").AcceptChanges()
                '            End If

                '        Next



                'If LEPO.EditValue = vbNullString Then

                row.Item("No_retur") = getNoTrans("RTR-M", getTanggal(BTRANS), BTRANS)

                txtNoRetur.Text = row.Item("No_retur")
                For Each rows As DataRow In ds4.Tables("RTRD").Rows

                    If rows.RowState = DataRowState.Added Then
                        rows.Item("No_retur") = row.Item("No_retur")
                    ElseIf rows.RowState = DataRowState.Modified Then
                        rows.Item("No_retur") = txtNoRetur.Text
                    End If
                Next
                'End If
            ElseIf STATE = "EDIT" Then

                For Each rows As DataRow In ds4.Tables("RTRD").Rows
                    If rows.RowState = DataRowState.Added Then
                        rows.Item("No_retur") = txtNoRetur.Text

                    ElseIf rows.RowState = DataRowState.Modified Then
                        rows.Item("No_retur") = txtNoRetur.Text
                    End If
                Next
                'call_procedure(txtNoRetur.EditValue, BTRANS)
            End If




            da3.Update(ds3.Tables("RTR"))

            da4.Update(ds4.Tables("RTRD"))

            ds3.Tables("RTR").AcceptChanges()

            ds4.Tables("RTRD").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan..")
            btnCetak = True
            With prn '<- untuk sementara dimatika klau sudah digabung dengan form main ini dinyalakan lagi
                .btnCetak.Enabled = True ' mendisable tombol add yang ada di frmUtama
              

            End With
            setStatus()


        Catch e As Exception
            BTRANS.Rollback()
            ds3.Tables("RTR").RejectChanges()
            ds4.Tables("RTRD").AcceptChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try

    End Sub
    Private Sub GV_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged

        If e.Column Is nama_barang Then
            GV.GetRow(e.RowHandle).item("kd_stok") = GV.GetRow(e.RowHandle).item("kd_stok")

        End If
        If LEPO.EditValue <> vbNullString Then

            If e.Column Is kd_stok Then
                Try
                    Dim rw As DataRow
                    rw = ds.Tables("VBARANG").Select("Kode_Barang='" & e.Value & "'")(0)
                    GV.GetRow(e.RowHandle).item("satuan") = rw("Kd_Satuan")

                Catch ex As Exception
                    GV.GetRow(e.RowHandle).item("satuan") = "BUAH"

                End Try
            End If
            If e.Column Is QTY Then
                GV.GetRow(e.RowHandle).item("total") = GV.GetRow(e.RowHandle).item("harga").ToString * GV.GetRow(e.RowHandle).item("qty").ToString
                GV.GetRow(e.RowHandle).item("Kd_Cabang") = kdcabang
                n = getTotal()
                txtJmlTotal.EditValue = n.ToString("C2")

            End If
            If e.Column Is Harga Then
                GV.GetRow(e.RowHandle).item("total") = GV.GetRow(e.RowHandle).item("harga").ToString * GV.GetRow(e.RowHandle).item("qty").ToString
                GV.GetRow(e.RowHandle).item("Kd_Cabang") = kdcabang
                n = getTotal()
                txtJmlTotal.EditValue = n.ToString("C2")
            End If
            If e.Column Is Total Then
                n = getTotal()
                txtJmlTotal.EditValue = n.ToString("C2")
            End If


        ElseIf LEPO.EditValue = vbNullString Then
            If e.Column Is nama_barang Then
                GV.GetRow(e.RowHandle).item("kd_stok") = GV.GetRow(e.RowHandle).item("kd_stok")

            End If
            If e.Column Is nama_barang Then
                Try
                    If Not ds3.Tables("Satuan") Is Nothing Then ds3.Tables("Satuan").Clear()
                    dalok = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select b.Kode_Satuan, b.Nama_Satuan from sif.dbo.SIF_Barang a left join sif.dbo.SIF_Satuan b on a.Kd_Satuan=b.Kode_Satuan  where a.kd_jns_persd in ('1','2','3') and a.Kode_Barang='" & GV.GetRow(e.RowHandle).item("kd_stok") & "'", sqlconn))
                    dalok.Fill(ds3, "Satuan")

                    GV.GetRow(e.RowHandle).item("satuan") = ds3.Tables("Satuan").Rows(0).Item(0)

                    GV.GetRow(e.RowHandle).item("total") = GV.GetRow(e.RowHandle).item("harga").ToString * GV.GetRow(e.RowHandle).item("qty").ToString
                    n = getTotal()
                    txtJmlTotal.EditValue = n.ToString("C2")

                Catch ex As Exception
                    GV.GetRow(e.RowHandle).item("satuan") = "BUAH"
                    GV.GetRow(e.RowHandle).item("total") = GV.GetRow(e.RowHandle).item("harga").ToString * GV.GetRow(e.RowHandle).item("qty").ToString
                    n = getTotal()
                    txtJmlTotal.EditValue = n.ToString("C2")
                    'MessageBox.Show(n)

                End Try
            End If
            If e.Column Is QTY Then
                GV.GetRow(e.RowHandle).item("total") = GV.GetRow(e.RowHandle).item("harga").ToString * GV.GetRow(e.RowHandle).item("qty").ToString
                GV.GetRow(e.RowHandle).item("Kd_Cabang") = kdcabang
                GV.GetRow(e.RowHandle).item("total") = GV.GetRow(e.RowHandle).item("harga").ToString * GV.GetRow(e.RowHandle).item("qty").ToString
                n = getTotal()
                txtJmlTotal.EditValue = n.ToString("C2")
                'MessageBox.Show(n)

            End If
            If e.Column Is Harga Then
                GV.GetRow(e.RowHandle).item("total") = GV.GetRow(e.RowHandle).item("harga").ToString * GV.GetRow(e.RowHandle).item("qty").ToString
                GV.GetRow(e.RowHandle).item("Kd_Cabang") = kdcabang
                GV.GetRow(e.RowHandle).item("total") = GV.GetRow(e.RowHandle).item("harga").ToString * GV.GetRow(e.RowHandle).item("qty").ToString
                n = getTotal()
                txtJmlTotal.EditValue = n.ToString("C2")
                'MessageBox.Show(n)
            End If
            If e.Column Is Total Then
                GV.GetRow(e.RowHandle).item("total") = GV.GetRow(e.RowHandle).item("harga").ToString * GV.GetRow(e.RowHandle).item("qty").ToString
                n = getTotal()
                txtJmlTotal.EditValue = n.ToString("C2")
                'MessageBox.Show(n)
            End If




            GV.GetRow(e.RowHandle).item("total") = GV.GetRow(e.RowHandle).item("harga").ToString * GV.GetRow(e.RowHandle).item("qty").ToString
            n = getTotal()
            txtJmlTotal.EditValue = n.ToString("C2")
        End If



    End Sub
    Private Sub reload_table(ByVal kode As String)
        If Not ds3.Tables("RTR") Is Nothing Then ds3.Tables("RTR").Clear()
        If Not ds4.Tables("RTRD") Is Nothing Then ds4.Tables("RTRD").Clear()


        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_RETUR_BELI where no_retur='" & kode & "'", sqlconn))
        da3.Fill(ds3, "RTR")

        da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,isnull(Kd_Cabang,1) Kd_Cabangq,'' As No,'' as no_po , '' as Nama_Barang , '' as kd_satuan ,qty*harga as total from PURC.dbo.PURC_RETUR_BELI_D where no_retur= '" & kode & "'", sqlconn))
        da4.Fill(ds4, "RTRD")
        'GC.DataSource = ds4.Tables("POD")

        AddHandler ds4.Tables("RTRD").RowDeleted, AddressOf refreshNomer

        'JPP-KUT-01'
        If ds3.Tables("RTR").Rows.Count > 0 Then
            Dim row As DataRow

            row = ds3.Tables("RTR").Rows(0)
            txtNoRetur.Text = row.Item("no_retur").ToString
            LEPO.EditValue = row.Item("no_po")
            txtNoRef.Text = row.Item("no_ref").ToString
            dtTanggal.Text = row.Item("tanggal").ToString
            LESupllier.EditValue = row.Item("kd_supplier").ToString
            txtstatus.Text = row.Item("status").ToString
            n = row.Item("jml_rp_trans").ToString
            txtJmlTotal.Text = n.ToString("C2")
        End If


    End Sub

    Private Sub frmPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'dtTanggal.Text = Date.Today
        'dtKirim.Text = Date.Today
        STATE = "ADD"
        connect()
        prn = getParent(Me)

        View_RTR_D()
        V_Supplier()
        If STATE = "ADD" Then
            dtTanggal.Text = Date.Today
        End If
        If txtNoRetur.Text = "" Then
            reload_table("xxx")
            GC.DataSource = ds4.Tables("RTRD")
            View_barang()
            View_barang1()

        End If

    End Sub

    Public Sub cariPO(ByVal nocsp As String) ' ============= cretaed by yaya =============
        dss = New DataSet
        dss1 = New DataSet
        sqlda = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_RETUR_BELI where no_retur='" & nocsp & "'", sqlconn))
        sqlda.Fill(dss, "_yaya")
        'MsgBox(dss.Tables(0).Rows(0).Item("no_po").ToString)
        If dss.Tables(0).Rows.Count Then
            txtNoRetur.Text = dss.Tables(0).Rows(0).Item("no_retur").ToString
            txtstatus.Text = dss.Tables(0).Rows(0).Item("status").ToString
            dtTanggal.Text = dss.Tables(0).Rows(0).Item("tanggal").ToString
            LEPO.EditValue = dss.Tables(0).Rows(0).Item("no_po").ToString
            LESupllier.EditValue = dss.Tables(0).Rows(0).Item("kd_supplier").ToString
            txtKeterangan.Text = dss.Tables(0).Rows(0).Item("keterangan").ToString

        End If
        sqlda1 = New SqlDataAdapter(New SqlCommand("select * from PURC.DBO.PURC_RETUR_BELI_D where no_po='" & txtNoRetur.Text & "'", sqlconn))
        sqlda1.Fill(dss1, "_yaya_d")
        GC.DataSource = dss1.Tables("_yaya_d")

    End Sub

 


    Private Sub GV_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow

        GV.GetRow(e.RowHandle).item("no_seq") = GV.RowCount + 1
        GV.GetRow(e.RowHandle).item("harga") = 0
        GV.GetRow(e.RowHandle).item("qty") = 0
        GV.GetRow(e.RowHandle).item("total") = 0


    End Sub


    Private Sub btSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        save_click()
    End Sub

    Function getTotal() As Double
        Dim ttl As Double

        For Each rw As DataRow In ds4.Tables("RTRD").Rows
            If TypeOf rw.Item("qty") Is DBNull Then
                MsgBox("QTY Masih Kosong, Harap diisi", MsgBoxStyle.Information)
                rw.Item("qty") = 0
                Exit Function
            Else
                ttl += rw("total")
            End If
        Next
        Return ttl
    End Function

    Private Sub LEPO_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEPO.EditValueChanged
        Dim dr As SqlDataReader = New SqlCommand("select distinct Kode_Supplier from sif.dbo.SIF_Supplier,PURC.DBO.PURC_PO  where kode_supplier=kd_supplier and no_po='" & LEPO.EditValue & "'", sqlconn).ExecuteReader
        If dr.Read() Then
            LESupllier.EditValue = dr(0)
        Else
            LESupllier.EditValue = vbNullString
        End If

        dr.Close()
        If LEPO.EditValue <> vbNullString Then
            If Not dsINV.Tables("ds_inv") Is Nothing Then dsINV.Tables("ds_inv").Clear()
            daINV = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_inv from fin.dbo.fin_pembelian where no_ref1='" & LEPO.EditValue & "'", sqlconn))
            daINV.Fill(dsINV, "ds_inv")
            LEINV.Properties.DataSource = dsINV.Tables("ds_inv")
            LEINV.Properties.DisplayMember = "no_inv"
            LEINV.Properties.ValueMember = "no_inv"

            LEINV.ItemIndex = 0
        End If
    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Data RETUR Beli ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            STATE = "DELETE"
            If Not ds3.Tables("RTR") Is Nothing Then delete(ds3.Tables("RTR").Rows)
            If Not ds4.Tables("RTRD") Is Nothing Then delete(ds4.Tables("RTRD").Rows)


            save_click(True)
            cancel_click()
            STATE = ""
        End If
    End Sub
    Private Sub refreshNomer(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        Dim j As Int16 = 1
        If STATE = "DELETE" Then Exit Sub
        For Each rw As DataRow In sender.Rows
            If rw.RowState <> DataRowState.Deleted Then
                For Each rwd As DataRow In ds4.Tables("RTRD").Select("NO=" & rw.Item("No_seq"))

                    rwd("NO") = i
                    rwd("No_seq") = i & "." & j
                    j += 1
                Next
                j = 1
                rw("No_seq") = i
                i += 1
            End If
        Next
    End Sub


    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub
    Private Sub LESupllier_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LESupllier.EditValueChanged

        If LESupllier.Text = "" Then
            If Not ds4.Tables("POD") Is Nothing Then ds4.Tables("POD").Clear()
            Exit Sub
        End If
        If txtNoRetur.Text = "" Then
            ds4.Tables("RTRD").Clear()
            Dim dr As SqlDataReader = New SqlCommand(" select * from PURC.dbo.vBarangPOTerpilih a left join SIF.dbo.SIF_Barang b on a.kd_stok=b.Kode_Barang  where a.kd_supplier='" & LESupllier.EditValue & "' and a.no_po='" & LEPO.EditValue & "' ", sqlconn).ExecuteReader
            Dim i As Int16 = 1
            While dr.Read
                Dim rw As DataRow = ds4.Tables("RTRD").NewRow
                rw.Item("no_po") = dr.Item("no_po")
                rw.Item("kd_stok") = dr.Item("kd_stok")
                rw.Item("Nama_Barang") = dr.Item("Nama_Barang")
                rw.Item("satuan") = dr.Item("kd_satuan")
                rw.Item("harga") = dr.Item("harga")
                rw.Item("qty") = dr.Item("qty")
                rw.Item("Total") = dr.Item("total")
                rw.Item("keterangan") = dr.Item("keterangan")
                rw.Item("no_seq") = i
                rw.Item("Kd_Cabang") = kdcabang

                n = dr.Item("qty_total")
                txtJmlTotal.EditValue = n.ToString("C2")

                i += 1
                ds4.Tables("RTRD").Rows.Add(rw)
            End While
            dr.Close()
        End If
        a = "1"
    End Sub


    Private Sub GC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GC.KeyDown
        If e.KeyCode = Keys.Delete Then
            STATE = "DELETE"
            If GV.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Record Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar DPM") = MsgBoxResult.Yes Then
                    GV.DeleteSelectedRows()
                End If
            End If
            save_click(True)
            n = getTotal()
            txtJmlTotal.EditValue = n.ToString("C2")

        End If
    End Sub

    Private Sub LEINV_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEINV.EditValueChanged

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub

    Private Sub dtTanggal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtTanggal.EditValueChanged

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

End Class