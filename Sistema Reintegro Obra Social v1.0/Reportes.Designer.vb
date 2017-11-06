<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reportes))
        Me.GridView1 = New System.Windows.Forms.DataGridView()
        Me.Boton_Salir = New System.Windows.Forms.Button()
        Me.txtFechaDesde = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFechaHasta = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.lblfechadesde = New System.Windows.Forms.Label()
        Me.lblfechahasta = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.checkFecha = New System.Windows.Forms.CheckBox()
        Me.botonExcel = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGridSeccionales = New System.Windows.Forms.DataGridView()
        Me.txtSeccional = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logoURGARA = New System.Windows.Forms.PictureBox()
        Me.logoOSRGA = New System.Windows.Forms.PictureBox()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.botonExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridSeccionales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logoURGARA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logoOSRGA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView1
        '
        Me.GridView1.AllowUserToAddRows = False
        Me.GridView1.BackgroundColor = System.Drawing.Color.MidnightBlue
        Me.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView1.Location = New System.Drawing.Point(6, 180)
        Me.GridView1.MultiSelect = False
        Me.GridView1.Name = "GridView1"
        Me.GridView1.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.GridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridView1.Size = New System.Drawing.Size(1254, 441)
        Me.GridView1.TabIndex = 25
        Me.GridView1.VirtualMode = True
        '
        'Boton_Salir
        '
        Me.Boton_Salir.Image = CType(resources.GetObject("Boton_Salir.Image"), System.Drawing.Image)
        Me.Boton_Salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Boton_Salir.Location = New System.Drawing.Point(795, 635)
        Me.Boton_Salir.Name = "Boton_Salir"
        Me.Boton_Salir.Size = New System.Drawing.Size(448, 36)
        Me.Boton_Salir.TabIndex = 26
        Me.Boton_Salir.Text = "Salir"
        Me.Boton_Salir.UseVisualStyleBackColor = True
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaDesde.Location = New System.Drawing.Point(96, 29)
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.Size = New System.Drawing.Size(153, 22)
        Me.txtFechaDesde.TabIndex = 11
        Me.txtFechaDesde.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(10, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Fecha Desde:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(267, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Hasta"
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaHasta.Location = New System.Drawing.Point(315, 29)
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Size = New System.Drawing.Size(153, 22)
        Me.txtFechaHasta.TabIndex = 12
        Me.txtFechaHasta.Visible = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(315, 55)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(153, 20)
        Me.DateTimePicker2.TabIndex = 21
        Me.DateTimePicker2.Visible = False
        '
        'lblfechadesde
        '
        Me.lblfechadesde.AutoSize = True
        Me.lblfechadesde.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblfechadesde.Location = New System.Drawing.Point(117, 13)
        Me.lblfechadesde.Name = "lblfechadesde"
        Me.lblfechadesde.Size = New System.Drawing.Size(89, 13)
        Me.lblfechadesde.TabIndex = 22
        Me.lblfechadesde.Text = "aaaa  -  mm  -  dd"
        Me.lblfechadesde.Visible = False
        '
        'lblfechahasta
        '
        Me.lblfechahasta.AutoSize = True
        Me.lblfechahasta.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblfechahasta.Location = New System.Drawing.Point(342, 13)
        Me.lblfechahasta.Name = "lblfechahasta"
        Me.lblfechahasta.Size = New System.Drawing.Size(89, 13)
        Me.lblfechahasta.TabIndex = 23
        Me.lblfechahasta.Text = "aaaa  -  mm  -  dd"
        Me.lblfechahasta.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(96, 55)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(153, 20)
        Me.DateTimePicker1.TabIndex = 20
        Me.DateTimePicker1.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.lblfechahasta)
        Me.GroupBox1.Controls.Add(Me.lblfechadesde)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.txtFechaHasta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFechaDesde)
        Me.GroupBox1.Location = New System.Drawing.Point(566, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(694, 109)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'checkFecha
        '
        Me.checkFecha.AutoSize = True
        Me.checkFecha.BackColor = System.Drawing.Color.Transparent
        Me.checkFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.checkFecha.Location = New System.Drawing.Point(568, 9)
        Me.checkFecha.Name = "checkFecha"
        Me.checkFecha.Size = New System.Drawing.Size(115, 19)
        Me.checkFecha.TabIndex = 23
        Me.checkFecha.Text = "Filtrar por Fecha"
        Me.checkFecha.UseVisualStyleBackColor = False
        '
        'botonExcel
        '
        Me.botonExcel.BackColor = System.Drawing.Color.Transparent
        Me.botonExcel.Image = Global.WindowsApplication1.My.Resources.Resources.logoexcelsistemaa
        Me.botonExcel.Location = New System.Drawing.Point(379, 634)
        Me.botonExcel.Name = "botonExcel"
        Me.botonExcel.Size = New System.Drawing.Size(47, 46)
        Me.botonExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.botonExcel.TabIndex = 78
        Me.botonExcel.TabStop = False
        '
        'DataGridSeccionales
        '
        Me.DataGridSeccionales.BackgroundColor = System.Drawing.SystemColors.Highlight
        Me.DataGridSeccionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridSeccionales.Location = New System.Drawing.Point(277, 9)
        Me.DataGridSeccionales.MultiSelect = False
        Me.DataGridSeccionales.Name = "DataGridSeccionales"
        Me.DataGridSeccionales.ReadOnly = True
        Me.DataGridSeccionales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridSeccionales.Size = New System.Drawing.Size(260, 145)
        Me.DataGridSeccionales.TabIndex = 83
        Me.DataGridSeccionales.Visible = False
        '
        'txtSeccional
        '
        Me.txtSeccional.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeccional.Location = New System.Drawing.Point(103, 47)
        Me.txtSeccional.MaxLength = 13
        Me.txtSeccional.Name = "txtSeccional"
        Me.txtSeccional.Size = New System.Drawing.Size(242, 22)
        Me.txtSeccional.TabIndex = 81
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(28, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Seccional:"
        '
        'logoURGARA
        '
        Me.logoURGARA.BackColor = System.Drawing.Color.Transparent
        Me.logoURGARA.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Marca_URGARA
        Me.logoURGARA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logoURGARA.Location = New System.Drawing.Point(41, 107)
        Me.logoURGARA.Name = "logoURGARA"
        Me.logoURGARA.Size = New System.Drawing.Size(95, 47)
        Me.logoURGARA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoURGARA.TabIndex = 85
        Me.logoURGARA.TabStop = False
        '
        'logoOSRGA
        '
        Me.logoOSRGA.BackColor = System.Drawing.Color.Transparent
        Me.logoOSRGA.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Marca_OSRGA2
        Me.logoOSRGA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logoOSRGA.Location = New System.Drawing.Point(143, 107)
        Me.logoOSRGA.Name = "logoOSRGA"
        Me.logoOSRGA.Size = New System.Drawing.Size(95, 47)
        Me.logoOSRGA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoOSRGA.TabIndex = 84
        Me.logoOSRGA.TabStop = False
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1267, 683)
        Me.Controls.Add(Me.logoURGARA)
        Me.Controls.Add(Me.logoOSRGA)
        Me.Controls.Add(Me.DataGridSeccionales)
        Me.Controls.Add(Me.txtSeccional)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.botonExcel)
        Me.Controls.Add(Me.Boton_Salir)
        Me.Controls.Add(Me.GridView1)
        Me.Controls.Add(Me.checkFecha)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Reportes"
        Me.Text = "Reportes"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.botonExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridSeccionales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logoURGARA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logoOSRGA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Boton_Salir As System.Windows.Forms.Button
    Friend WithEvents txtFechaDesde As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFechaHasta As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblfechadesde As System.Windows.Forms.Label
    Friend WithEvents lblfechahasta As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents checkFecha As System.Windows.Forms.CheckBox
    Friend WithEvents botonExcel As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DataGridSeccionales As System.Windows.Forms.DataGridView
    Friend WithEvents txtSeccional As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents logoURGARA As System.Windows.Forms.PictureBox
    Friend WithEvents logoOSRGA As System.Windows.Forms.PictureBox
End Class
