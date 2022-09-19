<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteMedico
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReporteMedico))
        Me.dtfecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtmedico = New System.Windows.Forms.TextBox()
        Me.btnimprime = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'dtfecha
        '
        Me.dtfecha.Location = New System.Drawing.Point(15, 79)
        Me.dtfecha.Name = "dtfecha"
        Me.dtfecha.Size = New System.Drawing.Size(200, 20)
        Me.dtfecha.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 16)
        Me.Label1.TabIndex = 77
        Me.Label1.Text = "BUSCAR POR FECHA Y MEDICO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(15, 195)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(133, 22)
        Me.txtID.TabIndex = 78
        '
        'txtmedico
        '
        Me.txtmedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmedico.Location = New System.Drawing.Point(15, 139)
        Me.txtmedico.Name = "txtmedico"
        Me.txtmedico.Size = New System.Drawing.Size(203, 22)
        Me.txtmedico.TabIndex = 79
        '
        'btnimprime
        '
        Me.btnimprime.BackColor = System.Drawing.Color.Silver
        Me.btnimprime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnimprime.ForeColor = System.Drawing.Color.Black
        Me.btnimprime.Image = CType(resources.GetObject("btnimprime.Image"), System.Drawing.Image)
        Me.btnimprime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnimprime.Location = New System.Drawing.Point(278, 64)
        Me.btnimprime.Name = "btnimprime"
        Me.btnimprime.Size = New System.Drawing.Size(81, 37)
        Me.btnimprime.TabIndex = 80
        Me.btnimprime.Text = "Imprimir"
        Me.btnimprime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnimprime.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Silver
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button5.Location = New System.Drawing.Point(264, 136)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(106, 40)
        Me.Button5.TabIndex = 81
        Me.Button5.Text = "Medicos"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button5.UseVisualStyleBackColor = False
        '
        'ReporteMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(427, 261)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnimprime)
        Me.Controls.Add(Me.txtmedico)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtfecha)
        Me.Name = "ReporteMedico"
        Me.Text = "ReporteMedico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dtfecha As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtmedico As TextBox
    Friend WithEvents btnimprime As Button
    Friend WithEvents Button5 As Button
End Class
