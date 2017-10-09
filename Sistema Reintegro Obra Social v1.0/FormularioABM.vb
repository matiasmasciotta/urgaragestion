Imports MySql.Data.MySqlClient
Imports System.IO

'FORMULARIO ABM VARIABLES PUBLICAS
Public Class FormularioABM
    Dim Conex As New MySqlConnection(CADENABASE2)
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand
    Dim dniBuscar As String
    Dim nombreBuscar As String
    Dim boo As Boolean
    Dim booModificacion As Boolean
    Dim cont As Integer
    Dim controlDNI As Boolean
    Dim controlNombre As Boolean
    Dim varSQLCAMPOSBENEFICIARIOS As String = "Beneficiarios.Codigo_Beneficiario,Beneficiarios.Cuil,Beneficiarios.ApellidoNombre,Beneficiarios.Sexo,Beneficiarios.Calle," & _
        "Beneficiarios.Puerta,Beneficiarios.Piso,Beneficiarios.Codigo_Postal,Beneficiarios.Celular,Beneficiarios.Telefono,Beneficiarios.Mail,Beneficiarios.Localidad," & _
        "Beneficiarios.Provincia,Beneficiarios.Urgara,Beneficiarios.TipoBeneficiarioTitular,Beneficiarios.Parentesco,Parentesco.Descripcion"
    '(00)Codigo_Beneficiario,(01)Cuil,(02)ApellidoNombre,(03)Sexo,(04)Calle,(05)Puerta,(06)Piso,(07)Codigo_Postal,(08)Celular,(09)Telefono,(10)Mail,(11)Localidad,(12)Provincia,
    '(13)Urgara,(14)TipoBeneficiarioTitular,(15)Parentesco,(16)Parentesco.Descripcion

    'Private Property prog As Integer
    'boton Cancelar
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If booModificacion = False Then
            Me.Close()
        Else
            apagarTextBox()
            booModificacion = False
        End If
    End Sub

    'CUANDO CARGA EL FORMULARIO ABM **************************
    Private Sub FormularioABM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        opUrgara.Checked = False
        opBuscarDNI.Checked = True
        booModificacion = False
        'botonModificarBeneficiario.Enabled = False
        mostrarlosdatos()
        boo = False
        cont = 0
        txtBusqueda.Focus()
        controlDNI = True
        controlNombre = False
        'deshabilito los textbox
        apagarTextBox()
        'botonConfirmarAlta.Enabled = False
    End Sub

    '@Metodo Deshabilita Los TextBox de Datos Personales (BENEFICIARIOS)
    Public Sub apagarTextBox()
        txtBeneficiario.Enabled = False
        txtCUIL.Enabled = False
        txtApellidoNombre.Enabled = False
        comboTipoBeneficiario.Enabled = False
        comboTipoBeneficiario.Items.Add("TITULAR")
        comboTipoBeneficiario.Items.Add("ADHERENTE")
        comboSexo.Enabled = False
        txtCalle.Enabled = False
        txtPuerta.Enabled = False
        txtPiso.Enabled = False
        txtCP.Enabled = False
        txtLocalidad.Enabled = False
        txtProvincia.Enabled = False
        txtCelular.Enabled = False
        txtTelefono.Enabled = False
        txtMail.Enabled = False
    End Sub

    '@Metodo Habilita Los TextBox de Datos Personales (BENEFICIARIOS)
    Public Sub prenderTextBox()
        'ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        txtBeneficiario.Enabled = True
        txtCUIL.Enabled = True
        txtApellidoNombre.Enabled = True
        comboTipoBeneficiario.Enabled = True
        comboSexo.Enabled = True
        txtCalle.Enabled = True
        txtPuerta.Enabled = True
        txtPiso.Enabled = True
        txtCP.Enabled = True
        txtLocalidad.Enabled = True
        txtProvincia.Enabled = True
        txtCelular.Enabled = True
        txtTelefono.Enabled = True
        txtMail.Enabled = True
    End Sub

    'CUANDO COMIENZO A ESCRIBIR EN EL TEXTBOX DE BUSQUEDA ********************************
    Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged
        buscarlosdatos()
    End Sub

    '@Metodo Llena Datos en GridVIEW
    Private Sub mostrarlosdatos()
        Try
            sql = "SELECT " & varSQLCAMPOSBENEFICIARIOS & " from beneficiarios,Parentesco where (Beneficiarios.Parentesco = Parentesco.Codigo)"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '@Metodo Para LLenar el GridView a partir de la BUSQUEDA *****************************
    Private Sub buscarlosdatos()
        Try
            If (opBuscarDNI.Checked = True) And (opBuscarNombre.Checked = False) Then
                sql = "SELECT " & varSQLCAMPOSBENEFICIARIOS & " from beneficiarios,Parentesco WHERE (Beneficiarios.Parentesco = Parentesco.Codigo) and (Beneficiarios.Cuil LIKE '%" & txtBusqueda.Text.ToString & "%')"
                controlNombre = False
            End If
            If (opBuscarNombre.Checked = True) And (opBuscarDNI.Checked = False) Then
                sql = "SELECT " & varSQLCAMPOSBENEFICIARIOS & " from beneficiarios,Parentesco WHERE (Beneficiarios.Parentesco = Parentesco.Codigo) and (Beneficiarios.ApellidoNombre LIKE '%" & txtBusqueda.Text.ToString & "%')"
                controlDNI = False
            End If
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    ' 1111-  LLENA LOS TEXTBOX CON LOS DATOS DE LA SELECCION DEL GRIDVIEW **************************
    Private Sub GridView_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridView.CellClick
        Try
            txtBeneficiario.Text = Me.GridView.Rows(e.RowIndex).Cells(0).Value
            tempCodigo_Beneficiario.Text = Me.GridView.Rows(e.RowIndex).Cells(0).Value

            txtCUIL.Text = Me.GridView.Rows(e.RowIndex).Cells(1).Value
            tempCuil.Text = Me.GridView.Rows(e.RowIndex).Cells(1).Value

            txtApellidoNombre.Text = Me.GridView.Rows(e.RowIndex).Cells(2).Value
            tempApellidoNombre.Text = Me.GridView.Rows(e.RowIndex).Cells(2).Value

            comboSexo.Items.Clear()
            comboSexo.Text = Me.GridView.Rows(e.RowIndex).Cells(3).Value
            If comboSexo.Text = "M" Then
                comboSexo.Items.Add("F")
            Else
                comboSexo.Items.Add("M")
            End If
            txtCalle.Text = Me.GridView.Rows(e.RowIndex).Cells(4).Value
            txtPuerta.Text = Me.GridView.Rows(e.RowIndex).Cells(5).Value
            txtPiso.Text = Me.GridView.Rows(e.RowIndex).Cells(6).Value
            txtCP.Text = Me.GridView.Rows(e.RowIndex).Cells(7).Value
            txtLocalidad.Text = Me.GridView.Rows(e.RowIndex).Cells(11).Value
            txtProvincia.Text = Me.GridView.Rows(e.RowIndex).Cells(12).Value
            'titular o adherente
            If Me.GridView.Rows(e.RowIndex).Cells(14).Value = 1 Then
                comboTipoBeneficiario.Text = "TITULAR"
            Else
                comboTipoBeneficiario.Text = "ADHERENTE"
            End If
            'parentesco
            txtParentesco.Text = Me.GridView.Rows(e.RowIndex).Cells(16).Value
            'Afiliado a urgara
            If Me.GridView.Rows(e.RowIndex).Cells(13).Value = 0 Then
                opUrgara.Checked = False
            End If
            If Me.GridView.Rows(e.RowIndex).Cells(13).Value = 1 Then
                opUrgara.Checked = True
            End If
            txtCelular.Text = Me.GridView.Rows(e.RowIndex).Cells(8).Value
            txtTelefono.Text = Me.GridView.Rows(e.RowIndex).Cells(9).Value
            txtMail.Text = Me.GridView.Rows(e.RowIndex).Cells(10).Value
        Catch
        End Try
        'botonModificarBeneficiario.Enabled = True
    End Sub

    '2222
    Private Sub GridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridView.CellContentClick
        Try
            txtBeneficiario.Text = Me.GridView.Rows(e.RowIndex).Cells(0).Value
            tempCodigo_Beneficiario.Text = Me.GridView.Rows(e.RowIndex).Cells(0).Value

            txtCUIL.Text = Me.GridView.Rows(e.RowIndex).Cells(1).Value
            tempCuil.Text = Me.GridView.Rows(e.RowIndex).Cells(1).Value

            txtApellidoNombre.Text = Me.GridView.Rows(e.RowIndex).Cells(2).Value
            tempApellidoNombre.Text = Me.GridView.Rows(e.RowIndex).Cells(2).Value

            comboSexo.Items.Clear()
            comboSexo.Text = Me.GridView.Rows(e.RowIndex).Cells(3).Value
            If comboSexo.Text = "M" Then
                comboSexo.Items.Add("F")
            Else
                comboSexo.Items.Add("M")
            End If
            txtCalle.Text = Me.GridView.Rows(e.RowIndex).Cells(4).Value
            txtPuerta.Text = Me.GridView.Rows(e.RowIndex).Cells(5).Value
            txtPiso.Text = Me.GridView.Rows(e.RowIndex).Cells(6).Value
            txtCP.Text = Me.GridView.Rows(e.RowIndex).Cells(7).Value
            txtLocalidad.Text = Me.GridView.Rows(e.RowIndex).Cells(11).Value
            txtProvincia.Text = Me.GridView.Rows(e.RowIndex).Cells(12).Value
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
        'botonModificarBeneficiario.Enabled = True
    End Sub



    ' Private Sub botonModificarBeneficiario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botonModificarBeneficiario.Click
    '     botonAgregarBeneficiario.Visible = False
    '     booModificacion = True
    ' 'BOTON MODIFICAR --> HABILITA LOS TEXTBOX
    '     prenderTextBox()
    '     OK.Visible = True
    '     CANCELAR.Visible = True
    '     GridView.Enabled = False
    ' End Sub

    ' Private Sub CANCELAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CANCELAR.Click
    '     OK.Visible = False
    '     CANCELAR.Visible = False
    '     apagarTextBox()
    '     GridView.Enabled = True
    ' End Sub

    Private Sub txtDetalle_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.botonConfirmarAlta.Enabled = True
        'botonConfirmarAlta.Enabled = False
    End Sub

    ' Private Function Imagen_Bytes(ByVal image As Image) As Byte()
    '     Throw New NotImplementedException
    ' End Function


    'UPDATE TABLA BENEFICIARIOS
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        ' updatebeneficiarios()
        update_to()
        buscarlosdatos()
        'OK.Visible = False
        'CANCELAR.Visible = False
        apagarTextBox()
        GridView.Enabled = True
        GridView.Refresh()
        txtBusqueda.Focus()
    End Sub

    ' viejo ********************************************************************
    '@Metodo Actualiza BASE DE DATOS BENEFICIARIOS
    ' Private Sub updatebeneficiarios()
    '     Try
    '         sql = "UPDATE `beneficiarios` SET `Codigo_Beneficiario` = Codigo_Beneficiario" & _
    '               ", `Cuil` = Cuil" & _
    '               ", `ApellidoNombre` = '" & txtApellidoNombre.Text.ToString & _
    '               "', `Sexo` = '" & comboSexo.Text.ToString & _
    '               "', `Calle` = '" & txtCalle.Text.ToString & _
    '               "', `Puerta` = '" & txtPuerta.Text.ToString & _
    '               "', `Piso` = '" & txtPiso.Text.ToString & _
    '               "', `Codigo_Postal` = '" & txtCP.Text.ToString & _
    '               "', `Localidad` = '" & txtLocalidad.Text.ToString & _
    '               "', `Provincia` = '" & txtProvincia.Text.ToString & _
    '               "', `Celular` = '" & txtCelular.Text.ToString & _
    '               "', `Telefono` = '" & txtTelefono.Text.ToString & _
    '               "', `Mail` = '" & txtMail.Text.ToString & _
    '               "' WHERE Codigo_Beneficiario = '" & txtBeneficiario.Text.ToString & "'"
    '         da = New MySqlDataAdapter(sql, Conex)
    '         dt = New DataTable
    '         da.Fill(dt)
    ''         MsgBox("Actualizado en BD!", vbInformation)
    ' 'GridView.DataSource = dt
    '     Catch ex As Exception
    '         MsgBox(ex.Message)
    '     End Try
    'End Sub


    '*********************** update parameters **************************************************************************************************************************************************************************
    Private Sub update_to()
        'Dim vardire As String = "C:\Users\Matias Masciotta\Pictures\urgara.jpeg"
        Using con_insert As New MySqlConnection(CADENABASE2)
            Dim cmdinsert As New MySqlCommand
            With cmdinsert
                .Connection = con_insert
                .CommandType = CommandType.Text
                .CommandText = "UPDATE beneficiarios SET Codigo_Beneficiario=?codben,Cuil=?cuil,ApellidoNombre=?apenom,calle=?calle," & _
                    "puerta=?puerta,piso=?piso,codigo_postal=?codpos,localidad=?localidad,provincia=?provincia,celular=?celular,telefono=?telefono,mail=?mail " & _
                    "WHERE codigo_beneficiario = '" & tempCodigo_Beneficiario.Text & "' and cuil = '" & tempCuil.Text & "' and apellidonombre = '" & tempApellidoNombre.Text & "'"
                'NO GRABA POR QUE ?apenom, o cuil, o codben, cambian y no busca al real.
                'hay que hacer una variable temporal al seleccionar al beneficiario que guarde: TempCODBEN, TempCuil, TempApenom
                .Parameters.AddWithValue("?codben", txtBeneficiario.Text.ToString)
                .Parameters.AddWithValue("?cuil", txtCUIL.Text.ToString)
                .Parameters.AddWithValue("?apenom", txtApellidoNombre.Text.ToString)
                .Parameters.AddWithValue("?calle", txtCalle.Text.ToString)
                .Parameters.AddWithValue("?puerta", txtPuerta.Text.ToString)
                .Parameters.AddWithValue("?piso", txtPiso.Text.ToString)
                .Parameters.AddWithValue("?codpos", txtCP.Text.ToString)
                .Parameters.AddWithValue("?localidad", txtLocalidad.Text.ToString)
                .Parameters.AddWithValue("?provincia", txtProvincia.Text.ToString)
                .Parameters.AddWithValue("?celular", txtCelular.Text.ToString)
                .Parameters.AddWithValue("?telefono", txtTelefono.Text.ToString)
                .Parameters.AddWithValue("?mail", txtMail.Text.ToString)
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
    '**********************************************************************************************************************************************************************************************************

    Private Sub opBuscarDNI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opBuscarDNI.CheckedChanged
        buscarlosdatos()
    End Sub

    Private Sub opBuscarNombre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles opBuscarNombre.CheckedChanged
        buscarlosdatos()
    End Sub


    'Private Sub botonAgregarBeneficiario_Click(sender As Object, e As EventArgs) Handles botonAgregarBeneficiario.Click
    '    MsgBox("Disponible en Version 2.0", vbInformation)
    'End Sub


End Class
