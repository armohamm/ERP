Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmCetakRPHSaja
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
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = True
    Public State As String
    Dim myBuilder As New SqlCommandBuilder
    Dim lng As Long
    Public Sub call_procedure()
        pnlLoad.Visible = True
        pnlLoad.Refresh()
        Dim dr As SqlDataReader
        'Try
        If Not ds1.Tables("Barang_Prod") Is Nothing Then ds1.Tables("Barang_Prod").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("Select m.kd_barang, m.no_rph From PROD.dbo.PROD_rcn_prod_b m " & _
                                                "where m.no_rph = '" & TextEdit1.EditValue & "' ", sqlconn))
        da1.Fill(ds1, "Barang_Prod")
        For i = 0 To ds1.Tables("Barang_Prod").Rows.Count - 1
            Dim rows As DataRow = ds1.Tables("Barang_Prod").Rows(i)
            'sqlCmd.CommandTimeout = 0
            'MsgBox(rows.Item("kd_barang").ToString, MsgBoxStyle.Information)
            Dim sqlCmd As New SqlCommand
            sqlCmd.Connection = sqlconn
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.CommandText = "PROD.dbo.prodp_ins_spk_temp_table"
            sqlCmd.Parameters.Add("@vno_rph", SqlDbType.VarChar, 50).Value = rows.Item("no_rph") 'frmCari.row("NO TRANS")
            sqlCmd.Parameters.Add("@vkd_barang", SqlDbType.VarChar, 50).Value = rows.Item("kd_barang")
            dr = sqlCmd.ExecuteReader
            dr.Close()
        Next

        Dim sqlCmd7 As New SqlCommand
        sqlCmd7.CommandTimeout = 0
        sqlCmd7.Connection = sqlconn
        sqlCmd7.CommandType = CommandType.StoredProcedure
        sqlCmd7.CommandText = "PROD.dbo.prodp_ins_spk2_fix"
        sqlCmd7.Parameters.Add("@vno_rph", SqlDbType.Char).Value = TextEdit1.Text 'frmCari.row("NO TRANS")
        dr = sqlCmd7.ExecuteReader
        dr.Close()


        Dim sqlCmd2 As New SqlCommand
        sqlCmd2.CommandTimeout = 0
        sqlCmd2.Connection = sqlconn
        sqlCmd2.CommandType = CommandType.StoredProcedure
        sqlCmd2.CommandText = "PROD.dbo.prodp_ins_spbb3"
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

        Dim sqlCmd4 As New SqlCommand
        sqlCmd4.CommandTimeout = 0
        sqlCmd4.Connection = sqlconn
        sqlCmd4.CommandType = CommandType.StoredProcedure
        sqlCmd4.CommandText = "PROD.dbo.prodp_ins_barcode"
        sqlCmd4.Parameters.Add("@vno_rph", SqlDbType.Char).Value = TextEdit1.Text 'frmCari.row("NO TRANS")
        dr = sqlCmd4.ExecuteReader
        dr.Close()

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
        pnlLoad.Visible = False
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
        Dim sqlcmd As New SqlCommand
        sqlcmd.CommandText = "select  Nama_Jenis,Jenis_Group,Nama_Jenis_Group,kd_jenis,no_rph, Nama_Merk, Nama_Tipe, Warna,kd_tipe,kd_kain, " & _
                                                                   "uk90 = sum(case ukuran when '90' then jumlah else 0 end), " & _
                                                                   "uk100 = sum(case ukuran when '100' then jumlah else 0 end), " & _
                                                                   "uk120 = sum(case ukuran when '120' then jumlah else 0 end), " & _
                                                                   "uk140 = sum(case ukuran when '140' then jumlah else 0 end), " & _
                                                                   "uk150 = sum(case ukuran when '150' then jumlah else 0 end), " & _
                                                                   "uk160 = sum(case ukuran when '160' then jumlah else 0 end), " & _
                                                                   "uk180 = sum(case ukuran when '180' then jumlah else 0 end), " & _
                                                                   "uk200 = sum(case ukuran when '200' then jumlah else 0 end), " & _
                                                                   "ukKHS = sum(case  when ukuran NOT IN ('90','100','120','140','150','160','180','200') then jumlah else 0 end), " & _
                                                                   "(Select SUBSTRING(( Select ' ' + so.Keterangan  + '/' + CONVERT(varchar(10),FLOOR(d.jumlah)) + '*' " & _
                                                                        "from PROD.dbo.PRODV_RCN_PROD S1 " & _
                                                                        "inner join PROD.dbo.PROD_rcn_prod_d d " & _
                                                                        "on d.no_rph = s1.no_rph and d.kd_barang = s1.Kode_Barang " & _
                                                                        "inner join PROD.dbo.PRODV_MON_SO so " & _
                                                                        "on so.No_sp = d.no_sp and so.no_seq_d = d.no_sp_dtl  " & _
                                                                        "and so.No_sp_box = d.no_seq " & _
                                                                        "where s1.ukuran NOT IN ('90','100','120','140','150','160','180','200') " & _
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
                                                                   "group by  Nama_Jenis,Jenis_Group,Nama_Jenis_Group,kd_jenis,no_rph, Nama_Merk, Nama_Tipe, Warna ,kd_tipe,kd_kain order by Nama_Merk asc"
        sqlcmd.CommandTimeout = 0
        sqlcmd.Connection = sqlconn
        DA = New SqlClient.SqlDataAdapter(sqlcmd)
        'dsete.Reset()
        gc.Refresh()
        DA.Fill(dsete, "SALES_SO_D")
        gc.DataSource = dsete.Tables("SALES_SO_D")
        jenis.Group()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("Select b.Jenis_Group,b.Nama_Jenis_Group, " & _
                                                                  "b.Kode_Barang, b.Nama_Barang,sum(b.jumlah) as jumlah, " & _
                                                                  "p.Nama_Persediaan as keterangan, b.Kd_Satuan " & _
                                                                  "from PROD.dbo.PRODV_RCN_PROD b " & _
                                                                  "inner join SIF.dbo.SIF_Jns_Persediaan p " & _
                                                                  "on b.kd_jns_persd = p.Kd_Jns_Persd " & _
                                                                  "where b.kd_departemen ='" & kddep & "' " & _
                                                                  "and b.kd_jns_persd = '2' " & _
                                                                  "group by b.Jenis_Group, b.Nama_Jenis_Group, " & _
                                                                  "b.Kode_Barang, b.Nama_Barang,b.Kd_Satuan,p.Nama_Persediaan", sqlconn))

        'dsete.Tables("SALES_SO_D1").Reset()
        GC_Barang.Refresh()
        DA.Fill(dsete, "SALES_SO_D1")
        GC_Barang.DataSource = dsete.Tables("SALES_SO_D1")
        GC_Barang.Show()
        col_jns_group.Group()

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
        'callReport(App_Path() & "\report\crzRlsRph2.rpt", "", "NoRPH=" & TextEdit1.Text)
        frmCetakRPH.no_rph = TextEdit1.Text
        frmCetakRPH.ShowDialog()
        'Else
        'MessageBox.Show("Pilih data yang akan dicetak dalam mode EDIT!")
        'End If
    End Sub
    Public Sub tampil_awal()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  Nama_Jenis,Jenis_Group,Nama_Jenis_Group,kd_jenis,no_rph, Nama_Merk, Nama_Tipe, Merk_Kain,kd_tipe,kd_kain, " & _
                                                                   "uk90 = sum(case ukuran when '90' then jumlah else 0 end), " & _
                                                                   "uk100 = sum(case ukuran when '100' then jumlah else 0 end), " & _
                                                                   "uk120 = sum(case ukuran when '120' then jumlah else 0 end), " & _
                                                                   "uk140 = sum(case ukuran when '140' then jumlah else 0 end), " & _
                                                                   "uk150 = sum(case ukuran when '150' then jumlah else 0 end), " & _
                                                                   "uk160 = sum(case ukuran when '160' then jumlah else 0 end), " & _
                                                                   "uk180 = sum(case ukuran when '180' then jumlah else 0 end), " & _
                                                                   "uk200 = sum(case ukuran when '200' then jumlah else 0 end), " & _
                                                                   "ukKHS = sum(case  when ukuran NOT IN ('90','100','120','140','150','160','180','200') then jumlah else 0 end), " & _
                                                                   "(Select SUBSTRING(( Select ',' + Nama_Ukuran + '/' + CONVERT(varchar(10),FLOOR(jumlah))+'*' " & _
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
                                                                   "where kd_departemen = '" & kddep & "' and kd_jns_persd = '1'" & _
                                                                   "and no_rph = '' " & _
                                                                   "group by  Nama_Jenis,Jenis_Group,Nama_Jenis_Group,kd_jenis,no_rph, Nama_Merk, Nama_Tipe, Merk_Kain ,kd_tipe,kd_kain order by Nama_Merk asc", sqlconn))

        dsete.Tables("SALES_SO_D").Reset()
        gc.Refresh()
        DA.Fill(dsete, "SALES_SO_D")
        gc.DataSource = dsete.Tables("SALES_SO_D")
        gc.Show()
        jenis.Group()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("Select b.Jenis_Group,b.Nama_Jenis_Group, " & _
                                                                   "b.Kode_Barang, b.Nama_Barang,b.Kd_Satuan,sum(b.jumlah) as jumlah, " & _
                                                                   "p.Nama_Persediaan as keterangan " & _
                                                                   "from PROD.dbo.PRODV_RCN_PROD b " & _
                                                                   "inner join SIF.dbo.SIF_Jns_Persediaan p " & _
                                                                   "on b.kd_jns_persd = p.Kd_Jns_Persd " & _
                                                                   "where b.kd_departemen ='" & kddep & "' " & _
                                                                   "and b.kd_jns_persd = '2' " & _
                                                                   "group by b.Jenis_Group, b.Nama_Jenis_Group, " & _
                                                                   "b.Kode_Barang, b.Nama_Barang,b.Kd_Satuan,p.Nama_Persediaan", sqlconn))

        dsete.Tables("SALES_SO_D1").Reset()
        GC_Barang.Refresh()
        DA.Fill(dsete, "SALES_SO_D1")
        GC_Barang.DataSource = dsete.Tables("SALES_SO_D1")
        GC_Barang.Show()
        'jenis.Group()


    End Sub
    Public Sub save_click()
        If TextEdit1.EditValue <> "" Then
            call_procedure()

            'gc.DataSource = dsete.Tables("SALES_SO_D")
            'gc.Show()

            btnSave = False
            btnadd = False
            btnEdit = True
            'btnDelete = True
            btnCancel = True
            setStatus()
            'Me.Enabled = True

            'sqlconn.Close()
            'con_open = False
            'MsgBox("closed..")
        End If

    End Sub

    Public Sub tampil()

        'Dim qstr As String = "select no_rph as [NO TRANS], kd_jadwal as [JADWAL KERJA], tanggal [Tanggal Rencana Produksi],jns_produksi [Jenis Produksi] from PROD.dbo.PRODV_RCN_PROD " & _
        '        " where kd_departemen='" & kddep & "' and jns_produksi = 'PRODUKSI'" & _
        '        " group by no_rph, kd_jadwal, tanggal, jns_produksi order by tanggal desc, no_rph desc "

        Dim qstr As String = "select d.no_rph as [NO TRANS], d.kd_jadwal as [JADWAL KERJA], d.tanggal [Tanggal Rencana Produksi], " & _
        "d.jns_produksi [Jenis Produksi], isnull(m.no_spk,'') [No SPK] from PROD.dbo.PRODV_RCN_PROD d " & _
        "left join (Select DISTINCT m.no_rph, m.no_spk from PROD.dbo.PROD_spk_m m) m " & _
        "on m.no_rph = d.no_rph " & _
        "where kd_departemen='" & kddep & "' and jns_produksi = 'PRODUKSI' " & _
        "group by d.no_rph, kd_jadwal, tanggal, jns_produksi, m.no_spk order by tanggal desc, d.no_rph desc "

        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(qstr, sqlconn))
        If Not ds1.Tables("lookup_so") Is Nothing Then ds1.Tables("lookup_so").Clear()
        da1.Fill(ds1, "lookup_so")
        frmCari.set_dso(ds1.Tables("lookup_so"))
        frmCari.set_dso(ds1.Tables("lookup_so"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            If Not ds2.Tables("rph2") Is Nothing Then ds2.Tables("rph2").Clear()
            Dim sqlcmd As New SqlCommand
            sqlcmd.CommandText = "select  Nama_Jenis,Jenis_Group,Nama_Jenis_Group,kd_jenis,no_rph, Nama_Merk, Nama_Tipe, Merk_Kain,kd_tipe,kd_sub_tipe , Nama_Sub_Tipe,kd_kain," & _
                                                                        "uk90 = sum(case ukuran when '90' then jumlah else 0 end), " & _
                                                                        "uk100 = sum(case ukuran when '100' then jumlah else 0 end), " & _
                                                                        "uk120 = sum(case ukuran when '120' then jumlah else 0 end), " & _
                                                                        "uk140 = sum(case ukuran when '140' then jumlah else 0 end), " & _
                                                                        "uk150 = sum(case ukuran when '150' then jumlah else 0 end), " & _
                                                                        "uk160 = sum(case ukuran when '160' then jumlah else 0 end), " & _
                                                                        "uk180 = sum(case ukuran when '180' then jumlah else 0 end), " & _
                                                                        "uk200 = sum(case ukuran when '200' then jumlah else 0 end), " & _
                                                                        "ukKHS = sum(case  when ukuran NOT IN ('90','100','120','140','150','160','180','200') then jumlah else 0 end), " & _
                                                                        "(Select SUBSTRING(( Select ' ' + so.Keterangan  + '/' + CONVERT(varchar(10),FLOOR(d.jumlah))+'*' " & _
                                                                        "from PROD.dbo.PRODV_RCN_PROD S1 " & _
                                                                        "inner join PROD.dbo.PROD_rcn_prod_d d " & _
                                                                        "on d.no_rph = s1.no_rph and d.kd_barang = s1.Kode_Barang " & _
                                                                        "inner join sales.dbo.SALES_SO_D so " & _
                                                                        "on so.No_sp = d.no_sp and so.no_seq = d.no_sp_dtl  " & _
                                                                        "where s1.ukuran NOT IN ('90','100','120','140','150','160','180','200') " & _
                                                                        "and S1.no_rph = '" & frmCari.row("NO TRANS") & "' and S1.kd_jenis=s2.kd_jenis and S1.kd_tipe = s2.kd_tipe and S1.kd_kain=s2.kd_kain  For XML PATH ('')),2,500)) as ket, " & _
                                                                        "(sum(case ukuran when '90' then jumlah else 0 end)+ sum(case ukuran when '100' then jumlah else 0 end)+" & _
                                                                        "sum(case ukuran when '120' then jumlah else 0 end)+" & _
                                                                        "sum(case ukuran when '140' then jumlah else 0 end)+" & _
                                                                        "sum(case ukuran when '150' then jumlah else 0 end)+sum(case ukuran when '160' then jumlah else 0 end)+" & _
                                                                        "sum(case ukuran when '180' then jumlah else 0 end)+" & _
                                                                        "sum(case ukuran when '200' then jumlah else 0 end)+" & _
                                                                        "sum(case  when ukuran NOT IN ('90','100','120','140','150','160','180','200') then jumlah else 0 end)) as Total " & _
                                                                        "from PROD.dbo.PRODV_RCN_PROD s2 " & _
                                                                        "where kd_departemen = '" & kddep & "' and no_rph = '" & frmCari.row("NO TRANS") & "' and kd_jns_persd ='1' " & _
                                                                        "group by  Nama_Jenis,Jenis_Group,Nama_Jenis_Group,kd_jenis,no_rph, Nama_Merk, Nama_Tipe, Merk_Kain ,kd_tipe,kd_sub_tipe , Nama_Sub_Tipe,kd_kain order by Nama_Merk asc"

            sqlcmd.CommandTimeout = 0
            sqlcmd.Connection = sqlconn
            da2 = New SqlClient.SqlDataAdapter(sqlcmd)
            'ds2.Reset()

            da2.Fill(ds2, "rph2")
            gc.DataSource = ds2.Tables("rph2")

            If Not ds2.Tables("rph3") Is Nothing Then ds2.Tables("rph3").Clear()
            da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("Select b.Jenis_Group,b.Nama_Jenis_Group, " & _
                                                                   "b.Kode_Barang, b.Nama_Barang,b.Kd_Satuan,sum(b.jumlah) as jumlah, " & _
                                                                   "p.Nama_Persediaan as keterangan " & _
                                                                   "from PROD.dbo.PRODV_RCN_PROD b " & _
                                                                   "inner join SIF.dbo.SIF_Jns_Persediaan p " & _
                                                                   "on b.kd_jns_persd = p.Kd_Jns_Persd " & _
                                                                   "where b.kd_departemen ='" & kddep & "' " & _
                                                                   "and b.kd_jns_persd = '2' and b.no_rph ='" & frmCari.row("NO TRANS") & "' " & _
                                                                   "group by b.Jenis_Group, b.Nama_Jenis_Group, " & _
                                                                   "b.Kode_Barang, b.Nama_Barang,b.Kd_Satuan,p.Nama_Persediaan", sqlconn))
            'ds2.Reset()
            da2.Fill(ds2, "rph3")
            GC_Barang.DataSource = ds2.Tables("rph3")

            TextEdit1.EditValue = frmCari.row("NO TRANS")
            txtJadwal.EditValue = frmCari.row("JADWAL KERJA")
            txtTgl_Rph.EditValue = frmCari.row("Tanggal Rencana Produksi")
            txt_jns_prod.Text = IIf(frmCari.row("Jenis Produksi") Is System.DBNull.Value, "", frmCari.row("Jenis Produksi"))




            btnSave = False
            btnadd = False
            btnEdit = False
            'btnDelete = True
            btnCetak = True
            btnCancel = True
            setStatus()
            Me.Enabled = True



            Dim colM(4) As DataColumn
            Dim colD(4) As DataColumn
            Dim colD1(1) As DataColumn
            Dim colD2(1) As DataColumn
            Dim rel, rel1 As DataRelation

        Else
            cancel()

        End If

    End Sub

    Sub cancel()
        gc.DataSource = dsete.Tables("SALES_SO_D")
        gc.Show()

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = False
        btnadd = False
        btnCetak = True
        setStatus()
        Me.Enabled = False
    End Sub
    Public Sub cancel_click()
        'gc.DataSource = dsete.Tables("SALES_SO_D")
        'gc.Show()

        'btnSave = False
        'btnCancel = False
        'btnDelete = False
        'btnEdit = True
        'btnadd = True
        'setStatus()
        'Me.Enabled = False
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

End Class