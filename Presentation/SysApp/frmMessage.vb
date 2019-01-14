Public Class frmMessage

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
        TMR.Enabled = True
        Me.Width = lblMsg.Width + lblMsg.Left + 20
    End Sub

End Class