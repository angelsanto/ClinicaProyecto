Public Class ReporteMedico
    Private Sub btnimprime_Click(sender As Object, e As EventArgs) Handles btnimprime.Click
        Dim fecha1 As Date = CDate(dtfecha.Text)
        Dim medico1 As String = txtID.Text

        Dim frmRM As New ReporteM

        frmRM.fecha = fecha1
        frmRM.medico = medico1

        frmRM.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MEDICOS.Show()
    End Sub

    Private Sub ReporteMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtID.Visible = False
    End Sub
End Class