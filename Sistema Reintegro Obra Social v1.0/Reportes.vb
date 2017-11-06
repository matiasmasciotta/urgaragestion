Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data
Imports System.Drawing.Imaging
Imports System.Drawing.Printing



Public Class Reportes
    Dim Conex As New MySqlConnection(CADENABASE2)
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Dim varSQLCAMPOS As String = "reintegros.codigo_Usuario,usuarios_reintegros.ApellidoNombre,usuarios_reintegros.codigo_seccional,seccionales.Descripcion,sum(reintegros.importe)"
    '(00)reintegros.codigo_Usuario
    '(01)usuarios_reintegros.ApellidoNombre
    '(02)usuarios_reintegros.codigo_seccional
    '(03)seccionales.Descripcion,
    '(04)sum(reintegros.importe) 


    'Metodo llena grid boo
    Private Sub llenarGridCompleto() '>>>>>>>>>>>
        Try
            sql = "SELECT " & varSQLCAMPOS & "FROM reintegros LEFT JOIN usuarios_reintegros ON (reintegros.codigo_usuario = usuarios_reintegros.codigo_usuario) " & _
                "LEFT JOIN seccionales ON (usuarios_reintegros.Codigo_Seccional=Seccionales.Codigo) WHERE (reintegros.auditor_medico = 1) AND (reintegros.Estado = 1) " & _
                "AND (reintegros.Pagado = 1) GROUP BY reintegros.codigo_Usuario"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BuscarDato()
        'Filtra los Pendientes de Auditoria Medica (GRID 1)
        Try
            If (txtFechaDesde.Text = "") And (txtFechaDesde.Text = "") Then
                sql = "SELECT " & varSQLCAMPOS & "FROM reintegros LEFT JOIN usuarios_reintegros ON (reintegros.codigo_usuario = usuarios_reintegros.codigo_usuario) " & _
                "LEFT JOIN seccionales ON (usuarios_reintegros.Codigo_Seccional=Seccionales.Codigo) WHERE (reintegros.auditor_medico = 1) AND (reintegros.Estado = 1) " & _
                "AND (reintegros.Pagado = 1) AND (Usuarios_Reintegros.Codigo_seccional like '%" & txtSeccional.Text & "%') GROUP BY reintegros.codigo_Usuario"
            Else
                sql = "SELECT " & varSQLCAMPOS & "FROM reintegros LEFT JOIN usuarios_reintegros ON (reintegros.codigo_usuario = usuarios_reintegros.codigo_usuario) " & _
                "LEFT JOIN seccionales ON (usuarios_reintegros.Codigo_Seccional=Seccionales.Codigo) WHERE (reintegros.auditor_medico = 1) AND (reintegros.Estado = 1) " & _
                "AND (reintegros.Pagado = 1) AND " & _
                    "(Fecha_Solicitud BETWEEN '" & txtFechaDesde.Text.ToString & "' AND '" & txtFechaHasta.Text.ToString & "') AND (Usuarios_Reintegros.Codigo_seccional " & _
                    "like '%" & txtSeccional.Text & "%') GROUP BY reintegros.codigo_Usuario"
            End If
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        txtFechaDesde.Text = DateTimePicker1.Value.Year & "-" & DateTimePicker1.Value.Month & "-" & DateTimePicker1.Value.Day
        txtFechaHasta.Text = DateTimePicker2.Value.Year & "-" & DateTimePicker2.Value.Month & "-" & DateTimePicker2.Value.Day
        'BuscarDato()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        txtFechaDesde.Text = DateTimePicker1.Value.Year & "-" & DateTimePicker1.Value.Month & "-" & DateTimePicker1.Value.Day
        txtFechaHasta.Text = DateTimePicker2.Value.Year & "-" & DateTimePicker2.Value.Month & "-" & DateTimePicker2.Value.Day
        'BuscarDato()
    End Sub
    'metodo limpia fecha
    Private Sub limpiafechas()
        txtFechaDesde.Text = ""
        txtFechaHasta.Text = ""
    End Sub

    'CHECK DE FECHA ACTIVADO O DESACTIVADO
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkFecha.CheckedChanged
        If checkFecha.Checked = True Then
            'MsgBox("CHECK ACTIVO FECHA", vbInformation)
            prendeFecha()
        Else
            'MsgBox("CHECK DESACTIVADO FECHA", vbInformation)
            apagaFecha()
            limpiafechas()
        End If
    End Sub

    'Metodo activa textbox y label de fecha
    Private Sub prendeFecha()
        txtFechaDesde.Visible = True
        txtFechaHasta.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        DateTimePicker1.Visible = True
        DateTimePicker2.Visible = True
        lblfechadesde.Visible = True
        lblfechahasta.Visible = True
    End Sub

    'Metodo oculta textbox y label de fecha
    Private Sub apagaFecha()
        txtFechaDesde.Visible = False
        txtFechaHasta.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        DateTimePicker1.Visible = False
        DateTimePicker2.Visible = False
        lblfechadesde.Visible = False
        lblfechahasta.Visible = False
    End Sub

    Private Sub Reportes_Click(sender As Object, e As EventArgs) Handles Me.Click
        DataGridSeccionales.Visible = False
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarGridCompleto()
        'carga grid seccionales
        Try
            sql = "SELECT codigo,descripcion from seccionales"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            DataGridSeccionales.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Boton_Salir_Click(sender As Object, e As EventArgs) Handles Boton_Salir.Click
        Me.Close()
    End Sub

    Private Sub txtFechaDesde_TextChanged(sender As Object, e As EventArgs) Handles txtFechaDesde.TextChanged
        BuscarDato()
    End Sub

    Private Sub txtFechaHasta_TextChanged(sender As Object, e As EventArgs) Handles txtFechaHasta.TextChanged
        BuscarDato()
    End Sub

    Private Sub txtSeccional_MouseHover(sender As Object, e As EventArgs)
        ToolTip1.SetToolTip(txtSeccional, "Doble click para seleccionar Seccional")
    End Sub

    

    Private Sub botonExcel_Click(sender As Object, e As EventArgs) Handles botonExcel.Click
        GridAExcel(GridView1)
    End Sub

    Private Sub botonExcel_MouseHover(sender As Object, e As EventArgs) Handles botonExcel.MouseHover
        ToolTip1.SetToolTip(botonExcel, "Click - Reporte en Excel")
    End Sub

    Private Sub txtSeccional_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles txtSeccional.MouseDoubleClick
        DataGridSeccionales.Visible = True
    End Sub

  
    Private Sub txtSeccional_TextChanged(sender As Object, e As EventArgs) Handles txtSeccional.TextChanged
        BuscarDato()
    End Sub

    Private Sub DataGridSeccionales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridSeccionales.CellClick
        Try
            txtSeccional.Text = Me.DataGridSeccionales.Rows(e.RowIndex).Cells(0).Value
        Catch
        End Try
    End Sub

    Private Sub DataGridSeccionales_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridSeccionales.CellContentClick
        Try
            txtSeccional.Text = Me.DataGridSeccionales.Rows(e.RowIndex).Cells(0).Value
        Catch
        End Try
    End Sub

    Private Sub DataGridSeccionales_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridSeccionales.CellContentDoubleClick
        DataGridSeccionales.Visible = False
    End Sub

    Private Sub DataGridSeccionales_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridSeccionales.CellDoubleClick
        DataGridSeccionales.Visible = False
    End Sub

    Private Sub Reportes_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        DataGridSeccionales.Visible = False
    End Sub
End Class