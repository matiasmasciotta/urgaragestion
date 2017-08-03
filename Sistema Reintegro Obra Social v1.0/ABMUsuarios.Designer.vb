<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMUsuarios
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CANCELAR = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.opBuscarNombre = New System.Windows.Forms.RadioButton()
        Me.opBuscarDNI = New System.Windows.Forms.RadioButton()
        Me.botonModificaUsuario = New System.Windows.Forms.Button()
        Me.botonAgregaUsuario = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GridView = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.lblingreso = New System.Windows.Forms.Label()
        Me.botonSalir = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.lbldni = New System.Windows.Forms.Label()
        Me.lblapenom = New System.Windows.Forms.Label()
        Me.txtApellidoNombre = New System.Windows.Forms.TextBox()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.lblpass2 = New System.Windows.Forms.Label()
        Me.txtPass2 = New System.Windows.Forms.TextBox()
        Me.lblsecc = New System.Windows.Forms.Label()
        Me.lblrol = New System.Windows.Forms.Label()
        Me.comboSeccional = New System.Windows.Forms.ComboBox()
        Me.comboROL = New System.Windows.Forms.ComboBox()
        Me.DataGridSeccionales = New System.Windows.Forms.DataGridView()
        Me.DataGridRol = New System.Windows.Forms.DataGridView()
        Me.lblgridsec = New System.Windows.Forms.Label()
        Me.lblgridrol = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.botonConfirmaUser = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridSeccionales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridRol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.CANCELAR)
        Me.Panel2.Controls.Add(Me.OK)
        Me.Panel2.Controls.Add(Me.opBuscarNombre)
        Me.Panel2.Controls.Add(Me.opBuscarDNI)
        Me.Panel2.Controls.Add(Me.botonModificaUsuario)
        Me.Panel2.Controls.Add(Me.botonAgregaUsuario)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.GridView)
        Me.Panel2.Location = New System.Drawing.Point(69, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(681, 557)
        Me.Panel2.TabIndex = 6
        '
        'CANCELAR
        '
        Me.CANCELAR.BackColor = System.Drawing.Color.Chocolate
        Me.CANCELAR.Location = New System.Drawing.Point(286, 515)
        Me.CANCELAR.Name = "CANCELAR"
        Me.CANCELAR.Size = New System.Drawing.Size(105, 41)
        Me.CANCELAR.TabIndex = 9
        Me.CANCELAR.Text = "Cancelar"
        Me.CANCELAR.UseVisualStyleBackColor = False
        Me.CANCELAR.Visible = False
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.OK.Location = New System.Drawing.Point(175, 515)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(105, 40)
        Me.OK.TabIndex = 8
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = False
        Me.OK.Visible = False
        '
        'opBuscarNombre
        '
        Me.opBuscarNombre.AutoSize = True
        Me.opBuscarNombre.Location = New System.Drawing.Point(181, 9)
        Me.opBuscarNombre.Name = "opBuscarNombre"
        Me.opBuscarNombre.Size = New System.Drawing.Size(110, 17)
        Me.opBuscarNombre.TabIndex = 7
        Me.opBuscarNombre.TabStop = True
        Me.opBuscarNombre.Text = "Apellido y Nombre"
        Me.opBuscarNombre.UseVisualStyleBackColor = True
        '
        'opBuscarDNI
        '
        Me.opBuscarDNI.AutoSize = True
        Me.opBuscarDNI.Location = New System.Drawing.Point(79, 9)
        Me.opBuscarDNI.Name = "opBuscarDNI"
        Me.opBuscarDNI.Size = New System.Drawing.Size(75, 17)
        Me.opBuscarDNI.TabIndex = 6
        Me.opBuscarDNI.TabStop = True
        Me.opBuscarDNI.Text = "ID / D.N.I."
        Me.opBuscarDNI.UseVisualStyleBackColor = True
        '
        'botonModificaUsuario
        '
        Me.botonModificaUsuario.BackColor = System.Drawing.Color.LightSkyBlue
        Me.botonModificaUsuario.Location = New System.Drawing.Point(175, 485)
        Me.botonModificaUsuario.Name = "botonModificaUsuario"
        Me.botonModificaUsuario.Size = New System.Drawing.Size(216, 24)
        Me.botonModificaUsuario.TabIndex = 4
        Me.botonModificaUsuario.Text = "Modificar "
        Me.botonModificaUsuario.UseVisualStyleBackColor = False
        '
        'botonAgregaUsuario
        '
        Me.botonAgregaUsuario.BackColor = System.Drawing.Color.MediumTurquoise
        Me.botonAgregaUsuario.Location = New System.Drawing.Point(397, 486)
        Me.botonAgregaUsuario.Name = "botonAgregaUsuario"
        Me.botonAgregaUsuario.Size = New System.Drawing.Size(82, 70)
        Me.botonAgregaUsuario.TabIndex = 3
        Me.botonAgregaUsuario.Text = "Crear Nuevo Usuario"
        Me.botonAgregaUsuario.UseVisualStyleBackColor = False
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(11, 11)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(62, 13)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "Buscar Por:"
        '
        'GridView
        '
        Me.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.GridView.Location = New System.Drawing.Point(3, 35)
        Me.GridView.MultiSelect = False
        Me.GridView.Name = "GridView"
        Me.GridView.ReadOnly = True
        Me.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridView.Size = New System.Drawing.Size(649, 445)
        Me.GridView.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.txtBusqueda)
        Me.Panel1.Controls.Add(Me.lblingreso)
        Me.Panel1.Location = New System.Drawing.Point(67, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(383, 44)
        Me.Panel1.TabIndex = 5
        '
        'txtBusqueda
        '
        Me.txtBusqueda.BackColor = System.Drawing.SystemColors.Info
        Me.txtBusqueda.Location = New System.Drawing.Point(10, 16)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(370, 20)
        Me.txtBusqueda.TabIndex = 2
        '
        'lblingreso
        '
        Me.lblingreso.AutoSize = True
        Me.lblingreso.ForeColor = System.Drawing.SystemColors.Desktop
        Me.lblingreso.Location = New System.Drawing.Point(7, 0)
        Me.lblingreso.Name = "lblingreso"
        Me.lblingreso.Size = New System.Drawing.Size(128, 13)
        Me.lblingreso.TabIndex = 1
        Me.lblingreso.Text = "Ingrese el Texto a Buscar"
        '
        'botonSalir
        '
        Me.botonSalir.Location = New System.Drawing.Point(833, 480)
        Me.botonSalir.Name = "botonSalir"
        Me.botonSalir.Size = New System.Drawing.Size(96, 57)
        Me.botonSalir.TabIndex = 10
        Me.botonSalir.Text = "SALIR"
        Me.botonSalir.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(97, 23)
        Me.txtID.MaxLength = 8
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(113, 20)
        Me.txtID.TabIndex = 12
        Me.txtID.Visible = False
        '
        'lbldni
        '
        Me.lbldni.AutoSize = True
        Me.lbldni.Location = New System.Drawing.Point(2, 28)
        Me.lbldni.Name = "lbldni"
        Me.lbldni.Size = New System.Drawing.Size(42, 13)
        Me.lbldni.TabIndex = 10
        Me.lbldni.Text = "ID/DNI"
        Me.lbldni.Visible = False
        '
        'lblapenom
        '
        Me.lblapenom.AutoSize = True
        Me.lblapenom.Location = New System.Drawing.Point(2, 63)
        Me.lblapenom.Name = "lblapenom"
        Me.lblapenom.Size = New System.Drawing.Size(92, 13)
        Me.lblapenom.TabIndex = 13
        Me.lblapenom.Text = "Nombre y Apellido"
        Me.lblapenom.Visible = False
        '
        'txtApellidoNombre
        '
        Me.txtApellidoNombre.Location = New System.Drawing.Point(97, 58)
        Me.txtApellidoNombre.MaxLength = 30
        Me.txtApellidoNombre.Name = "txtApellidoNombre"
        Me.txtApellidoNombre.Size = New System.Drawing.Size(113, 20)
        Me.txtApellidoNombre.TabIndex = 14
        Me.txtApellidoNombre.Visible = False
        '
        'lblpass
        '
        Me.lblpass.AutoSize = True
        Me.lblpass.Location = New System.Drawing.Point(2, 100)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(61, 13)
        Me.lblpass.TabIndex = 15
        Me.lblpass.Text = "Contraseña"
        Me.lblpass.Visible = False
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(97, 95)
        Me.txtPass.MaxLength = 16
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(93, 20)
        Me.txtPass.TabIndex = 16
        Me.txtPass.Visible = False
        '
        'lblpass2
        '
        Me.lblpass2.AutoSize = True
        Me.lblpass2.Location = New System.Drawing.Point(2, 136)
        Me.lblpass2.Name = "lblpass2"
        Me.lblpass2.Size = New System.Drawing.Size(72, 13)
        Me.lblpass2.TabIndex = 17
        Me.lblpass2.Text = "Repita Contra"
        Me.lblpass2.Visible = False
        '
        'txtPass2
        '
        Me.txtPass2.Location = New System.Drawing.Point(97, 131)
        Me.txtPass2.MaxLength = 16
        Me.txtPass2.Name = "txtPass2"
        Me.txtPass2.Size = New System.Drawing.Size(93, 20)
        Me.txtPass2.TabIndex = 18
        Me.txtPass2.Visible = False
        '
        'lblsecc
        '
        Me.lblsecc.AutoSize = True
        Me.lblsecc.Location = New System.Drawing.Point(3, 171)
        Me.lblsecc.Name = "lblsecc"
        Me.lblsecc.Size = New System.Drawing.Size(54, 13)
        Me.lblsecc.TabIndex = 19
        Me.lblsecc.Text = "Seccional"
        Me.lblsecc.Visible = False
        '
        'lblrol
        '
        Me.lblrol.AutoSize = True
        Me.lblrol.Location = New System.Drawing.Point(3, 209)
        Me.lblrol.Name = "lblrol"
        Me.lblrol.Size = New System.Drawing.Size(77, 13)
        Me.lblrol.TabIndex = 21
        Me.lblrol.Text = "Rol de Usuario"
        Me.lblrol.Visible = False
        '
        'comboSeccional
        '
        Me.comboSeccional.BackColor = System.Drawing.SystemColors.Highlight
        Me.comboSeccional.Enabled = False
        Me.comboSeccional.FormattingEnabled = True
        Me.comboSeccional.Location = New System.Drawing.Point(96, 168)
        Me.comboSeccional.Name = "comboSeccional"
        Me.comboSeccional.Size = New System.Drawing.Size(77, 21)
        Me.comboSeccional.TabIndex = 22
        Me.comboSeccional.Visible = False
        '
        'comboROL
        '
        Me.comboROL.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.comboROL.Enabled = False
        Me.comboROL.FormattingEnabled = True
        Me.comboROL.Location = New System.Drawing.Point(96, 206)
        Me.comboROL.Name = "comboROL"
        Me.comboROL.Size = New System.Drawing.Size(77, 21)
        Me.comboROL.TabIndex = 23
        Me.comboROL.Visible = False
        '
        'DataGridSeccionales
        '
        Me.DataGridSeccionales.BackgroundColor = System.Drawing.SystemColors.Highlight
        Me.DataGridSeccionales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridSeccionales.Location = New System.Drawing.Point(993, 112)
        Me.DataGridSeccionales.MultiSelect = False
        Me.DataGridSeccionales.Name = "DataGridSeccionales"
        Me.DataGridSeccionales.ReadOnly = True
        Me.DataGridSeccionales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridSeccionales.Size = New System.Drawing.Size(269, 194)
        Me.DataGridSeccionales.TabIndex = 24
        Me.DataGridSeccionales.Visible = False
        '
        'DataGridRol
        '
        Me.DataGridRol.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.DataGridRol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridRol.Location = New System.Drawing.Point(993, 338)
        Me.DataGridRol.MultiSelect = False
        Me.DataGridRol.Name = "DataGridRol"
        Me.DataGridRol.ReadOnly = True
        Me.DataGridRol.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridRol.Size = New System.Drawing.Size(269, 199)
        Me.DataGridRol.TabIndex = 25
        Me.DataGridRol.Visible = False
        '
        'lblgridsec
        '
        Me.lblgridsec.AutoSize = True
        Me.lblgridsec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgridsec.Location = New System.Drawing.Point(989, 88)
        Me.lblgridsec.Name = "lblgridsec"
        Me.lblgridsec.Size = New System.Drawing.Size(273, 16)
        Me.lblgridsec.TabIndex = 26
        Me.lblgridsec.Text = "Seleccione La Seccional a la que Pertenece"
        Me.lblgridsec.Visible = False
        '
        'lblgridrol
        '
        Me.lblgridrol.AutoSize = True
        Me.lblgridrol.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgridrol.Location = New System.Drawing.Point(990, 319)
        Me.lblgridrol.Name = "lblgridrol"
        Me.lblgridrol.Size = New System.Drawing.Size(169, 16)
        Me.lblgridrol.TabIndex = 27
        Me.lblgridrol.Text = "Seleccione Rol de Usuario"
        Me.lblgridrol.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.comboROL)
        Me.GroupBox1.Controls.Add(Me.comboSeccional)
        Me.GroupBox1.Controls.Add(Me.lblrol)
        Me.GroupBox1.Controls.Add(Me.lblsecc)
        Me.GroupBox1.Controls.Add(Me.lblpass2)
        Me.GroupBox1.Controls.Add(Me.txtPass2)
        Me.GroupBox1.Controls.Add(Me.lblpass)
        Me.GroupBox1.Controls.Add(Me.txtPass)
        Me.GroupBox1.Controls.Add(Me.lblapenom)
        Me.GroupBox1.Controls.Add(Me.txtApellidoNombre)
        Me.GroupBox1.Controls.Add(Me.lbldni)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Location = New System.Drawing.Point(756, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(225, 254)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos User"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(196, 108)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 23)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'botonConfirmaUser
        '
        Me.botonConfirmaUser.Image = Global.WindowsApplication1.My.Resources.Resources.descarga
        Me.botonConfirmaUser.Location = New System.Drawing.Point(833, 374)
        Me.botonConfirmaUser.Name = "botonConfirmaUser"
        Me.botonConfirmaUser.Size = New System.Drawing.Size(96, 74)
        Me.botonConfirmaUser.TabIndex = 29
        Me.botonConfirmaUser.Text = "CONFIRMAR!"
        Me.botonConfirmaUser.UseVisualStyleBackColor = True
        Me.botonConfirmaUser.Visible = False
        '
        'ABMUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(1312, 634)
        Me.Controls.Add(Me.botonConfirmaUser)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblgridrol)
        Me.Controls.Add(Me.lblgridsec)
        Me.Controls.Add(Me.DataGridRol)
        Me.Controls.Add(Me.DataGridSeccionales)
        Me.Controls.Add(Me.botonSalir)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ABMUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM Usuarios"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridSeccionales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridRol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents CANCELAR As System.Windows.Forms.Button
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents opBuscarNombre As System.Windows.Forms.RadioButton
    Friend WithEvents opBuscarDNI As System.Windows.Forms.RadioButton
    Friend WithEvents botonModificaUsuario As System.Windows.Forms.Button
    Friend WithEvents botonAgregaUsuario As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GridView As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents lblingreso As System.Windows.Forms.Label
    Friend WithEvents botonSalir As System.Windows.Forms.Button
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents lbldni As System.Windows.Forms.Label
    Friend WithEvents lblapenom As System.Windows.Forms.Label
    Friend WithEvents txtApellidoNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblpass As System.Windows.Forms.Label
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents lblpass2 As System.Windows.Forms.Label
    Friend WithEvents txtPass2 As System.Windows.Forms.TextBox
    Friend WithEvents lblsecc As System.Windows.Forms.Label
    Friend WithEvents lblrol As System.Windows.Forms.Label
    Friend WithEvents comboSeccional As System.Windows.Forms.ComboBox
    Friend WithEvents comboROL As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridSeccionales As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridRol As System.Windows.Forms.DataGridView
    Friend WithEvents lblgridsec As System.Windows.Forms.Label
    Friend WithEvents lblgridrol As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents botonConfirmaUser As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
