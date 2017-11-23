<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteExtendido
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblNumReintegro = New System.Windows.Forms.Label()
        Me.GridViewExtendReporte = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.botonExcel = New System.Windows.Forms.PictureBox()
        Me.lblUsuarioseccional = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        CType(Me.GridViewExtendReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.botonExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USUARIO:"
        '
        'lblNumReintegro
        '
        Me.lblNumReintegro.AutoSize = True
        Me.lblNumReintegro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumReintegro.Location = New System.Drawing.Point(13, 43)
        Me.lblNumReintegro.Name = "lblNumReintegro"
        Me.lblNumReintegro.Size = New System.Drawing.Size(15, 16)
        Me.lblNumReintegro.TabIndex = 1
        Me.lblNumReintegro.Text = "0"
        Me.lblNumReintegro.Visible = False
        '
        'GridViewExtendReporte
        '
        Me.GridViewExtendReporte.AllowUserToAddRows = False
        Me.GridViewExtendReporte.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.GridViewExtendReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridViewExtendReporte.Location = New System.Drawing.Point(12, 101)
        Me.GridViewExtendReporte.MultiSelect = False
        Me.GridViewExtendReporte.Name = "GridViewExtendReporte"
        Me.GridViewExtendReporte.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridViewExtendReporte.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridViewExtendReporte.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.GridViewExtendReporte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridViewExtendReporte.Size = New System.Drawing.Size(905, 498)
        Me.GridViewExtendReporte.TabIndex = 26
        Me.GridViewExtendReporte.VirtualMode = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(813, 43)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 45)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'botonExcel
        '
        Me.botonExcel.BackColor = System.Drawing.Color.Transparent
        Me.botonExcel.Image = Global.WindowsApplication1.My.Resources.Resources.logoexcelsistemaa
        Me.botonExcel.Location = New System.Drawing.Point(739, 43)
        Me.botonExcel.Name = "botonExcel"
        Me.botonExcel.Size = New System.Drawing.Size(38, 38)
        Me.botonExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.botonExcel.TabIndex = 79
        Me.botonExcel.TabStop = False
        '
        'lblUsuarioseccional
        '
        Me.lblUsuarioseccional.AutoSize = True
        Me.lblUsuarioseccional.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsuarioseccional.Location = New System.Drawing.Point(81, 75)
        Me.lblUsuarioseccional.Name = "lblUsuarioseccional"
        Me.lblUsuarioseccional.Size = New System.Drawing.Size(15, 16)
        Me.lblUsuarioseccional.TabIndex = 80
        Me.lblUsuarioseccional.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(317, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "FECHA DESDE"
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesde.Location = New System.Drawing.Point(313, 43)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(19, 20)
        Me.lblDesde.TabIndex = 82
        Me.lblDesde.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(489, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 16)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "HASTA"
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasta.Location = New System.Drawing.Point(480, 43)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(19, 20)
        Me.lblHasta.TabIndex = 84
        Me.lblHasta.Text = "0"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(930, 602)
        Me.ShapeContainer1.TabIndex = 85
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 452
        Me.LineShape1.X2 = 452
        Me.LineShape1.Y1 = 16
        Me.LineShape1.Y2 = 62
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(291, 11)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(311, 56)
        '
        'ReporteExtendido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 602)
        Me.Controls.Add(Me.lblHasta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDesde)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblUsuarioseccional)
        Me.Controls.Add(Me.botonExcel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GridViewExtendReporte)
        Me.Controls.Add(Me.lblNumReintegro)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "ReporteExtendido"
        Me.Text = "Descripcion extendida"
        CType(Me.GridViewExtendReporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.botonExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblNumReintegro As System.Windows.Forms.Label
    Friend WithEvents GridViewExtendReporte As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents botonExcel As System.Windows.Forms.PictureBox
    Friend WithEvents lblUsuarioseccional As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
End Class
