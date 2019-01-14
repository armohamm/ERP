Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports System.Drawing
Imports DevExpress.XtraPrinting

Public Class aFormMonNeracaSaldo
    Public btnSave As Boolean = False
    Public btnadd As Boolean = False
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = False
    Public prn As frmMain
    Dim dsNeracaSaldo As New DataSet
    Dim daNeracaSaldo, daLookUp As SqlDataAdapter
    Dim thn As String
    Dim bln As String
    Dim rek As String

    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnadd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Private Sub aFormMonNeracaSaldo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        connect()
        prn = getParent(Me)

        loadLookUp()
        Me.Enabled = True
        lckRek.EditValue = "0000000"
    End Sub

    Private Sub loadLookUp()
        If Not dsNeracaSaldo.Tables("BukuBesar") Is Nothing Then dsNeracaSaldo.Tables("BukuBesar").Clear()
        If Not dsNeracaSaldo.Tables("Kartu") Is Nothing Then dsNeracaSaldo.Tables("Kartu").Clear()
        If Not dsNeracaSaldo.Tables("Periode") Is Nothing Then dsNeracaSaldo.Tables("Periode").Clear()

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT DISTINCT kd_buku_besar, nm_buku_besar FROM SIF.dbo.SIF_buku_besar WHERE grup_header = 'D' UNION SELECT '0000000', '[Semua Rekening]'", sqlconn))
        daLookUp.Fill(dsNeracaSaldo, "Rekening")
        lckRek.Properties.DataSource = dsNeracaSaldo.Tables("Rekening")
        lckRek.Properties.DisplayMember = "nm_buku_besar"
        lckRek.Properties.ValueMember = "kd_buku_besar"
        lookRek.DataSource = dsNeracaSaldo.Tables("Rekening")
        lookRek.DisplayMember = "nm_buku_besar"
        lookRek.ValueMember = "kd_buku_besar"

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT kode, nama FROM FIN.dbo.v_kartu", sqlconn))
        daLookUp.Fill(dsNeracaSaldo, "Kartu")
        lookKartu.DataSource = dsNeracaSaldo.Tables("Kartu")
        lookKartu.DisplayMember = "nama"
        lookKartu.ValueMember = "kode"

        daLookUp = New SqlDataAdapter(New SqlCommand("SELECT thn_buku + bln_buku AS periode, nama_bulan + ' ' + thn_buku AS nama FROM SIF.dbo.SIF_Periode_Buku", sqlconn))
        daLookUp.Fill(dsNeracaSaldo, "Periode")
        lckPeriode.Properties.DataSource = dsNeracaSaldo.Tables("Periode")
        lckPeriode.Properties.DisplayMember = "nama"
        lckPeriode.Properties.ValueMember = "periode"
    End Sub

    Sub LoadAllData()
        If Not dsNeracaSaldo.Tables("NeracaSaldo") Is Nothing Then dsNeracaSaldo.Tables("NeracaSaldo").Clear()
        thn = Microsoft.VisualBasic.Left(lckPeriode.EditValue, 4).ToString
        bln = Microsoft.VisualBasic.Right(lckPeriode.EditValue, 2).ToString

        If Not lckRek.EditValue = "0000000" Then
            daNeracaSaldo = New SqlDataAdapter(New SqlCommand("SELECT ROW_NUMBER() OVER (ORDER BY a.kd_buku_besar) AS 'nomer', a.kd_buku_besar, a.kartu, (" & _
                                                                            "SELECT ISNULL(SUM(x.jml_val_debet - x.jml_val_kredit), 0) " & _
                                                                            "FROM FIN.dbo.FIN_NERACA_SALDO x " & _
                                                                   "WHERE x.thn_buku = '" & thn & "' AND x.bln_buku >= '00' AND x.bln_buku < '" & bln & "' " & _
                                                                         "AND x.kd_buku_besar LIKE '" & lckRek.EditValue & "' " & _
                                                                            "AND x.kartu= a.kartu" & _
                                                                       ") AS 'awal'," & _
                                                                       "ISNULL(SUM(a.jml_val_debet),0) AS 'debet'," & _
                                                                       "ISNULL(SUM(a.jml_val_kredit),0) AS 'kredit'," & _
                                                                       "ISNULL((" & _
                                                                         "SELECT ISNULL(SUM(x.jml_val_debet - x.jml_val_kredit), 0) " & _
                                                                            "FROM FIN.dbo.FIN_NERACA_SALDO x " & _
                                                                   "WHERE x.thn_buku = '" & thn & "' AND x.bln_buku >= '00' AND x.bln_buku < '" & bln & "' " & _
                                                                         "AND x.kd_buku_besar LIKE '" & lckRek.EditValue & "' " & _
                                                                            "AND x.kartu= a.kartu" & _
                                                                       ") + SUM(a.jml_val_debet-a.jml_val_kredit)" & _
                                                                       ",0) AS 'akhir' " & _
                                                               "FROM FIN.dbo.FIN_NERACA_SALDO a " & _
                                                                "WHERE NOT (a.kartu = 'S00000' OR a.kartu IS NULL OR a.kartu = '' OR a.kartu = 'CST000000' OR a.kartu = 'P00001' OR a.kartu LIKE '0%') " & _
                                                                "AND a.kd_buku_besar LIKE '" & lckRek.EditValue & "' " & _
                                                                "GROUP BY a.kd_buku_besar, a.kartu", sqlconn))
        Else
            daNeracaSaldo = New SqlDataAdapter(New SqlCommand("SELECT ROW_NUMBER() OVER (ORDER BY a.kd_buku_besar) AS 'nomer', a.kd_buku_besar, a.kartu, (" & _
                                                                            "SELECT ISNULL(SUM(x.jml_val_debet - x.jml_val_kredit), 0) " & _
                                                                            "FROM FIN.dbo.FIN_NERACA_SALDO x " & _
                                                                   "WHERE x.thn_buku = '" & thn & "' AND x.bln_buku >= '00' AND x.bln_buku < '" & bln & "' " & _
                                                                         "AND x.kd_buku_besar LIKE '%' " & _
                                                                            "AND x.kartu= a.kartu" & _
                                                                       ") AS 'awal'," & _
                                                                       "ISNULL(SUM(a.jml_val_debet),0) AS 'debet'," & _
                                                                       "ISNULL(SUM(a.jml_val_kredit),0) AS 'kredit'," & _
                                                                       "ISNULL((" & _
                                                                         "SELECT ISNULL(SUM(x.jml_val_debet - x.jml_val_kredit), 0) " & _
                                                                            "FROM FIN.dbo.FIN_NERACA_SALDO x " & _
                                                                   "WHERE x.thn_buku = '" & thn & "' AND x.bln_buku >= '00' AND x.bln_buku < '" & bln & "' " & _
                                                                         "AND x.kd_buku_besar LIKE '%' " & _
                                                                            "AND x.kartu= a.kartu" & _
                                                                       ") + SUM(a.jml_val_debet-a.jml_val_kredit)" & _
                                                                       ",0) AS 'akhir' " & _
                                                               "FROM FIN.dbo.FIN_NERACA_SALDO a " & _
                                                                "WHERE NOT (a.kartu = 'S00000' OR a.kartu IS NULL OR a.kartu = '' OR a.kartu = 'CST000000' OR a.kartu = 'P00001' OR a.kartu LIKE '0%') " & _
                                                                "AND a.kd_buku_besar LIKE '%' " & _
                                                                "GROUP BY a.kd_buku_besar, a.kartu", sqlconn))
        End If
        daNeracaSaldo.Fill(dsNeracaSaldo, "NeracaSaldo")
        gcNeracaSaldo.DataSource = dsNeracaSaldo.Tables("NeracaSaldo")
        gvNeracaSaldo.BestFitColumns()
    End Sub

    Public Sub cetak_click()
        MsgBox("Tidak ada fungsi cetak untuk Form ini.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "CATATAN!")
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        If lckPeriode.EditValue = vbNullString Then
            MsgBox("Periode belum dipilih.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "PERINGATAN!")
        Else
            LoadAllData()
        End If
    End Sub
End Class