Namespace Logica
    Public Class Perfil_x_Modulo

        Private db As Datos.Class.Perfil_x_Modulo

        Sub New()
            Me.db = New Datos.Class.Perfil_x_Modulo
        End Sub

        Public Function Crear(perfilxmodulo As Datos.Models.PerfilXModulo) As String
            Return Me.db.Crear(perfilxmodulo)
        End Function

        Public Function Editar(id As Integer, perfilxmodulo As Datos.Models.PerfilXModulo) As String
            Dim res As String = Me.db.Editar(id, perfilxmodulo)
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