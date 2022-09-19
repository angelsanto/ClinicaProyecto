
Imports System.Data.SqlClient

Public Class CITAS

    Dim con As New SqlConnection(My.Settings.Conexion)

    Private Sub CITAS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MOSTRARD()
        txtcodigoC.Enabled = False
        txtID.Visible = False
        txtIDP.Visible = False
        dtregistro.Enabled = False
    End Sub

    Private Sub MOSTRARD()

        Dim sql As String = "SELECT * FROM V_CitaMedica"
        Dim cmd As New SqlCommand(sql, con)

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "V_CitaMedica")

            Me.DataGridView1.DataSource = ds.Tables("V_CitaMedica")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub InsertarDatos()

        Try
            con.Open()
            Dim cmd As New SqlCommand("SP_InsertaCita", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@DNIP ", SqlDbType.VarChar).Value = txtIDP.Text.Trim()
            cmd.Parameters.Add("@DNID", SqlDbType.VarChar).Value = txtID.Text.Trim()
            cmd.Parameters.Add("@Fecha_Programada", SqlDbType.DateTime).Value = dtprorama.Text
            cmd.Parameters.Add("@Fecha_Registro", SqlDbType.DateTime).Value = dtregistro.Text

            cmd.ExecuteNonQuery()

            MessageBox.Show("Datos GUARDADOS Correctamente!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            txtID.Text = ""
            txtIDP.Text = ""
            txtpacientes.Text = ""
            txtmedico.Text = ""

            con.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
        End Try

    End Sub

    'Private Sub elimina()
    '    Try
    '        con.Open()
    '        Dim cmd As New SqlCommand("SP_EliminaCita", con)
    '        cmd.CommandType = CommandType.StoredProcedure
    '        cmd.Parameters.Add("@ID_cita ", SqlDbType.Int).Value = txtcodigoC.Text
    '        cmd.ExecuteNonQuery()

    '        MessageBox.Show("Datos ELIMINADOS Correctamente!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

    '        txtID.Text = ""
    '        txtIDP.Text = ""
    '        txtpacientes.Text = ""
    '        txtmedico.Text = ""
    '        con.Close()

    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message)
    '    End Try
    'End Sub

    Private Sub Actualiza()

        Try
            con.Open()
            Dim cmd As New SqlCommand("SP_Actualiza", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@ID_cita ", SqlDbType.Int).Value = txtcodigoC.Text
            cmd.Parameters.Add("@Fecha_Programada", SqlDbType.DateTime).Value = dtprorama.Text
            cmd.ExecuteNonQuery()

            MessageBox.Show("Datos ACTUALIZADOS Correctamente!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            txtID.Text = ""
            txtIDP.Text = ""
            txtpacientes.Text = ""
            txtmedico.Text = ""
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Pacientes.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MEDICOS.Show()
        'Me.Close()
    End Sub

    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Me.Close()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If (txtID.Text = "") Then
            MessageBox.Show("Debe Seleccionar El Doctor!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtID.Focus()

        ElseIf (txtIDP.Text = "") Then
            MessageBox.Show("Debe Seleccionar El Paciente!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtIDP.Focus()

        Else
            InsertarDatos()
            MOSTRARD()
        End If
    End Sub

    Private Sub BSC()

        Dim da As New SqlDataAdapter("Select * from V_CitaMedica where MEDICO LIKE '%" & Me.txtBuscar.Text & "%' or PACIENTES like '%" & Me.txtBuscar.Text & "%'", con)
        Dim ds As New DataSet
        da.Fill(ds, "V_CitaMedica")

        Me.DataGridView1.DataSource = ds.Tables(0)
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtcodigoC.Text = DataGridView1.Item(0, e.RowIndex).Value
        txtmedico.Enabled = False
        txtpacientes.Enabled = False
    End Sub

    Private Sub btnactualiza_Click(sender As Object, e As EventArgs) Handles btnactualiza.Click
        Actualiza()
        MOSTRARD()
    End Sub

    Private Sub btnimprime_Click(sender As Object, e As EventArgs) Handles btnimprime.Click
        ReporteCitas.Show()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BSC()
    End Sub
End Class