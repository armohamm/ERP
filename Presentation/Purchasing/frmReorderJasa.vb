Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports System.Data.SqlClient
Public Class frmReorderJasa
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public prn As frmMain   '<-- untuk mengakses frmMain
    Public obj As Object
    Dim ds, dsedit, ds1, ds2, ds3, ds4, ds5, ds6, ds7, dss, dss1 As New DataSet
    Public STATE As String '<-- untuk mengecek status saat ini (ADD, EDIT)
    Dim row As DataRow
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Dim DA, daedit, da2, da3, da4, da5, da6, da7, sqlda, sqlda1 As SqlClient.SqlDataAdapter
    Dim Buildernya As New SqlClient.SqlCommandBuilder
    Public Sub edit_click()
        daedit = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select No_PO as [Nomor],tgl_PO as [Tanggal] from PURC.dbo.PURC_PO where tipe_trans='JPP-KUT-02' and status='ENTRY' or status='REJECT'", sqlconn)) '<- query buat ditampilkan di LOV, pakailah alias colom biar enak dibaca
        If Not dsedit.Tables("lookup_PO") Is Nothing Then dsedit.Tables("lookup_PO").Clear()
        daedit.Fill(dsedit, "lookup_PO")
        frmCari.set_dso(dsedit.Tables("lookup_PO")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV
        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            reload_table(frmCari.row(0))
            State = "EDIT"
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
    Public Sub setStatus()
        With prn
            btnadd = .btnAdd.Enabled
            btnCancel = .btnCancel.Enabled
            btnDelete = .btnDelete.Enabled
            btnEdit = .btnEdit.Enabled
            btnSave = .btnSave.Enabled
        End With

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

    Private Sub V_Supplier()
        da5 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Supplier,Nama_Supplier from sif.dbo.SIF_Supplier", sqlconn))
        da5.Fill(ds5, "View_Supplier")
        LESupllier.Properties.DataSource = ds5.Tables("View_Supplier")
    End Sub
    Private Function NomorPO(ByVal bgtrans As SqlTransaction) As String
        Dim hasil, temp As String
        Dim sqldr As SqlDataReader = New SqlCommand("select max(substring(IsNULL(no_po,'00001'),1,5))+1 from PURC.DBO.PURC_PO", sqlconn, bgtrans).ExecuteReader
        sqldr.Read()
        temp = ""
        If TypeOf sqldr.Item(0) Is DBNull Then
            Dim bln1 As String = Format(Now, "MM")
            Dim th1 As String = Format(Now, "yyyy")
            hasil = "00001" & "/" & "PO" & "/" & th1 & bln1
        Else
            hasil = sqldr.Item(0)
            For i As Int16 = Len(hasil) To 4
                temp = "0" & temp
            Next
            Dim th, bln As String
            bln = Format(Now, "MM")
            th = Format(Now, "yyyy")
            hasil = temp & (hasil) & "/" & "PO" & "/" & th & bln
        End If
        sqldr.Close()
        Return hasil
    End Function
    Private Sub bersih()
        LEPR.EditValue = vbNullString
        LESupllier.EditValue = vbNullString
        LEValuta.EditValue = vbNullString
        txtkurs.EditValue = vbNullString
        txtKeterangan.Text = ""
        txtTerm.Text = ""
        txtSubTotal.EditValue = vbNullString
        txtJmlDiskon.EditValue = vbNullString
        txtJmlPPN.EditValue = vbNullString
        txtJmlTotal.EditValue = vbNullString
        txtNoPO.EditValue = vbNullString
        txtstatus.EditValue = vbNullString
    End Sub
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
    Sub View_PR_D()
        'da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct no_pr from PURC.DBO.PURC_CHOICE_SUPP where status='APPROVE'", sqlconn))
        da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct no_po from PURC.DBO.PURC_PO where tipe_trans='JPP-KUT-02'", sqlconn))
        da7.Fill(ds7, "View_PR_D")
        LEPR.Properties.DataSource = ds7.Tables("View_PR_D")
    End Sub
    Sub View_Valuta()
        da6 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Valuta,Nama_Valuta from sif.dbo.SIF_valuta", sqlconn))
        da6.Fill(ds6, "View_Valuta")
        LEValuta.Properties.DataSource = ds6.Tables("View_Valuta")

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
            If LEPR.EditValue = "" Then
                showMessages("No PO Belum Diisi")
                LEPR.Focus()
                Exit Sub
            End If

            If LEValuta.EditValue = "" Then
                showMessages("Valuta Belum Dipilih")
                LEValuta.Focus()
                Exit Sub
            End If

            If STATE = "ADD" Then
                row = ds3.Tables("PO").NewRow
                row.Item("Last_Create_Date") = Now
                row.Item("no_po") = NomorPO(BTRANS)
                txtNoPO.Text = row.Item("no_po")

                'row.Item("Last_Created_By") = username
            ElseIf STATE = "EDIT" Then
                row = ds3.Tables("PO").Rows(0)
                row.Item("Last_Update_Date") = Now
                row.Item("Last_Updated_By") = username
            End If
            Dim jatuh_tempo As Date
            jatuh_tempo = DateAdd(DateInterval.Day, 30, dtTanggal.EditValue)
            row.Item("Kd_Cabang") = kdcabang ' <-- hanya contoh, nanti diisi dengan yg bener

            row.Item("tipe_trans") = "JPP-KUT-02"
            row.Item("tgl_po") = dtTanggal.EditValue
            row.Item("tgl_po") = dtTanggal.EditValue
            row.Item("no_ref") = LEPR.EditValue
            row.Item("kd_supplier") = LESupllier.EditValue
            row.Item("kd_valuta") = LEValuta.EditValue
            row.Item("kurs_valuta") = txtkurs.Text
            row.Item("tgl_kirim") = dtKirim.EditValue
            row.Item("jml_rp_trans") = txtkurs.Text * txtSubTotal.Text
            row.Item("jml_val_trans") = txtSubTotal.Text
            row.Item("flag_ppn") = CEPPN.EditValue
            row.Item("jml_ppn") = txtJmlDiskon.Text
            row.Item("jml_diskon") = txtJmlDiskon.Text
            row.Item("keterangan") = txtKeterangan.Text
            row.Item("qty_total") = txtJmlTotal.EditValue
            row.Item("status") = "ENTRY"
            txtstatus.Text = row.Item("Status")
            row.Item("tgl_bayar") = dtBayar.EditValue
            row.Item("term_bayar") = txtTerm.Text
            row.Item("Program_Name") = Me.Name

            If STATE = "ADD" Then
                ds3.Tables("PO").Rows.Add(row)
            End If

            For Each rows As DataRow In ds4.Tables("POD").Rows
                If rows.RowState = DataRowState.Added Then
                    rows.Item("Last_Create_Date") = Now
                    rows.Item("Last_Created_By") = username

                    rows.Item("kd_Cabang") = kdcabang
                    rows.Item("tipe_trans") = "JPP-KUT-02"
                Else
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
                If CEPPN.Checked = True Then
                    row.Item("No_po") = getNoTrans("PO-JP", getTanggal(BTRANS), BTRANS)
                Else
                    row.Item("No_po") = getNoTrans("PO-JNP", getTanggal(BTRANS), BTRANS)
                End If
                txtNoPO.Text = row.Item("No_po")
                For Each rows As DataRow In ds4.Tables("POD").Rows
                    If rows.RowState = DataRowState.Added Then
                        rows.Item("No_po") = row.Item("No_po")
                    End If
                Next
            End If

            da3.Update(ds3.Tables("PO"))
            da4.Update(ds4.Tables("POD"))

            ds3.Tables("PO").AcceptChanges()
            ds4.Tables("POD").AcceptChanges()
            STATE = "EDIT"
            BTRANS.Commit()
            showMessages("Berhasil disimpan..")
        Catch e As Exception
            BTRANS.Rollback()
            ds3.Tables("PO").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub
    Private Sub GV_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV.CellValueChanged
        If e.Column Is kd_stok Then
            Dim rw As DataRow
            rw = ds.Tables("VBARANG").Select("Kode_Barang='" & e.Value & "'")(0)
            GV.GetRow(e.RowHandle).item("kd_satuan") = rw("Kd_Satuan")
        End If
        If e.Column Is QTY Then
            GV.GetRow(e.RowHandle).item("total") = GV.GetRow(e.RowHandle).item("harga").ToString * GV.GetRow(e.RowHandle).item("qty").ToString

        End If
        txtSubTotal.Text = total.SummaryItem.SummaryValue
    End Sub
    Private Sub reload_table(ByVal kode As String)
        If Not ds3.Tables("PO") Is Nothing Then ds3.Tables("PO").Clear()
        If Not ds4.Tables("POD") Is Nothing Then ds4.Tables("POD").Clear()


        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PURC.dbo.PURC_PO where no_po='" & kode & "'", sqlconn))
        da3.Fill(ds3, "PO")

        da4 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * ,'' As No,'' as no_pr,'' as Nama_Barang ,qty*harga as total from PURC.dbo.PURC_PO_D where no_po= '" & kode & "'", sqlconn))
        da4.Fill(ds4, "POD")
        'GC.DataSource = ds4.Tables("POD")

        AddHandler ds4.Tables("POD").RowDeleted, AddressOf refreshNomer

        'JPP-KUT-01'
        If ds3.Tables("PO").Rows.Count > 0 Then
            Dim row As DataRow

            row = ds3.Tables("PO").Rows(0)
            txtNoPO.Text = row.Item("no_po").ToString
            'LEPR.EditValue = row.Item("no_pr")
            LEValuta.EditValue = row.Item("kd_valuta").ToString
            txtkurs.Text = row.Item("kurs_valuta").ToString
            'txtNoRef.Text = row.Item("no_ref").ToString
            LEPR.EditValue = row.Item("no_ref")
            dtTanggal.Text = row.Item("tgl_po")
            dtKirim.Text = row.Item("tgl_kirim")
            dtBayar.Text = row.Item("tgl_bayar")
            txtTerm.Text = row.Item("term_bayar").ToString
            txtKeterangan.Text = row.Item("keterangan").ToString
            LESupllier.EditValue = row.Item("kd_supplier").ToString
            txtstatus.Text = row.Item("status").ToString
            CEPPN.EditValue = row.Item("flag_ppn").ToString
            txtJmlPPN.Text = row.Item("jml_ppn").ToString
            txtSubTotal.EditValue = row.Item("jml_val_trans")
            txtJmlDiskon.EditValue = row.Item("jml_diskon").ToString
            txtJmlTotal.EditValue = row.Item("qty_total").ToString
        End If


    End Sub
    Sub hitung_total()
        'txtSubTotal.EditValue = getTotal()
        If CEPPN.Checked = True Then
            CEPPN.Text = "PPN"
            txtJmlPPN.EditValue = (txtSubTotal.EditValue - txtJmlDiskon.EditValue) * (10 / 100)
        Else
            CEPPN.Text = "NON PPN"
            txtJmlPPN.EditValue = 0
        End If

        txtJmlTotal.EditValue = Val((txtSubTotal.EditValue - Val(txtJmlDiskon.EditValue))) + Val(txtJmlPPN.EditValue)
    End Sub
    Public Sub cetak_click()

        'callReport(App_Path() & "\report\rptDPM_M.rpt", "", "Nomor=0014/DPM/201106")
        callReport(App_Path() & "\report\rptPOJ.rpt", "", "Nomor=" & Trim(txtNoPO.Text))

    End Sub
    Private Sub frmPO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnEdit = False
        dtBayar.Text = Date.Today
        dtTanggal.Text = Date.Today
        dtKirim.Text = Date.Today
        STATE = "ADD"
        connect()
        LEValuta.EditValue = "IDR"
        txtkurs.Text = "1"
        prn = getParent(Me)
        da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Barang", sqlconn))
        da2.Fill(ds, "VBarang")
        repBrg.DataSource = ds.Tables("VBARANG")

        View_Valuta()
        View_PR_D()
        V_Supplier()
        yayak()
        If txtNoPO.Text = "" Then
            reload_table("xxx")
            GC.DataSource = ds4.Tables("POD")
        End If

    End Sub

    Public Sub cariPO(ByVal nocsp As String) ' ============= cretaed by yaya =============
        dss = New DataSet
        dss1 = New DataSet
        sqlda = New SqlDataAdapter(New SqlCommand("select * from PURC.dbo.PURC_PO where no_po='" & nocsp & "'", sqlconn))
        sqlda.Fill(dss, "_yaya")
        'MsgBox(dss.Tables(0).Rows(0).Item("no_po").ToString)
        If dss.Tables(0).Rows.Count Then
            txtNoPO.Text = dss.Tables(0).Rows(0).Item("no_po").ToString
            txtstatus.Text = dss.Tables(0).Rows(0).Item("status").ToString
            dtTanggal.Text = dss.Tables(0).Rows(0).Item("tgl_po").ToString
            LEPR.EditValue = dss.Tables(0).Rows(0).Item("no_pr").ToString
            LESupllier.EditValue = dss.Tables(0).Rows(0).Item("kd_supplier").ToString
            LEValuta.EditValue = dss.Tables(0).Rows(0).Item("kd_valuta").ToString
            txtKeterangan.Text = dss.Tables(0).Rows(0).Item("keterangan").ToString

        End If
        sqlda1 = New SqlDataAdapter(New SqlCommand("select * from PURC.DBO.PURC_PO_D where no_po='" & txtNoPO.Text & "'", sqlconn))
        sqlda1.Fill(dss1, "_yaya_d")
        GC.DataSource = dss1.Tables("_yaya_d")

    End Sub

    Private Sub yayak()
        thisThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        GV.Columns("harga").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GV.Columns("harga").DisplayFormat.FormatString = "n3"
        GV.Columns("qty").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GV.Columns("qty").DisplayFormat.FormatString = "n2"
        GV.Columns("total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        GV.Columns("total").DisplayFormat.FormatString = "n2"

    End Sub
    Private Sub GV_InitNewRow(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GV.InitNewRow
        GV.GetRow(e.RowHandle).item("no_seq") = GV.RowCount + 1
    End Sub

    Private Sub LEValuta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEValuta.EditValueChanged
        If LEValuta.EditValue = "IDR" Then
            txtkurs.Text = "1"
        Else
            txtkurs.Text = ""
            txtkurs.Focus()
        End If
    End Sub

    Private Sub btSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btSimpan.Click
        save_click()
    End Sub

    Private Sub LEPR_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LEPR.EditValueChanged
        Dim dr As SqlDataReader = New SqlCommand("select distinct Kode_Supplier from sif.dbo.SIF_Supplier,PURC.DBO.PURC_PO  where kode_supplier=kd_supplier and no_po='" & LEPR.EditValue & "'", sqlconn).ExecuteReader
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
        If txtNoPO.Text = "" Then
            ds4.Tables("POD").Clear()
            Dim dr As SqlDataReader = New SqlCommand(" select *  from PURC.dbo.VReorderPOJasa where kd_supplier='" & LESupllier.EditValue & "' and no_po='" & LEPR.EditValue & "' ", sqlconn).ExecuteReader
            Dim i As Int16 = 1
            While dr.Read
                Dim rw As DataRow = ds4.Tables("POD").NewRow
                rw.Item("no_po") = dr.Item("no_po")
                rw.Item("kd_stok") = dr.Item("kd_stok")
                rw.Item("Nama_Barang") = dr.Item("Nama_Barang")
                rw.Item("kd_satuan") = dr.Item("kd_satuan")
                rw.Item("harga") = dr.Item("harga")
                rw.Item("qty") = 0
                rw.Item("no_seq") = i
                i += 1
                ds4.Tables("POD").Rows.Add(rw)
            End While
            dr.Close()
        End If
    End Sub

    Private Sub CEPPN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEPPN.CheckedChanged
        If txtSubTotal.Text = "" Or txtSubTotal.Text = "0" Then
            MsgBox("Sub Total Masih Kosong,Silahkan Lakukan Transaksi ", MsgBoxStyle.Information, "Perhatian")
            Exit Sub
        Else
            If CEPPN.Checked = True Then
                CEPPN.Text = "PPN"
                txtJmlPPN.EditValue = txtSubTotal.EditValue * (10 / 100)

                txtJmlTotal.EditValue = Val(txtSubTotal.EditValue) + Val(txtJmlPPN.EditValue)
            Else
                CEPPN.Text = "NON PPN"
                'txtJmlPPN.Text = ""
                txtJmlPPN.EditValue = txtSubTotal.EditValue * (10 / 100)
                txtJmlTotal.EditValue = Val(txtJmlTotal.EditValue) - Val(txtJmlPPN.EditValue)
            End If
        End If

    End Sub
    Function getTotal() As Double
        Dim ttl As Double

        For Each rw As DataRow In ds4.Tables("POD").Rows
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
    Private Sub refreshNomer(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        Dim i As Int16 = 1
        Dim j As Int16 = 1
        If State = "DELETE" Then Exit Sub
        For Each rw As DataRow In sender.Rows
            If rw.RowState <> DataRowState.Deleted Then
                For Each rwd As DataRow In ds4.Tables("POD").Select("NO=" & rw.Item("No_seq"))

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
    Private Sub txtkurs_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtkurs.Leave
        'If LEValuta.EditValue <> "Rupiah" Then
        '    MsgBox("Kurs harus diisi !", MsgBoxStyle.Critical, "Perhatian")
        '    txtkurs.Focus()
        'End If
    End Sub


    Private Sub GV_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV.RowUpdated
        txtSubTotal.EditValue = getTotal()
    End Sub
    Private Sub txtJmlDiskon_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtJmlDiskon.KeyPress
        If e.KeyChar = Chr(13) Then
            hitung_total()
        End If
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data PO ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            STATE = "DELETE"
            If Not ds3.Tables("PO") Is Nothing Then delete(ds3.Tables("PO").Rows)
            If Not ds4.Tables("POD") Is Nothing Then delete(ds4.Tables("POD").Rows)


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


    Private Sub GC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GC.KeyDown
        If e.KeyCode = Keys.Delete Then
            If GV.GetSelectedRows.Count > 0 Then
                If MsgBox("Hapus Record Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Daftar DPM") = MsgBoxResult.Yes Then
                    GV.DeleteSelectedRows()
                End If
            End If
        End If
    End Sub

    Private Sub txtSubTotal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSubTotal.EditValueChanged
        hitung_total()
    End Sub

    Private Sub txtJmlDiskon_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtJmlDiskon.EditValueChanged
        hitung_total()
    End Sub
End Class