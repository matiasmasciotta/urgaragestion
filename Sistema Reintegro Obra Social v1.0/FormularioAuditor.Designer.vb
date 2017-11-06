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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioAuditor))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.botonLimpiarFiltroFechas = New System.Windows.Forms.Button()
        Me.txtFechaDesde = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.checkFecha = New System.Windows.Forms.CheckBox()
        Me.GridView2 = New System.Windows.Forms.DataGridView()
        Me.clbimagen = New System.Windows.Forms.CheckedListBox()
        Me.GridView3 = New System.Windows.Forms.DataGridView()
        Me.lblReintegroPendiente = New System.Windows.Forms.Label()
        Me.lblReintegroAprobado = New System.Windows.Forms.Label()
        Me.lblReintegroRechazado = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.panelAuditor = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.shapePendientes = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.txtPorcAM = New System.Windows.Forms.TextBox()
        Me.txtObservacionesAM = New System.Windows.Forms.TextBox()
        Me.lblporcentaje = New System.Windows.Forms.Label()
        Me.lblobsam = New System.Windows.Forms.Label()
        Me.lblporc = New System.Windows.Forms.Label()
        Me.opBuscaNumReintegro = New System.Windows.Forms.RadioButton()
        Me.opBuscarDNI = New System.Windows.Forms.RadioButton()
        Me.txtNumReintegroBusqueda = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.opPAGADO = New System.Windows.Forms.CheckBox()
        Me.opPagoPendiente = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.opComisionRechazados = New System.Windows.Forms.CheckBox()
        Me.opComisionAprobados = New System.Windows.Forms.CheckBox()
        Me.opComisionPendientes = New System.Windows.Forms.CheckBox()
        Me.opSubsidio = New System.Windows.Forms.CheckBox()
        Me.opReintegro = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.opAuditorMedicoSI = New System.Windows.Forms.CheckBox()
        Me.opAuditorRechazado = New System.Windows.Forms.CheckBox()
        Me.opPendienteAuditor = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.botonExcel = New System.Windows.Forms.PictureBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.botonLimpiarFiltros = New System.Windows.Forms.Button()
        Me.botonExcel2 = New System.Windows.Forms.PictureBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.botonExcel3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPicture = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtuserseccional = New System.Windows.Forms.TextBox()
        Me.opSeccional = New System.Windows.Forms.CheckBox()
        Me.botonDesaprobar = New System.Windows.Forms.Button()
        Me.botonAprobar = New System.Windows.Forms.Button()
        Me.logoURGARA = New System.Windows.Forms.PictureBox()
        Me.logoOSRGA = New System.Windows.Forms.PictureBox()
        Me.GridViewSeccionales = New System.Windows.Forms.DataGridView()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.botonExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.botonExcel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.botonExcel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.logoURGARA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logoOSRGA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSeccionales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridView1
        '
        Me.GridView1.AllowUserToAddRows = False
        Me.GridView1.BackgroundColor = System.Drawing.Color.DimGray
        Me.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView1.Location = New System.Drawing.Point(3, 25)
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
        Me.GridView1.Size = New System.Drawing.Size(748, 307)
        Me.GridView1.TabIndex = 80
        Me.GridView1.VirtualMode = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(785, 646)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(434, 30)
        Me.Button1.TabIndex = 79
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Detalle a Buscar:"
        '
        'txtBeneficiario
        '
        Me.txtBeneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeneficiario.Location = New System.Drawing.Point(43, 41)
        Me.txtBeneficiario.MaxLength = 13
        Me.txtBeneficiario.Name = "txtBeneficiario"
        Me.txtBeneficiario.Size = New System.Drawing.Size(286, 20)
        Me.txtBeneficiario.TabIndex = 82
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblfechahasta)
        Me.GroupBox1.Controls.Add(Me.lblfechadesde)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.txtFechaHasta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.botonLimpiarFiltroFechas)
        Me.GroupBox1.Controls.Add(Me.txtFechaDesde)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(13, 102)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(761, 85)
        Me.GroupBox1.TabIndex = 83
        Me.GroupBox1.TabStop = False
        '
        'lblfechahasta
        '
        Me.lblfechahasta.AutoSize = True
        Me.lblfechahasta.Location = New System.Drawing.Point(337, 13)
        Me.lblfechahasta.Name = "lblfechahasta"
        Me.lblfechahasta.Size = New System.Drawing.Size(82, 13)
        Me.lblfechahasta.TabIndex = 23
        Me.lblfechahasta.Text = "Año - Mes - Día"
        Me.lblfechahasta.Visible = False
        '
        'lblfechadesde
        '
        Me.lblfechadesde.AutoSize = True
        Me.lblfechadesde.Location = New System.Drawing.Point(104, 13)
        Me.lblfechadesde.Name = "lblfechadesde"
        Me.lblfechadesde.Size = New System.Drawing.Size(82, 13)
        Me.lblfechadesde.TabIndex = 22
        Me.lblfechadesde.Text = "Año - Mes - Día"
        Me.lblfechadesde.Visible = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(335, 57)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(156, 20)
        Me.DateTimePicker2.TabIndex = 21
        Me.DateTimePicker2.Visible = False
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaHasta.Location = New System.Drawing.Point(335, 29)
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Size = New System.Drawing.Size(156, 22)
        Me.txtFechaHasta.TabIndex = 12
        Me.txtFechaHasta.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(293, 32)
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
        Me.Label2.Location = New System.Drawing.Point(9, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Fecha Desde:"
        Me.Label2.Visible = False
        '
        'botonLimpiarFiltroFechas
        '
        Me.botonLimpiarFiltroFechas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.botonLimpiarFiltroFechas.AutoEllipsis = True
        Me.botonLimpiarFiltroFechas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.botonLimpiarFiltroFechas.BackColor = System.Drawing.Color.Silver
        Me.botonLimpiarFiltroFechas.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._as
        Me.botonLimpiarFiltroFechas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.botonLimpiarFiltroFechas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.botonLimpiarFiltroFechas.Location = New System.Drawing.Point(516, 32)
        Me.botonLimpiarFiltroFechas.Name = "botonLimpiarFiltroFechas"
        Me.botonLimpiarFiltroFechas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.botonLimpiarFiltroFechas.Size = New System.Drawing.Size(38, 39)
        Me.botonLimpiarFiltroFechas.TabIndex = 119
        Me.botonLimpiarFiltroFechas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.botonLimpiarFiltroFechas.UseVisualStyleBackColor = False
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaDesde.Location = New System.Drawing.Point(101, 29)
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.Size = New System.Drawing.Size(161, 22)
        Me.txtFechaDesde.TabIndex = 11
        Me.txtFechaDesde.Visible = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(101, 55)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(161, 20)
        Me.DateTimePicker1.TabIndex = 46
        Me.DateTimePicker1.Visible = False
        '
        'checkFecha
        '
        Me.checkFecha.AutoSize = True
        Me.checkFecha.BackColor = System.Drawing.Color.Transparent
        Me.checkFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkFecha.Location = New System.Drawing.Point(12, 78)
        Me.checkFecha.Name = "checkFecha"
        Me.checkFecha.Size = New System.Drawing.Size(115, 19)
        Me.checkFecha.TabIndex = 18
        Me.checkFecha.Text = "Filtrar por Fecha"
        Me.checkFecha.UseVisualStyleBackColor = False
        '
        'GridView2
        '
        Me.GridView2.AllowUserToAddRows = False
        Me.GridView2.AllowUserToDeleteRows = False
        Me.GridView2.BackgroundColor = System.Drawing.Color.DarkGray
        Me.GridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView2.Location = New System.Drawing.Point(0, 56)
        Me.GridView2.MultiSelect = False
        Me.GridView2.Name = "GridView2"
        Me.GridView2.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.GridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridView2.Size = New System.Drawing.Size(751, 276)
        Me.GridView2.TabIndex = 88
        Me.GridView2.VirtualMode = True
        '
        'clbimagen
        '
        Me.clbimagen.BackColor = System.Drawing.Color.Silver
        Me.clbimagen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clbimagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbimagen.FormattingEnabled = True
        Me.clbimagen.Location = New System.Drawing.Point(275, 487)
        Me.clbimagen.Name = "clbimagen"
        Me.clbimagen.Size = New System.Drawing.Size(214, 80)
        Me.clbimagen.TabIndex = 90
        '
        'GridView3
        '
        Me.GridView3.AllowUserToAddRows = False
        Me.GridView3.BackgroundColor = System.Drawing.Color.MistyRose
        Me.GridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView3.Location = New System.Drawing.Point(0, 25)
        Me.GridView3.MultiSelect = False
        Me.GridView3.Name = "GridView3"
        Me.GridView3.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridView3.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.GridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.GridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridView3.Size = New System.Drawing.Size(754, 310)
        Me.GridView3.TabIndex = 93
        Me.GridView3.VirtualMode = True
        '
        'lblReintegroPendiente
        '
        Me.lblReintegroPendiente.AutoSize = True
        Me.lblReintegroPendiente.BackColor = System.Drawing.Color.Transparent
        Me.lblReintegroPendiente.Location = New System.Drawing.Point(1115, 499)
        Me.lblReintegroPendiente.Name = "lblReintegroPendiente"
        Me.lblReintegroPendiente.Size = New System.Drawing.Size(28, 13)
        Me.lblReintegroPendiente.TabIndex = 95
        Me.lblReintegroPendiente.Text = "       "
        Me.lblReintegroPendiente.Visible = False
        '
        'lblReintegroAprobado
        '
        Me.lblReintegroAprobado.AutoSize = True
        Me.lblReintegroAprobado.BackColor = System.Drawing.Color.Transparent
        Me.lblReintegroAprobado.Location = New System.Drawing.Point(1072, 463)
        Me.lblReintegroAprobado.Name = "lblReintegroAprobado"
        Me.lblReintegroAprobado.Size = New System.Drawing.Size(28, 13)
        Me.lblReintegroAprobado.TabIndex = 96
        Me.lblReintegroAprobado.Text = "       "
        Me.lblReintegroAprobado.Visible = False
        '
        'lblReintegroRechazado
        '
        Me.lblReintegroRechazado.AutoSize = True
        Me.lblReintegroRechazado.BackColor = System.Drawing.Color.Transparent
        Me.lblReintegroRechazado.Location = New System.Drawing.Point(1104, 476)
        Me.lblReintegroRechazado.Name = "lblReintegroRechazado"
        Me.lblReintegroRechazado.Size = New System.Drawing.Size(28, 13)
        Me.lblReintegroRechazado.TabIndex = 97
        Me.lblReintegroRechazado.Text = "       "
        Me.lblReintegroRechazado.Visible = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.panelAuditor, Me.shapePendientes})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1237, 684)
        Me.ShapeContainer1.TabIndex = 98
        Me.ShapeContainer1.TabStop = False
        '
        'panelAuditor
        '
        Me.panelAuditor.Location = New System.Drawing.Point(785, 281)
        Me.panelAuditor.Name = "panelAuditor"
        Me.panelAuditor.Size = New System.Drawing.Size(433, 128)
        Me.panelAuditor.Visible = False
        '
        'shapePendientes
        '
        Me.shapePendientes.BackColor = System.Drawing.Color.DarkGray
        Me.shapePendientes.Location = New System.Drawing.Point(12, 178)
        Me.shapePendientes.Name = "shapePendientes"
        Me.shapePendientes.Size = New System.Drawing.Size(554, 24)
        '
        'CANCELA
        '
        Me.CANCELA.BackColor = System.Drawing.Color.Crimson
        Me.CANCELA.Location = New System.Drawing.Point(1051, 317)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(49, 29)
        Me.CANCELA.TabIndex = 100
        Me.CANCELA.Text = "Cancel"
        Me.CANCELA.UseVisualStyleBackColor = False
        Me.CANCELA.Visible = False
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.SpringGreen
        Me.OK.Location = New System.Drawing.Point(999, 317)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(49, 29)
        Me.OK.TabIndex = 99
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = False
        Me.OK.Visible = False
        '
        'txtPorcAM
        '
        Me.txtPorcAM.Location = New System.Drawing.Point(812, 332)
        Me.txtPorcAM.MaxLength = 3
        Me.txtPorcAM.Name = "txtPorcAM"
        Me.txtPorcAM.Size = New System.Drawing.Size(55, 20)
        Me.txtPorcAM.TabIndex = 101
        Me.txtPorcAM.Visible = False
        '
        'txtObservacionesAM
        '
        Me.txtObservacionesAM.Location = New System.Drawing.Point(811, 372)
        Me.txtObservacionesAM.MaxLength = 120
        Me.txtObservacionesAM.Name = "txtObservacionesAM"
        Me.txtObservacionesAM.Size = New System.Drawing.Size(379, 20)
        Me.txtObservacionesAM.TabIndex = 102
        Me.txtObservacionesAM.Visible = False
        '
        'lblporcentaje
        '
        Me.lblporcentaje.AutoSize = True
        Me.lblporcentaje.BackColor = System.Drawing.Color.Transparent
        Me.lblporcentaje.Location = New System.Drawing.Point(809, 315)
        Me.lblporcentaje.Name = "lblporcentaje"
        Me.lblporcentaje.Size = New System.Drawing.Size(107, 13)
        Me.lblporcentaje.TabIndex = 103
        Me.lblporcentaje.Text = "Porcentaje Reintegro"
        Me.lblporcentaje.Visible = False
        '
        'lblobsam
        '
        Me.lblobsam.AutoSize = True
        Me.lblobsam.BackColor = System.Drawing.Color.Transparent
        Me.lblobsam.Location = New System.Drawing.Point(809, 356)
        Me.lblobsam.Name = "lblobsam"
        Me.lblobsam.Size = New System.Drawing.Size(169, 13)
        Me.lblobsam.TabIndex = 104
        Me.lblobsam.Text = "Observaciones del Auditor Medico"
        Me.lblobsam.Visible = False
        '
        'lblporc
        '
        Me.lblporc.AutoSize = True
        Me.lblporc.BackColor = System.Drawing.Color.Transparent
        Me.lblporc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblporc.Location = New System.Drawing.Point(869, 334)
        Me.lblporc.Name = "lblporc"
        Me.lblporc.Size = New System.Drawing.Size(21, 16)
        Me.lblporc.TabIndex = 105
        Me.lblporc.Text = "%"
        Me.lblporc.Visible = False
        '
        'opBuscaNumReintegro
        '
        Me.opBuscaNumReintegro.AutoSize = True
        Me.opBuscaNumReintegro.BackColor = System.Drawing.Color.Transparent
        Me.opBuscaNumReintegro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opBuscaNumReintegro.Location = New System.Drawing.Point(344, 30)
        Me.opBuscaNumReintegro.Name = "opBuscaNumReintegro"
        Me.opBuscaNumReintegro.Size = New System.Drawing.Size(189, 20)
        Me.opBuscaNumReintegro.TabIndex = 109
        Me.opBuscaNumReintegro.TabStop = True
        Me.opBuscaNumReintegro.Text = "Buscar por N° de Reintegro"
        Me.opBuscaNumReintegro.UseVisualStyleBackColor = False
        '
        'opBuscarDNI
        '
        Me.opBuscarDNI.AutoSize = True
        Me.opBuscarDNI.BackColor = System.Drawing.Color.Transparent
        Me.opBuscarDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opBuscarDNI.Location = New System.Drawing.Point(344, 48)
        Me.opBuscarDNI.Name = "opBuscarDNI"
        Me.opBuscarDNI.Size = New System.Drawing.Size(190, 20)
        Me.opBuscarDNI.TabIndex = 108
        Me.opBuscarDNI.TabStop = True
        Me.opBuscarDNI.Text = "Buscar por Cuil Beneficiario"
        Me.opBuscarDNI.UseVisualStyleBackColor = False
        '
        'txtNumReintegroBusqueda
        '
        Me.txtNumReintegroBusqueda.Enabled = False
        Me.txtNumReintegroBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumReintegroBusqueda.Location = New System.Drawing.Point(537, 40)
        Me.txtNumReintegroBusqueda.MaxLength = 13
        Me.txtNumReintegroBusqueda.Name = "txtNumReintegroBusqueda"
        Me.txtNumReintegroBusqueda.Size = New System.Drawing.Size(121, 20)
        Me.txtNumReintegroBusqueda.TabIndex = 110
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(225, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 13)
        Me.Label10.TabIndex = 113
        Me.Label10.Text = "Pago del Reintegro"
        '
        'opPAGADO
        '
        Me.opPAGADO.AutoSize = True
        Me.opPAGADO.BackColor = System.Drawing.Color.Transparent
        Me.opPAGADO.Location = New System.Drawing.Point(331, 28)
        Me.opPAGADO.Name = "opPAGADO"
        Me.opPAGADO.Size = New System.Drawing.Size(68, 17)
        Me.opPAGADO.TabIndex = 112
        Me.opPAGADO.Text = "Pagados"
        Me.opPAGADO.UseVisualStyleBackColor = False
        '
        'opPagoPendiente
        '
        Me.opPagoPendiente.AutoSize = True
        Me.opPagoPendiente.BackColor = System.Drawing.Color.Transparent
        Me.opPagoPendiente.Location = New System.Drawing.Point(331, 12)
        Me.opPagoPendiente.Name = "opPagoPendiente"
        Me.opPagoPendiente.Size = New System.Drawing.Size(79, 17)
        Me.opPagoPendiente.TabIndex = 111
        Me.opPagoPendiente.Text = "Pendientes"
        Me.opPagoPendiente.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(16, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 13)
        Me.Label11.TabIndex = 114
        Me.Label11.Text = "Comisión Directiva"
        '
        'opComisionRechazados
        '
        Me.opComisionRechazados.AutoSize = True
        Me.opComisionRechazados.BackColor = System.Drawing.Color.Transparent
        Me.opComisionRechazados.Location = New System.Drawing.Point(116, 37)
        Me.opComisionRechazados.Name = "opComisionRechazados"
        Me.opComisionRechazados.Size = New System.Drawing.Size(86, 17)
        Me.opComisionRechazados.TabIndex = 115
        Me.opComisionRechazados.Text = "Rechazados"
        Me.opComisionRechazados.UseVisualStyleBackColor = False
        '
        'opComisionAprobados
        '
        Me.opComisionAprobados.AutoSize = True
        Me.opComisionAprobados.BackColor = System.Drawing.Color.Transparent
        Me.opComisionAprobados.Location = New System.Drawing.Point(116, 21)
        Me.opComisionAprobados.Name = "opComisionAprobados"
        Me.opComisionAprobados.Size = New System.Drawing.Size(77, 17)
        Me.opComisionAprobados.TabIndex = 116
        Me.opComisionAprobados.Text = "Aprobados"
        Me.opComisionAprobados.UseVisualStyleBackColor = False
        '
        'opComisionPendientes
        '
        Me.opComisionPendientes.AutoSize = True
        Me.opComisionPendientes.BackColor = System.Drawing.Color.Transparent
        Me.opComisionPendientes.Location = New System.Drawing.Point(116, 5)
        Me.opComisionPendientes.Name = "opComisionPendientes"
        Me.opComisionPendientes.Size = New System.Drawing.Size(79, 17)
        Me.opComisionPendientes.TabIndex = 117
        Me.opComisionPendientes.Text = "Pendientes"
        Me.opComisionPendientes.UseVisualStyleBackColor = False
        '
        'opSubsidio
        '
        Me.opSubsidio.AutoSize = True
        Me.opSubsidio.BackColor = System.Drawing.Color.Transparent
        Me.opSubsidio.Location = New System.Drawing.Point(524, 97)
        Me.opSubsidio.Name = "opSubsidio"
        Me.opSubsidio.Size = New System.Drawing.Size(71, 17)
        Me.opSubsidio.TabIndex = 121
        Me.opSubsidio.Text = "Subsidios"
        Me.opSubsidio.UseVisualStyleBackColor = False
        '
        'opReintegro
        '
        Me.opReintegro.AutoSize = True
        Me.opReintegro.BackColor = System.Drawing.Color.Transparent
        Me.opReintegro.Location = New System.Drawing.Point(445, 97)
        Me.opReintegro.Name = "opReintegro"
        Me.opReintegro.Size = New System.Drawing.Size(77, 17)
        Me.opReintegro.TabIndex = 120
        Me.opReintegro.Text = "Reintegros"
        Me.opReintegro.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(370, 99)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 122
        Me.Label12.Text = "Solicitud tipo:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(631, 191)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 13)
        Me.Label14.TabIndex = 126
        Me.Label14.Text = "Auditoría Médica"
        Me.Label14.Visible = False
        '
        'opAuditorMedicoSI
        '
        Me.opAuditorMedicoSI.AutoSize = True
        Me.opAuditorMedicoSI.Location = New System.Drawing.Point(634, 190)
        Me.opAuditorMedicoSI.Name = "opAuditorMedicoSI"
        Me.opAuditorMedicoSI.Size = New System.Drawing.Size(77, 17)
        Me.opAuditorMedicoSI.TabIndex = 124
        Me.opAuditorMedicoSI.Text = "Aprobados"
        Me.opAuditorMedicoSI.UseVisualStyleBackColor = True
        Me.opAuditorMedicoSI.Visible = False
        '
        'opAuditorRechazado
        '
        Me.opAuditorRechazado.AutoSize = True
        Me.opAuditorRechazado.Location = New System.Drawing.Point(627, 190)
        Me.opAuditorRechazado.Name = "opAuditorRechazado"
        Me.opAuditorRechazado.Size = New System.Drawing.Size(86, 17)
        Me.opAuditorRechazado.TabIndex = 125
        Me.opAuditorRechazado.Text = "Rechazados"
        Me.opAuditorRechazado.UseVisualStyleBackColor = True
        Me.opAuditorRechazado.Visible = False
        '
        'opPendienteAuditor
        '
        Me.opPendienteAuditor.AutoSize = True
        Me.opPendienteAuditor.Location = New System.Drawing.Point(632, 190)
        Me.opPendienteAuditor.Name = "opPendienteAuditor"
        Me.opPendienteAuditor.Size = New System.Drawing.Size(79, 17)
        Me.opPendienteAuditor.TabIndex = 123
        Me.opPendienteAuditor.Text = "Pendientes"
        Me.opPendienteAuditor.UseVisualStyleBackColor = True
        Me.opPendienteAuditor.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.clbimagen)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.opReintegro)
        Me.Panel1.Controls.Add(Me.opSubsidio)
        Me.Panel1.Controls.Add(Me.lblPicture)
        Me.Panel1.Location = New System.Drawing.Point(8, 96)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(770, 585)
        Me.Panel1.TabIndex = 127
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(4, 111)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(762, 361)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GridView1)
        Me.TabPage3.Controls.Add(Me.botonExcel)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(754, 335)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "PENDIENTES"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'botonExcel
        '
        Me.botonExcel.Image = Global.WindowsApplication1.My.Resources.Resources.logoexcelsistemaa
        Me.botonExcel.Location = New System.Drawing.Point(357, 1)
        Me.botonExcel.Name = "botonExcel"
        Me.botonExcel.Size = New System.Drawing.Size(28, 22)
        Me.botonExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.botonExcel.TabIndex = 81
        Me.botonExcel.TabStop = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Panel3)
        Me.TabPage4.Controls.Add(Me.GridView2)
        Me.TabPage4.Controls.Add(Me.Label10)
        Me.TabPage4.Controls.Add(Me.opComisionPendientes)
        Me.TabPage4.Controls.Add(Me.opComisionAprobados)
        Me.TabPage4.Controls.Add(Me.opComisionRechazados)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Controls.Add(Me.opPagoPendiente)
        Me.TabPage4.Controls.Add(Me.opPAGADO)
        Me.TabPage4.Controls.Add(Me.botonLimpiarFiltros)
        Me.TabPage4.Controls.Add(Me.botonExcel2)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(754, 335)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "APROBADOS AUDITOR"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Location = New System.Drawing.Point(768, 44)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(437, 160)
        Me.Panel3.TabIndex = 129
        '
        'botonLimpiarFiltros
        '
        Me.botonLimpiarFiltros.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.botonLimpiarFiltros.AutoEllipsis = True
        Me.botonLimpiarFiltros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.botonLimpiarFiltros.BackColor = System.Drawing.Color.DarkGray
        Me.botonLimpiarFiltros.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.escoba
        Me.botonLimpiarFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.botonLimpiarFiltros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.botonLimpiarFiltros.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.botonLimpiarFiltros.Location = New System.Drawing.Point(416, 9)
        Me.botonLimpiarFiltros.Name = "botonLimpiarFiltros"
        Me.botonLimpiarFiltros.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.botonLimpiarFiltros.Size = New System.Drawing.Size(36, 37)
        Me.botonLimpiarFiltros.TabIndex = 118
        Me.botonLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.botonLimpiarFiltros.UseVisualStyleBackColor = False
        '
        'botonExcel2
        '
        Me.botonExcel2.Image = Global.WindowsApplication1.My.Resources.Resources.logoexcelsistemaa
        Me.botonExcel2.Location = New System.Drawing.Point(681, 12)
        Me.botonExcel2.Name = "botonExcel2"
        Me.botonExcel2.Size = New System.Drawing.Size(35, 32)
        Me.botonExcel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.botonExcel2.TabIndex = 106
        Me.botonExcel2.TabStop = False
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GridView3)
        Me.TabPage5.Controls.Add(Me.botonExcel3)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(754, 335)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "RECHAZADOS AUDITOR"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'botonExcel3
        '
        Me.botonExcel3.Image = Global.WindowsApplication1.My.Resources.Resources.logoexcelsistemaa
        Me.botonExcel3.Location = New System.Drawing.Point(713, 2)
        Me.botonExcel3.Name = "botonExcel3"
        Me.botonExcel3.Size = New System.Drawing.Size(28, 22)
        Me.botonExcel3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.botonExcel3.TabIndex = 107
        Me.botonExcel3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.rec2
        Me.PictureBox1.Location = New System.Drawing.Point(264, 477)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(238, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 91
        Me.PictureBox1.TabStop = False
        '
        'lblPicture
        '
        Me.lblPicture.Location = New System.Drawing.Point(588, 476)
        Me.lblPicture.Name = "lblPicture"
        Me.lblPicture.Size = New System.Drawing.Size(163, 106)
        Me.lblPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lblPicture.TabIndex = 92
        Me.lblPicture.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtuserseccional)
        Me.Panel2.Controls.Add(Me.opSeccional)
        Me.Panel2.Location = New System.Drawing.Point(8, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(770, 68)
        Me.Panel2.TabIndex = 128
        '
        'txtuserseccional
        '
        Me.txtuserseccional.BackColor = System.Drawing.SystemColors.Info
        Me.txtuserseccional.Enabled = False
        Me.txtuserseccional.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtuserseccional.Location = New System.Drawing.Point(655, 35)
        Me.txtuserseccional.MaxLength = 13
        Me.txtuserseccional.Name = "txtuserseccional"
        Me.txtuserseccional.Size = New System.Drawing.Size(111, 20)
        Me.txtuserseccional.TabIndex = 132
        '
        'opSeccional
        '
        Me.opSeccional.AutoSize = True
        Me.opSeccional.BackColor = System.Drawing.Color.Transparent
        Me.opSeccional.Location = New System.Drawing.Point(649, 17)
        Me.opSeccional.Name = "opSeccional"
        Me.opSeccional.Size = New System.Drawing.Size(124, 17)
        Me.opSeccional.TabIndex = 123
        Me.opSeccional.Text = "Filtrar por User/Secc"
        Me.opSeccional.UseVisualStyleBackColor = False
        '
        'botonDesaprobar
        '
        Me.botonDesaprobar.BackColor = System.Drawing.Color.LightGray
        Me.botonDesaprobar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonDesaprobar.Image = CType(resources.GetObject("botonDesaprobar.Image"), System.Drawing.Image)
        Me.botonDesaprobar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.botonDesaprobar.Location = New System.Drawing.Point(1001, 227)
        Me.botonDesaprobar.Name = "botonDesaprobar"
        Me.botonDesaprobar.Size = New System.Drawing.Size(218, 41)
        Me.botonDesaprobar.TabIndex = 86
        Me.botonDesaprobar.Text = "Rechazar"
        Me.botonDesaprobar.UseVisualStyleBackColor = False
        Me.botonDesaprobar.Visible = False
        '
        'botonAprobar
        '
        Me.botonAprobar.BackColor = System.Drawing.Color.LightGray
        Me.botonAprobar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonAprobar.Image = CType(resources.GetObject("botonAprobar.Image"), System.Drawing.Image)
        Me.botonAprobar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.botonAprobar.Location = New System.Drawing.Point(784, 227)
        Me.botonAprobar.Name = "botonAprobar"
        Me.botonAprobar.Size = New System.Drawing.Size(219, 41)
        Me.botonAprobar.TabIndex = 85
        Me.botonAprobar.Text = "Aprobar"
        Me.botonAprobar.UseVisualStyleBackColor = False
        Me.botonAprobar.Visible = False
        '
        'logoURGARA
        '
        Me.logoURGARA.BackColor = System.Drawing.Color.Transparent
        Me.logoURGARA.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Marca_URGARA
        Me.logoURGARA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logoURGARA.Location = New System.Drawing.Point(855, 529)
        Me.logoURGARA.Name = "logoURGARA"
        Me.logoURGARA.Size = New System.Drawing.Size(140, 72)
        Me.logoURGARA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoURGARA.TabIndex = 130
        Me.logoURGARA.TabStop = False
        '
        'logoOSRGA
        '
        Me.logoOSRGA.BackColor = System.Drawing.Color.Transparent
        Me.logoOSRGA.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Marca_OSRGA2
        Me.logoOSRGA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logoOSRGA.Location = New System.Drawing.Point(1006, 528)
        Me.logoOSRGA.Name = "logoOSRGA"
        Me.logoOSRGA.Size = New System.Drawing.Size(144, 64)
        Me.logoOSRGA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoOSRGA.TabIndex = 129
        Me.logoOSRGA.TabStop = False
        '
        'GridViewSeccionales
        '
        Me.GridViewSeccionales.AllowUserToAddRows = False
        Me.GridViewSeccionales.BackgroundColor = System.Drawing.Color.DimGray
        Me.GridViewSeccionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridViewSeccionales.Location = New System.Drawing.Point(784, 33)
        Me.GridViewSeccionales.MultiSelect = False
        Me.GridViewSeccionales.Name = "GridViewSeccionales"
        Me.GridViewSeccionales.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridViewSeccionales.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GridViewSeccionales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.GridViewSeccionales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridViewSeccionales.Size = New System.Drawing.Size(445, 121)
        Me.GridViewSeccionales.TabIndex = 131
        Me.GridViewSeccionales.VirtualMode = True
        Me.GridViewSeccionales.Visible = False
        '
        'FormularioAuditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1237, 684)
        Me.Controls.Add(Me.GridViewSeccionales)
        Me.Controls.Add(Me.lblReintegroPendiente)
        Me.Controls.Add(Me.logoURGARA)
        Me.Controls.Add(Me.logoOSRGA)
        Me.Controls.Add(Me.checkFecha)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.opAuditorMedicoSI)
        Me.Controls.Add(Me.opAuditorRechazado)
        Me.Controls.Add(Me.opPendienteAuditor)
        Me.Controls.Add(Me.txtNumReintegroBusqueda)
        Me.Controls.Add(Me.opBuscaNumReintegro)
        Me.Controls.Add(Me.opBuscarDNI)
        Me.Controls.Add(Me.lblporc)
        Me.Controls.Add(Me.lblobsam)
        Me.Controls.Add(Me.lblporcentaje)
        Me.Controls.Add(Me.txtObservacionesAM)
        Me.Controls.Add(Me.txtPorcAM)
        Me.Controls.Add(Me.CANCELA)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.lblReintegroRechazado)
        Me.Controls.Add(Me.lblReintegroAprobado)
        Me.Controls.Add(Me.botonDesaprobar)
        Me.Controls.Add(Me.botonAprobar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBeneficiario)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "FormularioAuditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Auditor Medico"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        CType(Me.botonExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.botonExcel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.botonExcel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.logoURGARA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logoOSRGA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSeccionales, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents clbimagen As System.Windows.Forms.CheckedListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPicture As System.Windows.Forms.PictureBox
    Friend WithEvents GridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents lblReintegroPendiente As System.Windows.Forms.Label
    Friend WithEvents lblReintegroAprobado As System.Windows.Forms.Label
    Friend WithEvents lblReintegroRechazado As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents shapePendientes As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents CANCELA As System.Windows.Forms.Button
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents txtPorcAM As System.Windows.Forms.TextBox
    Friend WithEvents txtObservacionesAM As System.Windows.Forms.TextBox
    Friend WithEvents lblporcentaje As System.Windows.Forms.Label
    Friend WithEvents lblobsam As System.Windows.Forms.Label
    Friend WithEvents lblporc As System.Windows.Forms.Label
    Friend WithEvents botonExcel2 As System.Windows.Forms.PictureBox
    Friend WithEvents botonExcel3 As System.Windows.Forms.PictureBox
    Friend WithEvents opBuscaNumReintegro As System.Windows.Forms.RadioButton
    Friend WithEvents opBuscarDNI As System.Windows.Forms.RadioButton
    Friend WithEvents txtNumReintegroBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents opPAGADO As System.Windows.Forms.CheckBox
    Friend WithEvents opPagoPendiente As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents opComisionRechazados As System.Windows.Forms.CheckBox
    Friend WithEvents opComisionAprobados As System.Windows.Forms.CheckBox
    Friend WithEvents opComisionPendientes As System.Windows.Forms.CheckBox
    Friend WithEvents botonLimpiarFiltros As System.Windows.Forms.Button
    Friend WithEvents botonLimpiarFiltroFechas As System.Windows.Forms.Button
    Friend WithEvents opSubsidio As System.Windows.Forms.CheckBox
    Friend WithEvents opReintegro As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents opAuditorMedicoSI As System.Windows.Forms.CheckBox
    Friend WithEvents opAuditorRechazado As System.Windows.Forms.CheckBox
    Friend WithEvents opPendienteAuditor As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents panelAuditor As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents logoURGARA As System.Windows.Forms.PictureBox
    Friend WithEvents logoOSRGA As System.Windows.Forms.PictureBox
    Friend WithEvents GridViewSeccionales As System.Windows.Forms.DataGridView
    Friend WithEvents opSeccional As System.Windows.Forms.CheckBox
    Friend WithEvents txtuserseccional As System.Windows.Forms.TextBox
End Class
