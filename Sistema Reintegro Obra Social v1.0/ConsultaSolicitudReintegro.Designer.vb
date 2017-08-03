<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaSolicitudReintegro
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.checkFecha = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GridView1 = New System.Windows.Forms.DataGridView()
        Me.txtBeneficiario = New System.Windows.Forms.TextBox()
        Me.txtFechaHasta = New System.Windows.Forms.TextBox()
        Me.txtFechaDesde = New System.Windows.Forms.TextBox()
        Me.Boton_Salir = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblfechahasta = New System.Windows.Forms.Label()
        Me.lblfechadesde = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.clbimagen = New System.Windows.Forms.CheckedListBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.lblPicture = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.lblPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'checkFecha
        '
        Me.checkFecha.AutoSize = True
        Me.checkFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkFecha.Location = New System.Drawing.Point(7, -3)
        Me.checkFecha.Name = "checkFecha"
        Me.checkFecha.Size = New System.Drawing.Size(141, 20)
        Me.checkFecha.TabIndex = 18
        Me.checkFecha.Text = "Filtrar por Fecha"
        Me.checkFecha.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(330, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Fecha Desde:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Detalle a Buscar:"
        '
        'GridView1
        '
        Me.GridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView1.Location = New System.Drawing.Point(15, 157)
        Me.GridView1.MultiSelect = False
        Me.GridView1.Name = "GridView1"
        Me.GridView1.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.GridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.GridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridView1.Size = New System.Drawing.Size(618, 446)
        Me.GridView1.TabIndex = 14
        Me.GridView1.VirtualMode = True
        '
        'txtBeneficiario
        '
        Me.txtBeneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeneficiario.Location = New System.Drawing.Point(169, 12)
        Me.txtBeneficiario.MaxLength = 13
        Me.txtBeneficiario.Name = "txtBeneficiario"
        Me.txtBeneficiario.Size = New System.Drawing.Size(286, 22)
        Me.txtBeneficiario.TabIndex = 13
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaHasta.Location = New System.Drawing.Point(385, 44)
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Size = New System.Drawing.Size(200, 22)
        Me.txtFechaHasta.TabIndex = 12
        Me.txtFechaHasta.Visible = False
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaDesde.Location = New System.Drawing.Point(121, 44)
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.Size = New System.Drawing.Size(201, 22)
        Me.txtFechaDesde.TabIndex = 11
        Me.txtFechaDesde.Visible = False
        '
        'Boton_Salir
        '
        Me.Boton_Salir.Location = New System.Drawing.Point(859, 609)
        Me.Boton_Salir.Name = "Boton_Salir"
        Me.Boton_Salir.Size = New System.Drawing.Size(95, 36)
        Me.Boton_Salir.TabIndex = 19
        Me.Boton_Salir.Text = "Salir"
        Me.Boton_Salir.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(136, 118)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(201, 20)
        Me.DateTimePicker1.TabIndex = 20
        Me.DateTimePicker1.Visible = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(385, 72)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 21
        Me.DateTimePicker2.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblfechahasta)
        Me.GroupBox1.Controls.Add(Me.lblfechadesde)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.txtFechaHasta)
        Me.GroupBox1.Controls.Add(Me.checkFecha)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFechaDesde)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 105)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'lblfechahasta
        '
        Me.lblfechahasta.AutoSize = True
        Me.lblfechahasta.Location = New System.Drawing.Point(395, 28)
        Me.lblfechahasta.Name = "lblfechahasta"
        Me.lblfechahasta.Size = New System.Drawing.Size(94, 13)
        Me.lblfechahasta.TabIndex = 23
        Me.lblfechahasta.Text = "Año  -  Mes  -  Día"
        Me.lblfechahasta.Visible = False
        '
        'lblfechadesde
        '
        Me.lblfechadesde.AutoSize = True
        Me.lblfechadesde.Location = New System.Drawing.Point(130, 28)
        Me.lblfechadesde.Name = "lblfechadesde"
        Me.lblfechadesde.Size = New System.Drawing.Size(94, 13)
        Me.lblfechadesde.TabIndex = 22
        Me.lblfechadesde.Text = "Año  -  Mes  -  Día"
        Me.lblfechadesde.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(282, 609)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 36)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "IMPRIMIR PDF"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'clbimagen
        '
        Me.clbimagen.BackColor = System.Drawing.Color.LawnGreen
        Me.clbimagen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clbimagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbimagen.FormattingEnabled = True
        Me.clbimagen.Location = New System.Drawing.Point(768, 157)
        Me.clbimagen.Name = "clbimagen"
        Me.clbimagen.Size = New System.Drawing.Size(250, 96)
        Me.clbimagen.TabIndex = 24
        '
        'PrintDocument1
        '
        '
        'lblPicture
        '
        Me.lblPicture.Location = New System.Drawing.Point(705, 323)
        Me.lblPicture.Name = "lblPicture"
        Me.lblPicture.Size = New System.Drawing.Size(385, 283)
        Me.lblPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lblPicture.TabIndex = 25
        Me.lblPicture.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.oval_23967_960_720
        Me.PictureBox1.Location = New System.Drawing.Point(683, 86)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(430, 234)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(839, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Imagenes adjuntas"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(856, 305)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Vista Previa"
        '
        'ConsultaSolicitudReintegro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SteelBlue
        Me.ClientSize = New System.Drawing.Size(1249, 654)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPicture)
        Me.Controls.Add(Me.clbimagen)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Boton_Salir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridView1)
        Me.Controls.Add(Me.txtBeneficiario)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "ConsultaSolicitudReintegro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Solicitudes de Reintegro Generadas"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.lblPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents checkFecha As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtBeneficiario As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaHasta As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaDesde As System.Windows.Forms.TextBox
    Friend WithEvents Boton_Salir As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblfechahasta As System.Windows.Forms.Label
    Friend WithEvents lblfechadesde As System.Windows.Forms.Label
    Friend WithEvents lblPicture As System.Windows.Forms.PictureBox
    Friend WithEvents clbimagen As System.Windows.Forms.CheckedListBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
