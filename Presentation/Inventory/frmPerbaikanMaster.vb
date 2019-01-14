Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class frmPerbaikanMaster
    Dim dsete As New DataSet
    Dim dsete2 As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim DA As SqlDataAdapter
    Dim DAB As SqlDataAdapter
    Dim DAP As SqlDataAdapter
    Dim DAD As SqlDataAdapter
    Dim DADD As SqlDataAdapter
    Dim obj As Object
    Dim prn As frmMain
    Dim kriteria As String
    Public btnSave As Boolean = True
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public btnCetak As Boolean = False
    Public State As String
    Public baru As Boolean
    Dim myBuilder As New SqlCommandBuilder
    Private clone As DataView
    Public no_sp As String = ""
    Public tipe_transaksi As String = ""
    Dim rhandel As Integer
    Public konsinyasi = "UMUM"
    Public ONLOAD_STATE As Boolean = False
    Public oldTotal As Double = 0
    Dim dvCustomer As New DataView
    Public isInternal As Boolean = False
    Dim FORCE_OPEN As String
    Dim kddepx As String = KD_DIV_SPRING
    Private Sub frmPerbaikanMaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        prn = getParent(Me)
        'deTglMulai.DateTime = Now
        'deTglSelesai.DateTime = Now
        Me.Enabled = True

        'GV.
        'connect()

        dadbe = New SqlDataAdapter(New SqlCommand("select * from sif_jns_persediaan WHERE isnull(rec_stat,'') = 'Y'", sqlconn))
        dadbe.Fill(dsete, "jns_persed")
        repkdjenis.DataSource = dsete.Tables("jns_persed")
        dadbe = New SqlDataAdapter(New SqlCommand("select * from sif_jenis_barang WHERE isnull(rec_stat,'') = 'Y'", sqlconn))
        dadbe.Fill(dsete, "jns_barang")
        repJenis.DataSource = dsete.Tables("jns_barang")
        dadbe = New SqlDataAdapter(New SqlCommand("select * from sif_merk WHERE isnull(rec_stat,'') = 'Y'", sqlconn))
        dadbe.Fill(dsete, "merk")
        repMerk.DataSource = dsete.Tables("merk")
        dadbe = New SqlDataAdapter(New SqlCommand("select * from sif_tipe WHERE isnull(rec_stat,'') = 'Y'", sqlconn))
        dadbe.Fill(dsete, "tipe")
        repTipe.DataSource = dsete.Tables("tipe")
        dadbe = New SqlDataAdapter(New SqlCommand("select * from sif_sub_tipe WHERE isnull(rec_stat,'') = 'Y'", sqlconn))
        dadbe.Fill(dsete, "sub_tipe")
        repssubtipe.DataSource = dsete.Tables("sub_tipe")
        dadbe = New SqlDataAdapter(New SqlCommand("select * from sif_ukuran WHERE isnull(rec_stat,'') = 'Y'", sqlconn))
        dadbe.Fill(dsete, "ukuran")
        repUkuran.DataSource = dsete.Tables("ukuran")
        dadbe = New SqlDataAdapter(New SqlCommand("select * from sif_kain WHERE isnull(rec_stat,'') = 'Y'", sqlconn))
        dadbe.Fill(dsete, "kain")
        repKain.DataSource = dsete.Tables("kain")
        dadbe = New SqlDataAdapter(New SqlCommand("select * from sif_satuan WHERE isnull(rec_stat,'') = 'Y'", sqlconn))
        dadbe.Fill(dsete, "satuan")
        repSatuan.DataSource = dsete.Tables("satuan")

        dadbe = New SqlDataAdapter(New SqlCommand("SELECT Kd_Buku_Besar,Nm_Buku_Besar FROM SIF.dbo.SIF_Buku_Besar where grup_header = 'D' AND Kd_Buku_Besar LIKE '41%' and Rec_Stat = 'Y'", sqlconn))
        dadbe.Fill(dsete, "RekPenjExt")
        lckRekJualExt.Properties.DataSource = dsete.Tables("RekPenjExt")
        lckRekJualExt.Properties.ValueMember = "Kd_Buku_Besar"
        lckRekJualExt.Properties.DisplayMember = "Nm_Buku_Besar"

        dadbe = New SqlDataAdapter(New SqlCommand("SELECT Kd_Buku_Besar,Nm_Buku_Besar FROM SIF.dbo.SIF_Buku_Besar where grup_header = 'D' AND Kd_Buku_Besar LIKE '43%' and Rec_Stat = 'Y'", sqlconn))
        dadbe.Fill(dsete, "RekPenjInt")
        lckRekJualInt.Properties.DataSource = dsete.Tables("RekPenjInt")
        lckRekJualInt.Properties.ValueMember = "Kd_Buku_Besar"
        lckRekJualInt.Properties.DisplayMember = "Nm_Buku_Besar"

        dadbe = New SqlDataAdapter(New SqlCommand("SELECT Kd_Buku_Besar,Nm_Buku_Besar FROM SIF.dbo.SIF_Buku_Besar where grup_header = 'D' AND Kd_Buku_Besar LIKE '44%' and Rec_Stat = 'Y'", sqlconn))
        dadbe.Fill(dsete, "RekReturInt")
        lckRekReturInt.Properties.DataSource = dsete.Tables("RekReturInt")
        lckRekReturInt.Properties.ValueMember = "Kd_Buku_Besar"
        lckRekReturInt.Properties.DisplayMember = "Nm_Buku_Besar"

        dadbe = New SqlDataAdapter(New SqlCommand("SELECT Kd_Buku_Besar,Nm_Buku_Besar FROM SIF.dbo.SIF_Buku_Besar where grup_header = 'D' AND Kd_Buku_Besar LIKE '42%' and Rec_Stat = 'Y'", sqlconn))
        dadbe.Fill(dsete, "RekReturExt")
        lckRekReturExt.Properties.DataSource = dsete.Tables("RekReturExt")
        lckRekReturExt.Properties.ValueMember = "Kd_Buku_Besar"
        lckRekReturExt.Properties.DisplayMember = "Nm_Buku_Besar"

        dadbe = New SqlDataAdapter(New SqlCommand("SELECT Kd_Buku_Besar,Nm_Buku_Besar FROM SIF.dbo.SIF_Buku_Besar where grup_header = 'D' AND Kd_Buku_Besar LIKE '452%' and Rec_Stat = 'Y'", sqlconn))
        dadbe.Fill(dsete, "RekBonusInt")
        lckRekBonusInt.Properties.DataSource = dsete.Tables("RekBonusInt")
        lckRekBonusInt.Properties.ValueMember = "Kd_Buku_Besar"
        lckRekBonusInt.Properties.DisplayMember = "Nm_Buku_Besar"

        dadbe = New SqlDataAdapter(New SqlCommand("SELECT Kd_Buku_Besar,Nm_Buku_Besar FROM SIF.dbo.SIF_Buku_Besar where grup_header = 'D' AND Kd_Buku_Besar LIKE '451%' and Rec_Stat = 'Y'", sqlconn))
        dadbe.Fill(dsete, "RekBonusExt")
        lckRekBonusExt.Properties.DataSource = dsete.Tables("RekBonusExt")
        lckRekBonusExt.Properties.ValueMember = "Kd_Buku_Besar"
        lckRekBonusExt.Properties.DisplayMember = "Nm_Buku_Besar"

        dadbe = New SqlDataAdapter(New SqlCommand("SELECT Kd_Buku_Besar,Nm_Buku_Besar FROM SIF.dbo.SIF_Buku_Besar where grup_header = 'D' AND Kd_Buku_Besar LIKE '511%' and Rec_Stat = 'Y'", sqlconn))
        dadbe.Fill(dsete, "RekHPP")
        lckRekHPP.Properties.DataSource = dsete.Tables("RekHPP")
        lckRekHPP.Properties.ValueMember = "Kd_Buku_Besar"
        lckRekHPP.Properties.DisplayMember = "Nm_Buku_Besar"

        dadbe = New SqlDataAdapter(New SqlCommand("select * from sif_barang WHERE isnull(rec_stat,'') = 'Y'", sqlconn))
        dadbe.Fill(dsete, "barang")
        GC.DataSource = dsete.Tables("barang")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim BTRANS As SqlTransaction

        Try

            Dim myBuilder As SqlClient.SqlCommandBuilder
            myBuilder = New SqlClient.SqlCommandBuilder(dadbe)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            dadbe.UpdateCommand = myBuilder.GetUpdateCommand()
            dadbe.InsertCommand = myBuilder.GetInsertCommand()
            dadbe.DeleteCommand = myBuilder.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")

            dadbe.UpdateCommand.Transaction = BTRANS
            dadbe.InsertCommand.Transaction = BTRANS
            dadbe.DeleteCommand.Transaction = BTRANS


            dadbe.Update(dsete.Tables("barang"))
            BTRANS.Commit()
            showMessages("Transaksi Telah Diproses")
        Catch ex As Exception
            If Not BTRANS Is Nothing Then BTRANS.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try

    End Sub

    Private Sub GV_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GV.KeyDown
        If e.KeyCode = Keys.Delete Then
            GV.DeleteSelectedRows()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        dsete = New DataSet
        dadbe = New SqlDataAdapter(New SqlCommand("select * from sif_jns_persediaan WHERE isnull(rec_stat,'') = 'Y'", sqlconn))
        dadbe.Fill(dsete, "jns_persed")
        repkdjenis.DataSource = dsete.Tables("jns_persed")
        dadbe = New SqlDataAdapter(New SqlCommand("select * from sif_jenis_barang WHERE isnull(rec_stat,'') = 'Y'", sqlconn))
        dadbe.Fill(dsete, "jns_barang")
        repJenis.DataSource = dsete.Tables("jns_barang")
        dadbe = New SqlDataAdapter(New SqlCommand("select * from sif_merk WHERE isnull(rec_stat,'') = 'Y'", sqlconn))
        dadbe.Fill(dsete, "merk")
        repMerk.DataSource = dsete.Tables("merk")
        dadbe = New SqlDataAdapter(New SqlCommand("select * from sif_tipe WHERE isnull(rec_stat,'') = 'Y'", sqlconn))
        dadbe.Fill(dsete, "tipe")
        repTipe.DataSource = dsete.Tables("tipe")
        dadbe = New SqlDataAdapter(New SqlCommand("select * from sif_sub_tipe WHERE isnull(rec_stat,'') = 'Y'", sqlconn))
        dadbe.Fill(dsete, "sub_tipe")
        repssubtipe.DataSource = dsete.Tables("sub_tipe")
        dadbe = New SqlDataAdapter(New SqlCommand("select * from sif_ukuran WHERE isnull(rec_stat,'') = 'Y'", sqlconn))
        dadbe.Fill(dsete, "ukuran")
        repUkuran.DataSource = dsete.Tables("ukuran")
        dadbe = New SqlDataAdapter(New SqlCommand("select * from sif_kain WHERE isnull(rec_stat,'') = 'Y'", sqlconn))
        dadbe.Fill(dsete, "kain")
        repKain.DataSource = dsete.Tables("kain")
        dadbe = New SqlDataAdapter(New SqlCommand("select * from sif_satuan WHERE isnull(rec_stat,'') = 'Y'", sqlconn))
        dadbe.Fill(dsete, "satuan")
        repSatuan.DataSource = dsete.Tables("satuan")
        dadbe = New SqlDataAdapter(New SqlCommand("select * from sif_barang WHERE isnull(rec_stat,'') = 'Y'", sqlconn))
        dadbe.Fill(dsete, "barang")
        GC.DataSource = dsete.Tables("barang")
    End Sub

    Private Sub GV_ShownEditor(ByVal sender As Object, ByVal e As System.EventArgs) Handles GV.ShownEditor
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView
        view = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        On Error Resume Next
        If view.FocusedColumn Is TIPE Then
            Dim edit As DevExpress.XtraEditors.LookUpEdit
            Dim table As DataTable
            Dim row As DataRow

            edit = CType(view.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)

            table = CType(edit.Properties.DataSource, DataTable)
            clone = New DataView(table)
            row = view.GetDataRow(view.FocusedRowHandle)
            clone.RowFilter = "Kode_Merk = '" + row("kd_merk").ToString() + "'"
            edit.Properties.DataSource = clone
        ElseIf view.FocusedColumn Is subtipe Then
            Dim edit As DevExpress.XtraEditors.LookUpEdit
            Dim table As DataTable
            Dim row As DataRow

            edit = CType(view.ActiveEditor, DevExpress.XtraEditors.LookUpEdit)

            table = CType(edit.Properties.DataSource, DataTable)
            clone = New DataView(table)
            row = view.GetDataRow(view.FocusedRowHandle)
            clone.RowFilter = "Kd_Tipe = '" + row("kd_tipe").ToString() + "'"
            edit.Properties.DataSource = clone
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GC.ShowPrintPreview()

    End Sub

    Private Sub ckBom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ckBom.CheckedChanged

        If ckBom.Checked = True Then

            CheckEdit1.Checked = False
            dsete.Tables("barang").Clear()
            dadbe = New SqlDataAdapter(New SqlCommand("select * from sif_barang WHERE isnull(rec_stat,'') = 'Y' and exists (select 1 from sif.dbo.sif_bom where kd_bom=kode_barang )", sqlconn))
        Else
            dsete.Tables("barang").Clear()
            dadbe = New SqlDataAdapter(New SqlCommand("select * from sif_barang WHERE isnull(rec_stat,'') = 'Y'", sqlconn))
        End If
        dadbe.Fill(dsete, "barang")

    End Sub

    Public Sub save_click()
        Dim BTRANS As SqlTransaction

        Try

            Dim myBuilder As SqlClient.SqlCommandBuilder
            myBuilder = New SqlClient.SqlCommandBuilder(dadbe)
            myBuilder.ConflictOption = ConflictOption.OverwriteChanges
            dadbe.UpdateCommand = myBuilder.GetUpdateCommand()
            dadbe.InsertCommand = myBuilder.GetInsertCommand()
            dadbe.DeleteCommand = myBuilder.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")

            dadbe.UpdateCommand.Transaction = BTRANS
            dadbe.InsertCommand.Transaction = BTRANS
            dadbe.DeleteCommand.Transaction = BTRANS


            dadbe.Update(dsete.Tables("barang"))
            BTRANS.Commit()
            showMessages("Transaksi Telah Diproses")
        Catch ex As Exception
            If Not BTRANS Is Nothing Then BTRANS.Rollback()
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    Private Sub CheckEdit1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckEdit1.CheckedChanged

        If CheckEdit1.Checked = True Then
            ckBom.Checked = False
            dsete.Tables("barang").Clear()
            dadbe = New SqlDataAdapter(New SqlCommand("select * from sif_barang WHERE isnull(rec_stat,'') = 'Y' and kode_barang not in (Select distinct m.kd_bom from SIF.dbo.SIF_bom_s m where m.rec_stat = 'Y' )", sqlconn))
        Else
            dsete.Tables("barang").Clear()
            dadbe = New SqlDataAdapter(New SqlCommand("select * from sif_barang WHERE isnull(rec_stat,'') = 'Y'", sqlconn))
        End If
        dadbe.Fill(dsete, "barang")
    End Sub
End Class
