
Module Module1
    Public VariableGlobalUsuario As String
    Public VariableGlobalSeccional As Integer
    Public variableControl As Integer = 0

    'FICHERO TXT BASE *********lee ***
    Public CADENABASE2 As String



    ' Funcion para convertir imagen del picture box a bits y jpeg
    Public Function DeImagen_a_Bytes(ByVal Imagen As Image) As Byte()
        If Not Imagen Is Nothing Then
            'Crea un archivo temporal de cero bytes y nombre único en el disco y devuelve la ruta
            'de acceso completa a ese archivo.
            Dim ATemporal As String = IO.Path.GetTempFileName()
            'Inicializa una nueva instancia de la clase FileStream con el permiso de lectura/escritura,
            'el modo de creación y la ruta de acceso especificados.
            Dim filestream As New IO.FileStream(ATemporal, IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite)
            'Puede modificar el formato de la imagen a la hora de salvarla.
            Imagen.Save(filestream, System.Drawing.Imaging.ImageFormat.Jpeg)
            filestream.Position = 0
            Dim imgLength As Integer = CInt(filestream.Length)
            Dim bytes(0 To imgLength - 1) As Byte
            filestream.Read(bytes, 0, imgLength)
            filestream.Close()
            Return bytes
        Else
            Return Nothing
        End If
    End Function


    Public Sub effecIn()
        Dim effect As Integer
        For effect = 0 To 1
            MenuPrincipal.Opacity = effect
            MenuPrincipal.Refresh()
            Threading.Thread.Sleep(20)
        Next
    End Sub

    Public Sub effecOut()
        Dim effect As Double
        For effect = 1.1 To 0.0 Step -0.1
            MenuPrincipal.Opacity = effect
            MenuPrincipal.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub

End Module
