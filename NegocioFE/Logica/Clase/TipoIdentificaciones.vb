Namespace Logica
    Public Class TipoIdentificaciones
        Private db As New DatosFE.Class.IdentificacionTipos

        Public Function Obtener_TiposIdentificaciones() As List(Of DatosFE.Models.TiposIdentificacion)
            Return db.ObtenerTiposIdentificacion
        End Function
    End Class
End Namespace

