<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtFechaDesde = New System.Windows.Forms.TextBox()
        Me.txtFechaHasta = New System.Windows.Forms.TextBox()
        Me.txtBeneficiario = New System.Windows.Forms.TextBox()
        Me.GridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.checkFecha = New System.Windows.Forms.CheckBox()
        Me.checkUrgara = New System.Windows.Forms.CheckBox()
        Me.checkObraSocial = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtFechaReintegro = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(222, 578)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.Location = New System.Drawing.Point(111, 82)
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.Size = New System.Drawing.Size(156, 20)
        Me.txtFechaDesde.TabIndex = 1
        Me.txtFechaDesde.Visible = False
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.Location = New System.Drawing.Point(325, 82)
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Size = New System.Drawing.Size(164, 20)
        Me.txtFechaHasta.TabIndex = 2
        Me.txtFechaHasta.Visible = False
        '
        'txtBeneficiario
        '
        Me.txtBeneficiario.Location = New System.Drawing.Point(128, 22)
        Me.txtBeneficiario.MaxLength = 13
        Me.txtBeneficiario.Name = "txtBeneficiario"
        Me.txtBeneficiario.Size = New System.Drawing.Size(191, 20)
        Me.txtBeneficiario.TabIndex = 3
        '
        'GridView1
        '
        Me.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView1.Location = New System.Drawing.Point(10, 164)
        Me.GridView1.MultiSelect = False
        Me.GridView1.Name = "GridView1"
        Me.GridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridView1.Size = New System.Drawing.Size(1086, 408)
        Me.GridView1.TabIndex = 5
        Me.GridView1.VirtualMode = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Texto a Buscar:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Fecha Desde:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(284, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Hasta"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(77, 578)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 30)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Generar PDF"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'checkFecha
        '
        Me.checkFecha.AutoSize = True
        Me.checkFecha.Location = New System.Drawing.Point(34, 59)
        Me.checkFecha.Name = "checkFecha"
        Me.checkFecha.Size = New System.Drawing.Size(102, 17)
        Me.checkFecha.TabIndex = 10
        Me.checkFecha.Text = "Filtrar por Fecha"
        Me.checkFecha.UseVisualStyleBackColor = True
        '
        'checkUrgara
        '
        Me.checkUrgara.AutoSize = True
        Me.checkUrgara.Location = New System.Drawing.Point(139, 125)
        Me.checkUrgara.Name = "checkUrgara"
        Me.checkUrgara.Size = New System.Drawing.Size(128, 17)
        Me.checkUrgara.TabIndex = 11
        Me.checkUrgara.Text = "A Cargo de URGARA"
        Me.checkUrgara.UseVisualStyleBackColor = True
        '
        'checkObraSocial
        '
        Me.checkObraSocial.AutoSize = True
        Me.checkObraSocial.Location = New System.Drawing.Point(296, 125)
        Me.checkObraSocial.Name = "checkObraSocial"
        Me.checkObraSocial.Size = New System.Drawing.Size(137, 17)
        Me.checkObraSocial.TabIndex = 12
        Me.checkObraSocial.Text = "A Cargo de Obra Social"
        Me.checkObraSocial.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(397, 586)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(161, 17)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "PAGADO / REINTEGRADO"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtFechaReintegro
        '
        Me.txtFechaReintegro.Location = New System.Drawing.Point(686, 588)
        Me.txtFechaReintegro.Name = "txtFechaReintegro"
        Me.txtFechaReintegro.Size = New System.Drawing.Size(96, 20)
        Me.txtFechaReintegro.TabIndex = 15
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(573, 587)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(104, 13)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "Fecha de Reintegro:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(580, 618)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Valor Reintegrado: $180"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(508, 125)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(116, 17)
        Me.RadioButton1.TabIndex = 17
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Pendiente de Pago"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(847, 61)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(71, 64)
        Me.Button3.TabIndex = 18
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1108, 642)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtFechaReintegro)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.checkObraSocial)
        Me.Controls.Add(Me.checkUrgara)
        Me.Controls.Add(Me.checkFecha)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridView1)
        Me.Controls.Add(Me.txtBeneficiario)
        Me.Controls.Add(Me.txtFechaHasta)
        Me.Controls.Add(Me.txtFechaDesde)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Consulta"
        Me.Text = "Consultas"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtFechaDesde As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaHasta As System.Windows.Forms.TextBox
    Friend WithEvents txtBeneficiario As System.Windows.Forms.TextBox
    Friend WithEvents GridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents checkFecha As System.Windows.Forms.CheckBox
    Friend WithEvents checkUrgara As System.Windows.Forms.CheckBox
    Friend WithEvents checkObraSocial As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtFechaReintegro As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
