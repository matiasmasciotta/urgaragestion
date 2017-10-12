Imports System.Net
Imports System.Net.Mail

Module Correo

    Private correos As New MailMessage
    Private envios As New SmtpClient

    Sub enviarCorreo(ByVal emisor As String, ByVal password As String, ByVal mensaje As String, ByVal asunto As String, ByVal destinatario As String)
        Try
            correos.To.Clear()
            correos.Attachments.Clear()
            correos.Body = ""
            correos.Subject = ""
            correos.Body = mensaje
            correos.Subject = asunto
            correos.IsBodyHtml = True
            correos.To.Add(Trim(destinatario))
            '
            Dim i As Integer = 0
            Dim adjuntos As System.Collections.ArrayList
            adjuntos = New System.Collections.ArrayList()

            'borraria lo que queda en memoria..
            For i = 0 To adjuntos.Count - 1
                adjuntos.RemoveAt(i)
            Next
            For i = 0 To NuevoReintegro.clbimagen.Items.Count - 1
                correos.Attachments.Clear()
                adjuntos.Add(New Attachment(NuevoReintegro.clbStrings.Items(i).ToString()))
            Next
            If NuevoReintegro.clbimagen.Items.Count > 0 Then
                correos.Attachments.Clear()
                Dim j As Integer
                For j = 0 To NuevoReintegro.clbimagen.Items.Count - 1
                    correos.Attachments.Add(CType(adjuntos.Item(j), Attachment))
                Next
            End If
            correos.From = New MailAddress(emisor)
            envios.Credentials = New NetworkCredential(emisor, password)

            'Datos importantes no modificables para tener acceso a las cuentas
            envios.Host = "smtp.gmail.com"
            envios.Port = 587
            envios.EnableSsl = True
            envios.Send(correos)
            MsgBox("Email Enviado.. ", MsgBoxStyle.Information, "Mensaje")

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Mensajeria 1.0 vb.net ®", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Module
