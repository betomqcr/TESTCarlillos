Namespace Logica
    Public Class Perfil
        Private db As Datos.Class.Perfil

        Sub New()
            Me.db = New Datos.Class.Perfil
        End Sub

        Public Function Buscar(porNombre As Boolean, filtro As String) As List(Of Datos.Models.Perfil)
            Return Me.db.Buscar(porNombre, filtro)
        End Function

        Public Function Crear(pefil As Datos.Models.Perfil) As String
            Return Me.db.Crear(pefil)
        End Function

        Public Function Editar(id As Integer, perfil As Datos.Models.Perfil) As String
            Dim res As String = Me.db.Editar(id, perfil)
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


