Imports System.Data.SqlClient
Imports System.Globalization
Imports DevExpress.XtraPrintingLinks
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Imports System.Drawing
Imports DevExpress.Utils

Public Class frm_Kredit_Rec
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
    Private DALookup, DAKredit, DAHist, DAPot As SqlClient.SqlDataAdapter
    Private DSAll, DSRecovery As New DataSet
    Private rw As DataRow
    Private persen_provisi, persen_bunga, persen_denda, jml_plafond, jml_admin, batas_admin, batas_admin1, batas_admin2 As Decimal
    Private angsuran_pokok_akhir As Decimal
    Public _notrans As String = "xxx"
    Private persen_penalty As Decimal = 2.5
    Private stat_rec As Boolean = False
    Private lock_angsuran_pokok, lock_jml_terima As Boolean


    Public Sub add_click()
        STATE = "ADD" '<-- set state add
        btnAdd = False
        btnEdit = False
        btnCancel = True
        btnDelete = False
        btnSave = True
        setStatus()
        bersihkan()
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
        btnEdit = True
        btnAdd = True
        setStatus()
        Me.Enabled = False
        bersihkan()
        le_jenis_kredit.EditValue = Nothing
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

    End Sub
    Private Sub bersihkan()
        lb_provisi.Text = ""
        lb_bunga.Text = ""
        lb_denda.Text = ""
        lb_plafond.Text = ""
        lb_admin.Text = ""
        lb_no_trans.Text = ""
        te_bunga.EditValue = 0
        le_nama.EditValue = Nothing
        le_nama.Enabled = False
        bersihkan_nasabah()


        le_jenis_kredit.Properties.ReadOnly = IIf(STATE = "EDIT", True, False)
        le_tipe_kredit.Properties.ReadOnly = IIf(STATE = "EDIT", True, False)
        le_nama.Properties.ReadOnly = IIf(STATE = "EDIT", True, False)
    End Sub
    Private Sub bersihkan_nasabah()
        lb_nasabah.Text = ""
        te_jml_pinjaman.EditValue = 0
        te_lama_pinjaman.EditValue = 0
        te_jml_terima.EditValue = 0
        te_biaya_provisi.EditValue = 0
        te_pot_bonus.EditValue = 0
        te_pot_thr.EditValue = 0
        te_pot_tat.EditValue = 0
        te_keterangan.EditValue = ""
        te_norek_cair.EditValue = ""
        te_norek_debet.EditValue = ""
        te_total_recovery.EditValue = 0
        te_biaya_penalty.EditValue = 0
        te_bunga_berjalan.EditValue = 0
        te_angsuran_pokok.EditValue = 0
        te_angsuran_bunga.EditValue = 0
        te_angsuran_total.EditValue = 0
        cb_jml_terima.Checked = False
        If Not DSRecovery.Tables("_hist") Is Nothing Then DSRecovery.Tables("_hist").Clear()
        If Not DSAll.Tables("_kartu") Is Nothing Then DSAll.Tables("_kartu").Clear()

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
        If Not DSAll.Tables("_kartu") Is Nothing Then DSAll.Tables("_kartu").Clear()
        If Not DSAll.Tables("_pot") Is Nothing Then DSAll.Tables("_pot").Clear()

        DAKredit = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select  * from kredit where no_trans='" & kode & "'", sqlconn))
        DAKredit.Fill(DSAll, "_krd")
        If DSAll.Tables("_krd").Rows.Count > 0 Then
            Dim rwm As DataRow = DSAll.Tables("_krd").Rows(0)
            dt_tanggal.EditValue = rwm.Item("tgl_trans")
            dt_tanggal_debet.EditValue = rwm.Item("tgl_debet")

            le_jenis_kredit.EditValue = rwm.Item("jenis")
            le_tipe_kredit.EditValue = rwm.Item("tipe")
            le_nama.EditValue = rwm.Item("nasabah_id")
            te_no_form.Text = rwm.Item("no_ref")
            lb_no_trans.Text = rwm.Item("no_trans")
            cari_nasabah(le_nama.EditValue)
            te_jml_pinjaman.EditValue = rwm.Item("JML_PINJAMAN")
            te_lama_pinjaman.EditValue = rwm.Item("LAMA_ANGS")
            te_jml_terima.EditValue = rwm.Item("JML_TERIMA")
            te_pot_bonus.EditValue = rwm.Item("pot_bns")
            te_pot_tat.EditValue = rwm.Item("pot_tat")
            te_pot_thr.EditValue = rwm.Item("pot_thr")
            'le_batas_admin.EditValue = rwm.Item("nasabah_id")
            te_biaya_provisi.EditValue = rwm.Item("JML_PROVISI")
            te_biaya_admin.EditValue = rwm.Item("JML_ADMIN")
            te_bunga.EditValue = rwm.Item("bunga")
            le_batas_admin.EditValue = rwm.Item("batas_admin")

            te_keterangan.EditValue = rwm.Item("KETERANGAN")
            te_norek_cair.EditValue = rwm.Item("norek_cair")
            te_norek_debet.EditValue = rwm.Item("no_rek")
            te_norek_debet2.EditValue = rwm.Item("no_rek2")
            te_total_recovery.EditValue = rwm.Item("rec_jumlah")
            te_biaya_penalty.EditValue = rwm.Item("rec_penalty")
            te_bunga_berjalan.EditValue = rwm.Item("rec_bbj")
            te_angsuran_pokok.EditValue = rwm.Item("JML_POKOK")
            te_angsuran_bunga.EditValue = rwm.Item("JML_BUNGA")
            te_angsuran_total.EditValue = rwm.Item("jml_angsuran")

            cb_jml_terima.Checked = rwm.Item("lock_jml_terima")

            ' generate kartu angsuran
            Dim tgl_real, iterate_monthyear As DateTime
            Dim pinjaman, pot_bns, pot_thr, pot_tat, pokok_akhir, pot_total, pot_all As Long
            tgl_real = rwm.Item("tgl_trans")
            Dim tenor As Integer = rwm.Item("LAMA_ANGS")
            pokok_akhir = rwm.Item("JML_PINJAMAN")
            pot_all = 0
            For i As Integer = 1 To tenor
                iterate_monthyear = tgl_real.AddMonths(i)
                rw = DSAll.Tables("_kartu").NewRow()
                rw.Item("c_pokok_pinj") = pokok_akhir
                rw.Item("c_pokok") = IIf(i = tenor, rwm.Item("JML_POKOK_TERAKHIR"), rwm.Item("JML_POKOK"))
                rw.Item("c_bunga") = rwm.Item("JML_BUNGA")
                rw.Item("c_angs") = rw.Item("c_pokok") + rw.Item("c_bunga")
                rw.Item("c_bns") = 0
                rw.Item("c_thr") = 0
                rw.Item("c_tat") = 0
                rw.Item("angs_ke") = i
                rw.Item("c_tahun") = iterate_monthyear.Year
                rw.Item("c_bulan") = MonthName(Convert.ToInt16(iterate_monthyear.Month.ToString), True)
                If iterate_monthyear.Month = 4 Then
                    pokok_akhir = pokok_akhir - pot_bns
                    pot_total += pot_bns
                    rw.Item("c_bns") = rwm.Item("pot_bns")
                ElseIf iterate_monthyear.Month = 7 Then
                    pokok_akhir = pokok_akhir - pot_thr
                    pot_total += pot_thr
                    rw.Item("c_thr") = rwm.Item("pot_thr")
                ElseIf iterate_monthyear.Month = 12 Then
                    pokok_akhir = pokok_akhir - pot_tat
                    pot_total += pot_tat
                    rw.Item("c_tat") = rwm.Item("pot_tat")
                End If
                rw.Item("c_pokok_akhir") = rw.Item("c_pokok_pinj") - (rw.Item("c_pokok") + rw.Item("c_bns") + rw.Item("c_thr") + rw.Item("c_tat"))
                pokok_akhir = rw.Item("c_pokok_akhir")
                DSAll.Tables("_kartu").Rows.Add(rw)
            Next
            ' end kartu angsuran
            stat_rec = True

        End If


        

        If STATE = "ADD" Then
            DALookup = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from kartu where 1=2", sqlconn))
            DALookup.Fill(DSAll, "_kartu")
        End If
        GCKartu.DataSource = DSAll.Tables("_kartu")



        DAPot = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from kredit_pot where no_trans='" & kode & "'", sqlconn))
        DAPot.Fill(DSAll, "_pot")

        DAHist = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select 0 as jml_pinjaman, 0 as lama_angs, * from kredit_rec where no_trans='" & kode & "'", sqlconn))
        DAHist.Fill(DSRecovery, "_hist")
        For Each rh As DataRow In DSRecovery.Tables("_hist").Rows
            Dim sqdr As SqlDataReader = New SqlCommand("SELECT * from kredit k where k.no_trans= '" & rh.Item("no_kredit").ToString() & "'", sqlconn).ExecuteReader
            If sqdr.HasRows Then
                sqdr.Read()
                rh.Item("jml_pinjaman") = sqdr.Item("JML_PINJAMAN")
                rh.Item("lama_angs") = sqdr.Item("LAMA_ANGS")
                sqdr.Close()
            End If
            
        Next
        GCHistory.DataSource = DSRecovery.Tables("_hist")
    End Sub
    Public Sub save_click(Optional ByRef isDel As Boolean = False)
        If STATE = "ADD" Then
            If le_jenis_kredit.EditValue = vbNullString Then
                MsgBox("Jenis Kredit belum dipilih", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If te_jml_pinjaman.EditValue = 0 Then
                MsgBox("Besar pinjaman belum diisi", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If te_lama_pinjaman.EditValue = 0 Then
                MsgBox("Lama pinjaman belum diisi", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If te_total_recovery.EditValue = 0 Then
                MsgBox("Nilai recovery belum diisi pada tabel sebelah kanan", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

        End If
        If MsgBox("Data akan disimpan ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then simpan(isDel)
    End Sub

    Private Sub formLoad(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        connect()
        prn = getParent(Me)
        LoadStruktur("xxx")
        dt_tanggal.EditValue = Today
        dt_tanggal.Properties.MaxValue = Today
        dt_tanggal_debet.EditValue = IIf(Today.Day >= 25, New Date(Today.AddMonths(1).Year, Today.AddMonths(1).Month, 25), New Date(Today.Year, Today.Month, 25))
        dt_tanggal_debet.Properties.MinValue = Today

        DALookup = New SqlDataAdapter(New SqlCommand("SELECT * FROM m_jns_upload where tipe_trans='KRD' and kd2 in ('01','02')", sqlconn))
        DALookup.Fill(DSAll, "LookTran")
        le_jenis_kredit.Properties.DataSource = DSAll.Tables("LookTran")
        le_jenis_kredit.Properties.DisplayMember = "Nama"
        le_jenis_kredit.Properties.ValueMember = "kode"

        DALookup = New SqlDataAdapter(New SqlCommand("select tipe,nama from m_tipe", sqlconn))
        DALookup.Fill(DSAll, "LookTipe")
        le_tipe_kredit.Properties.DataSource = DSAll.Tables("LookTipe")
        le_tipe_kredit.Properties.DisplayMember = "nama"
        le_tipe_kredit.Properties.ValueMember = "tipe"
        le_tipe_kredit.EditValue = "F"

        DALookup = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("SELECT a.nasabah_id, a.sts_anggota, a.nama, a.tgl_lahir, a.telp_skrg, a.rekbca1, a.rekbca2, a.rekbca3, a.rec_stat, a.alamat, a.kota, j.job_id, j.job_nama FROM anggota a LEFT JOIN m_jabatan j ON j.job_id = a.job_id WHERE a.rec_stat=1", sqlconn))
        DALookup.Fill(DSAll, "LookNasabah")
        le_nama.Properties.DataSource = DSAll.Tables("LookNasabah")
        le_nama.Properties.ValueMember = "nasabah_id"
        le_nama.Properties.DisplayMember = "nasabah_id"
        le_nama.Enabled = False

        stat_rec = False
        lock_angsuran_pokok = False
        lock_jml_terima = False

    End Sub

    Public Function get_notran() As String
        Dim prefiks, ntran_cek, nextnumber As String

        prefiks = getKodeCabang() & le_jenis_kredit.Properties.GetDataSourceValue("kd2", le_jenis_kredit.ItemIndex).ToString() & blthn()

        Dim sqlr As SqlDataReader = New SqlCommand("select MAX( cast(substring(no_trans,8,3)+1 as numeric)) as num from kredit where no_trans like '" & prefiks & "%'", sqlconn).ExecuteReader
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

        If Not stat_rec Then
            MsgBox("Nasabah tidak memiliki pinjaman yang akan di recovery")
            bersihkan_nasabah()
            Exit Sub
        End If

        If Not isDelete Then
            If STATE = "ADD" Then
                row = DSAll.Tables("_krd").NewRow
                no_trans = get_notran()
                row.Item("no_trans") = no_trans
                row.Item("Last_Create_Date") = getTanggal()
                row.Item("Last_Created_By") = username
                row.Item("cetak_ke") = 0
                lb_no_trans.Text = no_trans

            ElseIf STATE = "EDIT" Then
                row = DSAll.Tables("_krd").Rows(0)
                row.Item("Last_Update") = getTanggal()
                row.Item("Update_By") = username
            ElseIf STATE = "CETAK" Then
                row.Item("cetak_ke") = row.Item("cetak_ke") + 1
            End If
            row.Item("tgl_trans") = dt_tanggal.EditValue
            row.Item("kd_kredit") = "REC" '### TOP UP
            row.Item("NASABAH_ID") = le_nama.EditValue
            row.Item("jenis") = le_jenis_kredit.EditValue
            row.Item("tipe") = le_tipe_kredit.EditValue
            row.Item("JML_PINJAMAN") = te_jml_pinjaman.EditValue
            row.Item("JML_DENDA") = lb_denda.Text
            row.Item("JML_ADMIN") = te_biaya_admin.EditValue
            row.Item("JML_POKOK") = te_angsuran_pokok.EditValue
            row.Item("JML_POKOK_TERAKHIR") = angsuran_pokok_akhir
            row.Item("JML_BUNGA") = te_angsuran_bunga.EditValue
            row.Item("jml_angsuran") = te_angsuran_total.EditValue
            row.Item("rec_tgl_debt_lalu") = dt_tanggal_debet.EditValue
            row.Item("tgl_debet") = dt_tanggal_debet.EditValue
            'row.Item("JML_ASURANSI") = tx_asr.Text
            row.Item("JML_PROVISI") = te_biaya_provisi.EditValue
            row.Item("JML_TERIMA") = te_jml_terima.EditValue
            'row.Item("JML_DENDA") = tx1_LamaPJM.Text
            row.Item("TGL_PENGAJUAN") = dt_tanggal.EditValue 'getTanggal()
            row.Item("STATUS_AKTIF") = 0
            row.Item("LAMA_ANGS") = te_lama_pinjaman.Text
            row.Item("sisa_angs") = te_lama_pinjaman.Text
            row.Item("TGL_TAGIHAN") = "25"
            row.Item("status_lunas") = "BELUM"
            row.Item("bunga") = persen_bunga
            row.Item("sisa_pokok_after_potong") = 0 't_pk_br
            row.Item("sisa_pokok") = te_jml_pinjaman.EditValue
            row.Item("sisa_pokok_lama") = 0 'sisa_pokok_lama
            row.Item("approve1_by") = "OutStanding"
            row.Item("approve2_by") = "OutStanding"
            row.Item("approve3_by") = "OutStanding"
            row.Item("approve4_by") = "OutStanding"
            row.Item("stat_approve") = 0
            row.Item("stat_cair") = 0
            row.Item("KETERANGAN") = te_keterangan.Text
            row.Item("stat_kabagSP") = "Outstanding"
            row.Item("no_rek") = te_norek_debet.Text
            row.Item("no_rek2") = te_norek_debet2.EditValue
            'row.Item("nama_bank") = txb_bank.Text 'rec_lunas
            row.Item("rec_lunas") = 1
            row.Item("pot_bns") = te_pot_bonus.EditValue
            row.Item("pot_thr") = te_pot_thr.EditValue
            row.Item("pot_tat") = te_pot_tat.EditValue
            row.Item("stat_pot_bns") = 0
            row.Item("stat_pot_thr") = 0
            row.Item("stat_pot_tat") = 0
            'row.Item("no_jaminan") = tx_jaminan.Text
            'row.Item("foto_jaminan") = foto
            row.Item("norek_cair") = te_norek_cair.Text
            row.Item("no_ref") = te_no_form.Text
            'If stat_rec = True Then
            row.Item("rec_jumlah") = te_total_recovery.EditValue
            row.Item("rec_penalty") = te_biaya_penalty.EditValue
            row.Item("rec_provisi") = te_biaya_provisi.EditValue
            row.Item("rec_admin") = te_biaya_admin.EditValue
            row.Item("rec_bbj") = te_bunga_berjalan.EditValue

            row.Item("batas_admin") = le_batas_admin.EditValue
            row.Item("lock_jml_terima") = cb_jml_terima.Checked


            If STATE = "ADD" Then
                DSAll.Tables("_krd").Rows.Add(row)

                For Each rwhist As DataRow In DSRecovery.Tables("_hist").Rows
                    rwhist.Item("no_trans") = no_trans
                Next

            End If

            
            simpan_pot()

            
        End If
        Try

            CommandBuilder = New SqlClient.SqlCommandBuilder(DAKredit)
            DAKredit.UpdateCommand = CommandBuilder.GetUpdateCommand()
            DAKredit.InsertCommand = CommandBuilder.GetInsertCommand()
            DAKredit.DeleteCommand = CommandBuilder.GetDeleteCommand()

            CommandBuilder = New SqlClient.SqlCommandBuilder(DAHist)
            DAHist.UpdateCommand = CommandBuilder.GetUpdateCommand()
            DAHist.InsertCommand = CommandBuilder.GetInsertCommand()
            DAHist.DeleteCommand = CommandBuilder.GetDeleteCommand()

            CommandBuilder = New SqlClient.SqlCommandBuilder(DAPot)
            DAPot.UpdateCommand = CommandBuilder.GetUpdateCommand()
            DAPot.InsertCommand = CommandBuilder.GetInsertCommand()
            DAPot.DeleteCommand = CommandBuilder.GetDeleteCommand()

            BTRANS = sqlconn.BeginTransaction("1")
            DAKredit.UpdateCommand.Transaction = BTRANS
            DAKredit.InsertCommand.Transaction = BTRANS
            DAKredit.DeleteCommand.Transaction = BTRANS

            DAHist.UpdateCommand.Transaction = BTRANS
            DAHist.InsertCommand.Transaction = BTRANS
            DAHist.DeleteCommand.Transaction = BTRANS

            DAPot.UpdateCommand.Transaction = BTRANS
            DAPot.InsertCommand.Transaction = BTRANS
            DAPot.DeleteCommand.Transaction = BTRANS

            DAKredit.Update(DSAll.Tables("_krd"))
            DAHist.Update(DSRecovery.Tables("_hist"))
            DAPot.Update(DSAll.Tables("_pot"))

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
            DSRecovery.Tables("_hist").RejectChanges() ' untuk membatalkan row yg diupdate/insert
            MsgBox(e.Message, MsgBoxStyle.Critical, "Gagal Simpan")
        End Try
    End Sub

    Private Sub le_jenis_kredit_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles le_jenis_kredit.EditValueChanged
        bersihkan()
        If le_jenis_kredit.EditValue = Nothing Then
            Exit Sub
        End If
        Dim this As DevExpress.XtraEditors.LookUpEdit = sender
        Dim dr As DataRow = DSAll.Tables("LookTran").Select("kode='" & this.EditValue & "'").First

        persen_provisi = dr.Item("provisi")
        persen_bunga = dr.Item("Bunga_KSP")
        persen_denda = dr.Item("Denda")
        persen_penalty = IIf(dr.Item("penalty") Is DBNull.Value, 0, dr.Item("penalty"))
        jml_plafond = dr.Item("nilai")
        jml_admin = dr.Item("Adm")
        batas_admin1 = dr.Item("batas_admin1")
        batas_admin2 = dr.Item("batas_admin2")

        Dim rw() As DataRow '= DSRecovery.Tables("_hist").NewRow
        Dim iList As New ArrayList

        Dim tbl As New DataTable()
        tbl.Columns.Add("batas", GetType(Decimal))
        tbl.Rows.Add(New Object() {batas_admin1})
        tbl.Rows.Add(New Object() {batas_admin2})
        le_batas_admin.Properties.DataSource = tbl
        le_batas_admin.EditValue = batas_admin1
        batas_admin = batas_admin1

        lb_provisi.Text = persen_provisi
        lb_bunga.Text = persen_bunga
        lb_denda.Text = persen_denda
        lb_plafond.Text = jml_plafond.ToString("c", New Globalization.CultureInfo("id-ID", False))
        lb_admin.Text = jml_admin.ToString("c", New Globalization.CultureInfo("id-ID", False))
        te_biaya_admin.EditValue = jml_admin
        te_bunga.EditValue = persen_bunga

        If STATE = "ADD" Then
            le_nama.Enabled = True
            le_nama.ShowPopup()
            le_nama.Focus()
        End If

    End Sub
    Private Sub cari_nasabah(ByVal vnip As String)
        Dim dr As DataRow = DSAll.Tables("LookNasabah").Select("nasabah_id='" & vnip & "'").First
        Dim nsb_jabatan As String
        If dr.Item("job_nama").ToString <> vbNullString Then
            nsb_jabatan = ", Jabatan: " & dr.Item("job_nama").ToString
        End If

        Dim nsb_alamat As String
        If dr.Item("alamat").ToString <> vbNullString Then
            nsb_alamat = ", Alamat: " & dr.Item("alamat").ToString
            If dr.Item("kota").ToString <> vbNullString Then
                nsb_alamat &= " " & dr.Item("kota").ToString
            End If
        Else
            If dr.Item("kota").ToString <> vbNullString Then
                nsb_alamat &= ", Alamat: " & dr.Item("kota").ToString
            End If
        End If

        lb_nasabah.Text = dr.Item("Nama").ToString & nsb_jabatan & nsb_alamat
        'If Not DSAll.Tables("LookupHistory") Is Nothing Then DSAll.Tables("LookupHistory").Clear()
        'DALookup = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select a.nasabah_id as NIP,a.Nama as [Nama],t.no_trans,t.tgl_trans as TGL_PINJAM,t.JML_PINJAMAN,t.sisa_angs,t.status_lunas,t.jenis,a.job_id,isnull(a.Almt_asal,'')as Almt_asal ,ISNULL(k.nama_kota,'') as nama_kota,ISNULL(t.no_rek,a.REKBCA1) as no_rek,* from kredit t left JOIN anggota a on t.nasabah_id=a.nasabah_id left join kota k on a.kode_kota=k.kode_kota where t.stat_cair=1 and t.stat_approve>=5 and t.status_lunas='BELUM' and a.nasabah_id='" & le_nama.EditValue & "'", sqlconn))
        If STATE = "ADD" Then
            te_norek_cair.Text = dr.Item("rekbca1").ToString
            te_norek_debet.Text = dr.Item("rekbca1").ToString
            te_norek_debet2.Text = dr.Item("rekbca2").ToString
        End If

    End Sub
    Private Sub cek_history()
        If STATE = "ADD" Then
            If Not DSRecovery.Tables("_hist") Is Nothing Then DSRecovery.Tables("_hist").Clear()
            Dim sqdr As SqlDataReader = New SqlCommand("select k.no_trans, k.nasabah_id, k.tgl_trans, k.no_ref, k.kd_kredit, k.jenis, k.JML_PINJAMAN, k.JML_POKOK, k.JML_BUNGA, k.sisa_pokok, k.LAMA_ANGS, k.sisa_angs from kredit k where k.nasabah_id= '" & le_nama.EditValue.ToString & "' and k.status_lunas<>'LUNAS' and k.stat_approve > 4 AND k.stat_cair=1 ", sqlconn).ExecuteReader
            Dim x As Int16 = 1
            If Not sqdr.HasRows Then
                stat_rec = False
                MsgBox("Nasabah tidak memiliki pinjaman yang akan di recovery")
                Exit Sub
            End If
            stat_rec = True
            While sqdr.Read
                Dim rw As DataRow = DSRecovery.Tables("_hist").NewRow
                rw.Item("no_seq") = x : x += 1
                rw.Item("no_kredit") = sqdr.Item("no_trans")
                rw.Item("nasabah_id") = sqdr.Item("nasabah_id")
                rw.Item("tgl_trans") = sqdr.Item("tgl_trans")
                rw.Item("no_ref") = sqdr.Item("no_ref")
                'rw.Item("kd_kredit") = sqdr.Item("kd_kredit")
                rw.Item("jenis") = sqdr.Item("jenis")
                rw.Item("jml_pinjaman") = sqdr.Item("JML_PINJAMAN")
                rw.Item("jml_pokok") = sqdr.Item("JML_POKOK")
                rw.Item("jml_bunga") = sqdr.Item("JML_BUNGA")
                rw.Item("sisa_pokok") = sqdr.Item("sisa_pokok")
                rw.Item("lama_angs") = sqdr.Item("LAMA_ANGS")
                rw.Item("sisa_angs") = sqdr.Item("sisa_angs")
                rw.Item("nilai") = 0
                rw.Item("bg_jln") = 0
                rw.Item("sisa") = sqdr.Item("sisa_pokok")

                DSRecovery.Tables("_hist").Rows.Add(rw)
            End While
            sqdr.Close()
            GCHistory.DataSource = DSRecovery.Tables("_hist")
        End If
    End Sub
    Private Sub le_nama_Closed(ByVal sender As System.Object, ByVal e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles le_nama.Closed
        bersihkan_nasabah()
        If le_nama.EditValue = Nothing Then
            Exit Sub
        End If
        cari_nasabah(le_nama.EditValue)
        If STATE = "ADD" Then
            cek_history()
            te_no_form.Focus()
        End If

    End Sub

    Private Sub hitung_angsuran()
        If Not stat_rec Then
            MsgBox("Nasabah tidak memiliki pinjaman yang akan di recovery")
            bersihkan_nasabah()
            Exit Sub
        End If
        Dim pinjaman, pot_bns, pot_thr, pot_tat, pokok_akhir, pot_total As Long
        Dim tenor As Integer
        Dim angsuran_pokok, angsuran_bunga, angsuran_total, total_recovery, biaya_penalty, biaya_provisi, bunga_berjalan As Decimal
        Dim tgl_real As DateTime = dt_tanggal.EditValue 'DateTime.Now
        Dim tgl_debet As DateTime = dt_tanggal_debet.EditValue 'DateTime.Now
        Dim iterate_monthyear As DateTime
        angsuran_pokok_akhir = 0
        If le_nama.EditValue Is Nothing Then
            MsgBox("Pilih anggota terlebih dahulu!")
            Exit Sub
        End If

        pinjaman = te_jml_pinjaman.EditValue
        tenor = te_lama_pinjaman.Text

        If pinjaman = 0 Or tenor = 0 Then
            Exit Sub
        End If

        angsuran_bunga = Math.Round(pinjaman * (te_bunga.EditValue / 100))
        pokok_akhir = pinjaman
        Decimal.TryParse(te_pot_bonus.EditValue, pot_bns)
        Decimal.TryParse(te_pot_thr.EditValue, pot_thr)
        Decimal.TryParse(te_pot_tat.EditValue, pot_tat)
        If Not DSAll.Tables("_kartu") Is Nothing Then DSAll.Tables("_kartu").Clear()

        pot_total = 0
        For i As Integer = 0 To (tenor - 1)
            iterate_monthyear = tgl_debet.AddMonths(i)
            rw = DSAll.Tables("_kartu").NewRow()
            rw.Item("c_pokok_pinj") = 0
            rw.Item("c_pokok") = 0
            rw.Item("c_bunga") = angsuran_bunga
            rw.Item("c_angs") = 0
            rw.Item("c_bns") = 0
            rw.Item("c_thr") = 0
            rw.Item("c_tat") = 0
            Dim ke As Integer = i + 1
            rw.Item("angs_ke") = ke
            rw.Item("c_tahun") = iterate_monthyear.Year
            rw.Item("c_bulan") = MonthName(Convert.ToInt16(iterate_monthyear.Month.ToString), True)
            If iterate_monthyear.Month = xbns.Month Then
                pokok_akhir = pokok_akhir - pot_bns
                pot_total += pot_bns
                rw.Item("c_bns") = pot_bns
            ElseIf iterate_monthyear.Month = xthr.Month Then
                pokok_akhir = pokok_akhir - pot_thr
                pot_total += pot_thr
                rw.Item("c_thr") = pot_thr
            ElseIf iterate_monthyear.Month = xtat.Month Then
                pokok_akhir = pokok_akhir - pot_tat
                pot_total += pot_tat
                rw.Item("c_tat") = pot_tat
            End If

            DSAll.Tables("_kartu").Rows.Add(rw)
        Next
        angsuran_pokok = Math.Round(pokok_akhir / tenor)
        Dim rw_prev As DataRow
        For i As Integer = 0 To (tenor - 1)
            rw = DSAll.Tables("_kartu")(i)
            rw_prev = DSAll.Tables("_kartu")(i - 1)


            If i = 0 Then
                rw.Item("c_pokok_pinj") = pinjaman
            Else
                rw.Item("c_pokok_pinj") = rw_prev.Item("c_pokok_akhir")
            End If
            If i = tenor - 1 Then
                rw.Item("c_pokok") = rw.Item("c_pokok_pinj")
                angsuran_pokok_akhir = rw.Item("c_pokok_pinj")
            Else
                rw.Item("c_pokok") = angsuran_pokok
            End If

            rw.Item("c_angs") = rw.Item("c_pokok") + rw.Item("c_bunga")

            Dim saldo_pokok_akhir As Decimal = rw.Item("c_pokok_pinj") - rw.Item("c_pokok")
            Dim pot_all As Decimal
            If i = (tenor - 1) Then
                rw.Item("c_bns") = IIf(rw.Item("c_bns") = 0, 0, saldo_pokok_akhir)
                rw.Item("c_thr") = IIf(rw.Item("c_thr") = 0, 0, saldo_pokok_akhir)
                rw.Item("c_tat") = IIf(rw.Item("c_tat") = 0, 0, saldo_pokok_akhir)
            End If

            pot_all = rw.Item("c_bns") + rw.Item("c_thr") + rw.Item("c_tat")
            rw.Item("c_pokok_akhir") = rw.Item("c_pokok_pinj") - (rw.Item("c_pokok") + pot_all)

        Next

        te_angsuran_pokok.EditValue = angsuran_pokok
        te_angsuran_bunga.EditValue = angsuran_bunga
        angsuran_total = angsuran_pokok + angsuran_bunga
        te_angsuran_total.EditValue = angsuran_total

        Decimal.TryParse(DSRecovery.Tables("_hist").Compute("Sum(nilai)", "([jenis]='DNOR' OR [jenis]='NORM' OR [jenis]='PBRG') AND nilai>0").ToString, total_recovery)
        Dim temptotal As Decimal = 0
        For Each drhist As DataRow In DSRecovery.Tables("_hist").Rows
            If drhist.Item("nilai") > 0 And (drhist.Item("jenis") = "DNOR" Or drhist.Item("jenis") = "NORM" Or drhist.Item("jenis") = "PBRG") Then
                temptotal += drhist.Item("nilai")
            End If
        Next
        total_recovery = temptotal
        te_total_recovery.EditValue = total_recovery
        biaya_penalty = Math.Round(total_recovery * persen_penalty / 100)
        te_biaya_penalty.EditValue = biaya_penalty

        If cb_jml_terima.Checked = False Then
            If pinjaman > batas_admin Then
                If total_recovery > 0 Then
                    biaya_provisi = (pinjaman - total_recovery) * persen_provisi / 100
                Else
                    biaya_provisi = (pinjaman - batas_admin) * persen_provisi / 100
                End If
            Else
                biaya_provisi = 0
            End If
            biaya_provisi = Math.Round(biaya_provisi)
            te_biaya_provisi.EditValue = biaya_provisi
        End If


        Dim tgl_trans As Date = dt_tanggal.EditValue
        Dim tgl_debet_akhir As Date
        Dim jml_hari_bln_lalu As Integer = DateTime.DaysInMonth(tgl_real.AddMonths(-1).Year(), tgl_real.AddMonths(-1).Month())
        Dim bunga_lama, biaya_bunga_berjalan As Decimal
        If tgl_real.Day() > 25 Then
            tgl_debet_akhir = New Date(tgl_real.Year(), tgl_real.Month(), 25)
        Else
            tgl_debet_akhir = New Date(tgl_real.AddMonths(-1).Year(), tgl_real.AddMonths(-1).Month(), 25)

            Dim span As TimeSpan = tgl_real - tgl_debet_akhir
            Dim jml_hari As Integer = 0
            jml_hari = span.Days() + 1
            'Decimal.TryParse(DSRecovery.Tables("_hist").Compute("Sum(jml_bunga)", "([kd_kredit]='DNOR' OR [kd_kredit]='NORM' OR [kd_kredit]='PBRG') AND [nilai]>0").ToString, bunga_lama)
            Dim temptotal2 As Decimal = 0
            For Each drhist As DataRow In DSRecovery.Tables("_hist").Rows
                If drhist.Item("nilai") > 0 And (drhist.Item("jenis") = "DNOR" Or drhist.Item("jenis") = "NORM" Or drhist.Item("jenis") = "PBRG") Then
                    temptotal2 += drhist.Item("jml_bunga")
                End If
            Next
            bunga_lama = temptotal2
            biaya_bunga_berjalan = (bunga_lama / jml_hari_bln_lalu) * jml_hari

        End If
        te_bunga_berjalan.EditValue = Math.Round(biaya_bunga_berjalan)

        If cb_jml_terima.Checked = False Then
            te_jml_terima.EditValue = pinjaman - (te_biaya_provisi.EditValue + te_biaya_admin.EditValue + te_total_recovery.EditValue + te_biaya_penalty.EditValue + te_bunga_berjalan.EditValue)
        End If
    End Sub

    Private Sub te_jml_pinjaman_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles te_jml_pinjaman.KeyDown
        If e.KeyCode = Keys.Enter Then
            If te_jml_pinjaman.EditValue > batas_admin And le_jenis_kredit.EditValue = "NORM" Then
                le_jenis_kredit.EditValue = "DNOR"
                Exit Sub
            End If
            hitung_angsuran()
            te_lama_pinjaman.Focus()
        End If
    End Sub

    Private Sub te_lama_pinjaman_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles te_lama_pinjaman.KeyDown
        If e.KeyCode = Keys.Enter Then
            hitung_angsuran()
            te_pot_bonus.Focus()
        End If
    End Sub

    Private Sub te_pot_bonus_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles te_pot_bonus.KeyDown
        If e.KeyCode = Keys.Enter Then
            hitung_angsuran()
            te_pot_thr.Focus()
        End If
    End Sub

    Private Sub te_pot_thr_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles te_pot_thr.KeyDown
        If e.KeyCode = Keys.Enter Then
            hitung_angsuran()
            te_pot_tat.Focus()
        End If
    End Sub

    Private Sub te_pot_tat_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles te_pot_tat.KeyDown
        If e.KeyCode = Keys.Enter Then
            hitung_angsuran()
            te_keterangan.Focus()
        End If
    End Sub

    Private Sub te_keterangan_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles te_keterangan.KeyDown
        If e.KeyCode = Keys.Enter Then
            te_norek_cair.Focus()
        End If
    End Sub

    Private Sub te_norek_cair_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles te_norek_cair.KeyDown
        If e.KeyCode = Keys.Enter Then
            te_norek_debet.Focus()
        End If
    End Sub

    Private Sub te_norek_debet_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles te_norek_debet.KeyDown
        If e.KeyCode = Keys.Enter Then
            te_norek_debet2.Focus()
        End If
    End Sub

    Private Sub GVHistory_CellValueChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GVHistory.CellValueChanged
        If e.Column.Name = "nilai" Then
            If e.Value > sender.GetRowCellValue(e.RowHandle, "sisa_pokok") Then
                MsgBox("Nilai Recovery melebihi Outstanding")
                sender.SetRowCellValue(e.RowHandle, "nilai", GVHistory.ActiveEditor.OldEditValue)
                Exit Sub
            End If
            Dim sisa_pinjaman As Decimal = sender.GetRowCellValue(e.RowHandle, "sisa_pokok") - e.Value
            sender.SetRowCellValue(e.RowHandle, "sisa", sisa_pinjaman)
            hitung_angsuran()
            GVHistory.MoveNext()
        End If
    End Sub

    Private Sub hitung_by_pokok()
        Dim pinjaman, pot_bns, pot_thr, pot_tat, pokok_akhir, pot_total As Long
        Dim tenor As Integer
        Dim angsuran_pokok, angsuran_bunga, angsuran_total, total_recovery, biaya_penalty, biaya_provisi, bunga_berjalan As Decimal
        Dim tgl_real As DateTime = dt_tanggal.EditValue 'DateTime.Now
        Dim iterate_monthyear As DateTime
        angsuran_pokok_akhir = 0
        If le_nama.EditValue Is Nothing Then
            MsgBox("Pilih anggota terlebih dahulu!")
            Exit Sub
        End If

        pinjaman = te_jml_pinjaman.EditValue
        angsuran_pokok = te_angsuran_pokok.EditValue

        If pinjaman = 0 Or angsuran_pokok = 0 Then
            Exit Sub
        End If

        angsuran_bunga = Math.Round(pinjaman * (te_bunga.EditValue / 100))
        pokok_akhir = pinjaman
        Decimal.TryParse(te_pot_bonus.EditValue, pot_bns)
        Decimal.TryParse(te_pot_thr.EditValue, pot_thr)
        Decimal.TryParse(te_pot_tat.EditValue, pot_tat)
        If Not DSAll.Tables("_kartu") Is Nothing Then DSAll.Tables("_kartu").Clear()

        pot_total = 0

        Dim saldo_pokok_awal As Double = pinjaman
        Dim saldo_pokok_akhir As Double = pinjaman
        Dim iterate_tenor As Integer = 0
        Dim rw_prev As DataRow

        pot_total = 0
        While saldo_pokok_akhir > 0
            iterate_tenor += 1
            rw_prev = DSAll.Tables("_kartu")(iterate_tenor - 1)
            iterate_monthyear = tgl_real.AddMonths(iterate_tenor)
            rw = DSAll.Tables("_kartu").NewRow()
            If (iterate_tenor > 1) Then
                rw.Item("c_pokok_pinj") = saldo_pokok_akhir
            Else
                rw.Item("c_pokok_pinj") = saldo_pokok_awal
            End If

            rw.Item("c_pokok") = angsuran_pokok
            rw.Item("c_bunga") = angsuran_bunga
            rw.Item("c_bns") = 0
            rw.Item("c_thr") = 0
            rw.Item("c_tat") = 0
            rw.Item("angs_ke") = iterate_tenor
            rw.Item("c_tahun") = iterate_monthyear.Year
            rw.Item("c_bulan") = MonthName(Convert.ToInt16(iterate_monthyear.Month.ToString), True)
            'saldo_pokok_akhir -= angsuran_pokok
            If saldo_pokok_akhir >= angsuran_pokok Then
                saldo_pokok_akhir -= angsuran_pokok
                angsuran_pokok_akhir = angsuran_pokok
            Else
                angsuran_pokok_akhir = saldo_pokok_akhir
                rw.Item("c_pokok") = angsuran_pokok_akhir
                saldo_pokok_akhir = 0
            End If
            If saldo_pokok_akhir > 0 Then
                If iterate_monthyear.Month = 4 Then
                    pot_bns = IIf(saldo_pokok_akhir < pot_bns, saldo_pokok_akhir, pot_bns)
                    rw.Item("c_bns") = pot_bns
                    pot_total += pot_bns
                    saldo_pokok_akhir -= pot_bns
                ElseIf iterate_monthyear.Month = 7 Then
                    pot_thr = IIf(saldo_pokok_akhir < pot_thr, saldo_pokok_akhir, pot_thr)
                    rw.Item("c_thr") = pot_thr
                    pot_total += pot_thr
                    saldo_pokok_akhir -= pot_thr
                ElseIf iterate_monthyear.Month = 12 Then
                    pot_tat = IIf(saldo_pokok_akhir < pot_tat, saldo_pokok_akhir, pot_tat)
                    rw.Item("c_tat") = pot_tat
                    pot_total += pot_tat
                    saldo_pokok_akhir -= pot_tat
                End If
            End If
            rw.Item("c_angs") = rw.Item("c_pokok") + rw.Item("c_bunga")
            rw.Item("c_pokok_akhir") = saldo_pokok_akhir

            DSAll.Tables("_kartu").Rows.Add(rw)
        End While


        te_lama_pinjaman.EditValue = iterate_tenor
        te_angsuran_bunga.EditValue = angsuran_bunga
        te_angsuran_total.EditValue = angsuran_pokok + angsuran_bunga

        'lb_tpot.Text = pot_pertahun.ToString("c", New Globalization.CultureInfo("id-ID", False))
        'lb_total2.Text = pot_total.ToString("c", New Globalization.CultureInfo("id-ID", False))

    End Sub

    Private Sub te_angsuran_pokok_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles te_angsuran_pokok.KeyDown
        If e.KeyCode = Keys.Enter Then
            hitung_by_pokok()
        End If
    End Sub

    Private Sub te_jml_terima_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles te_jml_terima.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim biaya_provisi As Decimal

            If te_jml_terima.EditValue = 0 Then
                biaya_provisi = 0
            Else
                If te_total_recovery.EditValue > batas_admin Then
                    biaya_provisi = te_jml_terima.EditValue * (persen_provisi / 100)
                Else
                    biaya_provisi = ((te_jml_terima.EditValue + te_total_recovery.EditValue) - batas_admin) * (persen_provisi / 100)
                End If
            End If
            
            biaya_provisi = Math.Round(biaya_provisi)
            te_biaya_provisi.EditValue = biaya_provisi
            Dim pinjaman As Long
            pinjaman = te_jml_terima.EditValue + (te_biaya_provisi.EditValue + te_biaya_admin.EditValue + te_total_recovery.EditValue + te_biaya_penalty.EditValue + te_bunga_berjalan.EditValue)
            te_jml_pinjaman.EditValue = pinjaman
            cb_jml_terima.Checked = True
            lock_jml_terima = True
            'Dim pinjaman As Long
            'pinjaman = te_jml_terima.EditValue + (te_biaya_provisi.EditValue + te_biaya_admin.EditValue + te_total_recovery.EditValue)
            'pinjaman = (te_jml_terima.EditValue - (bunga_prv * bts1) + TE_adm.EditValue) / (1 - bunga_prv)

            'TE_BsrPJM.EditValue = Math.Round(bsr_pjm)
            hitung_angsuran()
        End If
    End Sub

    Private Sub le_batas_admin_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles le_batas_admin.EditValueChanged
        batas_admin = le_batas_admin.EditValue
    End Sub

    Private Sub te_angsuran_total_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles te_angsuran_total.KeyDown
        If e.KeyCode = Keys.Enter Then
            te_angsuran_pokok.EditValue = te_angsuran_total.EditValue - te_angsuran_bunga.EditValue
            hitung_by_pokok()
        End If
    End Sub

    Private Sub te_no_form_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles te_no_form.KeyDown
        If e.KeyCode = Keys.Enter Then
            te_jml_pinjaman.Focus()
        End If
    End Sub

    Private Sub GCHistory_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GCHistory.KeyDown
        If e.KeyCode = Keys.Enter Then
            hitung_angsuran()
        End If
    End Sub


    Private Sub bt_kartu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_kartu.Click
        Dim composlink As CompositeLink = New CompositeLink(New PrintingSystem())
        composlink.PaperKind = Printing.PaperKind.Legal
        composlink.Landscape = True
        composlink.Margins.Top = 50
        composlink.Margins.Right = 50
        composlink.Margins.Bottom = 50
        composlink.Margins.Left = 50

        Dim pclink As PrintableComponentLink = New PrintableComponentLink()
        pclink.Component = GCKartu
        composlink.Links.Add(pclink)
        composlink.ShowPreviewDialog()
    End Sub

    Private Sub bt_komite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_komite.Click
        
    End Sub

    Private Sub bt_surat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_surat.Click

    End Sub

    Private Sub simpan_pot()
        _notrans = lb_no_trans.Text
        Dim seq As Integer = 0
        Dim pot_nilai As Decimal
        Dim dr As DataRow() = DSAll.Tables("_kartu").Select("c_bns>0")
        Dim jml_rw As Integer
        jml_rw = DSAll.Tables("_kartu").Select("c_bns>0").Count()
        pot_nilai = te_pot_bonus.EditValue
        If jml_rw > 0 Then
            Dim potrw As DataRow() = DSAll.Tables("_pot").Select("kd_kredit='BNS'")
            If potrw.Count() > 0 Then
                potrw(0).Item("nilai") = pot_nilai '* jml_rw
                potrw(0).Item("jml_pokok") = pot_nilai
                potrw(0).Item("jml_bunga") = 0
                potrw(0).Item("sisa_pokok") = pot_nilai * jml_rw
                potrw(0).Item("lama_angs") = jml_rw
                potrw(0).Item("sisa_angs") = jml_rw
                potrw(0).Item("update_by") = username
                potrw(0).Item("last_update") = DateTime.Now
            Else

                Dim nr As DataRow = DSAll.Tables("_pot").NewRow()
                'seq += 1
                nr.Item("no_trans") = _notrans
                'nr.Item("no_seq") = seq
                'nr.Item("no_kredit") = 
                nr.Item("nasabah_id") = le_nama.EditValue
                nr.Item("tgl_trans") = dt_tanggal.EditValue
                'nr.Item("no_ref") = 
                nr.Item("kd_kredit") = "BNS"
                nr.Item("jenis") = le_jenis_kredit.EditValue
                nr.Item("nilai") = pot_nilai '* jml_rw
                nr.Item("jml_pokok") = pot_nilai
                nr.Item("jml_bunga") = 0
                nr.Item("sisa_pokok") = pot_nilai * jml_rw
                nr.Item("lama_angs") = jml_rw
                nr.Item("sisa_angs") = jml_rw
                'nr.Item("tgl_bayar") = 
                'nr.Item("stat_lunas") = 
                'nr.Item("lunas_by") = 
                nr.Item("create_date") = DateTime.Now
                nr.Item("create_by") = username
                'nr.Item("cek_byr") = 
                'nr.Item("update_by") = 
                'nr.Item("last_update") = 
                'nr.Item("keterangan") = 
                'nr.Item("ket_cabang") = 
                'nr.Item("sisa") = 
                'nr.Item("jml_pinjaman") = 
                DSAll.Tables("_pot").Rows.Add(nr)
            End If
        Else
            For Each delrw As DataRow In DSAll.Tables("_pot").Select("kd_kredit='BNS'")
                delrw.Delete()
            Next
        End If

        pot_nilai = te_pot_thr.EditValue
        jml_rw = DSAll.Tables("_kartu").Select("c_thr>0").Count()
        If jml_rw > 0 Then
            Dim potrw As DataRow() = DSAll.Tables("_pot").Select("kd_kredit='THR'")
            If potrw.Count() > 0 Then
                potrw(0).Item("nilai") = pot_nilai '* jml_rw
                potrw(0).Item("jml_pokok") = pot_nilai
                potrw(0).Item("jml_bunga") = 0
                potrw(0).Item("sisa_pokok") = pot_nilai * jml_rw
                potrw(0).Item("lama_angs") = jml_rw
                potrw(0).Item("sisa_angs") = jml_rw
                potrw(0).Item("update_by") = username
                potrw(0).Item("last_update") = DateTime.Now
            Else

                Dim nr As DataRow = DSAll.Tables("_pot").NewRow()
                'seq += 1
                nr.Item("no_trans") = _notrans
                'nr.Item("no_seq") = seq
                'nr.Item("no_kredit") = 
                nr.Item("nasabah_id") = le_nama.EditValue
                nr.Item("tgl_trans") = dt_tanggal.EditValue
                'nr.Item("no_ref") = 
                nr.Item("kd_kredit") = "THR"
                nr.Item("jenis") = le_jenis_kredit.EditValue
                nr.Item("nilai") = pot_nilai '* jml_rw
                nr.Item("jml_pokok") = pot_nilai
                nr.Item("jml_bunga") = 0
                nr.Item("sisa_pokok") = pot_nilai * jml_rw
                nr.Item("lama_angs") = jml_rw
                nr.Item("sisa_angs") = jml_rw
                'nr.Item("tgl_bayar") = 
                'nr.Item("stat_lunas") = 
                'nr.Item("lunas_by") = 
                nr.Item("create_date") = DateTime.Now
                nr.Item("create_by") = username
                'nr.Item("cek_byr") = 
                'nr.Item("update_by") = 
                'nr.Item("last_update") = 
                'nr.Item("keterangan") = 
                'nr.Item("ket_cabang") = 
                'nr.Item("sisa") = 
                'nr.Item("jml_pinjaman") = 
                DSAll.Tables("_pot").Rows.Add(nr)
            End If
        Else
            For Each delrw As DataRow In DSAll.Tables("_pot").Select("kd_kredit='THR'")
                delrw.Delete()
            Next
        End If

        pot_nilai = te_pot_tat.EditValue
        jml_rw = DSAll.Tables("_kartu").Select("c_tat>0").Count()
        If jml_rw > 0 Then
            Dim potrw As DataRow() = DSAll.Tables("_pot").Select("kd_kredit='TAT'")
            If potrw.Count() > 0 Then
                potrw(0).Item("nilai") = pot_nilai '* jml_rw
                potrw(0).Item("jml_pokok") = pot_nilai
                potrw(0).Item("jml_bunga") = 0
                potrw(0).Item("sisa_pokok") = pot_nilai * jml_rw
                potrw(0).Item("lama_angs") = jml_rw
                potrw(0).Item("sisa_angs") = jml_rw
                potrw(0).Item("update_by") = username
                potrw(0).Item("last_update") = DateTime.Now
            Else

                Dim nr As DataRow = DSAll.Tables("_pot").NewRow()
                'seq += 1
                nr.Item("no_trans") = _notrans
                'nr.Item("no_seq") = seq
                'nr.Item("no_kredit") = 
                nr.Item("nasabah_id") = le_nama.EditValue
                nr.Item("tgl_trans") = dt_tanggal.EditValue
                'nr.Item("no_ref") = 
                nr.Item("kd_kredit") = "TAT"
                nr.Item("jenis") = le_jenis_kredit.EditValue
                nr.Item("nilai") = pot_nilai '* jml_rw
                nr.Item("jml_pokok") = pot_nilai
                nr.Item("jml_bunga") = 0
                nr.Item("sisa_pokok") = pot_nilai * jml_rw
                nr.Item("lama_angs") = jml_rw
                nr.Item("sisa_angs") = jml_rw
                'nr.Item("tgl_bayar") = 
                'nr.Item("stat_lunas") = 
                'nr.Item("lunas_by") = 
                nr.Item("create_date") = DateTime.Now
                nr.Item("create_by") = username
                'nr.Item("cek_byr") = 
                'nr.Item("update_by") = 
                'nr.Item("last_update") = 
                'nr.Item("keterangan") = 
                'nr.Item("ket_cabang") = 
                'nr.Item("sisa") = 
                'nr.Item("jml_pinjaman") = 
                DSAll.Tables("_pot").Rows.Add(nr)
            End If
        Else
            For Each delrw As DataRow In DSAll.Tables("_pot").Select("kd_kredit='TAT'")
                delrw.Delete()
            Next
        End If
        For Each pr As DataRow In DSAll.Tables("_pot").Rows
            If pr.RowState <> DataRowState.Deleted Then
                seq += 1
                pr.Item("no_seq") = seq
            End If
        Next
    End Sub
End Class