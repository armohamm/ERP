Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frminsentif
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

        If Not ds1.Tables("pegawai") Is Nothing Then ds1.Tables("pegawai").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select Kode_Pegawai,Nama_Pegawai from SIF.dbo.SIF_Pegawai ", sqlconn))
        da1.Fill(ds1, "pegawai")
        txtPegawai.Properties.DataSource = ds1.Tables("pegawai")
        txtPegawai.Properties.ValueMember = "Kode_Pegawai"
        txtPegawai.Properties.DisplayMember = "Nama_Pegawai"


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
            sqlCmd.CommandText = "PROD.dbo.prodp_hit_insentif_harian"
            sqlCmd.Parameters.Add("@vdate_start", SqlDbType.Char).Value = Format(txtTgl_Awal.DateTime, "yyyy/MM/dd")
            sqlCmd.Parameters.Add("@vdate_end", SqlDbType.Char).Value = Format(txtTgl_Akhir.DateTime, "yyyy/MM/dd")
            sqlCmd.Parameters.Add("@vkd_pegawai", SqlDbType.Char).Value = txtPegawai.EditValue
            sqlCmd.Parameters.Add("@vkd_kegiatan ", SqlDbType.Char).Value = txtKegiatan.EditValue
            sqlCmd.Parameters.Add("@vkd_jam", SqlDbType.Char).Value = txtJam.EditValue
            dr = sqlCmd.ExecuteReader

            dr.Close()


            If Not ds2.Tables("insd") Is Nothing Then ds2.Tables("insd").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_insentif_d where tanggal between '" & Format(txtTgl_Awal.DateTime, "yyyy/MM/dd") & " 00:00' and '" & Format(txtTgl_Akhir.DateTime, "yyyy/MM/dd") & " 00:00' and kd_kegiatan= '" & txtKegiatan.EditValue & "' and kd_pegawai= '" & txtPegawai.EditValue & "'", sqlconn))
            da1.Fill(ds2, "insd")
            gc.DataSource = ds2.Tables("insd")

            If Not ds2.Tables("inspeg") Is Nothing Then ds2.Tables("inspeg").Clear()
            da1 = New SqlDataAdapter(New SqlCommand("select * from PROD.dbo.PROD_insentif_peg where tanggal between '" & Format(txtTgl_Awal.DateTime, "yyyy/MM/dd") & " 00:00' and '" & Format(txtTgl_Akhir.DateTime, "yyyy/MM/dd") & " 00:00' and kd_kegiatan= '" & txtKegiatan.EditValue & "' and kd_pegawai= '" & txtPegawai.EditValue & "'", sqlconn))
            da1.Fill(ds2, "inspeg")
            GridControl1.DataSource = ds2.Tables("inspeg")
        Catch u As Exception
            MessageBox.Show(u.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
        End Try


    End Sub
    Public Sub cetak_click()

        callReport(App_Path() & "\report\insentifrpt.rpt", "", "&KDPEG=" & txtPegawai.EditValue & " &KDKEG=" & txtKegiatan.EditValue & " &GROUP=" & txtJam.EditValue & " &TGLAWAL=" & Format(txtTgl_Awal.DateTime, "yyyy/MM/dd") & " &TGLAKHIR=" & Format(txtTgl_Akhir.DateTime, "yyyy/MM/dd") & " &vnama_report=" & TEMPLATE, False)

    End Sub

    
End Class