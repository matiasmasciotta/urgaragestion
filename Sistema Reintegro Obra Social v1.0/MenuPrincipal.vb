Public Class MenuPrincipal
    'BOTON GENERAR SOLICITUD
    Private Sub GenerarSolicitudDeReintegroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarSolicitudDeReintegroToolStripMenuItem.Click
        NuevoReintegro.Show()
    End Sub
    '@BOTON SALIR
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ExaminarBeneficiariosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExaminarBeneficiariosToolStripMenuItem.Click
        FormularioABM.Show()
    End Sub

    'Private Sub ConsultarReintegrosPendientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultarReintegrosPendientesToolStripMenuItem.Click
    'Consulta.Show()
    'End Sub

    Private Sub IngresarAlSistemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarAlSistemaToolStripMenuItem.Click
        'poner recurso de audio
        'My.Computer.Audio.Play(My.Resources.Click_ratón_2___efecto_de_sonido, AudioPlayMode.Background)
        Login.Show()
    End Sub

    Private Sub MenuPrincipal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LLAMO AL FICHERO TXT donde apunta la base
        CADENABASE2 = My.Computer.FileSystem.ReadAllText("C:\SROS\CADENABASE.txt").ToString
        segundos.Text = Int(DateTime.Now.Second)
        minutos.Text = Int(DateTime.Now.Minute)
        horas.Text = Int(DateTime.Now.Hour)
        Timer1.Enabled = True
        'effecIn()
        apagarBotones()
        'MsgBox(CADENABASE2)

        '****************si quiero sobreescribirlo********
        'Dim obj As Object
        'Dim archivo As Object
        'obj = CreateObject("Scripting.FileSystemObject")
        'archivo = obj.CreateTextFile("C:\texto.txt")
        'archivo.WriteLine("Esta es la linea 1")
        'archivo.WriteLine("Esta es la linea 2")
        'archivo.close()
    End Sub


    'Metodo apaga botones
    Private Sub apagarBotones()
        ExaminarBeneficiariosToolStripMenuItem.Enabled = False
        ExaminarSolicitudDeReintegroToolStripMenuItem.Enabled = False
        GenerarSolicitudDeReintegroToolStripMenuItem.Enabled = False
        ConsultarReintegrosPendientesToolStripMenuItem.Enabled = False
    End Sub

    Private Sub ExaminarSolicitudDeReintegroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExaminarSolicitudDeReintegroToolStripMenuItem.Click
        ConsultaSolicitudReintegro.Show()
    End Sub

    Private Sub ABMUSUARIOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ABMUSUARIOSToolStripMenuItem.Click
        ABMUsuarios.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Timer1.Interval = (1000)
        'segundos.Text = Int(segundos.Text) + 1
        segundos.Text = DateTime.Now.Second
        minutos.Text = DateTime.Now.Minute
        horas.Text = DateTime.Now.Hour

    End Sub

    Private Sub horas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles horas.Click

    End Sub

    Private Sub SoporteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoporteToolStripMenuItem.Click
        soporte.Show()
    End Sub

    Private Sub ExaminarTodasLasSolicitudesSoloAdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExaminarTodasLasSolicitudesSoloAdminToolStripMenuItem.Click
        ConsultaTotal.Show()
    End Sub

    Private Sub DatosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatosToolStripMenuItem.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub MenuPrincipal_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        PictureBox2.Image = WindowsApplication1.My.Resources.Resources.logoblancourgara
    End Sub

    Private Sub PictureBox2_MouseHover(sender As Object, e As EventArgs) Handles PictureBox2.MouseHover
        ToolTip1.SetToolTip(PictureBox2, "http://www.urgara.org.ar/")
    End Sub

    Private Sub PictureBox2_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox2.MouseMove
        PictureBox2.Image = WindowsApplication1.My.Resources.Resources.logoblancourgara2
    End Sub

    Private Sub ConsultaAuditorMedicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaAuditorMedicoToolStripMenuItem.Click
        FormularioAuditor.show()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub lblUser_Click(sender As Object, e As EventArgs) Handles lblUser.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub minutos_Click(sender As Object, e As EventArgs) Handles minutos.Click

    End Sub

    Private Sub segundos_Click(sender As Object, e As EventArgs) Handles segundos.Click

    End Sub
End Class