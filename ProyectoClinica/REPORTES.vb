
Imports System.Data.SqlClient

Public Class REPORTESC

    Dim con As New SqlConnection(My.Settings.Conexion)


    Private Sub REPORTESC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MOSTRARD()
    End Sub

    Private Sub MOSTRARD()

        Dim sql As String = "SELECT * FROM V_FechasGeneral"
        Dim cmd As New SqlCommand(sql, con)

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "V_FechasGeneral")

            Me.DataGridView1.DataSource = ds.Tables("V_FechasGeneral")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub registrar_Click(sender As Object, e As EventArgs) Handles registrar.Click
        REPORTESF.Show()
    End Sub

    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Me.Close()
    End Sub

    Private Sub BSC()

        Dim da As New SqlDataAdapter("Select * from V_FechasGeneral where MEDICO LIKE '%" & Me.txtBuscar.Text & "%' or PACIENTES like '%" & Me.txtBuscar.Text & "%'", con)
        Dim ds As New DataSet
        da.Fill(ds, "V_FechasGeneral")

        Me.DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BSC()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReporteMedico.Show()
    End Sub


    'Private Sub BuscarF()

    '    Try
    '        con.Open()
    '        Dim cmd As New SqlCommand("SP_CitaMedicaSemana", con)
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Parameters.Add("@Fecha_Programada", SqlDbType.DateTime).Value = CDate(dtbusca.Text)
    '        cmd.ExecuteNonQuery()
    '        MessageBox.Show("Datos GUARDADOS Correctamente!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    '        con.Close()

    '    Catch ex As Exception

    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub


End Class