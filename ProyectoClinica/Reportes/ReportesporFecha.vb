Public Class ReportesporFecha
    Public fechainicio As Date
    Public fechafinal As Date
    Private Sub ReportesporFecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim objerep As New Reporte2
        objerep.SetParameterValue("@fecha", fechainicio)
        objerep.SetParameterValue("@fecha2", fechafinal)

        CrystalReportViewer1.ReportSource = objerep
    End Sub
End Class