Public Class MENU
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frmpaciente As New Pacientes
        frmpaciente.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmpaciente)
        frmpaciente.Show()


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim frmmedico As New MEDICOS
        frmmedico.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmmedico)
        frmmedico.Show()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frmespe As New ESPECIALIDAD
        frmespe.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmespe)
        frmespe.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frmdias As New MOSRAR_DIAS_MEDICOS
        frmdias.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmdias)
        frmdias.Show()


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frmcita As New CITAS
        frmcita.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmcita)
        frmcita.Show()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim frmBSF As New REPORTESC
        frmBSF.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmBSF)
        frmBSF.Show()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim frmLM As New LIMITECUPOS
        frmLM.MdiParent = Me
        Me.ToolStripContainer1.ContentPanel.Controls.Add(frmLM)
        frmLM.Show()
    End Sub
End Class