<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoReintegro
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCuilPago = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtSubsidio = New System.Windows.Forms.TextBox()
        Me.opSubsidio = New System.Windows.Forms.RadioButton()
        Me.opReintegro = New System.Windows.Forms.RadioButton()
        Me.txtAlias = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCBU = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblitem = New System.Windows.Forms.Label()
        Me.lblcontadoritems = New System.Windows.Forms.Label()
        Me.botonQuitarImagen = New System.Windows.Forms.Button()
        Me.lblPicture = New System.Windows.Forms.PictureBox()
        Me.clbimagen = New System.Windows.Forms.CheckedListBox()
        Me.botonImagen = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtObservacionesCarga = New System.Windows.Forms.TextBox()
        Me.txtFechaSolicitud = New System.Windows.Forms.TextBox()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.GridViewSubsidios = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.opBuscarNombre = New System.Windows.Forms.RadioButton()
        Me.opBuscarDNI = New System.Windows.Forms.RadioButton()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GridView = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.lblingreso = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCUIL = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtBeneficiario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtApellidoNombre = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.comboSexo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.comboTipoBeneficiario = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblNumeroReintegro = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtTipoCuenta = New System.Windows.Forms.ComboBox()
        Me.Panel5.SuspendLayout()
        CType(Me.lblPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewSubsidios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(658, 272)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(246, 12)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Datos Para la Solicitud del Nuevo Reintegro"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.txtTipoCuenta)
        Me.Panel5.Controls.Add(Me.Label17)
        Me.Panel5.Controls.Add(Me.txtCuilPago)
        Me.Panel5.Controls.Add(Me.Label19)
        Me.Panel5.Controls.Add(Me.txtSubsidio)
        Me.Panel5.Controls.Add(Me.opSubsidio)
        Me.Panel5.Controls.Add(Me.opReintegro)
        Me.Panel5.Controls.Add(Me.txtAlias)
        Me.Panel5.Controls.Add(Me.Label16)
        Me.Panel5.Controls.Add(Me.txtCBU)
        Me.Panel5.Controls.Add(Me.Label15)
        Me.Panel5.Controls.Add(Me.Label7)
        Me.Panel5.Controls.Add(Me.lblitem)
        Me.Panel5.Controls.Add(Me.lblcontadoritems)
        Me.Panel5.Controls.Add(Me.botonQuitarImagen)
        Me.Panel5.Controls.Add(Me.lblPicture)
        Me.Panel5.Controls.Add(Me.clbimagen)
        Me.Panel5.Controls.Add(Me.botonImagen)
        Me.Panel5.Controls.Add(Me.DateTimePicker1)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.txtObservacionesCarga)
        Me.Panel5.Controls.Add(Me.txtFechaSolicitud)
        Me.Panel5.Controls.Add(Me.txtImporte)
        Me.Panel5.Controls.Add(Me.txtDetalle)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.Label11)
        Me.Panel5.Controls.Add(Me.ShapeContainer1)
        Me.Panel5.Location = New System.Drawing.Point(483, 287)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(709, 362)
        Me.Panel5.TabIndex = 24
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(284, 136)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 12)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "Tipo Cuenta:"
        '
        'txtCuilPago
        '
        Me.txtCuilPago.Enabled = False
        Me.txtCuilPago.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuilPago.Location = New System.Drawing.Point(115, 134)
        Me.txtCuilPago.MaxLength = 13
        Me.txtCuilPago.Name = "txtCuilPago"
        Me.txtCuilPago.Size = New System.Drawing.Size(163, 20)
        Me.txtCuilPago.TabIndex = 8
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(16, 137)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(97, 12)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "CUIL Tit. Cuenta:"
        '
        'txtSubsidio
        '
        Me.txtSubsidio.Location = New System.Drawing.Point(212, 45)
        Me.txtSubsidio.Name = "txtSubsidio"
        Me.txtSubsidio.ReadOnly = True
        Me.txtSubsidio.Size = New System.Drawing.Size(100, 20)
        Me.txtSubsidio.TabIndex = 24
        '
        'opSubsidio
        '
        Me.opSubsidio.AutoSize = True
        Me.opSubsidio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opSubsidio.Location = New System.Drawing.Point(141, 46)
        Me.opSubsidio.Name = "opSubsidio"
        Me.opSubsidio.Size = New System.Drawing.Size(70, 16)
        Me.opSubsidio.TabIndex = 23
        Me.opSubsidio.TabStop = True
        Me.opSubsidio.Text = "Subsidio"
        Me.opSubsidio.UseVisualStyleBackColor = True
        '
        'opReintegro
        '
        Me.opReintegro.AutoSize = True
        Me.opReintegro.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opReintegro.Location = New System.Drawing.Point(59, 46)
        Me.opReintegro.Name = "opReintegro"
        Me.opReintegro.Size = New System.Drawing.Size(78, 16)
        Me.opReintegro.TabIndex = 22
        Me.opReintegro.TabStop = True
        Me.opReintegro.Text = "Reintegro"
        Me.opReintegro.UseVisualStyleBackColor = True
        '
        'txtAlias
        '
        Me.txtAlias.Enabled = False
        Me.txtAlias.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlias.Location = New System.Drawing.Point(365, 108)
        Me.txtAlias.MaxLength = 60
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Size = New System.Drawing.Size(208, 20)
        Me.txtAlias.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(318, 111)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 12)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "ALIAS:"
        '
        'txtCBU
        '
        Me.txtCBU.Enabled = False
        Me.txtCBU.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCBU.Location = New System.Drawing.Point(59, 108)
        Me.txtCBU.MaxLength = 22
        Me.txtCBU.Name = "txtCBU"
        Me.txtCBU.Size = New System.Drawing.Size(219, 20)
        Me.txtCBU.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(16, 111)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(32, 12)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "CBU:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(525, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(115, 12)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Vista Previa Imagen"
        '
        'lblitem
        '
        Me.lblitem.AutoSize = True
        Me.lblitem.Location = New System.Drawing.Point(610, 344)
        Me.lblitem.Name = "lblitem"
        Me.lblitem.Size = New System.Drawing.Size(39, 13)
        Me.lblitem.TabIndex = 16
        Me.lblitem.Text = "Label7"
        Me.lblitem.Visible = False
        '
        'lblcontadoritems
        '
        Me.lblcontadoritems.AutoSize = True
        Me.lblcontadoritems.Location = New System.Drawing.Point(570, 344)
        Me.lblcontadoritems.Name = "lblcontadoritems"
        Me.lblcontadoritems.Size = New System.Drawing.Size(39, 13)
        Me.lblcontadoritems.TabIndex = 15
        Me.lblcontadoritems.Text = "Label7"
        Me.lblcontadoritems.Visible = False
        '
        'botonQuitarImagen
        '
        Me.botonQuitarImagen.BackColor = System.Drawing.Color.Salmon
        Me.botonQuitarImagen.Location = New System.Drawing.Point(53, 234)
        Me.botonQuitarImagen.Name = "botonQuitarImagen"
        Me.botonQuitarImagen.Size = New System.Drawing.Size(87, 25)
        Me.botonQuitarImagen.TabIndex = 14
        Me.botonQuitarImagen.Text = "- Quitar"
        Me.botonQuitarImagen.UseVisualStyleBackColor = False
        '
        'lblPicture
        '
        Me.lblPicture.Location = New System.Drawing.Point(509, 193)
        Me.lblPicture.Name = "lblPicture"
        Me.lblPicture.Size = New System.Drawing.Size(140, 120)
        Me.lblPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lblPicture.TabIndex = 13
        Me.lblPicture.TabStop = False
        '
        'clbimagen
        '
        Me.clbimagen.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbimagen.FormattingEnabled = True
        Me.clbimagen.Location = New System.Drawing.Point(161, 178)
        Me.clbimagen.Name = "clbimagen"
        Me.clbimagen.Size = New System.Drawing.Size(308, 124)
        Me.clbimagen.TabIndex = 12
        '
        'botonImagen
        '
        Me.botonImagen.BackColor = System.Drawing.Color.LightGreen
        Me.botonImagen.Location = New System.Drawing.Point(53, 197)
        Me.botonImagen.Name = "botonImagen"
        Me.botonImagen.Size = New System.Drawing.Size(87, 31)
        Me.botonImagen.TabIndex = 10
        Me.botonImagen.Text = "+Subir Imagen"
        Me.botonImagen.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(460, 80)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(244, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 327)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 12)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Observaciones"
        '
        'txtObservacionesCarga
        '
        Me.txtObservacionesCarga.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacionesCarga.Location = New System.Drawing.Point(110, 324)
        Me.txtObservacionesCarga.MaxLength = 100
        Me.txtObservacionesCarga.Name = "txtObservacionesCarga"
        Me.txtObservacionesCarga.Size = New System.Drawing.Size(424, 20)
        Me.txtObservacionesCarga.TabIndex = 11
        '
        'txtFechaSolicitud
        '
        Me.txtFechaSolicitud.Enabled = False
        Me.txtFechaSolicitud.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaSolicitud.Location = New System.Drawing.Point(573, 59)
        Me.txtFechaSolicitud.Name = "txtFechaSolicitud"
        Me.txtFechaSolicitud.Size = New System.Drawing.Size(131, 20)
        Me.txtFechaSolicitud.TabIndex = 5
        '
        'txtImporte
        '
        Me.txtImporte.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.Location = New System.Drawing.Point(573, 38)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(131, 20)
        Me.txtImporte.TabIndex = 4
        '
        'txtDetalle
        '
        Me.txtDetalle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalle.Location = New System.Drawing.Point(3, 17)
        Me.txtDetalle.MaxLength = 100
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(701, 20)
        Me.txtDetalle.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(456, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 12)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Fecha de Solicitud:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(516, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 12)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Importe:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 12)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Detalle:"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(707, 360)
        Me.ShapeContainer1.TabIndex = 25
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(33, 165)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(444, 147)
        '
        'GridViewSubsidios
        '
        Me.GridViewSubsidios.BackgroundColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridViewSubsidios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.GridViewSubsidios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridViewSubsidios.DefaultCellStyle = DataGridViewCellStyle10
        Me.GridViewSubsidios.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.GridViewSubsidios.Location = New System.Drawing.Point(665, 237)
        Me.GridViewSubsidios.MultiSelect = False
        Me.GridViewSubsidios.Name = "GridViewSubsidios"
        Me.GridViewSubsidios.ReadOnly = True
        Me.GridViewSubsidios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridViewSubsidios.Size = New System.Drawing.Size(311, 92)
        Me.GridViewSubsidios.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.opBuscarNombre)
        Me.Panel2.Controls.Add(Me.opBuscarDNI)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.GridView)
        Me.Panel2.Location = New System.Drawing.Point(12, 66)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(469, 583)
        Me.Panel2.TabIndex = 26
        '
        'opBuscarNombre
        '
        Me.opBuscarNombre.AutoSize = True
        Me.opBuscarNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opBuscarNombre.Location = New System.Drawing.Point(199, 5)
        Me.opBuscarNombre.Name = "opBuscarNombre"
        Me.opBuscarNombre.Size = New System.Drawing.Size(138, 20)
        Me.opBuscarNombre.TabIndex = 7
        Me.opBuscarNombre.TabStop = True
        Me.opBuscarNombre.Text = "Apellido y Nombre"
        Me.opBuscarNombre.UseVisualStyleBackColor = True
        '
        'opBuscarDNI
        '
        Me.opBuscarDNI.AutoSize = True
        Me.opBuscarDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opBuscarDNI.Location = New System.Drawing.Point(102, 5)
        Me.opBuscarDNI.Name = "opBuscarDNI"
        Me.opBuscarDNI.Size = New System.Drawing.Size(91, 20)
        Me.opBuscarDNI.TabIndex = 6
        Me.opBuscarDNI.TabStop = True
        Me.opBuscarDNI.Text = "CUIL/D.N.I."
        Me.opBuscarDNI.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(5, 7)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(77, 16)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Buscar Por:"
        '
        'GridView
        '
        Me.GridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridView.DefaultCellStyle = DataGridViewCellStyle12
        Me.GridView.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.GridView.Location = New System.Drawing.Point(3, 35)
        Me.GridView.MultiSelect = False
        Me.GridView.Name = "GridView"
        Me.GridView.ReadOnly = True
        Me.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridView.Size = New System.Drawing.Size(461, 543)
        Me.GridView.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtBusqueda)
        Me.Panel1.Controls.Add(Me.lblingreso)
        Me.Panel1.Location = New System.Drawing.Point(10, 11)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(461, 44)
        Me.Panel1.TabIndex = 25
        '
        'txtBusqueda
        '
        Me.txtBusqueda.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.txtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(3, 16)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(453, 22)
        Me.txtBusqueda.TabIndex = 2
        '
        'lblingreso
        '
        Me.lblingreso.AutoSize = True
        Me.lblingreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblingreso.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblingreso.Location = New System.Drawing.Point(6, 0)
        Me.lblingreso.Name = "lblingreso"
        Me.lblingreso.Size = New System.Drawing.Size(123, 15)
        Me.lblingreso.TabIndex = 1
        Me.lblingreso.Text = "Beneficiario a Buscar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(517, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Código Beneficiario"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(858, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "CUIL:"
        '
        'txtCUIL
        '
        Me.txtCUIL.Location = New System.Drawing.Point(897, 30)
        Me.txtCUIL.Name = "txtCUIL"
        Me.txtCUIL.Size = New System.Drawing.Size(131, 20)
        Me.txtCUIL.TabIndex = 31
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtBeneficiario)
        Me.Panel3.Location = New System.Drawing.Point(496, 11)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(143, 44)
        Me.Panel3.TabIndex = 27
        '
        'txtBeneficiario
        '
        Me.txtBeneficiario.BackColor = System.Drawing.SystemColors.Info
        Me.txtBeneficiario.Location = New System.Drawing.Point(4, 16)
        Me.txtBeneficiario.Name = "txtBeneficiario"
        Me.txtBeneficiario.Size = New System.Drawing.Size(134, 20)
        Me.txtBeneficiario.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(691, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 15)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Datos Beneficiario"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txtApellidoNombre)
        Me.Panel4.Controls.Add(Me.Label14)
        Me.Panel4.Controls.Add(Me.txtCelular)
        Me.Panel4.Controls.Add(Me.Label22)
        Me.Panel4.Controls.Add(Me.txtMail)
        Me.Panel4.Controls.Add(Me.txtTelefono)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.comboSexo)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.comboTipoBeneficiario)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(487, 100)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(550, 164)
        Me.Panel4.TabIndex = 33
        '
        'txtApellidoNombre
        '
        Me.txtApellidoNombre.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.txtApellidoNombre.Enabled = False
        Me.txtApellidoNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidoNombre.ForeColor = System.Drawing.Color.MediumBlue
        Me.txtApellidoNombre.Location = New System.Drawing.Point(137, 20)
        Me.txtApellidoNombre.Name = "txtApellidoNombre"
        Me.txtApellidoNombre.Size = New System.Drawing.Size(337, 22)
        Me.txtApellidoNombre.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Enabled = False
        Me.Label14.Location = New System.Drawing.Point(36, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(95, 13)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "Apellido y Nombre:"
        '
        'txtCelular
        '
        Me.txtCelular.Enabled = False
        Me.txtCelular.Location = New System.Drawing.Point(347, 114)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(119, 20)
        Me.txtCelular.TabIndex = 25
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Enabled = False
        Me.Label22.Location = New System.Drawing.Point(302, 117)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(42, 13)
        Me.Label22.TabIndex = 24
        Me.Label22.Text = "Celular:"
        '
        'txtMail
        '
        Me.txtMail.Enabled = False
        Me.txtMail.Location = New System.Drawing.Point(137, 88)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(190, 20)
        Me.txtMail.TabIndex = 17
        '
        'txtTelefono
        '
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Location = New System.Drawing.Point(137, 114)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(112, 20)
        Me.txtTelefono.TabIndex = 16
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Location = New System.Drawing.Point(102, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Mail:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.Location = New System.Drawing.Point(79, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Telefono:"
        '
        'comboSexo
        '
        Me.comboSexo.Enabled = False
        Me.comboSexo.FormattingEnabled = True
        Me.comboSexo.Location = New System.Drawing.Point(347, 61)
        Me.comboSexo.Name = "comboSexo"
        Me.comboSexo.Size = New System.Drawing.Size(119, 21)
        Me.comboSexo.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Location = New System.Drawing.Point(309, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Sexo:"
        '
        'comboTipoBeneficiario
        '
        Me.comboTipoBeneficiario.Enabled = False
        Me.comboTipoBeneficiario.FormattingEnabled = True
        Me.comboTipoBeneficiario.Location = New System.Drawing.Point(137, 61)
        Me.comboTipoBeneficiario.Name = "comboTipoBeneficiario"
        Me.comboTipoBeneficiario.Size = New System.Drawing.Size(157, 21)
        Me.comboTipoBeneficiario.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Location = New System.Drawing.Point(27, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tipo de Beneficiario:"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(835, 659)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(161, 29)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblNumeroReintegro
        '
        Me.lblNumeroReintegro.AutoSize = True
        Me.lblNumeroReintegro.Font = New System.Drawing.Font("Arial Rounded MT Bold", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroReintegro.ForeColor = System.Drawing.Color.Maroon
        Me.lblNumeroReintegro.Location = New System.Drawing.Point(494, 269)
        Me.lblNumeroReintegro.Name = "lblNumeroReintegro"
        Me.lblNumeroReintegro.Size = New System.Drawing.Size(59, 12)
        Me.lblNumeroReintegro.TabIndex = 36
        Me.lblNumeroReintegro.Text = "Solicitud: "
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(535, 659)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(144, 31)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Generar Solicitud!"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(-1, 705)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(1206, 11)
        Me.ProgressBar1.TabIndex = 37
        '
        'txtTipoCuenta
        '
        Me.txtTipoCuenta.FormattingEnabled = True
        Me.txtTipoCuenta.Location = New System.Drawing.Point(365, 133)
        Me.txtTipoCuenta.Name = "txtTipoCuenta"
        Me.txtTipoCuenta.Size = New System.Drawing.Size(208, 21)
        Me.txtTipoCuenta.TabIndex = 30
        '
        'NuevoReintegro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1204, 718)
        Me.Controls.Add(Me.GridViewSubsidios)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.lblNumeroReintegro)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCUIL)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Label10)
        Me.KeyPreview = True
        Me.Name = "NuevoReintegro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "+ Nuevo Reintegro"
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.lblPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewSubsidios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtFechaSolicitud As System.Windows.Forms.TextBox
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents txtDetalle As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents opBuscarNombre As System.Windows.Forms.RadioButton
    Friend WithEvents opBuscarDNI As System.Windows.Forms.RadioButton
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GridView As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents lblingreso As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCUIL As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtBeneficiario As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents comboSexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents comboTipoBeneficiario As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtApellidoNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lblNumeroReintegro As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtObservacionesCarga As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents botonImagen As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents clbimagen As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblPicture As System.Windows.Forms.PictureBox
    Friend WithEvents botonQuitarImagen As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents lblcontadoritems As System.Windows.Forms.Label
    Friend WithEvents lblitem As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAlias As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCBU As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents opSubsidio As System.Windows.Forms.RadioButton
    Friend WithEvents opReintegro As System.Windows.Forms.RadioButton
    Friend WithEvents GridViewSubsidios As System.Windows.Forms.DataGridView
    Friend WithEvents txtSubsidio As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCuilPago As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents txtTipoCuenta As System.Windows.Forms.ComboBox
End Class
