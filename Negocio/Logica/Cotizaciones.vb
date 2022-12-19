Namespace Logica
    Public Class Cotizaciones

        Private db As Datos.Class.Cotizacion

        Sub New()
            Me.db = New Datos.Class.Cotizacion
        End Sub

        Public Function Buscar(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.Cotizacion)
            Dim datos As New List(Of Datos.Models.Cotizacion)
            datos = Me.db.Buscar(porNombre, Filtro)

            Dim Resultado As New List(Of Datos.Models.Cotizacion)
            For Each cot As Datos.Models.Cotizacion In datos
                Dim Cotizacion As New Datos.Models.Cotizacion
                Cotizacion.Cotizacion1 = cot.Cotizacion1
                Cotizacion.Fecha = cot.Fecha
                Cotizacion.CodCliente = cot.CodCliente
                Cotizacion.NombreCliente = cot.NombreCliente
                Cotizacion.Contacto = cot.Contacto
                Cotizacion.Validez = cot.Validez
                Cotizacion.TiempoEntrega = cot.TiempoEntrega
                Cotizacion.Contado = cot.Contado
                Cotizacion.Credito = cot.Credito
                Cotizacion.Anulado = cot.Anulado
                Cotizacion.Dias = cot.Dias
                Cotizacion.Observaciones = cot.Observaciones
                Cotizacion.SubTotalGravada = cot.SubTotalGravada
                Cotizacion.SubTotalExento = cot.SubTotalExento
                Cotizacion.Descuento = cot.Descuento
                Cotizacion.PagoImpuesto = cot.PagoImpuesto
                Cotizacion.Total = cot.Total
                Cotizacion.Cedula = cot.Cedula
                Cotizacion.CodMoneda = cot.CodMoneda
                Cotizacion.MonedaNombre = cot.MonedaNombre
                Cotizacion.SubTotal = cot.SubTotal
                Cotizacion.TipoCambio = cot.TipoCambio
                Cotizacion.ImpVenta = cot.ImpVenta
                Cotizacion.Transporte = cot.Transporte
                Cotizacion.Venta = cot.Venta
                Cotizacion.Exonerar = cot.Exonerar
                Cotizacion.Confirmada = cot.Confirmada
                Cotizacion.ConfirmadaPor = cot.ConfirmadaPor
                Cotizacion.EstadoActual = cot.EstadoActual
                Cotizacion.ObservacionEstado = cot.ObservacionEstado
                Cotizacion.IdFactura = cot.IdFactura
                Cotizacion.Telefono = cot.Telefono
                Cotizacion.TipoCedula = cot.TipoCedula
                Cotizacion.CedulaCliente = cot.CedulaCliente
                Cotizacion.IdSucursal = cot.IdSucursal

                For Each cotDet As Datos.Models.CotizacionDetalle In Me.db.BuscarDetalleCotizacion(cot.Cotizacion1)
                    Dim CotizacionDetalle As New Datos.Models.CotizacionDetalle
                    CotizacionDetalle.Numero = cotDet.Numero
                    CotizacionDetalle.Cotizacion = cotDet.Cotizacion
                    CotizacionDetalle.Codigo = cotDet.Codigo
                    CotizacionDetalle.CodArticulo = cotDet.CodArticulo
                    CotizacionDetalle.Descripcion = cotDet.Descripcion
                    CotizacionDetalle.Cantidad = cotDet.Cantidad
                    CotizacionDetalle.PrecioCosto = cotDet.PrecioCosto
                    CotizacionDetalle.PrecioBase = cotDet.PrecioBase
                    CotizacionDetalle.PrecioFlete = cotDet.PrecioFlete
                    CotizacionDetalle.PrecioOtros = cotDet.PrecioOtros
                    CotizacionDetalle.PrecioUnit = cotDet.PrecioUnit
                    CotizacionDetalle.Descuento = cotDet.Descuento
                    CotizacionDetalle.MontoDescuento = cotDet.MontoDescuento
                    CotizacionDetalle.Impuesto = cotDet.Impuesto
                    CotizacionDetalle.MontoImpuesto = cotDet.MontoImpuesto
                    CotizacionDetalle.SubtotalGravado = cotDet.SubtotalGravado
                    CotizacionDetalle.SubTotalExcento = cotDet.SubTotalExcento
                    CotizacionDetalle.SubTotal = cotDet.SubTotal
                    CotizacionDetalle.SubFamilia = cotDet.SubFamilia
                    CotizacionDetalle.MaxDescuento = cotDet.MaxDescuento
                    CotizacionDetalle.TipoCambioValorCompra = cotDet.TipoCambioValorCompra
                    CotizacionDetalle.CodMonedaVenta = cotDet.CodMonedaVenta
                    Cotizacion.CotizacionDetalles.Add(CotizacionDetalle)
                Next

                Resultado.Add(Cotizacion)
            Next

            Return Resultado
        End Function

        Public Function Crear(cotizacion As Datos.Models.Cotizacion) As String
            Return Me.db.Crear(cotizacion)
        End Function

        Public Function Editar(Id As Long, Cotizacion As Datos.Models.Cotizacion) As String
            Dim res As String = Me.db.Editar(Id, Cotizacion)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
        End Function

        Public Function Anular(Id As Long) As String
            Dim res As String = Me.db.Anular(Id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
        End Function

    End Class

End Namespace
