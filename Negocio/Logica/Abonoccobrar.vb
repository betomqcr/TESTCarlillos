Namespace Logica
    Public Class Abonoccobrar

        'Public Property AperturaCaja As New Logica.AperturaCaja
        'Public Property Moneda As New Logica.Monedas
        'Public Property Clientes As New Logica.Clientes

        Private db As Datos.Class.AbonosCobros

        Sub New()
            Me.db = New Datos.Class.AbonosCobros
        End Sub

        Public Function Crear(abonoccobrar As Datos.Models.Abonoccobrar) As String

            'como se hacen las transacciones?

            Try

                For Each d As Datos.Models.DetalleAbonoccobrar In abonoccobrar.DetalleAbonoccobrars
                    '
                Next

                Return Me.db.CrearAbonoCobro(abonoccobrar)
            Catch ex As Exception

            End Try
        End Function

        Public Function Buscar(porId As Boolean, Filtro As String) As List(Of Datos.Models.Abonoccobrar)
            Dim datos As New List(Of Datos.Models.Abonoccobrar)
            datos = db.ObtenerAbonocCobrar(porId, Filtro)

            Dim Resultado As New List(Of Datos.Models.Abonoccobrar)
            For Each abono As Datos.Models.Abonoccobrar In datos
                Dim abonoccobrar As New Datos.Models.Abonoccobrar
                abonoccobrar.IdRecibo = abono.IdRecibo
                abonoccobrar.NumRecibo = abono.NumRecibo
                abonoccobrar.CodCliente = abono.CodCliente
                abonoccobrar.NombreCliente = abono.NombreCliente
                abonoccobrar.SaldoCuenta = abono.SaldoCuenta
                abonoccobrar.Monto = abono.Monto
                abonoccobrar.SaldoActual = abono.SaldoActual
                abonoccobrar.Fecha = abono.Fecha
                abonoccobrar.Observaciones = abono.Observaciones
                abonoccobrar.Anula = abono.Anula
                abonoccobrar.CedUsuario = abono.CedUsuario
                abonoccobrar.Contabilizado = abono.Contabilizado
                abonoccobrar.Asiento = abono.Asiento
                abonoccobrar.CodMoneda = abono.CodMoneda
                abonoccobrar.Cheque = abono.Cheque
                abonoccobrar.NumCaja = abono.NumCaja
                abonoccobrar.Banco = abono.Banco
                abonoccobrar.NumApertura = abono.NumApertura
                abonoccobrar.EstadoEnvio = abono.EstadoEnvio
                abonoccobrar.IdSucursal = abono.IdSucursal


                For Each detalle As Datos.Models.DetalleAbonoccobrar In Me.db.ObtenerDetalleAbonoscCobrar(abono.IdRecibo)
                    Dim DetalleAbonoccobrar As New Datos.Models.DetalleAbonoccobrar
                    DetalleAbonoccobrar.Consecutivo = detalle.Consecutivo
                    DetalleAbonoccobrar.IdRecibo = detalle.IdRecibo
                    DetalleAbonoccobrar.Factura = detalle.Factura
                    DetalleAbonoccobrar.Tipo = detalle.Tipo
                    DetalleAbonoccobrar.Fecha = detalle.Fecha
                    DetalleAbonoccobrar.Monto = detalle.Monto
                    DetalleAbonoccobrar.SaldoAnt = detalle.SaldoAnt
                    DetalleAbonoccobrar.Intereses = detalle.Intereses
                    DetalleAbonoccobrar.Abono = detalle.Abono
                    DetalleAbonoccobrar.AbonoSuMoneda = detalle.AbonoSuMoneda
                    DetalleAbonoccobrar.Saldo = detalle.Saldo
                    abonoccobrar.DetalleAbonoccobrars.Add(DetalleAbonoccobrar)
                Next

                Resultado.Add(abonoccobrar)
            Next

            Return Resultado
        End Function

        Public Function Anular(Id As Long) As String
            Dim res As String = Me.db.Anular(Id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If



            '    Function Registrar_Anulacion_Venta() As Boolean
            '    Dim i As Long
            '    Dim Facttem As Double
            '    Dim Funciones As New Conexion
            '    If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()
            '    Dim Trans As SqlTransaction = SqlConnection1.BeginTransaction
            '    Try
            '        SqlUpdateCommand1.Transaction = Trans
            '        adAbonos.Update(DsRecibos1, "abonoccobrar")
            '        For i = 0 To BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Count - 1
            '            BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Position = i
            '            Facttem = BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Factura")
            '            Funciones.UpdateRecords("Ventas", "FacturaCancelado = 0", "Num_Factura =" & Facttem & "and Tipo = '" & BindingContext(DsRecibos1, "abonoccobrar.abonoccobrardetalle_abonoccobrar").Current("Tipo") & "'")
            '        Next
            '        Funciones.UpdateRecords("OpcionesDePago", "FormaPago = 'ANU'", "(Documento = " & txtNum_Recibo.Text & ") AND (TipoDocumento = 'ABO')")
            '        Trans.Commit()
            '        Return True

            '    Catch ex As Exception
            '        Trans.Rollback()
            '        MsgBox(ex.Message)
            '        ToolBar1.Buttons(3).Enabled = True
            '        Return False
            '    End Try
            'End Function
        End Function

    End Class

End Namespace
