Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Windows.Forms.Keys
Imports System.Text.RegularExpressions


Public Class MenuPrincipal
    Dim Conex As New MySqlConnection(CADENABASE2)
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand


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
    End Sub

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


    Private Sub SoporteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SoporteToolStripMenuItem.Click
        soporte.Show()
    End Sub

    Private Sub ExaminarTodasLasSolicitudesSoloAdminToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExaminarTodasLasSolicitudesSoloAdminToolStripMenuItem.Click
        ConsultaTotal.Show()
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
        FormularioAuditor.Show()
    End Sub


    Private Sub GenerarPagoDeReintegroOSubsidioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarPagoDeReintegroOSubsidioToolStripMenuItem.Click
        FormularioPagos.Show()
    End Sub

    'LABEL DE USER
    Private Sub GridViewUsuario_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles GridViewUsuario.RowsAdded
        lblUser.Text = GridViewUsuario.Rows(0).Cells(0).Value.ToString()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Reportes.Show()
    End Sub






    Private Sub botonValidaCuit_Click(sender As Object, e As EventArgs)

    End Sub

    '  Private Sub txtCUITT_KeyPress(sender As Object, e As KeyPressEventArgs)
    '      e.Handled = NumericSOLOCUIT(e.KeyChar)
    '  End Sub


    '    Public Function NumericSOLOCUIT(ByVal eChar As Char) As Boolean
    ' Dim chkStr As String = "0123456789"
    '     If chkStr.IndexOf(eChar) > -1 OrElse eChar = vbBack Then
    '         If eChar = Chr(44) And txtCUITT.Text.Contains(" ") Then Return True
    '         Return False
    '     Else
    '         Return True
    '     End If
    ' End Function


    '    Private Sub txtCUITT_LostFocus(sender As Object, e As EventArgs)
    ' Dim VARCUI As String = txtCUITT.Text
    '     mkf_validacuit(VARCUI)
    '     If mkf_validacuit(VARCUI) = True Then
    '         lblresultadocuit.Text = "(ok)"
    '         lblresultadocuit.ForeColor = Color.GreenYellow
    '     Else
    '         lblresultadocuit.Text = "(*)"
    '         lblresultadocuit.ForeColor = Color.Red
    '     End If
    ' End Sub


End Class