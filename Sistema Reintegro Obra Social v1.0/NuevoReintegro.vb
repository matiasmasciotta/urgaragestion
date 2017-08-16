Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Drawing.Imaging
Imports System.Windows.Forms.Keys
Public Class NuevoReintegro
    Dim Conex As New MySqlConnection(CADENABASE2)
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Dim cont As Integer = 0
    Dim n As Integer = 2
    Dim ima As Byte

    Private Sub NuevoReintegro_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtBusqueda.Focus()
    End Sub

    'LOAD FORMULARIO NUEVO REINTEGRO
    Private Sub NuevoReintegro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opReintegro.Checked = True
        lblNumeroReintegro.Text = VariableGlobalUsuario
        opBuscarDNI.Checked = True
        txtFechaSolicitud.Text = DateTime.Now.Year & "-" & DateTime.Now.Month & "-" & DateTime.Now.Day
        apagaDatosOperacion()
        llenaGridSubsidios()
        txtBusqueda.Focus()
    End Sub

    'EVENTO TEXT BUSQUEDA CHANGUED
    Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged
        buscarlosdatos()
    End Sub

    '[] DEFINICION DE METODO BUSCARLOSDATOS()
    Private Sub buscarlosdatos()
        Try
            If (opBuscarDNI.Checked = True) And (opBuscarNombre.Checked = False) Then
                sql = "SELECT Codigo_Beneficiario,Cuil,ApellidoNombre,Sexo,Calle,Puerta,Piso,Codigo_Postal,Celular,Telefono,Mail,Localidad,Provincia,Urgara,TipoBeneficiarioTitular from beneficiarios WHERE Cuil LIKE '%" & txtBusqueda.Text.ToString & "%'"
            End If
            If (opBuscarNombre.Checked = True) And (opBuscarDNI.Checked = False) Then
                sql = "SELECT Codigo_Beneficiario,Cuil,ApellidoNombre,Sexo,Calle,Puerta,Piso,Codigo_Postal,Celular,Telefono,Mail,Localidad,Provincia,Urgara,TipoBeneficiarioTitular from beneficiarios WHERE ApellidoNombre LIKE '%" & txtBusqueda.Text.ToString & "%'"
            End If
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    '@BUSCARLOSDATOS()

    '[] DEFINICION DE METODO MOSTRARLOSDATOS()
    Private Sub mostrarlosdatos()
        Try
            sql = "SELECT Codigo_Beneficiario,Cuil,ApellidoNombre,Sexo,Calle,Puerta,Piso,Codigo_Postal,Celular,Telefono,Mail,Localidad,Provincia,Urgara,TipoBeneficiarioTitular from beneficiarios"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    'LLENA LOS TEXTBOX CON LOS DATOS DE LA SELECCION DEL GRIDVIEW **************************
    Private Sub GridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridView.CellClick
        Try
            txtBeneficiario.Text = Me.GridView.Rows(e.RowIndex).Cells(0).Value
            txtCUIL.Text = Me.GridView.Rows(e.RowIndex).Cells(1).Value
            txtApellidoNombre.Text = Me.GridView.Rows(e.RowIndex).Cells(2).Value
            comboSexo.Text = Me.GridView.Rows(e.RowIndex).Cells(3).Value
            If Me.GridView.Rows(e.RowIndex).Cells(14).Value = 1 Then
                comboTipoBeneficiario.Text = "TITULAR"
            Else
                comboTipoBeneficiario.Text = "ADHERENTE"
            End If
            txtCelular.Text = Me.GridView.Rows(e.RowIndex).Cells(8).Value
            txtTelefono.Text = Me.GridView.Rows(e.RowIndex).Cells(9).Value
            txtMail.Text = Me.GridView.Rows(e.RowIndex).Cells(10).Value
        Catch
        End Try
        prendeDatosOperacion()
        GridViewSubsidios.Visible = False
        'GridView.Enabled = True
        txtDetalle.Focus()

    End Sub
    'LLENA LOS TEXTBOX CON LOS DATOS DE LA SELECCION DEL GRIDVIEW **************************
    Private Sub GridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridView.CellContentClick
        Try
            txtBeneficiario.Text = Me.GridView.Rows(e.RowIndex).Cells(0).Value
            txtCUIL.Text = Me.GridView.Rows(e.RowIndex).Cells(1).Value
            txtApellidoNombre.Text = Me.GridView.Rows(e.RowIndex).Cells(2).Value
            comboSexo.Text = Me.GridView.Rows(e.RowIndex).Cells(3).Value
            If Me.GridView.Rows(e.RowIndex).Cells(14).Value = 1 Then
                comboTipoBeneficiario.Text = "TITULAR"
            Else
                comboTipoBeneficiario.Text = "ADHERENTE"
            End If
            txtCelular.Text = Me.GridView.Rows(e.RowIndex).Cells(8).Value
            txtTelefono.Text = Me.GridView.Rows(e.RowIndex).Cells(9).Value
            txtMail.Text = Me.GridView.Rows(e.RowIndex).Cells(10).Value
        Catch
        End Try
        prendeDatosOperacion()
        GridViewSubsidios.Visible = False
        'GridView.Enabled = False
        txtDetalle.Focus()
    End Sub


    '**********************************************************************************************************************************************************************************************************
    '************************************************* nueva INSERT falta commit/rollback *********************************************************************************************************************
    '**********************************************************************************************************************************************************************************************************
    Private Sub Insert_into()
        'Dim vardire As String = "C:\Users\Matias Masciotta\Pictures\urgara.jpeg"
        Dim varobs As String = "SIN OBSERVACIONES"
        Dim varfec As String = "0000-00-00"
        Using con_insert As New MySqlConnection(CADENABASE2)
            Dim cmdinsert As New MySqlCommand
            Dim varimp As Double = Convert.ToDouble(txtImporte.Text)

            With cmdinsert
                .Connection = con_insert
                .CommandType = CommandType.Text
                'OPTION REINTEGRO>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>
                Dim vartiporeintegro As Integer
                If opReintegro.Checked = True Then
                    vartiporeintegro = 0
                    Select Case (clbimagen.Items.Count)
                        '?codus,?codben,?fecsol,?det,?imp,?obsc,?img1,?img2,?img3,?img4,?img5,?audmed,?porcaudmed,?obsam,?est,?aut,?acargo,?fecreint,?porcreint,?valfinal
                        Case 0
                            .CommandText = "INSERT INTO `reintegros`(`Codigo_Usuario`,`Codigo_Beneficiario`,`Fecha_Solicitud`,`Detalle`,`Importe`,`CBU`,`Alias`,`tipo_reintegro`,`id_Subsidio`,`Observaciones_Carga`,`Auditor_Medico`,`Porcentaje_Reintegro_AM`,`Observaciones_AM`,`Estado`,`Observaciones_Comision`,`Autorizante`,`A_Cargo`,`Fecha_Reintegro`,`Porcentaje_Reintegro_final`,`Valor_Reintegrado`,`Cuil_Pago`,`Tipo_Cuenta`)" & " VALUES " & "(?codus,?codben,?fecsol,?det,?imp,?cbu,?alias,?tiporeintegro,?idsub,?obsc,?audmed,?porcaudmed,?obsam,?est,?obscomision,?aut,?acargo,?fecreint,?porcreint,?valfinal,?cuilpago,?tipocuenta)"
                            .Parameters.AddWithValue("?codus", lblNumeroReintegro.Text.ToString)
                            .Parameters.AddWithValue("?codben", txtBeneficiario.Text.ToString)
                            .Parameters.AddWithValue("?fecsol", txtFechaSolicitud.Text.ToString)
                            .Parameters.AddWithValue("?det", txtDetalle.Text.ToString)
                            .Parameters.AddWithValue("?imp", varimp)
                            .Parameters.AddWithValue("?cbu", txtCBU.Text.ToString)
                            .Parameters.AddWithValue("?alias", txtAlias.Text.ToString)
                            .Parameters.AddWithValue("?tiporeintegro", Int(vartiporeintegro))
                            .Parameters.AddWithValue("?idsub", 0)
                            .Parameters.AddWithValue("?obsc", txtObservacionesCarga.Text)
                            .Parameters.AddWithValue("?audmed", Int(0))
                            .Parameters.AddWithValue("?porcaudmed", Int(0))
                            .Parameters.AddWithValue("?obsam", varobs)
                            .Parameters.AddWithValue("?est", Int(0))
                            .Parameters.AddWithValue("?obscomision", varobs)
                            .Parameters.AddWithValue("?aut", varobs)
                            .Parameters.AddWithValue("?acargo", Int(-1))
                            .Parameters.AddWithValue("?fecreint", varfec)
                            .Parameters.AddWithValue("?porcreint", Int(0))
                            .Parameters.AddWithValue("?valfinal", Int(0))

                        Case 1
                            .CommandText = "INSERT INTO `reintegros`(`Codigo_Usuario`,`Codigo_Beneficiario`,`Fecha_Solicitud`,`Detalle`,`Importe`,`CBU`,`Alias`,`tipo_reintegro`,`id_Subsidio`,`Observaciones_Carga`,`Imagen1`,`Auditor_Medico`,`Porcentaje_Reintegro_AM`,`Observaciones_AM`,`Estado`,`Observaciones_Comision`,`Autorizante`,`A_Cargo`,`Fecha_Reintegro`,`Porcentaje_Reintegro_final`,`Valor_Reintegrado`,`Cuil_Pago`,`Tipo_Cuenta`)" & " VALUES " & "(?codus,?codben,?fecsol,?det,?imp,?cbu,?alias,?tiporeintegro,?idsub,?obsc,?img1,?audmed,?porcaudmed,?obsam,?est,?obscomision,?aut,?acargo,?fecreint,?porcreint,?valfinal,?cuilpago,?tipocuenta)"
                            .Parameters.AddWithValue("?img1", DeImagen_a_Bytes(clbimagen.Items.Item(0)))
                            .Parameters.AddWithValue("?codus", lblNumeroReintegro.Text.ToString)
                            .Parameters.AddWithValue("?codben", txtBeneficiario.Text.ToString)
                            .Parameters.AddWithValue("?fecsol", txtFechaSolicitud.Text.ToString)
                            .Parameters.AddWithValue("?det", txtDetalle.Text.ToString)
                            .Parameters.AddWithValue("?imp", varimp)
                            .Parameters.AddWithValue("?cbu", txtCBU.Text.ToString)
                            .Parameters.AddWithValue("?alias", txtAlias.Text.ToString)
                            .Parameters.AddWithValue("?tiporeintegro", Int(vartiporeintegro))
                            .Parameters.AddWithValue("?idsub", 0)
                            .Parameters.AddWithValue("?obsc", txtObservacionesCarga.Text)
                            .Parameters.AddWithValue("?audmed", Int(0))
                            .Parameters.AddWithValue("?porcaudmed", Int(0))
                            .Parameters.AddWithValue("?obsam", varobs)
                            .Parameters.AddWithValue("?est", Int(0))
                            .Parameters.AddWithValue("?obscomision", varobs)
                            .Parameters.AddWithValue("?aut", varobs)
                            .Parameters.AddWithValue("?acargo", Int(-1))
                            .Parameters.AddWithValue("?fecreint", varfec)
                            .Parameters.AddWithValue("?porcreint", Int(0))
                            .Parameters.AddWithValue("?valfinal", Int(0))
                            .Parameters.AddWithValue("?cuilpago", txtCuilPago.Text.ToString)
                            .Parameters.AddWithValue("?tipocuenta", txtTipoCuenta.Text.ToString)
                        Case 2
                            .CommandText = "INSERT INTO `reintegros`(`Codigo_Usuario`,`Codigo_Beneficiario`,`Fecha_Solicitud`,`Detalle`,`Importe`,`CBU`,`Alias`,`tipo_reintegro`,`id_Subsidio`,`Observaciones_Carga`,`imagen1`,`Imagen2`,`Auditor_Medico`,`Porcentaje_Reintegro_AM`,`Observaciones_AM`,`Estado`,`Observaciones_Comision`,`Autorizante`,`A_Cargo`,`Fecha_Reintegro`,`Porcentaje_Reintegro_final`,`Valor_Reintegrado`,`Cuil_Pago`,`Tipo_Cuenta`)" & " VALUES " & "(?codus,?codben,?fecsol,?det,?imp,?cbu,?alias,?tiporeintegro,?idsub,?obsc,?img1,?img2,?audmed,?porcaudmed,?obsam,?est,?obscomision,?aut,?acargo,?fecreint,?porcreint,?valfinal,?cuilpago,?tipocuenta)"
                            .Parameters.AddWithValue("?img1", DeImagen_a_Bytes(clbimagen.Items.Item(0)))
                            .Parameters.AddWithValue("?img2", DeImagen_a_Bytes(clbimagen.Items.Item(1)))
                            .Parameters.AddWithValue("?codus", lblNumeroReintegro.Text.ToString)
                            .Parameters.AddWithValue("?codben", txtBeneficiario.Text.ToString)
                            .Parameters.AddWithValue("?fecsol", txtFechaSolicitud.Text.ToString)
                            .Parameters.AddWithValue("?det", txtDetalle.Text.ToString)
                            .Parameters.AddWithValue("?imp", varimp)
                            .Parameters.AddWithValue("?cbu", txtCBU.Text.ToString)
                            .Parameters.AddWithValue("?alias", txtAlias.Text.ToString)
                            .Parameters.AddWithValue("?tiporeintegro", Int(vartiporeintegro))
                            .Parameters.AddWithValue("?idsub", 0)
                            .Parameters.AddWithValue("?obsc", txtObservacionesCarga.Text)
                            .Parameters.AddWithValue("?audmed", Int(0))
                            .Parameters.AddWithValue("?porcaudmed", Int(0))
                            .Parameters.AddWithValue("?obsam", varobs)
                            .Parameters.AddWithValue("?est", Int(0))
                            .Parameters.AddWithValue("?obscomision", varobs)
                            .Parameters.AddWithValue("?aut", varobs)
                            .Parameters.AddWithValue("?acargo", Int(-1))
                            .Parameters.AddWithValue("?fecreint", varfec)
                            .Parameters.AddWithValue("?porcreint", Int(0))
                            .Parameters.AddWithValue("?valfinal", Int(0))
                            .Parameters.AddWithValue("?cuilpago", txtCuilPago.Text.ToString)
                            .Parameters.AddWithValue("?tipocuenta", txtTipoCuenta.Text.ToString)

                        Case 3
                            .CommandText = "INSERT INTO `reintegros`(`Codigo_Usuario`,`Codigo_Beneficiario`,`Fecha_Solicitud`,`Detalle`,`Importe`,`CBU`,`Alias`,`tipo_reintegro`,`id_Subsidio`,`Observaciones_Carga`,`imagen1`,`Imagen2`,`Imagen3`,`Auditor_Medico`,`Porcentaje_Reintegro_AM`,`Observaciones_AM`,`Estado`,`Observaciones_Comision`,`Autorizante`,`A_Cargo`,`Fecha_Reintegro`,`Porcentaje_Reintegro_final`,`Valor_Reintegrado`,`Cuil_Pago`,`Tipo_Cuenta`)" & " VALUES " & "(?codus,?codben,?fecsol,?det,?imp,?cbu,?alias,?tiporeintegro,?idsub,?obsc,?img1,?img2,?img3,?audmed,?porcaudmed,?obsam,?est,?obscomision,?aut,?acargo,?fecreint,?porcreint,?valfinal,?cuilpago,?tipocuenta)"
                            .Parameters.AddWithValue("?img1", DeImagen_a_Bytes(clbimagen.Items.Item(0)))
                            .Parameters.AddWithValue("?img2", DeImagen_a_Bytes(clbimagen.Items.Item(1)))
                            .Parameters.AddWithValue("?img3", DeImagen_a_Bytes(clbimagen.Items.Item(2)))
                            .Parameters.AddWithValue("?codus", lblNumeroReintegro.Text.ToString)
                            .Parameters.AddWithValue("?codben", txtBeneficiario.Text.ToString)
                            .Parameters.AddWithValue("?fecsol", txtFechaSolicitud.Text.ToString)
                            .Parameters.AddWithValue("?det", txtDetalle.Text.ToString)
                            .Parameters.AddWithValue("?imp", varimp)
                            .Parameters.AddWithValue("?cbu", txtCBU.Text.ToString)
                            .Parameters.AddWithValue("?alias", txtAlias.Text.ToString)
                            .Parameters.AddWithValue("?tiporeintegro", Int(vartiporeintegro))
                            .Parameters.AddWithValue("?idsub", 0)
                            .Parameters.AddWithValue("?obsc", txtObservacionesCarga.Text)
                            .Parameters.AddWithValue("?audmed", Int(0))
                            .Parameters.AddWithValue("?porcaudmed", Int(0))
                            .Parameters.AddWithValue("?obsam", varobs)
                            .Parameters.AddWithValue("?est", Int(0))
                            .Parameters.AddWithValue("?obscomision", varobs)
                            .Parameters.AddWithValue("?aut", varobs)
                            .Parameters.AddWithValue("?acargo", Int(-1))
                            .Parameters.AddWithValue("?fecreint", varfec)
                            .Parameters.AddWithValue("?porcreint", Int(0))
                            .Parameters.AddWithValue("?valfinal", Int(0))
                            .Parameters.AddWithValue("?cuilpago", txtCuilPago.Text.ToString)
                            .Parameters.AddWithValue("?tipocuenta", txtTipoCuenta.Text.ToString)

                        Case 4
                            .CommandText = "INSERT INTO `reintegros`(`Codigo_Usuario`,`Codigo_Beneficiario`,`Fecha_Solicitud`,`Detalle`,`Importe`,`CBU`,`Alias`,`tipo_reintegro`,`id_Subsidio`,`Observaciones_Carga`,`imagen1`,`Imagen2`,`Imagen3`,`Imagen4`,`Auditor_Medico`,`Porcentaje_Reintegro_AM`,`Observaciones_AM`,`Estado`,`Observaciones_Comision`,`Autorizante`,`A_Cargo`,`Fecha_Reintegro`,`Porcentaje_Reintegro_final`,`Valor_Reintegrado`,`Cuil_Pago`,`Tipo_Cuenta`)" & " VALUES " & "(?codus,?codben,?fecsol,?det,?imp,?cbu,?alias,?tiporeintegro,?idsub,?obsc,?img1,?img2,?img3,?img4,?audmed,?porcaudmed,?obsam,?est,?obscomision,?aut,?acargo,?fecreint,?porcreint,?valfinal,?cuilpago,?tipocuenta)"
                            .Parameters.AddWithValue("?img1", DeImagen_a_Bytes(clbimagen.Items.Item(0)))
                            .Parameters.AddWithValue("?img2", DeImagen_a_Bytes(clbimagen.Items.Item(1)))
                            .Parameters.AddWithValue("?img3", DeImagen_a_Bytes(clbimagen.Items.Item(2)))
                            .Parameters.AddWithValue("?img4", DeImagen_a_Bytes(clbimagen.Items.Item(3)))
                            .Parameters.AddWithValue("?codus", lblNumeroReintegro.Text.ToString)
                            .Parameters.AddWithValue("?codben", txtBeneficiario.Text.ToString)
                            .Parameters.AddWithValue("?fecsol", txtFechaSolicitud.Text.ToString)
                            .Parameters.AddWithValue("?det", txtDetalle.Text.ToString)
                            .Parameters.AddWithValue("?imp", varimp)
                            .Parameters.AddWithValue("?cbu", txtCBU.Text.ToString)
                            .Parameters.AddWithValue("?alias", txtAlias.Text.ToString)
                            .Parameters.AddWithValue("?tiporeintegro", Int(vartiporeintegro))
                            .Parameters.AddWithValue("?idsub", 0)
                            .Parameters.AddWithValue("?obsc", txtObservacionesCarga.Text)
                            .Parameters.AddWithValue("?audmed", Int(0))
                            .Parameters.AddWithValue("?porcaudmed", Int(0))
                            .Parameters.AddWithValue("?obsam", varobs)
                            .Parameters.AddWithValue("?est", Int(0))
                            .Parameters.AddWithValue("?obscomision", varobs)
                            .Parameters.AddWithValue("?aut", varobs)
                            .Parameters.AddWithValue("?acargo", Int(-1))
                            .Parameters.AddWithValue("?fecreint", varfec)
                            .Parameters.AddWithValue("?porcreint", Int(0))
                            .Parameters.AddWithValue("?valfinal", Int(0))
                            .Parameters.AddWithValue("?cuilpago", txtCuilPago.Text.ToString)
                            .Parameters.AddWithValue("?tipocuenta", txtTipoCuenta.Text.ToString)

                        Case 5
                            .CommandText = "INSERT INTO `reintegros`(`Codigo_Usuario`,`Codigo_Beneficiario`,`Fecha_Solicitud`,`Detalle`,`Importe`,`CBU`,`Alias`,`tipo_reintegro`,`id_Subsidio`,`Observaciones_Carga`,`imagen1`,`Imagen2`,`Imagen3`,`Imagen4`,`Imagen5`,`Auditor_Medico`,`Porcentaje_Reintegro_AM`,`Observaciones_AM`,`Estado`,`Observaciones_Comision`,`Autorizante`,`A_Cargo`,`Fecha_Reintegro`,`Porcentaje_Reintegro_final`,`Valor_Reintegrado`,`Cuil_Pago`,`Tipo_Cuenta`)" & " VALUES " & "(?codus,?codben,?fecsol,?det,?imp,?cbu,?alias,?tiporeintegro,?idsub,?obsc,?img1,?img2,?img3,?img4,?img5,?audmed,?porcaudmed,?obsam,?est,?obscomision,?aut,?acargo,?fecreint,?porcreint,?valfinal,?cuilpago,?tipocuenta)"
                            .Parameters.AddWithValue("?img1", DeImagen_a_Bytes(clbimagen.Items.Item(0)))
                            .Parameters.AddWithValue("?img2", DeImagen_a_Bytes(clbimagen.Items.Item(1)))
                            .Parameters.AddWithValue("?img3", DeImagen_a_Bytes(clbimagen.Items.Item(2)))
                            .Parameters.AddWithValue("?img4", DeImagen_a_Bytes(clbimagen.Items.Item(3)))
                            .Parameters.AddWithValue("?img5", DeImagen_a_Bytes(clbimagen.Items.Item(4)))
                            .Parameters.AddWithValue("?codus", lblNumeroReintegro.Text.ToString)
                            .Parameters.AddWithValue("?codben", txtBeneficiario.Text.ToString)
                            .Parameters.AddWithValue("?fecsol", txtFechaSolicitud.Text.ToString)
                            .Parameters.AddWithValue("?det", txtDetalle.Text.ToString)
                            .Parameters.AddWithValue("?imp", varimp)
                            .Parameters.AddWithValue("?cbu", txtCBU.Text.ToString)
                            .Parameters.AddWithValue("?alias", txtAlias.Text.ToString)
                            .Parameters.AddWithValue("?tiporeintegro", Int(vartiporeintegro))
                            .Parameters.AddWithValue("?idsub", 0)
                            .Parameters.AddWithValue("?obsc", txtObservacionesCarga.Text)
                            .Parameters.AddWithValue("?audmed", Int(0))
                            .Parameters.AddWithValue("?porcaudmed", Int(0))
                            .Parameters.AddWithValue("?obsam", varobs)
                            .Parameters.AddWithValue("?est", Int(0))
                            .Parameters.AddWithValue("?obscomision", varobs)
                            .Parameters.AddWithValue("?aut", varobs)
                            .Parameters.AddWithValue("?acargo", Int(-1))
                            .Parameters.AddWithValue("?fecreint", varfec)
                            .Parameters.AddWithValue("?porcreint", Int(0))
                            .Parameters.AddWithValue("?valfinal", Int(0))
                            .Parameters.AddWithValue("?cuilpago", txtCuilPago.Text.ToString)
                            .Parameters.AddWithValue("?tipocuenta", txtTipoCuenta.Text.ToString)
                    End Select
                End If
                'OPTION SUBSIDIO <<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
                If opSubsidio.Checked = True Then
                    vartiporeintegro = 1
                    Select Case (clbimagen.Items.Count)
                        '?codus,?codben,?fecsol,?det,?imp,?obsc,?img1,?img2,?img3,?img4,?img5,?audmed,?porcaudmed,?obsam,?est,?aut,?acargo,?fecreint,?porcreint,?valfinal
                        Case 0
                            .CommandText = "INSERT INTO `reintegros`(`Codigo_Usuario`,`Codigo_Beneficiario`,`Fecha_Solicitud`,`Detalle`,`Importe`,`CBU`,`Alias`,`tipo_reintegro`,`id_Subsidio`,`Observaciones_Carga`,`Auditor_Medico`,`Porcentaje_Reintegro_AM`,`Observaciones_AM`,`Estado`,`Observaciones_Comision`,`Autorizante`,`A_Cargo`,`Fecha_Reintegro`,`Porcentaje_Reintegro_final`,`Valor_Reintegrado`,`Cuil_Pago`,`Tipo_Cuenta`)" & " VALUES " & "(?codus,?codben,?fecsol,?det,?imp,?cbu,?alias,?tiporeintegro,?idsub,?obsc,?audmed,?porcaudmed,?obsam,?est,?obscomision,?aut,?acargo,?fecreint,?porcreint,?valfinal,?cuilpago,?tipocuenta)"
                            .Parameters.AddWithValue("?codus", lblNumeroReintegro.Text.ToString)
                            .Parameters.AddWithValue("?codben", txtBeneficiario.Text.ToString)
                            .Parameters.AddWithValue("?fecsol", txtFechaSolicitud.Text.ToString)
                            .Parameters.AddWithValue("?det", txtDetalle.Text.ToString)
                            .Parameters.AddWithValue("?imp", varimp)
                            .Parameters.AddWithValue("?cbu", txtCBU.Text.ToString)
                            .Parameters.AddWithValue("?alias", txtAlias.Text.ToString)
                            .Parameters.AddWithValue("?tiporeintegro", Int(vartiporeintegro))
                            .Parameters.AddWithValue("?idsub", Int(txtSubsidio.Text))
                            .Parameters.AddWithValue("?obsc", txtObservacionesCarga.Text)
                            .Parameters.AddWithValue("?audmed", Int(0))
                            .Parameters.AddWithValue("?porcaudmed", Int(0))
                            .Parameters.AddWithValue("?obsam", varobs)
                            .Parameters.AddWithValue("?est", Int(0))
                            .Parameters.AddWithValue("?obscomision", varobs)
                            .Parameters.AddWithValue("?aut", varobs)
                            .Parameters.AddWithValue("?acargo", Int(-1))
                            .Parameters.AddWithValue("?fecreint", varfec)
                            .Parameters.AddWithValue("?porcreint", Int(0))
                            .Parameters.AddWithValue("?valfinal", Int(0))
                            .Parameters.AddWithValue("?cuilpago", txtCuilPago.Text.ToString)
                            .Parameters.AddWithValue("?tipocuenta", txtTipoCuenta.Text.ToString)

                        Case 1
                            .CommandText = "INSERT INTO `reintegros`(`Codigo_Usuario`,`Codigo_Beneficiario`,`Fecha_Solicitud`,`Detalle`,`Importe`,`CBU`,`Alias`,`tipo_reintegro`,`id_Subsidio`,`Observaciones_Carga`,`Imagen1`,`Auditor_Medico`,`Porcentaje_Reintegro_AM`,`Observaciones_AM`,`Estado`,`Observaciones_Comision`,`Autorizante`,`A_Cargo`,`Fecha_Reintegro`,`Porcentaje_Reintegro_final`,`Valor_Reintegrado`,`Cuil_Pago`,`Tipo_Cuenta`)" & " VALUES " & "(?codus,?codben,?fecsol,?det,?imp,?cbu,?alias,?tiporeintegro,?idsub,?obsc,?img1,?audmed,?porcaudmed,?obsam,?est,?obscomision,?aut,?acargo,?fecreint,?porcreint,?valfinal,?cuilpago,?tipocuenta)"
                            .Parameters.AddWithValue("?img1", DeImagen_a_Bytes(clbimagen.Items.Item(0)))
                            .Parameters.AddWithValue("?codus", lblNumeroReintegro.Text.ToString)
                            .Parameters.AddWithValue("?codben", txtBeneficiario.Text.ToString)
                            .Parameters.AddWithValue("?fecsol", txtFechaSolicitud.Text.ToString)
                            .Parameters.AddWithValue("?det", txtDetalle.Text.ToString)
                            .Parameters.AddWithValue("?imp", varimp)
                            .Parameters.AddWithValue("?cbu", txtCBU.Text.ToString)
                            .Parameters.AddWithValue("?alias", txtAlias.Text.ToString)
                            .Parameters.AddWithValue("?tiporeintegro", Int(vartiporeintegro))
                            .Parameters.AddWithValue("?idsub", Int(txtSubsidio.Text))
                            .Parameters.AddWithValue("?obsc", txtObservacionesCarga.Text)
                            .Parameters.AddWithValue("?audmed", Int(0))
                            .Parameters.AddWithValue("?porcaudmed", Int(0))
                            .Parameters.AddWithValue("?obsam", varobs)
                            .Parameters.AddWithValue("?est", Int(0))
                            .Parameters.AddWithValue("?obscomision", varobs)
                            .Parameters.AddWithValue("?aut", varobs)
                            .Parameters.AddWithValue("?acargo", Int(-1))
                            .Parameters.AddWithValue("?fecreint", varfec)
                            .Parameters.AddWithValue("?porcreint", Int(0))
                            .Parameters.AddWithValue("?valfinal", Int(0))
                            .Parameters.AddWithValue("?cuilpago", txtCuilPago.Text.ToString)
                            .Parameters.AddWithValue("?tipocuenta", txtTipoCuenta.Text.ToString)
                        Case 2
                            .CommandText = "INSERT INTO `reintegros`(`Codigo_Usuario`,`Codigo_Beneficiario`,`Fecha_Solicitud`,`Detalle`,`Importe`,`CBU`,`Alias`,`tipo_reintegro`,`id_Subsidio`,`Observaciones_Carga`,`imagen1`,`Imagen2`,`Auditor_Medico`,`Porcentaje_Reintegro_AM`,`Observaciones_AM`,`Estado`,`Observaciones_Comision`,`Autorizante`,`A_Cargo`,`Fecha_Reintegro`,`Porcentaje_Reintegro_final`,`Valor_Reintegrado`,`Cuil_Pago`,`Tipo_Cuenta`)" & " VALUES " & "(?codus,?codben,?fecsol,?det,?imp,?cbu,?alias,?tiporeintegro,?idsub,?obsc,?img1,?img2,?audmed,?porcaudmed,?obsam,?est,?obscomision,?aut,?acargo,?fecreint,?porcreint,?valfinal,?cuilpago,?tipocuenta)"
                            .Parameters.AddWithValue("?img1", DeImagen_a_Bytes(clbimagen.Items.Item(0)))
                            .Parameters.AddWithValue("?img2", DeImagen_a_Bytes(clbimagen.Items.Item(1)))
                            .Parameters.AddWithValue("?codus", lblNumeroReintegro.Text.ToString)
                            .Parameters.AddWithValue("?codben", txtBeneficiario.Text.ToString)
                            .Parameters.AddWithValue("?fecsol", txtFechaSolicitud.Text.ToString)
                            .Parameters.AddWithValue("?det", txtDetalle.Text.ToString)
                            .Parameters.AddWithValue("?imp", varimp)
                            .Parameters.AddWithValue("?cbu", txtCBU.Text.ToString)
                            .Parameters.AddWithValue("?alias", txtAlias.Text.ToString)
                            .Parameters.AddWithValue("?tiporeintegro", Int(vartiporeintegro))
                            .Parameters.AddWithValue("?idsub", Int(txtSubsidio.Text))
                            .Parameters.AddWithValue("?obsc", txtObservacionesCarga.Text)
                            .Parameters.AddWithValue("?audmed", Int(0))
                            .Parameters.AddWithValue("?porcaudmed", Int(0))
                            .Parameters.AddWithValue("?obsam", varobs)
                            .Parameters.AddWithValue("?est", Int(0))
                            .Parameters.AddWithValue("?obscomision", varobs)
                            .Parameters.AddWithValue("?aut", varobs)
                            .Parameters.AddWithValue("?acargo", Int(-1))
                            .Parameters.AddWithValue("?fecreint", varfec)
                            .Parameters.AddWithValue("?porcreint", Int(0))
                            .Parameters.AddWithValue("?valfinal", Int(0))
                            .Parameters.AddWithValue("?cuilpago", txtCuilPago.Text.ToString)
                            .Parameters.AddWithValue("?tipocuenta", txtTipoCuenta.Text.ToString)

                        Case 3
                            .CommandText = "INSERT INTO `reintegros`(`Codigo_Usuario`,`Codigo_Beneficiario`,`Fecha_Solicitud`,`Detalle`,`Importe`,`CBU`,`Alias`,`tipo_reintegro`,`id_Subsidio`,`Observaciones_Carga`,`imagen1`,`Imagen2`,`Imagen3`,`Auditor_Medico`,`Porcentaje_Reintegro_AM`,`Observaciones_AM`,`Estado`,`Observaciones_Comision`,`Autorizante`,`A_Cargo`,`Fecha_Reintegro`,`Porcentaje_Reintegro_final`,`Valor_Reintegrado`,`Cuil_Pago`,`Tipo_Cuenta`)" & " VALUES " & "(?codus,?codben,?fecsol,?det,?imp,?cbu,?alias,?tiporeintegro,?idsub,?obsc,?img1,?img2,?img3,?audmed,?porcaudmed,?obsam,?est,?obscomision,?aut,?acargo,?fecreint,?porcreint,?valfinal,?cuilpago,?tipocuenta)"
                            .Parameters.AddWithValue("?img1", DeImagen_a_Bytes(clbimagen.Items.Item(0)))
                            .Parameters.AddWithValue("?img2", DeImagen_a_Bytes(clbimagen.Items.Item(1)))
                            .Parameters.AddWithValue("?img3", DeImagen_a_Bytes(clbimagen.Items.Item(2)))
                            .Parameters.AddWithValue("?codus", lblNumeroReintegro.Text.ToString)
                            .Parameters.AddWithValue("?codben", txtBeneficiario.Text.ToString)
                            .Parameters.AddWithValue("?fecsol", txtFechaSolicitud.Text.ToString)
                            .Parameters.AddWithValue("?det", txtDetalle.Text.ToString)
                            .Parameters.AddWithValue("?imp", varimp)
                            .Parameters.AddWithValue("?cbu", txtCBU.Text.ToString)
                            .Parameters.AddWithValue("?alias", txtAlias.Text.ToString)
                            .Parameters.AddWithValue("?tiporeintegro", Int(vartiporeintegro))
                            .Parameters.AddWithValue("?idsub", Int(txtSubsidio.Text))
                            .Parameters.AddWithValue("?obsc", txtObservacionesCarga.Text)
                            .Parameters.AddWithValue("?audmed", Int(0))
                            .Parameters.AddWithValue("?porcaudmed", Int(0))
                            .Parameters.AddWithValue("?obsam", varobs)
                            .Parameters.AddWithValue("?est", Int(0))
                            .Parameters.AddWithValue("?obscomision", varobs)
                            .Parameters.AddWithValue("?aut", varobs)
                            .Parameters.AddWithValue("?acargo", Int(-1))
                            .Parameters.AddWithValue("?fecreint", varfec)
                            .Parameters.AddWithValue("?porcreint", Int(0))
                            .Parameters.AddWithValue("?valfinal", Int(0))
                            .Parameters.AddWithValue("?cuilpago", txtCuilPago.Text.ToString)
                            .Parameters.AddWithValue("?tipocuenta", txtTipoCuenta.Text.ToString)

                        Case 4
                            .CommandText = "INSERT INTO `reintegros`(`Codigo_Usuario`,`Codigo_Beneficiario`,`Fecha_Solicitud`,`Detalle`,`Importe`,`CBU`,`Alias`,`tipo_reintegro`,`id_Subsidio`,`Observaciones_Carga`,`imagen1`,`Imagen2`,`Imagen3`,`Imagen4`,`Auditor_Medico`,`Porcentaje_Reintegro_AM`,`Observaciones_AM`,`Estado`,`Observaciones_Comision`,`Autorizante`,`A_Cargo`,`Fecha_Reintegro`,`Porcentaje_Reintegro_final`,`Valor_Reintegrado`,`Cuil_Pago`,`Tipo_Cuenta`)" & " VALUES " & "(?codus,?codben,?fecsol,?det,?imp,?cbu,?alias,?tiporeintegro,?idsub,?obsc,?img1,?img2,?img3,?img4,?audmed,?porcaudmed,?obsam,?est,?obscomision,?aut,?acargo,?fecreint,?porcreint,?valfinal,?cuilpago,?tipocuenta)"
                            .Parameters.AddWithValue("?img1", DeImagen_a_Bytes(clbimagen.Items.Item(0)))
                            .Parameters.AddWithValue("?img2", DeImagen_a_Bytes(clbimagen.Items.Item(1)))
                            .Parameters.AddWithValue("?img3", DeImagen_a_Bytes(clbimagen.Items.Item(2)))
                            .Parameters.AddWithValue("?img4", DeImagen_a_Bytes(clbimagen.Items.Item(3)))
                            .Parameters.AddWithValue("?codus", lblNumeroReintegro.Text.ToString)
                            .Parameters.AddWithValue("?codben", txtBeneficiario.Text.ToString)
                            .Parameters.AddWithValue("?fecsol", txtFechaSolicitud.Text.ToString)
                            .Parameters.AddWithValue("?det", txtDetalle.Text.ToString)
                            .Parameters.AddWithValue("?imp", varimp)
                            .Parameters.AddWithValue("?cbu", txtCBU.Text.ToString)
                            .Parameters.AddWithValue("?alias", txtAlias.Text.ToString)
                            .Parameters.AddWithValue("?tiporeintegro", Int(vartiporeintegro))
                            .Parameters.AddWithValue("?idsub", Int(txtSubsidio.Text))
                            .Parameters.AddWithValue("?obsc", txtObservacionesCarga.Text)
                            .Parameters.AddWithValue("?audmed", Int(0))
                            .Parameters.AddWithValue("?porcaudmed", Int(0))
                            .Parameters.AddWithValue("?obsam", varobs)
                            .Parameters.AddWithValue("?est", Int(0))
                            .Parameters.AddWithValue("?obscomision", varobs)
                            .Parameters.AddWithValue("?aut", varobs)
                            .Parameters.AddWithValue("?acargo", Int(-1))
                            .Parameters.AddWithValue("?fecreint", varfec)
                            .Parameters.AddWithValue("?porcreint", Int(0))
                            .Parameters.AddWithValue("?valfinal", Int(0))
                            .Parameters.AddWithValue("?cuilpago", txtCuilPago.Text.ToString)
                            .Parameters.AddWithValue("?tipocuenta", txtTipoCuenta.Text.ToString)

                        Case 5
                            .CommandText = "INSERT INTO `reintegros`(`Codigo_Usuario`,`Codigo_Beneficiario`,`Fecha_Solicitud`,`Detalle`,`Importe`,`CBU`,`Alias`,`tipo_reintegro`,`id_Subsidio`,`Observaciones_Carga`,`imagen1`,`Imagen2`,`Imagen3`,`Imagen4`,`Imagen5`,`Auditor_Medico`,`Porcentaje_Reintegro_AM`,`Observaciones_AM`,`Estado`,`Observaciones_Comision`,`Autorizante`,`A_Cargo`,`Fecha_Reintegro`,`Porcentaje_Reintegro_final`,`Valor_Reintegrado`,`Cuil_Pago`,`Tipo_Cuenta`)" & " VALUES " & "(?codus,?codben,?fecsol,?det,?imp,?cbu,?alias,?tiporeintegro,?idsub,?obsc,?img1,?img2,?img3,?img4,?img5,?audmed,?porcaudmed,?obsam,?est,?obscomision,?aut,?acargo,?fecreint,?porcreint,?valfinal,?cuilpago,?tipocuenta)"
                            .Parameters.AddWithValue("?img1", DeImagen_a_Bytes(clbimagen.Items.Item(0)))
                            .Parameters.AddWithValue("?img2", DeImagen_a_Bytes(clbimagen.Items.Item(1)))
                            .Parameters.AddWithValue("?img3", DeImagen_a_Bytes(clbimagen.Items.Item(2)))
                            .Parameters.AddWithValue("?img4", DeImagen_a_Bytes(clbimagen.Items.Item(3)))
                            .Parameters.AddWithValue("?img5", DeImagen_a_Bytes(clbimagen.Items.Item(4)))
                            .Parameters.AddWithValue("?codus", lblNumeroReintegro.Text.ToString)
                            .Parameters.AddWithValue("?codben", txtBeneficiario.Text.ToString)
                            .Parameters.AddWithValue("?fecsol", txtFechaSolicitud.Text.ToString)
                            .Parameters.AddWithValue("?det", txtDetalle.Text.ToString)
                            .Parameters.AddWithValue("?imp", varimp)
                            .Parameters.AddWithValue("?cbu", txtCBU.Text.ToString)
                            .Parameters.AddWithValue("?alias", txtAlias.Text.ToString)
                            .Parameters.AddWithValue("?tiporeintegro", Int(vartiporeintegro))
                            .Parameters.AddWithValue("?idsub", Int(txtSubsidio.Text))
                            .Parameters.AddWithValue("?obsc", txtObservacionesCarga.Text)
                            .Parameters.AddWithValue("?audmed", Int(0))
                            .Parameters.AddWithValue("?porcaudmed", Int(0))
                            .Parameters.AddWithValue("?obsam", varobs)
                            .Parameters.AddWithValue("?est", Int(0))
                            .Parameters.AddWithValue("?obscomision", varobs)
                            .Parameters.AddWithValue("?aut", varobs)
                            .Parameters.AddWithValue("?acargo", Int(-1))
                            .Parameters.AddWithValue("?fecreint", varfec)
                            .Parameters.AddWithValue("?porcreint", Int(0))
                            .Parameters.AddWithValue("?valfinal", Int(0))
                            .Parameters.AddWithValue("?cuilpago", txtCuilPago.Text.ToString)
                            .Parameters.AddWithValue("?tipocuenta", txtTipoCuenta.Text.ToString)
                    End Select


                End If
            End With
            Try
                con_insert.Open()
                cmdinsert.ExecuteNonQuery()
                con_insert.Close()
                MessageBox.Show("SOLICITUD GENERADA CORRECTAMENTE", "NUEVA SOLICITUD DE REINTEGRO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cont = 0
            Catch falla As MySqlException
                MsgBox(falla.Message)
            End Try
        End Using
    End Sub
    '*********************************************************************************************************************************************
    '*********************************************************************************************************************************************
    '*********************************************************************************************************************************************
    Private Sub limpiarTextboxOperacion()
        txtDetalle.Text = ""
        txtImporte.Text = ""
        txtFechaSolicitud.Text = ""
        txtObservacionesCarga.Text = ""
        txtCBU.Text = ""
        txtAlias.Text = ""
        txtSubsidio.Text = ""
        txtDetalle.Focus()
    End Sub

    Private Sub limpiarDatosBeneficiarios()
        txtBeneficiario.Text = ""
        txtBusqueda.Text = ""
        txtCUIL.Text = ""
        txtApellidoNombre.Text = ""
        comboTipoBeneficiario.Text = ""
        comboSexo.Text = ""
        txtMail.Text = ""
        txtTelefono.Text = ""
        txtCelular.Text = ""
        botonImagen.Visible = False
    End Sub
    Private Sub apagaDatosBeneficiarios()

    End Sub
    Private Sub apagaDatosOperacion()
        txtDetalle.Enabled = False
        txtImporte.Enabled = False
        txtFechaSolicitud.Enabled = False
        DateTimePicker1.Enabled = False
        txtObservacionesCarga.Enabled = False
        clbimagen.Enabled = False
        botonImagen.Visible = False
        botonQuitarImagen.Visible = False
    End Sub
    Private Sub prendeDatosOperacion()
        txtDetalle.Enabled = True
        txtImporte.Enabled = True
        txtFechaSolicitud.Enabled = False
        DateTimePicker1.Enabled = True
        txtObservacionesCarga.Enabled = True
        clbimagen.Visible = True
        clbimagen.Enabled = True
        botonImagen.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        txtFechaSolicitud.Text = DateTimePicker1.Value.Year & "-" & DateTimePicker1.Value.Month & "-" & DateTimePicker1.Value.Day
    End Sub

    'BOTON AÑADIR IMAGEN
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botonImagen.Click
        Dim existe As Boolean = False
        cont = clbimagen.Items.Count
        OpenFileDialog1.InitialDirectory = "c:\Users\Local\Pictures"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            If (cont < 5) Then
                clbimagen.Items.Add(Image.FromFile(OpenFileDialog1.FileName))
                cont = clbimagen.Items.Count
                botonImagen.Text = "+Subir Imagen " & "[" & cont & "]"
                lblcontadoritems.Text = clbimagen.Items.Count
                botonQuitarImagen.Visible = True
                botonQuitarImagen.Enabled = True
            Else
                lblitem.Text = clbimagen.Items.Item(0).ToString
                MsgBox("Maximo de Imagenes Permitido", vbExclamation)
                botonImagen.Visible = False
            End If
        End If
    End Sub



    'Al seleccionar item carga el PictureBox
    Private Sub clbimagen_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clbimagen.SelectedIndexChanged
        Try
            lblPicture.Image = clbimagen.SelectedItem
        Catch ex As Exception
        End Try
    End Sub

    'BOTON ACEPTAR --> GENERA NUEVA SOLICITUD DE REINTEGRO
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If (Trim(txtDetalle.Text) = "") Or (Trim(txtImporte.Text) = "") Or (Trim(txtFechaSolicitud.Text) = "") Or (Trim(txtCBU.Text) = "") Or (Trim(txtAlias.Text) = "") Then
            MsgBox("Por favor Complete todos los datos de la Operacion", vbExclamation, "Faltan Datos")
        Else
            Try
                ProgressBar1.Visible = True
                ProgressBar1.Increment(100)
                Insert_into()
                limpiarTextboxOperacion()
                limpiarDatosBeneficiarios()
                clbimagen.Items.Clear()
                apagaDatosBeneficiarios()
                apagaDatosOperacion()
                lblPicture.Image = Nothing
                botonQuitarImagen.Visible = False
                txtSubsidio.Visible = False
                txtBusqueda.Focus()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        ProgressBar1.Visible = False
    End Sub

    'click en buscar por dni
    Private Sub opBuscarDNI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opBuscarDNI.CheckedChanged
        buscarlosdatos()
        txtBusqueda.Focus()
        txtBusqueda.SelectAll()
    End Sub

    'click en boton buscar por apellido
    Private Sub opBuscarNombre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opBuscarNombre.CheckedChanged
        buscarlosdatos()
        txtBusqueda.Focus()
        txtBusqueda.SelectAll()
    End Sub

    Private Sub botonQuitarImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botonQuitarImagen.Click
        If clbimagen.Items.Count > 0 Then
            clbimagen.Items.Remove(clbimagen.SelectedItem)
            botonImagen.Visible = True
        Else
            If clbimagen.Items.Count = 0 Then
                botonQuitarImagen.Visible = False
            End If
        End If
    End Sub


    'CONTROLA QUE EL TEXTBOX DE IMPORTE SOLO ADMITA NUMEROS POR TECLADO
    Private Sub txtImporte_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtImporte.KeyPress
        e.Handled = NumericOnly(e.KeyChar)
        '  If (e.KeyChar =) Then
        '  Me.Close()
    End Sub

    ' DEFINICION DE FUNCION PARA QUE SOLO ADMITA NUMEROS Y "," EL TEXTBOX IMPORTE
    Public Function NumericOnly(ByVal eChar As Char) As Boolean
        Dim chkStr As String = "0123456789,"
        If chkStr.IndexOf(eChar) > -1 OrElse eChar = vbBack Then
            If eChar = Chr(44) And txtImporte.Text.Contains(",") Then Return True
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub llenaGridSubsidios()
        Try
            sql = "SELECT id_subsidio,detalle,importe FROM tipo_subsidio"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridViewSubsidios.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub opSubsidio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opSubsidio.CheckedChanged
        GridViewSubsidios.Visible = True
        txtSubsidio.Visible = True
    End Sub

    Private Sub opReintegro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opReintegro.CheckedChanged
        GridViewSubsidios.Visible = False
        txtSubsidio.Visible = False
        txtImporte.Text = ""
        txtImporte.Focus()
    End Sub


    Private Sub GridViewSubsidios_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridViewSubsidios.CellClick
        Try
            txtSubsidio.Text = Me.GridViewSubsidios.Rows(e.RowIndex).Cells(0).Value
            txtImporte.Text = Me.GridViewSubsidios.Rows(e.RowIndex).Cells(2).Value
        Catch
        End Try
    End Sub

    Private Sub GridViewSubsidios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridViewSubsidios.CellContentClick
        Try
            txtSubsidio.Text = Me.GridViewSubsidios.Rows(e.RowIndex).Cells(0).Value
            txtImporte.Text = Me.GridViewSubsidios.Rows(e.RowIndex).Cells(2).Value
        Catch
        End Try
    End Sub

    Private Sub GridViewSubsidios_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridViewSubsidios.CellMouseDoubleClick
        GridViewSubsidios.Visible = False
        Try
            txtSubsidio.Text = Me.GridViewSubsidios.Rows(e.RowIndex).Cells(0).Value
            txtImporte.Text = Me.GridViewSubsidios.Rows(e.RowIndex).Cells(2).Value
        Catch
        End Try
    End Sub

    Private Sub txtSubsidio_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSubsidio.DoubleClick
        GridViewSubsidios.Visible = True
    End Sub

    Private Sub txtCBU_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCBU.KeyPress
        'SOLO ADMITE NUMEROS CBU *******
        If InStr("0123456789", e.KeyChar) = False Then
            If (Asc(e.KeyChar)) <> 8 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub GridViewSubsidios_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GridViewSubsidios.KeyPress
        If Asc(e.KeyChar) = 13 Then
            GridViewSubsidios.Visible = False
        End If
    End Sub
End Class

