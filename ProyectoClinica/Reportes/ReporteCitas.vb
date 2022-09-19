Public Class ReporteCitas
    Private Sub ReporteCitas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objerep As New reporte1
        CrystalReportViewer1.ReportSource = objerep
    End Sub
End Class