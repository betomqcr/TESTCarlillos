Namespace Logica
    Public Class Marca

        Private db As Datos.Class.Marcas

        Sub New()
            Me.db = New Datos.Class.Marcas
        End Sub

        Public Function Buscar(porDescripcion As Boolean, Filtro As String) As List(Of Datos.Models.Marca)
            Return Me.db.Buscar(porDescripcion, Filtro)
        End Function

        Public Function Crear(bodega As Datos.Models.Marca) As String
            Return Me.db.Crear(bodega)
        End Function

        Public Function Editar(id As Integer, bodega As Datos.Models.Marca) As String
            Dim res As String = Me.db.Editar(id, bodega)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
        End Function

        Public Function Eliminar(id As Integer) As String
            Dim res As String = Me.db.Borrar(id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
        End Function

    End Class

End Namespace
