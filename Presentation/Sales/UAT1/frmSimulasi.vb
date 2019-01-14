Public Class frmSimulasi 
    Public tbl As New DataTable
    Public vol As Double = 4000000
    Public ret As Boolean = False
    Private Sub frmSimulasi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'tbl.Columns.Add("T", System.Type.GetType("System.Double"))
        'tbl.Columns.Add("L", System.Type.GetType("System.Double"))
        'tbl.Columns.Add("P", System.Type.GetType("System.Double"))
        'tbl.Columns.Add("%", System.Type.GetType("System.Double"))
        'tbl.Columns.Add("V", System.Type.GetType("System.Double"))
        'tbl.Columns.Add("J", System.Type.GetType("System.Double"))
        'tbl.Columns.Add("Q", System.Type.GetType("System.Double"))
        'tbl.Columns.Add("QR", System.Type.GetType("System.Double"))
        'tbl.Columns.Add("QQ", System.Type.GetType("System.Double"))
        gc.DataSource = tbl
        vol = vol * lblQty.Text
        'Dim rw As DataRow
        'rw = tbl.NewRow
        'rw("T") = 5.5
        'rw("L") = 180
        'rw("P") = 200
        'tbl.Rows.Add(rw)
        'rw = tbl.NewRow
        'rw("T") = 8
        'rw("L") = 180
        'rw("P") = 200
        'tbl.Rows.Add(rw)
        'rw = tbl.NewRow
        'rw("T") = 10
        'rw("L") = 180
        'rw("P") = 200
        'tbl.Rows.Add(rw)
        'rw = tbl.NewRow
        'rw("T") = 2.5
        'rw("L") = 180
        'rw("P") = 200
        'tbl.Rows.Add(rw)
        'rw = tbl.NewRow
        'rw("T") = 15
        'rw("L") = 180
        'rw("P") = 200
        'tbl.Rows.Add(rw)

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim totT As Double
        Dim VxQ As Double = 0
        Dim VPakai As Double = 0
        Dim VR As Double = 0
        Dim PR As Double = 0
        Dim JR As Double = 0
        Dim Vsisa As Double
        totT = T.SummaryText
        For I As Int16 = 0 To gv.RowCount - 1
            tbls(I, "%", tbls(I, "T") / totT)
            tbls(I, "V", tbls(I, "T") * tbls(I, "L_UP") * tbls(I, "P_UP"))
            tbls(I, "J", vol * tbls(I, "%"))
            If I < gv.RowCount - 1 Then
                tbls(I, "Q", Math.Floor(tbls(I, "J") / tbls(I, "V")))
                VxQ = VxQ + (tbls(I, "V") * tbls(I, "Q"))
            Else
                tbls(I, "Q", Math.Floor((vol - VxQ) / tbls(I, "V")))
            End If
            VPakai = VPakai + tbls(I, "V") * tbls(I, "Q")
        Next
        txtWaste.Text = vol - VPakai

        If QR.SummaryText > 0 Then
            For I As Int16 = 0 To gv.RowCount - 1
                VR = VR + tbls(I, "V") * IIf(tbls(I, "QR").ToString = "", 0, tbls(I, "QR"))
            Next
            If VR > vol Then
                QR.AppearanceCell.BackColor = Color.Red
                QR.AppearanceCell.ForeColor = Color.White

            Else
                QR.AppearanceCell.BackColor = Color.White
                QR.AppearanceCell.ForeColor = Color.Black
                Vsisa = vol - VR
                totT = 0
                For I As Int16 = 0 To gv.RowCount - 1
                    If tbls(I, "QR").ToString = "" Then
                        totT = totT + tbls(I, "T")
                        tbls(I, "QR", 0)
                    ElseIf tbls(I, "QR") = 0 Then
                        totT = totT + tbls(I, "T")
                    End If
                Next
                'totT = tbl.Compute("sum(%)", "QR>0")
                For I As Int16 = 0 To gv.RowCount - 1

                    If tbls(I, "QR").ToString > 0 Then
                        tbls(I, "QQ", tbls(I, "QR"))
                    Else
                        tbls(I, "QQ", 0)
                    End If
                Next
                VxQ = 0
                For I As Int16 = 0 To gv.RowCount - 1
                    If tbls(I, "QR").ToString = 0 Then
                        tbls(I, "%", tbls(I, "T") / totT)
                        tbls(I, "J", Vsisa * tbls(I, "%"))
                        If tbl.Compute("count(T)", "QQ=0") > 1 Then
                            tbls(I, "QQ", Math.Floor(tbls(I, "J") / tbls(I, "V")))
                            VxQ = VxQ + (tbls(I, "V") * tbls(I, "QQ"))
                        Else
                            tbls(I, "QQ", Math.Floor((Vsisa - VxQ) / tbls(I, "V")))
                        End If
                    End If
                Next

            End If
        End If
        lblWaste.Text = Microsoft.VisualBasic.Left(txtWaste.Text / (gv.GetRowCellValue(0, "L_UP") * gv.GetRowCellValue(0, "P_UP")), 4) & " X " & gv.GetRowCellValue(0, "L_UP") & " X " & gv.GetRowCellValue(0, "P_UP")
        tbl.AcceptChanges()
    End Sub
    Public Function tbls(ByVal i As Int16, ByVal colName As String) As Object
        Return gv.GetRowCellValue(i, colName)
    End Function
    Public Sub tbls(ByVal i As Int16, ByVal colName As String, ByVal val As Object)
        gv.SetRowCellValue(i, colName, val)
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTutup.Click
        'CType(Me.ParentForm, Object).tblr.Clear()
        Close()
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAply.Click
        'CType(Me.ParentForm, Object).tblr = tbl
        ret = True
        Close()
    End Sub
End Class