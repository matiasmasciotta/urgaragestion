﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaSolicitudReintegro))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.opPAGADO = New System.Windows.Forms.CheckBox()
        Me.opComisionRechazados = New System.Windows.Forms.CheckBox()
        Me.opComisionAprobados = New System.Windows.Forms.CheckBox()
        Me.opComisionPendientes = New System.Windows.Forms.CheckBox()
        Me.opSubsidio = New System.Windows.Forms.CheckBox()
        Me.opReintegro = New System.Windows.Forms.CheckBox()
        Me.botonLimpiarFiltros = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.opAuditorMedicoSI = New System.Windows.Forms.CheckBox()
        Me.opAuditorRechazado = New System.Windows.Forms.CheckBox()
        Me.opPagoPendiente = New System.Windows.Forms.CheckBox()
        Me.opPendienteAuditor = New System.Windows.Forms.CheckBox()
        Me.lblfechahasta = New System.Windows.Forms.Label()
        Me.lblfechadesde = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.clbimagen = New System.Windows.Forms.CheckedListBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblPicture = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtObservacionesCarga = New System.Windows.Forms.TextBox()
        Me.txtFechaSolicitud = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtTipoCuentaTEMPO = New System.Windows.Forms.TextBox()
        Me.txtCuilPagoTEMPO = New System.Windows.Forms.TextBox()
        Me.txtObservacionesTEMPO = New System.Windows.Forms.TextBox()
        Me.txtAliasTEMPO = New System.Windows.Forms.TextBox()
        Me.txtCBUTEMPO = New System.Windows.Forms.TextBox()
        Me.txtFechSolicitudTEMPO = New System.Windows.Forms.TextBox()
        Me.txtImporteTEMPO = New System.Windows.Forms.TextBox()
        Me.txtDetalleTEMPO = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCuilPago = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtTipoCuenta = New System.Windows.Forms.TextBox()
        Me.txtAlias = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCBU = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.botonQuitarImagen = New System.Windows.Forms.Button()
        Me.botonImagen = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.botonModificaSolicitud = New System.Windows.Forms.Button()
        Me.lblfe1 = New System.Windows.Forms.Label()
        Me.lblfe2 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.botonEliminarSolicitud = New System.Windows.Forms.Button()
        Me.lblTipoReintegro = New System.Windows.Forms.Label()
        Me.txtCuil = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GridView2 = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GridView3 = New System.Windows.Forms.DataGridView()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.lblPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'checkFecha
        '
        Me.checkFecha.AutoSize = True
        Me.checkFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkFecha.Location = New System.Drawing.Point(7, -3)
        Me.checkFecha.Name = "checkFecha"
        Me.checkFecha.Size = New System.Drawing.Size(57, 19)
        Me.checkFecha.TabIndex = 18
        Me.checkFecha.Text = "Filtrar"
        Me.checkFecha.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(267, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Fecha Desde:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Detalle a Buscar:"
        '
        'GridView1
        '
        Me.GridView1.AllowUserToAddRows = False
        Me.GridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView1.Location = New System.Drawing.Point(3, 4)
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
        Me.GridView1.Size = New System.Drawing.Size(648, 434)
        Me.GridView1.TabIndex = 14
        Me.GridView1.VirtualMode = True
        '
        'txtBeneficiario
        '
        Me.txtBeneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeneficiario.Location = New System.Drawing.Point(161, 12)
        Me.txtBeneficiario.MaxLength = 13
        Me.txtBeneficiario.Name = "txtBeneficiario"
        Me.txtBeneficiario.Size = New System.Drawing.Size(286, 22)
        Me.txtBeneficiario.TabIndex = 13
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
        'txtFechaDesde
        '
        Me.txtFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaDesde.Location = New System.Drawing.Point(96, 29)
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.Size = New System.Drawing.Size(153, 22)
        Me.txtFechaDesde.TabIndex = 11
        Me.txtFechaDesde.Visible = False
        '
        'Boton_Salir
        '
        Me.Boton_Salir.Location = New System.Drawing.Point(820, 627)
        Me.Boton_Salir.Name = "Boton_Salir"
        Me.Boton_Salir.Size = New System.Drawing.Size(182, 36)
        Me.Boton_Salir.TabIndex = 19
        Me.Boton_Salir.Text = "Salir"
        Me.Boton_Salir.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(103, 94)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(153, 20)
        Me.DateTimePicker1.TabIndex = 20
        Me.DateTimePicker1.Visible = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(315, 56)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(153, 20)
        Me.DateTimePicker2.TabIndex = 21
        Me.DateTimePicker2.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.opPAGADO)
        Me.GroupBox1.Controls.Add(Me.opComisionRechazados)
        Me.GroupBox1.Controls.Add(Me.opComisionAprobados)
        Me.GroupBox1.Controls.Add(Me.opComisionPendientes)
        Me.GroupBox1.Controls.Add(Me.opSubsidio)
        Me.GroupBox1.Controls.Add(Me.opReintegro)
        Me.GroupBox1.Controls.Add(Me.botonLimpiarFiltros)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.opAuditorMedicoSI)
        Me.GroupBox1.Controls.Add(Me.opAuditorRechazado)
        Me.GroupBox1.Controls.Add(Me.opPagoPendiente)
        Me.GroupBox1.Controls.Add(Me.opPendienteAuditor)
        Me.GroupBox1.Controls.Add(Me.lblfechahasta)
        Me.GroupBox1.Controls.Add(Me.lblfechadesde)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.txtFechaHasta)
        Me.GroupBox1.Controls.Add(Me.checkFecha)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFechaDesde)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(662, 166)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        '
        'opPAGADO
        '
        Me.opPAGADO.AutoSize = True
        Me.opPAGADO.Location = New System.Drawing.Point(382, 125)
        Me.opPAGADO.Name = "opPAGADO"
        Me.opPAGADO.Size = New System.Drawing.Size(68, 17)
        Me.opPAGADO.TabIndex = 89
        Me.opPAGADO.Text = "Pagados"
        Me.opPAGADO.UseVisualStyleBackColor = True
        '
        'opComisionRechazados
        '
        Me.opComisionRechazados.AutoSize = True
        Me.opComisionRechazados.Location = New System.Drawing.Point(276, 145)
        Me.opComisionRechazados.Name = "opComisionRechazados"
        Me.opComisionRechazados.Size = New System.Drawing.Size(86, 17)
        Me.opComisionRechazados.TabIndex = 88
        Me.opComisionRechazados.Text = "Rechazados"
        Me.opComisionRechazados.UseVisualStyleBackColor = True
        '
        'opComisionAprobados
        '
        Me.opComisionAprobados.AutoSize = True
        Me.opComisionAprobados.Location = New System.Drawing.Point(276, 125)
        Me.opComisionAprobados.Name = "opComisionAprobados"
        Me.opComisionAprobados.Size = New System.Drawing.Size(77, 17)
        Me.opComisionAprobados.TabIndex = 87
        Me.opComisionAprobados.Text = "Aprobados"
        Me.opComisionAprobados.UseVisualStyleBackColor = True
        '
        'opComisionPendientes
        '
        Me.opComisionPendientes.AutoSize = True
        Me.opComisionPendientes.Location = New System.Drawing.Point(276, 107)
        Me.opComisionPendientes.Name = "opComisionPendientes"
        Me.opComisionPendientes.Size = New System.Drawing.Size(79, 17)
        Me.opComisionPendientes.TabIndex = 84
        Me.opComisionPendientes.Text = "Pendientes"
        Me.opComisionPendientes.UseVisualStyleBackColor = True
        '
        'opSubsidio
        '
        Me.opSubsidio.AutoSize = True
        Me.opSubsidio.Location = New System.Drawing.Point(69, 125)
        Me.opSubsidio.Name = "opSubsidio"
        Me.opSubsidio.Size = New System.Drawing.Size(71, 17)
        Me.opSubsidio.TabIndex = 81
        Me.opSubsidio.Text = "Subsidios"
        Me.opSubsidio.UseVisualStyleBackColor = True
        '
        'opReintegro
        '
        Me.opReintegro.AutoSize = True
        Me.opReintegro.Location = New System.Drawing.Point(69, 107)
        Me.opReintegro.Name = "opReintegro"
        Me.opReintegro.Size = New System.Drawing.Size(77, 17)
        Me.opReintegro.TabIndex = 80
        Me.opReintegro.Text = "Reintegros"
        Me.opReintegro.UseVisualStyleBackColor = True
        '
        'botonLimpiarFiltros
        '
        Me.botonLimpiarFiltros.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.botonLimpiarFiltros.AutoEllipsis = True
        Me.botonLimpiarFiltros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.botonLimpiarFiltros.BackColor = System.Drawing.Color.Transparent
        Me.botonLimpiarFiltros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.botonLimpiarFiltros.Image = CType(resources.GetObject("botonLimpiarFiltros.Image"), System.Drawing.Image)
        Me.botonLimpiarFiltros.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.botonLimpiarFiltros.Location = New System.Drawing.Point(532, 44)
        Me.botonLimpiarFiltros.Name = "botonLimpiarFiltros"
        Me.botonLimpiarFiltros.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.botonLimpiarFiltros.Size = New System.Drawing.Size(86, 86)
        Me.botonLimpiarFiltros.TabIndex = 90
        Me.botonLimpiarFiltros.Text = "Limpiar Filtros"
        Me.botonLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.botonLimpiarFiltros.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(372, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 13)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "Pago del Reintegro"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(271, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 93
        Me.Label9.Text = "Comisión Directiva"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(93, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 92
        Me.Label8.Text = "Tipo"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(163, 90)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 13)
        Me.Label14.TabIndex = 91
        Me.Label14.Text = "Auditoría Médica"
        '
        'opAuditorMedicoSI
        '
        Me.opAuditorMedicoSI.AutoSize = True
        Me.opAuditorMedicoSI.Location = New System.Drawing.Point(160, 125)
        Me.opAuditorMedicoSI.Name = "opAuditorMedicoSI"
        Me.opAuditorMedicoSI.Size = New System.Drawing.Size(77, 17)
        Me.opAuditorMedicoSI.TabIndex = 83
        Me.opAuditorMedicoSI.Text = "Aprobados"
        Me.opAuditorMedicoSI.UseVisualStyleBackColor = True
        '
        'opAuditorRechazado
        '
        Me.opAuditorRechazado.AutoSize = True
        Me.opAuditorRechazado.Location = New System.Drawing.Point(160, 145)
        Me.opAuditorRechazado.Name = "opAuditorRechazado"
        Me.opAuditorRechazado.Size = New System.Drawing.Size(86, 17)
        Me.opAuditorRechazado.TabIndex = 86
        Me.opAuditorRechazado.Text = "Rechazados"
        Me.opAuditorRechazado.UseVisualStyleBackColor = True
        '
        'opPagoPendiente
        '
        Me.opPagoPendiente.AutoSize = True
        Me.opPagoPendiente.Location = New System.Drawing.Point(382, 107)
        Me.opPagoPendiente.Name = "opPagoPendiente"
        Me.opPagoPendiente.Size = New System.Drawing.Size(79, 17)
        Me.opPagoPendiente.TabIndex = 85
        Me.opPagoPendiente.Text = "Pendientes"
        Me.opPagoPendiente.UseVisualStyleBackColor = True
        '
        'opPendienteAuditor
        '
        Me.opPendienteAuditor.AutoSize = True
        Me.opPendienteAuditor.Location = New System.Drawing.Point(160, 107)
        Me.opPendienteAuditor.Name = "opPendienteAuditor"
        Me.opPendienteAuditor.Size = New System.Drawing.Size(79, 17)
        Me.opPendienteAuditor.TabIndex = 82
        Me.opPendienteAuditor.Text = "Pendientes"
        Me.opPendienteAuditor.UseVisualStyleBackColor = True
        '
        'lblfechahasta
        '
        Me.lblfechahasta.AutoSize = True
        Me.lblfechahasta.Location = New System.Drawing.Point(342, 13)
        Me.lblfechahasta.Name = "lblfechahasta"
        Me.lblfechahasta.Size = New System.Drawing.Size(89, 13)
        Me.lblfechahasta.TabIndex = 23
        Me.lblfechahasta.Text = "aaaa  -  mm  -  dd"
        Me.lblfechahasta.Visible = False
        '
        'lblfechadesde
        '
        Me.lblfechadesde.AutoSize = True
        Me.lblfechadesde.Location = New System.Drawing.Point(117, 13)
        Me.lblfechadesde.Name = "lblfechadesde"
        Me.lblfechadesde.Size = New System.Drawing.Size(89, 13)
        Me.lblfechadesde.TabIndex = 22
        Me.lblfechadesde.Text = "aaaa  -  mm  -  dd"
        Me.lblfechadesde.Visible = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1, Me.LineShape3, Me.LineShape4})
        Me.ShapeContainer1.Size = New System.Drawing.Size(656, 147)
        Me.ShapeContainer1.TabIndex = 95
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 145
        Me.LineShape2.X2 = 145
        Me.LineShape2.Y1 = 90
        Me.LineShape2.Y2 = 141
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 261
        Me.LineShape1.X2 = 261
        Me.LineShape1.Y1 = 90
        Me.LineShape1.Y2 = 141
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 369
        Me.LineShape3.X2 = 369
        Me.LineShape3.Y1 = 91
        Me.LineShape3.Y2 = 142
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 64
        Me.LineShape4.X2 = 467
        Me.LineShape4.Y1 = 89
        Me.LineShape4.Y2 = 89
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Button1.Location = New System.Drawing.Point(82, 685)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 36)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Exportar a EXCEL"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'clbimagen
        '
        Me.clbimagen.BackColor = System.Drawing.Color.LightSteelBlue
        Me.clbimagen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clbimagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbimagen.FormattingEnabled = True
        Me.clbimagen.Location = New System.Drawing.Point(755, 417)
        Me.clbimagen.Name = "clbimagen"
        Me.clbimagen.Size = New System.Drawing.Size(275, 96)
        Me.clbimagen.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(817, 383)
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
        Me.Label5.Location = New System.Drawing.Point(1150, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Vista Previa"
        '
        'lblPicture
        '
        Me.lblPicture.Location = New System.Drawing.Point(1082, 371)
        Me.lblPicture.Name = "lblPicture"
        Me.lblPicture.Size = New System.Drawing.Size(221, 211)
        Me.lblPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lblPicture.TabIndex = 25
        Me.lblPicture.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(749, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(383, 16)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "Datos Cargados para la solicitud del Nuevo Reintegro"
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker3.Location = New System.Drawing.Point(180, 122)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(257, 22)
        Me.DateTimePicker3.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(45, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Observaciones:"
        '
        'txtObservacionesCarga
        '
        Me.txtObservacionesCarga.Enabled = False
        Me.txtObservacionesCarga.Location = New System.Drawing.Point(162, 214)
        Me.txtObservacionesCarga.Name = "txtObservacionesCarga"
        Me.txtObservacionesCarga.Size = New System.Drawing.Size(475, 20)
        Me.txtObservacionesCarga.TabIndex = 6
        '
        'txtFechaSolicitud
        '
        Me.txtFechaSolicitud.Enabled = False
        Me.txtFechaSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaSolicitud.Location = New System.Drawing.Point(306, 96)
        Me.txtFechaSolicitud.Name = "txtFechaSolicitud"
        Me.txtFechaSolicitud.Size = New System.Drawing.Size(131, 22)
        Me.txtFechaSolicitud.TabIndex = 5
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.txtTipoCuentaTEMPO)
        Me.Panel5.Controls.Add(Me.txtCuilPagoTEMPO)
        Me.Panel5.Controls.Add(Me.txtObservacionesTEMPO)
        Me.Panel5.Controls.Add(Me.txtAliasTEMPO)
        Me.Panel5.Controls.Add(Me.txtCBUTEMPO)
        Me.Panel5.Controls.Add(Me.txtFechSolicitudTEMPO)
        Me.Panel5.Controls.Add(Me.txtImporteTEMPO)
        Me.Panel5.Controls.Add(Me.txtDetalleTEMPO)
        Me.Panel5.Controls.Add(Me.Label19)
        Me.Panel5.Controls.Add(Me.txtCuilPago)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.txtTipoCuenta)
        Me.Panel5.Controls.Add(Me.txtAlias)
        Me.Panel5.Controls.Add(Me.DateTimePicker3)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.txtCBU)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.txtObservacionesCarga)
        Me.Panel5.Controls.Add(Me.txtFechaSolicitud)
        Me.Panel5.Controls.Add(Me.txtImporte)
        Me.Panel5.Controls.Add(Me.txtDetalle)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Location = New System.Drawing.Point(675, 52)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(642, 294)
        Me.Panel5.TabIndex = 30
        '
        'txtTipoCuentaTEMPO
        '
        Me.txtTipoCuentaTEMPO.Enabled = False
        Me.txtTipoCuentaTEMPO.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCuentaTEMPO.Location = New System.Drawing.Point(437, 239)
        Me.txtTipoCuentaTEMPO.MaxLength = 80
        Me.txtTipoCuentaTEMPO.Name = "txtTipoCuentaTEMPO"
        Me.txtTipoCuentaTEMPO.Size = New System.Drawing.Size(208, 21)
        Me.txtTipoCuentaTEMPO.TabIndex = 77
        Me.txtTipoCuentaTEMPO.Visible = False
        '
        'txtCuilPagoTEMPO
        '
        Me.txtCuilPagoTEMPO.Enabled = False
        Me.txtCuilPagoTEMPO.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuilPagoTEMPO.Location = New System.Drawing.Point(180, 240)
        Me.txtCuilPagoTEMPO.MaxLength = 22
        Me.txtCuilPagoTEMPO.Name = "txtCuilPagoTEMPO"
        Me.txtCuilPagoTEMPO.Size = New System.Drawing.Size(169, 21)
        Me.txtCuilPagoTEMPO.TabIndex = 76
        Me.txtCuilPagoTEMPO.Visible = False
        '
        'txtObservacionesTEMPO
        '
        Me.txtObservacionesTEMPO.Enabled = False
        Me.txtObservacionesTEMPO.Location = New System.Drawing.Point(170, 199)
        Me.txtObservacionesTEMPO.Name = "txtObservacionesTEMPO"
        Me.txtObservacionesTEMPO.Size = New System.Drawing.Size(475, 20)
        Me.txtObservacionesTEMPO.TabIndex = 75
        Me.txtObservacionesTEMPO.Visible = False
        '
        'txtAliasTEMPO
        '
        Me.txtAliasTEMPO.Enabled = False
        Me.txtAliasTEMPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAliasTEMPO.Location = New System.Drawing.Point(439, 150)
        Me.txtAliasTEMPO.MaxLength = 80
        Me.txtAliasTEMPO.Name = "txtAliasTEMPO"
        Me.txtAliasTEMPO.Size = New System.Drawing.Size(188, 22)
        Me.txtAliasTEMPO.TabIndex = 74
        Me.txtAliasTEMPO.Visible = False
        '
        'txtCBUTEMPO
        '
        Me.txtCBUTEMPO.Enabled = False
        Me.txtCBUTEMPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCBUTEMPO.Location = New System.Drawing.Point(178, 150)
        Me.txtCBUTEMPO.MaxLength = 22
        Me.txtCBUTEMPO.Name = "txtCBUTEMPO"
        Me.txtCBUTEMPO.Size = New System.Drawing.Size(196, 22)
        Me.txtCBUTEMPO.TabIndex = 73
        Me.txtCBUTEMPO.Visible = False
        '
        'txtFechSolicitudTEMPO
        '
        Me.txtFechSolicitudTEMPO.Enabled = False
        Me.txtFechSolicitudTEMPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechSolicitudTEMPO.Location = New System.Drawing.Point(448, 96)
        Me.txtFechSolicitudTEMPO.Name = "txtFechSolicitudTEMPO"
        Me.txtFechSolicitudTEMPO.Size = New System.Drawing.Size(131, 22)
        Me.txtFechSolicitudTEMPO.TabIndex = 72
        Me.txtFechSolicitudTEMPO.Visible = False
        '
        'txtImporteTEMPO
        '
        Me.txtImporteTEMPO.Enabled = False
        Me.txtImporteTEMPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporteTEMPO.Location = New System.Drawing.Point(448, 67)
        Me.txtImporteTEMPO.Name = "txtImporteTEMPO"
        Me.txtImporteTEMPO.Size = New System.Drawing.Size(131, 22)
        Me.txtImporteTEMPO.TabIndex = 71
        Me.txtImporteTEMPO.Visible = False
        '
        'txtDetalleTEMPO
        '
        Me.txtDetalleTEMPO.Enabled = False
        Me.txtDetalleTEMPO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalleTEMPO.Location = New System.Drawing.Point(189, 15)
        Me.txtDetalleTEMPO.Name = "txtDetalleTEMPO"
        Me.txtDetalleTEMPO.Size = New System.Drawing.Size(313, 22)
        Me.txtDetalleTEMPO.TabIndex = 70
        Me.txtDetalleTEMPO.Visible = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(56, 260)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(106, 14)
        Me.Label19.TabIndex = 68
        Me.Label19.Text = "CUIL Tit. Cuenta:"
        '
        'txtCuilPago
        '
        Me.txtCuilPago.Enabled = False
        Me.txtCuilPago.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuilPago.Location = New System.Drawing.Point(162, 257)
        Me.txtCuilPago.MaxLength = 22
        Me.txtCuilPago.Name = "txtCuilPago"
        Me.txtCuilPago.Size = New System.Drawing.Size(169, 21)
        Me.txtCuilPago.TabIndex = 66
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(344, 260)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 14)
        Me.Label17.TabIndex = 69
        Me.Label17.Text = "Tipo Cuenta:"
        '
        'txtTipoCuenta
        '
        Me.txtTipoCuenta.Enabled = False
        Me.txtTipoCuenta.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCuenta.Location = New System.Drawing.Point(429, 257)
        Me.txtTipoCuenta.MaxLength = 80
        Me.txtTipoCuenta.Name = "txtTipoCuenta"
        Me.txtTipoCuenta.Size = New System.Drawing.Size(208, 21)
        Me.txtTipoCuenta.TabIndex = 67
        '
        'txtAlias
        '
        Me.txtAlias.Enabled = False
        Me.txtAlias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlias.Location = New System.Drawing.Point(431, 172)
        Me.txtAlias.MaxLength = 80
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Size = New System.Drawing.Size(188, 22)
        Me.txtAlias.TabIndex = 41
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(380, 174)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 16)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "ALIAS:"
        '
        'txtCBU
        '
        Me.txtCBU.Enabled = False
        Me.txtCBU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCBU.Location = New System.Drawing.Point(162, 171)
        Me.txtCBU.MaxLength = 22
        Me.txtCBU.Name = "txtCBU"
        Me.txtCBU.Size = New System.Drawing.Size(196, 22)
        Me.txtCBU.TabIndex = 40
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(114, 173)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 16)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "CBU:"
        '
        'txtImporte
        '
        Me.txtImporte.Enabled = False
        Me.txtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.Location = New System.Drawing.Point(306, 67)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(131, 22)
        Me.txtImporte.TabIndex = 4
        '
        'txtDetalle
        '
        Me.txtDetalle.Enabled = False
        Me.txtDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalle.Location = New System.Drawing.Point(14, 38)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(622, 22)
        Me.txtDetalle.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(159, 99)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(141, 16)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Fecha de Solicitud:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(236, 70)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 16)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Importe:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(49, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Detalle:"
        '
        'botonQuitarImagen
        '
        Me.botonQuitarImagen.BackColor = System.Drawing.Color.Salmon
        Me.botonQuitarImagen.Location = New System.Drawing.Point(884, 539)
        Me.botonQuitarImagen.Name = "botonQuitarImagen"
        Me.botonQuitarImagen.Size = New System.Drawing.Size(87, 25)
        Me.botonQuitarImagen.TabIndex = 14
        Me.botonQuitarImagen.Text = "- Quitar"
        Me.botonQuitarImagen.UseVisualStyleBackColor = False
        Me.botonQuitarImagen.Visible = False
        '
        'botonImagen
        '
        Me.botonImagen.BackColor = System.Drawing.Color.LightGreen
        Me.botonImagen.Location = New System.Drawing.Point(791, 539)
        Me.botonImagen.Name = "botonImagen"
        Me.botonImagen.Size = New System.Drawing.Size(87, 25)
        Me.botonImagen.TabIndex = 9
        Me.botonImagen.Text = "+Subir Imagen"
        Me.botonImagen.UseVisualStyleBackColor = False
        Me.botonImagen.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.recazulss
        Me.PictureBox1.Location = New System.Drawing.Point(714, 404)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(351, 126)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'CANCELA
        '
        Me.CANCELA.BackColor = System.Drawing.Color.Chocolate
        Me.CANCELA.Location = New System.Drawing.Point(411, 677)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(84, 52)
        Me.CANCELA.TabIndex = 33
        Me.CANCELA.Text = "Cancelar"
        Me.CANCELA.UseVisualStyleBackColor = False
        Me.CANCELA.Visible = False
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.OK.Location = New System.Drawing.Point(289, 703)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(126, 26)
        Me.OK.TabIndex = 32
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = False
        Me.OK.Visible = False
        '
        'botonModificaSolicitud
        '
        Me.botonModificaSolicitud.BackColor = System.Drawing.Color.LightSkyBlue
        Me.botonModificaSolicitud.Location = New System.Drawing.Point(289, 677)
        Me.botonModificaSolicitud.Name = "botonModificaSolicitud"
        Me.botonModificaSolicitud.Size = New System.Drawing.Size(126, 29)
        Me.botonModificaSolicitud.TabIndex = 31
        Me.botonModificaSolicitud.Text = "Modificar "
        Me.botonModificaSolicitud.UseVisualStyleBackColor = False
        Me.botonModificaSolicitud.Visible = False
        '
        'lblfe1
        '
        Me.lblfe1.AutoSize = True
        Me.lblfe1.Location = New System.Drawing.Point(968, 417)
        Me.lblfe1.Name = "lblfe1"
        Me.lblfe1.Size = New System.Drawing.Size(39, 13)
        Me.lblfe1.TabIndex = 34
        Me.lblfe1.Text = "Label7"
        Me.lblfe1.Visible = False
        '
        'lblfe2
        '
        Me.lblfe2.AutoSize = True
        Me.lblfe2.Location = New System.Drawing.Point(968, 437)
        Me.lblfe2.Name = "lblfe2"
        Me.lblfe2.Size = New System.Drawing.Size(39, 13)
        Me.lblfe2.TabIndex = 35
        Me.lblfe2.Text = "Label7"
        Me.lblfe2.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 735)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1332, 11)
        Me.ProgressBar1.TabIndex = 38
        '
        'botonEliminarSolicitud
        '
        Me.botonEliminarSolicitud.BackColor = System.Drawing.Color.Salmon
        Me.botonEliminarSolicitud.Location = New System.Drawing.Point(492, 677)
        Me.botonEliminarSolicitud.Name = "botonEliminarSolicitud"
        Me.botonEliminarSolicitud.Size = New System.Drawing.Size(87, 52)
        Me.botonEliminarSolicitud.TabIndex = 39
        Me.botonEliminarSolicitud.Text = "Eliminar"
        Me.botonEliminarSolicitud.UseVisualStyleBackColor = False
        Me.botonEliminarSolicitud.Visible = False
        '
        'lblTipoReintegro
        '
        Me.lblTipoReintegro.AutoSize = True
        Me.lblTipoReintegro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoReintegro.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTipoReintegro.Location = New System.Drawing.Point(862, 335)
        Me.lblTipoReintegro.Name = "lblTipoReintegro"
        Me.lblTipoReintegro.Size = New System.Drawing.Size(154, 16)
        Me.lblTipoReintegro.TabIndex = 40
        Me.lblTipoReintegro.Text = "Reintegro o Subsidio"
        '
        'txtCuil
        '
        Me.txtCuil.Enabled = False
        Me.txtCuil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuil.Location = New System.Drawing.Point(893, 9)
        Me.txtCuil.Name = "txtCuil"
        Me.txtCuil.Size = New System.Drawing.Size(114, 22)
        Me.txtCuil.TabIndex = 78
        Me.txtCuil.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(7, 208)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(662, 467)
        Me.TabControl1.TabIndex = 79
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(654, 441)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pendientes Auditoría"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GridView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(654, 441)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Aprobados AM"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GridView2
        '
        Me.GridView2.AllowUserToAddRows = False
        Me.GridView2.AllowUserToDeleteRows = False
        Me.GridView2.BackgroundColor = System.Drawing.Color.DarkSeaGreen
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridView2.DefaultCellStyle = DataGridViewCellStyle3
        Me.GridView2.Location = New System.Drawing.Point(1, 3)
        Me.GridView2.MultiSelect = False
        Me.GridView2.Name = "GridView2"
        Me.GridView2.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.GridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridView2.Size = New System.Drawing.Size(651, 435)
        Me.GridView2.TabIndex = 95
        Me.GridView2.VirtualMode = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GridView3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(654, 441)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Rechazados AM"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GridView3
        '
        Me.GridView3.AllowUserToAddRows = False
        Me.GridView3.BackgroundColor = System.Drawing.Color.Firebrick
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridView3.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.GridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridView3.DefaultCellStyle = DataGridViewCellStyle6
        Me.GridView3.Location = New System.Drawing.Point(3, 3)
        Me.GridView3.MultiSelect = False
        Me.GridView3.Name = "GridView3"
        Me.GridView3.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridView3.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.GridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.GridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridView3.Size = New System.Drawing.Size(651, 438)
        Me.GridView3.TabIndex = 96
        Me.GridView3.VirtualMode = True
        '
        'ConsultaSolicitudReintegro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1333, 745)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txtCuil)
        Me.Controls.Add(Me.lblTipoReintegro)
        Me.Controls.Add(Me.botonEliminarSolicitud)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.CANCELA)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.botonModificaSolicitud)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.botonQuitarImagen)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.botonImagen)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblPicture)
        Me.Controls.Add(Me.clbimagen)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Boton_Salir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBeneficiario)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblfe2)
        Me.Controls.Add(Me.lblfe1)
        Me.Controls.Add(Me.Panel5)
        Me.Name = "ConsultaSolicitudReintegro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Solicitudes de Reintegro Generadas"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.lblPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtObservacionesCarga As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaSolicitud As System.Windows.Forms.TextBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents botonQuitarImagen As System.Windows.Forms.Button
    Friend WithEvents botonImagen As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CANCELA As System.Windows.Forms.Button
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents botonModificaSolicitud As System.Windows.Forms.Button
    Friend WithEvents lblfe1 As System.Windows.Forms.Label
    Friend WithEvents lblfe2 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents botonEliminarSolicitud As System.Windows.Forms.Button
    Friend WithEvents txtAlias As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCBU As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblTipoReintegro As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtCuilPago As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtTipoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents txtCuilPagoTEMPO As System.Windows.Forms.TextBox
    Friend WithEvents txtObservacionesTEMPO As System.Windows.Forms.TextBox
    Friend WithEvents txtAliasTEMPO As System.Windows.Forms.TextBox
    Friend WithEvents txtCBUTEMPO As System.Windows.Forms.TextBox
    Friend WithEvents txtFechSolicitudTEMPO As System.Windows.Forms.TextBox
    Friend WithEvents txtImporteTEMPO As System.Windows.Forms.TextBox
    Friend WithEvents txtDetalleTEMPO As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoCuentaTEMPO As System.Windows.Forms.TextBox
    Friend WithEvents txtCuil As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents GridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents opPAGADO As System.Windows.Forms.CheckBox
    Friend WithEvents opComisionRechazados As System.Windows.Forms.CheckBox
    Friend WithEvents opComisionAprobados As System.Windows.Forms.CheckBox
    Friend WithEvents opComisionPendientes As System.Windows.Forms.CheckBox
    Friend WithEvents opSubsidio As System.Windows.Forms.CheckBox
    Friend WithEvents opReintegro As System.Windows.Forms.CheckBox
    Friend WithEvents botonLimpiarFiltros As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents opAuditorMedicoSI As System.Windows.Forms.CheckBox
    Friend WithEvents opAuditorRechazado As System.Windows.Forms.CheckBox
    Friend WithEvents opPagoPendiente As System.Windows.Forms.CheckBox
    Friend WithEvents opPendienteAuditor As System.Windows.Forms.CheckBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
