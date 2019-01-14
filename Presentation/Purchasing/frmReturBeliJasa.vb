Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient
Public Class frmReturBeliJasa
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain   '<-- untuk mengakses frmMain
    Public obj As Object
    Dim dSO As New DataSet
    Dim ds, dsedit, ds1, ds2, ds3, ds4, ds5, ds6, ds7, dss, dss1 As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Dim DA, daedit, da2, da3, da4, da5, da6, da7, sqlda, sqlda1 As SqlClient.SqlDataAdapter
    Dim Buildernya As New SqlClient.SqlCommandBuilder

    Public Sub setStatus()
        With prn
            btnadd = .btnAdd.Enabled
            btnCancel = .btnCancel.Enabled
            btnDelete = .btnDelete.Enabled
            btnEdit = .btnEdit.Enabled
            btnSave = .btnSave.Enabled
        End With

    End Sub
    Private Sub V_Supplier()
        da5 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Supplier,Nama_Supplier from sif.dbo.SIF_Supplier", sqlconn))
        da5.Fill(ds5, "View_Supplier")
        LESupllier.Properties.DataSource = ds5.Tables("View_Supplier")
    End Sub
    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder
        With prn '<- untuk sementara dimatika klau sudah digabung dengan form main ini dinyalakan lagi
            .btnAdd.Enabled = False ' mendisable tombol add yang ada di frmUtama
            .btnCancel.Enabled = True
            .btnDelete.Enabled = False
            .btnEdit.Enabled = False
            .btnSave.Enabled = True

        End With
        setStatus()
        STATE = "ADD" '<-- set state add

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

    Sub View_RTR_D()
        da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select no_po from PURC.DBO.PURC_PO where tipe_trans='JPP-KUT-02'", sqlconn))
        da7.Fill(ds7, "View_RTR_D")
        LEPO.Properties.DataSource = ds7.Tables("View_RTR_D")
    End Sub

    Private Sub NO(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        For Each rw As DataRow In sender.Rows
            rw("no_seq") = i
            i += 1
        Next
    End Sub




    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction



        If Not isDelete Then
            If LEPO.EditValue = "" Then
                showMessages("No PO Belum Diisi")
                LEPO.Focus()
                Exit Sub
            End If


            If STATE = "ADD" Then

                row = ds3.Tables("RTR").NewRow
                row.Item("Last_Create_Date") = Now
            ElseIf STATE = "EDIT" Then
                row = ds3.Tables("RTR").Rows(0)
                row.Item("Last_Update_Date") = Now
                row.Item("Last_Updated_By") = username
            End If
            row.Item("status") = IIf(CheckBox1.Checked = False, "N", "Y")
            row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener
            row.Item("tanggal") = dtTanggal.EditValue
            row.Item("no_po") = LEPO.EditValue
            row.Item("no_ref") = txtNoRef.Text
            row.Item("kd_supplier") = LESupllier.EditValue
            row.Item("keterangan") = txtKeterangan.Text
            row.Item("jml_rp_trans") = txtJmlTotal.EditValue
            row.Item("rec_stat") = "ENTRY"
            txtstatus.Text = row.Item("rec_stat")
            row.Item("Program_Name") = Me.Name

            If STATE = "ADD" Then
                ds3.Tables("RTR").Rows.Add(row)
            End If
            For Each rows As DataRow In ds4.Tables("RTRD").Rows
                If rows.RowState = DataRowState.Added Then
                    'rows.Item("no_po") = row.Item("no_po")
                    rows.Item("Last_Create_Date") = Now
                    rows.Item("Last_Created_By") = username
                    rows.Item("rec_stat") = "ENTRY"
                    rows.Item("kd_Cabang") = kdcabang
                    rows.Item("qty_sisa") = rows.Item("qty")
                    'rows.Item("tipe_trans") = "JPP-KUT-01"
                Else
                    rows.Item("Kd_Cabang") = kdcabang
                    rows.Item("Last_Update_Date") = Now
                    rows.Item("Last_Updated_By") = username
                End If
                rows.Item("Program_name") = Me.Name

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

                row.Item("No_retur") = getNoTrans("RTR-J", getTanggal(BTRANS), BTRANS)

                txtNoRetur.Text = row.Item("No_retur")
                For Each rows As DataRow In ds4.Tables("RTRD").Rows
                    If rows.RowState = DataRowState.Added Then
                        rows.Item("No_retur") = row.Item("No_retur")
                        'rows.Item("tipe_trans") = "JPP-KUT-01"
                    Else
                        rows.Item("Kd_Cabang") = kdcabang
                        rows.Item("Last_Update_Date") = Now
                        rows.Item("Last_Updated_By") = username
                    End If
                Next
            End If
            If STATE = "EDIT" Then
                'call_procedure(txtNoRetur.EditValue, BTRANS)
            End If

            da3.Update(ds3.Tables("RTR"))
            da4.Update(ds4.Tables("RTRD"))

            ds3.Tables("RTR").AcceptChanges()
            ds4.Tables("RTRD").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan..")
        Catch e As Exception
            BTRANS.Rollback()
            ds3.Tables("RTR").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try

       
    End Sub
    Public Sub edit_click()
        dSO = New DataSet
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_RETUR_BELI where no_retur like '%RTR-J%'", sqlconn)) '<- query buat ditampilkan di LOV
        DA.Fill(dSO, "LOOKUP_SIF_Customer")
        frmCari.set_dso(dSO.Tables(0))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_RETUR_BELI where no_retur='" & frmCari.row("no_retur") & "'", sqlconn))
            da3.Fill(ds3, "RTR")

            STATE = "EDIT"
            If ds3.Tables(0).Rows.Count > 0 Then
                txtNoRetur.Text = ds3.Tables(0).Rows(0).Item("no_retur").ToString
                LEPO.EditValue = ds3.Tables(0).Rows(0).Item("no_po").ToString
                LESupllier.EditValue = ds3.Tables(0).Rows(0).Item("kd_supplier").ToString
                dtTanggal.EditValue = ds3.Tables(0).Rows(0).Item("tanggal").ToString
                txtNoRef.EditValue = ds3.Tables(0).Rows(0).Item("no_ref").ToString
                txtKeterangan.Text = ds3.Tables(0).Rows(0).Item("keterangan").ToString
                txtstatus.Text = ds3.Tables(0).Rows(0).Item("rec_stat").ToString
                txtJmlTotal.EditValue = ds3.Tables(0).Rows(0).Item("jml_rp_trans").ToString
                IIf(ds3.Tables(0).Rows(0).Item("status").ToString = "Y", CheckBox1.Checked = True, CheckBox1.Checked = False)
                dtTanggal.Text = ds3.Tables(0).Rows(0).Item("tanggal").ToString
            End If
            controlOff(True)
            da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' As No,'' as no_po , '' as kd_satuan ,qty*harga as total from PURC.dbo.PURC_RETUR_BELI_D  where no_retur= '" & frmCari.row("no_retur") & "'", sqlconn))
            da4.Fill(ds4, "RTRD")
            GC.DataSource = ds4.Tables("RTRD")
        Else
            cancel_click()
            controlOff(False)
        End If
        With prn '<- untuk sementara dimatika klau sudah digabung dengan form main ini dinyalakan lagi
            .btnAdd.Enabled = False ' mendisable tombol add yang ada di frmUtama
            .btnCancel.Enabled = True
            .btnDelete.Enabled = True
            .btnEdit.Enabled = False
            .btnSave.Enabled = True

        End With
        setStatus()
    End Sub
    Private Sub controlOff(ByVal stat As Boolean)
        LEPO.Properties.ReadOnly = stat

        LESupllier.Properties.ReadOnly = stat
        dtTanggal.Properties.ReadOnly = stat
        txtNoRef.Properties.ReadOnly = stat
        txtKeterangan.ReadOnly = stat
        txtstatus.Properties.ReadOnly = stat
        'GV.OptionsBehavior.ReadOnly = stat
        GV.Columns("kd_stok").OptionsColumn.ReadOnly = stat
        GV.Columns("harga").OptionsColumn.ReadOnly = IIf(stat = True, False, True)
        GV.Columns("keterangan").OptionsColumn.ReadOnly = stat
        GV.Columns("qty").OptionsColumn.ReadOnly = stat
    End Sub

    Private Sub GV_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        If e.Column Is kd_stok Then
            Dim rw As DataRow
            rw = ds.Tables("VBARANG").Select("Kode_Barang='" & e.Value & "'")(0)
            GV.GetRow(e.RowHandle).item("satuan") = rw("Kd_Satuan")
        End If
        If e.Column Is QTY Then
            GV.GetRow(e.RowHandle).item("total") = GV.GetRow(e.RowHandle).item("harga").ToString * GV.GetRow(e.RowHandle).item("qty").ToString
        End If
    End Sub

    Public Sub cetak_click()

        'callReport(App_Path() & "\report\rptDPM_M.rpt", "", "Nomor=0014/DPM/201106")
        callReport(App_Path() & "\report\rptRTRJ.rpt", "", "Nomor=" & Trim(txtNoRetur.Text))

    End Sub
    Private Sub reload_table(ByVal kode As String)
        If Not ds3.Tables("RTR") Is Nothing Then ds3.Tables("RTR").Clear()
        If Not ds4.Tables("RTRD") Is Nothing Then ds4.Tables("RTRD").Clear()


        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_RETUR_BELI where no_retur='" & kode & "'", sqlconn))
        da3.Fill(ds3, "RTR")

        da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select *,'' as No,'' as no_po , '' as Nama_Barang , '' as kd_satuan ,qty*harga as total from PURC.dbo.PURC_RETUR_BELI_D where no_retur= '" & kode & "'", sqlconn))
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
            dtTanggal.Text = row.Item("tgl_po")
            LESupllier.EditValue = row.Item("kd_supplier").ToString
            txtstatus.Text = row.Item("status").ToString
            txtJmlTotal.Text = row.Item("qty").ToString
            IIf(row.Item("status").ToString = "Y", CheckBox1.Checked = True, CheckBox1.Checked = False)
        End If


    End Sub
    Private Sub refreshNomer(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        Dim j As Int16 = 1
        If State = "DELETE" Then Exit Sub
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
    Private Sub frmPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtTanggal.Text = Date.Today
        'dtKirim.Text = Date.Today

        STATE = "ADD"
        connect()
        prn = getParent(Me)

        View_RTR_D()
        V_Supplier()
        dtTanggal.Text = Date.Today
        'yayak()
        If txtNoRetur.Text = "" Then
            reload_table("xxx")
            GC.DataSource = ds4.Tables("RTRD")
        End If

    End Sub

    'Private Sub yayak()
    '    thisThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
    '    GV.Columns("Harga").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    '    GV.Columns("Harga").DisplayFormat.FormatString = "n3"
    '    GV.Columns("QTY").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    '    GV.Columns("QTY").DisplayFormat.FormatString = "n2"
    '    GV.Columns("Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
    '    GV.Columns("Total").DisplayFormat.FormatString = "n2"

    'End Sub
    Public Sub cariPO(ByVal nocsp As String) ' ============= cretaed by yaya =============
        dss = New DataSet
        dss1 = New DataSet
        sqlda = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_RETUR_BELI where no_retur='" & nocsp & "'", sqlconn))
        sqlda.Fill(dss, "_yaya")
        'MsgBox(dss.Tables(0).Rows(0).Item("no_po").ToString)
        If dss.Tables(0).Rows.Count Then
            txtNoRetur.Text = dss.Tables(0).Rows(0).Item("no_retur").ToString
            txtstatus.Text = dss.Tables(0).Rows(0).Item("status").ToString
            dtTanggal.Text = dss.Tables(0).Rows(0).Item("tgl_po").ToString
            LEPO.EditValue = dss.Tables(0).Rows(0).Item("no_po").ToString
            LESupllier.EditValue = dss.Tables(0).Rows(0).Item("kd_supplier").ToString
            txtKeterangan.Text = dss.Tables(0).Rows(0).Item("keterangan").ToString

        End If
        sqlda1 = New SqlDataAdapter(New SqlCommand("select * from PURC.DBO.PURC_RETUR_BLEI_D where no_po='" & txtNoRetur.Text & "'", sqlconn))
        sqlda1.Fill(dss1, "_yaya_d")
        GC.DataSource = dss1.Tables("_yaya_d")

    End Sub


    Private Sub GV_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.GetRow(e.RowHandle).item("no_seq") = GV.RowCount + 1
    End Sub


    Private Sub btSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSimpan.Click
        save_click()
    End Sub

    Function getTotal() As Double
        Dim ttl As Double

        For Each rw As DataRow In ds4.Tables("RTRD").Rows
            If TypeOf rw.Item("qty") Is DBNull Or rw.Item("qty") = 0 Then
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
    End Sub

    Private Sub LESupllier_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LESupllier.EditValueChanged
        If LESupllier.Text = "" Then
            If Not ds4.Tables("POD") Is Nothing Then ds4.Tables("POD").Clear()
            Exit Sub
        End If
        If txtNoRetur.Text = "" Then
            ds4.Tables("RTRD").Clear()
            Dim dr As SqlDataReader = New SqlCommand(" select *,'' as Nama_Barang  from PURC.dbo.vBarangPOTerpilih  where kd_supplier='" & LESupllier.EditValue & "' and no_po='" & LEPO.EditValue & "' ", sqlconn).ExecuteReader
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
                txtJmlTotal.EditValue = dr.Item("qty_total")
                i += 1
                ds4.Tables("RTRD").Rows.Add(rw)
            End While
            dr.Close()
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
    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub
    Private Sub bersih()
        LEPO.EditValue = vbNullString
        LESupllier.EditValue = vbNullString
        txtNoRetur.EditValue = vbNullString
        txtNoRef.EditValue = vbNullString
        txtKeterangan.Text = ""
        txtstatus.EditValue = vbNullString
        txtJmlTotal.EditValue = vbNullString
    End Sub
    Public Sub cancel_click()
        reload_table("XXX")
        bersih()
        With prn '<- untuk sementara dimatika klau sudah digabung dengan form main ini dinyalakan lagi
            .btnAdd.Enabled = True ' mendisable tombol add yang ada di frmUtama
            .btnCancel.Enabled = False
            .btnDelete.Enabled = False
            .btnEdit.Enabled = True
            .btnSave.Enabled = False

        End With
        setStatus()
    End Sub

    Private Sub GC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GC.KeyDown
        'If e.KeyCode = Keys.Delete Then
        '    If GV.GetSelectedRows.Count > 0 Then
        '        If MsgBox("Hapus Record Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar DPM") = MsgBoxResult.Yes Then
        '            GV.DeleteSelectedRows()
        '        End If
        '    End If
        'End If
    End Sub

End Class