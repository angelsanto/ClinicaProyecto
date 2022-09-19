Public Class ReporteM

    Public fecha As Date
    Public medico As String
    Private Sub ReporteM_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim objerep As New Reporte3
        objerep.SetParameterValue("@Fecha_Programada", fecha)
        objerep.SetParameterValue("@DNID", medico)

        CrystalReportViewer1.ReportSource = objerep


    End Sub
End Class