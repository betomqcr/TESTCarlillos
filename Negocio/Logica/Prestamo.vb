Namespace Logica
    Public Class Prestamo

        Private db As Datos.Class.Prestamo

        Sub New()
            Me.db = New Datos.Class.Prestamo
        End Sub

        Public Function Buscar(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.Prestamo)
            Dim datos As New List(Of Datos.Models.Prestamo)
            datos = db.Buscar(porNombre, Filtro)

            Dim Resultado As New List(Of Datos.Models.Prestamo)
            For Each pres As Datos.Models.Prestamo In datos
                Dim prestamo As New Datos.Models.Prestamo
                prestamo.Id = pres.Id
                prestamo.Fecha = pres.Fecha
                prestamo.Estado = pres.Estado
                prestamo.Anulado = pres.Anulado
                prestamo.Entrada = pres.Entrada
                prestamo.Salida = pres.Salida
                prestamo.Observacion = pres.Observacion
                prestamo.NombreDestino = pres.NombreDestino
                prestamo.Boleta = pres.Boleta
                prestamo.Destinatario = pres.Destinatario
                prestamo.NombreDestinatario = pres.NombreDestinatario
                prestamo.Destino = pres.Destino
                prestamo.Transportista = pres.Transportista
                prestamo.IdUsuariCreo = pres.IdUsuariCreo
                prestamo.BoletaProveedor = pres.BoletaProveedor

                For Each detalle As Datos.Models.DetallePrestamo In Me.db.BuscarDetalle(prestamo.Id)
                    Dim prestamoDetalle As New Datos.Models.DetallePrestamo
                    prestamoDetalle.Id = detalle.Id
                    prestamoDetalle.IdPrestamo = detalle.IdPrestamo
                    prestamoDetalle.Codigo = detalle.Codigo
                    prestamoDetalle.Descripcion = detalle.Descripcion
                    prestamoDetalle.Cantidad = detalle.Cantidad
                    prestamoDetalle.Precio = detalle.Precio
                    prestamoDetalle.Entregado = detalle.Entregado
                    prestamoDetalle.Devuelto = detalle.Devuelto

                    prestamo.DetallePrestamos.Add(prestamoDetalle)
                Next

                Resultado.Add(prestamo)
            Next

            Return Resultado
        End Function

        Public Function Crear(prestamo As Datos.Models.Prestamo) As String
            Return Me.db.Crear(prestamo)
            'Public Function insertar(ByVal dts As vprestamo, _IdUsuarioCreo As String, _BoletaProveedor As String, Optional ByVal _SPrestamo As Boolean = True) As Boolean
            '    Try
            '        conectado()
            '        If _SPrestamo = True Then
            '            cmd = New SqlCommand("Insertar_SPrestamo")
            '        Else
            '            cmd = New SqlCommand("Insertar_Prestamo")
            '        End If
            '        cmd.CommandType = CommandType.StoredProcedure
            '        cmd.Connection = cnn
            '        'cmd.Parameters.AddWithValue("@id", dts.gid)
            '        cmd.Parameters.AddWithValue("@boleta", dts.gboleta)
            '        cmd.Parameters.AddWithValue("@destinatario", dts.gdestinatario)
            '        cmd.Parameters.AddWithValue("@nombre_destinatario", dts.gnombre_destinatario)
            '        cmd.Parameters.AddWithValue("@destino", dts.gdestino)
            '        cmd.Parameters.AddWithValue("@nombre_destino", dts.gnombre_destino)
            '        cmd.Parameters.AddWithValue("@transportista", dts.gtransportista)
            '        cmd.Parameters.AddWithValue("@fecha", dts.gfecha)
            '        cmd.Parameters.AddWithValue("@estado", dts.gestado)
            '        cmd.Parameters.AddWithValue("@anulado", dts.ganulado)
            '        cmd.Parameters.AddWithValue("@entrada", dts.gentrada)
            '        cmd.Parameters.AddWithValue("@salida", dts.gsalida)
            '        cmd.Parameters.AddWithValue("@observacion", dts.gobservacion)
            '        cmd.Parameters.AddWithValue("@Id_UsuariCreo", _IdUsuarioCreo)
            '        cmd.Parameters.AddWithValue("@BoletaProveedor", _BoletaProveedor)
            '        If cmd.ExecuteNonQuery Then
            '            Return True
            '        Else
            '            Return False
            '        End If

            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '        Return False
            '    Finally
            '        desconectado()
            '    End Try
            'End Function

        End Function

        Public Function Editar(id As Long, prestamo As Datos.Models.Prestamo) As String
            Dim res As String = Me.db.Editar(id, prestamo)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
            'Public Function editar(ByVal dts As vprestamo, _IdUsuarioCreo As String, _BoletaProveedor As String, Optional ByVal _SPrestamo As Boolean = True) As Boolean
            '    Try
            '        conectado()

            '        If _SPrestamo = True Then
            '            cmd = New SqlCommand("Modificar_SPrestamo")
            '        Else
            '            cmd = New SqlCommand("Modificar_Prestamo")
            '        End If

            '        cmd.CommandType = CommandType.StoredProcedure
            '        cmd.Connection = cnn
            '        cmd.Parameters.AddWithValue("@boleta", dts.gboleta)
            '        cmd.Parameters.AddWithValue("@destinatario", dts.gdestinatario)
            '        cmd.Parameters.AddWithValue("@nombre_destinatario", dts.gnombre_destinatario)
            '        cmd.Parameters.AddWithValue("@destino", dts.gdestino)
            '        cmd.Parameters.AddWithValue("@nombre_destino", dts.gnombre_destino)
            '        cmd.Parameters.AddWithValue("@transportista", dts.gtransportista)
            '        cmd.Parameters.AddWithValue("@fecha", dts.gfecha)
            '        cmd.Parameters.AddWithValue("@estado", dts.gestado)
            '        cmd.Parameters.AddWithValue("@anulado", dts.ganulado)
            '        cmd.Parameters.AddWithValue("@entrada", dts.gentrada)
            '        cmd.Parameters.AddWithValue("@salida", dts.gsalida)
            '        cmd.Parameters.AddWithValue("@observacion", dts.gobservacion)
            '        cmd.Parameters.AddWithValue("@Id_UsuariCreo", _IdUsuarioCreo)
            '        cmd.Parameters.AddWithValue("@BoletaProveedor", _BoletaProveedor)
            '        If cmd.ExecuteNonQuery Then
            '            Return True
            '        Else
            '            Return False
            '        End If
            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '        Return False
            '    Finally
            '        desconectado()
            '    End Try
            'End Function

        End Function

        Public Function Eliminar(id As Long) As String
            Dim res As String = Me.db.Borrar(id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
            'Public Function eliminar(ByVal dts As vprestamo, Optional ByVal _SPrestamo As Boolean = True) As Boolean
            '    Try
            '        conectado()

            '        If _SPrestamo = True Then
            '            cmd = New SqlCommand("Eliminar_SPrestamo")
            '        Else
            '            cmd = New SqlCommand("Eliminar_Prestamo")
            '        End If

            '        cmd.CommandType = CommandType.StoredProcedure
            '        cmd.Connection = cnn
            '        cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = dts.gid
            '        If cmd.ExecuteNonQuery Then
            '            Return True
            '        Else
            '            Return False
            '        End If

            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '        Return False
            '    Finally
            '        desconectado()
            '    End Try

            'End Function

        End Function

        Public Sub Entregado()

            'Public Function entregado(ByVal dts As vprestamo) As Boolean
            '    Try
            '        conectado()
            '        cmd = New SqlCommand("entregado_prestamo")
            '        cmd.CommandType = CommandType.StoredProcedure
            '        cmd.Connection = cnn
            '        cmd.Parameters.Add("@id", SqlDbType.NVarChar, 50).Value = dts.gid
            '        If cmd.ExecuteNonQuery Then
            '            Return True
            '        Else
            '            Return False
            '        End If
            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '        Return False
            '    Finally
            '        desconectado()
            '    End Try

            'End Function

        End Sub

    End Class
End Namespace