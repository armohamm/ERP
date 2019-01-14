Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Data
Public Class frmGenDPB2
    Dim ds1, ds2, ds3 As New DataSet
    Dim da1, da2, da3 As New SqlDataAdapter
    Dim row As DataRow
    Dim mb As New SqlCommandBuilder
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public State As String

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub


    Private Sub frmGenDPB2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextEdit1.Visible = False
        connect()
        prn = getParent(Me)
        setStatus()

        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Sopir", sqlconn))
        da1.Fill(ds1, "Sopir")
        txtSopir.Properties.DataSource = ds1.Tables("Sopir")
        txtKernet.Properties.DataSource = ds1.Tables("Sopir")

        da1 = New SqlDataAdapter(New SqlCommand("select * from SIF.dbo.SIF_Kendaraan order by Nama_Kendaraan", sqlconn))
        da1.Fill(ds1, "Kendaraan")
        txtKendaraan.Properties.DataSource = ds1.Tables("Kendaraan")

        reload()


    End Sub

    Private Sub reload()
        If Not ds1.Tables("Barang") Is Nothing Then ds1.Tables("Barang").Clear()
        If Not ds1.Tables("noTrans") Is Nothing Then ds1.Tables("noTrans").Clear()
        If Not ds1.Tables("Kendaraan") Is Nothing Then ds1.Tables("Kendaraan").Clear()
        If Not ds1.Tables("Sopir") Is Nothing Then ds1.Tables("Sopir").Clear()
        da1 = New SqlDataAdapter(New SqlCommand("select  t.tanggal [Tanggal], t.no_trans [No Transaksi],t.no_dpb " & _
                                                "from ( " & _
                                                "select tanggal, no_trans, no_sp,no_dpb " & _
                                                "from PROD.dbo.PROD_rcn_krm_d " & _
                                                "group by no_trans, tanggal, no_sp,no_dpb ) t " & _
                                                "left join PROD.dbo.PROD_dpb_m d " & _
                                                "on t.no_trans=d.no_trans_krm and t.no_sp=d.no_sp " & _
                                                "WHERE t.no_dpb is null or t.no_dpb ='' group by t.no_trans, t.tanggal,t.no_dpb", sqlconn))
        'da1 = New SqlDataAdapter(New SqlCommand("select  t.tanggal [Tanggal], t.no_trans [No Transaksi] " & _
        '                                        "from ( " & _
        '                                        "select tanggal, no_trans, no_sp,no_dpb " & _
        '                                        "from PROD.dbo.PROD_rcn_krm_d " & _
        '                                        "group by no_trans, tanggal, no_sp,no_dpb ) t " & _
        '                                        "left join PROD.dbo.PROD_dpb_m d " & _
        '                                        "on t.no_trans=d.no_trans_krm and t.no_sp=d.no_sp and t.no_dpb=d.no_trans " & _
        '                                        "WHERE t.no_dpb is null " & _
        '                                        "group by t.no_trans, t.tanggal", sqlconn))
        da1.Fill(ds1, "noTrans")
        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Kendaraan, (Nama_Kendaraan + '-' + No_Polisi) as Nama_Kendaraan from sif.dbo.SIF_Kendaraan", sqlconn))
        da1.Fill(ds1, "Kendaraan")
        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.SIF_Sopir", sqlconn))
        da1.Fill(ds1, "Sopir")


        txtNoTrans.Properties.DisplayMember = "No Transaksi"
        txtNoTrans.Properties.ValueMember = "No Transaksi"
        txtNoTrans.Properties.DataSource = ds1.Tables("noTrans")

    End Sub

    Public Sub add_click()
        reload()
        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnAdd = False
        State = "ADD"
        setStatus()
    End Sub

    Public Sub edit_click()
        Dim qstr As String = "select distinct no_trans_krm ,tanggal Tanggal,no_pol from PROD.dbo.PROD_dpb_m "
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(qstr, sqlconn))
        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        da3.Fill(ds3, "lookup_so")
        frmCari.set_dso(ds3.Tables("lookup_so"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            reload()

            txtNoTrans.Properties.DataSource = ds1.Tables("noTrans")
            TextEdit1.Visible = True
            TextEdit1.Text = frmCari.row("no_trans_krm")
            txtNoTrans.EditValue = frmCari.row("no_trans_krm").ToString
            txtNoTrans.Visible = False
            Dim dr As SqlDataReader
            dr = New SqlClient.SqlCommand("select * from PROD.dbo.PROD_rcn_krm_m where no_trans='" & txtNoTrans.EditValue & "' ", sqlconn).ExecuteReader
            dr.Read()
            txtKendaraan.EditValue = dr.Item("kd_kendaraan")
            txtSopir.EditValue = dr.Item("kd_sopir")
            txtKernet.EditValue = dr.Item("kd_kenek")
            dr.Close()
            State = "EDIT"
            LoadDataBarang()
        End If


    End Sub

    Sub LoadDataBarang()
        If State = "ADD" Then
            If Not ds1.Relations("Detail Barang") Is Nothing Then ds1.Relations.Clear()
            If Not ds1.Tables("BarangDetil") Is Nothing Then ds1.Tables("BarangDetil").Clear()
            If Not ds1.Tables("Barang") Is Nothing Then ds1.Tables("Barang").Clear()
            'da2 = New SqlDataAdapter(New SqlCommand("select distinct t.no_sp, '' as no_dpb ,t.no_trans,v.Kd_Customer, v.Nama_Customer,v.Nama_Wilayah, v.Nama_Area " & _
            '                            "from PROD.dbo.PROD_rcn_krm_d t " & _
            '                            "left join PROD.dbo.PRODV_MON_SO v " & _
            '                            "on v.No_sp=t.no_sp and v.No_seq_d=t.no_sp_dtl " & _
            '                            "LEFT JOIN PROD.dbo.PROD_dpb_d d " & _
            '                            "on d.no_sp = t.no_sp and d.no_sp_dtl = t.no_sp_dtl " & _
            '                            "where t.no_trans='" & txtNoTrans.EditValue & "' and d.no_sp is NULL ", sqlconn))
            da2 = New SqlDataAdapter(New SqlCommand("select distinct t.no_sp, '' as no_dpb ,t.no_trans,v.Kd_Customer, " & _
                                                    "v.Nama_Customer, v.Nama_Wilayah, v.Nama_Area " & _
                                                    "from PROD.dbo.PROD_rcn_krm_d t " & _
                                                    "left join PROD.dbo.PRODV_MON_SO v " & _
                                                    "on v.No_sp=t.no_sp and v.No_seq_d=t.no_sp_dtl " & _
                                                    "LEFT JOIN PROD.dbo.PROD_dpb_m m " & _
                                                    "on m.no_trans_krm = t.no_trans and m.no_sp = t.no_sp " & _
                                                    "LEFT JOIN PROD.dbo.PROD_dpb_d d " & _
                                                    "on m.no_sp = d.no_sp and m.no_trans = d.no_trans " & _
                                                    "where t.no_trans='" & txtNoTrans.EditValue & "' and d.no_sp is NULL  ", sqlconn))
            da2.Fill(ds1, "Barang")
            da2 = New SqlDataAdapter(New SqlCommand("select distinct t.no_sp, t.no_trans, t.no_sp_dtl, t.jumlah, v.Kd_Customer, v.Nama_Customer, v.Kd_Stok, v.Nama_Barang, v.Kd_Satuan, v.Nama_Wilayah, v.Nama_Area " & _
                                        "from PROD.dbo.PROD_rcn_krm_d t " & _
                                        "left join PROD.dbo.PRODV_MON_SO v " & _
                                        "on v.No_sp=t.no_sp and v.No_seq_d=t.no_sp_dtl " & _
                                         "where t.no_trans='" & txtNoTrans.EditValue & "'", sqlconn))
            da2.Fill(ds1, "BarangDetil")
          

            Dim rl1 As DataRelation
            rl1 = ds1.Relations.Add("Detail Barang", ds1.Tables("Barang").Columns("no_sp"), ds1.Tables("BarangDetil").Columns("no_sp"), False)

            GC.DataSource = ds1.Tables("Barang")
            GC.LevelTree.Nodes.Add("Detail Barang", GV_Detail)
            GV.BestFitColumns()
        ElseIf State = "EDIT" Then
            If Not ds1.Relations("Detail Barang") Is Nothing Then ds1.Relations.Clear()
            If Not ds1.Tables("BarangDetil") Is Nothing Then ds1.Tables("BarangDetil").Clear()
            If Not ds1.Tables("Barang") Is Nothing Then ds1.Tables("Barang").Clear()
            da2 = New SqlDataAdapter(New SqlCommand("select distinct t.no_sp, t.no_trans as no_dpb ,t.no_trans_krm,v.Kd_Customer," & _
                                                    "v.Nama_Customer, v.Nama_Wilayah, v.Nama_Area " & _
                                                    "from PROD.dbo.PROD_dpb_m t " & _
                                                    "left join PROD.dbo.PRODV_MON_SO v " & _
                                                    "on v.No_sp=t.no_sp " & _
                                                    "where t.no_trans_krm='" & txtNoTrans.EditValue & "'", sqlconn))
            da2.Fill(ds1, "Barang")
            da2 = New SqlDataAdapter(New SqlCommand("select t.no_sp, t.no_trans, t.no_sp_dtl, t.jumlah," & _
                                                    "v.Kd_Customer, v.Nama_Customer, v.Kd_Stok, v.Nama_Barang, " & _
                                                    "v.Kd_Satuan, v.Nama_Wilayah, v.Nama_Area " & _
                                                    "from PROD.dbo.PROD_dpb_d t " & _
                                                    "left join PROD.dbo.PRODV_MON_SO v " & _
                                                    "on v.No_sp=t.no_sp and v.No_seq_d=t.no_sp_dtl and v.No_sp_box = t.no_seq " & _
                                                    "INNER JOIN PROD.dbo.PROD_dpb_m m " & _
                                                    "on m.no_trans = t.no_trans " & _
                                                    "where m.no_trans_krm= '" & txtNoTrans.EditValue & "'", sqlconn))
            da2.Fill(ds1, "BarangDetil")


            Dim rl1 As DataRelation
            rl1 = ds1.Relations.Add("Detail Barang", ds1.Tables("Barang").Columns("no_sp"), ds1.Tables("BarangDetil").Columns("no_sp"), False)

            GC.DataSource = ds1.Tables("Barang")
            GC.LevelTree.Nodes.Add("Detail Barang", GV_Detail)
            GV.BestFitColumns()
           
        End If
    End Sub

    
    
    Private Sub txtNoTrans_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoTrans.EditValueChanged
        If txtNoTrans.EditValue = Nothing Then

        Else
            Dim dr As SqlDataReader
            dr = New SqlClient.SqlCommand("select * from PROD.dbo.PROD_rcn_krm_m where no_trans='" & txtNoTrans.EditValue & "' ", sqlconn).ExecuteReader
            dr.Read()
            txtKendaraan.EditValue = dr.Item("kd_kendaraan")
            txtSopir.EditValue = dr.Item("kd_sopir")
            txtKernet.EditValue = dr.Item("kd_kenek")
            dr.Close()

            LoadDataBarang()
        End If
       
    End Sub

    Private Sub txtKendaraan_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKendaraan.EditValueChanged
        txt_kdKendaraan.Text = txtKendaraan.Text
    End Sub

    Private Sub txtSopir_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSopir.EditValueChanged
        txt_KdSopir.Text = txtSopir.Text
    End Sub

    Private Sub txtKernet_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtKernet.EditValueChanged
        txt_KdKernet.Text = txtKernet.Text
    End Sub
    
    Public Sub save_click()

        btnSave = False
        setStatus()
        For i As Int16 = 0 To GV.RowCount - 1
            BindingContext(GC.DataSource).Position = i
            GV.SetRowCellValue(i, "no_dpb", "PROSES")
            GV.RefreshRow(i)
            GV.SetRowCellValue(i, "no_dpb", proses(i))
            GV.RefreshRow(i)

        Next
        showMessages("Data DPB berhasil disimpan")
        btnSave = True
        setStatus()
        'reload()


    End Sub

    Private Function proses(ByVal i As Int16) As String
        Dim tgl As Date = getTanggal()
        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = sqlconn
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.CommandText = "PROD.dbo.buatDPB"
        sqlcmd.Parameters.Add("@no_trans_krm", SqlDbType.VarChar, 40).Value = txtNoTrans.EditValue
        sqlcmd.Parameters.Add("@no_sp", SqlDbType.VarChar, 40).Value = GV.GetRowCellValue(i, "no_sp")
        sqlcmd.Parameters.Add("@kdpeg", SqlDbType.VarChar, 40).Value = username
        sqlcmd.Parameters.Add("@tgldpb", SqlDbType.Date).Value = tgl
        sqlcmd.Parameters.Add("@no_dpb2", SqlDbType.VarChar, 100)
        sqlcmd.Parameters("@no_dpb2").Direction = ParameterDirection.Output
        sqlcmd.ExecuteNonQuery()
        Return sqlcmd.Parameters("@no_dpb2").Value.ToString
    End Function

    Public Sub cancel_click()
        txtNoTrans.EditValue = ""
        'reload()
        txtKendaraan.EditValue = ""
        txtSopir.EditValue = ""
        txtKernet.EditValue = ""
        txtNoTrans.Visible = True
        TextEdit1.Visible = False
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
    End Sub

    Public Sub cetak_click()
       
        Try
            callReport(App_Path() & "\report\PROD_DPB(Rekap).rpt", "", "&no_kirim=" & TextEdit1.Text)
        Catch ex As Exception
            callReport(App_Path() & "\report\PROD_DPB(Rekap).rpt", "", "&no_kirim=" & txtNoTrans.Text)
        End Try
      
    End Sub


    Private Sub btnCetak_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCetak.Click
        cetak_click()
    End Sub

  
    Private Sub txtNoTrans_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNoTrans.MouseEnter
        'Dim dr As SqlDataReader
        'dr = New SqlClient.SqlCommand("select * from PROD.dbo.PROD_rcn_krm_m where no_trans='" & txtNoTrans.EditValue & "' ", sqlconn).ExecuteReader
        'dr.Read()
        'txtKendaraan.EditValue = dr.Item("kd_kendaraan")
        'txtSopir.EditValue = dr.Item("kd_sopir")
        'txtKernet.EditValue = dr.Item("kd_kenek")
        'dr.Close()

        'LoadDataBarang()
    End Sub
End Class