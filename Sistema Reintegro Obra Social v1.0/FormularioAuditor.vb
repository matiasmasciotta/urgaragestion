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
    Dim varOPREINTEGRO As String = " "
    Dim varOPAUDITORMEDICO As String = " "
    Dim varOPCOMISION As String = " "
    Dim varOPPAGADO As String = " "
    Dim varTempDetalle As String = ""
    Dim varTempImporte As String = ""
    Dim varTempUsuarioSolicitante As String = ""
    Dim varTempCBU As String = ""
    Dim varTempAlias As String = ""
    Dim varTempCuilPago As String = ""
    Dim varTempTipoCuenta As String = ""
    Dim varTempNombreBeneficiario As String = ""
    Dim varSQLCAMPOS As String = " reintegros.codigo_usuario,reintegros.codigo_reintegro,reintegros.codigo_beneficiario," & _
                                 "reintegros.fecha_solicitud,reintegros.detalle,reintegros.importe,reintegros.observaciones_carga," & _
                                 "usuarios_reintegros.ApellidoNombre,usuarios_reintegros.tipo_usuario,usuarios_reintegros.codigo_seccional," & _
                                 "reintegros.CBU,reintegros.Alias,reintegros.tipo_reintegro,reintegros.id_Subsidio,reintegros.Pagado," & _
                                 "reintegros.Cuil_Pago,reintegros.tipo_cuenta,cuil_beneficiario,beneficiarios.ApellidoNombre "
    '(00)reintegros.codigo_usuario
    '(01)reintegros.codigo_reintegro
    '(02)reintegros.codigo_beneficiario
    '(03)reintegros.fecha_solicitud
    '(04)reintegros.detalle
    '(05)reintegros.importe
    '(06)reintegros.observaciones_carga
    '(07)usuarios_reintegros.ApellidoNombre
    '(08)usuarios_reintegros.tipo_usuario
    '(09)usuarios_reintegros.codigo_seccional
    '(10)reintegros.CBU
    '(11)reintegros.Alias
    '(12)reintegros.tipo_reintegro
    '(13)reintegros.id_Subsidio
    '(14)reintegros.Pagado
    '(15)reintegros.Cuil_Pago
    '(16)reintegros.tipo_cuenta
    '(17)reintegros.cuil_beneficiario 
    '(18)beneficiarios.ApellidoNombre
    Dim varSQLFROM As String = " FROM reintegros "
    Dim varSQLLEFT1 As String = " LEFT JOIN usuarios_reintegros ON (reintegros.CODIGO_USUARIO = usuarios_reintegros.CODIGO_USUARIO) "
    Dim varSQLLEFT2 As String = " LEFT JOIN beneficiarios ON ((reintegros.Codigo_Beneficiario = Beneficiarios.Codigo_Beneficiario) " & _
                                "AND (reintegros.Cuil_Beneficiario = beneficiarios.Cuil)) "

    Dim varAudMed As Integer
    Dim det As String = ""
    Dim varOPNUMREINTEGRO As String = ""
    Dim varUserSeccional As String = ""
    Dim varFILTROSECCIONAL As String = ""
    Dim varOPCUIL As String = ""
    Dim varSQLSECCIONALES As String = " usuarios_reintegros.codigo_usuario,usuarios_reintegros.apellidonombre,seccionales.descripcion "


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
            sql = "SELECT " & varSQLCAMPOS & varSQLFROM & varSQLLEFT1 & varSQLLEFT2 & "WHERE (Auditor_Medico = 0) order by reintegros.codigo_reintegro desc"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'grid aprobados 
        Try
            sql = "SELECT " & varSQLCAMPOS & varSQLFROM & varSQLLEFT1 & varSQLLEFT2 & "WHERE (Auditor_Medico = 1) order by reintegros.codigo_reintegro desc"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView2.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'grid rechazados
        Try
            sql = "SELECT " & varSQLCAMPOS & varSQLFROM & varSQLLEFT1 & varSQLLEFT2 & "WHERE (Auditor_Medico = 2) order by reintegros.codigo_reintegro desc"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView3.DataSource = dt
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



    Private Sub BuscarDato()
        'grid pendientes 12/10/2017
        Try
            If txtFechaDesde.Text = "" And txtFechaDesde.Text = "" Then
                sql = "SELECT " & varSQLCAMPOS & varSQLFROM & varSQLLEFT1 & varSQLLEFT2 & "WHERE (Detalle " & _
                    "LIKE '%" & txtBeneficiario.Text.ToString & "%') AND (Auditor_medico=0) " & varOPNUMREINTEGRO & varOPCUIL & varOPREINTEGRO & varFILTROSECCIONAL & " order by reintegros.codigo_reintegro desc"
            Else
                sql = "SELECT " & varSQLCAMPOS & varSQLFROM & varSQLLEFT1 & varSQLLEFT2 & "WHERE (Detalle LIKE '%" & txtBeneficiario.Text.ToString & "%') AND " & _
                    "(Fecha_Solicitud BETWEEN '" & txtFechaDesde.Text.ToString & "' AND '" & txtFechaHasta.Text.ToString & "') and " & _
                    "(Auditor_Medico = 0) " & varOPNUMREINTEGRO & varOPCUIL & varOPREINTEGRO & varFILTROSECCIONAL & " order by reintegros.codigo_reintegro desc"
            End If
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'grid aprobados
        Try
            If txtFechaDesde.Text = "" And txtFechaDesde.Text = "" Then
                sql = "SELECT " & varSQLCAMPOS & varSQLFROM & varSQLLEFT1 & varSQLLEFT2 & "WHERE (Detalle LIKE '%" & txtBeneficiario.Text.ToString & "%') and " & _
                    "(Auditor_medico=1) " & varOPNUMREINTEGRO & varOPCUIL & varOPREINTEGRO & varOPCOMISION & varOPPAGADO & varFILTROSECCIONAL & " order by reintegros.codigo_reintegro desc"
            Else
                sql = "SELECT " & varSQLCAMPOS & varSQLFROM & varSQLLEFT1 & varSQLLEFT2 & "WHERE (Detalle LIKE '%" & txtBeneficiario.Text.ToString & "%') AND " & _
                    "(Fecha_Solicitud BETWEEN '" & txtFechaDesde.Text.ToString & "' AND '" & txtFechaHasta.Text.ToString & "') and " & _
                    "(Auditor_Medico = 1) " & varOPNUMREINTEGRO & varOPCUIL & varOPREINTEGRO & varOPCOMISION & varOPPAGADO & varFILTROSECCIONAL & " order by reintegros.codigo_reintegro desc"
            End If
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView2.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'grid rechazados
        Try
            If txtFechaDesde.Text = "" And txtFechaDesde.Text = "" Then
                sql = "SELECT " & varSQLCAMPOS & varSQLFROM & varSQLLEFT1 & varSQLLEFT2 & "WHERE (Detalle LIKE '%" & txtBeneficiario.Text.ToString & "%') and " & _
                    "(Auditor_medico=2) " & varOPNUMREINTEGRO & varOPCUIL & varOPREINTEGRO & varFILTROSECCIONAL & " order by reintegros.codigo_reintegro desc"
            Else
                sql = "SELECT " & varSQLCAMPOS & varSQLFROM & varSQLLEFT1 & varSQLLEFT2 & "WHERE (Detalle LIKE '%" & txtBeneficiario.Text.ToString & "%') AND " & _
                    "(Fecha_Solicitud BETWEEN '" & txtFechaDesde.Text.ToString & "' AND '" & txtFechaHasta.Text.ToString & "') and " & _
                    "(Auditor_Medico = 2) " & varOPNUMREINTEGRO & varOPCUIL & varOPREINTEGRO & varFILTROSECCIONAL & " order by reintegros.codigo_reintegro desc"
            End If
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView3.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    'Funcion IF PAGADO
    Private Sub ifPagados()
        varOPPAGADO = ""
        If (opPagoPendiente.Checked = True) And (opPAGADO.Checked = False) Then
            varOPPAGADO = " AND (Pagado = 0) "
            If opPagoPendiente.Checked = True Then
                opComisionAprobados.Checked = True
                opAuditorMedicoSI.Checked = True
                opComisionRechazados.Enabled = False
                opComisionPendientes.Enabled = False
                opComisionAprobados.Enabled = False
                opPAGADO.Enabled = False
                opAuditorMedicoSI.Enabled = False
                opAuditorRechazado.Enabled = False
                opPendienteAuditor.Enabled = False
            End If
        End If
        If (opPagoPendiente.Checked = True) And (opPAGADO.Checked = True) Then
            varOPPAGADO = " AND (Pagado=0) or (Pagado=1)"
        End If
        If (opPagoPendiente.Checked = False) And (opPAGADO.Checked = True) Then
            varOPPAGADO = " AND (Pagado = 1) "
            opComisionAprobados.Checked = True
            opAuditorMedicoSI.Checked = True
            opComisionRechazados.Enabled = False
            opComisionPendientes.Enabled = False
            opComisionAprobados.Enabled = False
            opPagoPendiente.Enabled = False
            opAuditorMedicoSI.Enabled = False
            opAuditorRechazado.Enabled = False
            opPendienteAuditor.Enabled = False
        End If
        If (opPagoPendiente.Checked = False) And (opPAGADO.Checked = False) Then
            varOPPAGADO = " "
            habilitaCheck()
        End If
    End Sub
    Private Sub habilitaCheck()
        opSubsidio.Enabled = True
        opReintegro.Enabled = True
        opAuditorMedicoSI.Enabled = True
        opAuditorRechazado.Enabled = True
        opPendienteAuditor.Enabled = True
        opComisionAprobados.Enabled = True
        opComisionRechazados.Enabled = True
        opComisionPendientes.Enabled = True
        opPAGADO.Enabled = True
        opPagoPendiente.Enabled = True
    End Sub


    'funcion if de comision directiva <>>>>>>>>>>><<<<<<<<<
    Private Sub ifComision()
        varOPCOMISION = ""
        'PENDIENTE AUDITOR MEDICO (AUDITOR MEDICO APROBADO)
        If (opComisionPendientes.Checked = True) And (opComisionAprobados.Checked = False And opComisionRechazados.Checked = False) Then
            varOPCOMISION = " AND (Estado = 0)"
            opAuditorMedicoSI.Checked = True
        End If
        'PENDIENTE DE AUDITOR MEDICO Y APROBADOS
        If (opComisionPendientes.Checked = True) And (opComisionAprobados.Checked = True) And (opComisionRechazados.Checked = False) Then
            varOPCOMISION = " AND (Estado = 1) "
        End If
        'SOLO APROBADOS POR AUDITOR MEDICO
        If (opComisionPendientes.Checked = False) And (opComisionAprobados.Checked = True) And (opComisionRechazados.Checked = False) Then
            varOPCOMISION = " AND (Estado = 1) "
            opAuditorMedicoSI.Checked = True
        End If
        'PENDIENTE DE AUDITOR MEDICO Y RECHAZADOS
        If (opComisionPendientes.Checked = True) And (opComisionAprobados.Checked = False) And (opComisionRechazados.Checked = True) Then
            varOPCOMISION = " AND (Estado = 2) "
        End If
        'PENDIENTES - APROBADOS Y RECHAZADOS
        If (opComisionPendientes.Checked = True) And (opComisionAprobados.Checked = True) And (opComisionRechazados.Checked = True) Then
            varOPCOMISION = " AND (Estado = 1) or (Estado = 2) "
        End If
        'APROBADOS Y RECHAZADOS POR AUDITOR MEDICO
        If (opComisionPendientes.Checked = False) And (opComisionAprobados.Checked = True) And (opComisionRechazados.Checked = True) Then
            varOPCOMISION = " AND (Estado = 1) or (Estado = 2) "
        End If
        'SOLO RECHAZADOS POR AUDITOR MEDICO
        If (opComisionPendientes.Checked = False) And (opComisionAprobados.Checked = False) And (opComisionRechazados.Checked = True) Then
            varOPCOMISION = " AND (Estado = 2) "
            opAuditorMedicoSI.Checked = True
        End If
        'APARECEN TODOS LOS REGISTROS SIN FILTRO --> TODAS LAS SOLICITUDES DE REINTEGRO PENDIENTES DE APROBACION PARA AUDITOR
        If (opComisionPendientes.Checked = False) And (opComisionAprobados.Checked = False) And (opComisionRechazados.Checked = False) Then
            varOPCOMISION = " "
            habilitaCheck()
        End If
    End Sub

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

    '<<<<<<<<<<>>>>>>>>>>>>><<<<<<<<<<<<<<<<<<>>>>>> LLAMA A TODOS LOS IF CHECK >>>>>>>>>>>>>>><<<<<<<<<<<<<<>>>>>>>>>>>>>>>>>><<<<<<<<<<
    Private Sub todosLosIF()
        ifReintegroOSubsidio()
        ifAuditorMedico()
        ifComision()
        ifPagados()
    End Sub
    'funcion if auditor medico
    Private Sub ifAuditorMedico()
        varOPAUDITORMEDICO = ""
        'PENDIENTE AUDITOR MEDICO (AUDITOR MEDICO APROBADO)
        If (opPendienteAuditor.Checked = True) And (opAuditorMedicoSI.Checked = False) And (opAuditorRechazado.Checked = False) Then
            varOPAUDITORMEDICO = " AND (auditor_medico = 0)"
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
            varOPAUDITORMEDICO = " AND (auditor_medico = 1) or (auditor_medico = 2) "
        End If
        'APROBADOS Y RECHAZADOS POR AUDITOR MEDICO
        If (opPendienteAuditor.Checked = False) And (opAuditorMedicoSI.Checked = True) And (opAuditorRechazado.Checked = True) Then
            varOPAUDITORMEDICO = " AND (auditor_medico = 1) or (auditor_medico = 2) "
        End If
        'SOLO RECHAZADOS POR AUDITOR MEDICO
        If (opPendienteAuditor.Checked = False) And (opAuditorMedicoSI.Checked = False) And (opAuditorRechazado.Checked = True) Then
            varOPAUDITORMEDICO = " AND (auditor_medico = 2) "
        End If
        'APARECEN TODOS LOS REGISTROS SIN FILTRO --> TODAS LAS SOLICITUDES DE REINTEGRO PENDIENTES DE APROBACION PARA AUDITOR
        If (opPendienteAuditor.Checked = False) And (opAuditorMedicoSI.Checked = False) And (opAuditorRechazado.Checked = False) Then
            varOPAUDITORMEDICO = " "
            habilitaCheck()
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
            varTempDetalle = Me.GridView1.Rows(e.RowIndex).Cells(4).Value
            varTempImporte = Me.GridView1.Rows(e.RowIndex).Cells(5).Value
            varTempUsuarioSolicitante = Me.GridView1.Rows(e.RowIndex).Cells(7).Value
            varTempCBU = Me.GridView1.Rows(e.RowIndex).Cells(10).Value
            varTempAlias = Me.GridView1.Rows(e.RowIndex).Cells(11).Value
            varTempCuilPago = Me.GridView1.Rows(e.RowIndex).Cells(15).Value
            varTempTipoCuenta = Me.GridView1.Rows(e.RowIndex).Cells(16).Value
            varTempNombreBeneficiario = Me.GridView1.Rows(e.RowIndex).Cells(18).Value
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
            varTempDetalle = Me.GridView1.Rows(e.RowIndex).Cells(4).Value
            varTempImporte = Me.GridView1.Rows(e.RowIndex).Cells(5).Value
            varTempUsuarioSolicitante = Me.GridView1.Rows(e.RowIndex).Cells(7).Value
            varTempCBU = Me.GridView1.Rows(e.RowIndex).Cells(10).Value
            varTempAlias = Me.GridView1.Rows(e.RowIndex).Cells(11).Value
            varTempCuilPago = Me.GridView1.Rows(e.RowIndex).Cells(15).Value
            varTempTipoCuenta = Me.GridView1.Rows(e.RowIndex).Cells(16).Value
            varTempNombreBeneficiario = Me.GridView1.Rows(e.RowIndex).Cells(18).Value
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
            botonAprobar.Visible = False
            botonDesaprobar.Visible = False
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
            botonAprobar.Visible = False
            botonDesaprobar.Visible = False
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
            botonAprobar.Visible = False
            botonDesaprobar.Visible = False
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
            botonAprobar.Visible = False
            botonDesaprobar.Visible = False
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

        panelAuditor.Visible = True
        lblporcentaje.Visible = True
        lblporc.Visible = True
        lblobsam.Visible = True

        txtObservacionesAM.Visible = True
        det = "*El Auditor Medico Aprobó el reintegro: "
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
        lblobsam.Visible = True
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
                fechaHoy()
                MessageBox.Show("UPDATE en BD OK", "Actualizacion de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'ENV CORREO (MAIL EMISOR (GMAIL) - PASS (GMAIL) - MENSAJE   -   ASUNTO     - MAIL RECEPTOR)
                Insert_To_Modificacion()
                enviarCorreo("noreply.urgarareintegros@gmail.com", "Clave2017", "<u> Sr. GERENTE DE NUESTROS BOLSILLOS, </u> " & "<br /> <br />" & "El Auditor Medico aprueba el Reintegro nro: " & _
                             "<strong>" & varCodigoreintegro.ToString & "</strong> <br /> <br />" & "Fecha " & _
                             "aprobac. Auditor Medico: '" & VariableGlobalFechaHOY.ToString & "'" & "<br />" & "USUARIO " & _
                             "SOLICITANTE: '" & varTempUsuarioSolicitante.ToString & "'" & "<br />" & "BENEFICIARIO: " & _
                             "'" & varTempNombreBeneficiario.ToString & "'<br />" & "CUIL: '" & VariableGlobalCuilBeneficiario.ToString & "'<br />" & "SOLICITA: " & _
                             "'" & varTempDetalle.ToString & "'<br />" & "<strong> IMPORTE: $" & varTempImporte.ToString & "</strong> <br />" & "<br />" & "Datos para el Pago:  <br />" & _
                             "CBU: " & varTempCBU & " <br /> CUIL TITULAR CUENTA: " & varTempCuilPago & " <br /> ALIAS: " & varTempAlias & "<br /> " & _
                             "TIPO: " & varTempTipoCuenta & " <br /> <br /> A sus efectos, muchas gracias!", "Nuevo Rentegro Aprobado A.M. " & _
                             "Cod: [" & varCodigoreintegro.ToString & "] - Usuario: " & varTempUsuarioSolicitante.ToString & ", SROSS (NO RESPONDER " & _
                             "ESTE MENSAJE)", "matiasmasciotta@urgara.org.ar")

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
        OK.Visible = False
        CANCELA.Visible = False
        botonAprobar.Visible = False
        botonDesaprobar.Visible = False
        panelAuditor.Visible = False
        lblporcentaje.Visible = False
        lblporc.Visible = False
        lblobsam.Visible = False

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
            botonAprobar.Visible = False
            botonDesaprobar.Visible = False

            panelAuditor.Visible = False
            lblporcentaje.Visible = False
            lblporc.Visible = False
            lblobsam.Visible = False

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

    Private Sub botonExcel_MouseLeave(sender As Object, e As EventArgs) Handles botonExcel.MouseLeave
        botonExcel.Image = WindowsApplication1.My.Resources.Resources.logoexcelsistemaa
    End Sub

    Private Sub botonExcel_MouseMove(sender As Object, e As MouseEventArgs) Handles botonExcel.MouseMove
        botonExcel.Image = WindowsApplication1.My.Resources.Resources.logo2excel
    End Sub

    Private Sub botonExcel2_MouseHover(sender As Object, e As EventArgs) Handles botonExcel2.MouseHover
        etiquetear()
    End Sub

    Private Sub botonExcel2_MouseLeave(sender As Object, e As EventArgs) Handles botonExcel2.MouseLeave
        botonExcel2.Image = WindowsApplication1.My.Resources.Resources.logoexcelsistemaa
    End Sub
    Private Sub botonExcel2_MouseMove(sender As Object, e As MouseEventArgs) Handles botonExcel2.MouseMove
        botonExcel2.Image = WindowsApplication1.My.Resources.Resources.logo2excel
    End Sub

    Private Sub botonExcel3_MouseHover(sender As Object, e As EventArgs) Handles botonExcel3.MouseHover
        etiquetear()
    End Sub

    Private Sub botonExcel3_MouseLeave(sender As Object, e As EventArgs) Handles botonExcel3.MouseLeave
        botonExcel3.Image = WindowsApplication1.My.Resources.Resources.logoexcelsistemaa
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
        ToolTip1.SetToolTip(botonLimpiarFiltros, "Limpiar Filtros!")
        ToolTip1.SetToolTip(botonLimpiarFiltroFechas, "Limpiar Filtros!")
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

    Private Sub botonLimpiarFiltros_Click(sender As Object, e As EventArgs) Handles botonLimpiarFiltros.Click
        opComisionAprobados.Checked = False
        opComisionPendientes.Checked = False
        opComisionRechazados.Checked = False
        opPAGADO.Checked = False
        opPagoPendiente.Checked = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles botonLimpiarFiltroFechas.Click
        limpiafechas()
    End Sub

    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles botonLimpiarFiltroFechas.MouseHover
        etiquetear()
    End Sub

  
    Private Sub botonLimpiarFiltros_MouseHover(sender As Object, e As System.EventArgs) Handles botonLimpiarFiltros.MouseHover
        etiquetear()
    End Sub

    Private Sub opComisionPendientes_CheckedChanged(sender As Object, e As EventArgs) Handles opComisionPendientes.CheckedChanged
        todosLosIF()
        BuscarDato()
    End Sub

    Private Sub opComisionAprobados_CheckedChanged(sender As Object, e As EventArgs) Handles opComisionAprobados.CheckedChanged
        todosLosIF()
        BuscarDato()
    End Sub

    Private Sub opComisionRechazados_CheckedChanged(sender As Object, e As EventArgs) Handles opComisionRechazados.CheckedChanged
        todosLosIF()
        BuscarDato()
    End Sub

    Private Sub opPagoPendiente_CheckedChanged(sender As Object, e As EventArgs) Handles opPagoPendiente.CheckedChanged
        todosLosIF()
        BuscarDato()
    End Sub

    Private Sub opPAGADO_CheckedChanged(sender As Object, e As EventArgs) Handles opPAGADO.CheckedChanged
        todosLosIF()
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

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

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

    Private Sub GridViewSeccionales_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridViewSeccionales.CellContentClick
        Try
            txtuserseccional.Text = Me.GridViewSeccionales.Rows(e.RowIndex).Cells(0).Value
        Catch
        End Try
    End Sub

    Private Sub GridViewSeccionales_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridViewSeccionales.CellClick
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
End Class