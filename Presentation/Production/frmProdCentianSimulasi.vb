Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Public Class frmProdCentianSimulasi
    Dim ds1, ds2, ds3, ds4 As New DataSet
    Dim da1, da2, da3, da4, da5, da6 As New SqlDataAdapter
    Dim row, rows, rows1 As DataRow
    Dim mb, mb1, mb2, mb3 As New SqlCommandBuilder
    Dim BTRANS As SqlTransaction
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA As SqlDataAdapter
    Dim DAD As SqlDataAdapter
    Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode
    Dim obj As Object
    Dim prn As frmMain
    Dim jumlah As Integer
    Dim rl, rl1 As DataRelation
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String
    Dim B, C, D, A As Integer
    Dim x1, x2, x3, x4, i, x5 As Double
    Dim myBuilder As New SqlCommandBuilder
    Dim itung As Integer = 0
    Dim tot, view1 As Double
    Dim dr As SqlDataReader

    Dim ada, notrans As String
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
      
    End Sub

    Private Sub frmProdCentianSimulasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        A = 100
        If Not ds1.Tables("JDWKRJ") Is Nothing Then ds1.Tables("JDWKRJ").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Gen_Reff_D where Id_Ref_Data='JDWKRJ'", sqlconn))
        da1.Fill(ds1, "JDWKRJ")
        txtJadwal.Properties.DataSource = ds1.Tables("JDWKRJ")

        'btnEdit = False
        'btnDelete = False
        setStatus()
        State = "ADD"
        reload()
        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_rcn_prod_m  ", sqlconn))
        da1.Fill(ds3, "master")
        da6 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_rcn_prod_d  ", sqlconn))
        da6.Fill(ds3, "masterd")
        da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_rcn_prod_b  ", sqlconn))
        da2.Fill(ds3, "masterb")
        'da5 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_rcn_prod_box  ", sqlconn))
        'da5.Fill(ds3, "masterbox")
        

    End Sub

    Private Sub reload()
        If Not ds2.Tables("jenis") Is Nothing Then ds2.Tables("jenis").Clear()
        If Not ds2.Tables("SoD") Is Nothing Then ds2.Tables("SoD").Clear()
        If Not ds2.Tables("SoBox") Is Nothing Then ds2.Tables("SoBox").Clear()

        'da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_spk_d where no_spk='" & lkspk.EditValue & "' and kd_kegiatan ='" & lkkegiatan.EditValue & "'and kd_kegiatan_spk= '" & lkkegtn.EditValue & "'", sqlconn))
        da2 = New SqlDataAdapter(New SqlCommand("select Kd_Jns_Brg, Nama_Jenis from SIF.dbo.SIF_JENIS_BARANG ", sqlconn))
        da2.Fill(ds2, "jenis")
        GC.DataSource = ds2.Tables("jenis")
        

        da3 = New SqlDataAdapter(New SqlCommand("SELECT kd_jenis, no_sp,nama_barang,Kode_Barang from SALES.dbo.SALES_SO_D a,SIF.dbo.SIF_BARANG b where a.Kd_Stok=b.Kode_Barang  ", sqlconn))
        da3.Fill(ds2, "SoD")

        da3 = New SqlDataAdapter(New SqlCommand("SELECT jb.Nama_Jenis,b.kd_jenis, sb.No_sp,sb.no_seq_d,a.no_seq,b.nama_barang,b.Kode_Barang,  sb.panjang,0.00 as jml_blok, sb.lebar, sb.tebal, sb.Qty from SALES.dbo.SALES_SO_D a INNER JOIN SIF.dbo.SIF_BARANG b on a.Kd_Stok=b.Kode_Barang INNER JOIN SIF.dbo.SIF_Jenis_Barang jb on b.kd_jenis =jb.Kd_Jns_Brg INNER JOIN SALES.dbo.SALES_SOBOX_D sb on a.No_sp = sb.No_sp ", sqlconn))
        da3.Fill(ds2, "detil")

        da3 = New SqlDataAdapter(New SqlCommand("SELECT jb.Nama_Jenis,b.kd_jenis, sb.No_sp,a.No_seq as no_sp_detil, sb.No_seq,b.nama_barang, b.Kode_Barang,a.tipe_trans," & _
                                                "sb.panjang,0.00 as jml_blok, sb.lebar, sb.tebal, sb.Qty ,isnull(k.jumlah_kapasitas,0) jml_kapasitas " & _
                                                "from SALES.dbo.SALES_SO_D a " & _
                                                "INNER JOIN SIF.dbo.SIF_BARANG b on a.Kd_Stok=b.Kode_Barang " & _
                                                "INNER JOIN SIF.dbo.SIF_Jenis_Barang jb on b.kd_jenis =jb.Kd_Jns_Brg " & _
                                                "INNER JOIN SALES.dbo.SALES_SOBOX_D sb on a.No_sp = sb.No_sp " & _
                                                "LEFT JOIN SIF.dbo.SIF_kapasitas k on k.kd_jenis = b.kd_jenis", sqlconn))
        da3.Fill(ds2, "detil1")

        da3 = New SqlDataAdapter(New SqlCommand("SELECT c.no_sp,panjang,0.00 as jml_blok,0.00 as jumlah, lebar, tebal, Qty from SALES.dbo.SALES_SOBOX_D a,  SALES.dbo.SALES_SO c where  c.No_sp=a.No_sp ", sqlconn))
        da3.Fill(ds2, "SoBox")
        For Me.B = 0 To ds2.Tables("SoBox").Rows.Count - 1
            ds2.Tables("SoBox").Rows(B).Item("Qty") = 0
        Next

        rl = ds2.Relations.Add("Detail", ds2.Tables("jenis").Columns("Kd_Jns_Brg"), ds2.Tables("SoD").Columns("kd_jenis"), False)
        rl1 = ds2.Relations.Add("Detail1", ds2.Tables("SoD").Columns("no_sp"), ds2.Tables("SoBox").Columns("no_sp"), False)
        gc.DataSource = ds2.Tables("jenis")
        GC.LevelTree.Nodes.Add("Detail", GV2).Nodes.Add("Detail1", GV3)

        da3 = New SqlDataAdapter(New SqlCommand("select distinct kd_Jenis, d.Qty from SIF.dbo.SIF_JENIS_BARANG a,SALES.dbo.SALES_SO_D b,SIF.dbo.SIF_BARANG c,SALES.dbo.SALES_SOBOX_D d,  SALES.dbo.SALES_SO e where b.Kd_Stok=c.Kode_Barang AND e.No_sp=d.No_sp AND a.Kd_Jns_Brg=c.kd_jenis and e.No_sp = B.No_sp", sqlconn))

        da3.Fill(ds2, "simpan")
      
        dr = New SqlClient.SqlCommand("select v.*, isnull(k.jumlah_kapasitas,0) jml_kapasitas from " & _
                                      "(select distinct(kd_jenis), nama_jenis, tipe_trans from PROD.dbo.PRODV_MON_SO where Len(no_sp) > 10 And qty_sisa_prod > 0" & _
                                      " and departement='" & kddep & "' and tipe_trans <> 'JPJ-KPT-06' " & _
                                      ") v " & _
                                      "left join " & _
                                      "(select * from SIF.dbo.SIF_kapasitas where kegiatan_ppic='03') k " & _
                                      "on v.kd_jenis=k.kd_jenis", sqlconn).ExecuteReader
    End Sub

    Public Sub add_click()
        State = "ADD"


        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False

        setStatus()
        itung = 0
        x3 = 0
    End Sub

    Private Sub GV3_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV3.CellValueChanged
        Dim view As ColumnView = sender
        If x3 = 0 Then
            If e.Column.Name = "Qty" Then
                Dim x As Object
                Dim qty, tebal, jml_blok, lebar As Double
                x = CType(GC.FocusedView, DevExpress.XtraGrid.Views.Base.BaseView)
                qty = x.GetRowCellValue(e.RowHandle, "Qty")
                tebal = x.GetRowCellValue(e.RowHandle, "tebal")
                lebar = x.GetRowCellValue(e.RowHandle, "lebar")
                jml_blok = (qty * tebal) / A
                'x1 += jml_blok
                x.SetRowCellValue(e.RowHandle, "jml_blok", jml_blok)
                For j As Integer = 0 To GV3.RowCount - 1
                    tot += GV3.GetRowCellValue(j, jml_blok)
                Next

                If Not ds4.Tables("detil1") Is Nothing Then ds4.Tables("detil1").Clear()
                da3 = New SqlDataAdapter(New SqlCommand("SELECT SIF_Barang.Kode_Barang,SIF_Barang.Kd_Satuan,SIF_Barang.Nama_Barang, 0.00 as jml_sisa,0.00 as jml_prod,SIF_Ukuran.Tinggi,SIF_Ukuran.Lebar,SIF_Ukuran.Panjang FROM SIF.dbo.SIF_Barang SIF_Barang, SIF.dbo.SIF_Ukuran SIF_Ukuran WHERE(SIF_Barang.kd_ukuran = SIF_Ukuran.Kode_Ukuran)AND (SIF_Barang.kd_jenis = '007' AND SIF_Barang.kd_jns_persd = '1') AND SIF_Ukuran.Lebar='" & lebar & "'", sqlconn))
                da3.Fill(ds4, "detil1")



                If ds4.Tables("detil1").Rows.Count > 0 Then
                    ds4.Tables("detil1").Rows(0).Item("jml_sisa") = jml_blok + x1
                    x2 = ds4.Tables("detil1").Rows(0).Item("jml_sisa")
                    x1 = jml_blok
                    'ds4.Tables("detil1").Rows(0).Item("jml_prod") = ds4.Tables("detil1").Rows(0).Item("jml_sisa")

                    If itung = 0 Then
                        If Not ds4.Tables("detil") Is Nothing Then ds4.Tables("detil").Clear()
                        da4 = New SqlDataAdapter(New SqlCommand("SELECT SIF_Barang.Kode_Barang,SIF_Barang.Kd_Satuan,SIF_Barang.Nama_Barang, 0.00 as jml_sisa,0.00 as jml_prod,SIF_Ukuran.Tinggi,SIF_Ukuran.Lebar,SIF_Ukuran.Panjang FROM SIF.dbo.SIF_Barang SIF_Barang, SIF.dbo.SIF_Ukuran SIF_Ukuran WHERE(SIF_Barang.kd_ukuran = SIF_Ukuran.Kode_Ukuran)AND (SIF_Barang.kd_jenis = '007' AND SIF_Barang.kd_jns_persd = '1') ", sqlconn))
                        da4.Fill(ds4, "detil")
                        GridControl1.DataSource = ds4.Tables("detil")
                        itung = 1
                    End If



                End If
                For i As Integer = 0 To Gv1.RowCount - 1

                    If x5 = lebar Then

                        If Gv1.GetRowCellValue(i, "Lebar") = lebar Then

                            Gv1.SetRowCellValue(i, "jml_sisa", x2)

                            x5 = lebar

                        End If
                    Else
                        x1 = 0
                        If Not ds4.Tables("detil1") Is Nothing Then ds4.Tables("detil1").Clear()
                        da3 = New SqlDataAdapter(New SqlCommand("SELECT SIF_Barang.Kode_Barang,SIF_Barang.Kd_Satuan,SIF_Barang.Nama_Barang, 0.00 as jml_sisa,0.00 as jml_prod,SIF_Ukuran.Tinggi,SIF_Ukuran.Lebar,SIF_Ukuran.Panjang FROM SIF.dbo.SIF_Barang SIF_Barang, SIF.dbo.SIF_Ukuran SIF_Ukuran WHERE(SIF_Barang.kd_ukuran = SIF_Ukuran.Kode_Ukuran)AND (SIF_Barang.kd_jenis = '007' AND SIF_Barang.kd_jns_persd = '1') AND SIF_Ukuran.Lebar='" & lebar & "'", sqlconn))
                        da3.Fill(ds4, "detil1")
                        ds4.Tables("detil1").Rows(0).Item("jml_sisa") = jml_blok + x1
                        x2 = ds4.Tables("detil1").Rows(0).Item("jml_sisa")
                        x1 = jml_blok
                        If Gv1.GetRowCellValue(i, "Lebar") = lebar Then

                            Gv1.SetRowCellValue(i, "jml_sisa", x2)
                            x5 = lebar



                        End If
                    End If



                Next
            End If

        End If
        'view1 = view.Columns("jml_blok").SummaryText
        'MsgBox(view.Columns("jml_blok").SummaryText)
    End Sub

    Private Sub GV3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV3.LostFocus
       
        'MsgBox(view.Columns("jml_blok").SummaryText)

    End Sub

    Private Sub GV3_RowUpdated(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles GV3.RowUpdated
        Dim view As ColumnView = sender
        view1 = ds2.Tables("SoBox").Compute("sum(jml_blok)", "").ToString()
        'view1 = view.Columns("jml_blok").SummaryText
    End Sub

    
   
    Private Sub GV3_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles GV3.ValidateRow
        'Dim qty, tebal, jml_blok As Double

        'qty = e.Row("Qty").ToString
        'tebal = e.Row("tebal").ToString

        'jml_blok = (qty * tebal) / 100
        'e.Row("jml_blok") = jml_blok
        'MessageBox.Show(jml_blok)



    End Sub

    Private Sub GV_Main_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GV_Main.CellValueChanged
        If e.Column.Name = "Nama_Jenis" Then
            itung = 0
        End If
    End Sub

    Private Sub GV2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV2.Click
        'x1 = 0
    End Sub
    Public Sub save_click()

        If State = "ADD" Then
            Dim row As DataRow = ds3.Tables("master").Rows(0)
            notrans = getNoTrans("PRODRPH", txtTgl_Rph.DateTime)
            txtDPB.Text = notrans
            row = ds3.Tables("master").NewRow
            row.Item("no_rph") = txtDPB.Text
            row.Item("tanggal") = txtTgl_Rph.EditValue
            row.Item("kd_jadwal") = txtJadwal.EditValue
            row.Item("kd_jenis") = ds2.Tables("detil1").Rows(0).Item("kd_jenis")
            row.Item("tipe_trans") = ds2.Tables("detil1").Rows(0).Item("tipe_trans")
            row.Item("jml_kapasitas") = ds2.Tables("detil1").Rows(0).Item("jml_kapasitas")
            row.Item("kd_departemen") = kddep
            row.Item("kd_cabang") = getKodeCabang()
            row.Item("Last_Create_Date") = Now
            row.Item("Last_Created_By") = umum.username
            row.Item("Last_update_Date") = Now
            row.Item("Last_updated_By") = umum.username
            row.Item("Program_Name") = Me.Name
            ds3.Tables("master").Rows.Add(row)


            'prod_m
            For z = ds2.Tables("SoBox").Rows.Count - 1 To 0 Step -1


                Dim rows As DataRow = ds2.Tables("SoBox").Rows(z)
                Dim rows1 As DataRow = ds2.Tables("SoBox").Rows(z)

                If Not TypeOf rows("Qty") Is DBNull Then
                    If rows("Qty") > 0 Then


                        rows = ds3.Tables("masterd").NewRow
                        rows.Item("no_rph") = txtDPB.Text
                        rows.Item("tanggal") = txtTgl_Rph.EditValue
                        rows.Item("no_sp") = ds2.Tables("detil1").Rows(z).Item("No_sp")
                        rows.Item("no_sp_dtl") = ds2.Tables("detil1").Rows(z).Item("no_sp_detil")
                        rows.Item("kd_jenis") = ds2.Tables("detil1").Rows(z).Item("kd_jenis")
                        rows.Item("no_seq") = ds2.Tables("detil1").Rows(z).Item("no_seq")
                        rows.Item("panjang") = ds2.Tables("detil1").Rows(z).Item("panjang")
                        rows.Item("lebar") = ds2.Tables("detil1").Rows(z).Item("lebar")
                        rows.Item("tinggi") = ds2.Tables("detil1").Rows(z).Item("tebal")
                        rows.Item("jumlah") = IIf(view1 = 0.0, "0", view1)
                        rows.Item("kd_barang") = ds2.Tables("detil1").Rows(z).Item("Kode_Barang")
                        rows.Item("kd_departemen") = kddep
                        rows.Item("kd_cabang") = getKodeCabang()
                        rows.Item("Last_Create_Date") = Now
                        rows.Item("Last_Created_By") = umum.username
                        rows.Item("Last_update_Date") = Now
                        rows.Item("Last_updated_By") = umum.username
                        rows.Item("Program_Name") = Me.Name
                        ds3.Tables("masterd").Rows.Add(rows)

                        rows1 = ds3.Tables("masterb").NewRow
                        rows1.Item("no_rph") = txtDPB.Text
                        rows1.Item("kd_barang") = ds2.Tables("detil").Rows(z).Item("Kode_Barang")
                        rows1.Item("jumlah") = IIf(view1 = 0.0, "0", view1)
                        rows1.Item("kd_departemen") = kddep
                        rows1.Item("kd_cabang") = getKodeCabang()
                        rows1.Item("Last_Create_Date") = Now
                        rows1.Item("Last_Created_By") = umum.username
                        rows1.Item("Last_update_Date") = Now
                        rows1.Item("Last_updated_By") = umum.username
                        rows1.Item("Program_Name") = Me.Name
                        ds3.Tables("masterb").Rows.Add(rows1)


                        '    Else
                        '        ds2.Tables("simpan").Rows(z).Delete()
                    End If
                    'Else
                    '    ds2.Tables("simpan").Rows(z).Delete()
                End If


            Next


            'prod_d

            'For za = ds2.Tables("SoBOx").Rows.Count - 1 To 0 Step -1

            '    Dim rows As DataRow = ds2.Tables("SoBox").Rows(za)

            '    If Not TypeOf rows("Qty") Is DBNull Then
            '        notrans = getNoTrans("PRODRPH", txtTgl_Rph.DateTime)
            '        txtDPB.Text = notrans
            '        If rows("Qty") > 0 Then
            '            rows = ds3.Tables("masterd").NewRow
            '            rows.Item("no_rph") = txtDPB.Text
            '            rows.Item("tanggal") = txtTgl_Rph.EditValue
            '            rows.Item("no_sp") = ds2.Tables("detil1").Rows(za).Item("No_sp")
            '            rows.Item("no_sp_dtl") = ds2.Tables("detil1").Rows(za).Item("no_sp_detil")
            '            rows.Item("kd_jenis") = ds2.Tables("detil1").Rows(za).Item("kd_jenis")
            '            rows.Item("no_seq") = ds2.Tables("detil1").Rows(za).Item("no_seq")
            '            rows.Item("panjang") = ds2.Tables("detil1").Rows(za).Item("panjang")
            '            rows.Item("lebar") = ds2.Tables("detil1").Rows(za).Item("lebar")
            '            rows.Item("tinggi") = ds2.Tables("detil1").Rows(za).Item("tebal")
            '            rows.Item("jumlah") = IIf(view1 = 0.0, "0", view1)
            '            rows.Item("kd_barang") = ds2.Tables("detil1").Rows(za).Item("Kode_Barang")
            '            rows.Item("kd_departemen") = kddep
            '            rows.Item("kd_cabang") = getKodeCabang()
            '            rows.Item("Last_Create_Date") = Now
            '            rows.Item("Last_Created_By") = umum.username
            '            rows.Item("Last_update_Date") = Now
            '            rows.Item("Last_updated_By") = umum.username
            '            rows.Item("Program_Name") = Me.Name
            '            ds3.Tables("masterd").Rows.Add(rows)
            '            'Else
            '            '    ds2.Tables("detil").Rows(za).Delete()
            '        End If
            '        'Else
            '        '    ds2.Tables("detil").Rows(za).Delete()
            '    End If

            'Next

            'prod_b
            'For zb = ds2.Tables("SoBOx").Rows.Count - 1 To 0 Step -1

            '    Dim rows As DataRow = ds2.Tables("SoBox").Rows(zb)

            '    If Not TypeOf rows("Qty") Is DBNull Then
            '        notrans = getNoTrans("PRODRPH", txtTgl_Rph.DateTime)
            '        txtDPB.Text = notrans
            '        If rows("Qty") > 0 Then
            '            rows = ds3.Tables("masterb").NewRow
            '            rows.Item("no_rph") = txtDPB.Text
            '            rows.Item("kd_barang") = ds2.Tables("detil").Rows(zb).Item("Kode_Barang")
            '            rows.Item("jumlah") = IIf(view1 = 0.0, "0", view1)
            '            rows.Item("kd_departemen") = kddep
            '            rows.Item("kd_cabang") = getKodeCabang()
            '            rows.Item("Last_Create_Date") = Now
            '            rows.Item("Last_Created_By") = umum.username
            '            rows.Item("Last_update_Date") = Now
            '            rows.Item("Last_updated_By") = umum.username
            '            rows.Item("Program_Name") = Me.Name
            '            ds3.Tables("masterb").Rows.Add(rows)
            '            'Else
            '            '    ds2.Tables("detil").Rows(za).Delete()
            '        End If
            '        'Else
            '        '    ds2.Tables("detil").Rows(za).Delete()
            '    End If

            'Next


            ''prod_box
            'For zbox = ds2.Tables("SoBox").Rows.Count - 1 To 0 Step -1

            '    Dim rows As DataRow = ds2.Tables("SoBox").Rows(zbox)
            '    If Not TypeOf rows("Qty") Is DBNull Then
            '        If rows("Qty") > 0 Then
            '            rows = ds3.Tables("masterbox").NewRow
            '            rows.Item("no_rph") = txtDPB.Text
            '            rows.Item("no_sp") = ds2.Tables("detil1").Rows(zbox).Item("no_sp")
            '            rows.Item("no_sp_dtl") = ds2.Tables("detil1").Rows(zbox).Item("no_sp_detil")
            '            rows.Item("no_seq") = ds2.Tables("detil1").Rows(zbox).Item("no_seq")
            '            rows.Item("panjang") = ds2.Tables("detil1").Rows(zbox).Item("panjang")
            '            rows.Item("lebar") = ds2.Tables("detil1").Rows(zbox).Item("lebar")
            '            rows.Item("tebal") = ds2.Tables("detil1").Rows(zbox).Item("tebal")
            '            rows.Item("kd_departemen") = kddep
            '            rows.Item("kd_cabang") = getKodeCabang()
            '            rows.Item("Last_Create_Date") = Now
            '            rows.Item("Last_Created_By") = umum.username
            '            rows.Item("Last_update_Date") = Now
            '            rows.Item("Last_updated_By") = umum.username
            '            rows.Item("Program_Name") = Me.Name
            '            ds3.Tables("masterbox").Rows.Add(rows)
            '            'Else
            '            '    ds2.Tables("detil").Rows(za).Delete()
            '        End If
            '        'Else
            '        '    ds2.Tables("detil").Rows(za).Delete()
            '    End If

            'Next

        End If



        If State = "ADD" Then
            Try


                'mb = New SqlClient.SqlCommandBuilder(da5)
                'da5.UpdateCommand = mb.GetUpdateCommand()
                'da5.InsertCommand = mb.GetInsertCommand()
                'da5.DeleteCommand = mb.GetDeleteCommand()

                mb1 = New SqlClient.SqlCommandBuilder(da2)
                da2.UpdateCommand = mb1.GetUpdateCommand()
                da2.InsertCommand = mb1.GetInsertCommand()
                da2.DeleteCommand = mb1.GetDeleteCommand()

                mb2 = New SqlClient.SqlCommandBuilder(da6)
                da6.UpdateCommand = mb2.GetUpdateCommand()
                da6.InsertCommand = mb2.GetInsertCommand()
                da6.DeleteCommand = mb2.GetDeleteCommand()

                mb3 = New SqlClient.SqlCommandBuilder(da1)
                da1.UpdateCommand = mb3.GetUpdateCommand()
                da1.InsertCommand = mb3.GetInsertCommand()
                da1.DeleteCommand = mb3.GetDeleteCommand()


                da1.Update(ds3.Tables("master"))
                da6.Update(ds3.Tables("masterd"))
                da2.Update(ds3.Tables("masterb"))
                'da5.Update(ds3.Tables("masterbox"))


                'ds3.Tables("masterd").AcceptChanges()
                'ds3.Tables("masterb").AcceptChanges()

                showMessages("Saved..")

                txtDPB.Text = notrans



            Catch e As Exception

                ds3.Tables("master").RejectChanges()
                ds3.Tables("masterd").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                ds3.Tables("masterb").RejectChanges()
                'ds3.Tables("masterbox").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical)



            End Try




        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        save_click()
    End Sub
End Class
