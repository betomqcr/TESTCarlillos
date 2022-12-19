Namespace Logica
    Public Class Configuraciones
        Private db As New DatosFE.Class.Configuraciones


        Public Function Crear(conf As DatosFE.Models.Configuracione) As String
            Return Me.db.CrearConfiguracion(conf)
        End Function

        Public Function Borrar(id As Integer) As String
            Return Me.db.BorrarConfiguracion(id)
        End Function

        Public Function Obtener(cedula As String) As List(Of DatosFE.Models.Configuracione)
            Return Me.db.ObtenerConfiguraciones(cedula)
        End Function

    End Class
End Namespace