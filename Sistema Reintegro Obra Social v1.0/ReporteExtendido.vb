Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data
Imports System.Drawing.Imaging
Imports System.Drawing.Printing



Public Class ReporteExtendido
    Dim Conex As New MySqlConnection(CADENABASE2)
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand

    Private Sub llenarGridCompleto() '>>>>>>>>>>>
        Try
            If Reportes.txtFechaDesde.Text = "" And Reportes.txtFechaHasta.Text = "" Then
                sql = "select usuarios_reintegros.apellidonombre as USER,reintegros.codigo_reintegro AS REINTEGRO,reintegros.detalle AS DETALLE,reintegros.importe AS IMPORTE," & _
                    "reintegros.fecha_reintegro from usuarios_reintegros left join reintegros on " & _
                "(usuarios_reintegros.codigo_usuario=reintegros.codigo_usuario)" & _
                " where (reintegros.codigo_Usuario= '" & lblNumReintegro.Text.ToString & "') "
            Else
                sql = "select usuarios_reintegros.apellidonombre AS USER,reintegros.codigo_reintegro AS REINTEGRO,reintegros.detalle AS DETALLE,reintegros.importe AS IMPORTE," & _
                    "reintegros.fecha_reintegro from usuarios_reintegros left join reintegros on " & _
                "(usuarios_reintegros.codigo_usuario=reintegros.codigo_usuario)" & _
                " where (reintegros.codigo_Usuario= '" & lblNumReintegro.Text & "') AND (reintegros.fecha_reintegro between '" & Reportes.txtFechaDesde.Text & "' and '" & Reportes.txtFechaHasta.Text & "')"
            End If
            

            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridViewExtendReporte.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub ReporteExtendido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGridCompleto()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub botonExcel_Click(sender As Object, e As EventArgs) Handles botonExcel.Click
        GridAExcel(GridViewExtendReporte)
    End Sub

    Private Sub GridViewExtendReporte_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridViewExtendReporte.CellContentClick

    End Sub

    Private Sub GridViewExtendReporte_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles GridViewExtendReporte.RowsAdded
        lblUsuarioseccional.Text = GridViewExtendReporte.Rows(0).Cells(0).Value.ToString()
    End Sub
End Class