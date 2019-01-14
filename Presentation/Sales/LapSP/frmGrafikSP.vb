Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data
Imports System.Windows.Forms
Public Class frmGrafikSP
    Dim dsete As New DataSet
    Dim DA As SqlDataAdapter
    Private Sub frmGrafikSP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'connect()

        'Dim sql As String
        
        'txtFilter.Checked = False
        'DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT    RIGHT(CONVERT(VARCHAR(10), Tgl_sp, 103), 7) AS TGL, sum(Qty) qty , Nama_Barang " & _
        '" FROM sales.dbo.SALES_SO m, sales.dbo.SALES_SO_D d , SIF.dbo.SIF_Barang" & _
        '" where(m.No_sp = D.No_sp And Kd_Stok = Kode_Barang)" & _
        '" group by RIGHT(CONVERT(VARCHAR(10), Tgl_sp, 103), 7) , Nama_Barang" & _
        '" order by RIGHT(CONVERT(VARCHAR(10), Tgl_sp, 103), 7)", sqlconn))
        'DA.Fill(dsete, "0")
        dsete.Tables.Add("0")

        dsete.Tables(0).Columns.Add("divisi")
        dsete.Tables(0).Columns.Add("bulan")
        dsete.Tables(0).Columns.Add("nilai", System.Type.GetType("System.Int16"))
        Dim rw As DataRow

        rw = dsete.Tables(0).NewRow
        rw(0) = "spring"
        rw(1) = "januari"
        rw(2) = "10"
        dsete.Tables(0).Rows.Add(rw)

        rw = dsete.Tables(0).NewRow
        rw(0) = "spon"
        rw(1) = "januari"
        rw(2) = "30"
        dsete.Tables(0).Rows.Add(rw)

        rw = dsete.Tables(0).NewRow
        rw(0) = "spring"
        rw(1) = "februari"
        rw(2) = "30"

        dsete.Tables(0).Rows.Add(rw)
        rw = dsete.Tables(0).NewRow
        rw(0) = "spon"
        rw(1) = "februari"
        rw(2) = "20"
        dsete.Tables(0).Rows.Add(rw)

        CC.Series.Clear()
        CC.DataSource = dsete.Tables("0")
        CC.SeriesDataMember = dsete.Tables("0").Columns("divisi").ToString
        CC.SeriesTemplate.ArgumentDataMember = dsete.Tables("0").Columns("bulan").ToString
        CC.SeriesTemplate.ValueDataMembers.AddRange(New String(dsete.Tables("0").Columns("nilai").ToString))

    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        Dim sql As String = ""
        Dim fprod As String = ""
        Dim periode As String = ""

        If Not dsete.Tables("PRO") Is Nothing Then dsete.Tables("PRO").Clear()
        dsete.Tables("PRO").Columns.Add()
        For Each item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In txtProduk.Properties.Items
            If item.CheckState = CheckState.Checked Then
                fprod = fprod & item.Value & ","
            End If
        Next



        If txtProduk.Text <> "" Then



            For Each item As DevExpress.XtraEditors.Controls.CheckedListBoxItem In txtProduk.Properties.Items
                If item.CheckState = CheckState.Checked Then
                    fprod = fprod & item.Value & ","
                End If
            Next
            If fprod <> "" Then fprod = "('" & Microsoft.VisualBasic.Left(fprod, Len(fprod) - 1) & "')"
            sql = " KD_SET in " & fprod
            Dim DR_PRO As SqlDataReader = New SqlCommand("SELECT * FROM SIF.DBO.SIF_SET_PRODUCT WHERE " & sql, sqlconn).ExecuteReader
            DA.Fill(dsete, "PRO")
        Else
            Dim DR_PRO As SqlDataReader = New SqlCommand("SELECT * FROM SIF.DBO.SIF_SET_PRODUCT", sqlconn).ExecuteReader
            DA.Fill(dsete, "PRO")
        End If

        If Not dsete.Tables("PER") Is Nothing Then dsete.Tables("PER").Clear()
        dsete.Tables("PER").Columns.Add(New DataColumn("TGL"))
        If txtPeriode.EditValue = "H" Then
            periode = ", sales.dbo.getRangeTgl('" & Format(Start_Date.EditValue, "yyyyMMdd") & "','" & Format(Start_Date.EditValue, "yyyyMMdd") & "') as TGLX"
            sql = sql & " "
        ElseIf txtPeriode.EditValue = "B" Then

        Else

        End If

        If txtTipe.EditValue = "1" Then
            sql = "SELECT    RIGHT(CONVERT(VARCHAR(10), Tgl_sp, 103), 7) AS TGL, sum(Qty) qty , NAMA as  Nama_Barang" & _
            " FROM sales.dbo.SALES_SO m, sales.dbo.SALES_SO_D d , SIF.dbo.SIF_SET_PRODUCT " & periode & _
            " where(m.No_sp = D.No_sp And Kd_Stok = KD_SET) " & sql & _
            " group by RIGHT(CONVERT(VARCHAR(10), Tgl_sp, 103), 7) , NAMA" & _
            " order by RIGHT(CONVERT(VARCHAR(10), Tgl_sp, 103), 7)"
        Else
            sql = "SELECT    RIGHT(CONVERT(VARCHAR(10), Tgl_sp, 103), 7) AS TGL, sum(Qty) qty , Nama_Barang " & _
            " FROM sales.dbo.SALES_SO m, sales.dbo.SALES_SO_D d , SIF.dbo.SIF_Barang" & _
            " where(m.No_sp = D.No_sp And Kd_Stok = Kode_Barang) " & sql & _
            " group by RIGHT(CONVERT(VARCHAR(10), Tgl_sp, 103), 7) , Nama_Barang" & _
            " order by RIGHT(CONVERT(VARCHAR(10), Tgl_sp, 103), 7)"
        End If
        DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(sql, sqlconn))
        CC.DataSource = Nothing
        dsete.Tables("0").Clear()
        DA.Fill(dsete, "0")
        CC.DataSource = dsete.Tables("0")
        CC.RefreshData()

    End Sub

    Private Sub txtFilter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFilter.CheckedChanged
        Dim sql As String = ""
        If txtTipe.Text = "" Then
            Sql = "SELECT Kode_Barang, Nama_Barang from sif.dbo.sif_barang where kd_jns_persd=1"
        Else
            Sql = "SELECT KD_SET, NAMA from sif.dbo.SIF_SET_PRODUCT"
        End If
        If txtFilter.Checked Then
            DA = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(Sql, sqlconn))
            DA.Fill(dsete, "barang")

            For Each rw As DataRow In dsete.Tables("barang").Rows
                txtProduk.Properties.Items.Add(rw(0), rw(1).ToString)
            Next
        Else
            txtProduk.Properties.Items.Clear()
            txtProduk.Text = ""
        End If

    End Sub
End Class