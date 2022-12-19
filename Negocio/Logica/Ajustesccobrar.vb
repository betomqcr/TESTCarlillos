Namespace Logica
    Public Class Ajustesccobrar

        'Public Property Ventas As New Logica.Ventas
        'Public Property Clientes As New Logica.Clientes
        'Public Property Moneda As New Logica.Monedas

        Private db As Datos.Class.AjustesCobrar

        Sub New()
            Me.db = New Datos.Class.AjustesCobrar
        End Sub

        Public Function Crear(ajustesccobrar As Datos.Models.Ajustesccobrar) As String

            Try

                For Each d As Datos.Models.DetalleAjustesccobrar In ajustesccobrar.DetalleAjustesccobrars

                Next

                Return Me.db.CrearAjusteCobro(ajustesccobrar)

            Catch ex As Exception

            End Try

            'For i = 0 To BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Count - 1
            '    BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Position = i
            '    If BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Current("Saldo_Ajustado") = 0 Then
            '        FactTemp = BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Current("Factura")
            '        Funciones.UpdateRecords("Ventas", "FacturaCancelado = 1", "Num_Factura =" & FactTemp & "AND TIPO ='" & BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Current("Tipo") & "'")
            '    End If
            'Next

            'txtNum_Ajuste.Text = Numero_de_Ajuste()
            'BindingContext(AjusteCxC1, "ajustesccobrar").EndCurrentEdit()
            'daAjuste.Update(AjusteCxC1, "ajustesccobrar")
            'daDetalleAjuste.Update(AjusteCxC1, "detalle_ajustesccobrar")

        End Function

        Public Function Buscar(porId As Boolean, filtro As String) As List(Of Datos.Models.Ajustesccobrar)
            Dim datos As New List(Of Datos.Models.Ajustesccobrar)
            datos = db.ObtenerAjusteCobro(porId, filtro)

            Dim Resultado As New List(Of Datos.Models.Ajustesccobrar)
            For Each ajuste As Datos.Models.Ajustesccobrar In datos
                Dim Ajusteccobrar As New Datos.Models.Ajustesccobrar
                Ajusteccobrar.IdAjuste = ajuste.IdAjuste
                Ajusteccobrar.AjusteNo = ajuste.AjusteNo
                Ajusteccobrar.Tipo = ajuste.Tipo
                Ajusteccobrar.CodCliente = ajuste.CodCliente
                Ajusteccobrar.NombreCliente = ajuste.NombreCliente
                Ajusteccobrar.Fecha = ajuste.Fecha
                Ajusteccobrar.SaldoPrev = ajuste.SaldoPrev
                Ajusteccobrar.Monto = ajuste.Monto
                Ajusteccobrar.SaldoAct = ajuste.SaldoAct
                Ajusteccobrar.Observaciones = ajuste.Observaciones
                Ajusteccobrar.Anula = ajuste.Anula
                Ajusteccobrar.CodUsuario = ajuste.CodUsuario
                Ajusteccobrar.Contabilizado = ajuste.Contabilizado
                Ajusteccobrar.CodMoneda = ajuste.CodMoneda
                Ajusteccobrar.Asiento = ajuste.Asiento
                Ajusteccobrar.IdSucursal = ajuste.IdSucursal

                For Each detalle As Datos.Models.DetalleAjustesccobrar In Me.db.ObtenerDetallesAjustescCobrar(Ajusteccobrar.IdAjuste)
                    Dim DetalleAjusteccobrar As New Datos.Models.DetalleAjustesccobrar
                    DetalleAjusteccobrar.IdDetalleAjustecCobrar = detalle.IdDetalleAjustecCobrar
                    DetalleAjusteccobrar.IdAjustecCobrar = detalle.IdAjustecCobrar
                    DetalleAjusteccobrar.Factura = detalle.Factura
                    DetalleAjusteccobrar.Tipo = detalle.Tipo
                    DetalleAjusteccobrar.Monto = detalle.Monto
                    DetalleAjusteccobrar.SaldoAnt = detalle.SaldoAnt
                    DetalleAjusteccobrar.Ajuste = detalle.Ajuste
                    DetalleAjusteccobrar.AjusteSuMoneda = detalle.AjusteSuMoneda
                    DetalleAjusteccobrar.SaldoAjustado = detalle.SaldoAjustado
                    DetalleAjusteccobrar.Observaciones = detalle.Observaciones
                    DetalleAjusteccobrar.TipoNota = detalle.TipoNota
                    DetalleAjusteccobrar.CuentaContable = detalle.CuentaContable
                    DetalleAjusteccobrar.IdCuentaC = detalle.IdCuentaC

                    Ajusteccobrar.DetalleAjustesccobrars.Add(DetalleAjusteccobrar)
                Next

                Resultado.Add(Ajusteccobrar)
            Next

            Return Resultado
        End Function

        Public Function Anular(Id As Long) As String
            Dim res As String = Me.db.AnularAjusteCobro(Id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
            'Function Registrar_Anulacion_Ajuste() As Boolean
            '    Dim i As Long
            '    Dim Facttem As Double
            '    Dim Funciones As New Conexion
            '    If SqlConnection1.State <> SqlConnection1.State.Open Then SqlConnection1.Open()
            '    Dim Trans As SqlTransaction = SqlConnection1.BeginTransaction
            '    Try
            '        SqlUpdateCommand1.Transaction = Trans
            '        daAjuste.Update(AjusteCxC1, "ajustesccobrar")
            '        For i = 0 To BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Count - 1
            '            BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Position = i
            '            Facttem = BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Current("Factura")
            '            Funciones.UpdateRecords("Ventas", "FacturaCancelado = 0", "Num_Factura =" & Facttem & "AND TIPO ='" & BindingContext(AjusteCxC1, "ajustesccobrar.ajustesccobrardetalle_ajustesccobrar").Current("Tipo") & "'")
            '        Next
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
