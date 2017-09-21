Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Security.Cryptography

'juan pedro 13800267
'Clave0267

Public Class Login

    Dim Conex As New MySqlConnection(CADENABASE2)
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim sql As String
    Dim comando As MySqlCommand


    Private Sub BotonAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonAceptar.Click
        If (Trim(txtUser.Text) = "") Or (Trim(txtPass.Text) = "") Then
            MsgBox("Por Favor Complete todos los campos.", vbExclamation)
        Else
            'Call MD5EncryptPass(TempPass.Text)
            buscarUsuario()
        End If
    End Sub

    'METODO BUSCA SI EXISTE USER EN GRID
    Private Sub buscarUsuario()
        Try
            'ENCRIPTO AL TxtPass a MD5
            Call MD5EncryptPass(txtPass.Text)
            Dim variableUsuario As String = ""
            Dim variablePass As String = ""
            Dim variableTipoUsuario As Integer = -1
            variableUsuario = "00-" & Me.txtUser.Text & "-0"
            variablePass = Me.txtPass.Text
            'Controla si los TEXTBOX coinciden con las columnas correspondientes
            Dim existe As Boolean = (Me.GridView.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("Codigo_Usuario").Value) = variableUsuario)) And (Me.GridView.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("Constraseña").Value) = variablePass))
            Dim cont As Integer = 0
            If Not existe Then
                MsgBox("Datos Inexistentes, Verifique por favor", vbExclamation)
                txtPass.Text = ""
                txtUser.Focus()
                cont = cont + 1
                If (cont > 3) Then
                    MsgBox("Maximo de intentos permitidos, Intentelo nuevamente", vbExclamation)
                    cont = 0
                    Me.Close()
                End If
            Else
                'MsgBox("Ingreso!", vbInformation)
                'Si el usuario es correcto busca los datos de ROL de usuario para darle privilegios
               
                Dim SQL2 As String
                Dim MiConexion2 As New MySqlConnection(CADENABASE2)
                Dim Rs2 As MySqlDataReader
                Dim Com2 As New MySqlCommand
                Com2.Connection = MiConexion2
                MiConexion2.Open()
                SQL2 = "select tipo_usuario,codigo_seccional from usuarios_reintegros where codigo_usuario = '00-" & txtUser.Text.ToString & "-0'"
                VariableGlobalUsuario = "00-" & txtUser.Text.ToString & "-0"
                Com2 = New MySqlCommand(SQL2, MiConexion2)
                Rs2 = Com2.ExecuteReader()
                Rs2.Read()
                txtTipoUsuario.Text = Rs2(0) 'aca me pone el primer campo del select 
                VariableGlobalSeccional = Rs2(1)
                Rs2.Close()

                'Le doy privilegio de usuario
                '--> es User
                If txtTipoUsuario.Text = 0 Then
                    MenuPrincipal.ExaminarBeneficiariosToolStripMenuItem.Enabled = True
                    MenuPrincipal.ExaminarSolicitudDeReintegroToolStripMenuItem.Enabled = True
                    MenuPrincipal.GenerarSolicitudDeReintegroToolStripMenuItem.Enabled = True
                End If
                '--> es Admin
                If txtTipoUsuario.Text = 1 Then
                    MenuPrincipal.ExaminarBeneficiariosToolStripMenuItem.Enabled = True
                    MenuPrincipal.ExaminarSolicitudDeReintegroToolStripMenuItem.Enabled = True
                    MenuPrincipal.GenerarSolicitudDeReintegroToolStripMenuItem.Enabled = True
                    MenuPrincipal.ConsultarReintegrosPendientesToolStripMenuItem.Enabled = True
                    MenuPrincipal.UsersSoloAdminToolStripMenuItem.Visible = True
                    MenuPrincipal.ExaminarTodasLasSolicitudesSoloAdminToolStripMenuItem.Visible = True
                    MenuPrincipal.ConsultaAuditorMedicoToolStripMenuItem.Enabled = True
                End If
                '--> es Pagador
                If txtTipoUsuario.Text = 2 Then
                    'MenuPrincipal.ConsultarReintegrosPendientesToolStripMenuItem.Enabled = True
                    MenuPrincipal.GenerarPagoDeReintegroOSubsidioToolStripMenuItem.Enabled = True
                End If
                '--> es Auditor
                If txtTipoUsuario.Text = 3 Then
                    MenuPrincipal.ConsultarReintegrosPendientesToolStripMenuItem.Enabled = True
                    MenuPrincipal.ConsultaAuditorMedicoToolStripMenuItem.Enabled = True
                End If
                '--> es Otro
                If txtTipoUsuario.Text = 4 Then
                    'nada aún
                End If

                '*****************************************************************************************************
                BotonAceptar.Enabled = False
                BotonCancelar.Enabled = False
                txtUser.Enabled = False
                txtPass.Enabled = False
                Timer1.Start()
                MenuPrincipal.lblUser.Text = "Ingreso - " & DateTime.Now.Date
                MenuPrincipal.PictureBox1.Image = WindowsApplication1.My.Resources.Resources.mejoico2
                MenuPrincipal.lblUser.ForeColor = Color.Green
                MenuPrincipal.IngresarAlSistemaToolStripMenuItem.Text = "Salir para Cerrar Sesion"
                MenuPrincipal.IngresarAlSistemaToolStripMenuItem.Enabled = False
                'Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    'Funcion de encriptado ********************************************************************************************
    Private Sub MD5EncryptPass(ByVal StrPass As String)
        Dim md5 As New MD5CryptoServiceProvider
        Dim bytValue() As Byte
        Dim bytHash() As Byte
        Dim i As Integer
        txtPass.Text = ""
        bytValue = System.Text.Encoding.UTF8.GetBytes(StrPass)

        bytHash = md5.ComputeHash(bytValue)
        md5.Clear()

        For i = 0 To bytHash.Length - 1
            txtPass.Text &= bytHash(i).ToString("x").PadLeft(2, "0")
        Next
    End Sub

    Private Sub Login_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        txtUser.Focus()
    End Sub
    '*************************************************************************************************************************
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.TopMost = True
        Try
            sql = "select Codigo_Usuario,Constraseña,ApellidoNombre,Tipo_Usuario,Codigo_Seccional from usuarios_reintegros"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txtUser.Focus()
    End Sub

    Private Sub BotonCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BotonCancelar.Click
        Me.Close()
    End Sub

    'PROGRESSBARR timer
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value < 100 Then
            ProgressBar1.Value += 10
        Else
            Me.Close()
        End If
    End Sub

    Private Sub txtUser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUser.TextChanged

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub
End Class