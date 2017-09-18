
Module Module1
    Public VariableGlobalUsuario As String
    Public VariableGlobalSeccional As Integer
    Public variableControl As Integer = 0
    Public VariableGlobalBeneficiario As String
    Public VariableGlobalCuilBeneficiario As String
    Public VariableGlobalModificacion As String
    Public VariableGlobalReintegroModif As String
    Public VariableGlobalFechaHOY As String
    Public VariableGlobalHoraHOY As String
    Public VarHistorialReintegro As String
    Public Sub fechaHoy()
        VariableGlobalFechaHOY = DateTime.Now.Year & "-" & DateTime.Now.Month & "-" & DateTime.Now.Day
        VariableGlobalHoraHOY = DateTime.Now.TimeOfDay.Hours & ":" & DateTime.Now.TimeOfDay.Minutes & ":" & DateTime.Now.TimeOfDay.Seconds
    End Sub


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


    Public Function GridAExcel(ByVal DGV As DataGridView) As Boolean

        'Creamos las variables

        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try

            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = DGV.ColumnCount
            Dim NRow As Integer = DGV.RowCount
            'recorremos todas las filas, y por cada fila todas las columnas
            'y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = DGV.Columns(i - 1).DataPropertyName.ToString
            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) =
                    DGV.Rows(Fila).Cells(Col).Value()
                Next

            Next

            'Titulo en negrita, Alineado
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()
            'para visualizar el libro
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")

            Return False
        End Try
        Return True
    End Function

End Module
