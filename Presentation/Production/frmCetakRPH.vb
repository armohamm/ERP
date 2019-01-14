Public Class frmCetakRPH
    Public no_rph, Jenis_RPH As String
    Dim TemplatePur As String = "TemplateRPH"

    Private Sub frmCetakRPH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Jenis_RPH = ""
        no_rph = ""
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If Jenis_RPH = "RPHBUSA" Then
            callReport(App_Path() & "\report\crzRlsRph3.rpt", "", "NoRPH=" & no_rph & " &vnama_report=" & TemplatePur, False, False)
        Else
            callReport(App_Path() & "\report\crzRlsRph2.rpt", "", "NoRPH=" & no_rph & " &vnama_report=" & TemplatePur, False, False)

        End If
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        If Jenis_RPH = "RPHBUSA" Then
            callReport(App_Path() & "\report\crzRlsRphSetJadiSpon.rpt", "", "NoRPH=" & no_rph & " &vnama_report=" & TemplatePur, False, False)
        Else
            callReport(App_Path() & "\report\crzRlsRphSetJadi.rpt", "", "NoRPH=" & no_rph & " &vnama_report=" & TemplatePur, False, False)

        End If
    End Sub
End Class