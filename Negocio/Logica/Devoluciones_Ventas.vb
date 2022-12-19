Namespace Logica
    Public Class Devoluciones_Ventas

        Private db As Datos.Class.devoluciones_ventas

        Sub New()
            Me.db = New Datos.Class.devoluciones_ventas
        End Sub

        Public Function Buscar(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.DevolucionesVenta)
            Dim datos As New List(Of Datos.Models.DevolucionesVenta)
            datos = db.Buscar(porNombre, Filtro)

            Dim Resultado As New List(Of Datos.Models.DevolucionesVenta)
            For Each devo As Datos.Models.DevolucionesVenta In datos
                Dim Devolucion As New Datos.Models.DevolucionesVenta
                Devolucion.Devolucion = devo.Devolucion
                Devolucion.IdFactura = devo.IdFactura
                Devolucion.SaldoAntFact = devo.SaldoAntFact
                Devolucion.SubTotalGravado = devo.SubTotalGravado
                Devolucion.SubTotalExcento = devo.SubTotalExcento
                Devolucion.Descuento = devo.Descuento
                Devolucion.Impuesto = devo.Impuesto
                Devolucion.Monto = devo.Monto
                Devolucion.Fecha = devo.Fecha
                Devolucion.Contabilizado = devo.Contabilizado
                Devolucion.NumeroAsiento = devo.NumeroAsiento
                Devolucion.Anulado = devo.Anulado
                Devolucion.CedulaUsuario = devo.CedulaUsuario
                Devolucion.CodMoneda = devo.CodMoneda
                Devolucion.Transporte = devo.Transporte
                Devolucion.ContabilizadoCosto = devo.ContabilizadoCosto
                Devolucion.NumeroAsientoCosto = devo.NumeroAsientoCosto
                Devolucion.Caja = devo.Caja
                Devolucion.Consecutivo = devo.Consecutivo
                Devolucion.Enviadodgt = devo.Enviadodgt
                Devolucion.Estadodgt = devo.Estadodgt
                Devolucion.Consecutivodgt = devo.Consecutivodgt
                Devolucion.Clavedgt = devo.Clavedgt
                Devolucion.MontoDevolucion = devo.MontoDevolucion
                Devolucion.NumApertura = devo.NumApertura
                Devolucion.UsuarioRecibio = devo.UsuarioRecibio
                Devolucion.NotasDevolucion = devo.NotasDevolucion
                Devolucion.IdSucursal = devo.IdSucursal


                For Each detalle As Datos.Models.ArticulosVentasDevuelto In Me.db.BuscarDetalle(Devolucion.Devolucion)
                    Dim ArticulosDevueltos As New Datos.Models.ArticulosVentasDevuelto
                    ArticulosDevueltos.Consecutivo = detalle.Consecutivo
                    ArticulosDevueltos.Devolucion = detalle.Devolucion
                    ArticulosDevueltos.Codigo = detalle.Codigo
                    ArticulosDevueltos.Descripcion = detalle.Descripcion
                    ArticulosDevueltos.Cantidad = detalle.Cantidad
                    ArticulosDevueltos.CantVet = detalle.CantVet
                    ArticulosDevueltos.CantBod = detalle.CantBod
                    ArticulosDevueltos.PrecioCosto = detalle.PrecioCosto
                    ArticulosDevueltos.PrecioBase = detalle.PrecioBase
                    ArticulosDevueltos.PrecioFlete = detalle.PrecioFlete
                    ArticulosDevueltos.PrecioOtros = detalle.PrecioOtros
                    ArticulosDevueltos.PrecioUnit = detalle.PrecioUnit
                    ArticulosDevueltos.Descuento = detalle.Descuento
                    ArticulosDevueltos.MontoDescuento = detalle.MontoDescuento
                    ArticulosDevueltos.Impuesto = detalle.Impuesto
                    ArticulosDevueltos.MontoImpuesto = detalle.MontoImpuesto
                    ArticulosDevueltos.SubtotalGravado = detalle.SubtotalGravado
                    ArticulosDevueltos.SubTotalExcento = detalle.SubTotalExcento
                    ArticulosDevueltos.SubTotal = detalle.SubTotal
                    ArticulosDevueltos.IdArtVenta = detalle.IdArtVenta
                    ArticulosDevueltos.IdArticuloV = detalle.IdArticuloV
                    ArticulosDevueltos.Devuelto = detalle.Devuelto
                    ArticulosDevueltos.Empaquetado = detalle.Empaquetado
                    ArticulosDevueltos.Recibido = detalle.Recibido
                    ArticulosDevueltos.IdSucursal = detalle.IdSucursal

                    Devolucion.ArticulosVentasDevueltos.Add(ArticulosDevueltos)
                Next

                Resultado.Add(Devolucion)
            Next

            Return Resultado
        End Function

        Public Function Anular(id As Integer) As String
            Dim res As String = Me.db.Anular(id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
            '    Function Anular_Detalle(ByVal Id As Long) As Boolean
            '    '--------------------------------------------------------------------------------------------
            '    ' SE DISPARA DESENCADENADOR QUE REGISTRA EN EL KARDEX LA ANULACION DE LA DEVOLUCION         ' 
            '    ' SE PROCEDE A RECORRER Y ACTUALIZAR LA EXISTENCIA DE INVENTARIO Y A REVERTIR EL CONTADOR   '
            '    ' DE DEVOLUCIONES DE LA TABLA DE VENTAS_DETALLE.                                            '
            '    ' JSA : 31102006 2350                                                                       '
            '    '--------------------------------------------------------------------------------------------
            '    Try
            '        Dim i As Integer
            '        Dim Funciones As New Conexion
            '        For i = 0 To Me.DataSetDevolucionVentas1.articulos_ventas_devueltos.Count - 1
            '            Funciones.UpdateRecords("Ventas_Detalle", "Devoluciones = Devoluciones -" & Me.DataSetDevolucionVentas1.articulos_ventas_devueltos.Rows(i).Item("Cantidad"), "Id_Factura =" & Id & " AND id_venta_detalle =" & Me.DataSetDevolucionVentas1.articulos_ventas_devueltos.Rows(i).Item("id_art_venta"))
            '            '**************************************************************
            '            'JCGA 02 DE AGOSTO 2007, PARA ACTUALIZAR LOS DATOS EN EL INVENTARIO SE ESTABA TOMANDO A LA VARIABLE ID 
            '            'EN VEZ DEL CODIGO DEL ARTICULO.
            '            'dim CodigoArticulo as Long = Me.DataSetDevolucionVentas1.articulos_ventas_devueltos.Rows(i).Item("Codigo")
            '            'Funciones.UpdateRecords("Inventario", "Existencia = Existencia -" & Me.DataSetDevolucionVentas1.articulos_ventas_devueltos.Rows(i).Item("Cantidad"), "Codigo =" & CodigoArticulo)
            '            '**************************************************************
            '        Next
            '        Return True

            '    Catch ex As SystemException
            '        MsgBox(ex.Message)
            '        Return False
            '    End Try
            'End Function

            'Function Registrar_Anulacion_Devolucion() As Boolean
            '    Try
            '        Dim Funciones As New Conexion
            '        'Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Anulado") = True
            '        'Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").EndCurrentEdit()
            '        'Me.AdapterDevoluciones.Update(Me.DataSetDevolucionVentas1, "devoluciones_ventas")
            '        Funciones.UpdateRecords("devoluciones_ventas", "Anulado = 1", "Devolucion =" & Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion"))

            '        Return True
            '    Catch ex As SystemException
            '        MsgBox(ex.Message)
            '        Me.ToolBar1.Buttons(3).Enabled = True
            '        Return False
            '    End Try
            'End Function

        End Function

        Public Function Crear(devoluciones_ventas As Datos.Models.DevolucionesVenta) As String
            Return Me.db.Crear(devoluciones_ventas)
            'If CadenaConexionSeePOS.ToLower.IndexOf("taller") > 0 Then
            '    Me.AdapterOpcionesPago.InsertCommand.CommandText = Me.AdapterOpcionesPago.InsertCommand.CommandText.Replace("OpcionesDePago", "SeePOs.dbo.OpcionesDePago")
            'End If

            'Dim REST As Integer
            'Dim REST2 As Integer
            'Dim NumDevo As Long
            'Dim MontoDevoluciones As Double
            'Me.ToolBarEliminar.Enabled = False
            'Me.MontoDevolucion = Math.Round(CDbl(Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Monto").ToString), 2)
            'If Me.PasaFirmadoContado(Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Id"), MontoDevolucion) = False Then
            '    Exit Sub
            'End If
            'If Me.MontoDevolucion > 0 Then
            '    Me.esFirmadoContado = False
            'Else
            '    Me.esFirmadoContado = True
            'End If

            ''**********SI HAY ARTICULOS DEVUELTOS***********
            'If Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Count = 0 And TextEdit7.EditValue = 0 Then
            '    MsgBox("Es necesario que almenos exista un item en el area de detalle " & vbCrLf & "para efectuar el registro de la devolución o un monto por concepto de Transporte..")
            '    Exit Sub
            'ElseIf Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Count = 0 And TextEdit7.EditValue <> 0 Then
            '    If MsgBox("Desea proceder a registrar esta devolución sin haber definido detalle y solo por el monto de Transporte ...?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            'End If

            'NumDevo = txtNum_Devo.Text
            ''*****************SI LA VENTA ES DE CREDITO**************
            'If Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Tipo") = "CRE" Or Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Tipo") = "TCR" Or Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Tipo") = "MCR" Then
            '    Dim SaldoFacturaT As Double
            '    Dim codcliente As Double = Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("cod_cliente")
            '    Dim cConexion As New Conexion
            '    SaldoFacturaT = cConexion.SlqExecuteScalar(cConexion.Conectar, "SELECT dbo.SaldoFactura_Monto(GETDATE()," & TextNumero.Text & ",'" & ComboTipo.Text & "', " & codcliente & ", " & Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Total") & ") AS Saldo")

            '    Dim saldo As Decimal = SaldoFacturaT - Math.Round(CDbl(Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Monto").ToString), 2)
            '    If saldo < 0 Then
            '        Me.MontoDevolucion = (saldo * -1)

            '        Dim frm As New frmOpcionCaja
            '        frm.ShowDialog()
            '        Me.Caja_Factura = frm.Caja
            '        '*****************************************SELECCIONA CAJA **********************************************************
            '        If CajaAbierta(Caja_Factura) = False Then
            '            MsgBox("La caja #" & Caja_Factura & " no esta abierta, no sepuede realizar la operacion!!!", MsgBoxStyle.Exclamation, Text)
            '            Exit Sub
            '        End If

            '    Else
            '        Me.MontoDevolucion = 0
            '    End If

            '    cConexion.DesConectar(cConexion.sQlconexion)
            '    If (BindingContext(DataSetDevolucionVentas1, "Ventas").Current("Tipo") = "CRE" Or BindingContext(DataSetDevolucionVentas1, "Ventas").Current("Tipo") = "TCR") And SaldoFacturaT = 0 Then
            '        MontoDevoluciones = cConexion.SlqExecuteScalar(cConexion.Conectar, "SELECT isnull(SUM(Monto),0) as TotalMonto FROM Devoluciones_Ventas WHERE Id_Factura =" & Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Id") & " AND Anulado = 0")
            '        cConexion.DesConectar(cConexion.sQlconexion)
            '    End If
            '    If Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Monto") = SaldoFacturaT Then
            '        Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("FacturaCancelado") = True
            '        Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").EndCurrentEdit()
            '    End If
            '    '******************SI LA VENTA NO ES DE CREDITO**************
            'Else
            '    MontoDevoluciones = CConexion.SlqExecuteScalar(CConexion.Conectar, "SELECT ISNULL(SUM(Monto), 0) as TotalMonto FROM Devoluciones_Ventas WHERE Id_Factura =" & Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Id") & " AND Anulado = 0")

            '    If Math.Round(Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("Total") - Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Monto") - MontoDevoluciones, 2) = 0 Then
            '        Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").Current("FacturaCancelado") = True
            '        Me.BindingContext(Me.DataSetDevolucionVentas1, "Ventas").EndCurrentEdit()
            '    End If
            'End If

            ''******************** SI LA FACTURA ES DE CONTADO O ES DE CREDITO PERO YA SE PAGO ********************
            'If (ComboTipo.Text <> "CRE" And ComboTipo.Text <> "TCR") Or ((ComboTipo.Text = "CRE" Or ComboTipo.Text = "TCR") And CheckBox2.Checked = True) Then
            '    Try
            '        Dim frm As New frmOpcionCaja
            '        frm.ShowDialog()
            '        Me.Caja_Factura = frm.Caja
            '        '*****************************************SELECCIONA CAJA **********************************************************
            '        If CajaAbierta(Caja_Factura) = False Then
            '            MsgBox("La caja #" & Caja_Factura & " no esta abierta, no sepuede realizar la operacion!!!", MsgBoxStyle.Exclamation, Text)
            '            Exit Sub
            '        End If

            '        REST = MsgBox("Deseas devolver la siguiente cantidad --> " & Math.Round(CDbl(Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Monto").ToString), 2) & " <--", MsgBoxStyle.YesNo, "SeePos")
            '        '**************************************************************************************************************************
            '        If REST = 6 Then

            '            For i As Integer = 0 To Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Count - 1
            '                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Position = i
            '                Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").Current("Devolucion") = NumDevo
            '            Next
            '            Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas.devoluciones_ventasarticulos_ventas_devueltos").EndCurrentEdit()

            '            'validar que existan articulos por devolver
            '            If Me.TieneSaldo() = False Then
            '                MsgBox("Articulo ya fue devuelto.", MsgBoxStyle.Exclamation, "No se puede realizar la operacion")
            '                Exit Sub
            '            End If
            '            Me.AdapterDevoluciones.Update(Me.DataSetDevolucionVentas1.devoluciones_ventas)

            '            NumDevo = Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion")
            '            '================================================================================
            '            'ARTICULOS VENTAS DEVUELTOS
            '            Me.AdapterDetalleDevolucion.Update(Me.DataSetDevolucionVentas1.articulos_ventas_devueltos)
            '            '================================================================================

            '            Try
            '                '================================================================
            '                'VENTAS
            '                'AdapterVentas.Update(Me.DataSetDevolucionVentas1.Ventas)
            '                '================================================================

            '                '================================================================
            '                'VENTAS DETALLE
            '                AdapterDetalleVentas.Update(Me.DataSetDevolucionVentas1.Ventas_Detalle)
            '                '================================================================
            '            Catch ex As Exception

            '            End Try

            '            If Me.esFirmadoContado = False Then
            '                Me.InsertarOpicion_Pago()
            '            End If

            '            Me.AdapterOpcionesPago.Update(Me.DataSetDevolucionVentas1.OpcionesDePago)
            '            Me.DataSetDevolucionVentas1.AcceptChanges()

            '            Dim dbo As New GestioDatos
            '            If Me.esFirmadoContado = False Then
            '                dbo.Ejecuta("Update devoluciones_ventas set UsuarioRecibio = '" & Me.UsuarioRecibo & "', Caja = " & Me.Caja_Factura & ", Num_Apertura = " & Num_Apertura & " where Devolucion = " & Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion"))
            '            End If
            '            dbo.Ejecuta("Update devoluciones_ventas Set NotasDevolucion = '" & Me.NotasDevolucion & "', UsuarioRecibio = '" & Me.UsuarioRecibo & "', MontoDevolucion = " & Me.MontoDevolucion & " where Devolucion = " & Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion"))

            '            VolverEstadonormal()
            '            Limpiar()
            '            Me.ToolBarRegistrar.Enabled = False
            '            Me.ToolBarNuevo.Enabled = False
            '            Me.ToolBarBuscar.Enabled = False

            '            Me.ToolBarEliminar.Enabled = False
            '            Me.ToolBarImprimir.Enabled = False
            '            Me.ToolBar1.Buttons(0).Text = "Nuevo" ' cambio los iconos
            '            Me.ToolBar1.Buttons(0).ImageIndex = 0

            '            Me.txtUsuario.Enabled = True
            '            Me.txtUsuario.Focus()

            '            REST2 = MsgBox("La actualización del sistema se ejecutó con éxito" & vbCrLf & "¿ Desea que se imprima el recibo de Devolución?", MsgBoxStyle.YesNo, "Seepos")
            '            If REST2 = 6 Then
            '                imprimir(NumDevo)
            '            End If
            '            Exit Sub
            '        Else
            '            Exit Sub
            '        End If
            '        Me.ToolBarEliminar.Enabled = True

            '    Catch ex As Exception
            '        MsgBox(ex.ToString)
            '    End Try
            'End If

            ''SI LA FACTURA ES DE CREDITO 
            'If (ComboTipo.Text = "CRE" Or ComboTipo.Text = "TCR") And CheckBox2.Checked = False Then
            '    Try
            '        REST = MsgBox("Deseas devolver la siguiente cantidad --> " & Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Monto").ToString & "<--", MsgBoxStyle.YesNo, "SeePos")
            '        If REST = 6 Then

            '            Me.AdapterDevoluciones.Update(Me.DataSetDevolucionVentas1.devoluciones_ventas)
            '            NumDevo = Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion")
            '            AdapterDetalleDevolucion.Update(Me.DataSetDevolucionVentas1.articulos_ventas_devueltos)
            '            AdapterVentas.Update(Me.DataSetDevolucionVentas1.Ventas)
            '            AdapterDetalleVentas.Update(Me.DataSetDevolucionVentas1.Ventas_Detalle)

            '            Dim dbo As New GestioDatos
            '            If Me.MontoDevolucion > 0 Then
            '                Me.InsertarOpicion_Pago()
            '                dbo.Ejecuta("Update devoluciones_ventas set Caja = " & IIf(Me.Caja_Factura = 0, 1, Me.Caja_Factura) & ", Num_Apertura = " & Num_Apertura & " where Devolucion = " & Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion"))
            '                dbo.Ejecuta("Update devoluciones_ventas Set MontoDevolucion = " & Me.MontoDevolucion & " where Devolucion = " & Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion"))
            '            End If

            '            dbo.Ejecuta("Update devoluciones_ventas Set NotasDevolucion = '" & Me.NotasDevolucion & "', UsuarioRecibio = '" & Me.UsuarioRecibo & "' where Devolucion = " & Me.BindingContext(Me.DataSetDevolucionVentas1, "devoluciones_ventas").Current("Devolucion"))

            '            Me.AdapterOpcionesPago.Update(Me.DataSetDevolucionVentas1.OpcionesDePago)
            '            Me.DataSetDevolucionVentas1.AcceptChanges()

            '            VolverEstadonormal()
            '            Limpiar()
            '            Me.ToolBarRegistrar.Enabled = False
            '            Me.ToolBarNuevo.Enabled = True
            '            Me.ToolBarBuscar.Enabled = True
            '            Me.ToolBarEliminar.Enabled = False
            '            Me.ToolBarImprimir.Enabled = False
            '            Me.ToolBar1.Buttons(0).Text = "Nuevo" ' cambio los iconos
            '            Me.ToolBar1.Buttons(0).ImageIndex = 0
            '            REST2 = MsgBox("La actualización del sistema se ejecutó con éxito" & vbCrLf & "¿ Desea que se imprima el recibo de Devolución?", MsgBoxStyle.YesNo, "Seepos")
            '            If REST2 = 6 Then
            '                imprimir(NumDevo)
            '            End If
            '        End If
            '    Catch ex As Exception
            '        MsgBox(ex.ToString)
            '    End Try
            'End If
            ''        Else
            ''        MsgBox("Es necesario que almenos exista un item en el area de detalle para efctuar el registro de la devolución")
            ''       End If


        End Function

    End Class
End Namespace

