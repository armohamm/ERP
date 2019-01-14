Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Data

Public Class frmRcn_Krm_Koreksi
    Dim ds1, ds2, ds3 As New DataSet
    Dim da1, da2, da3, da4 As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
       
    End Sub

    Private Sub frmGenDPB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        txtTanggal.EditValue = Now
        reload()
    End Sub

    Private Sub reload()

        If Not ds1.Tables("noTrans") Is Nothing Then ds1.Tables("noTrans").Clear()
        
        da1 = New SqlDataAdapter(New SqlCommand("Select m.no_trans from PROD.dbo.PROD_rcn_krm_m m", sqlconn))
        da1.Fill(ds1, "noTrans")
       

        txtNoTrans.Properties.DisplayMember = "no_trans"
        txtNoTrans.Properties.ValueMember = "no_trans"
        txtNoTrans.Properties.DataSource = ds1.Tables("noTrans")
    End Sub

    Public Sub add_click()
        reload()
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnAdd = False
        State = "ADD"
        setStatus()
    End Sub

    Public Sub edit_click()
        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select P.tanggal Tanggal, P.no_trans, p.no_trans_koreksi from PROD.dbo.PROD_rcn_krm_koreksi_m P " & _
                                                                    "group by P.no_trans_koreksi, P.no_trans, P.tanggal order by P.tanggal desc, P.no_trans desc", sqlconn))

        da3.Fill(ds3, "lookup_so")
        frmCari.set_dso(ds3.Tables("lookup_so"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then

            State = "EDIT"
            txt_notrans_koreksi.Text = frmCari.row("no_trans_koreksi")
            txtTanggal.DateTime = frmCari.row("Tanggal")
            txtTanggal.Properties.ReadOnly = True
            txtNoTrans.EditValue = frmCari.row("no_trans")
            txtNoTrans.Properties.ReadOnly = True

           
            isi_detail()
            btnSave = True
            btnAdd = False
            btnEdit = False
            btnDelete = True
            btnCancel = True
            setStatus()

        Else
            cancel_click()
        End If


    End Sub

    Public Sub save_click()
        Dim dr As SqlDataReader
        Dim qstr As String
        If txtNoTrans.EditValue = "" Then
            showMessages("Pilih No Rencana Kirim terlebih dahulu!")
            Exit Sub
        End If
        Dim tgl As Date = Now
        If State = "ADD" Then

            Dim notrans As String
            Dim BTRANS As SqlTransaction
            mb = New SqlClient.SqlCommandBuilder(da1)
            da1.UpdateCommand = mb.GetUpdateCommand()
            da1.InsertCommand = mb.GetInsertCommand()
            da1.DeleteCommand = mb.GetDeleteCommand()

            mb = New SqlClient.SqlCommandBuilder(da2)
            da2.UpdateCommand = mb.GetUpdateCommand()
            da2.InsertCommand = mb.GetInsertCommand()
            da2.DeleteCommand = mb.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            da1.UpdateCommand.Transaction = BTRANS
            da1.InsertCommand.Transaction = BTRANS
            da1.DeleteCommand.Transaction = BTRANS

            da2.UpdateCommand.Transaction = BTRANS
            da2.InsertCommand.Transaction = BTRANS
            da2.DeleteCommand.Transaction = BTRANS
            notrans = getNoTrans("KRM_KOR", tgl, BTRANS)

            Dim row As DataRow = ds1.Tables("Rcn_Krm_M").Rows(0)
            txt_notrans_koreksi.Text = notrans
            row("tanggal") = tgl
            row("no_trans_koreksi") = txt_notrans_koreksi.Text
            row("last_create_date") = tgl
            row("last_created_by") = username
            row("program_name") = Me.Name

            For i = ds1.Tables("Rcn_Krm_D").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = ds1.Tables("Rcn_Krm_D").Rows(i)
                If Not TypeOf rows("jumlah_koreksi") Is DBNull Then
                    If rows("jumlah_koreksi") > 0 Then
                        rows("no_trans_koreksi") = txt_notrans_koreksi.Text
                        rows("tanggal") = txtTanggal.EditValue
                        rows("last_create_date") = tgl
                        rows("last_created_by") = username
                        rows("program_name") = Me.Name
                        rows("kd_cabang") = kdcabang
                        rows("kd_departemen") = kddep
                        rows("state_edited") = "0"
                    Else
                        ds1.Tables("Rcn_Krm_D").Rows(i).Delete()
                    End If
                Else
                    ds1.Tables("Rcn_Krm_D").Rows(i).Delete()
                End If
            Next




            Try

                da1.Update(ds1.Tables("Rcn_Krm_M"))
                da2.Update(ds1.Tables("Rcn_Krm_D"))
                ds1.Tables("Rcn_Krm_M").AcceptChanges()
                ds1.Tables("Rcn_Krm_D").AcceptChanges()
                BTRANS.Commit()
                txtNoTrans.Text = notrans
                showMessages("Data Koreksi rencana kirim Berhasil Disimpan")
                btnSave = False
                setStatus()
            Catch ex As Exception
                BTRANS.Rollback()
                ds1.Tables("MASTER").RejectChanges()
                ds1.Tables("KIRIM").RejectChanges()
                MsgBox(ex.Message)
            End Try



        ElseIf State = "EDIT" Then
            Dim notrans As String
            Dim BTRANS As SqlTransaction
            mb = New SqlClient.SqlCommandBuilder(da1)
            da1.UpdateCommand = mb.GetUpdateCommand()
            da1.InsertCommand = mb.GetInsertCommand()
            da1.DeleteCommand = mb.GetDeleteCommand()

            mb = New SqlClient.SqlCommandBuilder(da2)
            da2.UpdateCommand = mb.GetUpdateCommand()
            da2.InsertCommand = mb.GetInsertCommand()
            da2.DeleteCommand = mb.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            da1.UpdateCommand.Transaction = BTRANS
            da1.InsertCommand.Transaction = BTRANS
            da1.DeleteCommand.Transaction = BTRANS

            da2.UpdateCommand.Transaction = BTRANS
            da2.InsertCommand.Transaction = BTRANS
            da2.DeleteCommand.Transaction = BTRANS

            qstr = "delete from PROD.dbo.PROD_rcn_krm_koreksi_d where no_trans_koreksi='" & txt_notrans_koreksi.Text & "'"
            dr = New SqlClient.SqlCommand(qstr, sqlconn, BTRANS).ExecuteReader
            dr.Close()
            qstr = "delete from PROD.dbo.PROD_rcn_krm_koreksi_m where no_trans_koreksi='" & txt_notrans_koreksi.Text & "'"
            dr = New SqlClient.SqlCommand(qstr, sqlconn, BTRANS).ExecuteReader
            dr.Close()

            Dim row As DataRow = ds1.Tables("Rcn_Krm_M").Rows(0)
            'row("tanggal") = tgl
            row("no_trans_koreksi") = txt_notrans_koreksi.Text
            row("last_update_date") = tgl
            row("last_updated_by") = username
            row("program_name") = Me.Name

            For i = ds1.Tables("Rcn_Krm_D").Rows.Count - 1 To 0 Step -1
                Dim rows As DataRow = ds1.Tables("Rcn_Krm_D").Rows(i)
                If Not TypeOf rows("jumlah_koreksi") Is DBNull Then
                    If rows("jumlah_koreksi") > 0 Then
                        rows("no_trans_koreksi") = txt_notrans_koreksi.Text
                        rows("last_update_date") = tgl
                        rows("last_updated_by") = username
                        rows("program_name") = Me.Name
                        rows("kd_cabang") = kdcabang
                        rows("kd_departemen") = kddep
                        rows("state_edited") = "0"
                    Else
                        ds1.Tables("Rcn_Krm_D").Rows(i).Delete()
                    End If
                Else
                    ds1.Tables("Rcn_Krm_D").Rows(i).Delete()
                End If
            Next


            Try
                da1.Update(ds1.Tables("Rcn_Krm_M"))
                da2.Update(ds1.Tables("Rcn_Krm_D"))
                ds1.Tables("Rcn_Krm_M").AcceptChanges()
                ds1.Tables("Rcn_Krm_D").AcceptChanges()
                BTRANS.Commit()
                showMessages("Data Koreksi rencana kirim Berhasil Diedit")
                btnSave = False
                setStatus()
            Catch ex As Exception
                BTRANS.Rollback()
                ds1.Tables("MASTER").RejectChanges()
                ds1.Tables("KIRIM").RejectChanges()
                MsgBox(ex.Message)
            End Try

        End If

    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            showMessages("Deleted..")
            'cancel_click()
        End If
    End Sub

    Public Sub cancel_click()
        If Not ds1.Tables("Rcn_Krm_D") Is Nothing Then ds1.Tables("Rcn_Krm_D").Clear()
        GC.DataSource = ds1.Tables("Rcn_Krm_D")
        txtKendaraan.EditValue = ""
        txtSopir.EditValue = ""
        txtKernet.EditValue = ""
        txt_notrans_koreksi.Text = Nothing
       
        txtNoTrans.EditValue = Nothing
        txtNoTrans.Properties.ReadOnly = False
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
    End Sub

    Private Sub GV_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        If e.Column.ToString = "Jumlah Koreksi" Then
            If GV.GetRow(e.RowHandle).Item("jumlah_koreksi") > GV.GetRow(e.RowHandle).Item("jumlah") Then
                GV.SetColumnError(col_koreksi, "Jumlah Koreksi melebihi Jumlah Rencana Kirim", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                MessageBox.Show("Jumlah Koreksi melebihi Jumlah Rencana Kirim")
                GV.GetRow(e.RowHandle).Item("jumlah_koreksi") = 0
            Else

            End If
        End If
    End Sub

    Private Sub GV_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub
    Sub isi_detail()
        Dim dr, dr2 As SqlDataReader
        If State = "ADD" Then

        ElseIf State = "EDIT" Then
            If Not ds1.Tables("Rcn_Krm_D") Is Nothing Then ds1.Tables("Rcn_Krm_D").Clear()
            If Not ds1.Tables("Rcn_Krm_M") Is Nothing Then ds1.Tables("Rcn_Krm_M").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("Select m.* From PROD.dbo.PROD_rcn_krm_koreksi_m m where 1= 0", sqlconn))
            da1.Fill(ds1, "Rcn_Krm_M")
            dr = New SqlClient.SqlCommand("select m.*,k.Nama_Kendaraan,s.Nama_Sopir, " & _
                                                    "s1.Nama_Sopir as Nama_Kenek from PROD.dbo.PROD_rcn_krm_koreksi_m m " & _
                                                    "left join SIF.dbo.SIF_Kendaraan k " & _
                                                    "on m.kd_kendaraan = k.Kode_Kendaraan " & _
                                                    "left join SIF.dbo.SIF_Sopir s " & _
                                                    "on m.kd_sopir = s.Kode_Sopir " & _
                                                    "left join SIF.dbo.SIF_Sopir s1 " & _
                                                    "on m.kd_kenek = s1.Kode_Sopir " & _
                                                    "WHERE m.no_trans_koreksi='" & txt_notrans_koreksi.Text & "'", sqlconn).ExecuteReader
            While dr.Read
                txt_kdKendaraan.Text = dr.Item("Nama_Kendaraan")
                txt_KdSopir.Text = dr.Item("Nama_Sopir")
                txt_KdKernet.Text = dr.Item("Nama_Kenek")
                Dim rwm As DataRow = ds1.Tables("Rcn_Krm_M").NewRow
                rwm("no_trans") = dr.Item("no_trans")
                rwm("no_trans_koreksi") = dr.Item("no_trans_koreksi")
                rwm("tipe_trans") = dr.Item("tipe_trans")
                rwm("kd_kendaraan") = dr.Item("kd_kendaraan")
                rwm("kd_sopir") = dr.Item("kd_sopir")
                rwm("kd_kenek") = dr.Item("kd_kenek")
                rwm("jml_kapasitas") = dr.Item("jml_kapasitas")
                rwm("tanggal") = dr.Item("tanggal")
                rwm("kd_cabang") = kdcabang
                rwm("kd_departemen") = kddep
                rwm("last_create_date") = dr.Item("last_create_date")
                rwm("last_created_by") = dr.Item("last_created_by")
                ds1.Tables("Rcn_Krm_M").Rows.Add(rwm)
            End While
            dr.Close()

            If Not ds1.Tables("Rcn_Krm_D") Is Nothing Then ds1.Tables("Rcn_Krm_D").Clear()
            da2 = New SqlDataAdapter(New SqlCommand("Select d.*,'' Nama_Customer,'' Nama_Barang,'' Tgl_Kirim, '' Kd_Satuan,0.00 jumlah_koreksi2,0.00 jumlah_koreksi_maks From PROD.dbo.PROD_rcn_krm_koreksi_d d where 1=0", sqlconn))
            da2.Fill(ds1, "Rcn_Krm_D")

           
            dr2 = New SqlClient.SqlCommand("Select dt.*,v.Nama_Customer,v.Nama_Barang,v.Tgl_Kirim ,v.tgl_kirim_SO,v.Kd_Satuan, " & _
                                           "ISNULL(a.jumlah_koreksi2,0) jumlah_koreksi2 , " & _
                                           "(dt.jumlah - ISNULL(a.jumlah_koreksi2,0)) as jumlah_koreksi_maks " & _
                                           "From PROD.dbo.PROD_rcn_krm_koreksi_d dt " & _
                                           "left join PROD.dbo.PRODV_MON_SO v " & _
                                           "on dt.no_sp = v.No_sp and dt.no_sp_dtl = v.no_seq_d and dt.no_seq = v.No_sp_box " & _
                                           "left join (Select d.no_trans,d.no_sp,d.no_sp_dtl,d.no_seq, " & _
                                           "SUM(d.jumlah_koreksi) jumlah_koreksi2 " & _
                                           "From PROD.dbo.PROD_rcn_krm_koreksi_d d " & _
                                           "where d.no_trans_koreksi <> '" & txt_notrans_koreksi.Text & "' " & _
                                           "Group BY " & _
                                           "d.no_trans, d.no_sp,d.no_sp_dtl,d.no_seq) a " & _
                                           "on a.no_trans = dt.no_trans and a.no_sp =dt.no_sp " & _
                                           "and a.no_sp_dtl = dt.no_sp_dtl and a.no_seq = dt.no_seq " & _
                                           "where dt.no_trans_koreksi ='" & txt_notrans_koreksi.Text & "'", sqlconn).ExecuteReader

            While dr2.Read
                Dim rw As DataRow = ds1.Tables("Rcn_Krm_D").NewRow
                rw("kd_cabang") = dr2.Item("kd_cabang")
                rw("tanggal") = dr2.Item("tanggal")
                rw("no_trans") = dr2.Item("no_trans")
                rw("No_sp") = dr2.Item("No_sp")
                rw("no_sp_dtl") = dr2.Item("no_sp_dtl")
                rw("no_seq") = dr2.Item("no_seq")
                rw("kd_barang") = dr2.Item("kd_barang")
                rw("jumlah") = dr2.Item("jumlah")
                rw("jml_indeks") = dr2.Item("jml_indeks")
                rw("jml_m3") = dr2.Item("jml_m3")
                rw("rec_stat") = dr2.Item("rec_stat")
                rw("tinggi") = dr2.Item("tinggi")
                rw("lebar") = dr2.Item("lebar")
                rw("panjang") = dr2.Item("panjang")
                rw("program_name") = Me.Name
                rw("Kd_Satuan") = dr2.Item("Kd_Satuan")
                rw("Nama_Customer") = dr2.Item("Nama_Customer")
                rw("Nama_Barang") = dr2.Item("Nama_Barang")
                rw("jumlah_koreksi") = dr2.Item("jumlah_koreksi")
                rw("Tgl_Kirim") = IIf(dr2.Item("tgl_kirim_SO") Is DBNull.Value, dr2.Item("Tgl_Kirim"), dr2.Item("tgl_kirim_SO"))
                rw("no_dpb") = dr2.Item("no_dpb")
                rw("state_edited") = dr2.Item("state_edited")
                rw("jumlah_koreksi2") = dr2.Item("jumlah_koreksi2")
                rw("jumlah_koreksi_maks") = dr2.Item("jumlah_koreksi_maks")
                rw("last_create_date") = dr2.Item("last_create_date")
                rw("last_created_by") = dr2.Item("last_created_by")
                ds1.Tables("Rcn_Krm_D").Rows.Add(rw)
            End While
            dr2.Close()

            GC.DataSource = ds1.Tables("Rcn_Krm_D")
        End If
    End Sub
    Private Sub txtNoTrans_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoTrans.EditValueChanged
        Dim dr, dr2 As SqlDataReader
        If State = "ADD" Then
            If Not ds1.Tables("Rcn_Krm_D") Is Nothing Then ds1.Tables("Rcn_Krm_D").Clear()
            If Not ds1.Tables("Rcn_Krm_M") Is Nothing Then ds1.Tables("Rcn_Krm_M").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("Select m.* From PROD.dbo.PROD_rcn_krm_koreksi_m m where 1= 0", sqlconn))
            da1.Fill(ds1, "Rcn_Krm_M")
            dr = New SqlClient.SqlCommand("select m.*,k.Nama_Kendaraan,s.Nama_Sopir, " & _
                                                    "s1.Nama_Sopir as Nama_Kenek from PROD.dbo.PROD_rcn_krm_m m " & _
                                                    "left join SIF.dbo.SIF_Kendaraan k " & _
                                                    "on m.kd_kendaraan = k.Kode_Kendaraan " & _
                                                    "left join SIF.dbo.SIF_Sopir s " & _
                                                    "on m.kd_sopir = s.Kode_Sopir " & _
                                                    "left join SIF.dbo.SIF_Sopir s1 " & _
                                                    "on m.kd_kenek = s1.Kode_Sopir " & _
                                                    "WHERE m.no_trans='" & txtNoTrans.EditValue & "'", sqlconn).ExecuteReader
            While dr.Read
                txt_kdKendaraan.Text = dr.Item("Nama_Kendaraan")
                txt_KdSopir.Text = dr.Item("Nama_Sopir")
                txt_KdKernet.Text = dr.Item("Nama_Kenek")
                Dim rwm As DataRow = ds1.Tables("Rcn_Krm_M").NewRow
                rwm("no_trans") = dr.Item("no_trans")
                rwm("no_trans_koreksi") = ""
                rwm("tipe_trans") = dr.Item("tipe_trans")
                rwm("kd_kendaraan") = dr.Item("kd_kendaraan")
                rwm("kd_sopir") = dr.Item("kd_sopir")
                rwm("kd_kenek") = dr.Item("kd_kenek")
                rwm("jml_kapasitas") = dr.Item("jml_kapasitas")
                rwm("tanggal") = txtTanggal.EditValue
                rwm("kd_cabang") = kdcabang
                rwm("kd_departemen") = kddep
                ds1.Tables("Rcn_Krm_M").Rows.Add(rwm)
            End While
            dr.Close()

            If Not ds1.Tables("Rcn_Krm_D") Is Nothing Then ds1.Tables("Rcn_Krm_D").Clear()
            da2 = New SqlDataAdapter(New SqlCommand("Select d.*,'' Nama_Customer,'' Nama_Barang,'' Tgl_Kirim, '' Kd_Satuan,0.00 jumlah_koreksi2,0.00 jumlah_koreksi_maks From PROD.dbo.PROD_rcn_krm_koreksi_d d where 1=0", sqlconn))
            da2.Fill(ds1, "Rcn_Krm_D")

            'dr2 = New SqlClient.SqlCommand("Select d.*,v.Nama_Customer,v.Nama_Barang,v.Tgl_Kirim,v.tgl_kirim_SO,v.Kd_Satuan From PROD.dbo.PROD_rcn_krm_d d " & _
            '                               "left join PROD.dbo.PRODV_MON_SO v " & _
            '                               "on d.no_sp = v.No_sp and d.no_sp_dtl = v.no_seq_d and d.no_seq = v.No_sp_box " & _
            '                               "where d.no_trans ='" & txtNoTrans.EditValue & "'", sqlconn).ExecuteReader
            dr2 = New SqlClient.SqlCommand("Select dt.*,v.Nama_Customer,v.Nama_Barang,v.Tgl_Kirim ,v.tgl_kirim_SO,v.Kd_Satuan, " & _
                                           "ISNULL(a.jumlah_koreksi2,0) jumlah_koreksi2 , " & _
                                           "(dt.jumlah - ISNULL(a.jumlah_koreksi2,0)) as jumlah_koreksi_maks " & _
                                           "From PROD.dbo.PROD_rcn_krm_d dt " & _
                                           "left join PROD.dbo.PRODV_MON_SO v " & _
                                           "on dt.no_sp = v.No_sp and dt.no_sp_dtl = v.no_seq_d and dt.no_seq = v.No_sp_box " & _
                                           "left join (Select d.no_trans,d.no_sp,d.no_sp_dtl,d.no_seq, " & _
                                           "SUM(d.jumlah_koreksi) jumlah_koreksi2 " & _
                                           "From PROD.dbo.PROD_rcn_krm_koreksi_d d " & _
                                           "Group BY " & _
                                           "d.no_trans, d.no_sp,d.no_sp_dtl,d.no_seq) a " & _
                                           "on a.no_trans = dt.no_trans and a.no_sp =dt.no_sp " & _
                                           "and a.no_sp_dtl = dt.no_sp_dtl and a.no_seq = dt.no_seq " & _
                                           "where dt.no_trans ='" & txtNoTrans.EditValue & "'", sqlconn).ExecuteReader

            While dr2.Read
                Dim rw As DataRow = ds1.Tables("Rcn_Krm_D").NewRow
                rw("kd_cabang") = dr2.Item("kd_cabang")
                rw("tanggal") = dr2.Item("tanggal")
                rw("no_trans") = dr2.Item("no_trans")
                rw("No_sp") = dr2.Item("No_sp")
                rw("no_sp_dtl") = dr2.Item("no_sp_dtl")
                rw("no_seq") = dr2.Item("no_seq")
                rw("kd_barang") = dr2.Item("kd_barang")
                rw("jumlah") = dr2.Item("jumlah")
                rw("jml_indeks") = dr2.Item("jml_indeks")
                rw("jml_m3") = dr2.Item("jml_m3")
                rw("rec_stat") = dr2.Item("rec_stat")
                rw("tinggi") = dr2.Item("tinggi")
                rw("lebar") = dr2.Item("lebar")
                rw("panjang") = dr2.Item("panjang")
                rw("program_name") = Me.Name
                rw("Kd_Satuan") = dr2.Item("Kd_Satuan")
                rw("Nama_Customer") = dr2.Item("Nama_Customer")
                rw("Nama_Barang") = dr2.Item("Nama_Barang")
                rw("jumlah_koreksi") = 0
                rw("Tgl_Kirim") = IIf(dr2.Item("tgl_kirim_SO") Is DBNull.Value, dr2.Item("Tgl_Kirim"), dr2.Item("tgl_kirim_SO"))
                rw("no_dpb") = dr2.Item("no_dpb")
                rw("state_edited") = dr2.Item("state_edited")
                rw("jumlah_koreksi2") = dr2.Item("jumlah_koreksi2")
                rw("jumlah_koreksi_maks") = dr2.Item("jumlah_koreksi_maks")
                ds1.Tables("Rcn_Krm_D").Rows.Add(rw)
            End While
            dr2.Close()

            GC.DataSource = ds1.Tables("Rcn_Krm_D")

        ElseIf State = "EDIT" Then
           
        End If


    End Sub


    Public Sub cetak_click()
        
    End Sub


    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        cetak_click()
    End Sub

    

    Private Sub txtKendaraan_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKendaraan.EditValueChanged
        txt_kdKendaraan.Text = txtKendaraan.Text
    End Sub

    Private Sub txtKernet_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtKernet.EditValueChanged
        txt_KdKernet.Text = txtKernet.Text
    End Sub

    Private Sub txtSopir_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSopir.EditValueChanged
        txt_KdSopir.Text = txtSopir.Text
    End Sub

    
End Class