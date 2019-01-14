'|-----------------------
'|  CREATED BY RENDY    |
'|  EDITED BY RENDY     |
'|-----------------------
Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Public Class frmReportHutangUsaha
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim err As String = ""
    Dim isvalid As Boolean

    Dim kSp As String
    Dim kNoInv As String

    Dim VarTahun As String
    Dim VarBulan As String

    Dim dsThn, dsBln, dsRekap, dsDetUt, dsLunas, dsValuta, dsSupp, dsLookUp As New DataSet
    Dim daThn, daBln, daRekap, daDetUt, daLunas, daValuta, daSupp, daLookUp As SqlDataAdapter

    Private Sub frmReportHutangUsaha_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
       
        loadLookUP()
        Me.Enabled = True
     
    End Sub

    Sub loadLookUP()
        dsValuta.Clear()
        daValuta = New SqlDataAdapter(New SqlCommand("select Kode_Valuta, Nama_Valuta from SIF.dbo.SIF_Valuta", sqlconn))
        daValuta.Fill(dsValuta, "Valuta")
        Valuta.Properties.DataSource = dsValuta.Tables("Valuta")
        Valuta.Properties.DisplayMember = "Nama_Valuta"
        Valuta.Properties.ValueMember = "Kode_Valuta"

        dsSupp.Clear()
        daSupp = New SqlDataAdapter(New SqlCommand("select Nama_Supplier,Kode_Supplier from SIF.dbo.SIF_Supplier", sqlconn))
        daSupp.Fill(dsSupp, "Supplier")
        Supplier.Properties.DataSource = dsSupp.Tables("Supplier")
        Supplier.Properties.DisplayMember = "Nama_Supplier"
        Supplier.Properties.ValueMember = "Kode_Supplier"

        If Not dsLookUp.Tables("LookPeriode") Is Nothing Then dsLookUp.Tables("LookPeriode").Clear()
        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS 'thnbln', nama_bulan + ' ' + thn_buku as 'nama' FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        daLookUp.Fill(dsLookUp, "LookPeriode")
        lookupBulanAwal.Properties.DataSource = dsLookUp.Tables("LookPeriode")
        lookupBulanAwal.Properties.DisplayMember = "nama"
        lookupBulanAwal.Properties.ValueMember = "thnbln"
    End Sub

    Sub bersih()
        Supplier.EditValue = vbNullString
        Valuta.EditValue = vbNullString

    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        bersih()
    End Sub

    Sub CetakLaporan(Optional ByVal Supp As String = "", Optional ByVal Vall As String = "", Optional ByVal thnbln As String = "", Optional ByVal Boll As Boolean = False)
        ErrorProvider1.Clear()

        ErrorProvider1.Clear()
        'IF PRIMER
        If CERekapHutang.Checked = False And CEDetailHutang.Checked = False And CEKartuHutang.Checked = False And CEAgingHutang.Checked = False Then
            ErrorProvider1.SetError(CERekapHutang, "Pilih Salah Satu")
            ErrorProvider1.SetError(CEDetailHutang, "Pilih Salah Satu")
            ErrorProvider1.SetError(CEKartuHutang, "Pilih Salah Satu")
            ErrorProvider1.SetError(CEAgingHutang, "Pilih Salah Satu")
        Else

            'IF REKAP
            If CERekapHutang.Checked = True Then
                If CEAgingHutang.Checked = True Then
                    callReport(App_Path() & "\report\CRRekapAgingHutangUsaha.rpt", "", "", Boll)
                End If
                If CEKartuHutang.Checked = True Then
                    callReport(App_Path() & "\report\repKartuRekapHutangCommAlt.rpt", "", "&periode=" & lookupBulanAwal.EditValue & "&val=" & Valuta.EditValue, Boll)
                End If
            End If

            'IF DETAIL
            If CEDetailHutang.Checked = True Then

                'IF KARTU DETAIL
                If CEKartuHutang.Checked = True Then

                    If Valuta.EditValue = vbNullString Then
                        ErrorProvider1.SetError(Valuta, "Valuta Tidak Boleh Kosong")
                    Else
                        If Supplier.EditValue = vbNullString Then
                            Try
                                callReport(App_Path() & "\report\CRHutPiutUsDetailALL.rpt", "", "&valuta=" & Vall & "&thnbln=" & thnbln, Boll)
                            Catch ex As Exception
                                lblError.Text = ex.Message
                            End Try
                        Else
                            If lookupBulanAwal.EditValue = vbNullString Then
                                ErrorProvider1.SetError(lookupBulanAwal, "Tahun Bulan Tidak Boleh Kosong")
                            Else
                                Try
                                    callReport(App_Path() & "\report\CRHutPiutUsDetail.rpt", "", "&thnbln=" & thnbln & "&valuta=" & Vall & "&supplier=" & Supp, Boll)
                                Catch ex As Exception
                                    lblError.Text = ex.Message
                                End Try
                            End If
                        End If
                    End If
                End If


                'IF AGING DETAIL
                If CEAgingHutang.Checked = True Then

                    'IF VALUTA CEK
                    If Valuta.EditValue = vbNullString Then
                        ErrorProvider1.SetError(Valuta, "Valuta Tidak Boleh Kosong")
                    Else

                        'IF AGING DETAIL NOTA
                        If CEAgingHutangNota.Checked = True Then

                            If Valuta.EditValue <> vbNullString And Supplier.EditValue = vbNullString And lookupBulanAwal.EditValue = vbNullString Then
                                Try
                                    callReport(App_Path() & "\report\CRRekapAgingHutangUsaha.rpt", "", "&valuta=" & Vall, Boll)
                                Catch ex As Exception
                                    lblError.Text = ex.Message
                                End Try
                            Else
                                If Supplier.EditValue = vbNullString Then
                                    ErrorProvider1.SetError(Supplier, "Supplier Tidak Boleh Kosong")
                                ElseIf lookupBulanAwal.EditValue = vbNullString Then
                                    ErrorProvider1.SetError(lookupBulanAwal, "Tahun Bulan Tidak Boleh Kosong")
                                Else
                                    Try
                                        callReport(App_Path() & "\report\CRAgingHutPiutUsDetailNota.rpt", "", "&supplier=" & Supp & "&valuta=" & Vall & "&thnbln=" & thnbln, Boll)
                                    Catch ex As Exception
                                        lblError.Text = ex.Message
                                    End Try
                                End If
                            End If
                        End If


                        'IF AGING DETAIL JATUH TEMPO
                        If CEAgingHutangJthTempo.Checked = True Then

                            If Valuta.EditValue <> vbNullString And Supplier.EditValue = vbNullString And lookupBulanAwal.EditValue = vbNullString Then
                                Try
                                    callReport(App_Path() & "\report\CRAgingHutPiutUsAllJthTempo.rpt", "", "&valuta=" & Vall, Boll)
                                Catch ex As Exception
                                    lblError.Text = ex.Message
                                End Try
                            Else
                                If Supplier.EditValue = vbNullString Then
                                    ErrorProvider1.SetError(Supplier, "Supplier Tidak Boleh Kosong")
                                ElseIf lookupBulanAwal.EditValue = vbNullString Then
                                    ErrorProvider1.SetError(lookupBulanAwal, "Tahun Bulan Tidak Boleh Kosong")
                                Else
                                    Try
                                        callReport(App_Path() & "\report\CRAgingHutPiutUsDetailJthTempo.rpt", "", "&supplier=" & Supp & "&valuta=" & Vall & "&thnbln=" & thnbln, Boll)
                                    Catch ex As Exception
                                        lblError.Text = ex.Message
                                    End Try
                                End If
                            End If
                        End If


                        'END IF VALUTA CEK
                    End If
                    'END IF AGING DETAIL 
                End If
                'END IF DETAIL
            End If
            'END IF PRIMER 
        End If

    End Sub


    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        CetakLaporan(Supplier.EditValue, Valuta.EditValue, VarTahun & VarBulan, "true")
    End Sub

    Private Sub CERekapHutang_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CERekapHutang.CheckedChanged
        If CERekapHutang.Checked = True Then
            CEDetailHutang.Checked = False
        Else
            CEDetailHutang.Checked = True
        End If
    End Sub

    Private Sub CEDetailHutang_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEDetailHutang.CheckedChanged
        If CEDetailHutang.Checked = True Then
            CERekapHutang.Checked = False
        Else
            CERekapHutang.Checked = True
        End If
    End Sub

    Private Sub cmdExe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExe.Click
        CetakLaporan(Supplier.EditValue, Valuta.EditValue, VarTahun & VarBulan, False)
    End Sub

    Private Sub CEKartuHutang_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEKartuHutang.CheckedChanged
        If CEKartuHutang.Checked = True Then
            CEAgingHutang.Checked = False

            CEAgingHutangNota.Enabled = False
            CEAgingHutangJthTempo.Enabled = False
        Else
            CEAgingHutang.Checked = True

            CEAgingHutangNota.Enabled = True
            CEAgingHutangJthTempo.Enabled = True
        End If
    End Sub

    Private Sub CEAgingHutang_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEAgingHutang.CheckedChanged
        If CEAgingHutang.Checked = True Then
            CEKartuHutang.Checked = False

            CEAgingHutangNota.Enabled = True
            CEAgingHutangJthTempo.Enabled = True
        Else
            CEKartuHutang.Checked = True

            CEAgingHutangNota.Enabled = False
            CEAgingHutangJthTempo.Enabled = False
        End If
    End Sub

    Private Sub lookupBulanAwal_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lookupBulanAwal.EditValueChanged
        VarTahun = Microsoft.VisualBasic.Left(lookupBulanAwal.EditValue, 4)
        VarBulan = Microsoft.VisualBasic.Right(lookupBulanAwal.EditValue, 2)
    End Sub

    Private Sub CEAgingHutangNota_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEAgingHutangNota.CheckedChanged
        If CEAgingHutangNota.Checked = True Then
            CEAgingHutangJthTempo.Checked = False
        Else
            CEAgingHutangJthTempo.Checked = True
        End If
    End Sub

    Private Sub CEAgingHutangJthTempo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CEAgingHutangJthTempo.CheckedChanged
        If CEAgingHutangJthTempo.Checked = True Then
            CEAgingHutangNota.Checked = False
        Else
            CEAgingHutangNota.Checked = True
        End If
    End Sub
End Class