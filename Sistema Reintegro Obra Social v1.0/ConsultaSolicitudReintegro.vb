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
    Dim rollbackDetalle As String
    Dim rollbackImporte As String
    Dim rollbackCarga As String
    Dim rollbackFechaSolicitud As String
    Dim rollbackCBU As String
    Dim rollbackAlias As String
    Dim rollbackCuilPago As String
    Dim rollbackTipoCuenta As String
    Dim varCodigoreintegro As String
    Dim varSQLCAMPOS As String = "reintegros.codigo_usuario,codigo_reintegro,codigo_beneficiario,fecha_solicitud,detalle,importe,observaciones_carga, " & _
                              "usuarios_reintegros.ApellidoNombre,usuarios_reintegros.tipo_usuario,usuarios_reintegros.codigo_seccional,reintegros.CBU," & _
                              "reintegros.Alias,reintegros.tipo_reintegro,reintegros.id_Subsidio,reintegros.Pagado,reintegros.Cuil_Pago,reintegros.tipo_cuenta,cuil_beneficiario "
    Dim tempDETALLE As String
    Dim tempIMPORTE As String
    Dim tempFECHASOL As String
    Dim tempCBU As String
    Dim tempALIAS As String
    Dim tempOBSCARGA As String
    Dim tempCUILPAGO As String
    Dim tempTIPOCUENTA As String
    Dim MODIFICA As Boolean = False
    Dim varCodigoreintegroAprobado As String
    Dim varCodigoreintegroRechazado As String

    Private Sub ConsultaSolicitudReintegro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        VariableGlobalModificacion = ""
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
    Private Sub llenarGridCompleto() '>>>>>>>>>>>
        Try
            sql = "SELECT " & varSQLCAMPOS & "FROM REINTEGROS,USUARIOS_REINTEGROS WHERE (REINTEGROS.CODIGO_USUARIO = USUARIOS_REINTEGROS.CODIGO_USUARIO) " & _
                    "AND (USUARIOS_REINTEGROS.Codigo_Seccional = '" & VariableGlobalSeccional.ToString & "') AND (Auditor_Medico = 0)"
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

        'grid aprobados 
        Try
            sql = "SELECT " & varSQLCAMPOS & "FROM REINTEGROS,USUARIOS_REINTEGROS WHERE (REINTEGROS.CODIGO_USUARIO = USUARIOS_REINTEGROS.CODIGO_USUARIO) " & _
                    "AND (USUARIOS_REINTEGROS.Codigo_Seccional = '" & VariableGlobalSeccional.ToString & "') AND (Auditor_Medico = 1) order by fecha_solicitud desc"
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
                    "AND (USUARIOS_REINTEGROS.Codigo_Seccional = '" & VariableGlobalSeccional.ToString & "') AND (Auditor_Medico = 2) order by fecha_solicitud desc"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView3.DataSource = dt
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
    Private Sub formatearEncabezadoGrid()
        Me.GridView1.Columns(0).Name = "User"
        Me.GridView1.Columns(1).Name = "Reintegro(id)"
        Me.GridView1.Columns(2).Name = "Beneficiario(id)"
        Me.GridView1.Columns(3).Name = "Fecha Solic."
        Me.GridView1.Columns(4).Name = "Detalle"
        Me.GridView1.Columns(5).Name = "Imp.($)"
        Me.GridView1.Columns(6).Name = "Obs. carga"
        Me.GridView1.Columns(7).Name = "Nombre y Apellido Beneficiario"
        Me.GridView1.Columns(8).Name = "tipo user (X)"
        Me.GridView1.Columns(9).Name = "Secc User(X)"
        Me.GridView1.Columns(10).Name = "CBU p/pago Beneficiario"
        Me.GridView1.Columns(11).Name = "Alias Benef."
        Me.GridView1.Columns(12).Name = "Reint/Subs"
        Me.GridView1.Columns(13).Name = "idsubs(x)"
        Me.GridView1.Columns(14).Name = "Pagado si o no"
        Me.GridView1.Columns(15).Name = "Cuil para Pago Benef."
        Me.GridView1.Columns(16).Name = "Tipo Cuenta p/Pago Benef."
        Me.GridView1.Columns(17).Name = "Cuil Beneficiario."

    End Sub

    Private Sub BuscarDato()
        Try
            If txtFechaDesde.Text = "" And txtFechaDesde.Text = "" Then
                sql = "SELECT " & varSQLCAMPOS & "FROM REINTEGROS,USUARIOS_REINTEGROS WHERE (REINTEGROS.CODIGO_USUARIO = USUARIOS_REINTEGROS.CODIGO_USUARIO) " & _
                    "AND USUARIOS_REINTEGROS.Codigo_Seccional = '" & VariableGlobalSeccional & "' AND Detalle LIKE '%" & txtBeneficiario.Text.ToString & "%' and Auditor_medico=0)"
            Else

                sql = "SELECT " & varSQLCAMPOS & "FROM REINTEGROS,USUARIOS_REINTEGROS WHERE (REINTEGROS.CODIGO_USUARIO = USUARIOS_REINTEGROS.CODIGO_USUARIO) " & _
                    "AND USUARIOS_REINTEGROS.Codigo_Seccional = '" & VariableGlobalSeccional & "' AND Detalle LIKE '%" & txtBeneficiario.Text.ToString & "%' AND " & _
                    "(Fecha_Solicitud BETWEEN '" & txtFechaDesde.Text.ToString & "' AND '" & txtFechaHasta.Text.ToString & "') and (Auditor_Medico = 0)"
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

    '********************************************************                   *******************************************************************************
    ' 111 click en celda llena listbox con imagenes y grid  >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>    111111111111111111111111111111111111111111111111111111111111111111111111
    Private Sub GridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridView1.CellClick
        clbimagen.Items.Clear()
        lblPicture.Image = Nothing
        Dim SQL2 As String
        Dim MiConexion2 As New MySqlConnection(CADENABASE2)
        Dim Rs2 As MySqlDataReader
        Dim Com2 As New MySqlCommand
        Com2.Connection = MiConexion2
        MiConexion2.Open()
        varCodigoreintegro = (Me.GridView1.Rows(e.RowIndex).Cells(1).Value)
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
            lblfe1.Text = Me.GridView1.Rows(e.RowIndex).Cells(3).Value
            Dim fechacreacion As Date
            fechacreacion = lblfe1.Text
            lblfe2.Text = Format(fechacreacion, "yyyy/MM/dd")
            'af
            txtDetalle.Text = Me.GridView1.Rows(e.RowIndex).Cells(4).Value
            txtDetalleTEMPO.Text = txtDetalle.Text
            rollbackDetalle = txtDetalle.Text

            txtImporte.Text = Me.GridView1.Rows(e.RowIndex).Cells(5).Value
            txtImporteTEMPO.Text = txtImporte.Text
            rollbackImporte = txtImporte.Text

            txtObservacionesCarga.Text = Me.GridView1.Rows(e.RowIndex).Cells(6).Value
            txtObservacionesTEMPO.Text = txtObservacionesCarga.Text

            txtCBU.Text = Me.GridView1.Rows(e.RowIndex).Cells(10).Value
            txtCBUTEMPO.Text = txtCBU.Text

            txtAlias.Text = Me.GridView1.Rows(e.RowIndex).Cells(11).Value
            txtAliasTEMPO.Text = txtAlias.Text
            'si es 0 es reintegro
            If (Me.GridView1.Rows(e.RowIndex).Cells(12).Value) = 0 Then
                lblTipoReintegro.Text = "ES REINTEGRO"
            End If
            'si es 1 es subsidio
            If (Me.GridView1.Rows(e.RowIndex).Cells(12).Value) = 1 Then
                If (Me.GridView1.Rows(e.RowIndex).Cells(13).Value) = 1 Then lblTipoReintegro.Text = "ES SUBSIDIO POR NACIMIENTO"
                If (Me.GridView1.Rows(e.RowIndex).Cells(13).Value) = 2 Then lblTipoReintegro.Text = "ES SUBSIDIO POR FALLECIMIENTO"
            End If
            rollbackCarga = txtObservacionesCarga.Text
            txtFechaSolicitud.Text = lblfe2.Text
            txtFechSolicitudTEMPO.Text = txtFechaSolicitud.Text
            rollbackFechaSolicitud = txtFechaSolicitud.Text

            txtCuilPago.Text = Me.GridView1.Rows(e.RowIndex).Cells(15).Value
            txtCuilPagoTEMPO.Text = txtCuilPago.Text

            txtTipoCuenta.Text = Me.GridView1.Rows(e.RowIndex).Cells(16).Value
            txtTipoCuentaTEMPO.Text = txtTipoCuenta.Text

            txtCuil.Text = Me.GridView1.Rows(e.RowIndex).Cells(17).Value
            VariableGlobalCuilBeneficiario = txtCuil.Text

            botonModificaSolicitud.Visible = True
            botonModificaSolicitud.Enabled = True
            botonEliminarSolicitud.Visible = True
        Catch
        End Try
    End Sub

    ' 22222 click en celda llena listbox con imagenes y grid    <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<          22222222222222222222222222222222222
    Private Sub GridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridView1.CellContentClick
        'lleno listbox con imagenes de la base *************************************************
        clbimagen.Items.Clear()
        lblPicture.Image = Nothing
        Dim SQL2 As String
        Dim MiConexion2 As New MySqlConnection(CADENABASE2)
        Dim Rs2 As MySqlDataReader
        Dim Com2 As New MySqlCommand
        Com2.Connection = MiConexion2
        MiConexion2.Open()
        varCodigoreintegro = (Me.GridView1.Rows(e.RowIndex).Cells(1).Value)
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
        '***************************** fin llenado listbox ***************************************

        'llena textbox con datos de operacion
        Try
            'arreglo fecha
            VariableGlobalBeneficiario = Me.GridView1.Rows(e.RowIndex).Cells(2).Value
            lblfe1.Text = Me.GridView1.Rows(e.RowIndex).Cells(3).Value
            Dim fechacreacion As Date
            fechacreacion = lblfe1.Text
            lblfe2.Text = Format(fechacreacion, "yyyy/MM/dd")
            'af
            txtDetalle.Text = Me.GridView1.Rows(e.RowIndex).Cells(4).Value
            txtDetalleTEMPO.Text = txtDetalle.Text
            rollbackDetalle = txtDetalle.Text

            txtImporte.Text = Me.GridView1.Rows(e.RowIndex).Cells(5).Value
            txtImporteTEMPO.Text = txtImporte.Text
            rollbackImporte = txtImporte.Text

            txtObservacionesCarga.Text = Me.GridView1.Rows(e.RowIndex).Cells(6).Value
            txtObservacionesTEMPO.Text = txtObservacionesCarga.Text

            txtCBU.Text = Me.GridView1.Rows(e.RowIndex).Cells(10).Value
            txtCBUTEMPO.Text = txtCBU.Text

            txtAlias.Text = Me.GridView1.Rows(e.RowIndex).Cells(11).Value
            txtAliasTEMPO.Text = txtAlias.Text
            'si es 0 es reintegro
            If (Me.GridView1.Rows(e.RowIndex).Cells(12).Value) = 0 Then
                lblTipoReintegro.Text = "ES REINTEGRO"
            End If
            'si es 1 es subsidio
            If (Me.GridView1.Rows(e.RowIndex).Cells(12).Value) = 1 Then
                If (Me.GridView1.Rows(e.RowIndex).Cells(13).Value) = 1 Then lblTipoReintegro.Text = "ES SUBSIDIO POR NACIMIENTO"
                If (Me.GridView1.Rows(e.RowIndex).Cells(13).Value) = 2 Then lblTipoReintegro.Text = "ES SUBSIDIO POR FALLECIMIENTO"
            End If
            rollbackCarga = txtObservacionesCarga.Text
            txtFechaSolicitud.Text = lblfe2.Text
            txtFechSolicitudTEMPO.Text = txtFechaSolicitud.Text
            rollbackFechaSolicitud = txtFechaSolicitud.Text

            txtCuilPago.Text = Me.GridView1.Rows(e.RowIndex).Cells(15).Value
            txtCuilPagoTEMPO.Text = txtCuilPago.Text

            txtTipoCuenta.Text = Me.GridView1.Rows(e.RowIndex).Cells(16).Value
            txtTipoCuentaTEMPO.Text = txtTipoCuenta.Text

            txtCuil.Text = Me.GridView1.Rows(e.RowIndex).Cells(17).Value
            VariableGlobalCuilBeneficiario = txtCuil.Text

            botonModificaSolicitud.Visible = True
            botonModificaSolicitud.Enabled = True
            botonEliminarSolicitud.Visible = True
        Catch
        End Try
    End Sub
    'aasdas

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
        Catch
        End Try
    End Sub
    '****************************************




    'asdsad












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
        GridView1.Enabled = False
        EnabledTextOn()
        PrendeBotones()
    End Sub

    Private Sub CANCELA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELA.Click
        EnabledTextOff()
        ApagaBotones()
        rollbackearDatos()
        botonModificaSolicitud.Enabled = True
        GridView1.Enabled = True
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
        GridView1.Enabled = True
    End Sub
    Private Sub rollbackearDatos()
        txtDetalle.Text = rollbackDetalle.ToString
        txtImporte.Text = rollbackImporte
        txtObservacionesCarga.Text = rollbackCarga
        txtFechaSolicitud.Text = rollbackFechaSolicitud
        txtCBU.Text = rollbackCBU
        txtAlias.Text = rollbackAlias
        txtCuilPago.Text = rollbackCuilPago
        txtTipoCuenta.Text = rollbackTipoCuenta
    End Sub

    Private Sub DateTimePicker3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker3.ValueChanged
        txtFechaSolicitud.Text = DateTimePicker3.Value.Year & "-" & DateTimePicker3.Value.Month & "-" & DateTimePicker3.Value.Day
    End Sub

    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<

    Private Sub update_To() 'Pisa la base productiva "REINTEGROS"
        Using con_insert As New MySqlConnection(CADENABASE2)
            Dim cmdinsert As New MySqlCommand
            Dim varimp As Double = Convert.ToDouble(txtImporte.Text)
            With cmdinsert
                .Connection = con_insert
                .CommandType = CommandType.Text
                .CommandText = "UPDATE `reintegros` SET detalle=?detalle,importe=?importe,Observaciones_Carga=?obscarga,fecha_solicitud=?fecsol,CBU =?cbu,Alias=?alias,Cuil_Pago=?cuilpago,Tipo_Cuenta=?tipcue WHERE codigo_reintegro = ?codre"
                .Parameters.AddWithValue("?codre", varCodigoreintegro)
                .Parameters.AddWithValue("?detalle", txtDetalle.Text.ToString)
                .Parameters.AddWithValue("?importe", varimp)
                .Parameters.AddWithValue("?obscarga", txtObservacionesCarga.Text.ToString)
                .Parameters.AddWithValue("?fecsol", txtFechaSolicitud.Text.ToString)
                .Parameters.AddWithValue("?cbu", txtCBU.Text.ToString)
                .Parameters.AddWithValue("?alias", txtAlias.Text.ToString)
                .Parameters.AddWithValue("?cuilpago", txtCuilPago.Text.ToString)
                .Parameters.AddWithValue("?tipcue", txtTipoCuenta.Text.ToString)
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
            Dim varimp As Double = Convert.ToDouble(txtImporte.Text)
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

    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    Private Sub VERIFICA_MODIFICACIONES()
        VariableGlobalModificacion = ""
        Dim det As String = ""
        Dim imp As String = ""
        Dim fecsol As String = ""
        Dim cbuu As String = ""
        Dim ali As String = ""
        Dim obsc As String = ""
        Dim cui As String = ""
        Dim tipcue As String = ""


        If txtDetalle.Text <> txtDetalleTEMPO.Text Then
            det = " // modificó el detalle ANTES - [ " & txtDetalleTEMPO.Text & " ] DESPUÉS --> [ " & txtDetalle.Text & " ]"
        Else
            det = ""
        End If

        If txtImporte.Text <> txtImporteTEMPO.Text Then
            imp = " // modificó el importe - ANTES [ " & txtImporteTEMPO.Text & " ] DESPUÉS --> [ " & txtImporte.Text & " ]"
        Else
            imp = ""
        End If

        If txtFechaSolicitud.Text <> txtFechSolicitudTEMPO.Text Then
            fecsol = " // modificó la fecha de solicitud - ANTES [ " & txtFechSolicitudTEMPO.Text & " ] DESPUÉS --> [ " & txtFechaSolicitud.Text & " ]"
        Else
            fecsol = ""
        End If

        If txtCBU.Text <> txtCBUTEMPO.Text Then
            cbuu = " // modificó el CBU - ANTES [ " & txtCBUTEMPO.Text & " ] DESPUÉS --> [ " & txtCBU.Text & " ]"
        Else
            cbuu = ""
        End If

        If txtAlias.Text <> txtAliasTEMPO.Text Then
            ali = " //modificó el alias - ANTES [ " & txtAliasTEMPO.Text & " ] DESPUÉS --> [ " & txtAlias.Text & " ]"
        Else
            ali = ""
        End If

        If txtObservacionesCarga.Text <> txtObservacionesTEMPO.Text Then
            obsc = " // modificó las observaciones de carga - ANTES [ " & txtObservacionesTEMPO.Text & " ] DESPUÉS --> [ " & txtObservacionesCarga.Text & " ]"
        Else
            obsc = ""
        End If

        If txtCuilPago.Text <> txtCuilPagoTEMPO.Text Then
            cui = " // modificó el cuil de pago - ANTES [ " & txtCuilPagoTEMPO.Text & " ] DESPUÉS --> [ " & txtCuilPago.Text & " ]"
        Else
            cui = ""
        End If

        If txtTipoCuenta.Text <> txtTipoCuentaTEMPO.Text Then
            tipcue = " // modificó el tipo de cuenta - ANTES [ " & txtTipoCuentaTEMPO.Text & " ] DESPUÉS --> [ " & txtTipoCuenta.Text & " ]"
        Else
            tipcue = ""
        End If



        VariableGlobalModificacion = det & imp & fecsol & cbuu & ali & obsc & cui & tipcue

    End Sub


    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
    '<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<



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



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GridAExcel(GridView1)
    End Sub

    Private Sub GridView1_MouseMove(sender As Object, e As MouseEventArgs) Handles GridView1.MouseMove
        formatearEncabezadoGrid()
    End Sub

    'WW DOBLE CLICK EN GRID PARA HISTORIAL  WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW
    Private Sub GridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView1.CellContentDoubleClick
        Historial.lblTitulo.Text = "'Solicitudes de Reintegro' - Historial de Modificaciones del reintegro N° - " & varCodigoreintegro
        VarHistorialReintegro = varCodigoreintegro
        Historial.Show()
    End Sub


    Private Sub GridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView1.CellDoubleClick
        Historial.lblTitulo.Text = "'Solicitudes de Reintegro' - Historial de Modificaciones del reintegro N° - " & varCodigoreintegro
        VarHistorialReintegro = varCodigoreintegro
        Historial.Show()
    End Sub
    'WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW

    Private Sub GridView2_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView2.CellContentDoubleClick
        Historial.lblTitulo.Text = "'Solicitudes de Reintegro' - Historial de Modificaciones del reintegro N° - " & varCodigoreintegroAprobado
        VarHistorialReintegro = varCodigoreintegroAprobado
        Historial.Show()
    End Sub
    Private Sub GridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView2.CellDoubleClick
        Historial.lblTitulo.Text = "'Solicitudes de Reintegro' - Historial de Modificaciones del reintegro N° - " & varCodigoreintegroAprobado
        VarHistorialReintegro = varCodigoreintegroAprobado
        Historial.Show()
    End Sub

    Private Sub GridView3_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView3.CellContentDoubleClick
        Historial.lblTitulo.Text = "'Solicitudes de Reintegro' - Historial de Modificaciones del reintegro N° - " & varCodigoreintegroRechazado
        VarHistorialReintegro = varCodigoreintegroRechazado
        Historial.Show()
    End Sub

    Private Sub GridView3_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView3.CellDoubleClick
        Historial.lblTitulo.Text = "'Solicitudes de Reintegro' - Historial de Modificaciones del reintegro N° - " & varCodigoreintegroRechazado
        VarHistorialReintegro = varCodigoreintegroRechazado
        Historial.Show()
    End Sub
End Class






