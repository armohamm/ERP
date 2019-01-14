Imports System.Data.SqlClient
Public Class frmProsesPromo
    Dim dsete As New DataSet
    Dim dadbe, DAP As SqlDataAdapter
    Dim prn As frmMain
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = False
            .btnCancel.Enabled = False
            .btnDelete.Enabled = False
            .btnEdit.Enabled = False
            .btnSave.Enabled = True
        End With
    End Sub
    Public Sub add_click()
        setStatus()
    End Sub
    Public Sub cancel_click()
        cmdPromo.EditValue = vbNullString
        txtKeterangan.Text = ""
        txtBatasKirim.Text = ""
        txtMulai.Text = ""
        txtSelesai.Text = ""

        setStatus()
    End Sub

    Private Sub frmProsesPromo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        prn = frmMain
        connect()
        dadbe = New SqlDataAdapter(New SqlCommand("select * from sif.dbo.sif_promo where isnull(isClosed,'') ='' and not tgl_batas_kirim is null", sqlconn))
        dadbe.Fill(dsete, "promo")
        cmdPromo.Properties.DataSource = dsete.Tables("promo")

        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
    End Sub

    Private Sub cmdPromo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPromo.EditValueChanged
        If cmdPromo.EditValue = "" Then
            txtKeterangan.EditValue = vbNullString
            txtMulai.EditValue = vbNullString
            txtSelesai.EditValue = vbNullString
            txtBatasKirim.EditValue = vbNullString
        Else
            txtKeterangan.EditValue = cmdPromo.GetSelectedDataRow.item("nama_promo")
            txtMulai.EditValue = cmdPromo.GetSelectedDataRow.item("start_date")
            txtSelesai.EditValue = cmdPromo.GetSelectedDataRow.item("end_date")
            txtBatasKirim.EditValue = cmdPromo.GetSelectedDataRow.item("Tgl_Batas_Kirim")
        End If
    End Sub
    Public Sub save_click()
        If MsgBox("Proses Promo ? ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkCancel, "Proses") = MsgBoxResult.Cancel Then
            Exit Sub
        End If
        Dim btrans As SqlTransaction
        Dim myBuilder As SqlCommandBuilder

        If Not dsete.Tables("so") Is Nothing Then dsete.Tables("so").Clear()
        dadbe = New SqlDataAdapter(New SqlCommand("select no_sp, Tipe_trans from sales.dbo.sales_so where tgl_sp between @tglstart and @tglend and isnull(status,'')='OK' and isnull(isClosed,'') <> 'Y' and departement=" & cmdPromo.GetSelectedDataRow.item("kd_dept"), sqlconn))
        dadbe.SelectCommand.Parameters.Add("@tglstart", SqlDbType.DateTime).Value = txtMulai.EditValue
        dadbe.SelectCommand.Parameters.Add("@tglend", SqlDbType.DateTime).Value = txtSelesai.EditValue
        dadbe.Fill(dsete, "so")
        DAP = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.*, '' Jenis, '' Merk, '' Tipe, '' Subtipe ,(select nama_promo from sif.dbo.sif_promo where no_promo=a.kd_promo) PROMONAME from Sales.dbo.SALES_SO_D_PROMO a where 1=0", sqlconn))
        DAP.Fill(dsete, "SOP")
        myBuilder = New SqlClient.SqlCommandBuilder(DAP)
        myBuilder.ConflictOption = ConflictOption.OverwriteChanges
        DAP.UpdateCommand = myBuilder.GetUpdateCommand()
        DAP.InsertCommand = myBuilder.GetInsertCommand()
        DAP.DeleteCommand = myBuilder.GetDeleteCommand()

        Try
            btrans = sqlconn.BeginTransaction

            DAP.UpdateCommand.Transaction = btrans
            DAP.InsertCommand.Transaction = btrans
            DAP.DeleteCommand.Transaction = btrans

            For Each rwx As DataRow In dsete.Tables("so").Rows
                With New SqlCommand("delete from Sales.dbo.SALES_SO_D_PROMO where No_sp='" & rwx("no_sp") & "' and Status='Y' and KD_PROMO='" & cmdPromo.EditValue & "'", sqlconn, btrans).ExecuteNonQuery
                End With
                Dim dr As SqlDataReader = New SqlCommand("select a.* from sales.dbo.SoGetPromoBatasKirim('" & cmdPromo.EditValue & "','" & rwx("no_sp") & "' , '" & rwx("Tipe_trans") & "') as a", sqlconn, btrans).ExecuteReader
                Dim i As Int16 = 1
                While dr.Read()
                    Dim rw As DataRow = dsete.Tables("SOP").NewRow
                    rw("Kd_Cabang") = kdcabang
                    rw("tipe_trans") = rwx("Tipe_trans")
                    rw("Departemen") = kddep
                    rw("seq_sp") = i : i += 1
                    rw("NO_SP") = cmdPromo.EditValue
                    rw("KD_PROMO") = dr("KDPROMO")
                    rw("No_Seq") = dr("NOSEQ")
                    rw("JML_POINT") = dr("jml_point")
                    rw("CASHBACK") = dr("cash_back")
                    rw("Potongan") = dr("potongan")
                    rw("Potongan2") = dr("potongan2")
                    rw("KD_BRG_BONUS") = dr("kd_brg_bonus")
                    rw("QTY") = dr("free_qty")
                    rw("PROMO_DESC") = dr("PROMODESC")
                    rw("Programe_name") = Me.Name
                    rw("Last_Create_Date") = getTanggal(btrans)
                    rw("Last_Created_By") = username
                    rw("Status") = "Y"
                    rw("SP_AKUMULASI") = "T"
                    rw("ISNAMBAH") = dr("IS_NAMBAH")
                    rw("isTerkecil") = dr("isTerkecil")
                    rw("PromoBatasKirim") = "Y"
                    rw("NO_SP") = rwx("no_sp")
                    dsete.Tables("SOP").Rows.Add(rw)
                End While
            Next
            DAP.Update(dsete.Tables("SOP"))
            btrans.Commit()
            MsgBox("Data Telah Diproses", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            cancel_click()
        Catch ex As Exception
            If Not btrans Is Nothing Then btrans.Rollback()
            MsgBox("Proses Simpan Gagal : " & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Gagal Simpan")
        End Try

    End Sub
End Class