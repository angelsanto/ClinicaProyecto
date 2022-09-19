<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LIMITECUPOS
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LIMITECUPOS))
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cerrar = New System.Windows.Forms.Button()
        Me.V_MOSTRAR_HORARIOSTableAdapter = New ProyectoClinica.ClinicaDataSet2TableAdapters.V_MOSTRAR_HORARIOSTableAdapter()
        Me.ClinicaDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicaDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VLimiteCBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicaDataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VLimiteCBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VLimiteCBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicaDataSet3 = New ProyectoClinica.ClinicaDataSet3()
        'Me.ClinicaDataSet = New ProyectoClinica.ClinicaDataSet()
        Me.VLimiteCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        'Me.V_LimiteCTableAdapter = New ProyectoClinica.ClinicaDataSetTableAdapters.V_LimiteCTableAdapter()
        Me.V_LimiteCTableAdapter1 = New ProyectoClinica.ClinicaDataSet3TableAdapters.V_LimiteCTableAdapter()
        Me.VLimiteCBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.VLimiteCBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClinicaDataSet3BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colMEDICO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha_Programada = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFecha_Registro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLIMITEDECUPOS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ClinicaDataSet4 = New ProyectoClinica.ClinicaDataSet4()
        Me.VLimiteCUPOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.V_LimiteCUPOSTableAdapter = New ProyectoClinica.ClinicaDataSet4TableAdapters.V_LimiteCUPOSTableAdapter()
        CType(Me.ClinicaDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicaDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VLimiteCBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicaDataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VLimiteCBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VLimiteCBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicaDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VLimiteCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VLimiteCBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VLimiteCBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicaDataSet3BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClinicaDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VLimiteCUPOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(269, 64)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "LIMITE DE CUPOS DE CADA MEDICO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(380, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 96)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "BUSCAR EN LA TABLA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cerrar
        '
        Me.cerrar.BackColor = System.Drawing.Color.Transparent
        Me.cerrar.BackgroundImage = CType(resources.GetObject("cerrar.BackgroundImage"), System.Drawing.Image)
        Me.cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cerrar.FlatAppearance.BorderSize = 0
        Me.cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon
        Me.cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cerrar.ForeColor = System.Drawing.Color.Black
        Me.cerrar.Location = New System.Drawing.Point(790, 61)
        Me.cerrar.Name = "cerrar"
        Me.cerrar.Size = New System.Drawing.Size(92, 69)
        Me.cerrar.TabIndex = 80
        Me.cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cerrar.UseVisualStyleBackColor = False
        '
        'V_MOSTRAR_HORARIOSTableAdapter
        '
        Me.V_MOSTRAR_HORARIOSTableAdapter.ClearBeforeFill = True
        '
        'VLimiteCBindingSource1
        '
        Me.VLimiteCBindingSource1.DataSource = Me.ClinicaDataSetBindingSource1
        '
        'VLimiteCBindingSource2
        '
        Me.VLimiteCBindingSource2.DataSource = Me.ClinicaDataSetBindingSource
        '
        'VLimiteCBindingSource3
        '
        Me.VLimiteCBindingSource3.DataMember = "V_LimiteC"
        Me.VLimiteCBindingSource3.DataSource = Me.ClinicaDataSet3
        '
        'ClinicaDataSet3
        '
        Me.ClinicaDataSet3.DataSetName = "ClinicaDataSet3"
        Me.ClinicaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClinicaDataSet
        ''
        'Me.ClinicaDataSet.DataSetName = "ClinicaDataSet"
        'Me.ClinicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VLimiteCBindingSource
        '
        'Me.VLimiteCBindingSource.DataMember = "V_LimiteC"
        'Me.VLimiteCBindingSource.DataSource = Me.ClinicaDataSet
        '
        'V_LimiteCTableAdapter
        '
        'Me.V_LimiteCTableAdapter.ClearBeforeFill = True
        '
        'V_LimiteCTableAdapter1
        '
        Me.V_LimiteCTableAdapter1.ClearBeforeFill = True
        '
        'VLimiteCBindingSource4
        '
        Me.VLimiteCBindingSource4.DataMember = "V_LimiteC"
        Me.VLimiteCBindingSource4.DataSource = Me.ClinicaDataSet3
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.VLimiteCUPOSBindingSource
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GridControl1.Location = New System.Drawing.Point(0, 161)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(904, 259)
        Me.GridControl1.TabIndex = 82
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'VLimiteCBindingSource5
        '
        Me.VLimiteCBindingSource5.DataMember = "V_LimiteC"
        Me.VLimiteCBindingSource5.DataSource = Me.ClinicaDataSet3BindingSource
        '
        'ClinicaDataSet3BindingSource
        '
        Me.ClinicaDataSet3BindingSource.DataSource = Me.ClinicaDataSet3
        Me.ClinicaDataSet3BindingSource.Position = 0
        '
        'GridView1
        '
        Me.GridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.SystemColors.Control
        Me.GridView1.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.SystemColors.Control
        Me.GridView1.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Arial Unicode MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseFont = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.DodgerBlue
        Me.GridView1.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GridView1.Appearance.FilterPanel.BorderColor = System.Drawing.Color.Blue
        Me.GridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Green
        Me.GridView1.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GridView1.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.DodgerBlue
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.DodgerBlue
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.FooterPanel.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.GridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Green
        Me.GridView1.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.HeaderPanel.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.GridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.Row.FontStyleDelta = System.Drawing.FontStyle.Bold
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.Row.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colMEDICO, Me.colDia, Me.colFecha_Programada, Me.colFecha_Registro, Me.colLIMITEDECUPOS})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "MEDICO", Nothing, "")})
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.Text
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'colMEDICO
        '
        Me.colMEDICO.FieldName = "MEDICO"
        Me.colMEDICO.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText
        Me.colMEDICO.Name = "colMEDICO"
        Me.colMEDICO.OptionsColumn.FixedWidth = True
        Me.colMEDICO.OptionsColumn.ReadOnly = True
        Me.colMEDICO.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)})
        Me.colMEDICO.Visible = True
        Me.colMEDICO.VisibleIndex = 0
        '
        'colDia
        '
        Me.colDia.FieldName = "Dia"
        Me.colDia.Name = "colDia"
        Me.colDia.OptionsColumn.FixedWidth = True
        Me.colDia.OptionsColumn.ReadOnly = True
        Me.colDia.Visible = True
        Me.colDia.VisibleIndex = 1
        '
        'colFecha_Programada
        '
        Me.colFecha_Programada.FieldName = "Fecha_Programada"
        Me.colFecha_Programada.Name = "colFecha_Programada"
        Me.colFecha_Programada.OptionsColumn.FixedWidth = True
        Me.colFecha_Programada.OptionsColumn.ReadOnly = True
        Me.colFecha_Programada.Visible = True
        Me.colFecha_Programada.VisibleIndex = 2
        '
        'colFecha_Registro
        '
        Me.colFecha_Registro.FieldName = "Fecha_Registro"
        Me.colFecha_Registro.Name = "colFecha_Registro"
        Me.colFecha_Registro.OptionsColumn.FixedWidth = True
        Me.colFecha_Registro.OptionsColumn.ReadOnly = True
        Me.colFecha_Registro.Visible = True
        Me.colFecha_Registro.VisibleIndex = 3
        '
        'colLIMITEDECUPOS
        '
        Me.colLIMITEDECUPOS.FieldName = "LIMITE DE CUPOS"
        Me.colLIMITEDECUPOS.Name = "colLIMITEDECUPOS"
        Me.colLIMITEDECUPOS.OptionsColumn.FixedWidth = True
        Me.colLIMITEDECUPOS.OptionsColumn.ReadOnly = True
        Me.colLIMITEDECUPOS.Visible = True
        Me.colLIMITEDECUPOS.VisibleIndex = 4
        '
        'ClinicaDataSet4
        '
        Me.ClinicaDataSet4.DataSetName = "ClinicaDataSet4"
        Me.ClinicaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VLimiteCUPOSBindingSource
        '
        Me.VLimiteCUPOSBindingSource.DataMember = "V_LimiteCUPOS"
        Me.VLimiteCUPOSBindingSource.DataSource = Me.ClinicaDataSet4
        '
        'V_LimiteCUPOSTableAdapter
        '
        Me.V_LimiteCUPOSTableAdapter.ClearBeforeFill = True
        '
        'LIMITECUPOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(904, 420)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.cerrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Location = New System.Drawing.Point(250, 50)
        Me.Name = "LIMITECUPOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIMITECUPOS"
        CType(Me.ClinicaDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicaDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VLimiteCBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicaDataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VLimiteCBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VLimiteCBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicaDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.ClinicaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VLimiteCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VLimiteCBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VLimiteCBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicaDataSet3BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClinicaDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VLimiteCUPOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cerrar As Button
    Friend WithEvents V_MOSTRAR_HORARIOSTableAdapter As ClinicaDataSet2TableAdapters.V_MOSTRAR_HORARIOSTableAdapter
    Friend WithEvents ClinicaDataSet2BindingSource As BindingSource
    Friend WithEvents ClinicaDataSetBindingSource As BindingSource
    Friend WithEvents VLimiteCBindingSource1 As BindingSource
    Friend WithEvents ClinicaDataSetBindingSource1 As BindingSource
    Friend WithEvents VLimiteCBindingSource2 As BindingSource
    'Friend WithEvents ClinicaDataSet As ClinicaDataSet
    Friend WithEvents VLimiteCBindingSource As BindingSource
    'Friend WithEvents V_LimiteCTableAdapter As ClinicaDataSetTableAdapters.V_LimiteCTableAdapter
    Friend WithEvents ClinicaDataSet3 As ClinicaDataSet3
    Friend WithEvents VLimiteCBindingSource3 As BindingSource
    Friend WithEvents V_LimiteCTableAdapter1 As ClinicaDataSet3TableAdapters.V_LimiteCTableAdapter
    Friend WithEvents VLimiteCBindingSource4 As BindingSource
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents VLimiteCBindingSource5 As BindingSource
    Friend WithEvents ClinicaDataSet3BindingSource As BindingSource
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colMEDICO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha_Programada As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFecha_Registro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLIMITEDECUPOS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ClinicaDataSet4 As ClinicaDataSet4
    Friend WithEvents VLimiteCUPOSBindingSource As BindingSource
    Friend WithEvents V_LimiteCUPOSTableAdapter As ClinicaDataSet4TableAdapters.V_LimiteCUPOSTableAdapter
End Class
