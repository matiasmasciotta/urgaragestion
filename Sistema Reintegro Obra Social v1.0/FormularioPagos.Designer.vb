﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioPagos
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioPagos))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GridView2 = New System.Windows.Forms.DataGridView()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.botonExcel = New System.Windows.Forms.PictureBox()
        Me.botonDesaprobar = New System.Windows.Forms.Button()
        Me.botonAprobar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblObservacionesComision = New System.Windows.Forms.Label()
        Me.lblPorcentajeReintegro = New System.Windows.Forms.Label()
        Me.txtObservacionesAM = New System.Windows.Forms.TextBox()
        Me.txtPorcAM = New System.Windows.Forms.TextBox()
        Me.CANCELA = New System.Windows.Forms.Button()
        Me.OK = New System.Windows.Forms.Button()
        Me.lblPicture = New System.Windows.Forms.PictureBox()
        Me.clbimagen = New System.Windows.Forms.CheckedListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtAutorizante = New System.Windows.Forms.TextBox()
        Me.lblAutorizante = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblImporteSolicitado = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.botonExcelRechazados = New System.Windows.Forms.PictureBox()
        Me.GridView3 = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.botonExcelPagados = New System.Windows.Forms.PictureBox()
        Me.GridView4 = New System.Windows.Forms.DataGridView()
        Me.opSubsidio = New System.Windows.Forms.CheckBox()
        Me.opReintegro = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNumReintegroBusqueda = New System.Windows.Forms.TextBox()
        Me.opBuscaNumReintegro = New System.Windows.Forms.RadioButton()
        Me.opBuscarDNI = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.botonExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.botonExcelRechazados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.botonExcelPagados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 13)
        Me.Label1.TabIndex = 87
        Me.Label1.Text = "Detalle a Buscar:"
        '
        'txtBeneficiario
        '
        Me.txtBeneficiario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBeneficiario.Location = New System.Drawing.Point(26, 22)
        Me.txtBeneficiario.MaxLength = 13
        Me.txtBeneficiario.Name = "txtBeneficiario"
        Me.txtBeneficiario.Size = New System.Drawing.Size(286, 20)
        Me.txtBeneficiario.TabIndex = 85
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 57)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1173, 84)
        Me.GroupBox1.TabIndex = 86
        Me.GroupBox1.TabStop = False
        '
        'lblfechahasta
        '
        Me.lblfechahasta.AutoSize = True
        Me.lblfechahasta.BackColor = System.Drawing.Color.Transparent
        Me.lblfechahasta.Location = New System.Drawing.Point(374, 12)
        Me.lblfechahasta.Name = "lblfechahasta"
        Me.lblfechahasta.Size = New System.Drawing.Size(77, 13)
        Me.lblfechahasta.TabIndex = 23
        Me.lblfechahasta.Text = "aaaa - mm - dd"
        Me.lblfechahasta.Visible = False
        '
        'lblfechadesde
        '
        Me.lblfechadesde.AutoSize = True
        Me.lblfechadesde.BackColor = System.Drawing.Color.Transparent
        Me.lblfechadesde.Location = New System.Drawing.Point(120, 12)
        Me.lblfechadesde.Name = "lblfechadesde"
        Me.lblfechadesde.Size = New System.Drawing.Size(77, 13)
        Me.lblfechadesde.TabIndex = 22
        Me.lblfechadesde.Text = "aaaa - mm - dd"
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
        Me.checkFecha.BackColor = System.Drawing.Color.Transparent
        Me.checkFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkFecha.Location = New System.Drawing.Point(4, -1)
        Me.checkFecha.Name = "checkFecha"
        Me.checkFecha.Size = New System.Drawing.Size(115, 19)
        Me.checkFecha.TabIndex = 18
        Me.checkFecha.Text = "Filtrar por Fecha"
        Me.checkFecha.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(328, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 15)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Hasta"
        Me.Label3.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Fecha Desde:"
        Me.Label2.Visible = False
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
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(117, 54)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(201, 20)
        Me.DateTimePicker1.TabIndex = 46
        Me.DateTimePicker1.Visible = False
        '
        'GridView2
        '
        Me.GridView2.AllowUserToAddRows = False
        Me.GridView2.AllowUserToDeleteRows = False
        Me.GridView2.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.GridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView2.Location = New System.Drawing.Point(3, 3)
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
        Me.GridView2.Size = New System.Drawing.Size(1163, 267)
        Me.GridView2.TabIndex = 89
        Me.GridView2.VirtualMode = True
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(590, 330)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(535, 83)
        '
        'botonExcel
        '
        Me.botonExcel.Image = Global.WindowsApplication1.My.Resources.Resources.logoexcelsistemaa
        Me.botonExcel.Location = New System.Drawing.Point(1084, 276)
        Me.botonExcel.Name = "botonExcel"
        Me.botonExcel.Size = New System.Drawing.Size(45, 43)
        Me.botonExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.botonExcel.TabIndex = 92
        Me.botonExcel.TabStop = False
        '
        'botonDesaprobar
        '
        Me.botonDesaprobar.BackColor = System.Drawing.Color.Red
        Me.botonDesaprobar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonDesaprobar.Image = CType(resources.GetObject("botonDesaprobar.Image"), System.Drawing.Image)
        Me.botonDesaprobar.Location = New System.Drawing.Point(410, 387)
        Me.botonDesaprobar.Name = "botonDesaprobar"
        Me.botonDesaprobar.Size = New System.Drawing.Size(130, 34)
        Me.botonDesaprobar.TabIndex = 94
        Me.botonDesaprobar.Text = "RECHAZAR"
        Me.botonDesaprobar.UseVisualStyleBackColor = False
        Me.botonDesaprobar.Visible = False
        '
        'botonAprobar
        '
        Me.botonAprobar.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.botonAprobar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonAprobar.Image = CType(resources.GetObject("botonAprobar.Image"), System.Drawing.Image)
        Me.botonAprobar.Location = New System.Drawing.Point(410, 333)
        Me.botonAprobar.Name = "botonAprobar"
        Me.botonAprobar.Size = New System.Drawing.Size(130, 40)
        Me.botonAprobar.TabIndex = 93
        Me.botonAprobar.Text = "APROBAR REINTEGRO"
        Me.botonAprobar.UseVisualStyleBackColor = False
        Me.botonAprobar.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(956, 355)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 16)
        Me.Label9.TabIndex = 112
        Me.Label9.Text = "%"
        Me.Label9.Visible = False
        '
        'lblObservacionesComision
        '
        Me.lblObservacionesComision.AutoSize = True
        Me.lblObservacionesComision.Location = New System.Drawing.Point(609, 375)
        Me.lblObservacionesComision.Name = "lblObservacionesComision"
        Me.lblObservacionesComision.Size = New System.Drawing.Size(196, 13)
        Me.lblObservacionesComision.TabIndex = 111
        Me.lblObservacionesComision.Text = "Observaciones del Reintegro o Subsidio"
        Me.lblObservacionesComision.Visible = False
        '
        'lblPorcentajeReintegro
        '
        Me.lblPorcentajeReintegro.AutoSize = True
        Me.lblPorcentajeReintegro.Location = New System.Drawing.Point(896, 336)
        Me.lblPorcentajeReintegro.Name = "lblPorcentajeReintegro"
        Me.lblPorcentajeReintegro.Size = New System.Drawing.Size(107, 13)
        Me.lblPorcentajeReintegro.TabIndex = 110
        Me.lblPorcentajeReintegro.Text = "Porcentaje Reintegro"
        Me.lblPorcentajeReintegro.Visible = False
        '
        'txtObservacionesAM
        '
        Me.txtObservacionesAM.Location = New System.Drawing.Point(611, 391)
        Me.txtObservacionesAM.MaxLength = 120
        Me.txtObservacionesAM.Name = "txtObservacionesAM"
        Me.txtObservacionesAM.Size = New System.Drawing.Size(379, 20)
        Me.txtObservacionesAM.TabIndex = 109
        Me.txtObservacionesAM.Visible = False
        '
        'txtPorcAM
        '
        Me.txtPorcAM.Location = New System.Drawing.Point(899, 353)
        Me.txtPorcAM.MaxLength = 3
        Me.txtPorcAM.Name = "txtPorcAM"
        Me.txtPorcAM.Size = New System.Drawing.Size(55, 20)
        Me.txtPorcAM.TabIndex = 108
        Me.txtPorcAM.Visible = False
        '
        'CANCELA
        '
        Me.CANCELA.BackColor = System.Drawing.Color.Chocolate
        Me.CANCELA.Location = New System.Drawing.Point(1030, 379)
        Me.CANCELA.Name = "CANCELA"
        Me.CANCELA.Size = New System.Drawing.Size(49, 32)
        Me.CANCELA.TabIndex = 107
        Me.CANCELA.Text = "Cancelar"
        Me.CANCELA.UseVisualStyleBackColor = False
        Me.CANCELA.Visible = False
        '
        'OK
        '
        Me.OK.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.OK.Location = New System.Drawing.Point(1030, 339)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(49, 41)
        Me.OK.TabIndex = 106
        Me.OK.Text = "OK"
        Me.OK.UseVisualStyleBackColor = False
        Me.OK.Visible = False
        '
        'lblPicture
        '
        Me.lblPicture.BackColor = System.Drawing.SystemColors.Info
        Me.lblPicture.Location = New System.Drawing.Point(1058, 617)
        Me.lblPicture.Name = "lblPicture"
        Me.lblPicture.Size = New System.Drawing.Size(131, 107)
        Me.lblPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.lblPicture.TabIndex = 115
        Me.lblPicture.TabStop = False
        '
        'clbimagen
        '
        Me.clbimagen.BackColor = System.Drawing.Color.Silver
        Me.clbimagen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.clbimagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clbimagen.FormattingEnabled = True
        Me.clbimagen.Location = New System.Drawing.Point(754, 631)
        Me.clbimagen.Name = "clbimagen"
        Me.clbimagen.Size = New System.Drawing.Size(194, 80)
        Me.clbimagen.TabIndex = 113
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApplication1.My.Resources.Resources.rec2
        Me.PictureBox1.Location = New System.Drawing.Point(745, 622)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(214, 102)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 114
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(22, 694)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(608, 30)
        Me.Button1.TabIndex = 116
        Me.Button1.Text = "Salir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtAutorizante
        '
        Me.txtAutorizante.Location = New System.Drawing.Point(612, 352)
        Me.txtAutorizante.MaxLength = 120
        Me.txtAutorizante.Name = "txtAutorizante"
        Me.txtAutorizante.Size = New System.Drawing.Size(266, 20)
        Me.txtAutorizante.TabIndex = 117
        Me.txtAutorizante.Visible = False
        '
        'lblAutorizante
        '
        Me.lblAutorizante.AutoSize = True
        Me.lblAutorizante.Location = New System.Drawing.Point(609, 336)
        Me.lblAutorizante.Name = "lblAutorizante"
        Me.lblAutorizante.Size = New System.Drawing.Size(137, 13)
        Me.lblAutorizante.TabIndex = 118
        Me.lblAutorizante.Text = "Autorizante (de la Comision)"
        Me.lblAutorizante.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 16)
        Me.Label6.TabIndex = 119
        Me.Label6.Text = "Importe Solicitado: $"
        '
        'lblImporteSolicitado
        '
        Me.lblImporteSolicitado.AutoSize = True
        Me.lblImporteSolicitado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporteSolicitado.Location = New System.Drawing.Point(128, 276)
        Me.lblImporteSolicitado.Name = "lblImporteSolicitado"
        Me.lblImporteSolicitado.Size = New System.Drawing.Size(15, 16)
        Me.lblImporteSolicitado.TabIndex = 120
        Me.lblImporteSolicitado.Text = "1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 144)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1177, 453)
        Me.TabControl1.TabIndex = 121
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Silver
        Me.TabPage1.Controls.Add(Me.botonExcel)
        Me.TabPage1.Controls.Add(Me.lblAutorizante)
        Me.TabPage1.Controls.Add(Me.lblImporteSolicitado)
        Me.TabPage1.Controls.Add(Me.OK)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.CANCELA)
        Me.TabPage1.Controls.Add(Me.txtPorcAM)
        Me.TabPage1.Controls.Add(Me.txtAutorizante)
        Me.TabPage1.Controls.Add(Me.txtObservacionesAM)
        Me.TabPage1.Controls.Add(Me.lblPorcentajeReintegro)
        Me.TabPage1.Controls.Add(Me.lblObservacionesComision)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.GridView2)
        Me.TabPage1.Controls.Add(Me.botonDesaprobar)
        Me.TabPage1.Controls.Add(Me.botonAprobar)
        Me.TabPage1.Controls.Add(Me.ShapeContainer2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1169, 427)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "PENDIENTES DE APROBACION Y PAGO"
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(3, 3)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(1163, 421)
        Me.ShapeContainer2.TabIndex = 95
        Me.ShapeContainer2.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage2.Controls.Add(Me.botonExcelRechazados)
        Me.TabPage2.Controls.Add(Me.GridView3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1169, 427)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "RECHAZADOS POR C.D.N."
        '
        'botonExcelRechazados
        '
        Me.botonExcelRechazados.Image = Global.WindowsApplication1.My.Resources.Resources.logoexcelsistemaa
        Me.botonExcelRechazados.Location = New System.Drawing.Point(1070, 365)
        Me.botonExcelRechazados.Name = "botonExcelRechazados"
        Me.botonExcelRechazados.Size = New System.Drawing.Size(45, 43)
        Me.botonExcelRechazados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.botonExcelRechazados.TabIndex = 122
        Me.botonExcelRechazados.TabStop = False
        '
        'GridView3
        '
        Me.GridView3.AllowUserToAddRows = False
        Me.GridView3.BackgroundColor = System.Drawing.Color.MistyRose
        Me.GridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView3.Location = New System.Drawing.Point(3, 3)
        Me.GridView3.MultiSelect = False
        Me.GridView3.Name = "GridView3"
        Me.GridView3.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridView3.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.GridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.GridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridView3.Size = New System.Drawing.Size(1163, 344)
        Me.GridView3.TabIndex = 94
        Me.GridView3.VirtualMode = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.botonExcelPagados)
        Me.TabPage3.Controls.Add(Me.GridView4)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(1169, 427)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "APROBADOS C.D.N. Y PAGADOS"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'botonExcelPagados
        '
        Me.botonExcelPagados.Image = Global.WindowsApplication1.My.Resources.Resources.logoexcelsistemaa
        Me.botonExcelPagados.Location = New System.Drawing.Point(1053, 365)
        Me.botonExcelPagados.Name = "botonExcelPagados"
        Me.botonExcelPagados.Size = New System.Drawing.Size(45, 43)
        Me.botonExcelPagados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.botonExcelPagados.TabIndex = 122
        Me.botonExcelPagados.TabStop = False
        '
        'GridView4
        '
        Me.GridView4.AllowUserToAddRows = False
        Me.GridView4.BackgroundColor = System.Drawing.Color.YellowGreen
        Me.GridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView4.Location = New System.Drawing.Point(3, 5)
        Me.GridView4.MultiSelect = False
        Me.GridView4.Name = "GridView4"
        Me.GridView4.ReadOnly = True
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridView4.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.GridView4.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.GridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridView4.Size = New System.Drawing.Size(1163, 341)
        Me.GridView4.TabIndex = 95
        Me.GridView4.VirtualMode = True
        '
        'opSubsidio
        '
        Me.opSubsidio.AutoSize = True
        Me.opSubsidio.BackColor = System.Drawing.Color.Transparent
        Me.opSubsidio.Location = New System.Drawing.Point(807, 119)
        Me.opSubsidio.Name = "opSubsidio"
        Me.opSubsidio.Size = New System.Drawing.Size(71, 17)
        Me.opSubsidio.TabIndex = 127
        Me.opSubsidio.Text = "Subsidios"
        Me.opSubsidio.UseVisualStyleBackColor = False
        '
        'opReintegro
        '
        Me.opReintegro.AutoSize = True
        Me.opReintegro.BackColor = System.Drawing.Color.Transparent
        Me.opReintegro.Location = New System.Drawing.Point(807, 102)
        Me.opReintegro.Name = "opReintegro"
        Me.opReintegro.Size = New System.Drawing.Size(77, 17)
        Me.opReintegro.TabIndex = 126
        Me.opReintegro.Text = "Reintegros"
        Me.opReintegro.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(731, 113)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 128
        Me.Label12.Text = "Solicitud tipo:"
        '
        'txtNumReintegroBusqueda
        '
        Me.txtNumReintegroBusqueda.Enabled = False
        Me.txtNumReintegroBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumReintegroBusqueda.Location = New System.Drawing.Point(220, 20)
        Me.txtNumReintegroBusqueda.MaxLength = 13
        Me.txtNumReintegroBusqueda.Name = "txtNumReintegroBusqueda"
        Me.txtNumReintegroBusqueda.Size = New System.Drawing.Size(121, 20)
        Me.txtNumReintegroBusqueda.TabIndex = 125
        '
        'opBuscaNumReintegro
        '
        Me.opBuscaNumReintegro.AutoSize = True
        Me.opBuscaNumReintegro.BackColor = System.Drawing.Color.Transparent
        Me.opBuscaNumReintegro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opBuscaNumReintegro.Location = New System.Drawing.Point(26, 10)
        Me.opBuscaNumReintegro.Name = "opBuscaNumReintegro"
        Me.opBuscaNumReintegro.Size = New System.Drawing.Size(189, 20)
        Me.opBuscaNumReintegro.TabIndex = 124
        Me.opBuscaNumReintegro.TabStop = True
        Me.opBuscaNumReintegro.Text = "Buscar por N° de Reintegro"
        Me.opBuscaNumReintegro.UseVisualStyleBackColor = False
        '
        'opBuscarDNI
        '
        Me.opBuscarDNI.AutoSize = True
        Me.opBuscarDNI.BackColor = System.Drawing.Color.Transparent
        Me.opBuscarDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opBuscarDNI.Location = New System.Drawing.Point(26, 28)
        Me.opBuscarDNI.Name = "opBuscarDNI"
        Me.opBuscarDNI.Size = New System.Drawing.Size(190, 20)
        Me.opBuscarDNI.TabIndex = 123
        Me.opBuscarDNI.TabStop = True
        Me.opBuscarDNI.Text = "Buscar por Cuil Beneficiario"
        Me.opBuscarDNI.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNumReintegroBusqueda)
        Me.GroupBox2.Controls.Add(Me.opBuscaNumReintegro)
        Me.GroupBox2.Controls.Add(Me.opBuscarDNI)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Location = New System.Drawing.Point(343, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(839, 54)
        Me.GroupBox2.TabIndex = 129
        Me.GroupBox2.TabStop = False
        '
        'FormularioPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1201, 728)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.opReintegro)
        Me.Controls.Add(Me.opSubsidio)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblPicture)
        Me.Controls.Add(Me.clbimagen)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBeneficiario)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FormularioPagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pagos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.botonExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.botonExcelRechazados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.botonExcelPagados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents GridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents botonExcel As System.Windows.Forms.PictureBox
    Friend WithEvents botonDesaprobar As System.Windows.Forms.Button
    Friend WithEvents botonAprobar As System.Windows.Forms.Button
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblObservacionesComision As System.Windows.Forms.Label
    Friend WithEvents lblPorcentajeReintegro As System.Windows.Forms.Label
    Friend WithEvents txtObservacionesAM As System.Windows.Forms.TextBox
    Friend WithEvents txtPorcAM As System.Windows.Forms.TextBox
    Friend WithEvents CANCELA As System.Windows.Forms.Button
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents lblPicture As System.Windows.Forms.PictureBox
    Friend WithEvents clbimagen As System.Windows.Forms.CheckedListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtAutorizante As System.Windows.Forms.TextBox
    Friend WithEvents lblAutorizante As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblImporteSolicitado As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents GridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents ShapeContainer2 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents botonExcelRechazados As System.Windows.Forms.PictureBox
    Friend WithEvents botonExcelPagados As System.Windows.Forms.PictureBox
    Friend WithEvents opSubsidio As System.Windows.Forms.CheckBox
    Friend WithEvents opReintegro As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNumReintegroBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents opBuscaNumReintegro As System.Windows.Forms.RadioButton
    Friend WithEvents opBuscarDNI As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
