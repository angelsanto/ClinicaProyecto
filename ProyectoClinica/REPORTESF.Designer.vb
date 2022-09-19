<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REPORTESF
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(REPORTESF))
        Me.dtinicia = New System.Windows.Forms.DateTimePicker()
        Me.dtfinal = New System.Windows.Forms.DateTimePicker()
        Me.btnimprime = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'dtinicia
        '
        Me.dtinicia.Location = New System.Drawing.Point(47, 69)
        Me.dtinicia.Name = "dtinicia"
        Me.dtinicia.Size = New System.Drawing.Size(200, 20)
        Me.dtinicia.TabIndex = 0
        '
        'dtfinal
        '
        Me.dtfinal.Location = New System.Drawing.Point(435, 69)
        Me.dtfinal.Name = "dtfinal"
        Me.dtfinal.Size = New System.Drawing.Size(200, 20)
        Me.dtfinal.TabIndex = 1
        '
        'btnimprime
        '
        Me.btnimprime.BackColor = System.Drawing.Color.Silver
        Me.btnimprime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimprime.ForeColor = System.Drawing.Color.Black
        Me.btnimprime.Image = CType(resources.GetObject("btnimprime.Image"), System.Drawing.Image)
        Me.btnimprime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnimprime.Location = New System.Drawing.Point(299, 125)
        Me.btnimprime.Name = "btnimprime"
        Me.btnimprime.Size = New System.Drawing.Size(81, 37)
        Me.btnimprime.TabIndex = 75
        Me.btnimprime.Text = "Imprimir"
        Me.btnimprime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnimprime.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(174, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(305, 16)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "COMPRENDE DESDE------HASTA FECHAS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(44, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 16)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Fecha Inicial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(432, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Fecha Final"
        '
        'REPORTESF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(707, 174)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnimprime)
        Me.Controls.Add(Me.dtfinal)
        Me.Controls.Add(Me.dtinicia)
        Me.Name = "REPORTESF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GENERAR REPORTE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtinicia As DateTimePicker
    Friend WithEvents dtfinal As DateTimePicker
    Friend WithEvents btnimprime As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
End Class
