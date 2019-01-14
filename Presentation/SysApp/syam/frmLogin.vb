Imports System.Data
Imports System.Windows.Forms
Imports Presentation.frmMain
Imports System.Data.SqlClient

Public Class frmLogin
    Private Sub txtUsername_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsername.KeyPress
        If AscW(e.KeyChar) = 13 Then
            txtPassword.Focus()
            'login()
        End If
    End Sub
    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'connect()

        Dim inicls As New INICLASS
        Dim inifile As String = App_Path() & "\ConString.ini"
        cmbDb.Text = ""
        Dim hasil As String = inicls.getListKey("CSQL", inifile)
        Dim coll() As String
        If hasil <> "" Then
            coll = inicls.getListKey("CSQL", inifile).Split("%")
            For i As Int16 = 0 To coll.Count - 1
                If coll(i) <> "" And i = 0 Then cmbDb.Text = coll(i)
            Next
        End If
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        login()
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If AscW(e.KeyChar) = 13 Then
            login()
        End If
    End Sub

    Private Sub login()
        DB = cmbDb.Text
        connect()
        Dim dadbe As SqlClient.SqlDataAdapter
        Dim ds As New DataSet
        Dim i As Int16 = 0
        Dim j As Int16 = 0
        username = ""
        namauser = ""
        kdcabang = ""
        kddep = ""
        kdpeg = ""
        If txtPassword.Text = "" Then
            txtPassword.Select()
        ElseIf txtUsername.Text = "" Then
            txtUsername.Select()
        Else
            If txtUsername.Text = "admin" Or txtUsername.Text = "adminspon" Then
                username = "admin"
                namauser = "admin"
                kdcabang = "1"
                kddep = "1"
                baca_konfig()
                If txtUsername.Text = "adminspon" Then kddep = "3"
                Dim dr As SqlDataReader = New SqlCommand("select * from [KOPKAR].[dbo].[Parameter] where [Id_Table] = 'PARAM' and  [Kd_Cabang]= '" & kdcabang & "' AND Param_SubKode1='PUSATPEL'", sqlconn).ExecuteReader
                ' dr.Read()
                While dr.Read
                    'If dr("Param_SubKode1") = "PUSATPEL" Then
                    judulMain = dr("Param_KetKode1").ToString
                    'End If
                End While
                dr.Close()
                frmMain.Text = judulMain
                frmMain.Show()
                txtUsername.Focus()
                Me.Hide()
                txtPassword.Text = ""
                txtUsername.Text = ""
                pnlRole.Visible = False
                Exit Sub
            Else
                Dim dr As SqlDataReader = New SqlCommand("select * from KOPKAR.dbo.muser where userid= '" & txtUsername.Text & "' and passwd = '" & AES_Encrypt(txtPassword.Text, "password") & "'", sqlconn).ExecuteReader
                dr.Read()
                If Not dr.HasRows Then
                    showMessages("Username Atau Password Salah!", , "WARNING")
                    pnlLogin.Enabled = True
                    txtUsername.SelectAll()
                    txtUsername.Select()
                    dr.Close()
                    Exit Sub
                End If
                If dr("rec_stat").ToString <> "Y" Then
                    showMessages("User Tidak Aktif ", , "WARNING")
                    pnlLogin.Enabled = True
                    txtUsername.SelectAll()
                    txtUsername.Select()
                    Exit Sub
                End If
                kdpeg = dr("NIP")
                dr.Close()
                dr = New SqlCommand("select isnull(depsec,0) as depsec,* from KOPKAR.dbo.anggota where nasabah_id= '" & kdpeg & "'", sqlconn).ExecuteReader
                dr.Read()
                If Not dr.HasRows Then
                    MsgBox("Kode Pegawai Tidak Diketemukan, Hubungi Admin Setempat", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Gagal Login")
                    pnlLogin.Enabled = True
                    txtUsername.SelectAll()
                    txtUsername.Select()
                    dr.Close()
                    Exit Sub
                End If
                username = txtUsername.Text
                namauser = dr.Item("Nama")
                'kdcabang = dr.Item("Kd_Cabang")
                kddep = dr.Item("depsec")

                dr.Close()

                baca_konfig()
                
                dr = New SqlCommand("select * from [KOPKAR].[dbo].[Parameter] where [Id_Table] = 'PARAM' and  [Kd_Cabang]= '" & kdcabang & "' AND Param_SubKode1='PUSATPEL'", sqlconn).ExecuteReader
                ' dr.Read()
                While dr.Read
                    If dr("Param_SubKode1") = "SIKAP" Then
                        judulMain = dr("Param_KetKode1").ToString
                    Else
                        Perusahaan = dr("Param_KetKode1").ToString
                        AlamatPerusahaan = dr("Param_KetKode2").ToString
                        KotaPerusahaan = dr("Param_KetKode3").ToString
                    End If
                End While
                dr.Close()
                frmMain.Text = judulMain
                frmMain.lblJudul.Text = Perusahaan
                pnlLogin.Enabled = False
                dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select nama, mrole.idrole from KOPKAR.dbo.muser_role, KOPKAR.dbo.mrole where muser_role.idrole=mrole.idrole and iduser='" & txtUsername.Text & "'", sqlconn))
                dadbe.Fill(ds, "muser_role")

                Dim rows As New RowStyle
                Dim opt As New DevExpress.XtraEditors.SimpleButton

                layRole.Visible = False
                layRole.RowStyles.Clear()
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    opt = New DevExpress.XtraEditors.SimpleButton
                    opt.Image = btnLogin.Image
                    opt.Appearance.Options.UseFont = True
                    opt.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
                    opt.Height = 28
                    opt.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near

                    opt.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
                    AddHandler opt.Click, AddressOf btn_click
                    opt.Text = ds.Tables(0).Rows(i).Item(0).ToString.ToUpperInvariant
                    opt.Tag = ds.Tables(0).Rows(i).Item(1)
                    If ds.Tables(0).Rows.Count = 1 Then
                        btn_click(opt, New EventArgs)
                        Exit Sub
                    End If
                    rows = New RowStyle
                    rows.Height = 28
                    layRole.RowStyles.Add(rows)
                    layRole.SetRow(opt, i)
                    opt.Dock = DockStyle.Top
                    opt.Parent = layRole

                Next
                layRole.Height = i * 29 + 50
                layRole.SetRow(lblPilRol, 0)
                pnlRole.Dock = DockStyle.Fill
                layRole.Top = (Me.Height - layRole.Height) / 2
                layRole.Left = (Me.Width - layRole.Width) / 2

            End If
            pnlRole.Visible = True
            layRole.Visible = True
        End If
    End Sub
    Private Sub baca_konfig()
        'BACA KONFIG

        Dim sqldr As SqlDataReader
        'Dim sqlcfg As SqlDataReader
        'sqlcfg = New SqlCommand("", sqlconn).ExecuteReader
        'If sqlcfg.Read Then
        'End If
        'sqlcfg.Close()
        sqldr = New SqlCommand("SELECT " & _
"(select a.Nama as kt1 from m_konfig k left OUTER join anggota a on k.ketua1_id=a.nasabah_id) as kt1, " & _
"(select a.Nama from m_konfig k left OUTER join anggota a on k.ketua2_id=a.nasabah_id) as kt2, " & _
"(select a.Nama from m_konfig k left OUTER join anggota a on k.ketua3_id=a.nasabah_id) as kt3, " & _
"(select a.Nama from m_konfig k left OUTER join anggota a on k.ketua4_id=a.nasabah_id) as kt4, " & _
"(select a.Nama from m_konfig k left OUTER join anggota a on k.bendahara=a.nasabah_id) as bdhr, " & _
"(select a.Nama from m_konfig k left OUTER join anggota a on k.kabag_sppj=a.nasabah_id) as ksp, " & _
"(select a.Nama from m_konfig k left OUTER join anggota a on k.kabag_keu=a.nasabah_id) as keu, " & _
"(SELECT tgl_bns from m_konfig)  as tgl_bns, " & _
"(SELECT tgl_thr from m_konfig)  as tgl_thr, " & _
"(SELECT tgl_tat from m_konfig)  as tgl_tat", sqlconn).ExecuteReader
        sqldr.Read()
        If Not sqldr.HasRows Then
            MsgBox("Konfig tidak ada data", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Gagal konfig")
            'pnlLogin.Enabled = True
            'txtUsername.SelectAll()
            'txtUsername.Select()
            sqldr.Close()
            Exit Sub
        End If
        xbns = sqldr.Item("tgl_bns")
        xthr = sqldr.Item("tgl_thr")
        xtat = sqldr.Item("tgl_tat")
        kt1 = sqldr.Item("kt1")
        kt2 = sqldr.Item("kt2")
        kt3 = sqldr.Item("kt3")
        kt4 = sqldr.Item("kt4")
        kbgSP = sqldr.Item("ksp")
        kbKEU = sqldr.Item("keu")
        bendhr = sqldr.Item("bdhr")
        sqldr.Close()

    End Sub
    Private Sub btn_click(ByVal sender As Object, ByVal args As EventArgs)
        umum.userRole = sender.tag
        frmMain.Show()
        Me.Hide()
        frmBG.Dispose()
        txtPassword.Text = ""
        txtUsername.Text = ""
        layRole.RowStyles.Clear()
        pnlRole.Visible = False
        layRole.Visible = False
        pnlLogin.Enabled = True
        txtUsername.Focus()
    End Sub

    Private Sub cmdkeluar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdkeluar.Click
        End
    End Sub

    Private Sub cmbDb_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbDb.KeyPress
        If AscW(e.KeyChar) = 13 Then
            login()
        End If
    End Sub
End Class

