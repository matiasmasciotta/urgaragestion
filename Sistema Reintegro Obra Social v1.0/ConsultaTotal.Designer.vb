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
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTipoReintegro = New System.Windows.Forms.Label()
        Me.botonEliminarSolicitud = New System.Windows.Forms.Button()
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.botonModificaSolicitud = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.botonQuitarImagen = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.botonImagen = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtAlias = New System.Windows.Forms.TextBox()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCBU = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtObservacionesCarga = New System.Windows.Forms.TextBox()
        Me.txtFechaSolicitud = New System.Windows.Forms.TextBox()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.clbimagen = New System.Windows.Forms.CheckedListBox()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblPicture = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Boton_Salir = New System.Windows.Forms.Button()
        Me.opSubsidios = New System.Windows.Forms.DataGridView()
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
        Me.opComisionSI = New System.Windows.Forms.CheckBox()
        Me.opPagadoSi = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.opAuditorRechazado = New System.Windows.Forms.CheckBox()
        Me.Panel5.SuspendLayout()
        CType(Me.lblPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.opSubsidios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTipoReintegro
        '
        Me.lblTipoReintegro.AutoSize = True
        Me.lblTipoReintegro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoReintegro.ForeColor = System.Drawing.Color.DarkRed
        Me.lblTipoReintegro.Location = New System.Drawing.Point(394, 144)
        Me.lblTipoReintegro.Name = "lblTipoReintegro"
        Me.lblTipoReintegro.Size = New System.Drawing.Size(154, 16)
        Me.lblTipoReintegro.TabIndex = 62
        Me.lblTipoReintegro.Text = "Reintegro o Subsidio"
        '
        'botonEliminarSolicitud
        '
        Me.botonEliminarSolicitud.BackColor = System.Drawing.Color.Salmon
        Me.botonEliminarSolicitud.Location = New System.Drawing.Point(1094, 59)
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
        Me.CANCELA.Location = New System.Drawing.Point(1013, 59)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(84, 52)
        Me.CANCELA.TabIndex = 58
        Me.CANCELA.Text = "Cancelar"
        Me.CANCELA.UseVisualStyleBackColor = False
        Me.CANCELA.Visible = False
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.OK.Location = New System.Drawing.Point(891, 85)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(126, 26)
        Me.OK.TabIndex = 57
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = False
        Me.OK.Visible = False
        '
        'botonModificaSolicitud
        '
        Me.botonModificaSolicitud.BackColor = System.Drawing.Color.LightSkyBlue
        Me.botonModificaSolicitud.Location = New System.Drawing.Point(891, 59)
        Me.botonModificaSolicitud.Name = "botonModificaSolicitud"
        Me.botonModificaSolicitud.Size = New System.Drawing.Size(126, 29)
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
        Me.Label4.Location = New System.Drawing.Point(694, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 16)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Imagenes adjuntas"
        '
        'botonQuitarImagen
        '
        Me.botonQuitarImagen.BackColor = System.Drawing.Color.Salmon
        Me.botonQuitarImagen.Location = New System.Drawing.Point(747, 172)
        Me.botonQuitarImagen.Name = "botonQuitarImagen"
        Me.botonQuitarImagen.Size = New System.Drawing.Size(87, 25)
        Me.botonQuitarImagen.TabIndex = 44
        Me.botonQuitarImagen.Text = "- Quitar"
        Me.botonQuitarImagen.UseVisualStyleBackColor = False
        Me.botonQuitarImagen.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(122, 19)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(383, 16)
        Me.Label10.TabIndex = 54
        Me.Label10.Text = "Datos Cargados para la solicitud del Nuevo Reintegro"
        '
        'botonImagen
        '
        Me.botonImagen.BackColor = System.Drawing.Color.LightGreen
        Me.botonImagen.Location = New System.Drawing.Point(654, 172)
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
        Me.Panel5.Controls.Add(Me.txtAlias)
        Me.Panel5.Controls.Add(Me.DateTimePicker3)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Controls.Add(Me.txtCBU)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.txtObservacionesCarga)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.txtFechaSolicitud)
        Me.Panel5.Controls.Add(Me.botonQuitarImagen)
        Me.Panel5.Controls.Add(Me.botonImagen)
        Me.Panel5.Controls.Add(Me.txtImporte)
        Me.Panel5.Controls.Add(Me.Label10)
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
        Me.Panel5.Size = New System.Drawing.Size(1195, 237)
        Me.Panel5.TabIndex = 55
        '
        'txtAlias
        '
        Me.txtAlias.Enabled = False
        Me.txtAlias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlias.Location = New System.Drawing.Point(368, 164)
        Me.txtAlias.MaxLength = 80
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Size = New System.Drawing.Size(188, 22)
        Me.txtAlias.TabIndex = 41
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker3.Location = New System.Drawing.Point(142, 132)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(257, 22)
        Me.DateTimePicker3.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(316, 166)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 16)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "ALIAS:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(2, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Observaciones:"
        '
        'txtCBU
        '
        Me.txtCBU.Enabled = False
        Me.txtCBU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCBU.Location = New System.Drawing.Point(117, 164)
        Me.txtCBU.MaxLength = 22
        Me.txtCBU.Name = "txtCBU"
        Me.txtCBU.Size = New System.Drawing.Size(196, 22)
        Me.txtCBU.TabIndex = 40
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(69, 166)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 16)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "CBU:"
        '
        'txtObservacionesCarga
        '
        Me.txtObservacionesCarga.Enabled = False
        Me.txtObservacionesCarga.Location = New System.Drawing.Point(119, 197)
        Me.txtObservacionesCarga.Name = "txtObservacionesCarga"
        Me.txtObservacionesCarga.Size = New System.Drawing.Size(437, 20)
        Me.txtObservacionesCarga.TabIndex = 6
        '
        'txtFechaSolicitud
        '
        Me.txtFechaSolicitud.Enabled = False
        Me.txtFechaSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaSolicitud.Location = New System.Drawing.Point(268, 100)
        Me.txtFechaSolicitud.Name = "txtFechaSolicitud"
        Me.txtFechaSolicitud.Size = New System.Drawing.Size(131, 22)
        Me.txtFechaSolicitud.TabIndex = 5
        '
        'txtImporte
        '
        Me.txtImporte.Enabled = False
        Me.txtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.Location = New System.Drawing.Point(268, 69)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(131, 22)
        Me.txtImporte.TabIndex = 4
        '
        'clbimagen
        '
        Me.clbimagen.BackColor = System.Drawing.Color.LightBlue
        Me.clbimagen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clbimagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbimagen.FormattingEnabled = True
        Me.clbimagen.Location = New System.Drawing.Point(639, 50)
        Me.clbimagen.Name = "clbimagen"
        Me.clbimagen.Size = New System.Drawing.Size(250, 96)
        Me.clbimagen.TabIndex = 49
        '
        'txtDetalle
        '
        Me.txtDetalle.Enabled = False
        Me.txtDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalle.Location = New System.Drawing.Point(3, 38)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(553, 22)
        Me.txtDetalle.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1023, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Vista Previa"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(121, 103)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(141, 16)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Fecha de Solicitud:"
        '
        'lblPicture
        '
        Me.lblPicture.Location = New System.Drawing.Point(975, 38)
        Me.lblPicture.Name = "lblPicture"
        Me.lblPicture.Size = New System.Drawing.Size(198, 144)
        Me.lblPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lblPicture.TabIndex = 50
        Me.lblPicture.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(198, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 16)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Importe:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 16)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Detalle:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.recazul
        Me.PictureBox1.Location = New System.Drawing.Point(596, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(351, 211)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
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
        Me.DateTimePicker1.Location = New System.Drawing.Point(132, 110)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(201, 20)
        Me.DateTimePicker1.TabIndex = 46
        Me.DateTimePicker1.Visible = False
        '
        'Boton_Salir
        '
        Me.Boton_Salir.Location = New System.Drawing.Point(891, 116)
        Me.Boton_Salir.Name = "Boton_Salir"
        Me.Boton_Salir.Size = New System.Drawing.Size(290, 36)
        Me.Boton_Salir.TabIndex = 45
        Me.Boton_Salir.Text = "Salir"
        Me.Boton_Salir.UseVisualStyleBackColor = True
        '
        'opSubsidios
        '
        Me.opSubsidios.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.opSubsidios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.opSubsidios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.opSubsidios.DefaultCellStyle = DataGridViewCellStyle20
        Me.opSubsidios.Location = New System.Drawing.Point(7, 163)
        Me.opSubsidios.MultiSelect = False
        Me.opSubsidios.Name = "opSubsidios"
        Me.opSubsidios.ReadOnly = True
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.opSubsidios.RowHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.opSubsidios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.opSubsidios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.opSubsidios.Size = New System.Drawing.Size(1195, 300)
        Me.opSubsidios.TabIndex = 43
        Me.opSubsidios.VirtualMode = True
        '
        'txtBeneficiario
        '
        Me.txtBeneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeneficiario.Location = New System.Drawing.Point(24, 25)
        Me.txtBeneficiario.MaxLength = 13
        Me.txtBeneficiario.Name = "txtBeneficiario"
        Me.txtBeneficiario.Size = New System.Drawing.Size(286, 22)
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
        Me.GroupBox1.Location = New System.Drawing.Point(7, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(618, 88)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        '
        'lblfechahasta
        '
        Me.lblfechahasta.AutoSize = True
        Me.lblfechahasta.Location = New System.Drawing.Point(400, 14)
        Me.lblfechahasta.Name = "lblfechahasta"
        Me.lblfechahasta.Size = New System.Drawing.Size(94, 13)
        Me.lblfechahasta.TabIndex = 23
        Me.lblfechahasta.Text = "Año  -  Mes  -  Día"
        Me.lblfechahasta.Visible = False
        '
        'lblfechadesde
        '
        Me.lblfechadesde.AutoSize = True
        Me.lblfechadesde.Location = New System.Drawing.Point(135, 14)
        Me.lblfechadesde.Name = "lblfechadesde"
        Me.lblfechadesde.Size = New System.Drawing.Size(94, 13)
        Me.lblfechadesde.TabIndex = 22
        Me.lblfechadesde.Text = "Año  -  Mes  -  Día"
        Me.lblfechadesde.Visible = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(390, 58)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 21
        Me.DateTimePicker2.Visible = False
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaHasta.Location = New System.Drawing.Point(390, 30)
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Size = New System.Drawing.Size(200, 22)
        Me.txtFechaHasta.TabIndex = 12
        Me.txtFechaHasta.Visible = False
        '
        'checkFecha
        '
        Me.checkFecha.AutoSize = True
        Me.checkFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkFecha.Location = New System.Drawing.Point(7, -2)
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
        Me.Label3.Location = New System.Drawing.Point(346, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Hasta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Fecha Desde:"
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaDesde.Location = New System.Drawing.Point(126, 30)
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
        Me.ProgressBar1.Location = New System.Drawing.Point(-1, 693)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1214, 23)
        Me.ProgressBar1.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 16)
        Me.Label1.TabIndex = 64
        Me.Label1.Text = "Detalle a Buscar:"
        '
        'opReintegro
        '
        Me.opReintegro.AutoSize = True
        Me.opReintegro.Location = New System.Drawing.Point(8, 18)
        Me.opReintegro.Name = "opReintegro"
        Me.opReintegro.Size = New System.Drawing.Size(97, 17)
        Me.opReintegro.TabIndex = 65
        Me.opReintegro.Text = "REINTEGROS"
        Me.opReintegro.UseVisualStyleBackColor = True
        '
        'opSubsidio
        '
        Me.opSubsidio.AutoSize = True
        Me.opSubsidio.Location = New System.Drawing.Point(113, 17)
        Me.opSubsidio.Name = "opSubsidio"
        Me.opSubsidio.Size = New System.Drawing.Size(84, 17)
        Me.opSubsidio.TabIndex = 66
        Me.opSubsidio.Text = "SUBSIDIOS"
        Me.opSubsidio.UseVisualStyleBackColor = True
        '
        'opPendienteAuditor
        '
        Me.opPendienteAuditor.AutoSize = True
        Me.opPendienteAuditor.Location = New System.Drawing.Point(8, 48)
        Me.opPendienteAuditor.Name = "opPendienteAuditor"
        Me.opPendienteAuditor.Size = New System.Drawing.Size(95, 17)
        Me.opPendienteAuditor.TabIndex = 67
        Me.opPendienteAuditor.Text = "PENDIENTES"
        Me.opPendienteAuditor.UseVisualStyleBackColor = True
        '
        'opAuditorMedicoSI
        '
        Me.opAuditorMedicoSI.AutoSize = True
        Me.opAuditorMedicoSI.Location = New System.Drawing.Point(641, 77)
        Me.opAuditorMedicoSI.Name = "opAuditorMedicoSI"
        Me.opAuditorMedicoSI.Size = New System.Drawing.Size(183, 17)
        Me.opAuditorMedicoSI.TabIndex = 68
        Me.opAuditorMedicoSI.Text = "AUDITOR MEDICO APROBADO"
        Me.opAuditorMedicoSI.UseVisualStyleBackColor = True
        '
        'opComisionSI
        '
        Me.opComisionSI.AutoSize = True
        Me.opComisionSI.Location = New System.Drawing.Point(8, 108)
        Me.opComisionSI.Name = "opComisionSI"
        Me.opComisionSI.Size = New System.Drawing.Size(142, 17)
        Me.opComisionSI.TabIndex = 69
        Me.opComisionSI.Text = "APROBADO COMISION"
        Me.opComisionSI.UseVisualStyleBackColor = True
        '
        'opPagadoSi
        '
        Me.opPagadoSi.AutoSize = True
        Me.opPagadoSi.Location = New System.Drawing.Point(8, 124)
        Me.opPagadoSi.Name = "opPagadoSi"
        Me.opPagadoSi.Size = New System.Drawing.Size(110, 17)
        Me.opPagadoSi.TabIndex = 70
        Me.opPagadoSi.Text = "PAGADO JORGE"
        Me.opPagadoSi.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.opAuditorRechazado)
        Me.GroupBox2.Controls.Add(Me.opPagadoSi)
        Me.GroupBox2.Controls.Add(Me.opComisionSI)
        Me.GroupBox2.Controls.Add(Me.opPendienteAuditor)
        Me.GroupBox2.Controls.Add(Me.opSubsidio)
        Me.GroupBox2.Controls.Add(Me.opReintegro)
        Me.GroupBox2.Location = New System.Drawing.Point(633, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(232, 148)
        Me.GroupBox2.TabIndex = 71
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estado del Reintegro"
        '
        'opAuditorRechazado
        '
        Me.opAuditorRechazado.AutoSize = True
        Me.opAuditorRechazado.Location = New System.Drawing.Point(8, 84)
        Me.opAuditorRechazado.Name = "opAuditorRechazado"
        Me.opAuditorRechazado.Size = New System.Drawing.Size(189, 17)
        Me.opAuditorRechazado.TabIndex = 71
        Me.opAuditorRechazado.Text = "AUTITOR MEDICO RECHAZADO"
        Me.opAuditorRechazado.UseVisualStyleBackColor = True
        '
        'ConsultaTotal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1212, 726)
        Me.Controls.Add(Me.opAuditorMedicoSI)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lblTipoReintegro)
        Me.Controls.Add(Me.botonEliminarSolicitud)
        Me.Controls.Add(Me.CANCELA)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.botonModificaSolicitud)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtBeneficiario)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblfe2)
        Me.Controls.Add(Me.lblfe1)
        Me.Controls.Add(Me.opSubsidios)
        Me.Controls.Add(Me.Boton_Salir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "ConsultaTotal"
        Me.Text = "Consulta Gal"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.lblPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.opSubsidios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents Label10 As System.Windows.Forms.Label
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
    Friend WithEvents opSubsidios As System.Windows.Forms.DataGridView
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
    Friend WithEvents opComisionSI As System.Windows.Forms.CheckBox
    Friend WithEvents opPagadoSi As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents opAuditorRechazado As System.Windows.Forms.CheckBox
End Class
