Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data
Imports System.Drawing.Imaging
Imports System.Drawing.Printing

Public Class FormularioPagos
    Dim Conex As New MySqlConnection(CADENABASE2)
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Dim varCodigoreintegro As String
    Dim varCodigoreintegroAprobado As String
    Dim varCodigoreintegroPagado As String
    Dim varCodigoreintegroRechazado As String
    Dim varOPREINTEGRO As String = " "
    Dim varOPNUMREINTEGRO As String = ""
    Dim varOPCUIL As String = ""
    Dim varSQLCAMPOS As String = "reintegros.codigo_usuario,codigo_reintegro,codigo_beneficiario,fecha_solicitud,detalle,importe,observaciones_carga, " & _
                              "usuarios_reintegros.ApellidoNombre,usuarios_reintegros.tipo_usuario,usuarios_reintegros.codigo_seccional,reintegros.CBU," & _
                              "reintegros.Alias,reintegros.tipo_reintegro,reintegros.id_Subsidio,reintegros.Pagado,reintegros.Cuil_Pago,reintegros.tipo_cuenta,cuil_beneficiario "
    Dim varEstado As Integer
    Dim varPagado As Integer
    Dim varACargo As Integer
    Dim det As String = ""
    Dim pagaono As Boolean

    Dim varFILTROSECCIONAL As String = ""
    Dim varSQLSECCIONALES As String = " usuarios_reintegros.codigo_usuario,usuarios_reintegros.apellidonombre,seccionales.descripcion "
    Dim varUserSeccional As String = ""



    Private Sub ifReintegroOSubsidio()
        varOPREINTEGRO = ""
        If (opReintegro.Checked = True) And (opSubsidio.Checked = False) Then
            varOPREINTEGRO = " AND (tipo_reintegro = 0) "
        End If
        If (opReintegro.Checked = True) And (opSubsidio.Checked = True) Then
            varOPREINTEGRO = " "
        End If
        If (opReintegro.Checked = False) And (opSubsidio.Checked = True) Then
            varOPREINTEGRO = " AND (tipo_reintegro = 1) "
        End If
        If (opReintegro.Checked = False) And (opSubsidio.Checked = False) Then
            varOPREINTEGRO = " "
        End If
    End Sub

    Private Sub todosLosIF()
        ifReintegroOSubsidio()
    End Sub


    Private Sub opBuscaNumReintegro_CheckedChanged(sender As Object, e As EventArgs) Handles opBuscaNumReintegro.CheckedChanged
        If opBuscaNumReintegro.Checked = True Then
            opBuscarDNI.Checked = False
            txtNumReintegroBusqueda.Text = ""
            txtNumReintegroBusqueda.Enabled = True
            txtNumReintegroBusqueda.Focus()
        End If
    End Sub

    Private Sub opBuscarDNI_CheckedChanged(sender As Object, e As EventArgs) Handles opBuscarDNI.CheckedChanged
        If opBuscarDNI.Checked = True Then
            opBuscaNumReintegro.Checked = False
            txtNumReintegroBusqueda.Text = ""
            txtNumReintegroBusqueda.Enabled = True
            txtNumReintegroBusqueda.Focus()
        End If
    End Sub

    Private Sub txtNumReintegroBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtNumReintegroBusqueda.TextChanged
        If opBuscaNumReintegro.Checked = True Then
            varOPNUMREINTEGRO = " AND (Reintegros.Codigo_Reintegro like '%" & txtNumReintegroBusqueda.Text & "%') "
        Else
            varOPNUMREINTEGRO = " "
        End If
        If opBuscarDNI.Checked = True Then
            varOPCUIL = " AND (Reintegros.Cuil_Beneficiario like '%" & txtNumReintegroBusqueda.Text & "%') "
        Else
            varOPCUIL = " "
        End If
        BuscarDato()
    End Sub

    Private Sub BuscarDato()
        'pendientes comision
        Try
            If txtFechaDesde.Text = "" And txtFechaDesde.Text = "" Then
                sql = "SELECT " & varSQLCAMPOS & "FROM REINTEGROS,USUARIOS_REINTEGROS WHERE (REINTEGROS.CODIGO_USUARIO = USUARIOS_REINTEGROS.CODIGO_USUARIO) " & _
                    "AND (Auditor_Medico = 1) and (estado = 0) AND " & _
                    "(Detalle LIKE '%" & txtBeneficiario.Text.ToString & "%') " & varOPNUMREINTEGRO & varOPCUIL & varOPREINTEGRO & varFILTROSECCIONAL & " order by fecha_solicitud desc"
            Else
                sql = "SELECT " & varSQLCAMPOS & "FROM REINTEGROS,USUARIOS_REINTEGROS WHERE (REINTEGROS.CODIGO_USUARIO = USUARIOS_REINTEGROS.CODIGO_USUARIO) " & _
                    "AND (Auditor_Medico = 1) and (estado = 0) AND " & _
                    "(Detalle LIKE '%" & txtBeneficiario.Text.ToString & "%') AND " & _
                    "(Fecha_Solicitud BETWEEN '" & txtFechaDesde.Text.ToString & "' " & _
                    "AND '" & txtFechaHasta.Text.ToString & "') " & varOPNUMREINTEGRO & varOPCUIL & varOPREINTEGRO & varFILTROSECCIONAL & " order by fecha_solicitud desc"
            End If
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView2.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Rechazados por Comision
        Try
            If txtFechaDesde.Text = "" And txtFechaDesde.Text = "" Then
                sql = "SELECT " & varSQLCAMPOS & "FROM REINTEGROS,USUARIOS_REINTEGROS WHERE (REINTEGROS.CODIGO_USUARIO = USUARIOS_REINTEGROS.CODIGO_USUARIO) " & _
                    "AND (Auditor_Medico = 1) and (estado =2) AND " & _
                    "(Detalle LIKE '%" & txtBeneficiario.Text.ToString & "%') " & varOPNUMREINTEGRO & varOPCUIL & varOPREINTEGRO & varFILTROSECCIONAL & " order by fecha_solicitud desc"
            Else
                sql = "SELECT " & varSQLCAMPOS & "FROM REINTEGROS,USUARIOS_REINTEGROS WHERE (REINTEGROS.CODIGO_USUARIO = USUARIOS_REINTEGROS.CODIGO_USUARIO) " & _
                    "AND (Auditor_Medico = 1) and (estado =2) AND (Detalle LIKE '%" & txtBeneficiario.Text.ToString & "%') AND " & _
                    "(Fecha_Solicitud BETWEEN '" & txtFechaDesde.Text.ToString & "' " & _
                    "AND '" & txtFechaHasta.Text.ToString & "') " & varOPNUMREINTEGRO & varOPCUIL & varOPREINTEGRO & varFILTROSECCIONAL & " order by fecha_solicitud desc"
            End If
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView3.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'Pagados (aprobados por comision)
        Try
            If txtFechaDesde.Text = "" And txtFechaDesde.Text = "" Then
                sql = "SELECT " & varSQLCAMPOS & "FROM REINTEGROS,USUARIOS_REINTEGROS WHERE (REINTEGROS.CODIGO_USUARIO = USUARIOS_REINTEGROS.CODIGO_USUARIO) " & _
                    "AND (Auditor_Medico = 1) and (estado =1) and (pagado=1) AND " & _
                    "(Detalle LIKE '%" & txtBeneficiario.Text.ToString & "%') " & varOPNUMREINTEGRO & varOPCUIL & varOPREINTEGRO & varFILTROSECCIONAL & " order by fecha_solicitud desc"
            Else
                sql = "SELECT " & varSQLCAMPOS & "FROM REINTEGROS,USUARIOS_REINTEGROS WHERE (REINTEGROS.CODIGO_USUARIO = USUARIOS_REINTEGROS.CODIGO_USUARIO) " & _
                    "AND (Auditor_Medico = 1) and (estado =1) and (pagado=1) AND (Detalle LIKE '%" & txtBeneficiario.Text.ToString & "%') AND " & _
                    "(Fecha_Solicitud BETWEEN '" & txtFechaDesde.Text.ToString & "' " & _
                    "AND '" & txtFechaHasta.Text.ToString & "') " & varOPNUMREINTEGRO & varOPCUIL & varOPREINTEGRO & varFILTROSECCIONAL & " order by fecha_solicitud desc"
            End If
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView3.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    'metodo llenar grid
    Private Sub llenarGridCompleto() '>>>>>>>>>>>
        'grid aprobados 
        Try
            sql = "SELECT " & varSQLCAMPOS & "FROM REINTEGROS,USUARIOS_REINTEGROS WHERE (REINTEGROS.CODIGO_USUARIO = USUARIOS_REINTEGROS.CODIGO_USUARIO) " & _
                    "AND (Auditor_Medico = 1) and (estado = 0) order by fecha_solicitud desc"
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
                    "AND (Auditor_Medico = 1) and (estado =2) order by fecha_solicitud desc"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView3.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'grid rechazados
        Try
            sql = "SELECT " & varSQLCAMPOS & "FROM REINTEGROS,USUARIOS_REINTEGROS WHERE (REINTEGROS.CODIGO_USUARIO = USUARIOS_REINTEGROS.CODIGO_USUARIO) " & _
                    "AND (Auditor_Medico = 1) and (estado =1) and (pagado=1) order by fecha_solicitud desc"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView4.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'grid de seccionales
        Try
            sql = "SELECT " & varSQLSECCIONALES & " from usuarios_reintegros left join seccionales on (usuarios_reintegros.codigo_seccional = seccionales.codigo) "
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridViewSeccionales.DataSource = dt
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
    'metodo limpia fecha
    Private Sub limpiafechas()
        txtFechaDesde.Text = ""
        txtFechaHasta.Text = ""
    End Sub


    Private Sub FormularioPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        varPagado = 0
        apagaFecha()
        llenarGridCompleto()
        txtBeneficiario.Focus()
        txtFechaDesde.Enabled = False
        txtFechaHasta.Enabled = False
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
            lblImporteSolicitado.Text = Me.GridView2.Rows(e.RowIndex).Cells(5).Value
            botonAprobar.Visible = True
            botonDesaprobar.Visible = True
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
            lblImporteSolicitado.Text = Me.GridView2.Rows(e.RowIndex).Cells(5).Value
            botonAprobar.Visible = True
            botonDesaprobar.Visible = True
        Catch
        End Try
    End Sub
    '*******************************

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


    'VISTA PREVIA DEL PICTUREBOX AL SELECCIONAR EN EL COMBOLIST
    Private Sub clbimagen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbimagen.SelectedIndexChanged
        Try
            lblPicture.Image = clbimagen.SelectedItem
        Catch ex As Exception
        End Try
    End Sub



    Private Sub botonAprobar_Click(sender As Object, e As EventArgs) Handles botonAprobar.Click
        pagaono = True
        varPagado = 1
        botonAprobar.Visible = False
        botonDesaprobar.Visible = False
        GridView2.Visible = False
        varEstado = 1
        OK.Visible = True
        CANCELA.Visible = True
        txtAutorizante.Visible = True
        lblAutorizante.Visible = True
        txtPorcAM.Visible = True
        lblPorcentajeReintegro.Visible = True
        txtObservacionesAM.Visible = True
        lblObservacionesComision.Visible = True
        txtPorcAM.Focus()
    End Sub

    Private Sub botonDesaprobar_Click(sender As Object, e As EventArgs) Handles botonDesaprobar.Click
        pagaono = False
        varPagado = 2
        botonAprobar.Visible = False
        botonDesaprobar.Visible = False
        GridView2.Visible = False
        varEstado = 2
        varPagado = 0
        txtPorcAM.Text = "0"
        OK.Visible = True
        CANCELA.Visible = True
        txtAutorizante.Visible = True
        lblAutorizante.Visible = True
        txtObservacionesAM.Visible = True
        lblObservacionesComision.Visible = True
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
                fechaHoy()
                Dim plata As Double = Convert.ToDouble(lblImporteSolicitado.Text)
                Dim porcentaje As Double = Convert.ToDouble(txtPorcAM.Text)
                Dim varReintegroFinal As Double = plata * porcentaje / 100
                '`Estado` int(1) DEFAULT '0',   /* [0]-PENDIENTE / [1]-APROBADO / [2]-RECHAZADO  */
                '`Observaciones_Comision` varchar(120) NOT NULL DEFAULT 'NO YET' ,
                '`Autorizante` varchar(60) NOT NULL DEFAULT 'NO YET',
                '`A_Cargo` int(1) DEFAULT '0',  /*[0]- OBRA SOCIAL / [1]-URGARA */
                '/*INSTANCIA 4 -PAGO DEL REINTEGRO*/
                ' `Fecha_Reintegro` date DEFAULT '0000-00-00',  
                ' `Porcentaje_Reintegro_final` int(3) DEFAULT '0',
                ' `Valor_Reintegrado` float(8) DEFAULT '0',
                ' `Pagado` int(1) DEFAULT '0', /* [0]-NO  / [1]-SI */
                If pagaono = True Then
                    det = "$[APROBADO COMISION - PAGADO] Por desición de " & txtAutorizante.Text & ", el valor a reintegrado es: $" & varReintegroFinal & ", correspondiente al reintegro nº: "
                Else
                    det = "$$[RECHAZADO COMISION] Por desición de " & txtAutorizante.Text & ", la Comisión Directiva Rechazó el reintegro nº: "
                End If
                .CommandText = "UPDATE `reintegros` SET Estado=?est,Observaciones_Comision=?obscom,Autorizante=?aut,A_Cargo=?acargo,Fecha_Reintegro=?fecre,Porcentaje_Reintegro_final=?porcfinal,Valor_Reintegrado=?valre,Pagado=?pag WHERE codigo_reintegro = ?codre"
                .Parameters.AddWithValue("?codre", varCodigoreintegroAprobado)
                .Parameters.AddWithValue("?est", varEstado)
                .Parameters.AddWithValue("?obscom", txtObservacionesAM.Text)
                .Parameters.AddWithValue("?aut", txtAutorizante.Text)
                .Parameters.AddWithValue("?acargo", "1")
                .Parameters.AddWithValue("?fecre", VariableGlobalFechaHOY)
                .Parameters.AddWithValue("?porcfinal", txtPorcAM.Text)
                .Parameters.AddWithValue("?valre", varReintegroFinal)
                .Parameters.AddWithValue("?pag", varPagado)
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
                .Parameters.AddWithValue("?codre", varCodigoreintegroAprobado)
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
        txtAutorizante.Text = ""
        txtPorcAM.Text = ""
        txtObservacionesAM.Text = ""
        GridView2.Visible = True
        txtAutorizante.Visible = False
        txtPorcAM.Visible = False
        txtObservacionesAM.Visible = False
        botonAprobar.Visible = False
        botonDesaprobar.Visible = False
        det = ""
    End Sub

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        If Trim(txtPorcAM.Text = "") Then
            MsgBox("Debe llenar los campos obligatorios(*)", vbExclamation)
        Else
            update_To()
            txtAutorizante.Text = ""
            txtPorcAM.Text = ""
            txtObservacionesAM.Text = ""
            GridView2.Visible = True
            txtAutorizante.Visible = False
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
    Private Sub etiquetear()
        ToolTip1.SetToolTip(botonExcel, "Exportar Listado de Pendientes a Excel")
    End Sub


    Private Sub VERIFICA_MODIFICACIONES()
        VariableGlobalModificacion = ""
        VariableGlobalModificacion = det & varCodigoreintegroAprobado
    End Sub


    'CLICK 1 - REINTEGROS RECHAZADOS por comision
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
        Catch
        End Try
    End Sub
    'CKICK 2 - REINTEGROS RECHAZADOS por comision
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
        Catch
        End Try
    End Sub
    '****************************************

    'CLICK 1 - REINTEGROS PAGADOS Y APROBADOS POR COMISION
    Private Sub GridView4_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView4.CellClick
        clbimagen.Items.Clear()
        lblPicture.Image = Nothing
        Try
            Dim SQL2 As String
            Dim MiConexion2 As New MySqlConnection(CADENABASE2)
            Dim Rs2 As MySqlDataReader
            Dim Com2 As New MySqlCommand
            Com2.Connection = MiConexion2
            MiConexion2.Open()
            SQL2 = "select Imagen1,Imagen2,Imagen3,Imagen4,Imagen5 from reintegros where codigo_reintegro = '" & Me.GridView4.Rows(e.RowIndex).Cells(1).Value & "'"
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
            VariableGlobalBeneficiario = Me.GridView4.Rows(e.RowIndex).Cells(2).Value
            varCodigoreintegroPagado = (Me.GridView4.Rows(e.RowIndex).Cells(1).Value).ToString
            VariableGlobalCuilBeneficiario = Me.GridView4.Rows(e.RowIndex).Cells(17).Value
        Catch
        End Try
    End Sub

    'CKICK 2 - REINTEGROS PAGADOS Y APROBADOS POR COMISION
    Private Sub GridView4_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView4.CellContentClick
        clbimagen.Items.Clear()
        lblPicture.Image = Nothing
        Try
            Dim SQL2 As String
            Dim MiConexion2 As New MySqlConnection(CADENABASE2)
            Dim Rs2 As MySqlDataReader
            Dim Com2 As New MySqlCommand
            Com2.Connection = MiConexion2
            MiConexion2.Open()
            SQL2 = "select Imagen1,Imagen2,Imagen3,Imagen4,Imagen5 from reintegros where codigo_reintegro = '" & Me.GridView4.Rows(e.RowIndex).Cells(1).Value & "'"
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
            VariableGlobalBeneficiario = Me.GridView4.Rows(e.RowIndex).Cells(2).Value
            varCodigoreintegroPagado = (Me.GridView4.Rows(e.RowIndex).Cells(1).Value).ToString
            VariableGlobalCuilBeneficiario = Me.GridView4.Rows(e.RowIndex).Cells(17).Value
        Catch
        End Try
    End Sub
    '****************************************

    Private Sub GridView3_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView3.CellContentDoubleClick
        Try
            varCodigoreintegroRechazado = (Me.GridView3.Rows(e.RowIndex).Cells(1).Value).ToString
            Historial.lblTitulo.Text = "'RECHAZADOS' -" & " Historial de Modificaciones del reintegro N° -" & varCodigoreintegroRechazado & "-"
            VarHistorialReintegro = varCodigoreintegroRechazado
            Historial.Show()
        Catch
        End Try
    End Sub

    Private Sub GridView3_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView3.CellDoubleClick
        Try
            varCodigoreintegroRechazado = (Me.GridView3.Rows(e.RowIndex).Cells(1).Value).ToString
            Historial.lblTitulo.Text = "'RECHAZADOS' -" & " Historial de Modificaciones del reintegro N° -" & varCodigoreintegroRechazado & "-"
            VarHistorialReintegro = varCodigoreintegroRechazado
            Historial.Show()
        Catch
        End Try
    End Sub


    Private Sub GridView4_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView4.CellContentDoubleClick
        Try
            varCodigoreintegroPagado = (Me.GridView4.Rows(e.RowIndex).Cells(1).Value).ToString
            Historial.lblTitulo.Text = "'PAGADOS' -" & " Historial de Modificaciones del reintegro N° -" & varCodigoreintegroRechazado & "-"
            VarHistorialReintegro = varCodigoreintegroPagado
            Historial.Show()
        Catch
        End Try
    End Sub

    Private Sub GridView4_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView4.CellDoubleClick
        Try
            varCodigoreintegroPagado = (Me.GridView4.Rows(e.RowIndex).Cells(1).Value).ToString
            Historial.lblTitulo.Text = "'PAGADOS' -" & " Historial de Modificaciones del reintegro N° -" & varCodigoreintegroRechazado & "-"
            VarHistorialReintegro = varCodigoreintegroPagado
            Historial.Show()
        Catch
        End Try
    End Sub

    Private Sub botonExcel_Click(sender As Object, e As EventArgs) Handles botonExcel.Click
        GridAExcel(GridView2)
    End Sub

    Private Sub botonExcelRechazados_Click(sender As Object, e As EventArgs) Handles botonExcelRechazados.Click
        GridAExcel(GridView3)
    End Sub

    Private Sub botonExcelPagados_Click(sender As Object, e As EventArgs) Handles botonExcelPagados.Click
        GridAExcel(GridView4)
    End Sub

    Private Sub txtBeneficiario_TextChanged(sender As Object, e As EventArgs) Handles txtBeneficiario.TextChanged
        BuscarDato()
    End Sub

    Private Sub checkFecha_CheckedChanged(sender As Object, e As EventArgs) Handles checkFecha.CheckedChanged
        If checkFecha.Checked = True Then
            'MsgBox("CHECK ACTIVO FECHA", vbInformation)
            prendeFecha()
        Else
            'MsgBox("CHECK DESACTIVADO FECHA", vbInformation)
            apagaFecha()
            limpiafechas()
        End If
    End Sub

    Private Sub txtFechaDesde_TextChanged(sender As Object, e As EventArgs) Handles txtFechaDesde.TextChanged
        BuscarDato()
    End Sub

    Private Sub txtFechaHasta_TextChanged(sender As Object, e As EventArgs) Handles txtFechaHasta.TextChanged
        BuscarDato()
    End Sub

    Private Sub opReintegro_CheckedChanged(sender As Object, e As EventArgs) Handles opReintegro.CheckedChanged
        todosLosIF()
        BuscarDato()
    End Sub

    Private Sub opSubsidio_CheckedChanged(sender As Object, e As EventArgs) Handles opSubsidio.CheckedChanged
        todosLosIF()
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

    Private Sub opSeccional_CheckedChanged(sender As Object, e As EventArgs) Handles opSeccional.CheckedChanged
        If opSeccional.Checked = True Then
            GridViewSeccionales.Visible = True
        Else
            GridViewSeccionales.Visible = False
            txtuserseccional.Text = ""
            BuscarDato()
        End If
    End Sub

    Private Sub GridViewSeccionales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridViewSeccionales.CellClick
        Try
            txtuserseccional.Text = Me.GridViewSeccionales.Rows(e.RowIndex).Cells(0).Value
        Catch
        End Try
    End Sub

    Private Sub GridViewSeccionales_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridViewSeccionales.CellContentClick
        Try
            txtuserseccional.Text = Me.GridViewSeccionales.Rows(e.RowIndex).Cells(0).Value
        Catch
        End Try
    End Sub

    Private Sub txtuserseccional_TextChanged(sender As Object, e As EventArgs) Handles txtuserseccional.TextChanged
        If txtuserseccional.Text = "" Then
            varUserSeccional = ""
            varFILTROSECCIONAL = ""
        Else
            varUserSeccional = txtuserseccional.Text
            varFILTROSECCIONAL = " AND Reintegros.codigo_usuario = '" & varUserSeccional & "' "
            BuscarDato()
        End If
    End Sub

    Private Sub botonLimpiarFiltros_Click(sender As Object, e As EventArgs) Handles botonLimpiarFiltros.Click
        opReintegro.Checked = False
        opSubsidio.Checked = False
        opSeccional.Checked = False
        opBuscaNumReintegro.Checked = False
        opBuscarDNI.Checked = False
        txtNumReintegroBusqueda.Text = ""
    End Sub

    Private Sub botonLimpiarFiltros_MouseLeave(sender As Object, e As EventArgs) Handles botonLimpiarFiltros.MouseLeave
        botonLimpiarFiltros.BackgroundImage = WindowsApplication1.My.Resources.Resources.escoba2
    End Sub

    Private Sub botonLimpiarFiltros_MouseMove(sender As Object, e As MouseEventArgs) Handles botonLimpiarFiltros.MouseMove
        botonLimpiarFiltros.BackgroundImage = WindowsApplication1.My.Resources.Resources.escoba
    End Sub
End Class