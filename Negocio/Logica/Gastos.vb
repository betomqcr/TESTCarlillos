Namespace Logica
    Public Class Gastos

        Private db As Datos.Class.Gastos

        Sub New()
            Me.db = New Datos.Class.Gastos
        End Sub

        Public Function Eliminar(Id As Long) As String
            Return Me.db.BorrarGasto(Id)
        End Function

        Public Function Crear(Gasto As Datos.Models.Compra) As String
            Return db.CrearGastos(Gasto)
        End Function

        Public Function Editar(Id As Long, Gasto As Datos.Models.Compra) As String
            Dim res As String = db.EditarGasto(Id, Gasto)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
        End Function

        Public Function Buscar(porId As Boolean, filtro As String) As List(Of Datos.Models.Compra)
            Dim datos As New List(Of Datos.Models.Compra)
            datos = Me.db.ObtenerGasto(porId, filtro)

            Dim Resultado As New List(Of Datos.Models.Compra)
            For Each comp As Datos.Models.Compra In datos
                Dim Compra As New Datos.Models.Compra
                Compra.IdCompra = comp.IdCompra
                Compra.Factura = comp.Factura
                Compra.CodigoProv = comp.CodigoProv
                Compra.SubTotalGravado = comp.SubTotalGravado
                Compra.SubTotalExento = comp.SubTotalExento
                Compra.Descuento = comp.Descuento
                Compra.Impuesto = comp.Impuesto
                Compra.TotalFactura = comp.TotalFactura
                Compra.Fecha = comp.Fecha
                Compra.Vence = comp.Vence
                Compra.FechaIngreso = comp.FechaIngreso
                Compra.MotivoGasto = comp.MotivoGasto
                Compra.Compra1 = comp.Compra1
                Compra.Contabilizado = comp.Contabilizado
                Compra.Consignacion = comp.Consignacion
                Compra.Asiento = comp.Asiento
                Compra.ContaInve = comp.ContaInve
                Compra.AsientoInve = comp.AsientoInve
                Compra.TipoCompra = comp.TipoCompra
                Compra.CedulaUsuario = comp.CedulaUsuario
                Compra.CodMonedaCompra = comp.CodMonedaCompra
                Compra.FacturaCancelado = comp.FacturaCancelado
                Compra.Gasto = comp.Gasto
                Compra.TipoCambio = comp.TipoCambio
                Compra.CambioImpuesto = comp.CambioImpuesto
                Compra.Taller = comp.Taller
                Compra.Mascotas = comp.Mascotas
                Compra.NumOrden = comp.NumOrden
                Compra.Fec = comp.Fec
                Compra.CodigoActividad = comp.CodigoActividad
                Compra.EnviadoDgt = comp.EnviadoDgt
                Compra.EstadoDgt = comp.EstadoDgt
                Compra.ConsecutivoDgt = comp.ConsecutivoDgt
                Compra.ClaveDgt = comp.ClaveDgt
                Compra.Trans = comp.Trans
                Compra.NumTrans = comp.NumTrans
                Compra.Prepagada = comp.Prepagada
                Compra.PreAbono = comp.PreAbono


                For Each det As Datos.Models.ArticulosGasto In Me.db.ObtenerArticulosGastos(Compra.IdCompra)
                    Dim Detalle As New Datos.Models.ArticulosGasto
                    Detalle.IdArticuloComprados = det.IdArticuloComprados
                    Detalle.IdCompra = det.IdCompra
                    Detalle.Descripcion = det.Descripcion
                    Detalle.Base = det.Base
                    Detalle.MontoFlete = det.MontoFlete
                    Detalle.OtrosCargos = det.OtrosCargos
                    Detalle.Costo = det.Costo
                    Detalle.Cantidad = det.Cantidad
                    Detalle.Gravado = det.Gravado
                    Detalle.Exento = det.Exento
                    Detalle.DescuentoP = det.DescuentoP
                    Detalle.Descuento = det.Descuento
                    Detalle.ImpuestoP = det.ImpuestoP
                    Detalle.Impuesto = det.Impuesto
                    Detalle.Total = det.Total
                    Detalle.Devoluciones = det.Devoluciones
                    Detalle.NuevoCostoBase = det.NuevoCostoBase
                    Detalle.CuentaContable = det.CuentaContable
                    Detalle.CodTipoCompra = det.CodTipoCompra
                    Detalle.DescTipoCompra = det.DescTipoCompra

                    Compra.ArticulosGastos.Add(Detalle)
                Next

                Resultado.Add(Compra)
            Next

            Return Resultado
        End Function


    End Class
End Namespace

