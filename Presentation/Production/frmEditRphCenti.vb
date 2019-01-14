Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmEditRphCenti
    Dim dsete, ds1, ds2, ds3 As New DataSet
    Dim dadbe, da1, da2, da3 As SqlDataAdapter
    Dim DA, DAq As SqlDataAdapter
    Dim DAD As SqlDataAdapter
    Dim DTR As SqlDataReader
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
    Dim rel1 As DataRelation
    Dim lng As Long
    Dim TEMPLATE As String = "TemplateRPH"
    Public Sub call_procedure()
        Dim dr As SqlDataReader
        If Not ds1.Tables("Barang_BOM") Is Nothing Then ds1.Tables("Barang_BOM").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("Select m.kd_barang, '' Nama_Barang From PROD.dbo.PROD_rcn_prod_b m " & _
                                                "where 1=0 ", sqlconn))
        da1.Fill(ds1, "Barang_BOM")
        dr = New SqlClient.SqlCommand("Select distinct b.kd_barang,br.Nama_Barang From PROD.dbo.PROD_rcn_prod_b b " & _
                                      "left join SIF.dbo.SIF_Barang br " & _
                                      "on br.Kode_Barang = b.kd_barang " & _
                                      "where b.no_rph = '" & TextEdit1.Text & "' and  " & _
                                      "b.kd_barang not in (Select m.kd_bom from SIF.dbo.SIF_bom m " & _
                                      "where m.rec_stat = 'Y' and " & _
                                      "m.revisi = (Select max(bm.revisi) from SIF.dbo.SIF_bom bm where bm.kd_bom = m.kd_bom))", sqlconn).ExecuteReader
        If dr.HasRows Then
            While dr.Read
                Dim rw As DataRow = ds1.Tables("Barang_BOM").NewRow
                rw("kd_barang") = dr.Item("kd_barang")
                rw("Nama_Barang") = dr.Item("Nama_Barang")
                ds1.Tables("Barang_BOM").Rows.Add(rw)
            End While

        Else

        End If
        dr.Close()

        dr = New SqlClient.SqlCommand("Delete from PROD.dbo.temp_SPK ", sqlconn).ExecuteReader
        dr.Close()

        If Not ds1.Tables("Barang_Prod") Is Nothing Then ds1.Tables("Barang_Prod").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("Select distinct m.kd_barang, m.no_rph From PROD.dbo.PROD_rcn_prod_b m " & _
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
        'Try
        Dim sqlCmd1 As New SqlCommand
        sqlCmd1.CommandTimeout = 0
        sqlCmd1.Connection = sqlconn
        sqlCmd1.CommandType = CommandType.StoredProcedure
        sqlCmd1.CommandText = "PROD.dbo.prodp_ins_spk2_fix"
        sqlCmd1.Parameters.Add("@vno_rph", SqlDbType.Char).Value = TextEdit1.Text 'frmCari.row("NO TRANS")
        dr = sqlCmd1.ExecuteReader
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

        'Dim sqlCmd4 As New SqlCommand
        'sqlCmd4.CommandTimeout = 0
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
    Public Sub cetak_click()
        callReport(App_Path() & "\report\crzRlsRphCenti.rpt", "", "NoRPH=" & TextEdit1.EditValue & " &vnama_report=" & TEMPLATE, False, False)
        'MsgBox('&norph=" & lkrph.EditValue & " &kd.kegiatanspk=" & lkkegtn.EditValue & " &kdjenis=" & lkjnsbrg.EditValue, False)')
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
    Sub load_barang()
        If Not ds1.Tables("jnsBarang") Is Nothing Then ds1.Tables("jnsBarang").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang where rec_stat ='Y' ", sqlconn))
        da1.Fill(ds1, "jnsBarang")
        RepLEBarang.DataSource = ds1.Tables("jnsBarang")

    End Sub
    Private Sub frmRlsRphCenti_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        load_barang()
        State = "EDIT"
        Dim colD1(0) As DataColumn
        Dim colD2(0) As DataColumn

        If Not ds1.Tables("JDWKRJ") Is Nothing Then ds1.Tables("JDWKRJ").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='JDWKRJ'", sqlconn))
        da1.Fill(ds1, "JDWKRJ")
        txtJadwal.Properties.DataSource = ds1.Tables("JDWKRJ")
        'DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  Nama_Jenis,Jenis_Group,Nama_Jenis_Group,kd_jenis,no_rph, Nama_Merk, Nama_Tipe, Warna,kd_tipe,kd_kain, " & _
        '                                                                  "uk90 = sum(case ukuran when '90' then jumlah else 0 end), " & _
        '                                                                  "uk100 = sum(case ukuran when '100' then jumlah else 0 end), " & _
        '                                                                  "uk120 = sum(case ukuran when '120' then jumlah else 0 end), " & _
        '                                                                  "uk140 = sum(case ukuran when '140' then jumlah else 0 end), " & _
        '                                                                  "uk150 = sum(case ukuran when '150' then jumlah else 0 end), " & _
        '                                                                  "uk160 = sum(case ukuran when '160' then jumlah else 0 end), " & _
        '                                                                  "uk180 = sum(case ukuran when '180' then jumlah else 0 end), " & _
        '                                                                  "uk200 = sum(case ukuran when '200' then jumlah else 0 end), " & _
        '                                                                  "ukKHS = sum(case  when ukuran NOT IN ('90','100','120','140','150','160','180','200') then jumlah else 0 end), " & _
        '                                                                  "(Select SUBSTRING(( Select ',' + Nama_Ukuran + '/' + CONVERT(varchar(10),FLOOR(jumlah)) " & _
        '                                                                  "from PROD.dbo.PRODV_RCN_PROD S1 where ukuran NOT IN ('90','100','120','140','150','160','180','200')" & _
        '                                                                  "and S1.kd_jenis=s2.kd_jenis and S1.kd_tipe = s2.kd_tipe and S1.kd_kain=s2.kd_kain  For XML PATH ('')),2,500)) as ket, " & _
        '                                                                  "(sum(case ukuran when '90' then jumlah else 0 end)+ sum(case ukuran when '100' then jumlah else 0 end)+" & _
        '                                                                  "sum(case ukuran when '120' then jumlah else 0 end)+" & _
        '                                                                  "sum(case ukuran when '140' then jumlah else 0 end)+" & _
        '                                                                  "sum(case ukuran when '150' then jumlah else 0 end)+sum(case ukuran when '160' then jumlah else 0 end)+" & _
        '                                                                  "sum(case ukuran when '180' then jumlah else 0 end)+" & _
        '                                                                  "sum(case ukuran when '200' then jumlah else 0 end)+" & _
        '                                                                  "sum(case  when ukuran NOT IN ('90','100','120','140','150','160','180','200') then jumlah else 0 end)) as Total " & _
        '                                                                  "from PROD.dbo.PRODV_RCN_PROD s2 " & _
        '                                                                  "where kd_departemen = '" & kddep & "' " & _
        '                                                                  "group by  Nama_Jenis,Jenis_Group,Nama_Jenis_Group,kd_jenis,no_rph, Nama_Merk, Nama_Tipe, Warna ,kd_tipe,kd_kain", sqlconn))

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("Select b.Jenis_Group,b.Nama_Jenis_Group, " & _
                                                                  "b.Kode_Barang, b.Nama_Barang,sum(b.jumlah) as jumlah, " & _
                                                                  "p.Nama_Persediaan as keterangan, b.Kd_Satuan " & _
                                                                  "from PROD.dbo.PRODV_RCN_PROD_CENTI b " & _
                                                                  "inner join SIF.dbo.SIF_Jns_Persediaan p " & _
                                                                  "on b.kd_jns_persd = p.Kd_Jns_Persd " & _
                                                                  "where b.kd_departemen ='" & kddep & "' " & _
                                                                  "group by b.Jenis_Group, b.Nama_Jenis_Group, " & _
                                                                  "b.Kode_Barang, b.Nama_Barang,b.Kd_Satuan,p.Nama_Persediaan", sqlconn))

        dsete.Reset()
        gc.Refresh()
        DA.Fill(dsete, "SALES_SO_D")
        gc.DataSource = dsete.Tables("SALES_SO_D")

        'DAq = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select distinct  a.jumlah, br.Kode_Barang,a.no_sp,br.kd_merk,br.kd_tipe,br.kd_kain,br.Nama_Barang,a.tinggi,a.lebar,a.panjang " & _
        '      " from PROD.dbo.PROD_rcn_prod_d a inner join SIF.dbo.SIF_BARANG br ON a.kd_barang=br.Kode_Barang  " & _
        '      " inner join SIF.dbo.SIF_Merk m on br.kd_merk=m.Kode_Merk " & _
        '      " inner join SIF.dbo.SIF_Tipe t on br.kd_tipe=t.Kode_Tipe " & _
        '      " inner join SIF.dbo.SIF_Kain k on br.kd_kain=k.Kode_Kain  where a.no_rph= '" & TextEdit1.EditValue & "'", sqlconn))
        'DAq.Fill(dsete, "PROD_D")

        DAq = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct  a.jumlah, br.Kode_Barang,a.no_sp,a.no_sp_dtl,a.no_seq,br.kd_merk,br.kd_tipe,br.kd_kain,br.Nama_Barang,a.tinggi,a.lebar,a.panjang " & _
                                                                    "from PROD.dbo.PROD_rcn_prod_d a inner join SIF.dbo.SIF_BARANG br " & _
                                                                    "ON a.kd_barang=br.Kode_Barang inner join SIF.dbo.SIF_Merk m on br.kd_merk=m.Kode_Merk " & _
                                                                    "inner join SIF.dbo.SIF_Tipe t on br.kd_tipe=t.Kode_Tipe " & _
                                                                    "inner join SIF.dbo.SIF_Kain k on br.kd_kain=k.Kode_Kain  " & _
                                                                    "where a.no_rph= '" & TextEdit1.EditValue & "' " & _
                                                                    "order by a.no_sp, a.no_sp_dtl,a.no_seq ASC", sqlconn))
        DAq.Fill(dsete, "PROD_D")

        Dim rel1 As DataRelation

        'colD1(0) = dsete.Tables("SALES_SO_D").Columns("kd_merk")
        colD1(0) = dsete.Tables("SALES_SO_D").Columns("Kode_Barang")
        'colD1(1) = dsete.Tables("SALES_SO_D").Columns("kd_kain")

        'colD2(0) = dsete.Tables("PROD_D").Columns("kd_merk")
        colD2(0) = dsete.Tables("PROD_D").Columns("Kode_Barang")
        'colD2(1) = dsete.Tables("PROD_D").Columns("kd_kain")

        gc.DataSource = dsete.Tables("SALES_SO_D")
        rel1 = dsete.Relations.Add("Detail", colD1, colD2, False)
        gc.LevelTree.Nodes.Add("Detail", GridView2)

        jenis.Group()
        txtTgl_Rph.Text = Now
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
    Public Sub tampil_awal()

        'DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  Nama_Jenis,Jenis_Group,Nama_Jenis_Group,kd_jenis,no_rph, Nama_Merk, Nama_Tipe, Warna,kd_tipe,kd_kain, " & _
        '                                                           "uk90 = sum(case ukuran when '90' then jumlah else 0 end), " & _
        '                                                           "uk100 = sum(case ukuran when '100' then jumlah else 0 end), " & _
        '                                                           "uk120 = sum(case ukuran when '120' then jumlah else 0 end), " & _
        '                                                           "uk140 = sum(case ukuran when '140' then jumlah else 0 end), " & _
        '                                                           "uk150 = sum(case ukuran when '150' then jumlah else 0 end), " & _
        '                                                           "uk160 = sum(case ukuran when '160' then jumlah else 0 end), " & _
        '                                                           "uk180 = sum(case ukuran when '180' then jumlah else 0 end), " & _
        '                                                           "uk200 = sum(case ukuran when '200' then jumlah else 0 end), " & _
        '                                                           "ukKHS = sum(case  when ukuran NOT IN ('90','100','120','140','150','160','180','200') then jumlah else 0 end), " & _
        '                                                           "(Select SUBSTRING(( Select ',' + Nama_Ukuran + '/' + CONVERT(varchar(10),FLOOR(jumlah)) " & _
        '                                                           "from PROD.dbo.PRODV_RCN_PROD S1 where ukuran NOT IN ('90','100','120','140','150','160','180','200')" & _
        '                                                           "and S1.kd_jenis=s2.kd_jenis and S1.kd_tipe = s2.kd_tipe and S1.kd_kain=s2.kd_kain  For XML PATH ('')),2,500)) as ket, " & _
        '                                                           "(sum(case ukuran when '90' then jumlah else 0 end)+ sum(case ukuran when '100' then jumlah else 0 end)+" & _
        '                                                           "sum(case ukuran when '120' then jumlah else 0 end)+" & _
        '                                                           "sum(case ukuran when '140' then jumlah else 0 end)+" & _
        '                                                           "sum(case ukuran when '150' then jumlah else 0 end)+sum(case ukuran when '160' then jumlah else 0 end)+" & _
        '                                                           "sum(case ukuran when '180' then jumlah else 0 end)+" & _
        '                                                           "sum(case ukuran when '200' then jumlah else 0 end)+" & _
        '                                                           "sum(case  when ukuran NOT IN ('90','100','120','140','150','160','180','200') then jumlah else 0 end)) as Total " & _
        '                                                           "from PROD.dbo.PRODV_RCN_PROD s2 " & _
        '                                                           "where kd_departemen = '" & kddep & "' " & _
        '                                                           "group by  Nama_Jenis,Jenis_Group,Nama_Jenis_Group,kd_jenis,no_rph, Nama_Merk, Nama_Tipe, Warna ,kd_tipe,kd_kain", sqlconn))

        'DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("Select b.Jenis_Group,b.Nama_Jenis_Group, " & _
        '                                                           "b.Kode_Barang, b.Nama_Barang,b.Kd_Satuan,sum(b.jumlah) as jumlah, " & _
        '                                                           "p.Nama_Persediaan as keterangan " & _
        '                                                           "from PROD.dbo.PRODV_RCN_PROD b " & _
        '                                                           "inner join SIF.dbo.SIF_Jns_Persediaan p " & _
        '                                                           "on b.kd_jns_persd = p.Kd_Jns_Persd " & _
        '                                                           "where b.kd_departemen ='" & kddep & "' " & _
        '                                                           "group by b.Jenis_Group, b.Nama_Jenis_Group, " & _
        '                                                           "b.Kode_Barang, b.Nama_Barang,b.Kd_Satuan,p.Nama_Persediaan", sqlconn))
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("Select b.Jenis_Group,b.Nama_Jenis_Group, b.no_urut_brg,  " & _
                                                                   "b.Kode_Barang, b.Nama_Barang,b.Kd_Satuan,b.jumlah as jumlah, " & _
                                                                   "p.Nama_Persediaan as keterangan " & _
                                                                   "from PROD.dbo.PRODV_RCN_PROD_CENTI b " & _
                                                                   "inner join SIF.dbo.SIF_Jns_Persediaan p " & _
                                                                   "on b.kd_jns_persd = p.Kd_Jns_Persd " & _
                                                                   "where b.kd_departemen ='" & kddep & "' " & _
                                                                   "order by b.no_urut_brg ASC", sqlconn))

        dsete.Reset()
        gc.Refresh()
        DA.Fill(dsete, "SALES_SO_D")
        gc.DataSource = dsete.Tables("SALES_SO_D")


        DAq = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select distinct  a.jumlah,a.no_urut_brg, br.Kode_Barang,a.no_sp,m.Kode_Merk,t.Kode_Tipe,k.Kode_Kain,br.Nama_Barang,a.tinggi,a.lebar,a.panjang " & _
             " from PROD.dbo.PROD_rcn_prod_d a inner join SIF.dbo.SIF_BARANG br ON a.kd_barang=br.Kode_Barang  " & _
             " inner join SIF.dbo.SIF_Merk m on br.kd_merk=m.Kode_Merk " & _
             " inner join SIF.dbo.SIF_Tipe t on br.kd_tipe=t.Kode_Tipe " & _
             " inner join SIF.dbo.SIF_Kain k on br.kd_kain=k.Kode_Kain where a.no_rph= '" & TextEdit1.EditValue & "' order by a.no_urut_brg", sqlconn))
        DAq.Fill(dsete, "PROD_D")
        Dim colD1(0) As DataColumn
        Dim colD2(0) As DataColumn

        'colD1(0) = dsete.Tables("SALES_SO_D").Columns("kd_merk")
        colD1(0) = dsete.Tables("SALES_SO_D").Columns("no_urut_brg")
        'colD1(1) = dsete.Tables("SALES_SO_D").Columns("kd_kain")

        'colD2(0) = dsete.Tables("PROD_D").Columns("Kode_Merk")
        colD2(0) = dsete.Tables("PROD_D").Columns("no_urut_brg")
        'colD2(1) = dsete.Tables("PROD_D").Columns("Kode_Kain")



        rel1 = dsete.Relations.Add("Detail", colD1, colD2, False)
        gc.LevelTree.Nodes.Add("Detail", GridView2)

        gc.DataSource = dsete.Tables("SALES_SO_D")
        gc.Show()
        jenis.Group()


    End Sub
    Public Sub save_click()
        If TextEdit1.EditValue <> "" Then
            Dim BTRANS As SqlTransaction
            Dim mb, mb1 As New SqlCommandBuilder

            If Not ds3.Tables("rph1") Is Nothing Then ds3.Tables("rph1").Clear()
            da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT * From PROD.dbo.PROD_rcn_prod_m b " & _
                                                                        "where b.no_rph = '" & TextEdit1.Text & "' and b.kd_departemen = '" & kddep & "'", sqlconn))
            ds3.Reset()
            da3.Fill(ds3, "rph1")

            Dim row As DataRow = ds3.Tables("rph1").Rows(0)
            row.Item("tanggal") = txtTgl_Rph.EditValue
            row.Item("kd_jadwal") = txtJadwal.EditValue
            row.Item("last_update_date") = getTanggal()
            row.Item("last_updated_by") = username

            mb = New SqlClient.SqlCommandBuilder(da2)
            da2.UpdateCommand = mb.GetUpdateCommand()
            da2.InsertCommand = mb.GetInsertCommand()
            da2.DeleteCommand = mb.GetDeleteCommand()

            mb1 = New SqlClient.SqlCommandBuilder(da3)
            da3.UpdateCommand = mb1.GetUpdateCommand()
            da3.InsertCommand = mb1.GetInsertCommand()
            da3.DeleteCommand = mb1.GetDeleteCommand()

         

            BTRANS = sqlconn.BeginTransaction("1")
            da2.UpdateCommand.Transaction = BTRANS
            da2.InsertCommand.Transaction = BTRANS
            da2.DeleteCommand.Transaction = BTRANS


            da3.UpdateCommand.Transaction = BTRANS
            da3.InsertCommand.Transaction = BTRANS
            da3.DeleteCommand.Transaction = BTRANS
            '   call_procedure()

            da3.Update(ds3.Tables("rph1"))
            ds3.Tables("rph1").AcceptChanges()

            da2.Update(ds2.Tables("rph2"))
            ds2.Tables("rph2").AcceptChanges()



            'gc.DataSource = dsete.Tables("SALES_SO_D")
            'gc.Show()
            BTRANS.Commit()
            showMessages("Data Berhasil Disimpan")
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
        'Dim qstr As String = "select distinct no_rph as [NO TRANS], kd_jadwal as [JADWAL KERJA], tanggal [Tanggal Rencana Produksi],jns_produksi [Jenis Produksi] from PROD.dbo.PRODV_RCN_PROD_CENTI " & _
        '        " where kd_departemen='" & kddep & "' and sts_centi = 'Y'" & _
        '        " group by no_rph, kd_jadwal, tanggal, jns_produksi order by tanggal desc, no_rph desc "

        Dim qstr As String = "select d.no_rph as [NO TRANS], d.kd_jadwal as [JADWAL KERJA], d.tanggal [Tanggal Rencana Produksi], " & _
     "d.jns_produksi [Jenis Produksi], isnull(m.no_spk,'') [No SPK] from PROD.dbo.PRODV_RCN_PROD_CENTI d " & _
     "left join (Select DISTINCT m.no_rph, m.no_spk from PROD.dbo.PROD_spk_m m) m " & _
     "on m.no_rph = d.no_rph " & _
     "where kd_departemen='" & kddep & "' and jns_produksi = 'PRODUKSI' " & _
     "group by d.no_rph, kd_jadwal, tanggal, jns_produksi, m.no_spk order by tanggal desc, d.no_rph desc "

        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(qstr, sqlconn))
        If Not ds1.Tables("lookup_so") Is Nothing Then ds1.Tables("lookup_so").Clear()
        da1.Fill(ds1, "lookup_so")
        frmCari.set_dso(ds1.Tables("lookup_so"))
        'ds3.Tables("lookup_so").Columns(0).DateTimeMode = "dd/MM/yyyy"
        frmCari.set_dso(ds1.Tables("lookup_so"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            'da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  Nama_Jenis,Jenis_Group,Nama_Jenis_Group,kd_jenis,no_rph, Nama_Merk, Nama_Tipe, Warna,kd_tipe,kd_kain," & _
            '                                                          "uk90 = sum(case ukuran when '90' then jumlah else 0 end), " & _
            '                                                          "uk100 = sum(case ukuran when '100' then jumlah else 0 end), " & _
            '                                                          "uk120 = sum(case ukuran when '120' then jumlah else 0 end), " & _
            '                                                          "uk140 = sum(case ukuran when '140' then jumlah else 0 end), " & _
            '                                                          "uk150 = sum(case ukuran when '150' then jumlah else 0 end), " & _
            '                                                          "uk160 = sum(case ukuran when '160' then jumlah else 0 end), " & _
            '                                                          "uk180 = sum(case ukuran when '180' then jumlah else 0 end), " & _
            '                                                          "uk200 = sum(case ukuran when '200' then jumlah else 0 end), " & _
            '                                                          "ukKHS = sum(case  when ukuran NOT IN ('90','100','120','140','150','160','180','200') then jumlah else 0 end), " & _
            '                                                          "(Select SUBSTRING(( Select ',' + Nama_Ukuran + '/' + CONVERT(varchar(10),FLOOR(jumlah)) " & _
            '                                                          "from PROD.dbo.PRODV_RCN_PROD S1 where ukuran NOT IN ('90','100','120','140','150','160','180','200') " & _
            '                                                          "and no_rph = '" & frmCari.row("NO TRANS") & "' and S1.kd_jenis=s2.kd_jenis and S1.kd_tipe = s2.kd_tipe and S1.kd_kain=s2.kd_kain  For XML PATH ('')),2,500)) as ket, " & _
            '                                                          "(sum(case ukuran when '90' then jumlah else 0 end)+ sum(case ukuran when '100' then jumlah else 0 end)+" & _
            '                                                          "sum(case ukuran when '120' then jumlah else 0 end)+" & _
            '                                                          "sum(case ukuran when '140' then jumlah else 0 end)+" & _
            '                                                          "sum(case ukuran when '150' then jumlah else 0 end)+sum(case ukuran when '160' then jumlah else 0 end)+" & _
            '                                                          "sum(case ukuran when '180' then jumlah else 0 end)+" & _
            '                                                          "sum(case ukuran when '200' then jumlah else 0 end)+" & _
            '                                                          "sum(case  when ukuran NOT IN ('90','100','120','140','150','160','180','200') then jumlah else 0 end)) as Total " & _
            '                                                          "from PROD.dbo.PRODV_RCN_PROD s2 " & _
            '                                                          "where kd_departemen = '" & kddep & "' and no_rph = '" & frmCari.row("NO TRANS") & "'" & _
            '                                                          "group by  Nama_Jenis,Jenis_Group,Nama_Jenis_Group,kd_jenis,no_rph, Nama_Merk, Nama_Tipe, Warna ,kd_tipe,kd_kain", sqlconn))

            'da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("Select b.Jenis_Group,b.Nama_Jenis_Group, " & _
            '                                                       "b.Kode_Barang, b.Nama_Barang,b.Kd_Satuan,sum(b.jumlah) as jumlah, " & _
            '                                                       "p.Nama_Persediaan as keterangan " & _
            '                                                       "from PROD.dbo.PRODV_RCN_PROD b " & _
            '                                                       "inner join SIF.dbo.SIF_Jns_Persediaan p " & _
            '                                                       "on b.kd_jns_persd = p.Kd_Jns_Persd " & _
            '                                                       "where b.kd_departemen ='" & kddep & "' " & _
            '                                                       "and b.no_rph ='" & frmCari.row("NO TRANS") & "' " & _
            '                                                       "group by b.Jenis_Group, b.Nama_Jenis_Group, " & _
            '                                                       "b.Kode_Barang, b.Nama_Barang,b.Kd_Satuan,p.Nama_Persediaan", sqlconn))
            ds2.Relations.Clear()
            If Not ds2.Tables("rph2") Is Nothing Then ds2.Tables("rph2").Clear()
            If Not ds2.Tables("PROD_D") Is Nothing Then ds2.Tables("PROD_D").Clear()
            da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT *, '' Jenis_Group, '' Nama_Jenis_Group, '' Kd_Satuan From PROD.dbo.PROD_rcn_prod_b b " & _
                                                                        "where b.no_rph = '" & frmCari.row("NO TRANS") & "' and b.kd_departemen = '" & kddep & "'", sqlconn))
            ds2.Reset()
            da2.Fill(ds2, "rph2")
            Dim dr As SqlDataReader
            dr = New SqlClient.SqlCommand("Select b.no_rph,b.Jenis_Group,b.Nama_Jenis_Group, b.no_urut_brg,  " & _
                                                               "b.Kode_Barang, b.Nama_Barang,b.Kd_Satuan,b.jumlah as jumlah, " & _
                                                           "p.Nama_Persediaan as keterangan " & _
                                                           "from PROD.dbo.PRODV_RCN_PROD_CENTI b " & _
                                                           "inner join SIF.dbo.SIF_Jns_Persediaan p " & _
                                                           "on b.kd_jns_persd = p.Kd_Jns_Persd " & _
                                                           "where b.kd_departemen ='" & kddep & "' " & _
                                                           "and b.no_rph ='" & frmCari.row("NO TRANS") & "' " & _
                                                           "order by b.no_urut_brg ASC ", sqlconn).ExecuteReader
            '"order by v.No_sp, Convert(Int,v.No_seq_d) asc ", sqlconn).ExecuteReader

            While dr.Read
                For i = ds2.Tables("rph2").Rows.Count - 1 To 0 Step -1
                    Dim rows As DataRow = ds2.Tables("rph2").Rows(i)
                    If rows("kd_barang") = dr.Item("Kode_Barang") And rows("no_urut_brg") = dr.Item("no_urut_brg") Then
                        rows("Nama_Jenis_Group") = dr.Item("Nama_Jenis_Group")
                        rows("Kd_Satuan") = dr.Item("Kd_Satuan")
                    Else

                    End If
                  
                Next
            End While
            'da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("Select b.Jenis_Group,b.Nama_Jenis_Group, b.no_urut_brg,  " & _
            '                                               "b.Kode_Barang, b.Nama_Barang,b.Kd_Satuan,b.jumlah as jumlah, " & _
            '                                               "p.Nama_Persediaan as keterangan " & _
            '                                               "from PROD.dbo.PRODV_RCN_PROD_CENTI b " & _
            '                                               "inner join SIF.dbo.SIF_Jns_Persediaan p " & _
            '                                               "on b.kd_jns_persd = p.Kd_Jns_Persd " & _
            '                                               "where b.kd_departemen ='" & kddep & "' " & _
            '                                               "and b.no_rph ='" & frmCari.row("NO TRANS") & "' " & _
            '                                               "order by b.no_urut_brg ASC", sqlconn))

            gc.DataSource = ds2.Tables("rph2")


            ' DAq = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select distinct a.jumlah,a.no_urut_brg,br.Kode_Barang,a.no_sp, a.no_sp_dtl,a.no_seq, " & _
            '                                                             "m.Kode_Merk,t.Kode_Tipe,k.Kode_Kain,br.Nama_Barang,a.tinggi,a.lebar,a.panjang " & _
            '" from PROD.dbo.PROD_rcn_prod_d a inner join SIF.dbo.SIF_BARANG br ON a.kd_barang=br.Kode_Barang  " & _
            '" inner join SIF.dbo.SIF_Merk m on br.kd_merk=m.Kode_Merk " & _
            '" inner join SIF.dbo.SIF_Tipe t on br.kd_tipe=t.Kode_Tipe " & _
            '" inner join SIF.dbo.SIF_Kain k on br.kd_kain=k.Kode_Kain where a.no_rph= '" & frmCari.row("NO TRANS") & "' order by a.no_urut_brg", sqlconn))
            DAq = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct a.jumlah,a.no_urut_brg,br.Kode_Barang,a.no_sp, a.no_sp_dtl,a.no_seq,c.Nama_Customer, " & _
                                                                        "m.Kode_Merk, t.Kode_Tipe, k.Kode_Kain, br.Nama_Barang, a.tinggi, a.lebar, a.panjang " & _
                                                                        "from PROD.dbo.PROD_rcn_prod_d a inner join SIF.dbo.SIF_BARANG br ON a.kd_barang=br.Kode_Barang  " & _
                                                                        "inner join SALES.dbo.SALES_SO s on s.No_sp = a.no_sp " & _
                                                                        "left join SIF.dbo.SIF_Customer c on c.Kd_Customer = s.Kd_Customer " & _
                                                                        "inner join SIF.dbo.SIF_Merk m on br.kd_merk=m.Kode_Merk  " & _
                                                                        "inner join SIF.dbo.SIF_Tipe t on br.kd_tipe=t.Kode_Tipe " & _
                                                                        "inner join SIF.dbo.SIF_Kain k on br.kd_kain=k.Kode_Kain " & _
                                                                        "where a.no_rph= '" & frmCari.row("NO TRANS") & "' order by a.no_urut_brg", sqlconn))

            DAq.Fill(ds2, "PROD_D")
            Dim colD1(0) As DataColumn
            Dim colD2(0) As DataColumn

            'colD1(0) = ds2.Tables("rph2").Columns("kd_merk")
            colD1(0) = ds2.Tables("rph2").Columns("no_urut_brg")
            'colD1(1) = ds2.Tables("rph2").Columns("kd_kain")

            'colD2(0) = ds2.Tables("PROD_D").Columns("Kode_Merk")
            colD2(0) = ds2.Tables("PROD_D").Columns("no_urut_brg")
            'colD2(1) = ds2.Tables("PROD_D").Columns("Kode_Kain")



            rel1 = ds2.Relations.Add("Detail", colD1, colD2, False)
            gc.LevelTree.Nodes.Add("Detail", GridView2)

            gc.DataSource = ds2.Tables("rph2")
            txtTgl_Rph.EditValue = frmCari.row("Tanggal Rencana Produksi")
            TextEdit1.EditValue = frmCari.row("NO TRANS")
            txtJadwal.EditValue = frmCari.row("JADWAL KERJA")

            btnSave = True
            btnadd = False
            btnEdit = False
            'btnDelete = True
            btnCancel = True
            setStatus()
            Me.Enabled = True
        Else
            cancel_click()
        End If

    End Sub


    Public Sub cancel_click()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False

    End Sub

    Private Sub GV_InvalidRowException(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs) Handles gv.InvalidRowException
        e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction
    End Sub

    Private Sub GV_InitNewRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles gv.InitNewRow
        gv.GetRow(e.RowHandle).item("No_seq") = gv.RowCount + 1
    End Sub

    Private Sub TextEdit1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextEdit1.Click
        'tampil()
    End Sub

    Private Sub TextEdit1_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextEdit1.EditValueChanged

    End Sub
End Class