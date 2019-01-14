Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmProduktivitas
    Dim dsete, ds1, ds2, ds3 As New DataSet
    Dim dadbe, da1, da2 As SqlDataAdapter
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
    Dim TEMPLATE As String
    Public Sub save_click()
        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader
        Try
            sqlCmd.Connection = sqlconn
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.CommandText = "PROD.dbo.prodp_hit_produktivitas"
            sqlCmd.Parameters.Add("@vdate_start", SqlDbType.Char).Value = Format(txtTgl_Awal.DateTime, "yyyy/MM/dd")
            sqlCmd.Parameters.Add("@vdate_end", SqlDbType.Char).Value = Format(txtTgl_Akhir.DateTime, "yyyy/MM/dd")
            sqlCmd.Parameters.Add("@vkd_kegiatan ", SqlDbType.Char).Value = txtKegiatan.EditValue
            sqlCmd.Parameters.Add("@vkd_jam", SqlDbType.Char).Value = txtJam.EditValue
            dr = sqlCmd.ExecuteReader

            dr.Close()

            If Not ds2.Tables("inspeg") Is Nothing Then ds2.Tables("inspeg").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("select PROD_produktivitas_brg.tanggal, PROD_produktivitas_brg.kd_barang, " & _
                                                    "SIF_Barang.Nama_Barang, SIF_Satuan.Nama_Satuan, PROD_produktivitas_brg.jumlah_barang, " & _
                                                    "PROD_produktivitas_brg.jumlah_orang, PROD_produktivitas_brg.total " & _
                                                    "FROM (SIF.dbo.SIF_Barang SIF_Barang " & _
                                                    "INNER JOIN SIF.dbo.SIF_Satuan SIF_Satuan ON (SIF_Barang.Kd_Satuan = SIF_Satuan.Kode_Satuan)) " & _
                                                    "INNER JOIN PROD.dbo.PROD_produktivitas_brg PROD_produktivitas_brg ON (PROD_produktivitas_brg.kd_barang = SIF_Barang.Kode_Barang)", sqlconn))
            da1.Fill(ds2, "inspeg")
            GridControl1.DataSource = ds2.Tables("inspeg")
        Catch u As Exception
            MessageBox.Show(u.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try
    End Sub

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
    Private Sub frminsentif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader
        Try
            sqlCmd.Connection = sqlconn
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.CommandText = "PROD.dbo.prodp_hit_produktivitas"
            sqlCmd.Parameters.Add("@vdate_start", SqlDbType.Char).Value = Format(txtTgl_Awal.DateTime, "yyyy/MM/dd")
            sqlCmd.Parameters.Add("@vdate_end", SqlDbType.Char).Value = Format(txtTgl_Akhir.DateTime, "yyyyMMdd")
            sqlCmd.Parameters.Add("@vkd_kegiatan ", SqlDbType.Char).Value = txtKegiatan.EditValue
            sqlCmd.Parameters.Add("@vkd_jam", SqlDbType.Char).Value = txtJam.EditValue
            dr = sqlCmd.ExecuteReader

            dr.Close()

            If Not ds2.Tables("inspeg") Is Nothing Then ds2.Tables("inspeg").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("select PROD_produktivitas_brg.tanggal, PROD_produktivitas_brg.kd_barang, " & _
                                                    "SIF_Barang.Nama_Barang, SIF_Satuan.Nama_Satuan, PROD_produktivitas_brg.jumlah_barang, " & _
                                                    "PROD_produktivitas_brg.jumlah_orang, PROD_produktivitas_brg.total " & _
                                                    "FROM (SIF.dbo.SIF_Barang SIF_Barang " & _
                                                    "INNER JOIN SIF.dbo.SIF_Satuan SIF_Satuan ON (SIF_Barang.Kd_Satuan = SIF_Satuan.Kode_Satuan)) " & _
                                                    "INNER JOIN PROD.dbo.PROD_produktivitas_brg PROD_produktivitas_brg ON (PROD_produktivitas_brg.kd_barang = SIF_Barang.Kode_Barang)", sqlconn))
            da1.Fill(ds2, "inspeg")
            GridControl1.DataSource = ds2.Tables("inspeg")
        Catch u As Exception
            MessageBox.Show(u.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try

        Dim total_produktivitas, total_produktivitas_jam As Double
        Dim jam As Integer
        Dim dr1 As SqlDataReader = New SqlClient.SqlCommand(" select ROUND((ISNULL(SUM(PROD_produktivitas_brg.total),0) / ISNULL(sum(PROD_produktivitas_brg.jumlah_orang),0)/ " & _
                                                            "(SELECT  SIF_Gen_Reff_D.Val_kode1 " & _
                                                            "FROM SIF.dbo.SIF_Gen_Reff_D SIF_Gen_Reff_D " & _
                                                            "WHERE SIF_Gen_Reff_D.Ref_Role = 'PROD' " & _
                                                            "AND SIF_Gen_Reff_D.Id_Ref_Data = 'JAMPROD' " & _
                                                            "AND SIF_Gen_Reff_D.Id_Data = '" & txtJam.EditValue & "')),2) nilai_produktivitas " & _
                                                            "FROM (SIF.dbo.SIF_Barang SIF_Barang  " & _
                                                            "INNER JOIN SIF.dbo.SIF_Satuan SIF_Satuan  " & _
                                                            "ON (SIF_Barang.Kd_Satuan = SIF_Satuan.Kode_Satuan)) " & _
                                                            "INNER JOIN PROD.dbo.PROD_produktivitas_brg PROD_produktivitas_brg " & _
                                                            "ON (PROD_produktivitas_brg.kd_barang = SIF_Barang.Kode_Barang) ", sqlconn).ExecuteReader
        dr1.Read()
        If dr1.HasRows Then
            total_produktivitas = dr1.Item("nilai_produktivitas")
        End If
        dr1.Close()

        'Dim dr2 As SqlDataReader = New SqlClient.SqlCommand(" SELECT SIF_Gen_Reff_D.Val_kode1 " & _
        '                                                    "FROM SIF.dbo.SIF_Gen_Reff_D SIF_Gen_Reff_D " & _
        '                                                    "WHERE SIF_Gen_Reff_D.Ref_Role = 'PROD' " & _
        '                                                    "AND SIF_Gen_Reff_D.Id_Ref_Data = 'JAMPROD' " & _
        '                                                    "AND SIF_Gen_Reff_D.Id_Data = '" & txtJam.EditValue & "' ", sqlconn).ExecuteReader
        'dr2.Read()
        'If dr2.HasRows Then
        '    jam = dr2.Item("Val_kode1")
        'End If
        'dr2.Close()

        total_produktivitas_jam = total_produktivitas
        lbl_produktivitas.Text = total_produktivitas_jam




    End Sub
    Public Sub cetak_click()

        callReport(App_Path() & "\report\insentifrpt.rpt", "", " &KDKEG=" & txtKegiatan.EditValue & " &GROUP=" & txtJam.EditValue & " &TGLAWAL=" & Format(txtTgl_Awal.DateTime, "yyyy/MM/dd") & " &TGLAKHIR=" & Format(txtTgl_Akhir.DateTime, "yyyy/MM/dd") & " &vnama_report=" & TEMPLATE, False)

    End Sub


End Class