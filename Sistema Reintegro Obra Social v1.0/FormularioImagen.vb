Imports System.Drawing.Imaging
Imports System.Drawing.Printing

Public Class FormularioImagen

    Dim BM1 As Bitmap  'GUARDA LA IMAGEN INICIAL
    Dim MIX As Integer 'GUARDA LA POSICION INICIAL EN X DEL MOUSE
    Dim MIY As Integer 'GUARDA LA POSICION INICIAL EN Y DEL MOUSE
    Dim MUEVE As Boolean 'CONTROLA EL MOVIMIENTO DEL MOUSE

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BM1 = Me.PictureBox1.Image
        'PARAMETROS NECESARIOS
        PictureBox1.SizeMode = PictureBoxSizeMode.AutoSize 'AJUSTA EL TAMAÑO DEL PICTUREBOX AL TAMAÑO DE LA IMAGEN
        Panel1.AutoScroll = True 'MUESTRA LAS BARRAS DE SCROLL

    End Sub


    Private Sub ButtonAUMENTO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAUMENTO.Click

        'CADA VEZ QUE SE CLICA EL BOTON SE AUMENTA EL TAMAÑO DE LA IMAGEN UN 10%
        Dim BM2 As New Bitmap(BM1, PictureBox1.Image.Width * 1.1, PictureBox1.Image.Height * 1.1)
        PictureBox1.Image = BM2

    End Sub

    Private Sub ButtonDISMINUCION_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDISMINUCION.Click

        'CADA VEZ QUE SE CLICA EL BOTON SE DISMINUYE EL TAMAÑO DE LA IMAGEN UN 10%
        Dim BM2 As New Bitmap(BM1, PictureBox1.Image.Width * 0.9, PictureBox1.Image.Height * 0.9)
        PictureBox1.Image = BM2

    End Sub

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown

        'DETERMINA LA POSICION EN LA QUE SE HA PRESIONADO EL MOUSE
        MIX = e.Location.X
        MIY = e.Location.Y

        MUEVE = True 'SE HA INICIADO EL DESPLAZAMIENTO

    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove

        If MUEVE Then

            'DETERMINA LA DIFERENCIA DE POSICION DEL MOUSE
            Dim DIFX As Integer = (MIX - e.X)
            Dim DIFY As Integer = (MIY - e.Y)

            'NUEVA POSICION DE LAS BARRAS DE SCROLL DEL PANEL
            Panel1.AutoScrollPosition = New Point((DIFX - Panel1.AutoScrollPosition.X), (DIFY - Panel1.AutoScrollPosition.Y))

        End If

    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp

        MUEVE = False 'SE HA TERMINADO EL DESPLAZAMIENTO

    End Sub

    Private Sub ButtonINICIAL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonINICIAL.Click

        'IMAGEN Y PICTUREBOX VUELVEN A LOS VALORES INICIALES
        PictureBox1.Image = BM1
        Panel1.AutoScrollPosition = New Point(0, 0)

    End Sub







'SCROLL MOUSE -------------------------------------------------------------------------------------
'Private Sub PictureBox_MouseWheel(ByVal sender As System.Object,
'                             ByVal e As MouseEventArgs)
'    If e.Delta <> 0 Then
'        If e.Delta <= 0 Then
'            If PictureBox1.Width < 500 Then Exit Sub 'minimum 500?
'        Else
'            If PictureBox1.Width > 2000 Then Exit Sub 'maximum 2000?
'        End If
'
'            PictureBox1.Width += CInt(PictureBox1.Width * e.Delta / 1000)
'            PictureBox1.Height += CInt(PictureBox1.Height * e.Delta / 1000)
'        End If
'
'    End Sub
'--------------------------------------------------------------------------------------------


'Metodo imprimir
Private Sub imprimir()
    If MsgBox("¿Desea Imprimir la Imagen Seleccionada?", vbYesNo + vbQuestion) = vbYes Then
        Dim oPrintDoc As PrintDocument = New PrintDocument()
        AddHandler oPrintDoc.PrintPage, AddressOf ImprimirGrafico
        oPrintDoc.Print()
    Else
    End If
End Sub

'funcion imprimirGrafico -------------------------------------------------------------------------------------------
Private Sub ImprimirGrafico(ByVal sender As Object, ByVal e As PrintPageEventArgs)
    ' recuperar la imagen del PictureBox
    Dim oImagenBmp As Bitmap = Me.PictureBox1.Image
    ' pintamos la imagen en el dispositivo que la mostrará,
    ' en este caso la impresora
    e.Graphics.DrawImage(oImagenBmp, _
    e.MarginBounds.Left, _
    e.MarginBounds.Top, _
    e.MarginBounds.Width, _
    e.MarginBounds.Height)
End Sub

Private Sub botonImprime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botonImprime.Click
    imprimir()
End Sub

Private Sub botonVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botonVolver.Click
    Me.Close()
End Sub
End Class