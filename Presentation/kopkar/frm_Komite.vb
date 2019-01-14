Imports System.Data.SqlClient
Imports System.Globalization
Imports DevExpress.XtraPrintingLinks
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports System.Drawing
Imports DevExpress.Utils

Public Class frm_Komite
    Private thisThread As System.Threading.Thread = System.Threading.Thread.CurrentThread
    Private originalCulture As System.Globalization.CultureInfo = thisThread.CurrentCulture
    Public prn As frmMain
    Public btnSave As Boolean = False
    Public btnAdd As Boolean = True
    Public btnCancel As Boolean = False
    Public btnDelete As Boolean = False
    Public btnEdit As Boolean = True
    Public STATE As String = "ADD"

    Private CommandBuilder As New SqlClient.SqlCommandBuilder
    Private DALookup, DAKredit As SqlClient.SqlDataAdapter
    Private DSAll As New DataSet
    Private drow As DataRow
    
    Public Sub add_click()
        Dim sqlstr As String = "select k.nasabah_id as NIP, a.Nama, k.tgl_trans as Tanggal, k.no_trans as [No Trans] " & _
        ", m.Nama as Jenis, k.JML_PINJAMAN as Jumlah, k.LAMA_ANGS as Tenor " & _
        ", k.stat_kabagSP as [Status Kabag] " & _
        "FROM kredit k  " & _
        "left join anggota a ON k.nasabah_id = a.nasabah_id   " & _
        "left join m_jns_upload m ON m.kode = k.jenis " & _
        "where k.stat_approve < 5 order by k.tgl_trans desc"
        DALookup = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand(sqlstr, sqlconn))
        If Not DSAll.Tables("lookup_") Is Nothing Then DSAll.Tables("lookup_").Clear()
        DALookup.Fill(DSAll, "lookup_")
        frmCari.set_dso(DSAll.Tables("lookup_"))
        frmCari.ShowDialog()

        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            LoadStruktur(frmCari.row(3))
            STATE = "ADD" '<-- set state add
            btnAdd = False
            btnEdit = False
            btnCancel = True
            btnDelete = False
            btnSave = True
            setStatus()
            'bersihkan()
        Else
            cancel_click()
            STATE = ""
        End If


    End Sub
    Public Sub edit_click()
        STATE = "EDIT"
        DALookup = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select k.nasabah_id,k.no_trans,k.tgl_trans,a.Nama,k.jenis,k.JML_PINJAMAN,k.LAMA_ANGS,k.JML_ADMIN,k.JML_PROVISI,k.rec_penalty as penalti,k.stat_kabagSP,k.stat_approve,k.stat_cair,a.job_id from kredit k left join anggota a on k.nasabah_id=a.nasabah_id  where k.stat_approve < 5 and k.kd_kredit='REC' and k.Last_Created_By='" & username & "' order by k.tgl_trans desc", sqlconn))
        If Not DSAll.Tables("lookup_") Is Nothing Then DSAll.Tables("lookup_").Clear()
        DALookup.Fill(DSAll, "lookup_")
        frmCari.set_dso(DSAll.Tables("lookup_")) '<-- memparsing hasil dataset ke LOV
        frmCari.ShowDialog() '<-- menampilkan form LOV

        If Not frmCari.row Is Nothing Then '<-- jika row ada yg dipilih
            LoadStruktur(frmCari.row(1))
            btnAdd = False
            btnEdit = False
            btnSave = True
            btnCancel = True
            btnDelete = True
            setStatus()
        Else
            cancel_click()
            STATE = ""
        End If

    End Sub
    Public Sub cancel_click()
        btnSave = False
        btnCancel = False
        btnDelete = False
        btnEdit = False
        btnAdd = True
        setStatus()
        Me.Enabled = False
        bersihkan()

    End Sub
    Public Sub delete_click()
        'If MsgBox("Hapus Data ENTRY-an? Data entryan akan di batalkan dan di hapus?? ", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Hapus Data?") = MsgBoxResult.Yes Then

        '    'save_click(True)
        '    cancel_click()
        '    STATE = ""
        'End If
    End Sub
    Public Sub cetak_click()
        'callReport(App_Path() & "\report\komite.rpt", "", "n_trn=" & lb_notrans.Text, False, False)
        If te_no_trans.Text <> "" Then
            callReport(App_Path() & "\report\komite_test.rpt", "", "n_trn=" & te_no_trans.EditValue, False, False)
        Else
            MsgBox("No Transaksi Kosong", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub bersihkan()
        te_no_trans.EditValue = ""
        te_no_form.EditValue = ""
        te_tgl_trans.EditValue = ""

        te_nasabah_id.EditValue = ""
        te_nama.EditValue = ""
        te_jml_pinjaman.EditValue = ""
        te_lama_pinjaman.EditValue = ""
        te_angsuran_pokok.EditValue = ""
        te_angsuran_bunga.EditValue = ""
        te_angsuran_total.EditValue = ""
        me_note.Text = ""
        If Not DSAll.Tables("_hist") Is Nothing Then DSAll.Tables("_hist").Clear()
    End Sub
    Public Sub setStatus()
        With prn
            .btnAdd.Enabled = btnAdd
            .btnCancel.Enabled = btnCancel
            .btnDelete.Enabled = btnDelete
            .btnEdit.Enabled = btnEdit
            .btnSave.Enabled = btnSave
        End With
    End Sub

    Public Sub LoadStruktur(ByVal kode As String)
        If Not DSAll.Tables("_krd") Is Nothing Then DSAll.Tables("_krd").Clear()

        DAKredit = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  * from kredit where no_trans='" & kode & "'", sqlconn))
        DAKredit.Fill(DSAll, "_krd")
        If DSAll.Tables("_krd").Rows.Count > 0 Then
            Dim rwm As DataRow = DSAll.Tables("_krd").Rows(0)
            Dim sqlnas As SqlDataReader = New SqlCommand("SELECT * FROM anggota where nasabah_id='" & rwm.Item("nasabah_id") & "'", sqlconn).ExecuteReader
            sqlnas.Read()
            te_no_trans.EditValue = rwm.Item("no_trans")
            te_no_form.EditValue = rwm.Item("no_ref")
            te_tgl_trans.EditValue = Convert.ToDateTime(rwm.Item("tgl_trans")).ToString("dd/MM/yyyy")

            te_nasabah_id.EditValue = rwm.Item("nasabah_id")
            te_nama.EditValue = sqlnas.Item("Nama")
            te_jml_pinjaman.EditValue = rwm.Item("JML_PINJAMAN")
            te_lama_pinjaman.EditValue = rwm.Item("LAMA_ANGS")
            te_angsuran_pokok.EditValue = rwm.Item("JML_POKOK")
            te_angsuran_bunga.EditValue = rwm.Item("JML_BUNGA")
            te_angsuran_total.EditValue = rwm.Item("JML_ANGSURAN")

            If String.IsNullOrEmpty(rwm.Item("note_kabagSP").ToString()) Then
                Dim note As String
                note = "RECOVERY PINJAMAN DILUAR NORMATIF"
                note &= Environment.NewLine
                note &= " - Ybs "
                note &= Environment.NewLine
                note &= " - Ybs mengajukan recovery pinjaman di luar normatif " & Convert.ToDecimal(rwm.Item("JML_PINJAMAN")).ToString("c", New Globalization.CultureInfo("id-ID", False)) & _
                ", jangka waktu " & rwm.Item("LAMA_ANGS").ToString & " bulan, angsuran " & Convert.ToDecimal(rwm.Item("JML_ANGSURAN")).ToString("c", New Globalization.CultureInfo("id-ID", False)) & _
                "/bulan"
                me_note.Text = note
            Else
                me_note.Text = rwm.Item("note_kabagSP")
            End If

            DALookup = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select 0 as jml_pinjaman, 0 as lama_angs, * from kredit_rec where no_trans='" & kode & "'", sqlconn))
            DALookup.Fill(DSAll, "_hist")
            For Each rh As DataRow In DSAll.Tables("_hist").Rows
                Dim sqdr As SqlDataReader = New SqlCommand("SELECT * from kredit k where k.no_trans= '" & rh.Item("no_kredit").ToString() & "'", sqlconn).ExecuteReader
                If sqdr.HasRows Then
                    sqdr.Read()
                    rh.Item("jml_pinjaman") = sqdr.Item("JML_PINJAMAN")
                    rh.Item("lama_angs") = sqdr.Item("LAMA_ANGS")
                    sqdr.Close()
                End If

            Next
            GCHistory.DataSource = DSAll.Tables("_hist")

            sqlnas.Close()
        End If

    End Sub
    Public Sub save_click(Optional ByRef isDel As Boolean = False)
        If MsgBox("Data akan disimpan ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan(isDel)
    End Sub

    Private Sub formLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        LoadStruktur("xxx")
        btnEdit = False
        setStatus()

    End Sub

    Public Function get_notran() As String
        Dim prefiks, yymmdd, ntran_cek, nextnumber As String

        'prefiks = getKodeCabang() & le_jenis_kredit.Properties.GetDataSourceValue("kd2", le_jenis_kredit.ItemIndex).ToString() & blthn()
        Dim sqlblth As SqlDataReader = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),3,6)as blthn", sqlconn).ExecuteReader
        sqlblth.Read()
        yymmdd = sqlblth.Item(0)
        sqlblth.Close()
        prefiks = "R" & yymmdd
        Dim sqlr As SqlDataReader = New SqlCommand("select MAX( cast(substring(no_trans,8,3)+1 as numeric)) as num from retail where no_trans like '" & prefiks & "%'", sqlconn).ExecuteReader
        If sqlr.HasRows Then
            sqlr.Read()
            nextnumber = sqlr.Item("num").ToString()
            sqlr.Close()
        Else
            nextnumber = "1"
        End If
        ntran_cek = prefiks & nextnumber.PadLeft(3, "0"c)
        sqlr.Close()

        Return ntran_cek
    End Function

    Public Sub simpan(Optional ByRef isDelete As Boolean = False)
        Dim BTRANS As SqlTransaction
        Dim row As DataRow
        Dim no_trans As String

        If Not isDelete Then

            row = DSAll.Tables("_krd").Rows(0)
            row.Item("note_kabagSP") = me_note.Text
            row.Item("Last_Update") = getTanggal()
            row.Item("Last_Updated_By") = username
        End If

        Try

            CommandBuilder = New SqlClient.SqlCommandBuilder(DAKredit)
            DAKredit.UpdateCommand = CommandBuilder.GetUpdateCommand()
            DAKredit.InsertCommand = CommandBuilder.GetInsertCommand()
            DAKredit.DeleteCommand = CommandBuilder.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            DAKredit.UpdateCommand.Transaction = BTRANS
            DAKredit.InsertCommand.Transaction = BTRANS
            DAKredit.DeleteCommand.Transaction = BTRANS

            DAKredit.Update(DSAll.Tables("_krd"))

            BTRANS.Commit()

            If STATE = "DELETE" Then
                showMessages("Data Entry dihapus..")
            Else
                showMessages("Berhasil disimpan")
            End If
            STATE = "EDIT"
            btnSave = False
            setStatus()
        Catch e As Exception
            BTRANS.Rollback()
            DSAll.Tables("_krd").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub
End Class