Namespace Logica
    Public Class Presentaciones


        Private db As Datos.Class.Presentaciones

        Sub New()
            Me.db = New Datos.Class.Presentaciones
        End Sub

        Public Function Buscar(porDescripcion As Boolean, Filtro As String) As List(Of Datos.Models.Presentacione)
            Return Me.db.Buscar(porDescripcion, Filtro)
        End Function

        Public Function Crear(presentacion As Datos.Models.Presentacione) As String
            Return Me.db.Crear(presentacion)
        End Function

        Public Function Editar(id As Integer, presentacion As Datos.Models.Presentacione) As String
            Dim res As String = Me.db.Editar(id, presentacion)
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
