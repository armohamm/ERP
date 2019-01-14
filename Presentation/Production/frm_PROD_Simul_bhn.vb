Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base


Public Class frm_PROD_Simul_bhn
    Dim ds1, ds2, ds3, ds4, ds5, ds6, ds7 As New DataSet
    Dim da1, da2, da3, da4, da5, da6, da7, da8, da9 As New SqlDataAdapter
    Dim row, row1 As DataRow
    Dim mb, mb1 As New SqlCommandBuilder
    Dim BTRANS As SqlTransaction
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA As SqlDataAdapter
    Dim DAD As SqlDataAdapter
    Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode
    Dim obj As Object
    Dim prn As frmMain
    Dim jumlah As Integer
    Public btnSave As Boolean = False
    Public btnadd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Dim Lebar3, Lebar2, Lebar1 As Double
    Dim Lebar5, Lebar4, Lebar6 As Double
    Public State As String
    Dim B, C, D, A As Integer
    Dim itung As Integer = 0
    Dim x1, x2, x3, x4, i, x5, x6, x7, x8, x9, x10, x11, x12, i2, i3 As Double
    Dim tot, view1, lebarq, jumlah_sisa, jumlah_blok As Double
    Dim myBuilder As New SqlCommandBuilder
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
      
    End Sub
    Private Sub frm_PROD_Simul_bhn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        State = "ADD"

        If Not ds1.Tables("Barang") Is Nothing Then ds1.Tables("Barang").Clear()
        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_simul_bhn_m where 1=0  ", sqlconn))
        da1.Fill(ds1, "Barang")
     

        If Not ds1.Tables("Barang_d") Is Nothing Then ds1.Tables("Barang_d").Clear()
        da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_simul_bhn_d where 1=0  ", sqlconn))
        da2.Fill(ds1, "Barang_d")

        gc.DataSource = ds1.Tables("Barang")
        
        setStatus()
      
       



    End Sub
    Private Sub loadlookup()
        If Not ds2.Tables("lkBarang") Is Nothing Then ds2.Tables("lkBarang").Clear()
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang order by nama_barang ", sqlconn))
        da3.Fill(ds2, "lkBarang")
        lkbarang.DataSource = ds2.Tables("lkBarang")
        lkbarang.ValueMember = "Kode_Barang"
        lkbarang.DisplayMember = "Nama_Barang"

        
    End Sub

    Public Sub add_click()
        State = "ADD"
        loadlookup()

        btnSave = True
        btnCancel = True
        btnDelete = False
        btnEdit = False
        btnadd = False
        
        setStatus()
    End Sub

    Public Sub edit_click()
      
        State = "EDIT"
        If Not ds1.Tables("Barangq") Is Nothing Then ds1.Tables("Barangq").Clear()
        da1 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_simul_bhn_m where no_trans='" & A & "'" & _
                                                                    "and kd_brg='" & B & "' ", sqlconn))
        da1.Fill(ds1, "Barangq")
        If Not ds3.Tables("lookup_so") Is Nothing Then ds3.Tables("lookup_so").Clear()
        
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_simul_bhn_m a INNER JOIN SIF.dbo.SIF_Barang br " & _
                                                                    "on a.kd_brg=br.Kode_Barang ", sqlconn))

        da3.Fill(ds3, "lookup_so")
        frmCari.set_dso(ds3.Tables("lookup_so"))
        frmCari.ShowDialog()
        If Not frmCari.row Is Nothing Then


           
            Dim a As String
            Dim b As String

            a = frmCari.row("no_trans")
            b = frmCari.row("kd_brg")


           

            If Not ds3.Tables("Barangd") Is Nothing Then ds3.Tables("Barangd").Clear()
            da2 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_simul_bhn_m a " & _
                                                                        "where no_trans='" & a & "'" & _
                                                                        "and kd_brg='" & b & "' ", sqlconn))
            da2.Fill(ds3, "Barangd")

            row1 = ds3.Tables("Barangd").Rows(0)
            no.Text = row1.Item("no_trans").ToString
            loadlookup()
            gc.DataSource = ds3.Tables("Barangd")



            Dim sqlCmd As New SqlCommand
            Dim dr As SqlDataReader

            sqlCmd.Connection = sqlconn
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.CommandText = "PROD.dbo.prodp_ins_simul_bahan"
            sqlCmd.Parameters.Add("@vno_trans", SqlDbType.Char).Value = no.Text
            dr = sqlCmd.ExecuteReader
            dr.Close()

            If Not ds2.Tables("lkBarangd") Is Nothing Then ds2.Tables("lkBarangd").Clear()
            da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang order by nama_barang  ", sqlconn))
            da3.Fill(ds2, "lkBarangd")

            If Not ds1.Tables("Barangdet") Is Nothing Then ds1.Tables("Barangdet").Clear()
            da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_simul_bhn_d where no_trans='" & no.Text & "'  ", sqlconn))
            da3.Fill(ds1, "Barangdet")

            lknama.DataSource = ds2.Tables("lkBarangd")
            lknama.ValueMember = "Kode_Barang"
            lknama.DisplayMember = "Nama_Barang"

            GridControl1.DataSource = ds1.Tables("Barangdet")




            btnSave = True
            btnadd = False
            btnEdit = False
            btnDelete = True
            btnCancel = True
            setStatus()
            Me.Enabled = True
            
        Else
            cancel_click()
        End If
    End Sub
    Public Sub simpanmaster()
        If State = "ADD" Then '----------Simpan ADD
            Dim tgl As Date = getTanggal()




            Dim BTRANS As SqlTransaction
            mb = New SqlClient.SqlCommandBuilder(da1)
            da1.UpdateCommand = mb.GetUpdateCommand()
            da1.InsertCommand = mb.GetInsertCommand()
            da1.DeleteCommand = mb.GetDeleteCommand()

            

            BTRANS = sqlconn.BeginTransaction("1")
            da1.UpdateCommand.Transaction = BTRANS
            da1.InsertCommand.Transaction = BTRANS
            da1.DeleteCommand.Transaction = BTRANS

          


            Dim notrans As String
            notrans = getNoTrans("SMLBHN", tgl, BTRANS)
            no.Text = notrans
            For i As Integer = 0 To gv.RowCount - 1
                ds1.Tables("Barang").Rows(i).Item("no_trans") = no.Text

            Next

            For Each rows As DataRow In ds1.Tables("Barang").Rows
                If rows.RowState = DataRowState.Added Then

                    rows.Item("kd_departemen") = kddep
                    rows.Item("kd_cabang") = kdcabang

                ElseIf rows.RowState = DataRowState.Modified Then
                    rows.Item("last_update_date") = Now
                    rows.Item("last_updated_by") = username
                End If

            Next
         

            Try

                da1.Update(ds1.Tables("Barang"))
              
                ds1.Tables("Barang").AcceptChanges()
               
                BTRANS.Commit()
                btnSave = False
                setStatus()
                showMessages("Data Berhasil Disimpan")
                State = "EDIT"
              

            Catch e As Exception
                BTRANS.Rollback()
                ds1.Tables("Barang").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
            End Try

        ElseIf State = "EDIT" Then

            Dim tgl As Date = getTanggal()




            Dim BTRANS As SqlTransaction
            mb = New SqlClient.SqlCommandBuilder(da1)
            da1.UpdateCommand = mb.GetUpdateCommand()
            da1.InsertCommand = mb.GetInsertCommand()
            da1.DeleteCommand = mb.GetDeleteCommand()



            BTRANS = sqlconn.BeginTransaction("1")
            da1.UpdateCommand.Transaction = BTRANS
            da1.InsertCommand.Transaction = BTRANS
            da1.DeleteCommand.Transaction = BTRANS


            For Each rows As DataRow In ds1.Tables("Barang").Rows
                If rows.RowState = DataRowState.Added Then


                    rows.Item("kd_departemen") = kddep
                    rows.Item("kd_cabang") = kdcabang

                ElseIf rows.RowState = DataRowState.Modified Then
                    rows.Item("last_update_date") = Now
                    rows.Item("last_updated_by") = username
                End If

            Next


            Try

                da1.Update(ds1.Tables("Barang"))

                ds1.Tables("Barang").AcceptChanges()

                BTRANS.Commit()
                btnSave = False
                setStatus()
                showMessages("Data Berhasil Diedit")
                State = "EDIT"


            Catch e As Exception
                BTRANS.Rollback()
                ds1.Tables("Barang").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
            End Try

        End If



    End Sub



    Public Sub call_procedure(ByVal vnotrans As String, ByVal btrans As SqlTransaction)
        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader

        Dim sqlCmd1 As New SqlCommand
        sqlCmd1.Connection = sqlconn
        sqlCmd1.Transaction = btrans
        sqlCmd1.CommandType = CommandType.StoredProcedure
        sqlCmd1.CommandText = "PROD.dbo.prodp_ins_prod_b"
        sqlCmd1.Parameters.Add("@vno_rph", SqlDbType.Char).Value = vnotrans 'frmCari.row("NO TRANS")
        dr = sqlCmd1.ExecuteReader
        dr.Close()

        'sqlconn.Close()
    End Sub
    Public Sub delete_click()
        If MsgBox("Hapus Data Yang Dipilih?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data") = MsgBoxResult.Yes Then




            showMessages("Deleted..")

        End If
    End Sub

    Public Sub cancel_click()
        If Not ds2.Tables("lkBarangd") Is Nothing Then ds2.Tables("lkBarangd").Clear()
       
        If Not ds1.Tables("Barangdet") Is Nothing Then ds1.Tables("Barangdet").Clear()
        If Not ds3.Tables("Barangd") Is Nothing Then ds3.Tables("Barangd").Clear()

        If Not ds1.Tables("Barang") Is Nothing Then ds1.Tables("Barang").Clear()

        If Not ds1.Tables("Barang_d") Is Nothing Then ds1.Tables("Barang_d").Clear()
        no.Text = ""
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = True
        btnadd = True
        setStatus()
        Me.Enabled = False
    End Sub
    Public Sub save_click()

        If State = "EDIT" Then

            Dim tgl As Date = getTanggal()




            Dim BTRANS As SqlTransaction
            mb1 = New SqlClient.SqlCommandBuilder(da2)
            da2.UpdateCommand = mb1.GetUpdateCommand()
            da2.InsertCommand = mb1.GetInsertCommand()
            da2.DeleteCommand = mb1.GetDeleteCommand()



            BTRANS = sqlconn.BeginTransaction("1")
            da2.UpdateCommand.Transaction = BTRANS
            da2.InsertCommand.Transaction = BTRANS
            da2.DeleteCommand.Transaction = BTRANS


            For Each rows As DataRow In ds3.Tables("Barangd").Rows
                If rows.RowState = DataRowState.Added Then


                    rows.Item("kd_departemen") = kddep
                    rows.Item("kd_cabang") = kdcabang

                ElseIf rows.RowState = DataRowState.Modified Then

                    rows.Item("last_update_date") = Now
                    rows.Item("last_updated_by") = username
                End If

            Next


            Try

                da2.Update(ds3.Tables("Barangd"))

                ds3.Tables("Barangd").AcceptChanges()

                BTRANS.Commit()
                btnSave = False
                setStatus()
                showMessages("Data Berhasil Diedit")
                State = "EDIT"


            Catch e As Exception
                BTRANS.Rollback()
                ds3.Tables("Barangd").RejectChanges()
                MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
            End Try

            Dim sqlCmd As New SqlCommand
            Dim dr As SqlDataReader

            sqlCmd.Connection = sqlconn
            sqlCmd.CommandType = CommandType.StoredProcedure
            sqlCmd.CommandText = "PROD.dbo.prodp_ins_simul_bahan"
            sqlCmd.Parameters.Add("@vno_trans", SqlDbType.Char).Value = no.Text
            dr = sqlCmd.ExecuteReader
            dr.Close()

            If Not ds2.Tables("lkBarangd") Is Nothing Then ds2.Tables("lkBarangd").Clear()
            da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang order by nama_barang  ", sqlconn))
            da3.Fill(ds2, "lkBarangd")

            If Not ds1.Tables("Barangdet") Is Nothing Then ds1.Tables("Barangdet").Clear()
            da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_simul_bhn_d where no_trans='" & no.Text & "'  ", sqlconn))
            da3.Fill(ds1, "Barangdet")

            lknama.DataSource = ds2.Tables("lkBarangd")
            lknama.ValueMember = "Kode_Barang"
            lknama.DisplayMember = "Nama_Barang"

            GridControl1.DataSource = ds1.Tables("Barangdet")

        End If

    
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        simpanmaster()
        Dim sqlCmd As New SqlCommand
        Dim dr As SqlDataReader

        sqlCmd.Connection = sqlconn
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandText = "PROD.dbo.prodp_ins_simul_bahan"
        sqlCmd.Parameters.Add("@vno_trans", SqlDbType.Char).Value = no.Text
        dr = sqlCmd.ExecuteReader
        dr.Close()

        If Not ds2.Tables("lkBarangd") Is Nothing Then ds2.Tables("lkBarangd").Clear()
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select Kode_Barang,Nama_Barang from SIF.dbo.SIF_Barang order by nama_barang  ", sqlconn))
        da3.Fill(ds2, "lkBarangd")

        If Not ds1.Tables("Barangdet") Is Nothing Then ds1.Tables("Barangdet").Clear()
        da3 = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from PROD.dbo.PROD_simul_bhn_d where no_trans='" & no.Text & "'  ", sqlconn))
        da3.Fill(ds1, "Barangdet")

        lknama.DataSource = ds2.Tables("lkBarangd")
        lknama.ValueMember = "Kode_Barang"
        lknama.DisplayMember = "Nama_Barang"

        GridControl1.DataSource = ds1.Tables("Barangdet")
        


    End Sub
End Class