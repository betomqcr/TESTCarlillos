Namespace Logica
    Public Class PedidoBodega

        Private db As Datos.Class.PedidoBodega

        Sub New()
            Me.db = New Datos.Class.PedidoBodega
        End Sub

        Public Function Crear(pedidobodega As Datos.Models.PedidoBodega) As String
            Return Me.db.Crear(pedidobodega)
            'Datos.Models.PedidoBodega
            'Datos.Models.PedidoBodega

            'Private db As OBSoluciones.SQL.Transaccion
            'Private Consecutivo As Integer
            'Private Sub Guardar()
            '    Me.db = New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
            '    Me.Consecutivo = 0
            '    Try

            '        For i As Integer = 0 To Me.viewDatos.Rows.Count - 1
            '            Me.InsertarPedidoBodega(Me.dtpFechaSolicitud.Value,
            '                                Me.IdUsuario,
            '                                Me.viewDatos.Item("cCodigo", i).Value,
            '                                Me.viewDatos.Item("cCantidad", i).Value,
            '                                Me.viewDatos.Item("cObservaciones", i).Value,
            '                                Me.viewDatos.Item("cPrecioUnid", i).Value)

            '        Next
            '        db.Commit()
            '        Me.Close()
            '    Catch ex As Exception
            '        db.Rollback()
            '        MsgBox(ex.Message)
            '    End Try
            'End Sub

            ''***************************************************************************
            ''***************************************************************************
            ''***************************************************************************

            'Private Sub InsertarPedidoBodega(_FechaSolicitud As Date, _IdUsuarioSolicitud As String, _Codigo As String, _CantidadSolicitud As Decimal, _Observaciones As String, _PrecioUnid As Decimal)
            '    db.SetParametro("@fechaSolicitud", _FechaSolicitud)
            '    db.SetParametro("@IdUsuarioSolicitud", _IdUsuarioSolicitud)
            '    db.SetParametro("@Codigo", _Codigo)
            '    db.SetParametro("@CantidadSolicitud", _CantidadSolicitud)
            '    db.AddParametrosSalidaInt("@Consecutivo", Me.Consecutivo)
            '    db.SetParametro("@Observaciones", _Observaciones)
            '    db.SetParametro("@PrecioUnid", _PrecioUnid)
            '    db.SetParametro("@CantidadPuntos", 1)
            '    db.Ejecutar("Insertar_PedidoBodega", Me.Consecutivo, 4)
            'End Sub

        End Function

        Public Function Buscar(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.PedidoBodega)
            Return Me.db.Buscar(porNombre, Filtro)
            'Private Sub ConsultaBodega()

            '    If Me.ckFiltrarxEstado.Checked = True Then

            '        If Me.ckSolicitado.Checked = False And Me.ckPedido.Checked = False And Me.ckRecibido.Checked = False And Me.ckAnulado.Checked = False And Me.ckAgotado.Checked = False Then

            '            MsgBox("Para filtrar por estado debe marcar almenos un estado", MsgBoxStyle.Exclamation, "No se puedo procesar la operacion")
            '            Exit Sub

            '        End If

            '    End If

            '    If Me.ckFiltrarxFecha.Checked = True Then

            '        If Me.dtpHasta.Value < Me.dtpDesde.Value Then

            '            MsgBox("El rango de fechas a filtrar es invalido", MsgBoxStyle.Exclamation, "No se puedo procesar la operacion")
            '            Exit Sub

            '        End If

            '    End If

            '    Dim strConsulta As String = "Select * from viewPedidosBodega"
            '    Dim strFiltro As String = ""

            '    If Me.ckFiltrarxFecha.Checked = True And Me.ckFiltrarxEstado.Checked = True Then
            '        strFiltro = " Where Estado In(" & Me.getEstados & ") And dbo.dateonly(FechaSolicitud) >= dbo.dateonly('" & Me.dtpDesde.Value.ToShortDateString & "') and dbo.dateonly(FechaSolicitud) <= dbo.dateonly('" & Me.dtpHasta.Value.ToShortDateString & "')"
            '    End If

            '    If Me.ckFiltrarxFecha.Checked = True And Me.ckFiltrarxEstado.Checked = False Then
            '        strFiltro = " Where dbo.dateonly(FechaSolicitud) >= dbo.dateonly('" & Me.dtpDesde.Value.ToShortDateString & "') and dbo.dateonly(FechaSolicitud) <= dbo.dateonly('" & Me.dtpHasta.Value.ToShortDateString & "')"
            '    End If

            '    If Me.ckFiltrarxFecha.Checked = False And Me.ckFiltrarxEstado.Checked = True Then
            '        strFiltro = " Where Estado In(" & Me.getEstados & ")"
            '    End If

            '    If Me.ckFiltrarxFecha.Checked = False And Me.ckFiltrarxEstado.Checked = False Then
            '        strFiltro = ""
            '    End If

            '    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            '    Dim dt As New DataTable
            '    dt = db.Ejecutar(strConsulta & strFiltro & " Order by CasaComercial", CommandType.Text)
            '    Me.viewDatos.DataSource = dt
            '    Me.viewDatos.Columns("IdPedido").Visible = False

            '    Me.pone_color("PEDIDO", Drawing.Color.Yellow)
            '    Me.pone_color("RECIBIDO", Drawing.Color.LightGreen)
            '    Me.pone_color("AGOTADO", Drawing.Color.LightSalmon)

            'End Sub

        End Function

        Public Sub cambiarEstado(IdPedido As Integer, estado As String, idUsuario As String, cantidadPedida As Decimal, codigoProv As Integer)

            Select Case estado
                Case "PEDIDO"
                    '     Private Sub btnPedido_Click(sender As Object, e As EventArgs) Handles btnPedido.Click
                    '    Try
                    '        Dim Id As String = Me.viewDatos.Item("IdPedido", Me.viewDatos.CurrentRow.Index).Value
                    '        Dim frm As New frmRegistrarPedido
                    '        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    '            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                    '            db.Ejecutar("Update PedidoBodega  Set FechaPedido = getdate(), Estado = 'PEDIDO', IdUsuarioPidio = '" & Me.IdUsuario & "', CantidadPedido = " & frm.txtCantidad.Value & ", Proveedor = " & frm.CodigoProv & " Where IdPedido = " & Id, CommandType.Text)
                    '            Me.ConsultaBodega()
                    '        End If
                    '    Catch ex As Exception
                    '        Me.ConsultaBodega()
                    '    End Try
                    'End Sub
                Case "RECIBIDO"
                    'Private Sub btnRecibido_Click(sender As Object, e As EventArgs) Handles btnRecibido.Click
                    '    Try
                    '        Dim Id As String = Me.viewDatos.Item("IdPedido", Me.viewDatos.CurrentRow.Index).Value
                    '        Dim frm As New frmMarcarEstado
                    '        frm.lblEstado.Text = "Cambiar Estado a Recibido"
                    '        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    '            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                    '            db.Ejecutar("Update PedidoBodega  Set Estado = 'RECIBIDO', FechaRecibido = GetDate(), IdUsuarioRecibio = '" & Me.IdUsuario & "' Where IdPedido = " & Id, CommandType.Text)
                    '            Me.ConsultaBodega()
                    '        End If
                    '    Catch ex As Exception
                    '        Me.ConsultaBodega()
                    '    End Try
                    'End Sub
                Case "ANULADO"
                    'Private Sub btnAnulado_Click(sender As Object, e As EventArgs) Handles btnAnulado.Click
                    '    Try
                    '        Dim Id As String = Me.viewDatos.Item("IdPedido", Me.viewDatos.CurrentRow.Index).Value
                    '        Dim frm As New frmMarcarEstado
                    '        frm.lblEstado.Text = "Cambiar Estado a Anulado"
                    '        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    '            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                    '            db.Ejecutar("Update PedidoBodega  Set Estado = 'ANULADO' Where IdPedido = " & Id, CommandType.Text)
                    '            Me.ConsultaBodega()
                    '        End If
                    '    Catch ex As Exception
                    '        Me.ConsultaBodega()
                    '    End Try
                    'End Sub
                Case "AGOTADO"
                    'Private Sub btnAgotado_Click(sender As Object, e As EventArgs) Handles btnAgotado.Click
                    '    Try
                    '        Dim Id As String = Me.viewDatos.Item("IdPedido", Me.viewDatos.CurrentRow.Index).Value
                    '        Dim frm As New frmMarcarEstado
                    '        frm.lblEstado.Text = "Cambiar Estado a Agotado"
                    '        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    '            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                    '            db.Ejecutar("Update PedidoBodega  Set Estado = 'AGOTADO' Where IdPedido = " & Id, CommandType.Text)
                    '            Me.ConsultaBodega()
                    '        End If
                    '    Catch ex As Exception
                    '        Me.ConsultaBodega()
                    '    End Try
                    'End Sub
            End Select

        End Sub



    End Class
End Namespace