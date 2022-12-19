Imports Negocio.Utilidades
Namespace Logica
    Public Class TomaProveedor

        Private db As Datos.Class.TomaProveedor

        Sub New()
            Me.db = New Datos.Class.TomaProveedor
        End Sub

        Public Function Buscar(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.TomaProveedor)
            Dim datos As New List(Of Datos.Models.TomaProveedor)
            datos = Me.db.Buscar(porNombre, Filtro)

            Dim Resultado As New List(Of Datos.Models.TomaProveedor)
            For Each toma As Datos.Models.TomaProveedor In datos
                Dim TomaProveedor As New Datos.Models.TomaProveedor
                TomaProveedor.Id = toma.Id
                TomaProveedor.IdUsuarioCreo = toma.IdUsuarioCreo
                TomaProveedor.CodigoProv = toma.CodigoProv
                TomaProveedor.Fecha = toma.Fecha
                TomaProveedor.Anulado = toma.Anulado
                TomaProveedor.Aplicado = toma.Aplicado

                For Each det As Datos.Models.TomaProveedorDetalle In Me.db.BuscarDetalle(TomaProveedor.Id)
                    Dim Detalle As New Datos.Models.TomaProveedorDetalle
                    Detalle.Id = det.Id
                    Detalle.IdTomaProveedor = det.IdTomaProveedor
                    Detalle.Codigo = det.Codigo
                    Detalle.CodArticulo = det.CodArticulo
                    Detalle.Descripicon = det.Descripicon
                    Detalle.Existencia = det.Existencia
                    Detalle.Toma = det.Toma
                    Detalle.Diferencia = det.Diferencia

                    TomaProveedor.TomaProveedorDetalles.Add(Detalle)
                Next

                Resultado.Add(TomaProveedor)
            Next

            Return Resultado
        End Function

        Public Function Crear(Toma As Datos.Models.TomaProveedor) As String
            Return Me.db.Crear(Toma)
        End Function

        Public Function Editar(id As Long, Toma As Datos.Models.TomaProveedor) As String
            Dim res As String = Me.db.Editar(id, Toma)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
        End Function

        Public Function Eliminar(id As Long) As String
            Dim res As String = Me.db.Borrar(id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
        End Function

    End Class
End Namespace

