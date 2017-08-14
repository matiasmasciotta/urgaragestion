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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.lblPicture = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.botonLimpiarFiltros = New System.Windows.Forms.Button()
        Me.Panel5.SuspendLayout()
        CType(Me.lblPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewReintegros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.botonEliminarSolicitud.Location = New System.Drawing.Point(492, 195)
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
        Me.CANCELA.Location = New System.Drawing.Point(418, 221)
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
        Me.OK.Location = New System.Drawing.Point(296, 221)
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
        Me.botonModificaSolicitud.Location = New System.Drawing.Point(296, 195)
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
        Me.Label4.Location = New System.Drawing.Point(694, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 16)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Imagenes adjuntas"
        '
        'botonQuitarImagen
        '
        Me.botonQuitarImagen.BackColor = System.Drawing.Color.Salmon
        Me.botonQuitarImagen.Location = New System.Drawing.Point(764, 172)
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
        Me.botonImagen.Location = New System.Drawing.Point(671, 172)
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
        Me.txtAlias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlias.Location = New System.Drawing.Point(368, 136)
        Me.txtAlias.MaxLength = 80
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Size = New System.Drawing.Size(211, 22)
        Me.txtAlias.TabIndex = 41
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Enabled = False
        Me.DateTimePicker3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker3.Location = New System.Drawing.Point(321, 105)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(257, 22)
        Me.DateTimePicker3.TabIndex = 8
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(316, 138)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 16)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "ALIAS:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(2, 170)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Observaciones:"
        '
        'txtCBU
        '
        Me.txtCBU.Enabled = False
        Me.txtCBU.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCBU.Location = New System.Drawing.Point(117, 136)
        Me.txtCBU.MaxLength = 22
        Me.txtCBU.Name = "txtCBU"
        Me.txtCBU.Size = New System.Drawing.Size(196, 22)
        Me.txtCBU.TabIndex = 40
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(69, 138)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 16)
        Me.Label15.TabIndex = 42
        Me.Label15.Text = "CBU:"
        '
        'txtObservacionesCarga
        '
        Me.txtObservacionesCarga.Enabled = False
        Me.txtObservacionesCarga.Location = New System.Drawing.Point(119, 167)
        Me.txtObservacionesCarga.Name = "txtObservacionesCarga"
        Me.txtObservacionesCarga.Size = New System.Drawing.Size(460, 20)
        Me.txtObservacionesCarga.TabIndex = 6
        '
        'Boton_Salir
        '
        Me.Boton_Salir.Location = New System.Drawing.Point(968, 204)
        Me.Boton_Salir.Name = "Boton_Salir"
        Me.Boton_Salir.Size = New System.Drawing.Size(219, 36)
        Me.Boton_Salir.TabIndex = 45
        Me.Boton_Salir.Text = "Salir"
        Me.Boton_Salir.UseVisualStyleBackColor = True
        '
        'txtFechaSolicitud
        '
        Me.txtFechaSolicitud.Enabled = False
        Me.txtFechaSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaSolicitud.Location = New System.Drawing.Point(447, 77)
        Me.txtFechaSolicitud.Name = "txtFechaSolicitud"
        Me.txtFechaSolicitud.Size = New System.Drawing.Size(131, 22)
        Me.txtFechaSolicitud.TabIndex = 5
        '
        'txtImporte
        '
        Me.txtImporte.Enabled = False
        Me.txtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.Location = New System.Drawing.Point(447, 46)
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
        Me.txtDetalle.Location = New System.Drawing.Point(65, 14)
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(514, 22)
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
        Me.Label13.Location = New System.Drawing.Point(300, 80)
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
        Me.Label12.Location = New System.Drawing.Point(377, 49)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 16)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Importe:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 16)
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridViewReintegros.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GridViewReintegros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridViewReintegros.DefaultCellStyle = DataGridViewCellStyle5
        Me.GridViewReintegros.Location = New System.Drawing.Point(7, 153)
        Me.GridViewReintegros.MultiSelect = False
        Me.GridViewReintegros.Name = "GridViewReintegros"
        Me.GridViewReintegros.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridViewReintegros.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
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
        Me.opReintegro.Location = New System.Drawing.Point(9, 19)
        Me.opReintegro.Name = "opReintegro"
        Me.opReintegro.Size = New System.Drawing.Size(77, 17)
        Me.opReintegro.TabIndex = 65
        Me.opReintegro.Text = "Reintegros"
        Me.opReintegro.UseVisualStyleBackColor = True
        '
        'opSubsidio
        '
        Me.opSubsidio.AutoSize = True
        Me.opSubsidio.Location = New System.Drawing.Point(9, 34)
        Me.opSubsidio.Name = "opSubsidio"
        Me.opSubsidio.Size = New System.Drawing.Size(71, 17)
        Me.opSubsidio.TabIndex = 66
        Me.opSubsidio.Text = "Subsidios"
        Me.opSubsidio.UseVisualStyleBackColor = True
        '
        'opPendienteAuditor
        '
        Me.opPendienteAuditor.AutoSize = True
        Me.opPendienteAuditor.Enabled = False
        Me.opPendienteAuditor.Location = New System.Drawing.Point(117, 19)
        Me.opPendienteAuditor.Name = "opPendienteAuditor"
        Me.opPendienteAuditor.Size = New System.Drawing.Size(104, 17)
        Me.opPendienteAuditor.TabIndex = 67
        Me.opPendienteAuditor.Text = "A.M. Pendientes"
        Me.opPendienteAuditor.UseVisualStyleBackColor = True
        Me.opPendienteAuditor.Visible = False
        '
        'opAuditorMedicoSI
        '
        Me.opAuditorMedicoSI.AutoSize = True
        Me.opAuditorMedicoSI.Location = New System.Drawing.Point(117, 34)
        Me.opAuditorMedicoSI.Name = "opAuditorMedicoSI"
        Me.opAuditorMedicoSI.Size = New System.Drawing.Size(105, 17)
        Me.opAuditorMedicoSI.TabIndex = 68
        Me.opAuditorMedicoSI.Text = "A. M. Aprobados"
        Me.opAuditorMedicoSI.UseVisualStyleBackColor = True
        '
        'opComisionPendientes
        '
        Me.opComisionPendientes.AutoSize = True
        Me.opComisionPendientes.Location = New System.Drawing.Point(259, 19)
        Me.opComisionPendientes.Name = "opComisionPendientes"
        Me.opComisionPendientes.Size = New System.Drawing.Size(103, 17)
        Me.opComisionPendientes.TabIndex = 69
        Me.opComisionPendientes.Text = "C.D. Pendientes"
        Me.opComisionPendientes.UseVisualStyleBackColor = True
        '
        'opPagoPendiente
        '
        Me.opPagoPendiente.AutoSize = True
        Me.opPagoPendiente.Location = New System.Drawing.Point(259, 78)
        Me.opPagoPendiente.Name = "opPagoPendiente"
        Me.opPagoPendiente.Size = New System.Drawing.Size(122, 17)
        Me.opPagoPendiente.TabIndex = 70
        Me.opPagoPendiente.Text = "Pendientes de Pago"
        Me.opPagoPendiente.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
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
        Me.GroupBox2.Size = New System.Drawing.Size(406, 116)
        Me.GroupBox2.TabIndex = 71
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtros"
        '
        'opPAGADO
        '
        Me.opPAGADO.AutoSize = True
        Me.opPAGADO.Location = New System.Drawing.Point(259, 95)
        Me.opPAGADO.Name = "opPAGADO"
        Me.opPAGADO.Size = New System.Drawing.Size(110, 17)
        Me.opPAGADO.TabIndex = 74
        Me.opPAGADO.Text = "PAGADO JORGE"
        Me.opPAGADO.UseVisualStyleBackColor = True
        '
        'opComisionRechazados
        '
        Me.opComisionRechazados.AutoSize = True
        Me.opComisionRechazados.Location = New System.Drawing.Point(259, 50)
        Me.opComisionRechazados.Name = "opComisionRechazados"
        Me.opComisionRechazados.Size = New System.Drawing.Size(110, 17)
        Me.opComisionRechazados.TabIndex = 73
        Me.opComisionRechazados.Text = "C.D. Rechazados"
        Me.opComisionRechazados.UseVisualStyleBackColor = True
        '
        'opComisionAprobados
        '
        Me.opComisionAprobados.AutoSize = True
        Me.opComisionAprobados.Location = New System.Drawing.Point(259, 34)
        Me.opComisionAprobados.Name = "opComisionAprobados"
        Me.opComisionAprobados.Size = New System.Drawing.Size(101, 17)
        Me.opComisionAprobados.TabIndex = 72
        Me.opComisionAprobados.Text = "C.D. Aprobados"
        Me.opComisionAprobados.UseVisualStyleBackColor = True
        '
        'opAuditorRechazado
        '
        Me.opAuditorRechazado.AutoSize = True
        Me.opAuditorRechazado.Location = New System.Drawing.Point(117, 50)
        Me.opAuditorRechazado.Name = "opAuditorRechazado"
        Me.opAuditorRechazado.Size = New System.Drawing.Size(114, 17)
        Me.opAuditorRechazado.TabIndex = 71
        Me.opAuditorRechazado.Text = "A. M. Rechazados"
        Me.opAuditorRechazado.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 16)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(400, 97)
        Me.ShapeContainer1.TabIndex = 75
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape3
        '
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 259
        Me.LineShape3.X2 = 353
        Me.LineShape3.Y1 = 55
        Me.LineShape3.Y2 = 55
        '
        'LineShape2
        '
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 237
        Me.LineShape2.X2 = 237
        Me.LineShape2.Y1 = -6
        Me.LineShape2.Y2 = 90
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 95
        Me.LineShape1.X2 = 95
        Me.LineShape1.Y1 = -6
        Me.LineShape1.Y2 = 90
        '
        'botonLimpiarFiltros
        '
        Me.botonLimpiarFiltros.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.botonLimpiarFiltros.AutoEllipsis = True
        Me.botonLimpiarFiltros.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.botonLimpiarFiltros.BackColor = System.Drawing.Color.Transparent
        Me.botonLimpiarFiltros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.botonLimpiarFiltros.Image = CType(resources.GetObject("botonLimpiarFiltros.Image"), System.Drawing.Image)
        Me.botonLimpiarFiltros.Location = New System.Drawing.Point(1045, 41)
        Me.botonLimpiarFiltros.Name = "botonLimpiarFiltros"
        Me.botonLimpiarFiltros.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.botonLimpiarFiltros.Size = New System.Drawing.Size(100, 87)
        Me.botonLimpiarFiltros.TabIndex = 75
        Me.botonLimpiarFiltros.Text = "Limpiar Filtros"
        Me.botonLimpiarFiltros.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.botonLimpiarFiltros.UseVisualStyleBackColor = True
        '
        'ConsultaTotal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1212, 732)
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
        CType(Me.lblPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewReintegros, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents LineShape3 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
End Class
