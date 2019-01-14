Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid

Public Class aFormPONonMaterial
    Public btnadd As Boolean = True
    Public btnEdit As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnSave As Boolean = False
    Public btnCetak As Boolean = True
    Public prn As frmMain
    Dim gvq As Boolean
    Dim cektipe As String
    Public STATE As String
    Dim row As DataRow
    Dim transaksiid As String
    Dim tipetrans As String
    Dim myBuilder As New SqlCommandBuilder
    Dim dsHPP, dsCari, dsHPP1, dsHPP2 As New DataSet
    Dim daHPP, daHPPD, daHPPD1, daLookUp, daCari, daHPP1 As SqlDataAdapter
    Dim drHPP, drHPS, drHPP1 As SqlDataReader
    Dim BTRANS As SqlTransaction
    Dim isvalid As Boolean
    Dim err, bukubesar, ppn As String

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
        STATE = "ADD"
        gvq = False
        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = True
        btnDelete = False
        Me.Enabled = True
        setStatus()
        loadData("xxx")
        controlOff(False)
    End Sub

    Public Sub controlOff(ByVal stat As Boolean)
        txtNoTrans.Properties.ReadOnly = stat
        dteTanggal.Properties.ReadOnly = stat
        lookSupplier.Properties.ReadOnly = stat
        lookPO.Properties.ReadOnly = stat
        lookValuta.Properties.ReadOnly = stat
        txtValuta.Properties.ReadOnly = stat
        txtKet.Properties.ReadOnly = stat
        gvHPP.OptionsBehavior.ReadOnly = stat
    End Sub

    Private Sub clear()
        txtNoTrans.EditValue = vbNullString
        dteTanggal.EditValue = getTanggal()
        lookSupplier.EditValue = vbNullString
        lookPO.EditValue = vbNullString
        lookValuta.EditValue = vbNullString
        txtValuta.EditValue = vbNullString
        txtKet.EditValue = vbNullString
    End Sub

    Private Sub loadData(ByVal kode As String)

        If Not dsHPP.Tables("HPP") Is Nothing Then dsHPP.Tables("HPP").Clear()
        If Not dsHPP.Tables("HPPD") Is Nothing Then dsHPP.Tables("HPPD").Clear()
        daHPP = New SqlDataAdapter(New SqlCommand("select * from FIN.dbo.FIN_PEMBELIAN where no_inv = '" & kode & "'", sqlconn)) '<- query buat ditampilkan di LOV
        daHPP.Fill(dsHPP, "HPP")
        daHPPD = New SqlDataAdapter(New SqlCommand("select *, 0 as qtyi, 0 as hargai,0 as qtyku, 0 as total from FIN.dbo.FIN_PEMBELIAN_D where no_inv = '" & kode & "'", sqlconn)) '<- query buat ditampilkan di LOV
        daHPPD.Fill(dsHPP, "HPPD")
        gcHPP.DataSource = dsHPP.Tables("HPPD")
        gvHPP.BestFitColumns()

        If STATE = "EDIT" Then
            If dsHPP.Tables("HPP").Rows.Count > 0 Then
                If gvq = False Then
                    txtNoTrans.EditValue = dsHPP.Tables("HPP").Rows(0)("no_inv")
                    dteTanggal.EditValue = dsHPP.Tables("HPP").Rows(0)("tgl_inv")

                    lookPO.EditValue = dsHPP.Tables("HPP").Rows(0)("no_ref1")
                    lookValuta.EditValue = dsHPP.Tables("HPP").Rows(0)("kd_valuta")
                    txtValuta.EditValue = dsHPP.Tables("HPP").Rows(0)("kurs_valuta")
                    txtKet.EditValue = dsHPP.Tables("HPP").Rows(0)("keterangan")
                    cektipe = dsHPP.Tables("HPP").Rows(0)("tipe_trans")
                Else
                    txtNoTrans.EditValue = dsHPP.Tables("HPP").Rows(0)("no_inv")
                    dteTanggal.EditValue = dsHPP.Tables("HPP").Rows(0)("tgl_inv")
                    lookSupplier.EditValue = dsHPP.Tables("HPP").Rows(0)("kd_supplier")
                    lookPO.EditValue = dsHPP.Tables("HPP").Rows(0)("no_ref1")
                    lookValuta.EditValue = dsHPP.Tables("HPP").Rows(0)("kd_valuta")
                    txtValuta.EditValue = dsHPP.Tables("HPP").Rows(0)("kurs_valuta")
                    txtKet.EditValue = dsHPP.Tables("HPP").Rows(0)("keterangan")
                    cektipe = dsHPP.Tables("HPP").Rows(0)("tipe_trans")
                End If
            End If

            If dsHPP.Tables("HPPD").Rows.Count > 0 Then
                Dim dr As DataRow
                If cektipe = "JPP-KUT-02" Then
                    drHPP = New SqlCommand("select * from FIN.dbo.FIN_PEMBELIAN_D where no_inv = '" & kode & "'", sqlconn).ExecuteReader

                    drHPS = New SqlCommand("SELECT distinct A.tipe_trans,c.rek_biaya,a.flag_ppn, b.no_seq, b.kd_stok, b.kd_satuan, E.qty, F.harga_BARU harga " & _
    "FROM PURC.dbo.PURC_PO a, PURC.dbo.PURC_PO_D_bARANG b,SIF.dbo.SIF_Barang c,PURC.dbo.PURC_PR_D_BARANG D,PURC.dbo.PURC_DPM_D_BARANG E,PURC.DBO.PURC_CHOICE_SUPP_D F,PURC.DBO.PURC_CHOICE_SUPP G " & _
    "WHERE a.no_po = b.no_po AND a.no_po = '" & lookPO.EditValue & "' AND A.NO_PR=D.NO_PR AND E.no_dpm=D.no_dpm AND G.kd_supp_pilih=A.kd_supplier AND G.no_pr=A.no_pR AND F.no_csp=G.no_csp " & _
    "AND c.Kode_barang=b.kd_stok AND B.kd_stok=D.kd_stok AND B.kd_jasa=D.kd_jasa AND D.kd_jasa=E.kd_jasa", sqlconn).ExecuteReader
                    Dim i As Integer = 0
                    While drHPS.Read()
                        While drHPP.Read()
                            dr = dsHPP.Tables("HPPD").Rows(i)


                            dr("tipe_trans") = drHPP.Item("tipe_trans")
                            dr("kd_stok") = drHPP.Item("kd_stok")
                            dr("satuan") = drHPP.Item("satuan")

                            dr("qtyi") = drHPS.Item("qty") - drHPP.Item("qty")
                            dr("hargai") = drHPP.Item("harga")
                            dr("total") = drHPP.Item("harga") * dr("qtyi")
                            dr("kd_buku_besar") = drHPP.Item("kd_buku_besar")
                            dr("qty") = 0
                            dr("qtyku") = drHPP.Item("qty")
                            dr("harga") = drHPP.Item("harga")
                            dr("jml_val_trans") = drHPP.Item("jml_val_trans")
                            i += 1
                        End While
                    End While
                    drHPP.Close()
                    drHPS.Close()
                Else

                    drHPP = New SqlCommand("select * from FIN.dbo.FIN_PEMBELIAN_D where no_inv = '" & kode & "'", sqlconn).ExecuteReader

                    drHPS = New SqlCommand("SELECT  distinct b.tipe_trans,H.rek_biaya,a.flag_ppn, b.no_seq, b.kd_stok, b.kd_satuan, f.qty, d.harga_BARU harga " & _
"FROM PURC.dbo.PURC_PO a inner join   PURC.dbo.PURC_PO_D b on a.no_po=b.no_po " & _
 "inner join  SIF.dbo.SIF_Barang H ON H.Kode_Barang=B.kd_stok " & _
"inner join PURC.dbo.PURC_PR_D  c on c.no_pr=a.no_pr and c.kd_stok=b.kd_stok and c.no_seq=b.no_seq " & _
"inner join PURC.dbo.PURC_CHOICE_SUPP i on i.no_pr=c.no_pr and i.kd_stok=c.kd_stok and i.kd_supp_pilih=a.kd_supplier and a.no_pr=i.no_pr " & _
"inner join  PURC.dbo.PURC_CHOICE_SUPP_d d on   d.kd_supplier=a.kd_supplier and d.no_csp=i.no_csp and d.no_seq=b.no_seq and d.no_seq=c.no_seq " & _
"inner join  PURC.dbo.PURC_DPM e on e.No_DPM=c.no_dpm " & _
                   " inner Join " & _
"PURC.dbo.PURC_DPM_D f on f.No_DPM = e.No_DPM  and f.Kd_Stok=c.kd_stok and f.No_Seq=c.no_seq " & _
"where b.no_po='" & lookPO.EditValue & "'", sqlconn).ExecuteReader
                    Dim i As Integer = 0
                    While drHPS.Read()
                        While drHPP.Read()

                            dr = dsHPP.Tables("HPPD").Rows(i)


                            dr("tipe_trans") = drHPP.Item("tipe_trans")
                            dr("kd_stok") = drHPP.Item("kd_stok")
                            dr("satuan") = drHPP.Item("satuan")

                            dr("qtyi") = drHPS.Item("qty") - drHPP.Item("qty")
                            dr("hargai") = drHPP.Item("harga")
                            dr("total") = drHPP.Item("harga") * dr("qtyi")
                            dr("kd_buku_besar") = drHPP.Item("kd_buku_besar")
                            dr("qty") = 0
                            dr("qtyku") = drHPP.Item("qty")
                            dr("harga") = drHPP.Item("harga")
                            dr("jml_val_trans") = drHPP.Item("jml_val_trans")
                            i += 1
                        End While
                    End While
                    drHPP.Close()
                    drHPS.Close()
                End If


            End If

        End If

    End Sub

    Public Sub save_click(Optional ByRef isDelete As Boolean = False)
        If Not isDelete Then
            cek()
            If isvalid Then
                If Not isDelete Then
                    If STATE = "ADD" Then
                        If ppn = "Y" Then
                            txtNoTrans.EditValue = getNoTrans("JPPP", dteTanggal.EditValue, BTRANS)
                        Else
                            txtNoTrans.EditValue = getNoTrans("JPPNP", dteTanggal.EditValue, BTRANS)
                        End If
                        row = dsHPP.Tables("HPP").NewRow


                        row.Item("Kd_cabang") = getKodeCabang()
                        row.Item("tipe_trans") = tipetrans
                        row.Item("no_inv") = txtNoTrans.EditValue
                        row.Item("thnbln") = Format(dteTanggal.EditValue, "yyyyMM")
                        row.Item("kd_buku_besar") = bukubesar
                        row.Item("Last_create_date") = getTanggal()
                        row.Item("Last_created_by") = username
                        row.Item("Program_name") = Me.Name
                    ElseIf STATE = "EDIT" Then
                        row = dsHPP.Tables("HPP").Rows(0)
                        row("Last_update_date") = getTanggal()
                        row("Last_updated_by") = umum.username
                    End If

                    row.Item("tgl_inv") = dteTanggal.EditValue
                    row.Item("kd_supplier") = lookSupplier.EditValue
                    row.Item("no_ref1") = lookPO.EditValue
                    row.Item("kd_valuta") = lookValuta.EditValue
                    row.Item("kurs_valuta") = txtValuta.EditValue
                    row.Item("keterangan") = txtKet.EditValue
                    row.Item("jml_tagihan") = IIf(gvHPP.Columns("jml_val_trans").SummaryText = vbNullString, 0, gvHPP.Columns("jml_val_trans").SummaryText)
                    row.Item("jml_val_trans") = IIf(gvHPP.Columns("jml_val_trans").SummaryText = vbNullString, 0, gvHPP.Columns("jml_val_trans").SummaryText)
                    row.Item("jml_rp_trans") = IIf(gvHPP.Columns("jml_val_trans").SummaryText = vbNullString, 0, gvHPP.Columns("jml_val_trans").SummaryText * txtValuta.EditValue)

                    If STATE = "ADD" Then
                        dsHPP.Tables("HPP").Rows.Add(row)
                    End If

                    For Each rw As DataRow In dsHPP.Tables("HPPD").Rows
                        If rw.RowState = DataRowState.Added Then
                            rw("Kd_Cabang") = getKodeCabang()
                            rw("tipe_trans") = tipetrans
                            'rw("kd_buku_besar") = bukubesar
                            rw("no_inv") = txtNoTrans.EditValue
                            rw("Last_create_date") = getTanggal()
                            rw("Last_created_by") = username
                            rw("Programe_name") = Me.Name
                        ElseIf rw.RowState = DataRowState.Modified Then
                            rw("Last_update_date") = getTanggal()
                            rw("qty") = rw("qtyku") + rw("qty")
                            rw("Last_updated_by") = username
                        End If
                    Next

                End If
            Else
                If gvHPP.RowCount = 0 Then
                    MsgBox("Kesalahan dalam pengisian data :" & vbCrLf & err, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "ERROR!")
                    err = ""
                End If
            End If
        End If

        Try
            myBuilder = New SqlCommandBuilder(daHPP)
            daHPP.UpdateCommand = myBuilder.GetUpdateCommand()
            daHPP.InsertCommand = myBuilder.GetInsertCommand()
            daHPP.DeleteCommand = myBuilder.GetDeleteCommand()

            myBuilder = New SqlCommandBuilder(daHPPD)
            daHPPD.UpdateCommand = myBuilder.GetUpdateCommand()
            daHPPD.InsertCommand = myBuilder.GetInsertCommand()
            daHPPD.DeleteCommand = myBuilder.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            daHPP.UpdateCommand.Transaction = BTRANS
            daHPP.InsertCommand.Transaction = BTRANS
            daHPP.DeleteCommand.Transaction = BTRANS

            daHPPD.UpdateCommand.Transaction = BTRANS
            daHPPD.InsertCommand.Transaction = BTRANS
            daHPPD.DeleteCommand.Transaction = BTRANS

            daHPP.Update(dsHPP.Tables("HPP"))
            daHPPD.Update(dsHPP.Tables("HPPD"))

            dsHPP.Tables("HPP").AcceptChanges()
            dsHPP.Tables("HPPD").AcceptChanges()

            If Not isDelete Then
                If STATE = "ADD" Then
                    If tipetrans = "JPP-KUT-02" Then
                        call_procedure("JPP-KUT-02", txtNoTrans.EditValue, BTRANS)
                    Else
                        call_procedure("JPP-KUT-05", txtNoTrans.EditValue, BTRANS)
                    End If
                End If
            End If
            BTRANS.Commit()
            If Not isDelete Then
                showMessages("Berhasil disimpan.")
                If STATE = "EDIT" Then
                    transaksiid = txtNoTrans.EditValue
                    btnDelete = False
                    setStatus()

                End If
                'clear()
                'loadData("XXX")
            Else
                showMessages("Berhasil dihapus.")
                cancel_click()
            End If
        Catch e As Exception
            BTRANS.Rollback()
            dsHPP.Tables("HPP").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            dsHPP.Tables("HPPD").RejectChanges()
            MsgBox(e.Message)
        End Try
    End Sub

    Public Sub cetak_click()
        If Not txtNoTrans.EditValue = "" Then
            callReport(App_Path() & "\report\repPONonMaterial.rpt", "", "nomor=" & txtNoTrans.EditValue, True)
        End If
    End Sub
   
    Public Sub call_procedure(ByVal tipeT As String, ByVal noG As String, ByVal trans As SqlTransaction)

        Dim sqlCmd As New SqlCommand
        sqlCmd.Connection = sqlconn
        sqlCmd.Transaction = trans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "FIN.dbo.FIN_AUTOMAN_JURNAL"

        sqlCmd.Parameters.Add("@tipe_trans", SqlDbType.Char).Value = tipeT
        sqlCmd.Parameters.Add("@no_inv", SqlDbType.Char).Value = noG
        sqlCmd.ExecuteNonQuery()
    End Sub

    Public Sub cancel_click()
        STATE = ""
        btnadd = True
        btnEdit = True
        btnCancel = False
        btnDelete = False
        btnSave = False
        setStatus()
        Me.Enabled = False
        clear()
        loadData("XXX")
    End Sub

    Private Sub cek()
        isvalid = True
        If lookSupplier.EditValue = vbNullString Then
            isvalid = False
            DxErrorProvider1.SetError(lookSupplier, "Supplier tidak boleh kosong.")
        Else
            DxErrorProvider1.SetError(lookSupplier, "")
        End If
        If lookPO.EditValue = vbNullString Then
            isvalid = False
            DxErrorProvider1.SetError(lookPO, "No. PO tidak boleh kosong.")
        Else
            DxErrorProvider1.SetError(lookPO, "")
        End If
        If lookValuta.EditValue = vbNullString Then
            isvalid = False
            DxErrorProvider1.SetError(lookValuta, "Valuta tidak boleh kosong.")
        Else
            DxErrorProvider1.SetError(lookValuta, "")
        End If
        If Not lookValuta.EditValue = "IDR" Then
            If txtValuta.EditValue = 1 Then
                isvalid = False
                DxErrorProvider1.SetError(txtValuta, "Valuta non rupiah tidak boleh 1.")
            Else
                DxErrorProvider1.SetError(txtValuta, "")
            End If
        ElseIf lookValuta.EditValue = "IDR" Then
            If txtValuta.EditValue > 1 Then
                isvalid = False
                DxErrorProvider1.SetError(txtValuta, "Valuta rupiah harus 1.")
            Else
                DxErrorProvider1.SetError(txtValuta, "")
            End If
        End If
        If gvHPP.RowCount = 0 Then
            If STATE = "ADD" Then
                isvalid = False
                err &= "Detil belum diisi." & vbCrLf
            End If
        End If
    End Sub

    Private Sub loadSatuan()
        If Not dsHPP.Tables("Satuan") Is Nothing Then dsHPP.Tables("Satuan").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("select Kode_Satuan, Nama_Satuan from SIF.dbo.SIF_Satuan ", sqlconn)) '<- query buat ditampilkan di LOV
        daLookUp.Fill(dsHPP, "Satuan")
        lookSatuan.DataSource = dsHPP.Tables("Satuan")
        lookSatuan.DisplayMember = "Kode_Satuan"
        lookSatuan.ValueMember = "Kode_Satuan"
    End Sub

    Private Sub loadSupplier()
        If Not dsHPP.Tables("Supplier") Is Nothing Then dsHPP.Tables("Supplier").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("select Kode_Supplier, Nama_Supplier from SIF.dbo.SIF_Supplier  order by Nama_Supplier", sqlconn)) '<- query buat ditampilkan di LOV
        daLookUp.Fill(dsHPP, "Supplier")
        lookSupplier.Properties.DataSource = dsHPP.Tables("Supplier")
        lookSupplier.Properties.DisplayMember = "Nama_Supplier"
        lookSupplier.Properties.ValueMember = "Kode_Supplier"
    End Sub

    Private Sub loadPO()


        'If lookSupplier.EditValue = "" Then

        '    daLookUp = New SqlDataAdapter(New SqlCommand("select no_po, tgl_po, jml_val_trans from PURC.dbo.PURC_PO where tipe_trans = 'JPP-KUT-01' or tipe_trans = 'JPP-KUT-02'  order by tgl_po desc", sqlconn)) '<- query buat ditampilkan di LOV
        '    daLookUp.Fill(dsHPP, "PO")
        '    lookPO.Properties.DataSource = dsHPP.Tables("PO")
        '    lookPO.Properties.DisplayMember = "no_po"
        '    lookPO.Properties.ValueMember = "no_po"
        'Else
        If STATE = "ADD" Then
            If Not dsHPP.Tables("PO") Is Nothing Then dsHPP.Tables("PO").Clear()
            daLookUp = New SqlDataAdapter(New SqlCommand("select KD_SUPPLIER,no_po, tgl_po, jml_val_trans from PURC.dbo.PURC_PO where  no_po not in (select ISNULL(no_ref1,0) no_ref1 from FIN.dbo.FIN_PEMBELIAN )AND kd_supplier = '" & lookSupplier.EditValue & "'  order by tgl_po desc", sqlconn)) '<- query buat ditampilkan di LOV
            daLookUp.Fill(dsHPP, "PO")
            lookPO.Properties.DataSource = dsHPP.Tables("PO")
            lookPO.Properties.DisplayMember = "no_po"
            lookPO.Properties.ValueMember = "no_po"
        ElseIf STATE = "EDIT" Then
            If Not dsHPP.Tables("PO") Is Nothing Then dsHPP.Tables("PO").Clear()
            daLookUp = New SqlDataAdapter(New SqlCommand("select no_ref1 as no_po, tgl_inv as tgl_po, jml_val_trans  from FIN.dbo.FIN_PEMBELIAN where no_inv='" & frmCari.row("No. Transaksi") & "' and kd_supplier = '" & lookSupplier.EditValue & "'  order by tgl_po desc", sqlconn)) '<- query buat ditampilkan di LOV
            daLookUp.Fill(dsHPP, "PO")
            lookPO.Properties.DataSource = dsHPP.Tables("PO")
            lookPO.Properties.DisplayMember = "no_po"
            lookPO.Properties.ValueMember = "no_po"

        End If

        'ElseIf STATE = "EDIT" Then

        '    daLookUp = New SqlDataAdapter(New SqlCommand("select no_po, tgl_po, jml_val_trans from PURC.dbo.PURC_PO where no_po = '" & lookPO.EditValue & "'", sqlconn)) '<- query buat ditampilkan di LOV
        '    daLookUp.Fill(dsHPP, "PO")
        '    lookPO.Properties.DataSource = dsHPP.Tables("PO")
        '    lookPO.Properties.DisplayMember = "no_po"
        '    lookPO.Properties.ValueMember = "no_po"



    End Sub

    Private Sub loadValuta()
        If Not dsHPP.Tables("Valuta") Is Nothing Then dsHPP.Tables("Valuta").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("select Kode_Valuta, Nama_Valuta from SIF.dbo.SIF_Valuta", sqlconn)) '<- query buat ditampilkan di LOV
        daLookUp.Fill(dsHPP, "Valuta")
        lookValuta.Properties.DataSource = dsHPP.Tables("Valuta")
        lookValuta.Properties.DisplayMember = "Nama_Valuta"
        lookValuta.Properties.ValueMember = "Kode_Valuta"
    End Sub

    Private Sub loadBarang()
        If Not dsHPP.Tables("Barang") Is Nothing Then dsHPP.Tables("Barang").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("select Kode_Barang , Nama_Barang from SIF.dbo.SIF_Barang where kd_jns_persd in (1,2,3,4,6)", sqlconn)) '<- query buat ditampilkan di LOV
        daLookUp.Fill(dsHPP, "Barang")
        lookBrg.DataSource = dsHPP.Tables("Barang")
        lookBrg.DisplayMember = "Nama_Barang"
        lookBrg.ValueMember = "Kode_Barang"
    
    End Sub

    Private Sub aFormHPP_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)
        loadBarang()

        loadPO()
        loadSatuan()
        loadSupplier()
        loadValuta()
        dteTanggal.EditValue = getTanggal()
        txtValuta.EditValue = 1
    End Sub
    Public Sub edit()
        STATE = "EDIT"

        loadData(transaksiid)

        If Not (dsHPP.Tables("HPP").Rows(0)("no_posting").ToString = vbNullString Or dsHPP.Tables("HPP").Rows(0)("no_posting").ToString = "") Then
            MsgBox("No. transaski: " & txtNoTrans.EditValue & " telah diposting. Data tidak dapat diubah.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
            btnSave = False
            btnCancel = True
            btnadd = False
            btnEdit = False
            btnDelete = False
            setStatus()
            controlOff(True)
        Else
            btnSave = True
            btnCancel = True
            btnadd = False
            btnEdit = False
            btnDelete = True
            setStatus()
            controlOff(False)
        End If


    End Sub
    Public Sub edit_click()
        STATE = "EDIT"
        gvq = True
        dsCari = New DataSet
        daCari = New SqlDataAdapter(New SqlCommand("select tgl_inv as 'Tanggal Transaksi', no_inv as 'No. Transaksi', no_ref1 as 'No. Ref', keterangan as 'Keterangan', jml_val_trans as 'Total' from FIN.dbo.FIN_PEMBELIAN ", sqlconn)) '<- query buat ditampilkan di LOV
        daCari.Fill(dsCari, "LookHPP")
        frmCari.set_dso(dsCari.Tables("LookHPP"))
        frmCari.GV.Columns("Tanggal Transaksi").DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        frmCari.GV.Columns("Total").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        frmCari.GV.Columns("Tanggal Transaksi").DisplayFormat.FormatString = "d MMMM yyyy"
        frmCari.GV.Columns("Total").DisplayFormat.FormatString = "n2"
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then
            loadData(frmCari.row("No. Transaksi"))


            If Not (dsHPP.Tables("HPP").Rows(0)("no_posting").ToString = vbNullString Or dsHPP.Tables("HPP").Rows(0)("no_posting").ToString = "") Then
                MsgBox("No. transaski: " & txtNoTrans.EditValue & " telah diposting. Data tidak dapat diubah.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
                btnSave = False
                btnCancel = True
                btnadd = False
                btnEdit = False
                btnDelete = False
                setStatus()
                controlOff(True)
            Else
                btnSave = True
                btnCancel = True
                btnadd = False
                btnEdit = False
                btnDelete = True
                setStatus()
                controlOff(False)
            End If
        Else
            cancel_click()
        End If
    End Sub

    Public Sub delete_click()
        If Not txtNoTrans.EditValue = vbNullString Then
            If MsgBox("Hapus transaski HPP dengan nomor " & txtNoTrans.EditValue & " ?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "DELETE") = MsgBoxResult.Yes Then
                'STATE = "DELETE"
                For Each rw As DataRow In dsHPP.Tables("HPP").Rows
                    'Dim sqlx As New SqlCommand("delete from fin.dbo.fin_jurnal where no_jur='" & txtNoTrans.EditValue & "'", sqlconn, BTRANS)
                    'sqlx.ExecuteNonQuery()
                    rw.Delete()
                Next
                For Each rw As DataRow In dsHPP.Tables("HPPD").Rows
                    'Dim sqlx As New SqlCommand("delete from fin.dbo.fin_jurnal_D where no_jur='" & txtNoTrans.EditValue & "'", sqlconn, BTRANS)
                    'sqlx.ExecuteNonQuery()
                    rw.Delete()
                Next
                save_click(True)
            End If
        End If
    End Sub

    Private Sub refreshNomer()
        Dim i As Integer = 1
        If gvHPP.RowCount = 0 Then
            Exit Sub
        Else
            For j As Integer = 0 To gvHPP.RowCount - 1
                gvHPP.GetDataRow(j).Item("no_seq") = i
                i += 1
            Next
        End If
    End Sub

    Private Sub gcHPP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles gcHPP.KeyDown
        If e.KeyCode = Keys.Delete Then
            If gvHPP.GetSelectedRows.Count > 0 Then
                gvHPP.DeleteSelectedRows()
                refreshNomer()
            End If
        End If
    End Sub

    Private Sub gvHPP_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gvHPP.CellValueChanged
        Dim View As ColumnView = sender
        If e.Column Is jml_val_trans Then
            If e.Value.ToString = vbNullString Or e.Value.ToString = "" Then
                View.SetRowCellValue(e.RowHandle, "jml_rp_trans", 0)
            Else
                View.SetRowCellValue(e.RowHandle, "jml_rp_trans", e.Value * txtValuta.EditValue)
            End If
        End If
        




        If e.Column Is kd_stok Then
            If Not e.Value Is Nothing Then
                drHPP = New SqlCommand("SELECT rek_biaya FROM SIF.dbo.SIF_Barang WHERE Kode_Barang = '" & e.Value & "'", sqlconn).ExecuteReader
                drHPP.Read()
                View.SetRowCellValue(e.RowHandle, "kd_buku_besar", drHPP.Item("rek_biaya"))
                drHPP.Close()

            End If
        End If

        If e.Column Is qtyku Then

            If e.Value.ToString = vbNullString Or e.Value.ToString = "" Or e.Value = 0 Then
                View.SetRowCellValue(e.RowHandle, "qtyku", 0)
            Else

                View.SetRowCellValue(e.RowHandle, "jml_val_trans", e.Value * View.GetRowCellValue(e.RowHandle, "harga"))
                View.SetRowCellValue(e.RowHandle, "qtyi", View.GetRowCellValue(e.RowHandle, "qtyi") - e.Value)


            End If
        End If

        If e.Column Is qtyi Then

            'If e.Value.ToString = vbNullString Or e.Value.ToString = "" Or e.Value = 0 Then
            '    View.SetRowCellValue(e.RowHandle, "qtyi", 0)
            'Else


            View.SetRowCellValue(e.RowHandle, "total", e.Value * View.GetRowCellValue(e.RowHandle, "hargai"))

            'End If
        End If

        If e.Column Is harga Then
            If e.Value.ToString = vbNullString Or e.Value.ToString = "" Then
                View.SetRowCellValue(e.RowHandle, "harga", 0)
            Else
                View.SetRowCellValue(e.RowHandle, "jml_val_trans", e.Value * View.GetRowCellValue(e.RowHandle, "qtyku"))
            End If
        End If
    End Sub

    Private Sub gvHPP_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gvHPP.InitNewRow
        Dim View As ColumnView = sender
        View.SetRowCellValue(e.RowHandle, View.Columns("no_seq"), gvHPP.RowCount + 1)
        View.SetRowCellValue(e.RowHandle, View.Columns("jml_val_trans"), 0)
        View.SetRowCellValue(e.RowHandle, View.Columns("satuan"), "BUAH")
    End Sub

    Private Sub gvHPP_InvalidValueException(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs) Handles gvHPP.InvalidValueException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.DisplayError
    End Sub

    Private Sub gvHPP_ValidatingEditor(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs) Handles gvHPP.ValidatingEditor
        Dim vx As GridView = sender

        If vx.FocusedColumn.FieldName = "jml_val_trans" Then
            If Not (e.Value = vbNull) Then
                If e.Value = 0 Then
                    e.Valid = False
                    e.ErrorText = "Tolong isi detil nominal Jumlah."
                End If
            Else
                'e.Value = 0
            End If
        End If

        If vx.FocusedColumn.FieldName = "qty" Then
            If Not (e.Value = vbNull) Then
                If e.Value = 0 Then
                    e.Valid = False
                    e.ErrorText = "Tolong isi detil Qty Realisasi."
                End If
            Else
                'e.Value = 0
            End If
        End If

        If vx.FocusedColumn.FieldName = "harga" Then
            If Not (e.Value = vbNull) Then
                If e.Value = 0 Then
                    e.Valid = False
                    e.ErrorText = "Tolong isi detil Harga Realisasi."
                End If
                'Else
                '    e.Value = 0
            End If
        End If

        If vx.FocusedColumn.FieldName = "kd_stok" Then
            If e.Value = vbNull Then
                e.Valid = False
                e.ErrorText = "Tolong isi Nama Barang."
            End If
        End If
    End Sub

    Private Sub lookSupplier_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookSupplier.EditValueChanged
        loadPO()
    End Sub

    Private Sub lookPO_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookPO.EditValueChanged
        If STATE = "ADD" Then
            If Not dsHPP1.Tables("tipetrans") Is Nothing Then dsHPP1.Tables("tipetrans").Clear()
            daHPP1 = New SqlDataAdapter(New SqlCommand("SELECT * from PURC.dbo.PURC_PO where no_po='" & lookPO.EditValue & "'", sqlconn)) '<- query buat ditampilkan di LOV
            daHPP1.Fill(dsHPP1, "tipetrans")
            cektipe = dsHPP1.Tables("tipetrans").Rows(0).Item("tipe_trans")


            If Not lookPO.EditValue = vbNullString Then

                'If Not dsHPP1.Tables("cek") Is Nothing Then dsHPP1.Tables("cek").Clear()
                drHPP = New SqlCommand("SELECT kd_valuta, kurs_valuta FROM PURC.dbo.PURC_PO WHERE no_po = '" & lookPO.EditValue & "'", sqlconn).ExecuteReader
                drHPP.Read()
                lookValuta.EditValue = drHPP.Item("kd_valuta")
                txtValuta.EditValue = drHPP.Item("kurs_valuta")
                drHPP.Close()
                drHPP = New SqlCommand("SELECT kd_bb_besar1, kd_bb_besar2 FROM SIF.dbo.SIF_TIPE_TRANS_D WHERE tipe_trans = 'JPP-KUT-04' AND tipe_desc = 'HUTANG'", sqlconn).ExecuteReader
                drHPP.Read()
                If lookValuta.EditValue = "IDR" Then
                    bukubesar = drHPP.Item("kd_bb_besar1")
                Else
                    bukubesar = drHPP.Item("kd_bb_besar2")
                End If
                drHPP.Close()



                'If Not dsHPP1.Tables("cek") Is Nothing Then dsHPP1.Tables("cek").Clear()
                'daHPP1 = New SqlDataAdapter(New SqlCommand("SELECT * from FIN.dbo.FIN_PEMBELIAN a,FIN.dbo.FIN_PEMBELIAN_d b where a.no_ref1='" & lookPO.EditValue & "' and a.no_inv=b.no_inv", sqlconn)) '<- query buat ditampilkan di LOV
                'daHPP1.Fill(dsHPP1, "cek")

                'If dsHPP1.Tables("cek").Rows.Count = 0 Then
                'STATE = "ADD"

                If cektipe = "JPP-KUT-02" Then
                    dsHPP.Tables("HPPD").Clear()
                    Dim dr As DataRow
                    drHPP = New SqlCommand("SELECT distinct A.tipe_trans,c.rek_biaya,a.flag_ppn, b.no_seq, b.kd_stok, b.kd_satuan, E.qty, F.harga_BARU harga, (SELECT rek_biaya FROM SIF.dbo.SIF_Barang WHERE Kode_barang = b.kd_jasa) biaya " & _
    "FROM PURC.dbo.PURC_PO a, PURC.dbo.PURC_PO_D_bARANG b,SIF.dbo.SIF_Barang c,PURC.dbo.PURC_PR_D_BARANG D,PURC.dbo.PURC_DPM_D_BARANG E,PURC.DBO.PURC_CHOICE_SUPP_D F,PURC.DBO.PURC_CHOICE_SUPP G " & _
    "WHERE a.no_po = b.no_po AND a.no_po = '" & lookPO.EditValue & "' AND A.NO_PR=D.NO_PR AND E.no_dpm=D.no_dpm AND G.kd_supp_pilih=A.kd_supplier AND G.no_pr=A.no_pR AND F.no_csp=G.no_csp " & _
    "AND c.Kode_barang=b.kd_stok AND B.kd_stok=D.kd_stok AND B.kd_jasa=D.kd_jasa AND D.kd_jasa=E.kd_jasa", sqlconn).ExecuteReader

                    While drHPP.Read()

                        dr = dsHPP.Tables("HPPD").NewRow
                        ppn = drHPP.Item("flag_ppn")
                        tipetrans = drHPP.Item("tipe_trans")
                        dr("tipe_trans") = drHPP.Item("tipe_trans")
                        dr("kd_stok") = drHPP.Item("kd_stok")
                        dr("satuan") = drHPP.Item("kd_satuan")
                        dr("qtyi") = drHPP.Item("qty")
                        dr("hargai") = drHPP.Item("harga")
                        dr("total") = drHPP.Item("harga") * drHPP.Item("qty")
                        dr("kd_buku_besar") = drHPP.Item("biaya")
                        dr("qty") = 0
                        dr("harga") = drHPP.Item("harga")
                        dr("jml_val_trans") = 0
                        dsHPP.Tables("HPPD").Rows.Add(dr)

                    End While
                    drHPP.Close()

                    refreshNomer()
                Else
                    dsHPP.Tables("HPPD").Clear()
                    Dim dr As DataRow
                    drHPP = New SqlCommand("SELECT  distinct b.tipe_trans,H.rek_biaya,a.flag_ppn, b.no_seq, b.kd_stok, b.kd_satuan, b.qty, b.harga harga " & _
    "FROM PURC.dbo.PURC_PO a inner join   PURC.dbo.PURC_PO_D b on a.no_po=b.no_po and a.tipe_trans=b.tipe_trans " & _
  "inner join  SIF.dbo.SIF_Barang H ON H.Kode_Barang=B.kd_stok " & _
"where b.no_po='" & lookPO.EditValue & "'", sqlconn).ExecuteReader

                    While drHPP.Read()

                        dr = dsHPP.Tables("HPPD").NewRow
                        ppn = drHPP.Item("flag_ppn")
                        tipetrans = drHPP.Item("tipe_trans")
                        dr("tipe_trans") = drHPP.Item("tipe_trans")
                        dr("kd_stok") = drHPP.Item("kd_stok")
                        dr("satuan") = drHPP.Item("kd_satuan")
                        dr("qtyi") = drHPP.Item("qty")
                        dr("hargai") = drHPP.Item("harga")
                        dr("total") = drHPP.Item("harga") * drHPP.Item("qty")
                        dr("kd_buku_besar") = drHPP.Item("rek_biaya")
                        dr("qty") = 0
                        dr("harga") = drHPP.Item("harga")
                        dr("jml_val_trans") = 0
                        dsHPP.Tables("HPPD").Rows.Add(dr)

                    End While
                    drHPP.Close()

                    refreshNomer()
                End If
            End If
        End If
        'End If

        'ElseIf dsHPP1.Tables("cek").Rows.Count > 0 Then
        '        STATE = "EDIT"
        '        If STATE = "EDIT" Then
        '            loadPO()

        '            If Not dsHPP1.Tables("cek2") Is Nothing Then dsHPP1.Tables("cek2").Clear()
        '            daHPP1 = New SqlDataAdapter(New SqlCommand("SELECT a.no_inv,b.qty qty,a.jml_val_trans from FIN.dbo.FIN_PEMBELIAN a,FIN.dbo.FIN_PEMBELIAN_d b where a.no_ref1='" & lookPO.EditValue & "' and a.no_inv=b.no_inv", sqlconn))
        '            daHPP1.Fill(dsHPP1, "cek2")
        '            If dsHPP1.Tables("cek2").Rows.Count > 0 Then


        '                transaksiid = dsHPP1.Tables("cek2").Rows(0).Item("no_inv")

        '                loadData(transaksiid)
        '            Else
        '                transaksiid = ""

        '                loadData(transaksiid)
        '            End If
        '        End If

    End Sub

    


    Private Sub lookValuta_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lookValuta.EditValueChanged
        If lookValuta.EditValue = "IDR" Then
            txtValuta.EditValue = 1
            txtValuta.Properties.ReadOnly = True
        Else
            txtValuta.Properties.ReadOnly = False
        End If
    End Sub

    'Private Sub lookPO_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles lookPO.QueryPopUp
    '    loadPO()
    'End Sub

    Private Sub txtValuta_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtValuta.EditValueChanged
        If txtValuta.EditValue = 0 Then
            txtValuta.EditValue = 1
        End If
    End Sub

    'Private Sub lookBrg_EditValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lookBrg.EditValueChanged

    'End Sub

    Private Sub pnlPO_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlPO.Paint

    End Sub
End Class