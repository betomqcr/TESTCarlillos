Namespace Logica
    Public Class Preventas

        Private db As Datos.Class.PreVentas

        Sub New()
            Me.db = New Datos.Class.PreVentas
        End Sub

        Public Function obtenerPreVentas(id As Long) As Datos.Models.PreVenta
            Dim Datos As New Datos.Models.PreVenta
            Datos = Me.db.Obtener(id)

            Dim Preventa As New Datos.Models.PreVenta
            Preventa.Id = Datos.Id
            Preventa.NumFactura = Datos.NumFactura
            Preventa.Tipo = Datos.Tipo
            Preventa.CodCliente = Datos.CodCliente
            Preventa.NombreCliente = Datos.NombreCliente
            Preventa.Orden = Datos.Orden
            Preventa.CedulaUsuario = Datos.CedulaUsuario
            Preventa.PagoComision = Datos.PagoComision
            Preventa.SubTotal = Datos.SubTotal
            Preventa.Descuento = Datos.Descuento
            Preventa.ImpVenta = Datos.ImpVenta
            Preventa.Total = Datos.Total
            Preventa.Fecha = Datos.Fecha
            Preventa.Vence = Datos.Vence
            Preventa.CodEncargadoCompra = Datos.CodEncargadoCompra
            Preventa.Contabilizado = Datos.Contabilizado
            Preventa.AsientoVenta = Datos.AsientoVenta
            Preventa.ContabilizadoCventa = Datos.ContabilizadoCventa
            Preventa.AsientoCosto = Datos.AsientoCosto
            Preventa.Anulado = Datos.Anulado
            Preventa.PagoImpuesto = Datos.PagoImpuesto
            Preventa.FacturaCancelado = Datos.FacturaCancelado
            Preventa.NumApertura = Datos.NumApertura
            Preventa.Entregado = Datos.Entregado
            Preventa.CodMoneda = Datos.CodMoneda
            Preventa.MonedaNombre = Datos.MonedaNombre
            Preventa.Direccion = Datos.Direccion
            Preventa.Telefono = Datos.Telefono
            Preventa.SubTotalGravada = Datos.SubTotalGravada
            Preventa.SubTotalExento = Datos.SubTotalExento
            Preventa.Transporte = Datos.Transporte
            Preventa.TipoCambio = Datos.TipoCambio
            Preventa.Observaciones = Datos.Observaciones
            Preventa.Exonerar = Datos.Exonerar
            Preventa.Taller = Datos.Taller
            Preventa.Mascotas = Datos.Mascotas
            Preventa.NumCaja = Datos.NumCaja
            Preventa.Agente = Datos.Agente
            Preventa.CodAgente = Datos.CodAgente
            Preventa.Apartado = Datos.Apartado
            Preventa.EnviadoMh = Datos.EnviadoMh
            Preventa.Cedula = Datos.Cedula
            Preventa.ClaveMh = Datos.ClaveMh
            Preventa.EstadoMh = Datos.EstadoMh
            Preventa.TipoCedula = Datos.TipoCedula
            Preventa.ConsecutivoMh = Datos.ConsecutivoMh
            Preventa.ExcluirCxC = Datos.ExcluirCxC
            Preventa.Ficha = Datos.Ficha
            Preventa.Estado = Datos.Estado
            Preventa.IdCotizacion = Datos.IdCotizacion
            Preventa.Frecuente = Datos.Frecuente
            Preventa.IdFactura = Datos.IdFactura
            Preventa.IdFacturaRemplaza = Datos.IdFacturaRemplaza

            For Each preDet As Datos.Models.PreVentasDetalle In Me.db.BuscarDetalle(Datos.Id)
                Dim PreventaDetalle As New Datos.Models.PreVentasDetalle
                PreventaDetalle.IdVentaDetalle = preDet.IdVentaDetalle
                PreventaDetalle.IdFactura = preDet.IdFactura
                PreventaDetalle.Codigo = preDet.Codigo
                PreventaDetalle.CodArticulo = preDet.CodArticulo
                PreventaDetalle.Descripcion = preDet.Descripcion
                PreventaDetalle.Cantidad = preDet.Cantidad
                PreventaDetalle.PrecioCosto = preDet.PrecioCosto
                PreventaDetalle.PrecioBase = preDet.PrecioBase
                PreventaDetalle.PrecioFlete = preDet.PrecioFlete
                PreventaDetalle.PrecioOtros = preDet.PrecioOtros
                PreventaDetalle.PrecioUnit = preDet.PrecioUnit
                PreventaDetalle.Descuento = preDet.Descuento
                PreventaDetalle.MontoDescuento = preDet.MontoDescuento
                PreventaDetalle.Impuesto = preDet.Impuesto
                PreventaDetalle.MontoImpuesto = preDet.MontoImpuesto
                PreventaDetalle.SubtotalGravado = preDet.SubtotalGravado
                PreventaDetalle.SubTotalExcento = preDet.SubTotalExcento
                PreventaDetalle.SubTotal = preDet.SubTotal
                PreventaDetalle.Devoluciones = preDet.Devoluciones
                PreventaDetalle.NumeroEntrega = preDet.NumeroEntrega
                PreventaDetalle.MaxDescuento = preDet.MaxDescuento
                PreventaDetalle.TipoCambioValorCompra = preDet.TipoCambioValorCompra
                PreventaDetalle.CodMonedaVenta = preDet.CodMonedaVenta
                PreventaDetalle.Lote = preDet.Lote
                PreventaDetalle.CantVet = preDet.CantVet
                PreventaDetalle.CantBod = preDet.CantBod
                PreventaDetalle.Disminuye = preDet.Disminuye
                PreventaDetalle.Empaquetado = preDet.Empaquetado
                PreventaDetalle.NotaPantalla = preDet.NotaPantalla
                PreventaDetalle.IdBodega = preDet.IdBodega
                PreventaDetalle.Regalias = preDet.Regalias
                PreventaDetalle.CostoReal = preDet.CostoReal
                PreventaDetalle.IdTipoExoneracion = preDet.IdTipoExoneracion
                PreventaDetalle.NumeroDocumento = preDet.NumeroDocumento
                PreventaDetalle.FechaEmision = preDet.FechaEmision
                PreventaDetalle.PorcentajeCompra = preDet.PorcentajeCompra
                PreventaDetalle.Entregado = preDet.Entregado
                PreventaDetalle.Entregados = preDet.Entregados
                PreventaDetalle.IdSerie = preDet.IdSerie

                Preventa.PreVentasDetalles.Add(PreventaDetalle)
            Next

            Return Preventa
        End Function

        Public Function BuscarPreVenta(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.PreVenta)
            Dim datos As New List(Of Datos.Models.PreVenta)
            datos = Me.db.Buscar(porNombre, Filtro)

            Dim Resultado As New List(Of Datos.Models.PreVenta)
            For Each pre As Datos.Models.PreVenta In datos
                Dim Preventa As New Datos.Models.PreVenta
                Preventa.Id = pre.Id
                Preventa.NumFactura = pre.NumFactura
                Preventa.Tipo = pre.Tipo
                Preventa.CodCliente = pre.CodCliente
                Preventa.NombreCliente = pre.NombreCliente
                Preventa.Orden = pre.Orden
                Preventa.CedulaUsuario = pre.CedulaUsuario
                Preventa.PagoComision = pre.PagoComision
                Preventa.SubTotal = pre.SubTotal
                Preventa.Descuento = pre.Descuento
                Preventa.ImpVenta = pre.ImpVenta
                Preventa.Total = pre.Total
                Preventa.Fecha = pre.Fecha
                Preventa.Vence = pre.Vence
                Preventa.CodEncargadoCompra = pre.CodEncargadoCompra
                Preventa.Contabilizado = pre.Contabilizado
                Preventa.AsientoVenta = pre.AsientoVenta
                Preventa.ContabilizadoCventa = pre.ContabilizadoCventa
                Preventa.AsientoCosto = pre.AsientoCosto
                Preventa.Anulado = pre.Anulado
                Preventa.PagoImpuesto = pre.PagoImpuesto
                Preventa.FacturaCancelado = pre.FacturaCancelado
                Preventa.NumApertura = pre.NumApertura
                Preventa.Entregado = pre.Entregado
                Preventa.CodMoneda = pre.CodMoneda
                Preventa.MonedaNombre = pre.MonedaNombre
                Preventa.Direccion = pre.Direccion
                Preventa.Telefono = pre.Telefono
                Preventa.SubTotalGravada = pre.SubTotalGravada
                Preventa.SubTotalExento = pre.SubTotalExento
                Preventa.Transporte = pre.Transporte
                Preventa.TipoCambio = pre.TipoCambio
                Preventa.Observaciones = pre.Observaciones
                Preventa.Exonerar = pre.Exonerar
                Preventa.Taller = pre.Taller
                Preventa.Mascotas = pre.Mascotas
                Preventa.NumCaja = pre.NumCaja
                Preventa.Agente = pre.Agente
                Preventa.CodAgente = pre.CodAgente
                Preventa.Apartado = pre.Apartado
                Preventa.EnviadoMh = pre.EnviadoMh
                Preventa.Cedula = pre.Cedula
                Preventa.ClaveMh = pre.ClaveMh
                Preventa.EstadoMh = pre.EstadoMh
                Preventa.TipoCedula = pre.TipoCedula
                Preventa.ConsecutivoMh = pre.ConsecutivoMh
                Preventa.ExcluirCxC = pre.ExcluirCxC
                Preventa.Ficha = pre.Ficha
                Preventa.Estado = pre.Estado
                Preventa.IdCotizacion = pre.IdCotizacion
                Preventa.Frecuente = pre.Frecuente
                Preventa.IdFactura = pre.IdFactura
                Preventa.IdFacturaRemplaza = pre.IdFacturaRemplaza

                For Each preDet As Datos.Models.PreVentasDetalle In Me.db.BuscarDetalle(pre.Id)
                    Dim PreventaDetalle As New Datos.Models.PreVentasDetalle
                    PreventaDetalle.IdVentaDetalle = preDet.IdVentaDetalle
                    PreventaDetalle.IdFactura = preDet.IdFactura
                    PreventaDetalle.Codigo = preDet.Codigo
                    PreventaDetalle.CodArticulo = preDet.CodArticulo
                    PreventaDetalle.Descripcion = preDet.Descripcion
                    PreventaDetalle.Cantidad = preDet.Cantidad
                    PreventaDetalle.PrecioCosto = preDet.PrecioCosto
                    PreventaDetalle.PrecioBase = preDet.PrecioBase
                    PreventaDetalle.PrecioFlete = preDet.PrecioFlete
                    PreventaDetalle.PrecioOtros = preDet.PrecioOtros
                    PreventaDetalle.PrecioUnit = preDet.PrecioUnit
                    PreventaDetalle.Descuento = preDet.Descuento
                    PreventaDetalle.MontoDescuento = preDet.MontoDescuento
                    PreventaDetalle.Impuesto = preDet.Impuesto
                    PreventaDetalle.MontoImpuesto = preDet.MontoImpuesto
                    PreventaDetalle.SubtotalGravado = preDet.SubtotalGravado
                    PreventaDetalle.SubTotalExcento = preDet.SubTotalExcento
                    PreventaDetalle.SubTotal = preDet.SubTotal
                    PreventaDetalle.Devoluciones = preDet.Devoluciones
                    PreventaDetalle.NumeroEntrega = preDet.NumeroEntrega
                    PreventaDetalle.MaxDescuento = preDet.MaxDescuento
                    PreventaDetalle.TipoCambioValorCompra = preDet.TipoCambioValorCompra
                    PreventaDetalle.CodMonedaVenta = preDet.CodMonedaVenta
                    PreventaDetalle.Lote = preDet.Lote
                    PreventaDetalle.CantVet = preDet.CantVet
                    PreventaDetalle.CantBod = preDet.CantBod
                    PreventaDetalle.Disminuye = preDet.Disminuye
                    PreventaDetalle.Empaquetado = preDet.Empaquetado
                    PreventaDetalle.NotaPantalla = preDet.NotaPantalla
                    PreventaDetalle.IdBodega = preDet.IdBodega
                    PreventaDetalle.Regalias = preDet.Regalias
                    PreventaDetalle.CostoReal = preDet.CostoReal
                    PreventaDetalle.IdTipoExoneracion = preDet.IdTipoExoneracion
                    PreventaDetalle.NumeroDocumento = preDet.NumeroDocumento
                    PreventaDetalle.FechaEmision = preDet.FechaEmision
                    PreventaDetalle.PorcentajeCompra = preDet.PorcentajeCompra
                    PreventaDetalle.Entregado = preDet.Entregado
                    PreventaDetalle.Entregados = preDet.Entregados
                    PreventaDetalle.IdSerie = preDet.IdSerie

                    Preventa.PreVentasDetalles.Add(PreventaDetalle)
                Next

                Resultado.Add(Preventa)
            Next

            Return Resultado
        End Function

        Public Function Facturar_Preventa(IdPreventa As Long, Tipo As String, IdUsuario As String, IdEmpresa As Integer) As String
            Return Me.db.Facturar_PreVenta(IdPreventa, Tipo, IdUsuario, IdEmpresa)
        End Function

        Public Function Generar_ReciboDinero(IdPreAbono As Long, IdUsuario As String, IdEmpresa As Integer) As String
            Return Me.db.Generar_ReciboDinero(IdPreAbono, IdUsuario, IdEmpresa)
        End Function

        Public Function Apartar_Preventa(IdPreventa As Long, IdUsuario As String, IdEmpresa As Integer, MontoInicial As Double) As String
            Return Me.db.Apartar_Preventa(IdPreventa, IdUsuario, IdEmpresa, MontoInicial)
        End Function

        Public Function InsertarAbonoReintegro(preventa As Datos.Models.Abonoreintegro) As String
            Return Me.db.InsertarAbonoReintegro(preventa)
        End Function

        Public Function Crear(preventa As Datos.Models.PreVenta) As String
            Return Me.db.Crear(preventa)
        End Function

        Public Function Editar(id As Long, preventa As Datos.Models.PreVenta) As String
            Return Me.db.Editar(id, preventa)
        End Function

        Public Function BuscarFichasActivas() As List(Of Datos.Models.ViewPreventasActiva)
            Return Me.db.FichasActivas
        End Function

        Public Function InactivarFicha(id As Long, tipo As String, puntodeVenta As String) As String
            Return Me.db.InactivarFicha(id, tipo, puntodeVenta)
            'Private Sub btnInactivar_Click(sender As Object, e As EventArgs) Handles btnInactivar.Click
            '    Try
            '        If Me.viewFichasActivas.RowCount > 0 Then
            '            Dim frm As New frmVersionCompleta
            '            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            '                Dim id As String = Me.viewFichasActivas.Item("Id", Me.viewFichasActivas.CurrentRow.Index).Value
            '                Dim base As String = Me.viewFichasActivas.Item("BasedeDatos", Me.viewFichasActivas.CurrentRow.Index).Value
            '                Dim tipo As String = Me.viewFichasActivas.Item("Tipo", Me.viewFichasActivas.CurrentRow.Index).Value
            '                If IsNumeric(id) = True Then
            '                    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '                    If tipo = "ABO" Then
            '                        db.Ejecutar("Update " & base & ".dbo.PreAbonocCobrar Set Estado = 'Inactivada' Where Id_Recibo = " & id, CommandType.Text)
            '                    Else
            '                        db.Ejecutar("Update " & base & ".dbo.PreVentas Set Estado = 'Inactivada' Where Id = " & id, CommandType.Text)
            '                    End If
            '                    Me.buscarFichasActivas()
            '                End If
            '            End If
            '        End If
            '    Catch ex As Exception
            '    End Try
            'End Sub

        End Function

        Public Sub GeneraVenta(id_preventa As Integer,
                            puntodeventa As String,
                            tipo As String,
                            id_usuario As String,
                            ByRef id_factura As Integer,
                            ByRef num_factura As Integer)


            'trans.SetParametro("@IdPreventa", Me.Id_PreVenta)
            'trans.SetParametro("@PuntodeVenta", Me.PuntodeVenta)
            'trans.SetParametro("@Tipo", Me.TipoFactura)
            'trans.SetParametro("@Id_Usuario", Me.Id_Usuario)
            'trans.AddParametrosSalidaInt("@Id_Factura", Id_Factura)
            'trans.AddParametrosSalidaInt("@Num_Factura", Num_Factura)
            'trans.Ejecutar("Facturar_PreVenta", Id_Factura, 4, Num_Factura, 5)


        End Sub

        Public Sub GeneraAbonoFirmadoContado(ByRef id As Integer,
                                            id_factura As Integer,
                                            fechaAbono As Date,
                                            montoAbono As Decimal)

            'trans.AddParametroSalida("@Id", Me.Num_Factura)
            'trans.SetParametro("@IdFactura", Me.IdFacturaAbono)
            'trans.SetParametro("@Fecha", Me.FechaAbono)
            'trans.SetParametro("@Monto", Me.MontoAbono)
            'trans.Ejecutar("InsertAbonoReintegro", Num_Factura, 0)

        End Sub

        Public Sub GenerarReciboCxC(id_preventa As Integer,
                          id_usuario As String,
                          puntodeventa As String,
                          ByRef idrecibo As Integer,
                          ByRef numrecibo As Integer)

            'trans.SetParametro("@IdPreRecibo", Me.Id_PreVenta)
            'trans.SetParametro("@Id_Usuario", Me.Id_Usuario)
            'trans.SetParametro("@PuntodeVenta", Me.PuntodeVenta)
            'trans.AddParametrosSalidaInt("@IdRecibo", Me.IdRecibo)
            'trans.AddParametrosSalidaInt("@NumRecibo", Me.NumRecibo)
            'trans.Ejecutar("Generar_ReciboDinero", Me.IdRecibo, 3, Me.NumRecibo, 4)
            'Me.Num_Factura = Me.NumRecibo

        End Sub

        Public Sub GenerarApartado(id_preventa As Integer,
                                  fechaVence As Date,
                                  montoApartado As Decimal,
                                  puntodeVenta As String,
                                  id_usuario As String,
                                  ByRef id_Apartado As Integer,
                                  ByRef id_AbonoApartado As Integer)

            'Me.Id_Apartado = 0
            'trans.SetParametro("@IdPreventa", Me.Id_PreVenta)
            'trans.SetParametro("@FechaVence", Me.FechaVence.ToShortDateString)
            'trans.SetParametro("@MontoAbono", Me.MontoApartado)
            'trans.SetParametro("@PuntodeVenta", Me.PuntodeVenta)
            'trans.SetParametro("@Id_Usuario", Me.Id_Usuario)
            'trans.AddParametrosSalidaInt("@IdApartado", Id_Apartado)
            'trans.AddParametrosSalidaInt("@IdAbonoApartado", Id_AbonoApartado)
            'trans.Ejecutar("Apartar_PreVenta", Id_Apartado, 5, Me.Id_AbonoApartado, 6)
            'Me.Num_Factura = Id_Apartado

        End Sub

    End Class
End Namespace