Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Windows.Forms
Imports DevExpress.XtraPrintingLinks

Public Class frmGenHppSpkOrangCentian
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Dim ds, ds_cari2, ds_cari, ds_cari1, dsLookUp As New DataSet
    Dim da, DALOOKUP1, DALOOKUP, DALOOKUP2 As SqlDataAdapter
    Private Buildernya As New SqlClient.SqlCommandBuilder
    Dim myBuilder, mb1, mb2 As New SqlCommandBuilder
    Public ds1, ds2, ds3, ds4 As New DataSet
    Public da1, da2, da3, da4, da5, da6, da7 As New SqlDataAdapter
    Dim notrans_simulasi1, no_realisasi, no_spk1 As String
    Dim jenis_realisasi As String
    Dim prn As frmMain
    Private STATE As String
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Dim rl, r2 As DataRelation
    Dim col1(2), col2(2) As DataColumn

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Public Sub add_click()
        ' Contoh Bila Menekan tombol add di Frmmain
        Dim myBuilder As New SqlClient.SqlCommandBuilder
        btnSave = True
        btnEdit = False
        btnadd = False
        btnCancel = False
        setStatus()
    End Sub
    Private Sub formate_yayak()
        thisThread.CurrentCulture = New System.Globalization.CultureInfo("id-ID")
        'GvMonQC.Columns("qty_order").SummaryItem.DisplayFormat = DevExpress.Utils.FormatType.Numeric
        'GvMonQC.Columns("qty_order").SummaryItem.DisplayFormat
        Gv.Columns("qty_qc_pass").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Gv.Columns("qty_qc_pass").DisplayFormat.FormatString = "n2"
        Gv.Columns("qty_order").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Gv.Columns("qty_order").DisplayFormat.FormatString = "n2"
        Gv.Columns("hold").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Gv.Columns("hold").DisplayFormat.FormatString = "n2"
        Gv.Columns("qty_qc_unpass").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Gv.Columns("qty_qc_unpass").DisplayFormat.FormatString = "n2"
        'GvMonQC.Columns("qty_sisa").DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        'GvMonQC.Columns("qty_sisa").DisplayFormat.FormatString = "n2"
    End Sub



    Private Sub frmCetakProdSpkOrang_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        ' ReloadTable()

        prn = getParent(Me)
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)


        'DALOOKUP2 = New SqlDataAdapter(New SqlCommand("select distinct(blthn) from INV.dbo.INV_QC", sqlconn))
        'DALOOKUP2.Fill(ds_cari2, "_lookup1")
        'LookupBlthn.Properties.DataSource = ds_cari2.Tables("_lookup1")

        'Loadblthn()
    End Sub
    Sub ReloadTable()
        Dim sqltgl As String = ""

        ds.Relations.Clear()
        If Not ds.Tables("_MonQC") Is Nothing Then ds.Tables("_MonQC").Clear()
        If Not ds.Tables("_MonProd") Is Nothing Then ds.Tables("_MonProd").Clear()
        If Not ds.Tables("_MonProd1") Is Nothing Then ds.Tables("_MonProd1").Clear()

        'da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select dep.Nama_Departemen, m.rec_stat rec_stat,m.tanggal Tanggal, m.no_spk_man_rls No_SPK_Rls,m.no_spk_man No_SPK, " & _
        '    "g.Desc_Data KEGIATAN,g1.Desc_Data KEGIATAN_SPK,p.Nama_Pegawai PEGAWAI, " & _
        '    "g2.Desc_Data GROUP_KERJA,u.kd_mesin MESIN,s.no_rph NO_RPH, m.no_posting " & _
        '    "from PROD.dbo.PROD_rls_spk_man_m m " & _
        '    "left join SIF.dbo.SIF_Gen_Reff_D g " & _
        '    "on g.Id_Data=m.kd_kegiatan " & _
        '    "left join SIF.dbo.SIF_Gen_Reff_D g1 " & _
        '    "on g1.Id_Data=m.kd_kegiatan_spk " & _
        '    "left join SIF.dbo.SIF_Gen_Reff_D g2 " & _
        '    "on g2.Id_Data=m.group_kerja " & _
        '    "left join SIF.dbo.SIF_Pegawai p " & _
        '    "on p.Kode_Pegawai=m.kd_pegawai " & _
        '    "left join SIF.dbo.SIF_mesin_prod u " & _
        '    "on u.kd_mesin=m.kd_mesin " & _
        '    "left join SIF.dbo.SIF_Departemen dep " & _
        '    "on dep.Kd_Departemen = m.kd_departemen " & _
        '    "left join PROD.dbo.PROD_spk_m s " & _
        '    "on s.no_spk=m.no_spk_man " & _
        '    "and s.kd_kegiatan=m.kd_kegiatan " & _
        '    "and s.kd_kegiatan_spk=m.kd_kegiatan_spk " & _
        '    "where g1.Id_Ref_File='SPK' and s.no_rph is not null " & _
        '    "and g.Id_Ref_File='KGTSPK' and g2.Id_Ref_File='GRPKERJA' " & _
        '    "order by m.tanggal  ", sqlconn))

        If deTglMulai.EditValue = vbNullString And deTglSelesai.EditValue = vbNullString Then
            sqltgl = "1=0"
        ElseIf deTglMulai.EditValue <> vbNullString And deTglSelesai.EditValue = vbNullString Then
            sqltgl = " s.tanggal > convert(date,'" & deTglMulai.Text & "',103)"
        ElseIf deTglMulai.EditValue = vbNullString And deTglSelesai.EditValue <> vbNullString Then
            sqltgl = " s.tanggal < convert(date,'" & deTglSelesai.Text & "',103)"
        ElseIf deTglMulai.EditValue <> vbNullString And deTglSelesai.EditValue <> vbNullString Then
            sqltgl = " s.tanggal between convert(date,'" & deTglMulai.Text & "',103) and convert(date,'" & deTglSelesai.Text & "',103)"
            'ElseIf tglDari.EditValue <> vbNullString And tglsampai.EditValue <> vbNullString Then
            '    sqltgl = sqltgl & "and gdo.blthn='" & lookupBulanAwal.EditValue & "'"
            'Else
            '    'jika tgl dari kosong,tgl akhir kosong maka
            '    sqltgl = sqltgl & " gdo.blthn='" & lookupBulanAwal.EditValue & "'"
        End If

        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select distinct dep.Nama_Departemen , m.rec_stat, s.Tanggal, m.no_spk_man_rls No_SPK_Rls, " & _
                                                                   "m.no_spk_man No_SPK, g.Desc_Data [KEGIATAN],m.kd_kegiatan_spk, m.kd_kegiatan ,g1.Desc_Data [KEGIATAN_SPK], " & _
                                                                   "p.Nama_Pegawai [PEGAWAI], g2.Desc_Data [GROUP_KERJA],u.kd_mesin [MESIN], " & _
                                                                   "s.no_rph [NO_RPH],  no_posting = CASE when d.no_posting  Is  NULL OR d.no_posting = '' THEN '' else 'Sudah Posting' end " & _
                                                                   ",status_hpp = CASE when hp.no_spk_man_rls is NOT NULL THEN 'HPP Created' else '' end " & _
                                                                   "from PROD.dbo.PROD_rls_spk_man_m m " & _
                                                                   "left join PROD.dbo.PROD_rls_spk_man_d d " & _
                                                                   "on d.no_spk_man = m.no_spk_man and d.no_spk_man_rls = m.no_spk_man_rls  " & _
                                                                   "and d.kd_kegiatan = m.kd_kegiatan and d.kd_kegiatan_spk = m.kd_kegiatan_spk " & _
                                                                   "left join PROD.dbo.PROD_hpp_produksi hp " & _
                                                                   "on hp.no_spk_man = m.no_spk_man and hp.no_spk_man_rls = d.no_spk_man_rls " & _
                                                                   "left join SIF.dbo.SIF_Gen_Reff_D g " & _
                                                                   "on g.Id_Data=m.kd_kegiatan " & _
                                                                   "left join SIF.dbo.SIF_Gen_Reff_D g1 " & _
                                                                   "on g1.Id_Data=m.kd_kegiatan_spk " & _
                                                                   "left join SIF.dbo.SIF_Gen_Reff_D g2 " & _
                                                                   "on g2.Id_Data=m.group_kerja " & _
                                                                   "left join SIF.dbo.SIF_Departemen dep " & _
                                                                   "on dep.Kd_Departemen = m.kd_departemen " & _
                                                                   "left join SIF.dbo.SIF_Pegawai p " & _
                                                                   "on p.Kode_Pegawai=m.kd_pegawai " & _
                                                                   "left join SIF.dbo.SIF_mesin_prod u " & _
                                                                   "on u.kd_mesin=m.kd_mesin " & _
                                                                   "left join PROD.dbo.PROD_spk_m s " & _
                                                                   "on s.no_spk=m.no_spk_man " & _
                                                                   "and s.kd_kegiatan=m.kd_kegiatan " & _
                                                                   "and s.kd_kegiatan_spk=m.kd_kegiatan_spk " & _
                                                                   "where (m.sts_centi='Y') and g1.Id_Ref_File='SPK' and s.no_rph is not null " & _
                                                                   "and g.Id_Ref_File='KGTSPK' and m.kd_departemen='" & kddep & "' and g2.Id_Ref_File='GRPKERJA' and " & sqltgl & "  " & _
                                                                   "order by s.Tanggal  ", sqlconn))
        da.SelectCommand.CommandTimeout = 0
        da.Fill(ds, "_MonQC")

        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("Select  sm.no_spk_man_rls, rd.kd_barang,br.Nama_Barang, rd.no_urut, rd.jumlah_kerja " & _
                                                "From PROD.dbo.PROD_rls_spk_man_m sm " & _
                                                "left join PROD.dbo.PROD_rls_spk_man_d rd " & _
                                                "on rd.no_spk_man = sm.no_spk_man and rd.no_spk_man_rls = sm.no_spk_man_rls " & _
                                                "and rd.kd_kegiatan = sm.kd_kegiatan and rd.kd_kegiatan_spk = sm.kd_kegiatan_spk " & _
                                                "left join PROD.dbo.PROD_spk_m s " & _
                                                "on s.no_spk = sm.no_spk_man and s.kd_kegiatan = sm.kd_kegiatan " & _
                                                "and s.kd_kegiatan_spk = sm.kd_kegiatan_spk " & _
                                                "left join SIF.dbo.SIF_Barang br " & _
                                                "on br.Kode_Barang = rd.kd_barang " & _
                                                "where  " & sqltgl & "  " & _
                                                "ORDER BY sm.no_spk_man_rls, rd.kd_barang,rd.no_urut ASC ", sqlconn))
        da.SelectCommand.CommandTimeout = 0
        da.Fill(ds, "_MonProd")

        da = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("Select  sm.no_spk_man_rls,sm.kd_kegiatan, sm.kd_kegiatan_spk, rsp.kd_barang, rsp.no_urut, br.Nama_Barang, sp.kd_barang kd_barang_sp , " & _
                                                                   "br1.Nama_Barang as Nama_Barang_SP,br1.Kd_Satuan, rsp.tinggi, rsp.lebar, rsp.panjang,  rsp.jumlah " & _
                                                                   "From PROD.dbo.PROD_rls_spk_man_m sm " & _
                                                                   "left join PROD.dbo.PROD_rls_spk_man_d rd " & _
                                                                   "on rd.no_spk_man = sm.no_spk_man " & _
                                                                   "and rd.no_spk_man_rls = sm.no_spk_man_rls and rd.kd_kegiatan = sm.kd_kegiatan " & _
                                                                   "and rd.kd_kegiatan_spk = sm.kd_kegiatan_spk  " & _
                                                                   "inner join PROD.dbo.PROD_rls_spk_man_sp rsp " & _
                                                                   "on rsp.no_spk_man = rd.no_spk_man and rsp.no_spk_man_rls = rd.no_spk_man_rls " & _
                                                                   "and rsp.kd_kegiatan = rd.kd_kegiatan and rsp.kd_kegiatan_spk = rd.kd_kegiatan_spk " & _
                                                                   "and rsp.no_urut = rd.no_urut and rsp.kd_barang = rd.kd_barang " & _
                                                                   "left join PROD.dbo.PROD_spk_sp sp " & _
                                                                   "on sp.no_spk = rsp.no_spk_man and sp.kd_kegiatan = rsp.kd_kegiatan and sp.kd_kegiatan_spk = rsp.kd_kegiatan_spk " & _
                                                                   "and sp.no_urut_brg = rsp.no_urut and sp.no_sp = rsp.no_sp " & _
                                                                   "and sp.no_sp_dtl = rsp.no_sp_dtl  and sp.no_seq = rsp.no_seq " & _
                                                                   "left join sif.dbo.SIF_Barang br1 " & _
                                                                   "on br1.Kode_Barang = sp.kd_barang " & _
                                                                   "left join PROD.dbo.PROD_spk_m s  " & _
                                                                   "on s.no_spk = sm.no_spk_man and s.kd_kegiatan = sm.kd_kegiatan  " & _
                                                                   "and s.kd_kegiatan_spk = sm.kd_kegiatan_spk " & _
                                                                   "left join SIF.dbo.SIF_Barang br on br.Kode_Barang = rsp.kd_barang " & _
                                                                   "where  " & sqltgl & "  " & _
                                                                   "ORDER BY sm.no_spk_man_rls, rd.kd_barang,rd.no_urut ASC  ", sqlconn))
        da.SelectCommand.CommandTimeout = 0
        da.Fill(ds, "_MonProd1")

        col1(0) = ds.Tables("_MonQC").Columns("No_SPK_Rls")
        col1(1) = ds.Tables("_MonQC").Columns("kd_kegiatan")
        col1(2) = ds.Tables("_MonQC").Columns("kd_kegiatan_spk")

        col2(0) = ds.Tables("_MonProd1").Columns("no_spk_man_rls")
        col2(1) = ds.Tables("_MonProd1").Columns("kd_kegiatan")
        col2(2) = ds.Tables("_MonProd1").Columns("kd_kegiatan_spk")

        rl = ds.Relations.Add("RelJurDet", ds.Tables("_MonQC").Columns("No_SPK_Rls"), ds.Tables("_MonProd").Columns("no_spk_man_rls"), False)
        r2 = ds.Relations.Add("RelJurDet1", col1, col2, False)


        GcMultiBME.DataSource = ds.Tables("_MonQC")
        GcMultiBME.LevelTree.Nodes.Add("RelJurDet", GV_Barang)
        GcMultiBME.LevelTree.Nodes.Add("RelJurDet1", GV_SP)
    End Sub

    Private Sub isinomer()
        Dim i As Int16 = 1
        For Each row As DataRow In ds.Tables("_MonQC").Rows
            row.Item("nomer") = i : i += 1
        Next
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        ReloadTable()

    End Sub

    Sub simul()
        Dim dr As SqlDataReader
        'Dim BTRANS As SqlTransaction
        Dim notrans_simulasi, no_spk As String

        notrans_simulasi = no_realisasi
        notrans_simulasi1 = notrans_simulasi
        no_spk = no_spk1

        If jenis_realisasi = "H" Then
            If Not ds1.Tables("Barang_d") Is Nothing Then ds1.Tables("Barang_d").Clear()
            da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_simul_bhn_m_temp where 1=0 ", sqlconn))
            da7.Fill(ds1, "Barang_d")

            '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            'dr = New SqlClient.SqlCommand("select kd_barang, jumlah_kerja from PROD.dbo.PROD_rls_spk_man_d d " & _
            '                              "where d.no_spk_man_rls = '" & no_spk & "' ", sqlconn).ExecuteReader

            dr = New SqlClient.SqlCommand("select kd_barang, sum(jumlah_kerja) as jumlah_kerja, d.no_posting from PROD.dbo.PROD_rls_spk_man_d d " & _
                                          "where d.no_spk_man_rls = '" & no_realisasi & "' " & _
                                          "and (d.no_posting is  null or d.no_posting = '') " & _
                                          "GROUP BY d.kd_barang, d.no_posting", sqlconn).ExecuteReader
            While dr.Read()
                If dr.Item("jumlah_kerja") > 0 Then
                    Dim rw As DataRow = ds1.Tables("Barang_d").NewRow
                    rw("kd_cabang") = kdcabang
                    rw("kd_departemen") = kddep
                    rw("no_trans") = notrans_simulasi
                    rw("kd_brg") = dr.Item("kd_barang")
                    rw("jumlah") = dr.Item("jumlah_kerja")
                    rw("tipe_trans") = "3"
                    ds1.Tables("Barang_d").Rows.Add(rw)


                Else
                    dr.Close()

                End If
            End While
            dr.Close()



            'For i = gv.RowCount - 1 To 0 Step -1

            '    If Not TypeOf gv.GetRowCellValue(i, "jumlah_kerja") Is DBNull Then
            '        If gv.GetRowCellValue(i, "jumlah_kerja") > 0 Then
            '            Dim rw As DataRow = ds1.Tables("Barang_d").NewRow
            '            rw("kd_cabang") = kdcabang
            '            rw("kd_departemen") = kddep
            '            rw("no_trans") = notrans_simulasi
            '            rw("kd_brg") = gv.GetRowCellValue(i, "kd_barang")
            '            rw("jumlah") = gv.GetRowCellValue(i, "jumlah_kerja")
            '            rw("tipe_trans") = "3"
            '            ds1.Tables("Barang_d").Rows.Add(rw)

            '        Else

            '        End If
            '    Else

            '    End If
            'Next

            Dim BTRANS1 As SqlTransaction
            mb2 = New SqlClient.SqlCommandBuilder(da7)
            da7.UpdateCommand = mb2.GetUpdateCommand()
            da7.InsertCommand = mb2.GetInsertCommand()
            da7.DeleteCommand = mb2.GetDeleteCommand()

            BTRANS1 = sqlconn.BeginTransaction("1")
            da7.UpdateCommand.Transaction = BTRANS1
            da7.InsertCommand.Transaction = BTRANS1
            da7.DeleteCommand.Transaction = BTRANS1

            da7.Update(ds1.Tables("Barang_d"))
            ds1.Tables("Barang_d").AcceptChanges()



            BTRANS1.Commit()


            Dim sqlCmd As New SqlCommand
            Try
                sqlCmd.Connection = sqlconn
                sqlCmd.CommandType = CommandType.StoredProcedure
                sqlCmd.CommandText = "PROD.dbo.prodp_ins_simul_bahan_temp3"
                sqlCmd.Parameters.Add("@vno_trans", SqlDbType.Char).Value = notrans_simulasi1
                sqlCmd.Parameters.Add("@vno_spk_m", SqlDbType.Char).Value = no_spk
                dr = sqlCmd.ExecuteReader
                dr.Close()
            Catch ex As Exception
                dr.Close()
            End Try
           

        ElseIf jenis_realisasi = "D" Then
            If Not ds1.Tables("Barang_d") Is Nothing Then ds1.Tables("Barang_d").Clear()
            da7 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_simul_bhn_m_temp where 1=0 ", sqlconn))
            da7.Fill(ds1, "Barang_d")

            '++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            'dr = New SqlClient.SqlCommand("select kd_barang, jumlah_kerja from PROD.dbo.PROD_rls_spk_man_d d " & _
            '                              "where d.no_spk_man_rls = '" & no_spk & "' ", sqlconn).ExecuteReader

            dr = New SqlClient.SqlCommand("Select d.kd_barang,b.Nama_Barang,sum(jumlah) as jumlah, " & _
                                          "SUM((((d.panjang * d.lebar)* d.tinggi)/1000000) * d.jumlah) as jml_blok " & _
                                          "from PROD.dbo.PROD_rls_spk_man_sp d " & _
                                          "INNER JOIN (Select Distinct a.no_rph,a.no_spk from PROD.dbo.PROD_spk_m a) c " & _
                                          "on c.no_spk = d.no_spk_man " & _
                                          "INNER JOIN PROD.dbo.PROD_rls_spk_man_m m " & _
                                          "on m.no_spk_man = d.no_spk_man and m.no_spk_man_rls = d.no_spk_man_rls " & _
                                          "left JOIN SIF.dbo.SIF_Barang b " & _
                                          "on b.Kode_Barang = d.kd_barang " & _
                                          "where d.no_spk_man_rls = '" & no_realisasi & "' " & _
                                          "and (d.no_posting is null or d.no_posting ='') " & _
                                          "GROUP BY d.kd_barang,b.Nama_Barang", sqlconn).ExecuteReader
            While dr.Read()
                If dr.Item("jumlah") > 0 Then
                    Dim rw As DataRow = ds1.Tables("Barang_d").NewRow
                    rw("kd_cabang") = kdcabang
                    rw("kd_departemen") = kddep
                    rw("no_trans") = notrans_simulasi
                    rw("kd_brg") = dr.Item("kd_barang")
                    rw("jumlah") = dr.Item("jml_blok")
                    rw("tipe_trans") = "3"
                    ds1.Tables("Barang_d").Rows.Add(rw)


                Else
                    dr.Close()

                End If
            End While
            dr.Close()



            'For i = gv.RowCount - 1 To 0 Step -1

            '    If Not TypeOf gv.GetRowCellValue(i, "jumlah_kerja") Is DBNull Then
            '        If gv.GetRowCellValue(i, "jumlah_kerja") > 0 Then
            '            Dim rw As DataRow = ds1.Tables("Barang_d").NewRow
            '            rw("kd_cabang") = kdcabang
            '            rw("kd_departemen") = kddep
            '            rw("no_trans") = notrans_simulasi
            '            rw("kd_brg") = gv.GetRowCellValue(i, "kd_barang")
            '            rw("jumlah") = gv.GetRowCellValue(i, "jumlah_kerja")
            '            rw("tipe_trans") = "3"
            '            ds1.Tables("Barang_d").Rows.Add(rw)

            '        Else

            '        End If
            '    Else

            '    End If
            'Next

            Dim BTRANS1 As SqlTransaction
            mb2 = New SqlClient.SqlCommandBuilder(da7)
            da7.UpdateCommand = mb2.GetUpdateCommand()
            da7.InsertCommand = mb2.GetInsertCommand()
            da7.DeleteCommand = mb2.GetDeleteCommand()

            BTRANS1 = sqlconn.BeginTransaction("1")
            da7.UpdateCommand.Transaction = BTRANS1
            da7.InsertCommand.Transaction = BTRANS1
            da7.DeleteCommand.Transaction = BTRANS1

            da7.Update(ds1.Tables("Barang_d"))
            ds1.Tables("Barang_d").AcceptChanges()
            BTRANS1.Commit()


            Dim sqlCmd As New SqlCommand
            Try
                sqlCmd.Connection = sqlconn
                sqlCmd.CommandType = CommandType.StoredProcedure
                sqlCmd.CommandText = "PROD.dbo.prodp_ins_simul_bahan_temp_centi"
                sqlCmd.Parameters.Add("@vno_trans", SqlDbType.Char).Value = notrans_simulasi1
                sqlCmd.Parameters.Add("@vno_spk_m", SqlDbType.Char).Value = no_spk
                dr = sqlCmd.ExecuteReader
                dr.Close()
            Catch ex As Exception
                dr.Close()
            End Try
            
        End If

       


    End Sub
    Sub Simpan_Hpp_Produksi()
        If no_realisasi = vbNullString Or no_realisasi = "" Then
            MsgBox("Transasksi realisasi belum disimpan.", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader
        sqlCmd.CommandTimeout = 0
        sqlCmd.Connection = sqlconn
        ' sqlCmd.Transaction = btrans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "PROD.dbo.prodp_ins_hpp_produksi"
        sqlCmd.Parameters.Add("@no_rls_spk_man", SqlDbType.VarChar, 40).Value = no_realisasi
        dr = sqlCmd.ExecuteReader
        dr.Close()
        'MsgBox("HPP Created", MsgBoxStyle.Information)
    End Sub

    Sub Simpan_Hpp_Produksi_Centian()
        If no_realisasi = vbNullString Or no_realisasi = "" Then
            MsgBox("Transasksi realisasi belum disimpan.", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader
        sqlCmd.CommandTimeout = 0
        sqlCmd.Connection = sqlconn
        ' sqlCmd.Transaction = btrans
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "PROD.dbo.prodp_ins_hpp_produksi_centian"
        sqlCmd.Parameters.Add("@no_rls_spk_man", SqlDbType.VarChar, 40).Value = no_realisasi
        dr = sqlCmd.ExecuteReader
        dr.Close()
        'MsgBox("HPP Created", MsgBoxStyle.Information)
    End Sub
    Public Sub save_click()
        'If status_posting = "Sudah Posting" Then
        '    MsgBox("HPP sudah diposting, generate HPP gagal", MsgBoxStyle.Critical)
        '    Exit Sub
        'End If
        Dim dr1, dr As SqlDataReader

        dr = New SqlClient.SqlCommand("Delete PROD.dbo.PROD_simul_bhn_m_temp ", sqlconn).ExecuteReader
        dr.Close()

        dr = New SqlClient.SqlCommand("Delete PROD.dbo.PROD_simul_bhn_d_temp ", sqlconn).ExecuteReader
        dr.Close()



        For i = Gv.RowCount - 1 To 0 Step -1

            If Not TypeOf Gv.GetRowCellValue(i, "rec_stat") Is DBNull Then
                If Gv.GetRowCellValue(i, "rec_stat") = "Y" Then

                    dr = New SqlClient.SqlCommand("Select g.Val_kode1 from SIF.dbo.SIF_Gen_Reff_D g " & _
                                          "where g.Ref_Role = 'PROD' and g.Id_Ref_File = 'SPK' " & _
                                          "and g.Id_Data ='" & Gv.GetRowCellValue(i, "kd_kegiatan_spk") & "'", sqlconn).ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        If dr.Item(0) = "D" Then
                            jenis_realisasi = "D"
                        Else
                            jenis_realisasi = "H"
                        End If

                    End If
                    dr.Close()

                    no_realisasi = Gv.GetRowCellValue(i, "No_SPK_Rls")
                    no_spk1 = Gv.GetRowCellValue(i, "No_SPK")
                    '  MsgBox(no_realisasi, MsgBoxStyle.Information)
                    simul()
                    '--- Untuk mengecek ketersediaan bahan baku --------'
                    'dr1 = New SqlClient.SqlCommand("select COUNT(isnull(d.jumlah_stok,0)-isnull(d.jumlah,0))  from PROD.dbo.PROD_simul_bhn_d_temp d " & _
                    '                               "where no_trans = '" & notrans_simulasi1 & "' and isnull(d.jumlah_stok,0)-isnull(d.jumlah,0)  < 0", sqlconn).ExecuteReader
                    'dr1.Read()
                    'If dr1.HasRows Then
                    '    If dr1.Item(0) > 0 Then
                    '        MsgBox("Bahan baku tidak mencukupi, Generate HPP tidak bisa diproses", MsgBoxStyle.Critical)
                    '        dr1.Close()
                    '        frmDtlSO3.notrans_simulasi = notrans_simulasi1
                    '        frmDtlSO3.ShowDialog()
                    '        Exit Sub
                    '    Else
                    '        dr1.Close()

                    '    End If
                    'Else
                    '    dr1.Close()
                    'End If

                    If jenis_realisasi = "H" Then
                        Simpan_Hpp_Produksi()
                    ElseIf jenis_realisasi = "D" Then
                        Simpan_Hpp_Produksi_Centian()
                    End If



                Else

                End If
            Else

            End If
        Next
        MsgBox("Proses Generate HPP Selesai.", MsgBoxStyle.Information)
        ReloadTable()
    End Sub
    Public Sub cetak_click()
        Dim BTRANZ As SqlTransaction
        BTRANZ = sqlconn.BeginTransaction("1")
        For Each rw As DataRow In ds.Tables("_MonQC").Select("rec_stat='Y'")
            Try
                Dim i As Int16 = New SqlCommand("update PROD.dbo.PROD_rcn_krm_m set cetak_ulang='T', cetak_ke = cetak_ke + 1 where no_trans='" & rw.Item("no_trans") & "'", sqlconn, BTRANZ).ExecuteNonQuery
                If i > 0 Then
                    MsgBox(rw.Item("no_spk_man").ToString)
                    Dim a As String = ""
                    a = rw.Item("no_spk_man")
                    MsgBox(a)
                    callReport(App_Path() & "\report\PROD_RcnKrm.rpt", "", "no_trans=" & a)

                Else

                End If
            Catch e As Exception

                MsgBox("Gagal Cetak", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
                Exit Sub
            End Try
        Next
        'Dim a As String
        'a = "201305/KRM/00008"
        'callReport(App_Path() & "\report\PROD_RcnKrm.rpt", "", "no_trans=" & a)
        MsgBox("Data Telah Diproses", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Cetak")
        ds.Tables("_MonQC").Clear()
        'dsete.Tables("SOD").Clear()
    End Sub


    Private Sub Btn_pilih_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_pilih.Click
        btn_deselect.Enabled = True
        Btn_pilih.Enabled = False
        'For Each klik As DataRow In ds.Tables("_MonQC").Rows
        '    klik.Item("rec_stat") = "Y"
        'Next
        For i As Integer = 0 To Gv.RowCount - 1
            Gv.SetRowCellValue(i, "rec_stat", "Y")
        Next

    End Sub
    Private Sub Btn_pilih_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub btn_deselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btn_deselect_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_deselect.Click
        btn_deselect.Enabled = False
        Btn_pilih.Enabled = True
        'For Each klik As DataRow In ds.Tables("_MonQC").Rows
        '    klik.Item("rec_stat") = "T"
        'Next
        For i As Integer = 0 To Gv.RowCount - 1
            Gv.SetRowCellValue(i, "rec_stat", "T")
        Next
    End Sub
End Class