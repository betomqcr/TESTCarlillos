Namespace Logica
    Public Class PreTomaProveedor

        Private db As Datos.Class.PreTomaProveedor

        Sub New()
            Me.db = New Datos.Class.PreTomaProveedor
        End Sub

        Public Function Crear(pretoma As Datos.Models.PreTomaProveedor) As String
            Return Me.db.Crear(pretoma)
        End Function

        Public Function Editar(id As Decimal, pretoma As Datos.Models.PreTomaProveedor) As String
            Dim res As String = Me.db.Editar(id, pretoma)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
        End Function

        Public Function Buscar(porNombre As Boolean, Filtro As String) As List(Of Datos.Models.PreTomaProveedor)
            Dim datos As New List(Of Datos.Models.PreTomaProveedor)
            datos = db.Buscar(porNombre, Filtro)

            Dim Resultado As New List(Of Datos.Models.PreTomaProveedor)
            For Each toma As Datos.Models.PreTomaProveedor In datos
                Dim preToma As New Datos.Models.PreTomaProveedor
                preToma.Id = toma.Id
                preToma.IdUsuarioCreo = toma.IdUsuarioCreo
                preToma.CodigoProv = toma.CodigoProv
                preToma.Fecha = toma.Fecha
                preToma.Anulado = toma.Anulado
                preToma.Usado = toma.Usado

                For Each detalle As Datos.Models.PreTomaProveedorDetalle In Me.db.BuscarDetalle(preToma.Id)
                    Dim preTomaDetalle As New Datos.Models.PreTomaProveedorDetalle
                    preTomaDetalle.Id = detalle.Id
                    preTomaDetalle.IdPreTomaProveedor = detalle.IdPreTomaProveedor
                    preTomaDetalle.Codigo = detalle.Codigo
                    preTomaDetalle.CodArticulo = detalle.CodArticulo
                    preTomaDetalle.Descripicon = detalle.Descripicon
                    preTomaDetalle.Cantidad = detalle.Cantidad

                    preToma.PreTomaProveedorDetalles.Add(preTomaDetalle)
                Next

                Resultado.Add(preToma)
            Next

            Return Resultado
        End Function

    End Class
End Namespace

