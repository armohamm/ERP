Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmRlsRph
    Dim dsete, ds1, ds2 As New DataSet
    Dim dadbe, da1, da2 As SqlDataAdapter
    Dim DA As SqlDataAdapter
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

    Dim lng As Long
    Public Sub call_procedure()
        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader
        'Try
        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "PROD.dbo.prodp_ins_spk"
        sqlCmd.Parameters.Add("@vno_rph", SqlDbType.Char).Value = TextEdit1.Text 'frmCari.row("NO TRANS")
        dr = sqlCmd.ExecuteReader
        dr.Close()

        Dim sqlCmd2 As New SqlCommand
        sqlCmd2.Connection = sqlconn
        sqlCmd2.CommandType = CommandType.StoredProcedure
        sqlCmd2.CommandText = "PROD.dbo.prodp_ins_spbb"
        sqlCmd2.Parameters.Add("@vno_rph", SqlDbType.Char).Value = TextEdit1.Text 'frmCari.row("NO TRANS")
        dr = sqlCmd2.ExecuteReader
        dr.Close()

        Dim sqlCmd3 As New SqlCommand
        sqlCmd3.Connection = sqlconn
        sqlCmd3.CommandType = CommandType.StoredProcedure
        sqlCmd3.CommandText = "PROD.dbo.prodp_ins_dpm"
        sqlCmd3.Parameters.Add("@vno_rph", SqlDbType.Char).Value = TextEdit1.Text 'frmCari.row("NO TRANS")
        dr = sqlCmd3.ExecuteReader
        dr.Close()

        Dim sqlCmd4 As New SqlCommand
        sqlCmd4.Connection = sqlconn
        sqlCmd4.CommandType = CommandType.StoredProcedure
        sqlCmd4.CommandText = "PROD.dbo.prodp_ins_barcode"
        sqlCmd4.Parameters.Add("@vno_rph", SqlDbType.Char).Value = TextEdit1.Text 'frmCari.row("NO TRANS")
        dr = sqlCmd4.ExecuteReader
        dr.Close()

        Dim sqlCmd6 As New SqlCommand
        sqlCmd6.Connection = sqlconn
        sqlCmd6.CommandType = CommandType.StoredProcedure
        sqlCmd6.CommandText = "PROD.dbo.prodp_ins_qty_prod_in"
        sqlCmd6.Parameters.Add("@vno_rph", SqlDbType.Char).Value = TextEdit1.Text 'frmCari.row("NO TRANS")
        dr = sqlCmd6.ExecuteReader
        dr.Close()

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

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select  Nama_Jenis,no_rph, Nama_Merk, Nama_Tipe, Warna, " & _
                " uk90 = sum(case ukuran when '90' then jumlah else 0 end)," & _
                " uk100 = sum(case ukuran when '100' then jumlah else 0 end)," & _
                " uk110 = sum(case ukuran when '110' then jumlah else 0 end)," & _
                " uk120 = sum(case ukuran when '120' then jumlah else 0 end), " & _
                " uk130 = sum(case ukuran when '130' then jumlah else 0 end)," & _
                " uk140 = sum(case ukuran when '140' then jumlah else 0 end), " & _
                " uk150 = sum(case ukuran when '150' then jumlah else 0 end), " & _
                " uk160 = sum(case ukuran when '160' then jumlah else 0 end), " & _
                " uk170 = sum(case ukuran when '170' then jumlah else 0 end)," & _
                " uk180 = sum(case ukuran when '180' then jumlah else 0 end), " & _
                " uk190 = sum(case ukuran when '190' then jumlah else 0 end)," & _
                " uk200 = sum(case ukuran when '200' then jumlah else 0 end), " & _
                " ukKHS = sum(case ukuran when 'KHS' then jumlah else 0 end) " & _
                " from PROD.dbo.PRODV_RCN_PROD " & _
                " where kd_departemen = '" & kddep & "' " & _
                " group by  Nama_Jenis,no_rph, Nama_Merk, Nama_Tipe, Warna ", sqlconn))
        dsete.Reset()
        gc.Refresh()
        DA.Fill(dsete, "SALES_SO_D")
        gc.DataSource = dsete.Tables("SALES_SO_D")
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

    Public Sub cetak_click()
        'If Trim(txtNoDPB.Text) <> "" And State = "EDIT" Then
        'callReport(App_Path() & "\report\rptPOM.rpt", "", "Nomor=" & Trim(txtNoPO.Text))

        'Dim notrans As String = Trim(txtNoDPB.Text)
        callReport(App_Path() & "\report\ProdRlsRph.rpt", "", "norph=" & TextEdit1.Text)
        'Else
        'MessageBox.Show("Pilih data yang akan dicetak dalam mode EDIT!")
        'End If
    End Sub
    Public Sub tampil_awal()

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select no_rph, Nama_Jenis, Nama_Merk, Nama_Tipe, Warna, " & _
                " uk90 = sum(case ukuran when '90' then jumlah else 0 end)," & _
                " uk100 = sum(case ukuran when '100' then jumlah else 0 end)," & _
                " uk110 = sum(case ukuran when '110' then jumlah else 0 end)," & _
                " uk120 = sum(case ukuran when '120' then jumlah else 0 end), " & _
                " uk130 = sum(case ukuran when '130' then jumlah else 0 end)," & _
                " uk140 = sum(case ukuran when '140' then jumlah else 0 end), " & _
                " uk150 = sum(case ukuran when '150' then jumlah else 0 end), " & _
                " uk160 = sum(case ukuran when '160' then jumlah else 0 end), " & _
                " uk170 = sum(case ukuran when '170' then jumlah else 0 end)," & _
                " uk180 = sum(case ukuran when '180' then jumlah else 0 end), " & _
                " uk190 = sum(case ukuran when '190' then jumlah else 0 end)," & _
                " uk200 = sum(case ukuran when '200' then jumlah else 0 end), " & _
                " ukKHS = sum(case ukuran when 'KHS' then jumlah else 0 end) " & _
                " from PROD.dbo.PRODV_RCN_PROD " & _
                " where kd_departemen = '" & kddep & "' " & _
                " group by  Nama_Jenis,no_rph, Nama_Merk, Nama_Tipe, Warna ", sqlconn))

        dsete.Reset()
        gc.Refresh()
        DA.Fill(dsete, "SALES_SO_D")
        gc.DataSource = dsete.Tables("SALES_SO_D")
        gc.Show()
        jenis.Group()


    End Sub
    Public Sub save_click()
        If TextEdit1.EditValue <> "" Then
            call_procedure()
            
            gc.DataSource = dsete.Tables("SALES_SO_D")
            gc.Show()

            btnSave = False
            btnadd = False
            btnEdit = True
            'btnDelete = True
            btnCancel = True
            setStatus()
            'Me.Enabled = True

            sqlconn.Close()
            con_open = False
            'MsgBox("closed..")
        End If

    End Sub
    
    Public Sub tampil()
        
        Dim qstr As String = "select no_rph as [NO TRANS], kd_jadwal as [JADWAL KERJA] from PROD.dbo.PRODV_RCN_PROD " & _
                 " where kd_departemen = '" & kddep & "' group by no_rph, kd_jadwal "
        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(qstr, sqlconn))
        If Not ds1.Tables("lookup_so") Is Nothing Then ds1.Tables("lookup_so").Clear()
        da1.Fill(ds1, "lookup_so")
        frmCari.set_dso(ds1.Tables("lookup_so"))
        'ds3.Tables("lookup_so").Columns(0).DateTimeMode = "dd/MM/yyyy"
        frmCari.set_dso(ds1.Tables("lookup_so"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then
            da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select  Nama_Jenis, no_rph,Nama_Merk, Nama_Tipe, Warna, " & _
                " uk90 = sum(case ukuran when '90' then jumlah else 0 end)," & _
                " uk100 = sum(case ukuran when '100' then jumlah else 0 end)," & _
                " uk110 = sum(case ukuran when '110' then jumlah else 0 end)," & _
                " uk120 = sum(case ukuran when '120' then jumlah else 0 end), " & _
                " uk130 = sum(case ukuran when '130' then jumlah else 0 end)," & _
                " uk140 = sum(case ukuran when '140' then jumlah else 0 end), " & _
                " uk150 = sum(case ukuran when '150' then jumlah else 0 end), " & _
                " uk160 = sum(case ukuran when '160' then jumlah else 0 end), " & _
                " uk170 = sum(case ukuran when '170' then jumlah else 0 end)," & _
                " uk180 = sum(case ukuran when '180' then jumlah else 0 end), " & _
                " uk190 = sum(case ukuran when '190' then jumlah else 0 end)," & _
                " uk200 = sum(case ukuran when '200' then jumlah else 0 end), " & _
                " ukKHS = sum(case ukuran when 'KHS' then jumlah else 0 end) " & _
                " from PROD.dbo.PRODV_RCN_PROD " & _
                " where kd_departemen = '" & kddep & "' " & _
                " and no_rph = '" & frmCari.row("NO TRANS") & "' " & _
                " group by  Nama_Jenis,no_rph, Nama_Merk, Nama_Tipe, Warna ", sqlconn))
            ds2.Reset()
            da2.Fill(ds2, "rph2")
            gc.DataSource = ds2.Tables("rph2")
            TextEdit1.EditValue = frmCari.row("NO TRANS")
            txtJadwal.EditValue = frmCari.row("JADWAL KERJA")

            btnSave = True
            btnadd = False
            btnEdit = True
            'btnDelete = True
            btnCancel = True
            setStatus()
            Me.Enabled = True
        End If

    End Sub


    Public Sub cancel_click()

        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnAdd = True
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
        tampil()
    End Sub

End Class