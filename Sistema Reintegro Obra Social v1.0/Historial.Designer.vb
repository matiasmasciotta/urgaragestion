<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Historial
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GridView1 = New System.Windows.Forms.DataGridView()
        Me.botonExcel = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.GridDetalleReintegro = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logoURGARA = New System.Windows.Forms.PictureBox()
        Me.logoOSRGA = New System.Windows.Forms.PictureBox()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.botonExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDetalleReintegro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logoURGARA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logoOSRGA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(811, 24)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 30)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Volver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GridView1
        '
        Me.GridView1.AllowUserToAddRows = False
        Me.GridView1.AllowUserToDeleteRows = False
        Me.GridView1.BackgroundColor = System.Drawing.Color.LightSlateGray
        Me.GridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridView1.Location = New System.Drawing.Point(-30, 67)
        Me.GridView1.MultiSelect = False
        Me.GridView1.Name = "GridView1"
        Me.GridView1.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.GridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridView1.Size = New System.Drawing.Size(1564, 422)
        Me.GridView1.TabIndex = 15
        Me.GridView1.VirtualMode = True
        '
        'botonExcel
        '
        Me.botonExcel.Image = Global.WindowsApplication1.My.Resources.Resources.logoexcelsistemaa
        Me.botonExcel.Location = New System.Drawing.Point(753, 25)
        Me.botonExcel.Name = "botonExcel"
        Me.botonExcel.Size = New System.Drawing.Size(31, 28)
        Me.botonExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.botonExcel.TabIndex = 78
        Me.botonExcel.TabStop = False
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1543, 593)
        Me.ShapeContainer1.TabIndex = 79
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(12, 21)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(779, 37)
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(19, 31)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(71, 20)
        Me.lblTitulo.TabIndex = 80
        Me.lblTitulo.Text = "TITULO"
        '
        'GridDetalleReintegro
        '
        Me.GridDetalleReintegro.AllowUserToAddRows = False
        Me.GridDetalleReintegro.AllowUserToDeleteRows = False
        Me.GridDetalleReintegro.BackgroundColor = System.Drawing.Color.CornflowerBlue
        Me.GridDetalleReintegro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridDetalleReintegro.Location = New System.Drawing.Point(-38, 518)
        Me.GridDetalleReintegro.MultiSelect = False
        Me.GridDetalleReintegro.Name = "GridDetalleReintegro"
        Me.GridDetalleReintegro.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridDetalleReintegro.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridDetalleReintegro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.GridDetalleReintegro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridDetalleReintegro.Size = New System.Drawing.Size(1572, 64)
        Me.GridDetalleReintegro.TabIndex = 81
        Me.GridDetalleReintegro.VirtualMode = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 495)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 20)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Detalle del Reintegro"
        '
        'logoURGARA
        '
        Me.logoURGARA.BackColor = System.Drawing.Color.Transparent
        Me.logoURGARA.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Marca_URGARA
        Me.logoURGARA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logoURGARA.Location = New System.Drawing.Point(1336, 7)
        Me.logoURGARA.Name = "logoURGARA"
        Me.logoURGARA.Size = New System.Drawing.Size(95, 47)
        Me.logoURGARA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoURGARA.TabIndex = 84
        Me.logoURGARA.TabStop = False
        '
        'logoOSRGA
        '
        Me.logoOSRGA.BackColor = System.Drawing.Color.Transparent
        Me.logoOSRGA.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.Marca_OSRGA2
        Me.logoOSRGA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.logoOSRGA.Location = New System.Drawing.Point(1438, 7)
        Me.logoOSRGA.Name = "logoOSRGA"
        Me.logoOSRGA.Size = New System.Drawing.Size(95, 47)
        Me.logoOSRGA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoOSRGA.TabIndex = 83
        Me.logoOSRGA.TabStop = False
        '
        'Historial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1543, 593)
        Me.Controls.Add(Me.logoURGARA)
        Me.Controls.Add(Me.logoOSRGA)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GridDetalleReintegro)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.botonExcel)
        Me.Controls.Add(Me.GridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Historial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Historial"
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.botonExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDetalleReintegro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logoURGARA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logoOSRGA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents botonExcel As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents lblTitulo As System.Windows.Forms.Label
    Friend WithEvents GridDetalleReintegro As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents logoURGARA As System.Windows.Forms.PictureBox
    Friend WithEvents logoOSRGA As System.Windows.Forms.PictureBox
End Class
