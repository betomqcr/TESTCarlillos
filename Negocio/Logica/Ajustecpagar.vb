Namespace Logica
    Public Class Ajustecpagar

        '***************************************************************saldo
        'Public Property Proveedor As New Logica.Proveedores
        'Public Property Moneda As New Logica.Monedas

        Private db As Datos.Class.AjustesPagar

        Sub New()
            Me.db = New Datos.Class.AjustesPagar
        End Sub

        Public Function Buscar(porId As Boolean, filtro As String) As List(Of Datos.Models.Ajustescpagar)
            Dim datos As New List(Of Datos.Models.Ajustescpagar)
            datos = db.ObtenerAjustesPagar(porId, filtro)

            Dim Resultado As New List(Of Datos.Models.Ajustescpagar)
            For Each ajuste As Datos.Models.Ajustescpagar In datos
                Dim Ajustescpagar As New Datos.Models.Ajustescpagar
                Ajustescpagar.IdAjuste = ajuste.IdAjuste
                Ajustescpagar.AjusteNo = ajuste.AjusteNo
                Ajustescpagar.Tipo = ajuste.Tipo
                Ajustescpagar.CodProveedor = ajuste.CodProveedor
                Ajustescpagar.NombreProveedor = ajuste.NombreProveedor
                Ajustescpagar.Fecha = ajuste.Fecha
                Ajustescpagar.SaldoPrev = ajuste.SaldoPrev
                Ajustescpagar.Monto = ajuste.Monto
                Ajustescpagar.SaldoAct = ajuste.SaldoAct
                Ajustescpagar.Observaciones = ajuste.Observaciones
                Ajustescpagar.Anula = ajuste.Anula
                Ajustescpagar.CodUsuario = ajuste.CodUsuario
                Ajustescpagar.Contabilizado = ajuste.Contabilizado
                Ajustescpagar.CodMoneda = ajuste.CodMoneda
                Ajustescpagar.Asiento = ajuste.Asiento
                Ajustescpagar.FechaEntrada = ajuste.FechaEntrada
                Ajustescpagar.IdSucursal = ajuste.IdSucursal

                For Each detAjuste As Datos.Models.DetalleAjustescPagar In Me.db.ObtenerDetalles(Ajustescpagar.IdAjuste)
                    Dim DetalleAjuste As New Datos.Models.DetalleAjustescPagar
                    DetalleAjuste.IdDetalleAjustecPagar = detAjuste.IdDetalleAjustecPagar
                    DetalleAjuste.IdAjustecPagar = detAjuste.IdAjustecPagar
                    DetalleAjuste.Factura = detAjuste.Factura
                    DetalleAjuste.Tipo = detAjuste.Tipo
                    DetalleAjuste.Monto = detAjuste.Monto
                    DetalleAjuste.SaldoAnt = detAjuste.SaldoAnt
                    DetalleAjuste.Ajuste = detAjuste.Ajuste
                    DetalleAjuste.AjusteSuMoneda = detAjuste.AjusteSuMoneda
                    DetalleAjuste.SaldoAjustado = detAjuste.SaldoAjustado
                    DetalleAjuste.Observaciones = detAjuste.Observaciones
                    DetalleAjuste.TipoNota = detAjuste.TipoNota
                    DetalleAjuste.IdCompra = detAjuste.IdCompra
                    DetalleAjuste.CuentaContable = detAjuste.CuentaContable
                    DetalleAjuste.DescripcionCuentaContable = detAjuste.DescripcionCuentaContable
                    Ajustescpagar.DetalleAjustescPagars.Add(DetalleAjuste)
                Next

                Resultado.Add(Ajustescpagar)
            Next

            Return Resultado
        End Function

        Public Function BuscarDetalle(Id As Long) As List(Of Datos.Models.DetalleAjustescPagar)
            Return db.ObtenerAjustesPagar(Id)
            'identificador = CDbl(Fx.Buscar_X_Descripcion_Fecha("Select cast(ID_Ajuste as varchar) as Numero , Nombre_Proveedor, Fecha from ajustescpagar Order by Fecha DESC", "Nombre_Proveedor", "Fecha", "Buscar Ajuste de Cuenta", Me.SqlConnection1.ConnectionString))
            'buscando = True
            'If identificador = 0.0 Then ' si se dio en el boton de cancelar
            '    Me.buscando = False
            '    Exit Sub
            'End If

        End Function


        Public Function Crear(ajustecpagar As Datos.Models.Ajustescpagar) As String

            Try
                For Each d As Datos.Models.DetalleAjustescPagar In ajustecpagar.DetalleAjustescPagars

                Next

                Return Me.db.CrearAjustesPagar(ajustecpagar)
            Catch ex As Exception

            End Try

            'Valida
            'If Me.BindingContext(Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Count = 0 Then
            '    MsgBox("No se puede registrar un ajuste sin detalle", MsgBoxStyle.Critical)
            '    Me.ToolBar1.Buttons(2).Enabled = False
            '    Exit Function
            'End If


            'For i = 0 To Me.BindingContext(DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Count - 1
            '    Me.BindingContext(DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Position = i
            '    If Me.BindingContext(DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Current("Saldo_Ajustado") = 0 Then
            '        FactTemp = Me.BindingContext(DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Current("Factura")
            '        Proveedor = Me.BindingContext(DsAjustePagar, "Ajustescpagar").Current("Cod_Proveedor")
            '        Funciones.UpdateRecords("Compras", " FacturaCancelado = 1 ", " Factura =" & FactTemp & "AND TipoCompra ='CRE' and CodigoProv =" & Proveedor, "SeePos")
            '    End If
            'Next i
            'txtNum_Ajuste.Text = Numero_de_Ajuste()
            'Me.BindingContext(DsAjustePagar, "ajustescpagar").EndCurrentEdit()
            'Me.BindingContext(Me.DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").EndCurrentEdit()


            'Me.daAjustecPagar.InsertCommand.Transaction = Trans
            'Me.daAjustecPagar.UpdateCommand.Transaction = Trans
            'Me.daAjustecPagar.DeleteCommand.Transaction = Trans

            'Me.daDetallecPagar.InsertCommand.Transaction = Trans
            'Me.daDetallecPagar.UpdateCommand.Transaction = Trans
            'Me.daDetallecPagar.DeleteCommand.Transaction = Trans

            'Me.daAjustecPagar.Update(Me.DsAjustePagar, "Ajustescpagar")
            'Me.daDetallecPagar.Update(Me.DsAjustePagar, "Detalle_AjustescPagar")

        End Function

        Public Function Anular(Id As Long) As String
            Dim res As String = Me.db.AnularAjustesPagar(Id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
            '        Function Registrar_Anulacion_Ajuste() As Boolean
            '    Dim i As Long
            '    Dim Facttem As Double
            '    Dim Funciones As New Conexion
            '    If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
            '    Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
            '    Try
            '        Me.daAjustecPagar.UpdateCommand.Transaction = Trans

            '        Me.daAjustecPagar.Update(Me.DsAjustePagar, "Ajustescpagar")
            '        For i = 0 To Me.BindingContext(DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Count - 1
            '            Me.BindingContext(DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Position = i
            '            Facttem = Me.BindingContext(DsAjustePagar, "Ajustescpagar.AjustescpagarDetalle_AjustescPagar").Current("Factura")
            '            Funciones.UpdateRecords("Compras", "FacturaCancelado = 0", "Factura =" & Facttem & "AND TIPOCOMPRA ='CRE'", strModulos)
            '        Next i
            '        Trans.Commit()
            '        Return True
            '    Catch ex As Exception
            '        Trans.Rollback()
            '        MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            '        Me.ToolBar1.Buttons(3).Enabled = True
            '        Return False
            '    End Try
            'End Function

        End Function

    End Class

End Namespace
