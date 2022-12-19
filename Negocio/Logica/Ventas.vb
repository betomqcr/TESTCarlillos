Namespace Logica
    Public Class Ventas

        Private db As Datos.Class.Ventas

        Sub New()
            Me.db = New Datos.Class.Ventas
        End Sub

        Public Function obtenerVentas(id As Long) As Datos.Models.Venta
            Dim Datos As New Datos.Models.Venta
            Datos = Me.db.Obtener(id)

            Dim venta As New Datos.Models.Venta
            venta.Id = Datos.Id
            venta.NumFactura = Datos.NumFactura
            venta.Tipo = Datos.Tipo
            venta.CodCliente = Datos.CodCliente
            venta.NombreCliente = Datos.NombreCliente
            venta.Orden = Datos.Orden
            venta.CedulaUsuario = Datos.CedulaUsuario
            venta.PagoComision = Datos.PagoComision
            venta.SubTotal = Datos.SubTotal
            venta.Descuento = Datos.Descuento
            venta.ImpVenta = Datos.ImpVenta
            venta.Total = Datos.Total
            venta.Fecha = Datos.Fecha
            venta.Vence = Datos.Vence
            venta.CodEncargadoCompra = Datos.CodEncargadoCompra
            venta.Contabilizado = Datos.Contabilizado
            venta.AsientoVenta = Datos.AsientoVenta
            venta.ContabilizadoCventa = Datos.ContabilizadoCventa
            venta.AsientoCosto = Datos.AsientoCosto
            venta.Anulado = Datos.Anulado
            venta.PagoImpuesto = Datos.PagoImpuesto
            venta.FacturaCancelado = Datos.FacturaCancelado
            venta.NumApertura = Datos.NumApertura
            venta.Entregado = Datos.Entregado
            venta.CodMoneda = Datos.CodMoneda
            venta.MonedaNombre = Datos.MonedaNombre
            venta.Direccion = Datos.Direccion
            venta.Telefono = Datos.Telefono
            venta.SubTotalGravada = Datos.SubTotalGravada
            venta.SubTotalExento = Datos.SubTotalExento
            venta.Transporte = Datos.Transporte
            venta.TipoCambio = Datos.TipoCambio
            venta.Observaciones = Datos.Observaciones
            venta.Exonerar = Datos.Exonerar
            venta.Taller = Datos.Taller
            venta.Mascotas = Datos.Mascotas
            venta.NumCaja = Datos.NumCaja
            venta.Agente = Datos.Agente
            venta.CodAgente = Datos.CodAgente
            venta.Apartado = Datos.Apartado
            venta.EnviadoMh = Datos.EnviadoMh
            venta.Cedula = Datos.Cedula
            venta.ClaveMh = Datos.ClaveMh
            venta.EstadoMh = Datos.EstadoMh
            venta.TipoCedula = Datos.TipoCedula
            venta.ConsecutivoMh = Datos.ConsecutivoMh
            venta.ExcluirCxC = Datos.ExcluirCxC
            venta.Frecuente = Datos.Frecuente
            venta.IdFacturaRemplaza = Datos.IdFacturaRemplaza

            For Each veDet As Datos.Models.VentasDetalle In Me.db.BuscarDetalle(Datos.Id)
                Dim VentaDetalle As New Datos.Models.VentasDetalle
                VentaDetalle.IdVentaDetalle = veDet.IdVentaDetalle
                VentaDetalle.IdFactura = veDet.IdFactura
                VentaDetalle.Codigo = veDet.Codigo
                VentaDetalle.CodArticulo = veDet.CodArticulo
                VentaDetalle.Descripcion = veDet.Descripcion
                VentaDetalle.Cantidad = veDet.Cantidad
                VentaDetalle.PrecioCosto = veDet.PrecioCosto
                VentaDetalle.PrecioBase = veDet.PrecioBase
                VentaDetalle.PrecioFlete = veDet.PrecioFlete
                VentaDetalle.PrecioOtros = veDet.PrecioOtros
                VentaDetalle.PrecioUnit = veDet.PrecioUnit
                VentaDetalle.Descuento = veDet.Descuento
                VentaDetalle.MontoDescuento = veDet.MontoDescuento
                VentaDetalle.Impuesto = veDet.Impuesto
                VentaDetalle.MontoImpuesto = veDet.MontoImpuesto
                VentaDetalle.SubtotalGravado = veDet.SubtotalGravado
                VentaDetalle.SubTotalExcento = veDet.SubTotalExcento
                VentaDetalle.SubTotal = veDet.SubTotal
                VentaDetalle.Devoluciones = veDet.Devoluciones
                VentaDetalle.NumeroEntrega = veDet.NumeroEntrega
                VentaDetalle.MaxDescuento = veDet.MaxDescuento
                VentaDetalle.TipoCambioValorCompra = veDet.TipoCambioValorCompra
                VentaDetalle.CodMonedaVenta = veDet.CodMonedaVenta
                VentaDetalle.Lote = veDet.Lote
                VentaDetalle.CantVet = veDet.CantVet
                VentaDetalle.CantBod = veDet.CantBod
                VentaDetalle.Disminuye = veDet.Disminuye
                VentaDetalle.Empaquetado = veDet.Empaquetado
                VentaDetalle.NotaPantalla = veDet.NotaPantalla
                VentaDetalle.IdBodega = veDet.IdBodega
                VentaDetalle.Regalias = veDet.Regalias
                VentaDetalle.CostoReal = veDet.CostoReal
                VentaDetalle.IdTipoExoneracion = veDet.IdTipoExoneracion
                VentaDetalle.NumeroDocumento = veDet.NumeroDocumento
                VentaDetalle.FechaEmision = veDet.FechaEmision
                VentaDetalle.PorcentajeCompra = veDet.PorcentajeCompra
                VentaDetalle.Entregado = veDet.Entregado
                VentaDetalle.Entregados = veDet.Entregados
                VentaDetalle.IdSerie = veDet.IdSerie

                venta.VentasDetalles.Add(VentaDetalle)
            Next

            Return venta
        End Function

        Public Function BuscarVenta(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.Venta)
            Dim datos As New List(Of Datos.Models.Venta)
            datos = Me.db.Buscar(porNombre, Filtro)

            Dim Resultado As New List(Of Datos.Models.Venta)
            For Each ve As Datos.Models.Venta In datos
                Dim Venta As New Datos.Models.Venta
                Venta.Id = ve.Id
                Venta.NumFactura = ve.NumFactura
                Venta.Tipo = ve.Tipo
                Venta.CodCliente = ve.CodCliente
                Venta.NombreCliente = ve.NombreCliente
                Venta.Orden = ve.Orden
                Venta.CedulaUsuario = ve.CedulaUsuario
                Venta.PagoComision = ve.PagoComision
                Venta.SubTotal = ve.SubTotal
                Venta.Descuento = ve.Descuento
                Venta.ImpVenta = ve.ImpVenta
                Venta.Total = ve.Total
                Venta.Fecha = ve.Fecha
                Venta.Vence = ve.Vence
                Venta.CodEncargadoCompra = ve.CodEncargadoCompra
                Venta.Contabilizado = ve.Contabilizado
                Venta.AsientoVenta = ve.AsientoVenta
                Venta.ContabilizadoCventa = ve.ContabilizadoCventa
                Venta.AsientoCosto = ve.AsientoCosto
                Venta.Anulado = ve.Anulado
                Venta.PagoImpuesto = ve.PagoImpuesto
                Venta.FacturaCancelado = ve.FacturaCancelado
                Venta.NumApertura = ve.NumApertura
                Venta.Entregado = ve.Entregado
                Venta.CodMoneda = ve.CodMoneda
                Venta.MonedaNombre = ve.MonedaNombre
                Venta.Direccion = ve.Direccion
                Venta.Telefono = ve.Telefono
                Venta.SubTotalGravada = ve.SubTotalGravada
                Venta.SubTotalExento = ve.SubTotalExento
                Venta.Transporte = ve.Transporte
                Venta.TipoCambio = ve.TipoCambio
                Venta.Observaciones = ve.Observaciones
                Venta.Exonerar = ve.Exonerar
                Venta.Taller = ve.Taller
                Venta.Mascotas = ve.Mascotas
                Venta.NumCaja = ve.NumCaja
                Venta.Agente = ve.Agente
                Venta.CodAgente = ve.CodAgente
                Venta.Apartado = ve.Apartado
                Venta.EnviadoMh = ve.EnviadoMh
                Venta.Cedula = ve.Cedula
                Venta.ClaveMh = ve.ClaveMh
                Venta.EstadoMh = ve.EstadoMh
                Venta.TipoCedula = ve.TipoCedula
                Venta.ConsecutivoMh = ve.ConsecutivoMh
                Venta.ExcluirCxC = ve.ExcluirCxC
                Venta.Frecuente = ve.Frecuente
                Venta.IdFacturaRemplaza = ve.IdFacturaRemplaza

                For Each venDet As Datos.Models.VentasDetalle In Me.db.BuscarDetalle(ve.Id)
                    Dim VentaDetalle As New Datos.Models.VentasDetalle
                    VentaDetalle.IdVentaDetalle = venDet.IdVentaDetalle
                    VentaDetalle.IdFactura = venDet.IdFactura
                    VentaDetalle.Codigo = venDet.Codigo
                    VentaDetalle.CodArticulo = venDet.CodArticulo
                    VentaDetalle.Descripcion = venDet.Descripcion
                    VentaDetalle.Cantidad = venDet.Cantidad
                    VentaDetalle.PrecioCosto = venDet.PrecioCosto
                    VentaDetalle.PrecioBase = venDet.PrecioBase
                    VentaDetalle.PrecioFlete = venDet.PrecioFlete
                    VentaDetalle.PrecioOtros = venDet.PrecioOtros
                    VentaDetalle.PrecioUnit = venDet.PrecioUnit
                    VentaDetalle.Descuento = venDet.Descuento
                    VentaDetalle.MontoDescuento = venDet.MontoDescuento
                    VentaDetalle.Impuesto = venDet.Impuesto
                    VentaDetalle.MontoImpuesto = venDet.MontoImpuesto
                    VentaDetalle.SubtotalGravado = venDet.SubtotalGravado
                    VentaDetalle.SubTotalExcento = venDet.SubTotalExcento
                    VentaDetalle.SubTotal = venDet.SubTotal
                    VentaDetalle.Devoluciones = venDet.Devoluciones
                    VentaDetalle.NumeroEntrega = venDet.NumeroEntrega
                    VentaDetalle.MaxDescuento = venDet.MaxDescuento
                    VentaDetalle.TipoCambioValorCompra = venDet.TipoCambioValorCompra
                    VentaDetalle.CodMonedaVenta = venDet.CodMonedaVenta
                    VentaDetalle.Lote = venDet.Lote
                    VentaDetalle.CantVet = venDet.CantVet
                    VentaDetalle.CantBod = venDet.CantBod
                    VentaDetalle.Disminuye = venDet.Disminuye
                    VentaDetalle.Empaquetado = venDet.Empaquetado
                    VentaDetalle.NotaPantalla = venDet.NotaPantalla
                    VentaDetalle.IdBodega = venDet.IdBodega
                    VentaDetalle.Regalias = venDet.Regalias
                    VentaDetalle.CostoReal = venDet.CostoReal
                    VentaDetalle.IdTipoExoneracion = venDet.IdTipoExoneracion
                    VentaDetalle.NumeroDocumento = venDet.NumeroDocumento
                    VentaDetalle.FechaEmision = venDet.FechaEmision
                    VentaDetalle.PorcentajeCompra = venDet.PorcentajeCompra
                    VentaDetalle.Entregado = venDet.Entregado
                    VentaDetalle.Entregados = venDet.Entregados
                    VentaDetalle.IdSerie = venDet.IdSerie

                    Venta.VentasDetalles.Add(VentaDetalle)
                Next

                Resultado.Add(Venta)
            Next

            Return Resultado
        End Function

        Public Function Crear(ventas As Datos.Models.Venta) As String
            Return Me.db.Crear(ventas)
        End Function


    End Class
End Namespace
