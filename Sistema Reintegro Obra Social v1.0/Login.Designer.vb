<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BotonCancelar = New System.Windows.Forms.Button()
        Me.TempUser = New System.Windows.Forms.TextBox()
        Me.TempPass = New System.Windows.Forms.TextBox()
        Me.GridView = New System.Windows.Forms.DataGridView()
        Me.txtTipoUsuario = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BotonAceptar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(219, 61)
        Me.txtUser.MaxLength = 8
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(149, 20)
        Me.txtUser.TabIndex = 0
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(219, 97)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.Size = New System.Drawing.Size(149, 20)
        Me.txtPass.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.MediumOrchid
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(142, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuario (DNI)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.MediumOrchid
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(152, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Contraseña"
        '
        'BotonCancelar
        '
        Me.BotonCancelar.AutoEllipsis = True
        Me.BotonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BotonCancelar.Location = New System.Drawing.Point(267, 137)
        Me.BotonCancelar.Name = "BotonCancelar"
        Me.BotonCancelar.Size = New System.Drawing.Size(98, 25)
        Me.BotonCancelar.TabIndex = 5
        Me.BotonCancelar.Text = "Cancelar"
        Me.BotonCancelar.UseVisualStyleBackColor = True
        '
        'TempUser
        '
        Me.TempUser.Location = New System.Drawing.Point(283, 62)
        Me.TempUser.Name = "TempUser"
        Me.TempUser.Size = New System.Drawing.Size(84, 20)
        Me.TempUser.TabIndex = 7
        Me.TempUser.Visible = False
        '
        'TempPass
        '
        Me.TempPass.Location = New System.Drawing.Point(283, 100)
        Me.TempPass.Name = "TempPass"
        Me.TempPass.Size = New System.Drawing.Size(84, 20)
        Me.TempPass.TabIndex = 8
        Me.TempPass.Visible = False
        '
        'GridView
        '
        Me.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView.Location = New System.Drawing.Point(144, 208)
        Me.GridView.Name = "GridView"
        Me.GridView.Size = New System.Drawing.Size(94, 68)
        Me.GridView.TabIndex = 9
        Me.GridView.Visible = False
        '
        'txtTipoUsuario
        '
        Me.txtTipoUsuario.Location = New System.Drawing.Point(283, 140)
        Me.txtTipoUsuario.Name = "txtTipoUsuario"
        Me.txtTipoUsuario.Size = New System.Drawing.Size(82, 20)
        Me.txtTipoUsuario.TabIndex = 10
        Me.txtTipoUsuario.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(131, 189)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(235, 13)
        Me.ProgressBar1.TabIndex = 11
        '
        'Timer1
        '
        '
        'BotonAceptar
        '
        Me.BotonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BotonAceptar.Image = Global.WindowsApplication1.My.Resources.Resources.Iu9Rht06
        Me.BotonAceptar.Location = New System.Drawing.Point(144, 137)
        Me.BotonAceptar.Name = "BotonAceptar"
        Me.BotonAceptar.Size = New System.Drawing.Size(98, 25)
        Me.BotonAceptar.TabIndex = 2
        Me.BotonAceptar.Text = "Aceptar"
        Me.BotonAceptar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.r_14_170423113802
        Me.PictureBox1.Location = New System.Drawing.Point(90, 87)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.rounded_26376_960_720
        Me.PictureBox2.Location = New System.Drawing.Point(21, 11)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(458, 196)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(516, 276)
        Me.ControlBox = False
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.txtTipoUsuario)
        Me.Controls.Add(Me.GridView)
        Me.Controls.Add(Me.TempPass)
        Me.Controls.Add(Me.TempUser)
        Me.Controls.Add(Me.BotonCancelar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BotonAceptar)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.TransparencyKey = System.Drawing.Color.DarkGray
        CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents BotonAceptar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BotonCancelar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TempUser As System.Windows.Forms.TextBox
    Friend WithEvents TempPass As System.Windows.Forms.TextBox
    Friend WithEvents GridView As System.Windows.Forms.DataGridView
    Friend WithEvents txtTipoUsuario As System.Windows.Forms.TextBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
