Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.Data

Namespace OBSoluciones

    Namespace Utilidades

        Public Class PDF

            Private doc As Document
            Private writer As PdfWriter
            Private vAutor As String
            Private vTitulo As String
            Private tbl As PdfPTable
            Private cl As PdfPCell

            Public Property Autor As String
                Get
                    Return Me.vAutor
                End Get
                Set(value As String)
                    Me.vAutor = value
                End Set
            End Property

            Public Property Titulo As String
                Get
                    Return Me.vTitulo
                End Get
                Set(value As String)
                    Me.vTitulo = value
                End Set
            End Property

            Public Sub CrearDocumento(_Archivo As String)
                Me.doc = New Document(PageSize.A4)
                writer = PdfWriter.GetInstance(doc, New FileStream(_Archivo, FileMode.Create))
                doc.AddTitle(Me.vTitulo)
                doc.AddAuthor(Me.vAutor)
                doc.Open()
            End Sub

            Public Sub Terminar_Documento()
                doc.Close()
                writer.Close()
            End Sub

            Public Sub EscribirTexto(_Texto As String, _Alineado As Integer, Optional ByVal _Tamanyo As Single = 10)
                Dim parrafo As New Paragraph(_Texto)
                parrafo.Font = FontFactory.GetFont("Arial", _Tamanyo)
                parrafo.Alignment = _Alineado
                doc.Add(parrafo)
            End Sub

            Public Sub Agregar_Imagen(_Archivo)
                If File.Exists(_Archivo) = True Then
                    Dim imagen As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(_Archivo)
                    imagen.BorderWidth = 0
                    imagen.ScalePercent(40.0F)
                    imagen.Alignment = Element.ALIGN_RIGHT
                    doc.Add(imagen)
                End If
            End Sub

            Public Sub Crear_Tabla(_Columns As Integer, _tamanio() As Single, Optional ByVal _Porcentaje As Single = 100, Optional ByVal _Aligment As Single = Element.ALIGN_LEFT)
                Me.tbl = New PdfPTable(_Columns)
                tbl.WidthPercentage = _Porcentaje
                tbl.HorizontalAlignment = _Aligment
                tbl.SetWidths(_tamanio)
            End Sub

            Public Sub Crear_Tabla(_Columns As Integer, Optional ByVal _Porcentaje As Single = 100, Optional ByVal _Aligment As Single = Element.ALIGN_LEFT)
                Me.tbl = New PdfPTable(_Columns)
                tbl.WidthPercentage = _Porcentaje
                tbl.HorizontalAlignment = _Aligment
            End Sub

            Public Sub Termina_Tabla()
                doc.Add(tbl)
            End Sub

            Public Sub Agregar_Celda(_Descripcion As String, ByVal _Alineado As Single, Optional ByVal _Borde As Single = 0, Optional ByVal _Tamanyo As Single = 10)
                Dim parrafo As New Paragraph(_Descripcion)
                parrafo.Font = FontFactory.GetFont("Arial", _Tamanyo)
                parrafo.Alignment = _Alineado
                cl = New PdfPCell()
                cl.AddElement(parrafo)
                cl.BorderWidth = 0
                cl.BorderWidthBottom = _Borde
                tbl.AddCell(cl)
            End Sub

            Public Function GetImagen(_Direccion As String) As iTextSharp.text.Image
                If File.Exists(_Direccion) = True Then
                    Dim imagen As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(_Direccion)
                    imagen.BorderWidth = 0
                    imagen.ScalePercent(40.0F)
                    imagen.Alignment = Element.ALIGN_CENTER
                    Return imagen
                End If
            End Function

            Public Sub Agregar_Celda(_Imagen As iTextSharp.text.Image, Optional ByVal _Borde As Single = 0)
                Try
                    cl = New PdfPCell(_Imagen)
                    cl.VerticalAlignment = Element.ALIGN_CENTER
                    cl.BorderWidth = 0
                    cl.BorderWidthBottom = _Borde
                    tbl.AddCell(cl)
                Catch ex As Exception
                End Try
            End Sub

            Public Sub CrearNotaCredito(_Clave As String, _Dev As DatosFE.Models.ObtenerDevolucion43, _DevDet As List(Of DatosFE.Models.ObtenerDetallesDevolucion43))

                Dim Clave As String = _Clave
                Dim Consecutivo As String = _Dev.Consecutivo

                If Directory.Exists("C:\Facturas\" & Consecutivo) = False Then
                    Directory.CreateDirectory("C:\Facturas\" & Consecutivo)
                End If

                Me.CrearDocumento("C:\Facturas\" & Consecutivo & "\" & Clave & ".pdf")

                Me.Crear_Tabla(2)
                Me.Agregar_Celda("Nota de Credito N° " & Consecutivo & " Ver.: 4.3", Element.ALIGN_LEFT)
                Me.Agregar_Celda("Fecha Emision : " & _Dev.FechaEmision, Element.ALIGN_RIGHT)
                Me.Termina_Tabla()
                Me.Crear_Tabla(1)
                Me.Agregar_Celda("Clave Numérica " & Clave, Element.ALIGN_LEFT)
                Me.Agregar_Celda(" ", Element.ALIGN_CENTER, 0.75F, 1)
                Me.Termina_Tabla()

                Me.EscribirTexto(" ", Element.ALIGN_LEFT, 3)

                Me.Crear_Tabla(3)
                Me.Agregar_Celda(Me.GetImagen("C:\Facturas\Logo.png"))
                Me.Agregar_Celda(_Dev.NombreEmisor & vbCrLf _
                                 & "Cédula : " & _Dev.NumeroEmisor, Element.ALIGN_CENTER)
                Me.Agregar_Celda("Telefono : " & _Dev.NumTelefonoEmisor & vbCrLf _
                                 & "" & vbCrLf _
                                 & "Correo : " & _Dev.CorreoElectronicoEmisor & vbCrLf _
                                 & "" & vbCrLf _
                                 & "Direccion : " & _Dev.OtrasSenasEmisor, Element.ALIGN_LEFT, 0, 7)
                Me.Agregar_Celda(" ", Element.ALIGN_CENTER, 0.75F, 1)
                Me.Agregar_Celda(" ", Element.ALIGN_CENTER, 0.75F, 1)
                Me.Agregar_Celda(" ", Element.ALIGN_CENTER, 0.75F, 1)
                Me.Termina_Tabla()

                Dim TipoDocumento As String = _Dev.TipoFactura
                Dim NumeroDocumento As String = _Dev.NumeroReferencia

                Select Case TipoDocumento
                    Case "PVE" : TipoDocumento = "Tiquete Electronico"

                    Case "CRE" : TipoDocumento = "Factura Electronica (Credito)"
                    Case "CON" : TipoDocumento = "Factura Electronica (Contado)"

                    Case "MCR" : TipoDocumento = "Factura Electronica (Credito)"
                    Case "MCO" : TipoDocumento = "Factura Electronica (Contado)"

                    Case "TCR" : TipoDocumento = "Factura Electronica (Credito)"
                    Case "TCO" : TipoDocumento = "Factura Electronica (Contado)"
                End Select


                Me.Crear_Tabla(2)
                Me.Agregar_Celda("Receptor: " & _Dev.NombreReceptor, Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda("Tipo Documento Referencia: " & TipoDocumento, Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda("Cédula : " & _Dev.NumeroReceptor, Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda("Numero Documento Referencia: " & NumeroDocumento, Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda("Teléfono: " & _Dev.NumTelefonoReceptor, Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda("", Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda("Correo: " & _Dev.CorreoElectronicoReceptor, Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda("", Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda(" ", Element.ALIGN_CENTER, 0.75F, 1)
                Me.Agregar_Celda(" ", Element.ALIGN_CENTER, 0.75F, 1)
                Me.Termina_Tabla()

                Me.Crear_Tabla(1)
                Me.Agregar_Celda("Líneas de Detalle", Element.ALIGN_CENTER, 0, 10)
                Me.Termina_Tabla()

                Dim _tamanio() As Single = {10, 20, 75, 25, 20, 20, 30}
                Me.Crear_Tabla(7, _tamanio)
                Me.Agregar_Celda("Cant", Element.ALIGN_RIGHT, 0.75F)
                Me.Agregar_Celda("Codigo", Element.ALIGN_CENTER, 0.75F)
                Me.Agregar_Celda("Descripcion", Element.ALIGN_CENTER, 0.75F)
                Me.Agregar_Celda("P. Unit.", Element.ALIGN_RIGHT, 0.75F)
                Me.Agregar_Celda("% Desc.", Element.ALIGN_RIGHT, 0.75F)
                Me.Agregar_Celda("% IVA", Element.ALIGN_RIGHT, 0.75F)
                Me.Agregar_Celda("Monto", Element.ALIGN_RIGHT, 0.75F)

                For Each r As DatosFE.Models.ObtenerDetallesDevolucion43 In _DevDet
                    Me.Agregar_Celda(r.cantidad, Element.ALIGN_RIGHT, 0, 8)
                    Me.Agregar_Celda(r.Codigo, Element.ALIGN_CENTER, 0, 8)
                    Me.Agregar_Celda(r.Detalle, Element.ALIGN_LEFT, 0, 8)
                    Me.Agregar_Celda(Format(CDec(r.PrecioUnitario), "N2"), Element.ALIGN_RIGHT, 0, 8)
                    Me.Agregar_Celda(Format(CDec(r.Descuento), "N2"), Element.ALIGN_RIGHT, 0, 8)
                    Me.Agregar_Celda(Format(CDec(r.TarifaImpuesto), "N2"), Element.ALIGN_RIGHT, 0, 8)
                    Me.Agregar_Celda(Format(CDec(r.MontoTotal), "N2"), Element.ALIGN_RIGHT, 0, 8)
                Next

                Me.Termina_Tabla()

                Me.Crear_Tabla(1)
                Me.Agregar_Celda("(*) EXCENTO   = = = = = > ULTIMA LINEA < = = = = =", Element.ALIGN_CENTER, 0, 8)
                Me.Agregar_Celda("", Element.ALIGN_LEFT, 0.75F, 1)
                Me.Termina_Tabla()

                Dim _tamanio2() As Single = {40, 30}
                Me.Crear_Tabla(2, _tamanio2, 40, Element.ALIGN_RIGHT)
                Me.Agregar_Celda("GRAVADO", Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda(Format(CDec(_Dev.TotalGravado), "N2"), Element.ALIGN_RIGHT, 0, 8)
                Me.Agregar_Celda("EXENTO", Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda(Format(CDec(_Dev.TotalExento), "N2"), Element.ALIGN_RIGHT, 0, 8)

                Me.Agregar_Celda("DESCUENTO", Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda(Format(CDec(_Dev.TotalDescuentos), "N2"), Element.ALIGN_RIGHT, 0, 8)
                Me.Agregar_Celda("SUBTOTAL NETO", Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda(Format(CDec(_Dev.TotalVentaNeta), "N2"), Element.ALIGN_RIGHT, 0, 8)
                Me.Agregar_Celda("IVA", Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda(Format(CDec(_Dev.TotalImpuesto), "N2"), Element.ALIGN_RIGHT, 0, 8)
                Me.Agregar_Celda("TOTAL", Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda(Format(CDec(_Dev.TotalComprobante), "N2"), Element.ALIGN_RIGHT, 0, 8)

                Me.Agregar_Celda("MONEDA", Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda(_Dev.CodigoMoneda, Element.ALIGN_RIGHT, 0, 8)
                Me.Agregar_Celda("TIPO DE CAMBIO", Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda(_Dev.TipoCambio, Element.ALIGN_RIGHT, 0, 8)

                Me.Termina_Tabla()

                Me.EscribirTexto(" ", Element.ALIGN_LEFT)

                'codigo QR
                'Me.Agregar_Imagen("C:\Facturas\" & Consecutivo & "\" & Clave & ".png")

                Me.Crear_Tabla(1)
                Me.Agregar_Celda(_Dev.NumeroResolucion, Element.ALIGN_CENTER, 0, 7)
                Me.Agregar_Celda("", Element.ALIGN_LEFT, 0.75F, 1)
                Me.Termina_Tabla()

                Me.Terminar_Documento()
            End Sub

            Public Sub CrearFactura(_Clave As String, _Fac As DatosFE.Models.ObtenerFacturas43, _FacDet As List(Of DatosFE.Models.ObtenerDetalleFactura43))

                Dim Clave As String = _Clave
                Dim Consecutivo As String = _Fac.Consecutivo

                If Directory.Exists("C:\Facturas\" & Consecutivo) = False Then
                    Directory.CreateDirectory("C:\Facturas\" & Consecutivo)
                End If

                Me.CrearDocumento("C:\Facturas\" & Consecutivo & "\" & Clave & ".pdf")

                Me.Crear_Tabla(2)
                Me.Agregar_Celda("Factura Electrónica N° " & Consecutivo & " Ver.: 4.3", Element.ALIGN_LEFT)
                Me.Agregar_Celda("Fecha Emision : " & _Fac.FechaEmision, Element.ALIGN_RIGHT)
                Me.Termina_Tabla()
                Me.Crear_Tabla(1)
                Me.Agregar_Celda("Clave Numérica " & Clave, Element.ALIGN_LEFT)
                Me.Agregar_Celda(" ", Element.ALIGN_CENTER, 0.75F, 1)
                Me.Termina_Tabla()

                Me.EscribirTexto(" ", Element.ALIGN_LEFT, 3)

                Dim CedulaEmisor As String = _Fac.NumeroEmisor
                Me.Crear_Tabla(3)
                Me.Agregar_Celda(Me.GetImagen("C:\Facturas\Logo.png"))
                Me.Agregar_Celda(_Fac.NombreEmisor & vbCrLf _
                                 & "Cédula : " & CedulaEmisor, Element.ALIGN_CENTER)
                Me.Agregar_Celda("Telefono : " & _Fac.NumTelefonoEmisor & vbCrLf _
                                 & "" & vbCrLf _
                                 & "Correo : " & _Fac.CorreoElectronicoEmisor & vbCrLf _
                                 & "" & vbCrLf _
                                 & "Direccion :  " & _Fac.OtrasSenasEmisor, Element.ALIGN_LEFT, 0, 7)
                Me.Agregar_Celda(" ", Element.ALIGN_CENTER, 0.75F, 1)
                Me.Agregar_Celda(" ", Element.ALIGN_CENTER, 0.75F, 1)
                Me.Agregar_Celda(" ", Element.ALIGN_CENTER, 0.75F, 1)
                Me.Termina_Tabla()

                Dim TipoVenta As String = IIf(_Fac.CondicionVenta = "01", "CONTADO", "CREDITO")
                Me.Crear_Tabla(2)
                Me.Agregar_Celda("Receptor: " & _Fac.NombreReceptor, Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda("Condicion Venta: " & TipoVenta, Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda("Cédula : " & _Fac.NumeroReceptor, Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda(IIf(_Fac.CondicionVenta = "01", "", "Vence: " & CDate(_Fac.FechaVence).ToShortDateString), Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda("Teléfono: " & _Fac.NumTelefonoReceptor, Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda("Orden Compra: " & _Fac.OrdenCompra, Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda("Correo: " & _Fac.CorreoElectronicoReceptor, Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda("", Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda(" ", Element.ALIGN_CENTER, 0.75F, 1)
                Me.Agregar_Celda(" ", Element.ALIGN_CENTER, 0.75F, 1)
                Me.Termina_Tabla()

                Me.Crear_Tabla(1)
                Me.Agregar_Celda("Líneas de Detalle", Element.ALIGN_CENTER, 0, 10)
                Me.Termina_Tabla()

                Dim _tamanio() As Single = {10, 20, 75, 25, 20, 20, 30}
                Me.Crear_Tabla(7, _tamanio)
                Me.Agregar_Celda("Cant", Element.ALIGN_RIGHT, 0.75F)
                Me.Agregar_Celda("Codigo", Element.ALIGN_CENTER, 0.75F)
                Me.Agregar_Celda("Descripcion", Element.ALIGN_CENTER, 0.75F)
                Me.Agregar_Celda("P. Unit.", Element.ALIGN_RIGHT, 0.75F)
                Me.Agregar_Celda("% Desc.", Element.ALIGN_RIGHT, 0.75F)
                Me.Agregar_Celda("% IVA", Element.ALIGN_RIGHT, 0.75F)
                Me.Agregar_Celda("Monto", Element.ALIGN_RIGHT, 0.75F)

                For Each r As DatosFE.Models.ObtenerDetalleFactura43 In _FacDet
                    Me.Agregar_Celda(r.Cantidad, Element.ALIGN_RIGHT, 0, 8)
                    Me.Agregar_Celda(r.Codigo, Element.ALIGN_CENTER, 0, 8)
                    Me.Agregar_Celda(r.Detalle, Element.ALIGN_LEFT, 0, 8)
                    Me.Agregar_Celda(Format(CDec(r.PrecioUnitario), "N2"), Element.ALIGN_RIGHT, 0, 8)
                    Me.Agregar_Celda(Format(CDec(r.Descuento), "N2"), Element.ALIGN_RIGHT, 0, 8)

                    If r.PorcentajeCompraExoneracion > 0 Then
                        Me.Agregar_Celda(Format(CDec(r.ImpuestoNeto), "N2"), Element.ALIGN_RIGHT, 0, 8)
                    Else
                        Me.Agregar_Celda(Format(CDec(r.TarifaImpuesto), "N2"), Element.ALIGN_RIGHT, 0, 8)
                    End If

                    Me.Agregar_Celda(Format(CDec(r.MontoTotal), "N2"), Element.ALIGN_RIGHT, 0, 8)
                Next

                Me.Termina_Tabla()

                Me.Crear_Tabla(1)
                Me.Agregar_Celda("(*) EXCENTO   = = = = = > ULTIMA LINEA < = = = = =", Element.ALIGN_CENTER, 0, 8)
                Me.Agregar_Celda("", Element.ALIGN_LEFT, 0.75F, 1)
                Me.Termina_Tabla()

                Dim _tamanio2() As Single = {40, 30}
                Me.Crear_Tabla(2, _tamanio2, 40, Element.ALIGN_RIGHT)
                Me.Agregar_Celda("GRAVADO", Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda(Format(CDec(_Fac.TotalGravado), "N2"), Element.ALIGN_RIGHT, 0, 8)
                Me.Agregar_Celda("EXENTO", Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda(Format(CDec(_Fac.TotalExento), "N2"), Element.ALIGN_RIGHT, 0, 8)

                Me.Agregar_Celda("EXONERADO", Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda(Format(CDec(_Fac.TotalExonerado), "N2"), Element.ALIGN_RIGHT, 0, 8)

                Me.Agregar_Celda("DESCUENTO", Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda(Format(CDec(_Fac.TotalDescuentos), "N2"), Element.ALIGN_RIGHT, 0, 8)
                Me.Agregar_Celda("SUBTOTAL NETO", Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda(Format(CDec(_Fac.TotalVentaNeta), "N2"), Element.ALIGN_RIGHT, 0, 8)
                Me.Agregar_Celda("IVA", Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda(Format(CDec(_Fac.TotalImpuesto), "N2"), Element.ALIGN_RIGHT, 0, 8)
                Me.Agregar_Celda("TOTAL", Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda(Format(CDec(_Fac.TotalComprobante), "N2"), Element.ALIGN_RIGHT, 0, 8)

                Me.Agregar_Celda("MONEDA", Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda(_Fac.CodigoMoneda, Element.ALIGN_RIGHT, 0, 8)
                Me.Agregar_Celda("TIPO DE CAMBIO", Element.ALIGN_LEFT, 0, 8)
                Me.Agregar_Celda(_Fac.TipoCambio, Element.ALIGN_RIGHT, 0, 8)

                Me.Termina_Tabla()

                Me.EscribirTexto(" ", Element.ALIGN_LEFT)

                'codigo QR
                'Me.Agregar_Imagen("C:\Facturas\" & Consecutivo & "\" & Clave & ".png")

                Me.Crear_Tabla(1)
                Me.Agregar_Celda(_Fac.NumeroResolucion, Element.ALIGN_CENTER, 0, 7)
                Me.Agregar_Celda("", Element.ALIGN_LEFT, 0.75F, 1)
                Me.Termina_Tabla()

                If TipoVenta = "CREDITO" Then

                    Select Case CedulaEmisor
                        Case "3101105432" 'Super Veterinaria Liberia
                            Me.EscribirTexto(" ", Element.ALIGN_LEFT)
                            Me.Crear_Tabla(1)
                            Me.Agregar_Celda("Para depositos, favor indicar cuales facturas se estan cancelando.", Element.ALIGN_LEFT, 0, 9)
                            Me.Termina_Tabla()

                            Me.Crear_Tabla(3)
                            Me.Agregar_Celda("Banco de Costa Rica", Element.ALIGN_LEFT, 0, 8)
                            Me.Agregar_Celda("Banco Nacional de Costa Rica", Element.ALIGN_LEFT, 0, 8)
                            Me.Agregar_Celda("BAC San Jose", Element.ALIGN_LEFT, 0, 8)
                            Me.Agregar_Celda("CTA: 225-0003871-7", Element.ALIGN_LEFT, 0, 7)
                            Me.Agregar_Celda("CTA: 100-1-015-004884-6", Element.ALIGN_LEFT, 0, 7)
                            Me.Agregar_Celda("CTA: 900796020", Element.ALIGN_LEFT, 0, 7)
                            Me.Agregar_Celda("CC: 15201225000387171", Element.ALIGN_LEFT, 0, 7)
                            Me.Agregar_Celda("CC: 15101510010048842", Element.ALIGN_LEFT, 0, 7)
                            Me.Agregar_Celda("CC: 10200009007960202", Element.ALIGN_LEFT, 0, 7)
                            Me.Agregar_Celda("IBAN: CR 12 0152 0122 5000 3871 71", Element.ALIGN_LEFT, 0, 7)
                            Me.Agregar_Celda("IBAN: CR54 0151 0151 0010 0488 42", Element.ALIGN_LEFT, 0, 7)
                            Me.Agregar_Celda("IBAN: CR77 0102 0000 9007 9602 02", Element.ALIGN_LEFT, 0, 7)
                            Me.Termina_Tabla()

                            Me.EscribirTexto(" ", Element.ALIGN_LEFT)

                            Me.Crear_Tabla(1)
                            Me.Agregar_Celda("Esta factura devenga intereses mensuales despues de su vencimiento.", Element.ALIGN_LEFT, 0, 9)
                            Me.Termina_Tabla()

                        Case "3101340440" 'Super Veterinaria Cañas
                            Me.EscribirTexto(" ", Element.ALIGN_LEFT)
                            Me.Crear_Tabla(1)
                            Me.Agregar_Celda("Para depositos, favor indicar cuales facturas se estan cancelando.", Element.ALIGN_LEFT, 0, 9)
                            Me.Termina_Tabla()

                            Me.Crear_Tabla(1)
                            Me.Agregar_Celda("Banco Nacional de Costa Rica", Element.ALIGN_LEFT, 0, 8)
                            Me.Agregar_Celda("IBAN: CR95 0151 0081 0010 0440 65", Element.ALIGN_LEFT, 0, 7)
                            Me.Termina_Tabla()

                            Me.EscribirTexto(" ", Element.ALIGN_LEFT)

                            Me.Crear_Tabla(1)
                            Me.Agregar_Celda("Esta factura devenga intereses mensuales despues de su vencimiento.", Element.ALIGN_LEFT, 0, 9)
                            Me.Termina_Tabla()

                        Case "3101353624" 'Super Veterinaria Santa Cruz
                            Me.EscribirTexto(" ", Element.ALIGN_LEFT)
                            Me.Crear_Tabla(1)
                            Me.Agregar_Celda("Para depositos, favor indicar cuales facturas se estan cancelando.", Element.ALIGN_LEFT, 0, 9)
                            Me.Termina_Tabla()

                            Me.Crear_Tabla(1)
                            Me.Agregar_Celda("Banco Nacional de Costa Rica", Element.ALIGN_LEFT, 0, 8)
                            Me.Agregar_Celda("IBAN: CR91 0151 0151 0010 0567 12", Element.ALIGN_LEFT, 0, 7)
                            Me.Termina_Tabla()
                            Me.EscribirTexto(" ", Element.ALIGN_LEFT)

                            Me.Crear_Tabla(1)
                            Me.Agregar_Celda("Esta factura devenga intereses mensuales despues de su vencimiento.", Element.ALIGN_LEFT, 0, 9)
                            Me.Termina_Tabla()
                    End Select

                End If

                Me.Terminar_Documento()
            End Sub


        End Class

    End Namespace

End Namespace
