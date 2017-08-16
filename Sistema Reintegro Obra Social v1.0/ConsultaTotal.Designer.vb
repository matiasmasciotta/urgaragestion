<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultaTotal
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
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConsultaTotal))
        Me.lblTipoReintegro = New System.Windows.Forms.Label()
        Me.botonEliminarSolicitud = New System.Windows.Forms.Button()
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.botonModificaSolicitud = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.botonQuitarImagen = New System.Windows.Forms.Button()
        Me.botonImagen = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtAlias = New System.Windows.Forms.TextBox()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCBU = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtObservacionesCarga = New System.Windows.Forms.TextBox()
        Me.Boton_Salir = New System.Windows.Forms.Button()
        Me.txtFechaSolicitud = New System.Windows.Forms.TextBox()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.clbimagen = New System.Windows.Forms.CheckedListBox()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GridViewReintegros = New System.Windows.Forms.DataGridView()
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
        Me.lblfe2 = New System.Windows.Forms.Label()
        Me.lblfe1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.opReintegro = New System.Windows.Forms.CheckBox()
        Me.opSubsidio = New System.Windows.Forms.CheckBox()
        Me.opPendienteAuditor = New System.Windows.Forms.CheckBox()
        Me.opAuditorMedicoSI = New System.Windows.Forms.CheckBox()
        Me.opComisionPendientes = New System.Windows.Forms.CheckBox()
        Me.opPagoPendiente = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.opPAGADO = New System.Windows.Forms.CheckBox()
        Me.opComisionRechazados = New System.Windows.Forms.CheckBox()
        Me.opComisionAprobados = New System.Windows.Forms.CheckBox()
        Me.opAuditorRechazado = New System.Windows.Forms.CheckBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.botonLimpiarFiltros = New System.Windows.Forms.Button()
        Me.lblPicture = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtTipoCuenta = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCuilPago = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Panel5.SuspendLayout()
        CType(Me.GridViewReintegros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.lblPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTipoReintegro
        '
        Me.lblTipoReintegro.AutoSize = True
        Me.lblTipoReintegro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoReintegro.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTipoReintegro.Location = New System.Drawing.Point(496, 134)
        Me.lblTipoReintegro.Name = "lblTipoReintegro"
        Me.lblTipoReintegro.Size = New System.Drawing.Size(154, 16)
        Me.lblTipoReintegro.TabIndex = 62
        Me.lblTipoReintegro.Text = "Reintegro o Subsidio"
        '
        'botonEliminarSolicitud
        '
        Me.botonEliminarSolicitud.BackColor = System.Drawing.Color.Salmon
        Me.botonEliminarSolicitud.Location = New System.Drawing.Point(492, 192)
        Me.botonEliminarSolicitud.Name = "botonEliminarSolicitud"
        Me.botonEliminarSolicitud.Size = New System.Drawing.Size(87, 52)
        Me.botonEliminarSolicitud.TabIndex = 61
        Me.botonEliminarSolicitud.Text = "Eliminar"
        Me.botonEliminarSolicitud.UseVisualStyleBackColor = False
        Me.botonEliminarSolicitud.Visible = False
        '
        'CANCELA
        '
        Me.CANCELA.BackColor = System.Drawing.Color.Chocolate
        Me.CANCELA.Location = New System.Drawing.Point(418, 218)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(75, 26)
        Me.CANCELA.TabIndex = 58
        Me.CANCELA.Text = "Cancelar"
        Me.CANCELA.UseVisualStyleBackColor = False
        Me.CANCELA.Visible = False
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.OK.Location = New System.Drawing.Point(296, 218)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(121, 26)
        Me.OK.TabIndex = 57
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = False
        Me.OK.Visible = False
        '
        'botonModificaSolicitud
        '
        Me.botonModificaSolicitud.BackColor = System.Drawing.Color.LightSkyBlue
        Me.botonModificaSolicitud.Location = New System.Drawing.Point(296, 192)
        Me.botonModificaSolicitud.Name = "botonModificaSolicitud"
        Me.botonModificaSolicitud.Size = New System.Drawing.Size(197, 26)
        Me.botonModificaSolicitud.TabIndex = 56
        Me.botonModificaSolicitud.Text = "Modificar "
        Me.botonModificaSolicitud.UseVisualStyleBackColor = False
        Me.botonModificaSolicitud.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(700, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 16)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Imagenes adjuntas"
        '
        'botonQuitarImagen
        '
        Me.botonQuitarImagen.BackColor = System.Drawing.Color.Salmon
        Me.botonQuitarImagen.Location = New System.Drawing.Point(764, 169)
        Me.botonQuitarImagen.Name = "botonQuitarImagen"
        Me.botonQuitarImagen.Size = New System.Drawing.Size(87, 25)
        Me.botonQuitarImagen.TabIndex = 44
        Me.botonQuitarImagen.Text = "- Quitar"
        Me.botonQuitarImagen.UseVisualStyleBackColor = False
        Me.botonQuitarImagen.Visible = False
        '
        'botonImagen
        '
        Me.botonImagen.BackColor = System.Drawing.Color.LightGreen
        Me.botonImagen.Location = New System.Drawing.Point(671, 169)
        Me.botonImagen.Name = "botonImagen"
        Me.botonImagen.Size = New System.Drawing.Size(87, 25)
        Me.botonImagen.TabIndex = 41
        Me.botonImagen.Text = "+Subir Imagen"
        Me.botonImagen.UseVisualStyleBackColor = False
        Me.botonImagen.Visible = False
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.txtTipoCuenta)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.txtCuilPago)
        Me.Panel5.Controls.Add(Me.Label19)
        Me.Panel5.Controls.Add(Me.txtAlias)
        Me.Panel5.Controls.Add(Me.DateTimePicker3)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.botonEliminarSolicitud)
        Me.Panel5.Controls.Add(Me.txtCBU)
        Me.Panel5.Controls.Add(Me.CANCELA)
        Me.Panel5.Controls.Add(Me.OK)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.botonModificaSolicitud)
        Me.Panel5.Controls.Add(Me.txtObservacionesCarga)
        Me.Panel5.Controls.Add(Me.Boton_Salir)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.txtFechaSolicitud)
        Me.Panel5.Controls.Add(Me.botonQuitarImagen)
        Me.Panel5.Controls.Add(Me.botonImagen)
        Me.Panel5.Controls.Add(Me.txtImporte)
        Me.Panel5.Controls.Add(Me.clbimagen)
        Me.Panel5.Controls.Add(Me.txtDetalle)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(Me.lblPicture)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Location = New System.Drawing.Point(7, 469)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1195, 251)
        Me.Panel5.TabIndex = 55
        '
        'txtAlias
        '
        Me.txtAlias.Enabled = False
        Me.txtAlias.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlias.Location = New System.Drawing.Point(368, 106)
        Me.txtAlias.MaxLength = 80
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Size = New System.Drawing.Size(211, 21)
        Me.txtAlias.TabIndex = 41
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker3.Location = New System.Drawing.Point(321, 79)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(257, 21)
        Me.DateTimePicker3.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(319, 109)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 14)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "ALIAS:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 14)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Observaciones:"
        '
        'txtCBU
        '
        Me.txtCBU.Enabled = False
        Me.txtCBU.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCBU.Location = New System.Drawing.Point(86, 105)
        Me.txtCBU.MaxLength = 22
        Me.txtCBU.Name = "txtCBU"
        Me.txtCBU.Size = New System.Drawing.Size(196, 21)
        Me.txtCBU.TabIndex = 40
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(49, 107)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 14)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "CBU:"
        '
        'txtObservacionesCarga
        '
        Me.txtObservacionesCarga.Enabled = False
        Me.txtObservacionesCarga.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacionesCarga.Location = New System.Drawing.Point(113, 163)
        Me.txtObservacionesCarga.Name = "txtObservacionesCarga"
        Me.txtObservacionesCarga.Size = New System.Drawing.Size(466, 21)
        Me.txtObservacionesCarga.TabIndex = 6
        '
        'Boton_Salir
        '
        Me.Boton_Salir.Location = New System.Drawing.Point(962, 184)
        Me.Boton_Salir.Name = "Boton_Salir"
        Me.Boton_Salir.Size = New System.Drawing.Size(219, 36)
        Me.Boton_Salir.TabIndex = 45
        Me.Boton_Salir.Text = "Salir"
        Me.Boton_Salir.UseVisualStyleBackColor = True
        '
        'txtFechaSolicitud
        '
        Me.txtFechaSolicitud.Enabled = False
        Me.txtFechaSolicitud.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaSolicitud.Location = New System.Drawing.Point(447, 55)
        Me.txtFechaSolicitud.Name = "txtFechaSolicitud"
        Me.txtFechaSolicitud.Size = New System.Drawing.Size(131, 21)
        Me.txtFechaSolicitud.TabIndex = 5
        '
        'txtImporte
        '
        Me.txtImporte.Enabled = False
        Me.txtImporte.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.Location = New System.Drawing.Point(447, 30)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(131, 21)
        Me.txtImporte.TabIndex = 4
        '
        'clbimagen
        '
        Me.clbimagen.BackColor = System.Drawing.Color.LightBlue
        Me.clbimagen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clbimagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbimagen.FormattingEnabled = True
        Me.clbimagen.Location = New System.Drawing.Point(639, 47)
        Me.clbimagen.Name = "clbimagen"
        Me.clbimagen.Size = New System.Drawing.Size(250, 96)
        Me.clbimagen.TabIndex = 49
        '
        'txtDetalle
        '
        Me.txtDetalle.Enabled = False
        Me.txtDetalle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalle.Location = New System.Drawing.Point(65, 6)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(514, 21)
        Me.txtDetalle.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1027, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Vista Previa"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(300, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(117, 14)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Fecha de Solicitud:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(377, 33)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 14)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Importe:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 14)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Detalle:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(-89, 554)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(88, 36)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "IMPRIMIR PDF"
        Me.Button1.UseVisualStyleBackColor = True
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
        'GridViewReintegros
        '
        Me.GridViewReintegros.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridViewReintegros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.GridViewReintegros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridViewReintegros.DefaultCellStyle = DataGridViewCellStyle11
        Me.GridViewReintegros.Location = New System.Drawing.Point(7, 153)
        Me.GridViewReintegros.MultiSelect = False
        Me.GridViewReintegros.Name = "GridViewReintegros"
        Me.GridViewReintegros.ReadOnly = True
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridViewReintegros.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.GridViewReintegros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.GridViewReintegros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridViewReintegros.Size = New System.Drawing.Size(1195, 310)
        Me.GridViewReintegros.TabIndex = 43
        Me.GridViewReintegros.VirtualMode = True
        '
        'txtBeneficiario
        '
        Me.txtBeneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeneficiario.Location = New System.Drawing.Point(21, 22)
        Me.txtBeneficiario.MaxLength = 13
        Me.txtBeneficiario.Name = "txtBeneficiario"
        Me.txtBeneficiario.Size = New System.Drawing.Size(286, 20)
        Me.txtBeneficiario.TabIndex = 42
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
        Me.GroupBox1.Location = New System.Drawing.Point(7, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 80)
        Me.GroupBox1.TabIndex = 47
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
        'lblfe2
        '
        Me.lblfe2.AutoSize = True
        Me.lblfe2.Location = New System.Drawing.Point(888, 540)
        Me.lblfe2.Name = "lblfe2"
        Me.lblfe2.Size = New System.Drawing.Size(39, 13)
        Me.lblfe2.TabIndex = 60
        Me.lblfe2.Text = "Label7"
        Me.lblfe2.Visible = False
        '
        'lblfe1
        '
        Me.lblfe1.AutoSize = True
        Me.lblfe1.Location = New System.Drawing.Point(888, 520)
        Me.lblfe1.Name = "lblfe1"
        Me.lblfe1.Size = New System.Drawing.Size(39, 13)
        Me.lblfe1.TabIndex = 59
        Me.lblfe1.Text = "Label7"
        Me.lblfe1.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(-1, 724)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1214, 10)
        Me.ProgressBar1.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Detalle a Buscar:"
        '
        'opReintegro
        '
        Me.opReintegro.AutoSize = True
        Me.opReintegro.Location = New System.Drawing.Point(10, 34)
        Me.opReintegro.Name = "opReintegro"
        Me.opReintegro.Size = New System.Drawing.Size(77, 17)
        Me.opReintegro.TabIndex = 65
        Me.opReintegro.Text = "Reintegros"
        Me.opReintegro.UseVisualStyleBackColor = True
        '
        'opSubsidio
        '
        Me.opSubsidio.AutoSize = True
        Me.opSubsidio.Location = New System.Drawing.Point(10, 52)
        Me.opSubsidio.Name = "opSubsidio"
        Me.opSubsidio.Size = New System.Drawing.Size(71, 17)
        Me.opSubsidio.TabIndex = 66
        Me.opSubsidio.Text = "Subsidios"
        Me.opSubsidio.UseVisualStyleBackColor = True
        '
        'opPendienteAuditor
        '
        Me.opPendienteAuditor.AutoSize = True
        Me.opPendienteAuditor.Location = New System.Drawing.Point(101, 34)
        Me.opPendienteAuditor.Name = "opPendienteAuditor"
        Me.opPendienteAuditor.Size = New System.Drawing.Size(79, 17)
        Me.opPendienteAuditor.TabIndex = 67
        Me.opPendienteAuditor.Text = "Pendientes"
        Me.opPendienteAuditor.UseVisualStyleBackColor = True
        '
        'opAuditorMedicoSI
        '
        Me.opAuditorMedicoSI.AutoSize = True
        Me.opAuditorMedicoSI.Location = New System.Drawing.Point(101, 52)
        Me.opAuditorMedicoSI.Name = "opAuditorMedicoSI"
        Me.opAuditorMedicoSI.Size = New System.Drawing.Size(77, 17)
        Me.opAuditorMedicoSI.TabIndex = 68
        Me.opAuditorMedicoSI.Text = "Aprobados"
        Me.opAuditorMedicoSI.UseVisualStyleBackColor = True
        '
        'opComisionPendientes
        '
        Me.opComisionPendientes.AutoSize = True
        Me.opComisionPendientes.Location = New System.Drawing.Point(217, 34)
        Me.opComisionPendientes.Name = "opComisionPendientes"
        Me.opComisionPendientes.Size = New System.Drawing.Size(79, 17)
        Me.opComisionPendientes.TabIndex = 69
        Me.opComisionPendientes.Text = "Pendientes"
        Me.opComisionPendientes.UseVisualStyleBackColor = True
        '
        'opPagoPendiente
        '
        Me.opPagoPendiente.AutoSize = True
        Me.opPagoPendiente.Location = New System.Drawing.Point(323, 34)
        Me.opPagoPendiente.Name = "opPagoPendiente"
        Me.opPagoPendiente.Size = New System.Drawing.Size(79, 17)
        Me.opPagoPendiente.TabIndex = 70
        Me.opPagoPendiente.Text = "Pendientes"
        Me.opPagoPendiente.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.opPAGADO)
        Me.GroupBox2.Controls.Add(Me.opComisionRechazados)
        Me.GroupBox2.Controls.Add(Me.opComisionAprobados)
        Me.GroupBox2.Controls.Add(Me.opAuditorMedicoSI)
        Me.GroupBox2.Controls.Add(Me.opAuditorRechazado)
        Me.GroupBox2.Controls.Add(Me.opPagoPendiente)
        Me.GroupBox2.Controls.Add(Me.opComisionPendientes)
        Me.GroupBox2.Controls.Add(Me.opPendienteAuditor)
        Me.GroupBox2.Controls.Add(Me.opSubsidio)
        Me.GroupBox2.Controls.Add(Me.opReintegro)
        Me.GroupBox2.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox2.Location = New System.Drawing.Point(633, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(410, 116)
        Me.GroupBox2.TabIndex = 71
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtros"
        '
        'opPAGADO
        '
        Me.opPAGADO.AutoSize = True
        Me.opPAGADO.Location = New System.Drawing.Point(323, 52)
        Me.opPAGADO.Name = "opPAGADO"
        Me.opPAGADO.Size = New System.Drawing.Size(68, 17)
        Me.opPAGADO.TabIndex = 74
        Me.opPAGADO.Text = "Pagados"
        Me.opPAGADO.UseVisualStyleBackColor = True
        '
        'opComisionRechazados
        '
        Me.opComisionRechazados.AutoSize = True
        Me.opComisionRechazados.Location = New System.Drawing.Point(217, 72)
        Me.opComisionRechazados.Name = "opComisionRechazados"
        Me.opComisionRechazados.Size = New System.Drawing.Size(86, 17)
        Me.opComisionRechazados.TabIndex = 73
        Me.opComisionRechazados.Text = "Rechazados"
        Me.opComisionRechazados.UseVisualStyleBackColor = True
        '
        'opComisionAprobados
        '
        Me.opComisionAprobados.AutoSize = True
        Me.opComisionAprobados.Location = New System.Drawing.Point(217, 52)
        Me.opComisionAprobados.Name = "opComisionAprobados"
        Me.opComisionAprobados.Size = New System.Drawing.Size(77, 17)
        Me.opComisionAprobados.TabIndex = 72
        Me.opComisionAprobados.Text = "Aprobados"
        Me.opComisionAprobados.UseVisualStyleBackColor = True
        '
        'opAuditorRechazado
        '
        Me.opAuditorRechazado.AutoSize = True
        Me.opAuditorRechazado.Location = New System.Drawing.Point(101, 72)
        Me.opAuditorRechazado.Name = "opAuditorRechazado"
        Me.opAuditorRechazado.Size = New System.Drawing.Size(86, 17)
        Me.opAuditorRechazado.TabIndex = 71
        Me.opAuditorRechazado.Text = "Rechazados"
        Me.opAuditorRechazado.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape4, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(404, 97)
        Me.ShapeContainer1.TabIndex = 75
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 88
        Me.LineShape1.X2 = 87
        Me.LineShape1.Y1 = 18
        Me.LineShape1.Y2 = 90
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(109, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "Auditoría Médica"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Tipo"
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 205
        Me.LineShape2.X2 = 204
        Me.LineShape2.Y1 = 19
        Me.LineShape2.Y2 = 91
        '
        'LineShape4
        '
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 11
        Me.LineShape4.X2 = 403
        Me.LineShape4.Y1 = 14
        Me.LineShape4.Y2 = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(214, 17)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "Comisión Directiva"
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 308
        Me.LineShape3.X2 = 307
        Me.LineShape3.Y1 = 19
        Me.LineShape3.Y2 = 91
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(310, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 13)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "Pago del Reintegro"
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
        Me.botonLimpiarFiltros.Location = New System.Drawing.Point(1049, 32)
        Me.botonLimpiarFiltros.Name = "botonLimpiarFiltros"
        Me.botonLimpiarFiltros.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.botonLimpiarFiltros.Size = New System.Drawing.Size(80, 82)
        Me.botonLimpiarFiltros.TabIndex = 75
        Me.botonLimpiarFiltros.Text = "Limpiar Filtros"
        Me.botonLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.botonLimpiarFiltros.UseVisualStyleBackColor = True
        '
        'lblPicture
        '
        Me.lblPicture.Location = New System.Drawing.Point(973, 35)
        Me.lblPicture.Name = "lblPicture"
        Me.lblPicture.Size = New System.Drawing.Size(198, 144)
        Me.lblPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lblPicture.TabIndex = 50
        Me.lblPicture.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.recazul
        Me.PictureBox1.Location = New System.Drawing.Point(597, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(351, 211)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'txtTipoCuenta
        '
        Me.txtTipoCuenta.Enabled = False
        Me.txtTipoCuenta.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoCuenta.Location = New System.Drawing.Point(370, 135)
        Me.txtTipoCuenta.MaxLength = 80
        Me.txtTipoCuenta.Name = "txtTipoCuenta"
        Me.txtTipoCuenta.Size = New System.Drawing.Size(208, 21)
        Me.txtTipoCuenta.TabIndex = 63
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(288, 137)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 14)
        Me.Label17.TabIndex = 65
        Me.Label17.Text = "Tipo Cuenta:"
        '
        'txtCuilPago
        '
        Me.txtCuilPago.Enabled = False
        Me.txtCuilPago.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuilPago.Location = New System.Drawing.Point(113, 135)
        Me.txtCuilPago.MaxLength = 22
        Me.txtCuilPago.Name = "txtCuilPago"
        Me.txtCuilPago.Size = New System.Drawing.Size(169, 21)
        Me.txtCuilPago.TabIndex = 62
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(1, 138)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(106, 14)
        Me.Label19.TabIndex = 64
        Me.Label19.Text = "CUIL Tit. Cuenta:"
        '
        'ConsultaTotal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1212, 743)
        Me.Controls.Add(Me.botonLimpiarFiltros)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lblTipoReintegro)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtBeneficiario)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblfe2)
        Me.Controls.Add(Me.lblfe1)
        Me.Controls.Add(Me.GridViewReintegros)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "ConsultaTotal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Gal"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.GridViewReintegros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.lblPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTipoReintegro As System.Windows.Forms.Label
    Friend WithEvents botonEliminarSolicitud As System.Windows.Forms.Button
    Friend WithEvents CANCELA As System.Windows.Forms.Button
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents botonModificaSolicitud As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents botonQuitarImagen As System.Windows.Forms.Button
    Friend WithEvents botonImagen As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtAlias As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCBU As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtObservacionesCarga As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaSolicitud As System.Windows.Forms.TextBox
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblPicture As System.Windows.Forms.PictureBox
    Friend WithEvents clbimagen As System.Windows.Forms.CheckedListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Boton_Salir As System.Windows.Forms.Button
    Friend WithEvents GridViewReintegros As System.Windows.Forms.DataGridView
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
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblfe2 As System.Windows.Forms.Label
    Friend WithEvents lblfe1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents opReintegro As System.Windows.Forms.CheckBox
    Friend WithEvents opSubsidio As System.Windows.Forms.CheckBox
    Friend WithEvents opPendienteAuditor As System.Windows.Forms.CheckBox
    Friend WithEvents opAuditorMedicoSI As System.Windows.Forms.CheckBox
    Friend WithEvents opComisionPendientes As System.Windows.Forms.CheckBox
    Friend WithEvents opPagoPendiente As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents opAuditorRechazado As System.Windows.Forms.CheckBox
    Friend WithEvents opPAGADO As System.Windows.Forms.CheckBox
    Friend WithEvents opComisionRechazados As System.Windows.Forms.CheckBox
    Friend WithEvents opComisionAprobados As System.Windows.Forms.CheckBox
    Friend WithEvents botonLimpiarFiltros As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape4 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents txtTipoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCuilPago As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
End Class
