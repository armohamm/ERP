Imports System.Data
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Columns

Public Class frmProdTranRlsSpkCenti

    Dim ds1, ds2, ds3, ds4, ds5, ds6, dsedit As New DataSet
    Dim da1, da2, da3, da4, da5, da6, daedit As New SqlDataAdapter
    Dim row, rows As DataRow
    Dim mb, mb1 As New SqlCommandBuilder
    Dim prn As frmMain
    Dim nilai As String
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Dim colD1(0) As DataColumn
    Dim colD2(0) As DataColumn
    Public State, kode, kode1, kode2, kode3, kode4, kode5, jumlah, TEMPLATE As String
    Dim rl As DataRelation
    Dim dread, dr As SqlDataReader
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
    Private Sub frmProdTranRlsSpkCenti_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        State = "ADD"
        prn = getParent(Me)


        da1 = New SqlDataAdapter(New SqlCommand("select distinct no_rph from PROD.dbo.PROD_spk_m where kd_departemen='" & kddep & "' and sts_centi='Y'", sqlconn))
        da1.Fill(ds1, "rph")
        lkrph.Properties.DataSource = ds1.Tables("rph")
        lkrph.Properties.ValueMember = "no_rph"
        lkrph.Properties.DisplayMember = "no_rph"

        da5 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_rls_spk_m  ", sqlconn))
        da5.Fill(ds5, "SPKM")
    End Sub

    Public Sub add_click()
        
        btnSave = True
        btnCancel = True
        btnDelete = True
        btnEdit = False
        btnAdd = False
        State = "ADD"
        setStatus()

        nyalalookup()
    End Sub

    Private Sub lkkegiatan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkkegiatan.EditValueChanged
        'If State = "ADD" Then
        If Not ds4.Tables("load") Is Nothing Then ds4.Tables("load").Clear()

        lkkegtn.EditValue = vbNullString

        If Not ds3.Tables("kegiatan") Is Nothing Then ds3.Tables("kegiatan").Clear()
        da3 = New SqlDataAdapter(New SqlCommand("select distinct kd_kegiatan_spk,desc_data from PROD.dbo.PROD_spk_m a,SIF.dbo.SIF_Gen_Reff_D b where no_spk='" & lkspk.EditValue & "' and a.kd_kegiatan='" & lkkegiatan.EditValue & "' and a.no_rph='" & lkrph.EditValue & "' and b.ref_role='PROD' and b.id_Ref_File='SPK'and a.kd_kegiatan_spk=b.id_data ", sqlconn))
        da3.Fill(ds3, "kegiatan")
        lkkegtn.Properties.DataSource = ds3.Tables("kegiatan")
        lkkegtn.Properties.ValueMember = "kd_kegiatan_spk"
        lkkegtn.Properties.DisplayMember = "desc_data"

        If Not ds3.Tables("jamkerja") Is Nothing Then ds3.Tables("jamkerja").Clear()
        da3 = New SqlDataAdapter(New SqlCommand("select  id_data,desc_data from SIF.dbo.SIF_Gen_Reff_D where ref_role='PROD' and id_ref_file='JAMPROD'", sqlconn))
        da3.Fill(ds3, "jamkerja")
        lkjamkerja.Properties.DataSource = ds3.Tables("jamkerja")
        lkjamkerja.Properties.ValueMember = "id_data"
        lkjamkerja.Properties.DisplayMember = "desc_data"
        'ElseIf State = "EDIT" Then
        '    If Not ds3.Tables("kegiatan") Is Nothing Then ds3.Tables("kegiatan").Clear()
        '    da3 = New SqlDataAdapter(New SqlCommand("select distinct kd_kegiatan_spk,desc_data from PROD.dbo.PROD_rls_spk_m a,SIF.dbo.SIF_Gen_Reff_D b where no_spk='" & lkspk.EditValue & "' and a.kd_kegiatan='" & lkkegiatan.EditValue & "' and a.no_rph='" & lkrph.EditValue & "' and b.ref_role='PROD' and b.id_Ref_File='SPK'and a.kd_kegiatan_spk=b.id_data and a.no_spk_rls='" & kode4 & "'", sqlconn))
        '    da3.Fill(ds3, "kegiatan")
        '    lkkegtn.Properties.DataSource = ds3.Tables("kegiatan")
        '    lkkegtn.Properties.ValueMember = "kd_kegiatan_spk"
        '    lkkegtn.Properties.DisplayMember = "desc_data"
        '    lkkegtn.EditValue = ds3.Tables("kegiatan").Rows(0)

        '    If Not ds3.Tables("jamkerja") Is Nothing Then ds3.Tables("jamkerja").Clear()
        '    da3 = New SqlDataAdapter(New SqlCommand("select  id_data,desc_data from SIF.dbo.SIF_Gen_Reff_D where ref_role='PROD' and id_ref_file='JAMPROD'", sqlconn))
        '    da3.Fill(ds3, "jamkerja")
        '    lkjamkerja.Properties.DataSource = ds3.Tables("jamkerja")
        '    lkjamkerja.Properties.ValueMember = "id_data"
        '    lkjamkerja.Properties.DisplayMember = "desc_data"


        '    If Not ds3.Tables("jamkerja1") Is Nothing Then ds3.Tables("jamkerja1").Clear()
        '    da3 = New SqlDataAdapter(New SqlCommand("select distinct a.kd_jam id_data,kd_kegiatan_spk,desc_data from PROD.dbo.PROD_rls_spk_m a,SIF.dbo.SIF_Gen_Reff_D b where no_spk='" & lkspk.EditValue & "' and a.kd_kegiatan='" & lkkegiatan.EditValue & "' and a.no_rph='" & lkrph.EditValue & "' and b.ref_role='PROD' and b.id_Ref_File='JAMPROD'and a.kd_jam=b.id_data and a.no_spk_rls='" & kode4 & "'", sqlconn))
        '    da3.Fill(ds3, "jamkerja1")


        '    lkjamkerja.EditValue = ds3.Tables("jamkerja1").Rows(0)

        'End If

    End Sub

    Private Sub loadGrid()
        

        If Not ds4.Tables("loada") Is Nothing Then ds4.Tables("loada").Clear()

        da4 = New SqlDataAdapter(New SqlCommand("select a.no_rph, a.no_spk, a.kd_kegiatan, a.kd_kegiatan_spk, sum(isnull (b.jumlah_rework, 0)) as jumlah_rework, 1 * (ISNULL(a.jumlah_produksi,0)) indeks, " & _
                                                        "a.kd_barang, sum(isnull (a.jumlah_produksi, 0) - isnull (b.jumlah_kerja, 0)) as jumlah_produksi, " & _
                                                        "sum(isnull (b.jumlah_kerja, 0)) as jumlah_kerja, sum(isnull (a.jumlah_produksi, 0) - isnull (b.jumlah_kerja, 0)) as jumlah_sisa " & _
                                                "from prod.dbo.prod_spk_d a " & _
                                                "left outer join prod.dbo.prod_rls_spk_d b on (a.no_rph = b.no_rph) " & _
                                                "and (a.no_spk = b.no_spk) " & _
                                                "and (a.kd_kegiatan = b.kd_kegiatan) " & _
                                                "and (a.kd_kegiatan_spk = b.kd_kegiatan_spk) " & _
                                                "and (a.kd_barang = b.kd_barang) " & _
                                                "where a.no_rph='" & lkrph.EditValue & "' " & _
                                                "and a.no_spk='" & lkspk.EditValue & "' " & _
                                                "and a.kd_kegiatan ='" & lkkegiatan.EditValue & "' " & _
                                                "and a.kd_kegiatan_spk= '" & lkkegtn.EditValue & "' " & _
                                                "group by a.no_rph, a.no_spk, a.kd_kegiatan, a.kd_kegiatan_spk, a.kd_barang,a.jumlah_produksi", sqlconn))
        da4.Fill(ds4, "loada")

        If Not ds6.Tables("SPKMDq") Is Nothing Then ds6.Tables("SPKMDq").Clear()
        da6 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_rls_spk_d where no_spk='" & lkspk.EditValue & "' and kd_kegiatan='" & lkkegiatan.EditValue & "' and kd_kegiatan_spk= '" & lkkegtn.EditValue & "' and no_spk_rls= '" & kode5 & "'  ", sqlconn))
        da6.Fill(ds6, "SPKMDq")

        If ds6.Tables("SPKMDq").Rows.Count = 0 Then
            If ds4.Tables("loada").Rows.Count = 0 Then
                ds4.Relations.Clear()
                If Not ds4.Tables("loadab") Is Nothing Then ds4.Tables("loadab").Clear()
                If Not ds4.Tables("loadd") Is Nothing Then ds4.Tables("loadd").Clear()
                If Not ds4.Tables("SoBox") Is Nothing Then ds4.Tables("SoBox").Clear()

                da4 = New SqlDataAdapter(New SqlCommand("select a.no_rph no_rph, a.no_spk, a.kd_kegiatan, a.kd_kegiatan_spk, " & _
                                    "a.kd_barang kd_barang, floor(a.jumlah_produksi)  as jumlah_produksi, " & _
                                    "floor(isnull(b.jumlah_kerja,0)) as jumlah_kerja,0 as jumlah_sisa , ISNULL(k.nilai_konv,1)*isnull(b.jumlah_kerja,1) as indeks " & _
                                    "from prod.dbo.prod_spk_d a " & _
                                    "left join(Select SUM(jumlah_kerja)as jumlah_kerja,no_rph,no_spk,kd_kegiatan, " & _
                                    "kd_kegiatan_spk,kd_barang from prod.dbo.prod_rls_spk_d " & _
                                    "Group by no_rph,no_spk,kd_kegiatan,kd_kegiatan_spk,kd_barang) b " & _
                                    "on (a.no_rph = b.no_rph) " & _
                                    "and (a.no_spk = b.no_spk) " & _
                                    "and (a.kd_kegiatan = b.kd_kegiatan) " & _
                                    "and (a.kd_kegiatan_spk = b.kd_kegiatan_spk) " & _
                                    "and (a.kd_barang = b.kd_barang) " & _
                                    "INNER JOIN SIF.dbo.SIF_Barang br " & _
                                    "on br.Kode_Barang = a.kd_barang " & _
                                    "left join SIF.dbo.SIF_konv_prod k " & _
                                    "on k.jns_kegiatan = a.kd_kegiatan and k.kd_kegiatan = a.kd_kegiatan_spk " & _
                                    "and k.kd_ukuran = br.kd_ukuran and k.kd_tipe = br.kd_tipe " & _
                                    "where a.no_rph='" & lkrph.EditValue & "'" & _
                                    "and a.no_spk='" & lkspk.EditValue & "'" & _
                                    "and a.kd_kegiatan =' " & lkkegiatan.EditValue & "'" & _
                                    "and a.kd_kegiatan_spk= '" & lkkegtn.EditValue & "'", sqlconn))

                da4.Fill(ds4, "loadd")

                gControl.DataSource = ds4.Tables("loadd")
                da6 = New SqlDataAdapter(New SqlCommand("SELECT * from PROD.dbo.PROD_rcn_prod_d ", sqlconn))
                da6.Fill(ds4, "SoBox")


                colD1(0) = ds4.Tables("loadd").Columns("no_rph")
                'colD1(1) = ds4.Tables("loadd").Columns("kd_barang")

                colD2(0) = ds4.Tables("SoBox").Columns("no_rph")
                'colD2(1) = ds4.Tables("SoBox").Columns("kd_barang")

                rl = ds4.Relations.Add("Detail", colD1, colD2, False)

                gControl.DataSource = ds4.Tables("loadd")
                gControl.LevelTree.Nodes.Add("Detail", GridView1)
                For B As Integer = 0 To ds4.Tables("loadd").Rows.Count - 1
                    ds4.Tables("loadd").Rows(B).Item("jumlah_kerja") = ds4.Tables("loadd").Rows(B).Item("jumlah_produksi")
                Next


            Else
                ds4.Relations.Clear()
                If Not ds4.Tables("loadd") Is Nothing Then ds4.Tables("loadd").Clear()
                If Not ds4.Tables("loadab") Is Nothing Then ds4.Tables("loadab").Clear()
                If Not ds4.Tables("SoBox") Is Nothing Then ds4.Tables("SoBox").Clear()

                da4 = New SqlDataAdapter(New SqlCommand("select a.no_rph no_rph, a.no_spk, a.kd_kegiatan, a.kd_kegiatan_spk, " & _
                                                  " a.kd_barang kd_barang, floor(a.jumlah_produksi)  as jumlah_produksi,floor(isnull(b.jumlah_rework,0))* isnull(b.jumlah_kerja,1) as jumlah_rework, " & _
                                                                 "  floor(isnull(b.jumlah_kerja,0)) as jumlah_kerja,0 as jumlah_sisa,ISNULL(k.nilai_konv,1) as indeks  " & _
                                                   "from prod.dbo.prod_spk_d a " & _
                                                   "left join(Select SUM(jumlah_kerja)as jumlah_kerja,no_rph,no_spk,kd_kegiatan,jumlah_rework, " & _
                                                   "kd_kegiatan_spk,kd_barang from prod.dbo.prod_rls_spk_d " & _
                                                   "Group by no_rph,no_spk,kd_kegiatan,kd_kegiatan_spk,kd_barang,jumlah_rework) b " & _
                                                   "on (a.no_rph = b.no_rph) " & _
                                                   "and (a.no_spk = b.no_spk) " & _
                                                   "and (a.kd_kegiatan = b.kd_kegiatan) " & _
                                                   "and (a.kd_kegiatan_spk = b.kd_kegiatan_spk) " & _
                                                   "and (a.kd_barang = b.kd_barang) " & _
                                                    "INNER JOIN SIF.dbo.SIF_Barang br " & _
                                                    "on br.Kode_Barang = a.kd_barang " & _
                                                    "left join SIF.dbo.SIF_konv_prod k " & _
                                                    "on k.jns_kegiatan = a.kd_kegiatan and k.kd_kegiatan = a.kd_kegiatan_spk " & _
                                                    "and k.kd_ukuran = br.kd_ukuran and k.kd_tipe = br.kd_tipe " & _
                                                   "where a.no_rph='" & lkrph.EditValue & "' " & _
                                                          "and a.no_spk='" & lkspk.EditValue & "' " & _
                                                          "and a.kd_kegiatan ='" & lkkegiatan.EditValue & "' " & _
                                                          "and a.kd_kegiatan_spk= '" & lkkegtn.EditValue & "' ", sqlconn))
                da4.Fill(ds4, "loadab")


                gControl.DataSource = ds4.Tables("loadab")
                da6 = New SqlDataAdapter(New SqlCommand("SELECT * from PROD.dbo.PROD_rcn_prod_d ", sqlconn))
                da6.Fill(ds4, "SoBox")


                colD1(0) = ds4.Tables("loadab").Columns("no_rph")
                'colD1(1) = ds4.Tables("loadab").Columns("kd_barang")

                colD2(0) = ds4.Tables("SoBox").Columns("no_rph")
                'colD2(1) = ds4.Tables("SoBox").Columns("kd_barang")

                rl = ds4.Relations.Add("Detail", colD1, colD2, False)

                gControl.DataSource = ds4.Tables("loadab")
                gControl.LevelTree.Nodes.Add("Detail", GridView1)

               

            End If
        Else

            If Not ds4.Tables("loadd") Is Nothing Then ds4.Tables("load").Clear()
            If Not ds4.Tables("loadab") Is Nothing Then ds4.Tables("loadab").Clear()
            If Not ds4.Tables("SoBox") Is Nothing Then ds4.Tables("SoBox").Clear()

            da4 = New SqlDataAdapter(New SqlCommand("select kd_barang,jumlah_sisa as jumlah_produksi,jumlah_produksi as jumlah_kerja,1*jumlah_produksi as indeks,jumlah_rework from PROD.dbo.PROD_rls_spk_d where no_spk='" & lkspk.EditValue & "' and kd_kegiatan='" & lkkegiatan.EditValue & "' and kd_kegiatan_spk= '" & lkkegtn.EditValue & "' and no_spk_rls= '" & kode5 & "' ", sqlconn))
            da4.Fill(ds4, "loadab")

            gControl.DataSource = ds4.Tables("loadab")
        End If
        If Not ds6.Tables("SPKMD") Is Nothing Then ds6.Tables("SPKMD").Clear()
        da6 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_rls_spk_d where no_spk='" & lkspk.EditValue & "' and kd_kegiatan='" & lkkegiatan.EditValue & "' and kd_kegiatan_spk= '" & lkkegtn.EditValue & "' and no_spk_rls= '" & txtjumlah.Text & "'  ", sqlconn))
        da6.Fill(ds6, "SPKMD")

    End Sub
    Private Sub loadlookup()
        If Not ds4.Tables("loadnama") Is Nothing Then ds4.Tables("loadnama").Clear()
        If Not ds4.Tables("loadtipe") Is Nothing Then ds4.Tables("loadtipe").Clear()
        If Not ds4.Tables("loadkain") Is Nothing Then ds4.Tables("loadkain").Clear()
        If Not ds4.Tables("loadukuran") Is Nothing Then ds4.Tables("loadukuran").Clear()

        da3 = New SqlDataAdapter(New SqlCommand("select Kode_Barang, Nama_Barang from SIF.dbo.SIF_Barang", sqlconn))
        da3.Fill(ds4, "loadnama")
        lkbarang.DataSource = ds4.Tables("loadnama")
        lkbarang.DisplayMember = "Nama_Barang"
        lkbarang.ValueMember = "Kode_Barang"
        da3 = New SqlDataAdapter(New SqlCommand("select a.Kode_Barang, b.Nama_Tipe from SIF.dbo.SIF_Barang a, SIF.dbo.SIF_Tipe b WHERE a.kd_tipe=b.Kode_Tipe", sqlconn))
        da3.Fill(ds4, "loadtipe")
        lktipe.DataSource = ds4.Tables("loadtipe")
        lktipe.DisplayMember = "Nama_Tipe"
        lktipe.ValueMember = "Kode_Barang"
        da3 = New SqlDataAdapter(New SqlCommand("select a.Kode_Barang, b.Merk_Kain from SIF.dbo.SIF_Barang a, SIF.dbo.SIF_Kain b WHERE a.kd_kain=b.Kode_Kain", sqlconn))
        da3.Fill(ds4, "loadkain")
        lkkain.DataSource = ds4.Tables("loadkain")
        lkkain.DisplayMember = "Merk_Kain"
        lkkain.ValueMember = "Kode_Barang"
        da3 = New SqlDataAdapter(New SqlCommand("select a.Kode_Barang, b.Nama_Ukuran from SIF.dbo.SIF_Barang a, SIF.dbo.SIF_Ukuran b where a.kd_ukuran=b.Kode_Ukuran", sqlconn))
        da3.Fill(ds4, "loadukuran")
        lkukuran.DataSource = ds4.Tables("loadukuran")
        lkukuran.DisplayMember = "Nama_Ukuran"
        lkukuran.ValueMember = "Kode_Barang"
    End Sub

    Public Sub save_click()
        If State = "ADD" Then
            If Not ds4.Tables("load123") Is Nothing Then ds4.Tables("load123").Clear()
            da4 = New SqlDataAdapter(New SqlCommand("select* from PROD.dbo.PROD_rls_spk_d a " & _
                                                "where a.no_rph='" & lkrph.EditValue & "' " & _
                                           "and a.no_spk='" & lkspk.EditValue & "' " & _
                                           "and a.kd_kegiatan ='" & lkkegiatan.EditValue & "' " & _
                                           "and a.kd_kegiatan_spk= '" & lkkegtn.EditValue & "' ", sqlconn))
            da4.Fill(ds4, "load123")
            Dim total As Integer
            total = gView.GetRowCellValue(0, "jumlah_kerja")

            If ds4.Tables("load123").Rows.Count > 0 Then


                If ds4.Tables("load123").Rows(0).Item("jumlah_kerja") < total Then


                    gView.SetColumnError(jumlah_kerja, "Jumlah Dikerjakan tidak boleh lebih besar dari Jumlah Produksi", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
                    showMessages("Data kelebihan:" & total - ds4.Tables("load123").Rows(0).Item("jumlah_produksi"))
                ElseIf ds4.Tables("load123").Rows(0).Item("jumlah_kerja") = total Then
                    Exit Sub
                    bersih()
                    btnSave = False
                    btnCancel = False
                    btnDelete = False
                    btnEdit = True
                    btnAdd = True
                    setStatus()
                    Me.Enabled = False


                Else

                    kode5 = getNoTrans("PRODSPKRLS", getTanggal)
                    row = ds5.Tables("SPKM").NewRow
                    row.Item("no_spk_rls") = kode5
                    row.Item("tanggal") = txttanggal.Text
                    row.Item("no_rph") = lkrph.EditValue
                    row.Item("no_spk") = lkspk.EditValue
                    row.Item("sts_centi") = "Y"
                    row.Item("kd_kegiatan_spk") = lkkegtn.EditValue
                    row.Item("kd_kegiatan") = lkkegiatan.EditValue
                    row.Item("kd_jam") = lkjamkerja.EditValue
                    row.Item("kd_departemen") = kddep
                    row.Item("kd_cabang") = getKodeCabang()
                    row.Item("Last_Create_Date") = Now
                    row.Item("Last_Created_By") = umum.username
                    row.Item("Last_update_Date") = Now
                    row.Item("Last_updated_By") = umum.username
                    row.Item("Program_Name") = Me.Name
                    ds5.Tables("SPKM").Rows.Add(row)
                End If
            Else
                kode5 = getNoTrans("PRODSPKRLS", getTanggal)
                row = ds5.Tables("SPKM").NewRow
                row.Item("no_spk_rls") = kode5
                row.Item("tanggal") = txttanggal.Text
                row.Item("no_rph") = lkrph.EditValue
                row.Item("sts_centi") = "Y"
                row.Item("no_spk") = lkspk.EditValue
                row.Item("kd_kegiatan_spk") = lkkegtn.EditValue
                row.Item("kd_kegiatan") = lkkegiatan.EditValue
                row.Item("kd_jam") = lkjamkerja.EditValue
                row.Item("kd_departemen") = kddep
                row.Item("kd_cabang") = getKodeCabang()
                row.Item("Last_Create_Date") = Now
                row.Item("Last_Created_By") = umum.username
                row.Item("Last_update_Date") = Now
                row.Item("Last_updated_By") = umum.username
                row.Item("Program_Name") = Me.Name
                ds5.Tables("SPKM").Rows.Add(row)



            End If

        ElseIf State = "EDIT" Then

            row = ds5.Tables("SPKMq").Rows(0)
            row.Item("tanggal") = txttanggal.Text
            row.Item("no_rph") = lkrph.EditValue
            row.Item("no_spk") = lkspk.EditValue
            row.Item("kd_kegiatan_spk") = lkkegtn.EditValue
            row.Item("kd_kegiatan") = lkkegiatan.EditValue
            row.Item("kd_jam") = lkjamkerja.EditValue
            row.Item("kd_departemen") = kddep
            row.Item("kd_cabang") = getKodeCabang()
            row.Item("Last_update_Date") = Now
            row.Item("sts_centi") = "Y"
            row.Item("Last_updated_By") = umum.username
            row.Item("Program_Name") = Me.Name


        End If

        If State = "ADD" Then
            For l As Integer = 0 To gView.RowCount - 1

                rows = ds6.Tables("SPKMD").NewRow
                rows.Item("no_spk_rls") = kode5
                rows.Item("no_rph") = lkrph.EditValue
                rows.Item("no_spk") = lkspk.EditValue
                rows.Item("kd_kegiatan_spk") = lkkegtn.EditValue
                rows.Item("kd_kegiatan") = lkkegiatan.EditValue
                rows.Item("kd_departemen") = kddep
                rows.Item("kd_cabang") = getKodeCabang()
                rows.Item("Last_Create_Date") = Now
                rows.Item("Last_Created_By") = umum.username
                rows.Item("Program_Name") = Me.Name
                rows.Item("kd_barang") = gView.GetRowCellValue(l, "kd_barang")
                rows.Item("jumlah_kerja") = gView.GetRowCellValue(l, "jumlah_kerja")
                rows.Item("jumlah_produksi") = gView.GetRowCellValue(l, "jumlah_produksi")
                rows.Item("jumlah_sisa") = gView.GetRowCellValue(l, "jumlah_sisa")


                ds6.Tables("SPKMD").Rows.Add(rows)
            Next



        ElseIf State = "EDIT" Then


            For l As Integer = 0 To gView.RowCount - 1


                rows = ds4.Tables("loadq").Rows(0)
                rows.Item("no_rph") = lkrph.EditValue
                rows.Item("no_spk") = lkspk.EditValue
                rows.Item("kd_kegiatan_spk") = lkkegtn.EditValue
                rows.Item("kd_kegiatan") = lkkegiatan.EditValue
                rows.Item("kd_departemen") = kddep
                rows.Item("kd_cabang") = getKodeCabang()
                rows.Item("Last_update_Date") = Now
                rows.Item("Last_updated_By") = umum.username
                rows.Item("Program_Name") = Me.Name
                rows.Item("kd_barang") = gView.GetRowCellValue(l, "kd_barang")
                rows.Item("jumlah_kerja") = gView.GetRowCellValue(l, "jumlah_kerja")
                rows.Item("jumlah_produksi") = gView.GetRowCellValue(l, "jumlah_produksi")
                rows.Item("jumlah_sisa") = gView.GetRowCellValue(l, "jumlah_sisa")

            Next

        End If


        If State = "ADD" Then
            Try


                mb = New SqlClient.SqlCommandBuilder(da5)
                da5.UpdateCommand = mb.GetUpdateCommand()
                da5.InsertCommand = mb.GetInsertCommand()
                da5.DeleteCommand = mb.GetDeleteCommand()

                mb1 = New SqlClient.SqlCommandBuilder(da6)
                da6.UpdateCommand = mb1.GetUpdateCommand()
                da6.InsertCommand = mb1.GetInsertCommand()
                da6.DeleteCommand = mb1.GetDeleteCommand()



                da5.Update(ds5.Tables("SPKM"))
                da6.Update(ds6.Tables("SPKMD"))

                ds5.Tables("SPKM").AcceptChanges()
                ds6.Tables("SPKMD").AcceptChanges()
                showMessages("Saved..")

                txtjumlah.Text = kode5
          

            Catch e As Exception

                ds5.Tables("SPKM").RejectChanges()
                ds6.Tables("SPKMD").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical)



            End Try
        ElseIf State = "EDIT" Then

            Try


                mb = New SqlClient.SqlCommandBuilder(da5)
                da5.UpdateCommand = mb.GetUpdateCommand()
                da5.InsertCommand = mb.GetInsertCommand()
                da5.DeleteCommand = mb.GetDeleteCommand()

                mb1 = New SqlClient.SqlCommandBuilder(da4)
                da4.UpdateCommand = mb1.GetUpdateCommand()
                da4.InsertCommand = mb1.GetInsertCommand()
                da4.DeleteCommand = mb1.GetDeleteCommand()

                da4.Update(ds4.Tables("loadq"))
                da5.Update(ds5.Tables("SPKMq"))

                ds5.Tables("SPKMq").AcceptChanges()
                showMessages("EDIT SUCCES..")

                txtjumlah.Text = rows.Item("no_spk_rls").ToString
                
            Catch e As Exception

                ds4.Tables("loadq").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                ds5.Tables("SPKMq").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical)

            End Try

        End If

    End Sub
    Sub matilookup()
        lkrph.Enabled = False
        lkspk.Enabled = False
        lkkegtn.Enabled = False
        lkkegiatan.Enabled = False


    End Sub
    Sub nyalalookup()
        lkrph.Enabled = True
        lkspk.Enabled = True
        lkkegtn.Enabled = True
        lkkegiatan.Enabled = True

    End Sub

    Public Sub edit_click()

        State = "EDIT"

        dsedit = New DataSet
        daedit = New SqlDataAdapter(New SqlCommand("select a.no_rph as [NO RPH],a.no_spk as [No Spk] ,a.kd_kegiatan_spk as [KODE SPK],b.desc_data as [NAMA KEGIATAN],a.no_spk_rls as [NoSpkRealisasi],a.kd_kegiatan as [kdkegiatan]  from PROD.dbo.PROD_rls_spk_m a,SIF.dbo.SIF_Gen_Reff_D b where b.ref_role='PROD' and b.id_Ref_File='SPK'and a.kd_kegiatan_spk=b.id_data and a.kd_departemen='" & kddep & "' and (a.sts_centi='Y')", sqlconn)) '<- query buat ditampilkan di LOV
        daedit.Fill(dsedit, "LookSPK")
        frmCari.set_dso(dsedit.Tables("LookSPK"))
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then

            kode4 = frmCari.row("NoSpkRealisasi").ToString
            kode1 = frmCari.row("kdkegiatan").ToString
            kode3 = frmCari.row("KODE SPK").ToString

            'da1 = New SqlDataAdapter(New SqlCommand("select distinct no_rph from PROD.dbo.PROD_spk_m where kd_departemen='" & kddep & "'", sqlconn))
            'da1.Fill(ds1, "rph")
            'lkrph.Properties.DataSource = ds1.Tables("rph")
            'lkrph.Properties.ValueMember = "no_rph"
            'lkrph.Properties.DisplayMember = "no_rph"

            'dread = New SqlClient.SqlCommand("select * from PROD.dbo.PROD_rls_spk_m  where  kd_departemen='" & kddep & "' and no_spk_rls='" & kode4 & "' and kd_kegiatan_spk='" & kode3 & "'  and kd_kegiatan='" & kode1 & "' ", sqlconn).ExecuteReader
            'dread.Read()
            'txttanggal.Text = dread.Item("tanggal")
            'lkrph.EditValue = dread.Item("no_rph")
            'lkspk.EditValue = dread.Item("no_spk")
            'lkkegiatan.EditValue = dread.Item("kd_kegiatan")
            'lkkegtn.EditValue = dread.Item("kd_kegiatan_spk")
            'txtjumlah.Text = dread.Item("no_spk_rls")
            'lkjamkerja.EditValue = dread.Item("kd_jam")
            'txtjumlah.Text = dread.Item("no_spk_rls")
            'dread.Close()

            da5 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rls_spk_m  where  kd_departemen='" & kddep & "' and no_spk_rls='" & kode4 & "' and kd_kegiatan_spk='" & kode3 & "'  and kd_kegiatan='" & kode1 & "' ", sqlconn)) '<- query buat ditampilkan di LOV
            da5.Fill(ds5, "SPKMq")
            row = ds5.Tables("SPKMq").Rows(0)
           

            da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rls_spk_d a where  a.kd_departemen='" & kddep & "' and a.no_spk_rls='" & kode4 & "' and a.kd_kegiatan_spk='" & kode3 & "' ", sqlconn)) '<- query buat ditampilkan di LOV
            da4.Fill(ds4, "loadq")



            If Not ds4.Tables("loadq2") Is Nothing Then ds4.Tables("loadq2").Clear()
            da4 = New SqlDataAdapter(New SqlCommand("select *,1 * (ISNULL(a.jumlah_produksi,0)) indeks from PROD.dbo.PROD_rls_spk_d a " & _
                                                     "where  a.kd_departemen='" & kddep & "' and a.no_spk_rls='" & kode4 & "' and a.kd_kegiatan_spk='" & kode3 & "'  and a.kd_kegiatan='" & kode1 & "' ", sqlconn)) '<- query buat ditampilkan di LOV
            da4.Fill(ds4, "loadq2")


            If ds4.Tables("loadq2").Rows.Count = 0 Then
                If Not ds4.Tables("loadq2") Is Nothing Then ds4.Tables("loadq2").Clear()
                da4 = New SqlDataAdapter(New SqlCommand("select a.*,(ISNULL(c.nilai_konv,1)) * (ISNULL(a.jumlah_produksi,1)) indeks from PROD.dbo.PROD_rls_spk_d a INNER JOIN SIF.dbo.SIF_konv_prod c " & _
                                                    "ON a.kd_kegiatan = c.kd_kegiatan where  a.kd_departemen='" & kddep & "' and a.no_spk_rls='" & kode4 & "' and a.kd_kegiatan_spk='" & kode3 & "'  and a.kd_kegiatan='" & kode1 & "' ", sqlconn)) '<- query buat ditampilkan di LOV
                da4.Fill(ds4, "loadq2")
                gControl.DataSource = ds4.Tables("loadq2")
                da6 = New SqlDataAdapter(New SqlCommand("SELECT * from PROD.dbo.PROD_rcn_prod_d ", sqlconn))
                da6.Fill(ds4, "SoBox")

                colD1(0) = ds4.Tables("loadq2").Columns("no_rph")
                'colD1(1) = ds4.Tables("loadq2").Columns("kd_barang")

                colD2(0) = ds4.Tables("SoBox").Columns("no_rph")
                'colD2(1) = ds4.Tables("SoBox").Columns("kd_barang")

                rl = ds4.Relations.Add("Detail1", colD1, colD2, False)


                gControl.DataSource = ds4.Tables("loadq2")

                gControl.LevelTree.Nodes.Add("Detail1", GridView1)

            Else
                If Not ds4.Tables("loadq2") Is Nothing Then ds4.Tables("loadq2").Clear()
                da4 = New SqlDataAdapter(New SqlCommand("select *,1 * (ISNULL(a.jumlah_produksi,1)) indeks from PROD.dbo.PROD_rls_spk_d a " & _
                                                    "where  a.kd_departemen='" & kddep & "' and a.no_spk_rls='" & kode4 & "' and a.kd_kegiatan_spk='" & kode3 & "'  and a.kd_kegiatan='" & kode1 & "' ", sqlconn))
                da4.Fill(ds4, "loadq2")
                gControl.DataSource = ds4.Tables("loadq2")
                da6 = New SqlDataAdapter(New SqlCommand("SELECT * from PROD.dbo.PROD_rcn_prod_d ", sqlconn))
                da6.Fill(ds4, "SoBox")

                colD1(0) = ds4.Tables("loadq2").Columns("no_rph")
                'colD1(1) = ds4.Tables("loadq2").Columns("kd_barang")

                colD2(0) = ds4.Tables("SoBox").Columns("no_rph")
                'colD2(1) = ds4.Tables("SoBox").Columns("kd_barang")

                rl = ds4.Relations.Add("Detail1", colD1, colD2, False)

                gControl.DataSource = ds4.Tables("loadq2")
                gControl.LevelTree.Nodes.Add("Detail1", GridView1)


            End If



            txttanggal.Text = row.Item("tanggal")
            lkrph.EditValue = row.Item("no_rph")
            lkspk.EditValue = row.Item("no_spk")
            lkkegiatan.EditValue = row.Item("kd_kegiatan")
            lkkegtn.EditValue = row.Item("kd_kegiatan_spk")
            txtjumlah.Text = row.Item("no_spk_rls")
            lkjamkerja.EditValue = row.Item("kd_jam")
            txtjumlah.Text = row.Item("no_spk_rls")
         

            matilookup()
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
    Sub bersih()
        ds4.Relations.Clear()
        If Not ds4.Tables("loadd") Is Nothing Then ds4.Tables("loadd").Clear()
        If Not ds4.Tables("loadab") Is Nothing Then ds4.Tables("loadab").Clear()
        If Not ds5.Tables("SPKMq") Is Nothing Then ds5.Tables("SPKMq").Clear()
        If Not ds4.Tables("loadq") Is Nothing Then ds4.Tables("loadq").Clear()
        If Not ds6.Tables("load1") Is Nothing Then ds6.Tables("load1").Clear()
        If Not ds6.Tables("SPKMD") Is Nothing Then ds6.Tables("SPKMD").Clear()


        txttanggal.Text = Now.Date
        lkrph.EditValue = vbNullString
        txtjdwl.Text = vbNullString
        lkspk.EditValue = vbNullString
        lkkegiatan.EditValue = vbNullString
        txtjumlah.Text = ""
        lkkegtn.EditValue = vbNullString
        lkjamkerja.EditValue = vbNullString

        nyalalookup()
    End Sub

    Private Sub delete(ByVal rows As DataRowCollection)
        For Each rw As DataRow In rows
            rw.Delete()
        Next
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data Realisasi SPK ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then
            State = "DELETE"
            If Not ds5.Tables("SPKMq") Is Nothing Then
                For Each rw As DataRow In ds5.Tables("SPKMq").Rows
                    rw.Delete()
                Next
            End If
            If Not ds4.Tables("loadq") Is Nothing Then
                For Each rw As DataRow In ds4.Tables("loadq").Rows
                    rw.Delete()
                Next
            End If
            Try


                mb = New SqlClient.SqlCommandBuilder(da5)
                da5.UpdateCommand = mb.GetUpdateCommand()
                da5.InsertCommand = mb.GetInsertCommand()
                da5.DeleteCommand = mb.GetDeleteCommand()

                mb1 = New SqlClient.SqlCommandBuilder(da4)
                da4.UpdateCommand = mb1.GetUpdateCommand()
                da4.InsertCommand = mb1.GetInsertCommand()
                da4.DeleteCommand = mb1.GetDeleteCommand()



                da4.Update(ds4.Tables("loadq"))
                da5.Update(ds5.Tables("SPKMq"))

                ds4.Tables("loadq").AcceptChanges()
                ds5.Tables("SPKMq").AcceptChanges()
                showMessages("hapus SUCCES..")



                da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rls_spk_da where  a.kd_departemen='" & kddep & "' and a.no_spk_rls='" & txtjumlah.Text & "'", sqlconn)) '<- query buat ditampilkan di LOV
                da4.Fill(ds4, "loadq")
                If Not ds4.Tables("loadq") Is Nothing Then ds4.Tables("loadq").Clear()
                da4 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rls_spk_da where  a.kd_departemen='" & kddep & "' and a.no_spk_rls='" & txtjumlah.Text & "'", sqlconn)) '<- query buat ditampilkan di LOV
                da4.Fill(ds4, "loadq")
                gControl.DataSource = ds4.Tables("loadq")
            Catch e As Exception

                ds4.Tables("loadq").RejectChanges() ' untuk membatalkan row yg diupdate/insert
                ds5.Tables("SPKMq").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical)

            End Try
            State = ""
        End If
    End Sub

    Private Sub lkrph_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkrph.EditValueChanged
        If State = "ADD" Then
            If Not ds1.Tables("rph") Is Nothing Then ds1.Tables("rph").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("select distinct no_rph from PROD.dbo.PROD_spk_m where kd_departemen='" & kddep & "' ", sqlconn))
            da1.Fill(ds1, "rph")
            lkrph.Properties.DataSource = ds1.Tables("rph")
            lkrph.Properties.ValueMember = "no_rph"
            lkrph.Properties.DisplayMember = "no_rph"

            lkspk.EditValue = vbNullString
            lkkegiatan.EditValue = vbNullString
            lkkegtn.EditValue = vbNullString
            txtjdwl.Text = ""


            If Not ds1.Tables("nospk") Is Nothing Then ds1.Tables("nospk").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("select distinct no_spk from PROD.dbo.PROD_spk_m where kd_departemen='" & kddep & "' and no_rph= '" & lkrph.EditValue & "'", sqlconn))
            da1.Fill(ds1, "nospk")
            lkspk.Properties.DataSource = ds1.Tables("nospk")
            lkspk.Properties.ValueMember = "no_spk"
            lkspk.Properties.DisplayMember = "no_spk"
        ElseIf State = "EDIT" Then

            If Not ds1.Tables("rph") Is Nothing Then ds1.Tables("rph").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("select distinct b.no_rph from PROD.dbo.PROD_rls_spk_m b where b.kd_departemen='" & kddep & "'  and b.no_spk_rls='" & kode4 & "' ", sqlconn))
            da1.Fill(ds1, "rph")
            lkrph.Properties.DataSource = ds1.Tables("rph")
            lkrph.Properties.ValueMember = "no_rph"
            lkrph.Properties.DisplayMember = "no_rph"

            lkrph.EditValue = ds1.Tables("rph").Rows(0)


            If Not ds1.Tables("nospk") Is Nothing Then ds1.Tables("nospk").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("select distinct b.no_spk from PROD.dbo.PROD_rls_spk_m b where b.kd_departemen='" & kddep & "'  and b.no_spk_rls='" & kode4 & "' ", sqlconn))
            da1.Fill(ds1, "nospk")
            lkspk.Properties.DataSource = ds1.Tables("nospk")
            lkspk.Properties.ValueMember = "no_spk"
            lkspk.Properties.DisplayMember = "no_spk"
            lkspk.EditValue = ds1.Tables("nospk").Rows(0)
        End If
    End Sub
    Public Sub cetak_click()
       
        callReport(App_Path() & "\report\ProdRlsCentiSpk.rpt", "", "&norph=" & lkrph.EditValue & " &nospk=" & lkspk.EditValue & " &kdkegiatan=" & lkkegiatan.EditValue & " &kdkegiatanspk=" & lkkegtn.EditValue & " &nospkrls=" & txtjumlah.Text & " &vnama_report=" & TEMPLATE, False)

    End Sub
    Private Sub lkspk_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkspk.EditValueChanged
        'If State = "ADD" Then
        If Not ds4.Tables("load") Is Nothing Then ds4.Tables("load").Clear()

        txttanggal.Text = vbNullString
        lkkegiatan.EditValue = vbNullString
        lkkegtn.EditValue = vbNullString

        If Not ds1.Tables("isispk") Is Nothing Then ds1.Tables("isispk").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rcn_prod_m a,PROD.dbo.PROD_spk_m b,SIF.dbo.SIF_Gen_Reff_D c where b.no_spk='" & lkspk.EditValue & "' and a.no_rph=b.no_rph and a.kd_jadwal=c.id_data and c.ref_role='PROD' and c.id_Ref_File='JDWKRJ'", sqlconn))
        da1.Fill(ds1, "isispk")
        For i As Integer = 0 To ds1.Tables("isispk").Rows.Count - 1

            txtjdwl.Text = ds1.Tables("isispk").Rows(i).Item("desc_data").ToString
            txttanggal.Text = Now.Date
        Next

        If Not ds2.Tables("kegiatanspk") Is Nothing Then ds2.Tables("kegiatanspk").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select distinct kd_kegiatan,desc_data from PROD.dbo.PROD_spk_m a,SIF.dbo.SIF_Gen_Reff_D b where a.no_spk='" & lkspk.EditValue & "' and a.no_rph='" & lkrph.EditValue & "'and b.ref_role='PROD' and b.id_Ref_File='KGTSPK'and a.kd_kegiatan=b.id_data  ", sqlconn))
        da2.Fill(ds2, "kegiatanspk")
        lkkegiatan.Properties.DataSource = ds2.Tables("kegiatanspk")
        lkkegiatan.Properties.ValueMember = "kd_kegiatan"
        lkkegiatan.Properties.DisplayMember = "desc_data"
        'ElseIf State = "EDIT" Then
        'If Not ds1.Tables("isispk") Is Nothing Then ds1.Tables("isispk").Clear()
        'da1 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rcn_prod_m a,PROD.dbo.PROD_spk_m b,SIF.dbo.SIF_Gen_Reff_D c where b.no_spk='" & lkspk.EditValue & "' and a.no_rph=b.no_rph and a.kd_jadwal=c.id_data and c.ref_role='PROD' and c.id_Ref_File='JDWKRJ'", sqlconn))
        'da1.Fill(ds1, "isispk")
        'If ds1.Tables("isispk").Rows.Count = 0 Then
        'Else

        '    txtjdwl.Text = ds1.Tables("isispk").Rows(0).Item("desc_data").ToString
        '    txttanggal.Text = Now.Date

        'End If


        'If Not ds2.Tables("kegiatanspk") Is Nothing Then ds2.Tables("kegiatanspk").Clear()
        'da2 = New SqlDataAdapter(New SqlCommand("select distinct kd_kegiatan,desc_data from PROD.dbo.PROD_rls_spk_m a,SIF.dbo.SIF_Gen_Reff_D b where a.no_spk='" & lkspk.EditValue & "' and a.no_rph='" & lkrph.EditValue & "'and b.ref_role='PROD' and b.id_Ref_File='KGTSPK'and a.kd_kegiatan=b.id_data and a.no_spk_rls='" & kode4 & "' ", sqlconn))
        'da2.Fill(ds2, "kegiatanspk")
        'lkkegiatan.Properties.DataSource = ds2.Tables("kegiatanspk")
        'lkkegiatan.Properties.ValueMember = "kd_kegiatan"
        'lkkegiatan.Properties.DisplayMember = "desc_data"
        'lkkegiatan.EditValue = ds2.Tables("kegiatanspk").Rows(0)
        'End If

    End Sub

    Private Sub lkkegtn_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lkkegtn.EditValueChanged
        If State = "ADD" Then
            loadGrid()

            If Not ds4.Tables("load") Is Nothing Then ds4.Tables("load").Clear()
            If Not ds6.Tables("SPKMD") Is Nothing Then ds6.Tables("SPKMD").Clear()
            loadlookup()

            da4 = New SqlDataAdapter(New SqlCommand("select a.no_rph, a.no_spk, a.kd_kegiatan, a.kd_kegiatan_spk," & _
                                                            "a.kd_barang, sum(isnull (a.jumlah_produksi, 0) - isnull (b.jumlah_kerja, 0)) as jumlah_produksi, " & _
                                                            "sum(isnull (b.jumlah_kerja, 0)) as jumlah_kerja, sum(isnull (a.jumlah_produksi, 0) - isnull (b.jumlah_kerja, 0)) as jumlah_sisa " & _
                                                    "from prod.dbo.PROD_spk_d a " & _
                                                    "left outer join prod.dbo.PROD_rls_spk_d b on (a.no_rph = b.no_rph) " & _
                                                    "and (a.no_spk = b.no_spk) " & _
                                                    "and (a.kd_kegiatan = b.kd_kegiatan) " & _
                                                    "and (a.kd_kegiatan_spk = b.kd_kegiatan_spk) " & _
                                                    "and (a.kd_barang = b.kd_barang) " & _
                                                    "where a.no_rph='" & lkrph.EditValue & "' " & _
                                                    "and a.no_spk='" & lkspk.EditValue & "' " & _
                                                    "and a.kd_kegiatan ='" & lkkegiatan.EditValue & "' " & _
                                                    "and a.kd_kegiatan_spk= '" & lkkegtn.EditValue & "' " & _
                                                    "group by a.no_rph,  a.no_spk, a.kd_kegiatan, a.kd_kegiatan_spk, a.kd_barang", sqlconn))
            da4.Fill(ds4, "load")
        ElseIf State = "EDIT" Then
            loadlookup()

        End If

    End Sub

    Private Sub gView_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles gView.CellValueChanged
        Dim view As ColumnView = sender

        If State = "EDIT" Then

            If e.Column Is jumlah_kerja Then


                If Not ds4.Tables("cek1") Is Nothing Then ds4.Tables("cek1").Clear()
                da1 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_rls_spk_d where no_spk='" & lkspk.EditValue & "' and kd_kegiatan='" & lkkegiatan.EditValue & "' and kd_kegiatan_spk= '" & lkkegtn.EditValue & "' and no_spk_rls= '" & txtjumlah.Text & "'  ", sqlconn)) '<- query buat ditampilkan di LOV
                da1.Fill(ds4, "cek1")


                Dim int As Integer = view.GetRowCellValue(e.RowHandle, "jumlah_kerja")
                Dim s As Integer = ds4.Tables("cek1").Rows(0).Item("jumlah_kerja")


                If int < s Then

                    jumlah = int - s
                ElseIf int > s Then

                    jumlah = int - s
                End If
                view.SetRowCellValue(e.RowHandle, "jumlah_sisa", jumlah)


            End If

        ElseIf State = "ADD" Then
            If e.Column Is jumlah_kerja Then
                If Not ds4.Tables("cekadd") Is Nothing Then ds4.Tables("cekadd").Clear()

                da4 = New SqlDataAdapter(New SqlCommand("select a.no_rph no_rph, a.no_spk, a.kd_kegiatan, a.kd_kegiatan_spk, " & _
                                                  " a.kd_barang kd_barang, floor(a.jumlah_produksi)  as jumlah_produksi,floor(isnull(b.jumlah_rework,0)) as jumlah_rework, " & _
                                                                 "  floor(isnull(b.jumlah_kerja,0)) as jumlah_kerja,0 as jumlah_sisa,ISNULL(k.nilai_konv,1) as indeks  " & _
                                                   "from prod.dbo.prod_spk_d a " & _
                                                   "left join(Select SUM(jumlah_kerja)as jumlah_kerja,no_rph,no_spk,kd_kegiatan,jumlah_rework, " & _
                                                   "kd_kegiatan_spk,kd_barang from prod.dbo.prod_rls_spk_d " & _
                                                   "Group by no_rph,no_spk,kd_kegiatan,kd_kegiatan_spk,kd_barang,jumlah_rework) b " & _
                                                   "on (a.no_rph = b.no_rph) " & _
                                                   "and (a.no_spk = b.no_spk) " & _
                                                   "and (a.kd_kegiatan = b.kd_kegiatan) " & _
                                                   "and (a.kd_kegiatan_spk = b.kd_kegiatan_spk) " & _
                                                   "and (a.kd_barang = b.kd_barang) " & _
                                                    "INNER JOIN SIF.dbo.SIF_Barang br " & _
                                                    "on br.Kode_Barang = a.kd_barang " & _
                                                    "left join SIF.dbo.SIF_konv_prod k " & _
                                                    "on k.jns_kegiatan = a.kd_kegiatan and k.kd_kegiatan = a.kd_kegiatan_spk " & _
                                                    "and k.kd_ukuran = br.kd_ukuran and k.kd_tipe = br.kd_tipe " & _
                                                   "where a.no_rph='" & lkrph.EditValue & "' " & _
                                                          "and a.no_spk='" & lkspk.EditValue & "' " & _
                                                          "and a.kd_kegiatan ='" & lkkegiatan.EditValue & "' " & _
                                                          "and a.kd_kegiatan_spk= '" & lkkegtn.EditValue & "' ", sqlconn))
                da4.Fill(ds4, "cekadd")
                Dim int As Integer = view.GetRowCellValue(e.RowHandle, "jumlah_kerja")
                Dim s As Integer = ds4.Tables("cekadd").Rows(0).Item("jumlah_kerja")

                If int < s Then

                    jumlah = int
                ElseIf int > s Then

                    jumlah = int
                End If
                view.SetRowCellValue(e.RowHandle, "jumlah_sisa", jumlah)


            End If
            End If
    End Sub

    Private Sub gView_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gView.ValidateRow
    
        Dim isValid As Boolean = True
        If Not ds4.Tables("load123") Is Nothing Then ds4.Tables("load123").Clear()
        da4 = New SqlDataAdapter(New SqlCommand("select a.no_rph, a.no_spk, a.kd_kegiatan, a.kd_kegiatan_spk, " & _
                               " a.kd_barang, a.jumlah_produksi,a.jumlah_produksi - isnull (b.jumlah_kerja, 0) as jumlahq,floor(isnull (b.jumlah_kerja,0)) as jumlah_kerja, " & _
                                              " b.jumlah_kerja " & _
                                "from prod.dbo.prod_spk_d a " & _
                                "left join(Select SUM(jumlah_kerja)as jumlah_kerja,no_rph,no_spk,kd_kegiatan, " & _
                                "kd_kegiatan_spk,kd_barang from prod.dbo.prod_rls_spk_d " & _
                                "Group by no_rph,no_spk,kd_kegiatan,kd_kegiatan_spk,kd_barang) b " & _
                                "on (a.no_rph = b.no_rph) " & _
                                "and (a.no_spk = b.no_spk) " & _
                                "and (a.kd_kegiatan = b.kd_kegiatan) " & _
                                "and (a.kd_kegiatan_spk = b.kd_kegiatan_spk) " & _
                                "and (a.kd_barang = b.kd_barang) " & _
                                "where a.no_rph='" & lkrph.EditValue & "' " & _
                                       "and a.no_spk='" & lkspk.EditValue & "' " & _
                                       "and a.kd_kegiatan ='" & lkkegiatan.EditValue & "' " & _
                                       "and a.kd_kegiatan_spk= '" & lkkegtn.EditValue & "' ", sqlconn))
        da4.Fill(ds4, "load123")
        Dim total As Integer
        total = ds4.Tables("load123").Rows(0).Item("jumlah_kerja") + jumlah


        If ds4.Tables("load123").Rows(0).Item("jumlah_produksi") < total Then


            gView.SetColumnError(jumlah_kerja, "Jumlah Dikerjakan tidak boleh lebih besar dari Jumlah Produksi", DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical)
            showMessages("Data kelebihan:" & total - ds4.Tables("load123").Rows(0).Item("jumlah_produksi"))
            isValid = False

        End If
        e.Valid = isValid

    End Sub
End Class