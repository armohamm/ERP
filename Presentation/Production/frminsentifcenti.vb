Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frminsentifcenti
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
    Dim lgng As Long
    Dim TEMPLATE As String
    Public Sub cancel_click()
        If Not ds2.Tables("insd") Is Nothing Then ds2.Tables("insd").Clear()
        If Not ds2.Tables("inspeg") Is Nothing Then ds2.Tables("inspeg").Clear()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = False
        btnadd = True
        setStatus()
        Me.Enabled = False
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
    Private Sub frminsentifcenti_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
    End Sub
    Sub reload()
        If Not ds1.Tables("kegiatanspk") Is Nothing Then ds1.Tables("kegiatanspk").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select distinct id_data as kd_kegiatan,Desc_Data from SIF.dbo.SIF_Gen_Reff_D  where  ref_role='PROD' and id_Ref_File='SPK'  ", sqlconn))
        da1.Fill(ds1, "kegiatanspk")
        txtKegiatan.Properties.DataSource = ds1.Tables("kegiatanspk")
        txtKegiatan.Properties.ValueMember = "kd_kegiatan"
        txtKegiatan.Properties.DisplayMember = "Desc_Data"

        If Not ds1.Tables("pegawai") Is Nothing Then ds1.Tables("pegawai").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select Kode_Pegawai,Nama_Pegawai from SIF.dbo.SIF_Pegawai ", sqlconn))
        da1.Fill(ds1, "pegawai")
        lkpegawai.DataSource = ds1.Tables("pegawai")
        lkpegawai.ValueMember = "Kode_Pegawai"
        lkpegawai.DisplayMember = "Nama_Pegawai"

        If Not ds1.Tables("jamkerja") Is Nothing Then ds1.Tables("jamkerja").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select  Id_Data,Desc_Data from SIF.dbo.SIF_Gen_Reff_D where ref_role='PROD' and id_ref_file='JAMPROD'", sqlconn))
        da1.Fill(ds1, "jamkerja")
        txtJam.Properties.DataSource = ds1.Tables("jamkerja")
        txtJam.Properties.ValueMember = "Id_Data"
        txtJam.Properties.DisplayMember = "Desc_Data"
      
    End Sub
    Public Sub add_click()
        State = "ADD"
        reload()
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        setStatus()
    End Sub

 
    'Public Sub cetak_click()

    '    callReport(App_Path() & "\report\insentifrpt.rpt", "", "GROUP=" & txtJam.EditValue & " &TGLAWAL=" & Format(txtTgl_Awal.DateTime, "yyyy/MM/dd") & " &TGLAKHIR=" & Format(txtTgl_Akhir.DateTime, "yyyy/MM/dd") & " &vnama_report=" & TEMPLATE, False)

    'End Sub


   

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader
        Try
            sqlCmd.Connection = sqlconn
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.CommandText = "PROD.dbo.prodp_load_insentif_spon"
            sqlCmd.Parameters.Add("@vdate", SqlDbType.Char).Value = Format(txtTgl_Awal.DateTime, "yyyy/MM/dd")
            sqlCmd.Parameters.Add("@vkd_kegiatan ", SqlDbType.Char).Value = txtKegiatan.EditValue
            sqlCmd.Parameters.Add("@vkd_jam", SqlDbType.Char).Value = txtJam.EditValue
            sqlCmd.Parameters.Add("@vgroup_kerja", SqlDbType.Char).Value = "1"
            dr = sqlCmd.ExecuteReader
            MessageBox.Show("data berhasil disimpan")
            dr.Close()
        Catch
            MessageBox.Show("data gagal disimpan")
        End Try

        ds2.Relations.Clear()
        If Not ds2.Tables("insentifcenti") Is Nothing Then ds2.Tables("insentifcenti").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_insentif_centi_d where  REPLACE(CONVERT(varchar(7),tanggal,111),'/','') = '" & Format(txtTgl_Awal.DateTime, "yyyyMM") & "' and kd_kegiatan='" & txtKegiatan.EditValue & "' ", sqlconn))
        da2.Fill(ds2, "insentifcenti")

        If Not ds2.Tables("insentifcenti1") Is Nothing Then ds2.Tables("insentifcenti1").Clear()
        da3 = New SqlDataAdapter(New SqlCommand("select *,0 hasilproduksi,0 parameter,0 total from PROD.dbo.PROD_insentif_centi_krg where 1=0 ", sqlconn))
        da3.Fill(ds2, "insentifcenti1")

        gc.DataSource = ds2.Tables("insentifcenti")

        Dim colD1(2) As DataColumn
        Dim colD2(2) As DataColumn
        Dim rel1 As DataRelation

        colD1(0) = ds2.Tables("insentifcenti").Columns("tanggal")
        colD1(1) = ds2.Tables("insentifcenti").Columns("kd_kegiatan")
        colD1(2) = ds2.Tables("insentifcenti").Columns("kd_pegawai")

        colD2(0) = ds2.Tables("insentifcenti1").Columns("tanggal")
        colD2(1) = ds2.Tables("insentifcenti1").Columns("kd_kegiatan")
        colD2(2) = ds2.Tables("insentifcenti1").Columns("kd_pegawai")

        rel1 = ds2.Relations.Add("detil", colD1, colD2, False)
        gc.LevelTree.Nodes.Add("detil", GridView2)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
      

        If Not ds2.Tables("hasilproduksi") Is Nothing Then ds2.Tables("hasilproduksi").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PRODV_HARIAN_PRODUKSI" & _
                                               " where  REPLACE(CONVERT(varchar(7),tanggal,111),'/','') = '" & Format(txtTgl_Awal.DateTime, "yyyyMM") & "'", sqlconn))
        da2.Fill(ds2, "hasilproduksi")

        If Not ds2.Tables("kgtnspk") Is Nothing Then ds2.Tables("kgtnspk").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select distinct id_data as kd_kegiatan_spk,Desc_Data from SIF.dbo.SIF_Gen_Reff_D  where  ref_role='PROD' and id_Ref_File='SPK'  ", sqlconn))
        da1.Fill(ds2, "kgtnspk")
        frmDtlSO1.lkkegiatan.DataSource = ds2.Tables("kgtnspk")
        frmDtlSO1.lkkegiatan.ValueMember = "kd_kegiatan_spk"
        frmDtlSO1.lkkegiatan.DisplayMember = "Desc_Data"


        If Not ds2.Tables("barang") Is Nothing Then ds2.Tables("barang").Clear()
        da2 = New SqlDataAdapter(New SqlCommand("select distinct Kode_Barang as kd_barang,Nama_Barang from SIF.dbo.SIF_Barang  ", sqlconn))
        da2.Fill(ds2, "barang")
        frmDtlSO1.lkbarang.DataSource = ds2.Tables("barang")
        frmDtlSO1.lkbarang.ValueMember = "kd_barang"
        frmDtlSO1.lkbarang.DisplayMember = "Nama_Barang"

        frmDtlSO1.ShowDialog()
        frmDtlSO1.GridControl1.DataSource = ds2.Tables("hasilproduksi")



    End Sub

End Class