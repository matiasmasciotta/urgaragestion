Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data
Imports System.Drawing.Imaging
Imports System.Drawing.Printing

Public Class FormularioAuditor
    Dim Conex As New MySqlConnection(CADENABASE2)
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Dim varCodigoreintegro As String
    Dim varCodigoreintegroAprobado As String
    Dim varCodigoreintegroRechazado As String
    Dim varSQLCAMPOS As String = "reintegros.codigo_usuario,codigo_reintegro,codigo_beneficiario,fecha_solicitud,detalle,importe,observaciones_carga, " & _
                              "usuarios_reintegros.ApellidoNombre,usuarios_reintegros.tipo_usuario,usuarios_reintegros.codigo_seccional,reintegros.CBU," & _
                              "reintegros.Alias,reintegros.tipo_reintegro,reintegros.id_Subsidio,reintegros.Pagado,reintegros.Cuil_Pago,reintegros.tipo_cuenta,cuil_beneficiario "
    Dim varAudMed As Integer
    Dim det As String = ""
    Private Sub FormularioAuditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        apagaFecha()
        llenarGridCompleto()
        txtBeneficiario.Focus()
        txtFechaDesde.Enabled = False
        txtFechaHasta.Enabled = False
    End Sub

    Private Sub llenarGridCompleto() '>>>>>>>>>>>
        'grid pendientes
        Try
            sql = "SELECT " & varSQLCAMPOS & "FROM REINTEGROS,USUARIOS_REINTEGROS WHERE (REINTEGROS.CODIGO_USUARIO = USUARIOS_REINTEGROS.CODIGO_USUARIO) " & _
                    "AND (Auditor_Medico = 0) order by fecha_solicitud desc"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'grid aprobados 
        Try
            sql = "SELECT " & varSQLCAMPOS & "FROM REINTEGROS,USUARIOS_REINTEGROS WHERE (REINTEGROS.CODIGO_USUARIO = USUARIOS_REINTEGROS.CODIGO_USUARIO) " & _
                    "AND (Auditor_Medico = 1) order by fecha_solicitud desc"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView2.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'grid rechazados
        Try
            sql = "SELECT " & varSQLCAMPOS & "FROM REINTEGROS,USUARIOS_REINTEGROS WHERE (REINTEGROS.CODIGO_USUARIO = USUARIOS_REINTEGROS.CODIGO_USUARIO) " & _
                    "AND (Auditor_Medico = 2) order by fecha_solicitud desc"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView3.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub BuscarDato()
        Try
            If txtFechaDesde.Text = "" And txtFechaDesde.Text = "" Then
                sql = "SELECT " & varSQLCAMPOS & "FROM REINTEGROS,USUARIOS_REINTEGROS WHERE (REINTEGROS.CODIGO_USUARIO = USUARIOS_REINTEGROS.CODIGO_USUARIO) " & _
                    "AND Detalle LIKE '%" & txtBeneficiario.Text.ToString & "%' and Auditor_medico=0)"
            Else
                sql = "SELECT " & varSQLCAMPOS & "FROM REINTEGROS,USUARIOS_REINTEGROS WHERE (REINTEGROS.CODIGO_USUARIO = USUARIOS_REINTEGROS.CODIGO_USUARIO) " & _
                    "AND Detalle LIKE '%" & txtBeneficiario.Text.ToString & "%' AND " & _
                    "(Fecha_Solicitud BETWEEN '" & txtFechaDesde.Text.ToString & "' AND '" & txtFechaHasta.Text.ToString & "') and (Auditor_Medico = 0)"
            End If
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            If txtFechaDesde.Text = "" And txtFechaDesde.Text = "" Then
                sql = "SELECT " & varSQLCAMPOS & "FROM REINTEGROS,USUARIOS_REINTEGROS WHERE (REINTEGROS.CODIGO_USUARIO = USUARIOS_REINTEGROS.CODIGO_USUARIO) " & _
                    "AND Detalle LIKE '%" & txtBeneficiario.Text.ToString & "%' and Auditor_medico=1)"
            Else
                sql = "SELECT " & varSQLCAMPOS & "FROM REINTEGROS,USUARIOS_REINTEGROS WHERE (REINTEGROS.CODIGO_USUARIO = USUARIOS_REINTEGROS.CODIGO_USUARIO) " & _
                    "AND Detalle LIKE '%" & txtBeneficiario.Text.ToString & "%' AND " & _
                    "(Fecha_Solicitud BETWEEN '" & txtFechaDesde.Text.ToString & "' AND '" & txtFechaHasta.Text.ToString & "') and (Auditor_Medico = 1)"
            End If
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView2.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            If txtFechaDesde.Text = "" And txtFechaDesde.Text = "" Then
                sql = "SELECT " & varSQLCAMPOS & "FROM REINTEGROS,USUARIOS_REINTEGROS WHERE (REINTEGROS.CODIGO_USUARIO = USUARIOS_REINTEGROS.CODIGO_USUARIO) " & _
                    "AND Detalle LIKE '%" & txtBeneficiario.Text.ToString & "%' and Auditor_medico=2)"
            Else
                sql = "SELECT " & varSQLCAMPOS & "FROM REINTEGROS,USUARIOS_REINTEGROS WHERE (REINTEGROS.CODIGO_USUARIO = USUARIOS_REINTEGROS.CODIGO_USUARIO) " & _
                    "AND Detalle LIKE '%" & txtBeneficiario.Text.ToString & "%' AND " & _
                    "(Fecha_Solicitud BETWEEN '" & txtFechaDesde.Text.ToString & "' AND '" & txtFechaHasta.Text.ToString & "') and (Auditor_Medico = 2)"
            End If
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView3.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


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
    '****************************************
    'CLICK 1 - REINTEGROS PENDIENTES AUDITOR
    Private Sub GridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView1.CellClick
        'CARGA IMAGENES
        clbimagen.Items.Clear()
        lblPicture.Image = Nothing
        Dim SQL2 As String
        Dim MiConexion2 As New MySqlConnection(CADENABASE2)
        Dim Rs2 As MySqlDataReader
        Dim Com2 As New MySqlCommand
        Com2.Connection = MiConexion2
        MiConexion2.Open()
        'varCodigoreintegro = (Me.GridView1.Rows(e.RowIndex).Cells(1).Value)
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

        Try
            'arreglo fecha
            VariableGlobalBeneficiario = Me.GridView1.Rows(e.RowIndex).Cells(2).Value
            varCodigoreintegro = (Me.GridView1.Rows(e.RowIndex).Cells(1).Value).ToString
            VariableGlobalCuilBeneficiario = Me.GridView1.Rows(e.RowIndex).Cells(17).Value

            lblReintegroPendiente.Text = varCodigoreintegro
            botonAprobar.Visible = True
            botonDesaprobar.Visible = True

        Catch
        End Try
    End Sub
    'CLICK 2- REINTEGROS PENDIENTES AUDITOR
    Private Sub GridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView1.CellContentClick
        clbimagen.Items.Clear()
        lblPicture.Image = Nothing
        Dim SQL2 As String
        Dim MiConexion2 As New MySqlConnection(CADENABASE2)
        Dim Rs2 As MySqlDataReader
        Dim Com2 As New MySqlCommand
        Com2.Connection = MiConexion2
        MiConexion2.Open()
        'varCodigoreintegro = (Me.GridView1.Rows(e.RowIndex).Cells(1).Value)
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
        Try
            'arreglo fecha
            VariableGlobalBeneficiario = Me.GridView1.Rows(e.RowIndex).Cells(2).Value
            varCodigoreintegro = (Me.GridView1.Rows(e.RowIndex).Cells(1).Value).ToString
            VariableGlobalCuilBeneficiario = Me.GridView1.Rows(e.RowIndex).Cells(17).Value

            lblReintegroPendiente.Text = varCodigoreintegro
            botonAprobar.Visible = True
            botonDesaprobar.Visible = True
        Catch
        End Try
    End Sub

    '*****************************************
    'CLICK 1 - REINTEGROS APROBADOS
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView2.CellContentClick
        clbimagen.Items.Clear()
        lblPicture.Image = Nothing
        Try
            Dim SQL2 As String
            Dim MiConexion2 As New MySqlConnection(CADENABASE2)
            Dim Rs2 As MySqlDataReader
            Dim Com2 As New MySqlCommand
            Com2.Connection = MiConexion2
            MiConexion2.Open()
            SQL2 = "select Imagen1,Imagen2,Imagen3,Imagen4,Imagen5 from reintegros where codigo_reintegro = '" & Me.GridView2.Rows(e.RowIndex).Cells(1).Value.ToString & "'"
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
            'arreglo fecha
            VariableGlobalBeneficiario = Me.GridView2.Rows(e.RowIndex).Cells(2).Value
            varCodigoreintegroAprobado = (Me.GridView2.Rows(e.RowIndex).Cells(1).Value).ToString
            VariableGlobalCuilBeneficiario = Me.GridView2.Rows(e.RowIndex).Cells(17).Value

            lblReintegroAprobado.Text = varCodigoreintegroAprobado
        Catch
        End Try
    End Sub
    'CLICK 2 - REINTEGROS APROBADOS
    Private Sub GridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView2.CellClick
        clbimagen.Items.Clear()
        lblPicture.Image = Nothing
        Try
            Dim SQL2 As String
            Dim MiConexion2 As New MySqlConnection(CADENABASE2)
            Dim Rs2 As MySqlDataReader
            Dim Com2 As New MySqlCommand
            Com2.Connection = MiConexion2
            MiConexion2.Open()
            'varCodigoreintegro = (Me.GridView1.Rows(e.RowIndex).Cells(1).Value)
            SQL2 = "select Imagen1,Imagen2,Imagen3,Imagen4,Imagen5 from reintegros where codigo_reintegro = '" & Me.GridView2.Rows(e.RowIndex).Cells(1).Value.ToString & "'"
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
            'arreglo fecha
            VariableGlobalBeneficiario = Me.GridView2.Rows(e.RowIndex).Cells(2).Value
            varCodigoreintegroAprobado = (Me.GridView2.Rows(e.RowIndex).Cells(1).Value).ToString
            VariableGlobalCuilBeneficiario = Me.GridView2.Rows(e.RowIndex).Cells(17).Value

            lblReintegroAprobado.Text = varCodigoreintegroAprobado
        Catch
        End Try
    End Sub
    '*******************************
    'CLICK 1 - REINTEGROS RECHAZADOS
    Private Sub GridView3_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView3.CellClick
        clbimagen.Items.Clear()
        lblPicture.Image = Nothing
        Try
            Dim SQL2 As String
            Dim MiConexion2 As New MySqlConnection(CADENABASE2)
            Dim Rs2 As MySqlDataReader
            Dim Com2 As New MySqlCommand
            Com2.Connection = MiConexion2
            MiConexion2.Open()
            SQL2 = "select Imagen1,Imagen2,Imagen3,Imagen4,Imagen5 from reintegros where codigo_reintegro = '" & Me.GridView3.Rows(e.RowIndex).Cells(1).Value & "'"
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
            'arreglo fecha
            VariableGlobalBeneficiario = Me.GridView3.Rows(e.RowIndex).Cells(2).Value
            varCodigoreintegroRechazado = (Me.GridView3.Rows(e.RowIndex).Cells(1).Value).ToString
            VariableGlobalCuilBeneficiario = Me.GridView3.Rows(e.RowIndex).Cells(17).Value

            lblReintegroRechazado.Text = varCodigoreintegroRechazado
        Catch
        End Try
    End Sub
    'CKICK 2 - REINTEGROS RECHAZADOS
    Private Sub GridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView3.CellContentClick
        clbimagen.Items.Clear()
        lblPicture.Image = Nothing
        Try
            Dim SQL2 As String
            Dim MiConexion2 As New MySqlConnection(CADENABASE2)
            Dim Rs2 As MySqlDataReader
            Dim Com2 As New MySqlCommand
            Com2.Connection = MiConexion2
            MiConexion2.Open()
            SQL2 = "select Imagen1,Imagen2,Imagen3,Imagen4,Imagen5 from reintegros where codigo_reintegro = '" & Me.GridView3.Rows(e.RowIndex).Cells(1).Value & "'"
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
            'arreglo fecha
            VariableGlobalBeneficiario = Me.GridView3.Rows(e.RowIndex).Cells(2).Value
            varCodigoreintegroRechazado = (Me.GridView3.Rows(e.RowIndex).Cells(1).Value).ToString
            VariableGlobalCuilBeneficiario = Me.GridView3.Rows(e.RowIndex).Cells(17).Value

            lblReintegroRechazado.Text = varCodigoreintegroRechazado
        Catch
        End Try
    End Sub
    '****************************************

    'VISTA PREVIA DEL PICTUREBOX AL SELECCIONAR EN EL COMBOLIST
    Private Sub clbimagen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbimagen.SelectedIndexChanged
        Try
            lblPicture.Image = clbimagen.SelectedItem
        Catch ex As Exception
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




    Private Sub botonAprobar_Click(sender As Object, e As EventArgs) Handles botonAprobar.Click
        botonAprobar.Visible = False
        botonDesaprobar.Visible = False
        GridView2.Visible = False
        varAudMed = 1
        OK.Visible = True
        CANCELA.Visible = True
        txtPorcAM.Visible = True
        txtObservacionesAM.Visible = True
        det = "El Auditor Medico Aprobó el reintegro: "
        txtPorcAM.Focus()
    End Sub

    Private Sub botonDesaprobar_Click(sender As Object, e As EventArgs) Handles botonDesaprobar.Click
        botonAprobar.Visible = False
        botonDesaprobar.Visible = False
        GridView2.Visible = False
        varAudMed = 2
        txtPorcAM.Text = "0"
        OK.Visible = True
        CANCELA.Visible = True
        txtObservacionesAM.Visible = True
        det = "*El Auditor Medico Rechazó el reintegro: "
        txtObservacionesAM.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    Private Sub update_To() 'Pisa la base productiva "REINTEGROS"
        Using con_insert As New MySqlConnection(CADENABASE2)
            Dim cmdinsert As New MySqlCommand
            With cmdinsert
                .Connection = con_insert
                .CommandType = CommandType.Text
                .CommandText = "UPDATE `reintegros` SET Auditor_Medico=?aumed,Observaciones_AM=?obsAM,Porcentaje_Reintegro_AM=?porcAM WHERE codigo_reintegro = ?codre"
                .Parameters.AddWithValue("?codre", varCodigoreintegro)
                .Parameters.AddWithValue("?aumed", varAudMed)
                .Parameters.AddWithValue("?obsAM", txtObservacionesAM.text)
                .Parameters.AddWithValue("?porcAM", txtPorcAM.text)
            End With
            Try
                con_insert.Open()
                cmdinsert.ExecuteNonQuery()
                con_insert.Close()
                MessageBox.Show("UPDATE en BD OK", "Actualizacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Insert_To_Modificacion()
            Catch falla As MySqlException
                MsgBox(falla.Message)
            End Try
        End Using
    End Sub


    Private Sub Insert_To_Modificacion() 'Registra la modificacion que hizo el usuario logueado en la tabla "historial_reintegros"
        'calcula la fecha y hora de hoy en este preciso momento..
        fechaHoy()
        Using con_insert As New MySqlConnection(CADENABASE2)
            Dim cmdinsert As New MySqlCommand
            '   Dim varimp As Double = Convert.ToDouble(txtImporte.Text)
            With cmdinsert
                .Connection = con_insert
                .CommandType = CommandType.Text
                VERIFICA_MODIFICACIONES()
                .CommandText = "INSERT INTO `historial_reintegros`(`Codigo_Usuario`,`Codigo_Reintegro`,`Codigo_Beneficiario`,`Cuil_Beneficiario`,`Fecha_modificacion`," & _
                    "`Hora`,`Detalle`) VALUES (?codus,?codre,?codben,?cuilben,?fecmod,?hora,?detalle)"
                .Parameters.AddWithValue("?codus", VariableGlobalUsuario)
                .Parameters.AddWithValue("?codre", varCodigoreintegro)
                .Parameters.AddWithValue("?codben", VariableGlobalBeneficiario)
                .Parameters.AddWithValue("?cuilben", VariableGlobalCuilBeneficiario)
                .Parameters.AddWithValue("?fecmod", VariableGlobalFechaHOY)
                .Parameters.AddWithValue("?hora", VariableGlobalHoraHOY)
                .Parameters.AddWithValue("?detalle", VariableGlobalModificacion)
            End With
            Try
                con_insert.Open()
                cmdinsert.ExecuteNonQuery()
                con_insert.Close()
                MessageBox.Show("Asignado a historial de modificacion..", "Actualizacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch falla As MySqlException
                MsgBox(falla.Message)
            End Try
        End Using
    End Sub

    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
   
 
    Private Sub CANCELA_Click(sender As Object, e As EventArgs) Handles CANCELA.Click
        txtPorcAM.Text = ""
        txtObservacionesAM.Text = ""
        GridView2.Visible = True
        GridView3.Visible = True
        txtPorcAM.Visible = False
        txtObservacionesAM.Visible = False
        botonAprobar.Visible = False
        botonDesaprobar.Visible = False
        det = ""
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        If Trim(txtPorcAM.Text = "") Then
            MsgBox("Debe ingresar Porcentaje Sugerido y luego pulse 'OK'", vbExclamation)
        Else
            update_To()
            txtPorcAM.Text = ""
            txtObservacionesAM.Text = ""
            GridView2.Visible = True
            GridView3.Visible = True
            txtPorcAM.Visible = False
            txtObservacionesAM.Visible = False
            botonAprobar.Visible = False
            botonDesaprobar.Visible = False
            OK.Visible = False
            CANCELA.Visible = False
            llenarGridCompleto()
            det = ""
        End If
    End Sub

    Private Sub lblPicture_DoubleClick(sender As Object, e As EventArgs) Handles lblPicture.DoubleClick
        FormularioImagen.PictureBox1.Image = Me.lblPicture.Image
        FormularioImagen.Show()
    End Sub

    Private Sub botonExcel_Click(sender As Object, e As EventArgs) Handles botonExcel.Click
        GridAExcel(GridView1)
    End Sub
    Private Sub botonExcel2_Click(sender As Object, e As EventArgs) Handles botonExcel2.Click
        GridAExcel(GridView2)
    End Sub

    Private Sub botonExcel3_Click(sender As Object, e As EventArgs) Handles botonExcel3.Click
        GridAExcel(GridView3)
    End Sub

    Private Sub botonExcel_MouseHover(sender As Object, e As EventArgs) Handles botonExcel.MouseHover
        etiquetear()
    End Sub

    Private Sub botonExcel_MouseMove(sender As Object, e As MouseEventArgs) Handles botonExcel.MouseMove
        botonExcel.Image = WindowsApplication1.My.Resources.Resources.logo2excel
    End Sub

    Private Sub botonExcel2_MouseHover(sender As Object, e As EventArgs) Handles botonExcel2.MouseHover
        etiquetear()
    End Sub
    Private Sub botonExcel2_MouseMove(sender As Object, e As MouseEventArgs) Handles botonExcel2.MouseMove
        botonExcel2.Image = WindowsApplication1.My.Resources.Resources.logo2excel
    End Sub

    Private Sub botonExcel3_MouseHover(sender As Object, e As EventArgs) Handles botonExcel3.MouseHover
        etiquetear()
    End Sub

    Private Sub botonExcel3_MouseMove(sender As Object, e As MouseEventArgs) Handles botonExcel3.MouseMove
        botonExcel3.Image = WindowsApplication1.My.Resources.Resources.logo2excel
    End Sub

    Private Sub FormularioAuditor_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        botonExcel.Image = WindowsApplication1.My.Resources.Resources.logoexcelsistemaa
        botonExcel2.Image = WindowsApplication1.My.Resources.Resources.logoexcelsistemaa
        botonExcel3.Image = WindowsApplication1.My.Resources.Resources.logoexcelsistemaa
    End Sub

    Private Sub txtBeneficiario_TextChanged(sender As Object, e As EventArgs) Handles txtBeneficiario.TextChanged
        BuscarDato()
    End Sub

    Private Sub etiquetear()
        ToolTip1.SetToolTip(botonExcel, "Exportar Listado de Pendientes a Excel")
        ToolTip1.SetToolTip(botonExcel2, "Exportar Listado de Aprobados a Excel")
        ToolTip1.SetToolTip(botonExcel3, "Exportar Listado de Rechazados a Excel")
    End Sub


    Private Sub VERIFICA_MODIFICACIONES()
        VariableGlobalModificacion = ""
        VariableGlobalModificacion = det & varCodigoreintegro
    End Sub

    'EXPANDE GRID 1
    Private Sub RectangleShape1_DoubleClick(sender As Object, e As System.EventArgs) Handles shapePendientes.DoubleClick
        If (GridView1.Width = 555) And (shapePendientes.Width = 555) Then
            GridView1.Width = 1500
            shapePendientes.Width = 1500
        ElseIf (GridView1.Width = 1500) And (shapePendientes.Width = 1500) Then
            GridView1.Width = 555
            shapePendientes.Width = 555
        End If
    End Sub



    'DOBLE CLICK EN GRID PENDIENTES
    Private Sub GridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView1.CellDoubleClick
        Try
            varCodigoreintegro = (Me.GridView1.Rows(e.RowIndex).Cells(1).Value).ToString
            Historial.lblTitulo.Text = "'PENDIENTES' -" & " Historial de Modificaciones del reintegro N° -" & varCodigoreintegro & "-"
            VarHistorialReintegro = varCodigoreintegro
            Historial.Show()
        Catch
        End Try
    End Sub
    Private Sub GridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView1.CellContentDoubleClick
        Try
            varCodigoreintegro = (Me.GridView1.Rows(e.RowIndex).Cells(1).Value).ToString
            Historial.lblTitulo.Text = "'PENDIENTES' -" & " Historial de Modificaciones del reintegro N° -" & varCodigoreintegro & "-"
            VarHistorialReintegro = varCodigoreintegro
            Historial.Show()
        Catch
        End Try
    End Sub


    'DOBLE CLIC EN GRID APROBADOS
    Private Sub GridView2_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView2.CellContentDoubleClick
        Try
            varCodigoreintegroAprobado = (Me.GridView2.Rows(e.RowIndex).Cells(1).Value).ToString
            Historial.lblTitulo.Text = "'APROBADOS' -" & " Historial de Modificaciones del reintegro N° -" & varCodigoreintegroAprobado & "-"
            VarHistorialReintegro = varCodigoreintegroAprobado
            Historial.Show()
        Catch
        End Try
    End Sub

    Private Sub GridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView2.CellDoubleClick
        Try
            varCodigoreintegroAprobado = (Me.GridView2.Rows(e.RowIndex).Cells(1).Value).ToString
            Historial.lblTitulo.Text = "'APROBADOS' -" & " Historial de Modificaciones del reintegro N° -" & varCodigoreintegroAprobado & "-"
            VarHistorialReintegro = varCodigoreintegroAprobado
            Historial.Show()
        Catch
        End Try
    End Sub

    'DOBLE CLICK EN GRID RECHAZADOS
    Private Sub GridView3_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView3.CellContentDoubleClick
        Try
            varCodigoreintegroAprobado = (Me.GridView3.Rows(e.RowIndex).Cells(1).Value).ToString
            Historial.lblTitulo.Text = "'RECHAZADOS' -" & " Historial de Modificaciones del reintegro N° -" & varCodigoreintegroRechazado & "-"
            VarHistorialReintegro = varCodigoreintegroRechazado
            Historial.Show()
        Catch
        End Try
    End Sub

    Private Sub GridView3_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles GridView3.CellMouseDoubleClick
        Try
            varCodigoreintegroAprobado = (Me.GridView3.Rows(e.RowIndex).Cells(1).Value).ToString
            Historial.lblTitulo.Text = "'RECHAZADOS' -" & " Historial de Modificaciones del reintegro N° -" & varCodigoreintegroRechazado & "-"
            VarHistorialReintegro = varCodigoreintegroRechazado
            Historial.Show()
        Catch
        End Try
    End Sub
End Class