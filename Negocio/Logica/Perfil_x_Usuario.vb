Namespace Logica
    Public Class Perfil_x_Usuario

        Private db As Datos.Class.Perfil_x_Usuario

        Sub New()
            Me.db = New Datos.Class.Perfil_x_Usuario
        End Sub

        Public Function ObtenerPerfil_x_Usuario() As List(Of Datos.Models.PerfilXUsuario)
            'revisar el criterio de busqueda en el codigo
            Return Me.db.Buscar(True, "")
            'Me.AdapterPerfilxUsuario.Fill(Me.DatasetUsuario1.Perfil_x_Usuario)
        End Function

        Public Function CrearPerfil_x_usuario(pefil_x_usuario As Datos.Models.PerfilXUsuario) As String
            Return Me.db.Crear(pefil_x_usuario)
        End Function

        Public Function EliminarPerfil_x_usuario(id As Long) As String
            Dim res As String = Me.db.Borrar(id)
            If res = "0" Then
                Return "No existe el valor"
            Else
                Return res
            End If
        End Function

    End Class
End Namespace