Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data
Imports System.Drawing.Imaging
Imports System.Drawing.Printing

Public Class ConsultaSolicitudReintegro
    Dim Conex As New MySqlConnection(CADENABASE2)
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand

    Private Sub ConsultaSolicitudReintegro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
    
 
    End Sub

    Private Sub ConsultaSolicitudReintegro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        apagaFecha()
        llenarGridCompleto()
        txtBeneficiario.Focus()
        txtFechaDesde.Enabled = False
        txtFechaHasta.Enabled = False
        'GridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        'GridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        'GridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode
        'Referenciamos la columna
        'Dim col As DataGridViewColumn = GridView1.Columns("reintegros.imagen1")
        'Ajustamos la celda a su contenido.
        'col.DefaultCellStyle.WrapMode = DataGridViewTriState.True
    End Sub


    'Metodo llena grid boo
    Private Sub llenarGridCompleto()
        Try
            'SI QUIERO VER LO QUE CARGAN TODOS LOS USUARIOS DE ESA SECCIONAL (TODOS LOS USER DE ESA SECCIONAL)
            sql = "SELECT reintegros.codigo_usuario,codigo_reintegro,codigo_beneficiario,fecha_solicitud,detalle,importe,observaciones_carga,usuarios_reintegros.ApellidoNombre,usuarios_reintegros.tipo_usuario,usuarios_reintegros.codigo_seccional,reintegros.imagen1,reintegros.imagen2,reintegros.imagen3,reintegros.imagen4,reintegros.imagen5 FROM REINTEGROS,USUARIOS_REINTEGROS WHERE (REINTEGROS.CODIGO_USUARIO = USUARIOS_REINTEGROS.CODIGO_USUARIO) AND USUARIOS_REINTEGROS.Codigo_Seccional = '" & VariableGlobalSeccional.ToString & "'"

            'SI QUIERO VER SOLO LO QUE CARGA EL USUARIO LOGUEADO
            'sql = "SELECT Codigo_Reintegro,Codigo_Beneficiario,Fecha_Solicitud,Detalle,Importe,Observaciones_Carga,Imagen1" & _
            '         " FROM reintegros WHERE Codigo_Usuario = '" & VariableGlobalUsuario.ToString & "'"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView1.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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

    Private Sub Boton_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Boton_Salir.Click
        Me.Close()
    End Sub

    Private Sub txtBeneficiario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBeneficiario.TextChanged
        BuscarDato()
    End Sub

    Private Sub BuscarDato()
        Try
            If txtFechaDesde.Text = "" And txtFechaDesde.Text = "" Then
                sql = "SELECT reintegros.codigo_usuario,codigo_reintegro,codigo_beneficiario,fecha_solicitud,detalle,importe,observaciones_carga,imagen1,usuarios_reintegros.ApellidoNombre,usuarios_reintegros.tipo_usuario,usuarios_reintegros.codigo_seccional" & _
                     " FROM REINTEGROS,USUARIOS_REINTEGROS WHERE (REINTEGROS.CODIGO_USUARIO = USUARIOS_REINTEGROS.CODIGO_USUARIO) AND USUARIOS_REINTEGROS.Codigo_Seccional = '" & VariableGlobalSeccional & "' AND Detalle LIKE '%" & txtBeneficiario.Text.ToString & "%'"
            Else

                sql = "SELECT reintegros.codigo_usuario,codigo_reintegro,codigo_beneficiario,fecha_solicitud,detalle,importe,observaciones_carga,imagen1,usuarios_reintegros.ApellidoNombre,usuarios_reintegros.tipo_usuario,usuarios_reintegros.codigo_seccional " & _
                     "FROM REINTEGROS,USUARIOS_REINTEGROS WHERE (REINTEGROS.CODIGO_USUARIO = USUARIOS_REINTEGROS.CODIGO_USUARIO) AND USUARIOS_REINTEGROS.Codigo_Seccional = '" & VariableGlobalSeccional & "' AND Detalle LIKE '%" & txtBeneficiario.Text.ToString & "%' AND (Fecha_Solicitud BETWEEN '" & txtFechaDesde.Text.ToString & "' AND '" & txtFechaHasta.Text.ToString & "')"
            End If
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFechaHasta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFechaHasta.TextChanged
        BuscarDato()
    End Sub

    Private Sub txtFechaDesde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFechaDesde.TextChanged
        BuscarDato()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        txtFechaDesde.Text = DateTimePicker1.Value.Year & "-" & DateTimePicker1.Value.Month & "-" & DateTimePicker1.Value.Day
        txtFechaHasta.Text = DateTimePicker2.Value.Year & "-" & DateTimePicker2.Value.Month & "-" & DateTimePicker2.Value.Day
        BuscarDato()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        txtFechaDesde.Text = DateTimePicker1.Value.Year & "-" & DateTimePicker1.Value.Month & "-" & DateTimePicker1.Value.Day
        txtFechaHasta.Text = DateTimePicker2.Value.Year & "-" & DateTimePicker2.Value.Month & "-" & DateTimePicker2.Value.Day
        BuscarDato()
    End Sub
    'metodo limpia fecha
    Private Sub limpiafechas()
        txtFechaDesde.Text = ""
        txtFechaHasta.Text = ""
    End Sub

    '*******************************************************************************************************************************************************
    'click en celda llena listbox con imagenes
    Private Sub GridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridView1.CellClick
        clbimagen.Items.Clear()
        lblPicture.Image = Nothing
        Dim SQL2 As String
        Dim MiConexion2 As New MySqlConnection(CADENABASE2)
        Dim Rs2 As MySqlDataReader
        Dim Com2 As New MySqlCommand
        Com2.Connection = MiConexion2
        MiConexion2.Open()
        SQL2 = "select Imagen1,Imagen2,Imagen3,Imagen4,Imagen5 from reintegros where codigo_reintegro = '" & Me.GridView1.Rows(e.RowIndex).Cells(1).Value & "'"
        Com2 = New MySqlCommand(SQL2, MiConexion2)
        Rs2 = Com2.ExecuteReader()
        Rs2.Read()
        'lleno el list siempre y cuando no sea null
        For i = 0 To 4
            If Rs2(i).Equals(DBNull.Value) Then
                'clbimagen.Items.Add("NO IMAGE")
            Else
                Dim bits As Byte() = CType(Rs2(i), Byte())
                Dim memorybits As New System.IO.MemoryStream(bits)
                Dim bitmap As New Bitmap(memorybits)
                clbimagen.Items.Add(bitmap)
            End If
        Next
    End Sub

    'click en celda llena listbox con imagenes
    Private Sub GridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridView1.CellContentClick
        clbimagen.Items.Clear()
        lblPicture.Image = Nothing
        Dim SQL2 As String
        Dim MiConexion2 As New MySqlConnection(CADENABASE2)
        Dim Rs2 As MySqlDataReader
        Dim Com2 As New MySqlCommand
        Com2.Connection = MiConexion2
        MiConexion2.Open()
        SQL2 = "select Imagen1,Imagen2,Imagen3,Imagen4,Imagen5 from reintegros where codigo_reintegro = '" & Me.GridView1.Rows(e.RowIndex).Cells(1).Value & "'"
        Com2 = New MySqlCommand(SQL2, MiConexion2)
        Rs2 = Com2.ExecuteReader()
        Rs2.Read()
        'lleno el list siempre y cuando no sea null
        For i = 0 To 4
            If Rs2(i).Equals(DBNull.Value) Then
                'clbimagen.Items.Add("NO IMAGE")
            Else
                Dim bits As Byte() = CType(Rs2(i), Byte())
                Dim memorybits As New System.IO.MemoryStream(bits)
                Dim bitmap As New Bitmap(memorybits)
                clbimagen.Items.Add(bitmap)
            End If
        Next
    End Sub
    '*******************************************************************************************************************************************************

    'VISTA PREVIA DEL PICTUREBOX AL SELECCIONAR EN EL COMBOLIST
    Private Sub clbimagen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbimagen.SelectedIndexChanged
        Try
            lblPicture.Image = clbimagen.SelectedItem
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GridView1_CellContextMenuStripChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridView1.CellContextMenuStripChanged
        clbimagen.Items.Clear()
        clbimagen.Items.Add(DeImagen_a_Bytes(Me.GridView1.Rows(e.RowIndex).Cells(10).Value))
        clbimagen.Items.Add(DeImagen_a_Bytes(Me.GridView1.Rows(e.RowIndex).Cells(11).Value))
        clbimagen.Items.Add(DeImagen_a_Bytes(Me.GridView1.Rows(e.RowIndex).Cells(12).Value))
        clbimagen.Items.Add(DeImagen_a_Bytes(Me.GridView1.Rows(e.RowIndex).Cells(13).Value))
        clbimagen.Items.Add(DeImagen_a_Bytes(Me.GridView1.Rows(e.RowIndex).Cells(14).Value))
    End Sub



    'doble click en imagen --- IMPRIMIR
    Private Sub lblPicture_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblPicture.DoubleClick
        FormularioImagen.PictureBox1.Image = Me.lblPicture.Image
        FormularioImagen.Show()
    End Sub



    Private Sub ImprimirGrafico(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        ' recuperar la imagen del PictureBox
        Dim oImagenBmp As Bitmap = Me.lblPicture.Image
        ' pintamos la imagen en el dispositivo que la mostrará,
        ' en este caso la impresora
        e.Graphics.DrawImage(oImagenBmp, _
        e.MarginBounds.Left, _
        e.MarginBounds.Top, _
        e.MarginBounds.Width, _
        e.MarginBounds.Height)
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' e.Graphics.DrawImage(lblPicture.Image, 10, 20, 900, 920)
    End Sub

    'IMPRIMIR
    Private Sub imprimir()
        If MsgBox("¿Desea Imprimir la Imagen Seleccionada?", vbYesNo + vbQuestion) = vbYes Then
            Dim oPrintDoc As PrintDocument = New PrintDocument()
            AddHandler oPrintDoc.PrintPage, AddressOf ImprimirGrafico
            oPrintDoc.Print()
        Else
        End If
    End Sub

    Private Sub lblPicture_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblPicture.Click

    End Sub

    Private Sub lblPicture_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
End Class






