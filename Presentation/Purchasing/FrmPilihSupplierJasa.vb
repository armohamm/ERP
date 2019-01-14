
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient
Public Class FrmPilihSupplierJasa
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain   '<-- untuk mengakses frmMain
    Public obj As Object
    Dim dS, ds1, ds2, dsedit, ds3, ds4, ds5, ds6, ds7, ds8, dss, dss1 As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Dim DA, da2, da3, daedit, da4, da5, da6, da7, da8, sqlda, sqlda1 As SqlClient.SqlDataAdapter
    Dim Buildernya As New SqlClient.SqlCommandBuilder
    Public JenisLoad As String

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Private Sub NO(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        For Each rw As DataRow In sender.Rows
            rw("No_Seq") = i
            i += 1
        Next

    End Sub



    Private Function NomorCSP(ByVal bgtrans As SqlTransaction) As String
        Dim hasil, temp As String
        Dim sqldr As SqlDataReader = New SqlCommand("select max(substring(IsNULL(no_csp,'0001'),1,4))+1 from PURC.DBO.PURC_CHOICE_SUPP", sqlconn, bgtrans).ExecuteReader
        sqldr.Read()
        temp = ""
        If TypeOf sqldr.Item(0) Is DBNull Then
            Dim bln1 As String = Format(Now, "MM")
            Dim th1 As String = Format(Now, "yyyy")
            hasil = "0001" & "/" & "CSP" & "/" & th1 & bln1
        Else
            hasil = sqldr.Item(0)
            For i As Int16 = Len(hasil) To 3
                temp = "0" & temp
            Next
            Dim th, bln As String
            bln = Format(Now, "MM")
            th = Format(Now, "yyyy")
            hasil = temp & (hasil) & "/" & "CSP" & "/" & th & bln
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
        If LEPR.Enabled = False Then
            LEPR.Enabled = True
        End If

        If Not ds7.Tables("VPR") Is Nothing Then ds7.Tables("VPR").Clear()
        ds7.Tables("VPR").Clear()
        da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct PRD.no_pr from PURC.DBO.PURC_PR_D_BARANG PRD " & _
                                                                    "left join PURC.DBO.PURC_PR_D PR on PRD.no_pr=PR.no_pr " & _
                                                                    "left join PURC.dbo.PURC_CHOICE_SUPP CSP on PRD.no_pr=CSP.no_pr and PRD.kd_jasa=CSP.kd_stok and PRD.kd_stok=CSP.kd_substok " & _
                                                                    "where PR.rec_stat='APPROVE' and PR.jns_dpm='JASA' and CSP.no_csp is null", sqlconn))
        da7.Fill(ds7, "VPR")
        LEPR.Properties.DataSource = ds7.Tables("VPR")

        setStatus()

    End Sub


    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction
        Dim data As SqlDataReader

        If Not isDelete Then
            If LEPR.EditValue = "" Then
                showMessages("No PR Belum Diisi")
                LEPR.Focus()
                Exit Sub
            End If

            If LEBarang.EditValue = "" Then
                showMessages("Nama Jasa Belum Dipilih")
                LEBarang.Focus()
                Exit Sub
            End If

            If LEBarangD.EditValue = "" Then
                showMessages("Nama Barang Belum Diisi")
                LEPR.Focus()
                Exit Sub
            End If

            If ds4.Tables("CSD").Rows.Count = 0 Then
                showMessages("Supplier Belum Dipilih !")
                Exit Sub
            End If

            If LESupplier.EditValue = "" Then
                showMessages("Supplier Belum Dipilih")
                Exit Sub
            End If

            If STATE = "ADD" Then

                row = ds3.Tables("CS").NewRow
                'row.Item("no_csp") = NomorCSP(BTRANS)
                'txtNomor.Text = row.Item("no_csp")

                row.Item("Last_Create_Date") = Now
                row.Item("Last_Create_By") = username



            ElseIf STATE = "EDIT" Then
                row = ds3.Tables("CS").Rows(0)
                row.Item("Last_Update_Date") = Now
                row.Item("Last_Updated_By") = username

                

            End If

            row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
            'txtNomor.Text = row.Item("no_csp")
            row.Item("tgl_csp") = dtTanggal.EditValue
            row.Item("no_pr") = LEPR.EditValue
            row.Item("kd_stok") = LEBarang.EditValue
            row.Item("kd_substok") = LEBarangD.EditValue
            row.Item("kd_supp_pilih") = LESupplier.EditValue
            row.Item("keterangan") = txtKet.Text
            row.Item("rec_stat") = "ENTRY" 'IIf(cbStatus.Text = "AKTIF", "Y", "T")
            txtstatus.Text = row.Item("rec_stat")
            row.Item("Program_Name") = Me.Name

            If STATE = "ADD" Then
                ds3.Tables("CS").Rows.Add(row)
            End If

            For Each rows As DataRow In ds4.Tables("CSD").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("no_csp") = row.Item("no_csp")
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
            Buildernya = New SqlClient.SqlCommandBuilder(da3)
            'MsgBox(da3.SelectCommand.CommandText)
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
                row.Item("No_CSP") = getNoTrans("CSP", getTanggal(BTRANS), BTRANS)
                txtNomor.Text = row.Item("No_CSP")

                For Each rows As DataRow In ds4.Tables("CSD").Rows
                    If rows.RowState = DataRowState.Added Then
                        rows.Item("No_CSP") = row.Item("No_CSP")
                    End If
                Next
            End If

            da3.Update(ds3.Tables("CS"))
            da4.Update(ds4.Tables("CSD"))

            ds3.Tables("CS").AcceptChanges()
            ds4.Tables("CSD").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan..")
        Catch e As Exception
            BTRANS.Rollback()
            ds3.Tables("CS").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    Public Sub suppleyer(ByVal nocsp As String) ' ============= cretaed by yaya =============
        dss = New DataSet
        dss1 = New DataSet
        sqlda = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_CHOICE_SUPP where no_csp='" & nocsp & "'", sqlconn))
        sqlda.Fill(dss, "_yaya")
        'MsgBox(dss.Tables(0).Rows(0).Item("kd_supp_pilih").ToString)
        If dss.Tables(0).Rows.Count Then
            txtNomor.Text = dss.Tables(0).Rows(0).Item("no_csp").ToString
            txtstatus.Text = dss.Tables(0).Rows(0).Item("rec_stat").ToString
            dtTanggal.Text = dss.Tables(0).Rows(0).Item("tgl_csp").ToString
            LEPR.EditValue = dss.Tables(0).Rows(0).Item("no_pr").ToString
            LEBarang.EditValue = dss.Tables(0).Rows(0).Item("kd_stok").ToString
            LESupplier.EditValue = dss.Tables(0).Rows(0).Item("kd_supp_pilih").ToString
            txtKet.Text = dss.Tables(0).Rows(0).Item("keterangan").ToString

        End If
        sqlda1 = New SqlDataAdapter(New SqlCommand("select * from PURC.DBO.PURC_CHOICE_SUPP_D where no_csp='" & txtNomor.Text & "'", sqlconn))
        sqlda1.Fill(dss1, "_yaya_d")
        GC.DataSource = dss1.Tables("_yaya_d")


    End Sub

    Private Sub bersih()
        txtNomor.Text = ""
        txtKet.Text = ""
        txtstatus.Text = ""
        txtLastHarga.Text = ""
        txtLastPO.Text = ""
        txtLastSupp.Text = ""
        txtLastTgl.Text = ""
        LEPR.EditValue = vbNullString
        LESupplier.EditValue = vbNullString
        LEBarang.EditValue = vbNullString
        LEBarangD.EditValue = vbNullString

        'btSimpan.Enabled = False
    End Sub
    Private Sub bersih_cari()
        reload_table("XXX")
        txtNomor.Text = ""
        txtKet.Text = ""
        txtstatus.Text = ""
        txtLastHarga.Text = ""
        txtLastPO.Text = ""
        txtLastSupp.Text = ""
        txtLastTgl.Text = ""
        'LEPR.EditValue = vbNullString
        LESupplier.EditValue = vbNullString
        'LEBarang.EditValue = vbNullString
    End Sub
    Private Sub FrmPilihSupplier_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtTanggal.DateTime = Date.Today
        connect()
        If Not ds3.Tables("CS") Is Nothing Then
            ds3.Tables("CS").Clear()
        End If
        If Not ds4.Tables("CSD") Is Nothing Then
            ds4.Tables("CSD").Clear()
        End If
        If Not ds7.Tables("VPR") Is Nothing Then
            ds7.Tables("VPR").Clear()
        End If
        If Not ds6.Tables("KdBAyar") Is Nothing Then
            ds6.Tables("KdBAyar").Clear()
        End If
        If Not ds5.Tables("WKirim") Is Nothing Then
            ds5.Tables("WKirim").Clear()
        End If

        If txtNomor.Text = "" Then 'modif by yaya start here
            da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.DBO.PURC_CHOICE_SUPP where 1=0", sqlconn))
            da3.Fill(ds3, "CS")

            da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as No,'' as Nama_Supplier, '' as Kota1,'' as No_Telepon1,'' as Kontak_Person from PURC.DBO.PURC_CHOICE_SUPP_D where 1=0", sqlconn))
            da4.Fill(ds4, "CSD")
            GC.DataSource = ds4.Tables("CSD")
            LESupplier.Properties.DataSource = ds4.Tables("CSD")

            AddHandler ds4.Tables("CSD").RowDeleted, AddressOf refreshNomer

            da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct no_pr from PURC.DBO.PURC_PR_D where rec_stat='APPROVE' and jns_dpm='JASA'", sqlconn))
            da7.Fill(ds7, "VPR")
            LEPR.Properties.DataSource = ds7.Tables("VPR")
        ElseIf txtNomor.Text <> "" Then
            da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct no_pr from PURC.DBO.PURC_PR_D where rec_stat='APPROVE' and jns_dpm='JASA' ", sqlconn)) 'where status='PR'
            da7.Fill(ds7, "VPR")
            LEPR.Properties.DataSource = ds7.Tables("VPR")
        End If 'end here modif by yaya

        da6 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Id_Data,Desc_Data from sif.dbo.SIF_Gen_Reff_D where id_ref_file='JNSLMBYR'", sqlconn))
        da6.Fill(ds6, "KdBAyar")
        RepKdBayar.DataSource = ds6.Tables("KdBAyar")

        da5 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Id_Data ,Desc_Data from sif.dbo.SIF_Gen_Reff_D where id_ref_file='JNSWKTKRM'", sqlconn))
        da5.Fill(ds5, "WKirim")
        RepKirim.DataSource = ds5.Tables("WKirim")

        da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.Nama_Supplier,a.Kontak_Person,b.nama_kota as Kota1,a.No_Telepon1,a.Kode_Supplier from sif.dbo.SIF_Supplier a inner join sif.dbo.SIF_Kota b on a.Kota1=b.Kode_Kota", sqlconn))
        da2.Fill(dS, "VSUpplier")
        RepSupplier.DataSource = dS.Tables("VSUpplier")

        prn = getParent(Me)

        reload_table("xxx")
    End Sub
    Private Sub reload_table(ByVal kode As String)
        If Not ds3.Tables("CS") Is Nothing Then ds3.Tables("CS").Clear()
        If Not ds4.Tables("CSD") Is Nothing Then ds4.Tables("CSD").Clear()

        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.DBO.PURC_CHOICE_SUPP where No_CSP='" & kode & "'", sqlconn))
        da3.Fill(ds3, "CS")

        da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,(select Nama_Supplier from sif.dbo.sif_supplier where kode_supplier=kd_supplier) as Nama_Supplier, '' as Kota1,'' as No_Telepon1,'' as Kontak_Person from PURC.DBO.PURC_CHOICE_SUPP_D where No_CSP='" & kode & "' order by No_Seq asc", sqlconn))
        da4.Fill(ds4, "CSD")

        LESupplier.Properties.DataSource = ds4.Tables("CSD")
        If ds3.Tables("CS").Rows.Count > 0 Then
            Dim row As DataRow

            row = ds3.Tables("CS").Rows(0)
            txtNomor.Text = row.Item("no_csp").ToString
            LEPR.EditValue = row.Item("no_pr")
            LEBarang.EditValue = row.Item("kd_stok").ToString
            txtKet.Text = row.Item("keterangan").ToString
            dtTanggal.Text = row.Item("tgl_csp")

            LESupplier.EditValue = row.Item("kd_supp_pilih").ToString
            txtstatus.Text = row.Item("rec_stat").ToString

        End If

    End Sub

    Public Sub edit_click()
        JenisLoad = "Edit"
        daedit = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_Csp as [Nomor], tgl_csp as [Tanggal] from PURC.DBO.PURC_CHOICE_SUPP where rec_stat='ENTRY' or rec_stat='REJECT' ", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dsedit.Tables("lookup_CSP") Is Nothing Then dsedit.Tables("lookup_CSP").Clear()
        daedit.Fill(dsedit, "lookup_CSP")
        frmCari.set_dso(dsedit.Tables("lookup_CSP")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            STATE = "EDIT"
            If Not ds7.Tables("VPR") Is Nothing Then ds7.Tables("VPR").Clear()
            da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct no_pr from PURC.DBO.PURC_PR_D where rec_stat='APPROVE'", sqlconn))
            da7.Fill(ds7, "VPR")
            LEPR.Properties.DataSource = ds7.Tables("VPR")
            reload_table(frmCari.row(0))
            LEPR.Enabled = False
            LEBarang.Enabled = False
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
    Private Sub GV_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged

        If e.Column Is KodeSupplier Then
            Dim rw As DataRow
            rw = dS.Tables("VSUpplier").Select("Kode_Supplier='" & e.Value & "'")(0)
            GV.GetRow(e.RowHandle).item("Kontak_Person") = rw("Kontak_Person")
            GV.GetRow(e.RowHandle).item("Nama_Supplier") = rw("Nama_Supplier")
            GV.GetRow(e.RowHandle).item("Kota1") = rw("Kota1")
            GV.GetRow(e.RowHandle).item("No_Telepon1") = rw("No_Telepon1")
            Dim dr As SqlDataReader = New SqlCommand("select TOP 1 POD.* from  PURC.dbo.PURC_PO_D POD " & _
                                                     "LEFT join PURC.dbo.PURC_PO PO on POD.no_po = PO.no_po " & _
                                                     "where PO.kd_supplier='" & e.Value & "' and POD.kd_stok='" & LEBarang.EditValue & "' order by PO.tgl_approve desc", sqlconn).ExecuteReader
            If dr.Read() Then

                GV.GetRow(e.RowHandle).item("Harga_Lama") = dr.Item("harga").ToString
            End If

            dr.Close()
        End If
        'If e.Column Is qty_pr Then
        '    GV.GetRow(e.RowHandle).item("qty_sisa") = GV.GetRow(e.RowHandle).item("qty_order").ToString - GV.GetRow(e.RowHandle).item("qty_pr").ToString
        'End If
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.GetRow(e.RowHandle).item("no_seq") = GV.RowCount + 1
    End Sub

    Private Sub LEPR_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEPR.EditValueChanged
        If STATE = "ADD" Then
            da8 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select DISTINCT BRG.Kode_Barang, BRG.Nama_Barang, BRG.kd_Satuan from PURC.DBO.PURC_PR_D_BARANG PRD " & _
                                                                        "left join SIF.dbo.SIF_Barang BRG on PRD.kd_jasa=BRG.Kode_Barang  " & _
                                                                        "left join PURC.dbo.PURC_CHOICE_SUPP CSP on PRD.no_pr=CSP.no_pr and PRD.kd_jasa=CSP.kd_stok and PRD.kd_stok=CSP.kd_substok " & _
                                                                        "where PRD.no_pr='" & LEPR.EditValue & "' and CSP.no_csp is null", sqlconn))
        ElseIf STATE = "EDIT" Then
            da8 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select 	BRG.Kode_Barang, BRG.Nama_Barang, BRG.kd_Satuan from PURC.DBO.PURC_PR_D PRD " & _
                                                                        "left join SIF.dbo.SIF_Barang BRG on PRD.kd_stok=BRG.Kode_Barang  " & _
                                                                        "where PRD.no_pr='" & LEPR.EditValue & "'", sqlconn))
        End If
        ds8.Clear()
        da8.Fill(ds8, "VStok")
        LEBarang.Properties.DataSource = ds8.Tables("VStok")
        LEBarang.Properties.ValueMember = "Kode_Barang"
        LEBarang.Properties.DisplayMember = "Nama_Barang"

    End Sub

    Private Sub btSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSimpan.Click
        save_click()
    End Sub
    Public Sub cancel_click()
        reload_table("XXX")
        bersih()
        LEPR.Enabled = True
        LEBarang.Enabled = True
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
    End Sub
    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        bersih()
        Me.Close()

    End Sub

    Private Sub refreshNomer(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        Dim j As Int16 = 1
        If State = "DELETE" Then Exit Sub
        For Each rw As DataRow In sender.Rows
            If rw.RowState <> DataRowState.Deleted Then
                For Each rwd As DataRow In ds4.Tables("CSD").Select("NO=" & rw.Item("No_seq"))

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
    Public Sub delete_click()
        If MsgBox("Hapus Data Pemilihan Supplier ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            STATE = "DELETE"
            If Not ds3.Tables("CS") Is Nothing Then delete(ds3.Tables("CS").Rows)
            If Not ds4.Tables("CSD") Is Nothing Then delete(ds4.Tables("CSD").Rows)


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
    Public Sub cetak_click()
        'callReport(App_Path() & "\report\rptDPM_M.rpt", "", "Nomor=0014/DPM/201106")
        callReport(App_Path() & "\report\rptPemilihan_Sup.rpt", "", "Nomor=" & Trim(txtNomor.Text))
    End Sub
    Private Sub GC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GC.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Record Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar Dari Pemilihan Supplier") = MsgBoxResult.Yes Then
                    GV.DeleteSelectedRows()
                End If
            End If
        End If
    End Sub

    Private Sub GV_RowCountChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV.RowCountChanged
        
        'showMessages(GV.GetRowCellValue(GV.FocusedRowHandle, "kd_supplier").ToString)

    End Sub


    Private Sub GV_ValidateRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV.ValidateRow
        Dim isValid As Boolean = True
        If e.Row.item("kd_supplier").ToString = "" Then
            isValid = False
            GV.SetColumnError(KodeSupplier, "Harap Memilih supplier Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("Kd_Wkirim").ToString = "" Then
            isValid = False
            GV.SetColumnError(Kd_Wkirim, "Harap Memilih waktu pengiriman Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        If e.Row.item("Kd_Bayar").ToString = "" Then
            isValid = False
            GV.SetColumnError(KdBayar, "Harap Memilih lama pembayaran Telebih Dahulu.", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
        End If
        e.Valid = isValid
    End Sub

    Sub cek_noPR()

        Dim dr As SqlDataReader = New SqlCommand(" select no_csp from PURC.DBO.PURC_CHOICE_SUPP where  no_pr='" & LEPR.Text & "' and kd_stok='" & LEBarang.EditValue & "' and kd_substok='" & LEBarangD.EditValue & "'", sqlconn).ExecuteReader
        dr.Read()
        If dr.HasRows Then

            reload_table(dr.Item(0))
            STATE = "EDIT"
        Else
            STATE = "ADD"
            bersih_cari()

        End If
        dr.Close()
    End Sub

    Private Sub LEBarang_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEBarang.EditValueChanged
        
        If Not ds7.Tables("VBRGD") Is Nothing Then
            ds7.Tables("VBRGD").Clear()
        End If
        da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select B.Nama_Barang,B.Kode_Barang,C.no_csp from purc.dbo.PURC_PR_D_BARANG P " & _
                                                                    "left join SIF.dbo.SIF_Barang B on P.kd_stok=B.Kode_Barang " & _
                                                                    "left join PURC.dbo.PURC_CHOICE_SUPP C on P.kd_jasa=C.kd_stok and P.kd_stok=C.kd_substok " & _
                                                                    "where P.no_pr='" & LEPR.EditValue & "' and P.kd_jasa='" & LEBarang.EditValue & "' and C.no_csp is null", sqlconn)) 'where status='PR'
        da7.Fill(ds7, "VBRGD")
        LEBarangD.Properties.DataSource = ds7.Tables("VBRGD")

        'Dim dr As SqlDataReader = New SqlCommand("select TOP 1 PO.tgl_approve,PO.no_po,PO.Last_Create_Date,SP.Nama_Supplier,POD.harga from  PURC.dbo.PURC_PO_D POD " & _
        '                                             "LEFT join PURC.dbo.PURC_PO PO on POD.no_po = PO.no_po " & _
        '                                             "left join SIF.dbo.SIF_Supplier SP on PO.kd_supplier=SP.Kode_Supplier " & _
        '                                             "where POD.kd_stok='" & LEBarang.EditValue & "' order by PO.tgl_approve desc", sqlconn).ExecuteReader
        'If dr.Read() Then

        '    txtLastPO.Text = dr.Item("no_po").ToString
        '    txtLastHarga.Text = dr.Item("harga").ToString
        '    txtLastSupp.Text = dr.Item("nama_supplier").ToString
        '    txtLastTgl.Text = dr.Item("tgl_approve").ToString

        'End If

        'dr.Close()
        'JenisLoad = "Filter"
    End Sub

    Private Sub LEBarangD_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LEBarangD.EditValueChanged
        If JenisLoad <> "Edit" Then
            cek_noPR()
        End If
    End Sub
End Class