Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Data

Public Class frmGenDPB
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
        'With Me
        '    .btAdd.Enabled = btnAdd
        '    .btCancel.Enabled = btnCancel
        '    .btDel.Enabled = btnDelete
        '    .btEdit.Enabled = btnEdit
        '    .btSave.Enabled = btnSave
        'End With
    End Sub

    Private Sub frmGenDPB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)

        reload()
    End Sub

    Private Sub reload()
        If Not ds1.Tables("Barang") Is Nothing Then ds1.Tables("Barang").Clear()
        If Not ds1.Tables("noTrans") Is Nothing Then ds1.Tables("noTrans").Clear()
        If Not ds1.Tables("noSP") Is Nothing Then ds1.Tables("noSP").Clear()
        If Not ds1.Tables("DPBM") Is Nothing Then ds1.Tables("DPBM").Clear()
        If Not ds1.Tables("Kendaraan") Is Nothing Then ds1.Tables("Kendaraan").Clear()
        If Not ds1.Tables("Sopir") Is Nothing Then ds1.Tables("Sopir").Clear()
        'da1 = New SqlDataAdapter(New SqlCommand("select tanggal Tanggal, no_trans [No Transaksi] from PROD.dbo.PROD_rcn_krm group by no_trans, tanggal", sqlconn))
        da1 = New SqlDataAdapter(New SqlCommand("select t.tanggal [Tanggal], t.no_trans [No Transaksi] " & _
                                                "from ( " & _
                                                "select tanggal, no_trans, no_sp " & _
                                                "from PROD.dbo.PROD_rcn_krm_d " & _
                                                "group by no_trans, tanggal, no_sp ) t " & _
                                                "left join PROD.dbo.PROD_dpb_m d " & _
                                                "on t.no_trans=d.no_trans_krm and t.no_sp=d.no_sp " & _
                                                "WHERE d.no_trans_krm is null " & _
                                                "group by t.no_trans, t.tanggal", sqlconn))
        da1.Fill(ds1, "noTrans")
        da3 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_dpb_m where 1=0", sqlconn))
        da3.Fill(ds1, "DPBM")
        da2 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_dpb_d where 1=0", sqlconn))
        da2.Fill(ds1, "Barang")
        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Kendaraan, (Nama_Kendaraan + '-' + No_Polisi) as Nama_Kendaraan from sif.dbo.SIF_Kendaraan", sqlconn))
        da1.Fill(ds1, "Kendaraan")
        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Sopir", sqlconn))
        da1.Fill(ds1, "Sopir")

        txtSopir.Properties.DataSource = ds1.Tables("Sopir")
        txtKernet.Properties.DataSource = ds1.Tables("Sopir")
        txtKendaraan.Properties.DataSource = ds1.Tables("Kendaraan")

        txtNoTrans.Properties.DisplayMember = "No Transaksi"
        txtNoTrans.Properties.ValueMember = "No Transaksi"
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
        

        Dim qstr As String = "select a.tanggal Tanggal,a.no_trans_krm [No Pengiriman], a.no_trans [No DPB], a.no_sp [No SP], c.Nama_Customer " & _
                              "from PROD.dbo.PROD_dpb_m a, sales.dbo.sales_so b, sif.dbo.SIF_Customer c " & _
                             "where a.no_sp = b.no_sp and b.Kd_Customer = c.Kd_Customer and a.rec_stat = 'S' "
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(qstr, sqlconn))
        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        da3.Fill(ds3, "lookup_so")
        frmCari.set_dso(ds3.Tables("lookup_so"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            
            Dim nodpb = frmCari.row("No DPB")
            
            qstr = "select m.*, '' Nama_Customer " & _
                "from PROD.dbo.PROD_dpb_m m " & _
                "where m.no_trans = '" & nodpb & "'"
            da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(qstr, sqlconn))
            If Not ds1.Tables("DPBM") Is Nothing Then ds1.Tables("DPBM").Clear()
            da3.Fill(ds1, "DPBM")
            qstr = "select c.Nama_Customer " & _
                "from PROD.dbo.PROD_dpb_m m " & _
                "left join SIF.dbo.SIF_Customer c " & _
                "on m.kd_customer = c.Kd_Customer " & _
                "where m.no_trans = '" & nodpb & "'"

            Dim dr As SqlDataReader = New SqlClient.SqlCommand(qstr, sqlconn).ExecuteReader
            dr.Read()
            row = ds1.Tables("DPBM").Rows(0)
            row("Nama_Customer") = dr.Item("Nama_Customer")

            dr.Close()
            Dim mr As DataRow = ds1.Tables("DPBM").Rows(0)
            If Not ds1.Tables("noTrans") Is Nothing Then ds1.Tables("noTrans").Clear()
            If Not ds1.Tables("noSP") Is Nothing Then ds1.Tables("noSP").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("select t.tanggal [Tanggal], t.no_trans [No Transaksi] " & _
                                                "from ( " & _
                                                "select tanggal, no_trans, no_sp " & _
                                                "from PROD.dbo.PROD_rcn_krm_d " & _
                                                "group by no_trans, tanggal, no_sp ) t " & _
                                                "left join PROD.dbo.PROD_dpb_m d " & _
                                                "on t.no_trans=d.no_trans_krm and t.no_sp=d.no_sp " & _
                                                " " & _
                                                "group by t.no_trans, t.tanggal", sqlconn))
            da1.Fill(ds1, "noTrans")

            da1 = New SqlDataAdapter(New SqlCommand("select t.no_sp [No SP] " & _
                                                "from ( " & _
                                                "select tanggal, no_trans, no_sp " & _
                                                "from PROD.dbo.PROD_rcn_krm_d " & _
                                                "group by no_trans, tanggal, no_sp ) t " & _
                                                "left join PROD.dbo.PROD_dpb_m d " & _
                                                "on t.no_trans=d.no_trans_krm and t.no_sp=d.no_sp " & _
                                                " " & _
                                                " and t.no_trans='" & mr.Item("no_trans_krm") & "'", sqlconn))
            da1.Fill(ds1, "noSP")

            txtNoTrans.Properties.DataSource = ds1.Tables("noTrans")
            txtNoSP.Properties.DataSource = ds1.Tables("noSP")

            txtNoDPB.Text = mr.Item("no_trans").ToString
            txtNoTrans.EditValue = mr.Item("no_trans_krm").ToString

            txtNoSP.EditValue = mr.Item("no_sp")
            txtCustomer.Text = mr.Item("Nama_Customer").ToString
            txtKdCustomer.Text = mr.Item("kd_customer").ToString

            'Load Detail Barang
            If Not ds1.Tables("Barang") Is Nothing Then ds1.Tables("Barang").Clear()
            qstr = "Select *,'' Kd_Stok, '' Nama_Barang,'' Kd_Satuan from PROD.dbo.PROD_dpb_d where 1=0"
            da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(qstr, sqlconn))
            da2.Fill(ds1, "Barang")
            qstr = "select d.no_trans,d.tanggal, d.no_sp, d.no_sp_dtl,d.no_seq,d.tinggi,d.lebar,d.panjang, v.Kd_Stok, v.Nama_Barang, v.Kd_Satuan, d.jumlah " & _
            "from PROD.dbo.PROD_dpb_d d " & _
            "left join PROD.dbo.PRODV_MON_SO v " & _
            "on d.no_sp = v.No_sp and d.no_sp_dtl = v.No_seq_d and d.no_seq=v.No_sp_box " & _
            "where d.no_trans = '" & nodpb & "'"
            Dim dr1 As SqlDataReader = New SqlClient.SqlCommand(qstr, sqlconn).ExecuteReader
            While dr1.Read()
                Dim rw As DataRow = ds1.Tables("Barang").NewRow
                rw("kd_cabang") = kdcabang
                rw("kd_departemen") = kddep
                rw("Kd_Stok") = dr1.Item("Kd_Stok")
                rw("Nama_Barang") = dr1.Item("Nama_Barang")
                rw("Kd_Satuan") = dr1.Item("Kd_Satuan")
                rw("tanggal") = dr1.Item("tanggal")
                rw("no_trans") = dr1.Item("no_trans")
                rw("no_sp") = dr1.Item("no_sp")
                rw("no_sp_dtl") = dr1.Item("no_sp_dtl")
                rw("no_seq") = dr1.Item("no_seq")
                rw("tinggi") = dr1.Item("tinggi")
                rw("lebar") = dr1.Item("lebar")
                rw("panjang") = dr1.Item("panjang")
                rw("jumlah") = dr1.Item("jumlah")
                ds1.Tables("Barang").Rows.Add(rw)
            End While
            
            dr1.Close()


            dr = New SqlClient.SqlCommand("select * from PROD.dbo.PROD_rcn_krm_m where no_trans='" & mr.Item("no_trans_krm").ToString & "' ", sqlconn).ExecuteReader
            dr.Read()

            txtKendaraan.EditValue = dr.Item("kd_kendaraan")
            txt_kdKendaraan.Text = txtKendaraan.EditValue
            txtSopir.EditValue = dr.Item("kd_sopir")
            txt_KdSopir.Text = txtSopir.EditValue
            txtKernet.EditValue = dr.Item("kd_kenek")
            txt_KdKernet.Text = txtKernet.EditValue
            dr.Close()

            GC.DataSource = ds1.Tables("Barang")

            State = "EDIT"

            txtNoSP.Properties.ReadOnly = True
            txtNoTrans.Properties.ReadOnly = True
            GV.OptionsBehavior.ReadOnly = True
            btnSave = True
            btnAdd = False
            btnEdit = False
            btnDelete = False
            btnCancel = True
            setStatus()
            Me.Enabled = True
        Else
            cancel_click()
        End If
    End Sub

    Public Sub save_click()
        Dim qstr As String
        If txtNoSP.EditValue = "" Then
            showMessages("Pilih No SP terlebih dahulu!")
            Exit Sub
        End If
        Dim tgl As Date = getTanggal()
        If State = "ADD" Then
            If Not ds1.Tables("DPBM") Is Nothing Then ds1.Tables("DPBM").Clear()
            row = ds1.Tables("DPBM").NewRow

            row("tanggal") = tgl
            Dim notrans As String
            notrans = getNoTrans("PRODDPB", tgl)
            txtNoDPB.Text = notrans
            row("no_trans") = notrans
            row("no_trans_krm") = txtNoTrans.EditValue
            row("no_sp") = txtNoSP.EditValue
            row("last_create_date") = tgl
            row("last_created_by") = username
            row("last_update_date") = tgl
            row("last_updated_by") = username
            row("program_name") = Me.Name
            row("kd_cabang") = kdcabang
            row("kd_departemen") = kddep
            ds1.Tables("DPBM").Rows.Add(row)

            Dim mb As New SqlCommandBuilder(da3)
            da3.UpdateCommand = mb.GetUpdateCommand
            da3.Update(ds1.Tables("DPBM"))
            ds1.Tables("DPBM").AcceptChanges()

            For i = 0 To ds1.Tables("Barang").Rows.Count - 1
                Dim rows As DataRow = ds1.Tables("Barang").Rows(i)
                rows("tanggal") = tgl
                rows("no_trans") = notrans
                rows("kd_departemen") = kddep
            Next

            Dim mb2 As New SqlCommandBuilder(da2)
            da2.UpdateCommand = mb.GetUpdateCommand
            da2.Update(ds1.Tables("Barang"))
            ds1.Tables("Barang").AcceptChanges()
            showMessages("Data Berhasil Disimpan")
            State = "EDIT"

        ElseIf State = "EDIT" Then
            row = ds1.Tables("DPBM").Rows(0)
            'row("no_trans") = txtNoDPB.Text
            'row("no_trans_krm") = txtNoTrans.EditValue
            'row("no_sp") = txtNoSP.EditValue
            row("last_update_date") = tgl
            row("last_updated_by") = username
            Dim mb As New SqlCommandBuilder(da3)
            da3.UpdateCommand = mb.GetUpdateCommand
            da3.Update(ds1.Tables("DPBM"))
            ds1.Tables("DPBM").AcceptChanges()

            Dim dr As SqlDataReader

            qstr = "delete from PROD.dbo.PROD_dpb_d where no_trans='" & txtNoDPB.Text & "'"
            dr = New SqlClient.SqlCommand(qstr, sqlconn).ExecuteReader
            dr.Close()
            For i = 0 To ds1.Tables("Barang").Rows.Count - 1
                Dim rows As DataRow = ds1.Tables("Barang").Rows(i)
                rows("tanggal") = tgl
                rows("no_trans") = txtNoDPB.Text
                rows("kd_departemen") = kddep
                rows("last_created_by") = username
                rows("last_update_date") = getTanggal()
                rows("last_updated_by") = username
                rows("program_name") = Me.Name
                rows("kd_cabang") = kdcabang
                rows("rec_stat") = "S"
            Next
            'Next

            Dim mb2 As New SqlCommandBuilder(da2)
            da2.UpdateCommand = mb2.GetUpdateCommand
            da2.DeleteCommand = mb2.GetDeleteCommand()
            da2.Update(ds1.Tables("Barang"))
            ds1.Tables("Barang").AcceptChanges()
            showMessages("Data Berhasil Disimpan")
            State = "EDIT"

        End If

    End Sub

    Public Sub delete_click()
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            showMessages("Deleted..")
            'cancel_click()
        End If
    End Sub

    Public Sub cancel_click()
        If Not ds1.Tables("Barang") Is Nothing Then ds1.Tables("Barang").Clear()
        GC.DataSource = ds1.Tables("Barang")
        txtKendaraan.EditValue = ""
        txtSopir.EditValue = ""
        txtKernet.EditValue = ""
        txtNoDPB.Text = ""
        'txtNoTrans.EditValue = ""
        txtNoSP.EditValue = ""
        txtCustomer.Text = ""
        txtKdCustomer.Text = ""
        txtNoSP.Properties.ReadOnly = False
        txtNoTrans.Properties.ReadOnly = False
        GV.OptionsBehavior.ReadOnly = False
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
    End Sub

    Private Sub GV_InvalidRowException(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles GV.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub txtNoTrans_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoTrans.EditValueChanged
        
        If State = "ADD" Then
            If Not ds1.Tables("noSP") Is Nothing Then ds1.Tables("noSP").Clear()
            If Not ds1.Tables("Barang") Is Nothing Then ds1.Tables("Barang").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("select t.no_sp [No SP] " & _
                                                "from ( " & _
                                                "select tanggal, no_trans, no_sp " & _
                                                "from PROD.dbo.PROD_rcn_krm_d " & _
                                                "group by no_trans, tanggal, no_sp ) t " & _
                                                "left join PROD.dbo.PROD_dpb_m d " & _
                                                "on t.no_trans=d.no_trans_krm and t.no_sp=d.no_sp " & _
                                                "WHERE d.no_trans_krm is null " & _
                                                " and t.no_trans='" & txtNoTrans.EditValue & "'", sqlconn))
            da1.Fill(ds1, "noSP")
        ElseIf State = "EDIT" Then
            If Not ds1.Tables("noSP") Is Nothing Then ds1.Tables("noSP").Clear()
            If Not ds1.Tables("Barang") Is Nothing Then ds1.Tables("Barang").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("select t.no_sp [No SP] " & _
                                                "from ( " & _
                                                "select tanggal, no_trans, no_sp " & _
                                                "from PROD.dbo.PROD_rcn_krm_d " & _
                                                "group by no_trans, tanggal, no_sp ) t " & _
                                                "left join PROD.dbo.PROD_dpb_m d " & _
                                                "on t.no_trans=d.no_trans_krm and t.no_sp=d.no_sp " & _
                                                " " & _
                                                " and t.no_trans='" & txtNoTrans.EditValue & "'", sqlconn))
            da1.Fill(ds1, "noSP")
        End If
        
        da1.Fill(ds1, "noSP")

        txtNoSP.Properties.DisplayMember = "No SP"
        txtNoSP.Properties.ValueMember = "No SP"
        txtNoSP.Properties.DataSource = ds1.Tables("noSP")
        txtNoSP.EditValue = vbNullString
        GC.DataSource = ds1.Tables("Barang")
        Dim dr As SqlDataReader
        dr = New SqlClient.SqlCommand("select * from PROD.dbo.PROD_rcn_krm_m where no_trans='" & txtNoTrans.EditValue & "' ", sqlconn).ExecuteReader

        dr.Read()
        txtKendaraan.EditValue = dr.Item("kd_kendaraan")
        txt_kdKendaraan.Text = txtKendaraan.EditValue
        txtSopir.EditValue = dr.Item("kd_sopir")
        txt_KdSopir.Text = txtSopir.EditValue
        txtKernet.EditValue = dr.Item("kd_kenek")
        txt_KdKernet.Text = txtKernet.EditValue
        dr.Close()

    End Sub

    Private Sub txtNoSP_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoSP.EditValueChanged
        If State = "ADD" Then

            If Not ds1.Tables("Barang") Is Nothing Then ds1.Tables("Barang").Clear()
            da2 = New SqlDataAdapter(New SqlCommand("select t.*,'' Kd_Stok, '' Nama_Barang, '' Kd_Satuan from PROD.dbo.PROD_dpb_d t where 1=0", sqlconn))
            da2.Fill(ds1, "Barang")
            Dim dr As SqlDataReader = New SqlClient.SqlCommand("select t.no_trans, t.no_sp, t.no_sp_dtl, t.jumlah, v.Kd_Customer, v.Nama_Customer, v.Kd_Stok, v.Nama_Barang, v.Kd_Satuan " & _
                                        "from PROD.dbo.PROD_rcn_krm_d t " & _
                                        "left join PROD.dbo.PRODV_MON_SO v " & _
                                        "on v.No_sp=t.no_sp and v.No_seq_d=t.no_sp_dtl " & _
                                        "where t.no_trans='" & txtNoTrans.EditValue & "' and t.no_sp='" & txtNoSP.EditValue & "'", sqlconn).ExecuteReader

            While dr.Read
                Dim rw As DataRow = ds1.Tables("Barang").NewRow
                rw("no_sp") = dr.Item("no_sp")
                rw("no_sp_dtl") = dr.Item("no_sp_dtl")
                rw("Kd_Stok") = dr.Item("Kd_Stok")
                rw("Nama_Barang") = dr.Item("Nama_Barang")
                rw("Kd_Satuan") = dr.Item("Kd_Satuan")
                rw("jumlah") = dr.Item("jumlah")
                txtCustomer.Text = dr.Item("Nama_Customer").ToString
                txtKdCustomer.Text = dr.Item("Kd_Customer").ToString
                ds1.Tables("Barang").Rows.Add(rw)
            End While
            dr.Close()

            GC.DataSource = ds1.Tables("Barang")
        End If
    End Sub

    Public Sub cetak_click()
        'If Trim(txtNoDPB.Text) <> "" And State = "EDIT" Then
        'callReport(App_Path() & "\report\rptPOM.rpt", "", "Nomor=" & Trim(txtNoPO.Text))

        'Dim notrans As String = Trim(txtNoDPB.Text)
        callReport(App_Path() & "\report\PROD_DPB.rpt", "", "&no_trans=" & txtNoDPB.Text)
        'Else
        'MessageBox.Show("Pilih data yang akan dicetak dalam mode EDIT!")
        'End If
    End Sub

   
    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        cetak_click()
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