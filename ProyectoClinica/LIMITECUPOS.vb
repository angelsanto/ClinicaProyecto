
Imports System.Data.SqlClient
Public Class LIMITECUPOS

    Dim con As New SqlConnection(My.Settings.Conexion)
    Private Sub LIMITECUPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet4.V_LimiteCUPOS' Puede moverla o quitarla según sea necesario.
        Me.V_LimiteCUPOSTableAdapter.Fill(Me.ClinicaDataSet4.V_LimiteCUPOS)
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet3.V_LimiteC' Puede moverla o quitarla según sea necesario.
        'Me.V_LimiteCTableAdapter1.Fill(Me.ClinicaDataSet3.V_LimiteC)
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet.V_LimiteC' Puede moverla o quitarla según sea necesario.
        'Me.V_LimiteCTableAdapter.Fill(Me.ClinicaDataSet.V_LimiteC)
        'TODO: esta línea de código carga datos en la tabla 'ClinicaDataSet2.V_MOSTRAR_HORARIOS' Puede moverla o quitarla según sea necesario.

        'MOSTRARD()
    End Sub
    Private Sub MOSTRARD()

        'Dim sql As String = "SELECT * FROM V_LimiteC"
        'Dim cmd As New SqlCommand(sql, con)

        'Try
        '    Dim da As New SqlDataAdapter(cmd)
        '    Dim ds As New DataSet
        '    da.Fill(ds, "V_LimiteC")

        '    Me.DataGridView1.DataSource = ds.Tables("V_LimiteC")

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub BUSCARDATOS()

        'Dim f As Date = CDate(dtbuscar.Text)
        'Dim da As New SqlDataAdapter("Select * From V_LimiteC where DNID like '%" & Me.txtBuscar.Text & "%'  Or MEDICO Like '%" & Me.txtBuscar.Text & "' Or Fecha_Programada = '" & f & "'", con)
        'Dim ds As New DataSet()
        'da.Fill(ds, "V_LimiteC")
        'Me.DataGridView1.DataSource = ds.Tables(0)

    End Sub

    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Me.Close()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs)
        'BUSCARDATOS()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        'Dim f As Date = CDate(dtbuscar.Text)
        'Dim da As New SqlDataAdapter("Select * From V_LimiteC where Fecha_Programada = '" & f & "'", con)
        'Dim ds As New DataSet()
        'da.Fill(ds, "V_LimiteC")
        'Me.DataGridView1.DataSource = ds.Tables("V_LimiteC")
        'Try
        '    con.Open()
        '    Dim cmd As New SqlCommand("SP_PRUEBA", con)
        '    cmd.CommandType = CommandType.StoredProcedure
        '    cmd.Parameters.Add("@Fecha_Programada", SqlDbType.DateTime).Value = dtbuscar.Text
        '    cmd.Parameters.Add("@Primer_Nombre", SqlDbType.VarChar).Value = txtBuscar.Text

        '    cmd.ExecuteNonQuery()

        '    MessageBox.Show("Datos ELIMINADOS Correctamente!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        '    con.Close()


        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
        BUSCARDATOS()
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            'Me.V_LimiteCTableAdapter.FillBy(Me.ClinicaDataSet.V_LimiteC)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class