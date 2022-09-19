
Imports System.Data.SqlClient
Public Class MOSRAR_DIAS_MEDICOS

    Dim con As New SqlConnection(My.Settings.Conexion)

    'Private myCMD As SqlCommand
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mostrarBDS()
        MostrarCBX()
        MostrarCBXH()
        txtID.Enabled = False
        txthora.Enabled = False
        txtID.Visible = False
        txthora.Visible = False

    End Sub



    Private Sub mostrarBDS()
        Dim con As New SqlConnection(My.Settings.Conexion)
        Dim sql As String = "SELECT * FROM V_MOSTRAR_HORARIOS "
        Dim cmd As New SqlCommand(sql, con)

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, " V_MOSTRAR_HORARIOS")

            Me.DataGridView1.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub guardar()

        Try
            con.Open()
            Dim cmd As New SqlCommand("SP_Insertardia", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@ID_Dia", SqlDbType.VarChar).Value = cbdia.SelectedValue
            cmd.Parameters.Add("@DNID", SqlDbType.VarChar).Value = txtID.Text
            cmd.Parameters.Add("@ID_Hora", SqlDbType.VarChar).Value = txthora.Text

            cmd.ExecuteNonQuery()
            con.Close()

            MessageBox.Show("Datos GUARDADOS Correctamente!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            mostrarBDS()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


    End Sub
    Private Sub MostrarCBX()

        Dim sql As String = "SELECT * FROM Dias"
        Dim cmd As New SqlCommand(sql, con)

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "Dias")

            cbdia.DisplayMember = "Dia"
            cbdia.ValueMember = "ID_Dia"

            cbdia.DataSource = ds.Tables("Dias")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrarCBXH()

        Dim sql As String = "SELECT CONVERT (VARCHAR(5), H_inicio,108) +' - '+ CONVERT (VARCHAR(5), H_final,108) AS 'HORARIO', Cupos from Horarios"

        Dim cmd As New SqlCommand(Sql, con)

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "Horarios")
            cbhora.DisplayMember = "HORARIO"
            cbhora.ValueMember = "ID_Hora"
            cbhora.DataSource = ds.Tables("Horarios")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BUSCARDATOS()


        Dim da As New SqlDataAdapter("Select * From V_MOSTRAR_HORARIOS where MEDICO like '%" & Me.txtbuscar.Text & "%' or Dia like '%" & Me.txtbuscar.Text & "%'", con)
        Dim ds As New DataSet()
        da.Fill(ds, " V_MOSTRAR_HORARIOS")
        Me.DataGridView1.DataSource = ds.Tables(0)

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        BUSCARDATOS()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MEDICOS.Show()
        Me.Close()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If (txtID.Text = "") Then
            MessageBox.Show("Debe de SELECCIONAR AL MEDICO EN LA TABLA DE MEDICOS!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtID.Focus()
        Else
            guardar()
        End If
    End Sub

    Private Sub cbhora_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbhora.SelectedIndexChanged
        txtcupo.Text = cbhora.SelectedValue("Cupos").ToString
        txthora.Text = cbhora.SelectedIndex
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        LIMITECUPOS.Show()
    End Sub
End Class