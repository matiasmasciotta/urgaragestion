<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresarAlSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsersSoloAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABMUSUARIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExaminarBeneficiariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExaminarSolicitudDeReintegroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExaminarTodasLasSolicitudesSoloAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReintegrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarSolicitudDeReintegroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarReintegrosPendientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaAuditorMedicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerarPagoDeReintegroOSubsidioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SoporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.segundos = New System.Windows.Forms.Label()
        Me.horas = New System.Windows.Forms.Label()
        Me.minutos = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GridViewUsuario = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridViewUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SteelBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.DatosToolStripMenuItem, Me.ReintegrosToolStripMenuItem, Me.PagosToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1588, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresarAlSistemaToolStripMenuItem, Me.UsersSoloAdminToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'IngresarAlSistemaToolStripMenuItem
        '
        Me.IngresarAlSistemaToolStripMenuItem.BackColor = System.Drawing.Color.LightGray
        Me.IngresarAlSistemaToolStripMenuItem.Image = CType(resources.GetObject("IngresarAlSistemaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IngresarAlSistemaToolStripMenuItem.Name = "IngresarAlSistemaToolStripMenuItem"
        Me.IngresarAlSistemaToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.IngresarAlSistemaToolStripMenuItem.Text = "Ingresar al Sistema"
        '
        'UsersSoloAdminToolStripMenuItem
        '
        Me.UsersSoloAdminToolStripMenuItem.BackColor = System.Drawing.Color.LightGray
        Me.UsersSoloAdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ABMUSUARIOSToolStripMenuItem})
        Me.UsersSoloAdminToolStripMenuItem.Image = CType(resources.GetObject("UsersSoloAdminToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UsersSoloAdminToolStripMenuItem.Name = "UsersSoloAdminToolStripMenuItem"
        Me.UsersSoloAdminToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.UsersSoloAdminToolStripMenuItem.Text = "Users (Solo Admin)"
        Me.UsersSoloAdminToolStripMenuItem.Visible = False
        '
        'ABMUSUARIOSToolStripMenuItem
        '
        Me.ABMUSUARIOSToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.Lupita
        Me.ABMUSUARIOSToolStripMenuItem.Name = "ABMUSUARIOSToolStripMenuItem"
        Me.ABMUSUARIOSToolStripMenuItem.Size = New System.Drawing.Size(243, 22)
        Me.ABMUSUARIOSToolStripMenuItem.Text = "Examinar Usuarios (Solo Admin)"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.BackColor = System.Drawing.Color.LightGray
        Me.SalirToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.Salida
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(175, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'DatosToolStripMenuItem
        '
        Me.DatosToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue
        Me.DatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExaminarBeneficiariosToolStripMenuItem, Me.ExaminarSolicitudDeReintegroToolStripMenuItem, Me.ExaminarTodasLasSolicitudesSoloAdminToolStripMenuItem})
        Me.DatosToolStripMenuItem.Name = "DatosToolStripMenuItem"
        Me.DatosToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.DatosToolStripMenuItem.Text = "Consultas"
        '
        'ExaminarBeneficiariosToolStripMenuItem
        '
        Me.ExaminarBeneficiariosToolStripMenuItem.BackColor = System.Drawing.Color.LightGray
        Me.ExaminarBeneficiariosToolStripMenuItem.Image = CType(resources.GetObject("ExaminarBeneficiariosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExaminarBeneficiariosToolStripMenuItem.Name = "ExaminarBeneficiariosToolStripMenuItem"
        Me.ExaminarBeneficiariosToolStripMenuItem.Size = New System.Drawing.Size(306, 22)
        Me.ExaminarBeneficiariosToolStripMenuItem.Text = "Examinar Beneficiarios"
        '
        'ExaminarSolicitudDeReintegroToolStripMenuItem
        '
        Me.ExaminarSolicitudDeReintegroToolStripMenuItem.BackColor = System.Drawing.Color.LightGray
        Me.ExaminarSolicitudDeReintegroToolStripMenuItem.Image = CType(resources.GetObject("ExaminarSolicitudDeReintegroToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExaminarSolicitudDeReintegroToolStripMenuItem.Name = "ExaminarSolicitudDeReintegroToolStripMenuItem"
        Me.ExaminarSolicitudDeReintegroToolStripMenuItem.Size = New System.Drawing.Size(306, 22)
        Me.ExaminarSolicitudDeReintegroToolStripMenuItem.Text = "Examinar Solicitudes de Reintegro"
        '
        'ExaminarTodasLasSolicitudesSoloAdminToolStripMenuItem
        '
        Me.ExaminarTodasLasSolicitudesSoloAdminToolStripMenuItem.BackColor = System.Drawing.Color.LightGray
        Me.ExaminarTodasLasSolicitudesSoloAdminToolStripMenuItem.Image = CType(resources.GetObject("ExaminarTodasLasSolicitudesSoloAdminToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ExaminarTodasLasSolicitudesSoloAdminToolStripMenuItem.Name = "ExaminarTodasLasSolicitudesSoloAdminToolStripMenuItem"
        Me.ExaminarTodasLasSolicitudesSoloAdminToolStripMenuItem.Size = New System.Drawing.Size(306, 22)
        Me.ExaminarTodasLasSolicitudesSoloAdminToolStripMenuItem.Text = "Examinar Todas las Solicitudes (Solo Admin)"
        Me.ExaminarTodasLasSolicitudesSoloAdminToolStripMenuItem.Visible = False
        '
        'ReintegrosToolStripMenuItem
        '
        Me.ReintegrosToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue
        Me.ReintegrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarSolicitudDeReintegroToolStripMenuItem, Me.ConsultarReintegrosPendientesToolStripMenuItem, Me.ConsultaAuditorMedicoToolStripMenuItem})
        Me.ReintegrosToolStripMenuItem.Name = "ReintegrosToolStripMenuItem"
        Me.ReintegrosToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReintegrosToolStripMenuItem.Text = "Solicitud"
        '
        'GenerarSolicitudDeReintegroToolStripMenuItem
        '
        Me.GenerarSolicitudDeReintegroToolStripMenuItem.BackColor = System.Drawing.Color.LightGray
        Me.GenerarSolicitudDeReintegroToolStripMenuItem.Image = CType(resources.GetObject("GenerarSolicitudDeReintegroToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GenerarSolicitudDeReintegroToolStripMenuItem.Name = "GenerarSolicitudDeReintegroToolStripMenuItem"
        Me.GenerarSolicitudDeReintegroToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.GenerarSolicitudDeReintegroToolStripMenuItem.Text = "Generar Solicitud de Reintegro"
        '
        'ConsultarReintegrosPendientesToolStripMenuItem
        '
        Me.ConsultarReintegrosPendientesToolStripMenuItem.BackColor = System.Drawing.Color.LightGray
        Me.ConsultarReintegrosPendientesToolStripMenuItem.Image = CType(resources.GetObject("ConsultarReintegrosPendientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultarReintegrosPendientesToolStripMenuItem.Name = "ConsultarReintegrosPendientesToolStripMenuItem"
        Me.ConsultarReintegrosPendientesToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.ConsultarReintegrosPendientesToolStripMenuItem.Text = "Consultar Reintegros Pendientes"
        Me.ConsultarReintegrosPendientesToolStripMenuItem.Visible = False
        '
        'ConsultaAuditorMedicoToolStripMenuItem
        '
        Me.ConsultaAuditorMedicoToolStripMenuItem.BackColor = System.Drawing.Color.LightGray
        Me.ConsultaAuditorMedicoToolStripMenuItem.Enabled = False
        Me.ConsultaAuditorMedicoToolStripMenuItem.Image = Global.WindowsApplication1.My.Resources.Resources.medico
        Me.ConsultaAuditorMedicoToolStripMenuItem.Name = "ConsultaAuditorMedicoToolStripMenuItem"
        Me.ConsultaAuditorMedicoToolStripMenuItem.Size = New System.Drawing.Size(245, 22)
        Me.ConsultaAuditorMedicoToolStripMenuItem.Text = "Auditor Medico"
        '
        'PagosToolStripMenuItem
        '
        Me.PagosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerarPagoDeReintegroOSubsidioToolStripMenuItem})
        Me.PagosToolStripMenuItem.Name = "PagosToolStripMenuItem"
        Me.PagosToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.PagosToolStripMenuItem.Text = "Pagos"
        '
        'GenerarPagoDeReintegroOSubsidioToolStripMenuItem
        '
        Me.GenerarPagoDeReintegroOSubsidioToolStripMenuItem.BackColor = System.Drawing.Color.LightGray
        Me.GenerarPagoDeReintegroOSubsidioToolStripMenuItem.Enabled = False
        Me.GenerarPagoDeReintegroOSubsidioToolStripMenuItem.Image = CType(resources.GetObject("GenerarPagoDeReintegroOSubsidioToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GenerarPagoDeReintegroOSubsidioToolStripMenuItem.Name = "GenerarPagoDeReintegroOSubsidioToolStripMenuItem"
        Me.GenerarPagoDeReintegroOSubsidioToolStripMenuItem.Size = New System.Drawing.Size(273, 22)
        Me.GenerarPagoDeReintegroOSubsidioToolStripMenuItem.Text = "Generar Pago de Reintegro o Subsidio"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.Image = CType(resources.GetObject("ConsultarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ConsultarToolStripMenuItem.Text = "Consultar"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.BackColor = System.Drawing.Color.SteelBlue
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SoporteToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'SoporteToolStripMenuItem
        '
        Me.SoporteToolStripMenuItem.BackColor = System.Drawing.Color.LightGray
        Me.SoporteToolStripMenuItem.Image = CType(resources.GetObject("SoporteToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SoporteToolStripMenuItem.Name = "SoporteToolStripMenuItem"
        Me.SoporteToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.SoporteToolStripMenuItem.Text = "Soporte"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.Transparent
        Me.lblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.lblUser.Location = New System.Drawing.Point(1406, 43)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(97, 16)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Text = "Inicie Sesión"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.mejoricorojo
        Me.PictureBox1.Location = New System.Drawing.Point(1307, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(29, 26)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(1330, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 16)
        Me.Label1.TabIndex = 3
        '
        'segundos
        '
        Me.segundos.AutoSize = True
        Me.segundos.BackColor = System.Drawing.Color.Transparent
        Me.segundos.Font = New System.Drawing.Font("LcdD", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.segundos.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.segundos.Location = New System.Drawing.Point(1412, 59)
        Me.segundos.Name = "segundos"
        Me.segundos.Size = New System.Drawing.Size(20, 20)
        Me.segundos.TabIndex = 4
        Me.segundos.Text = "0"
        '
        'horas
        '
        Me.horas.AutoSize = True
        Me.horas.BackColor = System.Drawing.Color.Transparent
        Me.horas.Font = New System.Drawing.Font("LcdD", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.horas.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.horas.Location = New System.Drawing.Point(1339, 59)
        Me.horas.Name = "horas"
        Me.horas.Size = New System.Drawing.Size(20, 20)
        Me.horas.TabIndex = 5
        Me.horas.Text = "0"
        '
        'minutos
        '
        Me.minutos.AutoSize = True
        Me.minutos.BackColor = System.Drawing.Color.Transparent
        Me.minutos.Font = New System.Drawing.Font("LcdD", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minutos.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.minutos.Location = New System.Drawing.Point(1373, 59)
        Me.minutos.Name = "minutos"
        Me.minutos.Size = New System.Drawing.Size(20, 20)
        Me.minutos.TabIndex = 6
        Me.minutos.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("LcdD", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label2.Location = New System.Drawing.Point(1359, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("LcdD", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label3.Location = New System.Drawing.Point(1395, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = ":"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.WindowsApplication1.My.Resources.Resources.logoblancourgara
        Me.PictureBox2.Location = New System.Drawing.Point(647, 702)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(472, 134)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 700
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'GridViewUsuario
        '
        Me.GridViewUsuario.AllowUserToAddRows = False
        Me.GridViewUsuario.BackgroundColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridViewUsuario.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridViewUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GridViewUsuario.DefaultCellStyle = DataGridViewCellStyle2
        Me.GridViewUsuario.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.GridViewUsuario.Location = New System.Drawing.Point(738, 103)
        Me.GridViewUsuario.MultiSelect = False
        Me.GridViewUsuario.Name = "GridViewUsuario"
        Me.GridViewUsuario.ReadOnly = True
        Me.GridViewUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridViewUsuario.Size = New System.Drawing.Size(363, 62)
        Me.GridViewUsuario.TabIndex = 39
        Me.GridViewUsuario.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.Label4.Location = New System.Drawing.Point(1340, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Usuario:"
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1588, 865)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GridViewUsuario)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.minutos)
        Me.Controls.Add(Me.horas)
        Me.Controls.Add(Me.segundos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Menu Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridViewUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExaminarBeneficiariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExaminarSolicitudDeReintegroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReintegrosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarSolicitudDeReintegroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarReintegrosPendientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SoporteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresarAlSistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents UsersSoloAdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABMUSUARIOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExaminarTodasLasSolicitudesSoloAdminToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents segundos As System.Windows.Forms.Label
    Friend WithEvents horas As System.Windows.Forms.Label
    Friend WithEvents minutos As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ConsultaAuditorMedicoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PagosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerarPagoDeReintegroOSubsidioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GridViewUsuario As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
