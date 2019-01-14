Public Class frmMessage
    Public dialog As String
    Private Sub TMR_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TMR.Tick
        If Me.Opacity > 0.3 Then
            Me.Opacity = Me.Opacity - 0.1
            Me.Refresh()
            If TMR.Interval > 100 Then
                TMR.Interval = TMR.Interval / 5
            End If
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub frmMessage_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If dialog <> "LOADING" then
            TMR.Enabled = True
        End If
        Me.Width = lblMsg.Width + lblMsg.Left + 20
        If dialog = "INFO" Then
            pnlError.Visible = False
            pnlInfo.Visible = True
            pnlWarning.Visible = False
            pnlLoading.Visible = False
        ElseIf dialog = "WARNING" Then
            pnlError.Visible = False
            pnlInfo.Visible = False
            pnlWarning.Visible = True
            pnlLoading.Visible = False
        ElseIf dialog = "ERROR" Then
            pnlError.Visible = True
            pnlInfo.Visible = False
            pnlWarning.Visible = False
            pnlLoading.Visible = False
        Else
            pnlError.Visible = False
            pnlInfo.Visible = False
            pnlWarning.Visible = False
            pnlLoading.Visible = True
        End If
    End Sub

    Private Sub frmMessage_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.SetStyle(ControlStyles.OptimizedDoubleBuffer, True)
        pnlError.Top = 0
        pnlInfo.Top = 0
        pnlWarning.Top = 0
        pnlLoading.Top = 0
    End Sub
End Class