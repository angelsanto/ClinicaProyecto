
Imports System.Data.SqlClient
Public Class Pacientes

    Dim con As New SqlConnection(My.Settings.Conexion)
    Private myCMD As SqlCommand

    Private Sub Pacientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtID.Enabled = False
        txtnombre.Enabled = False
        txtprimeroA.Enabled = False
        txtsegundo.Enabled = False
        txtcell.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
        btnactualiza.Enabled = False
        btnelimina.Enabled = False

        MostrarD()
    End Sub
    Private Sub MostrarD()

        Dim sql As String = "SELECT * FROM Pacientes"
        Dim cmd As New SqlCommand(sql, con)

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "Pacientes")

            Me.DataGridView1.DataSource = ds.Tables("Pacientes")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub InsertarDatos()


        Try
            con.Open()
            Dim cmd As New SqlCommand("SP_InsertarPaciente", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@DNIP", SqlDbType.VarChar).Value = txtID.Text.Trim()
            cmd.Parameters.Add("@Primer_Nombre", SqlDbType.VarChar).Value = txtnombre.Text.Trim()
            cmd.Parameters.Add("@Segundo_Nombre", SqlDbType.VarChar).Value = txtsegundo.Text.Trim()
            cmd.Parameters.Add("@Primer_Apellido", SqlDbType.VarChar).Value = txtprimeroA.Text.Trim()
            cmd.Parameters.Add("@Cell", SqlDbType.VarChar).Value = txtcell.Text.Trim()


            cmd.ExecuteNonQuery()

            MessageBox.Show("Datos GUARDADOS Correctamente!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            txtID.Text = ""
            txtnombre.Text = ""
            txtsegundo.Text = ""
            txtprimeroA.Text = ""
            txtcell.Text = ""
            con.Close()

        Catch ex As Exception

            MessageBox.Show(ex.Message)
            End Try

    End Sub

    Private Sub actualizar()
        Try

            myCMD = New SqlCommand()
            myCMD.CommandText = "UPDATE Pacientes set Primer_Nombre=@Primer_Nombre, Segundo_Nombre=@Segundo_Nombre, Primer_Apellido=@Primer_Apellido, Cell=@Cell where DNIP=@DNIP"
            myCMD.CommandType = CommandType.Text
            con.Open()
            myCMD.Connection = con
            myCMD.Parameters.AddWithValue("@DNIP", txtID.Text)
            myCMD.Parameters.AddWithValue("@Primer_Nombre", txtnombre.Text)
            myCMD.Parameters.AddWithValue("@Segundo_Nombre", txtsegundo.Text)
            myCMD.Parameters.AddWithValue("@Primer_Apellido", txtprimeroA.Text)
            myCMD.Parameters.AddWithValue("@Cell", txtcell.Text)


            myCMD.ExecuteNonQuery()

            MessageBox.Show("Datos ACTUALIZADOS Correctamente!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            con.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ValidarD()
        Dim id As String
        id = txtID.Text.ToString

        Dim sql As String = "SELECT * FROM Pacientes WHERE DNIP ='" & id & "'"
        Dim cmd As New SqlCommand(sql, con)

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)

            If ds.Rows.Count > 0 Then
                For Each row As DataRow In ds.Rows
                    id = row("DNIP").ToString
                    MessageBox.Show("La INDENTIDAD ya se encuentra registrada!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    txtID.Text = ""
                Next

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtID.Enabled = True
        txtnombre.Enabled = True
        txtprimeroA.Enabled = True
        txtsegundo.Enabled = True
        txtcell.Enabled = True
        btnguardar.Enabled = True
        btnnuevo.Enabled = True
        btnactualiza.Enabled = True
        btnelimina.Enabled = True
        txtID.Text = ""
        txtnombre.Text = ""
        txtsegundo.Text = ""
        txtprimeroA.Text = ""
        txtcell.Text = ""
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        ValidarD()

        If (txtID.Text = "") Then
            MessageBox.Show("Debe de ingresar la IDENTIDAD!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtID.Focus()

        ElseIf (txtnombre.Text = "") Then
            MessageBox.Show("Debe de ingresar el NOMBRE!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtnombre.Focus()

        ElseIf (txtsegundo.Text = "") Then
            MessageBox.Show("Debe de ingresar el SEGUNDO NOMBRE!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtsegundo.Focus()

        ElseIf (txtprimeroA.Text = "") Then
            MessageBox.Show("Debe de ingresar el PRIMER APELLIDO!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtprimeroA.Focus()
        Else

            If MessageBox.Show("Esta seguro de la IDENTIDAD", "Informacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

                InsertarDatos()
                MostrarD()
            Else
                txtID.Focus()
            End If
        End If
    End Sub

    Private Sub btnactualiza_Click(sender As Object, e As EventArgs) Handles btnactualiza.Click
        actualizar()
        txtID.Text = ""
        txtnombre.Text = ""
        txtsegundo.Text = ""
        txtprimeroA.Text = ""
        txtcell.Text = ""
        MostrarD()
    End Sub

    Private Sub btnelimina_Click(sender As Object, e As EventArgs) Handles btnelimina.Click

        Try
            con.Open()
            Dim cmd As New SqlCommand("SP_Elimina", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@DNIP", SqlDbType.VarChar).Value = txtID.Text.Trim()
            cmd.ExecuteNonQuery()

            MessageBox.Show("Datos ELIMINADOS Correctamente!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            txtID.Text = ""
            txtnombre.Text = ""
            txtsegundo.Text = ""
            txtprimeroA.Text = ""
            txtcell.Text = ""
            con.Close()
            MostrarD()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BUSCARDATOS()

        Dim da As New SqlDataAdapter("Select * From Pacientes where DNIP like '%" & Me.txtBuscar.Text & "%' Or Primer_Nombre Like '%" & Me.txtBuscar.Text & "%' Or Segundo_Nombre Like '%" & Me.txtBuscar.Text & "%' Or Primer_Apellido Like '%" & Me.txtBuscar.Text & "%'", con)
        Dim ds As New DataSet()
        da.Fill(ds, "Pacientes")
        Me.DataGridView1.DataSource = ds.Tables(0)

    End Sub
    Private Sub Buscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BUSCARDATOS()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles cerrar.Click
        Me.Close()
    End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtID.Text = DataGridView1.Item(0, e.RowIndex).Value
        txtnombre.Text = DataGridView1.Item(1, e.RowIndex).Value
        txtsegundo.Text = DataGridView1.Item(2, e.RowIndex).Value
        txtprimeroA.Text = DataGridView1.Item(3, e.RowIndex).Value
        txtcell.Text = DataGridView1.Item(4, e.RowIndex).Value
        txtID.Enabled = False
        txtnombre.Enabled = True
        txtprimeroA.Enabled = True
        txtsegundo.Enabled = True
        txtcell.Enabled = True
        btnguardar.Enabled = True
        btnnuevo.Enabled = True
        btnactualiza.Enabled = True
        btnelimina.Enabled = True
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        CITAS.txtIDP.Text = Me.txtID.Text
        CITAS.txtpacientes.Text = Me.txtnombre.Text & " " & txtsegundo.Text & " " & txtprimeroA.Text
        CITAS.Show()
        Me.Hide()
    End Sub

    Private Sub registrar_Click(sender As Object, e As EventArgs) Handles registrar.Click
        CITAS.txtIDP.Text = Me.txtID.Text
        CITAS.txtpacientes.Text = Me.txtnombre.Text & " " & txtsegundo.Text & " " & txtprimeroA.Text
        CITAS.Show()
        Me.Hide()
    End Sub


    Private Sub txtcell_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcell.KeyPress

        e.Handled = Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar)

        If Not IsNumeric(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            MessageBox.Show("Solo puede ingresar Numeros!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        End If

    End Sub


    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress

        If e.KeyChar = ChrW(Keys.Enter) Then

            e.Handled = True
            SendKeys.Send("{TAB}")

            ValidarD()
        End If



        If InStr(1, "0123456789-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If


    End Sub
End Class