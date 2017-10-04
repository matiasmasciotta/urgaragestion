<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioABM
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
        Me.GridView = New System.Windows.Forms.DataGridView()
        Me.lblingreso = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CANCELAR = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.opBuscarNombre = New System.Windows.Forms.RadioButton()
        Me.opBuscarDNI = New System.Windows.Forms.RadioButton()
        Me.botonModificarBeneficiario = New System.Windows.Forms.Button()
        Me.botonAgregarBeneficiario = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtBeneficiario = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtApellidoNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtProvincia = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtLocalidad = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtCelular = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtPiso = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtPuerta = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCalle = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.comboSexo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.comboTipoBeneficiario = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCUIL = New System.Windows.Forms.TextBox()
        Me.botonConfirmarAlta = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridView
        '
        Me.GridView.AllowUserToAddRows = False
        Me.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.GridView.Location = New System.Drawing.Point(3, 35)
        Me.GridView.MultiSelect = False
        Me.GridView.Name = "GridView"
        Me.GridView.ReadOnly = True
        Me.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridView.Size = New System.Drawing.Size(517, 445)
        Me.GridView.TabIndex = 0
        '
        'lblingreso
        '
        Me.lblingreso.AutoSize = True
        Me.lblingreso.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblingreso.Location = New System.Drawing.Point(7, 0)
        Me.lblingreso.Name = "lblingreso"
        Me.lblingreso.Size = New System.Drawing.Size(128, 13)
        Me.lblingreso.TabIndex = 1
        Me.lblingreso.Text = "Ingrese el Texto a Buscar"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.BackColor = System.Drawing.SystemColors.Info
        Me.txtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(10, 16)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(390, 22)
        Me.txtBusqueda.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtBusqueda)
        Me.Panel1.Controls.Add(Me.lblingreso)
        Me.Panel1.Location = New System.Drawing.Point(3, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(405, 44)
        Me.Panel1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.CANCELAR)
        Me.Panel2.Controls.Add(Me.OK)
        Me.Panel2.Controls.Add(Me.opBuscarNombre)
        Me.Panel2.Controls.Add(Me.opBuscarDNI)
        Me.Panel2.Controls.Add(Me.botonModificarBeneficiario)
        Me.Panel2.Controls.Add(Me.botonAgregarBeneficiario)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.GridView)
        Me.Panel2.Location = New System.Drawing.Point(5, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(525, 573)
        Me.Panel2.TabIndex = 4
        '
        'CANCELAR
        '
        Me.CANCELAR.BackColor = System.Drawing.Color.Chocolate
        Me.CANCELAR.Location = New System.Drawing.Point(397, 516)
        Me.CANCELAR.Name = "CANCELAR"
        Me.CANCELAR.Size = New System.Drawing.Size(123, 38)
        Me.CANCELAR.TabIndex = 9
        Me.CANCELAR.Text = "Cancelar"
        Me.CANCELAR.UseVisualStyleBackColor = False
        Me.CANCELAR.Visible = False
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.OK.Location = New System.Drawing.Point(275, 516)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(123, 38)
        Me.OK.TabIndex = 8
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = False
        Me.OK.Visible = False
        '
        'opBuscarNombre
        '
        Me.opBuscarNombre.AutoSize = True
        Me.opBuscarNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opBuscarNombre.Location = New System.Drawing.Point(181, 9)
        Me.opBuscarNombre.Name = "opBuscarNombre"
        Me.opBuscarNombre.Size = New System.Drawing.Size(125, 19)
        Me.opBuscarNombre.TabIndex = 7
        Me.opBuscarNombre.TabStop = True
        Me.opBuscarNombre.Text = "Apellido y Nombre"
        Me.opBuscarNombre.UseVisualStyleBackColor = True
        '
        'opBuscarDNI
        '
        Me.opBuscarDNI.AutoSize = True
        Me.opBuscarDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opBuscarDNI.Location = New System.Drawing.Point(80, 9)
        Me.opBuscarDNI.Name = "opBuscarDNI"
        Me.opBuscarDNI.Size = New System.Drawing.Size(85, 19)
        Me.opBuscarDNI.TabIndex = 6
        Me.opBuscarDNI.TabStop = True
        Me.opBuscarDNI.Text = "CUIL/D.N.I."
        Me.opBuscarDNI.UseVisualStyleBackColor = True
        '
        'botonModificarBeneficiario
        '
        Me.botonModificarBeneficiario.BackColor = System.Drawing.Color.LightSkyBlue
        Me.botonModificarBeneficiario.Location = New System.Drawing.Point(181, 486)
        Me.botonModificarBeneficiario.Name = "botonModificarBeneficiario"
        Me.botonModificarBeneficiario.Size = New System.Drawing.Size(339, 24)
        Me.botonModificarBeneficiario.TabIndex = 4
        Me.botonModificarBeneficiario.Text = "Modificar "
        Me.botonModificarBeneficiario.UseVisualStyleBackColor = False
        '
        'botonAgregarBeneficiario
        '
        Me.botonAgregarBeneficiario.BackColor = System.Drawing.Color.MediumTurquoise
        Me.botonAgregarBeneficiario.Location = New System.Drawing.Point(3, 486)
        Me.botonAgregarBeneficiario.Name = "botonAgregarBeneficiario"
        Me.botonAgregarBeneficiario.Size = New System.Drawing.Size(181, 24)
        Me.botonAgregarBeneficiario.TabIndex = 3
        Me.botonAgregarBeneficiario.Text = "Agregar Beneficiario"
        Me.botonAgregarBeneficiario.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(11, 11)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(70, 15)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Buscar Por:"
        '
        'txtBeneficiario
        '
        Me.txtBeneficiario.BackColor = System.Drawing.SystemColors.Info
        Me.txtBeneficiario.Location = New System.Drawing.Point(3, 16)
        Me.txtBeneficiario.Name = "txtBeneficiario"
        Me.txtBeneficiario.ReadOnly = True
        Me.txtBeneficiario.Size = New System.Drawing.Size(134, 20)
        Me.txtBeneficiario.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtBeneficiario)
        Me.Panel3.Location = New System.Drawing.Point(549, 11)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(143, 44)
        Me.Panel3.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(571, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Código Beneficiario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Apellido y Nombre:"
        '
        'txtApellidoNombre
        '
        Me.txtApellidoNombre.Location = New System.Drawing.Point(134, 14)
        Me.txtApellidoNombre.Name = "txtApellidoNombre"
        Me.txtApellidoNombre.ReadOnly = True
        Me.txtApellidoNombre.Size = New System.Drawing.Size(233, 20)
        Me.txtApellidoNombre.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(555, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Datos Afiliado"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txtProvincia)
        Me.Panel4.Controls.Add(Me.Label24)
        Me.Panel4.Controls.Add(Me.txtLocalidad)
        Me.Panel4.Controls.Add(Me.Label23)
        Me.Panel4.Controls.Add(Me.txtCelular)
        Me.Panel4.Controls.Add(Me.Label22)
        Me.Panel4.Controls.Add(Me.txtCP)
        Me.Panel4.Controls.Add(Me.Label21)
        Me.Panel4.Controls.Add(Me.txtPiso)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.txtPuerta)
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Controls.Add(Me.txtMail)
        Me.Panel4.Controls.Add(Me.txtTelefono)
        Me.Panel4.Controls.Add(Me.txtCalle)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.comboSexo)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.comboTipoBeneficiario)
        Me.Panel4.Controls.Add(Me.txtApellidoNombre)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Location = New System.Drawing.Point(549, 78)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(480, 355)
        Me.Panel4.TabIndex = 10
        '
        'txtProvincia
        '
        Me.txtProvincia.Location = New System.Drawing.Point(134, 224)
        Me.txtProvincia.Name = "txtProvincia"
        Me.txtProvincia.Size = New System.Drawing.Size(112, 20)
        Me.txtProvincia.TabIndex = 29
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(72, 227)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(60, 15)
        Me.Label24.TabIndex = 28
        Me.Label24.Text = "Provincia:"
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Location = New System.Drawing.Point(134, 198)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(109, 20)
        Me.txtLocalidad.TabIndex = 27
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(71, 201)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(64, 15)
        Me.Label23.TabIndex = 26
        Me.Label23.Text = "Localidad:"
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(134, 250)
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(109, 20)
        Me.txtCelular.TabIndex = 25
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(85, 253)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(49, 15)
        Me.Label22.TabIndex = 24
        Me.Label22.Text = "Celular:"
        '
        'txtCP
        '
        Me.txtCP.Location = New System.Drawing.Point(134, 172)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(54, 20)
        Me.txtCP.TabIndex = 23
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(101, 174)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(32, 15)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "C.P.:"
        '
        'txtPiso
        '
        Me.txtPiso.Location = New System.Drawing.Point(134, 146)
        Me.txtPiso.Name = "txtPiso"
        Me.txtPiso.Size = New System.Drawing.Size(45, 20)
        Me.txtPiso.TabIndex = 21
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(98, 148)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(34, 15)
        Me.Label20.TabIndex = 20
        Me.Label20.Text = "Piso:"
        '
        'txtPuerta
        '
        Me.txtPuerta.Location = New System.Drawing.Point(134, 120)
        Me.txtPuerta.Name = "txtPuerta"
        Me.txtPuerta.Size = New System.Drawing.Size(47, 20)
        Me.txtPuerta.TabIndex = 19
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(85, 121)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(46, 15)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "Puerta:"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(134, 307)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(190, 20)
        Me.txtMail.TabIndex = 17
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(134, 278)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(112, 20)
        Me.txtTelefono.TabIndex = 16
        '
        'txtCalle
        '
        Me.txtCalle.Location = New System.Drawing.Point(134, 94)
        Me.txtCalle.Name = "txtCalle"
        Me.txtCalle.Size = New System.Drawing.Size(190, 20)
        Me.txtCalle.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(98, 310)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Mail:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(76, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Telefono:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(93, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Calle:"
        '
        'comboSexo
        '
        Me.comboSexo.FormattingEnabled = True
        Me.comboSexo.Location = New System.Drawing.Point(134, 67)
        Me.comboSexo.Name = "comboSexo"
        Me.comboSexo.Size = New System.Drawing.Size(119, 21)
        Me.comboSexo.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(92, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Sexo:"
        '
        'comboTipoBeneficiario
        '
        Me.comboTipoBeneficiario.FormattingEnabled = True
        Me.comboTipoBeneficiario.Location = New System.Drawing.Point(134, 40)
        Me.comboTipoBeneficiario.Name = "comboTipoBeneficiario"
        Me.comboTipoBeneficiario.Size = New System.Drawing.Size(157, 21)
        Me.comboTipoBeneficiario.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tipo de Beneficiario:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(786, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "CUIL:"
        '
        'txtCUIL
        '
        Me.txtCUIL.Location = New System.Drawing.Point(12, 15)
        Me.txtCUIL.Name = "txtCUIL"
        Me.txtCUIL.ReadOnly = True
        Me.txtCUIL.Size = New System.Drawing.Size(112, 20)
        Me.txtCUIL.TabIndex = 11
        '
        'botonConfirmarAlta
        '
        Me.botonConfirmarAlta.Location = New System.Drawing.Point(618, 498)
        Me.botonConfirmarAlta.Name = "botonConfirmarAlta"
        Me.botonConfirmarAlta.Size = New System.Drawing.Size(143, 48)
        Me.botonConfirmarAlta.TabIndex = 14
        Me.botonConfirmarAlta.Text = "Aceptar"
        Me.botonConfirmarAlta.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(789, 498)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 48)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtCUIL)
        Me.Panel5.Location = New System.Drawing.Point(740, 13)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(136, 41)
        Me.Panel5.TabIndex = 17
        '
        'FormularioABM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(1077, 664)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.botonConfirmarAlta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Name = "FormularioABM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Beneficiarios"
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridView As System.Windows.Forms.DataGridView
    Friend WithEvents lblingreso As System.Windows.Forms.Label
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtBeneficiario As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtApellidoNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCUIL As System.Windows.Forms.TextBox
    Friend WithEvents comboTipoBeneficiario As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCalle As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents comboSexo As System.Windows.Forms.ComboBox
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents botonModificarBeneficiario As System.Windows.Forms.Button
    Friend WithEvents botonAgregarBeneficiario As System.Windows.Forms.Button
    Friend WithEvents botonConfirmarAlta As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents opBuscarNombre As System.Windows.Forms.RadioButton
    Friend WithEvents opBuscarDNI As System.Windows.Forms.RadioButton
    Friend WithEvents txtCelular As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtCP As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtPiso As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtPuerta As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtProvincia As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CANCELAR As System.Windows.Forms.Button
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
End Class
