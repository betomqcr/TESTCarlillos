Namespace Logica
    Public Class ordencompra

        Private db As Datos.Class.OrdenCompra

        Sub New()
            Me.db = New Datos.Class.OrdenCompra
        End Sub

        Public Function Buscar(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.Ordencompra)
            Dim datos As New List(Of Datos.Models.Ordencompra)
            datos = Me.db.Buscar(porNombre, Filtro)

            Dim Resultado As New List(Of Datos.Models.Ordencompra)
            For Each ord As Datos.Models.Ordencompra In datos
                Dim OrdenCompra As New Datos.Models.Ordencompra
                OrdenCompra.Orden = ord.Orden
                OrdenCompra.Proveedor = ord.Proveedor
                OrdenCompra.Nombre = ord.Nombre
                OrdenCompra.Fecha = ord.Fecha
                OrdenCompra.Contado = ord.Contado
                OrdenCompra.Credito = ord.Credito
                OrdenCompra.Diascredito = ord.Diascredito
                OrdenCompra.Plazo = ord.Plazo
                OrdenCompra.Descuento = ord.Descuento
                OrdenCompra.Impuesto = ord.Impuesto
                OrdenCompra.Total = ord.Total
                OrdenCompra.Observaciones = ord.Observaciones
                OrdenCompra.Usuario = ord.Usuario
                OrdenCompra.NombreUsuario = ord.NombreUsuario
                OrdenCompra.Entregar = ord.Entregar
                OrdenCompra.CodMoneda = ord.CodMoneda
                OrdenCompra.SubTotalGravado = ord.SubTotalGravado
                OrdenCompra.SubTotalExento = ord.SubTotalExento
                OrdenCompra.SubTotal = ord.SubTotal
                OrdenCompra.Anulado = ord.Anulado
                OrdenCompra.IdSucursal = ord.IdSucursal

                For Each det As Datos.Models.DetalleOrdencompra In Me.db.BuscarDetalle(OrdenCompra.Orden)
                    Dim Detalle As New Datos.Models.DetalleOrdencompra
                    Detalle.Id = det.Id
                    Detalle.Orden = det.Orden
                    Detalle.Codigo = det.Codigo
                    Detalle.Descripcion = det.Descripcion
                    Detalle.CostoUnitario = det.CostoUnitario
                    Detalle.Cantidad = det.Cantidad
                    Detalle.TotalCompra = det.TotalCompra
                    Detalle.PorcDescuento = det.PorcDescuento
                    Detalle.Descuento = det.Descuento
                    Detalle.PorcImpuesto = det.PorcImpuesto
                    Detalle.Impuesto = det.Impuesto
                    Detalle.OtrosCargos = det.OtrosCargos
                    Detalle.MontoFlete = det.MontoFlete
                    Detalle.Costo = det.Costo
                    Detalle.Gravado = det.Gravado
                    Detalle.Exento = det.Exento
                    Detalle.Vendidos = det.Vendidos
                    Detalle.ExistActual = det.ExistActual

                    OrdenCompra.DetalleOrdencompras.Add(Detalle)
                Next

                Resultado.Add(OrdenCompra)
            Next

            Return Resultado
        End Function

        Public Function Crear(ordencompra As Datos.Models.Ordencompra) As String
            Return Me.db.Crear(ordencompra)

            'Function RegistrarOrden() As Boolean

            '    If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
            '    Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
            '    Try

            '        Me.Adapter_Orden_Compra.InsertCommand.Transaction = Trans
            '        Me.Adapter_Detalle_Orden_Compras.InsertCommand.Transaction = Trans

            '        Me.Adapter_Orden_Compra.UpdateCommand.Transaction = Trans
            '        Me.Adapter_Detalle_Orden_Compras.UpdateCommand.Transaction = Trans

            '        Me.Adapter_Orden_Compra.DeleteCommand.Transaction = Trans
            '        Me.Adapter_Detalle_Orden_Compras.DeleteCommand.Transaction = Trans

            '        Me.Adapter_Orden_Compra.Update(Me.DataSetOrden_Compras1, "ordencompra")
            '        Me.Adapter_Detalle_Orden_Compras.Update(Me.DataSetOrden_Compras1, "detalle_ordencompra")
            '        Trans.Commit()
            '        Return True

            '    Catch ex As Exception
            '        Trans.Rollback()
            '        MsgBox(ex.Message)
            '        Me.ToolBar1.Buttons(2).Enabled = True
            '        Return False
            '    End Try


            'End Function

        End Function

        Public Function Editar(id As Long, ordencompra As Datos.Models.Ordencompra) As String
            Dim res As String = Me.db.Editar(id, ordencompra)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
            'Function RegistrarOrden() As Boolean

            '    If Me.SqlConnection1.State <> Me.SqlConnection1.State.Open Then Me.SqlConnection1.Open()
            '    Dim Trans As SqlTransaction = Me.SqlConnection1.BeginTransaction
            '    Try

            '        Me.Adapter_Orden_Compra.InsertCommand.Transaction = Trans
            '        Me.Adapter_Detalle_Orden_Compras.InsertCommand.Transaction = Trans

            '        Me.Adapter_Orden_Compra.UpdateCommand.Transaction = Trans
            '        Me.Adapter_Detalle_Orden_Compras.UpdateCommand.Transaction = Trans

            '        Me.Adapter_Orden_Compra.DeleteCommand.Transaction = Trans
            '        Me.Adapter_Detalle_Orden_Compras.DeleteCommand.Transaction = Trans

            '        Me.Adapter_Orden_Compra.Update(Me.DataSetOrden_Compras1, "ordencompra")
            '        Me.Adapter_Detalle_Orden_Compras.Update(Me.DataSetOrden_Compras1, "detalle_ordencompra")
            '        Trans.Commit()
            '        Return True

            '    Catch ex As Exception
            '        Trans.Rollback()
            '        MsgBox(ex.Message)
            '        Me.ToolBar1.Buttons(2).Enabled = True
            '        Return False
            '    End Try


            'End Function

        End Function

        Public Function Anular(id As Long) As String
            Dim resp As String = Me.db.Anular(id)
            If resp = "0" Then
                Return "No existe el valor"
            Else
                Return resp
            End If
            'Function AnularOrden()
            '    Try
            '        Dim resp As Integer
            '        If Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").Count > 0 Then
            '            If Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra.ordencompradetalle_ordencompra").Count > 0 Then

            '                resp = MessageBox.Show("¿Desea Anular esta Orden de Compra...?", "Seepos", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1)
            '                If resp = 6 Then
            '                    CheckBox1.Checked = True
            '                    Me.BindingContext(Me.DataSetOrden_Compras1, "ordencompra").EndCurrentEdit()

            '                    Me.DataSetOrden_Compras1.AcceptChanges()
            '                    MsgBox("La Orden de Compra ha sido anulada correctamente", MsgBoxStyle.Information)
            '                    Me.DataSetOrden_Compras1.detalle_ordencompra.Clear()
            '                    Me.DataSetOrden_Compras1.ordencompra.Clear()

            '                    Me.ToolBar1.Buttons(4).Enabled = True
            '                    Me.ToolBar1.Buttons(1).Enabled = True

            '                    Me.ToolBar1.Buttons(0).Text = "Nuevo"
            '                    Me.ToolBar1.Buttons(0).ImageIndex = 0
            '                    Me.ToolBar1.Buttons(3).Enabled = False
            '                    Me.ToolBar1.Buttons(2).Enabled = False
            '                    Me.ToolBar1.Buttons(4).Enabled = False


            '                    Me.txtUsuario.Enabled = True
            '                    Me.txtUsuario.Text = ""
            '                    Me.txtNombreUsuario.Text = ""
            '                    Me.txtUsuario.Focus()
            '                Else : Exit Function

            '                End If
            '            End If
            '        End If

            '    Catch ex As System.Exception
            '        MsgBox(ex.Message)
            '    End Try
            'End Function

        End Function

    End Class
End Namespace