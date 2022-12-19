Imports Negocio.Utilidades
Namespace Logica
    Public Class Ubicaciones

        Private db As Datos.Class.Ubicaciones

        Sub New()
            Me.db = New Datos.Class.Ubicaciones
        End Sub

        Public Function Buscar(pornombre As Boolean, filtro As String) As List(Of Datos.Models.Ubicacione)
            Dim datos As New List(Of Datos.Models.Ubicacione)
            datos = Me.db.Buscar(pornombre, filtro)

            Dim Resultado As New List(Of Datos.Models.Ubicacione)
            For Each ubi As Datos.Models.Ubicacione In datos
                Dim Ubicacion As New Datos.Models.Ubicacione
                Ubicacion.Codigo = ubi.Codigo
                Ubicacion.Descripcion = ubi.Descripcion
                Ubicacion.Observaciones = ubi.Observaciones
                Ubicacion.Activa = ubi.Activa

                For Each subUbi As Datos.Models.SubUbicacion In Me.db.BuscarDetalle(ubi.Codigo)
                    Dim SubUbicacion As New Datos.Models.SubUbicacion
                    SubUbicacion.CodUbicacion = subUbi.CodUbicacion
                    SubUbicacion.CodSubUbicacion = subUbi.CodSubUbicacion
                    SubUbicacion.Codigo = subUbi.Codigo
                    SubUbicacion.DescripcionD = subUbi.DescripcionD
                    SubUbicacion.Observaciones = subUbi.Observaciones
                    Ubicacion.SubUbicacions.Add(SubUbicacion)
                Next

                Resultado.Add(Ubicacion)
            Next

            Return Resultado
        End Function

        Public Function Crear(ubicacion As Datos.Models.Ubicacione) As String
            Return Me.db.Crear(ubicacion)
        End Function

        Public Function Editar(id As Decimal, ubicacion As Datos.Models.Ubicacione) As String
            Dim res As String = Me.db.Editar(id, ubicacion)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
        End Function

        Public Function Eliminar(id As Decimal) As String
            Dim res As String = Me.db.Borrar(id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
        End Function

    End Class

End Namespace
