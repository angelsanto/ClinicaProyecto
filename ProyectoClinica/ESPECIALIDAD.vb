Imports System.Data.SqlClient

Public Class ESPECIALIDAD

    Dim con As New SqlConnection(My.Settings.Conexion)
    Private cmd As SqlCommand
    Private Sub ESPECIALIDAD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarD()
    End Sub

    Private Sub MostrarD()

        Dim sql As String = "SELECT * FROM Especialidad"
        Dim cmd As New SqlCommand(sql, con)

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "Especialidad")

            Me.DataGridView1.DataSource = ds.Tables("Especialidad")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Guardar()
        Try

            cmd = New SqlCommand()
            cmd.CommandText = "INSERT INTO Especialidad values(@codigo, @espe)"
            cmd.CommandType = CommandType.Text
            con.Open()
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@codigo", txtcodigo.Text)
            cmd.Parameters.AddWithValue("@espe", txtespe.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Datos GUARDADOS Correctamente!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Actualizar()
        Try

            cmd = New SqlCommand()
            cmd.CommandText = "UPDATE Especialidad SET  Especialidad=@espe where ID_Especi=@codigo"
            cmd.CommandType = CommandType.Text
            con.Open()
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@codigo", txtcodigo.Text)
            cmd.Parameters.AddWithValue("@espe", txtespe.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Datos ACTUALIZADOS Correctamente!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ValidarD()

        Dim id As String
        id = txtcodigo.Text.ToString

        Dim sql As String = "SELECT * FROM Especialidad WHERE ID_Especi ='" & id & "'"
        Dim cmd As New SqlCommand(sql, con)

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)

            If ds.Rows.Count > 0 Then
                For Each row As DataRow In ds.Rows
                    id = row("ID_Especi").ToString
                    MessageBox.Show("El CODIGO ya se encuentra registrado!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    txtcodigo.Text = ""
                Next

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        ValidarD()

        If (txtcodigo.Text = "") Then
            MessageBox.Show("Debe de ingresar el Codigo!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtcodigo.Focus()

        ElseIf (txtespe.Text = "") Then
            MessageBox.Show("Debe de ingresar la especialidad!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtespe.Focus()
        Else

            Guardar()
            txtcodigo.Text = ""
            txtespe.Text = ""
            MostrarD()
        End If

    End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        txtcodigo.Text = DataGridView1.Item(0, e.RowIndex).Value
        txtespe.Text = DataGridView1.Item(1, e.RowIndex).Value
        txtcodigo.Enabled = False
    End Sub

    Private Sub btnactualiza_Click(sender As Object, e As EventArgs) Handles btnactualiza.Click
        Actualizar()
        txtcodigo.Text = ""
        txtespe.Text = ""
        MostrarD()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MEDICOS.Show()
        Me.Close()
    End Sub



    Private Sub txtcodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcodigo.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True
            SendKeys.Send("{TAB}")

            ValidarD()
        End If

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Solo puede ingresar Numeros!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If


    End Sub
End Class