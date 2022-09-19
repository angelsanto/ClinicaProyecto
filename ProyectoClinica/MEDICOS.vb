
Imports System.Data.SqlClient

Public Class MEDICOS

    Dim con As New SqlConnection(My.Settings.Conexion)
    Private mycmd As SqlCommand


    Private Sub MEDICOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtID.Enabled = False
        txtnombre.Enabled = False
        txtprimeroA.Enabled = False
        txtsegundo.Enabled = False
        txtbarrio.Enabled = False
        txtcell.Enabled = False
        cbespe.Enabled = False
        btnguardar.Enabled = False
        btnnuevo.Enabled = True
        btnactualiza.Enabled = False
        btnelimina.Enabled = False
        MostrarBD()
        MostrarCBX()

    End Sub

    Private Sub MostrarCBX()

        Dim sql As String = "SELECT * FROM Especialidad"
        Dim cmd As New SqlCommand(sql, con)

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "Especialidad")

            cbespe.DisplayMember = "Especialidad"
            cbespe.ValueMember = "ID_Especi"

            cbespe.DataSource = ds.Tables("Especialidad")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub MostrarBD()

        Dim sql As String = "SELECT * FROM V_MEDICO"
        Dim cmd As New SqlCommand(sql, con)

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "V_MEDICO")

            Me.DataGridView1.DataSource = ds.Tables("V_MEDICO")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub InsertarD()

        Try
            con.Open()
            Dim cmd As New SqlCommand("SP_InsertarMedico", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@DNID", SqlDbType.VarChar).Value = txtID.Text.Trim()
            cmd.Parameters.Add("@Primer_Nombre", SqlDbType.VarChar).Value = txtnombre.Text.Trim()
            cmd.Parameters.Add("@Segundo_Nombre", SqlDbType.VarChar).Value = txtsegundo.Text.Trim()
            cmd.Parameters.Add("@Primer_Apellido", SqlDbType.VarChar).Value = txtprimeroA.Text.Trim()
            cmd.Parameters.Add("@Barrio", SqlDbType.VarChar).Value = txtbarrio.Text.Trim()
            cmd.Parameters.Add("@Cell", SqlDbType.VarChar).Value = txtcell.Text.Trim()
            cmd.Parameters.Add("@ID_Especi", SqlDbType.VarChar).Value = cbespe.SelectedValue

            cmd.ExecuteNonQuery()
            MessageBox.Show("Datos GUARDADOS Correctamente!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            txtID.Text = ""
            txtnombre.Text = ""
            txtsegundo.Text = ""
            txtprimeroA.Text = ""
            txtcell.Text = ""
            txtbarrio.Text = ""
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Actualizar()

        Try
            con.Open()
            Dim cmd As New SqlCommand("SP_ActualizarD", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@DNID", SqlDbType.VarChar).Value = txtID.Text.Trim()
            cmd.Parameters.Add("@Primer_Nombre", SqlDbType.VarChar).Value = txtnombre.Text.Trim()
            cmd.Parameters.Add("@Segundo_Nombre", SqlDbType.VarChar).Value = txtsegundo.Text.Trim()
            cmd.Parameters.Add("@Primer_Apellido", SqlDbType.VarChar).Value = txtprimeroA.Text.Trim()
            cmd.Parameters.Add("@Barrio", SqlDbType.VarChar).Value = txtbarrio.Text.Trim()
            cmd.Parameters.Add("@Cell", SqlDbType.VarChar).Value = txtcell.Text.Trim()
            cmd.Parameters.Add("@ID_Especi", SqlDbType.VarChar).Value = cbespe.SelectedValue

            cmd.ExecuteNonQuery()
            MessageBox.Show("Datos ACTUALIZADOS Correctamente!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            con.Close()
        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Private Sub ValidarD()

        Dim id As String
        id = txtID.Text.ToString

        Dim sql As String = "SELECT * FROM Doctor WHERE DNID ='" & id & "'"
        Dim cmd As New SqlCommand(sql, con)

        Try
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataTable
            da.Fill(ds)

            If ds.Rows.Count > 0 Then
                For Each row As DataRow In ds.Rows
                    id = row("DNID").ToString
                    MessageBox.Show("La INDENTIDAD ya se encuentra registrada!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                    txtID.Text = ""
                Next

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

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

        ElseIf (txtcell.Text = "") Then
            MessageBox.Show("Debe de ingresar el CELULAR!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            txtcell.Focus()
        Else
            If MessageBox.Show("Esta seguro de la IDENTIDAD", "Informacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

                InsertarD()
                MostrarBD()

            Else
                txtID.Focus()
            End If
        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        txtID.Enabled = True
        txtnombre.Enabled = True
        txtprimeroA.Enabled = True
        txtsegundo.Enabled = True
        txtbarrio.Enabled = True
        txtcell.Enabled = True
        cbespe.Enabled = True
        btnguardar.Enabled = True
        btnnuevo.Enabled = True
        btnactualiza.Enabled = True
        btnelimina.Enabled = True
        txtID.Text = ""
        txtnombre.Text = ""
        txtsegundo.Text = ""
        txtprimeroA.Text = ""
        txtbarrio.Text = ""
        txtcell.Text = ""
    End Sub

    Private Sub btnelimina_Click(sender As Object, e As EventArgs) Handles btnelimina.Click

        'Dim iden As String
        'iden = Me.txtID.Text
        'con.Open()
        'mycmd = New SqlCommand()
        'mycmd.CommandType = CommandType.Text
        'mycmd.Connection = con
        'mycmd.CommandText = "DELETE FROM Doctor WHERE DNID = " & iden & ""
        'mycmd.ExecuteNonQuery()

        'MessageBox.Show("Datos BORRADOS correctamente!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        'txtID.Text = ""
        'txtnombre.Text = ""
        'txtsegundo.Text = ""
        'txtprimeroA.Text = ""
        'txtcell.Text = ""
        'txtbarrio.Text = ""
        'con.Close()
        'MostrarBD()

        Try
            con.Open()
            Dim cmd As New SqlCommand("SP_EliminaD", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@DNID", SqlDbType.VarChar).Value = txtID.Text.Trim()
            cmd.ExecuteNonQuery()

            MessageBox.Show("Datos ELIMINADOS Correctamente!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            txtID.Text = ""
            txtnombre.Text = ""
            txtsegundo.Text = ""
            txtprimeroA.Text = ""
            txtcell.Text = ""
            txtbarrio.Text = ""
            con.Close()
            MostrarBD()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick

        txtID.Text = DataGridView1.Item(0, e.RowIndex).Value
        txtnombre.Text = DataGridView1.Item(1, e.RowIndex).Value
        txtsegundo.Text = DataGridView1.Item(2, e.RowIndex).Value
        txtprimeroA.Text = DataGridView1.Item(3, e.RowIndex).Value
        txtbarrio.Text = DataGridView1.Item(4, e.RowIndex).Value
        txtcell.Text = DataGridView1.Item(5, e.RowIndex).Value
        txtID.Enabled = False
        txtnombre.Enabled = True
        txtprimeroA.Enabled = True
        txtsegundo.Enabled = True
        txtcell.Enabled = True
        txtbarrio.Enabled = True
        cbespe.Enabled = True
        btnguardar.Enabled = True
        btnnuevo.Enabled = True
        btnactualiza.Enabled = True
        btnelimina.Enabled = True

    End Sub

    Private Sub BSC()

        Dim da As New SqlDataAdapter("Select * from V_MEDICO where DNID LIKE '%" & Me.txtBuscar.Text & "%' or Primer_Nombre LIKE '%" & Me.txtBuscar.Text & "%' or Segundo_Nombre LIKE '%" & Me.txtBuscar.Text & "%' or Primer_Apellido LIKE '%" & Me.txtBuscar.Text & "%'", con)
        Dim ds As New DataSet
        da.Fill(ds, "V_MEDICO")

        Me.DataGridView1.DataSource = ds.Tables(0)
    End Sub


    Private Sub btnactualiza_Click(sender As Object, e As EventArgs) Handles btnactualiza.Click
        Actualizar()
        MostrarBD()
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged
        BSC()
    End Sub

    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ESPECIALIDAD.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        MOSRAR_DIAS_MEDICOS.txtID.Text = Me.txtID.Text
        MOSRAR_DIAS_MEDICOS.txtmedico.Text = Me.txtnombre.Text & " " & txtsegundo.Text & " " & txtprimeroA.Text
        MOSRAR_DIAS_MEDICOS.Show()
        Me.Close()

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        CITAS.txtID.Text = Me.txtID.Text
        CITAS.txtmedico.Text = Me.txtnombre.Text & " " & txtsegundo.Text & " " & txtprimeroA.Text
        CITAS.Show()
        Me.Hide()
    End Sub

    Private Sub registar_Click(sender As Object, e As EventArgs) Handles registar.Click
        CITAS.txtID.Text = Me.txtID.Text
        CITAS.txtmedico.Text = Me.txtnombre.Text & " " & txtsegundo.Text & " " & txtprimeroA.Text
        CITAS.Show()
        Me.Hide()
    End Sub



    Private Sub txtcell_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcell.KeyPress


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

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress

        If InStr(1, "0123456789-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ReporteMedico.txtID.Text = Me.txtID.Text
        ReporteMedico.txtmedico.Text = Me.txtnombre.Text & " " & txtsegundo.Text & " " & txtprimeroA.Text
        ReporteMedico.Show()
    End Sub
End Class
