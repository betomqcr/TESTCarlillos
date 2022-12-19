Imports System.Net.Mail

Public Class Correo

    Public Archivos As New List(Of String)
    Private Directorio As String
    Private Correo As String = ""
    Private Clave As String = ""

    Sub New()
        Dim _correo As String = ""
        Dim _clave As String = ""

        Try
            _correo = GetSetting("SeeSOFT", "Seguridad", "CorreoFE")
            _clave = GetSetting("SeeSOFT", "Seguridad", "ClaveFE")

            If _correo = "" Or _clave = "" Then
                SaveSetting("SeeSOFT", "Seguridad", "CorreoFE", "facturaelectronica@suvesacr.com")
                SaveSetting("SeeSOFT", "Seguridad", "ClaveFE", "fac2018")

                _correo = GetSetting("SeeSOFT", "Seguridad", "CorreoFE")
                _clave = GetSetting("SeeSOFT", "Seguridad", "ClaveFE")
            End If

            Me.Correo = _correo
            Me.Clave = _clave
        Catch ex As Exception
            SaveSetting("SeeSOFT", "Seguridad", "CorreoFE", "facturaelectronica@suvesacr.com")
            SaveSetting("SeeSOFT", "Seguridad", "ClaveFE", "fac2018")

            _correo = GetSetting("SeeSOFT", "Seguridad", "CorreoFE")
            _clave = GetSetting("SeeSOFT", "Seguridad", "ClaveFE")

            Me.Correo = _correo
            Me.Clave = _clave
        End Try
    End Sub

    Private Function GetEmisor() As String
        Dim cls As New DatosFE.Class.Emisores
        Dim emisor As New DatosFE.Models.Emisor
        '***************************************OJO***************************************
        'WMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMMWMWMWMWMWMWMWMWMWMWM
        emisor = cls.ObtenerEmisores(0)
        '***************************************OJO***************************************
        'WMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMMWMWMWMWMWMWMWMWMWMWM
        Return emisor.Nombre
    End Function

    Public Function NotificarFacturaRechazada(_IdFactura As String, _Correo As String, _Observaciones As String) As String
        Try
            Dim xml As New OBSoluciones.ComprobantesElectronicos.GeneraXML_43
            Dim cls As New DatosFE.Class.Vistas
            Dim v As DatosFE.Models.ObtenerFacturas43
            v = cls.ObtenerFacturas43(_IdFactura).FirstOrDefault()
            Dim Tipo As String = v.Consecutivo.Substring(8, 2)
            If Tipo = "01" Then '01. Factura Electrónica
                Dim Correos() As String = _Correo.Split(";")
                For Each mail As String In Correos
                    If mail.Contains("@") = True Then
                        Me.Directorio = xml.RaizXML & "/" & v.NumeroConsecutivo & "/"
                        Archivos.Clear()
                        Archivos.Add(Me.Directorio & v.NumeroConsecutivo & "_02_Firmado.xml")
                        Archivos.Add(Me.Directorio & v.NumeroConsecutivo & "_07_RespuestaClave.xml")
                        Archivos.Add(Me.Directorio & v.Clave & ".pdf")
                        Dim Asunto As String = "Factura Rechazada del Emisor: " & Me.GetEmisor
                        Dim Cuerpo As String = _Observaciones
                        Me.Enviar_Correo_Adjunto(mail, Asunto, Cuerpo, Me.Archivos, "Factura Electronica", v.Clave, v.NumeroConsecutivo)
                    End If
                Next
            Else
                Return "" '04. Tiquete Electrónico
            End If
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Function EnviarFactura(_IdFactura As String) As String
        Try
            Dim xml As New OBSoluciones.ComprobantesElectronicos.GeneraXML_43
            Dim cls As New DatosFE.Class.Vistas
            Dim v As DatosFE.Models.ObtenerFacturas43
            v = cls.ObtenerFacturas43(_IdFactura).FirstOrDefault()
            Dim Tipo As String = v.Consecutivo.Substring(8, 2)
            If Tipo = "01" Then '01. Factura Electrónica
                Dim Correos() As String = v.CorreoElectronicoReceptor.Split(";")
                For Each mail As String In Correos
                    If mail.Contains("@") = True Then
                        Me.Directorio = xml.RaizXML & "/" & v.NumeroConsecutivo & "/"
                        Archivos.Clear()
                        Archivos.Add(Me.Directorio & v.NumeroConsecutivo & "_02_Firmado.xml")
                        Archivos.Add(Me.Directorio & v.NumeroConsecutivo & "_07_RespuestaClave.xml")
                        Archivos.Add(Me.Directorio & v.Clave & ".pdf")
                        Dim Asunto As String = "Factura Electrónica N°" & v.NumeroConsecutivo & " del Emisor: " & Me.GetEmisor
                        Dim Cuerpo As String = "Factura Electrónica N°" & v.NumeroConsecutivo
                        If v.NumeroReceptor = "4000042139" Then 'Las pegas del ice
                            Asunto = "Comprobante MM-" & v.OrdenCompra.Replace("MM-", "")
                            Cuerpo = "Se adjunta la referencia MM-" & v.OrdenCompra.Replace("MM-", "")
                            If Tipo = "CON" Or Tipo = "MCO" Or Tipo = "TCO" Then
                                mail = "facturasft@ice.go.cr" 'correo para las ventas de contado
                            ElseIf Tipo = "CRE" Or Tipo = "MCR" Or Tipo = "TCR" Then
                                mail = "facturasice@ice.go.cr" 'correo para las ventas de credito
                            End If
                            Me.Enviar_Correo_Adjunto(mail, Asunto, Cuerpo, Me.Archivos, "Factura Electronica", v.Clave, v.NumeroConsecutivo)
                        Else
                            Me.Enviar_Correo_Adjunto(mail, Asunto, Cuerpo, Me.Archivos, "Factura Electronica", v.Clave, v.NumeroConsecutivo)
                        End If
                    End If
                Next
                Return "1"
            Else
                Return "Los tiquetes no se envian por correoh" '04. Tiquete Electrónico
            End If
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    Public Sub EnviarNotaCredito(_IdFactura As String)
        Dim dt As New Data.DataTable
        Dim Correo, Consecutivo, Clave As String

        'dt = General.sql.Ejecutar("select dv.CONSECUTIVODGT as ConsecutivoMH, dv.CLAVEDGT as ClaveMH, ISNULL(c.CorreoComprobante,'') as CorreoComprobante from " & General.BasedeDatos & ".dbo.devoluciones_ventas dv inner join " & General.BasedeDatos & ".dbo.Ventas v on dv.Id_Factura = v.Id left join " & General.BasedeDatos & ".dbo.Clientes c on v.Cod_Cliente = c.identificacion where dv.Devolucion =  " & _IdFactura, CommandType.Text)

        If dt.Rows.Count > 0 Then
            Correo = dt.Rows(0).Item("CorreoComprobante")
            Consecutivo = dt.Rows(0).Item("ConsecutivoMH")
            Clave = dt.Rows(0).Item("ClaveMH")

            Dim Correos() As String = Correo.Split(";")

            For Each mail As String In Correos

                If mail.Contains("@") = True Then
                    Me.Directorio = "C:/Facturas/" & Consecutivo & "/"

                    Archivos.Clear()
                    Archivos.Add(Me.Directorio & Consecutivo & "_02_Firmado.xml")
                    Archivos.Add(Me.Directorio & Consecutivo & "_07_RespuestaClave.xml")
                    Archivos.Add(Me.Directorio & Clave & ".pdf")

                    Dim Asunto As String = "Nota Credito N°" & Consecutivo & " del Emisor: " & Me.GetEmisor
                    Dim Cuerpo As String = "Nota Credito N°" & Consecutivo

                    Me.Enviar_Correo_Adjunto(mail, Asunto, Cuerpo, Me.Archivos, "Nota de Credito", Clave, Consecutivo)
                Else
                    'Me.Bitacora = New BitacoraCorreo(Clave, Consecutivo, "Nota de Credito", "Correo Invalido", mail, "Correo no paso validacion")
                    'Me.Bitacora.Guardar()
                End If

            Next

        End If

    End Sub

    Private Sub Enviar_Correo_Adjunto(_CorreoPara As String, _Asunto As String, _Cuerpo As String, _Adjuntos As List(Of String), _Tipo As String, _Clave As String, _Consecutivo As String)
        Dim _Message As New System.Net.Mail.MailMessage()
        Dim _SMTP As New System.Net.Mail.SmtpClient
        _SMTP.Credentials = New System.Net.NetworkCredential(Me.Correo, Me.Clave)

        If Me.Correo.IndexOf("@gmail.com") > 0 Then
            _SMTP.Host = "smtp.gmail.com"
            _SMTP.Port = "587"
            _SMTP.EnableSsl = True
        End If

        If Me.Correo.IndexOf("@suvesacr.com") > 0 Then
            _SMTP.Host = "smtp.hosting24.com"
            _SMTP.Port = "587"
            _SMTP.EnableSsl = True
        End If

        ' CONFIGURACION_DEL_MENSAJE()
        _Message.[To].Add(_CorreoPara) 'Cuenta de Correo al que se le quiere enviar el e-mail
        _Message.From = New System.Net.Mail.MailAddress(Me.Correo, Me.Correo, System.Text.Encoding.UTF8) 'Quien lo envía
        _Message.Subject = _Asunto 'Sujeto del e-mail
        _Message.SubjectEncoding = System.Text.Encoding.UTF8 'Codificacion
        _Message.Body = _Cuerpo 'contenido del mail
        _Message.BodyEncoding = System.Text.Encoding.UTF8
        _Message.Priority = System.Net.Mail.MailPriority.Normal
        _Message.IsBodyHtml = False
        For Each adj As String In _Adjuntos
            If IO.File.Exists(adj) Then
                Dim adjunto = New System.Net.Mail.Attachment(adj) 'txtUbicacion.Text + "\" + txtNombreArchivo.Text)
                _Message.Attachments.Add(adjunto)
            End If
        Next
        _Message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
        'ENVIO()
        Try
            _SMTP.Send(_Message)
        Catch ex As System.Net.Mail.SmtpException
        End Try
        _Message = Nothing
        _SMTP = Nothing
    End Sub

End Class
