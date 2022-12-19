Namespace Logica
    Public Class MovimientosBodega

        Private db As Datos.Class.MovimientosBodega

        Sub New()
            Me.db = New Datos.Class.MovimientosBodega
        End Sub

        Public Function Buscar(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.MovimientosBodega)
            Dim datos As New List(Of Datos.Models.MovimientosBodega)
            datos = db.Buscar(porNombre, Filtro)

            Dim Resultado As New List(Of Datos.Models.MovimientosBodega)
            For Each mov As Datos.Models.MovimientosBodega In datos
                Dim movimientos As New Datos.Models.MovimientosBodega
                movimientos.BoletaMovimiento = mov.BoletaMovimiento
                movimientos.Bodega = mov.Bodega
                movimientos.Fecha = mov.Fecha
                movimientos.FechaEntrada = mov.FechaEntrada
                movimientos.Referencia = mov.Referencia
                movimientos.Usuario = mov.Usuario
                movimientos.Anulado = mov.Anulado
                movimientos.Cliente = mov.Cliente

                For Each detalle As Datos.Models.MovimientosBodegaDetalle In Me.db.BuscarDetalle(movimientos.BoletaMovimiento)
                    Dim movimientoDetalle As New Datos.Models.MovimientosBodegaDetalle
                    movimientoDetalle.IdDetalle = detalle.IdDetalle
                    movimientoDetalle.BoletaMovimiento = detalle.BoletaMovimiento
                    movimientoDetalle.Codigo = detalle.Codigo
                    movimientoDetalle.CodArticulo = detalle.CodArticulo
                    movimientoDetalle.Descripcion = detalle.Descripcion
                    movimientoDetalle.Cantidad = detalle.Cantidad
                    movimientoDetalle.TipoEntrada = detalle.TipoEntrada
                    movimientoDetalle.TipoSalida = detalle.TipoSalida
                    movimientoDetalle.Numero = detalle.Numero
                    movimientoDetalle.ExistenciaForzada = detalle.ExistenciaForzada
                    movimientoDetalle.ExistVeteForzada = detalle.ExistVeteForzada

                    movimientos.MovimientosBodegaDetalles.Add(movimientoDetalle)
                Next

                Resultado.Add(movimientos)
            Next

            Return Resultado
        End Function

        Public Function Crear(movimientobodega As Datos.Models.MovimientosBodega) As String
            Return Me.db.Crear(movimientobodega)
            'valida que no exista la referencia
            'Private Function ValidaReferencia(ByVal _CodBodega As Integer, ByVal _Referencia As String) As Boolean
            '    Dim SQL As New GestioDatos
            '    Dim Sentencia As String = "SELECT *  FROM MovimientosBodega WHERE Bodega = " & _CodBodega & " AND referencia = '" & _Referencia & "' and anulado = 0"
            '    Dim dtsReferencia As New DataTable
            '    dtsReferencia = SQL.Ejecuta(Sentencia)
            '    If dtsReferencia.Rows.Count > 0 Then
            '        MsgBox("La Referencia " & _Referencia & " ya existe para el Proveedor " & Me.ComboBoxBodegas.Text & ", por favor revise de nuevo!", MsgBoxStyle.OkOnly, "Atención la Referencia ya Existe")
            '        Return True
            '    Else
            '        Return False
            '    End If
            'End Function

            'Me.RegistrarDatos(Me.SqlDataAdapterMovimiento_Bodega, Me.DataSet_Movimiento_Bodega, Me.DataSet_Movimiento_Bodega.MovimientosBodega.ToString, True, False)
            'Me.RegistrarDatos(Me.SqlDataAdapter_MovimientDetalle, Me.DataSet_Movimiento_Bodega, Me.DataSet_Movimiento_Bodega.MovimientosBodega_Detalle.ToString, True)

            'If Me.ListaSerieEntrada.Count > 0 Then
            '    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '    For Each s As Serie In Me.ListaSerieEntrada
            '        db.Ejecutar("insert into Serie(codigo, serie, vendido, factura) values(" & s.Codigo & ",'" & s.Serie & "',0,0)", CommandType.Text)
            '    Next
            '    Me.ListaSerieEntrada.Clear()
            'End If

            'If Me.ListaSerieSalida.Count > 0 Then
            '    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '    For Each s As Serie In Me.ListaSerieSalida
            '        db.Ejecutar("delete from Serie where serie = '" & s.Serie & "' and codigo = " & s.Codigo, CommandType.Text)
            '    Next
            '    Me.ListaSerieSalida.Clear()
            'End If

            'actualiza el campo de existenca bodega
            'Sub registrar_existencias()

            '    Dim dts As New DataTable
            '    Dim codigo As String
            '    Dim bodega As String
            '    Dim funciones As New Conexion
            '    Dim exis_act As Double
            '    Dim Existenciabod As Double

            '    Dim dts_movimiento As New DataTable
            '    Try
            '        cFunciones.Llenar_Tabla_Generico("select * from MovimientosBodega_Detalle where boleta_movimiento = " & Me.TextBoxId.Text, dts_movimiento, CadenaConexionSeePOS)

            '        With dts_movimiento

            '            For i As Integer = 0 To .Rows.Count - 1
            '                codigo = .Rows(i).Item("codigo")

            '                cFunciones.Llenar_Tabla_Generico("select codigo,id_bodega,ExistenciaBodega,Existencia,dbo.ReporteBodega_SaldoInicial(GETDATE(),codigo,Id_Bodega)as exisbod  from Inventario where Consignacion = 1 and codigo = '" & codigo & "'", dts, CadenaConexionSeePOS)
            '                If dts.Rows.Count > 0 Then

            '                    'existencia actual en bodega
            '                    Existenciabod = dts.Rows(0).Item("exisbod")

            '                    'existencia en bodega inventario
            '                    exis_act = dts.Rows(0).Item("existenciabodega")

            '                    If Existenciabod <> exis_act Then
            '                        funciones.UpdateRecords("inventario", "existenciaBodega = " & Existenciabod, "codigo = " & codigo, "SeePos")
            '                    End If
            '                End If
            '            Next

            '        End With

            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '    End Try
            'End Sub


        End Function

        Public Function Anular(Id As Integer) As String
            Dim res As String = Me.db.Anular(Id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
            'Function insertar_bitacora() As Boolean
            '    Dim funciones As New Conexion
            '    Dim datos As String
            '    datos = "'AJUSTE BODEGA','" & Me.TextBoxId.Text & "','AJUSTE BODEGA','AJUSTE BODEGA ANULADO','" & Format(Now, "dd/MM/yyyy H:mm:ss") & "','" & Usua.Nombre & "'," & 0 & "," & 0 & "," & 0 & "," & 0 & "," & 0
            '    If funciones.AddNewRecord("Bitacora", "Tabla,Campo_Clave,DescripcionCampo,Accion, Fecha,Usuario,Costo,VentaA,VentaB,VentaC,VentaD", datos) <> "" Then
            '        MsgBox("Problemas al Anular el ajuste", MsgBoxStyle.Critical)
            '        Return False
            '    Else
            '        Return True
            '    End If
            'End Function

            'Function Registrar_Anulacion_Ajuste() As Boolean
            '    If Me.SqlConnection.State <> Me.SqlConnection.State.Open Then Me.SqlConnection.Open()
            '    Dim Trans As SqlTransaction = Me.SqlConnection.BeginTransaction
            '    Try

            '        Me.SqlDataAdapterMovimiento_Bodega.UpdateCommand.Transaction = Trans
            '        Me.SqlDataAdapterMovimiento_Bodega.Update(Me.DataSet_Movimiento_Bodega, "MovimientosBodega")

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
