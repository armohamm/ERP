Imports System.IO
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Imports Microsoft.Win32
Imports System.Drawing
Imports DevExpress.XtraPrinting
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Enterprise.InfoStore
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Web
Imports CrystalDecisions.Windows.Forms

Module umum

    Public sqlconn As New SqlConnection
    Public username As String
    Public namauser As String
    Public kdcabang As String
    Public kddep As String
    Public kdpeg As String
    Public judulMain As String
    Public Perusahaan As String
    Public AlamatPerusahaan As String
    Public KotaPerusahaan As String
    Public tipetrans As String
    Public userRole As String
    Public uname As String
    Public passwd As String
    Public dbase As String
    Public xbns, xthr, xtat As Date
    Public kt1, kt2, kt3, kt4, kbgSP, bendhr, kbKEU As String
    Dim DAdb As SqlDataAdapter
    Dim dset As New DataSet
    Public coll_form As New Collection
    Public imgCol As New ImageList
    Public imgColBig As New ImageList
    Private begintrans As Boolean
    Dim reportHeader As String
    Dim sqlTran As SqlTransaction
    Public defaultPrinter As String
    Public Const KD_DEP_SPRING = " "
    Public Const KD_DEP_SPON = ""
    Public Const KD_DEP_SELLY = ""

    Public charge As Double = 0
    Public batas_tebal As Double
    Public batas_lebar As Double
    Public batas_panjang As Double

    Public Const batas_up_lebar = 80
    Public Const batas_up_panjang = 200

    Public Const up_lebar = 10
    Public Const up_panjang = 10

    Public pembulatan As Double() = {80, 90, 100, 120, 125, 140, 150, 160, 180, 200, 210, 220, 230, 240, 250}

    Public server_ip As String
    Public MarginService As Double = 20

    Public DB As String = "LOCAL"
    Public Const SillyUmum = "JPJ-KPT-03"

    Public Const SpringUmum = "JPJ-KPT-01"
    Public Const ReturSpringUmum = "JRR-KPT-01"
    Public Const SpringInternal = "JPJ-KPT-07"
    Public Const SpringBonus = "JPJ-KPT-12"

    Public Const SponUmum = "JPJ-KPT-02"
    Public Const ReturSponUmum = "JRR-KPT-02"
    Public Const SponInternal = "JPJ-KPT-08"
    Public Const SponBonus = "JPJ-KPT-13"

    Public Const CentianUmum = "JPJ-KPT-04"
    Public Const CentianInternal = "JPJ-KPT-09"

    Public Const ServiceSpringUmum = "JPJ-KPT-05"
    Public Const ServiceSpringInternal = "JPJ-KPT-10"
    Public Const ServiceSponUmum = "JPJ-KPT-06"
    Public Const ServiceSponInternal = "JPJ-KPT-11"

    Public Const SPKonsinyasi = "JPJ-KPT-14"
    Public Const SPKonsinyasiSpon = "JPJ-KPT-16"

    'Public Const ReturGudangIn = "JBM-KUT-05"
    Public Const ReturGudangIn = "JPP-KUT-07"

    Public Const BatasBayarSpon = 45
    Public Const BatasBayarSpring = 28


    Public Const KD_DIV_SPRING = "2"
    Public Const KD_DIV_SPON = "3"
    Public Const KD_DIV_SILLY = "4"
    Public Const KD_DIV_PPIC_INV = "6"

    Public Const KodeGudangBarangJadi = "G0001"
    Public Sub get_pembulatan(ByRef e As Object)

        If e.Row("panjang") > batas_up_panjang Then
            e.Row("panjang_up") = e.Row("panjang")
        Else
            e.Row("panjang_up") = batas_up_panjang
        End If
        For i As Int16 = 0 To pembulatan.Length - 1
            If pembulatan(i) >= e.Row("lebar") Then
                e.Row("lebar_up") = pembulatan(i)
                Exit Sub
            End If
        Next
    End Sub

    Public Sub get_pembulatan(ByRef e As DataRow)

        If e("panjang") > batas_up_panjang Then
            e("panjang_up") = e("panjang")
        Else
            e("panjang_up") = batas_up_panjang
        End If
        For i As Int16 = 0 To pembulatan.Length - 1
            If pembulatan(i) >= e("lebar") Then
                e("lebar_up") = pembulatan(i)
                Exit Sub
            End If
        Next
    End Sub
    Public Function GetRandomPasswordUsingGUID(ByVal length As Integer) As String
        'Get the GUID
        Dim guidResult As String = System.Guid.NewGuid().ToString()

        'Remove the hyphens
        guidResult = guidResult.Replace("-", String.Empty)

        'Make sure length is valid
        If length <= 0 OrElse length > guidResult.Length Then
            Throw New ArgumentException("Length must be between 1 and " & guidResult.Length)
        End If

        'Return the first length bytes
        Return guidResult.Substring(0, length)
    End Function
    Public Sub call_report(ByVal QueryStrings As String, ByVal TableNames As String, ByVal rptname As String)
        Dim ReportForm As New CrystalReportForm
        Dim TableName(0) As String
        Dim QueryString(0) As String
        TableName(0) = QueryStrings
        QueryString(0) = TableNames
        ReportForm.ViewReport(rptname, TableName, QueryString)
    End Sub
    Public Sub isi_parameter()
        With New SqlCommand("select Val_kode1 from KOPKAR.dbo.sif_gen_reff where Ref_Role='SOBOX' and id_ref_file='CHARGE' and rec_stat='Y'", sqlconn).ExecuteReader
            .Read()
            If .HasRows Then charge = .Item(0)
            .Close()
        End With
        With New SqlCommand("select id_data, Desc_Data from KOPKAR.dbo.SIF_Gen_Reff_D where ref_role ='SOBOX' and id_ref_file='CHARGE' and rec_stat='Y'", sqlconn).ExecuteReader
            While .Read
                If .Item(1) = "t" Then batas_tebal = .Item(0)
                If .Item(1) = "l" Then batas_lebar = .Item(0)
                If .Item(1) = "p" Then batas_panjang = .Item(0)
            End While
            .Close()
        End With
    End Sub
    Public Class CrystalReportForm

        Friend Sub ViewReport(ByVal ReportName As String, ByVal TableName() As String, ByVal QueryString() As String, Optional ByVal [Parameter] As String = "")
            If Not UBound(TableName).Equals(UBound(QueryString)) Then MessageBox.Show("Passed Variable Are Not Correct", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information) : Exit Sub
            Dim Report As CrystalDecisions.CrystalReports.Engine.ReportDocument = New CrystalDecisions.CrystalReports.Engine.ReportDocument
            Dim CrystalReportViewer As CrystalDecisions.Windows.Forms.CrystalReportViewer = New CrystalDecisions.Windows.Forms.CrystalReportViewer
            CrystalReportViewer.ActiveViewIndex = 0
            CrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            CrystalReportViewer.DisplayGroupTree = False
            CrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
            CrystalReportViewer.Location = New System.Drawing.Point(0, 0)
            CrystalReportViewer.Name = "CrystalReportViewer"
            Dim Adapter As New OleDb.OleDbDataAdapter
            Dim DataSet As New DataSet
            For I As Integer = 0 To UBound(TableName)
                Adapter.Fill(DataSet, TableName(I))
            Next
            'Report In the report Folder
            Report.Load(Application.StartupPath & "/Report/" & ReportName & "")
            'Report.Database.Tables(0).SetDataSource()
            If Not [Parameter] = "" Then Report.SetParameterValue(0, [Parameter])
            CrystalReportViewer.ReportSource = Report
            'Me.Panel1.Controls.Add(CrystalReportViewer)
            CrystalReportViewer.Show()
        End Sub

    End Class
    Public Sub getDefaultPrinterName()
        Dim oPS As New System.Drawing.Printing.PrinterSettings
        Try
            defaultPrinter = oPS.PrinterName
        Catch ex As System.Exception
            defaultPrinter = ""
        Finally
            oPS = Nothing
        End Try
    End Sub
    Public Function decode_aktif(ByVal prm As String) As String
        Return IIf(UCase(prm) = "AKTIF", "Y", "T")
    End Function
    Public Function encode_aktif(ByVal prm As String) As String
        Return IIf(UCase(prm) = "Y", "AKTIF", "TIDAK AKTIF")
    End Function
    Public Function getTanggal(Optional ByVal btrans As Object = Nothing) As DateTime
        Dim dr As SqlDataReader
        Dim result As Date

        If btrans Is Nothing Then
            dr = New SqlCommand("select getDate()", sqlconn).ExecuteReader
        Else
            dr = New SqlCommand("select getDate()", sqlconn, btrans).ExecuteReader
        End If
        dr.Read()
        result = dr(0)
        dr.Close()
        dr = Nothing
        Return result
    End Function
    Public Function AES_Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
        End Try
    End Function
    Public Sub showHidePnl()


    End Sub

    Public Function AES_Decrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(input)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
        End Try
    End Function
    Public Function gettipeTrans(ByVal kd_jurnal As String, Optional ByVal jns_so As String = "UMUM", Optional ByVal nota As String = "PENJUALAN") As String
        Dim dr As SqlDataReader = New SqlCommand("select * from KOPKAR.dbo.sif_tipe_trans where kd_jurnal='" & kd_jurnal & "' and kd_dept='" & kddep & "' and UPPER(tipe_desc) like '%" & jns_so & "%' and UPPER(tipe_desc) like '%" & nota & "%'", sqlconn).ExecuteReader
        Dim hasil As String = ""
        dr.Read()

        If dr.HasRows Then
            hasil = dr("tipe_trans")
        End If
        dr.Close()
        dr = Nothing
        Return hasil

    End Function
    Public Function RegValue(ByVal Hive As RegistryHive, _
        ByVal Key As String, ByVal ValueName As String, _
        Optional ByRef ErrInfo As String = "") As String

        Dim objParent As RegistryKey
        Dim objSubkey As RegistryKey
        Dim sAns As String
        Select Case Hive
            Case RegistryHive.ClassesRoot
                objParent = Registry.ClassesRoot
            Case RegistryHive.CurrentConfig
                objParent = Registry.CurrentConfig
            Case RegistryHive.CurrentUser
                objParent = Registry.CurrentUser
            Case RegistryHive.DynData
                objParent = Registry.DynData
            Case RegistryHive.LocalMachine
                objParent = Registry.LocalMachine
            Case RegistryHive.PerformanceData
                objParent = Registry.PerformanceData
            Case RegistryHive.Users
                objParent = Registry.Users

        End Select

        Try
            'if can't be found, object is not initialized
            If Not objSubkey Is Nothing Then
                sAns = (objSubkey.GetValue(ValueName))
            End If
        Catch ex As Exception

            ErrInfo = ex.Message
        Finally

            'if no error but value is empty, populate errinfo
            If ErrInfo = "" And sAns = "" Then
                ErrInfo = _
                   "No value found for requested registry key"
            End If
        End Try
        Return sAns
    End Function
    Public Function getParent(ByVal frm As Form) As frmMain
        Return frmMain
    End Function
    Public Function App_Path() As String
        Return Application.StartupPath()
    End Function
    Public Sub showMessages(ByVal msg As String, Optional ByVal fontsize As Single = 16, Optional ByVal dialog As String = "INFO")
        frmMessage.dialog = dialog
        frmMessage.lblMsg.Text = msg
        frmMessage.lblMsg.Font = New Font(frmMessage.lblMsg.Font.FontFamily, fontsize, FontStyle.Italic)
        frmMessage.lblMsg2.Text = msg
        frmMessage.lblMsg2.Font = New Font(frmMessage.lblMsg.Font.FontFamily, fontsize, FontStyle.Italic)
        frmMessage.lblMsg3.Text = msg
        frmMessage.lblMsg3.Font = New Font(frmMessage.lblMsg.Font.FontFamily, fontsize, FontStyle.Italic)
        frmMessage.lblMsg4.Text = msg
        frmMessage.lblMsg4.Font = New Font(frmMessage.lblMsg.Font.FontFamily, fontsize, FontStyle.Italic)
        If dialog <> "LOADING" Then
            frmMessage.ShowDialog()
        Else

            frmMessage.Show()
            frmMessage.Top = frmMain.Height / 2
            frmMessage.Left = (frmMain.Width - frmMessage.Width) / 2
        End If
    End Sub
    Public Sub collect_image()
        Dim strFileSize As String = ""
        Dim di As New IO.DirectoryInfo(App_Path() & "\icons")
        Dim aryFi As IO.FileInfo() = di.GetFiles("*.ico")
        Dim fi As IO.FileInfo
        imgCol.ColorDepth = ColorDepth.Depth16Bit
        Dim i As Int16 = 0

        For Each fi In aryFi
            Try
                If fi.Extension = "ico" Then
                    imgCol.Images.Add(i, New Icon(fi.FullName))
                    imgColBig.Images.Add(i, New Icon(fi.FullName))
                Else
                    imgCol.Images.Add(i, Image.FromFile(fi.FullName))
                    imgColBig.Images.Add(i, Image.FromFile(fi.FullName))
                End If
                i += 1
            Catch ex As Exception

            End Try
        Next
        imgCol.ImageSize = New Size(16, 16)
        imgColBig.ImageSize = New Size(32, 32)
    End Sub
    Public Function isNull(ByVal x As Object, ByVal ret As Object) As Object
        If x Is Nothing Or x.ToString = "" Then
            Return ret
        Else
            Return x
        End If
    End Function
    Public Sub connect()
        'Dim inicls As New INICLASS()
        'Dim inifile As String = App_Path() & "\ConString.ini"
        'If Not sqlconn.State = ConnectionState.Open Then
        '    server_ip = inicls.INIRead(inifile, "SETTING", "SERVER")

        '    'sqlconn.ConnectionString = AES_Decrypt(inicls.INIRead(inifile, "CSQL", "sif"), "mjtqs123")
        '    sqlconn.ConnectionString = inicls.INIRead(inifile, "CSQL", DB)

        '    If Not sqlconn.State = ConnectionState.Open Then
        '        Try
        '            sqlconn.Open()
        '        Catch ex As Exception
        '            MsgBox("Gagal Koneksi Ke Database! Hubungi Admin." & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error Connection")
        '            End
        '        End Try
        '    End If
        'End If
        Dim inicls As New INICLASS()
        Dim inifile As String = App_Path() & "\ConString.ini"
        If Not sqlconn.State = ConnectionState.Open Then
            server_ip = inicls.INIRead(inifile, "SETTING", "SERVER_BCA")
            'server_ip = inicls.INIRead(inifile, "SETTING", "SERVER")
            uname = inicls.INIRead(inifile, "SETTING", "UNAME")
            passwd = inicls.INIRead(inifile, "SETTING", "PASSWD")
            'dbase = inicls.INIRead(inifile, "SETTING", "DB")

            'sqlconn.ConnectionString = AES_Decrypt(inicls.INIRead(inifile, "CSQL", "sif"), "mjtqs123")
            sqlconn.ConnectionString = inicls.INIRead(inifile, "CSQL", DB)

            If Not sqlconn.State = ConnectionState.Open Then
                Try
                    sqlconn.Open()
                Catch ex As Exception
                    MsgBox("Gagal Koneksi Ke Database! Hubungi Admin." & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Error Connection")
                    End
                End Try
            End If
        End If
    End Sub
    Public Sub begin_trans()
        If Not begintrans Then
            sqlTran = sqlconn.BeginTransaction()
            begintrans = True
        End If
    End Sub
    Public Sub commit_Trans()
        If begintrans Then
            sqlTran.Commit()
            begintrans = False
        End If
    End Sub
    Public Sub rollback_trans()
        If begintrans Then
            sqlTran.Rollback()
            begintrans = False
        End If
    End Sub
    Public Sub createMenu(Optional ByVal Parent As String = vbNullString, Optional ByVal prnMenu As Object = vbNull)
        Dim menux As ToolStripMenuItem
        'Dim dsete As New DataSet
        Dim dr As SqlDataReader
        'Dim dadbe As SqlClient.SqlDataAdapter
        Dim i As Int16 = 0
        Dim j As Int16 = 0
        If umum.username = "admin" Then
            dr = New SqlClient.SqlCommand("select * from KOPKAR.dbo.menu where parent_menu ='" & Parent & "'  order by urutan", sqlconn).ExecuteReader
            'dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.menu where parent_menu ='" & Parent & "'  order by urutan", sqlconn))
        Else
            dr = New SqlClient.SqlCommand("select * from KOPKAR.dbo.menu where parent_menu ='" & Parent & "' and  exists (select 1 from KOPKAR.dbo.role_menu where idrole='" & umum.userRole & "' and VALUE > 0 and  nm_menu=kode_menu)  order by urutan", sqlconn).ExecuteReader
            'dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from sif.dbo.menu where parent_menu ='" & Parent & "' and  exists (select 1 from sif.dbo.role_menu where idrole='" & umum.userRole & "' and VALUE > 0 and nm_menu=kode_menu)  order by urutan", sqlconn))
        End If

        'dadbe.Fill(dsete, "menu")
        '        For i = 0 To dsete.Tables(0).Rows.Count - 1
        i = 0

        While dr.Read
            ' j = IIf(dsete.Tables(0).Rows(i).Item("img") = vbNull, 0, dsete.Tables(0).Rows(i).Item("img"))
            j = IIf(dr("img") = vbNull, 0, dr("img")) 'dsete.Tables(0).Rows(i).Item("img"))
            menux = New ToolStripMenuItem("", imgCol.Images.Item(j), AddressOf umum.menu_click)
            menux.Text = dr("caption").ToString  'dsete.Tables(0).Rows(i).Item("caption").ToString
            menux.Name = dr("nm_menu").ToString 'dsete.Tables(0).Rows(i).Item("nm_menu").ToString
            If TypeOf prnMenu Is MenuStrip Then
                menux.ForeColor = Color.WhiteSmoke
                menux.Owner = prnMenu
                menux.Tag = "Header"
            Else
                prnMenu.DropDownItems.Add(menux)
                menux.Tag = dr("call_form").ToString 'dsete.Tables(0).Rows(i).Item("call_form").ToString
            End If
            createMenu(menux.Name, menux)
            i += 1
        End While
        dr.Close()
        'Next i

        If i > 0 Then
            prnMenu.Tag = "Header"
        End If

        'dadbe.Dispose()
        'dsete.Dispose()
    End Sub
    Public Sub menu_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nbil As DevExpress.XtraNavBar.NavBarItem
        Dim i As Integer
        Dim obj, nbg As Object
        Dim exists As Boolean = False
        Dim link As Object
        If sender.tag.ToString <> "Header" Then
            For Each nbg In frmMain.NBC.Groups
                For i = 0 To nbg.ItemLinks.Count - 1
                    If nbg.ItemLinks(i).ItemName = sender.tag.ToString Then
                        link = nbg.ItemLinks(i)
                        exists = True
                        Exit For
                    End If
                Next
            Next
            If exists Then
                frmMain.NBC.SelectedLink = link
                frmMain.NBC.SelectedLink.Group.Expanded = True
                frmMain.NBC.SelectedLink.PerformClick()
            Else
                nbil = frmMain.NBC.Items.Add
                nbil.Caption = sender.text
                nbil.Tag = sender.text
                nbil.Hint = sender.text
                nbil.Name = sender.tag.ToString
                nbil.SmallImage = sender.image
                If frmMain.NBG.Caption = "" Then
                    frmMain.NBG.Caption = sender.OwnerItem.Text
                    frmMain.NBG.SmallImage = sender.OwnerItem.image
                    frmMain.NBG.Name = sender.OwnerItem.name
                    obj = frmMain.NBG.ItemLinks.Add(nbil)
                Else
                    nbg = frmMain.NBC.Groups(sender.OwnerItem.name)
                    If nbg Is Nothing Then nbg = frmMain.NBC.Groups.Add
                    nbg.Expanded = True
                    nbg.Appearance.Font = frmMain.NBG.Appearance.Font
                    nbg.Caption = sender.OwnerItem.Text
                    nbg.SmallImage = sender.OwnerItem.image
                    nbg.name = sender.OwnerItem.name
                    obj = nbg.ItemLinks.Add(nbil)
                End If
                Call frmMain.NBC_LinkClicked(nbil, New DevExpress.XtraNavBar.NavBarLinkEventArgs(obj))
            End If
        End If
    End Sub
    Public Sub call_form_manual(ByVal frmname As String)
        Dim nbil As DevExpress.XtraNavBar.NavBarItem
        Dim i As Integer
        Dim obj, nbg As Object
        Dim exists As Boolean = False
        Dim link As Object

        For Each nbg In frmMain.NBC.Groups
            For i = 0 To nbg.ItemLinks.Count - 1
                If nbg.ItemLinks(i).ItemName = frmname Then
                    link = nbg.ItemLinks(i)
                    exists = True
                    Exit For
                End If
            Next
        Next
        If exists Then
            frmMain.NBC.SelectedLink = link
            frmMain.NBC.SelectedLink.Group.Expanded = True
            frmMain.NBC.SelectedLink.PerformClick()
        Else
            nbil = frmMain.NBC.Items.Add
            nbil.Caption = frmname
            nbil.Tag = frmname
            nbil.Hint = frmname
            nbil.Name = frmname

            nbg = frmMain.NBC.ActiveGroup
            obj = nbg.ItemLinks.Add(nbil)
            Call frmMain.NBC_LinkClicked(nbil, New DevExpress.XtraNavBar.NavBarLinkEventArgs(obj))
        End If
    End Sub
    Public Function formatNumber(ByVal angka As String) As String
        Dim hasil As String
        Dim temp As String
        Dim j As Int16 = 1
        Dim b As Boolean = False
        Dim p As Int16 = Len(angka)
        For i = 1 To p
            temp = Left(Right(angka, i), 1)
            If temp <> "," Then
                If j Mod 3 = 0 And i < p Then
                    hasil = "," & temp & hasil
                    j = 1
                Else
                    hasil = Left(Right(angka, i), 1) & hasil
                    j += 1
                End If
            Else
                hasil = Left(Right(angka, i), 1) & hasil
                If i < 3 Then hasil = hasil & "0"
                j = 1
                b = True
            End If
        Next
        Return hasil & If(b, "", ".00")
    End Function
    Public Function GetFormByName(ByVal formName As String) As Object
        Dim myasm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Try
            Return myasm.CreateInstance(myasm.GetName.Name.Replace(" ", "_") & "." & formName)
        Catch ex As Exception
            Return Nothing

        End Try
    End Function
    Public Sub add_pnl(ByVal frm As Form)
        Dim pnl As New DevExpress.XtraEditors.PanelControl
        Dim btn As New DevExpress.XtraEditors.SimpleButton
        pnl.Dock = DockStyle.Bottom
        pnl.Parent = frm
        AddHandler btn.Click, AddressOf HOOKED_ME
        pnl.Size = New Size(0, 40)
        btn.Size = New Size(65, 35)
        pnl.Visible = False
        btn.Visible = True
        btn.Text = "Tautkan"

        pnl.BackColor = Color.Azure
        btn.Parent = pnl
        pnl.Name = "pnlHook"
        btn.Dock = DockStyle.Right

    End Sub
    Public Sub frm_ParentChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If sender.Parent Is Nothing Then
            sender.controls("pnlHook").Visible = True
        Else
            sender.controls("pnlHook").Visible = False
        End If
    End Sub
    Public Sub HOOKED_ME(ByVal sender As Object, ByVal e As System.EventArgs) 'ByVal FRM As Object)
        Dim NBIL As Object
        Dim OBJ As Object
        Dim frm As Object

        OBJ = sender.parent

        While Not TypeOf OBJ Is Form
            OBJ = OBJ.parent
        End While
        frm = OBJ
        AddHandler DirectCast(frm, Form).Disposed, AddressOf frmMain.FORM_DISPOSED
        AddHandler DirectCast(frm, Form).ParentChanged, AddressOf frm_ParentChanged

        frmMain.FORM_DISPOSED(frm, New System.EventArgs)
        coll_form.Add(frm, frm.NAME)
        set_pos_frm(frm)
        frmMain.pnlDisplay2.Controls.Add(frm)

        frm.Show()
        NBIL = frmMain.NBC.Items.Add
        NBIL.Caption = frm.TEXT
        NBIL.Name = frm.NAME
        'NBIL.SmallImage = FRM.icon
        OBJ = frmMain.NBG.ItemLinks.Add(NBIL)
        Call frmMain.NBC_LinkClicked(NBIL, New DevExpress.XtraNavBar.NavBarLinkEventArgs(OBJ))

    End Sub
    Public Sub set_pos_frm(ByVal frm As Object)
        frm.TopLevel = False
        frm.Left = 0
        frm.Top = 0
        frm.FormBorderStyle = 0
        frm.WindowState = FormWindowState.Normal
        frm.Controls("pnlHook").Visible = False
        resizeForm(frm)
    End Sub
    Public Sub resizeForm(ByVal obj As Object)

        If obj.Controls("pnl").Dock = DockStyle.Fill Then
            frmMain.pnlDisplay2.AutoScroll = False
            obj.Size = frmMain.pnlDisplay2.Size
        Else
            frmMain.pnlDisplay2.AutoScroll = True
            frmMain.centerMe()
        End If
    End Sub
    Public Sub FillSales(ByRef sales As DevExpress.XtraEditors.LookUpEdit)
        Dim dsete As New DataSet
        Dim dadbe As SqlClient.SqlDataAdapter
        dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select kode_sales as Kode, Nama from msalesman", sqlconn))

        dadbe.Fill(dsete, "MSALESMAN")
        sales.Properties.DataSource = dsete.Tables("MSALESMAN")

        sales.Properties.ValueMember = "Kode"
        sales.Properties.DisplayMember = "Nama"
        dsete.Dispose()
        dadbe.Dispose()
    End Sub
    Public Sub fade_out(ByVal frm As Form)
        Dim iCount As Integer
        frm.Opacity = 0.99
        For iCount = 90 To 10 Step -10
            frm.Opacity = iCount / 100
            frm.Refresh()
            Threading.Thread.Sleep(50)
        Next

        frm.Close()

    End Sub
    Public Sub fade_in(ByVal frm As Form)
        Dim iCount As Integer
        Dim i As Integer = 5
        While iCount < 100
            frm.Opacity = iCount / 100
            frm.Refresh()
            iCount = iCount + i
            i = i + 2
        End While
        frm.Opacity = 0.99
    End Sub
    Public Sub default_add(ByRef prn As frmMain)
        With prn '<- untuk sementara dimatika klau sudah digabung dengan form main ini dinyalakan lagi
            .btnAdd.Enabled = False ' mendisable tombol add yang ada di frmUtama
            .btnCancel.Enabled = True
            .btnDelete.Enabled = False
            .btnEdit.Enabled = False
            .btnSave.Enabled = True
        End With
    End Sub
    Public Sub default_cancel(ByRef prn As frmMain)
        With prn '<- untuk sementara dimatika klau sudah digabung dengan form main ini dinyalakan lagi
            .btnAdd.Enabled = True ' mendisable tombol add yang ada di frmUtama
            .btnCancel.Enabled = False
            .btnDelete.Enabled = False
            .btnEdit.Enabled = True
            .btnSave.Enabled = False
        End With
    End Sub
    Public Sub Fade(ByRef picBox As PictureBox, ByVal Interval As Double)
        'Interval in seconds
        If Interval <= 0 Then Exit Sub

        Dim [then] As Double = DateAndTime.Timer
        Dim PercentRemaining As Double = 0

        'Keep fading the image while there's still time
        Do While PercentRemaining < 1

            FadeBitmap(picBox.BackgroundImage, 255 - (255 * PercentRemaining))

            'redraw the picBox so it shows the new faded image
            picBox.Invalidate()
            picBox.Update()

            'Calculate the % of time remaining
            PercentRemaining = (DateAndTime.Timer - [then]) / Interval
        Loop
        FadeBitmap(picBox.BackgroundImage, 0)
    End Sub
    Public Sub FadeBitmap(ByRef BitmapToFade As Bitmap, ByRef Alpha As Double)
        If Alpha > 255 Then Alpha = 255
        If Alpha < 0 Then Alpha = 0

        Dim bmpData As System.Drawing.Imaging.BitmapData = _
            BitmapToFade.LockBits(New Rectangle(Point.Empty, BitmapToFade.Size), _
                                  Imaging.ImageLockMode.ReadWrite, _
                                  BitmapToFade.PixelFormat)
        Dim ptr As IntPtr = bmpData.Scan0
        Dim Bytes(bmpData.Stride * BitmapToFade.Height - 1) As Byte

        System.Runtime.InteropServices.Marshal.Copy(ptr, Bytes, 0, Bytes.Length)

        For i = 3 To UBound(Bytes) Step 4
            Bytes(i) = Alpha
        Next

        System.Runtime.InteropServices.Marshal.Copy(Bytes, 0, ptr, Bytes.Length)

        BitmapToFade.UnlockBits(bmpData)
        bmpData = Nothing
        Bytes = Nothing
        ptr = IntPtr.Zero
    End Sub
    Private Const AW_BLEND = &H80000  'Uses a fade effect. This flag can be used only if hwnd is a top-level window.
    Private Declare Function AnimateWindow Lib "user32" (ByVal hwnd As Int32, ByVal dwTime As Int32, ByVal dwFlags As Int32) As Boolean
    Dim winHide As Integer = &H10000
    Dim winBlend As Integer = &H80000
    Sub AnimatedMe(ByVal saya As Form)
        AnimateWindow(saya.Handle.ToInt32, CInt(500), AW_BLEND)
    End Sub
    Public Function callReport(ByVal rptName As String, ByVal formulas As String, ByVal params As String, Optional ByVal cetak_langsung As Boolean = False, Optional ByVal use_login As Boolean = False, Optional ByVal Ukurankertas As String = "", Optional ByVal toolbar As Boolean = True) As Boolean
        Dim objForm As New frmViewReport
        'Dim tbl As New DataTable
        'Dim dadbe As SqlDataAdapter
        'dadbe = New SqlClient.SqlDataAdapter(New SqlClient.SqlCommand("select * from american_report.DBO.VSO_REP", sqlconn))
        'dadbe.Fill(tbl)
        objForm.use_login = use_login
        objForm.cetak_langsung = cetak_langsung
        objForm.kertas = Ukurankertas
        objForm.ToolBar = toolbar
        'objForm.tblName = "VSO_REP"
        'objForm.dtble = tbl
        If objForm.ViewReport(rptName, formulas, params) Then
            callReport = True
            If Not cetak_langsung Then objForm.Show()
        Else
            callReport = False
        End If
    End Function
    Public Function get_next_So(Optional ByVal btrans As SqlTransaction = Nothing) As String
        Dim cmd As New SqlCommand
        cmd.Connection = sqlconn
        If Not btrans Is Nothing Then
            cmd.Transaction = btrans
        End If
        cmd.CommandText = "SALES.[dbo].[GET_COUNTER_NUMBER_SO]"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@XJENIS_TRANSAKSI", SqlDbType.VarChar, 10)
        cmd.Parameters.Add("@XHASIL", SqlDbType.VarChar, 30)
        cmd.Parameters("@XHASIL").Direction = ParameterDirection.Output
        cmd.Parameters("@XJENIS_TRANSAKSI").Value = "SO"
        cmd.ExecuteNonQuery()
        get_next_So = CType(cmd.Parameters("@XHASIL").Value, String)

    End Function
    Public Function get_set_pinter(ByRef dok As String) As Boolean
        With New SqlCommand("select langsung from sales.dbo.SALES_SETING_CETAK_DOK where cetak_dok = '" & dok & "'", sqlconn).ExecuteReader
            .Read()
            If .HasRows Then : get_set_pinter = .Item(0)
            Else : get_set_pinter = 0
            End If
            .Close()
        End With
    End Function
    Public Function get_next_counter(ByVal param As String, Optional ByVal btrans As SqlTransaction = Nothing) As String
        Dim cmd As New SqlCommand
        cmd.Connection = sqlconn
        If Not btrans Is Nothing Then cmd.Transaction = btrans
        cmd.CommandText = "SALES.[dbo].[GET_COUNTER_NUMBER]"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@XJENIS_TRANSAKSI", SqlDbType.VarChar, 10)
        cmd.Parameters.Add("@XHASIL", SqlDbType.VarChar, 30)
        cmd.Parameters("@XHASIL").Direction = ParameterDirection.Output
        cmd.Parameters("@XJENIS_TRANSAKSI").Value = param
        cmd.ExecuteNonQuery()
        get_next_counter = CType(cmd.Parameters("@XHASIL").Value, String)
    End Function
    Public Function get_next_counter_master(ByVal param As String, Optional ByVal btrans As SqlTransaction = Nothing) As String
        Dim cmd As New SqlCommand
        cmd.Connection = sqlconn
        If Not btrans Is Nothing Then cmd.Transaction = btrans
        cmd.CommandText = "SALES.[dbo].[GET_COUNTER_NUMBER_MASTER]"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@XJENIS_TRANSAKSI", SqlDbType.VarChar, 10)
        cmd.Parameters.Add("@XHASIL", SqlDbType.VarChar, 30)
        cmd.Parameters("@XHASIL").Direction = ParameterDirection.Output
        cmd.Parameters("@XJENIS_TRANSAKSI").Value = param
        cmd.ExecuteNonQuery()
        get_next_counter_master = CType(cmd.Parameters("@XHASIL").Value, String)
    End Function
    Public Function getNoTrans(ByVal kdBukti As String, ByVal tgl As Date, Optional ByVal btrans As SqlTransaction = Nothing) As String
        Dim sqlcmd As New SqlCommand
        sqlcmd.Connection = sqlconn
        If Not btrans Is Nothing Then
            sqlcmd.Transaction = btrans
        End If
        sqlcmd.CommandType = CommandType.StoredProcedure
        sqlcmd.CommandText = "KOPKAR.dbo.sifp_get_no_trans"
        sqlcmd.Parameters.Add("@vkd_bukti", SqlDbType.VarChar, 10)
        sqlcmd.Parameters.Add("@vtgl_trans", SqlDbType.Date)
        sqlcmd.Parameters.Add("@vno_trans", SqlDbType.VarChar, 100)
        sqlcmd.Parameters("@vkd_bukti").Value = kdBukti
        sqlcmd.Parameters("@vtgl_trans").Value = tgl
        sqlcmd.Parameters("@vno_trans").Direction = ParameterDirection.Output
        sqlcmd.ExecuteNonQuery()
        Return sqlcmd.Parameters("@vno_trans").Value.ToString
    End Function
    Public Sub print_gc(ByVal xGc As Object, ByVal xreportHeader As String, Optional ByVal xLandscape As Boolean = False, Optional ByRef ukurankertas As System.Drawing.Printing.PaperKind = Printing.PaperKind.A4, Optional ByRef infotambahan As String = "")
        Dim ps As New PrintingSystem()
        Dim link As New PrintableComponentLink(ps)
        Dim ph As DevExpress.XtraPrinting.PageHeaderFooter = CType(link.PageHeaderFooter, PageHeaderFooter)
        ph.Header.Content.Add(umum.Perusahaan & vbCrLf & umum.AlamatPerusahaan & vbCrLf & umum.KotaPerusahaan)
        ph.Header.Content.Add(xreportHeader)
        ph.Header.Content.Add(infotambahan)

        ph.Header.LineAlignment = BrickAlignment.Near
        ph.Footer.Content.Add(username)
        ph.Footer.Content.Add("Page : [Page # of Pages #]")
        ph.Footer.Content.Add("Print Date : " & getTanggal.ToShortDateString())
        ph.Header.Font = New Font("Tahoma", 10, FontStyle.Bold)

        link.Component = xGc
        link.Margins.Left = 4
        link.Margins.Right = 4
        link.Margins.Bottom = 40
        link.Margins.Top = 90
        link.PaperKind = ukurankertas
        link.Landscape = xLandscape
        link.VerticalContentSplitting = VerticalContentSplitting.Smart
        link.CreateDocument()
        link.ShowPreview()

    End Sub
    Private Sub PrintableComponentLink1_CreateReportHeaderArea(ByVal sender As System.Object, _
    ByVal e As CreateAreaEventArgs)
        e.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        e.Graph.Font = New Font("Tahoma", 12, FontStyle.Bold)
        Dim rec As RectangleF = New RectangleF(0, 0, e.Graph.ClientPageSize.Width, 50)
        e.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None)
        e.Graph.DrawString(getTanggal.ToShortDateString, Color.Black, rec, BorderSide.Bottom)
    End Sub
    Public Function getKodeCabang()
        DAdb = New SqlDataAdapter(New SqlCommand("select Param_SubNo from KOPKAR.dbo.SIF_Parameter where Param_No='0'", sqlconn)) '<- query buat ditampilkan di LOV
        DAdb.Fill(dset, "kdCabang")
        kdcabang = dset.Tables("kdCabang").Rows(0)("Param_SubNo")
        Return kdcabang
    End Function
    Public Function cek_status_DPM(ByVal xdpm As String)
        Dim hasil, hasil1 As String
        Dim hasil2, hasil3 As Integer
        Dim sqlrd As SqlDataReader = New SqlCommand(" select rec_stat from purc.dbo.purc_dpm where no_dpm = '" & xdpm & "' ", sqlconn).ExecuteReader
        sqlrd.Read()
        hasil1 = sqlrd.Item(0)
        If hasil1 = "APPROVE" Then
            Dim sqlrd2 As SqlDataReader = New SqlCommand(" select count(no_po) from purc.dbo.v_mon_pencapaianDPM where no_dpm = '" & xdpm & "' ", sqlconn).ExecuteReader
            sqlrd2.Read()
            hasil2 = sqlrd2.Item(0)
            If hasil2 > 0 Then
                hasil = "Proses PO"
            Else
                Dim sqlrd3 As SqlDataReader = New SqlCommand(" select count(no_pr) from purc.dbo.v_mon_pencapaianDPM where no_dpm = '" & xdpm & "' ", sqlconn).ExecuteReader
                sqlrd3.Read()
                hasil3 = sqlrd3.Item(0)
                If hasil3 > 0 Then
                    hasil = "Proses PR"
                Else
                    hasil = "Approve Direksi"
                End If
                sqlrd3.Close()
            End If
            sqlrd2.Close()
        ElseIf hasil1 = "ENTRY" Then
            hasil = "Entry"
        ElseIf hasil1 = "REJECT" Then
            hasil = "Reject"
        End If
        sqlrd.Close()

        Return hasil
    End Function
    Public Function cek_status_PO(ByVal xpo As String)
        Dim hasil, hasil1 As String
        Dim hasil2, hasil3, hasil5 As Integer
        Dim sqlrd As SqlDataReader = New SqlCommand(" select rec_stat from purc.dbo.purc_po where no_po = '" & xpo & "' ", sqlconn).ExecuteReader
        sqlrd.Read()
        hasil1 = sqlrd.Item(0)
        If hasil1 = "APPROVE" Then
            Dim sqlrd2 As SqlDataReader = New SqlCommand(" select count(no_ref) from purc.dbo.v_gudang_in where no_ref = '" & xpo & "' ", sqlconn).ExecuteReader
            sqlrd2.Read()
            hasil2 = sqlrd2.Item(0)
            If hasil2 > 0 Then
                Dim sqlrd3 As SqlDataReader = New SqlCommand(" select sum(bf.saldo_akhir) akhire " & _
                                        "from(select x.kd_stok, x.qty, y.jml_qty, x.qty-y.jml_qty saldo_akhir " & _
                                        "from (select a.no_po, b.kd_stok, sum(b.qty) qty " & _
                                                " from purc.dbo.PURC_PO a, purc.dbo.PURC_PO_d b" & _
                                                " where a.no_po = b.no_po and a.no_po= '" & xpo & "' " & _
                                                " group by a.no_po, b.kd_stok) x, " & _
                                            " (select c.no_ref, c.kd_stok, sum(c.jumlah) jml_qty " & _
                                            "from purc.dbo.v_gudang_in c where c.no_ref= '" & xpo & "' " & _
                                            "group by c.no_ref, c.kd_stok) y " & _
                                        " where x.no_po = y.no_ref and x.kd_stok = x.kd_stok) bf ", sqlconn).ExecuteReader
                sqlrd3.Read()
                hasil3 = sqlrd3.Item(0)
                If hasil3 = 0 Then
                    hasil = "Delivered"
                Else
                    hasil = "Outstanding Qty"
                End If
                sqlrd3.Close()
            Else
                Dim sqlrd5 As SqlDataReader = New SqlCommand(" select isnull(jml_cetak,0) from purc.dbo.purc_po where no_po = '" & xpo & "' ", sqlconn).ExecuteReader
                sqlrd5.Read()
                hasil5 = sqlrd5.Item(0)
                If hasil5 > 0 Then
                    hasil = "Approve, Sudah tercetak"
                Else
                    hasil = "Approve, Belum tercetak"
                End If
                sqlrd5.Close()
            End If
            sqlrd2.Close()
        ElseIf hasil1 = "ENTRY" Then
            hasil = "Entry"
        ElseIf hasil1 = "REJECT" Then
            hasil = "Reject"
        End If
        sqlrd.Close()

        Return hasil

    End Function
    Public Function blthn(Optional ByVal btrans As Object = Nothing) As String
        Dim hasil As String
        Dim sqlblth As SqlDataReader
        If btrans Is Nothing Then
            'blthn=082011 select (select kd2 from m_bulan where kode=SUBSTRING(CONVERT(nvarchar(6),getdate(), 112),3,2))+ (select kd2 from m_bulan where kode=SUBSTRING(CONVERT(nvarchar(6),getdate(), 112),5,2))
            'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn).ExecuteReader
            '##blthn=201108
            'sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),1,6)as blthn", sqlconn).ExecuteReader
            sqlblth = New SqlCommand("select KOPKAR.dbo.getkodeperiode()", sqlconn).ExecuteReader
        Else
            'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn, btrans).ExecuteReader
            'sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),1,6)as blthn", sqlconn).ExecuteReader
            sqlblth = New SqlCommand("select KOPKAR.dbo.getkodeperiode()", sqlconn).ExecuteReader
        End If
        sqlblth.Read()
        hasil = sqlblth.Item(0)
        'End If
        sqlblth.Close()
        Return hasil
    End Function

    Public Function code_blthn(Optional ByVal btrans As Object = Nothing) As String
        Dim hasil As String
        Dim sqlblth As SqlDataReader
        If btrans Is Nothing Then
            'blthn=082011 select (select kd2 from m_bulan where kode=SUBSTRING(CONVERT(nvarchar(6),getdate(), 112),3,2))+ (select kd2 from m_bulan where kode=SUBSTRING(CONVERT(nvarchar(6),getdate(), 112),5,2))
            'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn).ExecuteReader
            '##blthn=201108
            'sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),1,6)as blthn", sqlconn).ExecuteReader
            sqlblth = New SqlCommand("select (select kd2 from m_bulan where kode=SUBSTRING(CONVERT(nvarchar(6),getdate(), 112),3,2))+ (select kd2 from m_bulan where kode=SUBSTRING(CONVERT(nvarchar(6),getdate(), 112),5,2))", sqlconn).ExecuteReader
        Else
            'sqlblth = New SqlCommand("select replace(substring(convert(varchar,getdate(),105),4,7),'-','') as blthn", sqlconn, btrans).ExecuteReader
            'sqlblth = New SqlCommand("select SUBSTRING(CONVERT(varchar,GETDATE(),112),1,6)as blthn", sqlconn).ExecuteReader
            sqlblth = New SqlCommand("select (select kd2 from m_bulan where kode=SUBSTRING(CONVERT(nvarchar(6),getdate(), 112),3,2))+ (select kd2 from m_bulan where kode=SUBSTRING(CONVERT(nvarchar(6),getdate(), 112),5,2))", sqlconn).ExecuteReader
        End If
        sqlblth.Read()
        hasil = sqlblth.Item(0)
        'End If
        sqlblth.Close()
        Return hasil
    End Function


End Module
