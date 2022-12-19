Namespace Logica
    Public Class Clientes_frecuentes

        Private db As Datos.Class.ClientesFrecuentes

        Sub New()
            Me.db = New Datos.Class.ClientesFrecuentes
        End Sub

        Public Function Buscar(porNombre As Boolean,
                                      filtro As String) As List(Of Datos.Models.ClientesFrecuente)
            Return Me.db.Buscar(porNombre, filtro)
        End Function

        Public Function Crear(cliente As Datos.Models.ClientesFrecuente) As String
            Return Me.db.Crear(cliente)
        End Function

        Public Function Editar(id As Long, cliente As Datos.Models.ClientesFrecuente) As String
            Dim res As String = Me.db.Editar(id, cliente)
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