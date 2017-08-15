Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Data.SqlClient
Imports System.Data
Imports System.Drawing.Imaging
Imports System.Drawing.Printing

Public Class ConsultaTotal
    Dim Conex As New MySqlConnection(CADENABASE2)
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Dim rollbackDetalle As String
    Dim rollbackImporte As String
    Dim rollbackCarga As String
    Dim rollbackFechaSolicitud As String
    Dim varCodigoreintegro As String
    Dim varOPREINTEGRO As String = " "
    Dim varOPAUDITORMEDICO As String = " "
    Dim varOPCOMISION As String = " "
    'Dim varSQLCAMPOS As String = "reintegros.codigo_usuario,codigo_reintegro,codigo_beneficiario,fecha_solicitud,detalle,importe,observaciones_carga, " & _
    '                            "usuarios_reintegros.ApellidoNombre,usuarios_reintegros.tipo_usuario,usuarios_reintegros.codigo_seccional,reintegros.CBU," & _
    '                            "reintegros.Alias,reintegros.tipo_reintegro,reintegros.id_Subsidio "

    'parche nuevo --> reemplazar al anterior
    Dim varSQLCAMPOS As String = "reintegros.codigo_usuario,codigo_reintegro,codigo_beneficiario,fecha_solicitud,detalle,importe,observaciones_carga, " & _
                                "usuarios_reintegros.ApellidoNombre,usuarios_reintegros.tipo_usuario,usuarios_reintegros.codigo_seccional,reintegros.CBU," & _
                                "reintegros.Alias,reintegros.tipo_reintegro,reintegros.id_Subsidio,reintegros.Pagado,reintegros.Cuil_Pago,reintegros.tipo_cuenta "




    Private Sub ConsultaTotal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridViewReintegros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        apagaFecha()
        llenarGridCompleto()
        'txtBeneficiario.Focus()
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
    Private Sub llenarGridCompleto() '>>>>>>>>>>>
        Try
            'TRAE TODOS LOS REINTEGROS PENDIENTES
            sql = "SELECT " & varSQLCAMPOS & "FROM REINTEGROS,USUARIOS_REINTEGROS WHERE (reintegros.codigo_usuario = usuarios_reintegros.codigo_usuario)"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridViewReintegros.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'CHECK DE FECHA ACTIVADO O DESACTIVADO
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkFecha.CheckedChanged
        todosLosIF()
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

    'funcion if reintegro o subsidio
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
            varOPREINTEGRO = ""
        End If

    End Sub
 

    'funcion if auditor medico
    Private Sub ifAuditorMedico()
        varOPAUDITORMEDICO = ""
        'PENDIENTE AUDITOR MEDICO (AUDITOR MEDICO APROBADO)
        If (opPendienteAuditor.Checked = True) And (opAuditorMedicoSI.Checked = False And opAuditorRechazado.Checked = False) Then
            varOPAUDITORMEDICO = " "
        End If
        'PENDIENTE DE AUDITOR MEDICO Y APROBADOS
        If (opPendienteAuditor.Checked = True) And (opAuditorMedicoSI.Checked = True) And (opAuditorRechazado.Checked = False) Then
            varOPAUDITORMEDICO = " AND (auditor_medico = 1) "
        End If
        'SOLO APROBADOS POR AUDITOR MEDICO
        If (opPendienteAuditor.Checked = False) And (opAuditorMedicoSI.Checked = True) And (opAuditorRechazado.Checked = False) Then
            varOPAUDITORMEDICO = " AND (auditor_medico = 1) "
        End If
        'PENDIENTE DE AUDITOR MEDICO Y RECHAZADOS
        If (opPendienteAuditor.Checked = True) And (opAuditorMedicoSI.Checked = False) And (opAuditorRechazado.Checked = True) Then
            varOPAUDITORMEDICO = " AND (auditor_medico = 2) "
        End If
        'PENDIENTES - APROBADOS Y RECHAZADOS
        If (opPendienteAuditor.Checked = True) And (opAuditorMedicoSI.Checked = True) And (opAuditorRechazado.Checked = True) Then
            varOPAUDITORMEDICO = " AND (auditor_medico = 1 or auditor_medico = 2) "
        End If
        'APROBADOS Y RECHAZADOS POR AUDITOR MEDICO
        If (opPendienteAuditor.Checked = False) And (opAuditorMedicoSI.Checked = True) And (opAuditorRechazado.Checked = True) Then
            varOPAUDITORMEDICO = " AND (auditor_medico = 1 or auditor_medico = 2) "
        End If
        'SOLO RECHAZADOS POR AUDITOR MEDICO
        If (opPendienteAuditor.Checked = False) And (opAuditorMedicoSI.Checked = False) And (opAuditorRechazado.Checked = True) Then
            varOPAUDITORMEDICO = " AND (auditor_medico = 2) "
        End If
        'APARECEN TODOS LOS REGISTROS SIN FILTRO --> TODAS LAS SOLICITUDES DE REINTEGRO PENDIENTES DE APROBACION PARA AUDITOR
        If (opPendienteAuditor.Checked = False) And (opAuditorMedicoSI.Checked = False) And (opAuditorRechazado.Checked = False) Then
            varOPAUDITORMEDICO = " "
        End If
    End Sub

    'funcion if de comision directiva
    Private Sub ifComision()
        varOPCOMISION = ""
        'PENDIENTE COMISION (AUDITOR MEDICO APROBADO)
        If (opComisionPendientes.Checked = True) And (opComisionAprobados.Checked = False) And (opComisionRechazados.Checked = False) And (opPAGADO.Checked = False) Then
            varOPCOMISION = " "
            opAuditorMedicoSI.Checked = True
        End If

        'PENDIENTE DE COMISION Y APROBADOS
        If (opComisionAprobados.Checked = True) And (opComisionRechazados.Checked = False) And (opPAGADO.Checked = False) Then
            varOPCOMISION = " AND (Estado = 1) "
        End If
        'SOLO APROBADOS POR COMISION
        If (opComisionPendientes.Checked = False) And (opComisionAprobados.Checked = True) And (opComisionRechazados.Checked = False) And (opPAGADO.Checked = False) Then
            varOPCOMISION = " AND (Estado = 1) "
        End If
        'RECHAZADOS por comision
        If (opComisionAprobados.Checked = False) And (opComisionRechazados.Checked = True) And (opPAGADO.Checked = False) Then
            varOPCOMISION = " AND (Estado = 2) "

        End If
        'APROBADOS Y RECHAZADOS
        If (opComisionAprobados.Checked = True) And (opComisionRechazados.Checked = True) And (opPAGADO.Checked = False) Then
            varOPCOMISION = " AND (Estado = 1) or (Estado = 2) "
        End If

        'APARECEN TODOS LOS REGISTROS SIN FILTRO --> PERO SI APROBADOS POR AUDITOR MEDICO
        If (opComisionAprobados.Checked = False) And (opComisionRechazados.Checked = False) And (opPAGADO.Checked = False) Then
            varOPCOMISION = " "
        End If
        'LOS APROBADOS POR COMISION Y LOS PAGADOS OK
        If (opComisionAprobados.Checked = True) And (opComisionRechazados.Checked = False) And (opPAGADO.Checked = True) Then
            varOPCOMISION = " AND (Estado = 1) or (Estado = 3) "
        End If
        'PENDIENTES DE COMISION, LOS RECHAZADOS Y LOS PAGADOS
        If (opComisionAprobados.Checked = False) And (opComisionRechazados.Checked = True) And (opPAGADO.Checked = True) Then
            varOPCOMISION = " AND (Estado = 2) or (Estado = 3) "
        End If
        'LOS PAGADOS
        If (opComisionAprobados.Checked = False) And (opComisionRechazados.Checked = False) And (opPAGADO.Checked = True) Then
            varOPCOMISION = " AND (Estado = 3) "

        End If
        'LOS APROBADOS POR COMISION, LOS RECHAZADOS Y LOS PAGADOS
        If (opComisionAprobados.Checked = True) And (opComisionRechazados.Checked = True) And (opPAGADO.Checked = True) Then
            varOPCOMISION = " AND (Estado=1) or (Estado = 2) or (Estado = 3) "

        End If
        'LOS APROBADOS POR COMISION Y PAGADOS OK >>><<<
        If (opComisionAprobados.Checked = True) And (opComisionRechazados.Checked = False) And (opPAGADO.Checked = True) Then
            varOPCOMISION = " AND (Estado=1) or (Estado = 3) "
        End If
        'LOS RECHAZADOS Y LOS PAGADOS OK
        If (opComisionAprobados.Checked = False) And (opComisionRechazados.Checked = True) And (opPAGADO.Checked = True) Then
            varOPCOMISION = " AND (Estado=2) or (Estado = 3) "

        End If
        'TODOS LOS PAGADOS
        If (opComisionAprobados.Checked = False) And (opComisionRechazados.Checked = False) And (opPAGADO.Checked = True) Then
            varOPCOMISION = " AND (Estado=3) "
        End If

    End Sub

    'clic en reintegro
    Private Sub opReintegro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opReintegro.CheckedChanged
        todosLosIF()
        BuscarDato()
    End Sub
    'clic en subsidio
    Private Sub opSubsidio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opSubsidio.CheckedChanged
        todosLosIF()
        BuscarDato()
    End Sub

    'escribo en el buscador
    Private Sub txtBeneficiario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBeneficiario.TextChanged
        todosLosIF()
        BuscarDato()
    End Sub

    'click auditor medico pendiente
    Private Sub opPendienteAuditor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opPendienteAuditor.CheckedChanged
        todosLosIF()
        BuscarDato()
    End Sub

    'clic auditor medico aprobado
    Private Sub opAuditorMedicoSI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opAuditorMedicoSI.CheckedChanged
        todosLosIF()
        BuscarDato()
    End Sub

    'clic en auditor rechazado
    Private Sub opAuditorRechazado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opAuditorRechazado.CheckedChanged
        todosLosIF()
        BuscarDato()
    End Sub

    'clic en comision pendiente
    Private Sub opComisionPendientes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opComisionPendientes.CheckedChanged
        If opComisionPendientes.Checked = True Then
            opAuditorMedicoSI.Checked = True
        Else
        End If
        todosLosIF()
        'BuscarDato()
    End Sub

    'clic en comision aprobada
    Private Sub opComisionAprobados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opComisionAprobados.CheckedChanged
        todosLosIF()
        BuscarDato()

    End Sub

    'clic en comision rechazada
    Private Sub opComisionRechazados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opComisionRechazados.CheckedChanged
        todosLosIF()
        BuscarDato()
    End Sub

    'clic en pago pendiente
    Private Sub opPagoPendiente_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opPagoPendiente.CheckedChanged
        If opPagoPendiente.Checked = True Then
            opComisionAprobados.Checked = True
            'opAuditorMedicoSI.Checked = True
        Else
        End If
        todosLosIF()
        'BuscarDato()
    End Sub

    'clic en pagados
    Private Sub opPAGADO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opPAGADO.CheckedChanged
        todosLosIF()
        BuscarDato()
    End Sub

    '<<<<<<<<<<>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<>>>>>> LLAMA A TODOS LOS IF CHECK >>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>><<<<<<<<<<
    Private Sub todosLosIF()
        ifReintegroOSubsidio()
        ifAuditorMedico()
        ifComision()
    End Sub
    Private Sub BuscarDato()
        Try
            If txtFechaDesde.Text = "" And txtFechaDesde.Text = "" Then
                sql = "SELECT " & varSQLCAMPOS & " FROM REINTEGROS,USUARIOS_REINTEGROS WHERE (reintegros.codigo_usuario = usuarios_reintegros.codigo_usuario) " & _
                        " and Detalle LIKE '%" & txtBeneficiario.Text.ToString & "%' " & varOPREINTEGRO & varOPAUDITORMEDICO & varOPCOMISION
            Else
                sql = "SELECT " & varSQLCAMPOS & "FROM REINTEGROS,USUARIOS_REINTEGROS WHERE (reintegros.codigo_usuario = usuarios_reintegros.codigo_usuario) " & _
                        " and Detalle LIKE '%" & txtBeneficiario.Text.ToString & "%' " & _
                   "AND (Fecha_Solicitud BETWEEN '" & txtFechaDesde.Text.ToString & "' " & _
                   "AND '" & txtFechaHasta.Text.ToString & "')" & varOPREINTEGRO & varOPAUDITORMEDICO & varOPCOMISION
            End If
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridViewReintegros.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BuscarDatoFecha()
        Try
            If txtFechaDesde.Text = "" And txtFechaDesde.Text = "" Then
                sql = "SELECT reintegros.codigo_usuario,codigo_reintegro,codigo_beneficiario,fecha_solicitud,detalle, " & _
                    "importe,observaciones_carga,usuarios_reintegros.ApellidoNombre,usuarios_reintegros.tipo_usuario, " & _
                    "usuarios_reintegros.codigo_seccional,reintegros.imagen1,reintegros.imagen2,reintegros.imagen3,reintegros.imagen4,reintegros.imagen5, " & _
                    "reintegros.CBU,reintegros.Alias,reintegros.tipo_reintegro,reintegros.id_Subsidio " & _
                    "FROM REINTEGROS,USUARIOS_REINTEGROS WHERE Detalle LIKE '%" & txtBeneficiario.Text.ToString & "%'"
            Else

                sql = "SELECT reintegros.codigo_usuario,codigo_reintegro,codigo_beneficiario,fecha_solicitud,detalle, " & _
                    "importe,observaciones_carga,usuarios_reintegros.ApellidoNombre,usuarios_reintegros.tipo_usuario, " & _
                    "usuarios_reintegros.codigo_seccional,reintegros.imagen1,reintegros.imagen2,reintegros.imagen3,reintegros.imagen4,reintegros.imagen5, " & _
                    "reintegros.CBU,reintegros.Alias,reintegros.tipo_reintegro,reintegros.id_Subsidio " & _
                    "FROM REINTEGROS,USUARIOS_REINTEGROS WHERE Detalle LIKE '%" & txtBeneficiario.Text.ToString & "%' AND (Fecha_Solicitud BETWEEN '" & txtFechaDesde.Text.ToString & "' AND '" & txtFechaHasta.Text.ToString & "')"

            End If
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridViewReintegros.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtFechaHasta_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFechaHasta.TextChanged
        todosLosIF()
        BuscarDato()
    End Sub

    Private Sub txtFechaDesde_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFechaDesde.TextChanged
        todosLosIF()
        BuscarDato()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        todosLosIF()
        txtFechaDesde.Text = DateTimePicker1.Value.Year & "-" & DateTimePicker1.Value.Month & "-" & DateTimePicker1.Value.Day
        txtFechaHasta.Text = DateTimePicker2.Value.Year & "-" & DateTimePicker2.Value.Month & "-" & DateTimePicker2.Value.Day
        BuscarDato()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        todosLosIF()
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
    Private Sub GridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridViewReintegros.CellClick
        clbimagen.Items.Clear()
        lblPicture.Image = Nothing
        Dim SQL2 As String
        Dim MiConexion2 As New MySqlConnection(CADENABASE2)
        Dim Rs2 As MySqlDataReader
        Dim Com2 As New MySqlCommand
        Com2.Connection = MiConexion2
        MiConexion2.Open()
        varCodigoreintegro = Int(Me.GridViewReintegros.Rows(e.RowIndex).Cells(1).Value)
        SQL2 = "select Imagen1,Imagen2,Imagen3,Imagen4,Imagen5 from reintegros where codigo_reintegro = '" & Me.GridViewReintegros.Rows(e.RowIndex).Cells(1).Value & "'"
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
            lblfe1.Text = Me.GridViewReintegros.Rows(e.RowIndex).Cells(3).Value
            Dim fechacreacion As Date
            fechacreacion = lblfe1.Text
            lblfe2.Text = Format(fechacreacion, "yyyy/MM/dd")
            'af
            txtDetalle.Text = Me.GridViewReintegros.Rows(e.RowIndex).Cells(4).Value
            rollbackDetalle = txtDetalle.Text
            txtImporte.Text = Me.GridViewReintegros.Rows(e.RowIndex).Cells(5).Value
            rollbackImporte = txtImporte.Text
            txtObservacionesCarga.Text = Me.GridViewReintegros.Rows(e.RowIndex).Cells(6).Value
            txtCBU.Text = Me.GridViewReintegros.Rows(e.RowIndex).Cells(10).Value
            txtAlias.Text = Me.GridViewReintegros.Rows(e.RowIndex).Cells(11).Value
            'si es 0 es reintegro
            If (Me.GridViewReintegros.Rows(e.RowIndex).Cells(12).Value) = 0 Then
                lblTipoReintegro.Text = "ES REINTEGRO"
            End If
            'si es 1 es subsidio
            If (Me.GridViewReintegros.Rows(e.RowIndex).Cells(12).Value) = 1 Then
                If (Me.GridViewReintegros.Rows(e.RowIndex).Cells(13).Value) = 1 Then lblTipoReintegro.Text = "ES SUBSIDIO POR NACIMIENTO"
                If (Me.GridViewReintegros.Rows(e.RowIndex).Cells(13).Value) = 2 Then lblTipoReintegro.Text = "ES SUBSIDIO POR FALLECIMIENTO"
            End If
            txtCuilPago.Text = Me.GridViewReintegros.Rows(e.RowIndex).Cells(15).Value
            'FALTAN LOS ROLLBACK
            txtTipoCuenta.Text = Me.GridViewReintegros.Rows(e.RowIndex).Cells(16).Value
            'falta rollback
            rollbackCarga = txtObservacionesCarga.Text
            txtFechaSolicitud.Text = lblfe2.Text
            rollbackFechaSolicitud = txtFechaSolicitud.Text
            botonModificaSolicitud.Visible = True
            botonModificaSolicitud.Enabled = True
            botonEliminarSolicitud.Visible = True
        Catch
        End Try
    End Sub

    'click en celda llena listbox con imagenes
    Private Sub GridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridViewReintegros.CellContentClick
        'lleno listbox con imagenes de la base *************************************************
        clbimagen.Items.Clear()
        lblPicture.Image = Nothing
        Dim SQL2 As String
        Dim MiConexion2 As New MySqlConnection(CADENABASE2)
        Dim Rs2 As MySqlDataReader
        Dim Com2 As New MySqlCommand
        Com2.Connection = MiConexion2
        MiConexion2.Open()
        varCodigoreintegro = Int(Me.GridViewReintegros.Rows(e.RowIndex).Cells(1).Value)
        SQL2 = "select Imagen1,Imagen2,Imagen3,Imagen4,Imagen5 from reintegros where codigo_reintegro = '" & Me.GridViewReintegros.Rows(e.RowIndex).Cells(1).Value & "'"
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
        '***************************** fin llenado listbox ***************************************

        'llena textbox con datos de operacion
        Try
            'arreglo fecha al inverso
            lblfe1.Text = Me.GridViewReintegros.Rows(e.RowIndex).Cells(3).Value
            Dim fechacreacion As Date
            fechacreacion = lblfe1.Text
            lblfe2.Text = Format(fechacreacion, "yyyy/MM/dd")
            'label reintegro o subsidio

            txtDetalle.Text = Me.GridViewReintegros.Rows(e.RowIndex).Cells(4).Value
            rollbackDetalle = txtDetalle.Text
            txtImporte.Text = Me.GridViewReintegros.Rows(e.RowIndex).Cells(5).Value
            rollbackImporte = txtImporte.Text
            txtObservacionesCarga.Text = Me.GridViewReintegros.Rows(e.RowIndex).Cells(6).Value
            txtCBU.Text = Me.GridViewReintegros.Rows(e.RowIndex).Cells(10).Value
            txtAlias.Text = Me.GridViewReintegros.Rows(e.RowIndex).Cells(11).Value
            'si es 0 es reintegro
            If (Me.GridViewReintegros.Rows(e.RowIndex).Cells(12).Value) = 0 Then
                lblTipoReintegro.Text = "ES REINTEGRO"
            End If
            'si es 1 es subsidio
            If (Me.GridViewReintegros.Rows(e.RowIndex).Cells(12).Value) = 1 Then
                If (Me.GridViewReintegros.Rows(e.RowIndex).Cells(13).Value) = 1 Then lblTipoReintegro.Text = "ES SUBSIDIO POR NACIMIENTO"
                If (Me.GridViewReintegros.Rows(e.RowIndex).Cells(13).Value) = 2 Then lblTipoReintegro.Text = "ES SUBSIDIO POR FALLECIMIENTO"
            End If
            txtCuilPago.Text = Me.GridViewReintegros.Rows(e.RowIndex).Cells(15).Value
            'FALTAN LOS ROLLBACK
            txtTipoCuenta.Text = Me.GridViewReintegros.Rows(e.RowIndex).Cells(16).Value
            'falta rollback
            rollbackCarga = txtObservacionesCarga.Text
            txtFechaSolicitud.Text = lblfe2.Text
            rollbackFechaSolicitud = txtFechaSolicitud.Text
            botonModificaSolicitud.Visible = True
            botonModificaSolicitud.Enabled = True
            botonEliminarSolicitud.Visible = True
        Catch
        End Try
    End Sub
    '*******************************************************************************************************************************************************
    'VISTA PREVIA DEL PICTUREBOX AL SELECCIONAR EN EL COMBOLIST
    Private Sub clbimagen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbimagen.SelectedIndexChanged
        Try
            lblPicture.Image = clbimagen.SelectedItem
        Catch ex As Exception
        End Try
    End Sub
    Private Sub GridView1_CellContextMenuStripChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridViewReintegros.CellContextMenuStripChanged
        clbimagen.Items.Clear()
        clbimagen.Items.Add(DeImagen_a_Bytes(Me.GridViewReintegros.Rows(e.RowIndex).Cells(10).Value))
        clbimagen.Items.Add(DeImagen_a_Bytes(Me.GridViewReintegros.Rows(e.RowIndex).Cells(11).Value))
        clbimagen.Items.Add(DeImagen_a_Bytes(Me.GridViewReintegros.Rows(e.RowIndex).Cells(12).Value))
        clbimagen.Items.Add(DeImagen_a_Bytes(Me.GridViewReintegros.Rows(e.RowIndex).Cells(13).Value))
        clbimagen.Items.Add(DeImagen_a_Bytes(Me.GridViewReintegros.Rows(e.RowIndex).Cells(14).Value))
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
    '  Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
    ' e.Graphics.DrawImage(lblPicture.Image, 10, 20, 900, 920)
    'End Sub

    'IMPRIMIR
    Private Sub imprimir()
        If MsgBox("¿Desea Imprimir la Imagen Seleccionada?", vbYesNo + vbQuestion) = vbYes Then
            Dim oPrintDoc As PrintDocument = New PrintDocument()
            AddHandler oPrintDoc.PrintPage, AddressOf ImprimirGrafico
            oPrintDoc.Print()
        Else
        End If
    End Sub
    Private Sub EnabledTextOff()
        txtDetalle.Enabled = False
        txtImporte.Enabled = False
        txtObservacionesCarga.Enabled = False
        txtFechaSolicitud.Enabled = False
        DateTimePicker3.Enabled = False
        txtCBU.Enabled = False
        txtAlias.Enabled = False
        txtCuilPago.Enabled = False
        txtTipoCuenta.Enabled = False
    End Sub

    Private Sub EnabledTextOn()
        txtDetalle.Enabled = True
        txtImporte.Enabled = True
        txtObservacionesCarga.Enabled = True
        'txtFechaSolicitud.Enabled = True
        DateTimePicker3.Enabled = True
        txtCBU.Enabled = True
        txtAlias.Enabled = True
        txtCuilPago.Enabled = True
        txtTipoCuenta.Enabled = True
    End Sub

    Private Sub PrendeBotones()
        OK.Visible = True
        CANCELA.Visible = True
        botonImagen.Visible = True
        botonQuitarImagen.Visible = True
    End Sub
    Private Sub ApagaBotones()
        OK.Visible = False
        CANCELA.Visible = False
        botonImagen.Visible = False
        botonQuitarImagen.Visible = False
    End Sub

    Private Sub botonModificaSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botonModificaSolicitud.Click
        botonModificaSolicitud.Enabled = False
        GridViewReintegros.Enabled = False
        EnabledTextOn()
        PrendeBotones()
    End Sub

    Private Sub CANCELA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELA.Click
        EnabledTextOff()
        ApagaBotones()
        rollbackearDatos()
        botonModificaSolicitud.Enabled = True
        GridViewReintegros.Enabled = True
    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If MsgBox("¿Desea Guardar los cambios realizados?", vbYesNo + vbQuestion) = vbYes Then
            ProgressBar1.Visible = True
            ProgressBar1.Increment(100)
            update_To()
            ApagaBotones()
            EnabledTextOff()
            llenarGridCompleto()
            ProgressBar1.Value = 0
        Else
            ApagaBotones()
            EnabledTextOff()
            rollbackearDatos()
            botonModificaSolicitud.Enabled = True
        End If
        GridViewReintegros.Enabled = True
    End Sub
    Private Sub rollbackearDatos()
        txtDetalle.Text = rollbackDetalle.ToString
        txtImporte.Text = rollbackImporte
        txtObservacionesCarga.Text = rollbackCarga
        txtFechaSolicitud.Text = rollbackFechaSolicitud
    End Sub

    Private Sub DateTimePicker3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker3.ValueChanged
        txtFechaSolicitud.Text = DateTimePicker3.Value.Year & "-" & DateTimePicker3.Value.Month & "-" & DateTimePicker3.Value.Day
    End Sub

    Private Sub update_To()
        Using con_insert As New MySqlConnection(CADENABASE2)
            Dim cmdinsert As New MySqlCommand
            Dim varimp As Double = Convert.ToDouble(txtImporte.Text)
            With cmdinsert
                .Connection = con_insert
                .CommandType = CommandType.Text
                .CommandText = "UPDATE `reintegros` SET detalle=?detalle,importe=?importe,Observaciones_Carga=?obscarga,fecha_solicitud=?fecsol,CBU =?cbu,Alias=?alias,Cuil_Pago=?cuilpago,Tipo_Cuenta=?tipocuenta WHERE codigo_reintegro = ?codre"
                .Parameters.AddWithValue("?codre", varCodigoreintegro)
                .Parameters.AddWithValue("?detalle", txtDetalle.Text.ToString)
                .Parameters.AddWithValue("?importe", varimp)
                .Parameters.AddWithValue("?obscarga", txtObservacionesCarga.Text.ToString)
                .Parameters.AddWithValue("?fecsol", txtFechaSolicitud.Text.ToString)
                .Parameters.AddWithValue("?cbu", txtCBU.Text.ToString)
                .Parameters.AddWithValue("?alias", txtAlias.Text.ToString)
                .Parameters.AddWithValue("?cuilpago", txtCuilPago.Text.ToString)
                .Parameters.AddWithValue("?tipocuenta", txtTipoCuenta.Text.ToString)

            End With
            Try
                con_insert.Open()
                cmdinsert.ExecuteNonQuery()
                con_insert.Close()
                MessageBox.Show("UPDATE en BD OK", "Actualizacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch falla As MySqlException
                MsgBox(falla.Message)
            End Try
        End Using
    End Sub

    'boton eliminar
    Private Sub botonEliminarSolicitud_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botonEliminarSolicitud.Click
        If MsgBox("¿Desea Realmente Eliminar la Solicitud de reintegro seleccionada?", vbYesNo + vbQuestion) = vbYes Then
            ProgressBar1.Visible = True
            ProgressBar1.Increment(100)
            delete_to()
            ApagaBotones()
            EnabledTextOff()
            llenarGridCompleto()
            ProgressBar1.Value = 0
        Else
            ApagaBotones()
            EnabledTextOff()
            rollbackearDatos()
            botonModificaSolicitud.Enabled = True
        End If
    End Sub
    'metodo eliminar registro
    Private Sub delete_to()
        Using con_insert As New MySqlConnection(CADENABASE2)
            Dim cmdinsert As New MySqlCommand
            With cmdinsert
                .Connection = con_insert
                .CommandType = CommandType.Text 'Delete from tipo_subsidio where id_subsidio = 3
                .CommandText = "DELETE from `reintegros` WHERE codigo_reintegro = ?codre"
                .Parameters.AddWithValue("?codre", varCodigoreintegro)
            End With
            Try
                con_insert.Open()
                cmdinsert.ExecuteNonQuery()
                con_insert.Close()
                MessageBox.Show("Eliminado, UPDATE en BD OK", "Actualizacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch falla As MySqlException
                MsgBox(falla.Message)
            End Try
        End Using
    End Sub

    Private Sub botonLimpiarFiltros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botonLimpiarFiltros.Click
        opReintegro.Checked = False
        opSubsidio.Checked = False
        opAuditorMedicoSI.Checked = False
        opAuditorRechazado.Checked = False
        opComisionAprobados.Checked = False
        opComisionPendientes.Checked = False
        opComisionRechazados.Checked = False
        opPagoPendiente.Checked = False
        opPAGADO.Checked = False
    End Sub
End Class