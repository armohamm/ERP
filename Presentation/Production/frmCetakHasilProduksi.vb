Public Class frmCetakHasilProduksi
    Public no_rph As String
    Public vkddep As String
    Public tanggal1, tanggal2 As String
    Private Sub frmCetakRPH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        '   MsgBox(tanggal1 & "  s/d  " & tanggal2, MsgBoxStyle.Information)
    End Sub

    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        'MsgBox(kddep)
        'MsgBox(vkddep)
        'MsgBox(tanggal1)
        'MsgBox(tanggal2)

        If vkddep = "" Then
            callReport(App_Path() & "\report\Prod_Report_Harian.rpt", "", "tanggal=" & tanggal1 & " &tanggala=" & tanggal2 & " &kd_departemen=" & kddep)
        Else
            callReport(App_Path() & "\report\Prod_Report_Harian.rpt", "", "tanggal=" & tanggal1 & " &tanggala=" & tanggal2 & " &kd_departemen=" & vkddep, False, False)
            '(App_Path() & "\report\Prod_Report_Harian.rpt", "", "kd_departemen=" & vkddep & " &tanggal=" & tanggal1 & " &tanggala=" & tanggal2, False, False)

        End If
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        'MsgBox(kddep)
        'MsgBox(vkddep)

        If vkddep = "" Then
            callReport(App_Path() & "\report\Prod_Report_Harian_Rekap.rpt", "", "tanggal=" & tanggal1 & " &tanggala=" & tanggal2 & " &kd_departemen=" & kddep)
        Else
            callReport(App_Path() & "\report\Prod_Report_Harian_Rekap.rpt", "", "tanggal=" & tanggal1 & " &tanggala=" & tanggal2 & " &kd_departemen=" & vkddep)
        End If
    End Sub
End Class