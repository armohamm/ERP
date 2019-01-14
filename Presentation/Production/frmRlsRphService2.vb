﻿Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmRlsRphService2
    Dim dsete, ds1, ds2 As New DataSet
    Dim dadbe, da1, da2, da3, da4 As SqlDataAdapter
    Dim DA As SqlDataAdapter
    Dim DAD As SqlDataAdapter
    Dim DTR, dr As SqlDataReader
    Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode
    Dim obj As Object
    Dim prn As frmMain
    Public con_open As Boolean = True
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Dim myBuilder As New SqlCommandBuilder

    Dim lng As Long
    Public Sub call_procedure()
        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader
        'Try
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "PROD.dbo.prodp_ins_spk_serv"
        sqlCmd.Parameters.Add("@vno_rph", SqlDbType.Char).Value = TextEdit1.Text 'frmCari.row("NO TRANS")
        dr = sqlCmd.ExecuteReader
        dr.Close()

        Dim sqlCmd2 As New SqlCommand
        sqlCmd2.Connection = sqlconn
        sqlCmd2.CommandType = CommandType.StoredProcedure
        sqlCmd2.CommandText = "PROD.dbo.prodp_ins_spbb_serv"
        sqlCmd2.Parameters.Add("@vno_rph", SqlDbType.Char).Value = TextEdit1.Text 'frmCari.row("NO TRANS")
        dr = sqlCmd2.ExecuteReader
        dr.Close()

        'Dim sqlCmd3 As New SqlCommand
        'sqlCmd3.Connection = sqlconn
        'sqlCmd3.CommandType = CommandType.StoredProcedure
        'sqlCmd3.CommandText = "PROD.dbo.prodp_ins_dpm"
        'sqlCmd3.Parameters.Add("@vno_rph", SqlDbType.Char).Value = TextEdit1.Text 'frmCari.row("NO TRANS")
        'dr = sqlCmd3.ExecuteReader
        'dr.Close()

        'Dim sqlCmd4 As New SqlCommand
        'sqlCmd4.Connection = sqlconn
        'sqlCmd4.CommandType = CommandType.StoredProcedure
        'sqlCmd4.CommandText = "PROD.dbo.prodp_ins_barcode"
        'sqlCmd4.Parameters.Add("@vno_rph", SqlDbType.Char).Value = TextEdit1.Text 'frmCari.row("NO TRANS")
        'dr = sqlCmd4.ExecuteReader
        'dr.Close()

        'Dim sqlCmd5 As New SqlCommand
        'sqlCmd5.Connection = sqlconn
        'sqlCmd5.CommandType = CommandType.StoredProcedure
        'sqlCmd5.CommandText = "PROD.dbo.prodp_ins_hsl_prod"
        'sqlCmd5.Parameters.Add("@vno_rph", SqlDbType.Char).Value = TextEdit1.Text 'frmCari.row("NO TRANS")
        'dr = sqlCmd5.ExecuteReader
        'dr.Close()

        'Dim sqlCmd6 As New SqlCommand
        'sqlCmd6.Connection = sqlconn
        'sqlCmd6.CommandType = CommandType.StoredProcedure
        'sqlCmd6.CommandText = "PROD.dbo.prodp_ins_qty_prod_in"
        'sqlCmd6.Parameters.Add("@vno_rph", SqlDbType.Char).Value = TextEdit1.Text 'frmCari.row("NO TRANS")
        'dr = sqlCmd6.ExecuteReader
        'dr.Close()

        showMessages("Saved...")
    End Sub
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Private Sub frmRlsRph_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()

        State = "EDIT"

        If Not ds1.Tables("JDWKRJ") Is Nothing Then ds1.Tables("JDWKRJ").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='JDWKRJ'", sqlconn))
        da1.Fill(ds1, "JDWKRJ")
        txtJadwal.Properties.DataSource = ds1.Tables("JDWKRJ")

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  Nama_Jenis,Jenis_Group,Nama_Jenis_Group,kd_jenis,no_rph, Nama_Merk, Nama_Tipe, Warna,kd_tipe,kd_kain, " & _
                                                                   "uk90 = sum(case ukuran when '90' then jumlah else 0 end), " & _
                                                                   "uk100 = sum(case ukuran when '100' then jumlah else 0 end), " & _
                                                                   "uk120 = sum(case ukuran when '120' then jumlah else 0 end), " & _
                                                                   "uk140 = sum(case ukuran when '140' then jumlah else 0 end), " & _
                                                                   "uk150 = sum(case ukuran when '150' then jumlah else 0 end), " & _
                                                                   "uk160 = sum(case ukuran when '160' then jumlah else 0 end), " & _
                                                                   "uk180 = sum(case ukuran when '180' then jumlah else 0 end), " & _
                                                                   "uk200 = sum(case ukuran when '200' then jumlah else 0 end), " & _
                                                                   "ukKHS = sum(case  when ukuran NOT IN ('90','100','120','140','150','160','180','200') then jumlah else 0 end), " & _
                                                                   "(Select SUBSTRING(( Select ',' + Nama_Ukuran + '/' + CONVERT(varchar(10),FLOOR(jumlah)) " & _
                                                                   "from PROD.dbo.PRODV_RCN_PROD S1 where ukuran NOT IN ('90','100','120','140','150','160','180','200')" & _
                                                                   "and S1.kd_jenis=s2.kd_jenis and S1.kd_tipe = s2.kd_tipe and S1.kd_kain=s2.kd_kain  For XML PATH ('')),2,500)) as ket, " & _
                                                                   "(sum(case ukuran when '90' then jumlah else 0 end)+ sum(case ukuran when '100' then jumlah else 0 end)+" & _
                                                                   "sum(case ukuran when '120' then jumlah else 0 end)+" & _
                                                                   "sum(case ukuran when '140' then jumlah else 0 end)+" & _
                                                                   "sum(case ukuran when '150' then jumlah else 0 end)+sum(case ukuran when '160' then jumlah else 0 end)+" & _
                                                                   "sum(case ukuran when '180' then jumlah else 0 end)+" & _
                                                                   "sum(case ukuran when '200' then jumlah else 0 end)+" & _
                                                                   "sum(case  when ukuran NOT IN ('90','100','120','140','150','160','180','200') then jumlah else 0 end)) as Total " & _
                                                                   "from PROD.dbo.PRODV_RCN_PROD s2 " & _
                                                                   "where kd_departemen = '" & kddep & "' " & _
                                                                   "and no_rph = '' " & _
                                                                   "group by  Nama_Jenis,Jenis_Group,Nama_Jenis_Group,kd_jenis,no_rph, Nama_Merk, Nama_Tipe, Warna ,kd_tipe,kd_kain", sqlconn))
        dsete.Reset()
        gc.Refresh()
        DA.Fill(dsete, "SALES_SO_D")
        gc.DataSource = dsete.Tables("SALES_SO_D")
        jenis.Group()

        txtTgl_Rph.Text = Format(Now, "dd/MM/yyyy")
        prn = getParent(Me)
        'Me.Enabled = True
    End Sub

    Public Sub add_click()

        State = "EDIT"

        If con_open = False Then
            sqlconn.Open()
        End If

        tampil()

    End Sub

    Public Sub edit_click()
        State = "EDIT"

        If con_open = False Then
            sqlconn.Open()
        End If

        tampil()

    End Sub

    Public Sub cetak_click()
        'If Trim(txtNoDPB.Text) <> "" And State = "EDIT" Then
        'callReport(App_Path() & "\report\rptPOM.rpt", "", "Nomor=" & Trim(txtNoPO.Text))

        'Dim notrans As String = Trim(txtNoDPB.Text)
        callReport(App_Path() & "\report\crzRlsRph2.rpt", "", "NoRPH=" & TextEdit1.Text)
        'Else
        'MessageBox.Show("Pilih data yang akan dicetak dalam mode EDIT!")
        'End If
    End Sub
    Public Sub tampil_awal()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  Nama_Jenis,Jenis_Group,Nama_Jenis_Group,kd_jenis,no_rph, Nama_Merk, Nama_Tipe, Warna,kd_tipe,kd_kain, " & _
                                                                   "uk90 = sum(case ukuran when '90' then jumlah else 0 end), " & _
                                                                   "uk100 = sum(case ukuran when '100' then jumlah else 0 end), " & _
                                                                   "uk120 = sum(case ukuran when '120' then jumlah else 0 end), " & _
                                                                   "uk140 = sum(case ukuran when '140' then jumlah else 0 end), " & _
                                                                   "uk150 = sum(case ukuran when '150' then jumlah else 0 end), " & _
                                                                   "uk160 = sum(case ukuran when '160' then jumlah else 0 end), " & _
                                                                   "uk180 = sum(case ukuran when '180' then jumlah else 0 end), " & _
                                                                   "uk200 = sum(case ukuran when '200' then jumlah else 0 end), " & _
                                                                   "ukKHS = sum(case  when ukuran NOT IN ('90','100','120','140','150','160','180','200') then jumlah else 0 end), " & _
                                                                   "(Select SUBSTRING(( Select ',' + Nama_Ukuran + '/' + CONVERT(varchar(10),FLOOR(jumlah)) " & _
                                                                   "from PROD.dbo.PRODV_RCN_PROD S1 where ukuran NOT IN ('90','100','120','140','150','160','180','200')" & _
                                                                   "and S1.kd_jenis=s2.kd_jenis and S1.kd_tipe = s2.kd_tipe and S1.kd_kain=s2.kd_kain  For XML PATH ('')),2,500)) as ket, " & _
                                                                   "(sum(case ukuran when '90' then jumlah else 0 end)+ sum(case ukuran when '100' then jumlah else 0 end)+" & _
                                                                   "sum(case ukuran when '120' then jumlah else 0 end)+" & _
                                                                   "sum(case ukuran when '140' then jumlah else 0 end)+" & _
                                                                   "sum(case ukuran when '150' then jumlah else 0 end)+sum(case ukuran when '160' then jumlah else 0 end)+" & _
                                                                   "sum(case ukuran when '180' then jumlah else 0 end)+" & _
                                                                   "sum(case ukuran when '200' then jumlah else 0 end)+" & _
                                                                   "sum(case  when ukuran NOT IN ('90','100','120','140','150','160','180','200') then jumlah else 0 end)) as Total " & _
                                                                   "from PROD.dbo.PRODV_RCN_PROD s2 " & _
                                                                   "where kd_departemen = '" & kddep & "' " & _
                                                                   "and no_rph = '' " & _
                                                                   "group by  Nama_Jenis,Jenis_Group,Nama_Jenis_Group,kd_jenis,no_rph, Nama_Merk, Nama_Tipe, Warna ,kd_tipe,kd_kain", sqlconn))

        dsete.Reset()
        gc.Refresh()
        DA.Fill(dsete, "SALES_SO_D")
        gc.DataSource = dsete.Tables("SALES_SO_D")
        gc.Show()
        jenis.Group()


    End Sub
    Public Sub save_click()
        If TextEdit1.EditValue <> "" Then
            call_procedure()

            gc.DataSource = dsete.Tables("SALES_SO_D")
            gc.Show()

            btnSave = False
            btnadd = False
            btnEdit = True
            'btnDelete = True
            btnCancel = True
            setStatus()
            'Me.Enabled = True

            sqlconn.Close()
            con_open = False
            'MsgBox("closed..")
        End If

    End Sub

    Public Sub tampil()

        Dim qstr As String = "select no_rph as [NO TRANS], kd_jadwal as [JADWAL KERJA], tanggal [Tanggal Rencana Produksi],jns_produksi [Jenis Produksi] from PROD.dbo.PRODV_RCN_PROD " & _
                " where kd_departemen='" & kddep & "' and jns_produksi = 'SERVICE'" & _
                " group by no_rph, kd_jadwal, tanggal, jns_produksi order by tanggal desc, no_rph desc "

        'Dim qstr As String = "select no_rph as [NO TRANS], kd_jadwal as [JADWAL KERJA], tanggal [Tanggal Rencana Produksi],jns_produksi [Jenis Produksi] from PROD.dbo.PRODV_RCN_PROD " & _
        '         " where kd_departemen = '" & kddep & "' group by no_rph, kd_jadwal, tanggal, jns_produksi "
        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(qstr, sqlconn))
        If Not ds1.Tables("lookup_so") Is Nothing Then ds1.Tables("lookup_so").Clear()
        da1.Fill(ds1, "lookup_so")
        frmCari.set_dso(ds1.Tables("lookup_so"))
        'ds3.Tables("lookup_so").Columns(0).DateTimeMode = "dd/MM/yyyy"
        frmCari.set_dso(ds1.Tables("lookup_so"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  Nama_Jenis,Jenis_Group,Nama_Jenis_Group,kd_jenis,no_rph, Nama_Merk, Nama_Tipe, Warna,kd_tipe,kd_kain," & _
                                                                        "uk90 = sum(case ukuran when '90' then jumlah else 0 end), " & _
                                                                        "uk100 = sum(case ukuran when '100' then jumlah else 0 end), " & _
                                                                        "uk120 = sum(case ukuran when '120' then jumlah else 0 end), " & _
                                                                        "uk140 = sum(case ukuran when '140' then jumlah else 0 end), " & _
                                                                        "uk150 = sum(case ukuran when '150' then jumlah else 0 end), " & _
                                                                        "uk160 = sum(case ukuran when '160' then jumlah else 0 end), " & _
                                                                        "uk180 = sum(case ukuran when '180' then jumlah else 0 end), " & _
                                                                        "uk200 = sum(case ukuran when '200' then jumlah else 0 end), " & _
                                                                        "ukKHS = sum(case  when ukuran NOT IN ('90','100','120','140','150','160','180','200') then jumlah else 0 end), " & _
                                                                        "(Select SUBSTRING(( Select ',' + Nama_Ukuran + '/' + CONVERT(varchar(10),FLOOR(jumlah)) " & _
                                                                        "from PROD.dbo.PRODV_RCN_PROD S1 where ukuran NOT IN ('90','100','120','140','150','160','180','200') " & _
                                                                        "and no_rph = '" & frmCari.row("NO TRANS") & "' and S1.kd_jenis=s2.kd_jenis and S1.kd_tipe = s2.kd_tipe and S1.kd_kain=s2.kd_kain  For XML PATH ('')),2,500)) as ket, " & _
                                                                        "(sum(case ukuran when '90' then jumlah else 0 end)+ sum(case ukuran when '100' then jumlah else 0 end)+" & _
                                                                        "sum(case ukuran when '120' then jumlah else 0 end)+" & _
                                                                        "sum(case ukuran when '140' then jumlah else 0 end)+" & _
                                                                        "sum(case ukuran when '150' then jumlah else 0 end)+sum(case ukuran when '160' then jumlah else 0 end)+" & _
                                                                        "sum(case ukuran when '180' then jumlah else 0 end)+" & _
                                                                        "sum(case ukuran when '200' then jumlah else 0 end)+" & _
                                                                        "sum(case  when ukuran NOT IN ('90','100','120','140','150','160','180','200') then jumlah else 0 end)) as Total " & _
                                                                        "from PROD.dbo.PRODV_RCN_PROD s2 " & _
                                                                        "where kd_departemen = '" & kddep & "' and no_rph = '" & frmCari.row("NO TRANS") & "'" & _
                                                                        "group by  Nama_Jenis,Jenis_Group,Nama_Jenis_Group,kd_jenis,no_rph, Nama_Merk, Nama_Tipe, Warna ,kd_tipe,kd_kain", sqlconn))
            ds2.Reset()
            da2.Fill(ds2, "rph2")
            gc.DataSource = ds2.Tables("rph2")
            TextEdit1.EditValue = frmCari.row("NO TRANS")
            txtJadwal.EditValue = frmCari.row("JADWAL KERJA")
            txt_jns_prod.Text = IIf(frmCari.row("Jenis Produksi") Is System.DBNull.Value, "", frmCari.row("Jenis Produksi"))

            da3 = New SqlDataAdapter(New SqlCommand("select t.*, 0 kd_jenis, '' Warna,'' Kode_Merk,'' Nama_Merk,'' Kode_Tipe,'' Nama_Tipe,'' Nama_Jenis, " & _
                                                    " '' Nama_Barang,'' Sisa,'' Nama_Jenis_Group,'' Jenis_Group, '' tgl_kirim, '' prioritas, " & _
                                                    " '' Kode_Service,'' nama_service from PROD.dbo.PROD_rcn_prod_d t where 1=0", sqlconn))
            da3.Fill(ds2, "SALES")
            Dim qstr1 As String = "select v.*,s.nama_service, d.no_rph,d.jumlah, d.jml_indeks, SIF_Kain.Warna,SIF_Merk.Kode_Merk," & _
                                  "SIF_Merk.Nama_Merk, SIF_Tipe.Kode_Tipe, SIF_Tipe.Nama_Tipe " & _
                                  "from PROD.dbo.PROD_rcn_prod_d d " & _
                                  "left join PROD.dbo.PRODV_MON_SRV_2 v " & _
                                  "on v.No_sp=d.no_sp  and v.no_seq_d=d.no_sp_dtl " & _
                                  "and v.No_sp_box = d.no_seq " & _
                                  "left join SIF.dbo.SIF_Barang b " & _
                                  "on v.Kd_Stok = b.Kode_Barang  " & _
                                  "left join SIF.dbo.SIF_bom_service s " & _
                                  "on s.kd_service = v.Kode_Service " & _
                                  "INNER JOIN SIF.dbo.SIF_Kain SIF_Kain " & _
                                  "ON b.kd_kain = SIF_Kain.Kode_Kain " & _
                                  "LEFT OUTER JOIN SIF.dbo.SIF_Merk SIF_Merk " & _
                                  "ON b.kd_merk = SIF_Merk.Kode_Merk " & _
                                  "INNER JOIN SIF.dbo.SIF_Tipe SIF_Tipe " & _
                                  "ON b.kd_tipe = SIF_Tipe.Kode_Tipe " & _
                                  "where d.no_rph = '" & TextEdit1.Text & "' and v.Kode_Service IS NOT NULL"
            dr = New SqlClient.SqlCommand(qstr1, sqlconn).ExecuteReader

            While dr.Read
                Dim rw As DataRow = ds2.Tables("SALES").NewRow
                rw("no_rph") = dr.Item("no_rph")
                rw("no_sp") = dr.Item("No_sp")
                rw("no_sp_dtl") = dr.Item("no_seq_d")
                rw("no_seq") = dr.Item("No_sp_box")
                rw("Sisa") = CInt(dr.Item("Qty_Sisa_Prod")) + CInt(dr.Item("jumlah"))
                rw("kd_barang") = dr.Item("Kd_Stok")
                rw("Nama_Barang") = dr.Item("Nama_Barang")
                rw("Warna") = dr.Item("Warna")
                rw("Kode_Merk") = dr.Item("Kode_Merk")
                rw("Nama_Merk") = dr.Item("Nama_Merk")
                rw("Kode_Tipe") = dr.Item("Kode_Tipe")
                rw("Nama_Tipe") = dr.Item("Nama_Tipe")
                rw("Nama_Jenis") = dr.Item("Nama_Jenis")
                rw("kd_jenis") = dr.Item("kd_jenis")
                rw("Jenis_Group") = dr.Item("Jenis_Group")
                rw("Nama_Jenis_Group") = dr.Item("Nama_Jenis_Group")
                rw("tgl_kirim") = dr.Item("tgl_kirim")
                rw("prioritas") = dr.Item("prioritas")
                rw("Kode_Service") = dr.Item("Kode_Service")
                rw("nama_service") = dr.Item("nama_service")
                rw("jml_indeks") = dr.Item("jml_indeks")
                ds2.Tables("SALES").Rows.Add(rw)
            End While
            dr.Close()


            da4 = New SqlDataAdapter(New SqlCommand("Select b.*, br.Nama_Barang,br.Kd_Satuan " & _
                                                    "From SALES.dbo.SALES_BOM_SERVICE b " & _
                                                    "left Join SIF.dbo.SIF_Barang br " & _
                                                    "on br.Kode_Barang = b.KD_BARANG", sqlconn))
            da4.Fill(ds2, "SOBOX")
          


            btnSave = True
            btnadd = False
            btnEdit = False
            'btnDelete = True
            btnCancel = True
            setStatus()
            Me.Enabled = True



            Dim colM(4) As DataColumn
            Dim colD(4) As DataColumn
            Dim colD1(2) As DataColumn
            Dim colD2(2) As DataColumn
            Dim rel, rel1 As DataRelation

            colM(0) = ds2.Tables("rph2").Columns("no_rph")
            colM(1) = ds2.Tables("rph2").Columns("Jenis_Group")
            colM(2) = ds2.Tables("rph2").Columns("Nama_Merk")
            colM(3) = ds2.Tables("rph2").Columns("Nama_Tipe")
            colM(4) = ds2.Tables("rph2").Columns("Warna")

            colD(0) = ds2.Tables("SALES").Columns("no_rph")
            colD(1) = ds2.Tables("SALES").Columns("Jenis_Group")
            colD(2) = ds2.Tables("SALES").Columns("Nama_Merk")
            colD(3) = ds2.Tables("SALES").Columns("Nama_Tipe")
            colD(4) = ds2.Tables("SALES").Columns("Warna")

            colD1(0) = ds2.Tables("SALES").Columns("no_sp")
            colD1(1) = ds2.Tables("SALES").Columns("no_sp_dtl")
            colD1(2) = ds2.Tables("SALES").Columns("Kode_Service")


            colD2(0) = ds2.Tables("SOBOX").Columns("NO_SP")
            colD2(1) = ds2.Tables("SOBOX").Columns("NO_SEQ_SP")
            colD2(2) = ds2.Tables("SOBOX").Columns("Kd_Service")


            rel = ds2.Relations.Add("Detail Services", colM, colD, False)

            rel1 = ds2.Relations.Add("Detail BOM Services", colD1, colD2, False)


            gc.LevelTree.Nodes.Add("Detail Services", GV_RPH_Service).Nodes.Add("Detail BOM Services", GV_Bom_Serv)
        Else
            cancel()
        End If

    End Sub
    Sub cancel()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
    End Sub

    Public Sub cancel_click()

        cancel()
    End Sub

    Private Sub GV_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gv.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gv.InitNewRow
        gv.GetRow(e.RowHandle).item("No_seq") = gv.RowCount + 1
    End Sub

    Private Sub TextEdit1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextEdit1.Click
        tampil()
    End Sub

    Private Sub pnlAtas_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlAtas.Paint

    End Sub
End Class