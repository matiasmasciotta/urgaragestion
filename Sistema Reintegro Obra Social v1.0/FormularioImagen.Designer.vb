<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioImagen
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
        Me.ButtonINICIAL = New System.Windows.Forms.Button()
        Me.ButtonDISMINUCION = New System.Windows.Forms.Button()
        Me.ButtonAUMENTO = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.botonVolver = New System.Windows.Forms.Button()
        Me.botonImprime = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonINICIAL
        '
        Me.ButtonINICIAL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonINICIAL.BackColor = System.Drawing.Color.Black
        Me.ButtonINICIAL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonINICIAL.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonINICIAL.Location = New System.Drawing.Point(1056, 184)
        Me.ButtonINICIAL.Name = "ButtonINICIAL"
        Me.ButtonINICIAL.Size = New System.Drawing.Size(100, 40)
        Me.ButtonINICIAL.TabIndex = 8
        Me.ButtonINICIAL.Text = "INICIAL"
        Me.ButtonINICIAL.UseVisualStyleBackColor = False
        '
        'ButtonDISMINUCION
        '
        Me.ButtonDISMINUCION.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDISMINUCION.BackColor = System.Drawing.Color.Black
        Me.ButtonDISMINUCION.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDISMINUCION.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonDISMINUCION.Location = New System.Drawing.Point(1056, 103)
        Me.ButtonDISMINUCION.Name = "ButtonDISMINUCION"
        Me.ButtonDISMINUCION.Size = New System.Drawing.Size(100, 40)
        Me.ButtonDISMINUCION.TabIndex = 6
        Me.ButtonDISMINUCION.Text = "ZOOM --"
        Me.ButtonDISMINUCION.UseVisualStyleBackColor = False
        '
        'ButtonAUMENTO
        '
        Me.ButtonAUMENTO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAUMENTO.BackColor = System.Drawing.Color.Black
        Me.ButtonAUMENTO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAUMENTO.ForeColor = System.Drawing.Color.Cyan
        Me.ButtonAUMENTO.Location = New System.Drawing.Point(1056, 57)
        Me.ButtonAUMENTO.Name = "ButtonAUMENTO"
        Me.ButtonAUMENTO.Size = New System.Drawing.Size(100, 40)
        Me.ButtonAUMENTO.TabIndex = 5
        Me.ButtonAUMENTO.Text = "ZOOM ++"
        Me.ButtonAUMENTO.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(62, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(934, 616)
        Me.Panel1.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(853, 579)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'botonVolver
        '
        Me.botonVolver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.botonVolver.BackColor = System.Drawing.Color.Black
        Me.botonVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonVolver.ForeColor = System.Drawing.Color.Cyan
        Me.botonVolver.Location = New System.Drawing.Point(1056, 457)
        Me.botonVolver.Name = "botonVolver"
        Me.botonVolver.Size = New System.Drawing.Size(100, 40)
        Me.botonVolver.TabIndex = 10
        Me.botonVolver.Text = "Volver"
        Me.botonVolver.UseVisualStyleBackColor = False
        '
        'botonImprime
        '
        Me.botonImprime.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.botonImprime.BackColor = System.Drawing.Color.Black
        Me.botonImprime.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.XPGhgtm
        Me.botonImprime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.botonImprime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonImprime.ForeColor = System.Drawing.Color.Cyan
        Me.botonImprime.Location = New System.Drawing.Point(1056, 292)
        Me.botonImprime.Name = "botonImprime"
        Me.botonImprime.Size = New System.Drawing.Size(100, 91)
        Me.botonImprime.TabIndex = 11
        Me.botonImprime.UseVisualStyleBackColor = False
        '
        'FormularioImagen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1187, 678)
        Me.Controls.Add(Me.botonImprime)
        Me.Controls.Add(Me.botonVolver)
        Me.Controls.Add(Me.ButtonINICIAL)
        Me.Controls.Add(Me.ButtonDISMINUCION)
        Me.Controls.Add(Me.ButtonAUMENTO)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormularioImagen"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imagen"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonINICIAL As System.Windows.Forms.Button
    Friend WithEvents ButtonDISMINUCION As System.Windows.Forms.Button
    Friend WithEvents ButtonAUMENTO As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents botonVolver As System.Windows.Forms.Button
    Friend WithEvents botonImprime As System.Windows.Forms.Button
End Class
