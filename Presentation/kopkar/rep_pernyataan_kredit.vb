Imports System.Data.SqlClient

Public Class rep_pernyataan_kredit

    Private Sub rep_pernyataan_kredit_ParametersRequestBeforeShow(ByVal sender As System.Object, ByVal e As DevExpress.XtraReports.Parameters.ParametersRequestEventArgs) Handles MyBase.ParametersRequestBeforeShow

    End Sub

    Private Sub rep_pernyataan_kredit_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Dim no_trans As String = Me.Parameters("no_trans").Value '"1021807002"
        Dim trans As SqlDataReader = New SqlCommand("select * from v_kredit WHERE no_trans='" & no_trans & "'", sqlconn).ExecuteReader
        trans.Read()
        Me.Parameters("nama").Value = trans("Nama")
        Me.Parameters("nip").Value = trans("nasabah_id")
        Me.Parameters("no_form").Value = trans("no_ref")

        Me.Parameters("jml_pinjaman").Value = trans("JML_PINJAMAN")
        Me.Parameters("rec_jumlah").Value = trans("rec_jumlah")
        Me.Parameters("rec_penalty").Value = trans("rec_penalty")
        Me.Parameters("rec_bb").Value = trans("rec_bbj")
        Me.Parameters("jml_provisi").Value = trans("JML_PROVISI")
        Me.Parameters("jml_admin").Value = trans("JML_ADMIN")
        Me.Parameters("total_biaya").Value = trans("JML_ADMIN") + trans("JML_PROVISI") + trans("rec_penalty") + trans("rec_bbj") + trans("rec_jumlah")
        Me.Parameters("sisa_pinjaman").Value = trans("JML_PINJAMAN") - Convert.ToDouble(Me.Parameters("total_biaya").Value)
        Me.Parameters("pot_bns").Value = trans("pot_bns")
        Me.Parameters("pot_thr").Value = trans("pot_thr")
        Me.Parameters("pot_tat").Value = trans("pot_tat")
        Me.Parameters("total_potongan").Value = trans("pot_bns") + trans("pot_thr") + trans("pot_tat")
        trans.Close()
    End Sub
End Class