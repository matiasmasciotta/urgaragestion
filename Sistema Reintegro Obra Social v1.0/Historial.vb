Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data
Imports System.Drawing.Imaging
Imports System.Drawing.Printing

Public Class Historial

    Dim Conex As New MySqlConnection(CADENABASE2)
    Dim conexion As New MySqlConnection(CADENABASE2)
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Dim varCodigoreintegro As String
    Dim varSQLCAMPOS As String = "apellidonombre,codigo_reintegro,fecha_modificacion,hora,detalle"

    Private Sub Historial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            sql = "select " & varSQLCAMPOS & " from historial_reintegros,usuarios_reintegros where (historial_reintegros.codigo_usuario = usuarios_reintegros.codigo_usuario) and (codigo_reintegro = '" & VarHistorialReintegro & "')"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub botonExcel_Click(sender As Object, e As EventArgs) Handles botonExcel.Click
        GridAExcel(GridView1)
    End Sub

    Private Sub etiquetear()
        ToolTip1.SetToolTip(botonExcel, "Exportar Listado a Excel")
    End Sub

    Private Sub botonExcel_MouseHover(sender As Object, e As EventArgs) Handles botonExcel.MouseHover
        etiquetear()
    End Sub

    Private Sub botonExcel_MouseMove(sender As Object, e As MouseEventArgs) Handles botonExcel.MouseMove
        botonExcel.Image = WindowsApplication1.My.Resources.Resources.logo2excel
    End Sub

    Private Sub Historial_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter

    End Sub

    Private Sub Historial_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        botonExcel.Image = WindowsApplication1.My.Resources.Resources.logoexcelsistemaa
    End Sub
End Class