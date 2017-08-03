Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Security.Cryptography
Public Class ABMUsuarios
    Dim Conex As New MySqlConnection("data source=localhost;user id=root; password='root'; database=dbsocial")
    Dim da As MySqlDataAdapter
    Dim dt As DataTable
    Dim ds As DataSet
    Dim sql As String
    Dim comando As MySqlCommand
    Dim varControlPass As Boolean = False
    '************

    Dim sql2 As String

    Dim cm2 As MySqlCommand
    Dim da2 As MySqlDataAdapter
    Dim ds2 As DataSet

    '********

    Private Sub GridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridView.CellContentClick

    End Sub

    Private Sub ABMUsuarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'carga grid usuarios
        cargaUsuarios()
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

        'carga grid usuarios_reintegros
        Try
            sql = "SELECT tipo_usuario,detalle from tipo_usuario"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            DataGridRol.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botonSalir.Click
        Me.Close()
    End Sub

    Private Sub BotonNuevoUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        prendeDatos()
    End Sub

    'Prende los Datos de nuevo USUARIO
    Private Sub prendeDatos()
        PictureBox1.Visible = True
        lbldni.Visible = True
        lblapenom.Visible = True
        lblrol.Visible = True
        lblgridrol.Visible = True
        lblgridsec.Visible = True
        lblpass.Visible = True
        lblpass2.Visible = True
        lblsecc.Visible = True
        GroupBox1.Visible = True
        DataGridSeccionales.Visible = True
        DataGridRol.Visible = True
        txtID.Visible = True
        txtApellidoNombre.Visible = True
        txtPass.Visible = True
        txtPass2.Visible = True
        comboROL.Visible = True
        comboSeccional.Visible = True
        botonConfirmaUser.Visible = True

    End Sub

    Private Sub apagaDatos()
        PictureBox1.Visible = False
        lbldni.Visible = False
        lblapenom.Visible = False
        lblrol.Visible = False
        lblgridrol.Visible = False
        lblgridsec.Visible = False
        lblpass.Visible = False
        lblpass2.Visible = False
        lblsecc.Visible = False
        GroupBox1.Visible = False
        DataGridSeccionales.Visible = False
        DataGridRol.Visible = False
        GroupBox1.Visible = False
        txtID.Visible = False
        txtApellidoNombre.Visible = False
        txtPass.Visible = False
        txtPass2.Visible = False
        comboROL.Visible = False
        comboSeccional.Visible = False
        botonConfirmaUser.Visible = False
    End Sub






    'metodo Carga SECCIONALES a combo
    'Private Sub cargaComboSeccionales()
    '    Dim sec As Array
    '  End Sub

    ' Private Sub cargaComboTipoDeUsuarios()
    'End Sub

    'Click en Grid --> llena Combobox Seccionales
    Private Sub DataGridSeccionales_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridSeccionales.CellContentClick
        Try
            comboSeccional.Text = Me.DataGridSeccionales.Rows(e.RowIndex).Cells(0).Value
        Catch
        End Try
    End Sub
    Private Sub DataGridSeccionales_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridSeccionales.CellClick
        comboSeccional.Text = Me.DataGridSeccionales.Rows(e.RowIndex).Cells(0).Value
    End Sub



    'Click en Grid --> llena ComboBox TIPO USUARIO
    Private Sub DataGridTiposUsuarios_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridRol.CellContentClick
        Try
            comboROL.Text = Me.DataGridRol.Rows(e.RowIndex).Cells(0).Value
        Catch
        End Try
    End Sub
    Private Sub DataGridRol_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridRol.CellClick
        comboROL.Text = Me.DataGridRol.Rows(e.RowIndex).Cells(0).Value
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botonConfirmaUser.Click
        agregarUser()
    End Sub

    Private Sub botonAgregarBeneficiario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botonAgregaUsuario.Click
        prendeDatos()
    End Sub

    'definicion metodo agregar user
    Private Sub agregarUser()
        'boton confirmar user
        ' no funciona
        Dim existe As Boolean = (Me.GridView.Rows.Cast(Of DataGridViewRow).Any(Function(x) CStr(x.Cells("Codigo_Usuario").Value) = "00-" & txtID.Text & "-0"))
        Dim cont As Integer = 0
        If Not existe Then
            'lo agrega
            If (Trim(txtID.Text) = "") Or (Trim(txtApellidoNombre.Text) = "") Or (Trim(txtPass.Text) = "") Or (Trim(txtPass.Text) = "") Or (Trim(comboSeccional.Text) = "") Or (Trim(comboROL.Text) = "") Then
                MsgBox("Por favor Complete todos los datos de la Operacion", vbExclamation, "Faltan Datos")
            Else
                Try
                    If varControlPass = True Then
                        MsgBox("Generando Nuevo Usuario..", vbInformation)
                        'encripto el valor del TEXT PASS
                        Call MD5EncryptPass(txtPass.Text)
                        'fin md5
                        sql = "INSERT INTO `Usuarios_Reintegros` " & _
                              "(`Codigo_Usuario`," & _
                              "`Constraseña`," & _
                              "`ApellidoNombre`, " & _
                              "`Tipo_Usuario`, " & _
                              "`Codigo_Seccional`, " & _
                              "`FechaAlta`) " & _
                              " VALUES (" & _
                              "'00-" & txtID.Text.ToString & "-0','" & txtPass.Text.ToString & "','" & txtApellidoNombre.Text.ToString & "','" & Int(comboROL.Text) & "'," & Int(comboSeccional.Text) & ",'" & (DateTime.Now.Year & "-" & DateTime.Now.Month & "-" & DateTime.Now.Day) & "')"
                        da = New MySqlDataAdapter(sql, Conex)
                        dt = New DataTable
                        da.Fill(dt)
                        MsgBox("Solicitud Generada con exito!", vbInformation)
                        limpiarTextBox()
                        PictureBox1.Visible = False
                        cargaUsuarios()
                        'GridView.DataSource = dt

                    Else
                        MsgBox("Las Pass no coinciden.", vbExclamation)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If
            apagaDatos()
            GridView.Refresh()
        Else
            MsgBox("Repetido!", vbExclamation)
            limpiarTextBox()
            txtID.Focus()
        End If
    End Sub
    Private Sub limpiarTextBox()
        txtID.Text = ""
        txtApellidoNombre.Text = ""
        txtPass.Text = ""
        txtPass2.Text = ""
        comboROL.Text = ""
        comboSeccional.Text = ""

    End Sub


    'CONTROLA LAS 2 PASS
    Private Sub txtPass2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPass2.TextChanged
        Dim i As Integer
        For i = 0 To txtPass.TextLength
            If i = txtPass.TextLength Then
                If txtPass.Text = txtPass2.Text Then
                    'pass correcta
                    PictureBox1.Image = WindowsApplication1.My.Resources.Resources.descarga
                    varControlPass = True
                Else
                    'pass incorrecta
                    PictureBox1.Image = WindowsApplication1.My.Resources.Resources.images
                    varControlPass = False
                End If
            End If
        Next
    End Sub

    Private Sub txtPass_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPass.TextChanged
        'PictureBox1.Image = WindowsApplication1.My.Resources.Resources.images
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

    Private Sub cargaUsuarios()
        Try
            sql = "SELECT USUARIOS_REINTEGROS.CODIGO_USUARIO,CONSTRASEÑA,USUARIOS_REINTEGROS.APELLIDONOMBRE,USUARIOS_REINTEGROS.CODIGO_SECCIONAL,SECCIONALES.DESCRIPCION,USUARIOS_REINTEGROS.TIPO_USUARIO FROM USUARIOS_REINTEGROS,SECCIONALES WHERE (/*ID-ID*/USUARIOS_REINTEGROS.CODIGO_SECCIONAL = SECCIONALES.CODIGO)"
            da = New MySqlDataAdapter(sql, Conex)
            dt = New DataTable
            da.Fill(dt)
            GridView.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class



