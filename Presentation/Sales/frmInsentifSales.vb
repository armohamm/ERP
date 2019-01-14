Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmInsentifSales
    Dim dsete As New DataSet
    Dim DA As SqlDataAdapter
    Dim prn As frmMain
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Private Sub frmInsentifSales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sales.dbo.SALES_INSENTIF_SALES where 1=0", sqlconn))
        DA.Fill(dsete, "SALES_INSENTIF_SALES")
        gc.DataSource = dsete.Tables("SALES_INSENTIF_SALES")

        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.sif_sales ", sqlconn))
        DA.Fill(dsete, "SALES")
        repSales.DataSource = dsete.Tables("SALES")
        prn = frmMain
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
        setStatus()
        gv.CardCaptionFormat = "Insentif Sales Bulan : {4}"
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        If txtTahun.Text = "" Then
            showMessages("Periode Belum Diisi", "WARNING")
            txtTahun.Focus()
            Exit Sub
        End If
        Dim dr As SqlDataReader = New SqlCommand("select * from sif.dbo.sif_sales", sqlconn).ExecuteReader
        Dim rw As DataRow
        dsete.Tables("SALES_INSENTIF_SALES").Clear()
        While dr.Read
            rw = dsete.Tables("SALES_INSENTIF_SALES").NewRow
            rw("bulan") = Microsoft.VisualBasic.Right("0" & txtTahun.DateTime.Month, 2)
            rw("tahun") = txtTahun.DateTime.Year
            rw("Kd_Cabang") = kdcabang
            rw("kd_sales") = dr("Kode_Sales")
            Dim dr2 As SqlDataReader = New SqlCommand("select isnull(sum(target),0) from sales.dbo.SALES_TARGET_SALES where kd_sales='" & dr("Kode_Sales") & "' and thn_buku='" & rw("tahun") & "' and bln_buku='" & rw("bulan") & "'", sqlconn).ExecuteReader
            dr2.Read()
            rw("Target") = dr2(0)
           
            dr2.Close()
            dr2 = New SqlCommand(" select isnull(sum(nota.jml_rp_trans),0) from sales.dbo.sales_so so, fin.dbo.fin_nota_d nota, fin.dbo.fin_nota notam  where nota.no_inv=notam.no_inv and  nota.no_sp = so.no_sp and  so.kd_sales='" & dr("Kode_Sales") & "' and substring(convert(varchar,notam.tgl_posting,112),1,6) = '" & rw("tahun").ToString & rw("bulan").ToString & "'", sqlconn).ExecuteReader
            dr2.Read()
            rw("Omzet") = dr2(0)

            dr2.Close()
            If rw("Target") > 0 Then
                If rw("Omzet") > rw("Target") Then
                    rw("Point_utama1") = 100
                Else
                    rw("Point_utama1") = Math.Round(rw("Omzet") / rw("Target") * 100)
                End If
                If rw("Point_utama1") = "100" Then
                    rw("Point_tambah1") = Math.Round(rw("Omzet") / rw("Target") * 100 - 100)

                Else
                    rw("Point_tambah1") = 0
                End If
                Dim s As Int16 = rw("Point_utama1")

                dr2 = New SqlCommand("select TOP 1 Hasil from SIF.dbo.SIF_INSENTIF_SALES WHERE Pencapaian >= " & s & " order by Pencapaian asc", sqlconn).ExecuteReader
                dr2.Read()
                rw("Nilai_point_utama") = Math.Round(dr2(0))
                dr2.Close()
                s = (rw("Point_utama1") + rw("Point_tambah1"))
                If rw("Point_tambah1") > 0 Then
                    dr2 = New SqlCommand("select TOP 1 Hasil, kelipatan from SIF.dbo.SIF_INSENTIF_SALES WHERE Pencapaian >= " & s & " order by Pencapaian asc", sqlconn).ExecuteReader
                    dr2.Read()
                    rw("Nilai_point_tambahan") = Math.Round(rw("Point_tambah1") / 100 * dr2(0) * dr2(1))
                    dr2.Close()
                Else
                    rw("Nilai_point_tambahan") = 0
                End If
                rw("Perolehan") = rw("Nilai_point_utama") + rw("Nilai_point_tambahan")

                dr2 = New SqlCommand("select isnull(count(no_sp),0) from fin.dbo.v_agging_baru where (u30 > 0 or u120 > 0) and  no_sp in (select no_sp from sales.dbo.sales_so where kd_sales='" & dr("Kode_Sales") & "')", sqlconn).ExecuteReader
                dr2.Read()
                Dim temp As Double = dr.Item(0)
                Dim indeks1 As Double = 1
                Dim indeks2 As Double = 1
                dr2.Close()

                dr2 = New SqlCommand("select min(indeks) from sif.dbo.sif_index_piutang where jml_pelanggan >= " & temp & " ", sqlconn).ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    indeks1 = dr(0)
                End If
                dr2.Close()

                dr2 = New SqlCommand("select isnull(sum(u120),0) from fin.dbo.v_agging_baru where (u30 > 0 or u120 > 0) and no_sp in (select no_sp from sales.dbo.sales_so where kd_sales='" & dr("Kode_Sales") & "')", sqlconn).ExecuteReader
                dr2.Read()
                temp = dr.Item(0)
                dr2.Close()

                dr2 = New SqlCommand("select min(indeks) from sif.dbo.sif_index_piutang where jml_piutang >= " & temp & " ", sqlconn).ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    indeks2 = dr(0)
                End If
                dr2.Close()
                
                rw("Index") = If(indeks1 > indeks2, indeks2, indeks1)
                rw("Perolehan_Akhir") = Math.Round(rw("Perolehan") * rw("Index"))
            Else
                rw("Point_utama1") = 0
                rw("Point_tambah1") = 0
                rw("Nilai_point_utama") = 0
                rw("Nilai_point_tambahan") = 0
                rw("Index") = 0
                rw("Perolehan") = 0
                rw("Perolehan_Akhir") = 0
            End If
            dsete.Tables("SALES_INSENTIF_SALES").Rows.Add(rw)
        End While
        dr.Close()
        btnSave = True
        setStatus()
    End Sub
    Public Sub save_click()
        Dim rw As DataRow
        Dim btrans As SqlTransaction
        Dim myBuilder As New SqlClient.SqlCommandBuilder
        For Each rw In dsete.Tables("SALES_INSENTIF_SALES").Rows

            rw("Kd_Cabang") = kdcabang
            rw("last_create_date") = getTanggal()
            rw("last_created_by") = username
            rw("program_name") = Me.Name
            
        Next

        myBuilder = New SqlClient.SqlCommandBuilder(DA)
        DA.UpdateCommand = myBuilder.GetUpdateCommand()
        DA.InsertCommand = myBuilder.GetInsertCommand()
        DA.DeleteCommand = myBuilder.GetDeleteCommand() '<- untuk mengenerate command insert, update, delete. hanya untuk table yang sederhana
        Try
            btrans = sqlconn.BeginTransaction

            DA.UpdateCommand.Transaction = btrans
            DA.InsertCommand.Transaction = btrans
            DA.DeleteCommand.Transaction = btrans

            DA.Update(dsete.Tables("SALES_INSENTIF_SALES"))

            showMessages("Data Telah Disimpan")
            btrans.Commit()
        Catch e As Exception
            btrans.Rollback()
            MsgBox(e.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Sub add_click()

    End Sub
    Public Sub cetak_click()
        gc.ShowPrintPreview()
    End Sub

    Private Sub txtTahun_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTahun.EditValueChanged
        If Not dsete.Tables("SALES_INSENTIF_SALES") Is Nothing Then dsete.Tables("SALES_INSENTIF_SALES").Clear()
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sales.dbo.SALES_INSENTIF_SALES where tahun='" & txtTahun.DateTime.Year & "' and bulan='" & Microsoft.VisualBasic.Right("0" & txtTahun.DateTime.Month, 2) & "'", sqlconn))
        DA.Fill(dsete, "SALES_INSENTIF_SALES")
    End Sub
End Class