Public Class REPORTESF
    Private Sub btnimprime_Click(sender As Object, e As EventArgs) Handles btnimprime.Click
        Dim fechaini As Date = CDate(dtinicia.Text)
        Dim fechafin As Date = CDate(dtfinal.Text)

        Dim frmfechas As New ReportesporFecha

        frmfechas.fechainicio = fechaini
        frmfechas.fechafinal = fechafin

        frmfechas.Show()

    End Sub

    Private Sub REPORTESF_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class