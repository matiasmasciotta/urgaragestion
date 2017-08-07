Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data


Public Class Consulta
    Dim Conex As New MySqlConnection(CADENABASE2)
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand

    '*******************************************************************************************************************************


    'PRESIONAR BOTON GENERAR REPORTE PDF
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            'Intentar generar el documento.
            Dim doc As New Document(PageSize.A4.Rotate(), 10, 10, 10, 10)
            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Lista de Reintegros.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF(doc)
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    '********************************************************************************************************************************

    Private Sub Consulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        apagaFecha()
        llenarGrid()
        txtBeneficiario.Focus()
    End Sub


    'Metodo llena grid boo
    Private Sub llenarboo()
        Try
            'FECHA OFF -- URGARA OFF -- OBRA SOCIAL OFF
            If (checkFecha.Checked = False) And (checkUrgara.Checked = False) And (checkObraSocial.Checked = False) Then
                sql = "SELECT Codigo_Reintegro,Codigo_Beneficiario,Fecha_Solicitud,Autorizante,A_Cargo,Auditor_Medico,Detalle," & _
                      "Importe,Porcentaje_Reintegro from reintegros WHERE Codigo_Beneficiario LIKE '%" & txtBeneficiario.Text.ToString & "%'"
            End If
            'FECHA ON -- URGARA OFF -- OBRA SOCIAL OFF
            If (checkFecha.Checked = True) And (checkUrgara.Checked = False) And (checkObraSocial.Checked = False) Then
                sql = "SELECT Codigo_Reintegro,Codigo_Beneficiario,Fecha_Solicitud,Autorizante,A_Cargo,Auditor_Medico,Detalle," & _
                     "Importe,Porcentaje_Reintegro from reintegros WHERE Codigo_Beneficiario LIKE '%" & txtBeneficiario.Text.ToString & "%'" & _
                     "AND Fecha_Solicitud BETWEEN '" & txtFechaDesde.Text.ToString & "' AND '" & txtFechaHasta.Text.ToString & "'"
            End If
            'FECHA ON -- URGARA ON -- OBRA SOCIAL OFF
            If (checkFecha.Checked = True) And (checkUrgara.Checked = True) And (checkObraSocial.Checked = False) Then
                sql = "SELECT Codigo_Reintegro,Codigo_Beneficiario,Fecha_Solicitud,Autorizante,A_Cargo,Auditor_Medico,Detalle," & _
                      "Importe,Porcentaje_Reintegro from reintegros WHERE Codigo_Beneficiario LIKE '%" & txtBeneficiario.Text.ToString & "%'" & _
                      "AND A_Cargo = '1' AND Fecha_Solicitud BETWEEN '" & txtFechaDesde.Text.ToString & "' AND '" & txtFechaHasta.Text.ToString & "'"
            End If
            'FECHA ON -- URGARA ON -- OBRA SOCIAL ON 
            If (checkFecha.Checked = True) And (checkUrgara.Checked = True) And (checkObraSocial.Checked = True) Then
                sql = "SELECT Codigo_Reintegro,Codigo_Beneficiario,Fecha_Solicitud,Autorizante,A_Cargo,Auditor_Medico,Detalle," & _
                      "Importe,Porcentaje_Reintegro from reintegros WHERE Codigo_Beneficiario LIKE '%" & txtBeneficiario.Text.ToString & "%'" & _
                      "AND Fecha_Solicitud BETWEEN '" & txtFechaDesde.Text.ToString & "' AND '" & txtFechaHasta.Text.ToString & "'"
            End If
            'FECHA ON -- URGARA OFF -- OBRA SOCIAL ON
            If (checkFecha.Checked = True) And (checkUrgara.Checked = False) And (checkObraSocial.Checked = True) Then
                sql = "SELECT Codigo_Reintegro,Codigo_Beneficiario,Fecha_Solicitud,Autorizante,A_Cargo,Auditor_Medico,Detalle," & _
                      "Importe,Porcentaje_Reintegro from reintegros WHERE Codigo_Beneficiario LIKE '%" & txtBeneficiario.Text.ToString & "%'" & _
                      "AND A_Cargo ='0' AND Fecha_Solicitud BETWEEN '" & txtFechaDesde.Text.ToString & "' AND '" & txtFechaHasta.Text.ToString & "'"
            End If
            'FECHA OFF -- URGARA ON -- OBRA SOCIAL ON
            If (checkFecha.Checked = False) And (checkUrgara.Checked = True) And (checkObraSocial.Checked = True) Then
                sql = "SELECT Codigo_Reintegro,Codigo_Beneficiario,Fecha_Solicitud,Autorizante,A_Cargo,Auditor_Medico,Detalle," & _
                      "Importe,Porcentaje_Reintegro from reintegros WHERE Codigo_Beneficiario LIKE '%" & txtBeneficiario.Text.ToString & "%'" & _
                      ""
            End If
            'FECHA OFF -- URGARA OFF -- OBRA SOCIAL ON
            If (checkFecha.Checked = False) And (checkUrgara.Checked = False) And (checkObraSocial.Checked = True) Then
                sql = "SELECT Codigo_Reintegro,Codigo_Beneficiario,Fecha_Solicitud,Autorizante,A_Cargo,Auditor_Medico,Detalle," & _
                      "Importe,Porcentaje_Reintegro from reintegros WHERE Codigo_Beneficiario LIKE '%" & txtBeneficiario.Text.ToString & "%'" & _
                      " AND A_Cargo ='0' "
            End If
            'FECHA OFF -- URGARA ON -- OBRA SOCIAL OFF
            If (checkFecha.Checked = False) And (checkUrgara.Checked = True) And (checkObraSocial.Checked = False) Then
                sql = "SELECT Codigo_Reintegro,Codigo_Beneficiario,Fecha_Solicitud,Autorizante,A_Cargo,Auditor_Medico,Detalle," & _
                      "Importe,Porcentaje_Reintegro from reintegros WHERE Codigo_Beneficiario LIKE '%" & txtBeneficiario.Text.ToString & "%'" & _
                      "AND A_Cargo = '1'"
            End If
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    '@Metodo llena grid sin filtro
    Private Sub llenarGrid()
        Try
            sql = "SELECT Codigo_Reintegro,Codigo_Beneficiario,Fecha_Solicitud,Autorizante,A_Cargo,Auditor_Medico,Detalle," & _
                  "Importe,Porcentaje_Reintegro,Imagen1 from reintegros WHERE Codigo_Beneficiario LIKE '%" & txtBeneficiario.Text.ToString & "%'"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '@Metodo llena grid con filtro fecha
    Private Sub llenarGridFecha()
        Try
            sql = "SELECT Codigo_Reintegro,Codigo_Beneficiario,Fecha_Solicitud,Autorizante,A_Cargo,Auditor_Medico,Detalle," & _
                  "Importe,Porcentaje_Reintegro,Imagen1 from reintegros WHERE Codigo_Beneficiario LIKE '%" & txtBeneficiario.Text.ToString & "%'" & _
                  "AND Fecha_Solicitud BETWEEN '" & txtFechaDesde.Text.ToString & "' AND '" & txtFechaHasta.Text.ToString & "'"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtBeneficiario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBeneficiario.TextChanged
        llenarboo()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    'CHECK DE FECHA ACTIVADO O DESACTIVADO
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkFecha.CheckedChanged
        If checkFecha.Checked = True Then
            'MsgBox("CHECK ACTIVO FECHA", vbInformation)
            prendeFecha()
        Else
            'MsgBox("CHECK DESACTIVADO FECHA", vbInformation)
            apagaFecha()
        End If
    End Sub

    'Metodo activa textbox y label de fecha
    Private Sub prendeFecha()
        txtFechaDesde.Visible = True
        txtFechaHasta.Visible = True
        Label2.Visible = True
        Label3.Visible = True
    End Sub

    'Metodo oculta textbox y label de fecha
    Private Sub apagaFecha()
        txtFechaDesde.Visible = False
        txtFechaHasta.Visible = False
        Label2.Visible = False
        Label3.Visible = False
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkUrgara.CheckedChanged
        llenarboo()
    End Sub

    Private Sub checkObraSocial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkObraSocial.CheckedChanged
        llenarboo()
    End Sub

    Private Sub txtFechaDesde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFechaDesde.TextChanged
        llenarboo()
    End Sub

    Private Sub txtFechaHasta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFechaHasta.TextChanged
        llenarboo()
    End Sub

    '*********************************************************************************************
    '*****************************PROCESO DE GENERACION DEL REPORTE PDF **************************
    '*********************************************************************************************

    'La funcion se usara en el metodo para crear el reporte en PDF.
    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        Dim values As Single() = New Single(GridView1.ColumnCount - 1) {}
        For i As Integer = 0 To GridView1.ColumnCount - 1
            values(i) = CSng(GridView1.Columns(i).Width)
        Next
        Return values
    End Function

    'Creamos un proceso para crear el reporte
    '   ***************************************************
    Public Sub ExportarDatosPDF(ByVal document As Document)
        'Se crea un objeto PDFTable con el numero de columnas del DataGridView. 
        Dim datatable As New PdfPTable(GridView1.ColumnCount)
        'Se asignan algunas propiedades para el diseño del PDF.
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(GridView1)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 50
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        'Se crea el encabezado en el PDF. 
        Dim encabezado As New Paragraph("** REINTEGROS OBRA SOCIAL **:", New Font(Font.Name = "Tahoma", 20, Font.Bold))

        'Se crea el texto abajo del encabezado.
        Dim texto As New Phrase("Reporte de Reintegros:" + Now.Date(), New Font(Font.Name = "Tahoma", 14, Font.Bold))
        'Se capturan los nombres de las columnas del DataGridView.
        For i As Integer = 0 To GridView1.ColumnCount - 1
            datatable.AddCell(GridView1.Columns(i).HeaderText)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1

        For i As Integer = 0 To GridView1.Rows.Count - 2
            For j As Integer = 0 To GridView1.Columns.Count - 1
                datatable.AddCell((GridView1(j, i).Value).ToString)
            Next
            datatable.CompleteRow()
        Next
        'da 2 tab entre columnas
        datatable.AddCell("   ")
        datatable.AddCell("   ")
        'imprime resultados
        datatable.AddCell(GridView1(2, 6).Value)
        datatable.AddCell(GridView1(3, 6).Value)
        datatable.CompleteRow()
        'Se agrega etiquetas
        document.Add(encabezado)
        document.Add(texto)
        document.Add(datatable)

    End Sub
    '*********************************************************************************************
    '******************************** TERMINA CODIGO REPORTE PDF *********************************
    '*********************************************************************************************

    'BOTON GENERAR REPORTE
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            'Intentar generar el documento.
            Dim doc As New Document(PageSize.LEGAL.Rotate(), 10, 10, 10, 10)
            'Path que guarda el reporte en el escritorio de windows (Desktop).
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\ReporteReintegros.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF(doc)
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            'Si el intento es fallido, mostrar MsgBox.
            MessageBox.Show("No se puede generar el documento PDF.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
