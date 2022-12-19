Namespace Logica
    Public Class AjustesInventario

        Private db As Datos.Class.AjustesInventarios
        'Private ad As Datos.Class.AjustesInventariosDetalles

        Sub New()
            Me.db = New Datos.Class.AjustesInventarios
            'Me.ad = New Datos.Class.AjustesInventariosDetalles
        End Sub

        Public Function Buscar(porId As Boolean, filtro As String) As List(Of Datos.Models.AjusteInventario)
            Dim datos As New List(Of Datos.Models.AjusteInventario)
            datos = db.ObtenerAjusteInventario(porId, filtro)

            Dim Resultado As New List(Of Datos.Models.AjusteInventario)
            For Each ajuste As Datos.Models.AjusteInventario In datos
                Dim AjusteInventario As New Datos.Models.AjusteInventario
                AjusteInventario.Consecutivo = ajuste.Consecutivo
                AjusteInventario.Fecha = ajuste.Fecha
                AjusteInventario.Anula = ajuste.Anula
                AjusteInventario.Cedula = ajuste.Cedula
                AjusteInventario.TotalEntrada = ajuste.TotalEntrada
                AjusteInventario.TotalSalida = ajuste.TotalSalida
                AjusteInventario.SaldoAjuste = ajuste.SaldoAjuste
                AjusteInventario.Asiento = ajuste.Asiento
                AjusteInventario.Contabilizado = ajuste.Contabilizado
                AjusteInventario.IdSucursal = ajuste.IdSucursal

                For Each detalle As Datos.Models.AjusteInventarioDetalle In Me.db.ObtenerDetalleAjustesInventario(AjusteInventario.Consecutivo)
                    Dim AjusteInventarioDetalle As New Datos.Models.AjusteInventarioDetalle
                    AjusteInventarioDetalle.Consecutivo = detalle.Consecutivo
                    AjusteInventarioDetalle.ConsAjuste = detalle.ConsAjuste
                    AjusteInventarioDetalle.CodArticulo = detalle.CodArticulo
                    AjusteInventarioDetalle.CodArticulo = detalle.CodArticulo
                    AjusteInventarioDetalle.DescArticulo = detalle.DescArticulo
                    AjusteInventarioDetalle.Cantidad = detalle.Cantidad
                    AjusteInventarioDetalle.Entrada = detalle.Entrada
                    AjusteInventarioDetalle.Salida = detalle.Salida
                    AjusteInventarioDetalle.Observacion = detalle.Observacion
                    AjusteInventarioDetalle.CuentaContable = detalle.CuentaContable
                    AjusteInventarioDetalle.TotalEntrada = detalle.TotalEntrada
                    AjusteInventarioDetalle.TotalSalida = detalle.TotalSalida
                    AjusteInventarioDetalle.Existencia = detalle.Existencia
                    AjusteInventarioDetalle.CostoUnit = detalle.CostoUnit
                    AjusteInventarioDetalle.CuentaContable = detalle.CuentaContable
                    AjusteInventarioDetalle.Descripcioncuentacontable = detalle.Descripcioncuentacontable
                    AjusteInventarioDetalle.Numero = detalle.Numero
                    AjusteInventarioDetalle.Gasto = detalle.Gasto
                    AjusteInventarioDetalle.Muerte = detalle.Muerte
                    AjusteInventarioDetalle.Actualizado = detalle.Actualizado

                    AjusteInventario.AjusteInventarioDetalles.Add(AjusteInventarioDetalle)
                Next

                Resultado.Add(AjusteInventario)
            Next

            Return Resultado
        End Function

        Public Function Anular(Id As Integer) As String
            Dim res As String = Me.db.AnularAjusteInventario(Id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
            'registra en vitacora
            'Function insertar_bitacora() As Boolean
            '    Dim funciones As New Conexion
            '    Dim datos As String
            '    datos = "'AJUSTE INVENTARIO','" & Me.txtNumero.Text & "','AJUSTE INVENTARIO','AJUSTE INVENATARIO ANULADO','" & usua.Nombre & "'," & 0 & "," & 0 & "," & 0 & "," & 0 & "," & 0
            '    If funciones.AddNewRecord("Bitacora", "Tabla,Campo_Clave,DescripcionCampo,Accion,Usuario,Costo,VentaA,VentaB,VentaC,VentaD", datos) <> "" Then
            '        MsgBox("Problemas al Anular el ajuste", MsgBoxStyle.Critical)
            '        Return False
            '    Else
            '        Return True
            '    End If
            'End Function


            '    Function Registrar_Anulacion_Ajuste() As Boolean

            '    If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
            '    Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
            '    Try

            '        Me.adAjusteInv.UpdateCommand.Transaction = Trans


            '        Me.adAjusteInv.Update(Me.DsAjusteInv2, "AjusteInventario")

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
        Public Function Crear(ajuste As Datos.Models.AjusteInventario) As String
            Try
                Me.db.CrearAjustesInventarios(ajuste)

                Return "1"
            Catch ex As Exception
                Return ex.Message
            End Try

            'validacion
            'If Ceros() Then
            'Else
            '    MsgBox("Ajustes en cero no se pueden almacenar!!")
            '    Exit Function
            'End If


            'registra en bitacora
            'Public Sub insertar_PermisoAjuste(ByVal ced As String, ByVal fecha As Date, ByVal descrip As String, ByVal id_Mov As Integer, ByVal _CedAdmin As String)
            '    Dim sentencia = "INSERT INTO registro_Permisoajuste (cedula_usuario, fecha, descripcion,id_Movimiento,Administrador)VALUES('" & ced & "','" & fecha & "','" & descrip & "'," & id_Mov & ",'" & _CedAdmin & "')"
            '    Dim SQL As New GestioDatos
            '    SQL.Ejecuta(sentencia)
            'End Sub


            'Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
            'Try
            '    Me.adAjusteInv.InsertCommand.Transaction = Trans
            '    Me.adAjusteInv.DeleteCommand.Transaction = Trans
            '    Me.adAjusteInv.UpdateCommand.Transaction = Trans
            '    Me.adAjusteInv.SelectCommand.Transaction = Trans

            '    Me.adAjusteInvDetalle.InsertCommand.Transaction = Trans
            '    Me.adAjusteInvDetalle.DeleteCommand.Transaction = Trans
            '    Me.adAjusteInvDetalle.UpdateCommand.Transaction = Trans
            '    Me.adAjusteInvDetalle.SelectCommand.Transaction = Trans

            '    Dim Cx As New Conexion
            '    Dim cantidad As Integer
            '    Dim codigo As Integer
            '    Dim MAxActual As Integer
            '    Dim rs As SqlDataReader
            '    If op_Entrada.Checked = True Then
            '        'se guarda la cantidad maxima ajustada , esta cantidad es el tope para las devoluciones
            '        For cont As Integer = 0 To BindingContext(Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").Count - 1

            '            cantidad = DsAjusteInv2.AjusteInventario_Detalle.Item(cont).Cantidad
            '            codigo = DsAjusteInv2.AjusteInventario_Detalle.Item(cont).Cod_Articulo()
            '            rs = Cx.GetRecorset(Cx.Conectar, "SELECT MAX_Inventario FROM Inventario WHERE Codigo='" & codigo & "'")
            '            If rs.Read Then
            '                MAxActual = rs("MAX_Inventario")
            '            End If
            '            rs.Close()
            '            Cx.UpdateRecords("Inventario", "MAX_Inventario=" & MAxActual + CInt(cantidad), "Codigo='" & CInt(codigo) & "'")
            '        Next

            '    ElseIf op_Salida.Checked = True Then
            '        'se guarda la cantidad maxima ajustada , esta cantidad es el tope para las devoluciones
            '        For cont As Integer = 0 To BindingContext(Me.DsAjusteInv2, "AjusteInventario.AjusteInventarioAjusteInventario_Detalle").Count - 1

            '            cantidad = DsAjusteInv2.AjusteInventario_Detalle.Item(cont).Cantidad
            '            codigo = DsAjusteInv2.AjusteInventario_Detalle.Item(cont).Cod_Articulo()
            '            rs = Cx.GetRecorset(Cx.Conectar, "SELECT MAX_Inventario FROM Inventario WHERE Codigo='" & codigo & "'")
            '            If rs.Read Then
            '                MAxActual = rs("MAX_Inventario")
            '            End If
            '            rs.Close()
            '            Cx.UpdateRecords("Inventario", "MAX_Inventario=" & MAxActual - CInt(cantidad), "Codigo='" & CInt(codigo) & "'")
            '        Next
            '    End If


            '    Me.adAjusteInv.Update(Me.DsAjusteInv2, "AjusteInventario")
            '    Me.adAjusteInvDetalle.Update(Me.DsAjusteInv2, "AjusteInventario_Detalle")

            '    Trans.Commit()
            '    Return True


            'Catch ex As Exception
            '    Trans.Rollback()
            '    MsgBox(ex.Message, MsgBoxStyle.Information, "Atención...")
            '    Me.ToolBar1.Buttons(2).Enabled = True
            '    Return False
            'End Try

        End Function

    End Class

End Namespace
