Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Controls
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class frmMonPromo
    Dim dsete As New DataSet
    Dim dadbe As SqlDataAdapter
    Dim rhandle, rhandle2 As Int16
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
    Private Sub frmCustGetPromo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect() '
        reload_table()
        txtPromo.Properties.DataSource = dsete.Tables("promo")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select Kd_Customer, Nama_Customer from sif.dbo.sif_customer where rec_stat='Y'", sqlconn))
        dadbe.Fill(dsete, "cust")
        Dim rw As DataRow = dsete.Tables("cust").NewRow()
        Rw(0) = "%%"
        rw(1) = "All"
        dsete.Tables("cust").Rows.InsertAt(rw, 0)
        cmdCustomr.Properties.DataSource = dsete.Tables("cust")
        repCust.DataSource = dsete.Tables("cust")
        prn = frmMain
        setStatus()
        prn.btnAdd_Click(prn.btnAdd, New EventArgs)
    End Sub
    Private Sub reload_table()
        If Not dsete.Tables("promo") Is Nothing Then dsete.Tables("promo").Clear()
        If Not dsete.Tables("promod") Is Nothing Then dsete.Tables("promod").Clear()
        If Not dsete.Tables("cust_promo") Is Nothing Then dsete.Tables("cust_promo").Clear()

        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select * from sif.dbo.sif_promo where isClosed is null and tipe_promo='Y'", sqlconn))
        dadbe.Fill(dsete, "promo")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select * from sif.dbo.sif_promo_d where no_promo = 'xxxxxx' ", sqlconn))
        dadbe.Fill(dsete, "promod")
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(" select * from sales.[dbo].[CustGetPromo2]('X','X')  ", sqlconn))
        dadbe.Fill(dsete, "cust_promo")
        txtPromo.EditValue = Nothing
    End Sub
    Private Sub txtPromo_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPromo.EditValueChanged
        If txtPromo.EditValue Is Nothing Then
            txtKodePromo.Text = ""
            txtDari.Text = ""
            txtsampai.Text = ""
        Else
            txtKodePromo.Text = txtPromo.EditValue
            txtDari.Text = FormatDateTime(txtPromo.GetColumnValue("start_date"), DateFormat.LongDate)
            txtsampai.Text = FormatDateTime(txtPromo.GetColumnValue("end_date"), DateFormat.LongDate)
        End If
    End Sub
    Private Sub promo_Gabungan()
        If cmdCustomr.Text = "" Then
            cmdCustomr.EditValue = "%%"
        End If
        Dim x As New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        pnlLoad.Visible = True
        For i As Int16 = 1 To GVG.Bands.Count - 1
            For j As Int16 = 1 To GVG.Bands(1).Columns.Count
                GVG.Bands(1).Columns(0).Dispose()
            Next
            GVG.Bands(1).Dispose()
        Next i

        Dim dr As Data.SqlClient.SqlDataReader = New SqlCommand("select * from sif.dbo.sif_promo_d where no_promo = '" & txtKodePromo.Text & "'", sqlconn).ExecuteReader

        While dr.Read
            With GVG.Bands.Add()
                .Tag = dr("no_seq")
                .Caption = dr("promo_desc")
                .AppearanceHeader.Font = Customer.AppearanceHeader.Font
                .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                If dr("target_qty").ToString = "" Then
                    x = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
                    x.Tag = dr("no_seq")
                    x.Caption = "Omzet : " & FormatCurrency(dr("target_rp"), , TriState.True)
                    x.FieldName = dr("no_seq") & "-target_rp"
                    x.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    x.DisplayFormat.FormatString = "n2"
                    x.Visible = True
                    x.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    .Columns.Insert(0, x)
                Else
                    x = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
                    x.Caption = "Qty : " & dr("target_qty").ToString
                    x.FieldName = dr("no_seq") & "-target_qty"
                    x.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    x.DisplayFormat.FormatString = "n"
                    x.Visible = True
                    x.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    .Columns.Insert(0, x)
                End If
            End With
        End While
        pnlLoad.Refresh()
        dr.Close()

        If Not dsete.Tables("data") Is Nothing Then dsete.Tables.Remove("data")
        dsete.Tables.Add("data")
        For Each x In GVG.Columns
            Dim dc As DataColumn = dsete.Tables("data").Columns.Add(x.FieldName)
            If x.FieldName <> "kd_customer" Then
                dc.DataType = GetType(Double)
            End If
            pnlLoad.Refresh()
        Next
        Dim jml_row As Int16
        With New SqlCommand("select count(1) from sif.dbo.sif_customer where kd_customer like '" & cmdCustomr.EditValue.ToString & "' and Rec_Stat='Y'", sqlconn).ExecuteReader
            .Read()
            jml_row = .Item(0)
            .Close()
        End With
        Dim drc As SqlDataReader = New SqlCommand("select Kd_Customer from sif.dbo.sif_customer where kd_customer like '" & cmdCustomr.EditValue.ToString & "' and Rec_Stat='Y'", sqlconn).ExecuteReader
        Dim xx As Int16 = 0
        While drc.Read
            Dim drw As DataRow = dsete.Tables("data").NewRow()
            drw("kd_customer") = drc("Kd_Customer")
            For Each rw As DataColumn In dsete.Tables("data").Columns
                Dim m As Object = Split(rw.ColumnName, "-")
                If rw.ColumnName <> "kd_customer" Then
                    If m(1) = "target_rp" Then
                        dr = New SqlCommand("select sales.dbo.pencapaianPromoGabunganMoney('" & drw("kd_customer") & "', '" & txtKodePromo.Text & "', '" & m(0) & "')", sqlconn).ExecuteReader
                    Else
                        dr = New SqlCommand("select sales.dbo.pencapaianPromoGabunganQTY('" & drw("kd_customer") & "', '" & txtKodePromo.Text & "', '" & m(0) & "')", sqlconn).ExecuteReader
                    End If
                    dr.Read()
                    If dr.HasRows Then
                        drw(rw.ColumnName) = dr(0)
                    Else
                        drw(rw.ColumnName) = 0
                    End If

                    dr.Close()
                End If
            Next
            dsete.Tables("data").Rows.Add(drw)
            xx += 1
            Label4.Text = "Please Wait " & xx.ToString & " / " & jml_row.ToString
            pnlLoad.Refresh()

        End While
        drc.Close()
        GC.DataSource = dsete.Tables("data")
        GVG.BestFitColumns()
    End Sub
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        If txtKodePromo.Text = "" Then
            showMessages("Harap Mengisi Promo", dialog:="WARNING")
            txtPromo.Focus()
            Exit Sub
        End If
        If cmdCustomr.Text = "" Then
            cmdCustomr.EditValue = "%%"
        End If
        If txtPromo.Properties.GetDataSourceValue("Jenis_Omzet", txtPromo.ItemIndex).ToString() = "Gabungan" Then
            GC.MainView = GVG
            promo_Gabungan()
            pnlLoad.Visible = False
            Exit Sub
        End If
        GC.MainView = GV
        
        Dim x As New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        pnlLoad.Visible = True
        For i As Int16 = 1 To GV.Bands.Count - 1
            For j As Int16 = 1 To GV.Bands(1).Columns.Count
                GV.Bands(1).Columns(0).Dispose()
            Next
            GV.Bands(1).Dispose()
        Next i

        Dim dr As Data.SqlClient.SqlDataReader = New SqlCommand("select * from sif.dbo.sif_promo_d where no_promo = '" & txtKodePromo.Text & "'", sqlconn).ExecuteReader

        While dr.Read
            With GV.Bands.Add()
                .Tag = dr("no_seq")
                .Caption = dr("promo_desc")
                .AppearanceHeader.Font = Customer.AppearanceHeader.Font
                .AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                Dim drs As Data.SqlClient.SqlDataReader = New SqlCommand("select * from sif.dbo.SIF_Promo_Syarat where no_promo = '" & txtKodePromo.Text & "'", sqlconn).ExecuteReader
                While drs.Read
                    x = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

                    If IIf(drs("jml_rp").ToString = "", "0", drs("jml_rp").ToString) <> "0" Then
                        x.Caption = "Omzet Rp : " & FormatCurrency(drs("jml_rp").ToString, 2)
                        x.Tag = drs("jml_rp").ToString
                        x.FieldName = dr("no_promo").ToString & "-" & dr("no_seq").ToString & "-" & drs("seq_syarat").ToString & "-rp"
                    Else
                        x.Caption = "Jml Beli : " & drs("jml_beli").ToString
                        x.Tag = drs("jml_beli").ToString
                        x.FieldName = dr("no_promo").ToString & "-" & dr("no_seq").ToString & "-" & drs("seq_syarat").ToString
                    End If
                    x.ToolTip = getDesSyarat(drs("Jns_Barang"), drs("kd_merk"), drs("kd_tipe"), drs("Ukuran"))
                    'x.Caption = CType(x.Caption, Double).ToString("n")
                    x.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
                    x.DisplayFormat.FormatString = "n"
                    x.Visible = True
                    x.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    .Columns.Insert(0, x)
                End While
                drs.Close()
                pnlLoad.Refresh()
            End With
        End While
        dr.Close()

        If Not dsete.Tables("data") Is Nothing Then dsete.Tables.Remove("data")
        dsete.Tables.Add("data")
        For Each x In GV.Columns
            Dim dc As DataColumn = dsete.Tables("data").Columns.Add(x.FieldName)
            If x.FieldName <> "kd_customer" Then
                dc.DataType = GetType(Double)
            End If
            pnlLoad.Refresh()

        Next
        'dbo.pencapaianPromoCustomer(Kd_Customer, no_promo, seq_detail, seq_syarat)
        Dim drc As SqlDataReader = New SqlCommand("select Kd_Customer from sif.dbo.sif_customer where kd_customer like '" & cmdCustomr.EditValue.ToString & "' and Rec_Stat='Y'", sqlconn).ExecuteReader
        While drc.Read
            Dim drw As DataRow = dsete.Tables("data").NewRow()
            drw("kd_customer") = drc("Kd_Customer")
            For Each rw As DataColumn In dsete.Tables("data").Columns
                If rw.ColumnName <> "kd_customer" Then
                    Dim m As Object = Split(rw.ColumnName, "-")
                    If Microsoft.VisualBasic.Right(rw.ColumnName, 2) = "rp" Then
                        dr = New SqlCommand("select sales.dbo.pencapaianPromoCustomer('" & drw("kd_customer") & "', '" & txtKodePromo.Text & "', '" & m(1) & "', '" & m(2) & "')", sqlconn).ExecuteReader
                    Else
                        dr = New SqlCommand("select sales.dbo.pencapaianPromoCustomerQty('" & drw("kd_customer") & "', '" & txtKodePromo.Text & "', '" & m(1) & "', '" & m(2) & "')", sqlconn).ExecuteReader
                    End If
                    dr.Read()
                    If dr.HasRows Then
                        drw(rw.ColumnName) = dr(0)
                    Else
                        drw(rw.ColumnName) = 0
                    End If

                    dr.Close()
                End If
            Next
            dsete.Tables("data").Rows.Add(drw)
            pnlLoad.Refresh()

        End While
        drc.Close()
        GC.DataSource = dsete.Tables("data")
        pnlLoad.Visible = False
        'dsete.Tables("data").Columns.Add("tmp")

        'With GV.Bands.Add()
        '    x = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn
        '    x.FieldName = "tmp"
        '    x.Visible = False
        '    .Columns.Insert(0, x)
        'End With
        'For Each drx As DataRow In dsete.Tables("data").Rows

        '    drx("tmp") = 0
        'Next
        GV.BestFitColumns()
    End Sub
    Public Sub add_click()

    End Sub

    Private Sub frmMonPromo_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        pnlLoad.Top = Me.Height / 2
        pnlLoad.Left = (Me.Width - pnlLoad.Width) / 2
    End Sub

    Private Sub txtPromo_QueryPopUp(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtPromo.QueryPopUp
        reload_table()
    End Sub
    Private Function getDesSyarat(ByVal kd_jenis As String, ByVal kd_merk As String, ByVal kd_type As String, ByVal kd_ukuran As String) As String
        Dim Hasil As String
        Dim dr As SqlDataReader
        If Microsoft.VisualBasic.Left(kd_jenis, 1) = "_" Then
            Hasil = "Jenis Barang : <B>ALL</B>" & vbCrLf
        Else
            dr = New SqlCommand("select Nama_Jenis from sif.dbo.SIF_Jenis_Barang where kd_jns_brg='" & kd_jenis & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Hasil = "Jenis Barang : " & dr(0) & vbCrLf
            Else
                Hasil = "Jenis Barang : Not Found's" & vbCrLf
            End If
            dr.Close()
        End If
        If Microsoft.VisualBasic.Left(kd_merk, 1) = "_" Then
            Hasil &= "Merk : ALL" & vbCrLf
        Else
            dr = New SqlCommand("select Nama_Merk from sif.dbo.SIF_Merk where Kode_Merk='" & kd_merk & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Hasil &= "Merk : " & dr(0) & vbCrLf
            Else
                Hasil &= "Merk : Not Found's" & vbCrLf
            End If
            dr.Close()
        End If
        If Microsoft.VisualBasic.Left(kd_type, 1) = "_" Then
            Hasil &= "Type : ALL" & vbCrLf
        Else
            dr = New SqlCommand("select Nama_tipe from sif.dbo.SIF_tipe where Kode_tipe='" & kd_type & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Hasil &= "Type : " & dr(0) & vbCrLf
            Else
                Hasil &= "Type : Not Found's" & vbCrLf
            End If
            dr.Close()
        End If
        If Microsoft.VisualBasic.Left(kd_ukuran, 1) = "_" Then
            Hasil &= "Ukuran : ALL"
        Else
            dr = New SqlCommand("select Nama_Ukuran from sif.dbo.SIF_Ukuran where Kode_Ukuran='" & kd_ukuran & "'", sqlconn).ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Hasil &= "Ukuran : " & dr(0)
            Else
                Hasil &= "Ukuran : Not Found's"
            End If
            dr.Close()
        End If
        Return Hasil
    End Function

    'Private Sub GVG_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles GVG.CustomDrawCell
    'e.Graphics.
    'End Sub
End Class