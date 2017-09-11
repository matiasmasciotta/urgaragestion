<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioAuditor
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.botonExcel = New System.Windows.Forms.PictureBox()
        Me.GridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBeneficiario = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblfechahasta = New System.Windows.Forms.Label()
        Me.lblfechadesde = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.txtFechaHasta = New System.Windows.Forms.TextBox()
        Me.checkFecha = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFechaDesde = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.botonAprobar = New System.Windows.Forms.Button()
        Me.botonDesaprobar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GridView2 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.clbimagen = New System.Windows.Forms.CheckedListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPicture = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GridView3 = New System.Windows.Forms.DataGridView()
        Me.lblReintegroPendiente = New System.Windows.Forms.Label()
        Me.lblReintegroAprobado = New System.Windows.Forms.Label()
        Me.lblReintegroRechazado = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.txtPorcAM = New System.Windows.Forms.TextBox()
        Me.txtObservacionesAM = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.botonExcel2 = New System.Windows.Forms.PictureBox()
        Me.botonExcel3 = New System.Windows.Forms.PictureBox()
        CType(Me.botonExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.botonExcel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.botonExcel3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'botonExcel
        '
        Me.botonExcel.Image = Global.WindowsApplication1.My.Resources.Resources.logoexcelsistemaa
        Me.botonExcel.Location = New System.Drawing.Point(510, 179)
        Me.botonExcel.Name = "botonExcel"
        Me.botonExcel.Size = New System.Drawing.Size(28, 22)
        Me.botonExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.botonExcel.TabIndex = 81
        Me.botonExcel.TabStop = False
        '
        'GridView1
        '
        Me.GridView1.AllowUserToAddRows = False
        Me.GridView1.BackgroundColor = System.Drawing.Color.SeaShell
        Me.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView1.Location = New System.Drawing.Point(12, 206)
        Me.GridView1.MultiSelect = False
        Me.GridView1.Name = "GridView1"
        Me.GridView1.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.GridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridView1.Size = New System.Drawing.Size(540, 364)
        Me.GridView1.TabIndex = 80
        Me.GridView1.VirtualMode = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(636, 608)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(76, 30)
        Me.Button1.TabIndex = 79
        Me.Button1.Text = "volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Detalle a Buscar:"
        '
        'txtBeneficiario
        '
        Me.txtBeneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeneficiario.Location = New System.Drawing.Point(46, 25)
        Me.txtBeneficiario.MaxLength = 13
        Me.txtBeneficiario.Name = "txtBeneficiario"
        Me.txtBeneficiario.Size = New System.Drawing.Size(286, 20)
        Me.txtBeneficiario.TabIndex = 82
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
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(32, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 84)
        Me.GroupBox1.TabIndex = 83
        Me.GroupBox1.TabStop = False
        '
        'lblfechahasta
        '
        Me.lblfechahasta.AutoSize = True
        Me.lblfechahasta.Location = New System.Drawing.Point(374, 12)
        Me.lblfechahasta.Name = "lblfechahasta"
        Me.lblfechahasta.Size = New System.Drawing.Size(82, 13)
        Me.lblfechahasta.TabIndex = 23
        Me.lblfechahasta.Text = "Año - Mes - Día"
        Me.lblfechahasta.Visible = False
        '
        'lblfechadesde
        '
        Me.lblfechadesde.AutoSize = True
        Me.lblfechadesde.Location = New System.Drawing.Point(120, 12)
        Me.lblfechadesde.Name = "lblfechadesde"
        Me.lblfechadesde.Size = New System.Drawing.Size(82, 13)
        Me.lblfechadesde.TabIndex = 22
        Me.lblfechadesde.Text = "Año - Mes - Día"
        Me.lblfechadesde.Visible = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(372, 56)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 21
        Me.DateTimePicker2.Visible = False
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaHasta.Location = New System.Drawing.Point(372, 28)
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Size = New System.Drawing.Size(200, 22)
        Me.txtFechaHasta.TabIndex = 12
        Me.txtFechaHasta.Visible = False
        '
        'checkFecha
        '
        Me.checkFecha.AutoSize = True
        Me.checkFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkFecha.Location = New System.Drawing.Point(4, -1)
        Me.checkFecha.Name = "checkFecha"
        Me.checkFecha.Size = New System.Drawing.Size(115, 19)
        Me.checkFecha.TabIndex = 18
        Me.checkFecha.Text = "Filtrar por Fecha"
        Me.checkFecha.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(328, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Hasta"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Fecha Desde:"
        Me.Label2.Visible = False
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaDesde.Location = New System.Drawing.Point(117, 28)
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.Size = New System.Drawing.Size(201, 22)
        Me.txtFechaDesde.TabIndex = 11
        Me.txtFechaDesde.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(117, 54)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(201, 20)
        Me.DateTimePicker1.TabIndex = 46
        Me.DateTimePicker1.Visible = False
        '
        'botonAprobar
        '
        Me.botonAprobar.BackColor = System.Drawing.Color.YellowGreen
        Me.botonAprobar.Location = New System.Drawing.Point(636, 242)
        Me.botonAprobar.Name = "botonAprobar"
        Me.botonAprobar.Size = New System.Drawing.Size(94, 34)
        Me.botonAprobar.TabIndex = 85
        Me.botonAprobar.Text = "Aprobar"
        Me.botonAprobar.UseVisualStyleBackColor = False
        Me.botonAprobar.Visible = False
        '
        'botonDesaprobar
        '
        Me.botonDesaprobar.BackColor = System.Drawing.Color.Silver
        Me.botonDesaprobar.Location = New System.Drawing.Point(636, 285)
        Me.botonDesaprobar.Name = "botonDesaprobar"
        Me.botonDesaprobar.Size = New System.Drawing.Size(94, 34)
        Me.botonDesaprobar.TabIndex = 86
        Me.botonDesaprobar.Text = "Desaprobar"
        Me.botonDesaprobar.UseVisualStyleBackColor = False
        Me.botonDesaprobar.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(233, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Pendientes"
        '
        'GridView2
        '
        Me.GridView2.AllowUserToAddRows = False
        Me.GridView2.BackgroundColor = System.Drawing.Color.Honeydew
        Me.GridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView2.Location = New System.Drawing.Point(792, 93)
        Me.GridView2.MultiSelect = False
        Me.GridView2.Name = "GridView2"
        Me.GridView2.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.GridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.GridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridView2.Size = New System.Drawing.Size(600, 133)
        Me.GridView2.TabIndex = 88
        Me.GridView2.VirtualMode = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1044, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 16)
        Me.Label5.TabIndex = 89
        Me.Label5.Text = "Aprobados"
        '
        'clbimagen
        '
        Me.clbimagen.BackColor = System.Drawing.Color.Silver
        Me.clbimagen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clbimagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbimagen.FormattingEnabled = True
        Me.clbimagen.Location = New System.Drawing.Point(581, 478)
        Me.clbimagen.Name = "clbimagen"
        Me.clbimagen.Size = New System.Drawing.Size(194, 80)
        Me.clbimagen.TabIndex = 90
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.rec2
        Me.PictureBox1.Location = New System.Drawing.Point(572, 468)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 91
        Me.PictureBox1.TabStop = False
        '
        'lblPicture
        '
        Me.lblPicture.Location = New System.Drawing.Point(600, 331)
        Me.lblPicture.Name = "lblPicture"
        Me.lblPicture.Size = New System.Drawing.Size(163, 131)
        Me.lblPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lblPicture.TabIndex = 92
        Me.lblPicture.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1044, 364)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 16)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Rechazados"
        '
        'GridView3
        '
        Me.GridView3.AllowUserToAddRows = False
        Me.GridView3.BackgroundColor = System.Drawing.Color.MistyRose
        Me.GridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView3.Location = New System.Drawing.Point(792, 386)
        Me.GridView3.MultiSelect = False
        Me.GridView3.Name = "GridView3"
        Me.GridView3.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridView3.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.GridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.GridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridView3.Size = New System.Drawing.Size(600, 257)
        Me.GridView3.TabIndex = 93
        Me.GridView3.VirtualMode = True
        '
        'lblReintegroPendiente
        '
        Me.lblReintegroPendiente.AutoSize = True
        Me.lblReintegroPendiente.Location = New System.Drawing.Point(186, 577)
        Me.lblReintegroPendiente.Name = "lblReintegroPendiente"
        Me.lblReintegroPendiente.Size = New System.Drawing.Size(28, 13)
        Me.lblReintegroPendiente.TabIndex = 95
        Me.lblReintegroPendiente.Text = "       "
        '
        'lblReintegroAprobado
        '
        Me.lblReintegroAprobado.AutoSize = True
        Me.lblReintegroAprobado.Location = New System.Drawing.Point(1169, 71)
        Me.lblReintegroAprobado.Name = "lblReintegroAprobado"
        Me.lblReintegroAprobado.Size = New System.Drawing.Size(28, 13)
        Me.lblReintegroAprobado.TabIndex = 96
        Me.lblReintegroAprobado.Text = "       "
        '
        'lblReintegroRechazado
        '
        Me.lblReintegroRechazado.AutoSize = True
        Me.lblReintegroRechazado.Location = New System.Drawing.Point(1169, 366)
        Me.lblReintegroRechazado.Name = "lblReintegroRechazado"
        Me.lblReintegroRechazado.Size = New System.Drawing.Size(28, 13)
        Me.lblReintegroRechazado.TabIndex = 97
        Me.lblReintegroRechazado.Text = "       "
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape3, Me.RectangleShape2, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1404, 679)
        Me.ShapeContainer1.TabIndex = 98
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape3
        '
        Me.RectangleShape3.Location = New System.Drawing.Point(792, 360)
        Me.RectangleShape3.Name = "RectangleShape3"
        Me.RectangleShape3.Size = New System.Drawing.Size(599, 23)
        '
        'RectangleShape2
        '
        Me.RectangleShape2.Location = New System.Drawing.Point(792, 65)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(599, 23)
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(12, 178)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(539, 24)
        '
        'CANCELA
        '
        Me.CANCELA.BackColor = System.Drawing.Color.Chocolate
        Me.CANCELA.Location = New System.Drawing.Point(810, 306)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(49, 25)
        Me.CANCELA.TabIndex = 100
        Me.CANCELA.Text = "Cancelar"
        Me.CANCELA.UseVisualStyleBackColor = False
        Me.CANCELA.Visible = False
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.OK.Location = New System.Drawing.Point(810, 262)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(49, 26)
        Me.OK.TabIndex = 99
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = False
        Me.OK.Visible = False
        '
        'txtPorcAM
        '
        Me.txtPorcAM.Location = New System.Drawing.Point(890, 263)
        Me.txtPorcAM.MaxLength = 3
        Me.txtPorcAM.Name = "txtPorcAM"
        Me.txtPorcAM.Size = New System.Drawing.Size(55, 20)
        Me.txtPorcAM.TabIndex = 101
        Me.txtPorcAM.Visible = False
        '
        'txtObservacionesAM
        '
        Me.txtObservacionesAM.Location = New System.Drawing.Point(889, 309)
        Me.txtObservacionesAM.MaxLength = 120
        Me.txtObservacionesAM.Name = "txtObservacionesAM"
        Me.txtObservacionesAM.Size = New System.Drawing.Size(379, 20)
        Me.txtObservacionesAM.TabIndex = 102
        Me.txtObservacionesAM.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(887, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 103
        Me.Label7.Text = "Porcentaje Reintegro"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(887, 293)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 13)
        Me.Label8.TabIndex = 104
        Me.Label8.Text = "Observaciones del Auditor Medico"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(947, 265)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 16)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = "%"
        '
        'botonExcel2
        '
        Me.botonExcel2.Image = Global.WindowsApplication1.My.Resources.Resources.logoexcelsistemaa
        Me.botonExcel2.Location = New System.Drawing.Point(1354, 66)
        Me.botonExcel2.Name = "botonExcel2"
        Me.botonExcel2.Size = New System.Drawing.Size(28, 22)
        Me.botonExcel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.botonExcel2.TabIndex = 106
        Me.botonExcel2.TabStop = False
        '
        'botonExcel3
        '
        Me.botonExcel3.Image = Global.WindowsApplication1.My.Resources.Resources.logoexcelsistemaa
        Me.botonExcel3.Location = New System.Drawing.Point(1354, 361)
        Me.botonExcel3.Name = "botonExcel3"
        Me.botonExcel3.Size = New System.Drawing.Size(28, 22)
        Me.botonExcel3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.botonExcel3.TabIndex = 107
        Me.botonExcel3.TabStop = False
        '
        'FormularioAuditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1404, 679)
        Me.Controls.Add(Me.botonExcel3)
        Me.Controls.Add(Me.botonExcel2)
        Me.Controls.Add(Me.GridView2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtObservacionesAM)
        Me.Controls.Add(Me.txtPorcAM)
        Me.Controls.Add(Me.CANCELA)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.lblReintegroRechazado)
        Me.Controls.Add(Me.lblReintegroAprobado)
        Me.Controls.Add(Me.lblReintegroPendiente)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GridView3)
        Me.Controls.Add(Me.lblPicture)
        Me.Controls.Add(Me.clbimagen)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.botonDesaprobar)
        Me.Controls.Add(Me.botonAprobar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBeneficiario)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.botonExcel)
        Me.Controls.Add(Me.GridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "FormularioAuditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auditor Medico"
        CType(Me.botonExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.botonExcel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.botonExcel3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents botonExcel As System.Windows.Forms.PictureBox
    Friend WithEvents GridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBeneficiario As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblfechahasta As System.Windows.Forms.Label
    Friend WithEvents lblfechadesde As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFechaHasta As System.Windows.Forms.TextBox
    Friend WithEvents checkFecha As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFechaDesde As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents botonAprobar As System.Windows.Forms.Button
    Friend WithEvents botonDesaprobar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents clbimagen As System.Windows.Forms.CheckedListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPicture As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents lblReintegroPendiente As System.Windows.Forms.Label
    Friend WithEvents lblReintegroAprobado As System.Windows.Forms.Label
    Friend WithEvents lblReintegroRechazado As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents CANCELA As System.Windows.Forms.Button
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents txtPorcAM As System.Windows.Forms.TextBox
    Friend WithEvents txtObservacionesAM As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents botonExcel2 As System.Windows.Forms.PictureBox
    Friend WithEvents botonExcel3 As System.Windows.Forms.PictureBox
End Class
