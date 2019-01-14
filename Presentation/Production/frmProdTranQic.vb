Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns
Public Class frmProdTranQic
    Dim ds1, ds2, ds3, ds4, ds5, ds6, ds7, dsedit As New DataSet
    Dim da1, da2, da3, da4, da5, da6, da7, daedit As New SqlDataAdapter
    Dim row, rows, row1, rows1 As DataRow
    Dim mb, mb1, mb2, mb3 As New SqlCommandBuilder
    Dim prn As frmMain
    Dim nilai As String
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Dim isinvalid As Boolean
    Public State, kode, kode1, kode2, kode3, kode4, kode5 As String
    Dim rl, rl1 As DataRelation
    Dim l, k, j, m As Integer
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub
    Public Sub add_click()
        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnAdd = False
        State = "ADD"
        setStatus()
    End Sub
    Private Sub frmProdTranQic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        State = "ADD"
        da1 = New SqlDataAdapter(New SqlCommand("select distinct no_rph from PROD.dbo.PROD_qic_m_temp where rec_stat='S' and kd_departemen = '" & kddep & "'", sqlconn))
        da1.Fill(ds1, "norph")
        lkrph.Properties.DataSource = ds1.Tables("norph")
        lkrph.Properties.ValueMember = "no_rph"
        lkrph.Properties.DisplayMember = "no_rph"

        If Not ds2.Tables("QICD") Is Nothing Then ds2.Tables("QICD").Clear()
        If Not ds4.Tables("QICMD") Is Nothing Then ds4.Tables("QICMD").Clear()
        da4 = New SqlDataAdapter(New SqlCommand("select* from PROD.dbo.PROD_qic_m ", sqlconn))
        da4.Fill(ds4, "QICM")
        da5 = New SqlDataAdapter(New SqlCommand("select* from PROD.dbo.PROD_qic_d ", sqlconn))
        da5.Fill(ds4, "QICMD")

    End Sub
    Private Sub loadlookup()
        If Not ds1.Tables("loadnama") Is Nothing Then ds1.Tables("loadnama").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        da1.Fill(ds1, "loadnama")
        lkkdbarang.DataSource = ds1.Tables("loadnama")
        lkkdbarang.DisplayMember = "Nama_Barang"
        lkkdbarang.ValueMember = "Kode_Barang"

        '    da1 = New SqlDataAdapter(New SqlCommand("select Kode_Barang, tipe_stok from SIF.dbo.SIF_Barang", sqlconn))
        '    da1.Fill(ds1, "loadtipe")
        '    lktipe.DataSource = ds1.Tables("loadtipe")
        '    lktipe.DisplayMember = "tipe_stok"
        '    lktipe.ValueMember = "Kode_Barang"

        '    da1 = New SqlDataAdapter(New SqlCommand("select a.Kode_Barang, b.Merk_Kain from SIF.dbo.SIF_Barang a, SIF.dbo.SIF_Kain b WHERE a.kd_kain=b.Kode_Kain", sqlconn))
        '    da1.Fill(ds1, "loadkain")
        '    lkkain.DataSource = ds1.Tables("loadkain")
        '    lkkain.DisplayMember = "Merk_Kain"
        '    lkkain.ValueMember = "Kode_Barang"

        '    da1 = New SqlDataAdapter(New SqlCommand("select a.Kode_Barang, b.Nama_Ukuran from SIF.dbo.SIF_Barang a, SIF.dbo.SIF_Ukuran b where a.kd_ukuran=b.Kode_Ukuran", sqlconn))
        '    da1.Fill(ds1, "loadukuran")
        '    lkukuran.DataSource = ds1.Tables("loadukuran")
        '    lkukuran.DisplayMember = "Nama_Ukuran"
        '    lkukuran.ValueMember = "Kode_Barang"


    End Sub
    Private Sub loadData()
        Dim dr As SqlDataReader
        If State = "ADD" Then
            If Not ds2.Tables("QICD") Is Nothing Then ds2.Tables("QICD").Clear()
            da3 = New SqlDataAdapter(New SqlCommand("Select d.*,'' Nama_Barang,'' kd_tipe,'' Nama_Tipe,'' kd_kain,'' Merk_Kain,'' kd_ukuran, " & _
                                                   "'' Nama_Ukuran,'' Desc_Data,0.00 jml_qic_real, " & _
                                                   "0.00 jml_prod_sisa from PROD.dbo.PROD_qic_d d where 1=0", sqlconn))
            da3.Fill(ds2, "QICD")
            dr = New SqlClient.SqlCommand("Select d.*,b.Nama_Barang,b.kd_tipe,t.Nama_Tipe,b.kd_kain,k.Merk_Kain,b.kd_ukuran, " & _
                                                    "u.Nama_Ukuran,s.Desc_Data,ISNULL(j.jumlah_qic,0)as jml_qic_real, " & _
                                                    "(d.jml_prod-ISNULL(j.jumlah_qic,0)) as jml_prod_sisa from PROD.dbo.PROD_qic_d_temp d " & _
                                                    "left join (Select sum(jml_qic)as jumlah_qic,no_rph,kd_kegiatan,kd_barang From PROD.dbo.PROD_qic_d " & _
                                                    "Group by no_rph,kd_kegiatan,kd_barang ) j " & _
                                                    "on j.no_rph = d.no_rph and j.kd_kegiatan=d.kd_kegiatan and j.kd_barang=d.kd_barang " & _
                                                    "left join  SIF.dbo.SIF_barang b " & _
                                                    "on b.Kode_Barang = d.kd_barang " & _
                                                    "left join SIF.dbo.SIF_Tipe t " & _
                                                    "on t.Kode_Tipe = b.kd_tipe " & _
                                                    "left join SIF.dbo.SIF_Kain k " & _
                                                    "on k.Kode_Kain = b.kd_kain " & _
                                                    "left join SIF.dbo.SIF_Ukuran u " & _
                                                    "on u.Kode_Ukuran= b.kd_ukuran " & _
                                                    "left join (Select Id_Data,Desc_Data FROM SIF.dbo.SIF_Gen_Reff_D where Ref_Role='PROD' and Id_Ref_Data='KGTSPK') s " & _
                                                    "on s.Id_data = d.kd_kegiatan " & _
                                                    "WHERE d.no_rph ='" & lkrph.EditValue & "' and d.kd_kegiatan='" & lkkegiatan.EditValue & "' and (d.jml_prod-ISNULL(j.jumlah_qic,0))<> 0", sqlconn).ExecuteReader
            While dr.Read
                Dim rwm1 As DataRow = ds2.Tables("QICD").NewRow
                rwm1("kd_barang") = dr.Item("kd_barang")
                rwm1("Nama_Barang") = dr.Item("Nama_Barang")
                rwm1("Nama_Tipe") = dr.Item("Nama_Tipe")
                rwm1("Merk_Kain") = dr.Item("Merk_Kain")
                rwm1("Nama_Ukuran") = dr.Item("Nama_Ukuran")
                rwm1("jml_prod") = CInt(dr.Item("jml_prod"))
                rwm1("jml_prod_sisa") = dr.Item("jml_prod_sisa")
                rwm1("jml_qic") = dr.Item("jml_qic")
                ds2.Tables("QICD").Rows.Add(rwm1)
            End While
            dr.Close()

            GridControl1.DataSource = ds2.Tables("QICD")
            GridView2.BestFitColumns()
        End If



        'da2 = New SqlDataAdapter(New SqlCommand("select distinct kd_jns_brg,Nama_Jenis from PROD.dbo.PROD_rcn_prod_d b, SALES.dbo.SALES_SO_D c,SIF.dbo.SIF_barang d,SIF.dbo.SIF_Jenis_Barang h where  b.no_sp=c.no_sp and b.no_sp_dtl=c.no_seq and c.kd_stok=d.kode_barang and b.no_rph= '" & lkrph.EditValue & "' and h.Kd_Departemen= '" & kddep & "' and d.kd_jns_persd=h.kd_jns_persd and d.kd_jenis=h.Kd_Jns_brg", sqlconn))
        'da2.Fill(ds2, "QIC")




    End Sub

    Private Sub lkrph_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkrph.EditValueChanged
        If State = "ADD" Then

            'If Not ds1.Tables("isirph") Is Nothing Then ds1.Tables("isirph").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rcn_prod_m a,SIF.dbo.SIF_Gen_Reff_D c where a.no_rph='" & lkrph.EditValue & "' and a.kd_jadwal=c.id_data and c.ref_role='PROD' and c.id_Ref_File='JDWKRJ'", sqlconn))
            da1.Fill(ds1, "isirph")


            txtjdwl.Text = ds1.Tables("isirph").Rows(0).Item("desc_data").ToString
            txttanggal.Text = Now.Date

            lkkegiatan.EditValue = Nothing
            If Not ds1.Tables("kegiatanspk") Is Nothing Then ds1.Tables("kegiatanspk").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("Select m.kd_kegiatan,s.desc_data from PROD.dbo.PROD_qic_m_temp m " & _
                                                    "left join (Select Id_Data,Desc_Data FROM SIF.dbo.SIF_Gen_Reff_D where Ref_Role='PROD' and Id_Ref_Data='KGTSPK') s " & _
                                                    "on s.Id_data = m.kd_kegiatan " & _
                                                    "WHERE m.no_rph ='" & lkrph.EditValue & "' ", sqlconn))
            da1.Fill(ds1, "kegiatanspk")
            lkkegiatan.Properties.DataSource = ds1.Tables("kegiatanspk")
            lkkegiatan.Properties.ValueMember = "kd_kegiatan"
            lkkegiatan.Properties.DisplayMember = "desc_data"



        ElseIf State = "EDIT" Then
            'If Not ds1.Tables("isirph") Is Nothing Then ds1.Tables("isirph").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rcn_prod_m a,SIF.dbo.SIF_Gen_Reff_D c where a.no_rph='" & lkrph.EditValue & "' and a.kd_jadwal=c.id_data and c.ref_role='PROD' and c.id_Ref_File='JDWKRJ'", sqlconn))
            da1.Fill(ds1, "isirph")


            txtjdwl.Text = ds1.Tables("isirph").Rows(0).Item("desc_data").ToString
            txttanggal.Text = Now.Date

            If Not ds1.Tables("kegiatanspk") Is Nothing Then ds1.Tables("kegiatanspk").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("Select m.kd_kegiatan,s.desc_data from PROD.dbo.PROD_qic_m_temp m " & _
                                                    "left join (Select Id_Data,Desc_Data FROM SIF.dbo.SIF_Gen_Reff_D where Ref_Role='PROD' and Id_Ref_Data='KGTSPK') s " & _
                                                    "on s.Id_data = m.kd_kegiatan " & _
                                                    "WHERE m.no_rph ='" & lkrph.EditValue & "' ", sqlconn))
            da1.Fill(ds1, "kegiatanspk")
            lkkegiatan.Properties.DataSource = ds1.Tables("kegiatanspk")
            lkkegiatan.Properties.ValueMember = "kd_kegiatan"
            lkkegiatan.Properties.DisplayMember = "desc_data"

            'loadlookup()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        save_click()
    End Sub


    Public Sub save_click()
        Dim notrans As String
        'Dim BTRANS As SqlTransaction
        'BTRANS = sqlconn.BeginTransaction("1")
        If State = "ADD" Then
            notrans = getNoTrans("PRODHSL", getTanggal)
            txt_no_hsl.Text = notrans
            row = ds4.Tables("QICM").NewRow
            row.Item("no_hsl_prod") = notrans
            row.Item("tanggal") = txttanggal.Text
            row.Item("no_rph") = lkrph.EditValue
            row.Item("kd_kegiatan") = lkkegiatan.EditValue
            row.Item("kd_cabang") = getKodeCabang()
            row.Item("kd_departemen") = kddep
            row.Item("rec_stat") = "R"
            row.Item("Last_Create_Date") = Now
            row.Item("Last_Created_By") = umum.username
            row.Item("Program_Name") = Me.Name
            ds4.Tables("QICM").Rows.Add(row)

        ElseIf State = "EDIT" Then
            row = ds4.Tables("QICM").Rows(0)

            row.Item("Last_update_Date") = Now
            row.Item("Last_updated_By") = umum.username

        End If

        If State = "ADD" Then
            For l As Integer = 0 To ds2.Tables("QICD").Rows.Count - 1

                rows = ds4.Tables("QICMD").NewRow
                rows.Item("no_hsl_prod") = notrans
                rows.Item("kd_kegiatan") = lkkegiatan.EditValue
                rows.Item("kd_cabang") = getKodeCabang()
                rows.Item("kd_departemen") = kddep
                rows.Item("rec_stat") = "R"
                rows.Item("Last_Create_Date") = Now
                rows.Item("Last_Created_By") = umum.username
                rows.Item("Program_Name") = Me.Name
                rows.Item("kd_barang") = ds2.Tables("QICD").Rows(l).Item("kd_barang").ToString
                rows.Item("no_rph") = lkrph.EditValue
                rows.Item("jml_prod") = ds2.Tables("QICD").Rows(l).Item("jml_prod").ToString
                rows.Item("jml_qic") = ds2.Tables("QICD").Rows(l).Item("jml_qic").ToString
                ds4.Tables("QICMD").Rows.Add(rows)

            Next

        ElseIf State = "EDIT" Then
            For m As Integer = 0 To ds5.Tables("QICd").Rows.Count - 1

                rows = ds4.Tables("QICMD").Rows(0)

                rows.Item("jml_qic") = ds5.Tables("QICd").Rows(m).Item("jml_qic").ToString
                rows.Item("Last_update_Date") = Now
                rows.Item("Last_updated_By") = umum.username

            Next

        End If

        If State = "ADD" Then
            If Not ds6.Tables("Bahan_M") Is Nothing Then ds6.Tables("Bahan_M").Clear()
            da6 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_ba_bahan_m", sqlconn))
            da6.Fill(ds6, "Bahan_M")
            row1 = ds6.Tables("Bahan_M").NewRow
            row1.Item("no_hsl_prod") = txt_no_hsl.Text
            row1.Item("tanggal") = txttanggal.Text
            row1.Item("no_rph") = lkrph.EditValue
            row1.Item("kd_kegiatan") = lkkegiatan.EditValue
            row1.Item("kd_cabang") = getKodeCabang()
            row1.Item("kd_departemen") = kddep
            row1.Item("rec_stat") = "R"
            row1.Item("Last_Create_Date") = Now
            row1.Item("Last_Created_By") = umum.username
            row1.Item("Program_Name") = Me.Name
            ds6.Tables("Bahan_M").Rows.Add(row1)

            If Not ds7.Tables("Bahan_D") Is Nothing Then ds7.Tables("Bahan_D").Clear()
            da7 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_ba_bahan_d", sqlconn))
            da7.Fill(ds7, "Bahan_D")


            For i As Int16 = 0 To GridView2.RowCount - 1
                Dim dr, dr1, dr2 As SqlDataReader
                Dim nilai_rata_in As Double
                dr1 = New SqlClient.SqlCommand("select SUM( I.nilai_rata  * bd.jumlah) as nilai_rata, " & _
                                               "(SUM( I.nilai_rata  * bd.jumlah)*" & GridView2.GetRowCellValue(i, "jml_qic") & ") as nilai_rata_in from SIF.dbo.SIF_bom_d bd " & _
                                               "left join INV.dbo.INV_STOK_SALDO I " & _
                                               "on i.kd_stok = bd.kd_barang " & _
                                               "where bd.kd_bom = '" & GridView2.GetRowCellValue(i, "kd_barang") & "' " & _
                                               "and I.bultah = (select MAX(SL.bultah)  from INV.dbo.INV_STOK_SALDO SL " & _
                                               "where SL.kd_stok = bd.kd_barang )", sqlconn).ExecuteReader
                dr1.Read()


                dr2 = New SqlClient.SqlCommand("Select (SUM(b.nilai) * " & GridView2.GetRowCellValue(i, "jml_qic") & ")as nilai_biaya from SIF.dbo.SIF_bom_biaya b " & _
                                               "where b.kd_bom = '" & GridView2.GetRowCellValue(i, "kd_barang") & "' ", sqlconn).ExecuteReader
                dr2.Read()
                nilai_rata_in = dr1.Item("nilai_rata_in") + dr2.Item("nilai_biaya")

                rows1 = ds7.Tables("Bahan_D").NewRow
                rows1.Item("no_hsl_prod") = notrans
                rows1.Item("kd_kegiatan") = lkkegiatan.EditValue
                rows1.Item("kd_cabang") = getKodeCabang()
                rows1.Item("kd_departemen") = kddep
                rows1.Item("rec_stat") = "R"
                rows1.Item("Last_Create_Date") = Now
                rows1.Item("Last_Created_By") = umum.username
                rows1.Item("Program_Name") = Me.Name
                rows1.Item("kd_barang") = GridView2.GetRowCellValue(i, "kd_barang")
                rows1.Item("no_rph") = lkrph.EditValue
                rows1.Item("jml_prod_in") = GridView2.GetRowCellValue(i, "jml_qic")
                rows1.Item("nilai_rata_in") = nilai_rata_in
                ds7.Tables("Bahan_D").Rows.Add(rows1)

                dr1.Close()
                dr2.Close()


                dr = New SqlClient.SqlCommand("select bd.kd_barang,  (bd.jumlah * " & GridView2.GetRowCellValue(i, "jml_qic") & ") as prod_out, " & _
                                              "((i.nilai_rata * bd.jumlah)* " & GridView2.GetRowCellValue(i, "jml_qic") & ") as nilai_rata_out " & _
                                              "from SIF.dbo.SIF_bom_d bd " & _
                                              "left join INV.dbo.INV_STOK_SALDO I " & _
                                              "on i.kd_stok = bd.kd_barang " & _
                                              "where bd.kd_bom = '" & GridView2.GetRowCellValue(i, "kd_barang") & "' " & _
                                              "and I.bultah = (select MAX(SL.bultah)  from INV.dbo.INV_STOK_SALDO SL " & _
                                              "where SL.kd_stok = bd.kd_barang )", sqlconn).ExecuteReader
                While dr.Read
                    rows1 = ds7.Tables("Bahan_D").NewRow
                    rows1.Item("no_hsl_prod") = notrans
                    rows1.Item("kd_kegiatan") = lkkegiatan.EditValue
                    rows1.Item("kd_cabang") = getKodeCabang()
                    rows1.Item("kd_departemen") = kddep
                    rows1.Item("rec_stat") = "R"
                    rows1.Item("Last_Create_Date") = Now
                    rows1.Item("Last_Created_By") = umum.username
                    rows1.Item("Program_Name") = Me.Name
                    rows1.Item("kd_barang") = dr.Item("kd_barang")
                    rows1.Item("no_rph") = lkrph.EditValue
                    rows1.Item("jml_prod_out") = dr.Item("prod_out")
                    rows1.Item("nilai_rata_out") = dr.Item("nilai_rata_out")
                    ds7.Tables("Bahan_D").Rows.Add(rows1)
                End While
                dr.Close()
            Next


            mb = New SqlClient.SqlCommandBuilder(da4)
            da4.UpdateCommand = mb.GetUpdateCommand()
            da4.InsertCommand = mb.GetInsertCommand()
            da4.DeleteCommand = mb.GetDeleteCommand()

            mb1 = New SqlClient.SqlCommandBuilder(da5)
            da5.UpdateCommand = mb1.GetUpdateCommand()
            da5.InsertCommand = mb1.GetInsertCommand()
            da5.DeleteCommand = mb1.GetDeleteCommand()

            mb2 = New SqlClient.SqlCommandBuilder(da6)
            da6.UpdateCommand = mb2.GetUpdateCommand()
            da6.InsertCommand = mb2.GetInsertCommand()
            da6.DeleteCommand = mb2.GetDeleteCommand()

            mb3 = New SqlClient.SqlCommandBuilder(da7)
            da7.UpdateCommand = mb3.GetUpdateCommand()
            da7.InsertCommand = mb3.GetInsertCommand()
            da7.DeleteCommand = mb3.GetDeleteCommand()



            da4.Update(ds4.Tables("QICM"))
            da5.Update(ds4.Tables("QICMD"))
            da6.Update(ds6.Tables("Bahan_M"))
            da7.Update(ds7.Tables("Bahan_D"))

            ds4.Tables("QICM").AcceptChanges()
            ds4.Tables("QICMD").AcceptChanges()
            ds6.Tables("Bahan_M").AcceptChanges()
            ds7.Tables("Bahan_D").AcceptChanges()
            showMessages("Saved..")

            For i As Int16 = 0 To GridView2.RowCount - 1
                Dim sqlCmd As New SqlCommand
                Dim dr As SqlDataReader
                sqlCmd.Connection = sqlconn
                sqlCmd.CommandType = CommandType.StoredProcedure
                sqlCmd.CommandText = "PROD.dbo.Update_Stok_Realisasi"
                sqlCmd.Parameters.Add("@kd_bom", SqlDbType.VarChar, 40).Value = GridView2.GetRowCellValue(i, "kd_barang")
                sqlCmd.Parameters.Add("@jumlah", SqlDbType.Decimal, 40).Value = GridView2.GetRowCellValue(i, "jml_qic")
                dr = sqlCmd.ExecuteReader
                dr.Close()
            Next



          

        ElseIf State = "EDIT" Then

            mb = New SqlClient.SqlCommandBuilder(da4)
            da4.UpdateCommand = mb.GetUpdateCommand()
            da4.InsertCommand = mb.GetInsertCommand()
            da4.DeleteCommand = mb.GetDeleteCommand()

            mb1 = New SqlClient.SqlCommandBuilder(da5)
            da5.UpdateCommand = mb1.GetUpdateCommand()
            da5.InsertCommand = mb1.GetInsertCommand()
            da5.DeleteCommand = mb1.GetDeleteCommand()



            da4.Update(ds4.Tables("QICM"))
            da5.Update(ds4.Tables("QICMD"))

            ds4.Tables("QICM").AcceptChanges()
            ds4.Tables("QICMD").AcceptChanges()
            showMessages("Edited..")
        End If

        


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        edit_click()
    End Sub
    Public Sub edit_click()
        Dim dr As SqlDataReader
        State = "EDIT"
        matilookup()


        ' bila menggunakan form cari
        dsedit = New DataSet
        daedit = New SqlDataAdapter(New SqlCommand("select  a.no_hsl_prod [No Realisasi Produksi],a.no_rph as [NO RPH], " & _
                                                   "a.tanggal [Tanggal],a.kd_kegiatan [Kode Kegiatan],s.Desc_Data [Area Kegiatan],b.jml_qic [Jumlah Realisasi] from PROD.dbo.PROD_qic_m a " & _
                                                   "left join PROD.dbo.PROD_qic_d b " & _
                                                   "on a.no_rph=b.no_rph and a.no_hsl_prod =b.no_hsl_prod and a.kd_kegiatan = b.kd_kegiatan " & _
                                                   "left join (Select Id_Data,Desc_Data FROM SIF.dbo.SIF_Gen_Reff_D where Ref_Role='PROD' and Id_Ref_Data='KGTSPK') s " & _
                                                   "on s.Id_data = a.kd_kegiatan " & _
                                                   "where a.kd_departemen='" & kddep & "' and a.rec_stat='R' ", sqlconn)) '<- query buat ditampilkan di LOV
        daedit.Fill(dsedit, "Look")
        frmCari.set_dso(dsedit.Tables("Look"))
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then

            kode1 = frmCari.row("NO RPH").ToString
            kode2 = frmCari.row("No Realisasi Produksi").ToString
            kode3 = frmCari.row("Kode Kegiatan")
            lkrph.EditValue = kode1
            lkkegiatan.EditValue = kode3
            txt_no_hsl.Text = kode2
            'kode3 = frmCari.row("KODE SPK").ToString


            da1 = New SqlDataAdapter(New SqlCommand("select  * from  PROD.dbo.PROD_rcn_prod_m u,PROD.dbo.PROD_rcn_prod_d b, SALES.dbo.SALES_SO_D c,SIF.dbo.SIF_barang d,SIF.dbo.SIF_Jenis_Barang h where  b.no_sp=c.no_sp and b.no_sp_dtl=c.no_seq and c.kd_stok=d.kode_barang and u.no_rph= '" & kode1 & "' and u.no_rph=b.no_rph and  h.Kd_Departemen= '" & kddep & "' and d.kd_jns_persd=h.kd_jns_persd and d.kd_jenis=h.Kd_Jns_brg", sqlconn)) '<- query buat ditampilkan di LOV
            da1.Fill(ds5, "QICdm")

            da2 = New SqlDataAdapter(New SqlCommand("Select d.*,'' Nama_Barang,'' kd_tipe,'' Nama_Tipe,'' kd_kain,'' Merk_Kain,'' kd_ukuran, " & _
                                                   "'' Nama_Ukuran,'' Desc_Data,0.00 jml_qic_real, " & _
                                                   "0.00 jml_prod_sisa from PROD.dbo.PROD_qic_d d where 1=0", sqlconn))
            da2.Fill(ds5, "QICd")

            dr = New SqlClient.SqlCommand("Select d.*,b.Nama_Barang,b.kd_tipe,t.Nama_Tipe,b.kd_kain,k.Merk_Kain,b.kd_ukuran, " & _
                                                    "u.Nama_Ukuran,s.Desc_Data,ISNULL(j.jumlah_qic,0)as jml_qic_real, " & _
                                                    "(d.jml_prod-ISNULL(j.jumlah_qic,0)) as jml_prod_sisa from PROD.dbo.PROD_qic_d d " & _
                                                    "left join (Select sum(jml_qic)as jumlah_qic,no_rph,kd_kegiatan,kd_barang " & _
                                                    "From PROD.dbo.PROD_qic_d where no_hsl_prod <> '" & kode2 & "' " & _
                                                    "Group by no_rph,kd_kegiatan,kd_barang ) j " & _
                                                    "on j.no_rph = d.no_rph and j.kd_kegiatan=d.kd_kegiatan and j.kd_barang=d.kd_barang " & _
                                                    "left join  SIF.dbo.SIF_barang b " & _
                                                    "on b.Kode_Barang = d.kd_barang " & _
                                                    "left join SIF.dbo.SIF_Tipe t " & _
                                                    "on t.Kode_Tipe = b.kd_tipe " & _
                                                    "left join SIF.dbo.SIF_Kain k " & _
                                                    "on k.Kode_Kain = b.kd_kain " & _
                                                    "left join SIF.dbo.SIF_Ukuran u " & _
                                                    "on u.Kode_Ukuran= b.kd_ukuran " & _
                                                    "left join (Select Id_Data,Desc_Data FROM SIF.dbo.SIF_Gen_Reff_D where Ref_Role='PROD' and Id_Ref_Data='KGTSPK') s " & _
                                                    "on s.Id_data = d.kd_kegiatan " & _
                                                    "WHERE no_hsl_prod = '" & kode2 & "' and  d.no_rph ='" & kode1 & "' " & _
                                                    "and d.kd_kegiatan='" & kode3 & "' and (d.jml_prod-ISNULL(j.jumlah_qic,0))<> 0", sqlconn).ExecuteReader
            While dr.Read
                Dim rwm1 As DataRow = ds5.Tables("QICd").NewRow
                rwm1("kd_barang") = dr.Item("kd_barang")
                rwm1("Nama_Barang") = dr.Item("Nama_Barang")
                rwm1("Nama_Tipe") = dr.Item("Nama_Tipe")
                rwm1("Merk_Kain") = dr.Item("Merk_Kain")
                rwm1("Nama_Ukuran") = dr.Item("Nama_Ukuran")
                rwm1("jml_prod") = dr.Item("jml_prod")
                rwm1("jml_prod_sisa") = dr.Item("jml_prod_sisa")
                rwm1("jml_qic") = dr.Item("jml_qic")
                ds5.Tables("QICd").Rows.Add(rwm1)
            End While
            dr.Close()

            loadlookup()
            GridControl1.DataSource = ds5.Tables("QICd")
            GridView2.BestFitColumns()


            If Not ds4.Tables("QICMD") Is Nothing Then ds4.Tables("QICMD").Clear()
            da5 = New SqlDataAdapter(New SqlCommand("select* from PROD.dbo.PROD_qic_d WHERE no_hsl_prod = '" & kode2 & "' and  no_rph ='" & kode1 & "' " & _
                                                    "and kd_kegiatan='" & kode3 & "' ", sqlconn))
            da5.Fill(ds4, "QICMD")



            btnSave = True
            btnCancel = True
            btnAdd = False
            btnEdit = False
            btnDelete = True
            setStatus()


        Else
            cancel_click()
            State = ""
        End If

    End Sub
    Sub matilookup()
        lkrph.Enabled = False
        lkkegiatan.Enabled = False
    End Sub
    Sub nyalalookup()
        lkrph.Enabled = True
        lkkegiatan.Enabled = True

    End Sub
    Sub bersih()


        nyalalookup()
        GridControl1.DataSource = vbNull
        ds2.Clear()
        ds2.Relations.Clear()
        ds5.Clear()
        ds5.Relations.Clear()
        If Not ds5.Tables("QICdm") Is Nothing Then ds5.Tables("QICdm").Clear()
        If Not dsedit.Tables("Look") Is Nothing Then dsedit.Tables("Look").Clear()
        If Not ds5.Tables("QICd") Is Nothing Then ds5.Tables("QICd").Clear()
        If Not ds2.Tables("QIC") Is Nothing Then ds2.Tables("QIC").Clear()
        If Not ds2.Tables("QICD") Is Nothing Then ds2.Tables("QICD").Clear()
        If Not ds4.Tables("QICMD") Is Nothing Then ds4.Tables("QICMD").Clear()
        If Not ds4.Tables("QICD") Is Nothing Then ds4.Tables("QICD").Clear()

        txttanggal.Text = Now.Date
        txt_no_hsl.Text = vbNullString
        txtjdwl.Text = vbNullString
        lkrph.EditValue = vbNullString
        lkkegiatan.EditValue = Nothing

    End Sub
    Public Sub cancel_click()
        bersih()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        cancel_click()
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data QIC ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            State = "DELETE"
            da1 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_qic_m a where  a.kd_departemen='" & kddep & "' and a.no_rph='" & lkrph.EditValue & "' ", sqlconn)) '<- query buat ditampilkan di LOV
            da1.Fill(ds3, "deleteq")
            da2 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_qic_d a where  a.kd_departemen='" & kddep & "' and a.no_rph='" & lkrph.EditValue & "' ", sqlconn)) '<- query buat ditampilkan di LOV
            da2.Fill(ds3, "deleteq1")

            If Not ds3.Tables("deleteq") Is Nothing Then
                For Each rw As DataRow In ds3.Tables("deleteq").Rows
                    rw.Delete()
                Next
            End If
            If Not ds3.Tables("deleteq1") Is Nothing Then
                For Each rw As DataRow In ds3.Tables("deleteq1").Rows
                    rw.Delete()
                Next
            End If
            Try


                mb = New SqlClient.SqlCommandBuilder(da1)
                da1.UpdateCommand = mb.GetUpdateCommand()
                da1.InsertCommand = mb.GetInsertCommand()
                da1.DeleteCommand = mb.GetDeleteCommand()

                mb1 = New SqlClient.SqlCommandBuilder(da2)
                da2.UpdateCommand = mb1.GetUpdateCommand()
                da2.InsertCommand = mb1.GetInsertCommand()
                da2.DeleteCommand = mb1.GetDeleteCommand()



                da1.Update(ds3.Tables("deleteq"))
                da2.Update(ds3.Tables("deleteq1"))

                ds3.Tables("deleteq").AcceptChanges()
                ds3.Tables("deleteq1").AcceptChanges()
                showMessages("hapus SUCCES..")


                bersih()
                btnSave = False
                btnCancel = False
                btnDelete = False
                btnEdit = True
                btnAdd = True
                setStatus()

                'da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rls_spk_d a where  a.kd_departemen='" & kddep & "' and a.no_spk_rls='" & txtjumlah.Text & "'", sqlconn)) '<- query buat ditampilkan di LOV
                'da4.Fill(ds4, "loadq")
                'If Not ds4.Tables("loadq") Is Nothing Then ds4.Tables("loadq").Clear()
                'da4.Fill(ds4, "loadq")
                'da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rls_spk_d a where  a.kd_departemen='" & kddep & "' and a.no_spk_rls='" & txtjumlah.Text & "'", sqlconn)) '<- query buat ditampilkan di LOV
                'GridControl1.DataSource = ds4.Tables("loadq")
            Catch e As Exception

                ds3.Tables("deleteq").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                ds3.Tables("deleteq1").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical)

            End Try
            State = ""
        End If
    End Sub
    Public Sub cetak_click()
        
        callReport(App_Path() & "\report\ReportQic.rpt", "", "&norph=" & lkrph.EditValue & "&nohslprod=" & txt_no_hsl.Text & "&kdkegiatan=" & lkkegiatan.EditValue & "", False)
        
    End Sub

    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        delete_click()
    End Sub


    Private Sub lkkegiatan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkkegiatan.EditValueChanged
        If State = "ADD" Then
            loadData()
            loadlookup()
        End If
    End Sub

    Private Sub GridView2_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView2.CellValueChanged

        If e.Column.ToString = "Jumlah QIC" Then
            If GridView2.GetRow(e.RowHandle).Item("jml_qic") > GridView2.GetRow(e.RowHandle).Item("jml_prod_sisa") Then
                GridView2.SetColumnError(stok_min, "Jumlah Realisasi Produksi Terlalu Banyak", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                MessageBox.Show("Jumlah Realisasi Produksi Terlalu Banyak")
                GridView2.GetRow(e.RowHandle).Item("jml_qic") = GridView2.GetRow(e.RowHandle).Item("jml_prod_sisa")
            Else

            End If
        End If

    End Sub
End Class