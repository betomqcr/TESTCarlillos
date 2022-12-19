Imports System.IO
Imports NegocioFE

Public Class EnvioComprobantes
    Private Ventas As New DatosFE.Class.Ventas
    Private Devoluciones As New DatosFE.Class.DevolucionesVentas
    Private Mensaje As New DatosFE.Class.MensajeRecepcionHacienda

    Private QR As New OBSoluciones.Utilidades.QR
    Private PDF As New OBSoluciones.Utilidades.PDF
    Public Archivos As New List(Of String)
    Public Event SubirFactura()

    Private WithEvents _xml As New OBSoluciones.ComprobantesElectronicos.GeneraXML_43
    Private clsEmisor As New DatosFE.Models.Emisor
    Private Directorio As String = "C:/Facturas/"
    Private XMLConsecutivo, XMLClave, XMLEmisorNumero, XMLEmisorTipo, XMLReceptorNumero, XMLReceptorTipo As String

    Sub New()
        Dim cls As New DatosFE.Class.Emisores
        '***************************************OJO***************************************
        'WMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMMWMWMWMWMWMWMWMWMWMWM
        'debo solucionar este problema: cuales el id
        Me.clsEmisor = cls.ObtenerEmisores(0)
        '***************************************OJO***************************************
        'WMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMWMMWMWMWMWMWMWMWMWMWMWM
    End Sub

    '**************************************************************************************************
    'Version API
    '**************************************************************************************************
    '   Utilidades
    Public Function getToken(ByRef Token As String) As String
        Try
            'OJO
            'debo tomar en cuenta que hay mas de un emisor
            Dim iTokenHacienda As New TokenHacienda
            iTokenHacienda.GetTokenHacienda(Me.clsEmisor.Usuario, Me.clsEmisor.Clave)
            If iTokenHacienda.AccesoConcedido = True Then
                Token = iTokenHacienda.accessToken
                Return "1"
            Else
                Return "Problemas al Obtener el Token"
            End If
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function

    '**************************************************************************************************
    '   FACTURA Y TIQUETES ELECTRONICOS
    Public Function EnviarFactura(_Id As String) As String
        Dim xml As New OBSoluciones.ComprobantesElectronicos.GeneraXML_43
        Dim resp = xml.XMLFactura(_Id) 'genera el xml firmado y pdf del comprobante electronico
        If resp = "1" Then
            Dim Token As String = ""
            resp = getToken(Token) 'obtenemos el token de hacienda
            If resp = "1" Then
                Dim enviaFactura As New Comunicacion
                If enviaFactura.EnvioDatos(Token, xml.ObjRecepcion) = True Then 'aqui envia el comprobante a la api de hacienda
                    'Guarda el Json del envio
                    Dim DirectorioTemp = xml.RaizXML & "/" & xml.Fac.NumeroConsecutivo & "/"
                    Dim jsonEnvio As String = enviaFactura.jsonEnvio
                    Dim jsonRespuesta As String = enviaFactura.jsonRespuesta
                    Dim outputFile As New IO.StreamWriter(DirectorioTemp & XMLConsecutivo & "_03_jsonEnvio.txt")
                    outputFile.Write(jsonEnvio)
                    outputFile.Close()
                    'Actualizar estados Factura
                    If enviaFactura.estadoFactura = "aceptado" Or enviaFactura.estadoFactura = "rechazado" Then
                        Me.Ventas.EditarEstadoFactura(_Id, "procesando")
                    Else
                        Me.Ventas.EditarEstadoFactura(_Id, enviaFactura.estadoFactura)
                    End If
                Else
                    Return "Problemas al enviar al api de hacienda"
                End If
            Else
                Return resp
            End If
            Return "1"
        Else
            Return resp
        End If
    End Function
    Public Function ActualizarEstadoFactura(_Id As String) As String
        Dim xml As New OBSoluciones.ComprobantesElectronicos.GeneraXML_43
        Dim ClaveMH As String = Me.Ventas.ObtenerClaveFactura(_Id) 'Documentos.Obtener_ClaveFacturaMH(_IdFactura)
        Dim ConsecutivoMh As String = Me.Ventas.ObtenerNumeroConsecutivoFactura(_Id) 'Documentos.Obtener_ConsecutivoFacturaMH(_IdFactura)
        Dim DirectorioTemp As String = xml.RaizXML & "/" & ConsecutivoMh & "/"
        If IO.Directory.Exists(DirectorioTemp) Then IO.Directory.CreateDirectory(DirectorioTemp)

        Dim Token As String = ""
        Dim resp As String = ""
        resp = getToken(Token) 'obtenemos el token de hacienda
        If resp = "1" Then
            Dim enviaFactura As New Comunicacion
            If enviaFactura.ConsultaEstatus(Token, ClaveMH) = True Then 'aqui consultamos el estado del comprobante en la api de hacienda
                'guardamos xml de la respuesta
                If Not IsNothing(enviaFactura.xmlRespuesta) Then
                    enviaFactura.xmlRespuesta.Save(DirectorioTemp & ConsecutivoMh & "_07_RespuestaClave.xml")
                End If
                'Actualizar estados Factura
                Select Case enviaFactura.estadoFactura
                    Case "rechazado"
                        Me.Ventas.EditarEstadoFactura(_Id, enviaFactura.estadoFactura)
                        ' Dim correo As New Correo
                        'Correo.NotificarFacturaRechazada(_IdDocumento, "rolando.obando@gmail.com", enviaFactura.MotiviRechazo)
                    Case Else : Me.Ventas.EditarEstadoFactura(_Id, enviaFactura.estadoFactura)
                End Select
            End If
        End If
    End Function
    Public Function EnviarCorreoFactura(_Id As String) As String
        Dim correo As New Correo
        Return correo.EnviarFactura(_Id)
    End Function
    '**************************************************************************************************
    Public Function EnviarDevolucion(_Id As String) As String
        Me._xml = New OBSoluciones.ComprobantesElectronicos.GeneraXML_43
        Dim resp = Me._xml.XMLDevolucion(_Id)
        If resp = "1" Then
            Dim Token As String = ""
            resp = getToken(Token) 'obtenemos el token de hacienda
            If resp = "1" Then
                Dim enviaFactura As New Comunicacion
                If enviaFactura.EnvioDatos(Token, Me._xml.ObjRecepcion) = True Then
                    'Guarda el Json del envio
                    Dim DirectorioTemp = _xml.RaizXML & "/" & _xml.Dev.Consecutivo & "/"
                    Dim jsonEnvio As String = enviaFactura.jsonEnvio
                    Dim jsonRespuesta As String = enviaFactura.jsonRespuesta
                    Dim outputFile As New IO.StreamWriter(DirectorioTemp & XMLConsecutivo & "_03_jsonEnvio.txt")
                    outputFile.Write(jsonEnvio)
                    outputFile.Close()
                    'Actualizar estados Devolucion
                    Select Case enviaFactura.estadoFactura
                        Case "aceptado" : Me.Devoluciones.EditarEstadoDevolucionVenta(_Id, "procesando", _xml.Dev.Clave, _xml.Dev.Consecutivo)
                        Case "rechazado" : Me.Devoluciones.EditarEstadoDevolucionVenta(_Id, "procesando", _xml.Dev.Clave, _xml.Dev.Consecutivo)
                        Case Else : Me.Devoluciones.EditarEstadoDevolucionVenta(_Id, "procesando", _xml.Dev.Clave, _xml.Dev.Consecutivo)
                    End Select
                End If
            End If
            Return "1"
        Else
            Return resp
        End If
    End Function
    Public Function ActualizarEstadoDevolucion(_Id As String) As String
        Dim xml As New OBSoluciones.ComprobantesElectronicos.GeneraXML_43
        Dim ClaveMH As String = Me.Devoluciones.ObtenerClaveDevolucion(_Id) 'Documentos.Obtener_ClaveFacturaMH(_IdFactura)
        Dim ConsecutivoMh As String = Me.Devoluciones.ObtenerNumeroConsecutivoDevolucion(_Id) 'Documentos.Obtener_ConsecutivoFacturaMH(_IdFactura)
        Dim DirectorioTemp As String = xml.RaizXML & "/" & ConsecutivoMh & "/"
        If IO.Directory.Exists(DirectorioTemp) Then IO.Directory.CreateDirectory(DirectorioTemp)

        Dim Token As String = ""
        Dim resp As String = ""
        resp = getToken(Token) 'obtenemos el token de hacienda
        If resp = "1" Then
            Dim enviaFactura As New Comunicacion
            If enviaFactura.ConsultaEstatus(Token, ClaveMH) = True Then 'aqui consultamos el estado del comprobante en la api de hacienda
                'guardamos xml de la respuesta
                If Not IsNothing(enviaFactura.xmlRespuesta) Then
                    enviaFactura.xmlRespuesta.Save(DirectorioTemp & ConsecutivoMh & "_07_RespuestaClave.xml")
                End If
                'Actualizar estados Factura
                Select Case enviaFactura.estadoFactura
                    Case "rechazado"
                        Me.Devoluciones.EditarEstadoDevolucionVenta(_Id, enviaFactura.estadoFactura)
                        ' Dim correo As New Correo
                        'Correo.NotificarFacturaRechazada(_IdDocumento, "rolando.obando@gmail.com", enviaFactura.MotiviRechazo)
                    Case Else : Me.Devoluciones.EditarEstadoDevolucionVenta(_Id, enviaFactura.estadoFactura)
                End Select
            End If
        End If
    End Function

    '**************************************************************************************************


    Private XMLConsecutivoReceptor As String = ""
    Private Sub ObtenerDatosXML(_xmlSinFirmar As String, Optional ByVal _MensajeReceptor As Boolean = False)
        Try

            Dim xmlEnvia As New Xml.XmlDocument
            xmlEnvia.LoadXml(_xmlSinFirmar)
            Me.XMLConsecutivo = ""
            Me.XMLClave = ""
            Me.XMLEmisorNumero = ""
            Me.XMLEmisorTipo = ""
            Me.XMLReceptorNumero = ""
            Me.XMLReceptorTipo = ""

            If _MensajeReceptor = False Then
                Me.XMLConsecutivo = xmlEnvia.GetElementsByTagName("NumeroConsecutivo")(0).InnerText
                Me.XMLClave = xmlEnvia.GetElementsByTagName("Clave")(0).InnerText
                Me.XMLEmisorNumero = xmlEnvia.GetElementsByTagName("Emisor")(0)("Identificacion")("Numero").InnerText
                Me.XMLEmisorTipo = xmlEnvia.GetElementsByTagName("Emisor")(0)("Identificacion")("Tipo").InnerText
                If xmlEnvia.GetElementsByTagName("Receptor").Count > 0 Then
                    If Not IsNothing(xmlEnvia.GetElementsByTagName("Receptor")(0)("Identificacion")) Then
                        Me.XMLReceptorNumero = xmlEnvia.GetElementsByTagName("Receptor")(0)("Identificacion")("Numero").InnerText
                        Me.XMLReceptorTipo = xmlEnvia.GetElementsByTagName("Receptor")(0)("Identificacion")("Tipo").InnerText
                    End If
                End If
            Else
                Me.XMLConsecutivo = xmlEnvia.GetElementsByTagName("NumeroConsecutivoReceptor")(0).InnerText
                Me.XMLClave = xmlEnvia.GetElementsByTagName("Clave")(0).InnerText
                Me.XMLEmisorNumero = xmlEnvia.GetElementsByTagName("NumeroCedulaEmisor")(0).InnerText
                Me.XMLConsecutivoReceptor = xmlEnvia.GetElementsByTagName("NumeroConsecutivoReceptor")(0).InnerText
                Select Case Len(Me.XMLEmisorNumero)
                    Case 9 : Me.XMLEmisorTipo = "01" 'FICICA
                    Case 10 : Me.XMLEmisorTipo = "02" 'JURIDICA
                    Case 11 : Me.XMLEmisorTipo = "03" 'DIMEX
                    Case 12 : Me.XMLEmisorTipo = "03" 'DIMEX
                End Select

                Me.XMLReceptorNumero = xmlEnvia.GetElementsByTagName("NumeroCedulaReceptor")(0).InnerText
                Select Case Len(Me.XMLReceptorNumero)
                    Case 9 : Me.XMLReceptorTipo = "01" 'FICICA
                    Case 10 : Me.XMLReceptorTipo = "02" 'JURIDICA
                    Case 11 : Me.XMLReceptorTipo = "03" 'DIMEX
                    Case 12 : Me.XMLReceptorTipo = "03" 'DIMEX
                End Select
            End If

        Catch ex As Exception
        End Try
    End Sub

    Public Sub GeneraPDFVenta(_IdFactura As String)
        Dim Fe As New DatosFE.Models.ObtenerFacturas43
        Dim FeDet As New List(Of DatosFE.Models.ObtenerDetalleFactura43)

        Dim cls As New DatosFE.Class.Vistas
        Fe = cls.ObtenerFacturas43(_IdFactura).FirstOrDefault()
        FeDet = cls.ObtenerDetalleFacturas43(_IdFactura)

        Me.PDF.Autor = "OBSoluciones"
        Me.PDF.Titulo = "Comprobantes Electronicos"
        Me.PDF.CrearFactura(Fe.Clave, Fe, FeDet)
    End Sub

    Public Sub GeneraPDFDevolucion(_IdFactura As String)
        Dim Dev As New DatosFE.Models.ObtenerDevolucion43
        Dim DevDet As New List(Of DatosFE.Models.ObtenerDetallesDevolucion43)

        Dim cls As New DatosFE.Class.Vistas
        Dev = cls.ObtenerDevolucionVenta43(_IdFactura).FirstOrDefault()
        DevDet = cls.ObtenerDetalleDevolucionVenta43(_IdFactura)

        Me.PDF.Autor = "OBSoluciones"
        Me.PDF.Titulo = "Comprobantes Electronicos"
        Me.PDF.CrearNotaCredito(Dev.Clave, Dev, DevDet)
    End Sub

    Public Function EnviarMensajeReceptor(_Id As String) As String
        Return Me._xml.XMLMensajeReceptor(_Id)
    End Function

    Private Function ObtenerCorreo(_IdRecibo As String) As String
        Dim Correo As String = ""
        Dim dt As New Data.DataTable
        'dt = General.sql.Ejecutar("select c.CorreoRecibo As Correo from " & General.BasedeDatos & ".dbo.abonoccobrar a inner join " & General.BasedeDatos & ".dbo.Clientes c on c.identificacion = a.Cod_Cliente where a.Id_Recibo = " & _IdRecibo, CommandType.Text)
        If dt.Rows.Count > 0 Then
            Correo = dt.Rows(0).Item("Correo")
        Else
            Correo = "rolando.obando@gmail.com"
        End If
        Return Correo
    End Function

    Private Function ObtenerRecibo(_IdRecibo As String) As String
        Dim Correo As String = ""
        Dim dt As New Data.DataTable
        'dt = General.sql.Ejecutar("select a.Num_Recibo As Correo from " & General.BasedeDatos & ".dbo.abonoccobrar a where a.Id_Recibo = " & _IdRecibo, CommandType.Text)
        If dt.Rows.Count > 0 Then
            Correo = dt.Rows(0).Item("Correo")
        Else
            Correo = "0"
        End If
        Return Correo
    End Function

    Private ProcesandoIdRecibo As Boolean = False

    Private Sub Escribir(_Texto As String)
        Try
            Dim ruta As String = "c:\logErrorReciboCxC.txt"
            Dim escritor As StreamWriter
            escritor = File.AppendText(ruta)
            escritor.Write(_Texto)
            escritor.Flush()
            escritor.Close()
        Catch ex As Exception
        End Try
    End Sub

    Public Sub ActualizarEstadoMensaje(_IdMensaje As Integer)
        Dim cls As New DatosFE.Class.Vistas
        Dim msg As New DatosFE.Models.GetMensajeXId
        Dim estado As String = ""

        msg = cls.GetMensajePorId(_IdMensaje).FirstOrDefault()

        estado = msg.Estado 'dt.Rows(0).Item("ESTADO")
        Me.XMLClave = msg.Clave 'dt.Rows(0).Item("CLAVE")
        Me.XMLConsecutivo = msg.Consecutivo 'dt.Rows(0).Item("CONSECUTIVO")
        Dim DirecionTemp As String = "C:/Compras/" & Me.XMLConsecutivo & "/"

        If estado = "pendiente" Then
            Me.EnviarMensajeReceptor(_IdMensaje)
        End If

        If estado = "procesando" Or estado = "recibido" Or estado = "" Then
            If IO.Directory.Exists(DirecionTemp) = False Then IO.Directory.CreateDirectory(DirecionTemp)
            Dim Token As String = ""
            getToken(Token)
            If Token <> "" Then
                Dim enviaComprobante As New Comunicacion
                If enviaComprobante.ConsultaEstatus(Token, Me.XMLClave) = True Then
                    Dim jsonEnvio As String = enviaComprobante.jsonEnvio
                    Dim jsonRespuesta As String = enviaComprobante.jsonRespuesta
                    Dim outputFile As New IO.StreamWriter(DirecionTemp & XMLConsecutivo & "_03_jsonEnvio.txt")
                    outputFile.Write(jsonEnvio)
                    outputFile.Close()
                    'Guarda el Json de la respuesta
                    outputFile = New IO.StreamWriter(DirecionTemp & XMLConsecutivo & "_04_jsonRespuesta.txt")
                    outputFile.Write(jsonRespuesta)
                    outputFile.Close()
                    'Guarda respuesta
                    If Not IsNothing(enviaComprobante.xmlRespuesta) Then
                        enviaComprobante.xmlRespuesta.Save(DirecionTemp & XMLConsecutivo & "_05_RESP.xml")
                    Else
                        outputFile = New IO.StreamWriter(DirecionTemp & XMLConsecutivo & "_05_RESP_SinRespuesta.txt")
                        outputFile.Write("")
                        outputFile.Close()
                    End If

                    jsonRespuesta = enviaComprobante.jsonRespuesta
                    outputFile = New IO.StreamWriter(DirecionTemp & XMLConsecutivo & "_06_jsonRespuestaClave.txt")
                    outputFile.Write(jsonRespuesta)
                    outputFile.Close()
                    If Not IsNothing(enviaComprobante.xmlRespuesta) Then
                        enviaComprobante.xmlRespuesta.Save(DirecionTemp & XMLConsecutivo & "_07_RespuestaClave.xml")
                    End If

                    Me.Mensaje.EditarEstadoMensajeReceptor(_IdMensaje, enviaComprobante.estadoFactura)
                End If
            End If
        End If

    End Sub

    Private Sub xml_setDifMontos(_IdFactura As String) Handles _xml.setDifMontos
        ' Me.Documentos.RegistrarEstadoFactura(_IdFactura, Me.XMLClave, Me.XMLConsecutivo, "-PROCESANDO-")
    End Sub

End Class
